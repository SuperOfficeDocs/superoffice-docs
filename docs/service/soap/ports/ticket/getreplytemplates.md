---
title: getReplyTemplates
uid: cs_soap_ports_ticket_getreplytemplates
description: Services SOAP interface ticket reference getReplyTemplates
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getReplyTemplates

## Description

Gets the id and name of all reply templates under a given folder. Useful for getting a list of reply templates in the system, which can be retrieved in full with the `getReplyTemplate` method.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| folderId | The id of the folder to retrieve reply templates from. -1 means retrieving all reply templates |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| replyTemplates | An array of *ReplyTemplateStruct*. Elements are listed below |
| description | The description of the given folder |
| name | The name of the given folder |

| ReplyTemplateStruct member | Description |
|---|---|
| id | ID of the reply template.|
| description | Description of the reply template |
| folder | Folder ID the reply template is in. |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0")
{
  ticket.ReplyTemplateStruct[] replyTemplates;
  ticketService.getReplyTemplates(sessionKey, -1);

  // assume this has been populated, see example for getReplyTemplateFolders
  TreeView tree;
  foreach(ticket.ReplyTemplateStruct rt in replyTemplates)
  {
    tree.addNode(rt.id, rt.description, rt.folder);
  }
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
