---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: changes_7_auth       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Changes in SuperOffice 7 - authentication # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Authentication

Authentication was redesigned and rewritten in SuperOffice 7.

This impacts all our applications – Win, Web, modules, web services, partner apps ... Everything
A breaking change – simple recompilation will in many cases not be enough.

Authentication is based on credentials – evidence that the user must provide to prove identity

Credentials must prove an identity (be verifiable) and the identity must be mapped to an associate ID. In SuperOffice, an identity is an associate ID.

During evaluation of credentials, exactly one identity must result, and no-one must vote against admittance. Evaluation is performed by NetServer and trusted plugins – only. No other code has the authority to authenticate.

**The standard flow of authentication/identity:**

* Try to authenticate without parameters I.e., rely on "environment", such as your current Windows login
* If this does not work, present a login dialog; then try to authenticate using this username and password If success, then we’re in, otherwise, retry a few times and then give up

> [!NOTE]
> We can authenticate without ever seeing a password in a SuperOffice dialog. NetServer contains two authentication plugins – one for username/password; one for Active Directory.

NetServer contains two authentication plugins – one for username/password and one for Active Directory.

* Each plugin is given all the available evidence (credentials)
* Each plugin can block login simply based on the credential type (you could, for instance, forbid login by certain means)
* Each plugin looks for credentials it understands
* Such credentials are evaluated, for instance, a password is checked against stored information
* Success results in an associate id
* Each plugin is finally given the opportunity to block login – we want to make it relatively easy to terminate access rights

The full potential of this system is not yet leveraged. The grey parts are present in the code, but not currently leveraged; i.e., we’re not actively using them in the standard plugins in 7.0.

SuperOffice is much more than one application:

* Web -> Batch ->  Reporter ->  OLE DB Provider
* Windows ->  Portal ->  Web Panel ->  Partner app
* Web ->  request ->  next request ->  next request ...

We need to "bring with us" the authenticated users’ identity, in a way that does not reveal too much. **The ticket**, a string that proves that you are currently authenticated, without revealing who you are or how you got there.

* Like a paper ticket, it is only valid if it has a "stub"
* The stub is in the database and is put there when the ticket is issued.
* A ticket itself does not contain a user ID
* If you can see the database, then you still can’t falsify valid tickets. A ticket cannot be deduced from the database.
* If you can write to the database ... But if you can do that, then you already have all the access you need.

A ticket does not contain the users’ password or anything else that is intelligible – it’s just a ticket

It’s base-64 encoded. If you unpack it, you will see something like {3F2504E0-4F89-11D3-9A0C-0305E82C3301};1254895 – and that is all. Essentially we have two random numbers – one is very large (the [GUID][1]), the other is smaller.

We use the GUID to find the stub in the credentials table, and the other number to match a hash in the same row. You can’t reconstruct the ticket from the hash (one-way street!), but you can get the hash from the ticket. By itself, the ticket doesn’t tell you anything useful, which is by design.

If you want information from a ticket, give it to NetServer for authentication. If you succeed, you know who you are; otherwise you’re out of luck.
At any time that you are authenticated with NetServer, you can get a ticket:  `SoContext.CurrentPrincipal.GetSafeCredentials()`

This is also the return value of the Authenticate WebService methods, and the `<usec>` template variable

Later on, you can pass in the ticket in a WebRequest header

You can also send it in, as the username

This means that anyplace that takes username/password, ticket/blank will work
This applies to Windows and Web equally – main clients, OLE DB, URL authentication, etc.

Multiple GetSafeCredentials() calls within the same process and validity period will return the same ticket. Remember that a ticket represents an identity, NOT a particular session (again, that is by design). It is quite OK for multiple sessions to share one ticket, they will just push the validity ahead of them.

Making a ticket string acceptable wherever a user name is requested is a way to minimize the impact on other software. Instead of having to write special calls to authenticate using tickets, you simply stuff it into the user name and go. Command-line parameter to SOCRM? Sure!

The ticket stub is timestamped and valid for 6 hours (in the database). Every time a ticket is used, it is renewed to the full 6 hours. We also log a bit about how it was used and you can have as many tickets as you want. We cache them and do not issue new ones every time you ask, this keeps the number of tickets at a manageable level
Expired tickets cannot be renewed. They will be deleted in due course (typically when you use a valid ticket, we fire off a thread to clean up)

Stored in the Credentials table. We no longer use the Associate.reserved is removed. This table is already used for storing outgoing credentials – such as mail server logins for CRM.Web, in 6.x.  In 7 we introduce incoming credentials (password, SID) and tickets as types. Custom plugins can add their own information.

## Credentials table

| Id | Assoc | Type | SearchName | Secret | ValidFrom | ValidTo | LastUsed |
|---|---|---|---|---|---|---|---|
| 92 | 104 | CRM5/PASSWORD | ADM0 | 7P:DnYq1bcQ9eys2z9WkgpxYBpP63M= | 2010-05-11 00:00:00 | 9999-12-31 23:59:59 | SUPEROFFICE\_ASA\\marekv on DEV-MAREK-2: SOCRM.exe (Logging in to SuperOffice CRM) |
| 93 | 17 | Ticket | d3989fc9-4d3a-44da-8f5b-85b0456103ef | 7S:IA087dxXBlSDMkRPqbigesOiIQA= | 2010-05-13 07:09:20 | 2010-05-14 13:09:20 | |
| 96 | 105 | ActiveDirectory | S-1-5-21-2132039509-1139229262-60295696-6555 | | 2010-05-14 00:00:00 | 9999-12-31 23:59:59 | |

> [!NOTE]
> Changing authentication method is like changing your socks – it may get you into your Club or not, but it doesn’t really change who you are inside of SuperOffice. Remember that a SuperOffice identity is an associate, and those are not affected by authentication changes. Only how you convince the system you are that associate changes. So you can play with this safely, as much as you want.

<!-- Referenced links -->
[1]: http://en.wikipedia.org/wiki/Globally_Unique_Identifier
