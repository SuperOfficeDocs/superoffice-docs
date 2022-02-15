---
uid: crmscript_class_customer
title: Customer (class)
description: The CRMScript customer class.
author: Bergfrid Skaara Dias
so.date: 11.02.2021
keywords: CRMScript, customer, person, contact
so.topic: concept
---

# Customer (class)

The **Customer** CRMScript class represents the following entities:

* Real-life: a customer (person) that may or may not work for a company or organization
* SuperOffice UI: contact
* Database table: person

> [!NOTE]
> All associates (internal employees) have a corresponding person record.

## Security

Don't assume that a user has access to everything. It is good practice to look up access rights before revealing or altering information about a person.

### Bool checkTableRights(String tableRight)

`checkTableRights()` determines whether the current user has access to a customer (person).

Access pertains to 1 of the following tasks:

* select
* update
* insert

```crmscript!
Customer c;
c.load(5);

Bool b = c.checkTableRights("select");
printLine(b.toString());
```

### Bool checkFieldRights(String field, String fieldRight)

checkFieldRights()` determines whether the current user has access to a field.

Access pertains to 1 of the following tasks:

* read
* write

```crmscript
Customer c;
c.load(5);

Bool b = c.checkFieldRights("person", "read");
print(b.toString());
```

## User experience

### String makeSalutation()

`makeSalutation()` creates a greeting appropriate for the customer. The string can be used at the beginning of a document or email.

```crmscript!
Customer c;
c.load(3);
printLine(c.makeSalutation());
```

### Void login()

Creates a valid session for the current customer.

To get the session key created by `login()`, call `getValue("loginSessionKey")`.

```crmscript!
Customer c;
c.load(7);
c.login();
printLine(c.getValue("loginSessionKey"));
c.logout();
```

### Void logout()

Logs out a customer.

## Parser variables

Calling `toParser()` will load fields, prefix them with *customer*, and make them available to [templates][2].

> [!NOTE]
> Repeated calls will overwrite rather than append the values in the Parser instance.

```crmscript!
Parser p;
Customer c;
c.load(4);
c.toParser(p);
printLine(p.getVariable("customer.name", 0));
```

<!-- Referenced links -->
[2]: ../../../automation/crmscript/parser-and-templates/reply-template.md
