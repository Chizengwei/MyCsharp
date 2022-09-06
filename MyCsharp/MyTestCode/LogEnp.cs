using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using NUnit.Framework;

namespace MyCsharp.MyTestCode
{
    public class LogEnp
    {
        public static void Excute()
        {
            Console.Out.WriteLine("Op");
        }
    }

    [TestFixture]
    public class BankAcount
    {
        [Test]
        public void Deposes()
        {
            Assert.That(BlankAcount.Counter(40));
            MessageBox.Show("测试案例执行");
        }
        

        [Test]
        public void LogTest()
        {
            Console.Out.WriteLine($"Log{typeof(BankAcount)}");
        }
    }
}