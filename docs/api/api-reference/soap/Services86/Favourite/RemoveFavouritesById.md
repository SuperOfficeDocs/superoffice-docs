---
uid: services86-favourite-removefavouritesbyid
title: Services86.FavouriteAgent.RemoveFavouritesById SOAP
Generated: true
---

# Services86 Favourite RemoveFavouritesById SOAP

SOAP request and response examples **Remote/Services86/Favourite.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IFavouriteAgent.RemoveFavouritesById">SuperOffice.Services86.IFavouriteAgent.RemoveFavouritesById</see> method.

## RemoveFavouritesById

Remove favourite using favourite id

* **favouriteIds:** Ids of favourite rows to delete



[WSDL file for Services86/Favourite](../Services86-Favourite.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveFavouritesById Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Favourite:ApplicationToken>1234567-1234-9876</Favourite:ApplicationToken>
  <Favourite:Credentials>
    <Favourite:Ticket>7T:1234abcxyzExample==</Favourite:Ticket>
  </Favourite:Credentials>
 <SOAP-ENV:Body>
   <Favourite:RemoveFavouritesById>
    <Favourite:FavouriteIds xsi:type="NetServerServices862:ArrayOfint">
     <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Favourite:RemoveFavouritesByIdResponse>
  </Favourite:RemoveFavouritesByIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

