---
uid: crmscript_ref_NSTriggerScriptEntity_GetScreenType
title: Integer GetScreenType()
intellisense: NSTriggerScriptEntity.GetScreenType
keywords: NSTriggerScriptEntity, GetScreenType
so.topic: reference
---

Event id that triggers script.  See EventHandlerType enum.

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 100 = NewTicket 
     - Enum: 101 = NewTicketFromCustomerCenter 
     - Enum: 102 = NewTicketFromEmail 
     - Enum: 103 = NewTicketFromCustomerCenterBeforeSave 
     - Enum: 104 = NewTicketFromSpmLink 
     - Enum: 105 = NewNotifyTicketFromForm 
     - Enum: 106 = NewTicketFromForm 
     - Enum: 109 = TicketSave 
     - Enum: 110 = TicketClosed 
     - Enum: 111 = TicketPostponed 
     - Enum: 112 = TicketDeleted 
     - Enum: 113 = TicketActivated 
     - Enum: 120 = TicketReopened 
     - Enum: 121 = TicketReopenedFromCustomerCenter 
     - Enum: 122 = TicketReopenedFromEmail 
     - Enum: 140 = TicketChangedPriority 
     - Enum: 141 = TicketChangedCategory 
     - Enum: 142 = TicketChangedOwnedBy 
     - Enum: 143 = TicketChangedPrimaryCustomer 
     - Enum: 144 = TicketChangedTicketStatus 
     - Enum: 145 = TicketChangedSlevel 
     - Enum: 150 = TicketMessageAdded 
     - Enum: 151 = TicketInternalMessageAdded 
     - Enum: 152 = TicketExternalMessageAdded 
     - Enum: 153 = TicketMessageSentimentCalculated 
     - Enum: 200 = CompactModeInjection 
     - Enum: 210 = CustomerCenterAuthentication 
     - Enum: 300 = ScheduledTaskFailed 
     - Enum: 301 = DbiTaskFailed 
     - Enum: 302 = CustomerSetSubscriptions 
     - Enum: 303 = ImportMailBeforeProcessing 
     - Enum: 304 = ImportMailAfterProcessing 
     - Enum: 305 = MainMenu 
     - Enum: 400 = ChatNewSession 
     - Enum: 401 = ChatSessionChangedStatus 
     - Enum: 402 = ChatBeforeSaveNewMessage 
     - Enum: 403 = ChatAfterSaveNewMessage 
     - Enum: 500 = ServiceScreenNewTicketLoad 
     - Enum: 501 = ServiceScreenNewQuickTicketLoad 
     - Enum: 502 = ServiceScreenListTicketMessagesLoad 
     - Enum: 503 = ServiceScreenAddMessageLoad 
     - Enum: 504 = ServiceScreenEditTicketLoad 
     - Enum: 505 = ServiceScreenViewCustomerLoad 
     - Enum: 506 = ServiceScreenEditCustomerLoad 
     - Enum: 507 = ServiceScreenViewCompanyLoad 
     - Enum: 508 = ServiceScreenEditCompanyLoad 
     - Enum: 509 = ServiceScreenForwardLoad 
     - Enum: 510 = ServiceScreenEditExtraTableLoad 
     - Enum: 600 = ServiceScreenNewTicketBeforeSubmit 
     - Enum: 601 = ServiceScreenNewQuickTicketBeforeSubmit 
     - Enum: 602 = ServiceScreenListTicketMessagesBeforeSubmit 
     - Enum: 603 = ServiceScreenAddMessageBeforeSubmit 
     - Enum: 604 = ServiceScreenEditTicketBeforeSubmit 
     - Enum: 605 = ServiceScreenViewCustomerBeforeSubmit 
     - Enum: 606 = ServiceScreenEditCustomerBeforeSubmit 
     - Enum: 607 = ServiceScreenViewCompanyBeforeSubmit 
     - Enum: 608 = ServiceScreenEditCompanyBeforeSubmit 
     - Enum: 609 = ServiceScreenForwardBeforeSubmit 
     - Enum: 610 = ServiceScreenEditExtraTableBeforeSubmit 
     - Enum: 700 = ServiceScreenNewTicketAfterSubmit 
     - Enum: 701 = ServiceScreenNewQuickTicketAfterSubmit 
     - Enum: 702 = ServiceScreenListTicketMessagesAfterSubmit 
     - Enum: 703 = ServiceScreenAddMessageAfterSubmit 
     - Enum: 704 = ServiceScreenEditTicketAfterSubmit 
     - Enum: 705 = ServiceScreenViewCustomerAfterSubmit 
     - Enum: 706 = ServiceScreenEditCustomerAfterSubmit 
     - Enum: 707 = ServiceScreenViewCompanyAfterSubmit 
     - Enum: 708 = ServiceScreenEditCompanyAfterSubmit 
     - Enum: 709 = ServiceScreenForwardAfterSubmit 
     - Enum: 710 = ServiceScreenEditExtraTableAfterSubmit 
     - Enum: 1001 = SalesBeforeSaveAppointment 
     - Enum: 1002 = SalesBeforeSaveStakeholder 
     - Enum: 1003 = SalesBeforeSaveQuote 
     - Enum: 1004 = SalesBeforeSaveDocument 
     - Enum: 1005 = SalesBeforeSaveContact 
     - Enum: 1006 = SalesBeforeSavePerson 
     - Enum: 1007 = SalesBeforeSaveRelation 
     - Enum: 1008 = SalesBeforeSaveSale 
     - Enum: 1009 = SalesBeforeSaveProject 
     - Enum: 1010 = SalesBeforeSaveSelection 
     - Enum: 1011 = SalesBeforeSaveProjectMember 
     - Enum: 1012 = SalesBeforeSaveSelectionMember 
     - Enum: 1013 = SalesBeforeSaveQuoteLine 
     - Enum: 1101 = SalesAfterSaveAppointment 
     - Enum: 1102 = SalesAfterSaveStakeholder 
     - Enum: 1103 = SalesAfterSaveQuote 
     - Enum: 1104 = SalesAfterSaveDocument 
     - Enum: 1105 = SalesAfterSaveContact 
     - Enum: 1106 = SalesAfterSavePerson 
     - Enum: 1107 = SalesAfterSaveRelation 
     - Enum: 1108 = SalesAfterSaveSale 
     - Enum: 1109 = SalesAfterSaveProject 
     - Enum: 1110 = SalesAfterSaveSelection 
     - Enum: 1111 = SalesAfterSaveProjectMember 
     - Enum: 1112 = SalesAfterSaveSelectionMember 
     - Enum: 1113 = SalesAfterSaveQuoteLine 

```crmscript
NSTriggerScriptEntity thing;
Integer screenType  = thing.GetScreenType();
```


