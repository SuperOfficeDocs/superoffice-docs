---
uid: services88-foreignsystem-getallforeignkeysonentity
title: Services88.ForeignSystemAgent.GetAllForeignKeysOnEntity SOAP
Generated: true
---

# Services88 ForeignSystem GetAllForeignKeysOnEntity SOAP

SOAP request and response examples **Remote/Services88/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IForeignSystemAgent.GetAllForeignKeysOnEntity">SuperOffice.Services88.IForeignSystemAgent.GetAllForeignKeysOnEntity</see> method.

## GetAllForeignKeysOnEntity

Get a list of foreignkeys ('app.device.key') and their values ('123') that belong to the specified entity.

* **entityType:** Entity type (table name): 'contact', 'project' etc.
* **entityId:** Primary key of Entity

**Returns:** Dictionary of 'appname.deviceid.keyname' = '123' key values


[WSDL file for Services88/ForeignSystem](../Services88-ForeignSystem.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllForeignKeysOnEntity Request

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
   <ForeignSystem:GetAllForeignKeysOnEntity>
    <ForeignSystem:EntityType xsi:type="xsd:string"></ForeignSystem:EntityType>
    <ForeignSystem:EntityId xsi:type="xsd:int">0</ForeignSystem:EntityId>
   </ForeignSystem:GetAllForeignKeysOnEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllForeignKeysOnEntity Response

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
  <ForeignSystem:GetAllForeignKeysOnEntityResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:StringDictionary">
    <ForeignSystem:StringKeyValuePair>
     <ForeignSystem:Key xsi:type="xsd:string"></ForeignSystem:Key>
     <ForeignSystem:Value xsi:type="xsd:string"></ForeignSystem:Value>
    </ForeignSystem:StringKeyValuePair>
   </ForeignSystem:Response>
  </ForeignSystem:GetAllForeignKeysOnEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

