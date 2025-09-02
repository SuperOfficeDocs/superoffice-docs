---
title: Services88.CustomerServiceAgent.SaveSystemTemplateSettings SOAP
generated: true
uid: Services88-CustomerService-SaveSystemTemplateSettings
content_type: reference
---

# Services88 CustomerService SaveSystemTemplateSettings

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.SaveSystemTemplateSettings">SuperOffice.Services88.ICustomerServiceAgent.SaveSystemTemplateSettings</see> method.

## SaveSystemTemplateSettings





[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveSystemTemplateSettings Request

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
   <CustomerService:SaveSystemTemplateSettings>
    <CustomerService:SystemTemplateSettings xsi:type="CustomerService:SystemTemplateSettings">
     <CustomerService:CustomerNewCustomerTemplateId xsi:type="xsd:int">0</CustomerService:CustomerNewCustomerTemplateId>
     <CustomerService:CustomerCustomerReplyTemplateId xsi:type="xsd:int">0</CustomerService:CustomerCustomerReplyTemplateId>
     <CustomerService:CustomerPasswordTemplateId xsi:type="xsd:int">0</CustomerService:CustomerPasswordTemplateId>
     <CustomerService:CustomerConfirmEmailTemplateId xsi:type="xsd:int">0</CustomerService:CustomerConfirmEmailTemplateId>
     <CustomerService:CustomerChatLogTemplateId xsi:type="xsd:int">0</CustomerService:CustomerChatLogTemplateId>
     <CustomerService:NewLinkTemplateId xsi:type="xsd:int">0</CustomerService:NewLinkTemplateId>
     <CustomerService:HotlistNewMessageTemplateId xsi:type="xsd:int">0</CustomerService:HotlistNewMessageTemplateId>
     <CustomerService:HotlistTicketActivatedTemplateId xsi:type="xsd:int">0</CustomerService:HotlistTicketActivatedTemplateId>
     <CustomerService:UserTicketAlarmTemplateId xsi:type="xsd:int">0</CustomerService:UserTicketAlarmTemplateId>
     <CustomerService:HotlistTicketTakenOverTemplateId xsi:type="xsd:int">0</CustomerService:HotlistTicketTakenOverTemplateId>
     <CustomerService:UserActiveTicketsTemplateId xsi:type="xsd:int">0</CustomerService:UserActiveTicketsTemplateId>
     <CustomerService:UserNewMessageTemplateId xsi:type="xsd:int">0</CustomerService:UserNewMessageTemplateId>
     <CustomerService:UserTicketActivatedTemplateId xsi:type="xsd:int">0</CustomerService:UserTicketActivatedTemplateId>
     <CustomerService:UserNewTicketTemplateId xsi:type="xsd:int">0</CustomerService:UserNewTicketTemplateId>
     <CustomerService:PublishKbQuestionTemplateId xsi:type="xsd:int">0</CustomerService:PublishKbQuestionTemplateId>
     <CustomerService:PublishKbAnswerTemplateId xsi:type="xsd:int">0</CustomerService:PublishKbAnswerTemplateId>
     <CustomerService:UserTicketTakenOverTemplateId xsi:type="xsd:int">0</CustomerService:UserTicketTakenOverTemplateId>
     <CustomerService:PrintTicketTemplateId xsi:type="xsd:int">0</CustomerService:PrintTicketTemplateId>
     <CustomerService:WeekStatTemplateId xsi:type="xsd:int">0</CustomerService:WeekStatTemplateId>
     <CustomerService:TicketAlarmHotlistTemplateId xsi:type="xsd:int">0</CustomerService:TicketAlarmHotlistTemplateId>
     <CustomerService:EmailAddresses xsi:type="xsd:string"></CustomerService:EmailAddresses>
    </CustomerService:SystemTemplateSettings>
   </CustomerService:SaveSystemTemplateSettings>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveSystemTemplateSettings Response

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
  <CustomerService:SaveSystemTemplateSettingsResponse>
   <CustomerService:Response xsi:type="CustomerService:SystemTemplateSettings">
    <CustomerService:CustomerNewCustomerTemplateId xsi:type="xsd:int">0</CustomerService:CustomerNewCustomerTemplateId>
    <CustomerService:CustomerCustomerReplyTemplateId xsi:type="xsd:int">0</CustomerService:CustomerCustomerReplyTemplateId>
    <CustomerService:CustomerPasswordTemplateId xsi:type="xsd:int">0</CustomerService:CustomerPasswordTemplateId>
    <CustomerService:CustomerConfirmEmailTemplateId xsi:type="xsd:int">0</CustomerService:CustomerConfirmEmailTemplateId>
    <CustomerService:CustomerChatLogTemplateId xsi:type="xsd:int">0</CustomerService:CustomerChatLogTemplateId>
    <CustomerService:NewLinkTemplateId xsi:type="xsd:int">0</CustomerService:NewLinkTemplateId>
    <CustomerService:HotlistNewMessageTemplateId xsi:type="xsd:int">0</CustomerService:HotlistNewMessageTemplateId>
    <CustomerService:HotlistTicketActivatedTemplateId xsi:type="xsd:int">0</CustomerService:HotlistTicketActivatedTemplateId>
    <CustomerService:UserTicketAlarmTemplateId xsi:type="xsd:int">0</CustomerService:UserTicketAlarmTemplateId>
    <CustomerService:HotlistTicketTakenOverTemplateId xsi:type="xsd:int">0</CustomerService:HotlistTicketTakenOverTemplateId>
    <CustomerService:UserActiveTicketsTemplateId xsi:type="xsd:int">0</CustomerService:UserActiveTicketsTemplateId>
    <CustomerService:UserNewMessageTemplateId xsi:type="xsd:int">0</CustomerService:UserNewMessageTemplateId>
    <CustomerService:UserTicketActivatedTemplateId xsi:type="xsd:int">0</CustomerService:UserTicketActivatedTemplateId>
    <CustomerService:UserNewTicketTemplateId xsi:type="xsd:int">0</CustomerService:UserNewTicketTemplateId>
    <CustomerService:PublishKbQuestionTemplateId xsi:type="xsd:int">0</CustomerService:PublishKbQuestionTemplateId>
    <CustomerService:PublishKbAnswerTemplateId xsi:type="xsd:int">0</CustomerService:PublishKbAnswerTemplateId>
    <CustomerService:UserTicketTakenOverTemplateId xsi:type="xsd:int">0</CustomerService:UserTicketTakenOverTemplateId>
    <CustomerService:PrintTicketTemplateId xsi:type="xsd:int">0</CustomerService:PrintTicketTemplateId>
    <CustomerService:WeekStatTemplateId xsi:type="xsd:int">0</CustomerService:WeekStatTemplateId>
    <CustomerService:TicketAlarmHotlistTemplateId xsi:type="xsd:int">0</CustomerService:TicketAlarmHotlistTemplateId>
    <CustomerService:EmailAddresses xsi:type="xsd:string"></CustomerService:EmailAddresses>
   </CustomerService:Response>
  </CustomerService:SaveSystemTemplateSettingsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

