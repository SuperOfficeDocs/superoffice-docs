---
title: POST Agents/BLOB/SaveBlobEntity
uid: v1BLOBAgent_SaveBlobEntity
generated: true
---

# POST Agents/BLOB/SaveBlobEntity

```http
POST /api/v1/Agents/BLOB/SaveBlobEntity
```

Updates the existing BlobEntity or creates a new BlobEntity if the id parameter is empty








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

## Request Body: entity 

The BlobEntity to be saved. 

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
POST /api/v1/Agents/BLOB/SaveBlobEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "BlobId": 935,
  "BlobSize": 53,
  "Description": "Realigned zero tolerance circuit",
  "ExtraInfo": "blanditiis",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "possimus",
  "OriginalSize": 230,
  "CreatedDate": "2025-03-19T03:45:22.9829669+01:00",
  "UpdatedDate": "2009-07-03T03:45:22.9829669+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ConceptualType": "odit"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 76,
  "BlobSize": 436,
  "Description": "Front-line well-modulated function",
  "ExtraInfo": "eum",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "deserunt",
  "OriginalSize": 952,
  "CreatedDate": "2002-12-27T03:45:22.9829669+01:00",
  "UpdatedDate": "2014-11-17T03:45:22.9829669+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ConceptualType": "repudiandae",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 89
    }
  }
}
```