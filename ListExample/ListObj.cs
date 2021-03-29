using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExample
{
    public class ListObj<T> where T : class, IElement
    {
        private readonly string _name;

        public List<T> Elements { get; set; } = new List<T>();

        public ListObj(string name)
        {
            _name = name;
        }

        public ListObj(List<T> list, string name) : this(name)
        {
            Elements = list;
        }

        public List<string> ListNames => Elements.Select(p => p.Name).ToList();

        public T this[int index]
        {
            get
            {
                return TakeElement(index);
            }
        }

        public T this[string name]
        {
            get
            {
                return TakeElement(name);
            }
        }

        public T TakeElement(int index)
        {
            try
            {
                return Elements[index];
            }
            catch
            {
                return default(T);
            }
        }

        public T TakeElement(string name)
        {
            var index = FindIndex(name);
            return Elements[index];
        }

        public int FindIndex(string value)
        {
            var listName = string.Empty;
            if (string.IsNullOrEmpty(_name))
            {
                listName = value.GetType().ToString();
            }

            int index = ListNames.FindIndex(p => p.Equals(value));
            if (index < 0)
            {
                throw new Exception($"In list of {listName}'s cannot find '{value}'");
            }

            return index;
        }
    }
}
