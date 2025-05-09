---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

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
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 418,
  "Name": "Dare LLC",
  "Department": "",
  "OrgNr": "1450154",
  "Number1": "1081851",
  "Number2": "711281",
  "UpdatedDate": "2023-02-07T16:32:38.3990594+01:00",
  "CreatedDate": "2023-07-16T16:32:38.3990594+02:00",
  "Emails": [
    {
      "Value": "quidem",
      "StrippedValue": "numquam",
      "Description": "Synchronised reciprocal synergy"
    },
    {
      "Value": "quidem",
      "StrippedValue": "numquam",
      "Description": "Synchronised reciprocal synergy"
    }
  ],
  "Interests": [
    {
      "Id": 901,
      "Name": "Hamill-Will",
      "ToolTip": "Veniam laborum voluptatem.",
      "Deleted": false,
      "Rank": 133,
      "Type": "aut",
      "ColorBlock": 458,
      "IconHint": "officia",
      "Selected": false,
      "LastChanged": "2001-06-24T16:32:38.3990594+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "inventore",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Orpha Dickinson V"
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "quia",
      "Description": "Public-key uniform structure"
    },
    {
      "Value": "non",
      "StrippedValue": "quia",
      "Description": "Public-key uniform structure"
    }
  ],
  "Phones": [
    {
      "Value": "in",
      "StrippedValue": "et",
      "Description": "Diverse human-resource conglomeration"
    },
    {
      "Value": "in",
      "StrippedValue": "et",
      "Description": "Diverse human-resource conglomeration"
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "qui",
      "Description": "Public-key multi-state implementation"
    },
    {
      "Value": "sit",
      "StrippedValue": "qui",
      "Description": "Public-key multi-state implementation"
    }
  ],
  "Description": "Reactive methodical functionalities",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "reiciendis",
      "PersonId": 191,
      "Mrmrs": "et",
      "Firstname": "Selina",
      "Lastname": "Mohr",
      "MiddleName": "Toy, Bruen and Walsh",
      "Title": "possimus",
      "Description": "Robust fresh-thinking collaboration",
      "Email": "kadin_shanahan@croninhintz.info",
      "FullName": "Ms. Junior Ayla Breitenberg Jr.",
      "DirectPhone": "504-110-5353",
      "FormalName": "Bayer Group",
      "CountryId": 12,
      "ContactId": 809,
      "ContactName": "McClure, Macejkovic and Rolfson",
      "Retired": 534,
      "Rank": 460,
      "ActiveInterests": 147,
      "ContactDepartment": "",
      "ContactCountryId": 768,
      "ContactOrgNr": "754265",
      "FaxPhone": "1-147-175-4335",
      "MobilePhone": "065-559-4580 x374",
      "ContactPhone": "1-096-603-0653 x98959",
      "AssociateName": "Hirthe-Wehner",
      "AssociateId": 700,
      "UsePersonAddress": false,
      "ContactFax": "asperiores",
      "Kanafname": "accusamus",
      "Kanalname": "ipsum",
      "Post1": "asperiores",
      "Post2": "dolorum",
      "Post3": "maxime",
      "EmailName": "maxwell@manncummings.uk",
      "ContactFullName": "Christelle Okuneva",
      "ActiveErpLinks": 50,
      "TicketPriorityId": 715,
      "SupportLanguageId": 141,
      "SupportAssociateId": 384,
      "CategoryName": "VIP Customer",
      "PersonNumber": "844597"
    }
  ],
  "NoMailing": true,
  "Kananame": "iusto",
  "Xstop": false,
  "ActiveInterests": 590,
  "GroupId": 758,
  "ActiveStatusMonitorId": 801,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 742,
  "DbiAgentId": 160,
  "DbiLastSyncronized": "2023-02-05T16:32:38.4146829+01:00",
  "DbiKey": "omnis",
  "DbiLastModified": "2014-07-17T16:32:38.4146829+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 65,
  "ActiveErpLinks": 911,
  "BounceEmails": [
    "winston.ruecker@paucekpurdy.co.uk",
    "jaleel_kris@langworth.ca"
  ],
  "Domains": [
    "omnis",
    "dicta"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Kristin Thompson",
    "SuperOffice:2": "Dr. Arianna Kacey Murazik II"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "natus"
  },
  "CustomFields": {
    "CustomFields1": "inventore",
    "CustomFields2": "soluta"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 246,
  "Name": "Goyette-Bernhard",
  "Department": "",
  "OrgNr": "911992",
  "Number1": "242702",
  "Number2": "1539243",
  "UpdatedDate": "2003-09-13T16:32:38.4146829+02:00",
  "CreatedDate": "2008-11-15T16:32:38.4146829+01:00",
  "Emails": [
    {
      "Value": "corporis",
      "StrippedValue": "velit",
      "Description": "Multi-layered hybrid encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "velit",
      "Description": "Multi-layered hybrid encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 6,
      "Name": "Anderson-Rosenbaum",
      "ToolTip": "Autem est corporis.",
      "Deleted": true,
      "Rank": 792,
      "Type": "neque",
      "ColorBlock": 467,
      "IconHint": "voluptate",
      "Selected": false,
      "LastChanged": "2003-09-23T16:32:38.4146829+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "assumenda",
      "StyleHint": "placeat",
      "Hidden": false,
      "FullName": "Prof. Deshaun Vidal Kunde Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolorem",
      "StrippedValue": "optio",
      "Description": "Grass-roots fresh-thinking groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "optio",
      "Description": "Grass-roots fresh-thinking groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nulla",
      "StrippedValue": "possimus",
      "Description": "Mandatory tangible benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 317
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "possimus",
      "Description": "Mandatory tangible benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 317
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolore",
      "StrippedValue": "aliquid",
      "Description": "Team-oriented demand-driven open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 199
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "aliquid",
      "Description": "Team-oriented demand-driven open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 199
        }
      }
    }
  ],
  "Description": "Public-key upward-trending orchestration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptas",
      "PersonId": 246,
      "Mrmrs": "enim",
      "Firstname": "Davonte",
      "Lastname": "Hodkiewicz",
      "MiddleName": "Hyatt-McGlynn",
      "Title": "nulla",
      "Description": "Stand-alone asynchronous concept",
      "Email": "melody@rempel.name",
      "FullName": "Sophie Wunsch",
      "DirectPhone": "(282)754-2677",
      "FormalName": "Kuhic-Wiza",
      "CountryId": 172,
      "ContactId": 92,
      "ContactName": "Pfeffer LLC",
      "Retired": 941,
      "Rank": 419,
      "ActiveInterests": 297,
      "ContactDepartment": "",
      "ContactCountryId": 221,
      "ContactOrgNr": "1653419",
      "FaxPhone": "1-079-830-7875",
      "MobilePhone": "1-168-476-8524 x678",
      "ContactPhone": "777-172-0375",
      "AssociateName": "Hettinger, Runolfsson and Nitzsche",
      "AssociateId": 863,
      "UsePersonAddress": false,
      "ContactFax": "autem",
      "Kanafname": "est",
      "Kanalname": "magni",
      "Post1": "corporis",
      "Post2": "totam",
      "Post3": "facere",
      "EmailName": "jamison_eichmann@ernserhickle.us",
      "ContactFullName": "Dr. Damian Cronin",
      "ActiveErpLinks": 69,
      "TicketPriorityId": 284,
      "SupportLanguageId": 934,
      "SupportAssociateId": 11,
      "CategoryName": "VIP Customer",
      "PersonNumber": "792194",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 807
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 699,
  "GroupId": 750,
  "ActiveStatusMonitorId": 738,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 48,
  "DbiAgentId": 435,
  "DbiLastSyncronized": "2021-03-03T16:32:38.4303083+01:00",
  "DbiKey": "sunt",
  "DbiLastModified": "2008-03-19T16:32:38.4303083+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 395,
  "ActiveErpLinks": 954,
  "BounceEmails": [
    "monty@walkercarroll.biz",
    "eve@dooleykoch.us"
  ],
  "Domains": [
    "voluptas",
    "numquam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Tania Christiansen DVM",
    "SuperOffice:2": "427904849"
  },
  "ExtraFields": {
    "ExtraFields1": "minima",
    "ExtraFields2": "ipsa"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "quidem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 267
    }
  }
}
```