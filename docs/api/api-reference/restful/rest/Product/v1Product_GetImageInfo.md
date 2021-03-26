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
Last-Modified: Mon, 21 Dec 1998 09:40:59 G12T

{
  "BlobId": 979,
  "BlobSize": 327,
  "Description": "Multi-channelled national local area network",
  "ExtraInfo": "ea",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "molestiae",
  "OriginalSize": 883,
  "CreatedDate": "2012-06-27T09:40:59.9660647+02:00",
  "UpdatedDate": "1998-12-21T09:40:59.9660647+01:00",
  "CreatedBy": {
    "AssociateId": 812,
    "Name": "Koch Inc and Sons",
    "PersonId": 887,
    "Rank": 702,
    "Tooltip": "reiciendis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 673,
    "FullName": "Mr. Domenica Veum",
    "FormalName": "Jast, Nikolaus and Gutmann",
    "Deleted": false,
    "EjUserId": 845,
    "UserName": "Fahey-Kuhlman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 795
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 504,
    "Name": "Stokes-Langosh",
    "PersonId": 568,
    "Rank": 282,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 844,
    "FullName": "Reva Klocko",
    "FormalName": "Zulauf LLC",
    "Deleted": false,
    "EjUserId": 588,
    "UserName": "Fritsch-Kuhlman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 620
      }
    }
  },
  "ConceptualType": "voluptatum",
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
      "FieldLength": 823
    }
  }
}
```