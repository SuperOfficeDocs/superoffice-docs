---
title: Services84.EMailAgent.CreateDefaultEMailSOInfo SOAP
generated: 1
uid: Services84-EMail-CreateDefaultEMailSOInfo
---

# Services84 EMail CreateDefaultEMailSOInfo

SOAP request and response examples **Remote/Services84/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IEMailAgent.CreateDefaultEMailSOInfo">SuperOffice.Services84.IEMailAgent.CreateDefaultEMailSOInfo</see> method.

## CreateDefaultEMailSOInfo

Loading default values into a new EMailSOInfo.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance

**Returns:** New EMailSOInfo with default values

[WSDL file for Services84/EMail](../Services84-EMail.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultEMailSOInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:CreateDefaultEMailSOInfo>
   </EMail:CreateDefaultEMailSOInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## CreateDefaultEMailSOInfo Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <EMail:CreateDefaultEMailSOInfoResponse>
   <EMail:Response xsi:type="EMail:EMailSOInfo">
    <EMail:DocumentId xsi:type="xsd:int">0</EMail:DocumentId>
    <EMail:AppointmentId xsi:type="xsd:int">0</EMail:AppointmentId>
    <EMail:ProjectId xsi:type="xsd:int">0</EMail:ProjectId>
    <EMail:SaleId xsi:type="xsd:int">0</EMail:SaleId>
    <EMail:Archived xsi:type="xsd:boolean">false</EMail:Archived>
    <EMail:ArchivedAt xsi:type="xsd:dateTime">2021-11-30T13:22:09Z</EMail:ArchivedAt>
    <EMail:ArchivedBy xsi:type="xsd:int">0</EMail:ArchivedBy>
    <EMail:ArchivedDisplayName xsi:type="xsd:string"></EMail:ArchivedDisplayName>
   </EMail:Response>
  </EMail:CreateDefaultEMailSOInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
