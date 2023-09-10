using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LandonPierce.Api.DAL
{
    [Table("dbo.Test")]
    public partial class Test
    {
        [Key]
        public int TestID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}