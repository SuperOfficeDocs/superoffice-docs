---
uid: services86-email-getemailsoinfo
title: Services86.EMailAgent.GetEMailSOInfo SOAP
Generated: true
---

# Services86 EMail GetEMailSOInfo SOAP

SOAP request and response examples **Remote/Services86/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IEMailAgent.GetEMailSOInfo">SuperOffice.Services86.IEMailAgent.GetEMailSOInfo</see> method.

## GetEMailSOInfo

Gets a EMailSOInfo object.
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **eMailSOInfoId:** The identifier of the EMailSOInfo object

**Returns:** EMailSOInfo


[WSDL file for Services86/EMail](../Services86-EMail.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetEMailSOInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetEMailSOInfo>
    <EMail:EMailSOInfoId xsi:type="xsd:int">0</EMail:EMailSOInfoId>
   </EMail:GetEMailSOInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetEMailSOInfo Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <EMail:GetEMailSOInfoResponse>
   <EMail:Response xsi:type="EMail:EMailSOInfo">
    <EMail:DocumentId xsi:type="xsd:int">0</EMail:DocumentId>
    <EMail:AppointmentId xsi:type="xsd:int">0</EMail:AppointmentId>
    <EMail:ProjectId xsi:type="xsd:int">0</EMail:ProjectId>
    <EMail:SaleId xsi:type="xsd:int">0</EMail:SaleId>
    <EMail:Archived xsi:type="xsd:boolean">false</EMail:Archived>
    <EMail:ArchivedAt xsi:type="xsd:dateTime">2021-03-25T21:36:08Z</EMail:ArchivedAt>
    <EMail:ArchivedBy xsi:type="xsd:int">0</EMail:ArchivedBy>
    <EMail:ArchivedDisplayName xsi:type="xsd:string"></EMail:ArchivedDisplayName>
   </EMail:Response>
  </EMail:GetEMailSOInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

