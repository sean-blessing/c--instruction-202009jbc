using System;

namespace ConsoleLibrary {
    public class MyConsole {
        static String GetString(String prompt) {
            Console.WriteLine(prompt);
            String s = Console.ReadLine();  // read user entry
            return s;
        }
        public static double getDouble(String prompt) {
            double d = 0;
            bool isValid = false;
            while (!isValid) {
                Console.Write(prompt);
                try {
                    d = double.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception e) {
                    Console.WriteLine("Error! Invalid double. Try again.");
                }
            }
            return d;
        }
    }
}
