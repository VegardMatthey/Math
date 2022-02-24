using System;

namespace SinCosTan
{
    class Trekanter
    {
        public static void Main()
        {
            GetLengths();
        }
        public static double RadianToDegrees(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
        public static double GetDegrees()
        {
            Console.Write("A : "); double A = Convert.ToDouble(Console.ReadLine());
            if(A == 0)
            {
                Console.WriteLine("A need to be known");
            }
            else{double C = 180 - A - 90;}
            return A;
        }
        public static void GetLengths()
        {
            Console.Write("Enter known : ");
            if(Console.ReadLine() == null){return;}
            string input = Console.ReadLine();
            double hyp = 0; double mot = 0; double hos = 0;

            if(input == "hyp")
            {
                Console.Write("Enter hyp : "); hyp = Convert.ToDouble(Console.ReadLine());
                mot = Math.Sin(Math.PI * GetDegrees() / 180.0) * hyp;
                hos = Math.Sqrt(hyp*hyp - mot*mot);
            }
            if(input == "mot")
            {
                Console.Write("Enter mot : "); mot = Convert.ToDouble(Console.ReadLine());
                hyp = mot / Math.Sin(Math.PI * GetDegrees() / 180.0);
                hos = Math.Sqrt(hyp*hyp - mot*mot);
            }
            if (input == "hos")
            {
                Console.Write("Enter hos : "); hos = Convert.ToDouble(Console.ReadLine());
                hyp = hos / Math.Cos(Math.PI * GetDegrees() / 180);
                mot = Math.Sqrt(hyp*hyp - hos*hos);
            }else{Console.WriteLine("Invalid name for known.");
            }
            Console.WriteLine("hyp = "+Math.Round(hyp,3)+"\nmot = "+Math.Round(mot,3)+"\nhos = "+Math.Round(hos,3));
            return;
        }
    }
}