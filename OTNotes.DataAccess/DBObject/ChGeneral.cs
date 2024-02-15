using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OTNotes.DataAccess.DBObject;

[Table("CHGeneral")]
public partial class ChGeneral
{
    public int ChgeneralId { get; set; }

    public int ClientId { get; set; }

    public int VisitId { get; set; }
    [StringLength(100)]
    public string? DominantLanguage { get; set; }
    [StringLength(50)]
    public string? DominantLanguageOther { get; set; }

    public string? AdditionalLanguages { get; set; } = null!;

    public string? IsHomeBound { get; set; }

    public string? HomBoundDetail { get; set; }

    public string? HomBoundDescription { get; set; }

    public string? PriorAdl { get; set; }

    public string? HasFallHistory { get; set; }

    public DateTime? FallHistory { get; set; }

    public string? IsIntervention { get; set; }

    public string? InterventionDetail { get; set; }

    public string? ReportedBy { get; set; }

    public string? LivingSituation { get; set; }

    public string? LivingSituationDescription { get; set; }

    public string? EnvBarrier { get; set; }

    public string? EnvBarrierEquipment { get; set; }

    public string? AdaptiveEquipment { get; set; }

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
}
