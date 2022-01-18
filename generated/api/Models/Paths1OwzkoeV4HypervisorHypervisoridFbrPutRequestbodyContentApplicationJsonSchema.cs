// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema :
        Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema,
        Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal
    {

        /// <summary>Internal Acessors for Fbrma</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal.Fbrma { get => (this._fbrma = this._fbrma ?? new Commvault.Powershell.Models.IdName()); set { {_fbrma = value;} } }

        /// <summary>Backing field for <see cref="Fbrma" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _fbrma;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Fbrma { get => (this._fbrma = this._fbrma ?? new Commvault.Powershell.Models.IdName()); set => this._fbrma = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? FbrmaId { get => ((Commvault.Powershell.Models.IIdNameInternal)Fbrma).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Fbrma).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string FbrmaName { get => ((Commvault.Powershell.Models.IIdNameInternal)Fbrma).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Fbrma).Name = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema" /> instance.
        /// </summary>
        public Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? FbrmaId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string FbrmaName { get; set; }

    }
    internal partial interface IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal

    {
        Commvault.Powershell.Models.IIdName Fbrma { get; set; }

        int? FbrmaId { get; set; }

        string FbrmaName { get; set; }

    }
}