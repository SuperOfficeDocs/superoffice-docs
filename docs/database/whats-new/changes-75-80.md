---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: changes_75_to_80       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Changes in SuperOffice from 7.5 to 8.0 # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Table changes from 7.5 to 8.0

## New tables

### Favourites

| Field | Type | Description |
|---|---|---|
| id | int | Primary key |
| table\_id | short | SuperOffice table reference |
| record\_id | int | Record in the referenced table |
| associate\_id |  int | The user who has marked this favorited |
| extra\_info\[255\] | nvarchar | Optional extra information |
| registered | DateTime | Registered datetime |
| registered\_by | int | Registered by whom |

## New fields on existing tables

### Traveltransactionlog

| Field | Type | Description |
|---|---|---|
| Flags | ushort | extra information about the operation, as a bit-masked enum |
| Application\_Id | | mainly online, used to track the execution context (who did this?) |

### UdListDefinition

| Field | Type | Description |
|---|---|---|
| RequiredLicense | string 255 | contains name(s) of license(s) needed for this list to become visible |

### PrefDesc

| Field | Type | Description |
|---|---|---|
| RequiredLicense | string 255 | contains name(s) of license(s) needed for this preference to become visible |

### SearchCriteria

| Field | Type | Description |
|---|---|---|
| DisplayName | string 255 | Display name when these criteria are a saved filter |

### Ticket

| Field | Type | Description |
|---|---|---|
| Ticket\_type | | supports new functionality for requests |

### Hierarchy

| Field | Type | Description |
|---|---|---|
| Registered date/associate | | |
| Updated date/associate | | |
| UpdatedCount | | |

### Element\_Profile

| Field | Type | Description |
|---|---|---|
| Filter\_Field | string 255 | supports new filtering functionality in Service product |
| Filter\_Value | string 255 | supports new filtering functionality in Service product |

### S\_Shipment

| Field | Type | Description |
|---|---|---|
| Selection\_id | | set if this shipment should be related to a selection |
| Project\_id | | set if this shipment should be related to a project |
| Generated\_Document\_id | | ID of the merged document that is the result of the shipment |
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
| Bounce\_Reason | string 1k | reason text received from mailing system |

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

* Ticket\_Type
* Ticket\_Relation\_Type
* Ticket\_Relation\_Action
* Ticket\_Relation

These tables support new functionality in Service, where you can define request types, relations between requests of certain types, and actions to be taken.
