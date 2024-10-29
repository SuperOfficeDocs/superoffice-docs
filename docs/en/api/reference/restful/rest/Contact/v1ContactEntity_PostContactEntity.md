---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
```


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

## Request Body: newEntity 

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

### Response body: ContactEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 71,
  "Name": "Kassulke-Schulist",
  "Department": "",
  "OrgNr": "1518976",
  "Number1": "711846",
  "Number2": "1038802",
  "UpdatedDate": "1998-05-27T13:14:10.7110321+02:00",
  "CreatedDate": "2021-01-21T13:14:10.7110321+01:00",
  "Emails": [
    {
      "Value": "beatae",
      "StrippedValue": "quia",
      "Description": "Synergized coherent forecast"
    },
    {
      "Value": "beatae",
      "StrippedValue": "quia",
      "Description": "Synergized coherent forecast"
    }
  ],
  "Interests": [
    {
      "Id": 714,
      "Name": "Davis Inc and Sons",
      "ToolTip": "Nostrum molestias aut.",
      "Deleted": false,
      "Rank": 536,
      "Type": "atque",
      "ColorBlock": 757,
      "IconHint": "rem",
      "Selected": false,
      "LastChanged": "2007-04-01T13:14:10.7110321+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quo",
      "StyleHint": "harum",
      "Hidden": false,
      "FullName": "Armani Fahey"
    }
  ],
  "Urls": [
    {
      "Value": "illo",
      "StrippedValue": "eligendi",
      "Description": "Face to face full-range moratorium"
    },
    {
      "Value": "illo",
      "StrippedValue": "eligendi",
      "Description": "Face to face full-range moratorium"
    }
  ],
  "Phones": [
    {
      "Value": "fugit",
      "StrippedValue": "nihil",
      "Description": "Virtual mission-critical encryption"
    },
    {
      "Value": "fugit",
      "StrippedValue": "nihil",
      "Description": "Virtual mission-critical encryption"
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "exercitationem",
      "Description": "Operative disintermediate encoding"
    },
    {
      "Value": "et",
      "StrippedValue": "exercitationem",
      "Description": "Operative disintermediate encoding"
    }
  ],
  "Description": "Quality-focused intangible forecast",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "provident",
      "PersonId": 533,
      "Mrmrs": "maiores",
      "Firstname": "Emilia",
      "Lastname": "Mosciski",
      "MiddleName": "Wisoky, Prosacco and Stehr",
      "Title": "minus",
      "Description": "Business-focused tertiary knowledge user",
      "Email": "viviane_wunsch@dooleyrunolfsdottir.ca",
      "FullName": "Roberta Orn",
      "DirectPhone": "(482)295-9543 x8621",
      "FormalName": "Schuster, Wolf and Zulauf",
      "CountryId": 154,
      "ContactId": 84,
      "ContactName": "Simonis Group",
      "Retired": 653,
      "Rank": 832,
      "ActiveInterests": 542,
      "ContactDepartment": "",
      "ContactCountryId": 382,
      "ContactOrgNr": "407438",
      "FaxPhone": "(942)408-1997 x251",
      "MobilePhone": "(021)606-8508",
      "ContactPhone": "(853)493-9550 x194",
      "AssociateName": "Berge, Ernser and Price",
      "AssociateId": 208,
      "UsePersonAddress": true,
      "ContactFax": "inventore",
      "Kanafname": "porro",
      "Kanalname": "aut",
      "Post1": "velit",
      "Post2": "ut",
      "Post3": "dolores",
      "EmailName": "jarret_swaniawski@stanton.info",
      "ContactFullName": "Miss Kyla Stephan Bashirian PhD",
      "ActiveErpLinks": 480,
      "TicketPriorityId": 893,
      "SupportLanguageId": 238,
      "SupportAssociateId": 456,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "eos",
  "Xstop": false,
  "ActiveInterests": 288,
  "GroupId": 814,
  "ActiveStatusMonitorId": 29,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 857,
  "DbiAgentId": 269,
  "DbiLastSyncronized": "2019-08-25T13:14:10.7110321+02:00",
  "DbiKey": "velit",
  "DbiLastModified": "1998-06-05T13:14:10.7110321+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 31,
  "ActiveErpLinks": 728,
  "BounceEmails": [
    "hortense@farrell.uk",
    "kade.kovacek@kuhn.ca"
  ],
  "Domains": [
    "dolorem",
    "dignissimos"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Humberto Anderson",
    "SuperOffice:2": "Elfrieda McDermott"
  },
  "ExtraFields": {
    "ExtraFields1": "nulla",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "inventore",
    "CustomFields2": "dolores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 353,
  "Name": "D'Amore-Windler",
  "Department": "",
  "OrgNr": "1409057",
  "Number1": "743353",
  "Number2": "1751316",
  "UpdatedDate": "2008-11-23T13:14:10.7110321+01:00",
  "CreatedDate": "2017-06-14T13:14:10.7110321+02:00",
  "Emails": [
    {
      "Value": "cum",
      "StrippedValue": "possimus",
      "Description": "Profound impactful implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 840
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "possimus",
      "Description": "Profound impactful implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 840
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 519,
      "Name": "Stanton Group",
      "ToolTip": "Dolor modi non tempora culpa.",
      "Deleted": false,
      "Rank": 134,
      "Type": "quae",
      "ColorBlock": 747,
      "IconHint": "molestias",
      "Selected": true,
      "LastChanged": "2000-01-30T13:14:10.7110321+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "nemo",
      "Hidden": false,
      "FullName": "Ardith Leannon",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 483
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "magnam",
      "StrippedValue": "non",
      "Description": "Integrated bi-directional approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "non",
      "Description": "Integrated bi-directional approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "id",
      "StrippedValue": "est",
      "Description": "Ameliorated full-range contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "est",
      "Description": "Ameliorated full-range contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "voluptatem",
      "Description": "Implemented even-keeled throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 966
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "voluptatem",
      "Description": "Implemented even-keeled throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 966
        }
      }
    }
  ],
  "Description": "Intuitive value-added database",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eveniet",
      "PersonId": 35,
      "Mrmrs": "ipsam",
      "Firstname": "Stella",
      "Lastname": "Dietrich",
      "MiddleName": "Witting-Dach",
      "Title": "nostrum",
      "Description": "Self-enabling local alliance",
      "Email": "bart@thompson.name",
      "FullName": "Ursula Altenwerth",
      "DirectPhone": "(458)697-9096",
      "FormalName": "Breitenberg, Lynch and Stamm",
      "CountryId": 251,
      "ContactId": 520,
      "ContactName": "Hickle, Renner and Harvey",
      "Retired": 713,
      "Rank": 677,
      "ActiveInterests": 686,
      "ContactDepartment": "",
      "ContactCountryId": 162,
      "ContactOrgNr": "1607013",
      "FaxPhone": "731-010-2024 x5233",
      "MobilePhone": "1-592-569-8264 x98136",
      "ContactPhone": "1-875-173-0363 x7195",
      "AssociateName": "Wiegand, Harvey and Hand",
      "AssociateId": 27,
      "UsePersonAddress": true,
      "ContactFax": "quia",
      "Kanafname": "et",
      "Kanalname": "eligendi",
      "Post1": "illum",
      "Post2": "eos",
      "Post3": "aliquam",
      "EmailName": "norbert@wilkinsonchamplin.biz",
      "ContactFullName": "Dr. Jillian Maurice Wiegand",
      "ActiveErpLinks": 838,
      "TicketPriorityId": 417,
      "SupportLanguageId": 416,
      "SupportAssociateId": 416,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 82
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ipsam",
  "Xstop": false,
  "ActiveInterests": 249,
  "GroupId": 685,
  "ActiveStatusMonitorId": 462,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 278,
  "DbiAgentId": 261,
  "DbiLastSyncronized": "2013-07-20T13:14:10.7110321+02:00",
  "DbiKey": "accusantium",
  "DbiLastModified": "2000-09-12T13:14:10.7110321+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 87,
  "ActiveErpLinks": 669,
  "BounceEmails": [
    "dawn@steuberdibbert.name",
    "ismael@jones.co.uk"
  ],
  "Domains": [
    "temporibus",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "538230962",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "nobis",
    "ExtraFields2": "neque"
  },
  "CustomFields": {
    "CustomFields1": "beatae",
    "CustomFields2": "reiciendis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 655
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```