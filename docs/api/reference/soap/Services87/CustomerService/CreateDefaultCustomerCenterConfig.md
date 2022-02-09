---
title: Services87.CustomerServiceAgent.CreateDefaultCustomerCenterConfig SOAP
generated: 1
uid: Services87-CustomerService-CreateDefaultCustomerCenterConfig
---

# Services87 CustomerService CreateDefaultCustomerCenterConfig

SOAP request and response examples **Remote/Services87/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ICustomerServiceAgent.CreateDefaultCustomerCenterConfig">SuperOffice.Services87.ICustomerServiceAgent.CreateDefaultCustomerCenterConfig</see> method.

## CreateDefaultCustomerCenterConfig

Loading default values into a new CustomerCenterConfig.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New CustomerCenterConfig with default values


[WSDL file for Services87/CustomerService](../Services87-CustomerService.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultCustomerCenterConfig Request

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
   <CustomerService:CreateDefaultCustomerCenterConfig>
   </CustomerService:CreateDefaultCustomerCenterConfig>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultCustomerCenterConfig Response

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
  <CustomerService:CreateDefaultCustomerCenterConfigResponse>
   <CustomerService:Response xsi:type="CustomerService:CustomerCenterConfig">
    <CustomerService:CustConfigId xsi:type="xsd:int">0</CustomerService:CustConfigId>
    <CustomerService:Type xsi:type="CustomerService:ConfigType">Style</CustomerService:Type>
    <CustomerService:Config xsi:type="xsd:string"></CustomerService:Config>
    <CustomerService:CustLangId xsi:type="xsd:int">0</CustomerService:CustLangId>
    <CustomerService:Registered xsi:type="xsd:dateTime">2021-11-30T13:23:12Z</CustomerService:Registered>
    <CustomerService:RegisteredAssociateId xsi:type="xsd:int">0</CustomerService:RegisteredAssociateId>
    <CustomerService:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:12Z</CustomerService:Updated>
    <CustomerService:UpdatedAssociateId xsi:type="xsd:int">0</CustomerService:UpdatedAssociateId>
   </CustomerService:Response>
  </CustomerService:CreateDefaultCustomerCenterConfigResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

