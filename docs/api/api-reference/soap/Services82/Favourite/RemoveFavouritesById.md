---
uid: services82-favourite-removefavouritesbyid
title: Services82.FavouriteAgent.RemoveFavouritesById SOAP
Generated: true
---

# Services82 Favourite RemoveFavouritesById SOAP

SOAP request and response examples **Remote/Services82/Favourite.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IFavouriteAgent.RemoveFavouritesById">SuperOffice.Services82.IFavouriteAgent.RemoveFavouritesById</see> method.

## RemoveFavouritesById

Remove favourite using favourite id

* **favouriteIds:** Ids of favourite rows to delete



[WSDL file for Services82/Favourite](../Services82-Favourite.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveFavouritesById Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Favourite:ApplicationToken>1234567-1234-9876</Favourite:ApplicationToken>
  <Favourite:Credentials>
    <Favourite:Ticket>7T:1234abcxyzExample==</Favourite:Ticket>
  </Favourite:Credentials>
 <SOAP-ENV:Body>
   <Favourite:RemoveFavouritesById>
    <Favourite:FavouriteIds xsi:type="NetServerServices822:ArrayOfint">
     <NetServerServices822:int xsi:type="xsd:int">0</NetServerServices822:int>
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
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Favourite:RemoveFavouritesByIdResponse>
  </Favourite:RemoveFavouritesByIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

