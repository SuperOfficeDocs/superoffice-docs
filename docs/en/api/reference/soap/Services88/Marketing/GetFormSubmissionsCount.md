---
title: Services88.MarketingAgent.GetFormSubmissionsCount SOAP
generated: true
uid: Services88-Marketing-GetFormSubmissionsCount
content_type: reference
---

# Services88 Marketing GetFormSubmissionsCount

SOAP request and response examples **Remote/Services88/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IMarketingAgent.GetFormSubmissionsCount">SuperOffice.Services88.IMarketingAgent.GetFormSubmissionsCount</see> method.

## GetFormSubmissionsCount





[WSDL file for Services88/Marketing](../Services88-Marketing.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFormSubmissionsCount Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Marketing:ApplicationToken>1234567-1234-9876</Marketing:ApplicationToken>
  <Marketing:Credentials>
    <Marketing:Ticket>7T:1234abcxyzExample==</Marketing:Ticket>
  </Marketing:Credentials>
 <SOAP-ENV:Body>
   <Marketing:GetFormSubmissionsCount>
    <Marketing:FormId xsi:type="xsd:int">0</Marketing:FormId>
    <Marketing:Status xsi:type="Marketing:FormSubmissionStatus">Unknown</Marketing:Status>
   </Marketing:GetFormSubmissionsCount>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFormSubmissionsCount Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Marketing:GetFormSubmissionsCountResponse>
   <Marketing:Response xsi:type="xsd:int">0</Marketing:Response>
  </Marketing:GetFormSubmissionsCountResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

