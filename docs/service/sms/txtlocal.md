---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: txtlocal_sms_plugin       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Configuration of TxtLocal NetServer SMS plugin # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                 # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Configuration of TxtLocal NetServer SMS Plugin

This document describes how to set up the TxtLocal NetServer SMS plugin to use in Customer Service. You need to set up an account with [TxtLocal][1] to get a username and password to connect to their service.

## Outgoing SMS Configuration from SuperOffice 8.0 SR3

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose TXTLocal in the list of available modules

In the **Plugin configuration** you add:

```text
txtlocal_username = txtlocal_password =
```

![x][img1]

Note - do not include the brackets.

## Outgoing SMS Configuration in SR2 or earlier

The file SupeOffice.Messaging. TxtLocal.dll must be copied manually to the NetServer library folder (bin folder).

### Web.config settings

Under configuration, add and replace username and password with the information you have from CM:

```xml
<appSettings>
  <!-- Web service URL -->
  <add key="txtlocal_url" value="http://www.textlocal.com/sendsmspost.php" />
  <!-- Specify the username to your SMS account -->
  <add key="txtlocal_username" value=" " />
  <!-- Specify the password to your SMS account -->
  <add key="txtlocal_password" value=" " />
  <!-- If set to 1, your request will only be simulated; no messages will be sent and no credits will be deducted. -->
  <add key="txtlocal_test" value="0" />
</appSettings>
```

Under configuration -> SuperOffice -> Factory -> DynamicLoad add:

```xml
  <add key="SuperOffice.Messaging.TxtLocal" value="SuperOffice.Messaging.TxtLocal.dll" />
```

<!-- Referenced links -->
[1]: http://www.textlocal.com/

<!-- Referenced images -->
[img1]:media/txtlocalsmssettings.png
