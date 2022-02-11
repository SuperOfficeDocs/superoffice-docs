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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "BlobId": 739,
  "BlobSize": 971,
  "Description": "Enhanced maximized open architecture",
  "ExtraInfo": "quia",
  "IsEncrypted": false,
  "IsZipped": false,
  "MimeType": "accusamus",
  "OriginalSize": 841,
  "CreatedDate": "2007-02-04T18:25:50.7858837+01:00",
  "UpdatedDate": "2017-07-17T18:25:50.7858837+02:00",
  "CreatedBy": {
    "AssociateId": 901,
    "Name": "Wuckert-Kassulke",
    "PersonId": 723,
    "Rank": 442,
    "Tooltip": "illo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 946,
    "FullName": "Miss Mariana Mitchell",
    "FormalName": "Torphy, Reichel and Windler",
    "Deleted": true,
    "EjUserId": 787,
    "UserName": "Schmitt, Steuber and Hirthe"
  },
  "UpdatedBy": {
    "AssociateId": 522,
    "Name": "Jacobi-Lemke",
    "PersonId": 898,
    "Rank": 457,
    "Tooltip": "consectetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 210,
    "FullName": "Alycia Klein",
    "FormalName": "Waelchi, Eichmann and Schoen",
    "Deleted": false,
    "EjUserId": 718,
    "UserName": "Lueilwitz Group"
  },
  "ConceptualType": "similique"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 388,
  "BlobSize": 580,
  "Description": "Quality-focused high-level protocol",
  "ExtraInfo": "corrupti",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "optio",
  "OriginalSize": 492,
  "CreatedDate": "2018-09-04T18:25:50.7888837+02:00",
  "UpdatedDate": "2007-05-15T18:25:50.7888837+02:00",
  "CreatedBy": {
    "AssociateId": 501,
    "Name": "Hilpert, Treutel and Funk",
    "PersonId": 279,
    "Rank": 648,
    "Tooltip": "quasi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 943,
    "FullName": "Easter Heathcote",
    "FormalName": "Upton-Johnson",
    "Deleted": false,
    "EjUserId": 482,
    "UserName": "Rodriguez-Turner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 514
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 977,
    "Name": "Armstrong, Pagac and Metz",
    "PersonId": 150,
    "Rank": 91,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 195,
    "FullName": "Melissa Kirlin",
    "FormalName": "Corwin-Lakin",
    "Deleted": false,
    "EjUserId": 521,
    "UserName": "Wunsch, Connelly and Ruecker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 12
      }
    }
  },
  "ConceptualType": "repellendus",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "redefine proactive mindshare"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 392
    }
  }
}
```