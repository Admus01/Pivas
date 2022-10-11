using static System.Console;

namespace consoleApp {
    class cv9 {
        static void Main() {
            WriteLine("Zadej retezec");
            string input = ReadLine();
            char[] splittedInput = input.ToCharArray();
            vypisVertikalne(splittedInput);
            
        }

        static void vypisVertikalne(char[] input) {
            foreach (char letter in input)
            {
                WriteLine(letter);
            }
        }
    }
}
