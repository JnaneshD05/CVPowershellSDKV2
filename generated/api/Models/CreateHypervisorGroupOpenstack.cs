// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Create a hypervisor group with OpenStack as the destination vendor</summary>
    public partial class CreateHypervisorGroupOpenstack :
        Commvault.Powershell.Models.ICreateHypervisorGroupOpenstack,
        Commvault.Powershell.Models.ICreateHypervisorGroupOpenstackInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICreateHypervisorGroupReq" />
        /// </summary>
        private Commvault.Powershell.Models.ICreateHypervisorGroupReq __createHypervisorGroupReq = new Commvault.Powershell.Models.CreateHypervisorGroupReq();

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName[] AccessNodes { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).AccessNodes; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).AccessNodes = value; }

        /// <summary>Internal Acessors for HypervisorType</summary>
        string Commvault.Powershell.Models.ICreateHypervisorGroupOpenstackInternal.HypervisorType { get => this._hypervisorType; set { {_hypervisorType = value;} } }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName Credentials { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Credentials; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Credentials = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? CredentialsId { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).CredentialsId; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).CredentialsId = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string CredentialsName { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).CredentialsName; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).CredentialsName = value; }

        /// <summary>Backing field for <see cref="HypervisorType" /> property.</summary>
        private string _hypervisorType= @"OPENSTACK";

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string HypervisorType { get => this._hypervisorType; }

        /// <summary>Backing field for <see cref="KeynoteAddress" /> property.</summary>
        private string _keynoteAddress;

        /// <summary>OpenStack KeyNote address</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string KeynoteAddress { get => this._keynoteAddress; set => this._keynoteAddress = value; }

        /// <summary>The name of the hypervisor group being created</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Name { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Name; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Name = value; }

        /// <summary>Backing field for <see cref="OpenstackDomain" /> property.</summary>
        private string _openstackDomain;

        /// <summary>OpenStack Domain Name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string OpenstackDomain { get => this._openstackDomain; set => this._openstackDomain = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>OpenStack password</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>if credential validation has to be skipped.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? SkipCredentialValidation { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).SkipCredentialValidation; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).SkipCredentialValidation = value; }

        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private string _userName;

        /// <summary>OpenStack userName</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserName { get => this._userName; set => this._userName = value; }

        /// <summary>Creates an new <see cref="CreateHypervisorGroupOpenstack" /> instance.</summary>
        public CreateHypervisorGroupOpenstack()
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
    /// Create a hypervisor group with OpenStack as the destination vendor
    public partial interface ICreateHypervisorGroupOpenstack :
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
        /// <summary>OpenStack KeyNote address</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"OpenStack KeyNote address ",
        SerializedName = @"keynoteAddress",
        PossibleTypes = new [] { typeof(string) })]
        string KeynoteAddress { get; set; }
        /// <summary>OpenStack Domain Name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"OpenStack Domain Name ",
        SerializedName = @"openstackDomain",
        PossibleTypes = new [] { typeof(string) })]
        string OpenstackDomain { get; set; }
        /// <summary>OpenStack password</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"OpenStack password ",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>OpenStack userName</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"OpenStack userName ",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    /// Create a hypervisor group with OpenStack as the destination vendor
    internal partial interface ICreateHypervisorGroupOpenstackInternal :
        Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal
    {
        string HypervisorType { get; set; }
        /// <summary>OpenStack KeyNote address</summary>
        string KeynoteAddress { get; set; }
        /// <summary>OpenStack Domain Name</summary>
        string OpenstackDomain { get; set; }
        /// <summary>OpenStack password</summary>
        string Password { get; set; }
        /// <summary>OpenStack userName</summary>
        string UserName { get; set; }

    }
}