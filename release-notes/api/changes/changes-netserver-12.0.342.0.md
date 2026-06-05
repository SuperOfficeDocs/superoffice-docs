---
uid: version_12.0.342.0_changes
date: 05.06.2026
---

# Changes from v11.13.921.0 and v12.0.342.0

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.FencingInfo`
* `SuperOffice.CRM.Services.TicketRelationAction`
* `SuperOffice.CRM.Services.TicketRelationDefinitionResult`
* `SuperOffice.CRM.Services.TicketRelationItem`
* `SuperOffice.CRM.Services.TicketRelationResult`

### Modified Types

#### SuperOffice.CRM.Services.EMailAccount is Modified

* New items
  * Property `UseGraphApi`

#### SuperOffice.CRM.Services.EMailConnectionInfo is Modified

* New items
  * Property `UseGraphApi`

#### SuperOffice.CRM.Services.EMailConnectionInfoExtended is Modified

* New items
  * Property `UseGraphApi`

#### SuperOffice.CRM.Services.EMailEntity is Modified

* New items
  * Property `ServerIdentifier`

#### SuperOffice.CRM.Services.EMailEnvelope is Modified

* New items
  * Property `ServerIdentifier`

#### SuperOffice.CRM.Services.IDashAgent is Modified

* New items
  * Method `GetDashboardFencingInfoAsync(CancellationToken)`

#### SuperOffice.CRM.Services.IEMailAgent is Modified

* New items
  * Method `DeleteFromServerIdentifierAsync(EMailConnectionInfo, String[], String, CancellationToken)`
  * Method `GetAttachmentFromServerIdentifierAsync(EMailConnectionInfo, String, String, CancellationToken)`
  * Method `GetEMailAsStreamFromServerIdentifierAsync(EMailConnectionInfo, String, Boolean, CancellationToken)`
  * Method `GetEMailEnvelopesFromServerIdsAsync(EMailConnectionInfo, String[], CancellationToken)`
  * Method `GetEMailFromServerIdentifierAsync(EMailConnectionInfo, String, Boolean, EMailFlags, Boolean, CancellationToken)`
  * Method `MarkAsReadFromServerIdentifiersAsync(EMailConnectionInfo, String[], Boolean, CancellationToken)`
  * Method `MoveToFolderFromServerIdentifierAsync(EMailConnectionInfo, String[], String, CancellationToken)`

#### SuperOffice.CRM.Services.ILicenseAgent is Modified

* New items
  * Method `GetFencingInfoAsync(CancellationToken)`

#### SuperOffice.CRM.Services.IListAgent is Modified

* New items
  * Method `ValidateTicketRelationDefinitionAsync(Int32, Int32[], Int32[], TicketRelationType, CancellationToken)`

#### SuperOffice.CRM.Services.IProjectAgent is Modified

* New items
  * Method `GetProjectFencingInfoAsync(CancellationToken)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `CreateTicketRelationsAsync(Int32[], Int32, TicketRelationType, String, CancellationToken)`
  * Method `GetTicketParentIdAsync(Int32, CancellationToken)`
  * Method `GetTicketRelationActionsAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetTicketRelationsAsync(Int32, CancellationToken)`
  * Method `SetTicketParentAsync(Int32, Int32, String, CancellationToken)`
  * Method `ValidateTicketRelationsAsync(Int32[], Int32, TicketRelationType, CancellationToken)`

#### SuperOffice.CRM.Services.IWorkflowAgent is Modified

* New items
  * Method `GetWorkflowFencingInfoAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Webhook is Modified

* New items
  * Property `ConsecutiveErrors`
  * Property `Description`
  * Property `ErrorAssociates`
  * Property `ErrorEmails`
  * Property `LastError`
  * Property `NotifyVia`
  * Property `NotifyWhen`
  * Property `TotalCalls`
  * Property `TotalErrors`

### Assembly: SuperOffice.Services.Implementation

### Modified Types

#### SuperOffice.CRM.Services.DashAgent is Modified

* New items
  * Method `GetDashboardFencingInfoAsync(CancellationToken)`

#### SuperOffice.CRM.Services.EMailAgent is Modified

* New items
  * Method `DeleteFromServerIdentifierAsync(EMailConnectionInfo, String[], String, CancellationToken)`
  * Method `GetAttachmentFromServerIdentifierAsync(EMailConnectionInfo, String, String, CancellationToken)`
  * Method `GetEMailAsStreamFromServerIdentifierAsync(EMailConnectionInfo, String, Boolean, CancellationToken)`
  * Method `GetEMailEnvelopesFromServerIdsAsync(EMailConnectionInfo, String[], CancellationToken)`
  * Method `GetEMailFromServerIdentifierAsync(EMailConnectionInfo, String, Boolean, EMailFlags, Boolean, CancellationToken)`
  * Method `MarkAsReadFromServerIdentifiersAsync(EMailConnectionInfo, String[], Boolean, CancellationToken)`
  * Method `MoveToFolderFromServerIdentifierAsync(EMailConnectionInfo, String[], String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IDashImplementation is Modified

* New items
  * Method `GetDashboardFencingInfoAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailEntityImplementation is Modified

* New items
  * Method `DeleteFromServerIdentifierAsync(EMailConnectionInfo, String[], String, CancellationToken)`
  * Method `GetAttachmentFromServerIdentifierAsync(EMailConnectionInfo, String, String, CancellationToken)`
  * Method `GetEMailAsStreamFromServerIdentifierAsync(EMailConnectionInfo, String, Boolean, CancellationToken)`
  * Method `GetEMailEnvelopesFromServerIdsAsync(EMailConnectionInfo, String[], CancellationToken)`
  * Method `GetEMailFromServerIdentifierAsync(EMailConnectionInfo, String, Boolean, EMailFlags, Boolean, CancellationToken)`
  * Method `MarkAsReadFromServerIdentifiersAsync(EMailConnectionInfo, String[], Boolean, CancellationToken)`
  * Method `MoveToFolderFromServerIdentifierAsync(EMailConnectionInfo, String[], String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IEmailFlowImplementation is Modified

* New items
  * Method `GetWorkflowFencingInfoAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.ILicenseImplementation is Modified

* New items
  * Method `GetFencingInfoAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectEntityImplementation is Modified

* New items
  * Method `GetProjectFencingInfoAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketRelationDefinitionEntityImplementation is Modified

* New items
  * Method `ValidateTicketRelationDefinitionAsync(Int32, Int32[], Int32[], TicketRelationType, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketRelationEntityImplementation is Modified

* New items
  * Method `CreateTicketRelationsAsync(Int32[], Int32, TicketRelationType, String, CancellationToken)`
  * Method `GetTicketParentIdAsync(Int32, CancellationToken)`
  * Method `GetTicketRelationActionsAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetTicketRelationsAsync(Int32, CancellationToken)`
  * Method `SetTicketParentAsync(Int32, Int32, String, CancellationToken)`
  * Method `ValidateTicketRelationsAsync(Int32[], Int32, TicketRelationType, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.EMailEntityImplementation is Modified

* New items
  * Method `DeleteFromServerIdentifierAsync(EMailConnectionInfo, String[], String, CancellationToken)`
  * Method `GetAttachmentFromServerIdentifierAsync(EMailConnectionInfo, String, String, CancellationToken)`
  * Method `GetEMailAsStreamFromServerIdentifierAsync(EMailConnectionInfo, String, Boolean, CancellationToken)`
  * Method `GetEMailEnvelopesFromServerIdsAsync(EMailConnectionInfo, String[], CancellationToken)`
  * Method `GetEMailFromServerIdentifierAsync(EMailConnectionInfo, String, Boolean, EMailFlags, Boolean, CancellationToken)`
  * Method `MarkAsReadFromServerIdentifiersAsync(EMailConnectionInfo, String[], Boolean, CancellationToken)`
  * Method `MoveToFolderFromServerIdentifierAsync(EMailConnectionInfo, String[], String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.EmailFlowImplementation is Modified

* New items
  * Method `GetWorkflowFencingInfoAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketEntityImplementation is Modified

* Deleted items
  * Method `TicketEntityImplementation(IAttachmentEntityImplementation, ITicketImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketStatusEntityImplementation, ITicketPriorityEntityImplementation, ITicketCategoryListImplementation, IContactImplementation, IPersonImplementation, IUserImplementation, IProjectImplementation, ISaleImplementation, ICacheManager, IBatchData, IPreferenceImplementation, IAssociateImplementation)`
* New items
  * Method `TicketEntityImplementation(IAttachmentEntityImplementation, ITicketImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketStatusEntityImplementation, ITicketPriorityEntityImplementation, ITicketCategoryListImplementation, IContactImplementation, IPersonImplementation, IUserImplementation, IProjectImplementation, ISaleImplementation, ICacheManager, IBatchData, IPreferenceImplementation, IAssociateImplementation, ITicketUsageImplementation)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketRelationEntityImplementation is Modified

* New items
  * Method `CreateTicketRelationsAsync(Int32[], Int32, TicketRelationType, String, CancellationToken)`
  * Method `GetTicketParentIdAsync(Int32, CancellationToken)`
  * Method `GetTicketRelationActionsAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetTicketRelationsAsync(Int32, CancellationToken)`
  * Method `SetTicketParentAsync(Int32, Int32, String, CancellationToken)`
  * Method `ValidateTicketRelationDefinitionAsync(Int32, Int32[], Int32[], TicketRelationType, CancellationToken)`
  * Method `ValidateTicketRelationsAsync(Int32[], Int32, TicketRelationType, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketUsageImplementation is Modified

* Deleted items
  * Method `TicketUsageImplementation()`
* New items
  * Method `TicketUsageImplementation(ILogger<TicketUsageImplementation>, IResolvedRequestsUsageClient)`

#### SuperOffice.CRM.Services.LicenseAgent is Modified

* New items
  * Method `GetFencingInfoAsync(CancellationToken)`

#### SuperOffice.CRM.Services.ListAgent is Modified

* New items
  * Method `ValidateTicketRelationDefinitionAsync(Int32, Int32[], Int32[], TicketRelationType, CancellationToken)`

#### SuperOffice.CRM.Services.ProjectAgent is Modified

* New items
  * Method `GetProjectFencingInfoAsync(CancellationToken)`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `CreateTicketRelationsAsync(Int32[], Int32, TicketRelationType, String, CancellationToken)`
  * Method `GetTicketParentIdAsync(Int32, CancellationToken)`
  * Method `GetTicketRelationActionsAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetTicketRelationsAsync(Int32, CancellationToken)`
  * Method `SetTicketParentAsync(Int32, Int32, String, CancellationToken)`
  * Method `ValidateTicketRelationsAsync(Int32[], Int32, TicketRelationType, CancellationToken)`

#### SuperOffice.CRM.Services.WorkflowAgent is Modified

* New items
  * Method `GetWorkflowFencingInfoAsync(CancellationToken)`

## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.Data.MeteringEventType`
* `SuperOffice.Data.MeteringStatus`
* `SuperOffice.Data.TicketRelationError`
* `SuperOffice.Data.WebhookNotifyVia`
* `SuperOffice.Data.WebhookNotifyWhen`

### Modified Types

#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.Mail is Modified

* Deleted items
  * Field `.MailSaveSentInSentItems`


#### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_FORMS_IS_DEPENDENT`
* New items
  * Field `SR_ADMIN_AI_UPGRADE_PLUS_TRANSLATION`
  * Field `SR_ADMIN_LICENSE_PLAN`
  * Field `SR_ADMIN_LICENSE_RESTRICTIONS`
  * Field `SR_ADMIN_LICENSE_SUITE_CUSTOMOBJ_WARNING`
  * Field `SR_ADMIN_LICENSE_SUITE_NEAR`
  * Field `SR_ADMIN_LICENSE_SUITE_WARNTOOL`
  * Field `SR_ADMIN_LIST_SHOW_CUSTOMOBJECTCARD`
  * Field `SR_ADMIN_MYAPPS`
  * Field `SR_ADMIN_SMS_TEST_MESSAGE`
  * Field `SR_ADMIN_SMS_TEST_MOBILE`
  * Field `SR_ADMIN_WEBHOOKS_ADD_HEADER`
  * Field `SR_ADMIN_WEBHOOKS_ADD_PROPERTY`
  * Field `SR_ADMIN_WEBHOOKS_BACK_TO_WEBHOOKS`
  * Field `SR_ADMIN_WEBHOOKS_CONSECUTIVE_FAILURES`
  * Field `SR_ADMIN_WEBHOOKS_COPY`
  * Field `SR_ADMIN_WEBHOOKS_COPY_SECRET_WARNING`
  * Field `SR_ADMIN_WEBHOOKS_CRM_SCRIPT_LABEL`
  * Field `SR_ADMIN_WEBHOOKS_CUSTOM_HEADERS`
  * Field `SR_ADMIN_WEBHOOKS_CUSTOM_HEADERS_DESCRIPTION`
  * Field `SR_ADMIN_WEBHOOKS_CUSTOM_PROPERTIES`
  * Field `SR_ADMIN_WEBHOOKS_CUSTOM_PROPERTIES_DESCRIPTION`
  * Field `SR_ADMIN_WEBHOOKS_DELETE_WEBHOOK_MESSAGE`
  * Field `SR_ADMIN_WEBHOOKS_DELETE_WEBHOOK_TITLE`
  * Field `SR_ADMIN_WEBHOOKS_DELETE_WEBHOOKS_MESSAGE`
  * Field `SR_ADMIN_WEBHOOKS_DELETE_WEBHOOKS_TITLE`
  * Field `SR_ADMIN_WEBHOOKS_DELIVERY_STATUS`
  * Field `SR_ADMIN_WEBHOOKS_DESTINATION`
  * Field `SR_ADMIN_WEBHOOKS_DESTINATION_DESCRIPTION`
  * Field `SR_ADMIN_WEBHOOKS_DESTINATION_EXTERNAL_URL`
  * Field `SR_ADMIN_WEBHOOKS_DISCARD_CHANGES_MESSAGE`
  * Field `SR_ADMIN_WEBHOOKS_DISCARD_CHANGES_TITLE`
  * Field `SR_ADMIN_WEBHOOKS_ENDPOINT_DISABLED_MESSAGE`
  * Field `SR_ADMIN_WEBHOOKS_ENDPOINT_URL`
  * Field `SR_ADMIN_WEBHOOKS_ERROR_NOTIFICATION`
  * Field `SR_ADMIN_WEBHOOKS_ERROR_NOTIFICATION_DESCRIPTION`
  * Field `SR_ADMIN_WEBHOOKS_ERROR_RECIPIENTS`
  * Field `SR_ADMIN_WEBHOOKS_ERROR_RECIPIENTS_PLACEHOLDER`
  * Field `SR_ADMIN_WEBHOOKS_EVENTS_TIP`
  * Field `SR_ADMIN_WEBHOOKS_GENERATE`
  * Field `SR_ADMIN_WEBHOOKS_HEADER_NAME`
  * Field `SR_ADMIN_WEBHOOKS_LOAD_FAILED_MESSAGE`
  * Field `SR_ADMIN_WEBHOOKS_LOAD_FAILED_TITLE`
  * Field `SR_ADMIN_WEBHOOKS_NOT_AVAILABLE_FOR_CRMSCRIPT`
  * Field `SR_ADMIN_WEBHOOKS_NOTIFY_EMAIL`
  * Field `SR_ADMIN_WEBHOOKS_NOTIFY_EMAIL_AND_INAPP`
  * Field `SR_ADMIN_WEBHOOKS_NOTIFY_INAPP`
  * Field `SR_ADMIN_WEBHOOKS_NOTIFY_ON_FIRST_FAILURE`
  * Field `SR_ADMIN_WEBHOOKS_NOTIFY_ON_FIRST_FAILURE_DESCRIPTION`
  * Field `SR_ADMIN_WEBHOOKS_NOTIFY_ON_FIRST_FAILURE_DESCRIPTION_COPY`
  * Field `SR_ADMIN_WEBHOOKS_NOTIFY_VIA`
  * Field `SR_ADMIN_WEBHOOKS_NOTIFY_WHEN_DISABLED`
  * Field `SR_ADMIN_WEBHOOKS_NOTIFY_WHEN_DISABLED_DESCRIPTION`
  * Field `SR_ADMIN_WEBHOOKS_NOTIFY_WHEN_DISABLED_DESCRIPTION_COPY`
  * Field `SR_ADMIN_WEBHOOKS_PROPERTY_NAME`
  * Field `SR_ADMIN_WEBHOOKS_REMOVE_HEADER`
  * Field `SR_ADMIN_WEBHOOKS_REMOVE_PROPERTY`
  * Field `SR_ADMIN_WEBHOOKS_RESPONSE_FAILED`
  * Field `SR_ADMIN_WEBHOOKS_RESPONSE_SUCCESS`
  * Field `SR_ADMIN_WEBHOOKS_RESTART`
  * Field `SR_ADMIN_WEBHOOKS_RESTART_FAILED_MESSAGE`
  * Field `SR_ADMIN_WEBHOOKS_RESTART_FAILED_TITLE`
  * Field `SR_ADMIN_WEBHOOKS_SAVE_FAILED_MESSAGE`
  * Field `SR_ADMIN_WEBHOOKS_SAVE_FAILED_TITLE`
  * Field `SR_ADMIN_WEBHOOKS_SECURITY_ADVANCED`
  * Field `SR_ADMIN_WEBHOOKS_SECURITY_DESCRIPTION`
  * Field `SR_ADMIN_WEBHOOKS_SEND_TEST`
  * Field `SR_ADMIN_WEBHOOKS_SHARED_SECRET`
  * Field `SR_ADMIN_WEBHOOKS_SHARED_SECRET_DESCRIPTION`
  * Field `SR_ADMIN_WEBHOOKS_SHARED_SECRET_PLACEHOLDER`
  * Field `SR_ADMIN_WEBHOOKS_STATISTICS`
  * Field `SR_ADMIN_WEBHOOKS_STATUS_ACTIVE`
  * Field `SR_ADMIN_WEBHOOKS_STATUS_ACTIVE_WITH_FAILURES`
  * Field `SR_ADMIN_WEBHOOKS_STATUS_DISABLED`
  * Field `SR_ADMIN_WEBHOOKS_STATUS_STOPPED`
  * Field `SR_ADMIN_WEBHOOKS_STATUS_UNKNOWN`
  * Field `SR_ADMIN_WEBHOOKS_TOGGLE_SECTION`
  * Field `SR_ADMIN_WEBHOOKS_TOTAL_CALLS`
  * Field `SR_ADMIN_WEBHOOKS_TOTAL_ERRORS`
  * Field `SR_ADMIN_WEBHOOKS_TRIGGER_NOTIFICATION`
  * Field `SR_ADMIN_WEBHOOKS_TYPE_CRMSCRIPT`
  * Field `SR_ADMIN_WEBHOOKS_TYPE_WEBHOOK`
  * Field `SR_ADMIN_WEBHOOKS_UPDATED`
  * Field `SR_ADMIN_WEBHOOKS_URL_PLACEHOLDER`
  * Field `SR_ADMIN_WEBHOOKS_VALUE`
  * Field `SR_ARCHIVE_KENDO_FILTER_BUTTONTITLE`
  * Field `SR_ARCHIVE_KENDO_LOGIC`
  * Field `SR_ARCHIVE_KENDO_OPERATOR`
  * Field `SR_ARCHIVE_KENDO_VALUE`
  * Field `SR_BTN_UPGRADE`
  * Field `SR_FENCING_DASHBOARD_LIMIT_REACHED_TOOLTIP`
  * Field `SR_FENCING_DASHBOARD_WARNING`
  * Field `SR_FENCING_DASHBOARD_WARNING_TOOLTIP`
  * Field `SR_FENCING_FLOWS_LIMIT_REACHED_TOOLTIP`
  * Field `SR_FENCING_FLOWS_WARNING`
  * Field `SR_FENCING_FLOWS_WARNING_TOOLTIP`
  * Field `SR_FENCING_PROJECT_LIMIT_REACHED_TOOLTIP`
  * Field `SR_FENCING_PROJECT_WARNING`
  * Field `SR_FENCING_PROJECT_WARNING_TOOLTIP`
  * Field `SR_FORMS_DEPENDENCY_CLEAR`
  * Field `SR_FORMS_FIELD_CONSENT_EMARKETING`
  * Field `SR_FORMS_FIELD_CONSENT_SALES_SERVICE`
  * Field `SR_FORMS_HAS_DEPENDENT_CHILDREN`
  * Field `SR_FORMS_INVALID_DEPENDENCY`
  * Field `SR_SIDEPANEL_PIN_PANE`
  * Field `SR_SIDEPANEL_SELECT_PANE`
  * Field `SR_WEBHOOK_CONTEXT_ID`
  * Field `SR_WEBHOOK_DISABLED_FULL`
  * Field `SR_WEBHOOK_DISABLED_TOO_MANY_FAILURES`
  * Field `SR_WEBHOOK_FAILURES_ACTIVE`

### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.Data.LandingPagePinTableInfo`
* `SuperOffice.CRM.Data.LandingPageTableInfo`
* `SuperOffice.CRM.Data.MeteringLogTableInfo`
* `SuperOffice.CRM.Data.WebhookNotifyTableInfo`
* `SuperOffice.CRM.Rows.LandingPagePinRecordData`
* `SuperOffice.CRM.Rows.LandingPagePinRecordDataExtensions`
* `SuperOffice.CRM.Rows.LandingPagePinRow`
* `SuperOffice.CRM.Rows.LandingPagePinRows`
* `SuperOffice.CRM.Rows.LandingPageRecordData`
* `SuperOffice.CRM.Rows.LandingPageRecordDataExtensions`
* `SuperOffice.CRM.Rows.LandingPageRow`
* `SuperOffice.CRM.Rows.LandingPageRows`
* `SuperOffice.CRM.Rows.MeteringLogRecordData`
* `SuperOffice.CRM.Rows.MeteringLogRecordDataExtensions`
* `SuperOffice.CRM.Rows.MeteringLogRow`
* `SuperOffice.CRM.Rows.MeteringLogRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateLandingPagePinRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateLandingPagePinRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateLandingPageRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateLandingPageRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateMeteringLogRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateMeteringLogRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWebhookNotifyRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWebhookNotifyRowsFactory`
* `SuperOffice.CRM.Rows.WebhookNotifyRecordData`
* `SuperOffice.CRM.Rows.WebhookNotifyRecordDataExtensions`
* `SuperOffice.CRM.Rows.WebhookNotifyRow`
* `SuperOffice.CRM.Rows.WebhookNotifyRows`
* `SuperOffice.CRM.Security.DashboardFencingCache`
* `SuperOffice.CRM.Security.ProjectFencingCache`
* `SuperOffice.CRM.Security.WorkflowFencingCache`
* `SuperOffice.Data.SQL.MeteringEventTypeFieldInfo`
* `SuperOffice.Data.SQL.MeteringStatusFieldInfo`
* `SuperOffice.Data.SQL.WebhookNotifyViaFieldInfo`
* `SuperOffice.Data.SQL.WebhookNotifyWhenFieldInfo`

### Modified Types

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_LandingPage_AssociateId`
  * Property `LeftOuterJoin_LandingPage_RegisteredAssociateId`
  * Property `LeftOuterJoin_LandingPage_UpdatedAssociateId`
  * Property `LeftOuterJoin_LandingPagePin_RegisteredAssociateId`
  * Property `LeftOuterJoin_LandingPagePin_UpdatedAssociateId`
  * Property `LeftOuterJoin_MeteringLog_RegisteredAssociateId`
  * Property `LeftOuterJoin_MeteringLog_UpdatedAssociateId`
  * Property `LeftOuterJoin_WebhookNotify_AssociateId`
  * Property `LeftOuterJoin_WebhookNotify_RegisteredAssociateId`
  * Property `LeftOuterJoin_WebhookNotify_UpdatedAssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.EmailAccountFields is Modified

* New items
  * Field `.EmailAccountFieldsUseGraphApi`

##### SuperOffice.CRM.Data.DBC.EmailItemFields is Modified

* New items
  * Field `.EmailItemFieldsServerIdentifier`

##### SuperOffice.CRM.Data.DBC.WebhookFields is Modified

* New items
  * Field `.WebhookFieldsDescription`
  * Field `.WebhookFieldsNotifyVia`
  * Field `.WebhookFieldsNotifyWhen`

* New items
  * Field `LandingPage`
  * Field `LandingPagePin`
  * Field `MeteringLog`
  * Field `WebhookNotify`

##### SuperOffice.CRM.Data.DBC.LandingPageFields is New

##### SuperOffice.CRM.Data.DBC.LandingPagePinFields is New

##### SuperOffice.CRM.Data.DBC.MeteringLogFields is New

##### SuperOffice.CRM.Data.DBC.WebhookNotifyFields is New

#### SuperOffice.CRM.Data.EmailAccountTableInfo is Modified

* New items
  * Property `UseGraphApi`

#### SuperOffice.CRM.Data.EmailItemTableInfo is Modified

* New items
  * Property `ServerIdentifier`

#### SuperOffice.CRM.Data.SelectionTableInfo is Modified

* New items
  * Property `LeftOuterJoin_LandingPage_SelectionId`

#### SuperOffice.CRM.Data.WebhookTableInfo is Modified

* New items
  * Property `Description`
  * Property `LeftOuterJoin_WebhookNotify_WebhookId`
  * Property `NotifyVia`
  * Property `NotifyWhen`

#### SuperOffice.CRM.Rows.EmailAccountRecordData is Modified

* New items
  * Field `UseGraphApi`

#### SuperOffice.CRM.Rows.EmailAccountRow is Modified

* New items
  * Property `UseGraphApi`

#### SuperOffice.CRM.Rows.EmailItemRecordData is Modified

* New items
  * Field `ServerIdentifier`

#### SuperOffice.CRM.Rows.EmailItemRow is Modified

* New items
  * Property `ServerIdentifier`

#### SuperOffice.CRM.Rows.EmailItemRows is Modified

* New items
  * Method `GetFromIdxServerIdentifierAsync(String, CancellationToken)`

##### SuperOffice.CRM.Rows.EmailItemRows.IdxServerIdentifier is New

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(MeteringEventType&, FieldInfo)`
  * Method `ValidateField(MeteringStatus&, FieldInfo)`
  * Method `ValidateField(TicketRelationError&, FieldInfo)`
  * Method `ValidateField(WebhookNotifyVia&, FieldInfo)`
  * Method `ValidateField(WebhookNotifyWhen&, FieldInfo)`

#### SuperOffice.CRM.Rows.WebhookRecordData is Modified

* New items
  * Field `Description`
  * Field `NotifyVia`
  * Field `NotifyWhen`

#### SuperOffice.CRM.Rows.WebhookRow is Modified

* New items
  * Property `Description`
  * Property `NotifyVia`
  * Property `NotifyWhen`

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* Deleted items
  * Method `DemandServiceT2AndAdminPermissions()`
  * Method `GetTicketMessageIdsAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Webhooks.Webhook is Modified

* New items
  * Property `Description`
  * Property `ErrorAssociateIds`
  * Property `ErrorEmails`
  * Property `NotifyVia`
  * Property `NotifyWhen`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetLandingPagePinTableInfo()`
  * Method `GetLandingPageTableInfo()`
  * Method `GetMeteringLogTableInfo()`
  * Method `GetWebhookNotifyTableInfo()`

### Assembly: SoDatabase.BusinessLogic

### New Types

* `SuperOffice.CRM.Lists.LandingpageProvider`
* `SuperOffice.CRM.Lists.WebhookEntityListProvider`
* `SuperOffice.CRM.Lists.WebhookEventListProvider`
* `SuperOffice.Security.Login.EmailConnectivityPostLoginPlugin`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.WebhookExtenderBase is Modified

* Deleted items
* New items
  * Method `PopulateRowFromReaderAsync(SoDataReader, ArchiveRow, CancellationToken)`

#### SuperOffice.CRM.Lists.CRMScriptProvider is Modified

#### SuperOffice.CRM.Lists.TicketTypeProvider is Modified

#### SuperOffice.CRM.Mail.MailCache is Modified

* New items
  * Method `FindMessageInStringIdList(MailEnvelope, String[])`
  * Method `GetCachedMailItemAsync(Int32, String, String, String, String, Boolean, CancellationToken)`
  * Method `GetMinimalMailEnvelope(Int32, String, EMailFlags)`

#### SuperOffice.CRM.Mail.MailSession<TMailInterface> is Modified

* Deleted items
  * Method `MailSession(String, String, String, Boolean)`
* New items
  * Method `MailSession(String, String, String, Boolean, Boolean)`
  * Method `ServerLoginAsync(String, String, String, Boolean, Boolean, CancellationToken)`

#### SuperOffice.CRM.Mail.MessageStoreSession is Modified

* New items
  * Method `GetEnvelopeStringIdsAsync(String, CancellationToken)`
  * Method `ServerLoginAsync(String, String, String, Boolean, Boolean, CancellationToken)`

#### SuperOffice.CRM.Mail.OutgoingMailSession is Modified

* New items
  * Method `ServerLoginAsync(String, String, String, Boolean, Boolean, CancellationToken)`

#### SuperOffice.CRM.Mail.SoMail is Modified

* Deleted items
  * Method `BeginReadAsync(String, String, String, String, Boolean, Boolean, CancellationToken)`
  * Method `LoginIncomingAsync(String, String, String, Boolean, String, Boolean, Boolean, CancellationToken)`
  * Method `LoginIncomingExtendedAsync(String, String, Int32, String, String, String, Boolean, Boolean, CancellationToken)`
  * Method `LoginOutgoingAsync(String, String, String, Boolean, CancellationToken)`
  * Method `LoginOutgoingExtendedAsync(String, String, Int32, String, String, CancellationToken)`
* New items
  * Method `BeginReadAsync(String, String, String, String, Boolean, Boolean, Boolean, CancellationToken)`
  * Method `GetMailReaderAsync(Boolean, CancellationToken)`
  * Method `GetMailSenderAsync(Boolean, CancellationToken)`
  * Method `LoginIncomingAsync(String, String, String, Boolean, String, Boolean, Boolean, Boolean, CancellationToken)`
  * Method `LoginIncomingExtendedAsync(String, String, Int32, String, String, String, Boolean, Boolean, Boolean, CancellationToken)`
  * Method `LoginOutgoingAsync(String, String, String, Boolean, Boolean, CancellationToken)`
  * Method `LoginOutgoingExtendedAsync(String, String, Int32, String, String, Boolean, CancellationToken)`

#### SuperOffice.CRM.Webhooks.DefaultWebhookPlugin is Modified

* Modified items
  * Method `AddToWebhookCountersAsync(Int32, Int32, Int32, Int32, String, CancellationToken)`
  * Method `InitializeWebhookUsageCacheAsync(CancellationToken)`
  * Method `UpdateWebhookStateAsync(Boolean, Webhook, WebhookUsageRecordData, CancellationToken)`
* New items
  * Method `DefaultWebhookPlugin(IWebhookTransmitter, ILogger<DefaultWebhookPlugin>, String)`
  * Method `GetAssociateEjUserIds(Int32[])`
  * Method `GetAssociateEmails(Int32[])`
  * Method `GetDefaultMailAsync(CancellationToken)`
  * Method `GetLocalizedString(String, Object[])`
  * Method `NotifyWebhookErrorAsync(Webhook, String, Int32, CancellationToken)`
  * Method `QueueErrorEmailAsync(String, String, String, String, CancellationToken)`
  * Method `QueueInAppNotificationAsync(Int32, String, String, CancellationToken)`

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.WebhookNotifyVia`
* `SuperOffice.CD.Database.WebhookNotifyWhen`
* `SuperOffice.CD.DSL.Database.Steps_LandingPage.LandingPage_01_Initial`
* `SuperOffice.CD.DSL.Database.Steps_Metering.Metering_01_MeteringLogTable`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_149_MarkAsSpam_FunctionalRight_LocaleText`
* `SuperOffice.CD.DSL.Database.Steps_Webhooks.Webhooks_05_NotifyTable`
* `SuperOffice.CD.DSL.Database.T_LandingPage`
* `SuperOffice.CD.DSL.Database.T_LandingPagePin`
* `SuperOffice.CD.DSL.Database.T_MeteringLog`
* `SuperOffice.CD.DSL.Database.T_WebhookNotify`
* `SuperOffice.CD.DSL.Database.TicketRelationError`

### Modified Types

#### SuperOffice.CD.DSL.Database.T_EmailAccount is Modified

* New items
  * Field `UseGraphApi`

#### SuperOffice.CD.DSL.Database.T_EmailItem is Modified

* New items
  * Field `ServerIdentifier`

#### SuperOffice.CD.DSL.Database.T_Webhook is Modified

* New items
  * Field `Description`
  * Field `NotifyVia`
  * Field `NotifyWhen`
