using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linqprograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[5] { "hi","dileep","how","are","you"};
            var myLinqQuery = from name in str
                              where name.Length>2
                              select name;

            // Query Execution
            foreach (var name in myLinqQuery)
                Console.WriteLine(name);

            //Filtering
            int[] arr=new int[] { 1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("The array is:");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            var enums=arr.Where(x=>x%2==0);
            var onums= arr.Where(x => x % 2 != 0);
            Console.WriteLine("Even Numbers");
            foreach(var i in enums )
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Odd Numbers");
            foreach (var i in onums)
            {
                Console.WriteLine(i);
            }
            var asec = arr.OrderBy(x=>x);
            Console.WriteLine("Ascending order( OrderBy() ):");
            foreach (var i in asec)
            {
                Console.WriteLine(i);
            }
            var desc = arr.OrderByDescending(x=>x);
            Console.WriteLine("Descending order( OrderByDescending() ):");
            foreach (var i in desc) Console.WriteLine(i);
            





            char[] sequence1 = {'m', 'q', 'o',
                           's', 'y', 'a','s'};

            char[] sequence2 = {'p', 't', 'r',
                           's', 'y', 'z','p'};

            // Display the sequences 
            Console.WriteLine("Set Operations:");
            Console.WriteLine("Union,intersect,distinct,except");
            Console.WriteLine("Sequence 1 is: ");

            foreach (var s1 in sequence1)
            {
                Console.WriteLine(s1);
            }

            Console.WriteLine("Sequence 2 is: ");

            foreach (var s2 in sequence2)
            {
                Console.WriteLine(s2);
            }
            Console.WriteLine("After Distinct Operation:");
            var res = sequence1.Distinct();
            foreach (var s in res) Console.WriteLine(s);

            var res1=sequence1.Intersect(sequence2);
            Console.WriteLine("After Intersection Operation:");
            foreach(var s in res1) Console.WriteLine(s);

            var res2 = sequence1.Union(sequence2);
            Console.WriteLine("After Union Operation:");
            foreach (var s in res2) Console.WriteLine(s);

            var res3 = sequence1.Except(sequence2);
            Console.WriteLine("After Except Operation(seq1-seq2):");
            foreach (var s in res3) Console.WriteLine(s);

            var res4 = sequence2.Except(sequence1);
            Console.WriteLine("After Except Operation(seq2-seq1):");
            foreach (var s in res3) Console.WriteLine(s);

            //The LINQ Standard Query Operator supports 8 types of element operators:

            //ElementAt
            //ElementAtOrDefault
            //First
            //FirstOrDefault
            //Last
            //LastOrDefault
            //Single
            //SingleOrDefault

        }
    }
}
