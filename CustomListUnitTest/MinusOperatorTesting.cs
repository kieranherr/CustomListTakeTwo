using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListUnitTest
{
    [TestClass]
    public class MinusOperatorTesting
    {
        [TestMethod]
        public void Minus_MinusTwoLists_Count2()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int expected = 2;

            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(1);
            list2.Add(6);


            actual = list1 - list2;

            Assert.AreEqual(expected, actual.Count);
        }
        [TestMethod]
        public void Minus_MinusTwoLists_Capacity4()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int expected = 4;

            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(1);
            list2.Add(6);


            
            actual = list1 - list2;

            Assert.AreEqual(expected, actual.Capacity);
        }
        [TestMethod]
        public void Minus_MinusTwoLists_Index1()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int expected = 5;


            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(1);
            list2.Add(6);



            actual = list1 - list2;

            Assert.AreEqual(expected, actual[1]);
        }
    }
}
