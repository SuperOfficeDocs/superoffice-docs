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
  "ContactId": 412,
  "Name": "Lindgren-Barrows",
  "Department": "",
  "OrgNr": "1328640",
  "Number1": "1085681",
  "Number2": "775807",
  "UpdatedDate": "2021-11-19T03:31:25.9009434+01:00",
  "CreatedDate": "2017-12-03T03:31:25.9009434+01:00",
  "Emails": [
    {
      "Value": "ea",
      "StrippedValue": "nulla",
      "Description": "Customer-focused non-volatile forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 882
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "nulla",
      "Description": "Customer-focused non-volatile forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 882
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 130,
      "Name": "Nolan-Cruickshank",
      "ToolTip": "Et occaecati commodi sed qui.",
      "Deleted": false,
      "Rank": 835,
      "Type": "deleniti",
      "ColorBlock": 947,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2011-07-30T03:31:25.9009434+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptates",
      "StyleHint": "repellat",
      "Hidden": true,
      "FullName": "Miller Yundt Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 520
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "nostrum",
      "Description": "Compatible scalable process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "nostrum",
      "Description": "Compatible scalable process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "vitae",
      "StrippedValue": "ut",
      "Description": "Customer-focused modular attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 803
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "ut",
      "Description": "Customer-focused modular attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 803
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "totam",
      "StrippedValue": "quod",
      "Description": "Open-architected object-oriented array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 743
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "quod",
      "Description": "Open-architected object-oriented array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 743
        }
      }
    }
  ],
  "Description": "Diverse client-driven application",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "totam",
      "PersonId": 491,
      "Mrmrs": "ipsum",
      "Firstname": "Arnaldo",
      "Lastname": "Schultz",
      "MiddleName": "Haag-Ortiz",
      "Title": "qui",
      "Description": "Sharable object-oriented Graphical User Interface",
      "Email": "bradley@ruecker.biz",
      "FullName": "Lionel McGlynn III",
      "DirectPhone": "218-602-3223",
      "FormalName": "Quitzon Group",
      "CountryId": 944,
      "ContactId": 898,
      "ContactName": "Schumm Inc and Sons",
      "Retired": 70,
      "Rank": 10,
      "ActiveInterests": 167,
      "ContactDepartment": "",
      "ContactCountryId": 998,
      "ContactOrgNr": "1431458",
      "FaxPhone": "1-253-291-1372 x95870",
      "MobilePhone": "(805)721-3843",
      "ContactPhone": "358-800-4499 x9882",
      "AssociateName": "Hahn, Hintz and Wolf",
      "AssociateId": 400,
      "UsePersonAddress": false,
      "ContactFax": "quis",
      "Kanafname": "nulla",
      "Kanalname": "libero",
      "Post1": "ipsa",
      "Post2": "provident",
      "Post3": "odit",
      "EmailName": "dorthy_paucek@weber.biz",
      "ContactFullName": "Jarrell Waelchi",
      "ActiveErpLinks": 811,
      "TicketPriorityId": 426,
      "SupportLanguageId": 624,
      "SupportAssociateId": 601,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 244
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "inventore",
  "Xstop": false,
  "ActiveInterests": 113,
  "GroupId": 417,
  "ActiveStatusMonitorId": 537,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 158,
  "DbiAgentId": 717,
  "DbiLastSyncronized": "2012-09-22T03:31:25.9009434+02:00",
  "DbiKey": "eveniet",
  "DbiLastModified": "2013-09-24T03:31:25.9009434+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 651,
  "ActiveErpLinks": 435,
  "BounceEmails": [
    "jenifer.rodriguez@leuschke.us",
    "stone@gleichnerreilly.ca"
  ],
  "Domains": [
    "culpa",
    "repellat"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "695155997"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "repellat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 203
    }
  }
}
```