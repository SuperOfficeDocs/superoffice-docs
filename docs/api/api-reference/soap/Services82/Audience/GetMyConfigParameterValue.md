---
uid: services82-audience-getmyconfigparametervalue
title: Services82.AudienceAgent.GetMyConfigParameterValue SOAP
Generated: true
---

# Services82 Audience GetMyConfigParameterValue SOAP

SOAP request and response examples **Remote/Services82/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IAudienceAgent.GetMyConfigParameterValue">SuperOffice.Services82.IAudienceAgent.GetMyConfigParameterValue</see> method.

## GetMyConfigParameterValue

Gets the string value of an Audience configuration parameter belonging to the currently logged on user with the specified configuration parameter name.

* **parameterName:** The name of the Audience configuration parameter

**Returns:** The string value of the Audience configuration parameter.


[WSDL file for Services82/Audience](../Services82-Audience.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetMyConfigParameterValue Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services82">
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
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Audience:GetMyConfigParameterValueResponse>
   <Audience:Response xsi:type="xsd:string"></Audience:Response>
  </Audience:GetMyConfigParameterValueResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

