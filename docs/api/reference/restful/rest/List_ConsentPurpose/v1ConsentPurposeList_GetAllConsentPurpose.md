---
title: GET List/ConsentPurpose/Items
id: v1ConsentPurposeList_GetAllConsentPurpose
---

# GET List/ConsentPurpose/Items

```http
GET /api/v1/List/ConsentPurpose/Items
```

Gets a list of all ConsentPurpose list items.

Calls the List agent service GetAllConsentPurpose.






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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
GET /api/v1/List/ConsentPurpose/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ConsentPurposeId": 833,
    "Name": "Ebert Group",
    "ConsentText": "et",
    "FormText": "architecto",
    "Key": "eum",
    "Tooltip": "et",
    "Active": 899,
    "UpdatedDate": "2012-12-22T18:25:51.6612947+01:00",
    "UpdatedBy": {
      "AssociateId": 9,
      "Name": "Kassulke Inc and Sons",
      "PersonId": 285,
      "Rank": 202,
      "Tooltip": "assumenda",
      "Type": "AnonymousAssociate",
      "GroupIdx": 839,
      "FullName": "Uriel Dare MD",
      "FormalName": "Harber Inc and Sons",
      "Deleted": true,
      "EjUserId": 105,
      "UserName": "Runolfsdottir-Auer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    },
    "Deleted": false,
    "Rank": 303,
    "PrivacyStatementDesc": "at",
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
        "FieldType": "System.String",
        "FieldLength": 73
      }
    }
  }
]
```