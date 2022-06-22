using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compuSciProj2021
{
    public class Class
    {
        private int classNum;
        private int subTopNum;
        private string classText;
        private string quest;
        private string ans;
        private DateTime uploadTime;
        private bool stat;

        public Class()
        {

        }

        public int ClassNum
        {
            get
            {
                return this.classNum;
            }
            set
            {
                this.classNum = value;
            }
        }

        public int SubTopNum
        {
            get
            {
                return this.subTopNum;
            }
            set
            {
                this.subTopNum = value;
            }
        }

        public string ClassText
        {
            get
            {
                return this.classText;
            }
            set
            {
                this.classText = value;
            }
        }

        public string Quest
        {
            get
            {
                return this.quest;
            }
            set
            {
                this.quest = value;
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
        public DateTime UploadTime
        {
            get
            {
                return this.uploadTime;
            }
            set
            {
                this.uploadTime = value;
            }
        }

        public bool Stat
        {
            get
            {
                return this.stat;
            }
            set
            {
                this.stat = value;
            }
        }
    }
}