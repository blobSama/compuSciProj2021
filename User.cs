﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compuSciProj2020
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
    }

}