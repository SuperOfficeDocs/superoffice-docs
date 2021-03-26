---
uid: services86-email-findcontactorpersonbyemailname
title: Services86.EMailAgent.FindContactOrPersonByEmailName SOAP
Generated: true
---

# Services86 EMail FindContactOrPersonByEmailName SOAP

SOAP request and response examples **Remote/Services86/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IEMailAgent.FindContactOrPersonByEmailName">SuperOffice.Services86.IEMailAgent.FindContactOrPersonByEmailName</see> method.

## FindContactOrPersonByEmailName

<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **name:** The sender name
* **emailAddress:** The sender email address

**Returns:** Contacts and persons matching emailaddress and name


[WSDL file for Services86/EMail](../Services86-EMail.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindContactOrPersonByEmailName Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:FindContactOrPersonByEmailName>
    <EMail:Name xsi:type="xsd:string"></EMail:Name>
    <EMail:EmailAddress xsi:type="xsd:string"></EMail:EmailAddress>
   </EMail:FindContactOrPersonByEmailName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindContactOrPersonByEmailName Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <EMail:FindContactOrPersonByEmailNameResponse>
   <EMail:Response xsi:type="EMail:ArrayOfContactOrPersonFromEmail">
    <EMail:ContactOrPersonFromEmail xsi:type="EMail:ContactOrPersonFromEmail">
     <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
     <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
     <EMail:EmailAddress xsi:type="xsd:string"></EMail:EmailAddress>
     <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
     <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
     <EMail:ContactDepartment xsi:type="xsd:string"></EMail:ContactDepartment>
     <EMail:SortName xsi:type="xsd:string"></EMail:SortName>
    </EMail:ContactOrPersonFromEmail>
   </EMail:Response>
  </EMail:FindContactOrPersonByEmailNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

