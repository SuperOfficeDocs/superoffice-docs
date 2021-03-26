---
uid: services87-customerservice-savesmsconfig
title: Services87.CustomerServiceAgent.SaveSmsConfig SOAP
Generated: true
---

# Services87 CustomerService SaveSmsConfig SOAP

SOAP request and response examples **Remote/Services87/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ICustomerServiceAgent.SaveSmsConfig">SuperOffice.Services87.ICustomerServiceAgent.SaveSmsConfig</see> method.

## SaveSmsConfig

Updates the existing SmsConfig or creates a new SmsConfig if the id parameter is 0.

* **smsConfig:** The SmsConfig that is saved.

**Returns:** New or updated SmsConfig


[WSDL file for Services87/CustomerService](../Services87-CustomerService.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveSmsConfig Request

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
   <CustomerService:SaveSmsConfig>
    <CustomerService:SmsConfig xsi:type="CustomerService:SmsConfig">
     <CustomerService:DefaultSmsCountry xsi:type="xsd:string"></CustomerService:DefaultSmsCountry>
     <CustomerService:NetServerSmsProvider xsi:type="xsd:string"></CustomerService:NetServerSmsProvider>
     <CustomerService:NsPluginSender xsi:type="xsd:string"></CustomerService:NsPluginSender>
     <CustomerService:NsPluginConfig xsi:type="CustomerService:StringDictionary">
      <CustomerService:StringKeyValuePair>
       <CustomerService:Key xsi:type="xsd:string"></CustomerService:Key>
       <CustomerService:Value xsi:type="xsd:string"></CustomerService:Value>
      </CustomerService:StringKeyValuePair>
     </CustomerService:NsPluginConfig>
    </CustomerService:SmsConfig>
   </CustomerService:SaveSmsConfig>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveSmsConfig Response

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
  <CustomerService:SaveSmsConfigResponse>
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
  </CustomerService:SaveSmsConfigResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

