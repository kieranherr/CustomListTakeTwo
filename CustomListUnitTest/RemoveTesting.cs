using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class RemoveTesting
    {
        [TestMethod]
        public void Remove_RemoveTwoFromList_Count2()
        {
            CustomList<int> customList = new CustomList<int>();
            int value1 = 4;
            int expected = 2;
            int actual;

            customList.Add(value1);
            customList.Add(value1);
            customList.Add(value1);
            customList.Add(value1);

            customList.Remove(value1);
            customList.Remove(value1);
            actual = customList.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveTwoFromList_Capacity4()
        {
            CustomList<int> customList = new CustomList<int>();
            int value1 = 6;
            int expected = 4;
            int actual;

            customList.Add(value1);
            customList.Add(value1);
            customList.Add(value1);
            customList.Add(value1);

            customList.Remove(value1);
            customList.Remove(value1);
            actual = customList.Capacity;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveTwoFromList_Capacity8()
        {
            CustomList<int> customList = new CustomList<int>();
            int value1 = 6;
            int expected = 8;
            int actual;

            customList.Add(value1);
            customList.Add(value1);
            customList.Add(value1);
            customList.Add(value1);
            customList.Add(value1);

            customList.Remove(value1);
            customList.Remove(value1);
            actual = customList.Capacity;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveOneFromList_Count0()
        {
            CustomList<int> customList = new CustomList<int>();
            int value1 = 4;
            int expected = 0;
            int actual;

            customList.Add(value1);

            customList.Remove(value1);

            actual = customList.Count;

            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void Remove_RemoveFromList_Index0()
        //{
        //    CustomList<int> customList = new CustomList<int>();
        //    int value1 = 6;
        //    int value2 = 5;
        //    int value3 = 7;
        //    int value4 = 9;
        //    int expected = 0;
        //    int actual;

        //    customList.Add(value1);
        //    customList.Add(value2);
        //    customList.Add(value3);
        //    customList.Add(value4);

        //    customList.Remove(value1);

        //    actual = customList.IndexOf(value2);

        //    Assert.AreEqual(expected, actual);
        //}
    }
}
