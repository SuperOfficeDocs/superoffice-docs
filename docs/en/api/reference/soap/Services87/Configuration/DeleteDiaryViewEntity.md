---
title: Services87.ConfigurationAgent.DeleteDiaryViewEntity SOAP
generated: 1
uid: Services87-Configuration-DeleteDiaryViewEntity
---

# Services87 Configuration DeleteDiaryViewEntity

SOAP request and response examples **Remote/Services87/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IConfigurationAgent.DeleteDiaryViewEntity">SuperOffice.Services87.IConfigurationAgent.DeleteDiaryViewEntity</see> method.

## DeleteDiaryViewEntity

[WSDL file for Services87/Configuration](../Services87-Configuration.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteDiaryViewEntity Request

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
   <Configuration:DeleteDiaryViewEntity>
    <Configuration:DiaryViewEntityId xsi:type="xsd:int">0</Configuration:DiaryViewEntityId>
   </Configuration:DeleteDiaryViewEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## DeleteDiaryViewEntity Response

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
  <Configuration:DeleteDiaryViewEntityResponse>
  </Configuration:DeleteDiaryViewEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
