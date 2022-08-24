---
title: POST Agents/PhoneList/SetPreferences
id: v1PhoneListAgent_SetPreferences
---

# POST Agents/PhoneList/SetPreferences

```http
POST /api/v1/Agents/PhoneList/SetPreferences
```

Setting Phone List Preferences to the CRM 5 user preferences

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/PhoneList/SetPreferences?$select=name,department,category/id
```

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request

Preferences

| Property Name | Type |  Description |
|----------------|------|--------------|
| Preferences |  | Search preferences for a phone list search <br /> Carrier object for PhoneListPreferences. Services for the PhoneListPreferences Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPhoneListAgent">PhoneList Agent</see>. |

## Response

| Response | Description |
|----------------|-------------|
| 204 | No Content |
