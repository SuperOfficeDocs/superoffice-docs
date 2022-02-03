---
title: Services84.ReplicationAgent.SetFreetextSearchEnabledOnArea SOAP
generated: 1
uid: Services84-Replication-SetFreetextSearchEnabledOnArea
---

# Services84 Replication SetFreetextSearchEnabledOnArea

SOAP request and response examples **Remote/Services84/Replication.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IReplicationAgent.SetFreetextSearchEnabledOnArea">SuperOffice.Services84.IReplicationAgent.SetFreetextSearchEnabledOnArea</see> method.

## SetFreetextSearchEnabledOnArea

Enable freetext search on this area

* **areaId:** The id of the area
* **freetextEnabled:** True if freetextSearch on this area shall be enabled

**Returns:** No return value


[WSDL file for Services84/Replication](../Services84-Replication.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetFreetextSearchEnabledOnArea Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Replication="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Replication:ApplicationToken>1234567-1234-9876</Replication:ApplicationToken>
  <Replication:Credentials>
    <Replication:Ticket>7T:1234abcxyzExample==</Replication:Ticket>
  </Replication:Credentials>
 <SOAP-ENV:Body>
   <Replication:SetFreetextSearchEnabledOnArea>
    <Replication:AreaId xsi:type="xsd:int">0</Replication:AreaId>
    <Replication:FreetextEnabled xsi:type="xsd:boolean">false</Replication:FreetextEnabled>
   </Replication:SetFreetextSearchEnabledOnArea>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetFreetextSearchEnabledOnArea Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Replication="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Replication:SetFreetextSearchEnabledOnAreaResponse>
  </Replication:SetFreetextSearchEnabledOnAreaResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

