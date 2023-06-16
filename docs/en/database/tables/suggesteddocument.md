---
uid: table-SuggestedDocument
title: SuggestedDocument table
description: Unique owner of a set of licensed modules
so.generated: true
keywords: database table SuggestedDocument
so.topic: reference
so.envir: onsite, online
---

# SuggestedDocument Table (126)

Unique owner of a set of licensed modules

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|SuggestedDocument\_id|Primary key|PK| |
|name|Item name, visible in Guide|String(239)| |
|rank|Rank, controls rank of non-instantiated items in Guide|UShort|&#x25CF;|
|tooltip|Tooltip / description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|saleTypeStageLinkId|Link to saleTypeStageLink, the anchor for sale guide items. Either this OR projectAnchorId should be set, not both at the same time.|FK [SaleTypeStageLink](saletypestagelink.md)|&#x25CF;|
|projectTypeStatusLinkId|Link to projectTypeStatusLink, the anchor for project guide items. Either this OR saleAnchorId should be set, not both at the same time.|FK [ProjectTypeStatusLink](projecttypestatuslink.md)|&#x25CF;|
|doctmpl\_id|Type of the suggested document|FK [DocTmpl](doctmpl.md)|&#x25CF;|
|header|Suggested &apos;header&apos;|String(219)|&#x25CF;|
|our\_ref|Suggested &apos;our reference&apos;|String(99)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SuggestedDocument table relationship diagram](./media/SuggestedDocument.png)

[!include[details](./includes/suggesteddocument.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|SuggestedDocument\_id |PK |Clustered, Unique |
|name |String(239) |Index |
|saleTypeStageLinkId |FK |Index |
|projectTypeStatusLinkId |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[appointment](appointment.md)  |Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this.  |
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[DocTmpl](doctmpl.md)  |DocTmpl list table. Describes templates available for writing new documents. |
|[ProjectTypeStatusLink](projecttypestatuslink.md)  |Many-many link table between project type and status, similar to sale type-stage link; and an anchor point for guide items |
|[SaleTypeStageLink](saletypestagelink.md)  |Many-many link table between sale type and stage; and an anchor point for guide items |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

