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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 52,
  "Name": "Watsica Inc and Sons",
  "Department": "",
  "OrgNr": "268807",
  "Number1": "886176",
  "Number2": "736544",
  "UpdatedDate": "2001-05-19T13:14:05.6320153+02:00",
  "CreatedDate": "2018-01-07T13:14:05.6320153+01:00",
  "Emails": [
    {
      "Value": "minus",
      "StrippedValue": "consequuntur",
      "Description": "Future-proofed needs-based project"
    },
    {
      "Value": "minus",
      "StrippedValue": "consequuntur",
      "Description": "Future-proofed needs-based project"
    }
  ],
  "Interests": [
    {
      "Id": 461,
      "Name": "Dickinson, Cronin and Deckow",
      "ToolTip": "Qui vitae.",
      "Deleted": false,
      "Rank": 155,
      "Type": "est",
      "ColorBlock": 464,
      "IconHint": "quae",
      "Selected": true,
      "LastChanged": "2004-01-28T13:14:05.6476412+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rerum",
      "StyleHint": "veniam",
      "Hidden": false,
      "FullName": "Carlos Alek Jakubowski Jr."
    }
  ],
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "cumque",
      "Description": "Fundamental value-added encryption"
    },
    {
      "Value": "in",
      "StrippedValue": "cumque",
      "Description": "Fundamental value-added encryption"
    }
  ],
  "Phones": [
    {
      "Value": "vero",
      "StrippedValue": "officia",
      "Description": "Sharable radical middleware"
    },
    {
      "Value": "vero",
      "StrippedValue": "officia",
      "Description": "Sharable radical middleware"
    }
  ],
  "Faxes": [
    {
      "Value": "inventore",
      "StrippedValue": "et",
      "Description": "Digitized incremental alliance"
    },
    {
      "Value": "inventore",
      "StrippedValue": "et",
      "Description": "Digitized incremental alliance"
    }
  ],
  "Description": "Visionary incremental secured line",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "neque",
      "PersonId": 255,
      "Mrmrs": "suscipit",
      "Firstname": "Drew",
      "Lastname": "Pfannerstill",
      "MiddleName": "Lynch, Erdman and Hettinger",
      "Title": "nostrum",
      "Description": "Synergistic well-modulated moderator",
      "Email": "alanna@spencer.ca",
      "FullName": "Dr. Lia Greg Haley",
      "DirectPhone": "332.296.7438 x71818",
      "FormalName": "Welch Group",
      "CountryId": 155,
      "ContactId": 102,
      "ContactName": "Heaney-Strosin",
      "Retired": 675,
      "Rank": 947,
      "ActiveInterests": 170,
      "ContactDepartment": "",
      "ContactCountryId": 612,
      "ContactOrgNr": "314995",
      "FaxPhone": "(006)030-0134 x663",
      "MobilePhone": "397.893.0562 x414",
      "ContactPhone": "911-200-2500 x9546",
      "AssociateName": "Wolf, Rempel and Brekke",
      "AssociateId": 508,
      "UsePersonAddress": true,
      "ContactFax": "sit",
      "Kanafname": "architecto",
      "Kanalname": "fuga",
      "Post1": "error",
      "Post2": "cumque",
      "Post3": "laudantium",
      "EmailName": "dax_reichel@kulasyundt.biz",
      "ContactFullName": "Ms. Lane Walsh III",
      "ActiveErpLinks": 384,
      "TicketPriorityId": 813,
      "SupportLanguageId": 439,
      "SupportAssociateId": 658,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "quis",
  "Xstop": true,
  "ActiveInterests": 399,
  "GroupId": 105,
  "ActiveStatusMonitorId": 330,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 470,
  "DbiAgentId": 359,
  "DbiLastSyncronized": "2016-07-01T13:14:05.6476412+02:00",
  "DbiKey": "porro",
  "DbiLastModified": "1997-07-16T13:14:05.6476412+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 216,
  "ActiveErpLinks": 431,
  "BounceEmails": [
    "johathan.koch@rennergorczany.ca",
    "ferne@lueilwitzbechtelar.co.uk"
  ],
  "Domains": [
    "voluptas",
    "perferendis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1245795296",
    "SuperOffice:2": "Mrs. Katlynn Autumn Stanton Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "quam"
  },
  "CustomFields": {
    "CustomFields1": "dolores",
    "CustomFields2": "rerum"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 694,
  "Name": "Bailey Group",
  "Department": "",
  "OrgNr": "1063568",
  "Number1": "1282445",
  "Number2": "606114",
  "UpdatedDate": "2009-05-21T13:14:05.6476412+02:00",
  "CreatedDate": "2005-07-13T13:14:05.6476412+02:00",
  "Emails": [
    {
      "Value": "cum",
      "StrippedValue": "ut",
      "Description": "Proactive didactic customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "ut",
      "Description": "Proactive didactic customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 940,
      "Name": "Ullrich, Berge and Prohaska",
      "ToolTip": "Ratione et eos delectus iusto.",
      "Deleted": false,
      "Rank": 176,
      "Type": "mollitia",
      "ColorBlock": 828,
      "IconHint": "quos",
      "Selected": true,
      "LastChanged": "1999-09-11T13:14:05.6476412+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "possimus",
      "StyleHint": "est",
      "Hidden": true,
      "FullName": "Alvina Collins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 219
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "sunt",
      "Description": "Enterprise-wide uniform ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 742
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "sunt",
      "Description": "Enterprise-wide uniform ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 742
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "dignissimos",
      "Description": "Synchronised content-based leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "dignissimos",
      "Description": "Synchronised content-based leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "natus",
      "StrippedValue": "quis",
      "Description": "Digitized maximized project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "quis",
      "Description": "Digitized maximized project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    }
  ],
  "Description": "Fully-configurable systematic hardware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ad",
      "PersonId": 389,
      "Mrmrs": "veritatis",
      "Firstname": "Zelma",
      "Lastname": "Homenick",
      "MiddleName": "Crist, Turner and Berge",
      "Title": "consequuntur",
      "Description": "Proactive optimal conglomeration",
      "Email": "otho@dubuque.co.uk",
      "FullName": "Ryan Walsh",
      "DirectPhone": "(232)028-9002",
      "FormalName": "Paucek Inc and Sons",
      "CountryId": 806,
      "ContactId": 707,
      "ContactName": "King Group",
      "Retired": 435,
      "Rank": 926,
      "ActiveInterests": 741,
      "ContactDepartment": "",
      "ContactCountryId": 208,
      "ContactOrgNr": "655474",
      "FaxPhone": "1-114-940-5201 x219",
      "MobilePhone": "1-961-428-2587",
      "ContactPhone": "(750)974-9915",
      "AssociateName": "Hand-Lockman",
      "AssociateId": 469,
      "UsePersonAddress": false,
      "ContactFax": "perferendis",
      "Kanafname": "quod",
      "Kanalname": "maxime",
      "Post1": "labore",
      "Post2": "itaque",
      "Post3": "veniam",
      "EmailName": "domingo_friesen@runolfssonmohr.us",
      "ContactFullName": "Ms. Shaylee Littel",
      "ActiveErpLinks": 648,
      "TicketPriorityId": 547,
      "SupportLanguageId": 67,
      "SupportAssociateId": 796,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "voluptas",
  "Xstop": false,
  "ActiveInterests": 860,
  "GroupId": 59,
  "ActiveStatusMonitorId": 311,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 632,
  "DbiAgentId": 707,
  "DbiLastSyncronized": "2007-10-14T13:14:05.6476412+02:00",
  "DbiKey": "dicta",
  "DbiLastModified": "2020-08-17T13:14:05.6476412+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 213,
  "ActiveErpLinks": 62,
  "BounceEmails": [
    "fanny@borer.info",
    "emory@cassin.uk"
  ],
  "Domains": [
    "id",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1562028179",
    "SuperOffice:2": "Yvette Mraz"
  },
  "ExtraFields": {
    "ExtraFields1": "repellat",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "fuga",
    "CustomFields2": "facilis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 187
    }
  }
}
```