---
title: GetNavigatorCompany
id: v1NavigatorAgent_GetNavigatorCompany
---

# GetNavigatorCompany

```http
POST /api/v1/Agents/Navigator/GetNavigatorCompany
```

Gets a NavigatorCompany object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| navigatorCompanyId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Navigator/GetNavigatorCompany?navigatorCompanyId=893
POST /api/v1/Agents/Navigator/GetNavigatorCompany?$select=name,department,category/id
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



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 |  |
| Value | string |  |
| Tooltip | string |  |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Navigator/GetNavigatorCompany
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 160,
  "Value": "eaque",
  "Tooltip": "illum",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "syndicate rich metrics"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "empower one-to-one niches"
      },
      "FieldType": "System.String",
      "FieldLength": 726
    }
  }
}
```