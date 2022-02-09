---
title: Services85.ListAgent.SaveConsentPurpose SOAP
generated: 1
uid: Services85-List-SaveConsentPurpose
---

# Services85 List SaveConsentPurpose

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.SaveConsentPurpose">SuperOffice.Services85.IListAgent.SaveConsentPurpose</see> method.

## SaveConsentPurpose

Save a ConsentPurpose object

* **consentPurpose:** The ConsentPurpose object to save

**Returns:** The saved ConsentPurpose object, updated with the ConsentPurposeId if it is a new database entry


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveConsentPurpose Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SaveConsentPurpose>
    <List:ConsentPurpose xsi:type="List:ConsentPurpose">
     <List:ConsentPurposeId xsi:type="xsd:int">0</List:ConsentPurposeId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:ConsentText xsi:type="xsd:string"></List:ConsentText>
     <List:FormText xsi:type="xsd:string"></List:FormText>
     <List:Key xsi:type="xsd:string"></List:Key>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Active xsi:type="xsd:short">0</List:Active>
     <List:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:34Z</List:UpdatedDate>
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
    </List:ConsentPurpose>
   </List:SaveConsentPurpose>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveConsentPurpose Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <List:SaveConsentPurposeResponse>
   <List:Response xsi:type="List:ConsentPurpose">
    <List:ConsentPurposeId xsi:type="xsd:int">0</List:ConsentPurposeId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:ConsentText xsi:type="xsd:string"></List:ConsentText>
    <List:FormText xsi:type="xsd:string"></List:FormText>
    <List:Key xsi:type="xsd:string"></List:Key>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Active xsi:type="xsd:short">0</List:Active>
    <List:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:34Z</List:UpdatedDate>
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
  </List:SaveConsentPurposeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

