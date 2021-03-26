---
uid: services81-license-changeserialnumber
title: Services81.LicenseAgent.ChangeSerialNumber SOAP
Generated: true
---

# Services81 License ChangeSerialNumber SOAP

SOAP request and response examples **Remote/Services81/License.svc**
Implemented by the <see cref="M:SuperOffice.Services81.ILicenseAgent.ChangeSerialNumber">SuperOffice.Services81.ILicenseAgent.ChangeSerialNumber</see> method.

## ChangeSerialNumber

Change the new serial number for the installation.

* **newCompanyName:** The new company name
* **newSerialNumber:** New serial number to change to.



[WSDL file for Services81/License](../Services81-License.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangeSerialNumber Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
 xmlns:NetServerServices812="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services81">
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

