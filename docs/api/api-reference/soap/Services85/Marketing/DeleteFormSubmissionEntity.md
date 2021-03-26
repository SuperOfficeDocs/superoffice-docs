---
uid: services85-marketing-deleteformsubmissionentity
title: Services85.MarketingAgent.DeleteFormSubmissionEntity SOAP
Generated: true
---

# Services85 Marketing DeleteFormSubmissionEntity SOAP

SOAP request and response examples **Remote/Services85/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IMarketingAgent.DeleteFormSubmissionEntity">SuperOffice.Services85.IMarketingAgent.DeleteFormSubmissionEntity</see> method.

## DeleteFormSubmissionEntity

Deletes the FormSubmissionEntity

* **formSubmissionEntityId:** The identity of the FormSubmissionEntity



[WSDL file for Services85/Marketing](../Services85-Marketing.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteFormSubmissionEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Marketing:ApplicationToken>1234567-1234-9876</Marketing:ApplicationToken>
  <Marketing:Credentials>
    <Marketing:Ticket>7T:1234abcxyzExample==</Marketing:Ticket>
  </Marketing:Credentials>
 <SOAP-ENV:Body>
   <Marketing:DeleteFormSubmissionEntity>
    <Marketing:FormSubmissionEntityId xsi:type="xsd:int">0</Marketing:FormSubmissionEntityId>
   </Marketing:DeleteFormSubmissionEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteFormSubmissionEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Marketing:DeleteFormSubmissionEntityResponse>
  </Marketing:DeleteFormSubmissionEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

