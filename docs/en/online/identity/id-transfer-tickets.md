---
title: Tickets and identity transfers
uid: id_transfer_tickets
description: Tickets and identity transfers
author: SuperOffice Product and Engineering
date:
keywords: authentication, user
content_type: concept
deployment: onsite
platform: web
index: true
---

# Tickets and identity transfers

SuperOffice is much more than one application.

* Web -> Reporter -> OLE DB Provider
* Win -> Portal -> Web Panel -> Partner app
* Web -> request -> next request -> next request ...

We need to "bring with us" the authenticated users' identity, in a way that does not reveal too much and that is hard to falsify, steal and misuse.

Identity transfer is **essential** in any non-trivial system because the world is much larger than one program (technically, one process or AppDomain is "one program"). Doing it in a way that is reasonably secure, scalable, and fast is something we cannot do without.

## Identity transfer tickets

We **cannot** reproduce the original authentication because it's quite possible we never saw those credentials! And all the code is effectively public, given Reflection tools.

Enter the **ticket**, a string that proves that you are currently authenticated, without revealing who you are or how you got there. Like a paper ticket, it is only valid if it has a "stub". The stub is in the database and is put there along with the credential record when the ticket is issued. A ticket itself does not contain a user ID. If you can see the database then you still can't falsify valid tickets. A ticket cannot be deduced from the database. If you can write to the database... But if you can do that then you already have all the access you need.

A ticket does not contain a user ID, the user's password, or anything else that is intelligible - it's just a ticket. It's base-64 encoded. When viewed in the database, it's unrecognizable to prevent falsify valid tickets. If you unpack it, you will see something like {3F2504E0-4F89-11D3-9A0C-0305E82C3301};1254895 - and that is all. Essentially we have two random numbers - one is very large (the [GUID][1]), the other is smaller.

We use the GUID to find the stub in the credentials table, and the other number to match a hash in the same row. You can't reconstruct the ticket from the hash but you can get the hash from the ticket. By itself, the ticket doesn't tell you anything useful, which is by design.

If you want information from a ticket, give it to NetServer for authentication. If you succeed, you know who you are and your request will proceed to execute. Otherwise, you’re out of luck.

## Issuing tickets

At any time that you are authenticated with NetServer, you can get a ticket:

```csharp
SoContext.CurrentPrincipal.GetSafeCredentials()
```

This is also the return value of the `Authenticate` web-service methods and the `<usec>` template variable. Later on, you can pass in the ticket in a `WebRequest` header. You can also send it in, as the username.

[!include[Usec Forbidden Online](../../includes/usec-forbidden-online.md)]

* This means that **anyplace** that takes username/password, ticket/blank will work.
* This applies to Win and Web equally - main clients, OLE DB, URL authentication, and similar.

Multiple `GetSafeCredentials()` calls within the same process and validity period will return the same ticket. Remember that a ticket represents an identity, **NOT** a particular session. It is quite OK for multiple sessions to share one ticket, they will just push the validity ahead of them.

Multiple sessions may share one ticket. Tickets have a **sliding expiration**, meaning each time they are used, the valid time is reset.

Making a ticket string acceptable wherever a user name is requested is a way to minimize the impact on other software. Instead of having to write special calls to authenticate using tickets, you simply stuff it into the user name and go. It works also as a command-line parameter to SOCRM.

Supplying a ticket string wherever a user name is requested is a way to minimize the impact on other software. Instead of having to write special calls to authenticate using tickets, you simply use it in place of the user name, even as a command-line parameter to *SOCRM.exe*!

## Ticket renewals

The ticket stub is timestamped and valid for 6 hours (in the database). Every time a ticket is used, it is renewed to the full 6 hours. We also log a bit about how it was used (client name). You can have as many tickets as you want.

* We cache them and do not issue new ones every time you ask.
* This keeps the number of tickets at a manageable level.

Expired tickets cannot be renewed. They will be deleted in due course (typically when you use a valid ticket, we fire off a thread to clean up).

## Credential storage

* The database table Credentials is already used for storing outgoing credentials - such as mail server logins for CRM.Web. In 7 we introduce incoming credentials (password, SID) and tickets as types. Custom plugins can add their information.

* There are checksums to prevent tampering.

* Rows are bound to the database; copying to another database will not work.

* For the time being, a user can have either password or AD authentication; the database model is not limited, but the software is. Allowing multiple credentials could potentially be quite confusing.

* "LastUsed" is quite interesting, in that it provides a peek at what is going on, from where. Depending on the application you can get more or less information, and it is updated on every (re)authentication.

<!-- Referenced links -->
[1]: http://en.wikipedia.org/wiki/Globally_Unique_Identifier
