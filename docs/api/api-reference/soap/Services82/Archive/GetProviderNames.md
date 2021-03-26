---
uid: services82-archive-getprovidernames
title: Services82.ArchiveAgent.GetProviderNames SOAP
Generated: true
---

# Services82 Archive GetProviderNames SOAP

SOAP request and response examples **Remote/Services82/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IArchiveAgent.GetProviderNames">SuperOffice.Services82.IArchiveAgent.GetProviderNames</see> method.

## GetProviderNames

Return list of all archive provider names


**Returns:** Array of all archive provider names.


[WSDL file for Services82/Archive](../Services82-Archive.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProviderNames Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services82">
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
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Archive:GetProviderNamesResponse>
   <Archive:Response xsi:type="NetServerServices822:ArrayOfstring">
    <NetServerServices822:string xsi:type="xsd:string"></NetServerServices822:string>
   </Archive:Response>
  </Archive:GetProviderNamesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

