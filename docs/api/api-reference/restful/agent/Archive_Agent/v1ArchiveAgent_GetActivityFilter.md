---
title: POST Agents/Archive/GetActivityFilter
id: v1ArchiveAgent_GetActivityFilter
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


## Response: object

Activity list filter information.



Carrier object for ActivityFilter.
Services for the ActivityFilter Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">Archive Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| FromDate | date-time | The filtering From date |
| ToDate | date-time | The filtering To date |
| AssociateList | array | The list of associates to filter on |
| GroupList | array | The list of groups to filter on |
| FutureDateList | array | The list of future date selections. This is a static MDO list with standard values. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Archive/GetActivityFilter
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2010-08-25T16:48:28.7194195+02:00",
  "ToDate": "2019-09-10T16:48:28.7194195+02:00",
  "AssociateList": [
    {
      "Id": 49,
      "Name": "Ruecker-Senger",
      "ToolTip": "Deserunt fugiat deserunt.",
      "Deleted": true,
      "Rank": 226,
      "Type": "quasi",
      "ColorBlock": 566,
      "IconHint": "sunt",
      "Selected": true,
      "LastChanged": "2001-05-19T16:48:28.7194195+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "quaerat",
      "Hidden": false,
      "FullName": "Zola Fritsch",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "aggregate rich models"
          },
          "FieldType": "System.Int32",
          "FieldLength": 590
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 340,
      "Name": "Torphy, Johns and Crona",
      "ToolTip": "Consequatur pariatur.",
      "Deleted": false,
      "Rank": 328,
      "Type": "dolorem",
      "ColorBlock": 275,
      "IconHint": "ipsum",
      "Selected": false,
      "LastChanged": "1999-02-18T16:48:28.7204189+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "eveniet",
      "Hidden": false,
      "FullName": "Furman Lueilwitz",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 463
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 622,
      "Name": "Oberbrunner-Swaniawski",
      "ToolTip": "Qui eum eos sequi quis.",
      "Deleted": false,
      "Rank": 252,
      "Type": "modi",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "provident",
      "ColorBlock": 730,
      "ExtraInfo": "velit",
      "StyleHint": "officia",
      "FullName": "Myrna Marks",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 940
        }
      }
    }
  ],
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
      "FieldType": "System.Int32",
      "FieldLength": 390
    }
  }
}
```