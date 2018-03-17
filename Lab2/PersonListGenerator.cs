using System.Collections.ObjectModel;
using Lab2.Models;

namespace Lab2
{
    static class PersonListGenerator
    {
        public static ObservableCollection<Person> GeneratePersons()
        {
            var persons = new ObservableCollection<Person>();

            for(int i = 0; i < 10; i++)
            {
                persons.Add(new Person("Name1", "Surname1", "email1@gmail.com"));
                persons.Add(new Person("Name2", "Surname2", "email2@gmail.com"));
                persons.Add(new Person("Name3", "Surname3", "email3@gmail.com"));
                persons.Add(new Person("Name4", "Surname4", "email4@gmail.com"));
                persons.Add(new Person("Name5", "Surname5", "email5@gmail.com"));
            }
            return persons;
        }
    }
}
