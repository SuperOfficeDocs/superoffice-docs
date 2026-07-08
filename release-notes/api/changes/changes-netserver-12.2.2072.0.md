---
uid: version_12.2.2072.0_changes
date: 07.07.2026
---

Changes from v12.1.1412.0 and v12.2.2072.0

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.INewsFeedAgent`
* `SuperOffice.CRM.Services.NewsFeedCTA`
* `SuperOffice.CRM.Services.NewsFeedItem`

### Modified Types

#### SuperOffice.CRM.Services.IEMailAgent is Modified

* New items
  * Method `GetEMailAsEmlStreamAsync(Int32, Boolean, CancellationToken)`


### Assembly: SuperOffice.Services.Implementation

### New Types

* `SuperOffice.CRM.Services.Implementation.BL.Contracts.INewsFeedItemImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.NewsFeedItemImplementation`
* `SuperOffice.CRM.Services.NewsFeedAgent`

### Modified Types

#### SuperOffice.CRM.Services.EMailAgent is Modified

* New items
  * Method `GetEMailAsEmlStreamAsync(Int32, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailEntityImplementation is Modified

* New items
  * Method `GetEMailAsEmlStreamAsync(Int32, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CustomerServiceStartupImplementation is Modified

* Deleted items
  * Method `CustomerServiceStartupImplementation(IPreferenceImplementation, ICacheManager)`
* New items
  * Method `CustomerServiceStartupImplementation(ICacheManager)`

#### SuperOffice.CRM.Services.Implementation.BL.EMailEntityImplementation is Modified

* New items
  * Method `GetEMailAsEmlStreamAsync(Int32, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PreferredTimeZoneImplementation is Modified

* Deleted items
  * Method `PreferredTimeZoneImplementation(IPreferenceAgent)`
* New items
  * Method `PreferredTimeZoneImplementation()`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.Diagnostics.DiagnoseException`
* `SuperOffice.Diagnostics.DiagnoseMethod`
* `SuperOffice.Diagnostics.DiagnoseMethodAsync`
* `SuperOffice.Diagnostics.Diagnostic`
* `SuperOffice.Security.Permissions.SoStrongName`
* `SuperOffice.Security.Util.DocumentArchiveFileImpersonationContext`
* `SuperOffice.Security.Util.WindowsIdentityHelper`
* `SuperOffice.Threading.ThreadwiseKeyCache<Item>`

### New Types

* `ExtensionMethods.ResourceManagerExt`
* `SuperOffice.Data.CtaFlavor`
* `SuperOffice.Data.CtaType`
* `SuperOffice.Data.NewsFeedItemStatus`
* `SuperOffice.Exceptions.XsrfValidationException`
* `SuperOffice.Globalization.ClientFilterFormat`
* `SuperOffice.Globalization.ResourceManager`
* `SuperOffice.Globalization.ResourceStringFormat`
* `SuperOffice.Globalization.RmDiWrapper`
* `SuperOffice.IO.Files.FileLookup`

### Modified Types

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.CustomerService is Modified

* Deleted items
  * Property `.CustomerServiceCsDomain`
  * Property `.CustomerServiceCsPassword`
  * Property `.CustomerServiceCsUserName`
  * Property `.CustomerServiceImpersonateCsUser`


##### SuperOffice.Configuration.ConfigFile.Data is Modified

* Modified items

##### .Data.Database is Modified

* Deleted items
  * Property `.DatabaseDynamicLoadedConnectionType`
  * Property `.DatabaseDynamicLoadedDataBaseDriver`
  * Property `.DatabaseImpersonateDatabaseUser`



##### SuperOffice.Configuration.ConfigFile.Diagnostics is Modified

* Deleted items
  * Property `.DiagnosticsCheckBrowserVersion`
  * Property `.DiagnosticsEnableScaffolding`
  * Property `.DiagnosticsLogFailureAudit`
  * Property `.DiagnosticsLogFolder`
  * Property `.DiagnosticsLoggedServices`
  * Property `.DiagnosticsLogLongQueries`
  * Property `.DiagnosticsLogLongQueriesAsXML`
  * Property `.DiagnosticsLogLongQueriesToPlugins`
  * Property `.DiagnosticsLogMailFolder`
  * Property `.DiagnosticsLogServiceCalls`
  * Property `.DiagnosticsLogSuccessAudit`
  * Property `.DiagnosticsLogToEventLog`
  * Property `.DiagnosticsLogToFile`
  * Property `.DiagnosticsLogToTrace`
  * Property `.DiagnosticsLongNonQueryThreshold`
  * Property `.DiagnosticsLongQueryRows`
  * Property `.DiagnosticsLongQueryThreshold`


##### SuperOffice.Configuration.ConfigFile.Documents is Modified

* Deleted items
  * Property `.DocumentsArchiveDomain`
  * Property `.DocumentsArchivePassword`
  * Property `.DocumentsArchiveUser`
  * Property `.DocumentsImpersonateUser`


##### SuperOffice.Configuration.ConfigFile.ICustomerServiceConfiguration is Modified

* Deleted items
  * Property `.ICustomerServiceConfigurationCsDomain`
  * Property `.ICustomerServiceConfigurationCsPassword`
  * Property `.ICustomerServiceConfigurationCsUserName`
  * Property `.ICustomerServiceConfigurationImpersonateCsUser`


##### SuperOffice.Configuration.ConfigFile.IDataDatabaseConfiguration is Modified

* Deleted items
  * Property `.IDataDatabaseConfigurationDynamicLoadedConnectionType`
  * Property `.IDataDatabaseConfigurationDynamicLoadedDataBaseDriver`
  * Property `.IDataDatabaseConfigurationImpersonateDatabaseUser`


##### SuperOffice.Configuration.ConfigFile.IDiagnosticsConfiguration is Modified

* Deleted items
  * Property `.IDiagnosticsConfigurationCheckBrowserVersion`
  * Property `.IDiagnosticsConfigurationEnableScaffolding`
  * Property `.IDiagnosticsConfigurationLogFailureAudit`
  * Property `.IDiagnosticsConfigurationLogFolder`
  * Property `.IDiagnosticsConfigurationLoggedServices`
  * Property `.IDiagnosticsConfigurationLogLongQueries`
  * Property `.IDiagnosticsConfigurationLogLongQueriesAsXML`
  * Property `.IDiagnosticsConfigurationLogLongQueriesToPlugins`
  * Property `.IDiagnosticsConfigurationLogMailFolder`
  * Property `.IDiagnosticsConfigurationLogServiceCalls`
  * Property `.IDiagnosticsConfigurationLogSuccessAudit`
  * Property `.IDiagnosticsConfigurationLogToEventLog`
  * Property `.IDiagnosticsConfigurationLogToFile`
  * Property `.IDiagnosticsConfigurationLogToTrace`
  * Property `.IDiagnosticsConfigurationLongNonQueryThreshold`
  * Property `.IDiagnosticsConfigurationLongQueryRows`
  * Property `.IDiagnosticsConfigurationLongQueryThreshold`


##### SuperOffice.Configuration.ConfigFile.IDocumentsConfiguration is Modified

* Deleted items
  * Property `.IDocumentsConfigurationArchiveDomain`
  * Property `.IDocumentsConfigurationArchivePassword`
  * Property `.IDocumentsConfigurationArchiveUser`
  * Property `.IDocumentsConfigurationImpersonateUser`


##### SuperOffice.Configuration.ConfigFile.IWebApiConfiguration is Modified

* Deleted items
  * Property `.IWebApiConfigurationAuthorizeWithImplicit`


##### SuperOffice.Configuration.ConfigFile.WebApi is Modified

* Deleted items
  * Property `.WebApiAuthorizeWithImplicit`


#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.Copilot is Modified

* New items
  * Field `.CopilotCompanyPurpose`


##### SuperOffice.CRM.UserPreferenceStrings.Mail is Modified

* Modified items
  * Field `.MailCheckForDuplicates`
  * Field `.MailEnableMailSync`
  * Field `.MailFirstMailSync`
  * Field `.MailIsEmailInstalled`
  * Field `.MailIsFaxInstalled`
  * Field `.MailMailSyncTimer`
  * Field `.MailRemoveAfterArchive`
* New items
  * Field `.MailDisableAutoEmailConnectivity`
  * Field `.MailUseLocalEmailApp`

* New items

##### SuperOffice.CRM.UserPreferenceStrings.AI is New

#### SuperOffice.Diagnostics.SoLogger is Modified


#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_NO_CUSTOM_OBJECT_PRESENT`
  * Field `SR_AI_AGENT`
  * Field `SR_ARCHIVE_MAILING_FORMRESPONSE`
  * Field `SR_ARCHIVE_SALE_SALE_CYCLE`
  * Field `SR_ARCHIVE_SALE_SALE_CYCLE_TOOLTIP`
  * Field `SR_COPILOT`
  * Field `SR_DASHBOARD_MEASURE_COUNTALL_TOOLTIP`
  * Field `SR_DASHTILE_SAL_MY_AVERAGE_SALE_CYCLE_PER_SALE_TYPE_THIS_AND_PREVIOUS_YEAR`
  * Field `SR_DASHTILE_SAL_MY_GROUPS_AVERAGE_SALE_CYCLE_PER_SALE_TYPE_THIS_AND_PREVIOUS_YEAR`
  * Field `SR_LIST_NEWSFEED`
  * Field `SR_LIST_NEWSFEED_TOOLTIP`
  * Field `SR_MARKETING_LISTMAILINGS_COPYTONEWMAILING`
  * Field `SR_MARKETING_LISTMAILINGS_COPYTOTEMPLATE`
  * Field `SR_MARKETING_LISTMAILINGS_FORMSMAILING`
  * Field `SR_MARKETING_LISTMAILINGS_READY`
  * Field `SR_MARKETING_LISTMAILINGS_RECENTMAILINGS`
  * Field `SR_MARKETING_LISTMAILINGS_SCHEDULED`
  * Field `SR_NEWSFEED_APPLICATION_ID`
  * Field `SR_NEWSFEED_EXPIRES_AT`
  * Field `SR_NEWSFEED_EXPIRES_AT_TOOLTIP`
  * Field `SR_NEWSFEED_FROM_CATEGORY`
  * Field `SR_NEWSFEED_FROM_CATEGORY_TOOLTIP`
  * Field `SR_NEWSFEED_FROM_NAME`
  * Field `SR_NEWSFEED_FROM_NAME_TOOLTIP`
  * Field `SR_NEWSFEED_ID`
  * Field `SR_NEWSFEED_ID_TOOLTIP`
  * Field `SR_NEWSFEED_IMAGELINK`
  * Field `SR_NEWSFEED_IMAGELINK_TOOLTIP`
  * Field `SR_NEWSFEED_IS_READ`
  * Field `SR_NEWSFEED_IS_READ_TOOLTIP`
  * Field `SR_NEWSFEED_PREVIEW_HINT`
  * Field `SR_NEWSFEED_PRIORITY`
  * Field `SR_NEWSFEED_PRIORITY_TOOLTIP`
  * Field `SR_NEWSFEED_READ_AT`
  * Field `SR_NEWSFEED_READ_AT_TOOLTIP`
  * Field `SR_NEWSFEED_SOURCELINK`
  * Field `SR_NEWSFEED_SOURCELINK_TOOLTIP`
  * Field `SR_NEWSFEED_STATUS`
  * Field `SR_NEWSFEED_STATUS_HANDLED`
  * Field `SR_NEWSFEED_STATUS_HANDLING`
  * Field `SR_NEWSFEED_STATUS_NORMAL`
  * Field `SR_NEWSFEED_STATUS_TOOLTIP`
  * Field `SR_NEWSFEED_SUMMARY`
  * Field `SR_NEWSFEED_SUMMARY_TOOLTIP`
  * Field `SR_NEWSFEED_TITLE`
  * Field `SR_NEWSFEED_TITLE_TOOLTIP`
  * Field `SR_PD_AI_AllowLeadFeeder_DESC`
  * Field `SR_PD_AI_AllowLeadFeeder_NAME`
  * Field `SR_PD_AI_DESC`
  * Field `SR_PD_AI_EnableAgents_DESC`
  * Field `SR_PD_AI_EnableAgents_NAME`
  * Field `SR_PD_AI_EnableAI_DESC`
  * Field `SR_PD_AI_EnableAI_NAME`
  * Field `SR_PD_AI_LeadFeederApiKey_DESC`
  * Field `SR_PD_AI_LeadFeederApiKey_NAME`
  * Field `SR_PD_AI_NAME`
  * Field `SR_PD_Mail_DisableAutoEmailConnectivity_DESC`
  * Field `SR_PD_Mail_DisableAutoEmailConnectivity_NAME`
  * Field `SR_PD_Mail_UseLocalEmailApp_DESC`
  * Field `SR_PD_Mail_UseLocalEmailApp_NAME`
  * Field `SR_PRIORITY_HIGH`
  * Field `SR_PRIORITY_HIGHEST`
  * Field `SR_PRIORITY_LOW`
  * Field `SR_PRIORITY_LOWEST`
  * Field `SR_PRIORITY_NONE`
  * Field `SR_PRIORITY_NORMAL`
  * Field `SR_SELECTION_COPILOT_FIND_PLACEHOLDER`
  * Field `SR_SELECTION_COPILOT_REFINE_SEARCH`
  * Field `SR_SELECTION_DELETE_ALL_REQUESTS_YES_NO`
  * Field `SR_TICKET_DRAFT_SAVED`
  * Field `SR_WEBHOOK_NOTIFICATION_ACCESS_DENIED`

#### SuperOffice.IO.Files.DiskFileAccess is Modified

* Deleted items
  * Method `EnsureAccess(Action)`
  * Method `EnsureAccess(Func<Task>)`
  * Method `EnsureAccess<T>(Func<T>)`

#### SuperOffice.IO.Files.IFileAccess is Modified

* Deleted items
  * Method `EnsureAccess(Action)`
  * Method `EnsureAccess(Func<Task>)`
  * Method `EnsureAccess<T>(Func<T>)`

#### SuperOffice.License.SoLicenseNames is Modified

* Deleted items
  * Field `AdAuth`
* New items
  * Field `Demo`

#### SuperOffice.SoSession is Modified

* Deleted items
  * Method `Authenticate(SoCredentials, WindowsIdentity)`

#### SuperOffice.Util.FileNameHelper is Modified

* New items
  * Field `InvalidFileNameChars`
  * Field `InvalidFileNameCharsPattern`
  * Method `GetFileNameAnyPlatform(String)`

#### SuperOffice.Util.ImageStreamUtils is Modified

* New items
  * Method `GetThumbnailPngBytes(Stream, Int32, Int32)`

#### SuperOffice.Util.ImageUtilities is Modified

* Deleted items
  * Method `GetThumbnail(String, Int32, Int32)`
  * Method `GetThumbnailImage(Stream, Int32, Int32)`
  * Method `GetThumbnailImage(String, Int32, Int32)`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.Data.NewsFeedItemCtaTableInfo`
* `SuperOffice.CRM.Data.NewsFeedItemHtmlTableInfo`
* `SuperOffice.CRM.Data.NewsFeedItemRecipientTableInfo`
* `SuperOffice.CRM.Data.NewsFeedItemTableInfo`
* `SuperOffice.CRM.Rows.NewsFeedItemCtaRecordData`
* `SuperOffice.CRM.Rows.NewsFeedItemCtaRecordDataExtensions`
* `SuperOffice.CRM.Rows.NewsFeedItemCtaRow`
* `SuperOffice.CRM.Rows.NewsFeedItemCtaRows`
* `SuperOffice.CRM.Rows.NewsFeedItemHtmlRecordData`
* `SuperOffice.CRM.Rows.NewsFeedItemHtmlRecordDataExtensions`
* `SuperOffice.CRM.Rows.NewsFeedItemHtmlRow`
* `SuperOffice.CRM.Rows.NewsFeedItemHtmlRows`
* `SuperOffice.CRM.Rows.NewsFeedItemRecipientRecordData`
* `SuperOffice.CRM.Rows.NewsFeedItemRecipientRecordDataExtensions`
* `SuperOffice.CRM.Rows.NewsFeedItemRecipientRow`
* `SuperOffice.CRM.Rows.NewsFeedItemRecipientRows`
* `SuperOffice.CRM.Rows.NewsFeedItemRecordData`
* `SuperOffice.CRM.Rows.NewsFeedItemRecordDataExtensions`
* `SuperOffice.CRM.Rows.NewsFeedItemRow`
* `SuperOffice.CRM.Rows.NewsFeedItemRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateNewsFeedItemCtaRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateNewsFeedItemCtaRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateNewsFeedItemHtmlRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateNewsFeedItemHtmlRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateNewsFeedItemRecipientRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateNewsFeedItemRecipientRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateNewsFeedItemRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateNewsFeedItemRowsFactory`
* `SuperOffice.Data.SQL.CtaFlavorFieldInfo`
* `SuperOffice.Data.SQL.CtaTypeFieldInfo`
* `SuperOffice.Data.SQL.NewsFeedItemStatusFieldInfo`

### Modified Types

#### SuperOffice.CRM.Administration.UserPlugin is Modified

* Deleted items
  * Method `UserPlugin()`
* New items
  * Method `UserPlugin(ILogger<UserPlugin>)`

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_NewsFeedItem_RegisteredAssociateId`
  * Property `LeftOuterJoin_NewsFeedItem_UpdatedAssociateId`
  * Property `LeftOuterJoin_NewsFeedItemRecipient_AssociateId`

#### SuperOffice.CRM.Data.ContactTableInfo is Modified

* New items
  * Property `LeftOuterJoin_NewsFeedItem_ContactId`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.SaleFields is Modified

* New items
  * Field `.SaleFieldsSaleCycle`


##### SuperOffice.CRM.Data.DBC.SaleHistFields is Modified

* New items
  * Field `.SaleHistFieldsSaleCycle`

* New items
  * Field `NewsFeedItem`
  * Field `NewsFeedItemCta`
  * Field `NewsFeedItemHtml`
  * Field `NewsFeedItemRecipient`

##### SuperOffice.CRM.Data.DBC.NewsFeedItemCtaFields is New

##### SuperOffice.CRM.Data.DBC.NewsFeedItemFields is New

##### SuperOffice.CRM.Data.DBC.NewsFeedItemHtmlFields is New

##### SuperOffice.CRM.Data.DBC.NewsFeedItemRecipientFields is New

#### SuperOffice.CRM.Data.PersonTableInfo is Modified

* New items
  * Property `LeftOuterJoin_NewsFeedItem_PersonId`

#### SuperOffice.CRM.Data.ProjectTableInfo is Modified

* New items
  * Property `LeftOuterJoin_NewsFeedItem_ProjectId`

#### SuperOffice.CRM.Data.SaleHistTableInfo is Modified

* New items
  * Property `SaleCycle`

#### SuperOffice.CRM.Data.SaleTableInfo is Modified

* New items
  * Property `LeftOuterJoin_NewsFeedItem_SaleId`
  * Property `SaleCycle`

#### SuperOffice.CRM.Data.Util.ExtraFieldHelper is Modified

* Deleted items
  * Method `ConvertDbExtraFieldToString(Object, FieldInfo, Boolean)`
* New items
  * Method `ConvertDbExtraFieldToString(Object, FieldInfo, Boolean, Int32)`

#### SuperOffice.CRM.Documents.ArchiveTempFileProvider is Modified

* Modified items
  * Method `ReadFileChunkAsync(String, Int64, Byte[], CancellationToken)`
  * Method `ReadFileCompleteAsync(String, CancellationToken)`
  * Method `WriteFileChunkAsync(String, Int64, Byte[], CancellationToken)`
  * Method `WriteFileCompleteAsync(String, Stream, CancellationToken)`

#### SuperOffice.CRM.Documents.SoArc2 is Modified

* Deleted items
  * Method `SoArc2(IConfiguration, ILogger<SoArc2>)`
* Modified items
  * Method `SaveDocumentFromStreamAsync(IDocumentInfo, String[], Stream, CancellationToken)`
* New items
  * Method `SoArc2(IConfiguration, IConfiguration, ILogger<SoArc2>)`

#### SuperOffice.CRM.Documents.SoArc2Helper is Modified

* Deleted items
  * Method `MakeLegalPathName(String)`

#### SuperOffice.CRM.QuoteConnection is Modified

* Deleted items
  * Method `CheckLicensesFor(IQuoteConnector)`

#### SuperOffice.CRM.Rows.ExtraFieldsHelper is Modified

* New items
  * Method `BuildDynamicLinkUrl(SoField, Int32)`
  * Method `IsDynamicLink(SoField)`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(CtaFlavor&, FieldInfo)`
  * Method `ValidateField(CtaType&, FieldInfo)`
  * Method `ValidateField(NewsFeedItemStatus&, FieldInfo)`

#### SuperOffice.CRM.Rows.SaleHistRecordData is Modified

* New items
  * Field `SaleCycle`

#### SuperOffice.CRM.Rows.SaleHistRow is Modified

* New items
  * Property `SaleCycle`

#### SuperOffice.CRM.Rows.SaleRecordData is Modified

* New items
  * Field `SaleCycle`

#### SuperOffice.CRM.Rows.SaleRow is Modified

* New items
  * Property `SaleCycle`
  * Event `OnSaleCycleChange`

#### SuperOffice.CRM.TimeZone.TimeZoneManager is Modified

* New items
  * Method `GetEffectiveDefaultTimeZoneAsync(CancellationToken)`

#### SuperOffice.Data.Cache.CacheBaseV2 is Modified


#### SuperOffice.Data.SoDatabase is Modified

* Deleted items
  * Method `SoDatabase()`
* New items
  * Method `SoDatabase(ILogger<SoDatabase>)`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetNewsFeedItemCtaTableInfo()`
  * Method `GetNewsFeedItemHtmlTableInfo()`
  * Method `GetNewsFeedItemRecipientTableInfo()`
  * Method `GetNewsFeedItemTableInfo()`

#### SuperOffice.License.LicenseManager is Modified

* Deleted items
  * Method `LicenseManager(INSLicenseService, ILogger<LicenseManager>)`
* New items
  * Method `LicenseManager(INSLicenseService)`

#### SuperOffice.Util.ITrackEventDispatcher is Modified

* New items
  * Property `LastEvent`
  * Property `LastEventName`
  * Property `Testing`

#### SuperOffice.Util.TrackEvent is Modified

* New items
  * Method `ToString()`

#### SuperOffice.Util.TrackEventDispatcher is Modified

* New items
  * Property `LastEvent`
  * Property `LastEventName`
  * Property `Testing`


### Assembly: SoDatabase.BusinessLogic

### New Types

* `SuperOffice.CRM.ArchiveLists.MailingFolderExtenderBase`
* `SuperOffice.CRM.ArchiveLists.MailingFolderMailingFolderExtender`
* `SuperOffice.CRM.ArchiveLists.MailingFolderProvider`
* `SuperOffice.CRM.ArchiveLists.MailingsAndFoldersProvider`
* `SuperOffice.CRM.ArchiveLists.MailingsHistoryExtender`
* `SuperOffice.CRM.ArchiveLists.NewsFeedItemContactExtender`
* `SuperOffice.CRM.ArchiveLists.NewsFeedItemExtenderBase`
* `SuperOffice.CRM.ArchiveLists.NewsFeedItemNewsFeedItemExtender`
* `SuperOffice.CRM.ArchiveLists.NewsFeedItemPersonExtender`
* `SuperOffice.CRM.ArchiveLists.NewsFeedItemProjectExtender`
* `SuperOffice.CRM.ArchiveLists.NewsFeedItemProvider`
* `SuperOffice.CRM.ArchiveLists.NewsFeedItemRecipientExtender`
* `SuperOffice.CRM.ArchiveLists.NewsFeedItemSaleExtender`
* `SuperOffice.CRM.Lists.EMailPriorityProvider`
* `SuperOffice.CRM.Lists.NewsFeedItemStatusProvider`
* `SuperOffice.CRM.Notification.AppointmentPushNotificationDispatcher`
* `SuperOffice.CRM.Notification.AppointmentPushNotificationRecipient`
* `SuperOffice.CRM.Notification.AppointmentPushNotificationTask`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.MailingsExtenderBase is Modified

* New items
  * Field `ColMailingFolderId`

#### SuperOffice.CRM.ArchiveLists.SaleExtenderBase is Modified


#### SuperOffice.CRM.Webhooks.WebhookManager is Modified

* New items
  * Method `ResetWorkerScalingForTests()`

#### SuperOffice.CRM.Webhooks.WebhookSlowDispatcher is Modified

* New items
  * Method `ResetWorkerScalingForTests()`

#### SuperOffice.CRM.Webhooks.WebhookTransmitter is Modified

* Modified items
  * Method `ServerCertificateCustomValidationCallback(Object, X509Certificate, X509Chain, SslPolicyErrors)`

#### SuperOffice.Data.Private.FreetextIncrementalIndexer is Modified

* Deleted items
  * Method `FreetextIncrementalIndexer()`
* New items
  * Method `FreetextIncrementalIndexer(ILogger<FreetextIncrementalIndexer>)`

#### SuperOffice.Security.Login.EmailConnectivityPostLoginPlugin is Modified

* Deleted items
  * Method `EmailConnectivityPostLoginPlugin()`
* New items
  * Method `EmailConnectivityPostLoginPlugin(ILogger<EmailConnectivityPostLoginPlugin>)`

#### SuperOffice.Security.Login.VideoMeetingPostLoginPlugin is Modified

* Deleted items
  * Method `VideoMeetingPostLoginPlugin()`
* New items
  * Method `VideoMeetingPostLoginPlugin(ILogger<VideoMeetingPostLoginPlugin>)`


### Assembly: SuperOffice.Plugins

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.CtaFlavor`
* `SuperOffice.CD.Database.CtaType`
* `SuperOffice.CD.Database.NewsFeedItemStatus`
* `SuperOffice.CD.DSL.Database.AiStep2`
* `SuperOffice.CD.DSL.Database.NewsFeedStep1`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_151_Sale_SaleCycle`
* `SuperOffice.CD.DSL.Database.T_NewsFeedItem`
* `SuperOffice.CD.DSL.Database.T_NewsFeedItemCta`
* `SuperOffice.CD.DSL.Database.T_NewsFeedItemHtml`
* `SuperOffice.CD.DSL.Database.T_NewsFeedItemRecipient`

### Modified Types

#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_141_NewFontsSorted is Modified


#### SuperOffice.CD.DSL.Database.T_Sale is Modified

* New items
  * Field `SaleCycle`

#### SuperOffice.CD.DSL.Database.T_SaleHist is Modified

* New items
  * Field `SaleCycle`



