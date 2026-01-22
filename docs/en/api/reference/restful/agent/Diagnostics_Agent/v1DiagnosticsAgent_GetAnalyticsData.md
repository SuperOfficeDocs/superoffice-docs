---
title: POST Agents/Diagnostics/GetAnalyticsData
uid: v1DiagnosticsAgent_GetAnalyticsData
generated: true
content_type: reference
---

# POST Agents/Diagnostics/GetAnalyticsData

```http
POST /api/v1/Agents/Diagnostics/GetAnalyticsData
```

Retrieve analytics properties to be included in usage tracking.


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Diagnostics/GetAnalyticsData?$select=name,department,category/id
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: AnalyticsData

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | User full name. Only included in Sod |
| Email | string | User email address. Only included in Sod |
| Company | string | User company name. Only included in Sod |
| LicenseStatus | UserAndInstallationLicenceStatus | Current license status of the user and installation |
| HasLicensce | object | Dictionary of license types and their status |
| SystemLicenseNames | array | Names of system licenses assigned to the user |
| UserSignedUpAt | string | Date and time when the user signed up |
| NumContact | int32 | Number of contacts associated with the user |
| NumPerson | int32 | Number of persons associated with the user |
| NumAppointment | int32 | Number of appointments for the user |
| NumSale | int32 | Number of sales associated with the user |
| NumProject | int32 | Number of projects associated with the user |
| NumSelection | int32 | Number of selections made by the user |
| NumEmailItem | int32 | Number of email items associated with the user |
| NumTicketLogAction | int32 | Number of ticket log actions performed by the user |
| NumDashboard | int32 | Number of dashboards available to the user |
| NumQuote | int32 | Number of quotes created by the user |
| NumQuoteLine | int32 | Number of quote lines associated with the user |
| NumDocument | int32 | Number of documents associated with the user |
| NumTargetAssignmentInfo | int32 | Number of target assignment info records |
| NumMailing | int32 | Number of mailings sent by the user |
| NumForm | int32 | Number of forms created by the user |
| NumWorkflow | int32 | Number of workflows associated with the user |
| TotContact | int32 | Total number of contacts in the system |
| TotPerson | int32 | Total number of persons in the system |
| TotAppointment | int32 | Total number of appointments in the system |
| TotSale | int32 | Total number of sales in the system |
| TotProject | int32 | Total number of projects in the system |
| TotSelection | int32 | Total number of selections in the system |
| TotEmailItem | int32 | Total number of email items in the system |
| TotTicketLogAction | int32 | Total number of ticket log actions in the system |
| TotDashboard | int32 | Total number of dashboards in the system |
| TotQuote | int32 | Total number of quotes in the system |
| TotQuoteLine | int32 | Total number of quote lines in the system |
| TotDocument | int32 | Total number of documents in the system |
| TotTargetAssignmentInfo | int32 | Total number of target assignment info records |
| TotMailing | int32 | Total number of mailings in the system |
| TotForm | int32 | Total number of forms in the system |
| TotWorkflow | int32 | Total number of workflows in the system |
| UserRegisteredAgeDays | int32 | Number of days since the user registered |
| UserCountryName | string | Name of the user's country |
| UserCountryCode | string | Country code of the user |
| Preferences | object | Array of user preferences (name and value) |
| TotWebUsers | int32 | Total number of web users in the system |
| GroupCountryName | string | Name of the group's country |
| GroupCountryCode | string | Country code of the group |
| GroupRegisteredDate | string | Date when the group was registered |
| GroupRegisteredAgeDays | int32 | Number of days since the group was registered |
| FeatureToggles | object | Array of feature toggles (name and enabled status) |
| FileVersion | string | Current file version as a string |
| FileVersionNumber | int32 | Current file version as a number |

## Sample request

[!include[sample request](../../samples/agent/request/v1DiagnosticsAgent_GetAnalyticsData.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1DiagnosticsAgent_GetAnalyticsData.md)]