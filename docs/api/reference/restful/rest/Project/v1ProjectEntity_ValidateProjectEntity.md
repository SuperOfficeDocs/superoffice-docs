---
title: POST Project/Validate
uid: v1ProjectEntity_ValidateProjectEntity
---

# POST Project/Validate

```http
POST /api/v1/Project/Validate
```

Check that entity is ready for saving, return error messages by field.








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

## Request Body: projectEntity  

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | bool | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | string | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for project |
| Links | array | List of all elements linked to the project |
| ActiveLinks | int32 | Number of active links to documents, other appointments, and such |
| Completed | bool | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | date-time | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | int32 | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | date-time | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |


## Response: object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample request

```http!
POST /api/v1/Project/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 864,
  "Name": "Toy Group",
  "ProjectNumber": "1850287",
  "ProjectMembers": [
    {
      "ProjectmemberId": 406,
      "ContactId": 295,
      "ProjectId": 556,
      "ContactName": "Considine Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Johns, Zboncak and Langworth",
      "EmailId": 631,
      "EmailAddress": "evan@fisherrogahn.info",
      "CountryId": 759,
      "Firstname": "Clovis",
      "MiddleName": "Shanahan-Davis",
      "Lastname": "Koch",
      "PersonId": 511,
      "Mrmrs": "quisquam",
      "ProjectMemberTypeName": "Littel, Mann and Mayer",
      "Phone": "(013)790-6923 x70677",
      "PhoneId": 43,
      "ProjectMemberTypeId": 729,
      "EmailAddressName": "camila@rohan.com",
      "Comment": "omnis",
      "FullName": "Dejuan Russel"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "nesciunt",
      "Description": "Re-contextualized transitional help-desk"
    },
    {
      "Value": "qui",
      "StrippedValue": "nesciunt",
      "Description": "Re-contextualized transitional help-desk"
    }
  ],
  "CreatedDate": "2010-10-24T02:49:51.3546907+02:00",
  "UpdatedDate": "2006-03-12T02:49:51.3546907+01:00",
  "Description": "Persevering zero administration portal",
  "Postit": "sunt",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Optimized logistical standardization",
  "ActiveStatusMonitorId": 521,
  "Links": [
    {
      "EntityName": "Wolf-McLaughlin",
      "Id": 901,
      "Description": "Advanced dynamic architecture",
      "ExtraInfo": "architecto",
      "LinkId": 375
    },
    {
      "EntityName": "Wolf-McLaughlin",
      "Id": 901,
      "Description": "Advanced dynamic architecture",
      "ExtraInfo": "architecto",
      "LinkId": 375
    }
  ],
  "ActiveLinks": 362,
  "Completed": true,
  "NextMilestoneDate": "2001-12-27T02:49:51.3703152+01:00",
  "NmdAppointmentId": 409,
  "EndDate": "2004-12-30T02:49:51.3703152+01:00",
  "ActiveErpLinks": 804,
  "UserDefinedFields": {
    "SuperOffice:1": "Deborah Harber",
    "SuperOffice:2": "Zakary Johann Klocko III"
  },
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "itaque"
  },
  "CustomFields": {
    "CustomFields1": "nobis",
    "CustomFields2": "id"
  },
  "PublishEventDate": "2022-10-07T02:49:51.3703152+02:00",
  "PublishTo": "2007-10-28T02:49:51.3703152+01:00",
  "PublishFrom": "2006-01-22T02:49:51.3703152+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "modi",
  "2": "magnam"
}
```