---
uid: enum-screenchoosertype
title: Enum values for ScreenChooserType
description: Lists the enum values for ScreenChooserType.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ScreenChooserType Enum



* None = 0
* System = 1
* ExtraTableEntry = 2
* ExtraTableAll = 3
* ExtraTableEdit = 4
* NewTicket = 100
* NewTicketFromCustomerCenter = 101
* NewTicketFromEmail = 102
* NewTicketFromCustomerCenterBeforeSave = 103
* TicketClosed = 110
* TicketPostponed = 111
* TicketDeleted = 112
* TicketActivated = 113
* TicketReopened = 120
* TicketReopenedFromCustomerCenter = 121
* TicketReopenedFromEmail = 122
* TicketChangedPriority = 140
* TicketChangedCategory = 141
* TicketChangedOwnedBy = 142
* TicketChangedPrimaryCustomer = 143
* TicketChangedTicketStatus = 144
* TicketChangedSlevel = 145
* TicketMessageAdded = 150
* TicketInternalMessageAdded = 151
* TicketExternalMessageAdded = 152
* CompactModeInjection = 200
* ScheduledTaskFailed = 300
* DbiTaskFailed = 301

## Usage

* [ticket_relation_action](../ticket-relation-action.md).event - Contains ticket relation actions, used to drive processing logic together with ticket relations
