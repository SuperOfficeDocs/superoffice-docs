---
title: GET Product/{id}/ImageInfo
id: v1Product_GetImageInfo
---

# GET Product/{id}/ImageInfo

```http
GET /api/v1/Product/{productId}/ImageInfo
```

Get the Blob that describes the given products picture.

The actual bitmap is accessible via /api/Services80/pricelist/1/product/123/image.




| Path Part | Type | Description |
|-----------|------|-------------|
| productId | int32 | Product id **Required** |



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
GET /api/v1/Product/{productId}/ImageInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 28 Dec 2003 18:25:51 G12T

{
  "BlobId": 840,
  "BlobSize": 615,
  "Description": "Up-sized mobile solution",
  "ExtraInfo": "amet",
  "IsEncrypted": false,
  "IsZipped": true,
  "MimeType": "similique",
  "OriginalSize": 205,
  "CreatedDate": "1998-09-25T18:25:51.4051179+02:00",
  "UpdatedDate": "2003-12-28T18:25:51.4051179+01:00",
  "CreatedBy": {
    "AssociateId": 449,
    "Name": "Barrows Inc and Sons",
    "PersonId": 280,
    "Rank": 302,
    "Tooltip": "veritatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 537,
    "FullName": "Jamaal Nicolas",
    "FormalName": "Lehner, Stoltenberg and Kemmer",
    "Deleted": true,
    "EjUserId": 126,
    "UserName": "Ankunding, Trantow and Pfeffer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 191
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 36,
    "Name": "Hauck, Konopelski and Altenwerth",
    "PersonId": 691,
    "Rank": 457,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 494,
    "FullName": "Will Bartell",
    "FormalName": "Adams, Huel and Romaguera",
    "Deleted": true,
    "EjUserId": 855,
    "UserName": "Kilback-Heller",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 935
      }
    }
  },
  "ConceptualType": "iste",
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
      "FieldLength": 165
    }
  }
}
```