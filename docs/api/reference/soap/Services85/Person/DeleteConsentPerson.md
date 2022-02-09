---
title: Services85.PersonAgent.DeleteConsentPerson SOAP
generated: 1
uid: Services85-Person-DeleteConsentPerson
---

# Services85 Person DeleteConsentPerson

SOAP request and response examples **Remote/Services85/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IPersonAgent.DeleteConsentPerson">SuperOffice.Services85.IPersonAgent.DeleteConsentPerson</see> method.

## DeleteConsentPerson

Deletes the ConsentPerson

* **consentPersonId:** The identity of the ConsentPerson



[WSDL file for Services85/Person](../Services85-Person.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteConsentPerson Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:DeleteConsentPerson>
    <Person:ConsentPersonId xsi:type="xsd:int">0</Person:ConsentPersonId>
   </Person:DeleteConsentPerson>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteConsentPerson Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Person:DeleteConsentPersonResponse>
  </Person:DeleteConsentPersonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

