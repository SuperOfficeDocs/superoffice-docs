---
title: Intelecom
uid: intelecom_sms_plugin
description: Intelecom NetServer SMS plugin
author: {github-id}
keywords:
topic: howto
---

# Intelecom

This document describes how to set up the Intelecom NetServer SMS plugin to use in Customer Service. You need to set up an account with [Intelecom][1] to get a username and password to connect to their service.

## Outgoing SMS Configuration from SuperOffice 8.0 SR3

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose Intelecom SMS in the list of available modules

In the **Plugin configuration** you add:

```text
intele_serviceId =
intele_username =
intele_password =
```

![x -screenshot][img1]

Note - do not include the brackets.

## Outgoing SMS Configuration in SR2 or earlier

From version 7.1 SR1 of NetServer, the SupeOffice.Messaging.Intelecom.dll is included in the NetServer release. The plugin can also be used in previous versions, but the .dll must be copied manually to the NetServer library folder (bin folder).

### Web.config settings

Under configuration, add and replace serviceId, username and password with the information you have from Intelecom:

```xml
<appSettings>
  <add key="intele_serviceId" value="" />
  <add key="intele_username" value="" />
  <add key="intele_password" value="" />
  <add key="intele_ClientSettingsProvider.ServiceUri" value="" />
  <add key="intele_NoSmsSession" value="" />
  <add key="intele_noStatusReport" value="" />
</appSettings>
```

Under configuration -> SuperOffice -> Factory -> DynamicLoad add:

```xml
<add key="Intelecom" value="SuperOffice.Messaging.Intelecom.dll" />
```

Under configuration -> system.serviceModel add:

```xml
<client>
  <endpoint address="http://smsgw.carrot.no/smsgw/services/SMSGateway_v21" binding="basicHttpBinding"
            bindingConfiguration="SMSGatewaySoapBinding" contract="IntelecomGW.SMSGateway" name="SMSGateway" />
</client>
```

Under configuration -> system.serviceModel -> bindings, add:

```xml
<basicHttpBinding>
  <binding name="SMSGatewaySoapBinding" closeTimeout="00:01:00" openTimeout="00:01:00" receiveTimeout="00:10:00"
           sendTimeout="00:01:00" allowCookies="false" bypassProxyOnLocal="false" hostNameComparisonMode="StrongWildcard" maxBufferSize="65536" maxBufferPoolSize="524288" maxReceivedMessageSize="65536" messageEncoding="Text"
           textEncoding="utf-8" transferMode="Buffered" useDefaultWebProxy="true">
    <readerQuotas maxDepth="32" maxStringContentLength="8192" maxArrayLength="16384" maxBytesPerRead="4096"
                  maxNameTableCharCount="16384" />
    <security mode="None">
      <transport clientCredentialType="None" proxyCredentialType="None" realm="" />
      <message clientCredentialType="UserName" algorithmSuite="Default" />
    </security>
  </binding>
</basicHttpBinding>
```

<!-- Referenced links -->
[1]: https://www.intele.com/contact-centre-solution/sms/

<!-- Referenced images -->
[img1]: media/intelecomsmssettings.png
