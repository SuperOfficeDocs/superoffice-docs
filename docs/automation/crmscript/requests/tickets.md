---
uid: crmscript_tickets
title: Tickets
author:
so.date:
keywords:
so.topic:
---

# Tickets

## Create and update requests

### Void setValue(String colName, String value)

Sets a named field to the given value. Look up names in the reference section down below, or check out the [class reference][1].

> [!NOTE]
> Both parameters are strings! Remember to use quotes even for IDs.<br>You must call `save()` after setting all applicable values to actually create or update the ticket.

```crmscript!
Ticket t;
t.setValue("title", "No audio");
t.setValue("category", "2");
t.setValue("status", "1");
t.setValue("priority", "2");
print(t.save().toString());
```

This snippet creates a new ticket and prints its ID.

> [!TIP]
> To check the available options for category, status, and priority: Go to the SuerOffice Admin client and select **Requests** from the main menu. You can now inspect the options in each tab.

### Integer save()

Saves a new or updated ticket and returns its ID.

```crmscript
Ticket t;
t.setValue("title", "No audio");
t.save();
```

### Integer save(String log)

A variant of `save()` that also adds a message to the ticket log.

```crmscript
Ticket t;
t.setValue("title", "No audio");
t.save("This is the 5th audio complaint in 1 hour!");
```

### Integer save(Bool setReadStatus, Bool doNotCheckEscalating)

A variant of `save()` with 2 settings for controlling processing:

* `setReadStatus`: if **true**, update the read status
* `doNotCheckEscalating`: if **true**, do NOT let the update trigger a possible escalation

```crmscript
Ticket t;
t.setValue("title", "No audio");
t.save(true, false);
```

### Integer save(String log, Bool setReadStatus, Bool doNotCheckEscalating)

A variant of `save()` that combines the processing settings and a log message.

```crmscript
Ticket t;
t.setValue("title", "No audio");
t.save("audio",true, true);
```

### Void addSecondaryCustomers(Vector ids)

Adds 1 or more customer IDs to the list of secondary customers.

> [!TIP]
> A [vector][2] is a 1-dimensional list of String objects.

```crmscript
Ticket t;
t.setValue("title", "Bad audio");
Vector v;
v.parseString("1,4,5",",");
t.addSecondaryCustomers(v);
t.save();
```

## Get ticket info

### Bool load(Integer id)

Brings up the ticket with the given ID. This is always the 1st step when you want to do anything with an existing ticket.

```crmscript
Ticket t;
t.load(1);
```

### String getValue(String colName)

Fetches the value from a named field. Look up names in the reference section down below, or check out the [class reference][3].

```crmscript!
Ticket t;
t.load(2);
print(t.getValue("ticketStatus"));
```

## Accept ticket

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

### Bool notifyEmail(Integer replyTemplateId)

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

## Reply to customer

In request handling, your most important task is to respond to inquiries.
Replies should be visible to the customer, thus you need to set `slevel` of the message to **2** (External).

### String buildEmailSubject()

Creates a string with the email tag, the ticket ID, and its title.

```crmscript!
Ticket t;
t.setValue("title", "External sensors not working");
t.setValue("category", "1");
t.save();
printLine(t.buildEmailSubject());
```

### String getMailFrom()

Determines and returns the most appropriate from-address, when sending an email on a ticket.

```crmscript!
Ticket t;
t.setValue("title", "Unable to go to warp speed");
t.setValue("category", "1");
t.save();
printLine(t.getMailFrom());
```

### String getOwnerEmail()

Creates a string with the ticket's owner formatted as `"Name" <email-addr>`.

```crmscript!
Ticket t;
t.setValue("title", "Where is my order?");
t.setValue("ownedBy", "0");
t.setValue("category", "1");
t.save();
printLine(t.getOwnerEmail());
```

### String getOwnerSms()

Creates a string with the ticket owner's cellphone number.

```crmscript!
Ticket t;
t.load(7);
printLine(t.getOwnerSms());
```

### String getInvolvedOnly()

Looks up all involved customers and returns a comma-separated list of their email addresses. **Involved** means that the customer has received a message on the ticket, but they are not listed as a customer on this ticket.

```crmscript
Ticket t;
t.load(3);
printLine(t.getInvolvedOnly());
```

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

## Priority and escalation

### Void checkEscalating(Integer action)

Runs a check according to the ticket's priority and the given action. Based on the result, 1 of the following happens:

* escalation stops
* escalation restarts
* escalation continues

You can specify the following actions:

| Value | Action                |
|:-----:|:----------------------|
| 0     | ActionRead            |
| 1     | ActionChangedOwner    |
| 2     | ActionNewInfo         |
| 3     | ActionClosed          |
| 4     | ActionChangedPriority |
| 5     | ActionNew             |

```crmscript
Ticket t;
t.load(8);
t.checkEscalating(4);
```

## Delegate

If a request handler is unable to resolve the issue, they can:

* pass the ticket to a colleague
* forward the ticket to an external party
* delegate and let the system pick the next owner

### Ask a colleague for help

1. Reassign the ticket.
2. Add an internal message with your question.
3. Update the last modified timestamps.
4. Optionally add the ticket to the previous owner's favorites list, as a reminder to follow up.

### Forward to an external party

A common scenario when you need to get advice from a sub-supplier.

> [!TIP]
> Use the contact's (customer's) email address as the sender so that any answer from the recipient will be sent directly to the contact and not back to SuperOffice Service.

#### Bool sendMessages(String subject, StringMatrix recipients, Bool fromCust, String messages, Integer msgId, String comment)

Forwards the listed messages. In the generated email, the comment is inserted at the top and followed by the messages, each separated by a line.

| Parameter  | Description                             |
|------------|-----------------------------------------|
| subject    | ticket.title or similar                 |
| recipients | Format: to / pipesign / name / email    |
| fromCust   | The sender's email address              |
| messages   | A comma-separated list of message IDs   |
| msgId      | ID of added "forward" message or -1     |
| comment    | A note preceding the forwarded messages |

**Recipients example:**
To \| John Doe \<john.doe@john.doe> Cc \| Jane Doe \<jane.doe@jane.doe>

### Void delegate()

Delegates a ticket to a user according to the rules of the ticket's category.

> [!NOTE]
> You must call `save()` to do the action.

```crmscript
Ticket t;
t.load(2);
t.delegate();
t.save();
```

### Void delegate(Integer notUser)

A variant of `delegate()` that lets you exclude a user from the pool of possible assignees.
For example if the 2nd owner also passes on the ticket and you want to avoid re-assigning to the original owner.

```crmscript
Ticket t;
t.load(2);
t.delegate(4);
t.save();
```

## Postpone tickets

Sometimes you need to put tickets on the back-burner.

```crmscript
DateTime now = getCurrentDateTime();

Ticket t;
t.load(3);
t.setValue("status", "3");
t.setValue("lastChanged", now.toString());
t.setValue("dbiLastModified", now.toString());

Message m;
m.setValue("ticketId", t.getValue("id"));
m.setValue("createdAt", t.getValue("lastChanged"));
m.setValue("createdBy", t.getValue("ownedBy"));
m.setValue("slevel", "1");
m.setValue("body", "Expecting fix in next patch");
m.save();

t.setValue("activate", now.moveToMonthEnd().toString());
t.save();
t.notifyEmail(5);
```

## Split and merge

If 1 request contains multiple questions, you can split the request.

Sometimes, you will for example see that the customer initially asks a technical question, but then uses the opportunity to raise an invoicing query as well.

Other times, the situation is reversed: multiple contacts in the same company have reported the same technical issue (via phone, email). You can then merge these duplicates into 1 request.

There's no `split()` or `merge()` method, but you can write your own logic. Here's how.

### Split requests

Pre-requisite: ID of the original ticket and the message you want to split out is known.

1. Load the original ticket.
1. Create a new ticket and copy *essential* data from the original.
1. Set a suitable title and category.
1. Copy the message with the new question to the new ticket.
1. Modify the original ticket to reflect the split.
1. Save both tickets and resume processing.

> [!TIP]
> You can also split a message.

### Merge requests

1. Load both requests.
2. Copy all contacts and messages from the source into the target.
3. Select which request data to keep. If you want to keep the value from the source, copy this into the target ticket (overwrite).
4. Set source ticket `connect_id` field equal to the target ticket id.
5. Set the status of the source ticket to **5** (Merged/Linked).
6. Update any other important settings on the target ticket.
7. Save both tickets and resume processing.

> [!TIP]
> To filter SearchEngine results for merged tickets, include criteria to exclude tickets with status equals 5.

## Close tickets

After responding to a request, you can set its status to **Closed**.

Typical scenarios:

* the case is resolved
* you have forwarded the ticket to an external party, who will handle and complete the request

```crmscript
Ticket t;
t.load(1);
t.setValue("status", "2");
t.save();
```

## Delete tickets

> [!WARNING]
> In general, we don't recommend deleting requests. It is usually preferable to add a comment and/or tag and mark it as closed.

Deleting a ticket will also delete all messages and attachments linked to it!

However, you may be required to delete a request to comply with your company's privacy policy. Proceed with caution! Use the same statements as for closing a ticket, just change the status code from 2 to 4.

## Reference

### Frequently used ticket values

| Parameter    | Db field         | Description                                                 |
|:-------------|:-----------------|:------------------------------------------------------------|
| title        | title            | A descriptive name, String                                  |
| category     | category         | The ID of the category the ticket belongs to                |
| ownedBy      | owned_by         | The ID of the user who owns the ticket                      |
| slevel       | slevel           | The security level of the ticket (1: internal, 2: external) |
| priority     | priority         | The ID                                                      |
| status       | status           | The main ticket status \[0-5\], see list                    |
| custId       | cust_id          | The ID of the primary customer                              |
| customers    | ticket_customers | A comma-separated list of customer IDs                      |
| createdBy    | created_by       | The ID of the user who posted the ticket (1: system)        |

For a complete list of fields, see the [database reference][6].

### Timestamp values

| Parameter      | Db field        | Description                                             |
|:---------------|:----------------|:--------------------------------------------------------|
| activate       | activate        | When to activated a postponed ticket                    |
| createdAt      | created_at      | When the ticket was created                             |
| repliedAt      | replied_at      | When the 1st external message was added                 |
| stopEscalation | stop_escalation |                       |
| readStatus     | read_status     | Has the owner has read the ticket? (red, yellow, green) |
| deadline       | deadline        | The deadline of the ticket                              |
| timeToClose    | time_to_close   | Minutes between create and close                        |

For a complete list of fields, see the [database reference][6].

### Status

| Status | Description           |
|:------:|-----------------------|
| 0      | Unknown/uninitialized |
| 1      | Active                |
| 2      | Closed                |
| 3      | Postponed             |
| 4      | Deleted               |
| 5      | Merged/Linked         |

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/SDK/SO.Customer.Service.Support/html/CRMScript-Classes-Ticket-setValue.htm
[2]: https://community.superoffice.com/documentation/SDK/SO.Customer.Service.Support/html/CRMScript-Classes-Vector-Vector.htm
[3]: https://community.superoffice.com/documentation/SDK/SO.Customer.Service.Support/html/CRMScript-Classes-Ticket-getValue.htm
[4]: ../parser-and-templates/reply-template.md
[5]: ../parser-and-templates/parser.md
[6]: https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-ticket.htm
