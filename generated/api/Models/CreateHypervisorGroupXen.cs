// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Create a hypervisor group with Google Cloud as the destination vendor</summary>
    public partial class CreateHypervisorGroupXen :
        Commvault.Powershell.Models.ICreateHypervisorGroupXen,
        Commvault.Powershell.Models.ICreateHypervisorGroupXenInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICreateHypervisorGroupReq" />
        /// </summary>
        private Commvault.Powershell.Models.ICreateHypervisorGroupReq __createHypervisorGroupReq = new Commvault.Powershell.Models.CreateHypervisorGroupReq();

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName[] AccessNodes { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).AccessNodes; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).AccessNodes = value; }

        /// <summary>Internal Acessors for HypervisorType</summary>
        string Commvault.Powershell.Models.ICreateHypervisorGroupXenInternal.HypervisorType { get => this._hypervisorType; set { {_hypervisorType = value;} } }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName Credentials { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Credentials; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Credentials = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? CredentialsId { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).CredentialsId; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).CredentialsId = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string CredentialsName { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).CredentialsName; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).CredentialsName = value; }

        /// <summary>Backing field for <see cref="HypervisorType" /> property.</summary>
        private string _hypervisorType= @"XEN_SERVER";

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string HypervisorType { get => this._hypervisorType; }

        /// <summary>The name of the hypervisor group being created</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Name { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Name; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Name = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>Xen password</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="ServerName" /> property.</summary>
        private string _serverName;

        /// <summary>Xen hostname</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ServerName { get => this._serverName; set => this._serverName = value; }

        /// <summary>if credential validation has to be skipped.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? SkipCredentialValidation { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).SkipCredentialValidation; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).SkipCredentialValidation = value; }

        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private string _userName;

        /// <summary>Xen userName</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserName { get => this._userName; set => this._userName = value; }

        /// <summary>Creates an new <see cref="CreateHypervisorGroupXen" /> instance.</summary>
        public CreateHypervisorGroupXen()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Commvault.Powershell.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Commvault.Powershell.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__createHypervisorGroupReq), __createHypervisorGroupReq);
            await eventListener.AssertObjectIsValid(nameof(__createHypervisorGroupReq), __createHypervisorGroupReq);
        }
    }
    /// Create a hypervisor group with Google Cloud as the destination vendor
    public partial interface ICreateHypervisorGroupXen :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.ICreateHypervisorGroupReq
    {
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"hypervisorType",
        PossibleTypes = new [] { typeof(string) })]
        string HypervisorType { get;  }
        /// <summary>Xen password</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Xen password ",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>Xen hostname</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Xen hostname ",
        SerializedName = @"serverName",
        PossibleTypes = new [] { typeof(string) })]
        string ServerName { get; set; }
        /// <summary>Xen userName</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Xen userName ",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    /// Create a hypervisor group with Google Cloud as the destination vendor
    internal partial interface ICreateHypervisorGroupXenInternal :
        Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal
    {
        string HypervisorType { get; set; }
        /// <summary>Xen password</summary>
        string Password { get; set; }
        /// <summary>Xen hostname</summary>
        string ServerName { get; set; }
        /// <summary>Xen userName</summary>
        string UserName { get; set; }

    }
}