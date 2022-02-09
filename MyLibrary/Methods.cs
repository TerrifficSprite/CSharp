using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace MyLibrary
{
    public class Methods
    {
        public int NumFromKeyboard(string text)
        {
            while (true)
            {
                try
                {
                    Console.Write(text);
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("*****\nВводити можна тiльки числа!\n*****");
                }
            }

        }

        public void PrintArrayList(ArrayList list)
        {
            Console.WriteLine(ReturnArrayListToString(list));
        }

        public string ReturnArrayListToString(ArrayList list)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    builder.Append("[" + list[i]);
                    goto Skip;
                }
                if (i == list.Count - 1)
                    builder.Append(", " + list[i] + "]");
                else
                    builder.Append(", " + list[i]);
                Skip: ;
            }
            return builder.ToString();
        }
        
    }
}