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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 137,
  "Name": "Grant-Jewess",
  "Department": "",
  "OrgNr": "1114278",
  "Number1": "604284",
  "Number2": "1077798",
  "UpdatedDate": "2005-09-06T12:57:42.2139348+02:00",
  "CreatedDate": "1997-10-06T12:57:42.2139348+02:00",
  "Emails": [
    {
      "Value": "error",
      "StrippedValue": "error",
      "Description": "Visionary cohesive implementation"
    },
    {
      "Value": "error",
      "StrippedValue": "error",
      "Description": "Visionary cohesive implementation"
    }
  ],
  "Interests": [
    {
      "Id": 295,
      "Name": "Gusikowski LLC",
      "ToolTip": "Culpa eum dolore similique eaque.",
      "Deleted": false,
      "Rank": 323,
      "Type": "culpa",
      "ColorBlock": 801,
      "IconHint": "rerum",
      "Selected": false,
      "LastChanged": "2024-03-26T12:57:42.2139348+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officiis",
      "StyleHint": "repellendus",
      "Hidden": false,
      "FullName": "Matilda Hyatt"
    }
  ],
  "Urls": [
    {
      "Value": "ducimus",
      "StrippedValue": "enim",
      "Description": "Assimilated eco-centric migration"
    },
    {
      "Value": "ducimus",
      "StrippedValue": "enim",
      "Description": "Assimilated eco-centric migration"
    }
  ],
  "Phones": [
    {
      "Value": "eius",
      "StrippedValue": "maiores",
      "Description": "Customer-focused eco-centric orchestration"
    },
    {
      "Value": "eius",
      "StrippedValue": "maiores",
      "Description": "Customer-focused eco-centric orchestration"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptate",
      "StrippedValue": "sed",
      "Description": "Optimized web-enabled throughput"
    },
    {
      "Value": "voluptate",
      "StrippedValue": "sed",
      "Description": "Optimized web-enabled throughput"
    }
  ],
  "Description": "Proactive bifurcated software",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nulla",
      "PersonId": 294,
      "Mrmrs": "laboriosam",
      "Firstname": "Cicero",
      "Lastname": "Emmerich",
      "MiddleName": "Gislason-Reichel",
      "Title": "minus",
      "Description": "Upgradable 24/7 encoding",
      "Email": "irving@gleichner.ca",
      "FullName": "Miss Serenity Pollich Jr.",
      "DirectPhone": "(996)602-2885",
      "FormalName": "Kuhlman, Medhurst and Funk",
      "CountryId": 167,
      "ContactId": 376,
      "ContactName": "Howell, Walker and Stamm",
      "Retired": 305,
      "Rank": 583,
      "ActiveInterests": 681,
      "ContactDepartment": "",
      "ContactCountryId": 133,
      "ContactOrgNr": "452227",
      "FaxPhone": "862.935.4389 x16598",
      "MobilePhone": "(056)067-0275",
      "ContactPhone": "1-487-084-8826 x10379",
      "AssociateName": "Weimann, Smitham and Dicki",
      "AssociateId": 83,
      "UsePersonAddress": false,
      "ContactFax": "expedita",
      "Kanafname": "aut",
      "Kanalname": "voluptas",
      "Post1": "nostrum",
      "Post2": "aliquid",
      "Post3": "recusandae",
      "EmailName": "freddie@moore.ca",
      "ContactFullName": "Cordia Hyatt",
      "ActiveErpLinks": 516,
      "TicketPriorityId": 491,
      "SupportLanguageId": 312,
      "SupportAssociateId": 643,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "rerum",
  "Xstop": false,
  "ActiveInterests": 158,
  "GroupId": 743,
  "ActiveStatusMonitorId": 38,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 51,
  "DbiAgentId": 394,
  "DbiLastSyncronized": "2004-02-27T12:57:42.2139348+01:00",
  "DbiKey": "delectus",
  "DbiLastModified": "2009-03-28T12:57:42.2139348+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 605,
  "ActiveErpLinks": 971,
  "BounceEmails": [
    "colton@hamill.uk",
    "alisa_goodwin@mayert.us"
  ],
  "Domains": [
    "aliquid",
    "sunt"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Shawn Sipes",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "animi"
  },
  "CustomFields": {
    "CustomFields1": "nemo",
    "CustomFields2": "nihil"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 366,
  "Name": "Kub, Gottlieb and Marks",
  "Department": "",
  "OrgNr": "969083",
  "Number1": "937972",
  "Number2": "943207",
  "UpdatedDate": "2018-02-10T12:57:42.2295563+01:00",
  "CreatedDate": "2014-05-14T12:57:42.2295563+02:00",
  "Emails": [
    {
      "Value": "at",
      "StrippedValue": "enim",
      "Description": "Self-enabling zero tolerance migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 941
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "enim",
      "Description": "Self-enabling zero tolerance migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 941
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 923,
      "Name": "Muller-Roob",
      "ToolTip": "Vel ratione id voluptas provident voluptate odio.",
      "Deleted": true,
      "Rank": 597,
      "Type": "repellat",
      "ColorBlock": 675,
      "IconHint": "laudantium",
      "Selected": false,
      "LastChanged": "1999-08-25T12:57:42.2295563+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Ms. Fabiola Finn Considine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 229
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolor",
      "StrippedValue": "qui",
      "Description": "Intuitive context-sensitive data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 554
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "qui",
      "Description": "Intuitive context-sensitive data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 554
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "labore",
      "StrippedValue": "voluptatem",
      "Description": "Programmable bifurcated core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "voluptatem",
      "Description": "Programmable bifurcated core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "deserunt",
      "StrippedValue": "eaque",
      "Description": "Public-key scalable paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 866
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "eaque",
      "Description": "Public-key scalable paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 866
        }
      }
    }
  ],
  "Description": "Centralized scalable time-frame",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "omnis",
      "PersonId": 608,
      "Mrmrs": "ea",
      "Firstname": "Andy",
      "Lastname": "Lindgren",
      "MiddleName": "Schmitt-Swaniawski",
      "Title": "quam",
      "Description": "Secured interactive protocol",
      "Email": "kory_hoppe@reinger.us",
      "FullName": "Donny Schuppe",
      "DirectPhone": "(596)059-5829",
      "FormalName": "Powlowski, Gislason and Cole",
      "CountryId": 978,
      "ContactId": 298,
      "ContactName": "Wilderman Inc and Sons",
      "Retired": 703,
      "Rank": 575,
      "ActiveInterests": 205,
      "ContactDepartment": "envisioneer global markets",
      "ContactCountryId": 222,
      "ContactOrgNr": "1769520",
      "FaxPhone": "874.064.6968 x530",
      "MobilePhone": "(051)055-5540 x11028",
      "ContactPhone": "1-096-539-2840",
      "AssociateName": "Lynch-Ritchie",
      "AssociateId": 727,
      "UsePersonAddress": false,
      "ContactFax": "perspiciatis",
      "Kanafname": "distinctio",
      "Kanalname": "velit",
      "Post1": "ea",
      "Post2": "officia",
      "Post3": "aliquam",
      "EmailName": "rosetta@erdman.biz",
      "ContactFullName": "Jamison Borer",
      "ActiveErpLinks": 563,
      "TicketPriorityId": 259,
      "SupportLanguageId": 182,
      "SupportAssociateId": 252,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quibusdam",
  "Xstop": false,
  "ActiveInterests": 979,
  "GroupId": 137,
  "ActiveStatusMonitorId": 395,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 405,
  "DbiAgentId": 127,
  "DbiLastSyncronized": "2023-04-08T12:57:42.2295563+02:00",
  "DbiKey": "dolorem",
  "DbiLastModified": "2011-04-01T12:57:42.2295563+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 61,
  "ActiveErpLinks": 353,
  "BounceEmails": [
    "shaina_bergstrom@mitchell.uk",
    "ottilie@bednar.name"
  ],
  "Domains": [
    "quo",
    "dolores"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Jacques Beatty",
    "SuperOffice:2": "Ms. Lenna Ernser II"
  },
  "ExtraFields": {
    "ExtraFields1": "alias",
    "ExtraFields2": "natus"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "reprehenderit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 165
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```