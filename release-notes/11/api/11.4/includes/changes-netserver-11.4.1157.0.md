---
uid: version_11.4.1157.0_changes
date: 19.09.2025
---

Changes from v11.3.1349 and v11.4.1157.0

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Deleted Types

* `SuperOffice.CRM.Services.InitalUtmParameters`

### New Types

* `SuperOffice.CRM.Services.SavedUtmParameters`
* `SuperOffice.CRM.Services.UserConnectedState`

### Modified Types

#### SuperOffice.CRM.Services.ContactEntity is Modified

* Deleted items
  * Property `InitialUtmParameters`
* New items
  * Property `UtmParameters`

#### SuperOffice.CRM.Services.IAppointmentAgent is Modified

* New items
  * Method `GetVideoMeetingConnectedStateAsync(CancellationToken)`

#### SuperOffice.CRM.Services.IDiagnosticsAgent is Modified

* New items
  * Method `PerformTasksAfterCustomObjectTableCreatedAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.IPersonAgent is Modified

* New items
  * Method `GetPersonImageAsStreamAsync(Int32, CancellationToken)`
  * Method `SetPersonImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetUtmCreatedPersonContactForFormSubmissionAsync(Int32, Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.ISelectionAgent is Modified

* New items
  * Method `SaveBoardViewSettingsForSelectionAndAssociateAsync(BoardViewSettingsBase, Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `AcceptTicketsAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.IUserAgent is Modified

* New items
  * Method `GetAllDataRightsAsync(Int32, RoleRelationToOwner, CancellationToken)`

#### SuperOffice.CRM.Services.PersonEntity is Modified

* Deleted items
  * Property `InitialUtmParameters`
* New items
  * Property `LeadstatusId`
  * Property `UtmParameters`

#### SuperOffice.CRM.Services.ProjectMember is Modified

* New items
  * Property `Registered`
  * Property `Updated`

#### SuperOffice.CRM.Services.Util.TypeConversion is Modified

* New items
  * Method `ConvertToStream(Image)`


### Assembly: SuperOffice.Services.Implementation

### New Types

* `SuperOffice.CRM.Services.Implementation.Util.LocalizedAddressHelper`
* `SuperOffice.CRM.Services.Implementation.Util.PreferenceHelper`

### Modified Types

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* New items
  * Method `GetVideoMeetingConnectedStateAsync(CancellationToken)`

#### SuperOffice.CRM.Services.DiagnosticsAgent is Modified

* New items
  * Method `PerformTasksAfterCustomObjectTableCreatedAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.BizCardImplementation is Modified

* Deleted items
  * Method `BizCardImplementation(IContactEntityImplementation, IPersonEntityImplementation, IBusinessImplementation, ICountryImplementation)`
* New items
  * Method `BizCardImplementation(IContactEntityImplementation, IContactImplementation, IPersonEntityImplementation, IBusinessImplementation, ICountryImplementation, ILogger<BizCardImplementation>)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IBoardViewSettingsBaseImplementation is Modified

* New items
  * Method `SaveBoardViewSettingsForSelectionAndAssociateAsync(BoardViewSettingsBase, Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IInstallationImplementation is Modified

* New items
  * Method `PerformTasksAfterCustomObjectTableCreatedAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IPersonEntityImplementation is Modified

* New items
  * Method `GetPersonImageAsStreamAsync(Int32, CancellationToken)`
  * Method `SetPersonImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetUtmCreatedPersonContactForFormSubmissionAsync(Int32, Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IRoleEntityImplementation is Modified

* New items
  * Method `GetAllDataRightsAsync(Int32, RoleRelationToOwner, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketEntityImplementation is Modified

* New items
  * Method `AcceptTicketsAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IVideoMeetingReservationImplementation is Modified

* New items
  * Method `GetVideoMeetingConnectedStateAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketEntityImplementation is Modified

* Deleted items
  * Method `TicketEntityImplementation(IAttachmentEntityImplementation, ITicketImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketStatusEntityImplementation, ITicketPriorityEntityImplementation, ITicketCategoryListImplementation, IPersonImplementation, IUserImplementation, IProjectImplementation, ISaleImplementation, ICacheManager, IBatchData, IPreferenceImplementation)`
* New items
  * Method `TicketEntityImplementation(IAttachmentEntityImplementation, ITicketImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketStatusEntityImplementation, ITicketPriorityEntityImplementation, ITicketCategoryListImplementation, IPersonImplementation, IUserImplementation, IProjectImplementation, ISaleImplementation, ICacheManager, IBatchData, IPreferenceImplementation, IAssociateImplementation)`
  * Method `AcceptTicketsAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.RoleEntityImplementation is Modified

* Deleted items
  * Method `RoleEntityImplementation(IAssociateImplementation, IDiagnosticsAgent, ISelectableMDOListImplementation)`
* New items
  * Method `RoleEntityImplementation(IAssociateImplementation, ICacheImplementation, ISelectableMDOListImplementation)`
  * Method `GetAllDataRightsAsync(Int32, RoleRelationToOwner, CancellationToken)`

#### SuperOffice.CRM.Services.PersonAgent is Modified

* New items
  * Method `GetPersonImageAsStreamAsync(Int32, CancellationToken)`
  * Method `SetPersonImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetUtmCreatedPersonContactForFormSubmissionAsync(Int32, Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.SelectionAgent is Modified

* New items
  * Method `SaveBoardViewSettingsForSelectionAndAssociateAsync(BoardViewSettingsBase, Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `AcceptTicketsAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.UserAgent is Modified

* New items
  * Method `GetAllDataRightsAsync(Int32, RoleRelationToOwner, CancellationToken)`

#### SuperOffice.ErpSync.CrmConnectionHandlerFacade is Modified

* New items
  * Method `CrmConnectionHandlerFacade(IServiceScopeFactory)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.Diagnostics.Logging.ISoMetricsPlugin`
* `SuperOffice.Diagnostics.Logging.SoMetricsPluginAttribute`
* `SuperOffice.Util.OperationTracker`

### New Types

* `SuperOffice.Diagnostics.Logging.ISoMetrics`
* `SuperOffice.Diagnostics.Logging.ISoOperation`
* `SuperOffice.Diagnostics.SoActivity`
* `SuperOffice.Diagnostics.SoEnvironment`
* `SuperOffice.Diagnostics.SoMetrics`
* `SuperOffice.Diagnostics.SoOperation`
* `SuperOffice.Util.IWebAppUsageRecorder`

### Modified Types

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.OnlineConfiguration is Modified

* New items
  * Property `.OnlineConfigurationUserflowApiKey`


#### SuperOffice.Configuration.VersionPropertyNames is Modified

* New items
  * Field `AppiAllArchiveCalls`
  * Field `DetailedTiming`
  * Field `ReportEndpointUsage`

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* New items
  * Field `DependencyTypeName`

#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.DiaryView is Modified

* Deleted items
  * Field `.DiaryViewSecretaryMode`


##### SuperOffice.CRM.UserPreferenceStrings.SalesNotification is Modified

* Deleted items
  * Field `.SalesNotificationNotifyCompanyAssignment`
* New items
  * Field `.SalesNotificationNotifyContactOwnership`


#### SuperOffice.Data.RagType is Modified

* New items
  * Field `Website`

#### SuperOffice.Diagnostics.AggregatedServiceCall is Modified

* New items
  * Property `RawAgent`
  * Property `RawMethod`

#### SuperOffice.Diagnostics.SoLogger is Modified

* Deleted items
  * Method `SoLogger(ILoggerFactory, IServiceProvider)`
  * Method `Count(String, Dictionary<String, Double>)`
  * Method `Count(String, NameValueCollection, Dictionary<String, Double>)`
  * Method `Count(String, NameValueCollection, ValueTuple<String, Double>[])`
  * Method `Count(String, String, Double)`
  * Method `Count(String, String[])`
  * Method `Count(String, ValueTuple<String, Double>[])`
  * Method `GetEnvironmentInfo()`
  * Method `GetLogger(Type)`
  * Method `PopulateEnvironmentInfo(NameValueCollection)`
  * Method `SetPermanentAdditionalValue(String, String)`
  * Method `SetPermanentAdditionalValues(String[], String[])`
  * Method `StartOperation(String, IDictionary<String, String>)`
  * Method `StartOperation(String, String[])`
* New items
  * Method `SoLogger(ILoggerFactory)`

#### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_DASHBOARD_ENABLE_SERIES`
  * Field `SR_UTM_CAMPAIGN`
  * Field `SR_UTM_CONTENT`
  * Field `SR_UTM_MEDIUM`
  * Field `SR_UTM_REFERRER_DOMAIN`
  * Field `SR_UTM_SOURCE`
  * Field `SR_UTM_TERM`
* New items
  * Field `SR_ADMIN_LISTS_LEADSTATUS_TOOLTIP`
  * Field `SR_ADMIN_ROLE_CUSTOM_OBJECT`
  * Field `SR_ADMIN_ROLE_DATARIGHTS_CUSTOM_OBJECTS`
  * Field `SR_ADMIN_ROLE_PERMISSION`
  * Field `SR_ARCHIVE_CATEGORY_RANK`
  * Field `SR_BATCH_RAGUPDATEPLUGIN_NAME`
  * Field `SR_BATCH_RAGUPDATEPLUGIN_TOOLTIP`
  * Field `SR_BATCH_RAUPDATEPLUGIN_CANCELLATION`
  * Field `SR_BOARD_CONTACT_MOVE_TO_CATEGORY`
  * Field `SR_BOARD_CONTACT_SELECT_CATEGORY`
  * Field `SR_BOARD_CONTACT_SETTINGS`
  * Field `SR_BOARD_FILTER_CONTACT`
  * Field `SR_BOARD_INVALID_CONTACT_CATEGORY`
  * Field `SR_BOARD_PROJECT_SETTINGS`
  * Field `SR_BOARD_SALE_SETTINGS`
  * Field `SR_BOARD_SAVE_FOR_ALL`
  * Field `SR_BOARD_SAVE_FOR_ALL_TOOLTIP`
  * Field `SR_BOARD_TICKET_SETTINGS`
  * Field `SR_DASHBOARD_PREVIEW_DISABLED`
  * Field `SR_LABEL_LEADSTATUS`
  * Field `SR_MAILLOGIN_CONNECT_EMAIL`
  * Field `SR_SELECTION_SAVE_FOR_ALL_DENIED`
  * Field `SR_TICKET_ACCEPT_DIALOG_LINE1`
  * Field `SR_TICKET_ACCEPT_DIALOG_LINE2`
  * Field `SR_TICKET_ACCEPT_DIALOG_LINE3`
  * Field `SR_TICKET_ACCEPT_DIALOG_TITLE`
  * Field `SR_UTM_ADMIN_ADDSCRIPT_DESC`
  * Field `SR_UTM_ADMIN_ADDSCRIPT_HEADER`
  * Field `SR_UTM_ADMIN_CONVERSIONTRACKING`
  * Field `SR_UTM_ADMIN_ENABLE_UTMTRACKING`
  * Field `SR_UTM_ADMIN_ENABLE_UTMTRACKING_DESC`
  * Field `SR_UTM_ADMIN_INFOBADGE`
  * Field `SR_UTM_ADMIN_INFOHEADER`
  * Field `SR_UTM_ADMIN_LINKS_HEADING`
  * Field `SR_UTM_CONVERSION_CAMPAIGN`
  * Field `SR_UTM_CONVERSION_CONTENT`
  * Field `SR_UTM_CONVERSION_MEDIUM`
  * Field `SR_UTM_CONVERSION_REFERRERDOMAIN`
  * Field `SR_UTM_CONVERSION_SOURCE`
  * Field `SR_UTM_CONVERSION_TERM`
  * Field `SR_UTM_ENABLE_UTMSAVING`
  * Field `SR_UTM_FIRSTTOUCH_CAMPAIGN`
  * Field `SR_UTM_FIRSTTOUCH_CONTENT`
  * Field `SR_UTM_FIRSTTOUCH_MEDIUM`
  * Field `SR_UTM_FIRSTTOUCH_REFERRER_DOMAIN`
  * Field `SR_UTM_FIRSTTOUCH_SOURCE`
  * Field `SR_UTM_FIRSTTOUCH_TERM`
  * Field `SR_UTM_LEADCREATION_CAMPAIGN`
  * Field `SR_UTM_LEADCREATION_CONTENT`
  * Field `SR_UTM_LEADCREATION_MEDIUM`
  * Field `SR_UTM_LEADCREATION_REFERRERDOMAIN`
  * Field `SR_UTM_LEADCREATION_SOURCE`
  * Field `SR_UTM_LEADCREATION_TERM`
  * Field `SR_UTM_PREFIX_LEAD`

#### SuperOffice.Security.Principal.IUserInfoService is Modified

* New items
  * Method `GetLicenses(Int32)`

#### SuperOffice.Security.Principal.SoClaimsPrincipal is Modified

* New items
  * Method `GetLicenses()`
  * Method `HasLicense(String)`
  * Method `HasLicense(String, String)`

#### SuperOffice.SoCoreClaimsPrincipalExtensions is Modified

* New items
  * Method `GetLicenses(ClaimsPrincipal)`
  * Method `HasLicense(ClaimsPrincipal, String)`
  * Method `HasLicense(ClaimsPrincipal, String, String)`

#### SuperOffice.Util.HttpHelper is Modified

* Modified items

##### SuperOffice.Util.HttpHelper.HttpServiceJwtConfig is Modified

* New items
  * Property `.HttpServiceJwtConfigNumberOfAttempts`



### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.Services.Implementation.ServiceFacades.ServiceFacadeRequestHeader`
* `SuperOffice.Util.TrackEventConfiguration`

### New Types

* `SuperOffice.CRM.Data.LeadstatusTableInfo`
* `SuperOffice.CRM.Rows.LeadstatusRecordData`
* `SuperOffice.CRM.Rows.LeadstatusRecordDataExtensions`
* `SuperOffice.CRM.Rows.LeadstatusRow`
* `SuperOffice.CRM.Rows.LeadstatusRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateLeadstatusRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateLeadstatusRowsFactory`
* `SuperOffice.CRM.Security.SentryQueryCustomObjectTableUpdater`

### Modified Types

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.PersonFields is Modified

* New items
  * Field `.PersonFieldsLeadstatusId`

* New items
  * Field `Leadstatus`

##### SuperOffice.CRM.Data.DBC.LeadstatusFields is New

#### SuperOffice.CRM.Data.PersonTableInfo is Modified

* New items
  * Property `LeadstatusId`
  * Property `LeadstatusId_InnerJoin_Leadstatus`

#### SuperOffice.CRM.Entities.Project is Modified

* New items
  * Method `OnSaveAsync(BatchSave)`

#### SuperOffice.CRM.Rows.PersonRecordData is Modified

* New items
  * Field `LeadstatusId`

#### SuperOffice.CRM.Rows.PersonRow is Modified

* New items
  * Property `LeadstatusId`
  * Event `OnLeadstatusIdChange`

#### SuperOffice.CRM.Rows.PersonRows is Modified

* New items
  * Method `GetFromIdxLeadstatusIdAsync(Int32, CancellationToken)`

##### SuperOffice.CRM.Rows.PersonRows.IdxLeadstatusId is New

#### SuperOffice.CRM.Services.Implementation.ServiceFacades.ServiceFacade is Modified

* Deleted items
  * Method `ServiceFacade(ILogger<ServiceFacade>)`
* New items
  * Method `ServiceFacade(SoOperation)`

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* New items
  * Method `GetTicketMessageIdsAsync(Int32, CancellationToken)`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetLeadstatusTableInfo()`

#### SuperOffice.License.ILicenseManager is Modified

* New items
  * Property `IsInitialized`

#### SuperOffice.License.LicenseManager is Modified

* New items
  * Property `IsInitialized`

#### SuperOffice.Security.Principal.SoDatabaseClaimsPrincipalExtensions is Modified

* Deleted items
  * Method `GetGrantedLicensesAsString(ClaimsPrincipal)`
  * Method `HasLicense(ClaimsPrincipal, String)`
  * Method `HasLicense(ClaimsPrincipal, String, String)`

#### SuperOffice.Util.TrackEventSender is Modified

* Deleted items
  * Method `TrackEventSender(IOptions<TrackEventConfiguration>, ILogger<TrackEventSender>, IAsyncQueue<TrackEvent>)`
* New items
  * Method `TrackEventSender(IOptions<OnlineConfiguration>, ILogger<TrackEventSender>, IAsyncQueue<TrackEvent>)`


### Assembly: SoDatabase.BusinessLogic

### New Types

* `SuperOffice.CRM.Lists.LeadStatusListProvider`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.Archive.AppointmentSelectionProviderBase is Modified

* Deleted items
  * Method `GetAppointmentSelectionMembersRowsAsync(Int32, String[], Boolean, CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.ChatConversationSelectionProviderBaseV2 is Modified

* Deleted items
  * Method `GetChatConversationSelectionMembersRowsAsync(Int32, String[], Boolean, CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.ContactPersonSelectionProviderBaseV2 is Modified

* Deleted items
  * Method `GetContactPersonSelectionMembersRowsAsync(Int32, String[], Boolean, CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionProviderBaseV2 is Modified

* Deleted items
  * Method `GetCustomObjectSelectionMembersRowsAsync(Int32, String[], CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.DocumentSelectionProviderBase is Modified

* Deleted items
  * Method `GetDocumentSelectionMembersRowsAsync(Int32, String[], Boolean, CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.DocumentSelectionProviderBaseV2 is Modified

* Deleted items
  * Method `GetDocumentSelectionMembersRowsAsync(Int32, String[], Boolean, CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.FormSubmissionSelectionProviderBaseV2 is Modified

* Deleted items
  * Method `GetFormSubmissionSelectionMembersRowsAsync(Int32, String[], CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.MailingsSelectionProviderBaseV2 is Modified

* Deleted items
  * Method `GetMailingsSelectionMembersRowsAsync(Int32, String[], CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.ProjectSelectionProviderBase is Modified

* Deleted items
  * Method `GetProjectSelectionMembersRowsAsync(Int32, String[], Boolean, CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.ProjectSelectionProviderBaseV2 is Modified

* Deleted items
  * Method `GetProjectSelectionMembersRowsAsync(Int32, String[], Boolean, CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.SaleSelectionProviderBase is Modified

* Deleted items
  * Method `GetSaleSelectionMembersRowsAsync(Int32, String[], Boolean, CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.SaleSelectionProviderBaseV2 is Modified

* Deleted items
  * Method `GetSaleSelectionMembersRowsAsync(Int32, String[], Boolean, CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.TicketSelectionProviderBase is Modified

* Deleted items
  * Method `GetTicketSelectionMembersRowsAsync(Int32, String[], CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.Archive.TicketSelectionProviderBaseV2 is Modified

* Deleted items
  * Method `GetTicketSelectionMembersRowsAsync(Int32, String[], CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.ExtensibleColumnsBase is Modified


#### SuperOffice.CRM.ArchiveLists.PersonExtenderBase is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.PersonExtenderBase.Features is Modified

* New items
  * Field `.FeaturesUtmParameters`


#### SuperOffice.CRM.ArchiveLists.ProjectMemberExtenderBase is Modified


#### SuperOffice.CRM.ArchiveLists.UtmParametersExtenderBase is Modified


#### SuperOffice.Data.UdefPublishHelper is Modified

* Deleted items
  * Method `UdefPublishHelper(IUdefHelper, ISystemEventHelper, ILogger<UdefPublishHelper>)`
* New items
  * Method `UdefPublishHelper(IUdefHelper, ISystemEventHelper, ILogger<UdefPublishHelper>, IWebAppUsageRecorder)`

#### SuperOffice.Util.RagAIHelper is Modified

* Deleted items
  * Method `PutDocument(String, String, String, String, RagType, Dictionary<String, Object>)`
* New items
  * Method `PutDocument(String, String, String, RagType, Dictionary<String, Object>)`

#### SuperOffice.Util.VideoMeetingHelper is Modified

* New items
  * Property `UserConnectedStateUrl`
  * Method `GetUserConnectedState()`

##### SuperOffice.Util.VideoMeetingHelper.UserConnectedState is New

#### SuperOffice.Util.WebAppUsageRecorder is Modified

* Deleted items
  * Method `RecordUsageAsync(WebAppUsageRecordData, CancellationToken)`
* New items
  * Method `WebAppUsageRecorder()`
  * Method `RecordUsageAsync(String, DateTime, Int32, UInt32)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.Steps_CS.CS_66_CustomObjects_DataRight_Priming`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_67_UpdateCustomObjectSelection_TableNumber`
* `SuperOffice.CD.DSL.Database.Steps_UserPreferences.UserPreference_01_Num_Expanded_Messages`
* `SuperOffice.CD.DSL.Database.T_Leadstatus`

### Modified Types

#### SuperOffice.CD.DSL.Database.T_Person is Modified

* New items
  * Field `LeadstatusId`



