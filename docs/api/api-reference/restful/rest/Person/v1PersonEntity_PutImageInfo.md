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
  "BlobId": 557,
  "BlobSize": 428,
  "Description": "Right-sized needs-based adapter",
  "ExtraInfo": "officiis",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "mollitia",
  "OriginalSize": 625,
  "CreatedDate": "2008-03-08T09:40:59.2436626+01:00",
  "UpdatedDate": "2015-11-17T09:40:59.2436626+01:00",
  "CreatedBy": {
    "AssociateId": 267,
    "Name": "Nolan Group",
    "PersonId": 402,
    "Rank": 428,
    "Tooltip": "a",
    "Type": "AnonymousAssociate",
    "GroupIdx": 278,
    "FullName": "Devonte Predovic I",
    "FormalName": "Kautzer, Murphy and Marks",
    "Deleted": true,
    "EjUserId": 485,
    "UserName": "Zieme LLC"
  },
  "UpdatedBy": {
    "AssociateId": 977,
    "Name": "Goldner-Goodwin",
    "PersonId": 367,
    "Rank": 739,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 881,
    "FullName": "Efrain Gutkowski",
    "FormalName": "Satterfield Inc and Sons",
    "Deleted": false,
    "EjUserId": 215,
    "UserName": "Tromp-Kuhic"
  },
  "ConceptualType": "voluptas"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 497,
  "BlobSize": 64,
  "Description": "User-centric bottom-line instruction set",
  "ExtraInfo": "quis",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "aut",
  "OriginalSize": 787,
  "CreatedDate": "2019-09-20T09:40:59.2456627+02:00",
  "UpdatedDate": "2013-10-13T09:40:59.2456627+02:00",
  "CreatedBy": {
    "AssociateId": 186,
    "Name": "Howe Group",
    "PersonId": 365,
    "Rank": 241,
    "Tooltip": "neque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 851,
    "FullName": "Ignacio Hilll",
    "FormalName": "Walter, Hayes and Heidenreich",
    "Deleted": true,
    "EjUserId": 564,
    "UserName": "Torp LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 168
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 247,
    "Name": "Denesik, Murray and Dooley",
    "PersonId": 219,
    "Rank": 128,
    "Tooltip": "fugit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 4,
    "FullName": "Earline Greenholt MD",
    "FormalName": "Bailey Inc and Sons",
    "Deleted": false,
    "EjUserId": 78,
    "UserName": "Nienow Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 224
      }
    }
  },
  "ConceptualType": "iure",
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
      "FieldLength": 996
    }
  }
}
```