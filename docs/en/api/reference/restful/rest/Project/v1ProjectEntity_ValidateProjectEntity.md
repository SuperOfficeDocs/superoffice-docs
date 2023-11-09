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
  "ProjectId": 599,
  "Name": "Beatty LLC",
  "ProjectNumber": "1357570",
  "ProjectMembers": [
    {
      "ProjectmemberId": 85,
      "ContactId": 979,
      "ProjectId": 285,
      "ContactName": "White Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Ledner, Johnston and Hahn",
      "EmailId": 764,
      "EmailAddress": "francisco.cummerata@stanton.co.uk",
      "CountryId": 176,
      "Firstname": "Julien",
      "MiddleName": "Lind-Wiegand",
      "Lastname": "Fay",
      "PersonId": 774,
      "Mrmrs": "dolorum",
      "ProjectMemberTypeName": "Kub, Murphy and Hintz",
      "Phone": "1-047-911-9893",
      "PhoneId": 475,
      "ProjectMemberTypeId": 738,
      "EmailAddressName": "martine.lowe@raynor.co.uk",
      "Comment": "at",
      "FullName": "Adaline Dooley"
    }
  ],
  "Urls": [
    {
      "Value": "distinctio",
      "StrippedValue": "ullam",
      "Description": "Multi-channelled bifurcated help-desk"
    },
    {
      "Value": "distinctio",
      "StrippedValue": "ullam",
      "Description": "Multi-channelled bifurcated help-desk"
    }
  ],
  "CreatedDate": "2009-12-10T11:06:42.0666003+01:00",
  "UpdatedDate": "1997-09-09T11:06:42.0666003+02:00",
  "Description": "Automated client-driven utilisation",
  "Postit": "et",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Persevering 4th generation focus group",
  "ActiveStatusMonitorId": 768,
  "Links": [
    {
      "EntityName": "Nolan, Bergnaum and Marks",
      "Id": 750,
      "Description": "Fundamental client-driven workforce",
      "ExtraInfo": "fuga",
      "LinkId": 294
    },
    {
      "EntityName": "Nolan, Bergnaum and Marks",
      "Id": 750,
      "Description": "Fundamental client-driven workforce",
      "ExtraInfo": "fuga",
      "LinkId": 294
    }
  ],
  "ActiveLinks": 664,
  "Completed": false,
  "NextMilestoneDate": "2003-06-07T11:06:42.0666003+02:00",
  "NmdAppointmentId": 373,
  "EndDate": "2004-05-19T11:06:42.0666003+02:00",
  "ActiveErpLinks": 222,
  "UserDefinedFields": {
    "SuperOffice:1": "Miracle Collins",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "nemo"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "consequuntur"
  },
  "PublishEventDate": "2002-04-12T11:06:42.0666003+02:00",
  "PublishTo": "2010-02-09T11:06:42.0666003+01:00",
  "PublishFrom": "1997-05-18T11:06:42.0666003+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "ullam",
  "2": "alias"
}
```