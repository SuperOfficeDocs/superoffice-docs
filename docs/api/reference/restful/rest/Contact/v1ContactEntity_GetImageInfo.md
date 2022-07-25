---
title: GET Contact/{id}/Imageinfo
id: v1ContactEntity_GetImageInfo
---

# GET Contact/{id}/Imageinfo

```http
GET /api/v1/Contact/{contactId}/Imageinfo
```

Get the Blob that describes the given contact's picture.

The actual bitmap is accessible via /api/v1/contact/123/image.

| Path Part | Type | Description |
|-----------|------|-------------|
| contactId | int32 | Contact id **Required** |

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
GET /api/v1/Contact/{contactId}/Imageinfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 16 Apr 2007 18:25:50 G4T

{
  "BlobId": 607,
  "BlobSize": 543,
  "Description": "Right-sized intermediate ability",
  "ExtraInfo": "et",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "dignissimos",
  "OriginalSize": 624,
  "CreatedDate": "2020-03-19T18:25:50.1936244+01:00",
  "UpdatedDate": "2007-04-16T18:25:50.1936244+02:00",
  "CreatedBy": {
    "AssociateId": 177,
    "Name": "West Group",
    "PersonId": 611,
    "Rank": 461,
    "Tooltip": "deserunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 730,
    "FullName": "Lisa Crist III",
    "FormalName": "Sanford, Hamill and Considine",
    "Deleted": true,
    "EjUserId": 504,
    "UserName": "Kulas-Adams",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "productize customized niches"
        },
        "FieldType": "System.Int32",
        "FieldLength": 685
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 261,
    "Name": "Lind, Bartoletti and Jenkins",
    "PersonId": 110,
    "Rank": 594,
    "Tooltip": "explicabo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 768,
    "FullName": "Mr. Alexandro Heaney",
    "FormalName": "Weissnat-Buckridge",
    "Deleted": true,
    "EjUserId": 477,
    "UserName": "Gulgowski-Hamill",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 28
      }
    }
  },
  "ConceptualType": "animi",
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
      "FieldLength": 471
    }
  }
}
```
