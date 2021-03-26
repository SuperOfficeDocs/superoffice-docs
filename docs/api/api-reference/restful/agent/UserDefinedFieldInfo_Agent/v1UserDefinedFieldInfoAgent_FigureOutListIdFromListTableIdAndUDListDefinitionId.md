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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Info": {
    "UDefFieldId": 306,
    "ColumnId": 608,
    "FieldDefault": "aut",
    "FieldHeight": 667,
    "FieldLabel": "veniam",
    "FieldLeft": 570,
    "FieldTop": 743,
    "FieldType": "Checkbox",
    "FieldWidth": 281,
    "FormatMask": "et",
    "HideLabel": true,
    "IsIndexed": false,
    "LabelHeight": 264,
    "LabelLeft": 249,
    "LabelTop": 950,
    "LabelWidth": 160,
    "LastVersionId": 659,
    "ListTableId": 633,
    "IsMandatory": false,
    "Type": "Appointment",
    "Page1LineNo": 389,
    "ProgId": "pariatur",
    "IsReadOnly": true,
    "ShortLabel": "et",
    "TabOrder": 473,
    "TextLength": 446,
    "Tooltip": "consectetur",
    "UdefIdentity": 504,
    "UDListDefinitionId": 964,
    "Justification": "Center",
    "Version": 337,
    "TemplateVariableName": "Mante LLC",
    "HasBeenPublished": true,
    "MdoListName": "Gorczany, Schmitt and Gislason"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

890
```