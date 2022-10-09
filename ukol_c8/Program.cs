using static System.Console;

namespace consoleApp {
    class cv8 {
        

        static void Main() {
            int x1, x2, y1, y2;
            double vzdalenost;
            WriteLine("Zadej x1");
            x1 = int.Parse(ReadLine());

            WriteLine("Zadej x2");
            x2 = int.Parse(ReadLine());

            WriteLine("Zadej y1");
            y1 = int.Parse(ReadLine());

            WriteLine("Zadej y2");
            y2 = int.Parse(ReadLine());

            vzdalenost = vypocetVzdalenosti(x1, x2, y1, y2);

            WriteLine(vzdalenost);
        }
        static double vypocetVzdalenosti(int x1, int x2, int y1, int y2) {
            float rozdilX,  rozdilY; 
            double d;

            if(y1 == y2) {
                return Math.Abs(x1) + Math.Abs(x2);
            }

            if(x1 == x2) {
                return Math.Abs(y1) + Math.Abs(y2);
            }

            rozdilX = Math.Abs(x1) - Math.Abs(x2);
            rozdilY = Math.Abs(y1) - Math.Abs(y2);
            d = rozdilX * rozdilX + rozdilY * rozdilY;

            return Math.Sqrt(d);
            
        }

        

    }
}
