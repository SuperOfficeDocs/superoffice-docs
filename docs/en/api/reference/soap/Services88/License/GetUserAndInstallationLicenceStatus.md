---
title: Services88.LicenseAgent.GetUserAndInstallationLicenceStatus SOAP
generated: true
uid: Services88-License-GetUserAndInstallationLicenceStatus
---

# Services88 License GetUserAndInstallationLicenceStatus

SOAP request and response examples **Remote/Services88/License.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ILicenseAgent.GetUserAndInstallationLicenceStatus">SuperOffice.Services88.ILicenseAgent.GetUserAndInstallationLicenceStatus</see> method.

## GetUserAndInstallationLicenceStatus





[WSDL file for Services88/License](../Services88-License.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUserAndInstallationLicenceStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices883="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <License:ApplicationToken>1234567-1234-9876</License:ApplicationToken>
  <License:Credentials>
    <License:Ticket>7T:1234abcxyzExample==</License:Ticket>
  </License:Credentials>
 <SOAP-ENV:Body>
   <License:GetUserAndInstallationLicenceStatus>
    <License:AssociateId xsi:type="xsd:int">0</License:AssociateId>
   </License:GetUserAndInstallationLicenceStatus>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUserAndInstallationLicenceStatus Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices883="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <License:GetUserAndInstallationLicenceStatusResponse>
   <License:Response xsi:type="License:UserAndInstallationLicenceStatus">
    <License:AdminWarningDate xsi:type="xsd:dateTime">2025-06-26T01:44:04Z</License:AdminWarningDate>
    <License:ExpiryDate xsi:type="xsd:dateTime">2025-06-26T01:44:04Z</License:ExpiryDate>
    <License:GraceDate xsi:type="xsd:dateTime">2025-06-26T01:44:04Z</License:GraceDate>
    <License:CompanyName xsi:type="xsd:string"></License:CompanyName>
    <License:SerialNr xsi:type="xsd:string"></License:SerialNr>
    <License:UserLicenses xsi:type="NetServerServices883:ArrayOfstring">
     <NetServerServices883:string xsi:type="xsd:string"></NetServerServices883:string>
    </License:UserLicenses>
   </License:Response>
  </License:GetUserAndInstallationLicenceStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

