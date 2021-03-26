---
uid: services84-appointment-generatelead
title: Services84.AppointmentAgent.GenerateLead SOAP
Generated: true
---

# Services84 Appointment GenerateLead SOAP

SOAP request and response examples **Remote/Services84/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAppointmentAgent.GenerateLead">SuperOffice.Services84.IAppointmentAgent.GenerateLead</see> method.

## GenerateLead

Adds a sales lead (task) to a contact in SuperOffice. If the contact or person is known, the sales lead is added to the current contact. If not, a new contact is created, with the associate with ownerIdForNewContact as responsible (Our Contact). A relation is created between the contact and the person submitting the lead. Based on wether the person the request is made for is found or not, the following happens: If the person is found, the person, person's contact and sales representative is returned. If neither the person nor the contact is found a new person and contact is created (if sufficient data is supplied), and the person, person's contact and sales representative is returned. If the contact and not the person is found a new person is created on this contact, and the contact, salesrep, and person is returned (if there was enough data to return the person). If more than one contact is found a list of contacts is returned.

* **associateIdForNewContact:** Associate id of the person set as "Our Contact" if a new Contact is created. Ensures that the sales lead is assigned to the correct salesman.
* **leadDescription:** Description of the lead. The lead text as shown in SuperOffice
* **relation:** The relation the person submitting the lead has to the contact.
* **relationId:** Id of the relation type. Database specific.
* **leadContact:** Name of the new or existing contact (company) the lead is created for.
* **leadPersonFirstname:** Firstname of the contact's person.
* **leadPersonLastname:** Lastname of the contact's person.
* **leadPersonEmail:** Email to the contact's person.
* **leadPhoneNumber:** Phone number of the contact or contact's person.
* **creatorsContact:** The contact (company) of the person creating the lead
* **creatorsFirstname:** The firstname of the person creating the lead
* **creatorsLastname:** The lastname of the person creating the lead

**Returns:** True if successfull.


[WSDL file for Services84/Appointment](../Services84-Appointment.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GenerateLead Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:GenerateLead>
    <Appointment:AssociateIdForNewContact xsi:type="xsd:int">0</Appointment:AssociateIdForNewContact>
    <Appointment:LeadDescription xsi:type="xsd:string"></Appointment:LeadDescription>
    <Appointment:Relation xsi:type="xsd:string"></Appointment:Relation>
    <Appointment:RelationId xsi:type="xsd:int">0</Appointment:RelationId>
    <Appointment:LeadContact xsi:type="xsd:string"></Appointment:LeadContact>
    <Appointment:LeadPersonFirstname xsi:type="xsd:string"></Appointment:LeadPersonFirstname>
    <Appointment:LeadPersonLastname xsi:type="xsd:string"></Appointment:LeadPersonLastname>
    <Appointment:LeadPersonEmail xsi:type="xsd:string"></Appointment:LeadPersonEmail>
    <Appointment:LeadPhoneNumber xsi:type="xsd:string"></Appointment:LeadPhoneNumber>
    <Appointment:CreatorsContact xsi:type="xsd:string"></Appointment:CreatorsContact>
    <Appointment:CreatorsFirstname xsi:type="xsd:string"></Appointment:CreatorsFirstname>
    <Appointment:CreatorsLastname xsi:type="xsd:string"></Appointment:CreatorsLastname>
   </Appointment:GenerateLead>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GenerateLead Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Appointment:GenerateLeadResponse>
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
    </Appointment:SalesRep>
   </Appointment:Response>
  </Appointment:GenerateLeadResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

