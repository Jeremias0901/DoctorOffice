//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoctorOffice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Patients
    {
        [DisplayName("ID")]
        public int PatientKey { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Apellido")]
        public string Surname { get; set; }
        public Nullable<int> Dni { get; set; }
        [DisplayName("Celular")]
        public Nullable<int> Phone { get; set; }
        public string Email { get; set; }
    }

}
