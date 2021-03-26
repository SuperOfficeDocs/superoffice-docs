---
uid: services87-favourite-togglefavourite
title: Services87.FavouriteAgent.ToggleFavourite SOAP
Generated: true
---

# Services87 Favourite ToggleFavourite SOAP

SOAP request and response examples **Remote/Services87/Favourite.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IFavouriteAgent.ToggleFavourite">SuperOffice.Services87.IFavouriteAgent.ToggleFavourite</see> method.

## ToggleFavourite

Toggle a record in a table as a favourite for an associate

* **tableName:** Table name, transformed to and from numeric table id by the service layer.
* **recordId:** 
* **associateId:** 
* **extraInfo:** 

**Returns:** Return the new value, true if added, false if removed


[WSDL file for Services87/Favourite](../Services87-Favourite.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ToggleFavourite Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Favourite:ApplicationToken>1234567-1234-9876</Favourite:ApplicationToken>
  <Favourite:Credentials>
    <Favourite:Ticket>7T:1234abcxyzExample==</Favourite:Ticket>
  </Favourite:Credentials>
 <SOAP-ENV:Body>
   <Favourite:ToggleFavourite>
    <Favourite:TableName xsi:type="xsd:string"></Favourite:TableName>
    <Favourite:RecordId xsi:type="xsd:int">0</Favourite:RecordId>
    <Favourite:AssociateId xsi:type="xsd:int">0</Favourite:AssociateId>
    <Favourite:ExtraInfo xsi:type="xsd:string"></Favourite:ExtraInfo>
   </Favourite:ToggleFavourite>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ToggleFavourite Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Favourite:ToggleFavouriteResponse>
   <Favourite:Response xsi:type="xsd:boolean">false</Favourite:Response>
  </Favourite:ToggleFavouriteResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

