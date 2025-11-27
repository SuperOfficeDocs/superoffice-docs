---
title: PATCH CopilotDataSource/{id}
uid: v1CopilotDataSourceEntity_PatchCopilotDataSourceEntity
generated: true
content_type: reference
---

# PATCH CopilotDataSource/{id}

```http
PATCH /api/v1/CopilotDataSource/{id}
```

Update a CopilotDataSourceEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.


See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>.
NsApiSlow threshold: 1000 ms.


## Experimental: ## The AI agent is experimental, subject to change, and not intended for partners. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IAIAgent} service SaveCopilotDataSourceEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The CopilotDataSourceEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/CopilotDataSource/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | String | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | String | The property names to modify.  "/users/0/email", "/users/-", |
| value | Object | New/Replaced value - string or object. |

## Response:

CopilotDataSourceEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | CopilotDataSourceEntity  updated. |
| 404 | CopilotDataSourceEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because CopilotDataSourceEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: CopilotDataSourceEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| CopilotDataSourceId | int32 | Primary key |
| CopilotDataSourceType | string | Type of copilot data source |
| CopilotId | int32 | The associated copilot |
| Description | string | Description of data source |
| Name | string | Name of data source |
| Settings | array | Collection of data source settings |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

[!include[sample request](../../samples/rest/request/v1CopilotDataSourceEntity_PatchCopilotDataSourceEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1CopilotDataSourceEntity_PatchCopilotDataSourceEntity.md)]