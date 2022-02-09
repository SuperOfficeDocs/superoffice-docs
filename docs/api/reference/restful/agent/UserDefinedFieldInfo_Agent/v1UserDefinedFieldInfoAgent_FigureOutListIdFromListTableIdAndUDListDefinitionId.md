---
title: POST Agents/UserDefinedFieldInfo/FigureOutListIdFromListTableIdAndUDListDefinitionId
id: v1UserDefinedFieldInfoAgent_FigureOutListIdFromListTableIdAndUDListDefinitionId
---

# POST Agents/UserDefinedFieldInfo/FigureOutListIdFromListTableIdAndUDListDefinitionId

```http
POST /api/v1/Agents/UserDefinedFieldInfo/FigureOutListIdFromListTableIdAndUDListDefinitionId
```

Kind of the reverse of SetListTableIdAndUDListDefinitionIdFromSelectedListId







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/UserDefinedFieldInfo/FigureOutListIdFromListTableIdAndUDListDefinitionId?$select=name,department,category/id
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

Info 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Info |  | Return information about the user defined fields. The information can be used to mirror the layout of the user-defined fields in the user interface. <para /> Carrier object for UserDefinedFieldInfo. Services for the UserDefinedFieldInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserDefinedFieldInfoAgent">UserDefinedFieldInfo Agent</see>. |


## Response: int32



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: int32


## Sample Request

```http!
POST /api/v1/Agents/UserDefinedFieldInfo/FigureOutListIdFromListTableIdAndUDListDefinitionId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Info": {
    "UDefFieldId": 842,
    "ColumnId": 667,
    "FieldDefault": "qui",
    "FieldHeight": 420,
    "FieldLabel": "et",
    "FieldLeft": 377,
    "FieldTop": 439,
    "FieldType": "Checkbox",
    "FieldWidth": 937,
    "FormatMask": "delectus",
    "HideLabel": true,
    "IsIndexed": true,
    "LabelHeight": 330,
    "LabelLeft": 234,
    "LabelTop": 578,
    "LabelWidth": 776,
    "LastVersionId": 456,
    "ListTableId": 253,
    "IsMandatory": true,
    "Type": "Appointment",
    "Page1LineNo": 501,
    "ProgId": "laboriosam",
    "IsReadOnly": true,
    "ShortLabel": "nam",
    "TabOrder": 908,
    "TextLength": 434,
    "Tooltip": "et",
    "UdefIdentity": 513,
    "UDListDefinitionId": 154,
    "Justification": "Center",
    "Version": 122,
    "TemplateVariableName": "McGlynn Inc and Sons",
    "HasBeenPublished": false,
    "MdoListName": "Morar-Gutmann"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

871
```