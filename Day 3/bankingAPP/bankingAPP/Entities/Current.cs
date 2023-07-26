using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP.Entities
{
    internal class Current : Accounts
    {
        bool v_isODFacilityEnabled;

        public bool IsODFacilityEnabled { 
            get { return v_isODFacilityEnabled; } 
            set { v_isODFacilityEnabled = value; } }


        public override double Widraw(int p_amount)
        {
            if (IsODFacilityEnabled)
            {
                if(AccountBalance - p_amount > -100000)
                {
                    throw new Exception("You cannot exceed OD limit of 100000");
                }
            }
            else if (IsODFacilityEnabled == false && p_amount > 10000)
            {
                throw new Exception("Insuffience balance or cannot widraw more than 100000 for current account");
            }
            return base.Widraw(p_amount);
        }
    }
}
