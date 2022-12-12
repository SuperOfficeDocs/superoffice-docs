<!-- markdownlint-disable-file MD041 MD024 MD013-->
## Changes from v10.1.2.1565 to v10.1.5.2031

### Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

#### Assembly: SuperOffice.Services

#### New Types

* `SuperOffice.CRM.Services.DocumentMigrationAssociate`
* `SuperOffice.CRM.Services.DocumentTemplateMigrationList`
* `SuperOffice.CRM.Services.PreviewDash`
* `SuperOffice.CRM.Services.PreviewDashTile`
* `SuperOffice.CRM.Services.PreviewFaqEntry`
* `SuperOffice.CRM.Services.PreviewQuickReply`
* `SuperOffice.CRM.Services.PreviewReplyTemplate`
* `SuperOffice.CRM.Services.QuoteApproveReason`
* `SuperOffice.CRM.Services.QuoteDenyReason`
* `SuperOffice.CRM.Services.Recipient`
* `SuperOffice.CRM.Services.TargetDimension`

#### Modified Types

##### SuperOffice.CRM.Services.ActivitySummaryItem is Modified

* Modified items
  * Property `Date`
  * Property `Registered`

##### SuperOffice.CRM.Services.AlarmData is Modified

* Modified items
  * Property `EndDate`
  * Property `StartTime`

##### SuperOffice.CRM.Services.Appointment is Modified

* Modified items
  * Property `ActiveDate`
  * Property `EndDate`
  * Property `StartDate`

##### SuperOffice.CRM.Services.AppointmentEntity is Modified

* Modified items
  * Property `ActiveDate`
  * Property `CreatedDate`
  * Property `EndDate`
  * Property `StartDate`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.AppointmentSyncData is Modified

* Modified items
  * Property `EndDate`
  * Property `StartDate`

##### SuperOffice.CRM.Services.AudienceConfigParameter is Modified

* Modified items
  * Property `CreatedDate`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.AudienceLayoutEntity is Modified

* Modified items
  * Property `CreatedDate`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.BlobEntity is Modified

* Modified items
  * Property `CreatedDate`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.ChatMessage is Modified

* Modified items
  * Property `WhenPosted`

##### SuperOffice.CRM.Services.ChatSessionEntity is Modified

* Modified items
  * Property `WhenEnded`
  * Property `WhenFetched`
  * Property `WhenIdle`
  * Property `WhenRequested`
  * Property `WhenStarted`

##### SuperOffice.CRM.Services.ChatSummaryItem is Modified

* Modified items
  * Property `WhenEnded`
  * Property `WhenRequested`

##### SuperOffice.CRM.Services.ChatTopicEntity is Modified

* Modified items
  * Property `LastAccept`

##### SuperOffice.CRM.Services.ChatWidgetSettings is Modified

* New items
  * Property `AgentMsgColor`
  * Property `AgentMsgTextColor`
  * Property `BadgeColor`
  * Property `BadgeTextColor`
  * Property `ButtonColor`
  * Property `ButtonTextColor`
  * Property `CustMsgColor`
  * Property `CustMsgTextColor`
  * Property `FontSize`

##### SuperOffice.CRM.Services.ConsentInfo is Modified

* Modified items
  * Property `Registered`
  * Property `Updated`

##### SuperOffice.CRM.Services.ConsentPurpose is Modified

* Modified items
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.ContactEntity is Modified

* Modified items
  * Property `CreatedDate`
  * Property `DbiLastModified`
  * Property `DbiLastSyncronized`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.ContactRelationEntity is Modified

* Modified items
  * Property `CreatedDate`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.CRMScriptEntity is Modified

* Modified items
  * Property `Registered`
  * Property `Updated`

##### SuperOffice.CRM.Services.CustomerCenterConfig is Modified

* Modified items
  * Property `Registered`
  * Property `Updated`

##### SuperOffice.CRM.Services.CustomerServiceAgent is Modified

* New items
  * Method `GetPreviewFaqEntry(Int32)`
  * Method `GetPreviewQuickReply(Int32)`
  * Method `GetPreviewReplyTemplate(Int32)`

##### SuperOffice.CRM.Services.DashAgent is Modified

* New items
  * Method `CreateDefaultPreviewDash()`
  * Method `CreateDefaultPreviewDashTile()`
  * Method `GetPreviewDash(Int32)`

##### SuperOffice.CRM.Services.DocumentEntity is Modified

* Modified items
  * Property `CreatedDate`
  * Property `Date`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.DocumentMigrationAgent is Modified

* New items
  * Method `CreateDefaultDocumentTemplateMigrationList()`
  * Method `GetForTemplates(Int32, Boolean)`
  * Method `MigrateTemplateToNewDocPlugin(Int32, Int32)`

##### SuperOffice.CRM.Services.DocumentMigrationItemList is Modified

* Modified items
  * Property `Documents`
* New items
  * Property `Associates`

##### SuperOffice.CRM.Services.EMailAgent is Modified

* New items
  * Method `GetExtendedEmailMessageIds(EMailConnectionInfoExtended)`

##### SuperOffice.CRM.Services.EMailEntity is Modified

* Modified items
  * Property `ReceivedAt`

##### SuperOffice.CRM.Services.ErpSyncAgent is Modified

* New items
  * Method `GetAllConnections(Boolean)`
  * Method `GetAllConnectors()`

##### SuperOffice.CRM.Services.ForeignAppEntity is Modified

* Modified items
  * Property `CreatedDate`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.ForeignDevice is Modified

* Modified items
  * Property `CreatedDate`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.ForeignKey is Modified

* Modified items
  * Property `CreatedDate`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.FormEntity is Modified

* Modified items
  * Property `Expires`
  * Property `Registered`
  * Property `Updated`

##### SuperOffice.CRM.Services.FormSubmissionEntity is Modified

* Modified items
  * Property `WhenSubmitted`

##### SuperOffice.CRM.Services.HierarchyEntity is Modified

* Modified items
  * Property `Registered`
  * Property `Updated`

##### SuperOffice.CRM.Services.ICustomerServiceAgent is Modified

* New items
  * Method `GetPreviewFaqEntry(Int32)`
  * Method `GetPreviewQuickReply(Int32)`
  * Method `GetPreviewReplyTemplate(Int32)`

##### SuperOffice.CRM.Services.IDashAgent is Modified

* New items
  * Method `CreateDefaultPreviewDash()`
  * Method `CreateDefaultPreviewDashTile()`
  * Method `GetPreviewDash(Int32)`

##### SuperOffice.CRM.Services.IDocumentMigrationAgent is Modified

* New items
  * Method `CreateDefaultDocumentTemplateMigrationList()`
  * Method `GetForTemplates(Int32, Boolean)`
  * Method `MigrateTemplateToNewDocPlugin(Int32, Int32)`

##### SuperOffice.CRM.Services.IEMailAgent is Modified

* New items
  * Method `GetExtendedEmailMessageIds(EMailConnectionInfoExtended)`

##### SuperOffice.CRM.Services.IErpSyncAgent is Modified

* New items
  * Method `GetAllConnections(Boolean)`
  * Method `GetAllConnectors()`

##### SuperOffice.CRM.Services.IListAgent is Modified

* New items
  * Method `GetQuoteApproveReason(Int32)`
  * Method `GetQuoteApproveReasonList(Int32[])`
  * Method `GetQuoteApproveReasons()`
  * Method `GetQuoteDenyReason(Int32)`
  * Method `GetQuoteDenyReasonList(Int32[])`
  * Method `GetQuoteDenyReasons()`

##### SuperOffice.CRM.Services.IQuoteAgent is Modified

* New items
  * Method `CancelApprovalRequest(Int32)`
  * Method `RequestApproval(Int32, Int32, String)`

##### SuperOffice.CRM.Services.ITargetsAgent is Modified

* New items
  * Method `CreateDefaultTargetDimension()`
  * Method `DeleteTargetDimension(Int32)`
  * Method `GetTargetDimension(Int32)`
  * Method `GetTargetDimensionsForEntityType(TargetEntityType)`
  * Method `GetTargetGroupIds(Int32)`
  * Method `SaveTargetDimension(TargetDimension)`

##### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `CalculateMessageRecipients(Int32, MessageActionType, Int32)`
  * Method `GetDefaultMessageContent(Int32, MessageActionType, Int32)`
  * Method `GetTicketMessageWithEmbeddedData(Int32, ImageEmbedType)`

##### SuperOffice.CRM.Services.ListAgent is Modified

* New items
  * Method `GetQuoteApproveReason(Int32)`
  * Method `GetQuoteApproveReasonList(Int32[])`
  * Method `GetQuoteApproveReasons()`
  * Method `GetQuoteDenyReason(Int32)`
  * Method `GetQuoteDenyReasonList(Int32[])`
  * Method `GetQuoteDenyReasons()`

##### SuperOffice.CRM.Services.PersonEntity is Modified

* Modified items
  * Property `BirthDate`
  * Property `CreatedDate`
  * Property `DbiLastModified`
  * Property `DbiLastSyncronized`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.PreviewMailing is Modified

* Modified items
  * Property `SendingTime`

##### SuperOffice.CRM.Services.PreviewMailingHeader is Modified

* Modified items
  * Property `StartDate`

##### SuperOffice.CRM.Services.PriceList is Modified

* Modified items
  * Property `ValidFrom`
  * Property `ValidTo`

##### SuperOffice.CRM.Services.Project is Modified

* Modified items
  * Property `PublishFrom`
  * Property `PublishTo`
  * Property `Updated`

##### SuperOffice.CRM.Services.ProjectEntity is Modified

* Modified items
  * Property `CreatedDate`
  * Property `EndDate`
  * Property `NextMilestoneDate`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.ProjectEvent is Modified

* Modified items
  * Property `EventDate`

##### SuperOffice.CRM.Services.ProjectEventEntity is Modified

* Modified items
  * Property `CreatedDate`
  * Property `EventDate`
  * Property `PublishFrom`
  * Property `PublishTo`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.QuoteAgent is Modified

* New items
  * Method `CancelApprovalRequest(Int32)`
  * Method `RequestApproval(Int32, Int32, String)`

##### SuperOffice.CRM.Services.QuoteLine is Modified

* Modified items
  * Property `SubscriptionStart`

##### SuperOffice.CRM.Services.QuoteVersion is Modified

* Modified items
  * Property `ApprovedRegisteredDate`
  * Property `ExpirationDate`
  * Property `LastRecalculated`
  * Property `Registered`
  * Property `SentDate`
  * Property `Updated`
* New items
  * Property `RequestAssociateId`
  * Property `RequestComment`

##### SuperOffice.CRM.Services.RoleEntity is Modified

* Modified items
  * Property `Created`
  * Property `Updated`

##### SuperOffice.CRM.Services.SaintConfiguration is Modified

* Modified items
  * Property `GenerationEnd`
  * Property `GenerationStart`

##### SuperOffice.CRM.Services.Sale is Modified

* Modified items
  * Property `NextDueDate`
  * Property `SaleDate`

##### SuperOffice.CRM.Services.SaleEntity is Modified

* Modified items
  * Property `CreatedDate`
  * Property `NextDueDate`
  * Property `ReopenDate`
  * Property `Saledate`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.SaleSummaryItem is Modified

* Modified items
  * Property `Registered`
  * Property `SaleDate`

##### SuperOffice.CRM.Services.Satellite is Modified

* Modified items
  * Property `Created`
  * Property `Updated`

##### SuperOffice.CRM.Services.Script is Modified

* Modified items
  * Property `Registered`
  * Property `Updated`

##### SuperOffice.CRM.Services.SelectionEntity is Modified

* Modified items
  * Property `CreatedDate`
  * Property `LastLoaded`
  * Property `LastMembershipChange`
  * Property `UpdatedDate`

##### SuperOffice.CRM.Services.SelectionSummaryItem is Modified

* Modified items
  * Property `Registered`

##### SuperOffice.CRM.Services.ShipmentMessageBlockEntity is Modified

* Modified items
  * Property `Registered`
  * Property `Updated`

##### SuperOffice.CRM.Services.ShipmentMessageEntity is Modified

* Modified items
  * Property `Registered`
  * Property `Updated`

##### SuperOffice.CRM.Services.StatusMonitor is Modified

* Modified items
  * Property `GenerationStart`

##### SuperOffice.CRM.Services.SystemEventEntity is Modified

* Modified items
  * Property `Eta`
  * Property `Registered`

##### SuperOffice.CRM.Services.TargetAssignment is Modified

* New items
  * Property `DimensionListItem`

##### SuperOffice.CRM.Services.TargetGroup is Modified

* New items
  * Property `TargetDimension`

##### SuperOffice.CRM.Services.TargetRevision is Modified

* Modified items
  * Property `When`

##### SuperOffice.CRM.Services.TargetsAgent is Modified

* New items
  * Method `CreateDefaultTargetDimension()`
  * Method `DeleteTargetDimension(Int32)`
  * Method `GetTargetDimension(Int32)`
  * Method `GetTargetDimensionsForEntityType(TargetEntityType)`
  * Method `GetTargetGroupIds(Int32)`
  * Method `SaveTargetDimension(TargetDimension)`

##### SuperOffice.CRM.Services.Ticket is Modified

* Modified items
  * Property `Activate`
  * Property `AlertTimeout`
  * Property `ClosedAt`
  * Property `CreatedAt`
  * Property `Deadline`
  * Property `FirstReadByUser`
  * Property `LastChanged`
  * Property `ReadByCustomer`
  * Property `ReadByOwner`
  * Property `RepliedAt`

##### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `CalculateMessageRecipients(Int32, MessageActionType, Int32)`
  * Method `GetDefaultMessageContent(Int32, MessageActionType, Int32)`
  * Method `GetTicketMessageWithEmbeddedData(Int32, ImageEmbedType)`

##### SuperOffice.CRM.Services.TicketEntity is Modified

* Modified items
  * Property `Activate`
  * Property `AlertTimeout`
  * Property `ClosedAt`
  * Property `CreatedAt`
  * Property `Deadline`
  * Property `FirstReadByUser`
  * Property `LastChanged`
  * Property `ReadByCustomer`
  * Property `ReadByOwner`
  * Property `RepliedAt`
* New items
  * Property `IconHint`
  * Property `OrigHumanCategoryId`
  * Property `SuggestedCategoryId`
  * Property `SuggestedCategoryName`

##### SuperOffice.CRM.Services.TicketMessage is Modified

* Modified items
  * Property `CreatedAt`

##### SuperOffice.CRM.Services.TicketMessageEntity is Modified

* Modified items
  * Property `CreatedAt`

##### SuperOffice.CRM.Services.TicketMessageHeader is Modified

* New items
  * Property `StdItem`
  * Property `StdItemCol`

##### SuperOffice.CRM.Services.TicketPriorityEntity is Modified

* Modified items
  * Property `FriStart`
  * Property `FriStop`
  * Property `MonStart`
  * Property `MonStop`
  * Property `NonDates`
  * Property `SatStart`
  * Property `SatStop`
  * Property `SunStart`
  * Property `SunStop`
  * Property `ThuStart`
  * Property `ThuStop`
  * Property `TueStart`
  * Property `TueStop`
  * Property `WedStart`
  * Property `WedStop`

##### SuperOffice.CRM.Services.TicketSummaryItem is Modified

* Modified items
  * Property `Registered`
* New items
  * Property `IconHint`

##### SuperOffice.CRM.Services.TriggerScriptEntity is Modified

* Modified items
  * Property `Registered`
  * Property `Updated`

##### SuperOffice.CRM.Services.User is Modified

* Modified items
  * Property `Lastlogin`
  * Property `Lastlogout`

##### SuperOffice.CRM.Services.WebAppUsage is Modified

* Modified items
  * Property `Timestamp`

##### SuperOffice.CRM.Services.Webhook is Modified

* Modified items
  * Property `Registered`
  * Property `Updated`

##### SuperOffice.CRM.Services.WebPanelEntity is Modified

* New items
  * Property `AlwaysReloadOnShow`

### NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

#### Assembly: SoCore

#### Deleted Types

* `SuperOffice.Security.Principal.CurrentWindowsTokenSupplier`
* `SuperOffice.Security.Principal.OidcSecurityToken`
* `SuperOffice.Security.Principal.SoAccessTokenSecurityToken`
* `SuperOffice.Security.Principal.SoCredentialsSecurityTokenProvider`
* `SuperOffice.Security.Principal.SoIdentity`
* `SuperOffice.Security.Principal.SoImpersonationSecurityToken`
* `SuperOffice.Security.Principal.UsernamePasswordWindowsTokenSupplier`

#### New Types

* `SoCore.Shared.CRM.Services.TimeZoneHintAttribute`
* `SoCore.Shared.CRM.Services.TimeZoneInterpretation`
* `SuperOffice.Data.ImageEmbedType`
* `SuperOffice.Data.MessageActionType`
* `SuperOffice.Data.MessageHeaderStdItem`
* `SuperOffice.Data.MessageHeaderStdItemCol`
* `SuperOffice.Data.RecipientType`
* `SuperOffice.Data.TargetAssignementLevel`
* `SuperOffice.Data.TargetMeasurementUnit`
* `SuperOffice.Exceptions.DirectInvokeAjaxServiceException`
* `SuperOffice.Exceptions.SoConsentException`
* `SuperOffice.Factory.SoServiceProviderScope`
* `SuperOffice.Security.Claims.ClaimsIdentityHelper`
* `SuperOffice.Security.Claims.SoTokenType`
* `SuperOffice.Security.Principal.CurrentWindowsIdentitySupplier`
* `SuperOffice.Util.SoDocumentPlugin`
* `SuperOffice.Util.StructurePatchingHelper`
* `SuperOffice.WebApi.IOnlineAppRequestInfo`
* `SuperOffice.WebApi.OnlineAppRequestInfo`
* `SuperOffice.WebApi.PartnerAppRequestInfo`
* `System.Linq.SupportForNetstandard2_0.LinqExtensions`

#### Modified Types

##### Microsoft.Extensions.DependencyInjection.NetServerCoreOptionsBuilder is Modified

* Deleted items
  * Method `AddTokenSupplier<TTokenSuplier>()`
* New items
  * Method `AddImplicitIdentitySupplier<TTokenSuplier>()`

##### SuperOffice.Configuration.ConfigFile is Modified

* New items
  * Method `ForceOverrideIsOnline(Boolean)`

##### SuperOffice.CRM.ArchiveLists.ArchiveRow is Modified

* New items
  * Method `Clone()`

##### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

###### SuperOffice.CRM.ArchiveLists.Constants.IconHints is Modified

* New items
  * Field `.IconHintsPerson_Relation`

##### SuperOffice.CRM.Rows.ContactCode is Modified

* Deleted items
  * Method `IsCharAlpha(Char)`
  * Method `IsCharAlphaNumeric(Char)`
  * Method `IsCharLower(Char)`
  * Method `IsCharNumeric(Char)`
  * Method `IsCharUpper(Char)`

##### SuperOffice.Data.NotificationEventType is Modified

* Deleted items
  * Field `SaleApprovalApproved`
  * Field `SaleApprovalDenied`
  * Field `SaleApprovalRequest`
* New items
  * Field `QuoteApprovalApproved`
  * Field `QuoteApprovalDenied`
  * Field `QuoteApprovalRequest`

##### SuperOffice.Data.ReplyTemplateBodyFlags is Modified

* New items
  * Field `ReplyTemplateBodyNone`

##### SuperOffice.Data.TargetEntityType is Modified

* Deleted items
  * Field `SaleAmount`
* New items
  * Field `Sale`

##### SuperOffice.Data.TicketBaseStatus is Modified

* New items
  * Field `Postponed1Hour`
  * Field `Postponed2Hours`
  * Field `Postponed3Hours`
  * Field `Postponed4Hours`
  * Field `PostponedDay`
  * Field `PostponedMonth`
  * Field `PostponedSpecific`
  * Field `PostponedWeek`

##### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_ADMIN_EJDISPLAYNAME`
  * Field `SR_ADMIN_EJDISPLAYNAME_TOOLTIP`
  * Field `SR_ADMIN_EJGROUP`
  * Field `SR_ADMIN_EJGROUP_TOOLTIP`
  * Field `SR_ADMIN_EJSTATUS`
  * Field `SR_ADMIN_EJSTATUS_TOOLTIP`
  * Field `SR_ADMIN_EJUSERID`
  * Field `SR_ADMIN_EJUSERID_TOOLTIP`
  * Field `SR_ADMIN_SIMEJUSER`
  * Field `SR_ARCHIVE_EJTICKET`
  * Field `SR_ARCHIVES_EJTICKET`
  * Field `SR_MAIN_EJOURNAL_NAVIGATOR`
  * Field `SR_TARGETS_SALE_TITLE`
  * Field `SR_USER_HAS_OPEN_TICKETS`
  * Field `SR_USER_IS_CATEGORY_MASTER`
  * Field `SR_USER_IS_IN_EMAIL_FILTER`
* New items
  * Field `SECURITY_FUNC_TARGETSADMINISTRATOR_DESC`
  * Field `SECURITY_FUNC_TARGETSADMINISTRATOR_NAME`
  * Field `SR_ADMIN_LIST_RELOAD_WEBPANEL`
  * Field `SR_ADMIN_LIST_RELOAD_WEBPANEL_TOOLTIP`
  * Field `SR_ADMIN_ZFD_MOVABLE_DOCS`
  * Field `SR_ADMIN_ZFD_NO_MOVABLE_DOCS`
  * Field `SR_ARCHIVE_EMAIL_FROMNAME`
  * Field `SR_ARCHIVE_EMAIL_TONAME`
  * Field `SR_ARCHIVE_QUOTE_APPROVAL_ASSOCIATE`
  * Field `SR_ARCHIVE_QUOTE_APPROVAL_ASSOCIATE_ID`
  * Field `SR_ARCHIVE_QUOTE_ENTITY_APPROVED`
  * Field `SR_ARCHIVE_QUOTE_ENTITY_DENIED`
  * Field `SR_ARCHIVE_QUOTE_ENTITY_NEEDS_APPROVAL`
  * Field `SR_ARCHIVE_QUOTE_ENTITY_REQUESTED`
  * Field `SR_ARCHIVE_QUOTE_OWNER`
  * Field `SR_ARCHIVE_QUOTE_OWNER_ID`
  * Field `SR_ARCHIVE_QUOTE_WARNING_REASON`
  * Field `SR_ARCHIVE_QUOTEVERSION_APPROVED_TEXT`
  * Field `SR_ARCHIVE_SALE_TITLE`
  * Field `SR_BUTT_APPLY_SHORT`
  * Field `SR_CHAT_ACCEPT_UPLOAD`
  * Field `SR_CHAT_AGENT_MSG_COLOR`
  * Field `SR_CHAT_AGENT_MSG_TEXT_COLOR`
  * Field `SR_CHAT_BADGE_COLOR`
  * Field `SR_CHAT_BUTTON_COLOR`
  * Field `SR_CHAT_CUST_MSG_COLOR`
  * Field `SR_CHAT_CUST_MSG_TEXT_COLOR`
  * Field `SR_CHAT_DELETED_AGENT`
  * Field `SR_CHAT_MSG_COLOR`
  * Field `SR_CLOSE_THIS_TAB_TEXT`
  * Field `SR_CLOSE_THIS_WINDOW_TEXT`
  * Field `SR_CLOSE_THIS_WINDOW_TITLE`
  * Field `SR_COMMON_SHOW_FAVOURITES`
  * Field `SR_COMMON_SHOW_HISTORY`
  * Field `SR_COMMON_SHOW_LIST`
  * Field `SR_COMMON_SHOW_MINE`
  * Field `SR_COMMON_SHOW_SEARCH_RESULTS`
  * Field `SR_CONFIGSCREEN_ACTION`
  * Field `SR_CONFIGSCREEN_ACTION_EXAMPLE`
  * Field `SR_CONFIGSCREEN_ACTION_EXAMPLE_TOOLTIP`
  * Field `SR_CONFIGSCREEN_ASSIGNTO_DESC`
  * Field `SR_CONFIGSCREEN_CONFIRM_APPLYLAYOUT`
  * Field `SR_CONFIGSCREEN_DEFAULTCLICK`
  * Field `SR_CONFIGSCREEN_EDITLAYOUT_ASSIGNMENT`
  * Field `SR_CONFIGSCREEN_NO_OPTIONS`
  * Field `SR_CONFIGSCREEN_ONCLICK_NAVIGATE`
  * Field `SR_CONFIGSCREEN_ONDBLCLICK_NAVIGATE`
  * Field `SR_CONFIGSCREEN_PREVIEW_OF_ENTITY`
  * Field `SR_CONFIGSCREEN_RESTORETABS`
  * Field `SR_CONTACT_SEARCH`
  * Field `SR_CRITERIONTYPE_COMPANY_COMPANY_RELATION`
  * Field `SR_CRITERIONTYPE_COMPANY_PERSON_RELATION`
  * Field `SR_CRITERIONTYPE_COMPANY_RELATION`
  * Field `SR_CRITERIONTYPE_PERSON_COMPANY_RELATION`
  * Field `SR_CRITERIONTYPE_PERSON_PERSON_RELATION`
  * Field `SR_DASHBOARD_COPY_TILE`
  * Field `SR_DASHBOARD_EDIT_COMPARE_TO_TARGET_DISABLED_BY_FIELD_TOOLTIP`
  * Field `SR_DASHBOARD_EDIT_COMPARE_TO_TARGET_LABEL_TOOLTIP`
  * Field `SR_DASHBOARD_EDIT_DIFFERENCE`
  * Field `SR_DASHBOARD_EDIT_DIFFERENCE_AS_ACTUAL`
  * Field `SR_DASHBOARD_EDIT_DIFFERENCE_AS_DIFF`
  * Field `SR_DASHBOARD_EDIT_LABEL_POSITION`
  * Field `SR_DASHBOARD_EDIT_LABELS_SHORT`
  * Field `SR_DASHBOARD_EDIT_LABELS_SHORT_AND_PERCENT`
  * Field `SR_DASHBOARD_EDIT_PIE_SIZE`
  * Field `SR_DASHBOARD_EDIT_SHOW_AS_PERCENTAGE`
  * Field `SR_DASHBOARD_EDIT_STYLE_COLUMNS_AT_100`
  * Field `SR_DASHBOARD_EDIT_STYLE_FULL_OVERLAP`
  * Field `SR_DASHBOARD_EDIT_STYLE_LINE_AT_100`
  * Field `SR_DASHBOARD_EDIT_STYLE_ONLY_ACTUAL`
  * Field `SR_DASHBOARD_NAV_NO_TILES`
  * Field `SR_DASHBOARD_SHOW_DATASET`
  * Field `SR_DASHTILE_SAL_MY_FORCAST_AGAINST_TARGET_THIS_QUARTER`
  * Field `SR_DASHTILE_SAL_MY_FORECAST_AGAINST_TARGET_THIS_MONTH`
  * Field `SR_DASHTILE_SAL_TEAM_FORECAST_AGAINST_TARGET_THIS_MONTH`
  * Field `SR_DASHTILE_SAL_TEAMS_FORCAST_AGAINST_TARGET_THIS_MONTH`
  * Field `SR_DISCARD_CHANGES_TEXT`
  * Field `SR_EDITOR_BUTTON_RESIZE`
  * Field `SR_EDITOR_BUTTON_RESIZE_DESC`
  * Field `SR_EMAIL_DOMAIN_BLACKLISTED`
  * Field `SR_FILEUPLOAD_BROWSE`
  * Field `SR_FILEUPLOAD_DROP`
  * Field `SR_FILEUPLOAD_ERROR`
  * Field `SR_FILEUPLOAD_ERROR_TOO_LARGE`
  * Field `SR_FILEUPLOAD_ERROR1`
  * Field `SR_FORMS_ACTION_DEFAULT_ASSOCIATE`
  * Field `SR_FORMS_INCLUDE_PARSER_VARIABLES`
  * Field `SR_FORMS_OPEN_LINK`
  * Field `SR_FORMS_RESET_CONFIG`
  * Field `SR_FORMS_SELECT_FIELDS`
  * Field `SR_HTMLTAGS_NEWTAG`
  * Field `SR_HTMLTAGS_NEWTAG_CONFIRMATION`
  * Field `SR_LABEL_NEW_QUICK_TICKET`
  * Field `SR_LABEL_NEW_TICKET`
  * Field `SR_MAIL_PREVIEW_FROMNAME_TOOLTIP`
  * Field `SR_MAIL_PREVIEW_TONAME_TOOLTIP`
  * Field `SR_MDO_DEFAULT_PLACEHOLDER`
  * Field `SR_MENU_CONTACT_NEW_QUICK_TICKET`
  * Field `SR_MENU_CONTACT_NEW_TICKET`
  * Field `SR_MENU_FILE_NEW_QUICK_TICKET`
  * Field `SR_MENU_TARGETS_ADJUST_NUMBERS_TOOLTIP`
  * Field `SR_MENU_TARGETS_CLEAR_TOOLTIP`
  * Field `SR_MENU_TARGETS_HISTORY_TOOLTIP`
  * Field `SR_MESSAGEHEADER_STDITEM_CUSTOMER_READ_FAQ`
  * Field `SR_MESSAGEHEADER_STDITEM_FORWARD`
  * Field `SR_MESSAGEHEADER_STDITEM_NO_AUTOREPLY`
  * Field `SR_MESSAGEHEADER_STDITEM_REPLYTEMPLATE`
  * Field `SR_MESSAGEHEADER_STDITEM_SENT_AUTOREPLYTOCUSTOMERS_A`
  * Field `SR_MESSAGEHEADER_STDITEM_SENT_AUTOREPLYTOCUSTOMERS_B`
  * Field `SR_MESSAGEHEADER_STDITEM_UNNAMED_ATTACHMENTBLOCKED`
  * Field `SR_MM_RESULT_TITLE`
  * Field `SR_PD_request_autoCloseTab_DESC`
  * Field `SR_PD_request_autoCloseTab_NAME`
  * Field `SR_PREVIEW_DASHTILE_NO_NAME`
  * Field `SR_PREVIEW_VIEW_ACTIVITIES`
  * Field `SR_PROJECTGUIDE_ALT_TEXT`
  * Field `SR_QUOTE_APPROVED_BY_ID`
  * Field `SR_QUOTE_QUOTEVERSION_APPROVALREQUESTED`
  * Field `SR_QUOTE_QUOTEVERSION_APPROVALREQUESTED_TOOLTIP`
  * Field `SR_QUOTE_REQUEST_APPROVAL_COMMENT`
  * Field `SR_QUOTE_REQUESTAPPROVAL`
  * Field `SR_QUOTE_SENDAPPROVALTO`
  * Field `SR_SALEGUIDE_ALT_TEXT`
  * Field `SR_SALEQUOTE_ALT_TEXT`
  * Field `SR_SELECTION_SAVEASSELECTION_DISABLE_REASON`
  * Field `SR_SELECTITEM_DEFAULT_PLACEHOLDER`
  * Field `SR_TABS_SEARCH`
  * Field `SR_TARGETS_ADD_NEW`
  * Field `SR_TARGETS_ADD_YOUR_TEAM`
  * Field `SR_TARGETS_ALL_LABEL`
  * Field `SR_TARGETS_ALL_SALES_AMOUNT`
  * Field `SR_TARGETS_LOCKED_BY_CHILDREN`
  * Field `SR_TARGETS_LOCKED_ROW_TOOLTIP`
  * Field `SR_TARGETS_NO_TARGETS_CREATED`
  * Field `SR_TARGETS_REVISION_HISTORY_TITLE`
  * Field `SR_TARGETS_ROW_LOCKED_TOOLTIP`
  * Field `SR_TARGETS_TOGGLE_LOCK_TOOLTIP`
  * Field `SR_TICKET_ACTION_ACCEPT`
  * Field `SR_TICKET_ACTION_JOINENTRIES`
  * Field `SR_TICKET_ACTION_PUBLISH`
  * Field `SR_TICKET_ACTION_SPLIT`
  * Field `SR_TICKET_CHANGELOG`
  * Field `SR_TICKET_CONNECT_KNOWN_SENDER`
  * Field `SR_TICKET_DEADLINE1`
  * Field `SR_TICKET_DETAILS`
  * Field `SR_TICKET_MESSAGE_ACTION_CHANGE`
  * Field `SR_TICKET_MESSAGE_ACTION_PRINTMESSAGE`
  * Field `SR_TICKET_MESSAGE_ACTION_SHOWMESSAGE`
  * Field `SR_TICKET_MESSAGE_ACTION_SPLITMESSAGE`
  * Field `SR_TICKET_MESSAGE_ACTION_VIEWHEADER`
  * Field `SR_TICKET_MESSAGE_CUSTOMFIELDS_HIDE`
  * Field `SR_TICKET_MESSAGE_CUSTOMFIELDS_SHOW`
  * Field `SR_TICKET_MESSAGE_SHOWMESSAGE_CAPTION`
  * Field `SR_TICKET_MESSAGE_TIMESPENT`
  * Field `SR_TICKET_MESSAGE_VIEWHEADER_CAPTION`
  * Field `SR_TICKET_MESSAGES1`
  * Field `SR_TICKET_PREVIEW_HIDE`
  * Field `SR_TICKET_PREVIEW_SHOW`
  * Field `SR_WEBTOOLS_INITIALIZE_ERROR_MESSAGE`

##### SuperOffice.License.SoLicenseNames is Modified

* New items
  * Field `TargetAppointment`
  * Field `TargetAppointmentUnlimited`
  * Field `TargetProject`
  * Field `TargetProjectUnlimited`
  * Field `TargetSale`
  * Field `TargetSaleUnlimited`
  * Field `TargetTicket`
  * Field `TargetTicketUnlimited`

##### SuperOffice.NetServerVersion is Modified

* Deleted items
  * Method `DotNetFrameworkVersion()`

##### SuperOffice.Security.Permissions.SoStrongName is Modified

* Deleted items
  * Property `Permission`
  * Property `PublicKeyBlob`

##### SuperOffice.Security.Principal.IContextResolver is Modified

* Deleted items
  * Method `TryResolveContext(SecurityToken[], String&)`
* New items
  * Method `TryResolveContextFromClaims(IEnumerable<ClaimsIdentity>, String&)`

##### SuperOffice.Security.Principal.IPostAuthenticationPlugin is Modified

* Deleted items
  * Method `PostAuthenticateFail(SoPrincipal, SecurityToken[], List<SecurityToken>, Exception)`
  * Method `PostAuthenticateSuccess(SoPrincipal, SecurityToken[], List<SecurityToken>)`
* New items
  * Method `PostAuthenticateFail(SoPrincipal, IEnumerable<ClaimsIdentity>, Exception)`
  * Method `PostAuthenticateSuccess(SoPrincipal, IEnumerable<ClaimsIdentity>)`

##### SuperOffice.Security.Principal.ISoIdentity is Modified

* Deleted items
  * Property `Source`

##### SuperOffice.Security.Principal.Private.PrincipalHelper is Modified

* Deleted items
  * Method `GetProvidedCredentials(SoIdentity)`
  * Method `SetIdentityState(SoIdentity, AuthenticationState)`

##### SuperOffice.Security.Principal.SoAccessToken is Modified

* New items
  * Field `ClaimType`

##### SuperOffice.Security.Principal.SoCredentialsSecurityToken is Modified

* Deleted items
  * Method `SoCredentialsSecurityToken(SoCredentials)`
  * Method `SoCredentialsSecurityToken(String)`
  * Method `GetCredentials()`

##### SuperOffice.Security.Principal.SoPrincipal is Modified

* Deleted items
  * Property `Tokens`
  * Method `SoPrincipal(SecurityToken[])`
* New items
  * Property `Identities`
  * Method `SoPrincipal(IEnumerable<ClaimsIdentity>)`

##### SuperOffice.SoDatabaseContext is Modified

* Deleted items
  * Method `TryResolveContext(IContextResolver&, String&, SecurityToken[])`
  * Method `TryResolveContext(IContextResolver&, String&, String, String)`
* New items
  * Method `TryResolveContext(IContextResolver&, String&, IEnumerable<ClaimsIdentity>)`
  * Method `TryResolveContext(IContextResolver&, String&, ClaimsIdentity[])`

##### SuperOffice.SoSession is Modified

* Deleted items
  * Method `Authenticate(SecurityToken[])`
  * Method `Authenticate(IIdentity)`
* New items
  * Method `Authenticate(ClaimsIdentity, Claim[])`

##### SuperOffice.Util.DateUtility is Modified

* New items
  * Method `CloseEnoughTo(DateTime, DateTime, Int32)`

##### SuperOffice.Util.Encoding is Modified

* New items
  * Method `ParseQueryString(String)`
  * Method `UrlEncodeUnicode(String)`

##### SuperOffice.Util.HttpHelper is Modified

* Modified items

###### SuperOffice.Util.HttpHelper.HttpServiceJwtConfig is Modified

* New items
  * Property `.HttpServiceJwtConfigTimeout`

##### SuperOffice.Util.SoMapper is Modified

* Deleted items
  * Method `CopyProperties(Type, Type, Object, Object, Boolean, Boolean)`
  * Method `CopyProperties<TSource, TDestination>(TSource, TDestination, Boolean)`
* New items
  * Method `CopyProperties(Type, Type, Object, Object, Boolean, Boolean, Boolean)`
  * Method `CopyProperties<TSource, TDestination>(TSource, TDestination, Boolean, Boolean, Boolean)`
  * Method `CopyProperties<TSource, TDestination>(TSource[], TDestination[], Boolean, Boolean, Boolean)`

#### Assembly: SoDatabase

#### Deleted Types

* `SuperOffice.CRM.ArchiveLists.ContactSourceRelationExtender`
* `SuperOffice.CRM.ArchiveLists.ContactTargetRelationExtender`
* `SuperOffice.CRM.ArchiveLists.Joiners.PersonSourceRelationExtender`
* `SuperOffice.CRM.ArchiveLists.Joiners.PersonTargetRelationExtender`
* `SuperOffice.CRM.Data.TargetPeriodAssignmentTableInfo`
* `SuperOffice.Data.Dialect.DB2Common`
* `SuperOffice.Data.Dialect.DB2Operations`
* `SuperOffice.Data.Dialect.MySqlCommon`
* `SuperOffice.Data.Dialect.Oracle10`
* `SuperOffice.Data.Dialect.Oracle11`
* `SuperOffice.Data.Dialect.Oracle8`
* `SuperOffice.Data.Dialect.Oracle9`
* `SuperOffice.Data.Dialect.SqlStateManager`
* `SuperOffice.Data.Dialect.SqlStateType`
* `SuperOffice.Data.Dialect.SybaseCommon`
* `SuperOffice.Data.Dialect.SybaseOperations`
* `SuperOffice.Security.Principal.AssociateResolver<TToken>`
* `SuperOffice.Security.Principal.UserNameAsWindowsIdentityResolver`

#### New Types

* `SuperOffice.CRM.ArchiveLists.ConfigurableArchiveProjectProvider`
* `SuperOffice.CRM.ArchiveLists.ConfigurableArchiveQuoteLineProvider`
* `SuperOffice.CRM.ArchiveLists.ContactSourceContactRelationExtender`
* `SuperOffice.CRM.ArchiveLists.ContactSourcePersonRelationExtender`
* `SuperOffice.CRM.ArchiveLists.ContactTargetContactRelationExtender`
* `SuperOffice.CRM.ArchiveLists.ContactTargetPersonRelationExtender`
* `SuperOffice.CRM.ArchiveLists.Joiners.PersonSourceContactRelationExtender`
* `SuperOffice.CRM.ArchiveLists.Joiners.PersonSourcePersonRelationExtender`
* `SuperOffice.CRM.ArchiveLists.Joiners.PersonTargetContactRelationExtender`
* `SuperOffice.CRM.ArchiveLists.Joiners.PersonTargetPersonRelationExtender`
* `SuperOffice.CRM.ArchiveLists.QuoteApprovalProvider`
* `SuperOffice.CRM.ArchiveLists.TargetValueSubProvider`
* `SuperOffice.CRM.Cache.MDOListTableQuoteApprReasonCache`
* `SuperOffice.CRM.Cache.MDOListTableQuoteDenyReasonCache`
* `SuperOffice.CRM.Data.ConfigurableScreenAppliesToTableInfo`
* `SuperOffice.CRM.Data.QuoteApprReasonGroupLinkTableInfo`
* `SuperOffice.CRM.Data.QuoteApprReasonHeadingLinkTableInfo`
* `SuperOffice.CRM.Data.QuoteApprReasonTableInfo`
* `SuperOffice.CRM.Data.QuoteDenyReasonGroupLinkTableInfo`
* `SuperOffice.CRM.Data.QuoteDenyReasonHeadingLinkTableInfo`
* `SuperOffice.CRM.Data.QuoteDenyReasonTableInfo`
* `SuperOffice.CRM.Data.TargetDimensionTableInfo`
* `SuperOffice.CRM.Entities.Providers.Factory.PersonInfo3ProviderIdFactory`
* `SuperOffice.CRM.Entities.Providers.Factory.PersonInfo3ProviderRDBFactory`
* `SuperOffice.CRM.Entities.Providers.Factory.ProjectInfo3ProviderIdFactory`
* `SuperOffice.CRM.Entities.Providers.Factory.ProjectInfo3ProviderRDBFactory`
* `SuperOffice.CRM.Entities.Providers.Factory.SaleInfo3ProviderIdFactory`
* `SuperOffice.CRM.Entities.Providers.Factory.SaleInfo3ProviderRDBFactory`
* `SuperOffice.CRM.Lists.SimpleMailingStatusProvider`
* `SuperOffice.CRM.Lists.TargetTypeProvider`
* `SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRecordData`
* `SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRecordDataExtensions`
* `SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRow`
* `SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateConfigurableScreenAppliesToRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateConfigurableScreenAppliesToRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteApprReasonGroupLinkRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteApprReasonGroupLinkRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteApprReasonHeadingLinkRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteApprReasonHeadingLinkRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteApprReasonRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteApprReasonRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteDenyReasonGroupLinkRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteDenyReasonGroupLinkRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteDenyReasonHeadingLinkRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteDenyReasonHeadingLinkRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteDenyReasonRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteDenyReasonRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetDimensionRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetDimensionRowsFactory`
* `SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRecordData`
* `SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRecordDataExtensions`
* `SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRow`
* `SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRows`
* `SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRecordData`
* `SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRecordDataExtensions`
* `SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRow`
* `SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRows`
* `SuperOffice.CRM.Rows.QuoteApprReasonRecordData`
* `SuperOffice.CRM.Rows.QuoteApprReasonRecordDataExtensions`
* `SuperOffice.CRM.Rows.QuoteApprReasonRow`
* `SuperOffice.CRM.Rows.QuoteApprReasonRows`
* `SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRecordData`
* `SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRecordDataExtensions`
* `SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRow`
* `SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRows`
* `SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRecordData`
* `SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRecordDataExtensions`
* `SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRow`
* `SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRows`
* `SuperOffice.CRM.Rows.QuoteDenyReasonRecordData`
* `SuperOffice.CRM.Rows.QuoteDenyReasonRecordDataExtensions`
* `SuperOffice.CRM.Rows.QuoteDenyReasonRow`
* `SuperOffice.CRM.Rows.QuoteDenyReasonRows`
* `SuperOffice.CRM.Rows.TargetDimensionRecordData`
* `SuperOffice.CRM.Rows.TargetDimensionRecordDataExtensions`
* `SuperOffice.CRM.Rows.TargetDimensionRow`
* `SuperOffice.CRM.Rows.TargetDimensionRows`
* `SuperOffice.CRM.Ticket.TicketHelper`
* `SuperOffice.Data.SQL.ReplyTemplateBodyFlagsFieldInfo`
* `SuperOffice.Data.SQL.TargetAssignementLevelFieldInfo`
* `SuperOffice.Data.SQL.TargetMeasurementUnitFieldInfo`
* `SuperOffice.Security.Principal.AssociateResolver`
* `SuperOffice.Security.Principal.SoAccessTokenClaimsExpander`
* `SuperOffice.Util.ChatExtenderHelper`
* `SuperOffice.Util.SoDocumentPluginPreferenceHelper`
* `SuperOffice.Util.TemporaryConfigOverride`
* `SuperOffice.Util.TemporaryFeatureToggle`

#### Modified Types

##### SuperOffice.CRM.ArchiveLists.Archive.ChatConversationSelectionDynamicProviderSingleCriteriaGroup is Modified

* New items
  * Method `AcceptRow(SoDataReader)`
  * Method `RequiredPhaseOneFields()`
  * Method `SetRestriction(ArchiveRestrictionInfo[])`

##### SuperOffice.CRM.ArchiveLists.ChatSessionExtenderBase is Modified

* New items
  * Field `AgentUnassignedId`
  * Field `DurationColumnName`
  * Field `TimeInQueueColumnName`

##### SuperOffice.CRM.ArchiveLists.EmailItemExtenderBase is Modified

##### SuperOffice.CRM.ArchiveLists.MailingsExtenderBase is Modified

##### SuperOffice.CRM.ArchiveLists.MultiQueryProviderBaseWithRestrictionGroups is Modified

* New items
  * Method `GetFirstProvider()`

##### SuperOffice.CRM.ArchiveLists.PhaseOneQueryCacher is Modified

* Modified items
  * Method `SetCachedKeys(String, Int32, List<Int32>)`
* New items
  * Method `Clear()`
  * Method `SetCachedKeys(String, String, List<Int32>)`

##### SuperOffice.CRM.ArchiveLists.TargetValueExtenderBase is Modified

* New items
  * Field `TargetAssignmentIdColName`
  * Field `TargetPeriodColName`
  * Field `TargetPeriodNumberColName`
  * Field `TargetPeriodTypeColName`
  * Field `TargetValueColName`
  * Property `EndDate`
  * Property `StartDate`

##### SuperOffice.CRM.ArchiveLists.TargetValueProvider is Modified

* Deleted items
  * Field `RowTypeName`
* Modified items
  * Method `TargetValueProvider()`
* New items
  * Property `BaseClassShouldFilterColumns`
  * Property `BaseClassShouldFilterEntities`
  * Property `BaseClassShouldPage`
  * Property `BaseClassShouldSort`
  * Method `GetResultData()`
  * Method `SetDesiredColumns(String[])`

##### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_ConfigurableScreenAppliesTo_RegisteredAssociateId`
  * Property `LeftOuterJoin_ConfigurableScreenAppliesTo_UpdatedAssociateId`
  * Property `LeftOuterJoin_QuoteApprReason_RegisteredAssociateId`
  * Property `LeftOuterJoin_QuoteApprReason_UpdatedAssociateId`
  * Property `LeftOuterJoin_QuoteApprReasonGroupLink_RegisteredAssociateId`
  * Property `LeftOuterJoin_QuoteApprReasonGroupLink_UpdatedAssociateId`
  * Property `LeftOuterJoin_QuoteApprReasonHeadingLink_RegisteredAssociateId`
  * Property `LeftOuterJoin_QuoteApprReasonHeadingLink_UpdatedAssociateId`
  * Property `LeftOuterJoin_QuoteDenyReason_RegisteredAssociateId`
  * Property `LeftOuterJoin_QuoteDenyReason_UpdatedAssociateId`
  * Property `LeftOuterJoin_QuoteDenyReasonGroupLink_RegisteredAssociateId`
  * Property `LeftOuterJoin_QuoteDenyReasonGroupLink_UpdatedAssociateId`
  * Property `LeftOuterJoin_QuoteDenyReasonHeadingLink_RegisteredAssociateId`
  * Property `LeftOuterJoin_QuoteDenyReasonHeadingLink_UpdatedAssociateId`
  * Property `LeftOuterJoin_QuoteVersion_RequestAssociateId`
  * Property `LeftOuterJoin_TargetDimension_RegisteredAssociateId`
  * Property `LeftOuterJoin_TargetDimension_UpdatedAssociateId`

##### SuperOffice.CRM.Data.ChatTopicTableInfo is Modified

* New items
  * Property `WidgetAgentMsgColor`
  * Property `WidgetAgentMsgTextColor`
  * Property `WidgetBadgeColor`
  * Property `WidgetBadgeTextColor`
  * Property `WidgetButtonColor`
  * Property `WidgetButtonTextColor`
  * Property `WidgetCustMsgColor`
  * Property `WidgetCustMsgTextColor`
  * Property `WidgetFontSize`

##### SuperOffice.CRM.Data.DBC is Modified

* Modified items

###### SuperOffice.CRM.Data.DBC.ChatTopicFields is Modified

* New items
  * Field `.ChatTopicFieldsWidgetAgentMsgColor`
  * Field `.ChatTopicFieldsWidgetAgentMsgTextColor`
  * Field `.ChatTopicFieldsWidgetBadgeColor`
  * Field `.ChatTopicFieldsWidgetBadgeTextColor`
  * Field `.ChatTopicFieldsWidgetButtonColor`
  * Field `.ChatTopicFieldsWidgetButtonTextColor`
  * Field `.ChatTopicFieldsWidgetCustMsgColor`
  * Field `.ChatTopicFieldsWidgetCustMsgTextColor`
  * Field `.ChatTopicFieldsWidgetFontSize`

###### SuperOffice.CRM.Data.DBC.QuoteVersionFields is Modified

* New items
  * Field `.QuoteVersionFieldsRequestAssociateId`
  * Field `.QuoteVersionFieldsRequestComment`

###### SuperOffice.CRM.Data.DBC.TargetAssignmentInfoFields is Modified

* New items
  * Field `.TargetAssignmentInfoFieldsTargetDimensionItemId`

###### SuperOffice.CRM.Data.DBC.TargetGroupFields is Modified

* New items
  * Field `.TargetGroupFieldsTargetDimensionId`

* New items
  * Field `ConfigurableScreenAppliesTo`
  * Field `QuoteApprReason`
  * Field `QuoteApprReasonGroupLink`
  * Field `QuoteApprReasonHeadingLink`
  * Field `QuoteDenyReason`
  * Field `QuoteDenyReasonGroupLink`
  * Field `QuoteDenyReasonHeadingLink`
  * Field `TargetDimension`

###### SuperOffice.CRM.Data.DBC.ConfigurableScreenAppliesToFields is New

###### SuperOffice.CRM.Data.DBC.QuoteApprReasonFields is New

###### SuperOffice.CRM.Data.DBC.QuoteApprReasonGroupLinkFields is New

###### SuperOffice.CRM.Data.DBC.QuoteApprReasonHeadingLinkFields is New

###### SuperOffice.CRM.Data.DBC.QuoteDenyReasonFields is New

###### SuperOffice.CRM.Data.DBC.QuoteDenyReasonGroupLinkFields is New

###### SuperOffice.CRM.Data.DBC.QuoteDenyReasonHeadingLinkFields is New

###### SuperOffice.CRM.Data.DBC.TargetDimensionFields is New

##### SuperOffice.CRM.Data.HeadingTableInfo is Modified

* New items
  * Property `LeftOuterJoin_QuoteApprReasonHeadingLink_HeadingId`
  * Property `LeftOuterJoin_QuoteDenyReasonHeadingLink_HeadingId`

##### SuperOffice.CRM.Data.QuoteVersionTableInfo is Modified

* New items
  * Property `RequestAssociateId`
  * Property `RequestAssociateId_InnerJoin_Associate`
  * Property `RequestComment`

##### SuperOffice.CRM.Data.ReplyTemplateBodyTableInfo is Modified

* Modified items
  * Property `Flags`

##### SuperOffice.CRM.Data.TargetAssignmentInfoTableInfo is Modified

* New items
  * Property `TargetDimensionItemId`

##### SuperOffice.CRM.Data.TargetGroupTableInfo is Modified

* New items
  * Property `TargetDimensionId`
  * Property `TargetDimensionId_InnerJoin_TargetDimension`

##### SuperOffice.CRM.Data.UserGroupTableInfo is Modified

* New items
  * Property `LeftOuterJoin_QuoteApprReasonGroupLink_GroupId`
  * Property `LeftOuterJoin_QuoteDenyReasonGroupLink_GroupId`

##### SuperOffice.CRM.Data.Util.ExtraFieldHelper is Modified

* New items
  * Method `GetInitializedExtraFields<T>(T)`

##### SuperOffice.CRM.Documents.HtmlToPdf is Modified

* Modified items
  * Method `ConvertHtmlToPdf(String, Stream)`

##### SuperOffice.CRM.Entities.EntityCustomFieldsHelper is Modified

* New items
  * Method `ToDictionary()`
  * Method `ToStringDictionary()`

##### SuperOffice.CRM.Entities.Providers.ContactInfoProvider is Modified

* New items
  * Property `CustomFields`

##### SuperOffice.CRM.Entities.Providers.PersonInfoProvider is Modified

* New items
  * Property `CustomFields`

##### SuperOffice.CRM.Entities.Providers.ProjectInfoProvider is Modified

* New items
  * Property `CustomFields`

##### SuperOffice.CRM.Entities.Providers.SaleInfoProvider is Modified

* New items
  * Property `CustomFields`

##### SuperOffice.CRM.Lists.CreateDocumentTemplatePluginsProvider is Modified

* New items
  * Method `GetDocumentPlugins()`
  * Method `GetPluginInfos()`
  * Method `ShouldIncludePlugin(IDocumentPlugin2)`
  * Method `ShouldIncludePluginInfo(PluginInfo)`

##### SuperOffice.CRM.Lists.DashboardProvider is Modified

* New items
  * Method `GetHistoryItems()`

##### SuperOffice.CRM.Lists.EjCategoryProvider is Modified

##### SuperOffice.CRM.Lists.LiteralsOnlyBase is Modified

* New items
  * Property `ForceFlatList`

##### SuperOffice.CRM.Notification.NotificationEventHandler is Modified

* Deleted items
  * Method `NotificationHandled(NotificationEventType, Int32)`
* New items
  * Property `SendMessageToOurself`
  * Property `SilentExceptions`
  * Method `NotificationHandled(NotificationEventType, Int32, IEnumerable<Int32>)`
  * Method `NotificationHandled(NotificationEventType, Int32, Int32)`
  * Method `NotifyUser(NotificationEventType, Int32, DateTime, Int32)`
  * Method `NotifyUsers(NotificationEventType, Int32, DateTime, IEnumerable<Int32>)`

##### SuperOffice.CRM.Notification.PushNotificationServiceManager is Modified

* Deleted items
  * Method `SendMessage(Int32[], PushNotificationMessage, Boolean, Boolean)`
* New items
  * Method `GetQuoteNotificationCount(Int32)`
  * Method `SendMessage(IEnumerable<Int32>, PushNotificationMessage, Boolean, Boolean)`

##### SuperOffice.CRM.Rows.AccessScriptRow is Modified

* Deleted items
  * Event `OnAccessTableNameChange`
  * Event `OnBodyChange`

##### SuperOffice.CRM.Rows.ActiveUserRow is Modified

* Deleted items
  * Event `OnClientTypeChange`
  * Event `OnComputerNameChange`
  * Event `OnDomainNameChange`
  * Event `OnLastloginChange`
  * Event `OnNetAddressChange`
  * Event `OnOsUserNameChange`

##### SuperOffice.CRM.Rows.AddressFormatRow is Modified

* Deleted items
  * Event `OnAddress1FlagsChange`
  * Event `OnAddress1LeadtextChange`
  * Event `OnAddress1LengthChange`
  * Event `OnAddress1LineChange`
  * Event `OnAddress1MaskChange`
  * Event `OnAddress1SubposChange`
  * Event `OnAddress1ZipChange`
  * Event `OnAddress2FlagsChange`
  * Event `OnAddress2LeadtextChange`
  * Event `OnAddress2LengthChange`
  * Event `OnAddress2LineChange`
  * Event `OnAddress2MaskChange`
  * Event `OnAddress2SubposChange`
  * Event `OnAddress2ZipChange`
  * Event `OnAddress3FlagsChange`
  * Event `OnAddress3LeadtextChange`
  * Event `OnAddress3LengthChange`
  * Event `OnAddress3LineChange`
  * Event `OnAddress3MaskChange`
  * Event `OnAddress3SubposChange`
  * Event `OnAddress3ZipChange`
  * Event `OnAtypeIdxChange`
  * Event `OnCityFlagsChange`
  * Event `OnCityLeadtextChange`
  * Event `OnCityLengthChange`
  * Event `OnCityLineChange`
  * Event `OnCityMaskChange`
  * Event `OnCitySubposChange`
  * Event `OnCityZipChange`
  * Event `OnCountyFlagsChange`
  * Event `OnCountyLeadtextChange`
  * Event `OnCountyLengthChange`
  * Event `OnCountyLineChange`
  * Event `OnCountyMaskChange`
  * Event `OnCountySubposChange`
  * Event `OnCountyZipChange`
  * Event `OnExtraFlagsChange`
  * Event `OnIsBuiltInChange`
  * Event `OnLabelLayout2Change`
  * Event `OnLabelLayoutChange`
  * Event `OnLayoutIdChange`
  * Event `OnNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStateFlagsChange`
  * Event `OnStateLeadtextChange`
  * Event `OnStateLengthChange`
  * Event `OnStateLineChange`
  * Event `OnStateMaskChange`
  * Event `OnStateSubposChange`
  * Event `OnStateZipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnZipFlagsChange`
  * Event `OnZipLeadtextChange`
  * Event `OnZipLengthChange`
  * Event `OnZipLineChange`
  * Event `OnZipMaskChange`
  * Event `OnZipSubposChange`
  * Event `OnZipZipChange`

##### SuperOffice.CRM.Rows.AddressRow is Modified

* Deleted items
  * Event `OnAddress1Change`
  * Event `OnAddress2Change`
  * Event `OnAddress3Change`
  * Event `OnAtypeIdxChange`
  * Event `OnCityChange`
  * Event `OnCountyChange`
  * Event `OnOwnerIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStateChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnValidFromChange`
  * Event `OnValidToChange`
  * Event `OnWgs84LatitudeChange`
  * Event `OnWgs84LongitudeChange`
  * Event `OnZipcodeChange`

##### SuperOffice.CRM.Rows.AmountClassGroupLinkRow is Modified

* Deleted items
  * Event `OnAmountclassIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AmountClassHeadingLinkRow is Modified

* Deleted items
  * Event `OnAmountclassIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AmountClassRow is Modified

* Deleted items
  * Event `OnAmountFromChange`
  * Event `OnAmountToChange`
  * Event `OnCurrencyIdChange`
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AppointmentRow is Modified

* New items
  * Event `OnValueChanged`

##### SuperOffice.CRM.Rows.AreaRow is Modified

* Deleted items
  * Event `OnAllDataChange`
  * Event `OnDbTypeChange`
  * Event `OnEncryptedCommChange`
  * Event `OnFilterTypeChange`
  * Event `OnMaxDataAgeChange`
  * Event `OnNameChange`
  * Event `OnParentAreaIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AreaUserAssignmentRow is Modified

* Deleted items
  * Event `OnAreaIdChange`
  * Event `OnAssociateIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AreaUserInclusionRow is Modified

* Deleted items
  * Event `OnAreaIdChange`
  * Event `OnAssociateIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AssociateGroupLinkRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AssociateHeadingLinkRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AssociateHistoryRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnContactIdChange`
  * Event `OnEjUserIdChange`
  * Event `OnFirstnameChange`
  * Event `OnGroupIdChange`
  * Event `OnLastnameChange`
  * Event `OnLocationAddressChange`
  * Event `OnMiddleNameChange`
  * Event `OnNameChange`
  * Event `OnOriginalRegisteredChange`
  * Event `OnPersonIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTypeChange`

##### SuperOffice.CRM.Rows.AssociateRow is Modified

* Deleted items
  * Event `OnChecklistlimitChange`
  * Event `OnDeletedChange`
  * Event `OnEjUserIdChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnGroupIdxChange`
  * Event `OnIsLocationChange`
  * Event `OnLastloginChange`
  * Event `OnLastlogoutChange`
  * Event `OnLocationAddressChange`
  * Event `OnNameChange`
  * Event `OnPersonIdChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnTypeChange`
  * Event `OnTzLocationIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUserFlagsChange`
  * Event `OnUserNameChange`
  * Event `OnWaitingForApprovalChange`

##### SuperOffice.CRM.Rows.AttachmentLocationRow is Modified

* Deleted items
  * Event `OnPathChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AttachmentRow is Modified

* Deleted items
  * Event `OnAttachmentLocationIdChange`
  * Event `OnAttSizeChange`
  * Event `OnAuthKeyChange`
  * Event `OnCharsetChange`
  * Event `OnContentTypeChange`
  * Event `OnDbiAgentIdChange`
  * Event `OnDbiKeyChange`
  * Event `OnDbiLastModifiedChange`
  * Event `OnDbiLastSyncronizedChange`
  * Event `OnNameChange`

##### SuperOffice.CRM.Rows.AudienceConfigRow is Modified

* Deleted items
  * Event `OnAudienceLayoutIdChange`
  * Event `OnConfigNameChange`
  * Event `OnConfigValueChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSeqnoChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AudienceLayoutLinkRow is Modified

* Deleted items
  * Event `OnAudienceLayoutIdChange`
  * Event `OnCommentChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTargetRecordChange`
  * Event `OnTargetTableChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AudienceLayoutRow is Modified

* Deleted items
  * Event `OnInstanceLayoutChange`
  * Event `OnInstanceNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AudienceVisibilityRow is Modified

* Deleted items
  * Event `OnCommentChange`
  * Event `OnConstraintEnabledChange`
  * Event `OnControllingRecordChange`
  * Event `OnControllingTableChange`
  * Event `OnExtraInfoChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSourceRecordChange`
  * Event `OnSourceTableChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.AutosaveRow is Modified

* Deleted items
  * Event `OnContentTypeChange`
  * Event `OnCreatedAtChange`
  * Event `OnDataChange`
  * Event `OnIndexIdChange`

##### SuperOffice.CRM.Rows.BaseTZLocationRow is Modified

* Deleted items
  * Event `OnDatabaseIdChange`
  * Event `OnDescriptionChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTZLocationIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnValidFromChange`

##### SuperOffice.CRM.Rows.BatchTaskDefinitionRow is Modified

* Deleted items
  * Event `OnAssemblyVersionChange`
  * Event `OnAutoRestartCountChange`
  * Event `OnDescriptionChange`
  * Event `OnIsMultiPassChange`
  * Event `OnMinimumSleepTimeChange`
  * Event `OnNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStartIntervalChange`
  * Event `OnTimeoutChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.BatchTaskRow is Modified

* Deleted items
  * Event `OnBatchTaskDefinitionIdChange`
  * Event `OnDbTagChange`
  * Event `OnDescriptionChange`
  * Event `OnDetailsRecordChange`
  * Event `OnDetailsTableChange`
  * Event `OnFileNameChange`
  * Event `OnLastStartedChange`
  * Event `OnProgressDescriptionChange`
  * Event `OnProgressPercentChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRequestChange`
  * Event `OnResponseChange`
  * Event `OnStartCountChange`
  * Event `OnStateChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.BinaryObjectLinkRow is Modified

* Deleted items
  * Event `OnBinaryObjectIdChange`
  * Event `OnLinkCommentChange`
  * Event `OnLinkTypeChange`
  * Event `OnOwnerRecordChange`
  * Event `OnOwnerTableChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.BinaryObjectRow is Modified

* Deleted items
  * Event `OnBinaryDataChange`
  * Event `OnBlobSizeChange`
  * Event `OnConceptualTypeChange`
  * Event `OnDescriptionChange`
  * Event `OnExtraInfoChange`
  * Event `OnIsEncryptedChange`
  * Event `OnIsZippedChange`
  * Event `OnMimeTypeChange`
  * Event `OnOriginalSizeChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.BusinessGroupLinkRow is Modified

* Deleted items
  * Event `OnBusinessIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.BusinessHeadingLinkRow is Modified

* Deleted items
  * Event `OnBusinessIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.BusinessRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CacheInvalidationRow is Modified

* Deleted items
  * Event `OnGenerationChange`
  * Event `OnLastChangeChange`
  * Event `OnLastChangeMachineChange`
  * Event `OnNameChange`

##### SuperOffice.CRM.Rows.CacheTablesRow is Modified

* Deleted items
  * Event `OnCheckSumChange`
  * Event `OnSubKeyIdChange`
  * Event `OnSubKeyValueChange`
  * Event `OnTableIdChange`

##### SuperOffice.CRM.Rows.CategoryFamilyRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CategoryGroupLinkRow is Modified

* Deleted items
  * Event `OnCategoryIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CategoryHeadingLinkRow is Modified

* Deleted items
  * Event `OnCategoryIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CategoryMembershipRow is Modified

* Deleted items
  * Event `OnCategoryIdChange`
  * Event `OnUserIdChange`
  * Event `OnWeightChange`

##### SuperOffice.CRM.Rows.CategoryRow is Modified

* Deleted items
  * Event `OnCategoryFamilyIdChange`
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ChatMessageRow is Modified

* Deleted items
  * Event `OnAuthorChange`
  * Event `OnCreatedByChange`
  * Event `OnMessageChange`
  * Event `OnReadByCustomerChange`
  * Event `OnSessionIdChange`
  * Event `OnSpecialParamChange`
  * Event `OnSpecialTypeChange`
  * Event `OnTypeChange`
  * Event `OnWhenPostedChange`

##### SuperOffice.CRM.Rows.ChatSessionRow is Modified

* Deleted items
  * Event `OnAlertLevelChange`
  * Event `OnChatbotIsactiveChange`
  * Event `OnCompanyNameChange`
  * Event `OnConsentedChange`
  * Event `OnContactIdChange`
  * Event `OnCountryChange`
  * Event `OnCustomerAliasChange`
  * Event `OnCustomerFetchChange`
  * Event `OnCustomerHostChange`
  * Event `OnCustomerIdChange`
  * Event `OnEmailChange`
  * Event `OnFirstMessageChange`
  * Event `OnFlagsChange`
  * Event `OnIdleChange`
  * Event `OnInitialQueuePosChange`
  * Event `OnLastMessageChange`
  * Event `OnNameChange`
  * Event `OnPhoneChange`
  * Event `OnProjectIdChange`
  * Event `OnRankChange`
  * Event `OnRatingChange`
  * Event `OnSaleIdChange`
  * Event `OnSessionKeyChange`
  * Event `OnStatusChange`
  * Event `OnTicketIdChange`
  * Event `OnTopicIdChange`
  * Event `OnTransferToChange`
  * Event `OnUserIdChange`
  * Event `OnWhenEndedChange`
  * Event `OnWhenRequestedChange`
  * Event `OnWhenStartedChange`

##### SuperOffice.CRM.Rows.ChatTopicRecordData is Modified

* New items
  * Field `WidgetAgentMsgColor`
  * Field `WidgetAgentMsgTextColor`
  * Field `WidgetBadgeColor`
  * Field `WidgetBadgeTextColor`
  * Field `WidgetButtonColor`
  * Field `WidgetButtonTextColor`
  * Field `WidgetCustMsgColor`
  * Field `WidgetCustMsgTextColor`
  * Field `WidgetFontSize`

##### SuperOffice.CRM.Rows.ChatTopicRow is Modified

* Deleted items
  * Event `OnAlertRecipientChange`
  * Event `OnAlertTemplateChange`
  * Event `OnAlertTimeoutChange`
  * Event `OnBadgeHeaderChange`
  * Event `OnBotEnabledChange`
  * Event `OnBotMessageReceivedScriptidChange`
  * Event `OnBotNameChange`
  * Event `OnBotRegisterScriptidChange`
  * Event `OnBotSessionChangedScriptidChange`
  * Event `OnBotSessionCreatedScriptidChange`
  * Event `OnCategoryIdChange`
  * Event `OnCustomQueueTextChange`
  * Event `OnDescriptionChange`
  * Event `OnFlagsChange`
  * Event `OnFriEnabledChange`
  * Event `OnFriStartChange`
  * Event `OnFriStopChange`
  * Event `OnKbCategoryIdChange`
  * Event `OnLanguageIdChange`
  * Event `OnLastAcceptChange`
  * Event `OnLunchStartChange`
  * Event `OnLunchStopChange`
  * Event `OnManagerWarningChatMessageChange`
  * Event `OnManagerWarningNewChatChange`
  * Event `OnMonEnabledChange`
  * Event `OnMonStartChange`
  * Event `OnMonStopChange`
  * Event `OnNameChange`
  * Event `OnOfflineFormQueueLengthChange`
  * Event `OnOfflineFormTimeLimitChange`
  * Event `OnPriorityIdChange`
  * Event `OnSatEnabledChange`
  * Event `OnSatStartChange`
  * Event `OnSatStopChange`
  * Event `OnSecondsPrAcceptChange`
  * Event `OnSunEnabledChange`
  * Event `OnSunStartChange`
  * Event `OnSunStopChange`
  * Event `OnThuEnabledChange`
  * Event `OnThuStartChange`
  * Event `OnThuStopChange`
  * Event `OnTueEnabledChange`
  * Event `OnTueStartChange`
  * Event `OnTueStopChange`
  * Event `OnTzLocationIdChange`
  * Event `OnUseLunchHoursChange`
  * Event `OnUseOpeningHoursChange`
  * Event `OnWarningChatMessageChange`
  * Event `OnWarningNewChatChange`
  * Event `OnWedEnabledChange`
  * Event `OnWedStartChange`
  * Event `OnWedStopChange`
  * Event `OnWelcomeMessageChange`
  * Event `OnWidgetAgentUseFirstnameChange`
  * Event `OnWidgetAutoFaqChange`
  * Event `OnWidgetColorChange`
  * Event `OnWidgetEnableRatingChange`
  * Event `OnWidgetEnableTicketChange`
  * Event `OnWidgetFontChange`
  * Event `OnWidgetLanguageChange`
  * Event `OnWidgetOfflineFieldsChange`
  * Event `OnWidgetOfflineHeaderChange`
  * Event `OnWidgetOfflineMessageChange`
  * Event `OnWidgetPostFormChange`
  * Event `OnWidgetPostHeaderChange`
  * Event `OnWidgetPostMessageChange`
  * Event `OnWidgetPostTranscriptChange`
  * Event `OnWidgetPreFormChange`
  * Event `OnWidgetPreMessageChange`
  * Event `OnWidgetRatingTextChange`
  * Event `OnWidgetRequiredFieldsChange`
  * Event `OnWidgetShowAgentPhotoChange`
  * Event `OnWidgetShowLogoChange`
  * Event `OnWidgetThemeChange`
  * Event `OnWidgetWelcomeMessageChange`
  * Event `OnWidgetWelcomeTitleChange`
* New items
  * Property `WidgetAgentMsgColor`
  * Property `WidgetAgentMsgTextColor`
  * Property `WidgetBadgeColor`
  * Property `WidgetBadgeTextColor`
  * Property `WidgetButtonColor`
  * Property `WidgetButtonTextColor`
  * Property `WidgetCustMsgColor`
  * Property `WidgetCustMsgTextColor`
  * Property `WidgetFontSize`

##### SuperOffice.CRM.Rows.ChatTopicUserRow is Modified

* Deleted items
  * Event `OnCanListenChange`
  * Event `OnCanRespondChange`
  * Event `OnManagerChange`
  * Event `OnNotificationsChange`
  * Event `OnTopicIdChange`
  * Event `OnUserIdChange`

##### SuperOffice.CRM.Rows.CompanyDomainRow is Modified

* Deleted items
  * Event `OnCompanyIdChange`
  * Event `OnDomainNameChange`
  * Event `OnRankChange`

##### SuperOffice.CRM.Rows.CompanyRow is Modified

* Deleted items
  * Event `OnDbContactIdChange`
  * Event `OnDbContactNameChange`
  * Event `OnDbDepartmentNameChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnExtraInfoChange`
  * Event `OnOwnerContactIdChange`
  * Event `OnOwnerContactNameChange`
  * Event `OnOwnerDepartmentNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRevisionChange`
  * Event `OnSerialNoChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnVersionChange`

##### SuperOffice.CRM.Rows.ComptrGroupLinkRow is Modified

* Deleted items
  * Event `OnComptrIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ComptrHeadingLinkRow is Modified

* Deleted items
  * Event `OnComptrIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ComptrRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ConfigRow is Modified

* Deleted items
  * Event `OnAdminMailChange`
  * Event `OnAttachmentPathChange`
  * Event `OnAutologoutChange`
  * Event `OnCgiBinChange`
  * Event `OnCgiUrlChange`
  * Event `OnCgiUrlInternalChange`
  * Event `OnDebugFlagsChange`
  * Event `OnDefaultMailChange`
  * Event `OnFeatureToggleChange`
  * Event `OnFlagsChange`
  * Event `OnGfxUrlChange`
  * Event `OnInstalledAtChange`
  * Event `OnInstalledByChange`
  * Event `OnLanguageChange`
  * Event `OnMailheaderChange`
  * Event `OnMbMaxValueChange`
  * Event `OnMbModifierChange`
  * Event `OnMbThresholdChange`
  * Event `OnPanicMailChange`
  * Event `OnSimautologoutChange`
  * Event `OnSmtpHostChange`
  * Event `OnSmtpPortChange`
  * Event `OnTagChange`
  * Event `OnTemplatePathChange`
  * Event `OnTempLicenseChange`
  * Event `OnTextPathChange`
  * Event `OnUniqueIdChange`
  * Event `OnVersionChange`
  * Event `OnWarningChange`

##### SuperOffice.CRM.Rows.ConfigurableScreenDeltaRow is Modified

* Deleted items
  * Event `OnAppliesToChange`
  * Event `OnDeltaJsonChange`
  * Event `OnDeltaStateChange`
  * Event `OnDeltaTypeChange`
  * Event `OnDescriptionChange`
  * Event `OnNameChange`
  * Event `OnRecipeIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ConnectionConfigFieldRow is Modified

* Deleted items
  * Event `OnErpConnectionIdChange`
  * Event `OnFieldKeyChange`
  * Event `OnFieldValueChange`
  * Event `OnQuoteConnectionIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ConsentPersonRow is Modified

* Deleted items
  * Event `OnCommentChange`
  * Event `OnConsentPurposeIdChange`
  * Event `OnConsentSourceIdChange`
  * Event `OnLegalBaseIdChange`
  * Event `OnPersonIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ConsentPurposeRow is Modified

* Deleted items
  * Event `OnActiveChange`
  * Event `OnConsentTextChange`
  * Event `OnDeletedChange`
  * Event `OnFormTextChange`
  * Event `OnKeyChange`
  * Event `OnNameChange`
  * Event `OnPrivacyStatementDescChange`
  * Event `OnPrivacyStatementUrlChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ConsentSourceRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnKeyChange`
  * Event `OnMailTemplateIdChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ContactInterestRow is Modified

* Deleted items
  * Event `OnCinterestIdxChange`
  * Event `OnContactIdChange`
  * Event `OnEndDateChange`
  * Event `OnFlagsChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStartDateChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ContIntGroupLinkRow is Modified

* Deleted items
  * Event `OnContIntIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ContIntHeadingLinkRow is Modified

* Deleted items
  * Event `OnContIntIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ContIntRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CounterValueRow is Modified

* Deleted items
  * Event `OnAmountClassIdChange`
  * Event `OnContactIdChange`
  * Event `OnDirectionChange`
  * Event `OnExtra1CountChange`
  * Event `OnExtra1IdChange`
  * Event `OnExtra2CountChange`
  * Event `OnExtra2IdChange`
  * Event `OnExtra3CountChange`
  * Event `OnExtra4CountChange`
  * Event `OnIntentIdChange`
  * Event `OnLastCompletedChange`
  * Event `OnLastDoByChange`
  * Event `OnLastRegisteredChange`
  * Event `OnNotCompletedChange`
  * Event `OnNotCompletedInPeriodChange`
  * Event `OnPersonIdChange`
  * Event `OnProjectIdChange`
  * Event `OnRecordTypeChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleStatusChange`
  * Event `OnTotalRegChange`
  * Event `OnTotalRegInPeriodChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CountryGroupLinkRow is Modified

* Deleted items
  * Event `OnCountryIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CountryHeadingLinkRow is Modified

* Deleted items
  * Event `OnCountryIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CountryRow is Modified

* Deleted items
  * Event `OnAbbrev2Change`
  * Event `OnAbbrev3Change`
  * Event `OnAddressLayoutChange`
  * Event `OnAddressLayoutDomesticChange`
  * Event `OnAddressLayoutForeignChange`
  * Event `OnCurrencyIdChange`
  * Event `OnCustomPhoneDescChange`
  * Event `OnDefaultLcidChange`
  * Event `OnDeletedChange`
  * Event `OnDialInPrefixChange`
  * Event `OnDialOutPrefixChange`
  * Event `OnDomainNameChange`
  * Event `OnEnglishNameChange`
  * Event `OnFlagresIdChange`
  * Event `OnInterAreaPrefixChange`
  * Event `OnIsBuiltInChange`
  * Event `OnIsoNumberChange`
  * Event `OnNameChange`
  * Event `OnOrgNrTextChange`
  * Event `OnPhonePartOfNAChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnTzLocationIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnZipPrefixChange`

##### SuperOffice.CRM.Rows.CredentialsRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnCommentChange`
  * Event `OnCredentialTypeChange`
  * Event `OnDisplayNameChange`
  * Event `OnDisplayTypeChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnExtraIdChange`
  * Event `OnIsActiveChange`
  * Event `OnLastUsedDateChange`
  * Event `OnLastusedInfoChange`
  * Event `OnPersonIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSearchNameChange`
  * Event `OnSecretChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnValidFromChange`
  * Event `OnValidToChange`

##### SuperOffice.CRM.Rows.CreditedGroupLinkRow is Modified

* Deleted items
  * Event `OnCreditedIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CreditedHeadingLinkRow is Modified

* Deleted items
  * Event `OnCreditedIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CreditedRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CurrencyGroupLinkRow is Modified

* Deleted items
  * Event `OnCurrencyIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CurrencyHeadingLinkRow is Modified

* Deleted items
  * Event `OnCurrencyIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CurrencyRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnIsoCodeChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRateChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUnitsChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CustCategoryRow is Modified

* Deleted items
  * Event `OnCategoryIdChange`
  * Event `OnFullnameChange`
  * Event `OnLanguageIdChange`
  * Event `OnNameChange`
  * Event `OnParentIdChange`

##### SuperOffice.CRM.Rows.CustConfigRow is Modified

* Deleted items
  * Event `OnConfigChange`
  * Event `OnCustLangIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTypeChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.CustLangRow is Modified

* Deleted items
  * Event `OnEmailDomainsChange`
  * Event `OnEmailHeaderChange`
  * Event `OnIsDefaultChange`
  * Event `OnIsoCodeChange`
  * Event `OnKbRootChange`
  * Event `OnLangCodeChange`
  * Event `OnNameChange`
  * Event `OnVirtualDomainChange`
  * Event `OnWebDomainsChange`

##### SuperOffice.CRM.Rows.DashboardRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnColumnsChange`
  * Event `OnDashboardThemeIdChange`
  * Event `OnDescriptionChange`
  * Event `OnGuidChange`
  * Event `OnNameChange`
  * Event `OnPinForAllChange`
  * Event `OnPinForAssociatesChange`
  * Event `OnPinForGroupsChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnVisibleForAllChange`
  * Event `OnVisibleForAssociatesChange`
  * Event `OnVisibleForGroupsChange`

##### SuperOffice.CRM.Rows.DashboardThemeRow is Modified

* Deleted items
  * Event `OnClientChange`
  * Event `OnConfigChange`
  * Event `OnIsBuiltInChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStyleChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.DashboardTileDefinitionRow is Modified

* Deleted items
  * Event `OnCurrencyCodeChange`
  * Event `OnCurrencyModeChange`
  * Event `OnDefaultHeightChange`
  * Event `OnDefaultWidthChange`
  * Event `OnDescriptionChange`
  * Event `OnEntityNameChange`
  * Event `OnEntityTypeChange`
  * Event `OnLayoutConfigChange`
  * Event `OnMeasureByFieldChange`
  * Event `OnMeasureChange`
  * Event `OnMeasureFieldChange`
  * Event `OnNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSecondarySelectionIdChange`
  * Event `OnSelectionIdChange`
  * Event `OnSortByChange`
  * Event `OnTileTypeChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUsageChange`

##### SuperOffice.CRM.Rows.DashboardTileFieldRow is Modified

* Deleted items
  * Event `OnColnameChange`
  * Event `OnDashboardTileDefinitionIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.DashboardTileRow is Modified

* Deleted items
  * Event `OnDashboardIdChange`
  * Event `OnDashboardTileDefinitionIdChange`
  * Event `OnHeightChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnWidthChange`

##### SuperOffice.CRM.Rows.DatabaseModelRow is Modified

* Deleted items
  * Event `OnIsDatabaseUnicodeChange`
  * Event `OnModelDataChange`
  * Event `OnModelVersionChange`

##### SuperOffice.CRM.Rows.DataRightRow is Modified

* Deleted items
  * Event `OnCRUDChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnFieldIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRelationToOwnerChange`
  * Event `OnRoleIdChange`
  * Event `OnTableIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.DbiAgentFieldRow is Modified

* Deleted items
  * Event `OnAgentIdChange`
  * Event `OnFieldNameChange`

##### SuperOffice.CRM.Rows.DbiAgentRow is Modified

* Deleted items
  * Event `OnIdStringChange`
  * Event `OnNameChange`
  * Event `OnPathChange`
  * Event `OnProtocolChange`

##### SuperOffice.CRM.Rows.DbiAgentScheduleRow is Modified

* Deleted items
  * Event `OnAgentIdChange`
  * Event `OnIdStringChange`
  * Event `OnReceivedObjectsChange`
  * Event `OnScheduleIdChange`
  * Event `OnScriptIdChange`
  * Event `OnSentObjectsChange`

##### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRow is Modified

* Deleted items
  * Event `OnDeliveryTermsIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRow is Modified

* Deleted items
  * Event `OnDeliveryTermsIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.DeliveryTermsRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRow is Modified

* Deleted items
  * Event `OnDeliveryTypeIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRow is Modified

* Deleted items
  * Event `OnDeliveryTypeIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.DeliveryTypeRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.DiaryViewRow is Modified

* Deleted items
  * Event `OnAssocIdChange`
  * Event `OnExtraInfoChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnTzLocationIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnVisibleColumnsChange`

##### SuperOffice.CRM.Rows.DiaryViewRowRow is Modified

* Deleted items
  * Event `OnAssocIdChange`
  * Event `OnDiaryViewIdChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.DictionaryBaseRow is Modified

* Deleted items
  * Event `OnCodeChange`
  * Event `OnFlagsChange`
  * Event `OnNameChange`

##### SuperOffice.CRM.Rows.DictionaryRow is Modified

* Deleted items
  * Event `OnBaseIdChange`
  * Event `OnIncludeChange`
  * Event `OnUserIdChange`
  * Event `OnWordChange`

##### SuperOffice.CRM.Rows.DocDocumentRow is Modified

* Deleted items
  * Event `OnAccessLevelChange`
  * Event `OnAttachmentIdChange`
  * Event `OnChangedByChange`
  * Event `OnCreatedAtChange`
  * Event `OnCreatedByChange`
  * Event `OnDescriptionChange`
  * Event `OnFolderIdChange`
  * Event `OnIdStringChange`
  * Event `OnLastChangedChange`
  * Event `OnStatusChange`
  * Event `OnTitleChange`

##### SuperOffice.CRM.Rows.DocFolderRow is Modified

* Deleted items
  * Event `OnAccessLevelChange`
  * Event `OnCreatedAtChange`
  * Event `OnCreatedByChange`
  * Event `OnFolderIdChange`
  * Event `OnFullnameChange`
  * Event `OnInheritedAccessLevelChange`
  * Event `OnStatusChange`
  * Event `OnTitleChange`

##### SuperOffice.CRM.Rows.DocTmplGroupLinkRow is Modified

* Deleted items
  * Event `OnDocTmplIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.DocTmplHeadingLinkRow is Modified

* Deleted items
  * Event `OnDocTmplIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.DocTmplRow is Modified

* Deleted items
  * Event `OnAcceleratorChange`
  * Event `OnAutoeventIdChange`
  * Event `OnDefaultOrefChange`
  * Event `OnDefaultPublishTypeChange`
  * Event `OnDeletedChange`
  * Event `OnDirectionChange`
  * Event `OnEmailSubjectChange`
  * Event `OnFilenameChange`
  * Event `OnIncludeSignatureChange`
  * Event `OnIntentIdChange`
  * Event `OnInvitationDocTypeChange`
  * Event `OnLoadTemplateFromPluginChange`
  * Event `OnMimeTypeChange`
  * Event `OnNameChange`
  * Event `OnPrivacyDocTypeChange`
  * Event `OnQuoteDocTypeChange`
  * Event `OnRankChange`
  * Event `OnRecordTypeChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRegkeyEditChange`
  * Event `OnRegkeyOpenChange`
  * Event `OnRegkeyPrintChange`
  * Event `OnSaveInDbChange`
  * Event `OnSenderEmailAddressChange`
  * Event `OnSenderEmailModeChange`
  * Event `OnShowCurrentsChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.EabEntryRow is Modified

* Deleted items
  * Event `OnDbiAgentIdChange`
  * Event `OnDbiDeleteChange`
  * Event `OnDbiKeyChange`
  * Event `OnDbiLastModifiedChange`
  * Event `OnDbiLastSyncronizedChange`
  * Event `OnEmailAddressChange`
  * Event `OnFolderIdChange`
  * Event `OnNameChange`
  * Event `OnSmsNumberChange`

##### SuperOffice.CRM.Rows.EabFolderRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnFolderIdChange`
  * Event `OnFullnameChange`
  * Event `OnNameChange`

##### SuperOffice.CRM.Rows.EjCategoryGroupLinkRow is Modified

* Deleted items
  * Event `OnEjCategoryIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.EjCategoryRow is Modified

* Deleted items
  * Event `OnAssignmentLagChange`
  * Event `OnCategoryMasterChange`
  * Event `OnClosingStatusChange`
  * Event `OnDelegateCounterChange`
  * Event `OnDelegateMethodChange`
  * Event `OnExternalNameChange`
  * Event `OnFlagsChange`
  * Event `OnFullnameChange`
  * Event `OnMsgClosingStatusChange`
  * Event `OnNameChange`
  * Event `OnNotificationEmailChange`
  * Event `OnParentIdChange`
  * Event `OnReplyTemplateChange`

##### SuperOffice.CRM.Rows.EjMessageRow is Modified

* Deleted items
  * Event `OnAuthorChange`
  * Event `OnBodyAttachmentChange`
  * Event `OnBodyChange`
  * Event `OnCreatedAtChange`
  * Event `OnCreatedByChange`
  * Event `OnCustomerIdChange`
  * Event `OnDebugInfoChange`
  * Event `OnEmailHeaderChange`
  * Event `OnHtmlBodyAttachmentChange`
  * Event `OnHtmlBodyChange`
  * Event `OnHtmlBodyInlineConvertedChange`
  * Event `OnImportantChange`
  * Event `OnInboxChange`
  * Event `OnLanguageChange`
  * Event `OnMailSorterChange`
  * Event `OnMessageCategoryChange`
  * Event `OnMessageIdChange`
  * Event `OnSearchTitleChange`
  * Event `OnSentimentChange`
  * Event `OnSentimentConfidenceChange`
  * Event `OnSlevelChange`
  * Event `OnTicketIdChange`
  * Event `OnTimeChargeChange`
  * Event `OnTimeSpentChange`
  * Event `OnTypeChange`

##### SuperOffice.CRM.Rows.EjpackageItemRow is Modified

* Deleted items
  * Event `OnDomainChange`
  * Event `OnEjpackageChange`
  * Event `OnIdxChange`
  * Event `OnItemIdChange`
  * Event `OnParentIdChange`
  * Event `OnRefNameChange`

##### SuperOffice.CRM.Rows.EjpackageRow is Modified

* Deleted items
  * Event `OnAttachmentIdChange`
  * Event `OnDescriptionChange`
  * Event `OnEjVersionChange`
  * Event `OnInstallScriptChange`
  * Event `OnLockedChange`
  * Event `OnNameChange`
  * Event `OnPackageVersionChange`
  * Event `OnUploadedAtChange`
  * Event `OnUploadedByChange`

##### SuperOffice.CRM.Rows.EjRoleRow is Modified

* Deleted items
  * Event `OnAccessMaskChange`
  * Event `OnAccessValuesChange`
  * Event `OnNameChange`
  * Event `OnUseCategoriesChange`
  * Event `OnUserGroupChange`
  * Event `OnUseUserGroupChange`

##### SuperOffice.CRM.Rows.EjscriptDebugRow is Modified

* Deleted items
  * Event `OnCodeLinePosChange`
  * Event `OnCodeRunUntilChange`
  * Event `OnCodeViewChange`
  * Event `OnDebugIdChange`
  * Event `OnInfoChange`
  * Event `OnSkipCountChange`
  * Event `OnStartedAtChange`
  * Event `OnStatusChange`
  * Event `OnVariableViewChange`

##### SuperOffice.CRM.Rows.EjscriptRow is Modified

* Deleted items
  * Event `OnAccessKeyChange`
  * Event `OnBodyChange`
  * Event `OnDescriptionChange`
  * Event `OnExtraMenusIdChange`
  * Event `OnHierarchyIdChange`
  * Event `OnHtmlOutputChange`
  * Event `OnIncludeIdChange`
  * Event `OnLongDescriptionChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUniqueIdentifierChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.EjselectionRow is Modified

* Deleted items
  * Event `OnAccessLevelChange`
  * Event `OnCreatorChange`
  * Event `OnDisplayPropertiesChange`
  * Event `OnEjTableChange`
  * Event `OnHierarchyIdChange`
  * Event `OnIncludeIdChange`
  * Event `OnLastCountChange`
  * Event `OnLeftMenuChange`
  * Event `OnNameChange`
  * Event `OnResultConfigChange`
  * Event `OnSourceIdChange`
  * Event `OnSourceTypeChange`

##### SuperOffice.CRM.Rows.EjselEjselRow is Modified

* Deleted items
  * Event `OnChildChange`
  * Event `OnOperationChange`
  * Event `OnOrderPosChange`
  * Event `OnParentChange`

##### SuperOffice.CRM.Rows.EjselMetaResultRow is Modified

* Deleted items
  * Event `OnCreatedAtChange`
  * Event `OnEjselectionChange`
  * Event `OnOwnerChange`

##### SuperOffice.CRM.Rows.EjselResultSetRow is Modified

* Deleted items
  * Event `OnMetaResultChange`
  * Event `OnRefIdChange`

##### SuperOffice.CRM.Rows.EjselSourceIdlistRow is Modified

* Deleted items
  * Event `OnNameChange`

##### SuperOffice.CRM.Rows.EjselSourceScriptRow is Modified

* Deleted items
  * Event `OnBodyChange`

##### SuperOffice.CRM.Rows.EjselSourceXmlRow is Modified

* Deleted items
  * Event `OnXmlDataChange`

##### SuperOffice.CRM.Rows.EjuserRow is Modified

* Deleted items
  * Event `OnAccessLevelChange`
  * Event `OnChatStatusChange`
  * Event `OnDateFormatChange`
  * Event `OnDateFormatLongStringChange`
  * Event `OnDateFormatStringChange`
  * Event `OnDbiAgentIdChange`
  * Event `OnDbiKeyChange`
  * Event `OnDbiLastModifiedChange`
  * Event `OnDbiLastSyncronizedChange`
  * Event `OnDefaultCategoryChange`
  * Event `OnDefaultStatusAddMessageChange`
  * Event `OnDefaultStatusNewTicketChange`
  * Event `OnDefaultUserChange`
  * Event `OnDictionaryChange`
  * Event `OnEmailChange`
  * Event `OnEmailMaskChange`
  * Event `OnFirstnameChange`
  * Event `OnFlagsChange`
  * Event `OnHiddenBagBitsetChange`
  * Event `OnIdleTimeChange`
  * Event `OnLanguageChange`
  * Event `OnLastCategoryChange`
  * Event `OnLastLoginAttemptChange`
  * Event `OnLastnameChange`
  * Event `OnLoginAttemptsChange`
  * Event `OnLoginnameChange`
  * Event `OnMiddlenameChange`
  * Event `OnMinuteOffsetChange`
  * Event `OnNewGuiChange`
  * Event `OnNotifyExternalLockChange`
  * Event `OnNotifyExternalSourceChange`
  * Event `OnNotifyMaskChange`
  * Event `OnNotPresentChange`
  * Event `OnNumExpandedMessagesChange`
  * Event `OnPasswordChange`
  * Event `OnPictureIdChange`
  * Event `OnProfileIdChange`
  * Event `OnSignatureChange`
  * Event `OnSimultaneousLoginChange`
  * Event `OnSmsChange`
  * Event `OnSmsMaskChange`
  * Event `OnStatusChange`
  * Event `OnTextareasizeChange`
  * Event `OnTimeFormatStringChange`
  * Event `OnUsergroupChange`
  * Event `OnUsernameChange`

##### SuperOffice.CRM.Rows.ElementProfileRow is Modified

* Deleted items
  * Event `OnConfigChange`
  * Event `OnElementTypeChange`
  * Event `OnFilterFieldChange`
  * Event `OnFilterValueChange`
  * Event `OnNameChange`
  * Event `OnOwnedByUserChange`
  * Event `OnProfileTypeChange`
  * Event `OnScreenDefinitionElementChange`
  * Event `OnStaticElementChange`

##### SuperOffice.CRM.Rows.EmailAccountRow is Modified

* Deleted items
  * Event `OnAccountStatusChange`
  * Event `OnAssociateIdChange`
  * Event `OnDefaultChange`
  * Event `OnEmailAddressChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnErrorCountChange`
  * Event `OnErrorReasonChange`
  * Event `OnIncomingAuthChange`
  * Event `OnOutgoingAuthChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.EmailAttachmentRow is Modified

* Deleted items
  * Event `OnCidChange`
  * Event `OnDescriptionChange`
  * Event `OnDispositionChange`
  * Event `OnEmailItemIdChange`
  * Event `OnEncodingChange`
  * Event `OnFilenameChange`
  * Event `OnSizeChange`
  * Event `OnTypeChange`

##### SuperOffice.CRM.Rows.EmailFolderRow is Modified

* Deleted items
  * Event `OnAccountIdChange`
  * Event `OnAttributesChange`
  * Event `OnFolderSeparatorChange`
  * Event `OnNameChange`
  * Event `OnParentFolderIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.EmailItemRow is Modified

* Deleted items
  * Event `OnAccountIdChange`
  * Event `OnAppointmentIdChange`
  * Event `OnCalDataChange`
  * Event `OnCcChange`
  * Event `OnContactIdChange`
  * Event `OnDocumentIdChange`
  * Event `OnEmailFolderIdChange`
  * Event `OnFlagsChange`
  * Event `OnFromChange`
  * Event `OnHasAttachmentChange`
  * Event `OnHtmlBodyChange`
  * Event `OnInReplyToChange`
  * Event `OnMessageIdChange`
  * Event `OnMimeChange`
  * Event `OnPersonIdChange`
  * Event `OnPlainBodyChange`
  * Event `OnPriorityChange`
  * Event `OnReceivedAtChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRepliedAtChange`
  * Event `OnSaleIdChange`
  * Event `OnSentAtChange`
  * Event `OnServerIdChange`
  * Event `OnSizeChange`
  * Event `OnSubjectChange`
  * Event `OnToChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.EmailRow is Modified

* Deleted items
  * Event `OnAppointmentIdChange`
  * Event `OnBounceCountChange`
  * Event `OnContactIdChange`
  * Event `OnDbiAgentIdChange`
  * Event `OnDescriptionChange`
  * Event `OnEmailAddressChange`
  * Event `OnLastBounceChange`
  * Event `OnLastBounceCodeChange`
  * Event `OnLastBounceReasonChange`
  * Event `OnLastSentChange`
  * Event `OnPersonIdChange`
  * Event `OnProjectIdChange`
  * Event `OnProtocolChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnReservedId1Change`
  * Event `OnReservedId2Change`
  * Event `OnTypeChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ErpConfigurationRow is Modified

* Deleted items
  * Event `OnConnectionRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSyncIntervalChange`
  * Event `OnSyncRunningChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ErpConnectionAccessRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnCanConnectChange`
  * Event `OnCanCreateERPChange`
  * Event `OnErpConnectionIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUserGroupIdChange`

##### SuperOffice.CRM.Rows.ErpConnectionActorTypeRow is Modified

* Deleted items
  * Event `OnActorTypeCrmChange`
  * Event `OnActorTypeErpChange`
  * Event `OnErpConnectionIdChange`
  * Event `OnIsActiveChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ErpConnectionRow is Modified

* Deleted items
  * Event `OnActiveChange`
  * Event `OnAllAccessChange`
  * Event `OnConnectionIdChange`
  * Event `OnDeletedChange`
  * Event `OnDisplayDescriptionChange`
  * Event `OnDisplayNameChange`
  * Event `OnErpConnectorIdChange`
  * Event `OnMostRecentTimestampChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ErpConnectorRow is Modified

* Deleted items
  * Event `OnConfigXmlChange`
  * Event `OnDeletedChange`
  * Event `OnDisplayNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnURLChange`

##### SuperOffice.CRM.Rows.ErpExternalKeyRow is Modified

* Deleted items
  * Event `OnActorTypeChange`
  * Event `OnErpConnectionIdChange`
  * Event `OnErpInternalKeyIdChange`
  * Event `OnErpKeyChange`
  * Event `OnMostRecentTimestampChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ErpFieldRow is Modified

* Deleted items
  * Event `OnAccessChange`
  * Event `OnCrmFieldKeyChange`
  * Event `OnDefaultValueChange`
  * Event `OnDisplayDescriptionChange`
  * Event `OnDisplayNameChange`
  * Event `OnErpConnectionActorTypeIdChange`
  * Event `OnErpFieldKeyChange`
  * Event `OnFieldTypeChange`
  * Event `OnFirstSyncDefaultValueChange`
  * Event `OnHasFirstSyncDefaultValueChange`
  * Event `OnListNameChange`
  * Event `OnListReferenceChange`
  * Event `OnMandatoryChange`
  * Event `OnMaxLengthChange`
  * Event `OnMissingInERPChange`
  * Event `OnPromptUserChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnShowInGuiChange`
  * Event `OnShowInSearchChange`
  * Event `OnSyncToCrmChange`
  * Event `OnSyncToErpChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ErpInternalKeyRow is Modified

* Deleted items
  * Event `OnMostRecentTimestampChange`
  * Event `OnRecordIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTableIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ErpListItemMappingRow is Modified

* Deleted items
  * Event `OnCrmItemKeyChange`
  * Event `OnErpFieldIdChange`
  * Event `OnErpItemKeyChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ErpSyncLogRow is Modified

* Deleted items
  * Event `OnCrmFieldKeyChange`
  * Event `OnErpExternalKeyIdChange`
  * Event `OnErpFieldKeyChange`
  * Event `OnNewValueChange`
  * Event `OnOldValueChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTargetIsCrmChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ExtAppGroupLinkRow is Modified

* Deleted items
  * Event `OnExtAppIdChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ExtAppHeadingLinkRow is Modified

* Deleted items
  * Event `OnExtAppIdChange`
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ExtAppRow is Modified

* Deleted items
  * Event `OnAppTypeChange`
  * Event `OnAvailableInStateChange`
  * Event `OnConfigInfoChange`
  * Event `OnDeletedChange`
  * Event `OnExecuteOnEventChange`
  * Event `OnFilenameChange`
  * Event `OnIconChange`
  * Event `OnNameChange`
  * Event `OnNavigationChange`
  * Event `OnParametersChange`
  * Event `OnPathChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnShowStateChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUrl1Change`
  * Event `OnUrl2Change`
  * Event `OnWaitToFinishChange`
  * Event `OnWindowNameChange`
  * Event `OnWorkdirChange`

##### SuperOffice.CRM.Rows.ExtDatasourceRow is Modified

* Deleted items
  * Event `OnDatabaseTypeChange`
  * Event `OnDatatypeChange`
  * Event `OnDbnameChange`
  * Event `OnFlagsChange`
  * Event `OnHostnameChange`
  * Event `OnLastAccessChange`
  * Event `OnLastUpdateChange`
  * Event `OnNameChange`
  * Event `OnNextUpdateChange`
  * Event `OnPasswordChange`
  * Event `OnPathChange`
  * Event `OnPortChange`
  * Event `OnSqlInitChange`
  * Event `OnUnixSocketChange`
  * Event `OnUpdateCompanyCountChange`
  * Event `OnUpdateCompletionTimeChange`
  * Event `OnUpdateCustomerCountChange`
  * Event `OnUpdateErrorMessageChange`
  * Event `OnUpdateIntervalChange`
  * Event `OnUpdateLockChange`
  * Event `OnUsernameChange`

##### SuperOffice.CRM.Rows.ExternalDocumentRow is Modified

* Deleted items
  * Event `OnAttachmentIdChange`
  * Event `OnChangedByChange`
  * Event `OnCreatedAtChange`
  * Event `OnCreatedByChange`
  * Event `OnDeletedChange`
  * Event `OnDescriptionChange`
  * Event `OnHierarchyIdChange`
  * Event `OnLastChangedChange`
  * Event `OnSMessageChange`
  * Event `OnTitleChange`

##### SuperOffice.CRM.Rows.ExternalEventRow is Modified

* Deleted items
  * Event `OnEventDateChange`
  * Event `OnEventEnabledChange`
  * Event `OnParentRecordChange`
  * Event `OnParentTableChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSignOffAssocIdChange`
  * Event `OnSignOffChange`
  * Event `OnSignOffConfTextIdChange`
  * Event `OnSignOffTaskEnableChange`
  * Event `OnSignOffTaskIdChange`
  * Event `OnSignOffTextIdChange`
  * Event `OnSignOffTriggersAssignChange`
  * Event `OnSignOnAssocIdChange`
  * Event `OnSignOnChange`
  * Event `OnSignOnConfTextIdChange`
  * Event `OnSignOnTaskEnableChange`
  * Event `OnSignOnTaskIdChange`
  * Event `OnSignOnTextIdChange`
  * Event `OnSignOnTriggersAssignChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ExtFieldRow is Modified

* Deleted items
  * Event `OnDatatypeChange`
  * Event `OnExtTableChange`
  * Event `OnFlagsChange`
  * Event `OnNameChange`
  * Event `OnSeqOrderChange`
  * Event `OnTargetChange`

##### SuperOffice.CRM.Rows.ExtraFieldsRow is Modified

* Deleted items
  * Event `OnDefaultValueChange`
  * Event `OnDescriptionChange`
  * Event `OnDomainChange`
  * Event `OnExtraTableChange`
  * Event `OnFieldNameChange`
  * Event `OnFlagsChange`
  * Event `OnNameChange`
  * Event `OnOrderPosChange`
  * Event `OnParamsChange`
  * Event `OnTargetExtraTableChange`
  * Event `OnTypeChange`

##### SuperOffice.CRM.Rows.ExtraMenusRow is Modified

* Deleted items
  * Event `OnBaseProgramChange`
  * Event `OnExtraInfoChange`
  * Event `OnExtraTableChange`
  * Event `OnFlagsChange`
  * Event `OnGroupIdChange`
  * Event `OnIconUrlChange`
  * Event `OnLabelChange`
  * Event `OnOrderPosChange`
  * Event `OnScreenChange`
  * Event `OnTargetChange`
  * Event `OnUrlChange`

##### SuperOffice.CRM.Rows.ExtraTablesEntryRow is Modified

* Deleted items
  * Event `OnEntryIdChange`
  * Event `OnExtraTablesResultChange`
  * Event `OnNextIdChange`
  * Event `OnOrderPosChange`
  * Event `OnPageNumChange`
  * Event `OnPrevIdChange`

##### SuperOffice.CRM.Rows.ExtraTablesResultRow is Modified

* Deleted items
  * Event `OnActivePageChange`
  * Event `OnExtraTableChange`
  * Event `OnLoginIdChange`
  * Event `OnNumEntriesChange`

##### SuperOffice.CRM.Rows.ExtraTablesRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnDisplayFieldChange`
  * Event `OnEditEntryHeaderChange`
  * Event `OnExtraTableNameChange`
  * Event `OnFlagsChange`
  * Event `OnFullnameFieldChange`
  * Event `OnHierarchyIdChange`
  * Event `OnNameChange`
  * Event `OnNewEntryHeaderChange`
  * Event `OnParentFieldChange`
  * Event `OnScreenChooserAllChange`
  * Event `OnScreenChooserEditChange`
  * Event `OnScreenChooserEntryChange`
  * Event `OnSearchHeaderChange`
  * Event `OnSortOrderChange`
  * Event `OnViewEntryHeaderChange`

##### SuperOffice.CRM.Rows.ExtTableRow is Modified

* Deleted items
  * Event `OnChildTableChange`
  * Event `OnExtDatasourceChange`
  * Event `OnLdapSearchBase2Change`
  * Event `OnLdapSearchFilterChange`
  * Event `OnLdapSearchResultChange`
  * Event `OnNameChange`
  * Event `OnParentTableChange`
  * Event `OnPrimaryKeyChange`
  * Event `OnPriorityChange`
  * Event `OnSqlLimitChange`
  * Event `OnSqlQuery2Change`
  * Event `OnSqlQueryChange`
  * Event `OnTargetChange`

##### SuperOffice.CRM.Rows.FavouriteRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnExtraInfoChange`
  * Event `OnRankChange`
  * Event `OnRecordIdChange`
  * Event `OnRegisteredByChange`
  * Event `OnRegisteredChange`
  * Event `OnTableIdChange`

##### SuperOffice.CRM.Rows.FieldLabelRow is Modified

* Deleted items
  * Event `OnActiveChange`
  * Event `OnParentIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnResourceIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ForeignAppRow is Modified

* Deleted items
  * Event `OnNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ForeignDeviceRow is Modified

* Deleted items
  * Event `OnDeviceIdChange`
  * Event `OnForeignappIdChange`
  * Event `OnLastsyncedChange`
  * Event `OnLastsyncedTransChange`
  * Event `OnNameChange`
  * Event `OnOwnerIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ForeignKeyRow is Modified

* Deleted items
  * Event `OnForeigndeviceIdChange`
  * Event `OnRecordIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSeqnoChange`
  * Event `OnSubkeyChange`
  * Event `OnSubvalueChange`
  * Event `OnTableIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.FormKeysRow is Modified

* Deleted items
  * Event `OnFormKeyChange`
  * Event `OnTimeOfEntryChange`

##### SuperOffice.CRM.Rows.FormRow is Modified

* Deleted items
  * Event `OnActiveChange`
  * Event `OnConfigChange`
  * Event `OnDescriptionChange`
  * Event `OnExpiresChange`
  * Event `OnFolderIdChange`
  * Event `OnFormKeyChange`
  * Event `OnGroupIdChange`
  * Event `OnMaxSubmitsChange`
  * Event `OnNameChange`
  * Event `OnNewTicketChange`
  * Event `OnRecipeChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnResponseShipmentIdChange`
  * Event `OnScriptIdChange`
  * Event `OnTypeChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.FormSubmissionRow is Modified

* Deleted items
  * Event `OnContactIdChange`
  * Event `OnEmailAddressChange`
  * Event `OnFormIdChange`
  * Event `OnPersonIdChange`
  * Event `OnProcessingLogChange`
  * Event `OnResponseChange`
  * Event `OnResponseShipmentAddrIdChange`
  * Event `OnStatusChange`
  * Event `OnWhenSubmittedChange`

##### SuperOffice.CRM.Rows.FreeTextIndexRow is Modified

* Deleted items
  * Event `OnContactIdChange`
  * Event `OnFreetextwordsIdChange`
  * Event `OnInfileChange`
  * Event `OnOwnerrecordIdChange`
  * Event `OnOwnertableIdChange`
  * Event `OnRecordIdChange`
  * Event `OnTableIdChange`

##### SuperOffice.CRM.Rows.FreeTextStopWordsRow is Modified

* Deleted items
  * Event `OnWordChange`

##### SuperOffice.CRM.Rows.FreeTextWordsRow is Modified

* Deleted items
  * Event `OnSoundExChange`
  * Event `OnWordChange`

##### SuperOffice.CRM.Rows.FunctionRightRoleLinkRow is Modified

* Deleted items
  * Event `OnEncryptedCheckChange`
  * Event `OnFunctionRightIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRoleIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.FunctionRightRow is Modified

* Deleted items
  * Event `OnEncryptedCheckChange`
  * Event `OnIsBuiltInChange`
  * Event `OnNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRequiredModuleNameChange`
  * Event `OnRightTypeChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.HeadingRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnExtraIdChange`
  * Event `OnListTableIdChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.HelpRow is Modified

* Deleted items
  * Event `OnApplicationAreaIdChange`
  * Event `OnBodyChange`
  * Event `OnLanguageChange`
  * Event `OnModuleIdChange`
  * Event `OnNameChange`
  * Event `OnParentIdChange`
  * Event `OnScreenIdChange`
  * Event `OnSortOrderChange`
  * Event `OnTitleChange`

##### SuperOffice.CRM.Rows.HierarchyRow is Modified

* Deleted items
  * Event `OnDomainChange`
  * Event `OnFullnameChange`
  * Event `OnNameChange`
  * Event `OnParentIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.HistoryRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnExtraIdChange`
  * Event `OnRankChange`
  * Event `OnRecordIdChange`
  * Event `OnTableIdChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.HotlistRow is Modified

* Deleted items
  * Event `OnTicketIdChange`
  * Event `OnUserIdChange`

##### SuperOffice.CRM.Rows.ImportDefaultRow is Modified

* Deleted items
  * Event `OnDbFieldIdChange`
  * Event `OnImportObjectIdChange`
  * Event `OnIntValueChange`
  * Event `OnIsBuiltinChange`
  * Event `OnIsSearchFieldChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStrValueChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ImportFieldRow is Modified

* Deleted items
  * Event `OnDbFieldIdChange`
  * Event `OnGuiCategoryChange`
  * Event `OnImportObjectIdChange`
  * Event `OnIsBuiltinChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTagChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ImportObjectRow is Modified

* Deleted items
  * Event `OnExtensionOfChange`
  * Event `OnIsBuiltinChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnShowInGuiChange`
  * Event `OnTableIdChange`
  * Event `OnTagChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ImportRelationRow is Modified

* Deleted items
  * Event `OnEdgeColourChange`
  * Event `OnForcePrimaryChange`
  * Event `OnForeignKeyChange`
  * Event `OnIsBuiltinChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSourceChange`
  * Event `OnTargetChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.InboxRow is Modified

* Deleted items
  * Event `OnCreatedChange`
  * Event `OnFormatChange`
  * Event `OnImportedChange`
  * Event `OnLockingIdChange`
  * Event `OnMailInFilterChange`
  * Event `OnMailSizeChange`
  * Event `OnNextRetryChange`
  * Event `OnPluginChange`
  * Event `OnStatusChange`
  * Event `OnUidlChange`

##### SuperOffice.CRM.Rows.IntentGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnIntentIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.IntentHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnIntentIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.IntentRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.InvitationRow is Modified

* Deleted items
  * Event `OnAppointmentIdChange`
  * Event `OnEventDtstampChange`
  * Event `OnEventSequenceChange`
  * Event `OnEventUidChange`
  * Event `OnOrganizerEmailChange`
  * Event `OnOrganizerFullnameChange`
  * Event `OnRecurringEndDateChange`
  * Event `OnRecurringStartDateChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.InvoiceEntryRow is Modified

* Deleted items
  * Event `OnDateInvoicedChange`
  * Event `OnDescriptionChange`
  * Event `OnDiscountChange`
  * Event `OnDiscountMoneyChange`
  * Event `OnIeSumChange`
  * Event `OnMessageIdChange`
  * Event `OnPricePrUnitChange`
  * Event `OnQuantityChange`
  * Event `OnTypeChange`

##### SuperOffice.CRM.Rows.InvoiceRow is Modified

* Deleted items
  * Event `OnCompanyIdChange`
  * Event `OnCreatedAtChange`
  * Event `OnCustomerIdChange`
  * Event `OnDescriptionChange`
  * Event `OnPriceChargedChange`
  * Event `OnTimeChargedChange`

##### SuperOffice.CRM.Rows.InvoiceSumRow is Modified

* Deleted items
  * Event `OnBalanceChange`
  * Event `OnCompanyIdChange`
  * Event `OnCustomerIdChange`
  * Event `OnLoginIdChange`
  * Event `OnNameChange`

##### SuperOffice.CRM.Rows.InvoiceTypeRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnFlagsChange`
  * Event `OnNameChange`
  * Event `OnPricePrUnitChange`

##### SuperOffice.CRM.Rows.ItemConfigRow is Modified

* Deleted items
  * Event `OnDomainChange`
  * Event `OnItemIdChange`
  * Event `OnItemNameChange`
  * Event `OnItemValueChange`

##### SuperOffice.CRM.Rows.KbAttachmentRow is Modified

* Deleted items
  * Event `OnAttachmentIdChange`
  * Event `OnEntryIdChange`

##### SuperOffice.CRM.Rows.KbCategoryLogRow is Modified

* Deleted items
  * Event `OnKbCategoryIdChange`
  * Event `OnLogWhenChange`
  * Event `OnUserIdChange`

##### SuperOffice.CRM.Rows.KbCategoryRow is Modified

* Deleted items
  * Event `OnAccessCheckChange`
  * Event `OnAccessLevelChange`
  * Event `OnCreatedByChange`
  * Event `OnDbiAgentIdChange`
  * Event `OnDbiKeyChange`
  * Event `OnDbiLastModifiedChange`
  * Event `OnDbiLastSyncronizedChange`
  * Event `OnDescriptionChange`
  * Event `OnFullnameChange`
  * Event `OnInheritedAccessLevelChange`
  * Event `OnNameChange`
  * Event `OnParentIdChange`
  * Event `OnSortOrderChange`

##### SuperOffice.CRM.Rows.KbEntryCommentRow is Modified

* Deleted items
  * Event `OnAuthorChange`
  * Event `OnBodyChange`
  * Event `OnCustomerIdChange`
  * Event `OnDbiAgentIdChange`
  * Event `OnDbiKeyChange`
  * Event `OnDbiLastModifiedChange`
  * Event `OnDbiLastSyncronizedChange`
  * Event `OnKbEntryIdChange`
  * Event `OnPublishStatusChange`
  * Event `OnTimePostedChange`

##### SuperOffice.CRM.Rows.KbEntryKeywordRow is Modified

* Deleted items
  * Event `OnKbEntryIdChange`
  * Event `OnKeywordChange`

##### SuperOffice.CRM.Rows.KbEntryLogRow is Modified

* Deleted items
  * Event `OnKbEntryIdChange`
  * Event `OnLogWhenChange`
  * Event `OnUserIdChange`

##### SuperOffice.CRM.Rows.KbEntryRow is Modified

* Deleted items
  * Event `OnAccessLevelChange`
  * Event `OnAnswerChange`
  * Event `OnCategoryIdChange`
  * Event `OnCreatedByChange`
  * Event `OnDbiAgentIdChange`
  * Event `OnDbiKeyChange`
  * Event `OnDbiLastModifiedChange`
  * Event `OnDbiLastSyncronizedChange`
  * Event `OnExpireDateChange`
  * Event `OnFlagsChange`
  * Event `OnKeywordsChange`
  * Event `OnLastChangedChange`
  * Event `OnQuestionChange`
  * Event `OnReadCountChange`
  * Event `OnScoreChange`
  * Event `OnScoreWeightChange`
  * Event `OnSortOrderChange`
  * Event `OnStatusChange`
  * Event `OnTitleChange`
  * Event `OnWorkflowPhaseChange`

##### SuperOffice.CRM.Rows.KbEntryWordsRow is Modified

* Deleted items
  * Event `OnEntryOriginChange`
  * Event `OnScoreChange`
  * Event `OnWordChange`

##### SuperOffice.CRM.Rows.KbGroupEntryRow is Modified

* Deleted items
  * Event `OnKbEntryIdChange`
  * Event `OnKbGroupIdChange`
  * Event `OnSortPosChange`

##### SuperOffice.CRM.Rows.KbGroupRow is Modified

* Deleted items
  * Event `OnDbiAgentIdChange`
  * Event `OnDbiKeyChange`
  * Event `OnDbiLastModifiedChange`
  * Event `OnDbiLastSyncronizedChange`
  * Event `OnDescriptionChange`
  * Event `OnKbCategoryIdChange`
  * Event `OnParentIdChange`

##### SuperOffice.CRM.Rows.KbHttpLinkRow is Modified

* Deleted items
  * Event `OnEntryIdChange`
  * Event `OnHttpLinkChange`
  * Event `OnNameChange`

##### SuperOffice.CRM.Rows.KbSolutionFinderEntryRow is Modified

* Deleted items
  * Event `OnKbEntryChange`
  * Event `OnSolutionFinderChange`

##### SuperOffice.CRM.Rows.KbSolutionFinderRow is Modified

* Deleted items
  * Event `OnBodyChange`
  * Event `OnNameChange`
  * Event `OnParentIdChange`

##### SuperOffice.CRM.Rows.KbWorkflowAccessRow is Modified

* Deleted items
  * Event `OnKbAccessChange`
  * Event `OnKbWorkflowChange`
  * Event `OnUserIdChange`

##### SuperOffice.CRM.Rows.KbWorkflowRow is Modified

* Deleted items
  * Event `OnNameChange`
  * Event `OnNextChange`
  * Event `OnPreviousChange`

##### SuperOffice.CRM.Rows.LanguageInfoCountryRow is Modified

* Deleted items
  * Event `OnCountryIdChange`
  * Event `OnIsBuiltInChange`
  * Event `OnIsDefaultChange`
  * Event `OnLanguageIdChange`
  * Event `OnLcidChange`
  * Event `OnOfficialChange`
  * Event `OnPercentageChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.LanguageInfoRow is Modified

* Deleted items
  * Event `OnAbbrev2Change`
  * Event `OnAbbrev3Change`
  * Event `OnDefaultLcidChange`
  * Event `OnEnglishNameChange`
  * Event `OnIsBuiltInChange`
  * Event `OnNativeNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.LegalBaseRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnKeyChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.LegalHtmlTagsRow is Modified

* Deleted items
  * Event `OnHtmlTagChange`

##### SuperOffice.CRM.Rows.LicenseAssocLinkRow is Modified

* Deleted items
  * Event `OnAssocIdChange`
  * Event `OnCommentChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnLicenseNumberChange`
  * Event `OnModuleLicenseIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnValidFromChange`
  * Event `OnValidToChange`

##### SuperOffice.CRM.Rows.LicenseSatlLinkRow is Modified

* Deleted items
  * Event `OnCommentChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnLicenseNumberChange`
  * Event `OnModuleLicenseIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSatelliteIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnValidFromChange`
  * Event `OnValidToChange`

##### SuperOffice.CRM.Rows.LocaleTextRow is Modified

* Deleted items
  * Event `OnIsBuiltinChange`
  * Event `OnLanguageIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnResourceIdChange`
  * Event `OnTextChange`
  * Event `OnTypeIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.LockingRow is Modified

* Deleted items
  * Event `OnErrorMessageChange`
  * Event `OnExecutionTimeChange`
  * Event `OnLastErrorChange`
  * Event `OnLastExecutionChange`
  * Event `OnLockExpireChange`
  * Event `OnLockPidChange`
  * Event `OnLockTtlChange`
  * Event `OnRetriesChange`
  * Event `OnStatusChange`
  * Event `OnStopChange`

##### SuperOffice.CRM.Rows.LogDebugRow is Modified

* Deleted items
  * Event `OnInfoChange`
  * Event `OnTimeOfEntryChange`

##### SuperOffice.CRM.Rows.LogEventsRow is Modified

* Deleted items
  * Event `OnEventGroupChange`
  * Event `OnEventIdChange`
  * Event `OnEventTypeChange`
  * Event `OnSourceUserChange`
  * Event `OnSourceUserDescChange`
  * Event `OnTargetIdChange`
  * Event `OnTimeOfEventChange`
  * Event `OnVar1Change`
  * Event `OnVar2Change`
  * Event `OnVar3Change`
  * Event `OnVar4Change`
  * Event `OnVar5Change`

##### SuperOffice.CRM.Rows.LoginCustomerRow is Modified

* Deleted items
  * Event `OnCreatedAtChange`
  * Event `OnCustomerIdChange`
  * Event `OnErrorMessageChange`
  * Event `OnExpireChange`
  * Event `OnLoginOriginChange`
  * Event `OnRemoteAddrChange`
  * Event `OnRemoteHostChange`
  * Event `OnSecondsToLiveChange`
  * Event `OnSessionKeyChange`

##### SuperOffice.CRM.Rows.LoginRow is Modified

* Deleted items
  * Event `OnActiveMenuChange`
  * Event `OnAuthenticationTypeChange`
  * Event `OnErrorMessageChange`
  * Event `OnFlagsChange`
  * Event `OnIdleChange`
  * Event `OnLoggedInChange`
  * Event `OnLoginOriginChange`
  * Event `OnNsSecretChange`
  * Event `OnRemoteAddrChange`
  * Event `OnRemoteHostChange`
  * Event `OnSessionKeyChange`
  * Event `OnStatusChange`
  * Event `OnUserIdChange`

##### SuperOffice.CRM.Rows.MailAliasRow is Modified

* Deleted items
  * Event `OnAliasChange`
  * Event `OnFilterIdChange`

##### SuperOffice.CRM.Rows.MailBlockRow is Modified

* Deleted items
  * Event `OnLastUpdateChange`
  * Event `OnMailAddrChange`
  * Event `OnTimePoolChange`

##### SuperOffice.CRM.Rows.MailInFilterRow is Modified

* Deleted items
  * Event `OnAddressChange`
  * Event `OnAiSuggestCategoryChange`
  * Event `OnAiTextAnalysisChange`
  * Event `OnAutofaqChange`
  * Event `OnAutofaqKbCategoryChange`
  * Event `OnCategoryIdChange`
  * Event `OnCheckwaitChange`
  * Event `OnDomainChange`
  * Event `OnImportmailPidChange`
  * Event `OnKeepHeadersChange`
  * Event `OnLanguageIdChange`
  * Event `OnLastErrorChange`
  * Event `OnLastSuccessChange`
  * Event `OnLastTryChange`
  * Event `OnMailgunDsnChange`
  * Event `OnNextCheckChange`
  * Event `OnNoautoreplyChange`
  * Event `OnNumSeqFailuresChange`
  * Event `OnPopPasswordChange`
  * Event `OnPopServerChange`
  * Event `OnPopUserChange`
  * Event `OnPriorityChange`
  * Event `OnReplyTemplateIdChange`
  * Event `OnServerTypeChange`
  * Event `OnStatusChange`

##### SuperOffice.CRM.Rows.MailInUidlRow is Modified

* Deleted items
  * Event `OnFilterIdChange`
  * Event `OnLastCheckedChange`
  * Event `OnRetriesChange`
  * Event `OnStatusChange`
  * Event `OnUidlChange`

##### SuperOffice.CRM.Rows.MergeMoveLogRow is Modified

* Deleted items
  * Event `OnDestinationRecordChange`
  * Event `OnOperationChange`
  * Event `OnOptionsChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSourceRecordChange`
  * Event `OnTableNumberChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.MessageCustomersRow is Modified

* Deleted items
  * Event `OnCustomerIdChange`
  * Event `OnEmailChange`
  * Event `OnMessageIdChange`

##### SuperOffice.CRM.Rows.MessageHandlerRow is Modified

* Deleted items
  * Event `OnMachineChange`
  * Event `OnPortChange`
  * Event `OnProcessIdHighChange`
  * Event `OnProcessIdLowChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRoleChange`
  * Event `OnUniqueIdentifierChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.MessageHeaderRow is Modified

* Deleted items
  * Event `OnHeaderValueChange`
  * Event `OnMessageIdChange`
  * Event `OnNameChange`
  * Event `OnStdItemChange`
  * Event `OnStdItemColChange`
  * Event `OnTypeChange`

##### SuperOffice.CRM.Rows.MessageIdRow is Modified

* Deleted items
  * Event `OnDomainChange`
  * Event `OnItemIdChange`
  * Event `OnMessageIdChange`

##### SuperOffice.CRM.Rows.MessageRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnDetailsRecordChange`
  * Event `OnDetailsTableChange`
  * Event `OnMessageTypeChange`
  * Event `OnMotherIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSourceHandlerChange`
  * Event `OnTargetHandlerChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ModuleLicenseRow is Modified

* Deleted items
  * Event `OnAllowedAssocsMaskChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnExtraFlagsChange`
  * Event `OnExtraInfoChange`
  * Event `OnHiddenChange`
  * Event `OnLicenseNumberChange`
  * Event `OnLicenseTypeChange`
  * Event `OnModuleDescriptionChange`
  * Event `OnModuleNameChange`
  * Event `OnModuleOwnerIdChange`
  * Event `OnModuleVersionChange`
  * Event `OnPrerequisiteModuleChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSignatureChange`
  * Event `OnSortOrderChange`
  * Event `OnTooltipChange`
  * Event `OnUnrestrictedChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ModuleOwnerRow is Modified

* Deleted items
  * Event `OnAdminWarningDateChange`
  * Event `OnDeploymentTypeChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnExpirationChange`
  * Event `OnExtraFlagsChange`
  * Event `OnExtraInfoChange`
  * Event `OnGraceToChange`
  * Event `OnLicenseUrlChange`
  * Event `OnLicenseVersionChange`
  * Event `OnMaintenanceToChange`
  * Event `OnNextCheckDateChange`
  * Event `OnOwnerDescriptionChange`
  * Event `OnOwnerNameChange`
  * Event `OnProductTypeChange`
  * Event `OnProductTypeDescriptionChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSignatureChange`
  * Event `OnSignedPublicKeyChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.MrMrsGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnMrMrsIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.MrMrsHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnMrMrsIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.MrMrsRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.MsFilterMailRow is Modified

* Deleted items
  * Event `OnMailInFilterIdChange`
  * Event `OnMailSorterIdChange`

##### SuperOffice.CRM.Rows.MsFilterRow is Modified

* Deleted items
  * Event `OnActionChange`
  * Event `OnActionWhenChange`
  * Event `OnAutofaqReplyCategoryChange`
  * Event `OnBodyTemplateChange`
  * Event `OnDescriptionChange`
  * Event `OnEjscriptChange`
  * Event `OnFlagsChange`
  * Event `OnForwardToChange`
  * Event `OnNewCategoryChange`
  * Event `OnNewOwnerChange`
  * Event `OnNewPriorityChange`
  * Event `OnNewSlevelChange`
  * Event `OnNewTagsChange`
  * Event `OnParseModeChange`
  * Event `OnPriorityChange`
  * Event `OnReplyTemplateChange`
  * Event `OnReplyToChange`
  * Event `OnReplyToSmsChange`
  * Event `OnSearchLocationChange`
  * Event `OnSearchString2Change`
  * Event `OnSearchStringChange`

##### SuperOffice.CRM.Rows.MsSubstituteRow is Modified

* Deleted items
  * Event `OnFlagsChange`
  * Event `OnMsFilterIdChange`
  * Event `OnParserNameChange`
  * Event `OnSubstTypeChange`
  * Event `OnTheRegexpChange`

##### SuperOffice.CRM.Rows.MsTrashbinRow is Modified

* Deleted items
  * Event `OnMailInFilterIdChange`
  * Event `OnMailSorterIdChange`
  * Event `OnSubjectChange`
  * Event `OnWhenTrashedChange`

##### SuperOffice.CRM.Rows.NoticeFrameRow is Modified

* Deleted items
  * Event `OnAverageDtChange`
  * Event `OnErrorDChange`
  * Event `OnErrorIChange`
  * Event `OnErrorPChange`
  * Event `OnRefreshRateChange`
  * Event `OnT0Change`

##### SuperOffice.CRM.Rows.NotifyRow is Modified

* Deleted items
  * Event `OnCategoryIdChange`
  * Event `OnChatNickNameChange`
  * Event `OnChatTopicIdChange`
  * Event `OnCustomMessageChange`
  * Event `OnCustomUrlChange`
  * Event `OnExpiresChange`
  * Event `OnOwnerIdChange`
  * Event `OnTicketAlertIdChange`
  * Event `OnTicketIdChange`
  * Event `OnTypeChange`
  * Event `OnUser2IdChange`
  * Event `OnUserIdChange`

##### SuperOffice.CRM.Rows.OLEFieldRow is Modified

* Deleted items
  * Event `OnAlgoDataChange`
  * Event `OnAlgoTypeChange`
  * Event `OnDatatypeChange`
  * Event `OnFieldIdChange`
  * Event `OnLengthChange`
  * Event `OnOLEViewIdChange`
  * Event `OnPredefinedChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSearchableChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.OLEFieldTextRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnLanguageIdChange`
  * Event `OnNameChange`
  * Event `OnOLEFieldIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.OLESubjectRow is Modified

* Deleted items
  * Event `OnPredefinedChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.OLESubjectTextRow is Modified

* Deleted items
  * Event `OnLanguageIdChange`
  * Event `OnNameChange`
  * Event `OnOLESubjectIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.OLEViewRow is Modified

* Deleted items
  * Event `OnOLESubjectIdChange`
  * Event `OnPredefinedChange`
  * Event `OnProgIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.OLEViewTextRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnLanguageIdChange`
  * Event `OnNameChange`
  * Event `OnOLEViewIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.OnlineAppRow is Modified

* Deleted items
  * Event `OnAuthorizationRevokedChange`
  * Event `OnClientIdChange`
  * Event `OnDisplayNameChange`
  * Event `OnLastUsedChange`
  * Event `OnPartnerNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.OutboxRow is Modified

* Deleted items
  * Event `OnCreatedChange`
  * Event `OnFromEmailChange`
  * Event `OnFromEnvelopeChange`
  * Event `OnLastErrorChange`
  * Event `OnMailSizeChange`
  * Event `OnMessageIdChange`
  * Event `OnNextRetryChange`
  * Event `OnPidChange`
  * Event `OnRcptChange`
  * Event `OnRetriesChange`
  * Event `OnRfc822ContentChange`
  * Event `OnStatusChange`
  * Event `OnSubjectChange`
  * Event `OnTicketIdChange`
  * Event `OnTypeChange`

##### SuperOffice.CRM.Rows.OutgoingMessageRow is Modified

* Deleted items
  * Event `OnExternalMessageIdChange`
  * Event `OnPluginChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSessionKeyChange`
  * Event `OnStatusChange`
  * Event `OnStatusDescriptionChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`

##### SuperOffice.CRM.Rows.OwnerContactLinkRow is Modified

* Deleted items
  * Event `OnContactIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRemarkChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PasswordRulesRow is Modified

* Deleted items
  * Event `OnFlagsChange`
  * Event `OnMinCharactersChange`
  * Event `OnMinLowercaseChange`
  * Event `OnMinNumbersChange`
  * Event `OnMinSpecialChange`
  * Event `OnMinUppercaseChange`

##### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnPaymentTermsIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnPaymentTermsIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PaymentTermsRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnPaymentTypeIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnPaymentTypeIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PaymentTypeRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PersIntGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnPersIntIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PersIntHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnPersIntIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PersIntRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PersonInterestRow is Modified

* Deleted items
  * Event `OnEndDateChange`
  * Event `OnFlagsChange`
  * Event `OnPersonIdChange`
  * Event `OnPinterestIdxChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStartDateChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PersPosGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnPersPosIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PersPosHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnPersPosIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PersPosRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PhoneFormatRow is Modified

* Deleted items
  * Event `OnAreaCodeLengthChange`
  * Event `OnCountryIdChange`
  * Event `OnDescriptionChange`
  * Event `OnDontFormatChange`
  * Event `OnIsActiveChange`
  * Event `OnIsBuiltInChange`
  * Event `OnLocalLengthChange`
  * Event `OnMaskChange`
  * Event `OnPrefixChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PhoneRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnOwnerIdChange`
  * Event `OnPhoneChange`
  * Event `OnPtypeIdxChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSearchPhoneNumberChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnValidFromChange`
  * Event `OnValidToChange`

##### SuperOffice.CRM.Rows.PMembTypeGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnPMembTypeIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnPMembTypeIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PMembTypeRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PrefDescLineRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnIsBuiltinChange`
  * Event `OnPrefDescIdChange`
  * Event `OnPrefShowValueChange`
  * Event `OnPrefValueChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PrefDescRow is Modified

* Deleted items
  * Event `OnAccessFlagsChange`
  * Event `OnDescriptionChange`
  * Event `OnIsBuiltinChange`
  * Event `OnMaxLevelChange`
  * Event `OnMaxValueChange`
  * Event `OnMinLevelChange`
  * Event `OnMinValueChange`
  * Event `OnNameChange`
  * Event `OnPrefkeyChange`
  * Event `OnPrefsectionChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRequiredLicenseChange`
  * Event `OnSubGroupChange`
  * Event `OnSysMaxLevelChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnValueTypeChange`

##### SuperOffice.CRM.Rows.PreferenceRow is Modified

* Deleted items
  * Event `OnPdataChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTypeChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PriceListRow is Modified

* Deleted items
  * Event `OnCurrencyIdChange`
  * Event `OnDescriptionChange`
  * Event `OnERPPriceListKeyChange`
  * Event `OnIsActiveChange`
  * Event `OnIsERPCopyChange`
  * Event `OnNameChange`
  * Event `OnQuoteConnectionIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnValidFromChange`
  * Event `OnValidToChange`

##### SuperOffice.CRM.Rows.PriceUnitGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnPriceUnitIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnPriceUnitIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PriceUnitRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PriorityGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnPriorityIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PriorityHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnPriorityIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PriorityRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProbGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnProbIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProbHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnProbIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProbRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnProbabilityChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnProductCategoryIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnProductCategoryIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProductCategoryRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnProductFamilyIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnProductFamilyIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProductFamilyRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProductRow is Modified

* Deleted items
  * Event `OnCodeChange`
  * Event `OnDefaultSubscriptionQuantityChange`
  * Event `OnDescriptionChange`
  * Event `OnERPProductKeyChange`
  * Event `OnExtraField1Change`
  * Event `OnExtraField2Change`
  * Event `OnExtraField3Change`
  * Event `OnExtraField4Change`
  * Event `OnExtraField5Change`
  * Event `OnExtraInfoChange`
  * Event `OnInAssortmentChange`
  * Event `OnIsSubscriptionChange`
  * Event `OnItemNumberChange`
  * Event `OnNameChange`
  * Event `OnPriceListIdChange`
  * Event `OnPriceUnitChange`
  * Event `OnProductCategoryKeyChange`
  * Event `OnProductFamilyKeyChange`
  * Event `OnProductTypeKeyChange`
  * Event `OnQuantityUnitChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRightsChange`
  * Event `OnRuleChange`
  * Event `OnSubscriptionUnitChange`
  * Event `OnSupplierChange`
  * Event `OnSupplierCodeChange`
  * Event `OnUnitCostChange`
  * Event `OnUnitListPriceChange`
  * Event `OnUnitMinimumPriceChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUrlChange`
  * Event `OnVATChange`
  * Event `OnVATInfoChange`

##### SuperOffice.CRM.Rows.ProductTypeGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnProductTypeIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnProductTypeIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProductTypeRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProductVersionRow is Modified

* Deleted items
  * Event `OnCodeNameChange`
  * Event `OnCommentChange`
  * Event `OnOwnerNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUpdatePathChange`
  * Event `OnVersionChange`

##### SuperOffice.CRM.Rows.ProfileRow is Modified

* Deleted items
  * Event `OnListCompaniesHeader2Change`
  * Event `OnListCompaniesHeaderChange`
  * Event `OnListCustomersHeader2Change`
  * Event `OnListCustomersHeaderChange`
  * Event `OnListTicketHeaderChange`
  * Event `OnListTicketsHeader2Change`
  * Event `OnListTicketsHeaderChange`
  * Event `OnNameChange`
  * Event `OnUserIdChange`

##### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnProjStatusIdChange`
  * Event `OnProjTypeIdChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProjStatusGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnProjStatusIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnProjStatusIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProjStatusRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProjTypeGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnProjTypeIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnProjTypeIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ProjTypeRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnDurationUnitChange`
  * Event `OnHasGuideChange`
  * Event `OnIsAutoAdvanceChange`
  * Event `OnNameChange`
  * Event `OnProjectDurationChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PublishRow is Modified

* Deleted items
  * Event `OnEncryptedCheckChange`
  * Event `OnEventDateChange`
  * Event `OnPublishFromChange`
  * Event `OnPublishToChange`
  * Event `OnPublishTypeChange`
  * Event `OnRecordIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTableNumberChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.PushNotificationServiceRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnDeviceDisplayNameChange`
  * Event `OnDeviceIdentifierChange`
  * Event `OnDevicePlatformChange`
  * Event `OnLanguageChange`
  * Event `OnLastNotificationDateChange`
  * Event `OnOSVersionChange`
  * Event `OnPNSHandleChange`
  * Event `OnPNSHandleUpdateDateChange`
  * Event `OnPocketVersionChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTagsChange`
  * Event `OnTimeZoneIdChange`
  * Event `OnTotalNotificationCountChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.QuickReplyRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnHtmlBodyChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.QuoteAlternativeRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnDiscountAmountChange`
  * Event `OnDiscountPercentChange`
  * Event `OnEarningAmountChange`
  * Event `OnEarningPercentChange`
  * Event `OnERPDiscountAmountChange`
  * Event `OnERPDiscountPercentChange`
  * Event `OnERPQuoteAlternativeKeyChange`
  * Event `OnExtraField1Change`
  * Event `OnExtraField2Change`
  * Event `OnExtraField3Change`
  * Event `OnExtraField4Change`
  * Event `OnExtraField5Change`
  * Event `OnNameChange`
  * Event `OnQuoteVersionIdChange`
  * Event `OnReasonChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStatusChange`
  * Event `OnTotalPriceChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUserValueOverrideChange`
  * Event `OnVATChange`
  * Event `OnVATInfoChange`

##### SuperOffice.CRM.Rows.QuoteConnectionAccessRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnQuoteConnectionIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUserGroupIdChange`

##### SuperOffice.CRM.Rows.QuoteConnectionRow is Modified

* Deleted items
  * Event `OnAllAccessChange`
  * Event `OnConnectorNameChange`
  * Event `OnDeletedChange`
  * Event `OnDisplayDescriptionChange`
  * Event `OnDisplayNameChange`
  * Event `OnErpConnectionIdChange`
  * Event `OnERPNameChange`
  * Event `OnExtraDataChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.QuoteLineConfigurationRow is Modified

* Deleted items
  * Event `OnEditableChange`
  * Event `OnFieldNameChange`
  * Event `OnInUseChange`
  * Event `OnLabelResChange`
  * Event `OnMandatoryChange`
  * Event `OnPreventHideChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRestrictEditChange`
  * Event `OnTooltipResChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.QuoteLineRow is Modified

* Deleted items
  * Event `OnCodeChange`
  * Event `OnDeliveredQuantityChange`
  * Event `OnDescriptionChange`
  * Event `OnDiscountAmountChange`
  * Event `OnDiscountPercentChange`
  * Event `OnEarningAmountChange`
  * Event `OnEarningPercentChange`
  * Event `OnERPDiscountAmountChange`
  * Event `OnERPDiscountPercentChange`
  * Event `OnERPProductKeyChange`
  * Event `OnERPQuoteLineKeyChange`
  * Event `OnExtraField1Change`
  * Event `OnExtraField2Change`
  * Event `OnExtraField3Change`
  * Event `OnExtraField4Change`
  * Event `OnExtraField5Change`
  * Event `OnExtraInfoChange`
  * Event `OnIsSubscriptionChange`
  * Event `OnItemNumberChange`
  * Event `OnNameChange`
  * Event `OnPriceUnitChange`
  * Event `OnProductCategoryKeyChange`
  * Event `OnProductFamilyKeyChange`
  * Event `OnProductTypeKeyChange`
  * Event `OnQuantityChange`
  * Event `OnQuantityUnitChange`
  * Event `OnQuoteAlternativeIdChange`
  * Event `OnRankChange`
  * Event `OnReasonChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRightsChange`
  * Event `OnRuleChange`
  * Event `OnStatusChange`
  * Event `OnSubscriptionQuantityChange`
  * Event `OnSubscriptionStartChange`
  * Event `OnSubscriptionUnitChange`
  * Event `OnSupplierChange`
  * Event `OnSupplierCodeChange`
  * Event `OnTotalPriceChange`
  * Event `OnUnitCostChange`
  * Event `OnUnitListPriceChange`
  * Event `OnUnitMinimumPriceChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUrlChange`
  * Event `OnUserValueOverrideChange`
  * Event `OnVATChange`
  * Event `OnVATInfoChange`

##### SuperOffice.CRM.Rows.QuoteRow is Modified

* Deleted items
  * Event `OnAcceptedQuoteAlternativeIdChange`
  * Event `OnActiveQuoteVersionIdChange`
  * Event `OnDocumentIdChange`
  * Event `OnERPOrderKeyChange`
  * Event `OnERPQuoteKeyChange`
  * Event `OnOrderCommentChange`
  * Event `OnPoNumberChange`
  * Event `OnPreferredEmailCultureChange`
  * Event `OnQuoteConnectionIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUseValuesFromQuoteChange`

##### SuperOffice.CRM.Rows.QuoteVersionAttachmentRow is Modified

* Deleted items
  * Event `OnDocumentIdChange`
  * Event `OnIncludedChange`
  * Event `OnQuoteVersionIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.QuoteVersionRecordData is Modified

* New items
  * Field `RequestAssociateId`
  * Field `RequestComment`

##### SuperOffice.CRM.Rows.QuoteVersionRow is Modified

* Deleted items
  * Event `OnApprovedByChange`
  * Event `OnApprovedRegisteredByChange`
  * Event `OnApprovedRegisteredDateChange`
  * Event `OnApprovedTextChange`
  * Event `OnArchivedStateChange`
  * Event `OnDeliveryCountryIdChange`
  * Event `OnDescriptionChange`
  * Event `OnERPDeliveryTermsKeyChange`
  * Event `OnERPDeliveryTypeKeyChange`
  * Event `OnERPPaymentTermsKeyChange`
  * Event `OnERPPaymentTypeKeyChange`
  * Event `OnERPQuoteVersionKeyChange`
  * Event `OnExpirationDateChange`
  * Event `OnExtraField1Change`
  * Event `OnExtraField2Change`
  * Event `OnExtraField3Change`
  * Event `OnExtraField4Change`
  * Event `OnExtraField5Change`
  * Event `OnFollowupIdChange`
  * Event `OnHasOwnDeliveryAddressChange`
  * Event `OnHasOwnInvoiceAddressChange`
  * Event `OnInvoiceCountryIdChange`
  * Event `OnLastRecalculatedChange`
  * Event `OnLikelyQuoteAlternativeIdChange`
  * Event `OnNumberChange`
  * Event `OnQuoteIdChange`
  * Event `OnRankChange`
  * Event `OnReasonChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSentDateChange`
  * Event `OnStateChange`
  * Event `OnStatusChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
* New items
  * Property `RequestAssociateId`
  * Property `RequestComment`

##### SuperOffice.CRM.Rows.ReasonGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnReasonIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ReasonHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnReasonIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ReasonRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnReasonSoldIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnReasonSoldIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ReasonSoldRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnReasonStalledIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnReasonStalledIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ReasonStalledRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.RecurrenceRuleRow is Modified

* Deleted items
  * Event `OnCyclicDayChange`
  * Event `OnCyclicMonthChange`
  * Event `OnCyclicWeekChange`
  * Event `OnEndDateChange`
  * Event `OnPatternChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStartDateChange`
  * Event `OnSubPatternChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnWeekdaysChange`

##### SuperOffice.CRM.Rows.RedLetterDayRow is Modified

* Deleted items
  * Event `OnColorChange`
  * Event `OnColoredChange`
  * Event `OnCountryIdChange`
  * Event `OnExtraFlagsChange`
  * Event `OnReddateChange`
  * Event `OnRedsChange`
  * Event `OnRgbColourChange`
  * Event `OnTextChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.RefCountRangeRow is Modified

* Deleted items
  * Event `OnHighestInUseChange`
  * Event `OnRangeSizeChange`
  * Event `OnRangeStartChange`
  * Event `OnRefCountsIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTravellerIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.RefCountsRow is Modified

* Deleted items
  * Event `OnCurrentValueChange`
  * Event `OnFieldIdChange`
  * Event `OnFlagsChange`
  * Event `OnRecordIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSatPrefixChange`
  * Event `OnTravelPrefixChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.RegistryRow is Modified

* Deleted items
  * Event `OnNameChange`
  * Event `OnRegIdChange`
  * Event `OnRegValueChange`

##### SuperOffice.CRM.Rows.RejectReasonGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRejectreasonIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRejectreasonIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.RejectReasonRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnReldefIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnReldefIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.RelationDefinitionRow is Modified

* Deleted items
  * Event `OnDefcommentChange`
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnPassiveTextChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.RelationsRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnDestinationRecordChange`
  * Event `OnDestinationTableChange`
  * Event `OnEndDateChange`
  * Event `OnGroupIdxChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRelcommentChange`
  * Event `OnReldefIdChange`
  * Event `OnRelFlagsChange`
  * Event `OnReversedChange`
  * Event `OnSourceRecordChange`
  * Event `OnSourceTableChange`
  * Event `OnStartDateChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.RelationTargetRow is Modified

* Deleted items
  * Event `OnBidirectionalChange`
  * Event `OnDestinationTableChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnReldefIdChange`
  * Event `OnSourceTableChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRow is Modified

* Deleted items
  * Event `OnAttachmentIdChange`
  * Event `OnEntryIdChange`

##### SuperOffice.CRM.Rows.ReplyTemplateBodyRecordData is Modified

* Modified items
  * Field `Flags`

##### SuperOffice.CRM.Rows.ReplyTemplateBodyRow is Modified

* Deleted items
  * Event `OnBodyHtmlChange`
  * Event `OnBodyPlainChange`
  * Event `OnBodySmsChange`
  * Event `OnFlagsChange`
  * Event `OnHeadersChange`
  * Event `OnLanguageIdChange`
  * Event `OnReplyTemplateIdChange`
  * Event `OnSubjectChange`
* Modified items
  * Property `Flags`

##### SuperOffice.CRM.Rows.ReplyTemplateFolderRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnFlagsChange`
  * Event `OnFullnameChange`
  * Event `OnNameChange`
  * Event `OnParentIdChange`

##### SuperOffice.CRM.Rows.ReplyTemplateRow is Modified

* Deleted items
  * Event `OnAccessLevelChange`
  * Event `OnDescriptionChange`
  * Event `OnFlagsChange`
  * Event `OnFolderIdChange`
  * Event `OnLastChangedChange`
  * Event `OnNameChange`
  * Event `OnOwnedByChange`

##### SuperOffice.CRM.Rows.ReporterListDefRow is Modified

* Deleted items
  * Event `OnListSourceChange`
  * Event `OnOleFieldKeyChange`
  * Event `OnOleFieldNameChange`
  * Event `OnOleViewIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ResourceOverrideRow is Modified

* Deleted items
  * Event `OnCultureChange`
  * Event `OnIsActiveChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnResourceNameChange`
  * Event `OnResourceValueChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.RoleCategoryRow is Modified

* Deleted items
  * Event `OnCategoryChange`
  * Event `OnCrmRoleChange`
  * Event `OnRoleChange`

##### SuperOffice.CRM.Rows.RoleElementRow is Modified

* Deleted items
  * Event `OnCrmRoleChange`
  * Event `OnElementProfileChange`
  * Event `OnRoleChange`

##### SuperOffice.CRM.Rows.RoleMemberRow is Modified

* Deleted items
  * Event `OnEjuserChange`
  * Event `OnRoleChange`

##### SuperOffice.CRM.Rows.RoleRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRoleTypeChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUseCategoriesChange`

##### SuperOffice.CRM.Rows.RoleWorkflowRow is Modified

* Deleted items
  * Event `OnCrmRoleChange`
  * Event `OnRoleChange`
  * Event `OnWorkflowAccessChange`
  * Event `OnWorkflowIdChange`

##### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(ImageEmbedType&, FieldInfo)`
  * Method `ValidateField(MessageActionType&, FieldInfo)`
  * Method `ValidateField(MessageHeaderStdItem&, FieldInfo)`
  * Method `ValidateField(MessageHeaderStdItemCol&, FieldInfo)`
  * Method `ValidateField(RecipientType&, FieldInfo)`
  * Method `ValidateField(TargetAssignementLevel&, FieldInfo)`
  * Method `ValidateField(TargetMeasurementUnit&, FieldInfo)`

##### SuperOffice.CRM.Rows.SaintConfigurationRow is Modified

* Deleted items
  * Event `OnEnabledChange`
  * Event `OnGenerationEndChange`
  * Event `OnGenerationStartChange`
  * Event `OnOwnerTableChange`
  * Event `OnPeriod1Change`
  * Event `OnPeriod2Change`
  * Event `OnPeriod3Change`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRowsGeneratedChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SaleHistRow is Modified

* Deleted items
  * Event `OnActiveLinksChange`
  * Event `OnAmountChange`
  * Event `OnAppointmentIdChange`
  * Event `OnAssociateIdChange`
  * Event `OnComptrIdChange`
  * Event `OnContactIdChange`
  * Event `OnCreditedIdChange`
  * Event `OnCurrencyIdChange`
  * Event `OnDoneChange`
  * Event `OnEarningChange`
  * Event `OnEarningPercentChange`
  * Event `OnGroupIdxChange`
  * Event `OnHeadingChange`
  * Event `OnNddAppointmentIdChange`
  * Event `OnNextDueDateChange`
  * Event `OnNumber1Change`
  * Event `OnPersonIdChange`
  * Event `OnPostitTextIdChange`
  * Event `OnProbabilityChange`
  * Event `OnProbabilityIdxChange`
  * Event `OnProjectIdChange`
  * Event `OnReasonIdChange`
  * Event `OnReasonSoldIdChange`
  * Event `OnReasonStalledIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnReopenDateChange`
  * Event `OnSaledateChange`
  * Event `OnSaleIdChange`
  * Event `OnSaleTypeCatIdChange`
  * Event `OnSaleTypeIdChange`
  * Event `OnSourceChange`
  * Event `OnSourceIdChange`
  * Event `OnStatusChange`
  * Event `OnTextIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUserdef2IdChange`
  * Event `OnUserdefIdChange`
  * Event `OnVisibilityChange`

##### SuperOffice.CRM.Rows.SaleStakeholderRow is Modified

* Deleted items
  * Event `OnCommentChange`
  * Event `OnContactIdChange`
  * Event `OnPersonIdChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleIdChange`
  * Event `OnStakeholderRoleIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleTypeCatIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleTypeCatIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SaleTypeCatRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SaleTypeGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleTypeIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleTypeIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SaleTypeQuoteAttachmentRow is Modified

* Deleted items
  * Event `OnDefaultIncludedChange`
  * Event `OnDocumentIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleTypeIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SaleTypeRow is Modified

* Deleted items
  * Event `OnAllowQuoteAlternativesChange`
  * Event `OnArchiveGroupingFieldsChange`
  * Event `OnConfirmationLinesTemplateChange`
  * Event `OnDefaultQuoteValidityChange`
  * Event `OnDeletedChange`
  * Event `OnDocumentGroupingFieldsChange`
  * Event `OnDurationUnitChange`
  * Event `OnHasGuideChange`
  * Event `OnHasStakeholdersChange`
  * Event `OnIsAutoAdvanceChange`
  * Event `OnMaxDiscountPercentChange`
  * Event `OnMaxDiscountPercentSetChange`
  * Event `OnMinEarningPercentChange`
  * Event `OnMinEarningPercentSetChange`
  * Event `OnNameChange`
  * Event `OnQuoteLinesTemplateChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleDurationChange`
  * Event `OnSaleTypeCatIdChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SaleTypeStageLinkRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleTypeIdChange`
  * Event `OnStageIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SalutationGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSalutationIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SalutationHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSalutationIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SalutationRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SatelliteRow is Modified

* Deleted items
  * Event `OnAreaIdChange`
  * Event `OnContactIdChange`
  * Event `OnDSNChange`
  * Event `OnEncryptedCommChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SAttachmentRow is Modified

* Deleted items
  * Event `OnAttachmentIdChange`
  * Event `OnMessageIdChange`

##### SuperOffice.CRM.Rows.SBounceShipmentRow is Modified

* Deleted items
  * Event `OnCustomerIdChange`
  * Event `OnEmailChange`
  * Event `OnShipmentIdChange`

##### SuperOffice.CRM.Rows.ScheduledTaskRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnScheduleIdChange`
  * Event `OnScriptIdChange`

##### SuperOffice.CRM.Rows.ScheduleRow is Modified

* Deleted items
  * Event `OnAfterScheduleIdChange`
  * Event `OnAsapChange`
  * Event `OnDayOfMonthChange`
  * Event `OnDisabledChange`
  * Event `OnDomainChange`
  * Event `OnErrorMessageChange`
  * Event `OnExecutionTimeChange`
  * Event `OnFrequencyChange`
  * Event `OnLastErrorChange`
  * Event `OnLastExecutionChange`
  * Event `OnLockExpireChange`
  * Event `OnLockPidChange`
  * Event `OnLockTtlChange`
  * Event `OnMinOfHourChange`
  * Event `OnMinuteIntervalChange`
  * Event `OnMonthsChange`
  * Event `OnNameChange`
  * Event `OnNextExecutionChange`
  * Event `OnOnceAtChange`
  * Event `OnRetriesChange`
  * Event `OnRetryIntervalChange`
  * Event `OnStatusChange`
  * Event `OnStopChange`
  * Event `OnTimeOfDayChange`
  * Event `OnWeekdaysChange`

##### SuperOffice.CRM.Rows.ScreenChooserRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnEjscriptChange`
  * Event `OnEnabledChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnScreenTargetChange`
  * Event `OnScreenTypeChange`
  * Event `OnUniqueIdentifierChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ScreenDefinitionActionRow is Modified

* Deleted items
  * Event `OnButtonChange`
  * Event `OnDoCheckChange`
  * Event `OnEjscriptBodyChange`
  * Event `OnEjscriptChange`
  * Event `OnScreenDefinitionChange`

##### SuperOffice.CRM.Rows.ScreenDefinitionElementRow is Modified

* Deleted items
  * Event `OnBaseTableChange`
  * Event `OnCreationScriptChange`
  * Event `OnDescriptionChange`
  * Event `OnElementTypeChange`
  * Event `OnHideChange`
  * Event `OnNameChange`
  * Event `OnOrderPosChange`
  * Event `OnScreenDefinitionChange`

##### SuperOffice.CRM.Rows.ScreenDefinitionHiddenRow is Modified

* Deleted items
  * Event `OnScreenDefinitionChange`
  * Event `OnVariableChange`

##### SuperOffice.CRM.Rows.ScreenDefinitionLanguageRow is Modified

* Deleted items
  * Event `OnLanguageChange`
  * Event `OnScreenDefinitionChange`
  * Event `OnVariableNameChange`
  * Event `OnVariableValueChange`

##### SuperOffice.CRM.Rows.ScreenDefinitionRow is Modified

* Deleted items
  * Event `OnAutosaveChange`
  * Event `OnCreationScriptChange`
  * Event `OnDescriptionChange`
  * Event `OnHierarchyIdChange`
  * Event `OnIdStringChange`
  * Event `OnLayoutModelChange`
  * Event `OnLoadFinalScriptBodyChange`
  * Event `OnLoadPostCgiScriptBodyChange`
  * Event `OnLoadScriptBodyChange`
  * Event `OnNameChange`
  * Event `OnScreenKeyChange`
  * Event `OnWarnOnNavigateChange`

##### SuperOffice.CRM.Rows.ScriptTraceRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnEnabledChange`
  * Event `OnLocationChange`
  * Event `OnNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSkipFramesChange`
  * Event `OnTtlChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ScriptTraceRunRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnEndedAtChange`
  * Event `OnExecutionTimeChange`
  * Event `OnFileSizeChange`
  * Event `OnNumFramesChange`
  * Event `OnPeakMemoryChange`
  * Event `OnScriptTraceIdChange`
  * Event `OnStartedAtChange`
  * Event `OnStatusChange`
  * Event `OnUserExecutionTimeChange`

##### SuperOffice.CRM.Rows.SDynCriteriaRow is Modified

* Deleted items
  * Event `OnCriteriaValueChange`
  * Event `OnFieldChange`
  * Event `OnListIdChange`
  * Event `OnLogOpChange`
  * Event `OnOperatorChange`
  * Event `OnSortOrderChange`

##### SuperOffice.CRM.Rows.SearchCatGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSearchCatIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SearchCatHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSearchCatIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SearchCatRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SearchCriteriaGroupRow is Modified

* Deleted items
  * Event `OnActiveChange`
  * Event `OnDirectionChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSearchCriteriaIdChange`
  * Event `OnTextIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SearchCriteriaRow is Modified

* Deleted items
  * Event `OnDisplayNameChange`
  * Event `OnNameChange`
  * Event `OnOwnerGuiNameChange`
  * Event `OnOwnerIdChange`
  * Event `OnOwnerNameChange`
  * Event `OnOwnerTableChange`
  * Event `OnOwnerTypeChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTextIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SearchCriterionRow is Modified

* Deleted items
  * Event `OnActiveChange`
  * Event `OnColumnNameChange`
  * Event `OnCriterionIdChange`
  * Event `OnExtraIdChange`
  * Event `OnLinkTypeChange`
  * Event `OnOperatorIdChange`
  * Event `OnOperatorNameChange`
  * Event `OnParenthesisChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSearchCriteriaGroupIdChange`
  * Event `OnUdefIdentityChange`
  * Event `OnUniqueKeyChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SearchCriterionValueRow is Modified

* Deleted items
  * Event `OnDoubleValueChange`
  * Event `OnListItemIdChange`
  * Event `OnListTableIdChange`
  * Event `OnLongValueChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSearchCriterionIdChange`
  * Event `OnStringValueChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnValueTypeChange`

##### SuperOffice.CRM.Rows.SelectionMemberRow is Modified

* Deleted items
  * Event `OnContactIdChange`
  * Event `OnPersonIdChange`
  * Event `OnSelectionIdChange`
  * Event `OnTargetRecordIdChange`
  * Event `OnTargetTableNumberChange`

##### SuperOffice.CRM.Rows.SequenceRow is Modified

* Deleted items
  * Event `OnNextIdChange`
  * Event `OnTableNameChange`
  * Event `OnTableNumberChange`

##### SuperOffice.CRM.Rows.ServiceAuthRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnAuthStatusChange`
  * Event `OnAuthTypeChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnPasswordChange`
  * Event `OnPortChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnServerChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUsernameChange`

##### SuperOffice.CRM.Rows.SessionObjectRow is Modified

* Deleted items
  * Event `OnCreatedAtChange`
  * Event `OnLoginIdChange`
  * Event `OnNameChange`
  * Event `OnPartChange`
  * Event `OnSessionValueChange`

##### SuperOffice.CRM.Rows.ShipmentTypeReservationRow is Modified

* Deleted items
  * Event `OnPersonIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnShipmentTypeIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.ShipmentTypeRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SLinkCustomerRow is Modified

* Deleted items
  * Event `OnCustomerIdChange`
  * Event `OnHttpUserAgentChange`
  * Event `OnLinkIdChange`
  * Event `OnLinkTypeChange`
  * Event `OnPageChange`
  * Event `OnPressedChange`
  * Event `OnShipmentIdChange`

##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRow is Modified

* Deleted items
  * Event `OnEmailChange`
  * Event `OnHttpUserAgentChange`
  * Event `OnLinkIdChange`
  * Event `OnLinkTypeChange`
  * Event `OnPageChange`
  * Event `OnPressedChange`
  * Event `OnShipmentIdChange`

##### SuperOffice.CRM.Rows.SLinkRow is Modified

* Deleted items
  * Event `OnActionFlagsChange`
  * Event `OnAddContactInterestChange`
  * Event `OnAddContactSelectionChange`
  * Event `OnAddPersonInterestChange`
  * Event `OnAddProjectChange`
  * Event `OnAddToSelectionChange`
  * Event `OnDescriptionChange`
  * Event `OnExtraFieldChange`
  * Event `OnFolderIdChange`
  * Event `OnHitsChange`
  * Event `OnLastResetChange`
  * Event `OnLinkValueChange`
  * Event `OnRedirectIsUrlChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRemoveContactInterestChange`
  * Event `OnRemoveContactSelectionChange`
  * Event `OnRemoveFromSelectionChange`
  * Event `OnRemovePersonInterestChange`
  * Event `OnRemoveProjectChange`
  * Event `OnScriptIdChange`
  * Event `OnStatusChange`
  * Event `OnTaskAssociateIdChange`
  * Event `OnTaskCreatingAssociateIdChange`
  * Event `OnTaskDurationChange`
  * Event `OnTaskFlagsChange`
  * Event `OnTaskIdxChange`
  * Event `OnTaskProjectChange`
  * Event `OnTaskStartChange`
  * Event `OnTaskTextChange`
  * Event `OnTemplateTextChange`
  * Event `OnTicketCategoryChange`
  * Event `OnTicketOwnedByChange`
  * Event `OnTicketPriorityChange`
  * Event `OnTicketTitleChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUrlChange`

##### SuperOffice.CRM.Rows.SListCustomerRow is Modified

* Deleted items
  * Event `OnCustomerIdChange`
  * Event `OnListIdChange`

##### SuperOffice.CRM.Rows.SListElementRow is Modified

* Deleted items
  * Event `OnAddressChange`
  * Event `OnListIdChange`
  * Event `OnNameChange`
  * Event `OnSmsChange`
  * Event `OnStatusChange`

##### SuperOffice.CRM.Rows.SListRow is Modified

* Deleted items
  * Event `OnDbiAgentIdChange`
  * Event `OnDbiKeyChange`
  * Event `OnDbiLastModifiedChange`
  * Event `OnDbiLastSyncronizedChange`
  * Event `OnFlagChange`
  * Event `OnFolderIdChange`
  * Event `OnNameChange`
  * Event `OnNumberOfElementsChange`
  * Event `OnTypeChange`
  * Event `OnWashedChange`
  * Event `OnWashingPercentChange`

##### SuperOffice.CRM.Rows.SListShipmentRow is Modified

* Deleted items
  * Event `OnListIdChange`
  * Event `OnShipmentIdChange`
  * Event `OnStatusChange`
  * Event `OnTypeChange`

##### SuperOffice.CRM.Rows.SMessageblockRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnBlockChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SMessageRow is Modified

* Deleted items
  * Event `OnAccessKeyChange`
  * Event `OnDescriptionChange`
  * Event `OnDesignChange`
  * Event `OnDesigntypeChange`
  * Event `OnDocumentMessageChange`
  * Event `OnFlagsChange`
  * Event `OnFolderIdChange`
  * Event `OnHeaderFieldChange`
  * Event `OnHtmlMessageChange`
  * Event `OnInlineImagesChange`
  * Event `OnLongDescriptionChange`
  * Event `OnPlainMessageChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRegisterViewsChange`
  * Event `OnSmsMessageChange`
  * Event `OnSubjectChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SmsHysteriaRow is Modified

* Deleted items
  * Event `OnCreatedAtChange`
  * Event `OnRecipientAddressChange`

##### SuperOffice.CRM.Rows.SmsRow is Modified

* Deleted items
  * Event `OnCustomerIdChange`
  * Event `OnDeliveredAtChange`
  * Event `OnDeliveryExtStatusChange`
  * Event `OnDeliveryExtStatusDescChange`
  * Event `OnDeliveryStatusChange`
  * Event `OnDeliveryStatusDescChange`
  * Event `OnMessageIdChange`
  * Event `OnOutboxIdChange`
  * Event `OnOutgoingMessageIdChange`
  * Event `OnReferenceKeyChange`
  * Event `OnSessionKeyChange`
  * Event `OnShipmentIdChange`
  * Event `OnSmsTextChange`

##### SuperOffice.CRM.Rows.SnapshotRow is Modified

* Deleted items
  * Event `OnCreatedAtChange`
  * Event `OnUserCommentChange`

##### SuperOffice.CRM.Rows.SoapAccessRow is Modified

* Deleted items
  * Event `OnAddressFromChange`
  * Event `OnAddressToChange`
  * Event `OnTypeChange`

##### SuperOffice.CRM.Rows.SORCriteriaRow is Modified

* Deleted items
  * Event `OnFieldNameChange`
  * Event `OnLockedChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSOROperatorsIdChange`
  * Event `OnSORPublishIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUseItChange`
  * Event `OnValue1Change`
  * Event `OnValue2Change`
  * Event `OnWhereOrderChange`

##### SuperOffice.CRM.Rows.SORFCTRow is Modified

* Deleted items
  * Event `OnAggregateFunctionChange`
  * Event `OnCaptionChange`
  * Event `OnCaptionResIdChange`
  * Event `OnContentChange`
  * Event `OnDisplayTypeChange`
  * Event `OnFieldTypeChange`
  * Event `OnGroupFooterTypeChange`
  * Event `OnNumberFormatChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSORSectionIdChange`
  * Event `OnTotalsCaptionChange`
  * Event `OnTotalsResIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SORFieldRow is Modified

* Deleted items
  * Event `OnAlignmentChange`
  * Event `OnContentChange`
  * Event `OnContentResIdChange`
  * Event `OnDataFormatChange`
  * Event `OnFieldTypeChange`
  * Event `OnFontBoldChange`
  * Event `OnFontColorChange`
  * Event `OnFontItalicChange`
  * Event `OnFontNameChange`
  * Event `OnFontSizeChange`
  * Event `OnFontStrikethroughChange`
  * Event `OnFontUnderlineChange`
  * Event `OnFuncChange`
  * Event `OnGroupTypeChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRunningChange`
  * Event `OnSetHeightChange`
  * Event `OnSetLeftChange`
  * Event `OnSetTopChange`
  * Event `OnSetWidthChange`
  * Event `OnSgroupChange`
  * Event `OnSORSectionIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnVisibleChange`

##### SuperOffice.CRM.Rows.SORLabelLayoutRow is Modified

* Deleted items
  * Event `OnBottomMarginChange`
  * Event `OnCountColumnsChange`
  * Event `OnCountRowsChange`
  * Event `OnDescriptionChange`
  * Event `OnLabelHeightChange`
  * Event `OnLeftMarginChange`
  * Event `OnNameChange`
  * Event `OnOrientationChange`
  * Event `OnPaperHeightChange`
  * Event `OnPaperWidthChange`
  * Event `OnPrintWidthChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRightMarginChange`
  * Event `OnTopMarginChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SOROperatorsRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnDescriptionResIdChange`
  * Event `OnOperator1Change`
  * Event `OnOperator2Change`
  * Event `OnOperatorTypeChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SORPublishGroupLinkRow is Modified

* Deleted items
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSORPublishIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUserGroupIdChange`

##### SuperOffice.CRM.Rows.SORPublishRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnCCountChange`
  * Event `OnDefaultLabelLayoutChange`
  * Event `OnDescriptionChange`
  * Event `OnDescriptionResIdChange`
  * Event `OnForceDefaultChange`
  * Event `OnIsBuiltInChange`
  * Event `OnIsEditedChange`
  * Event `OnNameChange`
  * Event `OnNameResIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSORTemplateIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SORSectionRow is Modified

* Deleted items
  * Event `OnGroupingFieldChange`
  * Event `OnHeightChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSectionTypeChange`
  * Event `OnSORTemplateIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SORTemplateRow is Modified

* Deleted items
  * Event `OnBottomMarginChange`
  * Event `OnLayoutChange`
  * Event `OnLeftMarginChange`
  * Event `OnOrderByChange`
  * Event `OnOrientationChange`
  * Event `OnPrintWidthChange`
  * Event `OnPublishedChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRightMarginChange`
  * Event `OnSubjectChange`
  * Event `OnTopMarginChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnViewNameChange`

##### SuperOffice.CRM.Rows.SourceGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSourceIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SourceHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSourceIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SourceRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SPictureEntryRow is Modified

* Deleted items
  * Event `OnAttachmentIdChange`
  * Event `OnDescriptionChange`
  * Event `OnFlagsChange`
  * Event `OnFolderIdChange`
  * Event `OnHitsChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStatusChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SPictureFolderRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnFolderTypeChange`
  * Event `OnNameChange`
  * Event `OnParentIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SSentMessageRow is Modified

* Deleted items
  * Event `OnCustomerIdChange`
  * Event `OnEmailChange`
  * Event `OnMessageIdChange`
  * Event `OnShipmentIdChange`
  * Event `OnWhenReadChange`
  * Event `OnWhenSentChange`

##### SuperOffice.CRM.Rows.SShipmentAddrRow is Modified

* Deleted items
  * Event `OnAddressChange`
  * Event `OnBounceCodeChange`
  * Event `OnBounceReasonChange`
  * Event `OnBounceReasontagChange`
  * Event `OnCleanedChange`
  * Event `OnContactIdChange`
  * Event `OnCustomerIdChange`
  * Event `OnFormSubmissionIdChange`
  * Event `OnNameChange`
  * Event `OnSenderNrChange`
  * Event `OnSendingTimeChange`
  * Event `OnShipmentIdChange`
  * Event `OnStatusChange`
  * Event `OnTicketIdChange`
  * Event `OnTimestampChange`
  * Event `OnTypeChange`

##### SuperOffice.CRM.Rows.SShipmentRow is Modified

* Deleted items
  * Event `OnActivePaneChange`
  * Event `OnActualCountChange`
  * Event `OnActualRateChange`
  * Event `OnActualTimeChange`
  * Event `OnAreStatisticsDirtyChange`
  * Event `OnClickNumChange`
  * Event `OnClickRateChange`
  * Event `OnConfigurationChange`
  * Event `OnCurrentSenderChange`
  * Event `OnDeliveredNumChange`
  * Event `OnDescriptionChange`
  * Event `OnEndDateChange`
  * Event `OnEnvelopeFromChange`
  * Event `OnFlagsChange`
  * Event `OnFolderIdChange`
  * Event `OnFromAddrChange`
  * Event `OnGeneratedDocumentIdChange`
  * Event `OnHardbounceNumChange`
  * Event `OnHardbounceRateChange`
  * Event `OnMessageIdChange`
  * Event `OnOpenNumChange`
  * Event `OnOpenRateChange`
  * Event `OnProjectIdChange`
  * Event `OnRecipientsChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnReplyAddrChange`
  * Event `OnSelectionIdChange`
  * Event `OnSendRateChange`
  * Event `OnShipmenttypeIdChange`
  * Event `OnSmtpPortChange`
  * Event `OnSmtpServChange`
  * Event `OnSoftbounceNumChange`
  * Event `OnSoftbounceRateChange`
  * Event `OnSortingChange`
  * Event `OnStartDateChange`
  * Event `OnStatusChange`
  * Event `OnTicketCategoryChange`
  * Event `OnTicketOwnerChange`
  * Event `OnTotalbounceNumChange`
  * Event `OnTotalbounceRateChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SSmtpServersRow is Modified

* Deleted items
  * Event `OnShipmentIdChange`
  * Event `OnSmtpPortChange`
  * Event `OnSmtpServerChange`

##### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStakeholderRoleIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStakeholderRoleIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.StakeholderRoleRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.StaticListRefRow is Modified

* Deleted items
  * Event `OnListIdChange`
  * Event `OnRefIdChange`

##### SuperOffice.CRM.Rows.StatusDefRow is Modified

* Deleted items
  * Event `OnDefaultTaskChange`
  * Event `OnDeletedChange`
  * Event `OnDirtyOnChangeChange`
  * Event `OnGenerationStartChange`
  * Event `OnIsVisualChange`
  * Event `OnLastGeneratedChange`
  * Event `OnNeedsUpdateChange`
  * Event `OnNumMatchesChange`
  * Event `OnNumNeedUpdateChange`
  * Event `OnOwnerTableChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.StatusValueRow is Modified

* Deleted items
  * Event `OnContactIdChange`
  * Event `OnExtra1IdChange`
  * Event `OnExtra2IdChange`
  * Event `OnIsSignalledChange`
  * Event `OnNeedsUpdateChange`
  * Event `OnPersonIdChange`
  * Event `OnProjectIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStatusDefIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSubscriptionUnitIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSubscriptionUnitIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SubscriptionUnitRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SuggestedAppointmentRow is Modified

* Deleted items
  * Event `OnAssignToMemberChange`
  * Event `OnAutoSuggestChange`
  * Event `OnDaysFutureChange`
  * Event `OnDeletedChange`
  * Event `OnDurationChange`
  * Event `OnIsMilestoneChange`
  * Event `OnNameChange`
  * Event `OnProjectTypeStatusLinkIdChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleTypeStageLinkIdChange`
  * Event `OnTaskIdChange`
  * Event `OnTextChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SuggestedDocumentRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnDocTmplIdChange`
  * Event `OnHeaderChange`
  * Event `OnNameChange`
  * Event `OnOurRefChange`
  * Event `OnProjectTypeStatusLinkIdChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleTypeStageLinkIdChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SuperListColumnSizeRow is Modified

* Deleted items
  * Event `OnAssocIdChange`
  * Event `OnColumnSizeChange`
  * Event `OnConfigurationNameChange`
  * Event `OnExtraInfoChange`
  * Event `OnGroupIdChange`
  * Event `OnListColumnChange`
  * Event `OnListOwnerChange`
  * Event `OnOrderByDirectionChange`
  * Event `OnOrderByRankChange`
  * Event `OnOwnerRecordChange`
  * Event `OnOwnerTableChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SWashingListRow is Modified

* Deleted items
  * Event `OnAddressChange`
  * Event `OnListIdChange`

##### SuperOffice.CRM.Rows.SWashingRow is Modified

* Deleted items
  * Event `OnBounceChange`
  * Event `OnEmailAddrChange`
  * Event `OnShipmentsChange`
  * Event `OnTypeChange`

##### SuperOffice.CRM.Rows.SystemEventRow is Modified

* Deleted items
  * Event `OnEtaChange`
  * Event `OnEventkeyChange`
  * Event `OnEventmessChange`
  * Event `OnExtraInfoChange`
  * Event `OnOwnerChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnScopeChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.SystemScriptRow is Modified

* Deleted items
  * Event `OnBodyChange`
  * Event `OnScriptIdChange`

##### SuperOffice.CRM.Rows.TableRowBase is Modified

* Deleted items
  * Event `OnValueChanged`

##### SuperOffice.CRM.Rows.TabOrderRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTabNameChange`
  * Event `OnTabOrderChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TagsGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTagsIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TagsHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTagsIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TagsRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TargetAssignmentInfoRecordData is Modified

* New items
  * Field `TargetDimensionItemId`

##### SuperOffice.CRM.Rows.TargetAssignmentInfoRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnContactIdChange`
  * Event `OnCurrencyIdChange`
  * Event `OnLockedChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUsergroupIdChange`
* New items
  * Property `TargetDimensionItemId`

##### SuperOffice.CRM.Rows.TargetAssignmentValueRow is Modified

* Deleted items
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTargetAssignmentInfoIdChange`
  * Event `OnTargetPeriodIdChange`
  * Event `OnTargetValueChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TargetChangeRow is Modified

* Deleted items
  * Event `OnFieldIdentifierChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTargetRevisionIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnValueChangeFromChange`
  * Event `OnValueChangeToChange`

##### SuperOffice.CRM.Rows.TargetGroupRecordData is Modified

* New items
  * Field `TargetDimensionId`

##### SuperOffice.CRM.Rows.TargetGroupRow is Modified

* Deleted items
  * Event `OnEntityTypeChange`
  * Event `OnPeriodTypeChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnYearChange`
* New items
  * Property `TargetDimensionId`

##### SuperOffice.CRM.Rows.TargetPeriodRow is Modified

* Deleted items
  * Event `OnPeriodNumberChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTargetGroupIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TargetRevisionHistoryRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnContactIdChange`
  * Event `OnEntityTypeChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTargetAssignmentInfoIdChange`
  * Event `OnTargetGroupIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUsergroupIdChange`
  * Event `OnYearChange`

##### SuperOffice.CRM.Rows.TargetRevisionRow is Modified

* Deleted items
  * Event `OnAssignmentInfoIdChange`
  * Event `OnLogEventChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTargetRevisionHistoryIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TaskGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTaskIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TaskHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTaskIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TaskRow is Modified

* Deleted items
  * Event `OnColorIndexChange`
  * Event `OnDefaultAlldayEventChange`
  * Event `OnDefaultFreeBusyChange`
  * Event `OnDefaultPublishTypeChange`
  * Event `OnDefaultVideomeetingStatusChange`
  * Event `OnDeletedChange`
  * Event `OnDirectionChange`
  * Event `OnIntentIdChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRecordTypeChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TemporaryKeyRow is Modified

* Deleted items
  * Event `OnAuthkeyChange`
  * Event `OnDomainChange`
  * Event `OnExpiresChange`
  * Event `OnPersonIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTargetIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TemporaryWordsRow is Modified

* Deleted items
  * Event `OnMagicNumberChange`
  * Event `OnWordChange`
  * Event `OnWordLengthChange`

##### SuperOffice.CRM.Rows.TicketAlertRow is Modified

* Deleted items
  * Event `OnActionChange`
  * Event `OnAlertLevelChange`
  * Event `OnAlertTimeoutChange`
  * Event `OnDelegateToChange`
  * Event `OnEmailToChange`
  * Event `OnPriorityChange`
  * Event `OnReplyTemplateIdCatmastChange`
  * Event `OnReplyTemplateIdCatmastSmsChange`
  * Event `OnReplyTemplateIdCustomerChange`
  * Event `OnReplyTemplateIdEmailChange`
  * Event `OnReplyTemplateIdSmsChange`
  * Event `OnReplyTemplateIdUserChange`
  * Event `OnReplyTemplateIdUserSmsChange`
  * Event `OnRtiCustomerSmsChange`
  * Event `OnScriptIdChange`
  * Event `OnSmsToChange`

##### SuperOffice.CRM.Rows.TicketAttachmentRow is Modified

* Deleted items
  * Event `OnAttachmentIdChange`
  * Event `OnContentIdChange`
  * Event `OnInlineImageChange`
  * Event `OnMessageIdChange`

##### SuperOffice.CRM.Rows.TicketCustomersRow is Modified

* Deleted items
  * Event `OnCustomerIdChange`
  * Event `OnTicketIdChange`

##### SuperOffice.CRM.Rows.TicketLogActionRow is Modified

* Deleted items
  * Event `OnCustomerIdChange`
  * Event `OnDescriptionChange`
  * Event `OnDetailsChange`
  * Event `OnLogActionChange`
  * Event `OnLogWhenChange`
  * Event `OnMessageIdChange`
  * Event `OnOrgTicketIdChange`
  * Event `OnTicketIdChange`
  * Event `OnUserIdChange`

##### SuperOffice.CRM.Rows.TicketLogChangeRow is Modified

* Deleted items
  * Event `OnActionIdChange`
  * Event `OnExtraFieldIdChange`
  * Event `OnFromValueChange`
  * Event `OnLogChangeChange`
  * Event `OnMessageIdChange`
  * Event `OnTicketIdChange`
  * Event `OnToValueChange`

##### SuperOffice.CRM.Rows.TicketLogRow is Modified

* Deleted items
  * Event `OnLogCodeChange`
  * Event `OnLogDescriptionChange`
  * Event `OnLogWhatValue2Change`
  * Event `OnLogWhenChange`
  * Event `OnLogWhoChange`
  * Event `OnTicketIdChange`

##### SuperOffice.CRM.Rows.TicketPriorityRow is Modified

* Deleted items
  * Event `OnChangedOwnerChange`
  * Event `OnDeadlineChange`
  * Event `OnFlagsChange`
  * Event `OnFriStartChange`
  * Event `OnFriStopChange`
  * Event `OnMonStartChange`
  * Event `OnMonStopChange`
  * Event `OnNameChange`
  * Event `OnNonDatesChange`
  * Event `OnSatStartChange`
  * Event `OnSatStopChange`
  * Event `OnSortOrderChange`
  * Event `OnStatusChange`
  * Event `OnSunStartChange`
  * Event `OnSunStopChange`
  * Event `OnThuStartChange`
  * Event `OnThuStopChange`
  * Event `OnTicketChangedPriorityChange`
  * Event `OnTicketClosedChange`
  * Event `OnTicketNewChange`
  * Event `OnTicketNewinfoChange`
  * Event `OnTicketReadChange`
  * Event `OnTueStartChange`
  * Event `OnTueStopChange`
  * Event `OnWedStartChange`
  * Event `OnWedStopChange`

##### SuperOffice.CRM.Rows.TicketRelationActionRow is Modified

* Deleted items
  * Event `OnActionChange`
  * Event `OnEventChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSourceRelationTypeChange`
  * Event `OnTargetRelationTypeChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TicketRelationRow is Modified

* Deleted items
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRelationTypeChange`
  * Event `OnSourceChange`
  * Event `OnTargetChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TicketRelationTypeRow is Modified

* Deleted items
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSourceLabelChange`
  * Event `OnSourceTypeChange`
  * Event `OnTargetLabelChange`
  * Event `OnTargetTypeChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TicketRow is Modified

* Deleted items
  * Event `OnActivateChange`
  * Event `OnAlertLevelChange`
  * Event `OnAlertStopChange`
  * Event `OnAlertTimeoutChange`
  * Event `OnAuthorChange`
  * Event `OnCategoryChange`
  * Event `OnClosedAtChange`
  * Event `OnConnectIdChange`
  * Event `OnContactIdChange`
  * Event `OnCreatedAtChange`
  * Event `OnCreatedByChange`
  * Event `OnCustIdChange`
  * Event `OnDbiAgentIdChange`
  * Event `OnDbiKeyChange`
  * Event `OnDbiLastModifiedChange`
  * Event `OnDbiLastSyncronizedChange`
  * Event `OnDeadlineChange`
  * Event `OnDisplayFilterChange`
  * Event `OnFilterAddressChange`
  * Event `OnFilterIdChange`
  * Event `OnFirstReadByOwnerChange`
  * Event `OnFirstReadByUserChange`
  * Event `OnFormSubmissionIdChange`
  * Event `OnFromAddressChange`
  * Event `OnHasAttachmentChange`
  * Event `OnLanguageChange`
  * Event `OnLastChangedChange`
  * Event `OnNumMessagesChange`
  * Event `OnNumRepliesChange`
  * Event `OnOrigCategoryChange`
  * Event `OnOrigHumanCategoryIdChange`
  * Event `OnOriginChange`
  * Event `OnOrigPriorityChange`
  * Event `OnOwnedByChange`
  * Event `OnPriorityChange`
  * Event `OnReadByCustomerChange`
  * Event `OnReadByOwnerChange`
  * Event `OnReadStatusChange`
  * Event `OnRealTimeSpentExternallyChange`
  * Event `OnRealTimeSpentInternallyChange`
  * Event `OnRealTimeSpentQueueChange`
  * Event `OnRealTimeToCloseChange`
  * Event `OnRealTimeToReplyChange`
  * Event `OnRepliedAtChange`
  * Event `OnSentimentChange`
  * Event `OnSentimentConfidenceChange`
  * Event `OnSlevelChange`
  * Event `OnStatusChange`
  * Event `OnSuggestedCategoryIdChange`
  * Event `OnTagsChange`
  * Event `OnTicketStatusChange`
  * Event `OnTicketTypeChange`
  * Event `OnTimeSpentCalculatedChange`
  * Event `OnTimeSpentExternallyChange`
  * Event `OnTimeSpentInternallyChange`
  * Event `OnTimeSpentQueueChange`
  * Event `OnTimeToCloseChange`
  * Event `OnTimeToReplyChange`
  * Event `OnTitleChange`

##### SuperOffice.CRM.Rows.TicketStatusHistoryRow is Modified

* Deleted items
  * Event `OnFromDatetimeChange`
  * Event `OnRealTimespanChange`
  * Event `OnTicketIdChange`
  * Event `OnTicketStatusChange`
  * Event `OnTimespanChange`
  * Event `OnToDatetimeChange`

##### SuperOffice.CRM.Rows.TicketStatusRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnNoEmailReopenChange`
  * Event `OnStatusChange`
  * Event `OnTimeCounterChange`
  * Event `OnTsRankChange`

##### SuperOffice.CRM.Rows.TicketTypeRow is Modified

* Deleted items
  * Event `OnDescriptionChange`
  * Event `OnFlagsChange`
  * Event `OnIconUrlChange`
  * Event `OnNameChange`
  * Event `OnNamePluralChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnShowInNavigatorChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TimestampsRow is Modified

* Deleted items
  * Event `OnActivateTicketsChange`
  * Event `OnActiveTicketsChange`
  * Event `OnAutologoutChange`
  * Event `OnBuildFaqChange`
  * Event `OnCriticalEmailChange`
  * Event `OnDeleteTempTicketChange`
  * Event `OnEjournalCronChange`
  * Event `OnLastTicketdelChange`
  * Event `OnMailFilterChange`
  * Event `OnMailSenderChange`
  * Event `OnMailsyncChange`
  * Event `OnTicketAlertChange`
  * Event `OnWeekStatChange`

##### SuperOffice.CRM.Rows.TravelCurrentRow is Modified

* Deleted items
  * Event `OnAdminLoginChange`
  * Event `OnAreaIdChange`
  * Event `OnCentralDbTagChange`
  * Event `OnCentralGeneratedtimeChange`
  * Event `OnCentralIdChange`
  * Event `OnCurrentGeneratedtimeChange`
  * Event `OnCurrentIdChange`
  * Event `OnDatabasetypeChange`
  * Event `OnDbTagChange`
  * Event `OnDefaultMakeReturnChange`
  * Event `OnEncryptedCommChange`
  * Event `OnFirstRecordnumberChange`
  * Event `OnLastPlaybacknumberChange`
  * Event `OnLastPlaybacktimeChange`
  * Event `OnLastRecordnumberChange`
  * Event `OnLastRecordtimeChange`
  * Event `OnParentDbTagChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSystemlevelChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TravelGeneratedDatabaseRow is Modified

* Deleted items
  * Event `OnAreaIdChange`
  * Event `OnDatabasetypeChange`
  * Event `OnDbTagChange`
  * Event `OnGeneratedtimeChange`
  * Event `OnLastLogIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStateChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TravelGeneratedTransactionRow is Modified

* Deleted items
  * Event `OnRecordstatusChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTranlogfirstIdChange`
  * Event `OnTranloglastIdChange`
  * Event `OnTransmissionnumberChange`
  * Event `OnTransmissiontypeChange`
  * Event `OnTravelIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TravelIDMappingRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnCdbNameChange`
  * Event `OnCounterChange`
  * Event `OnLocalIdChange`
  * Event `OnParentIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTableNumberChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TravellerRow is Modified

* Deleted items
  * Event `OnAreaIdChange`
  * Event `OnDatabasetypeChange`
  * Event `OnDbTagChange`
  * Event `OnDefaultMakeReturnChange`
  * Event `OnEncryptedCommChange`
  * Event `OnGeneratedtimeChange`
  * Event `OnLastPlaybacknumberChange`
  * Event `OnLastPlaybacktimeChange`
  * Event `OnLastRecordnumberChange`
  * Event `OnLastRecordtimeChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSystemlevelChange`
  * Event `OnTravelIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TravelTransactionLogRow is Modified

* Deleted items
  * Event `OnApplicationIdChange`
  * Event `OnAssociateIdChange`
  * Event `OnFlagsChange`
  * Event `OnPrevRecordIdChange`
  * Event `OnRecordIdChange`
  * Event `OnTablenumberChange`
  * Event `OnTtimeChange`
  * Event `OnTypeChange`

##### SuperOffice.CRM.Rows.TrayAppRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnGuidChange`
  * Event `OnLcidChange`
  * Event `OnPageGeneratedChange`
  * Event `OnPresenceDetectedChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TreeExplorerEntryRow is Modified

* Deleted items
  * Event `OnExpandOrderChange`
  * Event `OnHrefChange`
  * Event `OnIconChange`
  * Event `OnInternalIdChange`
  * Event `OnInternalParentChange`
  * Event `OnLeafChange`
  * Event `OnNameChange`
  * Event `OnOnclickChange`
  * Event `OnParentIdChange`
  * Event `OnSessionKeyChange`
  * Event `OnSortOrderChange`
  * Event `OnTargetChange`
  * Event `OnTooltipChange`
  * Event `OnTreeKeyChange`

##### SuperOffice.CRM.Rows.TreeExplorerLinkRow is Modified

* Deleted items
  * Event `OnEntryIdChange`
  * Event `OnHrefChange`
  * Event `OnIconChange`
  * Event `OnSessionKeyChange`
  * Event `OnTargetChange`
  * Event `OnTooltipChange`

##### SuperOffice.CRM.Rows.TypicalSearchRow is Modified

* Deleted items
  * Event `OnEntityNameChange`
  * Event `OnIncludePersonChange`
  * Event `OnIsEntityDefaultChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSourceChange`
  * Event `OnTitleChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnVersionNumberChange`

##### SuperOffice.CRM.Rows.TZDstRuleRow is Modified

* Deleted items
  * Event `OnBiasChange`
  * Event `OnDescriptionChange`
  * Event `OnEndDayOfMonthChange`
  * Event `OnEndMonthChange`
  * Event `OnEndRuleChange`
  * Event `OnIsBuiltInChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStartDayOfMonthChange`
  * Event `OnStartMonthChange`
  * Event `OnStartRuleChange`
  * Event `OnTZLocationIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnValidFromChange`

##### SuperOffice.CRM.Rows.TZLocationRow is Modified

* Deleted items
  * Event `OnCitiesChange`
  * Event `OnCountryIdChange`
  * Event `OnDeletedChange`
  * Event `OnDescriptionChange`
  * Event `OnGroupNameChange`
  * Event `OnIsActiveChange`
  * Event `OnIsBuiltInChange`
  * Event `OnLocationCodeChange`
  * Event `OnRegionNameChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnShortNameChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.TZStdRuleRow is Modified

* Deleted items
  * Event `OnBiasChange`
  * Event `OnDescriptionChange`
  * Event `OnIsBuiltInChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTZLocationIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnValidFromChange`

##### SuperOffice.CRM.Rows.UDAppntLargeRow is Modified

* Deleted items
  * Event `OnString41Change`
  * Event `OnString42Change`
  * Event `OnString43Change`
  * Event `OnString44Change`
  * Event `OnString45Change`
  * Event `OnString46Change`
  * Event `OnString47Change`
  * Event `OnString48Change`
  * Event `OnString49Change`

##### SuperOffice.CRM.Rows.UDAppntSmallRow is Modified

* Deleted items
  * Event `OnDouble01Change`
  * Event `OnDouble02Change`
  * Event `OnDouble03Change`
  * Event `OnDouble04Change`
  * Event `OnDouble05Change`
  * Event `OnDouble06Change`
  * Event `OnDouble07Change`
  * Event `OnDouble08Change`
  * Event `OnDouble09Change`
  * Event `OnDouble10Change`
  * Event `OnLong01Change`
  * Event `OnLong02Change`
  * Event `OnLong03Change`
  * Event `OnLong04Change`
  * Event `OnLong05Change`
  * Event `OnLong06Change`
  * Event `OnLong07Change`
  * Event `OnLong08Change`
  * Event `OnLong09Change`
  * Event `OnLong10Change`
  * Event `OnLong11Change`
  * Event `OnLong12Change`
  * Event `OnLong13Change`
  * Event `OnLong14Change`
  * Event `OnLong15Change`
  * Event `OnLong16Change`
  * Event `OnLong17Change`
  * Event `OnLong18Change`
  * Event `OnLong19Change`
  * Event `OnLong20Change`
  * Event `OnLong21Change`
  * Event `OnLong22Change`
  * Event `OnLong23Change`
  * Event `OnLong24Change`
  * Event `OnLong25Change`
  * Event `OnLong26Change`
  * Event `OnLong27Change`
  * Event `OnLong28Change`
  * Event `OnLong29Change`
  * Event `OnLong30Change`
  * Event `OnLong31Change`
  * Event `OnLong32Change`
  * Event `OnLong33Change`
  * Event `OnLong34Change`
  * Event `OnLong35Change`
  * Event `OnLong36Change`
  * Event `OnLong37Change`
  * Event `OnLong38Change`
  * Event `OnLong39Change`
  * Event `OnLong40Change`
  * Event `OnLong41Change`
  * Event `OnLong42Change`
  * Event `OnLong43Change`
  * Event `OnLong44Change`
  * Event `OnLong45Change`
  * Event `OnLong46Change`
  * Event `OnLong47Change`
  * Event `OnLong48Change`
  * Event `OnLong49Change`
  * Event `OnLong50Change`
  * Event `OnLong51Change`
  * Event `OnLong52Change`
  * Event `OnLong53Change`
  * Event `OnLong54Change`
  * Event `OnLong55Change`
  * Event `OnLong56Change`
  * Event `OnLong57Change`
  * Event `OnLong58Change`
  * Event `OnLong59Change`
  * Event `OnLong60Change`
  * Event `OnString01Change`
  * Event `OnString02Change`
  * Event `OnString03Change`
  * Event `OnString04Change`
  * Event `OnString05Change`
  * Event `OnString06Change`
  * Event `OnString07Change`
  * Event `OnString08Change`
  * Event `OnString09Change`
  * Event `OnString10Change`
  * Event `OnString11Change`
  * Event `OnString12Change`
  * Event `OnString13Change`
  * Event `OnString14Change`
  * Event `OnString15Change`
  * Event `OnString16Change`
  * Event `OnString17Change`
  * Event `OnString18Change`
  * Event `OnString19Change`
  * Event `OnString20Change`
  * Event `OnString21Change`
  * Event `OnString22Change`
  * Event `OnString23Change`
  * Event `OnString24Change`
  * Event `OnString25Change`
  * Event `OnString26Change`
  * Event `OnString27Change`
  * Event `OnString28Change`
  * Event `OnString29Change`
  * Event `OnString30Change`
  * Event `OnString31Change`
  * Event `OnString32Change`
  * Event `OnString33Change`
  * Event `OnString34Change`
  * Event `OnString35Change`
  * Event `OnString36Change`
  * Event `OnString37Change`
  * Event `OnString38Change`
  * Event `OnString39Change`
  * Event `OnString40Change`

##### SuperOffice.CRM.Rows.UDContactLargeRow is Modified

* Deleted items
  * Event `OnString41Change`
  * Event `OnString42Change`
  * Event `OnString43Change`
  * Event `OnString44Change`
  * Event `OnString45Change`
  * Event `OnString46Change`
  * Event `OnString47Change`
  * Event `OnString48Change`
  * Event `OnString49Change`

##### SuperOffice.CRM.Rows.UDContactSmallRow is Modified

* Deleted items
  * Event `OnDouble01Change`
  * Event `OnDouble02Change`
  * Event `OnDouble03Change`
  * Event `OnDouble04Change`
  * Event `OnDouble05Change`
  * Event `OnDouble06Change`
  * Event `OnDouble07Change`
  * Event `OnDouble08Change`
  * Event `OnDouble09Change`
  * Event `OnDouble10Change`
  * Event `OnLong01Change`
  * Event `OnLong02Change`
  * Event `OnLong03Change`
  * Event `OnLong04Change`
  * Event `OnLong05Change`
  * Event `OnLong06Change`
  * Event `OnLong07Change`
  * Event `OnLong08Change`
  * Event `OnLong09Change`
  * Event `OnLong10Change`
  * Event `OnLong11Change`
  * Event `OnLong12Change`
  * Event `OnLong13Change`
  * Event `OnLong14Change`
  * Event `OnLong15Change`
  * Event `OnLong16Change`
  * Event `OnLong17Change`
  * Event `OnLong18Change`
  * Event `OnLong19Change`
  * Event `OnLong20Change`
  * Event `OnLong21Change`
  * Event `OnLong22Change`
  * Event `OnLong23Change`
  * Event `OnLong24Change`
  * Event `OnLong25Change`
  * Event `OnLong26Change`
  * Event `OnLong27Change`
  * Event `OnLong28Change`
  * Event `OnLong29Change`
  * Event `OnLong30Change`
  * Event `OnLong31Change`
  * Event `OnLong32Change`
  * Event `OnLong33Change`
  * Event `OnLong34Change`
  * Event `OnLong35Change`
  * Event `OnLong36Change`
  * Event `OnLong37Change`
  * Event `OnLong38Change`
  * Event `OnLong39Change`
  * Event `OnLong40Change`
  * Event `OnLong41Change`
  * Event `OnLong42Change`
  * Event `OnLong43Change`
  * Event `OnLong44Change`
  * Event `OnLong45Change`
  * Event `OnLong46Change`
  * Event `OnLong47Change`
  * Event `OnLong48Change`
  * Event `OnLong49Change`
  * Event `OnLong50Change`
  * Event `OnLong51Change`
  * Event `OnLong52Change`
  * Event `OnLong53Change`
  * Event `OnLong54Change`
  * Event `OnLong55Change`
  * Event `OnLong56Change`
  * Event `OnLong57Change`
  * Event `OnLong58Change`
  * Event `OnLong59Change`
  * Event `OnLong60Change`
  * Event `OnString01Change`
  * Event `OnString02Change`
  * Event `OnString03Change`
  * Event `OnString04Change`
  * Event `OnString05Change`
  * Event `OnString06Change`
  * Event `OnString07Change`
  * Event `OnString08Change`
  * Event `OnString09Change`
  * Event `OnString10Change`
  * Event `OnString11Change`
  * Event `OnString12Change`
  * Event `OnString13Change`
  * Event `OnString14Change`
  * Event `OnString15Change`
  * Event `OnString16Change`
  * Event `OnString17Change`
  * Event `OnString18Change`
  * Event `OnString19Change`
  * Event `OnString20Change`
  * Event `OnString21Change`
  * Event `OnString22Change`
  * Event `OnString23Change`
  * Event `OnString24Change`
  * Event `OnString25Change`
  * Event `OnString26Change`
  * Event `OnString27Change`
  * Event `OnString28Change`
  * Event `OnString29Change`
  * Event `OnString30Change`
  * Event `OnString31Change`
  * Event `OnString32Change`
  * Event `OnString33Change`
  * Event `OnString34Change`
  * Event `OnString35Change`
  * Event `OnString36Change`
  * Event `OnString37Change`
  * Event `OnString38Change`
  * Event `OnString39Change`
  * Event `OnString40Change`

##### SuperOffice.CRM.Rows.UDDocLargeRow is Modified

* Deleted items
  * Event `OnString41Change`
  * Event `OnString42Change`
  * Event `OnString43Change`
  * Event `OnString44Change`
  * Event `OnString45Change`
  * Event `OnString46Change`
  * Event `OnString47Change`
  * Event `OnString48Change`
  * Event `OnString49Change`

##### SuperOffice.CRM.Rows.UDDocSmallRow is Modified

* Deleted items
  * Event `OnDouble01Change`
  * Event `OnDouble02Change`
  * Event `OnDouble03Change`
  * Event `OnDouble04Change`
  * Event `OnDouble05Change`
  * Event `OnDouble06Change`
  * Event `OnDouble07Change`
  * Event `OnDouble08Change`
  * Event `OnDouble09Change`
  * Event `OnDouble10Change`
  * Event `OnLong01Change`
  * Event `OnLong02Change`
  * Event `OnLong03Change`
  * Event `OnLong04Change`
  * Event `OnLong05Change`
  * Event `OnLong06Change`
  * Event `OnLong07Change`
  * Event `OnLong08Change`
  * Event `OnLong09Change`
  * Event `OnLong10Change`
  * Event `OnLong11Change`
  * Event `OnLong12Change`
  * Event `OnLong13Change`
  * Event `OnLong14Change`
  * Event `OnLong15Change`
  * Event `OnLong16Change`
  * Event `OnLong17Change`
  * Event `OnLong18Change`
  * Event `OnLong19Change`
  * Event `OnLong20Change`
  * Event `OnLong21Change`
  * Event `OnLong22Change`
  * Event `OnLong23Change`
  * Event `OnLong24Change`
  * Event `OnLong25Change`
  * Event `OnLong26Change`
  * Event `OnLong27Change`
  * Event `OnLong28Change`
  * Event `OnLong29Change`
  * Event `OnLong30Change`
  * Event `OnLong31Change`
  * Event `OnLong32Change`
  * Event `OnLong33Change`
  * Event `OnLong34Change`
  * Event `OnLong35Change`
  * Event `OnLong36Change`
  * Event `OnLong37Change`
  * Event `OnLong38Change`
  * Event `OnLong39Change`
  * Event `OnLong40Change`
  * Event `OnLong41Change`
  * Event `OnLong42Change`
  * Event `OnLong43Change`
  * Event `OnLong44Change`
  * Event `OnLong45Change`
  * Event `OnLong46Change`
  * Event `OnLong47Change`
  * Event `OnLong48Change`
  * Event `OnLong49Change`
  * Event `OnLong50Change`
  * Event `OnLong51Change`
  * Event `OnLong52Change`
  * Event `OnLong53Change`
  * Event `OnLong54Change`
  * Event `OnLong55Change`
  * Event `OnLong56Change`
  * Event `OnLong57Change`
  * Event `OnLong58Change`
  * Event `OnLong59Change`
  * Event `OnLong60Change`
  * Event `OnString01Change`
  * Event `OnString02Change`
  * Event `OnString03Change`
  * Event `OnString04Change`
  * Event `OnString05Change`
  * Event `OnString06Change`
  * Event `OnString07Change`
  * Event `OnString08Change`
  * Event `OnString09Change`
  * Event `OnString10Change`
  * Event `OnString11Change`
  * Event `OnString12Change`
  * Event `OnString13Change`
  * Event `OnString14Change`
  * Event `OnString15Change`
  * Event `OnString16Change`
  * Event `OnString17Change`
  * Event `OnString18Change`
  * Event `OnString19Change`
  * Event `OnString20Change`
  * Event `OnString21Change`
  * Event `OnString22Change`
  * Event `OnString23Change`
  * Event `OnString24Change`
  * Event `OnString25Change`
  * Event `OnString26Change`
  * Event `OnString27Change`
  * Event `OnString28Change`
  * Event `OnString29Change`
  * Event `OnString30Change`
  * Event `OnString31Change`
  * Event `OnString32Change`
  * Event `OnString33Change`
  * Event `OnString34Change`
  * Event `OnString35Change`
  * Event `OnString36Change`
  * Event `OnString37Change`
  * Event `OnString38Change`
  * Event `OnString39Change`
  * Event `OnString40Change`

##### SuperOffice.CRM.Rows.UDefFieldGLRow is Modified

* Deleted items
  * Event `OnFieldLineNoChange`
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUDefFieldIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.UDefFieldRow is Modified

* Deleted items
  * Event `OnColumnIdChange`
  * Event `OnFieldDefaultChange`
  * Event `OnFieldHeightChange`
  * Event `OnFieldLabelChange`
  * Event `OnFieldLeftChange`
  * Event `OnFieldTopChange`
  * Event `OnFieldTypeChange`
  * Event `OnFieldWidthChange`
  * Event `OnFormatMaskChange`
  * Event `OnHideLabelChange`
  * Event `OnIndexedChange`
  * Event `OnJustificationChange`
  * Event `OnLabelHeightChange`
  * Event `OnLabelLeftChange`
  * Event `OnLabelTopChange`
  * Event `OnLabelWidthChange`
  * Event `OnLastVersionIdChange`
  * Event `OnListTableIdChange`
  * Event `OnMandatoryChange`
  * Event `OnOwnerTableIdChange`
  * Event `OnPage1LineNoChange`
  * Event `OnProgIdChange`
  * Event `OnReadOnlyChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnShortLabelChange`
  * Event `OnTabOrderChange`
  * Event `OnTextLengthChange`
  * Event `OnTooltipChange`
  * Event `OnUdefIdentityChange`
  * Event `OnUDListDefinitionIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnVersionChange`

##### SuperOffice.CRM.Rows.UDListDefinitionRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnListTableIdChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRequiredLicenseChange`
  * Event `OnTooltipChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.UDListGroupLinkRow is Modified

* Deleted items
  * Event `OnGroupIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUDListIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.UDListHeadingLinkRow is Modified

* Deleted items
  * Event `OnHeadingIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUDListIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.UDListRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnUDListDefinitionIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.UDPersonLargeRow is Modified

* Deleted items
  * Event `OnString41Change`
  * Event `OnString42Change`
  * Event `OnString43Change`
  * Event `OnString44Change`
  * Event `OnString45Change`
  * Event `OnString46Change`
  * Event `OnString47Change`
  * Event `OnString48Change`
  * Event `OnString49Change`

##### SuperOffice.CRM.Rows.UDPersonSmallRow is Modified

* Deleted items
  * Event `OnDouble01Change`
  * Event `OnDouble02Change`
  * Event `OnDouble03Change`
  * Event `OnDouble04Change`
  * Event `OnDouble05Change`
  * Event `OnDouble06Change`
  * Event `OnDouble07Change`
  * Event `OnDouble08Change`
  * Event `OnDouble09Change`
  * Event `OnDouble10Change`
  * Event `OnLong01Change`
  * Event `OnLong02Change`
  * Event `OnLong03Change`
  * Event `OnLong04Change`
  * Event `OnLong05Change`
  * Event `OnLong06Change`
  * Event `OnLong07Change`
  * Event `OnLong08Change`
  * Event `OnLong09Change`
  * Event `OnLong10Change`
  * Event `OnLong11Change`
  * Event `OnLong12Change`
  * Event `OnLong13Change`
  * Event `OnLong14Change`
  * Event `OnLong15Change`
  * Event `OnLong16Change`
  * Event `OnLong17Change`
  * Event `OnLong18Change`
  * Event `OnLong19Change`
  * Event `OnLong20Change`
  * Event `OnLong21Change`
  * Event `OnLong22Change`
  * Event `OnLong23Change`
  * Event `OnLong24Change`
  * Event `OnLong25Change`
  * Event `OnLong26Change`
  * Event `OnLong27Change`
  * Event `OnLong28Change`
  * Event `OnLong29Change`
  * Event `OnLong30Change`
  * Event `OnLong31Change`
  * Event `OnLong32Change`
  * Event `OnLong33Change`
  * Event `OnLong34Change`
  * Event `OnLong35Change`
  * Event `OnLong36Change`
  * Event `OnLong37Change`
  * Event `OnLong38Change`
  * Event `OnLong39Change`
  * Event `OnLong40Change`
  * Event `OnLong41Change`
  * Event `OnLong42Change`
  * Event `OnLong43Change`
  * Event `OnLong44Change`
  * Event `OnLong45Change`
  * Event `OnLong46Change`
  * Event `OnLong47Change`
  * Event `OnLong48Change`
  * Event `OnLong49Change`
  * Event `OnLong50Change`
  * Event `OnLong51Change`
  * Event `OnLong52Change`
  * Event `OnLong53Change`
  * Event `OnLong54Change`
  * Event `OnLong55Change`
  * Event `OnLong56Change`
  * Event `OnLong57Change`
  * Event `OnLong58Change`
  * Event `OnLong59Change`
  * Event `OnLong60Change`
  * Event `OnString01Change`
  * Event `OnString02Change`
  * Event `OnString03Change`
  * Event `OnString04Change`
  * Event `OnString05Change`
  * Event `OnString06Change`
  * Event `OnString07Change`
  * Event `OnString08Change`
  * Event `OnString09Change`
  * Event `OnString10Change`
  * Event `OnString11Change`
  * Event `OnString12Change`
  * Event `OnString13Change`
  * Event `OnString14Change`
  * Event `OnString15Change`
  * Event `OnString16Change`
  * Event `OnString17Change`
  * Event `OnString18Change`
  * Event `OnString19Change`
  * Event `OnString20Change`
  * Event `OnString21Change`
  * Event `OnString22Change`
  * Event `OnString23Change`
  * Event `OnString24Change`
  * Event `OnString25Change`
  * Event `OnString26Change`
  * Event `OnString27Change`
  * Event `OnString28Change`
  * Event `OnString29Change`
  * Event `OnString30Change`
  * Event `OnString31Change`
  * Event `OnString32Change`
  * Event `OnString33Change`
  * Event `OnString34Change`
  * Event `OnString35Change`
  * Event `OnString36Change`
  * Event `OnString37Change`
  * Event `OnString38Change`
  * Event `OnString39Change`
  * Event `OnString40Change`

##### SuperOffice.CRM.Rows.UDProjectLargeRow is Modified

* Deleted items
  * Event `OnString41Change`
  * Event `OnString42Change`
  * Event `OnString43Change`
  * Event `OnString44Change`
  * Event `OnString45Change`
  * Event `OnString46Change`
  * Event `OnString47Change`
  * Event `OnString48Change`
  * Event `OnString49Change`

##### SuperOffice.CRM.Rows.UDProjectSmallRow is Modified

* Deleted items
  * Event `OnDouble01Change`
  * Event `OnDouble02Change`
  * Event `OnDouble03Change`
  * Event `OnDouble04Change`
  * Event `OnDouble05Change`
  * Event `OnDouble06Change`
  * Event `OnDouble07Change`
  * Event `OnDouble08Change`
  * Event `OnDouble09Change`
  * Event `OnDouble10Change`
  * Event `OnLong01Change`
  * Event `OnLong02Change`
  * Event `OnLong03Change`
  * Event `OnLong04Change`
  * Event `OnLong05Change`
  * Event `OnLong06Change`
  * Event `OnLong07Change`
  * Event `OnLong08Change`
  * Event `OnLong09Change`
  * Event `OnLong10Change`
  * Event `OnLong11Change`
  * Event `OnLong12Change`
  * Event `OnLong13Change`
  * Event `OnLong14Change`
  * Event `OnLong15Change`
  * Event `OnLong16Change`
  * Event `OnLong17Change`
  * Event `OnLong18Change`
  * Event `OnLong19Change`
  * Event `OnLong20Change`
  * Event `OnLong21Change`
  * Event `OnLong22Change`
  * Event `OnLong23Change`
  * Event `OnLong24Change`
  * Event `OnLong25Change`
  * Event `OnLong26Change`
  * Event `OnLong27Change`
  * Event `OnLong28Change`
  * Event `OnLong29Change`
  * Event `OnLong30Change`
  * Event `OnLong31Change`
  * Event `OnLong32Change`
  * Event `OnLong33Change`
  * Event `OnLong34Change`
  * Event `OnLong35Change`
  * Event `OnLong36Change`
  * Event `OnLong37Change`
  * Event `OnLong38Change`
  * Event `OnLong39Change`
  * Event `OnLong40Change`
  * Event `OnLong41Change`
  * Event `OnLong42Change`
  * Event `OnLong43Change`
  * Event `OnLong44Change`
  * Event `OnLong45Change`
  * Event `OnLong46Change`
  * Event `OnLong47Change`
  * Event `OnLong48Change`
  * Event `OnLong49Change`
  * Event `OnLong50Change`
  * Event `OnLong51Change`
  * Event `OnLong52Change`
  * Event `OnLong53Change`
  * Event `OnLong54Change`
  * Event `OnLong55Change`
  * Event `OnLong56Change`
  * Event `OnLong57Change`
  * Event `OnLong58Change`
  * Event `OnLong59Change`
  * Event `OnLong60Change`
  * Event `OnString01Change`
  * Event `OnString02Change`
  * Event `OnString03Change`
  * Event `OnString04Change`
  * Event `OnString05Change`
  * Event `OnString06Change`
  * Event `OnString07Change`
  * Event `OnString08Change`
  * Event `OnString09Change`
  * Event `OnString10Change`
  * Event `OnString11Change`
  * Event `OnString12Change`
  * Event `OnString13Change`
  * Event `OnString14Change`
  * Event `OnString15Change`
  * Event `OnString16Change`
  * Event `OnString17Change`
  * Event `OnString18Change`
  * Event `OnString19Change`
  * Event `OnString20Change`
  * Event `OnString21Change`
  * Event `OnString22Change`
  * Event `OnString23Change`
  * Event `OnString24Change`
  * Event `OnString25Change`
  * Event `OnString26Change`
  * Event `OnString27Change`
  * Event `OnString28Change`
  * Event `OnString29Change`
  * Event `OnString30Change`
  * Event `OnString31Change`
  * Event `OnString32Change`
  * Event `OnString33Change`
  * Event `OnString34Change`
  * Event `OnString35Change`
  * Event `OnString36Change`
  * Event `OnString37Change`
  * Event `OnString38Change`
  * Event `OnString39Change`
  * Event `OnString40Change`

##### SuperOffice.CRM.Rows.UDSaleLargeRow is Modified

* Deleted items
  * Event `OnString41Change`
  * Event `OnString42Change`
  * Event `OnString43Change`
  * Event `OnString44Change`
  * Event `OnString45Change`
  * Event `OnString46Change`
  * Event `OnString47Change`
  * Event `OnString48Change`
  * Event `OnString49Change`

##### SuperOffice.CRM.Rows.UDSaleSmallRow is Modified

* Deleted items
  * Event `OnDouble01Change`
  * Event `OnDouble02Change`
  * Event `OnDouble03Change`
  * Event `OnDouble04Change`
  * Event `OnDouble05Change`
  * Event `OnDouble06Change`
  * Event `OnDouble07Change`
  * Event `OnDouble08Change`
  * Event `OnDouble09Change`
  * Event `OnDouble10Change`
  * Event `OnLong01Change`
  * Event `OnLong02Change`
  * Event `OnLong03Change`
  * Event `OnLong04Change`
  * Event `OnLong05Change`
  * Event `OnLong06Change`
  * Event `OnLong07Change`
  * Event `OnLong08Change`
  * Event `OnLong09Change`
  * Event `OnLong10Change`
  * Event `OnLong11Change`
  * Event `OnLong12Change`
  * Event `OnLong13Change`
  * Event `OnLong14Change`
  * Event `OnLong15Change`
  * Event `OnLong16Change`
  * Event `OnLong17Change`
  * Event `OnLong18Change`
  * Event `OnLong19Change`
  * Event `OnLong20Change`
  * Event `OnLong21Change`
  * Event `OnLong22Change`
  * Event `OnLong23Change`
  * Event `OnLong24Change`
  * Event `OnLong25Change`
  * Event `OnLong26Change`
  * Event `OnLong27Change`
  * Event `OnLong28Change`
  * Event `OnLong29Change`
  * Event `OnLong30Change`
  * Event `OnLong31Change`
  * Event `OnLong32Change`
  * Event `OnLong33Change`
  * Event `OnLong34Change`
  * Event `OnLong35Change`
  * Event `OnLong36Change`
  * Event `OnLong37Change`
  * Event `OnLong38Change`
  * Event `OnLong39Change`
  * Event `OnLong40Change`
  * Event `OnLong41Change`
  * Event `OnLong42Change`
  * Event `OnLong43Change`
  * Event `OnLong44Change`
  * Event `OnLong45Change`
  * Event `OnLong46Change`
  * Event `OnLong47Change`
  * Event `OnLong48Change`
  * Event `OnLong49Change`
  * Event `OnLong50Change`
  * Event `OnLong51Change`
  * Event `OnLong52Change`
  * Event `OnLong53Change`
  * Event `OnLong54Change`
  * Event `OnLong55Change`
  * Event `OnLong56Change`
  * Event `OnLong57Change`
  * Event `OnLong58Change`
  * Event `OnLong59Change`
  * Event `OnLong60Change`
  * Event `OnString01Change`
  * Event `OnString02Change`
  * Event `OnString03Change`
  * Event `OnString04Change`
  * Event `OnString05Change`
  * Event `OnString06Change`
  * Event `OnString07Change`
  * Event `OnString08Change`
  * Event `OnString09Change`
  * Event `OnString10Change`
  * Event `OnString11Change`
  * Event `OnString12Change`
  * Event `OnString13Change`
  * Event `OnString14Change`
  * Event `OnString15Change`
  * Event `OnString16Change`
  * Event `OnString17Change`
  * Event `OnString18Change`
  * Event `OnString19Change`
  * Event `OnString20Change`
  * Event `OnString21Change`
  * Event `OnString22Change`
  * Event `OnString23Change`
  * Event `OnString24Change`
  * Event `OnString25Change`
  * Event `OnString26Change`
  * Event `OnString27Change`
  * Event `OnString28Change`
  * Event `OnString29Change`
  * Event `OnString30Change`
  * Event `OnString31Change`
  * Event `OnString32Change`
  * Event `OnString33Change`
  * Event `OnString34Change`
  * Event `OnString35Change`
  * Event `OnString36Change`
  * Event `OnString37Change`
  * Event `OnString38Change`
  * Event `OnString39Change`
  * Event `OnString40Change`

##### SuperOffice.CRM.Rows.UDTempLargeRow is Modified

* Deleted items
  * Event `OnString41Change`
  * Event `OnString42Change`
  * Event `OnString43Change`
  * Event `OnString44Change`
  * Event `OnString45Change`
  * Event `OnString46Change`
  * Event `OnString47Change`
  * Event `OnString48Change`
  * Event `OnString49Change`

##### SuperOffice.CRM.Rows.UDTempSmallRow is Modified

* Deleted items
  * Event `OnDouble01Change`
  * Event `OnDouble02Change`
  * Event `OnDouble03Change`
  * Event `OnDouble04Change`
  * Event `OnDouble05Change`
  * Event `OnDouble06Change`
  * Event `OnDouble07Change`
  * Event `OnDouble08Change`
  * Event `OnDouble09Change`
  * Event `OnDouble10Change`
  * Event `OnLong01Change`
  * Event `OnLong02Change`
  * Event `OnLong03Change`
  * Event `OnLong04Change`
  * Event `OnLong05Change`
  * Event `OnLong06Change`
  * Event `OnLong07Change`
  * Event `OnLong08Change`
  * Event `OnLong09Change`
  * Event `OnLong10Change`
  * Event `OnLong11Change`
  * Event `OnLong12Change`
  * Event `OnLong13Change`
  * Event `OnLong14Change`
  * Event `OnLong15Change`
  * Event `OnLong16Change`
  * Event `OnLong17Change`
  * Event `OnLong18Change`
  * Event `OnLong19Change`
  * Event `OnLong20Change`
  * Event `OnLong21Change`
  * Event `OnLong22Change`
  * Event `OnLong23Change`
  * Event `OnLong24Change`
  * Event `OnLong25Change`
  * Event `OnLong26Change`
  * Event `OnLong27Change`
  * Event `OnLong28Change`
  * Event `OnLong29Change`
  * Event `OnLong30Change`
  * Event `OnLong31Change`
  * Event `OnLong32Change`
  * Event `OnLong33Change`
  * Event `OnLong34Change`
  * Event `OnLong35Change`
  * Event `OnLong36Change`
  * Event `OnLong37Change`
  * Event `OnLong38Change`
  * Event `OnLong39Change`
  * Event `OnLong40Change`
  * Event `OnLong41Change`
  * Event `OnLong42Change`
  * Event `OnLong43Change`
  * Event `OnLong44Change`
  * Event `OnLong45Change`
  * Event `OnLong46Change`
  * Event `OnLong47Change`
  * Event `OnLong48Change`
  * Event `OnLong49Change`
  * Event `OnLong50Change`
  * Event `OnLong51Change`
  * Event `OnLong52Change`
  * Event `OnLong53Change`
  * Event `OnLong54Change`
  * Event `OnLong55Change`
  * Event `OnLong56Change`
  * Event `OnLong57Change`
  * Event `OnLong58Change`
  * Event `OnLong59Change`
  * Event `OnLong60Change`
  * Event `OnString01Change`
  * Event `OnString02Change`
  * Event `OnString03Change`
  * Event `OnString04Change`
  * Event `OnString05Change`
  * Event `OnString06Change`
  * Event `OnString07Change`
  * Event `OnString08Change`
  * Event `OnString09Change`
  * Event `OnString10Change`
  * Event `OnString11Change`
  * Event `OnString12Change`
  * Event `OnString13Change`
  * Event `OnString14Change`
  * Event `OnString15Change`
  * Event `OnString16Change`
  * Event `OnString17Change`
  * Event `OnString18Change`
  * Event `OnString19Change`
  * Event `OnString20Change`
  * Event `OnString21Change`
  * Event `OnString22Change`
  * Event `OnString23Change`
  * Event `OnString24Change`
  * Event `OnString25Change`
  * Event `OnString26Change`
  * Event `OnString27Change`
  * Event `OnString28Change`
  * Event `OnString29Change`
  * Event `OnString30Change`
  * Event `OnString31Change`
  * Event `OnString32Change`
  * Event `OnString33Change`
  * Event `OnString34Change`
  * Event `OnString35Change`
  * Event `OnString36Change`
  * Event `OnString37Change`
  * Event `OnString38Change`
  * Event `OnString39Change`
  * Event `OnString40Change`

##### SuperOffice.CRM.Rows.URLRow is Modified

* Deleted items
  * Event `OnContactIdChange`
  * Event `OnDescriptionChange`
  * Event `OnPersonIdChange`
  * Event `OnProjectIdChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnReservedId1Change`
  * Event `OnReservedId2Change`
  * Event `OnTypeChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUrlAddressChange`

##### SuperOffice.CRM.Rows.UsageStatsRow is Modified

* Deleted items
  * Event `OnAssocIdChange`
  * Event `OnData1Change`
  * Event `OnData2Change`
  * Event `OnData3Change`
  * Event `OnData4Change`
  * Event `OnData5Change`
  * Event `OnFunctionIdChange`
  * Event `OnSubIdChange`
  * Event `OnUsesChange`

##### SuperOffice.CRM.Rows.UserAttributeRow is Modified

* Deleted items
  * Event `OnAttKeyChange`
  * Event `OnAttValueChange`
  * Event `OnUserIdChange`

##### SuperOffice.CRM.Rows.UserCandidateRow is Modified

* Deleted items
  * Event `OnPersonIdChange`
  * Event `OnSecretKeyChange`
  * Event `OnSecretValueChange`

##### SuperOffice.CRM.Rows.UserGroupLinkRow is Modified

* Deleted items
  * Event `OnAssocIdChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRemarkChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUserGroupIdChange`
  * Event `OnValidFromChange`
  * Event `OnValidToChange`

##### SuperOffice.CRM.Rows.UserGroupRow is Modified

* Deleted items
  * Event `OnDeletedChange`
  * Event `OnNameChange`
  * Event `OnRankChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTooltipChange`
  * Event `OnTypeChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.UserPreferenceRow is Modified

* Deleted items
  * Event `OnDeflevelChange`
  * Event `OnMaxlevelChange`
  * Event `OnOwnerIdChange`
  * Event `OnPrefkeyChange`
  * Event `OnPrefsectionChange`
  * Event `OnPrefvalueChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.UserRoleLinkRow is Modified

* Deleted items
  * Event `OnAssociateIdChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnLinkTypeChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnRoleIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.VisibleForRow is Modified

* Deleted items
  * Event `OnAppointmentIdChange`
  * Event `OnEncryptedCheckChange`
  * Event `OnForAllChange`
  * Event `OnForAssocIdChange`
  * Event `OnForGroupIdChange`
  * Event `OnRecordIdChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSaleHistIdChange`
  * Event `OnSaleIdChange`
  * Event `OnSelectionIdChange`
  * Event `OnTableIdChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.WebAppUsageRow is Modified

* Deleted items
  * Event `OnAggregateBinChange`
  * Event `OnAggregateCountChange`
  * Event `OnAssocIdChange`
  * Event `OnTimestampChange`
  * Event `OnVersionChange`
  * Event `OnViewStateChange`

##### SuperOffice.CRM.Rows.WebhookRow is Modified

* Deleted items
  * Event `OnApplicationTokenChange`
  * Event `OnEventsChange`
  * Event `OnHeadersChange`
  * Event `OnNameChange`
  * Event `OnPropertiesChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnSecretChange`
  * Event `OnStateChange`
  * Event `OnTargetUrlChange`
  * Event `OnTypeChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.WebhookUsageRow is Modified

* Deleted items
  * Event `OnConsecutiveErrorsChange`
  * Event `OnLastErrorChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnTotalCallsChange`
  * Event `OnTotalErrorsChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`

##### SuperOffice.CRM.Rows.WinPosSizeRow is Modified

* Deleted items
  * Event `OnAssocIdChange`
  * Event `OnExtraIdChange`
  * Event `OnExtraInfoChange`
  * Event `OnHeightChange`
  * Event `OnLeftXChange`
  * Event `OnOwnerChange`
  * Event `OnRegisteredAssociateIdChange`
  * Event `OnRegisteredChange`
  * Event `OnStateChange`
  * Event `OnUpdatedAssociateIdChange`
  * Event `OnUpdatedChange`
  * Event `OnUpdatedCountChange`
  * Event `OnUpperYChange`
  * Event `OnWidthChange`

##### SuperOffice.CRM.Rows.WordRelationsRow is Modified

* Deleted items
  * Event `OnEntryIdChange`
  * Event `OnEntryWordIdChange`
  * Event `OnRelationOriginChange`
  * Event `OnUsedChange`

##### SuperOffice.CRM.Rows.WsdlDescriptionRow is Modified

* Deleted items
  * Event `OnBodyChange`
  * Event `OnNameChange`

##### SuperOffice.CRM.Rows.ZipToCityRow is Modified

* Deleted items
  * Event `OnCityChange`
  * Event `OnCountryIdChange`
  * Event `OnUpdatedCountChange`
  * Event `OnZipcodeChange`

##### SuperOffice.CRM.Sale.QuoteManager is Modified

* Deleted items
  * Method `GetStateImageAndText(QuoteVersionState, DateTime, String&, String&, String&)`
* New items
  * Method `CancelQuoteApprovalRequest(Int32)`
  * Method `GetStateImageAndText(QuoteVersionInfo, DateTime, String&, String&, String&)`
  * Method `RequestQuoteApproval(Int32, Int32, String)`

##### SuperOffice.Data.Cache.CacheBaseV2 is Modified

* New items
  * Property `Disposed`
  * Method `GetCurrent<T>()`

##### SuperOffice.Data.Dictionary.SoDictionary is Modified

* Deleted items
  * Method `GetDictionary()`

##### SuperOffice.Data.Dictionary.SoField is Modified

* New items
  * Property `TimeZoneInterpretation`

##### SuperOffice.Data.Private.FreetextIndexerLogic is Modified

* Deleted items
  * Method `GetWordsFromString(String, Boolean)`
* New items
  * Method `GetWordsFromString(String, Boolean, Boolean)`

##### SuperOffice.Data.PrivateDbConnectionFactory is Modified

* Deleted items
  * Method `CreateExplicit(String, String, String, String)`
* New items
  * Method `CreateExplicit(String, String)`

##### SuperOffice.Data.SoDatabase is Modified

* Deleted items
  * Method `ClearAllPools()`
  * Method `LogOut()`

##### SuperOffice.Data.SoftTrigger is Modified

* Modified items
  * Method `SubscribeOnPostChange(Int32, OnChange)`
  * Method `SubscribeOnPreChange(Int32, OnChange)`
  * Method `UnsubscribeOnPostChange(Int32, OnChange)`
  * Method `UnsubscribeOnPreChange(Int32, OnChange)`
* New items
  * Method `SubscribeOnPostChange(String, OnChange)`
  * Method `SubscribeOnPreChange(String, OnChange)`
  * Method `UnsubscribeOnPostChange(String, OnChange)`
  * Method `UnsubscribeOnPreChange(String, OnChange)`

##### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetConfigurableScreenAppliesToTableInfo()`
  * Method `GetQuoteApprReasonGroupLinkTableInfo()`
  * Method `GetQuoteApprReasonHeadingLinkTableInfo()`
  * Method `GetQuoteApprReasonTableInfo()`
  * Method `GetQuoteDenyReasonGroupLinkTableInfo()`
  * Method `GetQuoteDenyReasonHeadingLinkTableInfo()`
  * Method `GetQuoteDenyReasonTableInfo()`
  * Method `GetTargetDimensionTableInfo()`

##### SuperOffice.Security.ISoIdentityResolver is Modified

* Deleted items
  * Method `ResolveIdentity(IList<SecurityToken>, SoConnection, String&)`
* New items
  * Method `ResolveIdentity(IEnumerable<ClaimsIdentity>, SoConnection, String&)`

##### SuperOffice.Security.Principal.DefaultTokenContextResolver is Modified

* Deleted items
  * Method `TryResolveContext(SecurityToken[], String&)`
  * Method `TryResolveContextFromAccessToken(SecurityToken[], String&)`
  * Method `TryResolveContextFromTicket(SecurityToken[], String&)`
* New items
  * Method `TryResolveContextFromClaims(IEnumerable<ClaimsIdentity>, String&)`
  * Method `TryResolveContextFromTicketClaim(IEnumerable<ClaimsIdentity>, String&)`
  * Method `TryResolveContextSoAccessTokenClaim(IEnumerable<ClaimsIdentity>, String&)`

##### SuperOffice.Security.Principal.ISoIdentityValidator is Modified

* Deleted items
  * Method `TryValidateIdentity(IList<SecurityToken>, ISoIdentity, SoConnection, String&)`
* New items
  * Method `TryValidateIdentity(IEnumerable<ClaimsIdentity>, ISoIdentity, SoConnection, String&)`

##### SuperOffice.Security.Principal.OidcSoIdentity is Modified

* Deleted items
  * Property `Source`
  * Method `OidcSoIdentity(Int32, String, Int32, String, String, OidcSecurityToken)`
* Modified items
  * Property `InnerIdentity`
* New items
  * Method `OidcSoIdentity(Int32, String, String, Int32, String, String)`

##### SuperOffice.Security.Principal.OidcSoIdentityResolver is Modified

* Deleted items
  * Method `ResolveIdentity(IList<SecurityToken>, SoConnection, String&)`
* New items
  * Method `ResolveIdentity(IEnumerable<ClaimsIdentity>, SoConnection, String&)`

##### SuperOffice.Security.Principal.SoAccessTokenHelper is Modified

* Deleted items
  * Method `Decrypt(SoAccessTokenSecurityToken)`
* New items
  * Method `GetClaimsIdentity(SoAccessToken, String)`
  * Method `TryGetFromClaimsIdentity(ClaimsIdentity, SoAccessToken&)`

##### SuperOffice.Security.Principal.SoCredentialsIdentity is Modified

* Deleted items
  * Property `Source`

##### SuperOffice.Security.Principal.SoCredentialsIdentityResolver is Modified

* Deleted items
  * Method `ResolveIdentity(IList<SecurityToken>, SoConnection, String&)`
* New items
  * Method `ResolveIdentity(IEnumerable<ClaimsIdentity>, SoConnection, String&)`

##### SuperOffice.Security.Principal.SoCredentialsIdentityValidator is Modified

* Deleted items
  * Method `TryValidateIdentity(IList<SecurityToken>, ISoIdentity, SoConnection, String&)`
* New items
  * Method `TryValidateIdentity(IEnumerable<ClaimsIdentity>, ISoIdentity, SoConnection, String&)`

##### SuperOffice.Security.Principal.SoImpersonationIdentity is Modified

* Deleted items
  * Property `Source`

##### SuperOffice.Security.Principal.SoImpersonationIdentityResolver is Modified

* Deleted items
  * Method `ResolveIdentity(IList<SecurityToken>, SoConnection, String&)`
* New items
  * Method `ResolveIdentity(IEnumerable<ClaimsIdentity>, SoConnection, String&)`

##### SuperOffice.Security.Principal.SoImpersonationIdentityValidator is Modified

* Deleted items
  * Method `TryValidateIdentity(IList<SecurityToken>, ISoIdentity, SoConnection, String&)`
* New items
  * Method `TryValidateIdentity(IEnumerable<ClaimsIdentity>, ISoIdentity, SoConnection, String&)`

##### SuperOffice.Security.Principal.SoWindowsIdentity is Modified

* Deleted items
  * Property `Source`

##### SuperOffice.Security.Principal.UserNameIdentity is Modified

* Deleted items
  * Property `Source`

##### SuperOffice.Security.Principal.UserNameIdentityResolver is Modified

* Deleted items
  * Method `ResolveIdentity(IList<SecurityToken>, SoConnection, String&)`
* New items
  * Method `ResolveIdentity(IEnumerable<ClaimsIdentity>, SoConnection, String&)`

##### SuperOffice.Security.Principal.UserNameIdentityValidator is Modified

* Deleted items
  * Method `TryValidateIdentity(IList<SecurityToken>, ISoIdentity, SoConnection, String&)`
* New items
  * Method `TryValidateIdentity(IEnumerable<ClaimsIdentity>, ISoIdentity, SoConnection, String&)`

##### SuperOffice.Security.Principal.WindowsIdentityResolver is Modified

* Deleted items
  * Method `ResolveFilteredIdentity(IList<SecurityToken>, SoConnection, AcceptToken)`

###### SuperOffice.Security.Principal.WindowsIdentityResolver.AcceptToken is Deleted

* New items
  * Method `ResolveFilteredIdentity(IEnumerable<ClaimsIdentity>, SoConnection, AcceptIdentity)`

###### SuperOffice.Security.Principal.WindowsIdentityResolver.AcceptIdentity is New

##### SuperOffice.Security.Principal.WindowsIdentityValidator is Modified

* Deleted items
  * Method `TryValidateIdentity(IList<SecurityToken>, ISoIdentity, SoConnection, String&)`
* New items
  * Method `TryValidateIdentity(IEnumerable<ClaimsIdentity>, ISoIdentity, SoConnection, String&)`

##### SuperOffice.Security.Principal.WindowsOtherIdentityResolver is Modified

* Deleted items
  * Method `ResolveIdentity(IList<SecurityToken>, SoConnection, String&)`
* New items
  * Method `ResolveIdentity(IEnumerable<ClaimsIdentity>, SoConnection, String&)`

##### SuperOffice.Security.Principal.WindowsPersonIdentityResolver is Modified

* Deleted items
  * Method `ResolveIdentity(IList<SecurityToken>, SoConnection, String&)`
* New items
  * Method `ResolveIdentity(IEnumerable<ClaimsIdentity>, SoConnection, String&)`

##### SuperOffice.Util.TargetHelper is Modified

* Deleted items
  * Method `TargetPeriod(DateTime)`
* New items
  * Method `TargetPeriod(DateTime, TargetPeriodType)`

#### Assembly: SuperOffice.Plugins

#### Deleted Types

* `SuperOffice.Security.ISoSecurityTokenSupplier`
* `SuperOffice.Security.SoSecurityTokenSupplierAttribute`

#### New Types

* `SuperOffice.CRM.IContactInfo3`
* `SuperOffice.CRM.IPersonInfo3`
* `SuperOffice.CRM.IProjectInfo3`
* `SuperOffice.CRM.IQuoteConnector2`
* `SuperOffice.CRM.ISaleInfo3`
* `SuperOffice.CRM.IUserInfo`
* `SuperOffice.CRM.IUserInfo2`
* `SuperOffice.CRM.UserInfo2`
* `SuperOffice.Security.Claims.ClaimsExtensions`
* `SuperOffice.Security.Claims.ClaimsIdentitiesBuilder`
* `SuperOffice.Security.Claims.ClaimsIdentitiesExtensions`
* `SuperOffice.Security.Claims.ClaimsIdentityBuilder`
* `SuperOffice.Security.Claims.SoClaimTypes`
* `SuperOffice.Security.IImplicitIdentitySupplier`
* `SuperOffice.Security.ImplicitIdentitySupplierAttribute`

#### Modified Types

##### SuperOffice.CRM.CRMQuoteConnectorCapabilities is Modified

* New items
  * Field `NoCacheImages`
  * Field `NoCacheQuotelists`

##### SuperOffice.CRM.Globalization.CultureDataFormatter is Modified

* Modified items
  * Method `MapSuperOfficeLanguageToCulture(String)`

##### SuperOffice.CRM.QuoteConnectorBase is Modified

* New items
  * Method `OnQuoteVersionApproved(QuoteVersionContextInfo)`
  * Method `OnQuoteVersionRejected(QuoteVersionContextInfo)`
  * Method `OnQuoteVersionRequestApproval(QuoteVersionContextInfo)`

##### SuperOffice.CRM.QuoteVersionInfo is Modified

* New items
  * Property `RequestAssociateId`
  * Property `RequestComment`

##### SuperOffice.CRM.UserInfo is Modified

* Modified items
  * Property `AssociateId`
  * Property `AssociateName`
  * Property `CountryDomainName`
  * Property `CountryId`
  * Property `CountryName`
  * Property `Email`
  * Property `FullName`
  * Property `FunctionRights`
  * Property `Licenses`
  * Property `RoleId`
  * Property `RoleName`
  * Property `Ticket`

##### SuperOffice.Factory.PluginFactory is Modified

* New items
  * Method `Remove(PluginInfo)`

##### SuperOffice.Security.ISoSecurityTokenValidator is Modified

* Deleted items
  * Method `TryValidateTokens(IList<SecurityToken>, String&)`
* New items
  * Method `TryValidateTokens(IEnumerable<ClaimsIdentity>, String&)`

### Continuous Database

The following represent changes to SuperOffice database schema.

No changes detected.
