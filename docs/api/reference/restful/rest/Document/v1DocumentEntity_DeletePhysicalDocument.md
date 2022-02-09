---
title: DEL Document/{id}/Content
id: v1DocumentEntity_DeletePhysicalDocument
---

# DEL Document/{id}/Content

```http
DELETE /api/v1/Document/{documentId}/Content
```

Delete the document contents






| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | document primary key **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| allowedReturnType | array |  List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing. Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.&lt;br/&gt;An empty array implies that the client places no restriction on possible return action requests |

```http
DELETE /api/v1/Document/{documentId}/Content?allowedReturnType=Message
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
DELETE /api/v1/Document/{documentId}/Content
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ExternalReference": "et",
  "VersionId": "dicta",
  "Success": true,
  "Type": "CustomGui",
  "Value": "perspiciatis",
  "AdditionalInfo": "soluta"
}
```