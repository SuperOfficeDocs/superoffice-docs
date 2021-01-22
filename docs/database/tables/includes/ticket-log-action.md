
Whenever a request is changed, we will create one entry in ticket\_log\_action (with the timestamp), and multiple entries in ticket\_log\_change (one entry for each value that has changed).

#### enum LogAction

**Ticket:**

| Name | Value |
|---|---|
| LogAction\_Ticket\_Unknown |1 |
| LogAction\_Ticket\_CustomDescription |2 |
| LogAction\_Ticket\_Continue |3 |
| LogAction\_Ticket\_ImportTicketFromEmail |4 |
| LogAction\_Ticket\_ImportMailNewTicket |5 |
| LogAction\_Ticket\_ImportMailExistingTicket |6 |
| LogAction\_Ticket\_AttachmentConnectedToTicket |7 |
| LogAction\_Ticket\_TicketActivated |8 |
| LogAction\_Ticket\_TicketEscalated |9 |
| LogAction\_Ticket\_ConnectTwoTickets |10 |
| LogAction\_Ticket\_MessageAddedToTicket |11 |
| LogAction\_Ticket\_SendingSpmMessage |12 |
| LogAction\_Ticket\_SavedFromEjScript |13 |
| LogAction\_Ticket\_TicketEscalatedFromEjScript |14 |
| LogAction\_Ticket\_SetValuesFromSoap |15 |
| LogAction\_Ticket\_AddMessageFromSoap |16 |
| LogAction\_Ticket\_NewTicketFromSoap |17 |
| LogAction\_Ticket\_AddMessage |18 |
| LogAction\_Ticket\_NewTicket |19 |
| LogAction\_Ticket\_UserTakesOwnership |20 |
| LogAction\_Ticket\_ChangeStatus |21 |
| LogAction\_Ticket\_ChangeSecurityStatus |22 |
| LogAction\_Ticket\_QuickSetExtraDateTime |23 |
| LogAction\_Ticket\_QuickSetExtraDate |24 |
| LogAction\_Ticket\_QuickSetExtraTime |25 |
| LogAction\_Ticket\_QuickSetExtraField |26 |
| LogAction\_Ticket\_SwapExtraField |27 |
| LogAction\_Ticket\_ReadByUser |28 |
| LogAction\_Ticket\_BatchOperation |29 |
| LogAction\_Ticket\_BatchMarkAsRead |30 |
| LogAction\_Ticket\_BatchMarkAsUnread |31 |
| LogAction\_Ticket\_BatchCloseTicket |32 |
| LogAction\_Ticket\_EditTicket |            = 33 |
| LogAction\_Ticket\_DeleteTicket |34 |
| LogAction\_Ticket\_JoinTickets |35 |
| LogAction\_Ticket\_EditMessage |36 |
| LogAction\_Ticket\_CloseTicketAfterForward|     = 37 |
| LogAction\_Ticket\_CloseAfterMassMessage |38 |
| LogAction\_Ticket\_CloseTicketFromSoap |39 |
| LogAction\_Ticket\_ReadTicketFromSoap |40 |
| LogAction\_Ticket\_UserDeletedOwnerChanged |41 |
| LogAction\_Ticket\_NewTicketFromSpecialForm |42 |
| LogAction\_Ticket\_TicketClosedByFAQ |43 |
| LogAction\_Ticket\_NewTicketFromCustomer |44 |
| LogAction\_Ticket\_AddMessageFromCustomer |45 |
| LogAction\_Ticket\_ReadByCustomer |46 |
| LogAction\_Ticket\_SetRepliedAtByMassMessage |47 |
| LogAction\_Ticket\_TicketActivatedByBounce |48 |

**Message:**

| Name | Value |
|---|---|
| LogAction\_Message\_Unknown |10001 |
| LogAction\_Message\_CustomDescription |10002 |
| LogAction\_Message\_Continue |10003 |
| LogAction\_Message\_ImportTicketFromEmail |10004 |
| LogAction\_Message\_ImportMailAddMessage |10005 |
| LogAction\_Message\_AddedDebugInfo |10006 |
| LogAction\_Message\_SendingReplyTemplate |10007 |
| LogAction\_Message\_SendingSMS |10008 |
| LogAction\_Message\_SendingSpmMessage |10009 |
| LogAction\_Message\_SavedFromEjScript |10010 |
| LogAction\_Message\_AddMessageFromSoap |10011 |
| LogAction\_Message\_AddMessage |10012 |
| LogAction\_Message\_NewTicket |10013 |
| LogAction\_Message\_EditTicket |10014 |
| LogAction\_Message\_EditMessage |10015 |
| LogAction\_Message\_ForwardMessage |10016 |
| LogAction\_Message\_AddMassMessage |10017 |
| LogAction\_Message\_NewMessageFromSpecialForm |10018 |
| LogAction\_Message\_TicketNotifyFAQ |10019 |
| LogAction\_Message\_NewTicketFromCustomer |10020 |
| LogAction\_Message\_AddMessageFromCustomer |10021 |
| LogAction\_Message\_BounceMessage |10022 |
| LogAction\_Message\_OutboxMessage |10023 |
| LogAction\_Message\_EditMessageFromSoap |10024 |
| LogAction\_Message\_InlineImagesConverted |10025 |
