﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gun4Odev5
{
    class MyDictionary<K, V>
    {
        public K[] keys;
        public V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

            Console.WriteLine("'" + key + ": " + value + "' eklendi.");

        }

        public void Print()
        {
            Console.WriteLine("\n+LISTE+");

            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + ": " + values[i]);
            }
        }


    }
}
