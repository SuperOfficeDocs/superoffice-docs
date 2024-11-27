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
GET /api/v1/Contact/{id}?fk=True
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 29 Oct 2018 14:45:12 G10T

{
  "ContactId": 380,
  "Name": "Koch LLC",
  "Department": "",
  "OrgNr": "1094668",
  "Number1": "1221695",
  "Number2": "1305500",
  "UpdatedDate": "2018-10-29T14:45:12.6463559+01:00",
  "CreatedDate": "1999-04-26T14:45:12.6463559+02:00",
  "Emails": [
    {
      "Value": "saepe",
      "StrippedValue": "quae",
      "Description": "Distributed composite flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 611
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "quae",
      "Description": "Distributed composite flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 611
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 45,
      "Name": "Altenwerth Group",
      "ToolTip": "Maxime ullam et distinctio voluptatum.",
      "Deleted": false,
      "Rank": 776,
      "Type": "voluptate",
      "ColorBlock": 812,
      "IconHint": "autem",
      "Selected": true,
      "LastChanged": "2014-12-30T14:45:12.6463559+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "exercitationem",
      "StyleHint": "iure",
      "Hidden": true,
      "FullName": "Greg Leuschke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 792
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "tempora",
      "StrippedValue": "dolores",
      "Description": "Configurable leading edge benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 636
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "dolores",
      "Description": "Configurable leading edge benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 636
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "consequatur",
      "StrippedValue": "neque",
      "Description": "Re-contextualized empowering standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 534
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "neque",
      "Description": "Re-contextualized empowering standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 534
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolore",
      "StrippedValue": "quia",
      "Description": "Pre-emptive client-server help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 747
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "quia",
      "Description": "Pre-emptive client-server help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 747
        }
      }
    }
  ],
  "Description": "Business-focused foreground Graphic Interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "autem",
      "PersonId": 769,
      "Mrmrs": "enim",
      "Firstname": "Laurel",
      "Lastname": "Prosacco",
      "MiddleName": "Jakubowski-Runolfsdottir",
      "Title": "nemo",
      "Description": "Configurable static instruction set",
      "Email": "ian_corwin@johnson.us",
      "FullName": "Prof. Mariana Alison McKenzie MD",
      "DirectPhone": "341-808-1174",
      "FormalName": "Langosh LLC",
      "CountryId": 20,
      "ContactId": 626,
      "ContactName": "Barton Inc and Sons",
      "Retired": 972,
      "Rank": 233,
      "ActiveInterests": 586,
      "ContactDepartment": "",
      "ContactCountryId": 722,
      "ContactOrgNr": "1894595",
      "FaxPhone": "885.828.8757 x423",
      "MobilePhone": "(361)703-6469 x5684",
      "ContactPhone": "(773)273-5194 x1428",
      "AssociateName": "Zemlak-Terry",
      "AssociateId": 485,
      "UsePersonAddress": true,
      "ContactFax": "iusto",
      "Kanafname": "et",
      "Kanalname": "aut",
      "Post1": "voluptas",
      "Post2": "exercitationem",
      "Post3": "enim",
      "EmailName": "newton@rutherford.co.uk",
      "ContactFullName": "Viola Ernser",
      "ActiveErpLinks": 398,
      "TicketPriorityId": 859,
      "SupportLanguageId": 816,
      "SupportAssociateId": 205,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 367
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "saepe",
  "Xstop": false,
  "ActiveInterests": 633,
  "GroupId": 503,
  "ActiveStatusMonitorId": 305,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 451,
  "DbiAgentId": 623,
  "DbiLastSyncronized": "2014-06-01T14:45:12.6619778+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2017-06-17T14:45:12.6619778+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 682,
  "ActiveErpLinks": 58,
  "BounceEmails": [
    "hester_mohr@goldner.name",
    "deshawn@mckenziebosco.biz"
  ],
  "Domains": [
    "incidunt",
    "natus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "593814100",
    "SuperOffice:2": "130872810"
  },
  "ExtraFields": {
    "ExtraFields1": "sequi",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "quos",
    "CustomFields2": "velit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 75
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```