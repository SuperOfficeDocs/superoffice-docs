---
title: url_parameters
description: URL parameters
author:
so.date:
keywords:
so.topic:
---

# URL parameters

**URL parameters** let you control SuperOffice Service using simple HTTP commands. These commands are similar to a REST API. However, they return a full HTML user interface, not JSON or XML as REST would return.

For example, this URL will open a list of tickets for the current user:

`http://server/custsvc/ticket.exe?action=listTickets`

## URL structure

The 1st component is the **site address**, including customer ID and the *CS* sub-directory. For example: `https://sod.superoffice.com/CustXXXXX/CS/`

The 2nd component is the **endpoint**, specifying which program to run:

* blogic.exe
* customer.exe
* ticket.exe
* document.exe
* rms.exe
* stat.exe

3rd and last is the **query string**, specifying an action and possibly a list of parameters. Multiple parameters are separated with an ampersand `&`.

For example, `action=listTickets` or `action=doScript&id=123`.

## bLogic

| Action               | Parameters                                   |
|:---------------------|:---------------------------------------------|
| doScript             | id - The ID of the script<br>includeId - The include ID of the script |
| editScript           | Same as doScript                             |
| doScreenDefintion    | id - The ID of the screen<br>idString - the ID string of the screen   |
| editScreenDefinition | Same as doScreenDefintion                    |

> [!NOTE]
> You must set **exactly 1** parameter for blogic actions. For scripts, use either *id* or *includeId*. For screens, use *id* or *idString*. Don't supply both!

## Customer

| Action      | Parameters                                                               |
|:------------|:-------------------------------------------------------------------------|
| register    |                                                                          |
| newTicket   |                                                                          |
| listTicket  | ticketId                                                                 |
| listTickets | pageSize - The number of tickets per page                                |
| addMessage  | ticketId                                                                 |
| changeCust  |                                                                          |
| safeParse   | includeId - The ID string of the script<br>key - The authentication key |
| specialForm | template - The name of the template to use                               |

**Global parameters** common to all customer actions:

* custSessionKey
* noCookies
* templateFolder
* withFrame=1 or withFrame=0

> [!NOTE]
> The key must be the same as set in the script!

## Ticket

| Action               | Parameters                                     |
|:---------------------|:-----------------------------------------------|
| listTicket           | ticketId - The ticket to open                  |
| listTickets          |                                                |
| newTicket            | custId - The customer to connect the ticket to |
| editTicket           | ticketId - The ticket to edit                  |
| listTicketLog2       | ticketId                                       |
| doScreenDefinition   | id - The ID of the screen<br>idString - the ID string of the screen |
| viewTableEntry       | table<br>extraTable<br>id                    |
| editTableEntry       |                                                |
| searchTable          | table<br>selectionIncludeId - the ID string of a selection<br>selection - the ID of a selection |
| mainMenu             |                                                |
| editCompany          | id                                             |
| editCustomer         | id                                             |
| splitTicket          | ticketId                                       |
| splitMessage         | messageId                                      |

> [!NOTE]
> You must set **exactly 1** parameter for screen definitions. Use either *id* or *idString* - don't supply both!

## Document

| Action         | Parameters              |
|:---------------|:------------------------|
| find           |                         |
| listFolders    | focus<br>expandId      |
| editDocument   | documentId<br>folderId |
| editKbCategory | parentId<br>id         |
| editKbEntry    | categoryId<br>id       |
| viewKbEntry    | id                      |

## Rms

| Action        | Parameters                                                      |
|:--------------|:----------------------------------------------------------------|
| getAttachment | Use Attachment.getDownloadUrl to construct a valid query string |
| debug         |                                                                 |

## Stat

| Action         | Parameters |
|:---------------|:-----------|
| mainMenu       |            |
| simpleStat     |            |
| invoiceStat    |            |
| newStatChooser |            |
| viewStat       | documentId |
