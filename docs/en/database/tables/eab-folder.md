---
uid: table-eab_folder
title: eab_folder table
description: This table contains eab (email address book) folders, used for containing email addresses.
so.generated: true
keywords: database table eab_folder
so.topic: reference
so.envir: onsite, online
---

# eab\_folder Table (314)

This table contains eab (email address book) folders, used for containing email addresses.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|folder\_id|The id of the parent folder for this folder. NULL or -1 if this is a toplevel folder.|FK [eab_folder](eab-folder.md)| |
|name|The folder&amp;apos;s name.|String(64)| |
|description|The folder&amp;apos;s description.|String(255)|&#x25CF;|
|fullname|The full name of this category, i.e. Foo/bar/test.|Clob|&#x25CF;|


![eab_folder table relationship diagram](./media/eab_folder.png)

[!include[details](./includes/eab-folder.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|folder\_id |FK |Index |
|name |String(64) |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[eab\_entry](eab-entry.md)  |This table contains eab (email address book) entries, i.e. an alias (&amp;apos;Ola Hansen&amp;apos;) and an address (&amp;apos;ola@hansen.as&amp;apos;). |
|[eab\_folder](eab-folder.md)  |This table contains eab (email address book) folders, used for containing email addresses. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

