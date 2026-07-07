---
title: Services88.NewsFeedAgent.MarkAsRead SOAP
generated: true
uid: Services88-NewsFeed-MarkAsRead
content_type: reference
---

# Services88 NewsFeed MarkAsRead

SOAP request and response examples **Remote/Services88/NewsFeed.svc**
Implemented by the <see cref="M:SuperOffice.Services88.INewsFeedAgent.MarkAsRead">SuperOffice.Services88.INewsFeedAgent.MarkAsRead</see> method.

## MarkAsRead





[WSDL file for Services88/NewsFeed](../Services88-NewsFeed.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## MarkAsRead Request

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
   <NewsFeed:MarkAsRead>
    <NewsFeed:NewsFeedItemId xsi:type="xsd:int">0</NewsFeed:NewsFeedItemId>
   </NewsFeed:MarkAsRead>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## MarkAsRead Response

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
  <NewsFeed:MarkAsReadResponse>
  </NewsFeed:MarkAsReadResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

