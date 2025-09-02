---
title: Services88.EMailAgent.GetUnsanitizedPreviewAttachmentFromId SOAP
generated: true
uid: Services88-EMail-GetUnsanitizedPreviewAttachmentFromId
content_type: reference
---

# Services88 EMail GetUnsanitizedPreviewAttachmentFromId

SOAP request and response examples **Remote/Services88/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IEMailAgent.GetUnsanitizedPreviewAttachmentFromId">SuperOffice.Services88.IEMailAgent.GetUnsanitizedPreviewAttachmentFromId</see> method.

## GetUnsanitizedPreviewAttachmentFromId





[WSDL file for Services88/EMail](../Services88-EMail.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUnsanitizedPreviewAttachmentFromId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetUnsanitizedPreviewAttachmentFromId>
    <EMail:MailItemId xsi:type="xsd:int">0</EMail:MailItemId>
    <EMail:AttachmentId xsi:type="xsd:string"></EMail:AttachmentId>
    <EMail:AttachmentType xsi:type="xsd:string"></EMail:AttachmentType>
    <EMail:AttachmentFilename xsi:type="xsd:string"></EMail:AttachmentFilename>
   </EMail:GetUnsanitizedPreviewAttachmentFromId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUnsanitizedPreviewAttachmentFromId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <EMail:GetUnsanitizedPreviewAttachmentFromIdResponse>
   <EMail:Response xsi:type="EMail:EMailAttachment">
    <EMail:Description xsi:type="xsd:string"></EMail:Description>
    <EMail:Filename xsi:type="xsd:string"></EMail:Filename>
    <EMail:Size xsi:type="xsd:int">0</EMail:Size>
    <EMail:Type xsi:type="xsd:string"></EMail:Type>
    <EMail:Encoding xsi:type="xsd:string"></EMail:Encoding>
    <EMail:Id xsi:type="xsd:string"></EMail:Id>
    <EMail:Disposition xsi:type="xsd:string"></EMail:Disposition>
    <EMail:IsSafeFileExtension xsi:type="xsd:boolean">false</EMail:IsSafeFileExtension>
    <EMail:Stream xsi:type="xsd:base64Binary"></EMail:Stream>
   </EMail:Response>
  </EMail:GetUnsanitizedPreviewAttachmentFromIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

