---
title: Services88.MarketingAgent.GetAvailableFont SOAP
generated: true
uid: Services88-Marketing-GetAvailableFont
content_type: reference
---

# Services88 Marketing GetAvailableFont

SOAP request and response examples **Remote/Services88/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IMarketingAgent.GetAvailableFont">SuperOffice.Services88.IMarketingAgent.GetAvailableFont</see> method.

## GetAvailableFont





[WSDL file for Services88/Marketing](../Services88-Marketing.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAvailableFont Request

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
   <Marketing:GetAvailableFont>
    <Marketing:AvailableFontId xsi:type="xsd:int">0</Marketing:AvailableFontId>
   </Marketing:GetAvailableFont>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAvailableFont Response

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
  <Marketing:GetAvailableFontResponse>
   <Marketing:Response xsi:type="Marketing:AvailableFont">
    <Marketing:AvailableFontsId xsi:type="xsd:int">0</Marketing:AvailableFontsId>
    <Marketing:DisplayName xsi:type="xsd:string"></Marketing:DisplayName>
    <Marketing:FontFamily xsi:type="xsd:string"></Marketing:FontFamily>
    <Marketing:CssPath xsi:type="xsd:string"></Marketing:CssPath>
    <Marketing:Rank xsi:type="xsd:int">0</Marketing:Rank>
    <Marketing:Deleted xsi:type="xsd:boolean">false</Marketing:Deleted>
   </Marketing:Response>
  </Marketing:GetAvailableFontResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

