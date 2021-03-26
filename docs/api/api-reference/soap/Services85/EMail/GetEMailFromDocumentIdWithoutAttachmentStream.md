---
uid: services85-email-getemailfromdocumentidwithoutattachmentstream
title: Services85.EMailAgent.GetEMailFromDocumentIdWithoutAttachmentStream SOAP
Generated: true
---

# Services85 EMail GetEMailFromDocumentIdWithoutAttachmentStream SOAP

SOAP request and response examples **Remote/Services85/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IEMailAgent.GetEMailFromDocumentIdWithoutAttachmentStream">SuperOffice.Services85.IEMailAgent.GetEMailFromDocumentIdWithoutAttachmentStream</see> method.

## GetEMailFromDocumentIdWithoutAttachmentStream

Get an e-mail based on an archived document

* **documentId:** Unique id of the document

**Returns:** The e-mail


[WSDL file for Services85/EMail](../Services85-EMail.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetEMailFromDocumentIdWithoutAttachmentStream Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetEMailFromDocumentIdWithoutAttachmentStream>
    <EMail:DocumentId xsi:type="xsd:int">0</EMail:DocumentId>
   </EMail:GetEMailFromDocumentIdWithoutAttachmentStream>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetEMailFromDocumentIdWithoutAttachmentStream Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <EMail:GetEMailFromDocumentIdWithoutAttachmentStreamResponse>
   <EMail:Response xsi:type="EMail:EMailEntity">
    <EMail:To xsi:type="EMail:ArrayOfEMailAddress">
     <EMail:EMailAddress xsi:type="EMail:EMailAddress">
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Address xsi:type="xsd:string"></EMail:Address>
      <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
      <EMail:DuplicatePersonIds xsi:type="NetServerServices852:ArrayOfint">
       <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
      </EMail:DuplicatePersonIds>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
     </EMail:EMailAddress>
    </EMail:To>
    <EMail:Cc xsi:type="EMail:ArrayOfEMailAddress">
     <EMail:EMailAddress xsi:type="EMail:EMailAddress">
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Address xsi:type="xsd:string"></EMail:Address>
      <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
      <EMail:DuplicatePersonIds xsi:type="NetServerServices852:ArrayOfint">
       <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
      </EMail:DuplicatePersonIds>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
     </EMail:EMailAddress>
    </EMail:Cc>
    <EMail:Bcc xsi:type="EMail:ArrayOfEMailAddress">
     <EMail:EMailAddress xsi:type="EMail:EMailAddress">
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Address xsi:type="xsd:string"></EMail:Address>
      <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
      <EMail:DuplicatePersonIds xsi:type="NetServerServices852:ArrayOfint">
       <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
      </EMail:DuplicatePersonIds>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
     </EMail:EMailAddress>
    </EMail:Bcc>
    <EMail:Subject xsi:type="xsd:string"></EMail:Subject>
    <EMail:HTMLBody xsi:type="xsd:string"></EMail:HTMLBody>
    <EMail:From xsi:type="EMail:EMailAddress">
     <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
     <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
     <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
     <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
     <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
     <EMail:Address xsi:type="xsd:string"></EMail:Address>
     <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
     <EMail:DuplicatePersonIds xsi:type="NetServerServices852:ArrayOfint">
      <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
     </EMail:DuplicatePersonIds>
     <EMail:Name xsi:type="xsd:string"></EMail:Name>
    </EMail:From>
    <EMail:Sent xsi:type="xsd:dateTime">2021-03-25T21:35:46Z</EMail:Sent>
    <EMail:Size xsi:type="xsd:int">0</EMail:Size>
    <EMail:Priority xsi:type="EMail:EMailPriority">NoPriority</EMail:Priority>
    <EMail:Flags xsi:type="EMail:EMailFlags">Seen</EMail:Flags>
    <EMail:MessageID xsi:type="xsd:string"></EMail:MessageID>
    <EMail:PlainBody xsi:type="xsd:string"></EMail:PlainBody>
    <EMail:IsSent xsi:type="xsd:boolean">false</EMail:IsSent>
    <EMail:EMailSOInfo xsi:type="EMail:EMailSOInfo">
     <EMail:DocumentId xsi:type="xsd:int">0</EMail:DocumentId>
     <EMail:AppointmentId xsi:type="xsd:int">0</EMail:AppointmentId>
     <EMail:ProjectId xsi:type="xsd:int">0</EMail:ProjectId>
     <EMail:SaleId xsi:type="xsd:int">0</EMail:SaleId>
     <EMail:Archived xsi:type="xsd:boolean">false</EMail:Archived>
     <EMail:ArchivedAt xsi:type="xsd:dateTime">2021-03-25T21:35:46Z</EMail:ArchivedAt>
     <EMail:ArchivedBy xsi:type="xsd:int">0</EMail:ArchivedBy>
     <EMail:ArchivedDisplayName xsi:type="xsd:string"></EMail:ArchivedDisplayName>
    </EMail:EMailSOInfo>
    <EMail:ServerId xsi:type="xsd:int">0</EMail:ServerId>
    <EMail:Attachments xsi:type="EMail:ArrayOfEMailAttachment">
     <EMail:EMailAttachment xsi:type="EMail:EMailAttachment">
      <EMail:Description xsi:type="xsd:string"></EMail:Description>
      <EMail:Filename xsi:type="xsd:string"></EMail:Filename>
      <EMail:Size xsi:type="xsd:int">0</EMail:Size>
      <EMail:Type xsi:type="xsd:string"></EMail:Type>
      <EMail:Encoding xsi:type="xsd:string"></EMail:Encoding>
      <EMail:Id xsi:type="xsd:string"></EMail:Id>
      <EMail:Disposition xsi:type="xsd:string"></EMail:Disposition>
      <EMail:Stream xsi:type="xsd:base64Binary"></EMail:Stream>
     </EMail:EMailAttachment>
    </EMail:Attachments>
    <EMail:CustomHeaderList xsi:type="EMail:ArrayOfEMailCustomHeader">
     <EMail:EMailCustomHeader xsi:type="EMail:EMailCustomHeader">
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
      <EMail:Values xsi:type="NetServerServices852:ArrayOfstring">
       <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
      </EMail:Values>
     </EMail:EMailCustomHeader>
    </EMail:CustomHeaderList>
    <EMail:FolderName xsi:type="xsd:string"></EMail:FolderName>
    <EMail:EmailItemId xsi:type="xsd:int">0</EMail:EmailItemId>
    <EMail:AccountId xsi:type="xsd:int">0</EMail:AccountId>
    <EMail:ReceivedAt xsi:type="xsd:dateTime">2021-03-25T21:35:46Z</EMail:ReceivedAt>
    <EMail:InReplyTo xsi:type="EMail:EMailEnvelope">
     <EMail:ServerId xsi:type="xsd:int">0</EMail:ServerId>
     <EMail:MessageId xsi:type="xsd:string"></EMail:MessageId>
     <EMail:Subject xsi:type="xsd:string"></EMail:Subject>
     <EMail:From xsi:type="EMail:EMailAddress">
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Address xsi:type="xsd:string"></EMail:Address>
      <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
      <EMail:DuplicatePersonIds xsi:type="NetServerServices852:ArrayOfint">
       <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
      </EMail:DuplicatePersonIds>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
     </EMail:From>
     <EMail:To xsi:type="EMail:ArrayOfEMailAddress">
      <EMail:EMailAddress xsi:type="EMail:EMailAddress">
       <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
       <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
       <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
       <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
       <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
       <EMail:Address xsi:type="xsd:string"></EMail:Address>
       <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
       <EMail:DuplicatePersonIds xsi:type="NetServerServices852:ArrayOfint">
        <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
       </EMail:DuplicatePersonIds>
       <EMail:Name xsi:type="xsd:string"></EMail:Name>
      </EMail:EMailAddress>
     </EMail:To>
     <EMail:Sent xsi:type="xsd:dateTime">2021-03-25T21:35:46Z</EMail:Sent>
     <EMail:Priority xsi:type="EMail:EMailPriority">NoPriority</EMail:Priority>
     <EMail:Flags xsi:type="EMail:EMailFlags">Seen</EMail:Flags>
     <EMail:Size xsi:type="xsd:int">0</EMail:Size>
     <EMail:EMailSOInfo xsi:type="EMail:EMailSOInfo">
      <EMail:DocumentId xsi:type="xsd:int">0</EMail:DocumentId>
      <EMail:AppointmentId xsi:type="xsd:int">0</EMail:AppointmentId>
      <EMail:ProjectId xsi:type="xsd:int">0</EMail:ProjectId>
      <EMail:SaleId xsi:type="xsd:int">0</EMail:SaleId>
      <EMail:Archived xsi:type="xsd:boolean">false</EMail:Archived>
      <EMail:ArchivedAt xsi:type="xsd:dateTime">2021-03-25T21:35:46Z</EMail:ArchivedAt>
      <EMail:ArchivedBy xsi:type="xsd:int">0</EMail:ArchivedBy>
      <EMail:ArchivedDisplayName xsi:type="xsd:string"></EMail:ArchivedDisplayName>
     </EMail:EMailSOInfo>
    </EMail:InReplyTo>
    <EMail:RepliedAt xsi:type="xsd:dateTime">2021-03-25T21:35:46Z</EMail:RepliedAt>
   </EMail:Response>
  </EMail:GetEMailFromDocumentIdWithoutAttachmentStreamResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

