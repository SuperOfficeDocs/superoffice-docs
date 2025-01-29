---
uid: version_10.5.1.871_changes
date: 29.01.2025
---

Changes from v10.3.13.233 and v10.5.1.871

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* New items
  * Method `MoveWithEmail(Int32, DateTime, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `UpdateAppointmentWithModeAndEmail(Int32, DateTime, DateTime, AppointmentStatus, AppointmentType, Int32, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo)`

#### SuperOffice.CRM.Services.AppointmentInfo is Modified

* New items
  * Property `AnySendEmail`
  * Property `SendEmail`

#### SuperOffice.CRM.Services.DocumentAgent is Modified

* New items
  * Method `SavePrivacyReportPdf(Stream, String, Int32)`

#### SuperOffice.CRM.Services.IAppointmentAgent is Modified

* New items
  * Method `MoveWithEmail(Int32, DateTime, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `UpdateAppointmentWithModeAndEmail(Int32, DateTime, DateTime, AppointmentStatus, AppointmentType, Int32, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo)`

#### SuperOffice.CRM.Services.IDocumentAgent is Modified

* New items
  * Method `SavePrivacyReportPdf(Stream, String, Int32)`

#### SuperOffice.CRM.Services.IProjectAgent is Modified

* New items
  * Method `UpdateProjectMembers(Int32, ProjectMember[])`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `DoEscalating(Int32, TicketPriorityEscalateAction)`

#### SuperOffice.CRM.Services.ProjectAgent is Modified

* New items
  * Method `UpdateProjectMembers(Int32, ProjectMember[])`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `DoEscalating(Int32, TicketPriorityEscalateAction)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Modified Types

#### Microsoft.Extensions.DependencyInjection.NetServerServiceCollectionExtensions is Modified

* Deleted items
  * Method `AddTransientPlugin<TPlugin>(IServiceCollection)`
* New items
  * Method `AddTransientPlugin<TPlugin>(IServiceCollection, Func<IServiceProvider, TPlugin>)`

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.ExtraFieldAttrib is Modified

* New items
  * Field `.ExtraFieldAttribDisplayField`


##### SuperOffice.CRM.ArchiveLists.Constants.Options is Modified

* New items
  * Field `.OptionsDisplayFieldName`
  * Field `.OptionsForceRecompile`


#### SuperOffice.CRM.Services.IRequestArgumentsInfo is Modified

* Deleted items
  * Method `Initialize(String, Dictionary<String, Object>)`
* New items
  * Property `NsApiSlow`
  * Property `OperationNameArgumentsAppendix`
  * Method `AddInfo(String, String)`
  * Method `Initialize(String, Int64, Int32, Dictionary<String, Object>, Dictionary<String, Object>)`

#### SuperOffice.CRM.Services.RecurrenceDate is Modified

* Modified items
  * Property `Date`

#### SuperOffice.CRM.Services.RecurrenceInfo is Modified

* Modified items
  * Property `EndDate`
  * Property `StartDate`

#### SuperOffice.CRM.Services.RequestArgumentsInfo is Modified

* Deleted items
  * Method `Initialize(String, Dictionary<String, Object>)`
* New items
  * Property `NsApiSlow`
  * Property `OperationNameArgumentsAppendix`
  * Method `AddInfo(String, String)`
  * Method `Initialize(String, Int64, Int32, Dictionary<String, Object>, Dictionary<String, Object>)`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_CONFIGSCREEN_ARCHIVE_ITEM`
  * Field `SR_CONFIGSCREEN_PRIMARY_ITEM`
  * Field `SR_LICENSE_EXPIRED_ADMINWARNING`
  * Field `SR_LICENSE_EXPIRED_EXPIRED`
  * Field `SR_LICENSE_EXPIRED_GRACE`
  * Field `SR_LICENSE_NODATA`
  * Field `SR_MENU_DIARY_TODOLIST`
  * Field `SR_MM_CHANGE_DOCUMENT`
  * Field `SR_NO_ROWS_SELECTED`
  * Field `SR_PD_Client_DESC`
  * Field `SR_PD_Client_NAME`
  * Field `SR_PD_DiaryView_SeparateActivityView_DESC`
  * Field `SR_PD_DiaryView_SeparateActivityView_NAME`
  * Field `SR_TICKET_TRANSLATED_FROM`
  * Field `SR_TOOLTIP_TASK_NEW_TICKET`

#### SuperOffice.License.BuildInfoAttribute is Modified

* Deleted items
  * Method `BuildInfoAttribute(String, String, String, String)`
* New items
  * Property `SemanticVersion`
  * Method `BuildInfoAttribute(String, String, String, String, String)`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.ArchiveLists.Archive.FindErpProductSearchProvider`

### Modified Types

#### .ExtraFieldsAppointmentExtender is Modified

* Deleted items
  * Method `ExtraFieldsAppointmentExtender(SoField, String, RecursionInfo)`
* New items
  * Method `ExtraFieldsAppointmentExtender(String, RecursionInfo)`
  * Method `InnerPopulateRowFromReader(SoDataReader, ArchiveRow)`
  * Method `SetDesiredColumns(String[])`

#### .ExtraFieldsContactExtender is Modified

* Deleted items
  * Method `ExtraFieldsContactExtender(SoField, String, RecursionInfo)`
* New items
  * Method `ExtraFieldsContactExtender(String, RecursionInfo)`

#### .ExtraFieldsPersonExtender is Modified

* Deleted items
  * Method `ExtraFieldsPersonExtender(SoField, String, RecursionInfo)`
* New items
  * Method `ExtraFieldsPersonExtender(String, RecursionInfo)`
  * Method `InnerPopulateRowFromReader(SoDataReader, ArchiveRow)`
  * Method `SetDesiredColumns(String[])`

#### .ExtraFieldsProjectExtender is Modified

* Deleted items
  * Method `ExtraFieldsProjectExtender(SoField, String, RecursionInfo)`
* New items
  * Method `ExtraFieldsProjectExtender(String, RecursionInfo)`

#### .ExtraFieldsSaleExtender is Modified

* Deleted items
  * Method `ExtraFieldsSaleExtender(SoField, String, RecursionInfo)`
* New items
  * Method `ExtraFieldsSaleExtender(String, RecursionInfo)`

#### .ExtraFieldsTicketExtender is Modified

* Deleted items
  * Method `ExtraFieldsTicketExtender(SoField, String, RecursionInfo)`
* New items
  * Method `ExtraFieldsTicketExtender(String, RecursionInfo)`

#### SuperOffice.CRM.ArchiveLists.ExtraFieldsExtraTableExtender is Modified

* Deleted items
  * Method `ExtraFieldsExtraTableExtender(SoField, String, RecursionInfo)`
  * Method `ExtraFieldsExtraTableExtender(SoField, String, RecursionInfo, Boolean)`
* New items
  * Method `ExtraFieldsExtraTableExtender(String, RecursionInfo)`
  * Method `ExtraFieldsExtraTableExtender(String, RecursionInfo, Boolean)`

#### SuperOffice.CRM.ArchiveLists.RecursionInfo is Modified

* New items
  * Property `RelationField`

#### SuperOffice.CRM.Cache.ExtraFieldsCache is Modified

* Modified items
  * Method `GetDisplayField(Int32)`
  * Method `GetDisplayField(String)`

#### SuperOffice.CRM.Lists.ArchiveColumnsProviderBase is Modified

* New items
  * Field `SubHeadingIdStart`

#### SuperOffice.CRM.Script.CRMScriptHelper is Modified

* New items
  * Method `WriteJavaScriptLogging(String[])`

#### SuperOffice.CRM.Workflow.WorkflowUtil is Modified

* Modified items
  * Method `HasEmarketingConsentAndSubscription(Int32, Int32, String&)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database


