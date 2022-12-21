---
title: Services88.FavouriteAgent.RemoveFavourites SOAP
generated: 1
uid: Services88-Favourite-RemoveFavourites
---

# Services88 Favourite RemoveFavourites

SOAP request and response examples **Remote/Services88/Favourite.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFavouriteAgent.RemoveFavourites">SuperOffice.Services88.IFavouriteAgent.RemoveFavourites</see> method.

## RemoveFavourites





[WSDL file for Services88/Favourite](../Services88-Favourite.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveFavourites Request

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
   <Favourite:RemoveFavourites>
    <Favourite:TableName xsi:type="xsd:string"></Favourite:TableName>
    <Favourite:RecordIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Favourite:RecordIds>
    <Favourite:AssociateId xsi:type="xsd:int">0</Favourite:AssociateId>
   </Favourite:RemoveFavourites>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveFavourites Response

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
  <Favourite:RemoveFavouritesResponse>
  </Favourite:RemoveFavouritesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

