---
uid: services88-email-getattachmentfromid
title: Services88.EMailAgent.GetAttachmentFromId SOAP
Generated: true
---

# Services88 EMail GetAttachmentFromId SOAP

SOAP request and response examples **Remote/Services88/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IEMailAgent.GetAttachmentFromId">SuperOffice.Services88.IEMailAgent.GetAttachmentFromId</see> method.

## GetAttachmentFromId

Retrieve an attachment from an e-mail
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **mailItemId:** Unique ID for the e-mail to retrieve the attachment from
* **attachmentId:** Id of the attachment in the e-mail

**Returns:** The attachment


[WSDL file for Services88/EMail](../Services88-EMail.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAttachmentFromId Request

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
   <EMail:GetAttachmentFromId>
    <EMail:MailItemId xsi:type="xsd:int">0</EMail:MailItemId>
    <EMail:AttachmentId xsi:type="xsd:string"></EMail:AttachmentId>
   </EMail:GetAttachmentFromId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAttachmentFromId Response

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
  <EMail:GetAttachmentFromIdResponse>
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
  </EMail:GetAttachmentFromIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

