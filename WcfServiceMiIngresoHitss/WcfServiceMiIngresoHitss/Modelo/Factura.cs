//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceMiIngresoHitss.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        public int Id_Factura { get; set; }
        public System.DateTime Fecha_fac { get; set; }
        public float IVA { get; set; }
        public float Total { get; set; }
        public Nullable<int> Id_Pago { get; set; }
        public Nullable<decimal> Descuento { get; set; }
    }
}
