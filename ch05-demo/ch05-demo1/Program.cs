using System;

namespace ch05_demo1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Chapter 5 demos!");

            int nbr = ParseInt("Enter a whole number: ");

            Console.WriteLine("you entered: " + nbr);

            PrintOrderDetails(productName: "Light Up Pumpkin", orderNum: 33,
                sellerName:"Target");

            PrintCandyStats("Snickers", 5);
            PrintCandyStats("KitKat");
            PrintFavSong("Accidents Will Happen");

        }

        private static int ParseInt(String prompt) {
            int n = 0;
            while (true) {
                Console.WriteLine(prompt);
                try {
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception) {
                    Console.WriteLine("Hey!  Enter something valid!");
                }
            }
            return n;
        }

        // demonstrate named parameters
        private static void PrintOrderDetails(String sellerName,
                            int orderNum, String productName) {
            Console.WriteLine("Order Details: " + productName + ", on " +
                            "order # " + orderNum + ", purchased at " + 
                            sellerName + ".");
        }

        // demonstrate optional parameters
        private static void PrintCandyStats(String candyName, 
                                            int quantity = 0) {
            Console.WriteLine("* " + quantity + " pieces of " 
                                + candyName);
        }

        private static void PrintFavSong(String name) {
            //Console.WriteLine("My favorite song is " + name + ".");
            Console.WriteLine($"My favorite song is {name}.");

        }
    }
}
