---
uid: salestakeholder
title: salestakeholder table
description: Stakeholders in the sale, very similar to project members
so.generated: true
keywords:
  - "database"
  - "salestakeholder"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# SaleStakeholder Table (121)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|salestakeholder\_id|Primary key|PK| |
|sale\_id|Parent sale|FK [sale](sale.md)|&#x25CF;|
|contact\_id|Contact ID of person or contact who is the sale stakeholder|FK [contact](contact.md)|&#x25CF;|
|person\_id|Person ID of person who is the sale stakeholder, or 0 if it&apos;s just a contact|FK [person](person.md)|&#x25CF;|
|rank|Rank in list|UShort|&#x25CF;|
|stakeholderrole\_id|Member type link|FK [StakeholderRole](StakeholderRole.md)|&#x25CF;|
|comment|Optional comment|String(2047)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SaleStakeholder table relationship diagram](media\SaleStakeholder.png)

[!include[details](./includes/SaleStakeholder.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|salestakeholder\_id |PK |Clustered, Unique |
|contact\_id |FK |Index |
|person\_id |FK |Index |

## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.
* Cache table during filtering.

## Security Flags

* Sentry controls access to items in this table using user's Role and data rights matrix on the table's parent.

