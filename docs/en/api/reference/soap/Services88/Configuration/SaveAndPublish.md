---
title: Services88.ConfigurationAgent.SaveAndPublish SOAP
generated: true
uid: Services88-Configuration-SaveAndPublish
---

# Services88 Configuration SaveAndPublish

SOAP request and response examples **Remote/Services88/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IConfigurationAgent.SaveAndPublish">SuperOffice.Services88.IConfigurationAgent.SaveAndPublish</see> method.

## SaveAndPublish





[WSDL file for Services88/Configuration](../Services88-Configuration.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveAndPublish Request

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
   <Configuration:SaveAndPublish>
    <Configuration:ConfigurableScreenDelta xsi:type="Configuration:ConfigurableScreenDelta">
     <Configuration:ConfigurableScreenDeltaId xsi:type="xsd:int">0</Configuration:ConfigurableScreenDeltaId>
     <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
     <Configuration:Description xsi:type="xsd:string"></Configuration:Description>
     <Configuration:DeltaJson xsi:type="xsd:string"></Configuration:DeltaJson>
     <Configuration:DeltaType xsi:type="Configuration:DeltaType">Unknown</Configuration:DeltaType>
     <Configuration:DeltaState xsi:type="Configuration:DeltaState">Unknown</Configuration:DeltaState>
     <Configuration:RecipeId xsi:type="xsd:string"></Configuration:RecipeId>
     <Configuration:UpdatedDate xsi:type="xsd:dateTime">2023-11-10T12:36:05Z</Configuration:UpdatedDate>
     <Configuration:CreatedDate xsi:type="xsd:dateTime">2023-11-10T12:36:05Z</Configuration:CreatedDate>
     <Configuration:UpdatedBy xsi:type="Configuration:Associate">
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
     </Configuration:UpdatedBy>
     <Configuration:CreatedBy xsi:type="Configuration:Associate">
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
     </Configuration:CreatedBy>
     <Configuration:AppliesToIds xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </Configuration:AppliesToIds>
     <Configuration:AppliesToKey xsi:type="xsd:string"></Configuration:AppliesToKey>
    </Configuration:ConfigurableScreenDelta>
   </Configuration:SaveAndPublish>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveAndPublish Response

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
  <Configuration:SaveAndPublishResponse>
   <Configuration:Response xsi:type="Configuration:ConfigurableScreenDelta">
    <Configuration:ConfigurableScreenDeltaId xsi:type="xsd:int">0</Configuration:ConfigurableScreenDeltaId>
    <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
    <Configuration:Description xsi:type="xsd:string"></Configuration:Description>
    <Configuration:DeltaJson xsi:type="xsd:string"></Configuration:DeltaJson>
    <Configuration:DeltaType xsi:type="Configuration:DeltaType">Unknown</Configuration:DeltaType>
    <Configuration:DeltaState xsi:type="Configuration:DeltaState">Unknown</Configuration:DeltaState>
    <Configuration:RecipeId xsi:type="xsd:string"></Configuration:RecipeId>
    <Configuration:UpdatedDate xsi:type="xsd:dateTime">2023-11-10T12:36:05Z</Configuration:UpdatedDate>
    <Configuration:CreatedDate xsi:type="xsd:dateTime">2023-11-10T12:36:05Z</Configuration:CreatedDate>
    <Configuration:UpdatedBy xsi:type="Configuration:Associate">
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
    </Configuration:UpdatedBy>
    <Configuration:CreatedBy xsi:type="Configuration:Associate">
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
    </Configuration:CreatedBy>
    <Configuration:AppliesToIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Configuration:AppliesToIds>
    <Configuration:AppliesToKey xsi:type="xsd:string"></Configuration:AppliesToKey>
   </Configuration:Response>
  </Configuration:SaveAndPublishResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

