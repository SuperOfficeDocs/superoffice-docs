---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: upgrade_webtools       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Hide Web Tools download dialog # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite               # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Hide Web Tools download dialog

SuperOffice WebTools upgrade dialog can be suppressed by configuration in *web.config*.

## Upgrading

When a user logs in to an updated Web installation, Web Tools will detect there is an updated version available and prompt the user for upgrade. Versioning in SuperOffice is defined as "MAJOR.MINOR.BUILD.REVISION". The user will be "forced" to upgrade if the MAJOR component is higher than the current web tools major version. Other changes are optional upgrades.

The prompt for upgrade can be disabled in scenarios where you don’t want to push a new version of Web Tools. The configuration setting SuperOffice\\Downloads\\WebToolVersion in the *web.config* file can be set to a previous version. The user will still be able to upgrade to the latest version by pressing Download in the web client.

## Client upgrade warnings

Before SuperOffice version 7.5 the client would automatically check what version the server had, and ask the user to upgrade if the server version is newer than the client version. We have changed this functionality from 7.5 and you may now configure on the server if the clients should be asked to upgrade if they have a version older than a specific version.

Open **web.config** on the server where Sales & Marketing web is installed and add the following section in the

```xml
<sectionGroup name="SuperOffice">
...
<section name="Downloads" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
...
```

![x][1]

Now below `</Documents>` add the following new

```xml
<Downloads>
  <add key="WebToolVersion" value="8.0.6004.1310" />
</Downloads>
```

![x][2]

the value must be the same version as the DLL-files in the MSI.

If the value is blank we check against the current version installed on the server. So if you have installed SuperOffice 8.0 SR5 but do not want your clients to be asked to upgrade if they have installed Web Tools 8.0 SR2 you may set 8.0.6004.1310 in WebToolVersion value and the clients will only be prompted to upgrade if they are using a version older than 8.0.6004.1310. If they are using an older version but do not want to upgrade, they may tick the checkbox so it does not ask again. This information is stored in a persistent cookie which lasts till next server update.

Just one reminder:

This should never be the default solution. We release new versions of WebTools because it always contains improvements that solves IMPORTANT issues for our users. In general, we recommend all our users to run the last released version of WebTools. Sometimes it is even critical that users upgrade, and if customers turn this off, it is almost impossible for us to reach them with information that they should upgrade.

If you are unsure which Web Tools version you have, right-click on any DLL starting with SuperOffice in the SuperOffice Mail Link folder and check the Details tab. The version number you are looking for is the Product version.

![x][3]

<!-- Referenced links -->
[1]: media/2018-06-11_11-46-02.png
[2]: media/14503_31826.jpg
[3]: media/2018-12-21_15-33-29.png
