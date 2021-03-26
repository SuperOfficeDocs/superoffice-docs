---
title: PUT Contact/{id}/ImageInfo
id: v1ContactEntity_PutImageInfo
---

# PUT Contact/{id}/ImageInfo

```http
PUT /api/v1/Contact/{contactId}/ImageInfo
```

Update the Blob that describes the given contact's picture.

The actual bitmap is accessible via /api/v1/contact/123/image.




| Path Part | Type | Description |
|-----------|------|-------------|
| contactId | int32 | Contact id **Required** |



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
PUT /api/v1/Contact/{contactId}/ImageInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "BlobId": 457,
  "BlobSize": 49,
  "Description": "Public-key local parallelism",
  "ExtraInfo": "quas",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "omnis",
  "OriginalSize": 972,
  "CreatedDate": "2018-05-30T09:40:58.8523797+02:00",
  "UpdatedDate": "2016-04-25T09:40:58.8523797+02:00",
  "CreatedBy": {
    "AssociateId": 857,
    "Name": "Greenholt Group",
    "PersonId": 443,
    "Rank": 174,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 846,
    "FullName": "Della Conroy",
    "FormalName": "Ondricka LLC",
    "Deleted": false,
    "EjUserId": 735,
    "UserName": "Cruickshank, Prosacco and Boyer"
  },
  "UpdatedBy": {
    "AssociateId": 990,
    "Name": "Mann-Thiel",
    "PersonId": 609,
    "Rank": 776,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 754,
    "FullName": "Warren Monahan",
    "FormalName": "Zboncak-Hamill",
    "Deleted": true,
    "EjUserId": 235,
    "UserName": "Hammes-Heaney"
  },
  "ConceptualType": "voluptates"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 736,
  "BlobSize": 934,
  "Description": "Integrated homogeneous ability",
  "ExtraInfo": "nemo",
  "IsEncrypted": false,
  "IsZipped": true,
  "MimeType": "qui",
  "OriginalSize": 961,
  "CreatedDate": "2009-06-17T09:40:58.8543757+02:00",
  "UpdatedDate": "2005-06-09T09:40:58.8543757+02:00",
  "CreatedBy": {
    "AssociateId": 822,
    "Name": "Daugherty, Ziemann and Schinner",
    "PersonId": 785,
    "Rank": 403,
    "Tooltip": "asperiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 905,
    "FullName": "Gregorio Ruecker",
    "FormalName": "Klocko, Kreiger and Monahan",
    "Deleted": false,
    "EjUserId": 467,
    "UserName": "Kris, Blanda and Botsford",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 190
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 780,
    "Name": "Bashirian Inc and Sons",
    "PersonId": 565,
    "Rank": 691,
    "Tooltip": "in",
    "Type": "AnonymousAssociate",
    "GroupIdx": 573,
    "FullName": "Lexie Goldner",
    "FormalName": "Wehner, Shields and Mayert",
    "Deleted": true,
    "EjUserId": 440,
    "UserName": "Upton-Runte",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 966
      }
    }
  },
  "ConceptualType": "laboriosam",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "unleash ubiquitous functionalities"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 530
    }
  }
}
```