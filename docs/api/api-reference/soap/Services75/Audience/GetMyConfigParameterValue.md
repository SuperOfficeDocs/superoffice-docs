---
uid: services75-audience-getmyconfigparametervalue
title: Services75.AudienceAgent.GetMyConfigParameterValue SOAP
Generated: true
---

# Services75 Audience GetMyConfigParameterValue SOAP

SOAP request and response examples **Remote/Services75/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IAudienceAgent.GetMyConfigParameterValue">SuperOffice.Services75.IAudienceAgent.GetMyConfigParameterValue</see> method.

## GetMyConfigParameterValue

Gets the string value of an Audience configuration parameter belonging to the currently logged on user with the specified configuration parameter name.

* **parameterName:** The name of the Audience configuration parameter

**Returns:** The string value of the Audience configuration parameter.


[WSDL file for Services75/Audience](../Services75-Audience.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetMyConfigParameterValue Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Audience:ApplicationToken>1234567-1234-9876</Audience:ApplicationToken>
  <Audience:Credentials>
    <Audience:Ticket>7T:1234abcxyzExample==</Audience:Ticket>
  </Audience:Credentials>
 <SOAP-ENV:Body>
   <Audience:GetMyConfigParameterValue>
    <Audience:ParameterName xsi:type="xsd:string"></Audience:ParameterName>
   </Audience:GetMyConfigParameterValue>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetMyConfigParameterValue Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Audience:GetMyConfigParameterValueResponse>
   <Audience:Response xsi:type="xsd:string"></Audience:Response>
  </Audience:GetMyConfigParameterValueResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

