---
uid: txtlocal-sms-connector
title: TxtLocal
description: Configuration of TxtLocal NetServer SMS connector
keywords: TxtLocal
author: SuperOffice Product and Engineering
date: 10.07.2025
content_type: howto
category: Marketing
topic: SMS
redirect_from: /en/service/sms/txtlocal
language: en
---

# Configuration of TxtLocal NetServer SMS connector

This document describes how to set up the TxtLocal NetServer SMS connector to use in Customer Service. You need to set up an account with [TxtLocal][1] to get a username and password to connect to their service.

## Outgoing SMS Configuration from SuperOffice 8.0 SR3

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose TXTLocal in the list of available modules

In the **Plugin configuration** you add:

```text
txtlocal_username = txtlocal_password =
```

![x -screenshot][img1]

Note - do not include the brackets.

## Outgoing SMS Configuration in SR2 or earlier

The file SupeOffice.Messaging. TxtLocal.dll must be copied manually to the NetServer library folder (bin folder).

### Web.config settings

Under configuration, add and replace username and password with the information you have from CM:

```XML
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
[img1]: ../../../../media/loc/en/marketing/txtlocalsmssettings.png
