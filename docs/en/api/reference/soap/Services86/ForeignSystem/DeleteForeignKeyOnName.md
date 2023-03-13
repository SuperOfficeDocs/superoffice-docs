---
title: Services86.ForeignSystemAgent.DeleteForeignKeyOnName SOAP
generated: 1
uid: Services86-ForeignSystem-DeleteForeignKeyOnName
---

# Services86 ForeignSystem DeleteForeignKeyOnName

SOAP request and response examples **Remote/Services86/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IForeignSystemAgent.DeleteForeignKeyOnName">SuperOffice.Services86.IForeignSystemAgent.DeleteForeignKeyOnName</see> method.

## DeleteForeignKeyOnName





[WSDL file for Services86/ForeignSystem](../Services86-ForeignSystem.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteForeignKeyOnName Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:DeleteForeignKeyOnName>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
    <ForeignSystem:DeviceName xsi:type="xsd:string"></ForeignSystem:DeviceName>
    <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
    <ForeignSystem:KeyName xsi:type="xsd:string"></ForeignSystem:KeyName>
    <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
    <ForeignSystem:RecordId xsi:type="xsd:int">0</ForeignSystem:RecordId>
   </ForeignSystem:DeleteForeignKeyOnName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteForeignKeyOnName Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <ForeignSystem:DeleteForeignKeyOnNameResponse>
  </ForeignSystem:DeleteForeignKeyOnNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

