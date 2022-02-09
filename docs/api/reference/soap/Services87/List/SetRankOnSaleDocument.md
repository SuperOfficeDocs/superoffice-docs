---
title: Services87.ListAgent.SetRankOnSaleDocument SOAP
generated: 1
uid: Services87-List-SetRankOnSaleDocument
---

# Services87 List SetRankOnSaleDocument

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.SetRankOnSaleDocument">SuperOffice.Services87.IListAgent.SetRankOnSaleDocument</see> method.

## SetRankOnSaleDocument

Set rank order on project document

* **saleTypeStageLinkId:** The id of the list
* **itemsIds:** The ids of the items in the order you want



[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetRankOnSaleDocument Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SetRankOnSaleDocument>
    <List:SaleTypeStageLinkId xsi:type="xsd:int">0</List:SaleTypeStageLinkId>
    <List:ItemsIds xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <List:SetRankOnSaleDocumentResponse>
  </List:SetRankOnSaleDocumentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

