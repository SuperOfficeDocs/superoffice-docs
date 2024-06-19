---
title: Services87.ContactAgent.GetMyActiveContacts SOAP
generated: 1
uid: Services87-Contact-GetMyActiveContacts
---

# Services87 Contact GetMyActiveContacts

SOAP request and response examples **Remote/Services87/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IContactAgent.GetMyActiveContacts">SuperOffice.Services87.IContactAgent.GetMyActiveContacts</see> method.

## GetMyActiveContacts

[WSDL file for Services87/Contact](../Services87-Contact.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetMyActiveContacts Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetMyActiveContacts>
    <Contact:ActivityStartTime xsi:type="xsd:dateTime">2023-03-31T13:24:59Z</Contact:ActivityStartTime>
    <Contact:ContactCategories xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
    </Contact:ContactCategories>
    <Contact:ActionType xsi:type="Contact:ContactAction">Created</Contact:ActionType>
   </Contact:GetMyActiveContacts>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetMyActiveContacts Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Contact:GetMyActiveContactsResponse>
   <Contact:Response xsi:type="Contact:ArrayOfContactActivity">
    <Contact:ContactActivity xsi:type="Contact:ContactActivity">
     <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
     <Contact:Department xsi:type="xsd:string"></Contact:Department>
     <Contact:OrgNr xsi:type="xsd:string"></Contact:OrgNr>
     <Contact:Name xsi:type="xsd:string"></Contact:Name>
     <Contact:URL xsi:type="xsd:string"></Contact:URL>
     <Contact:AssociateFullName xsi:type="xsd:string"></Contact:AssociateFullName>
     <Contact:Action xsi:type="Contact:ContactAction">Created</Contact:Action>
     <Contact:ActionTime xsi:type="xsd:dateTime">2023-03-31T13:24:59Z</Contact:ActionTime>
     <Contact:Category xsi:type="xsd:string"></Contact:Category>
     <Contact:ActivityPersonName xsi:type="xsd:string"></Contact:ActivityPersonName>
     <Contact:ActionId xsi:type="xsd:int">0</Contact:ActionId>
     <Contact:PersonId xsi:type="xsd:int">0</Contact:PersonId>
     <Contact:ActivityPersonId xsi:type="xsd:int">0</Contact:ActivityPersonId>
     <Contact:AssociateId xsi:type="xsd:int">0</Contact:AssociateId>
    </Contact:ContactActivity>
   </Contact:Response>
  </Contact:GetMyActiveContactsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
