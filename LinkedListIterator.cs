using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class LinkedListIterator<List>: Iterator<List>
    {
        private Node<List> iterNode;

        internal LinkedListIterator(Node<List> headNode)
        {
            iterNode = headNode;
        }

      
    public bool hasNext()
        {
            return iterNode != null;
        }

        
    public List next()
        {
            List data = iterNode.data;
            iterNode = iterNode.next;
            return data;
        }
    }
}