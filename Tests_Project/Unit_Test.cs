using BPCalculator;
using NUnit.Framework;

using BPCalculator;

namespace Tests_Project
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Category_returns_Low()
        {
            /*BloodPressure.Systolic.set = 80;
            BloodPressure.Diastolic.set = 50;
            Assert.AreEqual('Low', BloodPressure.BPCategory.Category.get(80, 50));*/
        }

        [Test]
        public void Test_Category_returns_Ideal()
        {

        }

        [Test]
        public void Test_Category_returns_Pre_High()
        {

        }

        [Test]
        public void Test_Category_returns_High()
        {

        }

        [Test]
        public void Test_Invalid_SystolicMin()
        {

        }

        [Test]
        public void Test_Invalid_SystolicMax()
        {

        }

        [Test]
        public void Test_Invalid_DiastolicMin()
        {

        }

        [Test]
        public void Test_Invalid_DiastolicMax()
        {

        }
    }
}