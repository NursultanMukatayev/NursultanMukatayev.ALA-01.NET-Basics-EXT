using System;
using NUnit.Framework;
using Basic_Coding_NMukatayev_Task1;
using Basic_coding_Task_5;


namespace TestingClass
{

    [TestFixture]
    public class InsertionAndFindNextBiggerNum
    {
        [TestCase(26, 8, 1, 2)]
        [TestCase(10, int.MaxValue, 1, 42)]
        public void Insertion_test_arg_out_of_range_exc_test(int num_1, int num_2, int i, int j)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Insertion_of_numbers.Insertion(num_1, num_2, i, j));
        }

        [TestCase(13, 0, 2, 5)]
        public void Insertion_test_invalid_arg_exc_test(int first, int second, int i, int j)
        {
            Assert.Throws<ArgumentException>(() => Insertion_of_numbers.Insertion(first, second, i, j));
        }
    }

    [TestFixture]
    public class FindNextBiggerNumTest
    {
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(2077, ExpectedResult = 2707)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        public int FindNextBiggerNumberNUnitTest1(int number)
        {
            return FindNextBiggerNumber.FindNextBiggerNumber_(number);
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(int.MinValue)]
        public void FindNextBiggerNumberNUnitTest_NumberNotPositive_ThrowsException(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => FindNextBiggerNumber.FindNextBiggerNumber_(number));
        }
    }
}

