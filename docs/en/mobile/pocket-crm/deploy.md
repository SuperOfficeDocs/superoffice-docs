---
title: Deploy onsite
uid: deploy_pocket_onsite
description: Pocket CRM installation and deployment
author: {github-id}
keywords:
topic: howto
envir: onsite
client: pocket
---

# Deployment guide

## Pre-requisites

* [System requirements][1]
* [Client requirements][2]

## Overview

1. Make sure a connection to the server is available (NetServer).
2. Make sure all Pocket CRM users have a Pocket CRM license.
3. Download and install the Pocket CRM App on all devices.
4. Configure **the connection path to the server** on each of the Pocket CRM App.

## Step 1: prepare NetServer

You will need to set up and properly configure the correct version of SuperOffice NetServer.

> [!NOTE]
> Web and Pocket can share NetServer if the Web client does **not** have IIS authentication. The Pocket client does not support AD authentication. Pocket version 8 does not support IIS schemas.

Common issues are the configuration of document archive (SO_ARC) and email server setting. You can verify your NetServer installation using SuperOffice Web. The Pocket CRM client is installed on phones that access this server over the internet and must be able to reach this server host. The address for NetServer URL will be like this:  `http://servername.youcompany.com/NetServer/sevices80/`

> [!NOTE]
> Do not use space or national characters. Use lowercase a-z characters and/or numbers 0-9.

To access the NetServer from the Pocket CRM client, the NetServer needs to be accessible on the public internet that can be addressed and reached using HTTP over a designated port, by default port 80. Firewall and proxies must be properly configured so they don’t cause any problems related to communication between Pocket CRM client and NetServer.

Read more on [Deploy SuperOffice securely onsite][3]

### Verify NetServer

Pocket CRM uses SuperOffice NetServer so we need to verify that the Pocket CRM can reach the server that NetServer is installed on.

Open a browser and enter the domain name address to the remote NetServer installation. Example: `http://servername.youcompany.com/NetServer/sale.svc` Result should look like this:

![x -screenshot][img1]

Clients installed on mobile phones uses this address to communicate. This server address (URL) must be reachable from mobile phones (from the internet).

## Step 2: assign a Pocket license

> [!NOTE]
> This step is necessary **only if you have an Onsite Buy license type**. For Onsite Subscription, all users have the Pocket license included in the license plan.

All Pocket CRM users need a Pocket CRM license. Admin needs to set this in the Admin client > users:

![x -screenshot][img2]

## Steps 3-4: get the app on the mobile device

All users must complete the [client installation][6].

## Connection URL

The user can set this URL either by typing the address manually or by clicking a SOProtocol link on the device.

To make it easier to configure the URL for Pocket CRM, it is recommended that the installation address, `http://pocket.mydomain.com/pocketcrm/services80/` is sent as an SO protocol to the end-user using SMS or email that is accessible on the device they are to connect to.

You can send a predefined email with this URL by clicking **Pocket CRM settings** from the SuperOffice Web client:

![x -screenshot][img5]

> [!NOTE]
> To change the URL that is sent out in this email, changes have to be done in *web.config* for NetServer under [SoFormsAuthentication][7]:

```xml
<SoFormsAuthentication>
  <Pages>
    <add key="PocketCrmServiceUrl" value="[https://my.server.com/SuperOffice/remote/Services80](https://my.server.com/SuperOffice/remote/Services80)" />
```

<!-- Referenced links -->
[1]: system-requirements.md
[2]: configure.md
[3]: ../../onsite/security/index.md
[6]: install.md
[7]: ../../api/config/soformsauthentication.md

<!-- Referenced images -->
[img1]: media/image.png
[img2]: media/assign-licence.png
[img5]: media/preferences.png
