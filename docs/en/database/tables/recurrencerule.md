---
uid: table-RecurrenceRule
title: RecurrenceRule table
description: The recurrency pattern for a recurring event. Each recurring event has an appointment.recurrenceRuleId pointing to its pattern.
so.generated: true
keywords: database table RecurrenceRule
so.topic: reference
so.envir: onsite, online
---

# RecurrenceRule Table (207)

The recurrency pattern for a recurring event. Each recurring event has an appointment.recurrenceRuleId pointing to its pattern.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|RecurrenceRule\_id|Primary key|PK| |
|pattern|Recurrence pattern (daily, weekly etc)|Enum [RecurrencePattern](enums/recurrencepattern.md)| |
|subPattern|Subpattern (workday, everyday, weekday etc)|Enum [RecurrenceSubPattern](enums/recurrencesubpattern.md)| |
|weekdays|Weekdays used, bitmask based on  ERecurrenceWeekDays enumeration|UShort| |
|startDate|Start date for repetition pattern|DateTime| |
|endDate|End date for repetition pattern|DateTime| |
|cyclicDay|Every nth day, in cyclic patterns|UShort| |
|cyclicWeek|Every nth week, in cyclic patterns|UShort| |
|cyclicMonth|Every nth month, in cyclic patterns|UShort| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![RecurrenceRule table relationship diagram](./media/RecurrenceRule.png)

[!include[details](./includes/recurrencerule.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|RecurrenceRule\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[appointment](appointment.md)  |Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this.  |
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

