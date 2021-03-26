---
title: POST Document/{id}/Command/{command}
id: v1DocumentEntity_ExecuteDocumentCommand
---

# POST Document/{id}/Command/{command}

```http
POST /api/v1/Document/{documentId}/Command/{command}
```

Execute a custom command on a particular document, optionally a particular version






| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | SuperOffice document ID **Required** |
| command | string | Command name, generally matching one of those returned from the GetDocumentCommands service. However, it is legal for document plugins to support commands that are not declared through GetDocumentCommands, for instance if a custom GUI needs to access plugin functionality. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| versionId | string |  Version ID if applicable/desired; a blank value implies "latest" version and is always acceptable. |
| allowedReturnTypes | array |  List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.&lt;br/&gt;Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.&lt;br/&gt;An empty array implies that the client places no restriction on possible return action requests. |
| additionalData | array |  Any additional data that the document command needs. This parameter can be used as a tunnel between a custom-programmed GUI and its plugin.&lt;br/&gt;It is suggested that the format is name=value, with one such pair per array item. |

```http
POST /api/v1/Document/{documentId}/Command/{command}?versionId=explicabo
POST /api/v1/Document/{documentId}/Command/{command}?allowedReturnTypes=Message
POST /api/v1/Document/{documentId}/Command/{command}?additionalData=Lorax
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
| ExternalReference | string |  |
| VersionId | string |  |
| Success | bool |  |
| Type | string |  |
| Value | string |  |
| AdditionalInfo | string |  |

## Sample Request

```http!
POST /api/v1/Document/{documentId}/Command/{command}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ExternalReference": "dolor",
  "VersionId": "delectus",
  "Success": false,
  "Type": "CustomGui",
  "Value": "sequi",
  "AdditionalInfo": "sapiente"
}
```