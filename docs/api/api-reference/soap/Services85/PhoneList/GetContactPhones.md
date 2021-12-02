---
title: Services85.PhoneListAgent.GetContactPhones SOAP
generated: 1
uid: Services85-PhoneList-GetContactPhones
---

# Services85 PhoneList GetContactPhones

SOAP request and response examples **Remote/Services85/PhoneList.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IPhoneListAgent.GetContactPhones">SuperOffice.Services85.IPhoneListAgent.GetContactPhones</see> method.

## GetContactPhones

Returns an array of phone list items for all the persons belonging to a contact (company). The in-parameter must be a valid contact-id.

* **contactId:** The contact id

**Returns:** The contacts phone list.


[WSDL file for Services85/PhoneList](../Services85-PhoneList.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetContactPhones Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:PhoneList="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <PhoneList:ApplicationToken>1234567-1234-9876</PhoneList:ApplicationToken>
  <PhoneList:Credentials>
    <PhoneList:Ticket>7T:1234abcxyzExample==</PhoneList:Ticket>
  </PhoneList:Credentials>
 <SOAP-ENV:Body>
   <PhoneList:GetContactPhones>
    <PhoneList:ContactId xsi:type="xsd:int">0</PhoneList:ContactId>
   </PhoneList:GetContactPhones>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetContactPhones Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:PhoneList="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <PhoneList:GetContactPhonesResponse>
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
  </PhoneList:GetContactPhonesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

