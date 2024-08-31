using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class TaPretravel
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Staffid { get; set; }

    public string? DdName { get; set; }

    public string? DdEmail { get; set; }

    public string? EventsVisited { get; set; }

    public string? Purpose { get; set; }

    public string? Outcomes { get; set; }

    public string? ExpValues { get; set; }

    public string? SourceFund { get; set; }

    public string? Approved { get; set; }

    public DateTime? DateApproved { get; set; }

    public string? BCode { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public string? Ammend { get; set; }

    public string? ItenCtry { get; set; }

    public string? ItenTo { get; set; }

    public string? ArrDate { get; set; }

    public string? DepartDate { get; set; }

    public string? StFund { get; set; }

    public decimal? TotalCost { get; set; }

    public string? Travelmode { get; set; }

    public string? Flightno { get; set; }

    public string? Accomodation { get; set; }

    public string? PostReport { get; set; }

    public string? DdComment { get; set; }

    public string? BfApprove { get; set; }

    public string? BfComment { get; set; }

    public DateTime? BfDateApproved { get; set; }

    public string? FinalApprove { get; set; }

    public string? FinalComment { get; set; }

    public DateTime? FinalDateApproved { get; set; }

    public string? DocEvy { get; set; }

    public decimal? AdvanceLimit { get; set; }

    public string? CashType { get; set; }

    public string? CheckType { get; set; }

    public string? Payment { get; set; }

    public string? Denomination { get; set; }

    public string? SpecArrange { get; set; }

    public string? TicketNo { get; set; }

    public decimal? TicketAmt { get; set; }

    public string? Notes { get; set; }

    public decimal? TotalTravellersChks { get; set; }

    public decimal? TotalAdvance { get; set; }

    public decimal? AdvanceReceived { get; set; }

    public string? BfAmmend { get; set; }

    public string? DdgAmmend { get; set; }

    public string? DdgName { get; set; }

    public string? LastNotify { get; set; }

    public string? RequisitionNo { get; set; }

    public string? FinalTripStatus { get; set; }

    public string? PaChargeNotify { get; set; }

    public long? Iitauserid { get; set; }

    public long? PosttravelId { get; set; }

    public string? Target { get; set; }

    public string? ReportOutcomes { get; set; }

    public string? AValues { get; set; }

    public string? Followup { get; set; }

    public string? Comments { get; set; }

    public DateTime? ReportDate { get; set; }

    public long? PrevisitId { get; set; }

    public string? Postfile1 { get; set; }

    public string? Postfile2 { get; set; }

    public DateTime? TripStart { get; set; }

    public DateTime? TripEnd { get; set; }
}
