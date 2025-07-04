---
title: Services88.ConfigurationAgent.SaveSystemEventEntity SOAP
generated: true
uid: Services88-Configuration-SaveSystemEventEntity
---

# Services88 Configuration SaveSystemEventEntity

SOAP request and response examples **Remote/Services88/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IConfigurationAgent.SaveSystemEventEntity">SuperOffice.Services88.IConfigurationAgent.SaveSystemEventEntity</see> method.

## SaveSystemEventEntity





[WSDL file for Services88/Configuration](../Services88-Configuration.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveSystemEventEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:SaveSystemEventEntity>
    <Configuration:SystemEventEntity xsi:type="Configuration:SystemEventEntity">
     <Configuration:SystemEventId xsi:type="xsd:int">0</Configuration:SystemEventId>
     <Configuration:Scope xsi:type="Configuration:SystemEventScope">Undefined</Configuration:Scope>
     <Configuration:Eta xsi:type="xsd:dateTime">2025-06-26T01:43:08Z</Configuration:Eta>
     <Configuration:Eventkey xsi:type="xsd:string"></Configuration:Eventkey>
     <Configuration:Eventmess xsi:type="xsd:string"></Configuration:Eventmess>
     <Configuration:ExtraInfo xsi:type="xsd:int">0</Configuration:ExtraInfo>
     <Configuration:Owner xsi:type="xsd:int">0</Configuration:Owner>
     <Configuration:UpdatedCount xsi:type="xsd:short">0</Configuration:UpdatedCount>
     <Configuration:Registered xsi:type="xsd:dateTime">2025-06-26T01:43:08Z</Configuration:Registered>
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
      <Configuration:UserName xsi:type="xsd:string"></Configuration:UserName>
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Configuration:SaveSystemEventEntityResponse>
   <Configuration:Response xsi:type="Configuration:SystemEventEntity">
    <Configuration:SystemEventId xsi:type="xsd:int">0</Configuration:SystemEventId>
    <Configuration:Scope xsi:type="Configuration:SystemEventScope">Undefined</Configuration:Scope>
    <Configuration:Eta xsi:type="xsd:dateTime">2025-06-26T01:43:08Z</Configuration:Eta>
    <Configuration:Eventkey xsi:type="xsd:string"></Configuration:Eventkey>
    <Configuration:Eventmess xsi:type="xsd:string"></Configuration:Eventmess>
    <Configuration:ExtraInfo xsi:type="xsd:int">0</Configuration:ExtraInfo>
    <Configuration:Owner xsi:type="xsd:int">0</Configuration:Owner>
    <Configuration:UpdatedCount xsi:type="xsd:short">0</Configuration:UpdatedCount>
    <Configuration:Registered xsi:type="xsd:dateTime">2025-06-26T01:43:08Z</Configuration:Registered>
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
     <Configuration:UserName xsi:type="xsd:string"></Configuration:UserName>
    </Configuration:ActivatedBy>
   </Configuration:Response>
  </Configuration:SaveSystemEventEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

