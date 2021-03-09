using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
       T[] items;
        //Constructor
        public MyList()
        {
            items = new T[0];   
        }
       public void Add(T item)
        {
            T[] tempArray = items; //class ve diziler ile liste yapımı //

            items = new T[items.Length+1  ];


            for (int i = 0; i < tempArray.Length; i++) //geçici depoladığı dizi, bilgileri ana diziye geri koyuyor
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

       
    }
}
