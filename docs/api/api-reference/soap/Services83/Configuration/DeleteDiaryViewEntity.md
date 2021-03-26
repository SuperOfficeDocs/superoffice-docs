---
uid: services83-configuration-deletediaryviewentity
title: Services83.ConfigurationAgent.DeleteDiaryViewEntity SOAP
Generated: true
---

# Services83 Configuration DeleteDiaryViewEntity SOAP

SOAP request and response examples **Remote/Services83/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IConfigurationAgent.DeleteDiaryViewEntity">SuperOffice.Services83.IConfigurationAgent.DeleteDiaryViewEntity</see> method.

## DeleteDiaryViewEntity

Deletes the DiaryViewEntity

* **diaryViewEntityId:** The identity of the DiaryViewEntity



[WSDL file for Services83/Configuration](../Services83-Configuration.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteDiaryViewEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services83">
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
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Configuration:DeleteDiaryViewEntityResponse>
  </Configuration:DeleteDiaryViewEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

