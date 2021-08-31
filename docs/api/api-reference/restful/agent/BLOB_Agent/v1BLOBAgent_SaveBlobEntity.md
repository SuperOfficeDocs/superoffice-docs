---
title: SaveBlobEntity
id: v1BLOBAgent_SaveBlobEntity
---

# SaveBlobEntity

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
POST /api/v1/Agents/BLOB/SaveBlobEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "BlobId": 326,
  "BlobSize": 738,
  "Description": "Total non-volatile database",
  "ExtraInfo": "ipsam",
  "IsEncrypted": false,
  "IsZipped": false,
  "MimeType": "sunt",
  "OriginalSize": 583,
  "CreatedDate": "2020-11-12T14:58:03.2802409+01:00",
  "UpdatedDate": "2016-07-30T14:58:03.2802409+02:00",
  "CreatedBy": {
    "AssociateId": 496,
    "Name": "Pacocha-Stracke",
    "PersonId": 945,
    "Rank": 174,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 444,
    "FullName": "Hannah Padberg",
    "FormalName": "McDermott-Ruecker",
    "Deleted": true,
    "EjUserId": 997,
    "UserName": "Bergnaum, Labadie and Parker"
  },
  "UpdatedBy": {
    "AssociateId": 659,
    "Name": "Considine, Willms and Bednar",
    "PersonId": 329,
    "Rank": 426,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 234,
    "FullName": "Danny Bernier",
    "FormalName": "Nitzsche LLC",
    "Deleted": true,
    "EjUserId": 410,
    "UserName": "Ruecker, Kling and Wiza"
  },
  "ConceptualType": "et"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 90,
  "BlobSize": 616,
  "Description": "Universal disintermediate support",
  "ExtraInfo": "aut",
  "IsEncrypted": false,
  "IsZipped": false,
  "MimeType": "ea",
  "OriginalSize": 776,
  "CreatedDate": "2016-04-25T14:58:03.2812407+02:00",
  "UpdatedDate": "1995-04-20T14:58:03.2812407+02:00",
  "CreatedBy": {
    "AssociateId": 626,
    "Name": "Terry-Spinka",
    "PersonId": 910,
    "Rank": 782,
    "Tooltip": "iusto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 962,
    "FullName": "Jovanny Halvorson",
    "FormalName": "Kunze-Wiza",
    "Deleted": true,
    "EjUserId": 550,
    "UserName": "Schimmel Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 543
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 32,
    "Name": "Lockman-Turcotte",
    "PersonId": 220,
    "Rank": 951,
    "Tooltip": "optio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 328,
    "FullName": "Nola Wyman",
    "FormalName": "Streich, Beatty and O'Hara",
    "Deleted": false,
    "EjUserId": 953,
    "UserName": "Homenick-Braun",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 967
      }
    }
  },
  "ConceptualType": "similique",
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
      "FieldType": "System.String",
      "FieldLength": 303
    }
  }
}
```