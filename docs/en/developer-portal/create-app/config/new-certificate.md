---
uid: dp-new-certificate
title: New certificate
description: How to create a new certificate for an app in the SuperOffice Developer Portal.
keywords: Developer Portal, app, certificate
author: Bergfrid Dias
date: 02.26.2025
version: 2.0
version_devportal: 2.0
topic: howto
envir: cloud
---

# New certificate

The certificates in your application configuration are **RSA encryption keys**. You need the private key to [sign system user tokens][2] in server-to-server applications and database mirroring.

The Developer Portal stores your public key. However, you must store the private key.

[!include[How to replace value](includes/note-clear-to-replace.md)]

## How to

<!-- markdownlint-disable MD029 -->
[!include[Go to the app page](../../includes/go-to-app-page.md)]
<!-- List starts in the include. Next line MUST be 2. -->
2. Select **Configuration** > **Authentication**.

    ![Secrets and Certificates -screenshot][img1]

3. Click **New Certificate**.

    ![New Certificate dialog -screenshot][img2]

4. Enter a description and expiration, and then click **Add**.

    ![Certificates -screenshot][img3]

    [!include[Expiration ignored](includes/note-expiration.md)]

5. Store the **private key** somewhere safe! You can't look it up in the Developer Portal later.

6. Click **Save Settings**.

7. Request to publish the new configuration.
<!-- markdownlint-restore -->

## Read more

* [Application environments][3]
* [SuperID certificates][1]

<!-- Referenced links -->
[3]: ../../getting-started/app-envir.md
[1]: ../../../api/authentication/online/certificates/index.md
[2]: ../../../api//authentication/online/auth-application/sign-system-user-token.md

<!-- Referenced images -->
[img1]: media/secrets-and-certificates.png
[img2]: media/add-certificate.png
[img3]: media/certificate.png
