---
title: Table changes from 7.5 to 8.0
uid: changes_75_to_80
description: Changes in SuperOffice from 7.5 to 8.0
author: {github-id}
keywords: database
topic: reference
envir: onsite
version: 8.0
# client:
---

# Table changes from 7.5 to 8.0

## New tables

### Favorites

| Field | Type | Description |
|---|---|---|
| `id` | int | Primary key |
| `table_id` | short | SuperOffice table reference |
| `record_id` | int | Record in the referenced table |
| `associate_id` |  int | The user who has marked this favorited |
| `extra_info[255]` | nvarchar | Optional extra information |
| `registered` | DateTime | Registered datetime |
| `registered_by` | int | Registered by whom |

## New fields on existing tables

### Traveltransactionlog

| Field | Type | Description |
|---|---|---|
| `Flags` | ushort | extra information about the operation, as a bit-masked enum |
| `Application_Id` | | mainly online, used to track the execution context (who did this?) |

### UdListDefinition

| Field | Type | Description |
|---|---|---|
| `RequiredLicense` | string 255 | contains names of licenses needed for this list to become visible |

### PrefDesc

| Field | Type | Description |
|---|---|---|
| `RequiredLicense` | string 255 | contains names of licenses needed for this preference to become visible |

### SearchCriteria

| Field | Type | Description |
|---|---|---|
| `DisplayName` | string 255 | Display name when these criteria are a saved filter |

### Ticket

| Field | Type | Description |
|---|---|---|
| `Ticket_type` | | supports new functionality for requests |

### Hierarchy

| Field | Type | Description |
|---|---|---|
| Registered date/associate | | |
| Updated date/associate | | |
| UpdatedCount | | |

### Element\_Profile

| Field | Type | Description |
|---|---|---|
| `Filter_Field` | string 255 | supports new filtering functionality in Service product |
| `Filter_Value` | string 255 | supports new filtering functionality in Service product |

### S\_Shipment

| Field | Type | Description |
|---|---|---|
| `selection_id` | | set if this shipment should be related to a selection |
| `project_id` | | set if this shipment should be related to a project |
| `generated_document_id` | | ID of the merged document that is the result of the shipment |
| Registered date/associate | | |
| Updated date/associate | | |
| UpdatedCount | | |

### S\_Message

| Field | Type | Description |
|---|---|---|
| Registered date/associate | | |
| Updated date/associate | | |
| UpdatedCount | | |

### S\_Link

| Field | Type | Description |
|---|---|---|
| Registered date/associate | | |
| Updated date/associate | | |
| UpdatedCount | | |

### S\_Picture\_Folder

| Field | Type | Description |
|---|---|---|
| Registered date/associate | | |
| Updated date/associate | | |
| UpdatedCount | | |

### S\_Picture\_Entry

| Field | Type | Description |
|---|---|---|
| Registered date/associate | | |
| Updated date/associate | | |
| UpdatedCount | | |

### S\_Shipment\_Addr

| Field | Type | Description |
|---|---|---|
| `Bounce_Reason` | string 1k | reason text received from mailing system |

### ResourceOverride

| Field | Type | Description |
|---|---|---|
| Registered date/associate | | |
| Updated date/associate | | |
| UpdatedCount | | |

## Fields on existing tables with increased length

### QuoteVersion

* Description and Reason now have 2k characters each
* ExtraField1 - 5 now have 1k characters each

### QuoteAlternative

* Description and Reason now have 2k characters each
* ExtraField1 - 5 now have 1k characters each

### QuoteLineFa

* ExtraField1 - 5 now have 1k characters each

### Product

* Description now has 2k characters
* ExtraField1 - 5 now have 1k characters each

### Mail\_In\_Uidl

* uidl is now 2k characters

## Tables that support new functionality in Service

* `Ticket_Type`
* `Ticket_Relation_Type`
* `Ticket_Relation_Action`
* `Ticket_Relation`

These tables support new functionality in Service, where you can define request types, relations between requests of certain types, and actions to be taken.
