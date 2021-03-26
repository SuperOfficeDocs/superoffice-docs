---
title: POST Agents/PhoneList/SearchWithPreferences
id: v1PhoneListAgent_SearchWithPreferences
---

# POST Agents/PhoneList/SearchWithPreferences

```http
POST /api/v1/Agents/PhoneList/SearchWithPreferences
```

Searching the phone list.

Search is based on the supplied preferences.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/PhoneList/SearchWithPreferences?$select=name,department,category/id
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

SearchString, Preferences 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SearchString | string |  |
| Preferences |  | Search preferences for a phone list search <para /> Carrier object for PhoneListPreferences. Services for the PhoneListPreferences Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPhoneListAgent">PhoneList Agent</see>. |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonDirectPhone | string | Person Direct Phone |
| PersonCellPhone | string | Person Cell Phone |
| PersonPrivatePhone | string | Person Private Phone |
| PersonFaxNumber | string | Actual phone number as eneterd by the user |
| PersonPagerNumber | string | Actual phone number as eneterd by the user |
| PersonEmail | string | The address itself |
| Id | int32 | The contact or person's id |
| Name | string | The contact or person's name |
| Tooltip | string |  |
| UniqueId | string | Property setting a unique id indicating if this is a person or contact |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/PhoneList/SearchWithPreferences
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SearchString": "repellat",
  "Preferences": {
    "SearchCompany": true,
    "SearchFirstname": false,
    "SearchLastname": true,
    "SearchDepartment": true,
    "SearchModeCompany": "BeginsWith",
    "SearchModeDepartment": "BeginsWith",
    "SearchModeFirstname": "BeginsWith",
    "SearchModeLastname": "BeginsWith"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonDirectPhone": "222.384.5500 x71003",
    "PersonCellPhone": "454-376-1578 x8567",
    "PersonPrivatePhone": "1-621-703-5773 x5214",
    "PersonFaxNumber": "1710803",
    "PersonPagerNumber": "1144896",
    "PersonEmail": "rowan@jacobi.com",
    "Id": 574,
    "Name": "Prosacco LLC",
    "Tooltip": "mollitia",
    "UniqueId": "a",
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
        "FieldLength": 165
      }
    }
  }
]
```