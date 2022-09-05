---
title: Services84.AssociateAgent.GetAssociate SOAP
generated: 1
uid: Services84-Associate-GetAssociate
---

# Services84 Associate GetAssociate

SOAP request and response examples **Remote/Services84/Associate.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAssociateAgent.GetAssociate">SuperOffice.Services84.IAssociateAgent.GetAssociate</see> method.

## GetAssociate

Gets a Associate object.

* **associateId:** The identifier of the Associate object

**Returns:** Associate


[WSDL file for Services84/Associate](../Services84-Associate.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAssociate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Associate="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Associate:ApplicationToken>1234567-1234-9876</Associate:ApplicationToken>
  <Associate:Credentials>
    <Associate:Ticket>7T:1234abcxyzExample==</Associate:Ticket>
  </Associate:Credentials>
 <SOAP-ENV:Body>
   <Associate:GetAssociate>
    <Associate:AssociateId xsi:type="xsd:int">0</Associate:AssociateId>
   </Associate:GetAssociate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAssociate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Associate="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Associate:GetAssociateResponse>
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
  </Associate:GetAssociateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

