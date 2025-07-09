---
uid: identity_management
title: Identity management
description: All you need to know about identity management in SuperOffice CRM Online.
author: frodeb@superoffice.com
date: 01.15.2024
content_type: concept
keywords: SuperID, IdP, Microsoft Entra, ME-ID, AAD
index: true
---

# Introduction to SuperOffice identity management

All you need to know about identity management in SuperOffice CRM Online: Creating new user accounts; resetting passwords; federated IDs; identity providers; single sign-on; automatic user provisioning with SCIM; and what's the fuzz about SuperID?

We have been moving customers to [SuperID][1] for a while to standardize sign-in services and modernize the platform. It also strengthens security and resolves some of the username/password issues we have experienced in the past.

SuperID is a [sign-in service][2] and a federation gateway towards the identity providers. The SuperID sign-in service has 2 levels - basic and federated. Either with a SuperOffice password or delegated to an [identity provider (IdP)][3].

The sign-in service determines **how** you get access to SuperOffice CRM Online and **who** manages your credentials.

> [!TIP]
> Federated IDs make it easier for the user to sign in and increase the security of your identity management solution.

## Terminology

**Tenant -** the instance in SuperOffice CRM Online serving a customer. Sometimes simply referred to as **customer** or **customer installation** in light-weight and user-facing documentation. If an online system has multiple instances (such as SuperOffice CRM Online), we commonly say it is [multi-tenant][4].

**Identity provider (IdP) -** [federated identity][3] is a generic term for establishing a person's digital identity by delegating to a trusted 3rd party as opposed to a centralized domain of trust. It refers to where the user stores their credentials.

The trusted 3rd party is the **identity provider** (IdP). When accessing a new service, you have probably been presented with **Sign in with Facebook** or **Sign in with Google** as an alternative to creating a new user account. For you as a user, this means that you can **use your existing account** to sign in to multiple services - fewer passwords to remember.

**Password hash -** we never store actual passwords, not even the encrypted version of them, in the CRM database or SuperID. Instead, we store a hash - an encrypted value that we **can use to validate a password**. We calculate the hash based on an industry-standard algorithm and store the random-looking string of characters. The transformation from a human-readable entered password to a hash is a **one-way operation**: we can't reconstruct the password, so resetting a password means generating a new hash for a new password.

**SCIM -** a common language used to describe what an identity is and how to handle it. With SuperOffice you can use SCIM to automate user provisioning from Microsoft Entra ID (formerly Azure Active Directory).

<!-- Referenced links -->
[1]: superid/overview.md
[2]: superid/sign-in-services.md
[3]: federated-id-and-identity-providers.md
[4]: superid/primary-tenant.md
