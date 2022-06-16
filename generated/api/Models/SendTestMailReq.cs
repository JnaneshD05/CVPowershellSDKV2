// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class SendTestMailReq :
        Commvault.Powershell.Models.ISendTestMailReq,
        Commvault.Powershell.Models.ISendTestMailReqInternal
    {

        /// <summary>Backing field for <see cref="EncryptionAlgorithm" /> property.</summary>
        private string _encryptionAlgorithm;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string EncryptionAlgorithm { get => this._encryptionAlgorithm; set => this._encryptionAlgorithm = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>
        /// If password is specified, username must also be specified. password should be a base 64 encoded string. To use previoulsy
        /// saved username and password, leave out username and password in payload.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="SenderEmail" /> property.</summary>
        private string _senderEmail;

        /// <summary>The sender email address used for emails sent from the software.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SenderEmail { get => this._senderEmail; set => this._senderEmail = value; }

        /// <summary>Backing field for <see cref="SenderName" /> property.</summary>
        private string _senderName;

        /// <summary>The sender name used for emails sent from the software.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SenderName { get => this._senderName; set => this._senderName = value; }

        /// <summary>Backing field for <see cref="SmtpPort" /> property.</summary>
        private int _smtpPort;

        /// <summary>The port number that connects to the mail server.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int SmtpPort { get => this._smtpPort; set => this._smtpPort = value; }

        /// <summary>Backing field for <see cref="SmtpServerName" /> property.</summary>
        private string _smtpServerName;

        /// <summary>
        /// The name of the mail server that sends alerts, scheduled reports, log files, and additional information.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SmtpServerName { get => this._smtpServerName; set => this._smtpServerName = value; }

        /// <summary>Backing field for <see cref="UseAuthentication" /> property.</summary>
        private bool? _useAuthentication;

        /// <summary>
        /// The option to use authentication on the mail server. This is typically used in external or internet mail server configurations.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? UseAuthentication { get => this._useAuthentication; set => this._useAuthentication = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        /// <summary>
        /// If username is specified, password field must also be specified. To use previously saved username and password, leave
        /// out username and password in payload.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="SendTestMailReq" /> instance.</summary>
        public SendTestMailReq()
        {

        }
    }
    public partial interface ISendTestMailReq :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"encryptionAlgorithm",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionAlgorithm { get; set; }
        /// <summary>
        /// If password is specified, username must also be specified. password should be a base 64 encoded string. To use previoulsy
        /// saved username and password, leave out username and password in payload.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If password is specified, username must also be specified. password should be a base 64 encoded string. To use previoulsy saved username and password, leave out username and password in payload.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>The sender email address used for emails sent from the software.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The sender email address used for emails sent from the software.",
        SerializedName = @"senderEmail",
        PossibleTypes = new [] { typeof(string) })]
        string SenderEmail { get; set; }
        /// <summary>The sender name used for emails sent from the software.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The sender name used for emails sent from the software.",
        SerializedName = @"senderName",
        PossibleTypes = new [] { typeof(string) })]
        string SenderName { get; set; }
        /// <summary>The port number that connects to the mail server.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The port number that connects to the mail server.",
        SerializedName = @"SMTPPort",
        PossibleTypes = new [] { typeof(int) })]
        int SmtpPort { get; set; }
        /// <summary>
        /// The name of the mail server that sends alerts, scheduled reports, log files, and additional information.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the mail server that sends alerts, scheduled reports, log files, and additional information.",
        SerializedName = @"SMTPServerName",
        PossibleTypes = new [] { typeof(string) })]
        string SmtpServerName { get; set; }
        /// <summary>
        /// The option to use authentication on the mail server. This is typically used in external or internet mail server configurations.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The option to use authentication on the mail server. This is typically used in external or internet mail server configurations.",
        SerializedName = @"useAuthentication",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseAuthentication { get; set; }
        /// <summary>
        /// If username is specified, password field must also be specified. To use previously saved username and password, leave
        /// out username and password in payload.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If username is specified, password field must also be specified. To use previously saved username and password, leave out username and password in payload.",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    internal partial interface ISendTestMailReqInternal

    {
        string EncryptionAlgorithm { get; set; }
        /// <summary>
        /// If password is specified, username must also be specified. password should be a base 64 encoded string. To use previoulsy
        /// saved username and password, leave out username and password in payload.
        /// </summary>
        string Password { get; set; }
        /// <summary>The sender email address used for emails sent from the software.</summary>
        string SenderEmail { get; set; }
        /// <summary>The sender name used for emails sent from the software.</summary>
        string SenderName { get; set; }
        /// <summary>The port number that connects to the mail server.</summary>
        int SmtpPort { get; set; }
        /// <summary>
        /// The name of the mail server that sends alerts, scheduled reports, log files, and additional information.
        /// </summary>
        string SmtpServerName { get; set; }
        /// <summary>
        /// The option to use authentication on the mail server. This is typically used in external or internet mail server configurations.
        /// </summary>
        bool? UseAuthentication { get; set; }
        /// <summary>
        /// If username is specified, password field must also be specified. To use previously saved username and password, leave
        /// out username and password in payload.
        /// </summary>
        string Username { get; set; }

    }
}