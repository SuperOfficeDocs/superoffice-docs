---
title: Services88.BLOBAgent.CreateDefaultBlobEntity SOAP
generated: 1
uid: Services88-BLOB-CreateDefaultBlobEntity
---

# Services88 BLOB CreateDefaultBlobEntity

SOAP request and response examples **Remote/Services88/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IBLOBAgent.CreateDefaultBlobEntity">SuperOffice.Services88.IBLOBAgent.CreateDefaultBlobEntity</see> method.

## CreateDefaultBlobEntity

Loading default values into a new BlobEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance

**Returns:** New BlobEntity with default values

[WSDL file for Services88/BLOB](../Services88-BLOB.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultBlobEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:CreateDefaultBlobEntity>
   </BLOB:CreateDefaultBlobEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## CreateDefaultBlobEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <BLOB:CreateDefaultBlobEntityResponse>
   <BLOB:Response xsi:type="BLOB:BlobEntity">
    <BLOB:BlobId xsi:type="xsd:int">0</BLOB:BlobId>
    <BLOB:BlobSize xsi:type="xsd:unsignedInt">0</BLOB:BlobSize>
    <BLOB:Description xsi:type="xsd:string"></BLOB:Description>
    <BLOB:ExtraInfo xsi:type="xsd:string"></BLOB:ExtraInfo>
    <BLOB:IsEncrypted xsi:type="xsd:boolean">false</BLOB:IsEncrypted>
    <BLOB:IsZipped xsi:type="xsd:boolean">false</BLOB:IsZipped>
    <BLOB:MimeType xsi:type="xsd:string"></BLOB:MimeType>
    <BLOB:OriginalSize xsi:type="xsd:unsignedInt">0</BLOB:OriginalSize>
    <BLOB:CreatedDate xsi:type="xsd:dateTime">2022-08-26T08:58:31Z</BLOB:CreatedDate>
    <BLOB:UpdatedDate xsi:type="xsd:dateTime">2022-08-26T08:58:31Z</BLOB:UpdatedDate>
    <BLOB:CreatedBy xsi:type="BLOB:Associate">
     <BLOB:AssociateId xsi:type="xsd:int">0</BLOB:AssociateId>
     <BLOB:Name xsi:type="xsd:string"></BLOB:Name>
     <BLOB:PersonId xsi:type="xsd:int">0</BLOB:PersonId>
     <BLOB:Rank xsi:type="xsd:short">0</BLOB:Rank>
     <BLOB:Tooltip xsi:type="xsd:string"></BLOB:Tooltip>
     <BLOB:Type xsi:type="BLOB:UserType">Unknown</BLOB:Type>
     <BLOB:GroupIdx xsi:type="xsd:int">0</BLOB:GroupIdx>
     <BLOB:FullName xsi:type="xsd:string"></BLOB:FullName>
     <BLOB:FormalName xsi:type="xsd:string"></BLOB:FormalName>
     <BLOB:Deleted xsi:type="xsd:boolean">false</BLOB:Deleted>
     <BLOB:EjUserId xsi:type="xsd:int">0</BLOB:EjUserId>
     <BLOB:UserName xsi:type="xsd:string"></BLOB:UserName>
    </BLOB:CreatedBy>
    <BLOB:UpdatedBy xsi:type="BLOB:Associate">
     <BLOB:AssociateId xsi:type="xsd:int">0</BLOB:AssociateId>
     <BLOB:Name xsi:type="xsd:string"></BLOB:Name>
     <BLOB:PersonId xsi:type="xsd:int">0</BLOB:PersonId>
     <BLOB:Rank xsi:type="xsd:short">0</BLOB:Rank>
     <BLOB:Tooltip xsi:type="xsd:string"></BLOB:Tooltip>
     <BLOB:Type xsi:type="BLOB:UserType">Unknown</BLOB:Type>
     <BLOB:GroupIdx xsi:type="xsd:int">0</BLOB:GroupIdx>
     <BLOB:FullName xsi:type="xsd:string"></BLOB:FullName>
     <BLOB:FormalName xsi:type="xsd:string"></BLOB:FormalName>
     <BLOB:Deleted xsi:type="xsd:boolean">false</BLOB:Deleted>
     <BLOB:EjUserId xsi:type="xsd:int">0</BLOB:EjUserId>
     <BLOB:UserName xsi:type="xsd:string"></BLOB:UserName>
    </BLOB:UpdatedBy>
    <BLOB:ConceptualType xsi:type="xsd:string"></BLOB:ConceptualType>
   </BLOB:Response>
  </BLOB:CreateDefaultBlobEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
