---
title: GET Person/{id}/ImageInfo
id: v1PersonEntity_GetImageInfo
---

# GET Person/{id}/ImageInfo

```http
GET /api/v1/Person/{personId}/ImageInfo
```

Get the Blob that describes the given person's picture.

The actual bitmap is accessible via /api/Services80/person/123/image/content.




| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | Person id **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Carrier object for BlobEntity.
Services for the BlobEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IBLOBAgent">BLOB Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| CreatedBy |  | The person that first created the document. The property is read-only. |
| UpdatedBy |  | The person that last updated the appointment. |
| ConceptualType | string | The type, for instance PHOTO, PERSONPHOTO, or whatever, that is descriptive of what kind of image or data this is |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/Person/{personId}/ImageInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 18 May 1999 15:05:42 G5T

{
  "BlobId": 569,
  "BlobSize": 314,
  "Description": "Open-architected next generation hierarchy",
  "ExtraInfo": "illum",
  "IsEncrypted": false,
  "IsZipped": true,
  "MimeType": "harum",
  "OriginalSize": 95,
  "CreatedDate": "2000-12-10T15:05:42.4296675+01:00",
  "UpdatedDate": "1999-05-18T15:05:42.4296675+02:00",
  "CreatedBy": {
    "AssociateId": 235,
    "Name": "Skiles, Orn and Ratke",
    "PersonId": 404,
    "Rank": 566,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 121,
    "FullName": "Mylene Eichmann",
    "FormalName": "McDermott-McClure",
    "Deleted": false,
    "EjUserId": 798,
    "UserName": "Padberg, Gusikowski and Reichel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 240
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 999,
    "Name": "Murazik, Moen and O'Hara",
    "PersonId": 67,
    "Rank": 263,
    "Tooltip": "at",
    "Type": "AnonymousAssociate",
    "GroupIdx": 908,
    "FullName": "Brannon Rohan",
    "FormalName": "Nicolas, Kunze and McDermott",
    "Deleted": false,
    "EjUserId": 687,
    "UserName": "Conroy-Mayer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "empower wireless platforms"
        },
        "FieldType": "System.String",
        "FieldLength": 95
      }
    }
  },
  "ConceptualType": "atque",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "mesh ubiquitous paradigms"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 476
    }
  }
}
```