---
uid: services82-freetext-addwords
title: Services82.FreeTextAgent.AddWords SOAP
Generated: true
---

# Services82 FreeText AddWords SOAP

SOAP request and response examples **Remote/Services82/FreeText.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IFreeTextAgent.AddWords">SuperOffice.Services82.IFreeTextAgent.AddWords</see> method.

## AddWords

Adds the words in the string to the stop word list

* **stopWords:** The stop words to add

**Returns:** This method has no return value


[WSDL file for Services82/FreeText](../Services82-FreeText.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddWords Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <FreeText:ApplicationToken>1234567-1234-9876</FreeText:ApplicationToken>
  <FreeText:Credentials>
    <FreeText:Ticket>7T:1234abcxyzExample==</FreeText:Ticket>
  </FreeText:Credentials>
 <SOAP-ENV:Body>
   <FreeText:AddWords>
    <FreeText:StopWords xsi:type="xsd:string"></FreeText:StopWords>
   </FreeText:AddWords>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddWords Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <FreeText:AddWordsResponse>
  </FreeText:AddWordsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

