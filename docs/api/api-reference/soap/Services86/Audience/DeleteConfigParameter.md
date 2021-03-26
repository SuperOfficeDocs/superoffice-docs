---
uid: services86-audience-deleteconfigparameter
title: Services86.AudienceAgent.DeleteConfigParameter SOAP
Generated: true
---

# Services86 Audience DeleteConfigParameter SOAP

SOAP request and response examples **Remote/Services86/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IAudienceAgent.DeleteConfigParameter">SuperOffice.Services86.IAudienceAgent.DeleteConfigParameter</see> method.

## DeleteConfigParameter

Deletes an Audience configuration parameter belonging to a Audience layout

* **layoutName:** Name of the Audience layout instance
* **parameterName:** The name of the Audience configuration parameter



[WSDL file for Services86/Audience](../Services86-Audience.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteConfigParameter Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Audience:ApplicationToken>1234567-1234-9876</Audience:ApplicationToken>
  <Audience:Credentials>
    <Audience:Ticket>7T:1234abcxyzExample==</Audience:Ticket>
  </Audience:Credentials>
 <SOAP-ENV:Body>
   <Audience:DeleteConfigParameter>
    <Audience:LayoutName xsi:type="xsd:string"></Audience:LayoutName>
    <Audience:ParameterName xsi:type="xsd:string"></Audience:ParameterName>
   </Audience:DeleteConfigParameter>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteConfigParameter Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Audience:DeleteConfigParameterResponse>
  </Audience:DeleteConfigParameterResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

