---
title: POST Project/Validate
uid: v1ProjectEntity_ValidateProjectEntity
generated: true
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
| ProjectId | Integer | Primary key |
| Name | String | Project name |
| ProjectNumber | String | Automatically generated number |
| ProjectMembers | Array | The persons which are members of the project |
| Urls | Array | The project's internet adresses |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated date  in UTC. |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | Boolean | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | String | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for project |
| Links | Array | List of all elements linked to the project |
| ActiveLinks | Integer | Number of active links to documents, other appointments, and such |
| Completed | Boolean | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | String | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | Integer | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | String | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/Project/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 782,
  "Name": "Jacobs-Jenkins",
  "ProjectNumber": "1199069",
  "ProjectMembers": [
    {
      "ProjectmemberId": 15,
      "ContactId": 689,
      "ProjectId": 126,
      "ContactName": "Adams LLC",
      "ContactDepartment": "",
      "ProjectName": "Runolfsson, Cremin and Gutmann",
      "EmailId": 182,
      "EmailAddress": "jeramy@webertowne.co.uk",
      "CountryId": 185,
      "Firstname": "Julia",
      "MiddleName": "O'Reilly, Walker and Sanford",
      "Lastname": "Fisher",
      "PersonId": 309,
      "Mrmrs": "magni",
      "ProjectMemberTypeName": "Dickinson Group",
      "Phone": "143-518-2719 x1176",
      "PhoneId": 348,
      "ProjectMemberTypeId": 142,
      "EmailAddressName": "minerva@jaskolski.co.uk",
      "Comment": "illo",
      "FullName": "Dr. Nathen Magnus Ward"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "adipisci",
      "Description": "Down-sized intermediate emulation"
    },
    {
      "Value": "qui",
      "StrippedValue": "adipisci",
      "Description": "Down-sized intermediate emulation"
    }
  ],
  "CreatedDate": "2004-07-19T13:57:19.1090601+02:00",
  "UpdatedDate": "1998-06-27T13:57:19.1090601+02:00",
  "Description": "Intuitive logistical info-mediaries",
  "Postit": "sint",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Total high-level hierarchy",
  "ActiveStatusMonitorId": 80,
  "Links": [
    {
      "EntityName": "Streich Group",
      "Id": 53,
      "Description": "Compatible grid-enabled complexity",
      "ExtraInfo": "omnis",
      "LinkId": 477
    },
    {
      "EntityName": "Streich Group",
      "Id": 53,
      "Description": "Compatible grid-enabled complexity",
      "ExtraInfo": "omnis",
      "LinkId": 477
    }
  ],
  "ActiveLinks": 537,
  "Completed": false,
  "NextMilestoneDate": "2019-09-14T13:57:19.1090601+02:00",
  "NmdAppointmentId": 337,
  "EndDate": "2011-09-19T13:57:19.1090601+02:00",
  "ActiveErpLinks": 32,
  "UserDefinedFields": {
    "SuperOffice:1": "Malvina D'Amore",
    "SuperOffice:2": "Mrs. Carlie O'Conner"
  },
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "minima",
    "CustomFields2": "quasi"
  },
  "PublishEventDate": "2022-06-02T13:57:19.1090601+02:00",
  "PublishTo": "2017-04-24T13:57:19.1090601+02:00",
  "PublishFrom": "2018-01-20T13:57:19.1090601+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "atque",
  "2": "sunt"
}
```