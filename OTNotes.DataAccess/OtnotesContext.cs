using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OTNotes.DataAccess.DBObject;

namespace OTNotes.DataAccess
{
    public partial class OtnotesContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public OtnotesContext(DbContextOptions<OtnotesContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<ChGeneral> CHGenerals { get; set; }
        public DbSet<ChMedical> CHMedicals { get; set; }
        public DbSet<AreaOfAssess> AreaOfAssesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}


//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;

//namespace OTNotes.DataAccess;

//public partial class OtnotesContext : DbContext
//{
//    private readonly IConfiguration _configuration;
//    public OtnotesContext()
//    {
//    }

//    public OtnotesContext(DbContextOptions<OtnotesContext> options, IConfiguration configuration)
//             : base(options)
//    {
//        _configuration = configuration;
//    }

//    public virtual DbSet<Chgeneral> Chgenerals { get; set; }

//    public virtual DbSet<Chmedical> Chmedicals { get; set; }

////    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
////        => optionsBuilder.UseSqlServer("Server=44.199.178.207;Database=OTNotes;User Id=sa;Password=SA@1234;TrustServerCertificate=True;");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<Chgeneral>(entity =>
//        {
//            entity.ToTable("CHGeneral");

//            entity.Property(e => e.ChgeneralId).HasColumnName("CHGeneralId");
//            entity.Property(e => e.AdaptiveEquipment)
//                .HasMaxLength(10)
//                .IsUnicode(false);
//            entity.Property(e => e.AdaptiveEquipmentDeatil)
//                .HasMaxLength(2000)
//                .IsUnicode(false);
//            entity.Property(e => e.AdditionalLanguages)
//                .HasMaxLength(250)
//                .IsUnicode(false);
//            entity.Property(e => e.AttendSchool)
//                .HasMaxLength(4)
//                .IsUnicode(false);
//            entity.Property(e => e.ClassGrade)
//                .HasMaxLength(10)
//                .IsUnicode(false);
//            entity.Property(e => e.CommunicatesThrough)
//                .HasMaxLength(50)
//                .IsUnicode(false);
//            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
//            entity.Property(e => e.CurrentPlan)
//                .HasMaxLength(50)
//                .IsUnicode(false);
//            entity.Property(e => e.DeficitEffect).IsUnicode(false);
//            entity.Property(e => e.DominantLanguage)
//                .HasMaxLength(20)
//                .IsUnicode(false);
//            entity.Property(e => e.DominantLanguageOther)
//                .HasMaxLength(20)
//                .IsUnicode(false);
//            entity.Property(e => e.EnvBarrier)
//                .HasMaxLength(10)
//                .IsUnicode(false);
//            entity.Property(e => e.EnvBarrierEquipment)
//                .HasMaxLength(2000)
//                .IsUnicode(false);
//            entity.Property(e => e.ExpectedOutcome).IsUnicode(false);
//            entity.Property(e => e.FallHistory).HasColumnType("date");
//            entity.Property(e => e.FamilyDefictDescription).IsUnicode(false);
//            entity.Property(e => e.HasFallHistory)
//                .HasMaxLength(10)
//                .IsUnicode(false);
//            entity.Property(e => e.HasFamilyDefict)
//                .HasMaxLength(4)
//                .IsUnicode(false);
//            entity.Property(e => e.HasSocialSkillConcern)
//                .HasMaxLength(4)
//                .IsUnicode(false);
//            entity.Property(e => e.HasSpeechTherapyInPast)
//                .HasMaxLength(4)
//                .IsUnicode(false);
//            entity.Property(e => e.HaveYouReceiveReport)
//                .HasMaxLength(5)
//                .IsUnicode(false);
//            entity.Property(e => e.HomBoundDescription).IsUnicode(false);
//            entity.Property(e => e.HomBoundDetail)
//                .HasMaxLength(2000)
//                .IsUnicode(false);
//            entity.Property(e => e.InterventionDetail)
//                .HasMaxLength(100)
//                .IsUnicode(false);
//            entity.Property(e => e.IsHomeBound)
//                .HasMaxLength(10)
//                .IsUnicode(false);
//            entity.Property(e => e.IsIntervention)
//                .HasMaxLength(10)
//                .IsUnicode(false);
//            entity.Property(e => e.IsReceivingOutsideAgencyService)
//                .HasMaxLength(4)
//                .IsUnicode(false);
//            entity.Property(e => e.LivingSiblingDescription).IsUnicode(false);
//            entity.Property(e => e.LivingSituation)
//                .HasMaxLength(2000)
//                .IsUnicode(false)
//                .HasColumnName("livingSituation");
//            entity.Property(e => e.LivingSituationDescription)
//                .IsUnicode(false)
//                .HasColumnName("livingSituationDescription");
//            entity.Property(e => e.OtherSpecialistsWorkedWith)
//                .HasMaxLength(200)
//                .IsUnicode(false);
//            entity.Property(e => e.PastSpeechTherapyDescription)
//                .HasMaxLength(50)
//                .IsUnicode(false);
//            entity.Property(e => e.PriorAdl)
//                .HasMaxLength(500)
//                .IsUnicode(false)
//                .HasColumnName("PriorADL");
//            entity.Property(e => e.ReceivedPastSpeechTherapyReport)
//                .HasMaxLength(4)
//                .IsUnicode(false);
//            entity.Property(e => e.ReceivingOutsideAgencyWhere)
//                .HasMaxLength(50)
//                .IsUnicode(false);
//            entity.Property(e => e.ReportedBy)
//                .HasMaxLength(100)
//                .IsUnicode(false);
//            entity.Property(e => e.SocialSkillConcernDescription).IsUnicode(false);
//            entity.Property(e => e.SpeechTherapyReason).IsUnicode(false);
//            entity.Property(e => e.UnderstandingLevel)
//                .HasMaxLength(50)
//                .IsUnicode(false);
//            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
//            entity.Property(e => e.WhereName)
//                .HasMaxLength(50)
//                .IsUnicode(false);
//        });

//        modelBuilder.Entity<Chmedical>(entity =>
//        {
//            entity.ToTable("CHMedical");

//            entity.Property(e => e.ChmedicalId).HasColumnName("CHMedicalId");
//            entity.Property(e => e.AllergyDescription).IsUnicode(false);
//            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
//            entity.Property(e => e.Diagnosis1)
//                .HasMaxLength(20)
//                .IsUnicode(false);
//            entity.Property(e => e.Diagnosis1OnsetDate).HasColumnType("date");
//            entity.Property(e => e.Diagnosis2)
//                .HasMaxLength(20)
//                .IsUnicode(false);
//            entity.Property(e => e.Diagnosis2OnsetDate).HasColumnType("date");
//            entity.Property(e => e.Diagnosis3)
//                .HasMaxLength(20)
//                .IsUnicode(false);
//            entity.Property(e => e.Diagnosis3OnsetDate).HasColumnType("date");
//            entity.Property(e => e.Diagnosis4)
//                .HasMaxLength(20)
//                .IsUnicode(false);
//            entity.Property(e => e.Diagnosis4OnsetDate).HasColumnType("date");
//            entity.Property(e => e.DoesWearGlasses)
//                .HasMaxLength(4)
//                .IsUnicode(false);
//            entity.Property(e => e.DoesWearHearingAids)
//                .HasMaxLength(4)
//                .IsUnicode(false);
//            entity.Property(e => e.FcmIds)
//                .HasMaxLength(200)
//                .IsUnicode(false)
//                .HasColumnName("FCM_Ids");
//            entity.Property(e => e.HadHeadInjury)
//                .HasMaxLength(4)
//                .IsUnicode(false)
//                .HasDefaultValueSql("((0))");
//            entity.Property(e => e.HasAllergy)
//                .HasMaxLength(4)
//                .IsUnicode(false);
//            entity.Property(e => e.HasRecentChangeInVoice)
//                .HasMaxLength(4)
//                .IsUnicode(false);
//            entity.Property(e => e.HeadInjuryDescription).IsUnicode(false);
//            entity.Property(e => e.IsOnMedication)
//                .HasMaxLength(4)
//                .IsUnicode(false);
//            entity.Property(e => e.LastHearingScreeningDate).HasColumnType("date");
//            entity.Property(e => e.LastHearingScreeningResult)
//                .HasMaxLength(10)
//                .IsUnicode(false);
//            entity.Property(e => e.LastVisionScreeningDate).HasColumnType("date");
//            entity.Property(e => e.LastVisionScreeningResult)
//                .HasMaxLength(10)
//                .IsUnicode(false);
//            entity.Property(e => e.MedicationDescription).IsUnicode(false);
//            entity.Property(e => e.NoticeChange).HasColumnType("date");
//            entity.Property(e => e.OverallHealthDescription).IsUnicode(false);
//            entity.Property(e => e.PreviousSurgeriesDescription).IsUnicode(false);
//            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
