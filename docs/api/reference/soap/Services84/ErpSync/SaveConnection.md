---
title: Services84.ErpSyncAgent.SaveConnection SOAP
generated: 1
uid: Services84-ErpSync-SaveConnection
---

# Services84 ErpSync SaveConnection

SOAP request and response examples **Remote/Services84/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IErpSyncAgent.SaveConnection">SuperOffice.Services84.IErpSyncAgent.SaveConnection</see> method.

## SaveConnection

Saves a connection to the database.

* **connection:** The connection to save.

**Returns:** The resulting connection.


[WSDL file for Services84/ErpSync](../Services84-ErpSync.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveConnection Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:SaveConnection>
    <ErpSync:Connection xsi:type="ErpSync:ErpConnection">
     <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
     <ErpSync:ErpConnectorId xsi:type="xsd:int">0</ErpSync:ErpConnectorId>
     <ErpSync:DisplayName xsi:type="xsd:string"></ErpSync:DisplayName>
     <ErpSync:DisplayDescription xsi:type="xsd:string"></ErpSync:DisplayDescription>
     <ErpSync:Active xsi:type="xsd:boolean">false</ErpSync:Active>
     <ErpSync:ConnectionId xsi:type="xsd:string"></ErpSync:ConnectionId>
     <ErpSync:MostRecentTimestamp xsi:type="xsd:string"></ErpSync:MostRecentTimestamp>
     <ErpSync:ConfigFields xsi:type="ErpSync:StringDictionary">
      <ErpSync:StringKeyValuePair>
       <ErpSync:Key xsi:type="xsd:string"></ErpSync:Key>
       <ErpSync:Value xsi:type="xsd:string"></ErpSync:Value>
      </ErpSync:StringKeyValuePair>
     </ErpSync:ConfigFields>
     <ErpSync:Deleted xsi:type="xsd:boolean">false</ErpSync:Deleted>
     <ErpSync:AllAccess xsi:type="xsd:boolean">false</ErpSync:AllAccess>
     <ErpSync:UserGroupAccessIds xsi:type="NetServerServices842:ArrayOfint">
      <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
     </ErpSync:UserGroupAccessIds>
     <ErpSync:AssociateAccessIds xsi:type="NetServerServices842:ArrayOfint">
      <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
     </ErpSync:AssociateAccessIds>
    </ErpSync:Connection>
   </ErpSync:SaveConnection>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveConnection Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <ErpSync:SaveConnectionResponse>
   <ErpSync:Response xsi:type="ErpSync:ErpConnection">
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:ErpConnectorId xsi:type="xsd:int">0</ErpSync:ErpConnectorId>
    <ErpSync:DisplayName xsi:type="xsd:string"></ErpSync:DisplayName>
    <ErpSync:DisplayDescription xsi:type="xsd:string"></ErpSync:DisplayDescription>
    <ErpSync:Active xsi:type="xsd:boolean">false</ErpSync:Active>
    <ErpSync:ConnectionId xsi:type="xsd:string"></ErpSync:ConnectionId>
    <ErpSync:MostRecentTimestamp xsi:type="xsd:string"></ErpSync:MostRecentTimestamp>
    <ErpSync:ConfigFields xsi:type="ErpSync:StringDictionary">
     <ErpSync:StringKeyValuePair>
      <ErpSync:Key xsi:type="xsd:string"></ErpSync:Key>
      <ErpSync:Value xsi:type="xsd:string"></ErpSync:Value>
     </ErpSync:StringKeyValuePair>
    </ErpSync:ConfigFields>
    <ErpSync:Deleted xsi:type="xsd:boolean">false</ErpSync:Deleted>
    <ErpSync:AllAccess xsi:type="xsd:boolean">false</ErpSync:AllAccess>
    <ErpSync:UserGroupAccessIds xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </ErpSync:UserGroupAccessIds>
    <ErpSync:AssociateAccessIds xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </ErpSync:AssociateAccessIds>
   </ErpSync:Response>
  </ErpSync:SaveConnectionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

