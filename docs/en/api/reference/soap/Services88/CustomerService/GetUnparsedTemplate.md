---
title: Services88.CustomerServiceAgent.GetUnparsedTemplate SOAP
generated: true
uid: Services88-CustomerService-GetUnparsedTemplate
content_type: reference
---

# Services88 CustomerService GetUnparsedTemplate

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.GetUnparsedTemplate">SuperOffice.Services88.ICustomerServiceAgent.GetUnparsedTemplate</see> method.

## GetUnparsedTemplate





[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUnparsedTemplate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:GetUnparsedTemplate>
    <CustomerService:ReplyTemplateId xsi:type="xsd:int">0</CustomerService:ReplyTemplateId>
    <CustomerService:LanguageId xsi:type="xsd:int">0</CustomerService:LanguageId>
   </CustomerService:GetUnparsedTemplate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUnparsedTemplate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <CustomerService:GetUnparsedTemplateResponse>
   <CustomerService:Response xsi:type="CustomerService:ReplyTemplateParsed">
    <CustomerService:ReplyTemplateId xsi:type="xsd:int">0</CustomerService:ReplyTemplateId>
    <CustomerService:PlainParsed xsi:type="xsd:string"></CustomerService:PlainParsed>
    <CustomerService:HtmlParsed xsi:type="xsd:string"></CustomerService:HtmlParsed>
    <CustomerService:Attachments xsi:type="CustomerService:ArrayOfAttachmentEntity">
     <CustomerService:AttachmentEntity xsi:type="CustomerService:AttachmentEntity">
      <CustomerService:AttachmentId xsi:type="xsd:int">0</CustomerService:AttachmentId>
      <CustomerService:Name xsi:type="xsd:string"></CustomerService:Name>
      <CustomerService:ContentType xsi:type="xsd:string"></CustomerService:ContentType>
      <CustomerService:AttSize xsi:type="xsd:int">0</CustomerService:AttSize>
      <CustomerService:InlineImage xsi:type="xsd:boolean">false</CustomerService:InlineImage>
      <CustomerService:ContentId xsi:type="xsd:string"></CustomerService:ContentId>
      <CustomerService:AuthKey xsi:type="xsd:string"></CustomerService:AuthKey>
      <CustomerService:IsSafeFileExtension xsi:type="xsd:boolean">false</CustomerService:IsSafeFileExtension>
     </CustomerService:AttachmentEntity>
    </CustomerService:Attachments>
    <CustomerService:Subject xsi:type="xsd:string"></CustomerService:Subject>
   </CustomerService:Response>
  </CustomerService:GetUnparsedTemplateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

