---
uid: table-ms_filter_mail
title: ms_filter_mail table
description: This table connects mail filters (ms_filter) to mailboxes (mail_in_filter).
so.generated: true
keywords: database table ms_filter_mail
so.topic: reference
so.envir: onsite, online
---

# ms\_filter\_mail Table (311)

This table connects mail filters (ms_filter) to mailboxes (mail_in_filter).

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|mail\_sorter\_id|The reference to the mail filter entry.|FK [ms_filter](ms-filter.md)| |
|mail\_in\_filter\_id|The reference to the mailbox.|FK [mail_in_filter](mail-in-filter.md)| |


![ms_filter_mail table relationship diagram](./media/ms_filter_mail.png)

[!include[details](./includes/ms-filter-mail.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|mail\_sorter\_id |FK |Index |
|mail\_in\_filter\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[mail\_in\_filter](mail-in-filter.md)  |This table contains entries for the mailboxes the eJournal system is fetching mail from (POP3 or IMAP). |
|[ms\_filter](ms-filter.md)  |This table contains email filters. These are the filters allowing you to do advanced parsing of incomming emails. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

