---
title: Services88.AudienceAgent.GetMyAudienceLayout SOAP
generated: 1
uid: Services88-Audience-GetMyAudienceLayout
---

# Services88 Audience GetMyAudienceLayout

SOAP request and response examples **Remote/Services88/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAudienceAgent.GetMyAudienceLayout">SuperOffice.Services88.IAudienceAgent.GetMyAudienceLayout</see> method.

## GetMyAudienceLayout

Gets the Audience layout belonging to the currently logged on user.


**Returns:** Audience layout entity


[WSDL file for Services88/Audience](../Services88-Audience.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetMyAudienceLayout Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Audience:ApplicationToken>1234567-1234-9876</Audience:ApplicationToken>
  <Audience:Credentials>
    <Audience:Ticket>7T:1234abcxyzExample==</Audience:Ticket>
  </Audience:Credentials>
 <SOAP-ENV:Body>
   <Audience:GetMyAudienceLayout>
   </Audience:GetMyAudienceLayout>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetMyAudienceLayout Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Audience:GetMyAudienceLayoutResponse>
   <Audience:Response xsi:type="Audience:AudienceLayoutEntity">
    <Audience:AudienceLayoutId xsi:type="xsd:int">0</Audience:AudienceLayoutId>
    <Audience:InstanceLayout xsi:type="xsd:string"></Audience:InstanceLayout>
    <Audience:InstanceName xsi:type="xsd:string"></Audience:InstanceName>
    <Audience:CreatedDate xsi:type="xsd:dateTime">2021-11-30T13:23:32Z</Audience:CreatedDate>
    <Audience:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:23:32Z</Audience:UpdatedDate>
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
     <Audience:UserName xsi:type="xsd:string"></Audience:UserName>
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
     <Audience:UserName xsi:type="xsd:string"></Audience:UserName>
    </Audience:UpdatedBy>
   </Audience:Response>
  </Audience:GetMyAudienceLayoutResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

