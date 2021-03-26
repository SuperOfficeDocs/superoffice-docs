---
uid: services80-freetext-getstopwordlist
title: Services80.FreeTextAgent.GetStopWordList SOAP
Generated: true
---

# Services80 FreeText GetStopWordList SOAP

SOAP request and response examples **Remote/Services80/FreeText.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IFreeTextAgent.GetStopWordList">SuperOffice.Services80.IFreeTextAgent.GetStopWordList</see> method.

## GetStopWordList

Returns the list of stop words


**Returns:** The list of stop words


[WSDL file for Services80/FreeText](../Services80-FreeText.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetStopWordList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services80">
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
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <FreeText:GetStopWordListResponse>
   <FreeText:Response xsi:type="NetServerServices802:ArrayOfstring">
    <NetServerServices802:string xsi:type="xsd:string"></NetServerServices802:string>
   </FreeText:Response>
  </FreeText:GetStopWordListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

