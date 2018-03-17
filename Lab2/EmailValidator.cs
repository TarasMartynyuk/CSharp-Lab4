using System.Text.RegularExpressions;

namespace Lab2
{
    static class EmailValidator
    {
        public static bool IsValidFormat(string email)
        {
            // courtesy of @Maheep
            const string pattern = @"^([0-9a-zA-Z]" + //Start with a digit or alphabetical
                                   @"([\+\-_\.][0-9a-zA-Z]+)*" + // No continuous or ending +-_. chars in email
                                   @")+" +
                                   @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";

            return Regex.IsMatch(email, pattern);
        }
    }
}
