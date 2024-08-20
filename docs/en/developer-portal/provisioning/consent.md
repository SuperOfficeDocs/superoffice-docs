---
title: Consent to app
uid: provisioning-consent
description: "Learn about the tenant-approval sequence and when the customer's admin must authorize the application."
author: Margrethe Romnes
date: 12.20.2023
keywords: provisioning, apps, consent, I approve
topic: concept
envir: cloud
client: online
---

# Consent

During the [provisioning][5] of your application, the customer's administrator **must** authorize the application. This is done to secure each customer tenant in the online environment and **it is a requirement**, not optional.

> [!NOTE]
> Only a tenant user with administrator rights is allowed to approve online applications, both for standard and custom application types. Specifically, an administrator is someone with **General Administrator** or **User Administrator** function right.

The SuperOffice Operation Center stores information about when the application was authorized and which user clicked **I approve**.

The workflow is different for custom and standard applications.

## For custom applications

[!include[Activate app](../includes/explicit-consent.md)]

## For standard applications in the App Store

The [tenant administrative user must sign in to SuperID and approve the application][6] to establish an **authorization record** between the application and the tenant. If this option is unavailable to you, a strict hand-shake flow must be implemented.

### <a id="hand-shake"></a>Tenant approval sequence (hand-shake)

No one **may** ask for a customer's username and password to gain access to the tenant's resources. Everyone must adhere to the following authorization sequence.

![Authorization sequence -screenshot][img1]

### Post-approval

The user who approved the application appears in the App Store with the date the application was added.

![image5n4c.png -screenshot][img2]

> [!NOTE]
> A customer's administrator may authorize the application by clicking a link that includes your client ID. This will show the [consent dialog][6] for the application and as an administrator, they may click **I approve**.

## Is consent a one-time action?

No. The application must be approved in [each environment][2].

Some changes will require the customer's administrator to re-approve the application before it gets access to the database after the change.

**Re-approval is mandatory when:**

* your application initially runs in the application [user context][3] and you want to run as the **system user**
* you want to add **Webhooks** to an existing application
* you want to add [database mirroring][4] to an existing application

During approval, the customer's administrator should accept the following change if prompted:

> from: sentry prevents a user from seeing what they should see
> to: full access to everything in a customer database

<!-- Referenced links -->
[2]: ../getting-started/app-envir.md
[3]: ../getting-started/user-contexts.md
[4]: ../../mirroring/overview.md
[5]: index.md
[6]: get-consent.md

<!-- Referenced images -->
[img1]: media/appvendorconsultants.png
[img2]: media/installed-apps.png
