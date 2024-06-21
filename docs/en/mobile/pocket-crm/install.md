---
title: Install - online
uid: install_pocket_online
description: How to install and configure the CRM Pocket client
author: {github-id}
keywords:
topic: howto
envir: cloud
client: pocket
---

# How to install and configure the CRM Pocket client

Pocket CRM is included in Onsite Subscription and you can just download and install the Pocket CRM app. If you have an Onsite Buy license type, see the [deployment guide][2].

## Online

Pocket CRM can't log in to SuperOffice version 10 and later. You need to upgrade to [Mobile CRM][1] to benefit from the latest features.

## Onsite

1. Follow the process in Play Store/App Store for downloading and installing the application and **wait for the installation to finish before opening the application.**

    [![Get it on Google Play](../../../media/google-play-badge.png "Get it on Google Play")][4]

    [![Get it on Apple App Store](../../../media/download-on-appstore.png "Get it on Apple App Store")][5]

2. Open the installed application on your mobile device.

3. The first time you start the app, you will be asked to configure what type of environment your SuperOffice server is using. Choose **SuperOffice CRM**.

    ![x -screenshot][img4]

4. You must now set the URL in the app to connect it to the server by setting the *connection URL / connection string / URL to your Pocket server / NetServer installation*:

    ![x -screenshot][img5]

    Your administrator should know where to find this URL.

5. Sign in with the same username and password you use for the SuperOffice CRM and you are ready to use SuperOffice Pocket CRM!

## Reset the Pocket CRM client

If you need to either reset the settings or configure the client with another connection URL you can delete the settings by uninstalling the app then install it again - then you will be asked to choose how to connect (CRM Online / Onsite) once more.

<!-- Referenced links -->
[1]: https://online.superoffice.com/mobile
[2]: deploy.md
[4]: https://play.google.com/store/apps/details?id=no.superoffice.pocket.j2me.SuperOffice
[5]: http://itunes.apple.com/no/app/superoffice/ce/id445355343

<!-- Referenced images -->
[img4]: media/install-onsite.jpg
[img5]: media/set-url.png
