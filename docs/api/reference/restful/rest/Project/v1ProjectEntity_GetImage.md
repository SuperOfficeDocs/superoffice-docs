---
title: GET Project/{id}/Image
id: v1ProjectEntity_GetImage
---

# GET Project/{id}/Image

```http
GET /api/v1/Project/{projectId}/Image
```

The project's picture.

The image is returned as stored. If width/height or format is specified, then the image is
scaled and converted to the requested type.

| Path Part | Type | Description |
|-----------|------|-------------|
| projectId | int32 | Project id **Required** |

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| w | int32 |  Optional Width of bitmap. |
| h | int32 |  Optional Height of bitmap. |
| type | string |  Optional type of bitmap: JPEG or PNG or GIF |
| ifBlank | Enum: Default, ClearPixel, SrNoPhoto, SrNoPhotoWithBorder, Null, GenericFileIcon |  What to return if there is no picture (default = Null = 404 Error) (Default, ClearPixel, SrNoPhoto, SrNoPhotoWithBorder) |

```http
GET /api/v1/Project/{projectId}/Image?w=966
GET /api/v1/Project/{projectId}/Image?h=594
GET /api/v1/Project/{projectId}/Image?type=sed
GET /api/v1/Project/{projectId}/Image?ifBlank=ClearPixel
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

## Response: byte

| Response | Description |
|----------------|-------------|
| 200 | An image |
| 404 | No image on this project (when ifBlank not defined) |

Response body: byte

## Sample Request

```http!
GET /api/v1/Project/{projectId}/Image
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 An image
Content-Type: application/json; charset=utf-8

"GIF89....File contents as raw bytes..."
```
