---
title: Services85.AssociateAgent.GetAssociateByPersonId SOAP
generated: 1
uid: Services85-Associate-GetAssociateByPersonId
---

# Services85 Associate GetAssociateByPersonId

SOAP request and response examples **Remote/Services85/Associate.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IAssociateAgent.GetAssociateByPersonId">SuperOffice.Services85.IAssociateAgent.GetAssociateByPersonId</see> method.

## GetAssociateByPersonId

Returns the associate that belongs to this person if the person is an associate.

* **personId:** The person id

**Returns:** Associate if person is associate


[WSDL file for Services85/Associate](../Services85-Associate.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAssociateByPersonId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Associate="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Associate:ApplicationToken>1234567-1234-9876</Associate:ApplicationToken>
  <Associate:Credentials>
    <Associate:Ticket>7T:1234abcxyzExample==</Associate:Ticket>
  </Associate:Credentials>
 <SOAP-ENV:Body>
   <Associate:GetAssociateByPersonId>
    <Associate:PersonId xsi:type="xsd:int">0</Associate:PersonId>
   </Associate:GetAssociateByPersonId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAssociateByPersonId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Associate="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Associate:GetAssociateByPersonIdResponse>
   <Associate:Response xsi:type="Associate:Associate">
    <Associate:AssociateId xsi:type="xsd:int">0</Associate:AssociateId>
    <Associate:Name xsi:type="xsd:string"></Associate:Name>
    <Associate:PersonId xsi:type="xsd:int">0</Associate:PersonId>
    <Associate:Rank xsi:type="xsd:short">0</Associate:Rank>
    <Associate:Tooltip xsi:type="xsd:string"></Associate:Tooltip>
    <Associate:Type xsi:type="Associate:UserType">Unknown</Associate:Type>
    <Associate:GroupIdx xsi:type="xsd:int">0</Associate:GroupIdx>
    <Associate:FullName xsi:type="xsd:string"></Associate:FullName>
    <Associate:FormalName xsi:type="xsd:string"></Associate:FormalName>
    <Associate:Deleted xsi:type="xsd:boolean">false</Associate:Deleted>
    <Associate:EjUserId xsi:type="xsd:int">0</Associate:EjUserId>
   </Associate:Response>
  </Associate:GetAssociateByPersonIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

