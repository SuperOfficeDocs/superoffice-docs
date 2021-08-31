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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 07 Jul 1999 15:05:41 G7T

{
  "BlobId": 767,
  "BlobSize": 720,
  "Description": "Innovative responsive Graphical User Interface",
  "ExtraInfo": "eum",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "itaque",
  "OriginalSize": 684,
  "CreatedDate": "2005-09-15T15:05:41.8070108+02:00",
  "UpdatedDate": "1999-07-07T15:05:41.8070108+02:00",
  "CreatedBy": {
    "AssociateId": 528,
    "Name": "Paucek, Christiansen and Strosin",
    "PersonId": 272,
    "Rank": 258,
    "Tooltip": "vel",
    "Type": "AnonymousAssociate",
    "GroupIdx": 314,
    "FullName": "Lemuel Kuhic",
    "FormalName": "Rohan, Waters and Kirlin",
    "Deleted": false,
    "EjUserId": 454,
    "UserName": "Gleason Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 178
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 810,
    "Name": "Parisian, Hirthe and Johnson",
    "PersonId": 238,
    "Rank": 231,
    "Tooltip": "quam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 861,
    "FullName": "Christian Yundt",
    "FormalName": "Hauck, Klein and Kuhic",
    "Deleted": false,
    "EjUserId": 903,
    "UserName": "Ferry, Kuphal and Carter",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 532
      }
    }
  },
  "ConceptualType": "aut",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "deploy one-to-one infomediaries"
      },
      "FieldType": "System.String",
      "FieldLength": 894
    }
  }
}
```