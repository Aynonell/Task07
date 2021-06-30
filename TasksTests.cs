using System;
using Xunit;
using Tasks.Task7;


namespace TestTasks
{
    public class Tasks07Tests
    {
        [Fact]
        public void Task07TestRomanToInt()
        {
            Task07 task = new Task07();
            Assert.Equal(1, task.RomanToInt("I"));
            Assert.Equal(2, task.RomanToInt("II"));
            Assert.Equal(3, task.RomanToInt("III"));
            Assert.Equal(4, task.RomanToInt("IV"));
            Assert.Equal(5, task.RomanToInt("V"));
            Assert.Equal(6, task.RomanToInt("VI"));
            Assert.Equal(7, task.RomanToInt("VII"));
            Assert.Equal(8, task.RomanToInt("VIII"));
            Assert.Equal(9, task.RomanToInt("IX"));
            Assert.Equal(10, task.RomanToInt("X"));
            Assert.Equal(2496, task.RomanToInt("MMCDXCVI"));
        }
        [Fact]
        public void Task07TestGetValue()
        {
            Task07 task = new Task07();
            Assert.Equal(1, task.getValue('I'));
            Assert.Equal(5, task.getValue('V'));
            Assert.Equal(10, task.getValue('X'));
            Assert.Equal(50, task.getValue('L'));
            Assert.Equal(100, task.getValue('C'));
            Assert.Equal(500, task.getValue('D'));
            Assert.Equal(1000, task.getValue('M'));
        }
        [Theory]
        [InlineData("MMMCDIV")]
        [InlineData("MMMCDXVIII")]
        [InlineData("MMMCDXXXVII")]
        [InlineData("MMMCDLVII")]
        [InlineData("MMMCDLXXXII")]
        [InlineData("MMMCDLXXXIII")]
        [InlineData("MMMCDLXXXIV")]
        [InlineData("MMMCDLXXXV")]
        [InlineData("MMMCDLXXXVI")]
        [InlineData("MMMCDLXXXVII")]
        [InlineData("MMMDXLIII")]
        [InlineData("MMMDLXXXI")]
        [InlineData("MMMDLXXXII")]
        [InlineData("MMMDLXXXIII")]
        [InlineData("MMMDLXXXIV")]
        [InlineData("MMMDLXXXV")]
        [InlineData("MMMDLXXXVI")]
        [InlineData("MMMDLXXXVII")]
        [InlineData("MMMDLXXXVIII")]
        [InlineData("MMMDLXXXIX")]
        [InlineData("MMMDXC")]
        [InlineData("MMMDXCI")]
        [InlineData("MMMDXCIV")]
        [InlineData("MMMDXCIX")]
        [InlineData("MMMDC")]
        [InlineData("MMMDCI")]
        [InlineData("MMMDCLXI")]
        [InlineData("MMMDCCI")]
        [InlineData("MMMDCCXXXIII")]
        [InlineData("MMMDCCLXIX")]
        [InlineData("MMMDCCLXX")]
        [InlineData("MMMCMLXXIX")]
        

        public void Task07TestRepetTheSameNeighbourPositive(string roman)
        {
            Task07 task = new Task07();
            Assert.True(task.UnavaliableNeighbour(roman));
        }
        [Theory]
        [InlineData("XXIXXXX")]
        [InlineData("XXIVV")]
        [InlineData("DDCI")]
        public void Task07TestRepetTheSameNeighbourNegative(string roman)
        {
            Task07 task = new Task07();
            Assert.Throws<ArgumentException>(() => task.UnavaliableNeighbour(roman));
        }
    }
}
