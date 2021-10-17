using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace martin_linkedlist
{
    class LinkedList
    {
        //Created different pointers to make my program more readable. 

        private Node _head;
        private Node _search;
        private Node _tail;
        private Node _temp;
        private Node _current;
        private bool foundData = true;
        private bool lostData = false;

        public void Add(string addData)
        {
            Node createNode = new Node();
            createNode.Data = addData;

            if (_head == null)
            {
                _head = createNode;
                return;
            }

            _current = _head;

            while (_current != null)
            {
                if (_current.Next == null)
                {
                    _current.Next = createNode;
                    return;
                }
                else
                {
                    _current = _current.Next;
                }
            }
        }

        public bool Remove(string removeData)
        {

            if (_head != null)
            {
                _current = _head;

                //Removes through the center.
                while (_current != null)
                {
                    if (_current.Next != null)
                    {
                        if (_current.Data == removeData)
                        {
                            // If any data matches that Node we store the next pointer.
                            _temp = _current.Next;
                            // We update the data from the createNode we want to remove.  
                            _current.Data = _temp.Data;
                            // Then we change the pointer to the _temp variable breaking the chain from the previous createNode.
                            _current.Next = _temp.Next;
                        }
                        _current = _current.Next;
                    }
                    else
                    {
                        _current = _current.Next;
                    }
                }

                // I had to run the tail in a seperate while loop because I was running into the issues of the next createNode throwing an exception error. 
                // I would run into the issue if a user put in multiple of the same item so I check the tail at the end.

                _tail = _head;

                while (_tail != null)
                {
                    if (_tail.Next != null)
                    {

                        if (_tail.Next.Data == removeData)
                        {
                            _tail.Next = null;
                            break;
                        }
                        _tail = _tail.Next;
                    }
                    else
                    {
                        _tail = _tail.Next;
                    }
                }

                if (_head.Data == removeData)
                {
                    if (_head.Next != null)
                    {
                        _temp = _head.Next;
                        _head.Data = _temp.Data;
                        _head.Next = _temp.Next;
                    }
                    else
                    {
                        _head = null;
                    }
                }
            }
            else
            {
                return lostData;
            }
            return foundData;
        }
                
        public bool Contains(string containData)
        {
            _search = _head;

            while (_search != null)
            { 
                if (_search.Data == containData)
                {
                    return foundData;
                }
                _search = _search.Next;
            }
            return lostData;
        }

        public void PrintAllNodes()
        {
            if(_head == null)
            {
                Console.WriteLine("No Data Found.");
            }

            Node CurrentNode = _head;

            while (CurrentNode != null)
            {
                Console.WriteLine(CurrentNode.Data);
                if (CurrentNode.Next != null)
                    CurrentNode = CurrentNode.Next;
                else
                    break;
            }
        }
    }
}
