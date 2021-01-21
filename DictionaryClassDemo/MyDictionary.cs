﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryClassDemo
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] Keys;
        TValue[] Values;

        public MyDictionary()
        {
            Keys = new TKey[0];
            Values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < Keys.Length; i++)
            {
                if (Keys[i].Equals(key))
                {
                    throw new ArgumentException("Aynı anahtara sahip öğe zaten eklenmiş.");
                }
            }
            TKey[] tempKey = Keys;
            TValue[] tempValue = Values;

            Keys = new TKey[Keys.Length + 1];
            Values = new TValue[Values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                Keys[i] = tempKey[i];
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                Values[i] = tempValue[i];
            }

            Keys[Keys.Length - 1] = key;
            Values[Values.Length - 1] = value;

        }

        public int Count()
        {
            return Keys.Length;
        }

        public TKey GetKey(TValue value)
        {
            int index = Array.IndexOf(Values, value);
            return Keys[index];
        }

        public TValue GetValue(TKey key)
        {
            int index = Array.IndexOf(Keys, key);
            return Values[index];
        }

    }
}
