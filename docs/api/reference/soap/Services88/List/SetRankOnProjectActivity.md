---
title: Services88.ListAgent.SetRankOnProjectActivity SOAP
generated: 1
uid: Services88-List-SetRankOnProjectActivity
---

# Services88 List SetRankOnProjectActivity

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SetRankOnProjectActivity">SuperOffice.Services88.IListAgent.SetRankOnProjectActivity</see> method.

## SetRankOnProjectActivity

Set rank order on project activity

* **projectTypeStatusLinkId:** The id of the list
* **itemsIds:** The ids of the items in the order you want



[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetRankOnProjectActivity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SetRankOnProjectActivity>
    <List:ProjectTypeStatusLinkId xsi:type="xsd:int">0</List:ProjectTypeStatusLinkId>
    <List:ItemsIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </List:ItemsIds>
   </List:SetRankOnProjectActivity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetRankOnProjectActivity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <List:SetRankOnProjectActivityResponse>
  </List:SetRankOnProjectActivityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

