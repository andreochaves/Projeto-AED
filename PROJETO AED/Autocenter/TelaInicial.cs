using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autocenter
{
    class TelaInicial
    {
        private string select;
        

        public TelaInicial(string select)
        {
            this.select = select;
        }

        public string getSelect()
        {
            return select;
        }
        public void setSelect(string s)
        {
            select = s;
        }
    }
}
