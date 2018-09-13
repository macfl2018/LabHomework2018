using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTrail2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOne, inputTwo;
            char letterOne, letterTwo, letterThree, letterFour, letterFive, letterSix; 
            bool repeat1 = true, repeat2 = true;
            int characterLength = 3;

          //Brings in first input and determines if its a proper number or not
            
            while (repeat1 == true)
                {
                            Console.WriteLine("Please enter a three digit number");
                        inputOne = Console.ReadLine();

                    if (inputOne.Length == characterLength && Int32.TryParse(inputOne, out int numberOne) == true)
                    {
                        repeat1 = false;
                        Console.WriteLine("Put in another 3 digit number");
                        inputTwo= Console.ReadLine();

                                while (repeat2 == true)

                                {
           // Moves onto second input                        

                                    if (inputTwo.Length == characterLength && Int32.TryParse(inputTwo, out int numbertwo) == true)
                                    { 

                                        repeat2 = false;
                                        Console.WriteLine("Thank you for entering two 3 digit numbers");
                                        Console.ReadLine();
                                        Console.WriteLine("You entered" + " "+ inputOne + " " + " and " + " " + inputTwo);
                                        Console.ReadLine();

                                             string substringInputOne0 = inputOne.Substring(0, 1);
                                             //Console.WriteLine(substringInputOne0);


                                            string substringInputOne1 = inputOne.Substring(1, 1);
                                            //Console.WriteLine(substringInputOne1);

                                            string substringInputOne2 = inputOne.Substring(2, 1);
                                            //Console.WriteLine(substringInputOne2);



                                            string substringInputTwo0 = inputTwo.Substring(0, 1);
                                            //Console.WriteLine(substringInputTwo0);


                                            string substringInputTwo1 = inputTwo.Substring(1, 1);
                                            //Console.WriteLine(substringInputTwo1);

                                            string substringInputTwo2 = inputTwo.Substring(2, 1);
                                            //Console.WriteLine(substringInputTwo2);


                                            //Console.WriteLine(substringInputOne0, substringInputOne1, substringInputOne2, substringInputTwo0, substringInputTwo1, substringInputTwo2);
                                            //Console.ReadLine();

                                            Int32.TryParse(substringInputOne0, out int A0);
                                            Int32.TryParse(substringInputOne1, out int A1);
                                            Int32.TryParse(substringInputOne2, out int A2);


                                            Int32.TryParse(substringInputTwo0, out int B0);
                                            Int32.TryParse(substringInputTwo1, out int B1);
                                            Int32.TryParse(substringInputTwo2, out int B2);

                                             int AB0 = A0 + B0;
                                             int AB1 = A1 + B1;
                                             int AB2 = A2 + B2;

                                            //Console.Write(AB0);
                                            //Console.ReadLine();
                                            //Console.Write(AB1);
                                            //Console.ReadLine();
                                            //Console.Write(AB2);
                                            //Console.ReadLine();
                                            
                                                        if (AB0 == AB1 & AB1 == AB2) 
                                                        {

                                                        Console.WriteLine(" Your numbers match");
                                                        Console.ReadLine();
                                                         }

                                                        else
                                                        {
                                                        Console.WriteLine(" Your numbers do not match");
                                                        Console.ReadLine();
                                                        }







                                        }            
                                    else
                                    {
                                        repeat2 = true;
                                              Console.WriteLine("Please try again for a 3 digit number for your second input");
                                             inputTwo = Console.ReadLine();

                                    }

                                
                            
                                }
                        




                    }

                    else
                    {
                    repeat1 = true;
                        Console.WriteLine("Please only use a 3 digit numbmer");
                        Console.ReadLine();
                    }


                      


            }
            
           




        }
    }
}
