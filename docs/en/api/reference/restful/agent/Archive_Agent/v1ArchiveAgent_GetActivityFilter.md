---
title: POST Agents/Archive/GetActivityFilter
uid: v1ArchiveAgent_GetActivityFilter
generated: true
---

# POST Agents/Archive/GetActivityFilter

```http
POST /api/v1/Agents/Archive/GetActivityFilter
```

Get activity filter for the specified list.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetActivityFilter?$select=name,department,category/id
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

### Response body: ActivityFilter

| Property Name | Type |  Description |
|----------------|------|--------------|
| FromDate | date-time | The filtering From date |
| ToDate | date-time | The filtering To date |
| AssociateList | array | The list of associates to filter on |
| GroupList | array | The list of groups to filter on |
| FutureDateList | array | The list of future date selections. This is a static MDO list with standard values. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Archive/GetActivityFilter
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2019-07-23T11:44:32.7599049+02:00",
  "ToDate": "2001-06-16T11:44:32.7599049+02:00",
  "AssociateList": [
    {
      "Id": 528,
      "Name": "Medhurst-Medhurst",
      "ToolTip": "Error perspiciatis quasi et cupiditate.",
      "Deleted": false,
      "Rank": 85,
      "Type": "quam",
      "ColorBlock": 773,
      "IconHint": "quis",
      "Selected": true,
      "LastChanged": "2011-12-09T11:44:32.7599049+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "officia",
      "Hidden": false,
      "FullName": "Ayden Conn Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 198
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 190,
      "Name": "Beahan Group",
      "ToolTip": "Unde incidunt atque sit cupiditate.",
      "Deleted": false,
      "Rank": 685,
      "Type": "impedit",
      "ColorBlock": 871,
      "IconHint": "eaque",
      "Selected": false,
      "LastChanged": "2019-10-23T11:44:32.7599049+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "iusto",
      "Hidden": true,
      "FullName": "Eliane Rutherford",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 333,
      "Name": "Mayert LLC",
      "ToolTip": "Vero dolor enim non sequi magni.",
      "Deleted": false,
      "Rank": 133,
      "Type": "ab",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "iste",
      "ColorBlock": 459,
      "ExtraInfo": "quasi",
      "StyleHint": "distinctio",
      "FullName": "Ms. Izaiah Veda Ritchie III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 961
    }
  }
}
```