---
title: PUT Person/{id}/ImageInfo
id: v1PersonEntity_PutImageInfo
---

# PUT Person/{id}/ImageInfo

```http
PUT /api/v1/Person/{personId}/ImageInfo
```

Update the Blob that describes the given person's picture.

The actual bitmap is accessible via /api/Services80/person/123/image/content.




| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | Person id **Required** |



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

New or Updated information about the person image. 

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
PUT /api/v1/Person/{personId}/ImageInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "BlobId": 449,
  "BlobSize": 550,
  "Description": "Cross-platform national productivity",
  "ExtraInfo": "adipisci",
  "IsEncrypted": false,
  "IsZipped": false,
  "MimeType": "ut",
  "OriginalSize": 204,
  "CreatedDate": "2020-09-17T15:05:42.4306674+02:00",
  "UpdatedDate": "2004-04-09T15:05:42.4306674+02:00",
  "CreatedBy": {
    "AssociateId": 857,
    "Name": "Tremblay LLC",
    "PersonId": 358,
    "Rank": 257,
    "Tooltip": "fugiat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 112,
    "FullName": "Monroe Wintheiser",
    "FormalName": "Williamson LLC",
    "Deleted": true,
    "EjUserId": 120,
    "UserName": "Ebert-Crist"
  },
  "UpdatedBy": {
    "AssociateId": 595,
    "Name": "Beer-Heathcote",
    "PersonId": 631,
    "Rank": 617,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 449,
    "FullName": "Vernon Leffler",
    "FormalName": "Quitzon, Crist and Walter",
    "Deleted": true,
    "EjUserId": 144,
    "UserName": "Morar-Schamberger"
  },
  "ConceptualType": "magnam"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 389,
  "BlobSize": 27,
  "Description": "Focused background framework",
  "ExtraInfo": "itaque",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "vitae",
  "OriginalSize": 696,
  "CreatedDate": "2021-08-12T15:05:42.4326673+02:00",
  "UpdatedDate": "2003-08-31T15:05:42.4326673+02:00",
  "CreatedBy": {
    "AssociateId": 68,
    "Name": "Littel, Ryan and Toy",
    "PersonId": 485,
    "Rank": 170,
    "Tooltip": "doloribus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 290,
    "FullName": "Krista Kohler",
    "FormalName": "Parker Group",
    "Deleted": true,
    "EjUserId": 636,
    "UserName": "Thiel-Lang",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 149
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 242,
    "Name": "Kirlin-Lueilwitz",
    "PersonId": 237,
    "Rank": 337,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 413,
    "FullName": "Gabriel Braun",
    "FormalName": "Kohler, Gottlieb and Barton",
    "Deleted": false,
    "EjUserId": 827,
    "UserName": "Bayer-Koss",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 728
      }
    }
  },
  "ConceptualType": "aliquid",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 746
    }
  }
}
```