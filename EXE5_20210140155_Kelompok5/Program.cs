using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140155_Kelompok5
{
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node nur, azizah;

        public queue()
        {
            nur = null;
            azizah = null;
        }
        public void insert()
        {
            string k5;
            Node kel5 = new Node();
            Console.WriteLine("Masukkan element data");
            k5 = Console.ReadLine();
            kel5.name = k5;
            kel5.next = null;
            if (nur == null)
            {
                nur = kel5;
                azizah = kel5;
            }
            nur.next = kel5;
            nur = kel5;
        }
        public void delete()
        {
            if (nur == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            nur = nur.next;
            if (nur == null)
                azizah = null;
        }
        public void display()
        {
            if (nur == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

        }
    }
}

   