---
uid: services84-audience-saveaudiencelayoutentity
title: Services84.AudienceAgent.SaveAudienceLayoutEntity SOAP
Generated: true
---

# Services84 Audience SaveAudienceLayoutEntity SOAP

SOAP request and response examples **Remote/Services84/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAudienceAgent.SaveAudienceLayoutEntity">SuperOffice.Services84.IAudienceAgent.SaveAudienceLayoutEntity</see> method.

## SaveAudienceLayoutEntity

Updates the existing AudienceLayoutEntity or creates a new AudienceLayoutEntity if the id parameter is 0.

* **audienceLayoutEntity:** The AudienceLayoutEntity that is saved.

**Returns:** New or updated AudienceLayoutEntity


[WSDL file for Services84/Audience](../Services84-Audience.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveAudienceLayoutEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Audience:ApplicationToken>1234567-1234-9876</Audience:ApplicationToken>
  <Audience:Credentials>
    <Audience:Ticket>7T:1234abcxyzExample==</Audience:Ticket>
  </Audience:Credentials>
 <SOAP-ENV:Body>
   <Audience:SaveAudienceLayoutEntity>
    <Audience:AudienceLayoutEntity xsi:type="Audience:AudienceLayoutEntity">
     <Audience:AudienceLayoutId xsi:type="xsd:int">0</Audience:AudienceLayoutId>
     <Audience:InstanceLayout xsi:type="xsd:string"></Audience:InstanceLayout>
     <Audience:InstanceName xsi:type="xsd:string"></Audience:InstanceName>
     <Audience:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:20Z</Audience:CreatedDate>
     <Audience:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:20Z</Audience:UpdatedDate>
     <Audience:CreatedBy xsi:type="Audience:Associate">
      <Audience:AssociateId xsi:type="xsd:int">0</Audience:AssociateId>
      <Audience:Name xsi:type="xsd:string"></Audience:Name>
      <Audience:PersonId xsi:type="xsd:int">0</Audience:PersonId>
      <Audience:Rank xsi:type="xsd:short">0</Audience:Rank>
      <Audience:Tooltip xsi:type="xsd:string"></Audience:Tooltip>
      <Audience:Type xsi:type="Audience:UserType">Unknown</Audience:Type>
      <Audience:GroupIdx xsi:type="xsd:int">0</Audience:GroupIdx>
      <Audience:FullName xsi:type="xsd:string"></Audience:FullName>
      <Audience:FormalName xsi:type="xsd:string"></Audience:FormalName>
      <Audience:Deleted xsi:type="xsd:boolean">false</Audience:Deleted>
      <Audience:EjUserId xsi:type="xsd:int">0</Audience:EjUserId>
     </Audience:CreatedBy>
     <Audience:UpdatedBy xsi:type="Audience:Associate">
      <Audience:AssociateId xsi:type="xsd:int">0</Audience:AssociateId>
      <Audience:Name xsi:type="xsd:string"></Audience:Name>
      <Audience:PersonId xsi:type="xsd:int">0</Audience:PersonId>
      <Audience:Rank xsi:type="xsd:short">0</Audience:Rank>
      <Audience:Tooltip xsi:type="xsd:string"></Audience:Tooltip>
      <Audience:Type xsi:type="Audience:UserType">Unknown</Audience:Type>
      <Audience:GroupIdx xsi:type="xsd:int">0</Audience:GroupIdx>
      <Audience:FullName xsi:type="xsd:string"></Audience:FullName>
      <Audience:FormalName xsi:type="xsd:string"></Audience:FormalName>
      <Audience:Deleted xsi:type="xsd:boolean">false</Audience:Deleted>
      <Audience:EjUserId xsi:type="xsd:int">0</Audience:EjUserId>
     </Audience:UpdatedBy>
    </Audience:AudienceLayoutEntity>
   </Audience:SaveAudienceLayoutEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveAudienceLayoutEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Audience:SaveAudienceLayoutEntityResponse>
   <Audience:Response xsi:type="Audience:AudienceLayoutEntity">
    <Audience:AudienceLayoutId xsi:type="xsd:int">0</Audience:AudienceLayoutId>
    <Audience:InstanceLayout xsi:type="xsd:string"></Audience:InstanceLayout>
    <Audience:InstanceName xsi:type="xsd:string"></Audience:InstanceName>
    <Audience:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:20Z</Audience:CreatedDate>
    <Audience:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:20Z</Audience:UpdatedDate>
    <Audience:CreatedBy xsi:type="Audience:Associate">
     <Audience:AssociateId xsi:type="xsd:int">0</Audience:AssociateId>
     <Audience:Name xsi:type="xsd:string"></Audience:Name>
     <Audience:PersonId xsi:type="xsd:int">0</Audience:PersonId>
     <Audience:Rank xsi:type="xsd:short">0</Audience:Rank>
     <Audience:Tooltip xsi:type="xsd:string"></Audience:Tooltip>
     <Audience:Type xsi:type="Audience:UserType">Unknown</Audience:Type>
     <Audience:GroupIdx xsi:type="xsd:int">0</Audience:GroupIdx>
     <Audience:FullName xsi:type="xsd:string"></Audience:FullName>
     <Audience:FormalName xsi:type="xsd:string"></Audience:FormalName>
     <Audience:Deleted xsi:type="xsd:boolean">false</Audience:Deleted>
     <Audience:EjUserId xsi:type="xsd:int">0</Audience:EjUserId>
    </Audience:CreatedBy>
    <Audience:UpdatedBy xsi:type="Audience:Associate">
     <Audience:AssociateId xsi:type="xsd:int">0</Audience:AssociateId>
     <Audience:Name xsi:type="xsd:string"></Audience:Name>
     <Audience:PersonId xsi:type="xsd:int">0</Audience:PersonId>
     <Audience:Rank xsi:type="xsd:short">0</Audience:Rank>
     <Audience:Tooltip xsi:type="xsd:string"></Audience:Tooltip>
     <Audience:Type xsi:type="Audience:UserType">Unknown</Audience:Type>
     <Audience:GroupIdx xsi:type="xsd:int">0</Audience:GroupIdx>
     <Audience:FullName xsi:type="xsd:string"></Audience:FullName>
     <Audience:FormalName xsi:type="xsd:string"></Audience:FormalName>
     <Audience:Deleted xsi:type="xsd:boolean">false</Audience:Deleted>
     <Audience:EjUserId xsi:type="xsd:int">0</Audience:EjUserId>
    </Audience:UpdatedBy>
   </Audience:Response>
  </Audience:SaveAudienceLayoutEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

