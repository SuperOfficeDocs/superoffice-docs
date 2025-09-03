---
uid: version_11.3.1348.0_changes
date: 02.09.2025
---

Changes from v11.2.487.0 and v11.3.1348.0

## Web Services

These changes are observed in NetServer Core and Services.

### Assembly: SuperOffice.Services

### Deleted Types

* `SuperOffice.CRM.Services.Reflection.FactoryHelper`
* `SuperOffice.CRM.Services.Reflection.ProxyEndpointSelector`

### New Types

* `SuperOffice.CRM.Services.BizCard`
* `SuperOffice.CRM.Services.BoardViewSettingsBase`
* `SuperOffice.CRM.Services.CategoryEntity`
* `SuperOffice.CRM.Services.InitalUtmParameters`
* `SuperOffice.CRM.Services.ProjectBoardViewSettings`
* `SuperOffice.CRM.Services.SaleBoardViewSettings`
* `SuperOffice.CRM.Services.UtmParameters`

### Modified Types

#### SuperOffice.CRM.Services.Appointment is Modified

* New items
  * Property `MotherAssociateId`

#### SuperOffice.CRM.Services.AppointmentInfo is Modified

* New items
  * Property `MotherAssociateId`
  * Property `OwnedExternally`

#### SuperOffice.CRM.Services.Associate is Modified

* New items
  * Property `CustomFields`
  * Property `ExtraFields`

#### SuperOffice.CRM.Services.ContactEntity is Modified

* New items
  * Property `InitialUtmParameters`

#### SuperOffice.CRM.Services.CRMScriptEntity is Modified

* New items
  * Property `BlockedVerbs`

#### SuperOffice.CRM.Services.IAIAgent is Modified

* New items
  * Method `AnalyzeBizCardImageAsync(Stream, Boolean, CancellationToken)`
  * Method `AnalyzeBizCardTextAsync(String, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.IListAgent is Modified

* New items
  * Method `CreateDefaultCategoryEntityAsync(CancellationToken)`
  * Method `GetCategoryEntityAsync(Int32, CancellationToken)`
  * Method `SaveCategoryEntityAsync(CategoryEntity, CancellationToken)`

#### SuperOffice.CRM.Services.IPersonAgent is Modified

* New items
  * Method `GetUtmParametersAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.IProjectAgent is Modified

* New items
  * Method `SetCompletedAsync(Int32, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.ISelectionAgent is Modified

* New items
  * Method `CreateDefaultBoardViewSettingsFromEntityTypeAsync(BoardViewEntityType, CancellationToken)`
  * Method `DeleteBoardViewSettingsAsync(Int32, CancellationToken)`
  * Method `GetBoardViewSettingsAsync(Int32, CancellationToken)`
  * Method `GetBoardViewSettingsForSelectionAsync(Int32, Int32, CancellationToken)`
  * Method `SaveBoardViewSettingsAsync(BoardViewSettingsBase, CancellationToken)`

#### SuperOffice.CRM.Services.PersonEntity is Modified

* New items
  * Property `InitialUtmParameters`

#### SuperOffice.CRM.Services.Script is Modified

* New items
  * Property `BlockedVerbs`

#### SuperOffice.CRM.Services.Util.RoleRelationToOwner is Modified

* New items
  * Field `CustomObjects`


### Assembly: SuperOffice.Services.Implementation

### Deleted Types

* `SuperOffice.DashBoards.UpdateState`

### New Types

* `SuperOffice.CRM.Services.Implementation.BL.BizCardImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IBizCardImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IBoardViewSettingsBaseImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICategoryEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Relation`

### Modified Types

#### SuperOffice.CRM.Services.AIAgent is Modified

* Deleted items
  * Method `AIAgent(ITextServicesImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ISentimentImplementation, IRagAnswerImplementation, IRagResultImplementation, ISummarizerImplementation, ISoRequestItemsAccessor)`
  * Method `AIAgent(ITextServicesImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ISentimentImplementation, IRagAnswerImplementation, IRagResultImplementation, ISummarizerImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ISentimentImplementation, IRagAnswerImplementation, IRagResultImplementation, ISummarizerImplementation, ISoRequestItemsAccessor)`
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ISentimentImplementation, IRagAnswerImplementation, IRagResultImplementation, ISummarizerImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `AnalyzeBizCardImageAsync(Stream, Boolean, CancellationToken)`
  * Method `AnalyzeBizCardTextAsync(String, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* Deleted items
  * Method `AppointmentAgent(IAppointmentImplementation, IAppointmentEntityImplementation, IAppointmentListImplementation, IAppointmentSyncDataImplementation, IDayInformationListImplementation, IMultiAlarmDataImplementation, INextAvailableTimeListImplementation, ISalesActivityImplementation, ISuggestedAppointmentImplementation, ISuggestedAppointmentEntityImplementation, ITaskListItemImplementation, IVideoMeetingReservationImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `AppointmentAgent(IAppointmentImplementation, IAppointmentEntityImplementation, IAppointmentListImplementation, IAppointmentSyncDataImplementation, IDayInformationListImplementation, IMultiAlarmDataImplementation, INextAvailableTimeListImplementation, ISalesActivityImplementation, ISuggestedAppointmentImplementation, ISuggestedAppointmentEntityImplementation, ITaskListItemImplementation, IVideoMeetingReservationImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.ArchiveAgent is Modified

* Deleted items
  * Method `ArchiveAgent(IActivityFilterImplementation, IArchiveConfigurationImplementation, IArchiveListImplementation, IArchiveListResultImplementation, IRelatedDataImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `ArchiveAgent(IActivityFilterImplementation, IArchiveConfigurationImplementation, IArchiveListImplementation, IArchiveListResultImplementation, IRelatedDataImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.AssociateAgent is Modified

* Deleted items
  * Method `AssociateAgent(IAssociateImplementation, IAssociateListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `AssociateAgent(IAssociateImplementation, IAssociateListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.BatchAgent is Modified

* Deleted items
  * Method `BatchAgent(IBatchImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `BatchAgent(IBatchImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.BLOBAgent is Modified

* Deleted items
  * Method `BLOBAgent(IBlobEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `BLOBAgent(IBlobEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.BulkUpdateAgent is Modified

* Deleted items
  * Method `BulkUpdateAgent(IFieldValueInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `BulkUpdateAgent(IFieldValueInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.ChatAgent is Modified

* Deleted items
  * Method `ChatAgent(IChatPresenceImplementation, IChatSessionEntityImplementation, IChatTopicAgentImplementation, IChatTopicEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `ChatAgent(IChatPresenceImplementation, IChatSessionEntityImplementation, IChatTopicAgentImplementation, IChatTopicEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.ContactAgent is Modified

* Deleted items
  * Method `ContactAgent(IContactImplementation, IContactActivityListImplementation, IContactEntityImplementation, IContactListImplementation, IPreviewContactImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `ContactAgent(IContactImplementation, IContactActivityListImplementation, IContactEntityImplementation, IContactListImplementation, IPreviewContactImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.CRMScriptAgent is Modified

* Deleted items
  * Method `CRMScriptAgent(IScriptImplementation, ICRMScriptEntityImplementation, ITriggerScriptEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `CRMScriptAgent(IScriptImplementation, ICRMScriptEntityImplementation, ITriggerScriptEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.CustomerServiceAgent is Modified

* Deleted items
  * Method `CustomerServiceAgent(IChatSessionImplementation, ICsFeatureToggleImplementation, ICsSessionKeyImplementation, ICustomerCenterConfigImplementation, ICustomerServiceConfigImplementation, ICustomerServiceStartupImplementation, IEventDataImplementation, IMailboxImplementation, IMailboxEntityImplementation, IPreviewFaqEntryImplementation, IPreviewQuickReplyImplementation, IPreviewReplyTemplateImplementation, IReplyTemplateParsedImplementation, ISmsConfigImplementation, ISmtpTestResultImplementation, IStatisticsDataSetImplementation, ISystemTemplateSettingsImplementation, ITicketInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `CustomerServiceAgent(IChatSessionImplementation, ICsFeatureToggleImplementation, ICsSessionKeyImplementation, ICustomerCenterConfigImplementation, ICustomerServiceConfigImplementation, ICustomerServiceStartupImplementation, IEventDataImplementation, IMailboxImplementation, IMailboxEntityImplementation, IPreviewFaqEntryImplementation, IPreviewQuickReplyImplementation, IPreviewReplyTemplateImplementation, IReplyTemplateParsedImplementation, ISmsConfigImplementation, ISmtpTestResultImplementation, IStatisticsDataSetImplementation, ISystemTemplateSettingsImplementation, ITicketInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.DashAgent is Modified

* Deleted items
  * Method `DashAgent(IDashImplementation, IDashCollectionImplementation, IDashThemeImplementation, IDashTileImplementation, IDashTileDefinitionImplementation, IDashTileHtmlImplementation, IPreviewDashImplementation, IPreviewDashTileImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `DashAgent(IDashImplementation, IDashCollectionImplementation, IDashThemeImplementation, IDashTileImplementation, IDashTileDefinitionImplementation, IDashTileHtmlImplementation, IPreviewDashImplementation, IPreviewDashTileImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.DatabaseAgent is Modified

* Deleted items
  * Method `DatabaseAgent(IDictionaryStepInformationImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `DatabaseAgent(IDictionaryStepInformationImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.DatabaseTableAgent is Modified

* Deleted items
  * Method `DatabaseTableAgent(ITableRecordImplementation, IMassOperationResultImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `DatabaseTableAgent(ITableRecordImplementation, IMassOperationResultImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.DiagnosticsAgent is Modified

* Deleted items
  * Method `DiagnosticsAgent(ICacheImplementation, ICacheInvalidationImplementation, IEntityCountsImplementation, ILoggingImplementation, IUsageStatsImplementation, ISystemMessageListImplementation, ITableManagerImplementation, IInstallationImplementation, IWebAppUsageImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `DiagnosticsAgent(ICacheImplementation, ICacheInvalidationImplementation, IEntityCountsImplementation, ILoggingImplementation, IUsageStatsImplementation, ISystemMessageListImplementation, ITableManagerImplementation, IInstallationImplementation, IWebAppUsageImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.DocumentAgent is Modified

* Deleted items
  * Method `DocumentAgent(IDocumentImplementation, IDocumentEntityImplementation, IDocumentListImplementation, IDocumentPreviewImplementation, ISuggestedDocumentEntityImplementation, ITemplateVariablesParametersImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `DocumentAgent(IDocumentImplementation, IDocumentEntityImplementation, IDocumentListImplementation, IDocumentPreviewImplementation, ISuggestedDocumentEntityImplementation, ITemplateVariablesParametersImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.DocumentMigrationAgent is Modified

* Deleted items
  * Method `DocumentMigrationAgent(IDocumentMigrationItemListImplementation, IDocumentTemplateMigrationListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `DocumentMigrationAgent(IDocumentMigrationItemListImplementation, IDocumentTemplateMigrationListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.EMailAgent is Modified

* Deleted items
  * Method `EMailAgent(IEMailAccountImplementation, IEMailAddressImplementation, IEMailAppointmentImplementation, IEMailAttachmentImplementation, IEMailConnectionInfoImplementation, IEMailConnectionInfoExtendedImplementation, IEMailCustomHeaderImplementation, IEMailEntityImplementation, IEMailEnvelopeImplementation, IEMailFolderImplementation, IEMailSOInfoImplementation, ISyncUserAccountImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `EMailAgent(IEMailAccountImplementation, IEMailAddressImplementation, IEMailAppointmentImplementation, IEMailAttachmentImplementation, IEMailConnectionInfoImplementation, IEMailConnectionInfoExtendedImplementation, IEMailCustomHeaderImplementation, IEMailEntityImplementation, IEMailEnvelopeImplementation, IEMailFolderImplementation, IEMailSOInfoImplementation, ISyncUserAccountImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.ErpSyncAgent is Modified

* Deleted items
  * Method `ErpSyncAgent(IErpConnectionImplementation, IErpConnectionDataImplementation, IErpConnectionListMappingContainerImplementation, IErpSyncFieldValueImplementation, IErpSyncActorTypeMappingImplementation, IErpSyncConnectionSummaryImplementation, IErpSyncConnectorEntityImplementation, IErpSyncDefaultValueImplementation, IErpSyncEngineImplementation, IErpSyncEngineStatusImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `ErpSyncAgent(IErpConnectionImplementation, IErpConnectionDataImplementation, IErpConnectionListMappingContainerImplementation, IErpSyncFieldValueImplementation, IErpSyncActorTypeMappingImplementation, IErpSyncConnectionSummaryImplementation, IErpSyncConnectorEntityImplementation, IErpSyncDefaultValueImplementation, IErpSyncEngineImplementation, IErpSyncEngineStatusImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.FavouriteAgent is Modified

* Deleted items
  * Method `FavouriteAgent(IFavouriteImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `FavouriteAgent(IFavouriteImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.FindAgent is Modified

* Deleted items
  * Method `FindAgent(IFindImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `FindAgent(IFindImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.ForeignSystemAgent is Modified

* Deleted items
  * Method `ForeignSystemAgent(IForeignAppEntityImplementation, IForeignDeviceImplementation, IForeignKeyImplementation, IForeignKeyListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `ForeignSystemAgent(IForeignAppEntityImplementation, IForeignDeviceImplementation, IForeignKeyImplementation, IForeignKeyListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.FreeTextAgent is Modified

* Deleted items
  * Method `FreeTextAgent(IFreeTextImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `FreeTextAgent(IFreeTextImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.Implementation.BL.AppointmentEntityImplementation is Modified

* Deleted items
  * Method `AppointmentEntityImplementation(IArchiveAgent, IContactAgent, ISaleAgent, IPersonAgent, IProjectAgent, ILinkImplementation, IPriorityImplementation, ITaskListItemImplementation, ISoTimeZone, IAppointmentUtility, ICalendarAppointmentUtility, ICalendarUtility, IFieldInfoBaseImplementation, IAppointmentMatrixFactory)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
* Modified items
  * Method `SaveAsync(AppointmentEntity, CancellationToken)`
* New items
  * Method `AppointmentEntityImplementation(IArchiveAgent, IContactAgent, ISaleAgent, IPersonAgent, IProjectAgent, ILinkImplementation, IPriorityImplementation, ITaskListItemImplementation, ISoTimeZone, IAppointmentUtility, ICalendarAppointmentUtility, ICalendarUtility, IFieldInfoBaseImplementation, IAppointmentMatrixFactory, ICacheManager, ILogger<AppointmentEntityImplementation>)`
  * Method `CreateDefaultAppointmentEntityAsync(CancellationToken)`
  * Method `DeleteAppointmentEntityAsync(Int32, CancellationToken)`
  * Method `GetAppointmentEntityAsync(Int32, CancellationToken)`
  * Method `SaveAppointmentEntityAsync(AppointmentEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.AppointmentListImplementation is Modified

* Deleted items
  * Method `AppointmentListImplementation(IAppointmentEntityImplementation, IAppointmentUtility)`
* New items
  * Method `AppointmentListImplementation(IAppointmentEntityImplementation, IAppointmentUtility, IBookingManager, ICacheManager)`

#### SuperOffice.CRM.Services.Implementation.BL.AttachmentEntityImplementation is Modified

* Deleted items
  * Method `AttachmentEntityImplementation(IDocumentAgent)`
* New items
  * Method `AttachmentEntityImplementation(IDocumentAgent, ServiceFacade)`

#### SuperOffice.CRM.Services.Implementation.BL.ChatSessionEntityImplementation is Modified

* Deleted items
  * Method `ChatSessionEntityImplementation(IContactImplementation, ITicketImplementation, IAssociateImplementation, IChatSessionImplementation, IProjectImplementation, IPersonImplementation, ISaleImplementation)`
* New items
  * Method `ChatSessionEntityImplementation(IContactImplementation, ITicketImplementation, IAssociateImplementation, IChatSessionImplementation, IProjectImplementation, IPersonImplementation, ISaleImplementation, ICacheManager, ServiceFacade)`

#### SuperOffice.CRM.Services.Implementation.BL.ChatTopicEntityImplementation is Modified

* Deleted items
  * Method `ChatTopicEntityImplementation(IChatSessionEntityImplementation, IAssociateImplementation, ITicketPriorityImplementation, ICustomerLanguageImplementation, ITicketCategoryImplementation, IMDOAgent)`
* New items
  * Method `ChatTopicEntityImplementation(IChatSessionEntityImplementation, IAssociateImplementation, ITicketPriorityImplementation, ICustomerLanguageImplementation, ITicketCategoryImplementation, IMDOAgent, ICacheManager, ICRMScriptAgent)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IAppointmentEntityImplementation is Modified

* Deleted items
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `SaveAsync(AppointmentEntity, CancellationToken)`
* New items
  * Method `CreateDefaultAppointmentEntityAsync(CancellationToken)`
  * Method `DeleteAppointmentEntityAsync(Int32, CancellationToken)`
  * Method `GetAppointmentEntityAsync(Int32, CancellationToken)`
  * Method `SaveAppointmentEntityAsync(AppointmentEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IContactEntityImplementation is Modified

* Deleted items
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `SaveAsync(ContactEntity, CancellationToken)`
* New items
  * Method `CreateDefaultContactEntityAsync(CancellationToken)`
  * Method `DeleteContactEntityAsync(Int32, CancellationToken)`
  * Method `GetContactEntityAsync(Int32, CancellationToken)`
  * Method `SaveContactEntityAsync(ContactEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IDocumentEntityImplementation is Modified

* Deleted items
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `SaveAsync(DocumentEntity, CancellationToken)`
* New items
  * Method `CreateDefaultDocumentEntityAsync(CancellationToken)`
  * Method `DeleteDocumentEntityAsync(Int32, CancellationToken)`
  * Method `GetDocumentEntityAsync(Int32, CancellationToken)`
  * Method `SaveDocumentEntityAsync(DocumentEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IForeignAppEntityImplementation is Modified

* Deleted items
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `SaveAsync(ForeignAppEntity, CancellationToken)`
* New items
  * Method `CreateDefaultForeignAppEntityAsync(CancellationToken)`
  * Method `DeleteForeignAppEntityAsync(Int32, CancellationToken)`
  * Method `GetForeignAppEntityAsync(Int32, CancellationToken)`
  * Method `SaveForeignAppEntityAsync(ForeignAppEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IPersonEntityImplementation is Modified

* Deleted items
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `SaveAsync(PersonEntity, CancellationToken)`
* New items
  * Method `CreateDefaultPersonEntityAsync(CancellationToken)`
  * Method `DeletePersonEntityAsync(Int32, CancellationToken)`
  * Method `GetPersonEntityAsync(Int32, CancellationToken)`
  * Method `GetUtmParametersAsync(Int32, CancellationToken)`
  * Method `SavePersonEntityAsync(PersonEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectEntityImplementation is Modified

* Deleted items
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `SaveAsync(ProjectEntity, CancellationToken)`
* New items
  * Method `CreateDefaultProjectEntityAsync(CancellationToken)`
  * Method `DeleteProjectEntityAsync(Int32, CancellationToken)`
  * Method `GetProjectEntityAsync(Int32, CancellationToken)`
  * Method `SaveProjectEntityAsync(ProjectEntity, CancellationToken)`
  * Method `SetCompletedAsync(Int32, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaleEntityImplementation is Modified

* Deleted items
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `SaveAsync(SaleEntity, CancellationToken)`
* New items
  * Method `CreateDefaultSaleEntityAsync(CancellationToken)`
  * Method `DeleteSaleEntityAsync(Int32, CancellationToken)`
  * Method `GetSaleEntityAsync(Int32, CancellationToken)`
  * Method `SaveSaleEntityAsync(SaleEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.ISelectionEntityImplementation is Modified

* Deleted items
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `SaveAsync(SelectionEntity, CancellationToken)`
* New items
  * Method `CreateDefaultSelectionEntityAsync(CancellationToken)`
  * Method `GetSelectionEntityAsync(Int32, CancellationToken)`
  * Method `SaveSelectionEntityAsync(SelectionEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CustomObjectEntityImplementation is Modified

* Deleted items
  * Method `GetCustomObjectMetadataAsync()`
* New items
  * Method `GetCustomObjectMetadataAsync(CancellationToken)`
  * Method `GetRelationsAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CustomObjectMetadata is Modified

* New items
  * Property `Relations`

#### SuperOffice.CRM.Services.Implementation.BL.EMailEntityImplementation is Modified

* Deleted items
  * Method `EMailEntityImplementation(IEMailAccountImplementation, IEMailAddressImplementation, IEMailFolderImplementation, IAppointmentImplementation, IAppointmentEntityImplementation, IAppointmentUtility, ITempFileProvider, IDocumentAgent, IDocumentEntityImplementation, IPersonImplementation, IServiceAuthImplementation, ICalendarUtility, ICalendarAppointmentUtility)`
* New items
  * Method `EMailEntityImplementation(IEMailAccountImplementation, IEMailAddressImplementation, IEMailFolderImplementation, IAppointmentImplementation, IAppointmentEntityImplementation, IAppointmentUtility, ITempFileProvider, IDocumentAgent, IDocumentEntityImplementation, IPersonImplementation, IServiceAuthImplementation, ICalendarUtility, ICalendarAppointmentUtility, ICacheManager, ILogger<EMailEntityImplementation>)`

#### SuperOffice.CRM.Services.Implementation.BL.EMailFolderImplementation is Modified

* Deleted items
  * Method `EMailFolderImplementation(IEMailAccountImplementation, IServiceAuthImplementation)`
* New items
  * Method `EMailFolderImplementation(IEMailAccountImplementation, IServiceAuthImplementation, ILogger<EMailFolderImplementation>)`

#### SuperOffice.CRM.Services.Implementation.BL.ErpConnectionImplementation is Modified

* Deleted items
  * Method `ErpConnectionImplementation(IErpSyncActorTypeMappingImplementation)`
* New items
  * Method `ErpConnectionImplementation(IErpSyncActorTypeMappingImplementation, ICacheManager, IArchiveAgent)`

#### SuperOffice.CRM.Services.Implementation.BL.ErpConnectionListMappingContainerImplementation is Modified

* Deleted items
  * Method `ErpConnectionListMappingContainerImplementation(IUserDefinedFieldInfoImplementation)`
* New items
  * Method `ErpConnectionListMappingContainerImplementation(IUserDefinedFieldInfoImplementation, ILogger<ErpConnectionListMappingContainerImplementation>)`

#### SuperOffice.CRM.Services.Implementation.BL.EventDataImplementation is Modified

* Deleted items
  * Method `EventDataImplementation()`
* New items
  * Method `EventDataImplementation(ServiceFacade)`

#### SuperOffice.CRM.Services.Implementation.BL.ForeignAppEntityImplementation is Modified

* Deleted items
  * Method `ForeignAppEntityImplementation(IForeignDeviceImplementation, IForeignKeyImplementation)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
* Modified items
  * Method `DeleteAsync(Int32, CancellationToken)`
* New items
  * Method `ForeignAppEntityImplementation(IForeignDeviceImplementation, IForeignKeyImplementation, ICacheManager)`
  * Method `CreateDefaultForeignAppEntityAsync(CancellationToken)`
  * Method `DeleteForeignAppEntityAsync(Int32, CancellationToken)`
  * Method `GetForeignAppEntityAsync(Int32, CancellationToken)`
  * Method `SaveForeignAppEntityAsync(ForeignAppEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.HistoryImplementation is Modified

* Deleted items
  * Method `HistoryImplementation(IPreferenceImplementation, IPreferenceListImplementation)`
* New items
  * Method `HistoryImplementation(IPreferenceImplementation, IPreferenceListImplementation, ISoListProviderFactory, ILogger<HistoryImplementation>)`

#### SuperOffice.CRM.Services.Implementation.BL.HistoryListImplementation is Modified

* Deleted items
  * Method `HistoryListImplementation(IHistoryImplementation)`
* New items
  * Method `HistoryListImplementation(IHistoryImplementation, ICacheManager)`

#### SuperOffice.CRM.Services.Implementation.BL.MailboxImplementation is Modified

* Deleted items
  * Method `MailboxImplementation()`
* New items
  * Method `MailboxImplementation(ServiceFacade)`

#### SuperOffice.CRM.Services.Implementation.BL.PreviewContactImplementation is Modified

* Deleted items
  * Method `PreviewContactImplementation(ICacheManager)`
* New items
  * Method `PreviewContactImplementation(ICacheManager, ILogger<PreviewContactImplementation>)`

#### SuperOffice.CRM.Services.Implementation.BL.PriceListImplementation is Modified

* Deleted items
  * Method `PriceListImplementation(ICurrencyImplementation)`
* New items
  * Method `PriceListImplementation(ICurrencyImplementation, ICacheManager)`

#### SuperOffice.CRM.Services.Implementation.BL.RagResultImplementation is Modified

* New items
  * Property `IsUnitTestMode`

#### SuperOffice.CRM.Services.Implementation.BL.ReplyTemplateParsedImplementation is Modified

* Deleted items
  * Method `ReplyTemplateParsedImplementation()`
* New items
  * Method `ReplyTemplateParsedImplementation(ServiceFacade)`

#### SuperOffice.CRM.Services.Implementation.BL.SelectionEntityImplementation is Modified

* Deleted items
  * Method `SelectionEntityImplementation(IAppointmentEntityImplementation, IPersonImplementation, IBatchData, IDuplicateDetectorFactory, ISelectionTypeManager)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
* Modified items
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `SaveAsync(SelectionEntity, CancellationToken)`
* New items
  * Method `SelectionEntityImplementation(IAppointmentEntityImplementation, IPersonImplementation, IDuplicateDetectorFactory, ISelectionTypeManager, ISelectionCategoryImplementation, IArchiveAgent, IArchiveConfigurationImplementation, IContactImplementation)`
  * Method `CreateDefaultSelectionEntityAsync(CancellationToken)`
  * Method `GetSelectionEntityAsync(Int32, CancellationToken)`
  * Method `SaveSelectionEntityAsync(SelectionEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SmtpTestResultImplementation is Modified

* Deleted items
  * Method `SmtpTestResultImplementation()`
* New items
  * Method `SmtpTestResultImplementation(ServiceFacade)`

#### SuperOffice.CRM.Services.Implementation.BL.SuggestedAppointmentEntityImplementation is Modified

* Deleted items
  * Method `SuggestedAppointmentEntityImplementation()`
* New items
  * Method `SuggestedAppointmentEntityImplementation(ISoTaskImplementation)`

#### SuperOffice.CRM.Services.Implementation.BL.SuggestedDocumentEntityImplementation is Modified

* Deleted items
  * Method `SuggestedDocumentEntityImplementation()`
* New items
  * Method `SuggestedDocumentEntityImplementation(IDocumentTemplateImplementation, ICacheManager)`

#### SuperOffice.CRM.Services.Implementation.BL.TargetAssignmentImplementation is Modified

* Deleted items
  * Method `TargetAssignmentImplementation(ITargetDimensionImplementation, ITargetRevisionHistoryImplementation, IContactImplementation, IAssociateImplementation, ICurrencyImplementation, IMDOListImplementation, IUserGroupImplementation)`
* New items
  * Method `TargetAssignmentImplementation(ITargetDimensionImplementation, ITargetRevisionHistoryImplementation, IContactImplementation, IAssociateImplementation, ICurrencyImplementation, IMDOListImplementation, IUserGroupImplementation, ICacheManager, ILogger<TargetAssignmentImplementation>)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketInfoImplementation is Modified

* Deleted items
  * Method `TicketInfoImplementation()`
* New items
  * Method `TicketInfoImplementation(ServiceFacade)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketMessageEntityImplementation is Modified

* Deleted items
  * Method `TicketMessageEntityImplementation(IAttachmentEntityImplementation, ITicketImplementation, IUserImplementation)`
* New items
  * Method `TicketMessageEntityImplementation(IAttachmentEntityImplementation, ITicketImplementation, IUserImplementation, ServiceFacade, ICacheManager)`

#### SuperOffice.CRM.Services.Implementation.BL.TypicalSearchesImplementation is Modified

* Deleted items
  * Method `TypicalSearchesImplementation()`
  * Method `UpdateTypicalSearchAsync(TypicalSearches, IProgressNotification, CancellationToken)`
* New items
  * Method `TypicalSearchesImplementation(ILogger<TypicalSearchesImplementation>)`
  * Method `UpdateTypicalSearchAsync(TypicalSearches, IProgressNotification, ILogger, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.UserDefinedFieldInfoImplementation is Modified

* Deleted items
  * Method `UserDefinedFieldInfoImplementation(IUdefHelper, ISystemEventHelper, IUdefPublishHelper)`
* New items
  * Method `UserDefinedFieldInfoImplementation(IUdefHelper, ISystemEventHelper, IUdefPublishHelper, ICacheManager, ILogger<UserDefinedFieldInfoImplementation>)`

#### SuperOffice.CRM.Services.Implementation.BL.UserImplementation is Modified

* Deleted items
  * Method `UserImplementation(ICredentialImplementation, ICredentialsManager, IPersonEntityImplementation)`
* New items
  * Method `UserImplementation(ICredentialImplementation, ICredentialsManager, IPersonEntityImplementation, ICacheManager, ILogger<UserImplementation>)`

#### SuperOffice.CRM.Services.Implementation.BL.WebhookImplementation is Modified

* Deleted items
  * Method `WebhookImplementation()`
* New items
  * Method `WebhookImplementation(ILogger<WebhookImplementation>, IWebhookManager, ISoRequestItemsAccessor, IAssociateImplementation)`

#### SuperOffice.CRM.Services.Implementation.BL.WorkflowEventImplementation is Modified

* Deleted items
  * Method `WorkflowEventImplementation()`
* New items
  * Method `WorkflowEventImplementation(IWorkflowEngine)`

#### SuperOffice.CRM.Services.Implementation.LicenseImplementation is Modified

* Deleted items
  * Method `LicenseImplementation(ILicenseManager)`
* New items
  * Method `LicenseImplementation(ILicenseManager, ICacheManager)`

#### SuperOffice.CRM.Services.Implementation.TaskMenuImplementation is Modified

* Deleted items
  * Method `TaskMenuImplementation()`
* New items
  * Method `TaskMenuImplementation(ISoRequestItemsAccessor)`

#### SuperOffice.CRM.Services.Implementation.Util.CalendarAppointmentUtility is Modified

* Deleted items
  * Method `CalendarAppointmentUtility(ICalendarUtility, IAppointmentUtility, IAppointmentMatrixFactory)`
* New items
  * Method `CalendarAppointmentUtility(ICalendarUtility, IAppointmentUtility, IAppointmentMatrixFactory, IServiceScopeFactory, ILogger<CalendarAppointmentUtility>)`

#### SuperOffice.CRM.Services.Implementation.Util.HugoAIHelper is Modified

* Deleted items
  * Method `HugoAIHelper(IOptions<HugoAIConfiguration>)`
* New items
  * Method `HugoAIHelper(ICacheManager, IServiceScopeFactory, ILogger<HugoAIHelper>, IOptions<HugoAIConfiguration>)`

#### SuperOffice.CRM.Services.Implementation.Util.UserPreference is Modified

* Deleted items
  * Method `GetUserPreference(Int32, PreferenceLevel, String, String)`
* New items
  * Method `GetUserPreferenceAsync(Int32, PreferenceLevel, String, String, CancellationToken)`

#### SuperOffice.CRM.Services.ImportAgent is Modified

* Deleted items
  * Method `ImportAgent(IImportLineImplementation, IImportErpDataImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `ImportAgent(IImportLineImplementation, IImportErpDataImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.LicenseAgent is Modified

* Deleted items
  * Method `LicenseAgent(ILicenseImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `LicenseAgent(ILicenseImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.ListAgent is Modified

* Deleted items
  * Method `ListAgent(IAmountClassEntityImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor)`
  * Method `ListAgent(IAmountClassEntityImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `ListAgent(IAmountClassEntityImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryEntityImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor)`
  * Method `ListAgent(IAmountClassEntityImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryEntityImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `CreateDefaultCategoryEntityAsync(CancellationToken)`
  * Method `GetCategoryEntityAsync(Int32, CancellationToken)`
  * Method `SaveCategoryEntityAsync(CategoryEntity, CancellationToken)`

#### SuperOffice.CRM.Services.MarketingAgent is Modified

* Deleted items
  * Method `MarketingAgent(IFormEntityImplementation, IFormSubmissionEntityImplementation, IMailingStatisticsImplementation, IPreviewMailingImplementation, IPreviewMailingHeaderImplementation, IShipmentMessageBlockEntityImplementation, IShipmentMessageEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `MarketingAgent(IFormEntityImplementation, IFormSubmissionEntityImplementation, IMailingStatisticsImplementation, IPreviewMailingImplementation, IPreviewMailingHeaderImplementation, IShipmentMessageBlockEntityImplementation, IShipmentMessageEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.MDOAgent is Modified

* Deleted items
  * Method `MDOAgent(IMDOListImplementation, ISelectableMDOListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `MDOAgent(IMDOListImplementation, ISelectableMDOListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.NumberAllocationAgent is Modified

* Deleted items
  * Method `NumberAllocationAgent(IRefCountEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `NumberAllocationAgent(IRefCountEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.PersonAgent is Modified

* Deleted items
  * Method `PersonAgent(IConsentPersonImplementation, IPersonImplementation, IPersonEntityImplementation, IPersonImageImplementation, IPersonListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `PersonAgent(IConsentPersonImplementation, IPersonImplementation, IPersonEntityImplementation, IPersonImageImplementation, IPersonListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `GetUtmParametersAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.PhoneListAgent is Modified

* Deleted items
  * Method `PhoneListAgent(IPhoneListImplementation, IPhoneListPreferencesImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `PhoneListAgent(IPhoneListImplementation, IPhoneListPreferencesImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.PocketAgent is Modified

* Deleted items
  * Method `PocketAgent(ICallerIDImplementation, IPocketStartupDataImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `PocketAgent(ICallerIDImplementation, IPocketStartupDataImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.PreferenceAgent is Modified

* Deleted items
  * Method `PreferenceAgent(IPreferenceImplementation, IPreferenceDescriptionImplementation, IPreferenceDescriptionLineImplementation, IPreferenceListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `PreferenceAgent(IPreferenceImplementation, IPreferenceDescriptionImplementation, IPreferenceDescriptionLineImplementation, IPreferenceListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.ProjectAgent is Modified

* Deleted items
  * Method `ProjectAgent(IProjectImplementation, IProjectEntityImplementation, IProjectEventImplementation, IProjectEventEntityImplementation, IProjectEventListImplementation, IProjectListImplementation, IProjectMemberImplementation, IProjectMemberListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `ProjectAgent(IProjectImplementation, IProjectEntityImplementation, IProjectEventImplementation, IProjectEventEntityImplementation, IProjectEventListImplementation, IProjectListImplementation, IProjectMemberImplementation, IProjectMemberListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `SetCompletedAsync(Int32, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.QuoteAgent is Modified

* Deleted items
  * Method `QuoteAgent(IFieldMetadataImplementation, IPriceListImplementation, IProductImplementation, IQuoteImplementation, IQuoteAlternativeImplementation, IQuoteConnectionImplementation, IQuoteEntityImplementation, IQuoteLineImplementation, IQuoteLineConfigurationImplementation, IQuoteVersionImplementation, IQuoteVersionAttachmentImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `QuoteAgent(IFieldMetadataImplementation, IPriceListImplementation, IProductImplementation, IQuoteImplementation, IQuoteAlternativeImplementation, IQuoteConnectionImplementation, IQuoteEntityImplementation, IQuoteLineImplementation, IQuoteLineConfigurationImplementation, IQuoteVersionImplementation, IQuoteVersionAttachmentImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.RelationAgent is Modified

* Deleted items
  * Method `RelationAgent(IContactRelationEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `RelationAgent(IContactRelationEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.ReportAgent is Modified

* Deleted items
  * Method `ReportAgent(IReportLabelLayoutEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `ReportAgent(IReportLabelLayoutEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.ResourceAgent is Modified

* Deleted items
  * Method `ResourceAgent(IResourceOverrideImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `ResourceAgent(IResourceOverrideImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.SaintAgent is Modified

* Deleted items
  * Method `SaintAgent(ISaintConfigurationImplementation, IStatusMonitorImplementation, IStatusMonitorPeriodsImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `SaintAgent(ISaintConfigurationImplementation, IStatusMonitorImplementation, IStatusMonitorPeriodsImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.SaleAgent is Modified

* Deleted items
  * Method `SaleAgent(ISaleImplementation, ISaleEntityImplementation, ISaleListImplementation, ISaleStakeholderImplementation, ISaleStakeholderListImplementation, ISaleSummaryImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `SaleAgent(ISaleImplementation, ISaleEntityImplementation, ISaleListImplementation, ISaleStakeholderImplementation, ISaleStakeholderListImplementation, ISaleSummaryImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.SelectionAgent is Modified

* Deleted items
  * Method `SelectionAgent(ISelectionEntityImplementation, ISelectionForFindImplementation, ISelectionSummaryItemImplementation, ITypicalSearchesImplementation, ISoRequestItemsAccessor)`
  * Method `SelectionAgent(ISelectionEntityImplementation, ISelectionForFindImplementation, ISelectionSummaryItemImplementation, ITypicalSearchesImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `SelectionAgent(IBoardViewSettingsBaseImplementation, ISelectionEntityImplementation, ISelectionForFindImplementation, ISelectionSummaryItemImplementation, ITypicalSearchesImplementation, ISoRequestItemsAccessor)`
  * Method `SelectionAgent(IBoardViewSettingsBaseImplementation, ISelectionEntityImplementation, ISelectionForFindImplementation, ISelectionSummaryItemImplementation, ITypicalSearchesImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `CreateDefaultBoardViewSettingsFromEntityTypeAsync(BoardViewEntityType, CancellationToken)`
  * Method `DeleteBoardViewSettingsAsync(Int32, CancellationToken)`
  * Method `GetBoardViewSettingsAsync(Int32, CancellationToken)`
  * Method `GetBoardViewSettingsForSelectionAsync(Int32, Int32, CancellationToken)`
  * Method `SaveBoardViewSettingsAsync(BoardViewSettingsBase, CancellationToken)`

#### SuperOffice.CRM.Services.SentryAgent is Modified

* Deleted items
  * Method `SentryAgent(ISentryImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `SentryAgent(ISentryImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.TargetsAgent is Modified

* Deleted items
  * Method `TargetsAgent(ITargetAssignmentImplementation, ITargetDimensionImplementation, ITargetGroupImplementation, ITargetRevisionImplementation, ITargetRevisionHistoryImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `TargetsAgent(ITargetAssignmentImplementation, ITargetDimensionImplementation, ITargetGroupImplementation, ITargetRevisionImplementation, ITargetRevisionHistoryImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* Deleted items
  * Method `TicketAgent(IAttachmentEntityImplementation, ITicketImplementation, ITicketEntityImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketSummaryItemImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `TicketAgent(IAttachmentEntityImplementation, ITicketImplementation, ITicketEntityImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketSummaryItemImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.TimeZoneAgent is Modified

* Deleted items
  * Method `TimeZoneAgent(IPreferredTimeZoneImplementation, IRemoteTimeZoneMethodsImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `TimeZoneAgent(IPreferredTimeZoneImplementation, IRemoteTimeZoneMethodsImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.UserAgent is Modified

* Deleted items
  * Method `UserAgent(IAccessGatewayInfoImplementation, ICredentialImplementation, IRoleImplementation, IRoleEntityImplementation, IServiceAuthImplementation, ITokenManagementInfoImplementation, IUntrustedCredentialsImplementation, IUserImplementation, IUserGroupImplementation, IUserGroupListImplementation, IUserInfoImplementation, IUserInfoListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `UserAgent(IAccessGatewayInfoImplementation, ICredentialImplementation, IRoleImplementation, IRoleEntityImplementation, IServiceAuthImplementation, ITokenManagementInfoImplementation, IUntrustedCredentialsImplementation, IUserImplementation, IUserGroupImplementation, IUserGroupListImplementation, IUserInfoImplementation, IUserInfoListImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.UserDefinedFieldInfoAgent is Modified

* Deleted items
  * Method `UserDefinedFieldInfoAgent(IFieldInfoBaseImplementation, IUserDefinedFieldInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `UserDefinedFieldInfoAgent(IFieldInfoBaseImplementation, IUserDefinedFieldInfoImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.ViewStateAgent is Modified

* Deleted items
  * Method `ViewStateAgent(ILiveUiConfigImplementation, IHistoryImplementation, IHistoryListImplementation, IUiEventImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `ViewStateAgent(ILiveUiConfigImplementation, IHistoryImplementation, IHistoryListImplementation, IUiEventImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.WebhookAgent is Modified

* Deleted items
  * Method `WebhookAgent(IWebhookImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `WebhookAgent(IWebhookImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`

#### SuperOffice.CRM.Services.WorkflowAgent is Modified

* Deleted items
  * Method `WorkflowAgent(IEmailFlowImplementation, IWorkflowEventImplementation, IWorkflowEventResultImplementation, IWorkflowFilterImplementation, IWorkflowGoalImplementation, IWorkflowStepBaseImplementation, IWorkflowStepOptionBaseImplementation, IWorkflowTriggerImplementation, IWorkflowWaitForActionImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository)`
* New items
  * Method `WorkflowAgent(IEmailFlowImplementation, IWorkflowEventImplementation, IWorkflowEventResultImplementation, IWorkflowFilterImplementation, IWorkflowGoalImplementation, IWorkflowStepBaseImplementation, IWorkflowStepOptionBaseImplementation, IWorkflowTriggerImplementation, IWorkflowWaitForActionImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.Diagnostics.LogElement`
* `SuperOffice.Diagnostics.LogEntryInfo`
* `SuperOffice.Diagnostics.SoEventRecorder`

### New Types

* `Microsoft.Extensions.Logging.ILoggerExtensions`
* `SuperOffice.Data.BoardViewEntityType`
* `SuperOffice.Data.CategoryGroup`
* `SuperOffice.Data.EjScriptVerb`
* `SuperOffice.Exceptions.SoMissingDatabaseContextException`

### Modified Types

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.Diagnostics is Modified

* Deleted items
  * Property `.DiagnosticsLogEventRecorder`


##### SuperOffice.Configuration.ConfigFile.IDiagnosticsConfiguration is Modified

* Deleted items
  * Property `.IDiagnosticsConfigurationLogEventRecorder`

* New items
  * Method `GetAppSetting(String)`

#### SuperOffice.Configuration.File.ConfigFileSection is Modified

* Deleted items
  * Method `ConfigFileSection(ConfigFileFacade, IConfiguration, String)`
* New items
  * Method `ConfigFileSection(IServiceScopeFactory, IConfiguration, String)`

#### SuperOffice.Configuration.VersionPropertyNames is Modified

* New items
  * Field `CollectSoConnectionStack`

#### SuperOffice.CRM.Security.EOwnershipIndex is Modified

* New items
  * Field `CustomObjects`

#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.SalesNotification is Modified

* New items
  * Field `.SalesNotificationNotifyCompanyAssignment`

* New items

##### SuperOffice.CRM.UserPreferenceStrings.Mailing is New

#### SuperOffice.Data.DashTileType is Modified

* New items
  * Field `Funnel`

#### SuperOffice.Data.EventHandlerType is Modified

* New items
  * Field `SalesLoadTicket`
  * Field `SalesLoadTicketMessage`

#### SuperOffice.Data.GuideStepConstants is Modified

* New items
  * Field `ProjectTypeIDs`

#### SuperOffice.Data.NotifyType is Modified

* New items
  * Field `ContactAssignment`

#### SuperOffice.Diagnostics.ServiceCall is Modified

* New items
  * Method `ToString()`

#### SuperOffice.Diagnostics.SimplePeriodicGrafanaReporter is Modified

* New items
  * Property `LoggingIsActive`

#### SuperOffice.Diagnostics.SoLogger is Modified

* Deleted items
  * Method `LogException(EventLogEntryType, Exception, Boolean)`
  * Method `PopulateEnvironmentInfo(LogEntryInfo)`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_LISTS_CATEGORYGROUP`
  * Field `SR_ADMIN_LISTS_ENABLE_LEADSTATUS`
  * Field `SR_APPOINTMENT_IMAGE_WARNING`
  * Field `SR_APPOINTMENT_IMAGES_RESIZED`
  * Field `SR_BOARD_INVALID_REQUEST_PRIORITY`
  * Field `SR_BOARD_INVALID_REQUEST_STATUS`
  * Field `SR_BOARD_INVALID_REQUEST_TYPE`
  * Field `SR_BOARD_NO_FILTERS`
  * Field `SR_BOARD_REQUEST_SELECT_REQUEST_CLOSED_STATUS`
  * Field `SR_BOARD_REQUEST_SET_TO_CLOSED`
  * Field `SR_BOARD_SELECT_FUTURE_DATE`
  * Field `SR_CATEGORYGROUP_CUSTOMER`
  * Field `SR_CATEGORYGROUP_LOST`
  * Field `SR_CATEGORYGROUP_PARTNER`
  * Field `SR_CATEGORYGROUP_POTENTIAL`
  * Field `SR_CRITERION_PREV_YEAR`
  * Field `SR_CUSTOMOBJECT_NO_CREATE_ACCESS`
  * Field `SR_CUSTOMOBJECT_NO_ITEMS_DEFINED`
  * Field `SR_DASHBOARD_ADD_QUICK_FILTER`
  * Field `SR_DASHBOARD_CHART_TYPE_FUNNEL`
  * Field `SR_DASHBOARD_COPY_LINK`
  * Field `SR_DASHBOARD_EDIT_FUNNEL_NECK_HEIGHT`
  * Field `SR_DASHBOARD_EDIT_FUNNEL_NECK_WITH`
  * Field `SR_DASHBOARD_ENABLE_SERIES`
  * Field `SR_DASHBOARD_QUICK_FILTER`
  * Field `SR_FAVOURITE_CUSTOMOBJECT`
  * Field `SR_LISTITEM_TEXT_TOO_LONG`
  * Field `SR_MAILLOGIN_CONNECT_TO_EMAIL_SERVICE`
  * Field `SR_PD_Mail_PreferredEmailConnection_DESC`
  * Field `SR_PD_Mail_PreferredEmailConnection_NAME`
  * Field `SR_PD_Mailing_EnableUTMSaving_DESC`
  * Field `SR_PD_Mailing_EnableUTMSaving_NAME`
  * Field `SR_PD_serviceSettings_anonymizeUsersOnReply_DESC`
  * Field `SR_PD_serviceSettings_anonymizeUsersOnReply_NAME`
  * Field `SR_PDL_Mail_PreferredEmailConnection_1`
  * Field `SR_PDL_Mail_PreferredEmailConnection_2`
  * Field `SR_SENTRY_CUSTOM_OBJECTS`
  * Field `SR_TICKETARCHIVE_PRIORITY_RANK`
  * Field `SR_TICKETARCHIVE_PRIORITY_RANK_TOOLTIP`
  * Field `SR_TICKETARCHIVE_TICKETSTATUS_RANK`
  * Field `SR_TICKETARCHIVE_TICKETSTATUS_RANK_TOOLTIP`
  * Field `SR_UTM_ARCHIVECOLUMN_TOOLTIP`
  * Field `SR_UTM_CAMPAIGN`
  * Field `SR_UTM_CONTENT`
  * Field `SR_UTM_MEDIUM`
  * Field `SR_UTM_REFERRER_DOMAIN`
  * Field `SR_UTM_SOURCE`
  * Field `SR_UTM_TERM`
  * Field `SR_UTM_WEBFORM`

#### SuperOffice.License.SoLicenseNames is Modified

* New items
  * Field `UtmSaving`

#### SuperOffice.Threading.AsyncQueueProcessor<TQueue, TItem> is Modified

* Deleted items
  * Method `AsyncQueueProcessor(TQueue)`
* New items
  * Method `AsyncQueueProcessor(TQueue, ILogger<AsyncQueueProcessor<TQueue, TItem>>)`
  * Method `OuterProcessItemAsync(IAsyncQueueProcessItemContext<TItem>, CancellationToken)`

#### SuperOffice.Threading.TaskHelper is Modified

* New items
  * Method `WhenAllBatched<T>(IEnumerable<Task<T>>, Int32)`
  * Method `WhenAllBatched(IEnumerable<Task>, Int32)`

#### SuperOffice.Util.ImageUtilities is Modified

* Deleted items
  * Method `ResolveUrlOrBase64ImageNoReduction(String)`
* New items
  * Method `GetImageTypeFromBytes(Byte[], String)`
  * Method `ResolveUrlOrBase64ImageNoReductionAsync(String, CancellationToken)`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.Data.BoardViewSettingsTableInfo`
* `SuperOffice.CRM.Data.UtmParametersTableInfo`
* `SuperOffice.CRM.Entities.NotificationHelper`
* `SuperOffice.CRM.ExtraTableHelper`
* `SuperOffice.CRM.Rows.BoardViewSettingsRecordData`
* `SuperOffice.CRM.Rows.BoardViewSettingsRecordDataExtensions`
* `SuperOffice.CRM.Rows.BoardViewSettingsRow`
* `SuperOffice.CRM.Rows.BoardViewSettingsRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateBoardViewSettingsRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateBoardViewSettingsRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateUtmParametersRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateUtmParametersRowsFactory`
* `SuperOffice.CRM.Rows.UtmParametersRecordData`
* `SuperOffice.CRM.Rows.UtmParametersRecordDataExtensions`
* `SuperOffice.CRM.Rows.UtmParametersRow`
* `SuperOffice.CRM.Rows.UtmParametersRows`
* `SuperOffice.CRM.Security.CustomObjectSentry`
* `SuperOffice.CRM.Security.CustomObjectSentryQueryInfo`
* `SuperOffice.Data.SQL.BoardViewEntityTypeFieldInfo`
* `SuperOffice.Data.SQL.CategoryGroupFieldInfo`
* `SuperOffice.Data.SQL.EjScriptVerbFieldInfo`

### Modified Types

#### SuperOffice.CRM.Cache.AssociateCache is Modified

* New items
  * Method `GetEncodedAssociateImageAsync(Int32, Int32, Int32)`

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_BoardViewSettings_AssociateId`
  * Property `LeftOuterJoin_BoardViewSettings_RegisteredAssociateId`
  * Property `LeftOuterJoin_BoardViewSettings_UpdatedAssociateId`
  * Property `LeftOuterJoin_UtmParameters_RegisteredAssociateId`
  * Property `LeftOuterJoin_UtmParameters_UpdatedAssociateId`

#### SuperOffice.CRM.Data.CategoryTableInfo is Modified

* New items
  * Property `CategoryGroup`
  * Property `EnableLeadStatus`

#### SuperOffice.CRM.Data.ContactTableInfo is Modified

* New items
  * Property `LeftOuterJoin_Notify_ContactId`
  * Property `LeftOuterJoin_UtmParameters_CreatedContactId`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.CategoryFields is Modified

* New items
  * Field `.CategoryFieldsCategoryGroup`
  * Field `.CategoryFieldsEnableLeadStatus`


##### SuperOffice.CRM.Data.DBC.EjscriptFields is Modified

* New items
  * Field `.EjscriptFieldsBlockedVerbs`


##### SuperOffice.CRM.Data.DBC.ExtraTablesFields is Modified

* New items
  * Field `.ExtraTablesFieldsTableNumber`


##### SuperOffice.CRM.Data.DBC.NotifyFields is Modified

* New items
  * Field `.NotifyFieldsContactId`
  * Field `.NotifyFieldsPersonId`

* New items
  * Field `BoardViewSettings`
  * Field `UtmParameters`

##### SuperOffice.CRM.Data.DBC.BoardViewSettingsFields is New

##### SuperOffice.CRM.Data.DBC.UtmParametersFields is New

#### SuperOffice.CRM.Data.EjscriptTableInfo is Modified

* New items
  * Property `BlockedVerbs`

#### SuperOffice.CRM.Data.ExtraTablesTableInfo is Modified

* New items
  * Property `TableNumber`

#### SuperOffice.CRM.Data.FormSubmissionTableInfo is Modified

* New items
  * Property `LeftOuterJoin_UtmParameters_FormSubmissionId`

#### SuperOffice.CRM.Data.NotifyTableInfo is Modified

* New items
  * Property `ContactId`
  * Property `ContactId_InnerJoin_Contact`
  * Property `PersonId`
  * Property `PersonId_InnerJoin_Person`

#### SuperOffice.CRM.Data.PersonTableInfo is Modified

* New items
  * Property `LeftOuterJoin_Notify_PersonId`
  * Property `LeftOuterJoin_UtmParameters_CreatedPersonId`

#### SuperOffice.CRM.Data.SelectionTableInfo is Modified

* New items
  * Property `LeftOuterJoin_BoardViewSettings_SelectionId`

#### SuperOffice.CRM.Documents.ArchiveTempFileProvider is Modified

* Deleted items
  * Method `ArchiveTempFileProvider()`
* New items
  * Method `ArchiveTempFileProvider(ILogger<ArchiveTempFileProvider>)`

#### SuperOffice.CRM.Documents.SoArc2 is Modified

* Deleted items
  * Method `SoArc2(IConfiguration)`
* New items
  * Method `SoArc2(IConfiguration, ILogger<SoArc2>)`

#### SuperOffice.CRM.Lists.MDOProviderBase is Modified

* Modified items
  * Method `GetHistoryIconHint(ListTableRow)`

#### SuperOffice.CRM.ListsHelper is Modified

* New items
  * Method `GetUdListDefinitionIdForSoTable(SoTable)`

#### SuperOffice.CRM.Rows.CategoryRecordData is Modified

* New items
  * Field `CategoryGroup`
  * Field `EnableLeadStatus`

#### SuperOffice.CRM.Rows.CategoryRow is Modified

* New items
  * Property `CategoryGroup`
  * Property `EnableLeadStatus`

#### SuperOffice.CRM.Rows.CustomTableRow<TTableInfo> is Modified

* New items
  * Method `GetFromPrimaryKeyAsync(TTableInfo, Int32, CancellationToken)`

#### SuperOffice.CRM.Rows.EjscriptRecordData is Modified

* New items
  * Field `BlockedVerbs`

#### SuperOffice.CRM.Rows.EjscriptRow is Modified

* New items
  * Property `BlockedVerbs`

#### SuperOffice.CRM.Rows.ExtraTablesRecordData is Modified

* New items
  * Field `TableNumber`

#### SuperOffice.CRM.Rows.ExtraTablesRow is Modified

* New items
  * Property `TableNumber`

#### SuperOffice.CRM.Rows.NotifyRecordData is Modified

* New items
  * Field `ContactId`
  * Field `PersonId`

#### SuperOffice.CRM.Rows.NotifyRow is Modified

* New items
  * Property `ContactId`
  * Property `PersonId`

#### SuperOffice.CRM.Rows.NotifyRows is Modified

* New items
  * Method `GetFromIdxContactIdAsync(Int32, CancellationToken)`
  * Method `GetFromIdxPersonIdAsync(Int32, CancellationToken)`

##### SuperOffice.CRM.Rows.NotifyRows.IdxContactId is New

##### SuperOffice.CRM.Rows.NotifyRows.IdxPersonId is New

#### SuperOffice.CRM.Rows.RowDefaulter is Modified

* New items
  * Method `SetDefaultsAsync(SORLabelLayoutRow, DefaulterStrategy, CancellationToken)`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(BoardViewEntityType&, FieldInfo)`
  * Method `ValidateField(CategoryGroup&, FieldInfo)`
  * Method `ValidateField(EjScriptVerb&, FieldInfo)`

#### SuperOffice.CRM.Sale.QuoteDocumentGenerator is Modified

* Modified items
  * Method `MergeToPdf(Stream, Stream, DataSet)`
* New items
  * Method `QuoteDocumentGenerator(ILogger<QuoteDocumentGenerator>)`

#### SuperOffice.CRM.Security.Sentry is Modified

* Modified items
  * Method `IsContactLicenseOwner(Int32)`

##### SuperOffice.CRM.Security.Sentry.DataRightCache is Modified



#### SuperOffice.CRM.Services.Implementation.ServiceFacades.ServiceFacade is Modified

* Modified items
  * Method `CallServiceAsync(String, String, CancellationToken)`
  * Method `FireServiceCall(String, Object)`
* New items
  * Method `ServiceFacade(ILogger<ServiceFacade>)`

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* New items
  * Method `NotifyNewTicketMessageAsync(Int32)`

#### SuperOffice.CRM.Webhooks.WebhookSoftTriggerPlugin is Modified

* Modified items
  * Method `AddField(Dictionary<String, Object>, String, TableRowBase)`

#### SuperOffice.Data.Dialect.Dialect is Modified

* Modified items

##### SuperOffice.Data.Dialect.Dialect.NonParameterizedInt is Modified



#### SuperOffice.Data.ServicePreferenceMapper is Modified

* New items
  * Method `ServicePreferenceMapper(ServicePreferenceMappings, ICacheManager)`

#### SuperOffice.Data.ServicePreferenceMappings is Modified

* Modified items
  * Method `ServicePreferenceMappings()`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetBoardViewSettingsTableInfo()`
  * Method `GetUtmParametersTableInfo()`


### Assembly: SoDatabase.BusinessLogic

### New Types

* `SuperOffice.CRM.ArchiveLists.AssignmentCompanyNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.AssignmentCompanyNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.AssignmentNotificationExtenderBase`
* `SuperOffice.CRM.ArchiveLists.AssignmentNotificationProvider`
* `SuperOffice.CRM.ArchiveLists.AssignmentPersonNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.AssignmentPersonNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.ContactUtmParamatersExtender`
* `SuperOffice.CRM.ArchiveLists.CustomObjectFavouritesProvider`
* `SuperOffice.CRM.ArchiveLists.FavouriteCustomObjectExtender`
* `SuperOffice.CRM.ArchiveLists.FormSubmissionUtmParamatersExtender`
* `SuperOffice.CRM.ArchiveLists.PersonUtmParamatersExtender`
* `SuperOffice.CRM.ArchiveLists.UtmParametersExtenderBase`
* `SuperOffice.CRM.Lists.CategoryGroupProvider`
* `SuperOffice.CRM.Lists.CustomObjectFavouriteListProvider`
* `SuperOffice.Data.Dialect.PostgreSqlDialect`
* `SuperOffice.Data.Dialect.PostgreSqlMassOperations`
* `SuperOffice.Data.Dialect.PostgreSqlMassOperationsV2`
* `SuperOffice.Data.Dialect.PostgreSqlOperations`
* `SuperOffice.Util.BizCardResult`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.ActivityArchiveProviderBase is Modified

* New items
  * Field `EntityMailing`

#### SuperOffice.CRM.ArchiveLists.ExtraFieldExtenderBase is Modified


#### SuperOffice.CRM.ArchiveLists.TicketMessageExtenderBase is Modified


#### SuperOffice.CRM.ArchiveLists.TicketPriorityExtenderBase is Modified


#### SuperOffice.CRM.ArchiveLists.TicketStatusExtenderBase is Modified


#### SuperOffice.CRM.Entities.AppointmentMatrix is Modified

* Deleted items
  * Method `AppointmentMatrix(Appointment, RecurrenceUpdateMode, ICalendarUtility, IAppointmentUtility, IBookingManager)`
* New items
  * Method `AppointmentMatrix(Appointment, RecurrenceUpdateMode, ICalendarUtility, IAppointmentUtility, IBookingManager, ILogger<AppointmentMatrix>)`

#### SuperOffice.CRM.Entities.RecurrenceManager is Modified

* New items
  * Method `UpdateFromRecord(RecurrenceInfo, RecurrenceRuleRecordData, DateTime)`

#### SuperOffice.CRM.Lists.AssociateMDOProviderBase is Modified

* Modified items
  * Method `GetHistoryIconHint(ListTableRow)`

#### SuperOffice.CRM.Lists.EnrichContactProvider is Modified

* Deleted items
  * Method `EnrichContactProvider()`
* New items
  * Property `IsUnitTestMode`
  * Method `EnrichContactProvider(ILogger<EnrichContactProvider>)`

#### SuperOffice.CRM.Lists.ExtraTableDropdownProvider is Modified

* Modified items
  * Method `GetHistoryItemsAsync(CancellationToken)`

#### SuperOffice.CRM.Lists.GenericMDOProvider is Modified

* Modified items
  * Method `GetHistoryIconHint(ListTableRow)`

#### SuperOffice.CRM.Lists.ProjectStatusProvider is Modified


#### SuperOffice.CRM.Notification.PushNotificationServiceManager is Modified

* Modified items
  * Method `GetTagFromPushNotificationType(PushNotificationType)`

#### SuperOffice.CRM.Tooltips.MailItemTooltipPlugin is Modified

* Deleted items
  * Method `MailItemTooltipPlugin()`
* New items
  * Method `MailItemTooltipPlugin(ILogger<MailItemTooltipPlugin>)`

#### SuperOffice.CRM.Webhooks.DefaultWebhookPlugin is Modified

* Deleted items
  * Method `DefaultWebhookPlugin(IWebhookTransmitter)`
* New items
  * Method `DefaultWebhookPlugin(IWebhookTransmitter, ILogger<DefaultWebhookPlugin>)`

#### SuperOffice.CRM.Webhooks.WebhookDispatcher is Modified

* Deleted items
  * Method `WebhookDispatcher(IWebhookManager, IAsyncQueue<WebhookTaskInfo>)`
* New items
  * Method `WebhookDispatcher(IWebhookManager, IAsyncQueue<WebhookTaskInfo>, ILogger<WebhookDispatcher>)`

#### SuperOffice.CRM.Webhooks.WebhookManager is Modified

* Deleted items
  * Method `WebhookManager(IAsyncQueue<WebhookTaskInfo>, IAsyncQueue<DelayedItem<RetryWebhook>>, INSPrincipalAccessor, IServiceProvider, ILogger<WebhookManager>)`
* New items
  * Method `WebhookManager(IAsyncQueue<WebhookTaskInfo>, IAsyncQueue<DelayedItem<RetryWebhook>>, ISoRequestItemsAccessor, IServiceScopeFactory)`

#### SuperOffice.Data.Dialect.MassOperations is Modified

* Modified items
  * Method `GetTargetInformation(String)`
  * Method `ReformatColumnsForImport(SoTable, String[], IEnumerable<String[]>, Int32[], Dictionary<ComplexKey, RowInfo>, UDefType, Dictionary<Int32, Int32>, List<List<String>>)`
  * Method `ToCarrierStatus(Int32)`
  * Method `VerifyRights()`

##### SuperOffice.Data.Dialect.MassOperations.ERowStatus is Modified



##### SuperOffice.Data.Dialect.MassOperations.RowInfo is Modified


* New items
  * Method `GetUpdateTargetFromTempSql(SoTable, SoTable, SoField, SoField, SoField, IEnumerable<String>)`
  * Method `GetUpdateTempTableWithDataMatchSql(SoTable, SoTable, SoField, SoField, SoField, IEnumerable<String>)`
  * Method `GetUpdateTempTableWithKeyMatchSql(SoTable, SoTable, SoField, SoField, SoField, IEnumerable<String>)`
  * Method `GetUpdateTempTableWithNewKeysSql(SoTable, SoTable, SoField, SoField, SoField, IEnumerable<String>)`
  * Method `GetZeroOutColumnsSql(SoTable, SoTable, SoField, SoField, SoField[])`

#### SuperOffice.Data.Dialect.OracleMassOperations is Modified

* New items
  * Method `GetUpdateTargetFromTempSql(SoTable, SoTable, SoField, SoField, SoField, IEnumerable<String>)`
  * Method `GetUpdateTempTableWithDataMatchSql(SoTable, SoTable, SoField, SoField, SoField, IEnumerable<String>)`
  * Method `GetUpdateTempTableWithKeyMatchSql(SoTable, SoTable, SoField, SoField, SoField, IEnumerable<String>)`
  * Method `GetUpdateTempTableWithNewKeysSql(SoTable, SoTable, SoField, SoField, SoField, IEnumerable<String>)`
  * Method `GetZeroOutColumnsSql(SoTable, SoTable, SoField, SoField, SoField[])`

#### SuperOffice.Data.Dialect.SqlServerMassOperations is Modified

* New items
  * Method `GetUpdateTargetFromTempSql(SoTable, SoTable, SoField, SoField, SoField, IEnumerable<String>)`
  * Method `GetUpdateTempTableWithDataMatchSql(SoTable, SoTable, SoField, SoField, SoField, IEnumerable<String>)`
  * Method `GetUpdateTempTableWithKeyMatchSql(SoTable, SoTable, SoField, SoField, SoField, IEnumerable<String>)`
  * Method `GetUpdateTempTableWithNewKeysSql(SoTable, SoTable, SoField, SoField, SoField, IEnumerable<String>)`
  * Method `GetZeroOutColumnsSql(SoTable, SoTable, SoField, SoField, SoField[])`

#### SuperOffice.Data.UdefPublishHelper is Modified

* Deleted items
  * Method `UdefPublishHelper(IUdefHelper, ISystemEventHelper)`
* New items
  * Method `UdefPublishHelper(IUdefHelper, ISystemEventHelper, ILogger<UdefPublishHelper>)`

#### SuperOffice.Util.RagAIConfiguration is Modified

* Deleted items
  * Property `AppClientSecret`
  * Property `Fileset_Audience`
  * Property `Fileset_PrincipalName`
  * Property `Fileset_SigningKey`
* New items
  * Property `OverrideContextIdentifier`

#### SuperOffice.Util.RagAIHelper is Modified

* Deleted items
  * Method `RagAIHelper(IOptions<RagAIConfiguration>, ILogger<RagAIHelper>)`
* New items
  * Method `RagAIHelper(IOptions<RagAIConfiguration>, ILogger<RagAIHelper>, ICacheManager)`


### Assembly: SoLicense

### Modified Types

#### SuperOffice.License.SignatureCreator is Modified

* Deleted items
  * Method `SignatureCreator(SignedPublicKey, DSACryptoServiceProvider, ILogger)`
* New items
  * Method `SignatureCreator(SignedPublicKey, DSACryptoServiceProvider, ILogger<SignatureCreator>)`

#### SuperOffice.License.SignatureValidator is Modified

* Deleted items
  * Method `SignatureValidator(SignedPublicKey, ILogger)`
* New items
  * Method `SignatureValidator(SignedPublicKey, ILogger<SignatureValidator>)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.BoardViewEntityType`
* `SuperOffice.CD.Database.CategoryGroup`
* `SuperOffice.CD.DSL.Database.EjScriptVerb`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_61_EjscriptVerb`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_62_ExtraTables_TableNum`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_63_ExtraTables_TableNumValue`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_64_Model_NextTableNumber`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_65_Model_NextTableNumberFix`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_122_AssignmentNotification`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_123_UTMParameters`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_124_CategoryGroups`
* `SuperOffice.CD.DSL.Database.T_BoardViewSettings`
* `SuperOffice.CD.DSL.Database.T_UtmParameters`

### Modified Types

#### SuperOffice.CD.Database.DashTileType is Modified

* New items
  * Field `Funnel`

#### SuperOffice.CD.Database.RoleRelationToOwner is Modified

* New items
  * Field `CustomObjects`

#### SuperOffice.CD.DSL.Database.EventHandlerType is Modified

* New items
  * Field `SalesLoadTicket`
  * Field `SalesLoadTicketMessage`

#### SuperOffice.CD.DSL.Database.NotifyType is Modified

* New items
  * Field `ContactAssignment`

#### SuperOffice.CD.DSL.Database.T_Category is Modified

* New items
  * Field `CategoryGroup`
  * Field `EnableLeadStatus`

#### SuperOffice.CD.DSL.Database.T_Ejscript is Modified

* New items
  * Field `BlockedVerbs`

#### SuperOffice.CD.DSL.Database.T_ExtraTables is Modified

* New items
  * Field `TableNumber`

#### SuperOffice.CD.DSL.Database.T_Notify is Modified

* New items
  * Field `ContactId`
  * Field `PersonId`



