---
title: Services85.AudienceAgent.GetMyConfigParameter SOAP
generated: 1
uid: Services85-Audience-GetMyConfigParameter
---

# Services85 Audience GetMyConfigParameter

SOAP request and response examples **Remote/Services85/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IAudienceAgent.GetMyConfigParameter">SuperOffice.Services85.IAudienceAgent.GetMyConfigParameter</see> method.

## GetMyConfigParameter

Gets an Audience configuration parameter belonging to the currently logged on user with the specified configuration parameter name.

* **parameterName:** The name of the Audience configuration parameter

**Returns:** The Audience configuration parameter.

[WSDL file for Services85/Audience](../Services85-Audience.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetMyConfigParameter Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Audience:ApplicationToken>1234567-1234-9876</Audience:ApplicationToken>
  <Audience:Credentials>
    <Audience:Ticket>7T:1234abcxyzExample==</Audience:Ticket>
  </Audience:Credentials>
 <SOAP-ENV:Body>
   <Audience:GetMyConfigParameter>
    <Audience:ParameterName xsi:type="xsd:string"></Audience:ParameterName>
   </Audience:GetMyConfigParameter>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetMyConfigParameter Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Audience:GetMyConfigParameterResponse>
   <Audience:Response xsi:type="Audience:AudienceConfigParameter">
    <Audience:AudienceLayoutId xsi:type="xsd:int">0</Audience:AudienceLayoutId>
    <Audience:Name xsi:type="xsd:string"></Audience:Name>
    <Audience:Value xsi:type="xsd:string"></Audience:Value>
    <Audience:CreatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:26Z</Audience:CreatedDate>
    <Audience:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:26Z</Audience:UpdatedDate>
    <Audience:CreatedBy xsi:type="xsd:string"></Audience:CreatedBy>
    <Audience:UpdatedBy xsi:type="xsd:string"></Audience:UpdatedBy>
   </Audience:Response>
  </Audience:GetMyConfigParameterResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
