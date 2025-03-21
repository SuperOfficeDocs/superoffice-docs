---
title: Services84.LicenseAgent.GetLicenseStatusFromLicenseServer SOAP
generated: 1
uid: Services84-License-GetLicenseStatusFromLicenseServer
---

# Services84 License GetLicenseStatusFromLicenseServer

SOAP request and response examples **Remote/Services84/License.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ILicenseAgent.GetLicenseStatusFromLicenseServer">SuperOffice.Services84.ILicenseAgent.GetLicenseStatusFromLicenseServer</see> method.

## GetLicenseStatusFromLicenseServer

[WSDL file for Services84/License](../Services84-License.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLicenseStatusFromLicenseServer Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices843="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <License:ApplicationToken>1234567-1234-9876</License:ApplicationToken>
  <License:Credentials>
    <License:Ticket>7T:1234abcxyzExample==</License:Ticket>
  </License:Credentials>
 <SOAP-ENV:Body>
   <License:GetLicenseStatusFromLicenseServer>
    <License:OwnerName xsi:type="xsd:string"></License:OwnerName>
   </License:GetLicenseStatusFromLicenseServer>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetLicenseStatusFromLicenseServer Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices843="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <License:GetLicenseStatusFromLicenseServerResponse>
   <License:Response xsi:type="License:CheckLicenseStatusResult">
    <License:LicenseStatus xsi:type="License:LicenseStatus">Ok</License:LicenseStatus>
    <License:Message xsi:type="xsd:string"></License:Message>
    <License:Url xsi:type="xsd:string"></License:Url>
   </License:Response>
  </License:GetLicenseStatusFromLicenseServerResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
