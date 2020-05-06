using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantity_Measurement
{
    class MeasurementException : Exception
    {
        /// <summary>
        /// Exception type Declaration
        /// </summary>
        public enum Type
        {
            Null, Invalid_Type
        }
        public MeasurementException(Type type, String message) : base(message)
        {
        }
    }
    class Conversion
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Static function to select type conversion type
        /// </summary>
        /// <returns></returns>
        public static string Measure()
        {
            try
            {
                Console.WriteLine("1.Feet to Inch \n2.Inch to Feet");
                Console.WriteLine("Enter your choice");
                ConversionType type = new ConversionType();
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your input");
                string input = Console.ReadLine();
                Console.WriteLine(type.Convert(input, choice));
            }
            catch (FormatException message)
            {
                return message.Message;
            }
            return "";
        }
    }
    public class ConversionType
    {
        /// <summary>
        /// Conversion function created to convert Quantity of one type to another
        /// </summary>
        /// <param name="input"></param>
        /// <param name="choice"></param>
        /// <returns></returns>
        public string Convert(string input, int choice)
        {
            ConversionType type = new ConversionType();
            try
            {
                if (input.Length == 0)
                {
                    throw new MeasurementException(MeasurementException.Type.Null, "Enter Null Vlaue");
                }
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine(input + " Feet = " + type.Feet_to_Inch(double.Parse(input)) + " Inch");
                            break;
                        }
                    default:
                        {
                            throw new MeasurementException(MeasurementException.Type.Invalid_Type, "Invalid Type Exception");
                        }
                }
            }
            catch (MeasurementException message)
            {
                return message.Message;
            }
            catch (FormatException message)
            {
                return message.Message;
            }
            return "";
        }

        public double Feet_to_Inch(double input)
        {
            return input *= 12;
        }
        
    }
}
