﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WinFormsApp1
{
    public partial class Gender
    {
        public Gender()
        {
            People = new HashSet<Person>();
        }

        public int id_Gender { get; set; }
        public string GenderName { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}