---
uid: crmscript-create-user
title: Create and update customers
description: How to create and update customers.
keywords: CRMScript, ejuser, user, user account
author: Bergfrid Skaara Dias
date: 15.02.2021
version: 10
topic: howto
---

# Create and update customers

## Void setValue(String column, String Value)

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

## Integer save()

Saves a new or updated user and returns its ID.

* If the ID is set before calling `save()`, it's an update.
* If the ID is empty, it's a create.

```crmscript!
User u;
u.setValue("firstname", "Sam");
printLine(u.save().toString());
```

## Reference

### Frequently used values

| Parameter | Db field | Description |
|:--|:--|:--|
| id           | id         | ID (primary key) |
| username     | username   | Unique username or uid |
| profileId    | profile_id | The user's profile (profile.id) |
| firstname    | firstname  | The first name of the person |
| lastname     | lastname   | The last name of the person |
| email        | Email      | 1 or more |
| ownerCompany |            | The ID of the company linked to user's person entity |
| group        | usergroup  | The primary group for the user |
| status       | status     | Status<br>active (1), not present(2), deleted (3) |
| language     | language   | The user's language, see list below for values |

#### Language values

| Value | Description |
|:-----:|-------------|
| 0 | Norwegian |
| 1 | English |
| 2 | German |
| 3 | Swedish |
| 4 | Danish |
| 5 | Dutch |
| 6 | French |
| 7 | Spanish |
| 8 | Italian |
| 9 | Czech |
| 10 | Finnish |
| 11 | Polish |
| 12 | Russian |
| 13 | Ukrainian |

### Sign-in info

| Parameter | Db field | Description |
|:--|:--|:--|
| loginAttempts | login_attempts | How many times the user has tried to sign in with an incorrect password |
| lastLoginAttempt | last_login_attempt | The last time the user tried to sign in but failed |
| idleTime | idle_time | Duration in seconds the user has been idle |

### User flags and access flags

**User flags** represent preferences. For example, Use24HrsClock = 10.

**Access flags** represent what a user may do. For example, AccessDocuments = 8.

### Ticket notifications

Notifications (pop-up warnings) to the user are controlled by a bit mask.

| Value | Description |
|:-:|---|
| 1 | NewTicket |
| 2 | NewTicketMessage |
| 3 | TicketEscalated |
| 4 | TicketActivated |
| 5 | ActiveTickets (filter) |
| 6 | TicketTakeOver |
| 9 | Hotlist (filter) |
| 10 | Custom |

Learn more about [tickets][3].

<!-- Referenced links -->
[1]: <xref:CRMScript.Native.User.setValue(String,String,String)>
[3]: ../request/create.md
