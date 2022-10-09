using static System.Console;

namespace consoleApp{
    class cv7 {
      static void Main() {
        int m;
        int n;
        
        WriteLine("Zadej n");
        n = int.Parse(ReadLine());
        WriteLine("Zadej m");
        m = int.Parse(ReadLine());
        
        vypisMatici(m, n);
      }
      
      static void vypisMatici(int m, int n) {
          int startNumber = 1;
            int number;
            
            
            for(int i = 0; i < n; i++){
                number = startNumber;
                for(int j = 0; j < m; j++){
                    Write(number);
                    Write(" ");
                    number += n;
                }
                Write("\n");
                startNumber += 1;
            }
      }
      
    }
}