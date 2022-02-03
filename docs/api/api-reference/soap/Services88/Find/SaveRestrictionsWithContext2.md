---
title: Services88.FindAgent.SaveRestrictionsWithContext2 SOAP
generated: 1
uid: Services88-Find-SaveRestrictionsWithContext2
---

# Services88 Find SaveRestrictionsWithContext2

SOAP request and response examples **Remote/Services88/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFindAgent.SaveRestrictionsWithContext2">SuperOffice.Services88.IFindAgent.SaveRestrictionsWithContext2</see> method.

## SaveRestrictionsWithContext2

Save an array of restrictions for later use as search criteria (including as dynamic selection and Find).

* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **restrictions:** String of restrictions. The ColumnInfo member and the DisplayValues members need NOT be populated; it is enough to provide a name, operator and any values the operator may need. The IsActive is also saved. Values should be encoded using the CultureDataFormatter to ensure compatibility across cultures.
* **context:** Optional context that can be used by FindProvider

**Returns:** This service call just saves the restrictions. See SaveRestrictionsAndGetCriteriaInformation if you would like the restrictions returned as criteria immediately, in one roundtrip


[WSDL file for Services88/Find](../Services88-Find.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveRestrictionsWithContext2 Request

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
   <Find:SaveRestrictionsWithContext2>
    <Find:StorageType xsi:type="xsd:string"></Find:StorageType>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
    <Find:StorageKey xsi:type="xsd:string"></Find:StorageKey>
    <Find:Restrictions xsi:type="xsd:string"></Find:Restrictions>
    <Find:Context xsi:type="xsd:string"></Find:Context>
   </Find:SaveRestrictionsWithContext2>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveRestrictionsWithContext2 Response

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
  <Find:SaveRestrictionsWithContext2Response>
  </Find:SaveRestrictionsWithContext2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

