---
uid: enum-screenchoosertype
title: Enum values for ScreenChooserType
description: Lists the enum values for ScreenChooserType.
so.generated: true
keywords:
  - "database"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ScreenChooserType Enum



| Name | Value | Description |
|------|-------|-------------|
|None | 0||
|System | 1||
|ExtraTableEntry | 2||
|ExtraTableAll | 3||
|ExtraTableEdit | 4||
|NewTicket | 100||
|NewTicketFromCustomerCenter | 101||
|NewTicketFromEmail | 102||
|NewTicketFromCustomerCenterBeforeSave | 103||
|NewTicketFromSpmLink | 104||
|NewNotifyTicketFromForm | 105||
|NewTicketFromForm | 106||
|TicketSave | 109||
|TicketClosed | 110||
|TicketPostponed | 111||
|TicketDeleted | 112||
|TicketActivated | 113||
|TicketReopened | 120||
|TicketReopenedFromCustomerCenter | 121||
|TicketReopenedFromEmail | 122||
|TicketChangedPriority | 140||
|TicketChangedCategory | 141||
|TicketChangedOwnedBy | 142||
|TicketChangedPrimaryCustomer | 143||
|TicketChangedTicketStatus | 144||
|TicketChangedSlevel | 145||
|TicketMessageAdded | 150||
|TicketInternalMessageAdded | 151||
|TicketExternalMessageAdded | 152||
|TicketMessageSentimentCalculated | 153||
|CompactModeInjection | 200|| // Add custom stuff to our CompactMode client
|CustomerCenterAuthentication | 210||
|ScheduledTaskFailed | 300||
|DbiTaskFailed | 301||
|CustomerSetSubscriptions | 302||
|ImportMailBeforeProcessing | 303||
|ImportMailAfterProcessing | 304||
|MainMenu | 305||
|ChatNewSession | 400||
|ChatSessionChangedStatus | 401||
|ChatBeforeSaveNewMessage | 402||
|ChatAfterSaveNewMessage | 403||
|ChatbotRegistered | 410||
|ChatbotNewSession | 411||
|ChatbotSessionChangedStatus | 412||
|ChatbotNewMessage | 413||
|ServiceScreenNewTicketLoad |            500||
|ServiceScreenNewQuickTicketLoad |       501||
|ServiceScreenListTicketMessagesLoad |   502||
|ServiceScreenAddMessageLoad |           503||
|ServiceScreenEditTicketLoad |           504||
|ServiceScreenViewCustomerLoad |         505||
|ServiceScreenEditCustomerLoad |         506||
|ServiceScreenViewCompanyLoad |          507||
|ServiceScreenEditCompanyLoad |          508||
|ServiceScreenForwardLoad |              509||
|ServiceScreenEditExtraTableLoad |       510||
|ServiceScreenNewTicketBeforeSubmit |    600|| // NOTE: These enums must be 100 above Load enums!
|ServiceScreenNewQuickTicketBeforeSubmit | 601||
|ServiceScreenListTicketMessagesBeforeSubmit | 602||
|ServiceScreenAddMessageBeforeSubmit |     603||
|ServiceScreenEditTicketBeforeSubmit |     604||
|ServiceScreenViewCustomerBeforeSubmit | 605||
|ServiceScreenEditCustomerBeforeSubmit | 606||
|ServiceScreenViewCompanyBeforeSubmit | 607||
|ServiceScreenEditCompanyBeforeSubmit | 608||
|ServiceScreenForwardBeforeSubmit | 609||
|ServiceScreenEditExtraTableBeforeSubmit | 610||
|ServiceScreenNewTicketAfterSubmit |     700|| // NOTE: These enums must be 200 above Load enums!
|ServiceScreenNewQuickTicketAfterSubmit | 701||
|ServiceScreenListTicketMessagesAfterSubmit | 702||
|ServiceScreenAddMessageAfterSubmit | 703||
|ServiceScreenEditTicketAfterSubmit | 704||
|ServiceScreenViewCustomerAfterSubmit | 705||
|ServiceScreenEditCustomerAfterSubmit | 706||
|ServiceScreenViewCompanyAfterSubmit | 707||
|ServiceScreenEditCompanyAfterSubmit | 708||
|ServiceScreenForwardAfterSubmit | 709||
|ServiceScreenEditExtraTableAfterSubmit | 710||
|SalesBeforeSaveAppointment |     1001||
|SalesBeforeSaveStakeholder |     1002||
|SalesBeforeSaveQuote |           1003||
|SalesBeforeSaveDocument |        1004||
|SalesBeforeSaveContact |         1005||
|SalesBeforeSavePerson |          1006||
|SalesBeforeSaveRelation |        1007||
|SalesBeforeSaveSale |            1008||
|SalesBeforeSaveProject |         1009||
|SalesBeforeSaveSelection |       1010||
|SalesBeforeSaveProjectMember |   1011||
|SalesBeforeSaveSelectionMember | 1012||
|SalesBeforeSaveQuoteLine |       1013||
|SalesBeforeSaveAcceptQuote |     1014||
|SalesBeforeSaveRejectQuote |     1015||
|SalesAfterSaveAppointment |      1101||
|SalesAfterSaveStakeholder |      1102||
|SalesAfterSaveQuote |            1103||
|SalesAfterSaveDocument |         1104||
|SalesAfterSaveContact |          1105||
|SalesAfterSavePerson |           1106||
|SalesAfterSaveRelation |         1107||
|SalesAfterSaveSale |             1108||
|SalesAfterSaveProject |          1109||
|SalesAfterSaveSelection |        1110||
|SalesAfterSaveProjectMember |    1111||
|SalesAfterSaveSelectionMember |  1112||
|SalesAfterSaveQuoteLine |        1113||
|SalesAfterSaveAcceptQuote |      1114||
|SalesAfterSaveRejectQuote |      1115||

## Usage

* [ticket_relation_action](../ticket-relation-action.md).event - Contains ticket relation actions, used to drive processing logic together with ticket relations
