---
title: System templates
uid: system-templates
description: System reply templates
author: Bergfrid Dias
date: 05.31.2023
keywords: reply template, variable, parser, Service
topic: reference
---

# System templates

Not all parser variables are available in every context in SuperOffice Service. The following tables show which parser variables are available in which reply templates.

## Standard variable

The standard variables are Message, Company, Customer, Ticket, and Config.

| Template type              | [Customer][1],<br> [Company][2] | [User][3] | [Ticket][4] | Message | [Config][5] | Other |
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
| ticket.lastMessage | The last message on the request |
| custPassword | The un-encrypted version of the password only if this customer was generated at the same time as the "new customer" email was sent and encryption is turned on |
| from |  The sender email address |
| to | The recipient address |
| faq.question | The first message in the request that "publish" was called from |
| faq.answer | The last message in the request that "publish" was called from |

Some parser variables that exist will not be described. These are present only for backward compatibility.

<!-- Referenced links -->
[1]: learn/template-variables.md#customer
[2]: learn/template-variables.md#company
[3]: learn/template-variables.md#user
[4]: learn/template-variables.md#ticket
[5]: learn/template-variables.md#config

<!-- Referenced images -->
