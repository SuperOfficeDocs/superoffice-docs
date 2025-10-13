---
uid: cs-soap-ports-ticket-getreplytemplatefolders
title: getReplyTemplateFolders
description: Services SOAP interface ticket reference getReplyTemplateFolders
keywords: ticket port, getReplyTemplateFolders method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/ticket/getreplytemplatefolders
---

# getReplyTemplateFolders

## Description

Gets all reply template folders in the system.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| replyTemplateFolders | An array of *ReplyTemplateFolderStruct*. |

| ReplyTemplateFolderStruct member | Description |
|---|---|
| id | ID of the reply template folder.|
| description | Description of the reply template folder |
| name | Name of the reply template folder |
| parent | ID of the parent folder. |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0"))
{
  ticket.ReplyTemplateFolderStruct[] replyTemplateFolders;
  ticketService.getReplyTemplateFolders(sessionKey);
  TreeView tree;

  // assume addNode takes a node ID, a node description and a parent node ID
  tree.addNode(-1, "Reply template root node", -1);
  foreach(ticket.ReplyTemplateFolderStruct folder in replyTemplateFolders)
  {
    tree.addNode(folder.id, folder.name, folder.parent);
  }
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
