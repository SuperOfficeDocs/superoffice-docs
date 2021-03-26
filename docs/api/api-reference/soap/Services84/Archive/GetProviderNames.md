---
uid: services84-archive-getprovidernames
title: Services84.ArchiveAgent.GetProviderNames SOAP
Generated: true
---

# Services84 Archive GetProviderNames SOAP

SOAP request and response examples **Remote/Services84/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IArchiveAgent.GetProviderNames">SuperOffice.Services84.IArchiveAgent.GetProviderNames</see> method.

## GetProviderNames

Return list of all archive provider names


**Returns:** Array of all archive provider names.


[WSDL file for Services84/Archive](../Services84-Archive.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProviderNames Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services84">
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
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Archive:GetProviderNamesResponse>
   <Archive:Response xsi:type="NetServerServices842:ArrayOfstring">
    <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
   </Archive:Response>
  </Archive:GetProviderNamesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

