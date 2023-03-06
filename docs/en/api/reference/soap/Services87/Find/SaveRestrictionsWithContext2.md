---
title: Services87.FindAgent.SaveRestrictionsWithContext2 SOAP
generated: 1
uid: Services87-Find-SaveRestrictionsWithContext2
---

# Services87 Find SaveRestrictionsWithContext2

SOAP request and response examples **Remote/Services87/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IFindAgent.SaveRestrictionsWithContext2">SuperOffice.Services87.IFindAgent.SaveRestrictionsWithContext2</see> method.

## SaveRestrictionsWithContext2





[WSDL file for Services87/Find](../Services87-Find.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveRestrictionsWithContext2 Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services87">
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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Find:SaveRestrictionsWithContext2Response>
  </Find:SaveRestrictionsWithContext2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

