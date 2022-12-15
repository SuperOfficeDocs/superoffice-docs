---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=584
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
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

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 701,
  "Name": "Vandervort-O'Kon",
  "Department": "",
  "OrgNr": "1357200",
  "Number1": "1301065",
  "Number2": "1743413",
  "UpdatedDate": "2008-10-31T02:49:43.9191527+01:00",
  "CreatedDate": "2005-11-01T02:49:43.9191527+01:00",
  "Emails": [
    {
      "Value": "velit",
      "StrippedValue": "aperiam",
      "Description": "Organic logistical firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "aperiam",
      "Description": "Organic logistical firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 401,
      "Name": "Feest-Goldner",
      "ToolTip": "Eum consequatur praesentium saepe rerum nesciunt sit fugiat.",
      "Deleted": false,
      "Rank": 752,
      "Type": "libero",
      "ColorBlock": 586,
      "IconHint": "quas",
      "Selected": true,
      "LastChanged": "2013-12-15T02:49:43.9191527+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "provident",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Godfrey Brook Schroeder DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 422
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "inventore",
      "StrippedValue": "asperiores",
      "Description": "Reverse-engineered human-resource parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 959
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "asperiores",
      "Description": "Reverse-engineered human-resource parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 959
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "rerum",
      "StrippedValue": "at",
      "Description": "Adaptive upward-trending circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 660
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "at",
      "Description": "Adaptive upward-trending circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 660
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quae",
      "StrippedValue": "non",
      "Description": "User-centric uniform contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "non",
      "Description": "User-centric uniform contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    }
  ],
  "Description": "Expanded national toolset",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "exercitationem",
      "PersonId": 739,
      "Mrmrs": "voluptatem",
      "Firstname": "Velda",
      "Lastname": "Schmitt",
      "MiddleName": "Windler Group",
      "Title": "deleniti",
      "Description": "Ameliorated 6th generation process improvement",
      "Email": "ara@damore.info",
      "FullName": "Ms. Arvid Camryn Ebert",
      "DirectPhone": "869-586-9233 x8713",
      "FormalName": "Spencer-Simonis",
      "CountryId": 660,
      "ContactId": 65,
      "ContactName": "Padberg-Moore",
      "Retired": 543,
      "Rank": 659,
      "ActiveInterests": 386,
      "ContactDepartment": "",
      "ContactCountryId": 778,
      "ContactOrgNr": "669842",
      "FaxPhone": "546-334-8671",
      "MobilePhone": "(627)900-8528",
      "ContactPhone": "1-433-508-1369 x94872",
      "AssociateName": "Langosh, Bartoletti and Simonis",
      "AssociateId": 833,
      "UsePersonAddress": false,
      "ContactFax": "adipisci",
      "Kanafname": "est",
      "Kanalname": "aut",
      "Post1": "consequatur",
      "Post2": "tempore",
      "Post3": "id",
      "EmailName": "osvaldo.turcotte@homenick.info",
      "ContactFullName": "Reba Bashirian V",
      "ActiveErpLinks": 177,
      "TicketPriorityId": 399,
      "SupportLanguageId": 895,
      "SupportAssociateId": 94,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 560
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "molestiae",
  "Xstop": true,
  "ActiveInterests": 287,
  "GroupId": 23,
  "ActiveStatusMonitorId": 905,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 684,
  "DbiAgentId": 440,
  "DbiLastSyncronized": "2021-12-12T02:49:43.9191527+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2009-03-22T02:49:43.9191527+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 989,
  "ActiveErpLinks": 218,
  "BounceEmails": [
    "joel@stehr.us",
    "millie.runolfsdottir@streich.info"
  ],
  "Domains": [
    "ullam",
    "vel"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Rosa Abernathy V"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "possimus",
    "CustomFields2": "voluptatibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 977
    }
  }
}
```