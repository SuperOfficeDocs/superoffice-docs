---
title: Upgrade
uid: webtools-upgrade
description: Upgrade WebTools, Hide download dialog
author: {github-id}
keywords: WebTools, upgrade
so.topic: howto
so.envir: onsite
so.client: web
---

# Upgrading

When the user logs in to an updated Web installation, WebTools will detect there is an updated version available and prompt the user for an upgrade. Versioning in SuperOffice is defined as "MAJOR.MINOR.BUILD.REVISION". The user will be "forced" to upgrade if the MAJOR component is higher than the current major version of WebTools. Other changes are optional upgrades.

## Turn off upgrade prompt

The prompt to upgrade can be disabled in scenarios where you don’t want to push a new version of WebTools. The configuration setting [SuperOffice\Downloads\WebToolVersion][1] in the *web.config* file can be set to a previous version. The user will still be able to upgrade to the latest version by pressing Download in the web client.

![Logging in to Sales and Marketing (upgrade) -screenshot][img4]

## Hide WebTools download dialog

SuperOffice WebTools upgrade dialog can be suppressed by configuration in *web.config*.

When a user logs in to an updated Web installation, WebTools will detect there is an updated version available and prompt the user to upgrade. Versioning in SuperOffice is defined as "MAJOR.MINOR.BUILD.REVISION". The user will be "forced" to upgrade if the MAJOR component is higher than the current WebTools' major version. Other changes are optional upgrades.

The prompt for an upgrade can be disabled in scenarios where you don’t want to push a new version of WebTools. The configuration setting `SuperOffice\Downloads\WebToolVersion` in the *web.config* file can be set to a previous version. The user will still be able to upgrade to the latest version by pressing Download in the web client.

## Client upgrade warnings

Before SuperOffice version 7.5 the client would automatically check what version the server had, and ask the user to upgrade if the server version is newer than the client version. We have changed this functionality from 7.5 and you may now configure on the server if the clients should be asked to upgrade if they have a version older than a specific version.

Open *web.config* on the server where Sales & Marketing web is installed and add the following section in the

```xml
<sectionGroup name="SuperOffice">
  ...
  <section name="Downloads" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
  ...
```

![x -screenshot][img1]

Now below `</Documents>` add the following new section:

```xml
<Downloads>
  <add key="WebToolVersion" value="8.0.6004.1310" />
</Downloads>
```

![x -screenshot][img2]

The value must be the same version as the DLL files in the MSI.

If the value is blank we check against the current version installed on the server. So if you have installed SuperOffice 8.0 SR5 but do not want your clients to be asked to upgrade if they have installed WebTools 8.0 SR2 you may set 8.0.6004.1310 in WebToolVersion value and the clients will only be prompted to upgrade if they are using a version older than 8.0.6004.1310. If they are using an older version but do not want to upgrade, they may tick the checkbox so it does not ask again. This information is stored in a persistent cookie that lasts till the next server update.

Just one reminder:

This should never be the default solution. We release new versions of WebTools because it always contains improvements that solve IMPORTANT issues for our users. In general, we recommend all our users to run the last released version of WebTools. Sometimes it is even critical that users upgrade, and if customers turn this off, it is almost impossible for us to reach them with information that they should upgrade.

If you are unsure which WebTools version you have, right-click on any DLL starting with SuperOffice in the SuperOffice Mail Link folder and check the Details tab. The version number you are looking for is the Product version.

![x -screenshot][img3]

## Suppress the dialog in SuperOffice Admin

Since SuperOffice 9 it is possible to suppress the WebTools installation and upgrade dialog in SuperOffice Admin. Go to Preferences - System and check the Offer to install WebTools and Offer to upgrade WebTools options. Once set to 'No' clients will not be offered to install and / or upgrade WebTools.

![Install and upgrade dialog -screenshot][img5]

<!-- Referenced links -->
[1]: ../api/config/downloads.md

<!-- Referenced images -->
[img1]: media/2018-06-11.png
[img2]: media/14503-31826.jpg
[img3]: media/2018-12-21.png
[img4]: media/11035-21656.jpg
[img5]: media/upgrade-preferences.jpg
