---
uid: version_11.11.589.0_changes
date: 13.03.2026
---

Changes from v11.10.705 and v11.11.589.0

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.FormDesignCss`
* `SuperOffice.CRM.Services.FormFieldRestriction`
* `SuperOffice.CRM.Services.IMessagingAgent`
* `SuperOffice.CRM.Services.IncomingMessage`
* `SuperOffice.CRM.Services.MessageDeliveryStatus`
* `SuperOffice.CRM.Services.OutgoingMessage`
* `SuperOffice.CRM.Services.ProviderInfo`

### Modified Types

#### SuperOffice.CRM.Services.IAIAgent is Modified

* New items
  * Method `GetFirstFormDesignCssFromImageAsync(Stream, String, CancellationToken)`
  * Method `GetFirstFormDesignCssFromUrlAsync(String, String, CancellationToken)`
  * Method `GetNextFormDesignCssAsync(String, String, CancellationToken)`

#### SuperOffice.CRM.Services.IMarketingAgent is Modified

* New items
  * Method `SetAllFormFieldRestrictionsAsync(FormFieldRestriction[], CancellationToken)`

#### SuperOffice.CRM.Services.IProjectAgent is Modified

* New items
  * Method `GetProjectEntityWithoutMembersAsync(Int32, CancellationToken)`
  * Method `SaveProjectEntityWithoutMembersAsync(ProjectEntity, CancellationToken)`


### Assembly: SuperOffice.Services.Implementation

### New Types

* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IFormDesignCssImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IFormFieldRestrictionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IIncomingMessageImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IMessageDeliveryStatusImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IOutgoingMessageImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProviderInfoImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.FormDesignCssImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.FormFieldRestrictionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.IncomingMessageImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.MessageDeliveryStatusImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.OutgoingMessageImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.ProviderInfoImplementation`
* `SuperOffice.CRM.Services.Implementation.Util.IListDefinitionCache`
* `SuperOffice.CRM.Services.Implementation.Util.ListDefinitionCache`
* `SuperOffice.CRM.Services.MessagingAgent`

### Modified Types

#### SuperOffice.CRM.Services.AIAgent is Modified

* Deleted items
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ICopilotDataSourceEntityImplementation, ICopilotEntityImplementation, IFormDesignCarrierImplementation, ISentimentImplementation, INaturalLanguageSearchImplementation, ICreatePhotoBackgroundImplementation, IRagAnswerImplementation, IRagResultImplementation, IRagStatusImplementation, ISummarizerImplementation, ISoRequestItemsAccessor)`
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ICopilotDataSourceEntityImplementation, ICopilotEntityImplementation, IFormDesignCarrierImplementation, ISentimentImplementation, INaturalLanguageSearchImplementation, ICreatePhotoBackgroundImplementation, IRagAnswerImplementation, IRagResultImplementation, IRagStatusImplementation, ISummarizerImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ICopilotDataSourceEntityImplementation, ICopilotEntityImplementation, IFormDesignCarrierImplementation, IFormDesignCssImplementation, ISentimentImplementation, INaturalLanguageSearchImplementation, ICreatePhotoBackgroundImplementation, IRagAnswerImplementation, IRagResultImplementation, IRagStatusImplementation, ISummarizerImplementation, ISoRequestItemsAccessor)`
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ICopilotDataSourceEntityImplementation, ICopilotEntityImplementation, IFormDesignCarrierImplementation, IFormDesignCssImplementation, ISentimentImplementation, INaturalLanguageSearchImplementation, ICreatePhotoBackgroundImplementation, IRagAnswerImplementation, IRagResultImplementation, IRagStatusImplementation, ISummarizerImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `GetFirstFormDesignCssFromImageAsync(Stream, String, CancellationToken)`
  * Method `GetFirstFormDesignCssFromUrlAsync(String, String, CancellationToken)`
  * Method `GetNextFormDesignCssAsync(String, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectEntityImplementation is Modified

* New items
  * Method `GetProjectEntityWithoutMembersAsync(Int32, CancellationToken)`
  * Method `SaveProjectEntityWithoutMembersAsync(ProjectEntity, CancellationToken)`

#### SuperOffice.CRM.Services.MarketingAgent is Modified

* Deleted items
  * Method `MarketingAgent(IAvailableFontImplementation, IFormEntityImplementation, IFormSubmissionEntityImplementation, IMailingStatisticsImplementation, IPreviewMailingImplementation, IPreviewMailingHeaderImplementation, IShipmentMessageBlockEntityImplementation, IShipmentMessageEntityImplementation, ISoRequestItemsAccessor)`
  * Method `MarketingAgent(IAvailableFontImplementation, IFormEntityImplementation, IFormSubmissionEntityImplementation, IMailingStatisticsImplementation, IPreviewMailingImplementation, IPreviewMailingHeaderImplementation, IShipmentMessageBlockEntityImplementation, IShipmentMessageEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `MarketingAgent(IAvailableFontImplementation, IFormEntityImplementation, IFormFieldRestrictionImplementation, IFormSubmissionEntityImplementation, IMailingStatisticsImplementation, IPreviewMailingImplementation, IPreviewMailingHeaderImplementation, IShipmentMessageBlockEntityImplementation, IShipmentMessageEntityImplementation, ISoRequestItemsAccessor)`
  * Method `MarketingAgent(IAvailableFontImplementation, IFormEntityImplementation, IFormFieldRestrictionImplementation, IFormSubmissionEntityImplementation, IMailingStatisticsImplementation, IPreviewMailingImplementation, IPreviewMailingHeaderImplementation, IShipmentMessageBlockEntityImplementation, IShipmentMessageEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `SetAllFormFieldRestrictionsAsync(FormFieldRestriction[], CancellationToken)`

#### SuperOffice.CRM.Services.ProjectAgent is Modified

* New items
  * Method `GetProjectEntityWithoutMembersAsync(Int32, CancellationToken)`
  * Method `SaveProjectEntityWithoutMembersAsync(ProjectEntity, CancellationToken)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.Data.FormFieldRestrictionType`

### Modified Types

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.Data is Modified

* Modified items

##### .Data.Explicit is Modified

* Deleted items
  * Property `.ExplicitAnonymousAllowed`
  * Property `.ExplicitCommonDBConnection`



##### SuperOffice.Configuration.ConfigFile.IDataExplicitConfiguration is Modified

* Deleted items
  * Property `.IDataExplicitConfigurationAnonymousAllowed`
  * Property `.IDataExplicitConfigurationCommonDBConnection`


##### SuperOffice.Configuration.ConfigFile.TelemetryRoleName is Modified

* New items
  * Field `.TelemetryRoleNameWebApi`


#### SuperOffice.Configuration.VersionPropertyNames is Modified

* New items
  * Field `ForceSqlRecompile`
  * Field `SampleInAllRequests`

#### SuperOffice.Data.TicketOrigin is Modified

* New items
  * Field `API`
  * Field `Flow`

#### SuperOffice.Exceptions.SoLicenseException is Modified

* Modified items
  * Method `SoLicenseException(String, String, Boolean)`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_COPILOT_INSTRUCTIONS_EXAMPLE`
  * Field `SR_ADMIN_COPILOT_RETURN_POLICY`
  * Field `SR_ADMIN_COPILOT_ROLE`
  * Field `SR_ADMIN_COPILOT_ROLE_EXAMPLE`
  * Field `SR_ADMIN_COPILOT_SETTINGS_DESC`
  * Field `SR_ADMIN_COPILOT_SOURCES`
  * Field `SR_ADMIN_COPILOT_TEST`
  * Field `SR_ADMIN_COPILOT_TEST_ANSWER`
  * Field `SR_ADMIN_COPILOT_TEST_DESC`
  * Field `SR_ADMIN_COPILOT_TEST_RESULT`
  * Field `SR_ADMIN_COPILOT_TEST_SEARCH`
  * Field `SR_ADMIN_OAUTH_SETUP`
  * Field `SR_FORMFIELDS_LIST_HEADER`
  * Field `SR_FORMFIELDS_NAME`
  * Field `SR_FORMFIELDS_POLICY`
  * Field `SR_FORMFIELDS_RESTRICION_HIDE`
  * Field `SR_FORMFIELDS_RESTRICION_READONLY`
  * Field `SR_FORMS_ELEMENTS_FILTER`
  * Field `SR_ONBOARDING_BUTT_LATER`
  * Field `SR_ONBOARDING_DONE_EMAIL_UNCONNECTED`
  * Field `SR_ONBOARDING_DONE_GOOGLE`
  * Field `SR_ONBOARDING_DONE_SHAREPOINT`
  * Field `SR_ONBOARDING_DONE_WEBTOOLS_DISABLED`
  * Field `SR_ONBOARDING_DONE_WEBTOOLS_ENABLED`
  * Field `SR_ONBOARDING_EMAIL_MAILLINK_INFO`
  * Field `SR_SELECT_SINGLE_ITEM`
  * Field `SR_SMC_ALL_ADDED`
  * Field `SR_SMC_CANNOT_DELETE`
  * Field `SR_SMC_DEF_HEADING`
  * Field `SR_SMC_PREVIEW`
  * Field `SR_SMC_PREVIEW_CANCELLED`
  * Field `SR_SMC_PREVIEW_LINK_EXPIRED`
  * Field `SR_SMC_PREVIEW_MANAGE_ALL`
  * Field `SR_SMC_PREVIEW_MANAGE_ONE`
  * Field `SR_SMC_PREVIEW_SAVED`
  * Field `SR_SMC_PREVIEW_UNKNOWN_CUSTOMER`
  * Field `SR_SMC_TEXT`
  * Field `SR_TICKET_NUMBER_REQUESTS`
  * Field `SR_TICKET_OVERVIEW_RELATED_REQUESTS`
  * Field `SR_TICKET_RELATE_SEE_DETAILS`
  * Field `SR_TICKET_RELATED_REQUESTS`
  * Field `SR_TICKET_RELATED_SUCCESSFULLY`
  * Field `SR_TICKET_RELATION_CHILD_MULTIPLE`
  * Field `SR_TICKET_RELATION_CREATED`
  * Field `SR_TICKET_RELATION_LIST_VIEW`
  * Field `SR_TICKET_RELATION_OTHER_ERROR_REASON`
  * Field `SR_TICKET_RELATION_PARENT_ALREADY_SET`
  * Field `SR_TICKET_RELATION_TAB_DISABLED_TOOLTIP`
  * Field `SR_TICKETARCHIVE_CREATEDDATE`

#### SuperOffice.License.SoLicenseNames is Modified

* New items
  * Field `ActivityBoard`
  * Field `ContractManager`
  * Field `Map4You`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.Data.FormFieldRestrictionTableInfo`
* `SuperOffice.CRM.Rows.FormFieldRestrictionRecordData`
* `SuperOffice.CRM.Rows.FormFieldRestrictionRecordDataExtensions`
* `SuperOffice.CRM.Rows.FormFieldRestrictionRow`
* `SuperOffice.CRM.Rows.FormFieldRestrictionRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateFormFieldRestrictionRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateFormFieldRestrictionRowsFactory`
* `SuperOffice.Data.SQL.FormFieldRestrictionTypeFieldInfo`

### Modified Types

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_FormFieldRestriction_RegisteredAssociateId`
  * Property `LeftOuterJoin_FormFieldRestriction_UpdatedAssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* New items
  * Field `FormFieldRestriction`

##### SuperOffice.CRM.Data.DBC.FormFieldRestrictionFields is New

#### SuperOffice.CRM.Data.ProductVersionTableInfo is Modified

* Deleted items
  * Method `IdxOwnerName(String)`
  * Method `IdxOwnerNameCodeName(String, String)`

#### SuperOffice.CRM.Rows.ProductVersionRow is Modified

* Deleted items
  * Method `GetFromIdxOwnerNameCodeNameVersionAsync(String, String, String, CancellationToken)`

##### SuperOffice.CRM.Rows.ProductVersionRow.IdxOwnerNameCodeNameVersion is Deleted

#### SuperOffice.CRM.Rows.ProductVersionRows is Modified

* Deleted items
  * Method `GetFromIdxOwnerNameAsync(String, CancellationToken)`
  * Method `GetFromIdxOwnerNameCodeNameAsync(String, String, CancellationToken)`

##### SuperOffice.CRM.Rows.ProductVersionRows.IdxOwnerName is Deleted

##### SuperOffice.CRM.Rows.ProductVersionRows.IdxOwnerNameCodeName is Deleted

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(FormFieldRestrictionType&, FieldInfo)`

#### SuperOffice.CRM.Ticket.TicketChangeData is Modified

* New items
  * Property `NumReplies`
  * Property `Origin`
  * Property `Status`
  * Property `TimeToClose`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetFormFieldRestrictionTableInfo()`

#### SuperOffice.Util.TrackEventNames is Modified

* New items
  * Field `BootstrapperStart`
  * Field `EmailLogin`
  * Field `TicketClosed`
  * Field `TicketCreated`
  * Field `TicketRelationDeleted`


### Assembly: SoDatabase.BusinessLogic

### New Types

* `SuperOffice.CRM.Lists.FormFieldsProvider`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorExtender is Modified

* New items
  * Method `GetAppointmentStatusesOfDesiredEntities()`
  * Method `SetDesiredEntities(String[])`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorProvider is Modified

* New items
  * Method `SetDesiredEntities(String[])`

#### SuperOffice.CRM.ArchiveLists.EjscriptExtenderBase is Modified

* New items
  * Method `SetDesiredColumns(String[])`

#### SuperOffice.CRM.ArchiveLists.PersonProjectsExtender is Modified


#### SuperOffice.CRM.ArchiveLists.PersonProjectsFindExtender is Modified


#### SuperOffice.CRM.ArchiveLists.RestrictionStorageFactory is Modified

* Modified items
  * Method `GetMapping(String, String)`
  * Method `GetProvider(String)`
  * Method `GetProvider(String, String)`
  * Method `GetRestrictionFromAllGroupsViaStorage(ArchiveRestrictionInfo[], String, String, String, String)`
  * Method `GetRestrictionFromAllGroupsViaStorage(ArchiveRestrictionInfo[], String, String, String, String, String)`
  * Method `GetRestrictionViaStorage(ArchiveRestrictionInfo[], String, String, String, String)`
  * Method `GetRestrictionViaStorage(ArchiveRestrictionInfo[], String, String, String, String, String)`

#### SuperOffice.CRM.ArchiveLists.TicketExtenderBase is Modified


#### SuperOffice.Util.RagAIHelper is Modified

* Deleted items
  * Method `PutDocument(String, String, String, RagType, Dictionary<String, Object>)`
* New items
  * Method `CreateFormsDesignSessionFromImage(Stream, String, CancellationToken)`
  * Method `CreateFormsDesignSessionFromUrl(String, String, CancellationToken)`
  * Method `NextFormsDesignSessionCssRule(String, String, CancellationToken)`
  * Method `PutDocument(String, String, String, String, RagType, Dictionary<String, Object>)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.T_FormFieldRestriction`

### Modified Types

#### SuperOffice.CD.Database.TicketOrigin is Modified

* New items
  * Field `API`
  * Field `Flow`



