---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: compaya_sms_plugin       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Compaya NetServer SMS plugin # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                 # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Compaya

This document describes how to set up the Compaya NetServer SMS plugin to use in Customer Service. You need to set up an account with [Compaya][1] to get a username and password to connect to their service.

## Outgoing SMS Configuration from SuperOffice 8.0 SR3

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose Compaya SMS in the list of available modules

In the **Plugin configuration** you add:

```text
compaya_username=[username]
compaya_password=[password]
```

![x][2]

Note - do not include the brackets.

## Outgoing SMS Configuration in SR2 or earlier

The file SupeOffice.Messaging.Compaya.dll must be copied manually to the NetServer library folder (bin folder).
You may download version 8.0 SR2 [here][3].

### Web.config settings

Under configuration, add and replace username and password with the information you have from Compaya:

```xml
<appSettings>
  <!-- Web service URL -->
  <add key="compaya_url" value="http://www.cpsms.dk/sms/" />
  <!-- Specify the username to your SMS account, string (required) -->
  <add key="compaya_username" value="[Username]" />
  <!-- Specify the password to your SMS account, string (required) -->
  <add key="compaya_password" value="[Password]" />
</appSettings>
```

Under configuration -> SuperOffice -> Factory -> DynamicLoad add:

```xml
<add key="SuperOffice.Messaging.Compaya" value="SuperOffice.Messaging.Compaya.dll" />
```

<!-- Referenced links -->
[1]: http://www.compaya.dk/
[2]: media/compayasmssettings.png
[3]: https://community.superoffice.com/globalassets/technical-club/images/service/smsplugin8sr2/superoffice.messaging.compaya.dll
