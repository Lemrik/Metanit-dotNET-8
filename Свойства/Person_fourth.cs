using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Свойства
{
    internal class Person_fourth
    {
        string name = "";
        public string Name
        {
            get { return name; }

            private set { name = value; }
        }
        public Person_fourth(string name) => Name = name;
    }
}

/*
    Теперь закрытый блок set мы сможем использовать только в данном классе - в его методах, свойствах, конструкторе, но никак не в другом классе:

    При использовании модификаторов в свойствах следует учитывать ряд ограничений:

    Модификатор для блока set или get можно установить, если свойство имеет оба блока (и set, и get)

    Только один блок set или get может иметь модификатор доступа, но не оба сразу

    Модификатор доступа блока set или get должен быть более ограничивающим, 
    чем модификатор доступа свойства. Например, если свойство имеет модификатор public, 
    то блок set/get может иметь только модификаторы protected internal, internal, protected, private protected и private
 */

