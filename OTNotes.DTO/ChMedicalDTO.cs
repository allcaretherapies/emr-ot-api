using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTNotes.DTO
{
    public class ChMedicalDTO
    {
        public int CHMedicalId { get; set; }

        public int VisitId { get; set; }

        public int ClientId { get; set; }

        public string? HadHeadInjury { get; set; } = null!;

        public string? HeadInjuryDescription { get; set; }

        public string? HasAllergy { get; set; } = null!;

        public string? AllergyDescription { get; set; }

        public string? HasRecentChangeInVoice { get; set; }

        public DateTime? NoticeChange { get; set; }

        public string? IsOnMedication { get; set; }

        public string? MedicationDescription { get; set; }

        public string? PreviousSurgeriesDescription { get; set; }

        public string? OverallHealthDescription { get; set; }

        public string? Diagnosis1 { get; set; }

        public DateTime? Diagnosis1OnsetDate { get; set; }

        public string? Diagnosis2 { get; set; }

        public DateTime? Diagnosis2OnsetDate { get; set; }

        public string? Diagnosis3 { get; set; }

        public DateTime? Diagnosis3OnsetDate { get; set; }

        public string? Diagnosis4 { get; set; }

        public DateTime? Diagnosis4OnsetDate { get; set; }

        public DateTime? LastVisionScreeningDate { get; set; }

        public string? LastVisionScreeningResult { get; set; }

        public string? DoesWearGlasses { get; set; }

        public DateTime? LastHearingScreeningDate { get; set; }

        public string? LastHearingScreeningResult { get; set; }

        public string? DoesWearHearingAids { get; set; }

        public string? FCMIds { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? UpdatedBy { get; set; }

    }
}
