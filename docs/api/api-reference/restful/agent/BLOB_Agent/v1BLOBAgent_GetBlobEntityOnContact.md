---
title: POST Agents/BLOB/GetBlobEntityOnContact
id: v1BLOBAgent_GetBlobEntityOnContact
---

# POST Agents/BLOB/GetBlobEntityOnContact

```http
POST /api/v1/Agents/BLOB/GetBlobEntityOnContact
```

Gets the blob entity that represents the contact image binary object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/BLOB/GetBlobEntityOnContact?$select=name,department,category/id
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

## Request Body: request  

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |


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
POST /api/v1/Agents/BLOB/GetBlobEntityOnContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 726
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 810,
  "BlobSize": 918,
  "Description": "Synergistic mission-critical circuit",
  "ExtraInfo": "eius",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "beatae",
  "OriginalSize": 481,
  "CreatedDate": "2003-04-26T16:48:28.8011632+02:00",
  "UpdatedDate": "2015-02-26T16:48:28.8011632+01:00",
  "CreatedBy": {
    "AssociateId": 28,
    "Name": "Heidenreich Group",
    "PersonId": 923,
    "Rank": 880,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 375,
    "FullName": "Stanton Bartoletti",
    "FormalName": "Grant LLC",
    "Deleted": true,
    "EjUserId": 82,
    "UserName": "Emmerich, Kreiger and Durgan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 862
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 112,
    "Name": "Auer, Hermiston and Grant",
    "PersonId": 415,
    "Rank": 396,
    "Tooltip": "consequuntur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 457,
    "FullName": "Zelma Strosin",
    "FormalName": "Skiles, Blick and Kub",
    "Deleted": true,
    "EjUserId": 282,
    "UserName": "Cartwright, Wehner and Jacobs",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 439
      }
    }
  },
  "ConceptualType": "illum",
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
      "FieldLength": 419
    }
  }
}
```