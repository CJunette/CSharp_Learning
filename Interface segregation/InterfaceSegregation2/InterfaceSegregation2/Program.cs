using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//This case shows how to create a custom IEnumerable only(no ICollection) class and use that class to demonstrate the disobey of interface segregation.
namespace InterfaceSegregation2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };

            //2. What we need to do is to use the method Sum() on a ReadOnlyCollection instance. The Sum() method requires the class to be enumerabled.
            //18. Add the IEnumerable needed for the constructor of ReadOnlyCollection.
            ReadOnlyCollection collection = new ReadOnlyCollection(nums1);
            //19. The program.
            Console.WriteLine(Sum(collection));
        }

        //If I use "ICollection" here, the program will report error. Because that interface contains some more methods other than IEnumerable methods.
        //And the instance is of IEnumerable.
        //This method actually only uses the methods in IEnumerable, which means other methods in ICollection is useless here and they blocked instances
        //of IEnumerable to function here.
        //To correct it, just change "ICollection" into "IEnumerable".
        static int Sum(ICollection collection)
        {
            int count = 0;
            foreach (var i in collection)
            {
                count += (int)i;
            }
            return count;
        }
    }

    //1.Create a class that is the derivative class of IEnumerable but not of ICollection.
    class ReadOnlyCollection : IEnumerable
    {
        //9. The _array_2 should be passed in when ReadOnlyCollection is created. So we need an variable and a constructor.
        private int[] _array_1;
        public ReadOnlyCollection(IEnumerable array)
        {
            //10. I need to make sure all both int[] and ArrayList could be passed in.
            //11. First I need to know the length of it. And because it is IEnumerable, there is no ".length()". I need to use an old way.
            int count = 0;
            foreach (var n in array)
            {
                count += 1;
            }
            //12. Create an array to temporary copy the array.
            int[] store = new int[count];
            count = 0;

            foreach (var n in array)
            {
                store[count] = (int)n;
                count++;
            }
            //13. Initialize _array_1.
            _array_1 = store;
        }

        //3. IEnumerable requires a method called GetEnumerator(). GetEnumerator() requires a Inumerator return object.
        public IEnumerator GetEnumerator()
        {
            //14. Now, pass _array_1 into the constructor.
            return new Enumerator(_array_1);
        }

        //4. Create the return object based on IEnumerator.
        public class Enumerator : IEnumerator
        {
            //7. Create the variable to store the enumerable object.(I decide to use int[]) And an int variable to do enumeration.
            private int[] _array_2;
            private int _head;

            //8. The _array_2 should be passed in when we create the Enumerator. And the _head should be -1 because that is the start number.
            public Enumerator(int[] array)
            {
                _array_2 = array;
                _head = -1;
            }

            //5. IEnumerator require attribute Current, method MoveNext() and method Reset().
            //6. Current requires a get() method.(no set method because I don't wnat it to be changed). get() requires an object to return.(the current
            //enumerated object). So I need an object to be enumerated.
            public object Current
            {
                get
                {
                    //15. Now that we got the array, we can return the value it needs.
                    object o = _array_2[_head];
                    return o;
                }
            }

            public bool MoveNext()
            {
                //16. Finish MoveNext().
                if (++_head < _array_2.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                //17. Finish Reset().
                _head = -1;
            }
        }
    }

}
