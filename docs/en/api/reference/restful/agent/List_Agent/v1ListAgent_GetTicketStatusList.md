---
title: POST Agents/List/GetTicketStatusList
uid: v1ListAgent_GetTicketStatusList
---

# POST Agents/List/GetTicketStatusList

```http
POST /api/v1/Agents/List/GetTicketStatusList
```

Gets an array of TicketStatusEntity objects.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetTicketStatusList?$select=name,department,category/id
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

## Request Body: ticketStatusEntityIds 

The primary keys. 


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketStatusId | int32 | The primary key (auto-incremented) |
| Name | string | Name of user defined ticket status |
| Status | string | The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted |
| TimeCounter | string | Which field in ticket we count time spent on (queue, internal, external) |
| NoEmailReopen | bool | Whether inbound emails can reopen requests with this status or not |
| IsDefault | bool | Indicates if status is default one as there might be more than one status with same internal status |
| UsedInQueue | bool | If set, status is used in GetNext calculations |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/GetTicketStatusList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TicketStatusId": 701,
    "Name": "Emard-Feil",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": false,
    "IsDefault": false,
    "UsedInQueue": false,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 281
      }
    }
  }
]
```