---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=654
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

### Response body: ContactEntity

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

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 218,
  "Name": "Keeling-Kessler",
  "Department": "",
  "OrgNr": "1600742",
  "Number1": "818781",
  "Number2": "1294820",
  "UpdatedDate": "2022-07-09T04:02:01.4561411+02:00",
  "CreatedDate": "2022-04-12T04:02:01.4561411+02:00",
  "Emails": [
    {
      "Value": "perferendis",
      "StrippedValue": "ut",
      "Description": "Multi-layered 24 hour open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 417
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "ut",
      "Description": "Multi-layered 24 hour open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 417
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 835,
      "Name": "Mertz, Senger and Bailey",
      "ToolTip": "Culpa numquam ratione consequuntur cumque inventore.",
      "Deleted": false,
      "Rank": 563,
      "Type": "et",
      "ColorBlock": 948,
      "IconHint": "repellendus",
      "Selected": false,
      "LastChanged": "2018-11-28T04:02:01.4561411+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "reiciendis",
      "Hidden": false,
      "FullName": "Kurt Skiles",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "placeat",
      "Description": "Balanced hybrid flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 305
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "placeat",
      "Description": "Balanced hybrid flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 305
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "repellendus",
      "StrippedValue": "provident",
      "Description": "Decentralized optimizing Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 448
        }
      }
    },
    {
      "Value": "repellendus",
      "StrippedValue": "provident",
      "Description": "Decentralized optimizing Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 448
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "error",
      "StrippedValue": "qui",
      "Description": "Focused systemic utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 192
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "qui",
      "Description": "Focused systemic utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 192
        }
      }
    }
  ],
  "Description": "Integrated radical orchestration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "totam",
      "PersonId": 777,
      "Mrmrs": "et",
      "Firstname": "Stephanie",
      "Lastname": "Simonis",
      "MiddleName": "Thiel-Parker",
      "Title": "labore",
      "Description": "Grass-roots tertiary protocol",
      "Email": "terrence@gerhold.name",
      "FullName": "Theresia Kunze",
      "DirectPhone": "1-240-062-0459",
      "FormalName": "Gutkowski, Rohan and Schuster",
      "CountryId": 638,
      "ContactId": 649,
      "ContactName": "Lubowitz Inc and Sons",
      "Retired": 655,
      "Rank": 828,
      "ActiveInterests": 486,
      "ContactDepartment": "",
      "ContactCountryId": 676,
      "ContactOrgNr": "655287",
      "FaxPhone": "(350)214-1815 x2836",
      "MobilePhone": "071-271-1893 x77325",
      "ContactPhone": "(875)170-2746",
      "AssociateName": "Quigley-Gulgowski",
      "AssociateId": 48,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "aperiam",
      "Kanalname": "et",
      "Post1": "voluptatibus",
      "Post2": "omnis",
      "Post3": "facilis",
      "EmailName": "crystel_schimmel@botsfordmaggio.biz",
      "ContactFullName": "Mrs. Jude Eula Lindgren",
      "ActiveErpLinks": 260,
      "TicketPriorityId": 117,
      "SupportLanguageId": 402,
      "SupportAssociateId": 79,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 858
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 158,
  "GroupId": 253,
  "ActiveStatusMonitorId": 376,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 592,
  "DbiAgentId": 410,
  "DbiLastSyncronized": "2019-03-19T04:02:01.4561411+01:00",
  "DbiKey": "voluptatem",
  "DbiLastModified": "2019-04-22T04:02:01.4561411+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 743,
  "ActiveErpLinks": 519,
  "BounceEmails": [
    "rhett@turner.name",
    "delbert@braunkreiger.name"
  ],
  "Domains": [
    "incidunt",
    "maxime"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "laboriosam",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "quo"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 566
    }
  }
}
```