---
uid: services80-replication-setfreetextsearchenabledonarea
title: Services80.ReplicationAgent.SetFreetextSearchEnabledOnArea SOAP
Generated: true
---

# Services80 Replication SetFreetextSearchEnabledOnArea SOAP

SOAP request and response examples **Remote/Services80/Replication.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IReplicationAgent.SetFreetextSearchEnabledOnArea">SuperOffice.Services80.IReplicationAgent.SetFreetextSearchEnabledOnArea</see> method.

## SetFreetextSearchEnabledOnArea

Enable freetext search on this area

* **areaId:** The id of the area
* **freetextEnabled:** True if freetextSearch on this area shall be enabled

**Returns:** No return value


[WSDL file for Services80/Replication](../Services80-Replication.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetFreetextSearchEnabledOnArea Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Replication="http://www.superoffice.net/ws/crm/NetServer/Services80">
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
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Replication="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Replication:SetFreetextSearchEnabledOnAreaResponse>
  </Replication:SetFreetextSearchEnabledOnAreaResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

