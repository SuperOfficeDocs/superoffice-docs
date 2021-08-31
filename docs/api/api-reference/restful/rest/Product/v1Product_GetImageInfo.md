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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 04 Jun 2008 15:05:43 G6T

{
  "BlobId": 772,
  "BlobSize": 798,
  "Description": "Re-contextualized 6th generation website",
  "ExtraInfo": "itaque",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "qui",
  "OriginalSize": 467,
  "CreatedDate": "2019-12-21T15:05:43.0456665+01:00",
  "UpdatedDate": "2008-06-04T15:05:43.0456665+02:00",
  "CreatedBy": {
    "AssociateId": 811,
    "Name": "Bauch-Walker",
    "PersonId": 165,
    "Rank": 123,
    "Tooltip": "accusantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 34,
    "FullName": "Royal Ondricka",
    "FormalName": "Fahey LLC",
    "Deleted": false,
    "EjUserId": 367,
    "UserName": "Douglas Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 182
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 436,
    "Name": "Leffler-Blick",
    "PersonId": 267,
    "Rank": 245,
    "Tooltip": "facilis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 748,
    "FullName": "Natalia Larkin IV",
    "FormalName": "Bahringer, Roberts and Schuppe",
    "Deleted": false,
    "EjUserId": 458,
    "UserName": "Kautzer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engineer one-to-one portals"
        },
        "FieldType": "System.String",
        "FieldLength": 498
      }
    }
  },
  "ConceptualType": "id",
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
      "FieldLength": 951
    }
  }
}
```