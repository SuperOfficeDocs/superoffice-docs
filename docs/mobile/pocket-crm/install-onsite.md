---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: install_pocket_onsite       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Pocket CRM installation # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
so.client:   pocket         # online, web, win, pocket, or mobile
---

# Pocket CRM installation

* Pocket version 8 running directly with NetServer must have [remote web services][1].
* On CRM 8 we don't recommend the use of SuperOffice Pocket Server, only to access NetServer directly.
* Web & Pocket can share NetServer if Web client does not have IIS authentication.
* The site must allow TLS 1.0 if you are running on a Pocket CRM version lower than 8.0.32 which was released August 15th 2016. From August 15th 2016 we added support for TLS 1.2 communication protocols between device and server.
  * Pocket client does not support AD authentication
* Pocket version 8 does not support IIS schemas

Read more in [our administration site here][2].

## Deployment guide

1. Make sure a connection to the server is available (NetServer)
2. Make sure all Pocket CRM users have a Pocket CRM license
3. Download and install the Pocket CRM App on all the devices
4. Configure 'the connection path to the server' on each of the Pocket CRM App

## Prepare Server (NetServer)

You will need to set up and properly configure the correct version of SuperOffice NetServer.

Common issues are the configuration of document archive (SO\_ARC) and email server setting. You can verify your NetServer installation using SuperOffice Web. The Pocket CRM client is installed on phones that access this server over the internet and must be able to reach this server host. The address for NetServer URL will be like this:  `http://servername.youcompany.com/NetServer/sevices80/`

> [!NOTE]
> Do not use space or national characters; use lowercase a-z characters and/or numbers 0-9.

To access the NetServer from the Pocket CRM client, the NetServer needs to be accessible on the public Internet that can be addressed and reached using HTTP over a designated port, by default port 80. Firewall and proxies must be properly configured so they don’t cause any problems related to communication between Pocket CRM client and NetServer.

Read more on [Deploy SuperOffice securely onsite][3]

### Verify NetServer

Pocket CRM uses SuperOffice NetServer so we need to verify that the Pocket CRM can reach the server that NetServer is installed on.

Open a browser and enter the domain name address to the remote NetServer installation. Example: `http://servername.youcompany.com/NetServer/sale.svc` Result should look like this:

![x][4]

Clients installed on mobile phones uses this address to communicate. This server address (URL) must be reachable from the mobile phones (from the internet)

## Assign Pocket license

This step is necessary only if you have Onsite Buy license type. For Onsite Subscription all users have the Pocket license included in the license plan. All Pocket CRM users need a Pocket CRM license. Admin needs to set this in the Admin client > users:

![x][5]

## Download and install

Installing the Pocket Client on the mobile device. Choose Google Play if you use an Android device or choose App Store if you use an Apple device:

[![Get it on Google Play](https://online.superoffice.com/Login/Images/google-play-badge.png "Get it on Google Play")][6]

[![Get it on Apple App Store](https://online.superoffice.com/Login/Images/Download_on_the_App_Store_Badge_US-UK_135x40.svg "Get it on Apple App Store")][7]

Follow the process in Play Store/App Store for downloading and installing the application.

Open the installed application on your mobile.

## Configure connection to server

The first time you start the App, you will be asked to configure what type of environment your SuperOffice server is using.

Choose \[SuperOffice CRM\].

![x][9]

 You must now set the URL in the app to connect it to the server by setting the *connection url /connection string / URL to your Pocket server / NetServer installation*:

![x][10]

Your administrator should know where to find this URL.

You can set this URL either by typing the address manually or by clicking a SOProtocol link on the device:

* To make it easier to configure the URL for Pocket CRM it is recommended that the installation address, *http://pocket.mydomain.com/pocketcrm/services80/* is sent as an "SO protocol" to the end-user using SMS or email which is accessible on the device you are to connect to.

You can send a predefined email with this URL by clicking "Pocket CRM settings" from the SuperOffice Web client:

![x][11]

> [!NOTE]
> To change the URL that is sent out in this email, changes has to be done in *web.config* for NetServer under:

```xml
<SoFormsAuthentication>
  <Pages>
    <add key="PocketCrmServiceUrl" value="[https://my.server.com/SuperOffice/remote/Services80](https://my.server.com/SuperOffice/remote/Services80)" />
```

When you have set the URL to your NetServer installation in Pocket CRM, you will be presented with the log on screen.

Log in with the same username and password you use for the SuperOffice CRM and you are ready to use SuperOffice Pocket CRM!

## Reset the Pocket CRM client

If you need to either reset the settings or configure the client with another connection URL, you can delete the settings by uninstalling the app then install it again - then you can enter the server settings.

<!-- Referenced links -->
[1]: system-requirements.md
[2]: https://community.superoffice.com/en/technical/documentation/administration/pocket-crm/
[3]: https://community.superoffice.com/en/technical/documentation/prepare/security/deploy-securely/
[4]: media/image.png
[5]: media/image.png
[6]: https://play.google.com/store/apps/details?id=no.superoffice.pocket.j2me.SuperOffice
[7]: http://itunes.apple.com/no/app/superoffice/ce/id445355343
[8]: media/google-play-badge.png
[9]: media/image.png
[10]: media/image.png
[11]: media/image.png
