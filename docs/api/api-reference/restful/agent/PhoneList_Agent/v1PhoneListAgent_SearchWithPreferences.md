---
title: SearchWithPreferences
id: v1PhoneListAgent_SearchWithPreferences
---

# SearchWithPreferences

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SearchString": "repellendus",
  "Preferences": {
    "SearchCompany": true,
    "SearchFirstname": false,
    "SearchLastname": false,
    "SearchDepartment": false,
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
    "PersonDirectPhone": "676-257-3864",
    "PersonCellPhone": "(654)373-7386",
    "PersonPrivatePhone": "523.426.6055",
    "PersonFaxNumber": "917152",
    "PersonPagerNumber": "1101189",
    "PersonEmail": "valentin_cummerata@zemlakgoodwin.co.uk",
    "Id": 848,
    "Name": "Cummerata Group",
    "Tooltip": "laborum",
    "UniqueId": "voluptatum",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "target back-end platforms"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 562
      }
    }
  }
]
```