---
uid: services87-archive-getavailablecolumns
title: Services87.ArchiveAgent.GetAvailableColumns SOAP
Generated: true
---

# Services87 Archive GetAvailableColumns SOAP

SOAP request and response examples **Remote/Services87/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IArchiveAgent.GetAvailableColumns">SuperOffice.Services87.IArchiveAgent.GetAvailableColumns</see> method.

## GetAvailableColumns

Return list of all columns supported by an archive provider. See also GetArchiveConfiguration.

* **providerName:** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
* **context:** Optional context parameter, url-encoded string context parameter for ArchiveProvider constructor

**Returns:** Array of all columns supported by the archive provider.


[WSDL file for Services87/Archive](../Services87-Archive.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAvailableColumns Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:GetAvailableColumns>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:Context xsi:type="xsd:string"></Archive:Context>
   </Archive:GetAvailableColumns>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAvailableColumns Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Archive:GetAvailableColumnsResponse>
   <Archive:Response xsi:type="Archive:ArrayOfArchiveColumnInfo">
    <Archive:ArchiveColumnInfo xsi:type="Archive:ArchiveColumnInfo">
     <Archive:DisplayName xsi:type="xsd:string"></Archive:DisplayName>
     <Archive:DisplayTooltip xsi:type="xsd:string"></Archive:DisplayTooltip>
     <Archive:DisplayType xsi:type="xsd:string"></Archive:DisplayType>
     <Archive:CanOrderBy xsi:type="xsd:boolean">false</Archive:CanOrderBy>
     <Archive:Name xsi:type="xsd:string"></Archive:Name>
     <Archive:CanRestrictBy xsi:type="xsd:boolean">false</Archive:CanRestrictBy>
     <Archive:RestrictionType xsi:type="xsd:string"></Archive:RestrictionType>
     <Archive:RestrictionListName xsi:type="xsd:string"></Archive:RestrictionListName>
     <Archive:IsVisible xsi:type="xsd:boolean">false</Archive:IsVisible>
     <Archive:Width xsi:type="xsd:string"></Archive:Width>
     <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
     <Archive:HeadingIconHint xsi:type="xsd:string"></Archive:HeadingIconHint>
    </Archive:ArchiveColumnInfo>
   </Archive:Response>
  </Archive:GetAvailableColumnsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

