using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autocenter
{
    class TelaInicial
    {
        private int select;

        public TelaInicial(int select)
        {
            this.select = select;
        }

        public int getSelect()
        {
            return select;
        }
        public void setSelect(int s)
        {
            select = s;
        }
    }
}
