using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

/// <summary>
/// User
/// </summary>
public partial class User
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? DisplayName { get; set; }

    public string? Description { get; set; }

    public string? Department { get; set; }

    public int? Status { get; set; }

    public int? AuthenticationType { get; set; }

    public string? Password { get; set; }

    public DateTime? LastLogin { get; set; }

    public DateTime? LastLoginFailed { get; set; }

    public string? Preferences { get; set; }

    public string? StaffId { get; set; }

    public DateTime? ManualUpdate { get; set; }

    public virtual ICollection<BibAuthor> BibAuthors { get; set; } = new List<BibAuthor>();

    public virtual ICollection<Irsactivity> Irsactivities { get; set; } = new List<Irsactivity>();

    public virtual ICollection<Irsworkplan> Irsworkplans { get; set; } = new List<Irsworkplan>();

    public virtual ICollection<Learning> Learnings { get; set; } = new List<Learning>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<NrsWorkplan> NrsWorkplans { get; set; } = new List<NrsWorkplan>();

    public virtual ICollection<P4dsupportactivity> P4dsupportactivities { get; set; } = new List<P4dsupportactivity>();

    public virtual ICollection<P4dsupportworkplan> P4dsupportworkplans { get; set; } = new List<P4dsupportworkplan>();

    public virtual ICollection<P4dworkplan> P4dworkplans { get; set; } = new List<P4dworkplan>();

    public virtual ICollection<PmCorebudget> PmCorebudgets { get; set; } = new List<PmCorebudget>();

    public virtual ICollection<PmIitacostcenter> PmIitacostcenters { get; set; } = new List<PmIitacostcenter>();

    public virtual ICollection<PmStaff> PmStaffs { get; set; } = new List<PmStaff>();

    public virtual ICollection<Preference> PreferencesNavigation { get; set; } = new List<Preference>();

    public virtual ICollection<Program> Programs { get; set; } = new List<Program>();

    public virtual ICollection<Staffcommentlog> Staffcommentlogs { get; set; } = new List<Staffcommentlog>();

    public virtual ICollection<TraProgram> TraPrograms { get; set; } = new List<TraProgram>();

    public virtual ICollection<TraTrainee> TraTrainees { get; set; } = new List<TraTrainee>();

    public virtual ICollection<Userclassification> Userclassifications { get; set; } = new List<Userclassification>();

    public virtual ICollection<Userdelegation> UserdelegationDelegatedToNavigations { get; set; } = new List<Userdelegation>();

    public virtual ICollection<Userdelegation> UserdelegationOwners { get; set; } = new List<Userdelegation>();

    public virtual ICollection<Usernotification> Usernotifications { get; set; } = new List<Usernotification>();

    public virtual ICollection<Userpasswordrequest> Userpasswordrequests { get; set; } = new List<Userpasswordrequest>();

    public virtual ICollection<Userrole> Userroles { get; set; } = new List<Userrole>();

    public virtual ICollection<Usersupervisor> UsersupervisorSupervisors { get; set; } = new List<Usersupervisor>();

    public virtual ICollection<Usersupervisor> UsersupervisorUsers { get; set; } = new List<Usersupervisor>();

    public virtual ICollection<Workplan2> Workplan2s { get; set; } = new List<Workplan2>();

    public virtual ICollection<Workplanactionstatus> WorkplanactionstatusAppraisees { get; set; } = new List<Workplanactionstatus>();

    public virtual ICollection<Workplanactionstatus> WorkplanactionstatusAppraisers { get; set; } = new List<Workplanactionstatus>();

    public virtual ICollection<Workplanentrydeadline> Workplanentrydeadlines { get; set; } = new List<Workplanentrydeadline>();
}
