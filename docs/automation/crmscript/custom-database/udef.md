---
title: User-defined fields explained
uid: crmscript_udef
SortOrder: 10
---

A *user-defined* field (udef) is a custom field that you add to an existing SuperOffice database table. You can extend the following entities:

* [company](../persons-and-organizations/company.md)
* [contact](../persons-and-organizations/customer.md)
* [documents](../documents/index.md)
* [follow-up](../follow-ups/index.md)
* project
* [sale](../sales/index.md)

There are 8 different types of user-defined fields: Number, Decimal, Short text, Long text, Date, Unlimited date, Checkbox, and List (drop-down).

User-defined fields are managed in the SuperOffice CRM Admin client, in the **Fields** screen.

## Storage

| Field type       | Database table | Data type   |
|:-----------------|:---------------|:------------|
| Number           | UDXXXsmall     | Long        |
| Decimal          | UDXXXsmall     | Double      |
| Short text       | UDXXXsmall     | String[40]  |
| Long text        | **UDXXXLarge** | String[200] |
| Date             | UDXXXsmall     | Long        |
| Unlimited date   | UDXXXsmall     | String[40]  |
| Checkbox         | UDXXXsmall     | Long        |
| List (drop-down) | UDXXXsmall     | Long        |

### Available fields by type

Each entity that supports user-defined fields can have up to **119 custom fields**.

| Data type   | Quantity | Used by                          |
|:------------|:---------|:---------------------------------|
| Long        | 60       | number, date, check-box and list |
| Double      | 10       | decimal                          |
| String[40]  | 40       | short text and unlimited date    |
| String[200] | 9        | long text                        |

> [!NOTE]
> When all String[40] fields are taken, the system will use String[200] from the corresponding UDXXXLarge table. This will decrease the available number of fields for the long text type fields.

## Indexed fields

Indexing is good for user experience and performance. The first 4 fields of each data type are reserved for indexes.

You have to mark the checkbox when creating the field to allow it to be indexed. You can mark up to 4 fields in each of the 4 data types (Long, Double String[40], String[200]) for each entity. For example, you can index 4 numbers and 4 decimals for a contact, however you can't at the same time also index a date - because all Long index slots are taken by the numbers.

If you choose not to index at all, you're essentially wasting 16 fields! Thus, the max number of custom fields is reduced to 103.

## Prog IDs

The prog ID is used to identify user-defined fields for an entity. The format is **text:number**.

By default, the text part is *SuperOffice* and the number is a running counter. You can customize the ID when you create the field, but keep the text portion to letters a-z or their uppercase equivalents.

## Dates

User-defined *date* fields use the **SuperDate** format. This is a string:

* a set of square brackets enclosing a prefix and the date itself
* D: (fixed)
* the date on the YYYY.MM.DD format

For example, "[D:2020.08.27]".

### Convert DateTime to SuperDate

For [DateTime](../datatypes/datetime-type.md), you can use its built-in formatting options of `toString()`.

```crmscript!
String toSuperDate( DateTime dt ) {
  return dt.toString("[D:YY4.MM2.DD2]");
}

DateTime now;
printLine(toSuperDate(now));
```

### Convert Date to SuperDate

For [Date](../datatypes/date-type.md), you need to format the string yourself.

```crmscript!
String toSuperDate( Date d ) {
  return "[D:" + d.toString().substitute("-", ".") + "]";
}

Date now;
printLine(toSuperDate(now));
```

### Convert SuperDate to DateTime

```crmscript!
DateTime fromSuperDate( String s ) {
  return s.after("[D:").before("]").toDateTime();
}

DateTime dt = fromSuperDate("[D:2020.08.27]");
printLine(dt.toString());
```

### Convert SuperDate to Date

```crmscript!
Date fromSuperDate( String s ) {
  return s.after("[D:").before("]").toDate();
}

Date d = fromSuperDate("[D:2020.08.27]");
printLine(d.toString());
```

## Creating user-defined fields

1. Sign in to the SuperOffice CRM Admin client and select **Fields** in the main menu.
2. Select the entity you want to extend and then click **Add**.
3. Enter a name and select a type.
4. Optionally set other field properties, such as whether it is mandatory or should be indexed.
5. Click **Save**.
6. Optionally adjust the layout and/or set the field to be shown on the first page of the selected screen.
7. Continue adding fields. Click **Publish** when you're done.

> [!TIP]
> You can select up to 3 fields that will be included on the main card.

## Convert field type

Not all conversions are possible because different types of user-defined field values are stored in different tables in the database and use different base data types.

1. Go to the **Fields** screen.
2. Select the entity and then double-click the field you want to change.
3. Use the drop-down to set choose a new type. You'll see only the compatible field types.
4. Click **Save**. Then click **Publish**.

| Field type     | Number | Decimal | Short text | Long text | Date | Unlimited date | Checkbox | List |
|:---------------|:------:|:-------:|:----------:|:---------:|:----:|:--------------:|:--------:|:----:|
| Number         | x      | x       | x          |           |      |                |          |      |
| Decimal        | x      | x       | x          |           |      |                |          |      |
| Short text     | x      |         | x          |           |      |                |          |      |
| Long text      |        |         |            | x         |      |                |          |      |
| Date           |        |         | x          |           | x    | x              |          |      |
| Unlimited date |        |         | x          |           |      | x              |          |      |
| Checkbox       |        |         | x          |           |      |                | x        |      |
| List           |        |         | x          |           |      |                |          | x    |

**How to read the table:**

The field types in the left column are compatible with and can be converted to the types marked with an x.
For example, a number can be converted to a decimal and a short text. (And it's obviously compatible with itself.)

## Get all user-defined fields from entity

`GetUserDefinedFields()` retrieves all registered user-defined fields from an entity. Here, we use the [contact](../persons-and-organizations/customer.md) entity.

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
