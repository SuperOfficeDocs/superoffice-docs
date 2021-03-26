---
uid: services86-tooltips-gettooltip
title: Services86.TooltipsAgent.GetTooltip SOAP
Generated: true
---

# Services86 Tooltips GetTooltip SOAP

SOAP request and response examples **Remote/Services86/Tooltips.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ITooltipsAgent.GetTooltip">SuperOffice.Services86.ITooltipsAgent.GetTooltip</see> method.

## GetTooltip

Parse a tooltip hint and return a tooltip. The returned tooltip string may contain resource string identifiers (in square brackets), to be processed by the resource manager.&lt;para /&gt;The tooltip hint is either a literal text, representing itself, or a set of key/value pairs enclosed in curly braces. Each key is separated from its value by an equals sign, and each pair from the next by an ampersand, according to usual conventions.&lt;para /&gt;A typical tooltip hint could be {contact\_id=123} or {appointment\_id=222&amp;amp;mode=simple}

* **tooltipHint:** 



[WSDL file for Services86/Tooltips](../Services86-Tooltips.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTooltip Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Tooltips="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Tooltips="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Tooltips:GetTooltipResponse>
   <Tooltips:Response xsi:type="xsd:string"></Tooltips:Response>
  </Tooltips:GetTooltipResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

