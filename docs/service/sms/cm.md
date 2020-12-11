---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: cm_sms_plugin       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Configuration of CM NetServer SMS plugin # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                 # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Configuration of CM NetServer SMS Plugin

This document describes how to set up the CM NetServer SMS plugin to use in Customer Service. You need to set up an account with [CM][1] to get a username and password to connect to their service.

## Outgoing SMS Configuration from SuperOffice 8.0 SR3

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose CM in the list of available modules

In the **Plugin configuration** you add:

```text
cm_serviceId =
cm_username = cm_password =
```

![x][2]

Note - do not include the brackets.

## Outgoing SMS Configuration in SR2 or earlier

The file SupeOffice.Messaging.CM.dll must be copied manually to the NetServer library folder (bin folder). You may download version 8.0 SR2 [here][3].

### Web.config settings

Under configuration, add and replace username and password with the information you have from CM:

```xml
<appSettings>
  <add key="cm_serviceUrl" value="http://smsgateway02.cm.nl/cm/gateway.ashx" />
  <add key="cm_serviceId" value="[Customer Id]" />
  <add key="cm_username" value="[Username]" />
  <add key="cm_password" value="[Password]" />
</appSettings>
```

Under configuration -> SuperOffice -> Factory -> DynamicLoad add:

```xml
<add key="SuperOffice.Messaging.CM" value="SuperOffice.Messaging.CM.dll" />
```

<!-- Referenced links -->
[1]: https://www.cmtelecom.com/products/messaging/sms
[2]: media/cmsmssettings.png
[3]: https://community.superoffice.com/globalassets/technical-club/images/service/smsplugin8sr2/superoffice.messaging.cm.dll
