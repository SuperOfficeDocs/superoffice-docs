---
uid: services88-customerservice-saveallcustomercenterconfigs
title: Services88.CustomerServiceAgent.SaveAllCustomerCenterConfigs SOAP
Generated: true
---

# Services88 CustomerService SaveAllCustomerCenterConfigs SOAP

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.SaveAllCustomerCenterConfigs">SuperOffice.Services88.ICustomerServiceAgent.SaveAllCustomerCenterConfigs</see> method.

## SaveAllCustomerCenterConfigs

Save an array of CustomerCenterConfig entities to the database

* **custConfigs:** The CustomerCenterConfig entities to be saved. If the id does not exists, a new one will be created. Unknown ids will be skipped

**Returns:** void


[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveAllCustomerCenterConfigs Request

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
   <CustomerService:SaveAllCustomerCenterConfigs>
    <CustomerService:CustConfigs xsi:type="CustomerService:ArrayOfCustomerCenterConfig">
     <CustomerService:CustomerCenterConfig xsi:type="CustomerService:CustomerCenterConfig">
      <CustomerService:CustConfigId xsi:type="xsd:int">0</CustomerService:CustConfigId>
      <CustomerService:Type xsi:type="CustomerService:ConfigType">Style</CustomerService:Type>
      <CustomerService:Config xsi:type="xsd:string"></CustomerService:Config>
      <CustomerService:CustLangId xsi:type="xsd:int">0</CustomerService:CustLangId>
      <CustomerService:Registered xsi:type="xsd:dateTime">2021-03-25T21:36:54Z</CustomerService:Registered>
      <CustomerService:RegisteredAssociateId xsi:type="xsd:int">0</CustomerService:RegisteredAssociateId>
      <CustomerService:Updated xsi:type="xsd:dateTime">2021-03-25T21:36:54Z</CustomerService:Updated>
      <CustomerService:UpdatedAssociateId xsi:type="xsd:int">0</CustomerService:UpdatedAssociateId>
     </CustomerService:CustomerCenterConfig>
    </CustomerService:CustConfigs>
   </CustomerService:SaveAllCustomerCenterConfigs>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveAllCustomerCenterConfigs Response

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
  <CustomerService:SaveAllCustomerCenterConfigsResponse>
  </CustomerService:SaveAllCustomerCenterConfigsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

