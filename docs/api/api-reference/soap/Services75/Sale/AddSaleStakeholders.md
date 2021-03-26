---
uid: services75-sale-addsalestakeholders
title: Services75.SaleAgent.AddSaleStakeholders SOAP
Generated: true
---

# Services75 Sale AddSaleStakeholders SOAP

SOAP request and response examples **Remote/Services75/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services75.ISaleAgent.AddSaleStakeholders">SuperOffice.Services75.ISaleAgent.AddSaleStakeholders</see> method.

## AddSaleStakeholders



* **saleId:** 
* **saleStakeholders:** 



[WSDL file for Services75/Sale](../Services75-Sale.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddSaleStakeholders Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:AddSaleStakeholders>
    <Sale:SaleId xsi:type="xsd:int">0</Sale:SaleId>
    <Sale:SaleStakeholders xsi:type="Sale:ArrayOfSaleStakeholder">
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
    </Sale:SaleStakeholders>
   </Sale:AddSaleStakeholders>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddSaleStakeholders Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Sale:AddSaleStakeholdersResponse>
  </Sale:AddSaleStakeholdersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

