---
uid: version_10.2.4.796_changes
date: 3/30/2023
generated: 1
---

## Changes from v10.2.3.544 and v10.2.4.796

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.LiveUiConfig`
* `SuperOffice.CRM.Services.UiEvent`
* `SuperOffice.CRM.Services.UserCandidate`
* `SuperOffice.CRM.Services.WorkflowFilter`
* `SuperOffice.CRM.Services.WorkflowGoal`
* `SuperOffice.CRM.Services.WorkflowStepAddToList`
* `SuperOffice.CRM.Services.WorkflowStepBase`
* `SuperOffice.CRM.Services.WorkflowStepCreateFollowUp`
* `SuperOffice.CRM.Services.WorkflowStepCreateRequest`
* `SuperOffice.CRM.Services.WorkflowStepCreateSale`
* `SuperOffice.CRM.Services.WorkflowStepNotifyByEmail`
* `SuperOffice.CRM.Services.WorkflowStepNotifyBySMS`
* `SuperOffice.CRM.Services.WorkflowStepOption`
* `SuperOffice.CRM.Services.WorkflowStepRemoveFromList`
* `SuperOffice.CRM.Services.WorkflowStepRunScript`
* `SuperOffice.CRM.Services.WorkflowStepSendEmail`
* `SuperOffice.CRM.Services.WorkflowStepSendSMS`
* `SuperOffice.CRM.Services.WorkflowStepSplit`
* `SuperOffice.CRM.Services.WorkflowStepUpdateContact`
* `SuperOffice.CRM.Services.WorkflowStepWaitForAction`
* `SuperOffice.CRM.Services.WorkflowStepWaitForTime`
* `SuperOffice.CRM.Services.WorkflowTrigger`

### Modified Types

#### SuperOffice.CRM.Services.AttachmentEntity is Modified

* New items
  * Property `AuthKey`

#### SuperOffice.CRM.Services.EmailFlow is Modified

* Modified items
  * Property `JumpToFinish`
  * Property `OverrideConsentSubscription`
  * Property `StartOnlyOnce`
  * Property `Steps`
  * Property `VisibleForAll`
* New items
  * Property `BlockLists`
  * Property `EnrollmentEnd`
  * Property `Filter`
  * Property `FromAddr`
  * Property `FromName`
  * Property `FromType`
  * Property `GaCampaign`
  * Property `GaSource`
  * Property `Goals`
  * Property `RemoveFromFlows`
  * Property `ReplyToAddr`
  * Property `ReplyToName`
  * Property `ReplyToType`
  * Property `SelectedDays`
  * Property `SmsSender`
  * Property `TimeframeEnd`
  * Property `TimeframeStart`
  * Property `Triggers`
  * Property `TzLocation`
  * Property `UseEnrollmentEnd`
  * Property `UseGoogleAnalytics`
  * Property `UseTimeframe`
  * Property `UseWorkflowStart`
  * Property `WorkflowStart`

#### SuperOffice.CRM.Services.IPersonAgent is Modified

* New items
  * Method `CreateOrUpdateUserCandidate(Int32, String, Boolean)`
  * Method `GetCustomerCentrePasswordReplyTemplate(Int32)`
  * Method `GetUserCandidateByPerson(Int32)`
  * Method `SendEmail(String, String, String, String, String, Int32[])`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* Deleted items
  * Method `SaveTicketMessageEntityWithOptions(TicketMessageEntity, Boolean, Int32[])`
* New items
  * Method `SaveTicketMessageEntityWithOptions(TicketMessageEntity, Boolean, Int32[], Boolean)`

#### SuperOffice.CRM.Services.IViewStateAgent is Modified

* New items
  * Method `GetLiveUiConfig()`
  * Method `PublishAndRetrieveUiEvents(Int32, UiEvent[])`

#### SuperOffice.CRM.Services.IWorkflowAgent is Modified

* Deleted items
  * Method `AddAfterWorkflowStep(Int32, WorkflowStep)`
  * Method `CreateDefaultWorkflowStep()`
  * Method `DeleteWorkflowStep(Int32)`
  * Method `SaveWorkflowStep(WorkflowStep)`
* Modified items
  * Method `GetWorkflowStep(Int32)`
* New items
  * Method `AddAfterWorkflowStep(Int32, WorkflowStepBase)`
  * Method `CreateDefaultWorkflowFilter()`
  * Method `CreateDefaultWorkflowGoal()`
  * Method `CreateDefaultWorkflowStepFromType(WorkflowStepType)`
  * Method `CreateDefaultWorkflowStepOption()`
  * Method `CreateDefaultWorkflowTrigger()`
  * Method `DeleteWorkflowStepOption(Int32)`
  * Method `GetWorkflowStepOption(Int32)`
  * Method `SaveWorkflowStepOption(WorkflowStepOption)`

#### SuperOffice.CRM.Services.PersonAgent is Modified

* New items
  * Method `CreateOrUpdateUserCandidate(Int32, String, Boolean)`
  * Method `GetCustomerCentrePasswordReplyTemplate(Int32)`
  * Method `GetUserCandidateByPerson(Int32)`
  * Method `SendEmail(String, String, String, String, String, Int32[])`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* Deleted items
  * Method `SaveTicketMessageEntityWithOptions(TicketMessageEntity, Boolean, Int32[])`
* New items
  * Method `SaveTicketMessageEntityWithOptions(TicketMessageEntity, Boolean, Int32[], Boolean)`

#### SuperOffice.CRM.Services.ViewStateAgent is Modified

* New items
  * Method `GetLiveUiConfig()`
  * Method `PublishAndRetrieveUiEvents(Int32, UiEvent[])`

#### SuperOffice.CRM.Services.WorkflowAgent is Modified

* Deleted items
  * Method `AddAfterWorkflowStep(Int32, WorkflowStep)`
  * Method `CreateDefaultWorkflowStep()`
  * Method `DeleteWorkflowStep(Int32)`
  * Method `SaveWorkflowStep(WorkflowStep)`
* Modified items
  * Method `GetWorkflowStep(Int32)`
* New items
  * Method `AddAfterWorkflowStep(Int32, WorkflowStepBase)`
  * Method `CreateDefaultWorkflowFilter()`
  * Method `CreateDefaultWorkflowGoal()`
  * Method `CreateDefaultWorkflowStepFromType(WorkflowStepType)`
  * Method `CreateDefaultWorkflowStepOption()`
  * Method `CreateDefaultWorkflowTrigger()`
  * Method `DeleteWorkflowStepOption(Int32)`
  * Method `GetWorkflowStepOption(Int32)`
  * Method `SaveWorkflowStepOption(WorkflowStepOption)`

#### SuperOffice.CRM.Services.WorkflowStep is Modified

* New items
  * Property `Settings`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.Data.EmailFromType`
* `SuperOffice.Data.EmailReplyToType`
* `SuperOffice.Data.WorkflowTimeWaitAlgorithm`
* `SuperOffice.Data.WorkflowTimeWaitIntervalType`
* `SuperOffice.ServiceConstants`

### Modified Types

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.Client is Modified

* New items
  * Property `.ClientLiveUiEventLimit`
  * Property `.ClientLiveUiPollingInterval`


##### SuperOffice.Configuration.ConfigFile.ClientSection is Modified

* New items
  * Property `.ClientSectionLiveUiEventLimit`
  * Property `.ClientSectionLiveUiPollingInterval`


#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.Notification is Modified

* Deleted items
  * Field `.NotificationNotifyAppointmentCancel`
  * Field `.NotificationNotifyAppointmentChange`
  * Field `.NotificationNotifyAppointmentDecline`
  * Field `.NotificationNotifyAppointmentInvitation`

* New items

##### SuperOffice.CRM.UserPreferenceStrings.InApp is New

##### SuperOffice.CRM.UserPreferenceStrings.SalesNotification is New

#### SuperOffice.Data.Navigation is Modified

* New items
  * Field `TicketMinicard`

#### SuperOffice.Data.Weekday is Modified

* Modified items
  * Field `value__`

#### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_NOTIFY_TICKET_FAVOURITE_ESCALATED`
  * Field `SR_PD_notification_notifyAppointmentCancel_DESC`
  * Field `SR_PD_notification_notifyAppointmentCancel_NAME`
  * Field `SR_PD_notification_notifyAppointmentChange_DESC`
  * Field `SR_PD_notification_notifyAppointmentChange_NAME`
  * Field `SR_PD_notification_notifyAppointmentDecline_DESC`
  * Field `SR_PD_notification_notifyAppointmentDecline_NAME`
  * Field `SR_PD_notification_notifyAppointmentInvitation_DESC`
  * Field `SR_PD_notification_notifyAppointmentInvitation_NAME`
  * Field `SR_TARGETS_EXCLUDE_ASSCOCIATE`
* New items
  * Field `FROM_ALWAYS_FORWARD`
  * Field `FROM_SALES_CONTACT`
  * Field `FROM_SUPPORT_CONTACT`
  * Field `REPLY_TO_ALWAYS_FORWARD`
  * Field `REPLY_TO_EMPTY`
  * Field `REPLY_TO_SALES_CONTACT`
  * Field `REPLY_TO_SUPPORT_CONTACT`
  * Field `SR_ARCHIVE_EMAILFLOW_ID`
  * Field `SR_ARCHIVE_EMAILFLOW_ID_TOOLTIP`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_ID`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_ID_TOOLTIP`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_STATUS`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_STATUS_TOOLTIP`
  * Field `SR_ARCHIVE_EMAILFLOW_MAILING_TYPE`
  * Field `SR_ARCHIVE_EMAILFLOW_MAILING_TYPE_TOOLTIP`
  * Field `SR_ARCHIVE_EMAILFLOW_OVERRIDE_CONSENT_SUBSCRIPTION`
  * Field `SR_ARCHIVE_EMAILFLOW_OVERRIDE_CONSENT_SUBSCRIPTION_TOOLTIP`
  * Field `SR_ARCHIVE_EMAILFLOW_THUMBNAIL`
  * Field `SR_ARCHIVE_WORKFLOW__DEFINITION_JUMP_TO_FINISH_TOOLTIP`
  * Field `SR_ARCHIVE_WORKFLOW__DEFINITION_START_ONLY_ONCE_TOOLTIP`
  * Field `SR_ARCHIVE_WORKFLOW__DEFINITION_STATUS_TOOLTIP`
  * Field `SR_ARCHIVE_WORKFLOW_COMPLETED_COUNT`
  * Field `SR_ARCHIVE_WORKFLOW_COMPLETED_COUNT_TOOLTIP`
  * Field `SR_ARCHIVE_WORKFLOW_DEFINITION_STATUS`
  * Field `SR_ARCHIVE_WORKFLOW_DESC`
  * Field `SR_ARCHIVE_WORKFLOW_DESC_TOOLTIP`
  * Field `SR_ARCHIVE_WORKFLOW_ENROLLED_COUNT`
  * Field `SR_ARCHIVE_WORKFLOW_ENROLLED_COUNT_TOOLTIP`
  * Field `SR_ARCHIVE_WORKFLOW_ID`
  * Field `SR_ARCHIVE_WORKFLOW_ID_TOOLTIP`
  * Field `SR_ARCHIVE_WORKFLOW_IN_PROGRESS_COUNT`
  * Field `SR_ARCHIVE_WORKFLOW_IN_PROGRESS_COUNT_TOOLTIP`
  * Field `SR_ARCHIVE_WORKFLOW_JUMP_TO_FINISH`
  * Field `SR_ARCHIVE_WORKFLOW_NAME`
  * Field `SR_ARCHIVE_WORKFLOW_NAME_TOOLTIP`
  * Field `SR_ARCHIVE_WORKFLOW_START_ONLY_ONCE`
  * Field `SR_ARCHIVE_WORKFLOW_SUCCEEDED_COUNT`
  * Field `SR_ARCHIVE_WORKFLOW_SUCCEEDED_COUNT_TOOLTIP`
  * Field `SR_ARCHIVE_WORKFLOW_SUCCESS_RATE`
  * Field `SR_ARCHIVE_WORKFLOW_SUCCESS_RATE_TOOLTIP`
  * Field `SR_CUSTOMER_CENTRE_PASSWORD_SEND`
  * Field `SR_CUSTOMER_CENTRE_SEND_PASSWORD`
  * Field `SR_CUSTOMER_CENTRE_SENT_SUCCESSFULLY`
  * Field `SR_CUSTOMER_CENTRE_USER`
  * Field `SR_CUSTOMER_CENTRE_USER_MANAGE`
  * Field `SR_CUSTOMER_CENTRE_USER_UPDATED`
  * Field `SR_FLOW_ADD_TO_FLOW_CAPTION`
  * Field `SR_FLOW_ADD_TO_FLOW_DESCRIPTION`
  * Field `SR_FLOW_ADD_TO_FLOW_HEADING`
  * Field `SR_FLOW_ADD_TO_FLOW_LABEL`
  * Field `SR_FLOW_ADD_TO_FLOW_MENU_ITEM`
  * Field `SR_FLOW_ADD_TO_FLOW_RESULT`
  * Field `SR_MENU_LATEST_RELEASE_NOTES`
  * Field `SR_MENU_USER_TECH_DOC`
  * Field `SR_NOTIFY_CUSTOM_MESSAGE`
  * Field `SR_NOTIFY_MEETING_CONFLICT`
  * Field `SR_NOTIFY_TICKET_ESCALATED`
  * Field `SR_NOTIFY_TICKET_NEW_CAT`
  * Field `SR_PD_InApp_ComResourceCentre_DESC`
  * Field `SR_PD_InApp_ComResourceCentre_NAME`
  * Field `SR_PD_InApp_FeatureUpdatesNews_DESC`
  * Field `SR_PD_InApp_FeatureUpdatesNews_NAME`
  * Field `SR_PD_InApp_HelpTipsLearning_DESC`
  * Field `SR_PD_InApp_HelpTipsLearning_NAME`
  * Field `SR_PD_InApp_NAME`
  * Field `SR_PD_InApp_SurveysFeedback_DESC`
  * Field `SR_PD_InApp_SurveysFeedback_NAME`
  * Field `SR_PD_NetServices_ReleaseNotesUrl_DESC`
  * Field `SR_PD_NetServices_ReleaseNotesUrl_NAME`
  * Field `SR_PD_NetServices_UserTechDocsUrl_DESC`
  * Field `SR_PD_NetServices_UserTechDocsUrl_NAME`
  * Field `SR_PD_NetServices_WhatsNewPMUrl_DESC`
  * Field `SR_PD_NetServices_WhatsNewPMUrl_NAME`
  * Field `SR_PD_salesnotification_DESC`
  * Field `SR_PD_salesnotification_NAME`
  * Field `SR_PD_salesnotification_notifyAppointmentCancel_DESC`
  * Field `SR_PD_salesnotification_notifyAppointmentCancel_NAME`
  * Field `SR_PD_salesnotification_notifyAppointmentChange_DESC`
  * Field `SR_PD_salesnotification_notifyAppointmentChange_NAME`
  * Field `SR_PD_salesnotification_notifyAppointmentDecline_DESC`
  * Field `SR_PD_salesnotification_notifyAppointmentDecline_NAME`
  * Field `SR_PD_salesnotification_notifyAppointmentInvitation_DESC`
  * Field `SR_PD_salesnotification_notifyAppointmentInvitation_NAME`
  * Field `SR_PREVIEW_HTML`
  * Field `SR_PREVIEW_PLAIN_TEXT`
  * Field `SR_TARGETS_EXCLUDE_ASSOCIATE`
  * Field `SR_TARGETS_EXCLUDE_ASSOCIATE_TOOLTIP`
  * Field `SR_TICKET_ARCHIVE_MIGHT_BE_OUT_OF_SYNC`
  * Field `SR_TICKET_BEING_EDITED_BY`
  * Field `SR_TICKET_CHANGED_BY`
  * Field `SR_TICKET_NO_TICKETS_IN_QUEUE`
  * Field `SR_TICKET_OUT_OF_SYNC_CLICK_TO_REFRESH`
  * Field `SR_TICKET_VIEWED_BY`
  * Field `SR_USERCANDIDATE_USERNAME_EXISTS`
  * Field `SR_WORKFLOW_INSTANCE_STATUS_CANCELLED`
  * Field `SR_WORKFLOW_INSTANCE_STATUS_FAULTED`
  * Field `SR_WORKFLOW_INSTANCE_STATUS_FINISHED`
  * Field `SR_WORKFLOW_INSTANCE_STATUS_IDLE`
  * Field `SR_WORKFLOW_INSTANCE_STATUS_RUNNING`
  * Field `SR_WORKFLOW_INSTANCE_STATUS_SUSPENDED`
  * Field `SR_WORKFLOWDEFINITION_STATUS_PAUSED`
  * Field `SR_WORKFLOWDEFINITION_STATUS_RUNNING`
  * Field `SR_WORKFLOWDEFINITION_STATUS_STOPPED`
  * Field `SR_WORKFLOWGOALTYPE_ADDEDTOPROJECT`
  * Field `SR_WORKFLOWGOALTYPE_ADDEDTOSELECTION`
  * Field `SR_WORKFLOWGOALTYPE_APPOINTMENTCREATED`
  * Field `SR_WORKFLOWGOALTYPE_CONTACTUPDATED`
  * Field `SR_WORKFLOWGOALTYPE_FORMSUBMITTED`
  * Field `SR_WORKFLOWGOALTYPE_HADCHAT`
  * Field `SR_WORKFLOWGOALTYPE_LINKCLICKED`
  * Field `SR_WORKFLOWGOALTYPE_REQUESTCREATED`
  * Field `SR_WORKFLOWGOALTYPE_SALECREATEDONCOMPANY`
  * Field `SR_WORKFLOWGOALTYPE_SALECREATEDONCONTACT`
  * Field `SR_WORKFLOWS_CAMPAIGN`
  * Field `SR_WORKFLOWS_EMAIL_IN_TIMEFRAME`
  * Field `SR_WORKFLOWS_FROM_ADDR`
  * Field `SR_WORKFLOWS_FROM_NAME`
  * Field `SR_WORKFLOWS_MEDIUM`
  * Field `SR_WORKFLOWS_OVERRIDE_CONSSUB`
  * Field `SR_WORKFLOWS_REPLY_TO`
  * Field `SR_WORKFLOWS_REPLY_TO_ADDR`
  * Field `SR_WORKFLOWS_REPLY_TO_NAME`
  * Field `SR_WORKFLOWS_SOURCE`
  * Field `SR_WORKFLOWSTEPTYPE_CREATE_ACTIVITY`
  * Field `SR_WORKFLOWSTEPTYPE_FLOW_CONTROL`
  * Field `SR_WORKFLOWSTEPTYPE_INTERNAL_ACTIONS`
  * Field `SR_WORKFLOWSTEPTYPE_SEND_MESSAGE`
  * Field `SR_WORKFLOWSTEPTYPE_UPDATE_PARTICIPANT`
  * Field `SR_WORKFLOWTRIGGERTYPE_ADDTOLIST`
  * Field `SR_WORKFLOWTRIGGERTYPE_CREATEFOLLOWUP`
  * Field `SR_WORKFLOWTRIGGERTYPE_CREATEREQUEST`
  * Field `SR_WORKFLOWTRIGGERTYPE_CREATESALE`
  * Field `SR_WORKFLOWTRIGGERTYPE_NOTIFYBYEMAIL`
  * Field `SR_WORKFLOWTRIGGERTYPE_NOTIFYBYSMS`
  * Field `SR_WORKFLOWTRIGGERTYPE_REMOVEFROMLIST`
  * Field `SR_WORKFLOWTRIGGERTYPE_SENDEMAIL`
  * Field `SR_WORKFLOWTRIGGERTYPE_SENDSMS`
  * Field `SR_WORKFLOWTRIGGERTYPE_SPLIT`
  * Field `SR_WORKFLOWTRIGGERTYPE_UPDATECONTACT`
  * Field `SR_WORKFLOWTRIGGERTYPE_WAITFORACTION`
  * Field `SR_WORKFLOWTRIGGERTYPE_WAITFORTIME`

#### SuperOffice.Util.DateUtility is Modified

* New items
  * Method `CalcSeconds(DateTime)`
  * Method `SetTime(DateTime, Int32, Int32, Int32, Int32)`


### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.ArchiveLists.AsyncProviderWrapper`
* `SuperOffice.CRM.ArchiveLists.TicketUpdatedNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.TicketUpdatedNotificationSubProvider`
* `SuperOffice.Exceptions.SoAsyncProviderTimeoutException`

### New Types

* `SuperOffice.CRM.ArchiveLists.EmailFlowEmailFlowExtender`
* `SuperOffice.CRM.ArchiveLists.EmailFlowExtenderBase`
* `SuperOffice.CRM.ArchiveLists.EmailFlowHierarchyExtender`
* `SuperOffice.CRM.ArchiveLists.EmailFlowInstanceContactExtender`
* `SuperOffice.CRM.ArchiveLists.EmailFlowInstanceEmailFlowExtender`
* `SuperOffice.CRM.ArchiveLists.EmailFlowInstanceEmailFlowInstanceExtender`
* `SuperOffice.CRM.ArchiveLists.EmailFlowInstanceExtenderBase`
* `SuperOffice.CRM.ArchiveLists.EmailFlowInstancePersonExtender`
* `SuperOffice.CRM.ArchiveLists.EmailFlowInstanceProvider`
* `SuperOffice.CRM.ArchiveLists.EmailFlowProvider`
* `SuperOffice.CRM.ArchiveLists.EmailFlowWorkflowExtender`
* `SuperOffice.CRM.ArchiveLists.TicketNewMessageNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.TicketNewMessageNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.WorkflowAssociateExtender`
* `SuperOffice.CRM.ArchiveLists.WorkflowExtenderBase`
* `SuperOffice.CRM.Cache.TicketPriorityCache`
* `SuperOffice.CRM.Data.EntityCountsTableInfo`
* `SuperOffice.CRM.Data.WorkflowStepOptionLinkTableInfo`
* `SuperOffice.CRM.Data.WorkflowStepOptionTableInfo`
* `SuperOffice.CRM.Lists.EmailFlowListProvider`
* `SuperOffice.CRM.Lists.EmailFromTypeProvider`
* `SuperOffice.CRM.Lists.EmailReplyToTypeProvider`
* `SuperOffice.CRM.Lists.MailingDomainsProvider`
* `SuperOffice.CRM.Lists.WorkflowDefinitionStatusProvider`
* `SuperOffice.CRM.Lists.WorkflowGoalTypeProvider`
* `SuperOffice.CRM.Lists.WorkflowInstanceStatusProvider`
* `SuperOffice.CRM.Lists.WorkflowTriggerTypeProvider`
* `SuperOffice.CRM.RegistryExtensions`
* `SuperOffice.CRM.Rows.EntityCountsRecordData`
* `SuperOffice.CRM.Rows.EntityCountsRecordDataExtensions`
* `SuperOffice.CRM.Rows.EntityCountsRow`
* `SuperOffice.CRM.Rows.EntityCountsRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateEntityCountsRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateEntityCountsRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowStepOptionLinkRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowStepOptionLinkRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowStepOptionRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowStepOptionRowsFactory`
* `SuperOffice.CRM.Rows.WorkflowStepOptionLinkRecordData`
* `SuperOffice.CRM.Rows.WorkflowStepOptionLinkRecordDataExtensions`
* `SuperOffice.CRM.Rows.WorkflowStepOptionLinkRow`
* `SuperOffice.CRM.Rows.WorkflowStepOptionLinkRows`
* `SuperOffice.CRM.Rows.WorkflowStepOptionRecordData`
* `SuperOffice.CRM.Rows.WorkflowStepOptionRecordDataExtensions`
* `SuperOffice.CRM.Rows.WorkflowStepOptionRow`
* `SuperOffice.CRM.Rows.WorkflowStepOptionRows`
* `SuperOffice.CRM.Ticket.DaySchedule`
* `SuperOffice.CRM.Ticket.TicketAlertHelper`
* `SuperOffice.CRM.Ticket.TicketOwnerResolver`
* `SuperOffice.CRM.Ticket.TicketPriorityResolver`
* `SuperOffice.CRM.Ticket.TicketStatusRegistryHelper`
* `SuperOffice.CRM.Ticket.WeekSchedule`
* `SuperOffice.Data.SQL.EmailFromTypeFieldInfo`
* `SuperOffice.Data.SQL.EmailReplyToTypeFieldInfo`
* `SuperOffice.Data.SQL.WeekdayFieldInfo`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationExtenderBase is Modified

* Deleted items
  * Field `RecurringEndDateColumnName`
  * Field `RecurringStartDateColumnName`
  * Property `MappedEmailIdField`
  * Method `AddReceiverFullName(SoDataReader, ArchiveRow)`
* New items
  * Field `HasConflictColumnName`
  * Field `InvitedPersonIdColumnName`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationProvider is Modified

* New items
  * Property `AddConflicts`
  * Method `AddConflictColumnValue(List<ArchiveRow>)`

#### SuperOffice.CRM.ArchiveLists.ArchiveProviderFactory is Modified

* Deleted items
  * Method `CreateAsyncWrapped(String, String)`

#### SuperOffice.CRM.ArchiveLists.NotificationNotificationExtender<Info> is Modified

* Deleted items
* New items
  * Field `AssociateIdColumnName`

#### SuperOffice.CRM.ArchiveLists.NotificationProvider is Modified

* New items
  * Method `SetPagingInfo(Int32, Int32)`

#### SuperOffice.CRM.ArchiveLists.RequestNotificationProvider is Modified

* New items
  * Method `AcceptRow(ArchiveRow)`

#### SuperOffice.CRM.ArchiveLists.TicketNotificationExtenderBase is Modified

* New items
  * Method `AddNotifyDateTimeColumn(SoDataReader, ArchiveRow)`

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_EntityCounts_AssociateId`
  * Property `LeftOuterJoin_WorkflowStepOption_RegisteredAssociateId`
  * Property `LeftOuterJoin_WorkflowStepOption_UpdatedAssociateId`
  * Property `LeftOuterJoin_WorkflowStepOptionLink_RegisteredAssociateId`
  * Property `LeftOuterJoin_WorkflowStepOptionLink_UpdatedAssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.EmailFlowFields is Modified

* New items
  * Field `.EmailFlowFieldsFromAddr`
  * Field `.EmailFlowFieldsFromName`
  * Field `.EmailFlowFieldsFromType`
  * Field `.EmailFlowFieldsGaCampaign`
  * Field `.EmailFlowFieldsGaSource`
  * Field `.EmailFlowFieldsReplyToAddr`
  * Field `.EmailFlowFieldsReplyToName`
  * Field `.EmailFlowFieldsReplyToType`
  * Field `.EmailFlowFieldsSelectedDays`
  * Field `.EmailFlowFieldsSmsSender`
  * Field `.EmailFlowFieldsTimeframeEnd`
  * Field `.EmailFlowFieldsTimeframeStart`
  * Field `.EmailFlowFieldsUseGoogleAnalytics`
  * Field `.EmailFlowFieldsUseTimeframe`


##### SuperOffice.CRM.Data.DBC.WorkflowFields is Modified

* New items
  * Field `.WorkflowFieldsBlockLists`
  * Field `.WorkflowFieldsEnrollmentEnd`
  * Field `.WorkflowFieldsRemoveFromFlows`
  * Field `.WorkflowFieldsTzLocationId`
  * Field `.WorkflowFieldsUseEnrollmentEnd`
  * Field `.WorkflowFieldsUseWorkflowStart`
  * Field `.WorkflowFieldsWorkflowStart`


##### SuperOffice.CRM.Data.DBC.WorkflowInstanceFields is Modified

* New items
  * Field `.WorkflowInstanceFieldsNextStep`
  * Field `.WorkflowInstanceFieldsWaitUntil`


##### SuperOffice.CRM.Data.DBC.WorkflowStepFields is Modified

* Deleted items
  * Field `.WorkflowStepFieldsParentWorkflowStepId`

* New items
  * Field `EntityCounts`
  * Field `WorkflowStepOption`
  * Field `WorkflowStepOptionLink`

##### SuperOffice.CRM.Data.DBC.EntityCountsFields is New

##### SuperOffice.CRM.Data.DBC.WorkflowStepOptionFields is New

##### SuperOffice.CRM.Data.DBC.WorkflowStepOptionLinkFields is New

#### SuperOffice.CRM.Data.EmailFlowTableInfo is Modified

* New items
  * Property `FromAddr`
  * Property `FromName`
  * Property `FromType`
  * Property `GaCampaign`
  * Property `GaSource`
  * Property `ReplyToAddr`
  * Property `ReplyToName`
  * Property `ReplyToType`
  * Property `SelectedDays`
  * Property `SmsSender`
  * Property `TimeframeEnd`
  * Property `TimeframeStart`
  * Property `UseGoogleAnalytics`
  * Property `UseTimeframe`

#### SuperOffice.CRM.Data.TZLocationTableInfo is Modified

* New items
  * Property `LeftOuterJoin_Workflow_TzLocationId`

#### SuperOffice.CRM.Data.WorkflowInstanceTableInfo is Modified

* New items
  * Property `NextStep`
  * Property `NextStep_InnerJoin_WorkflowStep`
  * Property `WaitUntil`

#### SuperOffice.CRM.Data.WorkflowStepTableInfo is Modified

* Deleted items
  * Property `ParentWorkflowStepId`
  * Property `ParentWorkflowStepId_InnerJoin_WorkflowStep`
* New items
  * Property `LeftOuterJoin_WorkflowInstance_NextStep`
  * Property `LeftOuterJoin_WorkflowStepOption_WorkflowStepId`
  * Property `LeftOuterJoin_WorkflowStepOptionLink_WorkflowStepId`

#### SuperOffice.CRM.Data.WorkflowTableInfo is Modified

* New items
  * Property `BlockLists`
  * Property `EnrollmentEnd`
  * Property `LeftOuterJoin_WorkflowStepOption_WorkflowId`
  * Property `RemoveFromFlows`
  * Property `TzLocationId`
  * Property `TzLocationId_InnerJoin_TZLocation`
  * Property `UseEnrollmentEnd`
  * Property `UseWorkflowStart`
  * Property `WorkflowStart`
  * Method `IdxVisibleForAssociatesVisibleForGroups(Int32[], Int32[])`
  * Method `IdxVisibleForAssociatesVisibleForGroupsRemoveFromFlows(Int32[], Int32[], Int32[])`

#### SuperOffice.CRM.Rows.EmailFlowRecordData is Modified

* New items
  * Field `FromAddr`
  * Field `FromName`
  * Field `FromType`
  * Field `GaCampaign`
  * Field `GaSource`
  * Field `ReplyToAddr`
  * Field `ReplyToName`
  * Field `ReplyToType`
  * Field `SelectedDays`
  * Field `SmsSender`
  * Field `TimeframeEnd`
  * Field `TimeframeStart`
  * Field `UseGoogleAnalytics`
  * Field `UseTimeframe`

#### SuperOffice.CRM.Rows.EmailFlowRow is Modified

* New items
  * Property `FromAddr`
  * Property `FromName`
  * Property `FromType`
  * Property `GaCampaign`
  * Property `GaSource`
  * Property `ReplyToAddr`
  * Property `ReplyToName`
  * Property `ReplyToType`
  * Property `SelectedDays`
  * Property `SmsSender`
  * Property `TimeframeEnd`
  * Property `TimeframeStart`
  * Property `UseGoogleAnalytics`
  * Property `UseTimeframe`

#### SuperOffice.CRM.Rows.Implementation.TicketRowImplementation is Modified

* New items
  * Method `ApplyBusinessLogic()`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(EmailFromType&, FieldInfo)`
  * Method `ValidateField(EmailReplyToType&, FieldInfo)`
  * Method `ValidateField(WorkflowTimeWaitAlgorithm&, FieldInfo)`
  * Method `ValidateField(WorkflowTimeWaitIntervalType&, FieldInfo)`

#### SuperOffice.CRM.Rows.WorkflowInstanceRecordData is Modified

* New items
  * Field `NextStep`
  * Field `WaitUntil`

#### SuperOffice.CRM.Rows.WorkflowInstanceRow is Modified

* New items
  * Property `NextStep`
  * Property `WaitUntil`

#### SuperOffice.CRM.Rows.WorkflowRecordData is Modified

* New items
  * Field `BlockLists`
  * Field `EnrollmentEnd`
  * Field `RemoveFromFlows`
  * Field `TzLocationId`
  * Field `UseEnrollmentEnd`
  * Field `UseWorkflowStart`
  * Field `WorkflowStart`

#### SuperOffice.CRM.Rows.WorkflowRow is Modified

* New items
  * Property `BlockLists`
  * Property `EnrollmentEnd`
  * Property `RemoveFromFlows`
  * Property `TzLocationId`
  * Property `UseEnrollmentEnd`
  * Property `UseWorkflowStart`
  * Property `WorkflowStart`

#### SuperOffice.CRM.Rows.WorkflowRows is Modified

* New items
  * Method `GetFromIdxVisibleForAssociatesVisibleForGroupsRemoveFromFlows(Int32[], Int32[], Int32[])`
  * Method `GetFromIdxVisibleForAssociatesVisibleForGroupsRemoveFromFlowsBlockLists(Int32[], Int32[], Int32[], Int32[])`

##### SuperOffice.CRM.Rows.WorkflowRows.IdxVisibleForAssociatesVisibleForGroupsRemoveFromFlows is New

##### SuperOffice.CRM.Rows.WorkflowRows.IdxVisibleForAssociatesVisibleForGroupsRemoveFromFlowsBlockLists is New

#### SuperOffice.CRM.Rows.WorkflowStepRecordData is Modified

* Deleted items
  * Field `ParentWorkflowStepId`

#### SuperOffice.CRM.Rows.WorkflowStepRow is Modified

* Deleted items
  * Property `ParentWorkflowStepId`

#### SuperOffice.CRM.Security.SentryQueryUpdater is Modified

* Deleted items
  * Method `AfterExecute(SqlCommand, SqlCommand)`
* New items
  * Method `AfterExecute(SqlCommand, SqlCommand, Int32)`

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* New items
  * Method `GetNextInQueue()`

#### SuperOffice.CRM.TicketMessage.TicketMessageHelper is Modified

* New items
  * Method `FindAndInsertInlineAttachments(String, Int32)`

#### SuperOffice.Data.Dialect.DatabaseOperations is Modified

* Modified items
  * Method `ExecuteNonQuery(String)`

#### SuperOffice.Data.Private.FreetextIndexer is Modified

* Deleted items
  * Method `AfterExecute(SqlCommand, SqlCommand)`
* New items
  * Method `AfterExecute(SqlCommand, SqlCommand, Int32)`

#### SuperOffice.Data.Private.SoftDeleteInterceptor is Modified

* Deleted items
  * Method `AfterExecute(SqlCommand, SqlCommand)`
* New items
  * Method `AfterExecute(SqlCommand, SqlCommand, Int32)`

#### SuperOffice.Data.Private.TicketLogging.TicketLogger is Modified

* Deleted items
  * Method `AfterExecute(SqlCommand, SqlCommand)`
* New items
  * Method `AfterExecute(SqlCommand, SqlCommand, Int32)`

#### SuperOffice.Data.Private.TicketLogging.TicketLoggingLogic is Modified

* Deleted items
  * Method `GetRegistryRow(Enum)`

#### SuperOffice.Data.Private.TravelTransactionLogger is Modified

* Deleted items
  * Method `AfterExecute(SqlCommand, SqlCommand)`
* New items
  * Method `AfterExecute(SqlCommand, SqlCommand, Int32)`

#### SuperOffice.Data.PrivateDbConnectionFactory is Modified

* Modified items
  * Method `CreateExplicit(String, String)`

#### SuperOffice.Data.QueryExectionExtensions is Modified

* Modified items
  * Method `ExecuteNonQuery(SqlCommand)`

#### SuperOffice.Data.QueryExecutionHelper is Modified

* Modified items
  * Method `ExecuteNonQuery(SqlCommand)`
  * Method `ExecuteNonQuery(SqlCommand, SoConnection)`
  * Method `ExecuteNonQuery(SqlCommand, Boolean)`
  * Method `ExecuteNonQuery(SqlCommand, Boolean, SoConnection)`
* New items
  * Property `RowsAffected`

#### SuperOffice.Data.SoCommand is Modified

* Deleted items
  * Method `ExecutePassThrough(String)`

#### SuperOffice.Data.SQL.Update is Modified

* New items
  * Property `AdditionalRestriction`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetEntityCountsTableInfo()`
  * Method `GetWorkflowStepOptionLinkTableInfo()`
  * Method `GetWorkflowStepOptionTableInfo()`


### Assembly: SuperOffice.Plugins

### Assembly: SoLicense

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### Deleted Types

* `SuperOffice.CD.DSL.Database.Steps_Targets.WorkflowStep01_Initial`
* `SuperOffice.CD.DSL.Database.Steps_Targets.WorkflowStep02_Rank`
* `SuperOffice.CD.DSL.Database.Steps_Targets.WorkflowStep03_Hierarchy`

### New Types

* `SuperOffice.CD.Database.EmailFromType`
* `SuperOffice.CD.Database.EmailReplyToType`
* `SuperOffice.CD.Database.WorkflowTimeWaitAlgorithm`
* `SuperOffice.CD.Database.WorkflowTimeWaitIntervalType`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep01_Initial`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep02_Rank`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep03_Hierarchy`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep04_EmailSettings`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep05_WorkflowSettings`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep06_WorkflowBlockList`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep07_WorkflowStepOptions`
* `SuperOffice.CD.DSL.Database.SuperOffice_98_EntityCounts`
* `SuperOffice.CD.DSL.Database.T_EntityCounts`
* `SuperOffice.CD.DSL.Database.T_WorkflowStepOption`
* `SuperOffice.CD.DSL.Database.T_WorkflowStepOptionLink`

### Modified Types

#### SuperOffice.CD.Database.Navigation is Modified

* New items
  * Field `TicketMinicard`

#### SuperOffice.CD.DSL.Database.T_EmailFlow is Modified

* New items
  * Field `FromAddr`
  * Field `FromName`
  * Field `FromType`
  * Field `GaCampaign`
  * Field `GaSource`
  * Field `ReplyToAddr`
  * Field `ReplyToName`
  * Field `ReplyToType`
  * Field `SelectedDays`
  * Field `SmsSender`
  * Field `TimeframeEnd`
  * Field `TimeframeStart`
  * Field `UseGoogleAnalytics`
  * Field `UseTimeframe`

#### SuperOffice.CD.DSL.Database.T_Workflow is Modified

* New items
  * Field `BlockLists`
  * Field `EnrollmentEnd`
  * Field `RemoveFromFlows`
  * Field `TzLocationId`
  * Field `UseEnrollmentEnd`
  * Field `UseWorkflowStart`
  * Field `WorkflowStart`

#### SuperOffice.CD.DSL.Database.T_WorkflowInstance is Modified

* New items
  * Field `NextStep`
  * Field `WaitUntil`

#### SuperOffice.CD.DSL.Database.T_WorkflowStep is Modified

* Deleted items
  * Field `ParentWorkflowStepId`



