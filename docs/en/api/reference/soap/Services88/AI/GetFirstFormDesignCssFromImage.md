---
title: Services88.AIAgent.GetFirstFormDesignCssFromImage SOAP
generated: true
uid: Services88-AI-GetFirstFormDesignCssFromImage
content_type: reference
---

# Services88 AI GetFirstFormDesignCssFromImage

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.GetFirstFormDesignCssFromImage">SuperOffice.Services88.IAIAgent.GetFirstFormDesignCssFromImage</see> method.

## GetFirstFormDesignCssFromImage





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFirstFormDesignCssFromImage Request

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
   <AI:GetFirstFormDesignCssFromImage>
    <AI:Image xsi:type="xsd:base64Binary"></AI:Image>
    <AI:CssClass xsi:type="xsd:string"></AI:CssClass>
   </AI:GetFirstFormDesignCssFromImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFirstFormDesignCssFromImage Response

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
  <AI:GetFirstFormDesignCssFromImageResponse>
   <AI:Response xsi:type="AI:FormDesignCss">
    <AI:CssClass xsi:type="xsd:string"></AI:CssClass>
    <AI:CssRule xsi:type="xsd:string"></AI:CssRule>
    <AI:State xsi:type="xsd:string"></AI:State>
   </AI:Response>
  </AI:GetFirstFormDesignCssFromImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

