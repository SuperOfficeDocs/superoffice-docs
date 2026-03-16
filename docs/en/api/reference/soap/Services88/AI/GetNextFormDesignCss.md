---
title: Services88.AIAgent.GetNextFormDesignCss SOAP
generated: true
uid: Services88-AI-GetNextFormDesignCss
content_type: reference
---

# Services88 AI GetNextFormDesignCss

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.GetNextFormDesignCss">SuperOffice.Services88.IAIAgent.GetNextFormDesignCss</see> method.

## GetNextFormDesignCss





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNextFormDesignCss Request

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
   <AI:GetNextFormDesignCss>
    <AI:State xsi:type="xsd:string"></AI:State>
    <AI:CssClass xsi:type="xsd:string"></AI:CssClass>
   </AI:GetNextFormDesignCss>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNextFormDesignCss Response

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
  <AI:GetNextFormDesignCssResponse>
   <AI:Response xsi:type="AI:FormDesignCss">
    <AI:CssClass xsi:type="xsd:string"></AI:CssClass>
    <AI:CssRule xsi:type="xsd:string"></AI:CssRule>
    <AI:State xsi:type="xsd:string"></AI:State>
   </AI:Response>
  </AI:GetNextFormDesignCssResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

