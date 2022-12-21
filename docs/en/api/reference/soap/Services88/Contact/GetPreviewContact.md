---
title: Services88.ContactAgent.GetPreviewContact SOAP
generated: 1
uid: Services88-Contact-GetPreviewContact
---

# Services88 Contact GetPreviewContact

SOAP request and response examples **Remote/Services88/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IContactAgent.GetPreviewContact">SuperOffice.Services88.IContactAgent.GetPreviewContact</see> method.

## GetPreviewContact





[WSDL file for Services88/Contact](../Services88-Contact.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPreviewContact Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetPreviewContact>
    <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
   </Contact:GetPreviewContact>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPreviewContact Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Contact:GetPreviewContactResponse>
   <Contact:Response xsi:type="Contact:PreviewContact">
    <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
    <Contact:Name xsi:type="xsd:string"></Contact:Name>
    <Contact:Department xsi:type="xsd:string"></Contact:Department>
    <Contact:CountryId xsi:type="xsd:int">0</Contact:CountryId>
    <Contact:Number2 xsi:type="xsd:string"></Contact:Number2>
    <Contact:DirectPhone xsi:type="xsd:string"></Contact:DirectPhone>
    <Contact:URL xsi:type="xsd:string"></Contact:URL>
    <Contact:EmailAddress xsi:type="xsd:string"></Contact:EmailAddress>
    <Contact:BusinessName xsi:type="xsd:string"></Contact:BusinessName>
    <Contact:CategoryName xsi:type="xsd:string"></Contact:CategoryName>
    <Contact:AssociateFullName xsi:type="xsd:string"></Contact:AssociateFullName>
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
      <Contact:Formatted xsi:type="xsd:string"></Contact:Formatted>
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
      <Contact:Formatted xsi:type="xsd:string"></Contact:Formatted>
     </Contact:Postal>
     <Contact:Formatted xsi:type="xsd:string"></Contact:Formatted>
    </Contact:Address>
   </Contact:Response>
  </Contact:GetPreviewContactResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

