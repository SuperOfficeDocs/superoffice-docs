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
  "ContactId": 75,
  "Name": "Krajcik Inc and Sons",
  "Department": "",
  "OrgNr": "755872",
  "Number1": "1529108",
  "Number2": "578370",
  "UpdatedDate": "2015-07-24T16:00:40.398769+02:00",
  "CreatedDate": "1998-02-16T16:00:40.398769+01:00",
  "Emails": [
    {
      "Value": "odit",
      "StrippedValue": "explicabo",
      "Description": "Fundamental interactive hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 79
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "explicabo",
      "Description": "Fundamental interactive hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 79
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 129,
      "Name": "Berge, Wunsch and Hills",
      "ToolTip": "Natus alias incidunt cumque.",
      "Deleted": false,
      "Rank": 483,
      "Type": "non",
      "ColorBlock": 260,
      "IconHint": "saepe",
      "Selected": false,
      "LastChanged": "2000-12-27T16:00:40.398769+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iusto",
      "StyleHint": "possimus",
      "Hidden": false,
      "FullName": "Prof. Casper Paul Schimmel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 729
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quasi",
      "StrippedValue": "totam",
      "Description": "Switchable static paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 537
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "totam",
      "Description": "Switchable static paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 537
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "adipisci",
      "StrippedValue": "aliquid",
      "Description": "Versatile uniform methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 466
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "aliquid",
      "Description": "Versatile uniform methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 466
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "recusandae",
      "StrippedValue": "in",
      "Description": "Down-sized assymetric Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 298
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "in",
      "Description": "Down-sized assymetric Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 298
        }
      }
    }
  ],
  "Description": "Synchronised regional product",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "necessitatibus",
      "PersonId": 613,
      "Mrmrs": "et",
      "Firstname": "Kathleen",
      "Lastname": "Wisoky",
      "MiddleName": "Kuhic-Leuschke",
      "Title": "nulla",
      "Description": "Cloned attitude-oriented productivity",
      "Email": "delia_hermiston@gottliebdonnelly.co.uk",
      "FullName": "Dr. Ozella Swaniawski",
      "DirectPhone": "(357)525-6305 x151",
      "FormalName": "Leannon, Morissette and Mayert",
      "CountryId": 868,
      "ContactId": 227,
      "ContactName": "Glover Inc and Sons",
      "Retired": 649,
      "Rank": 744,
      "ActiveInterests": 955,
      "ContactDepartment": "",
      "ContactCountryId": 471,
      "ContactOrgNr": "994219",
      "FaxPhone": "003.318.9268",
      "MobilePhone": "169.867.7582 x803",
      "ContactPhone": "058.999.7868 x8715",
      "AssociateName": "Abbott-Marquardt",
      "AssociateId": 672,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "inventore",
      "Kanalname": "error",
      "Post1": "quis",
      "Post2": "est",
      "Post3": "nesciunt",
      "EmailName": "freddy@bashirian.ca",
      "ContactFullName": "Marquise Birdie Gusikowski V",
      "ActiveErpLinks": 876,
      "TicketPriorityId": 790,
      "SupportLanguageId": 375,
      "SupportAssociateId": 434,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 986
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "voluptas",
  "Xstop": false,
  "ActiveInterests": 984,
  "GroupId": 994,
  "ActiveStatusMonitorId": 373,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 205,
  "DbiAgentId": 901,
  "DbiLastSyncronized": "2002-07-06T16:00:40.4143897+02:00",
  "DbiKey": "eveniet",
  "DbiLastModified": "2016-10-10T16:00:40.4143897+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 732,
  "ActiveErpLinks": 650,
  "BounceEmails": [
    "selena@paucekdietrich.name",
    "kelli@kessler.us"
  ],
  "Domains": [
    "animi",
    "sunt"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1910236032",
    "SuperOffice:2": "Maye Willow Powlowski III"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "quis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 750
    }
  }
}
```