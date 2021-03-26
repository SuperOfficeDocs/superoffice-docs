---
uid: services88-phonelist-getfavoritesphones
title: Services88.PhoneListAgent.GetFavoritesPhones SOAP
Generated: true
---

# Services88 PhoneList GetFavoritesPhones SOAP

SOAP request and response examples **Remote/Services88/PhoneList.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPhoneListAgent.GetFavoritesPhones">SuperOffice.Services88.IPhoneListAgent.GetFavoritesPhones</see> method.

## GetFavoritesPhones

Returns an array of phone list items with the Contacts in the users favorites dropdown list.


**Returns:** The favorite contact phone list


[WSDL file for Services88/PhoneList](../Services88-PhoneList.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFavoritesPhones Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:PhoneList="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <PhoneList:ApplicationToken>1234567-1234-9876</PhoneList:ApplicationToken>
  <PhoneList:Credentials>
    <PhoneList:Ticket>7T:1234abcxyzExample==</PhoneList:Ticket>
  </PhoneList:Credentials>
 <SOAP-ENV:Body>
   <PhoneList:GetFavoritesPhones>
   </PhoneList:GetFavoritesPhones>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFavoritesPhones Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:PhoneList="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <PhoneList:GetFavoritesPhonesResponse>
   <PhoneList:Response xsi:type="PhoneList:ArrayOfPhoneListItem">
    <PhoneList:PhoneListItem xsi:type="PhoneList:PhoneListItem">
     <PhoneList:PersonDirectPhone xsi:type="xsd:string"></PhoneList:PersonDirectPhone>
     <PhoneList:PersonCellPhone xsi:type="xsd:string"></PhoneList:PersonCellPhone>
     <PhoneList:PersonPrivatePhone xsi:type="xsd:string"></PhoneList:PersonPrivatePhone>
     <PhoneList:PersonFaxNumber xsi:type="xsd:string"></PhoneList:PersonFaxNumber>
     <PhoneList:PersonPagerNumber xsi:type="xsd:string"></PhoneList:PersonPagerNumber>
     <PhoneList:PersonEmail xsi:type="xsd:string"></PhoneList:PersonEmail>
     <PhoneList:Id xsi:type="xsd:int">0</PhoneList:Id>
     <PhoneList:Name xsi:type="xsd:string"></PhoneList:Name>
     <PhoneList:Tooltip xsi:type="xsd:string"></PhoneList:Tooltip>
     <PhoneList:UniqueId xsi:type="xsd:string"></PhoneList:UniqueId>
    </PhoneList:PhoneListItem>
   </PhoneList:Response>
  </PhoneList:GetFavoritesPhonesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

