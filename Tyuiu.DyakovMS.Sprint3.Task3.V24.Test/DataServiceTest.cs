using Tyuiu.DyakovMS.Sprint3.Task3.V24.Lib;

namespace Tyuiu.DyakovMS.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReplaceCharInStringTest()
        {
            DataService ds = new DataService();
            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '*';

            string res = ds.ReplaceCharInString(value, replaceable, replacement);

            string wait = "*ft h**t nt*";
            Assert.AreEqual(wait, res);
        }
    }
}