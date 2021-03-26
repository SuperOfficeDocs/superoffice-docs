---
uid: services83-customerservice-eventhandlerexists
title: Services83.CustomerServiceAgent.EventHandlerExists SOAP
Generated: true
---

# Services83 CustomerService EventHandlerExists SOAP

SOAP request and response examples **Remote/Services83/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services83.ICustomerServiceAgent.EventHandlerExists">SuperOffice.Services83.ICustomerServiceAgent.EventHandlerExists</see> method.

## EventHandlerExists

Check if an eventhandler exists for a given enum

* **eventHandlerType:** The EventHandlerType we are checking

**Returns:** True if it exists


[WSDL file for Services83/CustomerService](../Services83-CustomerService.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## EventHandlerExists Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:EventHandlerExists>
    <CustomerService:EventHandlerType xsi:type="CustomerService:EventHandlerType">Unknown</CustomerService:EventHandlerType>
   </CustomerService:EventHandlerExists>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## EventHandlerExists Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <CustomerService:EventHandlerExistsResponse>
   <CustomerService:Response xsi:type="xsd:boolean">false</CustomerService:Response>
  </CustomerService:EventHandlerExistsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

