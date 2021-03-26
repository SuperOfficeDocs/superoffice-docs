---
uid: services80-audience-getconfigparametersbylayoutname
title: Services80.AudienceAgent.GetConfigParametersByLayoutName SOAP
Generated: true
---

# Services80 Audience GetConfigParametersByLayoutName SOAP

SOAP request and response examples **Remote/Services80/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IAudienceAgent.GetConfigParametersByLayoutName">SuperOffice.Services80.IAudienceAgent.GetConfigParametersByLayoutName</see> method.

## GetConfigParametersByLayoutName

Gets the Audience configuration parameters belonging to a given Audience layout.

* **layoutName:** Name of the Audience layout instance

**Returns:** Array of Audience configuration parameters.


[WSDL file for Services80/Audience](../Services80-Audience.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConfigParametersByLayoutName Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Audience:ApplicationToken>1234567-1234-9876</Audience:ApplicationToken>
  <Audience:Credentials>
    <Audience:Ticket>7T:1234abcxyzExample==</Audience:Ticket>
  </Audience:Credentials>
 <SOAP-ENV:Body>
   <Audience:GetConfigParametersByLayoutName>
    <Audience:LayoutName xsi:type="xsd:string"></Audience:LayoutName>
   </Audience:GetConfigParametersByLayoutName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConfigParametersByLayoutName Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Audience:GetConfigParametersByLayoutNameResponse>
   <Audience:Response xsi:type="Audience:ArrayOfAudienceConfigParameter">
    <Audience:AudienceConfigParameter xsi:type="Audience:AudienceConfigParameter">
     <Audience:AudienceLayoutId xsi:type="xsd:int">0</Audience:AudienceLayoutId>
     <Audience:Name xsi:type="xsd:string"></Audience:Name>
     <Audience:Value xsi:type="xsd:string"></Audience:Value>
     <Audience:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:34:06Z</Audience:CreatedDate>
     <Audience:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:34:06Z</Audience:UpdatedDate>
     <Audience:CreatedBy xsi:type="xsd:string"></Audience:CreatedBy>
     <Audience:UpdatedBy xsi:type="xsd:string"></Audience:UpdatedBy>
    </Audience:AudienceConfigParameter>
   </Audience:Response>
  </Audience:GetConfigParametersByLayoutNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

