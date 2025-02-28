//using System;
//using System.Diagnostics.SymbolStore;


//namespace ConsoleAppwipro.Day7
//{
//    public delegate void Notify();
//    public class ProcessBusinessLogic
//    {
//        public event Notify ProcessCompleted;

//        public void StartProcess()
//        {
//            Console.WriteLine("Process Started!");
//            OnProcessCompleted();
//        }

//        protected virtual void OnProcessCompleted()
//        {
//            if (ProcessCompleted != null)
//                ProcessCompleted.Invoke();
//        }
//    }

//    public class Subscriber
//    {
//        public void OnProcessCompleted()
//        {
//            Console.WriteLine("Process Completed!");
//        }
//    }

//    internal class Evente_demo
//    {
//        static void Main(string[] args)
//        {
//            ProcessBusinessLogic bl = new ProcessBusinessLogic();
//            Subscriber s = new Subscriber();

//            bl.ProcessCompleted += s.OnProcessCompleted;
//            bl.StartProcess();
//        }
//    }
//}

//  =====================================================================================================================


//using System;

//public class MyTest
//{
//    public event EventHandler MyEvent
//    {
//        add
//        {
//            Console.WriteLine("add operation");
//        }
//        remove
//        {
//            Console.WriteLine("remove operation");
//        }
//    }
//}
//public class Test
//{
//    public void TestEvent()
//    {
//        MyTest myTest = new MyTest();
//        myTest.MyEvent += myTest_MyEvent;
//        myTest.MyEvent -= myTest_MyEvent;
//    }
//    public void myTest_MyEvent(object sender, EventArgs e)
//    {
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Test test = new Test();
//        test.TestEvent();
//        Console.ReadKey();
//    }
//}