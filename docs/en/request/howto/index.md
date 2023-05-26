---
title: Request how-to
uid: request-howto
description: You can work with requests at multiple levels of NetServer.
author: Bergfrid Skaara Dias
so.date: 05.26.2023
keywords: request, ticket, API
so.topic: howto
---

# Request how-to

## CRMScript

* [Tickets][1]
* [Messages][2]
* [Request logs][3]
* [Samples][4]

## REST

* [RESTful ASP.NET WebAPI][6] - reference

## SOAP

* [Services 88 (WCF-based IIS application)][7] - reference

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

* [ticket database table][5]

<!-- Referenced links -->
[1]: crmscript/tickets.md
[2]: crmscript/add-message.md
[3]: crmscript/request-logs.md
[4]: crmscript/samples.md
[5]: ../../database/tables/ticket.md
[6]: ../../api/reference/restful/rest/ticket/index.md
[7]: ../../api/reference/soap/services88/ticket/index.md
