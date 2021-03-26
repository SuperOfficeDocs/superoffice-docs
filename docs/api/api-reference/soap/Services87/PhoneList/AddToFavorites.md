---
uid: services87-phonelist-addtofavorites
title: Services87.PhoneListAgent.AddToFavorites SOAP
Generated: true
---

# Services87 PhoneList AddToFavorites SOAP

SOAP request and response examples **Remote/Services87/PhoneList.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IPhoneListAgent.AddToFavorites">SuperOffice.Services87.IPhoneListAgent.AddToFavorites</see> method.

## AddToFavorites

Adds a new contact to the history/favorites. Returns the rank of the new history item. If the contact already existed in the history, it isn't added but the rank is updated.

* **contactId:** The contact id

**Returns:** The rank of the history item


[WSDL file for Services87/PhoneList](../Services87-PhoneList.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddToFavorites Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:PhoneList="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <PhoneList:ApplicationToken>1234567-1234-9876</PhoneList:ApplicationToken>
  <PhoneList:Credentials>
    <PhoneList:Ticket>7T:1234abcxyzExample==</PhoneList:Ticket>
  </PhoneList:Credentials>
 <SOAP-ENV:Body>
   <PhoneList:AddToFavorites>
    <PhoneList:ContactId xsi:type="xsd:int">0</PhoneList:ContactId>
   </PhoneList:AddToFavorites>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddToFavorites Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:PhoneList="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <PhoneList:AddToFavoritesResponse>
   <PhoneList:Response xsi:type="xsd:int">0</PhoneList:Response>
  </PhoneList:AddToFavoritesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

