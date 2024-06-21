---
title: Link Mobility (PSWinCom)
uid: pswincom_sms_plugin
description: Link Mobility (PSWinCom) NetServer SMS plugin
author: {github-id}
keywords:
topic: howto
---

# Link Mobility (PSWinCom)

This document describes how to set up the Link Mobility PSWinCom NetServer SMS plugin to use in Customer Service. You need to set up an account with Link Mobility and refer to the [PSWinCom][1] Gateway to get a username and password to connect to their service.

## Outgoing SMS Configuration from SuperOffice 8.0 SR3

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose PSWinCom SMS in the list of available modules

In the **Plugin configuration** you add:

```text
pswin_username =
pswin_password =
```

![x -screenshot][img1]

Note - do not include the brackets.

## Outgoing SMS Configuration in SR2 or earlier

From version 7.1 SR1 of NetServer, the *SupeOffice.Messaging.PSWinCom.dll* is included in the NetServer release. The plugin can also be used in 7.1, but the .dll must be copied manually to the NetServer library folder (*bin* folder).

### Web.config settings

Under configuration, add and replace username and password with the information you have from PSWinCom:

```xml
 <appSettings>
   <add key="pswin_username" value=""/>
   <add key="pswin_password" value=""/>
   <add key="pswin_seriesStart" value=""/>
   <add key="pswin_seriesEnd" value=""/>
   <add key="pswin_noStatusReport" value=""/>
   <add key="pswin_NoSmsSession" value=""/>
 </appSettings>
```

Under configuration -> SuperOffice -> Factory -> DynamicLoad add:

```xml
<add key="PSWinCom" value="SuperOffice.Messaging.PSWinCom.dll" />
```

Under configuration -> system.serviceModel add:

```xml
<client>
  <endpoint address="http://sms.pswin.com/SOAP/SMS.asmx"
            binding="basicHttpBinding" bindingConfiguration="SMSServiceSoap"
            contract="PsWinComGW.SMSServiceSoap" name="SMSServiceSoap" />
</client>
```

Under configuration -> system.serviceModel -> bindings, add:

```xml
<basicHttpBinding>
  <binding name="SMSServiceSoap" closeTimeout="00:01:00" openTimeout="00:01:00" receiveTimeout="00:10:00"
           sendTimeout="00:01:00" allowCookies="false" bypassProxyOnLocal="false" hostNameComparisonMode="StrongWildcard"
           maxBufferSize="65536" maxBufferPoolSize="524288" maxReceivedMessageSize="65536" messageEncoding="Text"
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
[1]: https://www.linkmobility.com/products/link-sms-gateway/

<!-- Referenced images -->
[img1]:media/pswincomsmssettings.png
