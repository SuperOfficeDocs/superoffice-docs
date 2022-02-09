---
title: Services88.LicenseAgent.ChangeSerialNumber SOAP
generated: 1
uid: Services88-License-ChangeSerialNumber
---

# Services88 License ChangeSerialNumber

SOAP request and response examples **Remote/Services88/License.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ILicenseAgent.ChangeSerialNumber">SuperOffice.Services88.ILicenseAgent.ChangeSerialNumber</see> method.

## ChangeSerialNumber

Change the new serial number for the installation. Requests a new license from SuperLicense, checks if change is authorized.

* **newCompanyName:** The new company name
* **newSerialNumber:** New serial number to change to.

**Returns:** License after serial number/name change


[WSDL file for Services88/License](../Services88-License.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangeSerialNumber Request

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
   <License:ChangeSerialNumber>
    <License:NewCompanyName xsi:type="xsd:string"></License:NewCompanyName>
    <License:NewSerialNumber xsi:type="xsd:string"></License:NewSerialNumber>
   </License:ChangeSerialNumber>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChangeSerialNumber Response

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
  <License:ChangeSerialNumberResponse>
   <License:Response xsi:type="License:LicenseResult">
    <License:Succeeded xsi:type="xsd:boolean">false</License:Succeeded>
    <License:Reason xsi:type="xsd:string"></License:Reason>
   </License:Response>
  </License:ChangeSerialNumberResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

