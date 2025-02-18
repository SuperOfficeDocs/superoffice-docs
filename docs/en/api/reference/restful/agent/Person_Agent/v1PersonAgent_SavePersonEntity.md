---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
generated: true
---

# POST Agents/Person/SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is empty








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

The PersonEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer | Primary key |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| Mrmrs | String | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | String | Title |
| UpdatedDate | String | Last updated date  in UTC. |
| CreatedDate | String | Registered date  in UTC. |
| BirthDate | String | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | Array | A collection of the person's emails |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | Boolean | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | Array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | Array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | Array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | Array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | Array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | Array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | String | Alphanumeric user field |
| FullName | String | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | Boolean | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | Boolean | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | Boolean | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | Array | The urls related to this person. |
| FormalName | String | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | String | Postal address, used in Japanese versions only |
| Post2 | String | Postal address, used in Japanese versions only |
| Post1 | String | Postal address, used in Japanese versions only |
| Kanalname | String | Kana last name, used in Japanese versions only |
| Kanafname | String | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | String | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | Integer | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| DbiLastSyncronized | String | Last external syncronization. |
| SentInfo | Integer | Has information on username/password been sent (ejournal) |
| ShowContactTickets | Integer | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | Array |  |
| InternetPhones | Array |  |
| Source | Integer | How did we get this person? For future integration needs |
| ActiveErpLinks | Integer | How many active ERP links are there for this person? |
| ShipmentTypes | Array | The person's available and selected shipment types. |
| Consents | Array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | Integer | The form id of the form that created the person |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | int32 | The form id of the form that created the person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 392,
  "Firstname": "Edison",
  "MiddleName": "Kovacek Inc and Sons",
  "Lastname": "Marvin",
  "Mrmrs": "similique",
  "Title": "dolore",
  "UpdatedDate": "2004-07-06T14:32:03.2492713+02:00",
  "CreatedDate": "1998-03-15T14:32:03.2492713+01:00",
  "BirthDate": "1998-01-15T14:32:03.2492713+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "nobis",
      "StrippedValue": "quibusdam",
      "Description": "Intuitive analyzing approach"
    },
    {
      "Value": "nobis",
      "StrippedValue": "quibusdam",
      "Description": "Intuitive analyzing approach"
    }
  ],
  "Description": "Synergistic asynchronous service-desk",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "laborum",
      "StrippedValue": "doloribus",
      "Description": "Down-sized heuristic application"
    },
    {
      "Value": "laborum",
      "StrippedValue": "doloribus",
      "Description": "Down-sized heuristic application"
    }
  ],
  "Faxes": [
    {
      "Value": "modi",
      "StrippedValue": "illum",
      "Description": "Cross-platform transitional initiative"
    },
    {
      "Value": "modi",
      "StrippedValue": "illum",
      "Description": "Cross-platform transitional initiative"
    }
  ],
  "MobilePhones": [
    {
      "Value": "unde",
      "StrippedValue": "et",
      "Description": "Team-oriented 3rd generation contingency"
    },
    {
      "Value": "unde",
      "StrippedValue": "et",
      "Description": "Team-oriented 3rd generation contingency"
    }
  ],
  "OfficePhones": [
    {
      "Value": "eum",
      "StrippedValue": "a",
      "Description": "Team-oriented optimizing capability"
    },
    {
      "Value": "eum",
      "StrippedValue": "a",
      "Description": "Team-oriented optimizing capability"
    }
  ],
  "OtherPhones": [
    {
      "Value": "ullam",
      "StrippedValue": "dolor",
      "Description": "Multi-channelled bottom-line task-force"
    },
    {
      "Value": "ullam",
      "StrippedValue": "dolor",
      "Description": "Multi-channelled bottom-line task-force"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 452,
      "Name": "Jacobson Inc and Sons",
      "ToolTip": "Deserunt et.",
      "Deleted": false,
      "Rank": 85,
      "Type": "sit",
      "ColorBlock": 338,
      "IconHint": "ex",
      "Selected": false,
      "LastChanged": "2006-10-28T14:32:03.2648896+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "corporis",
      "StyleHint": "ipsam",
      "Hidden": false,
      "FullName": "Oswaldo Kling"
    }
  ],
  "PersonNumber": "385686",
  "FullName": "Hollie McCullough",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "quis",
      "StrippedValue": "consequatur",
      "Description": "Implemented real-time initiative"
    },
    {
      "Value": "quis",
      "StrippedValue": "consequatur",
      "Description": "Implemented real-time initiative"
    }
  ],
  "FormalName": "Stark-Koch",
  "Address": null,
  "Post3": "autem",
  "Post2": "velit",
  "Post1": "cupiditate",
  "Kanalname": "sit",
  "Kanafname": "illo",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "laborum",
  "ActiveInterests": 3,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 964,
  "DbiKey": "eaque",
  "DbiLastModified": "1999-07-23T14:32:03.2648896+02:00",
  "DbiLastSyncronized": "2023-05-28T14:32:03.2648896+02:00",
  "SentInfo": 991,
  "ShowContactTickets": 603,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sed",
      "StrippedValue": "blanditiis",
      "Description": "Right-sized discrete matrix"
    },
    {
      "Value": "sed",
      "StrippedValue": "blanditiis",
      "Description": "Right-sized discrete matrix"
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "non",
      "Description": "User-friendly system-worthy complexity"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "non",
      "Description": "User-friendly system-worthy complexity"
    }
  ],
  "Source": 23,
  "ActiveErpLinks": 300,
  "ShipmentTypes": [
    {
      "Id": 585,
      "Name": "Ankunding, Sanford and Trantow",
      "ToolTip": "Commodi ex eos quasi optio excepturi.",
      "Deleted": true,
      "Rank": 441,
      "Type": "vel",
      "ColorBlock": 30,
      "IconHint": "voluptatibus",
      "Selected": false,
      "LastChanged": "2009-03-20T14:32:03.2648896+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laboriosam",
      "StyleHint": "sed",
      "Hidden": true,
      "FullName": "Syble Haag"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 682,
      "Comment": "maxime",
      "Registered": "2023-03-02T14:32:03.2648896+01:00",
      "RegisteredAssociateId": 887,
      "Updated": "2004-09-11T14:32:03.2648896+02:00",
      "UpdatedAssociateId": 699,
      "LegalBaseId": 436,
      "LegalBaseKey": "iste",
      "LegalBaseName": "Runolfsdottir, Harvey and McDermott",
      "ConsentPurposeId": 874,
      "ConsentPurposeKey": "dolorem",
      "ConsentPurposeName": "Schneider Group",
      "ConsentSourceId": 201,
      "ConsentSourceKey": "tenetur",
      "ConsentSourceName": "Denesik-Hand"
    }
  ],
  "BounceEmails": [
    "leonie.shanahan@price.us",
    "oswald@blandanader.name"
  ],
  "ActiveStatusMonitorId": 306,
  "CreatedByFormId": 525,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Ms. Lou Lemuel Schulist II"
  },
  "ExtraFields": {
    "ExtraFields1": "molestiae",
    "ExtraFields2": "totam"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "quasi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 561,
  "Firstname": "Marcelle",
  "MiddleName": "Ziemann, Fadel and Hilpert",
  "Lastname": "Parker",
  "Mrmrs": "inventore",
  "Title": "aut",
  "UpdatedDate": "2006-12-05T14:32:03.2648896+01:00",
  "CreatedDate": "2022-09-14T14:32:03.2648896+02:00",
  "BirthDate": "2005-07-22T14:32:03.2648896+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quod",
      "StrippedValue": "ipsa",
      "Description": "Synergistic bandwidth-monitored conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 836
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "ipsa",
      "Description": "Synergistic bandwidth-monitored conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 836
        }
      }
    }
  ],
  "Description": "Polarised transitional encoding",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ad",
      "StrippedValue": "rerum",
      "Description": "Configurable systemic neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 877
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "rerum",
      "Description": "Configurable systemic neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 877
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consequuntur",
      "StrippedValue": "dolorem",
      "Description": "Future-proofed logistical Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 373
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "dolorem",
      "Description": "Future-proofed logistical Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 373
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "saepe",
      "StrippedValue": "incidunt",
      "Description": "Upgradable hybrid strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 238
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "incidunt",
      "Description": "Upgradable hybrid strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 238
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "occaecati",
      "StrippedValue": "porro",
      "Description": "Innovative disintermediate open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 547
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "porro",
      "Description": "Innovative disintermediate open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 547
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "quis",
      "Description": "Polarised full-range internet solution",
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
      "Value": "et",
      "StrippedValue": "quis",
      "Description": "Polarised full-range internet solution",
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
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 720,
      "Name": "Schmidt-Ullrich",
      "ToolTip": "Rerum non asperiores.",
      "Deleted": true,
      "Rank": 32,
      "Type": "voluptatum",
      "ColorBlock": 320,
      "IconHint": "necessitatibus",
      "Selected": true,
      "LastChanged": "2006-07-21T14:32:03.2805145+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "expedita",
      "StyleHint": "officia",
      "Hidden": true,
      "FullName": "Alden Kertzmann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 543
        }
      }
    }
  ],
  "PersonNumber": "1271141",
  "FullName": "Ms. Katlyn Brakus",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "aliquid",
      "StrippedValue": "dolores",
      "Description": "Automated motivating pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 130
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "dolores",
      "Description": "Automated motivating pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 130
        }
      }
    }
  ],
  "FormalName": "Pfeffer-Runolfsdottir",
  "Address": null,
  "Post3": "corporis",
  "Post2": "expedita",
  "Post1": "ut",
  "Kanalname": "vel",
  "Kanafname": "sunt",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "reiciendis",
  "ActiveInterests": 672,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 58,
  "DbiKey": "rerum",
  "DbiLastModified": "2006-03-17T14:32:03.2805145+01:00",
  "DbiLastSyncronized": "2004-11-13T14:32:03.2805145+01:00",
  "SentInfo": 62,
  "ShowContactTickets": 782,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quae",
      "StrippedValue": "voluptatem",
      "Description": "Optimized executive local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "voluptatem",
      "Description": "Optimized executive local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "autem",
      "StrippedValue": "odit",
      "Description": "Virtual tertiary complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 734
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "odit",
      "Description": "Virtual tertiary complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 734
        }
      }
    }
  ],
  "Source": 754,
  "ActiveErpLinks": 78,
  "ShipmentTypes": [
    {
      "Id": 120,
      "Name": "Anderson, Leannon and Little",
      "ToolTip": "Quis quo ipsam dignissimos sed sequi.",
      "Deleted": false,
      "Rank": 247,
      "Type": "qui",
      "ColorBlock": 652,
      "IconHint": "consequatur",
      "Selected": false,
      "LastChanged": "1999-04-21T14:32:03.2805145+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "labore",
      "Hidden": false,
      "FullName": "Ms. Makenzie O'Connell Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 146
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 871,
      "Comment": "natus",
      "Registered": "2014-09-03T14:32:03.2805145+02:00",
      "RegisteredAssociateId": 379,
      "Updated": "2001-11-28T14:32:03.2805145+01:00",
      "UpdatedAssociateId": 450,
      "LegalBaseId": 91,
      "LegalBaseKey": "sit",
      "LegalBaseName": "Ritchie, Romaguera and Hansen",
      "ConsentPurposeId": 921,
      "ConsentPurposeKey": "voluptas",
      "ConsentPurposeName": "Welch-Kessler",
      "ConsentSourceId": 427,
      "ConsentSourceKey": "quia",
      "ConsentSourceName": "Gerlach Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 759
        }
      }
    }
  ],
  "BounceEmails": [
    "madonna.cronin@sporer.us",
    "newell_okuneva@auer.name"
  ],
  "ActiveStatusMonitorId": 318,
  "CreatedByFormId": 281,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Mrs. Jessy Leora Ruecker"
  },
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "vitae"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 499
    }
  }
}
```