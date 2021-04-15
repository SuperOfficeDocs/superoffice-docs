---
title: Configure
uid: configure_pocket_onsite
description: Pocket CRM config
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite
so.client: pocket
---

# Pocket CRM configuration

## Recommended configuration

* Upgrade to SuperOffice 8 > Automatically update clients [from Pocket Server to NetServer][6]
* Setting up an email account for the client
* Add a template for incoming images (jpeg)
* Add a follow-up type for SMS

## Enable logging

Enable [logging][1] in the *web.config* file like for CRM Web under SuperOffice>Diagnostics>LogToFile

## NetServer configuration - GSM formatted phone numbers

When initiating phone calls from Pocket CRM it is important that the numbers are formatted in a way that the phone can use. SuperOffice NetServer has the functionality to return all phone numbers from the SuperOffice database in a clean formatted way, without spaces, commas, and including country prefix, like this: +4712345678. To enable this feature in NetServer make sure that *web.config* contains this element:

```xml
<add key="AllwaysUseGsmPhoneStyle" value="True" />
```

## Client configuration - Setting up an email account

To use and be able to send an email within Pocket CRM an email account needs to be configured. This configuration needs to be performed in the SuperOffice 8.x Web Client.

## Admin configuration - Add a Template for incoming images (jpeg)

Open SuperOffice Admin client and select Lists section > Lists tab > double click **Template** and select **+ Add** bottom of the **Lists items**. Add this List item where filename has extension **.jpg**. The file may be empty, we use the extension to look up the correct template when a new file is saved.

## Admin configuration - Add a Follow-up type for SMS

Open SuperOffice Admin client and select Lists section > Lists tab > double click **Type (Follow-up)** and select **+ Add** bottom of the **Lists items**. Add this List item SMS as type **Appointment** and direction **Outgoing**.

See the admin [help file][2] for adding list items.

## Data caching

Pocket saves data that is accessed in a local SQLite database. This is for all data that is shown in the Pocket application, except documents.

Data that the user does not have access to is not saved. The data is initially saved forever but is periodically updated when accessed again.

All local data is erased if Pocket is reconfigured to a new installation, or if a new user logs in.

Both iOS and Android have default support for encrypting all content if a pin code or password is used to lock the device.

[https://www.apple.com/business/docs/iOS\_Security\_Guide.pdf][3]
[https://source.android.com/security/encryption/full-disk][4]

## Expose NetServer to internet

To connect Pocket CRM to NetServer's web services, NetServer needs to be accessible from the internet. If you have a [setup with remote NetServer on internal network and SuperOffice Web in DMZ][5], that means only Web server part is available on the internet.

A solution is to use [Reverse proxy][7] to make also NetServer available on the internet.

Installing a second NetServer in DMZ and connecting it via web services to the remote NetServer on internal LAN is not supported. The NetServer in DMZ will demand direct access to so\_arc and Pocket CRM using this setup will fail to save pictures and documents.

## Custom Pocket configuration URL

If you want to change the default Pocket CRM configuration URL, you can do so by setting a configuration value of SuperOffice Web in the *web.config* file.

The key name is PocketCrmServiceUrl and the value is the new URL for Pocket connection. You'll find this in the `<SoFormsAuthentication> - <Pages>` section.

Example:

```xml
<add key="PocketCrmServiceUrl" value="[http://pocket.customer.com/](http://pocket.superoffice.com/NetserverPocket/remote/Services80)" />
```

> [!NOTE]
> The template files we use to generate the email with Pocket configuration sent to users use two template variables:

* `{pccu}` variable always points to *\<CRM.web installation>\\PocketConfiguration.aspx* and is not configurable.
    The reason this is not a direct configuration link for the Pocket client (soprotocol scheme), is that a lot of users experienced problems on Android, where mail clients did not handle the custom protocol link correctly
    The custom protocol redirect/configuration URL that PocketConfiguration.aspx uses, is attempted retrieved from CRM.web installation *web.config*.

* `{pcvu}` variable is used as the display name for the Pocket configuration URL.

<!-- Referenced links -->
[1]: ../../onsite-setup/web-client/debug.md
[2]: https://community.superoffice.com/documentation/help/en/crm/9.2/webhelpadmin/index.htm#t=chap08%2FAdding_items.htm
[3]: https://www.apple.com/business/docs/iOS_Security_Guide.pdf
[4]: https://source.android.com/security/encryption/full-disk
[5]: ../../onsite-setup/security/deployment-scenarios.md
[6]: upgrade-to-8.md
[7]: ../../onsite-setup/crm-server/iis-web-server/set-up-reverse-proxy.md
