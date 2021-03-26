---
uid: services85-blob-getblobentityonperson
title: Services85.BLOBAgent.GetBlobEntityOnPerson SOAP
Generated: true
---

# Services85 BLOB GetBlobEntityOnPerson SOAP

SOAP request and response examples **Remote/Services85/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IBLOBAgent.GetBlobEntityOnPerson">SuperOffice.Services85.IBLOBAgent.GetBlobEntityOnPerson</see> method.

## GetBlobEntityOnPerson

Gets the blob entity that represents the person image binary object.

* **personId:** The person id

**Returns:** BlobEntity object


[WSDL file for Services85/BLOB](../Services85-BLOB.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetBlobEntityOnPerson Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:GetBlobEntityOnPerson>
    <BLOB:PersonId xsi:type="xsd:int">0</BLOB:PersonId>
   </BLOB:GetBlobEntityOnPerson>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetBlobEntityOnPerson Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <BLOB:GetBlobEntityOnPersonResponse>
   <BLOB:Response xsi:type="BLOB:BlobEntity">
    <BLOB:BlobId xsi:type="xsd:int">0</BLOB:BlobId>
    <BLOB:BlobSize xsi:type="xsd:unsignedInt">0</BLOB:BlobSize>
    <BLOB:Description xsi:type="xsd:string"></BLOB:Description>
    <BLOB:ExtraInfo xsi:type="xsd:string"></BLOB:ExtraInfo>
    <BLOB:IsEncrypted xsi:type="xsd:boolean">false</BLOB:IsEncrypted>
    <BLOB:IsZipped xsi:type="xsd:boolean">false</BLOB:IsZipped>
    <BLOB:MimeType xsi:type="xsd:string"></BLOB:MimeType>
    <BLOB:OriginalSize xsi:type="xsd:unsignedInt">0</BLOB:OriginalSize>
    <BLOB:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:42Z</BLOB:CreatedDate>
    <BLOB:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:42Z</BLOB:UpdatedDate>
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
    </BLOB:UpdatedBy>
    <BLOB:ConceptualType xsi:type="xsd:string"></BLOB:ConceptualType>
   </BLOB:Response>
  </BLOB:GetBlobEntityOnPersonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

