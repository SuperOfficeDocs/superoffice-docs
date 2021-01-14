---
title: Logs
uid: crmscript_request_logs
SortOrder: 30
---

The system logs all noteworthy actions and changes pertaining to tickets. You can also add your own log entries.

## Write a message to the ticket log

You can manually write messages to the ticket log. Not to be confused with the message objects associated with the ticket.

### Void log(String message)

Logs a message to the ticket log.

```crmscript
Ticket t;
t.load(2);
t.log("here we go again!");
```

### Void log(String who, String message)

A variant of `log()` that includes who made the entry.

```crmscript
Ticket t;
t.load(2);
t.log("SuperStar RequestHandler", "I can handle anything and anyone!");
```

## Search the log

When inspecting logs, the CRMScript [SearchEngine](../searchengine/index.md) is your best friend. Here's some info commonly filtered on:

* ticket_id
* message_id
* user_id
* customer_id
* log_when (DateTime)

Look up more options in the [database reference](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-ticket_log.htm).

**Example searches:**

* requests amended or updated in a specific way within a specific period
* all requests that a user has changed in the last week, regardless of who is responsible for the request or what status it has

```crmscript!
DateTime dt;
dt.moveToWeekStart();

SearchEngine se;
se.addField("ticket.id");
se.addField("ticket.title");
se.addCriteria("ticket.status", "OperatorEquals", "4", "OperatorAnd", 0);
se.addCriteria("ticket.last_changed", "OperatorGt", dt.toString(), "OperatorAnd", 0);

print(se.executeTextTable());
```

This will print the ID and title of any merged tickets updated sometime during the current week.

## Database entries

For each change to a ticket, new entries are added to both the **ticket_log_action** table and the **ticket_log_change** table.

| Table             | Entries                                 | Enum      |
|:------------------|:----------------------------------------|:----------|
| ticket_log_action | 1 entry with the timestamp              | [LogAction](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-ticket_log_action.htm) |
| ticket_log_change | 1 entry for each value that has changed | [LogChange](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-ticket_log_change.htm) |
