using System.Xml.Serialization;

namespace Phonebook
{
    public class Phonebook
    {
        private static Dictionary<string, List<string>> contacts = new Dictionary<string, List<string>>();

        public void AddContact(string contactName, string phoneNumber)
        {
            if (!contacts.ContainsKey(contactName))
            {
                contacts[contactName] = new List<string>();
            }
            contacts[contactName].Add(phoneNumber);

            Console.WriteLine($"Dodano kontakt: {contactName}, {phoneNumber}");
        }

        public void RemoveContact(string contactName)
        {
            if (contacts.ContainsKey(contactName))
            {
                contacts.Remove(contactName);
                Console.WriteLine($"Usunięto kontakt: {contactName}");
            }
            else
            {
                Console.WriteLine($"Kontakt {contactName} nie istnieje");
            }
        }

        public void ModifyContact(string contactName, string oldPhoneNumber, string newPhoneNumber)
        {
            if (contacts.ContainsKey(contactName))
            {
                if (contacts[contactName].Contains(oldPhoneNumber))
                {
                    contacts[contactName].Remove(oldPhoneNumber);
                    contacts[contactName].Add(newPhoneNumber);
                    Console.WriteLine($"Zmieniono numer kontaktu {contactName} z: {oldPhoneNumber} na: {newPhoneNumber}");
                }
                else
                {
                    Console.WriteLine($"Nie znaleziono numeru {oldPhoneNumber} dla kontaktu {contactName}");
                }
            }
            else
            {
                Console.WriteLine($"Kontakt {contactName} nie istnieje");
            }
        }

        public void DisplayContactByPhoneNumber(string phoneNumber)
        {
            var matchingContacts = contacts.Where(contact => contact.Value.Contains(phoneNumber)).ToList();

            if (matchingContacts.Any())
            {
                foreach (var contact in matchingContacts)
                {
                    Console.WriteLine($"Kontakt: {contact.Key}, Numer telefonu: {phoneNumber}");
                }
            }
            else
            {
                Console.WriteLine($"Nie znaleziono kontaktu z numerem {phoneNumber}");
            }
        }

        public void DisplayContactByContactName(string contactName)
        {
            if (contacts.ContainsKey(contactName))
            {
                Console.WriteLine($"Kontakt: {contactName}, Numery telefonu: {string.Join(", ", contacts[contactName])}");
            }
            else
            {
                Console.WriteLine($"Nie znaleziono kontaktu o nazwie {contactName}");
            }
        }

        public void DisplayAllContacts()
        {
            if (contacts.Any())
            {
                Console.WriteLine("Lista wszystkich kontaktów:");
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"Kontakt: {contact.Key}, Numer: {string.Join(", ", contact.Value)}");
                }
            }
            else
            {
                Console.WriteLine("Brak kontaktów");
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var phonebook = new Phonebook();

            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("\n MENU: \n1 - Add Contact \n2 - Modify Contact \n3 - Delete Contact \n4 - Display by Number \n5 - Display by Name \n6 - Show All \n0 - End ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Wprowadź nazwę kontaktu:");
                        string contactName = Console.ReadLine();
                        Console.WriteLine("Wprowadź numer telefonu:");
                        string phoneNumber = Console.ReadLine();
                        phonebook.AddContact(contactName, phoneNumber);
                        break;

                    case "2":
                        Console.WriteLine("Wprowadź nazwę kontaktu do zmiany numeru:");
                        string modifyName = Console.ReadLine();
                        Console.WriteLine("Wprowadź stary numer telefonu:");
                        string oldPhoneNumber = Console.ReadLine();
                        Console.WriteLine("Wprowadź nowy numer telefonu:");
                        string newPhoneNumber = Console.ReadLine();
                        phonebook.ModifyContact(modifyName, oldPhoneNumber, newPhoneNumber);
                        break;

                    case "3":
                        Console.WriteLine("Wprowadź nazwę kontaktu do usunięcia:");
                        string removeName = Console.ReadLine();
                        phonebook.RemoveContact(removeName);
                        break;

                    case "4":
                        Console.WriteLine("Wprowadź numer telefonu do wyszukania:");
                        string searchNumber = Console.ReadLine();
                        phonebook.DisplayContactByPhoneNumber(searchNumber);
                        break;

                    case "5":
                        Console.WriteLine("Wprowadź nazwę kontaktu do wyszukania:");
                        string searchName = Console.ReadLine();
                        phonebook.DisplayContactByContactName(searchName);
                        break;

                    case "6":
                        phonebook.DisplayAllContacts();
                        break;

                    case "0":
                        Console.WriteLine("Zakończenie programu");
                        continueProgram = false;
                        break;

                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}