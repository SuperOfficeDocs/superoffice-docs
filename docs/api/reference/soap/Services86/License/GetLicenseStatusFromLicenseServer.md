---
title: Services86.LicenseAgent.GetLicenseStatusFromLicenseServer SOAP
generated: 1
uid: Services86-License-GetLicenseStatusFromLicenseServer
---

# Services86 License GetLicenseStatusFromLicenseServer

SOAP request and response examples **Remote/Services86/License.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ILicenseAgent.GetLicenseStatusFromLicenseServer">SuperOffice.Services86.ILicenseAgent.GetLicenseStatusFromLicenseServer</see> method.

## GetLicenseStatusFromLicenseServer

Get License from the license server for a particular module owner.

* **ownerName:** Name of the module owner to get license from.

**Returns:** License from the database, from the license server and with usage.


[WSDL file for Services86/License](../Services86-License.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLicenseStatusFromLicenseServer Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices863="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
 xmlns:NetServerServices862="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices863="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services86">
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

