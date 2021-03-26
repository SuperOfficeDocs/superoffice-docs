---
uid: services86-list-getconsentpurposelist
title: Services86.ListAgent.GetConsentPurposeList SOAP
Generated: true
---

# Services86 List GetConsentPurposeList SOAP

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.GetConsentPurposeList">SuperOffice.Services86.IListAgent.GetConsentPurposeList</see> method.

## GetConsentPurposeList

Gets an array of ConsentPurpose objects.

* **consentPurposeIds:** The identifiers of the ConsentPurpose object

**Returns:** Array of ConsentPurpose objects


[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConsentPurposeList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetConsentPurposeList>
    <List:ConsentPurposeIds xsi:type="NetServerServices862:ArrayOfint">
     <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
    </List:ConsentPurposeIds>
   </List:GetConsentPurposeList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConsentPurposeList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <List:GetConsentPurposeListResponse>
   <List:Response xsi:type="List:ArrayOfConsentPurpose">
    <List:ConsentPurpose xsi:type="List:ConsentPurpose">
     <List:ConsentPurposeId xsi:type="xsd:int">0</List:ConsentPurposeId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:ConsentText xsi:type="xsd:string"></List:ConsentText>
     <List:FormText xsi:type="xsd:string"></List:FormText>
     <List:Key xsi:type="xsd:string"></List:Key>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Active xsi:type="xsd:short">0</List:Active>
     <List:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:36:13Z</List:UpdatedDate>
     <List:UpdatedBy xsi:type="List:Associate">
      <List:AssociateId xsi:type="xsd:int">0</List:AssociateId>
      <List:Name xsi:type="xsd:string"></List:Name>
      <List:PersonId xsi:type="xsd:int">0</List:PersonId>
      <List:Rank xsi:type="xsd:short">0</List:Rank>
      <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
      <List:Type xsi:type="List:UserType">Unknown</List:Type>
      <List:GroupIdx xsi:type="xsd:int">0</List:GroupIdx>
      <List:FullName xsi:type="xsd:string"></List:FullName>
      <List:FormalName xsi:type="xsd:string"></List:FormalName>
      <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
      <List:EjUserId xsi:type="xsd:int">0</List:EjUserId>
      <List:UserName xsi:type="xsd:string"></List:UserName>
     </List:UpdatedBy>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:PrivacyStatementDesc xsi:type="xsd:string"></List:PrivacyStatementDesc>
     <List:PrivacyStatementUrl xsi:type="xsd:string"></List:PrivacyStatementUrl>
    </List:ConsentPurpose>
   </List:Response>
  </List:GetConsentPurposeListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

