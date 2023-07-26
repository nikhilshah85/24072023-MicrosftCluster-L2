using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP.Entities
{
    internal class PF : Accounts 
    {
        int v_duration;

        public int Duration
        {
            get { return v_duration;  }
            set { v_duration = value; }
        
        }

        public override double Widraw(int p_amount)
        {
            if (p_amount > (AccountBalance * 0.8))
            {
                throw new Exception("You can widraw max " + (AccountBalance * 0.8) + " from the available balance");
            }
            return base.Widraw(p_amount);
        }
    }
}
