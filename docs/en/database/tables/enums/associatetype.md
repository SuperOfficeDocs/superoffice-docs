---
uid: enum-associatetype
title: Enum values for AssociateType
description: Lists the enum values for AssociateType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# AssociateType Enum

Associate type

| Name | Value | Description |
|------|-------|-------------|
|NoPersonBit|1|Associates with this bit is not associated with any person. Disregard the PersonId for associates with this bit set|
|AnonymousBit|2|Associates of this type is not authenticated for SuperOffice|
|NoCalenderBit|4|Associates with this bit do not have a calendar|
|NoSentryBit|8|Associates with this bit has full access rights, and the Sentry mechanism is bypassed|
|Employee|0|User / Employee|
|Resource|1|Resource like meeting room and projector|
|ExternalPerson|4|Person not working for the company taking part in Collaborative CRM (eCRM)|
|System|13|Application with full access rights (EAI)|
|Anonymous|7|Unknown party accessing the system (e.g. prospecting, eCRM)|

## Usage

* [associate](../associate.md).type - Employees, resources and other users - except for External persons
* [AssociateHistory](../associatehistory.md).type - Historical information about associates that have been deleted. Most references are NOT declared as foreign keys; this is a historical table that should not be updated when further changes occur in the database
