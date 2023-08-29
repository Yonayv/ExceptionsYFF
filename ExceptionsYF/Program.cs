using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace Exceptions_YF
{

    class Program
    {

        /// <summary>
        /// A method returns a float called Divide and takes two params
        /// If the second param is equal to zero then DivideByZeroExceptioin is thrown 
        /// Else the first param is returned and divided by the second param
        /// CheckAge method has one int param called age
        /// If the param is greater than or equal to 17 then a message with <age> is printed to console
        /// Else An ArgumentException is thrown
        /// In main there are two variables one set to zero
        /// result float is declared 
        /// An int with a random range from 2 to 30 is initialized
        /// A result is assigned result to the Divide method passing tow variables as arguments
        /// All exceptions are catched & printed to console using the built-in message property
        /// User is asked to try to input a floating point number other than zero.
        /// The second argument is changed to user inputted value
        /// Try is assigning result to the Divide method again, then its printed to console
        /// All exceptions are catched and printed to console the error message using the built-in message property
        /// A finally blcok prints a message with <result> 
        /// The Try calls upon ChechkAge & passes through the int variable created. 
        /// </result>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {

            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;

            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a number other than zero");
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());    
                
                try
                {
                    result = Divide(myFloat, myOtherFloat);

                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
                

            }
            finally
            {
                Console.WriteLine("Calculations completed with a result of " + result);

            }

            try
            {
                CheckAge(myInt); 
                

            }
            catch
            {
                Console.WriteLine($"You are {myInt} not old enough!");
            }
        }

    

        static float Divide(float x, float y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException();
            }

            else
            {
                return x / y;
            }
        }

        static void CheckAge(int age)
        {
            if(age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play mature");
            }
            else
            {
                throw new ArgumentException();
            }
        }


    }






}