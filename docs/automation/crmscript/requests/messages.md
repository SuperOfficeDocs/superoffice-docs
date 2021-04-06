---
uid: crmscript_messages
title: Messages
author:
so.date:
keywords:
so.topic:
---

# Messages

## Create and update messages

### Void setValue(String colName, String value)

Sets a named field to the given value. Look up names in the reference section down below, or check out the [class reference][1].

> [!NOTE]
> Both parameters are strings! Remember to use quotes even for IDs.<br>You must call `save()` after setting all applicable values to actually create or update the message.

```crmscript!
Message m;
m.setValue("emailHeader", "Test");
m.setValue("body", "This is a test");
print(m.save().toString());
```

### Void setAttachments(Vector ids)

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

### Void addHeader(String type, String value)

Adds a display header to the message. Not to be confused with email header!

Display headers are shown at the **View request** page when listing messages.

Commonly used types are *To*, *Cc*, *Bcc*, and *SMS*. The corresponding value would then be the recipients as a comma-separated list.

```crmscript
Message m;
m.load(1);
m.addHeader("To","post@company.com");
m.save();
```

### Integer save()

Saves a new or updated message and returns its ID.

```crmscript
Message m;
m.setValue("type","html");
m.save();
```

### Integer save(String log)

A variant of `save()` that also adds a message to the ticket log.

```crmscript
Message m;
m.setValue("type","html");
m.save("This is a duplicate.");
```

### Integer save(String log, Bool noNewInfo)

A  variant of `save()` with a setting for controlling processing:

* `noNewInfo`: if **false**, set the read status on ticket to yellow (if currently green)

```crmscript
Message m;
m.setValue("createdBy","1");
m.save("Need to follow up",true);
```

### Edit message

For obvious reasons, you should not alter the text in a message after the fact.

However, you might need to edit some properties for bookkeeping or compliance. For example:

* Time spent (accumulates)
* Invoicing info
* Access level (internal/external)
* Attachments (removal might be required)

## Use a reply template

You can save time by using a reply template as your basis.

### Void toParser(Parser parser)

Passes relevant data from the message to the parser.

* message.id
* message.slevel, message.slevelInteger (as text in the active user's language and as number)
* message.createdAt, message.createdAtRaw (formats *DD. MMM YYYY, kl. hh:mm* and *YYYY-MM-DD hh:mm:ss*)
* message.author
* message.header
* message.body, message.bodyPlain, message.bodyHtml
* message.messageCategory (Message: 0, Bounce: 1, OutboxFailed: 2
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

Read more about [the parser][2] and [reply templates][3].

### Void convertInlineImages()

Converts any inline images from content ID (cid:) to standard HTTP.

```crmscript
Message m;
m.convertInlineImages();
m.save();
```

## Get message info

### Bool load(Integer id)

Brings up the message with the given ID. This is always the 1st step when you want to do anything with an existing message.

```crmscript
Message m;
m.load(1);
```

### String getValue(String colName)

Fetches the value from a named field. Look up names in the reference section down below.

```crmscript!
Message m;
m.load(2);
print(m.getValue("timeCharge").toString());
```

### Integer\[\] getAttachments()

Fetches the ID of all attachments connected to the message.

```crmscript!
Message m;
m.load(2);
Integer[] attachments = m.getAttachments();
while(attachments.length() > 0) {
  printLine(attachments.popFront());
}
```

### Send message

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

## Reference

### Frequently used values

| Parameter    | Db field     | Description                                                 |
|:-------------|:-------------|:------------------------------------------------------------|
| ticketId     | ticket_id    | The ticket this message is a child of                       |
| type         | type         | plaintext or HTML                                           |
| author       | author       | a user's name, or a persons email address                   |
| createdBy    | created_by   | The ID of the user who posted the message (1: system)       |
| slevel       | slevel       | The security level of the ticket (1: internal, 2: external) |
| message_id   | message_id   | The X-Message-Id email header. Used for threading           |
| body         | body         | The text body for the message                               |
| bodyHtml     | html_body    | The html body for the message (if any)                      |
| emailHeader  | email_header | Raw text header                                             |

For a complete list of fields, see the [database reference][4].

### Timestamp values

| Parameter  | Db field    | Description                             |
|:-----------|:------------|:----------------------------------------|
| createdAt  | created_at  | When the message was posted             |
| timeSpent  | time_spent  | Minutes used on this message            |
| timeCharge | time_charge | Minutes to be invoiced for this message |

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/SDK/SO.Customer.Service.Support/html/CRMScript-Classes-Message-setValue.htm
[2]: ../parser-and-templates/parser.md
[3]: ../parser-and-templates/reply-template.md
[4]: https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-ej_message.htm
