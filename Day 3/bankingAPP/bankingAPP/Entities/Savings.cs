using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP.Entities
{
    internal class Savings : Accounts
    {
        double v_intrestRate;

        public double IntrestRate 
        { 
            get { return v_intrestRate; }
            set { v_intrestRate = value; }
        }


        public override double Widraw(int p_amount)
        {
            if (p_amount > 20000)
            {
                throw new Exception("Savings account can widraw max 20000 in a transaction");
            }
            else if(p_amount > AccountBalance)
            {
                throw new Exception("Insuffient balance ,you can widraw max " + AccountBalance);
            }
            return base.Widraw(p_amount);
        }
    }
}
