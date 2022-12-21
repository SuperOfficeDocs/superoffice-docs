---
title: System templates
uid: system_templates
description: System reply templates
author: {github-id}
keywords:
so.topic: reference
---

# System templates

The following table shows which parser variables are available in which reply templates. The standard variables are Message, Company, Customer, Ticket, and Config. Other variables are explained below the main table.

| Template | Message | Company | Customer | Ticket | Config | Other |
|---|:-:|:-:|:-:|:-:|:-:|---|
| notification of open requests | | x | x | x | x | ticket.lastMessage |
| notification of new message | x | x | x | x | x | |
| notification of activated request | | x | x | x | x | |
| notification of escalated request | | x | x | x | x | |
| new request notification | x | x | x | x | x | ticket.lastMessage |
| request reassignment | | x | x | x | x | |
| notifying a new message in the hotlist | x | x | x | x | x | |
| notifying an activated request in the hotlist | | x | x | x | x | |
| escalated request in the hotlist | | x | x | x | x | |
| notifying reassignment of a request in the hotlist | | x | x | x | x | |
| new customer contacts | | | x | | x | custPassword<br>from<br>to |
| autoreply | | x | x | x | x | |
| sending password to customer contacts | | | x | | x | from<br>to |
| formatting FAQ questions | | x | x  | x | | faq.question<br>faq.answer |

## Other parser variables

| Variable | Description |
|---|---|
| ticket.lastMessage | the last message on the request |
| custPassword | the un-encrypted version of the password only if this customer was generated at the same time as the "new customer" email was sent and encryption is turned on |
| from |  the sender email address |
| to | the recipient address |
| faq.question | the first message in the request that "publish" was called from |
| faq.answer | the last message in the request that "publish" was called from |
