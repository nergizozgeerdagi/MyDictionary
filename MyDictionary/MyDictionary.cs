using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            int i = 0;
            while (i < tempKeys.Length)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
                i++;
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public TKey[] Keys
        {
            get { return keys; }
        }

        public TValue[] Values
        {
            get { return values; }
        }

    }
}
