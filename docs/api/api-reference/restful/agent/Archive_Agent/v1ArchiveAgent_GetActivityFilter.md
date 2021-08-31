---
title: GetActivityFilter
id: v1ArchiveAgent_GetActivityFilter
---

# GetActivityFilter

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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "1995-12-17T14:58:03.2185688+01:00",
  "ToDate": "2011-10-09T14:58:03.2185688+02:00",
  "AssociateList": [
    {
      "Id": 430,
      "Name": "Gerlach, Stamm and Cole",
      "ToolTip": "Iure asperiores in vitae eveniet aut distinctio.",
      "Deleted": true,
      "Rank": 585,
      "Type": "est",
      "ColorBlock": 807,
      "IconHint": "cupiditate",
      "Selected": true,
      "LastChanged": "1996-05-20T14:58:03.2185688+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "perferendis",
      "Hidden": true,
      "FullName": "Mrs. Eli Cole",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 67
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 963,
      "Name": "Watsica-Haley",
      "ToolTip": "Omnis eligendi id repellendus excepturi.",
      "Deleted": false,
      "Rank": 779,
      "Type": "sunt",
      "ColorBlock": 319,
      "IconHint": "iste",
      "Selected": false,
      "LastChanged": "2010-04-26T14:58:03.2195685+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quas",
      "StyleHint": "aut",
      "Hidden": true,
      "FullName": "Dr. Esta Pfannerstill",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 394
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 618,
      "Name": "Mraz-Zieme",
      "ToolTip": "Corrupti ab ut nam voluptatem ipsa.",
      "Deleted": false,
      "Rank": 70,
      "Type": "qui",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "maiores",
      "ColorBlock": 815,
      "ExtraInfo": "harum",
      "StyleHint": "eaque",
      "FullName": "Assunta Kihn",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 224
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
      "FieldLength": 163
    }
  }
}
```