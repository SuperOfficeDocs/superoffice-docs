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
  "BlobId": 619,
  "BlobSize": 402,
  "Description": "Enhanced homogeneous secured line",
  "ExtraInfo": "ullam",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "repudiandae",
  "OriginalSize": 387,
  "CreatedDate": "2021-03-31T18:28:48.1515438+02:00",
  "UpdatedDate": "2014-10-13T18:28:48.1515438+02:00",
  "CreatedBy": {
    "AssociateId": 724,
    "Name": "Jewess, Ferry and Stehr",
    "PersonId": 328,
    "Rank": 923,
    "Tooltip": "repellendus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 114,
    "FullName": "Ibrahim Terry",
    "FormalName": "Treutel-Kuhlman",
    "Deleted": false,
    "EjUserId": 55,
    "UserName": "Hermann, Beer and Lueilwitz"
  },
  "UpdatedBy": {
    "AssociateId": 637,
    "Name": "Sporer-Hessel",
    "PersonId": 569,
    "Rank": 698,
    "Tooltip": "occaecati",
    "Type": "AnonymousAssociate",
    "GroupIdx": 910,
    "FullName": "Laurie Hoppe",
    "FormalName": "Beier LLC",
    "Deleted": false,
    "EjUserId": 236,
    "UserName": "Morissette-Parisian"
  },
  "ConceptualType": "a"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 250,
  "BlobSize": 481,
  "Description": "Grass-roots transitional framework",
  "ExtraInfo": "incidunt",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "iure",
  "OriginalSize": 221,
  "CreatedDate": "2000-07-01T18:28:48.1535429+02:00",
  "UpdatedDate": "2006-07-18T18:28:48.1535429+02:00",
  "CreatedBy": {
    "AssociateId": 313,
    "Name": "Feest, Jacobson and Glover",
    "PersonId": 222,
    "Rank": 728,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 619,
    "FullName": "Cassidy Pagac",
    "FormalName": "Kessler, Koelpin and Leffler",
    "Deleted": true,
    "EjUserId": 530,
    "UserName": "Lehner, Schiller and Rutherford",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 974
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 897,
    "Name": "Smith-Fahey",
    "PersonId": 727,
    "Rank": 609,
    "Tooltip": "tempora",
    "Type": "AnonymousAssociate",
    "GroupIdx": 297,
    "FullName": "Darius Feil",
    "FormalName": "Littel LLC",
    "Deleted": true,
    "EjUserId": 500,
    "UserName": "Lubowitz, Grimes and Gleichner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 255
      }
    }
  },
  "ConceptualType": "omnis",
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
      "FieldLength": 756
    }
  }
}
```