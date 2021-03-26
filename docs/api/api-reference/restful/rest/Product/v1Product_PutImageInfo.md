---
title: PUT Product/{id}/ImageInfo
id: v1Product_PutImageInfo
---

# PUT Product/{id}/ImageInfo

```http
PUT /api/v1/Product/{productId}/ImageInfo
```

Update the Blob that describes the given person's picture.

The actual bitmap is accessible via /api/Services80/person/123/image.




| Path Part | Type | Description |
|-----------|------|-------------|
| productId | int32 | Product id **Required** |



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

New or Updated information about the product image. 

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
PUT /api/v1/Product/{productId}/ImageInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "BlobId": 909,
  "BlobSize": 907,
  "Description": "Monitored scalable capacity",
  "ExtraInfo": "et",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "similique",
  "OriginalSize": 900,
  "CreatedDate": "2008-01-30T09:40:59.9670645+01:00",
  "UpdatedDate": "2013-10-13T09:40:59.9670645+02:00",
  "CreatedBy": {
    "AssociateId": 566,
    "Name": "Mann-Purdy",
    "PersonId": 993,
    "Rank": 22,
    "Tooltip": "corporis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 189,
    "FullName": "Soledad Jewess",
    "FormalName": "Ruecker, Champlin and O'Reilly",
    "Deleted": false,
    "EjUserId": 135,
    "UserName": "Lowe LLC"
  },
  "UpdatedBy": {
    "AssociateId": 554,
    "Name": "Muller, Berge and Maggio",
    "PersonId": 41,
    "Rank": 289,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 140,
    "FullName": "Tania Russel",
    "FormalName": "Wisoky Group",
    "Deleted": false,
    "EjUserId": 11,
    "UserName": "Sipes-Gerlach"
  },
  "ConceptualType": "voluptatem"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 380,
  "BlobSize": 174,
  "Description": "Distributed scalable protocol",
  "ExtraInfo": "esse",
  "IsEncrypted": false,
  "IsZipped": true,
  "MimeType": "dignissimos",
  "OriginalSize": 543,
  "CreatedDate": "1997-10-27T09:40:59.968066+01:00",
  "UpdatedDate": "2010-10-04T09:40:59.968066+02:00",
  "CreatedBy": {
    "AssociateId": 336,
    "Name": "Franecki Group",
    "PersonId": 637,
    "Rank": 665,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 124,
    "FullName": "Catherine Yost",
    "FormalName": "Becker Group",
    "Deleted": true,
    "EjUserId": 612,
    "UserName": "Jenkins Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 377
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 427,
    "Name": "Reichert, Jerde and Rohan",
    "PersonId": 236,
    "Rank": 808,
    "Tooltip": "deserunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 50,
    "FullName": "Glenda Mitchell",
    "FormalName": "Volkman Group",
    "Deleted": true,
    "EjUserId": 72,
    "UserName": "Nolan, Cassin and Feest",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 834
      }
    }
  },
  "ConceptualType": "dignissimos",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "strategize sticky applications"
      },
      "FieldType": "System.Int32",
      "FieldLength": 973
    }
  }
}
```