---
uid: services82-email-createemailfrommimemessage
title: Services82.EMailAgent.CreateEMailFromMimeMessage SOAP
Generated: true
---

# Services82 EMail CreateEMailFromMimeMessage SOAP

SOAP request and response examples **Remote/Services82/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IEMailAgent.CreateEMailFromMimeMessage">SuperOffice.Services82.IEMailAgent.CreateEMailFromMimeMessage</see> method.

## CreateEMailFromMimeMessage

Get an e-mail based on the provided MIME-message

* **mimeMessage:** string representing a MIME-formatted message

**Returns:** The e-mail


[WSDL file for Services82/EMail](../Services82-EMail.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateEMailFromMimeMessage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:CreateEMailFromMimeMessage>
    <EMail:MimeMessage xsi:type="xsd:string"></EMail:MimeMessage>
   </EMail:CreateEMailFromMimeMessage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateEMailFromMimeMessage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <EMail:CreateEMailFromMimeMessageResponse>
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
    </EMail:From>
    <EMail:Sent xsi:type="xsd:dateTime">2021-03-25T21:34:45Z</EMail:Sent>
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
      <EMail:Values xsi:type="NetServerServices822:ArrayOfstring">
       <NetServerServices822:string xsi:type="xsd:string"></NetServerServices822:string>
      </EMail:Values>
     </EMail:EMailCustomHeader>
    </EMail:CustomHeaderList>
    <EMail:FolderName xsi:type="xsd:string"></EMail:FolderName>
   </EMail:Response>
  </EMail:CreateEMailFromMimeMessageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

