---
title: GET Product/{id}/Image
uid: v1Product_GetImage
generated: true
content_type: reference
---

# GET Product/{id}/Image

```http
GET /api/v1/Product/{productId}/Image
```

The product's picture.


The image is returned as stored. If width/height or format is specified, then the image is 
scaled and converted to the requested type.





| Path Part | Type | Description |
|-----------|------|-------------|
| productId | int32 | Product id **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| w | int32 |  Optional Width of bitmap. |
| h | int32 |  Optional Height of bitmap. |
| type | string |  Optional type of bitmap: JPEG or PNG or GIF |
| ifBlank | Enum: Default, ClearPixel, SrNoPhoto, SrNoPhotoWithBorder, Null, GenericFileIcon |  What to return if there is no picture (default = Null = 404 Error) (Default, ClearPixel, SrNoPhoto, SrNoPhotoWithBorder) |

```http
GET /api/v1/Product/{productId}/Image?w=445
GET /api/v1/Product/{productId}/Image?h=277
GET /api/v1/Product/{productId}/Image?type=voluptatem
GET /api/v1/Product/{productId}/Image?ifBlank=ClearPixel
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `image/png`, `image/jpeg`, `image/gif`, `image/tiff` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:byte

An image

| Response | Description |
|----------------|-------------|
| 200 | An image |
| 404 | No image on this product (when ifBlank not defined) |

### Response body: byte


## Sample request

[!include[sample request](../../samples/rest/request/v1Product_GetImage.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1Product_GetImage.md)]