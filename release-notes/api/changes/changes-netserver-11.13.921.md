---
uid: version_11.13.921_changes
date: 29.04.2026
---

Changes from v11.12.675 and v11.13.921

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.RagContextIds`
* `SuperOffice.CRM.Services.TicketUsage`
* `SuperOffice.CRM.Services.XsrfValue`

### Modified Types

#### SuperOffice.CRM.Services.IAIAgent is Modified

* New items
  * Method `AnswerUsingContextAsync(String, String, RagContextIds, RagType, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.IContactAgent is Modified

* New items
  * Method `UpdateInterestsAsync(Int32, Int32[], Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.IDiagnosticsAgent is Modified

* New items
  * Method `RegisterClosedTicketsUsageAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.IPersonAgent is Modified

* New items
  * Method `UpdateInterestsAsync(Int32, Int32[], Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.IPreferenceAgent is Modified

* New items
  * Method `GetXsrfValueAsync(CancellationToken)`
  * Method `SetXsrfValueAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `SetSpamStatusByIdsAsync(Int32[], CancellationToken)`
  * Method `SetSpamStatusByProviderAsync(String, ArchiveRestrictionInfo[], CancellationToken)`

#### SuperOffice.CRM.Services.IUserAgent is Modified

* New items
  * Method `ExchangeCodeAndSaveTokensAsync(String, String, String, String, String, CancellationToken)`

#### SuperOffice.CRM.Services.TokenManagementInfo is Modified

* New items
  * Property `Claims`


### Assembly: SuperOffice.Services.Implementation

### New Types

* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketUsageImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.TicketUsageImplementation`
* `SuperOffice.CRM.Services.Implementation.Util.ConfigurationManagerCache`
* `SuperOffice.CRM.Services.Implementation.Util.ConfigurationManagerCacheExtensions`

### Modified Types

#### SuperOffice.CRM.Services.AIAgent is Modified

* New items
  * Method `AnswerUsingContextAsync(String, String, RagContextIds, RagType, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.ContactAgent is Modified

* New items
  * Method `UpdateInterestsAsync(Int32, Int32[], Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.DiagnosticsAgent is Modified

* Deleted items
  * Method `DiagnosticsAgent(IAnalyticsDataImplementation, ICacheImplementation, ICacheInvalidationImplementation, IEntityCountsImplementation, ILoggingImplementation, IUsageStatsImplementation, ISystemMessageListImplementation, ITableManagerImplementation, IInstallationImplementation, IWebAppUsageImplementation, ISoRequestItemsAccessor)`
  * Method `DiagnosticsAgent(IAnalyticsDataImplementation, ICacheImplementation, ICacheInvalidationImplementation, IEntityCountsImplementation, ILoggingImplementation, IUsageStatsImplementation, ISystemMessageListImplementation, ITableManagerImplementation, IInstallationImplementation, IWebAppUsageImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `DiagnosticsAgent(IAnalyticsDataImplementation, ICacheImplementation, ICacheInvalidationImplementation, IEntityCountsImplementation, ILoggingImplementation, IUsageStatsImplementation, ISystemMessageListImplementation, ITableManagerImplementation, IInstallationImplementation, ITicketUsageImplementation, IWebAppUsageImplementation, ISoRequestItemsAccessor)`
  * Method `DiagnosticsAgent(IAnalyticsDataImplementation, ICacheImplementation, ICacheInvalidationImplementation, IEntityCountsImplementation, ILoggingImplementation, IUsageStatsImplementation, ISystemMessageListImplementation, ITableManagerImplementation, IInstallationImplementation, ITicketUsageImplementation, IWebAppUsageImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `RegisterClosedTicketsUsageAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.AccessGatewayInfoImplementation is Modified

* Deleted items
  * Method `AccessGatewayInfoImplementation()`
* New items
  * Method `AccessGatewayInfoImplementation(ILogger<AccessGatewayInfoImplementation>, ConfigurationManagerCache, IHttpClientFactory, ITokenManagementInfoImplementation)`
  * Method `ExchangeCodeAndSaveTokensAsync(String, String, String, String, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IAccessGatewayInfoImplementation is Modified

* New items
  * Method `ExchangeCodeAndSaveTokensAsync(String, String, String, String, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IContactEntityImplementation is Modified

* New items
  * Method `UpdateInterestsAsync(Int32, Int32[], Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IPersonEntityImplementation is Modified

* New items
  * Method `UpdateInterestsAsync(Int32, Int32[], Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreferenceImplementation is Modified

* New items
  * Method `GetXsrfValueAsync(CancellationToken)`
  * Method `SetXsrfValueAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IRagAnswerImplementation is Modified

* New items
  * Method `AnswerUsingContextAsync(String, String, RagContextIds, RagType, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketEntityImplementation is Modified

* New items
  * Method `SetSpamStatusByIdsAsync(Int32[], CancellationToken)`
  * Method `SetSpamStatusByProviderAsync(String, ArchiveRestrictionInfo[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CustomObjectEntityImplementation is Modified

* Deleted items
  * Method `GetRelationsAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CustomObjectMetadata is Modified

* New items
  * Property `HasWebPanels`

#### SuperOffice.CRM.Services.Implementation.BL.RagAnswerImplementation is Modified

* New items
  * Method `AnswerUsingContextAsync(String, String, RagContextIds, RagType, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketEntityImplementation is Modified

* Deleted items
  * Method `TicketEntityImplementation(IAttachmentEntityImplementation, ITicketImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketStatusEntityImplementation, ITicketPriorityEntityImplementation, ITicketCategoryListImplementation, IPersonImplementation, IUserImplementation, IProjectImplementation, ISaleImplementation, ICacheManager, IBatchData, IPreferenceImplementation, IAssociateImplementation)`
* New items
  * Method `TicketEntityImplementation(IAttachmentEntityImplementation, ITicketImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketStatusEntityImplementation, ITicketPriorityEntityImplementation, ITicketCategoryListImplementation, IContactImplementation, IPersonImplementation, IUserImplementation, IProjectImplementation, ISaleImplementation, ICacheManager, IBatchData, IPreferenceImplementation, IAssociateImplementation)`
  * Method `SetSpamStatusByIdsAsync(Int32[], CancellationToken)`
  * Method `SetSpamStatusByProviderAsync(String, ArchiveRestrictionInfo[], CancellationToken)`

#### SuperOffice.CRM.Services.PersonAgent is Modified

* New items
  * Method `UpdateInterestsAsync(Int32, Int32[], Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.PreferenceAgent is Modified

* New items
  * Method `GetXsrfValueAsync(CancellationToken)`
  * Method `SetXsrfValueAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `SetSpamStatusByIdsAsync(Int32[], CancellationToken)`
  * Method `SetSpamStatusByProviderAsync(String, ArchiveRestrictionInfo[], CancellationToken)`

#### SuperOffice.CRM.Services.UserAgent is Modified

* New items
  * Method `ExchangeCodeAndSaveTokensAsync(String, String, String, String, String, CancellationToken)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.Threading.AsyncQueueTracker`
* `SuperOffice.Threading.IAsyncQueueInstance`
* `SuperOffice.Util.TemporaryValue<T>`

### Modified Types

#### SuperOffice.CRM.FunctionRightStrings is Modified

* New items
  * Field `CSMarkAsSpam`

#### SuperOffice.Data.Registry is Modified

* New items
  * Field `DefaultTicketStatusSpam`

#### SuperOffice.Data.TicketBaseStatus is Modified

* New items
  * Field `Spam`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN__STOP_WEBHOOK`
  * Field `SR_ADMIN_COPY_WEBHOOK`
  * Field `SR_ADMIN_DELETE_WEBHOOK`
  * Field `SR_ADMIN_EDIT_WEBHOOK`
  * Field `SR_ADMIN_FILTER_BY_WEBHOOK_NAME`
  * Field `SR_ADMIN_NEW_WEBHOOK`
  * Field `SR_ADMIN_RETRY_WEBHOOK`
  * Field `SR_ADMIN_WEBHOOK_CONSECUTIVE_ERRORS`
  * Field `SR_ADMIN_WEBHOOK_CONSECUTIVE_ERRORS_TOOLTIP`
  * Field `SR_ADMIN_WEBHOOK_EVENT_COUNT`
  * Field `SR_ADMIN_WEBHOOK_EVENT_COUNT_TOOLTIP`
  * Field `SR_ADMIN_WEBHOOK_EVENTS`
  * Field `SR_ADMIN_WEBHOOK_EVENTS_TOOLTIP`
  * Field `SR_ADMIN_WEBHOOK_ID`
  * Field `SR_ADMIN_WEBHOOK_LAST_ERROR`
  * Field `SR_ADMIN_WEBHOOK_LAST_ERROR_TOOLTIP`
  * Field `SR_ADMIN_WEBHOOK_LAST_EVENT`
  * Field `SR_ADMIN_WEBHOOK_LAST_EVENT_TOOLTIP`
  * Field `SR_ADMIN_WEBHOOK_NAME`
  * Field `SR_ADMIN_WEBHOOK_NAME_TOOLTIP`
  * Field `SR_ADMIN_WEBHOOK_STATUS`
  * Field `SR_ADMIN_WEBHOOK_STATUS_TOOLTIP`
  * Field `SR_ADMIN_WEBHOOK_TARGET_URL`
  * Field `SR_ADMIN_WEBHOOK_TARGET_URL_TOOLTIP`
  * Field `SR_ADMIN_WEBHOOK_TOTAL_CALLS`
  * Field `SR_ADMIN_WEBHOOK_TOTAL_CALLS_TOOLTIP`
  * Field `SR_ADMIN_WEBHOOK_TOTAL_ERRORS`
  * Field `SR_ADMIN_WEBHOOK_TOTAL_ERRORS_TOOLTIP`
  * Field `SR_ADMIN_WEBHOOK_TYPE`
  * Field `SR_ADMIN_WEBHOOK_TYPE_TOOLTIP`
  * Field `SR_ADMIN_WEBHOOKS`
  * Field `SR_ADMIN_WEBHOOKS_ADD`
  * Field `SR_ADMIN_WEBHOOKS_CLEAR_FILTERS`
  * Field `SR_ADMIN_WEBHOOKS_DELETE`
  * Field `SR_ADMIN_WEBHOOKS_ENTITY_TYPE`
  * Field `SR_ADMIN_WEBHOOKS_SEND_REAL_TIME_NOTIFICATIONS`
  * Field `SR_FORMS_ADD_DEPENDENT_FIELD`
  * Field `SR_FORMS_AI_PROGRESS_DONE`
  * Field `SR_FORMS_AI_PROGRESS_ERROR`
  * Field `SR_FORMS_DEPENDENCY_DONE`
  * Field `SR_FORMS_DEPENDENCY_EDIT`
  * Field `SR_FORMS_DEPENDENCY_LABEL`
  * Field `SR_FORMS_DEPENDENCY_LABEL2`
  * Field `SR_FORMS_DEPENDENCY_OR`
  * Field `SR_FORMS_DEPENDENCY_SELECT_VALUES`
  * Field `SR_FORMS_DEPENDENT_OF`
  * Field `SR_FORMS_IS_DEPENDENT`
  * Field `SR_FORMS_LAYOUT_HEADER`
  * Field `SR_FORMS_LAYOUT_SUBHEADER`
  * Field `SR_FORMS_STYLE_HEADER`
  * Field `SR_FORMS_STYLE_SUBHEADER`
  * Field `SR_GENERATE_QUOTEDOCUMENTS_ERROR`
  * Field `SR_ONBOARDING_DONE_CONNECTED_TO`
  * Field `SR_PROJECTMEMBER_FUNCTION`
  * Field `SR_PROJECTMEMBER_HASINFO`
  * Field `SR_PROJECTMEMBER_REGISTERED`
  * Field `SR_PROJECTMEMBER_UPDATED`
  * Field `SR_SINGULAR_WEBHOOK`
  * Field `SR_TICKET_ACTION_MARK_AS_SPAM`
  * Field `SR_TICKET_ARCHIVE_SPAM_ALL_REQUESTS_CONFIRMATION`
  * Field `SR_TICKET_ARCHIVE_SPAM_SELECTED_REQUESTS_CONFIRMATION`
  * Field `SR_TICKET_ASK_TO_CONFIRM_MARK_TICKET_AS_SPAM`
  * Field `SR_TICKET_MESSAGE_WARNING_LARGE`
  * Field `SR_TICKETARCHIVE_STATUS_SPAM`
  * Field `SR_WEBHOOK_ACTIVE`
  * Field `SR_WEBHOOK_ACTIVE_FAILURES`
  * Field `SR_WEBHOOK_CUSTOM_EVENTS`
  * Field `SR_WEBHOOK_STOPPED`
  * Field `SR_WEBHOOK_UNKNOWN`

#### SuperOffice.License.SoLicenseNames is Modified

* Deleted items
  * Field `ErpConnect`
  * Field `Mailchimp`
  * Field `Map4You`
  * Field `MsTeamsChat`
* New items
  * Field `ActivityFolders`
  * Field `AiAgent`
  * Field `AiBgRemover`
  * Field `AiFormCopilot`
  * Field `AiMcp`
  * Field `AiText`
  * Field `ConnectErpProfessional`
  * Field `ConnectErpStandard`
  * Field `Map4YouPro`

#### SuperOffice.Threading.AsyncQueue<TItem> is Modified

* Deleted items
  * Method `AsyncQueue(INSPrincipalAccessor, ILogger<AsyncQueue<TItem>>)`
* New items
  * Method `AsyncQueue(INSPrincipalAccessor, ILogger<AsyncQueue<TItem>>, AsyncQueueTracker)`

#### SuperOffice.Threading.AsyncQueueBase<TItem> is Modified

* Deleted items
  * Method `AsyncQueueBase(INSPrincipalAccessor, ILogger<AsyncQueueBase<TItem>>)`
* New items
  * Method `AsyncQueueBase(INSPrincipalAccessor, ILogger<AsyncQueueBase<TItem>>, AsyncQueueTracker)`
  * Method `WaitForInFlightItemsAsync(CancellationToken)`

#### SuperOffice.Util.StackTracer is Modified

* New items
  * Method `GetSanitizedCallstack(String)`


### Assembly: SoDatabase

### New Types

* `SuperOffice.Data.SQL.Case`

### Modified Types

#### SuperOffice.Data.Dialect.Dialect is Modified

* New items
  * Method `ToSql(Case)`

#### SuperOffice.Data.QueryExectionExtensions is Modified

* New items
  * Method `ExecuteBatchedReaderAsync(SqlCommand, Boolean, Int32, CancellationToken)`

#### SuperOffice.Data.S is Modified

* Modified items

##### SuperOffice.Data.S.FieldExpression is Modified

* New items
  * Method `.FieldExpressionCase()`


#### SuperOffice.Util.AccessGateway is Modified

* Modified items

##### SuperOffice.Util.AccessGateway.TokenManagementInfo is Modified

* New items
  * Property `.TokenManagementInfoClaims`


#### SuperOffice.Util.TrackEventNames is Modified

* New items
  * Field `BackgroundRemoved`
  * Field `CategorizerTrained`
  * Field `CategoryGuessed`
  * Field `CompanyPhotographed`
  * Field `FormDesigned`
  * Field `LanguageDetected`
  * Field `PersonPhotographed`
  * Field `ProjectPhotographed`
  * Field `SentimentAnalyzed`
  * Field `TextTranslated`


### Assembly: SoDatabase.BusinessLogic

### New Types

* `SuperOffice.CRM.ArchiveLists.WebhookExtenderBase`
* `SuperOffice.CRM.ArchiveLists.WebhookProvider`
* `SuperOffice.CRM.ArchiveLists.WebhookUsageExtenderBase`
* `SuperOffice.CRM.ArchiveLists.WebhookWebhookExtender`
* `SuperOffice.CRM.ArchiveLists.WebhookWebhookUsageExtender`
* `SuperOffice.CRM.Data.Util.Duplicates.ContactFreetextDuplicateRule`
* `SuperOffice.CRM.Data.Util.Duplicates.ProjectFreetextDuplicateRule`
* `SuperOffice.CRM.Data.Util.Duplicates.SelectionFreetextDuplicateRule`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.SaleExtenderBase is Modified

* New items
  * Method `AcceptRow(SoDataReader)`
  * Method `RequiredPhaseOneFields()`

#### SuperOffice.CRM.XsrfHelper is Modified

* New items
  * Method `GetXsrfValueAsync(CancellationToken)`
  * Method `SetXsrfValueAsync(String, CancellationToken)`


### Assembly: SuperOffice.Plugins

### Assembly: SoLicense

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.Steps_CS.CS_72_TicketStatusSpam`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_148_MarkAsSpam_FunctionalRight`

### Modified Types

#### SuperOffice.CD.Database.Registry is Modified

* New items
  * Field `DefaultTicketStatusSpam`

#### SuperOffice.CD.Database.TicketBaseStatus is Modified

* New items
  * Field `Spam`



