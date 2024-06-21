---
title: Request how-to
uid: request-howto
description: You can work with requests at multiple levels of NetServer and in CRMScript.
author: Bergfrid Skaara Dias
date: 05.30.2023
keywords: request, ticket, API
topic: howto
---

# Request how-to

## CRMScript

* [Create ticket][1]
* [Get ticket info][9]
* [Add a message][2]
* [Get message info][9]
* [Accept request][8]
* [Reply to customer][6]
* [Delegate a request][5]
* [Priority and escalation][11]
* [Split and merge tickets][10]
* [Samples][4]
* [Request logs][3]

## REST

* [RESTful ASP.NET WebAPI][16] - reference

## SOAP

* [Services 88 (WCF-based IIS application)][17] - reference

## A word of caution

### Edit message

For obvious reasons, you should not alter the text in a message after the fact.

However, you might need to edit some properties for bookkeeping or compliance. For example:

* Time spent (accumulates)
* Invoicing info
* Access level (internal/external)
* Attachments (removal might be required)

### Delete tickets

> [!WARNING]
> In general, we don't recommend deleting requests. It is usually preferable to add a comment and/or tag and mark it as closed.

Deleting a ticket will also delete all messages and attachments linked to it!

However, you may be required to delete a request to comply with your company's privacy policy. Proceed with caution! Use the same statements as for closing a ticket, just change the status code from 2 to 4.

## Resources

* [ticket database table][15]
* [ticket-priority database table][14]

<!-- Referenced links -->
[1]: crmscript/create.md
[2]: crmscript/add-message.md
[3]: crmscript/request-logs.md
[4]: crmscript/samples.md
[5]: crmscript/delegate.md
[6]: crmscript/reply.md
[8]: crmscript/accept.md
[9]: crmscript/get-ticket-info.md
[10]: crmscript/split-merge.md
[11]: crmscript/escalate.md
[14]: ../../database/tables/ticket-priority.md
[15]: ../../database/tables/ticket.md
[16]: ../../api/reference/restful/rest/ticket/index.md
[17]: ../../api/reference/soap/services88/ticket/index.md
