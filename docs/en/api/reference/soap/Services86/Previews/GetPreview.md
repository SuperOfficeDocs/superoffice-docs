---
title: Services86.PreviewsAgent.GetPreview SOAP
generated: 1
uid: Services86-Previews-GetPreview
---

# Services86 Previews GetPreview

SOAP request and response examples **Remote/Services86/Previews.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IPreviewsAgent.GetPreview">SuperOffice.Services86.IPreviewsAgent.GetPreview</see> method.

## GetPreview

[WSDL file for Services86/Previews](../Services86-Previews.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

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
