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
    }
}