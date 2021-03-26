---
uid: services86-contact-getcontact
title: Services86.ContactAgent.GetContact SOAP
Generated: true
---

# Services86 Contact GetContact SOAP

SOAP request and response examples **Remote/Services86/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IContactAgent.GetContact">SuperOffice.Services86.IContactAgent.GetContact</see> method.

## GetContact

Gets a Contact object.

* **contactId:** The identifier of the Contact object

**Returns:** Contact


[WSDL file for Services86/Contact](../Services86-Contact.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetContact Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetContact>
    <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
   </Contact:GetContact>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetContact Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Contact:GetContactResponse>
   <Contact:Response xsi:type="Contact:Contact">
    <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
    <Contact:Name xsi:type="xsd:string"></Contact:Name>
    <Contact:OrgNr xsi:type="xsd:string"></Contact:OrgNr>
    <Contact:Department xsi:type="xsd:string"></Contact:Department>
    <Contact:URL xsi:type="xsd:string"></Contact:URL>
    <Contact:City xsi:type="xsd:string"></Contact:City>
    <Contact:DirectPhone xsi:type="xsd:string"></Contact:DirectPhone>
    <Contact:AssociateId xsi:type="xsd:int">0</Contact:AssociateId>
    <Contact:CountryId xsi:type="xsd:int">0</Contact:CountryId>
    <Contact:EmailAddress xsi:type="xsd:string"></Contact:EmailAddress>
    <Contact:Kananame xsi:type="xsd:string"></Contact:Kananame>
    <Contact:EmailAddressName xsi:type="xsd:string"></Contact:EmailAddressName>
    <Contact:URLName xsi:type="xsd:string"></Contact:URLName>
    <Contact:AssociateFullName xsi:type="xsd:string"></Contact:AssociateFullName>
    <Contact:BusinessName xsi:type="xsd:string"></Contact:BusinessName>
    <Contact:CategoryName xsi:type="xsd:string"></Contact:CategoryName>
    <Contact:CountryName xsi:type="xsd:string"></Contact:CountryName>
    <Contact:Address xsi:type="Contact:Address">
     <Contact:Wgs84Latitude xsi:type="xsd:double">0.0</Contact:Wgs84Latitude>
     <Contact:Wgs84Longitude xsi:type="xsd:double">0.0</Contact:Wgs84Longitude>
     <Contact:LocalizedAddress xsi:type="Contact:ArrayOfArrayOfLocalizedField">
      <Contact:ArrayOfLocalizedField xsi:type="Contact:ArrayOfLocalizedField">
       <Contact:LocalizedField xsi:type="Contact:LocalizedField">
        <Contact:Name xsi:type="xsd:string"></Contact:Name>
        <Contact:Value xsi:type="xsd:string"></Contact:Value>
        <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
        <Contact:Label xsi:type="xsd:string"></Contact:Label>
        <Contact:ValueLength xsi:type="xsd:int">0</Contact:ValueLength>
        <Contact:AddressType xsi:type="xsd:string"></Contact:AddressType>
       </Contact:LocalizedField>
      </Contact:ArrayOfLocalizedField>
     </Contact:LocalizedAddress>
     <Contact:Street xsi:type="Contact:StructuredAddress">
      <Contact:AtypeIdx xsi:type="Contact:AddressType">Unknown</Contact:AtypeIdx>
      <Contact:Address1 xsi:type="xsd:string"></Contact:Address1>
      <Contact:Address2 xsi:type="xsd:string"></Contact:Address2>
      <Contact:Address3 xsi:type="xsd:string"></Contact:Address3>
      <Contact:City xsi:type="xsd:string"></Contact:City>
      <Contact:County xsi:type="xsd:string"></Contact:County>
      <Contact:State xsi:type="xsd:string"></Contact:State>
      <Contact:Zipcode xsi:type="xsd:string"></Contact:Zipcode>
     </Contact:Street>
     <Contact:Postal xsi:type="Contact:StructuredAddress">
      <Contact:AtypeIdx xsi:type="Contact:AddressType">Unknown</Contact:AtypeIdx>
      <Contact:Address1 xsi:type="xsd:string"></Contact:Address1>
      <Contact:Address2 xsi:type="xsd:string"></Contact:Address2>
      <Contact:Address3 xsi:type="xsd:string"></Contact:Address3>
      <Contact:City xsi:type="xsd:string"></Contact:City>
      <Contact:County xsi:type="xsd:string"></Contact:County>
      <Contact:State xsi:type="xsd:string"></Contact:State>
      <Contact:Zipcode xsi:type="xsd:string"></Contact:Zipcode>
     </Contact:Postal>
    </Contact:Address>
    <Contact:FormattedAddress xsi:type="xsd:string"></Contact:FormattedAddress>
    <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
    <Contact:IsOwnerContact xsi:type="xsd:boolean">false</Contact:IsOwnerContact>
    <Contact:ActiveErpLinks xsi:type="xsd:int">0</Contact:ActiveErpLinks>
   </Contact:Response>
  </Contact:GetContactResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

