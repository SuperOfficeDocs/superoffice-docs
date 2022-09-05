---
title: Services84.FavouriteAgent.GetFavourites SOAP
generated: 1
uid: Services84-Favourite-GetFavourites
---

# Services84 Favourite GetFavourites

SOAP request and response examples **Remote/Services84/Favourite.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IFavouriteAgent.GetFavourites">SuperOffice.Services84.IFavouriteAgent.GetFavourites</see> method.

## GetFavourites

Get all favourites for a table and associate

* **tableName:** Table name, transformed to and from numeric table id by the service layer.
* **associateId:** 



[WSDL file for Services84/Favourite](../Services84-Favourite.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFavourites Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Favourite:ApplicationToken>1234567-1234-9876</Favourite:ApplicationToken>
  <Favourite:Credentials>
    <Favourite:Ticket>7T:1234abcxyzExample==</Favourite:Ticket>
  </Favourite:Credentials>
 <SOAP-ENV:Body>
   <Favourite:GetFavourites>
    <Favourite:TableName xsi:type="xsd:string"></Favourite:TableName>
    <Favourite:AssociateId xsi:type="xsd:int">0</Favourite:AssociateId>
   </Favourite:GetFavourites>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFavourites Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Favourite:GetFavouritesResponse>
   <Favourite:Response xsi:type="Favourite:ArrayOfFavourite">
    <Favourite:Favourite xsi:type="Favourite:Favourite">
     <Favourite:TableName xsi:type="xsd:string"></Favourite:TableName>
     <Favourite:RecordId xsi:type="xsd:int">0</Favourite:RecordId>
     <Favourite:AssociateId xsi:type="xsd:int">0</Favourite:AssociateId>
     <Favourite:ExtraInfo xsi:type="xsd:string"></Favourite:ExtraInfo>
    </Favourite:Favourite>
   </Favourite:Response>
  </Favourite:GetFavouritesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

