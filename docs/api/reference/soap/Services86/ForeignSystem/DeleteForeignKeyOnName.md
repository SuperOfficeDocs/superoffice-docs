---
title: Services86.ForeignSystemAgent.DeleteForeignKeyOnName SOAP
generated: 1
uid: Services86-ForeignSystem-DeleteForeignKeyOnName
---

# Services86 ForeignSystem DeleteForeignKeyOnName

SOAP request and response examples **Remote/Services86/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IForeignSystemAgent.DeleteForeignKeyOnName">SuperOffice.Services86.IForeignSystemAgent.DeleteForeignKeyOnName</see> method.

## DeleteForeignKeyOnName

Deletes all specified occurrences of a key, belonging to the ForeignApp and ForeignDevice, table and record specified. Specifying a blank table name will delete ALL keys of the given name; specifying a recordId of 0 will delete ALL keys of the given name for the given table.

* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** The device identifier. Optional if device identifier is not used.
* **keyName:** The name of the foreign key to delete.
* **tableName:** Table name, transformed to and from numeric table id by the service layer.&lt;p/&gt;Use an empty string to delete ALL keys that otherwise match; this may be dangerous and can take a long time if there are many items to delete.
* **recordId:** Id of record that this key refers to. If the table name was blank, then this parameter must be 0. It can also be 0 to mean that the foreign key record was not bound to any particular record of the target table.&lt;p/&gt;Specifying a zero recordId will remove the recordId restriction and delete all keys that otherwise match.

**Returns:** This method has no return value


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

