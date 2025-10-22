---
title: POST Agents/AI/AnalyzeBizCardImage
uid: v1AIAgent_AnalyzeBizCardImage
generated: true
content_type: reference
---

# POST Agents/AI/AnalyzeBizCardImage

```http
POST /api/v1/Agents/AI/AnalyzeBizCardImage
```

Returns contact and person information from an image.

Merges results with matching database records if merge = true

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/AI/AnalyzeBizCardImage?$select=name,department,category/id
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

Image, MergeWithDatabase

| Property Name | Type |  Description |
|----------------|------|--------------|
| Image | String |  |
| MergeWithDatabase | Boolean |  |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: BizCard

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact | ContactEntity | The contact information. |
| Person | PersonEntity | The person information. |
| LogoImage | string | Base64 encoded company logo image, if available. |
| PhotoImage | string | Base64 encoded person photo image, if available. |

## Sample request

[!include[sample request](../../../../../../../../../api-reference/samples/rest/request/v1AIAgent_AnalyzeBizCardImage.md)]

## Sample response

[!include[sample response](../../../../../../../../../api-reference/samples/rest/request/v1AIAgent_AnalyzeBizCardImage.md)]
