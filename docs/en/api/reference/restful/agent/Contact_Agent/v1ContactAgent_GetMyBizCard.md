---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 848,
  "Name": "Huel, Abernathy and Sauer",
  "Department": "",
  "OrgNr": "1021688",
  "Number1": "197823",
  "Number2": "640652",
  "UpdatedDate": "2014-09-15T11:16:08.9128415+02:00",
  "CreatedDate": "2012-01-21T11:16:08.9128415+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "laborum",
      "Description": "Progressive logistical knowledge user",
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
      "Value": "et",
      "StrippedValue": "laborum",
      "Description": "Progressive logistical knowledge user",
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
  "Interests": [
    {
      "Id": 339,
      "Name": "Langosh, Morissette and Koss",
      "ToolTip": "Quis voluptatem vel quos omnis.",
      "Deleted": false,
      "Rank": 341,
      "Type": "exercitationem",
      "ColorBlock": 461,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2003-09-24T11:16:08.9128415+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dicta",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Dr. Arnulfo Rigoberto Kunze MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 163
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "quo",
      "Description": "Optional bi-directional forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 821
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "quo",
      "Description": "Optional bi-directional forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 821
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "incidunt",
      "StrippedValue": "veritatis",
      "Description": "Multi-channelled local model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 223
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "veritatis",
      "Description": "Multi-channelled local model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 223
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "omnis",
      "Description": "Streamlined needs-based system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 104
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "omnis",
      "Description": "Streamlined needs-based system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 104
        }
      }
    }
  ],
  "Description": "Virtual executive superstructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "praesentium",
      "PersonId": 953,
      "Mrmrs": "quis",
      "Firstname": "Javon",
      "Lastname": "Schaden",
      "MiddleName": "Abshire Inc and Sons",
      "Title": "porro",
      "Description": "Operative impactful collaboration",
      "Email": "cara@hamill.ca",
      "FullName": "Mr. Ronaldo Smith",
      "DirectPhone": "604.435.8265 x9168",
      "FormalName": "Grady Group",
      "CountryId": 111,
      "ContactId": 360,
      "ContactName": "Zulauf, Hahn and Armstrong",
      "Retired": 858,
      "Rank": 35,
      "ActiveInterests": 80,
      "ContactDepartment": "",
      "ContactCountryId": 313,
      "ContactOrgNr": "1137336",
      "FaxPhone": "(526)802-6451",
      "MobilePhone": "779.871.4451",
      "ContactPhone": "1-358-689-9295 x0708",
      "AssociateName": "Jewess-Walsh",
      "AssociateId": 18,
      "UsePersonAddress": false,
      "ContactFax": "commodi",
      "Kanafname": "natus",
      "Kanalname": "hic",
      "Post1": "voluptas",
      "Post2": "et",
      "Post3": "hic",
      "EmailName": "lacey_volkman@wunschkuhic.name",
      "ContactFullName": "Ms. Toy Jerde",
      "ActiveErpLinks": 121,
      "TicketPriorityId": 999,
      "SupportLanguageId": 899,
      "SupportAssociateId": 601,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 275
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ipsa",
  "Xstop": true,
  "ActiveInterests": 19,
  "GroupId": 541,
  "ActiveStatusMonitorId": 336,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 875,
  "DbiAgentId": 120,
  "DbiLastSyncronized": "2011-12-22T11:16:08.9128415+01:00",
  "DbiKey": "provident",
  "DbiLastModified": "2011-12-15T11:16:08.9128415+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 26,
  "ActiveErpLinks": 996,
  "BounceEmails": [
    "anna_gerlach@roberts.uk",
    "charlie@dickileannon.ca"
  ],
  "Domains": [
    "omnis",
    "molestias"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Keon King Dickens III",
    "SuperOffice:2": "Mr. Ena Mayer"
  },
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "iusto",
    "CustomFields2": "magni"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 812
    }
  }
}
```