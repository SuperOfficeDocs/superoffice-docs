---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: issue_ticket       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Issuing tickets # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
so.date: 05.08.2018
keywords: authentication,usec
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Issuing tickets

When authenticated with NetServer, you can get a ticket:

```csharp
SoContext.CurrentPrincipal.GetSafeCredentials()
```

A ticket is also part of the result upon a successful `Authenticate` against WebService, as well as available as a template variable called `<usec>`.

Later on, you can pass in the ticket in a `WebRequest` header

You can also send it in as the username

* This means that **anyplace** that takes username/password, ticket/blank will work
* This applies to Win and Web equally – main clients, OLE DB, URL authentication, and so on

Multiple `GetSafeCredentials()` calls within the same process and validity period will return the same ticket. A ticket represents an identity, **NOT** a particular [session][1].

Multiple sessions may share one ticket. Tickets have a **sliding expiration**, meaning each time they are used, the valid time is reset.

Supplying a ticket string wherever a user name is requested is a way to minimize the impact on other software. Instead of having to write special calls to authenticate using tickets, you simply use it in place of the user name, even as a command-line parameter to *SOCRM.exe*!

<!-- Referenced links -->
[1]: ../session-handling/index.md
