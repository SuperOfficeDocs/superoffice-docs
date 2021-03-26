---
uid: services83-archive-getprovidernames
title: Services83.ArchiveAgent.GetProviderNames SOAP
Generated: true
---

# Services83 Archive GetProviderNames SOAP

SOAP request and response examples **Remote/Services83/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IArchiveAgent.GetProviderNames">SuperOffice.Services83.IArchiveAgent.GetProviderNames</see> method.

## GetProviderNames

Return list of all archive provider names


**Returns:** Array of all archive provider names.


[WSDL file for Services83/Archive](../Services83-Archive.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProviderNames Request

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
   <Archive:GetProviderNames>
   </Archive:GetProviderNames>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProviderNames Response

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
  <Archive:GetProviderNamesResponse>
   <Archive:Response xsi:type="NetServerServices832:ArrayOfstring">
    <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
   </Archive:Response>
  </Archive:GetProviderNamesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

