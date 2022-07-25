---
title: Services86.AudienceAgent.SaveConfigParameter SOAP
generated: 1
uid: Services86-Audience-SaveConfigParameter
---

# Services86 Audience SaveConfigParameter

SOAP request and response examples **Remote/Services86/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IAudienceAgent.SaveConfigParameter">SuperOffice.Services86.IAudienceAgent.SaveConfigParameter</see> method.

## SaveConfigParameter

Saves an Audience configuration parameter belonging to a Audience layout

* **layoutName:** Name of the Audience layout instance
* **configParameter:** The Audience configuration parameter to save.

**Returns:** The new or updated configuration parameter

[WSDL file for Services86/Audience](../Services86-Audience.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveConfigParameter Request

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
   <Audience:SaveConfigParameter>
    <Audience:LayoutName xsi:type="xsd:string"></Audience:LayoutName>
    <Audience:ConfigParameter xsi:type="Audience:AudienceConfigParameter">
     <Audience:AudienceLayoutId xsi:type="xsd:int">0</Audience:AudienceLayoutId>
     <Audience:Name xsi:type="xsd:string"></Audience:Name>
     <Audience:Value xsi:type="xsd:string"></Audience:Value>
     <Audience:CreatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:47Z</Audience:CreatedDate>
     <Audience:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:47Z</Audience:UpdatedDate>
     <Audience:CreatedBy xsi:type="xsd:string"></Audience:CreatedBy>
     <Audience:UpdatedBy xsi:type="xsd:string"></Audience:UpdatedBy>
    </Audience:ConfigParameter>
   </Audience:SaveConfigParameter>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## SaveConfigParameter Response

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
  <Audience:SaveConfigParameterResponse>
   <Audience:Response xsi:type="Audience:AudienceConfigParameter">
    <Audience:AudienceLayoutId xsi:type="xsd:int">0</Audience:AudienceLayoutId>
    <Audience:Name xsi:type="xsd:string"></Audience:Name>
    <Audience:Value xsi:type="xsd:string"></Audience:Value>
    <Audience:CreatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:47Z</Audience:CreatedDate>
    <Audience:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:47Z</Audience:UpdatedDate>
    <Audience:CreatedBy xsi:type="xsd:string"></Audience:CreatedBy>
    <Audience:UpdatedBy xsi:type="xsd:string"></Audience:UpdatedBy>
   </Audience:Response>
  </Audience:SaveConfigParameterResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
