---
title: Services86.ContactAgent.GetMyActiveContacts SOAP
generated: 1
uid: Services86-Contact-GetMyActiveContacts
---

# Services86 Contact GetMyActiveContacts

SOAP request and response examples **Remote/Services86/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IContactAgent.GetMyActiveContacts">SuperOffice.Services86.IContactAgent.GetMyActiveContacts</see> method.

## GetMyActiveContacts

Returns the contacts where there has been activity since activityStartTime. If activityStartTime is larger than the current date, all contacts with activity since last log-out are returned. The result set can be filtered by category and action type.

* **activityStartTime:** The start time of the activities. If the start time is set to a future date; activites since the user last logged out are returned.
* **contactCategories:** Integer array of categories to filter on. If the array is empty contacts from all categories will be selected.
* **actionType:** The type of action that has occured. E.g. updates, deletes, new appointments, etc.

**Returns:** Array of contacts where there have been activity in the period.

[WSDL file for Services86/Contact](../Services86-Contact.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetMyActiveContacts Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetMyActiveContacts>
    <Contact:ActivityStartTime xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:ActivityStartTime>
    <Contact:ContactCategories xsi:type="NetServerServices862:ArrayOfint">
     <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
     <Contact:ActionTime xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:ActionTime>
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
