using System;
using System.Collections;

namespace InterfacesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IMessageService service = new ConsoleMessageService();
            //((IPrinter(service).Print();
            (service as IPrinter).Print();
            (service as IMessageService).Print();
            //Создать класс своей собственной коллекции.Или просто класс, который реализует интерфейс IList. 
            //Реализовать в нём все методы и свойства таким образом, чтобы объектами этого класса 
            //можно было пользоваться в коде удобнее, чем просто пользоваться массивом*/

            IList list = new TestClass();

            //(list as IList).Add(1);
            //(list as IList).Add(2);
            //(list as IList).Add(3);


        }
    }
}
