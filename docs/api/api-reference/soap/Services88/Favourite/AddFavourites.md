---
uid: services88-favourite-addfavourites
title: Services88.FavouriteAgent.AddFavourites SOAP
Generated: true
---

# Services88 Favourite AddFavourites SOAP

SOAP request and response examples **Remote/Services88/Favourite.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFavouriteAgent.AddFavourites">SuperOffice.Services88.IFavouriteAgent.AddFavourites</see> method.

## AddFavourites

Add a list of record ids as favourites for an associate

* **tableName:** Table name, transformed to and from numeric table id by the service layer.
* **recordIds:** 
* **associateId:** 
* **extraInfo:** 



[WSDL file for Services88/Favourite](../Services88-Favourite.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddFavourites Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Favourite:ApplicationToken>1234567-1234-9876</Favourite:ApplicationToken>
  <Favourite:Credentials>
    <Favourite:Ticket>7T:1234abcxyzExample==</Favourite:Ticket>
  </Favourite:Credentials>
 <SOAP-ENV:Body>
   <Favourite:AddFavourites>
    <Favourite:TableName xsi:type="xsd:string"></Favourite:TableName>
    <Favourite:RecordIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Favourite:RecordIds>
    <Favourite:AssociateId xsi:type="xsd:int">0</Favourite:AssociateId>
    <Favourite:ExtraInfo xsi:type="xsd:string"></Favourite:ExtraInfo>
   </Favourite:AddFavourites>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddFavourites Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Favourite:AddFavouritesResponse>
  </Favourite:AddFavouritesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

