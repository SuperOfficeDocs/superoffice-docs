---
uid: version_11.8.788.0_changes
date: 22.01.2026
---

Changes from v11.7.727 and v11.8.788.0

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.AnalyticsData`
* `SuperOffice.CRM.Services.TicketRelationDefinitionEntity`
* `SuperOffice.CRM.Services.TicketRelationEntity`

### Modified Types

#### SuperOffice.CRM.Services.Appointment is Modified

* New items
  * Property `TaskId`

#### SuperOffice.CRM.Services.IDiagnosticsAgent is Modified

* New items
  * Method `GetAnalyticsDataAsync(CancellationToken)`
  * Method `TrackEventAsync(String, StringDictionary, CancellationToken)`
  * Method `TrackUserAsync(StringDictionary, CancellationToken)`

#### SuperOffice.CRM.Services.IListAgent is Modified

* New items
  * Method `CreateDefaultTicketRelationDefinitionEntityAsync(CancellationToken)`
  * Method `DeleteTicketRelationDefinitionEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketRelationDefinitionEntityAsync(Int32, CancellationToken)`
  * Method `PerformNeededCategoryUpdateAsync(Int32, Int32, Int32, AutomatedCategoryUpdate, CancellationToken)`
  * Method `SaveTicketRelationDefinitionEntityAsync(TicketRelationDefinitionEntity, CancellationToken)`
  * Method `SetTicketRelationDefinitionSortOrderAsync(Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `CreateDefaultTicketRelationEntityAsync(CancellationToken)`
  * Method `DeleteTicketRelationEntityAsync(Int32, CancellationToken)`
  * Method `SaveTicketRelationEntityAsync(TicketRelationEntity, CancellationToken)`


### Assembly: SuperOffice.Services.Implementation

### New Types

* `SuperOffice.CRM.Services.Implementation.BL.AnalyticsDataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IAnalyticsDataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketRelationDefinitionEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketRelationEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.TicketRelationEntityImplementation`

### Modified Types

#### SuperOffice.CRM.Services.DiagnosticsAgent is Modified

* Deleted items
  * Method `DiagnosticsAgent(ICacheImplementation, ICacheInvalidationImplementation, IEntityCountsImplementation, ILoggingImplementation, IUsageStatsImplementation, ISystemMessageListImplementation, ITableManagerImplementation, IInstallationImplementation, IWebAppUsageImplementation, ISoRequestItemsAccessor)`
  * Method `DiagnosticsAgent(ICacheImplementation, ICacheInvalidationImplementation, IEntityCountsImplementation, ILoggingImplementation, IUsageStatsImplementation, ISystemMessageListImplementation, ITableManagerImplementation, IInstallationImplementation, IWebAppUsageImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `DiagnosticsAgent(IAnalyticsDataImplementation, ICacheImplementation, ICacheInvalidationImplementation, IEntityCountsImplementation, ILoggingImplementation, IUsageStatsImplementation, ISystemMessageListImplementation, ITableManagerImplementation, IInstallationImplementation, IWebAppUsageImplementation, ISoRequestItemsAccessor)`
  * Method `DiagnosticsAgent(IAnalyticsDataImplementation, ICacheImplementation, ICacheInvalidationImplementation, IEntityCountsImplementation, ILoggingImplementation, IUsageStatsImplementation, ISystemMessageListImplementation, ITableManagerImplementation, IInstallationImplementation, IWebAppUsageImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `GetAnalyticsDataAsync(CancellationToken)`
  * Method `TrackEventAsync(String, StringDictionary, CancellationToken)`
  * Method `TrackUserAsync(StringDictionary, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IAutomatedCategoryUpdateImplementation is Modified

* New items
  * Method `PerformNeededCategoryUpdateAsync(Int32, Int32, Int32, AutomatedCategoryUpdate, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.ILoggingImplementation is Modified

* New items
  * Method `TrackEventAsync(String, StringDictionary, CancellationToken)`
  * Method `TrackUserAsync(StringDictionary, CancellationToken)`

#### SuperOffice.CRM.Services.ListAgent is Modified

* Deleted items
  * Method `ListAgent(IAmountClassEntityImplementation, IAutomatedCategoryUpdateImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryEntityImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor)`
  * Method `ListAgent(IAmountClassEntityImplementation, IAutomatedCategoryUpdateImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryEntityImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `ListAgent(IAmountClassEntityImplementation, IAutomatedCategoryUpdateImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryEntityImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketRelationDefinitionEntityImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor)`
  * Method `ListAgent(IAmountClassEntityImplementation, IAutomatedCategoryUpdateImplementation, IBusinessImplementation, IBusinessListImplementation, ICategoryImplementation, ICategoryEntityImplementation, ICategoryListImplementation, ICompetitorImplementation, ICompetitorListImplementation, ITaskMenuImplementation, IConsentPurposeImplementation, IConsentPurposeListImplementation, IConsentSourceImplementation, IConsentSourceListImplementation, ICountryImplementation, ICountryListImplementation, ICreditedImplementation, ICreditedListImplementation, ICurrencyImplementation, ICurrencyEntityImplementation, ICurrencyListImplementation, ICustomerLanguageImplementation, ICustomerLanguageListImplementation, IDeliveryTermImplementation, IDeliveryTermsListImplementation, IDeliveryTypeImplementation, IDeliveryTypeListImplementation, IDepartmentImplementation, IDepartmentListImplementation, IDocumentTemplateImplementation, IDocumentTemplateEntityImplementation, IDocumentTemplateListImplementation, IExtAppEntityImplementation, IHeadingEntityImplementation, IHierarchyEntityImplementation, ILanguageInfoImplementation, ILanguageInfoListImplementation, ILegalBaseImplementation, ILegalBaseListImplementation, ILinkImplementation, ILinkListImplementation, IListEntityImplementation, IListItemEntityImplementation, ILocalizedTextImplementation, ILocalizedTextListImplementation, IMrMrsImplementation, IMrMrsListImplementation, IPaymentTermImplementation, IPaymentTermsListImplementation, IPaymentTypeImplementation, IPaymentTypeListImplementation, IPositionImplementation, IPositionListImplementation, IPriorityImplementation, IPriorityListImplementation, IProductCategoryImplementation, IProductCategoryListImplementation, IProductFamilyImplementation, IProductFamilyListImplementation, IProductTypeImplementation, IProductTypeListImplementation, IProjectStatusImplementation, IProjectStatusListImplementation, IProjectTypeImplementation, IProjectTypeEntityImplementation, IProjectTypeListImplementation, IQuickReplyImplementation, IRatingImplementation, IRatingListImplementation, IReasonImplementation, IReasonListImplementation, IQuoteApproveReasonImplementation, IQuoteApproveReasonListImplementation, IQuoteDenyReasonImplementation, IQuoteDenyReasonListImplementation, IReasonSoldImplementation, IReasonSoldListImplementation, IReasonStalledImplementation, IReasonStalledListImplementation, IRelationDefinitionEntityImplementation, IResourceEntityImplementation, ISaleStageEntityImplementation, ISaleTypeImplementation, ISaleTypeEntityImplementation, ISaleTypeListImplementation, ISelectionCategoryImplementation, ISelectionCategoryListImplementation, ISourceImplementation, ISourceListImplementation, ISoTaskImplementation, ITaskListImplementation, ITicketCategoryImplementation, ITicketCategoryEntityImplementation, ITicketCategoryListImplementation, ITicketCategoryMembershipEntityImplementation, ITicketPriorityImplementation, ITicketPriorityEntityImplementation, ITicketPriorityListImplementation, ITicketRelationDefinitionEntityImplementation, ITicketStatusEntityImplementation, ITicketStatusListImplementation, ITicketTypeEntityImplementation, ITicketTypeListImplementation, IWebPanelEntityImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `CreateDefaultTicketRelationDefinitionEntityAsync(CancellationToken)`
  * Method `DeleteTicketRelationDefinitionEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketRelationDefinitionEntityAsync(Int32, CancellationToken)`
  * Method `PerformNeededCategoryUpdateAsync(Int32, Int32, Int32, AutomatedCategoryUpdate, CancellationToken)`
  * Method `SaveTicketRelationDefinitionEntityAsync(TicketRelationDefinitionEntity, CancellationToken)`
  * Method `SetTicketRelationDefinitionSortOrderAsync(Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* Deleted items
  * Method `TicketAgent(IAttachmentEntityImplementation, ITicketImplementation, ITicketEntityImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketSummaryItemImplementation, ISoRequestItemsAccessor)`
  * Method `TicketAgent(IAttachmentEntityImplementation, ITicketImplementation, ITicketEntityImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketSummaryItemImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
* New items
  * Method `TicketAgent(IAttachmentEntityImplementation, ITicketImplementation, ITicketEntityImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketRelationEntityImplementation, ITicketSummaryItemImplementation, ISoRequestItemsAccessor)`
  * Method `TicketAgent(IAttachmentEntityImplementation, ITicketImplementation, ITicketEntityImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketRelationEntityImplementation, ITicketSummaryItemImplementation, ISoRequestItemsAccessor, IDebugUser, IServiceCallsRepository, IScriptingConfiguration, IOnlineConfiguration)`
  * Method `CreateDefaultTicketRelationEntityAsync(CancellationToken)`
  * Method `DeleteTicketRelationEntityAsync(Int32, CancellationToken)`
  * Method `SaveTicketRelationEntityAsync(TicketRelationEntity, CancellationToken)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.WebApi.ISoHttpContextItemsAccessor`
* `SuperOffice.WebApi.ITrackingSessionInfo`
* `SuperOffice.WebApi.TrackingSessionInfo`

### Modified Types

#### Microsoft.Extensions.DependencyInjection.NetServerCoreOptionsBuilder is Modified

* New items
  * Method `UseHttpContextItemsAccessor<T>()`

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.TelemetryRoleName is Modified

* Deleted items
  * Field `.TelemetryRoleNameCrmWebCore`


#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.Copilot is Modified

* New items
  * Field `.CopilotServiceProcedure`
  * Field `.CopilotServiceSystemPrompt`


#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_TICKETRELATION_CONFIRM_DELETE`
  * Field `SR_ADMIN_TICKETRELATION_DELETE`
  * Field `SR_DASHBOARD_ADD_QUICK_FILTER_DISABLED_TOOLTIP`
  * Field `SR_FORMS_CSS_ADD_CLASS`
  * Field `SR_ONBOARDING_AUTHENTICATION_ERROR`
  * Field `SR_ONBOARDING_BUTT_BACK`
  * Field `SR_ONBOARDING_BUTT_CANCEL`
  * Field `SR_ONBOARDING_BUTT_CLOSE`
  * Field `SR_ONBOARDING_BUTT_CONNECT`
  * Field `SR_ONBOARDING_BUTT_GET_STARTED`
  * Field `SR_ONBOARDING_BUTT_LOGIN`
  * Field `SR_ONBOARDING_BUTT_NEXT`
  * Field `SR_ONBOARDING_BUTT_SAVE`
  * Field `SR_ONBOARDING_CONNECT_EMAIL_TEXT`
  * Field `SR_ONBOARDING_CONNECT_EMAIL_TITLE`
  * Field `SR_ONBOARDING_CONNECT_TO_EMAIL_SERVICE`
  * Field `SR_ONBOARDING_CONNECTED_TO`
  * Field `SR_ONBOARDING_DOCUMENT_TEXT`
  * Field `SR_ONBOARDING_DOCUMENT_TITLE`
  * Field `SR_ONBOARDING_DONE_TEXT`
  * Field `SR_ONBOARDING_DONE_TITLE`
  * Field `SR_ONBOARDING_DUPLICATE_ACCOUNT_ERROR`
  * Field `SR_ONBOARDING_EMAIL_ACCOUNT`
  * Field `SR_ONBOARDING_EMAIL_ADVANCED_SETTINGS`
  * Field `SR_ONBOARDING_EMAIL_OAUTH_AUTH_ERROR`
  * Field `SR_ONBOARDING_EMAIL_OAUTH_SYSTEM_ERROR`
  * Field `SR_ONBOARDING_EMAIL_PASSWORD`
  * Field `SR_ONBOARDING_EMAIL_REDIRECTING`
  * Field `SR_ONBOARDING_EMAIL_USE_SSL`
  * Field `SR_ONBOARDING_EMAIL_USERNAME`
  * Field `SR_ONBOARDING_HELLO_TEXT`
  * Field `SR_ONBOARDING_HELLO_TITLE`
  * Field `SR_ONBOARDING_INCOMING_SERVER_NAME`
  * Field `SR_ONBOARDING_OR`
  * Field `SR_ONBOARDING_OUTGOING_SERVER_NAME`
  * Field `SR_ONBOARDING_WELCOME`
  * Field `SR_TICKET_RELATION_TYPE_CHILD`
  * Field `SR_TICKET_RELATION_TYPE_PARENT`
  * Field `SR_TICKET_RELATION_TYPE_RELATED`

#### SuperOffice.WebApi.HttpContextItem is Modified

* Deleted items
  * Field `AccountId`
  * Field `SoClaimsPrincipal`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.Data.AvailableFontsTableInfo`
* `SuperOffice.CRM.Rows.AvailableFontsRecordData`
* `SuperOffice.CRM.Rows.AvailableFontsRecordDataExtensions`
* `SuperOffice.CRM.Rows.AvailableFontsRow`
* `SuperOffice.CRM.Rows.AvailableFontsRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateAvailableFontsRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateAvailableFontsRowsFactory`
* `SuperOffice.Data.Cache.CacheBlockLogger`
* `SuperOffice.Util.TrackEventItem`
* `SuperOffice.Util.TrackEventNames`

### Modified Types

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_AvailableFonts_RegisteredAssociateId`
  * Property `LeftOuterJoin_AvailableFonts_UpdatedAssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* New items
  * Field `AvailableFonts`

##### SuperOffice.CRM.Data.DBC.AvailableFontsFields is New

#### SuperOffice.CRM.Rows.Implementation.PersonRowImplementation is Modified

* New items
  * Method `OnSavedAsync(Boolean)`

#### SuperOffice.CRM.Rows.Implementation.QuoteAlternativeRowImplementation is Modified

* New items
  * Method `SaveAsync()`

#### SuperOffice.CRM.Rows.Implementation.QuoteLineRowImplementation is Modified

* New items
  * Method `SaveAsync()`
  * Method `SetParentSentryLookups(ISoDataLookup)`

#### SuperOffice.CRM.Rows.Implementation.QuoteRowImplementation is Modified

* New items
  * Method `SaveAsync()`

#### SuperOffice.CRM.Rows.Implementation.QuoteVersionRowImplementation is Modified

* New items
  * Method `SaveAsync()`

#### SuperOffice.CRM.Rows.RowDefaulter is Modified

* New items
  * Method `SetDefaultsAsync(TicketRelationDefRow, DefaulterStrategy, CancellationToken)`
  * Method `SetDefaultsAsync(TicketRelationDefRow, CancellationToken)`

#### SuperOffice.CRM.Rows.TableRowBase is Modified

* New items
  * Method `GetTableRight()`
  * Method `ReadbackRowForSentryRecalculations<Idx>(Idx)`
  * Method `SetParentSentryLookups(ISoDataLookup)`

#### SuperOffice.CRM.Sale.IQuoteData is Modified

* Modified items
  * Method `CreateQuoteLine(Int32)`

#### SuperOffice.CRM.Security.AppointmentSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.AssociateSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.ContactSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.CustomObjectSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.DocDocumentSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.HierarchySentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.KbEntrySentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.PersonSentry is Modified

* Modified items

##### SuperOffice.CRM.Security.PersonSentry.PersonSentryQueryInfo is Modified

* Modified items
  * Method `.PersonSentryQueryInfoUpdateTypedMembers(PrivateSelect)`


#### SuperOffice.CRM.Security.ProjectSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.QuoteAlternativeSentry is Modified

* New items
  * Method `SetParentSentryLookups(ISoDataLookup)`

#### SuperOffice.CRM.Security.QuoteAlternativeSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.QuoteLineSentry is Modified

* Deleted items
  * Property `QuoteAlternativeTableInfo`
  * Property `QuoteTableInfo`
  * Property `QuoteVersionTableInfo`
  * Property `SaleTableInfo`
* New items
  * Method `SetParentSentryLookups(ISoDataLookup)`

#### SuperOffice.CRM.Security.QuoteLineSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.QuoteSentry is Modified

* New items
  * Method `SetParentSentryLookups(ISoDataLookup)`

#### SuperOffice.CRM.Security.QuoteSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.QuoteVersionSentry is Modified

* Deleted items
  * Property `QuoteTableInfo`
  * Property `SaleTableInfo`
  * Method `ComputeDerivedTableRights()`
* New items
  * Method `SetParentSentryLookups(ISoDataLookup)`

#### SuperOffice.CRM.Security.QuoteVersionSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.RelationsSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.ReplyTemplateSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.SaleSentry is Modified

* Deleted items
  * Method `SaleSentry(SaleTableInfo, QuoteTableInfo)`
  * Method `SaleSentry(SaleTableInfo, SaleStakeholderTableInfo)`
* New items
  * Method `ComputeGhostTableRights()`

#### SuperOffice.CRM.Security.SaleSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.SatelliteSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.SelectionSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.Sentry is Modified

* Deleted items
  * Method `CreateSentries(Select)`
* New items
  * Method `CreateSentries(Select, SoCommand)`
  * Method `SetParentSentryLookups(ISoDataLookup)`

#### SuperOffice.CRM.Security.Sentry<TMainTable> is Modified

* New items
  * Method `ComputeGhostTableRights()`
  * Method `ModifySameDayRights(ETableRight&, String&)`

#### SuperOffice.CRM.Security.SentryQueryInfo<TMainTable> is Modified

* Deleted items
  * Method `UpdateRelatedTableInfo<T>(PrivateSelect, T&)`
* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`
* New items
  * Method `UpdateRelatedTableInfo<T>(PrivateSelect, T&, TableInfo[])`

#### SuperOffice.CRM.Security.SORPublishSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.TicketSentryQueryInfo is Modified

* Modified items
  * Method `UpdateTypedMembers(PrivateSelect)`

#### SuperOffice.CRM.Security.VisibleForSentryHelper is Modified

* Deleted items
  * Method `JoinVisibleFor(Select, TableInfo)`
* New items
  * Method `JoinVisibleFor(Select, TableInfo, Boolean)`

#### SuperOffice.CRM.Services.Implementation.ServiceFacades.ServiceFacade is Modified

* Deleted items
  * Method `ServiceFacade(SoOperation)`
* New items
  * Method `ServiceFacade(SoOperation, ILogger<ServiceFacade>)`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetAvailableFontsTableInfo()`

#### SuperOffice.Util.ITrackEventDispatcher is Modified

* Modified items
  * Method `TrackEvent(String, ValueTuple<String, Object>[])`
* New items
  * Method `TrackUser(String, ValueTuple<String, Object>[])`

#### SuperOffice.Util.TrackEvent is Modified

* New items
  * Field `IdentifyEventName`

#### SuperOffice.Util.TrackEventDispatcher is Modified

* Deleted items
  * Method `TrackEventDispatcher(IAsyncQueue<TrackEvent>, ILogger<TrackEventDispatcher>)`
* Modified items
  * Method `TrackEvent(String, ValueTuple<String, Object>[])`
* New items
  * Method `TrackEventDispatcher(IAsyncQueue<TrackEventItem>, ILogger<TrackEventDispatcher>)`
  * Method `TrackUser(String, ValueTuple<String, Object>[])`

#### SuperOffice.Util.TrackEventSender is Modified

* Deleted items
  * Method `TrackEventSender(IOptions<OnlineConfiguration>, ILogger<TrackEventSender>, IAsyncQueue<TrackEvent>)`
  * Method `ProcessItemAsync(IAsyncQueueProcessItemContext<TrackEvent>, CancellationToken)`
* New items
  * Method `TrackEventSender(IOptions<OnlineConfiguration>, ILogger<TrackEventSender>, IAsyncQueue<TrackEventItem>)`
  * Method `ProcessItemAsync(IAsyncQueueProcessItemContext<TrackEventItem>, CancellationToken)`


### Assembly: SoDatabase.BusinessLogic

### New Types

* `SuperOffice.CRM.Lists.TicketRelationDefinitionProvider`
* `SuperOffice.Util.Http11EnforcingHandler`

### Modified Types

#### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem is Modified

* Modified items

##### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem.FieldValueStorage is Modified

* Deleted items
  * Field `.FieldValueStorageActive`
  * Field `.FieldValueStorageKey`
  * Field `.FieldValueStorageOperationType`
  * Field `.FieldValueStorageValues`
  * Method `.FieldValueStorageFieldValueStorage(Boolean, String, String, String[])`
* New items
  * Property `.FieldValueStorageActive`
  * Property `.FieldValueStorageKey`
  * Property `.FieldValueStorageOperationType`
  * Property `.FieldValueStorageValues`
  * Method `.FieldValueStorageFieldValueStorage()`


#### SuperOffice.CRM.Sale.QuoteData is Modified

* Modified items
  * Method `CreateQuoteLine(Int32)`


### Assembly: SuperOffice.Plugins

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.Steps_Copilot.Copilot_02_PrimingData`
* `SuperOffice.CD.DSL.Database.Steps_Dashboard.DashboardStep23_DefaultDashboardNoOwner`
* `SuperOffice.CD.DSL.Database.Steps_Dashboard.DashboardStep24_DefaultDashboardNoOwner`
* `SuperOffice.CD.DSL.Database.SuperOffice_135_PrimaryKeys`
* `SuperOffice.CD.DSL.Database.SuperOffice_136_AvailableFonts`
* `SuperOffice.CD.DSL.Database.T_AvailableFonts`


