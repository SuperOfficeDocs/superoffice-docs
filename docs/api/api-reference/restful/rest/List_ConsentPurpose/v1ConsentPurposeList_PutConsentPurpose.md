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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 747,
  "Name": "Lebsack-Macejkovic",
  "ConsentText": "assumenda",
  "FormText": "quaerat",
  "Key": "repellendus",
  "Tooltip": "quia",
  "Active": 572,
  "UpdatedDate": "2021-08-22T18:25:51.6652945+02:00",
  "UpdatedBy": {
    "AssociateId": 142,
    "Name": "Stehr LLC",
    "PersonId": 104,
    "Rank": 57,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 73,
    "FullName": "Tyson Kuhn",
    "FormalName": "Johns, McClure and Rutherford",
    "Deleted": false,
    "EjUserId": 718,
    "UserName": "Zboncak Inc and Sons"
  },
  "Deleted": false,
  "Rank": 255,
  "PrivacyStatementDesc": "voluptas",
  "PrivacyStatementUrl": "http://www.example.com/"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 535,
  "Name": "Kub, Steuber and Pacocha",
  "ConsentText": "maiores",
  "FormText": "ut",
  "Key": "asperiores",
  "Tooltip": "eos",
  "Active": 559,
  "UpdatedDate": "2010-06-28T18:25:51.6662945+02:00",
  "UpdatedBy": {
    "AssociateId": 45,
    "Name": "Jaskolski, Kuhic and Greenholt",
    "PersonId": 432,
    "Rank": 877,
    "Tooltip": "quibusdam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 724,
    "FullName": "Patience Pacocha",
    "FormalName": "Swift LLC",
    "Deleted": true,
    "EjUserId": 61,
    "UserName": "Hand Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 78
      }
    }
  },
  "Deleted": true,
  "Rank": 305,
  "PrivacyStatementDesc": "atque",
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
      "FieldLength": 372
    }
  }
}
```