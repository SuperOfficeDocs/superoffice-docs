---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: provisioning_consent       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Consent # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Consent

During the provisioning of your application, the customer's administrator **must** [authorize the application][1]. This is done to secure each customer tenant in the online environment, and **it is a requirement**, not optional.

> [!NOTE]
> Only a tenant user with administrator rights is allowed to approve online applications, both for standard and custom application types.

The tenant administrative user must sign in to SuperID and approve the application to establish an **authorization record** between the application and the tenant. If this option is unavailable to you, a [strict hand-shake flow][1] must be implemented.

The SuperOffice Operation Center stores information about when the application was authorized and which user clicked **I approve**.

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
[1]: https://community.superoffice.com/en/developer/create-apps/reference/tenant-approval/
[2]: https://community.superoffice.com/en/developer/create-apps/overview/application-environments/
[3]: https://community.superoffice.com/en/developer/create-apps/concepts/authentication/user-contexts/
[4]: ../mirroring/index.md