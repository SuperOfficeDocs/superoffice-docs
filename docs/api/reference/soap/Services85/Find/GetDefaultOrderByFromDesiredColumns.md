---
title: Services85.FindAgent.GetDefaultOrderByFromDesiredColumns SOAP
generated: 1
uid: Services85-Find-GetDefaultOrderByFromDesiredColumns
---

# Services85 Find GetDefaultOrderByFromDesiredColumns

SOAP request and response examples **Remote/Services85/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IFindAgent.GetDefaultOrderByFromDesiredColumns">SuperOffice.Services85.IFindAgent.GetDefaultOrderByFromDesiredColumns</see> method.

## GetDefaultOrderByFromDesiredColumns

Calculate the default orderby columns for a given provider and a set of desired columns. This is the same algorithm that is used by the Find service method.

* **providerName:** Provider name to calculate default orderby for
* **desiredColumns:** Desired columns (return fields), used in the orderby calculation. You can generally only order by columns that have been set as 'desired'.

**Returns:** Orderby information


[WSDL file for Services85/Find](../Services85-Find.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultOrderByFromDesiredColumns Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Find:ApplicationToken>1234567-1234-9876</Find:ApplicationToken>
  <Find:Credentials>
    <Find:Ticket>7T:1234abcxyzExample==</Find:Ticket>
  </Find:Credentials>
 <SOAP-ENV:Body>
   <Find:GetDefaultOrderByFromDesiredColumns>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
    <Find:DesiredColumns xsi:type="NetServerServices852:ArrayOfstring">
     <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services85">
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

