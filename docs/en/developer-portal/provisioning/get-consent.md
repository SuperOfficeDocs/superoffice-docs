---
uid: tenant-get-consent
title: Get consent to access a customer's tenant
description: How to obtain consent to access a customer's tenant
author: Margrethe Romnes
date: 12.20.2023
keywords: tenant, consent, approve
topic: howto
envir: cloud
client: online
---

# Get consent to access a customer's tenant

Each customer is responsible for their data and must explicitly approve each and every application that shall have access to their database in the production environment.

> [!CAUTION]
> External consultants **MAY NOT** approve access to a customer's production database!

## For custom applications

[!include[Activate app](../includes/explicit-consent.md)]

## For standard applications in the App Store

1. Send the administrator to the authorization endpoint and [authenticate the user][1].

2. The administrator clicks **I approve**. The dialog shows your application name, your company name, and other information relevant to the [consent][2].

    ![Consent -screenshot][img1]

    [Potential errors][3]

3. Provision the application.

<!-- Referenced links -->
[1]: ../../api/authentication/online/sign-in-user/index.md
[2]: consent.md
[3]: ../faq/unable-to-approve-app.md

<!-- Referenced images -->
[img1]: media/superid-approve.png
