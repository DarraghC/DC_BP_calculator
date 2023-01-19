using BPCalculator;
using NUnit.Framework;


namespace Tests_Project
{
    public class Tests
    {

        [Test]
        public void Test_Category_returns_Low()
        {
            BloodPressure bloodPressure = new BloodPressure{Systolic = 90, Diastolic = 50 };
            Assert.That(bloodPressure.Category, Is.EqualTo(BPCategory.Low));
        }



        [Test]
        public void Test_Category_returns_Ideal()
        {
            BloodPressure bloodPressure = new BloodPressure{Systolic = 120, Diastolic = 80 };
            Assert.That(bloodPressure.Category, Is.EqualTo(BPCategory.Ideal));
        }

        [Test]
        public void Test_Category_returns_Pre_High()
        {
            BloodPressure bloodPressure = new BloodPressure{Systolic = 139, Diastolic = 89};
            Assert.That(bloodPressure.Category, Is.EqualTo(BPCategory.PreHigh));
        }

        [Test]
        public void Test_Category_returns_High()
        {
            BloodPressure bloodPressure = new BloodPressure{Systolic = 140, Diastolic = 90};
            Assert.That(bloodPressure.Category, Is.EqualTo(BPCategory.High));
        }

    }
}