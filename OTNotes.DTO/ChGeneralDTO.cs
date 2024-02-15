using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTNotes.DTO
{
    public class ChGeneralDTO
    {
        public int ChgeneralId { get; set; }
        public int ClientId { get; set; }
        public int VisitId { get; set; }
        public string? DominantLanguage { get; set; }
        public string? DominantLanguageOther { get; set; }
        public string? AdditionalLanguages { get; set; }
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
        public string? CommunicatesThrough { get; set; }
        public string? UnderstandingLevel { get; set; }
        public string? HasFamilyDefict { get; set; }
        public string? FamilyDefictDescription { get; set; }
        public string? DeficitEffect { get; set; }
        public string? LivingSiblingDescription { get; set; }
        public string? AttendSchool { get; set; }
        public string? WhereName { get; set; }
        public string? ClassGrade { get; set; }
        public string? CurrentPlan { get; set; }
        public string? HasSocialSkillConcern { get; set; }
        public string? SocialSkillConcernDescription { get; set; }
        public string? SpeechTherapyReason { get; set; }
        public string? ExpectedOutcome { get; set; }
        public string? HasSpeechTherapyInPast { get; set; }
        public string? PastSpeechTherapyDescription { get; set; }
        public string? ReceivedPastSpeechTherapyReport { get; set; }
        public string? OtherSpecialistsWorkedWith { get; set; }
        public string? IsReceivingOutsideAgencyService { get; set; }
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

}
