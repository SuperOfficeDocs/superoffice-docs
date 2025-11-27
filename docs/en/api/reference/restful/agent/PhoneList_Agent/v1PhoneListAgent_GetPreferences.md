---
title: POST Agents/PhoneList/GetPreferences
uid: v1PhoneListAgent_GetPreferences
generated: true
content_type: reference
---

# POST Agents/PhoneList/GetPreferences

```http
POST /api/v1/Agents/PhoneList/GetPreferences
```

Getting Phone List Preferences from the CRM 5 user preferences


NsApiSlow threshold: 1000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/PhoneList/GetPreferences?$select=name,department,category/id
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PhoneListPreferences

| Property Name | Type |  Description |
|----------------|------|--------------|
| SearchCompany | bool | True if you want to search for Companies by their name. |
| SearchFirstname | bool | True if you want to search for Persons by their firstname. |
| SearchLastname | bool | True if you want to search for Persons by their lastname. |
| SearchDepartment | bool | True if you want to search for Departments where your colleagues work. |
| SearchModeCompany | string | The Company name search type, e.g. BeginsWith, Contains, Endswith, Matches |
| SearchModeDepartment | string | The Department search type, e.g. BeginsWith, Contains, Endswith, Matches |
| SearchModeFirstname | string | The firstname search type, e.g. BeginsWith, Contains, Endswith, Matches |
| SearchModeLastname | string | The lastname search type, e.g. BeginsWith, Contains, Endswith, Matches |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1PhoneListAgent_GetPreferences.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1PhoneListAgent_GetPreferences.md)]