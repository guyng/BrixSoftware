using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solutions
{
	public class Solution1
	{
		private ConcurrentQueue<Order> deskQueue = new ConcurrentQueue<Order>();
		private static Random random = new Random((int)DateTime.Now.Ticks);
		private int numOfCashier = 5;

		public Solution1()
		{
			StartProccessing();
		}

		public void StartProccessing()
		{
			Task.Run(() => EnqueToDesk());
			Task.Run(() => DequeFromDesk());
		}

		public void EnqueToDesk()
		{
			while (true)
			{
				deskQueue.Enqueue(new Order());
				Console.WriteLine("Enqued order to desk queue");
				Thread.Sleep(1000); // 1 Second
			}
		}

		public void DequeFromDesk()
		{
			Thread.Sleep(1000 * numOfCashier);
			while (true)
			{
				deskQueue.TryDequeue(out var result);
				Console.WriteLine("Dequeued order from the desk Queue");
				Thread.Sleep(1000);
			}
		}




	}
}
