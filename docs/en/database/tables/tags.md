---
uid: table-Tags
title: Tags table
description: MDO List of tags for Service entities
so.generated: true
keywords: database table Tags
so.topic: reference
so.envir: onsite, online
---

# Tags Table (459)

Tags MDO list item table.
MDO List of tags for Service entities

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|tags\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Tags table relationship diagram](./media/Tags.png)

[!include[details](./includes/tags.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|tags\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ms\_filter](ms-filter.md)  |This table contains email filters. These are the filters allowing you to do advanced parsing of incomming emails. |
|[TagsGroupLink](tagsgrouplink.md)  |User group link table for Tags, for MDO item hiding |
|[TagsHeadingLink](tagsheadinglink.md)  |Heading link table for Source, for MDO headers |
|[ticket](ticket.md)  |This table contains the tickets (requests) of the system. Its purpose should be evident. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

