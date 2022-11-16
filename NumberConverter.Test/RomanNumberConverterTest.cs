namespace NumberConverter.Test
{
    public class RomanNumberConverterTest
    {
        [Fact]
        public void Should_Reject_Null_Value()
        {
            decimal? value = null;
            RomanNumberConverter numberConverter = new();
            var result = numberConverter.ConvertDecimalToRoman(value.ToString());
            Assert.Equal("Must enter a number", result);
        }

        [Fact]
        public void Should_Reject_Number_Below_1_And_3999()
        {
            decimal? value = 4000;
            RomanNumberConverter numberConverter = new();
            var result = numberConverter.ConvertDecimalToRoman(value.ToString());
            Assert.Equal("Must enter a number between 1 and 3999", result);
        }

        [Fact]
        public void Should_Accept_Number_Below_1_And_3999()
        {
            decimal? value = 2500;
            RomanNumberConverter numberConverter = new();
            var result = numberConverter.ConvertDecimalToRoman(value.ToString());
            Assert.NotEqual("Must enter a number between 1 and 3999", result);
        }

        [Fact]
        public void Should_Return_Roman_Different_From_XXX()
        {
            decimal? value = 31;
            RomanNumberConverter numberConverter = new();
            var result = numberConverter.ConvertDecimalToRoman(value.ToString());
            Assert.NotEqual("XXX", result);
        }

        [Fact]
        public void Should_Return_Roman_V()
        {
            decimal? value = 5;
            RomanNumberConverter numberConverter = new();
            var result = numberConverter.ConvertDecimalToRoman(value.ToString());
            Assert.Equal("V", result);
        }

    }
}