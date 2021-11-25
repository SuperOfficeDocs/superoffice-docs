---
title: POST List/ConsentPurpose/Items
id: v1ConsentPurposeList_PostConsentPurpose
---

# POST List/ConsentPurpose/Items

```http
POST /api/v1/List/ConsentPurpose/Items
```

Create a new ConsentPurpose list item

Calls the List agent service SaveConsentPurpose.






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

## Request Body: newEntity  

The ConsentPurpose to be created. 

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
POST /api/v1/List/ConsentPurpose/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 273,
  "Name": "Hamill-Emard",
  "ConsentText": "veritatis",
  "FormText": "quis",
  "Key": "eius",
  "Tooltip": "veniam",
  "Active": 991,
  "UpdatedDate": "2015-12-13T18:25:51.6622944+01:00",
  "UpdatedBy": {
    "AssociateId": 540,
    "Name": "Hane LLC",
    "PersonId": 562,
    "Rank": 992,
    "Tooltip": "saepe",
    "Type": "AnonymousAssociate",
    "GroupIdx": 36,
    "FullName": "Max Cassin",
    "FormalName": "Stark, Cole and Beatty",
    "Deleted": true,
    "EjUserId": 868,
    "UserName": "Beier Group"
  },
  "Deleted": false,
  "Rank": 890,
  "PrivacyStatementDesc": "nihil",
  "PrivacyStatementUrl": "http://www.example.com/"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 771,
  "Name": "Dickinson Inc and Sons",
  "ConsentText": "ex",
  "FormText": "suscipit",
  "Key": "unde",
  "Tooltip": "ipsam",
  "Active": 438,
  "UpdatedDate": "2010-11-15T18:25:51.6632949+01:00",
  "UpdatedBy": {
    "AssociateId": 466,
    "Name": "Feest-Ankunding",
    "PersonId": 873,
    "Rank": 138,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 516,
    "FullName": "Kelli Dach",
    "FormalName": "Turcotte-Kozey",
    "Deleted": true,
    "EjUserId": 44,
    "UserName": "Spencer Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 741
      }
    }
  },
  "Deleted": true,
  "Rank": 577,
  "PrivacyStatementDesc": "et",
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
      "FieldLength": 568
    }
  }
}
```