using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesLesson
{
    class ConsoleMessageService : IMessageService, IPrinter
    {
        public int Number { get; set; }

        public int GetNumber()
        {
            //тело
            return 0;
        }

        public void Print()
        {
            //тело
        }

        void IMessageService.Print()
        {
            //тело
        }
        void IPrinter.Print()
        {
            //тело
        }

        public string PrintTypeName()
        {
            //тело
            return "0";
        }
    }
}
