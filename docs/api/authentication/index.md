---
title: authentication       
description: Authentication overview
author: {github-id}             # Your GitHub alias.
keywords:
so.date: 05.08.2018
so.topic: concept
---

# Authentication

Authentication, totally redesigned and rewritten in version 7, impacts all SuperOffice applications – Win, Web, Modules, Web Services, partner applications ... Everything!

Read more about using the API to perform authentication on our [Developer Community][1] web site.

## Chain of trust

Authentication is based on a **chain of trust**

* We trust ourselves
* We trust Active Directory
* We trust code that is signed in a certain way
  * If Active Directory says that **it** knows who the current user is, then **we** trust that statement and believe we are interacting with that user.
  * **How** AD knows, is unknown to us. For example, we never, ever, see the user's password. Or fingerprint. Or smartcard. Or whatever – we do not and cannot care: this is an important principle.

Chain of trust is an essential concept. Look up Kerberos for a good example. I trust Kerberos to authenticate me, the server trusts Kerberos / the server trusts me.

It’s the same as getting an ID in real life: the bank is not rechecking how you got your driver’s license, it simply trusts it. You don’t go through life arguing about your identity at every corner – you invoke a chain of trust (often implicitly), from you, through some middleman, to whomever you want to trust you right now.

## Credentials to identity

Authentication is based on **credentials** – evidence that the user must provide to prove identity.

Something – possibly more than one system – evaluates user credentials:

* Credentials must prove an identity (be verifiable)
* The identity must be mapped to an associate ID
* In SuperOffice, **an associate ID is an identity marker**

During the evaluation of credentials, an identity must result, and no-one must vote against admittance.

> [!NOTE]
> Evaluation is performed by **NetServer** and **trusted plugins** – only. No other code has the authority to authenticate users.

### Credentials must be verifiable

A Windows identity is signed by the system in a way that hardens it against tampering, so we can trust it. And AD forced you to present some convincing evidence before trusting you. A password is hashed, and the hash is compared against something stored in the database. Since that is often a complicated process, it makes sense to delegate it to a specialist, like AD.

The credentials are [processed by plugins][2] in a particular order:

1. Ticket
2. Username/password
3. WindowsUser
4. Impersonation
5. Anonymous
6. UsernameAsDomain
7. WindowsNonPerson.

The order is decided by the priority attribute value on the plugin, and the loop breaks on the first one to say "I know who this is!". Read more about the [processing pipeline][3].

### Order of things

The standard flow of authentication/identity is:

1. Try to authenticate without parameters
    * Rely on *environment*, such as your current Windows login, and possible other implicit knowledge
2. If unsuccessful, present a login dialog and authenticate using username and password
    * If successful, then we’re in!
    * Otherwise, retry until successful.

SuperOffice can authenticate without ever seeing a password in a SuperOffice dialog.

All SuperOffice applications will follow the same pattern. Both Win and Web will first try, then ask for credentials (username/password), then try again. However, if you specify a username and password on the command line to the *Windows client*, then that is an override of the ordinary logic.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/content/content/netserver-sdk/archived-articles/superoffice-authentication/
[2]: plugins.md
[3]: pipeline.md
