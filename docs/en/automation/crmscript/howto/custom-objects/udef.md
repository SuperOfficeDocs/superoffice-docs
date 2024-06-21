---
uid: crmscript-udef
title: Working with user-defined in CRMScript
description: User-defined in CRMScript
author: Bergfrid Dias
date: 02.07.2022
keywords: udef, custom objects, custom fields
topic: howto
---

# User-defined fields

## Convert DateTime to SuperDate

For [DateTime][6], you can use its built-in formatting options of `toString()`.

```crmscript!
String toSuperDate( DateTime dt ) {
  return dt.toString("[D:YY4.MM2.DD2]");
}

DateTime now;
printLine(toSuperDate(now));
```

## Convert Date to SuperDate

For [Date][7], you need to format the string yourself.

```crmscript!
String toSuperDate( Date d ) {
  return "[D:" + d.toString().substitute("-", ".") + "]";
}

Date now;
printLine(toSuperDate(now));
```

## Convert SuperDate to DateTime

```crmscript!
DateTime fromSuperDate( String s ) {
  return s.after("[D:").before("]").toDateTime();
}

DateTime dt = fromSuperDate("[D:2020.08.27]");
printLine(dt.toString());
```

## Convert SuperDate to Date

```crmscript!
Date fromSuperDate( String s ) {
  return s.after("[D:").before("]").toDate();
}

Date d = fromSuperDate("[D:2020.08.27]");
printLine(d.toString());
```

## Get all user-defined fields from entity

`GetUserDefinedFields()` retrieves all registered user-defined fields from an entity. Here, we use `NSContactEntity`.

> [!TIP]
> **Map** is a collection of key-value pairs. The key is **not the label** you gave the field! It's the **prog ID**!

```crmscript!
Void printContactUdefs(Integer contactId) {
  NSContactAgent contactAgent;
  NSContactEntity contact = contactAgent.GetContactEntity(contactId);

  Map udefs = contact.GetUserDefinedFields();

  udefs.first();
  while (!udefs.eof()){
    printLine(udefs.getKey() + " = " + udefs.getVal());
    udefs.next();
  }
}

printContactUdefs(5);
```

## Get a specific field

```crmscript
String getFieldFromContact(Integer contactId, String progId) {
  NSContactAgent agent;
  NSContactEntity contact = agent.GetContactEntity(contactId);
  Map fields = contact.GetUserDefinedFields();
  return fields.get(progId);
}

String s = getFieldFromContact(1,"SuperOffice:2");
printLine(s.);
```

## Update user-defined field value

Call `SetUserDefinedFields` to set a user-defined field.

> [!TIP]
> Remember to use the prog ID to identify the field. (*SuperOffice:1* in this example)

```crmscript
NSContactAgent contactAgent;
NSContactEntity contact = contactAgent.GetContactEntity(1);

String progId = "SuperOffice:2";
Date now;
Map udefs = contact.GetUserDefinedFields();
udefs.insert( progId, now );

contact.SetUserDefinedFields(udefs);
contact = contactAgent.SaveContactEntity(contact);
```

The field we're updating here is a date, so we have to make sure it's on the SuperDate format.

## Search based on user-defined field

This example uses the `NSFindAgent` to look up appointments based on a user-defined field. The search itself happens when we call `FindFromRestrictionsColumns()`. We then loop through and print the result.

```crmscript!
NSFindAgent agent;

String provider = "FindAppointment";

String[] columns;
columns.pushBack("date");
columns.pushBack("text");

String[]  values;
values.pushBack("UdefValue");

NSArchiveRestrictionInfo[] restrictions;
NSArchiveRestrictionInfo r;
r.SetName("appointmentUdef/SuperOffice:1");
r.SetOperator("=");
r.SetValues(values);
r.SetIsActive(true);
restrictions.pushBack(r);

NSFindResults result = agent.FindFromRestrictionsColumns(restrictions, provider, columns, 50, 0);

if (result.GetRowCount() > 0) {
  NSArchiveListItem[] archiveRows = result.GetArchiveRows();
  foreach (NSArchiveListItem row in archiveRows) {
    Map m = row.GetColumnData();
    m.first();
    while (!m.eof()){
      printLine(m.getKey() + " = " + m.getVal());
      m.next();
    }
  }
}
```

<!-- Referenced links -->
[6]: ../../datatypes/datetime-type.md
[7]: ../../datatypes/date-type.md
