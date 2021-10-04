// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>person</summary>
    public partial class MgPerson
    {

        /// <summary>Backing field for <see cref="Birthday" /> property.</summary>
        private string _birthday;

        /// <summary>The person's birthday.</summary>
        public string Birthday { get => this._birthday; set => this._birthday = value; }

        /// <summary>Backing field for <see cref="CompanyName" /> property.</summary>
        private string _companyName;

        /// <summary>The name of the person's company.</summary>
        public string CompanyName { get => this._companyName; set => this._companyName = value; }

        /// <summary>Backing field for <see cref="Department" /> property.</summary>
        private string _department;

        /// <summary>The person's department.</summary>
        public string Department { get => this._department; set => this._department = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The person's display name.</summary>
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="EmailAddresses" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgRankedEmailAddress[] _emailAddresses;

        /// <summary>The person's email addresses.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgRankedEmailAddress[] EmailAddresses { get => this._emailAddresses; set => this._emailAddresses = value; }

        /// <summary>Backing field for <see cref="GivenName" /> property.</summary>
        private string _givenName;

        /// <summary>The person's given name.</summary>
        public string GivenName { get => this._givenName; set => this._givenName = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="IsFavorite" /> property.</summary>
        private bool? _isFavorite;

        /// <summary>true if the user has flagged this person as a favorite.</summary>
        public bool? IsFavorite { get => this._isFavorite; set => this._isFavorite = value; }

        /// <summary>Backing field for <see cref="MailboxType" /> property.</summary>
        private string _mailboxType;

        /// <summary>The type of mailbox that is represented by the person's email address.</summary>
        public string MailboxType { get => this._mailboxType; set => this._mailboxType = value; }

        /// <summary>Backing field for <see cref="OfficeLocation" /> property.</summary>
        private string _officeLocation;

        /// <summary>The location of the person's office.</summary>
        public string OfficeLocation { get => this._officeLocation; set => this._officeLocation = value; }

        /// <summary>Backing field for <see cref="PersonNotes" /> property.</summary>
        private string _personNotes;

        /// <summary>Free-form notes that the user has taken about this person.</summary>
        public string PersonNotes { get => this._personNotes; set => this._personNotes = value; }

        /// <summary>Backing field for <see cref="PersonType" /> property.</summary>
        private string _personType;

        /// <summary>The type of person, for example distribution list.</summary>
        public string PersonType { get => this._personType; set => this._personType = value; }

        /// <summary>Backing field for <see cref="Phones" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgPhone[] _phones;

        /// <summary>The person's phone numbers.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPhone[] Phones { get => this._phones; set => this._phones = value; }

        /// <summary>Backing field for <see cref="PostalAddresses" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgLocation[] _postalAddresses;

        /// <summary>The person's addresses.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgLocation[] PostalAddresses { get => this._postalAddresses; set => this._postalAddresses = value; }

        /// <summary>Backing field for <see cref="Profession" /> property.</summary>
        private string _profession;

        /// <summary>The person's profession.</summary>
        public string Profession { get => this._profession; set => this._profession = value; }

        /// <summary>Backing field for <see cref="Sources" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgPersonDataSource[] _sources;

        /// <summary>
        /// The sources the user data comes from, for example Directory or Outlook Contacts.
        /// </summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPersonDataSource[] Sources { get => this._sources; set => this._sources = value; }

        /// <summary>Backing field for <see cref="Surname" /> property.</summary>
        private string _surname;

        /// <summary>The person's surname.</summary>
        public string Surname { get => this._surname; set => this._surname = value; }

        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        /// <summary>The person's title.</summary>
        public string Title { get => this._title; set => this._title = value; }

        /// <summary>Backing field for <see cref="UserPrincipalName" /> property.</summary>
        private string _userPrincipalName;

        /// <summary>
        /// The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet
        /// standard RFC 822. By convention, this should map to the person's email name. The general format is alias@domain.
        /// </summary>
        public string UserPrincipalName { get => this._userPrincipalName; set => this._userPrincipalName = value; }

        /// <summary>Backing field for <see cref="Websites" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgWebsite[] _websites;

        /// <summary>The person's websites.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgWebsite[] Websites { get => this._websites; set => this._websites = value; }

        /// <summary>Backing field for <see cref="YomiCompany" /> property.</summary>
        private string _yomiCompany;

        /// <summary>The phonetic Japanese name of the person's company.</summary>
        public string YomiCompany { get => this._yomiCompany; set => this._yomiCompany = value; }

    }
}