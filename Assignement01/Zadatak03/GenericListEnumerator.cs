using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak03
{
    class GenericListEnumerator<T> : IEnumerator<T>
    {
        private T generic;
        private int index;
        private GenericList<T> genL;

        public GenericListEnumerator(GenericList<T> l){
            genL = l;
            generic = default(T);
            index = -1;
        }

        public T Current
        {
            get
            {
               return generic ;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (index++ >= genL.Count )
            {
                return false;
            }
            else
            {
               generic  = genL.ElementAt(index);
            }
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
