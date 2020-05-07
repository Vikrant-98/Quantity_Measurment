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
        /// <summary>
        /// TC-1.12 Value check for 1 Inch Not Equal 1 Feet
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Value_Check_for_Not_Equality_With_1_Inch_to_1_Feet()
        {
            double actual = type.Inch_to_Feet(1);
            double expected = 1;
            Assert.AreNotEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.13 Value check for 1 Feet Equal to 12 Inch
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Value_Check_for_Equality_1_Feet_to_12_Inch()
        {
            double actual = type.Feet_to_Inch(1);
            double expected = 12;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.14 Value check for 12 Inch Equal 1 Feet
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Value_Check_for_Equality_12_Inch_to_1_Feet()
        {
            double actual = type.Inch_to_Feet(12);
            double expected = 1;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.15 Value check for 3 Feet Equal 1 Yard
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Value_Check_for_Equality_3_Feet_to_1_Yard()
        {
            double actual = type.Feet_to_Yard(3);
            double expected = 1;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.16 Value check for 1 Feet Not Equal 1 Yard
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Value_Check_for_Not_Equality_With_1_Feet_to_1_Yard()
        {
            double actual = type.Feet_to_Yard(1);
            double expected = 1;
            Assert.AreNotEqual(expected, actual);
        }
        /// <summary>
        /// TC-1.17 Value check for 1 Yard Not Equal 1 Feet
        /// </summary>
        [Test]
        public void Given_Input_Check_For_Value_Check_for_Not_Equality_1_Yard_to_1_Feet()
        {
            double actual = type.Yard_to_Feet(1);
            double expected = 1;
            Assert.AreNotEqual(expected, actual);
        }
        
    }
}