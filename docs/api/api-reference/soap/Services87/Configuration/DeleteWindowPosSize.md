---
uid: services87-configuration-deletewindowpossize
title: Services87.ConfigurationAgent.DeleteWindowPosSize SOAP
Generated: true
---

# Services87 Configuration DeleteWindowPosSize SOAP

SOAP request and response examples **Remote/Services87/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IConfigurationAgent.DeleteWindowPosSize">SuperOffice.Services87.IConfigurationAgent.DeleteWindowPosSize</see> method.

## DeleteWindowPosSize

Deletes a window and dialog position and size setting.

* **windowPosSizeId:** Id of the window and dialog position and size settings item.



[WSDL file for Services87/Configuration](../Services87-Configuration.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteWindowPosSize Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:DeleteWindowPosSize>
    <Configuration:WindowPosSizeId xsi:type="xsd:int">0</Configuration:WindowPosSizeId>
   </Configuration:DeleteWindowPosSize>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteWindowPosSize Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Configuration:DeleteWindowPosSizeResponse>
  </Configuration:DeleteWindowPosSizeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

