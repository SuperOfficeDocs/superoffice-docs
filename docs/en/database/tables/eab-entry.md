---
uid: table-eab_entry
title: eab_entry table
description: This table contains eab (email address book) entries, i.e. an alias (&amp;apos;Ola Hansen&amp;apos;) and an address (&amp;apos;ola@hansen.as&amp;apos;).
so.generated: true
keywords: database table eab_entry
so.topic: reference
so.envir: onsite, online
---

# eab\_entry Table (315)

This table contains eab (email address book) entries, i.e. an alias (&amp;apos;Ola Hansen&amp;apos;) and an address (&amp;apos;ola@hansen.as&amp;apos;).

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|folder\_id|The id of the folder in which this entry is located.|FK [eab_folder](eab-folder.md)| |
|name|The name of this email address|String(64)| |
|email\_address|The actual email address.|String(255)|&#x25CF;|
|sms\_number|The sms number for this person|String(255)|&#x25CF;|
|dbi\_agent\_id|Integration agent (eJournal)|FK [dbi_agent](dbi-agent.md)| |
|dbi\_key|The primary key for the integrated entry in the external datasource.|String(255)| |
|dbi\_last\_syncronized|Last external syncronization.|DateTime| |
|dbi\_last\_modified|When the entry was last modified.|DateTime| |
|dbi\_delete|This field is used for determin which entry to delete during a synchronization|Short|&#x25CF;|


![eab_entry table relationship diagram](./media/eab_entry.png)

[!include[details](./includes/eab-entry.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|folder\_id |FK |Index |
|name |String(64) |Index |
|dbi\_agent\_id |FK |Index |
|dbi\_key |String(255) |Index |
|dbi\_last\_syncronized |DateTime |Index |
|dbi\_last\_modified |DateTime |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[dbi\_agent](dbi-agent.md)  |DBI agent settings |
|[eab\_folder](eab-folder.md)  |This table contains eab (email address book) folders, used for containing email addresses. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

