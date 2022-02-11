---
title: Services87.PhoneListAgent.GetDepartmentPhones SOAP
generated: 1
uid: Services87-PhoneList-GetDepartmentPhones
---

# Services87 PhoneList GetDepartmentPhones

SOAP request and response examples **Remote/Services87/PhoneList.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IPhoneListAgent.GetDepartmentPhones">SuperOffice.Services87.IPhoneListAgent.GetDepartmentPhones</see> method.

## GetDepartmentPhones

Returns an array of phone list items with the in-parameter as restriction. The in-parameter must be a valid department id (UserGroupId).

* **departmentId:** The department to get the phone list for

**Returns:** The department phone list


[WSDL file for Services87/PhoneList](../Services87-PhoneList.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDepartmentPhones Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:PhoneList="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <PhoneList:ApplicationToken>1234567-1234-9876</PhoneList:ApplicationToken>
  <PhoneList:Credentials>
    <PhoneList:Ticket>7T:1234abcxyzExample==</PhoneList:Ticket>
  </PhoneList:Credentials>
 <SOAP-ENV:Body>
   <PhoneList:GetDepartmentPhones>
    <PhoneList:DepartmentId xsi:type="xsd:int">0</PhoneList:DepartmentId>
   </PhoneList:GetDepartmentPhones>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDepartmentPhones Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:PhoneList="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <PhoneList:GetDepartmentPhonesResponse>
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
  </PhoneList:GetDepartmentPhonesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

