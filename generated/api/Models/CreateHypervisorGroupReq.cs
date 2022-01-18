// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Create a hypervisor group</summary>
    public partial class CreateHypervisorGroupReq :
        Commvault.Powershell.Models.ICreateHypervisorGroupReq,
        Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal
    {

        /// <summary>Backing field for <see cref="AccessNodes" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _accessNodes;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] AccessNodes { get => this._accessNodes; set => this._accessNodes = value; }

        /// <summary>Internal Acessors for Credentials</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal.Credentials { get => (this._credentials = this._credentials ?? new Commvault.Powershell.Models.IdName()); set { {_credentials = value;} } }

        /// <summary>Backing field for <see cref="Credentials" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _credentials;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Credentials { get => (this._credentials = this._credentials ?? new Commvault.Powershell.Models.IdName()); set => this._credentials = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CredentialsId { get => ((Commvault.Powershell.Models.IIdNameInternal)Credentials).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Credentials).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CredentialsName { get => ((Commvault.Powershell.Models.IIdNameInternal)Credentials).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Credentials).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the hypervisor group being created</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="SkipCredentialValidation" /> property.</summary>
        private bool? _skipCredentialValidation;

        /// <summary>if credential validation has to be skipped.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? SkipCredentialValidation { get => this._skipCredentialValidation; set => this._skipCredentialValidation = value; }

        /// <summary>Creates an new <see cref="CreateHypervisorGroupReq" /> instance.</summary>
        public CreateHypervisorGroupReq()
        {

        }
    }
    /// Create a hypervisor group
    public partial interface ICreateHypervisorGroupReq :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"accessNodes",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] AccessNodes { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? CredentialsId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CredentialsName { get; set; }
        /// <summary>The name of the hypervisor group being created</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the hypervisor group being created",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>if credential validation has to be skipped.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"if credential validation has to be skipped.",
        SerializedName = @"skipCredentialValidation",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SkipCredentialValidation { get; set; }

    }
    /// Create a hypervisor group
    internal partial interface ICreateHypervisorGroupReqInternal

    {
        Commvault.Powershell.Models.IIdName[] AccessNodes { get; set; }

        Commvault.Powershell.Models.IIdName Credentials { get; set; }

        int? CredentialsId { get; set; }

        string CredentialsName { get; set; }
        /// <summary>The name of the hypervisor group being created</summary>
        string Name { get; set; }
        /// <summary>if credential validation has to be skipped.</summary>
        bool? SkipCredentialValidation { get; set; }

    }
}