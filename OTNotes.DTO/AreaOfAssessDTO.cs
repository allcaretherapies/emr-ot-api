using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTNotes.DTO
{
    public class AreaOfAssessDTO: BaseClassDTO
    {
        public int AreaOfAssessId { get; set; }
        public int VisitId { get; set; }
        public string? AssessArea { get; set; }
    }
}
