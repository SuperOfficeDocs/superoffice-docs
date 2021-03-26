---
uid: services75-find-getdefaultorderbyfromdesiredcolumns
title: Services75.FindAgent.GetDefaultOrderByFromDesiredColumns SOAP
Generated: true
---

# Services75 Find GetDefaultOrderByFromDesiredColumns SOAP

SOAP request and response examples **Remote/Services75/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IFindAgent.GetDefaultOrderByFromDesiredColumns">SuperOffice.Services75.IFindAgent.GetDefaultOrderByFromDesiredColumns</see> method.

## GetDefaultOrderByFromDesiredColumns

Calculate the default orderby columns for a given provider and a set of desired columns. This is the same algorithm that is used by the Find service method.

* **providerName:** Provider name to calculate default orderby for
* **desiredColumns:** Desired columns (return fields), used in the orderby calculation. You can generally only order by columns that have been set as 'desired'.

**Returns:** Orderby information


[WSDL file for Services75/Find](../Services75-Find.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultOrderByFromDesiredColumns Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Find:ApplicationToken>1234567-1234-9876</Find:ApplicationToken>
  <Find:Credentials>
    <Find:Ticket>7T:1234abcxyzExample==</Find:Ticket>
  </Find:Credentials>
 <SOAP-ENV:Body>
   <Find:GetDefaultOrderByFromDesiredColumns>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
    <Find:DesiredColumns xsi:type="NetServerServices752:ArrayOfstring">
     <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
    </Find:DesiredColumns>
   </Find:GetDefaultOrderByFromDesiredColumns>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDefaultOrderByFromDesiredColumns Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Find:GetDefaultOrderByFromDesiredColumnsResponse>
   <Find:Response xsi:type="Find:ArrayOfArchiveOrderByInfo">
    <Find:ArchiveOrderByInfo xsi:type="Find:ArchiveOrderByInfo">
     <Find:Name xsi:type="xsd:string"></Find:Name>
     <Find:Direction xsi:type="Find:OrderBySortType">ASC</Find:Direction>
    </Find:ArchiveOrderByInfo>
   </Find:Response>
  </Find:GetDefaultOrderByFromDesiredColumnsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

