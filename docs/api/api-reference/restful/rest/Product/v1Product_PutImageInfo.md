---
title: PUT Product/{id}/ImageInfo
id: v1Product_PutImageInfo
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
PUT /api/v1/Product/{productId}/ImageInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "BlobId": 714,
  "BlobSize": 791,
  "Description": "Horizontal composite complexity",
  "ExtraInfo": "repellat",
  "IsEncrypted": false,
  "IsZipped": true,
  "MimeType": "nisi",
  "OriginalSize": 179,
  "CreatedDate": "2014-12-25T15:05:43.047633+01:00",
  "UpdatedDate": "1998-07-29T15:05:43.047633+02:00",
  "CreatedBy": {
    "AssociateId": 344,
    "Name": "Beahan, Adams and Prohaska",
    "PersonId": 590,
    "Rank": 934,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 784,
    "FullName": "Lawrence Mueller",
    "FormalName": "Ryan Group",
    "Deleted": true,
    "EjUserId": 510,
    "UserName": "Breitenberg, Turcotte and Borer"
  },
  "UpdatedBy": {
    "AssociateId": 925,
    "Name": "Pagac Group",
    "PersonId": 269,
    "Rank": 540,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 253,
    "FullName": "Dewitt Renner",
    "FormalName": "Reichert, Sawayn and Walsh",
    "Deleted": true,
    "EjUserId": 258,
    "UserName": "Lakin, Jones and Farrell"
  },
  "ConceptualType": "autem"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 465,
  "BlobSize": 514,
  "Description": "Cloned non-volatile encryption",
  "ExtraInfo": "molestias",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "corrupti",
  "OriginalSize": 663,
  "CreatedDate": "2006-07-19T15:05:43.0486662+02:00",
  "UpdatedDate": "2020-07-01T15:05:43.0486662+02:00",
  "CreatedBy": {
    "AssociateId": 632,
    "Name": "Heathcote Group",
    "PersonId": 129,
    "Rank": 682,
    "Tooltip": "quidem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 172,
    "FullName": "Colby Cruickshank",
    "FormalName": "McClure-Schaden",
    "Deleted": true,
    "EjUserId": 599,
    "UserName": "Kozey-Witting",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 784
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 250,
    "Name": "Flatley-Herman",
    "PersonId": 454,
    "Rank": 288,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 243,
    "FullName": "Karina Crona",
    "FormalName": "Beatty, Aufderhar and Shields",
    "Deleted": false,
    "EjUserId": 914,
    "UserName": "Braun, Gerlach and Bauch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "cultivate visionary web-readiness"
        },
        "FieldType": "System.Int32",
        "FieldLength": 73
      }
    }
  },
  "ConceptualType": "et",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "transition B2C solutions"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 426
    }
  }
}
```