using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            // create persons
            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" };
            Person person2 = new Person { Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "020292-222A" };
            Person person3 = new Person { Firstname = "Teppo", Lastname = "Vuolle", SocialSecurityNumber = "030393-333A" };
            // add persons to collection
            persons.Add(person1.SocialSecurityNumber, person1);
            persons.Add(person2.SocialSecurityNumber, person2);
            persons.Add(person3.SocialSecurityNumber, person3);
            // find person with key
            string ssn = "020292-222A";
            Person found;
            if (persons.TryGetValue(ssn, out found))
            {
                Console.WriteLine("Person with SSN {0} found: {1}", ssn, found.ToString());
            }
            else Console.WriteLine("Person with SSN {0} NOT FOUND", ssn);

            foreach(string key in persons.Keys)
            {
                Console.WriteLine(key);
            }


            foreach (Person person in persons.Values)
            {
                Console.WriteLine(person.ToString());
            }

            foreach (KeyValuePair<string, Person> kvp in persons)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
            }

            if (persons.ContainsKey(ssn))
            {
                persons.Remove(ssn);
            }


        }
    }
}
