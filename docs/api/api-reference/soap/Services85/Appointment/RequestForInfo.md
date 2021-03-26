---
uid: services85-appointment-requestforinfo
title: Services85.AppointmentAgent.RequestForInfo SOAP
Generated: true
---

# Services85 Appointment RequestForInfo SOAP

SOAP request and response examples **Remote/Services85/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IAppointmentAgent.RequestForInfo">SuperOffice.Services85.IAppointmentAgent.RequestForInfo</see> method.

## RequestForInfo

Submits a request for information. The request is added to the task list of the user that is responsible for this contact. Based on wether the person the request is made for is found or not, the following happens: If the person is found, the person, person's contact and sales representative is returned. If neither the person nor the contact is found a new person and contact is created (if sufficient data is supplied), and the person, person's contact and sales representative is returned. If the contact and not the person is found a new person is created on this contact, and the contact, salesrep, and person is returned (if there was enough data to return the person). If more than one contact is found a list of contacts is returned.

* **associateIdForNewContact:** Associate id of the person set as "Our Contact" if a new Contact is created. Ensures that the request is assigned to the correct salesman.
* **channel:** The requested channel, e.g. "Phone"
* **regarding:** The text submitted by the user.
* **contactName:** The name of the contact that the RFI will be added to. May be empty.
* **personFirstname:** The firstname of the person that the RFI will be added to. May be empty.
* **personLastname:** The lastname of the person that the RFI will be added to. May be empty.
* **emailAddress:** The email address of the person that the RFI will be added to.
* **phoneNumber:** Phone number of the contact or contact's person.

**Returns:** True if the submission was successful.


[WSDL file for Services85/Appointment](../Services85-Appointment.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RequestForInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services85">
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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services85">
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
      </Appointment:Address>
      <Appointment:FormattedAddress xsi:type="xsd:string"></Appointment:FormattedAddress>
      <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
      <Appointment:IsOwnerContact xsi:type="xsd:boolean">false</Appointment:IsOwnerContact>
      <Appointment:ActiveErpLinks xsi:type="xsd:int">0</Appointment:ActiveErpLinks>
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
    </Appointment:SalesRep>
   </Appointment:Response>
  </Appointment:RequestForInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

