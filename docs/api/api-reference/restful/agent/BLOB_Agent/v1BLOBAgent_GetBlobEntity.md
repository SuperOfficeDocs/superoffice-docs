---
title: POST Agents/BLOB/GetBlobEntity
id: v1BLOBAgent_GetBlobEntity
---

# POST Agents/BLOB/GetBlobEntity

```http
POST /api/v1/Agents/BLOB/GetBlobEntity
```

Gets a BlobEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| blobEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/BLOB/GetBlobEntity?blobEntityId=50
POST /api/v1/Agents/BLOB/GetBlobEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/BLOB/GetBlobEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 597,
  "BlobSize": 238,
  "Description": "Integrated clear-thinking instruction set",
  "ExtraInfo": "et",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "dolor",
  "OriginalSize": 598,
  "CreatedDate": "2010-10-30T18:28:48.1555453+02:00",
  "UpdatedDate": "2012-03-24T18:28:48.1555453+01:00",
  "CreatedBy": {
    "AssociateId": 821,
    "Name": "Raynor, Pfannerstill and Moen",
    "PersonId": 533,
    "Rank": 144,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 211,
    "FullName": "Kali Stiedemann IV",
    "FormalName": "Barrows-Kutch",
    "Deleted": true,
    "EjUserId": 13,
    "UserName": "Zulauf, Kutch and Aufderhar",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 103
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 735,
    "Name": "Spinka-Fisher",
    "PersonId": 406,
    "Rank": 317,
    "Tooltip": "molestias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 370,
    "FullName": "Pascale Walsh",
    "FormalName": "McCullough LLC",
    "Deleted": false,
    "EjUserId": 360,
    "UserName": "Welch Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 384
      }
    }
  },
  "ConceptualType": "consequatur",
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
      "FieldLength": 622
    }
  }
}
```