using System;
namespace DataStructureNew
{
    public class LinkedList
    {
        
            private Node root;

            public int Lenght { get; private set; }

            public LinkedList()
            {
                root = null;
                Lenght = 0;
            }

            public LinkedList(int a)
            {
                root = new Node(a);
                Lenght = 1;
            }

            public void AddAtTheEnd(int a)
            {
                if (Lenght == 0)//(root==null)
                {
                    root = new Node(a);
                    Lenght = 1;
                }
                else if (Lenght == 1)//(root!=null&&root.Next==null)
                {
                    root.Next = new Node(a);
                    Lenght++;
                }
                else
                {
                    Node tmp = root;
                    while (tmp.Next != null)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Next = new Node(a);
                    Lenght++;
                }
            }

            public int[] ReturnArray()
            {
                int[] array = new int[Lenght];
                if (Lenght != 0)
                {
                    int i = 0;
                    Node tmp = root;
                    do
                    {
                        array[i] = tmp.Value;
                        i++;
                        tmp = tmp.Next;
                    } while (tmp != null);
                }
                return array;
            }

            public void AddAtTheBeggining(int a)
            {
                Node tmp = new Node(a);
                tmp.Next = root;
                root = tmp;
                Lenght++;
            }
        }
    }

