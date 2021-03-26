---
uid: services86-replication-setfreetextsearchenabledonarea
title: Services86.ReplicationAgent.SetFreetextSearchEnabledOnArea SOAP
Generated: true
---

# Services86 Replication SetFreetextSearchEnabledOnArea SOAP

SOAP request and response examples **Remote/Services86/Replication.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IReplicationAgent.SetFreetextSearchEnabledOnArea">SuperOffice.Services86.IReplicationAgent.SetFreetextSearchEnabledOnArea</see> method.

## SetFreetextSearchEnabledOnArea

Enable freetext search on this area
<para /><b>Online Restricted:</b> The Replication agent is not available in Online by default. Not available in Online. Only used on-site.

* **areaId:** The id of the area
* **freetextEnabled:** True if freetextSearch on this area shall be enabled

**Returns:** No return value


[WSDL file for Services86/Replication](../Services86-Replication.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetFreetextSearchEnabledOnArea Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Replication="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Replication="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Replication:SetFreetextSearchEnabledOnAreaResponse>
  </Replication:SetFreetextSearchEnabledOnAreaResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

