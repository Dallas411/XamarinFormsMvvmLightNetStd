﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XfMvvmLnetStd.Model
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
