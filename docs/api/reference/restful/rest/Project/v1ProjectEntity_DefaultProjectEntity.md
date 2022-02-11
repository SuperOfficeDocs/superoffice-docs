---
title: GET Project/default
id: v1ProjectEntity_DefaultProjectEntity
---

# GET Project/default

```http
GET /api/v1/Project/default
```

Set default values into a new ProjectEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Project agent service CreateDefaultProjectEntity.






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


## Response: object

The Project Service. The service implements all services working with the Project object



Carrier object for ProjectEntity.
Services for the ProjectEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IProjectAgent">Project Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/Project/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 10 Aug 2004 18:25:50 G8T

{
  "ProjectId": 813,
  "Name": "Grady, Shanahan and Dare",
  "ProjectNumber": "366946",
  "ProjectMembers": [
    {
      "ProjectmemberId": 574,
      "ContactId": 714,
      "ProjectId": 4,
      "ContactName": "Medhurst-Monahan",
      "ContactDepartment": "",
      "ProjectName": "Hegmann-Watsica",
      "EmailId": 756,
      "EmailAddress": "julia_robel@mckenziekeebler.name",
      "CountryId": 727,
      "Firstname": "Amber",
      "MiddleName": "Rippin Group",
      "Lastname": "Marquardt",
      "PersonId": 110,
      "Mrmrs": "ab",
      "ProjectMemberTypeName": "Brown, Maggio and Fisher",
      "Phone": "(414)232-2357 x061",
      "PhoneId": 54,
      "ProjectMemberTypeId": 23,
      "EmailAddressName": "gabriella@huels.com",
      "Comment": "aut",
      "FullName": "Miss Jazmyne Lind",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 371
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "blanditiis",
      "Description": "Enhanced disintermediate capacity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 465
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "blanditiis",
      "Description": "Enhanced disintermediate capacity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 465
        }
      }
    }
  ],
  "CreatedDate": "2009-03-28T18:25:50.7938837+01:00",
  "UpdatedDate": "2004-08-10T18:25:50.7938837+02:00",
  "Description": "De-engineered exuding analyzer",
  "Postit": "voluptatibus",
  "CreatedBy": {
    "AssociateId": 592,
    "Name": "Dach-Windler",
    "PersonId": 144,
    "Rank": 302,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 636,
    "FullName": "Nikki Kunze",
    "FormalName": "Moore Group",
    "Deleted": true,
    "EjUserId": 174,
    "UserName": "Maggio Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 681
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 968,
    "Name": "Schmeler, Heaney and Veum",
    "PersonId": 414,
    "Rank": 431,
    "Tooltip": "eos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 822,
    "FullName": "Kathryn Swift MD",
    "FormalName": "Pacocha-Berge",
    "Deleted": false,
    "EjUserId": 373,
    "UserName": "Torphy, Kemmer and Stanton",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 990
      }
    }
  },
  "Associate": {
    "AssociateId": 484,
    "Name": "Lebsack Group",
    "PersonId": 935,
    "Rank": 284,
    "Tooltip": "cupiditate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 204,
    "FullName": "Damaris Hermiston",
    "FormalName": "Nicolas Inc and Sons",
    "Deleted": false,
    "EjUserId": 538,
    "UserName": "Gulgowski, Homenick and Bayer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 866
      }
    }
  },
  "ProjectStatus": {
    "Id": 839,
    "Value": "nisi",
    "Tooltip": "ducimus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 12
      }
    }
  },
  "ProjectType": {
    "Id": 735,
    "Value": "earum",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "seize web-enabled mindshare"
        },
        "FieldType": "System.Int32",
        "FieldLength": 16
      }
    }
  },
  "HasImage": false,
  "ImageDescription": "Exclusive explicit analyzer",
  "ActiveStatusMonitorId": 360,
  "Links": [
    {
      "EntityName": "Veum LLC",
      "Id": 438,
      "Description": "User-friendly incremental strategy",
      "ExtraInfo": "dignissimos",
      "LinkId": 97,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 336
        }
      }
    }
  ],
  "ActiveLinks": 21,
  "Completed": false,
  "NextMilestoneDate": "2014-12-16T18:25:50.7958833+01:00",
  "NmdAppointmentId": 903,
  "EndDate": "2005-01-24T18:25:50.7958833+01:00",
  "ActiveErpLinks": 854,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "quaerat"
  },
  "CustomFields": {
    "CustomFields1": "delectus",
    "CustomFields2": "sunt"
  },
  "PublishEventDate": "2000-06-17T18:25:50.7958833+02:00",
  "PublishTo": "2013-12-04T18:25:50.7958833+01:00",
  "PublishFrom": "1999-01-07T18:25:50.7958833+01:00",
  "IsPublished": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 604
    }
  }
}
```