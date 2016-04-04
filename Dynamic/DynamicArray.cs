using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaliiR
{
    public class DynamicArray<T> : IDynamicArray<T>
    {
        protected int size = 0;
        protected T[] array;

        public DynamicArray ()
        {
            array = new T[1];
        }

        public int Capacity
        {
            get { return array.Length; }
        }

        public int Size
        {
            get { return size; }
             set { size = value; }
        }

        public void Add(T value)
        {
            if (Size >= Capacity)
            {
                ResizeArray();
            }
                array[Size] = value;
                Size++;     
        }

        public void Insert(int index, T value)
        {
            if (!(index >= 0 && index <= Size))
            {
                return;
            }
            else
            {
                if(Size >= Capacity)
                {
                    ResizeArray();
                }
                
                size++;
                T shiftValue = value;

                for(int i = 0; i < Size; i++)
                {
                    if(i >= index)
                    {
                        T temp = array[i];
                        array[i] = shiftValue;
                        shiftValue = temp;
                    }
                }
            }
        }

        public T Get(int index)
        {
           if(index >=0 && index < Size)
          {
              return array[index];
          }
         else 
          {
               return default(T);
          }
            
        }

        public void Remove(int index)
        {
            if (index <= 0 && index >= Size)
            {
                return;
            }
            else if(index >= Size)
            {
                Console.WriteLine("Index is out of array bounds");
            }
            else
            {
                for (int i = index; i <= Size; i++)
                {
                    array[i] = array[i + 1];                 
                }
                size--; 
            }
        }  

        private void ResizeArray()
        {
            T[] resizedArray = new T[Capacity * 2];
            for (int i = 0; i < Size; i++)
            {
                resizedArray[i] = array[i];
            }
            array = resizedArray;
        }

        public bool IsEmpty()
        {
            if (Size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Content:");
                for (int i = 0; i < Size; i++)
                {
                    Console.Write(" |{0}| \n", array[i]);
                }
            }
            else
            {
                Console.WriteLine("Stack/Queue is empty!");
            }
        }
    }
}
