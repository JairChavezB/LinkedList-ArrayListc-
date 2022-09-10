using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class ArrayListIterator<Arr>: Iterator<Arr>
    {
        private ArrayList<Arr> arrayList;
        private int iterItem;

        public ArrayListIterator(ArrayList<Arr> arrayList)
        {
            this.arrayList = arrayList;
        }

       
    public bool hasNext()
        {
            return iterItem < arrayList.getSize();
        }

        
    public Arr next()
        {
            Arr data = arrayList.getAt(iterItem);
            iterItem++;
            return data;
        }
    }
}