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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "BlobId": 417,
  "BlobSize": 378,
  "Description": "Sharable global circuit",
  "ExtraInfo": "dolor",
  "IsEncrypted": false,
  "IsZipped": true,
  "MimeType": "non",
  "OriginalSize": 416,
  "CreatedDate": "2003-09-09T15:05:41.8080056+02:00",
  "UpdatedDate": "1998-04-03T15:05:41.8080056+02:00",
  "CreatedBy": {
    "AssociateId": 483,
    "Name": "Mante Inc and Sons",
    "PersonId": 563,
    "Rank": 893,
    "Tooltip": "odit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 415,
    "FullName": "Alfonzo Heidenreich",
    "FormalName": "Borer LLC",
    "Deleted": false,
    "EjUserId": 642,
    "UserName": "Mertz, Heidenreich and Lebsack"
  },
  "UpdatedBy": {
    "AssociateId": 79,
    "Name": "Hane, Beahan and Prosacco",
    "PersonId": 484,
    "Rank": 669,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 885,
    "FullName": "Abner Schroeder",
    "FormalName": "Weimann, Conn and Orn",
    "Deleted": true,
    "EjUserId": 311,
    "UserName": "Jacobs, Carter and Connelly"
  },
  "ConceptualType": "mollitia"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 881,
  "BlobSize": 752,
  "Description": "Polarised client-driven strategy",
  "ExtraInfo": "sit",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "molestiae",
  "OriginalSize": 485,
  "CreatedDate": "2006-10-10T15:05:41.8220321+02:00",
  "UpdatedDate": "2014-08-10T15:05:41.8220321+02:00",
  "CreatedBy": {
    "AssociateId": 891,
    "Name": "Parker, Wehner and Bins",
    "PersonId": 54,
    "Rank": 205,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 179,
    "FullName": "Dustin Blanda",
    "FormalName": "Kris-Green",
    "Deleted": true,
    "EjUserId": 724,
    "UserName": "Ullrich, Leuschke and Hagenes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 889
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 578,
    "Name": "Hyatt, Will and Ebert",
    "PersonId": 177,
    "Rank": 783,
    "Tooltip": "iusto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 194,
    "FullName": "Jeanne Huels",
    "FormalName": "Hermann-Wyman",
    "Deleted": false,
    "EjUserId": 615,
    "UserName": "Breitenberg LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 763
      }
    }
  },
  "ConceptualType": "aliquid",
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
      "FieldLength": 167
    }
  }
}
```