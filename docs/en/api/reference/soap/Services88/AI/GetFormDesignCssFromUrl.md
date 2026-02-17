---
title: Services88.AIAgent.GetFormDesignCssFromUrl SOAP
generated: true
uid: Services88-AI-GetFormDesignCssFromUrl
content_type: reference
---

# Services88 AI GetFormDesignCssFromUrl

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.GetFormDesignCssFromUrl">SuperOffice.Services88.IAIAgent.GetFormDesignCssFromUrl</see> method.

## GetFormDesignCssFromUrl





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFormDesignCssFromUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <AI:ApplicationToken>1234567-1234-9876</AI:ApplicationToken>
  <AI:Credentials>
    <AI:Ticket>7T:1234abcxyzExample==</AI:Ticket>
  </AI:Credentials>
 <SOAP-ENV:Body>
   <AI:GetFormDesignCssFromUrl>
    <AI:Url xsi:type="xsd:string"></AI:Url>
    <AI:CssClasses xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </AI:CssClasses>
   </AI:GetFormDesignCssFromUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFormDesignCssFromUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <AI:GetFormDesignCssFromUrlResponse>
   <AI:Response xsi:type="AI:FormDesignCarrier">
    <AI:CssStyles xsi:type="xsd:string"></AI:CssStyles>
    <AI:Confidence xsi:type="xsd:double">0.0</AI:Confidence>
    <AI:Notes xsi:type="xsd:string"></AI:Notes>
   </AI:Response>
  </AI:GetFormDesignCssFromUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

