﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class OrederStatus
{
    public int id_OrederStatuse { get; set; }

    public string OrederStatuseName { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}