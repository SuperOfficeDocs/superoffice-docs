---
title: POST User/{id}/CustomCommand/{commandName}
id: v1User_ExecuteUserCommand
---

# POST User/{id}/CustomCommand/{commandName}

```http
POST /api/v1/User/{id}/CustomCommand/{commandName}
```

Executes a custom command for User



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The User to execute commands on. **Required** |
| commandName | string | The name of the command to execute. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| actionResult | Enum: Implicit, Yes, Ok, No, Cancel |  Result of an UI operation (Implicit,Yes,Ok,No,Cancel). Input to the command. |

```http
POST /api/v1/User/{id}/CustomCommand/{commandName}?actionResult=Cancel
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 404 | User with given id does not exist in the db. |
| 400 | Bad request. Entity to save is not in request body. |