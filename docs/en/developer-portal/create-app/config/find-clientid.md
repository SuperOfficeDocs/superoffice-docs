---
uid: dp-get-clientid
title: What is my client ID?
description: How to find the client ID for an app in the SuperOffice Developer Portal.
keywords: Developer Portal, app, client ID
author: Bergfrid Dias
date: 07.10.2026
version: 2.0
version_devportal: 2.16
content_type: howto
deployment: online
---

# What is my client ID?

[!include[Define app credentials](../../includes/def-app-credentials.md)]

<!-- markdownlint-disable MD029 -->
[!include[Go to the app page](../../includes/go-to-app-page.md)]
<!-- List starts in the include. Next line MUST be 2. -->
2. Select **Configuration** > **Authentication**

    ![App client ID per environment -screenshot][img1]

<!-- markdownlint-restore -->

Each application has a separate client ID for each environment (SOD, Stage, and Production).

## Regenerate the client ID

The client ID is assigned automatically and **cannot be edited manually**. Next to the client ID for each environment you have two controls:

* <i class="ph ph-copy" aria-hidden="true"></i> **Copy** — copy the client ID to the clipboard.
* <i class="ph ph-arrow-clockwise" aria-hidden="true"></i> **Regenerate** — generate a new client ID for that environment.

> [!WARNING]
> Regenerating changes the identifier your integration uses to authenticate. Update your application with the new client ID afterwards, or sign-in and API calls that rely on the old value will fail.

## Client ID must be unique per environment

The portal validates that a client ID is not already used by another application in the same environment. If a duplicate is detected, the field shows an error and you must regenerate the client ID until it is unique before you can save:

*This Client ID is already in use by another application.*

![Client ID in use by another application, with copy and regenerate controls -screenshot][img2]

## Read more

* [Application environments][3]

<!-- Referenced links -->
[3]: ../../getting-started/app-envir.md

<!-- Referenced images -->
[img1]: media/clientid-per-envir.png
[img2]: media/clientid-in-use.png
