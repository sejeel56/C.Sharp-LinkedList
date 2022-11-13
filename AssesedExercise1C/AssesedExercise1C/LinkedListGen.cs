using System;

namespace AssesedExercise1C
{

    class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> list = null; //default value – empty list

        public void AddItem(T item) //add item to front of list
        {
            list = new LinkGen<T>(item, list);
        }

        public void AppendItem(T item)
        {
            LinkGen<T> temp = list;

            if (temp == null)
                list = new LinkGen<T>(item, list);
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new LinkGen<T>(item, list);
            }
        }
        public void RemoveItem(T item)
        {
            LinkGen<T> temp = list;
            LinkListGen<T> newList = new LinkListGen<T>();
            while (temp != null)
            {
                if (item.CompareTo(temp.Data) != 0)
                {
                    newList.AppendItem(temp.Data);

                }
                temp = temp.Next;
            }
            newList.list = list;
        }


        public int NumberOfItems() // returns number of items in list
            {
                LinkGen<T> temp = list;
                int count = 0;
                while (temp != null) // move one link and add 1 to count
                {
                    count++;
                    temp = temp.Next;
                }
                return count;
            }
            public bool IsPresentItem(int item)
            {
                LinkGen<T> temp = list;
                int count = 0;


                while (temp != null)
                {
                    if (item.CompareTo(temp.Data) == 0)
                    {
                        Console.WriteLine(item + " is in the List");

                        return true;
                    }
                    temp = temp.Next;
                }
                return false;
            }
        }
    }

