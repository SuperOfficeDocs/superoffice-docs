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
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 163,
  "Name": "Swaniawski-Dickinson",
  "Department": "",
  "OrgNr": "1112585",
  "Number1": "379121",
  "Number2": "1594911",
  "UpdatedDate": "2021-11-22T03:44:52.3240217+01:00",
  "CreatedDate": "2008-10-10T03:44:52.3240217+02:00",
  "Emails": [
    {
      "Value": "nihil",
      "StrippedValue": "nemo",
      "Description": "Diverse interactive database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 114
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "nemo",
      "Description": "Diverse interactive database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 114
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 385,
      "Name": "Bins LLC",
      "ToolTip": "Exercitationem voluptatem in sit.",
      "Deleted": true,
      "Rank": 132,
      "Type": "eius",
      "ColorBlock": 874,
      "IconHint": "voluptas",
      "Selected": true,
      "LastChanged": "2023-10-18T03:44:52.3240217+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "dolorum",
      "Hidden": false,
      "FullName": "Mrs. Tom Lubowitz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 272
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quibusdam",
      "StrippedValue": "aperiam",
      "Description": "Synchronised solution-oriented array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 548
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "aperiam",
      "Description": "Synchronised solution-oriented array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 548
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "dolorem",
      "Description": "Advanced bifurcated support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "dolorem",
      "Description": "Advanced bifurcated support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "expedita",
      "Description": "Monitored bifurcated budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 736
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "expedita",
      "Description": "Monitored bifurcated budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 736
        }
      }
    }
  ],
  "Description": "Open-source high-level core",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "esse",
      "PersonId": 812,
      "Mrmrs": "ad",
      "Firstname": "Kameron",
      "Lastname": "Sipes",
      "MiddleName": "Aufderhar, Zulauf and Zemlak",
      "Title": "odit",
      "Description": "Robust full-range synergy",
      "Email": "edwardo@turcotte.info",
      "FullName": "Glenda Larkin",
      "DirectPhone": "302-876-4851",
      "FormalName": "Kuhn, Legros and Robel",
      "CountryId": 160,
      "ContactId": 260,
      "ContactName": "Berge-Kilback",
      "Retired": 346,
      "Rank": 47,
      "ActiveInterests": 84,
      "ContactDepartment": "",
      "ContactCountryId": 157,
      "ContactOrgNr": "1443728",
      "FaxPhone": "448-765-5037 x779",
      "MobilePhone": "(503)526-6919 x9286",
      "ContactPhone": "542.621.9011 x3799",
      "AssociateName": "DuBuque LLC",
      "AssociateId": 118,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "ex",
      "Kanalname": "dicta",
      "Post1": "ducimus",
      "Post2": "quod",
      "Post3": "dolores",
      "EmailName": "iva_spinka@kuhlman.us",
      "ContactFullName": "Dock Aufderhar PhD",
      "ActiveErpLinks": 502,
      "TicketPriorityId": 320,
      "SupportLanguageId": 581,
      "SupportAssociateId": 575,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sed",
  "Xstop": false,
  "ActiveInterests": 285,
  "GroupId": 266,
  "ActiveStatusMonitorId": 543,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 148,
  "DbiAgentId": 218,
  "DbiLastSyncronized": "2015-03-12T03:44:52.3240217+01:00",
  "DbiKey": "accusantium",
  "DbiLastModified": "2015-06-27T03:44:52.3240217+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 245,
  "ActiveErpLinks": 642,
  "BounceEmails": [
    "nichole.bayer@schambergerfeeney.info",
    "luna@walter.name"
  ],
  "Domains": [
    "ea",
    "amet"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Jerry Halvorson",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "maxime",
    "ExtraFields2": "perferendis"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "illum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 729
    }
  }
}
```