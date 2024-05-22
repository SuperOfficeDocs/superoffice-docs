---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
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

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 594,
  "Name": "Tromp Inc and Sons",
  "Department": "",
  "OrgNr": "256432",
  "Number1": "499379",
  "Number2": "629027",
  "UpdatedDate": "2010-10-31T12:57:42.2451778+01:00",
  "CreatedDate": "2010-06-21T12:57:42.2451778+02:00",
  "Emails": [
    {
      "Value": "eius",
      "StrippedValue": "sit",
      "Description": "Object-based global instruction set"
    },
    {
      "Value": "eius",
      "StrippedValue": "sit",
      "Description": "Object-based global instruction set"
    }
  ],
  "Interests": [
    {
      "Id": 837,
      "Name": "Rodriguez-Mueller",
      "ToolTip": "Dolor molestiae eos.",
      "Deleted": false,
      "Rank": 919,
      "Type": "adipisci",
      "ColorBlock": 173,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2010-02-19T12:57:42.2451778+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "doloribus",
      "StyleHint": "explicabo",
      "Hidden": false,
      "FullName": "Alfonso Tillman"
    }
  ],
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "pariatur",
      "Description": "Persistent leading edge website"
    },
    {
      "Value": "quia",
      "StrippedValue": "pariatur",
      "Description": "Persistent leading edge website"
    }
  ],
  "Phones": [
    {
      "Value": "nam",
      "StrippedValue": "quia",
      "Description": "Adaptive neutral Graphical User Interface"
    },
    {
      "Value": "nam",
      "StrippedValue": "quia",
      "Description": "Adaptive neutral Graphical User Interface"
    }
  ],
  "Faxes": [
    {
      "Value": "quidem",
      "StrippedValue": "repellat",
      "Description": "Down-sized grid-enabled throughput"
    },
    {
      "Value": "quidem",
      "StrippedValue": "repellat",
      "Description": "Down-sized grid-enabled throughput"
    }
  ],
  "Description": "Up-sized object-oriented system engine",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eaque",
      "PersonId": 886,
      "Mrmrs": "nulla",
      "Firstname": "Carlotta",
      "Lastname": "Runolfsson",
      "MiddleName": "Stroman Group",
      "Title": "repudiandae",
      "Description": "Diverse real-time model",
      "Email": "emerald.brown@steubersteuber.com",
      "FullName": "Leda Graham Beier V",
      "DirectPhone": "1-484-981-2976 x756",
      "FormalName": "Raynor-Gutmann",
      "CountryId": 68,
      "ContactId": 306,
      "ContactName": "Casper Group",
      "Retired": 782,
      "Rank": 312,
      "ActiveInterests": 223,
      "ContactDepartment": "",
      "ContactCountryId": 941,
      "ContactOrgNr": "912915",
      "FaxPhone": "809.648.1175 x41829",
      "MobilePhone": "910.609.6637 x736",
      "ContactPhone": "216-528-2209 x22927",
      "AssociateName": "Lubowitz-Gaylord",
      "AssociateId": 177,
      "UsePersonAddress": false,
      "ContactFax": "totam",
      "Kanafname": "asperiores",
      "Kanalname": "ea",
      "Post1": "magni",
      "Post2": "eos",
      "Post3": "delectus",
      "EmailName": "julian@batz.co.uk",
      "ContactFullName": "Estevan Tromp",
      "ActiveErpLinks": 217,
      "TicketPriorityId": 71,
      "SupportLanguageId": 1001,
      "SupportAssociateId": 859,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "itaque",
  "Xstop": false,
  "ActiveInterests": 931,
  "GroupId": 646,
  "ActiveStatusMonitorId": 453,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 660,
  "DbiAgentId": 806,
  "DbiLastSyncronized": "1998-12-27T12:57:42.2451778+01:00",
  "DbiKey": "qui",
  "DbiLastModified": "2021-02-12T12:57:42.2451778+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 149,
  "ActiveErpLinks": 333,
  "BounceEmails": [
    "friedrich@rueckergulgowski.co.uk",
    "jeffry.heller@aufderhar.uk"
  ],
  "Domains": [
    "laudantium",
    "alias"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "474067808",
    "SuperOffice:2": "1628105166"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "quis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 1000,
  "Name": "Beahan Group",
  "Department": "",
  "OrgNr": "960044",
  "Number1": "1169920",
  "Number2": "848408",
  "UpdatedDate": "2004-04-21T12:57:42.2607991+02:00",
  "CreatedDate": "2004-05-19T12:57:42.2607991+02:00",
  "Emails": [
    {
      "Value": "excepturi",
      "StrippedValue": "et",
      "Description": "Profit-focused responsive intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 892
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "et",
      "Description": "Profit-focused responsive intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 892
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 269,
      "Name": "Gibson Inc and Sons",
      "ToolTip": "Vel quaerat rem sunt praesentium.",
      "Deleted": true,
      "Rank": 527,
      "Type": "adipisci",
      "ColorBlock": 194,
      "IconHint": "veniam",
      "Selected": false,
      "LastChanged": "2009-03-29T12:57:42.2607991+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quaerat",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Prof. Samara Mueller DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 733
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ipsum",
      "StrippedValue": "temporibus",
      "Description": "Realigned non-volatile website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    },
    {
      "Value": "ipsum",
      "StrippedValue": "temporibus",
      "Description": "Realigned non-volatile website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ea",
      "StrippedValue": "modi",
      "Description": "Vision-oriented cohesive neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 58
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "modi",
      "Description": "Vision-oriented cohesive neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 58
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "earum",
      "StrippedValue": "et",
      "Description": "Integrated real-time customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "et",
      "Description": "Integrated real-time customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    }
  ],
  "Description": "Face to face needs-based definition",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aliquid",
      "PersonId": 189,
      "Mrmrs": "eaque",
      "Firstname": "Gardner",
      "Lastname": "Smith",
      "MiddleName": "Oberbrunner, Berge and Mohr",
      "Title": "id",
      "Description": "Decentralized actuating task-force",
      "Email": "gloria@hane.co.uk",
      "FullName": "Felipa Grant",
      "DirectPhone": "908-815-6229",
      "FormalName": "Halvorson, Deckow and Huel",
      "CountryId": 900,
      "ContactId": 307,
      "ContactName": "Quitzon, Mayer and Hane",
      "Retired": 629,
      "Rank": 62,
      "ActiveInterests": 38,
      "ContactDepartment": "",
      "ContactCountryId": 933,
      "ContactOrgNr": "1083860",
      "FaxPhone": "306-210-4510",
      "MobilePhone": "(736)721-3020 x2613",
      "ContactPhone": "1-765-463-2312 x4172",
      "AssociateName": "Frami Inc and Sons",
      "AssociateId": 822,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "et",
      "Kanalname": "exercitationem",
      "Post1": "dolor",
      "Post2": "facere",
      "Post3": "iure",
      "EmailName": "horace@stanton.co.uk",
      "ContactFullName": "Ms. Ray Jacobs PhD",
      "ActiveErpLinks": 169,
      "TicketPriorityId": 698,
      "SupportLanguageId": 504,
      "SupportAssociateId": 1002,
      "CategoryName": "VIP Customer",
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
  "NoMailing": false,
  "Kananame": "ad",
  "Xstop": true,
  "ActiveInterests": 417,
  "GroupId": 286,
  "ActiveStatusMonitorId": 626,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 908,
  "DbiAgentId": 565,
  "DbiLastSyncronized": "2022-10-15T12:57:42.2607991+02:00",
  "DbiKey": "impedit",
  "DbiLastModified": "2000-10-04T12:57:42.2607991+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 691,
  "ActiveErpLinks": 369,
  "BounceEmails": [
    "geraldine.hodkiewicz@riceheaney.us",
    "marilie@hellerkuvalis.us"
  ],
  "Domains": [
    "at",
    "quo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Fredrick Gaylord",
    "SuperOffice:2": "Alanna Hilll"
  },
  "ExtraFields": {
    "ExtraFields1": "occaecati",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "tempore",
    "CustomFields2": "beatae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 437
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```