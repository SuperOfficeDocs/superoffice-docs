---
uid: services83-archive-getgroupassociateids
title: Services83.ArchiveAgent.GetGroupAssociateIds SOAP
Generated: true
---

# Services83 Archive GetGroupAssociateIds SOAP

SOAP request and response examples **Remote/Services83/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IArchiveAgent.GetGroupAssociateIds">SuperOffice.Services83.IArchiveAgent.GetGroupAssociateIds</see> method.

## GetGroupAssociateIds

Returns the  associate ids that belongs to the given groups

* **groupIds:** Array of group ids

**Returns:** Array of associate ids


[WSDL file for Services83/Archive](../Services83-Archive.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetGroupAssociateIds Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:GetGroupAssociateIds>
    <Archive:GroupIds xsi:type="NetServerServices832:ArrayOfint">
     <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
    </Archive:GroupIds>
   </Archive:GetGroupAssociateIds>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetGroupAssociateIds Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Archive:GetGroupAssociateIdsResponse>
   <Archive:Response xsi:type="NetServerServices832:ArrayOfint">
    <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
   </Archive:Response>
  </Archive:GetGroupAssociateIdsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

