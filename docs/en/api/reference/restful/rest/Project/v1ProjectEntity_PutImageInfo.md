---
title: PUT Project/{id}/ImageInfo
uid: v1ProjectEntity_PutImageInfo
---

# PUT Project/{id}/ImageInfo

```http
PUT /api/v1/Project/{id}/ImageInfo
```

Update the Blob that describes the given project's picture.


The actual bitmap is accessible via /api/Services80/project/123/image/content.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | string |  **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| projectId | int32 | **Required** Project id |

```http
PUT /api/v1/Project/{id}/ImageInfo?projectId=467
```


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

New or Updated information about the image. 

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
| 400 | Bad request. Entity to save is not in request body. |

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/Project/{id}/ImageInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "BlobId": 783,
  "BlobSize": 574,
  "Description": "Robust empowering infrastructure",
  "ExtraInfo": "voluptatum",
  "IsEncrypted": false,
  "IsZipped": false,
  "MimeType": "qui",
  "OriginalSize": 316,
  "CreatedDate": "2007-01-18T17:37:39.0333033+01:00",
  "UpdatedDate": "1998-07-10T17:37:39.0333033+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ConceptualType": "iure"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 895,
  "BlobSize": 540,
  "Description": "Cloned attitude-oriented local area network",
  "ExtraInfo": "dolorem",
  "IsEncrypted": false,
  "IsZipped": false,
  "MimeType": "soluta",
  "OriginalSize": 549,
  "CreatedDate": "2006-03-29T17:37:39.0343059+02:00",
  "UpdatedDate": "2018-09-16T17:37:39.0343059+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ConceptualType": "illum",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 152
    }
  }
}
```