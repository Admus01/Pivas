using static System.Console;

namespace consoleApp {
    class cv9 {
        static void Main() {
            WriteLine("Zadej retezec");
            string input = ReadLine();
            char[] splittedInput = input.ToCharArray();
            int len = input.Length;
            vypisPozpatku(splittedInput, len);
            
        }

        static void vypisPozpatku(char[] input, int len) {
            for(int i = len - 1; i >= 0; i--)
            {
                Write(input[i]);
            }
        }
    }
}
