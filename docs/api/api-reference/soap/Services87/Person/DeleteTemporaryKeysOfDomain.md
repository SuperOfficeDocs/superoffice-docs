---
uid: services87-person-deletetemporarykeysofdomain
title: Services87.PersonAgent.DeleteTemporaryKeysOfDomain SOAP
Generated: true
---

# Services87 Person DeleteTemporaryKeysOfDomain SOAP

SOAP request and response examples **Remote/Services87/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IPersonAgent.DeleteTemporaryKeysOfDomain">SuperOffice.Services87.IPersonAgent.DeleteTemporaryKeysOfDomain</see> method.

## DeleteTemporaryKeysOfDomain

Delete all temporary keys for a given domain and person

* **domain:** The domain type to delete
* **personId:** The person for which to delete the keys



[WSDL file for Services87/Person](../Services87-Person.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteTemporaryKeysOfDomain Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:DeleteTemporaryKeysOfDomain>
    <Person:Domain xsi:type="Person:TemporaryKeyDomain">Unknown</Person:Domain>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
   </Person:DeleteTemporaryKeysOfDomain>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteTemporaryKeysOfDomain Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Person:DeleteTemporaryKeysOfDomainResponse>
  </Person:DeleteTemporaryKeysOfDomainResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

