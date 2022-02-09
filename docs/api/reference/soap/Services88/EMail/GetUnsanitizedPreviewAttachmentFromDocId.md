---
title: Services88.EMailAgent.GetUnsanitizedPreviewAttachmentFromDocId SOAP
generated: 1
uid: Services88-EMail-GetUnsanitizedPreviewAttachmentFromDocId
---

# Services88 EMail GetUnsanitizedPreviewAttachmentFromDocId

SOAP request and response examples **Remote/Services88/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IEMailAgent.GetUnsanitizedPreviewAttachmentFromDocId">SuperOffice.Services88.IEMailAgent.GetUnsanitizedPreviewAttachmentFromDocId</see> method.

## GetUnsanitizedPreviewAttachmentFromDocId

Retrieve an attachment from an e-mail stored in the document archive. The returned data is intended to be use for a preview. The returned data is not sanitized.
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **docId:** Unique ID for the e-mail in the document archive to retrieve the attachment from
* **attachmentId:** Id of the attachment in the e-mail

**Returns:** The attachment


[WSDL file for Services88/EMail](../Services88-EMail.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUnsanitizedPreviewAttachmentFromDocId Request

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
   <EMail:GetUnsanitizedPreviewAttachmentFromDocId>
    <EMail:DocId xsi:type="xsd:int">0</EMail:DocId>
    <EMail:AttachmentId xsi:type="xsd:string"></EMail:AttachmentId>
   </EMail:GetUnsanitizedPreviewAttachmentFromDocId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUnsanitizedPreviewAttachmentFromDocId Response

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
  <EMail:GetUnsanitizedPreviewAttachmentFromDocIdResponse>
   <EMail:Response xsi:type="EMail:EMailAttachment">
    <EMail:Description xsi:type="xsd:string"></EMail:Description>
    <EMail:Filename xsi:type="xsd:string"></EMail:Filename>
    <EMail:Size xsi:type="xsd:int">0</EMail:Size>
    <EMail:Type xsi:type="xsd:string"></EMail:Type>
    <EMail:Encoding xsi:type="xsd:string"></EMail:Encoding>
    <EMail:Id xsi:type="xsd:string"></EMail:Id>
    <EMail:Disposition xsi:type="xsd:string"></EMail:Disposition>
    <EMail:Stream xsi:type="xsd:base64Binary"></EMail:Stream>
   </EMail:Response>
  </EMail:GetUnsanitizedPreviewAttachmentFromDocIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

