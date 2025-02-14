---
uid: version_10.5.2.332_changes
date: 10.02.2025
---

<- [Back](../10.5.2-update.md)

## Changes from v10.5.1.871 and v10.5.2.332

---

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.AppointmentInfo is Modified

* New items
  * Property `IsPrivate`

#### SuperOffice.CRM.Services.IQuoteAgent is Modified

* New items
  * Method `CreateAndSaveQuoteLines(Int32, String[])`

#### SuperOffice.CRM.Services.Person is Modified

* New items
  * Property `PersonNumber`

#### SuperOffice.CRM.Services.QuoteAgent is Modified

* New items
  * Method `CreateAndSaveQuoteLines(Int32, String[])`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.Configuration.VersionProperties`
* `SuperOffice.Configuration.VersionPropertyNames`

### Modified Types

#### SuperOffice.Data.EventHandlerType is Modified

* New items
  * Field `SalesSplitTicket`

#### SuperOffice.Data.Registry is Modified

* Modified items
  * Field `AccessLicensePageWithoutLogin`
  * Field `ActiveLinksInMessages`
  * Field `AddedLegalHtmlCodeInUpgrade`
  * Field `AddedOptionsFcgi`
  * Field `AlertChatMessages`
  * Field `AllowedMailingLinksDomains`
  * Field `AllowSentryBypass`
  * Field `AllwaysSendMailToNewCustomers`
  * Field `AnonNSKey`
  * Field `ArriveNewTicket`
  * Field `AutoStartTimer`
  * Field `BaseURLForFAQCategory`
  * Field `BaseURLForFAQEntry`
  * Field `BlockCustomerFAQParsing`
  * Field `BlockLoginAttempts`
  * Field `BlockPanesRenderMode`
  * Field `CarrotPassword`
  * Field `CarrotUsername`
  * Field `CellphoneAndPhoneUpdateDone`
  * Field `CellphoneUpdateDone`
  * Field `ChatAvailableImage`
  * Field `ChatCheckForIdleSessions`
  * Field `ChatUnavailableImage`
  * Field `ChatUserIdleTime`
  * Field `ChatWhoisString`
  * Field `CheckHtmlValidityInSOEditor`
  * Field `CleanerImportOnOff`
  * Field `CleanerOnOff`
  * Field `CleanerThreshold`
  * Field `CleanerTolerance`
  * Field `CleanupLinefeedInNSMail`
  * Field `ClipMessagesLength`
  * Field `CollapsableMessageStrings`
  * Field `ComponentMaxWidth`
  * Field `ConverterDone`
  * Field `ConvertProfilesToClob`
  * Field `ConvertRegScreenChoosersToTable`
  * Field `CopyLDAPSearchBase`
  * Field `CreateExtraTableDbiFields`
  * Field `CrmGroup`
  * Field `CrmRoleAdmin`
  * Field `CrmRoleCustomer`
  * Field `CrmRoleStandard`
  * Field `CrossPostMergeTimeWindow`
  * Field `CrystalReportsSoapEndpoint`
  * Field `CSPHeader`
  * Field `CurlDisableStartTls`
  * Field `CurlMailTransferTimeout`
  * Field `CustomCacheBustingParameter`
  * Field `CustomerCenterTemplatesMovedToDB`
  * Field `CustomerEnableFAQAjax`
  * Field `CustomerEncryptionMethod`
  * Field `CustomNotifyEnabled`
  * Field `DBIBetaRelease`
  * Field `DBIExecutable`
  * Field `DbIntegratorEnableStreaming`
  * Field `DBSchemaDirty`
  * Field `DecodingMailSorter`
  * Field `DefaultBlogicScreensOnEditTicket`
  * Field `DefaultEditorBodyFont`
  * Field `DefaultEditorContent`
  * Field `DefaultNoCustomerOnForwarding`
  * Field `DefaultSmsCountry`
  * Field `DefaultStatusWhenTakingOwnership`
  * Field `DefaultTicketStatusClosed`
  * Field `DefaultTicketStatusConnected`
  * Field `DefaultTicketStatusDeleted`
  * Field `DefaultTicketStatusInactive`
  * Field `DefaultTicketStatusOpen`
  * Field `DefaultTimeToReplyOnNewTicket`
  * Field `DefaultTrackAllLinks`
  * Field `DelayMailboxImport`
  * Field `DelegateAlgorithm`
  * Field `DeleteInboxDays`
  * Field `DirtyTicketSaveEvent`
  * Field `DisableExternalSpmUpdate`
  * Field `DisableHtmlFiltering`
  * Field `DisableImportMailInlineSupport`
  * Field `DisableUnauthenticatedCreationInCustomerCentre`
  * Field `DisplayDataSources`
  * Field `DoNotAllowMultipleLogins`
  * Field `DoNotChangeSMRoles`
  * Field `DoNotKickLoginSessions`
  * Field `DoNotSearchBodyForTag`
  * Field `DoNotTestSmtp`
  * Field `DoNotUseCompanyCountry`
  * Field `EjournalCronLast`
  * Field `EjournalCronNow`
  * Field `EjournalOutbox`
  * Field `EjournalOutboxDelay`
  * Field `EjournalOutboxDeleteSentMailAfter`
  * Field `EjournalSender`
  * Field `EjSenderVersion`
  * Field `EmailImplementation`
  * Field `EmailSendingRetryLimit`
  * Field `EmarketeerNewLinkGraceDate`
  * Field `eMarketingEditorInNewWindow`
  * Field `EnableBackdoor`
  * Field `EnableEditMessage`
  * Field `EnableEjStat`
  * Field `EnableNewGui`
  * Field `EnableNewImportMail`
  * Field `EnableSpellCheck27`
  * Field `ExampleBounceFilterAdded`
  * Field `ExpiredWorkflowName`
  * Field `ExternalCustomerAuthEnabled`
  * Field `ExternalCustomerAuthURL`
  * Field `FacebookCallbackKey`
  * Field `FaqAddCommentsAccess`
  * Field `FaqReadCommentsAccess`
  * Field `FaqSuggestions`
  * Field `FaqTitleWeight`
  * Field `FastPersonRecipientSearch`
  * Field `FixCreationScripts`
  * Field `ForceHTTPS`
  * Field `ForceIEEdgeMode`
  * Field `ForceImmediateFileLogging`
  * Field `HideContactPersonPassword`
  * Field `HideExportButton`
  * Field `HideIntegratedEjSpmBlock`
  * Field `HideUserStatistics`
  * Field `IdleLimitCustomerSeconds`
  * Field `IdleLimitCustomerSecondsWeb`
  * Field `IgnoreReturnPath`
  * Field `ImageResizerExecutable`
  * Field `ImportMail3ExpireTime`
  * Field `ImportMail3ExpireTimeAnalyze`
  * Field `ImportmailCheckInvalidUTF8`
  * Field `ImportMailCreateUnknownPersons`
  * Field `ImportMailProcPri`
  * Field `ImportMailTimeout`
  * Field `ImportMessageAsAttachment`
  * Field `IncomingSmsBox`
  * Field `InlineImagesDefault`
  * Field `InternalMessageWhenNotCustomer`
  * Field `InvoiceEntrySumAdded`
  * Field `InvoiceUpdateDone`
  * Field `KeepDbLog`
  * Field `KeepExistingCustomerCenterTemplatesOnDisk`
  * Field `KeepFormKeys`
  * Field `KeepWarningLog`
  * Field `LastCleanedExpiredNotify`
  * Field `LastDiskSpaceWarningAttachments`
  * Field `LastDiskSpaceWarningBase`
  * Field `LastDiskSpaceWarningText`
  * Field `LastLicenseExpirationCheck`
  * Field `LastLicenseInfo`
  * Field `LastnameFirst`
  * Field `LastRequestDaysLimit`
  * Field `LastRequestTicketLimit`
  * Field `LimitSearchExtraTableResult`
  * Field `LogChannels`
  * Field `LogoutUrl`
  * Field `LogPath`
  * Field `MailFilterMinFaqValue`
  * Field `MailgunIncludeOutOfOffice`
  * Field `MailgunRewriteSenderHeader`
  * Field `MailingsUseEnvelopeFrom`
  * Field `MapiServerAppendString`
  * Field `MaxGridRows`
  * Field `MaximumCountRecipients`
  * Field `MaximumSmsMessagesPerDay`
  * Field `MaximumSmsMessagesPerRecipient`
  * Field `MaxLoginAttempts`
  * Field `MaxRowsForCharts`
  * Field `MinimumDiskSpace`
  * Field `MovedSystemScriptsToScreenChooser`
  * Field `NetServerKeepAlive`
  * Field `NetServerSmsProvider`
  * Field `NewInvoiceEntryFormat`
  * Field `NoEjOutbox`
  * Field `NotificationExpire`
  * Field `NotifyActiveTickets`
  * Field `NotifyActiveTicketsDays`
  * Field `NotifyFramePidGain`
  * Field `NotifyFramePidParamsDeprecated`
  * Field `NotifyFrameServerLoad`
  * Field `NotifyTimeOfDayForReport`
  * Field `NSConvertedProfiles`
  * Field `NSGetKeyPath`
  * Field `NsPluginConfig`
  * Field `NsPluginSender`
  * Field `NumOfListedLinks`
  * Field `OldMessageBeforeSignature`
  * Field `OptimizedCustomerCenterListTickets`
  * Field `OracleIndexesUpdated`
  * Field `OutmailWrapColumn`
  * Field `ParseCustomerFields`
  * Field `PasteFaq`
  * Field `PhoneUpdateDone`
  * Field `ProfilesConverted`
  * Field `PsWinComPassword`
  * Field `PsWinComSender`
  * Field `PsWinComUsername`
  * Field `PublishedWorkflowName`
  * Field `QueueTicketStatuses`
  * Field `QuickReplyMode`
  * Field `RecipientControlAdvancedSearch`
  * Field `RefreshNotifyFrameDeprecated`
  * Field `RegisterCustomerConfirmEmail`
  * Field `RegistryEntry_End`
  * Field `ReplacedLangFrWithSe`
  * Field `ReplyTemplateCustomerChatLog`
  * Field `ReplyTemplateCustomerConfirmEmail`
  * Field `ReplyTemplateCustomerCustomerReply`
  * Field `ReplyTemplateCustomerNewCustomer`
  * Field `ReplyTemplateCustomerPassword`
  * Field `ReplyTemplateHotlistNewMessage`
  * Field `ReplyTemplateHotlistTicketActivated`
  * Field `ReplyTemplateHotlistTicketAlarm`
  * Field `ReplyTemplateHotlistTicketTakenOver`
  * Field `ReplyTemplateLicenseExpirationWarning`
  * Field `ReplyTemplateNewLink`
  * Field `ReplyTemplatePrintTicket`
  * Field `ReplyTemplatePublishKbAnswer`
  * Field `ReplyTemplatePublishKbQuestion`
  * Field `ReplyTemplateUserActiveTickets`
  * Field `ReplyTemplateUserNewMessage`
  * Field `ReplyTemplateUserNewTicket`
  * Field `ReplyTemplateUserTicketActivated`
  * Field `ReplyTemplateUserTicketAlarm`
  * Field `ReplyTemplateUserTicketTakenOver`
  * Field `ReplyTemplateWeekStat`
  * Field `ReplyToAllOnlyLatestExternalMessage`
  * Field `ReplyToPrimaryEmail`
  * Field `ReportStartRootFolder`
  * Field `SandboxTicketMessages`
  * Field `SanitizeMailingsHtml`
  * Field `ScreenChooserAddMessage`
  * Field `ScreenChooserCategories`
  * Field `ScreenChooserEditTicket`
  * Field `ScreenChooserHelpPage`
  * Field `ScreenChooserInvoiceStat`
  * Field `ScreenChooserKnowledgeEditKbEntry`
  * Field `ScreenChooserKnowledgeListFolders`
  * Field `ScreenChooserKnowledgeViewKbEntry`
  * Field `ScreenChooserListTicketMessages`
  * Field `ScreenChooserListTicketTop`
  * Field `ScreenChooserNewTicket`
  * Field `ScreenChooserPriorities`
  * Field `ScreenChooserTicketMainMenu`
  * Field `ScreenChooserUsers`
  * Field `ScreenChooserViewCompany`
  * Field `ScreenChooserViewCustomer`
  * Field `SearchEngineCallback`
  * Field `SearchEngineFilters`
  * Field `SearchSubjectBeforeMsgId`
  * Field `SearchToSelections`
  * Field `SecurityModelEnabled`
  * Field `SelectCompanyColumns`
  * Field `SelectCustomerColumns`
  * Field `SelectTicketColumns`
  * Field `SentimentCalculationTimeframe`
  * Field `SetupCompanyAddress`
  * Field `SetupCompanyName`
  * Field `SetupFCGI`
  * Field `ShowAutoRepliesToCustomers`
  * Field `ShowAvatarsInCustomerCentre`
  * Field `ShowBlogicMenu`
  * Field `ShowOldReportsMenu`
  * Field `ShowReplyTemplatesToCustomers`
  * Field `ShowSubmitSpinner`
  * Field `ShowTotalInvoiceUnits`
  * Field `SLinkCleanUpDone`
  * Field `SmsChannel`
  * Field `SmsProvider`
  * Field `SmsSender`
  * Field `SmsServiceEndpoint`
  * Field `SmsServiceId`
  * Field `SMTPIgnoreLeadingDotEscaping`
  * Field `SmtpTimeout`
  * Field `SoapSystemUserPassword`
  * Field `SoapUseExtension`
  * Field `SpmConcurrentSMTPThreads`
  * Field `SpmDefaultFrom`
  * Field `SpmDefaultMailingRate`
  * Field `SpmHideNewMessageOption`
  * Field `SpmImgDBCopied`
  * Field `SpmMsgTicketParserUpdateDone`
  * Field `SpmOnlyPrimaryOnTicketSelection`
  * Field `SpmSMTPServer`
  * Field `SpmSMTPServerPort`
  * Field `SpmTimeToRestartSenders`
  * Field `SpmUseDeliveryReport`
  * Field `SpmUseHtmlEditor`
  * Field `StrictGDRPMode`
  * Field `StripNewLineInParser`
  * Field `SuperOfficeIntegrationPassword`
  * Field `SystemNSKey`
  * Field `SystemTimeMode`
  * Field `SystemTimeModeInstalled`
  * Field `Tele2Endpoint`
  * Field `Tele2SmsPassword`
  * Field `Tele2SmsUsername`
  * Field `TemporaryKeyHardDeleteDelay`
  * Field `TemporaryKeyTTL`
  * Field `ThumbnailsIsDefaultMode`
  * Field `TicketLogSystem`
  * Field `TimeKeyTTL`
  * Field `TimeZoneForNetServer`
  * Field `UnicodeConvertedTemplateFolder`
  * Field `UnpublishedWorkflowName`
  * Field `UpdateCustomerEmails`
  * Field `UpdatedActivateField`
  * Field `UpdateFaqAccessToWorkflowDone`
  * Field `UpdateTicketCustomersDone`
  * Field `UpdateUserDateFormatsDone`
  * Field `UpgradeCSParserConverted`
  * Field `UpgradeCustomerPasswordStatus`
  * Field `UpgradeNotPresentComment`
  * Field `UpgradeRolesConverted`
  * Field `UpgradeScreenDefinitionsToScripts`
  * Field `UpgradeTicketStatusName`
  * Field `UsageStatsDataAddNextRun`
  * Field `UsageStatsTableSizeNextRun`
  * Field `UsageStatsWebNextRun`
  * Field `UsageStatsWinNextRun`
  * Field `UseAbsoluteURLsInHTML`
  * Field `UseAttachmentFolders`
  * Field `UseAutoSuppressHeader`
  * Field `UseBrowserSpellCheck`
  * Field `UseCalltoOnPhoneLinks`
  * Field `UseCookieInCustomerCenter`
  * Field `UseEjParserForTemplates`
  * Field `UseExtension`
  * Field `UseFCGIImpersonation`
  * Field `UseFullText`
  * Field `UseHtmlRedirect`
  * Field `UseLegacyHtmlConverter`
  * Field `UseMiddleName`
  * Field `UseNetServerSms`
  * Field `UseOldHtmlSelectTreeLayout`
  * Field `UseOldMailInFilterRegExp`
  * Field `UseOnlyOneCookie`
  * Field `UseParserInDBIntegrator`
  * Field `UserAgentIsMobile`
  * Field `UserAgentIsTablet`
  * Field `UserGroupsConverted`
  * Field `UserOldScreensOnEditTicketDone`
  * Field `UserSignaturesConvertedToHtml`
  * Field `UserSyncResyncNextRun`
  * Field `UseSafeParserFunction`
  * Field `UseSha1OnLinks`
  * Field `UseSmsDeliveryReport`
  * Field `UseWebServiceSms`
  * Field `UseWordByWordKbSearch`
  * Field `ViewCompanyWithPanes`
  * Field `ViewCustomerWithPanes`
  * Field `ViewExtraTableEntryWithPanes`
  * Field `ViewTicketWithPanes`
  * Field `WeekStatRecipient`
  * Field `WwwPath`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_DIARY_SCHEDULING_TOOLTIP`
  * Field `SR_DIARY_SIDE_BY_SIDE_TOOLTIP`
  * Field `SR_DROP_CONVERT_TO_APPOINTMENT`
  * Field `SR_DROP_CONVERT_TO_TASK`
  * Field `SR_MOVE_ASSOCIATE_REASON`
  * Field `SR_TABS_REACHED_LIMIT`
  * Field `SR_TABS_TOO_MANY`


### Assembly: SoDatabase

### Modified Types

#### SuperOffice.CRM.Archives.PersonListItem is Modified

* New items
  * Property `PersonNumber`

#### SuperOffice.CRM.Lists.EmailAddressProvider is Modified


#### SuperOffice.CRM.Lists.EmailPhoneProvider is Modified


#### SuperOffice.Data.ServicePreferenceMappings is Modified

* Modified items

##### SuperOffice.Data.ServicePreferenceMappings.PreferenceMappingInfo is Modified

* New items
  * Field `.PreferenceMappingInfoDefaultValue`


#### SuperOffice.Data.SQL.TargetedSelect<MainTableInfo> is Modified

* New items
  * Method `SetOriginText(String)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### Modified Types

#### SuperOffice.CD.Database.ActivityStatus is Modified

* Modified items
  * Field `Completed`
  * Field `NotStarted`
  * Field `Started`
  * Field `Unknown`

#### SuperOffice.CD.Database.AddressType is Modified

* Modified items
  * Field `ContactPostalAddress`
  * Field `ContactStreetAddress`
  * Field `PersonPrivateAddress`
  * Field `QuoteBillingAddress`
  * Field `QuoteShippingAddress`
  * Field `Unknown`

#### SuperOffice.CD.Database.AiTextStyle is Modified

* Modified items
  * Field `Casual`
  * Field `Correct`
  * Field `Formal`
  * Field `None`
  * Field `Rephrase`

#### SuperOffice.CD.Database.AllDayEvent is Modified

* Modified items
  * Field `No`
  * Field `Yes`

#### SuperOffice.CD.Database.AppAvailState is Modified

* Modified items
  * Field `Always`
  * Field `CentralDb`
  * Field `SalesMarketingPocket`
  * Field `SalesMarketingWeb`
  * Field `SatelliteDb`
  * Field `TravelDb`

#### SuperOffice.CD.Database.AppointmentCautionWarning is Modified

* Modified items
  * Field `ExternalParticipantsDateTimeMismatch`
  * Field `IncomingRecurrenceChangeNotSupported`
  * Field `NotInSync`
  * Field `NotNotifiedByEmail`
  * Field `OK`
  * Field `RecurrencePatternNotSupported`

#### SuperOffice.CD.Database.AppointmentPrivate is Modified

* Modified items
  * Field `PrivateGroup`
  * Field `PrivateUser`
  * Field `Public`

#### SuperOffice.CD.Database.AppointmentStatus is Modified

* Modified items
  * Field `Assignment`
  * Field `AssignmentDeclined`
  * Field `AssignmentSeen`
  * Field `Booking`
  * Field `BookingDeclined`
  * Field `BookingDeleted`
  * Field `BookingMoved`
  * Field `BookingMovedSeen`
  * Field `BookingSeen`
  * Field `Completed`
  * Field `Hidden`
  * Field `NotStarted`
  * Field `Started`
  * Field `UnknownOrPostIt`

#### SuperOffice.CD.Database.AppointmentType is Modified

* Modified items
  * Field `BookingForChecklist`
  * Field `BookingForDiary`
  * Field `Document`
  * Field `inChecklist`
  * Field `inDiary`
  * Field `MergeDraft`
  * Field `MergeFinal`
  * Field `Note`
  * Field `SavedReport`
  * Field `Unknown`

#### SuperOffice.CD.Database.ArchiveBehaviour is Modified

* Modified items
  * Field `InArchives`
  * Field `MultiSelectInArchives`
  * Field `None`

#### SuperOffice.CD.Database.AssignmentStatus is Modified

* Modified items
  * Field `Assigning`
  * Field `Declined`
  * Field `None`
  * Field `Seen`
  * Field `Unknown`

#### SuperOffice.CD.Database.AssociateSourceType is Modified

* Modified items
  * Field `All`
  * Field `Department`
  * Field `DiaryViewList`
  * Field `History`
  * Field `Unknown`

#### SuperOffice.CD.Database.AssociateType is Modified

* Modified items
  * Field `Anonymous`
  * Field `AnonymousBit`
  * Field `Employee`
  * Field `ExternalPerson`
  * Field `NoCalenderBit`
  * Field `NoPersonBit`
  * Field `NoSentryBit`
  * Field `Resource`
  * Field `System`

#### SuperOffice.CD.Database.BatchTaskCancellationBehaviour is Modified

* Modified items
  * Field `CanCancel`
  * Field `CancelWithWarning`
  * Field `CannotCancel`

#### SuperOffice.CD.Database.BatchTaskState is Modified

* Modified items
  * Field `All`
  * Field `Aquired`
  * Field `Failed`
  * Field `New`
  * Field `Started`
  * Field `Succeeded`
  * Field `SucceededManualCleanup`
  * Field `Unknown`

#### SuperOffice.CD.Database.BlobLinkType is Modified

* Modified items
  * Field `AccessToken`
  * Field `BatchTask`
  * Field `ChatTopicImage`
  * Field `ContactImage`
  * Field `Dashboard`
  * Field `DashboardHtmlTileData`
  * Field `DashboardTile`
  * Field `EventImage`
  * Field `ExtraTableIcon`
  * Field `FormsBackgroundImage`
  * Field `PersonImage`
  * Field `ProductImage`
  * Field `ProductThumbnail`
  * Field `ProjectImage`
  * Field `QuoteLineImage`
  * Field `QuoteLineThumbnail`
  * Field `RefreshToken`
  * Field `StatusMonitorImage`
  * Field `Thumbnail`

#### SuperOffice.CD.Database.BookingType is Modified

* Modified items
  * Field `None`
  * Field `Owner`
  * Field `Participant`
  * Field `Unknown`

#### SuperOffice.CD.Database.CalMethod is Modified

* Modified items
  * Field `Add`
  * Field `Cancel`
  * Field `Counter`
  * Field `DeclineCounter`
  * Field `Publish`
  * Field `Refresh`
  * Field `Reply`
  * Field `Request`
  * Field `Unknown`

#### SuperOffice.CD.Database.CalReplyStatus is Modified

* Modified items
  * Field `Accepted`
  * Field `Declined`
  * Field `Tentative`
  * Field `Unknown`

#### SuperOffice.CD.Database.ChangePasswordType is Modified

* Modified items
  * Field `Email`
  * Field `Password`

#### SuperOffice.CD.Database.CheckoutState is Modified

* Modified items
  * Field `CheckedOutOther`
  * Field `CheckedOutOwn`
  * Field `LockingNotSupported`
  * Field `NotCheckedOut`

#### SuperOffice.CD.Database.ColorIndex is Modified

* Modified items
  * Field `BlueAlt1`
  * Field `BlueAlt2`
  * Field `BlueAlt3`
  * Field `DarkBlue`
  * Field `DarkGray`
  * Field `DarkGreen`
  * Field `DarkRed`
  * Field `DarkYellow`
  * Field `GrayAlt1`
  * Field `GrayAlt2`
  * Field `GrayAlt3`
  * Field `GreenAlt1`
  * Field `GreenAlt2`
  * Field `GreenAlt3`
  * Field `LightBlue`
  * Field `LightGray`
  * Field `LightGreen`
  * Field `LightRed`
  * Field `LightYellow`
  * Field `RedAlt1`
  * Field `RedAlt2`
  * Field `RedAlt3`
  * Field `YellowAlt1`
  * Field `YellowAlt2`
  * Field `YellowAlt3`

#### SuperOffice.CD.Database.CommandAction is Modified

* Modified items
  * Field `Implicit`
  * Field `Ok`
  * Field `OkCancel`
  * Field `YesNo`

#### SuperOffice.CD.Database.CommandActionResult is Modified

* Modified items
  * Field `Cancel`
  * Field `Implicit`
  * Field `No`
  * Field `Ok`
  * Field `Yes`

#### SuperOffice.CD.Database.ConceptualImageType is Modified

* Modified items
  * Field `EventImage`
  * Field `PersonImage`
  * Field `ProjectImage`
  * Field `StatusMonitorImage`
  * Field `Thumbnail`
  * Field `UndefinedImage`

#### SuperOffice.CD.Database.ContactAction is Modified

* Modified items
  * Field `ActivityCompleted`
  * Field `All`
  * Field `Created`
  * Field `DocumentAdded`
  * Field `NewActivity`
  * Field `PersonAdded`
  * Field `PersonUpdated`
  * Field `Unknown`
  * Field `Updated`

#### SuperOffice.CD.Database.ContactSourceType is Modified

* Modified items
  * Field `All`
  * Field `Diary`
  * Field `Favorites`
  * Field `History`
  * Field `Unknown`

#### SuperOffice.CD.Database.CredentialControlType is Modified

* Modified items
  * Field `Edit`
  * Field `Hidden`
  * Field `Link`
  * Field `Password`
  * Field `Static`

#### SuperOffice.CD.Database.CredentialUsage is Modified

* Modified items
  * Field `Inbound`
  * Field `Outbound`
  * Field `Session`

#### SuperOffice.CD.Database.CrmActorType is Modified

* Modified items
  * Field `Contact`
  * Field `Person`
  * Field `Project`
  * Field `Sale`
  * Field `Unknown`

#### SuperOffice.CD.Database.CustomFieldType is Modified

* Modified items
  * Field `Attachment`
  * Field `Blob`
  * Field `Checkbox`
  * Field `Date`
  * Field `DateTime`
  * Field `Decimal`
  * Field `DynamicLink`
  * Field `Integer`
  * Field `ListText`
  * Field `LongText`
  * Field `MdoList`
  * Field `RelationTo`
  * Field `ShortText`
  * Field `Time`
  * Field `TimeSpan`
  * Field `Unknown`

#### SuperOffice.CD.Database.DashboardLayout is Modified

* Modified items
  * Field `Four`
  * Field `None`
  * Field `One`
  * Field `ThreeESplit`
  * Field `ThreeTSplit`
  * Field `TwoHorizontalSplit`
  * Field `TwoVerticalSplit`

#### SuperOffice.CD.Database.DashboardTileEntityType is Modified

* Modified items
  * Field `Activity`
  * Field `Company`
  * Field `Document`
  * Field `Followup`
  * Field `None`
  * Field `Product`
  * Field `Project`
  * Field `Sale`
  * Field `WebPanel`

#### SuperOffice.CD.Database.DashboardTileOptionType is Modified

* Modified items
  * Field `Boolean`
  * Field `Integer`
  * Field `List`
  * Field `None`
  * Field `String`

#### SuperOffice.CD.Database.DashboardTileType is Modified

* Modified items
  * Field `Bignum`
  * Field `Chart`
  * Field `List`
  * Field `None`
  * Field `Web`

#### SuperOffice.CD.Database.DashTileCurrencyMode is Modified

* Modified items
  * Field `Base`
  * Field `None`
  * Field `Own`
  * Field `Specified`

#### SuperOffice.CD.Database.DashTileEntityType is Modified

* Modified items
  * Field `Appointment`
  * Field `Contact`
  * Field `None`
  * Field `Person`
  * Field `Project`
  * Field `Sale`

#### SuperOffice.CD.Database.DashTileMeasure is Modified

* Modified items
  * Field `Average`
  * Field `Count`
  * Field `CountAll`
  * Field `Max`
  * Field `Min`
  * Field `None`
  * Field `Sum`

#### SuperOffice.CD.Database.DashTileType is Modified

* Modified items
  * Field `Area`
  * Field `Bar`
  * Field `BigNum`
  * Field `Column`
  * Field `CombinedBarLine`
  * Field `CombinedColumnLine`
  * Field `Gauge`
  * Field `HTML`
  * Field `Line`
  * Field `List`
  * Field `None`
  * Field `Pie`
  * Field `WebPanel`

#### SuperOffice.CD.Database.DashTileUsage is Modified

* Modified items
  * Field `Dashboard`
  * Field `None`
  * Field `Selection`

#### SuperOffice.CD.Database.DeltaState is Modified

* Modified items
  * Field `Draft`
  * Field `Published`
  * Field `Unknown`

#### SuperOffice.CD.Database.DeltaType is Modified

* Modified items
  * Field `CustomFields`
  * Field `Customized`
  * Field `CustomObjectArchivePanel`
  * Field `System`
  * Field `Unknown`
  * Field `WebPanel`

#### SuperOffice.CD.Database.DocTmplDirection is Modified

* Modified items
  * Field `Incoming`
  * Field `Outgoing`
  * Field `SaintAll`
  * Field `Unknown`

#### SuperOffice.CD.Database.DocTmplInvitationType is Modified

* Modified items
  * Field `Cancelled`
  * Field `Changed`
  * Field `New`
  * Field `None`

#### SuperOffice.CD.Database.DocTmplPrivacyType is Modified

* Modified items
  * Field `None`
  * Field `PersonRegistered`

#### SuperOffice.CD.Database.DocTmplQuoteType is Modified

* Modified items
  * Field `ConfirmationLines`
  * Field `ConfirmationMailBody`
  * Field `MailBody`
  * Field `MainDocument`
  * Field `None`
  * Field `QuoteLines`

#### SuperOffice.CD.Database.DocTmplType is Modified

* Modified items
  * Field `Appointment`
  * Field `Document`
  * Field `Email`
  * Field `Fax`
  * Field `MergeDraft`
  * Field `MergeFinal`
  * Field `Phone`
  * Field `SavedReport`
  * Field `Todo`
  * Field `Unknown`

#### SuperOffice.CD.Database.DocumentHandler is Modified

* Modified items
  * Field `WebOnly`
  * Field `WebToolsAndOnline`

#### SuperOffice.CD.Database.DocumentLockSemantics is Modified

* Modified items
  * Field `Locking`
  * Field `None`
  * Field `Versioning`

#### SuperOffice.CD.Database.DurationUnit is Modified

* Modified items
  * Field `Century`
  * Field `Day`
  * Field `Decade`
  * Field `HalfYear`
  * Field `Hour`
  * Field `Millenium`
  * Field `Minute`
  * Field `Month`
  * Field `Quarter`
  * Field `Second`
  * Field `Unknown`
  * Field `Week`
  * Field `Year`

#### SuperOffice.CD.Database.EFieldRight is Modified

* Modified items
  * Field `FULL`
  * Field `None`
  * Field `Nullable`
  * Field `Read`
  * Field `UIHintMandatory`
  * Field `UIHintReadOnly`
  * Field `UIHints`
  * Field `Unused1`
  * Field `Unused2`
  * Field `Unused3`
  * Field `Unused4`
  * Field `Update`
  * Field `Write`

#### SuperOffice.CD.Database.EjUserStatus is Modified

* Modified items
  * Field `StatusDeleted`
  * Field `StatusNone`
  * Field `StatusNormal`
  * Field `StatusNotAvailable`
  * Field `StatusReadOnly`
  * Field `StatusSpm`
  * Field `StatusSystem`

#### SuperOffice.CD.Database.EMailFlags is Modified

* Modified items
  * Field `Answered`
  * Field `Deleted`
  * Field `Draft`
  * Field `Flagged`
  * Field `None`
  * Field `Recent`
  * Field `Seen`

#### SuperOffice.CD.Database.EmailFromType is Modified

* Modified items
  * Field `FromOnlySpecified`
  * Field `FromSalesContact`
  * Field `FromSupportContact`

#### SuperOffice.CD.Database.EMailMergeTargetType is Modified

* Modified items
  * Field `BestFit`
  * Field `Electronic`
  * Field `Fax`
  * Field `Mail`
  * Field `Printer`
  * Field `Xml`
  * Field `XmlFax`

#### SuperOffice.CD.Database.EMailPriority is Modified

* Modified items
  * Field `High`
  * Field `Highest`
  * Field `Low`
  * Field `Lowest`
  * Field `NoPriority`
  * Field `Normal`

#### SuperOffice.CD.Database.EmailReplyToType is Modified

* Modified items
  * Field `ReplyToEmpty`
  * Field `ReplyToOnlySpecified`
  * Field `ReplyToSalesContact`
  * Field `ReplyToSupportContact`

#### SuperOffice.CD.Database.EmailType is Modified

* Modified items
  * Field `Chat`
  * Field `Email`
  * Field `VoiP`

#### SuperOffice.CD.Database.ErpActorType is Modified

* Modified items
  * Field `Customer`
  * Field `Employee`
  * Field `Partner`
  * Field `Person`
  * Field `Project`
  * Field `Sale`
  * Field `Supplier`
  * Field `Unknown`

#### SuperOffice.CD.Database.ErpSyncResponseCode is Modified

* Modified items
  * Field `ErrorConnectorHasConnections`
  * Field `ErrorNotFound`
  * Field `NoError`

#### SuperOffice.CD.Database.ETableRight is Modified

* Modified items
  * Field `Delete`
  * Field `F`
  * Field `FI`
  * Field `Filtering`
  * Field `FULL`
  * Field `Insert`
  * Field `None`
  * Field `R`
  * Field `RestrictedUpdate`
  * Field `RF`
  * Field `RI`
  * Field `Select`
  * Field `UDR`
  * Field `Uninitialized`
  * Field `Unused1`
  * Field `Update`
  * Field `UR`
  * Field `URI`
  * Field `URU`
  * Field `WRITE`

#### SuperOffice.CD.Database.ExecuteOnEvent is Modified

* Modified items
  * Field `LocalUpdate`
  * Field `Logoff`
  * Field `Logon`
  * Field `Never`
  * Field `Wait`

#### SuperOffice.CD.Database.ExternalUserInfoModification is Modified

* Modified items
  * Field `Active`
  * Field `All`
  * Field `Password`
  * Field `Role`
  * Field `Unknown`
  * Field `UserName`

#### SuperOffice.CD.Database.ExtraDataFieldType is Modified

* Modified items
  * Field `Image`
  * Field `String`
  * Field `Url`

#### SuperOffice.CD.Database.ExtraFieldFlags is Modified

* Modified items
  * Field `CannotChange`
  * Field `Deleted`
  * Field `DontEscape`
  * Field `DropDown`
  * Field `Hidden`
  * Field `HideFunctions`
  * Field `HideHeaderIfEmpty`
  * Field `Indexed`
  * Field `InNewTicket`
  * Field `IsForeignId`
  * Field `IsId`
  * Field `ListRelations`
  * Field `Neutral`
  * Field `NotEmpty`
  * Field `Public`
  * Field `Readable`
  * Field `ReadOnly`
  * Field `Searchable`
  * Field `SetWhenClicked`
  * Field `ShowRelationInArchives`
  * Field `ShowWithProperties`
  * Field `UseDefault`
  * Field `ViewInList`
  * Field `ViewInSearch`

#### SuperOffice.CD.Database.FieldAccess is Modified

* Modified items
  * Field `Mandatory`
  * Field `Normal`
  * Field `ReadOnly`

#### SuperOffice.CD.Database.FieldDataType is Modified

* Modified items
  * Field `dbBlob`
  * Field `dbDateLocal`
  * Field `dbDateTimeLocal`
  * Field `dbDateTimeUTC`
  * Field `dbDouble`
  * Field `dbExtendedDateTimeLocal`
  * Field `dbExtendedDateTimeUTC`
  * Field `dbInt`
  * Field `dbIntId`
  * Field `dbIntIdArr`
  * Field `dbNull`
  * Field `dbShort`
  * Field `dbShortId`
  * Field `dbString`
  * Field `dbStringBlob`
  * Field `dbTimeLocal`
  * Field `dbUInt`
  * Field `dbUShort`
  * Field `Undefined`

#### SuperOffice.CD.Database.FieldMetadataType is Modified

* Modified items
  * Field `Checkbox`
  * Field `Date`
  * Field `Double`
  * Field `Integer`
  * Field `Label`
  * Field `List`
  * Field `Password`
  * Field `Text`

#### SuperOffice.CD.Database.FormsRecaptchaMode is Modified

* Modified items
  * Field `GlobalKeysExist`
  * Field `KeysNeeded`
  * Field `NotAvailable`

#### SuperOffice.CD.Database.FreeBusy is Modified

* Modified items
  * Field `Busy`
  * Field `Free`

#### SuperOffice.CD.Database.FreeTextOperator is Modified

* Modified items
  * Field `Contains`
  * Field `ExactMatch`
  * Field `StartsWith`

#### SuperOffice.CD.Database.GeneratorEncoding is Modified

* Modified items
  * Field `Html`
  * Field `Mime`
  * Field `MsExcel`
  * Field `MsOffice2007`
  * Field `MsOffice2007Xml`
  * Field `MsPowerpoint`
  * Field `MsWord`
  * Field `MsWord2007`
  * Field `OpenDocument`
  * Field `OpenDocumentXml`
  * Field `Pdf`
  * Field `Text`
  * Field `Url`
  * Field `UrlUnicode`
  * Field `Xml`

#### SuperOffice.CD.Database.HtmlSanitizerOptions is Modified

* Modified items
  * Field `Default`
  * Field `RemoveComment`

#### SuperOffice.CD.Database.ImageEmbedType is Modified

* Modified items
  * Field `Inline`
  * Field `Link`

#### SuperOffice.CD.Database.ImportAction is Modified

* Modified items
  * Field `ContactAdded`
  * Field `ContactNoChange`
  * Field `ContactUpdated`
  * Field `Obs`
  * Field `ObsERPDuplicate`
  * Field `PersonAdded`
  * Field `PersonNoChange`
  * Field `PersonUpdated`
  * Field `ProductAdded`
  * Field `ProductNoChange`
  * Field `ProductUpdated`
  * Field `Unknown`

#### SuperOffice.CD.Database.ImportBlankAction is Modified

* Modified items
  * Field `ImportPersonWithoutContact`
  * Field `Skip`
  * Field `UsePersonName`

#### SuperOffice.CD.Database.ImportCompanyDuplicateAction is Modified

* Modified items
  * Field `Skip`
  * Field `UseBlankName`
  * Field `UsePersonName`

#### SuperOffice.CD.Database.ImportContactDuplicateMatch is Modified

* Modified items
  * Field `Code`
  * Field `Id`
  * Field `Name`
  * Field `NameDepartment`
  * Field `Number`
  * Field `OrgNr`

#### SuperOffice.CD.Database.ImportDuplicateAction is Modified

* Modified items
  * Field `Add`
  * Field `MergeBlank`
  * Field `Replace`
  * Field `Skip`

#### SuperOffice.CD.Database.ImportEntityType is Modified

* Modified items
  * Field `Contact`
  * Field `Person`
  * Field `Product`
  * Field `Unknown`

#### SuperOffice.CD.Database.ImportNewListItem is Modified

* Modified items
  * Field `AddItemToList`
  * Field `SetToBlank`
  * Field `SetToDefault`

#### SuperOffice.CD.Database.ImportPersonDuplicateMatch is Modified

* Modified items
  * Field `EMailAddress`
  * Field `FullName`
  * Field `Id`
  * Field `MobilePhone`
  * Field `None`
  * Field `Number`

#### SuperOffice.CD.Database.ImportPhoneUrlsEmail is Modified

* Modified items
  * Field `AddToList`
  * Field `Replace`
  * Field `Skip`

#### SuperOffice.CD.Database.ImportProductDuplicateMatch is Modified

* Modified items
  * Field `Code`
  * Field `ErpKey`
  * Field `Name`
  * Field `NameCode`

#### SuperOffice.CD.Database.InterRestrictionOperator is Modified

* Modified items
  * Field `And`
  * Field `None`
  * Field `Or`

#### SuperOffice.CD.Database.InvitationStatus is Modified

* Modified items
  * Field `Accepted`
  * Field `Cancelled`
  * Field `Declined`
  * Field `Hidden`
  * Field `Invitation`
  * Field `Moved`
  * Field `MovedSeen`
  * Field `None`
  * Field `Seen`
  * Field `Unknown`

#### SuperOffice.CD.Database.LicenseStatus is Modified

* Modified items
  * Field `NewCompanyNameAvailable`
  * Field `NewLicenseAvailable`
  * Field `NewSerialAvailable`
  * Field `Ok`
  * Field `ProblemWithLicense`
  * Field `UnknownError`
  * Field `UseCustomMessage`
  * Field `UseCustomMessageAndUrl`

#### SuperOffice.CD.Database.LicenseType is Modified

* Modified items
  * Field `SatelliteLicense`
  * Field `SiteLicense`
  * Field `Unknown`
  * Field `UserLicense`

#### SuperOffice.CD.Database.LocalizedTextType is Modified

* Modified items
  * Field `Column`
  * Field `FunctionRightDesc`
  * Field `FunctionRightLabel`
  * Field `ImportField`
  * Field `ImportGUICategory`
  * Field `ImportObject`
  * Field `Label`
  * Field `PushNotificationText`
  * Field `StartupHints`
  * Field `StatusMonitorName`
  * Field `Table`
  * Field `UdefAppointmentLabel`
  * Field `UdefContactLabel`
  * Field `UdefDocumentLabel`
  * Field `UdefPersonLabel`
  * Field `UdefProjectLabel`
  * Field `UdefSaleLabel`
  * Field `Unknown`

#### SuperOffice.CD.Database.LogEvent is Modified

* Modified items
  * Field `Create`
  * Field `Delete`
  * Field `Edit`
  * Field `Lock`
  * Field `None`
  * Field `Unlock`

#### SuperOffice.CD.Database.MailboxType is Modified

* Modified items
  * Field `Facebook`
  * Field `Imap`
  * Field `ImapOAuth`
  * Field `Imaps`
  * Field `Mailgun`
  * Field `Mapi`
  * Field `Pop`
  * Field `Pops`
  * Field `SmsPlugin`
  * Field `Unknown`

#### SuperOffice.CD.Database.MailClient is Modified

* Modified items
  * Field `ClientDefault`
  * Field `LotusNotes`
  * Field `Outlook`
  * Field `SuperOffice`

#### SuperOffice.CD.Database.MessageActionType is Modified

* Modified items
  * Field `Forward`
  * Field `InternalComment`
  * Field `None`
  * Field `Reply`
  * Field `ReplyAll`

#### SuperOffice.CD.Database.MessageHeaderStdItem is Modified

* Modified items
  * Field `CustomerReadFAQ`
  * Field `Forward`
  * Field `NoAutoReply`
  * Field `None`
  * Field `ReplyTemplate`
  * Field `SentAutoReplyToCustomersA`
  * Field `SentAutoReplyToCustomersB`
  * Field `UnnamedAttachmentBlocked`

#### SuperOffice.CD.Database.MessageHeaderStdItemCol is Modified

* Modified items
  * Field `Name`
  * Field `None`
  * Field `Value`

#### SuperOffice.CD.Database.Navigation is Modified

* Modified items
  * Field `ActivityDialog`
  * Field `AppntSelectionCustomTask`
  * Field `AppntSelectionShadowTask`
  * Field `AppntSelectionTask`
  * Field `AppointmentDialogTask`
  * Field `AppointmentSelectionMailingsTask`
  * Field `BrowserPanel`
  * Field `ButtonPanelTask`
  * Field `CompanyCardTask`
  * Field `CompanyMinicard`
  * Field `ContactArchive`
  * Field `ContactCard`
  * Field `ContactSelectionMailingsTask`
  * Field `ContSelectionCustomTask`
  * Field `ContSelectionTask`
  * Field `CustomArchiveMiniCard`
  * Field `Dashboard`
  * Field `DiaryArchive`
  * Field `DiaryMinicard`
  * Field `DocSelectionCustomTask`
  * Field `DocSelectionShadowTask`
  * Field `DocSelectionTask`
  * Field `DocumentDialog`
  * Field `DocumentDialogTask`
  * Field `DocumentSelectionMailingsTask`
  * Field `FindSystem`
  * Field `Invisible`
  * Field `MailingSelectionTask`
  * Field `NavigatorButton`
  * Field `PersonArchive`
  * Field `PersonCard`
  * Field `PersonDialogTask`
  * Field `PersonMinicard`
  * Field `ProjectArchive`
  * Field `ProjectCard`
  * Field `ProjectCardTask`
  * Field `ProjectMinicard`
  * Field `ProjectSelectionMailingsTask`
  * Field `ProjSelectionCustomTask`
  * Field `ProjSelectionShadowTask`
  * Field `ProjSelectionTask`
  * Field `QuoteDialog`
  * Field `QuoteDialogArchive`
  * Field `QuoteDialogTask`
  * Field `QuoteLineDialog`
  * Field `QuoteLineDialogTask`
  * Field `QuoteLineSelectionCustomTask`
  * Field `QuoteLineSelectionMailingsTask`
  * Field `QuoteLineSelectionMainTask`
  * Field `QuoteLineSelectionShadowTask`
  * Field `ReportMinicard`
  * Field `SaleArchive`
  * Field `SaleCard`
  * Field `SaleDialogTask`
  * Field `SaleMinicard`
  * Field `SaleSelectionCustomTask`
  * Field `SaleSelectionMailingsTask`
  * Field `SaleSelectionShadowTask`
  * Field `SaleSelectionTask`
  * Field `SelectionAppointmentArchive`
  * Field `SelectionCard`
  * Field `SelectionContactArchive`
  * Field `SelectionDocumentArchive`
  * Field `SelectionMinicard`
  * Field `SelectionProjectArchive`
  * Field `SelectionQuoteLineArchive`
  * Field `SelectionSaleArchive`
  * Field `SelectionTaskCard`
  * Field `TicketCard`
  * Field `TicketMinicard`
  * Field `ToolboxMenu`
  * Field `TopPanelNewMenu`
  * Field `ViewMenu`

#### SuperOffice.CD.Database.NetServerBuildType is Modified

* Modified items
  * Field `Alpha`
  * Field `Beta`
  * Field `Feature`
  * Field `Release`
  * Field `ReleaseCandidate`
  * Field `Stable`

#### SuperOffice.CD.Database.NotificationEventType is Modified

* Modified items
  * Field `AppointmentCancelled`
  * Field `AppointmentDeclined`
  * Field `AppointmentInvitation`
  * Field `AppointmentMoved`
  * Field `NewTicket`
  * Field `NewTicketMessage`
  * Field `QuoteApprovalApproved`
  * Field `QuoteApprovalDenied`
  * Field `QuoteApprovalRequest`
  * Field `TicketActivated`
  * Field `TicketEscalated`
  * Field `Unknown`

#### SuperOffice.CD.Database.NotificationMessageType is Modified

* Modified items
  * Field `ImportantMessage`
  * Field `Message`
  * Field `RemoteAction`
  * Field `ShowWebPage`
  * Field `YesNoQuestion`

#### SuperOffice.CD.Database.NotificationPlatform is Modified

* Modified items
  * Field `Apple`
  * Field `AppleAdHoc`
  * Field `AppleDeveloper`
  * Field `Google`
  * Field `GoogleDeveloper`
  * Field `Microsoft`

#### SuperOffice.CD.Database.OrderBySortType is Modified

* Modified items
  * Field `ASC`
  * Field `DESC`

#### SuperOffice.CD.Database.PhoneType is Modified

* Modified items
  * Field `ContactFax`
  * Field `ContactPhone`
  * Field `PersonDirectFax`
  * Field `PersonDirectPhone`
  * Field `PersonMobile`
  * Field `PersonPager`
  * Field `PersonPrivate`
  * Field `Unknown`

#### SuperOffice.CD.Database.PrefDescAccessFlags is Modified

* Modified items
  * Field `adminGUI`
  * Field `CRMGUI`
  * Field `Level0`
  * Field `Unknown`
  * Field `WizardMode`

#### SuperOffice.CD.Database.PrefDescValueType is Modified

* Modified items
  * Field `Bool`
  * Field `ContactID`
  * Field `ListOfValues`
  * Field `ListTableRef`
  * Field `MultiLineText`
  * Field `Number`
  * Field `Password`
  * Field `PersonID`
  * Field `PosSize`
  * Field `ProjectID`
  * Field `SelectionID`
  * Field `Text`
  * Field `Time`
  * Field `TimeList`
  * Field `TimeZone`
  * Field `Unknown`

#### SuperOffice.CD.Database.PreferenceLevel is Modified

* Modified items
  * Field `Database`
  * Field `Group`
  * Field `HardDefault`
  * Field `Individual`
  * Field `PC`
  * Field `SystemWide`
  * Field `Undefined`

#### SuperOffice.CD.Database.PublishType is Modified

* Modified items
  * Field `External`
  * Field `Undefined`

#### SuperOffice.CD.Database.QuoteStatus is Modified

* Modified items
  * Field `Error`
  * Field `Ok`
  * Field `OkWithInfo`
  * Field `Warning`

#### SuperOffice.CD.Database.QuoteVersionButtonAction is Modified

* Modified items
  * Field `Approve`
  * Field `CloneVersion`
  * Field `Edit`
  * Field `GetOrderState`
  * Field `None`
  * Field `Reject`
  * Field `Send`
  * Field `SendConfirmation`
  * Field `UpdatePrices`
  * Field `ValidateVersion`
  * Field `ValidateVersionAndPlaceOrderIfPossible`
  * Field `ValidateVersionAndSendIfPossible`

#### SuperOffice.CD.Database.QuoteVersionState is Modified

* Modified items
  * Field `Archived`
  * Field `Draft`
  * Field `DraftApproved`
  * Field `DraftNeedsApproval`
  * Field `DraftNotApproved`
  * Field `DraftNotCalculated`
  * Field `Lost`
  * Field `Sent`
  * Field `Sold`
  * Field `Unknown`

#### SuperOffice.CD.Database.RecipientType is Modified

* Modified items
  * Field `BCC`
  * Field `CC`
  * Field `Sms`
  * Field `To`

#### SuperOffice.CD.Database.RecurrenceDailyPattern is Modified

* Modified items
  * Field `EveryCyclicDay`
  * Field `EveryWeekday`
  * Field `EveryWorkday`
  * Field `Unknown`

#### SuperOffice.CD.Database.RecurrenceEndType is Modified

* Modified items
  * Field `Counter`
  * Field `EndDate`
  * Field `Unknown`

#### SuperOffice.CD.Database.RecurrenceMonthlyPattern is Modified

* Modified items
  * Field `DayOfMonth`
  * Field `Unknown`
  * Field `WeekdayOfMonth`

#### SuperOffice.CD.Database.RecurrencePattern is Modified

* Modified items
  * Field `Custom`
  * Field `Daily`
  * Field `Monthly`
  * Field `Unknown`
  * Field `Weekly`
  * Field `Yearly`

#### SuperOffice.CD.Database.RecurrenceUpdateMode is Modified

* Modified items
  * Field `OnlyThis`
  * Field `StopRecurrence`
  * Field `ThisAndForward`
  * Field `Unknown`

#### SuperOffice.CD.Database.RecurrenceYearlyPattern is Modified

* Modified items
  * Field `DayOfMonth`
  * Field `Unknown`
  * Field `WeekdayOfMonth`

#### SuperOffice.CD.Database.RefcountFlags is Modified

* Modified items
  * Field `Allocate`
  * Field `AllowBlank`
  * Field `ReadOnly`
  * Field `Unique`
  * Field `Unknown`

#### SuperOffice.CD.Database.Registry is Modified

* Modified items
  * Field `AccessLicensePageWithoutLogin`
  * Field `ActiveLinksInMessages`
  * Field `AddedLegalHtmlCodeInUpgrade`
  * Field `AddedOptionsFcgi`
  * Field `AlertChatMessages`
  * Field `AllowedMailingLinksDomains`
  * Field `AllowSentryBypass`
  * Field `AllwaysSendMailToNewCustomers`
  * Field `AnonNSKey`
  * Field `ArriveNewTicket`
  * Field `AutoStartTimer`
  * Field `BaseURLForFAQCategory`
  * Field `BaseURLForFAQEntry`
  * Field `BlockCustomerFAQParsing`
  * Field `BlockLoginAttempts`
  * Field `BlockPanesRenderMode`
  * Field `CarrotPassword`
  * Field `CarrotUsername`
  * Field `CCTAddMessage`
  * Field `CCTCanceled`
  * Field `CCTChangeCust`
  * Field `CCTConfirmCustomer`
  * Field `CCTDoneConfirmCustomer`
  * Field `CCTDoneRegister`
  * Field `CCTEMarketeerSimpleMessage`
  * Field `CCTFramework`
  * Field `CCTListTicket`
  * Field `CCTListTickets`
  * Field `CCTLoggedIn`
  * Field `CCTLoggedOut`
  * Field `CCTLogin`
  * Field `CCTNewTicket`
  * Field `CCTNoAccess`
  * Field `CCTPasswordSent`
  * Field `CCTRegisterCust`
  * Field `CCTSendPassword`
  * Field `CCTSubscription`
  * Field `CCTTicketPosted`
  * Field `CCTUpdateConsent`
  * Field `CCTUpdateSubscriptions`
  * Field `CCTViewKBCategory`
  * Field `CCTViewKBEntry`
  * Field `CCTViewKBSearch`
  * Field `CCTWelcome`
  * Field `CellphoneAndPhoneUpdateDone`
  * Field `CellphoneUpdateDone`
  * Field `ChatAvailableImage`
  * Field `ChatCheckForIdleSessions`
  * Field `ChatUnavailableImage`
  * Field `ChatUserIdleTime`
  * Field `ChatWhoisString`
  * Field `CheckHtmlValidityInSOEditor`
  * Field `CleanerImportOnOff`
  * Field `CleanerOnOff`
  * Field `CleanerThreshold`
  * Field `CleanerTolerance`
  * Field `CleanupLinefeedInNSMail`
  * Field `ClipMessagesLength`
  * Field `CollapsableMessageStrings`
  * Field `ComponentMaxWidth`
  * Field `ConverterDone`
  * Field `ConvertProfilesToClob`
  * Field `ConvertRegScreenChoosersToTable`
  * Field `CopyLDAPSearchBase`
  * Field `CreateExtraTableDbiFields`
  * Field `CrmGroup`
  * Field `CrmRoleAdmin`
  * Field `CrmRoleCustomer`
  * Field `CrmRoleStandard`
  * Field `CrossPostMergeTimeWindow`
  * Field `CrystalReportsSoapEndpoint`
  * Field `CSPHeader`
  * Field `CurlDisableStartTls`
  * Field `CurlMailTransferTimeout`
  * Field `CustomCacheBustingParameter`
  * Field `CustomerCenterTemplatesMovedToDB`
  * Field `CustomerEnableFAQAjax`
  * Field `CustomerEncryptionMethod`
  * Field `CustomNotifyEnabled`
  * Field `DBIBetaRelease`
  * Field `DBIExecutable`
  * Field `DbIntegratorEnableStreaming`
  * Field `DBSchemaDirty`
  * Field `DecodingMailSorter`
  * Field `DefaultBlogicScreensOnEditTicket`
  * Field `DefaultEditorBodyFont`
  * Field `DefaultEditorContent`
  * Field `DefaultNoCustomerOnForwarding`
  * Field `DefaultSmsCountry`
  * Field `DefaultStatusWhenTakingOwnership`
  * Field `DefaultTicketStatusClosed`
  * Field `DefaultTicketStatusConnected`
  * Field `DefaultTicketStatusDeleted`
  * Field `DefaultTicketStatusInactive`
  * Field `DefaultTicketStatusOpen`
  * Field `DefaultTimeToReplyOnNewTicket`
  * Field `DefaultTrackAllLinks`
  * Field `DelayMailboxImport`
  * Field `DelegateAlgorithm`
  * Field `DeleteInboxDays`
  * Field `DirtyTicketSaveEvent`
  * Field `DisableExternalSpmUpdate`
  * Field `DisableHtmlFiltering`
  * Field `DisableImportMailInlineSupport`
  * Field `DisableUnauthenticatedCreationInCustomerCentre`
  * Field `DisplayDataSources`
  * Field `DoNotAllowMultipleLogins`
  * Field `DoNotChangeSMRoles`
  * Field `DoNotKickLoginSessions`
  * Field `DoNotSearchBodyForTag`
  * Field `DoNotTestSmtp`
  * Field `DoNotUseCompanyCountry`
  * Field `EjournalCronLast`
  * Field `EjournalCronNow`
  * Field `EjournalOutbox`
  * Field `EjournalOutboxDelay`
  * Field `EjournalOutboxDeleteSentMailAfter`
  * Field `EjournalSender`
  * Field `EjSenderVersion`
  * Field `EmailImplementation`
  * Field `EmailSendingRetryLimit`
  * Field `EmarketeerNewLinkGraceDate`
  * Field `eMarketingEditorInNewWindow`
  * Field `EnableBackdoor`
  * Field `EnableEditMessage`
  * Field `EnableEjStat`
  * Field `EnableNewGui`
  * Field `EnableNewImportMail`
  * Field `EnableSpellCheck27`
  * Field `ExampleBounceFilterAdded`
  * Field `ExpiredWorkflowName`
  * Field `ExternalCustomerAuthEnabled`
  * Field `ExternalCustomerAuthURL`
  * Field `FacebookCallbackKey`
  * Field `FaqAddCommentsAccess`
  * Field `FaqReadCommentsAccess`
  * Field `FaqSuggestions`
  * Field `FaqTitleWeight`
  * Field `FastPersonRecipientSearch`
  * Field `FixCreationScripts`
  * Field `ForceHTTPS`
  * Field `ForceIEEdgeMode`
  * Field `ForceImmediateFileLogging`
  * Field `HideContactPersonPassword`
  * Field `HideExportButton`
  * Field `HideIntegratedEjSpmBlock`
  * Field `HideUserStatistics`
  * Field `IdleLimitCustomerSeconds`
  * Field `IdleLimitCustomerSecondsWeb`
  * Field `IgnoreReturnPath`
  * Field `ImageResizerExecutable`
  * Field `ImportMail3ExpireTime`
  * Field `ImportMail3ExpireTimeAnalyze`
  * Field `ImportmailCheckInvalidUTF8`
  * Field `ImportMailCreateUnknownPersons`
  * Field `ImportMailProcPri`
  * Field `ImportMailTimeout`
  * Field `ImportMessageAsAttachment`
  * Field `IncomingSmsBox`
  * Field `InlineImagesDefault`
  * Field `InternalMessageWhenNotCustomer`
  * Field `InvoiceEntrySumAdded`
  * Field `InvoiceUpdateDone`
  * Field `KeepDbLog`
  * Field `KeepExistingCustomerCenterTemplatesOnDisk`
  * Field `KeepFormKeys`
  * Field `KeepWarningLog`
  * Field `LastCleanedExpiredNotify`
  * Field `LastDiskSpaceWarningAttachments`
  * Field `LastDiskSpaceWarningBase`
  * Field `LastDiskSpaceWarningText`
  * Field `LastLicenseExpirationCheck`
  * Field `LastLicenseInfo`
  * Field `LastnameFirst`
  * Field `LastRequestDaysLimit`
  * Field `LastRequestTicketLimit`
  * Field `LimitSearchExtraTableResult`
  * Field `LogChannels`
  * Field `LogoutUrl`
  * Field `LogPath`
  * Field `MailFilterMinFaqValue`
  * Field `MailgunIncludeOutOfOffice`
  * Field `MailgunRewriteSenderHeader`
  * Field `MailingsUseEnvelopeFrom`
  * Field `MapiServerAppendString`
  * Field `MaxGridRows`
  * Field `MaximumCountRecipients`
  * Field `MaximumSmsMessagesPerDay`
  * Field `MaximumSmsMessagesPerRecipient`
  * Field `MaxLoginAttempts`
  * Field `MaxRowsForCharts`
  * Field `MinimumDiskSpace`
  * Field `MovedSystemScriptsToScreenChooser`
  * Field `NetServerKeepAlive`
  * Field `NetServerSmsProvider`
  * Field `NewInvoiceEntryFormat`
  * Field `NoEjOutbox`
  * Field `NotificationExpire`
  * Field `NotifyActiveTickets`
  * Field `NotifyActiveTicketsDays`
  * Field `NotifyFramePidGain`
  * Field `NotifyFramePidParamsDeprecated`
  * Field `NotifyFrameServerLoad`
  * Field `NotifyTimeOfDayForReport`
  * Field `NSConvertedProfiles`
  * Field `NSGetKeyPath`
  * Field `NsPluginConfig`
  * Field `NsPluginSender`
  * Field `NumOfListedLinks`
  * Field `OldMessageBeforeSignature`
  * Field `OptimizedCustomerCenterListTickets`
  * Field `OracleIndexesUpdated`
  * Field `OutmailWrapColumn`
  * Field `ParseCustomerFields`
  * Field `PasteFaq`
  * Field `PhoneUpdateDone`
  * Field `ProfilesConverted`
  * Field `PsWinComPassword`
  * Field `PsWinComSender`
  * Field `PsWinComUsername`
  * Field `PublishedWorkflowName`
  * Field `QueueTicketStatuses`
  * Field `QuickReplyMode`
  * Field `RecipientControlAdvancedSearch`
  * Field `RefreshNotifyFrameDeprecated`
  * Field `RegisterCustomerConfirmEmail`
  * Field `RegistryEntry_End`
  * Field `ReplacedLangFrWithSe`
  * Field `ReplyTemplateCustomerChatLog`
  * Field `ReplyTemplateCustomerConfirmEmail`
  * Field `ReplyTemplateCustomerCustomerReply`
  * Field `ReplyTemplateCustomerNewCustomer`
  * Field `ReplyTemplateCustomerPassword`
  * Field `ReplyTemplateHotlistNewMessage`
  * Field `ReplyTemplateHotlistTicketActivated`
  * Field `ReplyTemplateHotlistTicketAlarm`
  * Field `ReplyTemplateHotlistTicketTakenOver`
  * Field `ReplyTemplateLicenseExpirationWarning`
  * Field `ReplyTemplateNewLink`
  * Field `ReplyTemplatePrintTicket`
  * Field `ReplyTemplatePublishKbAnswer`
  * Field `ReplyTemplatePublishKbQuestion`
  * Field `ReplyTemplateUserActiveTickets`
  * Field `ReplyTemplateUserNewMessage`
  * Field `ReplyTemplateUserNewTicket`
  * Field `ReplyTemplateUserTicketActivated`
  * Field `ReplyTemplateUserTicketAlarm`
  * Field `ReplyTemplateUserTicketTakenOver`
  * Field `ReplyTemplateWeekStat`
  * Field `ReplyToAllOnlyLatestExternalMessage`
  * Field `ReplyToPrimaryEmail`
  * Field `ReportStartRootFolder`
  * Field `SandboxTicketMessages`
  * Field `SanitizeMailingsHtml`
  * Field `ScreenChooserAddMessage`
  * Field `ScreenChooserCategories`
  * Field `ScreenChooserEditTicket`
  * Field `ScreenChooserHelpPage`
  * Field `ScreenChooserInvoiceStat`
  * Field `ScreenChooserKnowledgeEditKbEntry`
  * Field `ScreenChooserKnowledgeListFolders`
  * Field `ScreenChooserKnowledgeViewKbEntry`
  * Field `ScreenChooserListTicketMessages`
  * Field `ScreenChooserListTicketTop`
  * Field `ScreenChooserNewTicket`
  * Field `ScreenChooserPriorities`
  * Field `ScreenChooserTicketMainMenu`
  * Field `ScreenChooserUsers`
  * Field `ScreenChooserViewCompany`
  * Field `ScreenChooserViewCustomer`
  * Field `SearchEngineCallback`
  * Field `SearchEngineFilters`
  * Field `SearchSubjectBeforeMsgId`
  * Field `SearchToSelections`
  * Field `SecurityModelEnabled`
  * Field `SelectCompanyColumns`
  * Field `SelectCustomerColumns`
  * Field `SelectTicketColumns`
  * Field `SentimentCalculationTimeframe`
  * Field `SetupCompanyAddress`
  * Field `SetupCompanyName`
  * Field `SetupFCGI`
  * Field `ShowAutoRepliesToCustomers`
  * Field `ShowAvatarsInCustomerCentre`
  * Field `ShowBlogicMenu`
  * Field `ShowOldReportsMenu`
  * Field `ShowReplyTemplatesToCustomers`
  * Field `ShowSubmitSpinner`
  * Field `ShowTotalInvoiceUnits`
  * Field `SLinkCleanUpDone`
  * Field `SmsChannel`
  * Field `SmsProvider`
  * Field `SmsSender`
  * Field `SmsServiceEndpoint`
  * Field `SmsServiceId`
  * Field `SMTPIgnoreLeadingDotEscaping`
  * Field `SmtpTimeout`
  * Field `SoapSystemUserPassword`
  * Field `SoapUseExtension`
  * Field `SpmConcurrentSMTPThreads`
  * Field `SpmDefaultFrom`
  * Field `SpmDefaultMailingRate`
  * Field `SpmHideNewMessageOption`
  * Field `SpmImgDBCopied`
  * Field `SpmMsgTicketParserUpdateDone`
  * Field `SpmOnlyPrimaryOnTicketSelection`
  * Field `SpmSMTPServer`
  * Field `SpmSMTPServerPort`
  * Field `SpmTimeToRestartSenders`
  * Field `SpmUseDeliveryReport`
  * Field `SpmUseHtmlEditor`
  * Field `StrictGDRPMode`
  * Field `StripNewLineInParser`
  * Field `SuperOfficeIntegrationPassword`
  * Field `SystemNSKey`
  * Field `SystemTimeMode`
  * Field `SystemTimeModeInstalled`
  * Field `Tele2Endpoint`
  * Field `Tele2SmsPassword`
  * Field `Tele2SmsUsername`
  * Field `TemporaryKeyHardDeleteDelay`
  * Field `TemporaryKeyTTL`
  * Field `ThumbnailsIsDefaultMode`
  * Field `TicketLogSystem`
  * Field `TimeKeyTTL`
  * Field `TimeZoneForNetServer`
  * Field `UnicodeConvertedTemplateFolder`
  * Field `UnpublishedWorkflowName`
  * Field `UpdateCustomerEmails`
  * Field `UpdatedActivateField`
  * Field `UpdateFaqAccessToWorkflowDone`
  * Field `UpdateTicketCustomersDone`
  * Field `UpdateUserDateFormatsDone`
  * Field `UpgradeCSParserConverted`
  * Field `UpgradeCustomerPasswordStatus`
  * Field `UpgradeNotPresentComment`
  * Field `UpgradeRolesConverted`
  * Field `UpgradeScreenDefinitionsToScripts`
  * Field `UpgradeTicketStatusName`
  * Field `UsageStatsDataAddNextRun`
  * Field `UsageStatsTableSizeNextRun`
  * Field `UsageStatsWebNextRun`
  * Field `UsageStatsWinNextRun`
  * Field `UseAbsoluteURLsInHTML`
  * Field `UseAttachmentFolders`
  * Field `UseAutoSuppressHeader`
  * Field `UseBrowserSpellCheck`
  * Field `UseCalltoOnPhoneLinks`
  * Field `UseCookieInCustomerCenter`
  * Field `UseEjParserForTemplates`
  * Field `UseExtension`
  * Field `UseFCGIImpersonation`
  * Field `UseFullText`
  * Field `UseHtmlRedirect`
  * Field `UseLegacyHtmlConverter`
  * Field `UseMiddleName`
  * Field `UseNetServerSms`
  * Field `UseOldHtmlSelectTreeLayout`
  * Field `UseOldMailInFilterRegExp`
  * Field `UseOnlyOneCookie`
  * Field `UseParserInDBIntegrator`
  * Field `UserAgentIsMobile`
  * Field `UserAgentIsTablet`
  * Field `UserGroupsConverted`
  * Field `UserOldScreensOnEditTicketDone`
  * Field `UserSignaturesConvertedToHtml`
  * Field `UserSyncResyncNextRun`
  * Field `UseSafeParserFunction`
  * Field `UseSha1OnLinks`
  * Field `UseSmsDeliveryReport`
  * Field `UseWebServiceSms`
  * Field `UseWordByWordKbSearch`
  * Field `ViewCompanyWithPanes`
  * Field `ViewCustomerWithPanes`
  * Field `ViewExtraTableEntryWithPanes`
  * Field `ViewTicketWithPanes`
  * Field `WeekStatRecipient`
  * Field `WwwPath`

#### SuperOffice.CD.Database.RelationTarget is Modified

* Modified items
  * Field `Both`
  * Field `Contact`
  * Field `None`
  * Field `Person`

#### SuperOffice.CD.Database.ReportCategory is Modified

* Modified items
  * Field `All`
  * Field `Appointment`
  * Field `Contact`
  * Field `Diary`
  * Field `Favorites`
  * Field `None`
  * Field `Person`
  * Field `Project`
  * Field `Sale`
  * Field `Selection`

#### SuperOffice.CD.Database.ReportLayout is Modified

* Modified items
  * Field `CalendarMonth`
  * Field `CalendarWeek5`
  * Field `CalendarWeek7`
  * Field `CrossTable`
  * Field `GroupList`
  * Field `Label`
  * Field `List`
  * Field `Text`
  * Field `Unknown`

#### SuperOffice.CD.Database.ReportPaperOrientation is Modified

* Modified items
  * Field `Landscape`
  * Field `None`
  * Field `Portrait`

#### SuperOffice.CD.Database.ReturnType is Modified

* Modified items
  * Field `CustomGui`
  * Field `Message`
  * Field `None`
  * Field `Other`
  * Field `SoProtocol`
  * Field `URL`

#### SuperOffice.CD.Database.RoleRelationToOwner is Modified

* Modified items
  * Field `Anonymous`
  * Field `ExternalUser`
  * Field `MyCompany`
  * Field `MyOwn`
  * Field `OtherAssociates`
  * Field `OtherGroups`
  * Field `PrimaryGroup`
  * Field `SameProject`

#### SuperOffice.CD.Database.RoleType is Modified

* Modified items
  * Field `Anonymous`
  * Field `Employee`
  * Field `ExternalUser`
  * Field `System`

#### SuperOffice.CD.Database.SaleDone is Modified

* Modified items
  * Field `Done`
  * Field `NotDone`
  * Field `Unknown`

#### SuperOffice.CD.Database.SaleStatus is Modified

* Modified items
  * Field `Lost`
  * Field `Open`
  * Field `SaintAll`
  * Field `Sold`
  * Field `Stalled`
  * Field `Unknown`

#### SuperOffice.CD.Database.ScreenChooserType is Modified

* Modified items
  * Field `CompactModeInjection`
  * Field `DbiTaskFailed`
  * Field `ExtraTableAll`
  * Field `ExtraTableEdit`
  * Field `ExtraTableEntry`
  * Field `NewTicket`
  * Field `NewTicketFromCustomerCenter`
  * Field `NewTicketFromCustomerCenterBeforeSave`
  * Field `NewTicketFromEmail`
  * Field `None`
  * Field `ScheduledTaskFailed`
  * Field `System`
  * Field `TicketActivated`
  * Field `TicketChangedCategory`
  * Field `TicketChangedOwnedBy`
  * Field `TicketChangedPrimaryCustomer`
  * Field `TicketChangedPriority`
  * Field `TicketChangedSlevel`
  * Field `TicketChangedTicketStatus`
  * Field `TicketClosed`
  * Field `TicketDeleted`
  * Field `TicketExternalMessageAdded`
  * Field `TicketInternalMessageAdded`
  * Field `TicketMessageAdded`
  * Field `TicketPostponed`
  * Field `TicketReopened`
  * Field `TicketReopenedFromCustomerCenter`
  * Field `TicketReopenedFromEmail`

#### SuperOffice.CD.Database.SelectionSystemType is Modified

* Modified items
  * Field `DashboardTileSelection`
  * Field `PersonalForDashboard`
  * Field `PersonalForDashboardSecondary`
  * Field `PersonalForFind`
  * Field `TemporaryShortTermStatic`
  * Field `User`

#### SuperOffice.CD.Database.SelectionType is Modified

* Modified items
  * Field `Combined`
  * Field `Dynamic`
  * Field `Static`

#### SuperOffice.CD.Database.SelectionUnionType is Modified

* Modified items
  * Field `Intersect`
  * Field `SubtractLeftFromRight`
  * Field `SubtractRightFromLeft`
  * Field `Union`
  * Field `Unknown`
  * Field `XOR`

#### SuperOffice.CD.Database.SenderMailMode is Modified

* Modified items
  * Field `UseDefaultSender`
  * Field `UseLoggedInUser`
  * Field `UseOurContact`
  * Field `UseSupportContact`

#### SuperOffice.CD.Database.ShipmentAddrStatus is Modified

* Modified items
  * Field `Blocked`
  * Field `Bounced`
  * Field `Clicked`
  * Field `Complained`
  * Field `Duplicate`
  * Field `NoSubscription`
  * Field `Opened`
  * Field `Ready`
  * Field `Sent`
  * Field `SoftBounced`
  * Field `TooManyBounces`
  * Field `Unknown`

#### SuperOffice.CD.Database.ShipmentFlags is Modified

* Modified items
  * Field `FromAlwaysForward`
  * Field `FromOurContact`
  * Field `FromSalesContact`
  * Field `IncludeCompanies`
  * Field `IncludeNoMailings`
  * Field `Linkify`
  * Field `log`
  * Field `NoStaticListLookup`
  * Field `PopulateOnlyNow`
  * Field `PreferCompany`
  * Field `RecalculateRecipients`
  * Field `RecalculateRecipientsOnce`
  * Field `RemoveDuplicates`
  * Field `ReplyToAlwaysForward`
  * Field `ReplyToEmpty`
  * Field `ReplyToOurContact`
  * Field `ReplyToSalesContact`
  * Field `TrackRecipients`

#### SuperOffice.CD.Database.ShipmentLinkAction is Modified

* Modified items
  * Field `AddRequest`
  * Field `AddTask`
  * Field `AddToCsSelection`
  * Field `AddToSmProject`
  * Field `AddToSmSelection`
  * Field `ExecuteScript`
  * Field `None`
  * Field `RemoveContactInterest`
  * Field `RemoveFromCsSelection`
  * Field `RemoveFromSmProject`
  * Field `RemoveFromSmSelection`
  * Field `RemovePersonInterest`
  * Field `SetContactInterest`
  * Field `SetPersonInterest`

#### SuperOffice.CD.Database.ShipmentLinkRedirectKind is Modified

* Modified items
  * Field `RedirectToURL`
  * Field `ShowForm`
  * Field `ShowText`

#### SuperOffice.CD.Database.ShipmentLinkTaskFlags is Modified

* Modified items
  * Field `AssignToOurContact`
  * Field `IsAssignment`
  * Field `None`
  * Field `UseNextAvailableTime`

#### SuperOffice.CD.Database.ShipmentLinkType is Modified

* Modified items
  * Field `Consent`
  * Field `Image`
  * Field `Link`
  * Field `Unknown`
  * Field `Unsubscribe`

#### SuperOffice.CD.Database.ShipmentListStatus is Modified

* Modified items
  * Field `NotSent`
  * Field `Sent`

#### SuperOffice.CD.Database.ShipmentStatus is Modified

* Modified items
  * Field `AwaitPopulate`
  * Field `Canceled`
  * Field `Deleted`
  * Field `None`
  * Field `Ok`
  * Field `PopulateAborted`
  * Field `PopulateError`
  * Field `Populating`
  * Field `PopulatingOnly`
  * Field `Retry`
  * Field `Started`
  * Field `StatusFailed`
  * Field `TooManyRecipients`
  * Field `Waiting`

#### SuperOffice.CD.Database.ShowState is Modified

* Modified items
  * Field `AddressBar`
  * Field `Default`
  * Field `Maximized`
  * Field `MenuBar`
  * Field `Minimized`
  * Field `StatusBar`
  * Field `ToolBar`

#### SuperOffice.CD.Database.ShowTaskItemInClient is Modified

* Modified items
  * Field `Mobile`
  * Field `None`
  * Field `Web`

#### SuperOffice.CD.Database.ShowWindowState is Modified

* Modified items
  * Field `Maximized`
  * Field `Minimized`
  * Field `Normal`

#### SuperOffice.CD.Database.StatusScreenPanelType is Modified

* Modified items
  * Field `Hotlist`
  * Field `None`
  * Field `NumberOfCreatedRequestsPerDay`
  * Field `NumberOfCreatedRequestsPerMonth`
  * Field `NumberOfCreatedRequestsPerWeek`
  * Field `OpenRequestsPerCategory`
  * Field `OpenRequestsPerOrigin`
  * Field `OpenRequestsPerPriority`
  * Field `OpenRequestsPerStatus`
  * Field `OpenRequestsPerTopCategory`
  * Field `OpenRequestsPerUser`
  * Field `OpenRequestsPerUserGroup`
  * Field `OwnOpenRequests`
  * Field `StatusScreen`
  * Field `UnassignedRequests`
  * Field `UserReponseTimePerWeek`
  * Field `UserResponseTimePerDay`
  * Field `UserResponseTimePerMonth`

#### SuperOffice.CD.Database.StringSearchType is Modified

* Modified items
  * Field `BeginsWith`
  * Field `Contains`
  * Field `EndsWith`
  * Field `Exact`

#### SuperOffice.CD.Database.SystemEventScope is Modified

* Modified items
  * Field `Database`
  * Field `Group`
  * Field `SystemWide`
  * Field `Undefined`
  * Field `User`

#### SuperOffice.CD.Database.SystemMessageType is Modified

* Modified items
  * Field `Error`
  * Field `Info`
  * Field `Unspecified`
  * Field `Warning`

#### SuperOffice.CD.Database.TargetAssignementLevel is Modified

* Modified items
  * Field `Associate`
  * Field `Company`
  * Field `Group`
  * Field `None`

#### SuperOffice.CD.Database.TargetEntityType is Modified

* Modified items
  * Field `None`
  * Field `Sale`

#### SuperOffice.CD.Database.TargetLevel is Modified

* Modified items
  * Field `Associate`
  * Field `Company`
  * Field `Global`
  * Field `None`
  * Field `UserGroup`

#### SuperOffice.CD.Database.TargetMeasurementUnit is Modified

* Modified items
  * Field `Amount`
  * Field `Count`
  * Field `None`
  * Field `Profit`

#### SuperOffice.CD.Database.TargetPeriodType is Modified

* Modified items
  * Field `HalfYear`
  * Field `Month`
  * Field `None`
  * Field `Quarter`
  * Field `Year`

#### SuperOffice.CD.Database.TaskDirection is Modified

* Modified items
  * Field `Incoming`
  * Field `Outgoing`
  * Field `SaintAll`
  * Field `Unknown`

#### SuperOffice.CD.Database.TaskListItemType is Modified

* Modified items
  * Field `CrmScript`
  * Field `None`
  * Field `SoProtocol`
  * Field `Url`

#### SuperOffice.CD.Database.TaskType is Modified

* Modified items
  * Field `Appointment`
  * Field `Document`
  * Field `Email`
  * Field `Fax`
  * Field `MailMergeDraft`
  * Field `MailMergeFinal`
  * Field `Phone`
  * Field `Report`
  * Field `SaintAll`
  * Field `ToDo`
  * Field `Unknown`

#### SuperOffice.CD.Database.TemporaryKeyDomain is Modified

* Modified items
  * Field `ChangePasswordCustomerCenter`
  * Field `FormSubmitterRecipient`
  * Field `LoginCustomerCenter`
  * Field `MailingRecipient`
  * Field `PublicFaq`
  * Field `RegisterCustomerCenterEmailVerification`
  * Field `Unknown`
  * Field `ViewTicketInCustomerCenter`

#### SuperOffice.CD.Database.TextType is Modified

* Modified items
  * Field `AppointmentText`
  * Field `AudienceSignOffConfirmation`
  * Field `AudienceSignOnConfirmation`
  * Field `ContactInfo`
  * Field `DayInfo`
  * Field `DocumentText`
  * Field `LongPreference`
  * Field `NameExtension`
  * Field `Notepad`
  * Field `PersonInfo`
  * Field `ProjectInfo`
  * Field `ProjectMemberText`
  * Field `ProjectText`
  * Field `Reserved1`
  * Field `Reserved2`
  * Field `Reserved3`
  * Field `RoleInfo`
  * Field `SaleInfo`
  * Field `SaleText`
  * Field `SearchCriteriaGroupInfo`
  * Field `SearchCriteriaInfo`
  * Field `SelectionInfo`
  * Field `SelectionText`
  * Field `StatusMonitorDefaultTaskText`
  * Field `StatusMonitorInfo`
  * Field `TooltipExtension`
  * Field `UdefListSQL`
  * Field `Unknown`

#### SuperOffice.CD.Database.TicketBaseStatus is Modified

* Modified items
  * Field `Active`
  * Field `Closed`
  * Field `Deleted`
  * Field `Merged`
  * Field `Postponed`
  * Field `Postponed1Hour`
  * Field `Postponed2Hours`
  * Field `Postponed3Hours`
  * Field `Postponed4Hours`
  * Field `PostponedDay`
  * Field `PostponedMonth`
  * Field `PostponedSpecific`
  * Field `PostponedWeek`
  * Field `Unknown`

#### SuperOffice.CD.Database.TicketLogAction is Modified

* Modified items
  * Field `Message_AddedDebugInfo`
  * Field `Message_AddMassMessage`
  * Field `Message_AddMessage`
  * Field `Message_AddMessageFromCustomer`
  * Field `Message_AddMessageFromSoap`
  * Field `Message_BounceMessage`
  * Field `Message_Continue`
  * Field `Message_CustomDescription`
  * Field `Message_EditMessage`
  * Field `Message_EditMessageFromSoap`
  * Field `Message_EditTicket`
  * Field `Message_ForwardMessage`
  * Field `Message_ImportMailAddMessage`
  * Field `Message_ImportTicketFromEmail`
  * Field `Message_InlineImagesConverted`
  * Field `Message_NewMessageFromSpecialForm`
  * Field `Message_NewTicket`
  * Field `Message_NewTicketFromCustomer`
  * Field `Message_OutboxMessage`
  * Field `Message_SavedFromEjScript`
  * Field `Message_SendingReplyTemplate`
  * Field `Message_SendingSMS`
  * Field `Message_SendingSpmMessage`
  * Field `Message_TicketNotifyFAQ`
  * Field `Message_Unknown`
  * Field `No_Logging`
  * Field `Ticket_AddMessage`
  * Field `Ticket_AddMessageFromCustomer`
  * Field `Ticket_AddMessageFromSoap`
  * Field `Ticket_AttachmentConnectedToTicket`
  * Field `Ticket_AutoCategorized`
  * Field `Ticket_BatchCloseTicket`
  * Field `Ticket_BatchMarkAsRead`
  * Field `Ticket_BatchMarkAsUnread`
  * Field `Ticket_BatchOperation`
  * Field `Ticket_ChangeSecurityStatus`
  * Field `Ticket_ChangeStatus`
  * Field `Ticket_CloseAfterMassMessage`
  * Field `Ticket_CloseTicketAfterForward`
  * Field `Ticket_CloseTicketFromSoap`
  * Field `Ticket_ConnectTwoTickets`
  * Field `Ticket_CustomDescription`
  * Field `Ticket_DeleteTicket`
  * Field `Ticket_EditMessage`
  * Field `Ticket_EditTicket`
  * Field `Ticket_ImportMailExistingTicket`
  * Field `Ticket_ImportMailNewTicket`
  * Field `Ticket_ImportTicketFromEmail`
  * Field `Ticket_JoinTickets`
  * Field `Ticket_MessageAddedToTicket`
  * Field `Ticket_NewTicket`
  * Field `Ticket_NewTicketFromCustomer`
  * Field `Ticket_NewTicketFromSoap`
  * Field `Ticket_NewTicketFromSpecialForm`
  * Field `Ticket_QuickSetExtraDate`
  * Field `Ticket_QuickSetExtraDateTime`
  * Field `Ticket_QuickSetExtraField`
  * Field `Ticket_QuickSetExtraTime`
  * Field `Ticket_ReadByCustomer`
  * Field `Ticket_ReadByUser`
  * Field `Ticket_ReadTicketFromSoap`
  * Field `Ticket_SavedFromEjScript`
  * Field `Ticket_SendingSpmMessage`
  * Field `Ticket_SetRepliedAtByMassMessage`
  * Field `Ticket_SetValuesFromSoap`
  * Field `Ticket_SwapExtraField`
  * Field `Ticket_TicketActivated`
  * Field `Ticket_TicketActivatedByBounce`
  * Field `Ticket_TicketClosedByFAQ`
  * Field `Ticket_TicketEscalated`
  * Field `Ticket_TicketEscalatedFromEjScript`
  * Field `Ticket_Unknown`
  * Field `Ticket_UserDeletedOwneraction`
  * Field `Ticket_UserTakesOwnership`

#### SuperOffice.CD.Database.TicketLogFieldChange is Modified

* Modified items
  * Field `Activate`
  * Field `AgentId`
  * Field `AlertLevel`
  * Field `AlertStop`
  * Field `AlertTimeout`
  * Field `Author`
  * Field `Category`
  * Field `ClosedAt`
  * Field `ConnectId`
  * Field `CreatedAt`
  * Field `CreatedBy`
  * Field `CustId`
  * Field `DbiKey`
  * Field `DbiLastSyncronized`
  * Field `Deadline`
  * Field `DisplayFilter`
  * Field `ExtraField`
  * Field `FilterAddress`
  * Field `FilterId`
  * Field `FirstReadByOwner`
  * Field `FirstReadByUser`
  * Field `HasAttachment`
  * Field `LastChanged`
  * Field `Message_Author`
  * Field `Message_Body`
  * Field `Message_BodyHtml`
  * Field `Message_CreatedAt`
  * Field `Message_CreatedBy`
  * Field `Message_CustomerId`
  * Field `Message_DebugInfo`
  * Field `Message_EmailHeader`
  * Field `Message_ExtraField`
  * Field `Message_MailSorter`
  * Field `Message_MessageCategory`
  * Field `Message_MessageId`
  * Field `Message_SLevel`
  * Field `Message_TicketId`
  * Field `Message_TimeSpent`
  * Field `Message_Type`
  * Field `NumMessages`
  * Field `NumReplies`
  * Field `OwnedBy`
  * Field `Priority`
  * Field `ProjectId`
  * Field `ReadByCustomer`
  * Field `ReadByOwner`
  * Field `ReadStatus`
  * Field `RealTimeSpentExternally`
  * Field `RealTimeSpentInternally`
  * Field `RealTimeSpentQueue`
  * Field `RealTimeToClose`
  * Field `RealTimeToReply`
  * Field `RepliedAt`
  * Field `SaleId`
  * Field `SLevel`
  * Field `Status`
  * Field `Tags`
  * Field `TicketStatus`
  * Field `TicketType`
  * Field `TimeSpentExternally`
  * Field `TimeSpentInternally`
  * Field `TimeSpentQueue`
  * Field `TimeToClose`
  * Field `TimeToReply`
  * Field `Title`

#### SuperOffice.CD.Database.TicketOrigin is Modified

* Modified items
  * Field `AutoGenerated`
  * Field `Chat`
  * Field `CustomerCentre`
  * Field `Email`
  * Field `EMarketing`
  * Field `Facebook`
  * Field `Fax`
  * Field `Form`
  * Field `Internal`
  * Field `Phone`
  * Field `SMS`
  * Field `Twitter`
  * Field `Unknown`

#### SuperOffice.CD.Database.TicketStatusTimeCounter is Modified

* Modified items
  * Field `Externally`
  * Field `Internally`
  * Field `None`
  * Field `Queue`

#### SuperOffice.CD.Database.TravelEncryptionChild is Modified

* Modified items
  * Field `BF128`
  * Field `None`
  * Field `Serial`

#### SuperOffice.CD.Database.TravelEncryptionOwn is Modified

* Modified items
  * Field `BF128`
  * Field `None`
  * Field `Serial`

#### SuperOffice.CD.Database.TrlogTransType is Modified

* Modified items
  * Field `Delete`
  * Field `DeleteAreaUserAssignment`
  * Field `DeleteAreaUserInclusion`
  * Field `Insert`
  * Field `OldUpdateContact`
  * Field `OldUpdateProject`
  * Field `PublishUdef`
  * Field `TruncateTable`
  * Field `Unknown`
  * Field `Update`
  * Field `UpdateContact`
  * Field `UpdateFieldPart1`
  * Field `UpdateFieldPart2`
  * Field `UpdateFieldPart3`
  * Field `UpdateFieldPart4`
  * Field `UpdateFieldPart5`
  * Field `UpdateFieldPart6`
  * Field `UpdateFieldPart7`
  * Field `UpdateFieldPart8`
  * Field `UpdateOwner`
  * Field `UpdateProject`

#### SuperOffice.CD.Database.TtlFlags is Modified

* Modified items
  * Field `Imported`
  * Field `MassOperation`
  * Field `None`

#### SuperOffice.CD.Database.UDefFieldType is Modified

* Modified items
  * Field `Checkbox`
  * Field `Date`
  * Field `Decimal`
  * Field `List`
  * Field `LongText`
  * Field `Number`
  * Field `ShortText`
  * Field `UnlimitedDate`

#### SuperOffice.CD.Database.UdefJustification is Modified

* Modified items
  * Field `Center`
  * Field `Default`
  * Field `Left`
  * Field `Right`

#### SuperOffice.CD.Database.UDefType is Modified

* Modified items
  * Field `Appointment`
  * Field `Contact`
  * Field `Document`
  * Field `Invalid`
  * Field `None`
  * Field `Person`
  * Field `Project`
  * Field `Sale`
  * Field `Temp`

#### SuperOffice.CD.Database.UpsertNomatchAction is Modified

* Modified items
  * Field `DeleteRow`
  * Field `NoChange`
  * Field `ZeroColumns`

#### SuperOffice.CD.Database.UpsertRowActionStatus is Modified

* Modified items
  * Field `ColumnsZeroed`
  * Field `Deleted`
  * Field `Inserted`
  * Field `NoUpdateNeeded`
  * Field `Updated`

#### SuperOffice.CD.Database.UrlEncoding is Modified

* Modified items
  * Field `ANSI`
  * Field `None`
  * Field `Unicode`
  * Field `Unknown`

#### SuperOffice.CD.Database.UserType is Modified

* Modified items
  * Field `AnonymousAssociate`
  * Field `ExternalAssociate`
  * Field `InternalAssociate`
  * Field `ResourceAssociate`
  * Field `SystemAssociate`
  * Field `Unknown`

#### SuperOffice.CD.Database.ValueOverride is Modified

* Modified items
  * Field `DiscountAmount`
  * Field `DiscountPercent`
  * Field `EarningAmount`
  * Field `EarningPercent`
  * Field `None`
  * Field `Total`

#### SuperOffice.CD.Database.VideoMeetingStatus is Modified

* Modified items
  * Field `NoChange`
  * Field `VideoMeetingOff`
  * Field `VideoMeetingOn`

#### SuperOffice.CD.Database.Visibility is Modified

* Modified items
  * Field `All`
  * Field `Associate`
  * Field `Group`

#### SuperOffice.CD.Database.WebhookState is Modified

* Modified items
  * Field `Active`
  * Field `Stopped`
  * Field `TooManyErrors`
  * Field `Unknown`

#### SuperOffice.CD.Database.Weekday is Modified

* Modified items
  * Field `Friday`
  * Field `Monday`
  * Field `Saturday`
  * Field `Sunday`
  * Field `Thursday`
  * Field `Tuesday`
  * Field `Unknown`
  * Field `Wednesday`

#### SuperOffice.CD.Database.WeekOfMonth is Modified

* Modified items
  * Field `First`
  * Field `Fourth`
  * Field `Last`
  * Field `Second`
  * Field `Third`
  * Field `Unknown`

#### SuperOffice.CD.Database.WorkflowActionType is Modified

* Modified items
  * Field `After`
  * Field `Estimated`
  * Field `FirstAvailable`
  * Field `FirstAvailableAfter`
  * Field `None`
  * Field `Today`

#### SuperOffice.CD.Database.WorkflowContentType is Modified

* Modified items
  * Field `Form`
  * Field `Link`
  * Field `Message`
  * Field `None`

#### SuperOffice.CD.Database.WorkflowDefinitionStatus is Modified

* Modified items
  * Field `None`
  * Field `Paused`
  * Field `Running`
  * Field `Stopped`

#### SuperOffice.CD.Database.WorkflowEventType is Modified

* Modified items
  * Field `AddedMessage`
  * Field `AddedToProject`
  * Field `AddedToSelection`
  * Field `CreatedRequest`
  * Field `FormSubmitted`
  * Field `LinkClicked`
  * Field `None`
  * Field `OrderPlaced`
  * Field `PersonCreated`
  * Field `PersonUpdated`
  * Field `Run`
  * Field `SaleCreated`
  * Field `SaleLost`
  * Field `SaleSold`
  * Field `StartedChat`

#### SuperOffice.CD.Database.WorkflowGoalType is Modified

* Modified items
  * Field `AddedToProject`
  * Field `AddedToSelection`
  * Field `AppointmentCreated`
  * Field `FormSubmitted`
  * Field `HadChat`
  * Field `LinkClicked`
  * Field `None`
  * Field `PersonUpdated`
  * Field `RequestCreated`
  * Field `SaleCreatedOnCompany`
  * Field `SaleCreatedOnPerson`

#### SuperOffice.CD.Database.WorkflowInstanceStatus is Modified

* Modified items
  * Field `Active`
  * Field `Cancelled`
  * Field `DropOut`
  * Field `Finished`
  * Field `FinishedWithSuccess`
  * Field `Idle`
  * Field `None`

#### SuperOffice.CD.Database.WorkflowNotifyEmailType is Modified

* Modified items
  * Field `OurContact`
  * Field `OurServiceContact`
  * Field `SpecificEmailAddress`

#### SuperOffice.CD.Database.WorkflowNotifySMSType is Modified

* Modified items
  * Field `OurContact`
  * Field `OurServiceContact`
  * Field `SpecificPhoneNumbers`

#### SuperOffice.CD.Database.WorkflowOwnerType is Modified

* Modified items
  * Field `None`
  * Field `OurContact`
  * Field `OurSupportContact`
  * Field `Specified`

#### SuperOffice.CD.Database.WorkflowSplitOptionType is Modified

* Modified items
  * Field `FormData`
  * Field `FormSubmission`
  * Field `LinkClicked`
  * Field `None`
  * Field `PersonData`
  * Field `ProjectMembership`
  * Field `SelectionMembership`

#### SuperOffice.CD.Database.WorkflowStepType is Modified

* Modified items
  * Field `AddToList`
  * Field `CreateFollowUp`
  * Field `CreateRequest`
  * Field `CreateSale`
  * Field `None`
  * Field `NotifyByEmail`
  * Field `NotifyBySMS`
  * Field `RemoveFromList`
  * Field `RunScript`
  * Field `SendEmail`
  * Field `SendSMS`
  * Field `Split`
  * Field `UpdateParticipant`
  * Field `WaitForAction`
  * Field `WaitForTime`

#### SuperOffice.CD.Database.WorkflowTimeWaitAlgorithm is Modified

* Modified items
  * Field `None`
  * Field `NumIntervals`
  * Field `UntilDateField`
  * Field `UntilSpecified`

#### SuperOffice.CD.Database.WorkflowTimeWaitIntervalType is Modified

* Modified items
  * Field `Days`
  * Field `Hours`
  * Field `Minutes`
  * Field `None`
  * Field `Seconds`
  * Field `Weeks`
  * Field `WorkingDays`

#### SuperOffice.CD.Database.WorkflowTriggerType is Modified

* Modified items
  * Field `AddedMessage`
  * Field `AddedToProject`
  * Field `AddedToSelection`
  * Field `CreatedRequest`
  * Field `FormSubmitted`
  * Field `LinkClicked`
  * Field `None`
  * Field `OrderPlaced`
  * Field `PersonCreated`
  * Field `PersonUpdated`
  * Field `SaleCreated`
  * Field `SaleLost`
  * Field `SaleSold`
  * Field `StartedChat`

#### SuperOffice.CD.Database.WorkflowWaitForActionType is Modified

* Modified items
  * Field `FormSubmitted`
  * Field `LinkClicked`
  * Field `None`

#### SuperOffice.CD.DSL.Database.BadgeType is Modified

* Modified items
  * Field `Comment`
  * Field `Forward`
  * Field `Incoming`
  * Field `Outgoing`
  * Field `Reply`
  * Field `Unknown`

#### SuperOffice.CD.DSL.Database.CcTemplateType is Modified

* Modified items
  * Field `FromDisk`
  * Field `FromReplyTemplate`

#### SuperOffice.CD.DSL.Database.ChatSessionFlags is Modified

* Modified items
  * Field `CustomerIsTyping`
  * Field `UserIsTyping`

#### SuperOffice.CD.DSL.Database.ChatStatus is Modified

* Modified items
  * Field `NotPresent`
  * Field `Present`

#### SuperOffice.CD.DSL.Database.ConfigType is Modified

* Modified items
  * Field `Options`
  * Field `Style`

#### SuperOffice.CD.DSL.Database.DesignType is Modified

* Modified items
  * Field `SOEditor`
  * Field `Unknown`
  * Field `Unlayer`

#### SuperOffice.CD.DSL.Database.Domain is Modified

* Modified items
  * Field `Dashboards`
  * Field `EmailFlows`
  * Field `ExternalDocumentRelatedToSpmMessage`
  * Field `ExternalDocuments`
  * Field `ExtraTables`
  * Field `ScreenDefinitions`
  * Field `Scripts`
  * Field `Selections`
  * Field `Unknown`
  * Field `UserGroups`

#### SuperOffice.CD.DSL.Database.EmailAccountStatus is Modified

* Modified items
  * Field `Deleted`
  * Field `Failed`
  * Field `Failing`
  * Field `Ok`
  * Field `Unknown`

#### SuperOffice.CD.DSL.Database.EventHandlerType is Modified

* Modified items
  * Field `ChatAfterSaveNewMessage`
  * Field `ChatBeforeSaveNewMessage`
  * Field `ChatNewSession`
  * Field `ChatSessionChangedStatus`
  * Field `CompactModeInjection`
  * Field `CustomerCenterAuthentication`
  * Field `CustomerSetSubscriptions`
  * Field `DbiTaskFailed`
  * Field `ImportMailAfterProcessing`
  * Field `ImportMailBeforeProcessing`
  * Field `MainMenu`
  * Field `NewNotifyTicketFromForm`
  * Field `NewTicket`
  * Field `NewTicketFromCustomerCenter`
  * Field `NewTicketFromCustomerCenterBeforeSave`
  * Field `NewTicketFromEmail`
  * Field `NewTicketFromForm`
  * Field `NewTicketFromSpmLink`
  * Field `SalesAfterSaveAppointment`
  * Field `SalesAfterSaveApproveQuote`
  * Field `SalesAfterSaveContact`
  * Field `SalesAfterSaveCustomObject`
  * Field `SalesAfterSaveDocument`
  * Field `SalesAfterSavePerson`
  * Field `SalesAfterSaveProject`
  * Field `SalesAfterSaveProjectMember`
  * Field `SalesAfterSaveQuote`
  * Field `SalesAfterSaveQuoteLine`
  * Field `SalesAfterSaveRejectQuote`
  * Field `SalesAfterSaveRelation`
  * Field `SalesAfterSaveSale`
  * Field `SalesAfterSaveSelection`
  * Field `SalesAfterSaveSelectionMember`
  * Field `SalesAfterSaveStakeholder`
  * Field `SalesAfterSaveTicket`
  * Field `SalesBeforeSaveAppointment`
  * Field `SalesBeforeSaveApproveQuote`
  * Field `SalesBeforeSaveContact`
  * Field `SalesBeforeSaveCustomObject`
  * Field `SalesBeforeSaveDocument`
  * Field `SalesBeforeSavePerson`
  * Field `SalesBeforeSaveProject`
  * Field `SalesBeforeSaveProjectMember`
  * Field `SalesBeforeSaveQuote`
  * Field `SalesBeforeSaveQuoteLine`
  * Field `SalesBeforeSaveRejectQuote`
  * Field `SalesBeforeSaveRelation`
  * Field `SalesBeforeSaveSale`
  * Field `SalesBeforeSaveSelection`
  * Field `SalesBeforeSaveSelectionMember`
  * Field `SalesBeforeSaveStakeholder`
  * Field `SalesBeforeSaveTicket`
  * Field `SalesLoadCustomObject`
  * Field `ScheduledTaskFailed`
  * Field `ServiceScreenAddMessageAfterSubmit`
  * Field `ServiceScreenAddMessageBeforeSubmit`
  * Field `ServiceScreenAddMessageLoad`
  * Field `ServiceScreenEditCompanyAfterSubmit`
  * Field `ServiceScreenEditCompanyBeforeSubmit`
  * Field `ServiceScreenEditCompanyLoad`
  * Field `ServiceScreenEditCustomerAfterSubmit`
  * Field `ServiceScreenEditCustomerBeforeSubmit`
  * Field `ServiceScreenEditCustomerLoad`
  * Field `ServiceScreenEditExtraTableAfterSubmit`
  * Field `ServiceScreenEditExtraTableBeforeSubmit`
  * Field `ServiceScreenEditExtraTableLoad`
  * Field `ServiceScreenEditTicketAfterSubmit`
  * Field `ServiceScreenEditTicketBeforeSubmit`
  * Field `ServiceScreenEditTicketLoad`
  * Field `ServiceScreenForwardAfterSubmit`
  * Field `ServiceScreenForwardBeforeSubmit`
  * Field `ServiceScreenForwardLoad`
  * Field `ServiceScreenListTicketMessagesAfterSubmit`
  * Field `ServiceScreenListTicketMessagesBeforeSubmit`
  * Field `ServiceScreenListTicketMessagesLoad`
  * Field `ServiceScreenNewQuickTicketAfterSubmit`
  * Field `ServiceScreenNewQuickTicketBeforeSubmit`
  * Field `ServiceScreenNewQuickTicketLoad`
  * Field `ServiceScreenNewTicketAfterSubmit`
  * Field `ServiceScreenNewTicketBeforeSubmit`
  * Field `ServiceScreenNewTicketLoad`
  * Field `ServiceScreenViewCompanyAfterSubmit`
  * Field `ServiceScreenViewCompanyBeforeSubmit`
  * Field `ServiceScreenViewCompanyLoad`
  * Field `ServiceScreenViewCustomerAfterSubmit`
  * Field `ServiceScreenViewCustomerBeforeSubmit`
  * Field `ServiceScreenViewCustomerLoad`
  * Field `TicketActivated`
  * Field `TicketChangedCategory`
  * Field `TicketChangedOwnedBy`
  * Field `TicketChangedPrimaryCustomer`
  * Field `TicketChangedPriority`
  * Field `TicketChangedSlevel`
  * Field `TicketChangedTicketStatus`
  * Field `TicketClosed`
  * Field `TicketDeleted`
  * Field `TicketExternalMessageAdded`
  * Field `TicketInternalMessageAdded`
  * Field `TicketMessageAdded`
  * Field `TicketMessageSentimentCalculated`
  * Field `TicketPostponed`
  * Field `TicketReopened`
  * Field `TicketReopenedFromCustomerCenter`
  * Field `TicketReopenedFromEmail`
  * Field `TicketSave`
  * Field `Unknown`
* New items
  * Field `SalesSplitTicket`

#### SuperOffice.CD.DSL.Database.FormSubmissionStatus is Modified

* Modified items
  * Field `EmailVerification`
  * Field `Failed`
  * Field `InProgress`
  * Field `Processed`
  * Field `Submitted`
  * Field `Unknown`

#### SuperOffice.CD.DSL.Database.FormType is Modified

* Modified items
  * Field `Normal`
  * Field `Template`

#### SuperOffice.CD.DSL.Database.LoginFlags is Modified

* Modified items
  * Field `HideIEWarning`

#### SuperOffice.CD.DSL.Database.NotifyType is Modified

* Modified items
  * Field `ActiveTickets`
  * Field `ChatAlert`
  * Field `ChatMessageAlert`
  * Field `ChatSessionTransfered`
  * Field `Custom`
  * Field `Hotlist`
  * Field `NewTicket`
  * Field `NewTicketMessage`
  * Field `NotifyAll`
  * Field `TicketActivated`
  * Field `TicketEscalated`
  * Field `TicketTakeOver`

#### SuperOffice.CD.DSL.Database.RecipientSorting is Modified

* Modified items
  * Field `CompanyName`
  * Field `CompanyNumber`
  * Field `CountryZipCode`
  * Field `None`
  * Field `PersonLastname`

#### SuperOffice.CD.DSL.Database.ReplyTemplateAccessLevel is Modified

* Modified items
  * Field `Full`
  * Field `None`
  * Field `Read`

#### SuperOffice.CD.DSL.Database.ReplyTemplateBodyFlags is Modified

* Modified items
  * Field `ReplyTemplateBodyDefault`
  * Field `ReplyTemplateBodyIncludeHtml`
  * Field `ReplyTemplateBodyIncludePlain`
  * Field `ReplyTemplateBodyNone`

#### SuperOffice.CD.DSL.Database.ReplyTemplateFlags is Modified

* Modified items
  * Field `ReplyTemplateAll`
  * Field `ReplyTemplateCustomerChatLog`
  * Field `ReplyTemplateCustomerConfirmEmail`
  * Field `ReplyTemplateCustomerCustomerReply`
  * Field `ReplyTemplateCustomerNewCustomer`
  * Field `ReplyTemplateCustomerPassword`
  * Field `ReplyTemplateHotlistNewMessage`
  * Field `ReplyTemplateHotlistTicketActivated`
  * Field `ReplyTemplateHotlistTicketAlarm`
  * Field `ReplyTemplateHotlistTicketTakenOver`
  * Field `ReplyTemplateLicenseExpirationWarning`
  * Field `ReplyTemplateNewLink`
  * Field `ReplyTemplateNone`
  * Field `ReplyTemplatePrintTicket`
  * Field `ReplyTemplatePublishKbAnswer`
  * Field `ReplyTemplatePublishKbQuestion`
  * Field `ReplyTemplateUserActiveTickets`
  * Field `ReplyTemplateUserNewMessage`
  * Field `ReplyTemplateUserNewTicket`
  * Field `ReplyTemplateUserTicketActivated`
  * Field `ReplyTemplateUserTicketAlarm`
  * Field `ReplyTemplateUserTicketTakenOver`
  * Field `ReplyTemplateWeekStat`

#### SuperOffice.CD.DSL.Database.ScriptType is Modified

* Modified items
  * Field `CRMScript`
  * Field `JavaScript`
  * Field `Unknown`

#### SuperOffice.CD.DSL.Database.ServiceAuthStatus is Modified

* Modified items
  * Field `Error`
  * Field `Initialized`
  * Field `Unknown`

#### SuperOffice.CD.DSL.Database.ShipmentMessageType is Modified

* Modified items
  * Field `Document`
  * Field `Html`
  * Field `Plain`
  * Field `Sms`
  * Field `SourceView`

#### SuperOffice.CD.DSL.Database.Steps_Chat.ChatSessionStatus is Modified

* Modified items
  * Field `Closed`
  * Field `ClosedFromQueue`
  * Field `CustomerLast`
  * Field `Deleted`
  * Field `Faq`
  * Field `Finished`
  * Field `InQueue`
  * Field `Invalid`
  * Field `OfflineForm`
  * Field `PreChatForm`
  * Field `RequestPosted`
  * Field `UserLast`

#### SuperOffice.CD.DSL.Database.Steps_Chat.ChatTopicFlag is Modified

* Modified items
  * Field `CollectConsent`
  * Field `EmailAlert`
  * Field `None`
  * Field `OfflineCollectConsent`
  * Field `PopupAlert`
  * Field `UseCustomQueueMessage`
  * Field `UseQueueOfflineForm`
  * Field `WidgetSizeLarge`

#### SuperOffice.CD.DSL.Database.Steps_Chat.ChatWidgetSize is Modified

* Modified items
  * Field `Large`
  * Field `Normal`

#### SuperOffice.CD.DSL.Database.Steps_CS.ElementStatus is Modified

* Modified items
  * Field `None`
  * Field `Skipped`

#### SuperOffice.CD.DSL.Database.Steps_Notifications.ModifiedAppointmentFields is Modified

* Modified items
  * Field `Date`
  * Field `Location`
  * Field `None`
  * Field `Time`

#### SuperOffice.CD.DSL.Database.TagEntity is Modified

* Modified items
  * Field `Global`
  * Field `Ticket`

#### SuperOffice.CD.DSL.Database.TicketAlertAction is Modified

* Modified items
  * Field `ActionDelegate`
  * Field `ActionEmail`
  * Field `ActionEmailCategoryMaster`
  * Field `ActionEmailCustomer`
  * Field `ActionEmailUser`
  * Field `ActionScript`
  * Field `ActionSms`
  * Field `ActionSmsCategoryMaster`
  * Field `ActionSmsCustomer`
  * Field `ActionSmsUser`

#### SuperOffice.CD.DSL.Database.TicketCategoryClosingStatus is Modified

* Modified items
  * Field `Active`
  * Field `Closed`
  * Field `Postponed`
  * Field `UserDefined`

#### SuperOffice.CD.DSL.Database.TicketCategoryDelegateMethod is Modified

* Modified items
  * Field `Even`
  * Field `Not`
  * Field `Unfair`
  * Field `Unknown`
  * Field `Weighted`

#### SuperOffice.CD.DSL.Database.TicketCategoryFlags is Modified

* Modified items
  * Field `AcceptWhenReplying`
  * Field `DefaultToCategoryMaster`
  * Field `DelegateToOurContact`
  * Field `Internal`
  * Field `ListInMain`
  * Field `MembersOnly`
  * Field `NotifyMembers`
  * Field `OnlyLoggedInUsers`
  * Field `PropagateReplyTemplate`
  * Field `RedelegateNewMsg`
  * Field `Unknown`

#### SuperOffice.CD.DSL.Database.TicketMessageCategory is Modified

* Modified items
  * Field `Bounce`
  * Field `Message`
  * Field `OutboxFailed`

#### SuperOffice.CD.DSL.Database.TicketMessageType is Modified

* Modified items
  * Field `Html`
  * Field `Plain`
  * Field `Unknown`

#### SuperOffice.CD.DSL.Database.TicketPriorityEscalateAction is Modified

* Modified items
  * Field `ActionChangedOwner`
  * Field `ActionChangedPriority`
  * Field `ActionClosed`
  * Field `ActionNew`
  * Field `ActionNewInfo`
  * Field `ActionRead`

#### SuperOffice.CD.DSL.Database.TicketPriorityEscalateEvent is Modified

* Modified items
  * Field `Continue`
  * Field `None`
  * Field `Restart`
  * Field `Stop`

#### SuperOffice.CD.DSL.Database.TicketPriorityFlags is Modified

* Modified items
  * Field `AlertSchedule`
  * Field `Default`
  * Field `External`
  * Field `Unknown`

#### SuperOffice.CD.DSL.Database.TicketPriorityStatus is Modified

* Modified items
  * Field `Deleted`
  * Field `Normal`
  * Field `Unknown`

#### SuperOffice.CD.DSL.Database.TicketReadStatus is Modified

* Modified items
  * Field `Green`
  * Field `Red`
  * Field `Unknown`
  * Field `Yellow`

#### SuperOffice.CD.DSL.Database.TicketSecurityLevel is Modified

* Modified items
  * Field `External`
  * Field `Internal`
  * Field `Unknown`

#### SuperOffice.CD.DSL.Database.WidgetRequiredFields is Modified

* Modified items
  * Field `Company`
  * Field `Country`
  * Field `Email`
  * Field `Name`
  * Field `None`
  * Field `Phone`

#### SuperOffice.CD.DSL.Database.WidgetTheme is Modified

* Modified items
  * Field `Classic`
  * Field `Modern`
