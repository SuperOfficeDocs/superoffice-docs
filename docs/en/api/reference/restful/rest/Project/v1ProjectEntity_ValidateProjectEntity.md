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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 597,
  "Name": "Jewess-Mayert",
  "ProjectNumber": "1147568",
  "ProjectMembers": [
    {
      "ProjectmemberId": 906,
      "ContactId": 15,
      "ProjectId": 375,
      "ContactName": "Denesik-Hane",
      "ContactDepartment": "",
      "ProjectName": "McLaughlin, Rempel and Franecki",
      "EmailId": 314,
      "EmailAddress": "rafaela@luettgen.com",
      "CountryId": 781,
      "Firstname": "Durward",
      "MiddleName": "Schuster, Rosenbaum and Borer",
      "Lastname": "Schultz",
      "PersonId": 348,
      "Mrmrs": "laborum",
      "ProjectMemberTypeName": "Ankunding, Kuhn and Lind",
      "Phone": "(307)915-2485 x419",
      "PhoneId": 463,
      "ProjectMemberTypeId": 912,
      "EmailAddressName": "genevieve.wolff@jastconnelly.uk",
      "Comment": "occaecati",
      "FullName": "Prof. Rey Littel"
    }
  ],
  "Urls": [
    {
      "Value": "ea",
      "StrippedValue": "quasi",
      "Description": "Streamlined radical emulation"
    },
    {
      "Value": "ea",
      "StrippedValue": "quasi",
      "Description": "Streamlined radical emulation"
    }
  ],
  "CreatedDate": "1996-03-19T14:19:10.521726+01:00",
  "UpdatedDate": "2001-01-27T14:19:10.521726+01:00",
  "Description": "Monitored client-driven leverage",
  "Postit": "corrupti",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Seamless attitude-oriented Graphic Interface",
  "ActiveStatusMonitorId": 650,
  "Links": [
    {
      "EntityName": "Thiel Inc and Sons",
      "Id": 402,
      "Description": "Re-engineered 24 hour extranet",
      "ExtraInfo": "suscipit",
      "LinkId": 673
    },
    {
      "EntityName": "Thiel Inc and Sons",
      "Id": 402,
      "Description": "Re-engineered 24 hour extranet",
      "ExtraInfo": "suscipit",
      "LinkId": 673
    }
  ],
  "ActiveLinks": 71,
  "Completed": false,
  "NextMilestoneDate": "2005-12-06T14:19:10.521726+01:00",
  "NmdAppointmentId": 684,
  "EndDate": "2019-04-07T14:19:10.521726+02:00",
  "ActiveErpLinks": 707,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Jamil Bradtke",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "molestiae",
    "ExtraFields2": "repudiandae"
  },
  "CustomFields": {
    "CustomFields1": "nesciunt",
    "CustomFields2": "explicabo"
  },
  "PublishEventDate": "2017-05-30T14:19:10.521726+02:00",
  "PublishTo": "2019-07-06T14:19:10.521726+02:00",
  "PublishFrom": "2016-05-15T14:19:10.521726+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "corporis",
  "2": "aut"
}
```