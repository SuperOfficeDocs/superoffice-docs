---
uid: version_12.1.1412.0_changes
date: 16.06.2026
---

Changes from v12.0.342.0 and v12.1.1412.0

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.CustomObject`
* `SuperOffice.CRM.Services.CustomObjectDefinition`
* `SuperOffice.CRM.Services.CustomObjectField`
* `SuperOffice.CRM.Services.CustomObjectMetadata`
* `SuperOffice.CRM.Services.CustomObjectRelation`
* `SuperOffice.CRM.Services.ICustomObjectAgent`

### Modified Types

#### SuperOffice.CRM.Services.IBLOBAgent is Modified

* Deleted items
  * Method `GetChatImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetContactImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetContactImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetPersonImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetPersonImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetProductImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProductThumbnailAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetQuoteLineImageAsStreamAsync(Int32, CancellationToken)`
  * Method `SaveImageStreamAsync(BlobLinkType, Image, String, CancellationToken)`
  * Method `SaveImageStreamFromStreamAsync(BlobLinkType, Stream, String, CancellationToken)`
  * Method `SaveProjectImageAsync(String, Image, CancellationToken)`
  * Method `SaveProjectImageFromStreamAsync(String, Stream, CancellationToken)`
  * Method `SetContactImageAsync(Int32, Image, CancellationToken)`
  * Method `SetContactImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetPersonImageAsync(Int32, Image, CancellationToken)`
  * Method `SetPersonImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductImageAsync(Int32, Image, CancellationToken)`
  * Method `SetProductImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductThumbnailAsync(Int32, Image, CancellationToken)`
  * Method `SetProductThumbnailFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProjectImageAsync(Int32, Image, CancellationToken)`
  * Method `SetProjectImageFromStreamAsync(Int32, Stream, CancellationToken)`
* Modified items
  * Method `GetChatImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetContactImageAsync(Int32, CancellationToken)`
  * Method `GetContactImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetPersonImageAsync(Int32, CancellationToken)`
  * Method `GetPersonImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetProductImageAsync(Int32, CancellationToken)`
  * Method `GetProductThumbnailAsync(Int32, CancellationToken)`
  * Method `GetProjectImageAsync(Int32, CancellationToken)`
  * Method `GetProjectImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetQuoteLineImageAsync(Int32, CancellationToken)`
* New items
  * Method `SaveImageStreamAsync(BlobLinkType, Stream, String, CancellationToken)`
  * Method `SaveProjectImageAsync(String, Stream, CancellationToken)`
  * Method `SetContactImageAsync(Int32, Stream, CancellationToken)`
  * Method `SetPersonImageAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductImageAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductThumbnailAsync(Int32, Stream, CancellationToken)`
  * Method `SetProjectImageAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.ICustomerServiceAgent is Modified

* Deleted items
  * Method `CreateTicketFromMailDataAsync(Int32, String, CancellationToken)`
* New items
  * Method `CreateTicketFromMailDataAsync(Int32, String, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.IListAgent is Modified

* New items
  * Method `GetAllTicketRelationDefinitionEntitiesAsync(CancellationToken)`

#### SuperOffice.CRM.Services.IPersonAgent is Modified

* Deleted items
  * Method `GetPersonImageAsStreamAsync(Int32, CancellationToken)`
  * Method `SetPersonImageAsync(Int32, Image, CancellationToken)`
  * Method `SetPersonImageFromStreamAsync(Int32, Stream, CancellationToken)`
* Modified items
  * Method `GetPersonImageAsync(Int32, CancellationToken)`
* New items
  * Method `SetPersonImageAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.IProjectAgent is Modified

* Deleted items
  * Method `SetProjectImageAsync(Int32, Image, CancellationToken)`
* Modified items
  * Method `GetProjectImageAsync(Int32, CancellationToken)`
* New items
  * Method `SetProjectImageAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.PreviewFaqEntry is Modified

* New items
  * Property `AccessLevel`


### Assembly: SuperOffice.Services.Implementation

### Deleted Types

* `SuperOffice.CRM.Services.Implementation.BL.CustomObjectEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.CustomObjectMetadata`
* `SuperOffice.CRM.Services.Implementation.BL.Relation`

### New Types

* `SuperOffice.CRM.Services.CustomObjectAgent`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICustomObjectDefinitionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICustomObjectImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.CustomObjectDefinitionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.CustomObjectImplementation`

### Modified Types

#### SuperOffice.CRM.Services.AIAgent is Modified

* Deleted items
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ICopilotDataSourceEntityImplementation, ICopilotEntityImplementation, IFormDesignCarrierImplementation, IFormDesignCssImplementation, ISentimentImplementation, INaturalLanguageSearchImplementation, ICreatePhotoBackgroundImplementation, IRagAnswerImplementation, IRagResultImplementation, IRagStatusImplementation, ISummarizerImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ICopilotDataSourceEntityImplementation, ICopilotEntityImplementation, IFormDesignCarrierImplementation, IFormDesignCssImplementation, ISentimentImplementation, INaturalLanguageSearchImplementation, ICreatePhotoBackgroundImplementation, IRagAnswerImplementation, IRagResultImplementation, IRagStatusImplementation, ISummarizerImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* Deleted items
  * Method `AppointmentAgent(IAppointmentImplementation, IAppointmentEntityImplementation, IAppointmentListImplementation, IAppointmentSyncDataImplementation, IDayInformationListImplementation, IMultiAlarmDataImplementation, INextAvailableTimeListImplementation, ISalesActivityImplementation, ISuggestedAppointmentImplementation, ISuggestedAppointmentEntityImplementation, ITaskListItemImplementation, IVideoMeetingReservationImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `AppointmentAgent(IAppointmentImplementation, IAppointmentEntityImplementation, IAppointmentListImplementation, IAppointmentSyncDataImplementation, IDayInformationListImplementation, IMultiAlarmDataImplementation, INextAvailableTimeListImplementation, ISalesActivityImplementation, ISuggestedAppointmentImplementation, ISuggestedAppointmentEntityImplementation, ITaskListItemImplementation, IVideoMeetingReservationImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.ArchiveAgent is Modified

* Deleted items
  * Method `ArchiveAgent(IActivityFilterImplementation, IArchiveConfigurationImplementation, IArchiveListImplementation, IArchiveListResultImplementation, IRelatedDataImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `ArchiveAgent(IActivityFilterImplementation, IArchiveConfigurationImplementation, IArchiveListImplementation, IArchiveListResultImplementation, IRelatedDataImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.AssociateAgent is Modified

* Deleted items
  * Method `AssociateAgent(IAssociateImplementation, IAssociateListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `AssociateAgent(IAssociateImplementation, IAssociateListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.BatchAgent is Modified

* Deleted items
  * Method `BatchAgent(IBatchImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `BatchAgent(IBatchImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.BLOBAgent is Modified

* Deleted items
  * Method `BLOBAgent(IBlobEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `GetChatImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetContactImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetContactImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetPersonImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetPersonImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetProductImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProductThumbnailAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetQuoteLineImageAsStreamAsync(Int32, CancellationToken)`
  * Method `SaveImageStreamAsync(BlobLinkType, Image, String, CancellationToken)`
  * Method `SaveImageStreamFromStreamAsync(BlobLinkType, Stream, String, CancellationToken)`
  * Method `SaveProjectImageAsync(String, Image, CancellationToken)`
  * Method `SaveProjectImageFromStreamAsync(String, Stream, CancellationToken)`
  * Method `SetContactImageAsync(Int32, Image, CancellationToken)`
  * Method `SetContactImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetPersonImageAsync(Int32, Image, CancellationToken)`
  * Method `SetPersonImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductImageAsync(Int32, Image, CancellationToken)`
  * Method `SetProductImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductThumbnailAsync(Int32, Image, CancellationToken)`
  * Method `SetProductThumbnailFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProjectImageAsync(Int32, Image, CancellationToken)`
  * Method `SetProjectImageFromStreamAsync(Int32, Stream, CancellationToken)`
* Modified items
  * Method `GetChatImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetContactImageAsync(Int32, CancellationToken)`
  * Method `GetContactImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetPersonImageAsync(Int32, CancellationToken)`
  * Method `GetPersonImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetProductImageAsync(Int32, CancellationToken)`
  * Method `GetProductThumbnailAsync(Int32, CancellationToken)`
  * Method `GetProjectImageAsync(Int32, CancellationToken)`
  * Method `GetProjectImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetQuoteLineImageAsync(Int32, CancellationToken)`
* New items
  * Method `BLOBAgent(IBlobEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
  * Method `SaveImageStreamAsync(BlobLinkType, Stream, String, CancellationToken)`
  * Method `SaveProjectImageAsync(String, Stream, CancellationToken)`
  * Method `SetContactImageAsync(Int32, Stream, CancellationToken)`
  * Method `SetPersonImageAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductImageAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductThumbnailAsync(Int32, Stream, CancellationToken)`
  * Method `SetProjectImageAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.BulkUpdateAgent is Modified

* Deleted items
  * Method `BulkUpdateAgent(IFieldValueInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `BulkUpdateAgent(IFieldValueInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.ChatAgent is Modified

* Deleted items
  * Method `ChatAgent(IChatPresenceImplementation, IChatSessionEntityImplementation, IChatTopicAgentImplementation, IChatTopicEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `ChatAgent(IChatPresenceImplementation, IChatSessionEntityImplementation, IChatTopicAgentImplementation, IChatTopicEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.ContactAgent is Modified

* Deleted items
  * Method `ContactAgent(IContactImplementation, IContactActivityListImplementation, IContactEntityImplementation, IContactListImplementation, IPreviewContactImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `ContactAgent(IContactImplementation, IContactActivityListImplementation, IContactEntityImplementation, IContactListImplementation, IPreviewContactImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.CRMScriptAgent is Modified

* Deleted items
  * Method `CRMScriptAgent(IScriptImplementation, ICRMScriptEntityImplementation, ITriggerScriptEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `CRMScriptAgent(IScriptImplementation, ICRMScriptEntityImplementation, ITriggerScriptEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.CustomerServiceAgent is Modified

* Deleted items
  * Method `CustomerServiceAgent(IChatSessionImplementation, ICsFeatureToggleImplementation, ICsSessionKeyImplementation, ICustomerCenterConfigImplementation, ICustomerServiceConfigImplementation, ICustomerServiceStartupImplementation, IEventDataImplementation, IMailboxImplementation, IMailboxEntityImplementation, IPreviewFaqEntryImplementation, IPreviewQuickReplyImplementation, IPreviewReplyTemplateImplementation, IReplyTemplateParsedImplementation, ISmsConfigImplementation, ISmtpTestResultImplementation, IStatisticsDataSetImplementation, ISystemTemplateSettingsImplementation, ITicketInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `CreateTicketFromMailDataAsync(Int32, String, CancellationToken)`
* New items
  * Method `CustomerServiceAgent(IChatSessionImplementation, ICsFeatureToggleImplementation, ICsSessionKeyImplementation, ICustomerCenterConfigImplementation, ICustomerServiceConfigImplementation, ICustomerServiceStartupImplementation, IEventDataImplementation, IMailboxImplementation, IMailboxEntityImplementation, IPreviewFaqEntryImplementation, IPreviewQuickReplyImplementation, IPreviewReplyTemplateImplementation, IReplyTemplateParsedImplementation, ISmsConfigImplementation, ISmtpTestResultImplementation, IStatisticsDataSetImplementation, ISystemTemplateSettingsImplementation, ITicketInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
  * Method `CreateTicketFromMailDataAsync(Int32, String, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.DashAgent is Modified

* Deleted items
  * Method `DashAgent(IDashImplementation, IDashCollectionImplementation, IDashThemeImplementation, IDashTileImplementation, IDashTileDefinitionImplementation, IDashTileHtmlImplementation, IPreviewDashImplementation, IPreviewDashTileImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `DashAgent(IDashImplementation, IDashCollectionImplementation, IDashThemeImplementation, IDashTileImplementation, IDashTileDefinitionImplementation, IDashTileHtmlImplementation, IPreviewDashImplementation, IPreviewDashTileImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.DatabaseAgent is Modified

* Deleted items
  * Method `DatabaseAgent(IDictionaryStepInformationImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `DatabaseAgent(IDictionaryStepInformationImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.DatabaseTableAgent is Modified

* Deleted items
  * Method `DatabaseTableAgent(ITableRecordImplementation, IMassOperationResultImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `DatabaseTableAgent(ITableRecordImplementation, IMassOperationResultImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.DiagnosticsAgent is Modified

* Deleted items
  * Method `DiagnosticsAgent(IAnalyticsDataImplementation, ICacheImplementation, ICacheInvalidationImplementation, IEntityCountsImplementation, ILoggingImplementation, IUsageStatsImplementation, ISystemMessageListImplementation, ITableManagerImplementation, IInstallationImplementation, ITicketUsageImplementation, IWebAppUsageImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `DiagnosticsAgent(IAnalyticsDataImplementation, ICacheImplementation, ICacheInvalidationImplementation, IEntityCountsImplementation, ILoggingImplementation, IUsageStatsImplementation, ISystemMessageListImplementation, ITableManagerImplementation, IInstallationImplementation, ITicketUsageImplementation, IWebAppUsageImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.DocumentAgent is Modified

* Deleted items
  * Method `DocumentAgent(IDocumentImplementation, IDocumentEntityImplementation, IDocumentListImplementation, IDocumentPreviewImplementation, ISuggestedDocumentEntityImplementation, ITemplateVariablesParametersImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `DocumentAgent(IDocumentImplementation, IDocumentEntityImplementation, IDocumentListImplementation, IDocumentPreviewImplementation, ISuggestedDocumentEntityImplementation, ITemplateVariablesParametersImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.DocumentMigrationAgent is Modified

* Deleted items
  * Method `DocumentMigrationAgent(IDocumentMigrationItemListImplementation, IDocumentTemplateMigrationListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `DocumentMigrationAgent(IDocumentMigrationItemListImplementation, IDocumentTemplateMigrationListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.EMailAgent is Modified

* Deleted items
  * Method `EMailAgent(IEMailAccountImplementation, IEMailAddressImplementation, IEMailAppointmentImplementation, IEMailAttachmentImplementation, IEMailConnectionInfoImplementation, IEMailConnectionInfoExtendedImplementation, IEMailCustomHeaderImplementation, IEMailEntityImplementation, IEMailEnvelopeImplementation, IEMailFolderImplementation, IEMailSOInfoImplementation, ISyncUserAccountImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `EMailAgent(IEMailAccountImplementation, IEMailAddressImplementation, IEMailAppointmentImplementation, IEMailAttachmentImplementation, IEMailConnectionInfoImplementation, IEMailConnectionInfoExtendedImplementation, IEMailCustomHeaderImplementation, IEMailEntityImplementation, IEMailEnvelopeImplementation, IEMailFolderImplementation, IEMailSOInfoImplementation, ISyncUserAccountImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.ErpSyncAgent is Modified

* Deleted items
  * Method `ErpSyncAgent(IErpConnectionImplementation, IErpConnectionDataImplementation, IErpConnectionListMappingContainerImplementation, IErpSyncFieldValueImplementation, IErpSyncActorTypeMappingImplementation, IErpSyncConnectionSummaryImplementation, IErpSyncConnectorEntityImplementation, IErpSyncDefaultValueImplementation, IErpSyncEngineImplementation, IErpSyncEngineStatusImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `ErpSyncAgent(IErpConnectionImplementation, IErpConnectionDataImplementation, IErpConnectionListMappingContainerImplementation, IErpSyncFieldValueImplementation, IErpSyncActorTypeMappingImplementation, IErpSyncConnectionSummaryImplementation, IErpSyncConnectorEntityImplementation, IErpSyncDefaultValueImplementation, IErpSyncEngineImplementation, IErpSyncEngineStatusImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.FavouriteAgent is Modified

* Deleted items
  * Method `FavouriteAgent(IFavouriteImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `FavouriteAgent(IFavouriteImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.FindAgent is Modified

* Deleted items
  * Method `FindAgent(IFindImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `FindAgent(IFindImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.ForeignSystemAgent is Modified

* Deleted items
  * Method `ForeignSystemAgent(IForeignAppEntityImplementation, IForeignDeviceImplementation, IForeignKeyImplementation, IForeignKeyListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `ForeignSystemAgent(IForeignAppEntityImplementation, IForeignDeviceImplementation, IForeignKeyImplementation, IForeignKeyListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.FreeTextAgent is Modified

* Deleted items
  * Method `FreeTextAgent(IFreeTextImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `FreeTextAgent(IFreeTextImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IBlobEntityImplementation is Modified

* Deleted items
  * Method `GetChatImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetContactImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetContactImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetPersonImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetPersonImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetProductImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProductThumbnailAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetQuoteLineImageAsStreamAsync(Int32, CancellationToken)`
  * Method `SaveImageStreamAsync(BlobLinkType, Image, String, CancellationToken)`
  * Method `SaveImageStreamFromStreamAsync(BlobLinkType, Stream, String, CancellationToken)`
  * Method `SaveProjectImageAsync(String, Image, CancellationToken)`
  * Method `SaveProjectImageFromStreamAsync(String, Stream, CancellationToken)`
  * Method `SetContactImageAsync(Int32, Image, CancellationToken)`
  * Method `SetContactImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetPersonImageAsync(Int32, Image, CancellationToken)`
  * Method `SetPersonImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductImageAsync(Int32, Image, CancellationToken)`
  * Method `SetProductImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductThumbnailAsync(Int32, Image, CancellationToken)`
  * Method `SetProductThumbnailFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProjectImageAsync(Int32, Image, CancellationToken)`
  * Method `SetProjectImageFromStreamAsync(Int32, Stream, CancellationToken)`
* Modified items
  * Method `GetChatImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetContactImageAsync(Int32, CancellationToken)`
  * Method `GetContactImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetPersonImageAsync(Int32, CancellationToken)`
  * Method `GetPersonImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetProductImageAsync(Int32, CancellationToken)`
  * Method `GetProductThumbnailAsync(Int32, CancellationToken)`
  * Method `GetProjectImageAsync(Int32, CancellationToken)`
  * Method `GetProjectImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetQuoteLineImageAsync(Int32, CancellationToken)`
* New items
  * Method `SaveImageStreamAsync(BlobLinkType, Stream, String, CancellationToken)`
  * Method `SaveProjectImageAsync(String, Stream, CancellationToken)`
  * Method `SetContactImageAsync(Int32, Stream, CancellationToken)`
  * Method `SetPersonImageAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductImageAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductThumbnailAsync(Int32, Stream, CancellationToken)`
  * Method `SetProjectImageAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IPersonEntityImplementation is Modified

* Deleted items
  * Method `GetPersonImageAsStreamAsync(Int32, CancellationToken)`
  * Method `SetPersonImageAsync(Int32, Image, CancellationToken)`
  * Method `SetPersonImageFromStreamAsync(Int32, Stream, CancellationToken)`
* Modified items
  * Method `GetPersonImageAsync(Int32, CancellationToken)`
* New items
  * Method `SetPersonImageAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectEntityImplementation is Modified

* Deleted items
  * Method `SetProjectImageAsync(Int32, Image, CancellationToken)`
* Modified items
  * Method `GetProjectImageAsync(Int32, CancellationToken)`
* New items
  * Method `SetProjectImageAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketInfoImplementation is Modified

* Deleted items
  * Method `CreateTicketFromMailDataAsync(Int32, String, CancellationToken)`
* New items
  * Method `CreateTicketFromMailDataAsync(Int32, String, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketRelationDefinitionEntityImplementation is Modified

* New items
  * Method `GetAllTicketRelationDefinitionEntitiesAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.IncomingMessageImplementation is Modified

* Deleted items
  * Method `IncomingMessageImplementation()`
* New items
  * Method `IncomingMessageImplementation(MessagingManager)`

#### SuperOffice.CRM.Services.Implementation.BL.MessageDeliveryStatusImplementation is Modified

* Deleted items
  * Method `MessageDeliveryStatusImplementation()`
* New items
  * Method `MessageDeliveryStatusImplementation(MessagingManager)`

#### SuperOffice.CRM.Services.Implementation.BL.OutgoingMessageImplementation is Modified

* Deleted items
  * Method `OutgoingMessageImplementation()`
* New items
  * Method `OutgoingMessageImplementation(MessagingManager)`

#### SuperOffice.CRM.Services.Implementation.BL.ProviderInfoImplementation is Modified

* Deleted items
  * Method `ProviderInfoImplementation()`
* Modified items
  * Method `GetPluginsAsync(CancellationToken)`
* New items
  * Method `ProviderInfoImplementation(MessagingManager)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketInfoImplementation is Modified

* Deleted items
  * Method `CreateTicketFromMailDataAsync(Int32, String, CancellationToken)`
* New items
  * Method `CreateTicketFromMailDataAsync(Int32, String, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.ImportAgent is Modified

* Deleted items
  * Method `ImportAgent(IImportLineImplementation, IImportErpDataImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `ImportAgent(IImportLineImplementation, IImportErpDataImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.LicenseAgent is Modified

* Deleted items
  * Method `LicenseAgent(ILicenseImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `LicenseAgent(ILicenseImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.ListAgent is Modified

* Deleted items
  * Method `ListAgent(IAmountClassEntityImplementation, IAutomatedCategoryUpdateImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryEntityImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketRelationDefinitionEntityImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `ListAgent(IAmountClassEntityImplementation, IAutomatedCategoryUpdateImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryEntityImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketRelationDefinitionEntityImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
  * Method `GetAllTicketRelationDefinitionEntitiesAsync(CancellationToken)`

#### SuperOffice.CRM.Services.MarketingAgent is Modified

* Deleted items
  * Method `MarketingAgent(IAvailableFontImplementation, IFormEntityImplementation, IFormFieldRestrictionImplementation, IFormSubmissionEntityImplementation, IMailingStatisticsImplementation, IPreviewMailingImplementation, IPreviewMailingHeaderImplementation, IShipmentMessageBlockEntityImplementation, IShipmentMessageEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `MarketingAgent(IAvailableFontImplementation, IFormEntityImplementation, IFormFieldRestrictionImplementation, IFormSubmissionEntityImplementation, IMailingStatisticsImplementation, IPreviewMailingImplementation, IPreviewMailingHeaderImplementation, IShipmentMessageBlockEntityImplementation, IShipmentMessageEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.MDOAgent is Modified

* Deleted items
  * Method `MDOAgent(IMDOListImplementation, ISelectableMDOListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `MDOAgent(IMDOListImplementation, ISelectableMDOListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.MessagingAgent is Modified

* Deleted items
  * Method `MessagingAgent(IIncomingMessageImplementation, IMessageDeliveryStatusImplementation, IOutgoingMessageImplementation, IProviderInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `MessagingAgent(IIncomingMessageImplementation, IMessageDeliveryStatusImplementation, IOutgoingMessageImplementation, IProviderInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.NumberAllocationAgent is Modified

* Deleted items
  * Method `NumberAllocationAgent(IRefCountEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `NumberAllocationAgent(IRefCountEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.PersonAgent is Modified

* Deleted items
  * Method `PersonAgent(IConsentPersonImplementation, IPersonImplementation, IPersonEntityImplementation, IPersonImageImplementation, IPersonListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `GetPersonImageAsStreamAsync(Int32, CancellationToken)`
  * Method `SetPersonImageAsync(Int32, Image, CancellationToken)`
  * Method `SetPersonImageFromStreamAsync(Int32, Stream, CancellationToken)`
* Modified items
  * Method `GetPersonImageAsync(Int32, CancellationToken)`
* New items
  * Method `PersonAgent(IConsentPersonImplementation, IPersonImplementation, IPersonEntityImplementation, IPersonImageImplementation, IPersonListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
  * Method `SetPersonImageAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.PhoneListAgent is Modified

* Deleted items
  * Method `PhoneListAgent(IPhoneListImplementation, IPhoneListPreferencesImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `PhoneListAgent(IPhoneListImplementation, IPhoneListPreferencesImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.PocketAgent is Modified

* Deleted items
  * Method `PocketAgent(ICallerIDImplementation, IPocketStartupDataImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `PocketAgent(ICallerIDImplementation, IPocketStartupDataImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.PreferenceAgent is Modified

* Deleted items
  * Method `PreferenceAgent(IPreferenceImplementation, IPreferenceDescriptionImplementation, IPreferenceDescriptionLineImplementation, IPreferenceListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `PreferenceAgent(IPreferenceImplementation, IPreferenceDescriptionImplementation, IPreferenceDescriptionLineImplementation, IPreferenceListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.ProjectAgent is Modified

* Deleted items
  * Method `ProjectAgent(IProjectImplementation, IProjectEntityImplementation, IProjectEventImplementation, IProjectEventEntityImplementation, IProjectEventListImplementation, IProjectListImplementation, IProjectMemberImplementation, IProjectMemberListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `SetProjectImageAsync(Int32, Image, CancellationToken)`
* Modified items
  * Method `GetProjectImageAsync(Int32, CancellationToken)`
* New items
  * Method `ProjectAgent(IProjectImplementation, IProjectEntityImplementation, IProjectEventImplementation, IProjectEventEntityImplementation, IProjectEventListImplementation, IProjectListImplementation, IProjectMemberImplementation, IProjectMemberListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
  * Method `SetProjectImageAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.QuoteAgent is Modified

* Deleted items
  * Method `QuoteAgent(IFieldMetadataImplementation, IPriceListImplementation, IProductImplementation, IQuoteImplementation, IQuoteAlternativeImplementation, IQuoteConnectionImplementation, IQuoteEntityImplementation, IQuoteLineImplementation, IQuoteLineConfigurationImplementation, IQuoteVersionImplementation, IQuoteVersionAttachmentImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `QuoteAgent(IFieldMetadataImplementation, IPriceListImplementation, IProductImplementation, IQuoteImplementation, IQuoteAlternativeImplementation, IQuoteConnectionImplementation, IQuoteEntityImplementation, IQuoteLineImplementation, IQuoteLineConfigurationImplementation, IQuoteVersionImplementation, IQuoteVersionAttachmentImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.RelationAgent is Modified

* Deleted items
  * Method `RelationAgent(IContactRelationEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `RelationAgent(IContactRelationEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.ReportAgent is Modified

* Deleted items
  * Method `ReportAgent(IReportLabelLayoutEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `ReportAgent(IReportLabelLayoutEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.ResourceAgent is Modified

* Deleted items
  * Method `ResourceAgent(IResourceOverrideImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `ResourceAgent(IResourceOverrideImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.SaintAgent is Modified

* Deleted items
  * Method `SaintAgent(ISaintConfigurationImplementation, IStatusMonitorImplementation, IStatusMonitorPeriodsImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `SaintAgent(ISaintConfigurationImplementation, IStatusMonitorImplementation, IStatusMonitorPeriodsImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.SaleAgent is Modified

* Deleted items
  * Method `SaleAgent(ISaleImplementation, ISaleEntityImplementation, ISaleListImplementation, ISaleStakeholderImplementation, ISaleStakeholderListImplementation, ISaleSummaryImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `SaleAgent(ISaleImplementation, ISaleEntityImplementation, ISaleListImplementation, ISaleStakeholderImplementation, ISaleStakeholderListImplementation, ISaleSummaryImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.SelectionAgent is Modified

* Deleted items
  * Method `SelectionAgent(IBoardViewSettingsBaseImplementation, ISelectionEntityImplementation, ISelectionForFindImplementation, ISelectionSummaryItemImplementation, ITypicalSearchesImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `SelectionAgent(IBoardViewSettingsBaseImplementation, ISelectionEntityImplementation, ISelectionForFindImplementation, ISelectionSummaryItemImplementation, ITypicalSearchesImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.SentryAgent is Modified

* Deleted items
  * Method `SentryAgent(ISentryImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `SentryAgent(ISentryImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.TargetsAgent is Modified

* Deleted items
  * Method `TargetsAgent(ITargetAssignmentImplementation, ITargetDimensionImplementation, ITargetGroupImplementation, ITargetRevisionImplementation, ITargetRevisionHistoryImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `TargetsAgent(ITargetAssignmentImplementation, ITargetDimensionImplementation, ITargetGroupImplementation, ITargetRevisionImplementation, ITargetRevisionHistoryImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* Deleted items
  * Method `TicketAgent(IAttachmentEntityImplementation, ITicketImplementation, ITicketEntityImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketRelationEntityImplementation, ITicketSummaryItemImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `TicketAgent(IAttachmentEntityImplementation, ITicketImplementation, ITicketEntityImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketRelationEntityImplementation, ITicketSummaryItemImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.TimeZoneAgent is Modified

* Deleted items
  * Method `TimeZoneAgent(IPreferredTimeZoneImplementation, IRemoteTimeZoneMethodsImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `TimeZoneAgent(IPreferredTimeZoneImplementation, IRemoteTimeZoneMethodsImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.UserAgent is Modified

* Deleted items
  * Method `UserAgent(IAccessGatewayInfoImplementation, ICredentialImplementation, IRoleImplementation, IRoleEntityImplementation, IServiceAuthImplementation, ITokenManagementInfoImplementation, IUntrustedCredentialsImplementation, IUserImplementation, IUserGroupImplementation, IUserGroupListImplementation, IUserInfoImplementation, IUserInfoListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `UserAgent(IAccessGatewayInfoImplementation, ICredentialImplementation, IRoleImplementation, IRoleEntityImplementation, IServiceAuthImplementation, ITokenManagementInfoImplementation, IUntrustedCredentialsImplementation, IUserImplementation, IUserGroupImplementation, IUserGroupListImplementation, IUserInfoImplementation, IUserInfoListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.UserDefinedFieldInfoAgent is Modified

* Deleted items
  * Method `UserDefinedFieldInfoAgent(IFieldInfoBaseImplementation, IUserDefinedFieldInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `UserDefinedFieldInfoAgent(IFieldInfoBaseImplementation, IUserDefinedFieldInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.ViewStateAgent is Modified

* Deleted items
  * Method `ViewStateAgent(ILiveUiConfigImplementation, IHistoryImplementation, IHistoryListImplementation, IUiEventImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `ViewStateAgent(ILiveUiConfigImplementation, IHistoryImplementation, IHistoryListImplementation, IUiEventImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.WebhookAgent is Modified

* Deleted items
  * Method `WebhookAgent(IWebhookImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `WebhookAgent(IWebhookImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`

#### SuperOffice.CRM.Services.WorkflowAgent is Modified

* Deleted items
  * Method `WorkflowAgent(IEmailFlowImplementation, IWorkflowEventImplementation, IWorkflowEventResultImplementation, IWorkflowFilterImplementation, IWorkflowGoalImplementation, IWorkflowStepBaseImplementation, IWorkflowStepOptionBaseImplementation, IWorkflowTriggerImplementation, IWorkflowWaitForActionImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `WorkflowAgent(IEmailFlowImplementation, IWorkflowEventImplementation, IWorkflowEventResultImplementation, IWorkflowFilterImplementation, IWorkflowGoalImplementation, IWorkflowStepBaseImplementation, IWorkflowStepOptionBaseImplementation, IWorkflowTriggerImplementation, IWorkflowWaitForActionImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.Events.SoEventManager`
* `SuperOffice.Events.SoGlobalFlush`
* `SuperOffice.Security.Principal.CurrentWindowsIdentitySupplier`

### New Types

* `SuperOffice.Util.IStructurePatchingHelper`
* `SuperOffice.Util.StructurePatchingTypeCache`
* `SuperOffice.Util.TypeAction`

### Modified Types

#### Microsoft.Extensions.DependencyInjection.NetServerCoreOptionsBuilder is Modified

* Deleted items
  * Method `UseOnPremAD()`

#### SuperOffice.Configuration.ConfigFile is Modified

* Deleted items

##### SuperOffice.Configuration.ConfigFile.CssSprite is Deleted

##### SuperOffice.Configuration.ConfigFile.Factory is Deleted

##### SuperOffice.Configuration.ConfigFile.ICssSpriteConfiguration is Deleted

##### SuperOffice.Configuration.ConfigFile.IDataSessionConfiguration is Deleted

##### SuperOffice.Configuration.ConfigFile.IFactoryConfiguration is Deleted

##### SuperOffice.Configuration.ConfigFile.IInfrastructureConfiguration is Deleted

##### SuperOffice.Configuration.ConfigFile.IIntellisyncConnectorConfiguration is Deleted

##### SuperOffice.Configuration.ConfigFile.Infrastructure is Deleted

##### SuperOffice.Configuration.ConfigFile.IntellisyncConnector is Deleted

##### SuperOffice.Configuration.ConfigFile.IScriptingConfiguration is Deleted

##### SuperOffice.Configuration.ConfigFile.ISecurityActiveDirectoryCredentialPluginConfiguration is Deleted

##### SuperOffice.Configuration.ConfigFile.ISecuritySentryConfiguration is Deleted

##### SuperOffice.Configuration.ConfigFile.ISyncConfiguration is Deleted

##### SuperOffice.Configuration.ConfigFile.IThreadingConfiguration is Deleted

##### SuperOffice.Configuration.ConfigFile.Scripting is Deleted

##### SuperOffice.Configuration.ConfigFile.Sync is Deleted

##### SuperOffice.Configuration.ConfigFile.Threading is Deleted
* Modified items

##### SuperOffice.Configuration.ConfigFile.Data is Modified

* Deleted items

##### .Data.Session is Deleted


##### SuperOffice.Configuration.ConfigFile.Security is Modified

* Deleted items

##### .Security.ActiveDirectoryCredentialPlugin is Deleted

##### .Security.Sentry is Deleted


#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Deleted items

##### SuperOffice.CRM.UserPreferenceStrings.Phone is Deleted

##### SuperOffice.CRM.UserPreferenceStrings.SentryAddonNames is Deleted
* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.Mail is Modified

* New items
  * Field `.MailShowMyEmails`

* New items

##### SuperOffice.CRM.UserPreferenceStrings.License is New

#### SuperOffice.Data.TicketLogAction is Modified

* New items
  * Field `Message_DeleteMessage`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_WEBHOOKS_CRMSCRIPT_DISABLED_TOOLTIP`
  * Field `SR_FDLG_ADDPERIOD`
  * Field `SR_FENCING_PROJECT_MAX_GENERAL`
  * Field `SR_FORMS_NOT_SELECTED`
  * Field `SR_MM_TO`
  * Field `SR_PD_Functions_JoinPilotForStartPage_DESC`
  * Field `SR_PD_Functions_JoinPilotForStartPage_NAME`
  * Field `SR_PROJECT_COMPLETED_DISABLED`
  * Field `SR_TICKET_ARCHIVE_SPAM_SELECTED_REQUEST_CONFIRMATION`
  * Field `SR_TICKET_DRAFT_HAS_INVISIBLE_CHANGES`
  * Field `SR_TICKET_OPEN_FULL_VIEW`
  * Field `SR_TICKET_OPEN_IN_DIALOG`
  * Field `SR_TICKET_RESTRICTED_FAQ`
  * Field `SR_WEBHOOK_SEE_DETAILS`

#### SuperOffice.Security.Principal.INSAuthenticator is Modified

* New items
  * Method `AuthenticateAsync(IEnumerable<ClaimsIdentity>, CancellationToken)`

#### SuperOffice.SoSession is Modified

* New items
  * Method `AuthenticateAsync(ClaimsIdentity, CancellationToken, Claim[])`
  * Method `SignInToCurrentContext()`

#### SuperOffice.Threading.AsyncQueue<TItem> is Modified

* New items
  * Property `Count`
  * Method `DrainQueue()`

#### SuperOffice.Threading.AsyncQueueBase<TItem> is Modified

* New items
  * Property `Count`
  * Method `DrainQueue()`

#### SuperOffice.Threading.IAsyncQueueBase<TItem> is Modified

* New items
  * Property `Count`
  * Method `DrainQueue()`

#### SuperOffice.Util.ImageStreamUtils is Modified

* New items
  * Method `FitToPng(Stream, Int32, Int32)`
  * Method `FitToPngBytes(Stream, Int32, Int32)`
  * Method `GetNoPhotoPng()`
  * Method `GetTransparentPixelPng()`

#### SuperOffice.Util.StructurePatchingHelper is Modified

* Deleted items
  * Method `ApplyActions(Object, Attribute[], String, Dictionary<Type, TypeAction>, Action<Object>)`
  * Method `ApplyActions(Object, Dictionary<Type, TypeAction>, Action<Object>)`

##### SuperOffice.Util.StructurePatchingHelper.TypeAction is Deleted
* New items
  * Method `StructurePatchingHelper(StructurePatchingTypeCache)`
  * Method `ApplyActions(Object, Attribute[], String, Dictionary<Type, TypeAction>, Action<Object>)`
  * Method `ApplyActions(Object, Dictionary<Type, TypeAction>, Action<Object>)`


### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.Security.ISentryPlugin`
* `SuperOffice.CRM.Security.ISentryPluginQueryTableUpdater`
* `SuperOffice.CRM.Security.SentryPluginAttribute`
* `SuperOffice.CRM.Security.SentryPluginQueryTableUpdaterAttribute`

### New Types

* `SuperOffice.CRM.Webhooks.WebhookBannerNotification`
* `SuperOffice.CRM.Webhooks.WebhookBannerQueue`
* `SuperOffice.Data.SQL.ArgumentField`
* `SuperOffice.Data.SQL.Concat`

### Modified Types

#### SuperOffice.CRM.Cache.AssociateCache is Modified

* Deleted items
  * Method `GetAssociateImageAsync(Int32, Int32, Int32)`
* Modified items
  * Method `GetPersonImageAsync(Int32)`

#### SuperOffice.CRM.Cache.MDOPreferenceCache is Modified

* New items
  * Method `IsGroupingAllowed(String, String)`

#### SuperOffice.CRM.Security.ProjectFencingCache is Modified

* New items
  * Method `IsCacheInvalidatedAsync(String, Int32, PrivateSave, CancellationToken)`

#### SuperOffice.CRM.Security.RelationsSentry is Modified

* New items
  * Method `GetMainRight()`

#### SuperOffice.CRM.Security.Sentry is Modified

* Deleted items
  * Method `DemandPlugins()`

#### SuperOffice.CRM.Ticket.RelatedTicketInfo is Modified

* New items
  * Field `BaseStatus`
  * Field `RelationComment`
  * Field `RelationCreatedAt`
  * Field `TicketCreatedAt`
  * Field `TicketStatus`
  * Field `TicketStatusDisplayValue`

#### SuperOffice.CRM.Ticket.TicketRelationHelper is Modified

* Deleted items
  * Method `GetTicketRelationsInfoAsync(Int32, Int32, Int32, Int32, CancellationToken)`
* New items
  * Method `GetTicketRelationsInfoAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Webhooks.ISystemWebhookPlugin is Modified

* Deleted items
  * Method `SaveWebhookAsync(Webhook)`
* New items
  * Method `SaveWebhookAsync(Webhook, Boolean)`

#### SuperOffice.CRM.Webhooks.IWebhookManager is Modified

* Deleted items
  * Method `SaveWebhookAsync(Webhook)`
* New items
  * Method `SaveWebhookAsync(Webhook, Boolean)`

#### SuperOffice.Data.Cache.CacheBlockLogger is Modified

* New items
  * Method `KeepAll()`

#### SuperOffice.Data.DatabaseStepAttribute is Modified

* Deleted items
  * Method `DatabaseStepAttribute(String, Int32, ReleaseState)`
* New items
  * Method `DatabaseStepAttribute(String, Int32)`

#### SuperOffice.Data.Dialect.Dialect is Modified

* Deleted items
  * Method `GenerateCaseInsensitivity(FieldInfo, Parameter, String)`
* New items
  * Method `QuoteAliasIfNeeded(String)`
  * Method `ToSql(ArgumentField)`
  * Method `ToSql(Concat)`

#### SuperOffice.Data.Dictionary.SoField is Modified

* New items
  * Method `ConvertFieldDataTypeToDictFieldType(FieldDataType)`

#### SuperOffice.Data.S is Modified

* Modified items

##### SuperOffice.Data.S.FieldExpression is Modified

* New items
  * Method `.FieldExpressionConcat(Argument[])`


#### SuperOffice.Data.SoConnection is Modified

* New items
  * Method `OpenAsync(CancellationToken)`

#### SuperOffice.Data.SoDatabase is Modified

* Deleted items
  * Property `IgnoreADUsernameAuthentication`

#### SuperOffice.Data.SQL.Aggregation is Modified

* New items
  * Method `GetReferencedFields()`

#### SuperOffice.Data.SQL.Argument is Modified

* Modified items
  * Method `Between(Argument, Argument)`
  * Method `Equal(Argument)`
  * Method `GreaterThan(Argument)`
  * Method `GreaterThanOrEqual(Argument)`
  * Method `HasAll(Argument[])`
  * Method `HasAny(Argument[])`
  * Method `HasFlag(Argument)`
  * Method `HasNoFlag(Argument)`
  * Method `In(Argument[])`
  * Method `IsNotNull()`
  * Method `IsNull()`
  * Method `LessThan(Argument)`
  * Method `LessThanOrEqual(Argument)`
  * Method `Like(Argument)`
  * Method `Like(String)`
  * Method `MissingAll(Argument[])`
  * Method `MissingAny(Argument[])`
  * Method `NotBetween(Argument, Argument)`
  * Method `NotIn(Argument[])`
  * Method `NotLike(Argument)`
  * Method `UnEqual(Argument)`
* New items
  * Method `GetReferencedFields()`

#### SuperOffice.Data.SQL.ArgumentFunction is Modified

* New items
  * Method `GetReferencedFields()`

#### SuperOffice.Data.SQL.Case is Modified

* New items
  * Method `GetReferencedFields()`

#### SuperOffice.Data.SQL.FieldInfo is Modified

* New items
  * Method `GetReferencedFields()`

#### SuperOffice.Data.SQL.MathematicalExpression is Modified

* New items
  * Method `GetReferencedFields()`

#### SuperOffice.Data.SQL.TableInfo is Modified

* Deleted items
  * Property `IsDictionaryTable`
  * Property `ProtAll`

#### SuperOffice.Data.TablesInfo is Modified


#### SuperOffice.Util.IAppointmentUtility is Modified

* Modified items
  * Method `GetConnectionInfoAsync()`


### Assembly: SoDatabase.BusinessLogic

### Deleted Types

* `SuperOffice.CRM.ArchiveLists.IRestrictionStorage`
* `SuperOffice.CRM.ArchiveLists.IRestrictionStorageMappingConfiguration`
* `SuperOffice.CRM.ArchiveLists.RestrictionStorageFactory`
* `SuperOffice.CRM.ArchiveLists.RestrictionStoragePluginAttribute`
* `SuperOffice.Data.Dialect.Oracle12`
* `SuperOffice.Data.Dialect.OracleCommon`
* `SuperOffice.Data.Dialect.OracleMassOperations`
* `SuperOffice.Data.Dialect.OracleOperations`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentExtenderBase is Modified

* Deleted items
  * Method `ModifyQuery()`
  * Method `ProcessOrderBy()`

#### SuperOffice.CRM.ArchiveLists.ContactExtenderBase is Modified

* Deleted items
  * Method `StandardNameDept()`

#### SuperOffice.CRM.ArchiveLists.ExtensibleColumnsBase is Modified

* Modified items
  * Method `MapSimpleCustomField(FieldInfo, ArchiveColumnInfo[])`
  * Method `WantColumnForAnything(ArchiveColumnInfo[])`
  * Method `WantColumnForAnything(String[])`
  * Method `WantColumnForOrderBy(ArchiveColumnInfo[])`
  * Method `WantColumnForOrderBy(String[])`
  * Method `WantColumnForOutput(ArchiveColumnInfo[])`
  * Method `WantColumnForOutput(List<ArchiveColumnInfo>)`
  * Method `WantColumnForOutput(String[])`
  * Method `WantColumnForRestriction(ArchiveColumnInfo[])`
  * Method `WantColumnForRestriction(String[])`

#### SuperOffice.CRM.ArchiveLists.Joiners.AppointmentTextConversionExtender is Modified

* Deleted items
  * Method `GetDescription(SoDataReader)`
  * Method `RequestDescription()`
  * Method `RequestDescriptionForRestriction()`

#### SuperOffice.CRM.ArchiveLists.PersonContactExtenderHelper is Modified

* Deleted items
  * Method `GetNameAndDepartment(SoDataReader, ContactTableInfo, Boolean)`
* New items
  * Field `C_NameDepartmentColumnBaseName`
  * Method `CreateNameAndDepartmentArgumentField(ArchiveSelect, ArchiveColumnInfo)`
  * Method `GetNameAndDepartment(SoDataReader, Boolean, ArchiveColumnInfo)`
  * Method `PopulateNameAndDepartmentFromReader(SoDataReader, ArchiveRow, Boolean, ArchiveColumnInfo)`
  * Method `SetContactTableInfo(ContactTableInfo)`
  * Method `StandardNameDepartmentColumn()`

#### SuperOffice.CRM.ArchiveLists.RestrictionCriteriaStorage is Modified

* New items
  * Method `GetProvider(String)`
  * Method `GetProvider(String, String)`
  * Method `GetRestrictionFromAllGroupsViaStorage(ArchiveRestrictionInfo[], String, String, String, String)`
  * Method `GetRestrictionFromAllGroupsViaStorage(ArchiveRestrictionInfo[], String, String, String, String, String)`
  * Method `GetRestrictionViaStorage(ArchiveRestrictionInfo[], String, String, String, String)`
  * Method `GetRestrictionViaStorage(ArchiveRestrictionInfo[], String, String, String, String, String)`

#### SuperOffice.CRM.ArchiveLists.RestrictionStorageBase is Modified

* Modified items
  * Property `Context`

#### SuperOffice.CRM.CustomObject.CustomObjectHelper is Modified

* New items
  * Method `CurrentUserHasAtLeastReadOnExtraTable(Int32)`
  * Method `CurrentUserHasAtLeastReadOnExtraTable(String)`

#### SuperOffice.CRM.Entities.AppointmentMatrix is Modified

* Modified items

##### SuperOffice.CRM.Entities.AppointmentMatrix.SendMails is Modified

* Deleted items
  * Method `.SendMailsBeginInvoke(String, String, String, Boolean, String, String, String, Boolean, String, MailItem[], AsyncCallback, Object)`
  * Method `.SendMailsInvoke(String, String, String, Boolean, String, String, String, Boolean, String, MailItem[])`
* New items
  * Method `.SendMailsBeginInvoke(String, String, String, Boolean, String, String, String, Boolean, String, Boolean, MailItem[], AsyncCallback, Object)`
  * Method `.SendMailsInvoke(String, String, String, Boolean, String, String, String, Boolean, String, Boolean, MailItem[])`

* New items
  * Method `SetSendMailToParticipants(Boolean, String, String, String, Boolean, String, String, String, Boolean, Boolean, String)`

#### SuperOffice.CRM.Entities.IAppointmentMatrix is Modified

* New items
  * Method `SetSendMailToParticipants(Boolean, String, String, String, Boolean, String, String, String, Boolean, Boolean, String)`

#### SuperOffice.CRM.Mail.EMailHelper is Modified

* Deleted items
  * Method `ResolveAddressAsync(String, CancellationToken, Boolean)`
* New items
  * Method `ResolveAddressAsync(String, Boolean, CancellationToken)`

#### SuperOffice.CRM.Mail.SendMailQueue is Modified

* New items
  * Method `SendMail(String, String, String, Boolean, String, String, String, Boolean, String, Boolean, MailItem[])`

#### SuperOffice.CRM.Mail.SendMailQueueArgument is Modified

* New items
  * Property `UseGraphApi`
  * Method `SendMailQueueArgument(String, String, String, Boolean, String, String, String, Boolean, String, Boolean, MailItem[])`

#### SuperOffice.CRM.Mail.SoMail is Modified

* New items
  * Method `BeginSend(String, String, String, Boolean, Boolean)`

#### SuperOffice.CRM.TicketMessage.TicketMessageHelper is Modified

* Deleted items
  * Method `GetQuotedMessageContentAsync(Int32, Int32, CancellationToken)`
* New items
  * Method `BuildQuotedMessageAsync(IEnumerable<KeyValuePair<String, String>>, DateTime, String, String, String, String, TicketMessageType, String, CancellationToken)`

#### SuperOffice.CRM.Webhooks.DefaultWebhookPlugin is Modified

* Deleted items
  * Method `GetAssociateEjUserIds(Int32[])`
  * Method `QueueInAppNotificationAsync(Int32, String, String, CancellationToken)`
  * Method `SaveWebhookAsync(Webhook)`
* New items
  * Method `ResetWebhookUsageAsync(Int32, CancellationToken)`
  * Method `SaveWebhookAsync(Webhook, Boolean)`

#### SuperOffice.CRM.Webhooks.WebhookManager is Modified

* Deleted items
  * Method `SaveWebhookAsync(Webhook)`
* New items
  * Method `AbandonPendingWebhooks()`
  * Method `SaveWebhookAsync(Webhook, Boolean)`

#### SuperOffice.Data.Dialect.DatabaseOperations is Modified

* Modified items
  * Method `WipeAndImportTableAsync(SoTable, IEnumerable<Object[]>, CancellationToken)`
* New items
  * Method `UpdateStatisticsAsync(SoTable, CancellationToken)`

#### SuperOffice.Data.Dialect.SqlServerOperations is Modified

* Deleted items
  * Property `NumShipoutThreads`
* Modified items
  * Method `InnerTruncateTableAsync(SoTable, TruncateOptions)`
* New items
  * Method `UpdateStatisticsAsync(SoTable, CancellationToken)`

#### SuperOffice.Util.AppointmentUtility is Modified

* Modified items
  * Method `GetConnectionInfoAsync()`


### Assembly: SuperOffice.Plugins

### Deleted Types

* `SuperOffice.Events.EventEnginePluginAttribute`
* `SuperOffice.Events.IEventEngine`
* `SuperOffice.Events.SendEventArguments`

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### Modified Types

#### .Optimization_01_TtlForeignKeyIndexes is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.Database.SuperOffice80 is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.Database.TicketLogAction is Modified

* New items
  * Field `Message_DeleteMessage`

#### SuperOffice.CD.DSL.Database.AiStep1 is Modified


#### SuperOffice.CD.DSL.Database.ChatStep1 is Modified


#### SuperOffice.CD.DSL.Database.ChatStep15_LunchHours is Modified


#### SuperOffice.CD.DSL.Database.ChatStep16_WidgetSettings is Modified


#### SuperOffice.CD.DSL.Database.ChatStep17_Country is Modified


#### SuperOffice.CD.DSL.Database.ChatStep18_MessageNotification is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.ChatStep19_OfflineFromQueue is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.ChatStep20_Rating is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.ChatStep21_ChatTopicWidgetBadgeColor is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.ChatStep22_ChatTopicWidgetBadgeColor is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.ChatStep3 is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.ChatStep4 is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.ChatStep5 is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.ChatStep6 is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.ChatStep7_OpeningHours is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.ChatStep8_CustomQueue is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.ChatStep9_CSLanguage is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.ConsentManagementStep09_MigrationFromNomailing is Modified


#### SuperOffice.CD.DSL.Database.ConsentManagementStep1 is Modified


#### SuperOffice.CD.DSL.Database.ConsentManagementStep10_Indexes is Modified


#### SuperOffice.CD.DSL.Database.ConsentManagementStep11_Travel is Modified


#### SuperOffice.CD.DSL.Database.ConsentManagementStep12_Erp is Modified


#### SuperOffice.CD.DSL.Database.ConsentManagementStep13_Erp is Modified


#### SuperOffice.CD.DSL.Database.CRMScriptStep01_Tracing is Modified


#### SuperOffice.CD.DSL.Database.CRMScriptStep02_ExtraMenusId is Modified


#### SuperOffice.CD.DSL.Database.CRMScriptStep03_UniqueIdentifier is Modified


#### SuperOffice.CD.DSL.Database.CRMScriptStep04_PopulateGuid is Modified


#### SuperOffice.CD.DSL.Database.CRMScriptStep05_GuidUnique is Modified


#### SuperOffice.CD.DSL.Database.CRMScriptStep05_ScreenDefAutoSave is Modified


#### SuperOffice.CD.DSL.Database.CRMScriptStep07_ObsoleteTrigger is Modified


#### SuperOffice.CD.DSL.Database.CRMScriptStep08_ScriptType is Modified


#### SuperOffice.CD.DSL.Database.CRMScriptStep09_ScriptTraceRunFrames is Modified


#### SuperOffice.CD.DSL.Database.CRMScriptStep10_ScriptTraceEmail is Modified


#### SuperOffice.CD.DSL.Database.CRMScriptStep11_ScreenChooserFK is Modified


#### SuperOffice.CD.DSL.Database.CS_07_TicketMessageImportance is Modified


#### SuperOffice.CD.DSL.Database.CS_27_Registry288 is Modified


#### SuperOffice.CD.DSL.Database.CS_40_ListClean_RequestTypes is Modified


#### SuperOffice.CD.DSL.Database.CS_41_Reorg_RequestTypes is Modified


#### SuperOffice.CD.DSL.Database.CS_42_Recreate_TicketType is Modified


#### SuperOffice.CD.DSL.Database.CS_43_Adjust_TicketType is Modified


#### SuperOffice.CD.DSL.Database.CS_45_TicketType_Mirroring is Modified


#### SuperOffice.CD.DSL.Database.CSStep1 is Modified


#### SuperOffice.CD.DSL.Database.CSStep2 is Modified


#### SuperOffice.CD.DSL.Database.CSStep3_SMessageLongDescription is Modified


#### SuperOffice.CD.DSL.Database.ExternalOwnerStep1 is Modified


#### SuperOffice.CD.DSL.Database.InboxStep1 is Modified


#### SuperOffice.CD.DSL.Database.Mailing_01_SortingTypes is Modified


#### SuperOffice.CD.DSL.Database.Optimization_02_UserPreferences is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.PocketStep01 is Modified


#### SuperOffice.CD.DSL.Database.PocketStep04 is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.Steps_Chat.ChatStep11_ChatTopicEnumTypes is Modified


#### SuperOffice.CD.DSL.Database.Steps_Chat.ChatStep12_ChatSessionEnumTypes is Modified


#### SuperOffice.CD.DSL.Database.Steps_Chat.ChatStep13_ChatBotFields is Modified


#### SuperOffice.CD.DSL.Database.Steps_Chat.ChatStep14_ChatBotFields is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_01_TableAndEnum is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_02_StateEnum is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_05_AppliesTo is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_06_TaskListItemTable is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_07_TaskMenuEncoding is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_08_TaskMenuPriming is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_09_TicketTabPanesIdUpdate is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_10_Remove_FT_NSTicketType is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_11_CustomMdoComponent2ForTicketStatus is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.Mailing_10_DomainList is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConsentManagement.ConsentManagementStep14_SetStore is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConsentManagement.ConsentManagementStep15_NameChange is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConsentManagement.ConsentManagementStep16_SetGdprPref is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConsentManagement.ConsentManagementStep17_RemoveHashFromKeys is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConsentManagement.ConsentManagementStep18_MoreNameChange is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConsentManagement.ConsentManagementStep19_MoreNameChange is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConsentManagement.ConsentManagementStep20_Translations is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConsentManagement.ConsentManagementStep21_Translations is Modified


#### SuperOffice.CD.DSL.Database.Steps_ConsentManagement.ConsentManagementStep22_ClearInvalidMailItemIds is Modified


#### SuperOffice.CD.DSL.Database.Steps_Copilot.Copilot_01_Tables is Modified


#### SuperOffice.CD.DSL.Database.Steps_Copilot.Copilot_02_PrimingData is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_04_EnumTypes is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_05_TicketEnumTypes is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_06_TicketMessageEnumTypes is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_08_Tags is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_10_ContactId_AssociateId is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_11_SListElement_Flags is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_12_attachment_location is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_13_PasswordRules is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_14_MailInFilter_Dsn is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_15_TicketSentiment is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_16_MoveSuggestedCategory is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_17_TicketLogAction_details is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_18_MailboxEnumTypes is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_22_MailInFilter_AI is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_23_NotifyExpiry is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_24_MsFilterTags is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_25_CustomNotifyUrl is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_26_InboxUidlLength is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_28_ReplyTemplateBodyFlags is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_33_EjMessageMessageIdLength is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_34_TicketLogActionEnum is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_35_EjMessageBadge is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_36_NotifyRegistered is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_38_TicketTimeSpent is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_39_RequestType is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_44_TicketTimeSpan is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_46_TicketTypeIsDefault is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_47_TicketType_MailboxAndFilter is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_48_TicketTypeIcon is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_49_TicketTypeIcon is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_50_TicketTypeTooltip is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_51_CreatedBy_AssocToEjUser is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_52_LastExecutedByHttp is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_53_ExtraTablesIconId is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_54_TicketTypeNewColumns is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_55_TicketTypeUserGroups is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_56_TicketType_reply_forward_no_signature is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_57_Ejscript_SourceCode is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_58_Ejscript_SourceCode is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_59_TicketType_reply_external_as_default is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_60_Ejscript_SourceMap is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_61_EjscriptVerb is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_62_ExtraTables_TableNum is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_63_ExtraTables_TableNumValue is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_64_Model_NextTableNumber is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_65_Model_NextTableNumberFix is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_66_CustomObjects_DataRight_Priming is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_67_UpdateCustomObjectSelection_TableNumber is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_68_TicketRelation is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_69_TicketRelation2 is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_70_TicketRelationDef is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.CS_72_TicketStatusSpam is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.Mailing_04_ShipmentStatus is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.Mailing_05_FormSubmissionId is Modified


#### SuperOffice.CD.DSL.Database.Steps_CS.Mailing_06_BounceCode is Modified


#### SuperOffice.CD.DSL.Database.Steps_Dashboard.DashboardStep01_Initial is Modified


#### SuperOffice.CD.DSL.Database.Steps_Dashboard.DashboardStep13_CurrencyCode is Modified


#### SuperOffice.CD.DSL.Database.Steps_Dashboard.DashboardStep14_Sentry is Modified


#### SuperOffice.CD.DSL.Database.Steps_Dashboard.DashboardStep21_ThemeData is Modified


#### SuperOffice.CD.DSL.Database.Steps_Dashboard.DashboardStep22_QuickFilterInfo is Modified


#### SuperOffice.CD.DSL.Database.Steps_Dashboard.DashboardStep23_DefaultDashboardNoOwner is Modified


#### SuperOffice.CD.DSL.Database.Steps_Dashboard.DashboardStep24_DefaultDashboardNoOwner is Modified


#### SuperOffice.CD.DSL.Database.Steps_FollowUpDialog.FollowUpDialog_01_Text_Table_Modifications_And_New_Fields is Modified


#### SuperOffice.CD.DSL.Database.Steps_FollowUpDialog.FollowUpDialog_02_AppointmentTable_SendEmail_Field is Modified


#### SuperOffice.CD.DSL.Database.Steps_FollowUpDialog.FollowUpDialog_03_AddIndexOnAppointmentAgenda is Modified


#### SuperOffice.CD.DSL.Database.Steps_FollowUpDialog.FollowUpDialog_04_Add_Sentry_To_Html_Text is Modified


#### SuperOffice.CD.DSL.Database.Steps_LandingPage.LandingPage_01_Initial is Modified


#### SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_02_SMessageDesign is Modified


#### SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_03RemoveSOEditorTemplates is Modified


#### SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_07_StatisticsCalculation is Modified


#### SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_08_StatisticsDefaultDirty_Remove is Modified


#### SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_09_StatisticsDefaultDirty_Readd is Modified


#### SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_11_StatisticsSentNum is Modified


#### SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_12_LocalLinks is Modified


#### SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_13_LinkLength is Modified


#### SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_14_LinkRedirectKind is Modified


#### SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_15_RemoveRedirectIsUrl is Modified


#### SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_16_LinkRedirectFormId is Modified


#### SuperOffice.CD.DSL.Database.Steps_Metering.Metering_01_MeteringLogTable is Modified


#### SuperOffice.CD.DSL.Database.Steps_Notifications.Notifications_01_ModifiedAppointmentFields is Modified


#### SuperOffice.CD.DSL.Database.Steps_Notifications.Notifications_02_AppointmentIndex is Modified


#### SuperOffice.CD.DSL.Database.Steps_R_Service.R_Service_03_EjUserId_1 is Modified


#### SuperOffice.CD.DSL.Database.Steps_R_Service.R_Service_1 is Modified


#### SuperOffice.CD.DSL.Database.Steps_R_Service.R_Service_2 is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_101_Conflict_detector_appointment_index is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_102_Udef_Freetext is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_112_EjUser_Flags22 is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_113_Message is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_114_FunctionalRights is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_115_Document_ContentSetCount is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_116_PrepareRemoveReporter is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_117_Expanded_Messages is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_118_SearchCritIndexes is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_119_Appointment_OwnedExternally is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_120_CopyLabelSubstitutions is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_121_PrimingDataUpdateRLDaysDA is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_122_AssignmentNotification is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_123_UTMParameters is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_124_CategoryGroups is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_128_FixIncorrectUniqueIndexes is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_129_ClearServiceAssociateHistory is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_130_Sale_StageWhenClosed is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_138_Appointment_ExternalParticipants is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_148_MarkAsSpam_FunctionalRight is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_149_MarkAsSpam_FunctionalRight_LocaleText is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_19_SoftDelete is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_20_Saint2 is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_23_SuperId is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_28_Tags is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_70_BatchTask_AddFileName is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_82_Extrafield_IndexNames is Modified


#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_88_TargetsAdministrator_FunctionalRight is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_99_PersonAssocId is Modified


#### SuperOffice.CD.DSL.Database.Steps_Targets.TargetsStep01_Initial is Modified


#### SuperOffice.CD.DSL.Database.Steps_Targets.TargetsStep02_Normalize is Modified


#### SuperOffice.CD.DSL.Database.Steps_Targets.TargetsStep04_RevisionHistory is Modified


#### SuperOffice.CD.DSL.Database.Steps_Targets.TargetsStep05_LargeValueSupportAndMoreRevisionHistory is Modified


#### SuperOffice.CD.DSL.Database.Steps_Targets.TargetsStep06_RemoveOldValueFields is Modified


#### SuperOffice.CD.DSL.Database.Steps_Targets.TargetsStep07_NewDimensions is Modified


#### SuperOffice.CD.DSL.Database.Steps_Targets.TargetsStep08_ListField is Modified


#### SuperOffice.CD.DSL.Database.Steps_UserPreference.UserPreference_01_Num_Expanded_Messages is Modified


#### SuperOffice.CD.DSL.Database.Steps_UserPreference.UserPreference_02_EjUser_Simple_Fields_Migration is Modified


#### SuperOffice.CD.DSL.Database.Steps_UserPreference.UserPreference_03_Flags_Migration is Modified


#### SuperOffice.CD.DSL.Database.Steps_UserPreference.UserPreference_04_NotifyFields_Migration is Modified


#### SuperOffice.CD.DSL.Database.Steps_Webhooks.Webhooks_01_CreateTables is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.Steps_Webhooks.Webhooks_02_UsageTable is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.Steps_Webhooks.Webhooks_03_RemoveOldUsage is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.Steps_Webhooks.Webhooks_04_Add_ErrorEmail is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.Steps_Webhooks.Webhooks_05_NotifyTable is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep01_Initial is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep02_Rank is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep03_Hierarchy is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep04_EmailSettings is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep05_WorkflowSettings is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep06_WorkflowBlockList is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep07_WorkflowStepOptions is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep08_EmailFlowContent is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep09_NoConversionUtcDateAndTime is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep10_Locking is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep11_ParticipantFields is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep12_SShipmentAddrForeignKeysToFlow is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep13_SShipmentAddrForeignKeyIndexing is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep14_WorkflowStepOptionKeyToInt is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep15_FlowExitSettings is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep16_WorkflowFunctionalRights is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep16_WorkflowWaitForAction is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep18_EmailFlowContentFormsAndLinks is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep19_WorkflowSchemaOptimization_part1 is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep20_WorkflowSchemaOptimization_part2 is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep21_FormFields is Modified


#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep22_FlowReferences is Modified


#### SuperOffice.CD.DSL.Database.SubscriptionMgmtStep1 is Modified


#### SuperOffice.CD.DSL.Database.SubscriptionMgmtStep2 is Modified


#### SuperOffice.CD.DSL.Database.SubscriptionMgmtStep3 is Modified


#### SuperOffice.CD.DSL.Database.SubscriptionMgmtStep4 is Modified


#### SuperOffice.CD.DSL.Database.SubscriptionMgmtStep5_RenameTables is Modified


#### SuperOffice.CD.DSL.Database.SubscriptionMgmtStep6_Indexes is Modified


#### SuperOffice.CD.DSL.Database.SubscriptionMgmtStep7_Translations is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_100_SOCompany is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_104_Freetext_SequenceIds is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_11_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_111_UnsafeFileTypes_On_Group_Level is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_12_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_13_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_132_AutoUpdate is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_133_AutoUpdateAddLeadstatus is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_134_ShipmentAddrAddOwnerLock is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_135_PrimaryKeys is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_136_AvailableFonts is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_139_AvailableFontsSoftDelete is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_14_Indexes is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_15_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_16_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_17_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_18_DeleteOrphans is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_21_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_22_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_24_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_25_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_26_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_27_R_PreferenceMappings is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_5_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_56_PrunePreferences is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_58_SOCompany is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_6_TableNumberPrep is Modified

* Deleted items
  * Method `CustomPriming()`

#### SuperOffice.CD.DSL.Database.SuperOffice_60_AppointmentMother is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_66_PrimingData_Zip_Translations is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_69_PrimingData_Country_Language_RLD_GECompany is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_7_TableNumberFieldId is Modified

* Deleted items
  * Method `CustomPriming()`

#### SuperOffice.CD.DSL.Database.SuperOffice_9_PrimingData is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice_90_ResetTagsFiltering is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_96_SOCompany is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice_98_EntityCounts is Modified


#### SuperOffice.CD.DSL.Database.SuperOffice80_2 is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice80_3_CD2 is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.SuperOffice80_4_Upgrade is Modified

* Deleted items
  * Field `State`

#### SuperOffice.CD.DSL.Database.TechnicalDebt_01_DuplicateUserPreference is Modified

* Deleted items
  * Field `State`



