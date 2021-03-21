---
uid: enum-mailboxtype
title: Enum values for MailboxType
description: Lists the enum values for MailboxType.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# MailboxType Enum

Enum indicating the protocol to use (POP/IMAP).

* Unknown = 0
* Pop = 1
* Imap = 2
* Mapi = 3
* Facebook = 4
* Pops = 5
* Imaps = 6
* SmsPlugin = 7
* Mailgun = 8
* ImapOAuth = 9

## Usage

* [mail_in_filter](../mail-in-filter.md).server_type - This table contains entries for the mailboxes the eJournal system is fetching mail from (POP3 or IMAP).
