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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 757,
  "Name": "Towne, Schumm and Powlowski",
  "Department": "",
  "OrgNr": "1426177",
  "Number1": "1551570",
  "Number2": "782677",
  "UpdatedDate": "2011-09-29T13:14:08.5085+02:00",
  "CreatedDate": "1999-06-04T13:14:08.5085+02:00",
  "Emails": [
    {
      "Value": "eos",
      "StrippedValue": "nam",
      "Description": "Advanced maximized implementation"
    },
    {
      "Value": "eos",
      "StrippedValue": "nam",
      "Description": "Advanced maximized implementation"
    }
  ],
  "Interests": [
    {
      "Id": 188,
      "Name": "Schuppe LLC",
      "ToolTip": "Nihil iste.",
      "Deleted": true,
      "Rank": 752,
      "Type": "excepturi",
      "ColorBlock": 182,
      "IconHint": "rem",
      "Selected": true,
      "LastChanged": "2013-09-09T13:14:08.5085+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "officiis",
      "Hidden": false,
      "FullName": "Bryce Christ Schultz I"
    }
  ],
  "Urls": [
    {
      "Value": "aliquam",
      "StrippedValue": "tenetur",
      "Description": "Down-sized high-level capability"
    },
    {
      "Value": "aliquam",
      "StrippedValue": "tenetur",
      "Description": "Down-sized high-level capability"
    }
  ],
  "Phones": [
    {
      "Value": "voluptate",
      "StrippedValue": "id",
      "Description": "Adaptive responsive secured line"
    },
    {
      "Value": "voluptate",
      "StrippedValue": "id",
      "Description": "Adaptive responsive secured line"
    }
  ],
  "Faxes": [
    {
      "Value": "omnis",
      "StrippedValue": "quidem",
      "Description": "Fundamental high-level implementation"
    },
    {
      "Value": "omnis",
      "StrippedValue": "quidem",
      "Description": "Fundamental high-level implementation"
    }
  ],
  "Description": "Organized tertiary frame",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sint",
      "PersonId": 939,
      "Mrmrs": "dignissimos",
      "Firstname": "Santino",
      "Lastname": "Herman",
      "MiddleName": "Smith, Sporer and Bernier",
      "Title": "et",
      "Description": "Seamless demand-driven productivity",
      "Email": "raina.kozey@ledner.uk",
      "FullName": "Mrs. Florian Dagmar Heaney",
      "DirectPhone": "152.635.8347 x205",
      "FormalName": "Green Group",
      "CountryId": 544,
      "ContactId": 558,
      "ContactName": "Glover Inc and Sons",
      "Retired": 973,
      "Rank": 579,
      "ActiveInterests": 611,
      "ContactDepartment": "",
      "ContactCountryId": 377,
      "ContactOrgNr": "597706",
      "FaxPhone": "(919)707-5054",
      "MobilePhone": "1-193-932-2208 x751",
      "ContactPhone": "(603)516-2514",
      "AssociateName": "Metz-Feest",
      "AssociateId": 834,
      "UsePersonAddress": true,
      "ContactFax": "dolor",
      "Kanafname": "dolore",
      "Kanalname": "rerum",
      "Post1": "ea",
      "Post2": "quibusdam",
      "Post3": "qui",
      "EmailName": "modesta_nader@reilly.info",
      "ContactFullName": "Parker Wolf",
      "ActiveErpLinks": 677,
      "TicketPriorityId": 556,
      "SupportLanguageId": 397,
      "SupportAssociateId": 195,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1368780"
    }
  ],
  "NoMailing": false,
  "Kananame": "nisi",
  "Xstop": false,
  "ActiveInterests": 768,
  "GroupId": 56,
  "ActiveStatusMonitorId": 490,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 333,
  "DbiAgentId": 245,
  "DbiLastSyncronized": "2019-04-09T13:14:08.5085+02:00",
  "DbiKey": "quia",
  "DbiLastModified": "2024-10-30T13:14:08.5085+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 704,
  "ActiveErpLinks": 855,
  "BounceEmails": [
    "eleanore@pouros.name",
    "dorothea@wolfjewess.com"
  ],
  "Domains": [
    "nam",
    "quia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Bessie Kshlerin",
    "SuperOffice:2": "Katelyn Wolf"
  },
  "ExtraFields": {
    "ExtraFields1": "laboriosam",
    "ExtraFields2": "officia"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "dolores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 238,
  "Name": "McDermott Group",
  "Department": "",
  "OrgNr": "934235",
  "Number1": "999420",
  "Number2": "1492796",
  "UpdatedDate": "2021-04-29T13:14:08.5241261+02:00",
  "CreatedDate": "2011-09-04T13:14:08.5241261+02:00",
  "Emails": [
    {
      "Value": "saepe",
      "StrippedValue": "fugiat",
      "Description": "Synchronised regional website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 193
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "fugiat",
      "Description": "Synchronised regional website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 193
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 377,
      "Name": "Mills, Bogisich and Predovic",
      "ToolTip": "Sit dolorem consectetur.",
      "Deleted": false,
      "Rank": 943,
      "Type": "veniam",
      "ColorBlock": 940,
      "IconHint": "at",
      "Selected": true,
      "LastChanged": "2015-02-15T13:14:08.5241261+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cupiditate",
      "StyleHint": "voluptate",
      "Hidden": false,
      "FullName": "Ms. Willy Goldner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vitae",
      "StrippedValue": "commodi",
      "Description": "Switchable holistic solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "commodi",
      "Description": "Switchable holistic solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ea",
      "StrippedValue": "accusamus",
      "Description": "Ergonomic full-range open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 18
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "accusamus",
      "Description": "Ergonomic full-range open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 18
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quisquam",
      "StrippedValue": "eveniet",
      "Description": "Proactive regional methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 10
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "eveniet",
      "Description": "Proactive regional methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 10
        }
      }
    }
  ],
  "Description": "Progressive demand-driven success",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ratione",
      "PersonId": 497,
      "Mrmrs": "nam",
      "Firstname": "Luther",
      "Lastname": "Metz",
      "MiddleName": "Zboncak LLC",
      "Title": "reprehenderit",
      "Description": "Vision-oriented fresh-thinking projection",
      "Email": "johathan.gaylord@heidenreichkuhn.com",
      "FullName": "Peyton Keebler",
      "DirectPhone": "654-183-5195 x7640",
      "FormalName": "Gerlach, Erdman and Orn",
      "CountryId": 828,
      "ContactId": 457,
      "ContactName": "Bartoletti, Ernser and Lebsack",
      "Retired": 534,
      "Rank": 626,
      "ActiveInterests": 376,
      "ContactDepartment": "",
      "ContactCountryId": 133,
      "ContactOrgNr": "688469",
      "FaxPhone": "1-756-116-5464 x089",
      "MobilePhone": "990.912.6906",
      "ContactPhone": "(669)674-5643",
      "AssociateName": "Cormier Inc and Sons",
      "AssociateId": 323,
      "UsePersonAddress": false,
      "ContactFax": "consequuntur",
      "Kanafname": "aut",
      "Kanalname": "officia",
      "Post1": "quibusdam",
      "Post2": "non",
      "Post3": "laborum",
      "EmailName": "oceane@pagachudson.name",
      "ContactFullName": "Mr. Vicente Hessel V",
      "ActiveErpLinks": 944,
      "TicketPriorityId": 624,
      "SupportLanguageId": 715,
      "SupportAssociateId": 194,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1183657",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 886
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quas",
  "Xstop": false,
  "ActiveInterests": 567,
  "GroupId": 670,
  "ActiveStatusMonitorId": 580,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 613,
  "DbiAgentId": 441,
  "DbiLastSyncronized": "2013-12-03T13:14:08.5241261+01:00",
  "DbiKey": "alias",
  "DbiLastModified": "2013-03-07T13:14:08.5241261+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 225,
  "ActiveErpLinks": 121,
  "BounceEmails": [
    "willie@rueckerdibbert.info",
    "lazaro.beer@feeney.uk"
  ],
  "Domains": [
    "a",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Lisa Zemlak"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "laudantium"
  },
  "CustomFields": {
    "CustomFields1": "sapiente",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 983
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```