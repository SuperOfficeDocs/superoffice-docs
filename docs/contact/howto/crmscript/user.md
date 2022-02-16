---
uid: crmscript_class_user
title: User (class)
description: The CRMScript User class and how to create and update customers; get user information
author: Bergfrid Skaara Dias
so.date: 11.02.2021
keywords: CRMScript, ejuser, user, user account
so.topic: concept
---

# User (class)

The **User** CRMScript class represents the following entities:

* Real-life: a user account
* SuperOffice UI: user
* Database table: ejuser

> [!NOTE]
> To get from a user object to a customer or company object, you must go via the **associate** table.

## Security

### Bool isAdministrator()

Checks whether the user is an administrator.

### Bool isLoggedIn(Integer origin)

Checks if the user is signed to the given endpoint.

* 1 = soap interface
* 2 = web pages

```crmscript
print(u.isLoggedIn(2).toString());
```

### Bool hasTicketAccess(Integer ticketId, Integer accessLevel)

Checks whether the user meets the access level for a ticket.

| Access level | Ticket action |
|:------------:|---------------|
| 0            | List          |
| 1            | Read          |
| 2            | Edit          |

```crmscript
print(u.hasTicketAccess(42,1).toString());
```

## User experience

The **activeuser** table holds info about currently signed-in users. Use it to look up who is signed in, at what location, and so on.

> [!WARNING]
> Changing this table **might prevent users from signing in!** Fixing it requires intervention by SuperOffice support. Consider it a read-only table!

## Parser variables

Calling `toParser()` will load fields, prefix them with *user*, and make them available to [templates][2].

```crmscript!
Parser p;
User u;
u.load(2);
u.toParser(p);
printLine(p.getVariable("user.username", 0));
```

<!-- Referenced links -->
[2]: ../../../automation/crmscript/parser-and-templates/reply-template.md
