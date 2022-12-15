---
title: Authentication
uid: auth_breaking_changes_7
description: Changes in SuperOffice 7 - authentication
author: {github-id}
keywords: authentication, secret, ticket
so.topic: concept
so.envir: onsite
# so.client:
---

# From secret to ticket

Authentication was completely redesigned and rewritten in version 7. This impacts all our applications - Win, Web, modules, web services, partner apps ... Everything - and is **a breaking change**.

> [!NOTE]
> The current authentication scheme is described in the [introduction to onsite authentication][1]. This section applies only if you have a **6.x installation** and customizations that use a secret to authentication.

Both the APIs (syntax) and the content and behavior (semantics) have been changed. Simple recompilation will in many cases not be enough. Adaptation to the new scheme is probably not going to mean a lot of work, but something will have to be done.

Making a ticket string acceptable wherever a user name is requested is a way to minimize the impact on other software. Instead of having to write special calls to authenticate using tickets, you simply stuff it into the user name and go. Command-line parameter to SOCRM? Sure!

Tickets are stored in the Credentials table. We no longer use `Associate.reserved`.

> [!NOTE]
> Changing authentication method is like changing your socks – it may get you into your Club or not, but it doesn’t really change who you are inside of SuperOffice. Remember that a SuperOffice identity is an associate, and those are not affected by authentication changes. Only how you convince the system you are that associate changes. So you can play with this safely, as much as you want.

[Learn how to authenticate with tickets.][1]

## Why

### Security

The old system stored passwords using reversible encryption. This is inherently insecure (and obsolete) and code reflection makes it impossible to hide the method. It is a no-no, but as long as you’re using username+password to re-authenticate (think of the old NetServer Secret), you have no choice. That is one reason why the changes are so pervasive and breaking – it all hangs together.

### Flexibility

The world used to be simple: each system had its own user/password concept. No more – people expect and require integrations, policies, control, and more.

### Integration

Integration with Active Directory (Windows) is a feature of SuperOffice, and we needed a way to implement it, in a first-class manner and not as a by-product of some ODBC setting. The concepts we use are in line with Windows Identity Foundation.

Read more about using the API to perform authentication in the [overview][2].

<!-- Referenced links -->
[1]: index.md
[2]: ../overview.md
