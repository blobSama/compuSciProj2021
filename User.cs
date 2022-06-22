using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compuSciProj2021
{
    public class User
    {
        private string id;
        private string firstname;
        private string lastname;
        private string passWord;
        private string addrs;
        private int age;
        private bool isManager;
        private string pssWrdVrfy;
        private bool isActive;
        private int curTop;
        private int curSubTop;

        public User()
        {

        }

        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Firstname
        {
            get
            {
                return this.firstname;
            }
            set
            {
                this.firstname = value;
            }
        }

        public string pssWrd
        {
            get
            {
                return this.passWord;
            }
            set
            {
                this.passWord = value;
            }
        }

        public string Lastname
        {
            get
            {
                return this.lastname;
            }
            set
            {
                this.lastname = value;
            }
        }

        public string Addrs
        {
            get
            {
                return this.addrs;
            }
            set
            {
                this.addrs = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public bool Manager
        {
            get
            {
                return this.isManager;
            }
            set
            {
                this.isManager = value;
            }
        }

        public string passwordVerify
        {
            get
            {
                return this.pssWrdVrfy;
            }
            set
            {
                this.pssWrdVrfy = value;
            }
        }

        public bool Active
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

        public int CurTop
        {
            get
            {
                return this.curTop;
            }
            set
            {
                this.curTop = value;
            }
        }

        public int CurSubTop
        {
            get
            {
                return this.curSubTop;
            }
            set
            {
                this.curSubTop = value;
            }
        }
    }

}