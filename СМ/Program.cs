using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using IhorHolovatsky_Lists;

namespace СМ
{
    class Program
    {
        static void Main(string[] args)
        {

            var stream = new FileStream("INPUT.txt", FileMode.Open);
            var reader = new StreamReader(stream);
           
            var bytes = reader.ReadToEnd();

            int oneCounter = 0;
            int oneMax = 0;
            for (int i =0; i< bytes.Length; i++)
            {
                if (bytes[i] == '1')
                    oneCounter++;
                else
                {
                    if (oneCounter > oneMax)
                        oneMax = oneCounter;
                    oneCounter = 0;
                }
            }
            oneMax = oneMax > oneCounter ? oneMax : oneCounter;
            Console.WriteLine(oneMax);
            Console.ReadLine();
        }
    }
       }
