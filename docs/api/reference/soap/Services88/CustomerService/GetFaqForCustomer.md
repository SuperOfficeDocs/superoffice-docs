---
title: Services88.CustomerServiceAgent.GetFaqForCustomer SOAP
generated: 1
uid: Services88-CustomerService-GetFaqForCustomer
---

# Services88 CustomerService GetFaqForCustomer

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.GetFaqForCustomer">SuperOffice.Services88.ICustomerServiceAgent.GetFaqForCustomer</see> method.

## GetFaqForCustomer

Get a FAQ entry, ment to be displayed for a customer. This can either be a link to the FAQ entry on Custom Center, or it can be the answer and question. This is dependent on Registry setting with reg\_id=157

* **faqEntryId:** The id of the FAQ entry to get. Only FAQ entries with access level public (both for unauthenticated and autenticated customer) will be returned

**Returns:** The FAQ to show to the customer. Either a clickable link or the question/answer itself.


[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFaqForCustomer Request

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
   <CustomerService:GetFaqForCustomer>
    <CustomerService:FaqEntryId xsi:type="xsd:int">0</CustomerService:FaqEntryId>
   </CustomerService:GetFaqForCustomer>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFaqForCustomer Response

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
  <CustomerService:GetFaqForCustomerResponse>
   <CustomerService:Response xsi:type="xsd:string"></CustomerService:Response>
  </CustomerService:GetFaqForCustomerResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

