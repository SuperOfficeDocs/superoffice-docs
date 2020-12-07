---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: configure_pocket_onsite       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Pocket CRM config # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
so.client:   pocket         # online, web, win, pocket, or mobile
---

# Pocket CRM configuration

## Recommended configuration

* Upgrade to SuperOffice 8 > Automatically update clients [from Pocket Server to Netserver](uprade-to-8.md)
* Setting up an email account for the client
* Add a Template for incoming images (jpeg)
* Add a Follow-up type for SMS

## Enable logging

Enable [logging][1] in the web.config file like for CRM Web under SuperOffice->Diagnostics->LogToFile

## Netserver configuration - GSM formatted phone numbers

When initiating phone calls from Pocket CRM it is important that the numbers are formatted in a way that the phone can use. SuperOffice NetServer has the functionality to return all phone numbers from the SuperOffice database in a clean formatted way, without spaces, commas and including country prefix, like this: +4712345678. To enable this feature in NetServer make sure that Web.config contains this element:

```xml
<add key="AllwaysUseGsmPhoneStyle" value="True" />
```

## Client configuration - Setting up an email account

To use and be able to send an e-mail within Pocket CRM an e-mail account needs to be configured. This configuration needs to be performed in the SuperOffice 8.x Web Client.

## Admin configuration - Add a Template for incoming images (jpeg)

Open SuperOffice Admin client and select Lists section -> Lists tab -> double click “Template” and select “+ Add” bottom of the “Lists items”. Add this List item where filename has extension **.jpg**. The file may be empty, we use the extension to look up the correct template when a new file is saved.

## Admin configuration - Add a Follow-up type for SMS

Open SuperOffice Admin client and select Lists section -> Lists tab -> double click “Type (Follow-up)” and select “+ Add” bottom of the “Lists items”. Add this List item SMS as type **Appointment** and direction **Outgoing**.

See the admin [help file][2] for adding list items.

## Data caching

Pocket saves data that is accessed in a local SQLite database. This is for all data that is shown in the Pocket application, with the exception of documents.

Data that the user does not have access to is not saved. The data is initially saved forever, but is periodically updated when accessed again.

All local data is erased if Pocket is reconfigured to a new installation, or if a new user logs in.

Both iOS and Android have default support for encrypting all content if a pin code or password is used to lock the device.

[https://www.apple.com/business/docs/iOS\_Security\_Guide.pdf][3]
[https://source.android.com/security/encryption/full-disk][4]

## Expose NetServer to Internet

In order to connect Pocket CRM to NetServer's webservices, Netserver needs to be accessible from internet. If you have a [setup with remote NetServer on internal network and SuperOffice Web in DMZ][5], that means only Web server part is available on internet.

A solution is to use [Reverse proxy][8] to make also Netserver available on Internet.

Installing second Netserver in DMZ and connecting it via web services to the remote NetServer on internal LAN is not supported. The NetServer in DMZ will demand direct access to so\_arc and Pocket CRM using this setup will fail to save pictures and documents.

## Custom Pocket configuration URL

If you want to change the default Pocket CRM configuration URL, you can do so by setting a configuration value of SuperOffice Web in the Web.config.

The key name is PocketCrmServiceUrl and the value is the new URL for Pocket connection. You'll find this in the `<SoFormsAuthentication> - <Pages>` section.

Example:

```xml
<add key="PocketCrmServiceUrl" value="[http://pocket.customer.com/](http://pocket.superoffice.com/NetserverPocket/remote/Services80)" />
```

> [!NOTE]
> The template files we use to generate the email with Pocket configuration sent to users use two template variables:

* **{pccu}** variable always points to \<CRM.web installation>\\PocketConfiguration.aspx and is not configurable.
    The reason this is not a direct configuration link for the Pocket client (soprotocol scheme), is that a lot of users experienced problems on Android, where mail clients did not handle the custom protocol link correctly
    The custom protocol redirect/configuration url that PocketConfiguration.aspx uses, is attempted retrieved from CRM.web installation web.config.

* **{pcvu}** variable is used as the display name for the Pocket configuration URL.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/administration/config-ini/debugweb/
[2]: https://community.superoffice.com/documentation/help/en/crm/8.0/webhelpadmin/index.htm#t=chap08%2FAdding_items.htm
[3]: https://www.apple.com/business/docs/iOS_Security_Guide.pdf
[4]: https://source.android.com/security/encryption/full-disk
[5]: https://community.superoffice.com/en/technical/documentation/prepare/security/deploy-securely/deployment-scenarios/
[8]: https://community.superoffice.com/en/technical/documentation/prepare/security/deploy-securely/setting-up-a-reverse-proxy-on-iis8/