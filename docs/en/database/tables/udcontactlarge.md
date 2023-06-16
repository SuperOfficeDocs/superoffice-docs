---
uid: table-udcontactLarge
title: udcontactLarge table
description: User-defined fields for contact (long strings)
so.generated: true
keywords: database table udcontactLarge
so.topic: reference
so.envir: onsite, online
---

# udcontactLarge Table (36)

User-defined fields for contact (long strings)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|udcontactLarge\_id|Primary key|PK| |
|string41|string value 41, indexed|String(199)|&#x25CF;|
|string42|string value 42,  indexed|String(199)|&#x25CF;|
|string43|string value 43, indexed|String(199)|&#x25CF;|
|string44|string value 44, indexed|String(199)|&#x25CF;|
|string45|string value 45, not indexed|String(199)|&#x25CF;|
|string46|string value 46, not indexed|String(199)|&#x25CF;|
|string47|string value 47, not indexed|String(199)|&#x25CF;|
|string48|string value 48, not indexed|String(199)|&#x25CF;|
|string49|string value 49, not indexed|String(199)|&#x25CF;|


![udcontactLarge table relationship diagram](./media/udcontactLarge.png)

[!include[details](./includes/udcontactlarge.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|udcontactLarge\_id |PK |Clustered, Unique |
|string41 |String(199) |Index |
|string42 |String(199) |Index |
|string43 |String(199) |Index |
|string44 |String(199) |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[contact](contact.md)  |Companies and Organizations.   This table features a special record containing information about the contact that owns the database.   |


## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* Sentry controls access to items in this table using user's Role and data rights matrix on the table's parent.

