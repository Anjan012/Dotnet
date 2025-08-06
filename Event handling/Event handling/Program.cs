using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_handling
{
    internal class Program
    {
        public delegate void Notify();
        public class Process
        {
            public event Notify ProcessCompleted;
            public void StartProcess()
            {
                Console.WriteLine("Process Started!");
                System.Threading.Thread.Sleep(2000);
                OnProcessCompleted();
            }
            protected virtual void OnProcessCompleted()
            { ProcessCompleted?.Invoke(); }
        }
        public class Subscriber
        {
            public void OnProcessCompleted()
            { Console.WriteLine("Process Completed!"); }
        }

        static void Main(string[] args)
        {
            Process process = new Process();
            Subscriber subscriber = new Subscriber();
            process.ProcessCompleted += subscriber.OnProcessCompleted;
            process.StartProcess();

        }
    }
}
