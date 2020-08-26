using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class AddTesting
    {
        [TestMethod]
        public void Add_AddTwoToList_Count2()
        {
            CustomList<int> customList = new CustomList<int>();
            int value1 = 4;
            int value2 = 5;
            int expected = 2;
            int actual;

            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddTwoToList_Capacity4()
        {
            CustomList<int> customList = new CustomList<int>();
            int value1 = 4;
            int value2 = 5;
            int expected = 4;
            int actual;

            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Capacity;

            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void Add_TempArray_Index()
        //{
        //    CustomList<int> customList = new CustomList<int>();
        //    int value1 = 4;
        //    int value2 = 5;
        //    int value3 = 7;
        //    int value4 = 9;
        //    int value5 = 12;
        //    int expected = 7;
        //    int actual;

        //    customList.Add(value1);
        //    customList.Add(value2);
        //    customList.Add(value3);
        //    customList.Add(value4);
        //    customList.Add(value5);
        //    actual = customList[0];

        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void Add_AddToList_Count10()
        {
            CustomList<int> customList = new CustomList<int>();
            int value1 = 4;
            int value2 = 5;
            int value3 = 7;
            int value4 = 9;
            int value5 = 12;
            int value6 = 4;
            int value7 = 5;
            int value8 = 7;
            int value9 = 9;
            int value10 = 12;
            int expected = 10;
            int actual;

            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Add(value6);
            customList.Add(value7);
            customList.Add(value8);
            customList.Add(value9);
            customList.Add(value10);
            actual = customList.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToList_Capacity8()
        {
            CustomList<int> customList = new CustomList<int>();
            int value1 = 4;
            int value2 = 5;
            int value3 = 7;
            int value4 = 9;
            int value5 = 12;
            int expected = 8;
            int actual;

            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            actual = customList.Capacity;

            Assert.AreEqual(expected, actual);
        }
    }
}
