using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDemoDB7.Model
{
   public class zt_cat_grupos
    {
        [StringLength(20)]
        public string IdGrupoSKU { get; set; }//pk
        [StringLength(50)]
        public string DesGrupoSKU { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }
}
