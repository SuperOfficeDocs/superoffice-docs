---
title: POST Agents/Person/CreateOrUpdateUserCandidate
uid: v1PersonAgent_CreateOrUpdateUserCandidate
generated: true
---

# POST Agents/Person/CreateOrUpdateUserCandidate

```http
POST /api/v1/Agents/Person/CreateOrUpdateUserCandidate
```

Creates a Customer Centre User (UserCandidate) for a given Contact (personId) with the supplied parameters.


If the Customer Centre User already exists for a given Contact, the user is updated with the supplied parameters.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateOrUpdateUserCandidate?$select=name,department,category/id
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

PersonId, Username, AccessAllRequests 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer |  |
| Username | String |  |
| AccessAllRequests | Boolean |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: UserCandidate

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserCandidateId | int32 | Primary key |
| PersonId | int32 | Foreign key. Id of a person representing Customer Center User. |
| SecretKey | string | Username of a Customer Centre User. |
| SecretValue | string | Password of a Customer Centre User. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/CreateOrUpdateUserCandidate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 560,
  "Username": "voluptas",
  "AccessAllRequests": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UserCandidateId": 775,
  "PersonId": 281,
  "SecretKey": "ab",
  "SecretValue": "quasi",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 500
    }
  }
}
```