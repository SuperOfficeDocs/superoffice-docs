---
uid: version_11.9.1204.0_changes
date: 18.02.2026
---

Changes from v11.8.788 and v11.9.1204.0

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.AvailableFont`
* `SuperOffice.CRM.Services.CreatePhotoBackground`
* `SuperOffice.CRM.Services.NaturalLanguageSearch`
* `SuperOffice.CRM.Services.RagStatus`
* `SuperOffice.CRM.Services.RagStatusChunks`

### Modified Types

#### SuperOffice.CRM.Services.AnalyticsData is Modified

* Deleted items
  * Property `AmplitudeApiKey`
  * Property `UserflowToken`

#### SuperOffice.CRM.Services.Category is Modified

* Modified items
  * Property `Id`
  * Property `Tooltip`
  * Property `Value`
* New items
  * Property `CategoryGroup`
  * Property `Deleted`
  * Property `EnableLeadStatus`
  * Property `Rank`

#### SuperOffice.CRM.Services.IAIAgent is Modified

* New items
  * Method `CancelIndexingAsync(String, CancellationToken)`
  * Method `GetIndexingStatusAsync(String, CancellationToken)`
  * Method `ParseQueryIntoRestrictionsAsync(String, String, NaturalLanguageSearch, CancellationToken)`
  * Method `RemovePhotoBackgroundAsync(Stream, CancellationToken)`

#### SuperOffice.CRM.Services.IMarketingAgent is Modified

* New items
  * Method `CreateDefaultAvailableFontAsync(CancellationToken)`
  * Method `DeleteAvailableFontAsync(Int32, CancellationToken)`
  * Method `GetAvailableFontAsync(Int32, CancellationToken)`
  * Method `SaveAvailableFontAsync(AvailableFont, CancellationToken)`
  * Method `SetFontRankAsync(Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.PersonEntity is Modified

* New items
  * Property `Leadstatus`

#### SuperOffice.CRM.Services.WebPanelEntity is Modified

* New items
  * Property `CustomObjectEntity`


### Assembly: SuperOffice.Services.Implementation

### New Types

* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IAvailableFontImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICreatePhotoBackgroundImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.INaturalLanguageSearchImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IRagStatusImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.CreatePhotoBackgroundImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.NaturalLanguageSearchImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.RagStatusImplementation`

### Modified Types

#### SuperOffice.CRM.Services.AIAgent is Modified

* Deleted items
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ICopilotDataSourceEntityImplementation, ICopilotEntityImplementation, IFormDesignCarrierImplementation, ISentimentImplementation, IRagAnswerImplementation, IRagResultImplementation, ISummarizerImplementation, ISoRequestItemsAccessor)`
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ICopilotDataSourceEntityImplementation, ICopilotEntityImplementation, IFormDesignCarrierImplementation, ISentimentImplementation, IRagAnswerImplementation, IRagResultImplementation, ISummarizerImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ICopilotDataSourceEntityImplementation, ICopilotEntityImplementation, IFormDesignCarrierImplementation, ISentimentImplementation, INaturalLanguageSearchImplementation, ICreatePhotoBackgroundImplementation, IRagAnswerImplementation, IRagResultImplementation, IRagStatusImplementation, ISummarizerImplementation, ISoRequestItemsAccessor)`
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ICopilotDataSourceEntityImplementation, ICopilotEntityImplementation, IFormDesignCarrierImplementation, ISentimentImplementation, INaturalLanguageSearchImplementation, ICreatePhotoBackgroundImplementation, IRagAnswerImplementation, IRagResultImplementation, IRagStatusImplementation, ISummarizerImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `CancelIndexingAsync(String, CancellationToken)`
  * Method `GetIndexingStatusAsync(String, CancellationToken)`
  * Method `ParseQueryIntoRestrictionsAsync(String, String, NaturalLanguageSearch, CancellationToken)`
  * Method `RemovePhotoBackgroundAsync(Stream, CancellationToken)`

#### SuperOffice.CRM.Services.MarketingAgent is Modified

* Deleted items
  * Method `MarketingAgent(IFormEntityImplementation, IFormSubmissionEntityImplementation, IMailingStatisticsImplementation, IPreviewMailingImplementation, IPreviewMailingHeaderImplementation, IShipmentMessageBlockEntityImplementation, IShipmentMessageEntityImplementation, ISoRequestItemsAccessor)`
  * Method `MarketingAgent(IFormEntityImplementation, IFormSubmissionEntityImplementation, IMailingStatisticsImplementation, IPreviewMailingImplementation, IPreviewMailingHeaderImplementation, IShipmentMessageBlockEntityImplementation, IShipmentMessageEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `MarketingAgent(IAvailableFontImplementation, IFormEntityImplementation, IFormSubmissionEntityImplementation, IMailingStatisticsImplementation, IPreviewMailingImplementation, IPreviewMailingHeaderImplementation, IShipmentMessageBlockEntityImplementation, IShipmentMessageEntityImplementation, ISoRequestItemsAccessor)`
  * Method `MarketingAgent(IAvailableFontImplementation, IFormEntityImplementation, IFormSubmissionEntityImplementation, IMailingStatisticsImplementation, IPreviewMailingImplementation, IPreviewMailingHeaderImplementation, IShipmentMessageBlockEntityImplementation, IShipmentMessageEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `CreateDefaultAvailableFontAsync(CancellationToken)`
  * Method `DeleteAvailableFontAsync(Int32, CancellationToken)`
  * Method `GetAvailableFontAsync(Int32, CancellationToken)`
  * Method `SaveAvailableFontAsync(AvailableFont, CancellationToken)`
  * Method `SetFontRankAsync(Int32, Int32, CancellationToken)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.Util.ExpiringDictionary<TKey, TValue>`

### New Types

* `SuperOffice.Data.ExternallyOwnedStatus`
* `SuperOffice.Data.ExternallyOwnedType`
* `SuperOffice.Data.KbAccessLevel`
* `SuperOffice.Exceptions.SoFeatureToggleException`
* `Zomp.SyncMethodGenerator.SkipSyncVersionAttribute`

### Modified Types

#### .StringExtensions is Modified

* New items
  * Method `XPathSanitize(String)`

#### SuperOffice.CRM.Services.ParticipantInfo is Modified

* New items
  * Property `ExternallyOwnedStatus`
  * Property `ExternallyOwnedType`
  * Method `ParticipantInfo(Int32, Int32, Int32, Int32, Boolean, InvitationStatus, String, String, ExternallyOwnedType, ExternallyOwnedStatus)`

#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.Associates is Modified

* New items
  * Field `.AssociatesFirstLoginSession`


##### SuperOffice.CRM.UserPreferenceStrings.NetServices is Modified

* New items
  * Field `.NetServicesTemplatesUrl`

* New items

##### SuperOffice.CRM.UserPreferenceStrings.EmailNotification is New

#### SuperOffice.Data.Navigation is Modified

* New items
  * Field `CustomObjectArchive`
  * Field `CustomObjectCard`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `ADMIN_TICKET_RELATION_BUILT_IN_INFORMATION`
  * Field `RELATION_IS_A_CHILD_OF`
  * Field `RELATION_IS_A_PARENT_OF`
  * Field `RELATION_IS_RELATED_TO`
  * Field `SR_ADMIN_COPILOT_EXCLUDECSS`
  * Field `SR_ADMIN_COPILOT_EXCLUDECSS_TOOLTIP`
  * Field `SR_ADMIN_COPILOT_INCLUDECSS`
  * Field `SR_ADMIN_COPILOT_INCLUDECSS_TOOLTIP`
  * Field `SR_ADMIN_COPILOT_SITEMAP_TOOLTIP`
  * Field `SR_ADMIN_COPILOT_SKIPCSS`
  * Field `SR_ADMIN_COPILOT_SKIPCSS_TOOLTIP`
  * Field `SR_ADMIN_COPILOT_SKIPURLS`
  * Field `SR_ADMIN_COPILOT_SKIPURLS_TOOLTIP`
  * Field `SR_ADMIN_LIST_ALLOW_LOCAL`
  * Field `SR_ADMIN_LIST_ALLOW_LOCAL_TOOLTIP`
  * Field `SR_ADMIN_LIST_SHOW_CUSTOMOBJECTARCHIVE`
  * Field `SR_ADMIN_TICKETRELATION_NAME_ALREADY_EXIST`
  * Field `SR_APPOINTMENT_TYPE_OPTIONAL`
  * Field `SR_APPOINTMENT_TYPE_ORGANIZER`
  * Field `SR_APPOINTMENT_TYPE_REQUIRED`
  * Field `SR_ENUM_KB_ACCESS_INTERNAL`
  * Field `SR_ENUM_KB_ACCESS_PRIVATE`
  * Field `SR_ENUM_KB_ACCESS_PUBLIC`
  * Field `SR_ENUM_KB_ACCESS_PUBLIC_AUTHENTICATED`
  * Field `SR_ENUM_REPLYTEMPLATE_ACCESS_FULL`
  * Field `SR_ENUM_REPLYTEMPLATE_ACCESS_NONE`
  * Field `SR_ENUM_REPLYTEMPLATE_ACCESS_READ`
  * Field `SR_FORMFONTS_ADD_FONT`
  * Field `SR_FORMFONTS_BOLD`
  * Field `SR_FORMFONTS_CONFIRM_DELETE`
  * Field `SR_FORMFONTS_ENABLEDFONTS`
  * Field `SR_FORMFONTS_FONTPREVIEW`
  * Field `SR_FORMFONTS_INFOBADGE`
  * Field `SR_FORMFONTS_ITALIC`
  * Field `SR_FORMFONTS_LABEL`
  * Field `SR_FORMFONTS_NOTAVAILABLE`
  * Field `SR_FORMFONTS_REGULAR`
  * Field `SR_FORMFONTS_SEARCHBYNAME`
  * Field `SR_FORMS_CSS_LABEL`
  * Field `SR_INVITE_NOT_SEEN`
  * Field `SR_INVITE_TENTATIVE`
  * Field `SR_KB_WORKFLOW_EXPIRED`
  * Field `SR_KB_WORKFLOW_PUBLISHED`
  * Field `SR_KB_WORKFLOW_UNPUBLISHED`
  * Field `SR_MAILLOGIN_SIGN_IN_TO_EMAIL_SERVICE`
  * Field `SR_MENU_ONBOARDING`
  * Field `SR_NOTIFY_EMAIL_EXPIRED_DESC`
  * Field `SR_NOTIFY_EMAIL_EXPIRED_TITLE`
  * Field `SR_NOTIFY_SETTINGS_EMAIL_HEADING`
  * Field `SR_NOTIFY_SETTINGS_notifyExpiredEmailAuthentication`
  * Field `SR_ONBOARDING_ALREADY_HAVE_WEBTOOLS`
  * Field `SR_ONBOARDING_BUTT_DISCONNECT`
  * Field `SR_ONBOARDING_BUTT_SIGN_IN`
  * Field `SR_ONBOARDING_BUTT_UPDATE`
  * Field `SR_ONBOARDING_CLICK_TO_CONNECT`
  * Field `SR_ONBOARDING_CONNECT_TO_EMAIL`
  * Field `SR_ONBOARDING_CONNECT_TO_EMAIL_INFO_MESSAGE`
  * Field `SR_ONBOARDING_DOWNLOAD_WEBTOOLS`
  * Field `SR_ONBOARDING_RESUME_CONNECT`
  * Field `SR_ONBOARDING_RESUME_SIGN_IN`
  * Field `SR_ONBOARDING_SELECT_LANGUAGE`
  * Field `SR_ONBOARDING_SETTING_LANGUAGE`
  * Field `SR_ONBOARDING_WEBTOOLS_SWITCH_ARIA_LABEL`
  * Field `SR_ONBOARDING_WEBTOOLS_SWITCH_LABEL`
  * Field `SR_ONBOARDING_WEBTOOLS_UPDATE_AVAILABLE_PAGE`
  * Field `SR_ONBOARDING_WEBTOOLS_UPDATE_AVAILABLE_TEXT`
  * Field `SR_ONBOARDING_WEBTOOLS_UPDATE_AVAILABLE_TITLE`
  * Field `SR_ONBOARDING_WEBTOOLS_UPDATE_REQUIRED_PAGE`
  * Field `SR_ONBOARDING_WEBTOOLS_UPDATE_REQUIRED_TEXT`
  * Field `SR_ONBOARDING_WEBTOOLS_UPDATE_REQUIRED_TITLE`
  * Field `SR_PD_emailNotification_DESC`
  * Field `SR_PD_emailNotification_NAME`
  * Field `SR_PD_emailNotification_notifyExpiredEmailAuthentication_DESC`
  * Field `SR_PD_emailNotification_notifyExpiredEmailAuthentication_NAME`
  * Field `SR_TICKET_ADD_LINK_FROM`
  * Field `SR_TICKET_ADD_LINK_TO`
  * Field `SR_TICKET_CREATE_AND_CONTINUE`
  * Field `SR_TICKET_CREATE_NEW_REQUEST`
  * Field `SR_TICKET_LINK_TO_EXISTING`
  * Field `SR_TICKET_NEW_RELATION`
  * Field `SR_TICKET_NEW_REQUEST_TITLE`
  * Field `SR_TICKET_RELATE`
  * Field `SR_TICKET_RELATION_ALREADY_EXIST`
  * Field `SR_TICKET_RELATION_PARENT_ALREADY_EXIST`
  * Field `SR_TICKET_SELECT_DIFFERENT_FROM_SOURCE`
  * Field `SR_TICKETREL_ADD`
  * Field `SR_TICKETREL_DESTINATION_VALUE_INVALID_TOOLTIP`
  * Field `SR_TICKETREL_PARENT_REQUEST`
  * Field `SR_TICKETREL_REMOVE`

#### SuperOffice.License.SoLicenseNames is Modified

* New items
  * Field `Suite1Starter`
  * Field `Suite2Core`
  * Field `Suite3Growth`
  * Field `Suite4Plus`
  * Field `Suite5Super`
  * Field `SuiteMarker`
  * Field `SuiteUser`

#### SuperOffice.Threading.TaskHelper is Modified

* Modified items
  * Method `GetAllRunningTasks()`
* New items
  * Method `IterativelyWaitForRunningTasks()`

#### SuperOffice.Util.StringHelper is Modified

* New items
  * Method `CleanseString(String)`

#### SuperOffice.Util.XmlUtil is Modified

* New items
  * Method `IsValidXmlName(String)`

#### Zomp.SyncMethodGenerator.CreateSyncVersionAttribute is Modified

* New items
  * Property `PreserveProgress`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.Ticket.TicketRelationHelper`
* `SuperOffice.Data.SQL.DateAdd`
* `SuperOffice.Data.SQL.DatePart`

### Modified Types

#### SuperOffice.CRM.Data.AppointmentTableInfo is Modified

* New items
  * Property `ExternalParticipants`

#### SuperOffice.CRM.Data.AvailableFontsTableInfo is Modified

* New items
  * Property `Deleted`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.AppointmentFields is Modified

* New items
  * Field `.AppointmentFieldsExternalParticipants`


##### SuperOffice.CRM.Data.DBC.AvailableFontsFields is Modified

* New items
  * Field `.AvailableFontsFieldsDeleted`


#### SuperOffice.CRM.Rows.AppointmentRecordData is Modified

* New items
  * Field `ExternalParticipants`

#### SuperOffice.CRM.Rows.AppointmentRow is Modified

* New items
  * Property `ExternalParticipants`
  * Event `OnExternalParticipantsChange`

#### SuperOffice.CRM.Rows.AvailableFontsRecordData is Modified

* New items
  * Field `Deleted`

#### SuperOffice.CRM.Rows.AvailableFontsRow is Modified

* New items
  * Property `Deleted`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(ExternallyOwnedStatus&, FieldInfo)`
  * Method `ValidateField(ExternallyOwnedType&, FieldInfo)`
  * Method `ValidateField(KbAccessLevel&, FieldInfo)`

#### SuperOffice.CRM.Security.Sentry is Modified

* New items
  * Method `GetIntArrayField(FieldInfo)`

#### SuperOffice.Data.Dialect.Dialect is Modified

* New items
  * Method `ToSql(DateAdd)`

#### SuperOffice.Data.QueryExecutionHelper is Modified

* Modified items
  * Property `RowsAffected`

##### SuperOffice.Data.QueryExecutionHelper.ExecutionType is Modified

* New items
  * Field `.ExecutionTypeScalar`


#### SuperOffice.Data.S is Modified

* Modified items

##### SuperOffice.Data.S.ArgumentFunctions is Modified

* New items
  * Method `.ArgumentFunctionsDateAdd(DatePart, Argument, Argument)`


#### SuperOffice.Data.SoConnection is Modified

* New items
  * Property `ConnectionTrackingIdSource`
  * Property `CurrentTest`

#### SuperOffice.Util.TrackEventNames is Modified

* New items
  * Field `CopilotMessaged`
  * Field `TextSummarized`
  * Field `TextTransformed`


### Assembly: SoDatabase.BusinessLogic

### Deleted Types

* `SuperOffice.CallHome.TimeKeepingCallHome`

### New Types

* `SuperOffice.CallHome.NightlyJob`
* `SuperOffice.CallHome.TimeKeepingNightlyJob`
* `SuperOffice.CRM.ArchiveLists.RelatedTicketsProvider`
* `SuperOffice.CRM.ArchiveLists.TicketTicketRelationExtender`
* `SuperOffice.CRM.Lists.KbAccessLevelProvider`
* `SuperOffice.CRM.Lists.KbWorkflowProvider`
* `SuperOffice.CRM.Lists.OnlineFontLibraryProvider`
* `SuperOffice.CRM.Lists.ReplyTemplateAccessLevelProvider`
* `SuperOffice.CRM.Lists.TicketRelationTypeProvider`

### Modified Types

#### SuperOffice.CallHome.DataAdditionCallHome is Modified

* Deleted items
  * Method `CollectAndReport(CollectionLockInfo)`
* New items
  * Method `CollectAndReport(NightlyJobLockInfo)`

#### SuperOffice.CallHome.PeriodicCallHomeBase is Modified

* Deleted items
  * Property `IsProcessingRunning`
  * Method `CollectAndReport(CollectionLockInfo)`

##### SuperOffice.CallHome.PeriodicCallHomeBase.CollectionLockInfo is Deleted

##### SuperOffice.CallHome.PeriodicCallHomeBase.CollectionResult is Deleted
* Modified items
  * Method `PeriodicCallHomeBase(String, String, Int32)`
* New items
  * Method `CollectAndReport(NightlyJobLockInfo)`
  * Method `DoCycledTask(NightlyJobLockInfo)`

#### SuperOffice.CallHome.TableSizeCallHome is Modified

* Deleted items
  * Method `CollectAndReport(CollectionLockInfo)`
* New items
  * Method `CollectAndReport(NightlyJobLockInfo)`

#### SuperOffice.CallHome.UserReSyncCallHome is Modified

* Deleted items
  * Method `CollectAndReport(CollectionLockInfo)`
* New items
  * Method `CollectAndReport(NightlyJobLockInfo)`

#### SuperOffice.CallHome.UserSync is Modified

* Modified items
  * Method `ResyncUsers()`

#### SuperOffice.CallHome.WebAppUsageCallHome is Modified

* Deleted items
  * Method `CollectAndReport(CollectionLockInfo)`
* New items
  * Method `CollectAndReport(NightlyJobLockInfo)`

#### SuperOffice.CallHome.WinUsageStatCallHome is Modified

* Deleted items
  * Method `CollectAndReport(CollectionLockInfo)`
* New items
  * Method `CollectAndReport(NightlyJobLockInfo)`

#### SuperOffice.CRM.ArchiveLists.ExtensibleColumnsBase is Modified

* Deleted items
  * Property `DebugXML`

#### SuperOffice.CRM.ArchiveLists.ExtensibleHelper is Modified

* Deleted items
  * Property `DebugXML`

#### SuperOffice.CRM.ArchiveLists.MultiQueryProviderBase is Modified

* Deleted items
  * Property `DebugXML`

#### SuperOffice.CRM.Workflow.IWorkflowUtil is Modified

* Deleted items
  * Method `VerifySmtpSetupAsync(Int32, CancellationToken)`

#### SuperOffice.Data.Dialect.OracleCommon is Modified

* New items
  * Method `ToSql(DateAdd)`

#### SuperOffice.Data.Dialect.PostgreSqlDialect is Modified

* New items
  * Method `ToSql(DateAdd)`

#### SuperOffice.Data.Dialect.SqlServerOperations is Modified

* Modified items
  * Method `InnerTruncateTableAsync(SoTable, TruncateOptions)`

#### SuperOffice.Util.RagAIHelper is Modified

* Deleted items
  * Method `IndexingFinished(String, String, String)`
  * Method `IndexingStarted(String, String, String)`
* New items
  * Method `CancelIndexing(String, String, CancellationToken)`
  * Method `IndexingFinished(String, String)`
  * Method `IndexingStarted(String, String)`
  * Method `IndexingStatus(String, CancellationToken)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.ExternallyOwnedStatus`
* `SuperOffice.CD.Database.ExternallyOwnedType`
* `SuperOffice.CD.DSL.Database.KbAccessLevel`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_138_Appointment_ExternalParticipants`
* `SuperOffice.CD.DSL.Database.SuperOffice_139_AvailableFontsSoftDelete`

### Modified Types

#### SuperOffice.CD.Database.Navigation is Modified

* New items
  * Field `CustomObjectArchive`
  * Field `CustomObjectCard`

#### SuperOffice.CD.DSL.Database.T_Appointment is Modified

* New items
  * Field `ExternalParticipants`

#### SuperOffice.CD.DSL.Database.T_AvailableFonts is Modified

* New items
  * Field `Deleted`



