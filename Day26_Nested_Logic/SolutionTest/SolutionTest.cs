using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SolutionTest
{
    [TestClass]
    public class UnitTest_CalculateFine
    {
        [TestMethod]
        public void CalculateFine_OnDue_Return0()
        {
            // arrange
            Dictionary<string, int> dateDict = new Dictionary<string, int>();
            dateDict.Add("day", 15);
            dateDict.Add("month", 7);
            dateDict.Add("year", 2019);

            // act
            int fine = Day26_Nested_Logic.Solution.CalculateFine(dateDict, dateDict);

            // assert
            Assert.AreEqual(fine, 0);
        }

        [TestMethod]
        public void CalculateFine_BeforeDue_Return0()
        {
            // arrange
            Dictionary<string, int> dueDate = new Dictionary<string, int>();
            dueDate.Add("day", 15);
            dueDate.Add("month", 7);
            dueDate.Add("year", 2019);
            Dictionary<string, int> returnDate = new Dictionary<string, int>();
            returnDate.Add("day", 14);
            returnDate.Add("month", 7);
            returnDate.Add("year", 2019);

            // act
            int fine = Day26_Nested_Logic.Solution.CalculateFine(returnDate, dueDate);

            // assert
            Assert.AreEqual(fine, 0);
        }

        [TestMethod]
        public void CalculateFine_1DayLate_Return15()
        {
            // arrange
            Dictionary<string, int> dueDate = new Dictionary<string, int>();
            dueDate.Add("day", 15);
            dueDate.Add("month", 7);
            dueDate.Add("year", 2019);
            Dictionary<string, int> returnDate = new Dictionary<string, int>();
            returnDate.Add("day", 16);
            returnDate.Add("month", 7);
            returnDate.Add("year", 2019);

            // act
            int fine = Day26_Nested_Logic.Solution.CalculateFine(returnDate, dueDate);

            // assert
            Assert.AreEqual(fine, 15);
        }
        
        [TestMethod]
        public void CalculateFine_1MonthLate_Return500()
        {
            // arrange
            Dictionary<string, int> dueDate = new Dictionary<string, int>();
            dueDate.Add("day", 15);
            dueDate.Add("month", 7);
            dueDate.Add("year", 2019);
            Dictionary<string, int> returnDate = new Dictionary<string, int>();
            returnDate.Add("day", 16);
            returnDate.Add("month", 8);
            returnDate.Add("year", 2019);

            // act
            int fine = Day26_Nested_Logic.Solution.CalculateFine(returnDate, dueDate);

            // assert
            Assert.AreEqual(fine, 500);
        }

        [TestMethod]
        public void CalculateFine_1YearLate_Return10000()
        {
            // arrange
            Dictionary<string, int> dueDate = new Dictionary<string, int>();
            dueDate.Add("day", 15);
            dueDate.Add("month", 7);
            dueDate.Add("year", 2019);
            Dictionary<string, int> returnDate = new Dictionary<string, int>();
            returnDate.Add("day", 16);
            returnDate.Add("month", 8);
            returnDate.Add("year", 2020);

            // act
            int fine = Day26_Nested_Logic.Solution.CalculateFine(returnDate, dueDate);

            // assert
            Assert.AreEqual(fine, 10000);
        }

        [TestMethod]
        public void CalculateFine_1DayEarly_DiffMonth_DiffYear_Return10000()
        {
            // arrange
            Dictionary<string, int> dueDate = new Dictionary<string, int>();
            dueDate.Add("day", 1);
            dueDate.Add("month", 1);
            dueDate.Add("year", 2010);
            Dictionary<string, int> returnDate = new Dictionary<string, int>();
            returnDate.Add("day", 31);
            returnDate.Add("month", 12);
            returnDate.Add("year", 2009);

            // act
            int fine = Day26_Nested_Logic.Solution.CalculateFine(returnDate, dueDate);

            // assert
            Assert.AreEqual(fine, 0);
        }
    }
}
