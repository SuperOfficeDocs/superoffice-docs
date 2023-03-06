---
title: Services86.FindAgent.DeleteRestrictionGroup SOAP
generated: 1
uid: Services86-Find-DeleteRestrictionGroup
---

# Services86 Find DeleteRestrictionGroup

SOAP request and response examples **Remote/Services86/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IFindAgent.DeleteRestrictionGroup">SuperOffice.Services86.IFindAgent.DeleteRestrictionGroup</see> method.

## DeleteRestrictionGroup





[WSDL file for Services86/Find](../Services86-Find.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteRestrictionGroup Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Find:ApplicationToken>1234567-1234-9876</Find:ApplicationToken>
  <Find:Credentials>
    <Find:Ticket>7T:1234abcxyzExample==</Find:Ticket>
  </Find:Credentials>
 <SOAP-ENV:Body>
   <Find:DeleteRestrictionGroup>
    <Find:StorageType xsi:type="xsd:string"></Find:StorageType>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
    <Find:StorageKey xsi:type="xsd:string"></Find:StorageKey>
    <Find:Rank xsi:type="xsd:int">0</Find:Rank>
    <Find:Context xsi:type="xsd:string"></Find:Context>
   </Find:DeleteRestrictionGroup>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteRestrictionGroup Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Find:DeleteRestrictionGroupResponse>
  </Find:DeleteRestrictionGroupResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

