---
title: Services85.ConfigurationAgent.SaveSystemEventEntity SOAP
generated: 1
uid: Services85-Configuration-SaveSystemEventEntity
---

# Services85 Configuration SaveSystemEventEntity

SOAP request and response examples **Remote/Services85/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IConfigurationAgent.SaveSystemEventEntity">SuperOffice.Services85.IConfigurationAgent.SaveSystemEventEntity</see> method.

## SaveSystemEventEntity

Updates the existing SystemEventEntity or creates a new SystemEventEntity if the id parameter is 0.

* **systemEventEntity:** The SystemEventEntity that is saved.

**Returns:** New or updated SystemEventEntity

[WSDL file for Services85/Configuration](../Services85-Configuration.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveSystemEventEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:SaveSystemEventEntity>
    <Configuration:SystemEventEntity xsi:type="Configuration:SystemEventEntity">
     <Configuration:SystemEventId xsi:type="xsd:int">0</Configuration:SystemEventId>
     <Configuration:Scope xsi:type="Configuration:SystemEventScope">Undefined</Configuration:Scope>
     <Configuration:Eta xsi:type="xsd:dateTime">2021-11-30T13:22:27Z</Configuration:Eta>
     <Configuration:Eventkey xsi:type="xsd:string"></Configuration:Eventkey>
     <Configuration:Eventmess xsi:type="xsd:string"></Configuration:Eventmess>
     <Configuration:ExtraInfo xsi:type="xsd:int">0</Configuration:ExtraInfo>
     <Configuration:Owner xsi:type="xsd:int">0</Configuration:Owner>
     <Configuration:UpdatedCount xsi:type="xsd:short">0</Configuration:UpdatedCount>
     <Configuration:Registered xsi:type="xsd:dateTime">2021-11-30T13:22:27Z</Configuration:Registered>
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
    </Configuration:SystemEventEntity>
   </Configuration:SaveSystemEventEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## SaveSystemEventEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Configuration:SaveSystemEventEntityResponse>
   <Configuration:Response xsi:type="Configuration:SystemEventEntity">
    <Configuration:SystemEventId xsi:type="xsd:int">0</Configuration:SystemEventId>
    <Configuration:Scope xsi:type="Configuration:SystemEventScope">Undefined</Configuration:Scope>
    <Configuration:Eta xsi:type="xsd:dateTime">2021-11-30T13:22:27Z</Configuration:Eta>
    <Configuration:Eventkey xsi:type="xsd:string"></Configuration:Eventkey>
    <Configuration:Eventmess xsi:type="xsd:string"></Configuration:Eventmess>
    <Configuration:ExtraInfo xsi:type="xsd:int">0</Configuration:ExtraInfo>
    <Configuration:Owner xsi:type="xsd:int">0</Configuration:Owner>
    <Configuration:UpdatedCount xsi:type="xsd:short">0</Configuration:UpdatedCount>
    <Configuration:Registered xsi:type="xsd:dateTime">2021-11-30T13:22:27Z</Configuration:Registered>
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
  </Configuration:SaveSystemEventEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
