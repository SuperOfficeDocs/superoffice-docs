---
title: Services88.FreeTextAgent.GetStatus SOAP
generated: true
uid: Services88-FreeText-GetStatus
---

# Services88 FreeText GetStatus

SOAP request and response examples **Remote/Services88/FreeText.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFreeTextAgent.GetStatus">SuperOffice.Services88.IFreeTextAgent.GetStatus</see> method.

## GetStatus





[WSDL file for Services88/FreeText](../Services88-FreeText.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <FreeText:ApplicationToken>1234567-1234-9876</FreeText:ApplicationToken>
  <FreeText:Credentials>
    <FreeText:Ticket>7T:1234abcxyzExample==</FreeText:Ticket>
  </FreeText:Credentials>
 <SOAP-ENV:Body>
   <FreeText:GetStatus>
   </FreeText:GetStatus>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetStatus Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <FreeText:GetStatusResponse>
   <FreeText:Response xsi:type="FreeText:FreeText">
    <FreeText:FreeTextEnabled xsi:type="xsd:boolean">false</FreeText:FreeTextEnabled>
    <FreeText:SingleWordOperator xsi:type="FreeText:FreeTextOperator">Contains</FreeText:SingleWordOperator>
    <FreeText:MultiWordOperator xsi:type="FreeText:FreeTextOperator">Contains</FreeText:MultiWordOperator>
    <FreeText:CountWords xsi:type="xsd:int">0</FreeText:CountWords>
    <FreeText:Occurrences xsi:type="xsd:int">0</FreeText:Occurrences>
    <FreeText:LastGenerated xsi:type="xsd:dateTime">2025-06-26T01:44:04Z</FreeText:LastGenerated>
    <FreeText:AutoEnableTravelAreas xsi:type="xsd:boolean">false</FreeText:AutoEnableTravelAreas>
   </FreeText:Response>
  </FreeText:GetStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

