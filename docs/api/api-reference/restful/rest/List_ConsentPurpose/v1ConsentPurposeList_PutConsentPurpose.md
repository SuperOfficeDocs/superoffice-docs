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
  "ConsentPurposeId": 376,
  "Name": "Treutel, Runte and Rowe",
  "ConsentText": "aut",
  "FormText": "magnam",
  "Key": "optio",
  "Tooltip": "sit",
  "Active": 450,
  "UpdatedDate": "2014-01-06T09:41:00.260369+01:00",
  "UpdatedBy": {
    "AssociateId": 140,
    "Name": "Bins, Gutmann and Tromp",
    "PersonId": 148,
    "Rank": 122,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 351,
    "FullName": "Everette Walter",
    "FormalName": "Stroman, Weber and Schinner",
    "Deleted": true,
    "EjUserId": 33,
    "UserName": "Bauch, Simonis and Hudson"
  },
  "Deleted": false,
  "Rank": 977,
  "PrivacyStatementDesc": "libero",
  "PrivacyStatementUrl": "http://www.example.com/"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 800,
  "Name": "Pouros, Mitchell and Schaden",
  "ConsentText": "neque",
  "FormText": "explicabo",
  "Key": "quia",
  "Tooltip": "et",
  "Active": 356,
  "UpdatedDate": "2004-06-06T09:41:00.262371+02:00",
  "UpdatedBy": {
    "AssociateId": 456,
    "Name": "Hirthe, O'Keefe and Lesch",
    "PersonId": 455,
    "Rank": 921,
    "Tooltip": "provident",
    "Type": "AnonymousAssociate",
    "GroupIdx": 640,
    "FullName": "Tyree Farrell",
    "FormalName": "Tillman, Quigley and McLaughlin",
    "Deleted": true,
    "EjUserId": 988,
    "UserName": "Auer Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "syndicate transparent methodologies"
        },
        "FieldType": "System.String",
        "FieldLength": 459
      }
    }
  },
  "Deleted": true,
  "Rank": 979,
  "PrivacyStatementDesc": "ut",
  "PrivacyStatementUrl": "http://www.example.com/",
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
      "FieldLength": 854
    }
  }
}
```