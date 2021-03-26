---
uid: services85-contact-savequoteversionaddress
title: Services85.ContactAgent.SaveQuoteVersionAddress SOAP
Generated: true
---

# Services85 Contact SaveQuoteVersionAddress SOAP

SOAP request and response examples **Remote/Services85/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IContactAgent.SaveQuoteVersionAddress">SuperOffice.Services85.IContactAgent.SaveQuoteVersionAddress</see> method.

## SaveQuoteVersionAddress

Save a custom quote version address.

* **quoteVersionId:** The version to save the address on.
* **address:** The address to save on the quote version.
* **addressType:** Should be either QuoteBillingAddress or QuoteShippingAddress
* **countryId:** The country for the custom address

**Returns:** The saved addresses.


[WSDL file for Services85/Contact](../Services85-Contact.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveQuoteVersionAddress Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:SaveQuoteVersionAddress>
    <Contact:QuoteVersionId xsi:type="xsd:int">0</Contact:QuoteVersionId>
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
    </Contact:Address>
    <Contact:AddressType xsi:type="Contact:AddressType">Unknown</Contact:AddressType>
    <Contact:CountryId xsi:type="xsd:int">0</Contact:CountryId>
   </Contact:SaveQuoteVersionAddress>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveQuoteVersionAddress Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Contact:SaveQuoteVersionAddressResponse>
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
  </Contact:SaveQuoteVersionAddressResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

