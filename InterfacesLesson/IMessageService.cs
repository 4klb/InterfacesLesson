using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesLesson
{
    public interface IMessageService
    {
        //Интерфейс - это контракт, который говорит, что нужно делать,
        //но не говорит как это делать
        //может содержать только методы и свойства
        //приватные методы,конструкторы, переменные не может содежать
        
        //Интерфейсы не могут иметь 
        public int Number { get; set; }
        public void Print();
        public int GetNumber();
        public string PrintTypeName();
    }
}
