---
title: Services84.BLOBAgent.SetProductImage SOAP
generated: 1
uid: Services84-BLOB-SetProductImage
---

# Services84 BLOB SetProductImage

SOAP request and response examples **Remote/Services84/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IBLOBAgent.SetProductImage">SuperOffice.Services84.IBLOBAgent.SetProductImage</see> method.

## SetProductImage

Stores the product image that is displayed in the CRM application. The image is scaled down to max 1000x1000. This method operates only the main (rank=1) image; future extensions may support multiple images. A thumbnail of size 75x75 is also automatically set.

* **productId:** The project id of the product the image belongs to.
* **image:** The image that is stored on the product (System.Drawing.Image), scaled down to no more than 1000x1000



[WSDL file for Services84/BLOB](../Services84-BLOB.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetProductImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:SetProductImage>
    <BLOB:ProductId xsi:type="xsd:int">0</BLOB:ProductId>
    <BLOB:Image xsi:type="xsd:base64Binary"></BLOB:Image>
   </BLOB:SetProductImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetProductImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <BLOB:SetProductImageResponse>
  </BLOB:SetProductImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

