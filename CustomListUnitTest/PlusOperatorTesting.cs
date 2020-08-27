using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class PlusOperatorTesting
    {
        [TestMethod]
        public void Plus_AddTwoListsTogether_Count6()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int expected = 6;

            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);


            actual.Capacity = list1.Capacity + list2.Capacity;
            actual = list1 + list2;

            Assert.AreEqual(expected, actual.Count);
        }
        [TestMethod]
        public void Plus_AddTwoListsTogether_Capacity8()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int expected = 8;

            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);


            actual.Capacity = list1.Capacity + list2.Capacity;
            actual = list1 + list2;

            Assert.AreEqual(expected, actual.Capacity);
        }
        [TestMethod]
        public void Plus_AddTwoListsTogether_Index4()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int expected = 4;
            

            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);


            actual.Capacity = list1.Capacity + list2.Capacity;
            actual = list1 + list2;

            Assert.AreEqual(expected, actual[4]);
        }
    }
}
