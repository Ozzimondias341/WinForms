using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void Extract(System.Windows.Forms.CheckedListBox list)
        {
            if (list.Items.Count == 0) return;

            for(int i = 0;i < 7; i++)
            {
                int d = ((1 << i) & days);
                list.SetItemChecked(i, Convert.ToBoolean(d));
            }
        }

        public bool Contains(byte day)
        {
            if (days == 0) day = 7;
            day--;
            return (days & (1 << day)) != 0; 
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

        public byte GetMask() => days;
    }
}
