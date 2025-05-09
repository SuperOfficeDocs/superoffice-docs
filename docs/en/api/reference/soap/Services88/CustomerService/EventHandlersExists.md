---
title: Services88.CustomerServiceAgent.EventHandlersExists SOAP
generated: true
uid: Services88-CustomerService-EventHandlersExists
---

# Services88 CustomerService EventHandlersExists

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.EventHandlersExists">SuperOffice.Services88.ICustomerServiceAgent.EventHandlersExists</see> method.

## EventHandlersExists





[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## EventHandlersExists Request

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
   <CustomerService:EventHandlersExists>
    <CustomerService:EventHandlerTypes xsi:type="CustomerService:ArrayOfEventHandlerType">
     <CustomerService:EventHandlerType xsi:type="CustomerService:EventHandlerType">Unknown</CustomerService:EventHandlerType>
    </CustomerService:EventHandlerTypes>
   </CustomerService:EventHandlersExists>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## EventHandlersExists Response

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
  <CustomerService:EventHandlersExistsResponse>
   <CustomerService:Response xsi:type="CustomerService:ArrayOfEventHandlerType">
    <CustomerService:EventHandlerType xsi:type="CustomerService:EventHandlerType">Unknown</CustomerService:EventHandlerType>
   </CustomerService:Response>
  </CustomerService:EventHandlersExistsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

