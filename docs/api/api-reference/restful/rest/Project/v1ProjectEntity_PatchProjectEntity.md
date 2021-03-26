---
title: PATCH Project/{id}
id: v1ProjectEntity_PatchProjectEntity
---

# PATCH Project/{id}

```http
PATCH /api/v1/Project/{id}
```

Update a ProjectEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IProjectAgent} service SaveProjectEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Project/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

The Project Service. The service implements all services working with the Project object



ProjectEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity  updated. |
| 404 | ProjectEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |

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
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "nihil",
    "value": {
      "value1": {
        "PrimaryKey": 353,
        "EntityName": "sale",
        "saleId": 353,
        "contactId": 3958,
        "name": "Mayer Group"
      },
      "value2": {
        "PrimaryKey": 9462,
        "EntityName": "sale",
        "saleId": 9462,
        "contactId": 4549,
        "name": "Bartell-Cartwright"
      }
    }
  },
  {
    "op": "add",
    "path": "nihil",
    "value": {
      "value1": {
        "PrimaryKey": 353,
        "EntityName": "sale",
        "saleId": 353,
        "contactId": 3958,
        "name": "Mayer Group"
      },
      "value2": {
        "PrimaryKey": 9462,
        "EntityName": "sale",
        "saleId": 9462,
        "contactId": 4549,
        "name": "Bartell-Cartwright"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ProjectEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 145,
  "Name": "Gibson-Hegmann",
  "ProjectNumber": "1121248",
  "ProjectMembers": [
    {
      "ProjectmemberId": 570,
      "ContactId": 429,
      "ProjectId": 476,
      "ContactName": "Halvorson LLC",
      "ContactDepartment": "",
      "ProjectName": "Reichert-Green",
      "EmailId": 99,
      "EmailAddress": "frederik@batzdurgan.co.uk",
      "CountryId": 743,
      "Firstname": "Pete",
      "MiddleName": "Collins LLC",
      "Lastname": "Kessler",
      "PersonId": 404,
      "Mrmrs": "nihil",
      "ProjectMemberTypeName": "Kulas, McGlynn and Wisoky",
      "Phone": "1-281-552-4178 x608",
      "PhoneId": 310,
      "ProjectMemberTypeId": 54,
      "EmailAddressName": "hailey@weberkoepp.ca",
      "Comment": "libero",
      "FullName": "Dr. Woodrow Bins",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 308
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "possimus",
      "StrippedValue": "officiis",
      "Description": "Future-proofed content-based paradigm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 521
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "officiis",
      "Description": "Future-proofed content-based paradigm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 521
        }
      }
    }
  ],
  "CreatedDate": "1995-10-13T09:40:59.4776627+02:00",
  "UpdatedDate": "2012-09-20T09:40:59.4776627+02:00",
  "Description": "Monitored multimedia knowledge user",
  "Postit": "voluptatum",
  "CreatedBy": {
    "AssociateId": 352,
    "Name": "Baumbach-O'Conner",
    "PersonId": 504,
    "Rank": 7,
    "Tooltip": "nemo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 730,
    "FullName": "Daisha Tremblay",
    "FormalName": "Durgan Group",
    "Deleted": false,
    "EjUserId": 251,
    "UserName": "Kemmer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 20
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 930,
    "Name": "Mraz LLC",
    "PersonId": 572,
    "Rank": 270,
    "Tooltip": "reiciendis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 545,
    "FullName": "Dillan Heidenreich",
    "FormalName": "Rosenbaum Inc and Sons",
    "Deleted": true,
    "EjUserId": 137,
    "UserName": "Price, Predovic and Nikolaus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 762
      }
    }
  },
  "Associate": {
    "AssociateId": 399,
    "Name": "O'Kon-Runolfsdottir",
    "PersonId": 523,
    "Rank": 652,
    "Tooltip": "harum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 5,
    "FullName": "Dr. Kailey Klocko",
    "FormalName": "Fisher Group",
    "Deleted": false,
    "EjUserId": 896,
    "UserName": "Hayes-Ziemann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 695
      }
    }
  },
  "ProjectStatus": {
    "Id": 710,
    "Value": "voluptatem",
    "Tooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 873
      }
    }
  },
  "ProjectType": {
    "Id": 21,
    "Value": "in",
    "Tooltip": "nam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 756
      }
    }
  },
  "HasImage": true,
  "ImageDescription": "Cloned methodical interface",
  "ActiveStatusMonitorId": 463,
  "Links": [
    {
      "EntityName": "Ullrich-Jast",
      "Id": 829,
      "Description": "Down-sized full-range Graphic Interface",
      "ExtraInfo": "esse",
      "LinkId": 88,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 314
        }
      }
    }
  ],
  "ActiveLinks": 287,
  "Completed": true,
  "NextMilestoneDate": "2016-12-16T09:40:59.4786627+01:00",
  "NmdAppointmentId": 226,
  "EndDate": "2001-05-04T09:40:59.4786627+02:00",
  "ActiveErpLinks": 589,
  "UserDefinedFields": {
    "SuperOffice:1": "Noel Fay",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "explicabo"
  },
  "CustomFields": {
    "CustomFields1": "repudiandae",
    "CustomFields2": "vel"
  },
  "PublishEventDate": "2010-04-13T09:40:59.4786627+02:00",
  "PublishTo": "2019-04-09T09:40:59.4786627+02:00",
  "PublishFrom": "2007-02-25T09:40:59.4786627+01:00",
  "IsPublished": true,
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
      "FieldType": "System.Int32",
      "FieldLength": 723
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```