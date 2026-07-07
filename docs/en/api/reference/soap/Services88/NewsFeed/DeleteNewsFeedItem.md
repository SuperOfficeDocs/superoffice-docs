---
title: Services88.NewsFeedAgent.DeleteNewsFeedItem SOAP
generated: true
uid: Services88-NewsFeed-DeleteNewsFeedItem
content_type: reference
---

# Services88 NewsFeed DeleteNewsFeedItem

SOAP request and response examples **Remote/Services88/NewsFeed.svc**
Implemented by the <see cref="M:SuperOffice.Services88.INewsFeedAgent.DeleteNewsFeedItem">SuperOffice.Services88.INewsFeedAgent.DeleteNewsFeedItem</see> method.

## DeleteNewsFeedItem





[WSDL file for Services88/NewsFeed](../Services88-NewsFeed.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteNewsFeedItem Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:NewsFeed="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <NewsFeed:ApplicationToken>1234567-1234-9876</NewsFeed:ApplicationToken>
  <NewsFeed:Credentials>
    <NewsFeed:Ticket>7T:1234abcxyzExample==</NewsFeed:Ticket>
  </NewsFeed:Credentials>
 <SOAP-ENV:Body>
   <NewsFeed:DeleteNewsFeedItem>
    <NewsFeed:NewsFeedItemId xsi:type="xsd:int">0</NewsFeed:NewsFeedItemId>
   </NewsFeed:DeleteNewsFeedItem>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteNewsFeedItem Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:NewsFeed="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <NewsFeed:DeleteNewsFeedItemResponse>
  </NewsFeed:DeleteNewsFeedItemResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

