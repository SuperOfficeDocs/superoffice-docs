---
title: Services88.LicenseAgent.GetFencingInfo SOAP
generated: true
uid: Services88-License-GetFencingInfo
content_type: reference
---

# Services88 License GetFencingInfo

SOAP request and response examples **Remote/Services88/License.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ILicenseAgent.GetFencingInfo">SuperOffice.Services88.ILicenseAgent.GetFencingInfo</see> method.

## GetFencingInfo





[WSDL file for Services88/License](../Services88-License.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFencingInfo Request

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
   <License:GetFencingInfo>
   </License:GetFencingInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFencingInfo Response

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
  <License:GetFencingInfoResponse>
   <License:Response xsi:type="License:FencingInfo">
    <License:ActiveCount xsi:type="xsd:int">0</License:ActiveCount>
    <License:Maximum xsi:type="xsd:int">0</License:Maximum>
    <License:IsNearingMaximum xsi:type="xsd:boolean">false</License:IsNearingMaximum>
    <License:HasReachedMaximum xsi:type="xsd:boolean">false</License:HasReachedMaximum>
    <License:WarningMessage xsi:type="xsd:string"></License:WarningMessage>
    <License:WarningTooltip xsi:type="xsd:string"></License:WarningTooltip>
   </License:Response>
  </License:GetFencingInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

