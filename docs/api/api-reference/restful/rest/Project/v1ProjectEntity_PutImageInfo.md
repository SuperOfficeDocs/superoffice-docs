---
title: PUT Project/{id}/ImageInfo
id: v1ProjectEntity_PutImageInfo
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
PUT /api/v1/Project/{id}/ImageInfo?projectId=654
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
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Project/{id}/ImageInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "BlobId": 976,
  "BlobSize": 752,
  "Description": "Upgradable empowering function",
  "ExtraInfo": "corrupti",
  "IsEncrypted": false,
  "IsZipped": false,
  "MimeType": "rerum",
  "OriginalSize": 567,
  "CreatedDate": "2006-11-26T09:40:59.4076658+01:00",
  "UpdatedDate": "2011-07-05T09:40:59.4076658+02:00",
  "CreatedBy": {
    "AssociateId": 384,
    "Name": "Crona LLC",
    "PersonId": 740,
    "Rank": 174,
    "Tooltip": "facilis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 788,
    "FullName": "Javonte Weissnat",
    "FormalName": "Yost, Pfannerstill and Ziemann",
    "Deleted": true,
    "EjUserId": 840,
    "UserName": "Marvin, Konopelski and Vandervort"
  },
  "UpdatedBy": {
    "AssociateId": 361,
    "Name": "Considine, Heidenreich and Simonis",
    "PersonId": 438,
    "Rank": 334,
    "Tooltip": "deleniti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 499,
    "FullName": "Doris Hoppe",
    "FormalName": "Schmitt-Robel",
    "Deleted": false,
    "EjUserId": 332,
    "UserName": "Corkery, Sporer and Treutel"
  },
  "ConceptualType": "expedita"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 36,
  "BlobSize": 123,
  "Description": "Quality-focused motivating neural-net",
  "ExtraInfo": "doloremque",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "in",
  "OriginalSize": 342,
  "CreatedDate": "2017-11-21T09:40:59.4086656+01:00",
  "UpdatedDate": "1998-08-23T09:40:59.4086656+02:00",
  "CreatedBy": {
    "AssociateId": 180,
    "Name": "Gutkowski-Gutmann",
    "PersonId": 229,
    "Rank": 985,
    "Tooltip": "deleniti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 550,
    "FullName": "Kiera Durgan",
    "FormalName": "Mueller-Kessler",
    "Deleted": true,
    "EjUserId": 355,
    "UserName": "King-Altenwerth",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 603
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 774,
    "Name": "Ryan LLC",
    "PersonId": 597,
    "Rank": 97,
    "Tooltip": "eos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 551,
    "FullName": "Joana Jaskolski",
    "FormalName": "Hoppe LLC",
    "Deleted": false,
    "EjUserId": 959,
    "UserName": "Glover Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 179
      }
    }
  },
  "ConceptualType": "quae",
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
      "FieldLength": 337
    }
  }
}
```