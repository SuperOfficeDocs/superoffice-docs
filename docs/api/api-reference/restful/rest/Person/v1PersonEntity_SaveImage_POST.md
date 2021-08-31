---
title: POST Person/{id}/Image
id: v1PersonEntity_SaveImage_POST
---

# POST Person/{id}/Image

```http
POST /api/v1/Person/{personId}/Image
```

Save an image to a person.

Updating the image will update the ImageInfo automatically.




| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | Person id **Required** |



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

Image bitmap (PNG, GIF, JPEG or TIFF format). 



## Response: int32



| Response | Description |
|----------------|-------------|
| 200 | The image blob id |
| 400 | Image bitmap is missing from body or person id is not valid. |

Response body: int32


## Sample Request

```http!
POST /api/v1/Person/{personId}/Image
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 The image blob id
Content-Type: application/json; charset=utf-8

385
```