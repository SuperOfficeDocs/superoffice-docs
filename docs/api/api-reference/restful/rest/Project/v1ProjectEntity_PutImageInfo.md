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
PUT /api/v1/Project/{id}/ImageInfo?projectId=968
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
  "BlobId": 725,
  "BlobSize": 478,
  "Description": "Business-focused holistic circuit",
  "ExtraInfo": "odit",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "expedita",
  "OriginalSize": 281,
  "CreatedDate": "2000-08-20T15:05:42.5416348+02:00",
  "UpdatedDate": "2004-05-29T15:05:42.5416348+02:00",
  "CreatedBy": {
    "AssociateId": 754,
    "Name": "Murray-Bergnaum",
    "PersonId": 395,
    "Rank": 196,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 701,
    "FullName": "Keyshawn Gutmann",
    "FormalName": "Jenkins-Tillman",
    "Deleted": false,
    "EjUserId": 64,
    "UserName": "Gutkowski Inc and Sons"
  },
  "UpdatedBy": {
    "AssociateId": 735,
    "Name": "Nikolaus Group",
    "PersonId": 72,
    "Rank": 549,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 634,
    "FullName": "Bryce Collier",
    "FormalName": "Cartwright, Hoppe and Roob",
    "Deleted": true,
    "EjUserId": 549,
    "UserName": "Treutel Group"
  },
  "ConceptualType": "nulla"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 915,
  "BlobSize": 243,
  "Description": "Configurable intangible flexibility",
  "ExtraInfo": "et",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "sed",
  "OriginalSize": 163,
  "CreatedDate": "1998-08-25T15:05:42.5426353+02:00",
  "UpdatedDate": "2021-06-05T15:05:42.5426353+02:00",
  "CreatedBy": {
    "AssociateId": 784,
    "Name": "Nikolaus, Kris and Walsh",
    "PersonId": 397,
    "Rank": 11,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 881,
    "FullName": "Christop Howell",
    "FormalName": "Durgan, Gleichner and Stroman",
    "Deleted": true,
    "EjUserId": 374,
    "UserName": "Herzog Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 666
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 400,
    "Name": "Kuhn, Blanda and Mitchell",
    "PersonId": 614,
    "Rank": 708,
    "Tooltip": "cupiditate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 549,
    "FullName": "Flavie Oberbrunner",
    "FormalName": "Hand Group",
    "Deleted": false,
    "EjUserId": 82,
    "UserName": "Fahey-Hudson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 731
      }
    }
  },
  "ConceptualType": "repellat",
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
      "FieldLength": 732
    }
  }
}
```