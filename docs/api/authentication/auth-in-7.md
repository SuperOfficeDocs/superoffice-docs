---
title: Authentication in SuperOffice 7
uid: auth_in_7
description: Authentication in SuperOffice 7
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
---

# Authentication in SuperOffice 7

Authentication was completely redesigned and rewritten in version 7. This impacts all our applications and is **a breaking change**.

Both the APIs (syntax) and the content and behavior (semantics) have been changed. Simple recompilation will in many cases not be enough. Adaptation to the new scheme is probably not going to mean a lot of work, but something will have to be done.

## In a nutshell

* Single, common database user

* Password no longer stored reversibly

* Plugin-based, open-ended, authentication system

* Safe, password-free, re-authentication tickets for web requests and identity transfer

* No encrypted information in the associate record anymore

* No re-encryption during replication

* Industry-standard algorithms for encryption, hashing, and signing

* **Everything is NetServer-based**

## Why

### Security

The old system stored passwords using reversible encryption. This is inherently insecure (and obsolete) and code reflection makes it impossible to hide the method. It is a no-no, but as long as you’re using username+password to re-authenticate (think of the old NetServer Secret), you have no choice. That is one reason why the changes are so pervasive and breaking – it all hangs together.

### Flexibility

The world used to be simple: each system had its own user/password concept. No more – people expect and require integrations, policies, control, and more.

### Integration

Integration with Active Directory (Windows) is a feature of SuperOffice, and we needed a way to implement it, in a first-class manner and not as a by-product of some ODBC setting. The concepts we use are in line with Windows Identity Foundation.
