---
uid: crmscript-request-reply
title: Reply to customer
description: How to add a message and reply to a request with CRMScript; how to close a request.
keywords: Service, ticket, request, CRMScript
author: Bergfrid Skaara Dias
date: 05.26.2023
version: 10
topic: howto
---

# Reply to customer

In request handling, your most important task is to respond to inquiries.
Replies should be visible to the customer, thus you need to set `slevel` of the message to **2** (External).

## String buildEmailSubject()

Creates a string with the email tag, the ticket ID, and its title.

```crmscript!
Ticket t;
t.setValue("title", "External sensors not working");
t.setValue("category", "1");
t.save();
printLine(t.buildEmailSubject());
```

## String getMailFrom()

Determines and returns the most appropriate from-address, when sending an email on a ticket.

```crmscript!
Ticket t;
t.setValue("title", "Unable to go to warp speed");
t.setValue("category", "1");
t.save();
printLine(t.getMailFrom());
```

## String getOwnerEmail()

Creates a string with the ticket's owner formatted as `"Name" <email-addr>`.

```crmscript!
Ticket t;
t.setValue("title", "Where is my order?");
t.setValue("ownedBy", "0");
t.setValue("category", "1");
t.save();
printLine(t.getOwnerEmail());
```

## String getOwnerSms()

Creates a string with the ticket owner's cellphone number.

```crmscript!
Ticket t;
t.load(7);
printLine(t.getOwnerSms());
```

## String getInvolvedOnly()

Looks up all involved customers and returns a comma-separated list of their email addresses. **Involved** means that the customer has received a message on the ticket, but they are not listed as a customer on this ticket.

```crmscript
Ticket t;
t.load(3);
printLine(t.getInvolvedOnly());
```

## Add a message to ticket

```crmscript
Ticket t;
t.load(1);

String owner = t.getValue("ownedBy");

if (owner == "1") {
  t.setValue("ticketStatus", "1");
  Message m;
  m.setValue("ticketId", t.getValue("id"));
  m.setValue("createdAt", getCurrentDateTime().toString());
  m.setValue("createdBy", getActiveUser().getValue("id"));
  m.setValue("type", "1");
  m.setValue("author", "System");
  m.setValue("slevel", "1");
  m.setValue("body", "Remember to set owner");
  m.setValue("important", "true");
  m.save();
  t.save();
}
```

> [!TIP]
> Complex requests can take a lot of time to solve and involve a lot of communication between the customer and multiple request handlers. To keep track of messages, you can flag them as important: `setValue("important", "true")`.

You can also [add a display header and attachments][1] to the message.

## Using reply templates

You can save time by using a reply template as your basis.

### Void toParser(Parser theParser)

Passes relevant data from the ticket to the parser. Strings such as title and author are formatted as HTML.

```crmscript!
Ticket t;
t.load(3);

Parser p;
t.toParser(p);

ReplyTemplate rt;
rt.load(20);

String output = p.parseString(rt.getHtmlBody(2));
print(output);
```

Read more about [the parser][5] and [reply templates][4].

### Void toParserRaw(Parser theParser)

Same as `toParser()` but produces plain text and not HTML.

## Send message

### Void saveInvolved(String emailAddress)

Keeps track of recipients that are not necessarily customers on the request.

The list of involved is used to show address suggestions in the **Add message** screen.

```crmscript
Message m;
m.saveInvolved("post@company.com");
```

### Void saveInvolved(Vector emailAdresses)

Same as above, except you can specify a list of email addresses rather than just 1.

### Bool send(Vector to, Vector cc, Vector bcc)

Sends an email version of the message to the main contacts on the parent ticket.

If sending for some reason fails, `send()` will return **false**.

```crmscript!
Message m;
m.setValue("createdBy","1");
m.save();
Vector to;
Vector cc;
Vector bcc;
to.parseString("cto@company.no",",");
cc.parseString("teamlead@company.no",",");
bcc.parseString("cto@competitor.no",",");

Bool sent = m.send(to,cc,bcc);
printLine(sent.toString());
```

### Bool send(Vector to, Vector cc, Vector bcc, String subject)

A variant of `send()` where you can specify the subject.

```crmscript
m.send(to,cc,bcc,"Recruitment");
```

### Bool send(Vector to, Vector cc, Vector bcc, String subject, String bodyHeading)

A variant of `send()` where you can specify the subject and also a  heading for the body part.

```crmscript
m.send(to,cc,bcc,"Recruitment","");
```

> [!TIP]
> For no heading, pass an empty string. To use the default heading, pass **null** (same as omitting the string).

### Bool sendSms(Vector to)

Sends an SMS version of the message to the numbers listed.

### Void sendFacebook()

Sends a Facebook version of the message.

## Close tickets

After responding to a request, you can set its status to **Closed**.

Typical scenarios:

* The case is resolved.
* You have forwarded the ticket to an external party, who will handle and complete the request.

```crmscript
Ticket t;
t.load(1);
t.setValue("status", "2");
t.save();
```

<!-- Referenced links -->
[1]: add-message.md
[4]: reply-templates.md
[5]: ../../parser.md
