---
uid: services75-freetext-deletestopwordsbyid
title: Services75.FreeTextAgent.DeleteStopWordsById SOAP
Generated: true
---

# Services75 FreeText DeleteStopWordsById SOAP

SOAP request and response examples **Remote/Services75/FreeText.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IFreeTextAgent.DeleteStopWordsById">SuperOffice.Services75.IFreeTextAgent.DeleteStopWordsById</see> method.

## DeleteStopWordsById

Delete the stop words with these ids

* **stopWordIds:** The ids of the stopwords to delete

**Returns:** This method has no return value


[WSDL file for Services75/FreeText](../Services75-FreeText.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteStopWordsById Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <FreeText:ApplicationToken>1234567-1234-9876</FreeText:ApplicationToken>
  <FreeText:Credentials>
    <FreeText:Ticket>7T:1234abcxyzExample==</FreeText:Ticket>
  </FreeText:Credentials>
 <SOAP-ENV:Body>
   <FreeText:DeleteStopWordsById>
    <FreeText:StopWordIds xsi:type="NetServerServices752:ArrayOfint">
     <NetServerServices752:int xsi:type="xsd:int">0</NetServerServices752:int>
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
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <FreeText:DeleteStopWordsByIdResponse>
  </FreeText:DeleteStopWordsByIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

