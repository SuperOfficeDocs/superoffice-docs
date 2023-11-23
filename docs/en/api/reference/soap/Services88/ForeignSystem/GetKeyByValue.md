---
title: Services88.ForeignSystemAgent.GetKeyByValue SOAP
generated: true
uid: Services88-ForeignSystem-GetKeyByValue
---

# Services88 ForeignSystem GetKeyByValue

SOAP request and response examples **Remote/Services88/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IForeignSystemAgent.GetKeyByValue">SuperOffice.Services88.IForeignSystemAgent.GetKeyByValue</see> method.

## GetKeyByValue





[WSDL file for Services88/ForeignSystem](../Services88-ForeignSystem.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetKeyByValue Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:GetKeyByValue>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
    <ForeignSystem:DeviceName xsi:type="xsd:string"></ForeignSystem:DeviceName>
    <ForeignSystem:KeyName xsi:type="xsd:string"></ForeignSystem:KeyName>
    <ForeignSystem:KeyValue xsi:type="xsd:string"></ForeignSystem:KeyValue>
    <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
   </ForeignSystem:GetKeyByValue>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetKeyByValue Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <ForeignSystem:GetKeyByValueResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:ForeignKey">
    <ForeignSystem:Key xsi:type="xsd:string"></ForeignSystem:Key>
    <ForeignSystem:Value xsi:type="xsd:string"></ForeignSystem:Value>
    <ForeignSystem:RecordId xsi:type="xsd:int">0</ForeignSystem:RecordId>
    <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2023-11-10T12:36:56Z</ForeignSystem:CreatedDate>
    <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2023-11-10T12:36:56Z</ForeignSystem:UpdatedDate>
    <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
    <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
    <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
   </ForeignSystem:Response>
  </ForeignSystem:GetKeyByValueResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

