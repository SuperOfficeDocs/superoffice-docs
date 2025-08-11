---
uid: version_11.1.447_changes
date: 6/12/2025
---

Changes from v10.5.5.982 and v11.1.447

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Deleted Types

* `SuperOffice.CRM.Services.AgentBase<TAgent>`
* `SuperOffice.CRM.Services.AIAgent`
* `SuperOffice.CRM.Services.AppointmentAgent`
* `SuperOffice.CRM.Services.ArchiveAgent`
* `SuperOffice.CRM.Services.Area`
* `SuperOffice.CRM.Services.AssociateAgent`
* `SuperOffice.CRM.Services.AudienceAgent`
* `SuperOffice.CRM.Services.BatchAgent`
* `SuperOffice.CRM.Services.BLOBAgent`
* `SuperOffice.CRM.Services.BulkUpdateAgent`
* `SuperOffice.CRM.Services.ChatAgent`
* `SuperOffice.CRM.Services.ContactAgent`
* `SuperOffice.CRM.Services.CRMScriptAgent`
* `SuperOffice.CRM.Services.CustomerServiceAgent`
* `SuperOffice.CRM.Services.DashAgent`
* `SuperOffice.CRM.Services.Dashboard`
* `SuperOffice.CRM.Services.DashboardAgent`
* `SuperOffice.CRM.Services.DashboardTile`
* `SuperOffice.CRM.Services.DashboardTileOption`
* `SuperOffice.CRM.Services.DatabaseAgent`
* `SuperOffice.CRM.Services.DatabaseTableAgent`
* `SuperOffice.CRM.Services.DiagnosticsAgent`
* `SuperOffice.CRM.Services.DocumentAgent`
* `SuperOffice.CRM.Services.DocumentMigrationAgent`
* `SuperOffice.CRM.Services.EMailAgent`
* `SuperOffice.CRM.Services.ErpSyncAgent`
* `SuperOffice.CRM.Services.FavouriteAgent`
* `SuperOffice.CRM.Services.FindAgent`
* `SuperOffice.CRM.Services.ForeignSystemAgent`
* `SuperOffice.CRM.Services.FreeTextAgent`
* `SuperOffice.CRM.Services.IAudienceAgent`
* `SuperOffice.CRM.Services.IDashboardAgent`
* `SuperOffice.CRM.Services.ImportAgent`
* `SuperOffice.CRM.Services.IPartnerAgent`
* `SuperOffice.CRM.Services.IReplicationAgent`
* `SuperOffice.CRM.Services.LicenseAgent`
* `SuperOffice.CRM.Services.ListAgent`
* `SuperOffice.CRM.Services.MailMergeSettings`
* `SuperOffice.CRM.Services.MailMergeTask`
* `SuperOffice.CRM.Services.MarketingAgent`
* `SuperOffice.CRM.Services.MDOAgent`
* `SuperOffice.CRM.Services.NumberAllocationAgent`
* `SuperOffice.CRM.Services.PartnerAgent`
* `SuperOffice.CRM.Services.PartnerWebPanel`
* `SuperOffice.CRM.Services.PersonAgent`
* `SuperOffice.CRM.Services.PhoneListAgent`
* `SuperOffice.CRM.Services.PocketAgent`
* `SuperOffice.CRM.Services.PreferenceAgent`
* `SuperOffice.CRM.Services.ProjectAgent`
* `SuperOffice.CRM.Services.QuoteAgent`
* `SuperOffice.CRM.Services.QuoteListItem`
* `SuperOffice.CRM.Services.RelationAgent`
* `SuperOffice.CRM.Services.ReplicationAgent`
* `SuperOffice.CRM.Services.ReportAgent`
* `SuperOffice.CRM.Services.ReportEntity`
* `SuperOffice.CRM.Services.ResourceAgent`
* `SuperOffice.CRM.Services.SaintAgent`
* `SuperOffice.CRM.Services.SaleAgent`
* `SuperOffice.CRM.Services.Satellite`
* `SuperOffice.CRM.Services.SelectionAgent`
* `SuperOffice.CRM.Services.SentryAgent`
* `SuperOffice.CRM.Services.SystemEventEntity`
* `SuperOffice.CRM.Services.TargetsAgent`
* `SuperOffice.CRM.Services.Task`
* `SuperOffice.CRM.Services.TicketAgent`
* `SuperOffice.CRM.Services.TileData`
* `SuperOffice.CRM.Services.TileDataRow`
* `SuperOffice.CRM.Services.TimeZoneAgent`
* `SuperOffice.CRM.Services.UserAgent`
* `SuperOffice.CRM.Services.UserDefinedFieldInfoAgent`
* `SuperOffice.CRM.Services.ViewStateAgent`
* `SuperOffice.CRM.Services.WebhookAgent`
* `SuperOffice.CRM.Services.WorkflowAgent`

### New Types

* `SuperOffice.CRM.Services.SoTask`

### Modified Types

#### SuperOffice.CRM.Services.AppointmentMoveData is Modified

* Modified items
  * Property `NewStartTime`

#### SuperOffice.CRM.Services.IAIAgent is Modified

* Deleted items
  * Method `ClearChatbotTurns(String)`
  * Method `CreateTextForAppointment(AppointmentEntity, String)`
  * Method `DetectLanguage(String)`
  * Method `DetectSentiment(String)`
  * Method `ExpandText(String, Int32, String)`
  * Method `GetChatbotPromptSuggestions(String, String, Int32)`
  * Method `GetChatbotResponse(String, String, String, String, ChatbotTurn[], String)`
  * Method `GetChatbotTurns(String)`
  * Method `GetSummarizeContactPrompt(Int32, Int32, String, String)`
  * Method `GetSummarizeSalePrompt(Int32, Int32, String, String)`
  * Method `GetSummarizeTicketPrompt(Int32, Int32, String, String)`
  * Method `GetTrainingStatus()`
  * Method `GuessCategory(Int32)`
  * Method `RephraseText(String, AiTextStyle, String)`
  * Method `SummarizeContact(Int32, Int32, String)`
  * Method `SummarizeSale(Int32, Int32, String)`
  * Method `SummarizeText(String, Int32, String)`
  * Method `SummarizeTicket(Int32, Int32, String)`
  * Method `TrainCategoryGuesser(Int32, Int32, Int32)`
  * Method `Translate(String, String)`
  * Method `TranslateEntity(String, Int32, String)`
* New items
  * Method `ClearChatbotTurnsAsync(String, CancellationToken)`
  * Method `CreateTextForAppointmentAsync(AppointmentEntity, String, CancellationToken)`
  * Method `DetectLanguageAsync(String, CancellationToken)`
  * Method `DetectSentimentAsync(String, CancellationToken)`
  * Method `ExpandTextAsync(String, Int32, String, CancellationToken)`
  * Method `GetChatbotPromptSuggestionsAsync(String, String, Int32, CancellationToken)`
  * Method `GetChatbotResponseAsync(String, String, String, String, ChatbotTurn[], String, CancellationToken)`
  * Method `GetChatbotTurnsAsync(String, CancellationToken)`
  * Method `GetSummarizeContactPromptAsync(Int32, Int32, String, String, CancellationToken)`
  * Method `GetSummarizeSalePromptAsync(Int32, Int32, String, String, CancellationToken)`
  * Method `GetSummarizeTicketPromptAsync(Int32, Int32, String, String, CancellationToken)`
  * Method `GetTrainingStatusAsync(CancellationToken)`
  * Method `GuessCategoryAsync(Int32, CancellationToken)`
  * Method `RephraseTextAsync(String, AiTextStyle, String, CancellationToken)`
  * Method `SummarizeContactAsync(Int32, Int32, String, CancellationToken)`
  * Method `SummarizeSaleAsync(Int32, Int32, String, CancellationToken)`
  * Method `SummarizeTextAsync(String, Int32, String, CancellationToken)`
  * Method `SummarizeTicketAsync(Int32, Int32, String, CancellationToken)`
  * Method `TrainCategoryGuesserAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `TranslateAsync(String, String, CancellationToken)`
  * Method `TranslateEntityAsync(String, Int32, String, CancellationToken)`

#### SuperOffice.CRM.Services.IAppointmentAgent is Modified

* Deleted items
  * Method `Accept(Int32, RecurrenceUpdateMode)`
  * Method `AcceptRejected(Int32, RecurrenceUpdateMode)`
  * Method `AcceptWithEmailConfirmation(Int32, RecurrenceUpdateMode)`
  * Method `AcceptWithSmtpEmailConfirmation(Int32, RecurrenceUpdateMode, EMailConnectionInfo)`
  * Method `AssignTo(Int32, ParticipantInfo, RecurrenceUpdateMode)`
  * Method `CalculateDays(AppointmentEntity)`
  * Method `CanAssignToProjectMember(Int32, Int32)`
  * Method `CleanUpBookingDeleted(Int32[])`
  * Method `CleanUpBookingDeletedWithUpdateMode(Int32[], RecurrenceUpdateMode)`
  * Method `CleanUpRecurringBookingDeleted()`
  * Method `ConvertAppointmentToTask(Int32)`
  * Method `CreateAndAccept(Int32, RecurrenceUpdateMode)`
  * Method `CreateAndAcceptWithEmailConfirmation(Int32, RecurrenceUpdateMode)`
  * Method `CreateAppointmentEntityFromExisting(Int32, Int32)`
  * Method `CreateAppointmentForUID(AppointmentEntity, String)`
  * Method `CreateDefaultAppointmentEntity()`
  * Method `CreateDefaultAppointmentEntityByType(TaskType)`
  * Method `CreateDefaultAppointmentEntityByTypeAndAssociate(TaskType, Int32)`
  * Method `CreateDefaultAppointmentEntityFromProjectSuggestion(Int32, Int32, Boolean, Int32)`
  * Method `CreateDefaultAppointmentEntityFromSaleSuggestion(Int32, Int32, Boolean, Int32)`
  * Method `CreateDefaultRecurrence()`
  * Method `CreateDefaultRecurrenceByDate(DateTime)`
  * Method `CreateDefaultReOpenAppointment(Int32)`
  * Method `CreateDefaultSuggestedAppointmentEntity()`
  * Method `CreateDefaultTaskListItem()`
  * Method `CreateVideoMeetingReservation()`
  * Method `DeclineInvitationFromEmailItem(Int32, String)`
  * Method `Delete(Int32, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `DeleteAppointmentEntity(Int32)`
  * Method `DeleteVideoMeetingReservation(String)`
  * Method `GenerateLead(Int32, String, String, Int32, String, String, String, String, String, String, String, String)`
  * Method `GetActivityInformationListByDatesAndAssociate(DateTime, DateTime, Int32)`
  * Method `GetAlarms(Boolean, Boolean, Int32)`
  * Method `GetAppointment(Int32)`
  * Method `GetAppointmentEmailInvitation(AppointmentEntity, String, String)`
  * Method `GetAppointmentEntity(Int32)`
  * Method `GetAppointmentFromUID(String)`
  * Method `GetAppointmentHaveParticipantsWithEmail(Int32)`
  * Method `GetAppointmentList(Int32[])`
  * Method `GetAppointmentRecords(Int32, Int32)`
  * Method `GetAppointmentsByTaskHeading(Int32)`
  * Method `GetAssociateDiary(Int32, DateTime, DateTime, Int32)`
  * Method `GetAssociatesDiary(Int32[], DateTime, DateTime)`
  * Method `GetAssociatesDiaryInfo(Int32[], DateTime, DateTime)`
  * Method `GetCanInsertForAssociates(Int32[])`
  * Method `GetContactAppointments(Int32, DateTime, DateTime, Int32)`
  * Method `GetContactAppointmentsByTask(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetContactAppointmentsByTaskHeading(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetContactAppointmentsByTasks(Int32, DateTime, DateTime, Int32, Int32[])`
  * Method `GetContactAppointmentsByType(Int32, DateTime, DateTime, Int32, AppointmentType)`
  * Method `GetDayInformationListByDatesAndAssociate(DateTime, DateTime, Int32)`
  * Method `GetDiaryByGroup(Int32, Int32, DateTime, DateTime, Int32)`
  * Method `GetMyAppointments(DateTime, DateTime, Int32)`
  * Method `GetMyDiary(DateTime, DateTime, Int32)`
  * Method `GetMyPublishedAppointments()`
  * Method `GetMySyncAppointments(DateTime, DateTime)`
  * Method `GetMyTasks(Int32)`
  * Method `GetNextAvailableTime(Int32[], DateTime, DateTime, Int32, Boolean)`
  * Method `GetNextSuggestedAppointmentBySale(Int32, Int32, Boolean)`
  * Method `GetOrganizerName(Int32)`
  * Method `GetPersonAppointments(Int32, Boolean, DateTime, DateTime, Int32)`
  * Method `GetPersonAppointmentsByTask(Int32, Boolean, DateTime, DateTime, Int32, Int32)`
  * Method `GetPersonAppointmentsByTaskHeading(Int32, Boolean, DateTime, DateTime, Int32, Int32)`
  * Method `GetPersonAppointmentsByTasks(Int32, Boolean, DateTime, DateTime, Int32, Int32[])`
  * Method `GetPersonAppointmentsByType(Int32, Boolean, DateTime, DateTime, Int32, AppointmentType)`
  * Method `GetPersonDiary(Int32, DateTime, DateTime, Int32)`
  * Method `GetPersonTasks(Int32, Int32)`
  * Method `GetProjectAppointments(Int32, DateTime, DateTime, Int32)`
  * Method `GetProjectAppointmentsByTask(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetProjectAppointmentsByTaskHeading(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetProjectAppointmentsByTasks(Int32, DateTime, DateTime, Int32, Int32[])`
  * Method `GetProjectAppointmentsByType(Int32, DateTime, DateTime, Int32, AppointmentType)`
  * Method `GetProjectMemberAppointments(Int32, DateTime, DateTime, Int32)`
  * Method `GetProjectMemberAppointmentsByTask(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetProjectMemberAppointmentsByTaskHeading(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetProjectMemberAppointmentsByTasks(Int32, DateTime, DateTime, Int32, Int32[])`
  * Method `GetProjectMemberAppointmentsByType(Int32, DateTime, DateTime, Int32, AppointmentType)`
  * Method `GetPublishedAppointment(Int32)`
  * Method `GetPublishedAppointments(Int32[])`
  * Method `GetPublishedProjectAppointments(Int32)`
  * Method `GetRedLetterInformationListByDatesAndAssociate(DateTime, DateTime, Int32)`
  * Method `GetSuggestedAppointment(Int32)`
  * Method `GetSuggestedAppointmentEntity(Int32)`
  * Method `GetTaskListItem(Int32)`
  * Method `GetTaskListItems(Boolean)`
  * Method `GetUIDFromAppointmentId(Int32, Boolean)`
  * Method `Move(Int32, DateTime, RecurrenceUpdateMode)`
  * Method `MoveExtended(AppointmentMoveData)`
  * Method `MoveWithEmail(Int32, DateTime, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `Reject(Int32, String, RecurrenceUpdateMode)`
  * Method `RejectWithEmailConfirmation(Int32, String, RecurrenceUpdateMode)`
  * Method `RejectWithSmtpEmailConfirmation(Int32, String, RecurrenceUpdateMode, EMailConnectionInfo)`
  * Method `RequestForInfo(Int32, String, String, String, String, String, String, String)`
  * Method `Save(AppointmentEntity, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `SaveAppointmentEntity(AppointmentEntity)`
  * Method `SaveSuggestedAppointmentEntity(SuggestedAppointmentEntity)`
  * Method `SaveTaskListItem(TaskListItem)`
  * Method `SaveWithCustomInvitation(AppointmentEntity, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, String, String, String)`
  * Method `SetActivityStatus(String[], ActivityStatus)`
  * Method `SetSeen(Int32, RecurrenceUpdateMode)`
  * Method `SetSeenMany(Int32[], RecurrenceUpdateMode)`
  * Method `ToggleActivities(String[])`
  * Method `ToggleActivity(String)`
  * Method `ToggleAndSetActivities(String[])`
  * Method `ToggleAppointmentStatus(Int32)`
  * Method `UpdateAppointment(Int32, DateTime, DateTime, Int32, Int32, Int32)`
  * Method `UpdateAppointmentFromIcsResponse(String, Stream)`
  * Method `UpdateAppointmentWithMode(Int32, DateTime, DateTime, AppointmentStatus, AppointmentType, Int32, RecurrenceUpdateMode)`
  * Method `UpdateAppointmentWithModeAndEmail(Int32, DateTime, DateTime, AppointmentStatus, AppointmentType, Int32, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `ValidateAppointmentEntity(AppointmentEntity)`
  * Method `ValidateDays(AppointmentEntity, DateTime[])`
  * Method `WillSendEmail(AppointmentEntity)`
* New items
  * Method `AcceptAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `AcceptRejectedAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `AcceptWithEmailConfirmationAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `AcceptWithSmtpEmailConfirmationAsync(Int32, RecurrenceUpdateMode, EMailConnectionInfo, CancellationToken)`
  * Method `AssignToAsync(Int32, ParticipantInfo, RecurrenceUpdateMode, CancellationToken)`
  * Method `CalculateDaysAsync(AppointmentEntity, CancellationToken)`
  * Method `CanAssignToProjectMemberAsync(Int32, Int32, CancellationToken)`
  * Method `CleanUpBookingDeletedAsync(Int32[], CancellationToken)`
  * Method `CleanUpBookingDeletedWithUpdateModeAsync(Int32[], RecurrenceUpdateMode, CancellationToken)`
  * Method `CleanUpRecurringBookingDeletedAsync(CancellationToken)`
  * Method `ConvertAppointmentToTaskAsync(Int32, CancellationToken)`
  * Method `CreateAndAcceptAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `CreateAndAcceptWithEmailConfirmationAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `CreateAppointmentEntityFromExistingAsync(Int32, Int32, CancellationToken)`
  * Method `CreateAppointmentForUIDAsync(AppointmentEntity, String, CancellationToken)`
  * Method `CreateDefaultAppointmentEntityAsync(CancellationToken)`
  * Method `CreateDefaultAppointmentEntityByTypeAndAssociateAsync(TaskType, Int32, CancellationToken)`
  * Method `CreateDefaultAppointmentEntityByTypeAsync(TaskType, CancellationToken)`
  * Method `CreateDefaultAppointmentEntityFromProjectSuggestionAsync(Int32, Int32, Boolean, Int32, CancellationToken)`
  * Method `CreateDefaultAppointmentEntityFromSaleSuggestionAsync(Int32, Int32, Boolean, Int32, CancellationToken)`
  * Method `CreateDefaultRecurrenceAsync(CancellationToken)`
  * Method `CreateDefaultRecurrenceByDateAsync(DateTime, CancellationToken)`
  * Method `CreateDefaultReOpenAppointmentAsync(Int32, CancellationToken)`
  * Method `CreateDefaultSuggestedAppointmentEntityAsync(CancellationToken)`
  * Method `CreateDefaultTaskListItemAsync(CancellationToken)`
  * Method `CreateVideoMeetingReservationAsync(CancellationToken)`
  * Method `DeclineInvitationFromEmailItemAsync(Int32, String, CancellationToken)`
  * Method `DeleteAppointmentEntityAsync(Int32, CancellationToken)`
  * Method `DeleteAsync(Int32, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `DeleteVideoMeetingReservationAsync(String, CancellationToken)`
  * Method `GenerateLeadAsync(Int32, String, String, Int32, String, String, String, String, String, String, String, String, CancellationToken)`
  * Method `GetActivityInformationListByDatesAndAssociateAsync(DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetAlarmsAsync(Boolean, Boolean, Int32, CancellationToken)`
  * Method `GetAppointmentAsync(Int32, CancellationToken)`
  * Method `GetAppointmentEmailInvitationAsync(AppointmentEntity, String, String, CancellationToken)`
  * Method `GetAppointmentEntityAsync(Int32, CancellationToken)`
  * Method `GetAppointmentFromUIDAsync(String, CancellationToken)`
  * Method `GetAppointmentHaveParticipantsWithEmailAsync(Int32, CancellationToken)`
  * Method `GetAppointmentListAsync(Int32[], CancellationToken)`
  * Method `GetAppointmentRecordsAsync(Int32, Int32, CancellationToken)`
  * Method `GetAppointmentsByTaskHeadingAsync(Int32, CancellationToken)`
  * Method `GetAssociateDiaryAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetAssociatesDiaryAsync(Int32[], DateTime, DateTime, CancellationToken)`
  * Method `GetAssociatesDiaryInfoAsync(Int32[], DateTime, DateTime, CancellationToken)`
  * Method `GetCanInsertForAssociatesAsync(Int32[], CancellationToken)`
  * Method `GetContactAppointmentsAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetContactAppointmentsByTaskAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetContactAppointmentsByTaskHeadingAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetContactAppointmentsByTasksAsync(Int32, DateTime, DateTime, Int32, Int32[], CancellationToken)`
  * Method `GetContactAppointmentsByTypeAsync(Int32, DateTime, DateTime, Int32, AppointmentType, CancellationToken)`
  * Method `GetDayInformationListByDatesAndAssociateAsync(DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetDiaryByGroupAsync(Int32, Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetMyAppointmentsAsync(DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetMyDiaryAsync(DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetMyPublishedAppointmentsAsync(CancellationToken)`
  * Method `GetMySyncAppointmentsAsync(DateTime, DateTime, CancellationToken)`
  * Method `GetMyTasksAsync(Int32, CancellationToken)`
  * Method `GetNextAvailableTimeAsync(Int32[], DateTime, DateTime, Int32, Boolean, CancellationToken)`
  * Method `GetNextSuggestedAppointmentBySaleAsync(Int32, Int32, Boolean, CancellationToken)`
  * Method `GetOrganizerNameAsync(Int32, CancellationToken)`
  * Method `GetPersonAppointmentsAsync(Int32, Boolean, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetPersonAppointmentsByTaskAsync(Int32, Boolean, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetPersonAppointmentsByTaskHeadingAsync(Int32, Boolean, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetPersonAppointmentsByTasksAsync(Int32, Boolean, DateTime, DateTime, Int32, Int32[], CancellationToken)`
  * Method `GetPersonAppointmentsByTypeAsync(Int32, Boolean, DateTime, DateTime, Int32, AppointmentType, CancellationToken)`
  * Method `GetPersonDiaryAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetPersonTasksAsync(Int32, Int32, CancellationToken)`
  * Method `GetProjectAppointmentsAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetProjectAppointmentsByTaskAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetProjectAppointmentsByTaskHeadingAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetProjectAppointmentsByTasksAsync(Int32, DateTime, DateTime, Int32, Int32[], CancellationToken)`
  * Method `GetProjectAppointmentsByTypeAsync(Int32, DateTime, DateTime, Int32, AppointmentType, CancellationToken)`
  * Method `GetProjectMemberAppointmentsAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetProjectMemberAppointmentsByTaskAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetProjectMemberAppointmentsByTaskHeadingAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetProjectMemberAppointmentsByTasksAsync(Int32, DateTime, DateTime, Int32, Int32[], CancellationToken)`
  * Method `GetProjectMemberAppointmentsByTypeAsync(Int32, DateTime, DateTime, Int32, AppointmentType, CancellationToken)`
  * Method `GetPublishedAppointmentAsync(Int32, CancellationToken)`
  * Method `GetPublishedAppointmentsAsync(Int32[], CancellationToken)`
  * Method `GetPublishedProjectAppointmentsAsync(Int32, CancellationToken)`
  * Method `GetRedLetterInformationListByDatesAndAssociateAsync(DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetSuggestedAppointmentAsync(Int32, CancellationToken)`
  * Method `GetSuggestedAppointmentEntityAsync(Int32, CancellationToken)`
  * Method `GetTaskListItemAsync(Int32, CancellationToken)`
  * Method `GetTaskListItemsAsync(Boolean, CancellationToken)`
  * Method `GetUIDFromAppointmentIdAsync(Int32, Boolean, CancellationToken)`
  * Method `MoveAsync(Int32, DateTime, RecurrenceUpdateMode, CancellationToken)`
  * Method `MoveExtendedAsync(AppointmentMoveData, CancellationToken)`
  * Method `MoveWithEmailAsync(Int32, DateTime, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `RejectAsync(Int32, String, RecurrenceUpdateMode, CancellationToken)`
  * Method `RejectWithEmailConfirmationAsync(Int32, String, RecurrenceUpdateMode, CancellationToken)`
  * Method `RejectWithSmtpEmailConfirmationAsync(Int32, String, RecurrenceUpdateMode, EMailConnectionInfo, CancellationToken)`
  * Method `RequestForInfoAsync(Int32, String, String, String, String, String, String, String, CancellationToken)`
  * Method `SaveAppointmentEntityAsync(AppointmentEntity, CancellationToken)`
  * Method `SaveAsync(AppointmentEntity, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `SaveSuggestedAppointmentEntityAsync(SuggestedAppointmentEntity, CancellationToken)`
  * Method `SaveTaskListItemAsync(TaskListItem, CancellationToken)`
  * Method `SaveWithCustomInvitationAsync(AppointmentEntity, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, String, String, String, CancellationToken)`
  * Method `SetActivityStatusAsync(String[], ActivityStatus, CancellationToken)`
  * Method `SetSeenAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `SetSeenManyAsync(Int32[], RecurrenceUpdateMode, CancellationToken)`
  * Method `ToggleActivitiesAsync(String[], CancellationToken)`
  * Method `ToggleActivityAsync(String, CancellationToken)`
  * Method `ToggleAndSetActivitiesAsync(String[], CancellationToken)`
  * Method `ToggleAppointmentStatusAsync(Int32, CancellationToken)`
  * Method `UpdateAppointmentAsync(Int32, DateTime, DateTime, Int32, Int32, Int32, CancellationToken)`
  * Method `UpdateAppointmentFromIcsResponseAsync(String, Stream, CancellationToken)`
  * Method `UpdateAppointmentWithModeAndEmailAsync(Int32, DateTime, DateTime, AppointmentStatus, AppointmentType, Int32, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `UpdateAppointmentWithModeAsync(Int32, DateTime, DateTime, AppointmentStatus, AppointmentType, Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `ValidateAppointmentEntityAsync(AppointmentEntity, CancellationToken)`
  * Method `ValidateDaysAsync(AppointmentEntity, DateTime[], CancellationToken)`
  * Method `WillSendEmailAsync(AppointmentEntity, CancellationToken)`

#### SuperOffice.CRM.Services.IArchiveAgent is Modified

* Deleted items
  * Method `CreateDefaultArchiveListResult()`
  * Method `ExportArchive(String, String, String[], String[], ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String, String[], Int32)`
  * Method `GetActivityFilter()`
  * Method `GetArchiveConfiguration(String, String)`
  * Method `GetArchiveConfigurationV2(String, String, String, String)`
  * Method `GetArchiveConfigurationWithContext(String, String, String)`
  * Method `GetArchiveList(String, String, ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String[], Int32, Int32)`
  * Method `GetArchiveList2(String, String, String, String, String, Int32, Int32)`
  * Method `GetArchiveListByColumns(String, String[], ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String[], Int32, Int32)`
  * Method `GetArchiveListByColumns2(String, String, String, String, String, Int32, Int32)`
  * Method `GetArchiveListByColumnsWithContext(String, String[], ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String[], Int32, Int32, String)`
  * Method `GetArchiveListByColumnsWithContext2(String, String, String, String, String, Int32, Int32, String)`
  * Method `GetArchiveListByColumnsWithHeader(String, String[], ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String[], Int32, Int32, String)`
  * Method `GetArchiveListByColumnsWithHeader2(String, String, String, String, String, Int32, Int32, String)`
  * Method `GetArchiveListByColumnsWithHeaderWithContext(String, String[], ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String[], Int32, Int32, String, String)`
  * Method `GetArchiveListByColumnsWithHeaderWithContext2(String, String, String, String, String, Int32, Int32, String, String)`
  * Method `GetArchiveListWithContext(String, String, ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String[], Int32, Int32, String)`
  * Method `GetArchiveListWithContext2(String, String, String, String, String, Int32, Int32, String)`
  * Method `GetAvailableColumns(String, String)`
  * Method `GetAvailableEntities(String, String)`
  * Method `GetGroupAssociateIds(Int32[])`
  * Method `GetProviderNames()`
  * Method `GetRelatedData(String, Int32, String[])`
  * Method `GetRelatedData2(String, Int32, String)`
  * Method `SetActivityFilter(ActivityFilter)`
  * Method `SetChosenColumns(String, String, String[])`
  * Method `SetChosenColumnsV2(String, String, String, String, String[])`
  * Method `SetChosenEntities(String, String, String[])`
  * Method `SetChosenEntitiesV2(String, String, String, String, String[])`
  * Method `SetColumnWidths(String, String[])`
  * Method `SetColumnWidthsV2(String, String, String, String, String[])`
* New items
  * Method `CreateDefaultArchiveListResultAsync(CancellationToken)`
  * Method `ExportArchiveAsync(String, String, String[], String[], ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String, String[], Int32, CancellationToken)`
  * Method `GetActivityFilterAsync(CancellationToken)`
  * Method `GetArchiveConfigurationAsync(String, String, CancellationToken)`
  * Method `GetArchiveConfigurationV2Async(String, String, String, String, CancellationToken)`
  * Method `GetArchiveConfigurationWithContextAsync(String, String, String, CancellationToken)`
  * Method `GetArchiveList2Async(String, String, String, String, String, Int32, Int32, CancellationToken)`
  * Method `GetArchiveListAsync(String, String, ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String[], Int32, Int32, CancellationToken)`
  * Method `GetArchiveListByColumns2Async(String, String, String, String, String, Int32, Int32, CancellationToken)`
  * Method `GetArchiveListByColumnsAsync(String, String[], ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String[], Int32, Int32, CancellationToken)`
  * Method `GetArchiveListByColumnsWithContext2Async(String, String, String, String, String, Int32, Int32, String, CancellationToken)`
  * Method `GetArchiveListByColumnsWithContextAsync(String, String[], ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String[], Int32, Int32, String, CancellationToken)`
  * Method `GetArchiveListByColumnsWithHeader2Async(String, String, String, String, String, Int32, Int32, String, CancellationToken)`
  * Method `GetArchiveListByColumnsWithHeaderAsync(String, String[], ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String[], Int32, Int32, String, CancellationToken)`
  * Method `GetArchiveListByColumnsWithHeaderWithContext2Async(String, String, String, String, String, Int32, Int32, String, String, CancellationToken)`
  * Method `GetArchiveListByColumnsWithHeaderWithContextAsync(String, String[], ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String[], Int32, Int32, String, String, CancellationToken)`
  * Method `GetArchiveListWithContext2Async(String, String, String, String, String, Int32, Int32, String, CancellationToken)`
  * Method `GetArchiveListWithContextAsync(String, String, ArchiveOrderByInfo[], ArchiveRestrictionInfo[], String[], Int32, Int32, String, CancellationToken)`
  * Method `GetAvailableColumnsAsync(String, String, CancellationToken)`
  * Method `GetAvailableEntitiesAsync(String, String, CancellationToken)`
  * Method `GetGroupAssociateIdsAsync(Int32[], CancellationToken)`
  * Method `GetProviderNamesAsync(CancellationToken)`
  * Method `GetRelatedData2Async(String, Int32, String, CancellationToken)`
  * Method `GetRelatedDataAsync(String, Int32, String[], CancellationToken)`
  * Method `SetActivityFilterAsync(ActivityFilter, CancellationToken)`
  * Method `SetChosenColumnsAsync(String, String, String[], CancellationToken)`
  * Method `SetChosenColumnsV2Async(String, String, String, String, String[], CancellationToken)`
  * Method `SetChosenEntitiesAsync(String, String, String[], CancellationToken)`
  * Method `SetChosenEntitiesV2Async(String, String, String, String, String[], CancellationToken)`
  * Method `SetColumnWidthsAsync(String, String[], CancellationToken)`
  * Method `SetColumnWidthsV2Async(String, String, String, String, String[], CancellationToken)`

#### SuperOffice.CRM.Services.IAssociateAgent is Modified

* Deleted items
  * Method `GetAssociate(Int32)`
  * Method `GetAssociateByPersonId(Int32)`
  * Method `GetAssociateList(Int32[])`
  * Method `GetAssociatesByGroup(Int32, Int32)`
  * Method `GetEncryptionKey()`
  * Method `GetNote(Int32)`
  * Method `LogOffWindowsUsers(Int32[])`
  * Method `SaveNote(Int32, String[])`
* New items
  * Method `GetAssociateAsync(Int32, CancellationToken)`
  * Method `GetAssociateByPersonIdAsync(Int32, CancellationToken)`
  * Method `GetAssociateListAsync(Int32[], CancellationToken)`
  * Method `GetAssociatesByGroupAsync(Int32, Int32, CancellationToken)`
  * Method `GetEncryptionKeyAsync(CancellationToken)`
  * Method `GetNoteAsync(Int32, CancellationToken)`
  * Method `LogOffWindowsUsersAsync(Int32[], CancellationToken)`
  * Method `SaveNoteAsync(Int32, String[], CancellationToken)`

#### SuperOffice.CRM.Services.IBatchAgent is Modified

* Deleted items
  * Method `DeleteBatchTask(Int32)`
  * Method `DeleteBatchTasks(Int32[])`
  * Method `GetAllBatchTaskInfosByName(String)`
  * Method `GetAllBatchTaskInfosByNameAndState(String, BatchTaskState)`
  * Method `GetBatchTaskInfo(Int32)`
  * Method `GetBatchTaskInfosByAssociates(Int32[])`
  * Method `GetBatchTaskInfosByAssociatesAndState(Int32[], BatchTaskState)`
  * Method `GetBatchTaskInfosByNameAndAssociates(String, Int32[])`
  * Method `GetBatchTaskInfosByNameAndState(String, BatchTaskState)`
  * Method `GetBatchTaskInfosByState(BatchTaskState)`
  * Method `GetSystemBatchTaskInfosByName(String)`
  * Method `GetSystemBatchTaskInfosByNameAndState(String, BatchTaskState)`
  * Method `StartBatchJob(BatchTaskInfo)`
  * Method `StopBatchJob(Int32)`
  * Method `UpdateBatchTask(BatchTaskInfo)`
* New items
  * Method `DeleteBatchTaskAsync(Int32, CancellationToken)`
  * Method `DeleteBatchTasksAsync(Int32[], CancellationToken)`
  * Method `GetAllBatchTaskInfosByNameAndStateAsync(String, BatchTaskState, CancellationToken)`
  * Method `GetAllBatchTaskInfosByNameAsync(String, CancellationToken)`
  * Method `GetBatchTaskInfoAsync(Int32, CancellationToken)`
  * Method `GetBatchTaskInfosByAssociatesAndStateAsync(Int32[], BatchTaskState, CancellationToken)`
  * Method `GetBatchTaskInfosByAssociatesAsync(Int32[], CancellationToken)`
  * Method `GetBatchTaskInfosByNameAndAssociatesAsync(String, Int32[], CancellationToken)`
  * Method `GetBatchTaskInfosByNameAndStateAsync(String, BatchTaskState, CancellationToken)`
  * Method `GetBatchTaskInfosByStateAsync(BatchTaskState, CancellationToken)`
  * Method `GetSystemBatchTaskInfosByNameAndStateAsync(String, BatchTaskState, CancellationToken)`
  * Method `GetSystemBatchTaskInfosByNameAsync(String, CancellationToken)`
  * Method `StartBatchJobAsync(BatchTaskInfo, CancellationToken)`
  * Method `StopBatchJobAsync(Int32, CancellationToken)`
  * Method `UpdateBatchTaskAsync(BatchTaskInfo, CancellationToken)`

#### SuperOffice.CRM.Services.IBLOBAgent is Modified

* Deleted items
  * Method `ChangeContactImage(Int32, Int32)`
  * Method `ChangePersonImage(Int32, Int32)`
  * Method `ChangeProductImage(Int32, Int32)`
  * Method `ChangeProjectImage(Int32, Int32)`
  * Method `CleanupBatchTask(Int32)`
  * Method `CreateDefaultBlobEntity()`
  * Method `DeleteBlobEntity(Int32)`
  * Method `GetAppData(String)`
  * Method `GetBlobEntity(Int32)`
  * Method `GetBlobEntityOnContact(Int32)`
  * Method `GetBlobEntityOnCountry(Int32)`
  * Method `GetBlobEntityOnPerson(Int32)`
  * Method `GetBlobEntityOnProduct(Int32)`
  * Method `GetBlobEntityOnProject(Int32)`
  * Method `GetBlobStream(Int32)`
  * Method `GetChatImageWithSize(Int32, Int32, Int32)`
  * Method `GetContactImage(Int32)`
  * Method `GetContactImageWithSize(Int32, Int32, Int32)`
  * Method `GetOutputFromBatch(Int32)`
  * Method `GetPersonImage(Int32)`
  * Method `GetPersonImageWithSize(Int32, Int32, Int32)`
  * Method `GetProductImage(Int32)`
  * Method `GetProductThumbnail(Int32)`
  * Method `GetProjectImage(Int32)`
  * Method `GetProjectImageWithSize(Int32, Int32, Int32)`
  * Method `GetQuoteLineImage(Int32)`
  * Method `SaveBlobEntity(BlobEntity)`
  * Method `SaveImageStream(BlobLinkType, Image, String)`
  * Method `SaveProjectImage(String, Image)`
  * Method `SetAppData(String, String)`
  * Method `SetBlobStream(Int32, Stream)`
  * Method `SetContactImage(Int32, Image)`
  * Method `SetPersonImage(Int32, Image)`
  * Method `SetProductImage(Int32, Image)`
  * Method `SetProductThumbnail(Int32, Image)`
  * Method `SetProjectImage(Int32, Image)`
* New items
  * Method `ChangeContactImageAsync(Int32, Int32, CancellationToken)`
  * Method `ChangePersonImageAsync(Int32, Int32, CancellationToken)`
  * Method `ChangeProductImageAsync(Int32, Int32, CancellationToken)`
  * Method `ChangeProjectImageAsync(Int32, Int32, CancellationToken)`
  * Method `CleanupBatchTaskAsync(Int32, CancellationToken)`
  * Method `CreateDefaultBlobEntityAsync(CancellationToken)`
  * Method `DeleteBlobEntityAsync(Int32, CancellationToken)`
  * Method `GetBlobEntityAsync(Int32, CancellationToken)`
  * Method `GetBlobEntityOnContactAsync(Int32, CancellationToken)`
  * Method `GetBlobEntityOnCountryAsync(Int32, CancellationToken)`
  * Method `GetBlobEntityOnPersonAsync(Int32, CancellationToken)`
  * Method `GetBlobEntityOnProductAsync(Int32, CancellationToken)`
  * Method `GetBlobEntityOnProjectAsync(Int32, CancellationToken)`
  * Method `GetBlobStreamAsync(Int32, CancellationToken)`
  * Method `GetChatImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetContactImageAsync(Int32, CancellationToken)`
  * Method `GetContactImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetOutputFromBatchAsync(Int32, CancellationToken)`
  * Method `GetPersonImageAsync(Int32, CancellationToken)`
  * Method `GetPersonImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetProductImageAsync(Int32, CancellationToken)`
  * Method `GetProductThumbnailAsync(Int32, CancellationToken)`
  * Method `GetProjectImageAsync(Int32, CancellationToken)`
  * Method `GetProjectImageWithSizeAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetQuoteLineImageAsync(Int32, CancellationToken)`
  * Method `SaveBlobEntityAsync(BlobEntity, CancellationToken)`
  * Method `SaveImageStreamAsync(BlobLinkType, Image, String, CancellationToken)`
  * Method `SaveProjectImageAsync(String, Image, CancellationToken)`
  * Method `SetBlobStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetContactImageAsync(Int32, Image, CancellationToken)`
  * Method `SetPersonImageAsync(Int32, Image, CancellationToken)`
  * Method `SetProductImageAsync(Int32, Image, CancellationToken)`
  * Method `SetProductThumbnailAsync(Int32, Image, CancellationToken)`
  * Method `SetProjectImageAsync(Int32, Image, CancellationToken)`

#### SuperOffice.CRM.Services.IBulkUpdateAgent is Modified

* Deleted items
  * Method `ExecuteByEntityIds(FieldValueInfo[], String, String, String)`
  * Method `ExecuteBySelectionId(FieldValueInfo[], String, String, Int32, Boolean)`
  * Method `GetAvailableFields(String)`
  * Method `GetJobResultAsJsonFromBinaryObjectId(String, Int32)`
  * Method `GetJobResultsFromStorageAsJson()`
  * Method `GetStoredFields(String, String)`
  * Method `RemoveStoredFields(String, String)`
  * Method `RemoveStoredFieldsAndGetDefaultFields(String, String)`
* New items
  * Method `ExecuteByEntityIdsAsync(FieldValueInfo[], String, String, String, CancellationToken)`
  * Method `ExecuteBySelectionIdAsync(FieldValueInfo[], String, String, Int32, Boolean, CancellationToken)`
  * Method `GetAvailableFieldsAsync(String, CancellationToken)`
  * Method `GetJobResultAsJsonFromBinaryObjectIdAsync(String, Int32, CancellationToken)`
  * Method `GetJobResultsFromStorageAsJsonAsync(CancellationToken)`
  * Method `GetStoredFieldsAsync(String, String, CancellationToken)`
  * Method `RemoveStoredFieldsAndGetDefaultFieldsAsync(String, String, CancellationToken)`
  * Method `RemoveStoredFieldsAsync(String, String, CancellationToken)`

#### SuperOffice.CRM.Services.IChatAgent is Modified

* Deleted items
  * Method `AcceptChatSessionTransfer(Int32)`
  * Method `AddChatMessage(Int32, ChatMessage)`
  * Method `AddChatTopicUserAgent(Int32, ChatTopicAgent)`
  * Method `ChatSessionsForUser()`
  * Method `ChatTopicsForUser()`
  * Method `CreateChatSessionForTopic(Int32)`
  * Method `CreateDefaultChatSessionEntity()`
  * Method `CreateDefaultChatTopicAgent()`
  * Method `CreateDefaultChatTopicEntity()`
  * Method `DeleteChatSessionEntity(Int32)`
  * Method `DeleteChatTopicEntity(Int32)`
  * Method `DeleteChatTopicUserAgent(Int32, String)`
  * Method `GetChatMessages(Int32, Int32)`
  * Method `GetChatPresence()`
  * Method `GetChatSessionEntity(Int32)`
  * Method `GetChatTopicEntity(Int32)`
  * Method `GetChatTopicUserAgent(Int32, String)`
  * Method `GetChatTopicUserAgentList(Int32)`
  * Method `GetChatTranscript(Int32, Boolean)`
  * Method `GetUserAgentList(Boolean, Boolean)`
  * Method `IsWithinOpeningHours(Int32)`
  * Method `PickUpChatSession(Int32)`
  * Method `PickUpFirstChatSession()`
  * Method `RejectChatSessionTransfer(Int32)`
  * Method `ResetChatSession(Int32)`
  * Method `SaveChatPresence(ChatPresence[])`
  * Method `SaveChatSessionEntity(ChatSessionEntity)`
  * Method `SaveChatTopicEntity(ChatTopicEntity)`
  * Method `TransferChatSession(Int32, String)`
  * Method `UpdateChatTopicUserAgent(Int32, String, ChatTopicAgent)`
  * Method `UpdateChatTopicUserAgents(Int32, ChatTopicAgent[])`
* New items
  * Method `AcceptChatSessionTransferAsync(Int32, CancellationToken)`
  * Method `AddChatMessageAsync(Int32, ChatMessage, CancellationToken)`
  * Method `AddChatTopicUserAgentAsync(Int32, ChatTopicAgent, CancellationToken)`
  * Method `ChatSessionsForUserAsync(CancellationToken)`
  * Method `ChatTopicsForUserAsync(CancellationToken)`
  * Method `CreateChatSessionForTopicAsync(Int32, CancellationToken)`
  * Method `CreateDefaultChatSessionEntityAsync(CancellationToken)`
  * Method `CreateDefaultChatTopicAgentAsync(CancellationToken)`
  * Method `CreateDefaultChatTopicEntityAsync(CancellationToken)`
  * Method `DeleteChatSessionEntityAsync(Int32, CancellationToken)`
  * Method `DeleteChatTopicEntityAsync(Int32, CancellationToken)`
  * Method `DeleteChatTopicUserAgentAsync(Int32, String, CancellationToken)`
  * Method `GetChatMessagesAsync(Int32, Int32, CancellationToken)`
  * Method `GetChatPresenceAsync(CancellationToken)`
  * Method `GetChatSessionEntityAsync(Int32, CancellationToken)`
  * Method `GetChatTopicEntityAsync(Int32, CancellationToken)`
  * Method `GetChatTopicUserAgentAsync(Int32, String, CancellationToken)`
  * Method `GetChatTopicUserAgentListAsync(Int32, CancellationToken)`
  * Method `GetChatTranscriptAsync(Int32, Boolean, CancellationToken)`
  * Method `GetUserAgentListAsync(Boolean, Boolean, CancellationToken)`
  * Method `IsWithinOpeningHoursAsync(Int32, CancellationToken)`
  * Method `PickUpChatSessionAsync(Int32, CancellationToken)`
  * Method `PickUpFirstChatSessionAsync(CancellationToken)`
  * Method `RejectChatSessionTransferAsync(Int32, CancellationToken)`
  * Method `ResetChatSessionAsync(Int32, CancellationToken)`
  * Method `SaveChatPresenceAsync(ChatPresence[], CancellationToken)`
  * Method `SaveChatSessionEntityAsync(ChatSessionEntity, CancellationToken)`
  * Method `SaveChatTopicEntityAsync(ChatTopicEntity, CancellationToken)`
  * Method `TransferChatSessionAsync(Int32, String, CancellationToken)`
  * Method `UpdateChatTopicUserAgentAsync(Int32, String, ChatTopicAgent, CancellationToken)`
  * Method `UpdateChatTopicUserAgentsAsync(Int32, ChatTopicAgent[], CancellationToken)`

#### SuperOffice.CRM.Services.IContactAgent is Modified

* Deleted items
  * Method `AddPerson(Int32, PersonEntity)`
  * Method `ChangeCountry(ContactEntity, Int32)`
  * Method `Copy(Int32, String, String, Boolean)`
  * Method `CreateDefaultContactEntity()`
  * Method `CreateDefaultPreviewContact()`
  * Method `CreateNewEntry(DuplicateEntry)`
  * Method `DeleteContactEntity(Int32)`
  * Method `DeleteExpired()`
  * Method `GetAddress(Int32)`
  * Method `GetAddressByCountry(Int32, Int32)`
  * Method `GetContact(Int32)`
  * Method `GetContactEntity(Int32)`
  * Method `GetContactList(Int32[])`
  * Method `GetContactSummary(Int32, Int32)`
  * Method `GetContactWithPersons(Int32)`
  * Method `GetDomainDuplicates(String)`
  * Method `GetDuplicateRules()`
  * Method `GetDuplicates(String)`
  * Method `GetMyActiveContacts(DateTime, Int32[], ContactAction)`
  * Method `GetMyBizCard()`
  * Method `GetMyContact()`
  * Method `GetMyContacts()`
  * Method `GetMyRecentContacts(ContactSourceType)`
  * Method `GetNameDepartmentDuplicates(String, String)`
  * Method `GetPersons(Int32)`
  * Method `GetPreviewContact(Int32)`
  * Method `GetQuoteVersionAddresses(Int32)`
  * Method `IsNumberValid(Int32, String)`
  * Method `Merge(Int32, Int32, Boolean, Boolean)`
  * Method `SaveContactEntity(ContactEntity)`
  * Method `SaveQuoteVersionAddress(Int32, Address, AddressType, Int32)`
  * Method `SetDuplicateRulesStatus(DuplicateRule[])`
  * Method `Undelete(Int32)`
  * Method `ValidateContactEntity(ContactEntity)`
* New items
  * Method `AddPersonAsync(Int32, PersonEntity, CancellationToken)`
  * Method `ChangeCountryAsync(ContactEntity, Int32, CancellationToken)`
  * Method `CopyAsync(Int32, String, String, Boolean, CancellationToken)`
  * Method `CreateDefaultContactEntityAsync(CancellationToken)`
  * Method `CreateDefaultPreviewContactAsync(CancellationToken)`
  * Method `CreateNewEntryAsync(DuplicateEntry, CancellationToken)`
  * Method `DeleteContactEntityAsync(Int32, CancellationToken)`
  * Method `DeleteExpiredAsync(CancellationToken)`
  * Method `GetAddressAsync(Int32, CancellationToken)`
  * Method `GetAddressByCountryAsync(Int32, Int32, CancellationToken)`
  * Method `GetContactAsync(Int32, CancellationToken)`
  * Method `GetContactEntityAsync(Int32, CancellationToken)`
  * Method `GetContactListAsync(Int32[], CancellationToken)`
  * Method `GetContactSummaryAsync(Int32, Int32, CancellationToken)`
  * Method `GetContactWithPersonsAsync(Int32, CancellationToken)`
  * Method `GetDomainDuplicatesAsync(String, CancellationToken)`
  * Method `GetDuplicateRulesAsync(CancellationToken)`
  * Method `GetDuplicatesAsync(String, CancellationToken)`
  * Method `GetMyActiveContactsAsync(DateTime, Int32[], ContactAction, CancellationToken)`
  * Method `GetMyBizCardAsync(CancellationToken)`
  * Method `GetMyContactAsync(CancellationToken)`
  * Method `GetMyContactsAsync(CancellationToken)`
  * Method `GetMyRecentContactsAsync(ContactSourceType, CancellationToken)`
  * Method `GetNameDepartmentDuplicatesAsync(String, String, CancellationToken)`
  * Method `GetPersonsAsync(Int32, CancellationToken)`
  * Method `GetPreviewContactAsync(Int32, CancellationToken)`
  * Method `GetQuoteVersionAddressesAsync(Int32, CancellationToken)`
  * Method `IsNumberValidAsync(Int32, String, CancellationToken)`
  * Method `MergeAsync(Int32, Int32, Boolean, Boolean, CancellationToken)`
  * Method `SaveContactEntityAsync(ContactEntity, CancellationToken)`
  * Method `SaveQuoteVersionAddressAsync(Int32, Address, AddressType, Int32, CancellationToken)`
  * Method `SetDuplicateRulesStatusAsync(DuplicateRule[], CancellationToken)`
  * Method `UndeleteAsync(Int32, CancellationToken)`
  * Method `ValidateContactEntityAsync(ContactEntity, CancellationToken)`

#### SuperOffice.CRM.Services.ICRMScriptAgent is Modified

* Deleted items
  * Method `CreateDefaultCRMScriptEntity()`
  * Method `CreateDefaultTriggerScriptEntity()`
  * Method `DeleteCRMScriptByUniqueIdentifier(String)`
  * Method `DeleteCRMScriptEntity(Int32)`
  * Method `DeleteTriggerScriptByUniqueId(String)`
  * Method `DeleteTriggerScriptEntity(Int32)`
  * Method `ExecuteScript(Int32, StringDictionary)`
  * Method `ExecuteScriptAsEvent(Int32, EventData)`
  * Method `ExecuteScriptAsEventByUniqueId(String, EventData)`
  * Method `ExecuteScriptByIncludeId(String, StringDictionary)`
  * Method `ExecuteScriptByString(String, StringDictionary, EventData)`
  * Method `ExecuteScriptByUniqueId(String, StringDictionary)`
  * Method `GetCRMScriptByUniqueIdentifier(String)`
  * Method `GetCRMScriptEntity(Int32)`
  * Method `GetTriggerScriptByUniqueId(String)`
  * Method `GetTriggerScriptEntity(Int32)`
  * Method `ResolveIncludes(String, Boolean)`
  * Method `SaveCRMScriptByUniqueIdentifier(String, Script)`
  * Method `SaveCRMScriptEntity(CRMScriptEntity)`
  * Method `SaveCRMScriptEntityWithoutCompile(CRMScriptEntity)`
  * Method `SaveTriggerScriptByUniqueId(String, TriggerScriptEntity)`
  * Method `SaveTriggerScriptEntity(TriggerScriptEntity)`
  * Method `ValidateScript(Int32)`
  * Method `ValidateScriptByIncludeId(String)`
  * Method `ValidateScriptByString(String)`
  * Method `ValidateScriptByUniqueId(String)`
  * Method `ValidateTriggerScript(Int32)`
  * Method `ValidateTriggerScriptByUniqueId(String)`
* New items
  * Method `CreateDefaultCRMScriptEntityAsync(CancellationToken)`
  * Method `CreateDefaultTriggerScriptEntityAsync(CancellationToken)`
  * Method `DeleteCRMScriptByUniqueIdentifierAsync(String, CancellationToken)`
  * Method `DeleteCRMScriptEntityAsync(Int32, CancellationToken)`
  * Method `DeleteTriggerScriptByUniqueIdAsync(String, CancellationToken)`
  * Method `DeleteTriggerScriptEntityAsync(Int32, CancellationToken)`
  * Method `ExecuteScriptAsEventAsync(Int32, EventData, CancellationToken)`
  * Method `ExecuteScriptAsEventByUniqueIdAsync(String, EventData, CancellationToken)`
  * Method `ExecuteScriptAsync(Int32, StringDictionary, CancellationToken)`
  * Method `ExecuteScriptByIncludeIdAsync(String, StringDictionary, CancellationToken)`
  * Method `ExecuteScriptByStringAsync(String, StringDictionary, EventData, CancellationToken)`
  * Method `ExecuteScriptByUniqueIdAsync(String, StringDictionary, CancellationToken)`
  * Method `GetCRMScriptByUniqueIdentifierAsync(String, CancellationToken)`
  * Method `GetCRMScriptEntityAsync(Int32, CancellationToken)`
  * Method `GetTriggerScriptByUniqueIdAsync(String, CancellationToken)`
  * Method `GetTriggerScriptEntityAsync(Int32, CancellationToken)`
  * Method `ResolveIncludesAsync(String, Boolean, CancellationToken)`
  * Method `SaveCRMScriptByUniqueIdentifierAsync(String, Script, CancellationToken)`
  * Method `SaveCRMScriptEntityAsync(CRMScriptEntity, CancellationToken)`
  * Method `SaveCRMScriptEntityWithoutCompileAsync(CRMScriptEntity, CancellationToken)`
  * Method `SaveTriggerScriptByUniqueIdAsync(String, TriggerScriptEntity, CancellationToken)`
  * Method `SaveTriggerScriptEntityAsync(TriggerScriptEntity, CancellationToken)`
  * Method `ValidateScriptAsync(Int32, CancellationToken)`
  * Method `ValidateScriptByIncludeIdAsync(String, CancellationToken)`
  * Method `ValidateScriptByStringAsync(String, CancellationToken)`
  * Method `ValidateScriptByUniqueIdAsync(String, CancellationToken)`
  * Method `ValidateTriggerScriptAsync(Int32, CancellationToken)`
  * Method `ValidateTriggerScriptByUniqueIdAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.ICustomerServiceAgent is Modified

* Deleted items
  * Method `AddMessageFromMailData(Int32, String)`
  * Method `ChatSessionsForUser()`
  * Method `CheckIfCustomizedTemplates()`
  * Method `CheckSymmetricEncryption(String)`
  * Method `CreateDefaultCustomerCenterConfig()`
  * Method `CreateDefaultMailboxEntity()`
  * Method `CreateDefaultSmsConfig()`
  * Method `CreateSession(String)`
  * Method `CreateTicketFromMailData(Int32, String)`
  * Method `DeleteChatSessions(Int32[])`
  * Method `DeleteCustomerCenterConfig(Int32)`
  * Method `EventHandlerExists(EventHandlerType)`
  * Method `EventHandlersExists(EventHandlerType[])`
  * Method `ExecuteEventHandlers(EventData)`
  * Method `FindTicketsByTitleOrId(String, Int32)`
  * Method `GetAllCustomerCenterConfigs()`
  * Method `GetCustomerCenterConfig(Int32)`
  * Method `GetCustomerServiceStartup()`
  * Method `GetCustomerServiceStartupByOwner(Int32)`
  * Method `GetFaqForCustomer(Int32)`
  * Method `GetMailboxEntity(Int32)`
  * Method `GetMailboxes()`
  * Method `GetParsedTemplate(Int32, Int32, Int32, Int32)`
  * Method `GetPreviewFaqEntry(Int32)`
  * Method `GetPreviewQuickReply(Int32)`
  * Method `GetPreviewReplyTemplate(Int32)`
  * Method `GetProgramUrl(String, Boolean)`
  * Method `GetSmsConfig()`
  * Method `GetStatistics(StatusScreenPanelType[])`
  * Method `GetSystemTemplateSettings()`
  * Method `GetUnparsedTemplate(Int32, Int32)`
  * Method `HasChatNotify()`
  * Method `RemoveSession(Int32)`
  * Method `ReportSessionActive(String)`
  * Method `SaveAllCustomerCenterConfigs(CustomerCenterConfig[])`
  * Method `SaveCustomerCenterConfig(CustomerCenterConfig)`
  * Method `SaveMailboxEntity(MailboxEntity)`
  * Method `SaveSmsConfig(SmsConfig)`
  * Method `SaveSystemTemplateSettings(SystemTemplateSettings)`
  * Method `SessionIsValid(String)`
  * Method `TestSmtpServer(String, String, Boolean)`
  * Method `UpdateFeatureToggles(CsFeatureToggle[])`
* New items
  * Method `AddMessageFromMailDataAsync(Int32, String, CancellationToken)`
  * Method `ChatSessionsForUserAsync(CancellationToken)`
  * Method `CheckIfCustomizedTemplatesAsync(CancellationToken)`
  * Method `CheckSymmetricEncryptionAsync(String, CancellationToken)`
  * Method `CreateDefaultCustomerCenterConfigAsync(CancellationToken)`
  * Method `CreateDefaultMailboxEntityAsync(CancellationToken)`
  * Method `CreateSessionAsync(String, CancellationToken)`
  * Method `CreateTicketFromMailDataAsync(Int32, String, CancellationToken)`
  * Method `DeleteChatSessionsAsync(Int32[], CancellationToken)`
  * Method `DeleteCustomerCenterConfigAsync(Int32, CancellationToken)`
  * Method `EventHandlerExistsAsync(EventHandlerType, CancellationToken)`
  * Method `EventHandlersExistsAsync(EventHandlerType[], CancellationToken)`
  * Method `ExecuteEventHandlersAsync(EventData, CancellationToken)`
  * Method `FindTicketsByTitleOrIdAsync(String, Int32, CancellationToken)`
  * Method `GetAllCustomerCenterConfigsAsync(CancellationToken)`
  * Method `GetCustomerCenterConfigAsync(Int32, CancellationToken)`
  * Method `GetCustomerServiceStartupAsync(CancellationToken)`
  * Method `GetCustomerServiceStartupByOwnerAsync(Int32, CancellationToken)`
  * Method `GetFaqForCustomerAsync(Int32, CancellationToken)`
  * Method `GetMailboxEntityAsync(Int32, CancellationToken)`
  * Method `GetMailboxesAsync(CancellationToken)`
  * Method `GetParsedTemplateAsync(Int32, Int32, Int32, Int32, CancellationToken)`
  * Method `GetPreviewFaqEntryAsync(Int32, CancellationToken)`
  * Method `GetPreviewQuickReplyAsync(Int32, CancellationToken)`
  * Method `GetPreviewReplyTemplateAsync(Int32, CancellationToken)`
  * Method `GetProgramUrlAsync(String, Boolean, CancellationToken)`
  * Method `GetSmsConfigAsync(CancellationToken)`
  * Method `GetStatisticsAsync(StatusScreenPanelType[], CancellationToken)`
  * Method `GetSystemTemplateSettingsAsync(CancellationToken)`
  * Method `GetUnparsedTemplateAsync(Int32, Int32, CancellationToken)`
  * Method `HasChatNotifyAsync(CancellationToken)`
  * Method `RemoveSessionAsync(Int32, CancellationToken)`
  * Method `ReportSessionActiveAsync(String, CancellationToken)`
  * Method `SaveAllCustomerCenterConfigsAsync(CustomerCenterConfig[], CancellationToken)`
  * Method `SaveCustomerCenterConfigAsync(CustomerCenterConfig, CancellationToken)`
  * Method `SaveMailboxEntityAsync(MailboxEntity, CancellationToken)`
  * Method `SaveSystemTemplateSettingsAsync(SystemTemplateSettings, CancellationToken)`
  * Method `SessionIsValidAsync(String, CancellationToken)`
  * Method `TestSmtpServerAsync(String, String, Boolean, CancellationToken)`
  * Method `UpdateFeatureTogglesAsync(CsFeatureToggle[], CancellationToken)`

#### SuperOffice.CRM.Services.IDashAgent is Modified

* Deleted items
  * Method `AddNewTileToDashboard(Int32, DashTileDefinition)`
  * Method `AddTileToDashboard(Int32, Int32)`
  * Method `CopyTileSelection(Int32)`
  * Method `CreateDashTileSelectionFromEntity(String)`
  * Method `CreateDefaultDash()`
  * Method `CreateDefaultDashCollection()`
  * Method `CreateDefaultDashTheme()`
  * Method `CreateDefaultDashTile()`
  * Method `CreateDefaultDashTileDefinition()`
  * Method `CreateDefaultPreviewDash()`
  * Method `CreateDefaultPreviewDashTile()`
  * Method `CreateDefaultTileDefinitionForEntity(String)`
  * Method `CreateDefaultTileForEntity(String)`
  * Method `DeleteDash(Int32)`
  * Method `DeleteDashTheme(Int32)`
  * Method `DeleteDashTile(Int32)`
  * Method `DeleteDashTileDefinition(Int32)`
  * Method `DuplicateDashboard(Int32, String)`
  * Method `DuplicateTile(Int32, String)`
  * Method `GetDash(Int32)`
  * Method `GetDashCollection()`
  * Method `GetDashList(Int32[])`
  * Method `GetDashTheme(Int32)`
  * Method `GetDashTile(Int32)`
  * Method `GetDashTileDefinition(Int32)`
  * Method `GetDashTileHtml(Int32, String)`
  * Method `GetDashTileHtmlList(Int32)`
  * Method `GetDashTiles(Int32)`
  * Method `GetPreviewDash(Int32)`
  * Method `GetSecondaryTempTileSelection(Int32)`
  * Method `GetTempTileSelection(Int32)`
  * Method `SaveDash(Dash)`
  * Method `SaveDashTheme(DashTheme)`
  * Method `SaveDashTile(DashTile)`
  * Method `SaveDashTileDefinition(DashTileDefinition)`
  * Method `SaveDashTileHtmlList(Int32, DashTileHtml[])`
  * Method `SaveDashTiles(Int32, DashTile[])`
* New items
  * Method `AddNewTileToDashboardAsync(Int32, DashTileDefinition, CancellationToken)`
  * Method `AddTileToDashboardAsync(Int32, Int32, CancellationToken)`
  * Method `CopyTileSelectionAsync(Int32, CancellationToken)`
  * Method `CreateDashTileSelectionFromEntityAsync(String, CancellationToken)`
  * Method `CreateDefaultDashAsync(CancellationToken)`
  * Method `CreateDefaultDashCollectionAsync(CancellationToken)`
  * Method `CreateDefaultDashThemeAsync(CancellationToken)`
  * Method `CreateDefaultDashTileAsync(CancellationToken)`
  * Method `CreateDefaultDashTileDefinitionAsync(CancellationToken)`
  * Method `CreateDefaultPreviewDashAsync(CancellationToken)`
  * Method `CreateDefaultPreviewDashTileAsync(CancellationToken)`
  * Method `CreateDefaultTileDefinitionForEntityAsync(String, CancellationToken)`
  * Method `CreateDefaultTileForEntityAsync(String, CancellationToken)`
  * Method `DeleteDashAsync(Int32, CancellationToken)`
  * Method `DeleteDashThemeAsync(Int32, CancellationToken)`
  * Method `DeleteDashTileAsync(Int32, CancellationToken)`
  * Method `DeleteDashTileDefinitionAsync(Int32, CancellationToken)`
  * Method `DuplicateDashboardAsync(Int32, String, CancellationToken)`
  * Method `DuplicateTileAsync(Int32, String, CancellationToken)`
  * Method `GetDashAsync(Int32, CancellationToken)`
  * Method `GetDashCollectionAsync(CancellationToken)`
  * Method `GetDashListAsync(Int32[], CancellationToken)`
  * Method `GetDashThemeAsync(Int32, CancellationToken)`
  * Method `GetDashTileAsync(Int32, CancellationToken)`
  * Method `GetDashTileDefinitionAsync(Int32, CancellationToken)`
  * Method `GetDashTileHtmlAsync(Int32, String, CancellationToken)`
  * Method `GetDashTileHtmlListAsync(Int32, CancellationToken)`
  * Method `GetDashTilesAsync(Int32, CancellationToken)`
  * Method `GetPreviewDashAsync(Int32, CancellationToken)`
  * Method `GetSecondaryTempTileSelectionAsync(Int32, CancellationToken)`
  * Method `GetTempTileSelectionAsync(Int32, CancellationToken)`
  * Method `SaveDashAsync(Dash, CancellationToken)`
  * Method `SaveDashThemeAsync(DashTheme, CancellationToken)`
  * Method `SaveDashTileAsync(DashTile, CancellationToken)`
  * Method `SaveDashTileDefinitionAsync(DashTileDefinition, CancellationToken)`
  * Method `SaveDashTileHtmlListAsync(Int32, DashTileHtml[], CancellationToken)`
  * Method `SaveDashTilesAsync(Int32, DashTile[], CancellationToken)`

#### SuperOffice.CRM.Services.IDatabaseAgent is Modified

* Deleted items
  * Method `GetStepsFromNetServerCode()`
  * Method `GetStepsInDatabase()`
* New items
  * Method `GetStepsFromNetServerCodeAsync(CancellationToken)`
  * Method `GetStepsInDatabaseAsync(CancellationToken)`

#### SuperOffice.CRM.Services.IDatabaseTableAgent is Modified

* Deleted items
  * Method `Delete(String, Int32[])`
  * Method `DeleteRow(String, Int32)`
  * Method `Insert(String, String[], String[][])`
  * Method `InsertRow(String, StringDictionary)`
  * Method `ReadRow(String, Int32)`
  * Method `Truncate(String)`
  * Method `UpdateRow(String, Int32, StringDictionary)`
  * Method `Upsert(String, String[], String[], String[][], UpsertNomatchAction, Boolean)`
* New items
  * Method `DeleteAsync(String, Int32[], CancellationToken)`
  * Method `DeleteRowAsync(String, Int32, CancellationToken)`
  * Method `InsertAsync(String, String[], String[][], CancellationToken)`
  * Method `InsertRowAsync(String, StringDictionary, CancellationToken)`
  * Method `ReadRowAsync(String, Int32, CancellationToken)`
  * Method `TruncateAsync(String, CancellationToken)`
  * Method `UpdateRowAsync(String, Int32, StringDictionary, CancellationToken)`
  * Method `UpsertAsync(String, String[], String[], String[][], UpsertNomatchAction, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.IDiagnosticsAgent is Modified

* Deleted items
  * Method `AddWebAppUsage(WebAppUsage[])`
  * Method `ChangeLogSettings(Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean)`
  * Method `CollectDataAdditions()`
  * Method `CollectTableSizes()`
  * Method `CollectWebUsage()`
  * Method `CollectWinUsage()`
  * Method `FlushCaches()`
  * Method `FlushCachesByName(String[])`
  * Method `GetCacheInvalidationGenerations(String[])`
  * Method `GetCacheNames()`
  * Method `GetCacheState(String[])`
  * Method `GetEntityCountsForAllUsers()`
  * Method `GetEntityCountsForCurrentUser()`
  * Method `GetSystemMessages(Int32)`
  * Method `GetWebAppUsagesForPeriod(DateTime, DateTime, String)`
  * Method `LogViewState(String)`
  * Method `PerformTasksAfterCustomObjectTableDeleted(String)`
  * Method `PerformTasksAfterUpgrade()`
  * Method `RemoveExpiredSystemMessages()`
  * Method `RemoveSystemMessage(Int32, String)`
  * Method `RemoveSystemMessageForAssociate(Int32, String, Int32)`
  * Method `ResyncUsers()`
  * Method `SendSystemMessage(String, Int32, String, DateTime, SystemMessageType)`
  * Method `WebAppUsageExistsInPeriod(Int32, String, DateTime)`
* New items
  * Method `AddWebAppUsageAsync(WebAppUsage[], CancellationToken)`
  * Method `ChangeLogSettingsAsync(Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, CancellationToken)`
  * Method `CollectDataAdditionsAsync(CancellationToken)`
  * Method `CollectTableSizesAsync(CancellationToken)`
  * Method `CollectWebUsageAsync(CancellationToken)`
  * Method `CollectWinUsageAsync(CancellationToken)`
  * Method `FlushCachesAsync(CancellationToken)`
  * Method `FlushCachesByNameAsync(String[], CancellationToken)`
  * Method `GetCacheInvalidationGenerationsAsync(String[], CancellationToken)`
  * Method `GetCacheNamesAsync(CancellationToken)`
  * Method `GetCacheStateAsync(String[], CancellationToken)`
  * Method `GetEntityCountsForAllUsersAsync(CancellationToken)`
  * Method `GetEntityCountsForCurrentUserAsync(CancellationToken)`
  * Method `GetSystemMessagesAsync(Int32, CancellationToken)`
  * Method `GetWebAppUsagesForPeriodAsync(DateTime, DateTime, String, CancellationToken)`
  * Method `LogViewStateAsync(String, CancellationToken)`
  * Method `PerformTasksAfterCustomObjectTableDeletedAsync(String, CancellationToken)`
  * Method `PerformTasksAfterUpgradeAsync(CancellationToken)`
  * Method `RemoveExpiredSystemMessagesAsync(CancellationToken)`
  * Method `RemoveSystemMessageAsync(Int32, String, CancellationToken)`
  * Method `RemoveSystemMessageForAssociateAsync(Int32, String, Int32, CancellationToken)`
  * Method `ResyncUsersAsync(CancellationToken)`
  * Method `SendSystemMessageAsync(String, Int32, String, DateTime, SystemMessageType, CancellationToken)`
  * Method `WebAppUsageExistsInPeriodAsync(Int32, String, DateTime, CancellationToken)`

#### SuperOffice.CRM.Services.IDocumentAgent is Modified

* Deleted items
  * Method `CheckinDocument(Int32, String[], String, String[])`
  * Method `CheckoutDocument(Int32, String[])`
  * Method `CopyDocumentToCsAttachment(Int32)`
  * Method `CreateDefaultDocumentEntity()`
  * Method `CreateDefaultDocumentEntityFromSuggestion(Int32)`
  * Method `CreateDefaultDocumentPreview()`
  * Method `CreateDefaultSuggestedDocumentEntity()`
  * Method `CreateDefaultTemplateVariablesParameters()`
  * Method `CreateDocumentStream(DocumentEntity, Boolean)`
  * Method `CreateNewPhysicalDocumentFromTemplate(Int32, Int32, Int32, Int32, Int32, Int32, Int32, String)`
  * Method `CreateNewPhysicalDocumentFromTemplateWithCustomTags(Int32, Int32, Int32, Int32, Int32, Int32, Int32, String[], String[], String)`
  * Method `CreateNewPhysicalDocumentFromTemplateWithCustomTags2(Int32, Int32, Int32, Int32, Int32, Int32, Int32, StringDictionary, String)`
  * Method `CreateNewPhysicalMailMergeDocumentFromTemplate(Int32, String)`
  * Method `CreateTempFile(String, Stream)`
  * Method `DeleteDocumentEntity(Int32)`
  * Method `DeletePhysicalDocument(Int32, String[])`
  * Method `DeleteTempFile(String)`
  * Method `ExecuteDocumentCommand(Int32, String, String[], String, String[])`
  * Method `GetAppointmentDocuments(Int32)`
  * Method `GetCheckoutState(Int32)`
  * Method `GetContactDocuments(Int32, DateTime, DateTime, Int32)`
  * Method `GetContactDocumentsByTemplateHeading(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetContactDocumentsByTemplateType(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetContactDocumentsByTemplateTypes(Int32, DateTime, DateTime, Int32, Int32[])`
  * Method `GetDocument(Int32)`
  * Method `GetDocumentCommands(Int32, String[])`
  * Method `GetDocumentEntity(Int32)`
  * Method `GetDocumentLength(Int32, String)`
  * Method `GetDocumentList(Int32[])`
  * Method `GetDocumentProperties(Int32, String[])`
  * Method `GetDocumentsByTemplateHeading(Int32)`
  * Method `GetDocumentStream(Int32)`
  * Method `GetDocumentStreamFromEntity(DocumentEntity)`
  * Method `GetDocumentUrl(Int32, String, Boolean)`
  * Method `GetMyPublishedDocuments()`
  * Method `GetPersonDocuments(Int32)`
  * Method `GetPersonDocumentsByDate(Int32, Boolean, DateTime, DateTime, Int32)`
  * Method `GetPersonDocumentsByTemplateHeading(Int32, Boolean, DateTime, DateTime, Int32, Int32)`
  * Method `GetPersonDocumentsByTemplateType(Int32, Boolean, DateTime, DateTime, Int32, Int32)`
  * Method `GetPersonDocumentsByTemplateTypes(Int32, Boolean, DateTime, DateTime, Int32, Int32[])`
  * Method `GetPluginCapabilities(Int32)`
  * Method `GetPluginList()`
  * Method `GetPreviewDocumentStream(Int32)`
  * Method `GetProjectDocuments(Int32, DateTime, DateTime, Int32)`
  * Method `GetProjectDocumentsByTemplateHeading(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetProjectDocumentsByTemplateType(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetProjectDocumentsByTemplateTypes(Int32, DateTime, DateTime, Int32, Int32[])`
  * Method `GetProjectMemberDocuments(Int32, DateTime, DateTime, Int32)`
  * Method `GetProjectMemberDocumentsByTemplateHeading(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetProjectMemberDocumentsByTemplateType(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetProjectMemberDocumentsByTemplateTypes(Int32, DateTime, DateTime, Int32, Int32[])`
  * Method `GetPublishedDocument(Int32)`
  * Method `GetPublishedDocuments(Int32[])`
  * Method `GetPublishedDocumentsByDate(Int32, Boolean, DateTime, DateTime, Int32)`
  * Method `GetPublishedPersonDocumentsByDate(Int32, Boolean, DateTime, DateTime, Int32)`
  * Method `GetPublishedProjectDocuments(Int32)`
  * Method `GetSaleDocuments(Int32)`
  * Method `GetSanitizedDocumentStream(Int32)`
  * Method `GetSanitizedTemplateStream(String, Boolean, String)`
  * Method `GetSanitizedTemplateStreamFromId(Int32, String)`
  * Method `GetSuggestedDocumentEntity(Int32)`
  * Method `GetTempFile(String)`
  * Method `GetTemplateStream(String, Boolean, String)`
  * Method `GetTemplateStreamFromId(Int32, String)`
  * Method `GetUnsanitizedPreviewDocumentStream(Int32)`
  * Method `GetVersionList(Int32)`
  * Method `RenameDocument(Int32, String)`
  * Method `SaveDocumentEntity(DocumentEntity)`
  * Method `SaveDocumentTemplateStream(Int32, Stream, String, Int32)`
  * Method `SavePrivacyReport(String, String, Int32)`
  * Method `SavePrivacyReportPdf(Stream, String, Int32)`
  * Method `SaveSuggestedDocumentEntity(SuggestedDocumentEntity)`
  * Method `SetDocumentStream(DocumentEntity, Stream, Boolean)`
  * Method `SetDocumentStreamFromId(Int32, Stream)`
  * Method `SetTemplateStream(String, Boolean, Stream)`
  * Method `SubstituteMergeDocumentTemplateVariables(Int32, Int32, String[], String[])`
  * Method `SubstituteMergeDocumentTemplateVariables2(Int32, Int32, StringDictionary)`
  * Method `SubstituteMergeDocumentTemplateVariablesEx(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, String[], String[])`
  * Method `SubstituteMergeDocumentTemplateVariablesEx2(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, StringDictionary)`
  * Method `SubstituteTemplateVariables(String, GeneratorEncoding, Int32, Int32, Int32, Int32, Int32, Int32, Int32, String)`
  * Method `SubstituteTemplateVariablesEx(TemplateVariablesParameters)`
  * Method `SubstituteTemplateVariablesWithCustomTags(String, GeneratorEncoding, String[], String[], Int32, Int32, Int32, Int32, Int32, Int32, Int32, String)`
  * Method `SubstituteTemplateVariablesWithCustomTags2(String, GeneratorEncoding, StringDictionary, Int32, Int32, Int32, Int32, Int32, Int32, Int32, String)`
  * Method `UndoCheckoutDocument(Int32, String[])`
  * Method `ValidateDocumentEntity(DocumentEntity)`
  * Method `VerifyGetDocumentStream(Int32)`
* New items
  * Method `CheckinDocumentAsync(Int32, String[], String, String[], CancellationToken)`
  * Method `CheckoutDocumentAsync(Int32, String[], CancellationToken)`
  * Method `CopyDocumentToCsAttachmentAsync(Int32, CancellationToken)`
  * Method `CreateDefaultDocumentEntityAsync(CancellationToken)`
  * Method `CreateDefaultDocumentEntityFromSuggestionAsync(Int32, CancellationToken)`
  * Method `CreateDefaultDocumentPreviewAsync(CancellationToken)`
  * Method `CreateDefaultSuggestedDocumentEntityAsync(CancellationToken)`
  * Method `CreateDefaultTemplateVariablesParametersAsync(CancellationToken)`
  * Method `CreateDocumentStreamAsync(DocumentEntity, Boolean, CancellationToken)`
  * Method `CreateNewPhysicalDocumentFromTemplateAsync(Int32, Int32, Int32, Int32, Int32, Int32, Int32, String, CancellationToken)`
  * Method `CreateNewPhysicalDocumentFromTemplateWithCustomTags2Async(Int32, Int32, Int32, Int32, Int32, Int32, Int32, StringDictionary, String, CancellationToken)`
  * Method `CreateNewPhysicalDocumentFromTemplateWithCustomTagsAsync(Int32, Int32, Int32, Int32, Int32, Int32, Int32, String[], String[], String, CancellationToken)`
  * Method `CreateNewPhysicalMailMergeDocumentFromTemplateAsync(Int32, String, CancellationToken)`
  * Method `CreateTempFileAsync(String, Stream, CancellationToken)`
  * Method `DeleteDocumentEntityAsync(Int32, CancellationToken)`
  * Method `DeletePhysicalDocumentAsync(Int32, String[], CancellationToken)`
  * Method `DeleteTempFileAsync(String, CancellationToken)`
  * Method `ExecuteDocumentCommandAsync(Int32, String, String[], String, String[], CancellationToken)`
  * Method `GetAppointmentDocumentsAsync(Int32, CancellationToken)`
  * Method `GetCheckoutStateAsync(Int32, CancellationToken)`
  * Method `GetContactDocumentsAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetContactDocumentsByTemplateHeadingAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetContactDocumentsByTemplateTypeAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetContactDocumentsByTemplateTypesAsync(Int32, DateTime, DateTime, Int32, Int32[], CancellationToken)`
  * Method `GetDocumentAsync(Int32, CancellationToken)`
  * Method `GetDocumentCommandsAsync(Int32, String[], CancellationToken)`
  * Method `GetDocumentEntityAsync(Int32, CancellationToken)`
  * Method `GetDocumentLengthAsync(Int32, String, CancellationToken)`
  * Method `GetDocumentListAsync(Int32[], CancellationToken)`
  * Method `GetDocumentPropertiesAsync(Int32, String[], CancellationToken)`
  * Method `GetDocumentsByTemplateHeadingAsync(Int32, CancellationToken)`
  * Method `GetDocumentStreamAsync(Int32, CancellationToken)`
  * Method `GetDocumentStreamFromEntityAsync(DocumentEntity, CancellationToken)`
  * Method `GetDocumentUrlAsync(Int32, String, Boolean, CancellationToken)`
  * Method `GetMyPublishedDocumentsAsync(CancellationToken)`
  * Method `GetPersonDocumentsAsync(Int32, CancellationToken)`
  * Method `GetPersonDocumentsByDateAsync(Int32, Boolean, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetPersonDocumentsByTemplateHeadingAsync(Int32, Boolean, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetPersonDocumentsByTemplateTypeAsync(Int32, Boolean, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetPersonDocumentsByTemplateTypesAsync(Int32, Boolean, DateTime, DateTime, Int32, Int32[], CancellationToken)`
  * Method `GetPluginCapabilitiesAsync(Int32, CancellationToken)`
  * Method `GetPluginListAsync(CancellationToken)`
  * Method `GetPreviewDocumentStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectDocumentsAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetProjectDocumentsByTemplateHeadingAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetProjectDocumentsByTemplateTypeAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetProjectDocumentsByTemplateTypesAsync(Int32, DateTime, DateTime, Int32, Int32[], CancellationToken)`
  * Method `GetProjectMemberDocumentsAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetProjectMemberDocumentsByTemplateHeadingAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetProjectMemberDocumentsByTemplateTypeAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetProjectMemberDocumentsByTemplateTypesAsync(Int32, DateTime, DateTime, Int32, Int32[], CancellationToken)`
  * Method `GetPublishedDocumentAsync(Int32, CancellationToken)`
  * Method `GetPublishedDocumentsAsync(Int32[], CancellationToken)`
  * Method `GetPublishedDocumentsByDateAsync(Int32, Boolean, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetPublishedPersonDocumentsByDateAsync(Int32, Boolean, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetPublishedProjectDocumentsAsync(Int32, CancellationToken)`
  * Method `GetSaleDocumentsAsync(Int32, CancellationToken)`
  * Method `GetSanitizedDocumentStreamAsync(Int32, CancellationToken)`
  * Method `GetSanitizedTemplateStreamAsync(String, Boolean, String, CancellationToken)`
  * Method `GetSanitizedTemplateStreamFromIdAsync(Int32, String, CancellationToken)`
  * Method `GetSuggestedDocumentEntityAsync(Int32, CancellationToken)`
  * Method `GetTempFileAsync(String, CancellationToken)`
  * Method `GetTemplateStreamAsync(String, Boolean, String, CancellationToken)`
  * Method `GetTemplateStreamFromIdAsync(Int32, String, CancellationToken)`
  * Method `GetUnsanitizedPreviewDocumentStreamAsync(Int32, CancellationToken)`
  * Method `GetVersionListAsync(Int32, CancellationToken)`
  * Method `RenameDocumentAsync(Int32, String, CancellationToken)`
  * Method `SaveDocumentEntityAsync(DocumentEntity, CancellationToken)`
  * Method `SaveDocumentTemplateStreamAsync(Int32, Stream, String, Int32, CancellationToken)`
  * Method `SavePrivacyReportAsync(String, String, Int32, CancellationToken)`
  * Method `SavePrivacyReportPdfAsync(Stream, String, Int32, CancellationToken)`
  * Method `SaveSuggestedDocumentEntityAsync(SuggestedDocumentEntity, CancellationToken)`
  * Method `SetDocumentStreamAsync(DocumentEntity, Stream, Boolean, CancellationToken)`
  * Method `SetDocumentStreamFromIdAsync(Int32, Stream, CancellationToken)`
  * Method `SetTemplateStreamAsync(String, Boolean, Stream, CancellationToken)`
  * Method `SubstituteMergeDocumentTemplateVariables2Async(Int32, Int32, StringDictionary, CancellationToken)`
  * Method `SubstituteMergeDocumentTemplateVariablesAsync(Int32, Int32, String[], String[], CancellationToken)`
  * Method `SubstituteMergeDocumentTemplateVariablesEx2Async(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, StringDictionary, CancellationToken)`
  * Method `SubstituteMergeDocumentTemplateVariablesExAsync(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, String[], String[], CancellationToken)`
  * Method `SubstituteTemplateVariablesAsync(String, GeneratorEncoding, Int32, Int32, Int32, Int32, Int32, Int32, Int32, String, CancellationToken)`
  * Method `SubstituteTemplateVariablesExAsync(TemplateVariablesParameters, CancellationToken)`
  * Method `SubstituteTemplateVariablesWithCustomTags2Async(String, GeneratorEncoding, StringDictionary, Int32, Int32, Int32, Int32, Int32, Int32, Int32, String, CancellationToken)`
  * Method `SubstituteTemplateVariablesWithCustomTagsAsync(String, GeneratorEncoding, String[], String[], Int32, Int32, Int32, Int32, Int32, Int32, Int32, String, CancellationToken)`
  * Method `UndoCheckoutDocumentAsync(Int32, String[], CancellationToken)`
  * Method `ValidateDocumentEntityAsync(DocumentEntity, CancellationToken)`
  * Method `VerifyGetDocumentStreamAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.IDocumentMigrationAgent is Modified

* Deleted items
  * Method `CreateDefaultDocumentMigrationItemList()`
  * Method `CreateDefaultDocumentTemplateMigrationList()`
  * Method `GetForAllDocuments(Int32, Boolean)`
  * Method `GetForDateRange(Int32, DateTime, DateTime, Boolean)`
  * Method `GetForSelection(Int32, Int32, Boolean)`
  * Method `GetForTemplates(Int32, Boolean)`
  * Method `GetNumberOfConfidentialDocuments()`
  * Method `HasDocumentsToMigrate()`
  * Method `MigrateDocumentToNewDocPlugin(Int32, Int32)`
  * Method `MigrateTemplateToNewDocPlugin(Int32, Int32)`
* New items
  * Method `CreateDefaultDocumentMigrationItemListAsync(CancellationToken)`
  * Method `CreateDefaultDocumentTemplateMigrationListAsync(CancellationToken)`
  * Method `GetForAllDocumentsAsync(Int32, Boolean, CancellationToken)`
  * Method `GetForDateRangeAsync(Int32, DateTime, DateTime, Boolean, CancellationToken)`
  * Method `GetForSelectionAsync(Int32, Int32, Boolean, CancellationToken)`
  * Method `GetForTemplatesAsync(Int32, Boolean, CancellationToken)`
  * Method `GetNumberOfConfidentialDocumentsAsync(CancellationToken)`
  * Method `HasDocumentsToMigrateAsync(CancellationToken)`
  * Method `MigrateDocumentToNewDocPluginAsync(Int32, Int32, CancellationToken)`
  * Method `MigrateTemplateToNewDocPluginAsync(Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.IEMailAgent is Modified

* Deleted items
  * Method `Authenticate(EMailConnectionInfoExtended)`
  * Method `AuthenticateIncoming(EMailConnectionInfo)`
  * Method `AuthenticateOutgoing(EMailConnectionInfo)`
  * Method `CacheFolderList()`
  * Method `CreateDefaultEMailAccount()`
  * Method `CreateDefaultEMailAddress()`
  * Method `CreateDefaultEMailAppointment()`
  * Method `CreateDefaultEMailAttachment()`
  * Method `CreateDefaultEMailConnectionInfo()`
  * Method `CreateDefaultEMailConnectionInfoExtended()`
  * Method `CreateDefaultEMailCustomHeader()`
  * Method `CreateDefaultEMailEntity()`
  * Method `CreateDefaultEMailEnvelope()`
  * Method `CreateDefaultEMailFolder()`
  * Method `CreateDefaultEMailSOInfo()`
  * Method `CreateEMailFromDocumentEntity(DocumentEntity)`
  * Method `CreateEMailFromMimeMessage(String)`
  * Method `CreateFolder(EMailConnectionInfo)`
  * Method `CreateForwardEmail(EMailEntity)`
  * Method `CreateInlineHtmlHeader(EMailEntity)`
  * Method `CreateNewPhysicalDocumentFromEmail(Int32, Int32)`
  * Method `CreateNewPhysicalDocumentFromEmailAttachment(Int32, Int32, String)`
  * Method `Delete(EMailConnectionInfo, Int32[], String)`
  * Method `DeleteEMailAccount(Int32)`
  * Method `DeleteEmails(Int32[], String)`
  * Method `DeleteExtended(EMailConnectionInfoExtended, String[])`
  * Method `DeleteFolder(EMailConnectionInfo)`
  * Method `EmptyFolder(EMailConnectionInfo, String)`
  * Method `FindAddress(String)`
  * Method `FindContactOrPersonByEmailName(String, String)`
  * Method `FindContactOrPersonByEmailNameWithLimit(String, String, Int32, Int32)`
  * Method `GetAttachment(EMailConnectionInfo, Int32, String)`
  * Method `GetAttachmentFromId(Int32, String)`
  * Method `GetCurrentAccount()`
  * Method `GetCurrentAccountId()`
  * Method `GetEMail(Int32, Boolean)`
  * Method `GetEMailAccount(Int32)`
  * Method `GetEMailAccountFromEMailAddress(String)`
  * Method `GetEMailAddresses(Int32[])`
  * Method `GetEmailAppointment(Int32)`
  * Method `GetEmailAppointmentRecurrence(Int32)`
  * Method `GetEMailAsStream(EMailConnectionInfo, Int32, Boolean)`
  * Method `GetEmailDocumentAsMimeStream(Int32)`
  * Method `GetEMailEnvelopes(EMailConnectionInfo, Int32[])`
  * Method `GetEMailFromAttachmentId(Int32, String[], Boolean)`
  * Method `GetEMailFromDocumentAttachmentId(Int32, String[], Boolean)`
  * Method `GetEMailFromDocumentId(Int32)`
  * Method `GetEMailFromDocumentIdWithoutAttachmentStream(Int32)`
  * Method `GetEMailFromId(EMailConnectionInfo, Int32, Boolean, EMailFlags, Boolean)`
  * Method `GetEMailFromTemp(String)`
  * Method `GetEmailMessageIds(EMailConnectionInfoExtended)`
  * Method `GetEmailsAsString(EMailConnectionInfoExtended, String[])`
  * Method `GetEMailSOInfo(Int32)`
  * Method `GetExtendedEmailMessageIds(EMailConnectionInfoExtended)`
  * Method `GetFolderEMailCount(EMailConnectionInfo, Boolean)`
  * Method `GetFolderHasNewEMail(EMailConnectionInfo)`
  * Method `GetFolderInfo(EMailConnectionInfo, String[])`
  * Method `GetFolderList(EMailConnectionInfo, Boolean)`
  * Method `GetMailFromInReplyTo(String)`
  * Method `GetMailFromMessageId(String)`
  * Method `GetNewMail(Int32[])`
  * Method `GetParticipantInfoFromEmailAddress(String, Int32)`
  * Method `GetPersonEntitiesFromEmailAddress(String)`
  * Method `GetPersonsFromEmailAddress(String)`
  * Method `GetPreviewAttachmentFromDocId(Int32, String)`
  * Method `GetPreviewAttachmentFromId(Int32, String, String, String)`
  * Method `GetReadySyncEmailAccounts()`
  * Method `GetUnsanitizedEMail(Int32, Boolean)`
  * Method `GetUnsanitizedEMailFromAttachmentId(Int32, String[], Boolean)`
  * Method `GetUnsanitizedEMailFromDocumentAttachmentId(Int32, String[], Boolean)`
  * Method `GetUnsanitizedEMailFromDocumentId(Int32)`
  * Method `GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream(Int32)`
  * Method `GetUnsanitizedPreviewAttachmentFromDocId(Int32, String)`
  * Method `GetUnsanitizedPreviewAttachmentFromId(Int32, String, String, String)`
  * Method `HasMXRecord(String)`
  * Method `HasNewMail(Int32, Int32)`
  * Method `HasSPFRecord(String, String)`
  * Method `LatestItemIdByFolder(Int32)`
  * Method `MarkAsRead(EMailConnectionInfo, Int32[], Boolean)`
  * Method `MarkEmailsAsRead(Int32[], Boolean)`
  * Method `MoveEmailsToFolder(Int32, Int32[])`
  * Method `MoveEmailsToTrash(Int32[])`
  * Method `MoveToFolder(EMailConnectionInfo, Int32[], String)`
  * Method `RefreshFolder(EMailConnectionInfo, String[])`
  * Method `RefreshFolderForAssociate(String[])`
  * Method `RelayMessage(EMailConnectionInfoExtended, String, String, String[])`
  * Method `ResolveEMailRecipients(String)`
  * Method `Save(EMailEntity)`
  * Method `SaveDraft(EMailEntity)`
  * Method `SaveEMail(EMailConnectionInfo, EMailEntity)`
  * Method `SaveEMailAccount(EMailAccount)`
  * Method `SaveEmailToTmpDocument(EMailEntity, Int32, Boolean)`
  * Method `SaveToMailServer(EMailEntity)`
  * Method `Send(EMailEntity[])`
  * Method `SendAndSaveEmailToTmpDocument(EMailEntity, Boolean)`
  * Method `SendEMails(EMailConnectionInfo, EMailEntity[], EMailConnectionInfo)`
  * Method `SetRepliedAt(String)`
  * Method `SetSubscription(EMailConnectionInfo, EMailFolder[])`
  * Method `SyncEmailAccount(SyncUserAccount)`
  * Method `SyncEmailAccounts(SyncUserAccount[])`
  * Method `TestAuthenticate()`
  * Method `ToggleSubscription(Int32, Boolean)`
* New items
  * Method `AuthenticateAsync(EMailConnectionInfoExtended, CancellationToken)`
  * Method `AuthenticateIncomingAsync(EMailConnectionInfo, CancellationToken)`
  * Method `AuthenticateOutgoingAsync(EMailConnectionInfo, CancellationToken)`
  * Method `CacheFolderListAsync(CancellationToken)`
  * Method `CreateDefaultEMailAccountAsync(CancellationToken)`
  * Method `CreateDefaultEMailAddressAsync(CancellationToken)`
  * Method `CreateDefaultEMailAppointmentAsync(CancellationToken)`
  * Method `CreateDefaultEMailAttachmentAsync(CancellationToken)`
  * Method `CreateDefaultEMailConnectionInfoAsync(CancellationToken)`
  * Method `CreateDefaultEMailConnectionInfoExtendedAsync(CancellationToken)`
  * Method `CreateDefaultEMailCustomHeaderAsync(CancellationToken)`
  * Method `CreateDefaultEMailEntityAsync(CancellationToken)`
  * Method `CreateDefaultEMailEnvelopeAsync(CancellationToken)`
  * Method `CreateDefaultEMailFolderAsync(CancellationToken)`
  * Method `CreateDefaultEMailSOInfoAsync(CancellationToken)`
  * Method `CreateEMailFromDocumentEntityAsync(DocumentEntity, CancellationToken)`
  * Method `CreateEMailFromMimeMessageAsync(String, CancellationToken)`
  * Method `CreateFolderAsync(EMailConnectionInfo, CancellationToken)`
  * Method `CreateForwardEmailAsync(EMailEntity, CancellationToken)`
  * Method `CreateInlineHtmlHeaderAsync(EMailEntity, CancellationToken)`
  * Method `CreateNewPhysicalDocumentFromEmailAsync(Int32, Int32, CancellationToken)`
  * Method `CreateNewPhysicalDocumentFromEmailAttachmentAsync(Int32, Int32, String, CancellationToken)`
  * Method `DeleteAsync(EMailConnectionInfo, Int32[], String, CancellationToken)`
  * Method `DeleteEMailAccountAsync(Int32, CancellationToken)`
  * Method `DeleteEmailsAsync(Int32[], String, CancellationToken)`
  * Method `DeleteExtendedAsync(EMailConnectionInfoExtended, String[], CancellationToken)`
  * Method `DeleteFolderAsync(EMailConnectionInfo, CancellationToken)`
  * Method `EmptyFolderAsync(EMailConnectionInfo, String, CancellationToken)`
  * Method `FindAddressAsync(String, CancellationToken)`
  * Method `FindContactOrPersonByEmailNameAsync(String, String, CancellationToken)`
  * Method `FindContactOrPersonByEmailNameWithLimitAsync(String, String, Int32, Int32, CancellationToken)`
  * Method `GetAttachmentAsync(EMailConnectionInfo, Int32, String, CancellationToken)`
  * Method `GetAttachmentFromIdAsync(Int32, String, CancellationToken)`
  * Method `GetCurrentAccountAsync(CancellationToken)`
  * Method `GetCurrentAccountIdAsync(CancellationToken)`
  * Method `GetEMailAccountAsync(Int32, CancellationToken)`
  * Method `GetEMailAccountFromEMailAddressAsync(String, CancellationToken)`
  * Method `GetEMailAddressesAsync(Int32[], CancellationToken)`
  * Method `GetEmailAppointmentAsync(Int32, CancellationToken)`
  * Method `GetEmailAppointmentRecurrenceAsync(Int32, CancellationToken)`
  * Method `GetEMailAsStreamAsync(EMailConnectionInfo, Int32, Boolean, CancellationToken)`
  * Method `GetEMailAsync(Int32, Boolean, CancellationToken)`
  * Method `GetEmailDocumentAsMimeStreamAsync(Int32, CancellationToken)`
  * Method `GetEMailEnvelopesAsync(EMailConnectionInfo, Int32[], CancellationToken)`
  * Method `GetEMailFromAttachmentIdAsync(Int32, String[], Boolean, CancellationToken)`
  * Method `GetEMailFromDocumentAttachmentIdAsync(Int32, String[], Boolean, CancellationToken)`
  * Method `GetEMailFromDocumentIdAsync(Int32, CancellationToken)`
  * Method `GetEMailFromDocumentIdWithoutAttachmentStreamAsync(Int32, CancellationToken)`
  * Method `GetEMailFromIdAsync(EMailConnectionInfo, Int32, Boolean, EMailFlags, Boolean, CancellationToken)`
  * Method `GetEMailFromTempAsync(String, CancellationToken)`
  * Method `GetEmailMessageIdsAsync(EMailConnectionInfoExtended, CancellationToken)`
  * Method `GetEmailsAsStringAsync(EMailConnectionInfoExtended, String[], CancellationToken)`
  * Method `GetEMailSOInfoAsync(Int32, CancellationToken)`
  * Method `GetExtendedEmailMessageIdsAsync(EMailConnectionInfoExtended, CancellationToken)`
  * Method `GetFolderEMailCountAsync(EMailConnectionInfo, Boolean, CancellationToken)`
  * Method `GetFolderHasNewEMailAsync(EMailConnectionInfo, CancellationToken)`
  * Method `GetFolderInfoAsync(EMailConnectionInfo, String[], CancellationToken)`
  * Method `GetFolderListAsync(EMailConnectionInfo, Boolean, CancellationToken)`
  * Method `GetMailFromInReplyToAsync(String, CancellationToken)`
  * Method `GetMailFromMessageIdAsync(String, CancellationToken)`
  * Method `GetNewMailAsync(Int32[], CancellationToken)`
  * Method `GetParticipantInfoFromEmailAddressAsync(String, Int32, CancellationToken)`
  * Method `GetPersonEntitiesFromEmailAddressAsync(String, CancellationToken)`
  * Method `GetPersonsFromEmailAddressAsync(String, CancellationToken)`
  * Method `GetPreviewAttachmentFromDocIdAsync(Int32, String, CancellationToken)`
  * Method `GetPreviewAttachmentFromIdAsync(Int32, String, String, String, CancellationToken)`
  * Method `GetReadySyncEmailAccountsAsync(CancellationToken)`
  * Method `GetUnsanitizedEMailAsync(Int32, Boolean, CancellationToken)`
  * Method `GetUnsanitizedEMailFromAttachmentIdAsync(Int32, String[], Boolean, CancellationToken)`
  * Method `GetUnsanitizedEMailFromDocumentAttachmentIdAsync(Int32, String[], Boolean, CancellationToken)`
  * Method `GetUnsanitizedEMailFromDocumentIdAsync(Int32, CancellationToken)`
  * Method `GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamAsync(Int32, CancellationToken)`
  * Method `GetUnsanitizedPreviewAttachmentFromDocIdAsync(Int32, String, CancellationToken)`
  * Method `GetUnsanitizedPreviewAttachmentFromIdAsync(Int32, String, String, String, CancellationToken)`
  * Method `HasMXRecordAsync(String, CancellationToken)`
  * Method `HasNewMailAsync(Int32, Int32, CancellationToken)`
  * Method `HasSPFRecordAsync(String, String, CancellationToken)`
  * Method `LatestItemIdByFolderAsync(Int32, CancellationToken)`
  * Method `MarkAsReadAsync(EMailConnectionInfo, Int32[], Boolean, CancellationToken)`
  * Method `MarkEmailsAsReadAsync(Int32[], Boolean, CancellationToken)`
  * Method `MoveEmailsToFolderAsync(Int32, Int32[], CancellationToken)`
  * Method `MoveEmailsToTrashAsync(Int32[], CancellationToken)`
  * Method `MoveToFolderAsync(EMailConnectionInfo, Int32[], String, CancellationToken)`
  * Method `RefreshFolderAsync(EMailConnectionInfo, String[], CancellationToken)`
  * Method `RefreshFolderForAssociateAsync(String[], CancellationToken)`
  * Method `RelayMessageAsync(EMailConnectionInfoExtended, String, String, String[], CancellationToken)`
  * Method `ResolveEMailRecipientsAsync(String, CancellationToken)`
  * Method `SaveAsync(EMailEntity, CancellationToken)`
  * Method `SaveDraftAsync(EMailEntity, CancellationToken)`
  * Method `SaveEMailAccountAsync(EMailAccount, CancellationToken)`
  * Method `SaveEMailAsync(EMailConnectionInfo, EMailEntity, CancellationToken)`
  * Method `SaveEmailToTmpDocumentAsync(EMailEntity, Int32, Boolean, CancellationToken)`
  * Method `SaveToMailServerAsync(EMailEntity, CancellationToken)`
  * Method `SendAndSaveEmailToTmpDocumentAsync(EMailEntity, Boolean, CancellationToken)`
  * Method `SendAsync(EMailEntity[], CancellationToken)`
  * Method `SendEMailsAsync(EMailConnectionInfo, EMailEntity[], EMailConnectionInfo, CancellationToken)`
  * Method `SetRepliedAtAsync(String, CancellationToken)`
  * Method `SetSubscriptionAsync(EMailConnectionInfo, EMailFolder[], CancellationToken)`
  * Method `SyncEmailAccountAsync(SyncUserAccount, CancellationToken)`
  * Method `SyncEmailAccountsAsync(SyncUserAccount[], CancellationToken)`
  * Method `TestAuthenticateAsync(CancellationToken)`
  * Method `ToggleSubscriptionAsync(Int32, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.IErpSyncAgent is Modified

* Deleted items
  * Method `BreakActorLink(Int32, Int32, CrmActorType)`
  * Method `CanDeleteErpSyncConnectorEntity(Int32)`
  * Method `ChangeEngineInterval(TimeSpan)`
  * Method `ChangeEngineStatus(Boolean)`
  * Method `ConnectActor(Int32, Int32, CrmActorType, String, ErpActorType, ErpSyncFieldValue[])`
  * Method `CreateActorLink(Int32, Int32, CrmActorType, String, ErpActorType)`
  * Method `CreateDefaultErpSyncConnectorEntity()`
  * Method `CreateErpActorFromCrm(Int32, Int32, ErpActorType, CrmActorType, StringDictionary)`
  * Method `DeleteConnection(Int32)`
  * Method `DeleteErpSyncConnectorEntity(Int32)`
  * Method `ForceResync(Int32, Int32[])`
  * Method `ForceResyncBatchTask(Int32, Int32[])`
  * Method `ForceResyncExternal(Int32, ErpActorType, String[])`
  * Method `ForceResyncExternalNoBlankValues(Int32, ErpActorType, String[])`
  * Method `ForceResyncNoBlankValues(Int32, Int32[])`
  * Method `ForceSyncAll()`
  * Method `GetActorTypeMapping(Int32, ErpActorType)`
  * Method `GetAllConnections(Boolean)`
  * Method `GetAllConnectors()`
  * Method `GetConfigurationFields(Int32)`
  * Method `GetConnection(Int32)`
  * Method `GetConnectionListMappings(Int32)`
  * Method `GetConnectionsAndDisplayFields(CrmActorType, Int32)`
  * Method `GetCrmActorType(Int32, ErpActorType)`
  * Method `GetDefaultValueInfo(Int32)`
  * Method `GetEngineStatus()`
  * Method `GetErpConnectionConfigFields(Int32)`
  * Method `GetErpFieldValues(Int32, CrmActorType, Int32, String[])`
  * Method `GetErpSyncConnectionSummary(Int32)`
  * Method `GetErpSyncConnectorEntity(Int32)`
  * Method `GetFieldsForNewErpActor(Int32, ErpActorType)`
  * Method `GetFieldValuesFromCrm(Int32, CrmActorType)`
  * Method `GetFieldValuesFromErp(Int32, ErpActorType, String)`
  * Method `MoveErpFieldItem(Int32, Int32, Int32, ErpActorType)`
  * Method `SaveActorTypeMapping(ErpSyncActorTypeMapping)`
  * Method `SaveConnection(ErpConnection)`
  * Method `SaveConnectionListMappings(ErpConnectionListMappingContainer)`
  * Method `SaveDefaultValueInfo(ErpSyncDefaultValue)`
  * Method `SaveErpConnectionSyncPriorities(Int32[])`
  * Method `SaveErpSyncConnectorEntity(ErpSyncConnectorEntity)`
  * Method `SupportsAdvancedSearch(Int32, ErpActorType)`
  * Method `SyncAll()`
  * Method `TestConnectionByConfig(Int32, StringDictionary)`
  * Method `TestConnectionById(Int32)`
  * Method `TestConnectorUrl(String)`
  * Method `ToggleErpConnectionActive(Int32)`
  * Method `TryConnectActor(Int32, Int32, CrmActorType, String, ErpActorType, ErpSyncFieldValue[])`
  * Method `UpdateConnectionFields(Int32)`
  * Method `ValidateArchiveColumnConfig(String, Int32)`
* New items
  * Method `BreakActorLinkAsync(Int32, Int32, CrmActorType, CancellationToken)`
  * Method `CanDeleteErpSyncConnectorEntityAsync(Int32, CancellationToken)`
  * Method `ChangeEngineIntervalAsync(TimeSpan, CancellationToken)`
  * Method `ChangeEngineStatusAsync(Boolean, CancellationToken)`
  * Method `ConnectActorAsync(Int32, Int32, CrmActorType, String, ErpActorType, ErpSyncFieldValue[], CancellationToken)`
  * Method `CreateActorLinkAsync(Int32, Int32, CrmActorType, String, ErpActorType, CancellationToken)`
  * Method `CreateDefaultErpSyncConnectorEntityAsync(CancellationToken)`
  * Method `CreateErpActorFromCrmAsync(Int32, Int32, ErpActorType, CrmActorType, StringDictionary, CancellationToken)`
  * Method `DeleteConnectionAsync(Int32, CancellationToken)`
  * Method `DeleteErpSyncConnectorEntityAsync(Int32, CancellationToken)`
  * Method `ForceResyncAsync(Int32, Int32[], CancellationToken)`
  * Method `ForceResyncBatchTaskAsync(Int32, Int32[], CancellationToken)`
  * Method `ForceResyncExternalAsync(Int32, ErpActorType, String[], CancellationToken)`
  * Method `ForceResyncExternalNoBlankValuesAsync(Int32, ErpActorType, String[], CancellationToken)`
  * Method `ForceResyncNoBlankValuesAsync(Int32, Int32[], CancellationToken)`
  * Method `ForceSyncAllAsync(CancellationToken)`
  * Method `GetActorTypeMappingAsync(Int32, ErpActorType, CancellationToken)`
  * Method `GetAllConnectionsAsync(Boolean, CancellationToken)`
  * Method `GetAllConnectorsAsync(CancellationToken)`
  * Method `GetConfigurationFieldsAsync(Int32, CancellationToken)`
  * Method `GetConnectionAsync(Int32, CancellationToken)`
  * Method `GetConnectionListMappingsAsync(Int32, CancellationToken)`
  * Method `GetConnectionsAndDisplayFieldsAsync(CrmActorType, Int32, CancellationToken)`
  * Method `GetCrmActorTypeAsync(Int32, ErpActorType, CancellationToken)`
  * Method `GetDefaultValueInfoAsync(Int32, CancellationToken)`
  * Method `GetEngineStatusAsync(CancellationToken)`
  * Method `GetErpConnectionConfigFieldsAsync(Int32, CancellationToken)`
  * Method `GetErpFieldValuesAsync(Int32, CrmActorType, Int32, String[], CancellationToken)`
  * Method `GetErpSyncConnectionSummaryAsync(Int32, CancellationToken)`
  * Method `GetErpSyncConnectorEntityAsync(Int32, CancellationToken)`
  * Method `GetFieldsForNewErpActorAsync(Int32, ErpActorType, CancellationToken)`
  * Method `GetFieldValuesFromCrmAsync(Int32, CrmActorType, CancellationToken)`
  * Method `GetFieldValuesFromErpAsync(Int32, ErpActorType, String, CancellationToken)`
  * Method `MoveErpFieldItemAsync(Int32, Int32, Int32, ErpActorType, CancellationToken)`
  * Method `SaveActorTypeMappingAsync(ErpSyncActorTypeMapping, CancellationToken)`
  * Method `SaveConnectionAsync(ErpConnection, CancellationToken)`
  * Method `SaveConnectionListMappingsAsync(ErpConnectionListMappingContainer, CancellationToken)`
  * Method `SaveDefaultValueInfoAsync(ErpSyncDefaultValue, CancellationToken)`
  * Method `SaveErpConnectionSyncPrioritiesAsync(Int32[], CancellationToken)`
  * Method `SaveErpSyncConnectorEntityAsync(ErpSyncConnectorEntity, CancellationToken)`
  * Method `SupportsAdvancedSearchAsync(Int32, ErpActorType, CancellationToken)`
  * Method `SyncAllAsync(CancellationToken)`
  * Method `TestConnectionByConfigAsync(Int32, StringDictionary, CancellationToken)`
  * Method `TestConnectionByIdAsync(Int32, CancellationToken)`
  * Method `TestConnectorUrlAsync(String, CancellationToken)`
  * Method `ToggleErpConnectionActiveAsync(Int32, CancellationToken)`
  * Method `TryConnectActorAsync(Int32, Int32, CrmActorType, String, ErpActorType, ErpSyncFieldValue[], CancellationToken)`
  * Method `UpdateConnectionFieldsAsync(Int32, CancellationToken)`
  * Method `ValidateArchiveColumnConfigAsync(String, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.IFavouriteAgent is Modified

* Deleted items
  * Method `AddFavourite(String, Int32, Int32, String)`
  * Method `AddFavourites(String, Int32[], Int32, String)`
  * Method `AddTicketsToFavouritesByProvider(String, ArchiveRestrictionInfo[], Int32, String)`
  * Method `GetFavourites(String, Int32)`
  * Method `IsFavourite(String, Int32, Int32)`
  * Method `RemoveAllFavourites(String, Int32)`
  * Method `RemoveFavourite(String, Int32, Int32)`
  * Method `RemoveFavourites(String, Int32[], Int32)`
  * Method `RemoveFavouritesById(Int32[])`
  * Method `RemoveTicketsFromFavouritesByProvider(String, ArchiveRestrictionInfo[], Int32)`
  * Method `ToggleFavourite(String, Int32, Int32, String)`
* New items
  * Method `AddFavouriteAsync(String, Int32, Int32, String, CancellationToken)`
  * Method `AddFavouritesAsync(String, Int32[], Int32, String, CancellationToken)`
  * Method `AddTicketsToFavouritesByProviderAsync(String, ArchiveRestrictionInfo[], Int32, String, CancellationToken)`
  * Method `GetFavouritesAsync(String, Int32, CancellationToken)`
  * Method `IsFavouriteAsync(String, Int32, Int32, CancellationToken)`
  * Method `RemoveAllFavouritesAsync(String, Int32, CancellationToken)`
  * Method `RemoveFavouriteAsync(String, Int32, Int32, CancellationToken)`
  * Method `RemoveFavouritesAsync(String, Int32[], Int32, CancellationToken)`
  * Method `RemoveFavouritesByIdAsync(Int32[], CancellationToken)`
  * Method `RemoveTicketsFromFavouritesByProviderAsync(String, ArchiveRestrictionInfo[], Int32, CancellationToken)`
  * Method `ToggleFavouriteAsync(String, Int32, Int32, String, CancellationToken)`

#### SuperOffice.CRM.Services.IFindAgent is Modified

* Deleted items
  * Method `CreateRestrictionGroup(String, String, String, String)`
  * Method `DeleteRestrictionGroup(String, String, String, Int32, String)`
  * Method `Find(String, String, String, Int32, Int32)`
  * Method `FindFromRestrictions(ArchiveRestrictionInfo[], String, Int32, Int32)`
  * Method `FindFromRestrictions2(String, String, Int32, Int32)`
  * Method `FindFromRestrictionsColumns(ArchiveRestrictionInfo[], String, String[], Int32, Int32)`
  * Method `FindFromRestrictionsColumns2(String, String, String, Int32, Int32)`
  * Method `FindFromRestrictionsColumnsOrderBy(ArchiveRestrictionInfo[], String, String[], ArchiveOrderByInfo[], Int32, Int32)`
  * Method `FindFromRestrictionsColumnsOrderBy2(String, String, String, String, Int32, Int32)`
  * Method `FindOrderBy(String, String, String, Int32, Int32, ArchiveOrderByInfo[])`
  * Method `FindOrderBy2(String, String, String, Int32, Int32, String)`
  * Method `FindWithColumns(String, String, String, String[], Int32, Int32, ArchiveOrderByInfo[])`
  * Method `FindWithExtraRestrictions(String, String, String, ArchiveRestrictionInfo[], ArchiveOrderByInfo[], String[], Int32, Int32)`
  * Method `FindWithExtraRestrictions2(String, String, String, String, String, String, Int32, Int32)`
  * Method `GetAvailableRestrictionColumns(String, String)`
  * Method `GetCriteriaInformation(String, String, String, String[])`
  * Method `GetCriteriaInformationWithContext(String, String, String, String[], String)`
  * Method `GetDefaultDesiredColumns(String, String, String)`
  * Method `GetDefaultDesiredColumnsFromRestrictions(String, ArchiveRestrictionInfo[])`
  * Method `GetDefaultDesiredColumnsFromRestrictions2(String, String)`
  * Method `GetDefaultOrderBy(String, String, String)`
  * Method `GetDefaultOrderByFromDesiredColumns(String, String[])`
  * Method `GetRestrictionGroup(String, String, String, Int32, String)`
  * Method `GetRestrictionGroups(String, String, String, String)`
  * Method `GetSpecifiedCriteriaInformationWithDefaults(String, String, String, String[], String[])`
  * Method `GetSpecifiedCriteriaInformationWithDefaultsWithContext(String, String, String, String[], String[], String)`
  * Method `PopulateRestrictions(String, ArchiveRestrictionInfo[])`
  * Method `PopulateRestrictionValues(ArchiveRestrictionInfo[])`
  * Method `SaveRestrictionGroup(String, String, String, ArchiveRestrictionGroup, String)`
  * Method `SaveRestrictionGroups(String, String, String, ArchiveRestrictionGroup[], String)`
  * Method `SaveRestrictions(String, String, String, ArchiveRestrictionInfo[])`
  * Method `SaveRestrictions2(String, String, String, String)`
  * Method `SaveRestrictionsAndGetCriteriaInformation(String, String, String, ArchiveRestrictionInfo[], String[])`
  * Method `SaveRestrictionsAndGetCriteriaInformation2(String, String, String, String, String)`
  * Method `SaveRestrictionsWithContext(String, String, String, ArchiveRestrictionInfo[], String)`
  * Method `SaveRestrictionsWithContext2(String, String, String, String, String)`
* New items
  * Method `CreateRestrictionGroupAsync(String, String, String, String, CancellationToken)`
  * Method `DeleteRestrictionGroupAsync(String, String, String, Int32, String, CancellationToken)`
  * Method `FindAsync(String, String, String, Int32, Int32, CancellationToken)`
  * Method `FindFromRestrictions2Async(String, String, Int32, Int32, CancellationToken)`
  * Method `FindFromRestrictionsAsync(ArchiveRestrictionInfo[], String, Int32, Int32, CancellationToken)`
  * Method `FindFromRestrictionsColumns2Async(String, String, String, Int32, Int32, CancellationToken)`
  * Method `FindFromRestrictionsColumnsAsync(ArchiveRestrictionInfo[], String, String[], Int32, Int32, CancellationToken)`
  * Method `FindFromRestrictionsColumnsOrderBy2Async(String, String, String, String, Int32, Int32, CancellationToken)`
  * Method `FindFromRestrictionsColumnsOrderByAsync(ArchiveRestrictionInfo[], String, String[], ArchiveOrderByInfo[], Int32, Int32, CancellationToken)`
  * Method `FindOrderBy2Async(String, String, String, Int32, Int32, String, CancellationToken)`
  * Method `FindOrderByAsync(String, String, String, Int32, Int32, ArchiveOrderByInfo[], CancellationToken)`
  * Method `FindWithColumnsAsync(String, String, String, String[], Int32, Int32, ArchiveOrderByInfo[], CancellationToken)`
  * Method `FindWithExtraRestrictions2Async(String, String, String, String, String, String, Int32, Int32, CancellationToken)`
  * Method `FindWithExtraRestrictionsAsync(String, String, String, ArchiveRestrictionInfo[], ArchiveOrderByInfo[], String[], Int32, Int32, CancellationToken)`
  * Method `GetAvailableRestrictionColumnsAsync(String, String, CancellationToken)`
  * Method `GetCriteriaInformationAsync(String, String, String, String[], CancellationToken)`
  * Method `GetCriteriaInformationWithContextAsync(String, String, String, String[], String, CancellationToken)`
  * Method `GetDefaultDesiredColumnsAsync(String, String, String, CancellationToken)`
  * Method `GetDefaultDesiredColumnsFromRestrictions2Async(String, String, CancellationToken)`
  * Method `GetDefaultDesiredColumnsFromRestrictionsAsync(String, ArchiveRestrictionInfo[], CancellationToken)`
  * Method `GetDefaultOrderByAsync(String, String, String, CancellationToken)`
  * Method `GetDefaultOrderByFromDesiredColumnsAsync(String, String[], CancellationToken)`
  * Method `GetRestrictionGroupAsync(String, String, String, Int32, String, CancellationToken)`
  * Method `GetRestrictionGroupsAsync(String, String, String, String, CancellationToken)`
  * Method `GetSpecifiedCriteriaInformationWithDefaultsAsync(String, String, String, String[], String[], CancellationToken)`
  * Method `GetSpecifiedCriteriaInformationWithDefaultsWithContextAsync(String, String, String, String[], String[], String, CancellationToken)`
  * Method `PopulateRestrictionsAsync(String, ArchiveRestrictionInfo[], CancellationToken)`
  * Method `PopulateRestrictionValuesAsync(ArchiveRestrictionInfo[], CancellationToken)`
  * Method `SaveRestrictionGroupAsync(String, String, String, ArchiveRestrictionGroup, String, CancellationToken)`
  * Method `SaveRestrictionGroupsAsync(String, String, String, ArchiveRestrictionGroup[], String, CancellationToken)`
  * Method `SaveRestrictions2Async(String, String, String, String, CancellationToken)`
  * Method `SaveRestrictionsAndGetCriteriaInformation2Async(String, String, String, String, String, CancellationToken)`
  * Method `SaveRestrictionsAndGetCriteriaInformationAsync(String, String, String, ArchiveRestrictionInfo[], String[], CancellationToken)`
  * Method `SaveRestrictionsAsync(String, String, String, ArchiveRestrictionInfo[], CancellationToken)`
  * Method `SaveRestrictionsWithContext2Async(String, String, String, String, String, CancellationToken)`
  * Method `SaveRestrictionsWithContextAsync(String, String, String, ArchiveRestrictionInfo[], String, CancellationToken)`

#### SuperOffice.CRM.Services.IForeignSystemAgent is Modified

* Deleted items
  * Method `AddDeviceByIdentifier(String, String, String)`
  * Method `AddForeignKey(ForeignKey, String, String, String)`
  * Method `CreateDefaultForeignAppEntity()`
  * Method `DeleteDeviceByIdentifier(String, String, String)`
  * Method `DeleteForeignAppEntity(Int32)`
  * Method `DeleteForeignDevice(ForeignDevice, String)`
  * Method `DeleteForeignKey(ForeignKey, String, String, String, String, Int32)`
  * Method `DeleteForeignKeyOnName(String, String, String, String, String, Int32)`
  * Method `GetAllForeignKeysOnEntity(String, Int32)`
  * Method `GetAppByName(String)`
  * Method `GetApplicationDevices(String)`
  * Method `GetApplicationKeys(String)`
  * Method `GetDeviceByIdentifier(String, String, String)`
  * Method `GetDeviceByName(String, String)`
  * Method `GetDeviceKeys(String, String)`
  * Method `GetDeviceKeysOnDeviceIdentifier(String, String, String)`
  * Method `GetDeviceKeysOnDeviceIdentifierTable(String, String, String, String)`
  * Method `GetDeviceKeysOnDeviceIdentifierTableRecordId(String, String, String, String, Int32)`
  * Method `GetForeignAppEntity(Int32)`
  * Method `GetForeignDevice(Int32)`
  * Method `GetKey(String, String, String, String, Int32)`
  * Method `GetKeyByValue(String, String, String, String, String)`
  * Method `GetKeyByValueAndIdentifier(String, String, String, String, String, String)`
  * Method `GetKeyOnDeviceIdentifier(String, String, String, String, String, Int32)`
  * Method `GetKeyValue(String, String, String, String, Int32)`
  * Method `GetKeyValueOnDeviceIdentifier(String, String, String, String, String, Int32)`
  * Method `SaveDeviceByIdentifier(String, String, String, ForeignDevice)`
  * Method `SaveForeignAppEntity(ForeignAppEntity)`
  * Method `SaveForeignDevice(ForeignDevice, String)`
  * Method `SaveForeignKey(ForeignKey, String, String, String)`
* New items
  * Method `AddDeviceByIdentifierAsync(String, String, String, CancellationToken)`
  * Method `AddForeignKeyAsync(ForeignKey, String, String, String, CancellationToken)`
  * Method `CreateDefaultForeignAppEntityAsync(CancellationToken)`
  * Method `DeleteDeviceByIdentifierAsync(String, String, String, CancellationToken)`
  * Method `DeleteForeignAppEntityAsync(Int32, CancellationToken)`
  * Method `DeleteForeignDeviceAsync(ForeignDevice, String, CancellationToken)`
  * Method `DeleteForeignKeyAsync(ForeignKey, String, String, String, String, Int32, CancellationToken)`
  * Method `DeleteForeignKeyOnNameAsync(String, String, String, String, String, Int32, CancellationToken)`
  * Method `GetAllForeignKeysOnEntityAsync(String, Int32, CancellationToken)`
  * Method `GetAppByNameAsync(String, CancellationToken)`
  * Method `GetApplicationDevicesAsync(String, CancellationToken)`
  * Method `GetApplicationKeysAsync(String, CancellationToken)`
  * Method `GetDeviceByIdentifierAsync(String, String, String, CancellationToken)`
  * Method `GetDeviceByNameAsync(String, String, CancellationToken)`
  * Method `GetDeviceKeysAsync(String, String, CancellationToken)`
  * Method `GetDeviceKeysOnDeviceIdentifierAsync(String, String, String, CancellationToken)`
  * Method `GetDeviceKeysOnDeviceIdentifierTableAsync(String, String, String, String, CancellationToken)`
  * Method `GetDeviceKeysOnDeviceIdentifierTableRecordIdAsync(String, String, String, String, Int32, CancellationToken)`
  * Method `GetForeignAppEntityAsync(Int32, CancellationToken)`
  * Method `GetForeignDeviceAsync(Int32, CancellationToken)`
  * Method `GetKeyAsync(String, String, String, String, Int32, CancellationToken)`
  * Method `GetKeyByValueAndIdentifierAsync(String, String, String, String, String, String, CancellationToken)`
  * Method `GetKeyByValueAsync(String, String, String, String, String, CancellationToken)`
  * Method `GetKeyOnDeviceIdentifierAsync(String, String, String, String, String, Int32, CancellationToken)`
  * Method `GetKeyValueAsync(String, String, String, String, Int32, CancellationToken)`
  * Method `GetKeyValueOnDeviceIdentifierAsync(String, String, String, String, String, Int32, CancellationToken)`
  * Method `SaveDeviceByIdentifierAsync(String, String, String, ForeignDevice, CancellationToken)`
  * Method `SaveForeignAppEntityAsync(ForeignAppEntity, CancellationToken)`
  * Method `SaveForeignDeviceAsync(ForeignDevice, String, CancellationToken)`
  * Method `SaveForeignKeyAsync(ForeignKey, String, String, String, CancellationToken)`

#### SuperOffice.CRM.Services.IFreeTextAgent is Modified

* Deleted items
  * Method `AddWords(String)`
  * Method `DeleteStopWordsById(Int32[])`
  * Method `FreetextIndexRows(String, Int32[])`
  * Method `GetStatus()`
  * Method `GetStopWordList()`
  * Method `GetSuggestedStopWords(Int32)`
  * Method `RegenerateIndex(Boolean)`
  * Method `SetAutoEnableTravelAreas(Boolean)`
  * Method `SetEnabled(Boolean)`
  * Method `SetMultiWordOperator(FreeTextOperator)`
  * Method `SetSingleWordOperator(FreeTextOperator)`
* New items
  * Method `FreetextIndexRowsAsync(String, Int32[], CancellationToken)`
  * Method `GetStatusAsync(CancellationToken)`
  * Method `RegenerateIndexAsync(Boolean, CancellationToken)`
  * Method `SetEnabledAsync(Boolean, CancellationToken)`
  * Method `SetMultiWordOperatorAsync(FreeTextOperator, CancellationToken)`
  * Method `SetSingleWordOperatorAsync(FreeTextOperator, CancellationToken)`

#### SuperOffice.CRM.Services.IImportAgent is Modified

* Deleted items
  * Method `CreateDefaultImportLine(Int32)`
  * Method `CreateErpImportData(ArchiveRestrictionInfo[], String[], Int32, ErpActorType)`
  * Method `PreviewImport(ImportLine[], String[], String, String)`
  * Method `SaveImport(ImportLine[], String[], Boolean, String, String)`
* New items
  * Method `CreateDefaultImportLineAsync(Int32, CancellationToken)`
  * Method `CreateErpImportDataAsync(ArchiveRestrictionInfo[], String[], Int32, ErpActorType, CancellationToken)`
  * Method `PreviewImportAsync(ImportLine[], String[], String, String, CancellationToken)`
  * Method `SaveImportAsync(ImportLine[], String[], Boolean, String, String, CancellationToken)`

#### SuperOffice.CRM.Services.ILicenseAgent is Modified

* Deleted items
  * Method `ActivateLicenseInfo(ExtendedLicenseInfo)`
  * Method `AddLicenseFromFile(String)`
  * Method `AssignThirdPartyLicenses(Int32, String, String[])`
  * Method `ChangeSerialNumber(String, String)`
  * Method `GetLicenseForAllOwnersFromDB()`
  * Method `GetLicenseFromDB(String)`
  * Method `GetLicenseFromFile(String)`
  * Method `GetLicenseFromLicenseServer(String)`
  * Method `GetLicenseStatusFromLicenseServer(String)`
  * Method `GetModuleLicenseFromDB(String, String)`
  * Method `GetModuleLicenseHistoryFromLicenseServer(ExtendedLicenseInfo, ExtendedModuleLicense)`
  * Method `GetSatelliteLicenses(Int32)`
  * Method `GetShopUrl(String)`
  * Method `GetThirdPartyLicenseAssignments(Int32, String)`
  * Method `GetUserAndInstallationLicenceStatus(Int32)`
  * Method `GetUserLicenses(Int32)`
  * Method `GetUserLicensesMDOList()`
  * Method `RemoveLicenseFromDB(String)`
  * Method `UnassignThirdPartyLicenses(Int32, String, String[])`
  * Method `ValidateLicenseInfo(ExtendedLicenseInfo)`
* New items
  * Method `ActivateLicenseInfoAsync(ExtendedLicenseInfo, CancellationToken)`
  * Method `AddLicenseFromFileAsync(String, CancellationToken)`
  * Method `AssignThirdPartyLicensesAsync(Int32, String, String[], CancellationToken)`
  * Method `ChangeSerialNumberAsync(String, String, CancellationToken)`
  * Method `GetCentralLicenseAsync(CancellationToken)`
  * Method `GetLicenseForAllOwnersFromDBAsync(CancellationToken)`
  * Method `GetLicenseFromDBAsync(String, CancellationToken)`
  * Method `GetLicenseFromFileAsync(String, CancellationToken)`
  * Method `GetLicenseFromLicenseServerAsync(String, CancellationToken)`
  * Method `GetLicenseStatusFromLicenseServerAsync(String, CancellationToken)`
  * Method `GetModuleLicenseFromDBAsync(String, String, CancellationToken)`
  * Method `GetModuleLicenseHistoryFromLicenseServerAsync(ExtendedLicenseInfo, ExtendedModuleLicense, CancellationToken)`
  * Method `GetSatelliteLicensesAsync(Int32, CancellationToken)`
  * Method `GetShopUrlAsync(String, CancellationToken)`
  * Method `GetThirdPartyLicenseAssignmentsAsync(Int32, String, CancellationToken)`
  * Method `GetUserAndInstallationLicenceStatusAsync(Int32, CancellationToken)`
  * Method `GetUserLicensesAsync(Int32, CancellationToken)`
  * Method `GetUserLicensesMDOListAsync(CancellationToken)`
  * Method `RemoveLicenseFromDBAsync(String, CancellationToken)`
  * Method `SaveCentralLicenseAsync(LicenseOwner[], CancellationToken)`
  * Method `UnassignThirdPartyLicensesAsync(Int32, String, String[], CancellationToken)`
  * Method `ValidateLicenseInfoAsync(ExtendedLicenseInfo, CancellationToken)`

#### SuperOffice.CRM.Services.IListAgent is Modified

* Deleted items
  * Method `AddFromListDefinition(Int32, ListItemEntity)`
  * Method `AddFromListName(String, ListItemEntity)`
  * Method `AddHierarchyToPath(Domain, String, String)`
  * Method `ChangeCurrency(Double, String, String)`
  * Method `CreateDefaultAmountClassEntity()`
  * Method `CreateDefaultCountry()`
  * Method `CreateDefaultCurrencyEntity()`
  * Method `CreateDefaultDocumentTemplateEntity()`
  * Method `CreateDefaultDocumentTemplateLanguage(Int32, String)`
  * Method `CreateDefaultExtAppEntity()`
  * Method `CreateDefaultHeadingEntity()`
  * Method `CreateDefaultHeadingFromListDefinition(Int32)`
  * Method `CreateDefaultHierarchyEntity()`
  * Method `CreateDefaultListEntity()`
  * Method `CreateDefaultListItemEntity()`
  * Method `CreateDefaultProjectTypeEntity()`
  * Method `CreateDefaultRelationDefinitionEntity()`
  * Method `CreateDefaultResourceEntity()`
  * Method `CreateDefaultSaleStageEntity()`
  * Method `CreateDefaultSaleTypeEntity()`
  * Method `CreateDefaultTaskMenu()`
  * Method `CreateDefaultTicketCategoryEntity()`
  * Method `CreateDefaultTicketPriorityEntity()`
  * Method `CreateDefaultTicketStatusEntity()`
  * Method `CreateDefaultTicketTypeEntity()`
  * Method `CreateDefaultWebPanelEntity()`
  * Method `DeleteAllFromListDefinition(Int32)`
  * Method `DeleteAllFromListName(String)`
  * Method `DeleteAllHeadingsFromListDefinition(Int32)`
  * Method `DeleteAllHeadingsFromName(String)`
  * Method `DeleteAppTaskMenus()`
  * Method `DeleteAppWebPanels()`
  * Method `DeleteDocumentTemplateLanguage(Int32, String)`
  * Method `DeleteFromListDefinition(Int32, Int32)`
  * Method `DeleteFromListName(Int32, String)`
  * Method `DeleteHierarchyEntity(Int32)`
  * Method `DeleteHierarchyFromPath(Domain, String)`
  * Method `DeleteListEntity(Int32)`
  * Method `DeleteListEntityByName(String)`
  * Method `DeleteProjectStatus(Int32)`
  * Method `DeleteResourceEntity(Int32)`
  * Method `DeleteTaskMenu(Int32)`
  * Method `DeleteTicketCategoryEntity(Int32)`
  * Method `DeleteTicketPriorityEntity(Int32)`
  * Method `DeleteTicketStatusEntity(Int32)`
  * Method `DeleteTicketTypeEntity(Int32)`
  * Method `DeleteWebPanel(Int32)`
  * Method `GenerateNavigationUrl(Navigation, String)`
  * Method `GetAllConsentSource()`
  * Method `GetAllCountries(Boolean)`
  * Method `GetAllCurrencies(Boolean)`
  * Method `GetAllDocumentTemplates(Boolean)`
  * Method `GetAllDomains()`
  * Method `GetAllFromListDefinition(Int32, Boolean)`
  * Method `GetAllFromListName(String, Boolean)`
  * Method `GetAllInDomain(Domain, Boolean)`
  * Method `GetAllLegalBase()`
  * Method `GetAllReasonSold()`
  * Method `GetAllReasonStalled()`
  * Method `GetAllSaleStages(Boolean)`
  * Method `GetAllSaleType()`
  * Method `GetAllSaleTypeEntities(Boolean)`
  * Method `GetAllSelectionCategory()`
  * Method `GetAllTasks(Boolean)`
  * Method `GetAllTicketPriorities(Boolean)`
  * Method `GetAmountClassEntity(Int32)`
  * Method `GetAppTaskMenus()`
  * Method `GetAppWebPanels()`
  * Method `GetBaseCurrency()`
  * Method `GetBusiness(Int32)`
  * Method `GetBusinesses()`
  * Method `GetBusinessList(Int32[])`
  * Method `GetCategories()`
  * Method `GetCategory(Int32)`
  * Method `GetCategoryList(Int32[])`
  * Method `GetCompetitor(Int32)`
  * Method `GetCompetitorList(Int32[])`
  * Method `GetCompetitors()`
  * Method `GetConsentPurpose(Int32)`
  * Method `GetConsentPurposeList(Int32[])`
  * Method `GetConsentPurposes()`
  * Method `GetConsentSource(Int32)`
  * Method `GetConsentSourceList(Int32[])`
  * Method `GetConsentSources()`
  * Method `GetCountries()`
  * Method `GetCountry(Int32)`
  * Method `GetCountryList(Int32[])`
  * Method `GetCredited(Int32)`
  * Method `GetCreditedList(Int32[])`
  * Method `GetCrediteds()`
  * Method `GetCurrencies()`
  * Method `GetCurrency(Int32)`
  * Method `GetCurrencyEntity(Int32)`
  * Method `GetCurrencyList(Int32[])`
  * Method `GetCustomerLanguage(Int32)`
  * Method `GetCustomerLanguageList(Int32[])`
  * Method `GetCustomerLanguages()`
  * Method `GetDeliveryTerm(Int32)`
  * Method `GetDeliveryTerms()`
  * Method `GetDeliveryType(Int32)`
  * Method `GetDeliveryTypes()`
  * Method `GetDepartment(Int32)`
  * Method `GetDepartmentList(Int32[])`
  * Method `GetDepartments()`
  * Method `GetDocumentTemplate(Int32)`
  * Method `GetDocumentTemplateEntity(Int32)`
  * Method `GetDocumentTemplateExtension(Int32)`
  * Method `GetDocumentTemplateLanguages(Int32)`
  * Method `GetDocumentTemplateList(Int32[])`
  * Method `GetDocumentTemplateProperties(Int32, String[])`
  * Method `GetDocumentTemplates()`
  * Method `GetDocumentTemplatesTasks()`
  * Method `GetDocumentTemplateStreamFromId(Int32, String)`
  * Method `GetDocumentTemplateTask(Int32)`
  * Method `GetDocumentTemplateUrl(Int32, Boolean, String)`
  * Method `GetDocumentTemplateUsedInProjectStage(Int32)`
  * Method `GetDocumentTemplateUsedInSalesStage(Int32)`
  * Method `GetDocumentTypesForPlugin(Int32)`
  * Method `GetEmarketingStrictMode()`
  * Method `GetExtAppEntity(Int32)`
  * Method `GetFromListDefinition(Int32, Int32)`
  * Method `GetFromListName(Int32, String)`
  * Method `GetHeadingEntity(Int32)`
  * Method `GetHeadings(Int32, Int32, Boolean)`
  * Method `GetHeadingsForListItemFromListName(String, Int32, Boolean)`
  * Method `GetHeadingsFromListDefinition(Int32)`
  * Method `GetHeadingsFromName(String)`
  * Method `GetHierarchyEntity(Int32)`
  * Method `GetHierarchyFromPath(Domain, String, Boolean)`
  * Method `GetInstalledLanguages()`
  * Method `GetLanguageInfo(Int32)`
  * Method `GetLanguageInfoList(Int32[])`
  * Method `GetLegalBase(Int32)`
  * Method `GetLegalBaseList(Int32[])`
  * Method `GetLegalBases()`
  * Method `GetLink(Int32)`
  * Method `GetLinkList(Int32[])`
  * Method `GetListDefinitions(Boolean)`
  * Method `GetListEntity(Int32)`
  * Method `GetListEntityByName(String)`
  * Method `GetListItemsForHeading(Int32, Int32)`
  * Method `GetListItemsForHeadingFromListName(String, Int32)`
  * Method `GetListItemsForUserGroup(Int32, Int32)`
  * Method `GetListItemsForUserGroupFromListName(String, Int32)`
  * Method `GetLocalizedText(Int32)`
  * Method `GetLocalizedTextByType(LocalizedTextType, Int32, Int32)`
  * Method `GetLocalizedTextList(Int32[])`
  * Method `GetLocalizedTexts()`
  * Method `GetLocalizedTextsByLanguageId(Int32)`
  * Method `GetLocalizedTextsByType(LocalizedTextType[])`
  * Method `GetMrMrs(Int32)`
  * Method `GetMrMrses()`
  * Method `GetMrMrsList(Int32[])`
  * Method `GetOurCurrency()`
  * Method `GetOwnerCompanysCurrency()`
  * Method `GetPaymentTerm(Int32)`
  * Method `GetPaymentTerms()`
  * Method `GetPaymentType(Int32)`
  * Method `GetPaymentTypes()`
  * Method `GetPluginCapabilities(Int32)`
  * Method `GetPluginList()`
  * Method `GetPosition(Int32)`
  * Method `GetPositionList(Int32[])`
  * Method `GetPositions()`
  * Method `GetPriorities()`
  * Method `GetPriority(Int32)`
  * Method `GetPriorityList(Int32[])`
  * Method `GetProductCategories()`
  * Method `GetProductCategory(Int32)`
  * Method `GetProductFamilies()`
  * Method `GetProductFamily(Int32)`
  * Method `GetProductType(Int32)`
  * Method `GetProductTypes()`
  * Method `GetProjectStatus(Int32)`
  * Method `GetProjectStatuses()`
  * Method `GetProjectStatusList(Int32[])`
  * Method `GetProjectType(Int32)`
  * Method `GetProjectTypeEntity(Int32)`
  * Method `GetProjectTypeList(Int32[])`
  * Method `GetProjectTypes()`
  * Method `GetQuickReplies()`
  * Method `GetQuoteApproveReason(Int32)`
  * Method `GetQuoteApproveReasonList(Int32[])`
  * Method `GetQuoteApproveReasons()`
  * Method `GetQuoteDenyReason(Int32)`
  * Method `GetQuoteDenyReasonList(Int32[])`
  * Method `GetQuoteDenyReasons()`
  * Method `GetRating(Int32)`
  * Method `GetRatingList(Int32[])`
  * Method `GetRatings()`
  * Method `GetReason(Int32)`
  * Method `GetReasonList(Int32[])`
  * Method `GetReasons()`
  * Method `GetReasonSold(Int32)`
  * Method `GetReasonSoldList(Int32[])`
  * Method `GetReasonStalled(Int32)`
  * Method `GetReasonStalledList(Int32[])`
  * Method `GetRelationDefinitionEntity(Int32)`
  * Method `GetResourceEntity(Int32)`
  * Method `GetSaleStageEntity(Int32)`
  * Method `GetSaleType(Int32)`
  * Method `GetSaleTypeEntity(Int32)`
  * Method `GetSaleTypeList(Int32[])`
  * Method `GetSelectionCategory(Int32)`
  * Method `GetSelectionCategoryList(Int32[])`
  * Method `GetSource(Int32)`
  * Method `GetSourceList(Int32[])`
  * Method `GetSources()`
  * Method `GetTask(Int32)`
  * Method `GetTaskList(Int32[])`
  * Method `GetTaskMenu(Int32)`
  * Method `GetTaskMenuByProgId(String)`
  * Method `GetTasks()`
  * Method `GetTicketCategories()`
  * Method `GetTicketCategoriesForUserGroups(Int32[])`
  * Method `GetTicketCategory(Int32)`
  * Method `GetTicketCategoryEntity(Int32)`
  * Method `GetTicketCategoryList(Int32[])`
  * Method `GetTicketPriorities()`
  * Method `GetTicketPriority(Int32)`
  * Method `GetTicketPriorityEntity(Int32)`
  * Method `GetTicketPriorityList(Int32[])`
  * Method `GetTicketStatusEntity(Int32)`
  * Method `GetTicketStatuses()`
  * Method `GetTicketStatusList(Int32[])`
  * Method `GetTicketTypeEntity(Int32)`
  * Method `GetTicketTypeList(Int32[])`
  * Method `GetTicketTypes()`
  * Method `GetVisibleForUserGroups(Int32, Int32)`
  * Method `GetVisibleForUserGroupsFromListName(String, Int32)`
  * Method `GetWebPanelByProgId(String)`
  * Method `GetWebPanelEntity(Int32)`
  * Method `GetWebPanelList()`
  * Method `GlobalChangeTicketStatus(Int32, Int32)`
  * Method `GlobalChangeTicketType(Int32, Int32)`
  * Method `MoveAllTickets(Int32, Int32)`
  * Method `MoveListItem(Int32, Int32, Int32)`
  * Method `RebuildFullnames()`
  * Method `SaveAllFromListDefinition(Int32, ListItemEntity[])`
  * Method `SaveAllFromListName(String, ListItemEntity[])`
  * Method `SaveAmountClassEntity(AmountClassEntity)`
  * Method `SaveConsentPurpose(ConsentPurpose)`
  * Method `SaveConsentSource(ConsentSource)`
  * Method `SaveCountry(Country)`
  * Method `SaveCurrencyEntity(CurrencyEntity)`
  * Method `SaveDocumentTemplateEntity(DocumentTemplateEntity)`
  * Method `SaveDocumentTemplateStream(Int32, Stream, String, Int32)`
  * Method `SaveExtAppEntity(ExtAppEntity)`
  * Method `SaveFromListDefinition(Int32, Int32, ListItemEntity)`
  * Method `SaveFromListName(Int32, String, ListItemEntity)`
  * Method `SaveHeadingEntity(HeadingEntity)`
  * Method `SaveHeadingFromListDefinition(Int32, HeadingEntity)`
  * Method `SaveHeadingFromName(String, HeadingEntity)`
  * Method `SaveHeadingsForListItemFromListDefinition(Int32, Int32, SelectableMDOListItem[])`
  * Method `SaveHeadingsForListItemFromListName(String, Int32, SelectableMDOListItem[])`
  * Method `SaveHeadingsFromListDefinition(Int32, HeadingEntity[])`
  * Method `SaveHeadingsFromName(String, HeadingEntity[])`
  * Method `SaveHierarchyEntity(HierarchyEntity)`
  * Method `SaveLegalBase(LegalBase)`
  * Method `SaveListEntity(ListEntity)`
  * Method `SaveListEntityByName(String, ListEntity)`
  * Method `SaveListItemEntity(ListItemEntity)`
  * Method `SaveProjectTypeEntity(ProjectTypeEntity)`
  * Method `SaveQuickReplies(QuickReply[])`
  * Method `SaveRelationDefinitionEntity(RelationDefinitionEntity)`
  * Method `SaveResourceEntity(ResourceEntity)`
  * Method `SaveSaleStageEntity(SaleStageEntity)`
  * Method `SaveSaleTypeEntity(SaleTypeEntity)`
  * Method `SaveTaskMenu(TaskMenu)`
  * Method `SaveTicketCategoryEntity(TicketCategoryEntity)`
  * Method `SaveTicketPriorityEntity(TicketPriorityEntity)`
  * Method `SaveTicketStatusEntity(TicketStatusEntity)`
  * Method `SaveTicketTypeEntity(TicketTypeEntity)`
  * Method `SaveWebPanelEntity(WebPanelEntity)`
  * Method `SetDocumentPluginForAllDocumentTemplates(Int32)`
  * Method `SetDocumentTemplateFromDocumentTemplate(Int32, DocumentTemplateEntity)`
  * Method `SetDocumentTemplateStream(DocumentTemplateEntity, Stream, String, Int32)`
  * Method `SetEmarketingStrictMode(Boolean)`
  * Method `SetHeadingsForListItem(Int32, Int32, Int32[], Boolean)`
  * Method `SetListItemsForHeading(Int32, Int32, Int32[], Boolean)`
  * Method `SetListItemsForHeadingFromListName(String, Int32, Int32[], Boolean)`
  * Method `SetListItemsForUserGroup(Int32, Int32, Int32[], Boolean)`
  * Method `SetListItemsForUserGroupFromListName(String, Int32, Int32[], Boolean)`
  * Method `SetRankOnHeadings(Int32, Int32[])`
  * Method `SetRankOnProjectActivity(Int32, Int32[])`
  * Method `SetRankOnProjectDocument(Int32, Int32[])`
  * Method `SetRankOnSaleActivity(Int32, Int32[])`
  * Method `SetRankOnSaleDocument(Int32, Int32[])`
  * Method `SetTicketCategoriesForUserGroup(Int32, Int32[])`
  * Method `SetTicketPrioritySortOrder(Int32, Int32)`
  * Method `SetTicketStatusSortOrder(Int32, Int32)`
  * Method `SetTicketTypeSortOrder(Int32, Int32)`
  * Method `SetVisibleForUserGroup(Int32, Int32, Int32[], Boolean)`
  * Method `SetVisibleForUserGroups(Int32, Int32, SelectableMDOListItem[])`
  * Method `SetVisibleForUserGroupsFromListName(String, Int32, SelectableMDOListItem[])`
  * Method `SortListItems(Int32, String)`
  * Method `UpdateCategoryMemberships(Int32, TicketCategoryMembershipEntity[], TicketCategoryMembershipEntity[], TicketCategoryMembershipEntity[])`
  * Method `UpdateHierarchyFromPath(Domain, String, HierarchyEntity)`
* New items
  * Method `AddFromListDefinitionAsync(Int32, ListItemEntity, CancellationToken)`
  * Method `AddFromListNameAsync(String, ListItemEntity, CancellationToken)`
  * Method `AddHierarchyToPathAsync(Domain, String, String, CancellationToken)`
  * Method `ChangeCurrencyAsync(Double, String, String, CancellationToken)`
  * Method `CreateDefaultAmountClassEntityAsync(CancellationToken)`
  * Method `CreateDefaultCountryAsync(CancellationToken)`
  * Method `CreateDefaultCurrencyEntityAsync(CancellationToken)`
  * Method `CreateDefaultDocumentTemplateEntityAsync(CancellationToken)`
  * Method `CreateDefaultDocumentTemplateLanguageAsync(Int32, String, CancellationToken)`
  * Method `CreateDefaultExtAppEntityAsync(CancellationToken)`
  * Method `CreateDefaultHeadingEntityAsync(CancellationToken)`
  * Method `CreateDefaultHeadingFromListDefinitionAsync(Int32, CancellationToken)`
  * Method `CreateDefaultHierarchyEntityAsync(CancellationToken)`
  * Method `CreateDefaultListEntityAsync(CancellationToken)`
  * Method `CreateDefaultListItemEntityAsync(CancellationToken)`
  * Method `CreateDefaultProjectTypeEntityAsync(CancellationToken)`
  * Method `CreateDefaultRelationDefinitionEntityAsync(CancellationToken)`
  * Method `CreateDefaultResourceEntityAsync(CancellationToken)`
  * Method `CreateDefaultSaleStageEntityAsync(CancellationToken)`
  * Method `CreateDefaultSaleTypeEntityAsync(CancellationToken)`
  * Method `CreateDefaultTaskMenuAsync(CancellationToken)`
  * Method `CreateDefaultTicketCategoryEntityAsync(CancellationToken)`
  * Method `CreateDefaultTicketPriorityEntityAsync(CancellationToken)`
  * Method `CreateDefaultTicketStatusEntityAsync(CancellationToken)`
  * Method `CreateDefaultTicketTypeEntityAsync(CancellationToken)`
  * Method `CreateDefaultWebPanelEntityAsync(CancellationToken)`
  * Method `DeleteAllFromListDefinitionAsync(Int32, CancellationToken)`
  * Method `DeleteAllFromListNameAsync(String, CancellationToken)`
  * Method `DeleteAllHeadingsFromListDefinitionAsync(Int32, CancellationToken)`
  * Method `DeleteAllHeadingsFromNameAsync(String, CancellationToken)`
  * Method `DeleteAppTaskMenusAsync(CancellationToken)`
  * Method `DeleteAppWebPanelsAsync(CancellationToken)`
  * Method `DeleteDocumentTemplateLanguageAsync(Int32, String, CancellationToken)`
  * Method `DeleteFromListDefinitionAsync(Int32, Int32, CancellationToken)`
  * Method `DeleteFromListNameAsync(Int32, String, CancellationToken)`
  * Method `DeleteHierarchyEntityAsync(Int32, CancellationToken)`
  * Method `DeleteHierarchyFromPathAsync(Domain, String, CancellationToken)`
  * Method `DeleteListEntityAsync(Int32, CancellationToken)`
  * Method `DeleteListEntityByNameAsync(String, CancellationToken)`
  * Method `DeleteProjectStatusAsync(Int32, CancellationToken)`
  * Method `DeleteResourceEntityAsync(Int32, CancellationToken)`
  * Method `DeleteTaskMenuAsync(Int32, CancellationToken)`
  * Method `DeleteTicketCategoryEntityAsync(Int32, CancellationToken)`
  * Method `DeleteTicketPriorityEntityAsync(Int32, CancellationToken)`
  * Method `DeleteTicketStatusEntityAsync(Int32, CancellationToken)`
  * Method `DeleteTicketTypeEntityAsync(Int32, CancellationToken)`
  * Method `DeleteWebPanelAsync(Int32, CancellationToken)`
  * Method `GenerateNavigationUrlAsync(Navigation, String, CancellationToken)`
  * Method `GetAllConsentSourceAsync(CancellationToken)`
  * Method `GetAllCountriesAsync(Boolean, CancellationToken)`
  * Method `GetAllCurrenciesAsync(Boolean, CancellationToken)`
  * Method `GetAllDocumentTemplatesAsync(Boolean, CancellationToken)`
  * Method `GetAllDomainsAsync(CancellationToken)`
  * Method `GetAllFromListDefinitionAsync(Int32, Boolean, CancellationToken)`
  * Method `GetAllFromListNameAsync(String, Boolean, CancellationToken)`
  * Method `GetAllInDomainAsync(Domain, Boolean, CancellationToken)`
  * Method `GetAllLegalBaseAsync(CancellationToken)`
  * Method `GetAllReasonSoldAsync(CancellationToken)`
  * Method `GetAllReasonStalledAsync(CancellationToken)`
  * Method `GetAllSaleStagesAsync(Boolean, CancellationToken)`
  * Method `GetAllSaleTypeAsync(CancellationToken)`
  * Method `GetAllSaleTypeEntitiesAsync(Boolean, CancellationToken)`
  * Method `GetAllSelectionCategoryAsync(CancellationToken)`
  * Method `GetAllTasksAsync(Boolean, CancellationToken)`
  * Method `GetAllTicketPrioritiesAsync(Boolean, CancellationToken)`
  * Method `GetAmountClassEntityAsync(Int32, CancellationToken)`
  * Method `GetAppTaskMenusAsync(CancellationToken)`
  * Method `GetAppWebPanelsAsync(CancellationToken)`
  * Method `GetBaseCurrencyAsync(CancellationToken)`
  * Method `GetBusinessAsync(Int32, CancellationToken)`
  * Method `GetBusinessesAsync(CancellationToken)`
  * Method `GetBusinessListAsync(Int32[], CancellationToken)`
  * Method `GetCategoriesAsync(CancellationToken)`
  * Method `GetCategoryAsync(Int32, CancellationToken)`
  * Method `GetCategoryListAsync(Int32[], CancellationToken)`
  * Method `GetCompetitorAsync(Int32, CancellationToken)`
  * Method `GetCompetitorListAsync(Int32[], CancellationToken)`
  * Method `GetCompetitorsAsync(CancellationToken)`
  * Method `GetConsentPurposeAsync(Int32, CancellationToken)`
  * Method `GetConsentPurposeListAsync(Int32[], CancellationToken)`
  * Method `GetConsentPurposesAsync(CancellationToken)`
  * Method `GetConsentSourceAsync(Int32, CancellationToken)`
  * Method `GetConsentSourceListAsync(Int32[], CancellationToken)`
  * Method `GetConsentSourcesAsync(CancellationToken)`
  * Method `GetCountriesAsync(CancellationToken)`
  * Method `GetCountryAsync(Int32, CancellationToken)`
  * Method `GetCountryListAsync(Int32[], CancellationToken)`
  * Method `GetCreditedAsync(Int32, CancellationToken)`
  * Method `GetCreditedListAsync(Int32[], CancellationToken)`
  * Method `GetCreditedsAsync(CancellationToken)`
  * Method `GetCurrenciesAsync(CancellationToken)`
  * Method `GetCurrencyAsync(Int32, CancellationToken)`
  * Method `GetCurrencyEntityAsync(Int32, CancellationToken)`
  * Method `GetCurrencyListAsync(Int32[], CancellationToken)`
  * Method `GetCustomerLanguageAsync(Int32, CancellationToken)`
  * Method `GetCustomerLanguageListAsync(Int32[], CancellationToken)`
  * Method `GetCustomerLanguagesAsync(CancellationToken)`
  * Method `GetDeliveryTermAsync(Int32, CancellationToken)`
  * Method `GetDeliveryTermsAsync(CancellationToken)`
  * Method `GetDeliveryTypeAsync(Int32, CancellationToken)`
  * Method `GetDeliveryTypesAsync(CancellationToken)`
  * Method `GetDepartmentAsync(Int32, CancellationToken)`
  * Method `GetDepartmentListAsync(Int32[], CancellationToken)`
  * Method `GetDepartmentsAsync(CancellationToken)`
  * Method `GetDocumentTemplateAsync(Int32, CancellationToken)`
  * Method `GetDocumentTemplateEntityAsync(Int32, CancellationToken)`
  * Method `GetDocumentTemplateExtensionAsync(Int32, CancellationToken)`
  * Method `GetDocumentTemplateLanguagesAsync(Int32, CancellationToken)`
  * Method `GetDocumentTemplateListAsync(Int32[], CancellationToken)`
  * Method `GetDocumentTemplatePropertiesAsync(Int32, String[], CancellationToken)`
  * Method `GetDocumentTemplatesAsync(CancellationToken)`
  * Method `GetDocumentTemplatesTasksAsync(CancellationToken)`
  * Method `GetDocumentTemplateStreamFromIdAsync(Int32, String, CancellationToken)`
  * Method `GetDocumentTemplateTaskAsync(Int32, CancellationToken)`
  * Method `GetDocumentTemplateUrlAsync(Int32, Boolean, String, CancellationToken)`
  * Method `GetDocumentTemplateUsedInProjectStageAsync(Int32, CancellationToken)`
  * Method `GetDocumentTemplateUsedInSalesStageAsync(Int32, CancellationToken)`
  * Method `GetDocumentTypesForPluginAsync(Int32, CancellationToken)`
  * Method `GetEmarketingStrictModeAsync(CancellationToken)`
  * Method `GetExtAppEntityAsync(Int32, CancellationToken)`
  * Method `GetFromListDefinitionAsync(Int32, Int32, CancellationToken)`
  * Method `GetFromListNameAsync(Int32, String, CancellationToken)`
  * Method `GetHeadingEntityAsync(Int32, CancellationToken)`
  * Method `GetHeadingsAsync(Int32, Int32, Boolean, CancellationToken)`
  * Method `GetHeadingsForListItemFromListNameAsync(String, Int32, Boolean, CancellationToken)`
  * Method `GetHeadingsFromListDefinitionAsync(Int32, CancellationToken)`
  * Method `GetHeadingsFromNameAsync(String, CancellationToken)`
  * Method `GetHierarchyEntityAsync(Int32, CancellationToken)`
  * Method `GetHierarchyFromPathAsync(Domain, String, Boolean, CancellationToken)`
  * Method `GetInstalledLanguagesAsync(CancellationToken)`
  * Method `GetLanguageInfoAsync(Int32, CancellationToken)`
  * Method `GetLanguageInfoListAsync(Int32[], CancellationToken)`
  * Method `GetLegalBaseAsync(Int32, CancellationToken)`
  * Method `GetLegalBaseListAsync(Int32[], CancellationToken)`
  * Method `GetLegalBasesAsync(CancellationToken)`
  * Method `GetLinkAsync(Int32, CancellationToken)`
  * Method `GetLinkListAsync(Int32[], CancellationToken)`
  * Method `GetListDefinitionsAsync(Boolean, CancellationToken)`
  * Method `GetListEntityAsync(Int32, CancellationToken)`
  * Method `GetListEntityByNameAsync(String, CancellationToken)`
  * Method `GetListItemsForHeadingAsync(Int32, Int32, CancellationToken)`
  * Method `GetListItemsForHeadingFromListNameAsync(String, Int32, CancellationToken)`
  * Method `GetListItemsForUserGroupAsync(Int32, Int32, CancellationToken)`
  * Method `GetListItemsForUserGroupFromListNameAsync(String, Int32, CancellationToken)`
  * Method `GetLocalizedTextAsync(Int32, CancellationToken)`
  * Method `GetLocalizedTextByTypeAsync(LocalizedTextType, Int32, Int32, CancellationToken)`
  * Method `GetLocalizedTextListAsync(Int32[], CancellationToken)`
  * Method `GetLocalizedTextsAsync(CancellationToken)`
  * Method `GetLocalizedTextsByLanguageIdAsync(Int32, CancellationToken)`
  * Method `GetLocalizedTextsByTypeAsync(LocalizedTextType[], CancellationToken)`
  * Method `GetMrMrsAsync(Int32, CancellationToken)`
  * Method `GetMrMrsesAsync(CancellationToken)`
  * Method `GetMrMrsListAsync(Int32[], CancellationToken)`
  * Method `GetOurCurrencyAsync(CancellationToken)`
  * Method `GetOwnerCompanysCurrencyAsync(CancellationToken)`
  * Method `GetPaymentTermAsync(Int32, CancellationToken)`
  * Method `GetPaymentTermsAsync(CancellationToken)`
  * Method `GetPaymentTypeAsync(Int32, CancellationToken)`
  * Method `GetPaymentTypesAsync(CancellationToken)`
  * Method `GetPluginCapabilitiesAsync(Int32, CancellationToken)`
  * Method `GetPluginListAsync(CancellationToken)`
  * Method `GetPositionAsync(Int32, CancellationToken)`
  * Method `GetPositionListAsync(Int32[], CancellationToken)`
  * Method `GetPositionsAsync(CancellationToken)`
  * Method `GetPrioritiesAsync(CancellationToken)`
  * Method `GetPriorityAsync(Int32, CancellationToken)`
  * Method `GetPriorityListAsync(Int32[], CancellationToken)`
  * Method `GetProductCategoriesAsync(CancellationToken)`
  * Method `GetProductCategoryAsync(Int32, CancellationToken)`
  * Method `GetProductFamiliesAsync(CancellationToken)`
  * Method `GetProductFamilyAsync(Int32, CancellationToken)`
  * Method `GetProductTypeAsync(Int32, CancellationToken)`
  * Method `GetProductTypesAsync(CancellationToken)`
  * Method `GetProjectStatusAsync(Int32, CancellationToken)`
  * Method `GetProjectStatusesAsync(CancellationToken)`
  * Method `GetProjectStatusListAsync(Int32[], CancellationToken)`
  * Method `GetProjectTypeAsync(Int32, CancellationToken)`
  * Method `GetProjectTypeEntityAsync(Int32, CancellationToken)`
  * Method `GetProjectTypeListAsync(Int32[], CancellationToken)`
  * Method `GetProjectTypesAsync(CancellationToken)`
  * Method `GetQuickRepliesAsync(CancellationToken)`
  * Method `GetQuoteApproveReasonAsync(Int32, CancellationToken)`
  * Method `GetQuoteApproveReasonListAsync(Int32[], CancellationToken)`
  * Method `GetQuoteApproveReasonsAsync(CancellationToken)`
  * Method `GetQuoteDenyReasonAsync(Int32, CancellationToken)`
  * Method `GetQuoteDenyReasonListAsync(Int32[], CancellationToken)`
  * Method `GetQuoteDenyReasonsAsync(CancellationToken)`
  * Method `GetRatingAsync(Int32, CancellationToken)`
  * Method `GetRatingListAsync(Int32[], CancellationToken)`
  * Method `GetRatingsAsync(CancellationToken)`
  * Method `GetReasonAsync(Int32, CancellationToken)`
  * Method `GetReasonListAsync(Int32[], CancellationToken)`
  * Method `GetReasonsAsync(CancellationToken)`
  * Method `GetReasonSoldAsync(Int32, CancellationToken)`
  * Method `GetReasonSoldListAsync(Int32[], CancellationToken)`
  * Method `GetReasonStalledAsync(Int32, CancellationToken)`
  * Method `GetReasonStalledListAsync(Int32[], CancellationToken)`
  * Method `GetRelationDefinitionEntityAsync(Int32, CancellationToken)`
  * Method `GetResourceEntityAsync(Int32, CancellationToken)`
  * Method `GetSaleStageEntityAsync(Int32, CancellationToken)`
  * Method `GetSaleTypeAsync(Int32, CancellationToken)`
  * Method `GetSaleTypeEntityAsync(Int32, CancellationToken)`
  * Method `GetSaleTypeListAsync(Int32[], CancellationToken)`
  * Method `GetSelectionCategoryAsync(Int32, CancellationToken)`
  * Method `GetSelectionCategoryListAsync(Int32[], CancellationToken)`
  * Method `GetSoTaskAsync(Int32, CancellationToken)`
  * Method `GetSourceAsync(Int32, CancellationToken)`
  * Method `GetSourceListAsync(Int32[], CancellationToken)`
  * Method `GetSourcesAsync(CancellationToken)`
  * Method `GetTaskListAsync(Int32[], CancellationToken)`
  * Method `GetTaskMenuAsync(Int32, CancellationToken)`
  * Method `GetTaskMenuByProgIdAsync(String, CancellationToken)`
  * Method `GetTasksAsync(CancellationToken)`
  * Method `GetTicketCategoriesAsync(CancellationToken)`
  * Method `GetTicketCategoriesForUserGroupsAsync(Int32[], CancellationToken)`
  * Method `GetTicketCategoryAsync(Int32, CancellationToken)`
  * Method `GetTicketCategoryEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketCategoryListAsync(Int32[], CancellationToken)`
  * Method `GetTicketPrioritiesAsync(CancellationToken)`
  * Method `GetTicketPriorityAsync(Int32, CancellationToken)`
  * Method `GetTicketPriorityEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketPriorityListAsync(Int32[], CancellationToken)`
  * Method `GetTicketStatusEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketStatusesAsync(CancellationToken)`
  * Method `GetTicketStatusListAsync(Int32[], CancellationToken)`
  * Method `GetTicketTypeEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketTypeListAsync(Int32[], CancellationToken)`
  * Method `GetTicketTypesAsync(CancellationToken)`
  * Method `GetVisibleForUserGroupsAsync(Int32, Int32, CancellationToken)`
  * Method `GetVisibleForUserGroupsFromListNameAsync(String, Int32, CancellationToken)`
  * Method `GetWebPanelByProgIdAsync(String, CancellationToken)`
  * Method `GetWebPanelEntityAsync(Int32, CancellationToken)`
  * Method `GetWebPanelListAsync(CancellationToken)`
  * Method `GlobalChangeTicketStatusAsync(Int32, Int32, CancellationToken)`
  * Method `GlobalChangeTicketTypeAsync(Int32, Int32, CancellationToken)`
  * Method `MoveAllTicketsAsync(Int32, Int32, CancellationToken)`
  * Method `MoveListItemAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `RebuildFullnamesAsync(CancellationToken)`
  * Method `SaveAllFromListDefinitionAsync(Int32, ListItemEntity[], CancellationToken)`
  * Method `SaveAllFromListNameAsync(String, ListItemEntity[], CancellationToken)`
  * Method `SaveAmountClassEntityAsync(AmountClassEntity, CancellationToken)`
  * Method `SaveConsentPurposeAsync(ConsentPurpose, CancellationToken)`
  * Method `SaveConsentSourceAsync(ConsentSource, CancellationToken)`
  * Method `SaveCountryAsync(Country, CancellationToken)`
  * Method `SaveCurrencyEntityAsync(CurrencyEntity, CancellationToken)`
  * Method `SaveDocumentTemplateEntityAsync(DocumentTemplateEntity, CancellationToken)`
  * Method `SaveDocumentTemplateStreamAsync(Int32, Stream, String, Int32, CancellationToken)`
  * Method `SaveExtAppEntityAsync(ExtAppEntity, CancellationToken)`
  * Method `SaveFromListDefinitionAsync(Int32, Int32, ListItemEntity, CancellationToken)`
  * Method `SaveFromListNameAsync(Int32, String, ListItemEntity, CancellationToken)`
  * Method `SaveHeadingEntityAsync(HeadingEntity, CancellationToken)`
  * Method `SaveHeadingFromListDefinitionAsync(Int32, HeadingEntity, CancellationToken)`
  * Method `SaveHeadingFromNameAsync(String, HeadingEntity, CancellationToken)`
  * Method `SaveHeadingsForListItemFromListDefinitionAsync(Int32, Int32, SelectableMDOListItem[], CancellationToken)`
  * Method `SaveHeadingsForListItemFromListNameAsync(String, Int32, SelectableMDOListItem[], CancellationToken)`
  * Method `SaveHeadingsFromListDefinitionAsync(Int32, HeadingEntity[], CancellationToken)`
  * Method `SaveHeadingsFromNameAsync(String, HeadingEntity[], CancellationToken)`
  * Method `SaveHierarchyEntityAsync(HierarchyEntity, CancellationToken)`
  * Method `SaveLegalBaseAsync(LegalBase, CancellationToken)`
  * Method `SaveListEntityAsync(ListEntity, CancellationToken)`
  * Method `SaveListEntityByNameAsync(String, ListEntity, CancellationToken)`
  * Method `SaveListItemEntityAsync(ListItemEntity, CancellationToken)`
  * Method `SaveProjectTypeEntityAsync(ProjectTypeEntity, CancellationToken)`
  * Method `SaveQuickRepliesAsync(QuickReply[], CancellationToken)`
  * Method `SaveRelationDefinitionEntityAsync(RelationDefinitionEntity, CancellationToken)`
  * Method `SaveResourceEntityAsync(ResourceEntity, CancellationToken)`
  * Method `SaveSaleStageEntityAsync(SaleStageEntity, CancellationToken)`
  * Method `SaveSaleTypeEntityAsync(SaleTypeEntity, CancellationToken)`
  * Method `SaveTaskMenuAsync(TaskMenu, CancellationToken)`
  * Method `SaveTicketCategoryEntityAsync(TicketCategoryEntity, CancellationToken)`
  * Method `SaveTicketPriorityEntityAsync(TicketPriorityEntity, CancellationToken)`
  * Method `SaveTicketStatusEntityAsync(TicketStatusEntity, CancellationToken)`
  * Method `SaveTicketTypeEntityAsync(TicketTypeEntity, CancellationToken)`
  * Method `SaveWebPanelEntityAsync(WebPanelEntity, CancellationToken)`
  * Method `SetDocumentPluginForAllDocumentTemplatesAsync(Int32, CancellationToken)`
  * Method `SetDocumentTemplateFromDocumentTemplateAsync(Int32, DocumentTemplateEntity, CancellationToken)`
  * Method `SetDocumentTemplateStreamAsync(DocumentTemplateEntity, Stream, String, Int32, CancellationToken)`
  * Method `SetEmarketingStrictModeAsync(Boolean, CancellationToken)`
  * Method `SetHeadingsForListItemAsync(Int32, Int32, Int32[], Boolean, CancellationToken)`
  * Method `SetListItemsForHeadingAsync(Int32, Int32, Int32[], Boolean, CancellationToken)`
  * Method `SetListItemsForHeadingFromListNameAsync(String, Int32, Int32[], Boolean, CancellationToken)`
  * Method `SetListItemsForUserGroupAsync(Int32, Int32, Int32[], Boolean, CancellationToken)`
  * Method `SetListItemsForUserGroupFromListNameAsync(String, Int32, Int32[], Boolean, CancellationToken)`
  * Method `SetRankOnHeadingsAsync(Int32, Int32[], CancellationToken)`
  * Method `SetRankOnProjectActivityAsync(Int32, Int32[], CancellationToken)`
  * Method `SetRankOnProjectDocumentAsync(Int32, Int32[], CancellationToken)`
  * Method `SetRankOnSaleActivityAsync(Int32, Int32[], CancellationToken)`
  * Method `SetRankOnSaleDocumentAsync(Int32, Int32[], CancellationToken)`
  * Method `SetTicketCategoriesForUserGroupAsync(Int32, Int32[], CancellationToken)`
  * Method `SetTicketPrioritySortOrderAsync(Int32, Int32, CancellationToken)`
  * Method `SetTicketStatusSortOrderAsync(Int32, Int32, CancellationToken)`
  * Method `SetTicketTypeSortOrderAsync(Int32, Int32, CancellationToken)`
  * Method `SetVisibleForUserGroupAsync(Int32, Int32, Int32[], Boolean, CancellationToken)`
  * Method `SetVisibleForUserGroupsAsync(Int32, Int32, SelectableMDOListItem[], CancellationToken)`
  * Method `SetVisibleForUserGroupsFromListNameAsync(String, Int32, SelectableMDOListItem[], CancellationToken)`
  * Method `SortListItemsAsync(Int32, String, CancellationToken)`
  * Method `UpdateCategoryMembershipsAsync(Int32, TicketCategoryMembershipEntity[], TicketCategoryMembershipEntity[], TicketCategoryMembershipEntity[], CancellationToken)`
  * Method `UpdateHierarchyFromPathAsync(Domain, String, HierarchyEntity, CancellationToken)`

#### SuperOffice.CRM.Services.IMarketingAgent is Modified

* Deleted items
  * Method `CalculateMailingStatistics(Int32)`
  * Method `CreateDefaultFormEntity()`
  * Method `CreateDefaultFormSubmissionEntity()`
  * Method `CreateDefaultShipmentMessageBlockEntity()`
  * Method `CreateDefaultShipmentMessageEntity()`
  * Method `DeleteFormEntity(Int32)`
  * Method `DeleteFormSubmissionEntity(Int32)`
  * Method `DeleteMessageAndShipment(Int32)`
  * Method `DeleteShipmentMessageBlockEntity(Int32)`
  * Method `DeleteShipmentMessageEntity(Int32)`
  * Method `GetFormEntity(Int32)`
  * Method `GetFormSubmissionEntity(Int32)`
  * Method `GetFormSubmissionsCount(Int32, FormSubmissionStatus)`
  * Method `GetPreviewMailing(Int32)`
  * Method `GetPreviewMailingHeader(Int32)`
  * Method `GetShipmentMessageBlockEntity(Int32)`
  * Method `GetShipmentMessageEntity(Int32)`
  * Method `GetUserBlocks(Int32)`
  * Method `RenameMailingByMessageId(Int32, String)`
  * Method `SaveFormEntity(FormEntity)`
  * Method `SaveFormSubmissionEntity(FormSubmissionEntity)`
  * Method `SaveShipmentMessageBlockEntity(ShipmentMessageBlockEntity)`
  * Method `SaveShipmentMessageEntity(ShipmentMessageEntity)`
  * Method `VerifyGoogleRecaptcha(String, String)`
* New items
  * Method `CalculateMailingStatisticsAsync(Int32, CancellationToken)`
  * Method `CreateDefaultFormEntityAsync(CancellationToken)`
  * Method `CreateDefaultFormSubmissionEntityAsync(CancellationToken)`
  * Method `CreateDefaultShipmentMessageBlockEntityAsync(CancellationToken)`
  * Method `CreateDefaultShipmentMessageEntityAsync(CancellationToken)`
  * Method `DeleteFormEntityAsync(Int32, CancellationToken)`
  * Method `DeleteFormSubmissionEntityAsync(Int32, CancellationToken)`
  * Method `DeleteMessageAndShipmentAsync(Int32, CancellationToken)`
  * Method `DeleteShipmentMessageBlockEntityAsync(Int32, CancellationToken)`
  * Method `DeleteShipmentMessageEntityAsync(Int32, CancellationToken)`
  * Method `GetFormEntityAsync(Int32, CancellationToken)`
  * Method `GetFormSubmissionEntityAsync(Int32, CancellationToken)`
  * Method `GetFormSubmissionsCountAsync(Int32, FormSubmissionStatus, CancellationToken)`
  * Method `GetPreviewMailingAsync(Int32, CancellationToken)`
  * Method `GetPreviewMailingHeaderAsync(Int32, CancellationToken)`
  * Method `GetShipmentMessageBlockEntityAsync(Int32, CancellationToken)`
  * Method `GetShipmentMessageEntityAsync(Int32, CancellationToken)`
  * Method `GetUserBlocksAsync(Int32, CancellationToken)`
  * Method `RenameMailingByMessageIdAsync(Int32, String, CancellationToken)`
  * Method `SaveFormEntityAsync(FormEntity, CancellationToken)`
  * Method `SaveFormSubmissionEntityAsync(FormSubmissionEntity, CancellationToken)`
  * Method `SaveShipmentMessageBlockEntityAsync(ShipmentMessageBlockEntity, CancellationToken)`
  * Method `SaveShipmentMessageEntityAsync(ShipmentMessageEntity, CancellationToken)`
  * Method `VerifyGoogleRecaptchaAsync(String, String, CancellationToken)`

#### SuperOffice.CRM.Services.IMDOAgent is Modified

* Deleted items
  * Method `GetList(String, Boolean, String, Boolean)`
  * Method `GetListIdByListName(String)`
  * Method `GetListItem(String, Int32)`
  * Method `GetListNames()`
  * Method `GetListWithHistory(String, Boolean, String, Int32[], Boolean)`
  * Method `GetListWithRestriction(String, String, String)`
  * Method `GetSelectableList(String, Boolean, String, Boolean)`
  * Method `GetSelectableListWithHistory(String, Boolean, String, Int32[], Boolean)`
  * Method `GetSelectableListWithRestriction(String, String, String)`
  * Method `GetSelectableSimpleList(String)`
  * Method `GetSimpleList(String)`
  * Method `SetSelected(String, String, SelectableMDOListItem[])`
* New items
  * Method `GetListAsync(String, Boolean, String, Boolean, CancellationToken)`
  * Method `GetListIdByListNameAsync(String, CancellationToken)`
  * Method `GetListItemAsync(String, Int32, CancellationToken)`
  * Method `GetListNamesAsync(CancellationToken)`
  * Method `GetListWithHistoryAsync(String, Boolean, String, Int32[], Boolean, CancellationToken)`
  * Method `GetListWithRestrictionAsync(String, String, String, CancellationToken)`
  * Method `GetSelectableListAsync(String, Boolean, String, Boolean, CancellationToken)`
  * Method `GetSelectableListWithHistoryAsync(String, Boolean, String, Int32[], Boolean, CancellationToken)`
  * Method `GetSelectableListWithRestrictionAsync(String, String, String, CancellationToken)`
  * Method `GetSelectableSimpleListAsync(String, CancellationToken)`
  * Method `GetSimpleListAsync(String, CancellationToken)`
  * Method `SetSelectedAsync(String, String, SelectableMDOListItem[], CancellationToken)`

#### SuperOffice.CRM.Services.INumberAllocationAgent is Modified

* Deleted items
  * Method `CreateDefaultRefCountEntity()`
  * Method `DeleteRefCountEntity(Int32)`
  * Method `GetNumberEachTemplate()`
  * Method `GetRefCountEntity(Int32)`
  * Method `SaveDefaultNumbering(RefCountEntity)`
  * Method `SaveRefCountEntity(RefCountEntity)`
  * Method `SetNumberEachTemplate(Boolean)`
* New items
  * Method `CreateDefaultRefCountEntityAsync(CancellationToken)`
  * Method `DeleteRefCountEntityAsync(Int32, CancellationToken)`
  * Method `GetNumberEachTemplateAsync(CancellationToken)`
  * Method `GetRefCountEntityAsync(Int32, CancellationToken)`
  * Method `SaveDefaultNumberingAsync(RefCountEntity, CancellationToken)`
  * Method `SaveRefCountEntityAsync(RefCountEntity, CancellationToken)`
  * Method `SetNumberEachTemplateAsync(Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.IPersonAgent is Modified

* Deleted items
  * Method `AddBounce(String)`
  * Method `AddBounceWithCount(String, Int32)`
  * Method `AddBounceWithDetails(String, Int32, Int32, String)`
  * Method `AddEmailAddressToPerson(Int32, String, Boolean)`
  * Method `ChangeCountry(PersonEntity, Int32)`
  * Method `ChangePersonRank(Int32, Boolean)`
  * Method `CheckTemporaryKey(String)`
  * Method `CreateDefaultByContactId(Int32)`
  * Method `CreateDefaultConsentPerson()`
  * Method `CreateDefaultFromCredential(Int32, String, String, String)`
  * Method `CreateDefaultPersonEntity()`
  * Method `CreateDefaultPersonImage()`
  * Method `CreateOrUpdateUserCandidate(Int32, String, Boolean)`
  * Method `CreateTemporaryKey(TemporaryKeyDomain, Int32, Int32, DateTime)`
  * Method `CreateTemporaryKeyWithPayload(TemporaryKeyDomain, Int32, Int32, DateTime, String)`
  * Method `DeleteConsentPerson(Int32)`
  * Method `DeleteExpired()`
  * Method `DeletePersonEntity(Int32)`
  * Method `DeleteTemporaryKeysOfDomain(TemporaryKeyDomain, Int32)`
  * Method `GetAddress(Int32)`
  * Method `GetAddressByCountry(Int32, Int32)`
  * Method `GetBestSoLanguageForTemplate(Int32, Int32)`
  * Method `GetColleagues()`
  * Method `GetColleaguesByDepartment(Int32)`
  * Method `GetColleaguesBySource(AssociateSourceType, Int32)`
  * Method `GetConsentInfos(Int32)`
  * Method `GetConsentPerson(Int32)`
  * Method `GetCustomerCentrePasswordReplyTemplate(Int32)`
  * Method `GetMyOwner()`
  * Method `GetMyPerson()`
  * Method `GetOwnerOnPersonId(Int32)`
  * Method `GetPerson(Int32)`
  * Method `GetPersonEntity(Int32)`
  * Method `GetPersonImage(Int32)`
  * Method `GetPersonImages(Int32[], Int32, Int32)`
  * Method `GetPersonList(Int32[])`
  * Method `GetPersonsFromContact(Int32)`
  * Method `GetPersonsFromProject(Int32)`
  * Method `GetPersonSummary(Int32, Int32)`
  * Method `GetPhones(Int32)`
  * Method `GetSalesRep(String, String, String, String, String)`
  * Method `GetUserCandidateByPerson(Int32)`
  * Method `HasConsent(Int32, String)`
  * Method `IsNumberValid(Int32, String)`
  * Method `Merge(Int32, Int32, DateTime, Boolean, Boolean)`
  * Method `Move(Int32, Int32, DateTime)`
  * Method `NormalizeRanks(Int32)`
  * Method `RemoveConsent(Int32, String)`
  * Method `ResolvePersonFromInfo(Int32, String, String[], String[])`
  * Method `SaveConsentPerson(ConsentPerson)`
  * Method `SavePersonEntity(PersonEntity)`
  * Method `SendConsentConfirmationEmail(Int32, String, Int32, Int32, String)`
  * Method `SendEmail(String, String, String, String, String, Int32[])`
  * Method `SendEmailWithEventName(String, String, String, String, String, Int32[], String)`
  * Method `SetConsent(Int32, String, String, String, String)`
  * Method `SetPersonImage(Int32, Image)`
  * Method `SetPersonRank(Int32, Int16)`
  * Method `TryAddPersonsToEmailFlow(Int32, Int32[])`
  * Method `Undelete(Int32)`
  * Method `ValidatePersonEntity(PersonEntity)`
* New items
  * Method `AddBounceAsync(String, CancellationToken)`
  * Method `AddBounceWithCountAsync(String, Int32, CancellationToken)`
  * Method `AddBounceWithDetailsAsync(String, Int32, Int32, String, CancellationToken)`
  * Method `AddEmailAddressToPersonAsync(Int32, String, Boolean, CancellationToken)`
  * Method `ChangeCountryAsync(PersonEntity, Int32, CancellationToken)`
  * Method `ChangePersonRankAsync(Int32, Boolean, CancellationToken)`
  * Method `CheckTemporaryKeyAsync(String, CancellationToken)`
  * Method `CreateDefaultByContactIdAsync(Int32, CancellationToken)`
  * Method `CreateDefaultConsentPersonAsync(CancellationToken)`
  * Method `CreateDefaultFromCredentialAsync(Int32, String, String, String, CancellationToken)`
  * Method `CreateDefaultPersonEntityAsync(CancellationToken)`
  * Method `CreateDefaultPersonImageAsync(CancellationToken)`
  * Method `CreateOrUpdateUserCandidateAsync(Int32, String, Boolean, CancellationToken)`
  * Method `CreateTemporaryKeyAsync(TemporaryKeyDomain, Int32, Int32, DateTime, CancellationToken)`
  * Method `CreateTemporaryKeyWithPayloadAsync(TemporaryKeyDomain, Int32, Int32, DateTime, String, CancellationToken)`
  * Method `DeleteConsentPersonAsync(Int32, CancellationToken)`
  * Method `DeleteExpiredAsync(CancellationToken)`
  * Method `DeletePersonEntityAsync(Int32, CancellationToken)`
  * Method `DeleteTemporaryKeysOfDomainAsync(TemporaryKeyDomain, Int32, CancellationToken)`
  * Method `GetAddressAsync(Int32, CancellationToken)`
  * Method `GetAddressByCountryAsync(Int32, Int32, CancellationToken)`
  * Method `GetBestSoLanguageForTemplateAsync(Int32, Int32, CancellationToken)`
  * Method `GetColleaguesAsync(CancellationToken)`
  * Method `GetColleaguesByDepartmentAsync(Int32, CancellationToken)`
  * Method `GetColleaguesBySourceAsync(AssociateSourceType, Int32, CancellationToken)`
  * Method `GetConsentInfosAsync(Int32, CancellationToken)`
  * Method `GetConsentPersonAsync(Int32, CancellationToken)`
  * Method `GetCustomerCentrePasswordReplyTemplateAsync(Int32, CancellationToken)`
  * Method `GetMyOwnerAsync(CancellationToken)`
  * Method `GetMyPersonAsync(CancellationToken)`
  * Method `GetOwnerOnPersonIdAsync(Int32, CancellationToken)`
  * Method `GetPersonAsync(Int32, CancellationToken)`
  * Method `GetPersonEntityAsync(Int32, CancellationToken)`
  * Method `GetPersonImageAsync(Int32, CancellationToken)`
  * Method `GetPersonImagesAsync(Int32[], Int32, Int32, CancellationToken)`
  * Method `GetPersonListAsync(Int32[], CancellationToken)`
  * Method `GetPersonsFromContactAsync(Int32, CancellationToken)`
  * Method `GetPersonsFromProjectAsync(Int32, CancellationToken)`
  * Method `GetPersonSummaryAsync(Int32, Int32, CancellationToken)`
  * Method `GetPhonesAsync(Int32, CancellationToken)`
  * Method `GetSalesRepAsync(String, String, String, String, String, CancellationToken)`
  * Method `GetUserCandidateByPersonAsync(Int32, CancellationToken)`
  * Method `HasConsentAsync(Int32, String, CancellationToken)`
  * Method `IsNumberValidAsync(Int32, String, CancellationToken)`
  * Method `MergeAsync(Int32, Int32, DateTime, Boolean, Boolean, CancellationToken)`
  * Method `MoveAsync(Int32, Int32, DateTime, CancellationToken)`
  * Method `NormalizeRanksAsync(Int32, CancellationToken)`
  * Method `RemoveConsentAsync(Int32, String, CancellationToken)`
  * Method `ResolvePersonFromInfoAsync(Int32, String, String[], String[], CancellationToken)`
  * Method `SaveConsentPersonAsync(ConsentPerson, CancellationToken)`
  * Method `SavePersonEntityAsync(PersonEntity, CancellationToken)`
  * Method `SendConsentConfirmationEmailAsync(Int32, String, Int32, Int32, String, CancellationToken)`
  * Method `SendCustomerCentrePasswordEmailAsync(Int32, String, String, String, CancellationToken)`
  * Method `SendEmailAsync(String, String, String, String, String, Int32[], CancellationToken)`
  * Method `SendEmailWithEventNameAsync(String, String, String, String, String, Int32[], String, CancellationToken)`
  * Method `SetConsentAsync(Int32, String, String, String, String, CancellationToken)`
  * Method `SetPersonImageAsync(Int32, Image, CancellationToken)`
  * Method `SetPersonRankAsync(Int32, Int16, CancellationToken)`
  * Method `TryAddPersonsToEmailFlowAsync(Int32, Int32[], CancellationToken)`
  * Method `UndeleteAsync(Int32, CancellationToken)`
  * Method `ValidatePersonEntityAsync(PersonEntity, CancellationToken)`

#### SuperOffice.CRM.Services.IPhoneListAgent is Modified

* Deleted items
  * Method `AddToFavorites(Int32)`
  * Method `GetContactPhones(Int32)`
  * Method `GetDepartmentPhones(Int32)`
  * Method `GetFavoritesPhones()`
  * Method `GetPreferences()`
  * Method `Search(String)`
  * Method `SearchWithPreferences(String, PhoneListPreferences)`
  * Method `SetPreferences(PhoneListPreferences)`
* New items
  * Method `AddToFavoritesAsync(Int32, CancellationToken)`
  * Method `GetContactPhonesAsync(Int32, CancellationToken)`
  * Method `GetDepartmentPhonesAsync(Int32, CancellationToken)`
  * Method `GetFavoritesPhonesAsync(CancellationToken)`
  * Method `GetPreferencesAsync(CancellationToken)`
  * Method `SearchAsync(String, CancellationToken)`
  * Method `SearchWithPreferencesAsync(String, PhoneListPreferences, CancellationToken)`
  * Method `SetPreferencesAsync(PhoneListPreferences, CancellationToken)`

#### SuperOffice.CRM.Services.IPocketAgent is Modified

* Deleted items
  * Method `GetCallerIDsFromSelection(Int32, String)`
  * Method `GetMyCallerIDs(String, DateTime, DateTime)`
  * Method `GetPocketStartupData(String[], DateTime)`
  * Method `GetPushNotificationTagsForDevice(String)`
  * Method `GetRegisteredDevices(Int32)`
  * Method `NotificationHandled(NotificationEventType, Int32)`
  * Method `NotificationsHandled(NotificationEvent[])`
  * Method `NotifyUsers(NotificationEventType, Int32)`
  * Method `RegisterDeviceForPushNotification(PocketDeviceInfo)`
  * Method `RunAppointmentAlarmBroker()`
  * Method `SendPushNotification(Int32[], PocketNotificationMessage)`
  * Method `SetPushNotificationTagsForDevice(String, String)`
  * Method `SetPushNotificationTagsForUser(Int32, String)`
* New items
  * Method `GetCallerIDsFromSelectionAsync(Int32, String, CancellationToken)`
  * Method `GetMyCallerIDsAsync(String, DateTime, DateTime, CancellationToken)`
  * Method `GetPocketStartupDataAsync(String[], DateTime, CancellationToken)`
  * Method `GetPushNotificationTagsForDeviceAsync(String, CancellationToken)`
  * Method `GetRegisteredDevicesAsync(Int32, CancellationToken)`
  * Method `NotificationHandledAsync(NotificationEventType, Int32, CancellationToken)`
  * Method `NotificationsHandledAsync(NotificationEvent[], CancellationToken)`
  * Method `NotifyUsersAsync(NotificationEventType, Int32, CancellationToken)`
  * Method `RegisterDeviceForPushNotificationAsync(PocketDeviceInfo, CancellationToken)`
  * Method `RunAppointmentAlarmBrokerAsync(CancellationToken)`
  * Method `SendPushNotificationAsync(Int32[], PocketNotificationMessage, CancellationToken)`
  * Method `SetPushNotificationTagsForDeviceAsync(String, String, CancellationToken)`
  * Method `SetPushNotificationTagsForUserAsync(Int32, String, CancellationToken)`

#### SuperOffice.CRM.Services.IPreferenceAgent is Modified

* Deleted items
  * Method `CreateDefaultPreference()`
  * Method `CreateDefaultPreferenceDescription()`
  * Method `CreateDefaultPreferenceDescriptionLine()`
  * Method `DeleteFromSectionAndKey(String, String)`
  * Method `DeletePrefDescLinesByPrefDescId(Int32)`
  * Method `DeletePrefDescLinesByPrefDescIds(Int32[])`
  * Method `DeletePreference(Int32)`
  * Method `DeletePreferenceDescription(Int32)`
  * Method `DeletePreferenceDescriptionLine(Int32)`
  * Method `DeletePreferenceDescriptionLines(Int32[])`
  * Method `DeletePreferences(Int32[])`
  * Method `GetAll()`
  * Method `GetAllFromSection(String)`
  * Method `GetFromSectionAndKey(String, String)`
  * Method `GetNetServicesStatusUrl()`
  * Method `GetPreference(Int32)`
  * Method `GetPreferenceByName(String, String, PreferenceLevel)`
  * Method `GetPreferenceByNameAndId(String, String, PreferenceLevel, Int32)`
  * Method `GetPreferenceDescription(Int32)`
  * Method `GetPreferenceDescriptionLine(Int32)`
  * Method `GetPreferenceDescriptionLineFromIdAndValue(Int32, String)`
  * Method `GetPreferenceDescriptionLinesByPrefDescId(Int32)`
  * Method `GetPreferences(PreferenceSpec[])`
  * Method `GetPreferencesWithDisplayValues(PreferenceSpec[])`
  * Method `GetTabOrder(String)`
  * Method `GetTabOrders()`
  * Method `GetXsrfPaths(String)`
  * Method `SaveFromSectionAndKey(String, String, PreferenceDescription)`
  * Method `SavePreference(Preference)`
  * Method `SavePreferenceDescription(PreferenceDescription)`
  * Method `SavePreferenceDescriptionLine(PreferenceDescriptionLine)`
  * Method `SavePreferenceDescriptionLines(PreferenceDescriptionLine[])`
  * Method `SavePreferenceEntities(Preference[], Boolean)`
  * Method `SavePreferenceEntity(Preference, Boolean)`
  * Method `SavePreferences(Preference[])`
  * Method `SaveTabOrder(TabOrder)`
  * Method `SaveTabOrders(TabOrder[])`
  * Method `SetXsrfPaths(String, String[])`
  * Method `UpdateNetServicesStatus(String)`
* New items
  * Method `CreateDefaultPreferenceAsync(CancellationToken)`
  * Method `CreateDefaultPreferenceDescriptionAsync(CancellationToken)`
  * Method `CreateDefaultPreferenceDescriptionLineAsync(CancellationToken)`
  * Method `DeleteFromSectionAndKeyAsync(String, String, CancellationToken)`
  * Method `DeletePrefDescLinesByPrefDescIdAsync(Int32, CancellationToken)`
  * Method `DeletePrefDescLinesByPrefDescIdsAsync(Int32[], CancellationToken)`
  * Method `DeletePreferenceAsync(Int32, CancellationToken)`
  * Method `DeletePreferenceDescriptionAsync(Int32, CancellationToken)`
  * Method `DeletePreferenceDescriptionLineAsync(Int32, CancellationToken)`
  * Method `DeletePreferenceDescriptionLinesAsync(Int32[], CancellationToken)`
  * Method `DeletePreferencesAsync(Int32[], CancellationToken)`
  * Method `GetAllAsync(CancellationToken)`
  * Method `GetAllFromSectionAsync(String, CancellationToken)`
  * Method `GetFromSectionAndKeyAsync(String, String, CancellationToken)`
  * Method `GetNetServicesStatusUrlAsync(CancellationToken)`
  * Method `GetPreferenceAsync(Int32, CancellationToken)`
  * Method `GetPreferenceByNameAndIdAsync(String, String, PreferenceLevel, Int32, CancellationToken)`
  * Method `GetPreferenceByNameAsync(String, String, PreferenceLevel, CancellationToken)`
  * Method `GetPreferenceDescriptionAsync(Int32, CancellationToken)`
  * Method `GetPreferenceDescriptionLineAsync(Int32, CancellationToken)`
  * Method `GetPreferenceDescriptionLineFromIdAndValueAsync(Int32, String, CancellationToken)`
  * Method `GetPreferenceDescriptionLinesByPrefDescIdAsync(Int32, CancellationToken)`
  * Method `GetPreferencesAsync(PreferenceSpec[], CancellationToken)`
  * Method `GetPreferencesWithDisplayValuesAsync(PreferenceSpec[], CancellationToken)`
  * Method `GetTabOrderAsync(String, CancellationToken)`
  * Method `GetTabOrdersAsync(CancellationToken)`
  * Method `GetXsrfPathsAsync(String, CancellationToken)`
  * Method `SaveFromSectionAndKeyAsync(String, String, PreferenceDescription, CancellationToken)`
  * Method `SavePreferenceAsync(Preference, CancellationToken)`
  * Method `SavePreferenceDescriptionAsync(PreferenceDescription, CancellationToken)`
  * Method `SavePreferenceDescriptionLineAsync(PreferenceDescriptionLine, CancellationToken)`
  * Method `SavePreferenceDescriptionLinesAsync(PreferenceDescriptionLine[], CancellationToken)`
  * Method `SavePreferenceEntitiesAsync(Preference[], Boolean, CancellationToken)`
  * Method `SavePreferenceEntityAsync(Preference, Boolean, CancellationToken)`
  * Method `SavePreferencesAsync(Preference[], CancellationToken)`
  * Method `SaveTabOrderAsync(TabOrder, CancellationToken)`
  * Method `SaveTabOrdersAsync(TabOrder[], CancellationToken)`
  * Method `SetXsrfPathsAsync(String, String[], CancellationToken)`
  * Method `UpdateNetServicesStatusAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.IProjectAgent is Modified

* Deleted items
  * Method `AddProjectMembers(Int32, ProjectMember[])`
  * Method `CreateDefaultProjectEntity()`
  * Method `CreateDefaultProjectEventEntity()`
  * Method `CreateDefaultProjectMember()`
  * Method `CreateNewEntry(DuplicateEntry)`
  * Method `DeleteProjectEntity(Int32)`
  * Method `DeleteProjectEventEntity(Int32)`
  * Method `DeleteProjectEventEntityFromProjectId(Int32)`
  * Method `DeleteProjectMember(Int32)`
  * Method `DeleteProjectMemberByIds(Int32[])`
  * Method `DeleteProjectMembers(Int32, Int32[])`
  * Method `GetDuplicateRules()`
  * Method `GetDuplicates(String)`
  * Method `GetMyMemberProjects()`
  * Method `GetMyProjectEvents()`
  * Method `GetMyProjects(Boolean)`
  * Method `GetMyPublishedProjects()`
  * Method `GetNextMilestone(Int32)`
  * Method `GetNextProjectStatus(Int32)`
  * Method `GetProject(Int32)`
  * Method `GetProjectEntity(Int32)`
  * Method `GetProjectEvent(Int32)`
  * Method `GetProjectEventEntity(Int32)`
  * Method `GetProjectEventEntityFromProjectId(Int32)`
  * Method `GetProjectEventList(Int32[])`
  * Method `GetProjectEventOnPerson(Int32, Int32)`
  * Method `GetProjectEventsOnPerson(Int32)`
  * Method `GetProjectImage(Int32)`
  * Method `GetProjectList(Int32[])`
  * Method `GetProjectMember(Int32)`
  * Method `GetProjectMembers(Int32)`
  * Method `GetProjectMembersById(Int32[])`
  * Method `GetProjectsFromContact(Int32)`
  * Method `GetProjectsFromPerson(Int32)`
  * Method `GetPublishedProject(Int32)`
  * Method `GetPublishedProjects(Int32[])`
  * Method `GetPublishedProjectsOnPersonId(Int32)`
  * Method `HasGuide(Int32)`
  * Method `HasGuideActivities(Int32)`
  * Method `IsNumberValid(Int32, String)`
  * Method `Merge(Int32, Int32, Boolean)`
  * Method `OfferAutoNextStatusOnApppointmentCompleted(Int32)`
  * Method `SaveProjectEntity(ProjectEntity)`
  * Method `SaveProjectEventEntity(ProjectEventEntity)`
  * Method `SaveProjectMember(ProjectMember)`
  * Method `SaveProjectMembersFunctionAndComment(Int32[], Int32, String)`
  * Method `SetDuplicateRulesStatus(DuplicateRule[])`
  * Method `SetProjectImage(Int32, Image)`
  * Method `UpdateProjectMember(ProjectMember)`
  * Method `UpdateProjectMembers(Int32, ProjectMember[])`
  * Method `ValidateProjectEntity(ProjectEntity)`
* New items
  * Method `AddProjectMembersAsync(Int32, ProjectMember[], CancellationToken)`
  * Method `CreateDefaultProjectEntityAsync(CancellationToken)`
  * Method `CreateDefaultProjectEventEntityAsync(CancellationToken)`
  * Method `CreateDefaultProjectMemberAsync(CancellationToken)`
  * Method `CreateNewEntryAsync(DuplicateEntry, CancellationToken)`
  * Method `DeleteProjectEntityAsync(Int32, CancellationToken)`
  * Method `DeleteProjectEventEntityAsync(Int32, CancellationToken)`
  * Method `DeleteProjectEventEntityFromProjectIdAsync(Int32, CancellationToken)`
  * Method `DeleteProjectMemberAsync(Int32, CancellationToken)`
  * Method `DeleteProjectMemberByIdsAsync(Int32[], CancellationToken)`
  * Method `DeleteProjectMembersAsync(Int32, Int32[], CancellationToken)`
  * Method `GetDuplicateRulesAsync(CancellationToken)`
  * Method `GetDuplicatesAsync(String, CancellationToken)`
  * Method `GetMyMemberProjectsAsync(CancellationToken)`
  * Method `GetMyProjectEventsAsync(CancellationToken)`
  * Method `GetMyProjectsAsync(Boolean, CancellationToken)`
  * Method `GetMyPublishedProjectsAsync(CancellationToken)`
  * Method `GetNextMilestoneAsync(Int32, CancellationToken)`
  * Method `GetNextProjectStatusAsync(Int32, CancellationToken)`
  * Method `GetProjectAsync(Int32, CancellationToken)`
  * Method `GetProjectEntityAsync(Int32, CancellationToken)`
  * Method `GetProjectEventAsync(Int32, CancellationToken)`
  * Method `GetProjectEventEntityAsync(Int32, CancellationToken)`
  * Method `GetProjectEventEntityFromProjectIdAsync(Int32, CancellationToken)`
  * Method `GetProjectEventListAsync(Int32[], CancellationToken)`
  * Method `GetProjectEventOnPersonAsync(Int32, Int32, CancellationToken)`
  * Method `GetProjectEventsOnPersonAsync(Int32, CancellationToken)`
  * Method `GetProjectImageAsync(Int32, CancellationToken)`
  * Method `GetProjectListAsync(Int32[], CancellationToken)`
  * Method `GetProjectMemberAsync(Int32, CancellationToken)`
  * Method `GetProjectMembersAsync(Int32, CancellationToken)`
  * Method `GetProjectMembersByIdAsync(Int32[], CancellationToken)`
  * Method `GetProjectsFromContactAsync(Int32, CancellationToken)`
  * Method `GetProjectsFromPersonAsync(Int32, CancellationToken)`
  * Method `GetPublishedProjectAsync(Int32, CancellationToken)`
  * Method `GetPublishedProjectsAsync(Int32[], CancellationToken)`
  * Method `GetPublishedProjectsOnPersonIdAsync(Int32, CancellationToken)`
  * Method `HasGuideActivitiesAsync(Int32, CancellationToken)`
  * Method `HasGuideAsync(Int32, CancellationToken)`
  * Method `IsNumberValidAsync(Int32, String, CancellationToken)`
  * Method `MergeAsync(Int32, Int32, Boolean, CancellationToken)`
  * Method `OfferAutoNextStatusOnApppointmentCompletedAsync(Int32, CancellationToken)`
  * Method `SaveProjectEntityAsync(ProjectEntity, CancellationToken)`
  * Method `SaveProjectEventEntityAsync(ProjectEventEntity, CancellationToken)`
  * Method `SaveProjectMemberAsync(ProjectMember, CancellationToken)`
  * Method `SaveProjectMembersFunctionAndCommentAsync(Int32[], Int32, String, CancellationToken)`
  * Method `SetDuplicateRulesStatusAsync(DuplicateRule[], CancellationToken)`
  * Method `SetProjectImageAsync(Int32, Image, CancellationToken)`
  * Method `UpdateProjectMemberAsync(ProjectMember, CancellationToken)`
  * Method `UpdateProjectMembersAsync(Int32, ProjectMember[], CancellationToken)`
  * Method `ValidateProjectEntityAsync(ProjectEntity, CancellationToken)`

#### SuperOffice.CRM.Services.IQuoteAgent is Modified

* Deleted items
  * Method `AddSaleTypeQuoteAttachment(Int32, Int32)`
  * Method `ApproveQuoteVersion(Int32, String, Int32, String)`
  * Method `CancelApprovalRequest(Int32)`
  * Method `CanConnectorProvideCapability(Int32, String)`
  * Method `CopyQuoteAlternative(Int32, Int32, String)`
  * Method `CopySuperOfficePriceList(Int32, String, DateTime, DateTime, Int32, Boolean)`
  * Method `CreateAndSaveQuote(Int32, Int32, String)`
  * Method `CreateAndSaveQuoteFromSale(Int32, Int32)`
  * Method `CreateAndSaveQuoteLines(Int32, String[])`
  * Method `CreateAndSaveQuoteVersion(Int32)`
  * Method `CreateConnectionFromConnectorName(String)`
  * Method `CreateDefaultPriceList()`
  * Method `CreateDefaultProduct()`
  * Method `CreateDefaultQuoteAlternative()`
  * Method `CreateOrUpdateQuoteVersionAttachments(Int32)`
  * Method `CreateQuoteAlternative(Int32, String, String)`
  * Method `CreateQuoteLine(Int32, String)`
  * Method `CreateQuoteLineFromProduct(Int32, Product)`
  * Method `DeleteConnection(Int32)`
  * Method `DeletePriceList(Int32)`
  * Method `DeleteProduct(Int32)`
  * Method `DeleteQuote(Int32)`
  * Method `DeleteQuoteAlternative(Int32)`
  * Method `DeleteQuoteLine(Int32)`
  * Method `DeleteQuoteLines(Int32[])`
  * Method `DeleteSaleTypeQuoteAttachment(Int32)`
  * Method `FindProduct(Int32, String, String)`
  * Method `GenerateQuoteDocuments(Int32, Int32, Boolean, Int32, Boolean, String)`
  * Method `GetActivePriceLists(Int32, String)`
  * Method `GetActivePriceListsByCurrencyId(Int32, Int32)`
  * Method `GetAllAvailableQuoteConnections()`
  * Method `GetAllAvailableQuoteConnectionsWithPriceLists()`
  * Method `GetAllInstalledQuoteConnections()`
  * Method `GetAllPriceLists(Int32, String)`
  * Method `GetAllPriceListsByCurrencyId(Int32, Int32)`
  * Method `GetAllQuoteLineConfigurations()`
  * Method `GetConfigurationFields(Int32, String)`
  * Method `GetConnection(Int32)`
  * Method `GetConnectionConfigFields(Int32)`
  * Method `GetConnectionsForAssociate(Int32)`
  * Method `GetConnectionStartupErrors()`
  * Method `GetConnectionStartupResponse(Int32)`
  * Method `GetConnectorCapabilities(Int32)`
  * Method `GetConnectorCapabilityNames(Int32)`
  * Method `GetExtraInfo(String)`
  * Method `GetInUseQuoteLineConfigurations()`
  * Method `GetOrderConfirmation(Int32, Int32)`
  * Method `GetOrderState(Int32)`
  * Method `GetPriceList(Int32)`
  * Method `GetProduct(Int32, String)`
  * Method `GetProductFromDbId(Int32)`
  * Method `GetProductImage(Int32, String, Int32)`
  * Method `GetQuote(Int32)`
  * Method `GetQuoteAlternative(Int32)`
  * Method `GetQuoteAlternatives(Int32)`
  * Method `GetQuoteEntity(Int32)`
  * Method `GetQuoteEntityFromSaleId(Int32)`
  * Method `GetQuoteFromSaleId(Int32)`
  * Method `GetQuoteLine(Int32)`
  * Method `GetQuoteLineConfiguration(Int32)`
  * Method `GetQuoteLineConfigurationFromFieldName(String)`
  * Method `GetQuoteLineImage(Int32, Int32)`
  * Method `GetQuoteLines(Int32)`
  * Method `GetQuoteList(String)`
  * Method `GetQuoteVersion(Int32)`
  * Method `GetQuoteVersions(Int32)`
  * Method `GetQuoteVersionWorkflowButtonStates(Int32, Int32)`
  * Method `GetQuoteVersionWorkflowImageState(Int32)`
  * Method `GetQuoteVersionWorkflowState(Int32, Int32)`
  * Method `GetQuoteVersionWorkflowStatusInfo(Int32)`
  * Method `HasConnections()`
  * Method `IncludeQuoteVersionAttachment(Int32, Int32, Boolean)`
  * Method `MoveQuoteLine(Int32, Boolean)`
  * Method `PlaceOrder(Int32, Boolean, String, String, String)`
  * Method `RecalculateQuoteAlternative(Int32)`
  * Method `RecalculateQuoteLine(QuoteLine, String[])`
  * Method `RejectQuoteVersion(Int32, String, Int32, String)`
  * Method `RemoveProduct(Int32)`
  * Method `RequestApproval(Int32, Int32, String)`
  * Method `RestoreConnection(Int32)`
  * Method `SaveConnection(QuoteConnection)`
  * Method `SaveConnectionConfigFields(Int32, StringDictionary)`
  * Method `SavePriceList(PriceList)`
  * Method `SaveProduct(Product)`
  * Method `SaveQuote(Quote)`
  * Method `SaveQuoteAlternative(QuoteAlternative)`
  * Method `SaveQuoteEntity(QuoteEntity)`
  * Method `SaveQuoteLine(QuoteLine)`
  * Method `SaveQuoteLineConfiguration(QuoteLineConfiguration)`
  * Method `SaveQuoteLineConfigurations(QuoteLineConfiguration[])`
  * Method `SaveQuoteLineImage(Int32, Image, Int32)`
  * Method `SaveQuoteLines(QuoteLine[])`
  * Method `SaveQuoteVersion(QuoteVersion)`
  * Method `SaveQuoteVersionNumber(Int32, String)`
  * Method `SendQuoteVersion(Int32, DateTime, DateTime, String, String)`
  * Method `TestConnection(String, StringDictionary)`
  * Method `ToggleProductInAssortment(Int32)`
  * Method `ToggleQuoteVersionAttachmentIncluded(Int32)`
  * Method `ToggleSaleTypeQuoteAttachmentDefaultIncluded(Int32)`
  * Method `UpdateQuoteVersionPrices(Int32)`
  * Method `ValidateQuoteVersion(Int32, QuoteVersionButtonAction)`
* New items
  * Method `AddSaleTypeQuoteAttachmentAsync(Int32, Int32, CancellationToken)`
  * Method `ApproveQuoteVersionAsync(Int32, String, Int32, String, CancellationToken)`
  * Method `CancelApprovalRequestAsync(Int32, CancellationToken)`
  * Method `CanConnectorProvideCapabilityAsync(Int32, String, CancellationToken)`
  * Method `CopyQuoteAlternativeAsync(Int32, Int32, String, CancellationToken)`
  * Method `CopySuperOfficePriceListAsync(Int32, String, DateTime, DateTime, Int32, Boolean, CancellationToken)`
  * Method `CreateAndSaveQuoteAsync(Int32, Int32, String, CancellationToken)`
  * Method `CreateAndSaveQuoteFromSaleAsync(Int32, Int32, CancellationToken)`
  * Method `CreateAndSaveQuoteLinesAsync(Int32, String[], CancellationToken)`
  * Method `CreateAndSaveQuoteVersionAsync(Int32, CancellationToken)`
  * Method `CreateConnectionFromConnectorNameAsync(String, CancellationToken)`
  * Method `CreateDefaultPriceListAsync(CancellationToken)`
  * Method `CreateDefaultProductAsync(CancellationToken)`
  * Method `CreateDefaultQuoteAlternativeAsync(CancellationToken)`
  * Method `CreateOrUpdateQuoteVersionAttachmentsAsync(Int32, CancellationToken)`
  * Method `CreateQuoteAlternativeAsync(Int32, String, String, CancellationToken)`
  * Method `CreateQuoteLineAsync(Int32, String, CancellationToken)`
  * Method `CreateQuoteLineFromProductAsync(Int32, Product, CancellationToken)`
  * Method `DeleteConnectionAsync(Int32, CancellationToken)`
  * Method `DeletePriceListAsync(Int32, CancellationToken)`
  * Method `DeleteProductAsync(Int32, CancellationToken)`
  * Method `DeleteQuoteAlternativeAsync(Int32, CancellationToken)`
  * Method `DeleteQuoteAsync(Int32, CancellationToken)`
  * Method `DeleteQuoteLineAsync(Int32, CancellationToken)`
  * Method `DeleteQuoteLinesAsync(Int32[], CancellationToken)`
  * Method `DeleteSaleTypeQuoteAttachmentAsync(Int32, CancellationToken)`
  * Method `FindProductAsync(Int32, String, String, CancellationToken)`
  * Method `GenerateQuoteDocumentsAsync(Int32, Int32, Boolean, Int32, Boolean, String, CancellationToken)`
  * Method `GetActivePriceListsAsync(Int32, String, CancellationToken)`
  * Method `GetActivePriceListsByCurrencyIdAsync(Int32, Int32, CancellationToken)`
  * Method `GetAllAvailableQuoteConnectionsAsync(CancellationToken)`
  * Method `GetAllAvailableQuoteConnectionsWithPriceListsAsync(CancellationToken)`
  * Method `GetAllInstalledQuoteConnectionsAsync(CancellationToken)`
  * Method `GetAllPriceListsAsync(Int32, String, CancellationToken)`
  * Method `GetAllPriceListsByCurrencyIdAsync(Int32, Int32, CancellationToken)`
  * Method `GetAllQuoteLineConfigurationsAsync(CancellationToken)`
  * Method `GetConfigurationFieldsAsync(Int32, String, CancellationToken)`
  * Method `GetConnectionAsync(Int32, CancellationToken)`
  * Method `GetConnectionConfigFieldsAsync(Int32, CancellationToken)`
  * Method `GetConnectionsForAssociateAsync(Int32, CancellationToken)`
  * Method `GetConnectionStartupErrorsAsync(CancellationToken)`
  * Method `GetConnectionStartupResponseAsync(Int32, CancellationToken)`
  * Method `GetConnectorCapabilitiesAsync(Int32, CancellationToken)`
  * Method `GetConnectorCapabilityNamesAsync(Int32, CancellationToken)`
  * Method `GetExtraInfoAsync(String, CancellationToken)`
  * Method `GetInUseQuoteLineConfigurationsAsync(CancellationToken)`
  * Method `GetOrderConfirmationAsync(Int32, Int32, CancellationToken)`
  * Method `GetOrderStateAsync(Int32, CancellationToken)`
  * Method `GetPriceListAsync(Int32, CancellationToken)`
  * Method `GetProductAsync(Int32, String, CancellationToken)`
  * Method `GetProductFromDbIdAsync(Int32, CancellationToken)`
  * Method `GetProductImageAsync(Int32, String, Int32, CancellationToken)`
  * Method `GetQuoteAlternativeAsync(Int32, CancellationToken)`
  * Method `GetQuoteAlternativesAsync(Int32, CancellationToken)`
  * Method `GetQuoteAsync(Int32, CancellationToken)`
  * Method `GetQuoteEntityAsync(Int32, CancellationToken)`
  * Method `GetQuoteEntityFromSaleIdAsync(Int32, CancellationToken)`
  * Method `GetQuoteFromSaleIdAsync(Int32, CancellationToken)`
  * Method `GetQuoteLineAsync(Int32, CancellationToken)`
  * Method `GetQuoteLineConfigurationAsync(Int32, CancellationToken)`
  * Method `GetQuoteLineConfigurationFromFieldNameAsync(String, CancellationToken)`
  * Method `GetQuoteLinesAsync(Int32, CancellationToken)`
  * Method `GetQuoteVersionAsync(Int32, CancellationToken)`
  * Method `GetQuoteVersionsAsync(Int32, CancellationToken)`
  * Method `GetQuoteVersionWorkflowButtonStatesAsync(Int32, Int32, CancellationToken)`
  * Method `GetQuoteVersionWorkflowImageStateAsync(Int32, CancellationToken)`
  * Method `GetQuoteVersionWorkflowStateAsync(Int32, Int32, CancellationToken)`
  * Method `GetQuoteVersionWorkflowStatusInfoAsync(Int32, CancellationToken)`
  * Method `HasConnectionsAsync(CancellationToken)`
  * Method `IncludeQuoteVersionAttachmentAsync(Int32, Int32, Boolean, CancellationToken)`
  * Method `MoveQuoteLineAsync(Int32, Boolean, CancellationToken)`
  * Method `PlaceOrderAsync(Int32, Boolean, String, String, String, CancellationToken)`
  * Method `RecalculateQuoteAlternativeAsync(Int32, CancellationToken)`
  * Method `RecalculateQuoteLineAsync(QuoteLine, String[], CancellationToken)`
  * Method `RejectQuoteVersionAsync(Int32, String, Int32, String, CancellationToken)`
  * Method `RemoveProductAsync(Int32, CancellationToken)`
  * Method `RequestApprovalAsync(Int32, Int32, String, CancellationToken)`
  * Method `RestoreConnectionAsync(Int32, CancellationToken)`
  * Method `SaveConnectionAsync(QuoteConnection, CancellationToken)`
  * Method `SaveConnectionConfigFieldsAsync(Int32, StringDictionary, CancellationToken)`
  * Method `SavePriceListAsync(PriceList, CancellationToken)`
  * Method `SaveProductAsync(Product, CancellationToken)`
  * Method `SaveQuoteAlternativeAsync(QuoteAlternative, CancellationToken)`
  * Method `SaveQuoteAsync(Quote, CancellationToken)`
  * Method `SaveQuoteEntityAsync(QuoteEntity, CancellationToken)`
  * Method `SaveQuoteLineAsync(QuoteLine, CancellationToken)`
  * Method `SaveQuoteLineConfigurationAsync(QuoteLineConfiguration, CancellationToken)`
  * Method `SaveQuoteLineConfigurationsAsync(QuoteLineConfiguration[], CancellationToken)`
  * Method `SaveQuoteLinesAsync(QuoteLine[], CancellationToken)`
  * Method `SaveQuoteVersionAsync(QuoteVersion, CancellationToken)`
  * Method `SaveQuoteVersionNumberAsync(Int32, String, CancellationToken)`
  * Method `SendQuoteVersionAsync(Int32, DateTime, DateTime, String, String, CancellationToken)`
  * Method `TestConnectionAsync(String, StringDictionary, CancellationToken)`
  * Method `ToggleProductInAssortmentAsync(Int32, CancellationToken)`
  * Method `ToggleQuoteVersionAttachmentIncludedAsync(Int32, CancellationToken)`
  * Method `ToggleSaleTypeQuoteAttachmentDefaultIncludedAsync(Int32, CancellationToken)`
  * Method `UpdateQuoteVersionPricesAsync(Int32, CancellationToken)`
  * Method `ValidateQuoteVersionAsync(Int32, QuoteVersionButtonAction, CancellationToken)`

#### SuperOffice.CRM.Services.IRelationAgent is Modified

* Deleted items
  * Method `CreateDefaultContactRelationEntity()`
  * Method `DeleteContactRelation(Int32)`
  * Method `GetContactRelationEntity(Int32)`
  * Method `SaveContactRelation(ContactRelationEntity)`
* New items
  * Method `CreateDefaultContactRelationEntityAsync(CancellationToken)`
  * Method `DeleteContactRelationAsync(Int32, CancellationToken)`
  * Method `GetContactRelationEntityAsync(Int32, CancellationToken)`
  * Method `SaveContactRelationAsync(ContactRelationEntity, CancellationToken)`

#### SuperOffice.CRM.Services.IReportAgent is Modified

* Deleted items
  * Method `CreateDefaultReportEntity()`
  * Method `CreateDefaultReportLabelLayoutEntity()`
  * Method `CreateFavorite(Int32, String, String)`
  * Method `DeleteFavorite(Int32)`
  * Method `DeleteReport(Int32)`
  * Method `DeleteReportLabelLayoutEntity(Int32)`
  * Method `GenerateReport(Int32, Int32, String, String, String, ArchiveRestrictionInfo[])`
  * Method `GetReportEntity(Int32)`
  * Method `GetReportLabelLayoutEntity(Int32)`
  * Method `ImportReport(String)`
  * Method `SaveReportEntity(ReportEntity)`
  * Method `SaveReportLabelLayoutEntity(ReportLabelLayoutEntity)`
  * Method `UpdateFavorite(ReportEntity)`
* New items
  * Method `CreateDefaultReportLabelLayoutEntityAsync(CancellationToken)`
  * Method `DeleteReportLabelLayoutEntityAsync(Int32, CancellationToken)`
  * Method `GetReportLabelLayoutEntityAsync(Int32, CancellationToken)`
  * Method `SaveReportLabelLayoutEntityAsync(ReportLabelLayoutEntity, CancellationToken)`

#### SuperOffice.CRM.Services.IResourceAgent is Modified

* Deleted items
  * Method `ActivateResourceSubstitution(String, String, Boolean)`
  * Method `DeleteResourceSubstitution(String, String)`
  * Method `GetResourceSubstitutions(String[], String, Boolean)`
  * Method `IsResourceSubstitutionActive(String[], String)`
  * Method `SetResourceSubstitution(String, String, String, Boolean)`
* New items
  * Method `ActivateResourceSubstitutionAsync(String, String, Boolean, CancellationToken)`
  * Method `DeleteResourceSubstitutionAsync(String, String, CancellationToken)`
  * Method `GetResourceSubstitutionsAsync(String[], String, Boolean, CancellationToken)`
  * Method `IsResourceSubstitutionActiveAsync(String[], String, CancellationToken)`
  * Method `SetResourceSubstitutionAsync(String, String, String, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.ISaintAgent is Modified

* Deleted items
  * Method `CreateDefaultSaintConfiguration()`
  * Method `CreateDefaultStatusMonitor()`
  * Method `CreateDefaultStatusMonitorPeriods()`
  * Method `GetSaintConfigurations()`
  * Method `GetStatusMonitor(Int32)`
  * Method `GetStatusMonitorPeriods()`
  * Method `GetStatusMonitors(Int32, String)`
  * Method `RegenerateCounters(Boolean)`
  * Method `RegenerateStatusMonitor(Int32)`
  * Method `RegenerateStatusMonitors(Boolean)`
  * Method `SaveSaintConfiguration(SaintConfiguration)`
  * Method `SaveStatusMonitor(StatusMonitor)`
  * Method `SaveStatusMonitorPeriods(StatusMonitorPeriods)`
  * Method `SetRankOnStatusMonitors(String, Int32[])`
* New items
  * Method `CreateDefaultSaintConfigurationAsync(CancellationToken)`
  * Method `CreateDefaultStatusMonitorAsync(CancellationToken)`
  * Method `CreateDefaultStatusMonitorPeriodsAsync(CancellationToken)`
  * Method `GetSaintConfigurationsAsync(CancellationToken)`
  * Method `GetStatusMonitorAsync(Int32, CancellationToken)`
  * Method `GetStatusMonitorPeriodsAsync(CancellationToken)`
  * Method `GetStatusMonitorsAsync(Int32, String, CancellationToken)`
  * Method `RegenerateCountersAsync(Boolean, CancellationToken)`
  * Method `RegenerateStatusMonitorAsync(Int32, CancellationToken)`
  * Method `RegenerateStatusMonitorsAsync(Boolean, CancellationToken)`
  * Method `SaveSaintConfigurationAsync(SaintConfiguration, CancellationToken)`
  * Method `SaveStatusMonitorAsync(StatusMonitor, CancellationToken)`
  * Method `SaveStatusMonitorPeriodsAsync(StatusMonitorPeriods, CancellationToken)`
  * Method `SetRankOnStatusMonitorsAsync(String, Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.ISaleAgent is Modified

* Deleted items
  * Method `AddSaleStakeholders(Int32, SaleStakeholder[])`
  * Method `BatchUpdateNextDueDate()`
  * Method `CreateDefaultSaleEntity()`
  * Method `CreateDefaultSaleStakeholder()`
  * Method `CreateDefaultSaleSummary()`
  * Method `DeleteSaleEntity(Int32)`
  * Method `DeleteSaleStakeholder(Int32)`
  * Method `DeleteSaleStakeholders(Int32[])`
  * Method `GetMyOpportunities(Int32)`
  * Method `GetNextDueDate(Int32)`
  * Method `GetNextSaleStage(Int32, Boolean)`
  * Method `GetOpenSalesForContact(Int32)`
  * Method `GetProbabilityFromStage(Int32)`
  * Method `GetRecentSales(Int32, Int32)`
  * Method `GetSale(Int32)`
  * Method `GetSaleEntity(Int32)`
  * Method `GetSaleList(Int32[])`
  * Method `GetSalesByDate(DateTime, DateTime, Int32, SaleStatus)`
  * Method `GetSalesFromContact(Int32, Boolean)`
  * Method `GetSalesFromPerson(Int32, Boolean)`
  * Method `GetSaleStakeholder(Int32)`
  * Method `GetSaleStakeholderById(Int32[])`
  * Method `GetSaleStakeholderList(Int32[])`
  * Method `GetSaleStakeholders(Int32)`
  * Method `GetSummaryByAssociate(Int32, DateTime, DateTime)`
  * Method `GetSummaryByContact(Int32, DateTime, DateTime)`
  * Method `GetSummaryByGroup(Int32, DateTime, DateTime)`
  * Method `GetUpcomingSales(Int32, Int32)`
  * Method `HasGuide(Int32)`
  * Method `HasGuideActivities(Int32)`
  * Method `HasStakeholderSetting(Int32)`
  * Method `IsNumberValid(Int32, String)`
  * Method `OfferAutoNextStageOnApppointmentCompleted(Int32)`
  * Method `SaleHasQuote(Int32)`
  * Method `SaveSaleEntity(SaleEntity)`
  * Method `SaveSaleStakeholder(SaleStakeholder)`
  * Method `SetAsLost(Int32[])`
  * Method `SetAsLostWithReason(Int32[], Int32)`
  * Method `SetAsSold(Int32[])`
  * Method `SetAsSoldWithReason(Int32[], Int32)`
  * Method `UpdateSaleStakeholders(SaleStakeholder[])`
  * Method `ValidateSaleEntity(SaleEntity)`
* New items
  * Method `AddSaleStakeholdersAsync(Int32, SaleStakeholder[], CancellationToken)`
  * Method `BatchUpdateNextDueDateAsync(CancellationToken)`
  * Method `CreateDefaultSaleEntityAsync(CancellationToken)`
  * Method `CreateDefaultSaleStakeholderAsync(CancellationToken)`
  * Method `CreateDefaultSaleSummaryAsync(CancellationToken)`
  * Method `DeleteSaleEntityAsync(Int32, CancellationToken)`
  * Method `DeleteSaleStakeholderAsync(Int32, CancellationToken)`
  * Method `DeleteSaleStakeholdersAsync(Int32[], CancellationToken)`
  * Method `GetMyOpportunitiesAsync(Int32, CancellationToken)`
  * Method `GetNextDueDateAsync(Int32, CancellationToken)`
  * Method `GetNextSaleStageAsync(Int32, Boolean, CancellationToken)`
  * Method `GetOpenSalesForContactAsync(Int32, CancellationToken)`
  * Method `GetProbabilityFromStageAsync(Int32, CancellationToken)`
  * Method `GetRecentSalesAsync(Int32, Int32, CancellationToken)`
  * Method `GetSaleAsync(Int32, CancellationToken)`
  * Method `GetSaleEntityAsync(Int32, CancellationToken)`
  * Method `GetSaleListAsync(Int32[], CancellationToken)`
  * Method `GetSalesByDateAsync(DateTime, DateTime, Int32, SaleStatus, CancellationToken)`
  * Method `GetSalesFromContactAsync(Int32, Boolean, CancellationToken)`
  * Method `GetSalesFromPersonAsync(Int32, Boolean, CancellationToken)`
  * Method `GetSaleStakeholderAsync(Int32, CancellationToken)`
  * Method `GetSaleStakeholderByIdAsync(Int32[], CancellationToken)`
  * Method `GetSaleStakeholderListAsync(Int32[], CancellationToken)`
  * Method `GetSaleStakeholdersAsync(Int32, CancellationToken)`
  * Method `GetSummaryByAssociateAsync(Int32, DateTime, DateTime, CancellationToken)`
  * Method `GetSummaryByContactAsync(Int32, DateTime, DateTime, CancellationToken)`
  * Method `GetSummaryByGroupAsync(Int32, DateTime, DateTime, CancellationToken)`
  * Method `GetUpcomingSalesAsync(Int32, Int32, CancellationToken)`
  * Method `HasGuideActivitiesAsync(Int32, CancellationToken)`
  * Method `HasGuideAsync(Int32, CancellationToken)`
  * Method `HasStakeholderSettingAsync(Int32, CancellationToken)`
  * Method `IsNumberValidAsync(Int32, String, CancellationToken)`
  * Method `OfferAutoNextStageOnApppointmentCompletedAsync(Int32, CancellationToken)`
  * Method `SaleHasQuoteAsync(Int32, CancellationToken)`
  * Method `SaveSaleEntityAsync(SaleEntity, CancellationToken)`
  * Method `SaveSaleStakeholderAsync(SaleStakeholder, CancellationToken)`
  * Method `SetAsLostAsync(Int32[], CancellationToken)`
  * Method `SetAsLostWithReasonAsync(Int32[], Int32, CancellationToken)`
  * Method `SetAsSoldAsync(Int32[], CancellationToken)`
  * Method `SetAsSoldWithReasonAsync(Int32[], Int32, CancellationToken)`
  * Method `UpdateSaleStakeholdersAsync(SaleStakeholder[], CancellationToken)`
  * Method `ValidateSaleEntityAsync(SaleEntity, CancellationToken)`

#### SuperOffice.CRM.Services.ISelectionAgent is Modified

* Deleted items
  * Method `AddContactSelectionMembers(Int32, ContactPersonId[])`
  * Method `AddContactSelectionMembersFromSearch(Int32, String)`
  * Method `AddRemoveContactSelectionMemberInterests(Int32, Int32[], Int32[], Int32[], Int32[])`
  * Method `AddSelectionMembers(Int32, Int32[])`
  * Method `AddSelectionMembersFromSearch(Int32, String)`
  * Method `CopyContactSelectionMembers(Int32, Int32)`
  * Method `CopySelectionMembers(Int32, Int32)`
  * Method `CreateContactSelectionFromSelection(Int32, String, SelectionType, Boolean)`
  * Method `CreateContactSelectionFromShadowSelection(Int32, String)`
  * Method `CreateDefaultMailMergeSettings()`
  * Method `CreateDefaultMailMergeTask()`
  * Method `CreateDefaultSelectionEntity()`
  * Method `CreateNewEntry(DuplicateEntry)`
  * Method `CreateSelectionEntity(String)`
  * Method `CreateSelectionFromSelection(Int32, String, SelectionType, Boolean)`
  * Method `CreateTemporaryContactSelection()`
  * Method `CreateTemporaryContactSelectionFromContactPersonIds(ContactPersonId[])`
  * Method `CreateTemporaryContactSelectionFromProjectMembers(Int32)`
  * Method `CreateTemporaryContactSelectionFromSelectionMemberIds(Int32, Int32[])`
  * Method `CreateTemporarySelectionFromIds(Int32[], Int32)`
  * Method `DeleteContacts(Int32)`
  * Method `DeleteEntities(Int32)`
  * Method `DeletePersons(Int32)`
  * Method `DeleteSelectionEntity(Int32)`
  * Method `EditContactSelectionMemberDetails(Int32, SelectionMemberEditValues)`
  * Method `ExportSelectionMembers(Int32, String, Boolean)`
  * Method `ExportSelectionMembersWithOrderBy(Int32, String, Boolean, String)`
  * Method `GenerateFollowUps(Int32, AppointmentEntity, Int32, Boolean, Boolean)`
  * Method `GetDuplicateRules()`
  * Method `GetDuplicates(String)`
  * Method `GetDynamicSelectionCriteria(Int32)`
  * Method `GetDynamicSelectionCriteriaGroups(Int32)`
  * Method `GetParentCombinedSelections(Int32)`
  * Method `GetRecipientStatistics(Int32)`
  * Method `GetRecipientStatisticsFromContactPersonIds(ContactPersonId[])`
  * Method `GetRecipientStatisticsFromProjectMembers(Int32)`
  * Method `GetSelectionEntity(Int32)`
  * Method `GetSelectionForFind(String, Int32)`
  * Method `GetSelectionMembersArchiveRows(Int32, String)`
  * Method `GetSelectionShadowMembersArchiveRows(Int32, String)`
  * Method `GetSelectionSummaries(Int32[])`
  * Method `RemoveContactSelectionMembers(Int32, ContactPersonId[])`
  * Method `RemoveContactSelectionMembersFromIds(Int32, Int32[])`
  * Method `RemoveContactSelectionMembersFromSearch(Int32, String)`
  * Method `RemoveSelectionMembers(Int32, Int32[])`
  * Method `RemoveSelectionMembersById(Int32, Int32[])`
  * Method `RemoveSelectionMembersFromSearch(Int32, String)`
  * Method `SaveSelectionEntity(SelectionEntity)`
  * Method `SetDuplicateRulesStatus(DuplicateRule[])`
  * Method `SetDynamicSelectionCriteria(Int32, ArchiveRestrictionInfo[])`
  * Method `SetDynamicSelectionCriteria2(Int32, String)`
  * Method `SetDynamicSelectionCriteria3(Int32, ArchiveRestrictionInfo[], String)`
  * Method `SetDynamicSelectionCriteriaGroups(Int32, ArchiveRestrictionGroup[])`
  * Method `StartMailMerge(MailMergeSettings)`
  * Method `UpdateTypicalSearch(TypicalSearches)`
* New items
  * Method `AddContactSelectionMembersAsync(Int32, ContactPersonId[], CancellationToken)`
  * Method `AddContactSelectionMembersFromSearchAsync(Int32, String, CancellationToken)`
  * Method `AddRemoveContactSelectionMemberInterestsAsync(Int32, Int32[], Int32[], Int32[], Int32[], CancellationToken)`
  * Method `AddSelectionMembersAsync(Int32, Int32[], CancellationToken)`
  * Method `AddSelectionMembersFromSearchAsync(Int32, String, CancellationToken)`
  * Method `CopyContactSelectionMembersAsync(Int32, Int32, CancellationToken)`
  * Method `CopySelectionMembersAsync(Int32, Int32, CancellationToken)`
  * Method `CreateContactSelectionFromSelectionAsync(Int32, String, SelectionType, Boolean, CancellationToken)`
  * Method `CreateContactSelectionFromShadowSelectionAsync(Int32, String, CancellationToken)`
  * Method `CreateDefaultSelectionEntityAsync(CancellationToken)`
  * Method `CreateNewEntryAsync(DuplicateEntry, CancellationToken)`
  * Method `CreateSelectionEntityAsync(String, CancellationToken)`
  * Method `CreateSelectionFromSelectionAsync(Int32, String, SelectionType, Boolean, CancellationToken)`
  * Method `CreateTemporaryContactSelectionAsync(CancellationToken)`
  * Method `CreateTemporaryContactSelectionFromContactPersonIdsAsync(ContactPersonId[], CancellationToken)`
  * Method `CreateTemporaryContactSelectionFromSelectionMemberIdsAsync(Int32, Int32[], CancellationToken)`
  * Method `CreateTemporarySelectionFromIdsAsync(Int32[], Int32, CancellationToken)`
  * Method `DeleteContactsAsync(Int32, CancellationToken)`
  * Method `DeleteEntitiesAsync(Int32, CancellationToken)`
  * Method `DeletePersonsAsync(Int32, CancellationToken)`
  * Method `DeleteSelectionEntityAsync(Int32, CancellationToken)`
  * Method `EditContactSelectionMemberDetailsAsync(Int32, SelectionMemberEditValues, CancellationToken)`
  * Method `ExportSelectionMembersAsync(Int32, String, Boolean, CancellationToken)`
  * Method `ExportSelectionMembersWithOrderByAsync(Int32, String, Boolean, String, CancellationToken)`
  * Method `GenerateFollowUpsAsync(Int32, AppointmentEntity, Int32, Boolean, Boolean, CancellationToken)`
  * Method `GetDuplicateRulesAsync(CancellationToken)`
  * Method `GetDuplicatesAsync(String, CancellationToken)`
  * Method `GetDynamicSelectionCriteriaAsync(Int32, CancellationToken)`
  * Method `GetDynamicSelectionCriteriaGroupsAsync(Int32, CancellationToken)`
  * Method `GetParentCombinedSelectionsAsync(Int32, CancellationToken)`
  * Method `GetRecipientStatisticsAsync(Int32, CancellationToken)`
  * Method `GetRecipientStatisticsFromContactPersonIdsAsync(ContactPersonId[], CancellationToken)`
  * Method `GetRecipientStatisticsFromProjectMembersAsync(Int32, CancellationToken)`
  * Method `GetSelectionEntityAsync(Int32, CancellationToken)`
  * Method `GetSelectionForFindAsync(String, Int32, CancellationToken)`
  * Method `GetSelectionMembersArchiveRowsAsync(Int32, String, CancellationToken)`
  * Method `GetSelectionShadowMembersArchiveRowsAsync(Int32, String, CancellationToken)`
  * Method `GetSelectionSummariesAsync(Int32[], CancellationToken)`
  * Method `RemoveContactSelectionMembersAsync(Int32, ContactPersonId[], CancellationToken)`
  * Method `RemoveContactSelectionMembersFromIdsAsync(Int32, Int32[], CancellationToken)`
  * Method `RemoveContactSelectionMembersFromSearchAsync(Int32, String, CancellationToken)`
  * Method `RemoveSelectionMembersAsync(Int32, Int32[], CancellationToken)`
  * Method `RemoveSelectionMembersByIdAsync(Int32, Int32[], CancellationToken)`
  * Method `RemoveSelectionMembersFromSearchAsync(Int32, String, CancellationToken)`
  * Method `SaveSelectionEntityAsync(SelectionEntity, CancellationToken)`
  * Method `SetDuplicateRulesStatusAsync(DuplicateRule[], CancellationToken)`
  * Method `SetDynamicSelectionCriteria2Async(Int32, String, CancellationToken)`
  * Method `SetDynamicSelectionCriteria3Async(Int32, ArchiveRestrictionInfo[], String, CancellationToken)`
  * Method `SetDynamicSelectionCriteriaAsync(Int32, ArchiveRestrictionInfo[], CancellationToken)`
  * Method `SetDynamicSelectionCriteriaGroupsAsync(Int32, ArchiveRestrictionGroup[], CancellationToken)`
  * Method `UpdateTypicalSearchAsync(TypicalSearches, CancellationToken)`

#### SuperOffice.CRM.Services.ISentryAgent is Modified

* Deleted items
  * Method `CanCreateAppointmentInAllDiaries()`
  * Method `CanCreateAppointmentInAssociateDiaries(Int32[])`
  * Method `CanCreateAppointmentInEachAssociatesDiary(Int32[])`
  * Method `GetFunctionRights()`
  * Method `GetNewTableRight(String)`
  * Method `GetTableRightByContactOwnership(String, Int32)`
  * Method `GetTableRightByOwnership(String, Int32, Int32)`
  * Method `HasFunctionRight(String)`
* New items
  * Method `CanCreateAppointmentInAllDiariesAsync(CancellationToken)`
  * Method `CanCreateAppointmentInAssociateDiariesAsync(Int32[], CancellationToken)`
  * Method `CanCreateAppointmentInEachAssociatesDiaryAsync(Int32[], CancellationToken)`
  * Method `GetFunctionRightsAsync(CancellationToken)`
  * Method `GetNewTableRightAsync(String, CancellationToken)`
  * Method `GetTableRightByContactOwnershipAsync(String, Int32, CancellationToken)`
  * Method `GetTableRightByOwnershipAsync(String, Int32, Int32, CancellationToken)`
  * Method `HasFunctionRightAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.ITargetsAgent is Modified

* Deleted items
  * Method `CreateDefaultTargetAssignment()`
  * Method `CreateDefaultTargetAssignmentForCompany()`
  * Method `CreateDefaultTargetAssignmentForCompanyWithDimension(Int32)`
  * Method `CreateDefaultTargetAssignmentForCompanyWithYearAndDimension(Int32, Int32)`
  * Method `CreateDefaultTargetAssignmentForUserGroup(Int32)`
  * Method `CreateDefaultTargetAssignmentForUserGroupWithDimension(Int32, Int32)`
  * Method `CreateDefaultTargetAssignmentForUserGroupWithYearAndDimension(Int32, Int32, Int32)`
  * Method `CreateDefaultTargetDimension()`
  * Method `CreateDefaultTargetGroup()`
  * Method `CreateDefaultTargetRevision()`
  * Method `CreateDefaultTargetRevisionHistory()`
  * Method `DeleteTargetDimension(Int32)`
  * Method `DeleteTargetGroup(Int32)`
  * Method `ExportTargetGroupToExcel(Int32)`
  * Method `GetTargetAssignmentForYear(Int32, TargetEntityType, TargetLevel, Int32)`
  * Method `GetTargetAssignmentForYearAndDimension(Int32, TargetEntityType, TargetLevel, Int32, Int32)`
  * Method `GetTargetDimension(Int32)`
  * Method `GetTargetDimensionsForEntityType(TargetEntityType)`
  * Method `GetTargetGroup(Int32)`
  * Method `GetTargetGroupForYear(Int32, TargetEntityType)`
  * Method `GetTargetGroupForYearAndDimension(Int32, Int32)`
  * Method `GetTargetGroupIds(Int32)`
  * Method `GetTargetRevisionHistory(Int32)`
  * Method `SaveTargetDimension(TargetDimension)`
  * Method `SaveTargetGroup(TargetGroup)`
* New items
  * Method `CreateDefaultTargetAssignmentAsync(CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForCompanyAsync(CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForCompanyWithDimensionAsync(Int32, CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionAsync(Int32, Int32, CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForUserGroupAsync(Int32, CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForUserGroupWithDimensionAsync(Int32, Int32, CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `CreateDefaultTargetDimensionAsync(CancellationToken)`
  * Method `CreateDefaultTargetGroupAsync(CancellationToken)`
  * Method `CreateDefaultTargetRevisionAsync(CancellationToken)`
  * Method `CreateDefaultTargetRevisionHistoryAsync(CancellationToken)`
  * Method `DeleteTargetDimensionAsync(Int32, CancellationToken)`
  * Method `DeleteTargetGroupAsync(Int32, CancellationToken)`
  * Method `ExportTargetGroupToExcelAsync(Int32, CancellationToken)`
  * Method `GetTargetAssignmentForYearAndDimensionAsync(Int32, TargetEntityType, TargetLevel, Int32, Int32, CancellationToken)`
  * Method `GetTargetAssignmentForYearAsync(Int32, TargetEntityType, TargetLevel, Int32, CancellationToken)`
  * Method `GetTargetDimensionAsync(Int32, CancellationToken)`
  * Method `GetTargetDimensionsForEntityTypeAsync(TargetEntityType, CancellationToken)`
  * Method `GetTargetGroupAsync(Int32, CancellationToken)`
  * Method `GetTargetGroupForYearAndDimensionAsync(Int32, Int32, CancellationToken)`
  * Method `GetTargetGroupForYearAsync(Int32, TargetEntityType, CancellationToken)`
  * Method `GetTargetGroupIdsAsync(Int32, CancellationToken)`
  * Method `GetTargetRevisionHistoryAsync(Int32, CancellationToken)`
  * Method `SaveTargetDimensionAsync(TargetDimension, CancellationToken)`
  * Method `SaveTargetGroupAsync(TargetGroup, CancellationToken)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* Deleted items
  * Method `AddAttachments(Int32, Int32[])`
  * Method `BatchForward(Int32[], String[], String[], String[], String, Boolean)`
  * Method `BatchReply(TicketBatchReplyData)`
  * Method `CalculateMessageRecipients(Int32, MessageActionType, Int32)`
  * Method `ClearNotify(Int32[])`
  * Method `CopyFromCRMDocument(Int32)`
  * Method `CopyToTempFile(String, Int32)`
  * Method `CreateDefaultAttachmentEntity()`
  * Method `CreateDefaultForTicketType(Int32)`
  * Method `CreateDefaultTicketEntity()`
  * Method `CreateDefaultTicketMessageEntity()`
  * Method `DeleteMessageHeaders(Int32[])`
  * Method `DeleteTicketEntity(Int32)`
  * Method `DeleteTicketMessageEntity(Int32)`
  * Method `DoEscalating(Int32, TicketPriorityEscalateAction)`
  * Method `GetAttachmentEntity(Int32)`
  * Method `GetAttachmentInfo(Int32)`
  * Method `GetAttachmentInfoNonInline(Int32)`
  * Method `GetAttachmentPreview(Int32)`
  * Method `GetAttachmentStream(Int32)`
  * Method `GetDefaultMessageContent(Int32, MessageActionType, Int32)`
  * Method `GetDefaultMessageContentFull(Int32, MessageActionType, Int32, Int32)`
  * Method `GetDefaultMessageContentWithOptions(Int32, MessageActionType, Int32, Int32, Boolean)`
  * Method `GetForRmUi(Int32)`
  * Method `GetHotlistEjUsers(Int32, Int32[], NotifyType, NotifyChannel)`
  * Method `GetNextInQueue()`
  * Method `GetPreviewAttachmentStream(Int32)`
  * Method `GetRfcAttachmentStream(Int32, Int32)`
  * Method `GetTicket(Int32)`
  * Method `GetTicketAttachments(Int32)`
  * Method `GetTicketEntity(Int32)`
  * Method `GetTicketMessage(Int32)`
  * Method `GetTicketMessageEntities(Int32, Int32[])`
  * Method `GetTicketMessageEntity(Int32)`
  * Method `GetTicketMessageWithEmbeddedData(Int32, ImageEmbedType)`
  * Method `GetTicketMessageWithOptions(Int32, Boolean)`
  * Method `GetTickets(Int32[])`
  * Method `GetTicketSummaries(Int32[])`
  * Method `Html2Text(String)`
  * Method `MergeTickets(TicketEntity, Int32[])`
  * Method `NotifyNewTicket(Int32)`
  * Method `NotifyNewTicketMessage(Int32)`
  * Method `ProcessTicketWhenRead(Int32)`
  * Method `RemoveMessageAttachments(Int32, Int32[])`
  * Method `ResolveTicketId(Int32)`
  * Method `SanitizeMailContent(String)`
  * Method `SanitizeMailContents(String[])`
  * Method `SanitizeMailContentWithOptions(String, HtmlSanitizerOptions)`
  * Method `SaveAttachmentEntity(AttachmentEntity)`
  * Method `SaveTicketEntity(TicketEntity)`
  * Method `SaveTicketEntityWithNotify(TicketEntity, Boolean)`
  * Method `SaveTicketMessageEntity(TicketMessageEntity)`
  * Method `SaveTicketMessageEntityWithNotify(TicketMessageEntity, Boolean)`
  * Method `SaveTicketMessageEntityWithOptions(TicketMessageEntity, Boolean, Int32[], Boolean)`
  * Method `SendTicketMessage(Int32, String[], String[], String[], String, Int32, String)`
  * Method `SendTicketMessageSms(Int32, Int32, String[])`
  * Method `SetDeletedStatusByIds(Int32[])`
  * Method `SetDeletedStatusByProvider(String, ArchiveRestrictionInfo[])`
  * Method `SetTicketMessageImportant(Int32, Boolean)`
  * Method `SetTicketReadByOwner(Int32, TicketReadStatus, Boolean)`
  * Method `SplitTicket(Int32, Int32, DateTime, Int32[], TicketEntity)`
  * Method `SplitTicketMessage(TicketMessageEntity, TicketEntity, TicketMessageEntity, Int32[])`
  * Method `UndeleteByIds(Int32[])`
  * Method `UpdateTicketsReadStatus(Int32[], TicketReadStatus)`
  * Method `UpdateTicketsReadStatusByProvider(String, ArchiveRestrictionInfo[], TicketReadStatus)`
  * Method `UploadAttachment(Int32, Stream)`
  * Method `ValidateAttachments(Int32[])`
* New items
  * Method `AddAttachmentsAsync(Int32, Int32[], CancellationToken)`
  * Method `BatchForwardAsync(Int32[], String[], String[], String[], String, Boolean, CancellationToken)`
  * Method `BatchReplyAsync(TicketBatchReplyData, CancellationToken)`
  * Method `CalculateMessageRecipientsAsync(Int32, MessageActionType, Int32, CancellationToken)`
  * Method `ClearNotifyAsync(Int32[], CancellationToken)`
  * Method `CopyFromCRMDocumentAsync(Int32, CancellationToken)`
  * Method `CopyToTempFileAsync(String, Int32, CancellationToken)`
  * Method `CreateDefaultAttachmentEntityAsync(CancellationToken)`
  * Method `CreateDefaultForTicketTypeAsync(Int32, CancellationToken)`
  * Method `CreateDefaultTicketEntityAsync(CancellationToken)`
  * Method `CreateDefaultTicketMessageEntityAsync(CancellationToken)`
  * Method `DeleteMessageHeadersAsync(Int32[], CancellationToken)`
  * Method `DeleteTicketEntityAsync(Int32, CancellationToken)`
  * Method `DeleteTicketMessageEntityAsync(Int32, CancellationToken)`
  * Method `DoEscalatingAsync(Int32, TicketPriorityEscalateAction, CancellationToken)`
  * Method `GetAttachmentEntityAsync(Int32, CancellationToken)`
  * Method `GetAttachmentInfoAsync(Int32, CancellationToken)`
  * Method `GetAttachmentInfoNonInlineAsync(Int32, CancellationToken)`
  * Method `GetAttachmentPreviewAsync(Int32, CancellationToken)`
  * Method `GetAttachmentStreamAsync(Int32, CancellationToken)`
  * Method `GetDefaultMessageContentAsync(Int32, MessageActionType, Int32, CancellationToken)`
  * Method `GetDefaultMessageContentFullAsync(Int32, MessageActionType, Int32, Int32, CancellationToken)`
  * Method `GetDefaultMessageContentWithOptionsAsync(Int32, MessageActionType, Int32, Int32, Boolean, CancellationToken)`
  * Method `GetForRmUiAsync(Int32, CancellationToken)`
  * Method `GetHotlistEjUsersAsync(Int32, Int32[], NotifyType, NotifyChannel, CancellationToken)`
  * Method `GetNextInQueueAsync(CancellationToken)`
  * Method `GetPreviewAttachmentStreamAsync(Int32, CancellationToken)`
  * Method `GetRfcAttachmentStreamAsync(Int32, Int32, CancellationToken)`
  * Method `GetTicketAsync(Int32, CancellationToken)`
  * Method `GetTicketAttachmentsAsync(Int32, CancellationToken)`
  * Method `GetTicketEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketMessageAsync(Int32, CancellationToken)`
  * Method `GetTicketMessageEntitiesAsync(Int32, Int32[], CancellationToken)`
  * Method `GetTicketMessageEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketMessageWithEmbeddedDataAsync(Int32, ImageEmbedType, CancellationToken)`
  * Method `GetTicketMessageWithOptionsAsync(Int32, Boolean, CancellationToken)`
  * Method `GetTicketsAsync(Int32[], CancellationToken)`
  * Method `GetTicketSummariesAsync(Int32[], CancellationToken)`
  * Method `Html2TextAsync(String, CancellationToken)`
  * Method `MergeTicketsAsync(TicketEntity, Int32[], CancellationToken)`
  * Method `NotifyNewTicketAsync(Int32, CancellationToken)`
  * Method `NotifyNewTicketMessageAsync(Int32, CancellationToken)`
  * Method `ProcessTicketWhenReadAsync(Int32, CancellationToken)`
  * Method `RemoveMessageAttachmentsAsync(Int32, Int32[], CancellationToken)`
  * Method `ResolveTicketIdAsync(Int32, CancellationToken)`
  * Method `SanitizeMailContentAsync(String, CancellationToken)`
  * Method `SanitizeMailContentsAsync(String[], CancellationToken)`
  * Method `SanitizeMailContentWithOptionsAsync(String, HtmlSanitizerOptions, CancellationToken)`
  * Method `SaveAttachmentEntityAsync(AttachmentEntity, CancellationToken)`
  * Method `SaveTicketEntityAsync(TicketEntity, CancellationToken)`
  * Method `SaveTicketEntityWithNotifyAsync(TicketEntity, Boolean, CancellationToken)`
  * Method `SaveTicketMessageEntityAsync(TicketMessageEntity, CancellationToken)`
  * Method `SaveTicketMessageEntityWithNotifyAsync(TicketMessageEntity, Boolean, CancellationToken)`
  * Method `SaveTicketMessageEntityWithOptionsAsync(TicketMessageEntity, Boolean, Int32[], Boolean, CancellationToken)`
  * Method `SendTicketMessageAsync(Int32, String[], String[], String[], String, Int32, String, CancellationToken)`
  * Method `SendTicketMessageSmsAsync(Int32, Int32, String[], CancellationToken)`
  * Method `SetDeletedStatusByIdsAsync(Int32[], CancellationToken)`
  * Method `SetDeletedStatusByProviderAsync(String, ArchiveRestrictionInfo[], CancellationToken)`
  * Method `SetTicketMessageImportantAsync(Int32, Boolean, CancellationToken)`
  * Method `SetTicketReadByOwnerAsync(Int32, TicketReadStatus, Boolean, CancellationToken)`
  * Method `SplitTicketAsync(Int32, Int32, DateTime, Int32[], TicketEntity, CancellationToken)`
  * Method `SplitTicketMessageAsync(TicketMessageEntity, TicketEntity, TicketMessageEntity, Int32[], CancellationToken)`
  * Method `UndeleteByIdsAsync(Int32[], CancellationToken)`
  * Method `UpdateTicketsReadStatusAsync(Int32[], TicketReadStatus, CancellationToken)`
  * Method `UpdateTicketsReadStatusByProviderAsync(String, ArchiveRestrictionInfo[], TicketReadStatus, CancellationToken)`
  * Method `UploadAttachmentAsync(Int32, Stream, CancellationToken)`
  * Method `ValidateAttachmentsAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.ITimeZoneAgent is Modified

* Deleted items
  * Method `CheckNewTimeZoneDataAvailable()`
  * Method `DeleteTimeZones()`
  * Method `GetBaseTimeZoneId()`
  * Method `GetDefaultTimeZoneInformation()`
  * Method `GetDefaultTimeZonePreference()`
  * Method `InitializeTimeZoneData()`
  * Method `SetActiveTimeZoneRow(Int32, Boolean)`
  * Method `SetActiveTimeZonesByFilter(String, Boolean)`
  * Method `SetBaseTimeZoneId(Int32)`
  * Method `TimeOfLastTimeZoneUpdate()`
  * Method `ToggleActiveTimeZoneRow(Int32)`
  * Method `UpdateTimeZoneData()`
* New items
  * Method `CheckNewTimeZoneDataAvailableAsync(CancellationToken)`
  * Method `DeleteTimeZonesAsync(CancellationToken)`
  * Method `GetBaseTimeZoneIdAsync(CancellationToken)`
  * Method `GetDefaultTimeZoneInformationAsync(CancellationToken)`
  * Method `GetDefaultTimeZonePreferenceAsync(CancellationToken)`
  * Method `InitializeTimeZoneDataAsync(CancellationToken)`
  * Method `SetActiveTimeZoneRowAsync(Int32, Boolean, CancellationToken)`
  * Method `SetActiveTimeZonesByFilterAsync(String, Boolean, CancellationToken)`
  * Method `SetBaseTimeZoneIdAsync(Int32, CancellationToken)`
  * Method `TimeOfLastTimeZoneUpdateAsync(CancellationToken)`
  * Method `ToggleActiveTimeZoneRowAsync(Int32, CancellationToken)`
  * Method `UpdateTimeZoneDataAsync(CancellationToken)`

#### SuperOffice.CRM.Services.IUserAgent is Modified

* Deleted items
  * Method `AddOwnerContact(Int32)`
  * Method `CanChangePassword(Int32)`
  * Method `ChangeOwnPassword(String, String)`
  * Method `ChangePassword(Int32, String, String)`
  * Method `ChangePasswordFromName(String, String, String)`
  * Method `ChangeUserType(User, UserType)`
  * Method `CheckAccessGatewayRegistration()`
  * Method `CreateDefaultRoleEntity()`
  * Method `CreateDefaultRoleEntityFromType(RoleType)`
  * Method `CreateDefaultServiceAuth()`
  * Method `CreateDefaultUntrustedCredentials()`
  * Method `CreateDefaultUser()`
  * Method `CreateDefaultUserFromUserType(UserType)`
  * Method `CreateDefaultUserFromUserTypeAndCredential(UserType, Int32, String, String, String)`
  * Method `CreateDefaultUserFromUserTypeAndPersonId(UserType, Int32)`
  * Method `CreateExternalUser(Int32, String, String, Int32, Boolean)`
  * Method `CreateUserGroup()`
  * Method `DecryptAndSaveExternalTokens(TokenManagementInfo)`
  * Method `DeleteCredential(Int32, String)`
  * Method `DeleteExternalUser(Int32)`
  * Method `DeleteRole(Int32, Int32)`
  * Method `DeleteServiceAuth(Int32)`
  * Method `DeleteUser(Int32)`
  * Method `DeleteUserFromName(String)`
  * Method `DeleteUserGroup(Int32, Int32)`
  * Method `ExecuteUserCommand(String, CommandActionResult, User)`
  * Method `FindCredentialsGroups(String, String)`
  * Method `FindCredentialUsers(String, String)`
  * Method `FindRolesWithFunctionalRight(String)`
  * Method `FindRolesWithFunctionalRights(String[])`
  * Method `FindRolesWithoutFunctionalRights(String[])`
  * Method `GenerateNewPasswordForExternalUser(String)`
  * Method `GetAccessGatewayInfo()`
  * Method `GetAccessToken(String, Boolean)`
  * Method `GetAllFunctionalRights(RoleType)`
  * Method `GetAllRoles(RoleType)`
  * Method `GetAllUserGroups(Boolean)`
  * Method `GetCredentialTypes()`
  * Method `GetCredentialTypesForUserType(UserType)`
  * Method `GetCredentialUsersInGroup(String, String)`
  * Method `GetDataRight(Int32, String, RoleRelationToOwner)`
  * Method `GetDataRights(Int32, String)`
  * Method `GetDefaultAssociateUserName(User)`
  * Method `GetExternalTokens(String)`
  * Method `GetFunctionalRights(Int32)`
  * Method `GetOrRegisterAccessGatewayInfo(String)`
  * Method `GetRole(Int32)`
  * Method `GetRoleEntity(Int32)`
  * Method `GetServiceAuth(Int32)`
  * Method `GetSupportedChangePasswordTypes(Int32)`
  * Method `GetUntrustedCredentials(String)`
  * Method `GetUntrustedCredentialsForAssociate(Int32, String)`
  * Method `GetUser(Int32)`
  * Method `GetUserCommands(User)`
  * Method `GetUserFromEjUserId(Int32)`
  * Method `GetUserFromName(String)`
  * Method `GetUserFromPersonId(Int32)`
  * Method `GetUserGroup(Int32)`
  * Method `GetUserGroupList(Int32[])`
  * Method `GetUserInfo(Int32)`
  * Method `GetUserInfoList(Int32[])`
  * Method `GetUserPresenceStatus(Int32)`
  * Method `GetValidUserName(Int32, UserType, Int32, String)`
  * Method `GetValidUserNameForNewUser(User)`
  * Method `IsNickNameUnique(Int32, String)`
  * Method `IsPasswordValid(Int32, UserType, Int32, String)`
  * Method `IsPasswordValidWithReason(Int32, UserType, Int32, String)`
  * Method `IsUserNameValid(Int32, UserType, Int32, String)`
  * Method `IsUserNameValidWithReason(Int32, UserType, Int32, String)`
  * Method `MakeRetired(Int32, Boolean)`
  * Method `RegisterWithAccessGateway(String)`
  * Method `RemoveLicenses(Int32)`
  * Method `RemoveOwnerContact(Int32)`
  * Method `RemoveUntrustedCredentials(String, String)`
  * Method `RemoveUntrustedCredentialsForAssociate(Int32, String, String)`
  * Method `ResolveUserFromInfo(Int32, String, String[], String[], UserType, Credential)`
  * Method `SaveCredential(Int32, Credential)`
  * Method `SaveExternalTokens(TokenManagementInfo)`
  * Method `SaveRoleEntity(RoleEntity)`
  * Method `SaveServiceAuth(ServiceAuth)`
  * Method `SaveUntrustedCredentials(String, UntrustedCredentials)`
  * Method `SaveUntrustedCredentialsForAssociate(Int32, String, UntrustedCredentials)`
  * Method `SaveUser(User)`
  * Method `SaveUserFromName(String, User)`
  * Method `SaveUserGroup(UserGroup)`
  * Method `SendChangePasswordEMail(Int32)`
  * Method `SetDataRight(Int32, String, RoleRelationToOwner, String)`
  * Method `SetExternalUserInfo(Int32, String, String, Boolean, Int32, ExternalUserInfoModification)`
  * Method `SetFunctionalRights(Int32, Int32[])`
  * Method `SetGeneratedPassword(Int32)`
  * Method `SetGeneratedPasswordFromName(String)`
  * Method `SetPassword(Int32, String)`
  * Method `SetPasswordFromName(String, String)`
  * Method `SetUserPresenceStatus(Int32, UserPresenceStatus)`
  * Method `ValidateUser(User)`
* New items
  * Method `AddOwnerContactAsync(Int32, CancellationToken)`
  * Method `CanChangePasswordAsync(Int32, CancellationToken)`
  * Method `ChangeOwnPasswordAsync(String, String, CancellationToken)`
  * Method `ChangePasswordAsync(Int32, String, String, CancellationToken)`
  * Method `ChangePasswordFromNameAsync(String, String, String, CancellationToken)`
  * Method `ChangeUserTypeAsync(User, UserType, CancellationToken)`
  * Method `CheckAccessGatewayRegistrationAsync(CancellationToken)`
  * Method `CreateDefaultRoleEntityAsync(CancellationToken)`
  * Method `CreateDefaultRoleEntityFromTypeAsync(RoleType, CancellationToken)`
  * Method `CreateDefaultServiceAuthAsync(CancellationToken)`
  * Method `CreateDefaultUntrustedCredentialsAsync(CancellationToken)`
  * Method `CreateDefaultUserAsync(CancellationToken)`
  * Method `CreateDefaultUserFromUserTypeAndCredentialAsync(UserType, Int32, String, String, String, CancellationToken)`
  * Method `CreateDefaultUserFromUserTypeAndPersonIdAsync(UserType, Int32, CancellationToken)`
  * Method `CreateDefaultUserFromUserTypeAsync(UserType, CancellationToken)`
  * Method `CreateExternalUserAsync(Int32, String, String, Int32, Boolean, CancellationToken)`
  * Method `CreateUserGroupAsync(CancellationToken)`
  * Method `DecryptAndSaveExternalTokensAsync(TokenManagementInfo, CancellationToken)`
  * Method `DeleteCredentialAsync(Int32, String, CancellationToken)`
  * Method `DeleteExternalUserAsync(Int32, CancellationToken)`
  * Method `DeleteRoleAsync(Int32, Int32, CancellationToken)`
  * Method `DeleteServiceAuthAsync(Int32, CancellationToken)`
  * Method `DeleteUserAsync(Int32, CancellationToken)`
  * Method `DeleteUserFromNameAsync(String, CancellationToken)`
  * Method `DeleteUserGroupAsync(Int32, Int32, CancellationToken)`
  * Method `ExecuteUserCommandAsync(String, CommandActionResult, User, CancellationToken)`
  * Method `FindCredentialsGroupsAsync(String, String, CancellationToken)`
  * Method `FindCredentialUsersAsync(String, String, CancellationToken)`
  * Method `FindRolesWithFunctionalRightAsync(String, CancellationToken)`
  * Method `FindRolesWithFunctionalRightsAsync(String[], CancellationToken)`
  * Method `FindRolesWithoutFunctionalRightsAsync(String[], CancellationToken)`
  * Method `GenerateNewPasswordForExternalUserAsync(String, CancellationToken)`
  * Method `GetAccessGatewayInfoAsync(CancellationToken)`
  * Method `GetAccessTokenAsync(String, Boolean, CancellationToken)`
  * Method `GetAllFunctionalRightsAsync(RoleType, CancellationToken)`
  * Method `GetAllRolesAsync(RoleType, CancellationToken)`
  * Method `GetAllUserGroupsAsync(Boolean, CancellationToken)`
  * Method `GetCredentialTypesAsync(CancellationToken)`
  * Method `GetCredentialTypesForUserTypeAsync(UserType, CancellationToken)`
  * Method `GetCredentialUsersInGroupAsync(String, String, CancellationToken)`
  * Method `GetDataRightAsync(Int32, String, RoleRelationToOwner, CancellationToken)`
  * Method `GetDataRightsAsync(Int32, String, CancellationToken)`
  * Method `GetDefaultAssociateUserNameAsync(User, CancellationToken)`
  * Method `GetExternalTokensAsync(String, CancellationToken)`
  * Method `GetFunctionalRightsAsync(Int32, CancellationToken)`
  * Method `GetOrRegisterAccessGatewayInfoAsync(String, CancellationToken)`
  * Method `GetRoleAsync(Int32, CancellationToken)`
  * Method `GetRoleEntityAsync(Int32, CancellationToken)`
  * Method `GetServiceAuthAsync(Int32, CancellationToken)`
  * Method `GetSupportedChangePasswordTypesAsync(Int32, CancellationToken)`
  * Method `GetUntrustedCredentialsAsync(String, CancellationToken)`
  * Method `GetUntrustedCredentialsForAssociateAsync(Int32, String, CancellationToken)`
  * Method `GetUserAsync(Int32, CancellationToken)`
  * Method `GetUserCommandsAsync(User, CancellationToken)`
  * Method `GetUserFromEjUserIdAsync(Int32, CancellationToken)`
  * Method `GetUserFromNameAsync(String, CancellationToken)`
  * Method `GetUserFromPersonIdAsync(Int32, CancellationToken)`
  * Method `GetUserGroupAsync(Int32, CancellationToken)`
  * Method `GetUserGroupListAsync(Int32[], CancellationToken)`
  * Method `GetUserInfoAsync(Int32, CancellationToken)`
  * Method `GetUserInfoListAsync(Int32[], CancellationToken)`
  * Method `GetUserPresenceStatusAsync(Int32, CancellationToken)`
  * Method `GetValidUserNameAsync(Int32, UserType, Int32, String, CancellationToken)`
  * Method `GetValidUserNameForNewUserAsync(User, CancellationToken)`
  * Method `IsNickNameUniqueAsync(Int32, String, CancellationToken)`
  * Method `IsPasswordValidAsync(Int32, UserType, Int32, String, CancellationToken)`
  * Method `IsPasswordValidWithReasonAsync(Int32, UserType, Int32, String, CancellationToken)`
  * Method `IsUserNameValidAsync(Int32, UserType, Int32, String, CancellationToken)`
  * Method `IsUserNameValidWithReasonAsync(Int32, UserType, Int32, String, CancellationToken)`
  * Method `MakeRetiredAsync(Int32, Boolean, CancellationToken)`
  * Method `RegisterWithAccessGatewayAsync(String, CancellationToken)`
  * Method `RemoveLicensesAsync(Int32, CancellationToken)`
  * Method `RemoveOwnerContactAsync(Int32, CancellationToken)`
  * Method `RemoveUntrustedCredentialsAsync(String, String, CancellationToken)`
  * Method `RemoveUntrustedCredentialsForAssociateAsync(Int32, String, String, CancellationToken)`
  * Method `ResolveUserFromInfoAsync(Int32, String, String[], String[], UserType, Credential, CancellationToken)`
  * Method `SaveCredentialAsync(Int32, Credential, CancellationToken)`
  * Method `SaveExternalTokensAsync(TokenManagementInfo, CancellationToken)`
  * Method `SaveRoleEntityAsync(RoleEntity, CancellationToken)`
  * Method `SaveServiceAuthAsync(ServiceAuth, CancellationToken)`
  * Method `SaveUntrustedCredentialsAsync(String, UntrustedCredentials, CancellationToken)`
  * Method `SaveUntrustedCredentialsForAssociateAsync(Int32, String, UntrustedCredentials, CancellationToken)`
  * Method `SaveUserAsync(User, CancellationToken)`
  * Method `SaveUserFromNameAsync(String, User, CancellationToken)`
  * Method `SaveUserGroupAsync(UserGroup, CancellationToken)`
  * Method `SendChangePasswordEMailAsync(Int32, CancellationToken)`
  * Method `SetDataRightAsync(Int32, String, RoleRelationToOwner, String, CancellationToken)`
  * Method `SetExternalUserInfoAsync(Int32, String, String, Boolean, Int32, ExternalUserInfoModification, CancellationToken)`
  * Method `SetFunctionalRightsAsync(Int32, Int32[], CancellationToken)`
  * Method `SetGeneratedPasswordAsync(Int32, CancellationToken)`
  * Method `SetGeneratedPasswordFromNameAsync(String, CancellationToken)`
  * Method `SetPasswordAsync(Int32, String, CancellationToken)`
  * Method `SetPasswordFromNameAsync(String, String, CancellationToken)`
  * Method `SetUserPresenceStatusAsync(Int32, UserPresenceStatus, CancellationToken)`
  * Method `ValidateUserAsync(User, CancellationToken)`

#### SuperOffice.CRM.Services.IUserDefinedFieldInfoAgent is Modified

* Deleted items
  * Method `ChangeFieldType(UserDefinedFieldInfo, UDefFieldType, Boolean)`
  * Method `ClearCaches()`
  * Method `CreateDefaultUserDefinedFieldInfo()`
  * Method `CreateUserDefinedFieldInfo(UDefType, UDefFieldType)`
  * Method `DeleteUserDefinedFieldInfo(Int32)`
  * Method `DetectColumnIdChanges(UDefType)`
  * Method `DetectUnpublishedChanges(UDefType)`
  * Method `FigureOutListIdFromListTableIdAndUDListDefinitionId(UserDefinedFieldInfo)`
  * Method `GetChangedPageOneFields(UDefType, Int32)`
  * Method `GetCustomFieldInfo(String, String)`
  * Method `GetCustomFieldInfoList(String, Boolean)`
  * Method `GetPublishedUserDefinedFieldFromFieldLabel(String, UDefType)`
  * Method `GetPublishedUserDefinedFieldFromProgId(String, UDefType)`
  * Method `GetPublishedUserDefinedFieldList(UDefType)`
  * Method `GetPublishedUserDefinedPageOneFields(UDefType, Int32)`
  * Method `GetUserDefinedFieldFromFieldLabel(String, UDefType)`
  * Method `GetUserDefinedFieldFromIds(Int32[])`
  * Method `GetUserDefinedFieldFromProgId(String, UDefType)`
  * Method `GetUserDefinedFieldFromProgIds(String[], UDefType)`
  * Method `GetUserDefinedFieldInfo(Int32)`
  * Method `GetUserDefinedFieldList(UDefType)`
  * Method `GetUserDefinedPageOneFields(UDefType, Int32)`
  * Method `IsAnyPublishEventActive()`
  * Method `IsPublishEventActive(UDefType)`
  * Method `Publish(UDefType)`
  * Method `Revert(UDefType)`
  * Method `SaveUserDefinedFieldInfo(UserDefinedFieldInfo)`
  * Method `SaveUserDefinedFieldInfos(UserDefinedFieldInfo[])`
  * Method `SetListTableIdAndUDListDefinitionIdFromSelectedListId(UserDefinedFieldInfo, Int32)`
  * Method `SetPageOneFieldGrouping(UDefType, Boolean)`
  * Method `SetPublishStartSystemEvent(UDefType)`
  * Method `SetRankOnFields(UDefType, Int32[])`
  * Method `SetUserDefinedPageOneField(UDefType, Int32, Int32, Int32)`
* New items
  * Method `ChangeFieldTypeAsync(UserDefinedFieldInfo, UDefFieldType, Boolean, CancellationToken)`
  * Method `ClearCachesAsync(CancellationToken)`
  * Method `CreateDefaultUserDefinedFieldInfoAsync(CancellationToken)`
  * Method `CreateUserDefinedFieldInfoAsync(UDefType, UDefFieldType, CancellationToken)`
  * Method `DeleteUserDefinedFieldInfoAsync(Int32, CancellationToken)`
  * Method `DetectColumnIdChangesAsync(UDefType, CancellationToken)`
  * Method `DetectUnpublishedChangesAsync(UDefType, CancellationToken)`
  * Method `FigureOutListIdFromListTableIdAndUDListDefinitionIdAsync(UserDefinedFieldInfo, CancellationToken)`
  * Method `GetChangedPageOneFieldsAsync(UDefType, Int32, CancellationToken)`
  * Method `GetCustomFieldInfoAsync(String, String, CancellationToken)`
  * Method `GetCustomFieldInfoListAsync(String, Boolean, CancellationToken)`
  * Method `GetPublishedUserDefinedFieldFromFieldLabelAsync(String, UDefType, CancellationToken)`
  * Method `GetPublishedUserDefinedFieldFromProgIdAsync(String, UDefType, CancellationToken)`
  * Method `GetPublishedUserDefinedFieldListAsync(UDefType, CancellationToken)`
  * Method `GetPublishedUserDefinedPageOneFieldsAsync(UDefType, Int32, CancellationToken)`
  * Method `GetUserDefinedFieldFromFieldLabelAsync(String, UDefType, CancellationToken)`
  * Method `GetUserDefinedFieldFromIdsAsync(Int32[], CancellationToken)`
  * Method `GetUserDefinedFieldFromProgIdAsync(String, UDefType, CancellationToken)`
  * Method `GetUserDefinedFieldFromProgIdsAsync(String[], UDefType, CancellationToken)`
  * Method `GetUserDefinedFieldInfoAsync(Int32, CancellationToken)`
  * Method `GetUserDefinedFieldListAsync(UDefType, CancellationToken)`
  * Method `GetUserDefinedPageOneFieldsAsync(UDefType, Int32, CancellationToken)`
  * Method `IsAnyPublishEventActiveAsync(CancellationToken)`
  * Method `IsPublishEventActiveAsync(UDefType, CancellationToken)`
  * Method `PublishAsync(UDefType, CancellationToken)`
  * Method `RevertAsync(UDefType, CancellationToken)`
  * Method `SaveUserDefinedFieldInfoAsync(UserDefinedFieldInfo, CancellationToken)`
  * Method `SaveUserDefinedFieldInfosAsync(UserDefinedFieldInfo[], CancellationToken)`
  * Method `SetListTableIdAndUDListDefinitionIdFromSelectedListIdAsync(UserDefinedFieldInfo, Int32, CancellationToken)`
  * Method `SetPageOneFieldGroupingAsync(UDefType, Boolean, CancellationToken)`
  * Method `SetPublishStartSystemEventAsync(UDefType, CancellationToken)`
  * Method `SetRankOnFieldsAsync(UDefType, Int32[], CancellationToken)`
  * Method `SetUserDefinedPageOneFieldAsync(UDefType, Int32, Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.IViewStateAgent is Modified

* Deleted items
  * Method `DeleteHistory(String, Int32)`
  * Method `GetCurrent(String)`
  * Method `GetHistories()`
  * Method `GetHistoriesByName(String)`
  * Method `GetHistoriesByNames(String[])`
  * Method `GetHistoriesByNamesAndIds(HistoryRequest[])`
  * Method `GetHistory(Int32)`
  * Method `GetHistoryLengthPrefValue()`
  * Method `GetLiveUiConfig()`
  * Method `GetNextCurrent(String, Int32)`
  * Method `GetPreviousCurrent(String, Int32)`
  * Method `PublishAndRetrieveUiEvents(Int32, UiEvent[], MetricPair[])`
  * Method `SaveCurrent(History)`
  * Method `SaveCurrents(History[])`
  * Method `SaveHistories(String, History[])`
  * Method `SetHistoryLengthPrefValue(Int32)`
* New items
  * Method `DeleteHistoryAsync(String, Int32, CancellationToken)`
  * Method `GetCurrentAsync(String, CancellationToken)`
  * Method `GetHistoriesAsync(CancellationToken)`
  * Method `GetHistoriesByNameAsync(String, CancellationToken)`
  * Method `GetHistoriesByNamesAndIdsAsync(HistoryRequest[], CancellationToken)`
  * Method `GetHistoriesByNamesAsync(String[], CancellationToken)`
  * Method `GetHistoryAsync(Int32, CancellationToken)`
  * Method `GetHistoryLengthPrefValueAsync(CancellationToken)`
  * Method `GetLiveUiConfigAsync(CancellationToken)`
  * Method `GetNextCurrentAsync(String, Int32, CancellationToken)`
  * Method `GetPreviousCurrentAsync(String, Int32, CancellationToken)`
  * Method `PublishAndRetrieveUiEventsAsync(Int32, UiEvent[], MetricPair[], CancellationToken)`
  * Method `SaveCurrentAsync(History, CancellationToken)`
  * Method `SaveCurrentsAsync(History[], CancellationToken)`
  * Method `SaveHistoriesAsync(String, History[], CancellationToken)`
  * Method `SetHistoryLengthPrefValueAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.IWebhookAgent is Modified

* Deleted items
  * Method `CreateDefaultWebhook()`
  * Method `DeleteWebhook(Int32)`
  * Method `GetAllWebhooks(String, String, WebhookState)`
  * Method `GetLastError(Int32)`
  * Method `GetWebhook(Int32)`
  * Method `SaveWebhook(Webhook)`
  * Method `SignalEvent(String, Int32, StringObjectDictionary)`
  * Method `TestWebhook(Webhook)`
* New items
  * Method `CreateDefaultWebhookAsync(CancellationToken)`
  * Method `DeleteWebhookAsync(Int32, CancellationToken)`
  * Method `GetAllWebhooksAsync(String, String, WebhookState, CancellationToken)`
  * Method `GetLastErrorAsync(Int32, CancellationToken)`
  * Method `GetWebhookAsync(Int32, CancellationToken)`
  * Method `SaveWebhookAsync(Webhook, CancellationToken)`
  * Method `SignalEventAsync(String, Int32, StringObjectDictionary, CancellationToken)`
  * Method `TestWebhookAsync(Webhook, CancellationToken)`

#### SuperOffice.CRM.Services.IWorkflowAgent is Modified

* Deleted items
  * Method `AddAfterWorkflowStep(Int32, WorkflowStepBase)`
  * Method `ConnectEmailFlowContent(Int32, Int32)`
  * Method `CopyEmailFlow(Int32, String)`
  * Method `CopyEmailFlowContent(Int32, Int32)`
  * Method `CreateDefaultEmailFlow()`
  * Method `CreateDefaultWorkflowEvent()`
  * Method `CreateDefaultWorkflowEventResult()`
  * Method `CreateDefaultWorkflowFilter()`
  * Method `CreateDefaultWorkflowGoal()`
  * Method `CreateDefaultWorkflowStepFromType(WorkflowStepType)`
  * Method `CreateDefaultWorkflowStepOptionFromType(WorkflowSplitOptionType)`
  * Method `CreateDefaultWorkflowTrigger()`
  * Method `CreateDefaultWorkflowWaitForAction()`
  * Method `CreateEmailFlowContent(Int32, String)`
  * Method `DeleteEmailFlow(Int32)`
  * Method `DeleteWorkflowGoal(Int32)`
  * Method `DeleteWorkflowTrigger(Int32)`
  * Method `DeleteWorkflowWaitForAction(Int32)`
  * Method `GetEmailFlow(Int32)`
  * Method `GetWorkflowGoal(Int32)`
  * Method `GetWorkflowStep(Int32)`
  * Method `GetWorkflowStepOption(Int32)`
  * Method `GetWorkflowTrigger(Int32)`
  * Method `GetWorkflowWaitForAction(Int32)`
  * Method `RemoveParticipantsFromEmailFlow(Int32, Int32[])`
  * Method `Run()`
  * Method `SaveEmailFlow(EmailFlow)`
  * Method `SaveWorkflowGoal(WorkflowGoal)`
  * Method `SaveWorkflowTrigger(WorkflowTrigger)`
  * Method `SaveWorkflowWaitForAction(WorkflowWaitForAction)`
  * Method `SendEvent(WorkflowEvent)`
  * Method `SetStatusOnWorkflow(Int32, WorkflowDefinitionStatus)`
  * Method `TryAddPersonsToEmailFlow(Int32, Int32[])`
  * Method `UpdateFormSubmissions(Int32)`
* New items
  * Method `AddAfterWorkflowStepAsync(Int32, WorkflowStepBase, CancellationToken)`
  * Method `ConnectEmailFlowContentAsync(Int32, Int32, CancellationToken)`
  * Method `CopyEmailFlowAsync(Int32, String, CancellationToken)`
  * Method `CopyEmailFlowContentAsync(Int32, Int32, CancellationToken)`
  * Method `CreateDefaultEmailFlowAsync(CancellationToken)`
  * Method `CreateDefaultWorkflowEventAsync(CancellationToken)`
  * Method `CreateDefaultWorkflowEventResultAsync(CancellationToken)`
  * Method `CreateDefaultWorkflowFilterAsync(CancellationToken)`
  * Method `CreateDefaultWorkflowGoalAsync(CancellationToken)`
  * Method `CreateDefaultWorkflowStepFromTypeAsync(WorkflowStepType, CancellationToken)`
  * Method `CreateDefaultWorkflowStepOptionFromTypeAsync(WorkflowSplitOptionType, CancellationToken)`
  * Method `CreateDefaultWorkflowTriggerAsync(CancellationToken)`
  * Method `CreateDefaultWorkflowWaitForActionAsync(CancellationToken)`
  * Method `CreateEmailFlowContentAsync(Int32, String, CancellationToken)`
  * Method `DeleteEmailFlowAsync(Int32, CancellationToken)`
  * Method `DeleteWorkflowGoalAsync(Int32, CancellationToken)`
  * Method `DeleteWorkflowTriggerAsync(Int32, CancellationToken)`
  * Method `DeleteWorkflowWaitForActionAsync(Int32, CancellationToken)`
  * Method `GetEmailFlowAsync(Int32, CancellationToken)`
  * Method `GetWorkflowGoalAsync(Int32, CancellationToken)`
  * Method `GetWorkflowStepAsync(Int32, CancellationToken)`
  * Method `GetWorkflowStepOptionAsync(Int32, CancellationToken)`
  * Method `GetWorkflowTriggerAsync(Int32, CancellationToken)`
  * Method `GetWorkflowWaitForActionAsync(Int32, CancellationToken)`
  * Method `RemoveParticipantsFromEmailFlowAsync(Int32, Int32[], CancellationToken)`
  * Method `RunAsync(CancellationToken)`
  * Method `SaveEmailFlowAsync(EmailFlow, CancellationToken)`
  * Method `SaveWorkflowGoalAsync(WorkflowGoal, CancellationToken)`
  * Method `SaveWorkflowTriggerAsync(WorkflowTrigger, CancellationToken)`
  * Method `SaveWorkflowWaitForActionAsync(WorkflowWaitForAction, CancellationToken)`
  * Method `SendEventAsync(WorkflowEvent, CancellationToken)`
  * Method `SetStatusOnWorkflowAsync(Int32, WorkflowDefinitionStatus, CancellationToken)`
  * Method `TryAddPersonsToEmailFlowAsync(Int32, Int32[], CancellationToken)`
  * Method `UpdateFormSubmissionsAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.SuggestedAppointmentEntity is Modified

* Modified items
  * Property `Type`


### Assembly: SuperOffice.Services.Implementation

### Deleted Types

* `SuperOffice.CRM.Services.Implementation.AIAgentLocal`
* `SuperOffice.CRM.Services.Implementation.AppointmentAgentLocal`
* `SuperOffice.CRM.Services.Implementation.ArchiveAgentLocal`
* `SuperOffice.CRM.Services.Implementation.AssociateAgentLocal`
* `SuperOffice.CRM.Services.Implementation.AudienceAgentLocal`
* `SuperOffice.CRM.Services.Implementation.BatchAgentLocal`
* `SuperOffice.CRM.Services.Implementation.BL.AreaImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.AreaListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.AudienceLayoutEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.DashboardImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.DashboardTileImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.EntityImplementation<TCarrier>`
* `SuperOffice.CRM.Services.Implementation.BL.ErpSyncActorImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.JsonRestrictionParser`
* `SuperOffice.CRM.Services.Implementation.BL.PartnerWebPanelImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.QuoteListItemImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.SatelliteImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.SingleJsonRestrictionParser`
* `SuperOffice.CRM.Services.Implementation.BL.SystemEventEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.WorkflowStepOptionFormSubmissionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.WorkflowStepOptionLinkClickedImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.WorkflowStepOptionPersonDataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.WorkflowStepOptionProjectMembershipImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.WorkflowStepOptionSelectionMembershipImplementation`
* `SuperOffice.CRM.Services.Implementation.BLOBAgentLocal`
* `SuperOffice.CRM.Services.Implementation.BulkUpdateAgentLocal`
* `SuperOffice.CRM.Services.Implementation.ChatAgentLocal`
* `SuperOffice.CRM.Services.Implementation.ChatServiceFacade`
* `SuperOffice.CRM.Services.Implementation.ContactAgentLocal`
* `SuperOffice.CRM.Services.Implementation.CRMScriptAgentLocal`
* `SuperOffice.CRM.Services.Implementation.CRMScriptServiceFacade`
* `SuperOffice.CRM.Services.Implementation.CustomerServiceAgentLocal`
* `SuperOffice.CRM.Services.Implementation.CustomerServiceServiceFacade`
* `SuperOffice.CRM.Services.Implementation.DashAgentLocal`
* `SuperOffice.CRM.Services.Implementation.DashboardAgentLocal`
* `SuperOffice.CRM.Services.Implementation.DatabaseAgentLocal`
* `SuperOffice.CRM.Services.Implementation.DatabaseTableAgentLocal`
* `SuperOffice.CRM.Services.Implementation.DiagnosticsAgentLocal`
* `SuperOffice.CRM.Services.Implementation.DocumentAgentLocal`
* `SuperOffice.CRM.Services.Implementation.DocumentMigrationAgentLocal`
* `SuperOffice.CRM.Services.Implementation.EMailAgentLocal`
* `SuperOffice.CRM.Services.Implementation.ErpSyncAgentLocal`
* `SuperOffice.CRM.Services.Implementation.FavouriteAgentLocal`
* `SuperOffice.CRM.Services.Implementation.FindAgentLocal`
* `SuperOffice.CRM.Services.Implementation.ForeignSystemAgentLocal`
* `SuperOffice.CRM.Services.Implementation.FreeTextAgentLocal`
* `SuperOffice.CRM.Services.Implementation.ImportAgentLocal`
* `SuperOffice.CRM.Services.Implementation.LicenseAgentLocal`
* `SuperOffice.CRM.Services.Implementation.ListAgentLocal`
* `SuperOffice.CRM.Services.Implementation.ListServiceFacade`
* `SuperOffice.CRM.Services.Implementation.MarketingAgentLocal`
* `SuperOffice.CRM.Services.Implementation.MDOAgentLocal`
* `SuperOffice.CRM.Services.Implementation.NumberAllocationAgentLocal`
* `SuperOffice.CRM.Services.Implementation.PersonAgentLocal`
* `SuperOffice.CRM.Services.Implementation.PhoneListAgentLocal`
* `SuperOffice.CRM.Services.Implementation.PocketAgentLocal`
* `SuperOffice.CRM.Services.Implementation.PreferenceAgentLocal`
* `SuperOffice.CRM.Services.Implementation.ProjectAgentLocal`
* `SuperOffice.CRM.Services.Implementation.QuoteAgentLocal`
* `SuperOffice.CRM.Services.Implementation.RelationAgentLocal`
* `SuperOffice.CRM.Services.Implementation.ReplicationAgentLocal`
* `SuperOffice.CRM.Services.Implementation.ReportAgentLocal`
* `SuperOffice.CRM.Services.Implementation.ResourceAgentLocal`
* `SuperOffice.CRM.Services.Implementation.SaintAgentLocal`
* `SuperOffice.CRM.Services.Implementation.SaleAgentLocal`
* `SuperOffice.CRM.Services.Implementation.SelectionAgentLocal`
* `SuperOffice.CRM.Services.Implementation.SentryAgentLocal`
* `SuperOffice.CRM.Services.Implementation.TargetsAgentLocal`
* `SuperOffice.CRM.Services.Implementation.TicketAgentLocal`
* `SuperOffice.CRM.Services.Implementation.TicketServiceFacade`
* `SuperOffice.CRM.Services.Implementation.TimeZoneAgentLocal`
* `SuperOffice.CRM.Services.Implementation.UserAgentLocal`
* `SuperOffice.CRM.Services.Implementation.UserDefinedFieldInfoAgentLocal`
* `SuperOffice.CRM.Services.Implementation.Util.iCalendarAppointmentUtility`
* `SuperOffice.CRM.Services.Implementation.ViewStateAgentLocal`
* `SuperOffice.CRM.Services.Implementation.WebhookAgentLocal`
* `SuperOffice.CRM.Services.Implementation.WorkflowAgentLocal`

### New Types

* `SuperOffice.CRM.Services.AIAgent`
* `SuperOffice.CRM.Services.AppointmentAgent`
* `SuperOffice.CRM.Services.ArchiveAgent`
* `SuperOffice.CRM.Services.AssociateAgent`
* `SuperOffice.CRM.Services.BatchAgent`
* `SuperOffice.CRM.Services.BLOBAgent`
* `SuperOffice.CRM.Services.BulkUpdateAgent`
* `SuperOffice.CRM.Services.ChatAgent`
* `SuperOffice.CRM.Services.ContactAgent`
* `SuperOffice.CRM.Services.CRMScriptAgent`
* `SuperOffice.CRM.Services.CustomerServiceAgent`
* `SuperOffice.CRM.Services.DashAgent`
* `SuperOffice.CRM.Services.DatabaseAgent`
* `SuperOffice.CRM.Services.DatabaseTableAgent`
* `SuperOffice.CRM.Services.DiagnosticsAgent`
* `SuperOffice.CRM.Services.DocumentAgent`
* `SuperOffice.CRM.Services.DocumentMigrationAgent`
* `SuperOffice.CRM.Services.EMailAgent`
* `SuperOffice.CRM.Services.ErpSyncAgent`
* `SuperOffice.CRM.Services.FavouriteAgent`
* `SuperOffice.CRM.Services.FindAgent`
* `SuperOffice.CRM.Services.ForeignSystemAgent`
* `SuperOffice.CRM.Services.FreeTextAgent`
* `SuperOffice.CRM.Services.Implementation.BL.AttachmentEntityImplementationExtensions`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IAccessGatewayInfoImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IActivityFilterImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IAmountClassEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IAppointmentEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IAppointmentImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IAppointmentListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IAppointmentSyncDataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IArchiveConfigurationImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IArchiveListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IArchiveListResultImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IAssociateImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IAssociateListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IAttachmentEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IBatchImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IBlobEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IBusinessImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IBusinessListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICacheImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICacheInvalidationImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICallerIDImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICategorizationStatusResponseImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICategoryGuessImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICategoryImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICategoryListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IChatbotTurnImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IChatPresenceImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IChatSessionEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IChatSessionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IChatTopicAgentImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IChatTopicEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICompetitorImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICompetitorListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IConsentPersonImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IConsentPurposeImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IConsentPurposeListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IConsentSourceImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IConsentSourceListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IContactActivityListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IContactEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IContactImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IContactListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IContactRelationEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICountryImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICountryListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICredentialImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICreditedImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICreditedListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICRMScriptEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICsFeatureToggleImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICsSessionKeyImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICurrencyEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICurrencyImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICurrencyListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICustomerCenterConfigImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICustomerLanguageImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICustomerLanguageListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICustomerServiceConfigImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ICustomerServiceStartupImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDashCollectionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDashImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDashThemeImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDashTileDefinitionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDashTileHtmlImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDashTileImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDayInformationListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDeliveryTermImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDeliveryTermsListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDeliveryTypeImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDeliveryTypeListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDepartmentImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDepartmentListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDictionaryStepInformationImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDocumentEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDocumentImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDocumentListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDocumentMigrationItemListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDocumentPreviewImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDocumentTemplateEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDocumentTemplateImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDocumentTemplateListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDocumentTemplateMigrationListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDuplicateEntryImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IDuplicateRuleImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailAccountImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailAddressImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailAppointmentImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailAttachmentImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailConnectionInfoExtendedImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailConnectionInfoImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailCustomHeaderImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailEnvelopeImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEmailFlowImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailFolderImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEMailSOInfoImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEntityCountsImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IErpConnectionDataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IErpConnectionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IErpConnectionListMappingContainerImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IErpSyncActorTypeMappingImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IErpSyncConnectionSummaryImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IErpSyncConnectorEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IErpSyncDefaultValueImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IErpSyncEngineImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IErpSyncEngineStatusImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IErpSyncFieldValueImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IEventDataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IExtAppEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IFavouriteImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IFieldInfoBaseImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IFieldMetadataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IFieldValueInfoImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IFindImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IForeignAppEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IForeignDeviceImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IForeignKeyImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IForeignKeyListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IFormEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IFormSubmissionEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IFreeTextImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IHeadingEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IHierarchyEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IHistoryImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IHistoryListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IImportErpDataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IImportLineImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IInstallationImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ILanguageInfoImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ILanguageInfoListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ILegalBaseImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ILegalBaseListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ILicenseImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ILinkImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ILinkListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IListEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IListItemEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ILiveUiConfigImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ILocalizedTextImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ILocalizedTextListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ILoggingImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IMailboxEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IMailboxImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IMailingStatisticsImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IMassOperationResultImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IMDOListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IMrMrsImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IMrMrsListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IMultiAlarmDataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.INextAvailableTimeListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPaymentTermImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPaymentTermsListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPaymentTypeImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPaymentTypeListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPersonEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPersonImageImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPersonImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPersonListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPhoneListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPhoneListPreferencesImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPocketStartupDataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPositionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPositionListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreferenceDescriptionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreferenceDescriptionLineImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreferenceImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreferenceListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreferredTimeZoneImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreviewContactImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreviewDashImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreviewDashTileImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreviewFaqEntryImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreviewMailingHeaderImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreviewMailingImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreviewQuickReplyImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPreviewReplyTemplateImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPriceListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPriorityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IPriorityListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProductCategoryImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProductCategoryListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProductFamilyImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProductFamilyListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProductImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProductTypeImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProductTypeListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectEventEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectEventImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectEventListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectMemberImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectMemberListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectStatusImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectStatusListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectTypeEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectTypeImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectTypeListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IProjectTypeStatusLinkImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuickReplyImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuoteAlternativeImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuoteApproveReasonImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuoteApproveReasonListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuoteConnectionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuoteDenyReasonImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuoteDenyReasonListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuoteEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuoteImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuoteLineConfigurationImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuoteLineImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuoteVersionAttachmentImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IQuoteVersionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IRatingImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IRatingListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IReasonImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IReasonListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IReasonSoldImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IReasonSoldListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IReasonStalledImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IReasonStalledListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IRefCountEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IRelatedDataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IRelationDefinitionEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IRemoteTimeZoneMethodsImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IReplyTemplateParsedImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IReportLabelLayoutEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IResourceEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IResourceOverrideImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IRoleEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IRoleImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaintConfigurationImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaleEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaleImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaleListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISalesActivityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaleStageEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaleStakeholderImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaleStakeholderListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaleSummaryImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaleTypeEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaleTypeImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaleTypeListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISaleTypeStageLinkImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IScriptImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISelectableMDOListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISelectionCategoryImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISelectionCategoryListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISelectionEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISelectionForFindImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISelectionSummaryItemImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISentimentImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISentryImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IServiceAuthImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IShipmentMessageBlockEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IShipmentMessageEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISmsConfigImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISmtpTestResultImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISoTaskImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISourceImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISourceListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IStatisticsDataSetImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IStatusMonitorImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IStatusMonitorPeriodsImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISuggestedAppointmentEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISuggestedAppointmentImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISuggestedDocumentEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISummarizerImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISyncUserAccountImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISystemMessageListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ISystemTemplateSettingsImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITableRecordImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITargetAssignmentImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITargetDimensionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITargetGroupImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITargetRevisionHistoryImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITargetRevisionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITaskListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITaskListItemImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITaskMenuImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITemplateVariablesParametersImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITextServicesImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketCategoryEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketCategoryImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketCategoryListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketCategoryMembershipEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketInfoImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketMessageEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketMessageImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketPriorityEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketPriorityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketPriorityListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketStatusEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketStatusListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketSummaryItemImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketTypeEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITicketTypeListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITimeZoneDataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITokenManagementInfoImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITriggerScriptEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.ITypicalSearchesImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IUiEventImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IUntrustedCredentialsImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IUsageStatsImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IUserDefinedFieldInfoImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IUserGroupImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IUserGroupListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IUserImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IUserInfoImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IUserInfoListImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IVideoMeetingReservationImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IWebAppUsageImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IWebhookImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IWebPanelEntityImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IWorkflowEventImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IWorkflowEventResultImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IWorkflowFilterImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IWorkflowGoalImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IWorkflowStepBaseImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IWorkflowStepOptionBaseImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IWorkflowTriggerImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.Contracts.IWorkflowWaitForActionImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.EntityImplementationAsync<TCarrier>`
* `SuperOffice.CRM.Services.Implementation.BL.EventDataImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.HashSetExtensions`
* `SuperOffice.CRM.Services.Implementation.BL.IDocumentEntityImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.IEMailAccountImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.IEMailAddressImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.IEMailFolderImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.IFieldInfoBaseImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.IForeignDeviceImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.IForeignKeyImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.ILinkImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.IPriorityImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.ISaleImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.ISaleStakeholderListImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.IServiceAuthImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.ITargetAssignmentImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.ITargetDimensionImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.ITargetRevisionHistoryImplementationInternal`
* `SuperOffice.CRM.Services.Implementation.BL.MailboxImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.ReplyTemplateParsedImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.SmtpTestResultImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.StringBuilderExtensions`
* `SuperOffice.CRM.Services.Implementation.BL.SystemTemplateSettingsExtensions`
* `SuperOffice.CRM.Services.Implementation.BL.TicketInfoImplementation`
* `SuperOffice.CRM.Services.Implementation.BL.UserImplementationExtensions`
* `SuperOffice.CRM.Services.Implementation.BL.WorkflowGoalImplementationExtensions`
* `SuperOffice.CRM.Services.Implementation.BL.WorkflowStepBaseImplementationExtensions`
* `SuperOffice.CRM.Services.Implementation.BL.WorkflowStepOptionBaseImplementationExtensions`
* `SuperOffice.CRM.Services.Implementation.BL.WorkflowTriggerImplementationExtensions`
* `SuperOffice.CRM.Services.Implementation.BL.WorkflowWaitForActionImplementationExtensions`
* `SuperOffice.CRM.Services.Implementation.Util.AppointmentHelper`
* `SuperOffice.CRM.Services.Implementation.Util.CalendarAppointmentUtility`
* `SuperOffice.CRM.Services.Implementation.Util.CredentialHelper`
* `SuperOffice.CRM.Services.Implementation.Util.ICalendarAppointmentUtility`
* `SuperOffice.CRM.Services.Implementation.Util.UntrustedCredentialsHelper`
* `SuperOffice.CRM.Services.Implementation.Util.UserGroupConversionHelper`
* `SuperOffice.CRM.Services.ImportAgent`
* `SuperOffice.CRM.Services.LicenseAgent`
* `SuperOffice.CRM.Services.ListAgent`
* `SuperOffice.CRM.Services.MarketingAgent`
* `SuperOffice.CRM.Services.MDOAgent`
* `SuperOffice.CRM.Services.NumberAllocationAgent`
* `SuperOffice.CRM.Services.PersonAgent`
* `SuperOffice.CRM.Services.PhoneListAgent`
* `SuperOffice.CRM.Services.PocketAgent`
* `SuperOffice.CRM.Services.PreferenceAgent`
* `SuperOffice.CRM.Services.ProjectAgent`
* `SuperOffice.CRM.Services.QuoteAgent`
* `SuperOffice.CRM.Services.RelationAgent`
* `SuperOffice.CRM.Services.ReportAgent`
* `SuperOffice.CRM.Services.ResourceAgent`
* `SuperOffice.CRM.Services.SaintAgent`
* `SuperOffice.CRM.Services.SaleAgent`
* `SuperOffice.CRM.Services.SelectionAgent`
* `SuperOffice.CRM.Services.SentryAgent`
* `SuperOffice.CRM.Services.TargetsAgent`
* `SuperOffice.CRM.Services.TicketAgent`
* `SuperOffice.CRM.Services.TimeZoneAgent`
* `SuperOffice.CRM.Services.UserAgent`
* `SuperOffice.CRM.Services.UserDefinedFieldInfoAgent`
* `SuperOffice.CRM.Services.ViewStateAgent`
* `SuperOffice.CRM.Services.WebhookAgent`
* `SuperOffice.CRM.Services.WorkflowAgent`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.ErpEntityProvider is Modified

* Deleted items
  * Method `GetResultData()`
* New items
  * Method `GetResultDataAsync(CancellationToken)`

#### SuperOffice.CRM.ArchiveLists.ErpSyncLogProvider is Modified

* Deleted items
  * Method `InnerMapFields()`
* New items
  * Method `InnerMapFieldsAsync(CancellationToken)`

#### SuperOffice.CRM.BatchProcessing.Plugins.StatusMonitorRegenerateBatchPlugin is Modified

* Deleted items
  * Method `StatusMonitorRegenerateBatchPlugin()`
  * Method `Run(String, String)`
* New items
  * Method `StatusMonitorRegenerateBatchPlugin(IBatchData, IBatchServiceConfiguration, ILogger<StatusMonitorRegenerateBatchPlugin>)`
  * Method `RunAsync(String, String, CancellationToken)`

#### SuperOffice.CRM.Cache.ErpListCache is Modified

* Deleted items
  * Method `GetCurrent()`
* New items
  * Method `OnLoadAsync(CancellationToken)`

#### SuperOffice.CRM.Cache.ErpSearchResultCache is Modified

* Deleted items
  * Method `GetCurrent()`
* New items
  * Method `OnLoadAsync(CancellationToken)`

#### SuperOffice.CRM.Cache.QuoteListCache is Modified

* Deleted items
  * Method `GetCurrent()`
* New items
  * Method `OnLoadAsync(CancellationToken)`

#### SuperOffice.CRM.Lists.ErpActorTypeProvider is Modified

* Deleted items
  * Method `AddItems()`
* New items
  * Method `AddItemsAsync(CancellationToken)`

#### SuperOffice.CRM.Lists.ErpSyncListsProvider is Modified

* Deleted items
  * Method `GetProvider(String)`
* New items
  * Method `GetProviderAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.AccessGatewayInfoImplementation is Modified

* Deleted items
  * Method `CheckAccessGatewayRegistration()`
  * Method `GetAccessGatewayInfo()`
  * Method `GetOrRegisterAccessGatewayInfo(String)`
  * Method `RegisterWithAccessGateway(String)`
* New items
  * Method `AccessGatewayInfoImplementation()`
  * Method `CheckAccessGatewayRegistrationAsync(CancellationToken)`
  * Method `GetAccessGatewayInfoAsync(CancellationToken)`
  * Method `GetOrRegisterAccessGatewayInfoAsync(String, CancellationToken)`
  * Method `RegisterWithAccessGatewayAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.AmountClassEntityImplementation is Modified

* Deleted items
  * Method `AmountClassEntityImplementation()`
  * Method `CreateDefault()`
  * Method `GetFromId(Int32)`
  * Method `Save(AmountClassEntity)`
* New items
  * Method `AmountClassEntityImplementation(ICacheManager)`
  * Method `CreateDefaultAmountClassEntityAsync(CancellationToken)`
  * Method `GetAmountClassEntityAsync(Int32, CancellationToken)`
  * Method `SaveAmountClassEntityAsync(AmountClassEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.AppointmentEntityImplementation is Modified

* Deleted items
  * Method `AppointmentEntityImplementation()`
  * Method `Accept(Int32, RecurrenceUpdateMode)`
  * Method `AcceptRejected(Int32, RecurrenceUpdateMode)`
  * Method `AcceptWithEmailConfirmation(Int32, RecurrenceUpdateMode)`
  * Method `AcceptWithSmtpEmailConfirmation(Int32, RecurrenceUpdateMode, EMailConnectionInfo)`
  * Method `AssignTo(Int32, ParticipantInfo, RecurrenceUpdateMode)`
  * Method `CalculateDays(AppointmentEntity)`
  * Method `CanAssignToProjectMember(Int32, Int32)`
  * Method `CleanUpBookingDeleted(Int32[])`
  * Method `CleanUpBookingDeletedWithUpdateMode(Int32[], RecurrenceUpdateMode)`
  * Method `CleanUpRecurringBookingDeleted()`
  * Method `ConvertAppointmentToTask(Int32)`
  * Method `CreateAndAccept(Int32, RecurrenceUpdateMode)`
  * Method `CreateAndAcceptWithEmailConfirmation(Int32, RecurrenceUpdateMode)`
  * Method `CreateAppointmentEntityFromExisting(Int32, Int32)`
  * Method `CreateAppointmentForUID(AppointmentEntity, String)`
  * Method `CreateDefault()`
  * Method `CreateDefaultAppointmentEntityByType(TaskType)`
  * Method `CreateDefaultAppointmentEntityByTypeAndAssociate(TaskType, Int32)`
  * Method `CreateDefaultAppointmentEntityFromProjectSuggestion(Int32, Int32, Boolean, Int32)`
  * Method `CreateDefaultAppointmentEntityFromSaleSuggestion(Int32, Int32, Boolean, Int32)`
  * Method `CreateDefaultRecurrence()`
  * Method `CreateDefaultRecurrenceByDate(DateTime)`
  * Method `CreateDefaultReOpenAppointment(Int32)`
  * Method `DeclineInvitationFromEmailItem(Int32, String)`
  * Method `Delete(Int32)`
  * Method `Delete(Int32, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `GetAppointmentEmailInvitation(AppointmentEntity, String, String)`
  * Method `GetAppointmentFromUID(String)`
  * Method `GetAppointmentHaveParticipantsWithEmail(Int32)`
  * Method `GetCanInsertForAssociates(Int32[])`
  * Method `GetFromId(Int32)`
  * Method `GetNextSuggestedAppointmentBySale(Int32, Int32, Boolean)`
  * Method `GetOrganizerName(Int32)`
  * Method `GetUIDFromAppointmentId(Int32, Boolean)`
  * Method `Move(Int32, DateTime, RecurrenceUpdateMode)`
  * Method `MoveExtended(AppointmentMoveData)`
  * Method `MoveWithEmail(Int32, DateTime, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `PopulateCarrierFromDataContainer(AppointmentEntity, AppointmentEntityDataContainer)`
  * Method `PopulateDataContainerFromCarrier(AppointmentEntityDataContainer, AppointmentEntity)`
  * Method `RecalculateStartDate(DateTime, Int32)`
  * Method `Reject(Int32, String, RecurrenceUpdateMode)`
  * Method `RejectWithEmailConfirmation(Int32, String, RecurrenceUpdateMode)`
  * Method `RejectWithSmtpEmailConfirmation(Int32, String, RecurrenceUpdateMode, EMailConnectionInfo)`
  * Method `Save(AppointmentEntity)`
  * Method `Save(AppointmentEntity, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `SaveWithCustomInvitation(AppointmentEntity, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, String, String, String)`
  * Method `SetSeen(Int32, RecurrenceUpdateMode)`
  * Method `SetSeenMany(Int32[], RecurrenceUpdateMode)`
  * Method `UpdateAppointmentFromIcsResponse(String, Stream)`
  * Method `ValidateAppointmentEntity(AppointmentEntity)`
  * Method `ValidateDays(AppointmentEntity, DateTime[])`
  * Method `WillSendEmail(AppointmentEntity)`
* Modified items
  * Method `RemoveDefaultValuesFromTitleAndAgenda(AppointmentEntity)`

##### SuperOffice.CRM.Services.Implementation.BL.AppointmentEntityImplementation.AppointmentEntityDataContainer is Modified

* Deleted items
  * Method `.AppointmentEntityDataContainerAppointmentEntityDataContainer(Appointment)`
  * Method `.AppointmentEntityDataContainerAppointmentEntityDataContainer(Appointment, RecurrenceUpdateMode)`
  * Method `.AppointmentEntityDataContainerAppointmentEntityDataContainer(AppointmentMatrix)`
  * Method `.AppointmentEntityDataContainerAcceptWithSmtpEmailConfirmation(Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `.AppointmentEntityDataContainerDelete()`
  * Method `.AppointmentEntityDataContainerDelete(Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `.AppointmentEntityDataContainerGetAssignedBy(FieldProperty&)`
  * Method `.AppointmentEntityDataContainerGetAssociate(FieldProperty&)`
  * Method `.AppointmentEntityDataContainerGetCreatedBy(FieldProperty&)`
  * Method `.AppointmentEntityDataContainerGetDataContainerFromId(Int32)`
  * Method `.AppointmentEntityDataContainerGetDataContainerFromId(Int32, RecurrenceUpdateMode)`
  * Method `.AppointmentEntityDataContainerGetMotherAssociate(FieldProperty&)`
  * Method `.AppointmentEntityDataContainerGetNewDataContainer(DefaulterStrategy)`
  * Method `.AppointmentEntityDataContainerGetNewDataContainer(TaskType, DefaulterStrategy)`
  * Method `.AppointmentEntityDataContainerGetNewDataContainer(Boolean)`
  * Method `.AppointmentEntityDataContainerGetPriority(FieldProperty&)`
  * Method `.AppointmentEntityDataContainerGetUpdatedBy(FieldProperty&)`
  * Method `.AppointmentEntityDataContainerRejectWithSmtpEmailConfirmation(Boolean, String, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `.AppointmentEntityDataContainerSave()`
  * Method `.AppointmentEntityDataContainerSave(Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `.AppointmentEntityDataContainerSetDefaults(DefaulterStrategy)`
  * Method `.AppointmentEntityDataContainerSetSendMailToParticipants(Boolean, EMailConnectionInfo, EMailConnectionInfo)`
  * Method `.AppointmentEntityDataContainerSetSendMailToParticipants(Boolean, EMailConnectionInfo, EMailConnectionInfo, AppointmentMatrix)`
* Modified items
  * Property `.AppointmentEntityDataContainerAppointmentMatrix`
* New items
  * Method `.AppointmentEntityDataContainerAppointmentEntityDataContainer(IAppointmentMatrix)`
  * Method `.AppointmentEntityDataContainerAppointmentEntityDataContainer(IAppointmentMatrix, IServiceAuthImplementation)`
  * Method `.AppointmentEntityDataContainerAcceptWithSmtpEmailConfirmation(Boolean, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `.AppointmentEntityDataContainerCreateAppointmentEntityDataContainer(Appointment, RecurrenceUpdateMode, CancellationToken)`
  * Method `.AppointmentEntityDataContainerCreateAppointmentEntityDataContainer(Appointment, CancellationToken)`
  * Method `.AppointmentEntityDataContainerDeleteAsync(Boolean, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `.AppointmentEntityDataContainerDeleteAsync(CancellationToken)`
  * Method `.AppointmentEntityDataContainerGetAssignedByAsync(CancellationToken)`
  * Method `.AppointmentEntityDataContainerGetAssociateAsync(CancellationToken)`
  * Method `.AppointmentEntityDataContainerGetCreatedByAsync(CancellationToken)`
  * Method `.AppointmentEntityDataContainerGetDataContainerFromIdAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `.AppointmentEntityDataContainerGetDataContainerFromIdAsync(Int32, CancellationToken)`
  * Method `.AppointmentEntityDataContainerGetMotherAssociateAsync(CancellationToken)`
  * Method `.AppointmentEntityDataContainerGetNewDataContainerAsync(DefaulterStrategy, CancellationToken)`
  * Method `.AppointmentEntityDataContainerGetNewDataContainerAsync(TaskType, DefaulterStrategy, CancellationToken)`
  * Method `.AppointmentEntityDataContainerGetNewDataContainerAsync(Boolean, CancellationToken)`
  * Method `.AppointmentEntityDataContainerGetPriorityAsync(CancellationToken)`
  * Method `.AppointmentEntityDataContainerGetUpdatedByAsync(CancellationToken)`
  * Method `.AppointmentEntityDataContainerRejectWithSmtpEmailConfirmationAsync(Boolean, String, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `.AppointmentEntityDataContainerSaveAsync(Boolean, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `.AppointmentEntityDataContainerSaveAsync(CancellationToken)`
  * Method `.AppointmentEntityDataContainerSetDefaultsAsync(DefaulterStrategy, CancellationToken)`
  * Method `.AppointmentEntityDataContainerSetSendMailToParticipantsAsync(Boolean, EMailConnectionInfo, EMailConnectionInfo, IAppointmentMatrix, CancellationToken)`
  * Method `.AppointmentEntityDataContainerSetSendMailToParticipantsAsync(Boolean, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`

* New items
  * Method `AppointmentEntityImplementation(IArchiveAgent, IContactAgent, ISaleAgent, IPersonAgent, IProjectAgent, ILinkImplementation, IPriorityImplementation, ITaskListItemImplementation, ISoTimeZone, IAppointmentUtility, ICalendarAppointmentUtility, ICalendarUtility, IFieldInfoBaseImplementation, IAppointmentMatrixFactory)`
  * Method `AcceptAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `AcceptRejectedAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `AcceptWithEmailConfirmationAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `AcceptWithSmtpEmailConfirmationAsync(Int32, RecurrenceUpdateMode, EMailConnectionInfo, CancellationToken)`
  * Method `AssignToAsync(Int32, ParticipantInfo, RecurrenceUpdateMode, CancellationToken)`
  * Method `CalculateDaysAsync(AppointmentEntity, CancellationToken)`
  * Method `CanAssignToProjectMemberAsync(Int32, Int32, CancellationToken)`
  * Method `CleanUpBookingDeletedAsync(Int32[], CancellationToken)`
  * Method `CleanUpBookingDeletedWithUpdateModeAsync(Int32[], RecurrenceUpdateMode, CancellationToken)`
  * Method `CleanUpRecurringBookingDeletedAsync(CancellationToken)`
  * Method `ConvertAppointmentToTaskAsync(Int32, CancellationToken)`
  * Method `CreateAndAcceptAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `CreateAndAcceptWithEmailConfirmationAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `CreateAppointmentEntityFromExistingAsync(Int32, Int32, CancellationToken)`
  * Method `CreateAppointmentForUIDAsync(AppointmentEntity, String, CancellationToken)`
  * Method `CreateDefaultAppointmentEntityByTypeAndAssociateAsync(TaskType, Int32, CancellationToken)`
  * Method `CreateDefaultAppointmentEntityByTypeAsync(TaskType, CancellationToken)`
  * Method `CreateDefaultAppointmentEntityFromProjectSuggestionAsync(Int32, Int32, Boolean, Int32, CancellationToken)`
  * Method `CreateDefaultAppointmentEntityFromSaleSuggestionAsync(Int32, Int32, Boolean, Int32, CancellationToken)`
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `CreateDefaultRecurrenceAsync(CancellationToken)`
  * Method `CreateDefaultRecurrenceByDateAsync(DateTime, CancellationToken)`
  * Method `CreateDefaultReOpenAppointmentAsync(Int32, CancellationToken)`
  * Method `DeclineInvitationFromEmailItemAsync(Int32, String, CancellationToken)`
  * Method `DeleteAsync(Int32, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `GetAppointmentEmailInvitationAsync(AppointmentEntity, String, String, CancellationToken)`
  * Method `GetAppointmentFromUIDAsync(String, CancellationToken)`
  * Method `GetAppointmentHaveParticipantsWithEmailAsync(Int32, CancellationToken)`
  * Method `GetCanInsertForAssociatesAsync(Int32[], CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `GetNextSuggestedAppointmentBySaleAsync(Int32, Int32, Boolean, CancellationToken)`
  * Method `GetOrganizerNameAsync(Int32, CancellationToken)`
  * Method `GetUIDFromAppointmentIdAsync(Int32, Boolean, CancellationToken)`
  * Method `MoveAsync(Int32, DateTime, RecurrenceUpdateMode, CancellationToken)`
  * Method `MoveExtendedAsync(AppointmentMoveData, CancellationToken)`
  * Method `MoveWithEmailAsync(Int32, DateTime, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `PopulateCarrierFromDataContainerAsync(AppointmentEntity, AppointmentEntityDataContainer, CancellationToken)`
  * Method `PopulateDataContainerFromCarrierAsync(AppointmentEntityDataContainer, AppointmentEntity, CancellationToken)`
  * Method `RejectAsync(Int32, String, RecurrenceUpdateMode, CancellationToken)`
  * Method `RejectWithEmailConfirmationAsync(Int32, String, RecurrenceUpdateMode, CancellationToken)`
  * Method `RejectWithSmtpEmailConfirmationAsync(Int32, String, RecurrenceUpdateMode, EMailConnectionInfo, CancellationToken)`
  * Method `SaveAsync(AppointmentEntity, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `SaveAsync(AppointmentEntity, CancellationToken)`
  * Method `SaveWithCustomInvitationAsync(AppointmentEntity, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, String, String, String, CancellationToken)`
  * Method `SetSeenAsync(Int32, RecurrenceUpdateMode, CancellationToken)`
  * Method `SetSeenManyAsync(Int32[], RecurrenceUpdateMode, CancellationToken)`
  * Method `UpdateAppointmentFromIcsResponseAsync(String, Stream, CancellationToken)`
  * Method `ValidateAppointmentEntityAsync(AppointmentEntity, CancellationToken)`
  * Method `ValidateDaysAsync(AppointmentEntity, DateTime[], CancellationToken)`
  * Method `WillSendEmailAsync(AppointmentEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.AppointmentImplementation is Modified

* Deleted items
  * Method `AppointmentImplementation()`
  * Method `ConvertShortToBool(Int16)`
  * Method `ConvertShortToTimeSpan(Int16)`
  * Method `GetAppointment(Int32)`
  * Method `GetAppointmentsListItemSelect(AppointmentTableInfo, AssociateTableInfo)`
  * Method `GetAppointmentsListItemSelect(AppointmentTableInfo, AssociateTableInfo, PublishTableInfo, PublishTableInfo)`
  * Method `GetAppointmentsListItemSelect(AppointmentTableInfo, AssociateTableInfo, PublishTableInfo, PublishTableInfo, Int32)`
  * Method `GetAppointmentsListItemSelect(AppointmentTableInfo, AssociateTableInfo, PublishTableInfo, PublishTableInfo, Int32, Boolean)`
  * Method `GetNextSuggestedAppointment(Int32, Int32, Boolean)`
  * Method `IsAllowedToSetCompleted(String, ActivityStatus)`
  * Method `PopulateAppointmentFromEntity(AppointmentEntity)`
  * Method `PopulateFromSelectCommand(Select)`
  * Method `PopulateFromSoDataReader(SoDataReader)`
  * Method `SetActivityStatus(String[], ActivityStatus)`
  * Method `ToggleActivities(String[])`
  * Method `ToggleActivity(String)`
  * Method `ToggleAndSetActivities(String[])`
  * Method `ToggleAppointmentStatus(Int32)`
* New items
  * Method `AppointmentImplementation(IAssociateAgent)`
  * Method `GetAppointmentAsync(Int32, CancellationToken)`
  * Method `SetActivityStatusAsync(String[], ActivityStatus, CancellationToken)`
  * Method `ToggleActivitiesAsync(String[], CancellationToken)`
  * Method `ToggleActivityAsync(String, CancellationToken)`
  * Method `ToggleAndSetActivitiesAsync(String[], CancellationToken)`
  * Method `ToggleAppointmentStatusAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.AppointmentListImplementation is Modified

* Deleted items
  * Method `AppointmentListImplementation()`
  * Method `GetAppointmentList(Int32[])`
  * Method `GetAppointmentRecords(Int32, Int32)`
  * Method `GetAppointmentsByTaskHeading(Int32)`
  * Method `GetAssociateDiary(Int32, DateTime, DateTime, Int32)`
  * Method `GetAssociatesDiary(Int32[], DateTime, DateTime)`
  * Method `GetAssociatesDiaryInfo(Int32[], DateTime, DateTime, Int32)`
  * Method `GetContactAppointments(Int32, DateTime, DateTime, Int32)`
  * Method `GetContactAppointmentsByTask(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetContactAppointmentsByTaskHeading(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetContactAppointmentsByTasks(Int32, DateTime, DateTime, Int32, Int32[])`
  * Method `GetContactAppointmentsByType(Int32, DateTime, DateTime, Int32, AppointmentType)`
  * Method `GetContactDocumentAppointmentsByTemplateHeading(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetDiaryByGroup(Int32, Int32, DateTime, DateTime, Int32)`
  * Method `GetDocumentAppointmentsByTemplateHeading(Int32)`
  * Method `GetMyAppointments(DateTime, DateTime, Int32)`
  * Method `GetMyDiary(DateTime, DateTime, Int32)`
  * Method `GetMyPublishedAppointments()`
  * Method `GetMyTasks(Int32)`
  * Method `GetPersonAppointments(Int32, Boolean, DateTime, DateTime, Int32)`
  * Method `GetPersonAppointmentsByTask(Int32, Boolean, DateTime, DateTime, Int32, Int32)`
  * Method `GetPersonAppointmentsByTaskHeading(Int32, Boolean, DateTime, DateTime, Int32, Int32)`
  * Method `GetPersonAppointmentsByTasks(Int32, Boolean, DateTime, DateTime, Int32, Int32[])`
  * Method `GetPersonAppointmentsByType(Int32, Boolean, DateTime, DateTime, Int32, AppointmentType)`
  * Method `GetPersonDiary(Int32, DateTime, DateTime, Int32)`
  * Method `GetPersonTasks(Int32, Int32)`
  * Method `GetProjectAppointments(Int32, DateTime, DateTime, Int32)`
  * Method `GetProjectAppointmentsByTask(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetProjectAppointmentsByTaskHeading(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetProjectAppointmentsByTasks(Int32, DateTime, DateTime, Int32, Int32[])`
  * Method `GetProjectAppointmentsByType(Int32, DateTime, DateTime, Int32, AppointmentType)`
  * Method `GetProjectMemberAppointments(Int32, DateTime, DateTime, Int32)`
  * Method `GetProjectMemberAppointmentsByTask(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetProjectMemberAppointmentsByTaskHeading(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetProjectMemberAppointmentsByTasks(Int32, DateTime, DateTime, Int32, Int32[])`
  * Method `GetProjectMemberAppointmentsByType(Int32, DateTime, DateTime, Int32, AppointmentType)`
  * Method `GetProjectMemberDocumentAppointmentsByTemplateHeading(Int32, DateTime, DateTime, Int32, Int32)`
  * Method `GetPublishedAppointment(Int32)`
  * Method `GetPublishedAppointments(Int32[])`
  * Method `GetPublishedProjectAppointments(Int32)`
  * Method `UpdateAppointment(Int32, DateTime, DateTime, Int32, Int32, Int32)`
  * Method `UpdateAppointmentWithMode(Int32, DateTime, DateTime, AppointmentStatus, AppointmentType, Int32, RecurrenceUpdateMode)`
  * Method `UpdateAppointmentWithModeAndEmail(Int32, DateTime, DateTime, AppointmentStatus, AppointmentType, Int32, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo)`
* New items
  * Method `AppointmentListImplementation(IAppointmentEntityImplementation, IAppointmentUtility)`
  * Method `GetAppointmentListAsync(Int32[], CancellationToken)`
  * Method `GetAppointmentRecordsAsync(Int32, Int32, CancellationToken)`
  * Method `GetAppointmentsByTaskHeadingAsync(Int32, CancellationToken)`
  * Method `GetAssociateDiaryAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetAssociatesDiaryAsync(Int32[], DateTime, DateTime, CancellationToken)`
  * Method `GetAssociatesDiaryInfoAsync(Int32[], DateTime, DateTime, CancellationToken)`
  * Method `GetContactAppointmentsAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetContactAppointmentsByTaskAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetContactAppointmentsByTaskHeadingAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetContactAppointmentsByTasksAsync(Int32, DateTime, DateTime, Int32, Int32[], CancellationToken)`
  * Method `GetContactAppointmentsByTypeAsync(Int32, DateTime, DateTime, Int32, AppointmentType, CancellationToken)`
  * Method `GetContactDocumentAppointmentsByTemplateHeadingAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetDiaryByGroupAsync(Int32, Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetDocumentAppointmentsByTemplateHeadingAsync(Int32, CancellationToken)`
  * Method `GetMyAppointmentsAsync(DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetMyDiaryAsync(DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetMyPublishedAppointmentsAsync(CancellationToken)`
  * Method `GetMyTasksAsync(Int32, CancellationToken)`
  * Method `GetPersonAppointmentsAsync(Int32, Boolean, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetPersonAppointmentsByTaskAsync(Int32, Boolean, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetPersonAppointmentsByTaskHeadingAsync(Int32, Boolean, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetPersonAppointmentsByTasksAsync(Int32, Boolean, DateTime, DateTime, Int32, Int32[], CancellationToken)`
  * Method `GetPersonAppointmentsByTypeAsync(Int32, Boolean, DateTime, DateTime, Int32, AppointmentType, CancellationToken)`
  * Method `GetPersonDiaryAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetPersonTasksAsync(Int32, Int32, CancellationToken)`
  * Method `GetProjectAppointmentsAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetProjectAppointmentsByTaskAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetProjectAppointmentsByTaskHeadingAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetProjectAppointmentsByTasksAsync(Int32, DateTime, DateTime, Int32, Int32[], CancellationToken)`
  * Method `GetProjectAppointmentsByTypeAsync(Int32, DateTime, DateTime, Int32, AppointmentType, CancellationToken)`
  * Method `GetProjectMemberAppointmentsAsync(Int32, DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetProjectMemberAppointmentsByTaskAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetProjectMemberAppointmentsByTaskHeadingAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetProjectMemberAppointmentsByTasksAsync(Int32, DateTime, DateTime, Int32, Int32[], CancellationToken)`
  * Method `GetProjectMemberAppointmentsByTypeAsync(Int32, DateTime, DateTime, Int32, AppointmentType, CancellationToken)`
  * Method `GetProjectMemberDocumentAppointmentsByTemplateHeadingAsync(Int32, DateTime, DateTime, Int32, Int32, CancellationToken)`
  * Method `GetPublishedAppointmentAsync(Int32, CancellationToken)`
  * Method `GetPublishedAppointmentsAsync(Int32[], CancellationToken)`
  * Method `GetPublishedProjectAppointmentsAsync(Int32, CancellationToken)`
  * Method `UpdateAppointmentAsync(Int32, DateTime, DateTime, Int32, Int32, Int32, CancellationToken)`
  * Method `UpdateAppointmentWithModeAndEmailAsync(Int32, DateTime, DateTime, AppointmentStatus, AppointmentType, Int32, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `UpdateAppointmentWithModeAsync(Int32, DateTime, DateTime, AppointmentStatus, AppointmentType, Int32, RecurrenceUpdateMode, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.AppointmentSyncDataImplementation is Modified

* Deleted items
  * Method `GetMySyncAppointments(DateTime, DateTime)`
  * Method `GetMySyncAppointmentsOld(DateTime, DateTime)`
* New items
  * Method `AppointmentSyncDataImplementation()`
  * Method `GetMySyncAppointmentsAsync(DateTime, DateTime, CancellationToken)`
  * Method `GetMySyncAppointmentsOldAsync(DateTime, DateTime, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.AssociateImplementation is Modified

* Deleted items
  * Method `GetAssociate(Int32)`
  * Method `GetAssociateByPersonId(Int32)`
  * Method `GetEncryptionKey()`
  * Method `GetNote(Int32)`
  * Method `PopulateFromHDB(AssociateRecordData)`
  * Method `PopulateFromHDB(AssociateRow)`
  * Method `SaveNote(Int32, String[])`
* New items
  * Method `GetAssociateAsync(Int32, CancellationToken)`
  * Method `GetAssociateByPersonIdAsync(Int32, CancellationToken)`
  * Method `GetEncryptionKeyAsync(CancellationToken)`
  * Method `GetNoteAsync(Int32, CancellationToken)`
  * Method `PopulateFromHDBAsync(AssociateRecordData, CancellationToken)`
  * Method `PopulateFromHDBAsync(AssociateRow, CancellationToken)`
  * Method `SaveNoteAsync(Int32, String[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.AttachmentEntityImplementation is Modified

* Deleted items
  * Method `AttachmentEntityImplementation()`
  * Method `CopyFromCRMDocument(Int32)`
  * Method `CopyToTempFile(String, Int32)`
  * Method `CreateDefault()`
  * Method `GetAttachmentStream(Int32)`
  * Method `GetFromId(Int32)`
  * Method `Insert(String, String, Stream)`
  * Method `Save(AttachmentEntity)`
  * Method `UploadAttachment(Int32, Stream)`
* New items
  * Method `AttachmentEntityImplementation(IDocumentAgent)`
  * Method `CopyFromCRMDocumentAsync(Int32, CancellationToken)`
  * Method `CopyToTempFileAsync(String, Int32, CancellationToken)`
  * Method `CreateDefaultAttachmentEntityAsync(CancellationToken)`
  * Method `GetAttachmentEntityAsync(Int32, CancellationToken)`
  * Method `GetAttachmentStreamAsync(Int32, CancellationToken)`
  * Method `SaveAttachmentEntityAsync(AttachmentEntity, CancellationToken)`
  * Method `UploadAttachmentAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CacheInvalidationImplementation is Modified

* Deleted items
  * Method `GetCacheInvalidationGenerations(String[])`
* New items
  * Method `CacheInvalidationImplementation()`
  * Method `GetCacheInvalidationGenerationsAsync(String[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CallerIDImplementation is Modified

* Deleted items
  * Method `GetCallerIDsFromSelection(Int32, String)`
  * Method `GetMyCallerIDs(String, DateTime, DateTime)`
* New items
  * Method `CallerIDImplementation(ISelectionAgent, ILogger<CallerIDImplementation>)`
  * Method `GetCallerIDsFromSelectionAsync(Int32, String, CancellationToken)`
  * Method `GetMyCallerIDsAsync(String, DateTime, DateTime, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CategorizationStatusResponseImplementation is Modified

* Deleted items
  * Method `GetTrainingStatus()`
* New items
  * Method `CategorizationStatusResponseImplementation()`
  * Method `GetTrainingStatusAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CategoryGuessImplementation is Modified

* Deleted items
  * Method `GuessCategory(Int32)`
  * Method `TrainCategoryGuesser(Int32, Int32, Int32)`
* New items
  * Method `CategoryGuessImplementation()`
  * Method `GuessCategoryAsync(Int32, CancellationToken)`
  * Method `TrainCategoryGuesserAsync(Int32, Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ChatSessionEntityImplementation is Modified

* Deleted items
  * Method `ChatSessionEntityImplementation()`
  * Method `ChatSessionsForUser()`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `Save(ChatSessionEntity)`
* New items
  * Method `ChatSessionEntityImplementation(IContactImplementation, ITicketImplementation, IAssociateImplementation, IChatSessionImplementation, IProjectImplementation, IPersonImplementation, ISaleImplementation)`
  * Method `AcceptChatSessionTransferAsync(Int32, CancellationToken)`
  * Method `AddChatMessageAsync(Int32, ChatMessage, CancellationToken)`
  * Method `ChatSessionsForUserAsync(CancellationToken)`
  * Method `CreateDefaultChatSessionEntityAsync(CancellationToken)`
  * Method `DeleteChatSessionEntityAsync(Int32, CancellationToken)`
  * Method `GetChatMessagesAsync(Int32, Int32, CancellationToken)`
  * Method `GetChatSessionEntityAsync(Int32, CancellationToken)`
  * Method `GetChatTranscriptAsync(Int32, Boolean, CancellationToken)`
  * Method `PickUpChatSessionAsync(Int32, CancellationToken)`
  * Method `PickUpFirstChatSessionAsync(CancellationToken)`
  * Method `RejectChatSessionTransferAsync(Int32, CancellationToken)`
  * Method `ResetChatSessionAsync(Int32, CancellationToken)`
  * Method `SaveChatSessionEntityAsync(ChatSessionEntity, CancellationToken)`
  * Method `TransferChatSessionAsync(Int32, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ChatSessionImplementation is Modified

* Deleted items
  * Method `ChatSessionsForUser()`
  * Method `DeleteChatSessions(Int32[])`
* New items
  * Method `ChatSessionImplementation()`
  * Method `ChatSessionsForUserAsync(CancellationToken)`
  * Method `DeleteChatSessionsAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ChatTopicAgentImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
* New items
  * Method `CreateDefaultChatTopicAgentAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ChatTopicEntityImplementation is Modified

* Deleted items
  * Method `ChatTopicEntityImplementation()`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `IsWithinOpeningHours(Int32)`
  * Method `Save(ChatTopicEntity)`
* New items
  * Method `ChatTopicEntityImplementation(IChatSessionEntityImplementation, IAssociateImplementation, ITicketPriorityImplementation, ICustomerLanguageImplementation, ITicketCategoryImplementation, IMDOAgent)`
  * Method `AddChatTopicUserAgentAsync(Int32, ChatTopicAgent, CancellationToken)`
  * Method `ChatTopicsForUserAsync(CancellationToken)`
  * Method `CreateChatSessionForTopicAsync(Int32, CancellationToken)`
  * Method `CreateDefaultChatTopicEntityAsync(CancellationToken)`
  * Method `DeleteChatTopicEntityAsync(Int32, CancellationToken)`
  * Method `DeleteChatTopicUserAgentAsync(Int32, String, CancellationToken)`
  * Method `GetChatTopicEntityAsync(Int32, CancellationToken)`
  * Method `GetChatTopicUserAgentAsync(Int32, String, CancellationToken)`
  * Method `GetChatTopicUserAgentListAsync(Int32, CancellationToken)`
  * Method `GetUserAgentListAsync(Boolean, Boolean, CancellationToken)`
  * Method `IsWithinOpeningHoursAsync(Int32, CancellationToken)`
  * Method `SaveChatTopicEntityAsync(ChatTopicEntity, CancellationToken)`
  * Method `UpdateChatTopicUserAgentAsync(Int32, String, ChatTopicAgent, CancellationToken)`
  * Method `UpdateChatTopicUserAgentsAsync(Int32, ChatTopicAgent[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CompetitorImplementation is Modified

* Deleted items
  * Method `GetCompetitor(Int32)`
* Modified items
  * Method `PopulateFromHDB(ComptrRow)`
  * Method `PopulateFromHDB(ComptrRows)`
* New items
  * Method `GetCompetitorAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ConsentPersonImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `PopulateFromHDB(ConsentPersonRow)`
  * Method `Save(ConsentPerson)`
* New items
  * Method `ConsentPersonImplementation(IConsentPurposeImplementation, IConsentSourceImplementation, ILegalBaseImplementation)`
  * Method `CreateDefaultConsentPersonAsync(CancellationToken)`
  * Method `DeleteConsentPersonAsync(Int32, CancellationToken)`
  * Method `GetConsentPersonAsync(Int32, CancellationToken)`
  * Method `SaveConsentPersonAsync(ConsentPerson, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ConsentPurposeListImplementation is Modified

* Deleted items
  * Method `GetConsentPurposeList(Int32[])`
  * Method `GetConsentPurposes()`
* New items
  * Method `ConsentPurposeListImplementation(IAssociateImplementation)`
  * Method `GetConsentPurposeListAsync(Int32[], CancellationToken)`
  * Method `GetConsentPurposesAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ConsentSourceListImplementation is Modified

* Deleted items
  * Method `GetAllConsentSource()`
  * Method `GetConsentSourceList(Int32[])`
  * Method `GetConsentSources()`
* New items
  * Method `ConsentSourceListImplementation()`
  * Method `GetAllConsentSourceAsync(CancellationToken)`
  * Method `GetConsentSourceListAsync(Int32[], CancellationToken)`
  * Method `GetConsentSourcesAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ContactEntityImplementation is Modified

* Deleted items
  * Method `ContactEntityImplementation()`
  * Method `AddPerson(Int32, PersonEntity)`
  * Method `ChangeCountry(ContactEntity, Int32)`
  * Method `Copy(Int32, String, String, Boolean)`
  * Method `CreateDefault()`
  * Method `CreateNewEntry(DuplicateEntry)`
  * Method `Delete(Int32)`
  * Method `DeleteExpired()`
  * Method `GetAddress(Int32)`
  * Method `GetAddressByCountry(Int32, Int32)`
  * Method `GetContactSummary(Int32, Int32)`
  * Method `GetContactWithPersons(Int32)`
  * Method `GetDomainDuplicates(String)`
  * Method `GetDuplicateRules()`
  * Method `GetDuplicates(String)`
  * Method `GetFromId(Int32)`
  * Method `GetMyBizCard()`
  * Method `GetMyContact()`
  * Method `GetNameDepartmentDuplicates(String, String)`
  * Method `GetPersons(Int32)`
  * Method `GetQuoteVersionAddresses(Int32)`
  * Method `IsNumberValid(Int32, String)`
  * Method `Merge(Int32, Int32, Boolean, Boolean)`
  * Method `PopulateCarrierFromDataContainer(ContactEntity, ContactEntityDataContainer)`
  * Method `PopulateDataContainerFromCarrier(ContactEntityDataContainer, ContactEntity)`
  * Method `Save(ContactEntity)`
  * Method `SaveQuoteVersionAddress(Int32, Address, AddressType, Int32)`
  * Method `SetDuplicateRulesStatus(DuplicateRule[])`
  * Method `Undelete(Int32)`
  * Method `ValidateContactEntity(ContactEntity)`
* Modified items

##### SuperOffice.CRM.Services.Implementation.BL.ContactEntityImplementation.ContactEntityDataContainer is Modified

* Deleted items
  * Method `.ContactEntityDataContainerDelete()`
  * Method `.ContactEntityDataContainerGetCompanyDomains(FieldProperty&)`
  * Method `.ContactEntityDataContainerGetCustomerLanguage(FieldProperty&)`
  * Method `.ContactEntityDataContainerGetEmails(FieldProperty&)`
  * Method `.ContactEntityDataContainerGetNewDataContainer(DefaulterStrategy)`
  * Method `.ContactEntityDataContainerGetNewDataContainer(Boolean)`
  * Method `.ContactEntityDataContainerGetSupportAssociate(FieldProperty&)`
  * Method `.ContactEntityDataContainerGetTicketPriority(FieldProperty&)`
  * Method `.ContactEntityDataContainerGetUrls(FieldProperty&)`
  * Method `.ContactEntityDataContainerSave()`
  * Method `.ContactEntityDataContainerSetDefaults(DefaulterStrategy)`
* New items
  * Method `.ContactEntityDataContainerDeleteAsync(CancellationToken)`
  * Method `.ContactEntityDataContainerGetCompanyDomainsAsync(CancellationToken)`
  * Method `.ContactEntityDataContainerGetCustomerLanguageAsync(CancellationToken)`
  * Method `.ContactEntityDataContainerGetEmailsAsync(CancellationToken)`
  * Method `.ContactEntityDataContainerGetNewDataContainerAsync(DefaulterStrategy, CancellationToken)`
  * Method `.ContactEntityDataContainerGetNewDataContainerAsync(Boolean, CancellationToken)`
  * Method `.ContactEntityDataContainerGetSupportAssociateAsync(CancellationToken)`
  * Method `.ContactEntityDataContainerGetTicketPriorityAsync(CancellationToken)`
  * Method `.ContactEntityDataContainerGetUrlsAsync(CancellationToken)`
  * Method `.ContactEntityDataContainerSaveAsync(CancellationToken)`
  * Method `.ContactEntityDataContainerSetDefaultsAsync(DefaulterStrategy, CancellationToken)`

* New items
  * Method `ContactEntityImplementation(IContactImplementation, IArchiveAgent, IPersonImplementation, IPersonListImplementation, IPersonEntityImplementation, ILogger<ContactEntityImplementation>, IBusinessImplementation, ICategoryImplementation, ICountryImplementation, ITicketPriorityImplementation, ICustomerLanguageImplementation, IFieldInfoBaseImplementation, IDuplicateDetectorFactory, IQuoteManagerFactory)`
  * Method `AddPersonAsync(Int32, PersonEntity, CancellationToken)`
  * Method `ChangeCountryAsync(ContactEntity, Int32, CancellationToken)`
  * Method `CopyAsync(Int32, String, String, Boolean, CancellationToken)`
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `CreateNewEntryAsync(DuplicateEntry, CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `DeleteExpiredAsync(CancellationToken)`
  * Method `GetAddressAsync(Int32, CancellationToken)`
  * Method `GetAddressByCountryAsync(Int32, Int32, CancellationToken)`
  * Method `GetContactSummaryAsync(Int32, Int32, CancellationToken)`
  * Method `GetContactWithPersonsAsync(Int32, CancellationToken)`
  * Method `GetDomainDuplicatesAsync(String, CancellationToken)`
  * Method `GetDuplicateRulesAsync(CancellationToken)`
  * Method `GetDuplicatesAsync(String, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `GetMyBizCardAsync(CancellationToken)`
  * Method `GetMyContactAsync(CancellationToken)`
  * Method `GetNameDepartmentDuplicatesAsync(String, String, CancellationToken)`
  * Method `GetPersonsAsync(Int32, CancellationToken)`
  * Method `GetQuoteVersionAddressesAsync(Int32, CancellationToken)`
  * Method `IsNumberValidAsync(Int32, String, CancellationToken)`
  * Method `MergeAsync(Int32, Int32, Boolean, Boolean, CancellationToken)`
  * Method `PopulateCarrierFromDataContainerAsync(ContactEntity, ContactEntityDataContainer, CancellationToken)`
  * Method `PopulateDataContainerFromCarrierAsync(ContactEntityDataContainer, ContactEntity, CancellationToken)`
  * Method `SaveAsync(ContactEntity, CancellationToken)`
  * Method `SaveQuoteVersionAddressAsync(Int32, Address, AddressType, Int32, CancellationToken)`
  * Method `SetDuplicateRulesStatusAsync(DuplicateRule[], CancellationToken)`
  * Method `UndeleteAsync(Int32, CancellationToken)`
  * Method `ValidateContactEntityAsync(ContactEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ContactImplementation is Modified

* Deleted items
  * Method `CreateDefaultContact()`
  * Method `GetContact(Int32)`
  * Method `PopulateFromRDB(CustomSearch)`
  * Method `PopulateFromRDBItem(ContactListItem)`
* New items
  * Method `CreateDefaultContactAsync(CancellationToken)`
  * Method `GetContactAsync(Int32, CancellationToken)`
  * Method `PopulateFromRDBAsync(CustomSearch, CancellationToken)`
  * Method `PopulateFromRDBItemAsync(ContactListItem, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CredentialImplementation is Modified

* Deleted items
  * Method `DeleteCredential(Int32, String)`
  * Method `FindCredentialsGroups(String, String)`
  * Method `FindCredentialUsers(String, String)`
  * Method `GetCredentialsGroups(String)`
  * Method `GetCredentialTypes()`
  * Method `GetCredentialTypesForUserType(UserType)`
  * Method `GetCredentialUsers(String, String)`
  * Method `GetCredentialUsersInGroup(String, String)`
  * Method `SaveCredential(Int32, Credential)`
* New items
  * Method `CredentialImplementation(ICredentialsManager)`
  * Method `DeleteCredentialAsync(Int32, String, CancellationToken)`
  * Method `FindCredentialsGroupsAsync(String, String, CancellationToken)`
  * Method `FindCredentialUsersAsync(String, String, CancellationToken)`
  * Method `GetCredentialUsersInGroupAsync(String, String, CancellationToken)`
  * Method `SaveCredentialAsync(Int32, Credential, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CreditedImplementation is Modified

* Deleted items
  * Method `GetCredited(Int32)`
* Modified items
  * Method `PopulateFromHDB(CreditedRow)`
  * Method `PopulateListFromHDB(CreditedRows)`
* New items
  * Method `GetCreditedAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CRMScriptEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `ExecuteScript(Int32, StringDictionary)`
  * Method `ExecuteScriptAsEvent(Int32, EventData)`
  * Method `ExecuteScriptAsEventByUniqueId(String, EventData)`
  * Method `ExecuteScriptByIncludeId(String, StringDictionary)`
  * Method `ExecuteScriptByString(String, StringDictionary, EventData)`
  * Method `ExecuteScriptByUniqueId(String, StringDictionary)`
  * Method `GetFromId(Int32)`
  * Method `ResolveIncludes(String, Boolean)`
  * Method `Save(CRMScriptEntity)`
  * Method `SaveCRMScriptEntityWithoutCompile(CRMScriptEntity)`
  * Method `ValidateScript(Int32)`
  * Method `ValidateScriptByIncludeId(String)`
  * Method `ValidateScriptByString(String)`
  * Method `ValidateScriptByUniqueId(String)`
* New items
  * Method `CRMScriptEntityImplementation()`
  * Method `CreateDefaultCRMScriptEntityAsync(CancellationToken)`
  * Method `DeleteCRMScriptEntityAsync(Int32, CancellationToken)`
  * Method `ExecuteScriptAsEventAsync(Int32, EventData, CancellationToken)`
  * Method `ExecuteScriptAsEventByUniqueIdAsync(String, EventData, CancellationToken)`
  * Method `ExecuteScriptAsync(Int32, StringDictionary, CancellationToken)`
  * Method `ExecuteScriptByIncludeIdAsync(String, StringDictionary, CancellationToken)`
  * Method `ExecuteScriptByStringAsync(String, StringDictionary, EventData, CancellationToken)`
  * Method `ExecuteScriptByUniqueIdAsync(String, StringDictionary, CancellationToken)`
  * Method `GetCRMScriptEntityAsync(Int32, CancellationToken)`
  * Method `ResolveIncludesAsync(String, Boolean, CancellationToken)`
  * Method `SaveCRMScriptEntityAsync(CRMScriptEntity, CancellationToken)`
  * Method `SaveCRMScriptEntityWithoutCompileAsync(CRMScriptEntity, CancellationToken)`
  * Method `ValidateScriptAsync(Int32, CancellationToken)`
  * Method `ValidateScriptByIncludeIdAsync(String, CancellationToken)`
  * Method `ValidateScriptByStringAsync(String, CancellationToken)`
  * Method `ValidateScriptByUniqueIdAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CsFeatureToggleImplementation is Modified

* Deleted items
  * Method `EventHandlerExists(EventHandlerType)`
  * Method `EventHandlersExists(EventHandlerType[])`
  * Method `UpdateFeatureToggles(CsFeatureToggle[])`
* New items
  * Method `CsFeatureToggleImplementation()`
  * Method `EventHandlerExistsAsync(EventHandlerType, CancellationToken)`
  * Method `EventHandlersExistsAsync(EventHandlerType[], CancellationToken)`
  * Method `UpdateFeatureTogglesAsync(CsFeatureToggle[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CsSessionKeyImplementation is Modified

* Deleted items
  * Method `CheckSymmetricEncryption(String)`
  * Method `CreateSession(String)`
  * Method `HasChatNotify()`
  * Method `RemoveSession(Int32)`
  * Method `ReportSessionActive(String)`
  * Method `SessionIsValid(String)`
* New items
  * Method `CsSessionKeyImplementation(ICsSessionManager)`
  * Method `CheckSymmetricEncryptionAsync(String, CancellationToken)`
  * Method `CreateSessionAsync(String, CancellationToken)`
  * Method `HasChatNotifyAsync(CancellationToken)`
  * Method `RemoveSessionAsync(Int32, CancellationToken)`
  * Method `ReportSessionActiveAsync(String, CancellationToken)`
  * Method `SessionIsValidAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CurrencyEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetBaseCurrency()`
  * Method `GetFromId(Int32)`
  * Method `PopulateFromEntity(CurrencyEntity)`
  * Method `Save(CurrencyEntity)`
* Modified items
  * Method `PopulateFromRow(CurrencyRow)`
* New items
  * Method `CreateDefaultCurrencyEntityAsync(CancellationToken)`
  * Method `GetBaseCurrencyAsync(CancellationToken)`
  * Method `GetCurrencyEntityAsync(Int32, CancellationToken)`
  * Method `SaveCurrencyEntityAsync(CurrencyEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CurrencyImplementation is Modified

* Deleted items
  * Method `ChangeCurrency(Double, String, String)`
  * Method `GetCurrency(Int32)`
  * Method `GetOurCurrency()`
  * Method `GetOwnerCompanysCurrency()`
  * Method `populateListFromHDB(CurrencyRows)`
* Modified items
  * Method `PopulateFromHDB(CurrencyRow)`
* New items
  * Method `ChangeCurrencyAsync(Double, String, String, CancellationToken)`
  * Method `GetCurrencyAsync(Int32, CancellationToken)`
  * Method `GetOurCurrencyAsync(CancellationToken)`
  * Method `GetOwnerCompanysCurrencyAsync(CancellationToken)`
  * Method `PopulateListFromHDB(CurrencyRows)`

#### SuperOffice.CRM.Services.Implementation.BL.CustomerCenterConfigImplementation is Modified

* Deleted items
  * Method `CheckIfCustomizedTemplates()`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetAllCustomerCenterConfigs()`
  * Method `GetFromId(Int32)`
  * Method `Save(CustomerCenterConfig)`
  * Method `SaveAllCustomerCenterConfigs(CustomerCenterConfig[])`
* New items
  * Method `CustomerCenterConfigImplementation(IWebAppUsageImplementation)`
  * Method `CheckIfCustomizedTemplatesAsync(CancellationToken)`
  * Method `CreateDefaultCustomerCenterConfigAsync(CancellationToken)`
  * Method `DeleteCustomerCenterConfigAsync(Int32, CancellationToken)`
  * Method `GetAllCustomerCenterConfigsAsync(CancellationToken)`
  * Method `GetCustomerCenterConfigAsync(Int32, CancellationToken)`
  * Method `SaveAllCustomerCenterConfigsAsync(CustomerCenterConfig[], CancellationToken)`
  * Method `SaveCustomerCenterConfigAsync(CustomerCenterConfig, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CustomerServiceConfigImplementation is Modified

* Deleted items
  * Method `GetFaqForCustomer(Int32)`
  * Method `GetProgramUrl(String, Boolean)`
* New items
  * Method `CustomerServiceConfigImplementation()`
  * Method `GetFaqForCustomerAsync(Int32, CancellationToken)`
  * Method `GetProgramUrlAsync(String, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CustomerServiceStartupImplementation is Modified

* Deleted items
  * Method `GetCustomerServiceStartup()`
  * Method `GetCustomerServiceStartupByOwner(Int32)`
* New items
  * Method `CustomerServiceStartupImplementation(IPreferenceImplementation)`
  * Method `GetCustomerServiceStartupAsync(CancellationToken)`
  * Method `GetCustomerServiceStartupByOwnerAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CustomerServiceUpdater is Modified

* Deleted items
  * Method `FlushTempLicenseInCSConfig()`
  * Method `MoveCcTemplatesIntoDB(Boolean)`
  * Method `Update_CS_DB()`
  * Method `Update_CS_Packages(IProgressNotification)`
  * Method `Update_Customer_Centre()`
* New items
  * Method `FlushTempLicenseInCSConfigAsync()`
  * Method `MoveCcTemplatesIntoDBAsync(Boolean)`
  * Method `Update_CS_DBAsync()`
  * Method `Update_CS_PackagesAsync(IProgressNotification)`
  * Method `Update_Customer_CentreAsync()`

#### SuperOffice.CRM.Services.Implementation.BL.CustomObjectEntityImplementation is Modified

* Deleted items
  * Method `GetCustomObjectIconList()`
  * Method `GetCustomObjectMetadata()`
  * Method `GetDefaultValues(String)`
* New items
  * Method `GetCustomObjectIconListAsync(CancellationToken)`
  * Method `GetCustomObjectMetadataAsync()`
  * Method `GetDefaultValuesAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DashCollectionImplementation is Modified

* Deleted items
  * Method `DashCollectionImplementation()`
  * Method `CreateDefault()`
  * Method `GetDashCollection()`
* New items
  * Method `DashCollectionImplementation(IDashImplementation)`
  * Method `CreateDefaultDashCollectionAsync(CancellationToken)`
  * Method `GetDashCollectionAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DashImplementation is Modified

* Deleted items
  * Method `DashImplementation()`
  * Method `AddNewTileToDashboard(Int32, DashTileDefinition)`
  * Method `AddTileToDashboard(Int32, Int32)`
  * Method `CanEditLayout(DashTileDefinition)`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `DuplicateDashboard(Int32, String)`
  * Method `GetDashList(Int32[])`
  * Method `GetFavourites()`
  * Method `GetFromId(Int32)`
  * Method `GetIdsFromHistory()`
  * Method `GetPinned()`
  * Method `Save(Dash, String)`
* Modified items
  * Method `PopulateFromRow(DashboardRow)`
* New items
  * Method `DashImplementation(IDashTileImplementation, IDashTileDefinitionImplementation, IDashThemeImplementation, IFavouriteImplementation, IHistoryListImplementation)`
  * Method `AddNewTileToDashboardAsync(Int32, DashTileDefinition, CancellationToken)`
  * Method `AddTileToDashboardAsync(Int32, Int32, CancellationToken)`
  * Method `CreateDefaultDashAsync(CancellationToken)`
  * Method `DeleteDashAsync(Int32, CancellationToken)`
  * Method `DuplicateDashboardAsync(Int32, String, CancellationToken)`
  * Method `GetDashAsync(Int32, CancellationToken)`
  * Method `GetDashListAsync(Int32[], CancellationToken)`
  * Method `GetFavouritesAsync(CancellationToken)`
  * Method `GetIdsFromHistoryAsync(CancellationToken)`
  * Method `GetPinnedAsync(CancellationToken)`
  * Method `SaveDashAsync(Dash, String, CancellationToken)`
  * Method `SaveDashAsync(Dash, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DashThemeImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFirstDashTheme()`
  * Method `GetFromId(Int32)`
  * Method `PopulateFromRow(DashboardThemeRow)`
  * Method `Save(DashTheme)`
* New items
  * Method `CreateDefaultDashThemeAsync(CancellationToken)`
  * Method `DeleteDashThemeAsync(Int32, CancellationToken)`
  * Method `GetDashThemeAsync(Int32, CancellationToken)`
  * Method `SaveDashThemeAsync(DashTheme, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DashTileDefinitionImplementation is Modified

* Deleted items
  * Method `DashTileDefinitionImplementation()`
  * Method `CopyDashTileDefinition(DashTileDefinition)`
  * Method `CreateDefault()`
  * Method `CreateDefaultTileDefinitionForEntity(String)`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `PopulateFromRow(DashboardTileDefinitionRow)`
  * Method `Save(DashTileDefinition)`
* New items
  * Method `DashTileDefinitionImplementation(ISelectionEntityImplementation)`
  * Method `CreateDefaultDashTileDefinitionAsync(CancellationToken)`
  * Method `CreateDefaultTileDefinitionForEntityAsync(String, CancellationToken)`
  * Method `DeleteDashTileDefinitionAsync(Int32, CancellationToken)`
  * Method `GetDashTileDefinitionAsync(Int32, CancellationToken)`
  * Method `PopulateFromRowAsync(DashboardTileDefinitionRow, CancellationToken)`
  * Method `SaveDashTileDefinitionAsync(DashTileDefinition, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DashTileHtmlImplementation is Modified

* Deleted items
  * Method `GetDashTileHtml(Int32, String)`
  * Method `GetDashTileHtmlList(Int32)`
  * Method `SaveDashTileHtmlList(Int32, DashTileHtml[])`
* New items
  * Method `GetDashTileHtmlAsync(Int32, String, CancellationToken)`
  * Method `GetDashTileHtmlListAsync(Int32, CancellationToken)`
  * Method `SaveDashTileHtmlListAsync(Int32, DashTileHtml[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DashTileImplementation is Modified

* Deleted items
  * Method `DashTileImplementation()`
  * Method `CopyTileSelection(Int32)`
  * Method `CreateDashTileSelectionFromEntity(String)`
  * Method `CreateDefault()`
  * Method `CreateDefaultTileForEntity(String)`
  * Method `CreateTileCopy(DashTile, String, Int32)`
  * Method `Delete(Int32)`
  * Method `DuplicateTile(Int32, String)`
  * Method `GetDashTiles(Int32)`
  * Method `GetFromId(Int32)`
  * Method `GetMaxRank(Int32)`
  * Method `GetSecondaryTempTileSelection(Int32)`
  * Method `GetSpecifiedTempTileSelection(Int32, SelectionSystemType)`
  * Method `GetTempTileSelection(Int32)`
  * Method `Save(DashTile)`
  * Method `SaveDashTiles(Int32, DashTile[])`
* New items
  * Method `DashTileImplementation(IDashTileDefinitionImplementation, IDashTileHtmlImplementation, ISelectionTypeManager)`
  * Method `CopyTileSelectionAsync(Int32, CancellationToken)`
  * Method `CreateDashTileSelectionFromEntityAsync(String, CancellationToken)`
  * Method `CreateDefaultDashTileAsync(CancellationToken)`
  * Method `CreateDefaultTileForEntityAsync(String, CancellationToken)`
  * Method `CreateTileCopyAsync(DashTile, String, Int32, CancellationToken)`
  * Method `DeleteDashTileAsync(Int32, CancellationToken)`
  * Method `DuplicateTileAsync(Int32, String, CancellationToken)`
  * Method `GetDashTileAsync(Int32, CancellationToken)`
  * Method `GetDashTilesAsync(Int32, CancellationToken)`
  * Method `GetSecondaryTempTileSelectionAsync(Int32, CancellationToken)`
  * Method `GetTempTileSelectionAsync(Int32, CancellationToken)`
  * Method `SaveDashTileAsync(DashTile, CancellationToken)`
  * Method `SaveDashTilesAsync(Int32, DashTile[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DateTimeOperatorUpdater is Modified

* Deleted items
  * Method `Update(IProgressNotification)`
* New items
  * Method `UpdateAsync(IProgressNotification, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DayInformationListImplementation is Modified

* Deleted items
  * Method `GetActivityInformationListByDatesAndAssociate(DateTime, DateTime, Int32)`
  * Method `GetDayInformationListByDatesAndAssociate(DateTime, DateTime, Int32)`
  * Method `GetRedLetterInformationListByDatesAndAssociate(DateTime, DateTime, Int32)`
* New items
  * Method `GetActivityInformationListByDatesAndAssociateAsync(DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetDayInformationListByDatesAndAssociateAsync(DateTime, DateTime, Int32, CancellationToken)`
  * Method `GetRedLetterInformationListByDatesAndAssociateAsync(DateTime, DateTime, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DefaultDashboardsImplementation is Modified

* Deleted items
  * Method `DefaultDashboardsImplementation()`
  * Method `ReadDefaultDashboardFile(String)`
  * Method `ReadDefaultFlowReportFile(String)`
  * Method `UpdateDefaultDashboards()`
* Modified items
  * Method `GetDefaultDashboardFiles()`
  * Method `GetDefaultFlowReportFile()`
* New items
  * Method `DefaultDashboardsImplementation(IDashImplementation, IDashTileImplementation, IDashTileDefinitionImplementation, ISelectionEntityImplementation, IPreferenceImplementation)`
  * Method `ReadDefaultDashboardFileAsync(String, CancellationToken)`
  * Method `ReadDefaultFlowReportFileAsync(String, CancellationToken)`
  * Method `UpdateDefaultDashboardsAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DeliveryTermImplementation is Modified

* Deleted items
  * Method `GetDeliveryTerm(Int32)`
* Modified items
  * Method `PopulateFromHDB(DeliveryTermsRow)`
  * Method `PopulateFromHDB(DeliveryTermsRows)`
* New items
  * Method `DeliveryTermImplementation()`
  * Method `GetDeliveryTermAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DeliveryTermsListImplementation is Modified

* Deleted items
  * Method `GetDeliveryTerms()`
* New items
  * Method `DeliveryTermsListImplementation(IDeliveryTermImplementation)`
  * Method `GetDeliveryTermsAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DeliveryTypeImplementation is Modified

* Deleted items
  * Method `GetDeliveryType(Int32)`
* Modified items
  * Method `PopulateFromHDB(DeliveryTypeRow)`
  * Method `PopulateFromHDB(DeliveryTypeRows)`
* New items
  * Method `DeliveryTypeImplementation()`
  * Method `GetDeliveryTypeAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DeliveryTypeListImplementation is Modified

* Deleted items
  * Method `GetDeliveryTypes()`
* New items
  * Method `DeliveryTypeListImplementation(IDeliveryTypeImplementation)`
  * Method `GetDeliveryTypesAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DictionaryStepInformationImplementation is Modified

* Deleted items
  * Method `GetStepsFromNetServerCode()`
  * Method `GetStepsInDatabase()`
* New items
  * Method `DictionaryStepInformationImplementation()`
  * Method `GetStepsFromNetServerCodeAsync(CancellationToken)`
  * Method `GetStepsInDatabaseAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DocumentEntityImplementation is Modified

* Deleted items
  * Method `DocumentEntityImplementation()`
  * Method `CheckinDocument(Int32, String[], String, String[])`
  * Method `CheckoutDocument(Int32, String[])`
  * Method `CopyDocumentToCsAttachment(Int32)`
  * Method `CreateDefault()`
  * Method `CreateDefaultDocumentEntityFromSuggestion(Int32)`
  * Method `CreateDocumentStream(DocumentEntity, Boolean)`
  * Method `CreateNewPhysicalDocument(Int32, Boolean, StringDictionary, TemplateVariables, Boolean, String)`
  * Method `CreateNewPhysicalDocumentFromTemplate(Int32, Int32, Int32, Int32, Int32, Int32, Int32, String)`
  * Method `CreateNewPhysicalDocumentFromTemplateWithCustomTags(Int32, Int32, Int32, Int32, Int32, Int32, Int32, String[], String[], String)`
  * Method `CreateNewPhysicalDocumentFromTemplateWithCustomTags2(Int32, Int32, Int32, Int32, Int32, Int32, Int32, StringDictionary, String)`
  * Method `CreateNewPhysicalMailMergeDocumentFromTemplate(Int32, String)`
  * Method `CreateTempFile(String, Stream)`
  * Method `Delete(Int32)`
  * Method `DeletePhysicalDocument(Int32, String[])`
  * Method `DeleteTempFile(String)`
  * Method `ExecuteDocumentCommand(Int32, String, String[], String, String[])`
  * Method `GetCheckoutState(Int32)`
  * Method `GetDocument(DocumentEntity)`
  * Method `GetDocumentCommands(Int32, String[])`
  * Method `GetDocumentEntity(Int32)`
  * Method `GetDocumentProperties(Int32, String[])`
  * Method `GetDocumentStream(Int32)`
  * Method `GetDocumentStreamFromEntity(DocumentEntity)`
  * Method `GetDocumentUrl(Int32, String, Boolean)`
  * Method `GetFromId(Int32)`
  * Method `GetPluginCapabilities(Int32)`
  * Method `GetPluginList()`
  * Method `GetPreviewDocumentStream(Int32)`
  * Method `GetSanitizedDocumentStream(Int32)`
  * Method `GetSanitizedPreviewDocumentStream(Int32, Boolean)`
  * Method `GetSanitizedTemplateStream(String, Boolean, String)`
  * Method `GetSanitizedTemplateStreamFromId(Int32, String)`
  * Method `GetTempFile(String)`
  * Method `GetTemplateStream(String, Boolean, String)`
  * Method `GetTemplateStreamFromId(Int32, String)`
  * Method `GetUnsanitizedPreviewDocumentStream(Int32)`
  * Method `GetVersionList(Int32)`
  * Method `PopulateCarrierFromDataContainer(DocumentEntity, DocumentEntityDataContainer)`
  * Method `PopulateDataContainerFromCarrier(DocumentEntityDataContainer, DocumentEntity)`
  * Method `RenameDocument(Int32, String)`
  * Method `Save(DocumentEntity)`
  * Method `SaveDocumentEntity(DocumentEntity)`
  * Method `SaveDocumentTemplateStream(Int32, Stream, String, Int32)`
  * Method `SavePrivacyReport(String, String, Int32)`
  * Method `SavePrivacyReportPdf(Stream, String, Int32)`
  * Method `SetDocumentStream(DocumentEntity, Stream, Boolean)`
  * Method `SetDocumentStreamFromId(Int32, Stream)`
  * Method `SetTemplateStream(String, Boolean, Stream)`
  * Method `SubstituteMergeDocumentTemplateVariables(Int32, Int32, String[], String[])`
  * Method `SubstituteMergeDocumentTemplateVariables2(Int32, Int32, StringDictionary)`
  * Method `SubstituteMergeDocumentTemplateVariablesEx(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, String[], String[])`
  * Method `SubstituteMergeDocumentTemplateVariablesEx2(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, StringDictionary)`
  * Method `SubstituteTemplateVariables(String, GeneratorEncoding, Int32, Int32, Int32, Int32, Int32, Int32, Int32, String)`
  * Method `SubstituteTemplateVariablesEx(TemplateVariablesParameters)`
  * Method `SubstituteTemplateVariablesWithCustomTags(String, GeneratorEncoding, String[], String[], Int32, Int32, Int32, Int32, Int32, Int32, Int32, String)`
  * Method `SubstituteTemplateVariablesWithCustomTags2(String, GeneratorEncoding, StringDictionary, Int32, Int32, Int32, Int32, Int32, Int32, Int32, String)`
  * Method `UndoCheckoutDocument(Int32, String[])`
  * Method `ValidateDocumentEntity(DocumentEntity)`
  * Method `VerifyGetDocumentStream(Int32)`
* Modified items

##### SuperOffice.CRM.Services.Implementation.BL.DocumentEntityImplementation.DocumentEntityDataContainer is Modified

* Deleted items
  * Method `.DocumentEntityDataContainerDelete()`
  * Method `.DocumentEntityDataContainerGetDataContainerFromId(Int32)`
  * Method `.DocumentEntityDataContainerGetNewDataContainer(DefaulterStrategy)`
  * Method `.DocumentEntityDataContainerGetNewDataContainer(Boolean)`
  * Method `.DocumentEntityDataContainerSave()`
  * Method `.DocumentEntityDataContainerSetDefaults(DefaulterStrategy)`
* New items
  * Method `.DocumentEntityDataContainerDeleteAsync(CancellationToken)`
  * Method `.DocumentEntityDataContainerGetDataContainerFromIdAsync(Int32, CancellationToken)`
  * Method `.DocumentEntityDataContainerGetNewDataContainerAsync(DefaulterStrategy, CancellationToken)`
  * Method `.DocumentEntityDataContainerGetNewDataContainerAsync(Boolean, CancellationToken)`
  * Method `.DocumentEntityDataContainerSaveAsync(CancellationToken)`
  * Method `.DocumentEntityDataContainerSetDefaultsAsync(DefaulterStrategy, CancellationToken)`

* New items
  * Method `DocumentEntityImplementation(IContactImplementation, IPersonImplementation, ISaleImplementation, IDocumentTemplateImplementation, IListAgent, ILinkImplementation, IFieldInfoBaseImplementation, IProjectImplementation, IQuoteManagerFactory)`
  * Method `CheckinDocumentAsync(Int32, String[], String, String[], CancellationToken)`
  * Method `CheckoutDocumentAsync(Int32, String[], CancellationToken)`
  * Method `CopyDocumentToCsAttachmentAsync(Int32, CancellationToken)`
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `CreateDefaultDocumentEntityFromSuggestionAsync(Int32, CancellationToken)`
  * Method `CreateDocumentStreamAsync(DocumentEntity, Boolean, CancellationToken)`
  * Method `CreateNewPhysicalDocumentAsync(Int32, Boolean, StringDictionary, TemplateVariables, Boolean, String, CancellationToken)`
  * Method `CreateNewPhysicalDocumentFromTemplateAsync(Int32, Int32, Int32, Int32, Int32, Int32, Int32, String, CancellationToken)`
  * Method `CreateNewPhysicalDocumentFromTemplateWithCustomTags2Async(Int32, Int32, Int32, Int32, Int32, Int32, Int32, StringDictionary, String, CancellationToken)`
  * Method `CreateNewPhysicalDocumentFromTemplateWithCustomTagsAsync(Int32, Int32, Int32, Int32, Int32, Int32, Int32, String[], String[], String, CancellationToken)`
  * Method `CreateNewPhysicalMailMergeDocumentFromTemplateAsync(Int32, String, CancellationToken)`
  * Method `CreateTempFileAsync(String, Stream, CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `DeletePhysicalDocumentAsync(Int32, String[], CancellationToken)`
  * Method `DeleteTempFileAsync(String, CancellationToken)`
  * Method `ExecuteDocumentCommandAsync(Int32, String, String[], String, String[], CancellationToken)`
  * Method `GetCheckoutStateAsync(Int32, CancellationToken)`
  * Method `GetDocumentAsync(DocumentEntity, CancellationToken)`
  * Method `GetDocumentCommandsAsync(Int32, String[], CancellationToken)`
  * Method `GetDocumentEntityAsync(Int32, CancellationToken)`
  * Method `GetDocumentLengthAsync(Int32, String, CancellationToken)`
  * Method `GetDocumentPropertiesAsync(Int32, String[], CancellationToken)`
  * Method `GetDocumentStreamAsync(Int32, CancellationToken)`
  * Method `GetDocumentStreamFromEntityAsync(DocumentEntity, CancellationToken)`
  * Method `GetDocumentUrlAsync(Int32, String, Boolean, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `GetPluginCapabilitiesAsync(Int32, CancellationToken)`
  * Method `GetPluginListAsync(CancellationToken)`
  * Method `GetPreviewDocumentStreamAsync(Int32, CancellationToken)`
  * Method `GetSanitizedDocumentStreamAsync(Int32, CancellationToken)`
  * Method `GetSanitizedTemplateStreamAsync(String, Boolean, String, CancellationToken)`
  * Method `GetSanitizedTemplateStreamFromIdAsync(Int32, String, CancellationToken)`
  * Method `GetTempFileAsync(String, CancellationToken)`
  * Method `GetTemplateStreamAsync(String, Boolean, String, CancellationToken)`
  * Method `GetTemplateStreamFromIdAsync(Int32, String, CancellationToken)`
  * Method `GetUnsanitizedPreviewDocumentStreamAsync(Int32, CancellationToken)`
  * Method `GetVersionListAsync(Int32, CancellationToken)`
  * Method `PopulateCarrierFromDataContainerAsync(DocumentEntity, DocumentEntityDataContainer, CancellationToken)`
  * Method `PopulateDataContainerFromCarrierAsync(DocumentEntityDataContainer, DocumentEntity, CancellationToken)`
  * Method `RenameDocumentAsync(Int32, String, CancellationToken)`
  * Method `SaveAsync(DocumentEntity, CancellationToken)`
  * Method `SaveDocumentTemplateStreamAsync(Int32, Stream, String, Int32, CancellationToken)`
  * Method `SavePrivacyReportAsync(String, String, Int32, CancellationToken)`
  * Method `SavePrivacyReportPdfAsync(Stream, String, Int32, CancellationToken)`
  * Method `SetDocumentStreamAsync(DocumentEntity, Stream, Boolean, CancellationToken)`
  * Method `SetDocumentStreamFromIdAsync(Int32, Stream, CancellationToken)`
  * Method `SetTemplateStreamAsync(String, Boolean, Stream, CancellationToken)`
  * Method `SubstituteMergeDocumentTemplateVariables2Async(Int32, Int32, StringDictionary, CancellationToken)`
  * Method `SubstituteMergeDocumentTemplateVariablesAsync(Int32, Int32, String[], String[], CancellationToken)`
  * Method `SubstituteMergeDocumentTemplateVariablesEx2Async(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, StringDictionary, CancellationToken)`
  * Method `SubstituteMergeDocumentTemplateVariablesExAsync(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, String[], String[], CancellationToken)`
  * Method `SubstituteTemplateVariablesAsync(String, GeneratorEncoding, Int32, Int32, Int32, Int32, Int32, Int32, Int32, String, CancellationToken)`
  * Method `SubstituteTemplateVariablesExAsync(TemplateVariablesParameters, CancellationToken)`
  * Method `SubstituteTemplateVariablesWithCustomTags2Async(String, GeneratorEncoding, StringDictionary, Int32, Int32, Int32, Int32, Int32, Int32, Int32, String, CancellationToken)`
  * Method `SubstituteTemplateVariablesWithCustomTagsAsync(String, GeneratorEncoding, String[], String[], Int32, Int32, Int32, Int32, Int32, Int32, Int32, String, CancellationToken)`
  * Method `UndoCheckoutDocumentAsync(Int32, String[], CancellationToken)`
  * Method `ValidateDocumentEntityAsync(DocumentEntity, CancellationToken)`
  * Method `VerifyGetDocumentStreamAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DocumentMigrationItemListImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetForAllDocuments(Int32, Boolean)`
  * Method `GetForDateRange(Int32, DateTime, DateTime, Boolean)`
  * Method `GetForSelection(Int32, Int32, Boolean)`
  * Method `GetNumberOfConfidentialDocuments()`
  * Method `HasDocumentsToMigrate()`
  * Method `MigrateDocumentToNewDocPlugin(Int32, Int32)`
* New items
  * Method `DocumentMigrationItemListImplementation(ISelectionAgent, IPreferenceAgent)`
  * Method `CreateDefaultDocumentMigrationItemListAsync(CancellationToken)`
  * Method `GetForAllDocumentsAsync(Int32, Boolean, CancellationToken)`
  * Method `GetForDateRangeAsync(Int32, DateTime, DateTime, Boolean, CancellationToken)`
  * Method `GetForSelectionAsync(Int32, Int32, Boolean, CancellationToken)`
  * Method `GetNumberOfConfidentialDocumentsAsync(CancellationToken)`
  * Method `HasDocumentsToMigrateAsync(CancellationToken)`
  * Method `MigrateDocumentToNewDocPluginAsync(Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DocumentPreviewImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
* New items
  * Method `CreateDefaultDocumentPreviewAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DocumentTemplateEntityImplementation is Modified

* Deleted items
  * Method `DocumentTemplateEntityImplementation()`
  * Method `CreateDefault()`
  * Method `CreateDefaultDocumentTemplateLanguage(Int32, String)`
  * Method `DeleteDocumentTemplateLanguage(Int32, String)`
  * Method `GetDocumentTemplate(Int32)`
  * Method `GetDocumentTemplateExtension(Int32)`
  * Method `GetDocumentTemplateLanguages(Int32)`
  * Method `GetDocumentTemplateProperties(Int32, String[])`
  * Method `GetDocumentTemplateStreamFromId(Int32, String)`
  * Method `GetDocumentTemplateUrl(Int32, Boolean, String)`
  * Method `GetDocumentTemplateUsedInProjectStage(Int32)`
  * Method `GetDocumentTemplateUsedInSalesStage(Int32)`
  * Method `GetDocumentTypesForPlugin(Int32)`
  * Method `GetFromId(Int32)`
  * Method `GetPluginCapabilities(Int32)`
  * Method `GetPluginList()`
  * Method `PopulateFromEntity(DocumentTemplateEntity)`
  * Method `PopulateFromRow(DocTmplRow)`
  * Method `Save(DocumentTemplateEntity)`
  * Method `SaveDocumentTemplateStream(Int32, Stream, String, Int32)`
  * Method `SetDocumentTemplateFromDocumentTemplate(Int32, DocumentTemplateEntity)`
  * Method `SetDocumentTemplateStream(DocumentTemplateEntity, Stream, String, Int32)`
* Modified items
  * Method `PopulateFromRows(DocTmplRows)`
* New items
  * Method `DocumentTemplateEntityImplementation(IRefCountEntityImplementation)`
  * Method `CreateDefaultDocumentTemplateEntityAsync(CancellationToken)`
  * Method `CreateDefaultDocumentTemplateLanguageAsync(Int32, String, CancellationToken)`
  * Method `DeleteDocumentTemplateLanguageAsync(Int32, String, CancellationToken)`
  * Method `GetDocumentTemplateEntityAsync(Int32, CancellationToken)`
  * Method `GetDocumentTemplateExtensionAsync(Int32, CancellationToken)`
  * Method `GetDocumentTemplateLanguagesAsync(Int32, CancellationToken)`
  * Method `GetDocumentTemplatePropertiesAsync(Int32, String[], CancellationToken)`
  * Method `GetDocumentTemplateStreamFromIdAsync(Int32, String, CancellationToken)`
  * Method `GetDocumentTemplateUrlAsync(Int32, Boolean, String, CancellationToken)`
  * Method `GetDocumentTemplateUsedInProjectStageAsync(Int32, CancellationToken)`
  * Method `GetDocumentTemplateUsedInSalesStageAsync(Int32, CancellationToken)`
  * Method `GetDocumentTypesForPluginAsync(Int32, CancellationToken)`
  * Method `GetPluginCapabilitiesAsync(Int32, CancellationToken)`
  * Method `GetPluginListAsync(CancellationToken)`
  * Method `SaveDocumentTemplateEntityAsync(DocumentTemplateEntity, CancellationToken)`
  * Method `SaveDocumentTemplateStreamAsync(Int32, Stream, String, Int32, CancellationToken)`
  * Method `SetDocumentTemplateFromDocumentTemplateAsync(Int32, DocumentTemplateEntity, CancellationToken)`
  * Method `SetDocumentTemplateStreamAsync(DocumentTemplateEntity, Stream, String, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DocumentTemplateImplementation is Modified

* Deleted items
  * Method `GetDocumentTemplate(Int32)`
* Modified items
  * Method `PopulateFromHDB(DocTmplRow)`
* New items
  * Method `GetDocumentTemplateAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DocumentTemplateMigrationListImplementation is Modified

* Deleted items
  * Method `DocumentTemplateMigrationListImplementation()`
  * Method `CreateDefault()`
  * Method `GetForTemplates(Int32, Boolean)`
  * Method `MigrateTemplateToNewDocPlugin(Int32, Int32)`
* New items
  * Method `DocumentTemplateMigrationListImplementation(IDocumentTemplateEntityImplementation)`
  * Method `CreateDefaultDocumentTemplateMigrationListAsync(CancellationToken)`
  * Method `GetForTemplatesAsync(Int32, Boolean, CancellationToken)`
  * Method `MigrateTemplateToNewDocPluginAsync(Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.DuplicateRuleImplementation is Modified

* Deleted items
  * Method `GetDuplicateRule(IDuplicateRule)`
  * Method `GetDuplicateRule(Type, DuplicateRule)`
  * Method `GetDuplicateRules(IDuplicateRule[])`
  * Method `GetDuplicateRules(Type, DuplicateRule[])`
* New items
  * Method `GetDuplicateRuleAsync(IDuplicateRule, CancellationToken)`
  * Method `GetDuplicateRuleAsync(Type, DuplicateRule, CancellationToken)`
  * Method `GetDuplicateRulesAsync(IDuplicateRule[], CancellationToken)`
  * Method `GetDuplicateRulesAsync(Type, DuplicateRule[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.EMailAccountImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetCurrentAccount()`
  * Method `GetCurrentAccountId()`
  * Method `GetCurrentAccountRow()`
  * Method `GetCurrentAccountWithPasswords()`
  * Method `GetEMailAccountFromEMailAddress(String)`
  * Method `GetFromId(Int32)`
  * Method `PatchConnectionInfoObjects(EMailConnectionInfo, EMailConnectionInfo)`
  * Method `Save(EMailAccount)`
* New items
  * Method `CreateDefaultEMailAccountAsync(CancellationToken)`
  * Method `DeleteEMailAccountAsync(Int32, CancellationToken)`
  * Method `GetCurrentAccountAsync(CancellationToken)`
  * Method `GetCurrentAccountIdAsync(CancellationToken)`
  * Method `GetCurrentAccountRowAsync(CancellationToken)`
  * Method `GetEMailAccountAsync(Int32, CancellationToken)`
  * Method `GetEMailAccountFromEMailAddressAsync(String, CancellationToken)`
  * Method `PatchConnectionInfoObjectsAsync(EMailConnectionInfo, EMailConnectionInfo, CancellationToken)`
  * Method `SaveEMailAccountAsync(EMailAccount, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.EMailAddressImplementation is Modified

* Deleted items
  * Method `EMailAddressImplementation()`
  * Method `CreateDefault()`
  * Method `GetAddressDelimeter()`
  * Method `GetAddressObject(String)`
  * Method `GetCleanAddress(String, String)`
  * Method `GetEMailAddresses(MailAddress[])`
  * Method `GetFromAddress(Boolean)`
  * Method `GetPersonEntitiesFromEmailAddress(String)`
  * Method `GetPersonsFromEmailAddress(String)`
  * Method `HasMXRecord(String)`
  * Method `HasSPFRecord(String, String)`
  * Method `ResolveEMailRecipients(String)`
* Modified items
  * Method `GetEMailAddress(MailAddress)`
* New items
  * Method `EMailAddressImplementation(IEMailAccountImplementation)`
  * Method `CreateDefaultEMailAddressAsync(CancellationToken)`
  * Method `GetAddressDelimeterAsync()`
  * Method `GetCleanAddressAsync(String, String)`
  * Method `GetFromAddressAsync(Boolean, CancellationToken)`
  * Method `GetPersonEntitiesFromEmailAddressAsync(String, CancellationToken)`
  * Method `GetPersonsFromEmailAddressAsync(String, CancellationToken)`
  * Method `HasMXRecordAsync(String, CancellationToken)`
  * Method `HasSPFRecordAsync(String, String, CancellationToken)`
  * Method `ResolveEMailRecipientsAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.EMailAppointmentImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
* New items
  * Method `CreateDefaultEMailAppointmentAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.EMailEntityImplementation is Modified

* Deleted items
  * Method `EMailEntityImplementation()`
  * Method `Authenticate(EMailConnectionInfoExtended)`
  * Method `AuthenticateIncoming(EMailConnectionInfo)`
  * Method `AuthenticateOutgoing(EMailConnectionInfo)`
  * Method `CacheFolderList()`
  * Method `CreateDefault()`
  * Method `CreateEMailFromDocumentEntity(DocumentEntity)`
  * Method `CreateEMailFromMimeMessage(String)`
  * Method `CreateFolder(EMailConnectionInfo)`
  * Method `CreateForwardEmail(EMailEntity)`
  * Method `CreateInlineHtmlHeader(EMailEntity)`
  * Method `CreateNewPhysicalDocumentFromEmail(Int32, Int32)`
  * Method `CreateNewPhysicalDocumentFromEmailAttachment(Int32, Int32, String)`
  * Method `Delete(EMailConnectionInfo, Int32[], String)`
  * Method `DeleteEmails(Int32[], String)`
  * Method `DeleteExtended(EMailConnectionInfoExtended, String[])`
  * Method `DeleteFolder(EMailConnectionInfo)`
  * Method `EmptyFolder(EMailConnectionInfo, String)`
  * Method `FindAddress(String)`
  * Method `FindContactOrPersonByEmailName(String, String)`
  * Method `FindContactOrPersonByEmailNameWithLimit(String, String, Int32, Int32)`
  * Method `GetAttachment(EMailConnectionInfo, Int32, String)`
  * Method `GetAttachmentFromId(Int32, String)`
  * Method `GetEMail(Int32, Boolean, Boolean)`
  * Method `GetEMailAddresses(Int32[])`
  * Method `GetEmailAppointment(Int32)`
  * Method `GetEmailAppointmentRecurrence(Int32)`
  * Method `GetEMailAsStream(EMailConnectionInfo, Int32, Boolean, Boolean)`
  * Method `GetEMailAsStream(String, Int32, Boolean, Boolean)`
  * Method `GetEmailDocumentAsMimeStream(Int32)`
  * Method `GetEMailEnvelopes(EMailConnectionInfo, Int32[])`
  * Method `GetEMailFromAttachmentId(Int32, String[], Boolean, Boolean)`
  * Method `GetEMailFromDocumentAttachmentId(Int32, String[], Boolean, Boolean)`
  * Method `GetEMailFromDocumentId(Int32)`
  * Method `GetEMailFromDocumentIdWithoutAttachmentStream(Int32)`
  * Method `GetEMailFromId(EMailConnectionInfo, Int32, Boolean, EMailFlags, Boolean)`
  * Method `GetEMailFromTemp(String)`
  * Method `GetEmailMessageIds(EMailConnectionInfoExtended)`
  * Method `GetEmailsAsString(EMailConnectionInfoExtended, String[])`
  * Method `GetExtendedEmailMessageIds(EMailConnectionInfoExtended)`
  * Method `GetFolderEMailCount(EMailConnectionInfo, Boolean)`
  * Method `GetFolderHasNewEMail(EMailConnectionInfo)`
  * Method `GetFolderInfo(EMailConnectionInfo, String[])`
  * Method `GetFolderList(EMailConnectionInfo, Boolean)`
  * Method `GetMailReader(EmailAccountRow, String, Boolean, Boolean)`
  * Method `GetParticipantInfoFromEmailAddress(String, Int32)`
  * Method `GetPreviewAttachmentFromDocId(Int32, String, Boolean)`
  * Method `GetPreviewAttachmentFromId(Int32, String, String, String, Boolean)`
  * Method `GetUnsanitizedEMail(Int32, Boolean)`
  * Method `GetUnsanitizedEMailFromAttachmentId(Int32, String[], Boolean)`
  * Method `GetUnsanitizedEMailFromDocumentAttachmentId(Int32, String[], Boolean)`
  * Method `GetUnsanitizedEMailFromDocumentId(Int32)`
  * Method `GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream(Int32)`
  * Method `GetUnsanitizedPreviewAttachmentFromDocId(Int32, String)`
  * Method `GetUnsanitizedPreviewAttachmentFromId(Int32, String, String, String)`
  * Method `MarkAsRead(EMailConnectionInfo, Int32[], Boolean)`
  * Method `MarkEmailsAsRead(Int32[], Boolean)`
  * Method `MoveEmailsToTrash(Int32[])`
  * Method `MoveToFolder(EMailConnectionInfo, Int32[], String)`
  * Method `RefreshFolder(EMailConnectionInfo, String[])`
  * Method `RefreshFolderForAssociate(String[])`
  * Method `RelayMessage(EMailConnectionInfoExtended, String, String, String[])`
  * Method `Save(EMailEntity, String)`
  * Method `SaveDraft(EMailEntity)`
  * Method `SaveEMail(EMailConnectionInfo, EMailEntity)`
  * Method `SaveEmailItemRowFromMailItem(EmailItemRow, Int32, Int32, MailEnvelope, MailItem)`
  * Method `SaveEmailToTmpDocument(EMailEntity, Int32, Boolean)`
  * Method `SaveToMailServer(EMailEntity)`
  * Method `SaveToMailServerAsItem(EMailEntity)`
  * Method `Send(EMailEntity[])`
  * Method `SendAndSaveEmailToTmpDocument(EMailEntity, Boolean)`
  * Method `SendEMails(EMailConnectionInfo, EMailEntity[], EMailConnectionInfo)`
  * Method `SetCachedMailItem(Int32, String, String, Int32, String, MailItem, Boolean)`
  * Method `SetRepliedAt(String)`
  * Method `SetSubscription(EMailConnectionInfo, EMailFolder[])`
  * Method `TestAuthenticate()`
* New items
  * Method `EMailEntityImplementation(IEMailAccountImplementation, IEMailAddressImplementation, IEMailFolderImplementation, IAppointmentImplementation, IAppointmentEntityImplementation, IAppointmentUtility, ITempFileProvider, IDocumentAgent, IDocumentEntityImplementation, IPersonImplementation, IServiceAuthImplementation, ICalendarUtility, ICalendarAppointmentUtility)`
  * Method `AuthenticateAsync(EMailConnectionInfoExtended, CancellationToken)`
  * Method `AuthenticateIncomingAsync(EMailConnectionInfo, CancellationToken)`
  * Method `AuthenticateOutgoingAsync(EMailConnectionInfo, CancellationToken)`
  * Method `CacheFolderListAsync(CancellationToken)`
  * Method `CreateDefaultEMailEntityAsync(CancellationToken)`
  * Method `CreateEMailFromDocumentEntityAsync(DocumentEntity, CancellationToken)`
  * Method `CreateEMailFromMimeMessageAsync(String, CancellationToken)`
  * Method `CreateFolderAsync(EMailConnectionInfo, CancellationToken)`
  * Method `CreateForwardEmailAsync(EMailEntity, CancellationToken)`
  * Method `CreateInlineHtmlHeaderAsync(EMailEntity, CancellationToken)`
  * Method `CreateNewPhysicalDocumentFromEmailAsync(Int32, Int32, CancellationToken)`
  * Method `CreateNewPhysicalDocumentFromEmailAttachmentAsync(Int32, Int32, String, CancellationToken)`
  * Method `DeleteAsync(EMailConnectionInfo, Int32[], String, CancellationToken)`
  * Method `DeleteEmailsAsync(Int32[], String, CancellationToken)`
  * Method `DeleteExtendedAsync(EMailConnectionInfoExtended, String[], CancellationToken)`
  * Method `DeleteFolderAsync(EMailConnectionInfo, CancellationToken)`
  * Method `EmptyFolderAsync(EMailConnectionInfo, String, CancellationToken)`
  * Method `FindAddressAsync(String, CancellationToken)`
  * Method `FindContactOrPersonByEmailNameAsync(String, String, CancellationToken)`
  * Method `FindContactOrPersonByEmailNameWithLimitAsync(String, String, Int32, Int32, CancellationToken)`
  * Method `GetAttachmentAsync(EMailConnectionInfo, Int32, String, CancellationToken)`
  * Method `GetAttachmentFromIdAsync(Int32, String, CancellationToken)`
  * Method `GetEMailAddressesAsync(Int32[], CancellationToken)`
  * Method `GetEmailAppointmentAsync(Int32, CancellationToken)`
  * Method `GetEmailAppointmentRecurrenceAsync(Int32, CancellationToken)`
  * Method `GetEMailAsStreamAsync(EMailConnectionInfo, Int32, Boolean, CancellationToken)`
  * Method `GetEMailAsync(Int32, Boolean, CancellationToken)`
  * Method `GetEmailDocumentAsMimeStreamAsync(Int32, CancellationToken)`
  * Method `GetEMailEnvelopesAsync(EMailConnectionInfo, Int32[], CancellationToken)`
  * Method `GetEMailFromAttachmentIdAsync(Int32, String[], Boolean, CancellationToken)`
  * Method `GetEMailFromDocumentAttachmentIdAsync(Int32, String[], Boolean, CancellationToken)`
  * Method `GetEMailFromDocumentIdAsync(Int32, CancellationToken)`
  * Method `GetEMailFromDocumentIdWithoutAttachmentStreamAsync(Int32, CancellationToken)`
  * Method `GetEMailFromIdAsync(EMailConnectionInfo, Int32, Boolean, EMailFlags, Boolean, CancellationToken)`
  * Method `GetEMailFromTempAsync(String, CancellationToken)`
  * Method `GetEmailMessageIdsAsync(EMailConnectionInfoExtended, CancellationToken)`
  * Method `GetEmailsAsStringAsync(EMailConnectionInfoExtended, String[], CancellationToken)`
  * Method `GetExtendedEmailMessageIdsAsync(EMailConnectionInfoExtended, CancellationToken)`
  * Method `GetFolderEMailCountAsync(EMailConnectionInfo, Boolean, CancellationToken)`
  * Method `GetFolderHasNewEMailAsync(EMailConnectionInfo, CancellationToken)`
  * Method `GetFolderInfoAsync(EMailConnectionInfo, String[], CancellationToken)`
  * Method `GetFolderListAsync(EMailConnectionInfo, Boolean, CancellationToken)`
  * Method `GetMailFromInReplyToAsync(String, CancellationToken)`
  * Method `GetMailFromMessageIdAsync(String, CancellationToken)`
  * Method `GetMailReaderAsync(EmailAccountRow, String, Boolean, Boolean, CancellationToken)`
  * Method `GetNewMailAsync(Int32[], CancellationToken)`
  * Method `GetParticipantInfoFromEmailAddressAsync(String, Int32, CancellationToken)`
  * Method `GetPreviewAttachmentFromDocIdAsync(Int32, String, CancellationToken)`
  * Method `GetPreviewAttachmentFromDocIdImplementationAsync(Int32, String, Boolean, CancellationToken)`
  * Method `GetPreviewAttachmentFromIdAsync(Int32, String, String, String, CancellationToken)`
  * Method `GetPreviewAttachmentFromIdImplementationAsync(Int32, String, String, String, Boolean, CancellationToken)`
  * Method `GetUnsanitizedEMailAsync(Int32, Boolean, CancellationToken)`
  * Method `GetUnsanitizedEMailFromAttachmentIdAsync(Int32, String[], Boolean, CancellationToken)`
  * Method `GetUnsanitizedEMailFromDocumentAttachmentIdAsync(Int32, String[], Boolean, CancellationToken)`
  * Method `GetUnsanitizedEMailFromDocumentIdAsync(Int32, CancellationToken)`
  * Method `GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamAsync(Int32, CancellationToken)`
  * Method `GetUnsanitizedPreviewAttachmentFromDocIdAsync(Int32, String, CancellationToken)`
  * Method `GetUnsanitizedPreviewAttachmentFromIdAsync(Int32, String, String, String, CancellationToken)`
  * Method `HasNewMailAsync(Int32, Int32, CancellationToken)`
  * Method `LatestItemIdByFolderAsync(Int32, CancellationToken)`
  * Method `MarkAsReadAsync(EMailConnectionInfo, Int32[], Boolean, CancellationToken)`
  * Method `MarkEmailsAsReadAsync(Int32[], Boolean, CancellationToken)`
  * Method `MoveEmailsToFolderAsync(Int32, Int32[], CancellationToken)`
  * Method `MoveEmailsToTrashAsync(Int32[], CancellationToken)`
  * Method `MoveToFolderAsync(EMailConnectionInfo, Int32[], String, CancellationToken)`
  * Method `RefreshFolderAsync(EMailConnectionInfo, String[], CancellationToken)`
  * Method `RefreshFolderForAssociateAsync(String[], CancellationToken)`
  * Method `RelayMessageAsync(EMailConnectionInfoExtended, String, String, String[], CancellationToken)`
  * Method `SaveAsync(EMailEntity, String, CancellationToken)`
  * Method `SaveAsync(EMailEntity, CancellationToken)`
  * Method `SaveDraftAsync(EMailEntity, CancellationToken)`
  * Method `SaveEMailAsync(EMailConnectionInfo, EMailEntity, CancellationToken)`
  * Method `SaveEmailToTmpDocumentAsync(EMailEntity, Int32, Boolean, CancellationToken)`
  * Method `SaveToMailServerAsItemAsync(EMailEntity, CancellationToken)`
  * Method `SaveToMailServerAsync(EMailEntity, CancellationToken)`
  * Method `SendAndSaveEmailToTmpDocumentAsync(EMailEntity, Boolean, CancellationToken)`
  * Method `SendAsync(EMailEntity[], CancellationToken)`
  * Method `SendEMailsAsync(EMailConnectionInfo, EMailEntity[], EMailConnectionInfo, CancellationToken)`
  * Method `SetRepliedAtAsync(String, CancellationToken)`
  * Method `SetSubscriptionAsync(EMailConnectionInfo, EMailFolder[], CancellationToken)`
  * Method `TestAuthenticateAsync(CancellationToken)`
  * Method `ToggleSubscriptionAsync(Int32, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.EmailFlowImplementation is Modified

* Deleted items
  * Method `EmailFlowImplementation()`
  * Method `ConnectEmailFlowContent(Int32, Int32)`
  * Method `CopyEmailFlow(Int32, String)`
  * Method `CopyEmailFlowContent(Int32, Int32)`
  * Method `CreateDefault()`
  * Method `CreateEmailFlowContent(Int32, String)`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `LoadContentInfo(Int32)`
  * Method `ReassignAllStepsForCopyAndCopyContent(Int32, WorkflowStepBase[], String)`
  * Method `RemoveParticipantsFromEmailFlow(Int32, Int32[])`
  * Method `Save(EmailFlow)`
  * Method `SetStatusOnWorkflow(Int32, WorkflowDefinitionStatus)`
  * Method `TryAddPersonsToEmailFlow(Int32, Int32[])`
  * Method `UpdateFormSubmissions(Int32)`
* New items
  * Method `EmailFlowImplementation(IAssociateImplementation, ICacheManager, IMDOListImplementation, IWorkflowGoalImplementation, IWorkflowStepBaseImplementation, IWorkflowTriggerImplementation, IWorkflowUtil)`
  * Method `ConnectEmailFlowContentAsync(Int32, Int32, CancellationToken)`
  * Method `CopyEmailFlowAsync(Int32, String, CancellationToken)`
  * Method `CopyEmailFlowContentAsync(Int32, Int32, CancellationToken)`
  * Method `CreateDefaultEmailFlowAsync(CancellationToken)`
  * Method `CreateEmailFlowContentAsync(Int32, String, CancellationToken)`
  * Method `DeleteEmailFlowAsync(Int32, CancellationToken)`
  * Method `GetEmailFlowAsync(Int32, CancellationToken)`
  * Method `ReassignAllStepsForCopyAndCopyContentAsync(Int32, WorkflowStepBase[], String, CancellationToken)`
  * Method `RemoveParticipantsFromEmailFlowAsync(Int32, Int32[], CancellationToken)`
  * Method `SaveEmailFlowAsync(EmailFlow, CancellationToken)`
  * Method `SetStatusOnWorkflowAsync(Int32, WorkflowDefinitionStatus, CancellationToken)`
  * Method `TryAddPersonsToEmailFlowAsync(Int32, Int32[], CancellationToken)`
  * Method `UpdateFormSubmissionsAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.EMailFolderImplementation is Modified

* Deleted items
  * Method `EMailFolderImplementation()`
  * Method `CacheFolderList(ISoIncomingMailInterface)`
  * Method `CreateDefault()`
  * Method `CreateFromFolderInfo(SoMailFolderInfo)`
  * Method `Delete(Int32)`
  * Method `GetCustomFolderListForCache(ISoIncomingMailInterface)`
  * Method `GetCustomFolderListForSync(ISoIncomingMailInterface)`
  * Method `GetDraftsFolderName(Int32)`
  * Method `GetFolderName(EmailFolderRow)`
  * Method `GetFolderName(Int32)`
  * Method `GetSentFolderName(Int32)`
  * Method `GetSentFolderNames(Int32)`
  * Method `GetTrashFolderName(Int32)`
* Modified items
  * Method `FolderHasAutomaticCalendarSupport(Int32, Int32)`
  * Method `GetFolderName(Int32, EmailFolderRows)`
  * Method `GetMailFolder(EMailFolder)`
* New items
  * Method `EMailFolderImplementation(IEMailAccountImplementation, IServiceAuthImplementation)`
  * Method `CacheFolderListAsync(CancellationToken, ISoIncomingMailInterface)`
  * Method `CreateDefaultEMailFolderAsync(CancellationToken)`
  * Method `CreateFromFolderInfoAsync(SoMailFolderInfo, CancellationToken)`
  * Method `DeleteAsync(Int32)`
  * Method `GetCustomFolderListForCacheAsync(ISoIncomingMailInterface, CancellationToken)`
  * Method `GetCustomFolderListForSyncAsync(ISoIncomingMailInterface, CancellationToken)`
  * Method `GetDraftsFolderNameAsync(Int32, CancellationToken)`
  * Method `GetFolderNameAsync(EmailFolderRow, CancellationToken)`
  * Method `GetFolderNameAsync(Int32, CancellationToken)`
  * Method `GetSentFolderNameAsync(Int32, CancellationToken)`
  * Method `GetSentFolderNamesAsync(Int32, CancellationToken)`
  * Method `GetTrashFolderNameAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.EMailSOInfoImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetEMailSOInfo(Int32)`
* New items
  * Method `CreateDefaultEMailSOInfoAsync(CancellationToken)`
  * Method `GetEMailSOInfoAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ErpConnectionDataImplementation is Modified

* Deleted items
  * Method `GetConnectionsAndDisplayFields(CrmActorType, Int32)`
  * Method `GetErpFieldValues(Int32, CrmActorType, Int32, String[])`
  * Method `GetFieldsForNewErpActor(Int32, ErpActorType)`
* New items
  * Method `ErpConnectionDataImplementation()`
  * Method `GetConnectionsAndDisplayFieldsAsync(CrmActorType, Int32, CancellationToken)`
  * Method `GetErpFieldValuesAsync(Int32, CrmActorType, Int32, String[], CancellationToken)`
  * Method `GetFieldsForNewErpActorAsync(Int32, ErpActorType, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ErpConnectionImplementation is Modified

* Deleted items
  * Method `CreateDefaultErpConnection()`
  * Method `DeleteConnection(Int32)`
  * Method `GetConfigurationFields(Int32)`
  * Method `GetConnection(Int32)`
  * Method `GetErpConnectionConfigFields(Int32)`
  * Method `LoadAllListItems(ErpFieldTableInfo, Int32, ErpActorType)`
  * Method `MoveErpFieldItem(Int32, Int32, Int32, ErpActorType)`
  * Method `SaveConnection(ErpConnection)`
  * Method `SaveErpConnectionSyncPriorities(Int32[])`
  * Method `SupportsAdvancedSearch(Int32, ErpActorType)`
  * Method `TestConnectionByConfig(Int32, StringDictionary)`
  * Method `TestConnectionById(Int32)`
  * Method `ToggleErpConnectionActive(Int32)`
* New items
  * Method `ErpConnectionImplementation(IErpSyncActorTypeMappingImplementation)`
  * Method `DeleteConnectionAsync(Int32, CancellationToken)`
  * Method `GetAllConnectionsAsync(Boolean, CancellationToken)`
  * Method `GetAllConnectorsAsync(CancellationToken)`
  * Method `GetConfigurationFieldsAsync(Int32, CancellationToken)`
  * Method `GetConnectionAsync(Int32, CancellationToken)`
  * Method `GetErpConnectionConfigFieldsAsync(Int32, CancellationToken)`
  * Method `LoadAllListItems(ErpFieldTableInfo, Int32, ErpActorType, CancellationToken)`
  * Method `MoveErpFieldItemAsync(Int32, Int32, Int32, ErpActorType, CancellationToken)`
  * Method `SaveConnectionAsync(ErpConnection, CancellationToken)`
  * Method `SaveErpConnectionSyncPrioritiesAsync(Int32[], CancellationToken)`
  * Method `SupportsAdvancedSearchAsync(Int32, ErpActorType, CancellationToken)`
  * Method `TestConnectionByConfigAsync(Int32, StringDictionary, CancellationToken)`
  * Method `TestConnectionByIdAsync(Int32, CancellationToken)`
  * Method `ToggleErpConnectionActiveAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ErpConnectionListMappingContainerImplementation is Modified

* New items
  * Method `ErpConnectionListMappingContainerImplementation(IUserDefinedFieldInfoImplementation)`
  * Method `GetConnectionListMappingsAsync(Int32, CancellationToken)`
  * Method `SaveConnectionListMappingsAsync(ErpConnectionListMappingContainer, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ErpSyncActorTypeMappingImplementation is Modified

* Deleted items
  * Method `BreakActorLink(Int32, Int32, CrmActorType)`
  * Method `CreateActorLink(Int32, Int32, CrmActorType, String, ErpActorType)`
  * Method `CreateErpActorFromCrm(Int32, Int32, ErpActorType, CrmActorType, StringDictionary)`
  * Method `GetActorTypeMapping(Int32, ErpActorType)`
  * Method `GetCrmActorType(Int32, ErpActorType)`
  * Method `SaveActorTypeMapping(ErpSyncActorTypeMapping)`
  * Method `UpdateConnectionFields(Int32)`
  * Method `ValidateArchiveColumnConfig(String, Int32)`
* New items
  * Method `ErpSyncActorTypeMappingImplementation(ISoListProviderFactory, IUserDefinedFieldInfoImplementation)`
  * Method `BreakActorLinkAsync(Int32, Int32, CrmActorType, CancellationToken)`
  * Method `CreateActorLinkAsync(Int32, Int32, CrmActorType, String, ErpActorType, CancellationToken)`
  * Method `CreateErpActorFromCrmAsync(Int32, Int32, ErpActorType, CrmActorType, StringDictionary, CancellationToken)`
  * Method `GetActorTypeMappingAsync(Int32, ErpActorType, CancellationToken)`
  * Method `GetCrmActorTypeAsync(Int32, ErpActorType, CancellationToken)`
  * Method `SaveActorTypeMappingAsync(ErpSyncActorTypeMapping, CancellationToken)`
  * Method `UpdateConnectionFieldsAsync(Int32, CancellationToken)`
  * Method `ValidateArchiveColumnConfigAsync(String, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ErpSyncConnectionSummaryImplementation is Modified

* Deleted items
  * Method `GetErpSyncConnectionSummary(Int32)`
* New items
  * Method `ErpSyncConnectionSummaryImplementation()`
  * Method `GetErpSyncConnectionSummaryAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ErpSyncConnectorEntityImplementation is Modified

* Deleted items
  * Method `CanDeleteErpSyncConnectorEntity(Int32)`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `Save(ErpSyncConnectorEntity)`
  * Method `TestConnectorUrl(String)`
* New items
  * Method `CanDeleteErpSyncConnectorEntityAsync(Int32, CancellationToken)`
  * Method `CreateDefaultErpSyncConnectorEntityAsync(CancellationToken)`
  * Method `DeleteErpSyncConnectorEntityAsync(Int32, CancellationToken)`
  * Method `GetErpSyncConnectorEntityAsync(Int32, CancellationToken)`
  * Method `SaveErpSyncConnectorEntityAsync(ErpSyncConnectorEntity, CancellationToken)`
  * Method `TestConnectorUrlAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ErpSyncDefaultValueImplementation is Modified

* Deleted items
  * Method `GetDefaultValueInfo(Int32)`
  * Method `SaveDefaultValueInfo(ErpSyncDefaultValue)`
* New items
  * Method `ErpSyncDefaultValueImplementation()`
  * Method `GetDefaultValueInfoAsync(Int32, CancellationToken)`
  * Method `SaveDefaultValueInfoAsync(ErpSyncDefaultValue, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ErpSyncEngineImplementation is Modified

* Deleted items
  * Method `ForceResync(Int32, Int32[], Boolean)`
  * Method `ForceResyncBatchTask(Int32, ErpActorType, String[])`
  * Method `ForceResyncBatchTask(Int32, Int32[])`
  * Method `ForceResyncExternal(Int32, ErpActorType, String[], Boolean)`
  * Method `ForceResyncExternalNoBlankValues(Int32, ErpActorType, String[])`
  * Method `ForceResyncNoBlankValues(Int32, Int32[])`
  * Method `ForceSyncAll()`
  * Method `SyncAll()`
* New items
  * Method `ErpSyncEngineImplementation(IBatchData, IErpSyncEngineStatusImplementation)`
  * Method `ForceResyncAsync(Int32, Int32[], CancellationToken)`
  * Method `ForceResyncBatchTaskAsync(Int32, Int32[], CancellationToken)`
  * Method `ForceResyncExternalAsync(Int32, ErpActorType, String[], CancellationToken)`
  * Method `ForceResyncExternalNoBlankValuesAsync(Int32, ErpActorType, String[], CancellationToken)`
  * Method `ForceResyncNoBlankValuesAsync(Int32, Int32[], CancellationToken)`
  * Method `ForceSyncAllAsync(CancellationToken)`
  * Method `SyncAllAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ErpSyncEngineStatusImplementation is Modified

* Deleted items
  * Method `ChangeEngineInterval(TimeSpan)`
  * Method `ChangeEngineStatus(Boolean)`
  * Method `GetEngineStatus()`
* New items
  * Method `ErpSyncEngineStatusImplementation()`
  * Method `ChangeEngineIntervalAsync(TimeSpan, CancellationToken)`
  * Method `ChangeEngineStatusAsync(Boolean, CancellationToken)`
  * Method `GetEngineStatusAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ErpSyncFieldValueImplementation is Modified

* Deleted items
  * Method `ConnectActor(Int32, Int32, CrmActorType, String, ErpActorType, ErpSyncFieldValue[])`
  * Method `GetFieldValuesFromCrm(Int32, CrmActorType)`
  * Method `GetFieldValuesFromErp(Int32, ErpActorType, String)`
  * Method `TryConnectActor(Int32, Int32, CrmActorType, String, ErpActorType, ErpSyncFieldValue[])`
* Modified items
  * Method `GetFieldsFromActor(ErpSyncActor)`
* New items
  * Method `ErpSyncFieldValueImplementation()`
  * Method `ConnectActorAsync(Int32, Int32, CrmActorType, String, ErpActorType, ErpSyncFieldValue[], CancellationToken)`
  * Method `GetFieldValuesFromCrmAsync(Int32, CrmActorType, CancellationToken)`
  * Method `GetFieldValuesFromErpAsync(Int32, ErpActorType, String, CancellationToken)`
  * Method `TryConnectActorAsync(Int32, Int32, CrmActorType, String, ErpActorType, ErpSyncFieldValue[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ExtAppEntityImplementation is Modified

* Deleted items
  * Method `ExtAppEntityImplementation()`
  * Method `CreateDefault()`
  * Method `GetFromId(Int32)`
  * Method `Save(ExtAppEntity)`
* New items
  * Method `ExtAppEntityImplementation(IDiagnosticsAgent)`
  * Method `CreateDefaultExtAppEntityAsync(CancellationToken)`
  * Method `GetExtAppEntityAsync(Int32, CancellationToken)`
  * Method `SaveExtAppEntityAsync(ExtAppEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.FavouriteImplementation is Modified

* Deleted items
  * Method `AddFavourite(String, Int32, Int32, String)`
  * Method `AddFavourites(String, Int32[], Int32, String)`
  * Method `AddTicketsToFavouritesByProvider(String, ArchiveRestrictionInfo[], Int32, String)`
  * Method `GetFavourites(String, Int32)`
  * Method `IsFavourite(String, Int32, Int32)`
  * Method `RemoveAllFavourites(String, Int32)`
  * Method `RemoveFavourite(String, Int32, Int32)`
  * Method `RemoveFavourites(String, Int32[], Int32)`
  * Method `RemoveFavouritesById(Int32[])`
  * Method `RemoveTicketsFromFavouritesByProvider(String, ArchiveRestrictionInfo[], Int32)`
  * Method `ToggleFavourite(String, Int32, Int32, String)`
  * Method `TryRemoveFavourite(String, Int32, Int32)`
* New items
  * Method `FavouriteImplementation()`
  * Method `AddFavouriteAsync(String, Int32, Int32, String, CancellationToken)`
  * Method `AddFavouritesAsync(String, Int32[], Int32, String, CancellationToken)`
  * Method `AddTicketsToFavouritesByProviderAsync(String, ArchiveRestrictionInfo[], Int32, String, CancellationToken)`
  * Method `GetFavouritesAsync(String, Int32, CancellationToken)`
  * Method `IsFavouriteAsync(String, Int32, Int32, CancellationToken)`
  * Method `RemoveAllFavouritesAsync(String, Int32, CancellationToken)`
  * Method `RemoveFavouriteAsync(String, Int32, Int32, CancellationToken)`
  * Method `RemoveFavouritesAsync(String, Int32[], Int32, CancellationToken)`
  * Method `RemoveFavouritesByIdAsync(Int32[], CancellationToken)`
  * Method `RemoveTicketsFromFavouritesByProviderAsync(String, ArchiveRestrictionInfo[], Int32, CancellationToken)`
  * Method `ToggleFavouriteAsync(String, Int32, Int32, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.FieldInfoBaseImplementation is Modified

* Deleted items
  * Method `GetCustomFieldInfo(String, String)`
  * Method `GetCustomFieldInfoList(String, Boolean)`
  * Method `GetFieldProperties(String)`
* New items
  * Method `GetCustomFieldInfoAsync(String, String, CancellationToken)`
  * Method `GetCustomFieldInfoListAsync(String, Boolean, CancellationToken)`
  * Method `GetFieldPropertiesAsync(String)`

#### SuperOffice.CRM.Services.Implementation.BL.FieldMetadataImplementation is Modified

* Deleted items
  * Method `GetConfigurationFields(Int32, String)`
  * Method `TestConnection(String, StringDictionary)`
* New items
  * Method `FieldMetadataImplementation()`
  * Method `GetConfigurationFieldsAsync(Int32, String, CancellationToken)`
  * Method `TestConnectionAsync(String, StringDictionary, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.FieldValueInfoImplementation is Modified

* Deleted items
  * Method `ExecuteByEntityIds(FieldValueInfo[], String, String, String)`
  * Method `ExecuteBySelectionId(FieldValueInfo[], String, String, Int32, Boolean)`
  * Method `GetAvailableFields(String)`
  * Method `GetJobResultAsJsonFromBinaryObjectId(String, Int32)`
  * Method `GetJobResultsFromStorageAsJson()`
  * Method `GetStoredFields(String, String)`
  * Method `RemoveStoredFields(String, String)`
  * Method `RemoveStoredFieldsAndGetDefaultFields(String, String)`
* New items
  * Method `FieldValueInfoImplementation(ISelectionAgent, IBatchImplementation)`
  * Method `ExecuteByEntityIdsAsync(FieldValueInfo[], String, String, String, CancellationToken)`
  * Method `ExecuteBySelectionIdAsync(FieldValueInfo[], String, String, Int32, Boolean, CancellationToken)`
  * Method `GetAvailableFieldsAsync(String, CancellationToken)`
  * Method `GetJobResultAsJsonFromBinaryObjectIdAsync(String, Int32, CancellationToken)`
  * Method `GetJobResultsFromStorageAsJsonAsync(CancellationToken)`
  * Method `GetStoredFieldsAsync(String, String, CancellationToken)`
  * Method `RemoveStoredFieldsAndGetDefaultFieldsAsync(String, String, CancellationToken)`
  * Method `RemoveStoredFieldsAsync(String, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.FindImplementation is Modified

* Deleted items
  * Method `CreateRestrictionGroup(String, String, String, String)`
  * Method `DeleteRestrictionGroup(String, String, String, Int32, String)`
  * Method `Find(String, String, String, Int32, Int32)`
  * Method `FindFromRestrictions(ArchiveRestrictionInfo[], String, Int32, Int32)`
  * Method `FindFromRestrictions2(String, String, Int32, Int32)`
  * Method `FindFromRestrictionsColumns(ArchiveRestrictionInfo[], String, String[], Int32, Int32)`
  * Method `FindFromRestrictionsColumns2(String, String, String, Int32, Int32)`
  * Method `FindFromRestrictionsColumnsOrderBy(ArchiveRestrictionInfo[], String, String[], ArchiveOrderByInfo[], Int32, Int32)`
  * Method `FindFromRestrictionsColumnsOrderBy2(String, String, String, String, Int32, Int32)`
  * Method `FindOrderBy(String, String, String, Int32, Int32, ArchiveOrderByInfo[])`
  * Method `FindOrderBy2(String, String, String, Int32, Int32, String)`
  * Method `FindWithColumns(String, String, String, String[], Int32, Int32, ArchiveOrderByInfo[])`
  * Method `FindWithExtraRestrictions(String, String, String, ArchiveRestrictionInfo[], ArchiveOrderByInfo[], String[], Int32, Int32)`
  * Method `FindWithExtraRestrictions2(String, String, String, String, String, String, Int32, Int32)`
  * Method `GetAvailableRestrictionColumns(String, String)`
  * Method `GetCriteriaInformation(String, String, String, String[])`
  * Method `GetCriteriaInformationWithContext(String, String, String, String[], String)`
  * Method `GetDefaultDesiredColumns(String, String, String)`
  * Method `GetDefaultDesiredColumnsFromRestrictions(String, ArchiveRestrictionInfo[])`
  * Method `GetDefaultDesiredColumnsFromRestrictions2(String, String)`
  * Method `GetDefaultOrderBy(String, String, String)`
  * Method `GetDefaultOrderByFromDesiredColumns(String, String[])`
  * Method `GetRestrictionGroup(String, String, String, Int32, String)`
  * Method `GetRestrictionGroups(String, String, String, String)`
  * Method `GetSpecifiedCriteriaInformationWithDefaults(String, String, String, String[], String[])`
  * Method `GetSpecifiedCriteriaInformationWithDefaultsWithContext(String, String, String, String[], String[], String)`
  * Method `PopulateRestrictions(String, ArchiveRestrictionInfo[])`
  * Method `PopulateRestrictionValues(ArchiveRestrictionInfo[])`
  * Method `SaveRestrictionGroup(String, String, String, ArchiveRestrictionGroup, String)`
  * Method `SaveRestrictionGroups(String, String, String, ArchiveRestrictionGroup[], String)`
  * Method `SaveRestrictions(String, String, String, ArchiveRestrictionInfo[])`
  * Method `SaveRestrictions2(String, String, String, String)`
  * Method `SaveRestrictionsAndGetCriteriaInformation(String, String, String, ArchiveRestrictionInfo[], String[])`
  * Method `SaveRestrictionsAndGetCriteriaInformation2(String, String, String, String, String)`
  * Method `SaveRestrictionsWithContext(String, String, String, ArchiveRestrictionInfo[], String)`
  * Method `SaveRestrictionsWithContext2(String, String, String, String, String)`
* New items
  * Method `CreateRestrictionGroupAsync(String, String, String, String, CancellationToken)`
  * Method `DeleteRestrictionGroupAsync(String, String, String, Int32, String, CancellationToken)`
  * Method `FindAsync(String, String, String, Int32, Int32, CancellationToken)`
  * Method `FindFromRestrictions2Async(String, String, Int32, Int32, CancellationToken)`
  * Method `FindFromRestrictionsAsync(ArchiveRestrictionInfo[], String, Int32, Int32, CancellationToken)`
  * Method `FindFromRestrictionsColumns2Async(String, String, String, Int32, Int32, CancellationToken)`
  * Method `FindFromRestrictionsColumnsAsync(ArchiveRestrictionInfo[], String, String[], Int32, Int32, CancellationToken)`
  * Method `FindFromRestrictionsColumnsOrderBy2Async(String, String, String, String, Int32, Int32, CancellationToken)`
  * Method `FindFromRestrictionsColumnsOrderByAsync(ArchiveRestrictionInfo[], String, String[], ArchiveOrderByInfo[], Int32, Int32, CancellationToken)`
  * Method `FindOrderBy2Async(String, String, String, Int32, Int32, String, CancellationToken)`
  * Method `FindOrderByAsync(String, String, String, Int32, Int32, ArchiveOrderByInfo[], CancellationToken)`
  * Method `FindWithColumnsAsync(String, String, String, String[], Int32, Int32, ArchiveOrderByInfo[], CancellationToken)`
  * Method `FindWithExtraRestrictions2Async(String, String, String, String, String, String, Int32, Int32, CancellationToken)`
  * Method `FindWithExtraRestrictionsAsync(String, String, String, ArchiveRestrictionInfo[], ArchiveOrderByInfo[], String[], Int32, Int32, CancellationToken)`
  * Method `GetAvailableRestrictionColumnsAsync(String, String, CancellationToken)`
  * Method `GetCriteriaInformationAsync(String, String, String, String[], CancellationToken)`
  * Method `GetCriteriaInformationWithContextAsync(String, String, String, String[], String, CancellationToken)`
  * Method `GetDefaultDesiredColumnsAsync(String, String, String, CancellationToken)`
  * Method `GetDefaultDesiredColumnsFromRestrictions2Async(String, String, CancellationToken)`
  * Method `GetDefaultDesiredColumnsFromRestrictionsAsync(String, ArchiveRestrictionInfo[], CancellationToken)`
  * Method `GetDefaultOrderByAsync(String, String, String, CancellationToken)`
  * Method `GetDefaultOrderByFromDesiredColumnsAsync(String, String[], CancellationToken)`
  * Method `GetRestrictionGroupAsync(String, String, String, Int32, String, CancellationToken)`
  * Method `GetRestrictionGroupsAsync(String, String, String, String, CancellationToken)`
  * Method `GetSpecifiedCriteriaInformationWithDefaultsAsync(String, String, String, String[], String[], CancellationToken)`
  * Method `GetSpecifiedCriteriaInformationWithDefaultsWithContextAsync(String, String, String, String[], String[], String, CancellationToken)`
  * Method `PopulateRestrictionsAsync(String, ArchiveRestrictionInfo[], CancellationToken)`
  * Method `PopulateRestrictionValuesAsync(ArchiveRestrictionInfo[], CancellationToken)`
  * Method `SaveRestrictionGroupAsync(String, String, String, ArchiveRestrictionGroup, String, CancellationToken)`
  * Method `SaveRestrictionGroupsAsync(String, String, String, ArchiveRestrictionGroup[], String, CancellationToken)`
  * Method `SaveRestrictions2Async(String, String, String, String, CancellationToken)`
  * Method `SaveRestrictionsAndGetCriteriaInformation2Async(String, String, String, String, String, CancellationToken)`
  * Method `SaveRestrictionsAndGetCriteriaInformationAsync(String, String, String, ArchiveRestrictionInfo[], String[], CancellationToken)`
  * Method `SaveRestrictionsAsync(String, String, String, ArchiveRestrictionInfo[], CancellationToken)`
  * Method `SaveRestrictionsWithContext2Async(String, String, String, String, String, CancellationToken)`
  * Method `SaveRestrictionsWithContextAsync(String, String, String, ArchiveRestrictionInfo[], String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ForeignAppEntityImplementation is Modified

* Deleted items
  * Method `ForeignAppEntityImplementation()`
  * Method `AddDeviceByIdentifier(String, String, String)`
  * Method `AddForeignKey(ForeignKey, String, String, String)`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `DeleteDeviceByIdentifier(String, String, String)`
  * Method `DeleteForeignKeyOnName(String, String, String, String, String, Int32)`
  * Method `GetAppByName(String)`
  * Method `GetFromId(Int32)`
  * Method `GetKey(String, String, String, String, Int32)`
  * Method `GetKeyByValue(String, String, String, String, String)`
  * Method `GetKeyByValueAndIdentifier(String, String, String, String, String, String)`
  * Method `GetKeyOnDeviceIdentifier(String, String, String, String, String, Int32)`
  * Method `GetKeyValue(String, String, String, String, Int32)`
  * Method `GetKeyValueOnDeviceIdentifier(String, String, String, String, String, Int32)`
  * Method `PopulateCarrierFromDataContainer(ForeignAppEntity, ForeignAppEntityDataContainer)`
  * Method `PopulateDataContainerFromCarrier(ForeignAppEntityDataContainer, ForeignAppEntity)`
  * Method `Save(ForeignAppEntity)`
  * Method `SaveDeviceByIdentifier(String, String, String, ForeignDevice)`
  * Method `SaveForeignKey(ForeignKey, String, String, String)`
* Modified items

##### SuperOffice.CRM.Services.Implementation.BL.ForeignAppEntityImplementation.ForeignAppEntityDataContainer is Modified

* Deleted items
  * Method `.ForeignAppEntityDataContainerDelete()`
  * Method `.ForeignAppEntityDataContainerGetCreatedBy(FieldProperty&)`
  * Method `.ForeignAppEntityDataContainerGetNewDataContainer(DefaulterStrategy)`
  * Method `.ForeignAppEntityDataContainerGetNewDataContainer(Boolean)`
  * Method `.ForeignAppEntityDataContainerGetUpdatedBy(FieldProperty&)`
  * Method `.ForeignAppEntityDataContainerSave()`
* New items
  * Method `.ForeignAppEntityDataContainerDeleteAsync(CancellationToken)`
  * Method `.ForeignAppEntityDataContainerGetCreatedByAsync(CancellationToken)`
  * Method `.ForeignAppEntityDataContainerGetNewDataContainerAsync(DefaulterStrategy, CancellationToken)`
  * Method `.ForeignAppEntityDataContainerGetNewDataContainerAsync(Boolean, CancellationToken)`
  * Method `.ForeignAppEntityDataContainerGetUpdatedByAsync(CancellationToken)`
  * Method `.ForeignAppEntityDataContainerSaveAsync(CancellationToken)`

* New items
  * Method `ForeignAppEntityImplementation(IForeignDeviceImplementation, IForeignKeyImplementation)`
  * Method `AddDeviceByIdentifierAsync(String, String, String, CancellationToken)`
  * Method `AddForeignKeyAsync(ForeignKey, String, String, String, CancellationToken)`
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `DeleteDeviceByIdentifierAsync(String, String, String, CancellationToken)`
  * Method `DeleteForeignKeyOnNameAsync(String, String, String, String, String, Int32, CancellationToken)`
  * Method `GetAllForeignKeysOnEntityAsync(String, Int32, CancellationToken)`
  * Method `GetAppByNameAsync(String, CancellationToken)`
  * Method `GetApplicationDevicesAsync(String, CancellationToken)`
  * Method `GetDeviceByIdentifierAsync(String, String, String, CancellationToken)`
  * Method `GetDeviceByNameAsync(String, String, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `GetKeyAsync(String, String, String, String, Int32, CancellationToken)`
  * Method `GetKeyByValueAndIdentifierAsync(String, String, String, String, String, String, CancellationToken)`
  * Method `GetKeyByValueAsync(String, String, String, String, String, CancellationToken)`
  * Method `GetKeyOnDeviceIdentifierAsync(String, String, String, String, String, Int32, CancellationToken)`
  * Method `GetKeyValueAsync(String, String, String, String, Int32, CancellationToken)`
  * Method `GetKeyValueOnDeviceIdentifierAsync(String, String, String, String, String, Int32, CancellationToken)`
  * Method `PopulateCarrierFromDataContainerAsync(ForeignAppEntity, ForeignAppEntityDataContainer, CancellationToken)`
  * Method `PopulateDataContainerFromCarrierAsync(ForeignAppEntityDataContainer, ForeignAppEntity, CancellationToken)`
  * Method `SaveAsync(ForeignAppEntity, CancellationToken)`
  * Method `SaveDeviceByIdentifierAsync(String, String, String, ForeignDevice, CancellationToken)`
  * Method `SaveForeignKeyAsync(ForeignKey, String, String, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.FormEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `Save(FormEntity)`
  * Method `VerifyGoogleRecaptcha(String, String)`
* New items
  * Method `FormEntityImplementation(ITicketMessageEntityImplementation, IHistoryImplementation, ISoListProviderFactory)`
  * Method `CreateDefaultFormEntityAsync(CancellationToken)`
  * Method `DeleteFormEntityAsync(Int32, CancellationToken)`
  * Method `GetFormEntityAsync(Int32, CancellationToken)`
  * Method `SaveFormEntityAsync(FormEntity, CancellationToken)`
  * Method `VerifyGoogleRecaptchaAsync(String, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.FormSubmissionEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `Save(FormSubmissionEntity)`
* New items
  * Method `FormSubmissionEntityImplementation()`
  * Method `CreateDefaultFormSubmissionEntityAsync(CancellationToken)`
  * Method `DeleteFormSubmissionEntityAsync(Int32, CancellationToken)`
  * Method `GetFormSubmissionEntityAsync(Int32, CancellationToken)`
  * Method `SaveFormSubmissionEntityAsync(FormSubmissionEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.FreeTextImplementation is Modified

* Deleted items
  * Method `AddStopWords(List<String>)`
  * Method `AddWords(String)`
  * Method `DeleteStopWordsById(Int32[])`
  * Method `FreetextIndexRows(String, Int32[])`
  * Method `GetStatus()`
  * Method `GetStopWordIdList()`
  * Method `GetStopWordList()`
  * Method `GetSuggestedStopWords(Int32)`
  * Method `RegenerateIndex(Boolean)`
  * Method `SetAutoEnableTravelAreas(Boolean)`
  * Method `SetEnabled(Boolean)`
  * Method `SetMultiWordOperator(FreeTextOperator)`
  * Method `SetSingleWordOperator(FreeTextOperator)`
* New items
  * Method `FreeTextImplementation(IBatchData)`
  * Method `FreetextIndexRowsAsync(String, Int32[], CancellationToken)`
  * Method `GetStatusAsync(CancellationToken)`
  * Method `RegenerateIndexAsync(Boolean, CancellationToken)`
  * Method `SetEnabledAsync(Boolean, CancellationToken)`
  * Method `SetMultiWordOperatorAsync(FreeTextOperator, CancellationToken)`
  * Method `SetSingleWordOperatorAsync(FreeTextOperator, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.HeadingEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `CreateDefaultHeadingFromListDefinition(Int32)`
  * Method `GetFromId(Int32)`
  * Method `Save(HeadingEntity)`
* New items
  * Method `CreateDefaultHeadingEntityAsync(CancellationToken)`
  * Method `CreateDefaultHeadingFromListDefinitionAsync(Int32, CancellationToken)`
  * Method `GetHeadingEntityAsync(Int32, CancellationToken)`
  * Method `SaveHeadingEntityAsync(HeadingEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.HierarchyEntityImplementation is Modified

* Deleted items
  * Method `AddHierarchyToPath(Domain, String, String)`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `DeleteHierarchyFromPath(Domain, String)`
  * Method `FindOrCreateHierarchy(String, Domain)`
  * Method `GetAllDomains()`
  * Method `GetAllInDomain(Domain, Boolean)`
  * Method `GetFromId(Int32)`
  * Method `GetHierarchyFromPath(Domain, String, Boolean)`
  * Method `Save(HierarchyEntity)`
  * Method `UpdateHierarchyFromPath(Domain, String, HierarchyEntity)`
* New items
  * Method `AddHierarchyToPathAsync(Domain, String, String, CancellationToken)`
  * Method `CreateDefaultHierarchyEntityAsync(CancellationToken)`
  * Method `DeleteHierarchyEntityAsync(Int32, CancellationToken)`
  * Method `DeleteHierarchyFromPathAsync(Domain, String, CancellationToken)`
  * Method `FindOrCreateHierarchyAsync(String, Domain, CancellationToken)`
  * Method `GetAllDomainsAsync(CancellationToken)`
  * Method `GetAllInDomainAsync(Domain, Boolean, CancellationToken)`
  * Method `GetHierarchyEntityAsync(Int32, CancellationToken)`
  * Method `GetHierarchyFromPathAsync(Domain, String, Boolean, CancellationToken)`
  * Method `SaveHierarchyEntityAsync(HierarchyEntity, CancellationToken)`
  * Method `UpdateHierarchyFromPathAsync(Domain, String, HierarchyEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.HistoryImplementation is Modified

* Deleted items
  * Method `HistoryImplementation()`
  * Method `DeleteHistory(String, Int32)`
  * Method `GetCurrent(String)`
  * Method `GetGroupViewCurrent()`
  * Method `GetHistory(Int32)`
  * Method `GetNextCurrent(String, Int32)`
  * Method `GetPreviousCurrent(String, Int32)`
  * Method `NonSavingGetNextPrevCurrent(String, Int32, Boolean)`
  * Method `PopulateFromSelectCommand(Select)`
  * Method `SaveCurrent(History)`
* New items
  * Method `HistoryImplementation(IPreferenceImplementation, IPreferenceListImplementation)`
  * Method `DeleteHistoryAsync(String, Int32, CancellationToken)`
  * Method `GetCurrentAsync(String, CancellationToken)`
  * Method `GetGroupViewCurrentAsync(CancellationToken)`
  * Method `GetHistoryAsync(Int32, CancellationToken)`
  * Method `GetHistoryLengthPrefValueAsync(CancellationToken)`
  * Method `GetNextCurrentAsync(String, Int32, CancellationToken)`
  * Method `GetPreviousCurrentAsync(String, Int32, CancellationToken)`
  * Method `NonSavingGetNextPrevCurrentAsync(String, Int32, Boolean, CancellationToken)`
  * Method `PopulateFromSelectCommandAsync(Select, CancellationToken)`
  * Method `SaveCurrentAsync(History, CancellationToken)`
  * Method `SetHistoryLengthPrefValueAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.HistoryListImplementation is Modified

* Deleted items
  * Method `HistoryListImplementation()`
  * Method `ClearHistories(String)`
  * Method `GetHistories()`
  * Method `GetHistoriesByName(String)`
  * Method `GetHistoriesByNames(String[])`
  * Method `GetHistoriesByNamesAndIds(HistoryRequest[])`
  * Method `GetHistoryLengthPrefValue()`
  * Method `GetHistoryRows(String)`
  * Method `SaveCurrents(History[])`
  * Method `SaveHistories(String, History[])`
  * Method `SetHistoryLengthPrefValue(Int32)`
* New items
  * Method `HistoryListImplementation(IHistoryImplementation)`
  * Method `ClearHistoriesAsync(String, CancellationToken)`
  * Method `GetHistoriesAsync(CancellationToken)`
  * Method `GetHistoriesByNameAsync(String, CancellationToken)`
  * Method `GetHistoriesByNamesAndIdsAsync(HistoryRequest[], CancellationToken)`
  * Method `GetHistoriesByNamesAsync(String[], CancellationToken)`
  * Method `GetHistoryRowsAsync(String, CancellationToken)`
  * Method `SaveCurrentsAsync(History[], CancellationToken)`
  * Method `SaveHistoriesAsync(String, History[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ImportErpDataImplementation is Modified

* Deleted items
  * Method `CreateErpImportData(ArchiveRestrictionInfo[], String[], Int32, ErpActorType)`
  * Method `PreviewErpImport(ImportLine[], String[], String, Int32, ErpActorType)`
  * Method `SaveErpImport(ImportLine[], String[], Boolean, String, Int32, ErpActorType)`
* New items
  * Method `ImportErpDataImplementation()`
  * Method `CreateErpImportDataAsync(ArchiveRestrictionInfo[], String[], Int32, ErpActorType, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ImportLineImplementation is Modified

* Deleted items
  * Method `ImportLineImplementation()`
  * Method `CreateDefaultImport()`
  * Method `CreateDefaultImportLine(Int32)`
  * Method `PreviewImport(ImportLine[], String[], String, String)`
  * Method `SaveImport(ImportLine[], String[], Boolean, String, String)`
* New items
  * Method `ImportLineImplementation(IBatchData)`
  * Method `CreateDefaultImportLineAsync(Int32, CancellationToken)`
  * Method `ForceResyncBatchTaskAsync(Int32, ErpActorType, String[])`
  * Method `PreviewImportAsync(ImportLine[], String[], String, String, CancellationToken)`
  * Method `SaveImportAsync(ImportLine[], String[], Boolean, String, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.InstallationImplementation is Modified

* Deleted items
  * Method `PerformTasksAfterCustomObjectTableDeleted(String)`
  * Method `PerformTasksAfterUpgrade()`
  * Method `PerformTasksAfterUpgrade(IProgressNotification)`
* New items
  * Method `InstallationImplementation(IDefaultDashboardsImplementation, ILicenseManager, ILogger<InstallationImplementation>, IMailingStatistics, ISelectionEntityImplementation)`
  * Method `PerformTasksAfterCustomObjectTableDeletedAsync(String, CancellationToken)`
  * Method `PerformTasksAfterUpgradeAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.LegalBaseListImplementation is Modified

* Deleted items
  * Method `GetAllLegalBase()`
  * Method `GetLegalBaseList(Int32[])`
  * Method `GetLegalBases()`
* New items
  * Method `LegalBaseListImplementation()`
  * Method `GetAllLegalBaseAsync(CancellationToken)`
  * Method `GetLegalBaseListAsync(Int32[], CancellationToken)`
  * Method `GetLegalBasesAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.LinkImplementation is Modified

* Deleted items
  * Method `GetLink(Int32)`
  * Method `PopulateFromRow(RelationsRow)`
  * Method `SetLinksOnDataContainer(Link[])`
* Modified items
  * Method `GetTableNumberOnEntityName(String)`
* New items
  * Method `GetLinkAsync(Int32, CancellationToken)`
  * Method `PopulateFromRowAsync(RelationsRow, CancellationToken)`
  * Method `PopulateFromRowsAsync(RelationsRows, CancellationToken)`
  * Method `SetLinksOnDataContainerAsync(Link[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.LinkListImplementation is Modified

* Deleted items
  * Method `LinkListImplementation()`
  * Method `GetLinkList(Int32[])`
  * Method `PopulateFromRows(RelationsRows)`
* New items
  * Method `LinkListImplementation(ILinkImplementation)`
  * Method `GetLinkListAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ListEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `DeleteListEntityByName(String)`
  * Method `GetFromId(Int32, Boolean)`
  * Method `GetListDefinitions(Boolean)`
  * Method `GetListEntityByName(String)`
  * Method `Save(ListEntity)`
  * Method `SaveListEntityByName(String, ListEntity)`
* New items
  * Method `ListEntityImplementation()`
  * Method `CreateDefaultListEntityAsync(CancellationToken)`
  * Method `DeleteListEntityAsync(Int32, CancellationToken)`
  * Method `DeleteListEntityByNameAsync(String, CancellationToken)`
  * Method `GetListDefinitionsAsync(Boolean, CancellationToken)`
  * Method `GetListEntityAsync(Int32, CancellationToken)`
  * Method `GetListEntityByNameAsync(String, CancellationToken)`
  * Method `SaveListEntityAsync(ListEntity, CancellationToken)`
  * Method `SaveListEntityByNameAsync(String, ListEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ListItemEntityImplementation is Modified

* Deleted items
  * Method `AddFromListDefinition(Int32, ListItemEntity)`
  * Method `AddFromListName(String, ListItemEntity)`
  * Method `CreateDefault()`
  * Method `DeleteAllFromListDefinition(Int32)`
  * Method `DeleteAllFromListName(String)`
  * Method `DeleteAllHeadingsFromListDefinition(Int32)`
  * Method `DeleteAllHeadingsFromName(String)`
  * Method `DeleteFromListDefinition(Int32, Int32)`
  * Method `DeleteFromListName(Int32, String)`
  * Method `GetAllFromListDefinition(Int32, Boolean)`
  * Method `GetAllFromListName(String, Boolean)`
  * Method `GetFromListDefinition(Int32, Int32)`
  * Method `GetFromListName(Int32, String)`
  * Method `GetHeadings(Int32, Int32, Boolean)`
  * Method `GetHeadingsForListItemFromListName(String, Int32, Boolean)`
  * Method `GetHeadingsFromListDefinition(Int32)`
  * Method `GetHeadingsFromName(String)`
  * Method `GetListDefinitionFromId(Int32)`
  * Method `GetListDefinitionFromName(String)`
  * Method `GetListItemsForHeading(Int32, Int32)`
  * Method `GetListItemsForHeadingFromListName(String, Int32)`
  * Method `GetListItemsForUserGroup(Int32, Int32)`
  * Method `GetListItemsForUserGroupFromListName(String, Int32)`
  * Method `GetVisibleForUserGroups(Int32, Int32)`
  * Method `GetVisibleForUserGroupsFromListName(String, Int32)`
  * Method `MoveListItem(Int32, Int32, Int32)`
  * Method `SaveAllFromListDefinition(Int32, ListItemEntity[])`
  * Method `SaveAllFromListName(String, ListItemEntity[])`
  * Method `SaveFromListDefinition(Int32, Int32, ListItemEntity)`
  * Method `SaveFromListName(Int32, String, ListItemEntity)`
  * Method `SaveHeadingFromListDefinition(Int32, HeadingEntity)`
  * Method `SaveHeadingFromName(String, HeadingEntity)`
  * Method `SaveHeadingsForListItemFromListDefinition(Int32, Int32, SelectableMDOListItem[])`
  * Method `SaveHeadingsForListItemFromListName(String, Int32, SelectableMDOListItem[])`
  * Method `SaveHeadingsFromListDefinition(Int32, HeadingEntity[])`
  * Method `SaveHeadingsFromName(String, HeadingEntity[])`
  * Method `SaveListItemEntity(ListItemEntity)`
  * Method `SetHeadingsForListItem(Int32, Int32, Int32[], Boolean)`
  * Method `SetListItemsForHeading(Int32, Int32, Int32[], Boolean)`
  * Method `SetListItemsForHeadingFromListName(String, Int32, Int32[], Boolean)`
  * Method `SetListItemsForUserGroup(Int32, Int32, Int32[], Boolean)`
  * Method `SetListItemsForUserGroupFromListName(String, Int32, Int32[], Boolean)`
  * Method `SetRankOnHeadings(Int32, Int32[])`
  * Method `SetRankOnProjectActivity(Int32, Int32[])`
  * Method `SetRankOnProjectDocument(Int32, Int32[])`
  * Method `SetRankOnSaleActivity(Int32, Int32[])`
  * Method `SetRankOnSaleDocument(Int32, Int32[])`
  * Method `SetVisibleForUserGroup(Int32, Int32, Int32[], Boolean)`
  * Method `SetVisibleForUserGroups(Int32, Int32, SelectableMDOListItem[])`
  * Method `SetVisibleForUserGroupsFromListName(String, Int32, SelectableMDOListItem[])`
  * Method `SortListItems(Int32, String)`
* New items
  * Method `ListItemEntityImplementation(IListEntityImplementation, IHeadingEntityImplementation, ISelectableMDOListImplementation)`
  * Method `AddFromListDefinitionAsync(Int32, ListItemEntity, CancellationToken)`
  * Method `AddFromListNameAsync(String, ListItemEntity, CancellationToken)`
  * Method `CreateDefaultListItemEntityAsync(CancellationToken)`
  * Method `DeleteAllFromListDefinitionAsync(Int32, CancellationToken)`
  * Method `DeleteAllFromListNameAsync(String, CancellationToken)`
  * Method `DeleteAllHeadingsFromListDefinitionAsync(Int32, CancellationToken)`
  * Method `DeleteAllHeadingsFromNameAsync(String, CancellationToken)`
  * Method `DeleteFromListDefinitionAsync(Int32, Int32, CancellationToken)`
  * Method `DeleteFromListNameAsync(Int32, String, CancellationToken)`
  * Method `GetAllFromListDefinitionAsync(Int32, Boolean, CancellationToken)`
  * Method `GetAllFromListNameAsync(String, Boolean, CancellationToken)`
  * Method `GetFromListDefinitionAsync(Int32, Int32, CancellationToken)`
  * Method `GetFromListNameAsync(Int32, String, CancellationToken)`
  * Method `GetHeadingsAsync(Int32, Int32, Boolean, CancellationToken)`
  * Method `GetHeadingsForListItemFromListNameAsync(String, Int32, Boolean, CancellationToken)`
  * Method `GetHeadingsFromListDefinitionAsync(Int32, CancellationToken)`
  * Method `GetHeadingsFromNameAsync(String, CancellationToken)`
  * Method `GetListItemsForHeadingAsync(Int32, Int32, CancellationToken)`
  * Method `GetListItemsForHeadingFromListNameAsync(String, Int32, CancellationToken)`
  * Method `GetListItemsForUserGroupAsync(Int32, Int32, CancellationToken)`
  * Method `GetListItemsForUserGroupFromListNameAsync(String, Int32, CancellationToken)`
  * Method `GetVisibleForUserGroupsAsync(Int32, Int32, CancellationToken)`
  * Method `GetVisibleForUserGroupsFromListNameAsync(String, Int32, CancellationToken)`
  * Method `MoveListItemAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `SaveAllFromListDefinitionAsync(Int32, ListItemEntity[], CancellationToken)`
  * Method `SaveAllFromListNameAsync(String, ListItemEntity[], CancellationToken)`
  * Method `SaveFromListDefinitionAsync(Int32, Int32, ListItemEntity, CancellationToken)`
  * Method `SaveFromListNameAsync(Int32, String, ListItemEntity, CancellationToken)`
  * Method `SaveHeadingFromListDefinitionAsync(Int32, HeadingEntity, CancellationToken)`
  * Method `SaveHeadingFromNameAsync(String, HeadingEntity, CancellationToken)`
  * Method `SaveHeadingsForListItemFromListDefinitionAsync(Int32, Int32, SelectableMDOListItem[], CancellationToken)`
  * Method `SaveHeadingsForListItemFromListNameAsync(String, Int32, SelectableMDOListItem[], CancellationToken)`
  * Method `SaveHeadingsFromListDefinitionAsync(Int32, HeadingEntity[], CancellationToken)`
  * Method `SaveHeadingsFromNameAsync(String, HeadingEntity[], CancellationToken)`
  * Method `SaveListItemEntityAsync(ListItemEntity, CancellationToken)`
  * Method `SetHeadingsForListItemAsync(Int32, Int32, Int32[], Boolean, CancellationToken)`
  * Method `SetListItemsForHeadingAsync(Int32, Int32, Int32[], Boolean, CancellationToken)`
  * Method `SetListItemsForHeadingFromListNameAsync(String, Int32, Int32[], Boolean, CancellationToken)`
  * Method `SetListItemsForUserGroupAsync(Int32, Int32, Int32[], Boolean, CancellationToken)`
  * Method `SetListItemsForUserGroupFromListNameAsync(String, Int32, Int32[], Boolean, CancellationToken)`
  * Method `SetRankOnHeadingsAsync(Int32, Int32[], CancellationToken)`
  * Method `SetRankOnProjectActivityAsync(Int32, Int32[], CancellationToken)`
  * Method `SetRankOnProjectDocumentAsync(Int32, Int32[], CancellationToken)`
  * Method `SetRankOnSaleActivityAsync(Int32, Int32[], CancellationToken)`
  * Method `SetRankOnSaleDocumentAsync(Int32, Int32[], CancellationToken)`
  * Method `SetVisibleForUserGroupAsync(Int32, Int32, Int32[], Boolean, CancellationToken)`
  * Method `SetVisibleForUserGroupsAsync(Int32, Int32, SelectableMDOListItem[], CancellationToken)`
  * Method `SetVisibleForUserGroupsFromListNameAsync(String, Int32, SelectableMDOListItem[], CancellationToken)`
  * Method `SortListItemsAsync(Int32, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.LiveUiConfigImplementation is Modified

* Deleted items
  * Method `GetLiveUiConfig()`
* New items
  * Method `LiveUiConfigImplementation()`
  * Method `GetLiveUiConfigAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.MailboxEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetFromId(Int32)`
  * Method `Save(MailboxEntity)`
* New items
  * Method `CreateDefaultMailboxEntityAsync(CancellationToken)`
  * Method `GetMailboxEntityAsync(Int32, CancellationToken)`
  * Method `SaveMailboxEntityAsync(MailboxEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.MailingStatisticsImplementation is Modified

* Deleted items
  * Method `CalculateMailingStatistics(Int32, Int32)`
  * Method `GetFormSubmissionsCount(Int32, FormSubmissionStatus)`
* New items
  * Method `MailingStatisticsImplementation(IMailingStatistics)`
  * Method `CalculateMailingStatisticsAsync(Int32, Int32, CancellationToken)`
  * Method `CalculateMailingStatisticsAsync(Int32, CancellationToken)`
  * Method `GetFormSubmissionsCountAsync(Int32, FormSubmissionStatus, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.MassOperationResultImplementation is Modified

* Deleted items
  * Method `Delete(String, Int32[])`
  * Method `Insert(String, String[], String[][])`
  * Method `Truncate(String)`
  * Method `Upsert(String, String[], String[], String[][], UpsertNomatchAction, Boolean)`
* New items
  * Method `MassOperationResultImplementation(IMassOperations)`
  * Method `DeleteAsync(String, Int32[], CancellationToken)`
  * Method `InsertAsync(String, String[], String[][], CancellationToken)`
  * Method `TruncateAsync(String, CancellationToken)`
  * Method `UpsertAsync(String, String[], String[], String[][], UpsertNomatchAction, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.MultiAlarmDataImplementation is Modified

* Deleted items
  * Method `GetAlarms(Boolean, Boolean, Int32)`
* New items
  * Method `MultiAlarmDataImplementation(IBookingManager)`
  * Method `GetAlarmsAsync(Boolean, Boolean, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.NextAvailableTimeListImplementation is Modified

* Deleted items
  * Method `GetNextAvailableTime(Int32[], DateTime, DateTime, Int32, Boolean)`
* New items
  * Method `GetNextAvailableTimeAsync(Int32[], DateTime, DateTime, Int32, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PackageInstaller is Modified

* Deleted items
  * Method `Install(Boolean, Boolean&, Boolean)`
* New items
  * Method `InstallAsync(Boolean, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PaymentTermImplementation is Modified

* Deleted items
  * Method `GetPaymentTerm(Int32)`
* Modified items
  * Method `PopulateFromHDB(PaymentTermsRow)`
  * Method `PopulateFromHDB(PaymentTermsRows)`
* New items
  * Method `PaymentTermImplementation()`
  * Method `GetPaymentTermAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PaymentTermsListImplementation is Modified

* Deleted items
  * Method `GetPaymentTerms()`
* New items
  * Method `PaymentTermsListImplementation(IPaymentTermImplementation)`
  * Method `GetPaymentTermsAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PaymentTypeImplementation is Modified

* Deleted items
  * Method `GetPaymentType(Int32)`
* Modified items
  * Method `PopulateFromHDB(PaymentTypeRow)`
  * Method `PopulateFromHDB(PaymentTypeRows)`
* New items
  * Method `PaymentTypeImplementation()`
  * Method `GetPaymentTypeAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PaymentTypeListImplementation is Modified

* Deleted items
  * Method `GetPaymentTypes()`
* New items
  * Method `PaymentTypeListImplementation(IPaymentTypeImplementation)`
  * Method `GetPaymentTypesAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PersonEntityImplementation is Modified

* Deleted items
  * Method `PersonEntityImplementation()`
  * Method `AddBounce(String)`
  * Method `AddBounceWithCount(String, Int32)`
  * Method `AddBounceWithDetails(String, Int32, Int32, String)`
  * Method `AddEmailAddressToPerson(Int32, String, Boolean)`
  * Method `ChangeCountry(PersonEntity, Int32)`
  * Method `CheckTemporaryKey(String)`
  * Method `CreateDefault()`
  * Method `CreateDefaultByContactId(Int32)`
  * Method `CreateDefaultFromCredential(Int32, String, String, String)`
  * Method `CreateOrUpdateUserCandidate(Int32, String, Boolean)`
  * Method `CreateTemporaryKey(TemporaryKeyDomain, Int32, Int32, DateTime)`
  * Method `CreateTemporaryKeyWithPayload(TemporaryKeyDomain, Int32, Int32, DateTime, String)`
  * Method `Delete(Int32)`
  * Method `DeleteExpired()`
  * Method `DeleteTemporaryKeysOfDomain(TemporaryKeyDomain, Int32)`
  * Method `GetAddress(Int32)`
  * Method `GetAddressByCountry(Int32, Int32)`
  * Method `GetBestSoLanguageForTemplate(Int32, Int32)`
  * Method `GetBounceEmailsFromDataContainer(PersonEntityDataContainer, PersonEntity, FieldProperty&)`
  * Method `GetCustomerCentrePasswordReplyTemplate(Int32)`
  * Method `GetFromId(Int32)`
  * Method `GetMyPerson()`
  * Method `GetPersonImage(Int32)`
  * Method `GetPersonImages(Int32[], Int32, Int32)`
  * Method `GetPersonSummary(Int32, Int32)`
  * Method `GetPhones(Int32)`
  * Method `GetSalesRep(String, String, String, String, String)`
  * Method `GetUserCandidateByPerson(Int32)`
  * Method `HasConsent(Int32, String)`
  * Method `IsNumberValid(Int32, String)`
  * Method `Merge(Int32, Int32, DateTime, Boolean, Boolean)`
  * Method `Move(Int32, Int32, DateTime)`
  * Method `PopulateCarrierFromDataContainer(PersonEntity, PersonEntityDataContainer)`
  * Method `PopulateDataContainerFromCarrier(PersonEntityDataContainer, PersonEntity)`
  * Method `RemoveConsent(Int32, String)`
  * Method `ResolvePersonFromInfo(Int32, String, String[], String[])`
  * Method `Save(PersonEntity)`
  * Method `SendEmail(String, String, String, String, String, Int32[])`
  * Method `SendEmailWithEventName(String, String, String, String, String, Int32[], String)`
  * Method `SetConsent(Int32, String, String, String, String)`
  * Method `SetPersonImage(Int32, Image)`
  * Method `Undelete(Int32)`
  * Method `ValidatePersonEntity(PersonEntity)`
* Modified items

##### SuperOffice.CRM.Services.Implementation.BL.PersonEntityImplementation.PersonEntityDataContainer is Modified

* Deleted items
  * Method `.PersonEntityDataContainerDelete()`
  * Method `.PersonEntityDataContainerGetChatEmails(FieldProperty&)`
  * Method `.PersonEntityDataContainerGetCorrespondingAssociate(FieldProperty&)`
  * Method `.PersonEntityDataContainerGetCustomerLanguage(FieldProperty&)`
  * Method `.PersonEntityDataContainerGetDataContainerFromId(Int32)`
  * Method `.PersonEntityDataContainerGetEmails(FieldProperty&)`
  * Method `.PersonEntityDataContainerGetInternetPhones(FieldProperty&)`
  * Method `.PersonEntityDataContainerGetNewDataContainer(DefaulterStrategy)`
  * Method `.PersonEntityDataContainerGetNewDataContainer(DefaulterStrategy, Int32)`
  * Method `.PersonEntityDataContainerGetNewDataContainer(Boolean)`
  * Method `.PersonEntityDataContainerGetNewDataContainer(Boolean, Int32)`
  * Method `.PersonEntityDataContainerGetSupportAssociate(FieldProperty&)`
  * Method `.PersonEntityDataContainerGetTicketPriority(FieldProperty&)`
  * Method `.PersonEntityDataContainerGetUrls(FieldProperty&)`
  * Method `.PersonEntityDataContainerGetUserInfoId(FieldProperty&)`
  * Method `.PersonEntityDataContainerSave()`
  * Method `.PersonEntityDataContainerSetDefaults(DefaulterStrategy)`
* New items
  * Method `.PersonEntityDataContainerDeleteAsync(CancellationToken)`
  * Method `.PersonEntityDataContainerGetChatEmailsAsync(CancellationToken)`
  * Method `.PersonEntityDataContainerGetCorrespondingAssociateAsync(CancellationToken)`
  * Method `.PersonEntityDataContainerGetCustomerLanguageAsync(CancellationToken)`
  * Method `.PersonEntityDataContainerGetDataContainerFromIdAsync(Int32, CancellationToken)`
  * Method `.PersonEntityDataContainerGetEmailsAsync(CancellationToken)`
  * Method `.PersonEntityDataContainerGetInternetPhonesAsync(CancellationToken)`
  * Method `.PersonEntityDataContainerGetNewDataContainerAsync(DefaulterStrategy, Int32, CancellationToken)`
  * Method `.PersonEntityDataContainerGetNewDataContainerAsync(DefaulterStrategy, CancellationToken)`
  * Method `.PersonEntityDataContainerGetNewDataContainerAsync(Boolean, Int32, CancellationToken)`
  * Method `.PersonEntityDataContainerGetNewDataContainerAsync(Boolean, CancellationToken)`
  * Method `.PersonEntityDataContainerGetSupportAssociateAsync(CancellationToken)`
  * Method `.PersonEntityDataContainerGetTicketPriorityAsync(CancellationToken)`
  * Method `.PersonEntityDataContainerGetUrlsAsync(CancellationToken)`
  * Method `.PersonEntityDataContainerGetUserInfoIdAsync(CancellationToken)`
  * Method `.PersonEntityDataContainerSaveAsync(CancellationToken)`
  * Method `.PersonEntityDataContainerSetDefaultsAsync(DefaulterStrategy, CancellationToken)`

* New items
  * Method `PersonEntityImplementation(IContactImplementation, IPersonImplementation, IArchiveAgent, ICountryImplementation, IPositionImplementation, ICategoryImplementation, IBusinessImplementation, ITicketPriorityImplementation, ICustomerLanguageImplementation, IFieldInfoBaseImplementation, IUserInfoImplementation, IWorkflowEventImplementation, ICredentialsManager, IBlobEntityImplementation)`
  * Method `AddBounceAsync(String, CancellationToken)`
  * Method `AddBounceWithCountAsync(String, Int32, CancellationToken)`
  * Method `AddBounceWithDetailsAsync(String, Int32, Int32, String, CancellationToken)`
  * Method `AddEmailAddressToPersonAsync(Int32, String, Boolean, CancellationToken)`
  * Method `ChangeCountryAsync(PersonEntity, Int32, CancellationToken)`
  * Method `CheckTemporaryKeyAsync(String, CancellationToken)`
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `CreateDefaultByContactIdAsync(Int32, CancellationToken)`
  * Method `CreateDefaultFromCredentialAsync(Int32, String, String, String, CancellationToken)`
  * Method `CreateOrUpdateUserCandidateAsync(Int32, String, Boolean, CancellationToken)`
  * Method `CreateTemporaryKeyAsync(TemporaryKeyDomain, Int32, Int32, DateTime, CancellationToken)`
  * Method `CreateTemporaryKeyWithPayloadAsync(TemporaryKeyDomain, Int32, Int32, DateTime, String, CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `DeleteExpiredAsync(CancellationToken)`
  * Method `DeleteTemporaryKeysOfDomainAsync(TemporaryKeyDomain, Int32, CancellationToken)`
  * Method `GetAddressAsync(Int32, CancellationToken)`
  * Method `GetAddressByCountryAsync(Int32, Int32, CancellationToken)`
  * Method `GetBestSoLanguageForTemplateAsync(Int32, Int32, CancellationToken)`
  * Method `GetConsentInfosAsync(Int32, CancellationToken)`
  * Method `GetConsentsFromDataContainerAsync(PersonEntityDataContainer, PersonEntity, CancellationToken)`
  * Method `GetCustomerCentrePasswordReplyTemplateAsync(Int32, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `GetMyPersonAsync(CancellationToken)`
  * Method `GetPersonImageAsync(Int32, CancellationToken)`
  * Method `GetPersonImagesAsync(Int32[], Int32, Int32, CancellationToken)`
  * Method `GetPersonSummaryAsync(Int32, Int32, CancellationToken)`
  * Method `GetPhonesAsync(Int32, CancellationToken)`
  * Method `GetSalesRepAsync(String, String, String, String, String, CancellationToken)`
  * Method `GetUserCandidateByPersonAsync(Int32, CancellationToken)`
  * Method `HasConsentAsync(Int32, String, CancellationToken)`
  * Method `IsNumberValidAsync(Int32, String, CancellationToken)`
  * Method `MergeAsync(Int32, Int32, DateTime, Boolean, Boolean, CancellationToken)`
  * Method `MoveAsync(Int32, Int32, DateTime, CancellationToken)`
  * Method `PopulateCarrierFromDataContainerAsync(PersonEntity, PersonEntityDataContainer, CancellationToken)`
  * Method `PopulateDataContainerFromCarrierAsync(PersonEntityDataContainer, PersonEntity, CancellationToken)`
  * Method `RemoveConsentAsync(Int32, String, CancellationToken)`
  * Method `ResolvePersonFromInfoAsync(Int32, String, String[], String[], CancellationToken)`
  * Method `SaveAsync(PersonEntity, CancellationToken)`
  * Method `SendConsentConfirmationEmailAsync(Int32, String, Int32, Int32, String, CancellationToken)`
  * Method `SendCustomerCentrePasswordEmailAsync(Int32, String, String, String, CancellationToken)`
  * Method `SendEmailAsync(String, String, String, String, String, Int32[], CancellationToken)`
  * Method `SendEmailWithEventNameAsync(String, String, String, String, String, Int32[], String, CancellationToken)`
  * Method `SetConsentAsync(Int32, String, String, String, String, CancellationToken)`
  * Method `SetPersonImageAsync(Int32, Image, CancellationToken)`
  * Method `UndeleteAsync(Int32, CancellationToken)`
  * Method `ValidatePersonEntityAsync(PersonEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PersonImageImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
* New items
  * Method `CreateDefaultPersonImageAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PersonImplementation is Modified

* Deleted items
  * Method `PersonImplementation()`
  * Method `GetPerson(Int32)`
  * Method `PopulateFromEntity(Person)`
  * Method `PopulateFromRDB(CustomSearch)`
  * Method `TryAddPersonsToEmailFlow(Int32, Int32[])`
* New items
  * Method `PersonImplementation(IEmailFlowImplementation)`
  * Method `GetPersonAsync(Int32, CancellationToken)`
  * Method `PopulateFromEntityAsync(Person, CancellationToken)`
  * Method `PopulateFromRDBAsync(CustomSearch, CancellationToken)`
  * Method `TryAddPersonsToEmailFlowAsync(Int32, Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PocketStartupDataImplementation is Modified

* Deleted items
  * Method `GetPocketStartupData(String[], DateTime)`
  * Method `GetPushNotificationTagsForDevice(String)`
  * Method `GetRegisteredDevices(Int32)`
  * Method `GetRegisteredDevicesForUser(Int32)`
  * Method `NotificationHandled(NotificationEventType, Int32)`
  * Method `NotificationsHandled(NotificationEvent[])`
  * Method `NotifyUsers(NotificationEventType, Int32)`
  * Method `RegisterDeviceForPushNotification(PocketDeviceInfo)`
  * Method `RunAppointmentAlarmBroker()`
  * Method `SendPushNotification(Int32[], PocketNotificationMessage)`
  * Method `SetPushNotificationTagsForDevice(String, String)`
  * Method `SetPushNotificationTagsForUser(Int32, String)`
* New items
  * Method `PocketStartupDataImplementation(IArchiveAgent, IRemoteTimeZoneMethodsImplementation, IPreferenceImplementation, IPreferenceListImplementation, IWebPanelEntityImplementation, ISentryImplementation, IEMailAccountImplementation, IUdefHelper, ISoListProviderFactory)`
  * Method `GetPocketStartupDataAsync(String[], DateTime, CancellationToken)`
  * Method `GetPushNotificationTagsForDeviceAsync(String, CancellationToken)`
  * Method `GetRegisteredDevicesAsync(Int32, CancellationToken)`
  * Method `NotificationHandledAsync(NotificationEventType, Int32, CancellationToken)`
  * Method `NotificationsHandledAsync(NotificationEvent[], CancellationToken)`
  * Method `NotifyUsersAsync(NotificationEventType, Int32, CancellationToken)`
  * Method `RegisterDeviceForPushNotificationAsync(PocketDeviceInfo, CancellationToken)`
  * Method `RunAppointmentAlarmBrokerAsync(CancellationToken)`
  * Method `SendPushNotificationAsync(Int32[], PocketNotificationMessage, CancellationToken)`
  * Method `SetPushNotificationTagsForDeviceAsync(String, String, CancellationToken)`
  * Method `SetPushNotificationTagsForUserAsync(Int32, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PreferenceDescriptionImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `DeleteFromSectionAndKey(String, String)`
  * Method `GetAll()`
  * Method `GetAllFromSection(String)`
  * Method `GetFromId(Int32)`
  * Method `GetFromSectionAndKey(String, String)`
  * Method `Save(PreferenceDescription)`
  * Method `SaveFromSectionAndKey(String, String, PreferenceDescription)`
* New items
  * Method `CreateDefaultPreferenceDescriptionAsync(CancellationToken)`
  * Method `DeleteFromSectionAndKeyAsync(String, String, CancellationToken)`
  * Method `DeletePreferenceDescriptionAsync(Int32, CancellationToken)`
  * Method `GetAllAsync(CancellationToken)`
  * Method `GetAllFromSectionAsync(String, CancellationToken)`
  * Method `GetFromSectionAndKeyAsync(String, String, CancellationToken)`
  * Method `GetPreferenceDescriptionAsync(Int32, CancellationToken)`
  * Method `SaveFromSectionAndKeyAsync(String, String, PreferenceDescription, CancellationToken)`
  * Method `SavePreferenceDescriptionAsync(PreferenceDescription, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PreferenceDescriptionLineImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `DeletePrefDescLinesByPrefDescId(Int32)`
  * Method `DeletePrefDescLinesByPrefDescIds(Int32[])`
  * Method `DeletePreferenceDescriptionLines(Int32[])`
  * Method `GetFromId(Int32)`
  * Method `GetPreferenceDescriptionLineFromIdAndValue(Int32, String)`
  * Method `GetPreferenceDescriptionLinesByPrefDescId(Int32)`
  * Method `Save(PreferenceDescriptionLine)`
  * Method `SavePreferenceDescriptionLines(PreferenceDescriptionLine[])`
* New items
  * Method `CreateDefaultPreferenceDescriptionLineAsync(CancellationToken)`
  * Method `DeletePrefDescLinesByPrefDescIdAsync(Int32, CancellationToken)`
  * Method `DeletePrefDescLinesByPrefDescIdsAsync(Int32[], CancellationToken)`
  * Method `DeletePreferenceDescriptionLineAsync(Int32, CancellationToken)`
  * Method `DeletePreferenceDescriptionLinesAsync(Int32[], CancellationToken)`
  * Method `GetPreferenceDescriptionLineAsync(Int32, CancellationToken)`
  * Method `GetPreferenceDescriptionLineFromIdAndValueAsync(Int32, String, CancellationToken)`
  * Method `GetPreferenceDescriptionLinesByPrefDescIdAsync(Int32, CancellationToken)`
  * Method `SavePreferenceDescriptionLineAsync(PreferenceDescriptionLine, CancellationToken)`
  * Method `SavePreferenceDescriptionLinesAsync(PreferenceDescriptionLine[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PreferenceListImplementation is Modified

* Deleted items
  * Method `PreferenceListImplementation()`
  * Method `GetPreferences(PreferenceSpec[])`
  * Method `GetPreferencesWithDisplayValues(PreferenceSpec[])`
  * Method `GetTabOrders()`
  * Method `SavePreferenceEntities(Preference[], Boolean)`
  * Method `SavePreferences(Preference[])`
  * Method `SaveTabOrders(TabOrder[])`
* New items
  * Method `PreferenceListImplementation(IPreferenceImplementation)`
  * Method `GetPreferencesAsync(PreferenceSpec[], CancellationToken)`
  * Method `GetPreferencesWithDisplayValuesAsync(PreferenceSpec[], CancellationToken)`
  * Method `GetTabOrdersAsync(CancellationToken)`
  * Method `SavePreferenceEntitiesAsync(Preference[], Boolean, CancellationToken)`
  * Method `SavePreferencesAsync(Preference[], CancellationToken)`
  * Method `SaveTabOrdersAsync(TabOrder[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PreferredTimeZoneImplementation is Modified

* Deleted items
  * Method `GetDefaultTimeZoneInformation()`
* New items
  * Method `PreferredTimeZoneImplementation(IPreferenceAgent)`
  * Method `GetDefaultTimeZoneInformationAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PreviewContactImplementation is Modified

* Deleted items
  * Method `PreviewContactImplementation()`
  * Method `CreateDefault()`
  * Method `GetPreviewContact(Int32)`
* New items
  * Method `PreviewContactImplementation(ICacheManager)`
  * Method `CreateDefaultPreviewContactAsync(CancellationToken)`
  * Method `GetPreviewContactAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PreviewDashImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetPreviewDash(Int32)`
* New items
  * Method `CreateDefaultPreviewDashAsync(CancellationToken)`
  * Method `GetPreviewDashAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PreviewFaqEntryImplementation is Modified

* Deleted items
  * Method `GetPreviewFaqEntry(Int32)`
* New items
  * Method `GetPreviewFaqEntryAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PreviewMailingHeaderImplementation is Modified

* Deleted items
  * Method `GetPreviewMailingHeader(Int32)`
* New items
  * Method `PreviewMailingHeaderImplementation(IMailingStatistics)`
  * Method `GetPreviewMailingHeaderAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PreviewMailingImplementation is Modified

* Deleted items
  * Method `GetPreviewMailing(Int32)`
  * Method `GetPreviewMailingHeader(Int32)`
* Modified items
  * Method `ComputePersonFullName(PersonTableInfo, ISoDataRecord)`
* New items
  * Method `GetPreviewMailingAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PreviewQuickReplyImplementation is Modified

* Deleted items
  * Method `GetPreviewQuickReply(Int32)`
* New items
  * Method `GetPreviewQuickReplyAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PreviewReplyTemplateImplementation is Modified

* Deleted items
  * Method `GetPreviewReplyTemplate(Int32)`
* New items
  * Method `GetPreviewReplyTemplateAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PriceListImplementation is Modified

* Deleted items
  * Method `PriceListImplementation()`
* New items
  * Method `PriceListImplementation(ICurrencyImplementation)`
  * Method `CopySuperOfficePriceListAsync(Int32, String, DateTime, DateTime, Int32, Boolean, CancellationToken)`
  * Method `CreateDefaultPriceListAsync(CancellationToken)`
  * Method `DeletePriceListAsync(Int32, CancellationToken)`
  * Method `GetPriceListAsync(Int32, CancellationToken)`
  * Method `SavePriceListAsync(PriceList, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.PriorityImplementation is Modified

* Deleted items
  * Method `GetPriority(Int32)`
* Modified items
  * Method `PopulateFromHDB(PriorityRow)`
  * Method `PopulateFromHDB(PriorityRows)`
* New items
  * Method `GetPriorityAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProductCategoryImplementation is Modified

* Deleted items
  * Method `GetProductCategory(Int32)`
* Modified items
  * Method `PopulateFromHDB(ProductCategoryRow)`
  * Method `PopulateFromHDB(ProductCategoryRows)`
* New items
  * Method `ProductCategoryImplementation()`
  * Method `GetProductCategoryAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProductCategoryListImplementation is Modified

* Deleted items
  * Method `GetProductCategories()`
* New items
  * Method `ProductCategoryListImplementation(IProductCategoryImplementation)`
  * Method `GetProductCategoriesAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProductFamilyImplementation is Modified

* Deleted items
  * Method `GetProductFamily(Int32)`
* Modified items
  * Method `PopulateFromHDB(ProductFamilyRow)`
  * Method `PopulateFromHDB(ProductFamilyRows)`
* New items
  * Method `ProductFamilyImplementation()`
  * Method `GetProductFamilyAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProductFamilyListImplementation is Modified

* Deleted items
  * Method `GetProductFamilies()`
* New items
  * Method `ProductFamilyListImplementation(IProductFamilyImplementation)`
  * Method `GetProductFamiliesAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProductImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `FindProduct(Int32, String, String)`
  * Method `GetProduct(Int32, String)`
  * Method `GetProductFromDbId(Int32)`
  * Method `GetProductImage(Int32, String, Int32)`
  * Method `RemoveProduct(Int32)`
  * Method `Save(Product)`
  * Method `SaveProduct(Product)`
  * Method `ToggleProductInAssortment(Int32)`
* New items
  * Method `ProductImplementation(IQuoteManagerFactory)`
  * Method `CreateDefaultProductAsync(CancellationToken)`
  * Method `DeleteProductAsync(Int32, CancellationToken)`
  * Method `FindProductAsync(Int32, String, String, CancellationToken)`
  * Method `GetProductAsync(Int32, String, CancellationToken)`
  * Method `GetProductFromDbIdAsync(Int32, CancellationToken)`
  * Method `GetProductImageAsync(Int32, String, Int32, CancellationToken)`
  * Method `RemoveProductAsync(Int32, CancellationToken)`
  * Method `SaveProductAsync(Product, CancellationToken)`
  * Method `ToggleProductInAssortmentAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProductTypeImplementation is Modified

* Deleted items
  * Method `GetProductType(Int32)`
* Modified items
  * Method `PopulateFromHDB(ProductTypeRow)`
  * Method `PopulateFromHDB(ProductTypeRows)`
* New items
  * Method `ProductTypeImplementation()`
  * Method `GetProductTypeAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProductTypeListImplementation is Modified

* Deleted items
  * Method `GetProductTypes()`
* New items
  * Method `ProductTypeListImplementation(IProductTypeImplementation)`
  * Method `GetProductTypesAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProjectEntityImplementation is Modified

* Deleted items
  * Method `ProjectEntityImplementation()`
  * Method `AddProjectMembers(Int32, ProjectMember[])`
  * Method `CreateDefault()`
  * Method `CreateNewEntry(DuplicateEntry)`
  * Method `Delete(Int32)`
  * Method `DeleteProjectMemberByIds(Int32[])`
  * Method `DeleteProjectMembers(Int32, Int32[])`
  * Method `GetDuplicateRules()`
  * Method `GetDuplicates(String)`
  * Method `GetFromId(Int32)`
  * Method `GetNextMilestone(Int32)`
  * Method `GetNextProjectStatus(Int32)`
  * Method `GetProjectImage(Int32)`
  * Method `HasGuide(Int32)`
  * Method `HasGuideActivities(Int32)`
  * Method `IsNumberValid(Int32, String)`
  * Method `Merge(Int32, Int32, Boolean)`
  * Method `OfferAutoNextStatusOnApppointmentCompleted(Int32)`
  * Method `PopulateCarrierFromDataContainer(ProjectEntity, ProjectEntityDataContainer)`
  * Method `PopulateDataContainerFromCarrier(ProjectEntityDataContainer, ProjectEntity)`
  * Method `Save(ProjectEntity)`
  * Method `SetDuplicateRulesStatus(DuplicateRule[])`
  * Method `SetProjectImage(Int32, Image)`
  * Method `ValidateProjectEntity(ProjectEntity)`
* Modified items

##### SuperOffice.CRM.Services.Implementation.BL.ProjectEntityImplementation.ProjectEntityDataContainer is Modified

* Deleted items
  * Method `.ProjectEntityDataContainerDelete()`
  * Method `.ProjectEntityDataContainerGetNewDataContainer(DefaulterStrategy)`
  * Method `.ProjectEntityDataContainerGetNewDataContainer(Boolean)`
  * Method `.ProjectEntityDataContainerGetUrls(FieldProperty&)`
  * Method `.ProjectEntityDataContainerSave()`
  * Method `.ProjectEntityDataContainerSetDefaults(DefaulterStrategy)`
* New items
  * Method `.ProjectEntityDataContainerDeleteAsync(CancellationToken)`
  * Method `.ProjectEntityDataContainerGetNewDataContainerAsync(DefaulterStrategy, CancellationToken)`
  * Method `.ProjectEntityDataContainerGetNewDataContainerAsync(Boolean, CancellationToken)`
  * Method `.ProjectEntityDataContainerGetUrlsAsync(CancellationToken)`
  * Method `.ProjectEntityDataContainerSaveAsync(CancellationToken)`
  * Method `.ProjectEntityDataContainerSetDefaultsAsync(DefaulterStrategy, CancellationToken)`

* New items
  * Method `ProjectEntityImplementation(IAppointmentImplementation, ILinkImplementation, IProjectMemberListImplementation, IProjectStatusImplementation, IProjectTypeImplementation, IFieldInfoBaseImplementation, IDuplicateDetectorFactory, IWorkflowEventImplementation)`
  * Method `AddProjectMembersAsync(Int32, ProjectMember[], CancellationToken)`
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `CreateNewEntryAsync(DuplicateEntry, CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `DeleteProjectMemberByIdsAsync(Int32[], CancellationToken)`
  * Method `DeleteProjectMembersAsync(Int32, Int32[], CancellationToken)`
  * Method `GetDuplicateRulesAsync(CancellationToken)`
  * Method `GetDuplicatesAsync(String, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `GetNextMilestoneAsync(Int32, CancellationToken)`
  * Method `GetNextProjectStatusAsync(Int32, CancellationToken)`
  * Method `GetProjectImageAsync(Int32, CancellationToken)`
  * Method `HasGuideActivitiesAsync(Int32, CancellationToken)`
  * Method `HasGuideAsync(Int32, CancellationToken)`
  * Method `IsNumberValidAsync(Int32, String, CancellationToken)`
  * Method `MergeAsync(Int32, Int32, Boolean, CancellationToken)`
  * Method `OfferAutoNextStatusOnApppointmentCompletedAsync(Int32, CancellationToken)`
  * Method `PopulateCarrierFromDataContainerAsync(ProjectEntity, ProjectEntityDataContainer, CancellationToken)`
  * Method `PopulateDataContainerFromCarrierAsync(ProjectEntityDataContainer, ProjectEntity, CancellationToken)`
  * Method `SaveAsync(ProjectEntity, CancellationToken)`
  * Method `SetDuplicateRulesStatusAsync(DuplicateRule[], CancellationToken)`
  * Method `SetProjectImageAsync(Int32, Image, CancellationToken)`
  * Method `ValidateProjectEntityAsync(ProjectEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProjectImplementation is Modified

* Deleted items
  * Method `GetProject(Int32)`
  * Method `PopulateFromRDB(CustomSearch)`
* New items
  * Method `GetProjectAsync(Int32, CancellationToken)`
  * Method `PopulateFromRDBAsync(CustomSearch, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProjectStatusImplementation is Modified

* Deleted items
  * Method `DeleteProjectStatus(Int32)`
  * Method `GetProjectStatus(Int32)`
* Modified items
  * Method `PopulateFromHDB(ProjStatusRow)`
  * Method `PopulateFromHDB(ProjStatusRows)`
* New items
  * Method `DeleteProjectStatusAsync(Int32, CancellationToken)`
  * Method `GetProjectStatusAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProjectTypeEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetFromId(Int32)`
  * Method `Save(ProjectTypeEntity)`
* New items
  * Method `CreateDefaultProjectTypeEntityAsync(CancellationToken)`
  * Method `GetProjectTypeEntityAsync(Int32, CancellationToken)`
  * Method `SaveProjectTypeEntityAsync(ProjectTypeEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProjectTypeImplementation is Modified

* Deleted items
  * Method `GetProjectType(Int32)`
* Modified items
  * Method `PopulateFromHDB(ProjTypeRow)`
  * Method `PopulateFromHDB(ProjTypeRows)`
* New items
  * Method `GetProjectTypeAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ProjectTypeStatusLinkImplementation is Modified

* Deleted items
  * Method `GetProjectTypeStatusLink(Int32)`
* New items
  * Method `GetProjectTypeStatusLinkAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.QuickReplyImplementation is Modified

* Deleted items
  * Method `GetQuickReplies()`
  * Method `SaveQuickReplies(QuickReply[])`
* New items
  * Method `QuickReplyImplementation()`
  * Method `GetQuickRepliesAsync(CancellationToken)`
  * Method `SaveQuickRepliesAsync(QuickReply[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.QuoteAlternativeImplementation is Modified

* Deleted items
  * Method `QuoteAlternativeImplementation()`
  * Method `CopyQuoteAlternative(Int32, Int32, String)`
  * Method `CreateDefault()`
  * Method `CreateQuoteAlternative(Int32, String, String)`
  * Method `DeleteQuoteAlternative(Int32)`
  * Method `GetFromId(Int32)`
  * Method `GetQuoteAlternatives(Int32)`
  * Method `MoveQuoteLine(Int32, Boolean)`
  * Method `Save(QuoteAlternative)`
* New items
  * Method `QuoteAlternativeImplementation(IQuoteManagerFactory)`
  * Method `CopyQuoteAlternativeAsync(Int32, Int32, String, CancellationToken)`
  * Method `CreateDefaultQuoteAlternativeAsync(CancellationToken)`
  * Method `CreateQuoteAlternativeAsync(Int32, String, String, CancellationToken)`
  * Method `DeleteQuoteAlternativeAsync(Int32, CancellationToken)`
  * Method `GetQuoteAlternativeAsync(Int32, CancellationToken)`
  * Method `GetQuoteAlternativesAsync(Int32, CancellationToken)`
  * Method `MoveQuoteLineAsync(Int32, Boolean, CancellationToken)`
  * Method `RecalculateQuoteAlternativeAsync(Int32, CancellationToken)`
  * Method `SaveQuoteAlternativeAsync(QuoteAlternative, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.QuoteApproveReasonImplementation is Modified

* Deleted items
  * Method `GetQuoteApproveReason(Int32)`
  * Method `GetQuoteApproveReasons()`
  * Method `GetQuoteApproveReasons(Int32[])`
* New items
  * Method `QuoteApproveReasonImplementation()`
  * Method `GetQuoteApproveReasonAsync(Int32, CancellationToken)`
  * Method `GetQuoteApproveReasonsAsync(CancellationToken)`
  * Method `GetQuoteApproveReasonsAsync(CancellationToken, Int32[])`

#### SuperOffice.CRM.Services.Implementation.BL.QuoteConnectionImplementation is Modified

* Deleted items
  * Method `CanConnectorProvideCapability(Int32, String)`
  * Method `CreateConnectionFromConnectorName(String)`
  * Method `DeleteConnection(Int32)`
  * Method `GetActivePriceListsByCurrencyId(Int32, Int32)`
  * Method `GetAllInstalledQuoteConnections()`
  * Method `GetAllPriceLists(Int32, String)`
  * Method `GetAllPriceListsByCurrencyId(Int32, Int32)`
  * Method `GetConnection(Int32)`
  * Method `GetConnectionConfigFields(Int32)`
  * Method `GetConnectionsForAssociate(Int32)`
  * Method `GetConnectionStartupErrors()`
  * Method `GetConnectionStartupResponse(Int32)`
  * Method `GetConnectorCapabilities(Int32)`
  * Method `GetConnectorCapabilityNames(Int32)`
  * Method `RestoreConnection(Int32)`
  * Method `SaveConnection(QuoteConnection)`
  * Method `SaveConnectionConfigFields(Int32, StringDictionary)`
* New items
  * Method `QuoteConnectionImplementation()`
  * Method `CanConnectorProvideCapabilityAsync(Int32, String, CancellationToken)`
  * Method `CreateConnectionFromConnectorNameAsync(String, CancellationToken)`
  * Method `DeleteConnectionAsync(Int32, CancellationToken)`
  * Method `GetActivePriceListsAsync(Int32, String, CancellationToken)`
  * Method `GetActivePriceListsByCurrencyIdAsync(Int32, Int32, CancellationToken)`
  * Method `GetAllAvailableQuoteConnectionsAsync(CancellationToken)`
  * Method `GetAllAvailableQuoteConnectionsWithPriceListsAsync(CancellationToken)`
  * Method `GetAllInstalledQuoteConnectionsAsync(CancellationToken)`
  * Method `GetAllPriceListsAsync(Int32, String, CancellationToken)`
  * Method `GetAllPriceListsByCurrencyIdAsync(Int32, Int32, CancellationToken)`
  * Method `GetConnectionAsync(Int32, CancellationToken)`
  * Method `GetConnectionConfigFieldsAsync(Int32, CancellationToken)`
  * Method `GetConnectionsForAssociateAsync(Int32, CancellationToken)`
  * Method `GetConnectionStartupErrorsAsync(CancellationToken)`
  * Method `GetConnectionStartupResponseAsync(Int32, CancellationToken)`
  * Method `GetConnectorCapabilitiesAsync(Int32, CancellationToken)`
  * Method `GetConnectorCapabilityNamesAsync(Int32, CancellationToken)`
  * Method `HasConnectionsAsync(CancellationToken)`
  * Method `RestoreConnectionAsync(Int32, CancellationToken)`
  * Method `SaveConnectionAsync(QuoteConnection, CancellationToken)`
  * Method `SaveConnectionConfigFieldsAsync(Int32, StringDictionary, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.QuoteConverter is Modified

* Deleted items
  * Method `GetPriceListRow(PriceList)`
  * Method `GetServicesPriceList(PriceListRow)`
  * Method `GetServicesProduct(ProductRow)`
  * Method `GetServicesQuoteEntity(QuoteData)`
* New items
  * Method `GetPriceListRowAsync(PriceList, CancellationToken)`
  * Method `GetServicesPriceListAsync(PriceListRow, CancellationToken)`
  * Method `GetServicesProductAsync(ProductRow, CancellationToken)`
  * Method `GetServicesQuoteEntityAsync(IQuoteData, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.QuoteDenyReasonImplementation is Modified

* Deleted items
  * Method `GetQuoteDenyReason(Int32)`
  * Method `GetQuoteDenyReasons()`
  * Method `GetQuoteDenyReasons(Int32[])`
* New items
  * Method `QuoteDenyReasonImplementation()`
  * Method `GetQuoteDenyReasonAsync(Int32, CancellationToken)`
  * Method `GetQuoteDenyReasonsAsync(CancellationToken)`
  * Method `GetQuoteDenyReasonsAsync(CancellationToken, Int32[])`

#### SuperOffice.CRM.Services.Implementation.BL.QuoteEntityImplementation is Modified

* Deleted items
  * Method `CreateAndSaveQuote(Int32, Int32, String)`
  * Method `CreateAndSaveQuoteFromSale(Int32, Int32)`
  * Method `DeleteQuote(Int32)`
  * Method `GetOrderState(Int32)`
  * Method `GetQuoteEntity(Int32)`
  * Method `GetQuoteEntityFromSaleId(Int32)`
  * Method `PlaceOrder(Int32, Boolean, String, String, String)`
  * Method `SaveQuoteEntity(QuoteEntity)`
* New items
  * Method `QuoteEntityImplementation(IQuoteManagerFactory)`
  * Method `CreateAndSaveQuoteAsync(Int32, Int32, String, CancellationToken)`
  * Method `CreateAndSaveQuoteFromSaleAsync(Int32, Int32, CancellationToken)`
  * Method `DeleteQuoteAsync(Int32, CancellationToken)`
  * Method `GetOrderStateAsync(Int32, CancellationToken)`
  * Method `GetQuoteEntityAsync(Int32, CancellationToken)`
  * Method `GetQuoteEntityFromSaleIdAsync(Int32, CancellationToken)`
  * Method `PlaceOrderAsync(Int32, Boolean, String, String, String, CancellationToken)`
  * Method `SaveQuoteEntityAsync(QuoteEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.QuoteImplementation is Modified

* Deleted items
  * Method `GetQuote(Int32)`
  * Method `GetQuoteFromSaleId(Int32)`
  * Method `SaveQuote(Quote)`
* New items
  * Method `QuoteImplementation(IQuoteVersionImplementation, IQuoteAlternativeImplementation, IQuoteManagerFactory)`
  * Method `GetQuoteAsync(Int32, CancellationToken)`
  * Method `GetQuoteFromSaleIdAsync(Int32, CancellationToken)`
  * Method `SaveQuoteAsync(Quote, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.QuoteLineConfigurationImplementation is Modified

* Deleted items
  * Method `GetAllQuoteLineConfigurations()`
  * Method `GetInUseQuoteLineConfigurations()`
  * Method `GetQuoteLineConfiguration(Int32)`
  * Method `GetQuoteLineConfigurationFromFieldName(String)`
  * Method `SaveQuoteLineConfiguration(QuoteLineConfiguration)`
  * Method `SaveQuoteLineConfigurations(QuoteLineConfiguration[])`
* New items
  * Method `QuoteLineConfigurationImplementation()`
  * Method `GetAllQuoteLineConfigurationsAsync(CancellationToken)`
  * Method `GetInUseQuoteLineConfigurationsAsync(CancellationToken)`
  * Method `GetQuoteLineConfigurationAsync(Int32, CancellationToken)`
  * Method `GetQuoteLineConfigurationFromFieldNameAsync(String, CancellationToken)`
  * Method `SaveQuoteLineConfigurationAsync(QuoteLineConfiguration, CancellationToken)`
  * Method `SaveQuoteLineConfigurationsAsync(QuoteLineConfiguration[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.QuoteLineImplementation is Modified

* Deleted items
  * Method `QuoteLineImplementation()`
  * Method `CreateAndSaveQuoteLines(Int32, String[])`
  * Method `CreateQuoteLine(Int32, String)`
  * Method `CreateQuoteLineFromProduct(Int32, Product)`
  * Method `DeleteQuoteLine(Int32)`
  * Method `DeleteQuoteLines(Int32[])`
  * Method `GetExtraInfo(String)`
  * Method `GetExtraInfoStatic(String)`
  * Method `GetQuoteLine(Int32)`
  * Method `GetQuoteLineImage(Int32, Int32)`
  * Method `GetQuoteLines(Int32)`
  * Method `RecalculateQuoteLine(QuoteLine, String[])`
  * Method `SaveQuoteLine(QuoteLine)`
  * Method `SaveQuoteLineImage(Int32, Image, Int32)`
  * Method `SaveQuoteLines(QuoteLine[])`
* New items
  * Method `QuoteLineImplementation(IQuoteManagerFactory)`
  * Method `CreateAndSaveQuoteLinesAsync(Int32, String[], CancellationToken)`
  * Method `CreateQuoteLineAsync(Int32, String, CancellationToken)`
  * Method `CreateQuoteLineFromProductAsync(Int32, Product, CancellationToken)`
  * Method `DeleteQuoteLineAsync(Int32, CancellationToken)`
  * Method `DeleteQuoteLinesAsync(Int32[], CancellationToken)`
  * Method `GetExtraInfoAsync(String, CancellationToken)`
  * Method `GetQuoteLineAsync(Int32, CancellationToken)`
  * Method `GetQuoteLinesAsync(Int32, CancellationToken)`
  * Method `RecalculateQuoteLineAsync(QuoteLine, String[], CancellationToken)`
  * Method `SaveQuoteLineAsync(QuoteLine, CancellationToken)`
  * Method `SaveQuoteLinesAsync(QuoteLine[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.QuoteVersionAttachmentImplementation is Modified

* Deleted items
  * Method `AddSaleTypeQuoteAttachment(Int32, Int32)`
  * Method `CreateOrUpdateQuoteVersionAttachments(Int32)`
  * Method `DeleteSaleTypeQuoteAttachment(Int32)`
  * Method `IncludeQuoteVersionAttachment(Int32, Int32, Boolean)`
  * Method `ToggleQuoteVersionAttachmentIncluded(Int32)`
  * Method `ToggleSaleTypeQuoteAttachmentDefaultIncluded(Int32)`
* New items
  * Method `QuoteVersionAttachmentImplementation()`
  * Method `AddSaleTypeQuoteAttachmentAsync(Int32, Int32, CancellationToken)`
  * Method `CreateOrUpdateQuoteVersionAttachmentsAsync(Int32, CancellationToken)`
  * Method `DeleteSaleTypeQuoteAttachmentAsync(Int32, CancellationToken)`
  * Method `IncludeQuoteVersionAttachmentAsync(Int32, Int32, Boolean, CancellationToken)`
  * Method `ToggleQuoteVersionAttachmentIncludedAsync(Int32, CancellationToken)`
  * Method `ToggleSaleTypeQuoteAttachmentDefaultIncludedAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.QuoteVersionImplementation is Modified

* Deleted items
  * Method `QuoteVersionImplementation()`
  * Method `ApproveQuoteVersion(Int32, String, Int32, String)`
  * Method `CancelApprovalRequest(Int32)`
  * Method `CreateAndSaveQuoteVersion(Int32)`
  * Method `GenerateQuoteDocuments(Int32, Int32, Boolean, Int32, Boolean, String)`
  * Method `GetOrderConfirmation(Int32, Int32)`
  * Method `GetQuoteVersion(Int32)`
  * Method `GetQuoteVersions(Int32)`
  * Method `GetQuoteVersionWorkflowButtonStates(Int32, Int32)`
  * Method `GetQuoteVersionWorkflowImageState(Int32)`
  * Method `GetQuoteVersionWorkflowState(Int32, Int32)`
  * Method `GetQuoteVersionWorkflowStatusInfo(Int32)`
  * Method `RejectQuoteVersion(Int32, String, Int32, String)`
  * Method `RequestApproval(Int32, Int32, String)`
  * Method `SaveQuoteVersion(QuoteVersion)`
  * Method `SaveQuoteVersionNumber(Int32, String)`
  * Method `SendQuoteVersion(Int32, DateTime, DateTime, String, String)`
  * Method `UpdateQuoteVersionPrices(Int32)`
  * Method `ValidateQuoteVersion(Int32, QuoteVersionButtonAction)`
* New items
  * Method `QuoteVersionImplementation(IQuoteConnectionImplementation, IQuoteManagerFactory)`
  * Method `ApproveQuoteVersionAsync(Int32, String, Int32, String, CancellationToken)`
  * Method `CancelApprovalRequestAsync(Int32, CancellationToken)`
  * Method `CreateAndSaveQuoteVersionAsync(Int32, CancellationToken)`
  * Method `GenerateQuoteDocumentsAsync(Int32, Int32, Boolean, Int32, Boolean, String, CancellationToken)`
  * Method `GetOrderConfirmationAsync(Int32, Int32, CancellationToken)`
  * Method `GetQuoteVersionAsync(Int32, CancellationToken)`
  * Method `GetQuoteVersionsAsync(Int32, CancellationToken)`
  * Method `GetQuoteVersionWorkflowButtonStatesAsync(Int32, Int32, CancellationToken)`
  * Method `GetQuoteVersionWorkflowImageStateAsync(Int32, CancellationToken)`
  * Method `GetQuoteVersionWorkflowStateAsync(Int32, Int32, CancellationToken)`
  * Method `GetQuoteVersionWorkflowStatusInfoAsync(Int32, CancellationToken)`
  * Method `RejectQuoteVersionAsync(Int32, String, Int32, String, CancellationToken)`
  * Method `RequestApprovalAsync(Int32, Int32, String, CancellationToken)`
  * Method `SaveQuoteVersionAsync(QuoteVersion, CancellationToken)`
  * Method `SaveQuoteVersionNumberAsync(Int32, String, CancellationToken)`
  * Method `SendQuoteVersionAsync(Int32, DateTime, DateTime, String, String, CancellationToken)`
  * Method `UpdateQuoteVersionPricesAsync(Int32, CancellationToken)`
  * Method `ValidateQuoteVersionAsync(Int32, QuoteVersionButtonAction, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.RatingImplementation is Modified

* Deleted items
  * Method `GetRating(Int32)`
* Modified items
  * Method `PopulateFromHDB(ProbRow)`
  * Method `PopulateFromHDB(ProbRows)`
* New items
  * Method `GetRatingAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ReasonImplementation is Modified

* Deleted items
  * Method `GetReason(Int32)`
* Modified items
  * Method `PopulateFromHDB(ReasonRow)`
  * Method `PopulateFromHDB(ReasonRows)`
* New items
  * Method `GetReasonAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ReasonSoldImplementation is Modified

* Deleted items
  * Method `GetReasonSold(Int32)`
* Modified items
  * Method `PopulateFromHDB(ReasonSoldRow)`
  * Method `PopulateFromHDB(ReasonSoldRows)`
* New items
  * Method `GetReasonSoldAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ReasonSoldListImplementation is Modified

* Deleted items
  * Method `ReasonSoldListImplementation()`
  * Method `GetAllReasonSold()`
  * Method `GetReasonSoldList(Int32[])`
* New items
  * Method `ReasonSoldListImplementation(IReasonSoldImplementation)`
  * Method `GetAllReasonSoldAsync(CancellationToken)`
  * Method `GetReasonSoldListAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ReasonStalledImplementation is Modified

* Deleted items
  * Method `GetReasonStalled(Int32)`
* Modified items
  * Method `PopulateFromHDB(ReasonStalledRow)`
  * Method `PopulateFromHDB(ReasonStalledRows)`
* New items
  * Method `GetReasonStalledAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ReasonStalledListImplementation is Modified

* Deleted items
  * Method `ReasonStalledListImplementation()`
  * Method `GetAllReasonStalled()`
  * Method `GetReasonStalledList(Int32[])`
* New items
  * Method `ReasonStalledListImplementation(IReasonStalledImplementation)`
  * Method `GetAllReasonStalledAsync(CancellationToken)`
  * Method `GetReasonStalledListAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.RefCountEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `GetNumberEachTemplate()`
  * Method `Save(RefCountEntity)`
  * Method `SaveDefaultNumbering(RefCountEntity)`
  * Method `SetNumberEachTemplate(Boolean)`
* New items
  * Method `CreateDefaultRefCountEntityAsync(CancellationToken)`
  * Method `DeleteRefCountEntityAsync(Int32, CancellationToken)`
  * Method `GetNumberEachTemplateAsync(CancellationToken)`
  * Method `GetRefCountEntityAsync(Int32, CancellationToken)`
  * Method `SaveDefaultNumberingAsync(RefCountEntity, CancellationToken)`
  * Method `SaveRefCountEntityAsync(RefCountEntity, CancellationToken)`
  * Method `SetNumberEachTemplateAsync(Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.RelatedDataImplementation is Modified

* Deleted items
  * Method `GetRelatedData(String, Int32, String[])`
  * Method `GetRelatedData2(String, Int32, String)`
* New items
  * Method `GetRelatedData2Async(String, Int32, String, CancellationToken)`
  * Method `GetRelatedDataAsync(String, Int32, String[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.RelationDefinitionEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetFromId(Int32)`
  * Method `GetFromRow(RelationDefinitionRow, RelationDefinitionEntity&)`
  * Method `Save(RelationDefinitionEntity)`
* New items
  * Method `CreateDefaultRelationDefinitionEntityAsync(CancellationToken)`
  * Method `GetRelationDefinitionEntityAsync(Int32, CancellationToken)`
  * Method `SaveRelationDefinitionEntityAsync(RelationDefinitionEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.RemoteTimeZoneMethodsImplementation is Modified

* Deleted items
  * Method `CheckNewTimeZoneDataAvailable()`
  * Method `DeleteTimeZones()`
  * Method `GetBaseTimeZoneId()`
  * Method `GetDefaultTimeZonePreference()`
  * Method `InitializeTimeZoneData()`
  * Method `SetActiveTimeZoneRow(Int32, Boolean)`
  * Method `SetActiveTimeZonesByFilter(String, Boolean)`
  * Method `SetBaseTimeZoneId(Int32)`
  * Method `TimeOfLastTimeZoneUpdate()`
  * Method `ToggleActiveTimeZoneRow(Int32)`
  * Method `UpdateTimeZoneData()`
* New items
  * Method `RemoteTimeZoneMethodsImplementation()`
  * Method `CheckNewTimeZoneDataAvailableAsync(CancellationToken)`
  * Method `DeleteTimeZonesAsync(CancellationToken)`
  * Method `GetBaseTimeZoneIdAsync(CancellationToken)`
  * Method `GetDefaultTimeZonePreferenceAsync(CancellationToken)`
  * Method `InitializeTimeZoneDataAsync(CancellationToken)`
  * Method `SetActiveTimeZoneRowAsync(Int32, Boolean, CancellationToken)`
  * Method `SetActiveTimeZonesByFilterAsync(String, Boolean, CancellationToken)`
  * Method `SetBaseTimeZoneIdAsync(Int32, CancellationToken)`
  * Method `TimeOfLastTimeZoneUpdateAsync(CancellationToken)`
  * Method `ToggleActiveTimeZoneRowAsync(Int32, CancellationToken)`
  * Method `UpdateTimeZoneDataAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ResourceEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `Save(ResourceEntity)`
* New items
  * Method `CreateDefaultResourceEntityAsync(CancellationToken)`
  * Method `DeleteResourceEntityAsync(Int32, CancellationToken)`
  * Method `GetResourceEntityAsync(Int32, CancellationToken)`
  * Method `SaveResourceEntityAsync(ResourceEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ResourceOverrideImplementation is Modified

* Deleted items
  * Method `ResourceOverrideImplementation()`
  * Method `ActivateResourceSubstitution(String, String, Boolean)`
  * Method `DeleteResourceSubstitution(String, String)`
  * Method `GetResourceSubstitutions(String[], String, Boolean)`
  * Method `IsResourceSubstitutionActive(String[], String)`
  * Method `SetResourceSubstitution(String, String, String, Boolean)`
* New items
  * Method `ResourceOverrideImplementation(IPreferenceAgent)`
  * Method `ActivateResourceSubstitutionAsync(String, String, Boolean, CancellationToken)`
  * Method `DeleteResourceSubstitutionAsync(String, String, CancellationToken)`
  * Method `GetResourceSubstitutionsAsync(String[], String, Boolean, CancellationToken)`
  * Method `IsResourceSubstitutionActiveAsync(String[], String, CancellationToken)`
  * Method `SetResourceSubstitutionAsync(String, String, String, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SaintConfigurationImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetSaintConfigurations()`
  * Method `PopulateFromRow(SaintConfigurationRow)`
  * Method `Save(SaintConfiguration)`
* New items
  * Method `CreateDefaultSaintConfigurationAsync(CancellationToken)`
  * Method `GetSaintConfigurationsAsync(CancellationToken)`
  * Method `SaveSaintConfigurationAsync(SaintConfiguration, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SaleEntityImplementation is Modified

* Deleted items
  * Method `SaleEntityImplementation()`
  * Method `AddSaleStakeholders(Int32, SaleStakeholder[])`
  * Method `BatchUpdateNextDueDate()`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `DeleteSaleStakeholders(Int32[])`
  * Method `GetFromId(Int32)`
  * Method `GetNextDueDate(Int32)`
  * Method `GetNextSaleStage(Int32, Boolean)`
  * Method `GetProbabilityFromStage(Int32)`
  * Method `HasGuide(Int32)`
  * Method `HasGuideActivities(Int32)`
  * Method `HasStakeholderSetting(Int32)`
  * Method `IsNumberValid(Int32, String)`
  * Method `OfferAutoNextStageOnApppointmentCompleted(Int32)`
  * Method `PopulateCarrierFromDataContainer(SaleEntity, SaleEntityDataContainer)`
  * Method `PopulateDataContainerFromCarrier(SaleEntityDataContainer, SaleEntity)`
  * Method `SaleHasQuote(Int32)`
  * Method `Save(SaleEntity)`
  * Method `ValidateSaleEntity(SaleEntity)`
* Modified items

##### SuperOffice.CRM.Services.Implementation.BL.SaleEntityImplementation.SaleEntityDataContainer is Modified

* Deleted items
  * Method `.SaleEntityDataContainerDelete()`
  * Method `.SaleEntityDataContainerGetNewDataContainer(DefaulterStrategy)`
  * Method `.SaleEntityDataContainerGetNewDataContainer(Boolean)`
  * Method `.SaleEntityDataContainerSave()`
  * Method `.SaleEntityDataContainerSetDefaults(DefaulterStrategy)`
* New items
  * Method `.SaleEntityDataContainerDeleteAsync(CancellationToken)`
  * Method `.SaleEntityDataContainerGetNewDataContainerAsync(DefaulterStrategy, CancellationToken)`
  * Method `.SaleEntityDataContainerGetNewDataContainerAsync(Boolean, CancellationToken)`
  * Method `.SaleEntityDataContainerSaveAsync(CancellationToken)`
  * Method `.SaleEntityDataContainerSetDefaultsAsync(DefaulterStrategy, CancellationToken)`

* New items
  * Method `SaleEntityImplementation(IAppointmentImplementation, IContactImplementation, IPersonImplementation, IProjectImplementation, ISaleStakeholderListImplementation, ILinkImplementation, ICurrencyImplementation, ICompetitorImplementation, ICreditedImplementation, IRatingImplementation, IReasonImplementation, ISourceImplementation, ISaleTypeImplementation, IReasonSoldImplementation, IFieldInfoBaseImplementation, IReasonStalledImplementation, IWorkflowEventImplementation)`
  * Method `AddSaleStakeholdersAsync(Int32, SaleStakeholder[], CancellationToken)`
  * Method `BatchUpdateNextDueDateAsync(CancellationToken)`
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `DeleteSaleStakeholdersAsync(Int32[], CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `GetNextDueDateAsync(Int32, CancellationToken)`
  * Method `GetNextSaleStageAsync(Int32, Boolean, CancellationToken)`
  * Method `GetProbabilityFromStageAsync(Int32, CancellationToken)`
  * Method `HasGuideActivitiesAsync(Int32, CancellationToken)`
  * Method `HasGuideAsync(Int32, CancellationToken)`
  * Method `HasStakeholderSettingAsync(Int32, CancellationToken)`
  * Method `IsNumberValidAsync(Int32, String, CancellationToken)`
  * Method `OfferAutoNextStageOnApppointmentCompletedAsync(Int32, CancellationToken)`
  * Method `PopulateCarrierFromDataContainerAsync(SaleEntity, SaleEntityDataContainer, CancellationToken)`
  * Method `PopulateDataContainerFromCarrierAsync(SaleEntityDataContainer, SaleEntity, CancellationToken)`
  * Method `SaleHasQuoteAsync(Int32, CancellationToken)`
  * Method `SaveAsync(SaleEntity, CancellationToken)`
  * Method `ValidateSaleEntityAsync(SaleEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SaleImplementation is Modified

* Deleted items
  * Method `GetSale(Int32)`
  * Method `PopulateFromRDB(CustomSearch, Int32)`
* New items
  * Method `GetSaleAsync(Int32, CancellationToken)`
  * Method `PopulateFromRDBAsync(CustomSearch, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SalesActivityImplementation is Modified

* Deleted items
  * Method `SalesActivityImplementation()`
  * Method `GenerateLead(Int32, String, String, Int32, String, String, String, String, String, String, String, String)`
  * Method `RequestForInfo(Int32, String, String, String, String, String, String, String)`
* New items
  * Method `SalesActivityImplementation(IContactImplementation, IContactListImplementation, IPersonImplementation)`
  * Method `GenerateLeadAsync(Int32, String, String, Int32, String, String, String, String, String, String, String, String, CancellationToken)`
  * Method `RequestForInfoAsync(Int32, String, String, String, String, String, String, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SaleStageEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetFromId(Int32)`
  * Method `Save(SaleStageEntity)`
* Modified items
  * Method `PopulateFromRow(ProbRow)`
  * Method `PopulateFromRows(ProbRows)`
* New items
  * Method `CreateDefaultSaleStageEntityAsync(CancellationToken)`
  * Method `GetSaleStageEntityAsync(Int32, CancellationToken)`
  * Method `SaveSaleStageEntityAsync(SaleStageEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SaleTypeEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetAllSaleTypeEntities(Boolean)`
  * Method `GetFromId(Int32)`
  * Method `Save(SaleTypeEntity)`
* New items
  * Method `CreateDefaultSaleTypeEntityAsync(CancellationToken)`
  * Method `GetSaleTypeEntityAsync(Int32, CancellationToken)`
  * Method `SaveSaleTypeEntityAsync(SaleTypeEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SaleTypeImplementation is Modified

* Deleted items
  * Method `GetSaleType(Int32)`
* Modified items
  * Method `PopulateFromHDB(SaleTypeRow)`
  * Method `PopulateFromHDB(SaleTypeRows)`
* New items
  * Method `GetSaleTypeAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SaleTypeListImplementation is Modified

* Deleted items
  * Method `SaleTypeListImplementation()`
  * Method `GetAllSaleType()`
  * Method `GetSaleTypeList(Int32[])`
* New items
  * Method `SaleTypeListImplementation(ISaleTypeImplementation)`
  * Method `GetAllSaleTypeAsync(CancellationToken)`
  * Method `GetAllSaleTypeEntitiesAsync(Boolean, CancellationToken)`
  * Method `GetSaleTypeListAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SaleTypeStageLinkImplementation is Modified

* Deleted items
  * Method `GetSaleTypeStageLink(Int32)`
* New items
  * Method `GetSaleTypeStageLinkAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ScriptImplementation is Modified

* Deleted items
  * Method `DeleteCRMScriptByUniqueIdentifier(String)`
  * Method `GetCRMScriptByUniqueIdentifier(String)`
  * Method `SaveCRMScriptByUniqueIdentifier(String, Script)`
* New items
  * Method `ScriptImplementation()`
  * Method `DeleteCRMScriptByUniqueIdentifierAsync(String, CancellationToken)`
  * Method `GetCRMScriptByUniqueIdentifierAsync(String, CancellationToken)`
  * Method `SaveCRMScriptByUniqueIdentifierAsync(String, Script, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SelectableMDOListImplementation is Modified

* Deleted items
  * Method `SelectableMDOListImplementation()`
  * Method `GetSelectableList(String, Boolean, String, Boolean)`
  * Method `GetSelectableListWithHistory(String, Boolean, String, Int32[], Boolean)`
  * Method `GetSelectableListWithRestriction(String, String, String)`
  * Method `GetSelectableSimpleList(String)`
  * Method `SetSelected(String, String, SelectableMDOListItem[])`
* New items
  * Method `SelectableMDOListImplementation(ISoListProviderFactory)`
  * Method `GetSelectableListAsync(String, Boolean, String, Boolean, CancellationToken)`
  * Method `GetSelectableListWithHistoryAsync(String, Boolean, String, Int32[], Boolean, CancellationToken)`
  * Method `GetSelectableListWithRestrictionAsync(String, String, String, CancellationToken)`
  * Method `GetSelectableSimpleListAsync(String, CancellationToken)`
  * Method `SetSelectedAsync(String, String, SelectableMDOListItem[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SelectionEntityImplementation is Modified

* Deleted items
  * Method `SelectionEntityImplementation()`
  * Method `AddContactSelectionMembers(Int32, ContactPersonId[])`
  * Method `AddContactSelectionMembersFromSearch(Int32, String)`
  * Method `AddRemoveContactSelectionMemberInterests(Int32, Int32[], Int32[], Int32[], Int32[])`
  * Method `AddSelectionMembers(Int32, Int32[])`
  * Method `AddSelectionMembersFromSearch(Int32, String)`
  * Method `CopyContactSelectionMembers(Int32, Int32)`
  * Method `CopySelectionMembers(Int32, Int32)`
  * Method `CreateContactSelectionFromSelection(Int32, String, SelectionType, Boolean)`
  * Method `CreateContactSelectionFromShadowSelection(Int32, String)`
  * Method `CreateDefault()`
  * Method `CreateNewEntry(DuplicateEntry)`
  * Method `CreateSelectionEntity(String)`
  * Method `CreateSelectionFromSelection(Int32, String, SelectionType, Boolean)`
  * Method `CreateTemporaryContactSelection()`
  * Method `CreateTemporaryContactSelectionFromContactPersonIds(ContactPersonId[])`
  * Method `CreateTemporaryContactSelectionFromProjectMembers(Int32)`
  * Method `CreateTemporaryContactSelectionFromSelectionMemberIds(Int32, Int32[])`
  * Method `CreateTemporarySelectionFromIds(Int32[], Int32)`
  * Method `Delete(Int32)`
  * Method `DeleteContacts(Int32)`
  * Method `DeleteEntities(Int32)`
  * Method `DeletePersons(Int32)`
  * Method `DeleteSelectionEntity(Int32)`
  * Method `EditContactSelectionMemberDetails(Int32, SelectionMemberEditValues)`
  * Method `ExportSelectionMembers(Int32, String, Boolean)`
  * Method `ExportSelectionMembersEnumerator(Int32, String, String, Int32, Boolean, String)`
  * Method `ExportSelectionMembersWithOrderBy(Int32, String, Boolean, String)`
  * Method `GenerateFollowUps(Int32, AppointmentEntity, Int32, Boolean, Boolean)`
  * Method `GetDuplicateRules()`
  * Method `GetDuplicates(String)`
  * Method `GetDynamicSelectionCriteria(Int32)`
  * Method `GetDynamicSelectionCriteriaGroups(Int32)`
  * Method `GetFromId(Int32)`
  * Method `GetParentCombinedSelections(Int32)`
  * Method `GetRecipientStatistics(Int32)`
  * Method `GetRecipientStatisticsFromContactPersonIds(ContactPersonId[])`
  * Method `GetRecipientStatisticsFromProjectMembers(Int32)`
  * Method `GetSelectionMembersArchiveRows(Int32, String)`
  * Method `GetSelectionShadowMembersArchiveRows(Int32, String)`
  * Method `PopulateCarrierFromDataContainer(SelectionEntity, SelectionEntityDataContainer)`
  * Method `PopulateDataContainerFromCarrier(SelectionEntityDataContainer, SelectionEntity)`
  * Method `PostPopulateCarrierFromDataContainer<TRow>(SelectionEntity, DataContainer<SelectionEntity, TRow>)`
  * Method `PostPopulateDataContainerFromCarrier<TRow>(DataContainer<SelectionEntity, TRow>, SelectionEntity)`
  * Method `PrePopulateDataContainerFromCarrier<TRow>(DataContainer<SelectionEntity, TRow>, SelectionEntity)`
  * Method `RemoveContactSelectionMembers(Int32, ContactPersonId[])`
  * Method `RemoveContactSelectionMembersFromIds(Int32, Int32[])`
  * Method `RemoveContactSelectionMembersFromSearch(Int32, String)`
  * Method `RemoveSelectionMembers(Int32, Int32[])`
  * Method `RemoveSelectionMembersById(Int32, Int32[])`
  * Method `RemoveSelectionMembersFromSearch(Int32, String)`
  * Method `Save(SelectionEntity)`
  * Method `SetDuplicateRulesStatus(DuplicateRule[])`
  * Method `SetDynamicSelectionCriteria(Int32, ArchiveRestrictionInfo[])`
  * Method `SetDynamicSelectionCriteria2(Int32, String)`
  * Method `SetDynamicSelectionCriteria3(Int32, ArchiveRestrictionInfo[], String)`
  * Method `SetDynamicSelectionCriteriaGroups(Int32, ArchiveRestrictionGroup[])`
  * Method `StartMailMerge(MailMergeSettings)`
* Modified items
  * Property `SentryIsIgnored`

##### SuperOffice.CRM.Services.Implementation.BL.SelectionEntityImplementation.SelectionEntityDataContainer is Modified

* Deleted items
  * Method `.SelectionEntityDataContainerDelete()`
  * Method `.SelectionEntityDataContainerGetNewDataContainer(DefaulterStrategy)`
  * Method `.SelectionEntityDataContainerGetNewDataContainer(Boolean)`
  * Method `.SelectionEntityDataContainerSave()`
  * Method `.SelectionEntityDataContainerSetDefaults(DefaulterStrategy)`
* New items
  * Method `.SelectionEntityDataContainerDeleteAsync(CancellationToken)`
  * Method `.SelectionEntityDataContainerGetNewDataContainerAsync(DefaulterStrategy, CancellationToken)`
  * Method `.SelectionEntityDataContainerGetNewDataContainerAsync(Boolean, CancellationToken)`
  * Method `.SelectionEntityDataContainerSaveAsync(CancellationToken)`
  * Method `.SelectionEntityDataContainerSetDefaultsAsync(DefaulterStrategy, CancellationToken)`

* New items
  * Method `SelectionEntityImplementation(IAppointmentEntityImplementation, IPersonImplementation, IBatchData, IDuplicateDetectorFactory, ISelectionTypeManager)`
  * Method `AddContactSelectionMembersAsync(Int32, ContactPersonId[], CancellationToken)`
  * Method `AddContactSelectionMembersFromSearchAsync(Int32, String, CancellationToken)`
  * Method `AddRemoveContactSelectionMemberInterestsAsync(Int32, Int32[], Int32[], Int32[], Int32[], CancellationToken)`
  * Method `AddSelectionMembersAsync(Int32, Int32[], CancellationToken)`
  * Method `AddSelectionMembersFromSearchAsync(Int32, String, CancellationToken)`
  * Method `CopyContactSelectionMembersAsync(Int32, Int32, CancellationToken)`
  * Method `CopySelectionMembersAsync(Int32, Int32, CancellationToken)`
  * Method `CreateContactSelectionFromSelectionAsync(Int32, String, SelectionType, Boolean, CancellationToken)`
  * Method `CreateContactSelectionFromShadowSelectionAsync(Int32, String, CancellationToken)`
  * Method `CreateDefaultAsync(CancellationToken)`
  * Method `CreateNewEntryAsync(DuplicateEntry, CancellationToken)`
  * Method `CreateSelectionEntityAsync(String, CancellationToken)`
  * Method `CreateSelectionFromSelectionAsync(Int32, String, SelectionType, Boolean, CancellationToken)`
  * Method `CreateTemporaryContactSelectionAsync(CancellationToken)`
  * Method `CreateTemporaryContactSelectionFromContactPersonIdsAsync(ContactPersonId[], CancellationToken)`
  * Method `CreateTemporaryContactSelectionFromSelectionMemberIdsAsync(Int32, Int32[], CancellationToken)`
  * Method `CreateTemporarySelectionFromIdsAsync(Int32[], Int32, CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `DeleteContactsAsync(Int32, CancellationToken)`
  * Method `DeleteEntitiesAsync(Int32, CancellationToken)`
  * Method `DeletePersonsAsync(Int32, CancellationToken)`
  * Method `DeleteSelectionEntityAsync(Int32, CancellationToken)`
  * Method `EditContactSelectionMemberDetailsAsync(Int32, SelectionMemberEditValues, CancellationToken)`
  * Method `ExportSelectionMembersAsync(Int32, String, Boolean, CancellationToken)`
  * Method `ExportSelectionMembersEnumeratorAsync(Int32, String, String, Int32, Boolean, String, CancellationToken)`
  * Method `ExportSelectionMembersWithOrderByAsync(Int32, String, Boolean, String, CancellationToken)`
  * Method `GenerateFollowUpsAsync(Int32, AppointmentEntity, Int32, Boolean, Boolean, CancellationToken)`
  * Method `GetDuplicateRulesAsync(CancellationToken)`
  * Method `GetDuplicatesAsync(String, CancellationToken)`
  * Method `GetDynamicSelectionCriteriaAsync(Int32, CancellationToken)`
  * Method `GetDynamicSelectionCriteriaGroupsAsync(Int32, CancellationToken)`
  * Method `GetFromIdAsync(Int32, CancellationToken)`
  * Method `GetParentCombinedSelectionsAsync(Int32, CancellationToken)`
  * Method `GetRecipientStatisticsAsync(Int32, CancellationToken)`
  * Method `GetRecipientStatisticsFromContactPersonIdsAsync(ContactPersonId[], CancellationToken)`
  * Method `GetRecipientStatisticsFromProjectMembersAsync(Int32, CancellationToken)`
  * Method `GetSelectionMembersArchiveRowsAsync(Int32, String, CancellationToken)`
  * Method `GetSelectionShadowMembersArchiveRowsAsync(Int32, String, CancellationToken)`
  * Method `PopulateCarrierFromDataContainerAsync(SelectionEntity, SelectionEntityDataContainer, CancellationToken)`
  * Method `PopulateDataContainerFromCarrierAsync(SelectionEntityDataContainer, SelectionEntity, CancellationToken)`
  * Method `PostPopulateCarrierFromDataContainerAsync<TRow>(SelectionEntity, DataContainer<SelectionEntity, TRow>, CancellationToken)`
  * Method `PostPopulateDataContainerFromCarrierAsync<TRow>(DataContainer<SelectionEntity, TRow>, SelectionEntity, CancellationToken)`
  * Method `PrePopulateDataContainerFromCarrierAsync<TRow>(DataContainer<SelectionEntity, TRow>, SelectionEntity, CancellationToken)`
  * Method `RemoveContactSelectionMembersAsync(Int32, ContactPersonId[], CancellationToken)`
  * Method `RemoveContactSelectionMembersFromIdsAsync(Int32, Int32[], CancellationToken)`
  * Method `RemoveContactSelectionMembersFromSearchAsync(Int32, String, CancellationToken)`
  * Method `RemoveSelectionMembersAsync(Int32, Int32[], CancellationToken)`
  * Method `RemoveSelectionMembersByIdAsync(Int32, Int32[], CancellationToken)`
  * Method `RemoveSelectionMembersFromSearchAsync(Int32, String, CancellationToken)`
  * Method `SaveAsync(SelectionEntity, CancellationToken)`
  * Method `SetDuplicateRulesStatusAsync(DuplicateRule[], CancellationToken)`
  * Method `SetDynamicSelectionCriteria2Async(Int32, String, CancellationToken)`
  * Method `SetDynamicSelectionCriteria3Async(Int32, ArchiveRestrictionInfo[], String, CancellationToken)`
  * Method `SetDynamicSelectionCriteriaAsync(Int32, ArchiveRestrictionInfo[], CancellationToken)`
  * Method `SetDynamicSelectionCriteriaGroupsAsync(Int32, ArchiveRestrictionGroup[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SelectionForFindImplementation is Modified

* Deleted items
  * Method `GetSelectionForFind(String, Int32)`
* New items
  * Method `SelectionForFindImplementation(ISelectionTypeManager)`
  * Method `GetSelectionForFindAsync(String, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SelectionSummaryItemImplementation is Modified

* Deleted items
  * Method `GetSelectionSummaries(Int32[])`
* New items
  * Method `SelectionSummaryItemImplementation(ISelectionTypeManager)`
  * Method `GetSelectionSummariesAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SentimentImplementation is Modified

* Deleted items
  * Method `DetectLanguage(String)`
  * Method `DetectSentiment(String)`
  * Method `Translate(String, String)`
  * Method `TranslateEntity(String, Int32, String)`
* New items
  * Method `SentimentImplementation(ILogger<SentimentImplementation>, ITicketMessageEntityImplementation)`
  * Method `DetectLanguageAsync(String, CancellationToken)`
  * Method `DetectSentimentAsync(String, CancellationToken)`
  * Method `TranslateAsync(String, String, CancellationToken)`
  * Method `TranslateEntityAsync(String, Int32, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ServiceAuthImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `Save(ServiceAuth, Boolean)`
* New items
  * Method `CreateDefaultServiceAuthAsync(CancellationToken)`
  * Method `DeleteServiceAuthAsync(Int32, CancellationToken)`
  * Method `GetServiceAuthAsync(Int32, CancellationToken)`
  * Method `SaveServiceAuthAsync(ServiceAuth, Boolean, CancellationToken)`
  * Method `SaveServiceAuthAsync(ServiceAuth, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ShipmentMessageBlockEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `GetUserBlocks(Int32)`
  * Method `Save(ShipmentMessageBlockEntity)`
* New items
  * Method `CreateDefaultShipmentMessageBlockEntityAsync(CancellationToken)`
  * Method `DeleteShipmentMessageBlockEntityAsync(Int32, CancellationToken)`
  * Method `GetShipmentMessageBlockEntityAsync(Int32, CancellationToken)`
  * Method `GetUserBlocksAsync(Int32, CancellationToken)`
  * Method `SaveShipmentMessageBlockEntityAsync(ShipmentMessageBlockEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.ShipmentMessageEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `DeleteMessageAndShipment(Int32)`
  * Method `GetFromId(Int32)`
  * Method `RenameMailingByMessageId(Int32, String)`
  * Method `Save(ShipmentMessageEntity)`
* New items
  * Method `CreateDefaultShipmentMessageEntityAsync(CancellationToken)`
  * Method `DeleteMessageAndShipmentAsync(Int32, CancellationToken)`
  * Method `DeleteShipmentMessageEntityAsync(Int32, CancellationToken)`
  * Method `GetShipmentMessageEntityAsync(Int32, CancellationToken)`
  * Method `RenameMailingByMessageIdAsync(Int32, String, CancellationToken)`
  * Method `SaveShipmentMessageEntityAsync(ShipmentMessageEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SmsConfigImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `CreateDefaultSmsConfig()`
  * Method `Save(SmsConfig)`
  * Method `SaveSmsConfig(SmsConfig)`
* New items
  * Method `GetSmsConfigAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SourceImplementation is Modified

* Deleted items
  * Method `GetSource(Int32)`
* Modified items
  * Method `PopulateFromHDB(SourceRow)`
  * Method `PopulateFromHDB(SourceRows)`
* New items
  * Method `GetSourceAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.StatisticsDataSetImplementation is Modified

* Deleted items
  * Method `GetStatistics(StatusScreenPanelType[])`
* New items
  * Method `StatisticsDataSetImplementation()`
  * Method `GetStatisticsAsync(StatusScreenPanelType[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SuggestedAppointmentEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `Save(SuggestedAppointmentEntity)`
* New items
  * Method `CreateDefaultSuggestedAppointmentEntityAsync(CancellationToken)`
  * Method `GetSuggestedAppointmentEntityAsync(Int32, CancellationToken)`
  * Method `SaveSuggestedAppointmentEntityAsync(SuggestedAppointmentEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SuggestedAppointmentImplementation is Modified

* Deleted items
  * Method `SuggestedAppointmentImplementation()`
  * Method `GetSuggestedAppointment(Int32)`
* New items
  * Method `SuggestedAppointmentImplementation(IAssociateImplementation)`
  * Method `GetSuggestedAppointmentAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SuggestedDocumentEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetFromId(Int32)`
  * Method `Save(SuggestedDocumentEntity)`
* New items
  * Method `CreateDefaultSuggestedDocumentEntityAsync(CancellationToken)`
  * Method `GetSuggestedDocumentEntityAsync(Int32, CancellationToken)`
  * Method `SaveSuggestedDocumentEntityAsync(SuggestedDocumentEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SyncUserAccountImplementation is Modified

* Deleted items
  * Method `GetReadySyncEmailAccounts()`
  * Method `SyncEmailAccount(SyncUserAccount)`
  * Method `SyncEmailAccounts(SyncUserAccount[])`
* New items
  * Method `SyncUserAccountImplementation(INSPrincipalAccessor, IEMailEntityImplementation, ILogger<SyncUserAccount>)`
  * Method `GetReadySyncEmailAccountsAsync(CancellationToken)`
  * Method `SyncEmailAccountAsync(SyncUserAccount, CancellationToken)`
  * Method `SyncEmailAccountsAsync(SyncUserAccount[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.SystemTemplateSettingsImplementation is Modified

* Deleted items
  * Method `CreateMissingTemplates()`
  * Method `GetSystemTemplateSettings()`
  * Method `IsTemplateIdValid(Int32)`
  * Method `IsTemplateIdValid(StringBuilder, Int32, String)`
  * Method `ParseReplyTemplateBody(String, String&, String&, String&)`
  * Method `SaveSystemTemplateSettings(SystemTemplateSettings)`
* New items
  * Method `SystemTemplateSettingsImplementation()`
  * Method `GetSystemTemplateSettingsAsync(CancellationToken)`
  * Method `SaveSystemTemplateSettingsAsync(SystemTemplateSettings, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TableRecordImplementation is Modified

* Deleted items
  * Method `DeleteRow(String, Int32)`
  * Method `InsertRow(String, StringDictionary)`
  * Method `ReadRow(String, Int32)`
  * Method `UpdateRow(String, Int32, StringDictionary)`
* New items
  * Method `DeleteRowAsync(String, Int32, CancellationToken)`
  * Method `InsertRowAsync(String, StringDictionary, CancellationToken)`
  * Method `ReadRowAsync(String, Int32, CancellationToken)`
  * Method `UpdateRowAsync(String, Int32, StringDictionary, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TargetAssignmentImplementation is Modified

* Deleted items
  * Method `TargetAssignmentImplementation()`
  * Method `AddAllDimensionValues(Int32, TargetAssignment[], TargetDimension)`
  * Method `CreateDefault(TargetPeriodType)`
  * Method `CreateDefaultTargetAssignmentForAssociate(Int32, TargetPeriodType)`
  * Method `CreateDefaultTargetAssignmentForCompany()`
  * Method `CreateDefaultTargetAssignmentForCompanyWithDimension(Int32)`
  * Method `CreateDefaultTargetAssignmentForCompanyWithYearAndDimension(Int32, Int32)`
  * Method `CreateDefaultTargetAssignmentForDimensions(TargetAssignment, Int32[], String, TargetPeriodType)`
  * Method `CreateDefaultTargetAssignmentForUserGroup(Int32)`
  * Method `CreateDefaultTargetAssignmentForUserGroupWithDimension(Int32, Int32)`
  * Method `CreateDefaultTargetAssignmentForUserGroupWithYearAndDimension(Int32, Int32, Int32)`
  * Method `CreateTargetMatrix(Int32)`
  * Method `Delete(Int32)`
  * Method `GetFromTargetGroupId(Int32, TargetDimension, TargetPeriodType)`
  * Method `GetFromTargetGroupIdNoProcessing(Int32, String)`
  * Method `GetQueryForTargetGroup(Int32, TargetAssignementLevel, TargetAssignmentInfoTableInfo&, TargetAssignmentValueTableInfo&)`
  * Method `GetTargetAssignmentForYear(Int32, TargetEntityType, TargetLevel, Int32)`
  * Method `GetTargetAssignmentForYearAndDimension(Int32, TargetEntityType, TargetLevel, Int32, Int32)`
  * Method `GetTargetMatrix(Int32, TargetAssignementLevel)`
  * Method `ProcessDimensionData(Int32, TargetAssignment[], TargetDimension)`
  * Method `RemoveAssociateAssignments(Int32)`
  * Method `SaveToTargetGroupId(Int32, TargetPeriodType, TargetDimension, TargetAssignment[])`
  * Method `SortAssignments(IEnumerable<TargetAssignment>, String)`
  * Method `SortTargetMatrix(TargetMatrix)`
  * Method `TargetMatrixToTargetAssignments(TargetMatrix, String)`
* New items
  * Method `TargetAssignmentImplementation(ITargetDimensionImplementation, ITargetRevisionHistoryImplementation, IContactImplementation, IAssociateImplementation, ICurrencyImplementation, IMDOListImplementation, IUserGroupImplementation)`
  * Method `AddAllDimensionValuesAsync(Int32, TargetAssignment[], TargetDimension, CancellationToken)`
  * Method `CreateDefaultTargetAssignmentAsync(TargetPeriodType, CancellationToken)`
  * Method `CreateDefaultTargetAssignmentAsync(CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForAssociateAsync(Int32, TargetPeriodType, CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForCompanyAsync(CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForCompanyWithDimensionAsync(Int32, CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionAsync(Int32, Int32, CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForDimensionsAsync(TargetAssignment, Int32[], String, TargetPeriodType, CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForUserGroupAsync(Int32, CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForUserGroupWithDimensionAsync(Int32, Int32, CancellationToken)`
  * Method `CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `CreateTargetMatrixAsync(Int32, CancellationToken)`
  * Method `DeleteAsync(Int32, CancellationToken)`
  * Method `GetFromTargetGroupIdAsync(Int32, TargetDimension, TargetPeriodType, CancellationToken)`
  * Method `GetFromTargetGroupIdNoProcessingAsync(Int32, String, CancellationToken)`
  * Method `GetTargetAssignmentForYearAndDimensionAsync(Int32, TargetEntityType, TargetLevel, Int32, Int32, CancellationToken)`
  * Method `GetTargetAssignmentForYearAsync(Int32, TargetEntityType, TargetLevel, Int32, CancellationToken)`
  * Method `GetTargetMatrixAsync(Int32, TargetAssignementLevel, CancellationToken)`
  * Method `ProcessDimensionDataAsync(Int32, TargetAssignment[], TargetDimension, CancellationToken)`
  * Method `RemoveAssociateAssignmentsAsync(Int32, CancellationToken)`
  * Method `SaveToTargetGroupIdAsync(Int32, TargetPeriodType, TargetDimension, CancellationToken, TargetAssignment[])`
  * Method `SortAssignmentsAsync(IEnumerable<TargetAssignment>, String, CancellationToken)`
  * Method `SortTargetMatrixAsync(TargetMatrix, CancellationToken)`
  * Method `TargetMatrixToTargetAssignmentsAsync(TargetMatrix, String, CancellationToken)`
  * Method `TransformAssignmentValuesToPeriod(TargetAssignment[], TargetPeriodType, TargetPeriodType)`

#### SuperOffice.CRM.Services.Implementation.BL.TargetDimensionImplementation is Modified

* Deleted items
  * Method `TargetDimensionImplementation()`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `ExactlyOneDimension()`
  * Method `GetAllDimensionIdOfEntityTypeAndMeasurementUnit(TargetEntityType, TargetMeasurementUnit)`
  * Method `GetFirstId()`
  * Method `GetFromId(Int32)`
  * Method `GetTargetDimensionsForEntityType(TargetEntityType)`
  * Method `GetTargetGroupIds(Int32)`
  * Method `Save(TargetDimension)`
* New items
  * Method `TargetDimensionImplementation(ITargetRevisionHistoryImplementation)`
  * Method `CreateDefaultTargetDimensionAsync(CancellationToken)`
  * Method `DeleteTargetDimensionAsync(Int32, CancellationToken)`
  * Method `ExactlyOneDimensionAsync(CancellationToken)`
  * Method `GetAllDimensionIdOfEntityTypeAndMeasurementUnit(TargetEntityType, TargetMeasurementUnit, CancellationToken)`
  * Method `GetFirstIdAsync(CancellationToken)`
  * Method `GetTargetDimensionAsync(Int32, CancellationToken)`
  * Method `GetTargetDimensionsForEntityTypeAsync(TargetEntityType, CancellationToken)`
  * Method `GetTargetGroupIdsAsync(Int32, CancellationToken)`
  * Method `RemoveAssociateAssignmentsAsync(Int32, CancellationToken)`
  * Method `SaveTargetDimensionAsync(TargetDimension, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TargetGroupImplementation is Modified

* Deleted items
  * Method `TargetGroupImplementation()`
  * Method `CreateDefault()`
  * Method `CreateNameMap(TargetAssignment[])`
  * Method `Delete(Int32)`
  * Method `ExportTargetGroupToExcel(Int32)`
  * Method `GetFromId(Int32)`
  * Method `GetTargetGroupForYear(Int32, TargetEntityType)`
  * Method `GetTargetGroupForYearAndDimension(Int32, Int32)`
  * Method `GetTargetGroupIdForYear(Int32, TargetEntityType)`
  * Method `GetTargetGroupIdForYearAndDimension(Int32, Int32)`
  * Method `GetTargetGroupWithoutAssignments(Int32)`
  * Method `GetYear(Int32)`
  * Method `Save(TargetGroup)`
  * Method `TransformAssignmentValuesToPeriod(TargetAssignment[], TargetPeriodType, TargetPeriodType)`
* New items
  * Method `TargetGroupImplementation(ITargetAssignmentImplementation, ITargetDimensionImplementation, IBatchData)`
  * Method `CreateDefaultTargetGroupAsync(CancellationToken)`
  * Method `DeleteTargetGroupAsync(Int32, CancellationToken)`
  * Method `ExportTargetGroupToExcelAsync(Int32, CancellationToken)`
  * Method `GetTargetGroupAsync(Int32, CancellationToken)`
  * Method `GetTargetGroupForYearAndDimensionAsync(Int32, Int32, CancellationToken)`
  * Method `GetTargetGroupForYearAsync(Int32, TargetEntityType, CancellationToken)`
  * Method `GetYearAsync(Int32, CancellationToken)`
  * Method `SaveTargetGroupAsync(TargetGroup, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TargetRevisionHistoryImplementation is Modified

* Deleted items
  * Method `TargetRevisionHistoryImplementation()`
  * Method `CalculateAndSaveRevisionHistory(Int32, Dictionary<Int32, Dictionary<String, TargetHistoryValueState>>, Dictionary<Int32, Dictionary<String, TargetHistoryValueState>>)`
  * Method `CreateDefault()`
  * Method `GetTargetRevisionHistory(Int32)`
  * Method `LogDeleteAssignmentInfo(Int32, Int32)`
* New items
  * Method `TargetRevisionHistoryImplementation(IAssociateImplementation, IDatabaseOperations)`
  * Method `CalculateAndSaveRevisionHistoryAsync(Int32, Dictionary<Int32, Dictionary<String, TargetHistoryValueState>>, Dictionary<Int32, Dictionary<String, TargetHistoryValueState>>, CancellationToken)`
  * Method `CreateDefaultTargetRevisionHistoryAsync(CancellationToken)`
  * Method `DeleteSublevelsByIdsAsync(Int32, IEnumerable<Int32>, IEnumerable<Int32>, IEnumerable<Int32>, CancellationToken)`
  * Method `GetTargetRevisionHistoryAsync(Int32, CancellationToken)`
  * Method `LogDeleteAssignmentInfoAsync(Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TargetRevisionImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
* New items
  * Method `CreateDefaultTargetRevisionAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TaskListItemImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetFromId(Int32)`
  * Method `GetTaskListItems(Boolean)`
  * Method `Save(TaskListItem)`
* New items
  * Method `CreateDefaultTaskListItemAsync(CancellationToken)`
  * Method `GetTaskListItemAsync(Int32, CancellationToken)`
  * Method `GetTaskListItemsAsync(Boolean, CancellationToken)`
  * Method `SaveTaskListItemAsync(TaskListItem, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketCategoryEntityImplementation is Modified

* Deleted items
  * Method `TicketCategoryEntityImplementation()`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFormsNamesByCategoryId(Int32)`
  * Method `GetFromId(Int32)`
  * Method `MoveAllTickets(Int32, Int32)`
  * Method `RebuildFullnames()`
  * Method `Save(TicketCategoryEntity)`
  * Method `UpdateFormsCategoryId(Int32, Int32)`
* Modified items
  * Method `ConvertBaseStatusToClosingStatus(TicketBaseStatus)`
* New items
  * Method `TicketCategoryEntityImplementation(ITicketStatusEntityImplementation, IDatabaseOperations)`
  * Method `CreateDefaultTicketCategoryEntityAsync(CancellationToken)`
  * Method `DeleteTicketCategoryEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketCategoryEntityAsync(Int32, CancellationToken)`
  * Method `MoveAllTicketsAsync(Int32, Int32, CancellationToken)`
  * Method `RebuildFullnamesAsync(CancellationToken)`
  * Method `SaveTicketCategoryEntityAsync(TicketCategoryEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketCategoryImplementation is Modified

* Deleted items
  * Method `GetTicketCategory(Int32)`
* New items
  * Method `TicketCategoryImplementation()`
  * Method `GetTicketCategoryAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketCategoryMembershipEntityImplementation is Modified

* Deleted items
  * Method `UpdateCategoryMemberships(Int32, TicketCategoryMembershipEntity[], TicketCategoryMembershipEntity[], TicketCategoryMembershipEntity[])`
* New items
  * Method `TicketCategoryMembershipEntityImplementation()`
  * Method `UpdateCategoryMembershipsAsync(Int32, TicketCategoryMembershipEntity[], TicketCategoryMembershipEntity[], TicketCategoryMembershipEntity[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketEntityImplementation is Modified

* Deleted items
  * Method `TicketEntityImplementation()`
  * Method `BatchForward(Int32[], String[], String[], String[], String, Boolean)`
  * Method `BatchReply(TicketBatchReplyData)`
  * Method `ClearNotify(Int32[])`
  * Method `CreateDefault()`
  * Method `CreateDefaultForTicketType(Int32)`
  * Method `DeleteTicketEntity(Int32)`
  * Method `DoEscalating(Int32, TicketPriorityEscalateAction)`
  * Method `GetForRmUi(Int32)`
  * Method `GetFromId(Int32, Boolean)`
  * Method `GetHotlistEjUsers(Int32, Int32[], NotifyType, NotifyChannel)`
  * Method `GetNextInQueue()`
  * Method `GetTags(Int32[])`
  * Method `GetTicketAttachments(Int32)`
  * Method `GetTicketMessageEntities(Int32, Int32[])`
  * Method `MergeTickets(TicketEntity, Int32[])`
  * Method `NotifyNewTicket(Int32)`
  * Method `NotifyNewTicketMessage(Int32)`
  * Method `ProcessTicketWhenRead(Int32, Boolean)`
  * Method `ResolveTicketId(Int32)`
  * Method `Save(TicketEntity)`
  * Method `SaveTicketEntityWithNotify(TicketEntity, Boolean)`
  * Method `SetDeletedStatusByIds(Int32[])`
  * Method `SetDeletedStatusByProvider(String, ArchiveRestrictionInfo[])`
  * Method `SetTicketReadByOwner(Int32, TicketReadStatus, Boolean)`
  * Method `SplitTicket(Int32, Int32, DateTime, Int32[], TicketEntity)`
  * Method `SplitTicketMessage(TicketMessageEntity, TicketEntity, TicketMessageEntity, Int32[])`
  * Method `UndeleteByIds(Int32[])`
  * Method `UpdateTicketsReadStatus(Int32[], TicketReadStatus)`
  * Method `UpdateTicketsReadStatusByProvider(String, ArchiveRestrictionInfo[], TicketReadStatus)`
  * Method `ValidateAttachments(Int32[])`
* New items
  * Method `TicketEntityImplementation(IAttachmentEntityImplementation, ITicketImplementation, ITicketMessageImplementation, ITicketMessageEntityImplementation, ITicketStatusEntityImplementation, ITicketPriorityEntityImplementation, ITicketCategoryListImplementation, IPersonImplementation, IUserImplementation, IProjectImplementation, ISaleImplementation, ICacheManager, IBatchData, IPreferenceImplementation)`
  * Method `BatchForwardAsync(Int32[], String[], String[], String[], String, Boolean, CancellationToken)`
  * Method `BatchReplyAsync(TicketBatchReplyData, CancellationToken)`
  * Method `ClearNotifyAsync(Int32[], CancellationToken)`
  * Method `CreateDefaultForTicketTypeAsync(Int32, CancellationToken)`
  * Method `CreateDefaultTicketEntityAsync(CancellationToken)`
  * Method `DeleteTicketEntityAsync(Int32, CancellationToken)`
  * Method `DoEscalatingAsync(Int32, TicketPriorityEscalateAction, CancellationToken)`
  * Method `GetForRmUiAsync(Int32, CancellationToken)`
  * Method `GetHotlistEjUsersAsync(Int32, Int32[], NotifyType, NotifyChannel, CancellationToken)`
  * Method `GetNextInQueueAsync(CancellationToken)`
  * Method `GetTagsAsync(Int32[], CancellationToken)`
  * Method `GetTicketAttachmentsAsync(Int32, CancellationToken)`
  * Method `GetTicketEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketMessageEntitiesAsync(Int32, Int32[], CancellationToken)`
  * Method `MergeTicketsAsync(TicketEntity, Int32[], CancellationToken)`
  * Method `NotifyNewTicketAsync(Int32, CancellationToken)`
  * Method `NotifyNewTicketMessageAsync(Int32, CancellationToken)`
  * Method `ProcessTicketWhenReadAsync(Int32, CancellationToken)`
  * Method `ResolveTicketIdAsync(Int32, CancellationToken)`
  * Method `SaveTicketEntityAsync(TicketEntity, CancellationToken)`
  * Method `SaveTicketEntityWithNotifyAsync(TicketEntity, Boolean, CancellationToken)`
  * Method `SetDeletedStatusByIdsAsync(Int32[], CancellationToken)`
  * Method `SetDeletedStatusByProviderAsync(String, ArchiveRestrictionInfo[], CancellationToken)`
  * Method `SetTicketReadByOwnerAsync(Int32, TicketReadStatus, Boolean, CancellationToken)`
  * Method `SplitTicketAsync(Int32, Int32, DateTime, Int32[], TicketEntity, CancellationToken)`
  * Method `SplitTicketMessageAsync(TicketMessageEntity, TicketEntity, TicketMessageEntity, Int32[], CancellationToken)`
  * Method `UndeleteByIdsAsync(Int32[], CancellationToken)`
  * Method `UpdateTicketsReadStatusAsync(Int32[], TicketReadStatus, CancellationToken)`
  * Method `UpdateTicketsReadStatusByProviderAsync(String, ArchiveRestrictionInfo[], TicketReadStatus, CancellationToken)`
  * Method `ValidateAttachmentsAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketMessageEntityImplementation is Modified

* Deleted items
  * Method `TicketMessageEntityImplementation()`
  * Method `AddAttachments(Int32, Int32[])`
  * Method `CalculateMessageRecipients(Int32, MessageActionType, Int32)`
  * Method `CreateDefault()`
  * Method `DeleteMessageHeaders(Int32[])`
  * Method `DeleteTicketMessageEntity(Int32)`
  * Method `FindAttachments(Int32, Int32, Boolean)`
  * Method `GetAttachmentInfo(Int32)`
  * Method `GetAttachmentInfoNonInline(Int32)`
  * Method `GetAttachmentPreview(Int32)`
  * Method `GetDefaultMessageContent(Int32, MessageActionType, Int32)`
  * Method `GetDefaultMessageContentFull(Int32, MessageActionType, Int32, Int32)`
  * Method `GetDefaultMessageContentWithOptions(Int32, MessageActionType, Int32, Int32, Boolean)`
  * Method `GetFromId(Int32)`
  * Method `GetPreviewAttachmentStream(Int32)`
  * Method `GetRfcAttachmentStream(Int32, Int32)`
  * Method `GetTicketMessageEntities(Int32, Int32[])`
  * Method `GetTicketMessageWithEmbeddedData(Int32, ImageEmbedType)`
  * Method `GetTicketMessageWithOptions(Int32, Boolean)`
  * Method `Html2Text(String)`
  * Method `RemoveMessageAttachments(Int32, Int32[])`
  * Method `SanitizeMailContent(String)`
  * Method `SanitizeMailContents(String[])`
  * Method `SanitizeMailContentWithOptions(String, HtmlSanitizerOptions)`
  * Method `Save(TicketMessageEntity)`
  * Method `SaveTicketMessageEntityWithNotify(TicketMessageEntity, Boolean)`
  * Method `SaveTicketMessageEntityWithOptions(TicketMessageEntity, Boolean, Int32[], Boolean)`
  * Method `SendTicketMessage(Int32, String[], String[], String[], String, Int32, String)`
  * Method `SendTicketMessageSms(Int32, Int32, String[])`
  * Method `SetTicketMessageImportant(Int32, Boolean)`
* New items
  * Method `TicketMessageEntityImplementation(IAttachmentEntityImplementation, ITicketImplementation, IUserImplementation)`
  * Method `AddAttachmentsAsync(Int32, Int32[], CancellationToken)`
  * Method `CalculateMessageRecipientsAsync(Int32, MessageActionType, Int32, CancellationToken)`
  * Method `CreateDefaultTicketMessageEntityAsync(CancellationToken)`
  * Method `DeleteMessageHeadersAsync(Int32[], CancellationToken)`
  * Method `DeleteTicketMessageEntityAsync(Int32, CancellationToken)`
  * Method `GetAttachmentInfoAsync(Int32, CancellationToken)`
  * Method `GetAttachmentInfoNonInlineAsync(Int32, CancellationToken)`
  * Method `GetAttachmentPreviewAsync(Int32, CancellationToken)`
  * Method `GetDefaultMessageContentAsync(Int32, MessageActionType, Int32, CancellationToken)`
  * Method `GetDefaultMessageContentFullAsync(Int32, MessageActionType, Int32, Int32, CancellationToken)`
  * Method `GetDefaultMessageContentWithOptionsAsync(Int32, MessageActionType, Int32, Int32, Boolean, CancellationToken)`
  * Method `GetPreviewAttachmentStreamAsync(Int32, CancellationToken)`
  * Method `GetRfcAttachmentStreamAsync(Int32, Int32, CancellationToken)`
  * Method `GetTicketMessageEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketMessageWithEmbeddedDataAsync(Int32, ImageEmbedType, CancellationToken)`
  * Method `GetTicketMessageWithOptionsAsync(Int32, Boolean, CancellationToken)`
  * Method `Html2TextAsync(String, CancellationToken)`
  * Method `RemoveMessageAttachmentsAsync(Int32, Int32[], CancellationToken)`
  * Method `SanitizeMailContentAsync(String, CancellationToken)`
  * Method `SanitizeMailContentsAsync(String[], CancellationToken)`
  * Method `SanitizeMailContentWithOptionsAsync(String, HtmlSanitizerOptions, CancellationToken)`
  * Method `SaveTicketMessageEntityAsync(TicketMessageEntity, CancellationToken)`
  * Method `SaveTicketMessageEntityWithNotifyAsync(TicketMessageEntity, Boolean, CancellationToken)`
  * Method `SaveTicketMessageEntityWithOptionsAsync(TicketMessageEntity, Boolean, Int32[], Boolean, CancellationToken)`
  * Method `SendTicketMessageAsync(Int32, String[], String[], String[], String, Int32, String, CancellationToken)`
  * Method `SendTicketMessageSmsAsync(Int32, Int32, String[], CancellationToken)`
  * Method `SetTicketMessageImportantAsync(Int32, Boolean, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketPriorityEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `Save(TicketPriorityEntity)`
  * Method `SetTicketPrioritySortOrder(Int32, Int32)`
* New items
  * Method `CreateDefaultTicketPriorityEntityAsync(CancellationToken)`
  * Method `DeleteTicketPriorityEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketPriorityEntityAsync(Int32, CancellationToken)`
  * Method `SaveTicketPriorityEntityAsync(TicketPriorityEntity, CancellationToken)`
  * Method `SetTicketPrioritySortOrderAsync(Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketStatusEntityImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `GlobalChangeTicketStatus(Int32, Int32)`
  * Method `Save(TicketStatusEntity)`
  * Method `SetTicketStatusSortOrder(Int32, Int32)`
* New items
  * Method `CreateDefaultTicketStatusEntityAsync(CancellationToken)`
  * Method `DeleteTicketStatusEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketStatusEntityAsync(Int32, CancellationToken)`
  * Method `GlobalChangeTicketStatusAsync(Int32, Int32, CancellationToken)`
  * Method `SaveTicketStatusEntityAsync(TicketStatusEntity, CancellationToken)`
  * Method `SetTicketStatusSortOrderAsync(Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketSummaryItemImplementation is Modified

* Deleted items
  * Method `GetTicketSummaries(Int32[])`
* New items
  * Method `TicketSummaryItemImplementation()`
  * Method `GetTicketSummariesAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketTypeEntityImplementation is Modified

* Deleted items
  * Method `TicketTypeEntityImplementation()`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetDefaultTicketType()`
  * Method `GetFromId(Int32)`
  * Method `GetTicketType(Int32)`
  * Method `GlobalChangeTicketType(Int32, Int32)`
  * Method `PopulateFromRow(TicketTypeRow, Boolean)`
  * Method `Save(TicketTypeEntity)`
  * Method `SetTicketTypeSortOrder(Int32, Int32)`
* New items
  * Method `TicketTypeEntityImplementation(ITicketStatusListImplementation, ITicketPriorityListImplementation)`
  * Method `CreateDefaultTicketTypeEntityAsync(CancellationToken)`
  * Method `DeleteTicketTypeEntityAsync(Int32, CancellationToken)`
  * Method `GetTicketTypeEntityAsync(Int32, CancellationToken)`
  * Method `GlobalChangeTicketTypeAsync(Int32, Int32, CancellationToken)`
  * Method `SaveTicketTypeEntityAsync(TicketTypeEntity, CancellationToken)`
  * Method `SetTicketTypeSortOrderAsync(Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TicketTypeListImplementation is Modified

* Deleted items
  * Method `GetTicketTypeList(Int32[])`
  * Method `GetTicketTypes()`
* New items
  * Method `TicketTypeListImplementation()`
  * Method `GetTicketTypeListAsync(Int32[], CancellationToken)`
  * Method `GetTicketTypesAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TokenManagementInfoImplementation is Modified

* Deleted items
  * Method `DecryptAndSaveExternalTokens(TokenManagementInfo)`
  * Method `GetExternalTokens(String)`
  * Method `SaveExternalTokens(TokenManagementInfo)`
* New items
  * Method `TokenManagementInfoImplementation()`
  * Method `DecryptAndSaveExternalTokensAsync(TokenManagementInfo, CancellationToken)`
  * Method `GetExternalTokensAsync(String, CancellationToken)`
  * Method `SaveExternalTokensAsync(TokenManagementInfo, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TriggerScriptEntityImplementation is Modified

* Deleted items
  * Method `TriggerScriptEntityImplementation()`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `DeleteTriggerScriptByUniqueId(String)`
  * Method `GetFromId(Int32)`
  * Method `GetTriggerScriptByUniqueId(String)`
  * Method `Save(TriggerScriptEntity)`
  * Method `SaveTriggerScriptByUniqueId(String, TriggerScriptEntity)`
  * Method `ValidateTriggerScript(Int32)`
  * Method `ValidateTriggerScriptByUniqueId(String)`
* New items
  * Method `TriggerScriptEntityImplementation(ICRMScriptEntityImplementation)`
  * Method `CreateDefaultTriggerScriptEntityAsync(CancellationToken)`
  * Method `DeleteTriggerScriptByUniqueIdAsync(String, CancellationToken)`
  * Method `DeleteTriggerScriptEntityAsync(Int32, CancellationToken)`
  * Method `GetTriggerScriptByUniqueIdAsync(String, CancellationToken)`
  * Method `GetTriggerScriptEntityAsync(Int32, CancellationToken)`
  * Method `SaveTriggerScriptByUniqueIdAsync(String, TriggerScriptEntity, CancellationToken)`
  * Method `SaveTriggerScriptEntityAsync(TriggerScriptEntity, CancellationToken)`
  * Method `ValidateTriggerScriptAsync(Int32, CancellationToken)`
  * Method `ValidateTriggerScriptByUniqueIdAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.TypicalSearchesImplementation is Modified

* Deleted items
  * Method `DeleteTypicalSearch(TypicalSearchRows)`
  * Method `GetAllTypicalSearches(String)`
  * Method `UpdateTypicalSearch(TypicalSearches)`
  * Method `UpdateTypicalSearch(TypicalSearches, IProgressNotification)`
* New items
  * Method `TypicalSearchesImplementation()`
  * Method `DeleteTypicalSearchAsync(TypicalSearchRows, CancellationToken)`
  * Method `GetAllTypicalSearchesAsync(String, CancellationToken)`
  * Method `UpdateTypicalSearchAsync(TypicalSearches, IProgressNotification, CancellationToken)`
  * Method `UpdateTypicalSearchAsync(TypicalSearches, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.UiEventImplementation is Modified

* Deleted items
  * Method `PublishAndRetrieveUiEvents(Int32, UiEvent[], MetricPair[])`
* New items
  * Method `UiEventImplementation(IUiEventQueue)`
  * Method `PublishAndRetrieveUiEventsAsync(Int32, UiEvent[], MetricPair[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.UsageStatsImplementation is Modified

* Deleted items
  * Method `CollectDataAdditions()`
  * Method `CollectTableSizes()`
  * Method `CollectWebUsage()`
  * Method `CollectWinUsage()`
  * Method `ResyncUsers()`
* New items
  * Method `UsageStatsImplementation()`
  * Method `CollectDataAdditionsAsync(CancellationToken)`
  * Method `CollectTableSizesAsync(CancellationToken)`
  * Method `CollectWebUsageAsync(CancellationToken)`
  * Method `CollectWinUsageAsync(CancellationToken)`
  * Method `ResyncUsersAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.UserDefinedFieldInfoImplementation is Modified

* Deleted items
  * Method `UserDefinedFieldInfoImplementation()`
  * Method `ChangeFieldType(UserDefinedFieldInfo, UDefFieldType, Boolean)`
  * Method `ClearCaches()`
  * Method `CreateDefault()`
  * Method `CreateUserDefinedFieldInfo(UDefType, UDefFieldType)`
  * Method `Delete(Int32)`
  * Method `DetectColumnIdChanges(UDefType)`
  * Method `DetectUnpublishedChanges(UDefType)`
  * Method `FigureOutListIdFromListTableIdAndUDListDefinitionId(UserDefinedFieldInfo)`
  * Method `GetChangedPageOneFields(UDefType, Int32)`
  * Method `GetFromId(Int32)`
  * Method `GetPublishedUserDefinedFieldFromFieldLabel(String, UDefType)`
  * Method `GetPublishedUserDefinedFieldFromProgId(String, UDefType)`
  * Method `GetPublishedUserDefinedFieldList(UDefType)`
  * Method `GetPublishedUserDefinedPageOneFields(UDefType, Int32)`
  * Method `GetUserDefinedFieldFromFieldLabel(String, UDefType)`
  * Method `GetUserDefinedFieldFromIds(Int32[])`
  * Method `GetUserDefinedFieldFromProgId(String, UDefType)`
  * Method `GetUserDefinedFieldFromProgIds(String[], UDefType)`
  * Method `GetUserDefinedFieldList(UDefType)`
  * Method `GetUserDefinedPageOneFields(UDefType, Int32)`
  * Method `IsAnyPublishEventActive()`
  * Method `IsPublishEventActive(UDefType)`
  * Method `Publish(UDefType)`
  * Method `Revert(UDefType)`
  * Method `Save(UserDefinedFieldInfo)`
  * Method `SaveUserDefinedFieldInfos(UserDefinedFieldInfo[])`
  * Method `SetListTableIdAndUDListDefinitionIdFromSelectedListId(UserDefinedFieldInfo, Int32)`
  * Method `SetPageOneFieldGrouping(UDefType, Boolean)`
  * Method `SetPublishStartSystemEvent(UDefType)`
  * Method `SetRankOnFields(UDefType, Int32[])`
  * Method `SetUserDefinedPageOneField(UDefType, Int32, Int32, Int32)`
* New items
  * Method `UserDefinedFieldInfoImplementation(IUdefHelper, ISystemEventHelper, IUdefPublishHelper)`
  * Method `ChangeFieldTypeAsync(UserDefinedFieldInfo, UDefFieldType, Boolean, CancellationToken)`
  * Method `ClearCachesAsync(CancellationToken)`
  * Method `CreateDefaultUserDefinedFieldInfoAsync(CancellationToken)`
  * Method `CreateUserDefinedFieldInfoAsync(UDefType, UDefFieldType, CancellationToken)`
  * Method `DeleteUserDefinedFieldInfoAsync(Int32, CancellationToken)`
  * Method `DetectColumnIdChangesAsync(UDefType, CancellationToken)`
  * Method `DetectUnpublishedChangesAsync(UDefType, CancellationToken)`
  * Method `FigureOutListIdFromListTableIdAndUDListDefinitionIdAsync(UserDefinedFieldInfo, CancellationToken)`
  * Method `GetChangedPageOneFieldsAsync(UDefType, Int32, CancellationToken)`
  * Method `GetPublishedUserDefinedFieldFromFieldLabelAsync(String, UDefType, CancellationToken)`
  * Method `GetPublishedUserDefinedFieldFromProgIdAsync(String, UDefType, CancellationToken)`
  * Method `GetPublishedUserDefinedFieldListAsync(UDefType, CancellationToken)`
  * Method `GetPublishedUserDefinedPageOneFieldsAsync(UDefType, Int32, CancellationToken)`
  * Method `GetUserDefinedFieldFromFieldLabelAsync(String, UDefType, CancellationToken)`
  * Method `GetUserDefinedFieldFromIdsAsync(Int32[], CancellationToken)`
  * Method `GetUserDefinedFieldFromProgIdAsync(String, UDefType, CancellationToken)`
  * Method `GetUserDefinedFieldFromProgIdsAsync(String[], UDefType, CancellationToken)`
  * Method `GetUserDefinedFieldInfoAsync(Int32, CancellationToken)`
  * Method `GetUserDefinedFieldListAsync(UDefType, CancellationToken)`
  * Method `GetUserDefinedPageOneFieldsAsync(UDefType, Int32, CancellationToken)`
  * Method `IsAnyPublishEventActiveAsync(CancellationToken)`
  * Method `IsPublishEventActiveAsync(UDefType, CancellationToken)`
  * Method `PublishAsync(UDefType, CancellationToken)`
  * Method `RevertAsync(UDefType, CancellationToken)`
  * Method `SaveUserDefinedFieldInfoAsync(UserDefinedFieldInfo, CancellationToken)`
  * Method `SaveUserDefinedFieldInfosAsync(UserDefinedFieldInfo[], CancellationToken)`
  * Method `SetListTableIdAndUDListDefinitionIdFromSelectedListIdAsync(UserDefinedFieldInfo, Int32, CancellationToken)`
  * Method `SetPageOneFieldGroupingAsync(UDefType, Boolean, CancellationToken)`
  * Method `SetPublishStartSystemEventAsync(UDefType, CancellationToken)`
  * Method `SetRankOnFieldsAsync(UDefType, Int32[], CancellationToken)`
  * Method `SetUserDefinedPageOneFieldAsync(UDefType, Int32, Int32, Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.UserImplementation is Modified

* Deleted items
  * Method `UserImplementation()`
  * Method `AddOwnerContact(Int32)`
  * Method `CanChangePassword(Int32)`
  * Method `ChangeOwnPassword(String, String)`
  * Method `ChangePassword(Int32, String, String)`
  * Method `ChangePasswordFromName(String, String, String)`
  * Method `ChangeUserType(User, UserType)`
  * Method `CreateDefault()`
  * Method `CreateDefaultUserFromUserType(UserType)`
  * Method `CreateDefaultUserFromUserTypeAndCredential(UserType, Int32, String, String, String)`
  * Method `CreateDefaultUserFromUserTypeAndPersonId(UserType, Int32)`
  * Method `CreateExternalUser(Int32, String, String, Int32, Boolean)`
  * Method `Delete(Int32)`
  * Method `DeleteExternalUser(Int32)`
  * Method `DeleteUserFromName(String)`
  * Method `ExecuteCommand(String, CommandActionResult, User)`
  * Method `GenerateNewPasswordForExternalUser(String)`
  * Method `GetCommands(User)`
  * Method `GetCredentialTypes()`
  * Method `GetCredentialTypesForUserType(UserType)`
  * Method `GetDefaultAssociateUserName(User)`
  * Method `GetFromId(Int32)`
  * Method `GetSupportedChangePasswordTypes(Int32)`
  * Method `GetUntrustedCredentials(String)`
  * Method `GetUntrustedCredentialsForAssociate(Int32, String)`
  * Method `GetUserFromEjUserId(Int32)`
  * Method `GetUserFromName(String)`
  * Method `GetUserFromPersonId(Int32)`
  * Method `GetUserPresenceStatus(Int32)`
  * Method `GetValidUserName(Int32, UserType, Int32, String)`
  * Method `GetValidUserNameForNewUser(User)`
  * Method `IsNickNameUnique(Int32, String)`
  * Method `IsPasswordValid(Int32, UserType, Int32, String)`
  * Method `IsPasswordValidWithReason(Int32, UserType, Int32, String)`
  * Method `IsUserNameValid(Int32, UserType, Int32, String)`
  * Method `IsUserNameValidWithReason(Int32, UserType, Int32, String)`
  * Method `MakeRetired(Int32, Boolean)`
  * Method `RemoveLicenses(Int32)`
  * Method `RemoveOwnerContact(Int32)`
  * Method `RemoveUntrustedCredentials(String, String)`
  * Method `RemoveUntrustedCredentialsForAssociate(Int32, String, String)`
  * Method `ResolveUserFromInfo(Int32, String, String[], String[], UserType, Credential)`
  * Method `Save(User)`
  * Method `Save(User, Boolean)`
  * Method `SaveUntrustedCredentials(String, UntrustedCredentials)`
  * Method `SaveUntrustedCredentialsForAssociate(Int32, String, UntrustedCredentials)`
  * Method `SaveUserFromName(String, User)`
  * Method `SendChangePasswordEMail(Int32)`
  * Method `SetExternalUserInfo(Int32, String, String, Boolean, Int32, ExternalUserInfoModification)`
  * Method `SetGeneratedPassword(Int32)`
  * Method `SetGeneratedPasswordFromName(String)`
  * Method `SetPassword(Int32, String)`
  * Method `SetPasswordFromName(String, String)`
  * Method `SetUserPresenceStatus(Int32, UserPresenceStatus)`
  * Method `ValidateUser(User)`
* New items
  * Method `UserImplementation(ICredentialImplementation, ICredentialsManager, IPersonEntityImplementation)`
  * Method `AddOwnerContactAsync(Int32, CancellationToken)`
  * Method `CanChangePasswordAsync(Int32, CancellationToken)`
  * Method `ChangeOwnPasswordAsync(String, String, CancellationToken)`
  * Method `ChangePasswordAsync(Int32, String, String, CancellationToken)`
  * Method `ChangePasswordFromNameAsync(String, String, String, CancellationToken)`
  * Method `ChangeUserTypeAsync(User, UserType, CancellationToken)`
  * Method `CreateDefaultUserAsync(CancellationToken)`
  * Method `CreateDefaultUserFromUserTypeAndCredentialAsync(UserType, Int32, String, String, String, CancellationToken)`
  * Method `CreateDefaultUserFromUserTypeAndPersonIdAsync(UserType, Int32, CancellationToken)`
  * Method `CreateDefaultUserFromUserTypeAsync(UserType, CancellationToken)`
  * Method `CreateExternalUserAsync(Int32, String, String, Int32, Boolean, CancellationToken)`
  * Method `DeleteExternalUserAsync(Int32, CancellationToken)`
  * Method `DeleteUserAsync(Int32, CancellationToken)`
  * Method `DeleteUserFromNameAsync(String, CancellationToken)`
  * Method `ExecuteUserCommandAsync(String, CommandActionResult, User, CancellationToken)`
  * Method `GenerateNewPasswordForExternalUserAsync(String, CancellationToken)`
  * Method `GetAccessTokenAsync(String, Boolean, CancellationToken)`
  * Method `GetCredentialTypesAsync(CancellationToken)`
  * Method `GetCredentialTypesForUserTypeAsync(UserType, CancellationToken)`
  * Method `GetDefaultAssociateUserNameAsync(User, CancellationToken)`
  * Method `GetSupportedChangePasswordTypesAsync(Int32, CancellationToken)`
  * Method `GetUntrustedCredentialsAsync(String, CancellationToken)`
  * Method `GetUntrustedCredentialsForAssociateAsync(Int32, String, CancellationToken)`
  * Method `GetUserAsync(Int32, CancellationToken)`
  * Method `GetUserCommandsAsync(User, CancellationToken)`
  * Method `GetUserFromEjUserIdAsync(Int32, CancellationToken)`
  * Method `GetUserFromNameAsync(String, CancellationToken)`
  * Method `GetUserFromPersonIdAsync(Int32, CancellationToken)`
  * Method `GetUserPresenceStatusAsync(Int32, CancellationToken)`
  * Method `GetValidUserNameAsync(Int32, UserType, Int32, String, CancellationToken)`
  * Method `GetValidUserNameForNewUserAsync(User, CancellationToken)`
  * Method `IsNickNameUniqueAsync(Int32, String, CancellationToken)`
  * Method `IsPasswordValidAsync(Int32, UserType, Int32, String, CancellationToken)`
  * Method `IsPasswordValidWithReasonAsync(Int32, UserType, Int32, String, CancellationToken)`
  * Method `IsUserNameValidAsync(Int32, UserType, Int32, String, CancellationToken)`
  * Method `IsUserNameValidWithReasonAsync(Int32, UserType, Int32, String, CancellationToken)`
  * Method `MakeRetiredAsync(Int32, Boolean, CancellationToken)`
  * Method `RemoveLicensesAsync(Int32, CancellationToken)`
  * Method `RemoveOwnerContactAsync(Int32, CancellationToken)`
  * Method `RemoveUntrustedCredentialsAsync(String, String, CancellationToken)`
  * Method `RemoveUntrustedCredentialsForAssociateAsync(Int32, String, String, CancellationToken)`
  * Method `ResolveUserFromInfoAsync(Int32, String, String[], String[], UserType, Credential, CancellationToken)`
  * Method `SaveUntrustedCredentialsAsync(String, UntrustedCredentials, CancellationToken)`
  * Method `SaveUntrustedCredentialsForAssociateAsync(Int32, String, UntrustedCredentials, CancellationToken)`
  * Method `SaveUserAsync(User, CancellationToken)`
  * Method `SaveUserFromNameAsync(String, User, CancellationToken)`
  * Method `SendChangePasswordEMailAsync(Int32, CancellationToken)`
  * Method `SetExternalUserInfoAsync(Int32, String, String, Boolean, Int32, ExternalUserInfoModification, CancellationToken)`
  * Method `SetGeneratedPasswordAsync(Int32, CancellationToken)`
  * Method `SetGeneratedPasswordFromNameAsync(String, CancellationToken)`
  * Method `SetPasswordAsync(Int32, String, CancellationToken)`
  * Method `SetPasswordFromNameAsync(String, String, CancellationToken)`
  * Method `SetUserPresenceStatusAsync(Int32, UserPresenceStatus, CancellationToken)`
  * Method `ValidateUserAsync(User, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.UserInfoImplementation is Modified

* Deleted items
  * Method `GetUserInfo(Int32)`
* New items
  * Method `UserInfoImplementation()`
  * Method `GetUserInfoAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.UserInfoListImplementation is Modified

* Deleted items
  * Method `GetUserInfoList(Int32[])`
* New items
  * Method `UserInfoListImplementation()`
  * Method `GetUserInfoListAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.VideoMeetingReservationImplementation is Modified

* Deleted items
  * Method `CreateVideoMeetingReservation()`
  * Method `DeleteVideoMeetingReservation(String)`
* New items
  * Method `VideoMeetingReservationImplementation()`
  * Method `CreateVideoMeetingReservationAsync(CancellationToken)`
  * Method `DeleteVideoMeetingReservationAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.WebAppUsageImplementation is Modified

* Deleted items
  * Method `AddWebAppUsage(WebAppUsage[])`
  * Method `GetWebAppUsagesForPeriod(DateTime, DateTime, String)`
  * Method `WebAppUsageExistsInPeriod(Int32, String, DateTime)`
* New items
  * Method `WebAppUsageImplementation()`
  * Method `AddWebAppUsageAsync(WebAppUsage[], CancellationToken)`
  * Method `GetWebAppUsagesForPeriodAsync(DateTime, DateTime, String, CancellationToken)`
  * Method `WebAppUsageExistsInPeriodAsync(Int32, String, DateTime, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.WebhookImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetAllWebhooks(String, String, WebhookState)`
  * Method `GetFromId(Int32)`
  * Method `GetLastError(Int32)`
  * Method `Save(Webhook)`
  * Method `SignalEvent(String, Int32, StringObjectDictionary)`
  * Method `TestWebhook(Webhook)`
* New items
  * Method `CreateDefaultWebhookAsync(CancellationToken)`
  * Method `DeleteWebhookAsync(Int32, CancellationToken)`
  * Method `GetAllWebhooksAsync(String, String, WebhookState, CancellationToken)`
  * Method `GetLastErrorAsync(Int32, CancellationToken)`
  * Method `GetWebhookAsync(Int32, CancellationToken)`
  * Method `SaveWebhookAsync(Webhook, CancellationToken)`
  * Method `SignalEventAsync(String, Int32, StringObjectDictionary, CancellationToken)`
  * Method `TestWebhookAsync(Webhook, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.WorkflowEventImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Run()`
  * Method `SendEvent(WorkflowEvent)`
* New items
  * Method `CreateDefaultWorkflowEventAsync(CancellationToken)`
  * Method `RunAsync(CancellationToken)`
  * Method `SendEventAsync(WorkflowEvent, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.WorkflowEventResultImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
* New items
  * Method `CreateDefaultWorkflowEventResultAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.WorkflowFilterImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
* New items
  * Method `CreateDefaultWorkflowFilterAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.WorkflowGoalImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `PopulateFromRow(WorkflowGoalRecordData)`
  * Method `Save(WorkflowGoal)`
* New items
  * Method `CreateDefaultWorkflowGoalAsync(CancellationToken)`
  * Method `DeleteWorkflowGoalAsync(Int32, CancellationToken)`
  * Method `GetWorkflowGoalAsync(Int32, CancellationToken)`
  * Method `SaveWorkflowGoalAsync(WorkflowGoal, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.WorkflowStepBaseImplementation is Modified

* Deleted items
  * Method `WorkflowStepBaseImplementation()`
  * Method `AddAfterWorkflowStep(Int32, WorkflowStepBase)`
  * Method `CreateDefaultWorkflowStepFromType(WorkflowStepType)`
  * Method `Delete(Int32)`
  * Method `GetRootSteps(Int32)`
  * Method `GetWorkflowStep(Int32, Int32, Int32)`
  * Method `PopulateFromRow(WorkflowStepRecordData, Int32, Int32)`
  * Method `Save(WorkflowStepBase)`
* New items
  * Method `WorkflowStepBaseImplementation(IWorkflowStepOptionBaseImplementation, IWorkflowUtil)`
  * Method `AddAfterWorkflowStepAsync(Int32, WorkflowStepBase, CancellationToken)`
  * Method `CreateDefaultWorkflowStepFromTypeAsync(WorkflowStepType, CancellationToken)`
  * Method `GetWorkflowStepAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.WorkflowStepOptionBaseImplementation is Modified

* Deleted items
  * Method `WorkflowStepOptionBaseImplementation()`
  * Method `CreateDefaultWorkflowStepOptionFromType(WorkflowSplitOptionType)`
  * Method `Delete(Int32, Boolean)`
  * Method `GetStepOptionType(Int32)`
  * Method `GetWorkflowStepOption(Int32)`
  * Method `PopulateFromRow(WorkflowStepOptionRecordData, WorkflowSplitOptionType, Int32)`
  * Method `Save(WorkflowStepOptionBase)`
* New items
  * Method `WorkflowStepOptionBaseImplementation(IWorkflowUtil)`
  * Method `CreateDefaultWorkflowStepOptionFromTypeAsync(WorkflowSplitOptionType, CancellationToken)`
  * Method `GetWorkflowStepOptionAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.WorkflowTriggerImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `PopulateFromRow(WorkflowTriggerRecordData)`
  * Method `Save(WorkflowTrigger)`
* New items
  * Method `CreateDefaultWorkflowTriggerAsync(CancellationToken)`
  * Method `DeleteWorkflowTriggerAsync(Int32, CancellationToken)`
  * Method `GetWorkflowTriggerAsync(Int32, CancellationToken)`
  * Method `SaveWorkflowTriggerAsync(WorkflowTrigger, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.WorkflowWaitForActionImplementation is Modified

* Deleted items
  * Method `WorkflowWaitForActionImplementation()`
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `GetFromId(Int32)`
  * Method `PopulateFromRow(WorkflowWaitForActionRecordData, Int32)`
  * Method `Save(WorkflowWaitForAction)`
* New items
  * Method `WorkflowWaitForActionImplementation(IWorkflowUtil)`
  * Method `CreateDefaultWorkflowWaitForActionAsync(CancellationToken)`
  * Method `DeleteWorkflowWaitForActionAsync(Int32, CancellationToken)`
  * Method `GetWorkflowWaitForActionAsync(Int32, CancellationToken)`
  * Method `SaveWorkflowWaitForActionAsync(WorkflowWaitForAction, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.CustomCommands.CustomCommandManager is Modified

* Deleted items
  * Method `ExecuteCommand<TPluginType, TEntity>(String, CommandActionResult, TEntity)`
  * Method `GetCommands<TPluginType, TEntity>(TEntity)`
* New items
  * Method `ExecuteCommandAsync<TPluginType, TEntity>(String, CommandActionResult, TEntity, CancellationToken)`
  * Method `GetCommandsAsync<TPluginType, TEntity>(TEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.CustomCommands.ICustomCommandPlugin<TEntity> is Modified

* Deleted items
  * Method `ExecuteCommand(String, CommandActionResult, TEntity)`
  * Method `GetCommands(TEntity)`
* New items
  * Method `ExecuteCommandAsync(String, CommandActionResult, TEntity, CancellationToken)`
  * Method `GetCommandsAsync(TEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.EMailAttachmentImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `GetEMailAttachment(MailAttachment)`
  * Method `GetEMailAttachment(MailAttachment, FileExtensionValidator)`
* New items
  * Method `CreateDefaultEMailAttachmentAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.LicenseImplementation is Modified

* Deleted items
  * Method `ActivateLicenseInfo(ExtendedLicenseInfo)`
  * Method `AddLicenseFromFile(String)`
  * Method `AssignThirdPartyLicenses(Int32, String, String[])`
  * Method `ChangeSerialNumber(String, String)`
  * Method `GetLicenseForAllOwnersFromDB()`
  * Method `GetLicenseFromDB(String)`
  * Method `GetLicenseFromFile(String)`
  * Method `GetLicenseFromLicenseServer(String)`
  * Method `GetLicenseStatusFromLicenseServer(String)`
  * Method `GetModuleLicenseFromDB(String, String)`
  * Method `GetModuleLicenseHistoryFromLicenseServer(ExtendedLicenseInfo, ExtendedModuleLicense)`
  * Method `GetSatelliteLicenses(Int32)`
  * Method `GetShopUrl(String)`
  * Method `GetThirdPartyLicenseAssignments(Int32, String)`
  * Method `GetUserAndInstallationLicenceStatus(Int32)`
  * Method `GetUserLicenses(Int32)`
  * Method `GetUserLicensesMDOList()`
  * Method `RemoveLicenseFromDB(String)`
  * Method `UnassignThirdPartyLicenses(Int32, String, String[])`
  * Method `ValidateLicenseInfo(ExtendedLicenseInfo)`
* New items
  * Method `LicenseImplementation(ILicenseManager)`
  * Method `ActivateLicenseInfoAsync(ExtendedLicenseInfo, CancellationToken)`
  * Method `AddLicenseFromFileAsync(String, CancellationToken)`
  * Method `AssignThirdPartyLicensesAsync(Int32, String, String[], CancellationToken)`
  * Method `ChangeSerialNumberAsync(String, String, CancellationToken)`
  * Method `GetCentralLicenseAsync(CancellationToken)`
  * Method `GetLicenseForAllOwnersFromDBAsync(CancellationToken)`
  * Method `GetLicenseFromDBAsync(String, CancellationToken)`
  * Method `GetLicenseFromFileAsync(String, CancellationToken)`
  * Method `GetLicenseFromLicenseServerAsync(String, CancellationToken)`
  * Method `GetLicenseStatusFromLicenseServerAsync(String, CancellationToken)`
  * Method `GetModuleLicenseFromDBAsync(String, String, CancellationToken)`
  * Method `GetModuleLicenseHistoryFromLicenseServerAsync(ExtendedLicenseInfo, ExtendedModuleLicense, CancellationToken)`
  * Method `GetSatelliteLicensesAsync(Int32, CancellationToken)`
  * Method `GetShopUrlAsync(String, CancellationToken)`
  * Method `GetThirdPartyLicenseAssignmentsAsync(Int32, String, CancellationToken)`
  * Method `GetUserAndInstallationLicenceStatusAsync(Int32, CancellationToken)`
  * Method `GetUserLicensesAsync(Int32, CancellationToken)`
  * Method `GetUserLicensesMDOListAsync(CancellationToken)`
  * Method `RemoveLicenseFromDBAsync(String, CancellationToken)`
  * Method `SaveCentralLicenseAsync(LicenseOwner[], CancellationToken)`
  * Method `UnassignThirdPartyLicensesAsync(Int32, String, String[], CancellationToken)`
  * Method `ValidateLicenseInfoAsync(ExtendedLicenseInfo, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.RoleConversionHelper is Modified

* Deleted items
  * Method `CreateDefault(SoRole)`
  * Method `DeleteRole(SoRole, Int32)`
  * Method `GetRole(SoRole)`
  * Method `UpdateFromRole(SoRole, RoleEntity)`
* Modified items
  * Method `GetDataRights(SoRole)`
* New items
  * Method `CreateDefaultAsync(SoRole, CancellationToken)`
  * Method `DeleteRoleAsync(SoRole, Int32, CancellationToken)`
  * Method `UpdateFromRoleAsync(SoRole, RoleEntity, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.RoleEntityImplementation is Modified

* Deleted items
  * Method `RoleEntityImplementation()`
  * Method `CreateDefault()`
  * Method `CreateDefaultRoleEntityFromType(RoleType)`
  * Method `DeleteRole(Int32, Int32)`
  * Method `FindRolesWithFunctionalRight(String)`
  * Method `FindRolesWithFunctionalRights(String[])`
  * Method `FindRolesWithoutFunctionalRights(String[])`
  * Method `GetAllFunctionalRights(RoleType)`
  * Method `GetAllRoles(RoleType)`
  * Method `GetDataRight(Int32, String, RoleRelationToOwner)`
  * Method `GetDataRights(Int32, String)`
  * Method `GetFromId(Int32)`
  * Method `GetFunctionalRights(Int32)`
  * Method `Save(RoleEntity)`
  * Method `SetDataRight(Int32, String, RoleRelationToOwner, String)`
  * Method `SetFunctionalRights(Int32, Int32[])`
* New items
  * Method `RoleEntityImplementation(IAssociateImplementation, IDiagnosticsAgent, ISelectableMDOListImplementation)`
  * Method `CreateDefaultRoleEntityAsync(CancellationToken)`
  * Method `CreateDefaultRoleEntityFromTypeAsync(RoleType, CancellationToken)`
  * Method `DeleteRoleAsync(Int32, Int32, CancellationToken)`
  * Method `FindRolesWithFunctionalRightAsync(String, CancellationToken)`
  * Method `FindRolesWithFunctionalRightsAsync(String[], CancellationToken)`
  * Method `FindRolesWithoutFunctionalRightsAsync(String[], CancellationToken)`
  * Method `GetAllFunctionalRightsAsync(RoleType, CancellationToken)`
  * Method `GetAllRolesAsync(RoleType, CancellationToken)`
  * Method `GetDataRightAsync(Int32, String, RoleRelationToOwner, CancellationToken)`
  * Method `GetDataRightsAsync(Int32, String, CancellationToken)`
  * Method `GetFunctionalRightsAsync(Int32, CancellationToken)`
  * Method `GetRoleAsync(SoRole, CancellationToken)`
  * Method `GetRoleEntityAsync(Int32, CancellationToken)`
  * Method `SaveRoleEntityAsync(RoleEntity, CancellationToken)`
  * Method `SetDataRightAsync(Int32, String, RoleRelationToOwner, String, CancellationToken)`
  * Method `SetFunctionalRightsAsync(Int32, Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.SelectionCategoryImplementation is Modified

* Deleted items
  * Method `GetSelectionCategory(Int32)`
* Modified items
  * Method `PopulateFromHDB(SearchCatRow)`
  * Method `PopulateFromHDB(SearchCatRows)`
* New items
  * Method `GetSelectionCategoryAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.TaskMenuImplementation is Modified

* Deleted items
  * Method `CreateDefault()`
  * Method `Delete(Int32)`
  * Method `DeleteAppTaskMenus()`
  * Method `GetAppTaskMenus()`
  * Method `GetFromId(Int32)`
  * Method `GetTaskMenuByProgId(String)`
  * Method `Save(TaskMenu)`
* New items
  * Method `CreateDefaultTaskMenuAsync(CancellationToken)`
  * Method `DeleteAppTaskMenusAsync(CancellationToken)`
  * Method `DeleteTaskMenuAsync(Int32, CancellationToken)`
  * Method `GetAppTaskMenusAsync(CancellationToken)`
  * Method `GetTaskMenuAsync(Int32, CancellationToken)`
  * Method `GetTaskMenuByProgIdAsync(String, CancellationToken)`
  * Method `SaveTaskMenuAsync(TaskMenu, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.UserConversionHelper is Modified

* Deleted items
  * Method `GetUser(SoUser)`
  * Method `HandleFieldRights(String, Carrier, SoUser, FieldInfo, Type, EFieldRight, Boolean)`
  * Method `UpdateFromUser(SoUser, User, Dictionary<String, String>)`
* New items
  * Method `UpdateFromUserAsync(SoUser, User, Dictionary<String, String>, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.UserGroupImplementation is Modified

* Deleted items
  * Method `CreateUserGroup()`
  * Method `DeleteUserGroup(Int32, Int32)`
  * Method `GetAllUserGroups(Boolean)`
  * Method `GetUserGroup(Int32)`
  * Method `SaveUserGroup(UserGroup)`
  * Method `ToRow(UserGroup)`
  * Method `ToUserGroup(UserGroupRow)`
* New items
  * Method `UserGroupImplementation()`
  * Method `CreateUserGroupAsync(CancellationToken)`
  * Method `DeleteUserGroupAsync(Int32, Int32, CancellationToken)`
  * Method `GetAllUserGroupsAsync(Boolean, CancellationToken)`
  * Method `GetUserGroupAsync(Int32, CancellationToken)`
  * Method `SaveUserGroupAsync(UserGroup, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.UserGroupListImplementation is Modified

* Deleted items
  * Method `GetUserGroupList(Int32[])`
  * Method `ToUserGroups(UserGroupRows)`
* New items
  * Method `UserGroupListImplementation()`
  * Method `GetUserGroupListAsync(Int32[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.Util.CarrierUtility is Modified

* Deleted items
  * Method `GetAssociate(AssociateRecordData)`
  * Method `GetAssociate(AssociateRow)`
  * Method `GetAssociateRow(Associate, AssociateRow)`
  * Method `SetCustomFieldsForCarrier<TCarrier, TRow>(TCarrier, TRow)`
  * Method `UpdateCompanyDomainRows(String[], CompanyDomainRows, Int32, Boolean)`
  * Method `UpdateDocumentLinkRowsForAppointment(Document[], Int32)`
  * Method `UpdateDocumentLinkRowsForPerson(Document[])`
  * Method `UpdateDocumentLinkRowsForSale(Document[], Int32)`
  * Method `UpdateEmailRows(EntityElement[], EmailRows, Boolean, EmailType)`
  * Method `UpdatePhoneRows(EntityElement[], PhoneRows, Int32, Boolean)`
  * Method `UpdateProjectMemberRows(ProjectMember[], ProjectMemberCollection, Boolean)`
  * Method `UpdateUrlRows(EntityElement[], URLRows, Boolean)`
  * Method `UpdateVisibleForRow(Appointment)`
* New items
  * Method `GetAssociateAsync(AssociateRecordData, CancellationToken)`
  * Method `GetAssociateAsync(AssociateRow, CancellationToken)`
  * Method `SetCustomFieldsForCarrierAsync<TCarrier, TRow>(TCarrier, TRow, CancellationToken)`
  * Method `UpdateCompanyDomainRowsAsync(String[], CompanyDomainRows, Int32, Boolean)`
  * Method `UpdateEmailRowsAsync(EntityElement[], EmailRows, Boolean, EmailType)`
  * Method `UpdatePhoneRowsAsync(EntityElement[], PhoneRows, Int32, Boolean)`
  * Method `UpdateProjectMemberRowsAsync(ProjectMember[], ProjectMemberCollection, Boolean, CancellationToken)`
  * Method `UpdateUrlRowsAsync(EntityElement[], URLRows, Boolean)`

#### SuperOffice.CRM.Services.Implementation.Util.ContactPersonMatcher is Modified

* Deleted items
  * Method `FindCandidates(String, String, Int32, Int32)`
  * Method `FindCandidatesFor(String, String, Int32, Int32)`
  * Method `FindCompanyByName(String)`
  * Method `FindPersonByEmailPermutations(Int32[], Int32[])`
  * Method `FindPersonByName(String, Boolean)`
  * Method `FindPersonByNameComponents(String, String)`
  * Method `GetAllPeopleForIDs(Int32[], Int32[])`
  * Method `GetPartialEmailDomainMatches(String)`
  * Method `GetPartialUrlDomainMatches(String)`
  * Method `IsMiddleNameEnabled()`
* New items
  * Method `FindCandidatesAsync(String, String, CancellationToken, Int32, Int32)`
  * Method `FindCandidatesForAsync(String, String, CancellationToken, Int32, Int32)`
  * Method `FindCompanyByNameAsync(String, CancellationToken)`
  * Method `FindPersonByEmailPermutationsAsync(Int32[], Int32[], CancellationToken)`
  * Method `FindPersonByNameAsync(String, CancellationToken, Boolean)`
  * Method `FindPersonByNameComponentsAsync(String, String, CancellationToken)`
  * Method `GetAllPeopleForIDsAsync(Int32[], Int32[], CancellationToken)`
  * Method `GetPartialEmailDomainMatchesAsync(String, CancellationToken)`
  * Method `GetPartialUrlDomainMatchesAsync(String, CancellationToken)`
  * Method `IsMiddleNameEnabledAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.Util.DayListBusyCalculator is Modified

* Deleted items
  * Method `GetBusyPercentageFor(DateTime)`
* New items
  * Method `GetBusyPercentageForAsync(DateTime, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.Util.DbContactPersonMatcher is Modified

* Deleted items
  * Method `FindCompanyByName(String)`
  * Method `FindPersonByNameComponents(String, String)`
  * Method `GetAllPeopleForIDs(Int32[], Int32[])`
  * Method `GetPartialEmailDomainMatches(String)`
  * Method `GetPartialUrlDomainMatches(String)`
  * Method `GetPeopleForContactIDs(Int32[])`
  * Method `GetPeopleForPersonIDs(Int32[])`
  * Method `IsMiddleNameEnabled()`
* New items
  * Method `FindCompanyByNameAsync(String, CancellationToken)`
  * Method `FindPersonByNameComponentsAsync(String, String, CancellationToken)`
  * Method `GetAllPeopleForIDsAsync(Int32[], Int32[], CancellationToken)`
  * Method `GetPartialEmailDomainMatchesAsync(String, CancellationToken)`
  * Method `GetPartialUrlDomainMatchesAsync(String, CancellationToken)`
  * Method `GetPeopleForContactIDsAsync(Int32[], CancellationToken)`
  * Method `GetPeopleForPersonIDsAsync(Int32[], CancellationToken)`
  * Method `IsMiddleNameEnabledAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.Util.HugoAIHelper is Modified

* Deleted items
  * Method `AnalyzeSentiment(String, String)`
  * Method `DetectLanguage(String)`
  * Method `GetChatbotPromptSuggestions(String, String, Int32)`
  * Method `GetChatbotTurn(String, ChatbotTurn[], String)`
  * Method `GetMLModelStatus()`
  * Method `GuessCategory(CategorizationRequestItem)`
  * Method `Summarize(IEnumerable<String>, Int32, String)`
  * Method `TrainMLModel(List<CategorizationTrainingItem>)`
  * Method `TranslateText(String, String)`
* New items
  * Method `AnalyzeSentimentAsync(String, String, CancellationToken)`
  * Method `DetectLanguageAsync(String, CancellationToken)`
  * Method `GetChatbotPromptSuggestionsAsync(String, String, Int32, CancellationToken)`
  * Method `GetChatbotTurnAsync(String, ChatbotTurn[], String, CancellationToken)`
  * Method `GetMLModelStatusAsync(CancellationToken)`
  * Method `GuessCategoryAsync(CategorizationRequestItem, CancellationToken)`
  * Method `SummarizeAsync(IEnumerable<String>, Int32, String, CancellationToken)`
  * Method `TrainMLModelAsync(List<CategorizationTrainingItem>, CancellationToken)`
  * Method `TranslateTextAsync(String, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.Util.IAllDayTimeProvider is Modified

* Deleted items
  * Method `GetAllDayEndTime()`
  * Method `GetAllDayStartTime()`
* New items
  * Method `GetAllDayEndTimeAsync(CancellationToken)`
  * Method `GetAllDayStartTimeAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.Util.NetServerPreferenceAllDayTimeProvider is Modified

* Deleted items
  * Method `GetAllDayEndTime()`
  * Method `GetAllDayStartTime()`
* New items
  * Method `GetAllDayEndTimeAsync(CancellationToken)`
  * Method `GetAllDayStartTimeAsync(CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.Util.PhoneList.PersonContactList is Modified

* Deleted items
  * Method `GetContactPhoneList(Int32)`
  * Method `GetGroupPersonCollection(Int32)`
* New items
  * Method `GetContactPhoneListAsync(Int32, CancellationToken)`
  * Method `GetGroupPersonCollectionAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.Util.PhoneList.PhoneListSearch is Modified

* Deleted items
  * Method `SearchPhoneList(String)`
* New items
  * Method `SearchPhoneListAsync(String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.Util.QuoteCarrierUtility is Modified

* Deleted items
  * Method `SetCarrierRights(Quote, QuoteManager)`
  * Method `SetCarrierRights(QuoteAlternative, QuoteManager)`
  * Method `SetCarrierRights(QuoteAlternative[], QuoteManager)`
  * Method `SetCarrierRights(QuoteEntity, QuoteManager)`
  * Method `SetCarrierRights(QuoteVersion, QuoteManager)`
  * Method `SetCarrierRights(QuoteVersion[], QuoteManager)`
* New items
  * Method `SetCarrierRights(Quote, IQuoteManager)`
  * Method `SetCarrierRightsAsync(QuoteAlternative, IQuoteManager)`
  * Method `SetCarrierRightsAsync(QuoteAlternative[], IQuoteManager)`
  * Method `SetCarrierRightsAsync(QuoteEntity, IQuoteManager)`
  * Method `SetCarrierRightsAsync(QuoteVersion, IQuoteManager)`
  * Method `SetCarrierRightsAsync(QuoteVersion[], IQuoteManager)`

#### SuperOffice.CRM.Services.Implementation.Util.Relation is Modified

* Deleted items
  * Method `AddContactRelation(Int32, Int32, Int32, String)`
  * Method `AddContactToPersonRelation(Int32, Int32, Int32, String)`
  * Method `AddPersonRelation(Int32, Int32, Int32, String)`
  * Method `AddPersonToContactRelation(Int32, Int32, Int32, String)`
* New items
  * Method `AddContactRelationAsync(Int32, Int32, Int32, String, CancellationToken)`
  * Method `AddContactToPersonRelationAsync(Int32, Int32, Int32, String, CancellationToken)`
  * Method `AddPersonRelationAsync(Int32, Int32, Int32, String, CancellationToken)`
  * Method `AddPersonToContactRelationAsync(Int32, Int32, Int32, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.Util.RFI is Modified

* Deleted items
  * Method `AddContact(String, Int32)`
  * Method `AddPerson(Int32, String, String, String, String)`
  * Method `AddRFI(Int32, String, String)`
  * Method `AddSalesLead(Int32, String, String, Int32, String, String, String)`
  * Method `FindContact(String, String)`
  * Method `FindContactPerson(String, String, String, String, String)`
* New items
  * Method `AddContactAsync(String, Int32, CancellationToken)`
  * Method `AddPersonAsync(Int32, String, String, String, String, CancellationToken)`
  * Method `AddRFIAsync(Int32, String, String, CancellationToken)`
  * Method `AddSalesLeadAsync(Int32, String, String, Int32, String, String, String, CancellationToken)`
  * Method `FindContactAsync(String, String, CancellationToken)`
  * Method `FindContactPersonAsync(String, String, String, String, String, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.Util.StatusMonitorHelper is Modified

* Deleted items
  * Method `GetActiveStatusMonitor(Int32, TableInfo)`
  * Method `GetActiveStatusMonitorId(Int32, TableInfo)`
  * Method `GetAnyActiveStatusMonitorId(Int32, TableInfo)`
  * Method `GetStatusMonitor(Int32)`
  * Method `GetStatusMonitors(Int32, TableInfo)`
  * Method `RegenerateStatusMonitor(Int32, ProgressCallback)`
  * Method `RegenerateStatusMonitors()`
  * Method `RegenerateStatusMonitors(ProgressCallback)`
  * Method `SaveStatusMonitor(StatusMonitor)`

##### SuperOffice.CRM.Services.Implementation.Util.StatusMonitorHelper.ProgressCallback is Deleted
* New items
  * Method `GetActiveStatusMonitorAsync(Int32, TableInfo, CancellationToken)`
  * Method `GetActiveStatusMonitorIdAsync(Int32, TableInfo, CancellationToken)`
  * Method `GetAnyActiveStatusMonitorIdAsync(Int32, TableInfo, CancellationToken)`
  * Method `GetStatusMonitorAsync(Int32, CancellationToken)`
  * Method `GetStatusMonitorsAsync(Int32, TableInfo, CancellationToken)`
  * Method `RegenerateStatusMonitorAsync(Int32, ProgressCallbackAsync, CancellationToken)`
  * Method `RegenerateStatusMonitorsAsync(ProgressCallbackAsync, CancellationToken)`
  * Method `RegenerateStatusMonitorsAsync(CancellationToken)`
  * Method `SaveStatusMonitorAsync(StatusMonitor, CancellationToken)`

##### SuperOffice.CRM.Services.Implementation.Util.StatusMonitorHelper.ProgressCallbackAsync is New

#### SuperOffice.CRM.Services.Implementation.Util.UserPreference is Modified

* Deleted items
  * Method `IsMiddleNameEnabled()`
  * Method `SetUserPreference(Int32, PreferenceLevel, String, String, String)`
* New items
  * Method `IsMiddleNameEnabledAsync(CancellationToken)`
  * Method `SetUserPreferenceAsync(Int32, PreferenceLevel, String, String, String, CancellationToken)`

#### SuperOffice.CRM.Services.SaleStakeholderExtensions is Modified

* Deleted items
  * Method `ToCarrier(SaleStakeholderRow)`
  * Method `ToCarrierArray(SaleStakeholderRows)`
  * Method `ToRow(SaleStakeholder)`
* New items
  * Method `ToCarrierArrayAsync(SaleStakeholderRows, CancellationToken)`
  * Method `ToCarrierAsync(SaleStakeholderRow, CancellationToken)`
  * Method `ToRowAsync(SaleStakeholder, CancellationToken)`

#### SuperOffice.ErpSync.ActorHelper is Modified

* Deleted items
  * Method `BreakActorLink(Int32, Int32, CrmActorType)`
  * Method `CreateActorLink(Int32, Int32, CrmActorType, String, ErpActorType)`
  * Method `CreateActorLink(Int32, Int32, Int32, String, ErpActorType)`
  * Method `GetCrmActorType(Int32, ErpActorType)`
  * Method `GetDefaultErpFieldsAndValues(Int32, ErpActorType, Dictionary<String, String>, ErpSyncActor&)`
  * Method `GetMappedErpActorTypes(Int32, CrmActorType[])`
* New items
  * Method `BreakActorLinkAsync(Int32, Int32, CrmActorType, CancellationToken)`
  * Method `CreateActorLinkAsync(Int32, Int32, CrmActorType, String, ErpActorType, CancellationToken)`
  * Method `CreateActorLinkAsync(Int32, Int32, Int32, String, ErpActorType, CancellationToken)`
  * Method `GetCrmActorTypeAsync(Int32, ErpActorType, CancellationToken)`
  * Method `GetDefaultErpFieldsAndValuesAsync(Int32, ErpActorType, Dictionary<String, String>, ErpSyncActor, CancellationToken)`
  * Method `GetMappedErpActorTypesAsync(Int32, CancellationToken, CrmActorType[])`

#### SuperOffice.ErpSync.ConnectionHandlerFacadeBase is Modified

* Deleted items
  * Property `ConnectionId`
  * Property `ErpConnectionId`
  * Method `CreateActor(ErpSyncActor, ErpActorType)`
  * Method `GetActors(ErpActorType, String[])`
  * Method `GetConfigData()`
  * Method `GetList(String)`
  * Method `GetListItems(String, String[])`
  * Method `GetSupportedActorTypeFields(ErpActorType)`
  * Method `GetSupportedActorTypes()`
  * Method `GetUpdatedActors()`
  * Method `SaveActors(ErpSyncActor[])`
  * Method `SaveActors(ErpSyncActor[], Boolean)`
  * Method `SaveActorTimestamp(ErpSyncActor)`
  * Method `SaveConnection(Dictionary<String, String>)`
  * Method `SaveConnectionTimestamp(ErpSyncActor)`
  * Method `SearchActorByParent(ErpActorType, String, ErpActorType, String)`
  * Method `SearchActors(ErpActorType, String)`
  * Method `SearchActors(ErpActorType, String, String[])`
  * Method `TestConnection()`
* New items
  * Method `CreateActorAsync(ErpSyncActor, ErpActorType)`
  * Method `GetActorsAsync(ErpActorType, String[])`
  * Method `GetConfigDataAsync()`
  * Method `GetConnectionIdAsync()`
  * Method `GetErpConnectionIdAsync()`
  * Method `GetListAsync(String)`
  * Method `GetListItemsAsync(String, String[])`
  * Method `GetSupportedActorTypeFieldsAsync(ErpActorType)`
  * Method `GetSupportedActorTypesAsync()`
  * Method `GetUpdatedActorsAsync()`
  * Method `SaveActorsAsync(ErpSyncActor[])`
  * Method `SaveActorsAsync(ErpSyncActor[], Boolean)`
  * Method `SaveActorTimestampAsync(ErpSyncActor, CancellationToken)`
  * Method `SaveConnectionAsync(Dictionary<String, String>)`
  * Method `SaveConnectionTimestampAsync(ErpSyncActor, CancellationToken)`
  * Method `SearchActorByParentAsync(ErpActorType, String, ErpActorType, String)`
  * Method `SearchActorsAsync(ErpActorType, String)`
  * Method `SearchActorsAsync(ErpActorType, String, String[])`
  * Method `SetConnectionIdAsync(Guid)`
  * Method `SetErpConnectionIdAsync(Int32)`
  * Method `TestConnectionAsync()`

#### SuperOffice.ErpSync.ContactFieldKeys is Modified

* Deleted items
  * Method `GetField(String)`
  * Method `GetFields()`
* New items
  * Method `GetFieldAsync(String, CancellationToken)`
  * Method `GetFieldsAsync(CancellationToken)`

#### SuperOffice.ErpSync.CrmConnectionHandlerFacade is Modified

* Deleted items
  * Property `ConnectionId`
  * Property `ErpConnectionId`
  * Method `CreateActor(ErpSyncActor, ErpActorType)`
  * Method `GetActor(Int32, Int32)`
  * Method `GetActors(ErpActorType, String[])`
  * Method `GetConfigData()`
  * Method `GetCrmActorTypeFromInternalKeyId(Int32)`
  * Method `GetInternalKey(Int32, Int32)`
  * Method `GetList(String)`
  * Method `GetListItems(String, String[])`
  * Method `GetSupportedActorTypeFields(ErpActorType)`
  * Method `GetSupportedActorTypes()`
  * Method `GetUpdatedActors()`
  * Method `OpenConnection()`
  * Method `SaveActors(ErpSyncActor[])`
  * Method `SaveActors(ErpSyncActor[], Boolean)`
  * Method `SaveActorTimestamp(ErpSyncActor)`
  * Method `SaveConnection(Dictionary<String, String>)`
  * Method `SaveConnectionTimestamp(ErpSyncActor)`
  * Method `SearchActorByParent(ErpActorType, String, ErpActorType, String)`
  * Method `SearchActors(ErpActorType, String)`
  * Method `SearchActors(ErpActorType, String, String[])`
  * Method `TestConnection()`
* New items
  * Method `CreateActorAsync(ErpSyncActor, ErpActorType)`
  * Method `GetActorAsync(Int32, Int32)`
  * Method `GetActorsAsync(ErpActorType, String[])`
  * Method `GetConfigDataAsync()`
  * Method `GetConnectionIdAsync()`
  * Method `GetCrmActorTypeFromInternalKeyIdAsync(Int32, CancellationToken)`
  * Method `GetErpConnectionIdAsync()`
  * Method `GetInternalKeyAsync(Int32, Int32, CancellationToken)`
  * Method `GetListAsync(String)`
  * Method `GetListItemsAsync(String, String[])`
  * Method `GetSupportedActorTypeFieldsAsync(ErpActorType)`
  * Method `GetSupportedActorTypesAsync()`
  * Method `GetUpdatedActorsAsync()`
  * Method `OpenConnectionAsync(CancellationToken)`
  * Method `SaveActorsAsync(ErpSyncActor[])`
  * Method `SaveActorsAsync(ErpSyncActor[], Boolean)`
  * Method `SaveActorTimestampAsync(ErpSyncActor, CancellationToken)`
  * Method `SaveConnectionAsync(Dictionary<String, String>)`
  * Method `SaveConnectionTimestampAsync(ErpSyncActor, CancellationToken)`
  * Method `SearchActorByParentAsync(ErpActorType, String, ErpActorType, String)`
  * Method `SearchActorsAsync(ErpActorType, String)`
  * Method `SearchActorsAsync(ErpActorType, String, String[])`
  * Method `SetConnectionIdAsync(Guid)`
  * Method `SetErpConnectionIdAsync(Int32)`
  * Method `TestConnectionAsync()`

#### SuperOffice.ErpSync.CrmFieldMdoProvider is Modified

* Deleted items
  * Method `AddItems()`
* New items
  * Method `AddItemsAsync(CancellationToken)`

#### SuperOffice.ErpSync.ErpConnectionHandlerFacade is Modified

* Deleted items
  * Property `ConnectionId`
  * Property `ErpConnectionId`
  * Property `FieldCache`
  * Method `CreateActor(ErpSyncActor, ErpActorType)`
  * Method `CreateConnection(Int32, Guid, Dictionary<String, String>)`
  * Method `DeleteConnection(Guid)`
  * Method `DeleteConnection(Int32)`
  * Method `GetActor(Guid, ErpActorType, String, String[])`
  * Method `GetActor(Int32, ErpActorType, String, String[])`
  * Method `GetActor(Int32, Int32, String[])`
  * Method `GetActors(ErpActorType, String[])`
  * Method `GetActors(ErpActorType, String[], String[])`
  * Method `GetActorsMapped(ErpActorType, String[])`
  * Method `GetConfigData()`
  * Method `GetConfigData(Int32)`
  * Method `GetConnectionId(Int32)`
  * Method `GetErpConnectionId(Guid)`
  * Method `GetExternalKeyRow(Int32)`
  * Method `GetExternalKeyRow(String, ErpActorType)`
  * Method `GetFieldsByInternalKeyId(Int32)`
  * Method `GetFieldsForActorType(ErpActorType)`
  * Method `GetList(Int32, String)`
  * Method `GetList(String)`
  * Method `GetListItemDisplayValue(Int32, String, String)`
  * Method `GetListItems(Int32, String, String[])`
  * Method `GetListItems(String, String[])`
  * Method `GetSearchableFields(ErpActorType)`
  * Method `GetSelectedErpFields(Boolean, ErpActorType)`
  * Method `GetSupportedActorTypeFields(ErpActorType)`
  * Method `GetSupportedActorTypes()`
  * Method `GetSupportedShowInSearchFields(ErpActorType)`
  * Method `GetUpdatedActors()`
  * Method `OpenConnection(Guid)`
  * Method `OpenConnection(Int32)`
  * Method `SaveActors(ErpSyncActor[])`
  * Method `SaveActorTimestamp(ErpSyncActor)`
  * Method `SaveConnection()`
  * Method `SaveConnection(Dictionary<String, String>)`
  * Method `SaveConnection(Int32, Guid, Dictionary<String, String>)`
  * Method `SaveConnectionTimestamp(ErpSyncActor)`
  * Method `SearchActorByParent(ErpActorType, String, ErpActorType, String)`
  * Method `SearchActorByParent(ErpActorType, String, ErpActorType, String, String[])`
  * Method `SearchActors(ErpActorType, ArchiveRestrictionInfo[], String[])`
  * Method `SearchActors(ErpActorType, String)`
  * Method `SearchActors(ErpActorType, String, String[])`
  * Method `SupportsAdvancedSearch(ErpActorType)`
  * Method `TestConfigData(Int32, Dictionary<String, String>)`
  * Method `TestConnection()`
  * Method `TestConnectorURL(String)`
  * Method `UpdateConnectionFields()`
* Modified items
  * Method `GetErpKey(Int32)`
  * Method `GetInternalKey(String, ErpActorType)`
* New items
  * Method `CreateActorAsync(ErpSyncActor, ErpActorType)`
  * Method `CreateConnectionAsync(Int32, Guid, Dictionary<String, String>)`
  * Method `DeleteConnectionAsync(Guid)`
  * Method `DeleteConnectionAsync(Int32)`
  * Method `GetActorAsync(Guid, ErpActorType, String, String[])`
  * Method `GetActorAsync(Int32, ErpActorType, String, String[])`
  * Method `GetActorAsync(Int32, Int32, String[])`
  * Method `GetActorsAsync(ErpActorType, String[])`
  * Method `GetActorsAsync(ErpActorType, String[], String[])`
  * Method `GetActorsMappedAsync(ErpActorType, String[])`
  * Method `GetConfigDataAsync()`
  * Method `GetConfigDataAsync(Int32, CancellationToken)`
  * Method `GetConnectionIdAsync()`
  * Method `GetConnectionIdAsync(Int32, CancellationToken)`
  * Method `GetErpConnectionIdAsync()`
  * Method `GetErpConnectionIdAsync(Guid, CancellationToken)`
  * Method `GetExternalKeyRowAsync(Int32)`
  * Method `GetExternalKeyRowAsync(String, ErpActorType)`
  * Method `GetFieldCacheAsync(CancellationToken)`
  * Method `GetFieldsByInternalKeyIdAsync(Int32)`
  * Method `GetFieldsForActorTypeAsync(ErpActorType, CancellationToken)`
  * Method `GetListAsync(Int32, String, CancellationToken)`
  * Method `GetListAsync(String)`
  * Method `GetListItemDisplayValueAsync(Int32, String, String)`
  * Method `GetListItemsAsync(Int32, String, String[], CancellationToken)`
  * Method `GetListItemsAsync(String, String[])`
  * Method `GetSearchableFieldsAsync(ErpActorType, CancellationToken)`
  * Method `GetSelectedErpFieldsAsync(Boolean, ErpActorType)`
  * Method `GetSupportedActorTypeFieldsAsync(ErpActorType)`
  * Method `GetSupportedActorTypesAsync()`
  * Method `GetSupportedShowInSearchFieldsAsync(ErpActorType, CancellationToken)`
  * Method `GetUpdatedActorsAsync()`
  * Method `OpenConnectionAsync(Guid, CancellationToken)`
  * Method `OpenConnectionAsync(Int32, CancellationToken)`
  * Method `SaveActorsAsync(ErpSyncActor[])`
  * Method `SaveActorTimestampAsync(ErpSyncActor, CancellationToken)`
  * Method `SaveConnectionAsync()`
  * Method `SaveConnectionAsync(Dictionary<String, String>)`
  * Method `SaveConnectionAsync(Int32, Guid, Dictionary<String, String>)`
  * Method `SaveConnectionTimestampAsync(ErpSyncActor, CancellationToken)`
  * Method `SearchActorByParentAsync(ErpActorType, String, ErpActorType, String)`
  * Method `SearchActorByParentAsync(ErpActorType, String, ErpActorType, String, String[])`
  * Method `SearchActorsAsync(ErpActorType, ArchiveRestrictionInfo[], String[])`
  * Method `SearchActorsAsync(ErpActorType, String)`
  * Method `SearchActorsAsync(ErpActorType, String, String[])`
  * Method `SetConnectionIdAsync(Guid)`
  * Method `SetErpConnectionIdAsync(Int32)`
  * Method `SupportsAdvancedSearchAsync(ErpActorType)`
  * Method `TestConfigDataAsync(Int32, Dictionary<String, String>, CancellationToken)`
  * Method `TestConnectionAsync()`
  * Method `TestConnectorURLAsync(String, CancellationToken)`
  * Method `UpdateConnectionFieldsAsync()`

#### SuperOffice.ErpSync.ErpConnectorClient is Modified

* Deleted items
  * Method `ErpConnectorClient(String, IConfiguration)`
* New items
  * Method `CreateAsync(String, IConfiguration, CancellationToken)`

#### SuperOffice.ErpSync.ErpFieldMdoProvider is Modified

* Deleted items
  * Method `AddItems()`
* New items
  * Method `AddItemsAsync(CancellationToken)`

#### SuperOffice.ErpSync.Field.ErpFieldCache is Modified

* Deleted items
  * Property `ActorTypeMap`
  * Property `ErpConnectionId`
  * Property `Fields`
  * Property `ListMap`
  * Method `ReloadFieldCache()`
* Modified items
  * Method `ErpFieldCache(Int32)`
* New items
  * Method `CreateAsync(Int32, CancellationToken)`
  * Method `GetActorTypeMapAsync(CancellationToken)`
  * Method `GetErpConnectionIdAsync(CancellationToken)`
  * Method `GetFieldsAsync(CancellationToken)`
  * Method `GetListMapAsync(CancellationToken)`
  * Method `ReloadFieldCacheAsync(CancellationToken)`
  * Method `SetActorTypeMapAsync(ErpConnectionActorTypeRows)`
  * Method `SetErpConnectionIdAsync(Int32)`

#### SuperOffice.ErpSync.FieldHelper is Modified

* Deleted items
  * Method `GetCrmFieldKeys(Int32, ErpActorType, String[])`
  * Method `GetImportColumnFromEisField(Int32, ErpActorType)`
  * Method `GetMatchingCrmFieldKey(ErpActorType, String)`
  * Method `UpdateErpFieldRowFromFieldMetadataInfo(FieldMetadataInfo, ErpFieldRow&)`
* New items
  * Method `GetCrmFieldKeysAsync(Int32, ErpActorType, String[], CancellationToken)`
  * Method `GetImportColumnFromEisFieldAsync(Int32, ErpActorType, CancellationToken)`
  * Method `GetMatchingCrmFieldKeyAsync(ErpActorType, String, CancellationToken)`
  * Method `UpdateErpFieldRowFromFieldMetadataInfoAsync(FieldMetadataInfo, ErpFieldRow)`

#### SuperOffice.ErpSync.FieldKeysBase is Modified

* Deleted items
  * Method `GetFields(CrmActorType)`
  * Method `InitFields()`
* Modified items
  * Property `Fields`
* New items
  * Method `GetFieldsAsync(CrmActorType, CancellationToken)`
  * Method `InitFieldsAsync(CancellationToken)`

#### SuperOffice.ErpSync.PersonFieldKeys is Modified

* Deleted items
  * Method `GetField(String)`
  * Method `GetFields()`
* New items
  * Method `GetFieldAsync(String, CancellationToken)`
  * Method `GetFieldsAsync(CancellationToken)`

#### SuperOffice.ErpSync.ProjectFieldKeys is Modified

* Deleted items
  * Method `GetField(String)`
  * Method `GetFields()`
* New items
  * Method `GetFieldAsync(String, CancellationToken)`
  * Method `GetFieldsAsync(CancellationToken)`

#### SuperOffice.ErpSync.SyncEngine is Modified

* Deleted items
  * Method `ForceResync(Int32, Int32[], Boolean)`
  * Method `RunSync(Boolean)`
  * Method `SyncErpActorsToCrm(Int32, ErpActorType, String[])`
* Modified items
  * Method `SyncEngine()`
  * Method `ForceResync(Int32, ErpActorType, String[], Boolean)`
* New items
  * Method `CreateAsync(CancellationToken)`
  * Method `ForceResyncAsync(Int32, Int32[], Boolean)`
  * Method `RunSyncAsync(Boolean)`
  * Method `SyncErpActorsToCrmAsync(Int32, ErpActorType, String[])`
