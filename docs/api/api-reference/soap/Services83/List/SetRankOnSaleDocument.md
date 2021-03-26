---
uid: services83-list-setrankonsaledocument
title: Services83.ListAgent.SetRankOnSaleDocument SOAP
Generated: true
---

# Services83 List SetRankOnSaleDocument SOAP

SOAP request and response examples **Remote/Services83/List.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IListAgent.SetRankOnSaleDocument">SuperOffice.Services83.IListAgent.SetRankOnSaleDocument</see> method.

## SetRankOnSaleDocument

Set rank order on project document

* **saleTypeStageLinkId:** The id of the list
* **itemsIds:** The ids of the items in the order you want



[WSDL file for Services83/List](../Services83-List.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetRankOnSaleDocument Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SetRankOnSaleDocument>
    <List:SaleTypeStageLinkId xsi:type="xsd:int">0</List:SaleTypeStageLinkId>
    <List:ItemsIds xsi:type="NetServerServices832:ArrayOfint">
     <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
    </List:ItemsIds>
   </List:SetRankOnSaleDocument>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetRankOnSaleDocument Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <List:SetRankOnSaleDocumentResponse>
  </List:SetRankOnSaleDocumentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

