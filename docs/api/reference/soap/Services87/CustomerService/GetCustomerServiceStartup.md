---
title: Services87.CustomerServiceAgent.GetCustomerServiceStartup SOAP
generated: 1
uid: Services87-CustomerService-GetCustomerServiceStartup
---

# Services87 CustomerService GetCustomerServiceStartup

SOAP request and response examples **Remote/Services87/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ICustomerServiceAgent.GetCustomerServiceStartup">SuperOffice.Services87.ICustomerServiceAgent.GetCustomerServiceStartup</see> method.

## GetCustomerServiceStartup

Get the carrier with data that Service needs when starting up


**Returns:** The carrier containing the startup data


[WSDL file for Services87/CustomerService](../Services87-CustomerService.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCustomerServiceStartup Request

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
   <CustomerService:GetCustomerServiceStartup>
   </CustomerService:GetCustomerServiceStartup>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCustomerServiceStartup Response

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
  <CustomerService:GetCustomerServiceStartupResponse>
   <CustomerService:Response xsi:type="CustomerService:CustomerServiceStartup">
    <CustomerService:TimezoneEnabled xsi:type="xsd:boolean">false</CustomerService:TimezoneEnabled>
    <CustomerService:TZOffset xsi:type="xsd:int">0</CustomerService:TZOffset>
    <CustomerService:RecaptchaSiteKey xsi:type="xsd:string"></CustomerService:RecaptchaSiteKey>
   </CustomerService:Response>
  </CustomerService:GetCustomerServiceStartupResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

