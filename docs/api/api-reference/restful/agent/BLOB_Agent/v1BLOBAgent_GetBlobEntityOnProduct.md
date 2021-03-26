---
title: POST Agents/BLOB/GetBlobEntityOnProduct
id: v1BLOBAgent_GetBlobEntityOnProduct
---

# POST Agents/BLOB/GetBlobEntityOnProduct

```http
POST /api/v1/Agents/BLOB/GetBlobEntityOnProduct
```

Gets the blob entity that represents the product image binary object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/BLOB/GetBlobEntityOnProduct?$select=name,department,category/id
```


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

## Request Body: request  

ProductId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProductId | int32 |  |


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
POST /api/v1/Agents/BLOB/GetBlobEntityOnProduct
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProductId": 82
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 47,
  "BlobSize": 633,
  "Description": "Robust holistic interface",
  "ExtraInfo": "occaecati",
  "IsEncrypted": true,
  "IsZipped": false,
  "MimeType": "sed",
  "OriginalSize": 599,
  "CreatedDate": "2001-03-20T16:48:28.7972021+01:00",
  "UpdatedDate": "2009-02-18T16:48:28.7972021+01:00",
  "CreatedBy": {
    "AssociateId": 944,
    "Name": "Mayert, Denesik and Sporer",
    "PersonId": 274,
    "Rank": 64,
    "Tooltip": "ipsam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 814,
    "FullName": "Rebeka Gutkowski",
    "FormalName": "Larkin Inc and Sons",
    "Deleted": false,
    "EjUserId": 767,
    "UserName": "Brakus Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 787
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 94,
    "Name": "Homenick LLC",
    "PersonId": 750,
    "Rank": 845,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 346,
    "FullName": "Alvis Leuschke",
    "FormalName": "Farrell, Cole and Hahn",
    "Deleted": false,
    "EjUserId": 663,
    "UserName": "Doyle, Emmerich and Botsford",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 833
      }
    }
  },
  "ConceptualType": "laboriosam",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "streamline e-business functionalities"
      },
      "FieldType": "System.String",
      "FieldLength": 968
    }
  }
}
```