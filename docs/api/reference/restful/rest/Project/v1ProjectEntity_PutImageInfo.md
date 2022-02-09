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
PUT /api/v1/Project/{id}/ImageInfo?projectId=774
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
  "BlobId": 449,
  "BlobSize": 978,
  "Description": "Extended system-worthy product",
  "ExtraInfo": "repudiandae",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "libero",
  "OriginalSize": 353,
  "CreatedDate": "2017-08-10T18:25:50.8528853+02:00",
  "UpdatedDate": "2009-07-06T18:25:50.8528853+02:00",
  "CreatedBy": {
    "AssociateId": 475,
    "Name": "Yundt-Hickle",
    "PersonId": 498,
    "Rank": 977,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 902,
    "FullName": "Dr. Arvid Blanda",
    "FormalName": "Bayer, Glover and Reynolds",
    "Deleted": true,
    "EjUserId": 57,
    "UserName": "Strosin-Ortiz"
  },
  "UpdatedBy": {
    "AssociateId": 929,
    "Name": "Lesch-Fritsch",
    "PersonId": 42,
    "Rank": 363,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 608,
    "FullName": "Letitia Leffler",
    "FormalName": "Steuber, Anderson and Kreiger",
    "Deleted": true,
    "EjUserId": 601,
    "UserName": "Hirthe Group"
  },
  "ConceptualType": "eaque"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 287,
  "BlobSize": 450,
  "Description": "Secured optimizing definition",
  "ExtraInfo": "inventore",
  "IsEncrypted": false,
  "IsZipped": false,
  "MimeType": "doloribus",
  "OriginalSize": 613,
  "CreatedDate": "1996-03-19T18:25:50.8548851+01:00",
  "UpdatedDate": "2005-04-15T18:25:50.8548851+02:00",
  "CreatedBy": {
    "AssociateId": 37,
    "Name": "Hammes LLC",
    "PersonId": 678,
    "Rank": 258,
    "Tooltip": "unde",
    "Type": "AnonymousAssociate",
    "GroupIdx": 954,
    "FullName": "Benjamin McLaughlin",
    "FormalName": "Schuppe-Sawayn",
    "Deleted": false,
    "EjUserId": 127,
    "UserName": "Beahan-Mohr",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 41
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 547,
    "Name": "Legros LLC",
    "PersonId": 372,
    "Rank": 652,
    "Tooltip": "explicabo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 275,
    "FullName": "Ada Ratke IV",
    "FormalName": "Howe, Rice and Howe",
    "Deleted": false,
    "EjUserId": 148,
    "UserName": "Block LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 865
      }
    }
  },
  "ConceptualType": "necessitatibus",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "exploit 24/7 convergence"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 901
    }
  }
}
```