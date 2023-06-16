---
uid: enum-mailboxtype
title: Enum values for MailboxType
description: Lists the enum values for MailboxType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# MailboxType Enum

Enum indicating the protocol to use (POP/IMAP).

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown|
|Pop|1|Pop|
|Imap|2|Imap - without OAuth support. Use ImapOAuth instead if OAuth is needed|
|Mapi|3|Mapi - Obsolete|
|Facebook|4|TypeFacebook|
|Pops|5|Pop SSL|
|Imaps|6|Imap SSL|
|SmsPlugin|7|Incoming SMS, using a plugin|
|Mailgun|8|Used by mailboxes set up as a Mailgun route|
|ImapOAuth|9|This is a Imap mailbox using OAuth authentication|

## Usage

* [mail_in_filter](../mail-in-filter.md).server_type - This table contains entries for the mailboxes the eJournal system is fetching mail from (POP3 or IMAP).
