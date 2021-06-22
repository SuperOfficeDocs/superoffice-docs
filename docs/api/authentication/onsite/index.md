---
title: Authentication
uid: auth_onsite
description: Authentication in SuperOffice onsite
author: {github-id}
keywords: authentication, ticket, credentials
so.topic: concept
so.envir: onsite
# so.client:
---

# Authentication

## In a nutshell

* Single, common database user
* Password no longer stored reversibly
* Plugin-based, open-ended, authentication system
* Safe, password-free, re-authentication tickets for web requests and identity transfer
* No encrypted information in the associate record anymore
* No re-encryption during replication
* Industry-standard algorithms for encryption, hashing, and signing
* **Everything is NetServer-based**

## Chain of trust

Authentication is based on a **chain of trust**

* We trust ourselves

* We trust Active Directory

* We trust code that is signed in a certain way

  * If Active Directory says that **it** knows who the current user is, then **we** trust that statement and believe we are interacting with that user.

  * **How** AD knows, is unknown to us. For example, we never, ever, see the user's password. Or fingerprint. Or smart card. Or whatever – we do not and cannot care: this is an important principle.

Chain of trust is an essential concept. Look up Kerberos for a good example. I trust Kerberos to authenticate me, the server trusts Kerberos / the server trusts me.

It’s the same as getting an ID in real life: the bank is not rechecking how you got your driver’s license, it simply trusts it. You don’t go through life arguing about your identity at every corner – you invoke a chain of trust (often implicitly), from you, through some middleman, to whomever you want to trust you right now.

## Credentials to identity

Authentication is based on **credentials** – evidence that the user must provide to prove identity.

Something – possibly more than one system – evaluates user credentials:

* Credentials must prove an identity (be verifiable).
* The identity must be mapped to an associate ID.
* In SuperOffice, **an associate ID is an identity marker**.

During the evaluation of credentials, an identity must result, and no-one must vote against admittance.

> [!NOTE]
> Evaluation is performed by **NetServer** and **trusted plugins** – only. No other code has the authority to authenticate users.

## Credentials must be verifiable

A Windows identity is signed by the system in a way that hardens it against tampering, so we can trust it. And AD forced you to present some convincing evidence before trusting you. A password is hashed, and the hash is compared against something stored in the database. Since that is often a complicated process, it makes sense to delegate it to a specialist, like AD.

The credentials are [processed by plugins][2] in a particular order:

1. Ticket
2. Username/password
3. WindowsUser
4. Impersonation
5. Anonymous
6. UsernameAsDomain
7. WindowsNonPerson.

## The standard flow of authentication/identity

1. Try to authenticate without parameters
    * Rely on *environment*, such as your current Windows login, and possible other implicit knowledge.
2. If unsuccessful, present a login dialog and authenticate using username and password
    * If successful, then we’re in!
    * Otherwise, retry until successful.

> [!NOTE]
> We can authenticate without ever seeing a password in a SuperOffice dialog. NetServer contains two authentication plugins – one for username/password; one for Active Directory.

All SuperOffice applications will follow the same pattern. Both Win and Web will first try, then ask for credentials (username/password), then try again. However, if you specify a username and password on the command line to the *Windows client*, then that is an override of the ordinary logic.

Read more about the [processing pipeline][2].

## The ticket

SuperOffice is much more than one application:

* Web -> Batch ->  Reporter ->  OLE DB Provider
* Windows ->  Portal ->  Web Panel ->  Partner app
* Web ->  request ->  next request ->  next request ...

We need to "bring with us" the authenticated users’ identity, in a way that does not reveal too much. **A ticket** is a string that proves that you are currently authenticated, without revealing who you are or how you got there.

* Like a paper ticket, it is only valid if it has a **stub**.
* The stub is in the database and is put there when the ticket is issued.
* A ticket itself does not contain a user ID.
* If you can see the database, then you still can’t falsify valid tickets. A ticket cannot be deduced from the database.
* If you can write to the database ... But if you can do that, then you already have all the access you need.

> [!NOTE]
> A ticket does not contain the user’s password or anything else that is intelligible – it’s just a ticket.

### What's in a ticket?

Tickets are base-64 encoded. If you unpack one, you will see something like {3F2504E0-4F89-11D3-9A0C-0305E82C3301};1254895 – and that is all. Essentially we have 2 random numbers – one is very large (the [GUID][1]), the other is smaller.

We use the GUID to find the stub in the credentials table, and the other number to match a hash in the same row. You can’t reconstruct the ticket from the hash (one-way street!), but you can get the hash from the ticket. By itself, the ticket doesn’t tell you anything useful, which is by design.

If you want information from a ticket, give it to NetServer for authentication. If you succeed, you know who you are; otherwise, you’re out of luck.

At any time that you are authenticated with NetServer, you can get a ticket:

```csharp
SoContext.CurrentPrincipal.GetSafeCredentials()
```

This is also the return value of the Authenticate WebService methods and the `<usec>` template variable.

Later on, you can pass in the ticket in a WebRequest header

### Ticket as username

You can also send it in, as the username. This means that any place that takes username/password, ticket/blank will work This applies to Windows and Web equally – main clients, OLE DB, URL authentication, and so on.

Multiple `GetSafeCredentials()` calls within the same process and validity period will return the same ticket. Remember that a ticket represents an identity, NOT a particular session (again, that is by design). It is quite OK for multiple sessions to share one ticket, they will just push the validity ahead of them.

Making a ticket string acceptable wherever a user name is requested is a way to minimize the impact on other software. Instead of having to write special calls to authenticate using tickets, you simply stuff it into the user name and go. Command-line parameter to SOCRM? Sure!

### Duration

The ticket stub is timestamped and valid for 6 hours (in the database). Every time a ticket is used, it is renewed to the full 6 hours. We also log a bit about how it was used and you can have as many tickets as you want. We cache them and do not issue new ones every time you ask, this keeps the number of tickets at a manageable level.

Expired tickets cannot be renewed. They will be deleted in due course (typically when you use a valid ticket, we fire off a thread to clean up)

## Credentials table

Tickets are stored in the `Credentials` table. It holds **outgoing** credentials (such as mail server logins for CRM.Web), **incoming** credentials (password, SID), and tickets as types. Custom plugins can add their own information.

![Credentials table][img1]

A checksum column prevents tampering (not shown here) – simply put: change anything important, and the row becomes invalid.

Rows are bound to the database. Copying to another database will not work.

For the time being, a user can have either password or AD authentication. The database model is not limited, but the software is. Allowing multiple credentials could potentially be quite confusing.

`LastUsed` provides a peek at what is going on and from where. Depending on the application you can get more or less information, and it is updated on every (re)authentication. It’s easy to imagine a "who is on" tool leveraging this info, but remember that the same ticket can be passed to multiple places/apps/processes, so it’s not as detailed as you might want.

### Example

| Id | Assoc | Type | SearchName | Secret | ValidFrom | ValidTo | LastUsed |
|---|---|---|---|---|---|---|---|
| 92 | 104 | CRM5/PASSWORD | ADM0 | 7P:DnYq1bcQ9eys2z9WkgpxYBpP63M= | 2010-05-11 00:00:00 | 9999-12-31 23:59:59 | SUPEROFFICE_ASA\marekv on DEV-MAREK-2: SOCRM.exe (Logging in to SuperOffice CRM) |
| 93 | 17 | Ticket | d3989fc9-4d3a-44da-8f5b-85b0456103ef | 7S:IA087dxXBlSDMkRPqbigesOiIQA= | 2010-05-13 07:09:20 | 2010-05-14 13:09:20 | |
| 96 | 105 | ActiveDirectory | S-1-5-21-2132039509-1139229262-60295696-6555 | | 2010-05-14 00:00:00 | 9999-12-31 23:59:59 | |

<!-- Referenced links -->
[1]: http://en.wikipedia.org/wiki/Globally_Unique_Identifier
[2]: pipeline.md

<!-- Referenced images -->
[img1]: media/image001.gif
