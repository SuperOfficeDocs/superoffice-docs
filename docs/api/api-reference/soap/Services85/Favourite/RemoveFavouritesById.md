---
uid: services85-favourite-removefavouritesbyid
title: Services85.FavouriteAgent.RemoveFavouritesById SOAP
Generated: true
---

# Services85 Favourite RemoveFavouritesById SOAP

SOAP request and response examples **Remote/Services85/Favourite.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IFavouriteAgent.RemoveFavouritesById">SuperOffice.Services85.IFavouriteAgent.RemoveFavouritesById</see> method.

## RemoveFavouritesById

Remove favourite using favourite id

* **favouriteIds:** Ids of favourite rows to delete



[WSDL file for Services85/Favourite](../Services85-Favourite.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveFavouritesById Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Favourite:ApplicationToken>1234567-1234-9876</Favourite:ApplicationToken>
  <Favourite:Credentials>
    <Favourite:Ticket>7T:1234abcxyzExample==</Favourite:Ticket>
  </Favourite:Credentials>
 <SOAP-ENV:Body>
   <Favourite:RemoveFavouritesById>
    <Favourite:FavouriteIds xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
    </Favourite:FavouriteIds>
   </Favourite:RemoveFavouritesById>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveFavouritesById Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Favourite:RemoveFavouritesByIdResponse>
  </Favourite:RemoveFavouritesByIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

