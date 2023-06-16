---
uid: table-PaymentTermsHeadingLink
title: PaymentTermsHeadingLink table
description: Heading link table for PaymentTerms, for MDO item headings
so.generated: true
keywords: database table PaymentTermsHeadingLink
so.topic: reference
so.envir: onsite, online
---

# PaymentTermsHeadingLink Table (429)

Heading link table for PaymentTerms, for MDO item headings

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|paymenttermsheadinglink\_id|Primary key|PK| |
|paymentterms\_id|Link to PaymentTerms list table|FK [PaymentTerms](paymentterms.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PaymentTermsHeadingLink table relationship diagram](./media/PaymentTermsHeadingLink.png)

[!include[details](./includes/paymenttermsheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|paymenttermsheadinglink\_id |PK |Clustered, Unique |
|paymentterms\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[PaymentTerms](paymentterms.md)  |The list of payment terms, in the internal product register |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

