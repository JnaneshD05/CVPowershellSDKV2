// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class JobId :
        Commvault.Powershell.Models.IJobId,
        Commvault.Powershell.Models.IJobIdInternal
    {

        /// <summary>Backing field for <see cref="JobId1" /> property.</summary>
        private string _jobId1;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string JobId1 { get => this._jobId1; set => this._jobId1 = value; }

        /// <summary>Creates an new <see cref="JobId" /> instance.</summary>
        public JobId()
        {

        }
    }
    public partial interface IJobId :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(string) })]
        string JobId1 { get; set; }

    }
    internal partial interface IJobIdInternal

    {
        string JobId1 { get; set; }

    }
}