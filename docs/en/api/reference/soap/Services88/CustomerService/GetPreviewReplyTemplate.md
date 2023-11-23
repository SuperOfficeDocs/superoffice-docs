---
title: Services88.CustomerServiceAgent.GetPreviewReplyTemplate SOAP
generated: true
uid: Services88-CustomerService-GetPreviewReplyTemplate
---

# Services88 CustomerService GetPreviewReplyTemplate

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.GetPreviewReplyTemplate">SuperOffice.Services88.ICustomerServiceAgent.GetPreviewReplyTemplate</see> method.

## GetPreviewReplyTemplate





[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPreviewReplyTemplate Request

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
   <CustomerService:GetPreviewReplyTemplate>
    <CustomerService:ReplyTemplateId xsi:type="xsd:int">0</CustomerService:ReplyTemplateId>
   </CustomerService:GetPreviewReplyTemplate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPreviewReplyTemplate Response

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
  <CustomerService:GetPreviewReplyTemplateResponse>
   <CustomerService:Response xsi:type="CustomerService:PreviewReplyTemplate">
    <CustomerService:Name xsi:type="xsd:string"></CustomerService:Name>
    <CustomerService:Description xsi:type="xsd:string"></CustomerService:Description>
    <CustomerService:OwnedByFullName xsi:type="xsd:string"></CustomerService:OwnedByFullName>
    <CustomerService:Updated xsi:type="xsd:dateTime">2023-11-10T12:36:20Z</CustomerService:Updated>
    <CustomerService:Body xsi:type="xsd:string"></CustomerService:Body>
    <CustomerService:IsHtml xsi:type="xsd:boolean">false</CustomerService:IsHtml>
   </CustomerService:Response>
  </CustomerService:GetPreviewReplyTemplateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

