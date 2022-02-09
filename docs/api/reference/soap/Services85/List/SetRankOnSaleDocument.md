---
title: Services85.ListAgent.SetRankOnSaleDocument SOAP
generated: 1
uid: Services85-List-SetRankOnSaleDocument
---

# Services85 List SetRankOnSaleDocument

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.SetRankOnSaleDocument">SuperOffice.Services85.IListAgent.SetRankOnSaleDocument</see> method.

## SetRankOnSaleDocument

Set rank order on project document

* **saleTypeStageLinkId:** The id of the list
* **itemsIds:** The ids of the items in the order you want



[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetRankOnSaleDocument Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SetRankOnSaleDocument>
    <List:SaleTypeStageLinkId xsi:type="xsd:int">0</List:SaleTypeStageLinkId>
    <List:ItemsIds xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <List:SetRankOnSaleDocumentResponse>
  </List:SetRankOnSaleDocumentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

