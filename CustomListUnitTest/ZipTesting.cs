using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class ZipTesting
    {
        [TestMethod]
        public void Zip_ZipTwoLists_Index1()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int expected = 2;

            list1.Add(1);
            list1.Add(3);
            list1.Add(5);


            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            list1.Zip(list2);

            Assert.AreEqual(expected, list1[1]);
        }
        [TestMethod]
        public void Zip_ZipTwoLists_Count6()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int expected = 6;

            list1.Add(1);
            list1.Add(3);
            list1.Add(5);


            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            list1.Zip(list2);

            Assert.AreEqual(expected, list1.Count);
        }
        [TestMethod]
        public void Zip_ZipTwoLists_Capacity8()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int expected = 8;

            list1.Add(1);
            list1.Add(3);
            list1.Add(5);


            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            list1.Zip(list2);

            Assert.AreEqual(expected, list1.Capacity);
        }
    }
}
