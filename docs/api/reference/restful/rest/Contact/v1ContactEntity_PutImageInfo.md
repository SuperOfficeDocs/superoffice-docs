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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "BlobId": 439,
  "BlobSize": 87,
  "Description": "Cross-platform zero administration monitoring",
  "ExtraInfo": "nam",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "rem",
  "OriginalSize": 412,
  "CreatedDate": "1995-03-25T18:25:50.1946246+01:00",
  "UpdatedDate": "2009-03-17T18:25:50.1946246+01:00",
  "CreatedBy": {
    "AssociateId": 726,
    "Name": "Schaefer Inc and Sons",
    "PersonId": 699,
    "Rank": 119,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 985,
    "FullName": "Armani Kirlin",
    "FormalName": "Kerluke Inc and Sons",
    "Deleted": true,
    "EjUserId": 596,
    "UserName": "Macejkovic Group"
  },
  "UpdatedBy": {
    "AssociateId": 298,
    "Name": "Conroy, Nienow and Green",
    "PersonId": 903,
    "Rank": 250,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 273,
    "FullName": "Miss Selina Oberbrunner",
    "FormalName": "Kautzer, Reichel and O'Kon",
    "Deleted": false,
    "EjUserId": 990,
    "UserName": "Connelly Inc and Sons"
  },
  "ConceptualType": "minus"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 662,
  "BlobSize": 731,
  "Description": "Fundamental contextually-based software",
  "ExtraInfo": "non",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "rerum",
  "OriginalSize": 117,
  "CreatedDate": "2007-09-01T18:25:50.1966245+02:00",
  "UpdatedDate": "2005-05-18T18:25:50.1966245+02:00",
  "CreatedBy": {
    "AssociateId": 864,
    "Name": "Brakus, Nolan and Powlowski",
    "PersonId": 723,
    "Rank": 286,
    "Tooltip": "numquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 383,
    "FullName": "Jakob Larkin",
    "FormalName": "Reinger, Bruen and Barrows",
    "Deleted": true,
    "EjUserId": 159,
    "UserName": "Prohaska LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 239
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 101,
    "Name": "Yost, Mante and Murphy",
    "PersonId": 876,
    "Rank": 249,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 189,
    "FullName": "Ms. Baylee Davis",
    "FormalName": "Huels-Stehr",
    "Deleted": true,
    "EjUserId": 98,
    "UserName": "Leuschke, West and Collier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 311
      }
    }
  },
  "ConceptualType": "quia",
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
      "FieldLength": 515
    }
  }
}
```