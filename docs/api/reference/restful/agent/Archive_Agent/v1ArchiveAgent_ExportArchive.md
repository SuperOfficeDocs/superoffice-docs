---
title: POST Agents/Archive/ExportArchive
id: v1ArchiveAgent_ExportArchive
---

# POST Agents/Archive/ExportArchive

```http
POST /api/v1/Agents/Archive/ExportArchive
```

Exports the target archive to a downloadable format.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/ExportArchive?$select=name,department,category/id
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

ProviderName, Context, DesiredEntities, Columns, SortOrder, Restrictions, ExportType, SelectedRowIds, EstimatedRowCount

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | string |  |
| Context | string |  |
| DesiredEntities | array |  |
| Columns | array |  |
| SortOrder | array |  |
| Restrictions | array |  |
| ExportType | string |  |
| SelectedRowIds | array |  |
| EstimatedRowCount | int32 |  |

## Response: object

Carrier object for ExportArchiveResult.
Services for the ExportArchiveResult Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">Archive Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| BatchTaskId | int32 | Id of the BatchTask created. &lt;=0 if no BatchTask was created. |
| FileName | string | The path to the output file created, if it exists. Will be an empty string if no file was created. |
| Message | string | Descriptive messages; errors, etc. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Archive/ExportArchive
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Purdy Inc and Sons",
  "Context": "fugiat",
  "DesiredEntities": [
    "ut",
    "aut"
  ],
  "Columns": [
    "est",
    "et"
  ],
  "SortOrder": [
    {
      "Name": "Hettinger, Schiller and Lakin",
      "Direction": "ASC"
    },
    {
      "Name": "Hettinger, Schiller and Lakin",
      "Direction": "ASC"
    }
  ],
  "Restrictions": [
    {
      "Name": "Durgan, Kling and Vandervort",
      "Operator": "sed",
      "Values": [
        "voluptatibus",
        "aut"
      ],
      "DisplayValues": [
        "enim",
        "saepe"
      ],
      "ColumnInfo": {},
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 73,
      "InterOperator": "And",
      "UniqueHash": 667
    }
  ],
  "ExportType": "sint",
  "SelectedRowIds": [
    "aliquid",
    "architecto"
  ],
  "EstimatedRowCount": 126
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BatchTaskId": 223,
  "FileName": "Baumbach, Barton and Stark",
  "Message": "dolores",
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
      "FieldLength": 835
    }
  }
}
```
