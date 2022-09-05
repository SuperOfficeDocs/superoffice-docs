---
title: Services85.PersonAgent.GetAddressByCountry SOAP
generated: 1
uid: Services85-Person-GetAddressByCountry
---

# Services85 Person GetAddressByCountry

SOAP request and response examples **Remote/Services85/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IPersonAgent.GetAddressByCountry">SuperOffice.Services85.IPersonAgent.GetAddressByCountry</see> method.

## GetAddressByCountry

Gets the person's localized address.

* **personId:** The person id
* **countryId:** 

**Returns:** The address as LocalizedField[][].


[WSDL file for Services85/Person](../Services85-Person.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAddressByCountry Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:GetAddressByCountry>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:CountryId xsi:type="xsd:int">0</Person:CountryId>
   </Person:GetAddressByCountry>

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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Person:GetAddressByCountryResponse>
   <Person:Response xsi:type="Person:Address">
    <Person:Wgs84Latitude xsi:type="xsd:double">0.0</Person:Wgs84Latitude>
    <Person:Wgs84Longitude xsi:type="xsd:double">0.0</Person:Wgs84Longitude>
    <Person:LocalizedAddress xsi:type="Person:ArrayOfArrayOfLocalizedField">
     <Person:ArrayOfLocalizedField xsi:type="Person:ArrayOfLocalizedField">
      <Person:LocalizedField xsi:type="Person:LocalizedField">
       <Person:Name xsi:type="xsd:string"></Person:Name>
       <Person:Value xsi:type="xsd:string"></Person:Value>
       <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
       <Person:Label xsi:type="xsd:string"></Person:Label>
       <Person:ValueLength xsi:type="xsd:int">0</Person:ValueLength>
       <Person:AddressType xsi:type="xsd:string"></Person:AddressType>
      </Person:LocalizedField>
     </Person:ArrayOfLocalizedField>
    </Person:LocalizedAddress>
   </Person:Response>
  </Person:GetAddressByCountryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

