---
uid: crmscript_persons
title: Persons
description: How to work with persons in CRMScript.
author: Bergfrid Dias
so.date: 02.04.2022
keywords: person, contact, CRMScript
so.topic: howto
---

# Persons

## Customer (class)

The **Customer** CRMScript class represents the following entities:

* Real-life: a customer (person) that may or may not work for a company or organization
* SuperOffice UI: contact
* Database table: person

> [!NOTE]
> All [associates][1] (internal employees) have a corresponding person record.
>
> The `associate` table is an MDO list item table and has therefore not a corresponding CRMScript class.

### String makeSalutation()

`makeSalutation()` creates a greeting appropriate for the customer. The string can be used at the beginning of a document or email.

```crmscript!
Customer c;
c.load(3);
printLine(c.makeSalutation());
```

## User (class)

The **User** CRMScript class represents the following entities:

* Real-life: a user account
* SuperOffice UI: user
* Database table: ejuser

> [!NOTE]
> To get from a user object to a customer or company object, you must go via the **associate** table.

## Parser variables

Calling `toParser()` will load fields, prefix them based on the class, and make them available to [templates][2].

> [!NOTE]
> Repeated calls will overwrite rather than append the values in the Parser instance.

```crmscript!
Parser p;
Customer c;
c.load(4);
c.toParser(p);
printLine(p.getVariable("customer.name", 0));

User u;
u.load(2);
u.toParser(p);
printLine(p.getVariable("user.username", 0));
```

Here, prefixes are *customer* and *user* respectively.

<!-- Referenced links -->
[1]: ../../associate.md
[2]: ../../../automation/crmscript/parser-and-templates/reply-template.md
