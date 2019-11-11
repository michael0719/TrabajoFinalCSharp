using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALCHARP_VISTA_
{
    class Validar
    {
        public static void sololetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if(Char.IsSeparator(v.KeyChar)){
                v.Handled = false;
            }else
            {
                v.Handled = true;
            }
        }

        public static void solonumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }
    }
}
