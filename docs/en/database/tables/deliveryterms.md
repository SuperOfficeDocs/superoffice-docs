---
uid: table-DeliveryTerms
title: DeliveryTerms table
description: The list of Delivery terms, in the internal product register
so.generated: true
keywords: database table DeliveryTerms
so.topic: reference
so.envir: onsite, online
---

# DeliveryTerms Table (433)

DeliveryTerms MDO list item table.
The list of Delivery terms, in the internal product register

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|deliveryterms\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![DeliveryTerms table relationship diagram](./media/DeliveryTerms.png)

[!include[details](./includes/deliveryterms.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|deliveryterms\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[DeliveryTermsGroupLink](deliverytermsgrouplink.md)  |User group link table for DeliveryTerms, for MDO item hiding |
|[DeliveryTermsHeadingLink](deliverytermsheadinglink.md)  |Heading link table for DeliveryTerms, for MDO item headings |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

