---
uid: services88-person-sendconsentconfirmationemail
title: Services88.PersonAgent.SendConsentConfirmationEmail SOAP
Generated: true
---

# Services88 Person SendConsentConfirmationEmail SOAP

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.SendConsentConfirmationEmail">SuperOffice.Services88.IPersonAgent.SendConsentConfirmationEmail</see> method.

## SendConsentConfirmationEmail

Send confirmation email to the provided person, email address (id), using the document template

* **personId:** The person id
* **emailAddress:** The email address to send to.
* **emailTemplateId:** The id of the email template (doctmpl\_id)
* **cultureLcidId:** The id of the culture (LCID)
* **subject:** Optional email subject



[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SendConsentConfirmationEmail Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Person:SendConsentConfirmationEmailResponse>
  </Person:SendConsentConfirmationEmailResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

