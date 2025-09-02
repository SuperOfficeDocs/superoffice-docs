---
title: Services88.PersonAgent.GetCustomerCentrePasswordReplyTemplate SOAP
generated: true
uid: Services88-Person-GetCustomerCentrePasswordReplyTemplate
content_type: reference
---

# Services88 Person GetCustomerCentrePasswordReplyTemplate

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.GetCustomerCentrePasswordReplyTemplate">SuperOffice.Services88.IPersonAgent.GetCustomerCentrePasswordReplyTemplate</see> method.

## GetCustomerCentrePasswordReplyTemplate





[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCustomerCentrePasswordReplyTemplate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:GetCustomerCentrePasswordReplyTemplate>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
   </Person:GetCustomerCentrePasswordReplyTemplate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCustomerCentrePasswordReplyTemplate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Person:GetCustomerCentrePasswordReplyTemplateResponse>
   <Person:Response xsi:type="Person:ReplyTemplateParsed">
    <Person:ReplyTemplateId xsi:type="xsd:int">0</Person:ReplyTemplateId>
    <Person:PlainParsed xsi:type="xsd:string"></Person:PlainParsed>
    <Person:HtmlParsed xsi:type="xsd:string"></Person:HtmlParsed>
    <Person:Attachments xsi:type="Person:ArrayOfAttachmentEntity">
     <Person:AttachmentEntity xsi:type="Person:AttachmentEntity">
      <Person:AttachmentId xsi:type="xsd:int">0</Person:AttachmentId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:ContentType xsi:type="xsd:string"></Person:ContentType>
      <Person:AttSize xsi:type="xsd:int">0</Person:AttSize>
      <Person:InlineImage xsi:type="xsd:boolean">false</Person:InlineImage>
      <Person:ContentId xsi:type="xsd:string"></Person:ContentId>
      <Person:AuthKey xsi:type="xsd:string"></Person:AuthKey>
      <Person:IsSafeFileExtension xsi:type="xsd:boolean">false</Person:IsSafeFileExtension>
     </Person:AttachmentEntity>
    </Person:Attachments>
    <Person:Subject xsi:type="xsd:string"></Person:Subject>
   </Person:Response>
  </Person:GetCustomerCentrePasswordReplyTemplateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

