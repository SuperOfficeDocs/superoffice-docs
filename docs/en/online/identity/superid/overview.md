---
title: SuperID
uid: superid
description: "Introduction to SuperID, identity providers, and federated sign-in."
author: Bergfrid Dias
date: 02.02.2022
keywords: SuperID, federation gateway, identity provider
content_type: concept
index: true
---

# SuperID

SuperID is a sign-in service and a federation gateway towards the identity providers.

The [SuperID sign-in service][1] has 2 levels - basic and federated. Either with a SuperOffice password or delegated to an [identity provider (IdP)][2].

![Golden key -screenshot][img1]

## How does SuperID change my daily tasks?

For a **standard user**, there is not much difference at all. You'll notice a small change in the sign-in dialog and you can't ask an administrator to [reset your password][3] for you.

With SuperID, SuperOffice **administrators** can no longer set passwords manually in the Admin client. If an identity provider is set, they must also use the [domain-specific usernames (UPNs)][2] when adding new users.

## Can I turn off SuperID?

Moving to the new SuperID platform is a **one-way process**.

What we *can* do, is to turn off federated sign-in for *new** users. If we **disconnect your IdP**:

* **New users** will not be asked to sign in with the IdP.
* **Existing users** who already use IdP will continue to use IdP.

> [!TIP]
> Contact Support if you need to disconnect from an IdP.

## Can I swap between using IdP and SuperID password?

When you register an identity provider for a domain name, users of this domain will be asked to sign in with the IdP the 1st time they access SuperOffice.

After the connection between a user and an IdP has been established, you need to disconnect from the IdP to revert to using SuperOffice passwords. **This will only affect new users!**

## In SCIM

SuperID is used for authenticating both the administrator configuring the [Identity Manager Gateway][4] and users signing in to the system.

The user [accounts provisioned via SCIM][5] are by definition [federated IDs][2] and use the [SuperID - federated sign-in service][1].

## Continue reading

* [User accounts and passwords][6]
* [Authentication with WebTools, MailLink, and Pocket][8]

<!-- Referenced links -->
[1]: sign-in-services.md
[2]: ../federated-id-and-identity-providers.md
[3]: ../user/reset-password.md
[4]: ../scim/identity-management-gw.md
[5]: ../scim/user-provisioning.md
[6]: user-accounts-and-passwords.md
[8]: superid-webtools-maillink-pocket.md

<!-- Referenced images -->
[img1]: media/imagenstf.png
