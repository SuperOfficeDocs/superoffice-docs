---
uid: version_10.1.9.1223_changes
date: 12.07.2022
---

<!-- markdownlint-disable-file MD013 MD024-->

# Changes from v10.1.8.583 and v10.1.9.1223

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.PreferredTimeZone`

### Modified Types

#### SuperOffice.CRM.Services.CustomerServiceAgent is Modified

* New items
  * Method `ReportSessionActive(String)`

#### SuperOffice.CRM.Services.ICustomerServiceAgent is Modified

* New items
  * Method `ReportSessionActive(String)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `SaveTicketMessageEntityWithOptions(TicketMessageEntity, Boolean, Int32[])`

#### SuperOffice.CRM.Services.ITimeZoneAgent is Modified

* New items
  * Method `GetDefaultTimeZoneInformation()`

#### SuperOffice.CRM.Services.PluginResponse is Modified

* New items
  * Property `Status`

#### SuperOffice.CRM.Services.PluginUrlResponse is Modified

* New items
  * Property `Status`

#### SuperOffice.CRM.Services.QuoteVersionValidated is Modified

* New items
  * Property `Status`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `SaveTicketMessageEntityWithOptions(TicketMessageEntity, Boolean, Int32[])`

#### SuperOffice.CRM.Services.TicketMessage is Modified

* New items
  * Property `ChangedAt`

#### SuperOffice.CRM.Services.TimeZoneAgent is Modified

* New items
  * Method `GetDefaultTimeZoneInformation()`

## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `Microsoft.Extensions.DependencyInjection.ServiceCollectionExtensions`

### Modified Types

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADD_RECIPIENTS`
  * Field `SR_ADMIN_CHAT_NAVITEM`
  * Field `SR_BULKUPDATE_FORWARD_REQUESTS`
  * Field `SR_BULKUPDATE_INFO_FORWARDED_ID`
  * Field `SR_CONFIGSCREEN_MANDATORY_FIELD_IN_PANE`
  * Field `SR_MENU_REPORTER_DOWNLOAD_CTV_NEW`
  * Field `SR_PD_serviceSettings_idleThreshold_DESC`
  * Field `SR_PD_serviceSettings_idleThreshold_NAME`
  * Field `SR_TICKET_BULKREPLY_CLOSE_REQUEST`
  * Field `SR_TICKET_BULKREPLY_EXTERNAL_REQUESTS_COUNT`
  * Field `SR_TICKET_BULKREPLY_INTERNAL_MESSAGE_ERROR`
  * Field `SR_TICKET_BULKREPLY_INTERNAL_REQUESTS_COUNT`
  * Field `SR_TICKET_BULKREPLY_MESSAGE_EMPTY`
  * Field `SR_TICKET_BULKREPLY_SEND_COPY_TO_CUSTOMER`
  * Field `SR_TICKET_MESSAGE_INCOMING`
  * Field `SR_TICKETARCHIVE_ALERT_TIMEOUT`
  * Field `SR_TICKETARCHIVE_SENTIMENT_CONFIDENCE`
  * Field `SR_TICKETMERGE_USER_HAS_NOT_EDIT_RIGHTS`

### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.Util.ChatExtenderHelper`

### New Types

* `SuperOffice.CRM.ArchiveLists.IArchiveProviderExtenderAccept`
* `SuperOffice.CRM.Lists.AppointmentCategoryListProvider`
* `SuperOffice.CRM.Lists.DocumentCategoryListProvider`
* `SuperOffice.CRM.Lists.SaleCategoryListProvider`
* `SuperOffice.Util.DurationTimeHelper`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.ActivityArchiveProviderBase is Modified

* New items
  * Field `EntityOther`

#### SuperOffice.CRM.ArchiveLists.Aggregation.AggregationPluginBase is Modified

* New items
  * Method `FirstModifier()`

#### SuperOffice.CRM.ArchiveLists.AppointmentExtenderBase is Modified

* New items
  * Method `AcceptRow(SoDataReader)`
  * Method `RequiredPhaseOneFields()`

#### SuperOffice.CRM.ArchiveLists.Archive.ChatConversationSelectionDynamicProviderSingleCriteriaGroup is Modified

* Deleted items
  * Method `AcceptRow(SoDataReader)`
  * Method `RequiredPhaseOneFields()`
  * Method `SetRestriction(ArchiveRestrictionInfo[])`

#### SuperOffice.CRM.ArchiveLists.Archive.ChatConversationSelectionDynamicProviderV2 is Modified

* New items
  * Method `SetDesiredEntities(String[])`

#### SuperOffice.CRM.ArchiveLists.Archive.FormSubmissionSelectionDynamicProviderV2 is Modified

* New items
  * Method `SetDesiredEntities(String[])`

#### SuperOffice.CRM.ArchiveLists.Archive.MailingsSelectionDynamicProviderV2 is Modified

* New items
  * Method `SetDesiredEntities(String[])`

#### SuperOffice.CRM.ArchiveLists.ChatSessionExtenderBase is Modified

* Deleted items
  * Field `DurationColumnName`
* New items
  * Method `AcceptRow(SoDataReader)`
  * Method `RequiredPhaseOneFields()`

#### SuperOffice.CRM.ArchiveLists.ExtensibleColumnsBase is Modified

* New items
  * Method `SetLeftOuterJoin(Equal)`
  * Method `SetLeftOuterJoin(Equal, Restriction)`

#### SuperOffice.CRM.ArchiveLists.QueryProviderBase&lt;RowType> is Modified

* New items
  * Method `GetAllExtenders()`

#### SuperOffice.CRM.ArchiveLists.TicketExtenderBase is Modified

* New items
  * Field `MinutePrecision`

#### SuperOffice.CRM.AttachmentHelper is Modified

* New items
  * Method `AddAttachmentsToMessage(Int32, Int32[])`
  * Method `GetAttachmentCount(Int32[])`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.EjMessageFields is Modified

* New items
  * Field `.EjMessageFieldsChangedAt`
  * Field `.EjMessageFieldsChangedBy`

#### SuperOffice.CRM.Data.EjMessageTableInfo is Modified

* New items
  * Property `ChangedAt`
  * Property `ChangedBy`
  * Property `ChangedBy_InnerJoin_Ejuser`

#### SuperOffice.CRM.Data.EjuserTableInfo is Modified

* New items
  * Property `LeftOuterJoin_EjMessage_ChangedBy`

#### SuperOffice.CRM.Rows.EjMessageRecordData is Modified

* New items
  * Field `ChangedAt`
  * Field `ChangedBy`

#### SuperOffice.CRM.Rows.EjMessageRow is Modified

* New items
  * Property `ChangedAt`
  * Property `ChangedBy`

#### SuperOffice.Util.DocumentSaveChangeAnalyzer is Modified

* New items
  * Property `IsDocumentArchiveProviderChanged`

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### Modified Types

#### SuperOffice.CD.DSL.Database.T_EjMessage is Modified

* New items
  * Field `ChangedAt`
  * Field `ChangedBy`
