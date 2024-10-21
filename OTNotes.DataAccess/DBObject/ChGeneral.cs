using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OTNotes.DataAccess.DBObject;

[Table("CHGeneral")]
public partial class ChGeneral
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CHGeneralId { get; set; }

    public int ClientId { get; set; }

    public int VisitId { get; set; }
    [StringLength(100)]
    public string? DominantLanguage { get; set; }
    [StringLength(50)]
    public string? DominantLanguageOther { get; set; }
    [StringLength(250)]
    public string? AdditionalLanguages { get; set; } = null!;
    [StringLength(5)]
    public string? IsHomeBound { get; set; }
    [StringLength(1000)]
    public string? HomBoundDetail { get; set; }

    public string? HomBoundDescription { get; set; }
    [StringLength(1000)]
    public string? PriorAdl { get; set; }
    [StringLength(5)]
    public string? HasFallHistory { get; set; }

    public DateTime? FallHistoryDate { get; set; }
    [StringLength(5)]
    public string? IsIntervention { get; set; }
    [StringLength(50)]
    public string? InterventionDetail { get; set; }
    [StringLength(50)]
    public string? ReportedBy { get; set; }
    [StringLength(1000)]
    public string? LivingSituation { get; set; }

    public string? LivingSituationDescription { get; set; }
    [StringLength(5)]
    public string? EnvBarrier { get; set; }
    [StringLength(1000)]
    public string? EnvBarrierEquipment { get; set; }
    [StringLength(5)]
    public string? AdaptiveEquipment { get; set; }
    [StringLength(1000)]
    public string? AdaptiveEquipmentDeatil { get; set; }

    public string? CommunicatesThrough { get; set; } = null!;

    public string? UnderstandingLevel { get; set; } = null!;

    public string? HasFamilyDefict { get; set; } = null!;

    public string? FamilyDefictDescription { get; set; } = null!;

    public string? DeficitEffect { get; set; } = null!;

    public string? LivingSiblingDescription { get; set; } = null!;

    public string? AttendSchool { get; set; } = null!;

    public string? WhereName { get; set; }

    public string? ClassGrade { get; set; }

    public string? CurrentPlan { get; set; }

    public string? HasSocialSkillConcern { get; set; } = null!;

    public string? SocialSkillConcernDescription { get; set; }

    public string? SpeechTherapyReason { get; set; } = null!;

    public string? ExpectedOutcome { get; set; } = null!;

    public string? HasSpeechTherapyInPast { get; set; } = null!;

    public string? PastSpeechTherapyDescription { get; set; }

    public string? ReceivedPastSpeechTherapyReport { get; set; }

    public string? OtherSpecialistsWorkedWith { get; set; } = null!;

    public string? IsReceivingOutsideAgencyService { get; set; } = null!;

    public string? ReceivingOutsideAgencyWhere { get; set; }

    public int? SitupAge { get; set; }

    public int? StandAge { get; set; }

    public int? SpeakWordAge { get; set; }

    public int? CrawlAge { get; set; }

    public int? WalkAge { get; set; }

    public int? ComWordsAge1 { get; set; }

    public int? ComWordsAge { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public string? HaveYouReceiveReport { get; set; }

    [StringLength(500)]
    public string? ExpectationFromTherepist { get; set; }
    [StringLength(50)]
    public string? livingInHome { get; set; }
    [StringLength(25)]
    public string? CurrentlyWorking { get; set; }
    public bool? TakingServiceByAgency { get; set; }
    public bool? OtBeforeTaken { get; set; }
}
