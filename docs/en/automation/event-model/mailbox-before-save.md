---
uid: event_model_mailbox_before_save
title: Mailbox before save
description: CRMScript event model - Mailbox event, execute before message is saved
author:
date:
keywords: 
topic: reference
---

# Mailbox event, execute before message is saved

This is a CRMScript you can add under the menu **System design** in the screen **System Script**.

Here you can add CRMScript code that will be run for all mailboxes before the mail is taken by any mail filter, and also before it is saved.

[!include[ALT](../includes/get-set-variable.md)]

Here follows a list of all available variables that are possible to modify.

| Variable | Description |
|---|---|
| subject | Subject of the mail |
| author | Author of the mail |
| ticketExists |  1 if this is a mail on an existing request, else 0 |
| sendAutoReply | 1 if there will be sent an auto-reply, else 0 |
| whyNoAutoReply | Description on why there will not be sent any auto-reply |
| toTrashcan | 1 if this mail will be sent to the trashcan, else 0 |
| toBeDeleted | 1 if this mail will be deleted, else 0 |

## Read-only variables

| Variable | Description |
|---|---|
| body | The plain text part of the mail |
| bodyHtml | The HTML part of the mail |
| ticketId|  The ticket ID, -1 if this is a new ticket |
| fromEjournal | 1 if the mail is from another AIM Server, else 0 |
| isBounce | 1 if this is a bounce, else 0 |
| mailboxId | The id of the mailbox that the mail came in to |

> [!NOTE]
> If you load a ticket object with the given ticket ID, it is not recommended to change the values of this ticket. Later the ticket will be saved, and the values you have saved on the ticket might be overwritten. Thereby you should only modify the variables listed above.

## Example

This script will generate a new request if the incoming email is originally supposed to be connected to an existing request. The script will tell the email engine to generate a new request only if the original request is closed.

```crmscript
Ticket ticket;
ticket.load(getVariable("ticketId").toInteger());

if (ticket.getValue("status") == "2")
  setVariable("ticketExists", "0");  // Generate new request
```
