﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.StyleCop {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.StyleCop.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The add-in does not contain the property {0}..
        /// </summary>
        internal static string AddInDoesNotContainProperty {
            get {
                return ResourceManager.GetString("AddInDoesNotContainProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An AlertDialog which provides the user an option has been fired while the program is running in a non-UI state. In this state, the only valid option for AlertDialog is MessageBoxButtons.OK. Check the DisplayUI property on the StyleCopCore object before calling an AlertDialog which provides other options..
        /// </summary>
        internal static string AlertDialogWithOptionsInNonUIState {
            get {
                return ResourceManager.GetString("AlertDialogWithOptionsInNonUIState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All files.
        /// </summary>
        internal static string AllFiles {
            get {
                return ResourceManager.GetString("AllFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred during the analysis: {0}.
        /// </summary>
        internal static string AnalysisErrorOccurred {
            get {
                return ResourceManager.GetString("AnalysisErrorOccurred", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rules.
        /// </summary>
        internal static string AnalyzersTab {
            get {
                return ResourceManager.GetString("AnalyzersTab", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both nodes must be null, or both nodes must be non-null..
        /// </summary>
        internal static string BothItemsMustBeNullOrNonNull {
            get {
                return ResourceManager.GetString("BothItemsMustBeNullOrNonNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Results Caching.
        /// </summary>
        internal static string CacheTab {
            get {
                return ResourceManager.GetString("CacheTab", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StyleCop is running in non-UI mode. The settings dialog cannot be displayed in this mode. Check the status of the DisplayUI property on the StyleCopCore object before attempting to display settings..
        /// </summary>
        internal static string CannotDisplaySettingsInNonUIMode {
            get {
                return ResourceManager.GetString("CannotDisplaySettingsInNonUIMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The settings file at this path cannot be loaded: {0}.
        /// </summary>
        internal static string CannotLoadSettingsFilePath {
            get {
                return ResourceManager.GetString("CannotLoadSettingsFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string Collec {
            get {
                return ResourceManager.GetString("Collec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is not possible to compare properties of different types..
        /// </summary>
        internal static string ComparingDifferentPropertyTypes {
            get {
                return ResourceManager.GetString("ComparingDifferentPropertyTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The settings file could not be saved: {0}.
        /// </summary>
        internal static string CouldNotSaveSettingsFile {
            get {
                return ResourceManager.GetString("CouldNotSaveSettingsFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not save the violations file..
        /// </summary>
        internal static string CouldNotSaveViolationsFile {
            get {
                return ResourceManager.GetString("CouldNotSaveViolationsFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not save the violations file. An exception occurred: {0}.
        /// </summary>
        internal static string CouldNotSaveViolationsFileWithException {
            get {
                return ResourceManager.GetString("CouldNotSaveViolationsFileWithException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft StyleCop Default Settings.
        /// </summary>
        internal static string DefaultSettingsDialogTitle {
            get {
                return ResourceManager.GetString("DefaultSettingsDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analyzers are no longer allowed by be disabled by default. The DisableByDefault attribute has been deprecated and is not allowed to appear on a SourceAnalyzer node. Instead, place a DisabledByDefault attribute on Rule nodes to indicate individual rules which are disabled by default..
        /// </summary>
        internal static string DisabledByDefaultAttributeDeprecatedForAddIns {
            get {
                return ResourceManager.GetString("DisabledByDefaultAttributeDeprecatedForAddIns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are about to edit the default settings which are applied to all code on which this installation of StyleCop is run. You may need special permissions to write to the file. Are you sure you want to do this?.
        /// </summary>
        internal static string EditDefaultSettingsWarning {
            get {
                return ResourceManager.GetString("EditDefaultSettingsWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The settings file path must not be empty..
        /// </summary>
        internal static string EmptySettingsFilePath {
            get {
                return ResourceManager.GetString("EmptySettingsFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: {0}.
        /// </summary>
        internal static string ErrorTag {
            get {
                return ResourceManager.GetString("ErrorTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while loading one of the StyleCop add-ins: {0}, {1}.
        /// </summary>
        internal static string ExceptionWhileLoadingAddins {
            get {
                return ResourceManager.GetString("ExceptionWhileLoadingAddins", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Global Settings File.
        /// </summary>
        internal static string GlobalSettingsFile {
            get {
                return ResourceManager.GetString("GlobalSettingsFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The global settings file could not be loaded. Global settings will not be displayed..
        /// </summary>
        internal static string GlobalSettingsNotLoaded {
            get {
                return ResourceManager.GetString("GlobalSettingsNotLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal Error.
        /// </summary>
        internal static string InternalError {
            get {
                return ResourceManager.GetString("InternalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The analyzer or parser add-in returned a null or empty Xml initialization document..
        /// </summary>
        internal static string InvalidAddInXmlDocument {
            get {
                return ResourceManager.GetString("InvalidAddInXmlDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The window location input string is invalid: {0}.
        /// </summary>
        internal static string InvalidWindowLocationInputString {
            get {
                return ResourceManager.GetString("InvalidWindowLocationInputString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Is invalid.
        /// </summary>
        internal static string IsInvalid {
            get {
                return ResourceManager.GetString("IsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft StyleCop Linked Settings.
        /// </summary>
        internal static string LinkedSettingsDialogTitle {
            get {
                return ResourceManager.GetString("LinkedSettingsDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft StyleCop Project Settings.
        /// </summary>
        internal static string LocalSettingsDialogTitle {
            get {
                return ResourceManager.GetString("LocalSettingsDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The local settings file could not be opened or created: {0}.
        /// </summary>
        internal static string LocalSettingsNotOpenedOrCreated {
            get {
                return ResourceManager.GetString("LocalSettingsNotOpenedOrCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is not possible to merge two sets of settings when one specifies that rules are enabled by default, and the other specifies that rules are disabled by default..
        /// </summary>
        internal static string MergedSettingsRulesEnabledByDefaultMismatch {
            get {
                return ResourceManager.GetString("MergedSettingsRulesEnabledByDefaultMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no description for the add-in..
        /// </summary>
        internal static string MissingAddInDescription {
            get {
                return ResourceManager.GetString("MissingAddInDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The root node does not have a valid name attribute..
        /// </summary>
        internal static string MissingNameAttributeOnRootNode {
            get {
                return ResourceManager.GetString("MissingNameAttributeOnRootNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The node has already been inserted into a different collection..
        /// </summary>
        internal static string NodeAlreadyInCollection {
            get {
                return ResourceManager.GetString("NodeAlreadyInCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The node is not a member of the current list..
        /// </summary>
        internal static string NodeIsNotMemberOfList {
            get {
                return ResourceManager.GetString("NodeIsNotMemberOfList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The node is not a member of the list..
        /// </summary>
        internal static string NodeNotInList {
            get {
                return ResourceManager.GetString("NodeNotInList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The linked settings file does not exist or cannot be loaded..
        /// </summary>
        internal static string NoLinkedSettingsFile {
            get {
                return ResourceManager.GetString("NoLinkedSettingsFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no settings file located in a parent folder above the location of this settings file..
        /// </summary>
        internal static string NoParentSettingsFile {
            get {
                return ResourceManager.GetString("NoParentSettingsFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No violations encountered.
        /// </summary>
        internal static string NoViolationsEncountered {
            get {
                return ResourceManager.GetString("NoViolationsEncountered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft StyleCop Parent Settings.
        /// </summary>
        internal static string ParentSettingsDialogTitle {
            get {
                return ResourceManager.GetString("ParentSettingsDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parent settings file should only be edited by a build administrator, as the changes may apply to many projects. Are you sure you want to do this?.
        /// </summary>
        internal static string ParentSettingsEditedByAdministrator {
            get {
                return ResourceManager.GetString("ParentSettingsEditedByAdministrator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The settings file for the project could not be loaded or created: {0}.
        /// </summary>
        internal static string ProjectSettingsFileNotLoadedOrCreated {
            get {
                return ResourceManager.GetString("ProjectSettingsFileNotLoadedOrCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PropertyControl object has already been initialized.
        /// </summary>
        internal static string PropertyControlAlreadyInitialized {
            get {
                return ResourceManager.GetString("PropertyControlAlreadyInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property description has not been set..
        /// </summary>
        internal static string PropertyDescriptionNotSet {
            get {
                return ResourceManager.GetString("PropertyDescriptionNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property container does not contain a property descriptor for the {0} property..
        /// </summary>
        internal static string PropertyDescriptorDoesNotExist {
            get {
                return ResourceManager.GetString("PropertyDescriptorDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property descriptor does not have a default value defined..
        /// </summary>
        internal static string PropertyDescriptorHasNoDefaultValue {
            get {
                return ResourceManager.GetString("PropertyDescriptorHasNoDefaultValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The friendly name of the property has not been set..
        /// </summary>
        internal static string PropertyFriendlyNameNotSet {
            get {
                return ResourceManager.GetString("PropertyFriendlyNameNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property has no description..
        /// </summary>
        internal static string PropertyHasNoDescription {
            get {
                return ResourceManager.GetString("PropertyHasNoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property has no friendly name..
        /// </summary>
        internal static string PropertyHasNoFriendlyName {
            get {
                return ResourceManager.GetString("PropertyHasNoFriendlyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property has no name..
        /// </summary>
        internal static string PropertyHasNoName {
            get {
                return ResourceManager.GetString("PropertyHasNoName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property&apos;s merge attribute does not contain a boolean value..
        /// </summary>
        internal static string PropertyMergeAttributeHasInvalidValue {
            get {
                return ResourceManager.GetString("PropertyMergeAttributeHasInvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The collection is read-only..
        /// </summary>
        internal static string ReadOnlyCollection {
            get {
                return ResourceManager.GetString("ReadOnlyCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property is read-only..
        /// </summary>
        internal static string ReadOnlyProperty {
            get {
                return ResourceManager.GetString("ReadOnlyProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the root node must be &apos;SourceParser&apos;.
        /// </summary>
        internal static string RootNodeMustBeSourceParser {
            get {
                return ResourceManager.GetString("RootNodeMustBeSourceParser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A rule&apos;s CheckId must be six characters long, composed of two upper-case letters followed by four digits..
        /// </summary>
        internal static string RuleCheckIdInvalid {
            get {
                return ResourceManager.GetString("RuleCheckIdInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A rule cannot be marked with DisableByDefault=true if it is also marked with CanDisable=false..
        /// </summary>
        internal static string RuleDisabledByDefaultAndNotCanDisable {
            get {
                return ResourceManager.GetString("RuleDisabledByDefaultAndNotCanDisable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The rule {0} does not exist.
        /// </summary>
        internal static string RuleDoesNotExist {
            get {
                return ResourceManager.GetString("RuleDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The rule group has no Name attribute..
        /// </summary>
        internal static string RuleGroupHasNoNameAttribute {
            get {
                return ResourceManager.GetString("RuleGroupHasNoNameAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The rule {0} has no CheckId attribute..
        /// </summary>
        internal static string RuleHasNoCheckIdAttribute {
            get {
                return ResourceManager.GetString("RuleHasNoCheckIdAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The rule {0} has no Context element or the Context is empty..
        /// </summary>
        internal static string RuleHasNoContextElement {
            get {
                return ResourceManager.GetString("RuleHasNoContextElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The rule has no Name attribute..
        /// </summary>
        internal static string RuleHasNoNameAttribute {
            get {
                return ResourceManager.GetString("RuleHasNoNameAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A rule name must start with an upper-case letter, and can only contain letters and numbers..
        /// </summary>
        internal static string RuleNameInvalid {
            get {
                return ResourceManager.GetString("RuleNameInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A rule with the same name has already been added..
        /// </summary>
        internal static string RuleWithSameNameExists {
            get {
                return ResourceManager.GetString("RuleWithSameNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A settings file has not been loaded..
        /// </summary>
        internal static string SettingsFileHasNotBeenLoaded {
            get {
                return ResourceManager.GetString("SettingsFileHasNotBeenLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} (*.StyleCop)|*.StyleCop|{1} (*.*)|*.*&quot;.
        /// </summary>
        internal static string SettingsFileMatchPaths {
            get {
                return ResourceManager.GetString("SettingsFileMatchPaths", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings files.
        /// </summary>
        internal static string SettingsFiles {
            get {
                return ResourceManager.GetString("SettingsFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings Files.
        /// </summary>
        internal static string SettingsFilesTab {
            get {
                return ResourceManager.GetString("SettingsFilesTab", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The analyzer type does not have a properly formatted SourceAnalyzer attribute..
        /// </summary>
        internal static string SourceAnalyzerAttributeMissing {
            get {
                return ResourceManager.GetString("SourceAnalyzerAttributeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the root node must be &apos;SourceAnalyzer&apos;.
        /// </summary>
        internal static string SourceAnalyzerRootNodeIsIncorrect {
            get {
                return ResourceManager.GetString("SourceAnalyzerRootNodeIsIncorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A SourceCodeFactory may not return null..
        /// </summary>
        internal static string SourceCodeFactoryReturnsNull {
            get {
                return ResourceManager.GetString("SourceCodeFactoryReturnsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream-based runtime environments must use the SourceCodeStream class..
        /// </summary>
        internal static string SourceCodeStreamRequired {
            get {
                return ResourceManager.GetString("SourceCodeStreamRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SourceCode&apos;s Type property is not set..
        /// </summary>
        internal static string SourceCodeTypePropertyNotSet {
            get {
                return ResourceManager.GetString("SourceCodeTypePropertyNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream-based runtime environments must use the StreamBasedCodeProject class rather than CodeProject..
        /// </summary>
        internal static string StreamBasedCodeProjectRequired {
            get {
                return ResourceManager.GetString("StreamBasedCodeProjectRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GetCodeEditor is not implemented by StyleCopConsole..
        /// </summary>
        internal static string StyleCopConsoleDoesNotImplementGetCodeEditor {
            get {
                return ResourceManager.GetString("StyleCopConsoleDoesNotImplementGetCodeEditor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft StyleCop is unable to load. An unexpected error occurred. {0}.
        /// </summary>
        internal static string StyleCopUnableToLoad {
            get {
                return ResourceManager.GetString("StyleCopUnableToLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft StyleCop.
        /// </summary>
        internal static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A rule defined within a third-party rules add-in uses the CheckId {0}. CheckIds for third-party rules may not use the SA prefix, but instead must define their own two-letter prefix..
        /// </summary>
        internal static string UnknownAssemblyUsingDefaultCheckIdPrefix {
            get {
                return ResourceManager.GetString("UnknownAssemblyUsingDefaultCheckIdPrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: {1}.
        /// </summary>
        internal static string ViolationFormatter {
            get {
                return ResourceManager.GetString("ViolationFormatter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} violations encountered..
        /// </summary>
        internal static string ViolationsEncountered {
            get {
                return ResourceManager.GetString("ViolationsEncountered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: {0}.
        /// </summary>
        internal static string WarningTag {
            get {
                return ResourceManager.GetString("WarningTag", resourceCulture);
            }
        }
    }
}
