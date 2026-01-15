using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Week
    {
        static readonly string[] NAMES = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
        public byte days;
        public Week(byte days) 
        {
            this.days = days;
        }
        public override string ToString()
        {
            string days = "";

            for (byte i = 0; i < 7; i++)
            {
                byte day = (byte)(1 << i);
                if ((this.days & day) != 0) days += $"{NAMES[i]}, ";
            }

            /*
             ~ NOT - побитовое орицание(инверсия - унарная операция при которой 1 заменяется 0 и наоборот)
             | OR - побитовое сложение
             & AND - побитовое умножение
             ^ XOR - исключающее OR. 1 даёт только 1 и 0, но не 1 и 1 \ 0 и 0
             */

            return days;
        }
    }
}
