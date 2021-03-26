---
uid: services83-sale-updatesalestakeholders
title: Services83.SaleAgent.UpdateSaleStakeholders SOAP
Generated: true
---

# Services83 Sale UpdateSaleStakeholders SOAP

SOAP request and response examples **Remote/Services83/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services83.ISaleAgent.UpdateSaleStakeholders">SuperOffice.Services83.ISaleAgent.UpdateSaleStakeholders</see> method.

## UpdateSaleStakeholders



* **stakeholders:** 



[WSDL file for Services83/Sale](../Services83-Sale.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateSaleStakeholders Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:UpdateSaleStakeholders>
    <Sale:Stakeholders xsi:type="Sale:ArrayOfSaleStakeholder">
     <Sale:SaleStakeholder xsi:type="Sale:SaleStakeholder">
      <Sale:StakeholderRoleName xsi:type="xsd:string"></Sale:StakeholderRoleName>
      <Sale:Comment xsi:type="xsd:string"></Sale:Comment>
      <Sale:StakeholderRoleId xsi:type="xsd:int">0</Sale:StakeholderRoleId>
      <Sale:CountryId xsi:type="xsd:int">0</Sale:CountryId>
      <Sale:PersonId xsi:type="xsd:int">0</Sale:PersonId>
      <Sale:EmailDescription xsi:type="xsd:string"></Sale:EmailDescription>
      <Sale:EmailId xsi:type="xsd:int">0</Sale:EmailId>
      <Sale:EmailAddress xsi:type="xsd:string"></Sale:EmailAddress>
      <Sale:PhoneId xsi:type="xsd:int">0</Sale:PhoneId>
      <Sale:ContactName xsi:type="xsd:string"></Sale:ContactName>
      <Sale:ContactId xsi:type="xsd:int">0</Sale:ContactId>
      <Sale:SaleId xsi:type="xsd:int">0</Sale:SaleId>
      <Sale:Mrmrs xsi:type="xsd:string"></Sale:Mrmrs>
      <Sale:Firstname xsi:type="xsd:string"></Sale:Firstname>
      <Sale:MiddleName xsi:type="xsd:string"></Sale:MiddleName>
      <Sale:Lastname xsi:type="xsd:string"></Sale:Lastname>
      <Sale:SaleStakeholderId xsi:type="xsd:int">0</Sale:SaleStakeholderId>
      <Sale:Rank xsi:type="xsd:short">0</Sale:Rank>
      <Sale:Phone xsi:type="xsd:string"></Sale:Phone>
     </Sale:SaleStakeholder>
    </Sale:Stakeholders>
   </Sale:UpdateSaleStakeholders>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateSaleStakeholders Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Sale:UpdateSaleStakeholdersResponse>
   <Sale:Response xsi:type="Sale:ArrayOfSaleStakeholder">
    <Sale:SaleStakeholder xsi:type="Sale:SaleStakeholder">
     <Sale:StakeholderRoleName xsi:type="xsd:string"></Sale:StakeholderRoleName>
     <Sale:Comment xsi:type="xsd:string"></Sale:Comment>
     <Sale:StakeholderRoleId xsi:type="xsd:int">0</Sale:StakeholderRoleId>
     <Sale:CountryId xsi:type="xsd:int">0</Sale:CountryId>
     <Sale:PersonId xsi:type="xsd:int">0</Sale:PersonId>
     <Sale:EmailDescription xsi:type="xsd:string"></Sale:EmailDescription>
     <Sale:EmailId xsi:type="xsd:int">0</Sale:EmailId>
     <Sale:EmailAddress xsi:type="xsd:string"></Sale:EmailAddress>
     <Sale:PhoneId xsi:type="xsd:int">0</Sale:PhoneId>
     <Sale:ContactName xsi:type="xsd:string"></Sale:ContactName>
     <Sale:ContactId xsi:type="xsd:int">0</Sale:ContactId>
     <Sale:SaleId xsi:type="xsd:int">0</Sale:SaleId>
     <Sale:Mrmrs xsi:type="xsd:string"></Sale:Mrmrs>
     <Sale:Firstname xsi:type="xsd:string"></Sale:Firstname>
     <Sale:MiddleName xsi:type="xsd:string"></Sale:MiddleName>
     <Sale:Lastname xsi:type="xsd:string"></Sale:Lastname>
     <Sale:SaleStakeholderId xsi:type="xsd:int">0</Sale:SaleStakeholderId>
     <Sale:Rank xsi:type="xsd:short">0</Sale:Rank>
     <Sale:Phone xsi:type="xsd:string"></Sale:Phone>
    </Sale:SaleStakeholder>
   </Sale:Response>
  </Sale:UpdateSaleStakeholdersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

