﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WinFormsApp1
{
    public partial class Vehicle
    {
        public int id_Vehicle { get; set; }
        public int id_Person { get; set; }
        public int id_Mark { get; set; }
        public int id_Transmission { get; set; }
        public int id_Color { get; set; }
        public int id_Engine { get; set; }
        public string RegMumber { get; set; }
        public int? Mileage { get; set; }
        public string Model { get; set; }

        public virtual Color id_ColorNavigation { get; set; }
        public virtual Engine id_EngineNavigation { get; set; }
        public virtual Mark id_MarkNavigation { get; set; }
        public virtual Person id_PersonNavigation { get; set; }
        public virtual Transmission id_TransmissionNavigation { get; set; }
    }
}