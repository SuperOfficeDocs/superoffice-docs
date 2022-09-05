---
title: Services85.PersonAgent.SetConsent SOAP
generated: 1
uid: Services85-Person-SetConsent
---

# Services85 Person SetConsent

SOAP request and response examples **Remote/Services85/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IPersonAgent.SetConsent">SuperOffice.Services85.IPersonAgent.SetConsent</see> method.

## SetConsent

Set a specified type of consent on the person.

* **personId:** The person id
* **purpose:** The Key of the purpose this affects
* **source:** The Key of the source of this consent
* **legalBase:** The Key of the legal base for this consent
* **comment:** A comment regarding this consent. May be null or empty.



[WSDL file for Services85/Person](../Services85-Person.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetConsent Request

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
   <Person:SetConsent>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:Purpose xsi:type="xsd:string"></Person:Purpose>
    <Person:Source xsi:type="xsd:string"></Person:Source>
    <Person:LegalBase xsi:type="xsd:string"></Person:LegalBase>
    <Person:Comment xsi:type="xsd:string"></Person:Comment>
   </Person:SetConsent>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetConsent Response

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
  <Person:SetConsentResponse>
  </Person:SetConsentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

