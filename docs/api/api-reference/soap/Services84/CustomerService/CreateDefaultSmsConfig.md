---
uid: services84-customerservice-createdefaultsmsconfig
title: Services84.CustomerServiceAgent.CreateDefaultSmsConfig SOAP
Generated: true
---

# Services84 CustomerService CreateDefaultSmsConfig SOAP

SOAP request and response examples **Remote/Services84/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ICustomerServiceAgent.CreateDefaultSmsConfig">SuperOffice.Services84.ICustomerServiceAgent.CreateDefaultSmsConfig</see> method.

## CreateDefaultSmsConfig

Loading default values into a new SmsConfig.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New SmsConfig with default values


[WSDL file for Services84/CustomerService](../Services84-CustomerService.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultSmsConfig Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:CreateDefaultSmsConfig>
   </CustomerService:CreateDefaultSmsConfig>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultSmsConfig Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <CustomerService:CreateDefaultSmsConfigResponse>
   <CustomerService:Response xsi:type="CustomerService:SmsConfig">
    <CustomerService:DefaultSmsCountry xsi:type="xsd:string"></CustomerService:DefaultSmsCountry>
    <CustomerService:NetServerSmsProvider xsi:type="xsd:string"></CustomerService:NetServerSmsProvider>
    <CustomerService:NsPluginSender xsi:type="xsd:string"></CustomerService:NsPluginSender>
    <CustomerService:NsPluginConfig xsi:type="CustomerService:StringDictionary">
     <CustomerService:StringKeyValuePair>
      <CustomerService:Key xsi:type="xsd:string"></CustomerService:Key>
      <CustomerService:Value xsi:type="xsd:string"></CustomerService:Value>
     </CustomerService:StringKeyValuePair>
    </CustomerService:NsPluginConfig>
   </CustomerService:Response>
  </CustomerService:CreateDefaultSmsConfigResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

