---
title: DEL Document/{id}/Lock
id: v1DocumentEntity_UndoCheckoutDocument
---

# DEL Document/{id}/Lock

```http
DELETE /api/v1/Document/{documentId}/Lock
```

Undo (abandon) a checkout






| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | SuperOffice document ID **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| allowedReturnTypes | array |  List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.&lt;br/&gt;Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.&lt;br/&gt;An empty array implies that the client places no restriction on possible return action requests. |

```http
DELETE /api/v1/Document/{documentId}/Lock?allowedReturnTypes=Message
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
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
DELETE /api/v1/Document/{documentId}/Lock
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ExternalReference": "aut",
  "VersionId": "aut",
  "Success": false,
  "Type": "CustomGui",
  "Value": "rerum",
  "AdditionalInfo": "dolor"
}
```