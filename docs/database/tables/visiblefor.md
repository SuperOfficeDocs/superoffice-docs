---
uid: visiblefor
title: visiblefor table
description: Visible for rights, who may see this appointment/document, sale,  salehist or selection
so.generated: true
keywords:
  - "database"
  - "visiblefor"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# VisibleFor Table (196)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|VisibleFor\_id|Primary key|PK| |
|tableId|ID of table this right is valid for|TableNumber| |
|recordId|ID of row this right applies to|RecordId| |
|forAll|1 = visible to all, 0 = not visible to all|Id| |
|forGroupId|0 = not visible to any particular group, or ID of group|FK [UserGroup](UserGroup.md)| |
|forAssocId|0 = not visible to any particular associate, or ID of associate|FK [associate](associate.md)| |
|encryptedCheck|Encrypted checksum field, to prevent tampering|String(254)| |
|appointmentId|Shortcut: appointment id, if tableId = appointment; to give faster joins|FK [appointment](appointment.md)|&#x25CF;|
|saleId|Shortcut: sale id, if tableId = sale to give faster joins|FK [sale](sale.md)|&#x25CF;|
|saleHistId|Shortcut: salehist id, if tableId = salehist to give faster joins|FK [SaleHist](SaleHist.md)|&#x25CF;|
|selectionId|Shortcut: selection id, if tableId = selection to give faster joins|FK [selection](selection.md)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![VisibleFor table relationship diagram](media\VisibleFor.png)

[!include[details](./includes/VisibleFor.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|VisibleFor\_id |PK |Clustered, Unique |
|appointmentId |FK |Index |
|saleId |FK |Index |
|saleHistId |FK |Index |
|selectionId |FK |Index |
|recordId, tableId |RecordId, TableNumber |Index |
|tableId, recordId, forAll, forGroupId, forAssocId |TableNumber, RecordId, Id, FK, FK |Index |

## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

