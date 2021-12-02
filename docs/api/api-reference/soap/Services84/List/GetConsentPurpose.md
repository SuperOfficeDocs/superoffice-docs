---
title: Services84.ListAgent.GetConsentPurpose SOAP
generated: 1
uid: Services84-List-GetConsentPurpose
---

# Services84 List GetConsentPurpose

SOAP request and response examples **Remote/Services84/List.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IListAgent.GetConsentPurpose">SuperOffice.Services84.IListAgent.GetConsentPurpose</see> method.

## GetConsentPurpose

Gets a ConsentPurpose object.

* **consentPurposeId:** The identifier of the ConsentPurpose object

**Returns:** ConsentPurpose


[WSDL file for Services84/List](../Services84-List.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConsentPurpose Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetConsentPurpose>
    <List:ConsentPurposeId xsi:type="xsd:int">0</List:ConsentPurposeId>
   </List:GetConsentPurpose>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConsentPurpose Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <List:GetConsentPurposeResponse>
   <List:Response xsi:type="List:ConsentPurpose">
    <List:ConsentPurposeId xsi:type="xsd:int">0</List:ConsentPurposeId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:ConsentText xsi:type="xsd:string"></List:ConsentText>
    <List:FormText xsi:type="xsd:string"></List:FormText>
    <List:Key xsi:type="xsd:string"></List:Key>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Active xsi:type="xsd:short">0</List:Active>
    <List:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:13Z</List:UpdatedDate>
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
    </List:UpdatedBy>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:PrivacyStatementDesc xsi:type="xsd:string"></List:PrivacyStatementDesc>
    <List:PrivacyStatementUrl xsi:type="xsd:string"></List:PrivacyStatementUrl>
   </List:Response>
  </List:GetConsentPurposeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

