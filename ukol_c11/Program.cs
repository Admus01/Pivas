using static System.Console;

namespace consoleApp {
    class cv11 {
        static void Main() {
            WriteLine("Zadej rodne cislo");
            string input = ReadLine();
            char[] splittedInput = input.ToCharArray();
            urciPohlavi(splittedInput);
            
        }

        static void urciPohlavi(char[] input) {
            char index = input[2];
            if(index == '0') {
                WriteLine("Muz");
            } else if(index == '5' || index == '6' || index == '7') {
                WriteLine("Zena");
            } else {
                WriteLine("Spatne zadane rodne cislo");
            }
        }
    }
}
