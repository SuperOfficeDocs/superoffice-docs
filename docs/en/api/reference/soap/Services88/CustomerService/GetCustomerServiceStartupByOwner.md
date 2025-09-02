---
title: Services88.CustomerServiceAgent.GetCustomerServiceStartupByOwner SOAP
generated: true
uid: Services88-CustomerService-GetCustomerServiceStartupByOwner
content_type: reference
---

# Services88 CustomerService GetCustomerServiceStartupByOwner

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.GetCustomerServiceStartupByOwner">SuperOffice.Services88.ICustomerServiceAgent.GetCustomerServiceStartupByOwner</see> method.

## GetCustomerServiceStartupByOwner





[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCustomerServiceStartupByOwner Request

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
   <CustomerService:GetCustomerServiceStartupByOwner>
    <CustomerService:UserId xsi:type="xsd:int">0</CustomerService:UserId>
   </CustomerService:GetCustomerServiceStartupByOwner>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCustomerServiceStartupByOwner Response

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
  <CustomerService:GetCustomerServiceStartupByOwnerResponse>
   <CustomerService:Response xsi:type="CustomerService:CustomerServiceStartup">
    <CustomerService:TimezoneEnabled xsi:type="xsd:boolean">false</CustomerService:TimezoneEnabled>
    <CustomerService:TZOffset xsi:type="xsd:int">0</CustomerService:TZOffset>
    <CustomerService:RecaptchaSiteKey xsi:type="xsd:string"></CustomerService:RecaptchaSiteKey>
    <CustomerService:SelectedPreferences xsi:type="CustomerService:ArrayOfPreference">
     <CustomerService:Preference xsi:type="CustomerService:Preference">
      <CustomerService:Level xsi:type="CustomerService:PreferenceLevel">Undefined</CustomerService:Level>
      <CustomerService:RawValue xsi:type="xsd:string"></CustomerService:RawValue>
      <CustomerService:Specification xsi:type="CustomerService:PreferenceSpec">
       <CustomerService:Section xsi:type="xsd:string"></CustomerService:Section>
       <CustomerService:Key xsi:type="xsd:string"></CustomerService:Key>
      </CustomerService:Specification>
      <CustomerService:DisplayValue xsi:type="xsd:string"></CustomerService:DisplayValue>
      <CustomerService:DisplayTooltip xsi:type="xsd:string"></CustomerService:DisplayTooltip>
      <CustomerService:DisplayType xsi:type="CustomerService:PrefDescValueType">Unknown</CustomerService:DisplayType>
      <CustomerService:TabOrder xsi:type="CustomerService:TabOrder">
       <CustomerService:TabOrderId xsi:type="xsd:int">0</CustomerService:TabOrderId>
       <CustomerService:TabName xsi:type="xsd:string"></CustomerService:TabName>
       <CustomerService:Order xsi:type="xsd:string"></CustomerService:Order>
       <CustomerService:AssociateId xsi:type="xsd:int">0</CustomerService:AssociateId>
      </CustomerService:TabOrder>
      <CustomerService:TargetId xsi:type="xsd:int">0</CustomerService:TargetId>
      <CustomerService:PrefDescId xsi:type="xsd:int">0</CustomerService:PrefDescId>
      <CustomerService:TableName xsi:type="xsd:string"></CustomerService:TableName>
      <CustomerService:UserPreferenceId xsi:type="xsd:int">0</CustomerService:UserPreferenceId>
     </CustomerService:Preference>
    </CustomerService:SelectedPreferences>
   </CustomerService:Response>
  </CustomerService:GetCustomerServiceStartupByOwnerResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

