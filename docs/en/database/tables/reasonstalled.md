---
uid: table-ReasonStalled
title: ReasonStalled table
description: Why was the sale marked as stalled
so.generated: true
keywords: database table ReasonStalled
so.topic: reference
so.envir: onsite, online
---

# ReasonStalled Table (154)

ReasonStalled MDO list item table.
Why was the sale marked as stalled

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ReasonStalled\_Id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ReasonStalled table relationship diagram](./media/ReasonStalled.png)

[!include[details](./includes/reasonstalled.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ReasonStalled\_Id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ReasonStalledGroupLink](reasonstalledgrouplink.md)  |Link table for ReasonStalled, for MDO item hiding |
|[ReasonStalledHeadingLink](reasonstalledheadinglink.md)  |Heading link table for ReasonStalled, for MDO headers |
|[sale](sale.md)  |Sales  For every Sale record edited through the SuperOffice GUI, a copy of the current version of the record will be saved in the SaleHist table. This also applies to editing done through the SaleModel COM interface, but not to editing done through the OLE DB Provider or other channels.   |
|[SaleHist](salehist.md)  |Mirror image of the Sale table, providing a full transaction history. Every time you edit a sale, the current record of the sale is also saved here.  |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

