---
title: Services86.AudienceAgent.GetConfigParameterValue SOAP
generated: 1
uid: Services86-Audience-GetConfigParameterValue
---

# Services86 Audience GetConfigParameterValue

SOAP request and response examples **Remote/Services86/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IAudienceAgent.GetConfigParameterValue">SuperOffice.Services86.IAudienceAgent.GetConfigParameterValue</see> method.

## GetConfigParameterValue

Gets the string value of an Audience configuration parameter belonging to a given Audience layout with the specified configuration parameter name

* **layoutName:** Name of the Audience layout instance
* **parameterName:** The name of the Audience configuration parameter

**Returns:** The string value of the Audience configuration parameter.


[WSDL file for Services86/Audience](../Services86-Audience.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConfigParameterValue Request

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
   <Audience:GetConfigParameterValue>
    <Audience:LayoutName xsi:type="xsd:string"></Audience:LayoutName>
    <Audience:ParameterName xsi:type="xsd:string"></Audience:ParameterName>
   </Audience:GetConfigParameterValue>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConfigParameterValue Response

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
  <Audience:GetConfigParameterValueResponse>
   <Audience:Response xsi:type="xsd:string"></Audience:Response>
  </Audience:GetConfigParameterValueResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

