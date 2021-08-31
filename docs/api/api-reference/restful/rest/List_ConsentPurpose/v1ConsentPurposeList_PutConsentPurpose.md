---
title: PUT List/ConsentPurpose/Items/{id}
id: v1ConsentPurposeList_PutConsentPurpose
---

# PUT List/ConsentPurpose/Items/{id}

```http
PUT /api/v1/List/ConsentPurpose/Items/{id}
```

Updates the existing ConsentPurpose

Calls the List agent service SaveConsentPurpose.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of ConsentPurpose to be saved. **Required** |



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

## Request Body: entity  

The details of ConsentPurpose to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentPurposeId | int32 | Primary key |
| Name | string | Name of consent purpose |
| ConsentText | string | Form text used for the actual checkbox |
| FormText | string | Text for the consent form, the long text to be shown when asking the end-user for this kind of consent |
| Key | string | The key used to refer to this purpose, like #Process, #Emarketing etc. |
| Tooltip | string | List item tooltip |
| Active | int32 | Is the consent purpose active or not |
| UpdatedDate | date-time | The date the consent purpose was last updated  in UTC. |
| UpdatedBy |  | The associate that last updated the consent purpose |
| Deleted | bool | true if the ConsentPurpose is deleted |
| Rank | int32 | Rank of this consent source |
| PrivacyStatementDesc | string | Name or description for the privacy statement |
| PrivacyStatementUrl | string | Url referencing the actual privacy statement |


## Response: object

Carrier object for ConsentPurpose.
Services for the ConsentPurpose Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentPurposeId | int32 | Primary key |
| Name | string | Name of consent purpose |
| ConsentText | string | Form text used for the actual checkbox |
| FormText | string | Text for the consent form, the long text to be shown when asking the end-user for this kind of consent |
| Key | string | The key used to refer to this purpose, like #Process, #Emarketing etc. |
| Tooltip | string | List item tooltip |
| Active | int32 | Is the consent purpose active or not |
| UpdatedDate | date-time | The date the consent purpose was last updated  in UTC. |
| UpdatedBy |  | The associate that last updated the consent purpose |
| Deleted | bool | true if the ConsentPurpose is deleted |
| Rank | int32 | Rank of this consent source |
| PrivacyStatementDesc | string | Name or description for the privacy statement |
| PrivacyStatementUrl | string | Url referencing the actual privacy statement |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
PUT /api/v1/List/ConsentPurpose/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 295,
  "Name": "Rowe LLC",
  "ConsentText": "voluptatem",
  "FormText": "modi",
  "Key": "soluta",
  "Tooltip": "dicta",
  "Active": 941,
  "UpdatedDate": "2000-09-21T15:05:43.3345398+02:00",
  "UpdatedBy": {
    "AssociateId": 686,
    "Name": "Collier-Denesik",
    "PersonId": 453,
    "Rank": 923,
    "Tooltip": "suscipit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 984,
    "FullName": "Kayleigh Batz",
    "FormalName": "Zboncak-Gerlach",
    "Deleted": false,
    "EjUserId": 362,
    "UserName": "Champlin LLC"
  },
  "Deleted": true,
  "Rank": 20,
  "PrivacyStatementDesc": "totam",
  "PrivacyStatementUrl": "http://www.example.com/"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 241,
  "Name": "Langworth-Jast",
  "ConsentText": "et",
  "FormText": "neque",
  "Key": "consequatur",
  "Tooltip": "libero",
  "Active": 944,
  "UpdatedDate": "2011-10-15T15:05:43.3355422+02:00",
  "UpdatedBy": {
    "AssociateId": 486,
    "Name": "Boyer, Morissette and Huels",
    "PersonId": 252,
    "Rank": 400,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 222,
    "FullName": "Violette Kuhlman",
    "FormalName": "Schmeler Group",
    "Deleted": false,
    "EjUserId": 819,
    "UserName": "Cartwright, Haley and Doyle",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 417
      }
    }
  },
  "Deleted": false,
  "Rank": 480,
  "PrivacyStatementDesc": "assumenda",
  "PrivacyStatementUrl": "http://www.example.com/",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "iterate viral experiences"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 245
    }
  }
}
```