---
uid: services88-marketing-deleteformentity
title: Services88.MarketingAgent.DeleteFormEntity SOAP
Generated: true
---

# Services88 Marketing DeleteFormEntity SOAP

SOAP request and response examples **Remote/Services88/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IMarketingAgent.DeleteFormEntity">SuperOffice.Services88.IMarketingAgent.DeleteFormEntity</see> method.

## DeleteFormEntity

Deletes the FormEntity

* **formEntityId:** The identity of the FormEntity



[WSDL file for Services88/Marketing](../Services88-Marketing.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteFormEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Marketing:DeleteFormEntityResponse>
  </Marketing:DeleteFormEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

