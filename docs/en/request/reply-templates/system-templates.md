---
title: System templates
uid: system-templates
description: System reply templates
author: Bergfrid Dias
so.date: 03.16.2023
keywords: reply template
so.topic: reference
---

# System templates

Not all parser variables are available in every context in SuperOffice Service. The following tables show which parser variables are available in which reply templates.

## Standard variable

The standard variables are Message, Company, Customer, Ticket, and Config.

| Template type              | Customer,<br> Company | User | Ticket | Message | Config | Other |
|----------------------------|:---------:|:----:|:------:|:-------:|:------:|:-------------------|
| new request,<br> edit request,<br> add message |       | x       | x      |      | x     |     |
| autoreply                  | x         |      | x      |         |        |                    |
| email filter               | x         |      | x      |         | x      |                    |
| on incoming email          | x         |      | x      |         | x      | ticket.lastMessage |
| notify: new request        | x         |      | x      | x       | x      | ticket.lastMessage |
| notify: open requests      | x         |      | x      |         | x      | ticket.lastMessage |
| notify: new message        | x         |      | x      | x       | x      |                    |
| notify activated request,<br>escalated request,<br>re-assigned request | x | | x | | x |     |
| new customer contacts      | x<br> (customer only) |   |   |         |        | custPassword,<br> to,<br> from |
| send password<br> to customer contacts | x<br> (customer only) | | | | x     | to,<br> from      |
| format FAQ questions       | x         |      | x      |         |        | faq.question,<br> faq.answer |

## Other parser variables

| Variable | Description |
|---|---|
| ticket.lastMessage | the last message on the request |
| custPassword | the un-encrypted version of the password only if this customer was generated at the same time as the "new customer" email was sent and encryption is turned on |
| from |  the sender email address |
| to | the recipient address |
| faq.question | the first message in the request that "publish" was called from |
| faq.answer | the last message in the request that "publish" was called from |

Some parser variables that exist will not be described. These are present only for backward compatibility.
