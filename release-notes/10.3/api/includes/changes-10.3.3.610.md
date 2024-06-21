---
uid: version_10.3.3.610_changes
date: 3/20/2024
---

Changes from v10.3.2.841 and v10.3.3.610

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.WorkflowContentInfo`

### Modified Types

#### SuperOffice.CRM.Services.EmailFlow is Modified

* New items
  * Property `ContentInfo`

#### SuperOffice.CRM.Services.FormEntity is Modified

* New items
  * Property `EmailFlows`

#### SuperOffice.CRM.Services.WorkflowStepCreateRequest is Modified

* Deleted items
  * Property `Date`
  * Property `Status`
* New items
  * Property `TicketStatus`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.Data.DataSetProvider`
* `SuperOffice.Data.IDataSetProvider`
* `SuperOffice.Data.IRecordSetProvider`
* `SuperOffice.Data.Record`
* `SuperOffice.Data.RecordSetProvider`
* `SuperOffice.Data.RecordValue`

### New Types

* `SuperOffice.Data.WorkflowContentType`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.ArchiveColumnInfo is Modified

* New items
  * Property `IconHintPrefixDelimiter`

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.ExtraFieldAttrib is Modified

* New items
  * Field `.ExtraFieldAttribHideRestriction`
  * Field `.ExtraFieldAttribRank`
  * Field `.ExtraFieldAttribRootEntity`


#### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_APPOINTMENT_NO_ATTENDEES_ACCEPTED`
  * Field `SR_APPOINTMENT_SEND_EMAIL_TO_ACCEPTED`
* New items
  * Field `SR_APPOINTMENT_ATTENDEE_LIST_ACCEPTED`
  * Field `SR_APPOINTMENT_ATTENDEE_LIST_ALL`
  * Field `SR_APPOINTMENT_ATTENDEE_LIST_CONFLICT`
  * Field `SR_APPOINTMENT_ATTENDEE_LIST_DECLINED`
  * Field `SR_APPOINTMENT_NO_EMAIL`
  * Field `SR_APPOINTMENT_NO_MATCHING_PARTICIPANTS`
  * Field `SR_APPOINTMENT_REC_CHANGES_WARNING`
  * Field `SR_APPOINTMENT_SEND_EMAIL_TO_NOT_DECLINED`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_RESPONSELASTEMAIL`
  * Field `SR_ARCHIVE_WORKFLOW_ENROLLED_DATE`
  * Field `SR_FLOW_PARTICIPANT`
  * Field `SR_FLOW_REPORT`
  * Field `SR_FLOW_TRIGGER_ALLPERSONUPDATED`
  * Field `SR_FLOW_TRIGGER_CONTACTUPDATED`
  * Field `SR_FLOWREPORT_CTR_BY_EMAIL`
  * Field `SR_FLOWREPORT_ENROLLMENT_PARTICIPANTS_OVER_TIME`
  * Field `SR_FLOWREPORT_OPENRATE_BY_EMAIL`
  * Field `SR_FLOWREPORT_PARTICIPANT_DROPOUT_REASONS`
  * Field `SR_FLOWREPORT_PARTICIPANTS_BY_STATUS`
  * Field `SR_FLOWREPORT_RECIPIENTS`
  * Field `SR_FLOWREPORT_RECIPIENTS_BY_EMAIL`
  * Field `SR_FLOWREPORT_TOP_PERFORMING_EMAILS`
  * Field `SR_FORMARCHIVE_FORMDESCRIPTION`
  * Field `SR_FORMARCHIVE_FORMDESCRIPTION_TOOLTIP`
  * Field `SR_FORMARCHIVE_FORMID`
  * Field `SR_FORMARCHIVE_FORMID_TOOLTIP`
  * Field `SR_FORMARCHIVE_FORMNAME`
  * Field `SR_FORMARCHIVE_FORMNAME_TOOLTIP`
  * Field `SR_FORMARCHIVE_FORMTHUMBNAIL`
  * Field `SR_FORMARCHIVE_FORMTHUMBNAIL_TOOLTIP`
  * Field `SR_LABEL_FLOW_MAILING`
  * Field `SR_LABEL_FLOW_PARTICIPANT`
  * Field `SR_WORKFLOWS_BRANCH_PARTICIPANT_WARNING`
  * Field `SR_WORKFLOWS_FLOWS_FLOW`
  * Field `SR_WORKFLOWS_FLOWS_FLOWCONTENTS`
  * Field `SR_WORKFLOWS_FLOWS_PARTICIPANTS`
  * Field `SR_WORKFLOWS_FLOWS_REPORTS`
  * Field `SR_WORKFLOWS_FLOWS_SUMMARY`
  * Field `SR_WORKFLOWS_FORM_IS_ASSET_WARNING`
  * Field `SR_WORKFLOWS_FORM_IS_ASSET_WARNING_HEADING`
  * Field `SR_WORKFLOWS_FORMHASACTION_WARNING`
  * Field `SR_WORKFLOWS_LINKHASACTION_WARNING`
  * Field `SR_WORKFLOWS_STEP_PARTICIPANT_TOOLTIP`

#### SuperOffice.Util.HtmlHelper is Modified

* New items
  * Method `EscapePercentageSymbols(String)`


### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.ArchiveLists.EmailFlowContentEmailFlowContentExtender`

### New Types

* `SuperOffice.CRM.ArchiveLists.EmailFlowContentFormExtender`
* `SuperOffice.CRM.ArchiveLists.EmailFlowContentSMessageExtender`
* `SuperOffice.CRM.ArchiveLists.EmailFlowFormContentProvider`
* `SuperOffice.CRM.ArchiveLists.EmailFlowSMessageContentProvider`
* `SuperOffice.CRM.ArchiveLists.FormEmailFlowExtender`
* `SuperOffice.CRM.ArchiveLists.FormExtenderBase`
* `SuperOffice.CRM.ArchiveLists.Joiners.AppointmentExtraFieldExtender`
* `SuperOffice.CRM.ArchiveLists.Joiners.ProjectExtraFieldExtender`
* `SuperOffice.CRM.ArchiveLists.Joiners.SaleExtraFieldExtender`
* `SuperOffice.CRM.Data.WorkflowRootStepLinkTableInfo`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowRootStepLinkRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowRootStepLinkRowsFactory`
* `SuperOffice.CRM.Rows.WorkflowRootStepLinkRecordData`
* `SuperOffice.CRM.Rows.WorkflowRootStepLinkRecordDataExtensions`
* `SuperOffice.CRM.Rows.WorkflowRootStepLinkRow`
* `SuperOffice.CRM.Rows.WorkflowRootStepLinkRows`
* `.TicketStatusWithoutPostponeProvider`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.ArchiveProviderFactory is Modified

* New items
  * Method `HandlesExtraTable(String, String)`

#### SuperOffice.CRM.ArchiveLists.AssociateExtenderBase is Modified

* New items
  * Field `ColumnLocationAddress`

#### SuperOffice.CRM.ArchiveLists.AssociateResourceExtender is Modified

* New items
  * Method `InnerModifyQuery()`

#### SuperOffice.CRM.ArchiveLists.EmailFlowContentProvider is Modified

* Deleted items
  * Field `RowTypeName`
* New items
  * Field `ColDescription`
  * Field `ColId`
  * Field `ColShortDescription`
  * Field `ColThumbnail`

#### SuperOffice.CRM.ArchiveLists.ExtraFieldExtenderBase is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.ExtraFieldExtenderBase.RecursionInfo is Modified

* Deleted items
  * Property `.RecursionInfoRootEntity`
* New items
  * Property `.RecursionInfoColumnRank`


#### SuperOffice.CRM.ArchiveLists.FavouritePersonExtender is Modified

* New items
  * Field `ColumnFavouritePersonEmailAddress`

#### SuperOffice.CRM.ArchiveLists.FavouritesProvider is Modified

* New items
  * Field `ColumnEmailAddress`

#### SuperOffice.CRM.ArchiveLists.FreetextMatchCalculator is Modified

* Deleted items
  * Method `CalculateMatches(String[], String[], Nullable<Int32>, Nullable<Int32>, Boolean, List<PartialMatches>)`
* New items
  * Method `CalculateMatches(String[], String[], Nullable<Int32>, Nullable<Int32>, Boolean, List<PartialMatches>, Boolean)`

#### SuperOffice.CRM.ArchiveLists.MailingsExtenderBase is Modified

* New items
  * Method `MailingsExtenderBase(Features)`

##### SuperOffice.CRM.ArchiveLists.MailingsExtenderBase.Features is New

#### SuperOffice.CRM.ArchiveLists.PersonExtenderBase is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.PersonExtenderBase.Features is Modified

* New items
  * Field `.FeaturesFlowParticipant`


#### SuperOffice.CRM.ArchiveLists.ShipmentMessageExtenderBase is Modified

* New items
  * Method `ShipmentMessageExtenderBase(Features)`

##### SuperOffice.CRM.ArchiveLists.ShipmentMessageExtenderBase.Features is New

#### SuperOffice.CRM.ArchiveLists.ShipmentMessageShipmentExtender is Modified

* New items
  * Method `ShipmentMessageShipmentExtender(Features)`

#### SuperOffice.CRM.ArchiveLists.WorkflowInstanceExtenderBase is Modified


#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_WorkflowRootStepLink_RegisteredAssociateId`
  * Property `LeftOuterJoin_WorkflowRootStepLink_UpdatedAssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.EjscriptFields is Modified

* New items
  * Field `.EjscriptFieldsLastExecAnonHttp`
  * Field `.EjscriptFieldsLastExecHttp`


##### SuperOffice.CRM.Data.DBC.EmailFlowContentLinkFields is Modified

* New items
  * Field `.EmailFlowContentLinkFieldsFormId`
  * Field `.EmailFlowContentLinkFieldsSLinkId`


##### SuperOffice.CRM.Data.DBC.EmailFlowFields is Modified

* New items
  * Field `.EmailFlowFieldsMainMessageId`


##### SuperOffice.CRM.Data.DBC.WorkflowStepFields is Modified

* Deleted items
  * Field `.WorkflowStepFieldsRank`
  * Field `.WorkflowStepFieldsWorkflowId`


##### SuperOffice.CRM.Data.DBC.WorkflowStepOptionFields is Modified

* Deleted items
  * Field `.WorkflowStepOptionFieldsWorkflowId`


##### SuperOffice.CRM.Data.DBC.WorkflowStepOptionLinkFields is Modified

* New items
  * Field `.WorkflowStepOptionLinkFieldsRank`


##### SuperOffice.CRM.Data.DBC.WorkflowWaitForActionFields is Modified

* Deleted items
  * Field `.WorkflowWaitForActionFieldsWorkflowId`

* New items
  * Field `WorkflowRootStepLink`

##### SuperOffice.CRM.Data.DBC.WorkflowRootStepLinkFields is New

#### SuperOffice.CRM.Data.EjscriptTableInfo is Modified

* New items
  * Property `LastExecAnonHttp`
  * Property `LastExecHttp`

#### SuperOffice.CRM.Data.EmailFlowContentLinkTableInfo is Modified

* New items
  * Property `FormId`
  * Property `FormId_InnerJoin_Form`
  * Property `SLinkId`
  * Property `SLinkId_InnerJoin_SLink`

#### SuperOffice.CRM.Data.EmailFlowTableInfo is Modified

* New items
  * Property `MainMessageId`
  * Property `MainMessageId_InnerJoin_SMessage`

#### SuperOffice.CRM.Data.FormTableInfo is Modified

* New items
  * Property `LeftOuterJoin_EmailFlowContentLink_FormId`

#### SuperOffice.CRM.Data.SLinkTableInfo is Modified

* New items
  * Property `LeftOuterJoin_EmailFlowContentLink_SLinkId`

#### SuperOffice.CRM.Data.SMessageTableInfo is Modified

* New items
  * Property `LeftOuterJoin_EmailFlow_MainMessageId`

#### SuperOffice.CRM.Data.WorkflowStepOptionLinkTableInfo is Modified

* New items
  * Property `Rank`

#### SuperOffice.CRM.Data.WorkflowStepOptionTableInfo is Modified

* Deleted items
  * Property `WorkflowId`
  * Property `WorkflowId_InnerJoin_Workflow`

#### SuperOffice.CRM.Data.WorkflowStepTableInfo is Modified

* Deleted items
  * Property `Rank`
  * Property `WorkflowId`
  * Property `WorkflowId_InnerJoin_Workflow`
* New items
  * Property `LeftOuterJoin_WorkflowRootStepLink_WorkflowStepId`

#### SuperOffice.CRM.Data.WorkflowTableInfo is Modified

* Deleted items
  * Property `LeftOuterJoin_WorkflowStep_WorkflowId`
  * Property `LeftOuterJoin_WorkflowStepOption_WorkflowId`
  * Property `LeftOuterJoin_WorkflowWaitForAction_WorkflowId`
* New items
  * Property `LeftOuterJoin_WorkflowRootStepLink_WorkflowId`

#### SuperOffice.CRM.Data.WorkflowWaitForActionTableInfo is Modified

* Deleted items
  * Property `WorkflowId`
  * Property `WorkflowId_InnerJoin_Workflow`

#### SuperOffice.CRM.Documents.SoArc2Helper is Modified

* New items
  * Method `MakeLegalPathName(String)`

#### SuperOffice.CRM.Entities.AppointmentMatrix is Modified

* New items
  * Property `ForceChildProcessing`

#### SuperOffice.CRM.Entities.RecurrenceManager is Modified

* New items
  * Method `OnInternalNotesHtmlTextChange(Appointment, String, String, String)`
  * Method `OnInternalNotesTextChange(Appointment, String, String, String)`

#### SuperOffice.CRM.Lists.FormProvider is Modified

* New items
  * Method `HasActions(String)`

#### SuperOffice.CRM.Lists.LocationListProvider is Modified


#### SuperOffice.CRM.Lists.PersonFavouriteListProvider is Modified

* New items
  * Field `IncludeHasEmail`

#### SuperOffice.CRM.Lists.VisibleForAssociateMDOProvider is Modified

* New items
  * Field `IncludeHasEmail`

#### SuperOffice.CRM.Rows.EjscriptRecordData is Modified

* New items
  * Field `LastExecAnonHttp`
  * Field `LastExecHttp`

#### SuperOffice.CRM.Rows.EjscriptRow is Modified

* New items
  * Property `LastExecAnonHttp`
  * Property `LastExecHttp`

#### SuperOffice.CRM.Rows.EmailFlowContentLinkRecordData is Modified

* New items
  * Field `FormId`
  * Field `SLinkId`

#### SuperOffice.CRM.Rows.EmailFlowContentLinkRow is Modified

* New items
  * Property `FormId`
  * Property `SLinkId`

#### SuperOffice.CRM.Rows.EmailFlowRecordData is Modified

* New items
  * Field `MainMessageId`

#### SuperOffice.CRM.Rows.EmailFlowRow is Modified

* New items
  * Property `MainMessageId`

#### SuperOffice.CRM.Rows.Implementation.TicketRowImplementation is Modified

* Deleted items
  * Method `HandlePostponedStatuses(TicketBaseStatus)`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(WorkflowContentType&, FieldInfo)`

#### SuperOffice.CRM.Rows.WorkflowStepOptionLinkRecordData is Modified

* New items
  * Field `Rank`

#### SuperOffice.CRM.Rows.WorkflowStepOptionLinkRow is Modified

* New items
  * Property `Rank`

#### SuperOffice.CRM.Rows.WorkflowStepOptionRecordData is Modified

* Deleted items
  * Field `WorkflowId`

#### SuperOffice.CRM.Rows.WorkflowStepOptionRow is Modified

* Deleted items
  * Property `WorkflowId`

#### SuperOffice.CRM.Rows.WorkflowStepRecordData is Modified

* Deleted items
  * Field `Rank`
  * Field `WorkflowId`

#### SuperOffice.CRM.Rows.WorkflowStepRow is Modified

* Deleted items
  * Property `Rank`
  * Property `WorkflowId`

#### SuperOffice.CRM.Rows.WorkflowWaitForActionRecordData is Modified

* Deleted items
  * Field `WorkflowId`

#### SuperOffice.CRM.Rows.WorkflowWaitForActionRow is Modified

* Deleted items
  * Property `WorkflowId`

#### SuperOffice.CRM.Workflow.CreateRequestSettings is Modified

* Deleted items
  * Property `RequestDate`
  * Property `Status`

#### SuperOffice.CRM.WorkFlow.WorkflowEngine is Modified

* New items
  * Method `DoRequestEvent(WorkflowEvent)`
  * Method `GoalReached(WorkflowInstanceRow)`

#### SuperOffice.CRM.Workflow.WorkflowStepBase is Modified

* Deleted items
  * Method `ConditionsMet()`
  * Method `GoalReached()`

#### SuperOffice.CRM.Workflow.WorkflowUtil is Modified

* Modified items
  * Method `GetRootStepIds(Int32)`
  * Method `GetStepIds(Int32, WorkflowStepType)`
* New items
  * Method `CalculateTime(WorkflowTimeWaitIntervalType, Int32, DateTime)`
  * Method `CleanRestrictions(ArchiveRestrictionInfo[])`
  * Method `GetWorkflowIdFromStepId(Int32)`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetWorkflowRootStepLinkTableInfo()`


### Assembly: SuperOffice.Plugins

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.WorkflowContentType`
* `SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_10_Remove_FT_NSTicketType`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_52_LastExecutedByHttp`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep18_EmailFlowContentFormsAndLinks`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep19_WorkflowSchemaOptimization_part1`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep20_WorkflowSchemaOptimization_part2`
* `SuperOffice.CD.DSL.Database.T_WorkflowRootStepLink`

### Modified Types

#### SuperOffice.CD.DSL.Database.T_Ejscript is Modified

* New items
  * Field `LastExecAnonHttp`
  * Field `LastExecHttp`

#### SuperOffice.CD.DSL.Database.T_EmailFlow is Modified

* New items
  * Field `MainMessageId`

#### SuperOffice.CD.DSL.Database.T_EmailFlowContentLink is Modified

* New items
  * Field `FormId`
  * Field `SLinkId`

#### SuperOffice.CD.DSL.Database.T_WorkflowStep is Modified

* Deleted items
  * Field `Rank`
  * Field `WorkflowId`

#### SuperOffice.CD.DSL.Database.T_WorkflowStepOption is Modified

* Deleted items
  * Field `WorkflowId`

#### SuperOffice.CD.DSL.Database.T_WorkflowStepOptionLink is Modified

* New items
  * Field `Rank`

#### SuperOffice.CD.DSL.Database.T_WorkflowWaitForAction is Modified

* Deleted items
  * Field `WorkflowId`



