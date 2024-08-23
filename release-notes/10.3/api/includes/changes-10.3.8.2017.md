---
uid: version_10.3.8.2017_changes
date: 8/23/2024
---

Changes from v10.3.7.352 and v10.3.8.2017

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.CreateSystemMessageList`
* `SuperOffice.CRM.Services.CRMScriptSourceMap`
* `SuperOffice.CRM.Services.SystemMessage`

### Modified Types

#### SuperOffice.CRM.Services.CRMScriptAgent is Modified

* New items
  * Method `ResolveIncludes(String)`
  * Method `SaveCRMScriptEntityWithoutCompile(CRMScriptEntity)`

#### SuperOffice.CRM.Services.CRMScriptEntity is Modified

* New items
  * Property `AccessKey`
  * Property `HtmlOutput`
  * Property `Includes`
  * Property `ScriptType`
  * Property `SourceCode`
  * Property `SourceMaps`
  * Property `ValidationResult`

#### SuperOffice.CRM.Services.CRMScriptErrorInfo is Modified

* Deleted items
  * Property `ErrorCharacterPosition`
  * Property `ErrorLine`
* New items
  * Property `CharacterPosition`
  * Property `IncludeId`
  * Property `LineNumber`

#### SuperOffice.CRM.Services.CRMScriptResult is Modified

* New items
  * Property `Includes`
  * Property `SourceMaps`
  * Property `Transpiled`

#### SuperOffice.CRM.Services.DiagnosticsAgent is Modified

* New items
  * Method `GetSystemMessages(Int32)`
  * Method `RemoveExpiredSystemMessages()`
  * Method `RemoveSystemMessage(Int32, String)`
  * Method `RemoveSystemMessageForAssociate(Int32, String, Int32)`
  * Method `SendSystemMessage(String, Int32, String, DateTime, SystemMessageType)`

#### SuperOffice.CRM.Services.EventData is Modified

* New items
  * Property `TraceExecution`

#### SuperOffice.CRM.Services.ICRMScriptAgent is Modified

* New items
  * Method `ResolveIncludes(String)`
  * Method `SaveCRMScriptEntityWithoutCompile(CRMScriptEntity)`

#### SuperOffice.CRM.Services.IDiagnosticsAgent is Modified

* New items
  * Method `GetSystemMessages(Int32)`
  * Method `RemoveExpiredSystemMessages()`
  * Method `RemoveSystemMessage(Int32, String)`
  * Method `RemoveSystemMessageForAssociate(Int32, String, Int32)`
  * Method `SendSystemMessage(String, Int32, String, DateTime, SystemMessageType)`

#### SuperOffice.CRM.Services.IPersonAgent is Modified

* New items
  * Method `TryAddPersonsToEmailFlow(Int32, Int32[])`

#### SuperOffice.CRM.Services.PersonAgent is Modified

* New items
  * Method `TryAddPersonsToEmailFlow(Int32, Int32[])`

#### SuperOffice.CRM.Services.TicketType is Modified

* New items
  * Property `ReplyExternalAsDefault`
  * Property `ReplyForwardNoSignature`

#### SuperOffice.CRM.Services.TicketTypeEntity is Modified

* New items
  * Property `ReplyExternalAsDefault`
  * Property `ReplyForwardNoSignature`

#### SuperOffice.CRM.Services.WorkflowStepNotifyByEmail is Modified

* Deleted items
  * Property `ShipmentId`

#### SuperOffice.CRM.Services.WorkflowStepNotifyBySMS is Modified

* Deleted items
  * Property `ShipmentId`

## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.CRM.Documents.AsponseInitializer`
* `SuperOffice.Data.DocumentHandler`
* `SuperOffice.Data.MailClient`
* `SuperOffice.Data.SystemMessageType`
* `SuperOffice.Util.OnlineConfigWaiter`

### Modified Types

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.Client is Modified

* New items
  * Property `.ClientHighchartsExportServiceUrl`


##### SuperOffice.Configuration.ConfigFile.ClientSection is Modified

* New items
  * Property `.ClientSectionHighchartsExportServiceUrl`


#### SuperOffice.CRM.ApplicationIcons is Modified

* New items
  * Method `GetApplicationIcon(Int32, Boolean)`

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.IconHints is Modified

* Deleted items
  * Field `.IconHintsExtratable`
* New items
  * Field `.IconHintsCustomObject`


#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.DiaryView is Modified

* New items
  * Field `.DiaryViewNewFollowUpDialogActive`


#### SuperOffice.Data.EventHandlerType is Modified

* New items
  * Field `SalesLoadCustomObject`

#### SuperOffice.Data.GeneratorEncoding is Modified

* New items
  * Field `MsWord2007`

#### SuperOffice.Diagnostics.SoLogger is Modified

* New items
  * Method `Count(String, NameValueCollection, ValueTuple<String, Double>[])`

#### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_DASHBOARD_MEASURE_COUNT_ALL`
* New items
  * Field `SR_ADMIN_TICKETTYPE_REPLY_FORWARD_SETTINGS`
  * Field `SR_ADMIN_TICKETTYPE_REPLY_FORWARD_SETTINGS_EXCLUDE_SIGNATURE`
  * Field `SR_ADMIN_TICKETTYPE_REPLY_FORWARD_SETTINGS_EXTERNAL_DEFAULT`
  * Field `SR_ARCHIVE_AGGREGATE_LABEL`
  * Field `SR_ARCHIVE_AVERAGE_LABEL`
  * Field `SR_ARCHIVE_COUNT_LABEL`
  * Field `SR_ARCHIVE_MINMAX_LABEL`
  * Field `SR_ARCHIVE_SUM_LABEL`
  * Field `SR_CONFIRMATION_DELETE_DOCUMENT`
  * Field `SR_CONTACT_WITH_DEPARTMENT_EXISTS`
  * Field `SR_DASHBOARD_MEASURE_COUNTALL`
  * Field `SR_DOCUMENT_EDITED_BY_ASSOC`
  * Field `SR_DOCUMENT_EDITED_BY_OTHER`
  * Field `SR_DOCUMENT_EDITED_BY_SELF`
  * Field `SR_DOCUMENT_SAVE_AND_CHECKIN`
  * Field `SR_DOCUMENT_SAVE_NO_CHECKIN`
  * Field `SR_FILE_DROP_MULTIPLE_ERROR`
  * Field `SR_FILEUPLOAD_REQUIRED_ERROR`
  * Field `SR_FIND_CUSTOMOBJECT`
  * Field `SR_FORMS_RATING_0_NPS`
  * Field `SR_FORMS_RATING_1_DICE`
  * Field `SR_FORMS_RATING_1_NPS`
  * Field `SR_FORMS_RATING_1_STARS`
  * Field `SR_FORMS_RATING_10_NPS`
  * Field `SR_FORMS_RATING_2_DICE`
  * Field `SR_FORMS_RATING_2_NPS`
  * Field `SR_FORMS_RATING_2_STARS`
  * Field `SR_FORMS_RATING_3_DICE`
  * Field `SR_FORMS_RATING_3_NPS`
  * Field `SR_FORMS_RATING_3_STARS`
  * Field `SR_FORMS_RATING_4_DICE`
  * Field `SR_FORMS_RATING_4_NPS`
  * Field `SR_FORMS_RATING_4_STARS`
  * Field `SR_FORMS_RATING_5_DICE`
  * Field `SR_FORMS_RATING_5_NPS`
  * Field `SR_FORMS_RATING_5_STARS`
  * Field `SR_FORMS_RATING_6_DICE`
  * Field `SR_FORMS_RATING_6_NPS`
  * Field `SR_FORMS_RATING_7_NPS`
  * Field `SR_FORMS_RATING_8_NPS`
  * Field `SR_FORMS_RATING_9_NPS`
  * Field `SR_FORMS_RATING_SMILEYS_HAPPY`
  * Field `SR_FORMS_RATING_SMILEYS_NEUTRAL`
  * Field `SR_FORMS_RATING_SMILEYS_SAD`
  * Field `SR_FORMS_RATING_THUMBS_DOWN`
  * Field `SR_FORMS_RATING_THUMBS_UP`
  * Field `SR_MINICARD_COPILOT`
  * Field `SR_MM_CONTACTS_REPLACE_EMPTY_FIELDS`
  * Field `SR_MM_WILL_BE_DELETED`
  * Field `SR_PD_request_includeOwnTicketsInGetNext_DESC`
  * Field `SR_PD_request_includeOwnTicketsInGetNext_NAME`
  * Field `SR_PRINT_LABELS_A4`
  * Field `SR_PRINT_LABELS_BOTTOM`
  * Field `SR_PRINT_LABELS_CHOOSE_LABEL`
  * Field `SR_PRINT_LABELS_CM`
  * Field `SR_PRINT_LABELS_CONFIRM_DELETE`
  * Field `SR_PRINT_LABELS_CUSTOM`
  * Field `SR_PRINT_LABELS_DEFINE_LABEL_LAYOUT`
  * Field `SR_PRINT_LABELS_DELETE_LAYOUT`
  * Field `SR_PRINT_LABELS_HEIGHT`
  * Field `SR_PRINT_LABELS_INCHES`
  * Field `SR_PRINT_LABELS_INVALID_BOTTOM_MARGIN`
  * Field `SR_PRINT_LABELS_INVALID_COLUMN`
  * Field `SR_PRINT_LABELS_INVALID_HEIGHT`
  * Field `SR_PRINT_LABELS_INVALID_LEFT_MARGIN`
  * Field `SR_PRINT_LABELS_INVALID_RIGHT_MARGIN`
  * Field `SR_PRINT_LABELS_INVALID_ROW`
  * Field `SR_PRINT_LABELS_INVALID_TOP_MARGIN`
  * Field `SR_PRINT_LABELS_INVALID_WIDTH`
  * Field `SR_PRINT_LABELS_LABELS`
  * Field `SR_PRINT_LABELS_LANDSCAPE`
  * Field `SR_PRINT_LABELS_LEFT`
  * Field `SR_PRINT_LABELS_MARGINS`
  * Field `SR_PRINT_LABELS_NAME_MANDATORY`
  * Field `SR_PRINT_LABELS_ORIENTATION`
  * Field `SR_PRINT_LABELS_PAPER`
  * Field `SR_PRINT_LABELS_PORTRAIT`
  * Field `SR_PRINT_LABELS_RIGHT`
  * Field `SR_PRINT_LABELS_TOP`
  * Field `SR_PRINT_LABELS_TYPE`
  * Field `SR_PRINT_LABELS_US_LETTER`
  * Field `SR_PRINT_LABELS_WIDTH`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONCUSTOMERCHATLOG`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONCUSTOMERCONFIRMEMAIL`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONCUSTOMERNEWCUSTOMER`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONCUSTOMERPASSWORD`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONCUSTOMERREPLY`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONHOTLISTNEWMESSAGE`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONHOTLISTTICKETACTIVATED`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONHOTLISTTICKETALARM`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONHOTLISTTICKETTAKENOVER`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONLICENSEEXPIRATIONWARNING`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONNEWLINK`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONPRINTTICKET`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONPUBLISHKBANSWER`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONPUBLISHKBQUESTION`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONUSERACTIVETICKETS`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONUSERNEWMESSAGE`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONUSERNEWTICKET`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONUSERTICKETACTIVATED`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONUSERTICKETALARM`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONUSERTICKETTAKENOVER`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATEDESCRIPTIONWEEKSTAT`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMECUSTOMERCHATLOG`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMECUSTOMERCONFIRMEMAIL`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMECUSTOMERNEWCUSTOMER`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMECUSTOMERPASSWORD`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMECUSTOMERREPLY`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEHOTLISTNEWMESSAGE`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEHOTLISTTICKETACTIVATED`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEHOTLISTTICKETALARM`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEHOTLISTTICKETTAKENOVER`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMELICENSEEXPIRATIONWARNING`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMENEWLINK`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEPRINTTICKET`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEPUBLISHKBANSWER`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEPUBLISHKBQUESTION`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEUSERACTIVETICKETS`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEUSERNEWMESSAGE`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEUSERNEWTICKET`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEUSERTICKETACTIVATED`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEUSERTICKETALARM`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEUSERTICKETTAKENOVER`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATENAMEWEEKSTAT`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTCUSTOMERCHATLOG`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTCUSTOMERCONFIRMEMAIL`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTCUSTOMERNEWCUSTOMER`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTCUSTOMERPASSWORD`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTCUSTOMERREPLY`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTHOTLISTNEWMESSAGE`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTHOTLISTTICKETACTIVATED`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTHOTLISTTICKETALARM`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTHOTLISTTICKETTAKENOVER`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTLICENSEEXPIRATIONWARNING`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTNEWLINK`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTNOSUBJECT`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTPRINTTICKET`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTUSERACTIVETICKETS`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTUSERNEWMESSAGE`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTUSERNEWTICKET`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTUSERTICKETACTIVATED`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTUSERTICKETALARM`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTUSERTICKETTAKENOVER`
  * Field `SR_REPLYTEMPLATES_REPLYTEMPLATESUBJECTWEEKSTAT`
  * Field `SR_SETTINGS_EMAILCLIENT`
  * Field `SR_SETTINGS_NUMBER_AND_DATE_FORMAT`
  * Field `SR_STANDARDCATEGORIES_ADMINISTRATION`
  * Field `SR_STANDARDCATEGORIES_SALE`
  * Field `SR_STANDARDCATEGORIES_SUPPORT`
  * Field `SR_SYSTEMTEMPLATES_ACTIVETICKETS`
  * Field `SR_SYSTEMTEMPLATES_ASSIGNEDTICKET`
  * Field `SR_SYSTEMTEMPLATES_CHATLOG`
  * Field `SR_SYSTEMTEMPLATES_CUSTOMERCONFIRMEMAIL`
  * Field `SR_SYSTEMTEMPLATES_CUSTOMERREPLY`
  * Field `SR_SYSTEMTEMPLATES_CUSTOMERSENDPASSWORD`
  * Field `SR_SYSTEMTEMPLATES_LICENSEEXPIRATIONWARNING`
  * Field `SR_SYSTEMTEMPLATES_NEWCUSTMAIL`
  * Field `SR_SYSTEMTEMPLATES_NEWMESSAGE`
  * Field `SR_SYSTEMTEMPLATES_NEWMESSAGEHOTLIST`
  * Field `SR_SYSTEMTEMPLATES_PRINTTICKET`
  * Field `SR_SYSTEMTEMPLATES_PUBLISHKBANSWER`
  * Field `SR_SYSTEMTEMPLATES_PUBLISHKBQUESTION`
  * Field `SR_SYSTEMTEMPLATES_SUGGESTFAQ`
  * Field `SR_SYSTEMTEMPLATES_TICKETACTIVATED`
  * Field `SR_SYSTEMTEMPLATES_TICKETACTIVATEDHOTLIST`
  * Field `SR_SYSTEMTEMPLATES_TICKETALERT`
  * Field `SR_SYSTEMTEMPLATES_TICKETALERTHOTLIST`
  * Field `SR_SYSTEMTEMPLATES_TICKETTAKENOVER`
  * Field `SR_SYSTEMTEMPLATES_TICKETTAKENOVERHOTLIST`
  * Field `SR_SYSTEMTEMPLATES_WEEKSTAT`
  * Field `SR_TICKETPRIORITY_HIGH`
  * Field `SR_TICKETPRIORITY_LOW`
  * Field `SR_TICKETPRIORITY_MEDIUM`
  * Field `SR_WORKFLOWSTEP_INVALID_MISSING_SENDER`

#### SuperOffice.IO.TagContainer is Modified

* New items
  * Method `GetTags()`

#### SuperOffice.License.SoLicenseNames is Modified

* New items
  * Field `Nebula`

#### SuperOffice.Util.HttpHelper is Modified

* Modified items

##### SuperOffice.Util.HttpHelper.HttpServiceJwtConfig is Modified

* New items
  * Property `.HttpServiceJwtConfigHugoAI_User`



### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.ArchiveLists.Archive.ExtraTableSelectionCombinedProviderV2`
* `SuperOffice.CRM.ArchiveLists.Archive.ExtraTableSelectionDynamicProviderSingleCriteriaGroup`
* `SuperOffice.CRM.ArchiveLists.Archive.ExtraTableSelectionDynamicProviderV2`
* `SuperOffice.CRM.ArchiveLists.Archive.ExtraTableSelectionProviderBaseV2`
* `SuperOffice.CRM.ArchiveLists.Archive.ExtraTableSelectionProviderV2`
* `SuperOffice.CRM.ArchiveLists.Archive.ExtraTableSelectionStaticProviderV2`
* `SuperOffice.CRM.ArchiveLists.ExtraTableProvider`
* `SuperOffice.CRM.ArchiveLists.ExtraTableProviderBase`
* `SuperOffice.CRM.ArchiveLists.Joiners.ExtraTableExtraFieldExtender`
* `SuperOffice.CRM.Documents.AsponseInitializer`

### New Types

* `SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionCombinedProviderV2`
* `SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionDynamicProviderSingleCriteriaGroup`
* `SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionDynamicProviderV2`
* `SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionProviderBaseV2`
* `SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionProviderV2`
* `SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionStaticProviderV2`
* `SuperOffice.CRM.ArchiveLists.CustomObjectProvider`
* `SuperOffice.CRM.ArchiveLists.CustomObjectProviderBase`
* `SuperOffice.CRM.ArchiveLists.Joiners.CustomObjectExtraFieldExtender`
* `SuperOffice.CRM.Cache.OnlineAppCache`
* `SuperOffice.CRM.Entities.Providers.Factory.PersonInfo4ProviderIdFactory`
* `SuperOffice.CRM.Entities.Providers.Factory.PersonInfo4ProviderRDBFactory`
* `SuperOffice.CRM.Lists.ActiveLanguageProvider`
* `SuperOffice.CRM.Lists.DocumentHandlerProvider`
* `SuperOffice.CRM.Lists.MailClientProvider`
* `SuperOffice.CRM.Lists.RatingDiceProvider`
* `SuperOffice.CRM.Lists.RatingNpsProvider`
* `SuperOffice.CRM.Lists.RatingSmileysProvider`
* `SuperOffice.CRM.Lists.RatingStarsProvider`
* `SuperOffice.CRM.Lists.RatingThumbsProvider`
* `SuperOffice.CRM.Lists.TemplateVariablesProvider`
* `SuperOffice.CRM.Mail.SendSmsHelper`
* `SuperOffice.CRM.Script.CRMScriptHelper`
* `SuperOffice.CRM.Script.CRMScriptValidationException`
* `SuperOffice.Data.SQL.SystemMessageTypeFieldInfo`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentAssociateExtender is Modified

* New items
  * Method `InnerModifyQuery()`

#### SuperOffice.CRM.ArchiveLists.AppointmentUdefExtender is Modified

* Deleted items
  * Method `AppointmentUdefExtender()`
* New items
  * Method `AppointmentUdefExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ArchiveProviderFactory is Modified

* Deleted items
  * Method `HandlesExtraTable(String, String)`
* New items
  * Method `HandlesCustomObject(String, String)`

#### SuperOffice.CRM.ArchiveLists.ContactSaintExtender is Modified

* Deleted items
  * Method `ContactSaintExtender()`
* New items
  * Method `ContactSaintExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ContactUdefExtender is Modified

* Deleted items
  * Method `ContactUdefExtender()`
* New items
  * Method `ContactUdefExtender(String)`

#### SuperOffice.CRM.ArchiveLists.FormFieldsExtender is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.FormFieldsExtender.FormField is Modified

* New items
  * Field `.FormFieldOriginalLabel`


#### SuperOffice.CRM.ArchiveLists.PersonSaintExtender is Modified

* Deleted items
  * Method `PersonSaintExtender()`
* New items
  * Method `PersonSaintExtender(String)`

#### SuperOffice.CRM.ArchiveLists.PersonUdefExtender is Modified

* Deleted items
  * Method `PersonUdefExtender()`
* New items
  * Method `PersonUdefExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ProjectSaintExtender is Modified

* Deleted items
  * Method `ProjectSaintExtender()`
* New items
  * Method `ProjectSaintExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ProjectUdefExtender is Modified

* Deleted items
  * Method `ProjectUdefExtender()`
* New items
  * Method `ProjectUdefExtender(String)`

#### SuperOffice.CRM.ArchiveLists.SaleUdefExtender is Modified

* Deleted items
  * Method `SaleUdefExtender()`
* New items
  * Method `SaleUdefExtender(String)`

#### SuperOffice.CRM.CustomObject.CustomObjectHelper is Modified

* Deleted items
  * Method `ResolveRelationColumn(SoField)`
* New items
  * Method `ResolveRelationField(SoField)`
  * Method `ShouldHideIdField(String)`

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_Message_AssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.EjscriptFields is Modified

* New items
  * Field `.EjscriptFieldsIncludes`
  * Field `.EjscriptFieldsLastCompiled`
  * Field `.EjscriptFieldsSourceCode`
  * Field `.EjscriptFieldsSourceMaps`


##### SuperOffice.CRM.Data.DBC.MessageFields is Modified

* Deleted items
  * Field `.MessageFieldsDescription`
  * Field `.MessageFieldsDetailsRecord`
  * Field `.MessageFieldsDetailsTable`
  * Field `.MessageFieldsMessageType`
  * Field `.MessageFieldsMotherId`
  * Field `.MessageFieldsSourceHandler`
  * Field `.MessageFieldsTargetHandler`
* New items
  * Field `.MessageFieldsAssociateId`
  * Field `.MessageFieldsExpire`
  * Field `.MessageFieldsMarkdownMessage`
  * Field `.MessageFieldsOnlineappId`
  * Field `.MessageFieldsSystemMessageId`
  * Field `.MessageFieldsType`


##### SuperOffice.CRM.Data.DBC.TicketTypeFields is Modified

* New items
  * Field `.TicketTypeFieldsReplyExternalAsDefault`
  * Field `.TicketTypeFieldsReplyForwardNoSignature`


#### SuperOffice.CRM.Data.EjscriptTableInfo is Modified

* New items
  * Property `Includes`
  * Property `LastCompiled`
  * Property `SourceCode`
  * Property `SourceMaps`

#### SuperOffice.CRM.Data.MessageHandlerTableInfo is Modified

* Deleted items
  * Property `LeftOuterJoin_Message_SourceHandler`
  * Property `LeftOuterJoin_Message_TargetHandler`

#### SuperOffice.CRM.Data.MessageTableInfo is Modified

* Deleted items
  * Property `Description`
  * Property `DetailsRecord`
  * Property `DetailsTable`
  * Property `MessageType`
  * Property `MotherId`
  * Property `MotherId_InnerJoin_Message`
  * Property `SourceHandler`
  * Property `SourceHandler_InnerJoin_MessageHandler`
  * Property `TargetHandler`
  * Property `TargetHandler_InnerJoin_MessageHandler`
* New items
  * Property `AssociateId`
  * Property `AssociateId_InnerJoin_Associate`
  * Property `Expire`
  * Property `MarkdownMessage`
  * Property `OnlineappId`
  * Property `OnlineappId_InnerJoin_OnlineApp`
  * Property `SystemMessageId`
  * Property `Type`
  * Method `IdxAssociateId(Int32)`
  * Method `IdxAssociateIdSystemMessageId(Int32, String)`

#### SuperOffice.CRM.Data.OnlineAppTableInfo is Modified

* New items
  * Property `LeftOuterJoin_Message_OnlineappId`

#### SuperOffice.CRM.Data.TicketTypeTableInfo is Modified

* New items
  * Property `ReplyExternalAsDefault`
  * Property `ReplyForwardNoSignature`

#### SuperOffice.CRM.Documents.PhysicalDocument is Modified

* New items
  * Method `GetDatabaseLanguageCode()`
  * Method `GetDatabaseLanguageCulture()`

#### SuperOffice.CRM.Entities.Providers.PersonInfoProvider is Modified

* New items
  * Property `Business`
  * Property `Category`

#### SuperOffice.CRM.Entities.SaintRegenerator is Modified

* New items
  * Method `EnsureUdefs()`

#### SuperOffice.CRM.Globalization.CurrentPersonVariables is Modified

* Deleted items
  * Method `CurrentPersonVariables(IPersonInfo2)`
* New items
  * Property `Business`
  * Property `Category`
  * Method `CurrentPersonVariables(IPersonInfo4)`

#### SuperOffice.CRM.Globalization.PersonVariables is Modified

* Deleted items
  * Method `PersonVariables(IPersonInfo2)`
* New items
  * Method `PersonVariables(IPersonInfo4)`

#### SuperOffice.CRM.Globalization.SaleTags is Modified


#### SuperOffice.CRM.Globalization.SelectionTags is Modified


#### SuperOffice.CRM.Rows.EjscriptRecordData is Modified

* New items
  * Field `Includes`
  * Field `LastCompiled`
  * Field `SourceCode`
  * Field `SourceMaps`

#### SuperOffice.CRM.Rows.EjscriptRow is Modified

* New items
  * Property `Includes`
  * Property `LastCompiled`
  * Property `SourceCode`
  * Property `SourceMaps`

#### SuperOffice.CRM.Rows.MessageRecordData is Modified

* Deleted items
  * Field `Description`
  * Field `DetailsRecord`
  * Field `DetailsTable`
  * Field `MessageType`
  * Field `MotherId`
  * Field `SourceHandler`
  * Field `TargetHandler`
* New items
  * Field `AssociateId`
  * Field `Expire`
  * Field `MarkdownMessage`
  * Field `OnlineappId`
  * Field `SystemMessageId`
  * Field `Type`

#### SuperOffice.CRM.Rows.MessageRow is Modified

* Deleted items
  * Property `Description`
  * Property `DetailsRecord`
  * Property `DetailsTable`
  * Property `MessageType`
  * Property `MotherId`
  * Property `SourceHandler`
  * Property `TargetHandler`
* New items
  * Property `AssociateId`
  * Property `Expire`
  * Property `MarkdownMessage`
  * Property `OnlineappId`
  * Property `SystemMessageId`
  * Property `Type`
  * Method `GetFromIdxAssociateIdSystemMessageIdOnlineappId(Int32, String, Int32)`

##### SuperOffice.CRM.Rows.MessageRow.IdxAssociateIdSystemMessageIdOnlineappId is New

#### SuperOffice.CRM.Rows.MessageRows is Modified

* Deleted items
  * Method `GetFromIdxMotherId(Int32)`
  * Method `GetFromIdxSourceHandler(Int32)`
  * Method `GetFromIdxTargetHandler(Int32)`

##### SuperOffice.CRM.Rows.MessageRows.IdxMotherId is Deleted

##### SuperOffice.CRM.Rows.MessageRows.IdxSourceHandler is Deleted

##### SuperOffice.CRM.Rows.MessageRows.IdxTargetHandler is Deleted
* New items
  * Method `GetFromIdxAssociateId(Int32)`
  * Method `GetFromIdxAssociateIdSystemMessageId(Int32, String)`

##### SuperOffice.CRM.Rows.MessageRows.IdxAssociateId is New

##### SuperOffice.CRM.Rows.MessageRows.IdxAssociateIdSystemMessageId is New

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(DocumentHandler&, FieldInfo)`
  * Method `ValidateField(MailClient&, FieldInfo)`
  * Method `ValidateField(SystemMessageType&, FieldInfo)`

#### SuperOffice.CRM.Rows.TicketTypeRecordData is Modified

* New items
  * Field `ReplyExternalAsDefault`
  * Field `ReplyForwardNoSignature`

#### SuperOffice.CRM.Rows.TicketTypeRow is Modified

* New items
  * Property `ReplyExternalAsDefault`
  * Property `ReplyForwardNoSignature`

#### SuperOffice.CRM.Workflow.NotifyByEmailSettings is Modified

* Deleted items
  * Property `ShipmentId`

#### SuperOffice.CRM.Workflow.NotifyBySMSSettings is Modified

* Deleted items
  * Property `ShipmentId`

#### SuperOffice.CRM.Workflow.WorkflowStepRunScript is Modified

* New items
  * Method `ExecuteScriptAsEvent(Int32, EventData)`

#### SuperOffice.Data.SoftTrigger is Modified

* New items
  * Method `HasSubscribers(String)`


### Assembly: SuperOffice.Plugins

### New Types

* `SuperOffice.CRM.IPersonInfo4`

### Modified Types

#### SuperOffice.CRM.Documents.Constants is Modified

* Modified items

##### SuperOffice.CRM.Documents.Constants.Properties is Modified

* New items
  * Field `.PropertiesIsSafeFileExtension`



### Assembly: SoLicense

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.DocumentHandler`
* `SuperOffice.CD.Database.MailClient`
* `SuperOffice.CD.Database.SystemMessageType`
* `SuperOffice.CD.DSL.Database.CsTemplateResourceReader`
* `SuperOffice.CD.DSL.Database.ICsTemplateResourceReader`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_56_TicketType_reply_forward_no_signature`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_57_Ejscript_SourceCode`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_58_Ejscript_SourceCode`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_59_TicketType_reply_external_as_default`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_60_Ejscript_SourceMap`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_112_EjUser_Flags22`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_113_Message`

### Modified Types

#### SuperOffice.CD.Database.GeneratorEncoding is Modified

* New items
  * Field `MsWord2007`

#### SuperOffice.CD.DSL.Database.DocTemplateResourceReader is Modified

* Deleted items
  * Method `ReadDocTemplates(String)`
* New items
  * Method `ReadDocTemplate(String)`

#### SuperOffice.CD.DSL.Database.EventHandlerType is Modified

* New items
  * Field `SalesLoadCustomObject`

#### SuperOffice.CD.DSL.Database.IDocTemplateResourceReader is Modified

* Deleted items
  * Method `ReadDocTemplates(String)`
* New items
  * Method `ReadDocTemplate(String)`

#### SuperOffice.CD.DSL.Database.SuperOffice_111_UnsafeFileTypes_On_Group_Level is Modified

* New items
  * Field `DictionaryStepNumber`

#### SuperOffice.CD.DSL.Database.T_Ejscript is Modified

* New items
  * Field `Includes`
  * Field `LastCompiled`
  * Field `SourceCode`
  * Field `SourceMaps`

#### SuperOffice.CD.DSL.Database.T_Message is Modified

* Deleted items
  * Field `Description`
  * Field `DetailsRecord`
  * Field `DetailsTable`
  * Field `MessageType`
  * Field `MotherId`
  * Field `SourceHandler`
  * Field `TargetHandler`
* New items
  * Field `AssociateId`
  * Field `Expire`
  * Field `MarkdownMessage`
  * Field `OnlineappId`
  * Field `SystemMessageId`
  * Field `Type`

#### SuperOffice.CD.DSL.Database.T_TicketType is Modified

* New items
  * Field `ReplyExternalAsDefault`
  * Field `ReplyForwardNoSignature`



