---
uid: services88-erpsync-saveconnection
title: Services88.ErpSyncAgent.SaveConnection SOAP
Generated: true
---

# Services88 ErpSync SaveConnection SOAP

SOAP request and response examples **Remote/Services88/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IErpSyncAgent.SaveConnection">SuperOffice.Services88.IErpSyncAgent.SaveConnection</see> method.

## SaveConnection

Saves a connection to the database.
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.

* **connection:** The connection to save.

**Returns:** The resulting connection.


[WSDL file for Services88/ErpSync](../Services88-ErpSync.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveConnection Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
     <ErpSync:UserGroupAccessIds xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </ErpSync:UserGroupAccessIds>
     <ErpSync:AssociateAccessIds xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
    <ErpSync:UserGroupAccessIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </ErpSync:UserGroupAccessIds>
    <ErpSync:AssociateAccessIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </ErpSync:AssociateAccessIds>
   </ErpSync:Response>
  </ErpSync:SaveConnectionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

