//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Security.Cryptography;


//namespace ConsoleAppwipro.Day5
//{
//    internal class Collections_demo
//    {
//        static void Main(string[] args)
//        {
//            //Stack s1 = new Stack();
//            //s1.Push(1);
//            //s1.Push(2);
//            //s1.Push(3);
//            //s1.Push(4);
//            //s1.Push(5);

//            ////foreach (var item in s1)
//            ////{
//            ////    Console.WriteLine(item);
//            ////}

//            //s1.Pop();

//            //Stack s2 = new Stack();
//            //s2.Push(7);
//            //s2.Push("Cristiano");
//            //s2.Push("Ronaldo");
//            //s2.Push("Football");
//            //s2.Push(7.77f);

//            ////foreach (var item in s2)
//            ////{
//            ////    Console.WriteLine(item);
//            ////}    

//            //Console.WriteLine("The count of s1 is: "+ s1.Count);
//            //Console.WriteLine("The top element os s2 is : "+ s2.Peek());

//            // ===================================================================================================================

//            //Queue q1 = new Queue();

//            //q1.Enqueue(1);
//            //q1.Enqueue(2);
//            //q1.Enqueue(3);
//            //q1.Enqueue(4);
//            //q1.Enqueue(5);

//            //Console.WriteLine("The Queue elements are:");

//            //foreach (var item in q1) 
//            //    Console.WriteLine(item);

//            //Console.WriteLine("The first element is queue is: " + q1.Peek());

//            //ArrayList arr1 = new ArrayList();
//            //arr1.Add(1);
//            //arr1.Add(2);
//            //arr1.Add(3);
//            //arr1.Add(4);

//            //Console.WriteLine("ArrayList elements are:");

//            //foreach (var i in arr1) 
//            //    Console.WriteLine(i);

//            //int[] myarr = new int[3] {10,20,30};

//            //arr1.AddRange(myarr);

//            //Console.WriteLine("Now the ArrayList elements are:");
//            //foreach(var i in arr1)
//            //    Console.WriteLine(i);

//            //arr1.Reverse();

//            //Console.WriteLine("ArrayList after reversing:");
//            //foreach (var i in arr1)
//            //    Console.WriteLine(i);

//            //Stack s2 = new Stack();
//            //s2.Push(7);
//            //s2.Push("Cristiano");
//            //s2.Push("Ronaldo");
//            //s2.Push("Football");
//            //s2.Push(7.77f);

//            //arr1.AddRange(s2);
//            //Console.WriteLine("Now the ArrayList elements after adding a stack:");
//            //foreach (var i in arr1)
//            //    Console.WriteLine(i);

//            //arr1.Remove(20);        //  removes the element 20 from the arraylist
//            //Console.WriteLine("After removing 20");
//            //foreach (var i in arr1)
//            //    Console.WriteLine(i);
//            //arr1.RemoveAt(0);   // will remove the element at the 0th index

//            //arr1.Remove(s2);          // not working
//            //Console.WriteLine("After removing the stack elements");
//            //foreach (var i in arr1)
//            //    Console.WriteLine(i);


//            // hashtable and sorted list

//            //Hashtable ht = new Hashtable();
//            //ht.Add("c", 3);
//            //ht.Add("a", 1);
//            //ht.Add("d", 4);
//            //ht.Add("b", 2);
            

//            //Console.WriteLine("All keys:");
//            //foreach(string  s in ht.Keys)
//            //{
//            //    Console.WriteLine(s);
//            //}

//            //Console.WriteLine("All Values:");
//            //foreach (int s in ht.Values)
//            //{
//            //    Console.WriteLine(s);
//            //}

//            //Console.WriteLine("All keys and Values:");
//            //foreach (DictionaryEntry item in ht)
//            //{
//            //    Console.WriteLine(item.Key + " " + item.Value);
//            //}

//            //string Searchkey = "c";
//            //foreach(var key in ht.Keys)
//            //{
//            //    if((string)key == Searchkey)
//            //    {
//            //        Console.WriteLine("Found key : "+key);
//            //        break;
//            //    }
//            //}

//            //Sorted List

//            //SortedList sl = new SortedList();
//            //sl.Add("Delhi", 2);
//            //sl.Add("Hosur", 3);
//            //sl.Add("Bangalore", 1);
//            //sl.Add("bangalore", 5);

//            //foreach(DictionaryEntry item in sl)
//            //{
//            //    Console.WriteLine(item.Key + " " + item.Value);
//            //}
//            //sl.Clear();
//            //foreach (DictionaryEntry item in sl)
//            //{
//            //    Console.WriteLine(item.Key + " " + item.Value);
//            //}
//            //sl.Add("Delhi", 2);
//            //sl.Add("Hosur", 3);
//            //sl.Add("Bangalore", 1);
//            //sl.Add("bangalore", 5);

//            //sl.Remove("Bangalore");
//            //sl.RemoveAt(2); // will remove hosur
//            //foreach (DictionaryEntry item in sl)
//            //{
//            //    Console.WriteLine(item.Key + " " + item.Value);
//            //}
//            //DictionaryEntry[] sortedListArray = new DictionaryEntry[sl.Count];
//            //sl.CopyTo(sortedListArray, 0);
//            //foreach(var  item in sortedListArray)
//            //    Console.WriteLine(item.Key + " " + item.Value);


//            // Generics

//            Stack<int> s = new Stack<int>();
//            Queue<int> q = new Queue<int>();
//            SortedList<int,int> sl = new SortedList<int,int>();
//            HashSet<int> list = new HashSet<int>();
//            List<int> list2 = new List<int>();
//            // Hashtable is not generic
//            // ArrayList is not generic


//        }
//    }
//}
