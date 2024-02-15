using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTNotes.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHGeneral",
                columns: table => new
                {
                    ChgeneralId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                   
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    DominantLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DominantLanguageOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalLanguages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHomeBound = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomBoundDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomBoundDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriorAdl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasFallHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FallHistory = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsIntervention = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterventionDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LivingSituation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LivingSituationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvBarrier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvBarrierEquipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdaptiveEquipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdaptiveEquipmentDeatil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommunicatesThrough = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnderstandingLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFamilyDefict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyDefictDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeficitEffect = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LivingSiblingDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttendSchool = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhereName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasSocialSkillConcern = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialSkillConcernDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpeechTherapyReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedOutcome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasSpeechTherapyInPast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PastSpeechTherapyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivedPastSpeechTherapyReport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherSpecialistsWorkedWith = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsReceivingOutsideAgencyService = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivingOutsideAgencyWhere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SitupAge = table.Column<int>(type: "int", nullable: true),
                    StandAge = table.Column<int>(type: "int", nullable: true),
                    SpeakWordAge = table.Column<int>(type: "int", nullable: true),
                    CrawlAge = table.Column<int>(type: "int", nullable: true),
                    WalkAge = table.Column<int>(type: "int", nullable: true),
                    ComWordsAge1 = table.Column<int>(type: "int", nullable: true),
                    ComWordsAge = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    HaveYouReceiveReport = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHGeneral", x => x.ChgeneralId);
                });

            migrationBuilder.CreateTable(
                name: "CHMedical",
                columns: table => new
                {
                    ChmedicalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    HadHeadInjury = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadInjuryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasAllergy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllergyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasRecentChangeInVoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticeChange = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsOnMedication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousSurgeriesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OverallHealthDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis1OnsetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Diagnosis2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis2OnsetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Diagnosis3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis3OnsetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Diagnosis4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis4OnsetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastVisionScreeningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastVisionScreeningResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoesWearGlasses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastHearingScreeningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastHearingScreeningResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoesWearHearingAids = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FcmIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHMedical", x => x.ChmedicalId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHGeneral");

            migrationBuilder.DropTable(
                name: "CHMedical");
        }
    }
}
