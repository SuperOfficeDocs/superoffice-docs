<!-- markdownlint-disable-file MD041 -->
Whenever a request is changed, we will create one entry in `ticket_log_action` (with the timestamp), and multiple entries in `ticket_log_change` (one entry for each value that has changed).

#### enum LogAction

**Ticket:**

| Name | Value |
|---|---|
| `LogAction_Ticket_Unknown` | 1 |
| `LogAction_Ticket_CustomDescription` | 2 |
| `LogAction_Ticket_Continue` | 3 |
| `LogAction_Ticket_ImportTicketFromEmail` | 4 |
| `LogAction_Ticket_ImportMailNewTicket` | 5 |
| `LogAction_Ticket_ImportMailExistingTicket` |6 |
| `LogAction_Ticket_AttachmentConnectedToTicket` |7 |
| `LogAction_Ticket_TicketActivated` | 8 |
| `LogAction_Ticket_TicketEscalated` | 9 |
| `LogAction_Ticket_ConnectTwoTickets` | 10 |
| `LogAction_Ticket_MessageAddedToTicket` | 11 |
| `LogAction_Ticket_SendingSpmMessage` | 12 |
| `LogAction_Ticket_SavedFromEjScript` | 13 |
| `LogAction_Ticket_TicketEscalatedFromEjScript` | 14 |
| `LogAction_Ticket_SetValuesFromSoap` | 15 |
| `LogAction_Ticket_AddMessageFromSoap` | 16 |
| `LogAction_Ticket_NewTicketFromSoap` | 17 |
| `LogAction_Ticket_AddMessage` | 18 |
| `LogAction_Ticket_NewTicket` | 19 |
| `LogAction_Ticket_UserTakesOwnership` |20 |
| `LogAction_Ticket_ChangeStatus` | 21 |
| `LogAction_Ticket_ChangeSecurityStatus` | 22 |
| `LogAction_Ticket_QuickSetExtraDateTime` | 23 |
| `LogAction_Ticket_QuickSetExtraDate` | 24 |
| `LogAction_Ticket_QuickSetExtraTime` | 25 |
| `LogAction_Ticket_QuickSetExtraField` | 26 |
| `LogAction_Ticket_SwapExtraField` | 27 |
| `LogAction_Ticket_ReadByUser` | 28 |
| `LogAction_Ticket_BatchOperation` | 29 |
| `LogAction_Ticket_BatchMarkAsRead` | 30 |
| `LogAction_Ticket_BatchMarkAsUnread` | 31 |
| `LogAction_Ticket_BatchCloseTicket` | 32 |
| `LogAction_Ticket_EditTicket` | 33 |
| `LogAction_Ticket_DeleteTicket` | 34 |
| `LogAction_Ticket_JoinTickets` | 35 |
| `LogAction_Ticket_EditMessage` | 36 |
| `LogAction_Ticket_CloseTicketAfterForward`| 37 |
| `LogAction_Ticket_CloseAfterMassMessage` | 38 |
| `LogAction_Ticket_CloseTicketFromSoap` | 39 |
| `LogAction_Ticket_ReadTicketFromSoap` | 40 |
| `LogAction_Ticket_UserDeletedOwnerChanged` | 41 |
| `LogAction_Ticket_NewTicketFromSpecialForm` | 42 |
| `LogAction_Ticket_TicketClosedByFAQ` | 43 |
| `LogAction_Ticket_NewTicketFromCustomer` | 44 |
| `LogAction_Ticket_AddMessageFromCustomer` | 45 |
| `LogAction_Ticket_ReadByCustomer` | 46 |
| `LogAction_Ticket_SetRepliedAtByMassMessage` | 47 |
| `LogAction_Ticket_TicketActivatedByBounce` | 48 |

**Message:**

| Name | Value |
|---|---|
| `LogAction_Message_Unknown` | 10001 |
| `LogAction_Message_CustomDescription` | 10002 |
| `LogAction_Message_Continue` | 10003 |
| `LogAction_Message_ImportTicketFromEmail` | 10004 |
| `LogAction_Message_ImportMailAddMessage` | 10005 |
| `LogAction_Message_AddedDebugInfo` | 10006 |
| `LogAction_Message_SendingReplyTemplate` | 10007 |
| `LogAction_Message_SendingSMS` | 10008 |
| `LogAction_Message_SendingSpmMessage` | 10009 |
| `LogAction_Message_SavedFromEjScript` | 10010 |
| `LogAction_Message_AddMessageFromSoap` | 10011 |
| `LogAction_Message_AddMessage` | 10012 |
| `LogAction_Message_NewTicket` | 10013 |
| `LogAction_Message_EditTicket` | 10014 |
| `LogAction_Message_EditMessage` | 10015 |
| `LogAction_Message_ForwardMessage` | 10016 |
| `LogAction_Message_AddMassMessage` | 10017 |
| `LogAction_Message_NewMessageFromSpecialForm` | 10018 |
| `LogAction_Message_TicketNotifyFAQ` | 10019 |
| `LogAction_Message_NewTicketFromCustomer` | 10020 |
| `LogAction_Message_AddMessageFromCustomer` | 10021 |
| `LogAction_Message_BounceMessage` | 10022 |
| `LogAction_Message_OutboxMessage` | 10023 |
| `LogAction_Message_EditMessageFromSoap` | 10024 |
| `LogAction_Message_InlineImagesConverted` | 10025 |
