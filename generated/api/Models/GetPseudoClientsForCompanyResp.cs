// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Response template for list of servers with no packages a company</summary>
    public partial class GetPseudoClientsForCompanyResp :
        Commvault.Powershell.Models.IGetPseudoClientsForCompanyResp,
        Commvault.Powershell.Models.IGetPseudoClientsForCompanyRespInternal
    {

        /// <summary>Backing field for <see cref="Clients" /> property.</summary>
        private Commvault.Powershell.Models.IIdNameDisplayName[] _clients;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdNameDisplayName[] Clients { get => this._clients; set => this._clients = value; }

        /// <summary>Creates an new <see cref="GetPseudoClientsForCompanyResp" /> instance.</summary>
        public GetPseudoClientsForCompanyResp()
        {

        }
    }
    /// Response template for list of servers with no packages a company
    public partial interface IGetPseudoClientsForCompanyResp :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"clients",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdNameDisplayName) })]
        Commvault.Powershell.Models.IIdNameDisplayName[] Clients { get; set; }

    }
    /// Response template for list of servers with no packages a company
    internal partial interface IGetPseudoClientsForCompanyRespInternal

    {
        Commvault.Powershell.Models.IIdNameDisplayName[] Clients { get; set; }

    }
}