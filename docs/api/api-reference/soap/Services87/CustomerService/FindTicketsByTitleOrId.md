---
title: Services87.CustomerServiceAgent.FindTicketsByTitleOrId SOAP
generated: 1
uid: Services87-CustomerService-FindTicketsByTitleOrId
---

# Services87 CustomerService FindTicketsByTitleOrId

SOAP request and response examples **Remote/Services87/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ICustomerServiceAgent.FindTicketsByTitleOrId">SuperOffice.Services87.ICustomerServiceAgent.FindTicketsByTitleOrId</see> method.

## FindTicketsByTitleOrId

This method wil search for tickets matching title or id

* **titleOrId:** The search string. If this is a number, it will also search for a matching ticket id
* **maxRows:** The maximum number of rows to be returned

**Returns:** An array of objects containing some meta data for matching tickets


[WSDL file for Services87/CustomerService](../Services87-CustomerService.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindTicketsByTitleOrId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:FindTicketsByTitleOrId>
    <CustomerService:TitleOrId xsi:type="xsd:string"></CustomerService:TitleOrId>
    <CustomerService:MaxRows xsi:type="xsd:int">0</CustomerService:MaxRows>
   </CustomerService:FindTicketsByTitleOrId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindTicketsByTitleOrId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <CustomerService:FindTicketsByTitleOrIdResponse>
   <CustomerService:Response xsi:type="CustomerService:ArrayOfTicketInfo">
    <CustomerService:TicketInfo xsi:type="CustomerService:TicketInfo">
     <CustomerService:TicketId xsi:type="xsd:int">0</CustomerService:TicketId>
     <CustomerService:Title xsi:type="xsd:string"></CustomerService:Title>
     <CustomerService:OwnerName xsi:type="xsd:string"></CustomerService:OwnerName>
     <CustomerService:CategoryName xsi:type="xsd:string"></CustomerService:CategoryName>
     <CustomerService:PriorityName xsi:type="xsd:string"></CustomerService:PriorityName>
     <CustomerService:TicketUrl xsi:type="xsd:string"></CustomerService:TicketUrl>
     <CustomerService:PersonName xsi:type="xsd:string"></CustomerService:PersonName>
     <CustomerService:ContactName xsi:type="xsd:string"></CustomerService:ContactName>
    </CustomerService:TicketInfo>
   </CustomerService:Response>
  </CustomerService:FindTicketsByTitleOrIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

