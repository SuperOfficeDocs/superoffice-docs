---
uid: services85-license-getshopurl
title: Services85.LicenseAgent.GetShopUrl SOAP
Generated: true
---

# Services85 License GetShopUrl SOAP

SOAP request and response examples **Remote/Services85/License.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ILicenseAgent.GetShopUrl">SuperOffice.Services85.ILicenseAgent.GetShopUrl</see> method.

## GetShopUrl

Get the shop URL for the specified module owner. This can be used to redirect user to the web shop.

* **ownerName:** Name of the module owner.

**Returns:** The URL which contains the shop for the specified module owner.


[WSDL file for Services85/License](../Services85-License.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetShopUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices853="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <License:ApplicationToken>1234567-1234-9876</License:ApplicationToken>
  <License:Credentials>
    <License:Ticket>7T:1234abcxyzExample==</License:Ticket>
  </License:Credentials>
 <SOAP-ENV:Body>
   <License:GetShopUrl>
    <License:OwnerName xsi:type="xsd:string"></License:OwnerName>
   </License:GetShopUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetShopUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices853="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <License:GetShopUrlResponse>
   <License:Response xsi:type="xsd:string"></License:Response>
  </License:GetShopUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

