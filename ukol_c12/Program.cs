using static System.Console;

namespace consoleApp {
    class cv12 {
        static void Main() {
            WriteLine("Zadej den");
            int day = int.Parse(ReadLine());
            WriteLine("Zadej mesic");
            int month = int.Parse(ReadLine());

            string obdobi = urciObdobi(day, month);
            WriteLine(obdobi);
            
        }

        static string urciObdobi(int day, int month) {
            if(month == 1 || month == 2) {
                return "zima";
            }

            if(month == 12 && day >= 21) {

                return "zima";

            } else if(month == 12 && day < 21) {

                return "podzim";

            }

            if(month == 4 || month == 5){
                return "jaro";

            }

            if(month == 3 && day >= 21) {
                
                return "jaro";

            } else if(month == 3 && day < 21) {
                
                return "zima";

            }

            if(month == 7 || month == 8) {
                return "leto";

            }

            if (month == 6 && day >= 21) {

                return "leto";

            } else if (month == 6 && day < 21) {

                return "jaro";

            }

            if(month == 10 || month == 11) {
                return "podzim";

            }

            if (month == 9 && day >= 23) {
                return "podzim";
            } else if (month == 9 && day < 23) {
                return "leto";
            }
            
            return "Spatne datum";
           
        }
    }
}

