// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class IdNameProvider :
        Commvault.Powershell.Models.IIdNameProvider,
        Commvault.Powershell.Models.IIdNameProviderInternal
    {

        /// <summary>Internal Acessors for Provider</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IIdNameProviderInternal.Provider { get => (this._provider = this._provider ?? new Commvault.Powershell.Models.IdName()); set { {_provider = value;} } }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Provider" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _provider;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Provider { get => (this._provider = this._provider ?? new Commvault.Powershell.Models.IdName()); set => this._provider = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ProviderId { get => ((Commvault.Powershell.Models.IIdNameInternal)Provider).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Provider).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ProviderName { get => ((Commvault.Powershell.Models.IIdNameInternal)Provider).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Provider).Name = value ?? null; }

        /// <summary>Creates an new <see cref="IdNameProvider" /> instance.</summary>
        public IdNameProvider()
        {

        }
    }
    public partial interface IIdNameProvider :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? ProviderId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderName { get; set; }

    }
    internal partial interface IIdNameProviderInternal

    {
        int? Id { get; set; }

        string Name { get; set; }

        Commvault.Powershell.Models.IIdName Provider { get; set; }

        int? ProviderId { get; set; }

        string ProviderName { get; set; }

    }
}