using Tyuiu.CybenkoEA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.CybenkoEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageVaild()
        {
            var name = "Евгений";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Евгений", res);




        }


    }
}