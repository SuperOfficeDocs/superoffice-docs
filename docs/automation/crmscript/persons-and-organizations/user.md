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

## Create and update customers

### Void setValue(String column, String Value)

Sets a named field to the given value. Look up names in the reference section down below, or check out the [class reference][1].

> [!NOTE]
> Both parameters are strings! Remember to use quotes even for IDs.
>
> You must call `save()` after setting all applicable values to actually create or update the company.

```crmscript
User u;
u.load(9);
u.setValue("email", "bob@example.com");
u.save();
```

### Integer save()

Saves a new or updated user and returns its ID.

* If the ID is set before calling `save()`, it's an update.
* If the ID is empty, it's a create.

```crmscript!
User u;
u.setValue("firstname", "Sam");
printLine(u.save().toString());
```

## Get user info

### Bool load(Integer id)

Brings up the user with the given ID. This is always the 1st step when you want to do anything with an existing user.

```crmscript
User u;
u.load(9);
```

### Bool loadFromAgentAndKey(Integer id, String Key)

Brings up the user that is owned by the agent and matches the external key.

> [!CAUTION]
> `loadFromAgentAndKey()`might overwrite existing values!

### String getValue(String colName)

Fetches the value from a named field. Look up names in the reference section down below.

```crmscript!
User u;
u.load(8);
printLine(u.getValue("firstname"));
```

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

## Reference

### Frequently used values

| Parameter    | Db field    | Description                       |
|:-------------|:------------|:----------------------------------|
| id           | id          | ID (primary key)                  |
| username     | username    | Unique username or uid            |
| profileId    | profoile_id | The user's profile (profile.id)   |
| firstname    | firstname   | The first name of the person      |
| lastname     | lastname    | The last name of the person       |
| email        | Email       | 1 or more                         |
| ownerCompany |             | The ID of the company linked to user's person entity |
| group        | usergroup   | The primary group for the user    |
| status       | status      | Status<br>active (1), not present(2), deleted (3) |
| language     | language    | The user's language<br>("no" or "en") |

### Sign-in info

| Parameter        | Db field           | Description                                |
|:-----------------|:-------------------|:-------------------------------------------|
| loginAttempts    | login_attempts     | How many times the user has tried to sign in with an incorrect password |
| lastLoginAttempt | last_login_attempt | The last time the user tried to sign in but failed |
| idleTime         | idle_time          | Duration in seconds the user has been idle |

### User flags and access flags

**User flags** represent preferences. For example, Use24HrsClock = 10.

**Access flags** represent what a user may do. For example, AccessDocuments = 8.

### Ticket notifications

Notifications (pop-up warnings) to the user are controlled by a bit mask.

| Value | Description            |
|:-----:|------------------------|
| 1     | NewTicket              |
| 2     | NewTicketMessage       |
| 3     | TicketEscalated        |
| 4     | TicketActivated        |
| 5     | ActiveTickets (filter) |
| 6     | TicketTakeOver         |
| 9     | Hotlist (filter)       |
| 10    | Custom                 |

Learn more about [tickets][3].

<!-- Referenced links -->
[1]: <xref:CRMScript.Native.User.setValue(String,String,String)>
[2]: ../parser-and-templates/reply-template.md
[3]: ../requests/tickets.md
