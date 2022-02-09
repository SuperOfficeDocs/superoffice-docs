---
title: Services85.PersonAgent.SendConsentConfirmationEmail SOAP
generated: 1
uid: Services85-Person-SendConsentConfirmationEmail
---

# Services85 Person SendConsentConfirmationEmail

SOAP request and response examples **Remote/Services85/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IPersonAgent.SendConsentConfirmationEmail">SuperOffice.Services85.IPersonAgent.SendConsentConfirmationEmail</see> method.

## SendConsentConfirmationEmail

Send confirmation email to the provided person, email address (id), using the document template

* **personId:** The person id
* **emailAddress:** The email address to send to.
* **emailTemplateId:** The id of the email template (doctmpl\_id)
* **cultureLcidId:** The id of the culture (LCID)
* **subject:** Optional email subject



[WSDL file for Services85/Person](../Services85-Person.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SendConsentConfirmationEmail Request

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
   <Person:SendConsentConfirmationEmail>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:EmailAddress xsi:type="xsd:string"></Person:EmailAddress>
    <Person:EmailTemplateId xsi:type="xsd:int">0</Person:EmailTemplateId>
    <Person:CultureLcidId xsi:type="xsd:int">0</Person:CultureLcidId>
    <Person:Subject xsi:type="xsd:string"></Person:Subject>
   </Person:SendConsentConfirmationEmail>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SendConsentConfirmationEmail Response

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
  <Person:SendConsentConfirmationEmailResponse>
  </Person:SendConsentConfirmationEmailResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

