---
title: POST Agents/BLOB/GetBlobEntityOnProject
id: v1BLOBAgent_GetBlobEntityOnProject
---

# POST Agents/BLOB/GetBlobEntityOnProject

```http
POST /api/v1/Agents/BLOB/GetBlobEntityOnProject
```

Gets the blob entity that represents the project image binary object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/BLOB/GetBlobEntityOnProject?$select=name,department,category/id
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

ProjectId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 |  |


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
POST /api/v1/Agents/BLOB/GetBlobEntityOnProject
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 964
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 894,
  "BlobSize": 408,
  "Description": "Compatible human-resource paradigm",
  "ExtraInfo": "veritatis",
  "IsEncrypted": false,
  "IsZipped": false,
  "MimeType": "voluptas",
  "OriginalSize": 936,
  "CreatedDate": "2019-10-17T16:48:28.792199+02:00",
  "UpdatedDate": "1997-02-16T16:48:28.792199+01:00",
  "CreatedBy": {
    "AssociateId": 267,
    "Name": "O'Keefe, Gleichner and Orn",
    "PersonId": 403,
    "Rank": 406,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 242,
    "FullName": "Natasha Zulauf",
    "FormalName": "Conroy Group",
    "Deleted": true,
    "EjUserId": 100,
    "UserName": "Crona Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "empower viral eyeballs"
        },
        "FieldType": "System.String",
        "FieldLength": 517
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 153,
    "Name": "Doyle Inc and Sons",
    "PersonId": 975,
    "Rank": 32,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 22,
    "FullName": "Ms. Trenton Glover",
    "FormalName": "Fritsch-Vandervort",
    "Deleted": false,
    "EjUserId": 65,
    "UserName": "Kutch-Stamm",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 725
      }
    }
  },
  "ConceptualType": "maiores",
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
      "FieldLength": 441
    }
  }
}
```