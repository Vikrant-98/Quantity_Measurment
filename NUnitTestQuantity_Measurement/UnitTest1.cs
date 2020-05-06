using NUnit.Framework;
using Quantity_Measurement;

namespace Tests
{
    public class Tests
    {
        ConversionType obj = new ConversionType();
        /// <summary>
        /// TC-1.1 Test Case Compare with Zero
        /// </summary>
        [Test]
        public void Given_Feet_Convert_To_Inch_Zero_Input()
        {
            double actual = obj.Feet_to_Inch(0);
            double expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}