---
uid: table-Comptr
title: Comptr table
description: Comptr list table. List of all possible competitors (sale).
so.generated: true
keywords: database table Comptr
so.topic: reference
so.envir: onsite, online
---

# Comptr Table (109)

Comptr MDO list item table.
Comptr list table. List of all possible competitors (sale).

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Comptr\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Comptr table relationship diagram](./media/Comptr.png)

[!include[details](./includes/comptr.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Comptr\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ComptrGroupLink](comptrgrouplink.md)  |User group link table for Comptr, for MDO item hiding |
|[ComptrHeadingLink](comptrheadinglink.md)  |Heading link table for Comptr, for MDO headers |
|[sale](sale.md)  |Sales  For every Sale record edited through the SuperOffice GUI, a copy of the current version of the record will be saved in the SaleHist table. This also applies to editing done through the SaleModel COM interface, but not to editing done through the OLE DB Provider or other channels.   |
|[SaleHist](salehist.md)  |Mirror image of the Sale table, providing a full transaction history. Every time you edit a sale, the current record of the sale is also saved here.  |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

