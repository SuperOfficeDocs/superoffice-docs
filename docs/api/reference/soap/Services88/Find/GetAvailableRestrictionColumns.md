---
title: Services88.FindAgent.GetAvailableRestrictionColumns SOAP
generated: 1
uid: Services88-Find-GetAvailableRestrictionColumns
---

# Services88 Find GetAvailableRestrictionColumns

SOAP request and response examples **Remote/Services88/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFindAgent.GetAvailableRestrictionColumns">SuperOffice.Services88.IFindAgent.GetAvailableRestrictionColumns</see> method.

## GetAvailableRestrictionColumns

Get a list of the column names corresponding to available restrictions for a certain archive provider and restriction storage provider. Such columns have CanRestrict set to true, and are supported by the given restriction storage provider.

* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is to execute the search and return the result columns/rows

**Returns:** Array of column names, corresponding to support restrictions for the given archive and restriction storage providers.


[WSDL file for Services88/Find](../Services88-Find.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAvailableRestrictionColumns Request

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
   <Find:GetAvailableRestrictionColumns>
    <Find:StorageType xsi:type="xsd:string"></Find:StorageType>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
   </Find:GetAvailableRestrictionColumns>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAvailableRestrictionColumns Response

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
  <Find:GetAvailableRestrictionColumnsResponse>
   <Find:Response xsi:type="NetServerServices882:ArrayOfstring">
    <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
   </Find:Response>
  </Find:GetAvailableRestrictionColumnsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

