---
title: Services88.CustomerServiceAgent.GetSmsConfig SOAP
generated: 1
uid: Services88-CustomerService-GetSmsConfig
---

# Services88 CustomerService GetSmsConfig

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.GetSmsConfig">SuperOffice.Services88.ICustomerServiceAgent.GetSmsConfig</see> method.

## GetSmsConfig

Get the SmsConfig settings for Customer Service sms providers.


**Returns:** Current SMS configuration.


[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSmsConfig Request

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
   <CustomerService:GetSmsConfig>
   </CustomerService:GetSmsConfig>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSmsConfig Response

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
  <CustomerService:GetSmsConfigResponse>
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
  </CustomerService:GetSmsConfigResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

