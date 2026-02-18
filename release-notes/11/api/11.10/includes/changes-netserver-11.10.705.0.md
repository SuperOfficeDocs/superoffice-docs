---
uid: version_11.10.705.0_changes
date: 18.02.2026
---

Changes from v11.9.1204.0 and v11.10.705.0

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.FormDesignCarrier is Modified

* New items
  * Property `Confidence`
  * Property `CssStyles`
  * Property `Notes`

#### SuperOffice.CRM.Services.IAIAgent is Modified

* New items
  * Method `GetFormDesignCssFromImageAsync(Stream, String[], CancellationToken)`
  * Method `GetFormDesignCssFromUrlAsync(String, String[], CancellationToken)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `GetTicketRelationEntityAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.MDOListItem is Modified

* Deleted items
  * Method `GetFlattenedList(MDOListItem[])`
  * Method `GetFlattenedList(ICollection<MDOListItem>)`

#### SuperOffice.CRM.Services.Project is Modified

* New items
  * Property `EventId`
  * Property `StartDate`

#### SuperOffice.CRM.Services.ProjectEntity is Modified

* New items
  * Property `EventId`
  * Property `StartDate`

#### SuperOffice.CRM.Services.ProjectMember is Modified

* New items
  * Property `EventParticipantStatus`

#### SuperOffice.CRM.Services.RagStatus is Modified

* Deleted items
  * Property `StatusWebsite`

#### SuperOffice.CRM.Services.SelectableMDOListItem is Modified

* Deleted items
  * Method `GetFlattenedList(SelectableMDOListItem[])`
  * Method `GetFlattenedList(SelectableMDOListItem[], Boolean)`
  * Method `GetFlattenedList(ICollection<SelectableMDOListItem>)`
  * Method `GetFlattenedListFull(ICollection<SelectableMDOListItem>)`


### Assembly: SuperOffice.Services.Implementation

### Deleted Types

* `SuperOffice.Products.NetServerLocalServices`

### Modified Types

#### SuperOffice.CRM.Services.AIAgent is Modified

* New items
  * Method `GetFormDesignCssFromImageAsync(Stream, String[], CancellationToken)`
  * Method `GetFormDesignCssFromUrlAsync(String, String[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IFormDesignCarrierImplementation is Modified

* New items
  * Method `GetFormDesignCssFromImageAsync(Stream, String[], CancellationToken)`
  * Method `GetFormDesignCssFromUrlAsync(String, String[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketRelationEntityImplementation is Modified

* New items
  * Method `GetTicketRelationEntityAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.FormDesignCarrierImplementation is Modified

* New items
  * Method `GetFormDesignCssFromImageAsync(Stream, String[], CancellationToken)`
  * Method `GetFormDesignCssFromUrlAsync(String, String[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketRelationEntityImplementation is Modified

* New items
  * Method `GetTicketRelationEntityAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `GetTicketRelationEntityAsync(Int32, CancellationToken)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.License.Product`
* `SuperOffice.License.ProductAttribute`
* `SuperOffice.Products.NetServerCore`

### New Types

* `SuperOffice.CRM.ArchiveLists.ArchiveColumnInfoExtensions`
* `SuperOffice.Data.ProjectMemberEventParticipantStatus`
* `SuperOffice.Security.Principal.IPrincipalStateAccessor`

### Modified Types

#### SuperOffice.Configuration.ConfigFile is Modified

* Deleted items

##### SuperOffice.Configuration.ConfigFile.IReporterConfiguration is Deleted

##### SuperOffice.Configuration.ConfigFile.Reporter is Deleted
* Modified items

##### SuperOffice.Configuration.ConfigFile.BatchService is Modified

* Deleted items
  * Property `.BatchServiceImpersonateReporterPlugin`
  * Property `.BatchServiceReporterPath`


##### SuperOffice.Configuration.ConfigFile.IBatchServiceConfiguration is Modified

* Deleted items
  * Property `.IBatchServiceConfigurationImpersonateReporterPlugin`
  * Property `.IBatchServiceConfigurationReporterPath`


#### SuperOffice.CRM.ArchiveLists.ArchiveColumnInfo is Modified

* Deleted items
  * Method `ToNameArray(ArchiveColumnInfo[])`
  * Method `ToNameArray(List<ArchiveColumnInfo>)`
  * Method `ToNameArray(Predicate<ArchiveColumnInfo>, ArchiveColumnInfo[])`
  * Method `ToNameArray(Predicate<ArchiveColumnInfo>, List<ArchiveColumnInfo>)`
  * Method `ToNameDictionary(ArchiveColumnInfo[])`
  * Method `ToNameDictionary(List<ArchiveColumnInfo>)`
  * Method `ToNameDictionary(Predicate<ArchiveColumnInfo>, ArchiveColumnInfo[])`
  * Method `ToNameDictionary(Predicate<ArchiveColumnInfo>, List<ArchiveColumnInfo>)`

#### SuperOffice.CRM.FunctionRightStrings is Modified

* Deleted items
  * Field `HideReporter`

#### SuperOffice.CRM.Services.RecurrenceDayPattern is Modified

* New items
  * Method `Equals(RecurrenceDayPattern)`

#### SuperOffice.CRM.Services.RecurrenceInfo is Modified

* New items
  * Method `Equals(RecurrenceInfo)`

#### SuperOffice.CRM.Services.RecurrenceMonthPattern is Modified

* New items
  * Method `Equals(RecurrenceMonthPattern)`

#### SuperOffice.CRM.Services.RecurrenceWeekOfMonthPattern is Modified

* New items
  * Method `Equals(RecurrenceWeekOfMonthPattern)`

#### SuperOffice.CRM.Services.RecurrenceWeekPattern is Modified

* New items
  * Method `Equals(RecurrenceWeekPattern)`

#### SuperOffice.CRM.Services.RecurrenceYearPattern is Modified

* New items
  * Method `Equals(RecurrenceYearPattern)`

#### SuperOffice.Data.ConfigType is Modified

* New items
  * Field `SubscriptionsOptions`
  * Field `SubscriptionsStyle`

#### SuperOffice.Data.TicketLogAction is Modified

* New items
  * Field `Ticket_Relation`

#### SuperOffice.Data.TicketLogFieldChange is Modified

* New items
  * Field `Relation_Child`
  * Field `Relation_Parent`
  * Field `Relation_Related`

#### SuperOffice.Exceptions.SoHttpResponseException is Modified

* Deleted items
  * Method `SoHttpResponseException(HttpResponseMessage)`
* New items
  * Property `FriendlyMessage`
  * Method `SoHttpResponseException(HttpResponseMessage, String)`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_COPILOT_ADD_SOURCE`
  * Field `SR_ADMIN_COPILOT_BAD_RESULTS`
  * Field `SR_ADMIN_COPILOT_CRAWLER_DESC`
  * Field `SR_ADMIN_COPILOT_CRAWLER_MODE`
  * Field `SR_ADMIN_COPILOT_DELETE_SELECTED_SOURCE`
  * Field `SR_ADMIN_COPILOT_DELETE_SOURCE`
  * Field `SR_ADMIN_COPILOT_INDEX_ALL_DIR`
  * Field `SR_ADMIN_COPILOT_INDEX_CANCEL`
  * Field `SR_ADMIN_COPILOT_INDEX_NOW`
  * Field `SR_ADMIN_COPILOT_INDEXING_CANCELLED`
  * Field `SR_ADMIN_COPILOT_INDEXING_COMPLETED`
  * Field `SR_ADMIN_COPILOT_INDEXING_PROGRESS`
  * Field `SR_ADMIN_COPILOT_LAST_INDEXED`
  * Field `SR_ADMIN_COPILOT_LONG_TIME`
  * Field `SR_ADMIN_COPILOT_LONG_TIME_LATER`
  * Field `SR_ADMIN_COPILOT_NO_SOURCES_INDEXED`
  * Field `SR_ADMIN_COPILOT_SAMPLE_DATA`
  * Field `SR_ADMIN_COPILOT_SELECTION_DOCUMENTS`
  * Field `SR_ADMIN_COPILOT_SELECTION_REQUESTS`
  * Field `SR_ADMIN_COPILOT_SINGLE_PAGE`
  * Field `SR_ADMIN_COPILOT_SINGLE_PAGE_DESC`
  * Field `SR_ADMIN_COPILOT_SOURCE_NAME`
  * Field `SR_ADMIN_COPILOT_SOURCES_COMPLETED`
  * Field `SR_ADMIN_COPILOT_START_INDEX`
  * Field `SR_ADMIN_COPILOT_STARTED_INDEXING`
  * Field `SR_ADMIN_COPILOT_STARTING_URL`
  * Field `SR_ADMIN_COPILOT_USE_FAQ`
  * Field `SR_ADMIN_COPILOT_USE_RT`
  * Field `SR_ADMIN_COPILOT_USE_WEBSITES`
  * Field `SR_ADMIN_COPILOT_WEB_CONTENT`
  * Field `SR_ARCHIVE_STARTDATE`
  * Field `SR_ARCHIVE_STARTDATE_TOOLTIP`
  * Field `SR_DOCUMENT_DOWNLOAD_WEBTOOLS`
  * Field `SR_DOCUMENT_WEBTOOLS_TITLE`
  * Field `SR_FIELD_PROJECT_EVENT_ID`
  * Field `SR_FIELD_PROJECT_MEMBER_EVENT_STATUS`
  * Field `SR_FORMS_AI_BTN`
  * Field `SR_FORMS_AI_EXTRACT`
  * Field `SR_FORMS_AI_PREVIEW`
  * Field `SR_FORMS_ALLOW_OVERWRITE`
  * Field `SR_FORMS_FIELD_COMPANYBUSINESS`
  * Field `SR_FORMS_FIELD_COMPANYCODE`
  * Field `SR_FORMS_FIELD_COMPANYDEPARTMENT`
  * Field `SR_FORMS_FIELD_COMPANYINTERESTS`
  * Field `SR_FORMS_FIELD_CONTACTBIRTHDAY`
  * Field `SR_FORMS_FIELD_CONTACTBUSINESS`
  * Field `SR_FORMS_FIELD_CONTACTINTERESTS`
  * Field `SR_FORMS_FIELD_CONTACTLANGUAGE`
  * Field `SR_FORMS_OVERWRITE_WARNING`
  * Field `SR_ONBOARDING_DOCUMENT_TEXT_MARKDOWN`
  * Field `SR_ONBOARDING_DOWNLOAD_WEBTOOLS_BUTTON_LABEL`
  * Field `SR_PROJECT_MEMBER_EVENT_STATUS_NO_SHOW`
  * Field `SR_PROJECT_MEMBER_EVENT_STATUS_NOT_AN_EVENT`
  * Field `SR_PROJECT_MEMBER_EVENT_STATUS_NOT_REACTED`
  * Field `SR_PROJECT_MEMBER_EVENT_STATUS_REACTED_NO`
  * Field `SR_PROJECT_MEMBER_EVENT_STATUS_REACTED_YES`
  * Field `SR_PROJECT_MEMBER_EVENT_STATUS_SHOW`
  * Field `SR_SCM_RESET`
  * Field `SR_SCM_RESET_BUTT`
  * Field `SR_SCM_RESET_TOOLTIP`
  * Field `SR_SMC_BUTTON`
  * Field `SR_SMC_CHECKBOX_TEXT`
  * Field `SR_SMC_CONFIG`
  * Field `SR_SMC_INTRO`
  * Field `SR_SMC_LABEL`
  * Field `SR_SMC_LANGUAGES`
  * Field `SR_SMC_LINK`
  * Field `SR_SMC_OPTIONS`
  * Field `SR_SMC_OPTIONS_HEADER`
  * Field `SR_SMC_OPTIONS_INSTRUCTIONS`
  * Field `SR_SMC_PADDING`
  * Field `SR_SMC_POSITION`
  * Field `SR_SMC_SWITCH_COLOR`
  * Field `SR_TICKET_CANNOT_CLOSE_DIALOG_CAPTION`
  * Field `SR_TICKET_CANNOT_CLOSE_DIALOG_MESSAGE`
  * Field `SR_TICKET_HOW_MUCH_MORE`
  * Field `SR_TICKET_LOG_ACTION_RELATION`
  * Field `SR_TICKET_OFFER_CLOSE_DIALOG_CAPTION`
  * Field `SR_TICKET_OFFER_CLOSE_DIALOG_MESSAGE`
  * Field `SR_TICKET_OFFER_CLOSE_DIALOG_OK_CAPTION`
  * Field `SR_TICKET_OFFER_CLOSE_PARENT_DIALOG_CAPTION`
  * Field `SR_TICKET_OFFER_CLOSE_PARENT_DIALOG_MESSAGE`
  * Field `SR_TICKET_RELATION_CHILD_REQUESTS`
  * Field `SR_TICKET_RELATION_NODE_TOOLTIP`
  * Field `SR_TICKET_RELATION_RELATED_REQUESTS`
  * Field `SR_TICKET_RELATION_THIS_REQUEST`
  * Field `SR_TICKET_RELATION_THIS_REQUEST_EXPLANATION`
  * Field `SR_TICKET_RELATION_TREE_VIEW`

#### SuperOffice.License.SoLicenseNames is Modified

* New items
  * Field `AdminRole`
  * Field `AiCopilot`
  * Field `AiNLQ`
  * Field `AiServiceCopilot`
  * Field `AiSummarize`
  * Field `AiTranslate`
  * Field `BizCard`
  * Field `BookMyCalendar`
  * Field `CrmScript`
  * Field `DatabridgePro`
  * Field `EnrichCont`
  * Field `ErpConnect`
  * Field `FreeConfigScreens`
  * Field `FreeCustomObjects`
  * Field `FreeReplicationServer`
  * Field `FreeScim`
  * Field `GuideProject`
  * Field `GuideSale`
  * Field `LabelSubst`
  * Field `LeadMgt`
  * Field `Mailchimp`
  * Field `MobileRequest`
  * Field `MsTeams`
  * Field `MsTeamsChat`
  * Field `QuoteApproval`
  * Field `SmartFilter`
  * Field `Synchronizer`
  * Field `TicketLog`
  * Field `TicketType`
  * Field `UniSearch`

#### SuperOffice.Security.Principal.AsyncLocalPrincipalAccessor is Modified

* Deleted items
  * Property `User`
* New items
  * Property `InnerUser`

#### SuperOffice.Security.Principal.IUserInfoService is Modified

* New items
  * Method `Flush()`

#### SuperOffice.Security.Principal.NSPrincipalAccessorBase is Modified

* New items
  * Property `InnerUser`

#### SuperOffice.Security.Principal.ProcessPrincipalAccessor is Modified

* Deleted items
  * Property `User`
* New items
  * Property `InnerUser`

#### SuperOffice.Security.Principal.SoClaimsPrincipal is Modified

* Deleted items
  * Method `SoClaimsPrincipal(IUserInfoService, NSIdentityClaimValues)`
  * Method `SoClaimsPrincipal(IUserInfoService, ClaimsIdentity)`
* New items
  * Method `SoClaimsPrincipal(IUserInfoService, IPrincipalStateAccessor, NSIdentityClaimValues)`
  * Method `SoClaimsPrincipal(IUserInfoService, IPrincipalStateAccessor, ClaimsIdentity)`
  * Method `ResetIfExpired()`

#### SuperOffice.Security.Util.DocumentArchiveFileImpersonationContext is Modified

* Deleted items
  * Method `Execute(Func<Task>)`


### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.Data.Obsolete1TableInfo`
* `SuperOffice.CRM.Data.Obsolete2TableInfo`
* `SuperOffice.CRM.Data.Obsolete3TableInfo`
* `SuperOffice.CRM.Data.Obsolete4TableInfo`
* `SuperOffice.CRM.Data.OLEFieldTableInfo`
* `SuperOffice.CRM.Data.OLEFieldTextTableInfo`
* `SuperOffice.CRM.Data.OLESubjectTableInfo`
* `SuperOffice.CRM.Data.OLESubjectTextTableInfo`
* `SuperOffice.CRM.Data.OLEViewTableInfo`
* `SuperOffice.CRM.Data.OLEViewTextTableInfo`
* `SuperOffice.CRM.Data.ReporterListDefTableInfo`
* `SuperOffice.CRM.Data.SORCriteriaTableInfo`
* `SuperOffice.CRM.Data.SORFCTTableInfo`
* `SuperOffice.CRM.Data.SORFieldTableInfo`
* `SuperOffice.CRM.Data.SOROperatorsTableInfo`
* `SuperOffice.CRM.Data.SORPublishGroupLinkTableInfo`
* `SuperOffice.CRM.Data.SORPublishTableInfo`
* `SuperOffice.CRM.Data.SORSectionTableInfo`
* `SuperOffice.CRM.Data.SORTemplateTableInfo`
* `SuperOffice.CRM.Rows.Obsolete1RecordData`
* `SuperOffice.CRM.Rows.Obsolete1RecordDataExtensions`
* `SuperOffice.CRM.Rows.Obsolete1Row`
* `SuperOffice.CRM.Rows.Obsolete1Rows`
* `SuperOffice.CRM.Rows.Obsolete2RecordData`
* `SuperOffice.CRM.Rows.Obsolete2RecordDataExtensions`
* `SuperOffice.CRM.Rows.Obsolete2Row`
* `SuperOffice.CRM.Rows.Obsolete2Rows`
* `SuperOffice.CRM.Rows.Obsolete3RecordData`
* `SuperOffice.CRM.Rows.Obsolete3RecordDataExtensions`
* `SuperOffice.CRM.Rows.Obsolete3Row`
* `SuperOffice.CRM.Rows.Obsolete3Rows`
* `SuperOffice.CRM.Rows.Obsolete4RecordData`
* `SuperOffice.CRM.Rows.Obsolete4RecordDataExtensions`
* `SuperOffice.CRM.Rows.Obsolete4Row`
* `SuperOffice.CRM.Rows.Obsolete4Rows`
* `SuperOffice.CRM.Rows.OLEFieldRecordData`
* `SuperOffice.CRM.Rows.OLEFieldRecordDataExtensions`
* `SuperOffice.CRM.Rows.OLEFieldRow`
* `SuperOffice.CRM.Rows.OLEFieldRows`
* `SuperOffice.CRM.Rows.OLEFieldTextRecordData`
* `SuperOffice.CRM.Rows.OLEFieldTextRecordDataExtensions`
* `SuperOffice.CRM.Rows.OLEFieldTextRow`
* `SuperOffice.CRM.Rows.OLEFieldTextRows`
* `SuperOffice.CRM.Rows.OLESubjectRecordData`
* `SuperOffice.CRM.Rows.OLESubjectRecordDataExtensions`
* `SuperOffice.CRM.Rows.OLESubjectRow`
* `SuperOffice.CRM.Rows.OLESubjectRows`
* `SuperOffice.CRM.Rows.OLESubjectTextRecordData`
* `SuperOffice.CRM.Rows.OLESubjectTextRecordDataExtensions`
* `SuperOffice.CRM.Rows.OLESubjectTextRow`
* `SuperOffice.CRM.Rows.OLESubjectTextRows`
* `SuperOffice.CRM.Rows.OLEViewRecordData`
* `SuperOffice.CRM.Rows.OLEViewRecordDataExtensions`
* `SuperOffice.CRM.Rows.OLEViewRow`
* `SuperOffice.CRM.Rows.OLEViewRows`
* `SuperOffice.CRM.Rows.OLEViewTextRecordData`
* `SuperOffice.CRM.Rows.OLEViewTextRecordDataExtensions`
* `SuperOffice.CRM.Rows.OLEViewTextRow`
* `SuperOffice.CRM.Rows.OLEViewTextRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete1RowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete1RowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete2RowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete2RowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete3RowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete3RowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete4RowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete4RowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEFieldRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEFieldRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEFieldTextRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEFieldTextRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateOLESubjectRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateOLESubjectRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateOLESubjectTextRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateOLESubjectTextRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEViewRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEViewRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEViewTextRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEViewTextRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateReporterListDefRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateReporterListDefRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORCriteriaRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORCriteriaRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORFCTRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORFCTRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORFieldRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORFieldRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSOROperatorsRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSOROperatorsRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORPublishGroupLinkRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORPublishGroupLinkRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORPublishRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORPublishRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORSectionRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORSectionRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORTemplateRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateSORTemplateRowsFactory`
* `SuperOffice.CRM.Rows.ReporterListDefRecordData`
* `SuperOffice.CRM.Rows.ReporterListDefRecordDataExtensions`
* `SuperOffice.CRM.Rows.ReporterListDefRow`
* `SuperOffice.CRM.Rows.ReporterListDefRows`
* `SuperOffice.CRM.Rows.SORCriteriaRecordData`
* `SuperOffice.CRM.Rows.SORCriteriaRecordDataExtensions`
* `SuperOffice.CRM.Rows.SORCriteriaRow`
* `SuperOffice.CRM.Rows.SORCriteriaRows`
* `SuperOffice.CRM.Rows.SORFCTRecordData`
* `SuperOffice.CRM.Rows.SORFCTRecordDataExtensions`
* `SuperOffice.CRM.Rows.SORFCTRow`
* `SuperOffice.CRM.Rows.SORFCTRows`
* `SuperOffice.CRM.Rows.SORFieldRecordData`
* `SuperOffice.CRM.Rows.SORFieldRecordDataExtensions`
* `SuperOffice.CRM.Rows.SORFieldRow`
* `SuperOffice.CRM.Rows.SORFieldRows`
* `SuperOffice.CRM.Rows.SOROperatorsRecordData`
* `SuperOffice.CRM.Rows.SOROperatorsRecordDataExtensions`
* `SuperOffice.CRM.Rows.SOROperatorsRow`
* `SuperOffice.CRM.Rows.SOROperatorsRows`
* `SuperOffice.CRM.Rows.SORPublishGroupLinkRecordData`
* `SuperOffice.CRM.Rows.SORPublishGroupLinkRecordDataExtensions`
* `SuperOffice.CRM.Rows.SORPublishGroupLinkRow`
* `SuperOffice.CRM.Rows.SORPublishGroupLinkRows`
* `SuperOffice.CRM.Rows.SORPublishRecordData`
* `SuperOffice.CRM.Rows.SORPublishRecordDataExtensions`
* `SuperOffice.CRM.Rows.SORPublishRow`
* `SuperOffice.CRM.Rows.SORPublishRows`
* `SuperOffice.CRM.Rows.SORSectionRecordData`
* `SuperOffice.CRM.Rows.SORSectionRecordDataExtensions`
* `SuperOffice.CRM.Rows.SORSectionRow`
* `SuperOffice.CRM.Rows.SORSectionRows`
* `SuperOffice.CRM.Rows.SORTemplateRecordData`
* `SuperOffice.CRM.Rows.SORTemplateRecordDataExtensions`
* `SuperOffice.CRM.Rows.SORTemplateRow`
* `SuperOffice.CRM.Rows.SORTemplateRows`
* `SuperOffice.CRM.Security.SORPublishSentry`
* `SuperOffice.CRM.Security.SORPublishSentryQueryInfo`
* `SuperOffice.Data.SQL.DatePart`
* `SuperOffice.Products.NetServerDataBase`

### New Types

* `SuperOffice.CRM.Ticket.MainTicketInfo`
* `SuperOffice.CRM.Ticket.RelatedTicketInfo`
* `SuperOffice.CRM.Ticket.TicketRelationDefInfo`
* `SuperOffice.CRM.Ticket.TicketRelationtData`
* `SuperOffice.Data.SQL.DateDiff`
* `SuperOffice.Data.SQL.DateTimeArgumentFunction`
* `SuperOffice.Data.SQL.ProjectMemberEventParticipantStatusFieldInfo`

### Modified Types

#### SuperOffice.CRM.Archives.ProjectMemberListItem is Modified

* New items
  * Property `EventParticipantStatus`

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* Deleted items
  * Property `LeftOuterJoin_OLEField_RegisteredAssociateId`
  * Property `LeftOuterJoin_OLEField_UpdatedAssociateId`
  * Property `LeftOuterJoin_OLEFieldText_RegisteredAssociateId`
  * Property `LeftOuterJoin_OLEFieldText_UpdatedAssociateId`
  * Property `LeftOuterJoin_OLESubject_RegisteredAssociateId`
  * Property `LeftOuterJoin_OLESubject_UpdatedAssociateId`
  * Property `LeftOuterJoin_OLESubjectText_RegisteredAssociateId`
  * Property `LeftOuterJoin_OLESubjectText_UpdatedAssociateId`
  * Property `LeftOuterJoin_OLEView_RegisteredAssociateId`
  * Property `LeftOuterJoin_OLEView_UpdatedAssociateId`
  * Property `LeftOuterJoin_OLEViewText_RegisteredAssociateId`
  * Property `LeftOuterJoin_OLEViewText_UpdatedAssociateId`
  * Property `LeftOuterJoin_ReporterListDef_RegisteredAssociateId`
  * Property `LeftOuterJoin_ReporterListDef_UpdatedAssociateId`
  * Property `LeftOuterJoin_SORCriteria_RegisteredAssociateId`
  * Property `LeftOuterJoin_SORCriteria_UpdatedAssociateId`
  * Property `LeftOuterJoin_SORFCT_RegisteredAssociateId`
  * Property `LeftOuterJoin_SORFCT_UpdatedAssociateId`
  * Property `LeftOuterJoin_SORField_RegisteredAssociateId`
  * Property `LeftOuterJoin_SORField_UpdatedAssociateId`
  * Property `LeftOuterJoin_SOROperators_RegisteredAssociateId`
  * Property `LeftOuterJoin_SOROperators_UpdatedAssociateId`
  * Property `LeftOuterJoin_SORPublish_AssociateId`
  * Property `LeftOuterJoin_SORPublish_RegisteredAssociateId`
  * Property `LeftOuterJoin_SORPublish_UpdatedAssociateId`
  * Property `LeftOuterJoin_SORPublishGroupLink_RegisteredAssociateId`
  * Property `LeftOuterJoin_SORPublishGroupLink_UpdatedAssociateId`
  * Property `LeftOuterJoin_SORSection_RegisteredAssociateId`
  * Property `LeftOuterJoin_SORSection_UpdatedAssociateId`
  * Property `LeftOuterJoin_SORTemplate_RegisteredAssociateId`
  * Property `LeftOuterJoin_SORTemplate_UpdatedAssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* Deleted items
  * Field `Obsolete1`
  * Field `Obsolete2`
  * Field `Obsolete3`
  * Field `Obsolete4`
  * Field `OLEField`
  * Field `OLEFieldText`
  * Field `OLESubject`
  * Field `OLESubjectText`
  * Field `OLEView`
  * Field `OLEViewText`
  * Field `ReporterListDef`
  * Field `SORCriteria`
  * Field `SORFCT`
  * Field `SORField`
  * Field `SOROperators`
  * Field `SORPublish`
  * Field `SORPublishGroupLink`
  * Field `SORSection`
  * Field `SORTemplate`

##### SuperOffice.CRM.Data.DBC.Obsolete1Fields is Deleted

##### SuperOffice.CRM.Data.DBC.Obsolete2Fields is Deleted

##### SuperOffice.CRM.Data.DBC.Obsolete3Fields is Deleted

##### SuperOffice.CRM.Data.DBC.Obsolete4Fields is Deleted

##### SuperOffice.CRM.Data.DBC.OLEFieldFields is Deleted

##### SuperOffice.CRM.Data.DBC.OLEFieldTextFields is Deleted

##### SuperOffice.CRM.Data.DBC.OLESubjectFields is Deleted

##### SuperOffice.CRM.Data.DBC.OLESubjectTextFields is Deleted

##### SuperOffice.CRM.Data.DBC.OLEViewFields is Deleted

##### SuperOffice.CRM.Data.DBC.OLEViewTextFields is Deleted

##### SuperOffice.CRM.Data.DBC.ReporterListDefFields is Deleted

##### SuperOffice.CRM.Data.DBC.SORCriteriaFields is Deleted

##### SuperOffice.CRM.Data.DBC.SORFCTFields is Deleted

##### SuperOffice.CRM.Data.DBC.SORFieldFields is Deleted

##### SuperOffice.CRM.Data.DBC.SOROperatorsFields is Deleted

##### SuperOffice.CRM.Data.DBC.SORPublishFields is Deleted

##### SuperOffice.CRM.Data.DBC.SORPublishGroupLinkFields is Deleted

##### SuperOffice.CRM.Data.DBC.SORSectionFields is Deleted

##### SuperOffice.CRM.Data.DBC.SORTemplateFields is Deleted
* Modified items

##### SuperOffice.CRM.Data.DBC.ProjectFields is Modified

* New items
  * Field `.ProjectFieldsEventId`
  * Field `.ProjectFieldsStartDate`


##### SuperOffice.CRM.Data.DBC.ProjectMemberFields is Modified

* New items
  * Field `.ProjectMemberFieldsEventParticipantStatus`


#### SuperOffice.CRM.Data.ProjectMemberTableInfo is Modified

* New items
  * Property `EventParticipantStatus`

#### SuperOffice.CRM.Data.ProjectTableInfo is Modified

* New items
  * Property `EventId`
  * Property `StartDate`

#### SuperOffice.CRM.Data.SORLabelLayoutTableInfo is Modified

* Deleted items
  * Property `LeftOuterJoin_SORPublish_DefaultLabelLayout`

#### SuperOffice.CRM.Data.UserGroupTableInfo is Modified

* Deleted items
  * Property `LeftOuterJoin_SORPublishGroupLink_UserGroupId`

#### SuperOffice.CRM.Documents.SoArc2 is Modified

* Modified items
  * Method `SaveDocumentFromStreamAsync(IDocumentInfo, String[], Stream, CancellationToken)`

#### SuperOffice.CRM.Entities.Contact is Modified

* New items
  * Method `GetUtmParametersAsync(CancellationToken)`

#### SuperOffice.CRM.Rows.ProjectMemberRecordData is Modified

* New items
  * Field `EventParticipantStatus`

#### SuperOffice.CRM.Rows.ProjectMemberRow is Modified

* New items
  * Property `EventParticipantStatus`
  * Event `OnEventParticipantStatusChange`

#### SuperOffice.CRM.Rows.ProjectMemberRows is Modified

* New items
  * Method `GetFromIdxProjectIdEventParticipantStatusAsync(Int32, ProjectMemberEventParticipantStatus, CancellationToken)`

##### SuperOffice.CRM.Rows.ProjectMemberRows.IdxProjectIdEventParticipantStatus is New

#### SuperOffice.CRM.Rows.ProjectRecordData is Modified

* New items
  * Field `EventId`
  * Field `StartDate`

#### SuperOffice.CRM.Rows.ProjectRow is Modified

* New items
  * Property `EventId`
  * Property `StartDate`
  * Event `OnEventIdChange`
  * Event `OnStartDateChange`

#### SuperOffice.CRM.Rows.RowDefaulter is Modified

* Deleted items
  * Method `SetDefaultsAsync(SORLabelLayoutRow, DefaulterStrategy, CancellationToken)`
* New items
  * Method `SetDefaultsAsync(DiaryViewRow, DefaulterStrategy, CancellationToken)`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(ProjectMemberEventParticipantStatus&, FieldInfo)`

#### SuperOffice.CRM.Ticket.TicketChangeData is Modified

* New items
  * Property `TicketTypeId`

#### SuperOffice.CRM.Ticket.TicketRelationHelper is Modified

* New items
  * Method `GetChildTicketIdsToCloseAsync(Int32, CancellationToken)`
  * Method `GetParentRelationInfo(Int32, CancellationToken)`
  * Method `GetTicketRelationDataAsync(Int32, CancellationToken)`
  * Method `GetTicketRelationDefId(Int32, Int32, TicketRelationType, CancellationToken)`
  * Method `GetTicketRelationsInfoAsync(Int32, Int32, Int32, Int32, CancellationToken)`
  * Method `InverseRelation(TicketRelationType)`
  * Method `ResolveParentId(Int32, ValueTuple<Int32, Int32, Int32>)`
  * Method `UpdateTicketRelationDefIdForTicketRelationAsync(Int32)`

#### SuperOffice.Data.Cache.CacheBaseV2 is Modified

* New items
  * Method `OnDispose()`

#### SuperOffice.Data.Dialect.Dialect is Modified

* New items
  * Method `ToSql(DateDiff)`

#### SuperOffice.Data.Private.TicketLogging.TicketLoggerProcessor is Modified

* Modified items

##### SuperOffice.Data.Private.TicketLogging.TicketLoggerProcessor.QueryData is Modified

* New items
  * Property `.QueryDataIsRelationLog`


#### SuperOffice.Data.S is Modified

* Modified items

##### SuperOffice.Data.S.ArgumentFunctions is Modified

* Deleted items
  * Method `.ArgumentFunctionsDateAdd(DatePart, Argument, Argument)`
* New items
  * Method `.ArgumentFunctionsDateAdd(DatePart, Argument, Argument)`
  * Method `.ArgumentFunctionsDateDiff(DatePart, Argument, Argument)`


#### SuperOffice.Data.SQL.DateAdd is Modified

* Deleted items
  * Method `DateAdd(DatePart, Argument, Argument)`
  * Method `DatePartToString(DatePart)`
* Modified items
  * Property `Part`
* New items
  * Method `DateAdd(DatePart, Argument, Argument)`
  * Method `DatePartToString(DatePart)`

##### SuperOffice.Data.SQL.DateAdd.DatePart is New

#### SuperOffice.Data.TablesInfo is Modified

* Deleted items
  * Method `GetObsolete1TableInfo()`
  * Method `GetObsolete2TableInfo()`
  * Method `GetObsolete3TableInfo()`
  * Method `GetObsolete4TableInfo()`
  * Method `GetOLEFieldTableInfo()`
  * Method `GetOLEFieldTextTableInfo()`
  * Method `GetOLESubjectTableInfo()`
  * Method `GetOLESubjectTextTableInfo()`
  * Method `GetOLEViewTableInfo()`
  * Method `GetOLEViewTextTableInfo()`
  * Method `GetReporterListDefTableInfo()`
  * Method `GetSORCriteriaTableInfo()`
  * Method `GetSORFCTTableInfo()`
  * Method `GetSORFieldTableInfo()`
  * Method `GetSOROperatorsTableInfo()`
  * Method `GetSORPublishGroupLinkTableInfo()`
  * Method `GetSORPublishTableInfo()`
  * Method `GetSORSectionTableInfo()`
  * Method `GetSORTemplateTableInfo()`


### Assembly: SoDatabase.BusinessLogic

### Deleted Types

* `SuperOffice.CRM.ArchiveLists.AppointmentAcceptedNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.AppointmentAcceptedNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.AppointmentCancelledNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.AppointmentCancelledNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.AppointmentNewNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.AppointmentNewNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.AppointmentNotificationSubAggregatorProvider`
* `SuperOffice.CRM.ArchiveLists.AppointmentNotificationSubExtenderBase`
* `SuperOffice.CRM.ArchiveLists.AppointmentRejectedNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.AppointmentRejectedNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.AppointmentUpdatedNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.AppointmentUpdatedNotificationSubProvider`

### New Types

* `SuperOffice.CRM.Lists.ContIntProvider`
* `SuperOffice.CRM.Lists.PersIntProvider`
* `SuperOffice.CRM.Lists.ProjectMemberEventParticipantStatusProvider`
* `SuperOffice.Security.Principal.PrincipalCacheInvalidator`
* `SuperOffice.Security.Principal.PrincipalStatePostAuthenticationPlugin`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.Archive.Combinator is Modified


#### SuperOffice.CRM.ArchiveLists.ProjectExtenderBase is Modified


#### SuperOffice.CRM.ArchiveLists.ProjectMemberExtenderBase is Modified


#### SuperOffice.CRM.ArchiveLists.RelatedTicketsProvider is Modified

* New items
  * Method `PostProcessQuery()`

#### SuperOffice.CRM.Entities.RecurrenceManager is Modified

* New items
  * Property `HasRecurrenceChangedDuringSave`
  * Method `OnDoByChange(DateTime)`

#### SuperOffice.CRM.Webhooks.CrmScriptWebhookPlugin is Modified

* Deleted items
  * Method `CrmScriptWebhookPlugin()`
* New items
  * Method `CrmScriptWebhookPlugin(ILogger<CrmScriptWebhookPlugin>)`

#### SuperOffice.CRM.Webhooks.DefaultWebhookPlugin is Modified

* Deleted items
  * Method `UpdateWebhookStateAsync(Int32, WebhookState, CancellationToken)`
* New items
  * Method `UpdateWebhookStateAsync(Boolean, Webhook, WebhookUsageRecordData, CancellationToken)`

#### SuperOffice.Data.Dialect.OracleCommon is Modified

* New items
  * Method `ToSql(DateDiff)`

#### SuperOffice.Data.Dialect.PostgreSqlDialect is Modified

* New items
  * Method `ToSql(DateDiff)`

#### SuperOffice.Util.CalendarUtility is Modified

* Deleted items
  * Method `CalendarUtility()`
* New items
  * Method `CalendarUtility(ILogger<CalendarUtility>)`

#### SuperOffice.Util.RagAIHelper is Modified

* New items
  * Method `GetFormsDesignCssFromImage(Stream, String[], CancellationToken)`
  * Method `GetFormsDesignCssFromUrl(String, String[], CancellationToken)`


### Assembly: SuperOffice.Plugins

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### Deleted Types

* `SuperOffice.CD.DSL.Database.ConfigType`
* `SuperOffice.CD.DSL.Database.T_Obsolete1`
* `SuperOffice.CD.DSL.Database.T_Obsolete2`
* `SuperOffice.CD.DSL.Database.T_Obsolete3`
* `SuperOffice.CD.DSL.Database.T_Obsolete4`
* `SuperOffice.CD.DSL.Database.T_OLEField`
* `SuperOffice.CD.DSL.Database.T_OLEFieldText`
* `SuperOffice.CD.DSL.Database.T_OLESubject`
* `SuperOffice.CD.DSL.Database.T_OLESubjectText`
* `SuperOffice.CD.DSL.Database.T_OLEView`
* `SuperOffice.CD.DSL.Database.T_OLEViewText`
* `SuperOffice.CD.DSL.Database.T_ReporterListDef`
* `SuperOffice.CD.DSL.Database.T_SORCriteria`
* `SuperOffice.CD.DSL.Database.T_SORFCT`
* `SuperOffice.CD.DSL.Database.T_SORField`
* `SuperOffice.CD.DSL.Database.T_SOROperators`
* `SuperOffice.CD.DSL.Database.T_SORPublish`
* `SuperOffice.CD.DSL.Database.T_SORPublishGroupLink`
* `SuperOffice.CD.DSL.Database.T_SORSection`
* `SuperOffice.CD.DSL.Database.T_SORTemplate`

### New Types

* `SuperOffice.CD.Database.ConfigType`

### Modified Types

#### SuperOffice.CD.Database.LicenseStatus is Modified

* New items
  * Field `NewLicenseActivated`

#### SuperOffice.CD.Database.TicketLogAction is Modified

* New items
  * Field `Ticket_Relation`

#### SuperOffice.CD.Database.TicketLogFieldChange is Modified

* New items
  * Field `Relation_Child`
  * Field `Relation_Parent`
  * Field `Relation_Related`

#### SuperOffice.CD.DSL.Database.T_Project is Modified

* New items
  * Field `EventId`
  * Field `StartDate`

#### SuperOffice.CD.DSL.Database.T_ProjectMember is Modified

* New items
  * Field `EventParticipantStatus`



