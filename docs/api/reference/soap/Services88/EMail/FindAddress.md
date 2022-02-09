---
title: Services88.EMailAgent.FindAddress SOAP
generated: 1
uid: Services88-EMail-FindAddress
---

# Services88 EMail FindAddress

SOAP request and response examples **Remote/Services88/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IEMailAgent.FindAddress">SuperOffice.Services88.IEMailAgent.FindAddress</see> method.

## FindAddress

Search for contacts and persons with the specified e-mail address (exact match on the email address string required)
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **address:** E-mail address to look for

**Returns:** All resolved contacts/persons


[WSDL file for Services88/EMail](../Services88-EMail.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindAddress Request

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
   <EMail:FindAddress>
    <EMail:Address xsi:type="xsd:string"></EMail:Address>
   </EMail:FindAddress>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindAddress Response

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
  <EMail:FindAddressResponse>
   <EMail:Response xsi:type="EMail:ArrayOfEMailAddress">
    <EMail:EMailAddress xsi:type="EMail:EMailAddress">
     <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
     <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
     <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
     <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
     <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
     <EMail:Address xsi:type="xsd:string"></EMail:Address>
     <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
     <EMail:DuplicatePersonIds xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </EMail:DuplicatePersonIds>
     <EMail:Name xsi:type="xsd:string"></EMail:Name>
    </EMail:EMailAddress>
   </EMail:Response>
  </EMail:FindAddressResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

