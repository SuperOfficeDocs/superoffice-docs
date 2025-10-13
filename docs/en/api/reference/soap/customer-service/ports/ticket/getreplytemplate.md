---
uid: cs-soap-ports-ticket-getreplytemplate
title: getReplyTemplate
description: Services SOAP interface ticket reference getReplyTemplate
keywords: ticket port, getReplyTemplate method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/ticket/getreplytemplate
---

# getReplyTemplate

## Description

Gets data for a single reply template in a specified language.

## In parameters

| Parameter | Description |
|---|---|
| psessionKey | A valid session key |
| preplyTemplateId | The reply template ID |
| planguageId | The language ID to retrieve the reply template fields in |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| subject | The subject of the reply template |
| headers | Optional headers for the reply template |
| plainBody | Plaintext body of the reply template |
| htmlBody | HTML body of the reply template |
| hasPlainBody | If true the reply template is set to include the plaintext body |
| hasHtmlBody | If true the reply template is set to include the HTML body |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0"))
{
  getReplyTemplate(sessionKey, 19, 1, out subject, out headers, out plainBody, out htmlBody,  out hasPlainBody,  out hasHtmlBody);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
