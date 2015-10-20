using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS237InClass4
{
    class GenericNode<T>  //T means Type
    {
        //2 properties

        public GenericNode<T> Next //next is the pointer 
        {
            get;
            set;
        }

        public T Data                      //"string" could be anything eg object
        {
            get;
            set;
        }
    }
}
