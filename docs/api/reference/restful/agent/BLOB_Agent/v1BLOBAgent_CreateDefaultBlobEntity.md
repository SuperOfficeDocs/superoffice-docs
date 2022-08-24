---
title: POST Agents/BLOB/CreateDefaultBlobEntity
id: v1BLOBAgent_CreateDefaultBlobEntity
---

# POST Agents/BLOB/CreateDefaultBlobEntity

```http
POST /api/v1/Agents/BLOB/CreateDefaultBlobEntity
```

Set default values into a new BlobEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance

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
POST /api/v1/Agents/BLOB/CreateDefaultBlobEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 982,
  "BlobSize": 329,
  "Description": "Versatile fault-tolerant capacity",
  "ExtraInfo": "repellat",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "itaque",
  "OriginalSize": 426,
  "CreatedDate": "2008-03-27T18:28:48.1505424+01:00",
  "UpdatedDate": "1996-10-23T18:28:48.1505424+02:00",
  "CreatedBy": {
    "AssociateId": 100,
    "Name": "Thompson, Erdman and O'Hara",
    "PersonId": 307,
    "Rank": 93,
    "Tooltip": "numquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 591,
    "FullName": "Lindsey Hoppe",
    "FormalName": "Braun-Ortiz",
    "Deleted": true,
    "EjUserId": 234,
    "UserName": "O'Keefe LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 498
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 690,
    "Name": "Wolf, Ritchie and Schmidt",
    "PersonId": 632,
    "Rank": 197,
    "Tooltip": "totam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 193,
    "FullName": "William Witting",
    "FormalName": "Satterfield-Brown",
    "Deleted": true,
    "EjUserId": 804,
    "UserName": "Marvin-Moore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 934
      }
    }
  },
  "ConceptualType": "voluptatem",
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
      "FieldLength": 157
    }
  }
}
```
