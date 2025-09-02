---
title: Services88.TooltipsAgent.GetTooltip SOAP
generated: true
uid: Services88-Tooltips-GetTooltip
content_type: reference
---

# Services88 Tooltips GetTooltip

SOAP request and response examples **Remote/Services88/Tooltips.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITooltipsAgent.GetTooltip">SuperOffice.Services88.ITooltipsAgent.GetTooltip</see> method.

## GetTooltip





[WSDL file for Services88/Tooltips](../Services88-Tooltips.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTooltip Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Tooltips="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Tooltips:ApplicationToken>1234567-1234-9876</Tooltips:ApplicationToken>
  <Tooltips:Credentials>
    <Tooltips:Ticket>7T:1234abcxyzExample==</Tooltips:Ticket>
  </Tooltips:Credentials>
 <SOAP-ENV:Body>
   <Tooltips:GetTooltip>
    <Tooltips:TooltipHint xsi:type="xsd:string"></Tooltips:TooltipHint>
   </Tooltips:GetTooltip>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTooltip Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Tooltips="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Tooltips:GetTooltipResponse>
   <Tooltips:Response xsi:type="xsd:string"></Tooltips:Response>
  </Tooltips:GetTooltipResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

