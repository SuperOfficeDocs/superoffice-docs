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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 02 Aug 2021 18:25:50 G8T

{
  "BlobId": 349,
  "BlobSize": 674,
  "Description": "Re-contextualized coherent middleware",
  "ExtraInfo": "est",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "similique",
  "OriginalSize": 111,
  "CreatedDate": "2010-09-12T18:25:50.8518852+02:00",
  "UpdatedDate": "2021-08-02T18:25:50.8518852+02:00",
  "CreatedBy": {
    "AssociateId": 54,
    "Name": "Jast-Paucek",
    "PersonId": 467,
    "Rank": 12,
    "Tooltip": "animi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 907,
    "FullName": "Maria Schiller",
    "FormalName": "Mills-Block",
    "Deleted": false,
    "EjUserId": 961,
    "UserName": "Vandervort-Bradtke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 553
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 799,
    "Name": "Crist, Considine and Koepp",
    "PersonId": 459,
    "Rank": 371,
    "Tooltip": "repudiandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 480,
    "FullName": "Alvena Rath IV",
    "FormalName": "Rogahn Inc and Sons",
    "Deleted": false,
    "EjUserId": 849,
    "UserName": "Schowalter, Johnson and Okuneva",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 614
      }
    }
  },
  "ConceptualType": "voluptates",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "whiteboard one-to-one convergence"
      },
      "FieldType": "System.Int32",
      "FieldLength": 78
    }
  }
}
```