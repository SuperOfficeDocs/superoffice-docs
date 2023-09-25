---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 743,
  "Name": "Beatty-Berge",
  "Department": "",
  "OrgNr": "1164770",
  "Number1": "877467",
  "Number2": "893757",
  "UpdatedDate": "2000-05-31T03:24:47.4239365+02:00",
  "CreatedDate": "2000-03-21T03:24:47.4239365+01:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "aut",
      "Description": "Right-sized scalable artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "aut",
      "Description": "Right-sized scalable artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 536,
      "Name": "Green LLC",
      "ToolTip": "Quo perspiciatis quia quia nobis cumque.",
      "Deleted": false,
      "Rank": 447,
      "Type": "placeat",
      "ColorBlock": 823,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2005-02-07T03:24:47.4239365+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "aut",
      "Hidden": true,
      "FullName": "Tatyana Armstrong",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 331
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "labore",
      "StrippedValue": "ut",
      "Description": "Mandatory demand-driven moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 499
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "ut",
      "Description": "Mandatory demand-driven moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 499
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ullam",
      "StrippedValue": "at",
      "Description": "Quality-focused 5th generation data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 481
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "at",
      "Description": "Quality-focused 5th generation data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 481
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quo",
      "StrippedValue": "non",
      "Description": "Reduced neutral forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "non",
      "Description": "Reduced neutral forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    }
  ],
  "Description": "User-centric executive database",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 743,
      "Mrmrs": "consequatur",
      "Firstname": "Karlee",
      "Lastname": "Stroman",
      "MiddleName": "Mitchell, Padberg and McDermott",
      "Title": "quis",
      "Description": "Ergonomic actuating attitude",
      "Email": "orlo.lehner@upton.info",
      "FullName": "Mr. Cordie Maurine Eichmann II",
      "DirectPhone": "021-176-0250 x6788",
      "FormalName": "Krajcik, Simonis and Pfannerstill",
      "CountryId": 251,
      "ContactId": 229,
      "ContactName": "Will-Hagenes",
      "Retired": 204,
      "Rank": 815,
      "ActiveInterests": 774,
      "ContactDepartment": "",
      "ContactCountryId": 720,
      "ContactOrgNr": "1319208",
      "FaxPhone": "1-760-689-0536",
      "MobilePhone": "1-287-994-7798 x4452",
      "ContactPhone": "1-687-027-9688",
      "AssociateName": "Brakus Inc and Sons",
      "AssociateId": 372,
      "UsePersonAddress": true,
      "ContactFax": "itaque",
      "Kanafname": "ut",
      "Kanalname": "ut",
      "Post1": "eos",
      "Post2": "doloribus",
      "Post3": "fugiat",
      "EmailName": "madalyn_littel@wolffjohns.com",
      "ContactFullName": "Electa Corwin",
      "ActiveErpLinks": 690,
      "TicketPriorityId": 942,
      "SupportLanguageId": 992,
      "SupportAssociateId": 514,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatem",
  "Xstop": true,
  "ActiveInterests": 485,
  "GroupId": 191,
  "ActiveStatusMonitorId": 829,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 854,
  "DbiAgentId": 368,
  "DbiLastSyncronized": "2019-03-18T03:24:47.4239365+01:00",
  "DbiKey": "cum",
  "DbiLastModified": "2009-10-23T03:24:47.4239365+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 252,
  "ActiveErpLinks": 43,
  "BounceEmails": [
    "oma.lind@stokes.ca",
    "wilma@thiel.info"
  ],
  "Domains": [
    "dolorum",
    "cum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Josie Gulgowski"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 552
    }
  }
}
```