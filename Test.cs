using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compuSciProj2021
{
    public class Test
    {
        private int testNum;
        private DateTime uploadDate;
        private bool isActive;
        private int testTopic;
        private string difficulty;
        private string descript;

        public Test()
        {

        }

        public int TestNum
        {
            get
            {
                return this.testNum;
            }
            set
            {
                this.testNum = value;
            }
        }

        public DateTime UploadDate
        {
            get
            {
                return this.uploadDate;
            }
            set
            {
                this.uploadDate = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return this.isActive;
            }
            set
            {
                this.isActive = value;
            }
        }


        public int TestTopic
        {
            get
            {
                return this.testTopic;
            }
            set
            {
                this.testTopic = value;
            }
        }

        public string Difficulty
        {
            get
            {
                return this.difficulty;
            }
            set
            {
                this.difficulty = value;
            }
        }

        public string Descript
        {
            get
            {
                return this.descript;
            }
            set
            {
                this.descript = value;
            }
        }
    }
}