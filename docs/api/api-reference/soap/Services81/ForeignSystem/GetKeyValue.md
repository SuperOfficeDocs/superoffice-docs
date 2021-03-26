---
uid: services81-foreignsystem-getkeyvalue
title: Services81.ForeignSystemAgent.GetKeyValue SOAP
Generated: true
---

# Services81 ForeignSystem GetKeyValue SOAP

SOAP request and response examples **Remote/Services81/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IForeignSystemAgent.GetKeyValue">SuperOffice.Services81.IForeignSystemAgent.GetKeyValue</see> method.

## GetKeyValue

Gets the string value of a ForeignKey, that belongs to the specified device and application. A table name and record ID can also be specified.

* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **keyName:** The name of the foreign key.
* **tableName:** Table name, transformed to and from numeric table id by the service layer.<p />Use an empty string to indicate that your key is not bound to any specific table.
* **recordId:** Id of record that this key refers to. If the table name was blank, then this parameter must be 0. It can also be 0 to mean that the foreign key record was not bound to any particular record of the target table.

**Returns:** The ForeignKey value as string.


[WSDL file for Services81/ForeignSystem](../Services81-ForeignSystem.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetKeyValue Request

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
   <ForeignSystem:GetKeyValue>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
    <ForeignSystem:DeviceName xsi:type="xsd:string"></ForeignSystem:DeviceName>
    <ForeignSystem:KeyName xsi:type="xsd:string"></ForeignSystem:KeyName>
    <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
    <ForeignSystem:RecordId xsi:type="xsd:int">0</ForeignSystem:RecordId>
   </ForeignSystem:GetKeyValue>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetKeyValue Response

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
  <ForeignSystem:GetKeyValueResponse>
   <ForeignSystem:Response xsi:type="xsd:string"></ForeignSystem:Response>
  </ForeignSystem:GetKeyValueResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

