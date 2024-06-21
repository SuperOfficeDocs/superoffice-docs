---
uid: version_10.2.1.1698_changes
date: 2/2/2023
generated: 1
---

# Changes from v10.1.9.1223 and v10.2.1.1698

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Deleted Types

* `SuperOffice.CRM.Services.PrivateAIAgentFactory`
* `SuperOffice.CRM.Services.PrivateAppointmentAgentFactory`
* `SuperOffice.CRM.Services.PrivateArchiveAgentFactory`
* `SuperOffice.CRM.Services.PrivateAssociateAgentFactory`
* `SuperOffice.CRM.Services.PrivateAudienceAgentFactory`
* `SuperOffice.CRM.Services.PrivateBatchAgentFactory`
* `SuperOffice.CRM.Services.PrivateBLOBAgentFactory`
* `SuperOffice.CRM.Services.PrivateBulkUpdateAgentFactory`
* `SuperOffice.CRM.Services.PrivateChatAgentFactory`
* `SuperOffice.CRM.Services.PrivateContactAgentFactory`
* `SuperOffice.CRM.Services.PrivateCRMScriptAgentFactory`
* `SuperOffice.CRM.Services.PrivateCustomerServiceAgentFactory`
* `SuperOffice.CRM.Services.PrivateDashAgentFactory`
* `SuperOffice.CRM.Services.PrivateDashboardAgentFactory`
* `SuperOffice.CRM.Services.PrivateDatabaseAgentFactory`
* `SuperOffice.CRM.Services.PrivateDatabaseTableAgentFactory`
* `SuperOffice.CRM.Services.PrivateDiagnosticsAgentFactory`
* `SuperOffice.CRM.Services.PrivateDocumentAgentFactory`
* `SuperOffice.CRM.Services.PrivateDocumentMigrationAgentFactory`
* `SuperOffice.CRM.Services.PrivateEMailAgentFactory`
* `SuperOffice.CRM.Services.PrivateErpSyncAgentFactory`
* `SuperOffice.CRM.Services.PrivateFavouriteAgentFactory`
* `SuperOffice.CRM.Services.PrivateFindAgentFactory`
* `SuperOffice.CRM.Services.PrivateForeignSystemAgentFactory`
* `SuperOffice.CRM.Services.PrivateFreeTextAgentFactory`
* `SuperOffice.CRM.Services.PrivateImportAgentFactory`
* `SuperOffice.CRM.Services.PrivateLicenseAgentFactory`
* `SuperOffice.CRM.Services.PrivateListAgentFactory`
* `SuperOffice.CRM.Services.PrivateMarketingAgentFactory`
* `SuperOffice.CRM.Services.PrivateMDOAgentFactory`
* `SuperOffice.CRM.Services.PrivateNumberAllocationAgentFactory`
* `SuperOffice.CRM.Services.PrivatePartnerAgentFactory`
* `SuperOffice.CRM.Services.PrivatePersonAgentFactory`
* `SuperOffice.CRM.Services.PrivatePhoneListAgentFactory`
* `SuperOffice.CRM.Services.PrivatePocketAgentFactory`
* `SuperOffice.CRM.Services.PrivatePreferenceAgentFactory`
* `SuperOffice.CRM.Services.PrivateProjectAgentFactory`
* `SuperOffice.CRM.Services.PrivateQuoteAgentFactory`
* `SuperOffice.CRM.Services.PrivateRelationAgentFactory`
* `SuperOffice.CRM.Services.PrivateReplicationAgentFactory`
* `SuperOffice.CRM.Services.PrivateReportAgentFactory`
* `SuperOffice.CRM.Services.PrivateResourceAgentFactory`
* `SuperOffice.CRM.Services.PrivateSaintAgentFactory`
* `SuperOffice.CRM.Services.PrivateSaleAgentFactory`
* `SuperOffice.CRM.Services.PrivateSelectionAgentFactory`
* `SuperOffice.CRM.Services.PrivateSentryAgentFactory`
* `SuperOffice.CRM.Services.PrivateTargetsAgentFactory`
* `SuperOffice.CRM.Services.PrivateTicketAgentFactory`
* `SuperOffice.CRM.Services.PrivateTimeZoneAgentFactory`
* `SuperOffice.CRM.Services.PrivateUserAgentFactory`
* `SuperOffice.CRM.Services.PrivateUserDefinedFieldInfoAgentFactory`
* `SuperOffice.CRM.Services.PrivateViewStateAgentFactory`
* `SuperOffice.CRM.Services.PrivateWebhookAgentFactory`
* `SuperOffice.CRM.Services.Reflection.AgentLocalAttribute`
* `SuperOffice.CRM.Services.Reflection.AgentSwitchAttribute`
* `SuperOffice.CRM.Services.Reflection.ServiceAttribute`
* `SuperOffice.CRM.Services.Reflection.ServiceImplementationAttribute`
* `SuperOffice.CRM.Services.Reflection.ServiceSwitchAttribute`

### New Types

* `SuperOffice.CRM.Services.AttachmentValidationResult`
* `SuperOffice.CRM.Services.PersonImage`
* `SuperOffice.CRM.Services.RelatedData`
* `SuperOffice.CRM.Services.TaskMenu`
* `SuperOffice.CRM.Services.UserPresenceStatus`

### Modified Types

#### SuperOffice.CRM.Services.AccessGatewayInfo is Modified


#### SuperOffice.CRM.Services.ActivityFilter is Modified


#### SuperOffice.CRM.Services.ActivityInformationListItem is Modified


#### SuperOffice.CRM.Services.ActivitySummary is Modified


#### SuperOffice.CRM.Services.ActivitySummaryItem is Modified


#### SuperOffice.CRM.Services.Address is Modified


#### SuperOffice.CRM.Services.AddressSyncData is Modified


#### SuperOffice.CRM.Services.AIAgent is Modified


#### SuperOffice.CRM.Services.AlarmData is Modified


#### SuperOffice.CRM.Services.AmountClassEntity is Modified


#### SuperOffice.CRM.Services.Appointment is Modified


#### SuperOffice.CRM.Services.AppointmentAgent is Modified


#### SuperOffice.CRM.Services.AppointmentEntity is Modified


#### SuperOffice.CRM.Services.AppointmentSyncData is Modified


#### SuperOffice.CRM.Services.ApproveRejectResponse is Modified


#### SuperOffice.CRM.Services.ArchiveAgent is Modified

* New items
  * Method `GetRelatedData(String, Int32, String[])`
  * Method `GetRelatedData2(String, Int32, String)`

#### SuperOffice.CRM.Services.ArchiveConfiguration is Modified


#### SuperOffice.CRM.Services.ArchiveListItem is Modified


#### SuperOffice.CRM.Services.ArchiveListResult is Modified


#### SuperOffice.CRM.Services.Area is Modified


#### SuperOffice.CRM.Services.Associate is Modified


#### SuperOffice.CRM.Services.AssociateAgent is Modified


#### SuperOffice.CRM.Services.AttachmentEntity is Modified


#### SuperOffice.CRM.Services.AudienceAgent is Modified


#### SuperOffice.CRM.Services.AudienceConfigParameter is Modified


#### SuperOffice.CRM.Services.AudienceLayoutEntity is Modified


#### SuperOffice.CRM.Services.Batch is Modified


#### SuperOffice.CRM.Services.BatchAgent is Modified


#### SuperOffice.CRM.Services.BatchTaskInfo is Modified

* New items
  * Property `CancellationBehaviour`

#### SuperOffice.CRM.Services.BLOBAgent is Modified


#### SuperOffice.CRM.Services.BlobEntity is Modified


#### SuperOffice.CRM.Services.BulkUpdateAgent is Modified


#### SuperOffice.CRM.Services.Business is Modified


#### SuperOffice.CRM.Services.Cache is Modified


#### SuperOffice.CRM.Services.CallerID is Modified


#### SuperOffice.CRM.Services.CallerIDCollection is Modified


#### SuperOffice.CRM.Services.CategorizationModelDetails is Modified


#### SuperOffice.CRM.Services.CategorizationStatusResponse is Modified


#### SuperOffice.CRM.Services.Category is Modified


#### SuperOffice.CRM.Services.CategoryGuess is Modified


#### SuperOffice.CRM.Services.ChangedData is Modified


#### SuperOffice.CRM.Services.ChangedDataItem is Modified


#### SuperOffice.CRM.Services.ChatAgent is Modified


#### SuperOffice.CRM.Services.ChatBotSettings is Modified


#### SuperOffice.CRM.Services.ChatMessage is Modified


#### SuperOffice.CRM.Services.ChatOpeningHours is Modified


#### SuperOffice.CRM.Services.ChatPresence is Modified


#### SuperOffice.CRM.Services.ChatSession is Modified


#### SuperOffice.CRM.Services.ChatSessionEntity is Modified


#### SuperOffice.CRM.Services.ChatSummaryItem is Modified


#### SuperOffice.CRM.Services.ChatTopicAgent is Modified


#### SuperOffice.CRM.Services.ChatTopicEntity is Modified


#### SuperOffice.CRM.Services.ChatWidgetSettings is Modified


#### SuperOffice.CRM.Services.ColumnDataDictionary is Modified


#### SuperOffice.CRM.Services.ColumnDataDictionaryExt is Modified


#### SuperOffice.CRM.Services.CommandResult is Modified


#### SuperOffice.CRM.Services.Competitor is Modified


#### SuperOffice.CRM.Services.ConsentInfo is Modified


#### SuperOffice.CRM.Services.ConsentPerson is Modified


#### SuperOffice.CRM.Services.ConsentPurpose is Modified


#### SuperOffice.CRM.Services.ConsentSource is Modified


#### SuperOffice.CRM.Services.Contact is Modified

* New items
  * Property `Number1`
  * Property `Number2`

#### SuperOffice.CRM.Services.ContactActivity is Modified


#### SuperOffice.CRM.Services.ContactAgent is Modified


#### SuperOffice.CRM.Services.ContactEntity is Modified


#### SuperOffice.CRM.Services.ContactOrPersonFromEmail is Modified


#### SuperOffice.CRM.Services.ContactPersonId is Modified


#### SuperOffice.CRM.Services.ContactRelationEntity is Modified


#### SuperOffice.CRM.Services.ContactSummary is Modified


#### SuperOffice.CRM.Services.ControlInfo is Modified


#### SuperOffice.CRM.Services.Country is Modified


#### SuperOffice.CRM.Services.Credential is Modified


#### SuperOffice.CRM.Services.CredentialsGroup is Modified


#### SuperOffice.CRM.Services.CredentialsGroupUsers is Modified


#### SuperOffice.CRM.Services.CredentialType is Modified


#### SuperOffice.CRM.Services.CredentialUser is Modified


#### SuperOffice.CRM.Services.Credited is Modified


#### SuperOffice.CRM.Services.CriteriaInformation is Modified


#### SuperOffice.CRM.Services.CRMScriptAgent is Modified


#### SuperOffice.CRM.Services.CRMScriptEntity is Modified


#### SuperOffice.CRM.Services.CRMScriptResult is Modified


#### SuperOffice.CRM.Services.CsFeatureToggle is Modified


#### SuperOffice.CRM.Services.CsSessionKey is Modified


#### SuperOffice.CRM.Services.Currency is Modified


#### SuperOffice.CRM.Services.CurrencyEntity is Modified


#### SuperOffice.CRM.Services.CustomCommand is Modified


#### SuperOffice.CRM.Services.CustomerCenterConfig is Modified


#### SuperOffice.CRM.Services.CustomerLanguage is Modified


#### SuperOffice.CRM.Services.CustomerServiceAgent is Modified


#### SuperOffice.CRM.Services.CustomerServiceConfig is Modified


#### SuperOffice.CRM.Services.CustomerServiceStartup is Modified


#### SuperOffice.CRM.Services.Dash is Modified


#### SuperOffice.CRM.Services.DashAgent is Modified


#### SuperOffice.CRM.Services.Dashboard is Modified


#### SuperOffice.CRM.Services.DashboardAgent is Modified


#### SuperOffice.CRM.Services.DashboardTile is Modified


#### SuperOffice.CRM.Services.DashboardTileOption is Modified


#### SuperOffice.CRM.Services.DashCollection is Modified


#### SuperOffice.CRM.Services.DashTheme is Modified


#### SuperOffice.CRM.Services.DashTile is Modified


#### SuperOffice.CRM.Services.DashTileDefinition is Modified


#### SuperOffice.CRM.Services.DashTileHtml is Modified


#### SuperOffice.CRM.Services.DatabaseAgent is Modified


#### SuperOffice.CRM.Services.DatabaseTableAgent is Modified


#### SuperOffice.CRM.Services.DataRight is Modified


#### SuperOffice.CRM.Services.DataRights is Modified


#### SuperOffice.CRM.Services.DayInformationListItem is Modified


#### SuperOffice.CRM.Services.DeliveryTerm is Modified


#### SuperOffice.CRM.Services.DeliveryType is Modified


#### SuperOffice.CRM.Services.Department is Modified


#### SuperOffice.CRM.Services.DiagnosticsAgent is Modified


#### SuperOffice.CRM.Services.DictionaryStepInformation is Modified


#### SuperOffice.CRM.Services.Document is Modified


#### SuperOffice.CRM.Services.DocumentAgent is Modified


#### SuperOffice.CRM.Services.DocumentEntity is Modified


#### SuperOffice.CRM.Services.DocumentMigrationAgent is Modified


#### SuperOffice.CRM.Services.DocumentMigrationAssociate is Modified


#### SuperOffice.CRM.Services.DocumentMigrationItem is Modified


#### SuperOffice.CRM.Services.DocumentMigrationItemList is Modified


#### SuperOffice.CRM.Services.DocumentPreview is Modified


#### SuperOffice.CRM.Services.DocumentTemplate is Modified


#### SuperOffice.CRM.Services.DocumentTemplateEntity is Modified


#### SuperOffice.CRM.Services.DocumentTemplateMigrationList is Modified


#### SuperOffice.CRM.Services.DuplicateEntry is Modified


#### SuperOffice.CRM.Services.DuplicateRule is Modified


#### SuperOffice.CRM.Services.EMailAccount is Modified


#### SuperOffice.CRM.Services.EMailAddress is Modified


#### SuperOffice.CRM.Services.EMailAgent is Modified

* New items
  * Method `HasSPFRecord(String, String)`

#### SuperOffice.CRM.Services.EMailAppointment is Modified


#### SuperOffice.CRM.Services.EMailAttachment is Modified


#### SuperOffice.CRM.Services.EMailConnectionInfo is Modified


#### SuperOffice.CRM.Services.EMailConnectionInfoExtended is Modified


#### SuperOffice.CRM.Services.EMailCustomHeader is Modified


#### SuperOffice.CRM.Services.EMailEntity is Modified


#### SuperOffice.CRM.Services.EMailEnvelope is Modified


#### SuperOffice.CRM.Services.EMailFolder is Modified


#### SuperOffice.CRM.Services.EMailSOInfo is Modified


#### SuperOffice.CRM.Services.EntityElement is Modified


#### SuperOffice.CRM.Services.EntityName is Modified


#### SuperOffice.CRM.Services.ErpConnection is Modified


#### SuperOffice.CRM.Services.ErpConnectionData is Modified


#### SuperOffice.CRM.Services.ErpConnectionListMapping is Modified


#### SuperOffice.CRM.Services.ErpConnectionListMappingContainer is Modified


#### SuperOffice.CRM.Services.ErpCrmListItemMapping is Modified


#### SuperOffice.CRM.Services.ErpSyncActorSummary is Modified


#### SuperOffice.CRM.Services.ErpSyncActorTypeMapping is Modified


#### SuperOffice.CRM.Services.ErpSyncAgent is Modified


#### SuperOffice.CRM.Services.ErpSyncConnectionSummary is Modified


#### SuperOffice.CRM.Services.ErpSyncConnectorEntity is Modified


#### SuperOffice.CRM.Services.ErpSyncDefaultValue is Modified


#### SuperOffice.CRM.Services.ErpSyncEngine is Modified


#### SuperOffice.CRM.Services.ErpSyncEngineStatus is Modified


#### SuperOffice.CRM.Services.ErpSyncFieldMapping is Modified


#### SuperOffice.CRM.Services.ErpSyncFieldValue is Modified


#### SuperOffice.CRM.Services.EventData is Modified


#### SuperOffice.CRM.Services.ExportArchiveResult is Modified


#### SuperOffice.CRM.Services.ExtAppEntity is Modified


#### SuperOffice.CRM.Services.Favourite is Modified


#### SuperOffice.CRM.Services.FavouriteAgent is Modified


#### SuperOffice.CRM.Services.FieldInfoAttachment is Modified


#### SuperOffice.CRM.Services.FieldInfoBase is Modified


#### SuperOffice.CRM.Services.FieldInfoBlob is Modified


#### SuperOffice.CRM.Services.FieldInfoBool is Modified


#### SuperOffice.CRM.Services.FieldInfoDate is Modified


#### SuperOffice.CRM.Services.FieldInfoDateTime is Modified


#### SuperOffice.CRM.Services.FieldInfoDecimal is Modified


#### SuperOffice.CRM.Services.FieldInfoDynamicLink is Modified


#### SuperOffice.CRM.Services.FieldInfoInt is Modified


#### SuperOffice.CRM.Services.FieldInfoListText is Modified


#### SuperOffice.CRM.Services.FieldInfoLongText is Modified


#### SuperOffice.CRM.Services.FieldInfoMdoList is Modified


#### SuperOffice.CRM.Services.FieldInfoRelation is Modified


#### SuperOffice.CRM.Services.FieldInfoShortText is Modified


#### SuperOffice.CRM.Services.FieldInfoTime is Modified


#### SuperOffice.CRM.Services.FieldInfoTimeSpan is Modified


#### SuperOffice.CRM.Services.FieldMetadata is Modified


#### SuperOffice.CRM.Services.FieldMetadataDictionary is Modified


#### SuperOffice.CRM.Services.FieldMetadataDictionaryExt is Modified


#### SuperOffice.CRM.Services.FieldValueInfo is Modified


#### SuperOffice.CRM.Services.FindAgent is Modified


#### SuperOffice.CRM.Services.FindResults is Modified


#### SuperOffice.CRM.Services.ForeignAppEntity is Modified


#### SuperOffice.CRM.Services.ForeignDevice is Modified


#### SuperOffice.CRM.Services.ForeignKey is Modified


#### SuperOffice.CRM.Services.ForeignSystemAgent is Modified


#### SuperOffice.CRM.Services.FormEntity is Modified


#### SuperOffice.CRM.Services.FormSubmissionEntity is Modified


#### SuperOffice.CRM.Services.FreeText is Modified


#### SuperOffice.CRM.Services.FreeTextAgent is Modified


#### SuperOffice.CRM.Services.HeadingEntity is Modified


#### SuperOffice.CRM.Services.HierarchyEntity is Modified


#### SuperOffice.CRM.Services.History is Modified


#### SuperOffice.CRM.Services.HistoryRequest is Modified


#### SuperOffice.CRM.Services.IArchiveAgent is Modified

* New items
  * Method `GetRelatedData(String, Int32, String[])`
  * Method `GetRelatedData2(String, Int32, String)`

#### SuperOffice.CRM.Services.IEMailAgent is Modified

* New items
  * Method `HasSPFRecord(String, String)`

#### SuperOffice.CRM.Services.IListAgent is Modified

* New items
  * Method `CreateDefaultTaskMenu()`
  * Method `DeleteAppTaskMenus()`
  * Method `DeleteTaskMenu(Int32)`
  * Method `GetAppTaskMenus()`
  * Method `GetTaskMenu(Int32)`
  * Method `GetTaskMenuByProgId(String)`
  * Method `SaveTaskMenu(TaskMenu)`

#### SuperOffice.CRM.Services.ImportAgent is Modified


#### SuperOffice.CRM.Services.ImportColumnInfo is Modified


#### SuperOffice.CRM.Services.ImportErpData is Modified


#### SuperOffice.CRM.Services.ImportLine is Modified


#### SuperOffice.CRM.Services.Installation is Modified


#### SuperOffice.CRM.Services.IPersonAgent is Modified

* New items
  * Method `CreateDefaultPersonImage()`
  * Method `GetPersonImages(Int32[], Int32, Int32)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `GetTicketMessageWithOptions(Int32, Boolean)`
  * Method `UndeleteByIds(Int32[])`
  * Method `ValidateAttachments(Int32[])`

#### SuperOffice.CRM.Services.IUserAgent is Modified

* New items
  * Method `GetUserPresenceStatus(Int32)`
  * Method `SetUserPresenceStatus(Int32, UserPresenceStatus)`

#### SuperOffice.CRM.Services.IUserDefinedFieldInfoAgent is Modified

* New items
  * Method `ClearCaches()`

#### SuperOffice.CRM.Services.KbCategory is Modified


#### SuperOffice.CRM.Services.LanguageInfo is Modified


#### SuperOffice.CRM.Services.LegalBase is Modified


#### SuperOffice.CRM.Services.License is Modified


#### SuperOffice.CRM.Services.LicenseAgent is Modified


#### SuperOffice.CRM.Services.LicenseOwner is Modified


#### SuperOffice.CRM.Services.LicenseResult is Modified


#### SuperOffice.CRM.Services.Link is Modified


#### SuperOffice.CRM.Services.ListAgent is Modified

* New items
  * Method `CreateDefaultTaskMenu()`
  * Method `DeleteAppTaskMenus()`
  * Method `DeleteTaskMenu(Int32)`
  * Method `GetAppTaskMenus()`
  * Method `GetTaskMenu(Int32)`
  * Method `GetTaskMenuByProgId(String)`
  * Method `SaveTaskMenu(TaskMenu)`

#### SuperOffice.CRM.Services.ListEntity is Modified


#### SuperOffice.CRM.Services.ListItem is Modified


#### SuperOffice.CRM.Services.ListItemEntity is Modified


#### SuperOffice.CRM.Services.LocalizedField is Modified


#### SuperOffice.CRM.Services.LocalizedText is Modified


#### SuperOffice.CRM.Services.Logging is Modified


#### SuperOffice.CRM.Services.Mailbox is Modified


#### SuperOffice.CRM.Services.MailboxEntity is Modified


#### SuperOffice.CRM.Services.MailingStatistics is Modified


#### SuperOffice.CRM.Services.MailMergeSettings is Modified


#### SuperOffice.CRM.Services.MailMergeTask is Modified


#### SuperOffice.CRM.Services.MarketingAgent is Modified


#### SuperOffice.CRM.Services.MassOperationResult is Modified


#### SuperOffice.CRM.Services.MDOAgent is Modified


#### SuperOffice.CRM.Services.MDOListItem is Modified


#### SuperOffice.CRM.Services.ModuleLicenseLink is Modified


#### SuperOffice.CRM.Services.MrMrs is Modified


#### SuperOffice.CRM.Services.MultiAlarmData is Modified


#### SuperOffice.CRM.Services.NotificationEvent is Modified


#### SuperOffice.CRM.Services.NumberAllocationAgent is Modified


#### SuperOffice.CRM.Services.OperationInfo is Modified


#### SuperOffice.CRM.Services.OperationResult is Modified


#### SuperOffice.CRM.Services.ParticipantSyncData is Modified


#### SuperOffice.CRM.Services.PartnerAgent is Modified


#### SuperOffice.CRM.Services.PaymentTerm is Modified


#### SuperOffice.CRM.Services.PaymentType is Modified


#### SuperOffice.CRM.Services.Person is Modified


#### SuperOffice.CRM.Services.PersonAgent is Modified

* New items
  * Method `CreateDefaultPersonImage()`
  * Method `GetPersonImages(Int32[], Int32, Int32)`

#### SuperOffice.CRM.Services.PersonEntity is Modified


#### SuperOffice.CRM.Services.PersonSummary is Modified


#### SuperOffice.CRM.Services.PhoneListAgent is Modified


#### SuperOffice.CRM.Services.PhoneListItem is Modified


#### SuperOffice.CRM.Services.PhoneListPreferences is Modified


#### SuperOffice.CRM.Services.PluginResponse is Modified


#### SuperOffice.CRM.Services.PluginUrlResponse is Modified


#### SuperOffice.CRM.Services.PocketAgent is Modified


#### SuperOffice.CRM.Services.PocketDeviceInfo is Modified


#### SuperOffice.CRM.Services.PocketNotificationMessage is Modified


#### SuperOffice.CRM.Services.PocketStartupData is Modified


#### SuperOffice.CRM.Services.Position is Modified


#### SuperOffice.CRM.Services.Preference is Modified


#### SuperOffice.CRM.Services.PreferenceAgent is Modified


#### SuperOffice.CRM.Services.PreferenceDescription is Modified


#### SuperOffice.CRM.Services.PreferenceDescriptionLine is Modified


#### SuperOffice.CRM.Services.PreferenceSpec is Modified


#### SuperOffice.CRM.Services.PreferredTimeZone is Modified


#### SuperOffice.CRM.Services.PreviewContact is Modified


#### SuperOffice.CRM.Services.PreviewDash is Modified


#### SuperOffice.CRM.Services.PreviewDashTile is Modified


#### SuperOffice.CRM.Services.PreviewFaqEntry is Modified


#### SuperOffice.CRM.Services.PreviewMailing is Modified


#### SuperOffice.CRM.Services.PreviewMailingHeader is Modified


#### SuperOffice.CRM.Services.PreviewQuickReply is Modified


#### SuperOffice.CRM.Services.PreviewReplyTemplate is Modified


#### SuperOffice.CRM.Services.PriceList is Modified


#### SuperOffice.CRM.Services.Priority is Modified


#### SuperOffice.CRM.Services.Product is Modified


#### SuperOffice.CRM.Services.ProductCategory is Modified


#### SuperOffice.CRM.Services.ProductExtraDataField is Modified


#### SuperOffice.CRM.Services.ProductFamily is Modified


#### SuperOffice.CRM.Services.ProductType is Modified


#### SuperOffice.CRM.Services.Project is Modified


#### SuperOffice.CRM.Services.ProjectAgent is Modified


#### SuperOffice.CRM.Services.ProjectEntity is Modified


#### SuperOffice.CRM.Services.ProjectEvent is Modified


#### SuperOffice.CRM.Services.ProjectEventEntity is Modified


#### SuperOffice.CRM.Services.ProjectMember is Modified


#### SuperOffice.CRM.Services.ProjectStatus is Modified


#### SuperOffice.CRM.Services.ProjectType is Modified


#### SuperOffice.CRM.Services.ProjectTypeEntity is Modified


#### SuperOffice.CRM.Services.ProjectTypeStatusLink is Modified


#### SuperOffice.CRM.Services.QuickReply is Modified


#### SuperOffice.CRM.Services.Quote is Modified


#### SuperOffice.CRM.Services.QuoteAgent is Modified


#### SuperOffice.CRM.Services.QuoteAlternative is Modified


#### SuperOffice.CRM.Services.QuoteAlternativeRecalculated is Modified


#### SuperOffice.CRM.Services.QuoteApproveReason is Modified


#### SuperOffice.CRM.Services.QuoteConnection is Modified


#### SuperOffice.CRM.Services.QuoteContext is Modified


#### SuperOffice.CRM.Services.QuoteDenyReason is Modified


#### SuperOffice.CRM.Services.QuoteEntity is Modified


#### SuperOffice.CRM.Services.QuoteLine is Modified


#### SuperOffice.CRM.Services.QuoteLineConfiguration is Modified


#### SuperOffice.CRM.Services.QuoteListItem is Modified


#### SuperOffice.CRM.Services.QuotePublishDocuments is Modified


#### SuperOffice.CRM.Services.QuoteVersion is Modified


#### SuperOffice.CRM.Services.QuoteVersionAttachment is Modified


#### SuperOffice.CRM.Services.QuoteVersionButtonState is Modified


#### SuperOffice.CRM.Services.QuoteVersionStatusInformation is Modified


#### SuperOffice.CRM.Services.QuoteVersionValidated is Modified


#### SuperOffice.CRM.Services.QuoteVersionWorkflowState is Modified


#### SuperOffice.CRM.Services.Rating is Modified


#### SuperOffice.CRM.Services.Reason is Modified


#### SuperOffice.CRM.Services.ReasonSold is Modified


#### SuperOffice.CRM.Services.ReasonStalled is Modified


#### SuperOffice.CRM.Services.Recipient is Modified


#### SuperOffice.CRM.Services.RecipientStatistics is Modified


#### SuperOffice.CRM.Services.RedLetterDetails is Modified


#### SuperOffice.CRM.Services.RedLetterInformationListItem is Modified


#### SuperOffice.CRM.Services.RedLetterSummary is Modified


#### SuperOffice.CRM.Services.RefCountEntity is Modified


#### SuperOffice.CRM.Services.Reflection.FactoryHelper is Modified

* Deleted items
  * Method `GetService(Type)`
* Modified items
  * Method `CreateService<TService>(Object[])`

#### SuperOffice.CRM.Services.RelationAgent is Modified


#### SuperOffice.CRM.Services.RelationDefinitionEntity is Modified


#### SuperOffice.CRM.Services.RelationToOwner is Modified


#### SuperOffice.CRM.Services.RemoteTimeZoneMethods is Modified


#### SuperOffice.CRM.Services.ReplicationAgent is Modified


#### SuperOffice.CRM.Services.ReplyTemplate is Modified


#### SuperOffice.CRM.Services.ReplyTemplateParsed is Modified


#### SuperOffice.CRM.Services.ReportAgent is Modified


#### SuperOffice.CRM.Services.ReportEntity is Modified


#### SuperOffice.CRM.Services.ReportLabelLayoutEntity is Modified


#### SuperOffice.CRM.Services.ResolvedPerson is Modified


#### SuperOffice.CRM.Services.ResolvedUser is Modified


#### SuperOffice.CRM.Services.ResourceAgent is Modified


#### SuperOffice.CRM.Services.ResourceEntity is Modified


#### SuperOffice.CRM.Services.ResourceOverride is Modified


#### SuperOffice.CRM.Services.Role is Modified


#### SuperOffice.CRM.Services.RoleEntity is Modified


#### SuperOffice.CRM.Services.SaintAgent is Modified


#### SuperOffice.CRM.Services.SaintConfiguration is Modified


#### SuperOffice.CRM.Services.Sale is Modified


#### SuperOffice.CRM.Services.SaleAgent is Modified


#### SuperOffice.CRM.Services.SaleEntity is Modified


#### SuperOffice.CRM.Services.SalesActivity is Modified


#### SuperOffice.CRM.Services.SaleStageEntity is Modified


#### SuperOffice.CRM.Services.SaleStakeholder is Modified


#### SuperOffice.CRM.Services.SaleSummary is Modified


#### SuperOffice.CRM.Services.SaleSummaryItem is Modified


#### SuperOffice.CRM.Services.SaleType is Modified


#### SuperOffice.CRM.Services.SaleTypeEntity is Modified


#### SuperOffice.CRM.Services.SaleTypeStageLink is Modified


#### SuperOffice.CRM.Services.Satellite is Modified


#### SuperOffice.CRM.Services.Script is Modified


#### SuperOffice.CRM.Services.SelectableMDOListItem is Modified


#### SuperOffice.CRM.Services.SelectionAgent is Modified


#### SuperOffice.CRM.Services.SelectionCategory is Modified


#### SuperOffice.CRM.Services.SelectionEntity is Modified


#### SuperOffice.CRM.Services.SelectionForFind is Modified


#### SuperOffice.CRM.Services.SelectionMemberEditValues is Modified


#### SuperOffice.CRM.Services.SelectionSummaryItem is Modified


#### SuperOffice.CRM.Services.Sentiment is Modified


#### SuperOffice.CRM.Services.Sentry is Modified


#### SuperOffice.CRM.Services.SentryAgent is Modified


#### SuperOffice.CRM.Services.ServiceAuth is Modified


#### SuperOffice.CRM.Services.ShipmentMessageBlockEntity is Modified


#### SuperOffice.CRM.Services.ShipmentMessageEntity is Modified


#### SuperOffice.CRM.Services.SmsConfig is Modified


#### SuperOffice.CRM.Services.SmtpTestResult is Modified


#### SuperOffice.CRM.Services.Source is Modified


#### SuperOffice.CRM.Services.StatisticsDataSet is Modified


#### SuperOffice.CRM.Services.StatisticsDataValue is Modified


#### SuperOffice.CRM.Services.StatusMonitor is Modified


#### SuperOffice.CRM.Services.StatusMonitorPeriods is Modified


#### SuperOffice.CRM.Services.StructuredAddress is Modified


#### SuperOffice.CRM.Services.SuggestedAppointment is Modified


#### SuperOffice.CRM.Services.SuggestedAppointmentEntity is Modified


#### SuperOffice.CRM.Services.SuggestedDocumentEntity is Modified


#### SuperOffice.CRM.Services.SyncUserAccount is Modified


#### SuperOffice.CRM.Services.SystemEventEntity is Modified


#### SuperOffice.CRM.Services.SystemTemplateSettings is Modified


#### SuperOffice.CRM.Services.TableRecord is Modified


#### SuperOffice.CRM.Services.TabOrder is Modified


#### SuperOffice.CRM.Services.Tag is Modified


#### SuperOffice.CRM.Services.TargetAssignment is Modified


#### SuperOffice.CRM.Services.TargetChange is Modified


#### SuperOffice.CRM.Services.TargetDimension is Modified


#### SuperOffice.CRM.Services.TargetGroup is Modified


#### SuperOffice.CRM.Services.TargetRevision is Modified


#### SuperOffice.CRM.Services.TargetRevisionHistory is Modified


#### SuperOffice.CRM.Services.TargetsAgent is Modified


#### SuperOffice.CRM.Services.Task is Modified


#### SuperOffice.CRM.Services.TaskListItem is Modified


#### SuperOffice.CRM.Services.TemplateVariablesParameters is Modified


#### SuperOffice.CRM.Services.TemporaryKeyInfo is Modified


#### SuperOffice.CRM.Services.Ticket is Modified

* New items
  * Property `ProjectId`
  * Property `SaleId`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `GetTicketMessageWithOptions(Int32, Boolean)`
  * Method `UndeleteByIds(Int32[])`
  * Method `ValidateAttachments(Int32[])`

#### SuperOffice.CRM.Services.TicketBatchReplyData is Modified


#### SuperOffice.CRM.Services.TicketCategory is Modified


#### SuperOffice.CRM.Services.TicketCategoryEntity is Modified


#### SuperOffice.CRM.Services.TicketCategoryMembershipEntity is Modified


#### SuperOffice.CRM.Services.TicketEntity is Modified

* New items
  * Property `Project`
  * Property `Sale`

#### SuperOffice.CRM.Services.TicketInfo is Modified


#### SuperOffice.CRM.Services.TicketMessage is Modified


#### SuperOffice.CRM.Services.TicketMessageEntity is Modified

* New items
  * Property `AttachmentsInfo`

#### SuperOffice.CRM.Services.TicketMessageHeader is Modified


#### SuperOffice.CRM.Services.TicketPriority is Modified


#### SuperOffice.CRM.Services.TicketPriorityEntity is Modified


#### SuperOffice.CRM.Services.TicketPriorityEscalationLevelEntity is Modified


#### SuperOffice.CRM.Services.TicketStatusEntity is Modified


#### SuperOffice.CRM.Services.TicketSummaryItem is Modified


#### SuperOffice.CRM.Services.TileData is Modified


#### SuperOffice.CRM.Services.TimeZoneAgent is Modified


#### SuperOffice.CRM.Services.TokenManagementInfo is Modified


#### SuperOffice.CRM.Services.TriggerScriptEntity is Modified


#### SuperOffice.CRM.Services.TypicalSearch is Modified


#### SuperOffice.CRM.Services.TypicalSearches is Modified


#### SuperOffice.CRM.Services.UntrustedCredentials is Modified


#### SuperOffice.CRM.Services.UpsertRowStatus is Modified


#### SuperOffice.CRM.Services.UsageStats is Modified


#### SuperOffice.CRM.Services.User is Modified


#### SuperOffice.CRM.Services.UserAgent is Modified

* New items
  * Method `GetUserPresenceStatus(Int32)`
  * Method `SetUserPresenceStatus(Int32, UserPresenceStatus)`

#### SuperOffice.CRM.Services.UserDefinedFieldInfo is Modified


#### SuperOffice.CRM.Services.UserDefinedFieldInfoAgent is Modified

* New items
  * Method `ClearCaches()`

#### SuperOffice.CRM.Services.UserGroup is Modified


#### SuperOffice.CRM.Services.UserInfo is Modified


#### SuperOffice.CRM.Services.UserValidationResult is Modified


#### SuperOffice.CRM.Services.ViewStateAgent is Modified


#### SuperOffice.CRM.Services.VisibleFor is Modified


#### SuperOffice.CRM.Services.WebAppUsage is Modified


#### SuperOffice.CRM.Services.Webhook is Modified


#### SuperOffice.CRM.Services.WebhookAgent is Modified


#### SuperOffice.CRM.Services.WebhookResult is Modified


#### SuperOffice.CRM.Services.WebPanelEntity is Modified



## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.CRM.Services.ServiceMode`
* `SuperOffice.CRM.Services.Switches.SwitchDefault`
* `SuperOffice.Diagnostics.NetServerLogLevelHelper`
* `SuperOffice.Security.Principal.SoContextProviderAttribute`

### New Types

* `SuperOffice.CRM.Services.Implementation.UsageCalculator`
* `SuperOffice.Data.ArchiveBehaviour`
* `SuperOffice.Data.BatchTaskCancellationBehaviour`
* `SuperOffice.Data.ModifiedAppointmentFields`
* `SuperOffice.Data.ShowTaskItemInClient`
* `SuperOffice.Data.TaskListItemType`
* `SuperOffice.Exceptions.SoHttpResponseException`
* `SuperOffice.Factory.IClassFactory`
* `SuperOffice.Factory.ITypeFactories`
* `SuperOffice.Factory.ITypeFactoriesCollection`

### Modified Types

#### Microsoft.Extensions.DependencyInjection.NetServerServiceCollectionExtensions is Modified

* New items
  * Method `AddDatabaseScoped<TImplementation>(IServiceCollection)`
  * Method `AddDatabaseScoped<TService, TImplementation>(IServiceCollection)`
  * Method `AddSingletonPlugin<TPlugin>(IServiceCollection)`

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.AccessGateway is Modified



##### SuperOffice.Configuration.ConfigFile.AccessGatewaySection is Modified

* New items
  * Method `.AccessGatewaySectionAccessGatewaySection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.BatchService is Modified



##### SuperOffice.Configuration.ConfigFile.BatchServiceSection is Modified

* New items
  * Method `.BatchServiceSectionBatchServiceSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Client is Modified



##### SuperOffice.Configuration.ConfigFile.ClientConfigurationProvider is Modified



##### SuperOffice.Configuration.ConfigFile.ClientConfigurationProviderSection is Modified

* New items
  * Method `.ClientConfigurationProviderSectionClientConfigurationProviderSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.ClientSection is Modified

* New items
  * Method `.ClientSectionClientSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Cloud is Modified



##### SuperOffice.Configuration.ConfigFile.CloudSection is Modified

* New items
  * Method `.CloudSectionCloudSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.CssSprite is Modified



##### SuperOffice.Configuration.ConfigFile.CssSpriteSection is Modified

* New items
  * Method `.CssSpriteSectionCssSpriteSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.CustomerService is Modified



##### SuperOffice.Configuration.ConfigFile.CustomerServiceSection is Modified

* New items
  * Method `.CustomerServiceSectionCustomerServiceSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.CustomProxy is Modified



##### SuperOffice.Configuration.ConfigFile.CustomProxySection is Modified

* New items
  * Method `.CustomProxySectionCustomProxySection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Data is Modified

* Modified items

##### .Data.Database is Modified



##### .Data.DatabaseSection is Modified

* New items
  * Method `.DatabaseSectionDatabaseSection(ConfigFileFacade)`


##### .Data.Explicit is Modified



##### .Data.ExplicitSection is Modified

* New items
  * Method `.ExplicitSectionExplicitSection(ConfigFileFacade)`


##### .Data.Session is Modified

* Deleted items
  * Property `.SessionMode`


##### .Data.SessionSection is Modified

* Deleted items
  * Property `.SessionSectionMode`
* New items
  * Method `.SessionSectionSessionSection(ConfigFileFacade)`



##### SuperOffice.Configuration.ConfigFile.Diagnostics is Modified

* Deleted items
  * Property `.DiagnosticsLogDebug`
  * Property `.DiagnosticsLogDebugFrom`
  * Property `.DiagnosticsLogError`
  * Property `.DiagnosticsLogInformation`
  * Property `.DiagnosticsLogInformationFrom`
  * Property `.DiagnosticsLogTrace`
  * Property `.DiagnosticsLogTraceFrom`
  * Property `.DiagnosticsLogWarning`
  * Property `.DiagnosticsLogWarningFrom`


##### SuperOffice.Configuration.ConfigFile.DiagnosticsSection is Modified

* Deleted items
  * Property `.DiagnosticsSectionLogDebug`
  * Property `.DiagnosticsSectionLogDebugFrom`
  * Property `.DiagnosticsSectionLogError`
  * Property `.DiagnosticsSectionLogInformation`
  * Property `.DiagnosticsSectionLogInformationFrom`
  * Property `.DiagnosticsSectionLogTrace`
  * Property `.DiagnosticsSectionLogTraceFrom`
  * Property `.DiagnosticsSectionLogWarning`
  * Property `.DiagnosticsSectionLogWarningFrom`
* New items
  * Method `.DiagnosticsSectionDiagnosticsSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Documents is Modified



##### SuperOffice.Configuration.ConfigFile.DocumentsSection is Modified

* New items
  * Method `.DocumentsSectionDocumentsSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Downloads is Modified



##### SuperOffice.Configuration.ConfigFile.DownloadsSection is Modified

* New items
  * Method `.DownloadsSectionDownloadsSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Factory is Modified



##### SuperOffice.Configuration.ConfigFile.FactorySection is Modified

* New items
  * Method `.FactorySectionFactorySection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.FeatureToggles is Modified



##### SuperOffice.Configuration.ConfigFile.FeatureTogglesSection is Modified

* New items
  * Method `.FeatureTogglesSectionFeatureTogglesSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Globalization is Modified



##### SuperOffice.Configuration.ConfigFile.GlobalizationSection is Modified

* New items
  * Method `.GlobalizationSectionGlobalizationSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.GoogleRecaptcha is Modified



##### SuperOffice.Configuration.ConfigFile.GoogleRecaptchaSection is Modified

* New items
  * Method `.GoogleRecaptchaSectionGoogleRecaptchaSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Infrastructure is Modified



##### SuperOffice.Configuration.ConfigFile.InfrastructureSection is Modified

* New items
  * Method `.InfrastructureSectionInfrastructureSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.IntellisyncConnector is Modified



##### SuperOffice.Configuration.ConfigFile.IntellisyncConnectorSection is Modified

* New items
  * Method `.IntellisyncConnectorSectionIntellisyncConnectorSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Mail is Modified

* Modified items

##### .Mail.Component is Modified



##### .Mail.ComponentSection is Modified

* New items
  * Method `.ComponentSectionComponentSection(ConfigFileFacade)`



##### SuperOffice.Configuration.ConfigFile.Messaging is Modified



##### SuperOffice.Configuration.ConfigFile.MessagingSection is Modified

* New items
  * Method `.MessagingSectionMessagingSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.OidcLogin is Modified



##### SuperOffice.Configuration.ConfigFile.OidcLoginSection is Modified

* New items
  * Method `.OidcLoginSectionOidcLoginSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Pocket is Modified



##### SuperOffice.Configuration.ConfigFile.PocketSection is Modified

* New items
  * Method `.PocketSectionPocketSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Reporter is Modified



##### SuperOffice.Configuration.ConfigFile.ReporterSection is Modified

* New items
  * Method `.ReporterSectionReporterSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Scripting is Modified



##### SuperOffice.Configuration.ConfigFile.ScriptingSection is Modified

* New items
  * Method `.ScriptingSectionScriptingSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Security is Modified

* Modified items

##### .Security.ActiveDirectoryCredentialPlugin is Modified



##### .Security.ActiveDirectoryCredentialPluginSection is Modified

* New items
  * Method `.ActiveDirectoryCredentialPluginSectionActiveDirectoryCredentialPluginSection(ConfigFileFacade)`


##### .Security.Cryptography is Modified



##### .Security.CryptographySection is Modified

* New items
  * Method `.CryptographySectionCryptographySection(ConfigFileFacade)`


##### .Security.Sentry is Modified



##### .Security.SentrySection is Modified

* New items
  * Method `.SentrySectionSentrySection(ConfigFileFacade)`


##### .Security.SoPasswordCredentialPlugin is Modified



##### .Security.SoPasswordCredentialPluginSection is Modified

* New items
  * Method `.SoPasswordCredentialPluginSectionSoPasswordCredentialPluginSection(ConfigFileFacade)`



##### SuperOffice.Configuration.ConfigFile.Services is Modified

* Deleted items
  * Property `.ServicesDefaultMode`
  * Property `.ServicesSwitchDefault`
  * Property `.ServicesSwitchFailover`


##### SuperOffice.Configuration.ConfigFile.ServicesSection is Modified

* Deleted items
  * Property `.ServicesSectionDefaultMode`
  * Property `.ServicesSectionSwitchDefault`
  * Property `.ServicesSectionSwitchFailover`
* New items
  * Method `.ServicesSectionServicesSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.SoFormsAuthentication is Modified



##### SuperOffice.Configuration.ConfigFile.SoFormsAuthenticationSection is Modified

* New items
  * Method `.SoFormsAuthenticationSectionSoFormsAuthenticationSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.SubClients is Modified



##### SuperOffice.Configuration.ConfigFile.SubClientsSection is Modified

* New items
  * Method `.SubClientsSectionSubClientsSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.SuperId is Modified



##### SuperOffice.Configuration.ConfigFile.SuperIdSection is Modified

* New items
  * Method `.SuperIdSectionSuperIdSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.SuspendedSite is Modified



##### SuperOffice.Configuration.ConfigFile.SuspendedSiteSection is Modified

* New items
  * Method `.SuspendedSiteSectionSuspendedSiteSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Sync is Modified



##### SuperOffice.Configuration.ConfigFile.SyncSection is Modified

* New items
  * Method `.SyncSectionSyncSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.TestEnvironment is Modified



##### SuperOffice.Configuration.ConfigFile.TestEnvironmentSection is Modified

* New items
  * Method `.TestEnvironmentSectionTestEnvironmentSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Threading is Modified



##### SuperOffice.Configuration.ConfigFile.ThreadingSection is Modified

* New items
  * Method `.ThreadingSectionThreadingSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.TimeZone is Modified



##### SuperOffice.Configuration.ConfigFile.TimeZoneSection is Modified

* New items
  * Method `.TimeZoneSectionTimeZoneSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.WebApi is Modified



##### SuperOffice.Configuration.ConfigFile.WebApiSection is Modified

* New items
  * Method `.WebApiSectionWebApiSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.Webhooks is Modified



##### SuperOffice.Configuration.ConfigFile.WebhooksSection is Modified

* New items
  * Method `.WebhooksSectionWebhooksSection(ConfigFileFacade)`


##### SuperOffice.Configuration.ConfigFile.WebServices is Modified



##### SuperOffice.Configuration.ConfigFile.WebServicesSection is Modified

* New items
  * Method `.WebServicesSectionWebServicesSection(ConfigFileFacade)`


#### SuperOffice.Configuration.File.ConfigFileFacade is Modified

* New items
  * Method `GetConfigFileInUse()`

#### SuperOffice.Configuration.File.ConfigFileSection is Modified

* Deleted items
  * Property `ConfigFile`
  * Method `ConfigFileSection(String)`
* New items
  * Field `ConfigFile`
  * Method `ConfigFileSection(ConfigFileFacade, String)`

#### SuperOffice.CRM.ArchiveLists.ArchiveColumnData is Modified

* New items
  * Method `ToString(String)`

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.IconHints is Modified

* New items
  * Field `.IconHintsContextMenu`


#### SuperOffice.CRM.Services.Implementation.ServiceLogger is Modified

* Deleted items
  * Method `LogCall(String, String, String, Object, TimeSpan)`
  * Method `LogCall(String, String, String, Object, TimeSpan, Object)`
  * Method `LogCall(String, String, String[], Object[], TimeSpan)`
  * Method `LogCall(String, String, TimeSpan)`
  * Method `LogCall(String, String, TimeSpan, Object)`

#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.Defaults is Modified

* New items
  * Field `.DefaultsStandardStartupScreen`


##### SuperOffice.CRM.UserPreferenceStrings.MDOList is Modified

* New items
  * Field `.MDOListtaskmenu`

* New items

##### SuperOffice.CRM.UserPreferenceStrings.StandardStartupScreenOptions is New

#### SuperOffice.Data.UrlEncoding is Modified

* Modified items
  * Field `value__`

#### SuperOffice.Diagnostics.SoLogger is Modified

* Deleted items
  * Method `LogEntry(LogEntryInfo, Boolean, Boolean)`
  * Method `LogError(SoExceptionInfo)`
  * Method `LogError(Exception)`
  * Method `LogError(Type, String, String)`
  * Method `LogExceptionWarning(Exception, String, Object[])`
  * Method `LogInformation(Type, String, String)`
  * Method `LogInformation(Type, String, String, Boolean)`
  * Method `LogServiceCallToFile(String)`
  * Method `LogWarning(Exception)`
  * Method `LogWarning(Type, String, String)`
* New items
  * Method `LogExceptionError(String, Exception, String, Object[])`
  * Method `LogExceptionWarning(String, Exception, String, Object[])`
  * Method `StartOperation(String, IDictionary<String, String>)`

#### SuperOffice.Exceptions.DirectInvokeAjaxServiceException is Modified

* Deleted items
  * Property `HttpCode`
* Modified items
  * Method `DirectInvokeAjaxServiceException(Int32, String)`
* New items
  * Property `HttpStatusCode`
  * Method `DirectInvokeAjaxServiceException(HttpStatusCode, String)`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_AI_AUTOMATICALLY_CATEGORIZE`
  * Field `SR_ADMIN_AI_USE_TO_SUGGEST_CATEGORY`
  * Field `SR_ADMIN_FROM_USER_GROUP`
  * Field `SR_ADMIN_LIST_MAILINGDOMAIN_NAME`
  * Field `SR_ADMIN_LIST_MAILINGDOMAIN_PLACEHOLDER`
  * Field `SR_ADMIN_LIST_SHOWOPEN`
  * Field `SR_ADMIN_LISTS_SCRIPT`
  * Field `SR_ADMIN_LISTS_SHOWINARCHIVES`
  * Field `SR_ADMIN_LISTS_SHOWINARCHIVESMULTI`
  * Field `SR_ADMIN_LISTS_SHOWINMOBILE`
  * Field `SR_ADMIN_LISTS_SHOWINWEB`
  * Field `SR_ADMIN_TICKETPRIORITY_CANNOT_DELETE_DEFAULT`
  * Field `SR_ARCHIVE_CATEGORYMEMBERS_IS_DEFINED_BY_USERGROUP`
  * Field `SR_ATTACHMENT_MISSING`
  * Field `SR_BATCH_BULKUPDATEBATCHPLUGIN_CANCELLATION`
  * Field `SR_BATCH_BULKUPDATEBATCHPLUGIN_NAME`
  * Field `SR_BATCH_BULKUPDATEBATCHPLUGIN_TOOLTIP`
  * Field `SR_BATCH_CSMAILMERGEBATCHPLUGIN_NAME`
  * Field `SR_BATCH_CSMAILMERGEBATCHPLUGIN_TOOLTIP`
  * Field `SR_BATCH_DEFAULT_CANCELLATION`
  * Field `SR_BATCH_ERPFORCERESYNCBATCHPLUGIN_NAME`
  * Field `SR_BATCH_EXPORTARCHIVEBATCHPLUGIN_NAME`
  * Field `SR_BATCH_EXPORTARCHIVEBATCHPLUGIN_TOOLTIP`
  * Field `SR_BATCH_EXPORTSELECTIONTOFILEBATCHPLUGIN_NAME`
  * Field `SR_BATCH_EXPORTTARGETSBATCHPLUGIN_NAME`
  * Field `SR_BATCH_FREETEXTINDEXROWS_NAME`
  * Field `SR_BATCH_FREETEXTINDEXROWS_TOOLTIP`
  * Field `SR_BATCH_FREETEXTREGENBATCHPLUGIN_NAME`
  * Field `SR_BATCH_FREETEXTREGENBATCHPLUGIN_TOOLTIP`
  * Field `SR_BATCH_IMPORTBATCHPLUGIN_NAME`
  * Field `SR_BATCH_MAILMERGEBATCHPLUGIN_NAME`
  * Field `SR_BATCH_MAILMERGEBATCHPLUGIN_TOOLTIP`
  * Field `SR_BATCH_MAINTENANCEBATCHPLUGIN_NAME`
  * Field `SR_BATCH_REPORTERBATCHPLUGIN_NAME`
  * Field `SR_BATCH_SAINTREGENBATCHPLUGIN_NAME`
  * Field `SR_BATCH_STATUSMONITORREGENERATEBATCHPLUGIN_NAME`
  * Field `SR_BATCH_TASK_BUTTON_TOOLTIP`
  * Field `SR_BATCH_TERMINATE_TOOLTIP`
  * Field `SR_BATCH_TICKETFORWARD_NAME`
  * Field `SR_BATCH_TICKETREPLY_NAME`
  * Field `SR_BATCH_UDEFPUBLISHBATCHPLUGIN_NAME`
  * Field `SR_BATCH_UDEFPUBLISHBATCHPLUGIN_TOOLTIP`
  * Field `SR_BULKUPDATE_FIELDVALUE_TICKET_PROJECT`
  * Field `SR_BULKUPDATE_FIELDVALUE_TICKET_PROJECT_TOOLTIP`
  * Field `SR_BULKUPDATE_FIELDVALUE_TICKET_SALE`
  * Field `SR_BULKUPDATE_FIELDVALUE_TICKET_SALE_TOOLTIP`
  * Field `SR_CONFIGSCREEN_TASKMENU_SOPROTOCOL`
  * Field `SR_DASHBOARD_OLD_HELP`
  * Field `SR_DASHBOARD_OLD_WARNING`
  * Field `SR_EDITOR_TOGGLE_ATTACHMENTS`
  * Field `SR_EDITOR_TOGGLE_TEXTCHOOSER`
  * Field `SR_FIELD_APPOINTMENT_ACTIVE_DATE_NAME`
  * Field `SR_FIELD_APPOINTMENT_ACTIVE_DATE_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_ACTIVE_LINKS_NAME`
  * Field `SR_FIELD_APPOINTMENT_ACTIVE_LINKS_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_ALARM_NAME`
  * Field `SR_FIELD_APPOINTMENT_ALARM_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_ALLDAY_EVENT_NAME`
  * Field `SR_FIELD_APPOINTMENT_ALLDAY_EVENT_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_APPOINTMENT_ID_NAME`
  * Field `SR_FIELD_APPOINTMENT_APPOINTMENT_ID_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_CAUTION_WARNING_NAME`
  * Field `SR_FIELD_APPOINTMENT_CAUTION_WARNING_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_CENTRALSERVICE_VIDEOMEET_ID_NAME`
  * Field `SR_FIELD_APPOINTMENT_CENTRALSERVICE_VIDEOMEET_ID_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_COLOR_INDEX_NAME`
  * Field `SR_FIELD_APPOINTMENT_COLOR_INDEX_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_DO_BY_NAME`
  * Field `SR_FIELD_APPOINTMENT_DO_BY_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_DONE_NAME`
  * Field `SR_FIELD_APPOINTMENT_DONE_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_END_DATE_NAME`
  * Field `SR_FIELD_APPOINTMENT_END_DATE_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_FREE_BUSY_NAME`
  * Field `SR_FIELD_APPOINTMENT_FREE_BUSY_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_HAS_ALARM_NAME`
  * Field `SR_FIELD_APPOINTMENT_HAS_ALARM_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_IS_MILESTONE_NAME`
  * Field `SR_FIELD_APPOINTMENT_IS_MILESTONE_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_JOIN_VIDEOMEET_URL_NAME`
  * Field `SR_FIELD_APPOINTMENT_JOIN_VIDEOMEET_URL_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_LAG_TIME_NAME`
  * Field `SR_FIELD_APPOINTMENT_LEADTIME_NAME`
  * Field `SR_FIELD_APPOINTMENT_LEADTIME_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_LOCATION_NAME`
  * Field `SR_FIELD_APPOINTMENT_LOCATION_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_ORIGINAL_START_DATE_NAME`
  * Field `SR_FIELD_APPOINTMENT_ORIGINAL_START_DATE_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_PRIVATE_NAME`
  * Field `SR_FIELD_APPOINTMENT_PRIVATE_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_REGISTERED_NAME`
  * Field `SR_FIELD_APPOINTMENT_REGISTERED_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_REJECT_COUNTER_NAME`
  * Field `SR_FIELD_APPOINTMENT_REJECT_COUNTER_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_REJECT_REASON_NAME`
  * Field `SR_FIELD_APPOINTMENT_REJECT_REASON_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_SOURCE_NAME`
  * Field `SR_FIELD_APPOINTMENT_SOURCE_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_STATUS_NAME`
  * Field `SR_FIELD_APPOINTMENT_STATUS_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_TYPE_NAME`
  * Field `SR_FIELD_APPOINTMENT_TYPE_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_UPDATED_COUNT_NAME`
  * Field `SR_FIELD_APPOINTMENT_UPDATED_COUNT_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_UPDATED_NAME`
  * Field `SR_FIELD_APPOINTMENT_UPDATED_TOOLTIP`
  * Field `SR_FIELD_CONTACT_ACTIVE_ERP_LINKS_NAME`
  * Field `SR_FIELD_CONTACT_ACTIVE_ERP_LINKS_TOOLTIP`
  * Field `SR_FIELD_CONTACT_ACTIVE_INTERESTS_NAME`
  * Field `SR_FIELD_CONTACT_ACTIVE_INTERESTS_TOOLTIP`
  * Field `SR_FIELD_CONTACT_ADDRESS_CITY_NAME`
  * Field `SR_FIELD_CONTACT_ADDRESS_FORMATTED_ADDRESS_NAME`
  * Field `SR_FIELD_CONTACT_ADDRESS_FORMATTED_MULTI_LINE_ADDRESS_NAME`
  * Field `SR_FIELD_CONTACT_ADDRESS_LINE1_NAME`
  * Field `SR_FIELD_CONTACT_ADDRESS_LINE2_NAME`
  * Field `SR_FIELD_CONTACT_ADDRESS_ZIP_NAME`
  * Field `SR_FIELD_CONTACT_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_CONTACT_BUSINESS_IDX_NAME`
  * Field `SR_FIELD_CONTACT_CATEGORY_IDX_NAME`
  * Field `SR_FIELD_CONTACT_CONTACT_ID_NAME`
  * Field `SR_FIELD_CONTACT_CONTACT_ID_TOOLTIP`
  * Field `SR_FIELD_CONTACT_COUNTRY_ID_NAME`
  * Field `SR_FIELD_CONTACT_DELETED_DATE_NAME`
  * Field `SR_FIELD_CONTACT_DELETED_DATE_TOOLTIP`
  * Field `SR_FIELD_CONTACT_DELETED_NAME`
  * Field `SR_FIELD_CONTACT_DELETED_TOOLTIP`
  * Field `SR_FIELD_CONTACT_DEPARTMENT_NAME`
  * Field `SR_FIELD_CONTACT_DEPARTMENT_TOOLTIP`
  * Field `SR_FIELD_CONTACT_DOMAIN_NAME`
  * Field `SR_FIELD_CONTACT_FAX_FORMATTED_NUMBER_NAME`
  * Field `SR_FIELD_CONTACT_INFO_TEXT_NAME`
  * Field `SR_FIELD_CONTACT_KANANAME_NAME`
  * Field `SR_FIELD_CONTACT_KANANAME_TOOLTIP`
  * Field `SR_FIELD_CONTACT_NAME_NAME`
  * Field `SR_FIELD_CONTACT_NAME_TOOLTIP`
  * Field `SR_FIELD_CONTACT_NOMAILING_NAME`
  * Field `SR_FIELD_CONTACT_NOMAILING_TOOLTIP`
  * Field `SR_FIELD_CONTACT_NOTE_NAME`
  * Field `SR_FIELD_CONTACT_NUMBER1_NAME`
  * Field `SR_FIELD_CONTACT_NUMBER1_TOOLTIP`
  * Field `SR_FIELD_CONTACT_NUMBER2_NAME`
  * Field `SR_FIELD_CONTACT_NUMBER2_TOOLTIP`
  * Field `SR_FIELD_CONTACT_ORG_NR_NAME`
  * Field `SR_FIELD_CONTACT_ORG_NR_TOOLTIP`
  * Field `SR_FIELD_CONTACT_PHONE_FORMATTED_NUMBER_NAME`
  * Field `SR_FIELD_CONTACT_REGISTERED_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_CONTACT_REGISTERED_NAME`
  * Field `SR_FIELD_CONTACT_REGISTERED_TOOLTIP`
  * Field `SR_FIELD_CONTACT_SOUND_EX_NAME`
  * Field `SR_FIELD_CONTACT_SOUND_EX_TOOLTIP`
  * Field `SR_FIELD_CONTACT_SOURCE_NAME`
  * Field `SR_FIELD_CONTACT_SOURCE_TOOLTIP`
  * Field `SR_FIELD_CONTACT_SUPPORT_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_CONTACT_SUPPORT_LANGUAGE_ID_NAME`
  * Field `SR_FIELD_CONTACT_SUPPORT_PERSON_ID_NAME`
  * Field `SR_FIELD_CONTACT_TICKET_PRIORITY_ID_NAME`
  * Field `SR_FIELD_CONTACT_UPDATED_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_CONTACT_UPDATED_COUNT_NAME`
  * Field `SR_FIELD_CONTACT_UPDATED_COUNT_TOOLTIP`
  * Field `SR_FIELD_CONTACT_UPDATED_NAME`
  * Field `SR_FIELD_CONTACT_UPDATED_TOOLTIP`
  * Field `SR_FIELD_CONTACT_XSTOP_NAME`
  * Field `SR_FIELD_CONTACT_XSTOP_TOOLTIP`
  * Field `SR_FIELD_EJ_CATEGORY_CATEGORY_MASTER_NAME`
  * Field `SR_FIELD_EJ_CATEGORY_CATEGORY_MASTER_TOOLTIP`
  * Field `SR_FIELD_EJ_CATEGORY_CLOSING_STATUS_NAME`
  * Field `SR_FIELD_EJ_CATEGORY_CLOSING_STATUS_TOOLTIP`
  * Field `SR_FIELD_EJ_CATEGORY_DEFAULT_REPLY_STATUS_NAME`
  * Field `SR_FIELD_EJ_CATEGORY_DEFAULT_REPLY_STATUS_TOOLTIP`
  * Field `SR_FIELD_EJ_CATEGORY_EXTERNAL_NAME_NAME`
  * Field `SR_FIELD_EJ_CATEGORY_EXTERNAL_NAME_TOOLTIP`
  * Field `SR_FIELD_EJ_CATEGORY_FULLNAME_NAME`
  * Field `SR_FIELD_EJ_CATEGORY_FULLNAME_TOOLTIP`
  * Field `SR_FIELD_EJ_CATEGORY_ID_NAME`
  * Field `SR_FIELD_EJ_CATEGORY_ID_TOOLTIP`
  * Field `SR_FIELD_EJ_CATEGORY_MSG_CLOSING_STATUS_NAME`
  * Field `SR_FIELD_EJ_CATEGORY_MSG_CLOSING_STATUS_TOOLTIP`
  * Field `SR_FIELD_EJ_CATEGORY_NAME_NAME`
  * Field `SR_FIELD_EJ_CATEGORY_NAME_TOOLTIP`
  * Field `SR_FIELD_EJ_CATEGORY_PARENT_ID_NAME`
  * Field `SR_FIELD_EJ_CATEGORY_PARENT_ID_TOOLTIP`
  * Field `SR_FIELD_EJ_CATEGORY_REPLY_TEMPLATE_NAME`
  * Field `SR_FIELD_EJ_CATEGORY_REPLY_TEMPLATE_TOOLTIP`
  * Field `SR_FIELD_EJUSER_CHAT_STATUS_NAME`
  * Field `SR_FIELD_EJUSER_CHAT_STATUS_TOOLTIP`
  * Field `SR_FIELD_EJUSER_EMAIL_NAME`
  * Field `SR_FIELD_EJUSER_EMAIL_TOOLTIP`
  * Field `SR_FIELD_EJUSER_FIRSTNAME_NAME`
  * Field `SR_FIELD_EJUSER_FIRSTNAME_TOOLTIP`
  * Field `SR_FIELD_EJUSER_ID_NAME`
  * Field `SR_FIELD_EJUSER_ID_TOOLTIP`
  * Field `SR_FIELD_EJUSER_LASTNAME_NAME`
  * Field `SR_FIELD_EJUSER_LASTNAME_TOOLTIP`
  * Field `SR_FIELD_EJUSER_LOGINNAME_NAME`
  * Field `SR_FIELD_EJUSER_LOGINNAME_TOOLTIP`
  * Field `SR_FIELD_EJUSER_MIDDLENAME_NAME`
  * Field `SR_FIELD_EJUSER_MIDDLENAME_TOOLTIP`
  * Field `SR_FIELD_EJUSER_NOT_PRESENT_NAME`
  * Field `SR_FIELD_EJUSER_NOT_PRESENT_TOOLTIP`
  * Field `SR_FIELD_EJUSER_STATUS_NAME`
  * Field `SR_FIELD_EJUSER_STATUS_TOOLTIP`
  * Field `SR_FIELD_EJUSER_USERNAME_NAME`
  * Field `SR_FIELD_EJUSER_USERNAME_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_ACCESS_LEVEL_NAME`
  * Field `SR_FIELD_KB_ENTRY_ACCESS_LEVEL_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_ANSWER_NAME`
  * Field `SR_FIELD_KB_ENTRY_ANSWER_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_CREATED_BY_NAME`
  * Field `SR_FIELD_KB_ENTRY_CREATED_BY_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_EXPIRE_DATE_NAME`
  * Field `SR_FIELD_KB_ENTRY_EXPIRE_DATE_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_FLAGS_NAME`
  * Field `SR_FIELD_KB_ENTRY_FLAGS_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_ID_NAME`
  * Field `SR_FIELD_KB_ENTRY_ID_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_KEYWORDS_NAME`
  * Field `SR_FIELD_KB_ENTRY_KEYWORDS_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_LAST_CHANGED_NAME`
  * Field `SR_FIELD_KB_ENTRY_LAST_CHANGED_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_QUESTION_NAME`
  * Field `SR_FIELD_KB_ENTRY_QUESTION_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_READ_COUNT_NAME`
  * Field `SR_FIELD_KB_ENTRY_READ_COUNT_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_SCORE_NAME`
  * Field `SR_FIELD_KB_ENTRY_SCORE_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_SCORE_WEIGHT_NAME`
  * Field `SR_FIELD_KB_ENTRY_SCORE_WEIGHT_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_SORT_ORDER_NAME`
  * Field `SR_FIELD_KB_ENTRY_SORT_ORDER_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_STATUS_NAME`
  * Field `SR_FIELD_KB_ENTRY_STATUS_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_TEXT_NAME`
  * Field `SR_FIELD_KB_ENTRY_TEXT_TOOLTIP`
  * Field `SR_FIELD_KB_ENTRY_TITLE_NAME`
  * Field `SR_FIELD_KB_ENTRY_TITLE_TOOLTIP`
  * Field `SR_FIELD_PERSON_ACTIVE_ERP_LINKS_NAME`
  * Field `SR_FIELD_PERSON_ACTIVE_ERP_LINKS_TOOLTIP`
  * Field `SR_FIELD_PERSON_ACTIVE_INTERESTS_NAME`
  * Field `SR_FIELD_PERSON_ACTIVE_INTERESTS_TOOLTIP`
  * Field `SR_FIELD_PERSON_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_PERSON_ASSOCIATE_ID_TOOLTIP`
  * Field `SR_FIELD_PERSON_BLOCK_EMARKETING_NAME`
  * Field `SR_FIELD_PERSON_BLOCK_EMARKETING_TOOLTIP`
  * Field `SR_FIELD_PERSON_CONTACT_ID_NAME`
  * Field `SR_FIELD_PERSON_COUNTRY_ID_NAME`
  * Field `SR_FIELD_PERSON_DAY_OF_BIRTH_NAME`
  * Field `SR_FIELD_PERSON_DAY_OF_BIRTH_TOOLTIP`
  * Field `SR_FIELD_PERSON_DELETED_DATE_NAME`
  * Field `SR_FIELD_PERSON_DELETED_DATE_TOOLTIP`
  * Field `SR_FIELD_PERSON_DEPARTMENT_NAME`
  * Field `SR_FIELD_PERSON_DEPARTMENT_TOOLTIP`
  * Field `SR_FIELD_PERSON_DIRECT_FORMATTED_NUMBER_NAME`
  * Field `SR_FIELD_PERSON_EMAIL_NAME`
  * Field `SR_FIELD_PERSON_FIRSTNAME_NAME`
  * Field `SR_FIELD_PERSON_FIRSTNAME_TOOLTIP`
  * Field `SR_FIELD_PERSON_FULL_NAME_NAME`
  * Field `SR_FIELD_PERSON_GENDER_NAME`
  * Field `SR_FIELD_PERSON_GENDER_TOOLTIP`
  * Field `SR_FIELD_PERSON_GROUP_ID_NAME`
  * Field `SR_FIELD_PERSON_GROUP_ID_TOOLTIP`
  * Field `SR_FIELD_PERSON_INFO_TEXT_NAME`
  * Field `SR_FIELD_PERSON_INITIALS_NAME`
  * Field `SR_FIELD_PERSON_INITIALS_TOOLTIP`
  * Field `SR_FIELD_PERSON_KANAFNAME_NAME`
  * Field `SR_FIELD_PERSON_KANAFNAME_TOOLTIP`
  * Field `SR_FIELD_PERSON_KANALNAME_NAME`
  * Field `SR_FIELD_PERSON_KANALNAME_TOOLTIP`
  * Field `SR_FIELD_PERSON_LASTNAME_NAME`
  * Field `SR_FIELD_PERSON_LASTNAME_TOOLTIP`
  * Field `SR_FIELD_PERSON_MIDDLE_NAME_NAME`
  * Field `SR_FIELD_PERSON_MIDDLE_NAME_TOOLTIP`
  * Field `SR_FIELD_PERSON_MOBILE_FORMATTED_NUMBER_NAME`
  * Field `SR_FIELD_PERSON_MONTH_OF_BIRTH_NAME`
  * Field `SR_FIELD_PERSON_MONTH_OF_BIRTH_TOOLTIP`
  * Field `SR_FIELD_PERSON_MRMRS_NAME`
  * Field `SR_FIELD_PERSON_MRMRS_TOOLTIP`
  * Field `SR_FIELD_PERSON_NOMAILING_NAME`
  * Field `SR_FIELD_PERSON_NOMAILING_TOOLTIP`
  * Field `SR_FIELD_PERSON_PERSON_ID_NAME`
  * Field `SR_FIELD_PERSON_PERSON_ID_TOOLTIP`
  * Field `SR_FIELD_PERSON_PERSON_NUMBER_NAME`
  * Field `SR_FIELD_PERSON_PERSON_NUMBER_TOOLTIP`
  * Field `SR_FIELD_PERSON_PHONE_FORMATTED_NUMBER_NAME`
  * Field `SR_FIELD_PERSON_PHONE_PRESENT_NAME`
  * Field `SR_FIELD_PERSON_PHONE_PRESENT_TOOLTIP`
  * Field `SR_FIELD_PERSON_POST1_NAME`
  * Field `SR_FIELD_PERSON_POST1_TOOLTIP`
  * Field `SR_FIELD_PERSON_POST2_NAME`
  * Field `SR_FIELD_PERSON_POST2_TOOLTIP`
  * Field `SR_FIELD_PERSON_POST3_NAME`
  * Field `SR_FIELD_PERSON_POST3_TOOLTIP`
  * Field `SR_FIELD_PERSON_RANK_NAME`
  * Field `SR_FIELD_PERSON_RANK_TOOLTIP`
  * Field `SR_FIELD_PERSON_REGISTERED_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_PERSON_REGISTERED_NAME`
  * Field `SR_FIELD_PERSON_REGISTERED_TOOLTIP`
  * Field `SR_FIELD_PERSON_RETIRED_NAME`
  * Field `SR_FIELD_PERSON_RETIRED_TOOLTIP`
  * Field `SR_FIELD_PERSON_SALUTATION_NAME`
  * Field `SR_FIELD_PERSON_SALUTATION_TOOLTIP`
  * Field `SR_FIELD_PERSON_SENT_INFO_NAME`
  * Field `SR_FIELD_PERSON_SENT_INFO_TOOLTIP`
  * Field `SR_FIELD_PERSON_SHOW_CONTACT_TICKETS_NAME`
  * Field `SR_FIELD_PERSON_SHOW_CONTACT_TICKETS_TOOLTIP`
  * Field `SR_FIELD_PERSON_SOURCE_NAME`
  * Field `SR_FIELD_PERSON_SOURCE_TOOLTIP`
  * Field `SR_FIELD_PERSON_SUPPORT_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_PERSON_SUPPORT_LANGUAGE_ID_NAME`
  * Field `SR_FIELD_PERSON_TICKET_PRIORITY_ID_NAME`
  * Field `SR_FIELD_PERSON_TITLE_NAME`
  * Field `SR_FIELD_PERSON_TITLE_TOOLTIP`
  * Field `SR_FIELD_PERSON_UPDATE_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_PERSON_UPDATED_COUNT_NAME`
  * Field `SR_FIELD_PERSON_UPDATED_COUNT_TOOLTIP`
  * Field `SR_FIELD_PERSON_UPDATED_NAME`
  * Field `SR_FIELD_PERSON_UPDATED_TOOLTIP`
  * Field `SR_FIELD_PERSON_USEPERSONADDRESS_NAME`
  * Field `SR_FIELD_PERSON_USEPERSONADDRESS_TOOLTIP`
  * Field `SR_FIELD_PERSON_YEAR_OF_BIRTH_NAME`
  * Field `SR_FIELD_PERSON_YEAR_OF_BIRTH_TOOLTIP`
  * Field `SR_FIELD_PROJECT_ACTIVE_ERP_LINKS_NAME`
  * Field `SR_FIELD_PROJECT_ACTIVE_ERP_LINKS_TOOLTIP`
  * Field `SR_FIELD_PROJECT_ACTIVE_LINKS_NAME`
  * Field `SR_FIELD_PROJECT_ACTIVE_LINKS_TOOLTIP`
  * Field `SR_FIELD_PROJECT_DONE_NAME`
  * Field `SR_FIELD_PROJECT_DONE_TOOLTIP`
  * Field `SR_FIELD_PROJECT_END_DATE_NAME`
  * Field `SR_FIELD_PROJECT_END_DATE_TOOLTIP`
  * Field `SR_FIELD_PROJECT_NAME_NAME`
  * Field `SR_FIELD_PROJECT_NAME_TOOLTIP`
  * Field `SR_FIELD_PROJECT_NEXT_MILESTONE_DATE_NAME`
  * Field `SR_FIELD_PROJECT_NEXT_MILESTONE_DATE_TOOLTIP`
  * Field `SR_FIELD_PROJECT_PROJECT_ID_NAME`
  * Field `SR_FIELD_PROJECT_PROJECT_ID_TOOLTIP`
  * Field `SR_FIELD_PROJECT_PROJECT_NUMBER_NAME`
  * Field `SR_FIELD_PROJECT_PROJECT_NUMBER_TOOLTIP`
  * Field `SR_FIELD_PROJECT_REGISTERED_NAME`
  * Field `SR_FIELD_PROJECT_REGISTERED_TOOLTIP`
  * Field `SR_FIELD_PROJECT_SOUND_EX_NAME`
  * Field `SR_FIELD_PROJECT_SOUND_EX_TOOLTIP`
  * Field `SR_FIELD_PROJECT_SOURCE_NAME`
  * Field `SR_FIELD_PROJECT_SOURCE_TOOLTIP`
  * Field `SR_FIELD_PROJECT_UPDATED_COUNT_NAME`
  * Field `SR_FIELD_PROJECT_UPDATED_COUNT_TOOLTIP`
  * Field `SR_FIELD_PROJECT_UPDATED_NAME`
  * Field `SR_FIELD_PROJECT_UPDATED_TOOLTIP`
  * Field `SR_FIELD_SALE_ACTIVE_ERP_LINKS_NAME`
  * Field `SR_FIELD_SALE_ACTIVE_ERP_LINKS_TOOLTIP`
  * Field `SR_FIELD_SALE_ACTIVE_LINKS_NAME`
  * Field `SR_FIELD_SALE_ACTIVE_LINKS_TOOLTIP`
  * Field `SR_FIELD_SALE_AMOUNT_NAME`
  * Field `SR_FIELD_SALE_AMOUNT_TOOLTIP`
  * Field `SR_FIELD_SALE_DONE_NAME`
  * Field `SR_FIELD_SALE_DONE_TOOLTIP`
  * Field `SR_FIELD_SALE_EARNING_NAME`
  * Field `SR_FIELD_SALE_EARNING_PERCENT_NAME`
  * Field `SR_FIELD_SALE_EARNING_PERCENT_TOOLTIP`
  * Field `SR_FIELD_SALE_EARNING_TOOLTIP`
  * Field `SR_FIELD_SALE_HEADING_NAME`
  * Field `SR_FIELD_SALE_HEADING_TOOLTIP`
  * Field `SR_FIELD_SALE_NEXT_DUE_DATE_NAME`
  * Field `SR_FIELD_SALE_NEXT_DUE_DATE_TOOLTIP`
  * Field `SR_FIELD_SALE_NUMBER1_NAME`
  * Field `SR_FIELD_SALE_NUMBER1_TOOLTIP`
  * Field `SR_FIELD_SALE_PROBABILITY_NAME`
  * Field `SR_FIELD_SALE_PROBABILITY_TOOLTIP`
  * Field `SR_FIELD_SALE_REGISTERED_NAME`
  * Field `SR_FIELD_SALE_REGISTERED_TOOLTIP`
  * Field `SR_FIELD_SALE_REOPEN_DATE_NAME`
  * Field `SR_FIELD_SALE_REOPEN_DATE_TOOLTIP`
  * Field `SR_FIELD_SALE_SALE_ID_NAME`
  * Field `SR_FIELD_SALE_SALE_ID_TOOLTIP`
  * Field `SR_FIELD_SALE_SALEDATE_NAME`
  * Field `SR_FIELD_SALE_SALEDATE_TOOLTIP`
  * Field `SR_FIELD_SALE_SOURCE_NAME`
  * Field `SR_FIELD_SALE_SOURCE_TOOLTIP`
  * Field `SR_FIELD_SALE_STATUS_NAME`
  * Field `SR_FIELD_SALE_STATUS_TOOLTIP`
  * Field `SR_FIELD_SALE_UPDATED_COUNT_NAME`
  * Field `SR_FIELD_SALE_UPDATED_COUNT_TOOLTIP`
  * Field `SR_FIELD_SALE_UPDATED_NAME`
  * Field `SR_FIELD_SALE_UPDATED_TOOLTIP`
  * Field `SR_FIELD_SALE_VISIBILITY_NAME`
  * Field `SR_FIELD_SALE_VISIBILITY_TOOLTIP`
  * Field `SR_FIELD_TICKET_ACTIVATE_NAME`
  * Field `SR_FIELD_TICKET_AGENT_ID_NAME`
  * Field `SR_FIELD_TICKET_ALERT_LEVEL_NAME`
  * Field `SR_FIELD_TICKET_ALERT_STOP_NAME`
  * Field `SR_FIELD_TICKET_ALERT_TIMEOUT_NAME`
  * Field `SR_FIELD_TICKET_AUTHOR_NAME`
  * Field `SR_FIELD_TICKET_CATEGORY_NAME`
  * Field `SR_FIELD_TICKET_CLOSED_AT_NAME`
  * Field `SR_FIELD_TICKET_CONNECT_ID_NAME`
  * Field `SR_FIELD_TICKET_CONTACT_ID_NAME`
  * Field `SR_FIELD_TICKET_CREATED_AT_NAME`
  * Field `SR_FIELD_TICKET_CREATED_BY_NAME`
  * Field `SR_FIELD_TICKET_CUST_ID_NAME`
  * Field `SR_FIELD_TICKET_DBI_KEY_NAME`
  * Field `SR_FIELD_TICKET_DBI_LAST_SYNCRONIZED_NAME`
  * Field `SR_FIELD_TICKET_DEADLINE_NAME`
  * Field `SR_FIELD_TICKET_DISPLAY_FILTER_NAME`
  * Field `SR_FIELD_TICKET_FILTER_ADDRESS_NAME`
  * Field `SR_FIELD_TICKET_FILTER_ID_NAME`
  * Field `SR_FIELD_TICKET_FIRST_READ_BY_OWNER_NAME`
  * Field `SR_FIELD_TICKET_FIRST_READ_BY_USER_NAME`
  * Field `SR_FIELD_TICKET_FORM_SUBMISSION_ID_NAME`
  * Field `SR_FIELD_TICKET_FROM_ADDRESS_NAME`
  * Field `SR_FIELD_TICKET_HAS_ATTACHMENT_NAME`
  * Field `SR_FIELD_TICKET_ID_NAME`
  * Field `SR_FIELD_TICKET_LANGUAGE_NAME`
  * Field `SR_FIELD_TICKET_LAST_CHANGED_NAME`
  * Field `SR_FIELD_TICKET_NUM_MESSAGES_NAME`
  * Field `SR_FIELD_TICKET_NUM_REPLIES_NAME`
  * Field `SR_FIELD_TICKET_ORIG_HUMAN_CATEGORY_ID_NAME`
  * Field `SR_FIELD_TICKET_ORIGIN_NAME`
  * Field `SR_FIELD_TICKET_OWNED_BY_NAME`
  * Field `SR_FIELD_TICKET_PRIORITY_CHANGED_OWNER_NAME`
  * Field `SR_FIELD_TICKET_PRIORITY_DEADLINE_NAME`
  * Field `SR_FIELD_TICKET_PRIORITY_ID_NAME`
  * Field `SR_FIELD_TICKET_PRIORITY_ID_TOOLTIP`
  * Field `SR_FIELD_TICKET_PRIORITY_NAME`
  * Field `SR_FIELD_TICKET_PRIORITY_NAME_NAME`
  * Field `SR_FIELD_TICKET_PRIORITY_NAME_TOOLTIP`
  * Field `SR_FIELD_TICKET_PRIORITY_STATUS_NAME`
  * Field `SR_FIELD_TICKET_PRIORITY_TICKET_CHANGED_PRIORITY_NAME`
  * Field `SR_FIELD_TICKET_PRIORITY_TICKET_CLOSED_NAME`
  * Field `SR_FIELD_TICKET_PRIORITY_TICKET_NEW_NAME`
  * Field `SR_FIELD_TICKET_PROJECT_ID`
  * Field `SR_FIELD_TICKET_READ_BY_CUSTOMER_NAME`
  * Field `SR_FIELD_TICKET_READ_BY_OWNER_NAME`
  * Field `SR_FIELD_TICKET_READ_STATUS_NAME`
  * Field `SR_FIELD_TICKET_REAL_TIME_SPENT_EXTERNALLY_NAME`
  * Field `SR_FIELD_TICKET_REAL_TIME_SPENT_INTERNALLY_NAME`
  * Field `SR_FIELD_TICKET_REAL_TIME_SPENT_QUEUE_NAME`
  * Field `SR_FIELD_TICKET_REAL_TIME_TO_CLOSE_NAME`
  * Field `SR_FIELD_TICKET_REAL_TIME_TO_REPLY_NAME`
  * Field `SR_FIELD_TICKET_REPLIED_AT_NAME`
  * Field `SR_FIELD_TICKET_SALE_ID`
  * Field `SR_FIELD_TICKET_SENTIMENT_CONFIDENCE_NAME`
  * Field `SR_FIELD_TICKET_SENTIMENT_NAME`
  * Field `SR_FIELD_TICKET_SLEVEL_NAME`
  * Field `SR_FIELD_TICKET_STATUS_NAME`
  * Field `SR_FIELD_TICKET_SUGGESTED_CATEGORY_ID_NAME`
  * Field `SR_FIELD_TICKET_TAGS_NAME`
  * Field `SR_FIELD_TICKET_TEXT_NAME`
  * Field `SR_FIELD_TICKET_TICKET_STATUS_NAME`
  * Field `SR_FIELD_TICKET_TICKET_TYPE_NAME`
  * Field `SR_FIELD_TICKET_TIME_SPENT_EXTERNALLY_NAME`
  * Field `SR_FIELD_TICKET_TIME_SPENT_INTERNALLY_NAME`
  * Field `SR_FIELD_TICKET_TIME_SPENT_QUEUE_NAME`
  * Field `SR_FIELD_TICKET_TIME_TO_CLOSE_NAME`
  * Field `SR_FIELD_TICKET_TIME_TO_REPLY_NAME`
  * Field `SR_FIELD_TICKET_TITLE_NAME`
  * Field `SR_FIELD_Y_EQUIPMENT_ID_NAME`
  * Field `SR_FIELD_Y_EQUIPMENT_ID_TOOLTIP`
  * Field `SR_FIELD_Y_EQUIPMENT_LAST_CHANGED_NAME`
  * Field `SR_FIELD_Y_EQUIPMENT_LAST_CHANGED_TOOLTIP`
  * Field `SR_FORMS_ACTION_NO_PERSON`
  * Field `SR_MAILINGDOMAIN_NO_MX`
  * Field `SR_MAILINGDOMAIN_NO_MX_TEXT`
  * Field `SR_MAILINGDOMAIN_NO_SPF`
  * Field `SR_MAILINGDOMAIN_NO_SPF_TEXT`
  * Field `SR_MENU_EDIT_STATUS`
  * Field `SR_MENU_LIST_MERGE`
  * Field `SR_MENU_LIST_SPLIT`
  * Field `SR_NOTIFICATION_SETTINGS`
  * Field `SR_NOTIFY_AGE_LAST_HOUR`
  * Field `SR_NOTIFY_AGE_TODAY`
  * Field `SR_NOTIFY_AGE_YESTERDAY`
  * Field `SR_PD_Defaults_StandardStartupScreen_DESC`
  * Field `SR_PD_Defaults_StandardStartupScreen_NAME`
  * Field `SR_PD_Mailing_UseApprovedDomains_DESC`
  * Field `SR_PD_Mailing_UseApprovedDomains_NAME`
  * Field `SR_PD_serviceSettings_defaultTicketStatusOpen_DESC`
  * Field `SR_PD_serviceSettings_defaultTicketStatusOpen_NAME`
  * Field `SR_PDL_Defaults_StandardStartupScreen_Company`
  * Field `SR_PDL_Defaults_StandardStartupScreen_Contact`
  * Field `SR_PDL_Defaults_StandardStartupScreen_Dashboard`
  * Field `SR_PDL_Defaults_StandardStartupScreen_Diary`
  * Field `SR_PDL_Defaults_StandardStartupScreen_Lastscreen`
  * Field `SR_PDL_Defaults_StandardStartupScreen_Project`
  * Field `SR_PDL_Defaults_StandardStartupScreen_Sale`
  * Field `SR_PDL_Defaults_StandardStartupScreen_Ticket`
  * Field `SR_PREVIEW_VIEW_DOCUMENT_PREVIEW`
  * Field `SR_PROGRESS_NOT_KNOWN`
  * Field `SR_RECYCLEBIN_HEADER_SAME_RETENTION`
  * Field `SR_TASKMENU_SELECTONE`
  * Field `SR_TICKET_CANT_VIEW`
  * Field `SR_TICKET_PROJECT`
  * Field `SR_TICKET_REQUEST_DOESNT_EXIST`
  * Field `SR_TICKET_SALE`
  * Field `SR_TICKET_STATUS_COLOURS_TOOLTIP`
  * Field `SR_TICKET_WAS_MERGED_CLICK_TO_OPEN`
  * Field `SR_TICKETMERGE_PRIMARY_REQUEST_NOT_SELECTED`
  * Field `SR_USER_PRESENCESTATUS_NOTPRESENT`
  * Field `SR_USER_STATUS_NORMAL`
  * Field `SR_USER_STATUS_NOTAVAILABLE`

#### SuperOffice.Security.Principal.ContextContextProvider is Modified

* New items
  * Property `InheritSynchronizationContextInThreadManager`

#### SuperOffice.Security.Principal.ISoContextProvider is Modified

* New items
  * Property `InheritSynchronizationContextInThreadManager`

#### SuperOffice.Security.Principal.ProcessContextProvider is Modified

* New items
  * Property `InheritSynchronizationContextInThreadManager`

#### SuperOffice.Security.Principal.ThreadContextProvider is Modified

* New items
  * Property `InheritSynchronizationContextInThreadManager`

#### SuperOffice.Services.LatestVersion is Modified


#### SuperOffice.WebApi.HttpContextItem is Modified

* New items
  * Field `AccountId`
  * Field `TelemetryOperationName`

#### SuperOffice.WebApi.PartnerAppRequestInfo is Modified

* New items
  * Property `ExcludeFromInvoice`


### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.ArchiveLists.ExecutingServicesProvider`
* `SuperOffice.CRM.TimeZone.Private.PrivateLocalTimeConverterDataFetcherFactory`

### New Types

* `SuperOffice.CRM.ArchiveLists.Joiners.TicketProjectExtender`
* `SuperOffice.CRM.ArchiveLists.Joiners.TicketSaleExtender`
* `SuperOffice.CRM.ArchiveLists.RecycleTicketExtender`
* `SuperOffice.CRM.ArchiveLists.RecycleTicketProvider`
* `SuperOffice.CRM.AttachmentPluginAttribute`
* `SuperOffice.CRM.Cache.MDOListTableTaskMenuCache`
* `SuperOffice.CRM.Data.TaskMenuGroupLinkTableInfo`
* `SuperOffice.CRM.Data.TaskMenuHeadingLinkTableInfo`
* `SuperOffice.CRM.Data.TaskMenuTableInfo`
* `SuperOffice.CRM.IAttachmentPlugin`
* `SuperOffice.CRM.Lists.RelatedDataFieldsProvider`
* `SuperOffice.CRM.Lists.TaskMenuGroupProvider`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTaskMenuGroupLinkRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTaskMenuGroupLinkRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTaskMenuHeadingLinkRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTaskMenuHeadingLinkRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTaskMenuRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTaskMenuRowsFactory`
* `SuperOffice.CRM.Rows.TaskMenuGroupLinkRecordData`
* `SuperOffice.CRM.Rows.TaskMenuGroupLinkRecordDataExtensions`
* `SuperOffice.CRM.Rows.TaskMenuGroupLinkRow`
* `SuperOffice.CRM.Rows.TaskMenuGroupLinkRows`
* `SuperOffice.CRM.Rows.TaskMenuHeadingLinkRecordData`
* `SuperOffice.CRM.Rows.TaskMenuHeadingLinkRecordDataExtensions`
* `SuperOffice.CRM.Rows.TaskMenuHeadingLinkRow`
* `SuperOffice.CRM.Rows.TaskMenuHeadingLinkRows`
* `SuperOffice.CRM.Rows.TaskMenuRecordData`
* `SuperOffice.CRM.Rows.TaskMenuRecordDataExtensions`
* `SuperOffice.CRM.Rows.TaskMenuRow`
* `SuperOffice.CRM.Rows.TaskMenuRows`
* `SuperOffice.CRM.TicketMessage.AttachmentFilesystemPlugin`
* `SuperOffice.CRM.Tooltips.TicketPriorityTooltipPlugin`
* `SuperOffice.CRM.Tooltips.TicketStatusTooltipPlugin`
* `SuperOffice.Data.Private.TicketLogger`
* `SuperOffice.Data.Private.TicketLoggerProcessor`
* `SuperOffice.Data.Private.TicketLoggingLogic`
* `SuperOffice.Data.SQL.ArchiveBehaviourFieldInfo`
* `SuperOffice.Data.SQL.Greatest`
* `SuperOffice.Data.SQL.ModifiedAppointmentFieldsFieldInfo`
* `SuperOffice.Data.SQL.ShowTaskItemInClientFieldInfo`
* `SuperOffice.Data.SQL.TaskListItemTypeFieldInfo`
* `SuperOffice.Data.SQL.UrlEncodingFieldInfo`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.CategoryMembershipExtenderBase is Modified

* Deleted items
  * Method `CalculateRowRights(ArchiveRow, Int32)`
* New items
  * Field `ColumnIsDefinedByUsergroup`

#### SuperOffice.CRM.ArchiveLists.CategoryMembersProvider is Modified

* Deleted items
  * Method `AcceptRow(ArchiveRow)`
* New items
  * Method `GetRows(String)`

#### SuperOffice.CRM.ArchiveLists.ExistingCategoryMembersProvider is Modified

* Deleted items

#### SuperOffice.CRM.ArchiveLists.ExtensibleColumnsBase is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.ExtensibleColumnsBase.DbColumnBinding is Modified

* New items
  * Property `.DbColumnBindingOrderByFields`


#### SuperOffice.CRM.ArchiveLists.PersonExtenderBase is Modified

* New items
  * Field `ColPersonHasInterests`

#### SuperOffice.CRM.ArchiveLists.TicketExtenderBase is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.TicketExtenderBase.Features is Modified

* New items
  * Field `.FeaturesProject`
  * Field `.FeaturesSale`


#### SuperOffice.CRM.ArchiveLists.UdefExtenderBase is Modified


#### SuperOffice.CRM.Archives.ContactListItem is Modified

* New items
  * Property `ActiveErpLinks`
  * Property `Number1`
  * Property `Number2`

#### SuperOffice.CRM.AttachmentHelper is Modified

* New items
  * Method `GetPlugin(Int32)`

#### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem is Modified

* Modified items

##### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem.TicketFieldValueKeys is Modified

* New items
  * Field `.TicketFieldValueKeysProject`
  * Field `.TicketFieldValueKeysSale`


#### SuperOffice.CRM.Cache.ExtAppCache is Modified

* New items
  * Method `GetTaskMenus()`

#### SuperOffice.CRM.Cache.MDOListTableAmountClassCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableAssociateCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableBusinessCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableCaches is Modified


#### SuperOffice.CRM.Cache.MDOListTableCategoryCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableComptrCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableContIntCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableCountryCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableCreditedCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableCurrencyCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableDeliveryTermsCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableDeliveryTypeCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableDocTmplCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableExtAppCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableIntentCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableMrMrsCache is Modified


#### SuperOffice.CRM.Cache.MDOListTablePaymentTermsCache is Modified


#### SuperOffice.CRM.Cache.MDOListTablePaymentTypeCache is Modified


#### SuperOffice.CRM.Cache.MDOListTablePersIntCache is Modified


#### SuperOffice.CRM.Cache.MDOListTablePersPosCache is Modified


#### SuperOffice.CRM.Cache.MDOListTablePMembTypeCache is Modified


#### SuperOffice.CRM.Cache.MDOListTablePriceUnitCache is Modified


#### SuperOffice.CRM.Cache.MDOListTablePriorityCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableProbCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableProductCategoryCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableProductFamilyCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableProductTypeCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableProjStatusCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableProjTypeCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableQuoteApprReasonCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableQuoteDenyReasonCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableReasonCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableReasonSoldCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableReasonStalledCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableRejectReasonCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableRelationDefinitionCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableSaleTypeCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableSaleTypeCatCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableSalutationCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableSearchCatCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableSourceCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableStakeholderRoleCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableSubscriptionUnitCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableTagsCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableTaskCache is Modified


#### SuperOffice.CRM.Cache.MDOListTableUDListCache is Modified


#### SuperOffice.CRM.Data.AccessScriptTableInfo is Modified


#### SuperOffice.CRM.Data.ActiveUserTableInfo is Modified


#### SuperOffice.CRM.Data.AddressFormatTableInfo is Modified


#### SuperOffice.CRM.Data.AddressTableInfo is Modified


#### SuperOffice.CRM.Data.AmountClassGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.AmountClassHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.AmountClassTableInfo is Modified


#### SuperOffice.CRM.Data.AppointmentTableInfo is Modified

* New items
  * Property `ModifiedAppointmentFields`

#### SuperOffice.CRM.Data.AreaTableInfo is Modified


#### SuperOffice.CRM.Data.AreaUserAssignmentTableInfo is Modified


#### SuperOffice.CRM.Data.AreaUserInclusionTableInfo is Modified


#### SuperOffice.CRM.Data.AssociateGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.AssociateHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.AssociateHistoryTableInfo is Modified


#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_TaskMenu_RegisteredAssociateId`
  * Property `LeftOuterJoin_TaskMenu_UpdatedAssociateId`
  * Property `LeftOuterJoin_TaskMenuGroupLink_RegisteredAssociateId`
  * Property `LeftOuterJoin_TaskMenuGroupLink_UpdatedAssociateId`
  * Property `LeftOuterJoin_TaskMenuHeadingLink_RegisteredAssociateId`
  * Property `LeftOuterJoin_TaskMenuHeadingLink_UpdatedAssociateId`

#### SuperOffice.CRM.Data.AttachmentLocationTableInfo is Modified


#### SuperOffice.CRM.Data.AttachmentTableInfo is Modified


#### SuperOffice.CRM.Data.AudienceConfigTableInfo is Modified


#### SuperOffice.CRM.Data.AudienceLayoutLinkTableInfo is Modified


#### SuperOffice.CRM.Data.AudienceLayoutTableInfo is Modified


#### SuperOffice.CRM.Data.AudienceVisibilityTableInfo is Modified


#### SuperOffice.CRM.Data.AutosaveTableInfo is Modified


#### SuperOffice.CRM.Data.BaseTZLocationTableInfo is Modified


#### SuperOffice.CRM.Data.BatchTaskDefinitionTableInfo is Modified


#### SuperOffice.CRM.Data.BatchTaskTableInfo is Modified


#### SuperOffice.CRM.Data.BinaryObjectLinkTableInfo is Modified


#### SuperOffice.CRM.Data.BinaryObjectTableInfo is Modified


#### SuperOffice.CRM.Data.BusinessGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.BusinessHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.BusinessTableInfo is Modified


#### SuperOffice.CRM.Data.CacheInvalidationTableInfo is Modified


#### SuperOffice.CRM.Data.CacheTablesTableInfo is Modified


#### SuperOffice.CRM.Data.CategoryFamilyTableInfo is Modified


#### SuperOffice.CRM.Data.CategoryGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.CategoryHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.CategoryMembershipTableInfo is Modified

* New items
  * Property `IsDefinedByUsergroup`

#### SuperOffice.CRM.Data.CategoryTableInfo is Modified


#### SuperOffice.CRM.Data.ChatMessageTableInfo is Modified


#### SuperOffice.CRM.Data.ChatSessionTableInfo is Modified


#### SuperOffice.CRM.Data.ChatTopicTableInfo is Modified


#### SuperOffice.CRM.Data.ChatTopicUserTableInfo is Modified


#### SuperOffice.CRM.Data.CompanyDomainTableInfo is Modified


#### SuperOffice.CRM.Data.CompanyTableInfo is Modified


#### SuperOffice.CRM.Data.ComptrGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ComptrHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ComptrTableInfo is Modified


#### SuperOffice.CRM.Data.ConfigTableInfo is Modified


#### SuperOffice.CRM.Data.ConfigurableScreenAppliesToTableInfo is Modified


#### SuperOffice.CRM.Data.ConfigurableScreenDeltaTableInfo is Modified


#### SuperOffice.CRM.Data.ConnectionConfigFieldTableInfo is Modified


#### SuperOffice.CRM.Data.ConsentPersonTableInfo is Modified


#### SuperOffice.CRM.Data.ConsentPurposeTableInfo is Modified


#### SuperOffice.CRM.Data.ConsentSourceTableInfo is Modified


#### SuperOffice.CRM.Data.ContactInterestTableInfo is Modified


#### SuperOffice.CRM.Data.ContactTableInfo is Modified


#### SuperOffice.CRM.Data.ContIntGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ContIntHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ContIntTableInfo is Modified


#### SuperOffice.CRM.Data.CounterValueTableInfo is Modified


#### SuperOffice.CRM.Data.CountryGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.CountryHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.CountryTableInfo is Modified


#### SuperOffice.CRM.Data.CredentialsTableInfo is Modified


#### SuperOffice.CRM.Data.CreditedGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.CreditedHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.CreditedTableInfo is Modified


#### SuperOffice.CRM.Data.CurrencyGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.CurrencyHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.CurrencyTableInfo is Modified


#### SuperOffice.CRM.Data.CustCategoryTableInfo is Modified


#### SuperOffice.CRM.Data.CustConfigTableInfo is Modified


#### SuperOffice.CRM.Data.CustLangTableInfo is Modified


#### SuperOffice.CRM.Data.DashboardTableInfo is Modified


#### SuperOffice.CRM.Data.DashboardThemeTableInfo is Modified


#### SuperOffice.CRM.Data.DashboardTileDefinitionTableInfo is Modified


#### SuperOffice.CRM.Data.DashboardTileFieldTableInfo is Modified


#### SuperOffice.CRM.Data.DashboardTileTableInfo is Modified


#### SuperOffice.CRM.Data.DatabaseModelTableInfo is Modified


#### SuperOffice.CRM.Data.DataRightTableInfo is Modified


#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.AccessScriptFields is Modified



##### SuperOffice.CRM.Data.DBC.ActiveUserFields is Modified



##### SuperOffice.CRM.Data.DBC.AddressFields is Modified



##### SuperOffice.CRM.Data.DBC.AddressFormatFields is Modified



##### SuperOffice.CRM.Data.DBC.AmountClassFields is Modified



##### SuperOffice.CRM.Data.DBC.AmountClassGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.AmountClassHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.AppointmentFields is Modified

* New items
  * Field `.AppointmentFieldsModifiedAppointmentFields`


##### SuperOffice.CRM.Data.DBC.AreaFields is Modified



##### SuperOffice.CRM.Data.DBC.AreaUserAssignmentFields is Modified



##### SuperOffice.CRM.Data.DBC.AreaUserInclusionFields is Modified



##### SuperOffice.CRM.Data.DBC.AssociateFields is Modified



##### SuperOffice.CRM.Data.DBC.AssociateGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.AssociateHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.AssociateHistoryFields is Modified



##### SuperOffice.CRM.Data.DBC.AttachmentFields is Modified



##### SuperOffice.CRM.Data.DBC.AttachmentLocationFields is Modified



##### SuperOffice.CRM.Data.DBC.AudienceConfigFields is Modified



##### SuperOffice.CRM.Data.DBC.AudienceLayoutFields is Modified



##### SuperOffice.CRM.Data.DBC.AudienceLayoutLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.AudienceVisibilityFields is Modified



##### SuperOffice.CRM.Data.DBC.AutosaveFields is Modified



##### SuperOffice.CRM.Data.DBC.BaseTZLocationFields is Modified



##### SuperOffice.CRM.Data.DBC.BatchTaskDefinitionFields is Modified



##### SuperOffice.CRM.Data.DBC.BatchTaskFields is Modified



##### SuperOffice.CRM.Data.DBC.BinaryObjectFields is Modified



##### SuperOffice.CRM.Data.DBC.BinaryObjectLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.BusinessFields is Modified



##### SuperOffice.CRM.Data.DBC.BusinessGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.BusinessHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.CacheInvalidationFields is Modified



##### SuperOffice.CRM.Data.DBC.CacheTablesFields is Modified



##### SuperOffice.CRM.Data.DBC.CategoryFamilyFields is Modified



##### SuperOffice.CRM.Data.DBC.CategoryFields is Modified



##### SuperOffice.CRM.Data.DBC.CategoryGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.CategoryHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.CategoryMembershipFields is Modified

* New items
  * Field `.CategoryMembershipFieldsIsDefinedByUsergroup`


##### SuperOffice.CRM.Data.DBC.ChatMessageFields is Modified



##### SuperOffice.CRM.Data.DBC.ChatSessionFields is Modified



##### SuperOffice.CRM.Data.DBC.ChatTopicFields is Modified



##### SuperOffice.CRM.Data.DBC.ChatTopicUserFields is Modified



##### SuperOffice.CRM.Data.DBC.CompanyDomainFields is Modified



##### SuperOffice.CRM.Data.DBC.CompanyFields is Modified



##### SuperOffice.CRM.Data.DBC.ComptrFields is Modified



##### SuperOffice.CRM.Data.DBC.ComptrGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ComptrHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ConfigFields is Modified



##### SuperOffice.CRM.Data.DBC.ConfigurableScreenAppliesToFields is Modified



##### SuperOffice.CRM.Data.DBC.ConfigurableScreenDeltaFields is Modified



##### SuperOffice.CRM.Data.DBC.ConnectionConfigFieldFields is Modified



##### SuperOffice.CRM.Data.DBC.ConsentPersonFields is Modified



##### SuperOffice.CRM.Data.DBC.ConsentPurposeFields is Modified



##### SuperOffice.CRM.Data.DBC.ConsentSourceFields is Modified



##### SuperOffice.CRM.Data.DBC.ContactFields is Modified



##### SuperOffice.CRM.Data.DBC.ContactInterestFields is Modified



##### SuperOffice.CRM.Data.DBC.ContIntFields is Modified



##### SuperOffice.CRM.Data.DBC.ContIntGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ContIntHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.CounterValueFields is Modified



##### SuperOffice.CRM.Data.DBC.CountryFields is Modified



##### SuperOffice.CRM.Data.DBC.CountryGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.CountryHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.CredentialsFields is Modified



##### SuperOffice.CRM.Data.DBC.CreditedFields is Modified



##### SuperOffice.CRM.Data.DBC.CreditedGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.CreditedHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.CurrencyFields is Modified



##### SuperOffice.CRM.Data.DBC.CurrencyGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.CurrencyHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.CustCategoryFields is Modified



##### SuperOffice.CRM.Data.DBC.CustConfigFields is Modified



##### SuperOffice.CRM.Data.DBC.CustLangFields is Modified



##### SuperOffice.CRM.Data.DBC.DashboardFields is Modified



##### SuperOffice.CRM.Data.DBC.DashboardThemeFields is Modified



##### SuperOffice.CRM.Data.DBC.DashboardTileDefinitionFields is Modified



##### SuperOffice.CRM.Data.DBC.DashboardTileFieldFields is Modified



##### SuperOffice.CRM.Data.DBC.DashboardTileFields is Modified



##### SuperOffice.CRM.Data.DBC.DatabaseModelFields is Modified



##### SuperOffice.CRM.Data.DBC.DataRightFields is Modified



##### SuperOffice.CRM.Data.DBC.DbiAgentFieldFields is Modified



##### SuperOffice.CRM.Data.DBC.DbiAgentFields is Modified



##### SuperOffice.CRM.Data.DBC.DbiAgentScheduleFields is Modified



##### SuperOffice.CRM.Data.DBC.DeliveryTermsFields is Modified



##### SuperOffice.CRM.Data.DBC.DeliveryTermsGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.DeliveryTermsHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.DeliveryTypeFields is Modified



##### SuperOffice.CRM.Data.DBC.DeliveryTypeGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.DeliveryTypeHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.DiaryViewFields is Modified



##### SuperOffice.CRM.Data.DBC.DiaryViewRowFields is Modified



##### SuperOffice.CRM.Data.DBC.DictionaryBaseFields is Modified



##### SuperOffice.CRM.Data.DBC.DictionaryFields is Modified



##### SuperOffice.CRM.Data.DBC.DocDocumentFields is Modified



##### SuperOffice.CRM.Data.DBC.DocFolderFields is Modified



##### SuperOffice.CRM.Data.DBC.DocTmplFields is Modified



##### SuperOffice.CRM.Data.DBC.DocTmplGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.DocTmplHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.DocumentFields is Modified



##### SuperOffice.CRM.Data.DBC.EabEntryFields is Modified



##### SuperOffice.CRM.Data.DBC.EabFolderFields is Modified



##### SuperOffice.CRM.Data.DBC.EjCategoryFields is Modified



##### SuperOffice.CRM.Data.DBC.EjCategoryGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.EjMessageFields is Modified



##### SuperOffice.CRM.Data.DBC.EjpackageFields is Modified



##### SuperOffice.CRM.Data.DBC.EjpackageItemFields is Modified



##### SuperOffice.CRM.Data.DBC.EjRoleFields is Modified



##### SuperOffice.CRM.Data.DBC.EjscriptDebugFields is Modified



##### SuperOffice.CRM.Data.DBC.EjscriptFields is Modified



##### SuperOffice.CRM.Data.DBC.EjselectionFields is Modified



##### SuperOffice.CRM.Data.DBC.EjselEjselFields is Modified



##### SuperOffice.CRM.Data.DBC.EjselMetaResultFields is Modified



##### SuperOffice.CRM.Data.DBC.EjselResultSetFields is Modified



##### SuperOffice.CRM.Data.DBC.EjselSourceIdlistFields is Modified



##### SuperOffice.CRM.Data.DBC.EjselSourceScriptFields is Modified



##### SuperOffice.CRM.Data.DBC.EjselSourceXmlFields is Modified



##### SuperOffice.CRM.Data.DBC.EjuserFields is Modified



##### SuperOffice.CRM.Data.DBC.ElementProfileFields is Modified



##### SuperOffice.CRM.Data.DBC.EmailAccountFields is Modified



##### SuperOffice.CRM.Data.DBC.EmailAttachmentFields is Modified



##### SuperOffice.CRM.Data.DBC.EmailFields is Modified



##### SuperOffice.CRM.Data.DBC.EmailFolderFields is Modified



##### SuperOffice.CRM.Data.DBC.EmailItemFields is Modified



##### SuperOffice.CRM.Data.DBC.ErpConfigurationFields is Modified



##### SuperOffice.CRM.Data.DBC.ErpConnectionAccessFields is Modified



##### SuperOffice.CRM.Data.DBC.ErpConnectionActorTypeFields is Modified



##### SuperOffice.CRM.Data.DBC.ErpConnectionFields is Modified



##### SuperOffice.CRM.Data.DBC.ErpConnectorFields is Modified



##### SuperOffice.CRM.Data.DBC.ErpExternalKeyFields is Modified



##### SuperOffice.CRM.Data.DBC.ErpFieldFields is Modified



##### SuperOffice.CRM.Data.DBC.ErpInternalKeyFields is Modified



##### SuperOffice.CRM.Data.DBC.ErpListItemMappingFields is Modified



##### SuperOffice.CRM.Data.DBC.ErpSyncLogFields is Modified



##### SuperOffice.CRM.Data.DBC.ExtAppFields is Modified



##### SuperOffice.CRM.Data.DBC.ExtAppGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ExtAppHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ExtDatasourceFields is Modified



##### SuperOffice.CRM.Data.DBC.ExternalDocumentFields is Modified



##### SuperOffice.CRM.Data.DBC.ExternalEventFields is Modified



##### SuperOffice.CRM.Data.DBC.ExtFieldFields is Modified



##### SuperOffice.CRM.Data.DBC.ExtraFieldsFields is Modified



##### SuperOffice.CRM.Data.DBC.ExtraMenusFields is Modified



##### SuperOffice.CRM.Data.DBC.ExtraTablesEntryFields is Modified



##### SuperOffice.CRM.Data.DBC.ExtraTablesFields is Modified



##### SuperOffice.CRM.Data.DBC.ExtraTablesResultFields is Modified



##### SuperOffice.CRM.Data.DBC.ExtTableFields is Modified



##### SuperOffice.CRM.Data.DBC.FavouriteFields is Modified



##### SuperOffice.CRM.Data.DBC.FieldLabelFields is Modified



##### SuperOffice.CRM.Data.DBC.ForeignAppFields is Modified



##### SuperOffice.CRM.Data.DBC.ForeignDeviceFields is Modified



##### SuperOffice.CRM.Data.DBC.ForeignKeyFields is Modified



##### SuperOffice.CRM.Data.DBC.FormFields is Modified



##### SuperOffice.CRM.Data.DBC.FormKeysFields is Modified



##### SuperOffice.CRM.Data.DBC.FormSubmissionFields is Modified



##### SuperOffice.CRM.Data.DBC.FreeTextIndexFields is Modified



##### SuperOffice.CRM.Data.DBC.FreeTextStopWordsFields is Modified



##### SuperOffice.CRM.Data.DBC.FreeTextWordsFields is Modified



##### SuperOffice.CRM.Data.DBC.FunctionRightFields is Modified



##### SuperOffice.CRM.Data.DBC.FunctionRightRoleLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.HeadingFields is Modified



##### SuperOffice.CRM.Data.DBC.HelpFields is Modified



##### SuperOffice.CRM.Data.DBC.HierarchyFields is Modified



##### SuperOffice.CRM.Data.DBC.HistoryFields is Modified



##### SuperOffice.CRM.Data.DBC.HotlistFields is Modified



##### SuperOffice.CRM.Data.DBC.ImportDefaultFields is Modified



##### SuperOffice.CRM.Data.DBC.ImportFieldFields is Modified



##### SuperOffice.CRM.Data.DBC.ImportObjectFields is Modified



##### SuperOffice.CRM.Data.DBC.ImportRelationFields is Modified



##### SuperOffice.CRM.Data.DBC.InboxFields is Modified



##### SuperOffice.CRM.Data.DBC.IntentFields is Modified



##### SuperOffice.CRM.Data.DBC.IntentGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.IntentHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.InvitationFields is Modified



##### SuperOffice.CRM.Data.DBC.InvoiceEntryFields is Modified



##### SuperOffice.CRM.Data.DBC.InvoiceFields is Modified



##### SuperOffice.CRM.Data.DBC.InvoiceSumFields is Modified



##### SuperOffice.CRM.Data.DBC.InvoiceTypeFields is Modified



##### SuperOffice.CRM.Data.DBC.ItemConfigFields is Modified



##### SuperOffice.CRM.Data.DBC.KbAttachmentFields is Modified



##### SuperOffice.CRM.Data.DBC.KbCategoryFields is Modified



##### SuperOffice.CRM.Data.DBC.KbCategoryLogFields is Modified



##### SuperOffice.CRM.Data.DBC.KbEntryCommentFields is Modified



##### SuperOffice.CRM.Data.DBC.KbEntryFields is Modified



##### SuperOffice.CRM.Data.DBC.KbEntryKeywordFields is Modified



##### SuperOffice.CRM.Data.DBC.KbEntryLogFields is Modified



##### SuperOffice.CRM.Data.DBC.KbEntryWordsFields is Modified



##### SuperOffice.CRM.Data.DBC.KbGroupEntryFields is Modified



##### SuperOffice.CRM.Data.DBC.KbGroupFields is Modified



##### SuperOffice.CRM.Data.DBC.KbHttpLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.KbSolutionFinderEntryFields is Modified



##### SuperOffice.CRM.Data.DBC.KbSolutionFinderFields is Modified



##### SuperOffice.CRM.Data.DBC.KbWorkflowAccessFields is Modified



##### SuperOffice.CRM.Data.DBC.KbWorkflowFields is Modified



##### SuperOffice.CRM.Data.DBC.LanguageInfoCountryFields is Modified



##### SuperOffice.CRM.Data.DBC.LanguageInfoFields is Modified



##### SuperOffice.CRM.Data.DBC.LegalBaseFields is Modified



##### SuperOffice.CRM.Data.DBC.LegalHtmlTagsFields is Modified



##### SuperOffice.CRM.Data.DBC.LicenseAssocLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.LicenseSatlLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.LocaleTextFields is Modified



##### SuperOffice.CRM.Data.DBC.LockingFields is Modified



##### SuperOffice.CRM.Data.DBC.LogDebugFields is Modified



##### SuperOffice.CRM.Data.DBC.LogEventsFields is Modified



##### SuperOffice.CRM.Data.DBC.LoginCustomerFields is Modified



##### SuperOffice.CRM.Data.DBC.LoginFields is Modified



##### SuperOffice.CRM.Data.DBC.MailAliasFields is Modified



##### SuperOffice.CRM.Data.DBC.MailBlockFields is Modified



##### SuperOffice.CRM.Data.DBC.MailInFilterFields is Modified



##### SuperOffice.CRM.Data.DBC.MailInUidlFields is Modified



##### SuperOffice.CRM.Data.DBC.MergeMoveLogFields is Modified



##### SuperOffice.CRM.Data.DBC.MessageCustomersFields is Modified



##### SuperOffice.CRM.Data.DBC.MessageFields is Modified



##### SuperOffice.CRM.Data.DBC.MessageHandlerFields is Modified



##### SuperOffice.CRM.Data.DBC.MessageHeaderFields is Modified



##### SuperOffice.CRM.Data.DBC.MessageIdFields is Modified



##### SuperOffice.CRM.Data.DBC.ModuleLicenseFields is Modified



##### SuperOffice.CRM.Data.DBC.ModuleOwnerFields is Modified



##### SuperOffice.CRM.Data.DBC.MrMrsFields is Modified



##### SuperOffice.CRM.Data.DBC.MrMrsGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.MrMrsHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.MsFilterFields is Modified



##### SuperOffice.CRM.Data.DBC.MsFilterMailFields is Modified



##### SuperOffice.CRM.Data.DBC.MsSubstituteFields is Modified



##### SuperOffice.CRM.Data.DBC.MsTrashbinFields is Modified



##### SuperOffice.CRM.Data.DBC.NoticeFrameFields is Modified



##### SuperOffice.CRM.Data.DBC.NotifyFields is Modified



##### SuperOffice.CRM.Data.DBC.OLEFieldFields is Modified



##### SuperOffice.CRM.Data.DBC.OLEFieldTextFields is Modified



##### SuperOffice.CRM.Data.DBC.OLESubjectFields is Modified



##### SuperOffice.CRM.Data.DBC.OLESubjectTextFields is Modified



##### SuperOffice.CRM.Data.DBC.OLEViewFields is Modified



##### SuperOffice.CRM.Data.DBC.OLEViewTextFields is Modified



##### SuperOffice.CRM.Data.DBC.OnlineAppFields is Modified



##### SuperOffice.CRM.Data.DBC.OutboxFields is Modified



##### SuperOffice.CRM.Data.DBC.OutgoingMessageFields is Modified



##### SuperOffice.CRM.Data.DBC.OwnerContactLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PasswordRulesFields is Modified



##### SuperOffice.CRM.Data.DBC.PaymentTermsFields is Modified



##### SuperOffice.CRM.Data.DBC.PaymentTermsGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PaymentTermsHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PaymentTypeFields is Modified



##### SuperOffice.CRM.Data.DBC.PaymentTypeGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PaymentTypeHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PersIntFields is Modified



##### SuperOffice.CRM.Data.DBC.PersIntGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PersIntHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PersonFields is Modified



##### SuperOffice.CRM.Data.DBC.PersonInterestFields is Modified



##### SuperOffice.CRM.Data.DBC.PersPosFields is Modified



##### SuperOffice.CRM.Data.DBC.PersPosGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PersPosHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PhoneFields is Modified



##### SuperOffice.CRM.Data.DBC.PhoneFormatFields is Modified



##### SuperOffice.CRM.Data.DBC.PMembTypeFields is Modified



##### SuperOffice.CRM.Data.DBC.PMembTypeGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PMembTypeHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PrefDescFields is Modified



##### SuperOffice.CRM.Data.DBC.PrefDescLineFields is Modified



##### SuperOffice.CRM.Data.DBC.PreferenceFields is Modified



##### SuperOffice.CRM.Data.DBC.PriceListFields is Modified



##### SuperOffice.CRM.Data.DBC.PriceUnitFields is Modified



##### SuperOffice.CRM.Data.DBC.PriceUnitGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PriceUnitHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PriorityFields is Modified



##### SuperOffice.CRM.Data.DBC.PriorityGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PriorityHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProbFields is Modified



##### SuperOffice.CRM.Data.DBC.ProbGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProbHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProductCategoryFields is Modified



##### SuperOffice.CRM.Data.DBC.ProductCategoryGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProductCategoryHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProductFamilyFields is Modified



##### SuperOffice.CRM.Data.DBC.ProductFamilyGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProductFamilyHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProductFields is Modified



##### SuperOffice.CRM.Data.DBC.ProductTypeFields is Modified



##### SuperOffice.CRM.Data.DBC.ProductTypeGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProductTypeHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProductVersionFields is Modified



##### SuperOffice.CRM.Data.DBC.ProfileFields is Modified



##### SuperOffice.CRM.Data.DBC.ProjectFields is Modified



##### SuperOffice.CRM.Data.DBC.ProjectMemberFields is Modified



##### SuperOffice.CRM.Data.DBC.ProjectTypeStatusLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProjStatusFields is Modified



##### SuperOffice.CRM.Data.DBC.ProjStatusGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProjStatusHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProjTypeFields is Modified



##### SuperOffice.CRM.Data.DBC.ProjTypeGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ProjTypeHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.PublishFields is Modified



##### SuperOffice.CRM.Data.DBC.PushNotificationServiceFields is Modified



##### SuperOffice.CRM.Data.DBC.QuickReplyFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteAlternativeFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteApprReasonFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteApprReasonGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteApprReasonHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteConnectionAccessFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteConnectionFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteDenyReasonFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteDenyReasonGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteDenyReasonHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteLineConfigurationFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteLineFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteVersionAttachmentFields is Modified



##### SuperOffice.CRM.Data.DBC.QuoteVersionFields is Modified



##### SuperOffice.CRM.Data.DBC.ReasonFields is Modified



##### SuperOffice.CRM.Data.DBC.ReasonGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ReasonHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ReasonSoldFields is Modified



##### SuperOffice.CRM.Data.DBC.ReasonSoldGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ReasonSoldHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ReasonStalledFields is Modified



##### SuperOffice.CRM.Data.DBC.ReasonStalledGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.ReasonStalledHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.RecurrenceRuleFields is Modified



##### SuperOffice.CRM.Data.DBC.RedLetterDayFields is Modified



##### SuperOffice.CRM.Data.DBC.RefCountRangeFields is Modified



##### SuperOffice.CRM.Data.DBC.RefCountsFields is Modified



##### SuperOffice.CRM.Data.DBC.RegistryFields is Modified



##### SuperOffice.CRM.Data.DBC.RejectReasonFields is Modified



##### SuperOffice.CRM.Data.DBC.RejectReasonGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.RejectReasonHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.RelationDefinitionFields is Modified



##### SuperOffice.CRM.Data.DBC.RelationDefinitionGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.RelationDefinitionHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.RelationsFields is Modified



##### SuperOffice.CRM.Data.DBC.RelationTargetFields is Modified



##### SuperOffice.CRM.Data.DBC.ReplyTemplateAttachmentFields is Modified



##### SuperOffice.CRM.Data.DBC.ReplyTemplateBodyFields is Modified



##### SuperOffice.CRM.Data.DBC.ReplyTemplateFields is Modified



##### SuperOffice.CRM.Data.DBC.ReplyTemplateFolderFields is Modified



##### SuperOffice.CRM.Data.DBC.ReporterListDefFields is Modified



##### SuperOffice.CRM.Data.DBC.ResourceOverrideFields is Modified



##### SuperOffice.CRM.Data.DBC.RoleCategoryFields is Modified



##### SuperOffice.CRM.Data.DBC.RoleElementFields is Modified



##### SuperOffice.CRM.Data.DBC.RoleFields is Modified



##### SuperOffice.CRM.Data.DBC.RoleMemberFields is Modified



##### SuperOffice.CRM.Data.DBC.RoleWorkflowFields is Modified



##### SuperOffice.CRM.Data.DBC.SaintConfigurationFields is Modified



##### SuperOffice.CRM.Data.DBC.SaleFields is Modified



##### SuperOffice.CRM.Data.DBC.SaleHistFields is Modified



##### SuperOffice.CRM.Data.DBC.SaleStakeholderFields is Modified



##### SuperOffice.CRM.Data.DBC.SaleTypeCatFields is Modified



##### SuperOffice.CRM.Data.DBC.SaleTypeCatGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SaleTypeCatHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SaleTypeFields is Modified



##### SuperOffice.CRM.Data.DBC.SaleTypeGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SaleTypeHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SaleTypeQuoteAttachmentFields is Modified



##### SuperOffice.CRM.Data.DBC.SaleTypeStageLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SalutationFields is Modified



##### SuperOffice.CRM.Data.DBC.SalutationGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SalutationHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SatelliteFields is Modified



##### SuperOffice.CRM.Data.DBC.SAttachmentFields is Modified



##### SuperOffice.CRM.Data.DBC.SBounceShipmentFields is Modified



##### SuperOffice.CRM.Data.DBC.ScheduledTaskFields is Modified



##### SuperOffice.CRM.Data.DBC.ScheduleFields is Modified



##### SuperOffice.CRM.Data.DBC.ScreenChooserFields is Modified



##### SuperOffice.CRM.Data.DBC.ScreenDefinitionActionFields is Modified



##### SuperOffice.CRM.Data.DBC.ScreenDefinitionElementFields is Modified



##### SuperOffice.CRM.Data.DBC.ScreenDefinitionFields is Modified



##### SuperOffice.CRM.Data.DBC.ScreenDefinitionHiddenFields is Modified



##### SuperOffice.CRM.Data.DBC.ScreenDefinitionLanguageFields is Modified



##### SuperOffice.CRM.Data.DBC.ScriptTraceFields is Modified



##### SuperOffice.CRM.Data.DBC.ScriptTraceRunFields is Modified



##### SuperOffice.CRM.Data.DBC.SDynCriteriaFields is Modified



##### SuperOffice.CRM.Data.DBC.SearchCatFields is Modified



##### SuperOffice.CRM.Data.DBC.SearchCatGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SearchCatHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SearchCriteriaFields is Modified



##### SuperOffice.CRM.Data.DBC.SearchCriteriaGroupFields is Modified



##### SuperOffice.CRM.Data.DBC.SearchCriterionFields is Modified



##### SuperOffice.CRM.Data.DBC.SearchCriterionValueFields is Modified



##### SuperOffice.CRM.Data.DBC.SelectionFields is Modified



##### SuperOffice.CRM.Data.DBC.SelectionMemberFields is Modified



##### SuperOffice.CRM.Data.DBC.SequenceFields is Modified



##### SuperOffice.CRM.Data.DBC.ServiceAuthFields is Modified



##### SuperOffice.CRM.Data.DBC.SessionObjectFields is Modified



##### SuperOffice.CRM.Data.DBC.ShipmentTypeFields is Modified



##### SuperOffice.CRM.Data.DBC.ShipmentTypeReservationFields is Modified



##### SuperOffice.CRM.Data.DBC.SLinkCustomerFields is Modified



##### SuperOffice.CRM.Data.DBC.SLinkCustomerStaticalFields is Modified



##### SuperOffice.CRM.Data.DBC.SLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SListCustomerFields is Modified



##### SuperOffice.CRM.Data.DBC.SListElementFields is Modified



##### SuperOffice.CRM.Data.DBC.SListFields is Modified



##### SuperOffice.CRM.Data.DBC.SListShipmentFields is Modified



##### SuperOffice.CRM.Data.DBC.SMessageblockFields is Modified



##### SuperOffice.CRM.Data.DBC.SMessageFields is Modified



##### SuperOffice.CRM.Data.DBC.SmsFields is Modified



##### SuperOffice.CRM.Data.DBC.SmsHysteriaFields is Modified



##### SuperOffice.CRM.Data.DBC.SnapshotFields is Modified



##### SuperOffice.CRM.Data.DBC.SoapAccessFields is Modified



##### SuperOffice.CRM.Data.DBC.SORCriteriaFields is Modified



##### SuperOffice.CRM.Data.DBC.SORFCTFields is Modified



##### SuperOffice.CRM.Data.DBC.SORFieldFields is Modified



##### SuperOffice.CRM.Data.DBC.SORLabelLayoutFields is Modified



##### SuperOffice.CRM.Data.DBC.SOROperatorsFields is Modified



##### SuperOffice.CRM.Data.DBC.SORPublishFields is Modified



##### SuperOffice.CRM.Data.DBC.SORPublishGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SORSectionFields is Modified



##### SuperOffice.CRM.Data.DBC.SORTemplateFields is Modified



##### SuperOffice.CRM.Data.DBC.SourceFields is Modified



##### SuperOffice.CRM.Data.DBC.SourceGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SourceHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SPictureEntryFields is Modified



##### SuperOffice.CRM.Data.DBC.SPictureFolderFields is Modified



##### SuperOffice.CRM.Data.DBC.SSentMessageFields is Modified



##### SuperOffice.CRM.Data.DBC.SShipmentAddrFields is Modified



##### SuperOffice.CRM.Data.DBC.SShipmentFields is Modified



##### SuperOffice.CRM.Data.DBC.SSmtpServersFields is Modified



##### SuperOffice.CRM.Data.DBC.StakeholderRoleFields is Modified



##### SuperOffice.CRM.Data.DBC.StakeholderRoleGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.StakeholderRoleHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.StaticListRefFields is Modified



##### SuperOffice.CRM.Data.DBC.StatusDefFields is Modified



##### SuperOffice.CRM.Data.DBC.StatusValueFields is Modified



##### SuperOffice.CRM.Data.DBC.SubscriptionUnitFields is Modified



##### SuperOffice.CRM.Data.DBC.SubscriptionUnitGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SubscriptionUnitHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.SuggestedAppointmentFields is Modified



##### SuperOffice.CRM.Data.DBC.SuggestedDocumentFields is Modified



##### SuperOffice.CRM.Data.DBC.SuperListColumnSizeFields is Modified



##### SuperOffice.CRM.Data.DBC.SWashingFields is Modified



##### SuperOffice.CRM.Data.DBC.SWashingListFields is Modified



##### SuperOffice.CRM.Data.DBC.SystemEventFields is Modified



##### SuperOffice.CRM.Data.DBC.SystemScriptFields is Modified



##### SuperOffice.CRM.Data.DBC.TabOrderFields is Modified



##### SuperOffice.CRM.Data.DBC.TagsFields is Modified



##### SuperOffice.CRM.Data.DBC.TagsGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.TagsHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.TargetAssignmentInfoFields is Modified



##### SuperOffice.CRM.Data.DBC.TargetAssignmentValueFields is Modified



##### SuperOffice.CRM.Data.DBC.TargetChangeFields is Modified



##### SuperOffice.CRM.Data.DBC.TargetDimensionFields is Modified



##### SuperOffice.CRM.Data.DBC.TargetGroupFields is Modified



##### SuperOffice.CRM.Data.DBC.TargetPeriodFields is Modified



##### SuperOffice.CRM.Data.DBC.TargetRevisionFields is Modified



##### SuperOffice.CRM.Data.DBC.TargetRevisionHistoryFields is Modified



##### SuperOffice.CRM.Data.DBC.TaskFields is Modified



##### SuperOffice.CRM.Data.DBC.TaskGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.TaskHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.TemporaryKeyFields is Modified



##### SuperOffice.CRM.Data.DBC.TemporaryWordsFields is Modified



##### SuperOffice.CRM.Data.DBC.TextFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketAlertFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketAttachmentFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketCustomersFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketFields is Modified

* New items
  * Field `.TicketFieldsProjectId`
  * Field `.TicketFieldsSaleId`


##### SuperOffice.CRM.Data.DBC.TicketLogActionFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketLogChangeFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketLogFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketPriorityFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketRelationActionFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketRelationFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketRelationTypeFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketStatusFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketStatusHistoryFields is Modified



##### SuperOffice.CRM.Data.DBC.TicketTypeFields is Modified



##### SuperOffice.CRM.Data.DBC.TimestampsFields is Modified



##### SuperOffice.CRM.Data.DBC.TravelCurrentFields is Modified



##### SuperOffice.CRM.Data.DBC.TravelGeneratedDatabaseFields is Modified



##### SuperOffice.CRM.Data.DBC.TravelGeneratedTransactionFields is Modified



##### SuperOffice.CRM.Data.DBC.TravelIDMappingFields is Modified



##### SuperOffice.CRM.Data.DBC.TravellerFields is Modified



##### SuperOffice.CRM.Data.DBC.TravelTransactionLogFields is Modified



##### SuperOffice.CRM.Data.DBC.TrayAppFields is Modified



##### SuperOffice.CRM.Data.DBC.TreeExplorerEntryFields is Modified



##### SuperOffice.CRM.Data.DBC.TreeExplorerLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.TypicalSearchFields is Modified



##### SuperOffice.CRM.Data.DBC.TZDstRuleFields is Modified



##### SuperOffice.CRM.Data.DBC.TZLocationFields is Modified



##### SuperOffice.CRM.Data.DBC.TZStdRuleFields is Modified



##### SuperOffice.CRM.Data.DBC.UDAppntLargeFields is Modified



##### SuperOffice.CRM.Data.DBC.UDAppntSmallFields is Modified



##### SuperOffice.CRM.Data.DBC.UDContactLargeFields is Modified



##### SuperOffice.CRM.Data.DBC.UDContactSmallFields is Modified



##### SuperOffice.CRM.Data.DBC.UDDocLargeFields is Modified



##### SuperOffice.CRM.Data.DBC.UDDocSmallFields is Modified



##### SuperOffice.CRM.Data.DBC.UDefFieldFields is Modified



##### SuperOffice.CRM.Data.DBC.UDefFieldGLFields is Modified



##### SuperOffice.CRM.Data.DBC.UDListDefinitionFields is Modified



##### SuperOffice.CRM.Data.DBC.UDListFields is Modified



##### SuperOffice.CRM.Data.DBC.UDListGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.UDListHeadingLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.UDPersonLargeFields is Modified



##### SuperOffice.CRM.Data.DBC.UDPersonSmallFields is Modified



##### SuperOffice.CRM.Data.DBC.UDProjectLargeFields is Modified



##### SuperOffice.CRM.Data.DBC.UDProjectSmallFields is Modified



##### SuperOffice.CRM.Data.DBC.UDSaleLargeFields is Modified



##### SuperOffice.CRM.Data.DBC.UDSaleSmallFields is Modified



##### SuperOffice.CRM.Data.DBC.UDTempLargeFields is Modified



##### SuperOffice.CRM.Data.DBC.UDTempSmallFields is Modified



##### SuperOffice.CRM.Data.DBC.URLFields is Modified



##### SuperOffice.CRM.Data.DBC.UsageStatsFields is Modified



##### SuperOffice.CRM.Data.DBC.UserAttributeFields is Modified



##### SuperOffice.CRM.Data.DBC.UserCandidateFields is Modified



##### SuperOffice.CRM.Data.DBC.UserGroupFields is Modified



##### SuperOffice.CRM.Data.DBC.UserGroupLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.UserPreferenceFields is Modified



##### SuperOffice.CRM.Data.DBC.UserRoleLinkFields is Modified



##### SuperOffice.CRM.Data.DBC.VisibleForFields is Modified



##### SuperOffice.CRM.Data.DBC.WebAppUsageFields is Modified



##### SuperOffice.CRM.Data.DBC.WebhookFields is Modified



##### SuperOffice.CRM.Data.DBC.WebhookUsageFields is Modified



##### SuperOffice.CRM.Data.DBC.WinPosSizeFields is Modified



##### SuperOffice.CRM.Data.DBC.WordRelationsFields is Modified



##### SuperOffice.CRM.Data.DBC.WsdlDescriptionFields is Modified



##### SuperOffice.CRM.Data.DBC.ZipToCityFields is Modified


* New items
  * Field `TaskMenu`
  * Field `TaskMenuGroupLink`
  * Field `TaskMenuHeadingLink`

##### SuperOffice.CRM.Data.DBC.TaskMenuFields is New

##### SuperOffice.CRM.Data.DBC.TaskMenuGroupLinkFields is New

##### SuperOffice.CRM.Data.DBC.TaskMenuHeadingLinkFields is New

#### SuperOffice.CRM.Data.DbiAgentFieldTableInfo is Modified


#### SuperOffice.CRM.Data.DbiAgentScheduleTableInfo is Modified


#### SuperOffice.CRM.Data.DbiAgentTableInfo is Modified


#### SuperOffice.CRM.Data.DeliveryTermsGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.DeliveryTermsHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.DeliveryTermsTableInfo is Modified


#### SuperOffice.CRM.Data.DeliveryTypeGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.DeliveryTypeHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.DeliveryTypeTableInfo is Modified


#### SuperOffice.CRM.Data.DiaryViewRowTableInfo is Modified


#### SuperOffice.CRM.Data.DiaryViewTableInfo is Modified


#### SuperOffice.CRM.Data.DictionaryBaseTableInfo is Modified


#### SuperOffice.CRM.Data.DictionaryTableInfo is Modified


#### SuperOffice.CRM.Data.DocDocumentTableInfo is Modified


#### SuperOffice.CRM.Data.DocFolderTableInfo is Modified


#### SuperOffice.CRM.Data.DocTmplGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.DocTmplHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.DocTmplTableInfo is Modified


#### SuperOffice.CRM.Data.DocumentTableInfo is Modified


#### SuperOffice.CRM.Data.EabEntryTableInfo is Modified


#### SuperOffice.CRM.Data.EabFolderTableInfo is Modified


#### SuperOffice.CRM.Data.EjCategoryGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.EjCategoryTableInfo is Modified


#### SuperOffice.CRM.Data.EjMessageTableInfo is Modified


#### SuperOffice.CRM.Data.EjpackageItemTableInfo is Modified


#### SuperOffice.CRM.Data.EjpackageTableInfo is Modified


#### SuperOffice.CRM.Data.EjRoleTableInfo is Modified


#### SuperOffice.CRM.Data.EjscriptDebugTableInfo is Modified


#### SuperOffice.CRM.Data.EjscriptTableInfo is Modified

* New items
  * Property `LeftOuterJoin_TaskMenu_CrmScriptId`

#### SuperOffice.CRM.Data.EjselectionTableInfo is Modified


#### SuperOffice.CRM.Data.EjselEjselTableInfo is Modified


#### SuperOffice.CRM.Data.EjselMetaResultTableInfo is Modified


#### SuperOffice.CRM.Data.EjselResultSetTableInfo is Modified


#### SuperOffice.CRM.Data.EjselSourceIdlistTableInfo is Modified


#### SuperOffice.CRM.Data.EjselSourceScriptTableInfo is Modified


#### SuperOffice.CRM.Data.EjselSourceXmlTableInfo is Modified


#### SuperOffice.CRM.Data.EjuserTableInfo is Modified


#### SuperOffice.CRM.Data.ElementProfileTableInfo is Modified


#### SuperOffice.CRM.Data.EmailAccountTableInfo is Modified


#### SuperOffice.CRM.Data.EmailAttachmentTableInfo is Modified


#### SuperOffice.CRM.Data.EmailFolderTableInfo is Modified


#### SuperOffice.CRM.Data.EmailItemTableInfo is Modified


#### SuperOffice.CRM.Data.EmailTableInfo is Modified


#### SuperOffice.CRM.Data.ErpConfigurationTableInfo is Modified


#### SuperOffice.CRM.Data.ErpConnectionAccessTableInfo is Modified


#### SuperOffice.CRM.Data.ErpConnectionActorTypeTableInfo is Modified


#### SuperOffice.CRM.Data.ErpConnectionTableInfo is Modified


#### SuperOffice.CRM.Data.ErpConnectorTableInfo is Modified


#### SuperOffice.CRM.Data.ErpExternalKeyTableInfo is Modified


#### SuperOffice.CRM.Data.ErpFieldTableInfo is Modified


#### SuperOffice.CRM.Data.ErpInternalKeyTableInfo is Modified


#### SuperOffice.CRM.Data.ErpListItemMappingTableInfo is Modified


#### SuperOffice.CRM.Data.ErpSyncLogTableInfo is Modified


#### SuperOffice.CRM.Data.ExtAppGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ExtAppHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ExtAppTableInfo is Modified


#### SuperOffice.CRM.Data.ExtDatasourceTableInfo is Modified


#### SuperOffice.CRM.Data.ExternalDocumentTableInfo is Modified


#### SuperOffice.CRM.Data.ExternalEventTableInfo is Modified


#### SuperOffice.CRM.Data.ExtFieldTableInfo is Modified


#### SuperOffice.CRM.Data.ExtraFieldsTableInfo is Modified


#### SuperOffice.CRM.Data.ExtraMenusTableInfo is Modified


#### SuperOffice.CRM.Data.ExtraTablesEntryTableInfo is Modified


#### SuperOffice.CRM.Data.ExtraTablesResultTableInfo is Modified


#### SuperOffice.CRM.Data.ExtraTablesTableInfo is Modified


#### SuperOffice.CRM.Data.ExtTableTableInfo is Modified


#### SuperOffice.CRM.Data.FavouriteTableInfo is Modified


#### SuperOffice.CRM.Data.FieldLabelTableInfo is Modified


#### SuperOffice.CRM.Data.ForeignAppTableInfo is Modified


#### SuperOffice.CRM.Data.ForeignDeviceTableInfo is Modified


#### SuperOffice.CRM.Data.ForeignKeyTableInfo is Modified


#### SuperOffice.CRM.Data.FormKeysTableInfo is Modified


#### SuperOffice.CRM.Data.FormSubmissionTableInfo is Modified


#### SuperOffice.CRM.Data.FormTableInfo is Modified


#### SuperOffice.CRM.Data.FreeTextIndexTableInfo is Modified


#### SuperOffice.CRM.Data.FreeTextStopWordsTableInfo is Modified


#### SuperOffice.CRM.Data.FreeTextWordsTableInfo is Modified


#### SuperOffice.CRM.Data.FunctionRightRoleLinkTableInfo is Modified


#### SuperOffice.CRM.Data.FunctionRightTableInfo is Modified


#### SuperOffice.CRM.Data.HeadingTableInfo is Modified

* New items
  * Property `LeftOuterJoin_TaskMenuHeadingLink_HeadingId`

#### SuperOffice.CRM.Data.HelpTableInfo is Modified


#### SuperOffice.CRM.Data.HierarchyTableInfo is Modified


#### SuperOffice.CRM.Data.HistoryTableInfo is Modified


#### SuperOffice.CRM.Data.HotlistTableInfo is Modified


#### SuperOffice.CRM.Data.ImportDefaultTableInfo is Modified


#### SuperOffice.CRM.Data.ImportFieldTableInfo is Modified


#### SuperOffice.CRM.Data.ImportObjectTableInfo is Modified


#### SuperOffice.CRM.Data.ImportRelationTableInfo is Modified


#### SuperOffice.CRM.Data.InboxTableInfo is Modified


#### SuperOffice.CRM.Data.IntentGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.IntentHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.IntentTableInfo is Modified


#### SuperOffice.CRM.Data.InvitationTableInfo is Modified


#### SuperOffice.CRM.Data.InvoiceEntryTableInfo is Modified


#### SuperOffice.CRM.Data.InvoiceSumTableInfo is Modified


#### SuperOffice.CRM.Data.InvoiceTableInfo is Modified


#### SuperOffice.CRM.Data.InvoiceTypeTableInfo is Modified


#### SuperOffice.CRM.Data.ItemConfigTableInfo is Modified


#### SuperOffice.CRM.Data.KbAttachmentTableInfo is Modified


#### SuperOffice.CRM.Data.KbCategoryLogTableInfo is Modified


#### SuperOffice.CRM.Data.KbCategoryTableInfo is Modified


#### SuperOffice.CRM.Data.KbEntryCommentTableInfo is Modified


#### SuperOffice.CRM.Data.KbEntryKeywordTableInfo is Modified


#### SuperOffice.CRM.Data.KbEntryLogTableInfo is Modified


#### SuperOffice.CRM.Data.KbEntryTableInfo is Modified


#### SuperOffice.CRM.Data.KbEntryWordsTableInfo is Modified


#### SuperOffice.CRM.Data.KbGroupEntryTableInfo is Modified


#### SuperOffice.CRM.Data.KbGroupTableInfo is Modified


#### SuperOffice.CRM.Data.KbHttpLinkTableInfo is Modified


#### SuperOffice.CRM.Data.KbSolutionFinderEntryTableInfo is Modified


#### SuperOffice.CRM.Data.KbSolutionFinderTableInfo is Modified


#### SuperOffice.CRM.Data.KbWorkflowAccessTableInfo is Modified


#### SuperOffice.CRM.Data.KbWorkflowTableInfo is Modified


#### SuperOffice.CRM.Data.LanguageInfoCountryTableInfo is Modified


#### SuperOffice.CRM.Data.LanguageInfoTableInfo is Modified


#### SuperOffice.CRM.Data.LegalBaseTableInfo is Modified


#### SuperOffice.CRM.Data.LegalHtmlTagsTableInfo is Modified


#### SuperOffice.CRM.Data.LicenseAssocLinkTableInfo is Modified


#### SuperOffice.CRM.Data.LicenseSatlLinkTableInfo is Modified


#### SuperOffice.CRM.Data.LocaleTextTableInfo is Modified


#### SuperOffice.CRM.Data.LockingTableInfo is Modified


#### SuperOffice.CRM.Data.LogDebugTableInfo is Modified


#### SuperOffice.CRM.Data.LogEventsTableInfo is Modified


#### SuperOffice.CRM.Data.LoginCustomerTableInfo is Modified


#### SuperOffice.CRM.Data.LoginTableInfo is Modified


#### SuperOffice.CRM.Data.MailAliasTableInfo is Modified


#### SuperOffice.CRM.Data.MailBlockTableInfo is Modified


#### SuperOffice.CRM.Data.MailInFilterTableInfo is Modified


#### SuperOffice.CRM.Data.MailInUidlTableInfo is Modified


#### SuperOffice.CRM.Data.MergeMoveLogTableInfo is Modified


#### SuperOffice.CRM.Data.MessageCustomersTableInfo is Modified


#### SuperOffice.CRM.Data.MessageHandlerTableInfo is Modified


#### SuperOffice.CRM.Data.MessageHeaderTableInfo is Modified


#### SuperOffice.CRM.Data.MessageIdTableInfo is Modified


#### SuperOffice.CRM.Data.MessageTableInfo is Modified


#### SuperOffice.CRM.Data.ModuleLicenseTableInfo is Modified


#### SuperOffice.CRM.Data.ModuleOwnerTableInfo is Modified


#### SuperOffice.CRM.Data.MrMrsGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.MrMrsHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.MrMrsTableInfo is Modified


#### SuperOffice.CRM.Data.MsFilterMailTableInfo is Modified


#### SuperOffice.CRM.Data.MsFilterTableInfo is Modified


#### SuperOffice.CRM.Data.MsSubstituteTableInfo is Modified


#### SuperOffice.CRM.Data.MsTrashbinTableInfo is Modified


#### SuperOffice.CRM.Data.NoticeFrameTableInfo is Modified


#### SuperOffice.CRM.Data.NotifyTableInfo is Modified


#### SuperOffice.CRM.Data.OLEFieldTableInfo is Modified


#### SuperOffice.CRM.Data.OLEFieldTextTableInfo is Modified


#### SuperOffice.CRM.Data.OLESubjectTableInfo is Modified


#### SuperOffice.CRM.Data.OLESubjectTextTableInfo is Modified


#### SuperOffice.CRM.Data.OLEViewTableInfo is Modified


#### SuperOffice.CRM.Data.OLEViewTextTableInfo is Modified


#### SuperOffice.CRM.Data.OnlineAppTableInfo is Modified


#### SuperOffice.CRM.Data.OutboxTableInfo is Modified


#### SuperOffice.CRM.Data.OutgoingMessageTableInfo is Modified


#### SuperOffice.CRM.Data.OwnerContactLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PasswordRulesTableInfo is Modified


#### SuperOffice.CRM.Data.PaymentTermsGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PaymentTermsHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PaymentTermsTableInfo is Modified


#### SuperOffice.CRM.Data.PaymentTypeGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PaymentTypeHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PaymentTypeTableInfo is Modified


#### SuperOffice.CRM.Data.PersIntGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PersIntHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PersIntTableInfo is Modified


#### SuperOffice.CRM.Data.PersonInterestTableInfo is Modified


#### SuperOffice.CRM.Data.PersonTableInfo is Modified


#### SuperOffice.CRM.Data.PersPosGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PersPosHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PersPosTableInfo is Modified


#### SuperOffice.CRM.Data.PhoneFormatTableInfo is Modified


#### SuperOffice.CRM.Data.PhoneTableInfo is Modified


#### SuperOffice.CRM.Data.PMembTypeGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PMembTypeHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PMembTypeTableInfo is Modified


#### SuperOffice.CRM.Data.PrefDescLineTableInfo is Modified


#### SuperOffice.CRM.Data.PrefDescTableInfo is Modified


#### SuperOffice.CRM.Data.PreferenceTableInfo is Modified


#### SuperOffice.CRM.Data.PriceListTableInfo is Modified


#### SuperOffice.CRM.Data.PriceUnitGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PriceUnitHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PriceUnitTableInfo is Modified


#### SuperOffice.CRM.Data.PriorityGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PriorityHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.PriorityTableInfo is Modified


#### SuperOffice.CRM.Data.ProbGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProbHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProbTableInfo is Modified


#### SuperOffice.CRM.Data.ProductCategoryGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProductCategoryHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProductCategoryTableInfo is Modified


#### SuperOffice.CRM.Data.ProductFamilyGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProductFamilyHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProductFamilyTableInfo is Modified


#### SuperOffice.CRM.Data.ProductTableInfo is Modified


#### SuperOffice.CRM.Data.ProductTypeGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProductTypeHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProductTypeTableInfo is Modified


#### SuperOffice.CRM.Data.ProductVersionTableInfo is Modified


#### SuperOffice.CRM.Data.ProfileTableInfo is Modified


#### SuperOffice.CRM.Data.ProjectMemberTableInfo is Modified


#### SuperOffice.CRM.Data.ProjectTableInfo is Modified

* New items
  * Property `LeftOuterJoin_Ticket_ProjectId`

#### SuperOffice.CRM.Data.ProjectTypeStatusLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProjStatusGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProjStatusHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProjStatusTableInfo is Modified


#### SuperOffice.CRM.Data.ProjTypeGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProjTypeHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ProjTypeTableInfo is Modified


#### SuperOffice.CRM.Data.PublishTableInfo is Modified


#### SuperOffice.CRM.Data.PushNotificationServiceTableInfo is Modified


#### SuperOffice.CRM.Data.QuickReplyTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteAlternativeTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteApprReasonGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteApprReasonHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteApprReasonTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteConnectionAccessTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteConnectionTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteDenyReasonGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteDenyReasonHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteDenyReasonTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteLineConfigurationTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteLineTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteVersionAttachmentTableInfo is Modified


#### SuperOffice.CRM.Data.QuoteVersionTableInfo is Modified


#### SuperOffice.CRM.Data.ReasonGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ReasonHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ReasonSoldGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ReasonSoldHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ReasonSoldTableInfo is Modified


#### SuperOffice.CRM.Data.ReasonStalledGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ReasonStalledHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.ReasonStalledTableInfo is Modified


#### SuperOffice.CRM.Data.ReasonTableInfo is Modified


#### SuperOffice.CRM.Data.RecurrenceRuleTableInfo is Modified


#### SuperOffice.CRM.Data.RedLetterDayTableInfo is Modified


#### SuperOffice.CRM.Data.RefCountRangeTableInfo is Modified


#### SuperOffice.CRM.Data.RefCountsTableInfo is Modified


#### SuperOffice.CRM.Data.RegistryTableInfo is Modified


#### SuperOffice.CRM.Data.RejectReasonGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.RejectReasonHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.RejectReasonTableInfo is Modified


#### SuperOffice.CRM.Data.RelationDefinitionGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.RelationDefinitionHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.RelationDefinitionTableInfo is Modified


#### SuperOffice.CRM.Data.RelationsTableInfo is Modified


#### SuperOffice.CRM.Data.RelationTargetTableInfo is Modified


#### SuperOffice.CRM.Data.ReplyTemplateAttachmentTableInfo is Modified


#### SuperOffice.CRM.Data.ReplyTemplateBodyTableInfo is Modified


#### SuperOffice.CRM.Data.ReplyTemplateFolderTableInfo is Modified


#### SuperOffice.CRM.Data.ReplyTemplateTableInfo is Modified


#### SuperOffice.CRM.Data.ReporterListDefTableInfo is Modified


#### SuperOffice.CRM.Data.ResourceOverrideTableInfo is Modified


#### SuperOffice.CRM.Data.RoleCategoryTableInfo is Modified


#### SuperOffice.CRM.Data.RoleElementTableInfo is Modified


#### SuperOffice.CRM.Data.RoleMemberTableInfo is Modified


#### SuperOffice.CRM.Data.RoleTableInfo is Modified


#### SuperOffice.CRM.Data.RoleWorkflowTableInfo is Modified


#### SuperOffice.CRM.Data.SaintConfigurationTableInfo is Modified


#### SuperOffice.CRM.Data.SaleHistTableInfo is Modified


#### SuperOffice.CRM.Data.SaleStakeholderTableInfo is Modified


#### SuperOffice.CRM.Data.SaleTableInfo is Modified

* New items
  * Property `LeftOuterJoin_Ticket_SaleId`

#### SuperOffice.CRM.Data.SaleTypeCatGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SaleTypeCatHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SaleTypeCatTableInfo is Modified


#### SuperOffice.CRM.Data.SaleTypeGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SaleTypeHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SaleTypeQuoteAttachmentTableInfo is Modified


#### SuperOffice.CRM.Data.SaleTypeStageLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SaleTypeTableInfo is Modified


#### SuperOffice.CRM.Data.SalutationGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SalutationHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SalutationTableInfo is Modified


#### SuperOffice.CRM.Data.SatelliteTableInfo is Modified


#### SuperOffice.CRM.Data.SAttachmentTableInfo is Modified


#### SuperOffice.CRM.Data.SBounceShipmentTableInfo is Modified


#### SuperOffice.CRM.Data.ScheduledTaskTableInfo is Modified


#### SuperOffice.CRM.Data.ScheduleTableInfo is Modified


#### SuperOffice.CRM.Data.ScreenChooserTableInfo is Modified


#### SuperOffice.CRM.Data.ScreenDefinitionActionTableInfo is Modified


#### SuperOffice.CRM.Data.ScreenDefinitionElementTableInfo is Modified


#### SuperOffice.CRM.Data.ScreenDefinitionHiddenTableInfo is Modified


#### SuperOffice.CRM.Data.ScreenDefinitionLanguageTableInfo is Modified


#### SuperOffice.CRM.Data.ScreenDefinitionTableInfo is Modified


#### SuperOffice.CRM.Data.ScriptTraceRunTableInfo is Modified


#### SuperOffice.CRM.Data.ScriptTraceTableInfo is Modified


#### SuperOffice.CRM.Data.SDynCriteriaTableInfo is Modified


#### SuperOffice.CRM.Data.SearchCatGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SearchCatHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SearchCatTableInfo is Modified


#### SuperOffice.CRM.Data.SearchCriteriaGroupTableInfo is Modified


#### SuperOffice.CRM.Data.SearchCriteriaTableInfo is Modified


#### SuperOffice.CRM.Data.SearchCriterionTableInfo is Modified


#### SuperOffice.CRM.Data.SearchCriterionValueTableInfo is Modified


#### SuperOffice.CRM.Data.SelectionMemberTableInfo is Modified


#### SuperOffice.CRM.Data.SelectionTableInfo is Modified


#### SuperOffice.CRM.Data.SequenceTableInfo is Modified


#### SuperOffice.CRM.Data.ServiceAuthTableInfo is Modified


#### SuperOffice.CRM.Data.SessionObjectTableInfo is Modified


#### SuperOffice.CRM.Data.ShipmentTypeReservationTableInfo is Modified


#### SuperOffice.CRM.Data.ShipmentTypeTableInfo is Modified


#### SuperOffice.CRM.Data.SLinkCustomerStaticalTableInfo is Modified


#### SuperOffice.CRM.Data.SLinkCustomerTableInfo is Modified


#### SuperOffice.CRM.Data.SLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SListCustomerTableInfo is Modified


#### SuperOffice.CRM.Data.SListElementTableInfo is Modified


#### SuperOffice.CRM.Data.SListShipmentTableInfo is Modified


#### SuperOffice.CRM.Data.SListTableInfo is Modified


#### SuperOffice.CRM.Data.SMessageblockTableInfo is Modified


#### SuperOffice.CRM.Data.SMessageTableInfo is Modified


#### SuperOffice.CRM.Data.SmsHysteriaTableInfo is Modified


#### SuperOffice.CRM.Data.SmsTableInfo is Modified


#### SuperOffice.CRM.Data.SnapshotTableInfo is Modified


#### SuperOffice.CRM.Data.SoapAccessTableInfo is Modified


#### SuperOffice.CRM.Data.SORCriteriaTableInfo is Modified


#### SuperOffice.CRM.Data.SORFCTTableInfo is Modified


#### SuperOffice.CRM.Data.SORFieldTableInfo is Modified


#### SuperOffice.CRM.Data.SORLabelLayoutTableInfo is Modified


#### SuperOffice.CRM.Data.SOROperatorsTableInfo is Modified


#### SuperOffice.CRM.Data.SORPublishGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SORPublishTableInfo is Modified


#### SuperOffice.CRM.Data.SORSectionTableInfo is Modified


#### SuperOffice.CRM.Data.SORTemplateTableInfo is Modified


#### SuperOffice.CRM.Data.SourceGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SourceHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SourceTableInfo is Modified


#### SuperOffice.CRM.Data.SPictureEntryTableInfo is Modified


#### SuperOffice.CRM.Data.SPictureFolderTableInfo is Modified


#### SuperOffice.CRM.Data.SSentMessageTableInfo is Modified


#### SuperOffice.CRM.Data.SShipmentAddrTableInfo is Modified


#### SuperOffice.CRM.Data.SShipmentTableInfo is Modified


#### SuperOffice.CRM.Data.SSmtpServersTableInfo is Modified


#### SuperOffice.CRM.Data.StakeholderRoleGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.StakeholderRoleHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.StakeholderRoleTableInfo is Modified


#### SuperOffice.CRM.Data.StaticListRefTableInfo is Modified


#### SuperOffice.CRM.Data.StatusDefTableInfo is Modified


#### SuperOffice.CRM.Data.StatusValueTableInfo is Modified


#### SuperOffice.CRM.Data.SubscriptionUnitGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SubscriptionUnitHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.SubscriptionUnitTableInfo is Modified


#### SuperOffice.CRM.Data.SuggestedAppointmentTableInfo is Modified


#### SuperOffice.CRM.Data.SuggestedDocumentTableInfo is Modified


#### SuperOffice.CRM.Data.SuperListColumnSizeTableInfo is Modified


#### SuperOffice.CRM.Data.SWashingListTableInfo is Modified


#### SuperOffice.CRM.Data.SWashingTableInfo is Modified


#### SuperOffice.CRM.Data.SystemEventTableInfo is Modified


#### SuperOffice.CRM.Data.SystemScriptTableInfo is Modified


#### SuperOffice.CRM.Data.TabOrderTableInfo is Modified


#### SuperOffice.CRM.Data.TagsGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.TagsHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.TagsTableInfo is Modified


#### SuperOffice.CRM.Data.TargetAssignmentInfoTableInfo is Modified


#### SuperOffice.CRM.Data.TargetAssignmentValueTableInfo is Modified


#### SuperOffice.CRM.Data.TargetChangeTableInfo is Modified


#### SuperOffice.CRM.Data.TargetDimensionTableInfo is Modified


#### SuperOffice.CRM.Data.TargetGroupTableInfo is Modified


#### SuperOffice.CRM.Data.TargetPeriodTableInfo is Modified


#### SuperOffice.CRM.Data.TargetRevisionHistoryTableInfo is Modified


#### SuperOffice.CRM.Data.TargetRevisionTableInfo is Modified


#### SuperOffice.CRM.Data.TaskGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.TaskHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.TaskTableInfo is Modified


#### SuperOffice.CRM.Data.TemporaryKeyTableInfo is Modified


#### SuperOffice.CRM.Data.TemporaryWordsTableInfo is Modified


#### SuperOffice.CRM.Data.TextTableInfo is Modified


#### SuperOffice.CRM.Data.TicketAlertTableInfo is Modified


#### SuperOffice.CRM.Data.TicketAttachmentTableInfo is Modified


#### SuperOffice.CRM.Data.TicketCustomersTableInfo is Modified


#### SuperOffice.CRM.Data.TicketLogActionTableInfo is Modified


#### SuperOffice.CRM.Data.TicketLogChangeTableInfo is Modified


#### SuperOffice.CRM.Data.TicketLogTableInfo is Modified


#### SuperOffice.CRM.Data.TicketPriorityTableInfo is Modified


#### SuperOffice.CRM.Data.TicketRelationActionTableInfo is Modified


#### SuperOffice.CRM.Data.TicketRelationTableInfo is Modified


#### SuperOffice.CRM.Data.TicketRelationTypeTableInfo is Modified


#### SuperOffice.CRM.Data.TicketStatusHistoryTableInfo is Modified


#### SuperOffice.CRM.Data.TicketStatusTableInfo is Modified


#### SuperOffice.CRM.Data.TicketTableInfo is Modified

* New items
  * Property `ProjectId`
  * Property `ProjectId_InnerJoin_Project`
  * Property `SaleId`
  * Property `SaleId_InnerJoin_Sale`

#### SuperOffice.CRM.Data.TicketTypeTableInfo is Modified


#### SuperOffice.CRM.Data.TimestampsTableInfo is Modified


#### SuperOffice.CRM.Data.TravelCurrentTableInfo is Modified


#### SuperOffice.CRM.Data.TravelGeneratedDatabaseTableInfo is Modified


#### SuperOffice.CRM.Data.TravelGeneratedTransactionTableInfo is Modified


#### SuperOffice.CRM.Data.TravelIDMappingTableInfo is Modified


#### SuperOffice.CRM.Data.TravellerTableInfo is Modified


#### SuperOffice.CRM.Data.TravelTransactionLogTableInfo is Modified


#### SuperOffice.CRM.Data.TrayAppTableInfo is Modified


#### SuperOffice.CRM.Data.TreeExplorerEntryTableInfo is Modified


#### SuperOffice.CRM.Data.TreeExplorerLinkTableInfo is Modified


#### SuperOffice.CRM.Data.TypicalSearchTableInfo is Modified


#### SuperOffice.CRM.Data.TZDstRuleTableInfo is Modified


#### SuperOffice.CRM.Data.TZLocationTableInfo is Modified


#### SuperOffice.CRM.Data.TZStdRuleTableInfo is Modified


#### SuperOffice.CRM.Data.UDAppntLargeTableInfo is Modified


#### SuperOffice.CRM.Data.UDAppntSmallTableInfo is Modified


#### SuperOffice.CRM.Data.UDContactLargeTableInfo is Modified


#### SuperOffice.CRM.Data.UDContactSmallTableInfo is Modified


#### SuperOffice.CRM.Data.UDDocLargeTableInfo is Modified


#### SuperOffice.CRM.Data.UDDocSmallTableInfo is Modified


#### SuperOffice.CRM.Data.UDefFieldGLTableInfo is Modified


#### SuperOffice.CRM.Data.UDefFieldTableInfo is Modified


#### SuperOffice.CRM.Data.UDListDefinitionTableInfo is Modified


#### SuperOffice.CRM.Data.UDListGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.UDListHeadingLinkTableInfo is Modified


#### SuperOffice.CRM.Data.UDListTableInfo is Modified


#### SuperOffice.CRM.Data.UDPersonLargeTableInfo is Modified


#### SuperOffice.CRM.Data.UDPersonSmallTableInfo is Modified


#### SuperOffice.CRM.Data.UDProjectLargeTableInfo is Modified


#### SuperOffice.CRM.Data.UDProjectSmallTableInfo is Modified


#### SuperOffice.CRM.Data.UDSaleLargeTableInfo is Modified


#### SuperOffice.CRM.Data.UDSaleSmallTableInfo is Modified


#### SuperOffice.CRM.Data.UDTempLargeTableInfo is Modified


#### SuperOffice.CRM.Data.UDTempSmallTableInfo is Modified


#### SuperOffice.CRM.Data.URLTableInfo is Modified


#### SuperOffice.CRM.Data.UsageStatsTableInfo is Modified


#### SuperOffice.CRM.Data.UserAttributeTableInfo is Modified


#### SuperOffice.CRM.Data.UserCandidateTableInfo is Modified


#### SuperOffice.CRM.Data.UserGroupLinkTableInfo is Modified


#### SuperOffice.CRM.Data.UserGroupTableInfo is Modified

* New items
  * Property `LeftOuterJoin_TaskMenuGroupLink_GroupId`

#### SuperOffice.CRM.Data.UserPreferenceTableInfo is Modified


#### SuperOffice.CRM.Data.UserRoleLinkTableInfo is Modified


#### SuperOffice.CRM.Data.VisibleForTableInfo is Modified


#### SuperOffice.CRM.Data.WebAppUsageTableInfo is Modified


#### SuperOffice.CRM.Data.WebhookTableInfo is Modified


#### SuperOffice.CRM.Data.WebhookUsageTableInfo is Modified


#### SuperOffice.CRM.Data.WinPosSizeTableInfo is Modified


#### SuperOffice.CRM.Data.WordRelationsTableInfo is Modified


#### SuperOffice.CRM.Data.WsdlDescriptionTableInfo is Modified


#### SuperOffice.CRM.Data.ZipToCityTableInfo is Modified


#### SuperOffice.CRM.Entities.AppointmentMatrix is Modified

* New items
  * Method `SetModifiedAppointmentFields(AppointmentRow)`

#### SuperOffice.CRM.Rows.AccessScriptRecordData is Modified


#### SuperOffice.CRM.Rows.AccessScriptRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AccessScriptRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AccessScriptRow.AccessScriptRowIdx is Modified



##### SuperOffice.CRM.Rows.AccessScriptRow.AccessScriptRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AccessScriptRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AccessScriptRow.IdxAccessScriptId is Modified



#### SuperOffice.CRM.Rows.AccessScriptRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AccessScriptRows.AccessScriptRowsIdx is Modified



##### SuperOffice.CRM.Rows.AccessScriptRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.ActiveUserRecordData is Modified


#### SuperOffice.CRM.Rows.ActiveUserRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ActiveUserRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ActiveUserRow.ActiveUserRowIdx is Modified



##### SuperOffice.CRM.Rows.ActiveUserRow.ActiveUserRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ActiveUserRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ActiveUserRow.IdxActiveuserId is Modified



#### SuperOffice.CRM.Rows.ActiveUserRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ActiveUserRows.ActiveUserRowsIdx is Modified



##### SuperOffice.CRM.Rows.ActiveUserRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.AddressFormatRecordData is Modified


#### SuperOffice.CRM.Rows.AddressFormatRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AddressFormatRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AddressFormatRow.AddressFormatRowIdx is Modified



##### SuperOffice.CRM.Rows.AddressFormatRow.AddressFormatRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AddressFormatRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AddressFormatRow.IdxAddressformatId is Modified



#### SuperOffice.CRM.Rows.AddressFormatRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AddressFormatRows.AddressFormatRowsIdx is Modified



##### SuperOffice.CRM.Rows.AddressFormatRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.AddressRecordData is Modified


#### SuperOffice.CRM.Rows.AddressRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AddressRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AddressRow.AddressRowIdx is Modified



##### SuperOffice.CRM.Rows.AddressRow.AddressRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AddressRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AddressRow.IdxAddressId is Modified



##### SuperOffice.CRM.Rows.AddressRow.IdxOwnerIdAtypeIdx is Modified



#### SuperOffice.CRM.Rows.AddressRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AddressRows.AddressRowsIdx is Modified



##### SuperOffice.CRM.Rows.AddressRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AddressRows.IdxOwnerId is Modified



##### SuperOffice.CRM.Rows.AddressRows.IdxState is Modified



##### SuperOffice.CRM.Rows.AddressRows.IdxZipcode is Modified



#### SuperOffice.CRM.Rows.AmountClassGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.AmountClassGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AmountClassGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AmountClassGroupLinkRow.AmountClassGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.AmountClassGroupLinkRow.AmountClassGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AmountClassGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AmountClassGroupLinkRow.IdxAmountclassgrouplinkId is Modified



#### SuperOffice.CRM.Rows.AmountClassGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AmountClassGroupLinkRows.AmountClassGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.AmountClassGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AmountClassGroupLinkRows.IdxAmountclassId is Modified



##### SuperOffice.CRM.Rows.AmountClassGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.AmountClassHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.AmountClassHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AmountClassHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AmountClassHeadingLinkRow.AmountClassHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.AmountClassHeadingLinkRow.AmountClassHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AmountClassHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AmountClassHeadingLinkRow.IdxAmountclassheadinglinkId is Modified



#### SuperOffice.CRM.Rows.AmountClassHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AmountClassHeadingLinkRows.AmountClassHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.AmountClassHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AmountClassHeadingLinkRows.IdxAmountclassId is Modified



##### SuperOffice.CRM.Rows.AmountClassHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.AmountClassRecordData is Modified


#### SuperOffice.CRM.Rows.AmountClassRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AmountClassRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AmountClassRow.AmountClassRowIdx is Modified



##### SuperOffice.CRM.Rows.AmountClassRow.AmountClassRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AmountClassRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AmountClassRow.IdxAmountClassId is Modified



##### SuperOffice.CRM.Rows.AmountClassRow.IdxName is Modified



#### SuperOffice.CRM.Rows.AmountClassRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AmountClassRows.AmountClassRowsIdx is Modified



##### SuperOffice.CRM.Rows.AmountClassRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AmountClassRows.IdxAmountFrom is Modified



##### SuperOffice.CRM.Rows.AmountClassRows.IdxAmountTo is Modified



#### SuperOffice.CRM.Rows.AppointmentRecordData is Modified

* New items
  * Field `ModifiedAppointmentFields`

#### SuperOffice.CRM.Rows.AppointmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AppointmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AppointmentRow.AppointmentRowIdx is Modified



##### SuperOffice.CRM.Rows.AppointmentRow.AppointmentRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AppointmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AppointmentRow.IdxAppointmentId is Modified



##### SuperOffice.CRM.Rows.AppointmentRow.IdxAssociateIdActiveDateMotherIdAppointmentId is Modified



##### SuperOffice.CRM.Rows.AppointmentRow.IdxMotherIdStatusActiveDateRegisteredAssociateIdRegisteredAssignedByGroupIdxTypeAssociateIdAppointmentId is Modified



##### SuperOffice.CRM.Rows.AppointmentRow.IdxProjectIdTypeActiveDateDocumentIdAssociateIdGroupIdxMotherIdAssignedByAppointmentIdRegisteredRegisteredAssociateId is Modified


* New items
  * Property `ModifiedAppointmentFields`
  * Event `OnModifiedAppointmentFieldsChange`

#### SuperOffice.CRM.Rows.AppointmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AppointmentRows.AppointmentRowsIdx is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxActiveDate is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateIdActiveDate is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateIdActiveDateMotherId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateIdType is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateIdTypeEndDate is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateIdTypeEndDateDoBy is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateIdTypeStatus is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateIdTypeStatusActiveDate is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateIdTypeStatusDoBy is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateIdTypeStatusDone is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxContactIdType is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxDoBy is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxDocumentId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxDone is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxGroupIdx is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxMotherId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxMotherIdStatus is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxMotherIdStatusActiveDate is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxMotherIdStatusActiveDateRegisteredAssociateId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxMotherIdStatusActiveDateRegisteredAssociateIdRegistered is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxMotherIdStatusActiveDateRegisteredAssociateIdRegisteredAssignedBy is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxMotherIdStatusActiveDateRegisteredAssociateIdRegisteredAssignedByGroupIdx is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxMotherIdStatusActiveDateRegisteredAssociateIdRegisteredAssignedByGroupIdxType is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxMotherIdStatusActiveDateRegisteredAssociateIdRegisteredAssignedByGroupIdxTypeAssociateId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxProjectId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxProjectIdType is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxProjectIdTypeActiveDate is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxProjectIdTypeActiveDateDocumentId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxProjectIdTypeActiveDateDocumentIdAssociateId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxProjectIdTypeActiveDateDocumentIdAssociateIdGroupIdx is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxProjectIdTypeActiveDateDocumentIdAssociateIdGroupIdxMotherId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxProjectIdTypeActiveDateDocumentIdAssociateIdGroupIdxMotherIdAssignedBy is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxRecurrenceRuleId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxRecurrenceRuleIdActiveDate is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxRecurrenceRuleIdActiveDateAssociateId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxRecurrenceRuleIdActiveDateMotherId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxSaleId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxSource is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxSuggestedAppointmentId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxSuggestedDocumentId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxTextId is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxUserdef2Id is Modified



##### SuperOffice.CRM.Rows.AppointmentRows.IdxUserdefId is Modified



#### SuperOffice.CRM.Rows.AreaRecordData is Modified


#### SuperOffice.CRM.Rows.AreaRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AreaRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AreaRow.AreaRowIdx is Modified



##### SuperOffice.CRM.Rows.AreaRow.AreaRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AreaRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AreaRow.IdxAreaId is Modified



#### SuperOffice.CRM.Rows.AreaRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AreaRows.AreaRowsIdx is Modified



##### SuperOffice.CRM.Rows.AreaRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AreaRows.IdxParentAreaId is Modified



#### SuperOffice.CRM.Rows.AreaUserAssignmentRecordData is Modified


#### SuperOffice.CRM.Rows.AreaUserAssignmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AreaUserAssignmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AreaUserAssignmentRow.AreaUserAssignmentRowIdx is Modified



##### SuperOffice.CRM.Rows.AreaUserAssignmentRow.AreaUserAssignmentRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AreaUserAssignmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AreaUserAssignmentRow.IdxAreauserassignmentId is Modified



#### SuperOffice.CRM.Rows.AreaUserAssignmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AreaUserAssignmentRows.AreaUserAssignmentRowsIdx is Modified



##### SuperOffice.CRM.Rows.AreaUserAssignmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AreaUserAssignmentRows.IdxAreaId is Modified



##### SuperOffice.CRM.Rows.AreaUserAssignmentRows.IdxAssociateId is Modified



#### SuperOffice.CRM.Rows.AreaUserInclusionRecordData is Modified


#### SuperOffice.CRM.Rows.AreaUserInclusionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AreaUserInclusionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AreaUserInclusionRow.AreaUserInclusionRowIdx is Modified



##### SuperOffice.CRM.Rows.AreaUserInclusionRow.AreaUserInclusionRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AreaUserInclusionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AreaUserInclusionRow.IdxAreauserinclusionId is Modified



#### SuperOffice.CRM.Rows.AreaUserInclusionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AreaUserInclusionRows.AreaUserInclusionRowsIdx is Modified



##### SuperOffice.CRM.Rows.AreaUserInclusionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AreaUserInclusionRows.IdxAreaId is Modified



##### SuperOffice.CRM.Rows.AreaUserInclusionRows.IdxAssociateId is Modified



#### SuperOffice.CRM.Rows.AssociateGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.AssociateGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AssociateGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AssociateGroupLinkRow.AssociateGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.AssociateGroupLinkRow.AssociateGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AssociateGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AssociateGroupLinkRow.IdxAssociategrouplinkId is Modified



#### SuperOffice.CRM.Rows.AssociateGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AssociateGroupLinkRows.AssociateGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.AssociateGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AssociateGroupLinkRows.IdxAssociateId is Modified



##### SuperOffice.CRM.Rows.AssociateGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.AssociateHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.AssociateHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AssociateHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AssociateHeadingLinkRow.AssociateHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.AssociateHeadingLinkRow.AssociateHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AssociateHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AssociateHeadingLinkRow.IdxAssociateheadinglinkId is Modified



#### SuperOffice.CRM.Rows.AssociateHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AssociateHeadingLinkRows.AssociateHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.AssociateHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AssociateHeadingLinkRows.IdxAssociateId is Modified



##### SuperOffice.CRM.Rows.AssociateHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.AssociateHistoryRecordData is Modified


#### SuperOffice.CRM.Rows.AssociateHistoryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AssociateHistoryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AssociateHistoryRow.AssociateHistoryRowIdx is Modified



##### SuperOffice.CRM.Rows.AssociateHistoryRow.AssociateHistoryRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AssociateHistoryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AssociateHistoryRow.IdxAssociateHistoryId is Modified



#### SuperOffice.CRM.Rows.AssociateHistoryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AssociateHistoryRows.AssociateHistoryRowsIdx is Modified



##### SuperOffice.CRM.Rows.AssociateHistoryRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.AssociateRecordData is Modified


#### SuperOffice.CRM.Rows.AssociateRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AssociateRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AssociateRow.AssociateRowIdx is Modified



##### SuperOffice.CRM.Rows.AssociateRow.AssociateRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AssociateRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AssociateRow.IdxAssociateId is Modified



##### SuperOffice.CRM.Rows.AssociateRow.IdxName is Modified



#### SuperOffice.CRM.Rows.AssociateRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AssociateRows.AssociateRowsIdx is Modified



##### SuperOffice.CRM.Rows.AssociateRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AssociateRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.AssociateRows.IdxType is Modified



#### SuperOffice.CRM.Rows.AttachmentLocationRecordData is Modified


#### SuperOffice.CRM.Rows.AttachmentLocationRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AttachmentLocationRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AttachmentLocationRow.AttachmentLocationRowIdx is Modified



##### SuperOffice.CRM.Rows.AttachmentLocationRow.AttachmentLocationRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AttachmentLocationRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AttachmentLocationRow.IdxAttachmentLocationId is Modified



#### SuperOffice.CRM.Rows.AttachmentLocationRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AttachmentLocationRows.AttachmentLocationRowsIdx is Modified



##### SuperOffice.CRM.Rows.AttachmentLocationRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.AttachmentRecordData is Modified


#### SuperOffice.CRM.Rows.AttachmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AttachmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AttachmentRow.AttachmentRowIdx is Modified



##### SuperOffice.CRM.Rows.AttachmentRow.AttachmentRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AttachmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AttachmentRow.IdxAttachmentId is Modified



#### SuperOffice.CRM.Rows.AttachmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AttachmentRows.AttachmentRowsIdx is Modified



##### SuperOffice.CRM.Rows.AttachmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AttachmentRows.IdxDbiAgentId is Modified



##### SuperOffice.CRM.Rows.AttachmentRows.IdxDbiKey is Modified



##### SuperOffice.CRM.Rows.AttachmentRows.IdxDbiLastModified is Modified



##### SuperOffice.CRM.Rows.AttachmentRows.IdxDbiLastSyncronized is Modified



#### SuperOffice.CRM.Rows.AudienceConfigRecordData is Modified


#### SuperOffice.CRM.Rows.AudienceConfigRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AudienceConfigRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AudienceConfigRow.AudienceConfigRowIdx is Modified



##### SuperOffice.CRM.Rows.AudienceConfigRow.AudienceConfigRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AudienceConfigRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AudienceConfigRow.IdxAudienceConfigId is Modified



#### SuperOffice.CRM.Rows.AudienceConfigRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AudienceConfigRows.AudienceConfigRowsIdx is Modified



##### SuperOffice.CRM.Rows.AudienceConfigRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AudienceConfigRows.IdxAudienceLayoutId is Modified



#### SuperOffice.CRM.Rows.AudienceLayoutLinkRecordData is Modified


#### SuperOffice.CRM.Rows.AudienceLayoutLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AudienceLayoutLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AudienceLayoutLinkRow.AudienceLayoutLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.AudienceLayoutLinkRow.AudienceLayoutLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AudienceLayoutLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AudienceLayoutLinkRow.IdxAudienceLayoutLinkId is Modified



#### SuperOffice.CRM.Rows.AudienceLayoutLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AudienceLayoutLinkRows.AudienceLayoutLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.AudienceLayoutLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AudienceLayoutLinkRows.IdxAudienceLayoutId is Modified



##### SuperOffice.CRM.Rows.AudienceLayoutLinkRows.IdxTargetTable is Modified



##### SuperOffice.CRM.Rows.AudienceLayoutLinkRows.IdxTargetTableTargetRecord is Modified



#### SuperOffice.CRM.Rows.AudienceLayoutRecordData is Modified


#### SuperOffice.CRM.Rows.AudienceLayoutRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AudienceLayoutRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AudienceLayoutRow.AudienceLayoutRowIdx is Modified



##### SuperOffice.CRM.Rows.AudienceLayoutRow.AudienceLayoutRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AudienceLayoutRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AudienceLayoutRow.IdxAudienceLayoutId is Modified



##### SuperOffice.CRM.Rows.AudienceLayoutRow.IdxInstanceName is Modified



#### SuperOffice.CRM.Rows.AudienceLayoutRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AudienceLayoutRows.AudienceLayoutRowsIdx is Modified



##### SuperOffice.CRM.Rows.AudienceLayoutRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.AudienceVisibilityRecordData is Modified


#### SuperOffice.CRM.Rows.AudienceVisibilityRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AudienceVisibilityRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AudienceVisibilityRow.AudienceVisibilityRowIdx is Modified



##### SuperOffice.CRM.Rows.AudienceVisibilityRow.AudienceVisibilityRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AudienceVisibilityRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AudienceVisibilityRow.IdxAudienceVisibilityId is Modified



#### SuperOffice.CRM.Rows.AudienceVisibilityRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AudienceVisibilityRows.AudienceVisibilityRowsIdx is Modified



##### SuperOffice.CRM.Rows.AudienceVisibilityRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AudienceVisibilityRows.IdxControllingTable is Modified



##### SuperOffice.CRM.Rows.AudienceVisibilityRows.IdxControllingTableControllingRecord is Modified



##### SuperOffice.CRM.Rows.AudienceVisibilityRows.IdxSourceTable is Modified



##### SuperOffice.CRM.Rows.AudienceVisibilityRows.IdxSourceTableSourceRecord is Modified



#### SuperOffice.CRM.Rows.AutosaveRecordData is Modified


#### SuperOffice.CRM.Rows.AutosaveRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.AutosaveRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.AutosaveRow.AutosaveRowIdx is Modified



##### SuperOffice.CRM.Rows.AutosaveRow.AutosaveRowIdxBase is Modified



##### SuperOffice.CRM.Rows.AutosaveRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AutosaveRow.IdxAutosaveId is Modified



#### SuperOffice.CRM.Rows.AutosaveRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.AutosaveRows.AutosaveRowsIdx is Modified



##### SuperOffice.CRM.Rows.AutosaveRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.AutosaveRows.IdxIndexId is Modified



#### SuperOffice.CRM.Rows.BaseTZLocationRecordData is Modified


#### SuperOffice.CRM.Rows.BaseTZLocationRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.BaseTZLocationRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.BaseTZLocationRow.BaseTZLocationRowIdx is Modified



##### SuperOffice.CRM.Rows.BaseTZLocationRow.BaseTZLocationRowIdxBase is Modified



##### SuperOffice.CRM.Rows.BaseTZLocationRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BaseTZLocationRow.IdxBaseTZLocationId is Modified



#### SuperOffice.CRM.Rows.BaseTZLocationRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.BaseTZLocationRows.BaseTZLocationRowsIdx is Modified



##### SuperOffice.CRM.Rows.BaseTZLocationRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.BatchTaskDefinitionRecordData is Modified


#### SuperOffice.CRM.Rows.BatchTaskDefinitionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.BatchTaskDefinitionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.BatchTaskDefinitionRow.BatchTaskDefinitionRowIdx is Modified



##### SuperOffice.CRM.Rows.BatchTaskDefinitionRow.BatchTaskDefinitionRowIdxBase is Modified



##### SuperOffice.CRM.Rows.BatchTaskDefinitionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BatchTaskDefinitionRow.IdxBatchTaskDefinitionId is Modified



#### SuperOffice.CRM.Rows.BatchTaskDefinitionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.BatchTaskDefinitionRows.BatchTaskDefinitionRowsIdx is Modified



##### SuperOffice.CRM.Rows.BatchTaskDefinitionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BatchTaskDefinitionRows.IdxName is Modified



##### SuperOffice.CRM.Rows.BatchTaskDefinitionRows.IdxNameAssemblyVersion is Modified



#### SuperOffice.CRM.Rows.BatchTaskRecordData is Modified


#### SuperOffice.CRM.Rows.BatchTaskRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.BatchTaskRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.BatchTaskRow.BatchTaskRowIdx is Modified



##### SuperOffice.CRM.Rows.BatchTaskRow.BatchTaskRowIdxBase is Modified



##### SuperOffice.CRM.Rows.BatchTaskRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BatchTaskRow.IdxBatchTaskId is Modified



#### SuperOffice.CRM.Rows.BatchTaskRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.BatchTaskRows.BatchTaskRowsIdx is Modified



##### SuperOffice.CRM.Rows.BatchTaskRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BatchTaskRows.IdxBatchTaskDefinitionId is Modified



##### SuperOffice.CRM.Rows.BatchTaskRows.IdxBatchTaskDefinitionIdState is Modified



##### SuperOffice.CRM.Rows.BatchTaskRows.IdxState is Modified



#### SuperOffice.CRM.Rows.BinaryObjectLinkRecordData is Modified


#### SuperOffice.CRM.Rows.BinaryObjectLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.BinaryObjectLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.BinaryObjectLinkRow.BinaryObjectLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.BinaryObjectLinkRow.BinaryObjectLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.BinaryObjectLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BinaryObjectLinkRow.IdxBinaryObjectLinkId is Modified



#### SuperOffice.CRM.Rows.BinaryObjectLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.BinaryObjectLinkRows.BinaryObjectLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.BinaryObjectLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BinaryObjectLinkRows.IdxOwnerTable is Modified



##### SuperOffice.CRM.Rows.BinaryObjectLinkRows.IdxOwnerTableOwnerRecord is Modified



##### SuperOffice.CRM.Rows.BinaryObjectLinkRows.IdxOwnerTableOwnerRecordLinkType is Modified



##### SuperOffice.CRM.Rows.BinaryObjectLinkRows.IdxOwnerTableOwnerRecordLinkTypeRank is Modified



#### SuperOffice.CRM.Rows.BinaryObjectRecordData is Modified


#### SuperOffice.CRM.Rows.BinaryObjectRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.BinaryObjectRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.BinaryObjectRow.BinaryObjectRowIdx is Modified



##### SuperOffice.CRM.Rows.BinaryObjectRow.BinaryObjectRowIdxBase is Modified



##### SuperOffice.CRM.Rows.BinaryObjectRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BinaryObjectRow.IdxBinaryObjectId is Modified



#### SuperOffice.CRM.Rows.BinaryObjectRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.BinaryObjectRows.BinaryObjectRowsIdx is Modified



##### SuperOffice.CRM.Rows.BinaryObjectRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BinaryObjectRows.IdxConceptualType is Modified



##### SuperOffice.CRM.Rows.BinaryObjectRows.IdxExtraInfo is Modified



##### SuperOffice.CRM.Rows.BinaryObjectRows.IdxMimeType is Modified



#### SuperOffice.CRM.Rows.BusinessGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.BusinessGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.BusinessGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.BusinessGroupLinkRow.BusinessGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.BusinessGroupLinkRow.BusinessGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.BusinessGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BusinessGroupLinkRow.IdxBusinessgrouplinkId is Modified



#### SuperOffice.CRM.Rows.BusinessGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.BusinessGroupLinkRows.BusinessGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.BusinessGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BusinessGroupLinkRows.IdxBusinessId is Modified



##### SuperOffice.CRM.Rows.BusinessGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.BusinessHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.BusinessHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.BusinessHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.BusinessHeadingLinkRow.BusinessHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.BusinessHeadingLinkRow.BusinessHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.BusinessHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BusinessHeadingLinkRow.IdxBusinessheadinglinkId is Modified



#### SuperOffice.CRM.Rows.BusinessHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.BusinessHeadingLinkRows.BusinessHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.BusinessHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BusinessHeadingLinkRows.IdxBusinessId is Modified



##### SuperOffice.CRM.Rows.BusinessHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.BusinessRecordData is Modified


#### SuperOffice.CRM.Rows.BusinessRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.BusinessRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.BusinessRow.BusinessRowIdx is Modified



##### SuperOffice.CRM.Rows.BusinessRow.BusinessRowIdxBase is Modified



##### SuperOffice.CRM.Rows.BusinessRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.BusinessRow.IdxBusinessId is Modified



##### SuperOffice.CRM.Rows.BusinessRow.IdxName is Modified



#### SuperOffice.CRM.Rows.BusinessRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.BusinessRows.BusinessRowsIdx is Modified



##### SuperOffice.CRM.Rows.BusinessRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.CacheInvalidationRecordData is Modified


#### SuperOffice.CRM.Rows.CacheInvalidationRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CacheInvalidationRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CacheInvalidationRow.CacheInvalidationRowIdx is Modified



##### SuperOffice.CRM.Rows.CacheInvalidationRow.CacheInvalidationRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CacheInvalidationRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CacheInvalidationRow.IdxCacheInvalidationId is Modified



##### SuperOffice.CRM.Rows.CacheInvalidationRow.IdxName is Modified



#### SuperOffice.CRM.Rows.CacheInvalidationRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CacheInvalidationRows.CacheInvalidationRowsIdx is Modified



##### SuperOffice.CRM.Rows.CacheInvalidationRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.CacheTablesRecordData is Modified


#### SuperOffice.CRM.Rows.CacheTablesRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CacheTablesRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CacheTablesRow.CacheTablesRowIdx is Modified



##### SuperOffice.CRM.Rows.CacheTablesRow.CacheTablesRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CacheTablesRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CacheTablesRow.IdxCacheTabsId is Modified



#### SuperOffice.CRM.Rows.CacheTablesRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CacheTablesRows.CacheTablesRowsIdx is Modified



##### SuperOffice.CRM.Rows.CacheTablesRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CacheTablesRows.IdxTableId is Modified



#### SuperOffice.CRM.Rows.CategoryFamilyRecordData is Modified


#### SuperOffice.CRM.Rows.CategoryFamilyRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CategoryFamilyRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CategoryFamilyRow.CategoryFamilyRowIdx is Modified



##### SuperOffice.CRM.Rows.CategoryFamilyRow.CategoryFamilyRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CategoryFamilyRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CategoryFamilyRow.IdxCategoryFamilyId is Modified



##### SuperOffice.CRM.Rows.CategoryFamilyRow.IdxName is Modified



#### SuperOffice.CRM.Rows.CategoryFamilyRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CategoryFamilyRows.CategoryFamilyRowsIdx is Modified



##### SuperOffice.CRM.Rows.CategoryFamilyRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.CategoryGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.CategoryGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CategoryGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CategoryGroupLinkRow.CategoryGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.CategoryGroupLinkRow.CategoryGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CategoryGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CategoryGroupLinkRow.IdxCategorygrouplinkId is Modified



#### SuperOffice.CRM.Rows.CategoryGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CategoryGroupLinkRows.CategoryGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.CategoryGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CategoryGroupLinkRows.IdxCategoryId is Modified



##### SuperOffice.CRM.Rows.CategoryGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.CategoryHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.CategoryHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CategoryHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CategoryHeadingLinkRow.CategoryHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.CategoryHeadingLinkRow.CategoryHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CategoryHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CategoryHeadingLinkRow.IdxCategoryheadinglinkId is Modified



#### SuperOffice.CRM.Rows.CategoryHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CategoryHeadingLinkRows.CategoryHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.CategoryHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CategoryHeadingLinkRows.IdxCategoryId is Modified



##### SuperOffice.CRM.Rows.CategoryHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.CategoryMembershipRecordData is Modified

* New items
  * Field `IsDefinedByUsergroup`

#### SuperOffice.CRM.Rows.CategoryMembershipRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CategoryMembershipRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CategoryMembershipRow.CategoryMembershipRowIdx is Modified



##### SuperOffice.CRM.Rows.CategoryMembershipRow.CategoryMembershipRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CategoryMembershipRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CategoryMembershipRow.IdxCategoryMembershipId is Modified


* New items
  * Property `IsDefinedByUsergroup`

#### SuperOffice.CRM.Rows.CategoryMembershipRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CategoryMembershipRows.CategoryMembershipRowsIdx is Modified



##### SuperOffice.CRM.Rows.CategoryMembershipRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CategoryMembershipRows.IdxCategoryId is Modified



##### SuperOffice.CRM.Rows.CategoryMembershipRows.IdxUserId is Modified



#### SuperOffice.CRM.Rows.CategoryRecordData is Modified


#### SuperOffice.CRM.Rows.CategoryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CategoryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CategoryRow.CategoryRowIdx is Modified



##### SuperOffice.CRM.Rows.CategoryRow.CategoryRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CategoryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CategoryRow.IdxCategoryId is Modified



##### SuperOffice.CRM.Rows.CategoryRow.IdxName is Modified



#### SuperOffice.CRM.Rows.CategoryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CategoryRows.CategoryRowsIdx is Modified



##### SuperOffice.CRM.Rows.CategoryRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.ChatMessageRecordData is Modified


#### SuperOffice.CRM.Rows.ChatMessageRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ChatMessageRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ChatMessageRow.ChatMessageRowIdx is Modified



##### SuperOffice.CRM.Rows.ChatMessageRow.ChatMessageRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ChatMessageRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ChatMessageRow.IdxChatMessageId is Modified



#### SuperOffice.CRM.Rows.ChatMessageRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ChatMessageRows.ChatMessageRowsIdx is Modified



##### SuperOffice.CRM.Rows.ChatMessageRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ChatMessageRows.IdxSessionId is Modified



#### SuperOffice.CRM.Rows.ChatSessionRecordData is Modified


#### SuperOffice.CRM.Rows.ChatSessionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ChatSessionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ChatSessionRow.ChatSessionRowIdx is Modified



##### SuperOffice.CRM.Rows.ChatSessionRow.ChatSessionRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ChatSessionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ChatSessionRow.IdxChatSessionId is Modified



#### SuperOffice.CRM.Rows.ChatSessionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ChatSessionRows.ChatSessionRowsIdx is Modified



##### SuperOffice.CRM.Rows.ChatSessionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ChatSessionRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.ChatSessionRows.IdxStatus is Modified



##### SuperOffice.CRM.Rows.ChatSessionRows.IdxStatusTopicId is Modified



##### SuperOffice.CRM.Rows.ChatSessionRows.IdxTopicId is Modified



##### SuperOffice.CRM.Rows.ChatSessionRows.IdxUserId is Modified



#### SuperOffice.CRM.Rows.ChatTopicRecordData is Modified


#### SuperOffice.CRM.Rows.ChatTopicRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ChatTopicRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ChatTopicRow.ChatTopicRowIdx is Modified



##### SuperOffice.CRM.Rows.ChatTopicRow.ChatTopicRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ChatTopicRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ChatTopicRow.IdxChatTopicId is Modified



#### SuperOffice.CRM.Rows.ChatTopicRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ChatTopicRows.ChatTopicRowsIdx is Modified



##### SuperOffice.CRM.Rows.ChatTopicRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ChatTopicRows.IdxLanguageId is Modified



#### SuperOffice.CRM.Rows.ChatTopicUserRecordData is Modified


#### SuperOffice.CRM.Rows.ChatTopicUserRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ChatTopicUserRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ChatTopicUserRow.ChatTopicUserRowIdx is Modified



##### SuperOffice.CRM.Rows.ChatTopicUserRow.ChatTopicUserRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ChatTopicUserRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ChatTopicUserRow.IdxChatTopicUserId is Modified



#### SuperOffice.CRM.Rows.ChatTopicUserRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ChatTopicUserRows.ChatTopicUserRowsIdx is Modified



##### SuperOffice.CRM.Rows.ChatTopicUserRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ChatTopicUserRows.IdxTopicId is Modified



##### SuperOffice.CRM.Rows.ChatTopicUserRows.IdxUserId is Modified



#### SuperOffice.CRM.Rows.CompanyDomainRecordData is Modified


#### SuperOffice.CRM.Rows.CompanyDomainRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CompanyDomainRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CompanyDomainRow.CompanyDomainRowIdx is Modified



##### SuperOffice.CRM.Rows.CompanyDomainRow.CompanyDomainRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CompanyDomainRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CompanyDomainRow.IdxCompanyDomainId is Modified



#### SuperOffice.CRM.Rows.CompanyDomainRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CompanyDomainRows.CompanyDomainRowsIdx is Modified



##### SuperOffice.CRM.Rows.CompanyDomainRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CompanyDomainRows.IdxCompanyId is Modified



#### SuperOffice.CRM.Rows.CompanyRecordData is Modified


#### SuperOffice.CRM.Rows.CompanyRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CompanyRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CompanyRow.CompanyRowIdx is Modified



##### SuperOffice.CRM.Rows.CompanyRow.CompanyRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CompanyRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CompanyRow.IdxCompanyId is Modified



#### SuperOffice.CRM.Rows.CompanyRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CompanyRows.CompanyRowsIdx is Modified



##### SuperOffice.CRM.Rows.CompanyRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.ComptrGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ComptrGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ComptrGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ComptrGroupLinkRow.ComptrGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ComptrGroupLinkRow.ComptrGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ComptrGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ComptrGroupLinkRow.IdxComptrgrouplinkId is Modified



#### SuperOffice.CRM.Rows.ComptrGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ComptrGroupLinkRows.ComptrGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.ComptrGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ComptrGroupLinkRows.IdxComptrId is Modified



##### SuperOffice.CRM.Rows.ComptrGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.ComptrHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ComptrHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ComptrHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ComptrHeadingLinkRow.ComptrHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ComptrHeadingLinkRow.ComptrHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ComptrHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ComptrHeadingLinkRow.IdxComptrheadinglinkId is Modified



#### SuperOffice.CRM.Rows.ComptrHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ComptrHeadingLinkRows.ComptrHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.ComptrHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ComptrHeadingLinkRows.IdxComptrId is Modified



##### SuperOffice.CRM.Rows.ComptrHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.ComptrRecordData is Modified


#### SuperOffice.CRM.Rows.ComptrRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ComptrRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ComptrRow.ComptrRowIdx is Modified



##### SuperOffice.CRM.Rows.ComptrRow.ComptrRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ComptrRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ComptrRow.IdxComptrId is Modified



##### SuperOffice.CRM.Rows.ComptrRow.IdxName is Modified



#### SuperOffice.CRM.Rows.ComptrRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ComptrRows.ComptrRowsIdx is Modified



##### SuperOffice.CRM.Rows.ComptrRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.ConfigRecordData is Modified


#### SuperOffice.CRM.Rows.ConfigRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ConfigRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConfigRow.ConfigRowIdx is Modified



##### SuperOffice.CRM.Rows.ConfigRow.ConfigRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ConfigRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ConfigRow.IdxConfigId is Modified



#### SuperOffice.CRM.Rows.ConfigRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConfigRows.ConfigRowsIdx is Modified



##### SuperOffice.CRM.Rows.ConfigRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRecordData is Modified


#### SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRow.ConfigurableScreenAppliesToRowIdx is Modified



##### SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRow.ConfigurableScreenAppliesToRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRow.IdxConfigurableScreenAppliesToId is Modified



#### SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRows.ConfigurableScreenAppliesToRowsIdx is Modified



##### SuperOffice.CRM.Rows.ConfigurableScreenAppliesToRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.ConfigurableScreenDeltaRecordData is Modified


#### SuperOffice.CRM.Rows.ConfigurableScreenDeltaRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ConfigurableScreenDeltaRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConfigurableScreenDeltaRow.ConfigurableScreenDeltaRowIdx is Modified



##### SuperOffice.CRM.Rows.ConfigurableScreenDeltaRow.ConfigurableScreenDeltaRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ConfigurableScreenDeltaRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ConfigurableScreenDeltaRow.IdxConfigurableScreenDeltaId is Modified



#### SuperOffice.CRM.Rows.ConfigurableScreenDeltaRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConfigurableScreenDeltaRows.ConfigurableScreenDeltaRowsIdx is Modified



##### SuperOffice.CRM.Rows.ConfigurableScreenDeltaRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ConfigurableScreenDeltaRows.IdxRecipeId is Modified



#### SuperOffice.CRM.Rows.ConnectionConfigFieldRecordData is Modified


#### SuperOffice.CRM.Rows.ConnectionConfigFieldRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ConnectionConfigFieldRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConnectionConfigFieldRow.ConnectionConfigFieldRowIdx is Modified



##### SuperOffice.CRM.Rows.ConnectionConfigFieldRow.ConnectionConfigFieldRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ConnectionConfigFieldRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ConnectionConfigFieldRow.IdxConnectionConfigFieldId is Modified



#### SuperOffice.CRM.Rows.ConnectionConfigFieldRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConnectionConfigFieldRows.ConnectionConfigFieldRowsIdx is Modified



##### SuperOffice.CRM.Rows.ConnectionConfigFieldRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ConnectionConfigFieldRows.IdxErpConnectionId is Modified



##### SuperOffice.CRM.Rows.ConnectionConfigFieldRows.IdxQuoteConnectionId is Modified



#### SuperOffice.CRM.Rows.ConsentPersonRecordData is Modified


#### SuperOffice.CRM.Rows.ConsentPersonRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ConsentPersonRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConsentPersonRow.ConsentPersonRowIdx is Modified



##### SuperOffice.CRM.Rows.ConsentPersonRow.ConsentPersonRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ConsentPersonRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ConsentPersonRow.IdxConsentPersonId is Modified



##### SuperOffice.CRM.Rows.ConsentPersonRow.IdxPersonIdConsentPurposeId is Modified



#### SuperOffice.CRM.Rows.ConsentPersonRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConsentPersonRows.ConsentPersonRowsIdx is Modified



##### SuperOffice.CRM.Rows.ConsentPersonRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ConsentPersonRows.IdxConsentSourceId is Modified



##### SuperOffice.CRM.Rows.ConsentPersonRows.IdxLegalBaseId is Modified



##### SuperOffice.CRM.Rows.ConsentPersonRows.IdxPersonId is Modified



#### SuperOffice.CRM.Rows.ConsentPurposeRecordData is Modified


#### SuperOffice.CRM.Rows.ConsentPurposeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ConsentPurposeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConsentPurposeRow.ConsentPurposeRowIdx is Modified



##### SuperOffice.CRM.Rows.ConsentPurposeRow.ConsentPurposeRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ConsentPurposeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ConsentPurposeRow.IdxConsentPurposeId is Modified



##### SuperOffice.CRM.Rows.ConsentPurposeRow.IdxKey is Modified



##### SuperOffice.CRM.Rows.ConsentPurposeRow.IdxName is Modified



#### SuperOffice.CRM.Rows.ConsentPurposeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConsentPurposeRows.ConsentPurposeRowsIdx is Modified



##### SuperOffice.CRM.Rows.ConsentPurposeRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.ConsentSourceRecordData is Modified


#### SuperOffice.CRM.Rows.ConsentSourceRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ConsentSourceRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConsentSourceRow.ConsentSourceRowIdx is Modified



##### SuperOffice.CRM.Rows.ConsentSourceRow.ConsentSourceRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ConsentSourceRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ConsentSourceRow.IdxConsentSourceId is Modified



##### SuperOffice.CRM.Rows.ConsentSourceRow.IdxKey is Modified



#### SuperOffice.CRM.Rows.ConsentSourceRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ConsentSourceRows.ConsentSourceRowsIdx is Modified



##### SuperOffice.CRM.Rows.ConsentSourceRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.ContactInterestRecordData is Modified


#### SuperOffice.CRM.Rows.ContactInterestRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ContactInterestRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ContactInterestRow.ContactInterestRowIdx is Modified



##### SuperOffice.CRM.Rows.ContactInterestRow.ContactInterestRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ContactInterestRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ContactInterestRow.IdxContactIdCinterestIdx is Modified



##### SuperOffice.CRM.Rows.ContactInterestRow.IdxContactinterestId is Modified



#### SuperOffice.CRM.Rows.ContactInterestRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ContactInterestRows.ContactInterestRowsIdx is Modified



##### SuperOffice.CRM.Rows.ContactInterestRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ContactInterestRows.IdxCinterestIdx is Modified



##### SuperOffice.CRM.Rows.ContactInterestRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.ContactInterestRows.IdxEndDate is Modified



##### SuperOffice.CRM.Rows.ContactInterestRows.IdxStartDate is Modified



#### SuperOffice.CRM.Rows.ContactRecordData is Modified


#### SuperOffice.CRM.Rows.ContactRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ContactRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ContactRow.ContactRowIdx is Modified



##### SuperOffice.CRM.Rows.ContactRow.ContactRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ContactRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ContactRow.IdxContactId is Modified



#### SuperOffice.CRM.Rows.ContactRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ContactRows.ContactRowsIdx is Modified



##### SuperOffice.CRM.Rows.ContactRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxBusinessIdx is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxCategoryIdx is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxDbiAgentId is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxDbiKey is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxDbiLastModified is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxDbiLastSyncronized is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxDeletedDate is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxDepartment is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxKananame is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxMotherId is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxName is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxNameDepartment is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxNumber1 is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxNumber2 is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxOrgNr is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxSoundEx is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxSource is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxSupportPersonId is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxUserdef2Id is Modified



##### SuperOffice.CRM.Rows.ContactRows.IdxUserdefId is Modified



#### SuperOffice.CRM.Rows.ContIntGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ContIntGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ContIntGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ContIntGroupLinkRow.ContIntGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ContIntGroupLinkRow.ContIntGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ContIntGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ContIntGroupLinkRow.IdxContintgrouplinkId is Modified



#### SuperOffice.CRM.Rows.ContIntGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ContIntGroupLinkRows.ContIntGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.ContIntGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ContIntGroupLinkRows.IdxContIntId is Modified



##### SuperOffice.CRM.Rows.ContIntGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.ContIntHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ContIntHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ContIntHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ContIntHeadingLinkRow.ContIntHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ContIntHeadingLinkRow.ContIntHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ContIntHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ContIntHeadingLinkRow.IdxContintheadinglinkId is Modified



#### SuperOffice.CRM.Rows.ContIntHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ContIntHeadingLinkRows.ContIntHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.ContIntHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ContIntHeadingLinkRows.IdxContIntId is Modified



##### SuperOffice.CRM.Rows.ContIntHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.ContIntRecordData is Modified


#### SuperOffice.CRM.Rows.ContIntRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ContIntRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ContIntRow.ContIntRowIdx is Modified



##### SuperOffice.CRM.Rows.ContIntRow.ContIntRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ContIntRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ContIntRow.IdxContIntId is Modified



##### SuperOffice.CRM.Rows.ContIntRow.IdxName is Modified



#### SuperOffice.CRM.Rows.ContIntRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ContIntRows.ContIntRowsIdx is Modified



##### SuperOffice.CRM.Rows.ContIntRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.CounterValueBulkImportFacade is Modified


#### SuperOffice.CRM.Rows.CounterValueRecordData is Modified


#### SuperOffice.CRM.Rows.CounterValueRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CounterValueRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CounterValueRow.CounterValueRowIdx is Modified



##### SuperOffice.CRM.Rows.CounterValueRow.CounterValueRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CounterValueRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CounterValueRow.IdxCounterValueId is Modified



#### SuperOffice.CRM.Rows.CounterValueRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CounterValueRows.CounterValueRowsIdx is Modified



##### SuperOffice.CRM.Rows.CounterValueRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CounterValueRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.CounterValueRows.IdxContactIdRecordType is Modified



##### SuperOffice.CRM.Rows.CounterValueRows.IdxContactIdSaleStatus is Modified



##### SuperOffice.CRM.Rows.CounterValueRows.IdxProjectId is Modified



##### SuperOffice.CRM.Rows.CounterValueRows.IdxProjectIdRecordType is Modified



##### SuperOffice.CRM.Rows.CounterValueRows.IdxProjectIdSaleStatus is Modified



##### SuperOffice.CRM.Rows.CounterValueRows.IdxRecordType is Modified



##### SuperOffice.CRM.Rows.CounterValueRows.IdxRecordTypeDirection is Modified



##### SuperOffice.CRM.Rows.CounterValueRows.IdxRecordTypeDirectionIntentId is Modified



##### SuperOffice.CRM.Rows.CounterValueRows.IdxSaleStatus is Modified



##### SuperOffice.CRM.Rows.CounterValueRows.IdxSaleStatusAmountClassId is Modified



#### SuperOffice.CRM.Rows.CountryGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.CountryGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CountryGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CountryGroupLinkRow.CountryGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.CountryGroupLinkRow.CountryGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CountryGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CountryGroupLinkRow.IdxCountrygrouplinkId is Modified



#### SuperOffice.CRM.Rows.CountryGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CountryGroupLinkRows.CountryGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.CountryGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CountryGroupLinkRows.IdxCountryId is Modified



##### SuperOffice.CRM.Rows.CountryGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.CountryHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.CountryHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CountryHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CountryHeadingLinkRow.CountryHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.CountryHeadingLinkRow.CountryHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CountryHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CountryHeadingLinkRow.IdxCountryheadinglinkId is Modified



#### SuperOffice.CRM.Rows.CountryHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CountryHeadingLinkRows.CountryHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.CountryHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CountryHeadingLinkRows.IdxCountryId is Modified



##### SuperOffice.CRM.Rows.CountryHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.CountryRecordData is Modified


#### SuperOffice.CRM.Rows.CountryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CountryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CountryRow.CountryRowIdx is Modified



##### SuperOffice.CRM.Rows.CountryRow.CountryRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CountryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CountryRow.IdxCountryId is Modified



##### SuperOffice.CRM.Rows.CountryRow.IdxName is Modified



#### SuperOffice.CRM.Rows.CountryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CountryRows.CountryRowsIdx is Modified



##### SuperOffice.CRM.Rows.CountryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CountryRows.IdxEnglishName is Modified



#### SuperOffice.CRM.Rows.CredentialsRecordData is Modified


#### SuperOffice.CRM.Rows.CredentialsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CredentialsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CredentialsRow.CredentialsRowIdx is Modified



##### SuperOffice.CRM.Rows.CredentialsRow.CredentialsRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CredentialsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CredentialsRow.IdxCredentialsId is Modified



##### SuperOffice.CRM.Rows.CredentialsRow.IdxCredentialTypeSearchName is Modified



#### SuperOffice.CRM.Rows.CredentialsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CredentialsRows.CredentialsRowsIdx is Modified



##### SuperOffice.CRM.Rows.CredentialsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CredentialsRows.IdxCredentialType is Modified



##### SuperOffice.CRM.Rows.CredentialsRows.IdxCredentialTypeIsActive is Modified



##### SuperOffice.CRM.Rows.CredentialsRows.IdxCredentialTypePersonId is Modified



##### SuperOffice.CRM.Rows.CredentialsRows.IdxSearchName is Modified



#### SuperOffice.CRM.Rows.CreditedGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.CreditedGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CreditedGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CreditedGroupLinkRow.CreditedGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.CreditedGroupLinkRow.CreditedGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CreditedGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CreditedGroupLinkRow.IdxCreditedgrouplinkId is Modified



#### SuperOffice.CRM.Rows.CreditedGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CreditedGroupLinkRows.CreditedGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.CreditedGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CreditedGroupLinkRows.IdxCreditedId is Modified



##### SuperOffice.CRM.Rows.CreditedGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.CreditedHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.CreditedHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CreditedHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CreditedHeadingLinkRow.CreditedHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.CreditedHeadingLinkRow.CreditedHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CreditedHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CreditedHeadingLinkRow.IdxCreditedheadinglinkId is Modified



#### SuperOffice.CRM.Rows.CreditedHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CreditedHeadingLinkRows.CreditedHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.CreditedHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CreditedHeadingLinkRows.IdxCreditedId is Modified



##### SuperOffice.CRM.Rows.CreditedHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.CreditedRecordData is Modified


#### SuperOffice.CRM.Rows.CreditedRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CreditedRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CreditedRow.CreditedRowIdx is Modified



##### SuperOffice.CRM.Rows.CreditedRow.CreditedRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CreditedRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CreditedRow.IdxCreditedId is Modified



##### SuperOffice.CRM.Rows.CreditedRow.IdxName is Modified



#### SuperOffice.CRM.Rows.CreditedRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CreditedRows.CreditedRowsIdx is Modified



##### SuperOffice.CRM.Rows.CreditedRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.CurrencyGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.CurrencyGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CurrencyGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CurrencyGroupLinkRow.CurrencyGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.CurrencyGroupLinkRow.CurrencyGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CurrencyGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CurrencyGroupLinkRow.IdxCurrencygrouplinkId is Modified



#### SuperOffice.CRM.Rows.CurrencyGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CurrencyGroupLinkRows.CurrencyGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.CurrencyGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CurrencyGroupLinkRows.IdxCurrencyId is Modified



##### SuperOffice.CRM.Rows.CurrencyGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.CurrencyHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.CurrencyHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CurrencyHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CurrencyHeadingLinkRow.CurrencyHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.CurrencyHeadingLinkRow.CurrencyHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CurrencyHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CurrencyHeadingLinkRow.IdxCurrencyheadinglinkId is Modified



#### SuperOffice.CRM.Rows.CurrencyHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CurrencyHeadingLinkRows.CurrencyHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.CurrencyHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CurrencyHeadingLinkRows.IdxCurrencyId is Modified



##### SuperOffice.CRM.Rows.CurrencyHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.CurrencyRecordData is Modified


#### SuperOffice.CRM.Rows.CurrencyRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CurrencyRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CurrencyRow.CurrencyRowIdx is Modified



##### SuperOffice.CRM.Rows.CurrencyRow.CurrencyRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CurrencyRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CurrencyRow.IdxCurrencyId is Modified



##### SuperOffice.CRM.Rows.CurrencyRow.IdxName is Modified



#### SuperOffice.CRM.Rows.CurrencyRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CurrencyRows.CurrencyRowsIdx is Modified



##### SuperOffice.CRM.Rows.CurrencyRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.CustCategoryRecordData is Modified


#### SuperOffice.CRM.Rows.CustCategoryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CustCategoryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CustCategoryRow.CustCategoryRowIdx is Modified



##### SuperOffice.CRM.Rows.CustCategoryRow.CustCategoryRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CustCategoryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CustCategoryRow.IdxCustCategoryId is Modified



#### SuperOffice.CRM.Rows.CustCategoryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CustCategoryRows.CustCategoryRowsIdx is Modified



##### SuperOffice.CRM.Rows.CustCategoryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CustCategoryRows.IdxCategoryId is Modified



##### SuperOffice.CRM.Rows.CustCategoryRows.IdxLanguageId is Modified



##### SuperOffice.CRM.Rows.CustCategoryRows.IdxParentId is Modified



#### SuperOffice.CRM.Rows.CustConfigRecordData is Modified


#### SuperOffice.CRM.Rows.CustConfigRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CustConfigRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CustConfigRow.CustConfigRowIdx is Modified



##### SuperOffice.CRM.Rows.CustConfigRow.CustConfigRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CustConfigRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CustConfigRow.IdxCustConfigId is Modified



#### SuperOffice.CRM.Rows.CustConfigRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CustConfigRows.CustConfigRowsIdx is Modified



##### SuperOffice.CRM.Rows.CustConfigRows.CustomSearch is Modified



#### SuperOffice.CRM.Rows.CustLangRecordData is Modified


#### SuperOffice.CRM.Rows.CustLangRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.CustLangRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.CustLangRow.CustLangRowIdx is Modified



##### SuperOffice.CRM.Rows.CustLangRow.CustLangRowIdxBase is Modified



##### SuperOffice.CRM.Rows.CustLangRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CustLangRow.IdxCustLangId is Modified



#### SuperOffice.CRM.Rows.CustLangRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.CustLangRows.CustLangRowsIdx is Modified



##### SuperOffice.CRM.Rows.CustLangRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.CustLangRows.IdxKbRoot is Modified



#### SuperOffice.CRM.Rows.DashboardRecordData is Modified


#### SuperOffice.CRM.Rows.DashboardRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DashboardRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DashboardRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DashboardRow.DashboardRowIdx is Modified



##### SuperOffice.CRM.Rows.DashboardRow.DashboardRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DashboardRow.IdxDashboardId is Modified



#### SuperOffice.CRM.Rows.DashboardRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DashboardRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DashboardRows.DashboardRowsIdx is Modified



##### SuperOffice.CRM.Rows.DashboardRows.IdxAssociateId is Modified



#### SuperOffice.CRM.Rows.DashboardThemeRecordData is Modified


#### SuperOffice.CRM.Rows.DashboardThemeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DashboardThemeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DashboardThemeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DashboardThemeRow.DashboardThemeRowIdx is Modified



##### SuperOffice.CRM.Rows.DashboardThemeRow.DashboardThemeRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DashboardThemeRow.IdxDashboardThemeId is Modified



#### SuperOffice.CRM.Rows.DashboardThemeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DashboardThemeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DashboardThemeRows.DashboardThemeRowsIdx is Modified



#### SuperOffice.CRM.Rows.DashboardTileDefinitionRecordData is Modified


#### SuperOffice.CRM.Rows.DashboardTileDefinitionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DashboardTileDefinitionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DashboardTileDefinitionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DashboardTileDefinitionRow.DashboardTileDefinitionRowIdx is Modified



##### SuperOffice.CRM.Rows.DashboardTileDefinitionRow.DashboardTileDefinitionRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DashboardTileDefinitionRow.IdxDashboardTileDefinitionId is Modified



#### SuperOffice.CRM.Rows.DashboardTileDefinitionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DashboardTileDefinitionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DashboardTileDefinitionRows.DashboardTileDefinitionRowsIdx is Modified



##### SuperOffice.CRM.Rows.DashboardTileDefinitionRows.IdxEntityType is Modified



#### SuperOffice.CRM.Rows.DashboardTileFieldRecordData is Modified


#### SuperOffice.CRM.Rows.DashboardTileFieldRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DashboardTileFieldRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DashboardTileFieldRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DashboardTileFieldRow.DashboardTileFieldRowIdx is Modified



##### SuperOffice.CRM.Rows.DashboardTileFieldRow.DashboardTileFieldRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DashboardTileFieldRow.IdxDashboardTileFieldId is Modified



#### SuperOffice.CRM.Rows.DashboardTileFieldRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DashboardTileFieldRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DashboardTileFieldRows.DashboardTileFieldRowsIdx is Modified



##### SuperOffice.CRM.Rows.DashboardTileFieldRows.IdxDashboardTileDefinitionId is Modified



#### SuperOffice.CRM.Rows.DashboardTileRecordData is Modified


#### SuperOffice.CRM.Rows.DashboardTileRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DashboardTileRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DashboardTileRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DashboardTileRow.DashboardTileRowIdx is Modified



##### SuperOffice.CRM.Rows.DashboardTileRow.DashboardTileRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DashboardTileRow.IdxDashboardTileId is Modified



#### SuperOffice.CRM.Rows.DashboardTileRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DashboardTileRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DashboardTileRows.DashboardTileRowsIdx is Modified



##### SuperOffice.CRM.Rows.DashboardTileRows.IdxDashboardId is Modified



#### SuperOffice.CRM.Rows.DatabaseModelRecordData is Modified


#### SuperOffice.CRM.Rows.DatabaseModelRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DatabaseModelRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DatabaseModelRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DatabaseModelRow.DatabaseModelRowIdx is Modified



##### SuperOffice.CRM.Rows.DatabaseModelRow.DatabaseModelRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DatabaseModelRow.IdxDatabaseModelId is Modified



#### SuperOffice.CRM.Rows.DatabaseModelRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DatabaseModelRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DatabaseModelRows.DatabaseModelRowsIdx is Modified



#### SuperOffice.CRM.Rows.DataRightRecordData is Modified


#### SuperOffice.CRM.Rows.DataRightRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DataRightRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DataRightRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DataRightRow.DataRightRowIdx is Modified



##### SuperOffice.CRM.Rows.DataRightRow.DataRightRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DataRightRow.IdxDataRightId is Modified



##### SuperOffice.CRM.Rows.DataRightRow.IdxRoleIdTableIdFieldIdRelationToOwner is Modified



#### SuperOffice.CRM.Rows.DataRightRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DataRightRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DataRightRows.DataRightRowsIdx is Modified



##### SuperOffice.CRM.Rows.DataRightRows.IdxRoleId is Modified



##### SuperOffice.CRM.Rows.DataRightRows.IdxRoleIdTableId is Modified



##### SuperOffice.CRM.Rows.DataRightRows.IdxRoleIdTableIdFieldId is Modified



#### SuperOffice.CRM.Rows.DbiAgentFieldRecordData is Modified


#### SuperOffice.CRM.Rows.DbiAgentFieldRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DbiAgentFieldRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DbiAgentFieldRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DbiAgentFieldRow.DbiAgentFieldRowIdx is Modified



##### SuperOffice.CRM.Rows.DbiAgentFieldRow.DbiAgentFieldRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DbiAgentFieldRow.IdxDbiAgentFieldId is Modified



#### SuperOffice.CRM.Rows.DbiAgentFieldRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DbiAgentFieldRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DbiAgentFieldRows.DbiAgentFieldRowsIdx is Modified



##### SuperOffice.CRM.Rows.DbiAgentFieldRows.IdxAgentId is Modified



#### SuperOffice.CRM.Rows.DbiAgentRecordData is Modified


#### SuperOffice.CRM.Rows.DbiAgentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DbiAgentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DbiAgentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DbiAgentRow.DbiAgentRowIdx is Modified



##### SuperOffice.CRM.Rows.DbiAgentRow.DbiAgentRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DbiAgentRow.IdxDbiAgentId is Modified



#### SuperOffice.CRM.Rows.DbiAgentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DbiAgentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DbiAgentRows.DbiAgentRowsIdx is Modified



#### SuperOffice.CRM.Rows.DbiAgentScheduleRecordData is Modified


#### SuperOffice.CRM.Rows.DbiAgentScheduleRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DbiAgentScheduleRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DbiAgentScheduleRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DbiAgentScheduleRow.DbiAgentScheduleRowIdx is Modified



##### SuperOffice.CRM.Rows.DbiAgentScheduleRow.DbiAgentScheduleRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DbiAgentScheduleRow.IdxDbiAgentScheduleId is Modified



#### SuperOffice.CRM.Rows.DbiAgentScheduleRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DbiAgentScheduleRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DbiAgentScheduleRows.DbiAgentScheduleRowsIdx is Modified



##### SuperOffice.CRM.Rows.DbiAgentScheduleRows.IdxAgentId is Modified



##### SuperOffice.CRM.Rows.DbiAgentScheduleRows.IdxScheduleId is Modified



##### SuperOffice.CRM.Rows.DbiAgentScheduleRows.IdxScriptId is Modified



#### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRow.DeliveryTermsGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRow.DeliveryTermsGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRow.IdxDeliveryTermsGroupLinkId is Modified



#### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRows.DeliveryTermsGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRows.IdxDeliveryTermsId is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRow.DeliveryTermsHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRow.DeliveryTermsHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRow.IdxDeliveryTermsHeadingLinkId is Modified



#### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRows.DeliveryTermsHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRows.IdxDeliveryTermsId is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.DeliveryTermsRecordData is Modified


#### SuperOffice.CRM.Rows.DeliveryTermsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DeliveryTermsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DeliveryTermsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsRow.DeliveryTermsRowIdx is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsRow.DeliveryTermsRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsRow.IdxDeliveryTermsId is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsRow.IdxName is Modified



#### SuperOffice.CRM.Rows.DeliveryTermsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DeliveryTermsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DeliveryTermsRows.DeliveryTermsRowsIdx is Modified



#### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRow.DeliveryTypeGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRow.DeliveryTypeGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRow.IdxDeliveryTypeGroupLinkId is Modified



#### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRows.DeliveryTypeGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRows.IdxDeliveryTypeId is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRow.DeliveryTypeHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRow.DeliveryTypeHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRow.IdxDeliveryTypeHeadingLinkId is Modified



#### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRows.DeliveryTypeHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRows.IdxDeliveryTypeId is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.DeliveryTypeRecordData is Modified


#### SuperOffice.CRM.Rows.DeliveryTypeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DeliveryTypeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DeliveryTypeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeRow.DeliveryTypeRowIdx is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeRow.DeliveryTypeRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeRow.IdxDeliveryTypeId is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeRow.IdxName is Modified



#### SuperOffice.CRM.Rows.DeliveryTypeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DeliveryTypeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DeliveryTypeRows.DeliveryTypeRowsIdx is Modified



#### SuperOffice.CRM.Rows.DiaryViewRecordData is Modified


#### SuperOffice.CRM.Rows.DiaryViewRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DiaryViewRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DiaryViewRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DiaryViewRow.DiaryViewRowIdx is Modified



##### SuperOffice.CRM.Rows.DiaryViewRow.DiaryViewRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DiaryViewRow.IdxDiaryViewId is Modified



#### SuperOffice.CRM.Rows.DiaryViewRowRecordData is Modified


#### SuperOffice.CRM.Rows.DiaryViewRowRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DiaryViewRowRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DiaryViewRowRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DiaryViewRowRow.DiaryViewRowRowIdx is Modified



##### SuperOffice.CRM.Rows.DiaryViewRowRow.DiaryViewRowRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DiaryViewRowRow.IdxDiaryViewRowId is Modified



#### SuperOffice.CRM.Rows.DiaryViewRowRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DiaryViewRowRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DiaryViewRowRows.DiaryViewRowRowsIdx is Modified



##### SuperOffice.CRM.Rows.DiaryViewRowRows.IdxDiaryViewId is Modified



#### SuperOffice.CRM.Rows.DiaryViewRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DiaryViewRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DiaryViewRows.DiaryViewRowsIdx is Modified



##### SuperOffice.CRM.Rows.DiaryViewRows.IdxAssocId is Modified



#### SuperOffice.CRM.Rows.DictionaryBaseRecordData is Modified


#### SuperOffice.CRM.Rows.DictionaryBaseRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DictionaryBaseRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DictionaryBaseRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DictionaryBaseRow.DictionaryBaseRowIdx is Modified



##### SuperOffice.CRM.Rows.DictionaryBaseRow.DictionaryBaseRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DictionaryBaseRow.IdxDictionaryBaseId is Modified



#### SuperOffice.CRM.Rows.DictionaryBaseRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DictionaryBaseRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DictionaryBaseRows.DictionaryBaseRowsIdx is Modified



#### SuperOffice.CRM.Rows.DictionaryRecordData is Modified


#### SuperOffice.CRM.Rows.DictionaryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DictionaryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DictionaryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DictionaryRow.DictionaryRowIdx is Modified



##### SuperOffice.CRM.Rows.DictionaryRow.DictionaryRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DictionaryRow.IdxDictionaryId is Modified



#### SuperOffice.CRM.Rows.DictionaryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DictionaryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DictionaryRows.DictionaryRowsIdx is Modified



##### SuperOffice.CRM.Rows.DictionaryRows.IdxBaseId is Modified



##### SuperOffice.CRM.Rows.DictionaryRows.IdxInclude is Modified



##### SuperOffice.CRM.Rows.DictionaryRows.IdxUserId is Modified



##### SuperOffice.CRM.Rows.DictionaryRows.IdxWord is Modified



#### SuperOffice.CRM.Rows.DocDocumentRecordData is Modified


#### SuperOffice.CRM.Rows.DocDocumentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DocDocumentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DocDocumentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DocDocumentRow.DocDocumentRowIdx is Modified



##### SuperOffice.CRM.Rows.DocDocumentRow.DocDocumentRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DocDocumentRow.IdxDocDocumentId is Modified



#### SuperOffice.CRM.Rows.DocDocumentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DocDocumentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DocDocumentRows.DocDocumentRowsIdx is Modified



##### SuperOffice.CRM.Rows.DocDocumentRows.IdxAttachmentId is Modified



##### SuperOffice.CRM.Rows.DocDocumentRows.IdxChangedBy is Modified



##### SuperOffice.CRM.Rows.DocDocumentRows.IdxCreatedBy is Modified



##### SuperOffice.CRM.Rows.DocDocumentRows.IdxFolderId is Modified



##### SuperOffice.CRM.Rows.DocDocumentRows.IdxTitle is Modified



#### SuperOffice.CRM.Rows.DocFolderRecordData is Modified


#### SuperOffice.CRM.Rows.DocFolderRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DocFolderRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DocFolderRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DocFolderRow.DocFolderRowIdx is Modified



##### SuperOffice.CRM.Rows.DocFolderRow.DocFolderRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DocFolderRow.IdxDocFolderId is Modified



#### SuperOffice.CRM.Rows.DocFolderRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DocFolderRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DocFolderRows.DocFolderRowsIdx is Modified



##### SuperOffice.CRM.Rows.DocFolderRows.IdxCreatedBy is Modified



##### SuperOffice.CRM.Rows.DocFolderRows.IdxFolderId is Modified



##### SuperOffice.CRM.Rows.DocFolderRows.IdxTitle is Modified



#### SuperOffice.CRM.Rows.DocTmplGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.DocTmplGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DocTmplGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DocTmplGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DocTmplGroupLinkRow.DocTmplGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.DocTmplGroupLinkRow.DocTmplGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DocTmplGroupLinkRow.IdxDoctmplgrouplinkId is Modified



#### SuperOffice.CRM.Rows.DocTmplGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DocTmplGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DocTmplGroupLinkRows.DocTmplGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.DocTmplGroupLinkRows.IdxDocTmplId is Modified



##### SuperOffice.CRM.Rows.DocTmplGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.DocTmplHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.DocTmplHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DocTmplHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DocTmplHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DocTmplHeadingLinkRow.DocTmplHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.DocTmplHeadingLinkRow.DocTmplHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DocTmplHeadingLinkRow.IdxDoctmplheadinglinkId is Modified



#### SuperOffice.CRM.Rows.DocTmplHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DocTmplHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DocTmplHeadingLinkRows.DocTmplHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.DocTmplHeadingLinkRows.IdxDocTmplId is Modified



##### SuperOffice.CRM.Rows.DocTmplHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.DocTmplRecordData is Modified


#### SuperOffice.CRM.Rows.DocTmplRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DocTmplRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DocTmplRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DocTmplRow.DocTmplRowIdx is Modified



##### SuperOffice.CRM.Rows.DocTmplRow.DocTmplRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DocTmplRow.IdxDocTmplId is Modified



##### SuperOffice.CRM.Rows.DocTmplRow.IdxName is Modified



#### SuperOffice.CRM.Rows.DocTmplRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DocTmplRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DocTmplRows.DocTmplRowsIdx is Modified



#### SuperOffice.CRM.Rows.DocumentRecordData is Modified


#### SuperOffice.CRM.Rows.DocumentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.DocumentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.DocumentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DocumentRow.DocumentRowIdx is Modified



##### SuperOffice.CRM.Rows.DocumentRow.DocumentRowIdxBase is Modified



##### SuperOffice.CRM.Rows.DocumentRow.IdxDocumentId is Modified



#### SuperOffice.CRM.Rows.DocumentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.DocumentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.DocumentRows.DocumentRowsIdx is Modified



##### SuperOffice.CRM.Rows.DocumentRows.IdxArchiveProvider is Modified



##### SuperOffice.CRM.Rows.DocumentRows.IdxExtref is Modified



##### SuperOffice.CRM.Rows.DocumentRows.IdxHeader is Modified



##### SuperOffice.CRM.Rows.DocumentRows.IdxOurRef is Modified



##### SuperOffice.CRM.Rows.DocumentRows.IdxSearchname is Modified



##### SuperOffice.CRM.Rows.DocumentRows.IdxUserdef2Id is Modified



##### SuperOffice.CRM.Rows.DocumentRows.IdxUserdefId is Modified



#### SuperOffice.CRM.Rows.EabEntryRecordData is Modified


#### SuperOffice.CRM.Rows.EabEntryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EabEntryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EabEntryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EabEntryRow.EabEntryRowIdx is Modified



##### SuperOffice.CRM.Rows.EabEntryRow.EabEntryRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EabEntryRow.IdxEabEntryId is Modified



#### SuperOffice.CRM.Rows.EabEntryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EabEntryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EabEntryRows.EabEntryRowsIdx is Modified



##### SuperOffice.CRM.Rows.EabEntryRows.IdxDbiAgentId is Modified



##### SuperOffice.CRM.Rows.EabEntryRows.IdxDbiKey is Modified



##### SuperOffice.CRM.Rows.EabEntryRows.IdxDbiLastModified is Modified



##### SuperOffice.CRM.Rows.EabEntryRows.IdxDbiLastSyncronized is Modified



##### SuperOffice.CRM.Rows.EabEntryRows.IdxFolderId is Modified



##### SuperOffice.CRM.Rows.EabEntryRows.IdxName is Modified



#### SuperOffice.CRM.Rows.EabFolderRecordData is Modified


#### SuperOffice.CRM.Rows.EabFolderRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EabFolderRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EabFolderRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EabFolderRow.EabFolderRowIdx is Modified



##### SuperOffice.CRM.Rows.EabFolderRow.EabFolderRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EabFolderRow.IdxEabFolderId is Modified



#### SuperOffice.CRM.Rows.EabFolderRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EabFolderRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EabFolderRows.EabFolderRowsIdx is Modified



##### SuperOffice.CRM.Rows.EabFolderRows.IdxFolderId is Modified



##### SuperOffice.CRM.Rows.EabFolderRows.IdxName is Modified



#### SuperOffice.CRM.Rows.EjCategoryGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.EjCategoryGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjCategoryGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjCategoryGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjCategoryGroupLinkRow.EjCategoryGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.EjCategoryGroupLinkRow.EjCategoryGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjCategoryGroupLinkRow.IdxEjCategorygrouplinkId is Modified



#### SuperOffice.CRM.Rows.EjCategoryGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjCategoryGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjCategoryGroupLinkRows.EjCategoryGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.EjCategoryGroupLinkRows.IdxEjCategoryId is Modified



##### SuperOffice.CRM.Rows.EjCategoryGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.EjCategoryRecordData is Modified


#### SuperOffice.CRM.Rows.EjCategoryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjCategoryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjCategoryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjCategoryRow.EjCategoryRowIdx is Modified



##### SuperOffice.CRM.Rows.EjCategoryRow.EjCategoryRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjCategoryRow.IdxEjCategoryId is Modified



#### SuperOffice.CRM.Rows.EjCategoryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjCategoryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjCategoryRows.EjCategoryRowsIdx is Modified



##### SuperOffice.CRM.Rows.EjCategoryRows.IdxCategoryMaster is Modified



##### SuperOffice.CRM.Rows.EjCategoryRows.IdxParentId is Modified



##### SuperOffice.CRM.Rows.EjCategoryRows.IdxReplyTemplate is Modified



#### SuperOffice.CRM.Rows.EjMessageRecordData is Modified


#### SuperOffice.CRM.Rows.EjMessageRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjMessageRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjMessageRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjMessageRow.EjMessageRowIdx is Modified



##### SuperOffice.CRM.Rows.EjMessageRow.EjMessageRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjMessageRow.IdxEjMessageId is Modified



#### SuperOffice.CRM.Rows.EjMessageRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjMessageRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjMessageRows.EjMessageRowsIdx is Modified



##### SuperOffice.CRM.Rows.EjMessageRows.IdxBodyAttachment is Modified



##### SuperOffice.CRM.Rows.EjMessageRows.IdxCreatedAt is Modified



##### SuperOffice.CRM.Rows.EjMessageRows.IdxCreatedBy is Modified



##### SuperOffice.CRM.Rows.EjMessageRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.EjMessageRows.IdxHtmlBodyAttachment is Modified



##### SuperOffice.CRM.Rows.EjMessageRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.EjMessageRows.IdxSearchTitle is Modified



##### SuperOffice.CRM.Rows.EjMessageRows.IdxSearchTitleBody is Modified



##### SuperOffice.CRM.Rows.EjMessageRows.IdxSearchTitleBodyHtmlBody is Modified



##### SuperOffice.CRM.Rows.EjMessageRows.IdxTicketId is Modified



#### SuperOffice.CRM.Rows.EjpackageItemRecordData is Modified


#### SuperOffice.CRM.Rows.EjpackageItemRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjpackageItemRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjpackageItemRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjpackageItemRow.EjpackageItemRowIdx is Modified



##### SuperOffice.CRM.Rows.EjpackageItemRow.EjpackageItemRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjpackageItemRow.IdxEjpackageItemId is Modified



#### SuperOffice.CRM.Rows.EjpackageItemRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjpackageItemRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjpackageItemRows.EjpackageItemRowsIdx is Modified



##### SuperOffice.CRM.Rows.EjpackageItemRows.IdxDomain is Modified



##### SuperOffice.CRM.Rows.EjpackageItemRows.IdxEjpackage is Modified



##### SuperOffice.CRM.Rows.EjpackageItemRows.IdxItemId is Modified



##### SuperOffice.CRM.Rows.EjpackageItemRows.IdxParentId is Modified



#### SuperOffice.CRM.Rows.EjpackageRecordData is Modified


#### SuperOffice.CRM.Rows.EjpackageRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjpackageRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjpackageRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjpackageRow.EjpackageRowIdx is Modified



##### SuperOffice.CRM.Rows.EjpackageRow.EjpackageRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjpackageRow.IdxEjpackageId is Modified



#### SuperOffice.CRM.Rows.EjpackageRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjpackageRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjpackageRows.EjpackageRowsIdx is Modified



##### SuperOffice.CRM.Rows.EjpackageRows.IdxAttachmentId is Modified



##### SuperOffice.CRM.Rows.EjpackageRows.IdxUploadedBy is Modified



#### SuperOffice.CRM.Rows.EjRoleRecordData is Modified


#### SuperOffice.CRM.Rows.EjRoleRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjRoleRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjRoleRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjRoleRow.EjRoleRowIdx is Modified



##### SuperOffice.CRM.Rows.EjRoleRow.EjRoleRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjRoleRow.IdxEjRoleId is Modified



#### SuperOffice.CRM.Rows.EjRoleRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjRoleRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjRoleRows.EjRoleRowsIdx is Modified



##### SuperOffice.CRM.Rows.EjRoleRows.IdxUserGroup is Modified



#### SuperOffice.CRM.Rows.EjscriptDebugRecordData is Modified


#### SuperOffice.CRM.Rows.EjscriptDebugRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjscriptDebugRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjscriptDebugRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjscriptDebugRow.EjscriptDebugRowIdx is Modified



##### SuperOffice.CRM.Rows.EjscriptDebugRow.EjscriptDebugRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjscriptDebugRow.IdxEjscriptDebugId is Modified



#### SuperOffice.CRM.Rows.EjscriptDebugRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjscriptDebugRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjscriptDebugRows.EjscriptDebugRowsIdx is Modified



#### SuperOffice.CRM.Rows.EjscriptRecordData is Modified


#### SuperOffice.CRM.Rows.EjscriptRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjscriptRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjscriptRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjscriptRow.EjscriptRowIdx is Modified



##### SuperOffice.CRM.Rows.EjscriptRow.EjscriptRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjscriptRow.IdxEjscriptId is Modified



##### SuperOffice.CRM.Rows.EjscriptRow.IdxUniqueIdentifier is Modified



#### SuperOffice.CRM.Rows.EjscriptRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjscriptRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjscriptRows.EjscriptRowsIdx is Modified



##### SuperOffice.CRM.Rows.EjscriptRows.IdxHierarchyId is Modified



##### SuperOffice.CRM.Rows.EjscriptRows.IdxIncludeId is Modified



#### SuperOffice.CRM.Rows.EjselectionRecordData is Modified


#### SuperOffice.CRM.Rows.EjselectionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjselectionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselectionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselectionRow.EjselectionRowIdx is Modified



##### SuperOffice.CRM.Rows.EjselectionRow.EjselectionRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjselectionRow.IdxEjselectionId is Modified



#### SuperOffice.CRM.Rows.EjselectionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselectionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselectionRows.EjselectionRowsIdx is Modified



##### SuperOffice.CRM.Rows.EjselectionRows.IdxCreator is Modified



##### SuperOffice.CRM.Rows.EjselectionRows.IdxHierarchyId is Modified



##### SuperOffice.CRM.Rows.EjselectionRows.IdxIncludeId is Modified



##### SuperOffice.CRM.Rows.EjselectionRows.IdxSourceId is Modified



##### SuperOffice.CRM.Rows.EjselectionRows.IdxSourceType is Modified



#### SuperOffice.CRM.Rows.EjselEjselRecordData is Modified


#### SuperOffice.CRM.Rows.EjselEjselRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjselEjselRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselEjselRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselEjselRow.EjselEjselRowIdx is Modified



##### SuperOffice.CRM.Rows.EjselEjselRow.EjselEjselRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjselEjselRow.IdxEjselEjselId is Modified



#### SuperOffice.CRM.Rows.EjselEjselRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselEjselRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselEjselRows.EjselEjselRowsIdx is Modified



##### SuperOffice.CRM.Rows.EjselEjselRows.IdxChild is Modified



##### SuperOffice.CRM.Rows.EjselEjselRows.IdxOperation is Modified



##### SuperOffice.CRM.Rows.EjselEjselRows.IdxOrderPos is Modified



##### SuperOffice.CRM.Rows.EjselEjselRows.IdxParent is Modified



#### SuperOffice.CRM.Rows.EjselMetaResultRecordData is Modified


#### SuperOffice.CRM.Rows.EjselMetaResultRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjselMetaResultRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselMetaResultRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselMetaResultRow.EjselMetaResultRowIdx is Modified



##### SuperOffice.CRM.Rows.EjselMetaResultRow.EjselMetaResultRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjselMetaResultRow.IdxEjselMetaResultId is Modified



#### SuperOffice.CRM.Rows.EjselMetaResultRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselMetaResultRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselMetaResultRows.EjselMetaResultRowsIdx is Modified



##### SuperOffice.CRM.Rows.EjselMetaResultRows.IdxCreatedAt is Modified



##### SuperOffice.CRM.Rows.EjselMetaResultRows.IdxEjselection is Modified



##### SuperOffice.CRM.Rows.EjselMetaResultRows.IdxOwner is Modified



#### SuperOffice.CRM.Rows.EjselResultSetRecordData is Modified


#### SuperOffice.CRM.Rows.EjselResultSetRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjselResultSetRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselResultSetRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselResultSetRow.EjselResultSetRowIdx is Modified



##### SuperOffice.CRM.Rows.EjselResultSetRow.EjselResultSetRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjselResultSetRow.IdxEjselResultSetId is Modified



#### SuperOffice.CRM.Rows.EjselResultSetRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselResultSetRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselResultSetRows.EjselResultSetRowsIdx is Modified



##### SuperOffice.CRM.Rows.EjselResultSetRows.IdxMetaResult is Modified



##### SuperOffice.CRM.Rows.EjselResultSetRows.IdxRefId is Modified



#### SuperOffice.CRM.Rows.EjselSourceIdlistRecordData is Modified


#### SuperOffice.CRM.Rows.EjselSourceIdlistRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjselSourceIdlistRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselSourceIdlistRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselSourceIdlistRow.EjselSourceIdlistRowIdx is Modified



##### SuperOffice.CRM.Rows.EjselSourceIdlistRow.EjselSourceIdlistRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjselSourceIdlistRow.IdxEjselSourceIdlistId is Modified



#### SuperOffice.CRM.Rows.EjselSourceIdlistRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselSourceIdlistRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselSourceIdlistRows.EjselSourceIdlistRowsIdx is Modified



#### SuperOffice.CRM.Rows.EjselSourceScriptRecordData is Modified


#### SuperOffice.CRM.Rows.EjselSourceScriptRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjselSourceScriptRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselSourceScriptRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselSourceScriptRow.EjselSourceScriptRowIdx is Modified



##### SuperOffice.CRM.Rows.EjselSourceScriptRow.EjselSourceScriptRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjselSourceScriptRow.IdxEjselSourceScriptId is Modified



#### SuperOffice.CRM.Rows.EjselSourceScriptRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselSourceScriptRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselSourceScriptRows.EjselSourceScriptRowsIdx is Modified



#### SuperOffice.CRM.Rows.EjselSourceXmlRecordData is Modified


#### SuperOffice.CRM.Rows.EjselSourceXmlRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjselSourceXmlRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselSourceXmlRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselSourceXmlRow.EjselSourceXmlRowIdx is Modified



##### SuperOffice.CRM.Rows.EjselSourceXmlRow.EjselSourceXmlRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjselSourceXmlRow.IdxEjselSourceXmlId is Modified



#### SuperOffice.CRM.Rows.EjselSourceXmlRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjselSourceXmlRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjselSourceXmlRows.EjselSourceXmlRowsIdx is Modified



#### SuperOffice.CRM.Rows.EjuserRecordData is Modified


#### SuperOffice.CRM.Rows.EjuserRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EjuserRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjuserRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjuserRow.EjuserRowIdx is Modified



##### SuperOffice.CRM.Rows.EjuserRow.EjuserRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EjuserRow.IdxEjuserId is Modified



#### SuperOffice.CRM.Rows.EjuserRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EjuserRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EjuserRows.EjuserRowsIdx is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxDbiAgentId is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxDbiKey is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxDbiLastModified is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxDbiLastSyncronized is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxDefaultCategory is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxDefaultStatusAddMessage is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxDefaultStatusNewTicket is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxEmail is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxLastCategory is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxLoginname is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxPictureId is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxProfileId is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxUsergroup is Modified



##### SuperOffice.CRM.Rows.EjuserRows.IdxUsername is Modified



#### SuperOffice.CRM.Rows.ElementProfileRecordData is Modified


#### SuperOffice.CRM.Rows.ElementProfileRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ElementProfileRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ElementProfileRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ElementProfileRow.ElementProfileRowIdx is Modified



##### SuperOffice.CRM.Rows.ElementProfileRow.ElementProfileRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ElementProfileRow.IdxElementProfileId is Modified



#### SuperOffice.CRM.Rows.ElementProfileRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ElementProfileRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ElementProfileRows.ElementProfileRowsIdx is Modified



##### SuperOffice.CRM.Rows.ElementProfileRows.IdxOwnedByUser is Modified



##### SuperOffice.CRM.Rows.ElementProfileRows.IdxScreenDefinitionElement is Modified



#### SuperOffice.CRM.Rows.EmailAccountRecordData is Modified


#### SuperOffice.CRM.Rows.EmailAccountRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EmailAccountRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EmailAccountRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EmailAccountRow.EmailAccountRowIdx is Modified



##### SuperOffice.CRM.Rows.EmailAccountRow.EmailAccountRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EmailAccountRow.IdxEmailAccountId is Modified



##### SuperOffice.CRM.Rows.EmailAccountRow.IdxEmailAddress is Modified



#### SuperOffice.CRM.Rows.EmailAccountRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EmailAccountRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EmailAccountRows.EmailAccountRowsIdx is Modified



##### SuperOffice.CRM.Rows.EmailAccountRows.IdxAssociateId is Modified



#### SuperOffice.CRM.Rows.EmailAttachmentRecordData is Modified


#### SuperOffice.CRM.Rows.EmailAttachmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EmailAttachmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EmailAttachmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EmailAttachmentRow.EmailAttachmentRowIdx is Modified



##### SuperOffice.CRM.Rows.EmailAttachmentRow.EmailAttachmentRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EmailAttachmentRow.IdxEmailAttachmentId is Modified



#### SuperOffice.CRM.Rows.EmailAttachmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EmailAttachmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EmailAttachmentRows.EmailAttachmentRowsIdx is Modified



##### SuperOffice.CRM.Rows.EmailAttachmentRows.IdxEmailItemId is Modified



#### SuperOffice.CRM.Rows.EmailFolderRecordData is Modified


#### SuperOffice.CRM.Rows.EmailFolderRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EmailFolderRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EmailFolderRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EmailFolderRow.EmailFolderRowIdx is Modified



##### SuperOffice.CRM.Rows.EmailFolderRow.EmailFolderRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EmailFolderRow.IdxEmailFolderId is Modified



#### SuperOffice.CRM.Rows.EmailFolderRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EmailFolderRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EmailFolderRows.EmailFolderRowsIdx is Modified



##### SuperOffice.CRM.Rows.EmailFolderRows.IdxAccountId is Modified



#### SuperOffice.CRM.Rows.EmailItemRecordData is Modified


#### SuperOffice.CRM.Rows.EmailItemRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EmailItemRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EmailItemRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EmailItemRow.EmailItemRowIdx is Modified



##### SuperOffice.CRM.Rows.EmailItemRow.EmailItemRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EmailItemRow.IdxEmailItemId is Modified



#### SuperOffice.CRM.Rows.EmailItemRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EmailItemRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EmailItemRows.EmailItemRowsIdx is Modified



##### SuperOffice.CRM.Rows.EmailItemRows.IdxAccountId is Modified



##### SuperOffice.CRM.Rows.EmailItemRows.IdxAccountIdServerId is Modified



##### SuperOffice.CRM.Rows.EmailItemRows.IdxEmailFolderId is Modified



##### SuperOffice.CRM.Rows.EmailItemRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.EmailItemRows.IdxServerId is Modified



#### SuperOffice.CRM.Rows.EmailRecordData is Modified


#### SuperOffice.CRM.Rows.EmailRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.EmailRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.EmailRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EmailRow.EmailRowIdx is Modified



##### SuperOffice.CRM.Rows.EmailRow.EmailRowIdxBase is Modified



##### SuperOffice.CRM.Rows.EmailRow.IdxEmailId is Modified



#### SuperOffice.CRM.Rows.EmailRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.EmailRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.EmailRows.EmailRowsIdx is Modified



##### SuperOffice.CRM.Rows.EmailRows.IdxAppointmentId is Modified



##### SuperOffice.CRM.Rows.EmailRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.EmailRows.IdxDbiAgentId is Modified



##### SuperOffice.CRM.Rows.EmailRows.IdxEmailAddress is Modified



##### SuperOffice.CRM.Rows.EmailRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.EmailRows.IdxProjectId is Modified



##### SuperOffice.CRM.Rows.EmailRows.IdxProtocol is Modified



##### SuperOffice.CRM.Rows.EmailRows.IdxRank is Modified



##### SuperOffice.CRM.Rows.EmailRows.IdxReservedId1 is Modified



##### SuperOffice.CRM.Rows.EmailRows.IdxReservedId2 is Modified



#### SuperOffice.CRM.Rows.ErpConfigurationRecordData is Modified


#### SuperOffice.CRM.Rows.ErpConfigurationRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ErpConfigurationRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpConfigurationRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpConfigurationRow.ErpConfigurationRowIdx is Modified



##### SuperOffice.CRM.Rows.ErpConfigurationRow.ErpConfigurationRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ErpConfigurationRow.IdxErpConfigurationId is Modified



#### SuperOffice.CRM.Rows.ErpConfigurationRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpConfigurationRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpConfigurationRows.ErpConfigurationRowsIdx is Modified



#### SuperOffice.CRM.Rows.ErpConnectionAccessRecordData is Modified


#### SuperOffice.CRM.Rows.ErpConnectionAccessRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ErpConnectionAccessRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpConnectionAccessRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpConnectionAccessRow.ErpConnectionAccessRowIdx is Modified



##### SuperOffice.CRM.Rows.ErpConnectionAccessRow.ErpConnectionAccessRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ErpConnectionAccessRow.IdxErpConnectionAccessId is Modified



#### SuperOffice.CRM.Rows.ErpConnectionAccessRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpConnectionAccessRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpConnectionAccessRows.ErpConnectionAccessRowsIdx is Modified



#### SuperOffice.CRM.Rows.ErpConnectionActorTypeRecordData is Modified


#### SuperOffice.CRM.Rows.ErpConnectionActorTypeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ErpConnectionActorTypeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpConnectionActorTypeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpConnectionActorTypeRow.ErpConnectionActorTypeRowIdx is Modified



##### SuperOffice.CRM.Rows.ErpConnectionActorTypeRow.ErpConnectionActorTypeRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ErpConnectionActorTypeRow.IdxErpConnectionActorTypeId is Modified



##### SuperOffice.CRM.Rows.ErpConnectionActorTypeRow.IdxErpConnectionIdActorTypeErp is Modified



#### SuperOffice.CRM.Rows.ErpConnectionActorTypeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpConnectionActorTypeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpConnectionActorTypeRows.ErpConnectionActorTypeRowsIdx is Modified



##### SuperOffice.CRM.Rows.ErpConnectionActorTypeRows.IdxErpConnectionId is Modified



##### SuperOffice.CRM.Rows.ErpConnectionActorTypeRows.IdxErpConnectionIdActorTypeCrm is Modified



#### SuperOffice.CRM.Rows.ErpConnectionRecordData is Modified


#### SuperOffice.CRM.Rows.ErpConnectionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ErpConnectionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpConnectionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpConnectionRow.ErpConnectionRowIdx is Modified



##### SuperOffice.CRM.Rows.ErpConnectionRow.ErpConnectionRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ErpConnectionRow.IdxConnectionId is Modified



##### SuperOffice.CRM.Rows.ErpConnectionRow.IdxErpConnectionId is Modified



#### SuperOffice.CRM.Rows.ErpConnectionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpConnectionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpConnectionRows.ErpConnectionRowsIdx is Modified



##### SuperOffice.CRM.Rows.ErpConnectionRows.IdxErpConnectorId is Modified



#### SuperOffice.CRM.Rows.ErpConnectorRecordData is Modified


#### SuperOffice.CRM.Rows.ErpConnectorRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ErpConnectorRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpConnectorRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpConnectorRow.ErpConnectorRowIdx is Modified



##### SuperOffice.CRM.Rows.ErpConnectorRow.ErpConnectorRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ErpConnectorRow.IdxErpConnectorId is Modified



#### SuperOffice.CRM.Rows.ErpConnectorRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpConnectorRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpConnectorRows.ErpConnectorRowsIdx is Modified



#### SuperOffice.CRM.Rows.ErpExternalKeyRecordData is Modified


#### SuperOffice.CRM.Rows.ErpExternalKeyRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ErpExternalKeyRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpExternalKeyRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpExternalKeyRow.ErpExternalKeyRowIdx is Modified



##### SuperOffice.CRM.Rows.ErpExternalKeyRow.ErpExternalKeyRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ErpExternalKeyRow.IdxErpConnectionIdActorTypeErpKey is Modified



##### SuperOffice.CRM.Rows.ErpExternalKeyRow.IdxErpConnectionIdErpInternalKeyId is Modified



##### SuperOffice.CRM.Rows.ErpExternalKeyRow.IdxErpExternalKeyId is Modified



#### SuperOffice.CRM.Rows.ErpExternalKeyRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpExternalKeyRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpExternalKeyRows.ErpExternalKeyRowsIdx is Modified



##### SuperOffice.CRM.Rows.ErpExternalKeyRows.IdxErpConnectionId is Modified



##### SuperOffice.CRM.Rows.ErpExternalKeyRows.IdxErpConnectionIdActorType is Modified



##### SuperOffice.CRM.Rows.ErpExternalKeyRows.IdxErpInternalKeyId is Modified



#### SuperOffice.CRM.Rows.ErpFieldRecordData is Modified


#### SuperOffice.CRM.Rows.ErpFieldRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ErpFieldRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpFieldRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpFieldRow.ErpFieldRowIdx is Modified



##### SuperOffice.CRM.Rows.ErpFieldRow.ErpFieldRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ErpFieldRow.IdxErpConnectionActorTypeIdErpFieldKey is Modified



##### SuperOffice.CRM.Rows.ErpFieldRow.IdxErpFieldId is Modified



#### SuperOffice.CRM.Rows.ErpFieldRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpFieldRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpFieldRows.ErpFieldRowsIdx is Modified



##### SuperOffice.CRM.Rows.ErpFieldRows.IdxErpConnectionActorTypeId is Modified



#### SuperOffice.CRM.Rows.ErpInternalKeyRecordData is Modified


#### SuperOffice.CRM.Rows.ErpInternalKeyRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ErpInternalKeyRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpInternalKeyRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpInternalKeyRow.ErpInternalKeyRowIdx is Modified



##### SuperOffice.CRM.Rows.ErpInternalKeyRow.ErpInternalKeyRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ErpInternalKeyRow.IdxErpInternalKeyId is Modified



##### SuperOffice.CRM.Rows.ErpInternalKeyRow.IdxRecordIdTableId is Modified



#### SuperOffice.CRM.Rows.ErpInternalKeyRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpInternalKeyRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpInternalKeyRows.ErpInternalKeyRowsIdx is Modified



##### SuperOffice.CRM.Rows.ErpInternalKeyRows.IdxRecordId is Modified



#### SuperOffice.CRM.Rows.ErpListItemMappingRecordData is Modified


#### SuperOffice.CRM.Rows.ErpListItemMappingRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ErpListItemMappingRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpListItemMappingRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpListItemMappingRow.ErpListItemMappingRowIdx is Modified



##### SuperOffice.CRM.Rows.ErpListItemMappingRow.ErpListItemMappingRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ErpListItemMappingRow.IdxErpFieldIdErpItemKey is Modified



##### SuperOffice.CRM.Rows.ErpListItemMappingRow.IdxErpListItemMappingId is Modified



#### SuperOffice.CRM.Rows.ErpListItemMappingRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpListItemMappingRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpListItemMappingRows.ErpListItemMappingRowsIdx is Modified



##### SuperOffice.CRM.Rows.ErpListItemMappingRows.IdxErpFieldId is Modified



#### SuperOffice.CRM.Rows.ErpSyncLogRecordData is Modified


#### SuperOffice.CRM.Rows.ErpSyncLogRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ErpSyncLogRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpSyncLogRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpSyncLogRow.ErpSyncLogRowIdx is Modified



##### SuperOffice.CRM.Rows.ErpSyncLogRow.ErpSyncLogRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ErpSyncLogRow.IdxErpSyncLogId is Modified



#### SuperOffice.CRM.Rows.ErpSyncLogRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ErpSyncLogRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ErpSyncLogRows.ErpSyncLogRowsIdx is Modified



#### SuperOffice.CRM.Rows.ExtAppGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ExtAppGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExtAppGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtAppGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtAppGroupLinkRow.ExtAppGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ExtAppGroupLinkRow.ExtAppGroupLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExtAppGroupLinkRow.IdxExtappgrouplinkId is Modified



#### SuperOffice.CRM.Rows.ExtAppGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtAppGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtAppGroupLinkRows.ExtAppGroupLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.ExtAppGroupLinkRows.IdxExtAppId is Modified



##### SuperOffice.CRM.Rows.ExtAppGroupLinkRows.IdxGroupId is Modified



#### SuperOffice.CRM.Rows.ExtAppHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ExtAppHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExtAppHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtAppHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtAppHeadingLinkRow.ExtAppHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ExtAppHeadingLinkRow.ExtAppHeadingLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExtAppHeadingLinkRow.IdxExtappheadinglinkId is Modified



#### SuperOffice.CRM.Rows.ExtAppHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtAppHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtAppHeadingLinkRows.ExtAppHeadingLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.ExtAppHeadingLinkRows.IdxExtAppId is Modified



##### SuperOffice.CRM.Rows.ExtAppHeadingLinkRows.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.ExtAppRecordData is Modified


#### SuperOffice.CRM.Rows.ExtAppRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExtAppRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtAppRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtAppRow.ExtAppRowIdx is Modified



##### SuperOffice.CRM.Rows.ExtAppRow.ExtAppRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExtAppRow.IdxExtAppId is Modified



##### SuperOffice.CRM.Rows.ExtAppRow.IdxName is Modified



#### SuperOffice.CRM.Rows.ExtAppRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtAppRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtAppRows.ExtAppRowsIdx is Modified



#### SuperOffice.CRM.Rows.ExtDatasourceRecordData is Modified


#### SuperOffice.CRM.Rows.ExtDatasourceRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExtDatasourceRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtDatasourceRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtDatasourceRow.ExtDatasourceRowIdx is Modified



##### SuperOffice.CRM.Rows.ExtDatasourceRow.ExtDatasourceRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExtDatasourceRow.IdxExtDatasourceId is Modified



#### SuperOffice.CRM.Rows.ExtDatasourceRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtDatasourceRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtDatasourceRows.ExtDatasourceRowsIdx is Modified



#### SuperOffice.CRM.Rows.ExternalDocumentRecordData is Modified


#### SuperOffice.CRM.Rows.ExternalDocumentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExternalDocumentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExternalDocumentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExternalDocumentRow.ExternalDocumentRowIdx is Modified



##### SuperOffice.CRM.Rows.ExternalDocumentRow.ExternalDocumentRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExternalDocumentRow.IdxExternalDocumentId is Modified



#### SuperOffice.CRM.Rows.ExternalDocumentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExternalDocumentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExternalDocumentRows.ExternalDocumentRowsIdx is Modified



##### SuperOffice.CRM.Rows.ExternalDocumentRows.IdxAttachmentId is Modified



##### SuperOffice.CRM.Rows.ExternalDocumentRows.IdxChangedBy is Modified



##### SuperOffice.CRM.Rows.ExternalDocumentRows.IdxCreatedBy is Modified



##### SuperOffice.CRM.Rows.ExternalDocumentRows.IdxHierarchyId is Modified



##### SuperOffice.CRM.Rows.ExternalDocumentRows.IdxSMessage is Modified



##### SuperOffice.CRM.Rows.ExternalDocumentRows.IdxTitle is Modified



#### SuperOffice.CRM.Rows.ExternalEventRecordData is Modified


#### SuperOffice.CRM.Rows.ExternalEventRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExternalEventRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExternalEventRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExternalEventRow.ExternalEventRowIdx is Modified



##### SuperOffice.CRM.Rows.ExternalEventRow.ExternalEventRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExternalEventRow.IdxExternalEventId is Modified



#### SuperOffice.CRM.Rows.ExternalEventRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExternalEventRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExternalEventRows.ExternalEventRowsIdx is Modified



##### SuperOffice.CRM.Rows.ExternalEventRows.IdxEventDate is Modified



##### SuperOffice.CRM.Rows.ExternalEventRows.IdxEventEnabled is Modified



##### SuperOffice.CRM.Rows.ExternalEventRows.IdxParentRecord is Modified



##### SuperOffice.CRM.Rows.ExternalEventRows.IdxParentTable is Modified



#### SuperOffice.CRM.Rows.ExtFieldRecordData is Modified


#### SuperOffice.CRM.Rows.ExtFieldRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExtFieldRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtFieldRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtFieldRow.ExtFieldRowIdx is Modified



##### SuperOffice.CRM.Rows.ExtFieldRow.ExtFieldRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExtFieldRow.IdxExtFieldId is Modified



#### SuperOffice.CRM.Rows.ExtFieldRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtFieldRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtFieldRows.ExtFieldRowsIdx is Modified



##### SuperOffice.CRM.Rows.ExtFieldRows.IdxExtTable is Modified



#### SuperOffice.CRM.Rows.ExtraFieldsRecordData is Modified


#### SuperOffice.CRM.Rows.ExtraFieldsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExtraFieldsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtraFieldsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtraFieldsRow.ExtraFieldsRowIdx is Modified



##### SuperOffice.CRM.Rows.ExtraFieldsRow.ExtraFieldsRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExtraFieldsRow.IdxExtraFieldsId is Modified



#### SuperOffice.CRM.Rows.ExtraFieldsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtraFieldsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtraFieldsRows.ExtraFieldsRowsIdx is Modified



##### SuperOffice.CRM.Rows.ExtraFieldsRows.IdxExtraTable is Modified



##### SuperOffice.CRM.Rows.ExtraFieldsRows.IdxTargetExtraTable is Modified



#### SuperOffice.CRM.Rows.ExtraMenusRecordData is Modified


#### SuperOffice.CRM.Rows.ExtraMenusRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExtraMenusRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtraMenusRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtraMenusRow.ExtraMenusRowIdx is Modified



##### SuperOffice.CRM.Rows.ExtraMenusRow.ExtraMenusRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExtraMenusRow.IdxExtraMenusId is Modified



#### SuperOffice.CRM.Rows.ExtraMenusRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtraMenusRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtraMenusRows.ExtraMenusRowsIdx is Modified



##### SuperOffice.CRM.Rows.ExtraMenusRows.IdxExtraTable is Modified



#### SuperOffice.CRM.Rows.ExtraTablesEntryRecordData is Modified


#### SuperOffice.CRM.Rows.ExtraTablesEntryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExtraTablesEntryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtraTablesEntryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtraTablesEntryRow.ExtraTablesEntryRowIdx is Modified



##### SuperOffice.CRM.Rows.ExtraTablesEntryRow.ExtraTablesEntryRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExtraTablesEntryRow.IdxExtraTablesEntryId is Modified



#### SuperOffice.CRM.Rows.ExtraTablesEntryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtraTablesEntryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtraTablesEntryRows.ExtraTablesEntryRowsIdx is Modified



##### SuperOffice.CRM.Rows.ExtraTablesEntryRows.IdxExtraTablesResult is Modified



#### SuperOffice.CRM.Rows.ExtraTablesRecordData is Modified


#### SuperOffice.CRM.Rows.ExtraTablesRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExtraTablesResultRecordData is Modified


#### SuperOffice.CRM.Rows.ExtraTablesResultRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExtraTablesResultRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtraTablesResultRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtraTablesResultRow.ExtraTablesResultRowIdx is Modified



##### SuperOffice.CRM.Rows.ExtraTablesResultRow.ExtraTablesResultRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExtraTablesResultRow.IdxExtraTablesResultId is Modified



#### SuperOffice.CRM.Rows.ExtraTablesResultRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtraTablesResultRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtraTablesResultRows.ExtraTablesResultRowsIdx is Modified



##### SuperOffice.CRM.Rows.ExtraTablesResultRows.IdxExtraTable is Modified



##### SuperOffice.CRM.Rows.ExtraTablesResultRows.IdxLoginId is Modified



#### SuperOffice.CRM.Rows.ExtraTablesRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtraTablesRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtraTablesRow.ExtraTablesRowIdx is Modified



##### SuperOffice.CRM.Rows.ExtraTablesRow.ExtraTablesRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExtraTablesRow.IdxExtraTablesId is Modified



#### SuperOffice.CRM.Rows.ExtraTablesRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtraTablesRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtraTablesRows.ExtraTablesRowsIdx is Modified



##### SuperOffice.CRM.Rows.ExtraTablesRows.IdxDisplayField is Modified



##### SuperOffice.CRM.Rows.ExtraTablesRows.IdxFullnameField is Modified



##### SuperOffice.CRM.Rows.ExtraTablesRows.IdxHierarchyId is Modified



##### SuperOffice.CRM.Rows.ExtraTablesRows.IdxParentField is Modified



##### SuperOffice.CRM.Rows.ExtraTablesRows.IdxScreenChooserAll is Modified



##### SuperOffice.CRM.Rows.ExtraTablesRows.IdxScreenChooserEdit is Modified



##### SuperOffice.CRM.Rows.ExtraTablesRows.IdxScreenChooserEntry is Modified



#### SuperOffice.CRM.Rows.ExtTableRecordData is Modified


#### SuperOffice.CRM.Rows.ExtTableRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ExtTableRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtTableRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtTableRow.ExtTableRowIdx is Modified



##### SuperOffice.CRM.Rows.ExtTableRow.ExtTableRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ExtTableRow.IdxExtTableId is Modified



#### SuperOffice.CRM.Rows.ExtTableRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ExtTableRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ExtTableRows.ExtTableRowsIdx is Modified



##### SuperOffice.CRM.Rows.ExtTableRows.IdxChildTable is Modified



##### SuperOffice.CRM.Rows.ExtTableRows.IdxExtDatasource is Modified



##### SuperOffice.CRM.Rows.ExtTableRows.IdxParentTable is Modified



#### SuperOffice.CRM.Rows.FavouriteRecordData is Modified


#### SuperOffice.CRM.Rows.FavouriteRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.FavouriteRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.FavouriteRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FavouriteRow.FavouriteRowIdx is Modified



##### SuperOffice.CRM.Rows.FavouriteRow.FavouriteRowIdxBase is Modified



##### SuperOffice.CRM.Rows.FavouriteRow.IdxFavouriteId is Modified



#### SuperOffice.CRM.Rows.FavouriteRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.FavouriteRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FavouriteRows.FavouriteRowsIdx is Modified



##### SuperOffice.CRM.Rows.FavouriteRows.IdxRecordId is Modified



##### SuperOffice.CRM.Rows.FavouriteRows.IdxRecordIdAssociateId is Modified



##### SuperOffice.CRM.Rows.FavouriteRows.IdxRecordIdAssociateIdTableId is Modified



#### SuperOffice.CRM.Rows.FieldLabelRecordData is Modified


#### SuperOffice.CRM.Rows.FieldLabelRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.FieldLabelRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.FieldLabelRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FieldLabelRow.FieldLabelRowIdx is Modified



##### SuperOffice.CRM.Rows.FieldLabelRow.FieldLabelRowIdxBase is Modified



##### SuperOffice.CRM.Rows.FieldLabelRow.IdxFieldLabelId is Modified



#### SuperOffice.CRM.Rows.FieldLabelRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.FieldLabelRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FieldLabelRows.FieldLabelRowsIdx is Modified



##### SuperOffice.CRM.Rows.FieldLabelRows.IdxResourceId is Modified



#### SuperOffice.CRM.Rows.ForeignAppRecordData is Modified


#### SuperOffice.CRM.Rows.ForeignAppRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ForeignAppRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ForeignAppRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ForeignAppRow.ForeignAppRowIdx is Modified



##### SuperOffice.CRM.Rows.ForeignAppRow.ForeignAppRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ForeignAppRow.IdxForeignappId is Modified



#### SuperOffice.CRM.Rows.ForeignAppRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ForeignAppRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ForeignAppRows.ForeignAppRowsIdx is Modified



#### SuperOffice.CRM.Rows.ForeignDeviceRecordData is Modified


#### SuperOffice.CRM.Rows.ForeignDeviceRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ForeignDeviceRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ForeignDeviceRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ForeignDeviceRow.ForeignDeviceRowIdx is Modified



##### SuperOffice.CRM.Rows.ForeignDeviceRow.ForeignDeviceRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ForeignDeviceRow.IdxForeigndeviceId is Modified



#### SuperOffice.CRM.Rows.ForeignDeviceRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ForeignDeviceRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ForeignDeviceRows.ForeignDeviceRowsIdx is Modified



##### SuperOffice.CRM.Rows.ForeignDeviceRows.IdxDeviceId is Modified



##### SuperOffice.CRM.Rows.ForeignDeviceRows.IdxForeignappId is Modified



##### SuperOffice.CRM.Rows.ForeignDeviceRows.IdxName is Modified



##### SuperOffice.CRM.Rows.ForeignDeviceRows.IdxOwnerId is Modified



#### SuperOffice.CRM.Rows.ForeignKeyRecordData is Modified


#### SuperOffice.CRM.Rows.ForeignKeyRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ForeignKeyRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ForeignKeyRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ForeignKeyRow.ForeignKeyRowIdx is Modified



##### SuperOffice.CRM.Rows.ForeignKeyRow.ForeignKeyRowIdxBase is Modified



##### SuperOffice.CRM.Rows.ForeignKeyRow.IdxForeignkeyId is Modified



#### SuperOffice.CRM.Rows.ForeignKeyRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ForeignKeyRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ForeignKeyRows.ForeignKeyRowsIdx is Modified



##### SuperOffice.CRM.Rows.ForeignKeyRows.IdxForeigndeviceId is Modified



##### SuperOffice.CRM.Rows.ForeignKeyRows.IdxRecordId is Modified



##### SuperOffice.CRM.Rows.ForeignKeyRows.IdxSeqno is Modified



##### SuperOffice.CRM.Rows.ForeignKeyRows.IdxSubkey is Modified



##### SuperOffice.CRM.Rows.ForeignKeyRows.IdxSubvalue is Modified



#### SuperOffice.CRM.Rows.FormKeysRecordData is Modified


#### SuperOffice.CRM.Rows.FormKeysRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.FormKeysRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.FormKeysRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FormKeysRow.FormKeysRowIdx is Modified



##### SuperOffice.CRM.Rows.FormKeysRow.FormKeysRowIdxBase is Modified



##### SuperOffice.CRM.Rows.FormKeysRow.IdxFormKeysId is Modified



#### SuperOffice.CRM.Rows.FormKeysRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.FormKeysRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FormKeysRows.FormKeysRowsIdx is Modified



##### SuperOffice.CRM.Rows.FormKeysRows.IdxFormKey is Modified



#### SuperOffice.CRM.Rows.FormRecordData is Modified


#### SuperOffice.CRM.Rows.FormRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.FormRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.FormRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FormRow.FormRowIdx is Modified



##### SuperOffice.CRM.Rows.FormRow.FormRowIdxBase is Modified



##### SuperOffice.CRM.Rows.FormRow.IdxFormId is Modified



#### SuperOffice.CRM.Rows.FormRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.FormRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FormRows.FormRowsIdx is Modified



##### SuperOffice.CRM.Rows.FormRows.IdxFormKey is Modified



##### SuperOffice.CRM.Rows.FormRows.IdxResponseShipmentId is Modified



##### SuperOffice.CRM.Rows.FormRows.IdxScriptId is Modified



#### SuperOffice.CRM.Rows.FormSubmissionRecordData is Modified


#### SuperOffice.CRM.Rows.FormSubmissionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.FormSubmissionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.FormSubmissionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FormSubmissionRow.FormSubmissionRowIdx is Modified



##### SuperOffice.CRM.Rows.FormSubmissionRow.FormSubmissionRowIdxBase is Modified



##### SuperOffice.CRM.Rows.FormSubmissionRow.IdxFormSubmissionId is Modified



#### SuperOffice.CRM.Rows.FormSubmissionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.FormSubmissionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FormSubmissionRows.FormSubmissionRowsIdx is Modified



##### SuperOffice.CRM.Rows.FormSubmissionRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.FormSubmissionRows.IdxFormId is Modified



##### SuperOffice.CRM.Rows.FormSubmissionRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.FormSubmissionRows.IdxResponseShipmentAddrId is Modified



#### SuperOffice.CRM.Rows.FreeTextIndexBulkImportFacade is Modified


#### SuperOffice.CRM.Rows.FreeTextIndexRecordData is Modified


#### SuperOffice.CRM.Rows.FreeTextIndexRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.FreeTextIndexRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.FreeTextIndexRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FreeTextIndexRow.FreeTextIndexRowIdx is Modified



##### SuperOffice.CRM.Rows.FreeTextIndexRow.FreeTextIndexRowIdxBase is Modified



##### SuperOffice.CRM.Rows.FreeTextIndexRow.IdxFreetextindexId is Modified



#### SuperOffice.CRM.Rows.FreeTextIndexRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.FreeTextIndexRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FreeTextIndexRows.FreeTextIndexRowsIdx is Modified



##### SuperOffice.CRM.Rows.FreeTextIndexRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.FreeTextIndexRows.IdxFreetextwordsId is Modified



##### SuperOffice.CRM.Rows.FreeTextIndexRows.IdxFreetextwordsIdOwnertableId is Modified



##### SuperOffice.CRM.Rows.FreeTextIndexRows.IdxTableId is Modified



##### SuperOffice.CRM.Rows.FreeTextIndexRows.IdxTableIdRecordId is Modified



#### SuperOffice.CRM.Rows.FreeTextStopWordsRecordData is Modified


#### SuperOffice.CRM.Rows.FreeTextStopWordsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.FreeTextStopWordsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.FreeTextStopWordsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FreeTextStopWordsRow.FreeTextStopWordsRowIdx is Modified



##### SuperOffice.CRM.Rows.FreeTextStopWordsRow.FreeTextStopWordsRowIdxBase is Modified



##### SuperOffice.CRM.Rows.FreeTextStopWordsRow.IdxFreetextwordsId is Modified



#### SuperOffice.CRM.Rows.FreeTextStopWordsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.FreeTextStopWordsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FreeTextStopWordsRows.FreeTextStopWordsRowsIdx is Modified



##### SuperOffice.CRM.Rows.FreeTextStopWordsRows.IdxWord is Modified



#### SuperOffice.CRM.Rows.FreeTextWordsBulkImportFacade is Modified


#### SuperOffice.CRM.Rows.FreeTextWordsRecordData is Modified


#### SuperOffice.CRM.Rows.FreeTextWordsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.FreeTextWordsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.FreeTextWordsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FreeTextWordsRow.FreeTextWordsRowIdx is Modified



##### SuperOffice.CRM.Rows.FreeTextWordsRow.FreeTextWordsRowIdxBase is Modified



##### SuperOffice.CRM.Rows.FreeTextWordsRow.IdxFreetextwordsId is Modified



#### SuperOffice.CRM.Rows.FreeTextWordsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.FreeTextWordsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FreeTextWordsRows.FreeTextWordsRowsIdx is Modified



##### SuperOffice.CRM.Rows.FreeTextWordsRows.IdxSoundEx is Modified



##### SuperOffice.CRM.Rows.FreeTextWordsRows.IdxWord is Modified



#### SuperOffice.CRM.Rows.FunctionRightRecordData is Modified


#### SuperOffice.CRM.Rows.FunctionRightRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.FunctionRightRoleLinkRecordData is Modified


#### SuperOffice.CRM.Rows.FunctionRightRoleLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.FunctionRightRoleLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.FunctionRightRoleLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FunctionRightRoleLinkRow.FunctionRightRoleLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.FunctionRightRoleLinkRow.FunctionRightRoleLinkRowIdxBase is Modified



##### SuperOffice.CRM.Rows.FunctionRightRoleLinkRow.IdxFunctionRightRoleLinkId is Modified



#### SuperOffice.CRM.Rows.FunctionRightRoleLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.FunctionRightRoleLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FunctionRightRoleLinkRows.FunctionRightRoleLinkRowsIdx is Modified



##### SuperOffice.CRM.Rows.FunctionRightRoleLinkRows.IdxFunctionRightId is Modified



##### SuperOffice.CRM.Rows.FunctionRightRoleLinkRows.IdxRoleId is Modified



##### SuperOffice.CRM.Rows.FunctionRightRoleLinkRows.IdxRoleIdFunctionRightId is Modified



#### SuperOffice.CRM.Rows.FunctionRightRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.FunctionRightRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FunctionRightRow.FunctionRightRowIdx is Modified



##### SuperOffice.CRM.Rows.FunctionRightRow.FunctionRightRowIdxBase is Modified



##### SuperOffice.CRM.Rows.FunctionRightRow.IdxFunctionRightId is Modified



#### SuperOffice.CRM.Rows.FunctionRightRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.FunctionRightRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.FunctionRightRows.FunctionRightRowsIdx is Modified



#### SuperOffice.CRM.Rows.HeadingRecordData is Modified


#### SuperOffice.CRM.Rows.HeadingRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.HeadingRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.HeadingRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.HeadingRow.HeadingRowIdx is Modified



##### SuperOffice.CRM.Rows.HeadingRow.HeadingRowIdxBase is Modified



##### SuperOffice.CRM.Rows.HeadingRow.IdxHeadingId is Modified



#### SuperOffice.CRM.Rows.HeadingRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.HeadingRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.HeadingRows.HeadingRowsIdx is Modified



##### SuperOffice.CRM.Rows.HeadingRows.IdxListTableId is Modified



##### SuperOffice.CRM.Rows.HeadingRows.IdxName is Modified



#### SuperOffice.CRM.Rows.HelpRecordData is Modified


#### SuperOffice.CRM.Rows.HelpRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.HelpRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.HelpRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.HelpRow.HelpRowIdx is Modified



##### SuperOffice.CRM.Rows.HelpRow.HelpRowIdxBase is Modified



##### SuperOffice.CRM.Rows.HelpRow.IdxHelpId is Modified



#### SuperOffice.CRM.Rows.HelpRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.HelpRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.HelpRows.HelpRowsIdx is Modified



##### SuperOffice.CRM.Rows.HelpRows.IdxApplicationAreaId is Modified



##### SuperOffice.CRM.Rows.HelpRows.IdxModuleId is Modified



##### SuperOffice.CRM.Rows.HelpRows.IdxParentId is Modified



##### SuperOffice.CRM.Rows.HelpRows.IdxScreenId is Modified



#### SuperOffice.CRM.Rows.HierarchyRecordData is Modified


#### SuperOffice.CRM.Rows.HierarchyRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.HierarchyRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.HierarchyRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.HierarchyRow.HierarchyRowIdx is Modified



##### SuperOffice.CRM.Rows.HierarchyRow.HierarchyRowIdxBase is Modified



##### SuperOffice.CRM.Rows.HierarchyRow.IdxHierarchyId is Modified



#### SuperOffice.CRM.Rows.HierarchyRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.HierarchyRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.HierarchyRows.HierarchyRowsIdx is Modified



##### SuperOffice.CRM.Rows.HierarchyRows.IdxDomain is Modified



##### SuperOffice.CRM.Rows.HierarchyRows.IdxName is Modified



##### SuperOffice.CRM.Rows.HierarchyRows.IdxParentId is Modified



#### SuperOffice.CRM.Rows.HistoryRecordData is Modified


#### SuperOffice.CRM.Rows.HistoryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.HistoryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.HistoryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.HistoryRow.HistoryRowIdx is Modified



##### SuperOffice.CRM.Rows.HistoryRow.HistoryRowIdxBase is Modified



##### SuperOffice.CRM.Rows.HistoryRow.IdxHistoryId is Modified



#### SuperOffice.CRM.Rows.HistoryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.HistoryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.HistoryRows.HistoryRowsIdx is Modified



##### SuperOffice.CRM.Rows.HistoryRows.IdxAssociateId is Modified



##### SuperOffice.CRM.Rows.HistoryRows.IdxAssociateIdTableId is Modified



##### SuperOffice.CRM.Rows.HistoryRows.IdxAssociateIdTableIdExtraId is Modified



##### SuperOffice.CRM.Rows.HistoryRows.IdxRank is Modified



#### SuperOffice.CRM.Rows.HotlistRecordData is Modified


#### SuperOffice.CRM.Rows.HotlistRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.HotlistRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.HotlistRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.HotlistRow.HotlistRowIdx is Modified



##### SuperOffice.CRM.Rows.HotlistRow.HotlistRowIdxBase is Modified



##### SuperOffice.CRM.Rows.HotlistRow.IdxHotlistId is Modified



#### SuperOffice.CRM.Rows.HotlistRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.HotlistRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.HotlistRows.HotlistRowsIdx is Modified



##### SuperOffice.CRM.Rows.HotlistRows.IdxTicketId is Modified



##### SuperOffice.CRM.Rows.HotlistRows.IdxUserId is Modified



#### SuperOffice.CRM.Rows.ImportDefaultRecordData is Modified


#### SuperOffice.CRM.Rows.ImportDefaultRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ImportDefaultRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ImportDefaultRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ImportDefaultRow.IdxImportDefaultId is Modified



##### SuperOffice.CRM.Rows.ImportDefaultRow.ImportDefaultRowIdx is Modified



##### SuperOffice.CRM.Rows.ImportDefaultRow.ImportDefaultRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ImportDefaultRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ImportDefaultRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ImportDefaultRows.IdxImportObjectId is Modified



##### SuperOffice.CRM.Rows.ImportDefaultRows.ImportDefaultRowsIdx is Modified



#### SuperOffice.CRM.Rows.ImportFieldRecordData is Modified


#### SuperOffice.CRM.Rows.ImportFieldRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ImportFieldRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ImportFieldRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ImportFieldRow.IdxImportFieldId is Modified



##### SuperOffice.CRM.Rows.ImportFieldRow.ImportFieldRowIdx is Modified



##### SuperOffice.CRM.Rows.ImportFieldRow.ImportFieldRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ImportFieldRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ImportFieldRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ImportFieldRows.IdxImportObjectId is Modified



##### SuperOffice.CRM.Rows.ImportFieldRows.ImportFieldRowsIdx is Modified



#### SuperOffice.CRM.Rows.ImportObjectRecordData is Modified


#### SuperOffice.CRM.Rows.ImportObjectRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ImportObjectRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ImportObjectRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ImportObjectRow.IdxImportObjectId is Modified



##### SuperOffice.CRM.Rows.ImportObjectRow.ImportObjectRowIdx is Modified



##### SuperOffice.CRM.Rows.ImportObjectRow.ImportObjectRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ImportObjectRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ImportObjectRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ImportObjectRows.ImportObjectRowsIdx is Modified



#### SuperOffice.CRM.Rows.ImportRelationRecordData is Modified


#### SuperOffice.CRM.Rows.ImportRelationRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ImportRelationRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ImportRelationRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ImportRelationRow.IdxImportRelationId is Modified



##### SuperOffice.CRM.Rows.ImportRelationRow.ImportRelationRowIdx is Modified



##### SuperOffice.CRM.Rows.ImportRelationRow.ImportRelationRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ImportRelationRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ImportRelationRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ImportRelationRows.IdxSource is Modified



##### SuperOffice.CRM.Rows.ImportRelationRows.IdxTarget is Modified



##### SuperOffice.CRM.Rows.ImportRelationRows.ImportRelationRowsIdx is Modified



#### SuperOffice.CRM.Rows.InboxRecordData is Modified


#### SuperOffice.CRM.Rows.InboxRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.InboxRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.InboxRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.InboxRow.IdxInboxId is Modified



##### SuperOffice.CRM.Rows.InboxRow.InboxRowIdx is Modified



##### SuperOffice.CRM.Rows.InboxRow.InboxRowIdxBase is Modified



#### SuperOffice.CRM.Rows.InboxRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.InboxRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.InboxRows.IdxImported is Modified



##### SuperOffice.CRM.Rows.InboxRows.IdxLockingId is Modified



##### SuperOffice.CRM.Rows.InboxRows.IdxMailInFilter is Modified



##### SuperOffice.CRM.Rows.InboxRows.IdxStatus is Modified



##### SuperOffice.CRM.Rows.InboxRows.InboxRowsIdx is Modified



#### SuperOffice.CRM.Rows.IntentGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.IntentGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.IntentGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.IntentGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.IntentGroupLinkRow.IdxIntentgrouplinkId is Modified



##### SuperOffice.CRM.Rows.IntentGroupLinkRow.IntentGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.IntentGroupLinkRow.IntentGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.IntentGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.IntentGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.IntentGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.IntentGroupLinkRows.IdxIntentId is Modified



##### SuperOffice.CRM.Rows.IntentGroupLinkRows.IntentGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.IntentHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.IntentHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.IntentHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.IntentHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.IntentHeadingLinkRow.IdxIntentheadinglinkId is Modified



##### SuperOffice.CRM.Rows.IntentHeadingLinkRow.IntentHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.IntentHeadingLinkRow.IntentHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.IntentHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.IntentHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.IntentHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.IntentHeadingLinkRows.IdxIntentId is Modified



##### SuperOffice.CRM.Rows.IntentHeadingLinkRows.IntentHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.IntentRecordData is Modified


#### SuperOffice.CRM.Rows.IntentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.IntentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.IntentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.IntentRow.IdxIntentId is Modified



##### SuperOffice.CRM.Rows.IntentRow.IdxName is Modified



##### SuperOffice.CRM.Rows.IntentRow.IntentRowIdx is Modified



##### SuperOffice.CRM.Rows.IntentRow.IntentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.IntentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.IntentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.IntentRows.IntentRowsIdx is Modified



#### SuperOffice.CRM.Rows.InvitationRecordData is Modified


#### SuperOffice.CRM.Rows.InvitationRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.InvitationRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.InvitationRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.InvitationRow.IdxInvitationId is Modified



##### SuperOffice.CRM.Rows.InvitationRow.InvitationRowIdx is Modified



##### SuperOffice.CRM.Rows.InvitationRow.InvitationRowIdxBase is Modified



#### SuperOffice.CRM.Rows.InvitationRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.InvitationRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.InvitationRows.IdxAppointmentId is Modified



##### SuperOffice.CRM.Rows.InvitationRows.IdxEventUid is Modified



##### SuperOffice.CRM.Rows.InvitationRows.InvitationRowsIdx is Modified



#### SuperOffice.CRM.Rows.InvoiceEntryRecordData is Modified


#### SuperOffice.CRM.Rows.InvoiceEntryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.InvoiceEntryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.InvoiceEntryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.InvoiceEntryRow.IdxInvoiceEntryId is Modified



##### SuperOffice.CRM.Rows.InvoiceEntryRow.InvoiceEntryRowIdx is Modified



##### SuperOffice.CRM.Rows.InvoiceEntryRow.InvoiceEntryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.InvoiceEntryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.InvoiceEntryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.InvoiceEntryRows.IdxDateInvoiced is Modified



##### SuperOffice.CRM.Rows.InvoiceEntryRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.InvoiceEntryRows.IdxType is Modified



##### SuperOffice.CRM.Rows.InvoiceEntryRows.InvoiceEntryRowsIdx is Modified



#### SuperOffice.CRM.Rows.InvoiceRecordData is Modified


#### SuperOffice.CRM.Rows.InvoiceRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.InvoiceRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.InvoiceRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.InvoiceRow.IdxInvoiceId is Modified



##### SuperOffice.CRM.Rows.InvoiceRow.InvoiceRowIdx is Modified



##### SuperOffice.CRM.Rows.InvoiceRow.InvoiceRowIdxBase is Modified



#### SuperOffice.CRM.Rows.InvoiceRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.InvoiceRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.InvoiceRows.IdxCompanyId is Modified



##### SuperOffice.CRM.Rows.InvoiceRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.InvoiceRows.InvoiceRowsIdx is Modified



#### SuperOffice.CRM.Rows.InvoiceSumRecordData is Modified


#### SuperOffice.CRM.Rows.InvoiceSumRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.InvoiceSumRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.InvoiceSumRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.InvoiceSumRow.IdxInvoiceSumId is Modified



##### SuperOffice.CRM.Rows.InvoiceSumRow.InvoiceSumRowIdx is Modified



##### SuperOffice.CRM.Rows.InvoiceSumRow.InvoiceSumRowIdxBase is Modified



#### SuperOffice.CRM.Rows.InvoiceSumRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.InvoiceSumRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.InvoiceSumRows.IdxCompanyId is Modified



##### SuperOffice.CRM.Rows.InvoiceSumRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.InvoiceSumRows.IdxLoginId is Modified



##### SuperOffice.CRM.Rows.InvoiceSumRows.InvoiceSumRowsIdx is Modified



#### SuperOffice.CRM.Rows.InvoiceTypeRecordData is Modified


#### SuperOffice.CRM.Rows.InvoiceTypeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.InvoiceTypeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.InvoiceTypeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.InvoiceTypeRow.IdxInvoiceTypeId is Modified



##### SuperOffice.CRM.Rows.InvoiceTypeRow.InvoiceTypeRowIdx is Modified



##### SuperOffice.CRM.Rows.InvoiceTypeRow.InvoiceTypeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.InvoiceTypeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.InvoiceTypeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.InvoiceTypeRows.InvoiceTypeRowsIdx is Modified



#### SuperOffice.CRM.Rows.ItemConfigRecordData is Modified


#### SuperOffice.CRM.Rows.ItemConfigRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ItemConfigRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ItemConfigRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ItemConfigRow.IdxItemConfigId is Modified



##### SuperOffice.CRM.Rows.ItemConfigRow.ItemConfigRowIdx is Modified



##### SuperOffice.CRM.Rows.ItemConfigRow.ItemConfigRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ItemConfigRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ItemConfigRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ItemConfigRows.IdxDomain is Modified



##### SuperOffice.CRM.Rows.ItemConfigRows.IdxItemId is Modified



##### SuperOffice.CRM.Rows.ItemConfigRows.ItemConfigRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbAttachmentRecordData is Modified


#### SuperOffice.CRM.Rows.KbAttachmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbAttachmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbAttachmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbAttachmentRow.IdxKbAttachmentId is Modified



##### SuperOffice.CRM.Rows.KbAttachmentRow.KbAttachmentRowIdx is Modified



##### SuperOffice.CRM.Rows.KbAttachmentRow.KbAttachmentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbAttachmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbAttachmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbAttachmentRows.IdxAttachmentId is Modified



##### SuperOffice.CRM.Rows.KbAttachmentRows.IdxEntryId is Modified



##### SuperOffice.CRM.Rows.KbAttachmentRows.KbAttachmentRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbCategoryLogRecordData is Modified


#### SuperOffice.CRM.Rows.KbCategoryLogRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbCategoryLogRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbCategoryLogRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbCategoryLogRow.IdxKbCategoryLogId is Modified



##### SuperOffice.CRM.Rows.KbCategoryLogRow.KbCategoryLogRowIdx is Modified



##### SuperOffice.CRM.Rows.KbCategoryLogRow.KbCategoryLogRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbCategoryLogRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbCategoryLogRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbCategoryLogRows.IdxKbCategoryId is Modified



##### SuperOffice.CRM.Rows.KbCategoryLogRows.IdxUserId is Modified



##### SuperOffice.CRM.Rows.KbCategoryLogRows.KbCategoryLogRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbCategoryRecordData is Modified


#### SuperOffice.CRM.Rows.KbCategoryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbCategoryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbCategoryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbCategoryRow.IdxKbCategoryId is Modified



##### SuperOffice.CRM.Rows.KbCategoryRow.KbCategoryRowIdx is Modified



##### SuperOffice.CRM.Rows.KbCategoryRow.KbCategoryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbCategoryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbCategoryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbCategoryRows.IdxCreatedBy is Modified



##### SuperOffice.CRM.Rows.KbCategoryRows.IdxDbiAgentId is Modified



##### SuperOffice.CRM.Rows.KbCategoryRows.IdxDbiKey is Modified



##### SuperOffice.CRM.Rows.KbCategoryRows.IdxDbiLastModified is Modified



##### SuperOffice.CRM.Rows.KbCategoryRows.IdxDbiLastSyncronized is Modified



##### SuperOffice.CRM.Rows.KbCategoryRows.IdxParentId is Modified



##### SuperOffice.CRM.Rows.KbCategoryRows.IdxSortOrder is Modified



##### SuperOffice.CRM.Rows.KbCategoryRows.KbCategoryRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbEntryCommentRecordData is Modified


#### SuperOffice.CRM.Rows.KbEntryCommentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbEntryCommentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbEntryCommentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbEntryCommentRow.IdxKbEntryCommentId is Modified



##### SuperOffice.CRM.Rows.KbEntryCommentRow.KbEntryCommentRowIdx is Modified



##### SuperOffice.CRM.Rows.KbEntryCommentRow.KbEntryCommentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbEntryCommentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbEntryCommentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbEntryCommentRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.KbEntryCommentRows.IdxDbiAgentId is Modified



##### SuperOffice.CRM.Rows.KbEntryCommentRows.IdxDbiKey is Modified



##### SuperOffice.CRM.Rows.KbEntryCommentRows.IdxDbiLastModified is Modified



##### SuperOffice.CRM.Rows.KbEntryCommentRows.IdxDbiLastSyncronized is Modified



##### SuperOffice.CRM.Rows.KbEntryCommentRows.IdxKbEntryId is Modified



##### SuperOffice.CRM.Rows.KbEntryCommentRows.KbEntryCommentRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbEntryKeywordRecordData is Modified


#### SuperOffice.CRM.Rows.KbEntryKeywordRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbEntryKeywordRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbEntryKeywordRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbEntryKeywordRow.IdxKbEntryKeywordId is Modified



##### SuperOffice.CRM.Rows.KbEntryKeywordRow.KbEntryKeywordRowIdx is Modified



##### SuperOffice.CRM.Rows.KbEntryKeywordRow.KbEntryKeywordRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbEntryKeywordRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbEntryKeywordRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbEntryKeywordRows.IdxKbEntryId is Modified



##### SuperOffice.CRM.Rows.KbEntryKeywordRows.IdxKeyword is Modified



##### SuperOffice.CRM.Rows.KbEntryKeywordRows.KbEntryKeywordRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbEntryLogRecordData is Modified


#### SuperOffice.CRM.Rows.KbEntryLogRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbEntryLogRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbEntryLogRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbEntryLogRow.IdxKbEntryLogId is Modified



##### SuperOffice.CRM.Rows.KbEntryLogRow.KbEntryLogRowIdx is Modified



##### SuperOffice.CRM.Rows.KbEntryLogRow.KbEntryLogRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbEntryLogRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbEntryLogRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbEntryLogRows.IdxKbEntryId is Modified



##### SuperOffice.CRM.Rows.KbEntryLogRows.IdxUserId is Modified



##### SuperOffice.CRM.Rows.KbEntryLogRows.KbEntryLogRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbEntryRecordData is Modified


#### SuperOffice.CRM.Rows.KbEntryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbEntryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbEntryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbEntryRow.IdxKbEntryId is Modified



##### SuperOffice.CRM.Rows.KbEntryRow.KbEntryRowIdx is Modified



##### SuperOffice.CRM.Rows.KbEntryRow.KbEntryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbEntryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbEntryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.IdxCategoryId is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.IdxCreatedBy is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.IdxDbiAgentId is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.IdxDbiKey is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.IdxDbiLastModified is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.IdxDbiLastSyncronized is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.IdxSortOrder is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.IdxTitle is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.IdxTitleQuestion is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.IdxTitleQuestionAnswer is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.IdxTitleQuestionAnswerKeywords is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.IdxWorkflowPhase is Modified



##### SuperOffice.CRM.Rows.KbEntryRows.KbEntryRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbEntryWordsRecordData is Modified


#### SuperOffice.CRM.Rows.KbEntryWordsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbEntryWordsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbEntryWordsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbEntryWordsRow.IdxKbEntryWordsId is Modified



##### SuperOffice.CRM.Rows.KbEntryWordsRow.KbEntryWordsRowIdx is Modified



##### SuperOffice.CRM.Rows.KbEntryWordsRow.KbEntryWordsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbEntryWordsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbEntryWordsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbEntryWordsRows.IdxWord is Modified



##### SuperOffice.CRM.Rows.KbEntryWordsRows.KbEntryWordsRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbGroupEntryRecordData is Modified


#### SuperOffice.CRM.Rows.KbGroupEntryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbGroupEntryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbGroupEntryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbGroupEntryRow.IdxKbGroupEntryId is Modified



##### SuperOffice.CRM.Rows.KbGroupEntryRow.KbGroupEntryRowIdx is Modified



##### SuperOffice.CRM.Rows.KbGroupEntryRow.KbGroupEntryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbGroupEntryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbGroupEntryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbGroupEntryRows.IdxKbEntryId is Modified



##### SuperOffice.CRM.Rows.KbGroupEntryRows.IdxKbGroupId is Modified



##### SuperOffice.CRM.Rows.KbGroupEntryRows.KbGroupEntryRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbGroupRecordData is Modified


#### SuperOffice.CRM.Rows.KbGroupRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbGroupRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbGroupRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbGroupRow.IdxKbGroupId is Modified



##### SuperOffice.CRM.Rows.KbGroupRow.KbGroupRowIdx is Modified



##### SuperOffice.CRM.Rows.KbGroupRow.KbGroupRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbGroupRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbGroupRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbGroupRows.IdxDbiAgentId is Modified



##### SuperOffice.CRM.Rows.KbGroupRows.IdxDbiKey is Modified



##### SuperOffice.CRM.Rows.KbGroupRows.IdxDbiLastModified is Modified



##### SuperOffice.CRM.Rows.KbGroupRows.IdxDbiLastSyncronized is Modified



##### SuperOffice.CRM.Rows.KbGroupRows.IdxKbCategoryId is Modified



##### SuperOffice.CRM.Rows.KbGroupRows.IdxParentId is Modified



##### SuperOffice.CRM.Rows.KbGroupRows.KbGroupRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbHttpLinkRecordData is Modified


#### SuperOffice.CRM.Rows.KbHttpLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbHttpLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbHttpLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbHttpLinkRow.IdxKbHttpLinkId is Modified



##### SuperOffice.CRM.Rows.KbHttpLinkRow.KbHttpLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.KbHttpLinkRow.KbHttpLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbHttpLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbHttpLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbHttpLinkRows.IdxEntryId is Modified



##### SuperOffice.CRM.Rows.KbHttpLinkRows.KbHttpLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbSolutionFinderEntryRecordData is Modified


#### SuperOffice.CRM.Rows.KbSolutionFinderEntryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbSolutionFinderEntryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbSolutionFinderEntryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbSolutionFinderEntryRow.IdxKbSolutionFinderEntryId is Modified



##### SuperOffice.CRM.Rows.KbSolutionFinderEntryRow.KbSolutionFinderEntryRowIdx is Modified



##### SuperOffice.CRM.Rows.KbSolutionFinderEntryRow.KbSolutionFinderEntryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbSolutionFinderEntryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbSolutionFinderEntryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbSolutionFinderEntryRows.IdxKbEntry is Modified



##### SuperOffice.CRM.Rows.KbSolutionFinderEntryRows.IdxSolutionFinder is Modified



##### SuperOffice.CRM.Rows.KbSolutionFinderEntryRows.KbSolutionFinderEntryRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbSolutionFinderRecordData is Modified


#### SuperOffice.CRM.Rows.KbSolutionFinderRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbSolutionFinderRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbSolutionFinderRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbSolutionFinderRow.IdxKbSolutionFinderId is Modified



##### SuperOffice.CRM.Rows.KbSolutionFinderRow.KbSolutionFinderRowIdx is Modified



##### SuperOffice.CRM.Rows.KbSolutionFinderRow.KbSolutionFinderRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbSolutionFinderRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbSolutionFinderRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbSolutionFinderRows.IdxParentId is Modified



##### SuperOffice.CRM.Rows.KbSolutionFinderRows.KbSolutionFinderRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbWorkflowAccessRecordData is Modified


#### SuperOffice.CRM.Rows.KbWorkflowAccessRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbWorkflowAccessRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbWorkflowAccessRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbWorkflowAccessRow.IdxKbWorkflowAccessId is Modified



##### SuperOffice.CRM.Rows.KbWorkflowAccessRow.KbWorkflowAccessRowIdx is Modified



##### SuperOffice.CRM.Rows.KbWorkflowAccessRow.KbWorkflowAccessRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbWorkflowAccessRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbWorkflowAccessRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbWorkflowAccessRows.IdxKbWorkflow is Modified



##### SuperOffice.CRM.Rows.KbWorkflowAccessRows.IdxUserId is Modified



##### SuperOffice.CRM.Rows.KbWorkflowAccessRows.KbWorkflowAccessRowsIdx is Modified



#### SuperOffice.CRM.Rows.KbWorkflowRecordData is Modified


#### SuperOffice.CRM.Rows.KbWorkflowRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.KbWorkflowRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbWorkflowRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbWorkflowRow.IdxKbWorkflowId is Modified



##### SuperOffice.CRM.Rows.KbWorkflowRow.KbWorkflowRowIdx is Modified



##### SuperOffice.CRM.Rows.KbWorkflowRow.KbWorkflowRowIdxBase is Modified



#### SuperOffice.CRM.Rows.KbWorkflowRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.KbWorkflowRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.KbWorkflowRows.IdxNext is Modified



##### SuperOffice.CRM.Rows.KbWorkflowRows.IdxPrevious is Modified



##### SuperOffice.CRM.Rows.KbWorkflowRows.KbWorkflowRowsIdx is Modified



#### SuperOffice.CRM.Rows.LanguageInfoCountryRecordData is Modified


#### SuperOffice.CRM.Rows.LanguageInfoCountryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.LanguageInfoCountryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.LanguageInfoCountryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LanguageInfoCountryRow.IdxLanguageInfoCountryId is Modified



##### SuperOffice.CRM.Rows.LanguageInfoCountryRow.LanguageInfoCountryRowIdx is Modified



##### SuperOffice.CRM.Rows.LanguageInfoCountryRow.LanguageInfoCountryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.LanguageInfoCountryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.LanguageInfoCountryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LanguageInfoCountryRows.LanguageInfoCountryRowsIdx is Modified



#### SuperOffice.CRM.Rows.LanguageInfoRecordData is Modified


#### SuperOffice.CRM.Rows.LanguageInfoRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.LanguageInfoRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.LanguageInfoRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LanguageInfoRow.IdxLanguageInfoId is Modified



##### SuperOffice.CRM.Rows.LanguageInfoRow.LanguageInfoRowIdx is Modified



##### SuperOffice.CRM.Rows.LanguageInfoRow.LanguageInfoRowIdxBase is Modified



#### SuperOffice.CRM.Rows.LanguageInfoRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.LanguageInfoRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LanguageInfoRows.LanguageInfoRowsIdx is Modified



#### SuperOffice.CRM.Rows.LegalBaseRecordData is Modified


#### SuperOffice.CRM.Rows.LegalBaseRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.LegalBaseRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.LegalBaseRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LegalBaseRow.IdxKey is Modified



##### SuperOffice.CRM.Rows.LegalBaseRow.IdxLegalBaseId is Modified



##### SuperOffice.CRM.Rows.LegalBaseRow.LegalBaseRowIdx is Modified



##### SuperOffice.CRM.Rows.LegalBaseRow.LegalBaseRowIdxBase is Modified



#### SuperOffice.CRM.Rows.LegalBaseRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.LegalBaseRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LegalBaseRows.LegalBaseRowsIdx is Modified



#### SuperOffice.CRM.Rows.LegalHtmlTagsRecordData is Modified


#### SuperOffice.CRM.Rows.LegalHtmlTagsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.LegalHtmlTagsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.LegalHtmlTagsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LegalHtmlTagsRow.IdxLegalHtmlTagsId is Modified



##### SuperOffice.CRM.Rows.LegalHtmlTagsRow.LegalHtmlTagsRowIdx is Modified



##### SuperOffice.CRM.Rows.LegalHtmlTagsRow.LegalHtmlTagsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.LegalHtmlTagsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.LegalHtmlTagsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LegalHtmlTagsRows.LegalHtmlTagsRowsIdx is Modified



#### SuperOffice.CRM.Rows.LicenseAssocLinkRecordData is Modified


#### SuperOffice.CRM.Rows.LicenseAssocLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.LicenseAssocLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.LicenseAssocLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LicenseAssocLinkRow.IdxLicenseAssocLinkId is Modified



##### SuperOffice.CRM.Rows.LicenseAssocLinkRow.IdxModuleLicenseIdAssocId is Modified



##### SuperOffice.CRM.Rows.LicenseAssocLinkRow.LicenseAssocLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.LicenseAssocLinkRow.LicenseAssocLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.LicenseAssocLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.LicenseAssocLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LicenseAssocLinkRows.IdxModuleLicenseId is Modified



##### SuperOffice.CRM.Rows.LicenseAssocLinkRows.LicenseAssocLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.LicenseSatlLinkRecordData is Modified


#### SuperOffice.CRM.Rows.LicenseSatlLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.LicenseSatlLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.LicenseSatlLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LicenseSatlLinkRow.IdxLicenseSatlLinkId is Modified



##### SuperOffice.CRM.Rows.LicenseSatlLinkRow.IdxModuleLicenseIdSatelliteId is Modified



##### SuperOffice.CRM.Rows.LicenseSatlLinkRow.LicenseSatlLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.LicenseSatlLinkRow.LicenseSatlLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.LicenseSatlLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.LicenseSatlLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LicenseSatlLinkRows.IdxModuleLicenseId is Modified



##### SuperOffice.CRM.Rows.LicenseSatlLinkRows.LicenseSatlLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.LocaleTextRecordData is Modified


#### SuperOffice.CRM.Rows.LocaleTextRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.LocaleTextRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.LocaleTextRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LocaleTextRow.IdxLanguageIdTypeIdResourceId is Modified



##### SuperOffice.CRM.Rows.LocaleTextRow.IdxLocaleTextId is Modified



##### SuperOffice.CRM.Rows.LocaleTextRow.LocaleTextRowIdx is Modified



##### SuperOffice.CRM.Rows.LocaleTextRow.LocaleTextRowIdxBase is Modified



#### SuperOffice.CRM.Rows.LocaleTextRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.LocaleTextRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LocaleTextRows.IdxLanguageId is Modified



##### SuperOffice.CRM.Rows.LocaleTextRows.IdxLanguageIdTypeId is Modified



##### SuperOffice.CRM.Rows.LocaleTextRows.IdxResourceId is Modified



##### SuperOffice.CRM.Rows.LocaleTextRows.LocaleTextRowsIdx is Modified



#### SuperOffice.CRM.Rows.LockingRecordData is Modified


#### SuperOffice.CRM.Rows.LockingRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.LockingRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.LockingRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LockingRow.IdxLockingId is Modified



##### SuperOffice.CRM.Rows.LockingRow.LockingRowIdx is Modified



##### SuperOffice.CRM.Rows.LockingRow.LockingRowIdxBase is Modified



#### SuperOffice.CRM.Rows.LockingRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.LockingRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LockingRows.LockingRowsIdx is Modified



#### SuperOffice.CRM.Rows.LogDebugRecordData is Modified


#### SuperOffice.CRM.Rows.LogDebugRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.LogDebugRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.LogDebugRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LogDebugRow.IdxLogDebugId is Modified



##### SuperOffice.CRM.Rows.LogDebugRow.LogDebugRowIdx is Modified



##### SuperOffice.CRM.Rows.LogDebugRow.LogDebugRowIdxBase is Modified



#### SuperOffice.CRM.Rows.LogDebugRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.LogDebugRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LogDebugRows.LogDebugRowsIdx is Modified



#### SuperOffice.CRM.Rows.LogEventsRecordData is Modified


#### SuperOffice.CRM.Rows.LogEventsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.LogEventsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.LogEventsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LogEventsRow.IdxLogEventsId is Modified



##### SuperOffice.CRM.Rows.LogEventsRow.LogEventsRowIdx is Modified



##### SuperOffice.CRM.Rows.LogEventsRow.LogEventsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.LogEventsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.LogEventsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LogEventsRows.LogEventsRowsIdx is Modified



#### SuperOffice.CRM.Rows.LoginCustomerRecordData is Modified


#### SuperOffice.CRM.Rows.LoginCustomerRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.LoginCustomerRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.LoginCustomerRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LoginCustomerRow.IdxLoginCustomerId is Modified



##### SuperOffice.CRM.Rows.LoginCustomerRow.LoginCustomerRowIdx is Modified



##### SuperOffice.CRM.Rows.LoginCustomerRow.LoginCustomerRowIdxBase is Modified



#### SuperOffice.CRM.Rows.LoginCustomerRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.LoginCustomerRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LoginCustomerRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.LoginCustomerRows.IdxLoginOrigin is Modified



##### SuperOffice.CRM.Rows.LoginCustomerRows.IdxSessionKey is Modified



##### SuperOffice.CRM.Rows.LoginCustomerRows.LoginCustomerRowsIdx is Modified



#### SuperOffice.CRM.Rows.LoginRecordData is Modified


#### SuperOffice.CRM.Rows.LoginRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.LoginRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.LoginRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LoginRow.IdxLoginId is Modified



##### SuperOffice.CRM.Rows.LoginRow.LoginRowIdx is Modified



##### SuperOffice.CRM.Rows.LoginRow.LoginRowIdxBase is Modified



#### SuperOffice.CRM.Rows.LoginRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.LoginRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.LoginRows.IdxLoginOrigin is Modified



##### SuperOffice.CRM.Rows.LoginRows.IdxSessionKey is Modified



##### SuperOffice.CRM.Rows.LoginRows.IdxStatus is Modified



##### SuperOffice.CRM.Rows.LoginRows.IdxUserId is Modified



##### SuperOffice.CRM.Rows.LoginRows.LoginRowsIdx is Modified



#### SuperOffice.CRM.Rows.MailAliasRecordData is Modified


#### SuperOffice.CRM.Rows.MailAliasRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MailAliasRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MailAliasRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MailAliasRow.IdxMailAliasId is Modified



##### SuperOffice.CRM.Rows.MailAliasRow.MailAliasRowIdx is Modified



##### SuperOffice.CRM.Rows.MailAliasRow.MailAliasRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MailAliasRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MailAliasRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MailAliasRows.IdxFilterId is Modified



##### SuperOffice.CRM.Rows.MailAliasRows.MailAliasRowsIdx is Modified



#### SuperOffice.CRM.Rows.MailBlockRecordData is Modified


#### SuperOffice.CRM.Rows.MailBlockRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MailBlockRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MailBlockRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MailBlockRow.IdxMailBlockId is Modified



##### SuperOffice.CRM.Rows.MailBlockRow.MailBlockRowIdx is Modified



##### SuperOffice.CRM.Rows.MailBlockRow.MailBlockRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MailBlockRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MailBlockRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MailBlockRows.MailBlockRowsIdx is Modified



#### SuperOffice.CRM.Rows.MailInFilterRecordData is Modified


#### SuperOffice.CRM.Rows.MailInFilterRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MailInFilterRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MailInFilterRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MailInFilterRow.IdxMailInFilterId is Modified



##### SuperOffice.CRM.Rows.MailInFilterRow.MailInFilterRowIdx is Modified



##### SuperOffice.CRM.Rows.MailInFilterRow.MailInFilterRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MailInFilterRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MailInFilterRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MailInFilterRows.IdxCategoryId is Modified



##### SuperOffice.CRM.Rows.MailInFilterRows.IdxLanguageId is Modified



##### SuperOffice.CRM.Rows.MailInFilterRows.IdxPriority is Modified



##### SuperOffice.CRM.Rows.MailInFilterRows.IdxReplyTemplateId is Modified



##### SuperOffice.CRM.Rows.MailInFilterRows.MailInFilterRowsIdx is Modified



#### SuperOffice.CRM.Rows.MailInUidlRecordData is Modified


#### SuperOffice.CRM.Rows.MailInUidlRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MailInUidlRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MailInUidlRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MailInUidlRow.IdxMailInUidlId is Modified



##### SuperOffice.CRM.Rows.MailInUidlRow.MailInUidlRowIdx is Modified



##### SuperOffice.CRM.Rows.MailInUidlRow.MailInUidlRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MailInUidlRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MailInUidlRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MailInUidlRows.IdxFilterId is Modified



##### SuperOffice.CRM.Rows.MailInUidlRows.MailInUidlRowsIdx is Modified



#### SuperOffice.CRM.Rows.MergeMoveLogRecordData is Modified


#### SuperOffice.CRM.Rows.MergeMoveLogRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MergeMoveLogRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MergeMoveLogRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MergeMoveLogRow.IdxMergeMoveLogId is Modified



##### SuperOffice.CRM.Rows.MergeMoveLogRow.MergeMoveLogRowIdx is Modified



##### SuperOffice.CRM.Rows.MergeMoveLogRow.MergeMoveLogRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MergeMoveLogRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MergeMoveLogRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MergeMoveLogRows.IdxOperation is Modified



##### SuperOffice.CRM.Rows.MergeMoveLogRows.IdxTableNumber is Modified



##### SuperOffice.CRM.Rows.MergeMoveLogRows.MergeMoveLogRowsIdx is Modified



#### SuperOffice.CRM.Rows.MessageCustomersRecordData is Modified


#### SuperOffice.CRM.Rows.MessageCustomersRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MessageCustomersRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MessageCustomersRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MessageCustomersRow.IdxMessageCustomersId is Modified



##### SuperOffice.CRM.Rows.MessageCustomersRow.MessageCustomersRowIdx is Modified



##### SuperOffice.CRM.Rows.MessageCustomersRow.MessageCustomersRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MessageCustomersRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MessageCustomersRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MessageCustomersRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.MessageCustomersRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.MessageCustomersRows.MessageCustomersRowsIdx is Modified



#### SuperOffice.CRM.Rows.MessageHandlerRecordData is Modified


#### SuperOffice.CRM.Rows.MessageHandlerRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MessageHandlerRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MessageHandlerRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MessageHandlerRow.IdxMessageHandlerId is Modified



##### SuperOffice.CRM.Rows.MessageHandlerRow.IdxUniqueIdentifier is Modified



##### SuperOffice.CRM.Rows.MessageHandlerRow.MessageHandlerRowIdx is Modified



##### SuperOffice.CRM.Rows.MessageHandlerRow.MessageHandlerRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MessageHandlerRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MessageHandlerRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MessageHandlerRows.IdxMachine is Modified



##### SuperOffice.CRM.Rows.MessageHandlerRows.MessageHandlerRowsIdx is Modified



#### SuperOffice.CRM.Rows.MessageHeaderRecordData is Modified


#### SuperOffice.CRM.Rows.MessageHeaderRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MessageHeaderRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MessageHeaderRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MessageHeaderRow.IdxMessageHeaderId is Modified



##### SuperOffice.CRM.Rows.MessageHeaderRow.MessageHeaderRowIdx is Modified



##### SuperOffice.CRM.Rows.MessageHeaderRow.MessageHeaderRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MessageHeaderRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MessageHeaderRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MessageHeaderRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.MessageHeaderRows.MessageHeaderRowsIdx is Modified



#### SuperOffice.CRM.Rows.MessageIdRecordData is Modified


#### SuperOffice.CRM.Rows.MessageIdRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MessageIdRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MessageIdRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MessageIdRow.IdxMessageIdId is Modified



##### SuperOffice.CRM.Rows.MessageIdRow.MessageIdRowIdx is Modified



##### SuperOffice.CRM.Rows.MessageIdRow.MessageIdRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MessageIdRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MessageIdRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MessageIdRows.IdxDomain is Modified



##### SuperOffice.CRM.Rows.MessageIdRows.IdxItemId is Modified



##### SuperOffice.CRM.Rows.MessageIdRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.MessageIdRows.MessageIdRowsIdx is Modified



#### SuperOffice.CRM.Rows.MessageRecordData is Modified


#### SuperOffice.CRM.Rows.MessageRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MessageRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MessageRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MessageRow.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.MessageRow.MessageRowIdx is Modified



##### SuperOffice.CRM.Rows.MessageRow.MessageRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MessageRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MessageRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MessageRows.IdxMotherId is Modified



##### SuperOffice.CRM.Rows.MessageRows.IdxSourceHandler is Modified



##### SuperOffice.CRM.Rows.MessageRows.IdxTargetHandler is Modified



##### SuperOffice.CRM.Rows.MessageRows.MessageRowsIdx is Modified



#### SuperOffice.CRM.Rows.ModuleLicenseRecordData is Modified


#### SuperOffice.CRM.Rows.ModuleLicenseRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ModuleLicenseRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ModuleLicenseRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ModuleLicenseRow.IdxModuleLicenseId is Modified



##### SuperOffice.CRM.Rows.ModuleLicenseRow.IdxModuleNameModuleVersionModuleOwnerId is Modified



##### SuperOffice.CRM.Rows.ModuleLicenseRow.ModuleLicenseRowIdx is Modified



##### SuperOffice.CRM.Rows.ModuleLicenseRow.ModuleLicenseRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ModuleLicenseRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ModuleLicenseRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ModuleLicenseRows.IdxModuleName is Modified



##### SuperOffice.CRM.Rows.ModuleLicenseRows.IdxModuleNameModuleVersion is Modified



##### SuperOffice.CRM.Rows.ModuleLicenseRows.ModuleLicenseRowsIdx is Modified



#### SuperOffice.CRM.Rows.ModuleOwnerRecordData is Modified


#### SuperOffice.CRM.Rows.ModuleOwnerRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ModuleOwnerRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ModuleOwnerRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ModuleOwnerRow.IdxModuleOwnerId is Modified



##### SuperOffice.CRM.Rows.ModuleOwnerRow.IdxOwnerName is Modified



##### SuperOffice.CRM.Rows.ModuleOwnerRow.ModuleOwnerRowIdx is Modified



##### SuperOffice.CRM.Rows.ModuleOwnerRow.ModuleOwnerRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ModuleOwnerRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ModuleOwnerRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ModuleOwnerRows.ModuleOwnerRowsIdx is Modified



#### SuperOffice.CRM.Rows.MrMrsGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.MrMrsGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MrMrsGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MrMrsGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MrMrsGroupLinkRow.IdxMrmrsgrouplinkId is Modified



##### SuperOffice.CRM.Rows.MrMrsGroupLinkRow.MrMrsGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.MrMrsGroupLinkRow.MrMrsGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MrMrsGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MrMrsGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MrMrsGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.MrMrsGroupLinkRows.IdxMrMrsId is Modified



##### SuperOffice.CRM.Rows.MrMrsGroupLinkRows.MrMrsGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.MrMrsHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.MrMrsHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MrMrsHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MrMrsHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MrMrsHeadingLinkRow.IdxMrmrsheadinglinkId is Modified



##### SuperOffice.CRM.Rows.MrMrsHeadingLinkRow.MrMrsHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.MrMrsHeadingLinkRow.MrMrsHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MrMrsHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MrMrsHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MrMrsHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.MrMrsHeadingLinkRows.IdxMrMrsId is Modified



##### SuperOffice.CRM.Rows.MrMrsHeadingLinkRows.MrMrsHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.MrMrsRecordData is Modified


#### SuperOffice.CRM.Rows.MrMrsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MrMrsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MrMrsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MrMrsRow.IdxMrMrsId is Modified



##### SuperOffice.CRM.Rows.MrMrsRow.IdxName is Modified



##### SuperOffice.CRM.Rows.MrMrsRow.MrMrsRowIdx is Modified



##### SuperOffice.CRM.Rows.MrMrsRow.MrMrsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MrMrsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MrMrsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MrMrsRows.MrMrsRowsIdx is Modified



#### SuperOffice.CRM.Rows.MsFilterMailRecordData is Modified


#### SuperOffice.CRM.Rows.MsFilterMailRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MsFilterMailRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MsFilterMailRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MsFilterMailRow.IdxMsFilterMailId is Modified



##### SuperOffice.CRM.Rows.MsFilterMailRow.MsFilterMailRowIdx is Modified



##### SuperOffice.CRM.Rows.MsFilterMailRow.MsFilterMailRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MsFilterMailRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MsFilterMailRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MsFilterMailRows.IdxMailInFilterId is Modified



##### SuperOffice.CRM.Rows.MsFilterMailRows.IdxMailSorterId is Modified



##### SuperOffice.CRM.Rows.MsFilterMailRows.MsFilterMailRowsIdx is Modified



#### SuperOffice.CRM.Rows.MsFilterRecordData is Modified


#### SuperOffice.CRM.Rows.MsFilterRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MsFilterRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MsFilterRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MsFilterRow.IdxMsFilterId is Modified



##### SuperOffice.CRM.Rows.MsFilterRow.MsFilterRowIdx is Modified



##### SuperOffice.CRM.Rows.MsFilterRow.MsFilterRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MsFilterRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MsFilterRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MsFilterRows.IdxAutofaqReplyCategory is Modified



##### SuperOffice.CRM.Rows.MsFilterRows.IdxBodyTemplate is Modified



##### SuperOffice.CRM.Rows.MsFilterRows.IdxEjscript is Modified



##### SuperOffice.CRM.Rows.MsFilterRows.IdxNewCategory is Modified



##### SuperOffice.CRM.Rows.MsFilterRows.IdxNewOwner is Modified



##### SuperOffice.CRM.Rows.MsFilterRows.IdxNewPriority is Modified



##### SuperOffice.CRM.Rows.MsFilterRows.IdxNewTags is Modified



##### SuperOffice.CRM.Rows.MsFilterRows.IdxReplyTemplate is Modified



##### SuperOffice.CRM.Rows.MsFilterRows.MsFilterRowsIdx is Modified



#### SuperOffice.CRM.Rows.MsSubstituteRecordData is Modified


#### SuperOffice.CRM.Rows.MsSubstituteRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MsSubstituteRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MsSubstituteRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MsSubstituteRow.IdxMsSubstituteId is Modified



##### SuperOffice.CRM.Rows.MsSubstituteRow.MsSubstituteRowIdx is Modified



##### SuperOffice.CRM.Rows.MsSubstituteRow.MsSubstituteRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MsSubstituteRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MsSubstituteRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MsSubstituteRows.IdxMsFilterId is Modified



##### SuperOffice.CRM.Rows.MsSubstituteRows.MsSubstituteRowsIdx is Modified



#### SuperOffice.CRM.Rows.MsTrashbinRecordData is Modified


#### SuperOffice.CRM.Rows.MsTrashbinRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.MsTrashbinRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.MsTrashbinRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MsTrashbinRow.IdxMsTrashbinId is Modified



##### SuperOffice.CRM.Rows.MsTrashbinRow.MsTrashbinRowIdx is Modified



##### SuperOffice.CRM.Rows.MsTrashbinRow.MsTrashbinRowIdxBase is Modified



#### SuperOffice.CRM.Rows.MsTrashbinRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.MsTrashbinRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.MsTrashbinRows.IdxMailInFilterId is Modified



##### SuperOffice.CRM.Rows.MsTrashbinRows.IdxMailSorterId is Modified



##### SuperOffice.CRM.Rows.MsTrashbinRows.MsTrashbinRowsIdx is Modified



#### SuperOffice.CRM.Rows.NoticeFrameRecordData is Modified


#### SuperOffice.CRM.Rows.NoticeFrameRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.NoticeFrameRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.NoticeFrameRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.NoticeFrameRow.IdxNoticeFrameId is Modified



##### SuperOffice.CRM.Rows.NoticeFrameRow.NoticeFrameRowIdx is Modified



##### SuperOffice.CRM.Rows.NoticeFrameRow.NoticeFrameRowIdxBase is Modified



#### SuperOffice.CRM.Rows.NoticeFrameRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.NoticeFrameRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.NoticeFrameRows.NoticeFrameRowsIdx is Modified



#### SuperOffice.CRM.Rows.NotifyRecordData is Modified


#### SuperOffice.CRM.Rows.NotifyRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.NotifyRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.NotifyRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.NotifyRow.IdxNotifyId is Modified



##### SuperOffice.CRM.Rows.NotifyRow.NotifyRowIdx is Modified



##### SuperOffice.CRM.Rows.NotifyRow.NotifyRowIdxBase is Modified



#### SuperOffice.CRM.Rows.NotifyRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.NotifyRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.NotifyRows.IdxCategoryId is Modified



##### SuperOffice.CRM.Rows.NotifyRows.IdxChatTopicId is Modified



##### SuperOffice.CRM.Rows.NotifyRows.IdxOwnerId is Modified



##### SuperOffice.CRM.Rows.NotifyRows.IdxTicketAlertId is Modified



##### SuperOffice.CRM.Rows.NotifyRows.IdxTicketId is Modified



##### SuperOffice.CRM.Rows.NotifyRows.IdxUser2Id is Modified



##### SuperOffice.CRM.Rows.NotifyRows.IdxUserId is Modified



##### SuperOffice.CRM.Rows.NotifyRows.NotifyRowsIdx is Modified



#### SuperOffice.CRM.Rows.OLEFieldRecordData is Modified


#### SuperOffice.CRM.Rows.OLEFieldRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.OLEFieldRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.OLEFieldRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OLEFieldRow.IdxOLEFieldId is Modified



##### SuperOffice.CRM.Rows.OLEFieldRow.OLEFieldRowIdx is Modified



##### SuperOffice.CRM.Rows.OLEFieldRow.OLEFieldRowIdxBase is Modified



#### SuperOffice.CRM.Rows.OLEFieldRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.OLEFieldRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OLEFieldRows.IdxFieldId is Modified



##### SuperOffice.CRM.Rows.OLEFieldRows.IdxOLEViewId is Modified



##### SuperOffice.CRM.Rows.OLEFieldRows.IdxOLEViewIdFieldId is Modified



##### SuperOffice.CRM.Rows.OLEFieldRows.OLEFieldRowsIdx is Modified



#### SuperOffice.CRM.Rows.OLEFieldTextRecordData is Modified


#### SuperOffice.CRM.Rows.OLEFieldTextRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.OLEFieldTextRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.OLEFieldTextRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OLEFieldTextRow.IdxOLEFieldTextId is Modified



##### SuperOffice.CRM.Rows.OLEFieldTextRow.OLEFieldTextRowIdx is Modified



##### SuperOffice.CRM.Rows.OLEFieldTextRow.OLEFieldTextRowIdxBase is Modified



#### SuperOffice.CRM.Rows.OLEFieldTextRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.OLEFieldTextRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OLEFieldTextRows.IdxLanguageId is Modified



##### SuperOffice.CRM.Rows.OLEFieldTextRows.IdxName is Modified



##### SuperOffice.CRM.Rows.OLEFieldTextRows.IdxOLEFieldId is Modified



##### SuperOffice.CRM.Rows.OLEFieldTextRows.IdxOLEFieldIdLanguageId is Modified



##### SuperOffice.CRM.Rows.OLEFieldTextRows.OLEFieldTextRowsIdx is Modified



#### SuperOffice.CRM.Rows.OLESubjectRecordData is Modified


#### SuperOffice.CRM.Rows.OLESubjectRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.OLESubjectRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.OLESubjectRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OLESubjectRow.IdxOLESubjectId is Modified



##### SuperOffice.CRM.Rows.OLESubjectRow.OLESubjectRowIdx is Modified



##### SuperOffice.CRM.Rows.OLESubjectRow.OLESubjectRowIdxBase is Modified



#### SuperOffice.CRM.Rows.OLESubjectRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.OLESubjectRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OLESubjectRows.OLESubjectRowsIdx is Modified



#### SuperOffice.CRM.Rows.OLESubjectTextRecordData is Modified


#### SuperOffice.CRM.Rows.OLESubjectTextRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.OLESubjectTextRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.OLESubjectTextRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OLESubjectTextRow.IdxOLESubjectTextId is Modified



##### SuperOffice.CRM.Rows.OLESubjectTextRow.OLESubjectTextRowIdx is Modified



##### SuperOffice.CRM.Rows.OLESubjectTextRow.OLESubjectTextRowIdxBase is Modified



#### SuperOffice.CRM.Rows.OLESubjectTextRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.OLESubjectTextRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OLESubjectTextRows.IdxLanguageId is Modified



##### SuperOffice.CRM.Rows.OLESubjectTextRows.IdxName is Modified



##### SuperOffice.CRM.Rows.OLESubjectTextRows.IdxOLESubjectId is Modified



##### SuperOffice.CRM.Rows.OLESubjectTextRows.IdxOLESubjectIdLanguageId is Modified



##### SuperOffice.CRM.Rows.OLESubjectTextRows.OLESubjectTextRowsIdx is Modified



#### SuperOffice.CRM.Rows.OLEViewRecordData is Modified


#### SuperOffice.CRM.Rows.OLEViewRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.OLEViewRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.OLEViewRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OLEViewRow.IdxOLEViewId is Modified



##### SuperOffice.CRM.Rows.OLEViewRow.OLEViewRowIdx is Modified



##### SuperOffice.CRM.Rows.OLEViewRow.OLEViewRowIdxBase is Modified



#### SuperOffice.CRM.Rows.OLEViewRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.OLEViewRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OLEViewRows.IdxOLESubjectId is Modified



##### SuperOffice.CRM.Rows.OLEViewRows.OLEViewRowsIdx is Modified



#### SuperOffice.CRM.Rows.OLEViewTextRecordData is Modified


#### SuperOffice.CRM.Rows.OLEViewTextRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.OLEViewTextRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.OLEViewTextRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OLEViewTextRow.IdxOLEViewTextId is Modified



##### SuperOffice.CRM.Rows.OLEViewTextRow.OLEViewTextRowIdx is Modified



##### SuperOffice.CRM.Rows.OLEViewTextRow.OLEViewTextRowIdxBase is Modified



#### SuperOffice.CRM.Rows.OLEViewTextRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.OLEViewTextRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OLEViewTextRows.IdxLanguageId is Modified



##### SuperOffice.CRM.Rows.OLEViewTextRows.IdxName is Modified



##### SuperOffice.CRM.Rows.OLEViewTextRows.IdxOLEViewId is Modified



##### SuperOffice.CRM.Rows.OLEViewTextRows.IdxOLEViewIdLanguageId is Modified



##### SuperOffice.CRM.Rows.OLEViewTextRows.OLEViewTextRowsIdx is Modified



#### SuperOffice.CRM.Rows.OnlineAppRecordData is Modified


#### SuperOffice.CRM.Rows.OnlineAppRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.OnlineAppRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.OnlineAppRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OnlineAppRow.IdxClientId is Modified



##### SuperOffice.CRM.Rows.OnlineAppRow.IdxOnlineAppId is Modified



##### SuperOffice.CRM.Rows.OnlineAppRow.OnlineAppRowIdx is Modified



##### SuperOffice.CRM.Rows.OnlineAppRow.OnlineAppRowIdxBase is Modified



#### SuperOffice.CRM.Rows.OnlineAppRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.OnlineAppRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OnlineAppRows.OnlineAppRowsIdx is Modified



#### SuperOffice.CRM.Rows.OutboxRecordData is Modified


#### SuperOffice.CRM.Rows.OutboxRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.OutboxRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.OutboxRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OutboxRow.IdxOutboxId is Modified



##### SuperOffice.CRM.Rows.OutboxRow.OutboxRowIdx is Modified



##### SuperOffice.CRM.Rows.OutboxRow.OutboxRowIdxBase is Modified



#### SuperOffice.CRM.Rows.OutboxRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.OutboxRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OutboxRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.OutboxRows.IdxTicketId is Modified



##### SuperOffice.CRM.Rows.OutboxRows.OutboxRowsIdx is Modified



#### SuperOffice.CRM.Rows.OutgoingMessageRecordData is Modified


#### SuperOffice.CRM.Rows.OutgoingMessageRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.OutgoingMessageRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.OutgoingMessageRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OutgoingMessageRow.IdxOutgoingMessageId is Modified



##### SuperOffice.CRM.Rows.OutgoingMessageRow.OutgoingMessageRowIdx is Modified



##### SuperOffice.CRM.Rows.OutgoingMessageRow.OutgoingMessageRowIdxBase is Modified



#### SuperOffice.CRM.Rows.OutgoingMessageRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.OutgoingMessageRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OutgoingMessageRows.IdxExternalMessageId is Modified



##### SuperOffice.CRM.Rows.OutgoingMessageRows.IdxRegisteredAssociateId is Modified



##### SuperOffice.CRM.Rows.OutgoingMessageRows.IdxSessionKey is Modified



##### SuperOffice.CRM.Rows.OutgoingMessageRows.IdxUpdatedAssociateId is Modified



##### SuperOffice.CRM.Rows.OutgoingMessageRows.OutgoingMessageRowsIdx is Modified



#### SuperOffice.CRM.Rows.OwnerContactLinkRecordData is Modified


#### SuperOffice.CRM.Rows.OwnerContactLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.OwnerContactLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.OwnerContactLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OwnerContactLinkRow.IdxOwnerContactLinkId is Modified



##### SuperOffice.CRM.Rows.OwnerContactLinkRow.OwnerContactLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.OwnerContactLinkRow.OwnerContactLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.OwnerContactLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.OwnerContactLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.OwnerContactLinkRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.OwnerContactLinkRows.OwnerContactLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PasswordRulesRecordData is Modified


#### SuperOffice.CRM.Rows.PasswordRulesRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PasswordRulesRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PasswordRulesRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PasswordRulesRow.IdxPasswordRulesId is Modified



##### SuperOffice.CRM.Rows.PasswordRulesRow.PasswordRulesRowIdx is Modified



##### SuperOffice.CRM.Rows.PasswordRulesRow.PasswordRulesRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PasswordRulesRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PasswordRulesRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PasswordRulesRows.PasswordRulesRowsIdx is Modified



#### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRow.IdxPaymentTermsGroupLinkId is Modified



##### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRow.PaymentTermsGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRow.PaymentTermsGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRows.IdxPaymentTermsId is Modified



##### SuperOffice.CRM.Rows.PaymentTermsGroupLinkRows.PaymentTermsGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRow.IdxPaymentTermsHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRow.PaymentTermsHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRow.PaymentTermsHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRows.IdxPaymentTermsId is Modified



##### SuperOffice.CRM.Rows.PaymentTermsHeadingLinkRows.PaymentTermsHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PaymentTermsRecordData is Modified


#### SuperOffice.CRM.Rows.PaymentTermsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PaymentTermsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PaymentTermsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PaymentTermsRow.IdxName is Modified



##### SuperOffice.CRM.Rows.PaymentTermsRow.IdxPaymentTermsId is Modified



##### SuperOffice.CRM.Rows.PaymentTermsRow.PaymentTermsRowIdx is Modified



##### SuperOffice.CRM.Rows.PaymentTermsRow.PaymentTermsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PaymentTermsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PaymentTermsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PaymentTermsRows.PaymentTermsRowsIdx is Modified



#### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRow.IdxPaymentTypeGroupLinkId is Modified



##### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRow.PaymentTypeGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRow.PaymentTypeGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRows.IdxPaymentTypeId is Modified



##### SuperOffice.CRM.Rows.PaymentTypeGroupLinkRows.PaymentTypeGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRow.IdxPaymentTypeHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRow.PaymentTypeHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRow.PaymentTypeHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRows.IdxPaymentTypeId is Modified



##### SuperOffice.CRM.Rows.PaymentTypeHeadingLinkRows.PaymentTypeHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PaymentTypeRecordData is Modified


#### SuperOffice.CRM.Rows.PaymentTypeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PaymentTypeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PaymentTypeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PaymentTypeRow.IdxName is Modified



##### SuperOffice.CRM.Rows.PaymentTypeRow.IdxPaymentTypeId is Modified



##### SuperOffice.CRM.Rows.PaymentTypeRow.PaymentTypeRowIdx is Modified



##### SuperOffice.CRM.Rows.PaymentTypeRow.PaymentTypeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PaymentTypeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PaymentTypeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PaymentTypeRows.PaymentTypeRowsIdx is Modified



#### SuperOffice.CRM.Rows.PersIntGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PersIntGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PersIntGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersIntGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersIntGroupLinkRow.IdxPersintgrouplinkId is Modified



##### SuperOffice.CRM.Rows.PersIntGroupLinkRow.PersIntGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PersIntGroupLinkRow.PersIntGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PersIntGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersIntGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersIntGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.PersIntGroupLinkRows.IdxPersIntId is Modified



##### SuperOffice.CRM.Rows.PersIntGroupLinkRows.PersIntGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PersIntHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PersIntHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PersIntHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersIntHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersIntHeadingLinkRow.IdxPersintheadinglinkId is Modified



##### SuperOffice.CRM.Rows.PersIntHeadingLinkRow.PersIntHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PersIntHeadingLinkRow.PersIntHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PersIntHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersIntHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersIntHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.PersIntHeadingLinkRows.IdxPersIntId is Modified



##### SuperOffice.CRM.Rows.PersIntHeadingLinkRows.PersIntHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PersIntRecordData is Modified


#### SuperOffice.CRM.Rows.PersIntRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PersIntRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersIntRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersIntRow.IdxName is Modified



##### SuperOffice.CRM.Rows.PersIntRow.IdxPersIntId is Modified



##### SuperOffice.CRM.Rows.PersIntRow.PersIntRowIdx is Modified



##### SuperOffice.CRM.Rows.PersIntRow.PersIntRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PersIntRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersIntRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersIntRows.PersIntRowsIdx is Modified



#### SuperOffice.CRM.Rows.PersonInterestRecordData is Modified


#### SuperOffice.CRM.Rows.PersonInterestRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PersonInterestRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersonInterestRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersonInterestRow.IdxPersonIdPinterestIdx is Modified



##### SuperOffice.CRM.Rows.PersonInterestRow.IdxPersoninterestId is Modified



##### SuperOffice.CRM.Rows.PersonInterestRow.PersonInterestRowIdx is Modified



##### SuperOffice.CRM.Rows.PersonInterestRow.PersonInterestRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PersonInterestRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersonInterestRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersonInterestRows.IdxEndDate is Modified



##### SuperOffice.CRM.Rows.PersonInterestRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.PersonInterestRows.IdxPinterestIdx is Modified



##### SuperOffice.CRM.Rows.PersonInterestRows.IdxStartDate is Modified



##### SuperOffice.CRM.Rows.PersonInterestRows.PersonInterestRowsIdx is Modified



#### SuperOffice.CRM.Rows.PersonRecordData is Modified


#### SuperOffice.CRM.Rows.PersonRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PersonRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersonRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersonRow.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.PersonRow.PersonRowIdx is Modified



##### SuperOffice.CRM.Rows.PersonRow.PersonRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PersonRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersonRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxBusinessIdx is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxCategoryIdx is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxContactIdRank is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxDbiAgentId is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxDbiKey is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxDbiLastModified is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxDbiLastSyncronized is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxDeletedDate is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxFirstname is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxKanafname is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxKanalname is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxLastname is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxMiddleName is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxPersonNumber is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxSource is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxUserdef2Id is Modified



##### SuperOffice.CRM.Rows.PersonRows.IdxUserdefId is Modified



##### SuperOffice.CRM.Rows.PersonRows.PersonRowsIdx is Modified



#### SuperOffice.CRM.Rows.PersPosGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PersPosGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PersPosGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersPosGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersPosGroupLinkRow.IdxPersposgrouplinkId is Modified



##### SuperOffice.CRM.Rows.PersPosGroupLinkRow.PersPosGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PersPosGroupLinkRow.PersPosGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PersPosGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersPosGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersPosGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.PersPosGroupLinkRows.IdxPersPosId is Modified



##### SuperOffice.CRM.Rows.PersPosGroupLinkRows.PersPosGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PersPosHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PersPosHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PersPosHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersPosHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersPosHeadingLinkRow.IdxPersposheadinglinkId is Modified



##### SuperOffice.CRM.Rows.PersPosHeadingLinkRow.PersPosHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PersPosHeadingLinkRow.PersPosHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PersPosHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersPosHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersPosHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.PersPosHeadingLinkRows.IdxPersPosId is Modified



##### SuperOffice.CRM.Rows.PersPosHeadingLinkRows.PersPosHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PersPosRecordData is Modified


#### SuperOffice.CRM.Rows.PersPosRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PersPosRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersPosRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersPosRow.IdxName is Modified



##### SuperOffice.CRM.Rows.PersPosRow.IdxPersPosId is Modified



##### SuperOffice.CRM.Rows.PersPosRow.PersPosRowIdx is Modified



##### SuperOffice.CRM.Rows.PersPosRow.PersPosRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PersPosRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PersPosRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PersPosRows.PersPosRowsIdx is Modified



#### SuperOffice.CRM.Rows.PhoneFormatRecordData is Modified


#### SuperOffice.CRM.Rows.PhoneFormatRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PhoneFormatRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PhoneFormatRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PhoneFormatRow.IdxPhoneFormatId is Modified



##### SuperOffice.CRM.Rows.PhoneFormatRow.IdxPrefixCountryId is Modified



##### SuperOffice.CRM.Rows.PhoneFormatRow.PhoneFormatRowIdx is Modified



##### SuperOffice.CRM.Rows.PhoneFormatRow.PhoneFormatRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PhoneFormatRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PhoneFormatRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PhoneFormatRows.IdxPrefix is Modified



##### SuperOffice.CRM.Rows.PhoneFormatRows.PhoneFormatRowsIdx is Modified



#### SuperOffice.CRM.Rows.PhoneRecordData is Modified


#### SuperOffice.CRM.Rows.PhoneRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PhoneRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PhoneRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PhoneRow.IdxPhoneId is Modified



##### SuperOffice.CRM.Rows.PhoneRow.PhoneRowIdx is Modified



##### SuperOffice.CRM.Rows.PhoneRow.PhoneRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PhoneRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PhoneRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PhoneRows.IdxOwnerId is Modified



##### SuperOffice.CRM.Rows.PhoneRows.IdxOwnerIdPtypeIdx is Modified



##### SuperOffice.CRM.Rows.PhoneRows.IdxRank is Modified



##### SuperOffice.CRM.Rows.PhoneRows.IdxSearchPhoneNumber is Modified



##### SuperOffice.CRM.Rows.PhoneRows.PhoneRowsIdx is Modified



#### SuperOffice.CRM.Rows.PMembTypeGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PMembTypeGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PMembTypeGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PMembTypeGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PMembTypeGroupLinkRow.IdxPmembtypegrouplinkId is Modified



##### SuperOffice.CRM.Rows.PMembTypeGroupLinkRow.PMembTypeGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PMembTypeGroupLinkRow.PMembTypeGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PMembTypeGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PMembTypeGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PMembTypeGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.PMembTypeGroupLinkRows.IdxPMembTypeId is Modified



##### SuperOffice.CRM.Rows.PMembTypeGroupLinkRows.PMembTypeGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRow.IdxPmembtypeheadinglinkId is Modified



##### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRow.PMembTypeHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRow.PMembTypeHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRows.IdxPMembTypeId is Modified



##### SuperOffice.CRM.Rows.PMembTypeHeadingLinkRows.PMembTypeHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PMembTypeRecordData is Modified


#### SuperOffice.CRM.Rows.PMembTypeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PMembTypeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PMembTypeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PMembTypeRow.IdxName is Modified



##### SuperOffice.CRM.Rows.PMembTypeRow.IdxPMembTypeId is Modified



##### SuperOffice.CRM.Rows.PMembTypeRow.PMembTypeRowIdx is Modified



##### SuperOffice.CRM.Rows.PMembTypeRow.PMembTypeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PMembTypeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PMembTypeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PMembTypeRows.PMembTypeRowsIdx is Modified



#### SuperOffice.CRM.Rows.PrefDescLineRecordData is Modified


#### SuperOffice.CRM.Rows.PrefDescLineRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PrefDescLineRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PrefDescLineRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PrefDescLineRow.IdxPrefDescLineId is Modified



##### SuperOffice.CRM.Rows.PrefDescLineRow.PrefDescLineRowIdx is Modified



##### SuperOffice.CRM.Rows.PrefDescLineRow.PrefDescLineRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PrefDescLineRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PrefDescLineRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PrefDescLineRows.IdxPrefDescId is Modified



##### SuperOffice.CRM.Rows.PrefDescLineRows.IdxPrefValue is Modified



##### SuperOffice.CRM.Rows.PrefDescLineRows.PrefDescLineRowsIdx is Modified



#### SuperOffice.CRM.Rows.PrefDescRecordData is Modified


#### SuperOffice.CRM.Rows.PrefDescRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PrefDescRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PrefDescRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PrefDescRow.IdxPrefDescId is Modified



##### SuperOffice.CRM.Rows.PrefDescRow.PrefDescRowIdx is Modified



##### SuperOffice.CRM.Rows.PrefDescRow.PrefDescRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PrefDescRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PrefDescRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PrefDescRows.IdxPrefkey is Modified



##### SuperOffice.CRM.Rows.PrefDescRows.IdxPrefsection is Modified



##### SuperOffice.CRM.Rows.PrefDescRows.PrefDescRowsIdx is Modified



#### SuperOffice.CRM.Rows.PreferenceRecordData is Modified


#### SuperOffice.CRM.Rows.PreferenceRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PreferenceRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PreferenceRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PreferenceRow.IdxPreferenceId is Modified



##### SuperOffice.CRM.Rows.PreferenceRow.IdxTypePreferenceId is Modified



##### SuperOffice.CRM.Rows.PreferenceRow.PreferenceRowIdx is Modified



##### SuperOffice.CRM.Rows.PreferenceRow.PreferenceRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PreferenceRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PreferenceRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PreferenceRows.IdxType is Modified



##### SuperOffice.CRM.Rows.PreferenceRows.PreferenceRowsIdx is Modified



#### SuperOffice.CRM.Rows.PriceListRecordData is Modified


#### SuperOffice.CRM.Rows.PriceListRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PriceListRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriceListRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriceListRow.IdxPriceListId is Modified



##### SuperOffice.CRM.Rows.PriceListRow.PriceListRowIdx is Modified



##### SuperOffice.CRM.Rows.PriceListRow.PriceListRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PriceListRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriceListRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriceListRows.IdxCurrencyId is Modified



##### SuperOffice.CRM.Rows.PriceListRows.IdxValidFrom is Modified



##### SuperOffice.CRM.Rows.PriceListRows.IdxValidFromValidTo is Modified



##### SuperOffice.CRM.Rows.PriceListRows.IdxValidFromValidToIsActive is Modified



##### SuperOffice.CRM.Rows.PriceListRows.IdxValidFromValidToIsActiveIsERPCopy is Modified



##### SuperOffice.CRM.Rows.PriceListRows.PriceListRowsIdx is Modified



#### SuperOffice.CRM.Rows.PriceUnitGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PriceUnitGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PriceUnitGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriceUnitGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriceUnitGroupLinkRow.IdxPriceUnitGroupLinkId is Modified



##### SuperOffice.CRM.Rows.PriceUnitGroupLinkRow.PriceUnitGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PriceUnitGroupLinkRow.PriceUnitGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PriceUnitGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriceUnitGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriceUnitGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.PriceUnitGroupLinkRows.IdxPriceUnitId is Modified



##### SuperOffice.CRM.Rows.PriceUnitGroupLinkRows.PriceUnitGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRow.IdxPriceUnitHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRow.PriceUnitHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRow.PriceUnitHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRows.IdxPriceUnitId is Modified



##### SuperOffice.CRM.Rows.PriceUnitHeadingLinkRows.PriceUnitHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PriceUnitRecordData is Modified


#### SuperOffice.CRM.Rows.PriceUnitRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PriceUnitRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriceUnitRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriceUnitRow.IdxName is Modified



##### SuperOffice.CRM.Rows.PriceUnitRow.IdxPriceUnitId is Modified



##### SuperOffice.CRM.Rows.PriceUnitRow.PriceUnitRowIdx is Modified



##### SuperOffice.CRM.Rows.PriceUnitRow.PriceUnitRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PriceUnitRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriceUnitRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriceUnitRows.PriceUnitRowsIdx is Modified



#### SuperOffice.CRM.Rows.PriorityGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PriorityGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PriorityGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriorityGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriorityGroupLinkRow.IdxPrioritygrouplinkId is Modified



##### SuperOffice.CRM.Rows.PriorityGroupLinkRow.PriorityGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PriorityGroupLinkRow.PriorityGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PriorityGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriorityGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriorityGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.PriorityGroupLinkRows.IdxPriorityId is Modified



##### SuperOffice.CRM.Rows.PriorityGroupLinkRows.PriorityGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PriorityHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.PriorityHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PriorityHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriorityHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriorityHeadingLinkRow.IdxPriorityheadinglinkId is Modified



##### SuperOffice.CRM.Rows.PriorityHeadingLinkRow.PriorityHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.PriorityHeadingLinkRow.PriorityHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PriorityHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriorityHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriorityHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.PriorityHeadingLinkRows.IdxPriorityId is Modified



##### SuperOffice.CRM.Rows.PriorityHeadingLinkRows.PriorityHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.PriorityRecordData is Modified


#### SuperOffice.CRM.Rows.PriorityRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PriorityRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriorityRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriorityRow.IdxName is Modified



##### SuperOffice.CRM.Rows.PriorityRow.IdxPriorityId is Modified



##### SuperOffice.CRM.Rows.PriorityRow.PriorityRowIdx is Modified



##### SuperOffice.CRM.Rows.PriorityRow.PriorityRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PriorityRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PriorityRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PriorityRows.PriorityRowsIdx is Modified



#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAccessScriptRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAccessScriptRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateActiveUserRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateActiveUserRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAddressFormatRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAddressFormatRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAddressRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAddressRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAmountClassGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAmountClassGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAmountClassHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAmountClassHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAmountClassRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAmountClassRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAppointmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAppointmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAreaRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAreaRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAreaUserAssignmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAreaUserAssignmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAreaUserInclusionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAreaUserInclusionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAssociateGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAssociateGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAssociateHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAssociateHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAssociateHistoryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAssociateHistoryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAssociateRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAssociateRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAttachmentLocationRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAttachmentLocationRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAttachmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAttachmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAudienceConfigRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAudienceConfigRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAudienceLayoutLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAudienceLayoutLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAudienceLayoutRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAudienceLayoutRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAudienceVisibilityRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAudienceVisibilityRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAutosaveRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateAutosaveRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBaseTZLocationRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBaseTZLocationRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBatchTaskDefinitionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBatchTaskDefinitionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBatchTaskRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBatchTaskRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBinaryObjectLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBinaryObjectLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBinaryObjectRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBinaryObjectRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBusinessGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBusinessGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBusinessHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBusinessHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBusinessRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateBusinessRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCacheInvalidationRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCacheInvalidationRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCacheTablesRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCacheTablesRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCategoryFamilyRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCategoryFamilyRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCategoryGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCategoryGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCategoryHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCategoryHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCategoryMembershipRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCategoryMembershipRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCategoryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCategoryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateChatMessageRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateChatMessageRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateChatSessionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateChatSessionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateChatTopicRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateChatTopicRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateChatTopicUserRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateChatTopicUserRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCompanyDomainRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCompanyDomainRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCompanyRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCompanyRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateComptrGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateComptrGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateComptrHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateComptrHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateComptrRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateComptrRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConfigRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConfigRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConfigurableScreenAppliesToRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConfigurableScreenAppliesToRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConfigurableScreenDeltaRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConfigurableScreenDeltaRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConnectionConfigFieldRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConnectionConfigFieldRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConsentPersonRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConsentPersonRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConsentPurposeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConsentPurposeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConsentSourceRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateConsentSourceRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateContactInterestRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateContactInterestRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateContactRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateContactRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateContIntGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateContIntGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateContIntHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateContIntHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateContIntRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateContIntRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCounterValueRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCounterValueRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCountryGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCountryGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCountryHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCountryHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCountryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCountryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCredentialsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCredentialsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCreditedGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCreditedGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCreditedHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCreditedHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCreditedRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCreditedRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCurrencyGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCurrencyGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCurrencyHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCurrencyHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCurrencyRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCurrencyRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCustCategoryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCustCategoryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCustConfigRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCustConfigRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCustLangRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateCustLangRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDashboardRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDashboardRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDashboardThemeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDashboardThemeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDashboardTileDefinitionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDashboardTileDefinitionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDashboardTileFieldRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDashboardTileFieldRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDashboardTileRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDashboardTileRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDatabaseModelRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDatabaseModelRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDataRightRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDataRightRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDbiAgentFieldRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDbiAgentFieldRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDbiAgentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDbiAgentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDbiAgentScheduleRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDbiAgentScheduleRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDeliveryTermsGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDeliveryTermsGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDeliveryTermsHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDeliveryTermsHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDeliveryTermsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDeliveryTermsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDeliveryTypeGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDeliveryTypeGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDeliveryTypeHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDeliveryTypeHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDeliveryTypeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDeliveryTypeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDiaryViewRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDiaryViewRowRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDiaryViewRowRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDiaryViewRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDictionaryBaseRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDictionaryBaseRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDictionaryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDictionaryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDocDocumentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDocDocumentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDocFolderRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDocFolderRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDocTmplGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDocTmplGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDocTmplHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDocTmplHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDocTmplRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDocTmplRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDocumentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateDocumentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEabEntryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEabEntryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEabFolderRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEabFolderRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjCategoryGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjCategoryGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjCategoryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjCategoryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjMessageRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjMessageRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjpackageItemRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjpackageItemRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjpackageRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjpackageRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjRoleRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjRoleRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjscriptDebugRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjscriptDebugRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjscriptRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjscriptRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselectionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselectionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselEjselRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselEjselRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselMetaResultRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselMetaResultRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselResultSetRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselResultSetRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselSourceIdlistRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselSourceIdlistRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselSourceScriptRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselSourceScriptRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselSourceXmlRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjselSourceXmlRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjuserRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEjuserRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateElementProfileRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateElementProfileRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailAccountRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailAccountRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailAttachmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailAttachmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailFolderRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailFolderRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailItemRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailItemRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpConfigurationRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpConfigurationRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpConnectionAccessRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpConnectionAccessRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpConnectionActorTypeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpConnectionActorTypeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpConnectionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpConnectionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpConnectorRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpConnectorRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpExternalKeyRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpExternalKeyRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpFieldRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpFieldRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpInternalKeyRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpInternalKeyRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpListItemMappingRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpListItemMappingRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpSyncLogRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateErpSyncLogRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtAppGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtAppGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtAppHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtAppHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtAppRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtAppRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtDatasourceRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtDatasourceRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExternalDocumentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExternalDocumentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExternalEventRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExternalEventRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtFieldRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtFieldRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtraFieldsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtraFieldsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtraMenusRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtraMenusRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtraTablesEntryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtraTablesEntryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtraTablesResultRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtraTablesResultRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtraTablesRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtraTablesRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtTableRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateExtTableRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFavouriteRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFavouriteRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFieldLabelRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFieldLabelRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateForeignAppRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateForeignAppRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateForeignDeviceRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateForeignDeviceRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateForeignKeyRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateForeignKeyRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFormKeysRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFormKeysRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFormRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFormRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFormSubmissionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFormSubmissionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFreeTextIndexRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFreeTextIndexRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFreeTextStopWordsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFreeTextStopWordsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFreeTextWordsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFreeTextWordsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFunctionRightRoleLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFunctionRightRoleLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFunctionRightRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateFunctionRightRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateHeadingRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateHeadingRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateHelpRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateHelpRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateHierarchyRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateHierarchyRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateHistoryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateHistoryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateHotlistRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateHotlistRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateImportDefaultRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateImportDefaultRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateImportFieldRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateImportFieldRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateImportObjectRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateImportObjectRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateImportRelationRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateImportRelationRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateInboxRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateInboxRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateIntentGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateIntentGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateIntentHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateIntentHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateIntentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateIntentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateInvitationRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateInvitationRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateInvoiceEntryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateInvoiceEntryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateInvoiceRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateInvoiceRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateInvoiceSumRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateInvoiceSumRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateInvoiceTypeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateInvoiceTypeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateItemConfigRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateItemConfigRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbAttachmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbAttachmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbCategoryLogRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbCategoryLogRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbCategoryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbCategoryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbEntryCommentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbEntryCommentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbEntryKeywordRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbEntryKeywordRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbEntryLogRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbEntryLogRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbEntryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbEntryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbEntryWordsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbEntryWordsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbGroupEntryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbGroupEntryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbGroupRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbGroupRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbHttpLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbHttpLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbSolutionFinderEntryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbSolutionFinderEntryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbSolutionFinderRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbSolutionFinderRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbWorkflowAccessRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbWorkflowAccessRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbWorkflowRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateKbWorkflowRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLanguageInfoCountryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLanguageInfoCountryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLanguageInfoRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLanguageInfoRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLegalBaseRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLegalBaseRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLegalHtmlTagsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLegalHtmlTagsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLicenseAssocLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLicenseAssocLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLicenseSatlLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLicenseSatlLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLocaleTextRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLocaleTextRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLockingRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLockingRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLogDebugRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLogDebugRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLogEventsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLogEventsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLoginCustomerRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLoginCustomerRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLoginRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateLoginRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMailAliasRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMailAliasRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMailBlockRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMailBlockRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMailInFilterRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMailInFilterRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMailInUidlRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMailInUidlRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMergeMoveLogRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMergeMoveLogRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMessageCustomersRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMessageCustomersRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMessageHandlerRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMessageHandlerRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMessageHeaderRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMessageHeaderRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMessageIdRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMessageIdRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMessageRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMessageRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateModuleLicenseRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateModuleLicenseRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateModuleOwnerRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateModuleOwnerRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMrMrsGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMrMrsGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMrMrsHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMrMrsHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMrMrsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMrMrsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMsFilterMailRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMsFilterMailRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMsFilterRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMsFilterRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMsSubstituteRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMsSubstituteRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMsTrashbinRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateMsTrashbinRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateNoticeFrameRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateNoticeFrameRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateNotifyRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateNotifyRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEFieldRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEFieldRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEFieldTextRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEFieldTextRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOLESubjectRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOLESubjectRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOLESubjectTextRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOLESubjectTextRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEViewRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEViewRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEViewTextRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOLEViewTextRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOnlineAppRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOnlineAppRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOutboxRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOutboxRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOutgoingMessageRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOutgoingMessageRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOwnerContactLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateOwnerContactLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePasswordRulesRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePasswordRulesRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePaymentTermsGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePaymentTermsGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePaymentTermsHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePaymentTermsHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePaymentTermsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePaymentTermsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePaymentTypeGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePaymentTypeGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePaymentTypeHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePaymentTypeHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePaymentTypeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePaymentTypeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersIntGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersIntGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersIntHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersIntHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersIntRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersIntRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersonInterestRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersonInterestRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersonRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersonRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersPosGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersPosGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersPosHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersPosHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersPosRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePersPosRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePhoneFormatRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePhoneFormatRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePhoneRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePhoneRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePMembTypeGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePMembTypeGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePMembTypeHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePMembTypeHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePMembTypeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePMembTypeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePrefDescLineRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePrefDescLineRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePrefDescRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePrefDescRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePreferenceRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePreferenceRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriceListRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriceListRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriceUnitGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriceUnitGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriceUnitHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriceUnitHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriceUnitRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriceUnitRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriorityGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriorityGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriorityHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriorityHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriorityRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePriorityRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProbGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProbGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProbHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProbHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProbRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProbRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductCategoryGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductCategoryGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductCategoryHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductCategoryHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductCategoryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductCategoryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductFamilyGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductFamilyGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductFamilyHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductFamilyHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductFamilyRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductFamilyRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductTypeGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductTypeGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductTypeHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductTypeHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductTypeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductTypeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductVersionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProductVersionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProfileRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProfileRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjectMemberRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjectMemberRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjectRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjectRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjectTypeStatusLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjectTypeStatusLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjStatusGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjStatusGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjStatusHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjStatusHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjStatusRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjStatusRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjTypeGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjTypeGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjTypeHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjTypeHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjTypeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateProjTypeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePublishRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePublishRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePushNotificationServiceRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivatePushNotificationServiceRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuickReplyRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuickReplyRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteAlternativeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteAlternativeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteApprReasonGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteApprReasonGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteApprReasonHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteApprReasonHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteApprReasonRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteApprReasonRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteConnectionAccessRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteConnectionAccessRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteConnectionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteConnectionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteDenyReasonGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteDenyReasonGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteDenyReasonHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteDenyReasonHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteDenyReasonRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteDenyReasonRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteLineConfigurationRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteLineConfigurationRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteLineRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteLineRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteVersionAttachmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteVersionAttachmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteVersionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateQuoteVersionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonSoldGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonSoldGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonSoldHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonSoldHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonSoldRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonSoldRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonStalledGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonStalledGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonStalledHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonStalledHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonStalledRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReasonStalledRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRecurrenceRuleRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRecurrenceRuleRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRedLetterDayRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRedLetterDayRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRefCountRangeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRefCountRangeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRefCountsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRefCountsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRegistryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRegistryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRejectReasonGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRejectReasonGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRejectReasonHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRejectReasonHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRejectReasonRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRejectReasonRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRelationDefinitionGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRelationDefinitionGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRelationDefinitionHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRelationDefinitionHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRelationDefinitionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRelationDefinitionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRelationsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRelationsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRelationTargetRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRelationTargetRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReplyTemplateAttachmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReplyTemplateAttachmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReplyTemplateBodyRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReplyTemplateBodyRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReplyTemplateFolderRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReplyTemplateFolderRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReplyTemplateRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReplyTemplateRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReporterListDefRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateReporterListDefRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateResourceOverrideRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateResourceOverrideRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRoleCategoryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRoleCategoryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRoleElementRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRoleElementRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRoleMemberRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRoleMemberRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRoleRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRoleRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRoleWorkflowRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateRoleWorkflowRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaintConfigurationRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaintConfigurationRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleHistRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleHistRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleStakeholderRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleStakeholderRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeCatGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeCatGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeCatHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeCatHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeCatRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeCatRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeQuoteAttachmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeQuoteAttachmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeStageLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSaleTypeStageLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSalutationGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSalutationGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSalutationHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSalutationHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSalutationRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSalutationRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSatelliteRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSatelliteRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSAttachmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSAttachmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSBounceShipmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSBounceShipmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScheduledTaskRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScheduledTaskRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScheduleRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScheduleRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScreenChooserRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScreenChooserRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScreenDefinitionActionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScreenDefinitionActionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScreenDefinitionElementRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScreenDefinitionElementRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScreenDefinitionHiddenRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScreenDefinitionHiddenRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScreenDefinitionLanguageRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScreenDefinitionLanguageRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScreenDefinitionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScreenDefinitionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScriptTraceRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScriptTraceRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScriptTraceRunRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateScriptTraceRunRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSDynCriteriaRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSDynCriteriaRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCatGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCatGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCatHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCatHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCatRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCatRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCriteriaGroupRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCriteriaGroupRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCriteriaRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCriteriaRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCriterionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCriterionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCriterionValueRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSearchCriterionValueRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSelectionMemberRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSelectionMemberRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSelectionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSelectionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSequenceRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSequenceRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateServiceAuthRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateServiceAuthRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSessionObjectRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSessionObjectRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateShipmentTypeReservationRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateShipmentTypeReservationRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateShipmentTypeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateShipmentTypeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSLinkCustomerRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSLinkCustomerRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSLinkCustomerStaticalRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSLinkCustomerStaticalRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSListCustomerRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSListCustomerRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSListElementRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSListElementRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSListRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSListRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSListShipmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSListShipmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSMessageblockRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSMessageblockRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSMessageRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSMessageRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSmsHysteriaRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSmsHysteriaRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSmsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSmsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSnapshotRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSnapshotRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSoapAccessRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSoapAccessRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORCriteriaRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORCriteriaRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORFCTRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORFCTRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORFieldRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORFieldRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORLabelLayoutRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORLabelLayoutRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSOROperatorsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSOROperatorsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORPublishGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORPublishGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORPublishRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORPublishRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORSectionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORSectionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORTemplateRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSORTemplateRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSourceGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSourceGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSourceHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSourceHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSourceRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSourceRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSPictureEntryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSPictureEntryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSPictureFolderRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSPictureFolderRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSSentMessageRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSSentMessageRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSShipmentAddrRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSShipmentAddrRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSShipmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSShipmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSSmtpServersRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSSmtpServersRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateStakeholderRoleGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateStakeholderRoleGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateStakeholderRoleHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateStakeholderRoleHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateStakeholderRoleRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateStakeholderRoleRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateStaticListRefRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateStaticListRefRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateStatusDefRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateStatusDefRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateStatusValueRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateStatusValueRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSubscriptionUnitGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSubscriptionUnitGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSubscriptionUnitHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSubscriptionUnitHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSubscriptionUnitRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSubscriptionUnitRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSuggestedAppointmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSuggestedAppointmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSuggestedDocumentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSuggestedDocumentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSuperListColumnSizeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSuperListColumnSizeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSWashingListRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSWashingListRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSWashingRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSWashingRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSystemEventRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSystemEventRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSystemScriptRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateSystemScriptRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTabOrderRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTabOrderRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTagsGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTagsGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTagsHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTagsHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTagsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTagsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetAssignmentInfoRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetAssignmentInfoRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetAssignmentValueRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetAssignmentValueRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetChangeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetChangeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetDimensionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetDimensionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetGroupRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetGroupRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetPeriodRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetPeriodRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetRevisionHistoryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetRevisionHistoryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetRevisionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTargetRevisionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTaskGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTaskGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTaskHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTaskHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTaskRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTaskRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTemporaryKeyRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTemporaryKeyRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTemporaryWordsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTemporaryWordsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTextRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTextRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketAlertRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketAlertRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketAttachmentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketAttachmentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketCustomersRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketCustomersRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketLogActionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketLogActionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketLogChangeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketLogChangeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketLogRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketLogRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketPriorityRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketPriorityRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationActionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationActionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationTypeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationTypeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketStatusHistoryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketStatusHistoryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketStatusRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketStatusRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketTypeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketTypeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTimestampsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTimestampsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTravelCurrentRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTravelCurrentRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTravelGeneratedDatabaseRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTravelGeneratedDatabaseRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTravelGeneratedTransactionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTravelGeneratedTransactionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTravelIDMappingRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTravelIDMappingRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTravellerRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTravellerRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTravelTransactionLogRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTravelTransactionLogRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTrayAppRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTrayAppRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTreeExplorerEntryRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTreeExplorerEntryRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTreeExplorerLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTreeExplorerLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTypicalSearchRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTypicalSearchRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTZDstRuleRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTZDstRuleRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTZLocationRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTZLocationRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTZStdRuleRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateTZStdRuleRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDAppntLargeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDAppntLargeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDAppntSmallRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDAppntSmallRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDContactLargeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDContactLargeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDContactSmallRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDContactSmallRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDDocLargeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDDocLargeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDDocSmallRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDDocSmallRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDefFieldGLRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDefFieldGLRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDefFieldRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDefFieldRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDListDefinitionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDListDefinitionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDListGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDListGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDListHeadingLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDListHeadingLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDListRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDListRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDPersonLargeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDPersonLargeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDPersonSmallRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDPersonSmallRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDProjectLargeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDProjectLargeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDProjectSmallRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDProjectSmallRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDSaleLargeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDSaleLargeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDSaleSmallRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDSaleSmallRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDTempLargeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDTempLargeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDTempSmallRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUDTempSmallRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateURLRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateURLRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUsageStatsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUsageStatsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUserAttributeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUserAttributeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUserCandidateRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUserCandidateRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUserGroupLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUserGroupLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUserGroupRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUserGroupRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUserPreferenceRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUserPreferenceRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUserRoleLinkRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateUserRoleLinkRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateVisibleForRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateVisibleForRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateWebAppUsageRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateWebAppUsageRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateWebhookRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateWebhookRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateWebhookUsageRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateWebhookUsageRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateWinPosSizeRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateWinPosSizeRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateWordRelationsRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateWordRelationsRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateWsdlDescriptionRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateWsdlDescriptionRowsFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateZipToCityRowFactory is Modified


#### SuperOffice.CRM.Rows.PrivateFactory.PrivateZipToCityRowsFactory is Modified


#### SuperOffice.CRM.Rows.ProbGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProbGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProbGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProbGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProbGroupLinkRow.IdxProbgrouplinkId is Modified



##### SuperOffice.CRM.Rows.ProbGroupLinkRow.ProbGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProbGroupLinkRow.ProbGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProbGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProbGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProbGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.ProbGroupLinkRows.IdxProbId is Modified



##### SuperOffice.CRM.Rows.ProbGroupLinkRows.ProbGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProbHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProbHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProbHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProbHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProbHeadingLinkRow.IdxProbheadinglinkId is Modified



##### SuperOffice.CRM.Rows.ProbHeadingLinkRow.ProbHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProbHeadingLinkRow.ProbHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProbHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProbHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProbHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.ProbHeadingLinkRows.IdxProbId is Modified



##### SuperOffice.CRM.Rows.ProbHeadingLinkRows.ProbHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProbRecordData is Modified


#### SuperOffice.CRM.Rows.ProbRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProbRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProbRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProbRow.IdxName is Modified



##### SuperOffice.CRM.Rows.ProbRow.IdxProbId is Modified



##### SuperOffice.CRM.Rows.ProbRow.ProbRowIdx is Modified



##### SuperOffice.CRM.Rows.ProbRow.ProbRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProbRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProbRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProbRows.ProbRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRow.IdxProductCategoryGroupLinkId is Modified



##### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRow.ProductCategoryGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRow.ProductCategoryGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRows.IdxProductCategoryId is Modified



##### SuperOffice.CRM.Rows.ProductCategoryGroupLinkRows.ProductCategoryGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRow.IdxProductCategoryHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRow.ProductCategoryHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRow.ProductCategoryHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRows.IdxProductCategoryId is Modified



##### SuperOffice.CRM.Rows.ProductCategoryHeadingLinkRows.ProductCategoryHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProductCategoryRecordData is Modified


#### SuperOffice.CRM.Rows.ProductCategoryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProductCategoryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductCategoryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductCategoryRow.IdxName is Modified



##### SuperOffice.CRM.Rows.ProductCategoryRow.IdxProductCategoryId is Modified



##### SuperOffice.CRM.Rows.ProductCategoryRow.ProductCategoryRowIdx is Modified



##### SuperOffice.CRM.Rows.ProductCategoryRow.ProductCategoryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProductCategoryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductCategoryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductCategoryRows.ProductCategoryRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRow.IdxProductFamilyGroupLinkId is Modified



##### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRow.ProductFamilyGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRow.ProductFamilyGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRows.IdxProductFamilyId is Modified



##### SuperOffice.CRM.Rows.ProductFamilyGroupLinkRows.ProductFamilyGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRow.IdxProductFamilyHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRow.ProductFamilyHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRow.ProductFamilyHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRows.IdxProductFamilyId is Modified



##### SuperOffice.CRM.Rows.ProductFamilyHeadingLinkRows.ProductFamilyHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProductFamilyRecordData is Modified


#### SuperOffice.CRM.Rows.ProductFamilyRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProductFamilyRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductFamilyRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductFamilyRow.IdxName is Modified



##### SuperOffice.CRM.Rows.ProductFamilyRow.IdxProductFamilyId is Modified



##### SuperOffice.CRM.Rows.ProductFamilyRow.ProductFamilyRowIdx is Modified



##### SuperOffice.CRM.Rows.ProductFamilyRow.ProductFamilyRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProductFamilyRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductFamilyRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductFamilyRows.ProductFamilyRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProductRecordData is Modified


#### SuperOffice.CRM.Rows.ProductRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProductRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductRow.IdxProductId is Modified



##### SuperOffice.CRM.Rows.ProductRow.ProductRowIdx is Modified



##### SuperOffice.CRM.Rows.ProductRow.ProductRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProductRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductRows.IdxERPProductKey is Modified



##### SuperOffice.CRM.Rows.ProductRows.IdxPriceListId is Modified



##### SuperOffice.CRM.Rows.ProductRows.ProductRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProductTypeGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProductTypeGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProductTypeGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductTypeGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductTypeGroupLinkRow.IdxProductTypeGroupLinkId is Modified



##### SuperOffice.CRM.Rows.ProductTypeGroupLinkRow.ProductTypeGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProductTypeGroupLinkRow.ProductTypeGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProductTypeGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductTypeGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductTypeGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.ProductTypeGroupLinkRows.IdxProductTypeId is Modified



##### SuperOffice.CRM.Rows.ProductTypeGroupLinkRows.ProductTypeGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRow.IdxProductTypeHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRow.ProductTypeHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRow.ProductTypeHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRows.IdxProductTypeId is Modified



##### SuperOffice.CRM.Rows.ProductTypeHeadingLinkRows.ProductTypeHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProductTypeRecordData is Modified


#### SuperOffice.CRM.Rows.ProductTypeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProductTypeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductTypeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductTypeRow.IdxName is Modified



##### SuperOffice.CRM.Rows.ProductTypeRow.IdxProductTypeId is Modified



##### SuperOffice.CRM.Rows.ProductTypeRow.ProductTypeRowIdx is Modified



##### SuperOffice.CRM.Rows.ProductTypeRow.ProductTypeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProductTypeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductTypeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductTypeRows.ProductTypeRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProductVersionRecordData is Modified


#### SuperOffice.CRM.Rows.ProductVersionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProductVersionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductVersionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductVersionRow.IdxOwnerNameCodeNameVersion is Modified



##### SuperOffice.CRM.Rows.ProductVersionRow.IdxProductVersionId is Modified



##### SuperOffice.CRM.Rows.ProductVersionRow.ProductVersionRowIdx is Modified



##### SuperOffice.CRM.Rows.ProductVersionRow.ProductVersionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProductVersionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProductVersionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProductVersionRows.IdxOwnerName is Modified



##### SuperOffice.CRM.Rows.ProductVersionRows.IdxOwnerNameCodeName is Modified



##### SuperOffice.CRM.Rows.ProductVersionRows.ProductVersionRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProfileRecordData is Modified


#### SuperOffice.CRM.Rows.ProfileRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProfileRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProfileRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProfileRow.IdxProfileId is Modified



##### SuperOffice.CRM.Rows.ProfileRow.ProfileRowIdx is Modified



##### SuperOffice.CRM.Rows.ProfileRow.ProfileRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProfileRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProfileRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProfileRows.IdxUserId is Modified



##### SuperOffice.CRM.Rows.ProfileRows.ProfileRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProjectMemberRecordData is Modified


#### SuperOffice.CRM.Rows.ProjectMemberRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProjectMemberRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjectMemberRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjectMemberRow.IdxProjectmemberId is Modified



##### SuperOffice.CRM.Rows.ProjectMemberRow.ProjectMemberRowIdx is Modified



##### SuperOffice.CRM.Rows.ProjectMemberRow.ProjectMemberRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProjectMemberRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjectMemberRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjectMemberRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.ProjectMemberRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.ProjectMemberRows.IdxProjectId is Modified



##### SuperOffice.CRM.Rows.ProjectMemberRows.IdxProjectIdRank is Modified



##### SuperOffice.CRM.Rows.ProjectMemberRows.ProjectMemberRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProjectRecordData is Modified


#### SuperOffice.CRM.Rows.ProjectRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProjectRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjectRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjectRow.IdxProjectId is Modified



##### SuperOffice.CRM.Rows.ProjectRow.ProjectRowIdx is Modified



##### SuperOffice.CRM.Rows.ProjectRow.ProjectRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProjectRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjectRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjectRows.IdxDone is Modified



##### SuperOffice.CRM.Rows.ProjectRows.IdxName is Modified



##### SuperOffice.CRM.Rows.ProjectRows.IdxProjectNumber is Modified



##### SuperOffice.CRM.Rows.ProjectRows.IdxSoundEx is Modified



##### SuperOffice.CRM.Rows.ProjectRows.IdxSource is Modified



##### SuperOffice.CRM.Rows.ProjectRows.IdxUserdef2Id is Modified



##### SuperOffice.CRM.Rows.ProjectRows.ProjectRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRow.IdxProjectTypeStatusLinkId is Modified



##### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRow.ProjectTypeStatusLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRow.ProjectTypeStatusLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRows.IdxProjTypeId is Modified



##### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRows.IdxProjTypeIdProjStatusId is Modified



##### SuperOffice.CRM.Rows.ProjectTypeStatusLinkRows.ProjectTypeStatusLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProjStatusGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProjStatusGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProjStatusGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjStatusGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjStatusGroupLinkRow.IdxProjstatusgrouplinkId is Modified



##### SuperOffice.CRM.Rows.ProjStatusGroupLinkRow.ProjStatusGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProjStatusGroupLinkRow.ProjStatusGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProjStatusGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjStatusGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjStatusGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.ProjStatusGroupLinkRows.IdxProjStatusId is Modified



##### SuperOffice.CRM.Rows.ProjStatusGroupLinkRows.ProjStatusGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRow.IdxProjstatusheadinglinkId is Modified



##### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRow.ProjStatusHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRow.ProjStatusHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRows.IdxProjStatusId is Modified



##### SuperOffice.CRM.Rows.ProjStatusHeadingLinkRows.ProjStatusHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProjStatusRecordData is Modified


#### SuperOffice.CRM.Rows.ProjStatusRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProjStatusRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjStatusRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjStatusRow.IdxName is Modified



##### SuperOffice.CRM.Rows.ProjStatusRow.IdxProjStatusId is Modified



##### SuperOffice.CRM.Rows.ProjStatusRow.ProjStatusRowIdx is Modified



##### SuperOffice.CRM.Rows.ProjStatusRow.ProjStatusRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProjStatusRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjStatusRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjStatusRows.ProjStatusRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProjTypeGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProjTypeGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProjTypeGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjTypeGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjTypeGroupLinkRow.IdxProjtypegrouplinkId is Modified



##### SuperOffice.CRM.Rows.ProjTypeGroupLinkRow.ProjTypeGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProjTypeGroupLinkRow.ProjTypeGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProjTypeGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjTypeGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjTypeGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.ProjTypeGroupLinkRows.IdxProjTypeId is Modified



##### SuperOffice.CRM.Rows.ProjTypeGroupLinkRows.ProjTypeGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRow.IdxProjtypeheadinglinkId is Modified



##### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRow.ProjTypeHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRow.ProjTypeHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRows.IdxProjTypeId is Modified



##### SuperOffice.CRM.Rows.ProjTypeHeadingLinkRows.ProjTypeHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ProjTypeRecordData is Modified


#### SuperOffice.CRM.Rows.ProjTypeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ProjTypeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjTypeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjTypeRow.IdxName is Modified



##### SuperOffice.CRM.Rows.ProjTypeRow.IdxProjTypeId is Modified



##### SuperOffice.CRM.Rows.ProjTypeRow.ProjTypeRowIdx is Modified



##### SuperOffice.CRM.Rows.ProjTypeRow.ProjTypeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ProjTypeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ProjTypeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ProjTypeRows.ProjTypeRowsIdx is Modified



#### SuperOffice.CRM.Rows.PublishRecordData is Modified


#### SuperOffice.CRM.Rows.PublishRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PublishRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PublishRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PublishRow.IdxPublishId is Modified



##### SuperOffice.CRM.Rows.PublishRow.IdxTableNumberRecordIdPublishType is Modified



##### SuperOffice.CRM.Rows.PublishRow.PublishRowIdx is Modified



##### SuperOffice.CRM.Rows.PublishRow.PublishRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PublishRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PublishRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PublishRows.IdxPublishType is Modified



##### SuperOffice.CRM.Rows.PublishRows.IdxTableNumber is Modified



##### SuperOffice.CRM.Rows.PublishRows.IdxTableNumberRecordId is Modified



##### SuperOffice.CRM.Rows.PublishRows.PublishRowsIdx is Modified



#### SuperOffice.CRM.Rows.PushNotificationServiceRecordData is Modified


#### SuperOffice.CRM.Rows.PushNotificationServiceRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.PushNotificationServiceRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.PushNotificationServiceRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PushNotificationServiceRow.IdxPushNotificationServiceId is Modified



##### SuperOffice.CRM.Rows.PushNotificationServiceRow.PushNotificationServiceRowIdx is Modified



##### SuperOffice.CRM.Rows.PushNotificationServiceRow.PushNotificationServiceRowIdxBase is Modified



#### SuperOffice.CRM.Rows.PushNotificationServiceRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.PushNotificationServiceRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.PushNotificationServiceRows.PushNotificationServiceRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuickReplyRecordData is Modified


#### SuperOffice.CRM.Rows.QuickReplyRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuickReplyRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuickReplyRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuickReplyRow.IdxQuickReplyId is Modified



##### SuperOffice.CRM.Rows.QuickReplyRow.QuickReplyRowIdx is Modified



##### SuperOffice.CRM.Rows.QuickReplyRow.QuickReplyRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuickReplyRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuickReplyRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuickReplyRows.IdxRank is Modified



##### SuperOffice.CRM.Rows.QuickReplyRows.QuickReplyRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteAlternativeRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteAlternativeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteAlternativeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteAlternativeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteAlternativeRow.IdxQuoteAlternativeId is Modified



##### SuperOffice.CRM.Rows.QuoteAlternativeRow.QuoteAlternativeRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteAlternativeRow.QuoteAlternativeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteAlternativeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteAlternativeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteAlternativeRows.IdxERPQuoteAlternativeKey is Modified



##### SuperOffice.CRM.Rows.QuoteAlternativeRows.IdxQuoteVersionId is Modified



##### SuperOffice.CRM.Rows.QuoteAlternativeRows.QuoteAlternativeRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRow.IdxQuoteApprReasonGroupLinkId is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRow.QuoteApprReasonGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRow.QuoteApprReasonGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRows.IdxQuoteapprreasonId is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonGroupLinkRows.QuoteApprReasonGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRow.IdxQuoteApprReasonHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRow.QuoteApprReasonHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRow.QuoteApprReasonHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRows.IdxQuoteapprreasonId is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonHeadingLinkRows.QuoteApprReasonHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteApprReasonRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteApprReasonRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteApprReasonRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteApprReasonRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonRow.IdxName is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonRow.IdxQuoteApprReasonId is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonRow.QuoteApprReasonRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonRow.QuoteApprReasonRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteApprReasonRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteApprReasonRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteApprReasonRows.QuoteApprReasonRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteConnectionAccessRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteConnectionAccessRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteConnectionAccessRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteConnectionAccessRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteConnectionAccessRow.IdxQuoteConnectionAccessId is Modified



##### SuperOffice.CRM.Rows.QuoteConnectionAccessRow.QuoteConnectionAccessRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteConnectionAccessRow.QuoteConnectionAccessRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteConnectionAccessRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteConnectionAccessRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteConnectionAccessRows.QuoteConnectionAccessRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteConnectionRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteConnectionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteConnectionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteConnectionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteConnectionRow.IdxQuoteConnectionId is Modified



##### SuperOffice.CRM.Rows.QuoteConnectionRow.QuoteConnectionRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteConnectionRow.QuoteConnectionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteConnectionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteConnectionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteConnectionRows.QuoteConnectionRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRow.IdxQuoteDenyReasonGroupLinkId is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRow.QuoteDenyReasonGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRow.QuoteDenyReasonGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRows.IdxQuotedenyreasonId is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonGroupLinkRows.QuoteDenyReasonGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRow.IdxQuoteDenyReasonHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRow.QuoteDenyReasonHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRow.QuoteDenyReasonHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRows.IdxQuotedenyreasonId is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonHeadingLinkRows.QuoteDenyReasonHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteDenyReasonRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteDenyReasonRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteDenyReasonRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteDenyReasonRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonRow.IdxName is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonRow.IdxQuoteDenyReasonId is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonRow.QuoteDenyReasonRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonRow.QuoteDenyReasonRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteDenyReasonRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteDenyReasonRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteDenyReasonRows.QuoteDenyReasonRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteLineConfigurationRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteLineConfigurationRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteLineConfigurationRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteLineConfigurationRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteLineConfigurationRow.IdxQuoteLineConfigurationId is Modified



##### SuperOffice.CRM.Rows.QuoteLineConfigurationRow.QuoteLineConfigurationRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteLineConfigurationRow.QuoteLineConfigurationRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteLineConfigurationRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteLineConfigurationRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteLineConfigurationRows.QuoteLineConfigurationRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteLineRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteLineRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteLineRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteLineRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteLineRow.IdxQuoteLineId is Modified



##### SuperOffice.CRM.Rows.QuoteLineRow.QuoteLineRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteLineRow.QuoteLineRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteLineRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteLineRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteLineRows.IdxQuoteAlternativeId is Modified



##### SuperOffice.CRM.Rows.QuoteLineRows.QuoteLineRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteRow.IdxQuoteId is Modified



##### SuperOffice.CRM.Rows.QuoteRow.QuoteRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteRow.QuoteRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteRows.QuoteRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteVersionAttachmentRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteVersionAttachmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteVersionAttachmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteVersionAttachmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteVersionAttachmentRow.IdxQuoteVersionAttachmentId is Modified



##### SuperOffice.CRM.Rows.QuoteVersionAttachmentRow.IdxQuoteVersionIdDocumentId is Modified



##### SuperOffice.CRM.Rows.QuoteVersionAttachmentRow.QuoteVersionAttachmentRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteVersionAttachmentRow.QuoteVersionAttachmentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteVersionAttachmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteVersionAttachmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteVersionAttachmentRows.IdxQuoteVersionId is Modified



##### SuperOffice.CRM.Rows.QuoteVersionAttachmentRows.QuoteVersionAttachmentRowsIdx is Modified



#### SuperOffice.CRM.Rows.QuoteVersionRecordData is Modified


#### SuperOffice.CRM.Rows.QuoteVersionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.QuoteVersionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteVersionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteVersionRow.IdxQuoteVersionId is Modified



##### SuperOffice.CRM.Rows.QuoteVersionRow.QuoteVersionRowIdx is Modified



##### SuperOffice.CRM.Rows.QuoteVersionRow.QuoteVersionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.QuoteVersionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.QuoteVersionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.QuoteVersionRows.IdxERPQuoteVersionKey is Modified



##### SuperOffice.CRM.Rows.QuoteVersionRows.IdxQuoteId is Modified



##### SuperOffice.CRM.Rows.QuoteVersionRows.QuoteVersionRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReasonGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ReasonGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReasonGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonGroupLinkRow.IdxReasongrouplinkId is Modified



##### SuperOffice.CRM.Rows.ReasonGroupLinkRow.ReasonGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ReasonGroupLinkRow.ReasonGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReasonGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.ReasonGroupLinkRows.IdxReasonId is Modified



##### SuperOffice.CRM.Rows.ReasonGroupLinkRows.ReasonGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReasonHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ReasonHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReasonHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonHeadingLinkRow.IdxReasonheadinglinkId is Modified



##### SuperOffice.CRM.Rows.ReasonHeadingLinkRow.ReasonHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ReasonHeadingLinkRow.ReasonHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReasonHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.ReasonHeadingLinkRows.IdxReasonId is Modified



##### SuperOffice.CRM.Rows.ReasonHeadingLinkRows.ReasonHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReasonRecordData is Modified


#### SuperOffice.CRM.Rows.ReasonRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReasonRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonRow.IdxName is Modified



##### SuperOffice.CRM.Rows.ReasonRow.IdxReasonId is Modified



##### SuperOffice.CRM.Rows.ReasonRow.ReasonRowIdx is Modified



##### SuperOffice.CRM.Rows.ReasonRow.ReasonRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReasonRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonRows.ReasonRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRow.IdxReasonSoldGroupLinkId is Modified



##### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRow.ReasonSoldGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRow.ReasonSoldGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRows.IdxReasonSoldId is Modified



##### SuperOffice.CRM.Rows.ReasonSoldGroupLinkRows.ReasonSoldGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRow.IdxReasonSoldHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRow.ReasonSoldHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRow.ReasonSoldHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRows.IdxReasonSoldId is Modified



##### SuperOffice.CRM.Rows.ReasonSoldHeadingLinkRows.ReasonSoldHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReasonSoldRecordData is Modified


#### SuperOffice.CRM.Rows.ReasonSoldRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReasonSoldRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonSoldRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonSoldRow.IdxName is Modified



##### SuperOffice.CRM.Rows.ReasonSoldRow.IdxReasonSoldId is Modified



##### SuperOffice.CRM.Rows.ReasonSoldRow.ReasonSoldRowIdx is Modified



##### SuperOffice.CRM.Rows.ReasonSoldRow.ReasonSoldRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReasonSoldRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonSoldRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonSoldRows.ReasonSoldRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRow.IdxReasonStalledGroupLinkId is Modified



##### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRow.ReasonStalledGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRow.ReasonStalledGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRows.IdxReasonStalledId is Modified



##### SuperOffice.CRM.Rows.ReasonStalledGroupLinkRows.ReasonStalledGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRow.IdxReasonStalledHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRow.ReasonStalledHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRow.ReasonStalledHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRows.IdxReasonStalledId is Modified



##### SuperOffice.CRM.Rows.ReasonStalledHeadingLinkRows.ReasonStalledHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReasonStalledRecordData is Modified


#### SuperOffice.CRM.Rows.ReasonStalledRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReasonStalledRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonStalledRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonStalledRow.IdxName is Modified



##### SuperOffice.CRM.Rows.ReasonStalledRow.IdxReasonStalledId is Modified



##### SuperOffice.CRM.Rows.ReasonStalledRow.ReasonStalledRowIdx is Modified



##### SuperOffice.CRM.Rows.ReasonStalledRow.ReasonStalledRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReasonStalledRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReasonStalledRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReasonStalledRows.ReasonStalledRowsIdx is Modified



#### SuperOffice.CRM.Rows.RecurrenceRuleRecordData is Modified


#### SuperOffice.CRM.Rows.RecurrenceRuleRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RecurrenceRuleRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RecurrenceRuleRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RecurrenceRuleRow.IdxRecurrenceRuleId is Modified



##### SuperOffice.CRM.Rows.RecurrenceRuleRow.RecurrenceRuleRowIdx is Modified



##### SuperOffice.CRM.Rows.RecurrenceRuleRow.RecurrenceRuleRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RecurrenceRuleRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RecurrenceRuleRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RecurrenceRuleRows.RecurrenceRuleRowsIdx is Modified



#### SuperOffice.CRM.Rows.RedLetterDayRecordData is Modified


#### SuperOffice.CRM.Rows.RedLetterDayRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RedLetterDayRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RedLetterDayRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RedLetterDayRow.IdxRedletterdayId is Modified



##### SuperOffice.CRM.Rows.RedLetterDayRow.RedLetterDayRowIdx is Modified



##### SuperOffice.CRM.Rows.RedLetterDayRow.RedLetterDayRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RedLetterDayRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RedLetterDayRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RedLetterDayRows.IdxCountryId is Modified



##### SuperOffice.CRM.Rows.RedLetterDayRows.IdxCountryIdReddate is Modified



##### SuperOffice.CRM.Rows.RedLetterDayRows.RedLetterDayRowsIdx is Modified



#### SuperOffice.CRM.Rows.RefCountRangeRecordData is Modified


#### SuperOffice.CRM.Rows.RefCountRangeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RefCountRangeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RefCountRangeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RefCountRangeRow.IdxRefCountRangeId is Modified



##### SuperOffice.CRM.Rows.RefCountRangeRow.RefCountRangeRowIdx is Modified



##### SuperOffice.CRM.Rows.RefCountRangeRow.RefCountRangeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RefCountRangeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RefCountRangeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RefCountRangeRows.IdxRefCountsId is Modified



##### SuperOffice.CRM.Rows.RefCountRangeRows.IdxTravellerId is Modified



##### SuperOffice.CRM.Rows.RefCountRangeRows.RefCountRangeRowsIdx is Modified



#### SuperOffice.CRM.Rows.RefCountsRecordData is Modified


#### SuperOffice.CRM.Rows.RefCountsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RefCountsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RefCountsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RefCountsRow.IdxRefCountsId is Modified



##### SuperOffice.CRM.Rows.RefCountsRow.RefCountsRowIdx is Modified



##### SuperOffice.CRM.Rows.RefCountsRow.RefCountsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RefCountsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RefCountsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RefCountsRows.IdxFieldId is Modified



##### SuperOffice.CRM.Rows.RefCountsRows.IdxFieldIdRecordId is Modified



##### SuperOffice.CRM.Rows.RefCountsRows.IdxRecordId is Modified



##### SuperOffice.CRM.Rows.RefCountsRows.RefCountsRowsIdx is Modified



#### SuperOffice.CRM.Rows.RegistryRecordData is Modified


#### SuperOffice.CRM.Rows.RegistryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RegistryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RegistryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RegistryRow.IdxRegistryId is Modified



##### SuperOffice.CRM.Rows.RegistryRow.RegistryRowIdx is Modified



##### SuperOffice.CRM.Rows.RegistryRow.RegistryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RegistryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RegistryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RegistryRows.RegistryRowsIdx is Modified



#### SuperOffice.CRM.Rows.RejectReasonGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.RejectReasonGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RejectReasonGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RejectReasonGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RejectReasonGroupLinkRow.IdxRejectreasongrouplinkId is Modified



##### SuperOffice.CRM.Rows.RejectReasonGroupLinkRow.RejectReasonGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.RejectReasonGroupLinkRow.RejectReasonGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RejectReasonGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RejectReasonGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RejectReasonGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.RejectReasonGroupLinkRows.IdxRejectreasonId is Modified



##### SuperOffice.CRM.Rows.RejectReasonGroupLinkRows.RejectReasonGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRow.IdxRejectreasonheadinglinkId is Modified



##### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRow.RejectReasonHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRow.RejectReasonHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRows.IdxRejectreasonId is Modified



##### SuperOffice.CRM.Rows.RejectReasonHeadingLinkRows.RejectReasonHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.RejectReasonRecordData is Modified


#### SuperOffice.CRM.Rows.RejectReasonRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RejectReasonRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RejectReasonRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RejectReasonRow.IdxName is Modified



##### SuperOffice.CRM.Rows.RejectReasonRow.IdxRejectReasonId is Modified



##### SuperOffice.CRM.Rows.RejectReasonRow.RejectReasonRowIdx is Modified



##### SuperOffice.CRM.Rows.RejectReasonRow.RejectReasonRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RejectReasonRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RejectReasonRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RejectReasonRows.RejectReasonRowsIdx is Modified



#### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRow.IdxReldefgrouplinkId is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRow.RelationDefinitionGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRow.RelationDefinitionGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRows.IdxReldefId is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionGroupLinkRows.RelationDefinitionGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRow.IdxReldefheadinglinkId is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRow.RelationDefinitionHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRow.RelationDefinitionHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRows.IdxReldefId is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionHeadingLinkRows.RelationDefinitionHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.RelationDefinitionRecordData is Modified


#### SuperOffice.CRM.Rows.RelationDefinitionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RelationDefinitionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RelationDefinitionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionRow.IdxReldefId is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionRow.RelationDefinitionRowIdx is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionRow.RelationDefinitionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RelationDefinitionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RelationDefinitionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RelationDefinitionRows.RelationDefinitionRowsIdx is Modified



#### SuperOffice.CRM.Rows.RelationsRecordData is Modified


#### SuperOffice.CRM.Rows.RelationsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RelationsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RelationsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RelationsRow.IdxRelationId is Modified



##### SuperOffice.CRM.Rows.RelationsRow.RelationsRowIdx is Modified



##### SuperOffice.CRM.Rows.RelationsRow.RelationsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RelationsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RelationsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RelationsRows.IdxDestinationRecord is Modified



##### SuperOffice.CRM.Rows.RelationsRows.IdxDestinationTable is Modified



##### SuperOffice.CRM.Rows.RelationsRows.IdxDestinationTableDestinationRecord is Modified



##### SuperOffice.CRM.Rows.RelationsRows.IdxDestinationTableDestinationRecordReversed is Modified



##### SuperOffice.CRM.Rows.RelationsRows.IdxReldefId is Modified



##### SuperOffice.CRM.Rows.RelationsRows.IdxReversed is Modified



##### SuperOffice.CRM.Rows.RelationsRows.IdxSourceRecord is Modified



##### SuperOffice.CRM.Rows.RelationsRows.IdxSourceTable is Modified



##### SuperOffice.CRM.Rows.RelationsRows.IdxSourceTableSourceRecord is Modified



##### SuperOffice.CRM.Rows.RelationsRows.IdxSourceTableSourceRecordReversed is Modified



##### SuperOffice.CRM.Rows.RelationsRows.RelationsRowsIdx is Modified



#### SuperOffice.CRM.Rows.RelationTargetRecordData is Modified


#### SuperOffice.CRM.Rows.RelationTargetRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RelationTargetRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RelationTargetRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RelationTargetRow.IdxReltargetId is Modified



##### SuperOffice.CRM.Rows.RelationTargetRow.RelationTargetRowIdx is Modified



##### SuperOffice.CRM.Rows.RelationTargetRow.RelationTargetRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RelationTargetRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RelationTargetRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RelationTargetRows.IdxBidirectional is Modified



##### SuperOffice.CRM.Rows.RelationTargetRows.IdxDestinationTable is Modified



##### SuperOffice.CRM.Rows.RelationTargetRows.IdxReldefId is Modified



##### SuperOffice.CRM.Rows.RelationTargetRows.IdxSourceTable is Modified



##### SuperOffice.CRM.Rows.RelationTargetRows.RelationTargetRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRecordData is Modified


#### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRow.IdxReplyTemplateAttachmentId is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRow.ReplyTemplateAttachmentRowIdx is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRow.ReplyTemplateAttachmentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRows.IdxAttachmentId is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRows.IdxEntryId is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateAttachmentRows.ReplyTemplateAttachmentRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReplyTemplateBodyRecordData is Modified


#### SuperOffice.CRM.Rows.ReplyTemplateBodyRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReplyTemplateBodyRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReplyTemplateBodyRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateBodyRow.IdxReplyTemplateBodyId is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateBodyRow.ReplyTemplateBodyRowIdx is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateBodyRow.ReplyTemplateBodyRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReplyTemplateBodyRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReplyTemplateBodyRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateBodyRows.IdxLanguageId is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateBodyRows.IdxReplyTemplateId is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateBodyRows.ReplyTemplateBodyRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReplyTemplateFolderRecordData is Modified


#### SuperOffice.CRM.Rows.ReplyTemplateFolderRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReplyTemplateFolderRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReplyTemplateFolderRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateFolderRow.IdxReplyTemplateFolderId is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateFolderRow.ReplyTemplateFolderRowIdx is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateFolderRow.ReplyTemplateFolderRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReplyTemplateFolderRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReplyTemplateFolderRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateFolderRows.IdxName is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateFolderRows.IdxParentId is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateFolderRows.ReplyTemplateFolderRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReplyTemplateRecordData is Modified


#### SuperOffice.CRM.Rows.ReplyTemplateRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReplyTemplateRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReplyTemplateRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateRow.IdxReplyTemplateId is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateRow.ReplyTemplateRowIdx is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateRow.ReplyTemplateRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReplyTemplateRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReplyTemplateRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateRows.IdxFolderId is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateRows.IdxName is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateRows.IdxOwnedBy is Modified



##### SuperOffice.CRM.Rows.ReplyTemplateRows.ReplyTemplateRowsIdx is Modified



#### SuperOffice.CRM.Rows.ReporterListDefRecordData is Modified


#### SuperOffice.CRM.Rows.ReporterListDefRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ReporterListDefRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReporterListDefRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReporterListDefRow.IdxReporterListDefId is Modified



##### SuperOffice.CRM.Rows.ReporterListDefRow.ReporterListDefRowIdx is Modified



##### SuperOffice.CRM.Rows.ReporterListDefRow.ReporterListDefRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ReporterListDefRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ReporterListDefRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ReporterListDefRows.IdxOleFieldKey is Modified



##### SuperOffice.CRM.Rows.ReporterListDefRows.IdxOleFieldName is Modified



##### SuperOffice.CRM.Rows.ReporterListDefRows.IdxOleViewId is Modified



##### SuperOffice.CRM.Rows.ReporterListDefRows.ReporterListDefRowsIdx is Modified



#### SuperOffice.CRM.Rows.ResourceOverrideRecordData is Modified


#### SuperOffice.CRM.Rows.ResourceOverrideRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ResourceOverrideRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ResourceOverrideRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ResourceOverrideRow.IdxResourceNameCulture is Modified



##### SuperOffice.CRM.Rows.ResourceOverrideRow.IdxResourceOverrideId is Modified



##### SuperOffice.CRM.Rows.ResourceOverrideRow.ResourceOverrideRowIdx is Modified



##### SuperOffice.CRM.Rows.ResourceOverrideRow.ResourceOverrideRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ResourceOverrideRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ResourceOverrideRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ResourceOverrideRows.IdxResourceName is Modified



##### SuperOffice.CRM.Rows.ResourceOverrideRows.ResourceOverrideRowsIdx is Modified



#### SuperOffice.CRM.Rows.RoleCategoryRecordData is Modified


#### SuperOffice.CRM.Rows.RoleCategoryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RoleCategoryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RoleCategoryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RoleCategoryRow.IdxRoleCategoryId is Modified



##### SuperOffice.CRM.Rows.RoleCategoryRow.RoleCategoryRowIdx is Modified



##### SuperOffice.CRM.Rows.RoleCategoryRow.RoleCategoryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RoleCategoryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RoleCategoryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RoleCategoryRows.IdxCategory is Modified



##### SuperOffice.CRM.Rows.RoleCategoryRows.IdxCrmRole is Modified



##### SuperOffice.CRM.Rows.RoleCategoryRows.IdxRole is Modified



##### SuperOffice.CRM.Rows.RoleCategoryRows.RoleCategoryRowsIdx is Modified



#### SuperOffice.CRM.Rows.RoleElementRecordData is Modified


#### SuperOffice.CRM.Rows.RoleElementRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RoleElementRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RoleElementRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RoleElementRow.IdxRoleElementId is Modified



##### SuperOffice.CRM.Rows.RoleElementRow.RoleElementRowIdx is Modified



##### SuperOffice.CRM.Rows.RoleElementRow.RoleElementRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RoleElementRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RoleElementRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RoleElementRows.IdxCrmRole is Modified



##### SuperOffice.CRM.Rows.RoleElementRows.IdxElementProfile is Modified



##### SuperOffice.CRM.Rows.RoleElementRows.IdxRole is Modified



##### SuperOffice.CRM.Rows.RoleElementRows.RoleElementRowsIdx is Modified



#### SuperOffice.CRM.Rows.RoleMemberRecordData is Modified


#### SuperOffice.CRM.Rows.RoleMemberRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RoleMemberRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RoleMemberRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RoleMemberRow.IdxRoleMemberId is Modified



##### SuperOffice.CRM.Rows.RoleMemberRow.RoleMemberRowIdx is Modified



##### SuperOffice.CRM.Rows.RoleMemberRow.RoleMemberRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RoleMemberRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RoleMemberRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RoleMemberRows.IdxEjuser is Modified



##### SuperOffice.CRM.Rows.RoleMemberRows.IdxRole is Modified



##### SuperOffice.CRM.Rows.RoleMemberRows.RoleMemberRowsIdx is Modified



#### SuperOffice.CRM.Rows.RoleRecordData is Modified


#### SuperOffice.CRM.Rows.RoleRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RoleRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RoleRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RoleRow.IdxRoleId is Modified



##### SuperOffice.CRM.Rows.RoleRow.RoleRowIdx is Modified



##### SuperOffice.CRM.Rows.RoleRow.RoleRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RoleRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RoleRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RoleRows.RoleRowsIdx is Modified



#### SuperOffice.CRM.Rows.RoleWorkflowRecordData is Modified


#### SuperOffice.CRM.Rows.RoleWorkflowRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.RoleWorkflowRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.RoleWorkflowRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RoleWorkflowRow.IdxRoleWorkflowId is Modified



##### SuperOffice.CRM.Rows.RoleWorkflowRow.RoleWorkflowRowIdx is Modified



##### SuperOffice.CRM.Rows.RoleWorkflowRow.RoleWorkflowRowIdxBase is Modified



#### SuperOffice.CRM.Rows.RoleWorkflowRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.RoleWorkflowRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.RoleWorkflowRows.IdxCrmRole is Modified



##### SuperOffice.CRM.Rows.RoleWorkflowRows.IdxRole is Modified



##### SuperOffice.CRM.Rows.RoleWorkflowRows.IdxWorkflowId is Modified



##### SuperOffice.CRM.Rows.RoleWorkflowRows.RoleWorkflowRowsIdx is Modified



#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(ArchiveBehaviour&, FieldInfo)`
  * Method `ValidateField(BatchTaskCancellationBehaviour&, FieldInfo)`
  * Method `ValidateField(ModifiedAppointmentFields&, FieldInfo)`
  * Method `ValidateField(ShowTaskItemInClient&, FieldInfo)`
  * Method `ValidateField(TaskListItemType&, FieldInfo)`

#### SuperOffice.CRM.Rows.SaintConfigurationRecordData is Modified


#### SuperOffice.CRM.Rows.SaintConfigurationRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SaintConfigurationRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaintConfigurationRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaintConfigurationRow.IdxSaintConfigurationId is Modified



##### SuperOffice.CRM.Rows.SaintConfigurationRow.SaintConfigurationRowIdx is Modified



##### SuperOffice.CRM.Rows.SaintConfigurationRow.SaintConfigurationRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SaintConfigurationRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaintConfigurationRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaintConfigurationRows.SaintConfigurationRowsIdx is Modified



#### SuperOffice.CRM.Rows.SaleHistRecordData is Modified


#### SuperOffice.CRM.Rows.SaleHistRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SaleHistRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleHistRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleHistRow.IdxSalehistId is Modified



##### SuperOffice.CRM.Rows.SaleHistRow.SaleHistRowIdx is Modified



##### SuperOffice.CRM.Rows.SaleHistRow.SaleHistRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SaleHistRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleHistRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.IdxDone is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.IdxHeading is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.IdxNumber1 is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.IdxProjectId is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.IdxSaledate is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.IdxSaleId is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.IdxSource is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.IdxStatus is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.IdxUserdef2Id is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.IdxUserdefId is Modified



##### SuperOffice.CRM.Rows.SaleHistRows.SaleHistRowsIdx is Modified



#### SuperOffice.CRM.Rows.SaleRecordData is Modified


#### SuperOffice.CRM.Rows.SaleRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SaleRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleRow.IdxSaleId is Modified



##### SuperOffice.CRM.Rows.SaleRow.SaleRowIdx is Modified



##### SuperOffice.CRM.Rows.SaleRow.SaleRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SaleRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxAssociateId is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxAssociateIdDone is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxAssociateIdDoneSaledate is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxContactIdSaledate is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxContactIdSaledateAssociateId is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxDone is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxHeading is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxNumber1 is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxProjectId is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxProjectIdSaledate is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxProjectIdSaledateAssociateId is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxSaledate is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxSource is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxStatus is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxUserdef2Id is Modified



##### SuperOffice.CRM.Rows.SaleRows.IdxUserdefId is Modified



##### SuperOffice.CRM.Rows.SaleRows.SaleRowsIdx is Modified



#### SuperOffice.CRM.Rows.SaleStakeholderRecordData is Modified


#### SuperOffice.CRM.Rows.SaleStakeholderRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SaleStakeholderRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleStakeholderRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleStakeholderRow.IdxSaleStakeholderId is Modified



##### SuperOffice.CRM.Rows.SaleStakeholderRow.SaleStakeholderRowIdx is Modified



##### SuperOffice.CRM.Rows.SaleStakeholderRow.SaleStakeholderRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SaleStakeholderRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleStakeholderRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleStakeholderRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.SaleStakeholderRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.SaleStakeholderRows.SaleStakeholderRowsIdx is Modified



#### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRow.IdxSaleTypeCatGroupLinkId is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRow.SaleTypeCatGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRow.SaleTypeCatGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRows.IdxSaleTypeCatId is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatGroupLinkRows.SaleTypeCatGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRow.IdxSaleTypeCatHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRow.SaleTypeCatHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRow.SaleTypeCatHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRows.IdxSaleTypeCatId is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatHeadingLinkRows.SaleTypeCatHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SaleTypeCatRecordData is Modified


#### SuperOffice.CRM.Rows.SaleTypeCatRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SaleTypeCatRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeCatRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatRow.IdxName is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatRow.IdxSaleTypeCatId is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatRow.SaleTypeCatRowIdx is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatRow.SaleTypeCatRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SaleTypeCatRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeCatRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeCatRows.SaleTypeCatRowsIdx is Modified



#### SuperOffice.CRM.Rows.SaleTypeGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SaleTypeGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SaleTypeGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeGroupLinkRow.IdxSaleTypegrouplinkId is Modified



##### SuperOffice.CRM.Rows.SaleTypeGroupLinkRow.SaleTypeGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SaleTypeGroupLinkRow.SaleTypeGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SaleTypeGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.SaleTypeGroupLinkRows.IdxSaleTypeId is Modified



##### SuperOffice.CRM.Rows.SaleTypeGroupLinkRows.SaleTypeGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRow.IdxSaleTypeheadinglinkId is Modified



##### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRow.SaleTypeHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRow.SaleTypeHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRows.IdxSaleTypeId is Modified



##### SuperOffice.CRM.Rows.SaleTypeHeadingLinkRows.SaleTypeHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SaleTypeQuoteAttachmentRecordData is Modified


#### SuperOffice.CRM.Rows.SaleTypeQuoteAttachmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SaleTypeQuoteAttachmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeQuoteAttachmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeQuoteAttachmentRow.IdxSaleTypeQuoteAttachmentId is Modified



##### SuperOffice.CRM.Rows.SaleTypeQuoteAttachmentRow.SaleTypeQuoteAttachmentRowIdx is Modified



##### SuperOffice.CRM.Rows.SaleTypeQuoteAttachmentRow.SaleTypeQuoteAttachmentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SaleTypeQuoteAttachmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeQuoteAttachmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeQuoteAttachmentRows.SaleTypeQuoteAttachmentRowsIdx is Modified



#### SuperOffice.CRM.Rows.SaleTypeRecordData is Modified


#### SuperOffice.CRM.Rows.SaleTypeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SaleTypeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeRow.IdxName is Modified



##### SuperOffice.CRM.Rows.SaleTypeRow.IdxSaleTypeId is Modified



##### SuperOffice.CRM.Rows.SaleTypeRow.SaleTypeRowIdx is Modified



##### SuperOffice.CRM.Rows.SaleTypeRow.SaleTypeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SaleTypeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeRows.SaleTypeRowsIdx is Modified



#### SuperOffice.CRM.Rows.SaleTypeStageLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SaleTypeStageLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SaleTypeStageLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeStageLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeStageLinkRow.IdxSaleTypeStageLinkId is Modified



##### SuperOffice.CRM.Rows.SaleTypeStageLinkRow.SaleTypeStageLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SaleTypeStageLinkRow.SaleTypeStageLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SaleTypeStageLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SaleTypeStageLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SaleTypeStageLinkRows.IdxSaleTypeId is Modified



##### SuperOffice.CRM.Rows.SaleTypeStageLinkRows.IdxSaleTypeIdStageId is Modified



##### SuperOffice.CRM.Rows.SaleTypeStageLinkRows.SaleTypeStageLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SalutationGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SalutationGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SalutationGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SalutationGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SalutationGroupLinkRow.IdxSalutationgrouplinkId is Modified



##### SuperOffice.CRM.Rows.SalutationGroupLinkRow.SalutationGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SalutationGroupLinkRow.SalutationGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SalutationGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SalutationGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SalutationGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.SalutationGroupLinkRows.IdxSalutationId is Modified



##### SuperOffice.CRM.Rows.SalutationGroupLinkRows.SalutationGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SalutationHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SalutationHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SalutationHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SalutationHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SalutationHeadingLinkRow.IdxSalutationheadinglinkId is Modified



##### SuperOffice.CRM.Rows.SalutationHeadingLinkRow.SalutationHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SalutationHeadingLinkRow.SalutationHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SalutationHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SalutationHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SalutationHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.SalutationHeadingLinkRows.IdxSalutationId is Modified



##### SuperOffice.CRM.Rows.SalutationHeadingLinkRows.SalutationHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SalutationRecordData is Modified


#### SuperOffice.CRM.Rows.SalutationRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SalutationRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SalutationRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SalutationRow.IdxName is Modified



##### SuperOffice.CRM.Rows.SalutationRow.IdxSalutationId is Modified



##### SuperOffice.CRM.Rows.SalutationRow.SalutationRowIdx is Modified



##### SuperOffice.CRM.Rows.SalutationRow.SalutationRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SalutationRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SalutationRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SalutationRows.SalutationRowsIdx is Modified



#### SuperOffice.CRM.Rows.SatelliteRecordData is Modified


#### SuperOffice.CRM.Rows.SatelliteRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SatelliteRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SatelliteRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SatelliteRow.IdxSatelliteId is Modified



##### SuperOffice.CRM.Rows.SatelliteRow.SatelliteRowIdx is Modified



##### SuperOffice.CRM.Rows.SatelliteRow.SatelliteRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SatelliteRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SatelliteRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SatelliteRows.SatelliteRowsIdx is Modified



#### SuperOffice.CRM.Rows.SAttachmentRecordData is Modified


#### SuperOffice.CRM.Rows.SAttachmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SAttachmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SAttachmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SAttachmentRow.IdxSAttachmentId is Modified



##### SuperOffice.CRM.Rows.SAttachmentRow.SAttachmentRowIdx is Modified



##### SuperOffice.CRM.Rows.SAttachmentRow.SAttachmentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SAttachmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SAttachmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SAttachmentRows.IdxAttachmentId is Modified



##### SuperOffice.CRM.Rows.SAttachmentRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.SAttachmentRows.SAttachmentRowsIdx is Modified



#### SuperOffice.CRM.Rows.SBounceShipmentRecordData is Modified


#### SuperOffice.CRM.Rows.SBounceShipmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SBounceShipmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SBounceShipmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SBounceShipmentRow.IdxSBounceShipmentId is Modified



##### SuperOffice.CRM.Rows.SBounceShipmentRow.SBounceShipmentRowIdx is Modified



##### SuperOffice.CRM.Rows.SBounceShipmentRow.SBounceShipmentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SBounceShipmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SBounceShipmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SBounceShipmentRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.SBounceShipmentRows.IdxShipmentId is Modified



##### SuperOffice.CRM.Rows.SBounceShipmentRows.SBounceShipmentRowsIdx is Modified



#### SuperOffice.CRM.Rows.ScheduledTaskRecordData is Modified


#### SuperOffice.CRM.Rows.ScheduledTaskRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ScheduledTaskRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScheduledTaskRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScheduledTaskRow.IdxScheduledTaskId is Modified



##### SuperOffice.CRM.Rows.ScheduledTaskRow.ScheduledTaskRowIdx is Modified



##### SuperOffice.CRM.Rows.ScheduledTaskRow.ScheduledTaskRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ScheduledTaskRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScheduledTaskRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScheduledTaskRows.IdxScheduleId is Modified



##### SuperOffice.CRM.Rows.ScheduledTaskRows.IdxScriptId is Modified



##### SuperOffice.CRM.Rows.ScheduledTaskRows.ScheduledTaskRowsIdx is Modified



#### SuperOffice.CRM.Rows.ScheduleRecordData is Modified


#### SuperOffice.CRM.Rows.ScheduleRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ScheduleRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScheduleRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScheduleRow.IdxScheduleId is Modified



##### SuperOffice.CRM.Rows.ScheduleRow.ScheduleRowIdx is Modified



##### SuperOffice.CRM.Rows.ScheduleRow.ScheduleRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ScheduleRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScheduleRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScheduleRows.IdxAfterScheduleId is Modified



##### SuperOffice.CRM.Rows.ScheduleRows.ScheduleRowsIdx is Modified



#### SuperOffice.CRM.Rows.ScreenChooserRecordData is Modified


#### SuperOffice.CRM.Rows.ScreenChooserRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ScreenChooserRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScreenChooserRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScreenChooserRow.IdxScreenChooserId is Modified



##### SuperOffice.CRM.Rows.ScreenChooserRow.IdxUniqueIdentifier is Modified



##### SuperOffice.CRM.Rows.ScreenChooserRow.ScreenChooserRowIdx is Modified



##### SuperOffice.CRM.Rows.ScreenChooserRow.ScreenChooserRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ScreenChooserRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScreenChooserRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScreenChooserRows.IdxScreenTarget is Modified



##### SuperOffice.CRM.Rows.ScreenChooserRows.ScreenChooserRowsIdx is Modified



#### SuperOffice.CRM.Rows.ScreenDefinitionActionRecordData is Modified


#### SuperOffice.CRM.Rows.ScreenDefinitionActionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ScreenDefinitionActionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScreenDefinitionActionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionActionRow.IdxScreenDefinitionActionId is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionActionRow.ScreenDefinitionActionRowIdx is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionActionRow.ScreenDefinitionActionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ScreenDefinitionActionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScreenDefinitionActionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionActionRows.IdxEjscript is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionActionRows.IdxScreenDefinition is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionActionRows.ScreenDefinitionActionRowsIdx is Modified



#### SuperOffice.CRM.Rows.ScreenDefinitionElementRecordData is Modified


#### SuperOffice.CRM.Rows.ScreenDefinitionElementRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ScreenDefinitionElementRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScreenDefinitionElementRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionElementRow.IdxScreenDefinitionElementId is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionElementRow.ScreenDefinitionElementRowIdx is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionElementRow.ScreenDefinitionElementRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ScreenDefinitionElementRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScreenDefinitionElementRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionElementRows.IdxScreenDefinition is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionElementRows.ScreenDefinitionElementRowsIdx is Modified



#### SuperOffice.CRM.Rows.ScreenDefinitionHiddenRecordData is Modified


#### SuperOffice.CRM.Rows.ScreenDefinitionHiddenRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ScreenDefinitionHiddenRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScreenDefinitionHiddenRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionHiddenRow.IdxScreenDefinitionHiddenId is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionHiddenRow.ScreenDefinitionHiddenRowIdx is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionHiddenRow.ScreenDefinitionHiddenRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ScreenDefinitionHiddenRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScreenDefinitionHiddenRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionHiddenRows.IdxScreenDefinition is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionHiddenRows.ScreenDefinitionHiddenRowsIdx is Modified



#### SuperOffice.CRM.Rows.ScreenDefinitionLanguageRecordData is Modified


#### SuperOffice.CRM.Rows.ScreenDefinitionLanguageRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ScreenDefinitionLanguageRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScreenDefinitionLanguageRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionLanguageRow.IdxScreenDefinitionLanguageId is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionLanguageRow.ScreenDefinitionLanguageRowIdx is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionLanguageRow.ScreenDefinitionLanguageRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ScreenDefinitionLanguageRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScreenDefinitionLanguageRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionLanguageRows.IdxScreenDefinition is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionLanguageRows.ScreenDefinitionLanguageRowsIdx is Modified



#### SuperOffice.CRM.Rows.ScreenDefinitionRecordData is Modified


#### SuperOffice.CRM.Rows.ScreenDefinitionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ScreenDefinitionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScreenDefinitionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionRow.IdxScreenDefinitionId is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionRow.ScreenDefinitionRowIdx is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionRow.ScreenDefinitionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ScreenDefinitionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScreenDefinitionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionRows.IdxHierarchyId is Modified



##### SuperOffice.CRM.Rows.ScreenDefinitionRows.ScreenDefinitionRowsIdx is Modified



#### SuperOffice.CRM.Rows.ScriptTraceRecordData is Modified


#### SuperOffice.CRM.Rows.ScriptTraceRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ScriptTraceRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScriptTraceRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScriptTraceRow.IdxScriptTraceId is Modified



##### SuperOffice.CRM.Rows.ScriptTraceRow.ScriptTraceRowIdx is Modified



##### SuperOffice.CRM.Rows.ScriptTraceRow.ScriptTraceRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ScriptTraceRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScriptTraceRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScriptTraceRows.ScriptTraceRowsIdx is Modified



#### SuperOffice.CRM.Rows.ScriptTraceRunRecordData is Modified


#### SuperOffice.CRM.Rows.ScriptTraceRunRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ScriptTraceRunRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScriptTraceRunRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScriptTraceRunRow.IdxScriptTraceRunId is Modified



##### SuperOffice.CRM.Rows.ScriptTraceRunRow.ScriptTraceRunRowIdx is Modified



##### SuperOffice.CRM.Rows.ScriptTraceRunRow.ScriptTraceRunRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ScriptTraceRunRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ScriptTraceRunRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ScriptTraceRunRows.ScriptTraceRunRowsIdx is Modified



#### SuperOffice.CRM.Rows.SDynCriteriaRecordData is Modified


#### SuperOffice.CRM.Rows.SDynCriteriaRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SDynCriteriaRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SDynCriteriaRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SDynCriteriaRow.IdxSDynCriteriaId is Modified



##### SuperOffice.CRM.Rows.SDynCriteriaRow.SDynCriteriaRowIdx is Modified



##### SuperOffice.CRM.Rows.SDynCriteriaRow.SDynCriteriaRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SDynCriteriaRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SDynCriteriaRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SDynCriteriaRows.IdxListId is Modified



##### SuperOffice.CRM.Rows.SDynCriteriaRows.SDynCriteriaRowsIdx is Modified



#### SuperOffice.CRM.Rows.SearchCatGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SearchCatGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SearchCatGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCatGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCatGroupLinkRow.IdxSearchcatgrouplinkId is Modified



##### SuperOffice.CRM.Rows.SearchCatGroupLinkRow.SearchCatGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SearchCatGroupLinkRow.SearchCatGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SearchCatGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCatGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCatGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.SearchCatGroupLinkRows.IdxSearchCatId is Modified



##### SuperOffice.CRM.Rows.SearchCatGroupLinkRows.SearchCatGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SearchCatHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SearchCatHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SearchCatHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCatHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCatHeadingLinkRow.IdxSearchcatheadinglinkId is Modified



##### SuperOffice.CRM.Rows.SearchCatHeadingLinkRow.SearchCatHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SearchCatHeadingLinkRow.SearchCatHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SearchCatHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCatHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCatHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.SearchCatHeadingLinkRows.IdxSearchCatId is Modified



##### SuperOffice.CRM.Rows.SearchCatHeadingLinkRows.SearchCatHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SearchCatRecordData is Modified


#### SuperOffice.CRM.Rows.SearchCatRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SearchCatRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCatRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCatRow.IdxName is Modified



##### SuperOffice.CRM.Rows.SearchCatRow.IdxSearchCatId is Modified



##### SuperOffice.CRM.Rows.SearchCatRow.SearchCatRowIdx is Modified



##### SuperOffice.CRM.Rows.SearchCatRow.SearchCatRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SearchCatRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCatRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCatRows.SearchCatRowsIdx is Modified



#### SuperOffice.CRM.Rows.SearchCriteriaGroupRecordData is Modified


#### SuperOffice.CRM.Rows.SearchCriteriaGroupRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SearchCriteriaGroupRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCriteriaGroupRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaGroupRow.IdxSearchCriteriaGroupId is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaGroupRow.SearchCriteriaGroupRowIdx is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaGroupRow.SearchCriteriaGroupRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SearchCriteriaGroupRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCriteriaGroupRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaGroupRows.SearchCriteriaGroupRowsIdx is Modified



#### SuperOffice.CRM.Rows.SearchCriteriaRecordData is Modified


#### SuperOffice.CRM.Rows.SearchCriteriaRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SearchCriteriaRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCriteriaRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaRow.IdxSearchCriteriaId is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaRow.SearchCriteriaRowIdx is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaRow.SearchCriteriaRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SearchCriteriaRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCriteriaRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaRows.IdxOwnerId is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaRows.IdxOwnerIdOwnerName is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaRows.IdxOwnerIdOwnerNameOwnerGuiName is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaRows.IdxOwnerIdOwnerTable is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaRows.IdxOwnerIdOwnerTableOwnerType is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaRows.IdxOwnerIdOwnerTableOwnerTypeOwnerGuiName is Modified



##### SuperOffice.CRM.Rows.SearchCriteriaRows.SearchCriteriaRowsIdx is Modified



#### SuperOffice.CRM.Rows.SearchCriterionRecordData is Modified


#### SuperOffice.CRM.Rows.SearchCriterionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SearchCriterionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCriterionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCriterionRow.IdxSearchCriterionId is Modified



##### SuperOffice.CRM.Rows.SearchCriterionRow.SearchCriterionRowIdx is Modified



##### SuperOffice.CRM.Rows.SearchCriterionRow.SearchCriterionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SearchCriterionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCriterionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCriterionRows.SearchCriterionRowsIdx is Modified



#### SuperOffice.CRM.Rows.SearchCriterionValueRecordData is Modified


#### SuperOffice.CRM.Rows.SearchCriterionValueRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SearchCriterionValueRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCriterionValueRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCriterionValueRow.IdxSearchCriterionValueId is Modified



##### SuperOffice.CRM.Rows.SearchCriterionValueRow.SearchCriterionValueRowIdx is Modified



##### SuperOffice.CRM.Rows.SearchCriterionValueRow.SearchCriterionValueRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SearchCriterionValueRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SearchCriterionValueRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SearchCriterionValueRows.SearchCriterionValueRowsIdx is Modified



#### SuperOffice.CRM.Rows.SelectionMemberRecordData is Modified


#### SuperOffice.CRM.Rows.SelectionMemberRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SelectionMemberRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SelectionMemberRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SelectionMemberRow.IdxSelectionmemberId is Modified



##### SuperOffice.CRM.Rows.SelectionMemberRow.SelectionMemberRowIdx is Modified



##### SuperOffice.CRM.Rows.SelectionMemberRow.SelectionMemberRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SelectionMemberRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SelectionMemberRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SelectionMemberRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.SelectionMemberRows.IdxContactIdPersonId is Modified



##### SuperOffice.CRM.Rows.SelectionMemberRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.SelectionMemberRows.IdxSelectionId is Modified



##### SuperOffice.CRM.Rows.SelectionMemberRows.IdxSelectionIdContactId is Modified



##### SuperOffice.CRM.Rows.SelectionMemberRows.SelectionMemberRowsIdx is Modified



#### SuperOffice.CRM.Rows.SelectionRecordData is Modified


#### SuperOffice.CRM.Rows.SelectionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SelectionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SelectionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SelectionRow.IdxSelectionId is Modified



##### SuperOffice.CRM.Rows.SelectionRow.SelectionRowIdx is Modified



##### SuperOffice.CRM.Rows.SelectionRow.SelectionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SelectionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SelectionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SelectionRows.IdxAssociateId is Modified



##### SuperOffice.CRM.Rows.SelectionRows.IdxDone is Modified



##### SuperOffice.CRM.Rows.SelectionRows.IdxGroupIdx is Modified



##### SuperOffice.CRM.Rows.SelectionRows.IdxName is Modified



##### SuperOffice.CRM.Rows.SelectionRows.IdxSoundEx is Modified



##### SuperOffice.CRM.Rows.SelectionRows.IdxSource is Modified



##### SuperOffice.CRM.Rows.SelectionRows.SelectionRowsIdx is Modified



#### SuperOffice.CRM.Rows.SequenceRecordData is Modified


#### SuperOffice.CRM.Rows.SequenceRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SequenceRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SequenceRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SequenceRow.IdxId is Modified



##### SuperOffice.CRM.Rows.SequenceRow.IdxTableName is Modified



##### SuperOffice.CRM.Rows.SequenceRow.IdxTableNumber is Modified



##### SuperOffice.CRM.Rows.SequenceRow.SequenceRowIdx is Modified



##### SuperOffice.CRM.Rows.SequenceRow.SequenceRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SequenceRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SequenceRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SequenceRows.SequenceRowsIdx is Modified



#### SuperOffice.CRM.Rows.ServiceAuthRecordData is Modified


#### SuperOffice.CRM.Rows.ServiceAuthRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ServiceAuthRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ServiceAuthRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ServiceAuthRow.IdxServiceAuthId is Modified



##### SuperOffice.CRM.Rows.ServiceAuthRow.ServiceAuthRowIdx is Modified



##### SuperOffice.CRM.Rows.ServiceAuthRow.ServiceAuthRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ServiceAuthRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ServiceAuthRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ServiceAuthRows.ServiceAuthRowsIdx is Modified



#### SuperOffice.CRM.Rows.SessionObjectRecordData is Modified


#### SuperOffice.CRM.Rows.SessionObjectRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SessionObjectRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SessionObjectRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SessionObjectRow.IdxSessionObjectId is Modified



##### SuperOffice.CRM.Rows.SessionObjectRow.SessionObjectRowIdx is Modified



##### SuperOffice.CRM.Rows.SessionObjectRow.SessionObjectRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SessionObjectRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SessionObjectRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SessionObjectRows.IdxLoginId is Modified



##### SuperOffice.CRM.Rows.SessionObjectRows.IdxName is Modified



##### SuperOffice.CRM.Rows.SessionObjectRows.SessionObjectRowsIdx is Modified



#### SuperOffice.CRM.Rows.ShipmentTypeRecordData is Modified


#### SuperOffice.CRM.Rows.ShipmentTypeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ShipmentTypeReservationRecordData is Modified


#### SuperOffice.CRM.Rows.ShipmentTypeReservationRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ShipmentTypeReservationRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ShipmentTypeReservationRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ShipmentTypeReservationRow.IdxShipmentTypeReservationId is Modified



##### SuperOffice.CRM.Rows.ShipmentTypeReservationRow.ShipmentTypeReservationRowIdx is Modified



##### SuperOffice.CRM.Rows.ShipmentTypeReservationRow.ShipmentTypeReservationRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ShipmentTypeReservationRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ShipmentTypeReservationRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ShipmentTypeReservationRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.ShipmentTypeReservationRows.IdxShipmentTypeId is Modified



##### SuperOffice.CRM.Rows.ShipmentTypeReservationRows.IdxShipmentTypeIdPersonId is Modified



##### SuperOffice.CRM.Rows.ShipmentTypeReservationRows.ShipmentTypeReservationRowsIdx is Modified



#### SuperOffice.CRM.Rows.ShipmentTypeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ShipmentTypeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ShipmentTypeRow.IdxShipmentTypeId is Modified



##### SuperOffice.CRM.Rows.ShipmentTypeRow.ShipmentTypeRowIdx is Modified



##### SuperOffice.CRM.Rows.ShipmentTypeRow.ShipmentTypeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ShipmentTypeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ShipmentTypeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ShipmentTypeRows.ShipmentTypeRowsIdx is Modified



#### SuperOffice.CRM.Rows.SLinkCustomerRecordData is Modified


#### SuperOffice.CRM.Rows.SLinkCustomerRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SLinkCustomerRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SLinkCustomerRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerRow.IdxSLinkCustomerId is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerRow.SLinkCustomerRowIdx is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerRow.SLinkCustomerRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SLinkCustomerRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SLinkCustomerRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerRows.IdxLinkId is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerRows.IdxLinkType is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerRows.IdxLinkTypeShipmentId is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerRows.IdxShipmentId is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerRows.IdxShipmentIdCustomerId is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerRows.SLinkCustomerRowsIdx is Modified



#### SuperOffice.CRM.Rows.SLinkCustomerStaticalRecordData is Modified


#### SuperOffice.CRM.Rows.SLinkCustomerStaticalRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SLinkCustomerStaticalRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRow.IdxSLinkCustomerStaticalId is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRow.SLinkCustomerStaticalRowIdx is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRow.SLinkCustomerStaticalRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SLinkCustomerStaticalRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRows.IdxEmail is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRows.IdxLinkId is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRows.IdxLinkType is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRows.IdxLinkTypeShipmentId is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRows.IdxShipmentId is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRows.IdxShipmentIdEmail is Modified



##### SuperOffice.CRM.Rows.SLinkCustomerStaticalRows.SLinkCustomerStaticalRowsIdx is Modified



#### SuperOffice.CRM.Rows.SLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SLinkRow.IdxSLinkId is Modified



##### SuperOffice.CRM.Rows.SLinkRow.SLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SLinkRow.SLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxAddContactInterest is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxAddContactSelection is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxAddPersonInterest is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxAddProject is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxAddToSelection is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxRemoveContactInterest is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxRemoveContactSelection is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxRemoveFromSelection is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxRemovePersonInterest is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxRemoveProject is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxScriptId is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxTaskAssociateId is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxTaskCreatingAssociateId is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxTaskIdx is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxTaskProject is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxTicketCategory is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxTicketOwnedBy is Modified



##### SuperOffice.CRM.Rows.SLinkRows.IdxTicketPriority is Modified



##### SuperOffice.CRM.Rows.SLinkRows.SLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SListCustomerRecordData is Modified


#### SuperOffice.CRM.Rows.SListCustomerRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SListCustomerRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SListCustomerRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SListCustomerRow.IdxSListCustomerId is Modified



##### SuperOffice.CRM.Rows.SListCustomerRow.SListCustomerRowIdx is Modified



##### SuperOffice.CRM.Rows.SListCustomerRow.SListCustomerRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SListCustomerRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SListCustomerRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SListCustomerRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.SListCustomerRows.IdxListId is Modified



##### SuperOffice.CRM.Rows.SListCustomerRows.SListCustomerRowsIdx is Modified



#### SuperOffice.CRM.Rows.SListElementRecordData is Modified


#### SuperOffice.CRM.Rows.SListElementRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SListElementRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SListElementRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SListElementRow.IdxSListElementId is Modified



##### SuperOffice.CRM.Rows.SListElementRow.SListElementRowIdx is Modified



##### SuperOffice.CRM.Rows.SListElementRow.SListElementRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SListElementRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SListElementRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SListElementRows.IdxAddress is Modified



##### SuperOffice.CRM.Rows.SListElementRows.IdxListId is Modified



##### SuperOffice.CRM.Rows.SListElementRows.IdxSms is Modified



##### SuperOffice.CRM.Rows.SListElementRows.SListElementRowsIdx is Modified



#### SuperOffice.CRM.Rows.SListRecordData is Modified


#### SuperOffice.CRM.Rows.SListRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SListRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SListRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SListRow.IdxSListId is Modified



##### SuperOffice.CRM.Rows.SListRow.SListRowIdx is Modified



##### SuperOffice.CRM.Rows.SListRow.SListRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SListRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SListRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SListRows.IdxDbiAgentId is Modified



##### SuperOffice.CRM.Rows.SListRows.IdxDbiKey is Modified



##### SuperOffice.CRM.Rows.SListRows.IdxDbiLastModified is Modified



##### SuperOffice.CRM.Rows.SListRows.IdxDbiLastSyncronized is Modified



##### SuperOffice.CRM.Rows.SListRows.SListRowsIdx is Modified



#### SuperOffice.CRM.Rows.SListShipmentRecordData is Modified


#### SuperOffice.CRM.Rows.SListShipmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SListShipmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SListShipmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SListShipmentRow.IdxSListShipmentId is Modified



##### SuperOffice.CRM.Rows.SListShipmentRow.SListShipmentRowIdx is Modified



##### SuperOffice.CRM.Rows.SListShipmentRow.SListShipmentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SListShipmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SListShipmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SListShipmentRows.IdxListId is Modified



##### SuperOffice.CRM.Rows.SListShipmentRows.IdxShipmentId is Modified



##### SuperOffice.CRM.Rows.SListShipmentRows.SListShipmentRowsIdx is Modified



#### SuperOffice.CRM.Rows.SMessageblockRecordData is Modified


#### SuperOffice.CRM.Rows.SMessageblockRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SMessageblockRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SMessageblockRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SMessageblockRow.IdxSMessageblockId is Modified



##### SuperOffice.CRM.Rows.SMessageblockRow.SMessageblockRowIdx is Modified



##### SuperOffice.CRM.Rows.SMessageblockRow.SMessageblockRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SMessageblockRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SMessageblockRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SMessageblockRows.SMessageblockRowsIdx is Modified



#### SuperOffice.CRM.Rows.SMessageRecordData is Modified


#### SuperOffice.CRM.Rows.SMessageRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SMessageRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SMessageRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SMessageRow.IdxSMessageId is Modified



##### SuperOffice.CRM.Rows.SMessageRow.SMessageRowIdx is Modified



##### SuperOffice.CRM.Rows.SMessageRow.SMessageRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SMessageRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SMessageRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SMessageRows.SMessageRowsIdx is Modified



#### SuperOffice.CRM.Rows.SmsHysteriaRecordData is Modified


#### SuperOffice.CRM.Rows.SmsHysteriaRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SmsHysteriaRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SmsHysteriaRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SmsHysteriaRow.IdxSmsHysteriaId is Modified



##### SuperOffice.CRM.Rows.SmsHysteriaRow.SmsHysteriaRowIdx is Modified



##### SuperOffice.CRM.Rows.SmsHysteriaRow.SmsHysteriaRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SmsHysteriaRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SmsHysteriaRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SmsHysteriaRows.SmsHysteriaRowsIdx is Modified



#### SuperOffice.CRM.Rows.SmsRecordData is Modified


#### SuperOffice.CRM.Rows.SmsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SmsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SmsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SmsRow.IdxSmsId is Modified



##### SuperOffice.CRM.Rows.SmsRow.SmsRowIdx is Modified



##### SuperOffice.CRM.Rows.SmsRow.SmsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SmsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SmsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SmsRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.SmsRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.SmsRows.IdxOutboxId is Modified



##### SuperOffice.CRM.Rows.SmsRows.IdxOutgoingMessageId is Modified



##### SuperOffice.CRM.Rows.SmsRows.IdxReferenceKey is Modified



##### SuperOffice.CRM.Rows.SmsRows.IdxSessionKey is Modified



##### SuperOffice.CRM.Rows.SmsRows.IdxShipmentId is Modified



##### SuperOffice.CRM.Rows.SmsRows.SmsRowsIdx is Modified



#### SuperOffice.CRM.Rows.SnapshotRecordData is Modified


#### SuperOffice.CRM.Rows.SnapshotRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SnapshotRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SnapshotRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SnapshotRow.IdxSnapshotId is Modified



##### SuperOffice.CRM.Rows.SnapshotRow.SnapshotRowIdx is Modified



##### SuperOffice.CRM.Rows.SnapshotRow.SnapshotRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SnapshotRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SnapshotRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SnapshotRows.SnapshotRowsIdx is Modified



#### SuperOffice.CRM.Rows.SoapAccessRecordData is Modified


#### SuperOffice.CRM.Rows.SoapAccessRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SoapAccessRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SoapAccessRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SoapAccessRow.IdxSoapAccessId is Modified



##### SuperOffice.CRM.Rows.SoapAccessRow.SoapAccessRowIdx is Modified



##### SuperOffice.CRM.Rows.SoapAccessRow.SoapAccessRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SoapAccessRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SoapAccessRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SoapAccessRows.SoapAccessRowsIdx is Modified



#### SuperOffice.CRM.Rows.SORCriteriaRecordData is Modified


#### SuperOffice.CRM.Rows.SORCriteriaRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SORCriteriaRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORCriteriaRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORCriteriaRow.IdxSORCriteriaId is Modified



##### SuperOffice.CRM.Rows.SORCriteriaRow.SORCriteriaRowIdx is Modified



##### SuperOffice.CRM.Rows.SORCriteriaRow.SORCriteriaRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SORCriteriaRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORCriteriaRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORCriteriaRows.IdxSOROperatorsId is Modified



##### SuperOffice.CRM.Rows.SORCriteriaRows.IdxSORPublishId is Modified



##### SuperOffice.CRM.Rows.SORCriteriaRows.IdxUseIt is Modified



##### SuperOffice.CRM.Rows.SORCriteriaRows.IdxWhereOrder is Modified



##### SuperOffice.CRM.Rows.SORCriteriaRows.SORCriteriaRowsIdx is Modified



#### SuperOffice.CRM.Rows.SORFCTRecordData is Modified


#### SuperOffice.CRM.Rows.SORFCTRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SORFCTRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORFCTRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORFCTRow.IdxSORFCTId is Modified



##### SuperOffice.CRM.Rows.SORFCTRow.SORFCTRowIdx is Modified



##### SuperOffice.CRM.Rows.SORFCTRow.SORFCTRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SORFCTRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORFCTRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORFCTRows.IdxFieldType is Modified



##### SuperOffice.CRM.Rows.SORFCTRows.IdxSORSectionId is Modified



##### SuperOffice.CRM.Rows.SORFCTRows.SORFCTRowsIdx is Modified



#### SuperOffice.CRM.Rows.SORFieldRecordData is Modified


#### SuperOffice.CRM.Rows.SORFieldRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SORFieldRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORFieldRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORFieldRow.IdxSORFieldId is Modified



##### SuperOffice.CRM.Rows.SORFieldRow.SORFieldRowIdx is Modified



##### SuperOffice.CRM.Rows.SORFieldRow.SORFieldRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SORFieldRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORFieldRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORFieldRows.IdxFieldType is Modified



##### SuperOffice.CRM.Rows.SORFieldRows.IdxSORSectionId is Modified



##### SuperOffice.CRM.Rows.SORFieldRows.IdxVisible is Modified



##### SuperOffice.CRM.Rows.SORFieldRows.SORFieldRowsIdx is Modified



#### SuperOffice.CRM.Rows.SORLabelLayoutRecordData is Modified


#### SuperOffice.CRM.Rows.SORLabelLayoutRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SORLabelLayoutRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORLabelLayoutRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORLabelLayoutRow.IdxSORLabelLayoutId is Modified



##### SuperOffice.CRM.Rows.SORLabelLayoutRow.SORLabelLayoutRowIdx is Modified



##### SuperOffice.CRM.Rows.SORLabelLayoutRow.SORLabelLayoutRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SORLabelLayoutRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORLabelLayoutRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORLabelLayoutRows.IdxName is Modified



##### SuperOffice.CRM.Rows.SORLabelLayoutRows.SORLabelLayoutRowsIdx is Modified



#### SuperOffice.CRM.Rows.SOROperatorsRecordData is Modified


#### SuperOffice.CRM.Rows.SOROperatorsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SOROperatorsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SOROperatorsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SOROperatorsRow.IdxSOROperatorsId is Modified



##### SuperOffice.CRM.Rows.SOROperatorsRow.SOROperatorsRowIdx is Modified



##### SuperOffice.CRM.Rows.SOROperatorsRow.SOROperatorsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SOROperatorsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SOROperatorsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SOROperatorsRows.IdxOperatorType is Modified



##### SuperOffice.CRM.Rows.SOROperatorsRows.SOROperatorsRowsIdx is Modified



#### SuperOffice.CRM.Rows.SORPublishGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SORPublishGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SORPublishGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORPublishGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORPublishGroupLinkRow.IdxSORPublishGoupLinkId is Modified



##### SuperOffice.CRM.Rows.SORPublishGroupLinkRow.SORPublishGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SORPublishGroupLinkRow.SORPublishGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SORPublishGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORPublishGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORPublishGroupLinkRows.IdxSORPublishId is Modified



##### SuperOffice.CRM.Rows.SORPublishGroupLinkRows.IdxUserGroupId is Modified



##### SuperOffice.CRM.Rows.SORPublishGroupLinkRows.SORPublishGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SORPublishRecordData is Modified


#### SuperOffice.CRM.Rows.SORPublishRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SORPublishRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORPublishRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORPublishRow.IdxSORPublishId is Modified



##### SuperOffice.CRM.Rows.SORPublishRow.SORPublishRowIdx is Modified



##### SuperOffice.CRM.Rows.SORPublishRow.SORPublishRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SORPublishRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORPublishRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORPublishRows.IdxAssociateId is Modified



##### SuperOffice.CRM.Rows.SORPublishRows.IdxDefaultLabelLayout is Modified



##### SuperOffice.CRM.Rows.SORPublishRows.IdxForceDefault is Modified



##### SuperOffice.CRM.Rows.SORPublishRows.IdxName is Modified



##### SuperOffice.CRM.Rows.SORPublishRows.IdxSORTemplateId is Modified



##### SuperOffice.CRM.Rows.SORPublishRows.SORPublishRowsIdx is Modified



#### SuperOffice.CRM.Rows.SORSectionRecordData is Modified


#### SuperOffice.CRM.Rows.SORSectionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SORSectionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORSectionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORSectionRow.IdxSORSectionId is Modified



##### SuperOffice.CRM.Rows.SORSectionRow.SORSectionRowIdx is Modified



##### SuperOffice.CRM.Rows.SORSectionRow.SORSectionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SORSectionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORSectionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORSectionRows.IdxSORTemplateId is Modified



##### SuperOffice.CRM.Rows.SORSectionRows.SORSectionRowsIdx is Modified



#### SuperOffice.CRM.Rows.SORTemplateRecordData is Modified


#### SuperOffice.CRM.Rows.SORTemplateRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SORTemplateRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORTemplateRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORTemplateRow.IdxSORTemplateId is Modified



##### SuperOffice.CRM.Rows.SORTemplateRow.SORTemplateRowIdx is Modified



##### SuperOffice.CRM.Rows.SORTemplateRow.SORTemplateRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SORTemplateRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SORTemplateRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SORTemplateRows.IdxPublished is Modified



##### SuperOffice.CRM.Rows.SORTemplateRows.IdxSubject is Modified



##### SuperOffice.CRM.Rows.SORTemplateRows.SORTemplateRowsIdx is Modified



#### SuperOffice.CRM.Rows.SourceGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SourceGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SourceGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SourceGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SourceGroupLinkRow.IdxSourcegrouplinkId is Modified



##### SuperOffice.CRM.Rows.SourceGroupLinkRow.SourceGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SourceGroupLinkRow.SourceGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SourceGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SourceGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SourceGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.SourceGroupLinkRows.IdxSourceId is Modified



##### SuperOffice.CRM.Rows.SourceGroupLinkRows.SourceGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SourceHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SourceHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SourceHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SourceHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SourceHeadingLinkRow.IdxSourceheadinglinkId is Modified



##### SuperOffice.CRM.Rows.SourceHeadingLinkRow.SourceHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SourceHeadingLinkRow.SourceHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SourceHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SourceHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SourceHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.SourceHeadingLinkRows.IdxSourceId is Modified



##### SuperOffice.CRM.Rows.SourceHeadingLinkRows.SourceHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SourceRecordData is Modified


#### SuperOffice.CRM.Rows.SourceRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SourceRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SourceRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SourceRow.IdxName is Modified



##### SuperOffice.CRM.Rows.SourceRow.IdxSourceId is Modified



##### SuperOffice.CRM.Rows.SourceRow.SourceRowIdx is Modified



##### SuperOffice.CRM.Rows.SourceRow.SourceRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SourceRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SourceRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SourceRows.SourceRowsIdx is Modified



#### SuperOffice.CRM.Rows.SPictureEntryRecordData is Modified


#### SuperOffice.CRM.Rows.SPictureEntryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SPictureEntryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SPictureEntryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SPictureEntryRow.IdxSPictureEntryId is Modified



##### SuperOffice.CRM.Rows.SPictureEntryRow.SPictureEntryRowIdx is Modified



##### SuperOffice.CRM.Rows.SPictureEntryRow.SPictureEntryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SPictureEntryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SPictureEntryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SPictureEntryRows.IdxAttachmentId is Modified



##### SuperOffice.CRM.Rows.SPictureEntryRows.SPictureEntryRowsIdx is Modified



#### SuperOffice.CRM.Rows.SPictureFolderRecordData is Modified


#### SuperOffice.CRM.Rows.SPictureFolderRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SPictureFolderRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SPictureFolderRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SPictureFolderRow.IdxSPictureFolderId is Modified



##### SuperOffice.CRM.Rows.SPictureFolderRow.SPictureFolderRowIdx is Modified



##### SuperOffice.CRM.Rows.SPictureFolderRow.SPictureFolderRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SPictureFolderRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SPictureFolderRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SPictureFolderRows.IdxFolderType is Modified



##### SuperOffice.CRM.Rows.SPictureFolderRows.IdxParentId is Modified



##### SuperOffice.CRM.Rows.SPictureFolderRows.IdxParentIdFolderType is Modified



##### SuperOffice.CRM.Rows.SPictureFolderRows.SPictureFolderRowsIdx is Modified



#### SuperOffice.CRM.Rows.SSentMessageRecordData is Modified


#### SuperOffice.CRM.Rows.SSentMessageRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SSentMessageRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SSentMessageRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SSentMessageRow.IdxSSentMessageId is Modified



##### SuperOffice.CRM.Rows.SSentMessageRow.SSentMessageRowIdx is Modified



##### SuperOffice.CRM.Rows.SSentMessageRow.SSentMessageRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SSentMessageRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SSentMessageRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SSentMessageRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.SSentMessageRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.SSentMessageRows.IdxShipmentId is Modified



##### SuperOffice.CRM.Rows.SSentMessageRows.SSentMessageRowsIdx is Modified



#### SuperOffice.CRM.Rows.SShipmentAddrRecordData is Modified


#### SuperOffice.CRM.Rows.SShipmentAddrRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SShipmentAddrRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SShipmentAddrRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SShipmentAddrRow.IdxSShipmentAddrId is Modified



##### SuperOffice.CRM.Rows.SShipmentAddrRow.SShipmentAddrRowIdx is Modified



##### SuperOffice.CRM.Rows.SShipmentAddrRow.SShipmentAddrRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SShipmentAddrRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SShipmentAddrRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SShipmentAddrRows.IdxAddress is Modified



##### SuperOffice.CRM.Rows.SShipmentAddrRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.SShipmentAddrRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.SShipmentAddrRows.IdxShipmentId is Modified



##### SuperOffice.CRM.Rows.SShipmentAddrRows.IdxStatus is Modified



##### SuperOffice.CRM.Rows.SShipmentAddrRows.IdxStatusShipmentId is Modified



##### SuperOffice.CRM.Rows.SShipmentAddrRows.IdxTicketId is Modified



##### SuperOffice.CRM.Rows.SShipmentAddrRows.SShipmentAddrRowsIdx is Modified



#### SuperOffice.CRM.Rows.SShipmentRecordData is Modified


#### SuperOffice.CRM.Rows.SShipmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SShipmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SShipmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SShipmentRow.IdxSShipmentId is Modified



##### SuperOffice.CRM.Rows.SShipmentRow.SShipmentRowIdx is Modified



##### SuperOffice.CRM.Rows.SShipmentRow.SShipmentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SShipmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SShipmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SShipmentRows.IdxAreStatisticsDirty is Modified



##### SuperOffice.CRM.Rows.SShipmentRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.SShipmentRows.SShipmentRowsIdx is Modified



#### SuperOffice.CRM.Rows.SSmtpServersRecordData is Modified


#### SuperOffice.CRM.Rows.SSmtpServersRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SSmtpServersRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SSmtpServersRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SSmtpServersRow.IdxSSmtpServersId is Modified



##### SuperOffice.CRM.Rows.SSmtpServersRow.SSmtpServersRowIdx is Modified



##### SuperOffice.CRM.Rows.SSmtpServersRow.SSmtpServersRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SSmtpServersRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SSmtpServersRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SSmtpServersRows.IdxShipmentId is Modified



##### SuperOffice.CRM.Rows.SSmtpServersRows.SSmtpServersRowsIdx is Modified



#### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRow.IdxStakeholderRoleGroupLinkId is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRow.StakeholderRoleGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRow.StakeholderRoleGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRows.IdxStakeholderRoleId is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleGroupLinkRows.StakeholderRoleGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRow.IdxStakeholderRoleHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRow.StakeholderRoleHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRow.StakeholderRoleHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRows.IdxStakeholderRoleId is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleHeadingLinkRows.StakeholderRoleHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.StakeholderRoleRecordData is Modified


#### SuperOffice.CRM.Rows.StakeholderRoleRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.StakeholderRoleRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.StakeholderRoleRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleRow.IdxName is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleRow.IdxStakeholderRoleId is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleRow.StakeholderRoleRowIdx is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleRow.StakeholderRoleRowIdxBase is Modified



#### SuperOffice.CRM.Rows.StakeholderRoleRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.StakeholderRoleRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.StakeholderRoleRows.StakeholderRoleRowsIdx is Modified



#### SuperOffice.CRM.Rows.StaticListRefRecordData is Modified


#### SuperOffice.CRM.Rows.StaticListRefRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.StaticListRefRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.StaticListRefRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.StaticListRefRow.IdxStaticListRefId is Modified



##### SuperOffice.CRM.Rows.StaticListRefRow.StaticListRefRowIdx is Modified



##### SuperOffice.CRM.Rows.StaticListRefRow.StaticListRefRowIdxBase is Modified



#### SuperOffice.CRM.Rows.StaticListRefRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.StaticListRefRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.StaticListRefRows.IdxListId is Modified



##### SuperOffice.CRM.Rows.StaticListRefRows.IdxRefId is Modified



##### SuperOffice.CRM.Rows.StaticListRefRows.StaticListRefRowsIdx is Modified



#### SuperOffice.CRM.Rows.StatusDefRecordData is Modified


#### SuperOffice.CRM.Rows.StatusDefRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.StatusDefRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.StatusDefRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.StatusDefRow.IdxStatusDefId is Modified



##### SuperOffice.CRM.Rows.StatusDefRow.StatusDefRowIdx is Modified



##### SuperOffice.CRM.Rows.StatusDefRow.StatusDefRowIdxBase is Modified



#### SuperOffice.CRM.Rows.StatusDefRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.StatusDefRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.StatusDefRows.StatusDefRowsIdx is Modified



#### SuperOffice.CRM.Rows.StatusValueRecordData is Modified


#### SuperOffice.CRM.Rows.StatusValueRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.StatusValueRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.StatusValueRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.StatusValueRow.IdxStatusValueId is Modified



##### SuperOffice.CRM.Rows.StatusValueRow.StatusValueRowIdx is Modified



##### SuperOffice.CRM.Rows.StatusValueRow.StatusValueRowIdxBase is Modified



#### SuperOffice.CRM.Rows.StatusValueRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.StatusValueRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxContactIdIsSignalled is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxContactIdIsSignalledStatusDefId is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxExtra1Id is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxExtra1IdIsSignalled is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxExtra1IdIsSignalledStatusDefId is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxExtra2Id is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxExtra2IdIsSignalled is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxExtra2IdIsSignalledStatusDefId is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxIsSignalled is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxPersonIdIsSignalled is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxPersonIdIsSignalledStatusDefId is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxProjectId is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxProjectIdIsSignalled is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxProjectIdIsSignalledStatusDefId is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.IdxStatusDefId is Modified



##### SuperOffice.CRM.Rows.StatusValueRows.StatusValueRowsIdx is Modified



#### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRow.IdxSubscriptionUnitGroupLinkId is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRow.SubscriptionUnitGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRow.SubscriptionUnitGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRows.IdxSubscriptionUnitId is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitGroupLinkRows.SubscriptionUnitGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRow.IdxSubscriptionUnitHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRow.SubscriptionUnitHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRow.SubscriptionUnitHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRows.IdxSubscriptionUnitId is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitHeadingLinkRows.SubscriptionUnitHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.SubscriptionUnitRecordData is Modified


#### SuperOffice.CRM.Rows.SubscriptionUnitRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SubscriptionUnitRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SubscriptionUnitRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitRow.IdxName is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitRow.IdxSubscriptionUnitId is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitRow.SubscriptionUnitRowIdx is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitRow.SubscriptionUnitRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SubscriptionUnitRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SubscriptionUnitRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SubscriptionUnitRows.SubscriptionUnitRowsIdx is Modified



#### SuperOffice.CRM.Rows.SuggestedAppointmentRecordData is Modified


#### SuperOffice.CRM.Rows.SuggestedAppointmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SuggestedAppointmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SuggestedAppointmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SuggestedAppointmentRow.IdxSuggestedAppointmentId is Modified



##### SuperOffice.CRM.Rows.SuggestedAppointmentRow.SuggestedAppointmentRowIdx is Modified



##### SuperOffice.CRM.Rows.SuggestedAppointmentRow.SuggestedAppointmentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SuggestedAppointmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SuggestedAppointmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SuggestedAppointmentRows.IdxName is Modified



##### SuperOffice.CRM.Rows.SuggestedAppointmentRows.IdxProjectTypeStatusLinkId is Modified



##### SuperOffice.CRM.Rows.SuggestedAppointmentRows.IdxSaleTypeStageLinkId is Modified



##### SuperOffice.CRM.Rows.SuggestedAppointmentRows.SuggestedAppointmentRowsIdx is Modified



#### SuperOffice.CRM.Rows.SuggestedDocumentRecordData is Modified


#### SuperOffice.CRM.Rows.SuggestedDocumentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SuggestedDocumentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SuggestedDocumentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SuggestedDocumentRow.IdxSuggestedDocumentId is Modified



##### SuperOffice.CRM.Rows.SuggestedDocumentRow.SuggestedDocumentRowIdx is Modified



##### SuperOffice.CRM.Rows.SuggestedDocumentRow.SuggestedDocumentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SuggestedDocumentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SuggestedDocumentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SuggestedDocumentRows.IdxName is Modified



##### SuperOffice.CRM.Rows.SuggestedDocumentRows.IdxProjectTypeStatusLinkId is Modified



##### SuperOffice.CRM.Rows.SuggestedDocumentRows.IdxSaleTypeStageLinkId is Modified



##### SuperOffice.CRM.Rows.SuggestedDocumentRows.SuggestedDocumentRowsIdx is Modified



#### SuperOffice.CRM.Rows.SuperListColumnSizeRecordData is Modified


#### SuperOffice.CRM.Rows.SuperListColumnSizeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SuperListColumnSizeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SuperListColumnSizeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SuperListColumnSizeRow.IdxSuperListColumnSizeId is Modified



##### SuperOffice.CRM.Rows.SuperListColumnSizeRow.SuperListColumnSizeRowIdx is Modified



##### SuperOffice.CRM.Rows.SuperListColumnSizeRow.SuperListColumnSizeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SuperListColumnSizeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SuperListColumnSizeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SuperListColumnSizeRows.IdxAssocId is Modified



##### SuperOffice.CRM.Rows.SuperListColumnSizeRows.IdxAssocIdListOwner is Modified



##### SuperOffice.CRM.Rows.SuperListColumnSizeRows.SuperListColumnSizeRowsIdx is Modified



#### SuperOffice.CRM.Rows.SWashingListRecordData is Modified


#### SuperOffice.CRM.Rows.SWashingListRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SWashingListRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SWashingListRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SWashingListRow.IdxSWashingListId is Modified



##### SuperOffice.CRM.Rows.SWashingListRow.SWashingListRowIdx is Modified



##### SuperOffice.CRM.Rows.SWashingListRow.SWashingListRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SWashingListRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SWashingListRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SWashingListRows.IdxListId is Modified



##### SuperOffice.CRM.Rows.SWashingListRows.SWashingListRowsIdx is Modified



#### SuperOffice.CRM.Rows.SWashingRecordData is Modified


#### SuperOffice.CRM.Rows.SWashingRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SWashingRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SWashingRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SWashingRow.IdxSWashingId is Modified



##### SuperOffice.CRM.Rows.SWashingRow.SWashingRowIdx is Modified



##### SuperOffice.CRM.Rows.SWashingRow.SWashingRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SWashingRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SWashingRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SWashingRows.SWashingRowsIdx is Modified



#### SuperOffice.CRM.Rows.SystemEventRecordData is Modified


#### SuperOffice.CRM.Rows.SystemEventRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SystemEventRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SystemEventRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SystemEventRow.IdxEventkeyScopeOwner is Modified



##### SuperOffice.CRM.Rows.SystemEventRow.IdxSystemEventId is Modified



##### SuperOffice.CRM.Rows.SystemEventRow.SystemEventRowIdx is Modified



##### SuperOffice.CRM.Rows.SystemEventRow.SystemEventRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SystemEventRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SystemEventRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SystemEventRows.IdxEventkey is Modified



##### SuperOffice.CRM.Rows.SystemEventRows.IdxEventkeyScope is Modified



##### SuperOffice.CRM.Rows.SystemEventRows.SystemEventRowsIdx is Modified



#### SuperOffice.CRM.Rows.SystemScriptRecordData is Modified


#### SuperOffice.CRM.Rows.SystemScriptRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.SystemScriptRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.SystemScriptRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SystemScriptRow.IdxSystemScriptId is Modified



##### SuperOffice.CRM.Rows.SystemScriptRow.SystemScriptRowIdx is Modified



##### SuperOffice.CRM.Rows.SystemScriptRow.SystemScriptRowIdxBase is Modified



#### SuperOffice.CRM.Rows.SystemScriptRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.SystemScriptRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.SystemScriptRows.SystemScriptRowsIdx is Modified



#### SuperOffice.CRM.Rows.TabOrderRecordData is Modified


#### SuperOffice.CRM.Rows.TabOrderRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TabOrderRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TabOrderRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TabOrderRow.IdxTabOrderId is Modified



##### SuperOffice.CRM.Rows.TabOrderRow.TabOrderRowIdx is Modified



##### SuperOffice.CRM.Rows.TabOrderRow.TabOrderRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TabOrderRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TabOrderRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TabOrderRows.IdxAssociateId is Modified



##### SuperOffice.CRM.Rows.TabOrderRows.IdxAssociateIdTabName is Modified



##### SuperOffice.CRM.Rows.TabOrderRows.TabOrderRowsIdx is Modified



#### SuperOffice.CRM.Rows.TagsGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.TagsGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TagsGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TagsGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TagsGroupLinkRow.IdxTagsGroupLinkId is Modified



##### SuperOffice.CRM.Rows.TagsGroupLinkRow.TagsGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.TagsGroupLinkRow.TagsGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TagsGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TagsGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TagsGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.TagsGroupLinkRows.IdxTagsId is Modified



##### SuperOffice.CRM.Rows.TagsGroupLinkRows.TagsGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.TagsHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.TagsHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TagsHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TagsHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TagsHeadingLinkRow.IdxTagsHeadingLinkId is Modified



##### SuperOffice.CRM.Rows.TagsHeadingLinkRow.TagsHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.TagsHeadingLinkRow.TagsHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TagsHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TagsHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TagsHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.TagsHeadingLinkRows.IdxTagsId is Modified



##### SuperOffice.CRM.Rows.TagsHeadingLinkRows.TagsHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.TagsRecordData is Modified


#### SuperOffice.CRM.Rows.TagsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TagsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TagsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TagsRow.IdxName is Modified



##### SuperOffice.CRM.Rows.TagsRow.IdxTagsId is Modified



##### SuperOffice.CRM.Rows.TagsRow.TagsRowIdx is Modified



##### SuperOffice.CRM.Rows.TagsRow.TagsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TagsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TagsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TagsRows.TagsRowsIdx is Modified



#### SuperOffice.CRM.Rows.TargetAssignmentInfoRecordData is Modified


#### SuperOffice.CRM.Rows.TargetAssignmentInfoRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TargetAssignmentInfoRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetAssignmentInfoRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetAssignmentInfoRow.IdxTargetAssignmentInfoId is Modified



##### SuperOffice.CRM.Rows.TargetAssignmentInfoRow.TargetAssignmentInfoRowIdx is Modified



##### SuperOffice.CRM.Rows.TargetAssignmentInfoRow.TargetAssignmentInfoRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TargetAssignmentInfoRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetAssignmentInfoRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetAssignmentInfoRows.IdxAssociateId is Modified



##### SuperOffice.CRM.Rows.TargetAssignmentInfoRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.TargetAssignmentInfoRows.IdxUsergroupId is Modified



##### SuperOffice.CRM.Rows.TargetAssignmentInfoRows.TargetAssignmentInfoRowsIdx is Modified



#### SuperOffice.CRM.Rows.TargetAssignmentValueRecordData is Modified


#### SuperOffice.CRM.Rows.TargetAssignmentValueRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TargetAssignmentValueRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetAssignmentValueRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetAssignmentValueRow.IdxTargetAssignmentValueId is Modified



##### SuperOffice.CRM.Rows.TargetAssignmentValueRow.TargetAssignmentValueRowIdx is Modified



##### SuperOffice.CRM.Rows.TargetAssignmentValueRow.TargetAssignmentValueRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TargetAssignmentValueRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetAssignmentValueRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetAssignmentValueRows.TargetAssignmentValueRowsIdx is Modified



#### SuperOffice.CRM.Rows.TargetChangeRecordData is Modified


#### SuperOffice.CRM.Rows.TargetChangeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TargetChangeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetChangeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetChangeRow.IdxTargetChangeId is Modified



##### SuperOffice.CRM.Rows.TargetChangeRow.TargetChangeRowIdx is Modified



##### SuperOffice.CRM.Rows.TargetChangeRow.TargetChangeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TargetChangeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetChangeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetChangeRows.IdxTargetRevisionId is Modified



##### SuperOffice.CRM.Rows.TargetChangeRows.TargetChangeRowsIdx is Modified



#### SuperOffice.CRM.Rows.TargetDimensionRecordData is Modified


#### SuperOffice.CRM.Rows.TargetDimensionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TargetDimensionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetDimensionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetDimensionRow.IdxTargetDimensionId is Modified



##### SuperOffice.CRM.Rows.TargetDimensionRow.TargetDimensionRowIdx is Modified



##### SuperOffice.CRM.Rows.TargetDimensionRow.TargetDimensionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TargetDimensionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetDimensionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetDimensionRows.IdxEntityType is Modified



##### SuperOffice.CRM.Rows.TargetDimensionRows.IdxSelectedDimensions is Modified



##### SuperOffice.CRM.Rows.TargetDimensionRows.TargetDimensionRowsIdx is Modified



#### SuperOffice.CRM.Rows.TargetGroupRecordData is Modified


#### SuperOffice.CRM.Rows.TargetGroupRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TargetGroupRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetGroupRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetGroupRow.IdxTargetGroupId is Modified



##### SuperOffice.CRM.Rows.TargetGroupRow.TargetGroupRowIdx is Modified



##### SuperOffice.CRM.Rows.TargetGroupRow.TargetGroupRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TargetGroupRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetGroupRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetGroupRows.TargetGroupRowsIdx is Modified



#### SuperOffice.CRM.Rows.TargetPeriodRecordData is Modified


#### SuperOffice.CRM.Rows.TargetPeriodRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TargetPeriodRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetPeriodRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetPeriodRow.IdxTargetPeriodId is Modified



##### SuperOffice.CRM.Rows.TargetPeriodRow.TargetPeriodRowIdx is Modified



##### SuperOffice.CRM.Rows.TargetPeriodRow.TargetPeriodRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TargetPeriodRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetPeriodRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetPeriodRows.TargetPeriodRowsIdx is Modified



#### SuperOffice.CRM.Rows.TargetRevisionHistoryRecordData is Modified


#### SuperOffice.CRM.Rows.TargetRevisionHistoryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TargetRevisionHistoryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetRevisionHistoryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetRevisionHistoryRow.IdxTargetGroupId is Modified



##### SuperOffice.CRM.Rows.TargetRevisionHistoryRow.IdxTargetRevisionHistoryId is Modified



##### SuperOffice.CRM.Rows.TargetRevisionHistoryRow.TargetRevisionHistoryRowIdx is Modified



##### SuperOffice.CRM.Rows.TargetRevisionHistoryRow.TargetRevisionHistoryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TargetRevisionHistoryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetRevisionHistoryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetRevisionHistoryRows.IdxTargetAssignmentInfoId is Modified



##### SuperOffice.CRM.Rows.TargetRevisionHistoryRows.TargetRevisionHistoryRowsIdx is Modified



#### SuperOffice.CRM.Rows.TargetRevisionRecordData is Modified


#### SuperOffice.CRM.Rows.TargetRevisionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TargetRevisionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetRevisionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetRevisionRow.IdxTargetRevisionId is Modified



##### SuperOffice.CRM.Rows.TargetRevisionRow.TargetRevisionRowIdx is Modified



##### SuperOffice.CRM.Rows.TargetRevisionRow.TargetRevisionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TargetRevisionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TargetRevisionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TargetRevisionRows.IdxAssignmentInfoId is Modified



##### SuperOffice.CRM.Rows.TargetRevisionRows.TargetRevisionRowsIdx is Modified



#### SuperOffice.CRM.Rows.TaskGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.TaskGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TaskGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TaskGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TaskGroupLinkRow.IdxTaskgrouplinkId is Modified



##### SuperOffice.CRM.Rows.TaskGroupLinkRow.TaskGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.TaskGroupLinkRow.TaskGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TaskGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TaskGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TaskGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.TaskGroupLinkRows.IdxTaskId is Modified



##### SuperOffice.CRM.Rows.TaskGroupLinkRows.TaskGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.TaskHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.TaskHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TaskHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TaskHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TaskHeadingLinkRow.IdxTaskheadinglinkId is Modified



##### SuperOffice.CRM.Rows.TaskHeadingLinkRow.TaskHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.TaskHeadingLinkRow.TaskHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TaskHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TaskHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TaskHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.TaskHeadingLinkRows.IdxTaskId is Modified



##### SuperOffice.CRM.Rows.TaskHeadingLinkRows.TaskHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.TaskRecordData is Modified


#### SuperOffice.CRM.Rows.TaskRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TaskRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TaskRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TaskRow.IdxName is Modified



##### SuperOffice.CRM.Rows.TaskRow.IdxTaskId is Modified



##### SuperOffice.CRM.Rows.TaskRow.TaskRowIdx is Modified



##### SuperOffice.CRM.Rows.TaskRow.TaskRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TaskRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TaskRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TaskRows.TaskRowsIdx is Modified



#### SuperOffice.CRM.Rows.TemporaryKeyRecordData is Modified


#### SuperOffice.CRM.Rows.TemporaryKeyRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TemporaryKeyRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TemporaryKeyRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TemporaryKeyRow.IdxTemporaryKeyId is Modified



##### SuperOffice.CRM.Rows.TemporaryKeyRow.TemporaryKeyRowIdx is Modified



##### SuperOffice.CRM.Rows.TemporaryKeyRow.TemporaryKeyRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TemporaryKeyRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TemporaryKeyRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TemporaryKeyRows.TemporaryKeyRowsIdx is Modified



#### SuperOffice.CRM.Rows.TemporaryWordsRecordData is Modified


#### SuperOffice.CRM.Rows.TemporaryWordsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TemporaryWordsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TemporaryWordsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TemporaryWordsRow.IdxTemporaryWordsId is Modified



##### SuperOffice.CRM.Rows.TemporaryWordsRow.TemporaryWordsRowIdx is Modified



##### SuperOffice.CRM.Rows.TemporaryWordsRow.TemporaryWordsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TemporaryWordsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TemporaryWordsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TemporaryWordsRows.IdxWord is Modified



##### SuperOffice.CRM.Rows.TemporaryWordsRows.IdxWordLength is Modified



##### SuperOffice.CRM.Rows.TemporaryWordsRows.TemporaryWordsRowsIdx is Modified



#### SuperOffice.CRM.Rows.TextRecordData is Modified


#### SuperOffice.CRM.Rows.TextRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TextRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TextRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TextRow.IdxTextId is Modified



##### SuperOffice.CRM.Rows.TextRow.TextRowIdx is Modified



##### SuperOffice.CRM.Rows.TextRow.TextRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TextRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TextRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TextRows.IdxOwnerId is Modified



##### SuperOffice.CRM.Rows.TextRows.IdxOwnerIdType is Modified



##### SuperOffice.CRM.Rows.TextRows.IdxText is Modified



##### SuperOffice.CRM.Rows.TextRows.TextRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketAlertRecordData is Modified


#### SuperOffice.CRM.Rows.TicketAlertRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketAlertRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketAlertRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketAlertRow.IdxTicketAlertId is Modified



##### SuperOffice.CRM.Rows.TicketAlertRow.TicketAlertRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketAlertRow.TicketAlertRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketAlertRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketAlertRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketAlertRows.IdxDelegateTo is Modified



##### SuperOffice.CRM.Rows.TicketAlertRows.IdxPriority is Modified



##### SuperOffice.CRM.Rows.TicketAlertRows.IdxReplyTemplateIdCatmast is Modified



##### SuperOffice.CRM.Rows.TicketAlertRows.IdxReplyTemplateIdCatmastSms is Modified



##### SuperOffice.CRM.Rows.TicketAlertRows.IdxReplyTemplateIdCustomer is Modified



##### SuperOffice.CRM.Rows.TicketAlertRows.IdxReplyTemplateIdEmail is Modified



##### SuperOffice.CRM.Rows.TicketAlertRows.IdxReplyTemplateIdSms is Modified



##### SuperOffice.CRM.Rows.TicketAlertRows.IdxReplyTemplateIdUser is Modified



##### SuperOffice.CRM.Rows.TicketAlertRows.IdxReplyTemplateIdUserSms is Modified



##### SuperOffice.CRM.Rows.TicketAlertRows.IdxRtiCustomerSms is Modified



##### SuperOffice.CRM.Rows.TicketAlertRows.IdxScriptId is Modified



##### SuperOffice.CRM.Rows.TicketAlertRows.TicketAlertRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketAttachmentRecordData is Modified


#### SuperOffice.CRM.Rows.TicketAttachmentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketAttachmentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketAttachmentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketAttachmentRow.IdxTicketAttachmentId is Modified



##### SuperOffice.CRM.Rows.TicketAttachmentRow.TicketAttachmentRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketAttachmentRow.TicketAttachmentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketAttachmentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketAttachmentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketAttachmentRows.IdxAttachmentId is Modified



##### SuperOffice.CRM.Rows.TicketAttachmentRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.TicketAttachmentRows.TicketAttachmentRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketCustomersRecordData is Modified


#### SuperOffice.CRM.Rows.TicketCustomersRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketCustomersRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketCustomersRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketCustomersRow.IdxTicketCustomersId is Modified



##### SuperOffice.CRM.Rows.TicketCustomersRow.TicketCustomersRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketCustomersRow.TicketCustomersRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketCustomersRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketCustomersRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketCustomersRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.TicketCustomersRows.IdxTicketId is Modified



##### SuperOffice.CRM.Rows.TicketCustomersRows.IdxTicketIdCustomerId is Modified



##### SuperOffice.CRM.Rows.TicketCustomersRows.TicketCustomersRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketLogActionRecordData is Modified


#### SuperOffice.CRM.Rows.TicketLogActionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketLogActionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketLogActionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketLogActionRow.IdxTicketLogActionId is Modified



##### SuperOffice.CRM.Rows.TicketLogActionRow.TicketLogActionRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketLogActionRow.TicketLogActionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketLogActionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketLogActionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketLogActionRows.IdxCustomerId is Modified



##### SuperOffice.CRM.Rows.TicketLogActionRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.TicketLogActionRows.IdxOrgTicketId is Modified



##### SuperOffice.CRM.Rows.TicketLogActionRows.IdxTicketId is Modified



##### SuperOffice.CRM.Rows.TicketLogActionRows.IdxUserId is Modified



##### SuperOffice.CRM.Rows.TicketLogActionRows.TicketLogActionRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketLogChangeRecordData is Modified


#### SuperOffice.CRM.Rows.TicketLogChangeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketLogChangeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketLogChangeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketLogChangeRow.IdxTicketLogChangeId is Modified



##### SuperOffice.CRM.Rows.TicketLogChangeRow.TicketLogChangeRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketLogChangeRow.TicketLogChangeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketLogChangeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketLogChangeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketLogChangeRows.IdxActionId is Modified



##### SuperOffice.CRM.Rows.TicketLogChangeRows.IdxExtraFieldId is Modified



##### SuperOffice.CRM.Rows.TicketLogChangeRows.IdxMessageId is Modified



##### SuperOffice.CRM.Rows.TicketLogChangeRows.IdxTicketId is Modified



##### SuperOffice.CRM.Rows.TicketLogChangeRows.TicketLogChangeRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketLogRecordData is Modified


#### SuperOffice.CRM.Rows.TicketLogRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketLogRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketLogRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketLogRow.IdxTicketLogId is Modified



##### SuperOffice.CRM.Rows.TicketLogRow.TicketLogRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketLogRow.TicketLogRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketLogRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketLogRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketLogRows.IdxLogCode is Modified



##### SuperOffice.CRM.Rows.TicketLogRows.IdxLogWhatValue2 is Modified



##### SuperOffice.CRM.Rows.TicketLogRows.IdxLogWhen is Modified



##### SuperOffice.CRM.Rows.TicketLogRows.IdxTicketId is Modified



##### SuperOffice.CRM.Rows.TicketLogRows.TicketLogRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketPriorityRecordData is Modified


#### SuperOffice.CRM.Rows.TicketPriorityRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketPriorityRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketPriorityRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketPriorityRow.IdxTicketPriorityId is Modified



##### SuperOffice.CRM.Rows.TicketPriorityRow.TicketPriorityRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketPriorityRow.TicketPriorityRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketPriorityRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketPriorityRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketPriorityRows.TicketPriorityRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketRecordData is Modified

* New items
  * Field `ProjectId`
  * Field `SaleId`

#### SuperOffice.CRM.Rows.TicketRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketRelationActionRecordData is Modified


#### SuperOffice.CRM.Rows.TicketRelationActionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketRelationActionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketRelationActionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketRelationActionRow.IdxTicketRelationActionId is Modified



##### SuperOffice.CRM.Rows.TicketRelationActionRow.TicketRelationActionRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketRelationActionRow.TicketRelationActionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketRelationActionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketRelationActionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketRelationActionRows.TicketRelationActionRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketRelationRecordData is Modified


#### SuperOffice.CRM.Rows.TicketRelationRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketRelationRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketRelationRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketRelationRow.IdxTicketRelationId is Modified



##### SuperOffice.CRM.Rows.TicketRelationRow.TicketRelationRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketRelationRow.TicketRelationRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketRelationRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketRelationRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketRelationRows.IdxSource is Modified



##### SuperOffice.CRM.Rows.TicketRelationRows.IdxTarget is Modified



##### SuperOffice.CRM.Rows.TicketRelationRows.TicketRelationRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketRelationTypeRecordData is Modified


#### SuperOffice.CRM.Rows.TicketRelationTypeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketRelationTypeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketRelationTypeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketRelationTypeRow.IdxTicketRelationTypeId is Modified



##### SuperOffice.CRM.Rows.TicketRelationTypeRow.TicketRelationTypeRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketRelationTypeRow.TicketRelationTypeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketRelationTypeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketRelationTypeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketRelationTypeRows.TicketRelationTypeRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketRow.IdxTicketId is Modified



##### SuperOffice.CRM.Rows.TicketRow.TicketRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketRow.TicketRowIdxBase is Modified


* New items
  * Property `ProjectId`
  * Property `SaleId`

#### SuperOffice.CRM.Rows.TicketRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxAlertTimeout is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxCategory is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxConnectId is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxCreatedAt is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxCreatedBy is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxCustId is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxDbiAgentId is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxDbiKey is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxDbiLastModified is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxDbiLastSyncronized is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxFilterId is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxOrigCategory is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxOrigPriority is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxOwnedBy is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxPriority is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxReadStatus is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxStatus is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxTags is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxTicketStatus is Modified



##### SuperOffice.CRM.Rows.TicketRows.IdxTicketType is Modified



##### SuperOffice.CRM.Rows.TicketRows.TicketRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketStatusHistoryRecordData is Modified


#### SuperOffice.CRM.Rows.TicketStatusHistoryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketStatusHistoryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketStatusHistoryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketStatusHistoryRow.IdxTicketStatusHistoryId is Modified



##### SuperOffice.CRM.Rows.TicketStatusHistoryRow.TicketStatusHistoryRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketStatusHistoryRow.TicketStatusHistoryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketStatusHistoryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketStatusHistoryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketStatusHistoryRows.IdxTicketId is Modified



##### SuperOffice.CRM.Rows.TicketStatusHistoryRows.IdxTicketStatus is Modified



##### SuperOffice.CRM.Rows.TicketStatusHistoryRows.TicketStatusHistoryRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketStatusRecordData is Modified


#### SuperOffice.CRM.Rows.TicketStatusRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketStatusRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketStatusRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketStatusRow.IdxTicketStatusId is Modified



##### SuperOffice.CRM.Rows.TicketStatusRow.TicketStatusRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketStatusRow.TicketStatusRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketStatusRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketStatusRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketStatusRows.IdxStatus is Modified



##### SuperOffice.CRM.Rows.TicketStatusRows.TicketStatusRowsIdx is Modified



#### SuperOffice.CRM.Rows.TicketTypeRecordData is Modified


#### SuperOffice.CRM.Rows.TicketTypeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TicketTypeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketTypeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketTypeRow.IdxTicketTypeId is Modified



##### SuperOffice.CRM.Rows.TicketTypeRow.TicketTypeRowIdx is Modified



##### SuperOffice.CRM.Rows.TicketTypeRow.TicketTypeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TicketTypeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TicketTypeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TicketTypeRows.TicketTypeRowsIdx is Modified



#### SuperOffice.CRM.Rows.TimestampsRecordData is Modified


#### SuperOffice.CRM.Rows.TimestampsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TimestampsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TimestampsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TimestampsRow.IdxTimestampsId is Modified



##### SuperOffice.CRM.Rows.TimestampsRow.TimestampsRowIdx is Modified



##### SuperOffice.CRM.Rows.TimestampsRow.TimestampsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TimestampsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TimestampsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TimestampsRows.TimestampsRowsIdx is Modified



#### SuperOffice.CRM.Rows.TravelCurrentRecordData is Modified


#### SuperOffice.CRM.Rows.TravelCurrentRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TravelCurrentRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TravelCurrentRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TravelCurrentRow.IdxTravelcurrentId is Modified



##### SuperOffice.CRM.Rows.TravelCurrentRow.TravelCurrentRowIdx is Modified



##### SuperOffice.CRM.Rows.TravelCurrentRow.TravelCurrentRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TravelCurrentRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TravelCurrentRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TravelCurrentRows.TravelCurrentRowsIdx is Modified



#### SuperOffice.CRM.Rows.TravelGeneratedDatabaseRecordData is Modified


#### SuperOffice.CRM.Rows.TravelGeneratedDatabaseRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TravelGeneratedDatabaseRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TravelGeneratedDatabaseRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TravelGeneratedDatabaseRow.IdxTravelgenerateddatabaseId is Modified



##### SuperOffice.CRM.Rows.TravelGeneratedDatabaseRow.TravelGeneratedDatabaseRowIdx is Modified



##### SuperOffice.CRM.Rows.TravelGeneratedDatabaseRow.TravelGeneratedDatabaseRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TravelGeneratedDatabaseRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TravelGeneratedDatabaseRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TravelGeneratedDatabaseRows.TravelGeneratedDatabaseRowsIdx is Modified



#### SuperOffice.CRM.Rows.TravelGeneratedTransactionRecordData is Modified


#### SuperOffice.CRM.Rows.TravelGeneratedTransactionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TravelGeneratedTransactionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TravelGeneratedTransactionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TravelGeneratedTransactionRow.IdxTravelgeneratedtransactionId is Modified



##### SuperOffice.CRM.Rows.TravelGeneratedTransactionRow.TravelGeneratedTransactionRowIdx is Modified



##### SuperOffice.CRM.Rows.TravelGeneratedTransactionRow.TravelGeneratedTransactionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TravelGeneratedTransactionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TravelGeneratedTransactionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TravelGeneratedTransactionRows.IdxTransmissionnumber is Modified



##### SuperOffice.CRM.Rows.TravelGeneratedTransactionRows.IdxTransmissionnumberTravelId is Modified



##### SuperOffice.CRM.Rows.TravelGeneratedTransactionRows.IdxTravelId is Modified



##### SuperOffice.CRM.Rows.TravelGeneratedTransactionRows.TravelGeneratedTransactionRowsIdx is Modified



#### SuperOffice.CRM.Rows.TravelIDMappingRecordData is Modified


#### SuperOffice.CRM.Rows.TravelIDMappingRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TravelIDMappingRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TravelIDMappingRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TravelIDMappingRow.IdxTravelidmappingId is Modified



##### SuperOffice.CRM.Rows.TravelIDMappingRow.TravelIDMappingRowIdx is Modified



##### SuperOffice.CRM.Rows.TravelIDMappingRow.TravelIDMappingRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TravelIDMappingRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TravelIDMappingRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TravelIDMappingRows.IdxAssociateId is Modified



##### SuperOffice.CRM.Rows.TravelIDMappingRows.IdxAssociateIdTableNumber is Modified



##### SuperOffice.CRM.Rows.TravelIDMappingRows.IdxAssociateIdTableNumberParentId is Modified



##### SuperOffice.CRM.Rows.TravelIDMappingRows.IdxLocalId is Modified



##### SuperOffice.CRM.Rows.TravelIDMappingRows.TravelIDMappingRowsIdx is Modified



#### SuperOffice.CRM.Rows.TravellerRecordData is Modified


#### SuperOffice.CRM.Rows.TravellerRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TravellerRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TravellerRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TravellerRow.IdxTravellerId is Modified



##### SuperOffice.CRM.Rows.TravellerRow.TravellerRowIdx is Modified



##### SuperOffice.CRM.Rows.TravellerRow.TravellerRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TravellerRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TravellerRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TravellerRows.TravellerRowsIdx is Modified



#### SuperOffice.CRM.Rows.TravelTransactionLogRecordData is Modified


#### SuperOffice.CRM.Rows.TravelTransactionLogRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TravelTransactionLogRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TravelTransactionLogRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TravelTransactionLogRow.IdxTraveltransactionlogId is Modified



##### SuperOffice.CRM.Rows.TravelTransactionLogRow.TravelTransactionLogRowIdx is Modified



##### SuperOffice.CRM.Rows.TravelTransactionLogRow.TravelTransactionLogRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TravelTransactionLogRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TravelTransactionLogRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TravelTransactionLogRows.IdxTablenumber is Modified



##### SuperOffice.CRM.Rows.TravelTransactionLogRows.IdxTablenumberRecordId is Modified



##### SuperOffice.CRM.Rows.TravelTransactionLogRows.IdxTtime is Modified



##### SuperOffice.CRM.Rows.TravelTransactionLogRows.IdxType is Modified



##### SuperOffice.CRM.Rows.TravelTransactionLogRows.IdxTypeTablenumber is Modified



##### SuperOffice.CRM.Rows.TravelTransactionLogRows.TravelTransactionLogRowsIdx is Modified



#### SuperOffice.CRM.Rows.TrayAppRecordData is Modified


#### SuperOffice.CRM.Rows.TrayAppRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TrayAppRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TrayAppRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TrayAppRow.IdxGuid is Modified



##### SuperOffice.CRM.Rows.TrayAppRow.IdxTrayAppId is Modified



##### SuperOffice.CRM.Rows.TrayAppRow.TrayAppRowIdx is Modified



##### SuperOffice.CRM.Rows.TrayAppRow.TrayAppRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TrayAppRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TrayAppRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TrayAppRows.IdxAssociateId is Modified



##### SuperOffice.CRM.Rows.TrayAppRows.TrayAppRowsIdx is Modified



#### SuperOffice.CRM.Rows.TreeExplorerEntryRecordData is Modified


#### SuperOffice.CRM.Rows.TreeExplorerEntryRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TreeExplorerEntryRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TreeExplorerEntryRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TreeExplorerEntryRow.IdxTreeExplorerEntryId is Modified



##### SuperOffice.CRM.Rows.TreeExplorerEntryRow.TreeExplorerEntryRowIdx is Modified



##### SuperOffice.CRM.Rows.TreeExplorerEntryRow.TreeExplorerEntryRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TreeExplorerEntryRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TreeExplorerEntryRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TreeExplorerEntryRows.IdxExpandOrder is Modified



##### SuperOffice.CRM.Rows.TreeExplorerEntryRows.IdxParentId is Modified



##### SuperOffice.CRM.Rows.TreeExplorerEntryRows.IdxSessionKey is Modified



##### SuperOffice.CRM.Rows.TreeExplorerEntryRows.IdxTreeKey is Modified



##### SuperOffice.CRM.Rows.TreeExplorerEntryRows.TreeExplorerEntryRowsIdx is Modified



#### SuperOffice.CRM.Rows.TreeExplorerLinkRecordData is Modified


#### SuperOffice.CRM.Rows.TreeExplorerLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TreeExplorerLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TreeExplorerLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TreeExplorerLinkRow.IdxTreeExplorerLinkId is Modified



##### SuperOffice.CRM.Rows.TreeExplorerLinkRow.TreeExplorerLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.TreeExplorerLinkRow.TreeExplorerLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TreeExplorerLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TreeExplorerLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TreeExplorerLinkRows.IdxEntryId is Modified



##### SuperOffice.CRM.Rows.TreeExplorerLinkRows.IdxSessionKey is Modified



##### SuperOffice.CRM.Rows.TreeExplorerLinkRows.TreeExplorerLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.TypicalSearchRecordData is Modified


#### SuperOffice.CRM.Rows.TypicalSearchRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TypicalSearchRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TypicalSearchRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TypicalSearchRow.IdxTypicalSearchId is Modified



##### SuperOffice.CRM.Rows.TypicalSearchRow.TypicalSearchRowIdx is Modified



##### SuperOffice.CRM.Rows.TypicalSearchRow.TypicalSearchRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TypicalSearchRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TypicalSearchRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TypicalSearchRows.IdxEntityName is Modified



##### SuperOffice.CRM.Rows.TypicalSearchRows.IdxEntityNameSource is Modified



##### SuperOffice.CRM.Rows.TypicalSearchRows.TypicalSearchRowsIdx is Modified



#### SuperOffice.CRM.Rows.TZDstRuleRecordData is Modified


#### SuperOffice.CRM.Rows.TZDstRuleRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TZDstRuleRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TZDstRuleRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TZDstRuleRow.IdxTZDstRuleId is Modified



##### SuperOffice.CRM.Rows.TZDstRuleRow.TZDstRuleRowIdx is Modified



##### SuperOffice.CRM.Rows.TZDstRuleRow.TZDstRuleRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TZDstRuleRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TZDstRuleRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TZDstRuleRows.IdxTZLocationId is Modified



##### SuperOffice.CRM.Rows.TZDstRuleRows.TZDstRuleRowsIdx is Modified



#### SuperOffice.CRM.Rows.TZLocationRecordData is Modified


#### SuperOffice.CRM.Rows.TZLocationRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TZLocationRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TZLocationRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TZLocationRow.IdxLocationCode is Modified



##### SuperOffice.CRM.Rows.TZLocationRow.IdxTZLocationId is Modified



##### SuperOffice.CRM.Rows.TZLocationRow.TZLocationRowIdx is Modified



##### SuperOffice.CRM.Rows.TZLocationRow.TZLocationRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TZLocationRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TZLocationRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TZLocationRows.TZLocationRowsIdx is Modified



#### SuperOffice.CRM.Rows.TZStdRuleRecordData is Modified


#### SuperOffice.CRM.Rows.TZStdRuleRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.TZStdRuleRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.TZStdRuleRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TZStdRuleRow.IdxTZStdRuleId is Modified



##### SuperOffice.CRM.Rows.TZStdRuleRow.TZStdRuleRowIdx is Modified



##### SuperOffice.CRM.Rows.TZStdRuleRow.TZStdRuleRowIdxBase is Modified



#### SuperOffice.CRM.Rows.TZStdRuleRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.TZStdRuleRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.TZStdRuleRows.IdxTZLocationId is Modified



##### SuperOffice.CRM.Rows.TZStdRuleRows.TZStdRuleRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDAppntLargeRecordData is Modified


#### SuperOffice.CRM.Rows.UDAppntLargeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDAppntLargeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDAppntLargeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDAppntLargeRow.IdxUdappntlargeId is Modified



##### SuperOffice.CRM.Rows.UDAppntLargeRow.UDAppntLargeRowIdx is Modified



##### SuperOffice.CRM.Rows.UDAppntLargeRow.UDAppntLargeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDAppntLargeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDAppntLargeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDAppntLargeRows.IdxString41 is Modified



##### SuperOffice.CRM.Rows.UDAppntLargeRows.IdxString42 is Modified



##### SuperOffice.CRM.Rows.UDAppntLargeRows.IdxString43 is Modified



##### SuperOffice.CRM.Rows.UDAppntLargeRows.IdxString44 is Modified



##### SuperOffice.CRM.Rows.UDAppntLargeRows.UDAppntLargeRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDAppntSmallRecordData is Modified


#### SuperOffice.CRM.Rows.UDAppntSmallRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDAppntSmallRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDAppntSmallRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRow.IdxUdappntsmallId is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRow.UDAppntSmallRowIdx is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRow.UDAppntSmallRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDAppntSmallRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDAppntSmallRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.IdxDouble01 is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.IdxDouble02 is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.IdxDouble03 is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.IdxDouble04 is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.IdxLong01 is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.IdxLong02 is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.IdxLong03 is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.IdxLong04 is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.IdxString01 is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.IdxString02 is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.IdxString03 is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.IdxString04 is Modified



##### SuperOffice.CRM.Rows.UDAppntSmallRows.UDAppntSmallRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDContactLargeRecordData is Modified


#### SuperOffice.CRM.Rows.UDContactLargeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDContactLargeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDContactLargeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDContactLargeRow.IdxUdcontactLargeId is Modified



##### SuperOffice.CRM.Rows.UDContactLargeRow.UDContactLargeRowIdx is Modified



##### SuperOffice.CRM.Rows.UDContactLargeRow.UDContactLargeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDContactLargeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDContactLargeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDContactLargeRows.IdxString41 is Modified



##### SuperOffice.CRM.Rows.UDContactLargeRows.IdxString42 is Modified



##### SuperOffice.CRM.Rows.UDContactLargeRows.IdxString43 is Modified



##### SuperOffice.CRM.Rows.UDContactLargeRows.IdxString44 is Modified



##### SuperOffice.CRM.Rows.UDContactLargeRows.UDContactLargeRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDContactSmallRecordData is Modified


#### SuperOffice.CRM.Rows.UDContactSmallRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDContactSmallRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDContactSmallRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRow.IdxUdcontactSmallId is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRow.UDContactSmallRowIdx is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRow.UDContactSmallRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDContactSmallRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDContactSmallRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.IdxDouble01 is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.IdxDouble02 is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.IdxDouble03 is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.IdxDouble04 is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.IdxLong01 is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.IdxLong02 is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.IdxLong03 is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.IdxLong04 is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.IdxString01 is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.IdxString02 is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.IdxString03 is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.IdxString04 is Modified



##### SuperOffice.CRM.Rows.UDContactSmallRows.UDContactSmallRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDDocLargeRecordData is Modified


#### SuperOffice.CRM.Rows.UDDocLargeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDDocLargeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDDocLargeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDDocLargeRow.IdxUddoclargeId is Modified



##### SuperOffice.CRM.Rows.UDDocLargeRow.UDDocLargeRowIdx is Modified



##### SuperOffice.CRM.Rows.UDDocLargeRow.UDDocLargeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDDocLargeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDDocLargeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDDocLargeRows.IdxString41 is Modified



##### SuperOffice.CRM.Rows.UDDocLargeRows.IdxString42 is Modified



##### SuperOffice.CRM.Rows.UDDocLargeRows.IdxString43 is Modified



##### SuperOffice.CRM.Rows.UDDocLargeRows.IdxString44 is Modified



##### SuperOffice.CRM.Rows.UDDocLargeRows.UDDocLargeRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDDocSmallRecordData is Modified


#### SuperOffice.CRM.Rows.UDDocSmallRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDDocSmallRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDDocSmallRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRow.IdxUddocsmallId is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRow.UDDocSmallRowIdx is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRow.UDDocSmallRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDDocSmallRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDDocSmallRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.IdxDouble01 is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.IdxDouble02 is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.IdxDouble03 is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.IdxDouble04 is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.IdxLong01 is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.IdxLong02 is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.IdxLong03 is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.IdxLong04 is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.IdxString01 is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.IdxString02 is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.IdxString03 is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.IdxString04 is Modified



##### SuperOffice.CRM.Rows.UDDocSmallRows.UDDocSmallRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDefFieldGLRecordData is Modified


#### SuperOffice.CRM.Rows.UDefFieldGLRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDefFieldGLRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDefFieldGLRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDefFieldGLRow.IdxUDefFieldGLId is Modified



##### SuperOffice.CRM.Rows.UDefFieldGLRow.UDefFieldGLRowIdx is Modified



##### SuperOffice.CRM.Rows.UDefFieldGLRow.UDefFieldGLRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDefFieldGLRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDefFieldGLRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDefFieldGLRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.UDefFieldGLRows.IdxUDefFieldId is Modified



##### SuperOffice.CRM.Rows.UDefFieldGLRows.UDefFieldGLRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDefFieldRecordData is Modified


#### SuperOffice.CRM.Rows.UDefFieldRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDefFieldRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDefFieldRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDefFieldRow.IdxUDefFieldId is Modified



##### SuperOffice.CRM.Rows.UDefFieldRow.UDefFieldRowIdx is Modified



##### SuperOffice.CRM.Rows.UDefFieldRow.UDefFieldRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDefFieldRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDefFieldRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDefFieldRows.IdxOwnerTableId is Modified



##### SuperOffice.CRM.Rows.UDefFieldRows.UDefFieldRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDListDefinitionRecordData is Modified


#### SuperOffice.CRM.Rows.UDListDefinitionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDListDefinitionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDListDefinitionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDListDefinitionRow.IdxName is Modified



##### SuperOffice.CRM.Rows.UDListDefinitionRow.IdxUDListDefinitionId is Modified



##### SuperOffice.CRM.Rows.UDListDefinitionRow.UDListDefinitionRowIdx is Modified



##### SuperOffice.CRM.Rows.UDListDefinitionRow.UDListDefinitionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDListDefinitionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDListDefinitionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDListDefinitionRows.UDListDefinitionRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDListGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.UDListGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDListGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDListGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDListGroupLinkRow.IdxUdlistgrouplinkId is Modified



##### SuperOffice.CRM.Rows.UDListGroupLinkRow.UDListGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.UDListGroupLinkRow.UDListGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDListGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDListGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDListGroupLinkRows.IdxGroupId is Modified



##### SuperOffice.CRM.Rows.UDListGroupLinkRows.IdxUDListId is Modified



##### SuperOffice.CRM.Rows.UDListGroupLinkRows.UDListGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDListHeadingLinkRecordData is Modified


#### SuperOffice.CRM.Rows.UDListHeadingLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDListHeadingLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDListHeadingLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDListHeadingLinkRow.IdxUdlistheadinglinkId is Modified



##### SuperOffice.CRM.Rows.UDListHeadingLinkRow.UDListHeadingLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.UDListHeadingLinkRow.UDListHeadingLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDListHeadingLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDListHeadingLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDListHeadingLinkRows.IdxHeadingId is Modified



##### SuperOffice.CRM.Rows.UDListHeadingLinkRows.IdxUDListId is Modified



##### SuperOffice.CRM.Rows.UDListHeadingLinkRows.UDListHeadingLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDListRecordData is Modified


#### SuperOffice.CRM.Rows.UDListRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDListRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDListRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDListRow.IdxUDListId is Modified



##### SuperOffice.CRM.Rows.UDListRow.UDListRowIdx is Modified



##### SuperOffice.CRM.Rows.UDListRow.UDListRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDListRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDListRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDListRows.IdxName is Modified



##### SuperOffice.CRM.Rows.UDListRows.UDListRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDPersonLargeRecordData is Modified


#### SuperOffice.CRM.Rows.UDPersonLargeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDPersonLargeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDPersonLargeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDPersonLargeRow.IdxUdpersonLargeId is Modified



##### SuperOffice.CRM.Rows.UDPersonLargeRow.UDPersonLargeRowIdx is Modified



##### SuperOffice.CRM.Rows.UDPersonLargeRow.UDPersonLargeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDPersonLargeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDPersonLargeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDPersonLargeRows.IdxString41 is Modified



##### SuperOffice.CRM.Rows.UDPersonLargeRows.IdxString42 is Modified



##### SuperOffice.CRM.Rows.UDPersonLargeRows.IdxString43 is Modified



##### SuperOffice.CRM.Rows.UDPersonLargeRows.IdxString44 is Modified



##### SuperOffice.CRM.Rows.UDPersonLargeRows.UDPersonLargeRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDPersonSmallRecordData is Modified


#### SuperOffice.CRM.Rows.UDPersonSmallRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDPersonSmallRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDPersonSmallRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRow.IdxUdpersonSmallId is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRow.UDPersonSmallRowIdx is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRow.UDPersonSmallRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDPersonSmallRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDPersonSmallRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.IdxDouble01 is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.IdxDouble02 is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.IdxDouble03 is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.IdxDouble04 is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.IdxLong01 is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.IdxLong02 is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.IdxLong03 is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.IdxLong04 is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.IdxString01 is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.IdxString02 is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.IdxString03 is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.IdxString04 is Modified



##### SuperOffice.CRM.Rows.UDPersonSmallRows.UDPersonSmallRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDProjectLargeRecordData is Modified


#### SuperOffice.CRM.Rows.UDProjectLargeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDProjectLargeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDProjectLargeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDProjectLargeRow.IdxUdprojectLargeId is Modified



##### SuperOffice.CRM.Rows.UDProjectLargeRow.UDProjectLargeRowIdx is Modified



##### SuperOffice.CRM.Rows.UDProjectLargeRow.UDProjectLargeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDProjectLargeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDProjectLargeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDProjectLargeRows.IdxString41 is Modified



##### SuperOffice.CRM.Rows.UDProjectLargeRows.IdxString42 is Modified



##### SuperOffice.CRM.Rows.UDProjectLargeRows.IdxString43 is Modified



##### SuperOffice.CRM.Rows.UDProjectLargeRows.IdxString44 is Modified



##### SuperOffice.CRM.Rows.UDProjectLargeRows.UDProjectLargeRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDProjectSmallRecordData is Modified


#### SuperOffice.CRM.Rows.UDProjectSmallRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDProjectSmallRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDProjectSmallRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRow.IdxUdprojectSmallId is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRow.UDProjectSmallRowIdx is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRow.UDProjectSmallRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDProjectSmallRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDProjectSmallRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.IdxDouble01 is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.IdxDouble02 is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.IdxDouble03 is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.IdxDouble04 is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.IdxLong01 is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.IdxLong02 is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.IdxLong03 is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.IdxLong04 is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.IdxString01 is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.IdxString02 is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.IdxString03 is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.IdxString04 is Modified



##### SuperOffice.CRM.Rows.UDProjectSmallRows.UDProjectSmallRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDSaleLargeRecordData is Modified


#### SuperOffice.CRM.Rows.UDSaleLargeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDSaleLargeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDSaleLargeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDSaleLargeRow.IdxUdsalelargeId is Modified



##### SuperOffice.CRM.Rows.UDSaleLargeRow.UDSaleLargeRowIdx is Modified



##### SuperOffice.CRM.Rows.UDSaleLargeRow.UDSaleLargeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDSaleLargeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDSaleLargeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDSaleLargeRows.IdxString41 is Modified



##### SuperOffice.CRM.Rows.UDSaleLargeRows.IdxString42 is Modified



##### SuperOffice.CRM.Rows.UDSaleLargeRows.IdxString43 is Modified



##### SuperOffice.CRM.Rows.UDSaleLargeRows.IdxString44 is Modified



##### SuperOffice.CRM.Rows.UDSaleLargeRows.UDSaleLargeRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDSaleSmallRecordData is Modified


#### SuperOffice.CRM.Rows.UDSaleSmallRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDSaleSmallRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDSaleSmallRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRow.IdxUdsalesmallId is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRow.UDSaleSmallRowIdx is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRow.UDSaleSmallRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDSaleSmallRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDSaleSmallRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.IdxDouble01 is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.IdxDouble02 is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.IdxDouble03 is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.IdxDouble04 is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.IdxLong01 is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.IdxLong02 is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.IdxLong03 is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.IdxLong04 is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.IdxString01 is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.IdxString02 is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.IdxString03 is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.IdxString04 is Modified



##### SuperOffice.CRM.Rows.UDSaleSmallRows.UDSaleSmallRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDTempLargeRecordData is Modified


#### SuperOffice.CRM.Rows.UDTempLargeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDTempLargeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDTempLargeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDTempLargeRow.IdxUdtempLargeId is Modified



##### SuperOffice.CRM.Rows.UDTempLargeRow.UDTempLargeRowIdx is Modified



##### SuperOffice.CRM.Rows.UDTempLargeRow.UDTempLargeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDTempLargeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDTempLargeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDTempLargeRows.UDTempLargeRowsIdx is Modified



#### SuperOffice.CRM.Rows.UDTempSmallRecordData is Modified


#### SuperOffice.CRM.Rows.UDTempSmallRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UDTempSmallRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDTempSmallRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDTempSmallRow.IdxUdtempSmallId is Modified



##### SuperOffice.CRM.Rows.UDTempSmallRow.UDTempSmallRowIdx is Modified



##### SuperOffice.CRM.Rows.UDTempSmallRow.UDTempSmallRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UDTempSmallRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UDTempSmallRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UDTempSmallRows.UDTempSmallRowsIdx is Modified



#### SuperOffice.CRM.Rows.URLRecordData is Modified


#### SuperOffice.CRM.Rows.URLRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.URLRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.URLRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.URLRow.IdxUrlId is Modified



##### SuperOffice.CRM.Rows.URLRow.URLRowIdx is Modified



##### SuperOffice.CRM.Rows.URLRow.URLRowIdxBase is Modified



#### SuperOffice.CRM.Rows.URLRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.URLRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.URLRows.IdxContactId is Modified



##### SuperOffice.CRM.Rows.URLRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.URLRows.IdxProjectId is Modified



##### SuperOffice.CRM.Rows.URLRows.IdxRank is Modified



##### SuperOffice.CRM.Rows.URLRows.IdxReservedId1 is Modified



##### SuperOffice.CRM.Rows.URLRows.IdxReservedId2 is Modified



##### SuperOffice.CRM.Rows.URLRows.IdxUrlAddress is Modified



##### SuperOffice.CRM.Rows.URLRows.URLRowsIdx is Modified



#### SuperOffice.CRM.Rows.UsageStatsRecordData is Modified


#### SuperOffice.CRM.Rows.UsageStatsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UsageStatsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UsageStatsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UsageStatsRow.IdxUsageStatsId is Modified



##### SuperOffice.CRM.Rows.UsageStatsRow.UsageStatsRowIdx is Modified



##### SuperOffice.CRM.Rows.UsageStatsRow.UsageStatsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UsageStatsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UsageStatsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UsageStatsRows.IdxAssocId is Modified



##### SuperOffice.CRM.Rows.UsageStatsRows.UsageStatsRowsIdx is Modified



#### SuperOffice.CRM.Rows.UserAttributeRecordData is Modified


#### SuperOffice.CRM.Rows.UserAttributeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UserAttributeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UserAttributeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UserAttributeRow.IdxUserAttributeId is Modified



##### SuperOffice.CRM.Rows.UserAttributeRow.UserAttributeRowIdx is Modified



##### SuperOffice.CRM.Rows.UserAttributeRow.UserAttributeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UserAttributeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UserAttributeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UserAttributeRows.IdxAttKey is Modified



##### SuperOffice.CRM.Rows.UserAttributeRows.IdxUserId is Modified



##### SuperOffice.CRM.Rows.UserAttributeRows.UserAttributeRowsIdx is Modified



#### SuperOffice.CRM.Rows.UserCandidateRecordData is Modified


#### SuperOffice.CRM.Rows.UserCandidateRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UserCandidateRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UserCandidateRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UserCandidateRow.IdxUserCandidateId is Modified



##### SuperOffice.CRM.Rows.UserCandidateRow.UserCandidateRowIdx is Modified



##### SuperOffice.CRM.Rows.UserCandidateRow.UserCandidateRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UserCandidateRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UserCandidateRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UserCandidateRows.IdxPersonId is Modified



##### SuperOffice.CRM.Rows.UserCandidateRows.IdxSecretKey is Modified



##### SuperOffice.CRM.Rows.UserCandidateRows.UserCandidateRowsIdx is Modified



#### SuperOffice.CRM.Rows.UserGroupLinkRecordData is Modified


#### SuperOffice.CRM.Rows.UserGroupLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UserGroupLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UserGroupLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UserGroupLinkRow.IdxUserGroupLinkId is Modified



##### SuperOffice.CRM.Rows.UserGroupLinkRow.UserGroupLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.UserGroupLinkRow.UserGroupLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UserGroupLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UserGroupLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UserGroupLinkRows.IdxAssocId is Modified



##### SuperOffice.CRM.Rows.UserGroupLinkRows.IdxUserGroupId is Modified



##### SuperOffice.CRM.Rows.UserGroupLinkRows.UserGroupLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.UserGroupRecordData is Modified


#### SuperOffice.CRM.Rows.UserGroupRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UserGroupRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UserGroupRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UserGroupRow.IdxName is Modified



##### SuperOffice.CRM.Rows.UserGroupRow.IdxUserGroupId is Modified



##### SuperOffice.CRM.Rows.UserGroupRow.UserGroupRowIdx is Modified



##### SuperOffice.CRM.Rows.UserGroupRow.UserGroupRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UserGroupRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UserGroupRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UserGroupRows.UserGroupRowsIdx is Modified



#### SuperOffice.CRM.Rows.UserPreferenceRecordData is Modified


#### SuperOffice.CRM.Rows.UserPreferenceRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UserPreferenceRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UserPreferenceRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UserPreferenceRow.IdxUserpreferenceId is Modified



##### SuperOffice.CRM.Rows.UserPreferenceRow.UserPreferenceRowIdx is Modified



##### SuperOffice.CRM.Rows.UserPreferenceRow.UserPreferenceRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UserPreferenceRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UserPreferenceRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UserPreferenceRows.IdxDeflevel is Modified



##### SuperOffice.CRM.Rows.UserPreferenceRows.IdxOwnerId is Modified



##### SuperOffice.CRM.Rows.UserPreferenceRows.IdxPrefkey is Modified



##### SuperOffice.CRM.Rows.UserPreferenceRows.IdxPrefsection is Modified



##### SuperOffice.CRM.Rows.UserPreferenceRows.IdxPrefsectionPrefkey is Modified



##### SuperOffice.CRM.Rows.UserPreferenceRows.IdxPrefsectionPrefkeyDeflevel is Modified



##### SuperOffice.CRM.Rows.UserPreferenceRows.IdxPrefsectionPrefkeyDeflevelOwnerId is Modified



##### SuperOffice.CRM.Rows.UserPreferenceRows.UserPreferenceRowsIdx is Modified



#### SuperOffice.CRM.Rows.UserRoleLinkRecordData is Modified


#### SuperOffice.CRM.Rows.UserRoleLinkRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.UserRoleLinkRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.UserRoleLinkRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UserRoleLinkRow.IdxUserRoleLinkId is Modified



##### SuperOffice.CRM.Rows.UserRoleLinkRow.UserRoleLinkRowIdx is Modified



##### SuperOffice.CRM.Rows.UserRoleLinkRow.UserRoleLinkRowIdxBase is Modified



#### SuperOffice.CRM.Rows.UserRoleLinkRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.UserRoleLinkRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.UserRoleLinkRows.UserRoleLinkRowsIdx is Modified



#### SuperOffice.CRM.Rows.VisibleForRecordData is Modified


#### SuperOffice.CRM.Rows.VisibleForRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.VisibleForRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.VisibleForRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.VisibleForRow.IdxVisibleForId is Modified



##### SuperOffice.CRM.Rows.VisibleForRow.VisibleForRowIdx is Modified



##### SuperOffice.CRM.Rows.VisibleForRow.VisibleForRowIdxBase is Modified



#### SuperOffice.CRM.Rows.VisibleForRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.VisibleForRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.VisibleForRows.IdxAppointmentId is Modified



##### SuperOffice.CRM.Rows.VisibleForRows.IdxRecordId is Modified



##### SuperOffice.CRM.Rows.VisibleForRows.IdxRecordIdTableId is Modified



##### SuperOffice.CRM.Rows.VisibleForRows.IdxSaleHistId is Modified



##### SuperOffice.CRM.Rows.VisibleForRows.IdxSaleId is Modified



##### SuperOffice.CRM.Rows.VisibleForRows.IdxSelectionId is Modified



##### SuperOffice.CRM.Rows.VisibleForRows.IdxTableId is Modified



##### SuperOffice.CRM.Rows.VisibleForRows.IdxTableIdRecordId is Modified



##### SuperOffice.CRM.Rows.VisibleForRows.IdxTableIdRecordIdForAll is Modified



##### SuperOffice.CRM.Rows.VisibleForRows.IdxTableIdRecordIdForAllForGroupId is Modified



##### SuperOffice.CRM.Rows.VisibleForRows.IdxTableIdRecordIdForAllForGroupIdForAssocId is Modified



##### SuperOffice.CRM.Rows.VisibleForRows.VisibleForRowsIdx is Modified



#### SuperOffice.CRM.Rows.WebAppUsageRecordData is Modified


#### SuperOffice.CRM.Rows.WebAppUsageRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.WebAppUsageRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.WebAppUsageRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.WebAppUsageRow.IdxWebAppUsageId is Modified



##### SuperOffice.CRM.Rows.WebAppUsageRow.WebAppUsageRowIdx is Modified



##### SuperOffice.CRM.Rows.WebAppUsageRow.WebAppUsageRowIdxBase is Modified



#### SuperOffice.CRM.Rows.WebAppUsageRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.WebAppUsageRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.WebAppUsageRows.IdxViewState is Modified



##### SuperOffice.CRM.Rows.WebAppUsageRows.IdxViewStateTimestamp is Modified



##### SuperOffice.CRM.Rows.WebAppUsageRows.IdxViewStateTimestampAssocId is Modified



##### SuperOffice.CRM.Rows.WebAppUsageRows.WebAppUsageRowsIdx is Modified



#### SuperOffice.CRM.Rows.WebhookRecordData is Modified


#### SuperOffice.CRM.Rows.WebhookRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.WebhookRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.WebhookRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.WebhookRow.IdxWebhookId is Modified



##### SuperOffice.CRM.Rows.WebhookRow.WebhookRowIdx is Modified



##### SuperOffice.CRM.Rows.WebhookRow.WebhookRowIdxBase is Modified



#### SuperOffice.CRM.Rows.WebhookRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.WebhookRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.WebhookRows.WebhookRowsIdx is Modified



#### SuperOffice.CRM.Rows.WebhookUsageRecordData is Modified


#### SuperOffice.CRM.Rows.WebhookUsageRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.WebhookUsageRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.WebhookUsageRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.WebhookUsageRow.IdxWebhookUsageId is Modified



##### SuperOffice.CRM.Rows.WebhookUsageRow.WebhookUsageRowIdx is Modified



##### SuperOffice.CRM.Rows.WebhookUsageRow.WebhookUsageRowIdxBase is Modified



#### SuperOffice.CRM.Rows.WebhookUsageRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.WebhookUsageRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.WebhookUsageRows.WebhookUsageRowsIdx is Modified



#### SuperOffice.CRM.Rows.WinPosSizeRecordData is Modified


#### SuperOffice.CRM.Rows.WinPosSizeRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.WinPosSizeRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.WinPosSizeRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.WinPosSizeRow.IdxWinPosSizeId is Modified



##### SuperOffice.CRM.Rows.WinPosSizeRow.WinPosSizeRowIdx is Modified



##### SuperOffice.CRM.Rows.WinPosSizeRow.WinPosSizeRowIdxBase is Modified



#### SuperOffice.CRM.Rows.WinPosSizeRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.WinPosSizeRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.WinPosSizeRows.IdxAssocId is Modified



##### SuperOffice.CRM.Rows.WinPosSizeRows.IdxAssocIdOwner is Modified



##### SuperOffice.CRM.Rows.WinPosSizeRows.WinPosSizeRowsIdx is Modified



#### SuperOffice.CRM.Rows.WordRelationsRecordData is Modified


#### SuperOffice.CRM.Rows.WordRelationsRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.WordRelationsRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.WordRelationsRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.WordRelationsRow.IdxWordRelationsId is Modified



##### SuperOffice.CRM.Rows.WordRelationsRow.WordRelationsRowIdx is Modified



##### SuperOffice.CRM.Rows.WordRelationsRow.WordRelationsRowIdxBase is Modified



#### SuperOffice.CRM.Rows.WordRelationsRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.WordRelationsRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.WordRelationsRows.IdxEntryId is Modified



##### SuperOffice.CRM.Rows.WordRelationsRows.IdxEntryWordId is Modified



##### SuperOffice.CRM.Rows.WordRelationsRows.WordRelationsRowsIdx is Modified



#### SuperOffice.CRM.Rows.WsdlDescriptionRecordData is Modified


#### SuperOffice.CRM.Rows.WsdlDescriptionRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.WsdlDescriptionRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.WsdlDescriptionRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.WsdlDescriptionRow.IdxWsdlDescriptionId is Modified



##### SuperOffice.CRM.Rows.WsdlDescriptionRow.WsdlDescriptionRowIdx is Modified



##### SuperOffice.CRM.Rows.WsdlDescriptionRow.WsdlDescriptionRowIdxBase is Modified



#### SuperOffice.CRM.Rows.WsdlDescriptionRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.WsdlDescriptionRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.WsdlDescriptionRows.WsdlDescriptionRowsIdx is Modified



#### SuperOffice.CRM.Rows.ZipToCityRecordData is Modified


#### SuperOffice.CRM.Rows.ZipToCityRecordDataExtensions is Modified


#### SuperOffice.CRM.Rows.ZipToCityRow is Modified

* Modified items

##### SuperOffice.CRM.Rows.ZipToCityRow.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ZipToCityRow.IdxZiptocityId is Modified



##### SuperOffice.CRM.Rows.ZipToCityRow.ZipToCityRowIdx is Modified



##### SuperOffice.CRM.Rows.ZipToCityRow.ZipToCityRowIdxBase is Modified



#### SuperOffice.CRM.Rows.ZipToCityRows is Modified

* Modified items

##### SuperOffice.CRM.Rows.ZipToCityRows.CustomSearch is Modified



##### SuperOffice.CRM.Rows.ZipToCityRows.IdxCity is Modified



##### SuperOffice.CRM.Rows.ZipToCityRows.IdxCountryId is Modified



##### SuperOffice.CRM.Rows.ZipToCityRows.IdxCountryIdZipcode is Modified



##### SuperOffice.CRM.Rows.ZipToCityRows.ZipToCityRowsIdx is Modified



#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* New items
  * Method `GetFacadeAssociateId(Int32)`
  * Method `GetUserDisplayValue(String, Int32)`

#### SuperOffice.Data.DatabaseStepAttribute is Modified


#### SuperOffice.Data.Dialect.Dialect is Modified

* New items
  * Method `ToSql(Greatest)`

#### SuperOffice.Data.Dictionary.DictionaryVersion is Modified


#### SuperOffice.Data.Dictionary.SoField is Modified

* New items
  * Property `DisplayDescription`
  * Property `DisplayName`

#### SuperOffice.Data.Dictionary.SoTable is Modified

* Modified items
  * Property `Item`
  * Property `Item`
  * Property `Item`
* New items
  * Property `DisplayDescription`
  * Property `DisplayName`

#### SuperOffice.Data.S is Modified

* Modified items

##### SuperOffice.Data.S.Math is Modified

* New items
  * Method `.MathNewGreatest(Argument, Argument)`
  * Method `.MathNewGreatest(Argument[])`


#### SuperOffice.Data.SQL.AddressTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.AllDayEventFieldInfo is Modified


#### SuperOffice.Data.SQL.AppAvailStateFieldInfo is Modified


#### SuperOffice.Data.SQL.AppointmentCautionWarningFieldInfo is Modified


#### SuperOffice.Data.SQL.AppointmentPrivateFieldInfo is Modified


#### SuperOffice.Data.SQL.AppointmentStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.AppointmentTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.AssociateTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.BlobLinkTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.ChatMessageSpecialTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.ChatMessageTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.ChatSessionFlagsFieldInfo is Modified


#### SuperOffice.Data.SQL.ChatSessionStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.ChatStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.ChatTopicFlagFieldInfo is Modified


#### SuperOffice.Data.SQL.ConfigTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.CredentialUsageFieldInfo is Modified


#### SuperOffice.Data.SQL.CrmActorTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.DashTileCurrencyModeFieldInfo is Modified


#### SuperOffice.Data.SQL.DashTileEntityTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.DashTileMeasureFieldInfo is Modified


#### SuperOffice.Data.SQL.DashTileTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.DashTileUsageFieldInfo is Modified


#### SuperOffice.Data.SQL.DeltaStateFieldInfo is Modified


#### SuperOffice.Data.SQL.DeltaTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.DesignTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.DocTmplDirectionFieldInfo is Modified


#### SuperOffice.Data.SQL.DocTmplInvitationTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.DocTmplPrivacyTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.DocTmplQuoteTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.DocTmplTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.DurationUnitFieldInfo is Modified


#### SuperOffice.Data.SQL.ElementStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.EmailAccountStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.EMailFlagsFieldInfo is Modified


#### SuperOffice.Data.SQL.EMailPriorityFieldInfo is Modified


#### SuperOffice.Data.SQL.EmailTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.ErpActorTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.ExecuteOnEventFieldInfo is Modified


#### SuperOffice.Data.SQL.FieldAccessFieldInfo is Modified


#### SuperOffice.Data.SQL.FieldMetadataTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.FormSubmissionStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.FormTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.FreeBusyFieldInfo is Modified


#### SuperOffice.Data.SQL.LicenseTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.LogEventFieldInfo is Modified


#### SuperOffice.Data.SQL.LoginFlagsFieldInfo is Modified


#### SuperOffice.Data.SQL.MailboxTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.NavigationFieldInfo is Modified


#### SuperOffice.Data.SQL.NotificationPlatformFieldInfo is Modified


#### SuperOffice.Data.SQL.PhoneTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.PrefDescAccessFlagsFieldInfo is Modified


#### SuperOffice.Data.SQL.PrefDescValueTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.PreferenceLevelFieldInfo is Modified


#### SuperOffice.Data.SQL.PublishTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.QuoteStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.QuoteVersionStateFieldInfo is Modified


#### SuperOffice.Data.SQL.RecipientSortingFieldInfo is Modified


#### SuperOffice.Data.SQL.RecurrencePatternFieldInfo is Modified


#### SuperOffice.Data.SQL.RefcountFlagsFieldInfo is Modified


#### SuperOffice.Data.SQL.ReplyTemplateBodyFlagsFieldInfo is Modified


#### SuperOffice.Data.SQL.RoleTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.SaleDoneFieldInfo is Modified


#### SuperOffice.Data.SQL.SaleStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.ScreenChooserTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.SelectionSystemTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.SelectionUnionTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.SenderMailModeFieldInfo is Modified


#### SuperOffice.Data.SQL.ServiceAuthStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.ShipmentAddrStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.ShipmentLinkActionFieldInfo is Modified


#### SuperOffice.Data.SQL.ShipmentLinkTaskFlagsFieldInfo is Modified


#### SuperOffice.Data.SQL.ShipmentLinkTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.ShipmentListStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.ShipmentMessageTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.ShipmentStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.ShowStateFieldInfo is Modified


#### SuperOffice.Data.SQL.ShowWindowStateFieldInfo is Modified


#### SuperOffice.Data.SQL.TargetAssignementLevelFieldInfo is Modified


#### SuperOffice.Data.SQL.TargetEntityTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.TargetMeasurementUnitFieldInfo is Modified


#### SuperOffice.Data.SQL.TargetPeriodTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.TaskDirectionFieldInfo is Modified


#### SuperOffice.Data.SQL.TaskTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.TemporaryKeyDomainFieldInfo is Modified


#### SuperOffice.Data.SQL.TextTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.TicketBaseStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.TicketCategoryDelegateMethodFieldInfo is Modified


#### SuperOffice.Data.SQL.TicketCategoryFlagsFieldInfo is Modified


#### SuperOffice.Data.SQL.TicketMessageCategoryFieldInfo is Modified


#### SuperOffice.Data.SQL.TicketMessageTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.TicketOriginFieldInfo is Modified


#### SuperOffice.Data.SQL.TicketPriorityEscalateEventFieldInfo is Modified


#### SuperOffice.Data.SQL.TicketPriorityFlagsFieldInfo is Modified


#### SuperOffice.Data.SQL.TicketPriorityStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.TicketReadStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.TicketSecurityLevelFieldInfo is Modified


#### SuperOffice.Data.SQL.TicketStatusTimeCounterFieldInfo is Modified


#### SuperOffice.Data.SQL.TravelEncryptionChildFieldInfo is Modified


#### SuperOffice.Data.SQL.TravelEncryptionOwnFieldInfo is Modified


#### SuperOffice.Data.SQL.TrlogTransTypeFieldInfo is Modified


#### SuperOffice.Data.SQL.TtlFlagsFieldInfo is Modified


#### SuperOffice.Data.SQL.UdefJustificationFieldInfo is Modified


#### SuperOffice.Data.SQL.ValueOverrideFieldInfo is Modified


#### SuperOffice.Data.SQL.VideoMeetingStatusFieldInfo is Modified


#### SuperOffice.Data.SQL.WebhookStateFieldInfo is Modified


#### SuperOffice.Data.SQL.WidgetRequiredFieldsFieldInfo is Modified


#### SuperOffice.Data.SQL.WidgetThemeFieldInfo is Modified


#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetTaskMenuGroupLinkTableInfo()`
  * Method `GetTaskMenuHeadingLinkTableInfo()`
  * Method `GetTaskMenuTableInfo()`

#### SuperOffice.Util.TargetHelper is Modified

* Deleted items
  * Method `GetDefaultValues()`
* New items
  * Method `GetDefaultValues(TargetPeriodType)`


### Assembly: SuperOffice.Plugins

### Assembly: SoLicense

### Modified Types

#### SuperOffice.License.SignatureCreator is Modified

* New items
  * Method `SignatureCreator(SignedPublicKey, DSACryptoServiceProvider, ILogger)`

#### SuperOffice.License.SignatureValidator is Modified

* New items
  * Method `SignatureValidator(SignedPublicKey, ILogger)`
  * Method `ComputeHash(SignedPublicKey, ILogger)`
  * Method `Validate(SignedPublicKey, ILogger)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.ArchiveBehaviour`
* `SuperOffice.CD.Database.BatchTaskCancellationBehaviour`
* `SuperOffice.CD.Database.ShowTaskItemInClient`
* `SuperOffice.CD.Database.TaskListItemType`
* `SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_06_TaskListItemTable`
* `SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_07_TaskMenuEncoding`
* `SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_08_TaskMenuPriming`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_33_EjMessageMessageIdLength`
* `SuperOffice.CD.DSL.Database.Steps_Notifications.ModifiedAppointmentFields`
* `SuperOffice.CD.DSL.Database.Steps_Notifications.Notifications_01_ModifiedAppointmentFields`
* `SuperOffice.CD.DSL.Database.SuperOffice_96_SOCompany`
* `SuperOffice.CD.DSL.Database.T_TaskMenu`
* `SuperOffice.CD.DSL.Database.T_TaskMenuGroupLink`
* `SuperOffice.CD.DSL.Database.T_TaskMenuHeadingLink`

### Modified Types

#### SuperOffice.CD.DSL.Database.T_AccessScript is Modified


#### SuperOffice.CD.DSL.Database.T_ActiveUser is Modified


#### SuperOffice.CD.DSL.Database.T_Address is Modified


#### SuperOffice.CD.DSL.Database.T_AddressFormat is Modified


#### SuperOffice.CD.DSL.Database.T_AmountClass is Modified


#### SuperOffice.CD.DSL.Database.T_AmountClassGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_AmountClassHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Appointment is Modified

* New items
  * Field `ModifiedAppointmentFields`

#### SuperOffice.CD.DSL.Database.T_Area is Modified


#### SuperOffice.CD.DSL.Database.T_AreaUserAssignment is Modified


#### SuperOffice.CD.DSL.Database.T_AreaUserInclusion is Modified


#### SuperOffice.CD.DSL.Database.T_Associate is Modified


#### SuperOffice.CD.DSL.Database.T_AssociateGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_AssociateHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_AssociateHistory is Modified


#### SuperOffice.CD.DSL.Database.T_Attachment is Modified


#### SuperOffice.CD.DSL.Database.T_AttachmentLocation is Modified


#### SuperOffice.CD.DSL.Database.T_AudienceConfig is Modified


#### SuperOffice.CD.DSL.Database.T_AudienceLayout is Modified


#### SuperOffice.CD.DSL.Database.T_AudienceLayoutLink is Modified


#### SuperOffice.CD.DSL.Database.T_AudienceVisibility is Modified


#### SuperOffice.CD.DSL.Database.T_Autosave is Modified


#### SuperOffice.CD.DSL.Database.T_BaseTZLocation is Modified


#### SuperOffice.CD.DSL.Database.T_BatchTask is Modified


#### SuperOffice.CD.DSL.Database.T_BatchTaskDefinition is Modified


#### SuperOffice.CD.DSL.Database.T_BinaryObject is Modified


#### SuperOffice.CD.DSL.Database.T_BinaryObjectLink is Modified


#### SuperOffice.CD.DSL.Database.T_Business is Modified


#### SuperOffice.CD.DSL.Database.T_BusinessGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_BusinessHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_CacheInvalidation is Modified


#### SuperOffice.CD.DSL.Database.T_CacheTables is Modified


#### SuperOffice.CD.DSL.Database.T_Category is Modified


#### SuperOffice.CD.DSL.Database.T_CategoryFamily is Modified


#### SuperOffice.CD.DSL.Database.T_CategoryGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_CategoryHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_CategoryMembership is Modified

* New items
  * Field `IsDefinedByUsergroup`

#### SuperOffice.CD.DSL.Database.T_ChatMessage is Modified


#### SuperOffice.CD.DSL.Database.T_ChatSession is Modified


#### SuperOffice.CD.DSL.Database.T_ChatTopic is Modified


#### SuperOffice.CD.DSL.Database.T_ChatTopicUser is Modified


#### SuperOffice.CD.DSL.Database.T_Company is Modified


#### SuperOffice.CD.DSL.Database.T_CompanyDomain is Modified


#### SuperOffice.CD.DSL.Database.T_Comptr is Modified


#### SuperOffice.CD.DSL.Database.T_ComptrGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_ComptrHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Config is Modified


#### SuperOffice.CD.DSL.Database.T_ConfigurableScreenAppliesTo is Modified


#### SuperOffice.CD.DSL.Database.T_ConfigurableScreenDelta is Modified


#### SuperOffice.CD.DSL.Database.T_ConnectionConfigField is Modified


#### SuperOffice.CD.DSL.Database.T_ConsentPerson is Modified


#### SuperOffice.CD.DSL.Database.T_ConsentPurpose is Modified


#### SuperOffice.CD.DSL.Database.T_ConsentSource is Modified


#### SuperOffice.CD.DSL.Database.T_Contact is Modified


#### SuperOffice.CD.DSL.Database.T_ContactInterest is Modified


#### SuperOffice.CD.DSL.Database.T_ContInt is Modified


#### SuperOffice.CD.DSL.Database.T_ContIntGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_ContIntHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_CounterValue is Modified


#### SuperOffice.CD.DSL.Database.T_Country is Modified


#### SuperOffice.CD.DSL.Database.T_CountryGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_CountryHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Credentials is Modified


#### SuperOffice.CD.DSL.Database.T_Credited is Modified


#### SuperOffice.CD.DSL.Database.T_CreditedGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_CreditedHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Currency is Modified


#### SuperOffice.CD.DSL.Database.T_CurrencyGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_CurrencyHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_CustCategory is Modified


#### SuperOffice.CD.DSL.Database.T_CustConfig is Modified


#### SuperOffice.CD.DSL.Database.T_CustLang is Modified


#### SuperOffice.CD.DSL.Database.T_Dashboard is Modified


#### SuperOffice.CD.DSL.Database.T_DashboardTheme is Modified


#### SuperOffice.CD.DSL.Database.T_DashboardTile is Modified


#### SuperOffice.CD.DSL.Database.T_DashboardTileDefinition is Modified


#### SuperOffice.CD.DSL.Database.T_DashboardTileField is Modified


#### SuperOffice.CD.DSL.Database.T_DatabaseModel is Modified


#### SuperOffice.CD.DSL.Database.T_DataRight is Modified


#### SuperOffice.CD.DSL.Database.T_DbiAgent is Modified


#### SuperOffice.CD.DSL.Database.T_DbiAgentField is Modified


#### SuperOffice.CD.DSL.Database.T_DbiAgentSchedule is Modified


#### SuperOffice.CD.DSL.Database.T_DeliveryTerms is Modified


#### SuperOffice.CD.DSL.Database.T_DeliveryTermsGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_DeliveryTermsHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_DeliveryType is Modified


#### SuperOffice.CD.DSL.Database.T_DeliveryTypeGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_DeliveryTypeHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_DiaryView is Modified


#### SuperOffice.CD.DSL.Database.T_DiaryViewRow is Modified


#### SuperOffice.CD.DSL.Database.T_Dictionary is Modified


#### SuperOffice.CD.DSL.Database.T_DictionaryBase is Modified


#### SuperOffice.CD.DSL.Database.T_DocDocument is Modified


#### SuperOffice.CD.DSL.Database.T_DocFolder is Modified


#### SuperOffice.CD.DSL.Database.T_DocTmpl is Modified


#### SuperOffice.CD.DSL.Database.T_DocTmplGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_DocTmplHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Document is Modified


#### SuperOffice.CD.DSL.Database.T_EabEntry is Modified


#### SuperOffice.CD.DSL.Database.T_EabFolder is Modified


#### SuperOffice.CD.DSL.Database.T_EjCategory is Modified


#### SuperOffice.CD.DSL.Database.T_EjCategoryGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_EjMessage is Modified


#### SuperOffice.CD.DSL.Database.T_Ejpackage is Modified


#### SuperOffice.CD.DSL.Database.T_EjpackageItem is Modified


#### SuperOffice.CD.DSL.Database.T_EjRole is Modified


#### SuperOffice.CD.DSL.Database.T_Ejscript is Modified


#### SuperOffice.CD.DSL.Database.T_EjscriptDebug is Modified


#### SuperOffice.CD.DSL.Database.T_Ejselection is Modified


#### SuperOffice.CD.DSL.Database.T_EjselEjsel is Modified


#### SuperOffice.CD.DSL.Database.T_EjselMetaResult is Modified


#### SuperOffice.CD.DSL.Database.T_EjselResultSet is Modified


#### SuperOffice.CD.DSL.Database.T_EjselSourceIdlist is Modified


#### SuperOffice.CD.DSL.Database.T_EjselSourceScript is Modified


#### SuperOffice.CD.DSL.Database.T_EjselSourceXml is Modified


#### SuperOffice.CD.DSL.Database.T_Ejuser is Modified


#### SuperOffice.CD.DSL.Database.T_ElementProfile is Modified


#### SuperOffice.CD.DSL.Database.T_Email is Modified


#### SuperOffice.CD.DSL.Database.T_EmailAccount is Modified


#### SuperOffice.CD.DSL.Database.T_EmailAttachment is Modified


#### SuperOffice.CD.DSL.Database.T_EmailFolder is Modified


#### SuperOffice.CD.DSL.Database.T_EmailItem is Modified


#### SuperOffice.CD.DSL.Database.T_ErpConfiguration is Modified


#### SuperOffice.CD.DSL.Database.T_ErpConnection is Modified


#### SuperOffice.CD.DSL.Database.T_ErpConnectionAccess is Modified


#### SuperOffice.CD.DSL.Database.T_ErpConnectionActorType is Modified


#### SuperOffice.CD.DSL.Database.T_ErpConnector is Modified


#### SuperOffice.CD.DSL.Database.T_ErpExternalKey is Modified


#### SuperOffice.CD.DSL.Database.T_ErpField is Modified


#### SuperOffice.CD.DSL.Database.T_ErpInternalKey is Modified


#### SuperOffice.CD.DSL.Database.T_ErpListItemMapping is Modified


#### SuperOffice.CD.DSL.Database.T_ErpSyncLog is Modified


#### SuperOffice.CD.DSL.Database.T_ExtApp is Modified


#### SuperOffice.CD.DSL.Database.T_ExtAppGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_ExtAppHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_ExtDatasource is Modified


#### SuperOffice.CD.DSL.Database.T_ExternalDocument is Modified


#### SuperOffice.CD.DSL.Database.T_ExternalEvent is Modified


#### SuperOffice.CD.DSL.Database.T_ExtField is Modified


#### SuperOffice.CD.DSL.Database.T_ExtraFields is Modified


#### SuperOffice.CD.DSL.Database.T_ExtraMenus is Modified


#### SuperOffice.CD.DSL.Database.T_ExtraTables is Modified


#### SuperOffice.CD.DSL.Database.T_ExtraTablesEntry is Modified


#### SuperOffice.CD.DSL.Database.T_ExtraTablesResult is Modified


#### SuperOffice.CD.DSL.Database.T_ExtTable is Modified


#### SuperOffice.CD.DSL.Database.T_Favourite is Modified


#### SuperOffice.CD.DSL.Database.T_FieldLabel is Modified


#### SuperOffice.CD.DSL.Database.T_ForeignApp is Modified


#### SuperOffice.CD.DSL.Database.T_ForeignDevice is Modified


#### SuperOffice.CD.DSL.Database.T_ForeignKey is Modified


#### SuperOffice.CD.DSL.Database.T_Form is Modified


#### SuperOffice.CD.DSL.Database.T_FormKeys is Modified


#### SuperOffice.CD.DSL.Database.T_FormSubmission is Modified


#### SuperOffice.CD.DSL.Database.T_FreeTextIndex is Modified


#### SuperOffice.CD.DSL.Database.T_FreeTextStopWords is Modified


#### SuperOffice.CD.DSL.Database.T_FreeTextWords is Modified


#### SuperOffice.CD.DSL.Database.T_FunctionRight is Modified


#### SuperOffice.CD.DSL.Database.T_FunctionRightRoleLink is Modified


#### SuperOffice.CD.DSL.Database.T_Heading is Modified


#### SuperOffice.CD.DSL.Database.T_Help is Modified


#### SuperOffice.CD.DSL.Database.T_Hierarchy is Modified


#### SuperOffice.CD.DSL.Database.T_History is Modified


#### SuperOffice.CD.DSL.Database.T_Hotlist is Modified


#### SuperOffice.CD.DSL.Database.T_ImportDefault is Modified


#### SuperOffice.CD.DSL.Database.T_ImportField is Modified


#### SuperOffice.CD.DSL.Database.T_ImportObject is Modified


#### SuperOffice.CD.DSL.Database.T_ImportRelation is Modified


#### SuperOffice.CD.DSL.Database.T_Inbox is Modified


#### SuperOffice.CD.DSL.Database.T_Intent is Modified


#### SuperOffice.CD.DSL.Database.T_IntentGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_IntentHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Invitation is Modified


#### SuperOffice.CD.DSL.Database.T_Invoice is Modified


#### SuperOffice.CD.DSL.Database.T_InvoiceEntry is Modified


#### SuperOffice.CD.DSL.Database.T_InvoiceSum is Modified


#### SuperOffice.CD.DSL.Database.T_InvoiceType is Modified


#### SuperOffice.CD.DSL.Database.T_ItemConfig is Modified


#### SuperOffice.CD.DSL.Database.T_KbAttachment is Modified


#### SuperOffice.CD.DSL.Database.T_KbCategory is Modified


#### SuperOffice.CD.DSL.Database.T_KbCategoryLog is Modified


#### SuperOffice.CD.DSL.Database.T_KbEntry is Modified


#### SuperOffice.CD.DSL.Database.T_KbEntryComment is Modified


#### SuperOffice.CD.DSL.Database.T_KbEntryKeyword is Modified


#### SuperOffice.CD.DSL.Database.T_KbEntryLog is Modified


#### SuperOffice.CD.DSL.Database.T_KbEntryWords is Modified


#### SuperOffice.CD.DSL.Database.T_KbGroup is Modified


#### SuperOffice.CD.DSL.Database.T_KbGroupEntry is Modified


#### SuperOffice.CD.DSL.Database.T_KbHttpLink is Modified


#### SuperOffice.CD.DSL.Database.T_KbSolutionFinder is Modified


#### SuperOffice.CD.DSL.Database.T_KbSolutionFinderEntry is Modified


#### SuperOffice.CD.DSL.Database.T_KbWorkflow is Modified


#### SuperOffice.CD.DSL.Database.T_KbWorkflowAccess is Modified


#### SuperOffice.CD.DSL.Database.T_LanguageInfo is Modified


#### SuperOffice.CD.DSL.Database.T_LanguageInfoCountry is Modified


#### SuperOffice.CD.DSL.Database.T_LegalBase is Modified


#### SuperOffice.CD.DSL.Database.T_LegalHtmlTags is Modified


#### SuperOffice.CD.DSL.Database.T_LicenseAssocLink is Modified


#### SuperOffice.CD.DSL.Database.T_LicenseSatlLink is Modified


#### SuperOffice.CD.DSL.Database.T_LocaleText is Modified


#### SuperOffice.CD.DSL.Database.T_Locking is Modified


#### SuperOffice.CD.DSL.Database.T_LogDebug is Modified


#### SuperOffice.CD.DSL.Database.T_LogEvents is Modified


#### SuperOffice.CD.DSL.Database.T_Login is Modified


#### SuperOffice.CD.DSL.Database.T_LoginCustomer is Modified


#### SuperOffice.CD.DSL.Database.T_MailAlias is Modified


#### SuperOffice.CD.DSL.Database.T_MailBlock is Modified


#### SuperOffice.CD.DSL.Database.T_MailInFilter is Modified


#### SuperOffice.CD.DSL.Database.T_MailInUidl is Modified


#### SuperOffice.CD.DSL.Database.T_MergeMoveLog is Modified


#### SuperOffice.CD.DSL.Database.T_Message is Modified


#### SuperOffice.CD.DSL.Database.T_MessageCustomers is Modified


#### SuperOffice.CD.DSL.Database.T_MessageHandler is Modified


#### SuperOffice.CD.DSL.Database.T_MessageHeader is Modified


#### SuperOffice.CD.DSL.Database.T_MessageId is Modified


#### SuperOffice.CD.DSL.Database.T_ModuleLicense is Modified


#### SuperOffice.CD.DSL.Database.T_ModuleOwner is Modified


#### SuperOffice.CD.DSL.Database.T_MrMrs is Modified


#### SuperOffice.CD.DSL.Database.T_MrMrsGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_MrMrsHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_MsFilter is Modified


#### SuperOffice.CD.DSL.Database.T_MsFilterMail is Modified


#### SuperOffice.CD.DSL.Database.T_MsSubstitute is Modified


#### SuperOffice.CD.DSL.Database.T_MsTrashbin is Modified


#### SuperOffice.CD.DSL.Database.T_NoticeFrame is Modified


#### SuperOffice.CD.DSL.Database.T_Notify is Modified


#### SuperOffice.CD.DSL.Database.T_OLEField is Modified


#### SuperOffice.CD.DSL.Database.T_OLEFieldText is Modified


#### SuperOffice.CD.DSL.Database.T_OLESubject is Modified


#### SuperOffice.CD.DSL.Database.T_OLESubjectText is Modified


#### SuperOffice.CD.DSL.Database.T_OLEView is Modified


#### SuperOffice.CD.DSL.Database.T_OLEViewText is Modified


#### SuperOffice.CD.DSL.Database.T_OnlineApp is Modified


#### SuperOffice.CD.DSL.Database.T_Outbox is Modified


#### SuperOffice.CD.DSL.Database.T_OutgoingMessage is Modified


#### SuperOffice.CD.DSL.Database.T_OwnerContactLink is Modified


#### SuperOffice.CD.DSL.Database.T_PasswordRules is Modified


#### SuperOffice.CD.DSL.Database.T_PaymentTerms is Modified


#### SuperOffice.CD.DSL.Database.T_PaymentTermsGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_PaymentTermsHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_PaymentType is Modified


#### SuperOffice.CD.DSL.Database.T_PaymentTypeGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_PaymentTypeHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_PersInt is Modified


#### SuperOffice.CD.DSL.Database.T_PersIntGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_PersIntHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Person is Modified


#### SuperOffice.CD.DSL.Database.T_PersonInterest is Modified


#### SuperOffice.CD.DSL.Database.T_PersPos is Modified


#### SuperOffice.CD.DSL.Database.T_PersPosGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_PersPosHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Phone is Modified


#### SuperOffice.CD.DSL.Database.T_PhoneFormat is Modified


#### SuperOffice.CD.DSL.Database.T_PMembType is Modified


#### SuperOffice.CD.DSL.Database.T_PMembTypeGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_PMembTypeHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_PrefDesc is Modified


#### SuperOffice.CD.DSL.Database.T_PrefDescLine is Modified


#### SuperOffice.CD.DSL.Database.T_Preference is Modified


#### SuperOffice.CD.DSL.Database.T_PriceList is Modified


#### SuperOffice.CD.DSL.Database.T_PriceUnit is Modified


#### SuperOffice.CD.DSL.Database.T_PriceUnitGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_PriceUnitHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Priority is Modified


#### SuperOffice.CD.DSL.Database.T_PriorityGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_PriorityHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Prob is Modified


#### SuperOffice.CD.DSL.Database.T_ProbGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_ProbHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Product is Modified


#### SuperOffice.CD.DSL.Database.T_ProductCategory is Modified


#### SuperOffice.CD.DSL.Database.T_ProductCategoryGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_ProductCategoryHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_ProductFamily is Modified


#### SuperOffice.CD.DSL.Database.T_ProductFamilyGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_ProductFamilyHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_ProductType is Modified


#### SuperOffice.CD.DSL.Database.T_ProductTypeGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_ProductTypeHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_ProductVersion is Modified


#### SuperOffice.CD.DSL.Database.T_Profile is Modified


#### SuperOffice.CD.DSL.Database.T_Project is Modified


#### SuperOffice.CD.DSL.Database.T_ProjectMember is Modified


#### SuperOffice.CD.DSL.Database.T_ProjectTypeStatusLink is Modified


#### SuperOffice.CD.DSL.Database.T_ProjStatus is Modified


#### SuperOffice.CD.DSL.Database.T_ProjStatusGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_ProjStatusHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_ProjType is Modified


#### SuperOffice.CD.DSL.Database.T_ProjTypeGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_ProjTypeHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Publish is Modified


#### SuperOffice.CD.DSL.Database.T_PushNotificationService is Modified


#### SuperOffice.CD.DSL.Database.T_QuickReply is Modified


#### SuperOffice.CD.DSL.Database.T_Quote is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteAlternative is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteApprReason is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteApprReasonGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteApprReasonHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteConnection is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteConnectionAccess is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteDenyReason is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteDenyReasonGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteDenyReasonHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteLine is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteLineConfiguration is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteVersion is Modified


#### SuperOffice.CD.DSL.Database.T_QuoteVersionAttachment is Modified


#### SuperOffice.CD.DSL.Database.T_Reason is Modified


#### SuperOffice.CD.DSL.Database.T_ReasonGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_ReasonHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_ReasonSold is Modified


#### SuperOffice.CD.DSL.Database.T_ReasonSoldGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_ReasonSoldHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_ReasonStalled is Modified


#### SuperOffice.CD.DSL.Database.T_ReasonStalledGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_ReasonStalledHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_RecurrenceRule is Modified


#### SuperOffice.CD.DSL.Database.T_RedLetterDay is Modified


#### SuperOffice.CD.DSL.Database.T_RefCountRange is Modified


#### SuperOffice.CD.DSL.Database.T_RefCounts is Modified


#### SuperOffice.CD.DSL.Database.T_Registry is Modified


#### SuperOffice.CD.DSL.Database.T_RejectReason is Modified


#### SuperOffice.CD.DSL.Database.T_RejectReasonGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_RejectReasonHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_RelationDefinition is Modified


#### SuperOffice.CD.DSL.Database.T_RelationDefinitionGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_RelationDefinitionHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Relations is Modified


#### SuperOffice.CD.DSL.Database.T_RelationTarget is Modified


#### SuperOffice.CD.DSL.Database.T_ReplyTemplate is Modified


#### SuperOffice.CD.DSL.Database.T_ReplyTemplateAttachment is Modified


#### SuperOffice.CD.DSL.Database.T_ReplyTemplateBody is Modified


#### SuperOffice.CD.DSL.Database.T_ReplyTemplateFolder is Modified


#### SuperOffice.CD.DSL.Database.T_ReporterListDef is Modified


#### SuperOffice.CD.DSL.Database.T_ResourceOverride is Modified


#### SuperOffice.CD.DSL.Database.T_Role is Modified


#### SuperOffice.CD.DSL.Database.T_RoleCategory is Modified


#### SuperOffice.CD.DSL.Database.T_RoleElement is Modified


#### SuperOffice.CD.DSL.Database.T_RoleMember is Modified


#### SuperOffice.CD.DSL.Database.T_RoleWorkflow is Modified


#### SuperOffice.CD.DSL.Database.T_SaintConfiguration is Modified


#### SuperOffice.CD.DSL.Database.T_Sale is Modified


#### SuperOffice.CD.DSL.Database.T_SaleHist is Modified


#### SuperOffice.CD.DSL.Database.T_SaleStakeholder is Modified


#### SuperOffice.CD.DSL.Database.T_SaleType is Modified


#### SuperOffice.CD.DSL.Database.T_SaleTypeCat is Modified


#### SuperOffice.CD.DSL.Database.T_SaleTypeCatGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_SaleTypeCatHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_SaleTypeGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_SaleTypeHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_SaleTypeQuoteAttachment is Modified


#### SuperOffice.CD.DSL.Database.T_SaleTypeStageLink is Modified


#### SuperOffice.CD.DSL.Database.T_Salutation is Modified


#### SuperOffice.CD.DSL.Database.T_SalutationGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_SalutationHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_Satellite is Modified


#### SuperOffice.CD.DSL.Database.T_SAttachment is Modified


#### SuperOffice.CD.DSL.Database.T_SBounceShipment is Modified


#### SuperOffice.CD.DSL.Database.T_Schedule is Modified


#### SuperOffice.CD.DSL.Database.T_ScheduledTask is Modified


#### SuperOffice.CD.DSL.Database.T_ScreenChooser is Modified


#### SuperOffice.CD.DSL.Database.T_ScreenDefinition is Modified


#### SuperOffice.CD.DSL.Database.T_ScreenDefinitionAction is Modified


#### SuperOffice.CD.DSL.Database.T_ScreenDefinitionElement is Modified


#### SuperOffice.CD.DSL.Database.T_ScreenDefinitionHidden is Modified


#### SuperOffice.CD.DSL.Database.T_ScreenDefinitionLanguage is Modified


#### SuperOffice.CD.DSL.Database.T_ScriptTrace is Modified


#### SuperOffice.CD.DSL.Database.T_ScriptTraceRun is Modified


#### SuperOffice.CD.DSL.Database.T_SDynCriteria is Modified


#### SuperOffice.CD.DSL.Database.T_SearchCat is Modified


#### SuperOffice.CD.DSL.Database.T_SearchCatGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_SearchCatHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_SearchCriteria is Modified


#### SuperOffice.CD.DSL.Database.T_SearchCriteriaGroup is Modified


#### SuperOffice.CD.DSL.Database.T_SearchCriterion is Modified


#### SuperOffice.CD.DSL.Database.T_SearchCriterionValue is Modified


#### SuperOffice.CD.DSL.Database.T_Selection is Modified


#### SuperOffice.CD.DSL.Database.T_SelectionMember is Modified


#### SuperOffice.CD.DSL.Database.T_Sequence is Modified


#### SuperOffice.CD.DSL.Database.T_ServiceAuth is Modified


#### SuperOffice.CD.DSL.Database.T_SessionObject is Modified


#### SuperOffice.CD.DSL.Database.T_ShipmentType is Modified


#### SuperOffice.CD.DSL.Database.T_ShipmentTypeReservation is Modified


#### SuperOffice.CD.DSL.Database.T_SLink is Modified


#### SuperOffice.CD.DSL.Database.T_SLinkCustomer is Modified


#### SuperOffice.CD.DSL.Database.T_SLinkCustomerStatical is Modified


#### SuperOffice.CD.DSL.Database.T_SList is Modified


#### SuperOffice.CD.DSL.Database.T_SListCustomer is Modified


#### SuperOffice.CD.DSL.Database.T_SListElement is Modified


#### SuperOffice.CD.DSL.Database.T_SListShipment is Modified


#### SuperOffice.CD.DSL.Database.T_SMessage is Modified


#### SuperOffice.CD.DSL.Database.T_SMessageblock is Modified


#### SuperOffice.CD.DSL.Database.T_Sms is Modified


#### SuperOffice.CD.DSL.Database.T_SmsHysteria is Modified


#### SuperOffice.CD.DSL.Database.T_Snapshot is Modified


#### SuperOffice.CD.DSL.Database.T_SoapAccess is Modified


#### SuperOffice.CD.DSL.Database.T_SORCriteria is Modified


#### SuperOffice.CD.DSL.Database.T_SORFCT is Modified


#### SuperOffice.CD.DSL.Database.T_SORField is Modified


#### SuperOffice.CD.DSL.Database.T_SORLabelLayout is Modified


#### SuperOffice.CD.DSL.Database.T_SOROperators is Modified


#### SuperOffice.CD.DSL.Database.T_SORPublish is Modified


#### SuperOffice.CD.DSL.Database.T_SORPublishGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_SORSection is Modified


#### SuperOffice.CD.DSL.Database.T_SORTemplate is Modified


#### SuperOffice.CD.DSL.Database.T_Source is Modified


#### SuperOffice.CD.DSL.Database.T_SourceGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_SourceHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_SPictureEntry is Modified


#### SuperOffice.CD.DSL.Database.T_SPictureFolder is Modified


#### SuperOffice.CD.DSL.Database.T_SSentMessage is Modified


#### SuperOffice.CD.DSL.Database.T_SShipment is Modified


#### SuperOffice.CD.DSL.Database.T_SShipmentAddr is Modified


#### SuperOffice.CD.DSL.Database.T_SSmtpServers is Modified


#### SuperOffice.CD.DSL.Database.T_StakeholderRole is Modified


#### SuperOffice.CD.DSL.Database.T_StakeholderRoleGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_StakeholderRoleHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_StaticListRef is Modified


#### SuperOffice.CD.DSL.Database.T_StatusDef is Modified


#### SuperOffice.CD.DSL.Database.T_StatusValue is Modified


#### SuperOffice.CD.DSL.Database.T_SubscriptionUnit is Modified


#### SuperOffice.CD.DSL.Database.T_SubscriptionUnitGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_SubscriptionUnitHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_SuggestedAppointment is Modified


#### SuperOffice.CD.DSL.Database.T_SuggestedDocument is Modified


#### SuperOffice.CD.DSL.Database.T_SuperListColumnSize is Modified


#### SuperOffice.CD.DSL.Database.T_SWashing is Modified


#### SuperOffice.CD.DSL.Database.T_SWashingList is Modified


#### SuperOffice.CD.DSL.Database.T_SystemEvent is Modified


#### SuperOffice.CD.DSL.Database.T_SystemScript is Modified


#### SuperOffice.CD.DSL.Database.T_TabOrder is Modified


#### SuperOffice.CD.DSL.Database.T_Tags is Modified


#### SuperOffice.CD.DSL.Database.T_TagsGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_TagsHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_TargetAssignmentInfo is Modified


#### SuperOffice.CD.DSL.Database.T_TargetAssignmentValue is Modified


#### SuperOffice.CD.DSL.Database.T_TargetChange is Modified


#### SuperOffice.CD.DSL.Database.T_TargetDimension is Modified


#### SuperOffice.CD.DSL.Database.T_TargetGroup is Modified


#### SuperOffice.CD.DSL.Database.T_TargetPeriod is Modified


#### SuperOffice.CD.DSL.Database.T_TargetRevision is Modified


#### SuperOffice.CD.DSL.Database.T_TargetRevisionHistory is Modified


#### SuperOffice.CD.DSL.Database.T_Task is Modified


#### SuperOffice.CD.DSL.Database.T_TaskGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_TaskHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_TemporaryKey is Modified


#### SuperOffice.CD.DSL.Database.T_TemporaryWords is Modified


#### SuperOffice.CD.DSL.Database.T_Text is Modified


#### SuperOffice.CD.DSL.Database.T_Ticket is Modified

* New items
  * Field `ProjectId`
  * Field `SaleId`

#### SuperOffice.CD.DSL.Database.T_TicketAlert is Modified


#### SuperOffice.CD.DSL.Database.T_TicketAttachment is Modified


#### SuperOffice.CD.DSL.Database.T_TicketCustomers is Modified


#### SuperOffice.CD.DSL.Database.T_TicketLog is Modified


#### SuperOffice.CD.DSL.Database.T_TicketLogAction is Modified


#### SuperOffice.CD.DSL.Database.T_TicketLogChange is Modified


#### SuperOffice.CD.DSL.Database.T_TicketPriority is Modified


#### SuperOffice.CD.DSL.Database.T_TicketRelation is Modified


#### SuperOffice.CD.DSL.Database.T_TicketRelationAction is Modified


#### SuperOffice.CD.DSL.Database.T_TicketRelationType is Modified


#### SuperOffice.CD.DSL.Database.T_TicketStatus is Modified


#### SuperOffice.CD.DSL.Database.T_TicketStatusHistory is Modified


#### SuperOffice.CD.DSL.Database.T_TicketType is Modified


#### SuperOffice.CD.DSL.Database.T_Timestamps is Modified


#### SuperOffice.CD.DSL.Database.T_TravelCurrent is Modified


#### SuperOffice.CD.DSL.Database.T_TravelGeneratedDatabase is Modified


#### SuperOffice.CD.DSL.Database.T_TravelGeneratedTransaction is Modified


#### SuperOffice.CD.DSL.Database.T_TravelIDMapping is Modified


#### SuperOffice.CD.DSL.Database.T_Traveller is Modified


#### SuperOffice.CD.DSL.Database.T_TravelTransactionLog is Modified


#### SuperOffice.CD.DSL.Database.T_TrayApp is Modified


#### SuperOffice.CD.DSL.Database.T_TreeExplorerEntry is Modified


#### SuperOffice.CD.DSL.Database.T_TreeExplorerLink is Modified


#### SuperOffice.CD.DSL.Database.T_TypicalSearch is Modified


#### SuperOffice.CD.DSL.Database.T_TZDstRule is Modified


#### SuperOffice.CD.DSL.Database.T_TZLocation is Modified


#### SuperOffice.CD.DSL.Database.T_TZStdRule is Modified


#### SuperOffice.CD.DSL.Database.T_UDAppntLarge is Modified


#### SuperOffice.CD.DSL.Database.T_UDAppntSmall is Modified


#### SuperOffice.CD.DSL.Database.T_UDContactLarge is Modified


#### SuperOffice.CD.DSL.Database.T_UDContactSmall is Modified


#### SuperOffice.CD.DSL.Database.T_UDDocLarge is Modified


#### SuperOffice.CD.DSL.Database.T_UDDocSmall is Modified


#### SuperOffice.CD.DSL.Database.T_UDefField is Modified


#### SuperOffice.CD.DSL.Database.T_UDefFieldGL is Modified


#### SuperOffice.CD.DSL.Database.T_UDList is Modified


#### SuperOffice.CD.DSL.Database.T_UDListDefinition is Modified


#### SuperOffice.CD.DSL.Database.T_UDListGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_UDListHeadingLink is Modified


#### SuperOffice.CD.DSL.Database.T_UDPersonLarge is Modified


#### SuperOffice.CD.DSL.Database.T_UDPersonSmall is Modified


#### SuperOffice.CD.DSL.Database.T_UDProjectLarge is Modified


#### SuperOffice.CD.DSL.Database.T_UDProjectSmall is Modified


#### SuperOffice.CD.DSL.Database.T_UDSaleLarge is Modified


#### SuperOffice.CD.DSL.Database.T_UDSaleSmall is Modified


#### SuperOffice.CD.DSL.Database.T_UDTempLarge is Modified


#### SuperOffice.CD.DSL.Database.T_UDTempSmall is Modified


#### SuperOffice.CD.DSL.Database.T_URL is Modified


#### SuperOffice.CD.DSL.Database.T_UsageStats is Modified


#### SuperOffice.CD.DSL.Database.T_UserAttribute is Modified


#### SuperOffice.CD.DSL.Database.T_UserCandidate is Modified


#### SuperOffice.CD.DSL.Database.T_UserGroup is Modified


#### SuperOffice.CD.DSL.Database.T_UserGroupLink is Modified


#### SuperOffice.CD.DSL.Database.T_UserPreference is Modified


#### SuperOffice.CD.DSL.Database.T_UserRoleLink is Modified


#### SuperOffice.CD.DSL.Database.T_VisibleFor is Modified


#### SuperOffice.CD.DSL.Database.T_WebAppUsage is Modified


#### SuperOffice.CD.DSL.Database.T_Webhook is Modified


#### SuperOffice.CD.DSL.Database.T_WebhookUsage is Modified


#### SuperOffice.CD.DSL.Database.T_WinPosSize is Modified


#### SuperOffice.CD.DSL.Database.T_WordRelations is Modified


#### SuperOffice.CD.DSL.Database.T_WsdlDescription is Modified


#### SuperOffice.CD.DSL.Database.T_ZipToCity is Modified




