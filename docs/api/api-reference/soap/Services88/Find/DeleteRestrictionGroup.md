---
uid: services88-find-deleterestrictiongroup
title: Services88.FindAgent.DeleteRestrictionGroup SOAP
Generated: true
---

# Services88 Find DeleteRestrictionGroup SOAP

SOAP request and response examples **Remote/Services88/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFindAgent.DeleteRestrictionGroup">SuperOffice.Services88.IFindAgent.DeleteRestrictionGroup</see> method.

## DeleteRestrictionGroup

Create a restriction group, initialized with next rank etc.

* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **rank:** Rank of the group to be deleted.
* **context:** Optional context that can be used by FindProvider

**Returns:** This service call just saves the restrictions.


[WSDL file for Services88/Find](../Services88-Find.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteRestrictionGroup Request

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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Find:DeleteRestrictionGroupResponse>
  </Find:DeleteRestrictionGroupResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

