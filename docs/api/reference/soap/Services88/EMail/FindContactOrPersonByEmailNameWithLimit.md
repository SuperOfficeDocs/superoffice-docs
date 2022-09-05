---
title: Services88.EMailAgent.FindContactOrPersonByEmailNameWithLimit SOAP
generated: 1
uid: Services88-EMail-FindContactOrPersonByEmailNameWithLimit
---

# Services88 EMail FindContactOrPersonByEmailNameWithLimit

SOAP request and response examples **Remote/Services88/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IEMailAgent.FindContactOrPersonByEmailNameWithLimit">SuperOffice.Services88.IEMailAgent.FindContactOrPersonByEmailNameWithLimit</see> method.

## FindContactOrPersonByEmailNameWithLimit

<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **name:** The sender name
* **emailAddress:** The sender email address
* **numberOfContacts:** Maximum returned number of contacts
* **numberOfPersons:** Maximum returned number of persons

**Returns:** Contacts and persons matching emailaddress and name


[WSDL file for Services88/EMail](../Services88-EMail.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindContactOrPersonByEmailNameWithLimit Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:FindContactOrPersonByEmailNameWithLimit>
    <EMail:Name xsi:type="xsd:string"></EMail:Name>
    <EMail:EmailAddress xsi:type="xsd:string"></EMail:EmailAddress>
    <EMail:NumberOfContacts xsi:type="xsd:int">0</EMail:NumberOfContacts>
    <EMail:NumberOfPersons xsi:type="xsd:int">0</EMail:NumberOfPersons>
   </EMail:FindContactOrPersonByEmailNameWithLimit>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindContactOrPersonByEmailNameWithLimit Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <EMail:FindContactOrPersonByEmailNameWithLimitResponse>
   <EMail:Response xsi:type="EMail:ArrayOfContactOrPersonFromEmail">
    <EMail:ContactOrPersonFromEmail xsi:type="EMail:ContactOrPersonFromEmail">
     <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
     <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
     <EMail:EmailAddress xsi:type="xsd:string"></EMail:EmailAddress>
     <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
     <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
     <EMail:ContactDepartment xsi:type="xsd:string"></EMail:ContactDepartment>
     <EMail:ContactCategory xsi:type="xsd:string"></EMail:ContactCategory>
     <EMail:SortName xsi:type="xsd:string"></EMail:SortName>
    </EMail:ContactOrPersonFromEmail>
   </EMail:Response>
  </EMail:FindContactOrPersonByEmailNameWithLimitResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

