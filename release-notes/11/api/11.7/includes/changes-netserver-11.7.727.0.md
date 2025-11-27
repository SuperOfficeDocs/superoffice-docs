---
uid: version_11.7.727.0_changes
date: 27.11.2025
---

Changes from v11.6.943.0 and v11.7.727.0

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.AutomatedCategoryUpdate`
* `SuperOffice.CRM.Services.CopilotDataSourceEntity`
* `SuperOffice.CRM.Services.CopilotDataSourceSetting`
* `SuperOffice.CRM.Services.CopilotEntity`
* `SuperOffice.CRM.Services.FormDesignCarrier`

### Modified Types

#### SuperOffice.CRM.Services.IAIAgent is Modified

* New items
  * Method `CreateDefaultCopilotDataSourceEntityAsync(CancellationToken)`
  * Method `CreateDefaultCopilotEntityAsync(CancellationToken)`
  * Method `DeleteCopilotDataSourceEntityAsync(Int32, CancellationToken)`
  * Method `DeleteCopilotEntityAsync(Int32, CancellationToken)`
  * Method `GetCopilotDataSourceEntityAsync(Int32, CancellationToken)`
  * Method `GetCopilotEntityAsync(Int32, CancellationToken)`
  * Method `GetFormDesignFromImageAsync(Stream, CancellationToken)`
  * Method `GetFormDesignFromUrlAsync(String, CancellationToken)`
  * Method `SaveCopilotDataSourceEntityAsync(CopilotDataSourceEntity, CancellationToken)`
  * Method `SaveCopilotEntityAsync(CopilotEntity, CancellationToken)`

#### SuperOffice.CRM.Services.IListAgent is Modified

* New items
  * Method `GetAllAutomatedCategoryUpdatesAsync(CancellationToken)`
  * Method `GetNeedCategoryUpdateForPersonAsync(Int32, Int32, Int32, Int32, CancellationToken)`
  * Method `GetNeedCategoryUpdateForSaleAsync(SaleStatus, Int32, Int32, Int32, CancellationToken)`
  * Method `SaveAllAutomatedCategoryUpdatesAsync(AutomatedCategoryUpdate[], CancellationToken)`


### Assembly: SuperOffice.Services.Implementation

### Deleted Types

* `SuperOffice.CRM.Services.Implementation.Util.PreferenceHelper`

### New Types

* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IAutomatedCategoryUpdateImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICopilotDataSourceEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICopilotEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IFormDesignCarrierImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.CopilotEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.FormDesignCarrierImplementation`

### Modified Types

#### SuperOffice.CRM.Services.AIAgent is Modified

* Deleted items
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ISentimentImplementation, IRagAnswerImplementation, IRagResultImplementation, ISummarizerImplementation, ISoRequestItemsAccessor)`
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ISentimentImplementation, IRagAnswerImplementation, IRagResultImplementation, ISummarizerImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ICopilotDataSourceEntityImplementation, ICopilotEntityImplementation, IFormDesignCarrierImplementation, ISentimentImplementation, IRagAnswerImplementation, IRagResultImplementation, ISummarizerImplementation, ISoRequestItemsAccessor)`
  * Method `AIAgent(ITextServicesImplementation, IBizCardImplementation, ICategorizationStatusResponseImplementation, ICategoryGuessImplementation, IChatbotTurnImplementation, ICopilotDataSourceEntityImplementation, ICopilotEntityImplementation, IFormDesignCarrierImplementation, ISentimentImplementation, IRagAnswerImplementation, IRagResultImplementation, ISummarizerImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `CreateDefaultCopilotDataSourceEntityAsync(CancellationToken)`
  * Method `CreateDefaultCopilotEntityAsync(CancellationToken)`
  * Method `DeleteCopilotDataSourceEntityAsync(Int32, CancellationToken)`
  * Method `DeleteCopilotEntityAsync(Int32, CancellationToken)`
  * Method `GetCopilotDataSourceEntityAsync(Int32, CancellationToken)`
  * Method `GetCopilotEntityAsync(Int32, CancellationToken)`
  * Method `GetFormDesignFromImageAsync(Stream, CancellationToken)`
  * Method `GetFormDesignFromUrlAsync(String, CancellationToken)`
  * Method `SaveCopilotDataSourceEntityAsync(CopilotDataSourceEntity, CancellationToken)`
  * Method `SaveCopilotEntityAsync(CopilotEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CustomerServiceStartupImplementation is Modified

* Deleted items
  * Method `CustomerServiceStartupImplementation(IPreferenceImplementation)`
* New items
  * Method `CustomerServiceStartupImplementation(IPreferenceImplementation, ICacheManager)`

#### SuperOffice.CRM.Services.ListAgent is Modified

* Deleted items
  * Method `ListAgent(IAmountClassEntityImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryEntityImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor)`
  * Method `ListAgent(IAmountClassEntityImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryEntityImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `ListAgent(IAmountClassEntityImplementation, IAutomatedCategoryUpdateImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryEntityImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor)`
  * Method `ListAgent(IAmountClassEntityImplementation, IAutomatedCategoryUpdateImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryEntityImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `GetAllAutomatedCategoryUpdatesAsync(CancellationToken)`
  * Method `GetNeedCategoryUpdateForPersonAsync(Int32, Int32, Int32, Int32, CancellationToken)`
  * Method `GetNeedCategoryUpdateForSaleAsync(SaleStatus, Int32, Int32, Int32, CancellationToken)`
  * Method `SaveAllAutomatedCategoryUpdatesAsync(AutomatedCategoryUpdate[], CancellationToken)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `.CharExtenssions`

### New Types

* `.CharExtensions`
* `SuperOffice.Data.CategoryUpdateTrigger`
* `SuperOffice.Data.CopilotDataSourceType`
* `SuperOffice.Data.TicketRelationType`
* `SuperOffice.Exceptions.SoFunctionRightException`

### Modified Types

#### .StringExtensions is Modified

* New items
  * Method `ValidateSecureFilePath(String)`

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.Client is Modified

* New items
  * Property `.ClientDashboardTileTimeoutSeconds`


##### SuperOffice.Configuration.ConfigFile.IClientConfiguration is Modified

* New items
  * Property `.IClientConfigurationDashboardTileTimeoutSeconds`


#### SuperOffice.Configuration.VersionPropertyNames is Modified

* New items
  * Field `DisconnectDatabaseDuringFlush`

#### SuperOffice.CRM.FunctionRightStrings is Modified

* New items
  * Field `HideMailings`

#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.DataCollection is Modified

* New items
  * Field `.DataCollectionTimeKeeping`


#### SuperOffice.Data.Registry is Modified

* New items
  * Field `TimeKeepingSyncNextRun`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_AI_SERVICE_COPILOT`
  * Field `SR_ADMIN_TICKET_ACTIVE_TICKETRELATIONS`
  * Field `SR_ADMIN_TICKET_CLOSE_PARENT`
  * Field `SR_ADMIN_TICKET_DESCRIPTION`
  * Field `SR_ADMIN_TICKET_DESCRIPTION_USED_AS_A_TOOLTIP`
  * Field `SR_ADMIN_TICKET_OFFER_TO_CLOSE_ALL_RELATED`
  * Field `SR_ADMIN_TICKET_PARENT_RELATIONS_MANDATORY`
  * Field `SR_ADMIN_TICKET_PREVENT_CLOSING_PARENT`
  * Field `SR_ADMIN_TICKET_RELATED_TO_REQUEST_TYPES`
  * Field `SR_ADMIN_TICKET_RELATION_TYPE`
  * Field `SR_ADMIN_TICKET_RELATIONS_FOR_REQUEST_TYPE`
  * Field `SR_ADMIN_TICKET_TICKETRELATIONS`
  * Field `SR_ARCHIVE_STAKEHOLDERS_ENABLED`
  * Field `SR_ARCHIVE_STAKEHOLDERS_ENABLED_TOOLTIP`
  * Field `SR_CATEGORY_UPDATE_CONFIRM_CATEGORY`
  * Field `SR_CATEGORY_UPDATE_CONFIRM_HEADER`
  * Field `SR_CATEGORY_UPDATE_CONFIRM_LEADSTATUS`
  * Field `SR_CATEGORY_UPDATE_CONFIRM_SALELOST`
  * Field `SR_CATEGORY_UPDATE_CONFIRM_SALEREGISTERED`
  * Field `SR_CATEGORY_UPDATE_CONFIRM_SALESOLD`
  * Field `SR_DASHBOARD_LOAD_ANYWAY`
  * Field `SR_DASHBOARD_PROCESSING_TIME_ERROR`
  * Field `SR_DASHBOARD_PROCESSING_TIME_MESSAGE`
  * Field `SR_FORMS_CSS`
  * Field `SR_FORMS_CSS_ADDBUTTON`
  * Field `SR_FORMS_CSS_BACKGROUND`
  * Field `SR_FORMS_CSS_BUTTON`
  * Field `SR_FORMS_CSS_CHECKBOX`
  * Field `SR_FORMS_CSS_CHOOSER`
  * Field `SR_FORMS_CSS_CONSENT`
  * Field `SR_FORMS_CSS_DATE`
  * Field `SR_FORMS_CSS_DATETIME`
  * Field `SR_FORMS_CSS_DECIMAL`
  * Field `SR_FORMS_CSS_DROPDOWN`
  * Field `SR_FORMS_CSS_FORM`
  * Field `SR_FORMS_CSS_ID`
  * Field `SR_FORMS_CSS_IMAGE`
  * Field `SR_FORMS_CSS_INFO`
  * Field `SR_FORMS_CSS_INPUT`
  * Field `SR_FORMS_CSS_INTEGER`
  * Field `SR_FORMS_CSS_PAGE`
  * Field `SR_FORMS_CSS_PAGE_1`
  * Field `SR_FORMS_CSS_PAGEFOOTER`
  * Field `SR_FORMS_CSS_PAGEPROGRESS`
  * Field `SR_FORMS_CSS_PAGES`
  * Field `SR_FORMS_CSS_RADIO`
  * Field `SR_FORMS_CSS_RATING`
  * Field `SR_FORMS_CSS_RATING_DICE`
  * Field `SR_FORMS_CSS_RATING_NPS`
  * Field `SR_FORMS_CSS_RATING_SMILEY`
  * Field `SR_FORMS_CSS_RATING_STARS`
  * Field `SR_FORMS_CSS_RATING_THUMBS`
  * Field `SR_FORMS_CSS_RECAPTCHA`
  * Field `SR_FORMS_CSS_REQUIRED`
  * Field `SR_FORMS_CSS_SUB`
  * Field `SR_FORMS_CSS_TABLE`
  * Field `SR_FORMS_CSS_TEXT`
  * Field `SR_FORMS_CSS_TEXTAREA`
  * Field `SR_FORMS_CSS_TEXTBLOCK`
  * Field `SR_FORMS_CSS_UPLOADFILE`
  * Field `SR_INBOX_CONNECTED_AS`
  * Field `SR_INBOX_SIGN_OUT`
  * Field `SR_TICKET_MESSAGE_SHOW_COMMENTS`
  * Field `SR_TICKET_MESSAGE_SHOW_REPLIES`
  * Field `SR_TICKETREL_RELDEF_NAME1`
  * Field `SR_TICKETREL_RELDEF_NAME2`
  * Field `SR_TICKETREL_RELDEF_NAME3`
  * Field `SR_TICKETREL_RELDEF_TOOLTIP1`
  * Field `SR_TICKETREL_RELDEF_TOOLTIP2`
  * Field `SR_TICKETREL_RELDEF_TOOLTIP3`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.Data.AutomatedCategoryUpdateTableInfo`
* `SuperOffice.CRM.Data.CopilotDataSourceSettingTableInfo`
* `SuperOffice.CRM.Data.CopilotDataSourceTableInfo`
* `SuperOffice.CRM.Data.CopilotTableInfo`
* `SuperOffice.CRM.Data.TicketRelationDefTableInfo`
* `SuperOffice.CRM.Data.TicketRelationTableInfo`
* `SuperOffice.CRM.Data.TicketRelDefTicketTypeTableInfo`
* `SuperOffice.CRM.Rows.AutomatedCategoryUpdateRecordData`
* `SuperOffice.CRM.Rows.AutomatedCategoryUpdateRecordDataExtensions`
* `SuperOffice.CRM.Rows.AutomatedCategoryUpdateRow`
* `SuperOffice.CRM.Rows.AutomatedCategoryUpdateRows`
* `SuperOffice.CRM.Rows.CopilotDataSourceRecordData`
* `SuperOffice.CRM.Rows.CopilotDataSourceRecordDataExtensions`
* `SuperOffice.CRM.Rows.CopilotDataSourceRow`
* `SuperOffice.CRM.Rows.CopilotDataSourceRows`
* `SuperOffice.CRM.Rows.CopilotDataSourceSettingRecordData`
* `SuperOffice.CRM.Rows.CopilotDataSourceSettingRecordDataExtensions`
* `SuperOffice.CRM.Rows.CopilotDataSourceSettingRow`
* `SuperOffice.CRM.Rows.CopilotDataSourceSettingRows`
* `SuperOffice.CRM.Rows.CopilotRecordData`
* `SuperOffice.CRM.Rows.CopilotRecordDataExtensions`
* `SuperOffice.CRM.Rows.CopilotRow`
* `SuperOffice.CRM.Rows.CopilotRows`
* `SuperOffice.CRM.Rows.Implementation.TimeKeepingRowImplementation`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateAutomatedCategoryUpdateRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateAutomatedCategoryUpdateRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateCopilotDataSourceRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateCopilotDataSourceRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateCopilotDataSourceSettingRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateCopilotDataSourceSettingRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateCopilotRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateCopilotRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationDefRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationDefRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelDefTicketTypeRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelDefTicketTypeRowsFactory`
* `SuperOffice.CRM.Rows.TicketRelationDefRecordData`
* `SuperOffice.CRM.Rows.TicketRelationDefRecordDataExtensions`
* `SuperOffice.CRM.Rows.TicketRelationDefRow`
* `SuperOffice.CRM.Rows.TicketRelationDefRows`
* `SuperOffice.CRM.Rows.TicketRelationRecordData`
* `SuperOffice.CRM.Rows.TicketRelationRecordDataExtensions`
* `SuperOffice.CRM.Rows.TicketRelationRow`
* `SuperOffice.CRM.Rows.TicketRelationRows`
* `SuperOffice.CRM.Rows.TicketRelDefTicketTypeRecordData`
* `SuperOffice.CRM.Rows.TicketRelDefTicketTypeRecordDataExtensions`
* `SuperOffice.CRM.Rows.TicketRelDefTicketTypeRow`
* `SuperOffice.CRM.Rows.TicketRelDefTicketTypeRows`
* `SuperOffice.Data.Cache.CacheBlockInformationCollector`
* `SuperOffice.Data.SQL.CategoryUpdateTriggerFieldInfo`
* `SuperOffice.Data.SQL.CopilotDataSourceTypeFieldInfo`
* `SuperOffice.Data.SQL.TicketRelationTypeFieldInfo`

### Modified Types

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_AutomatedCategoryUpdate_RegisteredAssociateId`
  * Property `LeftOuterJoin_AutomatedCategoryUpdate_UpdatedAssociateId`
  * Property `LeftOuterJoin_Copilot_RegisteredAssociateId`
  * Property `LeftOuterJoin_Copilot_UpdatedAssociateId`
  * Property `LeftOuterJoin_CopilotDataSource_RegisteredAssociateId`
  * Property `LeftOuterJoin_CopilotDataSource_UpdatedAssociateId`
  * Property `LeftOuterJoin_CopilotDataSourceSetting_RegisteredAssociateId`
  * Property `LeftOuterJoin_CopilotDataSourceSetting_UpdatedAssociateId`
  * Property `LeftOuterJoin_TicketRelation_RegisteredAssociateId`
  * Property `LeftOuterJoin_TicketRelation_UpdatedAssociateId`
  * Property `LeftOuterJoin_TicketRelationDef_RegisteredAssociateId`
  * Property `LeftOuterJoin_TicketRelationDef_UpdatedAssociateId`

#### SuperOffice.CRM.Data.CategoryTableInfo is Modified

* New items
  * Property `LeftOuterJoin_AutomatedCategoryUpdate_DefaultCategory`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.SShipmentAddrFields is Modified

* New items
  * Field `.SShipmentAddrFieldsOwnerLock`


##### SuperOffice.CRM.Data.DBC.TimeKeepingFields is Modified

* Deleted items
  * Field `.TimeKeepingFieldsEntityId`
* New items
  * Field `.TimeKeepingFieldsOwnerRecord`
  * Field `.TimeKeepingFieldsOwnerTable`

* New items
  * Field `AutomatedCategoryUpdate`
  * Field `Copilot`
  * Field `CopilotDataSource`
  * Field `CopilotDataSourceSetting`
  * Field `TicketRelation`
  * Field `TicketRelationDef`
  * Field `TicketRelDefTicketType`

##### SuperOffice.CRM.Data.DBC.AutomatedCategoryUpdateFields is New

##### SuperOffice.CRM.Data.DBC.CopilotDataSourceFields is New

##### SuperOffice.CRM.Data.DBC.CopilotDataSourceSettingFields is New

##### SuperOffice.CRM.Data.DBC.CopilotFields is New

##### SuperOffice.CRM.Data.DBC.TicketRelationDefFields is New

##### SuperOffice.CRM.Data.DBC.TicketRelationFields is New

##### SuperOffice.CRM.Data.DBC.TicketRelDefTicketTypeFields is New

#### SuperOffice.CRM.Data.LeadstatusTableInfo is Modified

* New items
  * Property `LeftOuterJoin_AutomatedCategoryUpdate_LeadstatusId`

#### SuperOffice.CRM.Data.SShipmentAddrTableInfo is Modified

* New items
  * Property `OwnerLock`

#### SuperOffice.CRM.Data.TicketTableInfo is Modified

* New items
  * Property `LeftOuterJoin_TicketRelation_DestinationTicketId`
  * Property `LeftOuterJoin_TicketRelation_SourceTicketId`

#### SuperOffice.CRM.Data.TicketTypeTableInfo is Modified

* New items
  * Property `LeftOuterJoin_TicketRelDefTicketType_DestinationTicketTypeId`
  * Property `LeftOuterJoin_TicketRelDefTicketType_SourceTicketTypeId`

#### SuperOffice.CRM.Data.TimeKeepingTableInfo is Modified

* Deleted items
  * Property `EntityId`
  * Method `IdxEntityId(Int32)`
  * Method `IdxEntityIdStateId(Int32, Int32)`
* New items
  * Property `OwnerRecord`
  * Property `OwnerTable`
  * Method `IdxOwnerRecord(Int32)`
  * Method `IdxOwnerRecordStateId(Int32, Int32)`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(CategoryUpdateTrigger&, FieldInfo)`
  * Method `ValidateField(CopilotDataSourceType&, FieldInfo)`
  * Method `ValidateField(TicketRelationType&, FieldInfo)`

#### SuperOffice.CRM.Rows.SShipmentAddrRecordData is Modified

* New items
  * Field `OwnerLock`

#### SuperOffice.CRM.Rows.SShipmentAddrRow is Modified

* New items
  * Property `OwnerLock`

#### SuperOffice.CRM.Rows.TimeKeepingRecordData is Modified

* Deleted items
  * Field `EntityId`
* New items
  * Field `OwnerRecord`
  * Field `OwnerTable`

#### SuperOffice.CRM.Rows.TimeKeepingRow is Modified

* Deleted items
  * Property `EntityId`
* New items
  * Property `OwnerRecord`
  * Property `OwnerTable`

#### SuperOffice.CRM.Rows.TimeKeepingRows is Modified

* Deleted items
  * Method `GetFromIdxEntityIdAsync(Int32, CancellationToken)`
  * Method `GetFromIdxEntityIdStateIdAsync(Int32, Int32, CancellationToken)`
  * Method `GetFromIdxEntityIdStateIdTimeKeepingTypeAsync(Int32, Int32, TimeKeepingType, CancellationToken)`

##### SuperOffice.CRM.Rows.TimeKeepingRows.IdxEntityId is Deleted

##### SuperOffice.CRM.Rows.TimeKeepingRows.IdxEntityIdStateId is Deleted

##### SuperOffice.CRM.Rows.TimeKeepingRows.IdxEntityIdStateIdTimeKeepingType is Deleted
* New items
  * Method `GetFromIdxOwnerRecordAsync(Int32, CancellationToken)`
  * Method `GetFromIdxOwnerRecordStateIdAsync(Int32, Int32, CancellationToken)`
  * Method `GetFromIdxOwnerRecordStateIdTimeKeepingTypeAsync(Int32, Int32, TimeKeepingType, CancellationToken)`

##### SuperOffice.CRM.Rows.TimeKeepingRows.IdxOwnerRecord is New

##### SuperOffice.CRM.Rows.TimeKeepingRows.IdxOwnerRecordStateId is New

##### SuperOffice.CRM.Rows.TimeKeepingRows.IdxOwnerRecordStateIdTimeKeepingType is New

#### SuperOffice.Data.SoConnection is Modified

* New items
  * Property `OpenByCustAndAge`
  * Method `AddTrackingComment(String)`

##### SuperOffice.Data.SoConnection.ConnectionInfo is New

#### SuperOffice.Data.SoPreference is Modified

* New items
  * Method `GetOwnerPreferences(Int32, Int32, ValueTuple<String, String, String>[])`
  * Method `GetOwnerPreferencesAsync(Int32, Int32, ValueTuple<String, String, String>[], CancellationToken)`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetAutomatedCategoryUpdateTableInfo()`
  * Method `GetCopilotDataSourceSettingTableInfo()`
  * Method `GetCopilotDataSourceTableInfo()`
  * Method `GetCopilotTableInfo()`
  * Method `GetTicketRelationDefTableInfo()`
  * Method `GetTicketRelationTableInfo()`
  * Method `GetTicketRelDefTicketTypeTableInfo()`

#### SuperOffice.Util.ITrackEventDispatcher is Modified

* Deleted items
  * Method `TrackEvent(String)`
* New items
  * Method `TrackEvent(String, ValueTuple<String, Object>[])`

#### SuperOffice.Util.TrackEvent is Modified

* New items
  * Property `EventProperties`
  * Method `TrackEvent(String, ValueTuple<String, Object>[])`

#### SuperOffice.Util.TrackEventDispatcher is Modified

* Deleted items
  * Method `TrackEvent(String)`
* New items
  * Method `TrackEvent(String, ValueTuple<String, Object>[])`


### Assembly: SoDatabase.BusinessLogic

### New Types

* `SuperOffice.CallHome.TimeKeepingCallHome`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.SaleExtenderBase is Modified


#### SuperOffice.Data.Cache.CacheFlusher is Modified

* Modified items
  * Method `Flush(IEnumerable<String>)`

#### SuperOffice.Data.SoDuplicateChecker is Modified

* New items
  * Method `CheckIfMultilingualFieldHasDuplications(FieldInfo, String, Nullable<Int32>, CancellationToken)`

#### SuperOffice.Util.RagAIHelper is Modified

* New items
  * Method `GetFormsDesignFromImage(Stream, CancellationToken)`
  * Method `GetFormsDesignFromUrl(String, CancellationToken)`


### Assembly: SoLicense

### Modified Types

#### SuperOffice.License.LicenseInfoHelper is Modified

* Deleted items
  * Method `SaveLicenseAsImportFile(LicenseInfo, String)`
  * Method `SaveLicenseAsXml(LicenseInfo, String)`
  * Method `WriteToXml(LicenseInfo)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.CategoryUpdateTrigger`
* `SuperOffice.CD.DSL.Database.CopilotDataSourceType`
* `SuperOffice.CD.DSL.Database.Steps_Copilot.Copilot_01_Tables`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_68_TicketRelation`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_69_TicketRelation2`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_70_TicketRelationDef`
* `SuperOffice.CD.DSL.Database.SuperOffice_132_AutoUpdate`
* `SuperOffice.CD.DSL.Database.SuperOffice_133_AutoUpdateAddLeadstatus`
* `SuperOffice.CD.DSL.Database.SuperOffice_134_ShipmentAddrAddOwnerLock`
* `SuperOffice.CD.DSL.Database.T_AutomatedCategoryUpdate`
* `SuperOffice.CD.DSL.Database.T_Copilot`
* `SuperOffice.CD.DSL.Database.T_CopilotDataSource`
* `SuperOffice.CD.DSL.Database.T_CopilotDataSourceSetting`
* `SuperOffice.CD.DSL.Database.T_TicketRelation`
* `SuperOffice.CD.DSL.Database.T_TicketRelationDef`
* `SuperOffice.CD.DSL.Database.T_TicketRelDefTicketType`
* `SuperOffice.CD.DSL.Database.TicketRelationType`

### Modified Types

#### SuperOffice.CD.Database.Registry is Modified

* New items
  * Field `TimeKeepingSyncNextRun`

#### SuperOffice.CD.DSL.Database.T_SShipmentAddr is Modified

* New items
  * Field `OwnerLock`

#### SuperOffice.CD.DSL.Database.T_TimeKeeping is Modified

* Deleted items
  * Field `EntityId`
* New items
  * Field `OwnerRecord`
  * Field `OwnerTable`



