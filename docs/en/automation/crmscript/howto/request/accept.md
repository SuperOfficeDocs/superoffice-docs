---
uid: crmscript-request-accept
title: Accept ticket
description: How to accept ticket with CRMScript.
keywords: Service, ticket, request, CRMScript
author: Bergfrid Skaara Dias
date: 05.26.2023
version: 10
topic: howto
---

# Accept ticket

Accepting or assigning a ticket means to update `ownedBy`. You might also want to update the status and the last modified timestamps.

```crmscript
Ticket t;
t.load(1);

if (t.getValue("ownedBy") == "1") {
  t.setValue("ownedBy", "7");
  t.setValue("ticketStatus", "1");
  String now = getCurrentDateTime().toString();
  t.setValue("lastChanged", now);
  t.setValue("dbiLastModified", now);
  t.save();
}
```

## Bool notifyEmail(Integer replyTemplateId)

Sends a notification email to the owner of the ticket.

Call `notifyEmail()` when you create a new ticket, add a new message to a ticket, and similar events.

Pass the ID of a suitable [reply template][4].

```crmscript
Ticket t;
t.setValue("title", "No audio");
t.setValue("ownedBy", "3");
t.save();
t.notifyEmail(8);
```

<!-- Referenced links -->
[4]: reply-templates.md
