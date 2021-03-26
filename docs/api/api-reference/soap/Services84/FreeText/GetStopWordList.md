---
uid: services84-freetext-getstopwordlist
title: Services84.FreeTextAgent.GetStopWordList SOAP
Generated: true
---

# Services84 FreeText GetStopWordList SOAP

SOAP request and response examples **Remote/Services84/FreeText.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IFreeTextAgent.GetStopWordList">SuperOffice.Services84.IFreeTextAgent.GetStopWordList</see> method.

## GetStopWordList

Returns the list of stop words


**Returns:** The list of stop words


[WSDL file for Services84/FreeText](../Services84-FreeText.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetStopWordList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <FreeText:ApplicationToken>1234567-1234-9876</FreeText:ApplicationToken>
  <FreeText:Credentials>
    <FreeText:Ticket>7T:1234abcxyzExample==</FreeText:Ticket>
  </FreeText:Credentials>
 <SOAP-ENV:Body>
   <FreeText:GetStopWordList>
   </FreeText:GetStopWordList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetStopWordList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <FreeText:GetStopWordListResponse>
   <FreeText:Response xsi:type="NetServerServices842:ArrayOfstring">
    <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
   </FreeText:Response>
  </FreeText:GetStopWordListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

