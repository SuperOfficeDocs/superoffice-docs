---
uid: tenant-get-consent
title: Get consent to access a customer's tenant
description: How to obtain consent to access a customer's tenant
author: Margrethe Romnes
so.date: 09.07.2023
keywords: tenant, consent, approve
so.topic: howto
so.envir: cloud
so.client: online
---

# Get consent to access a customer's tenant

Each customer is responsible for their data and must explicitly approve each and every application that shall have access to their database in the production environment.

> [!CAUTION]
> External consultants **MAY NOT** approve access to a customer's production database!

1. Send the administrator to the authorization endpoint and [authenticate the user][1].

2. The administrator clicks **I approve**. The dialog shows your application name, your company name, and other information relevant to the [consent][2].

    ![Consent -screenshot][img1]

3. Provision the application.

## Potential errors

You are unable to complete providing consent (Approve) to the application.

![img2][img2]

This means that SuperOffice Operations Center does not recognize your user as an administrator.

### How to resolve 'account does not have access' error

You can resolve this issue by signing in to SuperOffice, navigate to settings and maintenance (admin), then make a change to the user like user level or role and then save. Next, change back and save again.

Your user is now able to successfully approve the application.

<!-- Referenced links -->
[1]: ../../api/authentication/online/sign-in-user/index.md
[2]: consent.md

<!-- Referenced images -->
[img1]: media/superid-approve.png
[img2]: media/no-access-error-page.png
