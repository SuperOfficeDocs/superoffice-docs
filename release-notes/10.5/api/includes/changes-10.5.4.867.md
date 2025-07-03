---
uid: version_10.5.4.867_changes
date: 04.04.2025
---

<!-- markdownlint-disable-file MD041 MD033 MD024-->
Changes from v10.5.3.711 and v10.5.4.867

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.Appointment is Modified

* New items
  * Property `OwnedExternally`

#### SuperOffice.CRM.Services.AppointmentEntity is Modified

* New items
  * Property `OwnedExternally`

#### SuperOffice.CRM.Services.CRMScriptRunResult is Modified

* New items
  * Property `Headers`
  * Property `StatusCode`
  * Property `StatusMessage`

#### SuperOffice.CRM.Services.CustomerServiceAgent is Modified

* New items
  * Method `GetCustomerServiceStartupByOwner(Int32)`

#### SuperOffice.CRM.Services.CustomerServiceStartup is Modified

* New items
  * Property `SelectedPreferences`

#### SuperOffice.CRM.Services.ICustomerServiceAgent is Modified

* New items
  * Method `GetCustomerServiceStartupByOwner(Int32)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `GetHotlistEjUsers(Int32, Int32[], NotifyType, NotifyChannel)`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `GetHotlistEjUsers(Int32, Int32[], NotifyType, NotifyChannel)`

## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.Data.AppointmentExternalOwner`
* `SuperOffice.Data.NotifyChannel`
* `SuperOffice.Data.NotifyType`

### Modified Types

#### SuperOffice.Configuration.VersionPropertyNames is Modified

* New items
  * Field `DebugUser`

#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.NotificationEmail is Modified

* New items
  * Field `.NotificationEmailNotifyEmailCustomMessage`
  * Field `.NotificationEmailNotifyEmailFavouriteRequest`
  * Field `.NotificationEmailNotifyEmailNewMessage`
  * Field `.NotificationEmailNotifyEmailNewRequest`
  * Field `.NotificationEmailNotifyEmailOpenRequestsNotRead`
  * Field `.NotificationEmailNotifyEmailRequestActivated`
  * Field `.NotificationEmailNotifyEmailRequestAssignedAway`
  * Field `.NotificationEmailNotifyEmailRequestEscalated`

##### SuperOffice.CRM.UserPreferenceStrings.NotificationSms is Modified

* New items
  * Field `.NotificationSmsNotifySmsCustomMessage`
  * Field `.NotificationSmsNotifySmsFavouriteRequest`
  * Field `.NotificationSmsNotifySmsNewMessage`
  * Field `.NotificationSmsNotifySmsNewRequest`
  * Field `.NotificationSmsNotifySmsRequestActivated`
  * Field `.NotificationSmsNotifySmsRequestAssignedAway`
  * Field `.NotificationSmsNotifySmsRequestEscalated`

##### SuperOffice.CRM.UserPreferenceStrings.Request is Modified

* New items
  * Field `.RequestAutoQuoteLastmessage`
  * Field `.RequestCheckBoxOnLeft`
  * Field `.RequestDefaultMessageStatus`
  * Field `.RequestDefaultOwner`
  * Field `.RequestDefaultRequestStatus`
  * Field `.RequestNewWindowWhenAdding`
  * Field `.RequestNoWarnOnLoss`
  * Field `.RequestNumExpandedMsg`
  * Field `.RequestOnlyOpenInFavourites`
  * Field `.RequestOnlyOwnCategories`
  * Field `.RequestOwnRequestsOnly`
  * Field `.RequestPreviewImageAttachment`
  * Field `.RequestRequestDefaultCategory`
  * Field `.RequestShowLastOnTop`
  * Field `.RequestSimplifiedEditor`
  * Field `.RequestSingleLineBreaks`
  * Field `.RequestUseLastCategory`

#### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `HEL_Test_HTML`
* New items
  * Field `SR_IMPORT_SHOWALLROWS_INPREVIEW`
  * Field `SR_IMPORT_WARNING_DELAY`
  * Field `SR_INVITATION_OWNED_EXTERNALLY_GOOGLE`
  * Field `SR_INVITATION_OWNED_EXTERNALLY_OTHER`
  * Field `SR_INVITATION_OWNED_EXTERNALLY_OUTLOOK`
  * Field `SR_PD_Mailing_UseTrackingImage_DESC`
  * Field `SR_PD_Mailing_UseTrackingImage_NAME`
  * Field `SR_SCRIPT_TYPE`
  * Field `SR_SCRIPT_TYPE_TOOLTIP`
  * Field `SR_TICKET_INTERNAL_EXPLANATION`
  * Field `SR_TICKET_MESSAGES_QUICK_ACTION_HIDE_FORWARD`
  * Field `SR_TICKET_MESSAGES_QUICK_ACTION_HIDE_REPLY`
  * Field `SR_TICKET_MESSAGES_QUICK_ACTION_HIDE_REPLY_ALL`
  * Field `SR_TICKET_MESSAGES_QUICK_ACTIONS_SETTINGS`

### Assembly: SoDatabase

### New Types

* `SuperOffice.Data.IDebugUser`
* `SuperOffice.Data.SQL.AppointmentExternalOwnerFieldInfo`
* `SuperOffice.Util.ITrackEventDispatcher`
* `SuperOffice.Util.TrackEvent`
* `SuperOffice.Util.TrackEventConfiguration`
* `SuperOffice.Util.TrackEventDispatcher`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.Dynamic_specializations.DynamicSaleExtender is Modified

* New items
  * Method `InnerModifyQuery()`
  * Method `InnerPopulateRowFromReader(SoDataReader, ArchiveRow)`
  * Method `SetDesiredColumns(String[])`

#### SuperOffice.CRM.ArchiveLists.DynamicPersonExtender is Modified

#### SuperOffice.CRM.ArchiveLists.EjscriptExtenderBase is Modified

* New items
  * Field `ColumnType`

#### SuperOffice.CRM.ArchiveLists.PersonExtenderBase is Modified

* New items
  * Property `SupportLanguage`

#### SuperOffice.CRM.ArchiveLists.SaleExtenderBase is Modified

* New items
  * Method `ResolveProbabilityName(SaleStatus, Int32, String)`

#### SuperOffice.CRM.ArchiveLists.TicketMessageExtenderBase is Modified

#### SuperOffice.CRM.Data.AppointmentTableInfo is Modified

* New items
  * Property `OwnedExternally`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.AppointmentFields is Modified

* New items
  * Field `.AppointmentFieldsOwnedExternally`

#### SuperOffice.CRM.Entities.AppointmentMatrix is Modified

* New items
  * Method `GetMailBodyFromMailBody(TemplateVariables, String, ParticipantInfo)`

#### SuperOffice.CRM.Lists.QuoteTemplateProvider is Modified

* New items
  * Method `AcceptHistoryRow(ListTableRow)`

#### SuperOffice.CRM.Rows.AppointmentRecordData is Modified

* New items
  * Field `OwnedExternally`

#### SuperOffice.CRM.Rows.AppointmentRow is Modified

* New items
  * Property `OwnedExternally`
  * Event `OnOwnedExternallyChange`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(AppointmentExternalOwner&, FieldInfo)`
  * Method `ValidateField(NotifyChannel&, FieldInfo)`
  * Method `ValidateField(NotifyType&, FieldInfo)`

### Assembly: SuperOffice.Plugins

### Modified Types

#### SuperOffice.Factory.AssemblyHelper is Modified

* Deleted items
* Modified items
  * Method `IsSystemAssembly(String)`
* New items
  * Method `IsAllowedToScan(Assembly)`
  * Method `IsAllowedToScan(String)`

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.AppointmentExternalOwner`
* `SuperOffice.CD.Database.NotifyChannel`
* `SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_11_CustomMdoComponent2ForTicketStatus`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_119_Appointment_OwnedExternally`

### Modified Types

#### SuperOffice.CD.DSL.Database.NotifyType is Modified

#### SuperOffice.CD.DSL.Database.T_Appointment is Modified

* New items
  * Field `OwnedExternally`
