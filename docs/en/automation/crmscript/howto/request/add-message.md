---
uid: crmscript-message-create
title: Create and update messages
description: How to create and update request messages in CRMScript.
keywords: CRMScript, Service, ticket, request, message
author: Bergfrid Skaara Dias
date: 05.26.2023
version: 10
topic: howto
---

# Create and update messages

## Void setValue(String colName, String value)

Sets a named field to the given value. Look up names in the reference section down below, or check out the [class reference][1].

> [!NOTE]
> Both parameters are strings! Remember to use quotes even for IDs.
>
> You must call `save()` after setting all applicable values to actually create or update the message.

```crmscript!
Message m;
m.setValue("emailHeader", "Test");
m.setValue("body", "This is a test");
print(m.save().toString());
```

### Frequently used values

| Parameter | Db field | Description |
|:--|:--|:--|
| ticketId | ticket_id | The ticket this message is a child of |
| type | type | Plaintext or HTML |
| author | author | A user's name, or a persons email address |
| createdBy | created_by | The ID of the user who posted the message (1: system) |
| slevel | slevel | The security level of the ticket (1: internal, 2: external) |
| message_id | message_id | The X-Message-Id email header. Used for threading |
| body | body | The text body for the message |
| bodyHtml | html_body | The html body for the message (if any) |
| emailHeader | email_header | Raw text header |

For a complete list of fields, see the [database reference][3].

## Void setAttachments(Vector ids)

Connects 1 or more attachments to the message. Attachments are identified by their ID.

> [!NOTE]
> You must call `save()` before calling `setAttachments()`!

```crmscript
Message m;
m.setValue("ticketId","4");
m.save();
Vector v;
v.parseString("1,4,7",",");
m.setAttachments(v);
m.save();
```

## Void addHeader(String type, String value)

Adds a display header to the message. Not to be confused with email header!

Display headers are shown at the **View request** page when listing messages.

Commonly used types are *To*, *Cc*, *Bcc*, and *SMS*. The corresponding value would then be the recipients as a comma-separated list.

```crmscript
Message m;
m.load(1);
m.addHeader("To","post@company.com");
m.save();
```

## Integer save()

Saves a new or updated message and returns its ID.

```crmscript
Message m;
m.setValue("type","html");
m.save();
```

## Integer save(String log)

A variant of `save()` that also adds a message to the ticket log.

```crmscript
Message m;
m.setValue("type","html");
m.save("This is a duplicate.");
```

## Integer save(String log, Bool noNewInfo)

A  variant of `save()` with a setting for controlling processing:

* `noNewInfo`: if **false**, set the read status on ticket to yellow (if currently green)

```crmscript
Message m;
m.setValue("createdBy","1");
m.save("Need to follow up",true);
```

## Using reply templates

You can save time by using a reply template as your basis.

### Void toParser(Parser parser)

Passes relevant data from the message to the parser.

* message.id
* message.slevel, message.slevelInteger (as text in the active user's language and as number)
* message.createdAt, message.createdAtRaw (formats *DD. MMM YYYY, kl. hh:mm* and *YYYY-MM-DD hh:mm:ss*)
* message.author
* message.header
* message.body, message.bodyPlain, message.bodyHtml
* message.messageCategory (Message: 0, Bounce: 1, OutboxFailed: 2)
* message.mailSorter (mail filter applied to incoming message)
* message.x_myextrafield (extrafield value)

```crmscript!
Message m;
m.setValue("body", "Thank you, mr. Data!");
m.setValue("type", "html");

Parser p;
m.toParser(p);
printLine("Body passed to parser: " + p.getVariable("message.body",0));

ReplyTemplate rt;
rt.load(19);
String htmlBody = rt.getHtmlBody(2);

m.setValue("bodyHtml" , p.parseString(htmlBody));

printLine("\nHTML body of message after parsing:\n\n" + m.getValue("bodyHtml"));
```

Read more about [the parser][5] and [reply templates][4].

### Void convertInlineImages()

Converts any inline images from content ID (cid:) to standard HTTP.

```crmscript
Message m;
m.convertInlineImages();
m.save();
```

<!-- Referenced links -->
[1]: <xref:CRMScript.Native.Message.setValue(String,String)>
[3]: ../../../../database/tables/ej-message.md
[4]: reply-templates.md
[5]: ../../parser.md
