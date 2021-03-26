---
uid: services86-messaging-getplugins
title: Services86.MessagingAgent.GetPlugins SOAP
Generated: true
---

# Services86 Messaging GetPlugins SOAP

SOAP request and response examples **Remote/Services86/Messaging.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IMessagingAgent.GetPlugins">SuperOffice.Services86.IMessagingAgent.GetPlugins</see> method.

## GetPlugins

<para /><b>Online Restricted:</b> The Messaging agent is not available in Online by default. Access must be requested specifically when app is registered.




[WSDL file for Services86/Messaging](../Services86-Messaging.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPlugins Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Messaging:GetPluginsResponse>
   <Messaging:Response xsi:type="Messaging:ArrayOfProviderInfo">
    <Messaging:ProviderInfo xsi:type="Messaging:ProviderInfo">
     <Messaging:Name xsi:type="xsd:string"></Messaging:Name>
     <Messaging:SupportedMessagingFormats xsi:type="NetServerServices862:ArrayOfstring">
      <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
     </Messaging:SupportedMessagingFormats>
     <Messaging:SupportsConfig xsi:type="xsd:boolean">false</Messaging:SupportsConfig>
    </Messaging:ProviderInfo>
   </Messaging:Response>
  </Messaging:GetPluginsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

