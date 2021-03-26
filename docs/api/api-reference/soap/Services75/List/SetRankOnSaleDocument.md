---
uid: services75-list-setrankonsaledocument
title: Services75.ListAgent.SetRankOnSaleDocument SOAP
Generated: true
---

# Services75 List SetRankOnSaleDocument SOAP

SOAP request and response examples **Remote/Services75/List.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IListAgent.SetRankOnSaleDocument">SuperOffice.Services75.IListAgent.SetRankOnSaleDocument</see> method.

## SetRankOnSaleDocument

Set rank order on project document

* **saleTypeStageLinkId:** The id of the list
* **itemsIds:** The ids of the items in the order you want



[WSDL file for Services75/List](../Services75-List.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetRankOnSaleDocument Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SetRankOnSaleDocument>
    <List:SaleTypeStageLinkId xsi:type="xsd:int">0</List:SaleTypeStageLinkId>
    <List:ItemsIds xsi:type="NetServerServices752:ArrayOfint">
     <NetServerServices752:int xsi:type="xsd:int">0</NetServerServices752:int>
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
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <List:SetRankOnSaleDocumentResponse>
  </List:SetRankOnSaleDocumentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

