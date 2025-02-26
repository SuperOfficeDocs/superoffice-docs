---
title: Create a new client secret
uid: dp-get-client-secret
description: How to create a new client secret in the SuperOffice Developer Portal.
keywords: Developer Portal, app, client secret, application secret
author: Bergfrid Dias
date: 02.26.2025
version: 2.0
version_devportal: 2.0
topic: howto
envir: cloud
client:
---

# Create a new client secret

[!include[Howto replace value](includes/note-clear-to-replace.md)]

[!include[Define app credentials](../../includes/def-app-credentials.md)] That also means that you can't copy it from the Developer Portal. If it's lost, you need to create a new one.

<!-- markdownlint-disable MD029 -->
[!include[Go to the app page](../../includes/go-to-app-page.md)]
<!-- List starts in the include. Next line MUST be 2. -->
2. Select **Configuration**.

3. Click **New Client Secret**.

    ![Application secret -screenshot][img1]

    [!include[Expiration ignored](includes/note-expiration.md)]

4. Store the secret somewhere safe! You can't look it up in the Developer Portal later.

5. Click **Save Settings**.

6. Request to publish the new configuration.
<!-- markdownlint-restore -->

## Read more

* [Application environments][3]

<!-- Referenced links -->
[3]: ../../getting-started/app-envir.md

<!-- Referenced images -->
[img1]: media/client-secret.png
