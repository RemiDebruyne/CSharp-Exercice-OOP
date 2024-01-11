using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePile.Classes
{
    internal class Pile<T>
    {
        private T[] _elementsInStack;
        private int _nbOfElementsInStack;


        public Pile()
        {
            _elementsInStack = Array.Empty<T>();
        }
        public Pile(int taille)
        {
            _elementsInStack = new T[taille];
        }

        public void Read()
        {
            foreach (T element in _elementsInStack)
            {
                if (element is not null && !element.Equals(default(T)))
                    Console.WriteLine(element);
            }
        }

        public void ReadNbOfElem()
        {
            Console.WriteLine(_nbOfElementsInStack);
        }
        public bool Add(T input)
        {
            if (_nbOfElementsInStack < _elementsInStack.Length)
            {
                _elementsInStack[_nbOfElementsInStack++] = input;
                return true;
            }

            return false;

        }

        public void Remove()
        {
            _elementsInStack[_nbOfElementsInStack--] = default;

        }

        public void RemoveBydIndex(int index)
        {
            if (_elementsInStack[index] == null)
                Console.WriteLine("Index is empty");
            _elementsInStack[index] = default;
            _nbOfElementsInStack--;
        }

    }
}
