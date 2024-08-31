using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class BibPublication
{
    public int PubId { get; set; }

    public int? EnteredBy { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Year { get; set; }

    public string? Actualyear { get; set; }

    public string? Title { get; set; }

    public string? BibtexId { get; set; }

    public string? PubType { get; set; }

    public string? Type { get; set; }

    public string? Survey { get; set; }

    public int? Mark { get; set; }

    public string? Series { get; set; }

    public string? Volume { get; set; }

    public string? Publisher { get; set; }

    public string? Location { get; set; }

    public string? Issn { get; set; }

    public string? Isbn { get; set; }

    public string? Firstpage { get; set; }

    public string? Lastpage { get; set; }

    public string? Journal { get; set; }

    public string? Booktitle { get; set; }

    public string? Number { get; set; }

    public string? Institution { get; set; }

    public string? Address { get; set; }

    public string? Chapter { get; set; }

    public string? Edition { get; set; }

    public string? Howpublished { get; set; }

    public string? Month { get; set; }

    public string? Organization { get; set; }

    public string? School { get; set; }

    public string? Note { get; set; }

    public string? Keywords { get; set; }

    public string? Abstract { get; set; }

    public string? Url { get; set; }

    public string? Doi { get; set; }

    public string? Crossref { get; set; }

    public string? Namekey { get; set; }

    public string? Userfields { get; set; }

    public string? Specialchars { get; set; }

    public string? Cleanjournal { get; set; }

    public string? Cleantitle { get; set; }

    public string? Peerreviewed { get; set; }

    public string? Thomsonindex { get; set; }

    public string? Devcountauth { get; set; }

    public string? Ispublic { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<BibPublicationauthor> BibPublicationauthors { get; set; } = new List<BibPublicationauthor>();
}
