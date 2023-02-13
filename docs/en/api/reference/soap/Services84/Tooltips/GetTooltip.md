---
title: Services84.TooltipsAgent.GetTooltip SOAP
generated: 1
uid: Services84-Tooltips-GetTooltip
---

# Services84 Tooltips GetTooltip

SOAP request and response examples **Remote/Services84/Tooltips.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ITooltipsAgent.GetTooltip">SuperOffice.Services84.ITooltipsAgent.GetTooltip</see> method.

## GetTooltip





[WSDL file for Services84/Tooltips](../Services84-Tooltips.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTooltip Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Tooltips="http://www.superoffice.net/ws/crm/NetServer/Services84">
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
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Tooltips="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Tooltips:GetTooltipResponse>
   <Tooltips:Response xsi:type="xsd:string"></Tooltips:Response>
  </Tooltips:GetTooltipResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

