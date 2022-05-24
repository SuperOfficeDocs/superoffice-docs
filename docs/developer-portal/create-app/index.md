---
title: Register an app
uid: dp-register-app
description: Registering a new app in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 05.18.2022
keywords: Developer Portal, app
so.topic: howto
so.version:
so.envir: cloud
so.client:
---

# Register an app

![Partner overview -screenshot][img1]

## Overview

1. In the Developer Portal, go to your partner page.

2. In the **Applications** section, click **Create App**.

3. Choose a template and whether this is a custom or standard app. Click **Next**.

    ![Create application wizard -screenshot][img2]

4. Enter the name of your application. Click **Next**.

    ![Enter application name -screenshot][img3]

5. Enter one or more redirect URLs - one per line. Click **Next**.

    ![Enter redirect URL -screenshot][img4]

6. Specify integration points  if applicable.

7. Set the technical contact for your app.

    ![-screenshot][img5]

8. Click **Create Application**.

You can now request to publish the configuration.

![App registration complete -screenshot][img6]

For standard apps, you can [start working on the App Store information][11].

## Types of apps

When registering an application, you can choose from five predefined templates that will prompt you for the required settings. Alternatively, you can choose to start with an empty set and fill in what you need.

* [Web application][12]
* [Native application][13]
* [Server-to-server application][14]
* [Custom database mirroring application][15]
* [Standard ERP sync and quote application][16]

## Get keys

After [signing up for a developer account][1], you need to register your application idea to get your unique client ID and client secret so you can start coding.

If you have registered the application but lost the keys, you need to [look up your ID][7] and [create a new secret][8].

## Read more

* [Getting started][1]
* [Application environments][3]
* [User contexts][4]
* [Provisioning][5]
* [Redirects][6]

## What would you like to do?

* [Get access to SOD][2]
* [Check what your client ID is][7]
* [Create a new client secret][8]
* [View or change CORS and redirection URLs][9]
* [Add a certificate][10]

<!-- Referenced links -->
[1]: ../../apps/getting-started/index.md
[2]: ../../apps/getting-started/get-access-to-sod.md
[3]: ../../apps/getting-started/app-envir.md
[4]: ../../apps/getting-started/user-contexts.md
[5]: ../../apps/provisioning/index.md
[6]: ../../apps/redirects/index.md
[7]: ../security/find-clientid.md
[8]: ../security/get-client-secret.md
[9]: ../security/cors-and-redirection-urls.md
[10]: ../security/new-certificate.md
[11]: ../app-store/update-app-page.md
[12]: web-app.md
[13]: native-app.md
[14]: server-to-server-app.md
[15]: mirror-app.md
[16]: sync-app.md

<!-- Referenced images -->
[img1]: ../media/partner-overview.png
[img2]: media/create-app-wizard.png
[img3]: media/enter-app-name.png
[img4]: media/enter-redirect-urls.png
[img5]: media/select-technical-contact.png
[img6]: media/request-publish-stage.png
