using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class process
    {
        public abstract double processing();
    }
    class triangle : process
    {
        double side1;
        double side2;
        double side3;
        public triangle(double s1, double s2, double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public override double processing()

        {
            return (side1 + side2 + side3);
        }
    }
    class circle : process
    {
        double jari;
        public circle(double j)
        {
            jari = j;
        }
        public override double processing()

        {
            return (2 * (Convert.ToDouble(3.14)) * jari);
        }
    }
        class rectangle : process
        {
            double length;
            double width;
            public rectangle(double a, double b)
            {
                length = a;
                width = b;
            }
            public override double processing()
            {
                return (2 * (length + width));
            }
    }

    class trapezoid : process
            {
                double sideA;
                double sideB;
                double sideC;
                double sideD;
                public trapezoid(double sA, double sB, double sC, double sD)
                {
                    sideA = sA;
                    sideB = sB;
                    sideC = sC;
                    sideD = sD;
                }
                public override double processing()
                {
                    return (sideA + sideB + sideC + sideD);
                }
            }
    class Menu_Keliling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================== :");
            Console.WriteLine("PERHITUNGAN KELILING :");
            Console.WriteLine("=================================== :");
            Console.WriteLine("1. Segitiga :");
            Console.WriteLine("2. Lingkaran :");
            Console.WriteLine("3. Persegi Panjang :");
            Console.WriteLine("4. Trapesium :");
            Console.WriteLine("====================================");
            Console.Write("Pilihan Menu :");
            double nomor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("====================================");

            if (nomor == 1)
            {
                Console.WriteLine();
                Console.Write("Masukkan sisi pertama : ");
                double side1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan sisi kedua : ");
                double side2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan sisi ketiga : ");
                double side3 = Convert.ToDouble(Console.ReadLine());
                process p = new triangle(side1, side2, side3);
                double l = p.processing();
                Console.WriteLine("Keliling Segitiga : " + l);

            }
            else if (nomor == 2)

            {
                Console.Write("Masukkan jari : ");
                double jari = Convert.ToDouble(Console.ReadLine());
                process a = new circle(jari);
                double b = a.processing();
                Console.WriteLine("Keliling Lingkaran : " + b);

            }
            else if (nomor == 3)
            {
                Console.Write("Masukkan panjang: ");
                double panjang = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan lebar : ");
                double lebar = Convert.ToDouble(Console.ReadLine());
                process x = new rectangle(panjang, lebar);
                double y = x.processing();
                Console.WriteLine("Keliling Persegi Panjang : " + y );

            }
            else
            {
                Console.Write("Masukkan side pertama: ");
                double sideA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan side kedua : ");
                double sideB = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan side ketiga : ");
                double sideC = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan side keempat : ");
                double sideD = Convert.ToDouble(Console.ReadLine());
                process m = new trapezoid(sideA, sideB, sideC, sideD);
                double n = m.processing();
                Console.WriteLine("Keliling Trapesium : " + n);    
            }
            Console.Read();
        }
     }
}

