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

    public partial class Medics
    {
        [DisplayName("ID Médico")]
        public int MedicKey { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Apellido")]
        public string Surname { get; set; }
        [DisplayName("Número de Matricula")]
        public Nullable<int> NumberTuition { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.Name, this.Surname);
        }
    }
}
