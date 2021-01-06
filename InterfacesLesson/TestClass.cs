using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfacesLesson
{
    public class TestClass : IList
    {
        private object[] contents = new object[10];
        private int count;

        public TestClass()
        {
            count = 0;
        }
        public object this[int index]
        {
            get
            {
                return contents[index];
            }
            set
            {
                contents[index] = value;
            }
        }

        public bool IsFixedSize 
        {
            get
            {
                return true;
            }
        } 

        public bool IsReadOnly 
        {
            get
            {
                return false;
            }
        } 

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public object SyncRoot
        {
            get
            {
                return this;
            }
        }

        public int Add(object value)
        {
            if (count < contents.Length)
            {
                contents[count] = value;
                count++;

                return (count - 1);
            }

            return -1;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < count; i++)
            {
                if (contents[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < count; i++)
            {
                array.SetValue(contents[i], index++);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return null;
        }

        public int IndexOf(object value)
        {
            for (int i = 0; i < count; i++)
            {
                if (contents[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, object value)
        {
            if ((count + 1 <= contents.Length) && (index < count) && (index >= 0))
            {
                count++;

                for (int i = count - 1; i > index; i--)
                {
                    contents[i] = contents[i - 1];
                }
                contents[index] = value;
            }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < count))
            {
                for (int i = index; i < count - 1; i++)
                {
                    contents[i] = contents[i + 1];
                }
                count--;
            }
        }
    }
}
