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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 943,
  "Name": "Mann, Murazik and Goyette",
  "ConsentText": "consectetur",
  "FormText": "vitae",
  "Key": "eos",
  "Tooltip": "molestiae",
  "Active": 664,
  "UpdatedDate": "2001-12-09T09:41:00.257362+01:00",
  "UpdatedBy": {
    "AssociateId": 109,
    "Name": "Schumm LLC",
    "PersonId": 840,
    "Rank": 606,
    "Tooltip": "in",
    "Type": "AnonymousAssociate",
    "GroupIdx": 676,
    "FullName": "Hershel Emard",
    "FormalName": "Trantow, Rogahn and Spencer",
    "Deleted": true,
    "EjUserId": 461,
    "UserName": "Murazik-Dach"
  },
  "Deleted": false,
  "Rank": 195,
  "PrivacyStatementDesc": "error",
  "PrivacyStatementUrl": "http://www.example.com/"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 305,
  "Name": "Schimmel-Kunze",
  "ConsentText": "quo",
  "FormText": "voluptas",
  "Key": "consequatur",
  "Tooltip": "sit",
  "Active": 365,
  "UpdatedDate": "2020-02-07T09:41:00.2583636+01:00",
  "UpdatedBy": {
    "AssociateId": 261,
    "Name": "Lindgren, Cassin and Rutherford",
    "PersonId": 599,
    "Rank": 632,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 848,
    "FullName": "Ali Hermann",
    "FormalName": "Greenholt-Bartoletti",
    "Deleted": true,
    "EjUserId": 327,
    "UserName": "Feil, Parker and Vandervort",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "leverage end-to-end networks"
        },
        "FieldType": "System.Int32",
        "FieldLength": 409
      }
    }
  },
  "Deleted": false,
  "Rank": 14,
  "PrivacyStatementDesc": "eius",
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
      "FieldLength": 299
    }
  }
}
```