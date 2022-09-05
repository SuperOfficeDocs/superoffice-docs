---
title: Services88.ReplicationAgent.GetAreaList SOAP
generated: 1
uid: Services88-Replication-GetAreaList
---

# Services88 Replication GetAreaList

SOAP request and response examples **Remote/Services88/Replication.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IReplicationAgent.GetAreaList">SuperOffice.Services88.IReplicationAgent.GetAreaList</see> method.

## GetAreaList

Gets an array of Area objects.
<para /><b>Online Restricted:</b> The Replication agent is not available in Online by default. Not available in Online. Only used on-site.

* **areaIds:** The identifiers of the Area object

**Returns:** Array of Area objects


[WSDL file for Services88/Replication](../Services88-Replication.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAreaList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Replication="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Replication:ApplicationToken>1234567-1234-9876</Replication:ApplicationToken>
  <Replication:Credentials>
    <Replication:Ticket>7T:1234abcxyzExample==</Replication:Ticket>
  </Replication:Credentials>
 <SOAP-ENV:Body>
   <Replication:GetAreaList>
    <Replication:AreaIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Replication:AreaIds>
   </Replication:GetAreaList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAreaList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Replication="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Replication:GetAreaListResponse>
   <Replication:Response xsi:type="Replication:ArrayOfArea">
    <Replication:Area xsi:type="Replication:Area">
     <Replication:AreaId xsi:type="xsd:int">0</Replication:AreaId>
     <Replication:Name xsi:type="xsd:string"></Replication:Name>
     <Replication:MaxDataAge xsi:type="xsd:short">0</Replication:MaxDataAge>
     <Replication:NumberOfUsers xsi:type="xsd:int">0</Replication:NumberOfUsers>
     <Replication:NumberOfLogins xsi:type="xsd:int">0</Replication:NumberOfLogins>
     <Replication:FreetextEnabeled xsi:type="xsd:boolean">false</Replication:FreetextEnabeled>
    </Replication:Area>
   </Replication:Response>
  </Replication:GetAreaListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

