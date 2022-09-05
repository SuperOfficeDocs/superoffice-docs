---
title: Services88.PersonAgent.SaveConsentPerson SOAP
generated: 1
uid: Services88-Person-SaveConsentPerson
---

# Services88 Person SaveConsentPerson

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.SaveConsentPerson">SuperOffice.Services88.IPersonAgent.SaveConsentPerson</see> method.

## SaveConsentPerson

Updates the existing ConsentPerson or creates a new ConsentPerson if the id parameter is 0.

* **consentPerson:** The ConsentPerson that is saved.

**Returns:** New or updated ConsentPerson


[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveConsentPerson Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:SaveConsentPerson>
    <Person:ConsentPerson xsi:type="Person:ConsentPerson">
     <Person:ConsentPersonId xsi:type="xsd:int">0</Person:ConsentPersonId>
     <Person:ConsentSource xsi:type="Person:ConsentSource">
      <Person:ConsentSourceId xsi:type="xsd:int">0</Person:ConsentSourceId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
      <Person:Rank xsi:type="xsd:short">0</Person:Rank>
      <Person:Key xsi:type="xsd:string"></Person:Key>
      <Person:MailTemplateId xsi:type="xsd:int">0</Person:MailTemplateId>
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
     </Person:ConsentSource>
     <Person:LegalBase xsi:type="Person:LegalBase">
      <Person:LegalBaseId xsi:type="xsd:int">0</Person:LegalBaseId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
      <Person:Rank xsi:type="xsd:short">0</Person:Rank>
      <Person:Key xsi:type="xsd:string"></Person:Key>
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
     </Person:LegalBase>
     <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
     <Person:ConsentPurpose xsi:type="Person:ConsentPurpose">
      <Person:ConsentPurposeId xsi:type="xsd:int">0</Person:ConsentPurposeId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:ConsentText xsi:type="xsd:string"></Person:ConsentText>
      <Person:FormText xsi:type="xsd:string"></Person:FormText>
      <Person:Key xsi:type="xsd:string"></Person:Key>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
      <Person:Active xsi:type="xsd:short">0</Person:Active>
      <Person:UpdatedDate xsi:type="xsd:dateTime">2022-08-26T08:59:56Z</Person:UpdatedDate>
      <Person:UpdatedBy xsi:type="Person:Associate">
       <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
       <Person:Name xsi:type="xsd:string"></Person:Name>
       <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
       <Person:Rank xsi:type="xsd:short">0</Person:Rank>
       <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
       <Person:Type xsi:type="Person:UserType">Unknown</Person:Type>
       <Person:GroupIdx xsi:type="xsd:int">0</Person:GroupIdx>
       <Person:FullName xsi:type="xsd:string"></Person:FullName>
       <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
       <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
       <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
       <Person:UserName xsi:type="xsd:string"></Person:UserName>
      </Person:UpdatedBy>
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
      <Person:Rank xsi:type="xsd:short">0</Person:Rank>
      <Person:PrivacyStatementDesc xsi:type="xsd:string"></Person:PrivacyStatementDesc>
      <Person:PrivacyStatementUrl xsi:type="xsd:string"></Person:PrivacyStatementUrl>
     </Person:ConsentPurpose>
     <Person:Comment xsi:type="xsd:string"></Person:Comment>
    </Person:ConsentPerson>
   </Person:SaveConsentPerson>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveConsentPerson Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Person:SaveConsentPersonResponse>
   <Person:Response xsi:type="Person:ConsentPerson">
    <Person:ConsentPersonId xsi:type="xsd:int">0</Person:ConsentPersonId>
    <Person:ConsentSource xsi:type="Person:ConsentSource">
     <Person:ConsentSourceId xsi:type="xsd:int">0</Person:ConsentSourceId>
     <Person:Name xsi:type="xsd:string"></Person:Name>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     <Person:Rank xsi:type="xsd:short">0</Person:Rank>
     <Person:Key xsi:type="xsd:string"></Person:Key>
     <Person:MailTemplateId xsi:type="xsd:int">0</Person:MailTemplateId>
     <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
    </Person:ConsentSource>
    <Person:LegalBase xsi:type="Person:LegalBase">
     <Person:LegalBaseId xsi:type="xsd:int">0</Person:LegalBaseId>
     <Person:Name xsi:type="xsd:string"></Person:Name>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     <Person:Rank xsi:type="xsd:short">0</Person:Rank>
     <Person:Key xsi:type="xsd:string"></Person:Key>
     <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
    </Person:LegalBase>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:ConsentPurpose xsi:type="Person:ConsentPurpose">
     <Person:ConsentPurposeId xsi:type="xsd:int">0</Person:ConsentPurposeId>
     <Person:Name xsi:type="xsd:string"></Person:Name>
     <Person:ConsentText xsi:type="xsd:string"></Person:ConsentText>
     <Person:FormText xsi:type="xsd:string"></Person:FormText>
     <Person:Key xsi:type="xsd:string"></Person:Key>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     <Person:Active xsi:type="xsd:short">0</Person:Active>
     <Person:UpdatedDate xsi:type="xsd:dateTime">2022-08-26T08:59:56Z</Person:UpdatedDate>
     <Person:UpdatedBy xsi:type="Person:Associate">
      <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
      <Person:Rank xsi:type="xsd:short">0</Person:Rank>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
      <Person:Type xsi:type="Person:UserType">Unknown</Person:Type>
      <Person:GroupIdx xsi:type="xsd:int">0</Person:GroupIdx>
      <Person:FullName xsi:type="xsd:string"></Person:FullName>
      <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
      <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
      <Person:UserName xsi:type="xsd:string"></Person:UserName>
     </Person:UpdatedBy>
     <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
     <Person:Rank xsi:type="xsd:short">0</Person:Rank>
     <Person:PrivacyStatementDesc xsi:type="xsd:string"></Person:PrivacyStatementDesc>
     <Person:PrivacyStatementUrl xsi:type="xsd:string"></Person:PrivacyStatementUrl>
    </Person:ConsentPurpose>
    <Person:Comment xsi:type="xsd:string"></Person:Comment>
   </Person:Response>
  </Person:SaveConsentPersonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

