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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 765,
  "Name": "Champlin LLC",
  "Department": "",
  "OrgNr": "474668",
  "Number1": "1310367",
  "Number2": "1086450",
  "UpdatedDate": "2003-12-24T04:22:26.1840946+01:00",
  "CreatedDate": "2022-11-23T04:22:26.1840946+01:00",
  "Emails": [
    {
      "Value": "inventore",
      "StrippedValue": "repellendus",
      "Description": "Fundamental logistical superstructure"
    },
    {
      "Value": "inventore",
      "StrippedValue": "repellendus",
      "Description": "Fundamental logistical superstructure"
    }
  ],
  "Interests": [
    {
      "Id": 630,
      "Name": "Moen Inc and Sons",
      "ToolTip": "Et quam impedit.",
      "Deleted": true,
      "Rank": 591,
      "Type": "hic",
      "ColorBlock": 403,
      "IconHint": "voluptas",
      "Selected": false,
      "LastChanged": "2015-06-29T04:22:26.1840946+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "corporis",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Dr. Braxton Murazik"
    }
  ],
  "Urls": [
    {
      "Value": "commodi",
      "StrippedValue": "sit",
      "Description": "Phased non-volatile workforce"
    },
    {
      "Value": "commodi",
      "StrippedValue": "sit",
      "Description": "Phased non-volatile workforce"
    }
  ],
  "Phones": [
    {
      "Value": "sed",
      "StrippedValue": "quo",
      "Description": "Reduced secondary middleware"
    },
    {
      "Value": "sed",
      "StrippedValue": "quo",
      "Description": "Reduced secondary middleware"
    }
  ],
  "Faxes": [
    {
      "Value": "praesentium",
      "StrippedValue": "suscipit",
      "Description": "Future-proofed zero defect projection"
    },
    {
      "Value": "praesentium",
      "StrippedValue": "suscipit",
      "Description": "Future-proofed zero defect projection"
    }
  ],
  "Description": "Front-line content-based algorithm",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quos",
      "PersonId": 954,
      "Mrmrs": "sed",
      "Firstname": "Aryanna",
      "Lastname": "Runolfsson",
      "MiddleName": "Mohr, Pfannerstill and Halvorson",
      "Title": "delectus",
      "Description": "Multi-tiered assymetric internet solution",
      "Email": "loren@fayreichel.us",
      "FullName": "Mr. Vesta Ritchie",
      "DirectPhone": "604.023.4024 x962",
      "FormalName": "Brakus, Hudson and Reichert",
      "CountryId": 604,
      "ContactId": 417,
      "ContactName": "Nienow LLC",
      "Retired": 596,
      "Rank": 898,
      "ActiveInterests": 370,
      "ContactDepartment": "",
      "ContactCountryId": 479,
      "ContactOrgNr": "1077783",
      "FaxPhone": "1-944-095-5914",
      "MobilePhone": "1-526-756-6507 x2375",
      "ContactPhone": "(941)245-6490 x3181",
      "AssociateName": "White, DuBuque and Graham",
      "AssociateId": 207,
      "UsePersonAddress": false,
      "ContactFax": "dolor",
      "Kanafname": "molestias",
      "Kanalname": "veniam",
      "Post1": "delectus",
      "Post2": "in",
      "Post3": "blanditiis",
      "EmailName": "lexie.larson@mayerstokes.ca",
      "ContactFullName": "Austin Roob",
      "ActiveErpLinks": 929,
      "TicketPriorityId": 262,
      "SupportLanguageId": 304,
      "SupportAssociateId": 318,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "repellat",
  "Xstop": false,
  "ActiveInterests": 341,
  "GroupId": 647,
  "ActiveStatusMonitorId": 39,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 704,
  "DbiAgentId": 561,
  "DbiLastSyncronized": "1998-06-08T04:22:26.1840946+02:00",
  "DbiKey": "doloribus",
  "DbiLastModified": "2016-03-24T04:22:26.1840946+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 361,
  "ActiveErpLinks": 613,
  "BounceEmails": [
    "juston@gislason.us",
    "sammy_purdy@rohantowne.biz"
  ],
  "Domains": [
    "voluptates",
    "tempora"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "354194156",
    "SuperOffice:2": "Renee Swaniawski PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "consequuntur",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "dolorem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 633,
  "Name": "Bahringer LLC",
  "Department": "",
  "OrgNr": "1460484",
  "Number1": "725548",
  "Number2": "1187311",
  "UpdatedDate": "2002-06-27T04:22:26.1997169+02:00",
  "CreatedDate": "2023-05-14T04:22:26.1997169+02:00",
  "Emails": [
    {
      "Value": "quo",
      "StrippedValue": "necessitatibus",
      "Description": "Up-sized secondary framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 262
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "necessitatibus",
      "Description": "Up-sized secondary framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 262
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 834,
      "Name": "Gleason-Leannon",
      "ToolTip": "Quasi dolores reprehenderit laboriosam consequatur magni atque sapiente.",
      "Deleted": false,
      "Rank": 197,
      "Type": "sed",
      "ColorBlock": 339,
      "IconHint": "facilis",
      "Selected": false,
      "LastChanged": "1998-08-16T04:22:26.1997169+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "temporibus",
      "StyleHint": "quam",
      "Hidden": false,
      "FullName": "Mrs. Marjory Kara Parker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 526
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aliquam",
      "StrippedValue": "tempore",
      "Description": "Managed 4th generation superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 967
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "tempore",
      "Description": "Managed 4th generation superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 967
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "quo",
      "Description": "Optimized maximized project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "quo",
      "Description": "Optimized maximized project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "unde",
      "StrippedValue": "laudantium",
      "Description": "Open-architected multi-tasking adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "laudantium",
      "Description": "Open-architected multi-tasking adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    }
  ],
  "Description": "Cloned 4th generation projection",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "exercitationem",
      "PersonId": 68,
      "Mrmrs": "aut",
      "Firstname": "Savion",
      "Lastname": "Bartell",
      "MiddleName": "Schamberger Inc and Sons",
      "Title": "magni",
      "Description": "Synergistic eco-centric firmware",
      "Email": "lauretta_kris@howellgutmann.biz",
      "FullName": "Mr. Cornelius Bennie Schultz DVM",
      "DirectPhone": "521.783.2966",
      "FormalName": "Howe Inc and Sons",
      "CountryId": 347,
      "ContactId": 380,
      "ContactName": "Carroll-Breitenberg",
      "Retired": 715,
      "Rank": 418,
      "ActiveInterests": 52,
      "ContactDepartment": "",
      "ContactCountryId": 777,
      "ContactOrgNr": "790450",
      "FaxPhone": "063-889-8240",
      "MobilePhone": "(564)170-7961 x710",
      "ContactPhone": "070.902.3869 x444",
      "AssociateName": "Block Group",
      "AssociateId": 470,
      "UsePersonAddress": false,
      "ContactFax": "maxime",
      "Kanafname": "aut",
      "Kanalname": "possimus",
      "Post1": "vitae",
      "Post2": "laborum",
      "Post3": "voluptas",
      "EmailName": "elfrieda.klein@muller.biz",
      "ContactFullName": "Carolanne Becker",
      "ActiveErpLinks": 667,
      "TicketPriorityId": 422,
      "SupportLanguageId": 277,
      "SupportAssociateId": 662,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "fuga",
  "Xstop": false,
  "ActiveInterests": 481,
  "GroupId": 470,
  "ActiveStatusMonitorId": 686,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 639,
  "DbiAgentId": 396,
  "DbiLastSyncronized": "2003-04-05T04:22:26.1997169+02:00",
  "DbiKey": "suscipit",
  "DbiLastModified": "2022-05-27T04:22:26.1997169+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 422,
  "ActiveErpLinks": 719,
  "BounceEmails": [
    "rhianna.cummings@walter.com",
    "enola_walsh@parker.uk"
  ],
  "Domains": [
    "eos",
    "nihil"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1278931952",
    "SuperOffice:2": "744498401"
  },
  "ExtraFields": {
    "ExtraFields1": "iusto",
    "ExtraFields2": "dolorum"
  },
  "CustomFields": {
    "CustomFields1": "totam",
    "CustomFields2": "earum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 803
    }
  }
}
```