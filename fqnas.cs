using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compuSciProj2021
{
    public class fqnas
    {
        private string askUsrID;
        private string ansUsrID;
        private string qstn;
        private string ans;
        private DateTime askDate;
        private DateTime ansDate;
        
        public fqnas()
        {

        }

        public string AskUsrId
        {
            get
            {
                return this.askUsrID;
            }
            set
            {
                this.askUsrID = value;
            }
        }

        public string AnsUsrId
        {
            get
            {
                return this.ansUsrID;
            }
            set
            {
                this.ansUsrID = value;
            }
        }
        public string Qstn
        {
            get
            {
                return this.qstn;
            }
            set
            {
                this.qstn = value;
            }
        }
        public string Ans
        {
            get
            {
                return this.ans;
            }
            set
            {
                this.ans = value;
            }
        }
        public DateTime AskDate
        {
            get
            {
                return this.askDate;
            }
            set
            {
                this.askDate = value;
            }
        }
        
        public DateTime AnsDate
        {
            get
            {
                return this.ansDate;
            }
            set
            {
                this.ansDate = value;
            }
        }
    }
}