using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PAR.Infrastructure.Models;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace PAR.Infrastructure.Data;

public partial class PARContext : DbContext
{
    public PARContext()
    {
    }

    public PARContext(DbContextOptions<PARContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Achievement> Achievements { get; set; }

    public virtual DbSet<Achievementattachment> Achievementattachments { get; set; }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<Appraisal> Appraisals { get; set; }

    public virtual DbSet<Appraisalcommittee> Appraisalcommittees { get; set; }

    public virtual DbSet<Appraisalevaluator> Appraisalevaluators { get; set; }

    public virtual DbSet<Appraisalscore> Appraisalscores { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<BibAuthor> BibAuthors { get; set; }

    public virtual DbSet<BibPublication> BibPublications { get; set; }

    public virtual DbSet<BibPublicationauthor> BibPublicationauthors { get; set; }

    public virtual DbSet<Booleanpreference> Booleanpreferences { get; set; }

    public virtual DbSet<Committee> Committees { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Datepreference> Datepreferences { get; set; }

    public virtual DbSet<Irsachievement> Irsachievements { get; set; }

    public virtual DbSet<Irsachievementattachment> Irsachievementattachments { get; set; }

    public virtual DbSet<Irsactivity> Irsactivities { get; set; }

    public virtual DbSet<Irsattachment> Irsattachments { get; set; }

    public virtual DbSet<Irskpi> Irskpis { get; set; }

    public virtual DbSet<Irskpiachievement> Irskpiachievements { get; set; }

    public virtual DbSet<Irsworkplan> Irsworkplans { get; set; }

    public virtual DbSet<Kpi> Kpis { get; set; }

    public virtual DbSet<Kpiachievement> Kpiachievements { get; set; }

    public virtual DbSet<Learning> Learnings { get; set; }

    public virtual DbSet<Learningattachment> Learningattachments { get; set; }

    public virtual DbSet<Learningattachment1> Learningattachments1 { get; set; }

    public virtual DbSet<MtpAchievement> MtpAchievements { get; set; }

    public virtual DbSet<MtpLogin> MtpLogins { get; set; }

    public virtual DbSet<MtpMtp> MtpMtps { get; set; }

    public virtual DbSet<MtpWorkplan> MtpWorkplans { get; set; }

    public virtual DbSet<Mtpdocument> Mtpdocuments { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NrsWorkplan> NrsWorkplans { get; set; }

    public virtual DbSet<Nrsachievement> Nrsachievements { get; set; }

    public virtual DbSet<Nrsachievementattachment> Nrsachievementattachments { get; set; }

    public virtual DbSet<Nrsattachment> Nrsattachments { get; set; }

    public virtual DbSet<Numberpreference> Numberpreferences { get; set; }

    public virtual DbSet<Output> Outputs { get; set; }

    public virtual DbSet<Outputtarget> Outputtargets { get; set; }

    public virtual DbSet<P4dachievement> P4dachievements { get; set; }

    public virtual DbSet<P4dachievementattachment> P4dachievementattachments { get; set; }

    public virtual DbSet<P4dactivity> P4dactivities { get; set; }

    public virtual DbSet<P4dattachment> P4dattachments { get; set; }

    public virtual DbSet<P4dcrp> P4dcrps { get; set; }

    public virtual DbSet<P4dmtpdocument> P4dmtpdocuments { get; set; }

    public virtual DbSet<P4doutput> P4doutputs { get; set; }

    public virtual DbSet<P4doutputtarget> P4doutputtargets { get; set; }

    public virtual DbSet<P4dproject> P4dprojects { get; set; }

    public virtual DbSet<P4dsupportachievement> P4dsupportachievements { get; set; }

    public virtual DbSet<P4dsupportachievementattachment> P4dsupportachievementattachments { get; set; }

    public virtual DbSet<P4dsupportactivity> P4dsupportactivities { get; set; }

    public virtual DbSet<P4dsupportattachment> P4dsupportattachments { get; set; }

    public virtual DbSet<P4dsupportworkplan> P4dsupportworkplans { get; set; }

    public virtual DbSet<P4dworkplan> P4dworkplans { get; set; }

    public virtual DbSet<ParReport> ParReports { get; set; }

    public virtual DbSet<ParWorkplan> ParWorkplans { get; set; }

    public virtual DbSet<PmCorebudget> PmCorebudgets { get; set; }

    public virtual DbSet<PmCostcenter> PmCostcenters { get; set; }

    public virtual DbSet<PmExpressionofinterest> PmExpressionofinterests { get; set; }

    public virtual DbSet<PmExpressionofintereststaff> PmExpressionofintereststaffs { get; set; }

    public virtual DbSet<PmFinancialreport> PmFinancialreports { get; set; }

    public virtual DbSet<PmIdea> PmIdeas { get; set; }

    public virtual DbSet<PmIdeastaff> PmIdeastaffs { get; set; }

    public virtual DbSet<PmIitacostcenter> PmIitacostcenters { get; set; }

    public virtual DbSet<PmPartner> PmPartners { get; set; }

    public virtual DbSet<PmProject> PmProjects { get; set; }

    public virtual DbSet<PmProjectcostcenter> PmProjectcostcenters { get; set; }

    public virtual DbSet<PmProjectdocument> PmProjectdocuments { get; set; }

    public virtual DbSet<PmProjectstaff> PmProjectstaffs { get; set; }

    public virtual DbSet<PmProposal> PmProposals { get; set; }

    public virtual DbSet<PmProposalstaff> PmProposalstaffs { get; set; }

    public virtual DbSet<PmStaff> PmStaffs { get; set; }

    public virtual DbSet<PmTechnicalreport> PmTechnicalreports { get; set; }

    public virtual DbSet<PreAuthor> PreAuthors { get; set; }

    public virtual DbSet<PrePublication> PrePublications { get; set; }

    public virtual DbSet<PrePublicationauthor> PrePublicationauthors { get; set; }

    public virtual DbSet<Preference> Preferences { get; set; }

    public virtual DbSet<Program> Programs { get; set; }

    public virtual DbSet<Programmember> Programmembers { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Query> Queries { get; set; }

    public virtual DbSet<Queryparameter> Queryparameters { get; set; }

    public virtual DbSet<Srvachievement> Srvachievements { get; set; }

    public virtual DbSet<Srvachievementattachment> Srvachievementattachments { get; set; }

    public virtual DbSet<Srvactivity> Srvactivities { get; set; }

    public virtual DbSet<Srvattachment> Srvattachments { get; set; }

    public virtual DbSet<Srvcrp> Srvcrps { get; set; }

    public virtual DbSet<Srvmtpdocument> Srvmtpdocuments { get; set; }

    public virtual DbSet<Srvoutput> Srvoutputs { get; set; }

    public virtual DbSet<Srvoutputtarget> Srvoutputtargets { get; set; }

    public virtual DbSet<Srvproject> Srvprojects { get; set; }

    public virtual DbSet<Srvworkplan> Srvworkplans { get; set; }

    public virtual DbSet<Staffcommentlog> Staffcommentlogs { get; set; }

    public virtual DbSet<Stringpreference> Stringpreferences { get; set; }

    public virtual DbSet<TaPretravel> TaPretravels { get; set; }

    public virtual DbSet<TraProgram> TraPrograms { get; set; }

    public virtual DbSet<TraTrainee> TraTrainees { get; set; }

    public virtual DbSet<Travelauthorization> Travelauthorizations { get; set; }

    public virtual DbSet<Traveler> Travelers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Useraccesstag> Useraccesstags { get; set; }

    public virtual DbSet<Userclassification> Userclassifications { get; set; }

    public virtual DbSet<Userdelegation> Userdelegations { get; set; }

    public virtual DbSet<Userlookup> Userlookups { get; set; }

    public virtual DbSet<Usernotification> Usernotifications { get; set; }

    public virtual DbSet<Userpasswordrequest> Userpasswordrequests { get; set; }

    public virtual DbSet<Userrole> Userroles { get; set; }

    public virtual DbSet<Usersupervisor> Usersupervisors { get; set; }

    public virtual DbSet<Workplan2> Workplan2s { get; set; }

    public virtual DbSet<Workplanactionstatus> Workplanactionstatuses { get; set; }

    public virtual DbSet<Workplanentrydeadline> Workplanentrydeadlines { get; set; }

    public virtual DbSet<Workplanstatuslog> Workplanstatuslogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Achievement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("achievement")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ActivityId, "FKCB94370F81E5F5CF");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Achievement1).HasColumnName("achievement");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.Completion)
                .HasMaxLength(255)
                .HasColumnName("completion");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Achievementattachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("achievementattachments")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IrsKpiachievementId, "FKC5398D211FFBCE8D");

            entity.HasIndex(e => e.KpiachievementId, "FKC5398D2158916042");

            entity.HasIndex(e => e.AchievementId, "FKC5398D217265CCC5");

            entity.HasIndex(e => e.AttachmentsId, "FKC5398D21EA8EA62");

            entity.Property(e => e.AchievementId).HasColumnName("Achievement_id");
            entity.Property(e => e.AttachmentsId).HasColumnName("attachments_id");
            entity.Property(e => e.IrsKpiachievementId).HasColumnName("IrsKPIAchievement_id");
            entity.Property(e => e.KpiachievementId).HasColumnName("KPIAchievement_id");

            entity.HasOne(d => d.IrsKpiachievement).WithMany()
                .HasForeignKey(d => d.IrsKpiachievementId)
                .HasConstraintName("FKC5398D211FFBCE8D");

            entity.HasOne(d => d.Kpiachievement).WithMany()
                .HasForeignKey(d => d.KpiachievementId)
                .HasConstraintName("FKC5398D2158916042");
        });

        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("activity")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.WorkplanId, "FKA126572F5C58FA3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activity1).HasColumnName("activity");
            entity.Property(e => e.AllocatedTime)
                .HasMaxLength(255)
                .HasColumnName("allocatedTime");
            entity.Property(e => e.CoreCenter)
                .HasMaxLength(150)
                .HasColumnName("coreCenter");
            entity.Property(e => e.CostCenter)
                .HasMaxLength(150)
                .HasColumnName("costCenter");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CrpPartners)
                .HasMaxLength(1000)
                .HasColumnName("crpPartners");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.InternalIita)
                .HasMaxLength(255)
                .HasColumnName("internalIITA");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.MileStoneQtr1).HasColumnName("mileStoneQtr1");
            entity.Property(e => e.MileStoneQtr2).HasColumnName("mileStoneQtr2");
            entity.Property(e => e.MileStoneQtr3).HasColumnName("mileStoneQtr3");
            entity.Property(e => e.MileStoneQtr4).HasColumnName("mileStoneQtr4");
            entity.Property(e => e.OtherExternal)
                .HasMaxLength(1000)
                .HasColumnName("otherExternal");
            entity.Property(e => e.ProposedBudget).HasColumnName("proposedBudget");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.WorkplanId).HasColumnName("workplan_id");
        });

        modelBuilder.Entity<Appraisal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("appraisal")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AppraiseeId, "FK4AE92C536735707");

            entity.HasIndex(e => e.AppraiserId, "FK4AE92C536793FDA");

            entity.HasIndex(e => e.CountryId, "FK4AE92C5523DCFB1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdditionalComments).HasColumnName("additionalComments");
            entity.Property(e => e.Appeal)
                .HasMaxLength(5)
                .HasDefaultValueSql("'No'")
                .HasColumnName("appeal");
            entity.Property(e => e.AppraiseeId).HasColumnName("appraisee_id");
            entity.Property(e => e.AppraiseeId1)
                .HasMaxLength(20)
                .HasColumnName("appraiseeId");
            entity.Property(e => e.AppraiseeName)
                .HasMaxLength(200)
                .HasColumnName("appraiseeName");
            entity.Property(e => e.AppraiserId).HasColumnName("appraiser_id");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.CommitteeMember)
                .HasMaxLength(255)
                .HasColumnName("committeeMember");
            entity.Property(e => e.CompletedTraining).HasColumnName("completedTraining");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DisciplinaryAction).HasColumnName("disciplinaryAction");
            entity.Property(e => e.Eligibility).HasColumnName("eligibility");
            entity.Property(e => e.FinalScore).HasColumnName("finalScore");
            entity.Property(e => e.IrsEffectiveness).HasColumnName("irsEffectiveness");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(255)
                .HasColumnName("jobTitle");
            entity.Property(e => e.JuniorManageStaff)
                .HasMaxLength(255)
                .HasColumnName("juniorManageStaff");
            entity.Property(e => e.Justification).HasColumnName("justification");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.ManageStaff)
                .HasMaxLength(255)
                .HasColumnName("manageStaff");
            entity.Property(e => e.Project)
                .HasMaxLength(255)
                .HasColumnName("project");
            entity.Property(e => e.RatingSummary)
                .HasMaxLength(255)
                .HasColumnName("ratingSummary");
            entity.Property(e => e.Research)
                .HasMaxLength(255)
                .HasColumnName("research");
            entity.Property(e => e.Selfappraised)
                .HasMaxLength(255)
                .HasDefaultValueSql("'No'")
                .HasColumnName("selfappraised");
            entity.Property(e => e.StaffComments).HasColumnName("staffComments");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .HasColumnName("state");
            entity.Property(e => e.Strengths).HasColumnName("strengths");
            entity.Property(e => e.Suggestions).HasColumnName("suggestions");
            entity.Property(e => e.TrainingNeeds).HasColumnName("trainingNeeds");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
            entity.Property(e => e.Unit)
                .HasMaxLength(255)
                .HasColumnName("unit");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Weaknesses).HasColumnName("weaknesses");
            entity.Property(e => e.YearOfAppraisal).HasColumnName("yearOfAppraisal");

            entity.HasOne(d => d.Country).WithMany(p => p.Appraisals)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK4AE92C5523DCFB1");
        });

        modelBuilder.Entity<Appraisalcommittee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("appraisalcommittee")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AppraisalId, "FK5CAAD238134C9C32");

            entity.HasIndex(e => e.CommitteeId, "FK5CAAD238C4E1E091");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppraisalId).HasColumnName("appraisal_id");
            entity.Property(e => e.CommitteeId).HasColumnName("committee_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Appraisal).WithMany(p => p.Appraisalcommittees)
                .HasForeignKey(d => d.AppraisalId)
                .HasConstraintName("FK5CAAD238134C9C32");

            entity.HasOne(d => d.Committee).WithMany(p => p.Appraisalcommittees)
                .HasForeignKey(d => d.CommitteeId)
                .HasConstraintName("FK5CAAD238C4E1E091");
        });

        modelBuilder.Entity<Appraisalevaluator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("appraisalevaluator")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AppraisalId, "FKE07CC2EA134C9C32");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppraisalId).HasColumnName("appraisal_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Appraisal).WithMany(p => p.Appraisalevaluators)
                .HasForeignKey(d => d.AppraisalId)
                .HasConstraintName("FKE07CC2EA134C9C32");
        });

        modelBuilder.Entity<Appraisalscore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("appraisalscore")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AppraisalId, "FK3087AECD134C9C32");

            entity.HasIndex(e => e.Id, "FK3087AECD14C33E30");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppraisalId).HasColumnName("appraisal_id");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.ScoreKey)
                .HasMaxLength(100)
                .HasColumnName("scoreKey");

            entity.HasOne(d => d.Appraisal).WithMany(p => p.Appraisalscores)
                .HasForeignKey(d => d.AppraisalId)
                .HasConstraintName("FK3087AECD134C9C32");
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("attachment")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.DiskPath, "diskPath").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(100)
                .HasColumnName("contentType");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.DiskPath)
                .HasMaxLength(200)
                .HasColumnName("diskPath");
            entity.Property(e => e.Downloads).HasColumnName("downloads");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .HasColumnName("fileName");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<BibAuthor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bib_author")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Iitauserid, "FK65FF214F565F36DA");

            entity.HasIndex(e => e.Email, "IX_BA_Email");

            entity.HasIndex(e => e.Id, "IX_Bib_Author");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Cleanname)
                .HasMaxLength(255)
                .HasColumnName("cleanname");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("firstname");
            entity.Property(e => e.Iitauserid).HasColumnName("IITAUSERID");
            entity.Property(e => e.Institute)
                .HasMaxLength(255)
                .HasColumnName("institute");
            entity.Property(e => e.Surname)
                .HasMaxLength(255)
                .HasColumnName("surname");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.Von)
                .HasMaxLength(255)
                .HasColumnName("von");

            entity.HasOne(d => d.Iitauser).WithMany(p => p.BibAuthors)
                .HasForeignKey(d => d.Iitauserid)
                .HasConstraintName("FK65FF214F565F36DA");
        });

        modelBuilder.Entity<BibPublication>(entity =>
        {
            entity.HasKey(e => e.PubId).HasName("PRIMARY");

            entity
                .ToTable("bib_publication")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.PubId, "IX_Publication");

            entity.Property(e => e.PubId)
                .ValueGeneratedNever()
                .HasColumnName("pub_id");
            entity.Property(e => e.Abstract)
                .HasColumnType("text")
                .HasColumnName("abstract");
            entity.Property(e => e.Actualyear)
                .HasMaxLength(12)
                .HasColumnName("actualyear");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.BibtexId)
                .HasMaxLength(255)
                .HasColumnName("bibtex_id");
            entity.Property(e => e.Booktitle)
                .HasMaxLength(255)
                .HasColumnName("booktitle");
            entity.Property(e => e.Chapter)
                .HasMaxLength(10)
                .HasColumnName("chapter");
            entity.Property(e => e.Cleanjournal)
                .HasMaxLength(255)
                .HasColumnName("cleanjournal");
            entity.Property(e => e.Cleantitle)
                .HasMaxLength(255)
                .HasColumnName("cleantitle");
            entity.Property(e => e.Crossref)
                .HasMaxLength(255)
                .HasColumnName("crossref");
            entity.Property(e => e.Devcountauth)
                .HasMaxLength(3)
                .HasColumnName("devcountauth");
            entity.Property(e => e.Doi)
                .HasMaxLength(255)
                .HasColumnName("doi");
            entity.Property(e => e.Edition)
                .HasMaxLength(255)
                .HasColumnName("edition");
            entity.Property(e => e.EnteredBy).HasColumnName("entered_by");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entry_date");
            entity.Property(e => e.Firstpage)
                .HasMaxLength(10)
                .HasColumnName("firstpage");
            entity.Property(e => e.Howpublished)
                .HasMaxLength(255)
                .HasColumnName("howpublished");
            entity.Property(e => e.Institution)
                .HasMaxLength(255)
                .HasColumnName("institution");
            entity.Property(e => e.Isbn)
                .HasMaxLength(32)
                .HasColumnName("isbn");
            entity.Property(e => e.Ispublic)
                .HasDefaultValueSql("'FALSE'")
                .HasColumnType("enum('TRUE','FALSE')")
                .HasColumnName("ispublic");
            entity.Property(e => e.Issn)
                .HasMaxLength(32)
                .HasColumnName("issn");
            entity.Property(e => e.Journal)
                .HasMaxLength(255)
                .HasColumnName("journal");
            entity.Property(e => e.Keywords)
                .HasColumnType("text")
                .HasColumnName("keywords");
            entity.Property(e => e.Lastpage)
                .HasMaxLength(10)
                .HasColumnName("lastpage");
            entity.Property(e => e.Location)
                .HasMaxLength(127)
                .HasColumnName("location");
            entity.Property(e => e.Mark).HasColumnName("mark");
            entity.Property(e => e.Month)
                .HasMaxLength(255)
                .HasColumnName("month");
            entity.Property(e => e.Namekey)
                .HasMaxLength(255)
                .HasColumnName("namekey");
            entity.Property(e => e.Note)
                .HasColumnType("text")
                .HasColumnName("note");
            entity.Property(e => e.Number)
                .HasMaxLength(255)
                .HasColumnName("number");
            entity.Property(e => e.Organization)
                .HasMaxLength(255)
                .HasColumnName("organization");
            entity.Property(e => e.Peerreviewed)
                .HasMaxLength(3)
                .HasColumnName("peerreviewed");
            entity.Property(e => e.PubType)
                .HasMaxLength(255)
                .HasColumnName("pub_type");
            entity.Property(e => e.Publisher)
                .HasMaxLength(127)
                .HasColumnName("publisher");
            entity.Property(e => e.School)
                .HasMaxLength(255)
                .HasColumnName("school");
            entity.Property(e => e.Series)
                .HasMaxLength(64)
                .HasColumnName("series");
            entity.Property(e => e.Specialchars)
                .HasMaxLength(5)
                .HasColumnName("specialchars");
            entity.Property(e => e.Survey)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("survey");
            entity.Property(e => e.Thomsonindex)
                .HasMaxLength(3)
                .HasColumnName("thomsonindex");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(13)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedBy)
                .HasDefaultValueSql("'0'")
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updated_date");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.Userfields)
                .HasColumnType("text")
                .HasColumnName("userfields");
            entity.Property(e => e.Volume)
                .HasMaxLength(16)
                .HasColumnName("volume");
            entity.Property(e => e.Year)
                .HasMaxLength(12)
                .HasColumnName("year");
        });

        modelBuilder.Entity<BibPublicationauthor>(entity =>
        {
            entity.HasKey(e => new { e.PubId, e.Author, e.IsEditor })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("bib_publicationauthor", tb => tb.HasComment("InnoDB free: 4096 kB"))
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.PubId, "FKBE04B073D0BDA37");

            entity.HasIndex(e => e.Author, "FK_BA_BPA");

            entity.Property(e => e.PubId).HasColumnName("pub_id");
            entity.Property(e => e.Author).HasColumnName("author");
            entity.Property(e => e.IsEditor)
                .HasMaxLength(1)
                .HasDefaultValueSql("''")
                .HasColumnName("is_editor");
            entity.Property(e => e.Rank).HasColumnName("rank");

            entity.HasOne(d => d.AuthorNavigation).WithMany(p => p.BibPublicationauthors)
                .HasForeignKey(d => d.Author)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKBE04B073D08EBFE8");

            entity.HasOne(d => d.Pub).WithMany(p => p.BibPublicationauthors)
                .HasForeignKey(d => d.PubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKBE04B073D0BDA37");
        });

        modelBuilder.Entity<Booleanpreference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("booleanpreference")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Id, "FKF7D33303225C6812");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.PreferenceValue)
                .HasColumnType("bit(1)")
                .HasColumnName("preferenceValue");
        });

        modelBuilder.Entity<Committee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("committee")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chair)
                .HasMaxLength(255)
                .HasColumnName("chair");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("country")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsoCode)
                .HasMaxLength(255)
                .HasColumnName("isoCode");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("course")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Datepreference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("datepreference")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Id, "FK98601BEC225C6812");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.PreferenceValue)
                .HasColumnType("datetime")
                .HasColumnName("preferenceValue");
        });

        modelBuilder.Entity<Irsachievement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("irsachievement")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.ActivityId, "FK186368856C382917");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Achievement).HasColumnName("achievement");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.Completion)
                .HasMaxLength(50)
                .HasColumnName("completion");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Activity).WithMany(p => p.Irsachievements)
                .HasForeignKey(d => d.ActivityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK186368856C382917");
        });

        modelBuilder.Entity<Irsachievementattachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("irsachievementattachments")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.IrsachievementId, "FK3D93F5EB8C550B67");

            entity.HasIndex(e => e.AttachmentsId, "FK3D93F5EBEA8EA62");

            entity.Property(e => e.AttachmentsId).HasColumnName("attachments_id");
            entity.Property(e => e.IrsachievementId).HasColumnName("IRSAchievement_id");

            entity.HasOne(d => d.Attachments).WithMany()
                .HasForeignKey(d => d.AttachmentsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK3D93F5EBEA8EA62");

            entity.HasOne(d => d.Irsachievement).WithMany()
                .HasForeignKey(d => d.IrsachievementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK3D93F5EB8C550B67");
        });

        modelBuilder.Entity<Irsactivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("irsactivity")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.UserId, "FK6813897936E9810D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityYear).HasColumnName("activityYear");
            entity.Property(e => e.AdditionalSuggestions)
                .HasColumnType("blob")
                .HasColumnName("additionalSuggestions");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.EntryYear).HasColumnName("entryYear");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.NextYearGoals)
                .HasColumnType("blob")
                .HasColumnName("nextYearGoals");
            entity.Property(e => e.ResponsibilityChanges)
                .HasColumnType("blob")
                .HasColumnName("responsibilityChanges");
            entity.Property(e => e.ResponsibilityOutputs)
                .HasColumnType("blob")
                .HasColumnName("responsibilityOutputs");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SuccessAndChallenges)
                .HasColumnType("blob")
                .HasColumnName("successAndChallenges");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.User).WithMany(p => p.Irsactivities)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK6813897936E9810D");
        });

        modelBuilder.Entity<Irsattachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("irsattachment")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.DiskPath, "diskPath").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(100)
                .HasColumnName("contentType");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.DiskPath)
                .HasMaxLength(200)
                .HasColumnName("diskPath");
            entity.Property(e => e.Downloads).HasColumnName("downloads");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .HasColumnName("fileName");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Irskpi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("irskpi")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.WorkplanId, "FK830DA6FA7E072537");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activity).HasColumnName("activity");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.Kpitext).HasColumnName("kpitext");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.MileStoneQtr1).HasColumnName("mileStoneQtr1");
            entity.Property(e => e.MileStoneQtr2).HasColumnName("mileStoneQtr2");
            entity.Property(e => e.MileStoneQtr3).HasColumnName("mileStoneQtr3");
            entity.Property(e => e.MileStoneQtr4).HasColumnName("mileStoneQtr4");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.WorkplanId).HasColumnName("workplan_id");

            entity.HasOne(d => d.Workplan).WithMany(p => p.Irskpis)
                .HasForeignKey(d => d.WorkplanId)
                .HasConstraintName("FK830DA6FA7E072537");
        });

        modelBuilder.Entity<Irskpiachievement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("irskpiachievement")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.KpiId, "FK831E4FD5400CEF5D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Achievement).HasColumnName("achievement");
            entity.Property(e => e.Completion)
                .HasMaxLength(50)
                .HasColumnName("completion");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.KpiId).HasColumnName("kpi_id");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Kpi).WithMany(p => p.Irskpiachievements)
                .HasForeignKey(d => d.KpiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK831E4FD5400CEF5D");
        });

        modelBuilder.Entity<Irsworkplan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("irsworkplan")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.UserId, "FKCCE7F82436E9810D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("dateUpdated");
            entity.Property(e => e.Indicators).HasColumnName("indicators");
            entity.Property(e => e.Objective).HasColumnName("objective");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.User).WithMany(p => p.Irsworkplans)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKCCE7F82436E9810D");
        });

        modelBuilder.Entity<Kpi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("kpi")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.WorkplanId, "FK12384D49F4802");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activity).HasColumnName("activity");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.Kpitext).HasColumnName("kpitext");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.MileStoneQtr1).HasColumnName("mileStoneQtr1");
            entity.Property(e => e.MileStoneQtr2).HasColumnName("mileStoneQtr2");
            entity.Property(e => e.MileStoneQtr3).HasColumnName("mileStoneQtr3");
            entity.Property(e => e.MileStoneQtr4).HasColumnName("mileStoneQtr4");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.WorkplanId).HasColumnName("workplan_id");

            entity.HasOne(d => d.Workplan).WithMany(p => p.Kpis)
                .HasForeignKey(d => d.WorkplanId)
                .HasConstraintName("FK12384D49F4802");
        });

        modelBuilder.Entity<Kpiachievement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("kpiachievement")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.KpiId, "FKB228790B33657DB2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Achievement).HasColumnName("achievement");
            entity.Property(e => e.Completion)
                .HasMaxLength(50)
                .HasColumnName("completion");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.KpiId).HasColumnName("kpi_id");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Kpi).WithMany(p => p.Kpiachievements)
                .HasForeignKey(d => d.KpiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKB228790B33657DB2");
        });

        modelBuilder.Entity<Learning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("learning")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.UserId, "FK61AED73E36E9810D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.User).WithMany(p => p.Learnings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK61AED73E36E9810D");
        });

        modelBuilder.Entity<Learningattachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("learningattachment")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.DiskPath, "diskPath").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(100)
                .HasColumnName("contentType");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.DiskPath)
                .HasMaxLength(200)
                .HasColumnName("diskPath");
            entity.Property(e => e.Downloads).HasColumnName("downloads");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .HasColumnName("fileName");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Learningattachment1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("learningattachments")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AttachmentsId, "FKABD849927AE42CD4");

            entity.HasIndex(e => e.LearningId, "FKABD84992D77C5E23");

            entity.Property(e => e.AttachmentsId).HasColumnName("attachments_id");
            entity.Property(e => e.LearningId).HasColumnName("Learning_id");

            entity.HasOne(d => d.Attachments).WithMany()
                .HasForeignKey(d => d.AttachmentsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKABD849927AE42CD4");

            entity.HasOne(d => d.Learning).WithMany()
                .HasForeignKey(d => d.LearningId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKABD84992D77C5E23");
        });

        modelBuilder.Entity<MtpAchievement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mtp_achievement")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Achievement)
                .HasColumnName("achievement")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Activitynum).HasColumnName("activitynum");
            entity.Property(e => e.Comment)
                .HasColumnName("comment")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Completion).HasColumnName("completion");
            entity.Property(e => e.FileEvidence)
                .HasMaxLength(300)
                .HasColumnName("file_evidence");
            entity.Property(e => e.Mtprecid).HasColumnName("mtprecid");
            entity.Property(e => e.Regdate)
                .HasColumnType("datetime")
                .HasColumnName("regdate");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<MtpLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mtp_login")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Iitauserid).HasColumnName("IITAUSERID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Staffname)
                .HasColumnType("text")
                .HasColumnName("staffname");
        });

        modelBuilder.Entity<MtpMtp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mtp_mtp")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ActivitiesAndTimeAllocation).HasColumnName("Activities_and_time_allocation");
            entity.Property(e => e.Activity2).HasColumnName("activity2");
            entity.Property(e => e.Activity3).HasColumnName("activity3");
            entity.Property(e => e.ActivityYear).HasColumnName("activity_year");
            entity.Property(e => e.ActualOutcome).HasColumnName("actual_outcome");
            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .HasColumnName("category");
            entity.Property(e => e.Cgpriority)
                .HasMaxLength(50)
                .HasColumnName("cgpriority");
            entity.Property(e => e.Cmt1).HasColumnName("cmt1");
            entity.Property(e => e.Cmt2).HasColumnName("cmt2");
            entity.Property(e => e.Cmt3).HasColumnName("cmt3");
            entity.Property(e => e.CoreCenter).HasColumnName("core_center");
            entity.Property(e => e.CoreCenter2).HasColumnName("core_center2");
            entity.Property(e => e.CoreCenter3).HasColumnName("core_center3");
            entity.Property(e => e.CostCenter).HasColumnName("cost_center");
            entity.Property(e => e.CostCenter2).HasColumnName("cost_center2");
            entity.Property(e => e.CostCenter3).HasColumnName("cost_center3");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.EntryYear).HasColumnName("entry_Year");
            entity.Property(e => e.FileEvy)
                .HasMaxLength(100)
                .HasColumnName("file_evy");
            entity.Property(e => e.FileEvy2).HasColumnName("file_evy2");
            entity.Property(e => e.FileEvy3).HasColumnName("file_evy3");
            entity.Property(e => e.Iitauserid).HasColumnName("IITAUSERID");
            entity.Property(e => e.Impact).HasMaxLength(255);
            entity.Property(e => e.IntendedUser)
                .HasMaxLength(255)
                .HasColumnName("Intended_User");
            entity.Property(e => e.IntendedUser2)
                .HasMaxLength(255)
                .HasColumnName("intended_user2");
            entity.Property(e => e.IntendedUser3)
                .HasMaxLength(255)
                .HasColumnName("intended_user3");
            entity.Property(e => e.MilestonesDec).HasColumnName("Milestones_Dec");
            entity.Property(e => e.MilestonesDec2).HasColumnName("milestones_dec2");
            entity.Property(e => e.MilestonesDec3).HasColumnName("milestones_dec3");
            entity.Property(e => e.MilestonesJun).HasColumnName("Milestones_Jun");
            entity.Property(e => e.MilestonesJun2).HasColumnName("milestones_jun2");
            entity.Property(e => e.MilestonesJun3).HasColumnName("milestones_jun3");
            entity.Property(e => e.MilestonesMar).HasColumnName("Milestones_Mar");
            entity.Property(e => e.MilestonesMar2).HasColumnName("milestones_mar2");
            entity.Property(e => e.MilestonesMar3).HasColumnName("milestones_mar3");
            entity.Property(e => e.MilestonesSep).HasColumnName("Milestones_Sep");
            entity.Property(e => e.MilestonesSep2).HasColumnName("milestones_sep2");
            entity.Property(e => e.MilestonesSep3).HasColumnName("milestones_sep3");
            entity.Property(e => e.Mtp)
                .HasMaxLength(255)
                .HasColumnName("mtp");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Outcome).HasMaxLength(255);
            entity.Property(e => e.OutputTarget).HasColumnName("Output_Target");
            entity.Property(e => e.Outputs).HasMaxLength(255);
            entity.Property(e => e.Region).HasColumnName("region");
            entity.Property(e => e.Region2).HasColumnName("region2");
            entity.Property(e => e.Region3).HasColumnName("region3");
            entity.Property(e => e.StaffTime).HasColumnName("staff_time");
            entity.Property(e => e.StaffTime2).HasColumnName("staff_time2");
            entity.Property(e => e.StaffTime3).HasColumnName("staff_time3");
            entity.Property(e => e.SubmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("submission_date");
            entity.Property(e => e.TotalTime).HasColumnName("total_time");
            entity.Property(e => e.TotalTime2).HasColumnName("total_time2");
            entity.Property(e => e.TotalTime3).HasColumnName("total_time3");
            entity.Property(e => e.UpdatedOutputTarget).HasColumnName("Updated_Output_Target");
            entity.Property(e => e.Wght1)
                .HasMaxLength(50)
                .HasColumnName("wght1");
            entity.Property(e => e.Wght2)
                .HasMaxLength(50)
                .HasColumnName("wght2");
            entity.Property(e => e.Wght3)
                .HasMaxLength(50)
                .HasColumnName("wght3");
        });

        modelBuilder.Entity<MtpWorkplan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mtp_workplan")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ActivitiesAndTimeAllocation).HasColumnName("Activities_and_time_allocation");
            entity.Property(e => e.Activity2).HasColumnName("activity2");
            entity.Property(e => e.Activity3).HasColumnName("activity3");
            entity.Property(e => e.ActivityYear).HasColumnName("activity_year");
            entity.Property(e => e.ActualOutcome).HasColumnName("actual_outcome");
            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .HasColumnName("category");
            entity.Property(e => e.Cgpriority)
                .HasMaxLength(50)
                .HasColumnName("cgpriority");
            entity.Property(e => e.Cmt1).HasColumnName("cmt1");
            entity.Property(e => e.Cmt2).HasColumnName("cmt2");
            entity.Property(e => e.Cmt3).HasColumnName("cmt3");
            entity.Property(e => e.CoreCenter)
                .HasMaxLength(255)
                .HasColumnName("core_center");
            entity.Property(e => e.CoreCenter2)
                .HasMaxLength(255)
                .HasColumnName("core_center2");
            entity.Property(e => e.CoreCenter3)
                .HasMaxLength(255)
                .HasColumnName("core_center3");
            entity.Property(e => e.CostCenter)
                .HasMaxLength(255)
                .HasColumnName("cost_center");
            entity.Property(e => e.CostCenter2)
                .HasMaxLength(255)
                .HasColumnName("cost_center2");
            entity.Property(e => e.CostCenter3)
                .HasMaxLength(255)
                .HasColumnName("cost_center3");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.EntryYear).HasColumnName("entry_Year");
            entity.Property(e => e.FileEvy)
                .HasMaxLength(255)
                .HasColumnName("file_evy");
            entity.Property(e => e.FileEvy2)
                .HasMaxLength(255)
                .HasColumnName("file_evy2");
            entity.Property(e => e.FileEvy3)
                .HasMaxLength(255)
                .HasColumnName("file_evy3");
            entity.Property(e => e.Iitauserid).HasColumnName("IITAUSERID");
            entity.Property(e => e.Impact).HasMaxLength(255);
            entity.Property(e => e.IntendedUser)
                .HasMaxLength(255)
                .HasColumnName("intended_user");
            entity.Property(e => e.IntendedUser2)
                .HasMaxLength(255)
                .HasColumnName("intended_user2");
            entity.Property(e => e.IntendedUser3)
                .HasMaxLength(255)
                .HasColumnName("intended_user3");
            entity.Property(e => e.MilestonesDec).HasColumnName("Milestones_Dec");
            entity.Property(e => e.MilestonesDec2).HasColumnName("milestones_dec2");
            entity.Property(e => e.MilestonesDec3).HasColumnName("milestones_dec3");
            entity.Property(e => e.MilestonesJun).HasColumnName("Milestones_Jun");
            entity.Property(e => e.MilestonesJun2).HasColumnName("milestones_jun2");
            entity.Property(e => e.MilestonesJun3).HasColumnName("milestones_jun3");
            entity.Property(e => e.MilestonesMar).HasColumnName("Milestones_Mar");
            entity.Property(e => e.MilestonesMar2).HasColumnName("milestones_mar2");
            entity.Property(e => e.MilestonesMar3).HasColumnName("milestones_mar3");
            entity.Property(e => e.MilestonesSep).HasColumnName("Milestones_Sep");
            entity.Property(e => e.MilestonesSep2).HasColumnName("milestones_sep2");
            entity.Property(e => e.MilestonesSep3).HasColumnName("milestones_sep3");
            entity.Property(e => e.Mtp)
                .HasMaxLength(255)
                .HasColumnName("mtp");
            entity.Property(e => e.MtpoutputId).HasColumnName("mtpoutputID");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Outcome).HasMaxLength(255);
            entity.Property(e => e.OutputTarget).HasColumnName("Output_Target");
            entity.Property(e => e.Outputs).HasMaxLength(255);
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .HasColumnName("region");
            entity.Property(e => e.Region2)
                .HasMaxLength(100)
                .HasColumnName("region2");
            entity.Property(e => e.Region3)
                .HasMaxLength(100)
                .HasColumnName("region3");
            entity.Property(e => e.StaffTime).HasColumnName("staff_time");
            entity.Property(e => e.StaffTime2).HasColumnName("staff_time2");
            entity.Property(e => e.StaffTime3).HasColumnName("staff_time3");
            entity.Property(e => e.StatusCmt)
                .HasMaxLength(255)
                .HasColumnName("status_cmt");
            entity.Property(e => e.StatusSysdate)
                .HasColumnType("datetime")
                .HasColumnName("status_sysdate");
            entity.Property(e => e.SubmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("submission_date");
            entity.Property(e => e.TotalTime).HasColumnName("total_time");
            entity.Property(e => e.TotalTime2).HasColumnName("total_time2");
            entity.Property(e => e.TotalTime3).HasColumnName("total_time3");
            entity.Property(e => e.UpdatedOutputTarget).HasColumnName("Updated_Output_Target");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Wght1)
                .HasMaxLength(50)
                .HasColumnName("wght1");
            entity.Property(e => e.Wght2)
                .HasMaxLength(50)
                .HasColumnName("wght2");
            entity.Property(e => e.Wght3)
                .HasMaxLength(50)
                .HasColumnName("wght3");
            entity.Property(e => e.WkpStatus)
                .HasMaxLength(10)
                .HasColumnName("wkp_status");
        });

        modelBuilder.Entity<Mtpdocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mtpdocument")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.EndYear).HasColumnName("endYear");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Narrative).HasColumnName("narrative");
            entity.Property(e => e.StartYear).HasColumnName("startYear");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("notification")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.SubscriberNotificationId, "FK2D45DD0B89944C95");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.OriginAppName)
                .HasMaxLength(200)
                .HasColumnName("originAppName");
            entity.Property(e => e.Read)
                .HasColumnType("bit(1)")
                .HasColumnName("read");
            entity.Property(e => e.SubscriberNotificationId).HasColumnName("subscriberNotificationId");
            entity.Property(e => e.Title).HasColumnName("title");

            entity.HasOne(d => d.SubscriberNotification).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.SubscriberNotificationId)
                .HasConstraintName("FK2D45DD0B89944C95");
        });

        modelBuilder.Entity<NrsWorkplan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("nrs_workplan", tb => tb.HasComment("NRS Workplan"))
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.UserId, "FK60B00CCA36E9810D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("dateUpdated");
            entity.Property(e => e.Indicators).HasColumnName("indicators");
            entity.Property(e => e.Objective).HasColumnName("objective");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.User).WithMany(p => p.NrsWorkplans)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK60B00CCA36E9810D");
        });

        modelBuilder.Entity<Nrsachievement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("nrsachievement")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.WorkplanId, "FK81B858A0D49F4802");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Achievement).HasColumnName("achievement");
            entity.Property(e => e.Comment)
                .HasColumnName("comment")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.WorkplanId).HasColumnName("workplan_id");

            entity.HasOne(d => d.Workplan).WithMany(p => p.Nrsachievements)
                .HasForeignKey(d => d.WorkplanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK81B858A0D49F4802");
        });

        modelBuilder.Entity<Nrsachievementattachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nrsachievementattachments")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.NrsachievementId, "FKD28576F05FD4BC22");

            entity.HasIndex(e => e.AttachmentsId, "FKD28576F0E91BE234");

            entity.Property(e => e.AttachmentsId).HasColumnName("attachments_id");
            entity.Property(e => e.NrsachievementId).HasColumnName("NRSAchievement_id");

            entity.HasOne(d => d.Attachments).WithMany()
                .HasForeignKey(d => d.AttachmentsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKD28576F0E91BE234");

            entity.HasOne(d => d.Nrsachievement).WithMany()
                .HasForeignKey(d => d.NrsachievementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKD28576F05FD4BC22");
        });

        modelBuilder.Entity<Nrsattachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("nrsattachment")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.DiskPath, "diskPath").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(100)
                .HasColumnName("contentType");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.DiskPath)
                .HasMaxLength(200)
                .HasColumnName("diskPath");
            entity.Property(e => e.Downloads).HasColumnName("downloads");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .HasColumnName("fileName");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Numberpreference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("numberpreference")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Id, "FKBC0CF124225C6812");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.PreferenceValue)
                .HasPrecision(19, 2)
                .HasColumnName("preferenceValue");
        });

        modelBuilder.Entity<Output>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("output")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ProjectId, "FK8D7605213F37BA05");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CgiarAlignment)
                .HasMaxLength(300)
                .HasColumnName("cgiarAlignment");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Impact)
                .HasMaxLength(1500)
                .HasColumnName("impact");
            entity.Property(e => e.IntendedUser)
                .HasMaxLength(255)
                .HasColumnName("intendedUser");
            entity.Property(e => e.IpgNarrative).HasColumnName("ipgNarrative");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Outcome)
                .HasMaxLength(1500)
                .HasColumnName("outcome");
            entity.Property(e => e.PartnersNarrative).HasColumnName("partnersNarrative");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Title)
                .HasMaxLength(300)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Project).WithMany(p => p.Outputs)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK8D7605213F37BA05");
        });

        modelBuilder.Entity<Outputtarget>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("outputtarget")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.OutputId, "FK2AF4612A701F1CF");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.OutputId).HasColumnName("output_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Types)
                .HasMaxLength(255)
                .HasColumnName("types");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.Output).WithMany(p => p.Outputtargets)
                .HasForeignKey(d => d.OutputId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK2AF4612A701F1CF");
        });

        modelBuilder.Entity<P4dachievement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4dachievement")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ActivityId, "FKDEB0782FF576FB63");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Achievement).HasColumnName("achievement");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.Completion)
                .HasMaxLength(255)
                .HasColumnName("completion");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Activity).WithMany(p => p.P4dachievements)
                .HasForeignKey(d => d.ActivityId)
                .HasConstraintName("FKDEB0782FF576FB63");
        });

        modelBuilder.Entity<P4dachievementattachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("p4dachievementattachments")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.P4dachievementId, "FKF9CF58014165A1D1");

            entity.HasIndex(e => e.AttachmentsId, "FKF9CF5801E20EDAF6");

            entity.Property(e => e.AttachmentsId).HasColumnName("attachments_id");
            entity.Property(e => e.P4dachievementId).HasColumnName("P4DAchievement_id");

            entity.HasOne(d => d.Attachments).WithMany()
                .HasForeignKey(d => d.AttachmentsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKF9CF5801E20EDAF6");

            entity.HasOne(d => d.P4dachievement).WithMany()
                .HasForeignKey(d => d.P4dachievementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKF9CF58014165A1D1");
        });

        modelBuilder.Entity<P4dactivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4dactivity")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.WorkplanId, "FK29B6AA0F745F783");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activity).HasColumnName("activity");
            entity.Property(e => e.AllocatedTime)
                .HasMaxLength(255)
                .HasColumnName("allocatedTime");
            entity.Property(e => e.CoreCenter)
                .HasMaxLength(150)
                .HasColumnName("coreCenter");
            entity.Property(e => e.CostCenter)
                .HasMaxLength(150)
                .HasColumnName("costCenter");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CrpPartners)
                .HasMaxLength(255)
                .HasColumnName("crpPartners");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.InternalIita)
                .HasMaxLength(255)
                .HasColumnName("internalIITA");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.MileStoneQtr1).HasColumnName("mileStoneQtr1");
            entity.Property(e => e.MileStoneQtr2).HasColumnName("mileStoneQtr2");
            entity.Property(e => e.MileStoneQtr3).HasColumnName("mileStoneQtr3");
            entity.Property(e => e.MileStoneQtr4).HasColumnName("mileStoneQtr4");
            entity.Property(e => e.OtherExternal).HasColumnName("otherExternal");
            entity.Property(e => e.ProposedBudget).HasColumnName("proposedBudget");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.WorkplanId).HasColumnName("workplan_id");

            entity.HasOne(d => d.Workplan).WithMany(p => p.P4dactivities)
                .HasForeignKey(d => d.WorkplanId)
                .HasConstraintName("FK29B6AA0F745F783");
        });

        modelBuilder.Entity<P4dattachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4dattachment")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.DiskPath, "diskPath").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(100)
                .HasColumnName("contentType");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.DiskPath)
                .HasMaxLength(200)
                .HasColumnName("diskPath");
            entity.Property(e => e.Downloads).HasColumnName("downloads");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .HasColumnName("fileName");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<P4dcrp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4dcrps")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<P4dmtpdocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4dmtpdocument")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.EndYear).HasColumnName("endYear");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Narrative).HasColumnName("narrative");
            entity.Property(e => e.StartYear).HasColumnName("startYear");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<P4doutput>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4doutput")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.P4DprojectId, "FK9BD90012423F511");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CgiarAlignment).HasColumnName("cgiarAlignment");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Impact).HasColumnName("impact");
            entity.Property(e => e.IntendedUser)
                .HasMaxLength(255)
                .HasColumnName("intendedUser");
            entity.Property(e => e.IpgNarrative).HasColumnName("ipgNarrative");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Outcome).HasColumnName("outcome");
            entity.Property(e => e.P4DprojectId).HasColumnName("p4DProject_id");
            entity.Property(e => e.PartnersNarrative).HasColumnName("partnersNarrative");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.P4Dproject).WithMany(p => p.P4doutputs)
                .HasForeignKey(d => d.P4DprojectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK9BD90012423F511");
        });

        modelBuilder.Entity<P4doutputtarget>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4doutputtarget")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.P4DoutputId, "FK531B28F28D5C2543");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.P4DoutputId).HasColumnName("p4DOutput_id");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Types)
                .HasMaxLength(150)
                .HasColumnName("types");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.P4Doutput).WithMany(p => p.P4doutputtargets)
                .HasForeignKey(d => d.P4DoutputId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK531B28F28D5C2543");
        });

        modelBuilder.Entity<P4dproject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4dproject")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MtpDocumentId, "FK5D72B41987B20AB1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.IpgNarrative).HasColumnName("ipgNarrative");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.MtpDocumentId).HasColumnName("mtpDocument_id");
            entity.Property(e => e.Narrative).HasColumnName("narrative");
            entity.Property(e => e.P4DoutputsNarrative).HasColumnName("p4DOutputsNarrative");
            entity.Property(e => e.PartnersNarrative).HasColumnName("partnersNarrative");
            entity.Property(e => e.Title)
                .HasMaxLength(80)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.MtpDocument).WithMany(p => p.P4dprojects)
                .HasForeignKey(d => d.MtpDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK5D72B41987B20AB1");
        });

        modelBuilder.Entity<P4dsupportachievement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4dsupportachievement")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ActivityId, "FKA44306E09056677F");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Achievement).HasColumnName("achievement");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.Completion)
                .HasMaxLength(50)
                .HasColumnName("completion");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Activity).WithMany(p => p.P4dsupportachievements)
                .HasForeignKey(d => d.ActivityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKA44306E09056677F");
        });

        modelBuilder.Entity<P4dsupportachievementattachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("p4dsupportachievementattachments")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AttachmentsId, "FK408B60B042C3B012");

            entity.HasIndex(e => e.P4dsupportAchievementId, "FK408B60B044B56F84");

            entity.Property(e => e.AttachmentsId).HasColumnName("attachments_id");
            entity.Property(e => e.P4dsupportAchievementId).HasColumnName("P4DSupportAchievement_id");

            entity.HasOne(d => d.Attachments).WithMany()
                .HasForeignKey(d => d.AttachmentsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK408B60B042C3B012");

            entity.HasOne(d => d.P4dsupportAchievement).WithMany()
                .HasForeignKey(d => d.P4dsupportAchievementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK408B60B044B56F84");
        });

        modelBuilder.Entity<P4dsupportactivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4dsupportactivity")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.UserId, "FKF66900FE36E9810D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityYear).HasColumnName("activityYear");
            entity.Property(e => e.AdditionalSuggestions).HasColumnName("additionalSuggestions");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.EntryYear).HasColumnName("entryYear");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.NextYearGoals).HasColumnName("nextYearGoals");
            entity.Property(e => e.ResponsibilityChanges).HasColumnName("responsibilityChanges");
            entity.Property(e => e.ResponsibilityOutputs).HasColumnName("responsibilityOutputs");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SuccessAndChallenges).HasColumnName("successAndChallenges");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.User).WithMany(p => p.P4dsupportactivities)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKF66900FE36E9810D");
        });

        modelBuilder.Entity<P4dsupportattachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4dsupportattachment")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.DiskPath, "diskPath").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(100)
                .HasColumnName("contentType");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.DiskPath)
                .HasMaxLength(200)
                .HasColumnName("diskPath");
            entity.Property(e => e.Downloads).HasColumnName("downloads");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .HasColumnName("fileName");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<P4dsupportworkplan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4dsupportworkplan")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.UserId, "FK5B3D6FA936E9810D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("dateUpdated");
            entity.Property(e => e.Indicators).HasColumnName("indicators");
            entity.Property(e => e.Objective).HasColumnName("objective");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.User).WithMany(p => p.P4dsupportworkplans)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK5B3D6FA936E9810D");
        });

        modelBuilder.Entity<P4dworkplan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("p4dworkplan")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.UserId, "FK8E8B18BA36E9810D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityYear).HasColumnName("activityYear");
            entity.Property(e => e.ActualOutcome).HasColumnName("actualOutcome");
            entity.Property(e => e.BeneficiaryCountries).HasColumnName("beneficiaryCountries");
            entity.Property(e => e.Categories)
                .HasMaxLength(150)
                .HasColumnName("categories");
            entity.Property(e => e.CgPriorities)
                .HasMaxLength(255)
                .HasColumnName("cgPriorities");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.EntryYear).HasColumnName("entryYear");
            entity.Property(e => e.Impact).HasColumnName("impact");
            entity.Property(e => e.IntendedUser).HasColumnName("intendedUser");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.OpenAccess)
                .HasMaxLength(5)
                .HasColumnName("openAccess");
            entity.Property(e => e.Outcome).HasColumnName("outcome");
            entity.Property(e => e.OutcomePathway).HasColumnName("outcomePathway");
            entity.Property(e => e.OutputTarget).HasColumnName("outputTarget");
            entity.Property(e => e.OutputTargetYear).HasColumnName("outputTargetYear");
            entity.Property(e => e.Outputs).HasColumnName("outputs");
            entity.Property(e => e.ProductLine).HasColumnName("productLine");
            entity.Property(e => e.Project)
                .HasMaxLength(150)
                .HasColumnName("project");
            entity.Property(e => e.Region)
                .HasMaxLength(400)
                .HasColumnName("region");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.User).WithMany(p => p.P4dworkplans)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK8E8B18BA36E9810D");
        });

        modelBuilder.Entity<ParReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("par_report")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => new { e.Iitauserid, e.ActivityYear }, "IX_par_report_iitauserid_year").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityYear).HasColumnName("activityYear");
            entity.Property(e => e.CardevConferenceattend).HasColumnName("cardev_conferenceattend");
            entity.Property(e => e.CardevOtherneeds).HasColumnName("cardev_otherneeds");
            entity.Property(e => e.CardevTrainingneeds).HasColumnName("cardev_trainingneeds");
            entity.Property(e => e.Com).HasColumnName("com");
            entity.Property(e => e.ComAttendmeeting).HasColumnName("com_attendmeeting");
            entity.Property(e => e.ComAttendvisitors).HasColumnName("com_attendvisitors");
            entity.Property(e => e.ComFieldtour).HasColumnName("com_fieldtour");
            entity.Property(e => e.ComMediainterview).HasColumnName("com_mediainterview");
            entity.Property(e => e.ComOpenhouse).HasColumnName("com_openhouse");
            entity.Property(e => e.ComPolicymakersmeeting).HasColumnName("com_policymakersmeeting");
            entity.Property(e => e.ComProfhosting).HasColumnName("com_profhosting");
            entity.Property(e => e.ComPubawareness).HasColumnName("com_pubawareness");
            entity.Property(e => e.ComSeminar).HasColumnName("com_seminar");
            entity.Property(e => e.ComServescommittee).HasColumnName("com_servescommittee");
            entity.Property(e => e.ComVisitorscare).HasColumnName("com_visitorscare");
            entity.Property(e => e.ComWebarticles).HasColumnName("com_webarticles");
            entity.Property(e => e.ComWorkingco).HasColumnName("com_workingco");
            entity.Property(e => e.ComWorkshops).HasColumnName("com_workshops");
            entity.Property(e => e.ConstSignificantconstraint).HasColumnName("const_significantconstraint");
            entity.Property(e => e.Iitauserid).HasColumnName("IITAUSERID");
            entity.Property(e => e.Otherprof).HasColumnName("otherprof");
            entity.Property(e => e.OtherprofCommittees).HasColumnName("otherprof_committees");
            entity.Property(e => e.OtherprofOfficialtravels).HasColumnName("otherprof_officialtravels");
            entity.Property(e => e.OtherprofProfsocieties).HasColumnName("otherprof_profsocieties");
            entity.Property(e => e.ProjmManagedprojects)
                .HasColumnName("projm_managedprojects")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.ProjmMgtrole).HasColumnName("projm_mgtrole");
            entity.Property(e => e.ProjmStaffsupervised).HasColumnName("projm_staffsupervised");
            entity.Property(e => e.Qtysc).HasColumnName("qtysc");
            entity.Property(e => e.QtyscAbstracts).HasColumnName("qtysc_abstracts");
            entity.Property(e => e.QtyscAwards).HasColumnName("qtysc_awards");
            entity.Property(e => e.QtyscConsultancies).HasColumnName("qtysc_consultancies");
            entity.Property(e => e.QtyscContribution).HasColumnName("qtysc_contribution");
            entity.Property(e => e.QtyscEditnewsletter).HasColumnName("qtysc_editnewsletter");
            entity.Property(e => e.QtyscInvitedpresentation).HasColumnName("qtysc_invitedpresentation");
            entity.Property(e => e.QtyscReferees).HasColumnName("qtysc_referees");
            entity.Property(e => e.ResmConceptnotes).HasColumnName("resm_conceptnotes");
            entity.Property(e => e.ResmOtherresources).HasColumnName("resm_otherresources");
            entity.Property(e => e.ResmProposals).HasColumnName("resm_proposals");
            entity.Property(e => e.ResmResponsecall).HasColumnName("resm_responsecall");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<ParWorkplan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("par_workplan")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => new { e.User, e.ActivityYear }, "IX_par_workplan_user_year").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityYear).HasColumnName("activityYear");
            entity.Property(e => e.Bibliography).HasColumnName("bibliography");
            entity.Property(e => e.CareerDevelopmentNeed).HasColumnName("careerDevelopmentNeed");
            entity.Property(e => e.Com).HasColumnName("com");
            entity.Property(e => e.ConceptNote).HasColumnName("conceptNote");
            entity.Property(e => e.ManagedProjects).HasColumnName("managedProjects");
            entity.Property(e => e.MgtRole).HasColumnName("mgtRole");
            entity.Property(e => e.OtherResources).HasColumnName("otherResources");
            entity.Property(e => e.Otherprof).HasColumnName("otherprof");
            entity.Property(e => e.PrePublishedMaterial).HasColumnName("prePublishedMaterial");
            entity.Property(e => e.ProjectParticipation).HasColumnName("projectParticipation");
            entity.Property(e => e.ProjectProposal).HasColumnName("projectProposal");
            entity.Property(e => e.Qtysc).HasColumnName("qtysc");
            entity.Property(e => e.ResponseCall).HasColumnName("responseCall");
            entity.Property(e => e.StaffSupervised).HasColumnName("staffSupervised");
            entity.Property(e => e.Trainees).HasColumnName("trainees");
            entity.Property(e => e.TrainingPrograms).HasColumnName("trainingPrograms");
            entity.Property(e => e.Travel).HasColumnName("travel");
            entity.Property(e => e.User).HasColumnName("user");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<PmCorebudget>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_corebudget")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Iitauserid, "FK71DD8326565F36DA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CcBudgetYtd).HasColumnName("CC_BUDGET_YTD");
            entity.Property(e => e.CcCode)
                .HasMaxLength(10)
                .HasColumnName("CC_CODE");
            entity.Property(e => e.CcDescr)
                .HasColumnType("text")
                .HasColumnName("CC_DESCR");
            entity.Property(e => e.CcEncYtd).HasColumnName("CC_ENC_YTD");
            entity.Property(e => e.CcExpYtd).HasColumnName("CC_EXP_YTD");
            entity.Property(e => e.CcFundsAvail).HasColumnName("CC_FUNDS_AVAIL");
            entity.Property(e => e.CcPcentExp).HasColumnName("CC_PCENT_EXP");
            entity.Property(e => e.CcStatus)
                .HasMaxLength(10)
                .HasColumnName("CC_STATUS");
            entity.Property(e => e.Email)
                .HasColumnType("tinytext")
                .HasColumnName("EMAIL");
            entity.Property(e => e.EmailRemind)
                .HasMaxLength(10)
                .HasColumnName("EMAIL_REMIND");
            entity.Property(e => e.Iitauserid).HasColumnName("IITAUSERID");
            entity.Property(e => e.RefreshDate)
                .HasColumnType("datetime")
                .HasColumnName("REFRESH_DATE");

            entity.HasOne(d => d.Iitauser).WithMany(p => p.PmCorebudgets)
                .HasForeignKey(d => d.Iitauserid)
                .HasConstraintName("FK71DD8326565F36DA");
        });

        modelBuilder.Entity<PmCostcenter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_costcenter")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActualExp).HasColumnName("ACTUAL_EXP");
            entity.Property(e => e.Budget).HasColumnName("BUDGET");
            entity.Property(e => e.CcCode)
                .HasMaxLength(6)
                .HasColumnName("CC_CODE");
            entity.Property(e => e.Encumb).HasColumnName("ENCUMB");
            entity.Property(e => e.OtherInc).HasColumnName("OTHER_INC");
            entity.Property(e => e.Rcpts).HasColumnName("RCPTS");
            entity.Property(e => e.RefreshDate)
                .HasColumnType("datetime")
                .HasColumnName("REFRESH_DATE");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<PmExpressionofinterest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_expressionofinterest")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Idea, "idx_pm_ideas_lookup");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ActionsTaken)
                .HasMaxLength(200)
                .HasColumnName("ACTIONS_TAKEN");
            entity.Property(e => e.CenterContribution).HasColumnName("CENTER_CONTRIBUTION");
            entity.Property(e => e.Comments)
                .HasColumnType("text")
                .HasColumnName("COMMENTS");
            entity.Property(e => e.ContractDate)
                .HasColumnType("datetime")
                .HasColumnName("CONTRACT_DATE");
            entity.Property(e => e.Crop)
                .HasMaxLength(225)
                .HasColumnName("CROP");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(225)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Donor)
                .HasColumnType("text")
                .HasColumnName("DONOR");
            entity.Property(e => e.Duration).HasColumnName("DURATION");
            entity.Property(e => e.ExpectedResult)
                .HasColumnType("text")
                .HasColumnName("EXPECTED_RESULT");
            entity.Property(e => e.ExpectedYear).HasColumnName("EXPECTED_YEAR");
            entity.Property(e => e.Goal)
                .HasColumnType("text")
                .HasColumnName("GOAL");
            entity.Property(e => e.Idea)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("IDEA");
            entity.Property(e => e.Leader)
                .HasColumnType("text")
                .HasColumnName("LEADER");
            entity.Property(e => e.Macroproject)
                .HasMaxLength(8)
                .HasColumnName("MACROPROJECT");
            entity.Property(e => e.MtpProject)
                .HasColumnType("text")
                .HasColumnName("MTP_PROJECT");
            entity.Property(e => e.NextSteps)
                .HasMaxLength(200)
                .HasColumnName("NEXT_STEPS");
            entity.Property(e => e.Objective)
                .HasColumnType("text")
                .HasColumnName("OBJECTIVE");
            entity.Property(e => e.PotentialBeneficiaries)
                .HasColumnType("text")
                .HasColumnName("POTENTIAL_BENEFICIARIES");
            entity.Property(e => e.Project)
                .HasMaxLength(20)
                .HasColumnName("PROJECT");
            entity.Property(e => e.Proposal)
                .HasMaxLength(20)
                .HasColumnName("PROPOSAL");
            entity.Property(e => e.Purpose)
                .HasColumnType("text")
                .HasColumnName("PURPOSE");
            entity.Property(e => e.RejectionReason)
                .HasColumnType("text")
                .HasColumnName("REJECTION_REASON");
            entity.Property(e => e.ResearchSite)
                .HasMaxLength(50)
                .HasColumnName("RESEARCH_SITE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("STATUS");
            entity.Property(e => e.Submission)
                .HasColumnType("datetime")
                .HasColumnName("SUBMISSION");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("TITLE");
            entity.Property(e => e.Topic)
                .HasMaxLength(225)
                .HasColumnName("TOPIC");
            entity.Property(e => e.TotalBudget).HasColumnName("TOTAL_BUDGET");
        });

        modelBuilder.Entity<PmExpressionofintereststaff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_expressionofintereststaff")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Carnet)
                .HasMaxLength(8)
                .HasColumnName("CARNET");
            entity.Property(e => e.Idea)
                .HasMaxLength(10)
                .HasColumnName("IDEA");
            entity.Property(e => e.IdeaId).HasColumnName("idea_id");
            entity.Property(e => e.Leader)
                .HasMaxLength(1)
                .HasColumnName("LEADER");
            entity.Property(e => e.Participation).HasColumnName("PARTICIPATION");
            entity.Property(e => e.PersonId).HasColumnName("person_id");
        });

        modelBuilder.Entity<PmFinancialreport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_financialreport")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.Comments)
                .HasMaxLength(1500)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Commitment)
                .HasMaxLength(1)
                .HasColumnName("COMMITMENT");
            entity.Property(e => e.Currency)
                .HasMaxLength(20)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.DelayReason).HasColumnName("DELAY_REASON");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY_DATE");
            entity.Property(e => e.Donor)
                .HasMaxLength(50)
                .HasColumnName("DONOR");
            entity.Property(e => e.EmailRemind)
                .HasMaxLength(10)
                .HasColumnName("EMAIL_REMIND");
            entity.Property(e => e.FinRepId).HasColumnName("FIN_REP_ID");
            entity.Property(e => e.OriginalCurrency).HasColumnName("ORIGINAL_CURRENCY");
            entity.Property(e => e.Partner)
                .HasMaxLength(20)
                .HasColumnName("PARTNER");
            entity.Property(e => e.PeriodFrom)
                .HasColumnType("datetime")
                .HasColumnName("PERIOD_FROM");
            entity.Property(e => e.PeriodTo)
                .HasColumnType("datetime")
                .HasColumnName("PERIOD_TO");
            entity.Property(e => e.Project)
                .HasMaxLength(10)
                .HasColumnName("PROJECT");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.ReportDate)
                .HasColumnType("datetime")
                .HasColumnName("REPORT_DATE");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<PmIdea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_ideas")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Idea, "idx_pm_ideas_lookup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionsTaken)
                .HasMaxLength(200)
                .HasColumnName("ACTIONS_TAKEN");
            entity.Property(e => e.CenterContribution).HasColumnName("CENTER_CONTRIBUTION");
            entity.Property(e => e.Comments)
                .HasColumnType("text")
                .HasColumnName("COMMENTS");
            entity.Property(e => e.ContractDate)
                .HasColumnType("datetime")
                .HasColumnName("CONTRACT_DATE");
            entity.Property(e => e.Crop)
                .HasMaxLength(225)
                .HasColumnName("CROP");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(225)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Donor)
                .HasColumnType("text")
                .HasColumnName("DONOR");
            entity.Property(e => e.Duration).HasColumnName("DURATION");
            entity.Property(e => e.ExpectedResult)
                .HasColumnType("text")
                .HasColumnName("EXPECTED_RESULT");
            entity.Property(e => e.ExpectedYear).HasColumnName("EXPECTED_YEAR");
            entity.Property(e => e.Goal)
                .HasColumnType("text")
                .HasColumnName("GOAL");
            entity.Property(e => e.Idea)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("IDEA");
            entity.Property(e => e.Leader)
                .HasColumnType("text")
                .HasColumnName("LEADER");
            entity.Property(e => e.Macroproject)
                .HasMaxLength(8)
                .HasColumnName("MACROPROJECT");
            entity.Property(e => e.MtpProject)
                .HasColumnType("text")
                .HasColumnName("MTP_PROJECT");
            entity.Property(e => e.NextSteps)
                .HasMaxLength(200)
                .HasColumnName("NEXT_STEPS");
            entity.Property(e => e.Objective)
                .HasColumnType("text")
                .HasColumnName("OBJECTIVE");
            entity.Property(e => e.PotentialBeneficiaries)
                .HasColumnType("text")
                .HasColumnName("POTENTIAL_BENEFICIARIES");
            entity.Property(e => e.Project)
                .HasMaxLength(20)
                .HasColumnName("PROJECT");
            entity.Property(e => e.Proposal)
                .HasMaxLength(20)
                .HasColumnName("PROPOSAL");
            entity.Property(e => e.Purpose)
                .HasColumnType("text")
                .HasColumnName("PURPOSE");
            entity.Property(e => e.RejectionReason)
                .HasColumnType("text")
                .HasColumnName("REJECTION_REASON");
            entity.Property(e => e.ResearchSite)
                .HasMaxLength(50)
                .HasColumnName("RESEARCH_SITE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("STATUS");
            entity.Property(e => e.Submission)
                .HasColumnType("datetime")
                .HasColumnName("SUBMISSION");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("TITLE");
            entity.Property(e => e.Topic)
                .HasMaxLength(225)
                .HasColumnName("TOPIC");
            entity.Property(e => e.TotalBudget).HasColumnName("TOTAL_BUDGET");
        });

        modelBuilder.Entity<PmIdeastaff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_ideastaff")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IdeaId, "FK5946B687188EA540");

            entity.HasIndex(e => e.PersonId, "FK5946B687358D0EFF");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Carnet)
                .HasMaxLength(8)
                .HasColumnName("CARNET");
            entity.Property(e => e.Idea)
                .HasMaxLength(10)
                .HasColumnName("IDEA");
            entity.Property(e => e.IdeaId).HasColumnName("idea_id");
            entity.Property(e => e.Leader)
                .HasMaxLength(1)
                .HasColumnName("LEADER");
            entity.Property(e => e.Participation).HasColumnName("PARTICIPATION");
            entity.Property(e => e.PersonId).HasColumnName("person_id");

            entity.HasOne(d => d.IdeaNavigation).WithMany(p => p.PmIdeastaffs)
                .HasForeignKey(d => d.IdeaId)
                .HasConstraintName("FK5946B687188EA540");

            entity.HasOne(d => d.Person).WithMany(p => p.PmIdeastaffs)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK5946B687358D0EFF");
        });

        modelBuilder.Entity<PmIitacostcenter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_iitacostcenter")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Iitauserid, "FK1FF4BC31565F36DA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CcBoEmail)
                .HasColumnType("text")
                .HasColumnName("CC_BO_EMAIL");
            entity.Property(e => e.CcBudgetYtd).HasColumnName("CC_BUDGET_YTD");
            entity.Property(e => e.CcCode)
                .HasMaxLength(10)
                .HasColumnName("CC_CODE");
            entity.Property(e => e.CcDescr)
                .HasColumnType("text")
                .HasColumnName("CC_DESCR");
            entity.Property(e => e.CcEncYtd).HasColumnName("CC_ENC_YTD");
            entity.Property(e => e.CcExpYtd).HasColumnName("CC_EXP_YTD");
            entity.Property(e => e.CcFundsAvail).HasColumnName("CC_FUNDS_AVAIL");
            entity.Property(e => e.CcPcentExp).HasColumnName("CC_PCENT_EXP");
            entity.Property(e => e.CcStatus)
                .HasMaxLength(10)
                .HasColumnName("CC_STATUS");
            entity.Property(e => e.CcTotExpEncYtd).HasColumnName("CC_TOT_EXP_ENC_YTD");
            entity.Property(e => e.Email)
                .HasColumnType("tinytext")
                .HasColumnName("EMAIL");
            entity.Property(e => e.EmailRemind)
                .HasMaxLength(10)
                .HasColumnName("EMAIL_REMIND");
            entity.Property(e => e.Iitauserid).HasColumnName("IITAUSERID");
            entity.Property(e => e.RefreshDate)
                .HasColumnType("datetime")
                .HasColumnName("REFRESH_DATE");

            entity.HasOne(d => d.Iitauser).WithMany(p => p.PmIitacostcenters)
                .HasForeignKey(d => d.Iitauserid)
                .HasConstraintName("FK1FF4BC31565F36DA");
        });

        modelBuilder.Entity<PmPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_partner")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Acronym)
                .HasMaxLength(255)
                .HasColumnName("ACRONYM");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.AlreadyPartner)
                .HasMaxLength(1)
                .HasColumnName("ALREADY_PARTNER");
            entity.Property(e => e.AreasOfOperation)
                .HasColumnType("text")
                .HasColumnName("AREAS_OF_OPERATION");
            entity.Property(e => e.Cgiar)
                .HasMaxLength(1)
                .HasColumnName("CGIAR");
            entity.Property(e => e.Country)
                .HasMaxLength(200)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.DonorCat)
                .HasMaxLength(50)
                .HasColumnName("DONOR_CAT");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fax)
                .HasMaxLength(255)
                .HasColumnName("FAX");
            entity.Property(e => e.FoundingYear)
                .HasMaxLength(100)
                .HasColumnName("FOUNDING_YEAR");
            entity.Property(e => e.Geogscope)
                .HasMaxLength(100)
                .HasColumnName("GEOGSCOPE");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Partner)
                .HasMaxLength(10)
                .HasColumnName("PARTNER");
            entity.Property(e => e.PartnerSince)
                .HasMaxLength(100)
                .HasColumnName("PARTNER_SINCE");
            entity.Property(e => e.PartnerType)
                .HasMaxLength(1)
                .HasColumnName("PARTNER_TYPE");
            entity.Property(e => e.PartnershipType)
                .HasMaxLength(10)
                .HasColumnName("PARTNERSHIP_TYPE");
            entity.Property(e => e.Partnersite)
                .HasMaxLength(50)
                .HasColumnName("PARTNERSITE");
            entity.Property(e => e.Postal)
                .HasMaxLength(200)
                .HasColumnName("POSTAL");
            entity.Property(e => e.ProjectIndicator).HasColumnName("PROJECT_INDICATOR");
            entity.Property(e => e.ProposalIndicator).HasColumnName("PROPOSAL_INDICATOR");
            entity.Property(e => e.Telephone)
                .HasMaxLength(200)
                .HasColumnName("TELEPHONE");
        });

        modelBuilder.Entity<PmProject>(entity =>
        {
            entity.HasKey(e => e.Project).HasName("PRIMARY");

            entity
                .ToTable("pm_projects")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Idea, "FKF131A87CB5F028D4");

            entity.HasIndex(e => e.Project, "idx_pm_projects_lookup");

            entity.Property(e => e.Project)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("PROJECT");
            entity.Property(e => e.Agreement)
                .HasColumnType("text")
                .HasColumnName("AGREEMENT");
            entity.Property(e => e.AuditPeriodicity).HasColumnName("AUDIT_PERIODICITY");
            entity.Property(e => e.CashflowIndicator).HasColumnName("CASHFLOW_INDICATOR");
            entity.Property(e => e.CiatBudget).HasColumnName("CIAT_BUDGET");
            entity.Property(e => e.ConditionalIndicator)
                .HasMaxLength(1)
                .HasColumnName("CONDITIONAL_INDICATOR");
            entity.Property(e => e.Crop)
                .HasMaxLength(225)
                .HasColumnName("CROP");
            entity.Property(e => e.Currency)
                .HasMaxLength(20)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(225)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.Duration).HasColumnName("DURATION");
            entity.Property(e => e.EmailRemind)
                .HasMaxLength(10)
                .HasColumnName("EMAIL_REMIND");
            entity.Property(e => e.EmailRemind100)
                .HasMaxLength(10)
                .HasColumnName("EMAIL_REMIND_100");
            entity.Property(e => e.EmailRemind30)
                .HasMaxLength(10)
                .HasColumnName("EMAIL_REMIND_30");
            entity.Property(e => e.EmailRemind60)
                .HasMaxLength(10)
                .HasColumnName("EMAIL_REMIND_60");
            entity.Property(e => e.EmailRemind70)
                .HasMaxLength(10)
                .HasColumnName("EMAIL_REMIND_70");
            entity.Property(e => e.EmailRemind90)
                .HasMaxLength(10)
                .HasColumnName("EMAIL_REMIND_90");
            entity.Property(e => e.EndingDate)
                .HasColumnType("datetime")
                .HasColumnName("ENDING_DATE");
            entity.Property(e => e.ExpectedResult)
                .HasColumnType("text")
                .HasColumnName("EXPECTED_RESULT");
            entity.Property(e => e.ExtensionIndicator)
                .HasMaxLength(1)
                .HasColumnName("EXTENSION_INDICATOR");
            entity.Property(e => e.FinancialReport).HasColumnName("FINANCIAL_REPORT");
            entity.Property(e => e.ForWeb)
                .HasMaxLength(1)
                .HasColumnName("FOR_WEB");
            entity.Property(e => e.ForWebEmail)
                .HasMaxLength(10)
                .HasColumnName("FOR_WEB_EMAIL");
            entity.Property(e => e.Goal)
                .HasColumnType("text")
                .HasColumnName("GOAL");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idea)
                .HasMaxLength(20)
                .HasColumnName("IDEA");
            entity.Property(e => e.LastExtensionDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_EXTENSION_DATE");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Macroproject)
                .HasMaxLength(8)
                .HasColumnName("MACROPROJECT");
            entity.Property(e => e.Office)
                .HasMaxLength(50)
                .HasColumnName("OFFICE");
            entity.Property(e => e.OriginalCurrency).HasColumnName("ORIGINAL_CURRENCY");
            entity.Property(e => e.Overhead).HasColumnName("OVERHEAD");
            entity.Property(e => e.PartnerIndicator).HasColumnName("PARTNER_INDICATOR");
            entity.Property(e => e.Pass)
                .HasMaxLength(1)
                .HasColumnName("PASS");
            entity.Property(e => e.PotentialBeneficiaries)
                .HasColumnType("text")
                .HasColumnName("POTENTIAL_BENEFICIARIES");
            entity.Property(e => e.ProjType)
                .HasMaxLength(15)
                .HasColumnName("PROJ_TYPE");
            entity.Property(e => e.ProjectExtension)
                .HasColumnType("datetime")
                .HasColumnName("PROJECT_EXTENSION");
            entity.Property(e => e.Proposal)
                .HasMaxLength(20)
                .HasColumnName("PROPOSAL");
            entity.Property(e => e.Purpose)
                .HasColumnType("text")
                .HasColumnName("PURPOSE");
            entity.Property(e => e.RegionalDd)
                .HasMaxLength(40)
                .HasColumnName("REGIONAL_DD");
            entity.Property(e => e.ResearchSite)
                .HasMaxLength(50)
                .HasColumnName("RESEARCH_SITE");
            entity.Property(e => e.ReviewPeriodicity).HasColumnName("REVIEW_PERIODICITY");
            entity.Property(e => e.StartingDate)
                .HasColumnType("datetime")
                .HasColumnName("STARTING_DATE");
            entity.Property(e => e.Stitle)
                .HasColumnType("text")
                .HasColumnName("STITLE");
            entity.Property(e => e.SubContract)
                .HasMaxLength(1)
                .HasColumnName("SUB_CONTRACT");
            entity.Property(e => e.TechnicalReport).HasColumnName("TECHNICAL_REPORT");
            entity.Property(e => e.TerminationIndicator)
                .HasMaxLength(1)
                .HasColumnName("TERMINATION_INDICATOR");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("TITLE");
            entity.Property(e => e.Topic)
                .HasMaxLength(225)
                .HasColumnName("TOPIC");
            entity.Property(e => e.TotalBudget).HasColumnName("TOTAL_BUDGET");
            entity.Property(e => e.Zone)
                .HasMaxLength(50)
                .HasColumnName("ZONE");
        });

        modelBuilder.Entity<PmProjectcostcenter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_projectcostcenter")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Donor)
                .HasMaxLength(30)
                .HasColumnName("DONOR");
            entity.Property(e => e.DonorContribution).HasColumnName("DONOR_CONTRIBUTION");
            entity.Property(e => e.IitaCc)
                .HasMaxLength(5)
                .HasColumnName("IITA_CC");
            entity.Property(e => e.OriginalCurrency).HasColumnName("ORIGINAL_CURRENCY");
            entity.Property(e => e.PdId).HasColumnName("PD_ID");
            entity.Property(e => e.Project)
                .HasMaxLength(10)
                .HasColumnName("PROJECT");
            entity.Property(e => e.Rate).HasColumnName("RATE");
            entity.Property(e => e.Relationship)
                .HasMaxLength(125)
                .HasColumnName("RELATIONSHIP");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SrcToAgency).HasColumnName("SRC_TO_AGENCY");
        });

        modelBuilder.Entity<PmProjectdocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_projectdocument")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Document)
                .HasMaxLength(255)
                .HasColumnName("DOCUMENT");
            entity.Property(e => e.Project)
                .HasMaxLength(10)
                .HasColumnName("PROJECT");
            entity.Property(e => e.RepId).HasColumnName("REP_ID");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("TITLE");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .HasColumnName("TYPE");
            entity.Property(e => e.UploadedBy)
                .HasMaxLength(20)
                .HasColumnName("UPLOADED_BY");
            entity.Property(e => e.UploadedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPLOADED_ON");
            entity.Property(e => e.Version).HasColumnName("VERSION");
        });

        modelBuilder.Entity<PmProjectstaff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_projectstaff")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Carnet)
                .HasMaxLength(8)
                .HasColumnName("CARNET");
            entity.Property(e => e.Leader)
                .HasMaxLength(1)
                .HasColumnName("LEADER");
            entity.Property(e => e.Participation).HasColumnName("PARTICIPATION");
            entity.Property(e => e.PersonId).HasColumnName("person_id");
            entity.Property(e => e.PjEndDate)
                .HasColumnType("datetime")
                .HasColumnName("PJ_END_DATE");
            entity.Property(e => e.PjStartDate)
                .HasColumnType("datetime")
                .HasColumnName("PJ_START_DATE");
            entity.Property(e => e.Project)
                .HasMaxLength(30)
                .HasColumnName("PROJECT");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.ProjectPosition)
                .HasMaxLength(225)
                .HasColumnName("PROJECT_POSITION");
        });

        modelBuilder.Entity<PmProposal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_proposals")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Proposal, "idx_pm_proposals_lookup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CiatBudget).HasColumnName("CIAT_BUDGET");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(200)
                .HasColumnName("CONTACT_EMAIL");
            entity.Property(e => e.ContractDate)
                .HasColumnType("datetime")
                .HasColumnName("CONTRACT_DATE");
            entity.Property(e => e.Crop)
                .HasMaxLength(225)
                .HasColumnName("CROP");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Discipline)
                .HasMaxLength(225)
                .HasColumnName("DISCIPLINE");
            entity.Property(e => e.DonorReply)
                .HasMaxLength(1)
                .HasColumnName("DONOR_REPLY");
            entity.Property(e => e.Duration).HasColumnName("DURATION");
            entity.Property(e => e.EmailRemind)
                .HasMaxLength(10)
                .HasColumnName("EMAIL_REMIND");
            entity.Property(e => e.ExpectedResult)
                .HasColumnType("text")
                .HasColumnName("EXPECTED_RESULT");
            entity.Property(e => e.ExpectedYear).HasColumnName("EXPECTED_YEAR");
            entity.Property(e => e.Goal)
                .HasColumnType("text")
                .HasColumnName("GOAL");
            entity.Property(e => e.Idea)
                .HasMaxLength(20)
                .HasColumnName("IDEA");
            entity.Property(e => e.Macroproject)
                .HasMaxLength(8)
                .HasColumnName("MACROPROJECT");
            entity.Property(e => e.PotentialBeneficiaries)
                .HasColumnType("text")
                .HasColumnName("POTENTIAL_BENEFICIARIES");
            entity.Property(e => e.Project)
                .HasMaxLength(20)
                .HasColumnName("PROJECT");
            entity.Property(e => e.Proposal)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("PROPOSAL");
            entity.Property(e => e.Purpose)
                .HasColumnType("text")
                .HasColumnName("PURPOSE");
            entity.Property(e => e.RejectionReason)
                .HasColumnType("text")
                .HasColumnName("REJECTION_REASON");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .HasColumnName("REMARKS");
            entity.Property(e => e.ResearchSite)
                .HasMaxLength(50)
                .HasColumnName("RESEARCH_SITE");
            entity.Property(e => e.ResponseDate)
                .HasColumnType("datetime")
                .HasColumnName("RESPONSE_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("STATUS");
            entity.Property(e => e.Submission)
                .HasColumnType("datetime")
                .HasColumnName("SUBMISSION");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("TITLE");
            entity.Property(e => e.Topic)
                .HasMaxLength(225)
                .HasColumnName("TOPIC");
            entity.Property(e => e.TotalBudget).HasColumnName("TOTAL_BUDGET");
        });

        modelBuilder.Entity<PmProposalstaff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_proposalstaff")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ProposalId, "FKB72A806CB6B0FC60");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Carnet)
                .HasMaxLength(8)
                .HasColumnName("CARNET");
            entity.Property(e => e.Leader)
                .HasMaxLength(1)
                .HasColumnName("LEADER");
            entity.Property(e => e.Participation).HasColumnName("PARTICIPATION");
            entity.Property(e => e.PersonId).HasColumnName("person_id");
            entity.Property(e => e.Proposal)
                .HasMaxLength(10)
                .HasColumnName("PROPOSAL");
            entity.Property(e => e.ProposalId).HasColumnName("proposal_id");

            entity.HasOne(d => d.ProposalNavigation).WithMany(p => p.PmProposalstaffs)
                .HasForeignKey(d => d.ProposalId)
                .HasConstraintName("FKB72A806CB6B0FC60");
        });

        modelBuilder.Entity<PmStaff>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PRIMARY");

            entity
                .ToTable("pm_staff")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Iitauserid, "FK_PMS_User");

            entity.Property(e => e.PersonId).HasColumnName("person_id");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category");
            entity.Property(e => e.CategoryType)
                .HasMaxLength(3)
                .HasColumnName("category_type");
            entity.Property(e => e.Classification)
                .HasMaxLength(255)
                .HasColumnName("classification");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.Iitauserid).HasColumnName("IITAUSERID");
            entity.Property(e => e.Institution)
                .HasMaxLength(30)
                .HasColumnName("institution");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("location");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Nationality)
                .HasMaxLength(255)
                .HasColumnName("nationality");
            entity.Property(e => e.Position)
                .HasMaxLength(255)
                .HasColumnName("POSITION");
            entity.Property(e => e.StaffStatus)
                .HasMaxLength(2)
                .HasColumnName("staff_status");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasColumnName("status");

            entity.HasOne(d => d.Iitauser).WithMany(p => p.PmStaffs)
                .HasForeignKey(d => d.Iitauserid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PMS_User");
        });

        modelBuilder.Entity<PmTechnicalreport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pm_technicalreport")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comments)
                .HasMaxLength(800)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.DelayReason)
                .HasMaxLength(800)
                .HasColumnName("DELAY_REASON");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY_DATE");
            entity.Property(e => e.Donor)
                .HasMaxLength(50)
                .HasColumnName("DONOR");
            entity.Property(e => e.EmailRemind)
                .HasMaxLength(10)
                .HasColumnName("EMAIL_REMIND");
            entity.Property(e => e.Partner)
                .HasMaxLength(20)
                .HasColumnName("PARTNER");
            entity.Property(e => e.PeriodFrom)
                .HasColumnType("datetime")
                .HasColumnName("PERIOD_FROM");
            entity.Property(e => e.PeriodTo)
                .HasColumnType("datetime")
                .HasColumnName("PERIOD_TO");
            entity.Property(e => e.Project)
                .HasMaxLength(10)
                .HasColumnName("PROJECT");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.ReportDate)
                .HasColumnType("datetime")
                .HasColumnName("REPORT_DATE");
            entity.Property(e => e.TechRepId).HasColumnName("TECH_REP_ID");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<PreAuthor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pre_author")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Iitauserid, "FK300EBEA7565F36DA");

            entity.Property(e => e.Cleanname)
                .HasMaxLength(255)
                .HasColumnName("cleanname");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("firstname");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Iitauserid).HasColumnName("IITAUSERID");
            entity.Property(e => e.Institute)
                .HasMaxLength(255)
                .HasColumnName("institute");
            entity.Property(e => e.Surname)
                .HasMaxLength(255)
                .HasColumnName("surname");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.Von)
                .HasMaxLength(255)
                .HasColumnName("von");

            entity.HasOne(d => d.Iitauser).WithMany()
                .HasForeignKey(d => d.Iitauserid)
                .HasConstraintName("FK300EBEA7565F36DA");
        });

        modelBuilder.Entity<PrePublication>(entity =>
        {
            entity.HasKey(e => e.PubId).HasName("PRIMARY");

            entity
                .ToTable("pre_publication")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.PubId)
                .ValueGeneratedNever()
                .HasColumnName("pub_id");
            entity.Property(e => e.Abstract)
                .HasColumnType("text")
                .HasColumnName("abstract");
            entity.Property(e => e.Actualyear)
                .HasMaxLength(12)
                .HasColumnName("actualyear");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.BibtexId)
                .HasMaxLength(255)
                .HasColumnName("bibtex_id");
            entity.Property(e => e.Booktitle)
                .HasMaxLength(255)
                .HasColumnName("booktitle");
            entity.Property(e => e.Chapter)
                .HasMaxLength(10)
                .HasColumnName("chapter");
            entity.Property(e => e.Cleanjournal)
                .HasMaxLength(255)
                .HasColumnName("cleanjournal");
            entity.Property(e => e.Cleantitle)
                .HasMaxLength(255)
                .HasColumnName("cleantitle");
            entity.Property(e => e.Crossref)
                .HasMaxLength(255)
                .HasColumnName("crossref");
            entity.Property(e => e.Devcountauth)
                .HasMaxLength(3)
                .HasColumnName("devcountauth");
            entity.Property(e => e.Doi)
                .HasMaxLength(255)
                .HasColumnName("doi");
            entity.Property(e => e.Edition)
                .HasMaxLength(255)
                .HasColumnName("edition");
            entity.Property(e => e.EnteredBy).HasColumnName("entered_by");
            entity.Property(e => e.Firstpage)
                .HasMaxLength(10)
                .HasColumnName("firstpage");
            entity.Property(e => e.Howpublished)
                .HasMaxLength(255)
                .HasColumnName("howpublished");
            entity.Property(e => e.Institution)
                .HasMaxLength(255)
                .HasColumnName("institution");
            entity.Property(e => e.Isbn)
                .HasMaxLength(32)
                .HasColumnName("isbn");
            entity.Property(e => e.Ispublic)
                .HasDefaultValueSql("'FALSE'")
                .HasColumnType("enum('TRUE','FALSE')")
                .HasColumnName("ispublic");
            entity.Property(e => e.Issn)
                .HasMaxLength(32)
                .HasColumnName("issn");
            entity.Property(e => e.Journal)
                .HasMaxLength(255)
                .HasColumnName("journal");
            entity.Property(e => e.Keywords)
                .HasColumnType("text")
                .HasColumnName("keywords");
            entity.Property(e => e.Lastpage)
                .HasMaxLength(10)
                .HasColumnName("lastpage");
            entity.Property(e => e.Location)
                .HasMaxLength(127)
                .HasColumnName("location");
            entity.Property(e => e.Mark).HasColumnName("mark");
            entity.Property(e => e.Month)
                .HasMaxLength(255)
                .HasColumnName("month");
            entity.Property(e => e.Namekey)
                .HasMaxLength(255)
                .HasColumnName("namekey");
            entity.Property(e => e.Note)
                .HasColumnType("text")
                .HasColumnName("note");
            entity.Property(e => e.Number)
                .HasMaxLength(255)
                .HasColumnName("number");
            entity.Property(e => e.Organization)
                .HasMaxLength(255)
                .HasColumnName("organization");
            entity.Property(e => e.Peerreviewed)
                .HasMaxLength(3)
                .HasColumnName("peerreviewed");
            entity.Property(e => e.PubType)
                .HasMaxLength(255)
                .HasColumnName("pub_type");
            entity.Property(e => e.Publisher)
                .HasMaxLength(127)
                .HasColumnName("publisher");
            entity.Property(e => e.School)
                .HasMaxLength(255)
                .HasColumnName("school");
            entity.Property(e => e.Series)
                .HasMaxLength(64)
                .HasColumnName("series");
            entity.Property(e => e.Specialchars)
                .HasMaxLength(5)
                .HasColumnName("specialchars");
            entity.Property(e => e.Survey)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("survey");
            entity.Property(e => e.Thomsonindex)
                .HasMaxLength(3)
                .HasColumnName("thomsonindex");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(13)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedBy)
                .HasDefaultValueSql("'0'")
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updated_date");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.Userfields)
                .HasColumnType("text")
                .HasColumnName("userfields");
            entity.Property(e => e.Volume)
                .HasMaxLength(16)
                .HasColumnName("volume");
            entity.Property(e => e.Year)
                .HasMaxLength(12)
                .HasColumnName("year");
        });

        modelBuilder.Entity<PrePublicationauthor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pre_publicationauthor")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.PubId, "FKFC11CC1B3DC0496C");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author).HasColumnName("author");
            entity.Property(e => e.IsEditor)
                .HasMaxLength(1)
                .HasColumnName("is_editor");
            entity.Property(e => e.PubId).HasColumnName("pub_id");
            entity.Property(e => e.Rank).HasColumnName("rank");

            entity.HasOne(d => d.Pub).WithMany(p => p.PrePublicationauthors)
                .HasForeignKey(d => d.PubId)
                .HasConstraintName("FKFC11CC1B3DC0496C");
        });

        modelBuilder.Entity<Preference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("preference")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.UserId, "FK1FCE98FB36E9810D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BigVal)
                .HasPrecision(19, 2)
                .HasColumnName("bigVal");
            entity.Property(e => e.BoolVal)
                .HasColumnType("bit(1)")
                .HasColumnName("boolVal");
            entity.Property(e => e.CharVal)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("charVal");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateVal)
                .HasColumnType("datetime")
                .HasColumnName("dateVal");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.DoubleVal).HasColumnName("doubleVal");
            entity.Property(e => e.IntVal).HasColumnName("intVal");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.LongVal).HasColumnName("longVal");
            entity.Property(e => e.PreferenceKey)
                .HasMaxLength(255)
                .HasColumnName("preferenceKey");
            entity.Property(e => e.PreferenceType).HasColumnName("preferenceType");
            entity.Property(e => e.StringVal)
                .HasMaxLength(255)
                .HasColumnName("stringVal");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.PreferencesNavigation)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK1FCE98FB36E9810D");
        });

        modelBuilder.Entity<Program>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("program")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Director, "FK50C7B6647768A273");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Director).HasColumnName("director");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.DirectorNavigation).WithMany(p => p.Programs)
                .HasForeignKey(d => d.Director)
                .HasConstraintName("FK50C7B6647768A273");
        });

        modelBuilder.Entity<Programmember>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("programmember")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Member, "FK40BDD21E2880D981").IsUnique();

            entity.HasIndex(e => e.Program, "FK40BDD21E30E9CABF");

            entity.Property(e => e.Member).HasColumnName("member");
            entity.Property(e => e.Program).HasColumnName("program");

            entity.HasOne(d => d.MemberNavigation).WithOne()
                .HasForeignKey<Programmember>(d => d.Member)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK40BDD21E2880D981");

            entity.HasOne(d => d.ProgramNavigation).WithMany()
                .HasForeignKey(d => d.Program)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK40BDD21E30E9CABF");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("project")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MtpDocumentId, "FK50C8E2F9EE59E8C5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.IpgNarrative).HasColumnName("ipgNarrative");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.MtpDocumentId).HasColumnName("mtpDocument_id");
            entity.Property(e => e.Narrative).HasColumnName("narrative");
            entity.Property(e => e.OutputsNarrative).HasColumnName("outputsNarrative");
            entity.Property(e => e.PartnersNarrative).HasColumnName("partnersNarrative");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.MtpDocument).WithMany(p => p.Projects)
                .HasForeignKey(d => d.MtpDocumentId)
                .HasConstraintName("FK50C8E2F9EE59E8C5");
        });

        modelBuilder.Entity<Query>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("query")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllowedRoles).HasColumnName("allowedRoles");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Heads).HasColumnName("heads");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Query1).HasColumnName("query");
            entity.Property(e => e.ShortName)
                .HasMaxLength(100)
                .HasColumnName("shortName");
            entity.Property(e => e.TemplateName)
                .HasMaxLength(200)
                .HasColumnName("templateName");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Queryparameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("queryparameter")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.QueryId, "FK32A3E7E16058DB98");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.QueryId).HasColumnName("query_id");

            entity.HasOne(d => d.Query).WithMany(p => p.Queryparameters)
                .HasForeignKey(d => d.QueryId)
                .HasConstraintName("FK32A3E7E16058DB98");
        });

        modelBuilder.Entity<Srvachievement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("srvachievement")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Achievement).HasColumnName("achievement");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.Completion)
                .HasMaxLength(50)
                .HasColumnName("completion");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Srvachievementattachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("srvachievementattachments")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.AttachmentsId).HasColumnName("attachments_id");
            entity.Property(e => e.SrvachievementId).HasColumnName("SRVAchievement_id");
        });

        modelBuilder.Entity<Srvactivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("srvactivity")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activity).HasColumnName("activity");
            entity.Property(e => e.AllocatedTime)
                .HasMaxLength(255)
                .HasColumnName("allocatedTime");
            entity.Property(e => e.CoreCenter)
                .HasMaxLength(150)
                .HasColumnName("coreCenter");
            entity.Property(e => e.CostCenter)
                .HasMaxLength(150)
                .HasColumnName("costCenter");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CrpPartners)
                .HasMaxLength(255)
                .HasColumnName("crpPartners");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.InternalIita)
                .HasMaxLength(255)
                .HasColumnName("internalIITA");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.MileStoneQtr1).HasColumnName("mileStoneQtr1");
            entity.Property(e => e.MileStoneQtr2).HasColumnName("mileStoneQtr2");
            entity.Property(e => e.MileStoneQtr3).HasColumnName("mileStoneQtr3");
            entity.Property(e => e.MileStoneQtr4).HasColumnName("mileStoneQtr4");
            entity.Property(e => e.OtherExternal).HasColumnName("otherExternal");
            entity.Property(e => e.ProposedBudget).HasColumnName("proposedBudget");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.WorkplanId).HasColumnName("workplan_id");
        });

        modelBuilder.Entity<Srvattachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("srvattachment")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.DiskPath, "diskPath").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(100)
                .HasColumnName("contentType");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.DiskPath)
                .HasMaxLength(200)
                .HasColumnName("diskPath");
            entity.Property(e => e.Downloads).HasColumnName("downloads");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .HasColumnName("fileName");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Srvcrp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("srvcrps")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Srvmtpdocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("srvmtpdocument")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.EndYear).HasColumnName("endYear");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Narrative).HasColumnName("narrative");
            entity.Property(e => e.StartYear).HasColumnName("startYear");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Srvoutput>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("srvoutput")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CgiarAlignment).HasColumnName("cgiarAlignment");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Impact).HasColumnName("impact");
            entity.Property(e => e.IntendedUser)
                .HasMaxLength(255)
                .HasColumnName("intendedUser");
            entity.Property(e => e.IpgNarrative).HasColumnName("ipgNarrative");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Outcome).HasColumnName("outcome");
            entity.Property(e => e.PartnersNarrative).HasColumnName("partnersNarrative");
            entity.Property(e => e.SrvprojectId).HasColumnName("SRVProject_id");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Srvoutputtarget>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("srvoutputtarget")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.SrvoutputId).HasColumnName("SRVOutput_id");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Types)
                .HasMaxLength(150)
                .HasColumnName("types");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Srvproject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("srvproject")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.IpgNarrative).HasColumnName("ipgNarrative");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.MtpDocumentId).HasColumnName("mtpDocument_id");
            entity.Property(e => e.Narrative).HasColumnName("narrative");
            entity.Property(e => e.PartnersNarrative).HasColumnName("partnersNarrative");
            entity.Property(e => e.SrvoutputsNarrative).HasColumnName("SRVOutputsNarrative");
            entity.Property(e => e.Title)
                .HasMaxLength(80)
                .HasColumnName("title");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Srvworkplan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("srvworkplan")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityYear).HasColumnName("activityYear");
            entity.Property(e => e.ActualOutcome).HasColumnName("actualOutcome");
            entity.Property(e => e.BeneficiaryCountries).HasColumnName("beneficiaryCountries");
            entity.Property(e => e.Categories)
                .HasMaxLength(150)
                .HasColumnName("categories");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.EntryYear).HasColumnName("entryYear");
            entity.Property(e => e.Impact).HasColumnName("impact");
            entity.Property(e => e.IntendedUser).HasColumnName("intendedUser");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.OpenAccess)
                .HasMaxLength(5)
                .HasColumnName("openAccess");
            entity.Property(e => e.Outcome).HasColumnName("outcome");
            entity.Property(e => e.OutcomePathway).HasColumnName("outcomePathway");
            entity.Property(e => e.OutputTarget).HasColumnName("outputTarget");
            entity.Property(e => e.OutputTargetYear).HasColumnName("outputTargetYear");
            entity.Property(e => e.Outputs).HasColumnName("outputs");
            entity.Property(e => e.ProductLine).HasColumnName("productLine");
            entity.Property(e => e.Project)
                .HasMaxLength(150)
                .HasColumnName("project");
            entity.Property(e => e.Region)
                .HasMaxLength(200)
                .HasColumnName("region");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Staffcommentlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("staffcommentlog")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AppraisalId, "FKEA98EB45134C9C32");

            entity.HasIndex(e => e.UserId, "FKEA98EB455FF93CF6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppraisalId).HasColumnName("appraisal_id");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.SysDate)
                .HasColumnType("datetime")
                .HasColumnName("sysDate");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Appraisal).WithMany(p => p.Staffcommentlogs)
                .HasForeignKey(d => d.AppraisalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKEA98EB45134C9C32");

            entity.HasOne(d => d.User).WithMany(p => p.Staffcommentlogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FKEA98EB455FF93CF6");
        });

        modelBuilder.Entity<Stringpreference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("stringpreference")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Id, "FK98601BEC225C6812");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.PreferenceValue)
                .HasMaxLength(255)
                .HasColumnName("preferenceValue");
        });

        modelBuilder.Entity<TaPretravel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ta_pretravel")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AValues)
                .HasColumnType("mediumtext")
                .HasColumnName("a_values");
            entity.Property(e => e.Accomodation)
                .HasColumnType("text")
                .HasColumnName("accomodation");
            entity.Property(e => e.AdvanceLimit)
                .HasPrecision(19, 4)
                .HasColumnName("advance_limit");
            entity.Property(e => e.AdvanceReceived)
                .HasPrecision(19, 4)
                .HasColumnName("advance_received");
            entity.Property(e => e.Ammend)
                .HasMaxLength(5)
                .HasColumnName("ammend");
            entity.Property(e => e.Approved)
                .HasMaxLength(50)
                .HasColumnName("approved");
            entity.Property(e => e.ArrDate)
                .HasColumnType("text")
                .HasColumnName("arr_date");
            entity.Property(e => e.BCode)
                .HasMaxLength(50)
                .HasColumnName("b_code");
            entity.Property(e => e.BfAmmend)
                .HasMaxLength(10)
                .HasColumnName("bf_ammend");
            entity.Property(e => e.BfApprove)
                .HasMaxLength(25)
                .HasColumnName("bf_approve");
            entity.Property(e => e.BfComment)
                .HasColumnType("text")
                .HasColumnName("bf_comment");
            entity.Property(e => e.BfDateApproved)
                .HasColumnType("datetime")
                .HasColumnName("bf_date_approved");
            entity.Property(e => e.CashType)
                .HasMaxLength(210)
                .HasColumnName("cash_type");
            entity.Property(e => e.CheckType)
                .HasMaxLength(210)
                .HasColumnName("check_type");
            entity.Property(e => e.Comments)
                .HasColumnType("mediumtext")
                .HasColumnName("comments");
            entity.Property(e => e.DateApproved)
                .HasColumnType("datetime")
                .HasColumnName("date_approved");
            entity.Property(e => e.DdComment)
                .HasColumnType("text")
                .HasColumnName("dd_comment");
            entity.Property(e => e.DdEmail)
                .HasMaxLength(50)
                .HasColumnName("dd_email");
            entity.Property(e => e.DdName)
                .HasMaxLength(150)
                .HasColumnName("dd_name");
            entity.Property(e => e.DdgAmmend)
                .HasMaxLength(10)
                .HasColumnName("ddg_ammend");
            entity.Property(e => e.DdgName)
                .HasMaxLength(80)
                .HasColumnName("ddg_name");
            entity.Property(e => e.Denomination)
                .HasMaxLength(250)
                .HasColumnName("denomination");
            entity.Property(e => e.DepartDate)
                .HasColumnType("text")
                .HasColumnName("depart_date");
            entity.Property(e => e.DocEvy)
                .HasColumnType("text")
                .HasColumnName("doc_evy");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.EventsVisited)
                .HasColumnType("text")
                .HasColumnName("events_visited");
            entity.Property(e => e.ExpValues)
                .HasColumnType("text")
                .HasColumnName("exp_values");
            entity.Property(e => e.FinalApprove)
                .HasMaxLength(25)
                .HasColumnName("final_approve");
            entity.Property(e => e.FinalComment)
                .HasColumnType("text")
                .HasColumnName("final_comment");
            entity.Property(e => e.FinalDateApproved)
                .HasColumnType("datetime")
                .HasColumnName("final_date_approved");
            entity.Property(e => e.FinalTripStatus)
                .HasMaxLength(50)
                .HasColumnName("final_trip_status");
            entity.Property(e => e.Flightno)
                .HasMaxLength(150)
                .HasColumnName("flightno");
            entity.Property(e => e.Followup)
                .HasColumnType("mediumtext")
                .HasColumnName("followup");
            entity.Property(e => e.Iitauserid).HasColumnName("IITAUSERID");
            entity.Property(e => e.ItenCtry)
                .HasColumnType("text")
                .HasColumnName("iten_ctry");
            entity.Property(e => e.ItenTo)
                .HasColumnType("text")
                .HasColumnName("iten_to");
            entity.Property(e => e.LastNotify)
                .HasMaxLength(20)
                .HasColumnName("last_notify");
            entity.Property(e => e.Name)
                .HasMaxLength(120)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.Outcomes)
                .HasColumnType("text")
                .HasColumnName("outcomes");
            entity.Property(e => e.PaChargeNotify)
                .HasMaxLength(50)
                .HasColumnName("pa_charge_notify");
            entity.Property(e => e.Payment)
                .HasMaxLength(250)
                .HasColumnName("payment");
            entity.Property(e => e.PostReport)
                .HasMaxLength(50)
                .HasColumnName("post_report");
            entity.Property(e => e.Postfile1)
                .HasMaxLength(150)
                .HasColumnName("postfile1");
            entity.Property(e => e.Postfile2)
                .HasMaxLength(150)
                .HasColumnName("postfile2");
            entity.Property(e => e.PosttravelId).HasColumnName("posttravel_id");
            entity.Property(e => e.PrevisitId).HasColumnName("previsit_ID");
            entity.Property(e => e.Purpose)
                .HasColumnType("text")
                .HasColumnName("purpose");
            entity.Property(e => e.ReportDate)
                .HasColumnType("datetime")
                .HasColumnName("report_date");
            entity.Property(e => e.ReportOutcomes)
                .HasColumnType("mediumtext")
                .HasColumnName("report_outcomes");
            entity.Property(e => e.RequisitionNo)
                .HasMaxLength(50)
                .HasColumnName("requisitionNo");
            entity.Property(e => e.SourceFund)
                .HasMaxLength(150)
                .HasColumnName("source_fund");
            entity.Property(e => e.SpecArrange)
                .HasColumnType("text")
                .HasColumnName("spec_arrange");
            entity.Property(e => e.StFund)
                .HasMaxLength(250)
                .HasColumnName("st_fund");
            entity.Property(e => e.Staffid)
                .HasMaxLength(20)
                .HasColumnName("staffid");
            entity.Property(e => e.SubmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("submission_date");
            entity.Property(e => e.Target)
                .HasColumnType("mediumtext")
                .HasColumnName("target");
            entity.Property(e => e.TicketAmt)
                .HasPrecision(19, 4)
                .HasColumnName("ticket_amt");
            entity.Property(e => e.TicketNo)
                .HasMaxLength(250)
                .HasColumnName("ticket_no");
            entity.Property(e => e.TotalAdvance)
                .HasPrecision(19, 4)
                .HasColumnName("total_advance");
            entity.Property(e => e.TotalCost)
                .HasPrecision(19, 4)
                .HasColumnName("total_cost");
            entity.Property(e => e.TotalTravellersChks)
                .HasPrecision(19, 4)
                .HasColumnName("total_travellers_chks");
            entity.Property(e => e.Travelmode)
                .HasColumnType("text")
                .HasColumnName("travelmode");
            entity.Property(e => e.TripEnd)
                .HasColumnType("datetime")
                .HasColumnName("trip_end");
            entity.Property(e => e.TripStart)
                .HasColumnType("datetime")
                .HasColumnName("trip_start");
        });

        modelBuilder.Entity<TraProgram>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("tra_program")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Iitauserid, "FKE86233E8565F36DA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contact).HasColumnName("contact");
            entity.Property(e => e.CostCenter)
                .HasMaxLength(100)
                .HasColumnName("costCenter");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .HasDefaultValueSql("'SYSTEM'")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Email)
                .HasMaxLength(400)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.ExtensionDate)
                .HasColumnType("datetime")
                .HasColumnName("extensionDate");
            entity.Property(e => e.FundSource)
                .HasMaxLength(255)
                .HasColumnName("fundSource");
            entity.Property(e => e.Funding)
                .HasMaxLength(400)
                .HasColumnName("funding");
            entity.Property(e => e.Iitauserid).HasColumnName("IITAUSERID");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(200)
                .HasDefaultValueSql("'SYSTEM'")
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Location)
                .HasMaxLength(400)
                .HasColumnName("location");
            entity.Property(e => e.MaterialAvailable)
                .HasMaxLength(400)
                .HasColumnName("materialAvailable");
            entity.Property(e => e.Outcome)
                .HasColumnType("text")
                .HasColumnName("outcome");
            entity.Property(e => e.Participants).HasColumnName("participants");
            entity.Property(e => e.ParticipantsFemale).HasColumnName("participantsFemale");
            entity.Property(e => e.Program)
                .HasMaxLength(255)
                .HasColumnName("program");
            entity.Property(e => e.ProjectNo)
                .HasMaxLength(100)
                .HasColumnName("projectNo");
            entity.Property(e => e.Purpose)
                .HasColumnType("text")
                .HasColumnName("purpose");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.Title)
                .HasMaxLength(500)
                .HasColumnName("title");
            entity.Property(e => e.Trainers)
                .HasMaxLength(400)
                .HasColumnName("trainers");
            entity.Property(e => e.TrainingDescription)
                .HasColumnType("text")
                .HasColumnName("trainingDescription");
            entity.Property(e => e.Type)
                .HasMaxLength(400)
                .HasColumnName("type");
            entity.Property(e => e.Version)
                .HasDefaultValueSql("'0'")
                .HasColumnName("version");

            entity.HasOne(d => d.Iitauser).WithMany(p => p.TraPrograms)
                .HasForeignKey(d => d.Iitauserid)
                .HasConstraintName("FKE86233E8565F36DA");
        });

        modelBuilder.Entity<TraTrainee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("tra_trainees")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Iitauserid, "FKAB9F8FE7565F36DA");

            entity.HasIndex(e => e.ProgramProject, "FKAB9F8FE75F8D3AD1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CostCenter)
                .HasMaxLength(255)
                .HasColumnName("costCenter");
            entity.Property(e => e.Country)
                .HasColumnType("tinytext")
                .HasColumnName("country");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .HasDefaultValueSql("'SYSTEM'")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CurrentAddress)
                .HasColumnType("text")
                .HasColumnName("currentAddress");
            entity.Property(e => e.Degree)
                .HasColumnType("tinytext")
                .HasColumnName("degree");
            entity.Property(e => e.DegreeAwardDate)
                .HasColumnType("datetime")
                .HasColumnName("degreeAwardDate");
            entity.Property(e => e.Email)
                .HasColumnType("tinytext")
                .HasColumnName("email");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.ExtensionDate)
                .HasColumnType("datetime")
                .HasColumnName("extensionDate");
            entity.Property(e => e.Gender)
                .HasColumnType("tinytext")
                .HasColumnName("gender");
            entity.Property(e => e.Iitauserid).HasColumnName("IITAUSERID");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(200)
                .HasDefaultValueSql("'SYSTEM'")
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Location)
                .HasColumnType("tinytext")
                .HasColumnName("location");
            entity.Property(e => e.Name)
                .HasColumnType("tinytext")
                .HasColumnName("name");
            entity.Property(e => e.PermanentAddress)
                .HasColumnType("text")
                .HasColumnName("permanentAddress");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnName("phone");
            entity.Property(e => e.PresentEmployerAddress)
                .HasColumnType("text")
                .HasColumnName("presentEmployerAddress");
            entity.Property(e => e.PresentEmployerName)
                .HasMaxLength(255)
                .HasColumnName("presentEmployerName");
            entity.Property(e => e.Program)
                .HasColumnType("tinytext")
                .HasColumnName("program");
            entity.Property(e => e.ProgramProject).HasColumnName("program_PROJECT");
            entity.Property(e => e.ProjectNo)
                .HasMaxLength(255)
                .HasColumnName("projectNo");
            entity.Property(e => e.RegStatus)
                .HasColumnType("tinytext")
                .HasColumnName("regStatus");
            entity.Property(e => e.ResearchTopic).HasColumnName("researchTopic");
            entity.Property(e => e.SponsorType)
                .HasColumnType("tinytext")
                .HasColumnName("sponsorType");
            entity.Property(e => e.Sponsors)
                .HasColumnType("tinytext")
                .HasColumnName("sponsors");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.Supervisor)
                .HasColumnType("tinytext")
                .HasColumnName("supervisor");
            entity.Property(e => e.University)
                .HasColumnType("tinytext")
                .HasColumnName("university");
            entity.Property(e => e.UniversityAddress)
                .HasColumnType("text")
                .HasColumnName("universityAddress");
            entity.Property(e => e.UniversitySupervisor)
                .HasMaxLength(255)
                .HasColumnName("universitySupervisor");
            entity.Property(e => e.UniversitySupervisorEmail)
                .HasMaxLength(255)
                .HasColumnName("universitySupervisorEmail");
            entity.Property(e => e.UniversitySupervisorPhone)
                .HasMaxLength(255)
                .HasColumnName("universitySupervisorPhone");

            entity.HasOne(d => d.Iitauser).WithMany(p => p.TraTrainees)
                .HasForeignKey(d => d.Iitauserid)
                .HasConstraintName("FKAB9F8FE7565F36DA");

            entity.HasOne(d => d.ProgramProjectNavigation).WithMany(p => p.TraTrainees)
                .HasForeignKey(d => d.ProgramProject)
                .HasConstraintName("FKAB9F8FE75F8D3AD1");
        });

        modelBuilder.Entity<Travelauthorization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("travelauthorization")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.LineManagerId, "FK28A3335F275544C8");

            entity.HasIndex(e => e.TravelerId, "FK28A3335F9D5CC183");

            entity.HasIndex(e => e.OwnerId, "FK28A3335FCBDFED0E");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CostSharing).HasColumnName("costSharing");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.DateModifed)
                .HasColumnType("datetime")
                .HasColumnName("dateModifed");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.Funding)
                .HasMaxLength(255)
                .HasColumnName("funding");
            entity.Property(e => e.LineManagerId).HasColumnName("lineManager_id");
            entity.Property(e => e.OracleRequisitionNumber)
                .HasMaxLength(255)
                .HasColumnName("oracleRequisitionNumber");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.TotalCost).HasColumnName("totalCost");
            entity.Property(e => e.TravelerId).HasColumnName("traveler_id");
            entity.Property(e => e.TripType)
                .HasMaxLength(255)
                .HasColumnName("tripType");
            entity.Property(e => e.Version)
                .HasDefaultValueSql("'1'")
                .HasColumnName("version");
        });

        modelBuilder.Entity<Traveler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("traveler")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.UserId, "FK509D91675FF93CF6");

            entity.HasIndex(e => e.TravelAuthorizationId, "FK509D91679044BC71");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("lastName");
            entity.Property(e => e.StaffId)
                .HasMaxLength(20)
                .HasColumnName("staffId");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.TravelAuthorizationId).HasColumnName("travelAuthorization_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Version)
                .HasDefaultValueSql("'1'")
                .HasColumnName("version");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user", tb => tb.HasComment("User"))
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Mail, "IX_User_mail").IsUnique();

            entity.HasIndex(e => e.Username, "IX_User_username").IsUnique();

            entity.HasIndex(e => e.StaffId, "staffId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthenticationType)
                .HasDefaultValueSql("'0'")
                .HasColumnName("authenticationType");
            entity.Property(e => e.Department)
                .HasMaxLength(200)
                .HasColumnName("department");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(200)
                .HasColumnName("displayName");
            entity.Property(e => e.FirstName)
                .HasMaxLength(200)
                .HasColumnName("firstName");
            entity.Property(e => e.LastLogin)
                .HasColumnType("datetime")
                .HasColumnName("lastLogin");
            entity.Property(e => e.LastLoginFailed)
                .HasColumnType("datetime")
                .HasColumnName("lastLoginFailed");
            entity.Property(e => e.LastName)
                .HasMaxLength(200)
                .HasColumnName("lastName");
            entity.Property(e => e.Mail)
                .HasMaxLength(200)
                .HasColumnName("mail");
            entity.Property(e => e.ManualUpdate)
                .HasColumnType("datetime")
                .HasColumnName("manual_update");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .HasColumnName("password");
            entity.Property(e => e.Preferences)
                .HasMaxLength(255)
                .HasColumnName("preferences");
            entity.Property(e => e.StaffId)
                .HasMaxLength(20)
                .HasColumnName("staffId");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnName("status");
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Useraccesstag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("useraccesstag")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.UserId, "FK269E5FEB5FF93CF6");

            entity.Property(e => e.Tag).HasColumnName("tag");
            entity.Property(e => e.UserId).HasColumnName("User_id");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK269E5FEB5FF93CF6");
        });

        modelBuilder.Entity<Userclassification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("userclassification")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.UserId, "FK5E11A8B15FF93CF6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Classification)
                .HasMaxLength(255)
                .HasColumnName("classification");
            entity.Property(e => e.Jobdescription)
                .HasMaxLength(255)
                .HasColumnName("jobdescription");
            entity.Property(e => e.Pg).HasColumnName("pg");
            entity.Property(e => e.Staffcategory)
                .HasMaxLength(255)
                .HasColumnName("staffcategory");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.User).WithMany(p => p.Userclassifications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK5E11A8B15FF93CF6");
        });

        modelBuilder.Entity<Userdelegation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("userdelegation", tb => tb.HasComment("Delegations"))
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.OwnerId, "FK44143F7329E06DF5");

            entity.HasIndex(e => e.DelegatedTo, "FK44143F73707D4D21");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Application)
                .HasMaxLength(50)
                .HasColumnName("application");
            entity.Property(e => e.DelegatedTo).HasColumnName("delegatedTo");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("fromDate");
            entity.Property(e => e.OwnerId).HasColumnName("ownerId");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("toDate");

            entity.HasOne(d => d.DelegatedToNavigation).WithMany(p => p.UserdelegationDelegatedToNavigations)
                .HasForeignKey(d => d.DelegatedTo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK44143F73707D4D21");

            entity.HasOne(d => d.Owner).WithMany(p => p.UserdelegationOwners)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK44143F7329E06DF5");
        });

        modelBuilder.Entity<Userlookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("userlookup")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Userid, "FK_UserLookup_User");

            entity.HasIndex(e => e.Identifier, "IX_UserLookup_Identifier").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Identifier)
                .HasMaxLength(200)
                .HasColumnName("identifier");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Usernotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("usernotification")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.UserId, "FKC31EB4765FF93CF6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.EventName)
                .HasMaxLength(200)
                .HasColumnName("eventName");
            entity.Property(e => e.FormatString).HasColumnName("formatString");
            entity.Property(e => e.Frequency)
                .HasMaxLength(100)
                .HasColumnName("frequency");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.Priority)
                .HasMaxLength(100)
                .HasColumnName("priority");
            entity.Property(e => e.Subscribed)
                .HasColumnType("bit(1)")
                .HasColumnName("subscribed");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.User).WithMany(p => p.Usernotifications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKC31EB4765FF93CF6");
        });

        modelBuilder.Entity<Userpasswordrequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("userpasswordrequest")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.UserId, "FK8175E0095FF93CF6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateGenerated)
                .HasColumnType("datetime")
                .HasColumnName("dateGenerated");
            entity.Property(e => e.DateUsed)
                .HasColumnType("datetime")
                .HasColumnName("dateUsed");
            entity.Property(e => e.Key)
                .HasMaxLength(50)
                .HasColumnName("key");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Userpasswordrequests)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK8175E0095FF93CF6");
        });

        modelBuilder.Entity<Userrole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("userrole", tb => tb.HasComment("User roles"))
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.UserId, "FKF3F7670136E9810D");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Application)
                .HasMaxLength(50)
                .HasColumnName("application");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasColumnName("role");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Userroles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKF3F7670136E9810D");
        });

        modelBuilder.Entity<Usersupervisor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("usersupervisor", tb => tb.HasComment("User hierarchy"))
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.UserId, "FK8C15E5B336E9810D");

            entity.HasIndex(e => e.SupervisorId, "FK8C15E5B3A74D756A");

            entity.HasIndex(e => e.Application, "IX_Application");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Application)
                .HasMaxLength(100)
                .HasColumnName("application");
            entity.Property(e => e.SupervisorId).HasColumnName("supervisorId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Supervisor).WithMany(p => p.UsersupervisorSupervisors)
                .HasForeignKey(d => d.SupervisorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK8C15E5B3A74D756A");

            entity.HasOne(d => d.User).WithMany(p => p.UsersupervisorUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK8C15E5B336E9810D");
        });

        modelBuilder.Entity<Workplan2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("workplan2")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.UserId, "FKB95DF59836E9810D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityYear).HasColumnName("activityYear");
            entity.Property(e => e.ActualOutcome).HasColumnName("actualOutcome");
            entity.Property(e => e.BeneficiaryCountries)
                .HasMaxLength(255)
                .HasColumnName("beneficiaryCountries");
            entity.Property(e => e.Categories)
                .HasMaxLength(255)
                .HasColumnName("categories");
            entity.Property(e => e.CgPriorities)
                .HasMaxLength(255)
                .HasColumnName("cgPriorities");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.EntryYear).HasColumnName("entryYear");
            entity.Property(e => e.Impact)
                .HasMaxLength(255)
                .HasColumnName("impact");
            entity.Property(e => e.IntendedUser)
                .HasMaxLength(255)
                .HasColumnName("intendedUser");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.OpenAccess)
                .HasMaxLength(5)
                .HasColumnName("openAccess");
            entity.Property(e => e.Outcome).HasColumnName("outcome");
            entity.Property(e => e.OutcomePathway).HasColumnName("outcomePathway");
            entity.Property(e => e.OutputTarget).HasColumnName("outputTarget");
            entity.Property(e => e.OutputTargetYear).HasColumnName("outputTargetYear");
            entity.Property(e => e.Outputs).HasColumnName("outputs");
            entity.Property(e => e.ProductLine).HasColumnName("productLine");
            entity.Property(e => e.Project)
                .HasMaxLength(255)
                .HasColumnName("project");
            entity.Property(e => e.Region)
                .HasMaxLength(255)
                .HasColumnName("region");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.User).WithMany(p => p.Workplan2s)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKB95DF59836E9810D");
        });

        modelBuilder.Entity<Workplanactionstatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("workplanactionstatus")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AppraiseeId, "FK32365CC236735707");

            entity.HasIndex(e => e.AppraiserId, "FK32365CC236793FDA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppraiseeId).HasColumnName("appraisee_id");
            entity.Property(e => e.AppraiserId).HasColumnName("appraiser_id");
            entity.Property(e => e.ApprovalStatus)
                .HasMaxLength(255)
                .HasColumnName("approvalStatus");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.SubmissionStatus)
                .HasMaxLength(255)
                .HasColumnName("submissionStatus");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.Appraisee).WithMany(p => p.WorkplanactionstatusAppraisees)
                .HasForeignKey(d => d.AppraiseeId)
                .HasConstraintName("FK32365CC236735707");

            entity.HasOne(d => d.Appraiser).WithMany(p => p.WorkplanactionstatusAppraisers)
                .HasForeignKey(d => d.AppraiserId)
                .HasConstraintName("FK32365CC236793FDA");
        });

        modelBuilder.Entity<Workplanentrydeadline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("workplanentrydeadline")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.UserId, "FK117DF1305FF93CF6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Deadline)
                .HasColumnType("datetime")
                .HasColumnName("deadline");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.WorkplanYear).HasColumnName("workplanYear");

            entity.HasOne(d => d.User).WithMany(p => p.Workplanentrydeadlines)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK117DF1305FF93CF6");
        });

        modelBuilder.Entity<Workplanstatuslog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("workplanstatuslog")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.WorkplanActionStatusId, "FK99EA4D387C859B42");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("lastUpdatedBy");
            entity.Property(e => e.SysDate)
                .HasColumnType("datetime")
                .HasColumnName("sysDate");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.WorkplanActionStatusId).HasColumnName("workplanActionStatus_id");

            entity.HasOne(d => d.WorkplanActionStatus).WithMany(p => p.Workplanstatuslogs)
                .HasForeignKey(d => d.WorkplanActionStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK99EA4D387C859B42");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
