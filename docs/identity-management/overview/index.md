---
title: overview       
description: All you need to know about identity management in SuperOffice CRM Online.                   
author: {github-id}             # Your GitHub alias.
keywords:
---


# Introduction to SuperOffice identity management

All you need to know about identity management in SuperOffice CRM Online. Creating new user accounts; resetting passwords; federated IDs; identity providers; single sign-on; automatic user provisioning with SCIM, and what's the fuzz about SuperID?

We have been moving customers to [SuperID][1] for a while to standardize sign-in services and modernize the platform. It also strengthens security and resolves some of the username/password issues we have experienced in the past.

SuperID is a [sign-in service][2] and a federation gateway towards the identity providers. The SuperID sign-in service has 2 levels - basic and federated. Either with a SuperOffice password or delegated to an [identity provider (IdP)][3].

The sign-in service determines **how** you get access to SuperOffice CRM Online and **who** manages your credentials.

> [!TIP] Federated IDs make it easier for the user to sign in and increase the security of your identity management solution.

## Terminology

**Tenant -** the instance in SuperOffice CRM Online serving a customer. Sometimes simply referred to as _customer_ or _customer installation_ in light-weight and user-facing documentation. If an online system has multiple instances (such as SuperOffice CRM Online), we commonly say it is [_multi-tenant_][4].

**Identity provider (IdP) -** [federated identity][3] is a generic term for establishing a person's digital identity by delegating to a trusted 3rd party as opposed to a centralized domain of trust. It refers to where the user stores their credentials.

The trusted 3rd party is the **identity provider** (IdP). When accessing a new service, you have probably been presented with **Sign in with Facebook** or **Sign in with Google** as an alternative to creating a new user account. For you as a user, this means that you can **use your existing account** to sign in to multiple services - fewer passwords to remember.

**Password hash -** we never store actual passwords, not even the encrypted version of them, in the CRM database or SuperID. Instead, we store a hash - an encrypted value that we **can use to validate a password**. We calculate the hash based on an industry-standard algorithm and store the random-looking string of characters. The transformation from a human-readable entered password to hash is a **one-way operation**: we can't reconstruct the password, so resetting a password means to generate a new hash for a new password.

**SCIM -** a common language used to describe what an identity is and how to handle it. With SuperOffice you can user SCIM to automate user provisioning from Azure AD.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/identity-management/concepts/superid/
[2]: https://community.superoffice.com/en/technical/documentation/identity-management/overview/sign-in-services/
[3]: https://community.superoffice.com/en/technical/documentation/identity-management/overview/federated-id/
[4]: https://community.superoffice.com/en/technical/documentation/identity-management/concepts/primary-tenant/
