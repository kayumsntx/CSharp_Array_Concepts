using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				DoTask();

			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.ReadLine();
			}

        }

        private static void DoTask()
        {
            DeclareArray();
            ArrayInstance();
            AnnonimousTypesArray();
            AccessingArray();
            PassingThroughArray();
            CopyingArray();
            SingleDimensionalArray();
            MultiDimentionalArray();
            JaggedArray();

        }

        private static void JaggedArray()
        {
            string[] employeeName = new string[3];
            employeeName[0] = "Mr. Kayum";
            employeeName[1] = "Mr. MD";
            employeeName[2] = "Mr. Hossain";

            string[][] jArray = new string[3][];
            
           

            
            
           
            jArray[0] = new string[3];
            jArray[0][0] = "Doctoret";
            jArray[0][1] = "Masters";
            jArray[0][2] = "HSC";

            jArray[1] = new string[2];
            jArray[1][0] = "HSC";
            jArray[1][1] = "SSC";

            jArray[2] = new string[1];
            jArray[2][0] = "HSC";
            

            for (int i = 0; i < jArray.Length; i++)
            {
                string[] innerArray = jArray[i];
                Console.WriteLine($"{employeeName[i]} education Details");
                Console.WriteLine("...................................");
                for (int j=0; j<innerArray.Length; j++)
                {
                    Console.WriteLine(innerArray[j] );

                    
                }
                Console.WriteLine();
            }



        }

        private static void MultiDimentionalArray()
        {
            string[,] mdArray =new string[,]
            {
                { "MD", "Kayum", "Hossain"},
                { "Diana", "John", "Smith"}
            };
            for(int i = 0; i <= mdArray.GetUpperBound(0); i++)
            {
                string firstName = mdArray[i,0];
                string middleName = mdArray[i,1];
                string lastName = mdArray[i, 2];
                Console.WriteLine($"{firstName} {middleName} {lastName}");
                Console.WriteLine(".............");
            }
        }

        private static void SingleDimensionalArray()
        {
            string[] names = new string[3];
            names[0] = "Kayum";
            names[1] = "Hossain";
            names[2] = "MD";
            foreach (var item in names)
            {
                Console.Write($"{item} ");
            }
        }

        private static void CopyingArray()
        {
            Console.WriteLine("Copy 1");
            int[] pins = new int[5] { 1, 2, 3, 4, 5 };
            foreach (var item in pins)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            int[] change = pins;
            foreach (var item in change)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Copy 2");
            int[] copy = new int[pins.Length];
            for (int i = 0; i < pins.Length; i++)
            {
                copy[i] = pins[i];
            }
            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Copy 3");
            int[] copy2 = new int[pins.Length];
            pins.CopyTo(copy2, 0);

            foreach (var item in copy2)
            {
                Console.WriteLine(item);
            }

            int[] copy3 = new int[pins.Length];
            Array.Copy(pins, copy3, copy3.Length);
            foreach (var item in copy3)
            {
                Console.WriteLine(item);
            }
        }
        private static void PassingThroughArray()
        {
            var infos = new[]
            {
                new {Name="Kayum",age=30},
                new {Name = "Hossan",age=20}

            };
            ProcessData(infos);
        }

        private static void ProcessData(object[] infos)
        {
            foreach (var info in infos)
            {
                Console.WriteLine();
            }
        
        }

        private static void AccessingArray()
        {
            int[] pins;
            pins = new int[5];  
            pins[0] = 1;
            pins[1] = 2;
            pins[2] = 3;
            pins[3] = 4;
            pins[4] = 5;

            int myPin;
            myPin = pins[2];
            Console.WriteLine(myPin);

                        
        }

        private static void AnnonimousTypesArray()
        {

            var names = new[]{
                new  {Name="Kayum",Age=30},
                new {Name="Hossain",Age=20}



            };
            {

            }
        }

        private static void ArrayInstance()
        {
            int[] pins;
            pins = new int[4] {1234, 5678, 9012, 7889}; //explicite
            int[] pins2 = { 1234, 6556, 5685, 56869 }; //implicite 
            var myArray1 = new[] { "1","2","3" };
            var myArray = new[] { 1, 2, 3, 4, 5, 6, };
            var number = new[] { 1, 2, 3.5, 99.999 }; //ok
        }

        private static void DeclareArray()
        {
            int[] pins;

            pins = new int[5];
            pins[0] = 1234;
            pins[1] = 5678;
            pins[2] = 9012;    
            pins[3] = 7889;    
            pins[4] = 3456;

            for (int i = 0; i < pins.Length; i++)
               
            { 
            Console.WriteLine(pins[i]);
               
            }
            Console.WriteLine(":::::::::::::");
            int[] pins2 = new int[5] { 1234, 5565, 5555, 6685, 5556 };
            for (int i = 0;i < pins2.Length; i++)
            {
                Console.WriteLine(pins2[i]);
            }
            Console.WriteLine();
            //int[] pins = new int[5] { 2, 4, 6, 8, 2, 8, 6, 7 };
            //int[] pins = new int[5] { 2, 4, 6 };
            Console.WriteLine();

                        Random r = new Random();
            int[] pins4 = new int[4]{ r.Next() % 10, r.Next() % 10, r.Next() % 10,
        r.Next() % 10 };
            foreach (var item in pins4)
            {
                Console.WriteLine(item);

            }
            }
    }
}
