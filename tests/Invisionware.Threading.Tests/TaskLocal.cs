using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Invisionware.Threading.Tests
{
    [TestFixture]
    public class TaskLocalTests
    {
        [SetUp]
        public void Initialize()
        {
        }

        [Test]
        public async Task TaskLocalTest()
        {
            var list = new List<Task>();

            var taskLocal = new TaskLocal<long>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(Task.Factory.StartNew(async () =>
                                                   {
                                                       long v = DateTime.Now.Ticks;

                                                       taskLocal.Value = v;
                                                       Console.WriteLine("Task Local Value Before : {0}", taskLocal.Value);

                                                       await Task.Delay(100);

                                                       Console.WriteLine("Task Local Value After : {0}", taskLocal.Value);

                                                       Assert.AreEqual(v, taskLocal.Value);
                                                   }));
            }

            await Task.WhenAll(list.ToArray());
        }
    }
}
