---
uid: services75-messaging-getplugins
title: Services75.MessagingAgent.GetPlugins SOAP
Generated: true
---

# Services75 Messaging GetPlugins SOAP

SOAP request and response examples **Remote/Services75/Messaging.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IMessagingAgent.GetPlugins">SuperOffice.Services75.IMessagingAgent.GetPlugins</see> method.

## GetPlugins






[WSDL file for Services75/Messaging](../Services75-Messaging.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPlugins Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Messaging:ApplicationToken>1234567-1234-9876</Messaging:ApplicationToken>
  <Messaging:Credentials>
    <Messaging:Ticket>7T:1234abcxyzExample==</Messaging:Ticket>
  </Messaging:Credentials>
 <SOAP-ENV:Body>
   <Messaging:GetPlugins>
   </Messaging:GetPlugins>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPlugins Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Messaging:GetPluginsResponse>
   <Messaging:Response xsi:type="Messaging:ArrayOfProviderInfo">
    <Messaging:ProviderInfo xsi:type="Messaging:ProviderInfo">
     <Messaging:Name xsi:type="xsd:string"></Messaging:Name>
     <Messaging:SupportedMessagingFormats xsi:type="NetServerServices752:ArrayOfstring">
      <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
     </Messaging:SupportedMessagingFormats>
    </Messaging:ProviderInfo>
   </Messaging:Response>
  </Messaging:GetPluginsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

