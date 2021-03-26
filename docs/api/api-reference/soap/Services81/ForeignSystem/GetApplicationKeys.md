---
uid: services81-foreignsystem-getapplicationkeys
title: Services81.ForeignSystemAgent.GetApplicationKeys SOAP
Generated: true
---

# Services81 ForeignSystem GetApplicationKeys SOAP

SOAP request and response examples **Remote/Services81/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IForeignSystemAgent.GetApplicationKeys">SuperOffice.Services81.IForeignSystemAgent.GetApplicationKeys</see> method.

## GetApplicationKeys

Returns all ForeignKeys that belong to an application.

* **applicationName:** The name of the foreign application.

**Returns:** Array of all ForeignKeys in the ForeignApp.


[WSDL file for Services81/ForeignSystem](../Services81-ForeignSystem.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetApplicationKeys Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:GetApplicationKeys>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
   </ForeignSystem:GetApplicationKeys>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetApplicationKeys Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <ForeignSystem:GetApplicationKeysResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:ArrayOfForeignKey">
    <ForeignSystem:ForeignKey xsi:type="ForeignSystem:ForeignKey">
     <ForeignSystem:Key xsi:type="xsd:string"></ForeignSystem:Key>
     <ForeignSystem:Value xsi:type="xsd:string"></ForeignSystem:Value>
     <ForeignSystem:RecordId xsi:type="xsd:int">0</ForeignSystem:RecordId>
     <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:34:29Z</ForeignSystem:CreatedDate>
     <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:34:29Z</ForeignSystem:UpdatedDate>
     <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
     <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
     <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
    </ForeignSystem:ForeignKey>
   </ForeignSystem:Response>
  </ForeignSystem:GetApplicationKeysResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

