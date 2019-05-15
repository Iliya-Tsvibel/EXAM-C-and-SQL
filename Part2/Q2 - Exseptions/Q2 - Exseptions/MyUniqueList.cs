using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2___Exseptions
{
    class MyUniqueList
    {
        List<int> list = new List<int>();


        public MyUniqueList()
        {

        }

        public bool Add(int item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }

            else
            {

                throw new ItemAlreadyExistException();
            }

        }

        public bool Remove(int item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return true;
            }

            else
            {

                throw new ItemNotFoundException();

            }
        }

       

        public int Peek(int index)
        {
            if (index > list.Count())
                throw new IndexOutOfRangeException();

            return list[index];
        }

        public int this[int index]
        {
            get
            {
                if (index > list.Count())
                    throw new IndexOutOfRangeException();

                return this.list[index];
            }
            set
            {
                if (index > list.Count())
                    throw new IndexOutOfRangeException();

                if (list[index] == value)
                    return;
                if (list.Contains(value))
                    return;
                list[index] = value;
            }
        }
    }
}
