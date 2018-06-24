using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4_практика
{
    class Program
    {
        static void Main(string[] args)
        {
            int osn= 2;
            int step = 200;
            string buf = "2";
            string buf2 = "";
            char c =' ';
            int  k, a, b, len;
            for(int i=0;i<step;i++)
            {
                buf2 = buf;
                len = buf2.Length;
                buf = " ";
                k = 0;
                for(int j=0;j<len;j++)
                {
                    a= (Convert.ToInt32(buf[j]) ) * osn + k;
                    b= a %10;
                    k= a / 10;
                    buf= buf + Convert.ToChar((int)b+48 );
                    
                }
                if (k != 0)
                    buf = buf + Convert.ToChar((int)k +48);

            }
            len= buf.Length-1;
            for ( int i= 0; i<(len/2); i++)
                {
                    c= buf[len - i ];
                buf.Replace(buf[len - i ], buf[i]);
                    buf.Replace(buf[i], c);
                }

            Console.WriteLine((buf));
            


            

            

        }
    }
}
