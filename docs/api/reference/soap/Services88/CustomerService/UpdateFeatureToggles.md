---
title: Services88.CustomerServiceAgent.UpdateFeatureToggles SOAP
generated: 1
uid: Services88-CustomerService-UpdateFeatureToggles
---

# Services88 CustomerService UpdateFeatureToggles

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.UpdateFeatureToggles">SuperOffice.Services88.ICustomerServiceAgent.UpdateFeatureToggles</see> method.

## UpdateFeatureToggles

Update the cached FeatureToggles for CS

* **featureToggles:** Feature toggle name / state



[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateFeatureToggles Request

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
   <CustomerService:UpdateFeatureToggles>
    <CustomerService:FeatureToggles xsi:type="CustomerService:ArrayOfCsFeatureToggle">
     <CustomerService:CsFeatureToggle xsi:type="CustomerService:CsFeatureToggle">
      <CustomerService:Name xsi:type="xsd:string"></CustomerService:Name>
      <CustomerService:State xsi:type="xsd:boolean">false</CustomerService:State>
     </CustomerService:CsFeatureToggle>
    </CustomerService:FeatureToggles>
   </CustomerService:UpdateFeatureToggles>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateFeatureToggles Response

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
  <CustomerService:UpdateFeatureTogglesResponse>
  </CustomerService:UpdateFeatureTogglesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

