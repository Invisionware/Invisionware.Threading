using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nito.AsyncEx;

namespace Invisionware.Threading.Console
{
    class Program
    {
        static void Main(string[] args)
        {
			System.Console.WriteLine("Starting");

			AsyncContext.Run(() => TestCase());

			System.Console.WriteLine("Done");
			System.Console.ReadLine();
		}

		static async Task TestCase()
		{
			var list = new List<Task>();

			var taskLocal = new TaskLocal<long>();

			for (int i = 0; i < 10; i++)
			{
				list.Add(Task.Factory.StartNew(async () =>
				{
					taskLocal.Value = DateTime.Now.Ticks;
					System.Console.WriteLine("Task Local Value Before : {0}", taskLocal.Value);

					Task.Delay(1000);

					System.Console.WriteLine("Task Local Value After : {0}", taskLocal.Value);
				}));
			}

			await Task.WhenAll(list.ToArray());

        }
    }
}
