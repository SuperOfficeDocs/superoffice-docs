---
title: Services86.MarketingAgent.DeleteFormEntity SOAP
generated: 1
uid: Services86-Marketing-DeleteFormEntity
---

# Services86 Marketing DeleteFormEntity

SOAP request and response examples **Remote/Services86/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IMarketingAgent.DeleteFormEntity">SuperOffice.Services86.IMarketingAgent.DeleteFormEntity</see> method.

## DeleteFormEntity

Deletes the FormEntity

* **formEntityId:** The identity of the FormEntity



[WSDL file for Services86/Marketing](../Services86-Marketing.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteFormEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Marketing:ApplicationToken>1234567-1234-9876</Marketing:ApplicationToken>
  <Marketing:Credentials>
    <Marketing:Ticket>7T:1234abcxyzExample==</Marketing:Ticket>
  </Marketing:Credentials>
 <SOAP-ENV:Body>
   <Marketing:DeleteFormEntity>
    <Marketing:FormEntityId xsi:type="xsd:int">0</Marketing:FormEntityId>
   </Marketing:DeleteFormEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteFormEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Marketing:DeleteFormEntityResponse>
  </Marketing:DeleteFormEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

