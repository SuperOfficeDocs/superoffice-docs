---
uid: enum-ticketlogaction
title: Enum values for TicketLogAction
description: Lists the enum values for TicketLogAction.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TicketLogAction Enum

An enum indicating what kind of log-entry this is.

| Name | Value | Description |
|------|-------|-------------|
|No_Logging|0|No_Logging|
|Ticket_Unknown|1|Ticket_Unknown action|
|Ticket_CustomDescription|2|Ticket_CustomDescription action|
|Ticket_ImportTicketFromEmail|4|Ticket_ImportTicketFromEmail action|
|Ticket_ImportMailNewTicket|5|Ticket_ImportMailNewTicket action|
|Ticket_ImportMailExistingTicket|6|Ticket_ImportMailExistingTicket action|
|Ticket_AttachmentConnectedToTicket|7|Ticket_AttachmentConnectedToTicket action|
|Ticket_TicketActivated|8|Ticket_TicketActivated action|
|Ticket_TicketEscalated|9|Ticket_TicketEscalated action|
|Ticket_ConnectTwoTickets|10|Ticket_ConnectTwoTickets action|
|Ticket_MessageAddedToTicket|11|Ticket_MessageAddedToTicket action|
|Ticket_SendingSpmMessage|12|Ticket_SendingSpmMessage action|
|Ticket_SavedFromEjScript|13|Ticket_SavedFromEjScript action|
|Ticket_TicketEscalatedFromEjScript|14|Ticket_TicketEscalatedFromEjScript action|
|Ticket_SetValuesFromSoap|15|Ticket_SetValuesFromSoap action|
|Ticket_AddMessageFromSoap|16|Ticket_AddMessageFromSoap action|
|Ticket_NewTicketFromSoap|17|Ticket_NewTicketFromSoap action|
|Ticket_AddMessage|18|Ticket_AddMessage action|
|Ticket_NewTicket|19|Ticket_NewTicket action|
|Ticket_UserTakesOwnership|20|Ticket_UserTakesOwnership action|
|Ticket_ChangeStatus|21|Ticket_ChangeStatus action|
|Ticket_ChangeSecurityStatus|22|Ticket_ChangeSecurityStatus action|
|Ticket_QuickSetExtraDateTime|23|Ticket_QuickSetExtraDateTime action|
|Ticket_QuickSetExtraDate|24|Ticket_QuickSetExtraDate action|
|Ticket_QuickSetExtraTime|25|Ticket_QuickSetExtraTime action|
|Ticket_QuickSetExtraField|26|Ticket_QuickSetExtraField action|
|Ticket_SwapExtraField|27|Ticket_SwapExtraField action|
|Ticket_ReadByUser|28|Ticket_ReadByUser action|
|Ticket_BatchOperation|29|Ticket_BatchOperation action|
|Ticket_BatchMarkAsRead|30|Ticket_BatchMarkAsRead action|
|Ticket_BatchMarkAsUnread|31|Ticket_BatchMarkAsUnread action|
|Ticket_BatchCloseTicket|32|Ticket_BatchCloseTicket action|
|Ticket_EditTicket|33|Ticket_EditTicket action|
|Ticket_DeleteTicket|34|Ticket_DeleteTicket action|
|Ticket_JoinTickets|35|Ticket_JoinTickets action|
|Ticket_EditMessage|36|Ticket_EditMessage action|
|Ticket_CloseTicketAfterForward|37|Ticket_CloseTicketAfterForward action|
|Ticket_CloseAfterMassMessage|38|Ticket_CloseAfterMassMessage action|
|Ticket_CloseTicketFromSoap|39|Ticket_CloseTicketFromSoap action|
|Ticket_ReadTicketFromSoap|40|Ticket_ReadTicketFromSoap action|
|Ticket_UserDeletedOwneraction|41|Ticket_UserDeletedOwneraction action|
|Ticket_NewTicketFromSpecialForm|42|Ticket_NewTicketFromSpecialForm action|
|Ticket_TicketClosedByFAQ|43|Ticket_TicketClosedByFAQ action|
|Ticket_NewTicketFromCustomer|44|Ticket_NewTicketFromCustomer action|
|Ticket_AddMessageFromCustomer|45|Ticket_AddMessageFromCustomer action|
|Ticket_ReadByCustomer|46|Ticket_ReadByCustomer action|
|Ticket_SetRepliedAtByMassMessage|47|Ticket_SetRepliedAtByMassMessage action|
|Ticket_TicketActivatedByBounce|48|Ticket_TicketActivatedByBounce action|
|Ticket_AutoCategorized|49|Ticket_AutoCategorized action|
|Message_Unknown|10001|Message_Unknown action|
|Message_CustomDescription|10002|Message_CustomDescription action|
|Message_Continue|10003|Message_Continue action|
|Message_ImportTicketFromEmail|10004|Message_ImportTicketFromEmail action|
|Message_ImportMailAddMessage|10005|Message_ImportMailAddMessage action|
|Message_AddedDebugInfo|10006|Message_AddedDebugInfo action|
|Message_SendingReplyTemplate|10007|Message_SendingReplyTemplate action|
|Message_SendingSMS|10008|Message_SendingSMS action|
|Message_SendingSpmMessage|10009|Message_SendingSpmMessage action|
|Message_SavedFromEjScript|10010|Message_SavedFromEjScript action|
|Message_AddMessageFromSoap|10011|Message_AddMessageFromSoap action|
|Message_AddMessage|10012|Message_AddMessage action|
|Message_NewTicket|10013|Message_NewTicket action|
|Message_EditTicket|10014|Message_EditTicket action|
|Message_EditMessage|10015|Message_EditMessage action|
|Message_ForwardMessage|10016|Message_ForwardMessage action|
|Message_AddMassMessage|10017|Message_AddMassMessage action|
|Message_NewMessageFromSpecialForm|10018|Message_NewMessageFromSpecialForm action|
|Message_TicketNotifyFAQ|10019|Message_TicketNotifyFAQ action|
|Message_NewTicketFromCustomer|10020|Message_NewTicketFromCustomer action|
|Message_AddMessageFromCustomer|10021|Message_AddMessageFromCustomer action|
|Message_BounceMessage|10022|Message_BounceMessage action|
|Message_OutboxMessage|10023|Message_OutboxMessage action|
|Message_EditMessageFromSoap|10024|Message_EditMessageFromSoap action|
|Message_InlineImagesConverted|10025|Message_InlineImagesConverted action|

## Usage

* [ticket_log_action](../ticket-log-action.md).log_action - This table contains actions for the tickets.
