---
uid: services86-previews-getpreview
title: Services86.PreviewsAgent.GetPreview SOAP
Generated: true
---

# Services86 Previews GetPreview SOAP

SOAP request and response examples **Remote/Services86/Previews.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IPreviewsAgent.GetPreview">SuperOffice.Services86.IPreviewsAgent.GetPreview</see> method.

## GetPreview

Parse a Preview hint and return a Preview. The returned Preview string may contain resource string identifiers (in square brackets), to be processed by the resource manager.&lt;para /&gt;The Preview hint is either a literal text, representing itself, or a set of key/value pairs enclosed in curly braces. Each key is separated from its value by an equals sign, and each pair from the next by an ampersand, according to usual conventions.&lt;para /&gt;A typical Preview hint could be {contact\_id=123} or {appointment\_id=222&amp;amp;mode=simple}

* **previewHint:** 



[WSDL file for Services86/Previews](../Services86-Previews.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPreview Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Previews="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Previews:ApplicationToken>1234567-1234-9876</Previews:ApplicationToken>
  <Previews:Credentials>
    <Previews:Ticket>7T:1234abcxyzExample==</Previews:Ticket>
  </Previews:Credentials>
 <SOAP-ENV:Body>
   <Previews:GetPreview>
    <Previews:PreviewHint xsi:type="xsd:string"></Previews:PreviewHint>
   </Previews:GetPreview>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPreview Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Previews="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Previews:GetPreviewResponse>
   <Previews:Response xsi:type="xsd:string"></Previews:Response>
  </Previews:GetPreviewResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

