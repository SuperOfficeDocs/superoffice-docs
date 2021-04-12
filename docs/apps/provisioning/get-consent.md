---
title: Get consent for a customer's tenant
uid: get_consent_for_tenant
description: How to obtain consent to access a customer's tenant
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# Obtain consent to access a customer's tenant

Each customer is responsible for their data and must explicitly approve each and every application that shall have access to their database in the production environment.

> [!CAUTION]
> External consultants **MAY NOT** approve access to a customer's production database!

1. Send the administrator to the authorization endpoint and [authenticate the user][1].

2. The administrator clicks **I approve**. The dialog shows your application name, your company name, and other information relevant to the [consent][2].

    ![Consent][img1]

3. Provision the application.

<!-- Referenced links -->
[1]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/authentication/online/auth-user.md
[2]: consent.md

<!-- Referenced images -->
[img1]: media/superid-approve.png
