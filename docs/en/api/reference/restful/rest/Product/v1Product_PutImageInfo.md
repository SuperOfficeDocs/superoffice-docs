---
title: PUT Product/{id}/ImageInfo
uid: v1Product_PutImageInfo
generated: true
---

# PUT Product/{id}/ImageInfo

```http
PUT /api/v1/Product/{productId}/ImageInfo
```

Update the Blob that describes the given person's picture.


The actual bitmap is accessible via /api/Services80/person/123/image.





| Path Part | Type | Description |
|-----------|------|-------------|
| productId | int32 | Product id **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: imageInfo 

New or Updated information about the product image. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| BlobId | Integer | Primary key |
| BlobSize | Integer | The length, in bytes, of the binary data AS STORED after any encryption and/or zipping. Important to get right, since some databases will not tell us just based on the blob itself! |
| Description | String | A description that is entered by the user, and visible to the user |
| ExtraInfo | String | Extra information, spare field, can be used for anything that makes sense. Should not refer to any particular context, that is something for the BinaryObjectLInk |
| IsEncrypted | Boolean | Has the data been encrypted. |
| IsZipped | Boolean | Has the data been zipped. |
| MimeType | String | Mime type, describing the technical type (image/jpeg) of the data |
| OriginalSize | Integer | Original size of the binary data, before encryption and/or zipping. This is what the ultimate client will get |
| CreatedDate | String | Registered when  in UTC. |
| UpdatedDate | String | Last updated when  in UTC. |
| CreatedBy | Associate | The person that first created the document. The property is read-only. |
| UpdatedBy | Associate | The person that last updated the appointment. |
| ConceptualType | String | The type, for instance PHOTO, PERSONPHOTO, or whatever, that is descriptive of what kind of image or data this is |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: BlobEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| BlobId | int32 | Primary key |
| BlobSize | int32 | The length, in bytes, of the binary data AS STORED after any encryption and/or zipping. Important to get right, since some databases will not tell us just based on the blob itself! |
| Description | string | A description that is entered by the user, and visible to the user |
| ExtraInfo | string | Extra information, spare field, can be used for anything that makes sense. Should not refer to any particular context, that is something for the BinaryObjectLInk |
| IsEncrypted | bool | Has the data been encrypted. |
| IsZipped | bool | Has the data been zipped. |
| MimeType | string | Mime type, describing the technical type (image/jpeg) of the data |
| OriginalSize | int32 | Original size of the binary data, before encryption and/or zipping. This is what the ultimate client will get |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy | Associate | The person that first created the document. The property is read-only. |
| UpdatedBy | Associate | The person that last updated the appointment. |
| ConceptualType | string | The type, for instance PHOTO, PERSONPHOTO, or whatever, that is descriptive of what kind of image or data this is |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/Product/{productId}/ImageInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "BlobId": 260,
  "BlobSize": 430,
  "Description": "Customer-focused contextually-based neural-net",
  "ExtraInfo": "excepturi",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "laborum",
  "OriginalSize": 302,
  "CreatedDate": "2003-03-09T13:38:17.8119358+01:00",
  "UpdatedDate": "2000-11-07T13:38:17.8119358+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ConceptualType": "quaerat"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 506,
  "BlobSize": 760,
  "Description": "Vision-oriented multi-tasking algorithm",
  "ExtraInfo": "et",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "adipisci",
  "OriginalSize": 218,
  "CreatedDate": "2007-11-19T13:38:17.8119358+01:00",
  "UpdatedDate": "2007-12-24T13:38:17.8119358+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ConceptualType": "unde",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 835
    }
  }
}
```