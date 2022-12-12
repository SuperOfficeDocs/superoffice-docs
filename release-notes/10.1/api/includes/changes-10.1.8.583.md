<!-- markdownlint-disable-file MD041 MD024 MD013-->
## Changes from v10.1.6.812 to v10.1.8.583

### Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

#### Assembly: SuperOffice.Services

#### New Types

* `SuperOffice.CRM.Services.PreviewContact`
* `SuperOffice.CRM.Services.TicketBatchReplyData`

#### Modified Types

##### SuperOffice.CRM.Services.BatchAgent is Modified

* New items
  * Method `GetAllBatchTaskInfosByName(String)`
  * Method `GetAllBatchTaskInfosByNameAndState(String, BatchTaskState)`
  * Method `GetSystemBatchTaskInfosByName(String)`
  * Method `GetSystemBatchTaskInfosByNameAndState(String, BatchTaskState)`

##### SuperOffice.CRM.Services.ContactAgent is Modified

* New items
  * Method `CreateDefaultPreviewContact()`
  * Method `GetPreviewContact(Int32)`

##### SuperOffice.CRM.Services.CustomerServiceAgent is Modified

* New items
  * Method `GetUnparsedTemplate(Int32, Int32)`

##### SuperOffice.CRM.Services.EventData is Modified

* New items
  * Property `ShowDialog`

##### SuperOffice.CRM.Services.FavouriteAgent is Modified

* New items
  * Method `AddTicketsToFavouritesByProvider(String, ArchiveRestrictionInfo[], Int32, String)`
  * Method `RemoveFavourites(String, Int32[], Int32)`
  * Method `RemoveTicketsFromFavouritesByProvider(String, ArchiveRestrictionInfo[], Int32)`

##### SuperOffice.CRM.Services.FreeTextAgent is Modified

* New items
  * Method `FreetextIndexRows(String, Int32[])`

##### SuperOffice.CRM.Services.IBatchAgent is Modified

* New items
  * Method `GetAllBatchTaskInfosByName(String)`
  * Method `GetAllBatchTaskInfosByNameAndState(String, BatchTaskState)`
  * Method `GetSystemBatchTaskInfosByName(String)`
  * Method `GetSystemBatchTaskInfosByNameAndState(String, BatchTaskState)`

##### SuperOffice.CRM.Services.IContactAgent is Modified

* New items
  * Method `CreateDefaultPreviewContact()`
  * Method `GetPreviewContact(Int32)`

##### SuperOffice.CRM.Services.ICustomerServiceAgent is Modified

* New items
  * Method `GetUnparsedTemplate(Int32, Int32)`

##### SuperOffice.CRM.Services.IFavouriteAgent is Modified

* New items
  * Method `AddTicketsToFavouritesByProvider(String, ArchiveRestrictionInfo[], Int32, String)`
  * Method `RemoveFavourites(String, Int32[], Int32)`
  * Method `RemoveTicketsFromFavouritesByProvider(String, ArchiveRestrictionInfo[], Int32)`

##### SuperOffice.CRM.Services.IFreeTextAgent is Modified

* New items
  * Method `FreetextIndexRows(String, Int32[])`

##### SuperOffice.CRM.Services.ITargetsAgent is Modified

* New items
  * Method `CreateDefaultTargetAssignmentForCompanyWithYearAndDimension(Int32, Int32)`
  * Method `CreateDefaultTargetAssignmentForUserGroupWithYearAndDimension(Int32, Int32, Int32)`

##### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `BatchForward(Int32[], String[], String[], String[], String, Boolean)`
  * Method `BatchReply(TicketBatchReplyData)`
  * Method `DeleteMessageHeaders(Int32[])`
  * Method `MergeTickets(TicketEntity, Int32[])`
  * Method `RemoveMessageAttachments(Int32, Int32[])`
  * Method `ResolveTicketId(Int32)`
  * Method `SetDeletedStatusByIds(Int32[])`
  * Method `SetDeletedStatusByProvider(String, ArchiveRestrictionInfo[])`
  * Method `SplitTicket(Int32, Int32[], TicketEntity)`
  * Method `SplitTicketMessage(TicketMessageEntity, TicketEntity, TicketMessageEntity, Int32[])`
  * Method `UpdateTicketsReadStatus(Int32[], TicketReadStatus)`
  * Method `UpdateTicketsReadStatusByProvider(String, ArchiveRestrictionInfo[], TicketReadStatus)`

##### SuperOffice.CRM.Services.TargetAssignment is Modified

* New items
  * Property `DimensionListItemDisplayName`

##### SuperOffice.CRM.Services.TargetsAgent is Modified

* New items
  * Method `CreateDefaultTargetAssignmentForCompanyWithYearAndDimension(Int32, Int32)`
  * Method `CreateDefaultTargetAssignmentForUserGroupWithYearAndDimension(Int32, Int32, Int32)`

##### SuperOffice.CRM.Services.TemplateVariablesParameters is Modified

* New items
  * Property `TicketId`

##### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `BatchForward(Int32[], String[], String[], String[], String, Boolean)`
  * Method `BatchReply(TicketBatchReplyData)`
  * Method `DeleteMessageHeaders(Int32[])`
  * Method `MergeTickets(TicketEntity, Int32[])`
  * Method `RemoveMessageAttachments(Int32, Int32[])`
  * Method `ResolveTicketId(Int32)`
  * Method `SetDeletedStatusByIds(Int32[])`
  * Method `SetDeletedStatusByProvider(String, ArchiveRestrictionInfo[])`
  * Method `SplitTicket(Int32, Int32[], TicketEntity)`
  * Method `SplitTicketMessage(TicketMessageEntity, TicketEntity, TicketMessageEntity, Int32[])`
  * Method `UpdateTicketsReadStatus(Int32[], TicketReadStatus)`
  * Method `UpdateTicketsReadStatusByProvider(String, ArchiveRestrictionInfo[], TicketReadStatus)`

##### SuperOffice.CRM.Services.TicketCategoryEntity is Modified

* New items
  * Property `EffectiveReplyTemplateId`

##### SuperOffice.CRM.Services.TicketEntity is Modified

* New items
  * Property `FirstReadByOwner`

##### SuperOffice.CRM.Services.TicketMessageHeader is Modified

* New items
  * Property `Id`

### NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

#### Assembly: SoCore

#### New Types

* `SuperOffice.Data.TicketPriorityEscalateAction`

#### Modified Types

##### .IEnumerableExtensions is Modified

* Deleted items
  * Method `ForEach<T>(IEnumerable<T>, Action<T>)`

##### .StringExtensions is Modified

* New items
  * Method `ToXmlSafe(String)`

##### SuperOffice.Data.ChatMessageSpecialType is Modified

* New items
  * Field `IllegalFileType`

##### SuperOffice.Data.EventHandlerType is Modified

* New items
  * Field `SalesAfterSaveTicket`
  * Field `SalesBeforeSaveTicket`

##### SuperOffice.Data.Navigation is Modified

* New items
  * Field `TicketCard`

##### SuperOffice.Data.NotificationEventType is Modified

* New items
  * Field `AppointmentDeclined`

##### SuperOffice.Exceptions.SoException is Modified

* New items
  * Method `SoException(String, String, Boolean)`

##### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_PD_DataMirroring_BatchSize_DESC`
  * Field `SR_PD_DataMirroring_BatchSize_NAME`
  * Field `SR_PD_DataMirroring_DESC`
  * Field `SR_PD_DataMirroring_ExcludeTables_DESC`
  * Field `SR_PD_DataMirroring_ExcludeTables_NAME`
  * Field `SR_PD_DataMirroring_NAME`
  * Field `SR_PREF_Functions_ShowDateTimeComponent_NAME`
  * Field `SR_TARGETS_INCREASE_BY`
* New items
  * Field `SR_ADMIN_LIST_SHOW_TICKETCARD`
  * Field `SR_ARCHIVE_DELETE_ALL_REQUESTS`
  * Field `SR_ARCHIVE_DELETE_ALL_REQUESTS_CONFIRMATION`
  * Field `SR_ARCHIVE_DELETE_PERMANENTLY`
  * Field `SR_ARCHIVE_DELETE_SELECTED_REQUESTS_CONFIRMATION`
  * Field `SR_BULKUPDATE_ACTION_CLOSE_REQUEST_AFTER_FORWARD`
  * Field `SR_BULKUPDATE_FORWARD`
  * Field `SR_BULKUPDATE_FORWARD_NO_EXTERNAL_REQUESTS_SELECTED`
  * Field `SR_BULKUPDATE_REPLY_TO_CUSTOMERS`
  * Field `SR_BUTT_COPY_URL`
  * Field `SR_CHATWIDGET_SEND_ERROR`
  * Field `SR_CHATWIDGET_SEND_ERROR_FILE`
  * Field `SR_CONFIGSCREEN_GRID_CAPTION`
  * Field `SR_CONFIGSCREEN_GRID_STYLE`
  * Field `SR_CONFIGSCREEN_GRID_STYLE_LINES`
  * Field `SR_CONFIGSCREEN_GRID_STYLE_NONE`
  * Field `SR_CONFIGSCREEN_GRID_STYLE_WITH_HEADER`
  * Field `SR_CONFIGSCREEN_MAXWIDTH`
  * Field `SR_DASHBOARD_CREATE_NEW_DASHBOARD`
  * Field `SR_DASHBOARD_MEASURE_AVERAGE_TOOLTIP`
  * Field `SR_DASHBOARD_MEASURE_COUNT_TOOLTIP`
  * Field `SR_DASHBOARD_MEASURE_MAX_TOOLTIP`
  * Field `SR_DASHBOARD_MEASURE_MIN_TOOLTIP`
  * Field `SR_DASHBOARD_MEASURE_SUM_TOOLTIP`
  * Field `SR_DASHBOARD_TARGET_SALE_COUNT`
  * Field `SR_DASHTILE_CHA_AVERAGE_TIME_IN_QUEUE_THIS_MONTH`
  * Field `SR_DOCUMENT_EMAILADDRESSBOOK`
  * Field `SR_DOCUMENT_EXTERNALDOCUMENT`
  * Field `SR_DOCUMENT_FAQ`
  * Field `SR_DOCUMENT_REPLYTEMPLATES`
  * Field `SR_FAVOURITE_REMOVEENTITY`
  * Field `SR_MAIN_PROJECT_NOPROJECTS_AND_CANNOTCREATE`
  * Field `SR_MENU_KNOWLEDGEBASE`
  * Field `SR_MESSAGESPLIT_EDIT_TITLE`
  * Field `SR_MESSAGESPLIT_INCLUDE_ATTACHMENTS`
  * Field `SR_PD_Mirroring_BatchSize_DESC`
  * Field `SR_PD_Mirroring_BatchSize_NAME`
  * Field `SR_PD_Mirroring_DESC`
  * Field `SR_PD_Mirroring_NAME`
  * Field `SR_PD_Mirroring_SkipTable_DESC`
  * Field `SR_PD_Mirroring_SkipTable_NAME`
  * Field `SR_POCKET_SCAN_QRCODE_10`
  * Field `SR_QUOTE_NONE_DEFINED`
  * Field `SR_TARGETS_ADJUST_BY`
  * Field `SR_TARGETS_CLIPBOARD_NEED_PERMISSION`
  * Field `SR_TARGETS_CONFIRM_DELETE_TARGET`
  * Field `SR_TARGETS_CONFIRM_REMOVE_ASSOCIATE_LEVEL`
  * Field `SR_TARGETS_CONFIRM_REMOVE_DIMENSION`
  * Field `SR_TARGETS_COPY_ROW`
  * Field `SR_TARGETS_FROM_ALL_SALES_TOOLTIPS`
  * Field `SR_TARGETS_PASTE_ROWS`
  * Field `SR_TICKET_ACTION_MERGE_REQUESTS`
  * Field `SR_TICKET_ACTION_SPLIT_REQUEST`
  * Field `SR_TICKET_ERROR_MERGED`
  * Field `SR_TICKET_MESSAGE_DELETE_SURE`
  * Field `SR_TICKET_SUGGESTED_CATEGORY`
  * Field `SR_TICKET_UNASSIGNED`
  * Field `SR_TICKETMERGE_BTN_MERGE`
  * Field `SR_TICKETMERGE_CUSTOMERS_WARNING`
  * Field `SR_TICKETMERGE_MERGE_INTO`
  * Field `SR_TICKETMERGE_MERGE_REQUESTS`
  * Field `SR_TICKETMERGE_MESSAGES_WARNING`
  * Field `SR_TICKETMERGE_PREVIEW`
  * Field `SR_TICKETSPLIT_HIDE_ATTACHMENTS`
  * Field `SR_TICKETSPLIT_MOVE_MESSAGES`
  * Field `SR_TICKETSPLIT_TABPROPERTIES`
  * Field `SR_TICKETSPLIT_VIEW_ATTACHMENTS`

##### SuperOffice.Util.AssemblyHelper is Modified

##### SuperOffice.WebApi.IOnlineAppRequestInfo is Modified

* New items
  * Property `ContextIdentifier`

##### SuperOffice.WebApi.OnlineAppRequestInfo is Modified

* New items
  * Property `ContextIdentifier`

#### Assembly: SoDatabase

#### Deleted Types

* `SuperOffice.Security.Principal.SoWindowsIdentity`
* `SuperOffice.Security.Principal.WindowsIdentityResolver`
* `SuperOffice.Security.Principal.WindowsIdentityValidator`
* `SuperOffice.Security.Principal.WindowsOtherIdentityResolver`
* `SuperOffice.Security.Principal.WindowsPersonIdentityResolver`

#### New Types

* `SuperOffice.CRM.ArchiveLists.ExactKeyMatchCalculator`
* `SuperOffice.CRM.ArchiveLists.FreetextTicketResultProvider`
* `SuperOffice.CRM.ArchiveLists.UdefRetryState`
* `SuperOffice.CRM.AttachmentHelper`
* `SuperOffice.CRM.FacadeHelper`
* `SuperOffice.CRM.Lists.IgnoreGroupingAndHeadingsForAdminMdoProviderBase`
* `SuperOffice.CRM.Lists.TargetEntityTypeProvider`
* `SuperOffice.CRM.Lists.TargetMeasurementUnitProvider`
* `SuperOffice.CRM.Rows.Implementation.EjMessageRowImplementation`
* `SuperOffice.CRM.Rows.Implementation.TicketRowImplementation`
* `SuperOffice.CRM.TicketMessage.TicketMessageHelper`

#### Modified Types

##### SuperOffice.CRM.ArchiveLists.ArchiveProviderFactory is Modified

* Modified items

###### SuperOffice.CRM.ArchiveLists.ArchiveProviderFactory.ArchiveProviderCache is Modified

* Modified items
  * Property `.ArchiveProviderCacheEntityColumnInfo`

##### SuperOffice.CRM.ArchiveLists.QuoteApprovalProvider is Modified

##### SuperOffice.CRM.ArchiveLists.TargetValueExtenderBase is Modified

* Deleted items

##### SuperOffice.CRM.ArchiveLists.UdefExtenderBase is Modified

##### SuperOffice.CRM.Globalization.SystemTags is Modified

* Deleted items
  * Method `SystemTags()`
* New items
  * Method `SystemTags(Int32)`

##### SuperOffice.CRM.Globalization.TemplateVariableIds is Modified

* New items
  * Field `TicketId`

##### SuperOffice.CRM.Globalization.TemplateVariables is Modified

* New items
  * Property `TicketId`

##### SuperOffice.CRM.Lists.ServiceAssociateMDOProvider is Modified

* Deleted items
  * Field `IncludeHistory`

##### SuperOffice.CRM.Lists.TargetTypeProvider is Modified

* Deleted items
  * Method `FieldNameToProviderColName(String)`
  * Method `ProviderColNameToDbColName(String)`
* New items
  * Field `c_includeInvalid`
  * Method `FieldToProviderColName(FieldInfo)`
  * Method `IsUnique(TargetEntityType, TargetMeasurementUnit, String, Int32)`
  * Method `ProviderColNameToField(TargetEntityType, String)`
  * Method `ProviderColumnToListInfo(TargetEntityType, String)`

##### SuperOffice.CRM.Notification.NotificationEventHandler is Modified

* Deleted items
  * Method `NotifyUsers(NotificationEventType, Int32, DateTime, IEnumerable<Int32>)`
* New items
  * Method `NotifyUsers(NotificationEventType, Int32, DateTime, IEnumerable<Int32>, Dictionary<String, String>)`

##### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(TicketPriorityEscalateAction&, FieldInfo)`

##### SuperOffice.CRM.Rows.TableRowBase is Modified

##### SuperOffice.CRM.Security.EjCategoryCache is Modified

* New items
  * Method `GetEffectiveReplyTemplateId(Int32)`

##### SuperOffice.CRM.Security.TicketSentry is Modified

* New items
  * Method `ComputeDerivedTableRights()`

##### SuperOffice.CRM.Ticket.TicketHelper is Modified

* New items
  * Method `HasUpdateRight(Int32, Int32, Int32)`
  * Method `ResolveTicketId(Int32)`

##### SuperOffice.Data.Dialect.OracleCommon is Modified

* New items
  * Method `ToSql(JsonValue)`

##### SuperOffice.Data.Private.FreetextIndexerLogic is Modified

* New items
  * Method `IndexSpecificRows(String, Int32[], ProgressCallback)`

##### SuperOffice.Data.S is Modified

* New items
  * Method `NewSelect<MainTableInfo>(TableInfo, Func<MainTableInfo, Restriction>)`

##### SuperOffice.Data.ServicePreferenceMappings is Modified

* New items
  * Method `AttachmentPathDecoder(String, String)`

##### SuperOffice.License.LicenseManager is Modified

* New items
  * Method `ToInfo(ModuleLicense)`

#### Assembly: SuperOffice.Plugins

#### Modified Types

##### SuperOffice.Factory.AssemblyHelper is Modified

#### Assembly: SoLicense

#### Modified Types

##### SuperOffice.License.SignatureValidator is Modified

* Modified items
  * Method `ComputeHash(String, String, ModuleLicense)`

### Continuous Database

The following represent changes to SuperOffice database schema.

#### Assembly: SuperOffice.CD.DSL.Database

#### New Types

* `SuperOffice.CD.DSL.Database.SuperOffice_90_ResetTagsFiltering`
* `SuperOffice.CD.DSL.Database.TicketPriorityEscalateAction`

#### Modified Types

##### SuperOffice.CD.Database.Navigation is Modified

* New items
  * Field `TicketCard`

##### SuperOffice.CD.Database.NotificationEventType is Modified

* New items
  * Field `AppointmentDeclined`

##### SuperOffice.CD.DSL.Database.EventHandlerType is Modified

* New items
  * Field `SalesAfterSaveTicket`
  * Field `SalesBeforeSaveTicket`
