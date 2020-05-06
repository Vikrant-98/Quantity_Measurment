using NUnit.Framework;
using Quantity_Measurement;

namespace Tests
{
    public class Tests
    {
        ConversionType type = new ConversionType();
        /// <summary>
        /// TC-1.1 Test Case Compare with Zero
        /// </summary>
        [Test]
        public void Given_Feet_Convert_To_Inch_Zero_Input()
        {
            double actual = type.Feet_to_Inch(0);
            double expected = 0;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.2 Test for Null Exception
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Null_Value_Feet_to_Inch()
        {
            string actual = type.Convert("", 1);
            string expected = "Enter Null Vlaue";
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.3 Test for Invalid Reference format Exception
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Ref_Check_Feet_to_Inch()
        {
            string actual = type.Convert("abc", 1);
            string expected = "Input string was not in a correct format.";
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.4 Test for Invalid type check Exception
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Invalid_Type_Feet_to_Inch()
        {
            string actual = type.Convert("5", 7);
            string expected = "Invalid Type Exception";
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.5 Given value input gives correct output
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Value_Check_for_Equality_Feet_to_Inch()
        {
            double actual = type.Feet_to_Inch(2);
            double expected = 24;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.6 Test Case Compare with Zero
        /// </summary>
        [Test]
        public void Given_Inch_Convert_To_Feet_Zero_Input()
        {
            double actual = type.Inch_to_Feet(0);
            double expected = 0;
            Assert.AreEqual(expected, actual);
        }/// <summary>
        /// TC-1.7 Test Case to check Null Value
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Null_Value_Inch_to_Feet()
        {
            string actual = type.Convert("", 2);
            string expected = "Enter Null Vlaue";
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.8 Test for Invalid Reference format Exception
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Ref_Check_Inch_to_Feet()
        {
            string actual = type.Convert("abc", 2);
            string expected = "Input string was not in a correct format.";
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.9 Test for Invalid type check Exception
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Invalid_Type_Inch_to_Feet()
        {
            string actual = type.Convert("5", 7);
            string expected = "Invalid Type Exception";
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.10 Given value input gives correct output
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Value_Check_for_Equality_Inch_to_Feet()
        {
            double actual = type.Inch_to_Feet(3.6);
            double expected = 0.3;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.11 Value check for 1 Feet Not Equal 1 Inch
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Value_Check_for_Not_Equality_1_Feet_to_1_Inch()
        {
            double actual = type.Feet_to_Inch(1);
            double expected = 1;
            Assert.AreNotEqual(expected, actual);
        }
        
    }
}