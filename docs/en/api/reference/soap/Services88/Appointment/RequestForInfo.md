---
title: Services88.AppointmentAgent.RequestForInfo SOAP
generated: true
uid: Services88-Appointment-RequestForInfo
content_type: reference
---

# Services88 Appointment RequestForInfo

SOAP request and response examples **Remote/Services88/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAppointmentAgent.RequestForInfo">SuperOffice.Services88.IAppointmentAgent.RequestForInfo</see> method.

## RequestForInfo





[WSDL file for Services88/Appointment](../Services88-Appointment.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RequestForInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:RequestForInfo>
    <Appointment:AssociateIdForNewContact xsi:type="xsd:int">0</Appointment:AssociateIdForNewContact>
    <Appointment:Channel xsi:type="xsd:string"></Appointment:Channel>
    <Appointment:Regarding xsi:type="xsd:string"></Appointment:Regarding>
    <Appointment:ContactName xsi:type="xsd:string"></Appointment:ContactName>
    <Appointment:PersonFirstname xsi:type="xsd:string"></Appointment:PersonFirstname>
    <Appointment:PersonLastname xsi:type="xsd:string"></Appointment:PersonLastname>
    <Appointment:EmailAddress xsi:type="xsd:string"></Appointment:EmailAddress>
    <Appointment:PhoneNumber xsi:type="xsd:string"></Appointment:PhoneNumber>
   </Appointment:RequestForInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RequestForInfo Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Appointment:RequestForInfoResponse>
   <Appointment:Response xsi:type="Appointment:SalesActivity">
    <Appointment:RequestedContacts xsi:type="Appointment:ArrayOfContact">
     <Appointment:Contact xsi:type="Appointment:Contact">
      <Appointment:ContactId xsi:type="xsd:int">0</Appointment:ContactId>
      <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
      <Appointment:OrgNr xsi:type="xsd:string"></Appointment:OrgNr>
      <Appointment:Department xsi:type="xsd:string"></Appointment:Department>
      <Appointment:URL xsi:type="xsd:string"></Appointment:URL>
      <Appointment:City xsi:type="xsd:string"></Appointment:City>
      <Appointment:DirectPhone xsi:type="xsd:string"></Appointment:DirectPhone>
      <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
      <Appointment:CountryId xsi:type="xsd:int">0</Appointment:CountryId>
      <Appointment:EmailAddress xsi:type="xsd:string"></Appointment:EmailAddress>
      <Appointment:Kananame xsi:type="xsd:string"></Appointment:Kananame>
      <Appointment:EmailAddressName xsi:type="xsd:string"></Appointment:EmailAddressName>
      <Appointment:URLName xsi:type="xsd:string"></Appointment:URLName>
      <Appointment:AssociateFullName xsi:type="xsd:string"></Appointment:AssociateFullName>
      <Appointment:BusinessName xsi:type="xsd:string"></Appointment:BusinessName>
      <Appointment:CategoryName xsi:type="xsd:string"></Appointment:CategoryName>
      <Appointment:CountryName xsi:type="xsd:string"></Appointment:CountryName>
      <Appointment:Address xsi:type="Appointment:Address">
       <Appointment:Wgs84Latitude xsi:type="xsd:double">0.0</Appointment:Wgs84Latitude>
       <Appointment:Wgs84Longitude xsi:type="xsd:double">0.0</Appointment:Wgs84Longitude>
       <Appointment:LocalizedAddress xsi:type="Appointment:ArrayOfArrayOfLocalizedField">
        <Appointment:ArrayOfLocalizedField xsi:type="Appointment:ArrayOfLocalizedField">
         <Appointment:LocalizedField xsi:type="Appointment:LocalizedField">
          <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
          <Appointment:Value xsi:type="xsd:string"></Appointment:Value>
          <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
          <Appointment:Label xsi:type="xsd:string"></Appointment:Label>
          <Appointment:ValueLength xsi:nil="true"></Appointment:ValueLength>
          <Appointment:AddressType xsi:type="xsd:string"></Appointment:AddressType>
         </Appointment:LocalizedField>
        </Appointment:ArrayOfLocalizedField>
       </Appointment:LocalizedAddress>
       <Appointment:Street xsi:type="Appointment:StructuredAddress">
        <Appointment:AtypeIdx xsi:type="Appointment:AddressType">Unknown</Appointment:AtypeIdx>
        <Appointment:Address1 xsi:type="xsd:string"></Appointment:Address1>
        <Appointment:Address2 xsi:type="xsd:string"></Appointment:Address2>
        <Appointment:Address3 xsi:type="xsd:string"></Appointment:Address3>
        <Appointment:City xsi:type="xsd:string"></Appointment:City>
        <Appointment:County xsi:type="xsd:string"></Appointment:County>
        <Appointment:State xsi:type="xsd:string"></Appointment:State>
        <Appointment:Zipcode xsi:type="xsd:string"></Appointment:Zipcode>
        <Appointment:Formatted xsi:type="xsd:string"></Appointment:Formatted>
       </Appointment:Street>
       <Appointment:Postal xsi:type="Appointment:StructuredAddress">
        <Appointment:AtypeIdx xsi:type="Appointment:AddressType">Unknown</Appointment:AtypeIdx>
        <Appointment:Address1 xsi:type="xsd:string"></Appointment:Address1>
        <Appointment:Address2 xsi:type="xsd:string"></Appointment:Address2>
        <Appointment:Address3 xsi:type="xsd:string"></Appointment:Address3>
        <Appointment:City xsi:type="xsd:string"></Appointment:City>
        <Appointment:County xsi:type="xsd:string"></Appointment:County>
        <Appointment:State xsi:type="xsd:string"></Appointment:State>
        <Appointment:Zipcode xsi:type="xsd:string"></Appointment:Zipcode>
        <Appointment:Formatted xsi:type="xsd:string"></Appointment:Formatted>
       </Appointment:Postal>
       <Appointment:Formatted xsi:type="xsd:string"></Appointment:Formatted>
      </Appointment:Address>
      <Appointment:FormattedAddress xsi:type="xsd:string"></Appointment:FormattedAddress>
      <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
      <Appointment:IsOwnerContact xsi:type="xsd:boolean">false</Appointment:IsOwnerContact>
      <Appointment:ActiveErpLinks xsi:type="xsd:int">0</Appointment:ActiveErpLinks>
      <Appointment:Number1 xsi:type="xsd:string"></Appointment:Number1>
      <Appointment:Number2 xsi:type="xsd:string"></Appointment:Number2>
     </Appointment:Contact>
    </Appointment:RequestedContacts>
    <Appointment:RequestedPerson xsi:type="Appointment:Person">
     <Appointment:Position xsi:type="xsd:string"></Appointment:Position>
     <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
     <Appointment:Mrmrs xsi:type="xsd:string"></Appointment:Mrmrs>
     <Appointment:Firstname xsi:type="xsd:string"></Appointment:Firstname>
     <Appointment:Lastname xsi:type="xsd:string"></Appointment:Lastname>
     <Appointment:MiddleName xsi:type="xsd:string"></Appointment:MiddleName>
     <Appointment:Title xsi:type="xsd:string"></Appointment:Title>
     <Appointment:Description xsi:type="xsd:string"></Appointment:Description>
     <Appointment:Email xsi:type="xsd:string"></Appointment:Email>
     <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
     <Appointment:DirectPhone xsi:type="xsd:string"></Appointment:DirectPhone>
     <Appointment:FormalName xsi:type="xsd:string"></Appointment:FormalName>
     <Appointment:CountryId xsi:type="xsd:int">0</Appointment:CountryId>
     <Appointment:ContactId xsi:type="xsd:int">0</Appointment:ContactId>
     <Appointment:ContactName xsi:type="xsd:string"></Appointment:ContactName>
     <Appointment:Retired xsi:type="xsd:short">0</Appointment:Retired>
     <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
     <Appointment:ActiveInterests xsi:type="xsd:short">0</Appointment:ActiveInterests>
     <Appointment:ContactDepartment xsi:type="xsd:string"></Appointment:ContactDepartment>
     <Appointment:ContactCountryId xsi:type="xsd:int">0</Appointment:ContactCountryId>
     <Appointment:ContactOrgNr xsi:type="xsd:string"></Appointment:ContactOrgNr>
     <Appointment:FaxPhone xsi:type="xsd:string"></Appointment:FaxPhone>
     <Appointment:MobilePhone xsi:type="xsd:string"></Appointment:MobilePhone>
     <Appointment:ContactPhone xsi:type="xsd:string"></Appointment:ContactPhone>
     <Appointment:AssociateName xsi:type="xsd:string"></Appointment:AssociateName>
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:UsePersonAddress xsi:type="xsd:boolean">false</Appointment:UsePersonAddress>
     <Appointment:ContactFax xsi:type="xsd:string"></Appointment:ContactFax>
     <Appointment:Kanafname xsi:type="xsd:string"></Appointment:Kanafname>
     <Appointment:Kanalname xsi:type="xsd:string"></Appointment:Kanalname>
     <Appointment:Post1 xsi:type="xsd:string"></Appointment:Post1>
     <Appointment:Post2 xsi:type="xsd:string"></Appointment:Post2>
     <Appointment:Post3 xsi:type="xsd:string"></Appointment:Post3>
     <Appointment:EmailName xsi:type="xsd:string"></Appointment:EmailName>
     <Appointment:ContactFullName xsi:type="xsd:string"></Appointment:ContactFullName>
     <Appointment:ActiveErpLinks xsi:type="xsd:int">0</Appointment:ActiveErpLinks>
     <Appointment:TicketPriorityId xsi:type="xsd:int">0</Appointment:TicketPriorityId>
     <Appointment:SupportLanguageId xsi:type="xsd:int">0</Appointment:SupportLanguageId>
     <Appointment:SupportAssociateId xsi:type="xsd:int">0</Appointment:SupportAssociateId>
     <Appointment:CategoryName xsi:type="xsd:string"></Appointment:CategoryName>
     <Appointment:PersonNumber xsi:type="xsd:string"></Appointment:PersonNumber>
    </Appointment:RequestedPerson>
    <Appointment:SalesRep xsi:type="Appointment:Person">
     <Appointment:Position xsi:type="xsd:string"></Appointment:Position>
     <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
     <Appointment:Mrmrs xsi:type="xsd:string"></Appointment:Mrmrs>
     <Appointment:Firstname xsi:type="xsd:string"></Appointment:Firstname>
     <Appointment:Lastname xsi:type="xsd:string"></Appointment:Lastname>
     <Appointment:MiddleName xsi:type="xsd:string"></Appointment:MiddleName>
     <Appointment:Title xsi:type="xsd:string"></Appointment:Title>
     <Appointment:Description xsi:type="xsd:string"></Appointment:Description>
     <Appointment:Email xsi:type="xsd:string"></Appointment:Email>
     <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
     <Appointment:DirectPhone xsi:type="xsd:string"></Appointment:DirectPhone>
     <Appointment:FormalName xsi:type="xsd:string"></Appointment:FormalName>
     <Appointment:CountryId xsi:type="xsd:int">0</Appointment:CountryId>
     <Appointment:ContactId xsi:type="xsd:int">0</Appointment:ContactId>
     <Appointment:ContactName xsi:type="xsd:string"></Appointment:ContactName>
     <Appointment:Retired xsi:type="xsd:short">0</Appointment:Retired>
     <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
     <Appointment:ActiveInterests xsi:type="xsd:short">0</Appointment:ActiveInterests>
     <Appointment:ContactDepartment xsi:type="xsd:string"></Appointment:ContactDepartment>
     <Appointment:ContactCountryId xsi:type="xsd:int">0</Appointment:ContactCountryId>
     <Appointment:ContactOrgNr xsi:type="xsd:string"></Appointment:ContactOrgNr>
     <Appointment:FaxPhone xsi:type="xsd:string"></Appointment:FaxPhone>
     <Appointment:MobilePhone xsi:type="xsd:string"></Appointment:MobilePhone>
     <Appointment:ContactPhone xsi:type="xsd:string"></Appointment:ContactPhone>
     <Appointment:AssociateName xsi:type="xsd:string"></Appointment:AssociateName>
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:UsePersonAddress xsi:type="xsd:boolean">false</Appointment:UsePersonAddress>
     <Appointment:ContactFax xsi:type="xsd:string"></Appointment:ContactFax>
     <Appointment:Kanafname xsi:type="xsd:string"></Appointment:Kanafname>
     <Appointment:Kanalname xsi:type="xsd:string"></Appointment:Kanalname>
     <Appointment:Post1 xsi:type="xsd:string"></Appointment:Post1>
     <Appointment:Post2 xsi:type="xsd:string"></Appointment:Post2>
     <Appointment:Post3 xsi:type="xsd:string"></Appointment:Post3>
     <Appointment:EmailName xsi:type="xsd:string"></Appointment:EmailName>
     <Appointment:ContactFullName xsi:type="xsd:string"></Appointment:ContactFullName>
     <Appointment:ActiveErpLinks xsi:type="xsd:int">0</Appointment:ActiveErpLinks>
     <Appointment:TicketPriorityId xsi:type="xsd:int">0</Appointment:TicketPriorityId>
     <Appointment:SupportLanguageId xsi:type="xsd:int">0</Appointment:SupportLanguageId>
     <Appointment:SupportAssociateId xsi:type="xsd:int">0</Appointment:SupportAssociateId>
     <Appointment:CategoryName xsi:type="xsd:string"></Appointment:CategoryName>
     <Appointment:PersonNumber xsi:type="xsd:string"></Appointment:PersonNumber>
    </Appointment:SalesRep>
   </Appointment:Response>
  </Appointment:RequestForInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

