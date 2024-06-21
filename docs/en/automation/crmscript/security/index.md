---
uid: crmscript-security
title: Security
description: Security and access control in CRMScript.
author: Bergfrid Skaara Dias
date: 02.16.2022
keywords: CRMScript, security, user, access control
topic: concept
---

# Security

Don't assume that a user has access to everything. It is good practice to look up access rights before revealing or altering information about a person or company.

The **activeuser** table holds info about currently signed-in users. Use it to look up who is signed in, at what location, and so on.

> [!WARNING]
> Changing this table **might prevent users from signing in!** Fixing it requires intervention by SuperOffice support. Consider it a read-only table!

## Bool isLoggedIn(Integer origin)

Checks if the user is signed to the given endpoint.

* 1 = SOAP interface
* 2 = web pages

```crmscript
User u;
u.load(2);
print(u.isLoggedIn(2).toString());
```

## Void login()

Creates a valid session for the current customer.

To get the session key created by `login()`, call `getValue("loginSessionKey")`.

```crmscript!
Customer c;
c.load(7);
c.login();
printLine(c.getValue("loginSessionKey"));
c.logout();
```

## Void logout()

Logs out a customer.

## Bool isAdministrator()

Checks whether the user is an administrator.

## Bool checkTableRights(String tableRight)

`checkTableRights()` determines whether the current user has access to something.

Access pertains to one of the following tasks:

* select
* update
* insert

**Customer (person):**

```crmscript!
Customer c;
c.load(5);

Bool b = c.checkTableRights("select");
printLine(b.toString());
```

**Company (contact):**

```crmscript!
Company c;
c.load(2);

Bool b = c.checkTableRights("select");
printLine(b.toString());
```

## Bool checkFieldRights(String field, String fieldRight)

`checkFieldRights()` determines whether the current user has access to a field.

Access pertains to 1 of the following tasks:

* read
* write

**Customer (person):**

```crmscript
Customer c;
c.load(5);

Bool b = c.checkFieldRights("person", "read");
print(b.toString());
```

**Company (contact):**

```crmscript
Company c;
c.load(2);

Bool b = c.checkFieldRights("contact", "read");
print(b.toString());
```

## Bool hasTicketAccess(Integer ticketId, Integer accessLevel)

Checks whether the user meets the access level for a ticket.

| Access level | Ticket action |
|:------------:|---------------|
| 0            | List          |
| 1            | Read          |
| 2            | Edit          |

```crmscript
print(u.hasTicketAccess(42,1).toString());
```

<!-- Referenced links -->
