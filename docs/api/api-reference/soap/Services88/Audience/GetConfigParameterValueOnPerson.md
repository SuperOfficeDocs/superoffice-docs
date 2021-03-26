---
uid: services88-audience-getconfigparametervalueonperson
title: Services88.AudienceAgent.GetConfigParameterValueOnPerson SOAP
Generated: true
---

# Services88 Audience GetConfigParameterValueOnPerson SOAP

SOAP request and response examples **Remote/Services88/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAudienceAgent.GetConfigParameterValueOnPerson">SuperOffice.Services88.IAudienceAgent.GetConfigParameterValueOnPerson</see> method.

## GetConfigParameterValueOnPerson

Gets the string value of an Audience configuration parameter with the specified configuration parameter name on the person specified

* **parameterName:** The name of the Audience configuration parameter
* **personId:** Id of the person the parameter belongs to

**Returns:** The string value of the Audience configuration parameter.


[WSDL file for Services88/Audience](../Services88-Audience.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConfigParameterValueOnPerson Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Audience:ApplicationToken>1234567-1234-9876</Audience:ApplicationToken>
  <Audience:Credentials>
    <Audience:Ticket>7T:1234abcxyzExample==</Audience:Ticket>
  </Audience:Credentials>
 <SOAP-ENV:Body>
   <Audience:GetConfigParameterValueOnPerson>
    <Audience:ParameterName xsi:type="xsd:string"></Audience:ParameterName>
    <Audience:PersonId xsi:type="xsd:int">0</Audience:PersonId>
   </Audience:GetConfigParameterValueOnPerson>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConfigParameterValueOnPerson Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Audience:GetConfigParameterValueOnPersonResponse>
   <Audience:Response xsi:type="xsd:string"></Audience:Response>
  </Audience:GetConfigParameterValueOnPersonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

