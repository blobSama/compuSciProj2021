using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compuSciProj2021
{
    public class Application
    {
        private string userId;
        private string workId;
        private string workplaceReply;
        private string cv;
        private int offerNum;

        public Application()
        {

        }

        public string UserId
        {
            get
            {
                return this.userId;
            }
            set
            {
                this.userId = value;
            }
        }

        public string WorkId
        {
            get
            {
                return this.workId;
            }
            set
            {
                this.workId = value;
            }
        }

        public string Reply
        {
            get
            {
                return this.workplaceReply;
            }
            set
            {
                this.workplaceReply = value;
            }
        }

        public string Cv
        {
            get
            {
                return this.cv;
            }
            set
            {
                this.cv = value;
            }
        }
        public int offerNumber
        {
            get
            {
                return this.offerNum;
            }
            set
            {
                this.offerNum = value;
            }
        }
    }
}