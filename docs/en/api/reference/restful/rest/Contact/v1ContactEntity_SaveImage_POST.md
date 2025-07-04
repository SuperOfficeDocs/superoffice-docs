---
title: POST Contact/{id}/Image
uid: v1ContactEntity_SaveImage_POST
generated: true
---

# POST Contact/{id}/Image

```http
POST /api/v1/Contact/{contactId}/Image
```

Save an image to a contact.


Updating the image will update the ImageInfo automatically.





| Path Part | Type | Description |
|-----------|------|-------------|
| contactId | int32 | Contact id **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `image/png`, `image/jpeg`, `image/gif`, `image/tiff`, `multipart/form-data` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: image binary

Bitmap (GIF, TIFF, PNG or JPG format) 


## Response:int32

The blob id for the image

| Response | Description |
|----------------|-------------|
| 200 | The blob id for the image |
| 400 | Image bitmap is missing from body. |

### Response body: int32


## Sample request

```http!
POST /api/v1/Contact/{contactId}/Image
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 The blob id for the image
Content-Type: application/json; charset=utf-8

449
```