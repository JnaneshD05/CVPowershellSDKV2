// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class AlertCategoryIdName1 :
        Commvault.Powershell.Models.IAlertCategoryIdName1,
        Commvault.Powershell.Models.IAlertCategoryIdName1Internal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        /// <summary>id of the category of the alert definition</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>category of the alert definition</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="AlertCategoryIdName1" /> instance.</summary>
        public AlertCategoryIdName1()
        {

        }
    }
    public partial interface IAlertCategoryIdName1 :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>id of the category of the alert definition</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"id of the category of the alert definition",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }
        /// <summary>category of the alert definition</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"category of the alert definition",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    internal partial interface IAlertCategoryIdName1Internal

    {
        /// <summary>id of the category of the alert definition</summary>
        int? Id { get; set; }
        /// <summary>category of the alert definition</summary>
        string Name { get; set; }

    }
}