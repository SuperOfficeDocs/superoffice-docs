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
  "BlobId": 267,
  "BlobSize": 270,
  "Description": "Business-focused systematic product",
  "ExtraInfo": "recusandae",
  "IsEncrypted": false,
  "IsZipped": false,
  "MimeType": "quae",
  "OriginalSize": 145,
  "CreatedDate": "1997-10-07T18:25:51.4061181+02:00",
  "UpdatedDate": "2015-05-24T18:25:51.4061181+02:00",
  "CreatedBy": {
    "AssociateId": 888,
    "Name": "Oberbrunner Group",
    "PersonId": 30,
    "Rank": 835,
    "Tooltip": "dignissimos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 388,
    "FullName": "Nicole Schultz",
    "FormalName": "Eichmann-Krajcik",
    "Deleted": false,
    "EjUserId": 47,
    "UserName": "Stroman, Lakin and Rippin"
  },
  "UpdatedBy": {
    "AssociateId": 329,
    "Name": "Monahan, Pacocha and Johnston",
    "PersonId": 519,
    "Rank": 597,
    "Tooltip": "eaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 53,
    "FullName": "Mara Botsford",
    "FormalName": "Skiles, Hilll and Gorczany",
    "Deleted": false,
    "EjUserId": 822,
    "UserName": "Parisian, Waelchi and Auer"
  },
  "ConceptualType": "officia"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 996,
  "BlobSize": 265,
  "Description": "Implemented multi-tasking parallelism",
  "ExtraInfo": "porro",
  "IsEncrypted": true,
  "IsZipped": true,
  "MimeType": "ad",
  "OriginalSize": 356,
  "CreatedDate": "1996-09-30T18:25:51.4091181+02:00",
  "UpdatedDate": "2016-03-19T18:25:51.4091181+01:00",
  "CreatedBy": {
    "AssociateId": 538,
    "Name": "Rath Group",
    "PersonId": 318,
    "Rank": 638,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 793,
    "FullName": "Edyth Ferry",
    "FormalName": "Rippin-Armstrong",
    "Deleted": false,
    "EjUserId": 651,
    "UserName": "Roob LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 959
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 940,
    "Name": "Will Inc and Sons",
    "PersonId": 709,
    "Rank": 450,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 998,
    "FullName": "Leanne Hermann",
    "FormalName": "Bradtke-Rice",
    "Deleted": true,
    "EjUserId": 792,
    "UserName": "Predovic-Kemmer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 302
      }
    }
  },
  "ConceptualType": "et",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "maximize value-added e-services"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 318
    }
  }
}
```