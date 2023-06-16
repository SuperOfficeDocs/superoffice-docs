---
uid: table-DeliveryTermsHeadingLink
title: DeliveryTermsHeadingLink table
description: Heading link table for DeliveryTerms, for MDO item headings
so.generated: true
keywords: database table DeliveryTermsHeadingLink
so.topic: reference
so.envir: onsite, online
---

# DeliveryTermsHeadingLink Table (435)

Heading link table for DeliveryTerms, for MDO item headings

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|deliverytermsheadinglink\_id|Primary key|PK| |
|deliveryterms\_id|Link to DeliveryTerms list table|FK [DeliveryTerms](deliveryterms.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![DeliveryTermsHeadingLink table relationship diagram](./media/DeliveryTermsHeadingLink.png)

[!include[details](./includes/deliverytermsheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|deliverytermsheadinglink\_id |PK |Clustered, Unique |
|deliveryterms\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[DeliveryTerms](deliveryterms.md)  |The list of Delivery terms, in the internal product register |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

