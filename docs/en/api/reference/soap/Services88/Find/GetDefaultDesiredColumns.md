---
title: Services88.FindAgent.GetDefaultDesiredColumns SOAP
generated: true
uid: Services88-Find-GetDefaultDesiredColumns
content_type: reference
---

# Services88 Find GetDefaultDesiredColumns

SOAP request and response examples **Remote/Services88/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFindAgent.GetDefaultDesiredColumns">SuperOffice.Services88.IFindAgent.GetDefaultDesiredColumns</see> method.

## GetDefaultDesiredColumns





[WSDL file for Services88/Find](../Services88-Find.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultDesiredColumns Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Find:ApplicationToken>1234567-1234-9876</Find:ApplicationToken>
  <Find:Credentials>
    <Find:Ticket>7T:1234abcxyzExample==</Find:Ticket>
  </Find:Credentials>
 <SOAP-ENV:Body>
   <Find:GetDefaultDesiredColumns>
    <Find:StorageType xsi:type="xsd:string"></Find:StorageType>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
    <Find:StorageKey xsi:type="xsd:string"></Find:StorageKey>
   </Find:GetDefaultDesiredColumns>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDefaultDesiredColumns Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Find:GetDefaultDesiredColumnsResponse>
   <Find:Response xsi:type="Find:ArrayOfArchiveColumnInfo">
    <Find:ArchiveColumnInfo xsi:type="Find:ArchiveColumnInfo">
     <Find:DisplayName xsi:type="xsd:string"></Find:DisplayName>
     <Find:DisplayTooltip xsi:type="xsd:string"></Find:DisplayTooltip>
     <Find:DisplayType xsi:type="xsd:string"></Find:DisplayType>
     <Find:CanOrderBy xsi:type="xsd:boolean">false</Find:CanOrderBy>
     <Find:Name xsi:type="xsd:string"></Find:Name>
     <Find:CanRestrictBy xsi:type="xsd:boolean">false</Find:CanRestrictBy>
     <Find:RestrictionType xsi:type="xsd:string"></Find:RestrictionType>
     <Find:RestrictionListName xsi:type="xsd:string"></Find:RestrictionListName>
     <Find:IsVisible xsi:type="xsd:boolean">false</Find:IsVisible>
     <Find:Width xsi:type="xsd:string"></Find:Width>
     <Find:IconHint xsi:type="xsd:string"></Find:IconHint>
     <Find:HeadingIconHint xsi:type="xsd:string"></Find:HeadingIconHint>
     <Find:ExtraInfo xsi:type="xsd:string"></Find:ExtraInfo>
    </Find:ArchiveColumnInfo>
   </Find:Response>
  </Find:GetDefaultDesiredColumnsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

