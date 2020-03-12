using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDemoDB7.Model
{
  public  class zt_cat_productos
    {
        [StringLength(20)]
        public string IdSKU { get; set; }
        [StringLength(20)]
        public string IdGrupoSKU { get; set; }//fk
        public zt_cat_grupos zt_cat_grupos { get; set; }
        [StringLength(10)]
        public string IdUMedidaBase { get; set; }//fk
        public zt_cat_unidad_medidas zt_cat_unidad_medidas { get; set; }
        [StringLength(20)]
        public string CodigoBarras { get; set; }
        [StringLength(50)]
        public string DesSKU { get; set; }
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
