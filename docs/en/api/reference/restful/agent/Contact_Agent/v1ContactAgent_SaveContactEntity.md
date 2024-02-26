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
  "ContactId": 252,
  "Name": "Pfannerstill, Balistreri and Zemlak",
  "Department": "drive holistic niches",
  "OrgNr": "1058925",
  "Number1": "729387",
  "Number2": "990583",
  "UpdatedDate": "2017-03-13T10:30:23.2730672+01:00",
  "CreatedDate": "2011-02-05T10:30:23.2730672+01:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "non",
      "Description": "Optional empowering application"
    },
    {
      "Value": "ut",
      "StrippedValue": "non",
      "Description": "Optional empowering application"
    }
  ],
  "Interests": [
    {
      "Id": 672,
      "Name": "Jacobi-Stanton",
      "ToolTip": "Rerum reiciendis.",
      "Deleted": false,
      "Rank": 379,
      "Type": "accusamus",
      "ColorBlock": 560,
      "IconHint": "consequuntur",
      "Selected": true,
      "LastChanged": "2018-05-18T10:30:23.2730672+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "unde",
      "StyleHint": "natus",
      "Hidden": false,
      "FullName": "King Sawayn"
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "officia",
      "Description": "Customizable neutral emulation"
    },
    {
      "Value": "quo",
      "StrippedValue": "officia",
      "Description": "Customizable neutral emulation"
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "impedit",
      "Description": "Pre-emptive empowering parallelism"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "impedit",
      "Description": "Pre-emptive empowering parallelism"
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "itaque",
      "Description": "Advanced full-range functionalities"
    },
    {
      "Value": "sint",
      "StrippedValue": "itaque",
      "Description": "Advanced full-range functionalities"
    }
  ],
  "Description": "Extended dedicated capacity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "atque",
      "PersonId": 412,
      "Mrmrs": "quia",
      "Firstname": "Ardella",
      "Lastname": "Dickens",
      "MiddleName": "O'Hara-Hickle",
      "Title": "ut",
      "Description": "Synchronised context-sensitive pricing structure",
      "Email": "isaac.nader@schmitt.info",
      "FullName": "Herman Daniel",
      "DirectPhone": "(998)139-3294 x29669",
      "FormalName": "Flatley Inc and Sons",
      "CountryId": 487,
      "ContactId": 70,
      "ContactName": "Kuvalis-Carroll",
      "Retired": 296,
      "Rank": 864,
      "ActiveInterests": 616,
      "ContactDepartment": "",
      "ContactCountryId": 60,
      "ContactOrgNr": "678562",
      "FaxPhone": "817.741.1200",
      "MobilePhone": "937-928-9177 x0131",
      "ContactPhone": "134-983-3598 x30511",
      "AssociateName": "Harber, Towne and Hackett",
      "AssociateId": 42,
      "UsePersonAddress": false,
      "ContactFax": "esse",
      "Kanafname": "doloribus",
      "Kanalname": "ad",
      "Post1": "molestiae",
      "Post2": "mollitia",
      "Post3": "voluptas",
      "EmailName": "kraig@rempeloconnell.ca",
      "ContactFullName": "Reed West",
      "ActiveErpLinks": 21,
      "TicketPriorityId": 503,
      "SupportLanguageId": 302,
      "SupportAssociateId": 805,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "ut",
  "Xstop": true,
  "ActiveInterests": 180,
  "GroupId": 814,
  "ActiveStatusMonitorId": 641,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 17,
  "DbiAgentId": 54,
  "DbiLastSyncronized": "2011-11-20T10:30:23.2730672+01:00",
  "DbiKey": "vel",
  "DbiLastModified": "2017-06-07T10:30:23.2730672+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 246,
  "ActiveErpLinks": 161,
  "BounceEmails": [
    "maeve@jaskolski.uk",
    "friedrich@marquardt.us"
  ],
  "Domains": [
    "voluptatem",
    "sed"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Juston Homenick DDS",
    "SuperOffice:2": "1784943828"
  },
  "ExtraFields": {
    "ExtraFields1": "minima",
    "ExtraFields2": "explicabo"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "quibusdam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 970,
  "Name": "Collins, Nader and Weissnat",
  "Department": "",
  "OrgNr": "1555055",
  "Number1": "645734",
  "Number2": "632619",
  "UpdatedDate": "2012-09-18T10:30:23.2886916+02:00",
  "CreatedDate": "1999-04-06T10:30:23.2886916+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "iusto",
      "Description": "Down-sized content-based Graphical User Interface",
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
      "Value": "et",
      "StrippedValue": "iusto",
      "Description": "Down-sized content-based Graphical User Interface",
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
  "Interests": [
    {
      "Id": 936,
      "Name": "Morissette LLC",
      "ToolTip": "Esse dolorem itaque vitae.",
      "Deleted": false,
      "Rank": 63,
      "Type": "cumque",
      "ColorBlock": 903,
      "IconHint": "delectus",
      "Selected": true,
      "LastChanged": "1997-01-28T10:30:23.2886916+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "sequi",
      "Hidden": false,
      "FullName": "Heloise Runolfsdottir",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 548
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "necessitatibus",
      "Description": "Optimized multi-state forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 145
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "necessitatibus",
      "Description": "Optimized multi-state forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 145
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "rerum",
      "StrippedValue": "sed",
      "Description": "Optimized next generation throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "sed",
      "Description": "Optimized next generation throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "occaecati",
      "Description": "Pre-emptive global process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "occaecati",
      "Description": "Pre-emptive global process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    }
  ],
  "Description": "Persistent value-added data-warehouse",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ratione",
      "PersonId": 648,
      "Mrmrs": "sunt",
      "Firstname": "Adrianna",
      "Lastname": "Labadie",
      "MiddleName": "Price LLC",
      "Title": "impedit",
      "Description": "Reverse-engineered uniform implementation",
      "Email": "napoleon@oconner.ca",
      "FullName": "Pete Howe",
      "DirectPhone": "(427)405-1144 x69951",
      "FormalName": "Donnelly LLC",
      "CountryId": 580,
      "ContactId": 895,
      "ContactName": "Hane, Jast and Hackett",
      "Retired": 403,
      "Rank": 853,
      "ActiveInterests": 465,
      "ContactDepartment": "",
      "ContactCountryId": 569,
      "ContactOrgNr": "1268006",
      "FaxPhone": "1-638-810-3136",
      "MobilePhone": "480-563-9321 x06229",
      "ContactPhone": "1-539-206-9918 x2147",
      "AssociateName": "Schumm-McClure",
      "AssociateId": 941,
      "UsePersonAddress": false,
      "ContactFax": "sapiente",
      "Kanafname": "est",
      "Kanalname": "illum",
      "Post1": "quod",
      "Post2": "quo",
      "Post3": "minima",
      "EmailName": "darwin_strosin@hansenvonrueden.uk",
      "ContactFullName": "Kamryn Kovacek",
      "ActiveErpLinks": 613,
      "TicketPriorityId": 944,
      "SupportLanguageId": 424,
      "SupportAssociateId": 66,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 87
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "omnis",
  "Xstop": false,
  "ActiveInterests": 581,
  "GroupId": 90,
  "ActiveStatusMonitorId": 428,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 999,
  "DbiAgentId": 372,
  "DbiLastSyncronized": "2016-04-26T10:30:23.2886916+02:00",
  "DbiKey": "molestiae",
  "DbiLastModified": "2012-11-23T10:30:23.2886916+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 65,
  "ActiveErpLinks": 657,
  "BounceEmails": [
    "alize.nicolas@hodkiewiczstark.info",
    "jesse.johnson@kris.info"
  ],
  "Domains": [
    "aut",
    "quia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Rowena Klocko MD",
    "SuperOffice:2": "Ms. Boyd Bartoletti I"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "cupiditate"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 160
    }
  }
}
```