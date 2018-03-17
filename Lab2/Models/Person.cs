using System;

namespace Lab2.Models
{
    class Person
    {
        #region Binding properties
        public string Name { get; }
        public string Surname { get; }
        public string Email { get; } = "N/A";
        public DateTime DateOfBirth { get; } = new DateTime(1970, 1, 1);

        public bool IsAdult => BirthDataUtils.CalculateAge(DateOfBirth) >= 18;
        public bool IsBirthday => BirthDataUtils.IsBirthday(DateOfBirth);
        public AstrologicalSign AstrologicalSign => GetAstrologicalSign(DateOfBirth);
        public ZodiacSign ZodiacSign => GetZodiacSign(DateOfBirth);
        #endregion

        #region ctors
        internal Person(string name, string surname, string email, DateTime dateOfBirth) : this(name, surname, email)
        {
            if(! BirthDataUtils.IsValidBirthDate(dateOfBirth))
            {
                throw new ArgumentOutOfRangeException(nameof(dateOfBirth));
            }
            DateOfBirth = dateOfBirth;
        }

        internal Person(string name, string surname, string email) : this(name, surname)
        {
            if(email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }
            if(! EmailValidator.IsValidFormat(email))
            {
                throw new ArgumentException("the email is badly fomatted");
            }
            Email = email;
        }

        internal Person(string name, string surname, DateTime dateOfBirth) : this(name, surname)
        {
            DateOfBirth = dateOfBirth;
        }

        internal Person(string name, string surname)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
        }
        #endregion

        private static AstrologicalSign GetAstrologicalSign(DateTime birthDate)
        {
            const int astrologicalYearStartMonth = 3;

            int monthOrdinalFromMarch =  birthDate.DayOfYear / 31 - astrologicalYearStartMonth;

            if(monthOrdinalFromMarch < 0)
            {
                monthOrdinalFromMarch += 12;
            }
            return (AstrologicalSign) monthOrdinalFromMarch;
        }

        private static ZodiacSign GetZodiacSign(DateTime birthDate)
        {
            // the first year when the cycle would start after 0th yearAD
            const int firstCycleStartAd = 4;
            int inCycleYear = (birthDate.Year - firstCycleStartAd) % 12;
            return (ZodiacSign) inCycleYear;
        }
    }
}
