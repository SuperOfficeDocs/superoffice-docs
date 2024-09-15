---
uid: table-invoice_sum
title: invoice_sum table
description: This table is used temporarily when listing invoice statistics. It is used because we need to sort balances from both customers and companies.
so.generated: true
keywords: database table invoice_sum
so.topic: reference
so.envir: onsite, online
---

# invoice\_sum Table (266)

This table is used temporarily when listing invoice statistics. It is used because we need to sort balances from both customers and companies.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|login\_id|The id of the user using the table.|FK [login](login.md)| |
|name|The name of the entry.|String(255)|&#x25CF;|
|customer\_id|The reference of the customer entry this entry is connected to. NULL or -1 if not connected.|FK [person](person.md)| |
|company\_id|The reference of the company entry this entry is connected to. NULL or -1 if not connected.|FK [contact](contact.md)| |
|balance|The balance for the given customer or company.|Int|&#x25CF;|


![invoice_sum table relationship diagram](./media/invoice_sum.png)

[!include[details](./includes/invoice-sum.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|login\_id |FK |Index |
|customer\_id |FK |Index |
|company\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[contact](contact.md)  |Companies and Organizations.   This table features a special record containing information about the contact that owns the database.   |
|[login](login.md)  |This table contains entries for the user sessions.  |
|[person](person.md)  |Persons in a company or an organizations. All associates have a corresponding person record |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

