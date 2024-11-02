using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTNotes.DataAccess.DBObject;

[Table("CHMedical")]
public partial class ChMedical
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CHMedicalId { get; set; }

    public int VisitId { get; set; }

    [Column(Order = 2)]
    public int ClientId { get; set; }

    [StringLength(5000)]
    public string? DevelopmentalDiagnoses { get; set; } = null!;
    [StringLength(5000)]
    public string? BehavioralDiagnoses { get; set; } = null!;
    public string? HadHeadInjury { get; set; } = null!;

    public string? HeadInjuryDescription { get; set; }

    public string? HasAllergy { get; set; } = null!;

    public string? AllergyDescription { get; set; }

    public string? HasRecentChangeInVoice { get; set; }

    public DateTime? NoticeChange { get; set; }

    public string? IsOnMedication { get; set; }

    public string? MedicationDescription { get; set; }

    [StringLength(5)]
    public string? AnyPreviousSurgeries { get; set; }
    public string? PreviousSurgeriesDescription { get; set; }

    public string? OverallHealthDescription { get; set; }
    [StringLength(5000)]
    public string? PrecautionsLimitations { get; set; }
    
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

    [StringLength(5000)]
    public string ProblemSwallowSwitch { get; set; }
    [StringLength(5000)]
    public string CoughAfterDrink { get; set; }
    [StringLength(5000)]
    public string JointPainDiscomfort { get; set; }
    [StringLength(5000)]
    public string MedicalDiagnosisList { get; set; }
    [StringLength(5000)]
    public string PrenatalBirthHistory { get; set; }
    [StringLength(5000)]
    public string StayNICU { get; set; }
}
