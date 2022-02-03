---
uid: table-sale
title: sale table
description: Sales  For every Sale record edited through the SuperOffice GUI, a copy of the previous version of the record will be saved in the SaleHist table. This also applies to editing done through the SaleModel COM interface, but not to editing done through the OLE DB Provider or other channels.  
so.generated: true
keywords:
  - "database"
  - "sale"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# sale Table (13)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|sale\_id|Primary key|PK| |
|associate\_id|Owning associate|FK [associate](associate.md)| |
|group\_idx|Owner&apos;s group whn sale was created|FK [UserGroup](usergroup.md)| |
|contact\_id|Optional contact reference|FK [contact](contact.md)| |
|person\_id|Optional person reference|FK [person](person.md)|&#x25CF;|
|registered|Registered date|UtcDateTime|&#x25CF;|
|saledate|(expected / lost / won) sales date|DateTime| |
|amount|Total sale amount|Double|&#x25CF;|
|probability\_idx|Pointer to probability list value|FK [Prob](prob.md)| |
|appointment\_id|For future use|FK [appointment](appointment.md)| |
|text\_id|Optional long description|FK [text](text.md)|&#x25CF;|
|project\_id|Optional project reference|FK [project](project.md)| |
|earning|Earning on sale|Double|&#x25CF;|
|earning\_percent|Earning as percent of total|Double|&#x25CF;|
|userdef\_id|User-defined fields reference|FK [udsalesmall](udsalesmall.md)|&#x25CF;|
|userdef2\_id|User-defined fields reference|FK [udsalelarge](udsalelarge.md)|&#x25CF;|
|heading|Sale heading (short description?)|String(219)|&#x25CF;|
|credited\_id|Who is to be credited for the sale|FK [Credited](credited.md)|&#x25CF;|
|source\_id|Source of order|FK [Source](source.md)|&#x25CF;|
|reason\_id|Why we lost it|FK [Reason](reason.md)|&#x25CF;|
|comptr\_id|Competitor|FK [Comptr](comptr.md)|&#x25CF;|
|currency\_id|Currency of sale|FK [Currency](currency.md)|&#x25CF;|
|probability|Actual probability, may differ from the one in the list|UShort|&#x25CF;|
|status|Status: 1 = open, 2 = sold, 3 = lost, 4 = stalled|Enum [SaleStatus](enums/salestatus.md)|&#x25CF;|
|done|Done (0=don&apos;t know, 1 = No, 2=Yes)|Enum [SaleDone](enums/saledone.md)|&#x25CF;|
|number1|Alphanumeric user field|String(49)|&#x25CF;|
|visibility|Obsolete, but still maintained denormalization of visiblefor|UShort|&#x25CF;|
|source|For future integration use; source of record|UShort|&#x25CF;|
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|activeLinks|Number of active links to documents and such|UInt|&#x25CF;|
|saleType\_id|Link to list, sale type (big sale, small sale, no-process sale, ...)|FK [SaleType](saletype.md)|&#x25CF;|
|postitText\_id|Paperclip text|FK [text](text.md)|&#x25CF;|
|reasonStalled\_id|If the status is stalled, it should be commented here|FK [ReasonStalled](reasonstalled.md)|&#x25CF;|
|reopenDate|Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate.|DateTime|&#x25CF;|
|nextDueDate|Next due date, this is a denormalization of &apos;closest future activity date, or most recent if no future activities&apos;. Maintained by the system, but very convenient for searching.|DateTime|&#x25CF;|
|nddAppointment\_id|ID, can be 0, of the appointment that &quot;caused&quot; the nextDueDate|FK [appointment](appointment.md)|&#x25CF;|
|reasonSold\_id|Reason why we made the sale|FK [ReasonSold](reasonsold.md)|&#x25CF;|
|saleTypeCat\_id|Category of sale type, slaved from saletype|FK [SaleTypeCat](saletypecat.md)|&#x25CF;|
|activeErpLinks|The number of Erp Sync connections this record is synced with; count of the ErpExternalKey+ErpInternalKey relations|Int|&#x25CF;|


![sale table relationship diagram](./media/sale.png)

[!include[details](./includes/sale.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|sale\_id |PK |Clustered, Unique |
|contact\_id |FK |Index |
|person\_id |FK |Index |
|saledate |DateTime |Index |
|project\_id |FK |Index |
|userdef\_id |FK |Index |
|userdef2\_id |FK |Index |
|heading |String(219) |Index |
|status |Enum |Index |
|done |Enum |Index |
|number1 |String(49) |Index |
|source |UShort |Index |
|associate\_id, done, saledate |FK, Enum, DateTime |Index |
|contact\_id, saledate, associate\_id |FK, DateTime, FK |Index |
|project\_id, saledate, associate\_id |FK, DateTime, FK |Index |

## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.
* Cache table during filtering.

## Security Flags

* Sentry controls access to items in this table using user's Role and data rights matrix.
* Visibility controlled via matching [VisibleFor](VisibleFor.md) row.

