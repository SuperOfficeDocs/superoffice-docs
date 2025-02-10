---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.


Calls the Contact agent service GetContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=False
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

ContactEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ContactEntityWithLinks

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
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 03 Oct 2000 12:01:32 G10T

{
  "ContactId": 424,
  "Name": "Considine, Rosenbaum and Turcotte",
  "Department": "",
  "OrgNr": "1448538",
  "Number1": "673389",
  "Number2": "40977",
  "UpdatedDate": "2000-10-03T12:01:32.7925531+02:00",
  "CreatedDate": "2016-10-26T12:01:32.7925531+02:00",
  "Emails": [
    {
      "Value": "iste",
      "StrippedValue": "eaque",
      "Description": "Centralized bi-directional algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 146
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "eaque",
      "Description": "Centralized bi-directional algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 146
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 896,
      "Name": "Herman, Paucek and Roberts",
      "ToolTip": "Necessitatibus qui consectetur blanditiis quidem iste iure.",
      "Deleted": false,
      "Rank": 499,
      "Type": "explicabo",
      "ColorBlock": 503,
      "IconHint": "qui",
      "Selected": true,
      "LastChanged": "2003-09-04T12:01:32.7925531+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "eos",
      "Hidden": false,
      "FullName": "Miss Desmond Adolfo Lynch PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 579
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "quia",
      "Description": "Monitored global functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 74
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "quia",
      "Description": "Monitored global functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 74
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quisquam",
      "StrippedValue": "molestias",
      "Description": "Sharable dynamic moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 10
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "molestias",
      "Description": "Sharable dynamic moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 10
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tempore",
      "StrippedValue": "vero",
      "Description": "Innovative modular standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 769
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "vero",
      "Description": "Innovative modular standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 769
        }
      }
    }
  ],
  "Description": "Synergized static secured line",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ipsum",
      "PersonId": 933,
      "Mrmrs": "quibusdam",
      "Firstname": "Abigail",
      "Lastname": "Conn",
      "MiddleName": "Lindgren Inc and Sons",
      "Title": "quisquam",
      "Description": "Up-sized 24/7 support",
      "Email": "edna@mueller.us",
      "FullName": "Lyla Bruen",
      "DirectPhone": "486.223.1658 x416",
      "FormalName": "D'Amore, Windler and Reichel",
      "CountryId": 338,
      "ContactId": 405,
      "ContactName": "Emard Inc and Sons",
      "Retired": 781,
      "Rank": 885,
      "ActiveInterests": 946,
      "ContactDepartment": "",
      "ContactCountryId": 394,
      "ContactOrgNr": "1191479",
      "FaxPhone": "852.497.4289 x79497",
      "MobilePhone": "733.572.1541",
      "ContactPhone": "1-082-666-9730 x2261",
      "AssociateName": "Towne Group",
      "AssociateId": 222,
      "UsePersonAddress": true,
      "ContactFax": "rerum",
      "Kanafname": "quos",
      "Kanalname": "molestias",
      "Post1": "sapiente",
      "Post2": "aut",
      "Post3": "est",
      "EmailName": "wilson@white.ca",
      "ContactFullName": "Mr. Gussie Cristina Klein V",
      "ActiveErpLinks": 368,
      "TicketPriorityId": 708,
      "SupportLanguageId": 98,
      "SupportAssociateId": 239,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1090970",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 470
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "odio",
  "Xstop": false,
  "ActiveInterests": 173,
  "GroupId": 539,
  "ActiveStatusMonitorId": 75,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 55,
  "DbiAgentId": 672,
  "DbiLastSyncronized": "2019-01-09T12:01:32.7925531+01:00",
  "DbiKey": "delectus",
  "DbiLastModified": "2017-03-05T12:01:32.7925531+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 397,
  "ActiveErpLinks": 131,
  "BounceEmails": [
    "loren@huel.co.uk",
    "isidro.tillman@friesen.name"
  ],
  "Domains": [
    "non",
    "doloremque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "351651196",
    "SuperOffice:2": "Myron Skyla Christiansen IV"
  },
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 165
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```