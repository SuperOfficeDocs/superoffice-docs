---
uid: services81-contact-getaddress
title: Services81.ContactAgent.GetAddress SOAP
Generated: true
---

# Services81 Contact GetAddress SOAP

SOAP request and response examples **Remote/Services81/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IContactAgent.GetAddress">SuperOffice.Services81.IContactAgent.GetAddress</see> method.

## GetAddress

Gets the contact's localized address.

* **contactId:** The contact id

**Returns:** The address as LocalizedField[][].


[WSDL file for Services81/Contact](../Services81-Contact.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAddress Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetAddress>
    <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
   </Contact:GetAddress>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAddress Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Contact:GetAddressResponse>
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
  </Contact:GetAddressResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

