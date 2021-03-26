---
title: GET Project/{id}/Imageinfo
id: v1ProjectEntity_GetImageInfo
---

# GET Project/{id}/Imageinfo

```http
GET /api/v1/Project/{projectId}/Imageinfo
```

Get the Blob that describes the given project's picture.

The actual bitmap is accessible via /api/Services80/project/123/image/content.




| Path Part | Type | Description |
|-----------|------|-------------|
| projectId | int32 | Project id **Required** |



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
GET /api/v1/Project/{projectId}/Imageinfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 01 Dec 2002 09:40:59 G12T

{
  "BlobId": 212,
  "BlobSize": 565,
  "Description": "Integrated exuding analyzer",
  "ExtraInfo": "esse",
  "IsEncrypted": false,
  "IsZipped": true,
  "MimeType": "enim",
  "OriginalSize": 758,
  "CreatedDate": "2007-07-15T09:40:59.4066657+02:00",
  "UpdatedDate": "2002-12-01T09:40:59.4066657+01:00",
  "CreatedBy": {
    "AssociateId": 396,
    "Name": "Corkery Group",
    "PersonId": 626,
    "Rank": 931,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 82,
    "FullName": "Cyrus Kris",
    "FormalName": "Kemmer Group",
    "Deleted": true,
    "EjUserId": 90,
    "UserName": "Mills, Carter and Stark",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 751
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 956,
    "Name": "Kemmer-Lemke",
    "PersonId": 704,
    "Rank": 795,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 300,
    "FullName": "Nia Mann",
    "FormalName": "Erdman-Spinka",
    "Deleted": false,
    "EjUserId": 314,
    "UserName": "Smith, Ryan and Hackett",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 225
      }
    }
  },
  "ConceptualType": "eveniet",
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
      "FieldLength": 876
    }
  }
}
```