---
title: Services87.PersonAgent.HasConsent SOAP
generated: 1
uid: Services87-Person-HasConsent
---

# Services87 Person HasConsent

SOAP request and response examples **Remote/Services87/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IPersonAgent.HasConsent">SuperOffice.Services87.IPersonAgent.HasConsent</see> method.

## HasConsent

Check if consent has been given by a specified person, for a specific purpose. Withdraw consents return FALSE.

* **personId:** The person id
* **purpose:** The key of the purpose to check. (e.g. 'STORE' or 'EMARKETING')

**Returns:** True if the person has consented to the given purpose.


[WSDL file for Services87/Person](../Services87-Person.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## HasConsent Request

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
   <Person:HasConsent>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:Purpose xsi:type="xsd:string"></Person:Purpose>
   </Person:HasConsent>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## HasConsent Response

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
  <Person:HasConsentResponse>
   <Person:Response xsi:type="xsd:boolean">false</Person:Response>
  </Person:HasConsentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

