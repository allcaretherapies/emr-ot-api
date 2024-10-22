using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTNotes.DataAccess.DBObject
{
    [Table("AreaOfAssess")]
    public partial class AreaOfAssess: BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AreaOfAssessId { get; set; }
        public int VisitId { get; set; }
        [StringLength(1000)]
        public string? AssessArea { get; set; }
    }
 }
