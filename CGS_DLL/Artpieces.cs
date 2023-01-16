using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CGS_DLL
{
    class Artpieces: CollectionBase // this class is used for data structure, it handles data
    {
        public void add(Artpiece artpiece)
        {
            List.Add(artpiece);
        }

        public Artpiece this[int index] // indexer
        {
            get { return (Artpiece)List[index]; }
            set { List[index] = value; }
        }
    }
}
