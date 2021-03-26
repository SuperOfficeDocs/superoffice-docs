---
uid: services83-freetext-deletestopwordsbyid
title: Services83.FreeTextAgent.DeleteStopWordsById SOAP
Generated: true
---

# Services83 FreeText DeleteStopWordsById SOAP

SOAP request and response examples **Remote/Services83/FreeText.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IFreeTextAgent.DeleteStopWordsById">SuperOffice.Services83.IFreeTextAgent.DeleteStopWordsById</see> method.

## DeleteStopWordsById

Delete the stop words with these ids

* **stopWordIds:** The ids of the stopwords to delete

**Returns:** This method has no return value


[WSDL file for Services83/FreeText](../Services83-FreeText.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteStopWordsById Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <FreeText:ApplicationToken>1234567-1234-9876</FreeText:ApplicationToken>
  <FreeText:Credentials>
    <FreeText:Ticket>7T:1234abcxyzExample==</FreeText:Ticket>
  </FreeText:Credentials>
 <SOAP-ENV:Body>
   <FreeText:DeleteStopWordsById>
    <FreeText:StopWordIds xsi:type="NetServerServices832:ArrayOfint">
     <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
    </FreeText:StopWordIds>
   </FreeText:DeleteStopWordsById>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteStopWordsById Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <FreeText:DeleteStopWordsByIdResponse>
  </FreeText:DeleteStopWordsByIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

