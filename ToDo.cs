using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoWithEnums
{
    class ToDo
    {
        public string ThingToDo { get; private set; }

        public ToDo(string thingToDo)
        {
            ThingToDo = thingToDo;
        }
    }
}
