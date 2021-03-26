---
uid: services80-contact-getaddressbycountry
title: Services80.ContactAgent.GetAddressByCountry SOAP
Generated: true
---

# Services80 Contact GetAddressByCountry SOAP

SOAP request and response examples **Remote/Services80/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IContactAgent.GetAddressByCountry">SuperOffice.Services80.IContactAgent.GetAddressByCountry</see> method.

## GetAddressByCountry

Gets the contact's localized address.

* **contactId:** The contact id
* **countryId:** 

**Returns:** The address as LocalizedField[][].


[WSDL file for Services80/Contact](../Services80-Contact.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAddressByCountry Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetAddressByCountry>
    <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
    <Contact:CountryId xsi:type="xsd:int">0</Contact:CountryId>
   </Contact:GetAddressByCountry>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAddressByCountry Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Contact:GetAddressByCountryResponse>
   <Contact:Response xsi:type="Contact:Address">
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
   </Contact:Response>
  </Contact:GetAddressByCountryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

