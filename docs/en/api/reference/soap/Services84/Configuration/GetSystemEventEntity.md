---
title: Services84.ConfigurationAgent.GetSystemEventEntity SOAP
generated: 1
uid: Services84-Configuration-GetSystemEventEntity
---

# Services84 Configuration GetSystemEventEntity

SOAP request and response examples **Remote/Services84/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IConfigurationAgent.GetSystemEventEntity">SuperOffice.Services84.IConfigurationAgent.GetSystemEventEntity</see> method.

## GetSystemEventEntity

Gets a SystemEventEntity object.

* **systemEventEntityId:** The identifier of the SystemEventEntity object

**Returns:** SystemEventEntity

[WSDL file for Services84/Configuration](../Services84-Configuration.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSystemEventEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:GetSystemEventEntity>
    <Configuration:SystemEventEntityId xsi:type="xsd:int">0</Configuration:SystemEventEntityId>
   </Configuration:GetSystemEventEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetSystemEventEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Configuration:GetSystemEventEntityResponse>
   <Configuration:Response xsi:type="Configuration:SystemEventEntity">
    <Configuration:SystemEventId xsi:type="xsd:int">0</Configuration:SystemEventId>
    <Configuration:Scope xsi:type="Configuration:SystemEventScope">Undefined</Configuration:Scope>
    <Configuration:Eta xsi:type="xsd:dateTime">2022-08-26T08:50:30Z</Configuration:Eta>
    <Configuration:Eventkey xsi:type="xsd:string"></Configuration:Eventkey>
    <Configuration:Eventmess xsi:type="xsd:string"></Configuration:Eventmess>
    <Configuration:ExtraInfo xsi:type="xsd:int">0</Configuration:ExtraInfo>
    <Configuration:Owner xsi:type="xsd:int">0</Configuration:Owner>
    <Configuration:UpdatedCount xsi:type="xsd:short">0</Configuration:UpdatedCount>
    <Configuration:Registered xsi:type="xsd:dateTime">2022-08-26T08:50:30Z</Configuration:Registered>
    <Configuration:ActivatedBy xsi:type="Configuration:Associate">
     <Configuration:AssociateId xsi:type="xsd:int">0</Configuration:AssociateId>
     <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
     <Configuration:PersonId xsi:type="xsd:int">0</Configuration:PersonId>
     <Configuration:Rank xsi:type="xsd:short">0</Configuration:Rank>
     <Configuration:Tooltip xsi:type="xsd:string"></Configuration:Tooltip>
     <Configuration:Type xsi:type="Configuration:UserType">Unknown</Configuration:Type>
     <Configuration:GroupIdx xsi:type="xsd:int">0</Configuration:GroupIdx>
     <Configuration:FullName xsi:type="xsd:string"></Configuration:FullName>
     <Configuration:FormalName xsi:type="xsd:string"></Configuration:FormalName>
     <Configuration:Deleted xsi:type="xsd:boolean">false</Configuration:Deleted>
     <Configuration:EjUserId xsi:type="xsd:int">0</Configuration:EjUserId>
    </Configuration:ActivatedBy>
   </Configuration:Response>
  </Configuration:GetSystemEventEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
