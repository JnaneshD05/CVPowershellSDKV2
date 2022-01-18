// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Create task response for backup</summary>
    public partial class CreateTaskRespforBackup :
        Commvault.Powershell.Models.ICreateTaskRespforBackup,
        Commvault.Powershell.Models.ICreateTaskRespforBackupInternal
    {

        /// <summary>Backing field for <see cref="JobIds" /> property.</summary>
        private Commvault.Powershell.Models.IAny[] _jobIds;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IAny[] JobIds { get => this._jobIds; set => this._jobIds = value; }

        /// <summary>Backing field for <see cref="TaskId" /> property.</summary>
        private int? _taskId;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? TaskId { get => this._taskId; set => this._taskId = value; }

        /// <summary>Creates an new <see cref="CreateTaskRespforBackup" /> instance.</summary>
        public CreateTaskRespforBackup()
        {

        }
    }
    /// Create task response for backup
    public partial interface ICreateTaskRespforBackup :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"jobIds",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAny) })]
        Commvault.Powershell.Models.IAny[] JobIds { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"taskId",
        PossibleTypes = new [] { typeof(int) })]
        int? TaskId { get; set; }

    }
    /// Create task response for backup
    internal partial interface ICreateTaskRespforBackupInternal

    {
        Commvault.Powershell.Models.IAny[] JobIds { get; set; }

        int? TaskId { get; set; }

    }
}