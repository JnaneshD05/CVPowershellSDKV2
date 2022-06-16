// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Used to update the properties of an existing company</summary>
    [System.ComponentModel.TypeConverter(typeof(UpdateCompanyTypeConverter))]
    public partial class UpdateCompany
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.UpdateCompany"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IUpdateCompany" />.</returns>
        public static Commvault.Powershell.Models.IUpdateCompany DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpdateCompany(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.UpdateCompany"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IUpdateCompany" />.</returns>
        public static Commvault.Powershell.Models.IUpdateCompany DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpdateCompany(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpdateCompany" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IUpdateCompany FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.UpdateCompany"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpdateCompany(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Status = (Commvault.Powershell.Models.ICompanyStatus) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Status, Commvault.Powershell.Models.CompanyStatusTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).General = (Commvault.Powershell.Models.IGeneral) content.GetValueForProperty("General",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).General, Commvault.Powershell.Models.GeneralTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).EmailSettings = (Commvault.Powershell.Models.IEmailSettings) content.GetValueForProperty("EmailSettings",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).EmailSettings, Commvault.Powershell.Models.EmailSettingsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Sites = (Commvault.Powershell.Models.ISites) content.GetValueForProperty("Sites",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Sites, Commvault.Powershell.Models.SitesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptions = (Commvault.Powershell.Models.IFileExceptions) content.GetValueForProperty("FileExceptions",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptions, Commvault.Powershell.Models.FileExceptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).NewName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Security = (Commvault.Powershell.Models.IUpdateSecurityAssoc[]) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Security, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IUpdateSecurityAssoc>(__y, Commvault.Powershell.Models.UpdateSecurityAssocTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TenantOperators = (Commvault.Powershell.Models.ITenantOperator[]) content.GetValueForProperty("TenantOperators",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TenantOperators, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ITenantOperator>(__y, Commvault.Powershell.Models.TenantOperatorTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Plans = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("Plans",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Plans, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).DefaultPlans = (Commvault.Powershell.Models.IDefaultPlan[]) content.GetValueForProperty("DefaultPlans",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).DefaultPlans, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDefaultPlan>(__y, Commvault.Powershell.Models.DefaultPlanTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralNewAlias = (string) content.GetValueForProperty("GeneralNewAlias",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralNewAlias, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralEmailSuffix = (string) content.GetValueForProperty("GeneralEmailSuffix",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralEmailSuffix, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralSupportedSolutions = (string[]) content.GetValueForProperty("GeneralSupportedSolutions",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralSupportedSolutions, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralServiceCommcells = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("GeneralServiceCommcells",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralServiceCommcells, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).EmailSettingSenderName = (string) content.GetValueForProperty("EmailSettingSenderName",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).EmailSettingSenderName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).EmailSettingSenderEmail = (string) content.GetValueForProperty("EmailSettingSenderEmail",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).EmailSettingSenderEmail, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptionWindows = (string) content.GetValueForProperty("FileExceptionWindows",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptionWindows, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptionUnix = (string) content.GetValueForProperty("FileExceptionUnix",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptionUnix, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).StatusOptions = (Commvault.Powershell.Models.IDeactivationOptions) content.GetValueForProperty("StatusOptions",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).StatusOptions, Commvault.Powershell.Models.DeactivationOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).StatusDeactivate = (bool?) content.GetValueForProperty("StatusDeactivate",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).StatusDeactivate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralTwoFactorAuth = (Commvault.Powershell.Models.ITwoFactorAuth) content.GetValueForProperty("GeneralTwoFactorAuth",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralTwoFactorAuth, Commvault.Powershell.Models.TwoFactorAuthTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralAuthcodeForInstallation = (bool?) content.GetValueForProperty("GeneralAuthcodeForInstallation",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralAuthcodeForInstallation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralUpnInsteadOfEmail = (bool?) content.GetValueForProperty("GeneralUpnInsteadOfEmail",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralUpnInsteadOfEmail, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralResellerMode = (bool?) content.GetValueForProperty("GeneralResellerMode",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralResellerMode, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralEnableDataEncryption = (bool?) content.GetValueForProperty("GeneralEnableDataEncryption",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralEnableDataEncryption, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralAutoDiscoverApp = (bool?) content.GetValueForProperty("GeneralAutoDiscoverApp",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralAutoDiscoverApp, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralInfrastructureType = (string) content.GetValueForProperty("GeneralInfrastructureType",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralInfrastructureType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralAssignLaptopOwners = (string) content.GetValueForProperty("GeneralAssignLaptopOwners",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralAssignLaptopOwners, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TwoFactorAuthUserGroups = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("TwoFactorAuthUserGroups",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TwoFactorAuthUserGroups, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).SitePrimarySiteName = (string) content.GetValueForProperty("SitePrimarySiteName",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).SitePrimarySiteName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).SiteSecondarySiteNames = (string[]) content.GetValueForProperty("SiteSecondarySiteNames",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).SiteSecondarySiteNames, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptionUseCompanyGlobalFilter = (bool?) content.GetValueForProperty("FileExceptionUseCompanyGlobalFilter",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptionUseCompanyGlobalFilter, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).OptionDisableBackup = (bool?) content.GetValueForProperty("OptionDisableBackup",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).OptionDisableBackup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).OptionDisableRestore = (bool?) content.GetValueForProperty("OptionDisableRestore",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).OptionDisableRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).OptionDisableLogin = (bool?) content.GetValueForProperty("OptionDisableLogin",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).OptionDisableLogin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TwoFactorAuthEnable = (bool?) content.GetValueForProperty("TwoFactorAuthEnable",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TwoFactorAuthEnable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TwoFactorAuthAll = (bool?) content.GetValueForProperty("TwoFactorAuthAll",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TwoFactorAuthAll, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.UpdateCompany"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpdateCompany(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Status = (Commvault.Powershell.Models.ICompanyStatus) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Status, Commvault.Powershell.Models.CompanyStatusTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).General = (Commvault.Powershell.Models.IGeneral) content.GetValueForProperty("General",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).General, Commvault.Powershell.Models.GeneralTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).EmailSettings = (Commvault.Powershell.Models.IEmailSettings) content.GetValueForProperty("EmailSettings",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).EmailSettings, Commvault.Powershell.Models.EmailSettingsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Sites = (Commvault.Powershell.Models.ISites) content.GetValueForProperty("Sites",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Sites, Commvault.Powershell.Models.SitesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptions = (Commvault.Powershell.Models.IFileExceptions) content.GetValueForProperty("FileExceptions",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptions, Commvault.Powershell.Models.FileExceptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).NewName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Security = (Commvault.Powershell.Models.IUpdateSecurityAssoc[]) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Security, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IUpdateSecurityAssoc>(__y, Commvault.Powershell.Models.UpdateSecurityAssocTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TenantOperators = (Commvault.Powershell.Models.ITenantOperator[]) content.GetValueForProperty("TenantOperators",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TenantOperators, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ITenantOperator>(__y, Commvault.Powershell.Models.TenantOperatorTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Plans = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("Plans",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).Plans, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).DefaultPlans = (Commvault.Powershell.Models.IDefaultPlan[]) content.GetValueForProperty("DefaultPlans",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).DefaultPlans, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDefaultPlan>(__y, Commvault.Powershell.Models.DefaultPlanTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralNewAlias = (string) content.GetValueForProperty("GeneralNewAlias",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralNewAlias, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralEmailSuffix = (string) content.GetValueForProperty("GeneralEmailSuffix",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralEmailSuffix, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralSupportedSolutions = (string[]) content.GetValueForProperty("GeneralSupportedSolutions",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralSupportedSolutions, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralServiceCommcells = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("GeneralServiceCommcells",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralServiceCommcells, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).EmailSettingSenderName = (string) content.GetValueForProperty("EmailSettingSenderName",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).EmailSettingSenderName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).EmailSettingSenderEmail = (string) content.GetValueForProperty("EmailSettingSenderEmail",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).EmailSettingSenderEmail, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptionWindows = (string) content.GetValueForProperty("FileExceptionWindows",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptionWindows, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptionUnix = (string) content.GetValueForProperty("FileExceptionUnix",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptionUnix, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).StatusOptions = (Commvault.Powershell.Models.IDeactivationOptions) content.GetValueForProperty("StatusOptions",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).StatusOptions, Commvault.Powershell.Models.DeactivationOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).StatusDeactivate = (bool?) content.GetValueForProperty("StatusDeactivate",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).StatusDeactivate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralTwoFactorAuth = (Commvault.Powershell.Models.ITwoFactorAuth) content.GetValueForProperty("GeneralTwoFactorAuth",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralTwoFactorAuth, Commvault.Powershell.Models.TwoFactorAuthTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralAuthcodeForInstallation = (bool?) content.GetValueForProperty("GeneralAuthcodeForInstallation",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralAuthcodeForInstallation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralUpnInsteadOfEmail = (bool?) content.GetValueForProperty("GeneralUpnInsteadOfEmail",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralUpnInsteadOfEmail, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralResellerMode = (bool?) content.GetValueForProperty("GeneralResellerMode",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralResellerMode, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralEnableDataEncryption = (bool?) content.GetValueForProperty("GeneralEnableDataEncryption",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralEnableDataEncryption, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralAutoDiscoverApp = (bool?) content.GetValueForProperty("GeneralAutoDiscoverApp",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralAutoDiscoverApp, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralInfrastructureType = (string) content.GetValueForProperty("GeneralInfrastructureType",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralInfrastructureType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralAssignLaptopOwners = (string) content.GetValueForProperty("GeneralAssignLaptopOwners",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).GeneralAssignLaptopOwners, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TwoFactorAuthUserGroups = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("TwoFactorAuthUserGroups",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TwoFactorAuthUserGroups, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).SitePrimarySiteName = (string) content.GetValueForProperty("SitePrimarySiteName",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).SitePrimarySiteName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).SiteSecondarySiteNames = (string[]) content.GetValueForProperty("SiteSecondarySiteNames",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).SiteSecondarySiteNames, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptionUseCompanyGlobalFilter = (bool?) content.GetValueForProperty("FileExceptionUseCompanyGlobalFilter",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).FileExceptionUseCompanyGlobalFilter, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).OptionDisableBackup = (bool?) content.GetValueForProperty("OptionDisableBackup",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).OptionDisableBackup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).OptionDisableRestore = (bool?) content.GetValueForProperty("OptionDisableRestore",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).OptionDisableRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).OptionDisableLogin = (bool?) content.GetValueForProperty("OptionDisableLogin",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).OptionDisableLogin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TwoFactorAuthEnable = (bool?) content.GetValueForProperty("TwoFactorAuthEnable",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TwoFactorAuthEnable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TwoFactorAuthAll = (bool?) content.GetValueForProperty("TwoFactorAuthAll",((Commvault.Powershell.Models.IUpdateCompanyInternal)this).TwoFactorAuthAll, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }
    }
    /// Used to update the properties of an existing company
    [System.ComponentModel.TypeConverter(typeof(UpdateCompanyTypeConverter))]
    public partial interface IUpdateCompany

    {

    }
}