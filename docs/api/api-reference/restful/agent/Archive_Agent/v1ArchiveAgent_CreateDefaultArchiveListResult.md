---
title: POST Agents/Archive/CreateDefaultArchiveListResult
id: v1ArchiveAgent_CreateDefaultArchiveListResult
---

# POST Agents/Archive/CreateDefaultArchiveListResult

```http
POST /api/v1/Agents/Archive/CreateDefaultArchiveListResult
```

Set default values into a new ArchiveListResult.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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

Header/Detail variant of archive result, with a Row Count plus the actual rows. Future extensions may include other header data on the same level as the RowCount



Carrier object for ArchiveListResult.
Services for the ArchiveListResult Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">Archive Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| RowCount | int32 | Count of rows, independent of paging. If you order up page 1 with page size 50, the row count may still be 279, that being the number of rows that would have been returned in a  paging-off situation |
| Rows | array | The actual rows, according to the paging info, of the result. See RowCount for a paging-independent count estimate |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Archive/CreateDefaultArchiveListResult
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RowCount": 237,
  "Rows": [
    {
      "EntityName": "Donnelly, Littel and Wunsch",
      "PrimaryKey": 726,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "voluptatum",
          "TooltipHint": "eos",
          "LinkHint": "atque"
        }
      },
      "LinkHint": "voluptatem",
      "StyleHint": "id",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 494
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
      "FieldLength": 375
    }
  }
}
```