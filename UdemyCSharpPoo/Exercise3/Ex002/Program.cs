using System.Globalization;

namespace Ex002 {
    class Progam {
        static void Main(string[] args) {
            
            double rai = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = rai * rai * pi;
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));


        }
        
    }
}


