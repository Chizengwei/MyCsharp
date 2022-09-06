using System.Collections;
using System.Collections.Generic;

namespace MyCsharp.MyTestCode
{
    public class MyEnumarableDemo : IEnumerable<object>
    {
        public IEnumerator<object> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class MyEnumerator : IEnumerator<string>
    {
        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return true;
        }

        public void Reset()
        {
        }

        public string Current { get; }

        object IEnumerator.Current => Current;
    }
}