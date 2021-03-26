---
title: POST Agents/List/GetConsentPurpose
id: v1ListAgent_GetConsentPurpose
---

# POST Agents/List/GetConsentPurpose

```http
POST /api/v1/Agents/List/GetConsentPurpose
```

Gets a ConsentPurpose object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| consentPurposeId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetConsentPurpose?consentPurposeId=277
POST /api/v1/Agents/List/GetConsentPurpose?$select=name,department,category/id
```


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
POST /api/v1/Agents/List/GetConsentPurpose
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 94,
  "Name": "Erdman LLC",
  "ConsentText": "temporibus",
  "FormText": "eos",
  "Key": "rerum",
  "Tooltip": "necessitatibus",
  "Active": 65,
  "UpdatedDate": "2011-07-21T16:48:29.7679255+02:00",
  "UpdatedBy": {
    "AssociateId": 62,
    "Name": "Ullrich-Cormier",
    "PersonId": 684,
    "Rank": 445,
    "Tooltip": "adipisci",
    "Type": "AnonymousAssociate",
    "GroupIdx": 804,
    "FullName": "Mr. Alaina Swaniawski",
    "FormalName": "Connelly-Fritsch",
    "Deleted": false,
    "EjUserId": 777,
    "UserName": "O'Conner, Boyle and Simonis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 345
      }
    }
  },
  "Deleted": true,
  "Rank": 687,
  "PrivacyStatementDesc": "fugiat",
  "PrivacyStatementUrl": "http://www.example.com/",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "brand turn-key e-commerce"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 478
    }
  }
}
```