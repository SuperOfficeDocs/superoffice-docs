---
title: POST Agents/BLOB/SaveBlobEntity
id: v1BLOBAgent_SaveBlobEntity
---

# POST Agents/BLOB/SaveBlobEntity

```http
POST /api/v1/Agents/BLOB/SaveBlobEntity
```

Updates the existing BlobEntity or creates a new BlobEntity if the id parameter is empty








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

## Request Body: entity  

The BlobEntity to be saved. 

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
POST /api/v1/Agents/BLOB/SaveBlobEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "BlobId": 602,
  "BlobSize": 322,
  "Description": "Extended solution-oriented database",
  "ExtraInfo": "voluptatibus",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "laborum",
  "OriginalSize": 485,
  "CreatedDate": "2000-11-05T16:48:28.7852071+01:00",
  "UpdatedDate": "2019-09-18T16:48:28.7852071+02:00",
  "CreatedBy": {
    "AssociateId": 362,
    "Name": "Shields Inc and Sons",
    "PersonId": 564,
    "Rank": 984,
    "Tooltip": "veniam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 359,
    "FullName": "Marilyne Stanton",
    "FormalName": "Friesen, Cronin and Dietrich",
    "Deleted": true,
    "EjUserId": 121,
    "UserName": "Herman-Beatty"
  },
  "UpdatedBy": {
    "AssociateId": 33,
    "Name": "Pacocha LLC",
    "PersonId": 226,
    "Rank": 200,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 965,
    "FullName": "Salvatore Hilpert PhD",
    "FormalName": "Hilpert-Smitham",
    "Deleted": false,
    "EjUserId": 884,
    "UserName": "Rippin Group"
  },
  "ConceptualType": "in"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 632,
  "BlobSize": 826,
  "Description": "Networked stable installation",
  "ExtraInfo": "nihil",
  "IsEncrypted": false,
  "IsZipped": true,
  "MimeType": "et",
  "OriginalSize": 789,
  "CreatedDate": "2000-04-25T16:48:28.7871992+02:00",
  "UpdatedDate": "1994-04-03T16:48:28.7871992+02:00",
  "CreatedBy": {
    "AssociateId": 830,
    "Name": "Pagac, Schaden and Kertzmann",
    "PersonId": 874,
    "Rank": 817,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 449,
    "FullName": "Orlando Becker",
    "FormalName": "Conn Inc and Sons",
    "Deleted": true,
    "EjUserId": 300,
    "UserName": "Kreiger LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 906
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 973,
    "Name": "Schoen, Zboncak and Kulas",
    "PersonId": 346,
    "Rank": 940,
    "Tooltip": "sapiente",
    "Type": "AnonymousAssociate",
    "GroupIdx": 582,
    "FullName": "Ezekiel Cronin",
    "FormalName": "Pfeffer, Hansen and Kassulke",
    "Deleted": true,
    "EjUserId": 148,
    "UserName": "O'Conner LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 490
      }
    }
  },
  "ConceptualType": "quas",
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
      "FieldLength": 902
    }
  }
}
```