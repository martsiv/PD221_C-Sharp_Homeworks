using System.Collections;

namespace _12_Homework__Generic_collections_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n===================================== Task 1 =====================================\n");
            ArrayList newList = new ArrayList()
            { (bool)true, (int)5, (double)6.4, (bool)false, (int)7, (double)3.5, (int)1, (int)3, (double)7.24, (int)9, (int)33, (double)14.2};

            List<bool> bools = newList.OfType<bool>().ToList();
            List<int> ints = newList.OfType<int>().ToList();
            List<double> doubles = newList.OfType<double>().ToList();

            Console.WriteLine("All bools: " + string.Join(", ", bools));
            Console.WriteLine("All ints: " + string.Join(", ", ints));
            Console.WriteLine("All doubles: " + string.Join(", ", doubles));


            Console.WriteLine("\n===================================== Task 2 =====================================\n");
            List<string> words = new List<string>()
            { "some", "words", "Apples", "Correction", "Adwertises", "Fruit"};
            Console.WriteLine("All words: " + string.Join(", ", words));
            Console.WriteLine("Longest word: " + words.OrderByDescending(w => w.Length).ThenBy(w => w).First());


            Console.WriteLine("\n===================================== Task 3 =====================================\n");

            PhoneBook phoneBook = new PhoneBook();

            PhoneSubscriber adam = new PhoneSubscriber
                (phoneNumber: "+380964825054", firstName: "Adam", lastName: "Sendler");
            PhoneSubscriber leo = new PhoneSubscriber
                (phoneNumber: "+380503829513", firstName: "Leonardo", lastName: "DaVinci");
            PhoneSubscriber georg = new PhoneSubscriber
                (phoneNumber: "+380734930578", firstName: "Georg", lastName: "Washington");

            phoneBook.AddRecord(adam.PhoneNumber, adam);
            phoneBook.AddRecord(leo.PhoneNumber, leo);
            phoneBook.AddRecord(georg.PhoneNumber, georg);
            Console.WriteLine("\nAll records:");
            phoneBook.PrintAllRecords();
            if (phoneBook.UpdateRecord(leo.PhoneNumber, new PhoneSubscriber(phoneNumber: "+380994284715", firstName: "Arnold", lastName: "Schwartzenegger")))
            {
                Console.WriteLine("\nUpdated success");
                Console.WriteLine("All records:");
                phoneBook.PrintAllRecords();
            }
            else Console.WriteLine("\nFail update subscriber");
            if (phoneBook.UpdateRecord("unknown number", new PhoneSubscriber(phoneNumber: "none", firstName: "none", lastName: "none")))
            {
                Console.WriteLine("\nUpdated success.");
                Console.WriteLine("All records:");
                phoneBook.PrintAllRecords();
            }
            else Console.WriteLine("\nFail update subscriber");


            if (phoneBook.RemoveRecord(adam.PhoneNumber))
            {
                Console.WriteLine("\nDeleted success.");
                Console.WriteLine("\nAll records:");
                phoneBook.PrintAllRecords();
            }
            else Console.WriteLine("\nFail deleted subscriber");

            string key = georg.PhoneNumber;
            PhoneSubscriber? otherSubscriber = phoneBook.GetRecord(key);
            Console.WriteLine($"\nKey {key}: " + otherSubscriber ?? "not found");

            key = "none";
            otherSubscriber = phoneBook.GetRecord(key);
            Console.WriteLine($"\nKey {key}: " + (otherSubscriber?.ToString() ?? "not found"));


            Console.WriteLine("\n===================================== Task 4 =====================================\n");

            PlayingDeck deck = new PlayingDeck();
            deck.Shuffle();
            foreach (var item in deck)
                Console.WriteLine(item);
            PlayingСard[] cards = deck.GetCards();
            Console.WriteLine("\nCards in hand:");
            foreach (var item in cards)
                Console.WriteLine(item);
            Console.WriteLine("\nCards in deck:");
            foreach (var item in deck)
                Console.WriteLine(item);


            Console.WriteLine("\n===================================== Task 5 =====================================\n");

            //HanoiTower hanoiTower = new HanoiTower();
            //hanoiTower.Show();
            //Console.ReadKey();  
            //hanoiTower.Play();
        }
    }
}