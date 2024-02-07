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
  "PersonId": 133,
  "Firstname": "Cyril",
  "MiddleName": "Ward, Thiel and Beier",
  "Lastname": "Adams",
  "Mrmrs": "rerum",
  "Title": "blanditiis",
  "UpdatedDate": "2000-11-12T16:54:55.6925073+01:00",
  "CreatedDate": "2022-06-15T16:54:55.6925073+02:00",
  "BirthDate": "1998-03-05T16:54:55.6925073+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aliquid",
      "StrippedValue": "natus",
      "Description": "Organic impactful internet solution"
    },
    {
      "Value": "aliquid",
      "StrippedValue": "natus",
      "Description": "Organic impactful internet solution"
    }
  ],
  "Description": "Vision-oriented client-server throughput",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "aliquam",
      "StrippedValue": "dignissimos",
      "Description": "User-centric needs-based moderator"
    },
    {
      "Value": "aliquam",
      "StrippedValue": "dignissimos",
      "Description": "User-centric needs-based moderator"
    }
  ],
  "Faxes": [
    {
      "Value": "quis",
      "StrippedValue": "laborum",
      "Description": "Organized hybrid neural-net"
    },
    {
      "Value": "quis",
      "StrippedValue": "laborum",
      "Description": "Organized hybrid neural-net"
    }
  ],
  "MobilePhones": [
    {
      "Value": "sed",
      "StrippedValue": "corrupti",
      "Description": "Business-focused system-worthy challenge"
    },
    {
      "Value": "sed",
      "StrippedValue": "corrupti",
      "Description": "Business-focused system-worthy challenge"
    }
  ],
  "OfficePhones": [
    {
      "Value": "adipisci",
      "StrippedValue": "dignissimos",
      "Description": "Persistent stable focus group"
    },
    {
      "Value": "adipisci",
      "StrippedValue": "dignissimos",
      "Description": "Persistent stable focus group"
    }
  ],
  "OtherPhones": [
    {
      "Value": "odio",
      "StrippedValue": "eum",
      "Description": "Future-proofed homogeneous ability"
    },
    {
      "Value": "odio",
      "StrippedValue": "eum",
      "Description": "Future-proofed homogeneous ability"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 849,
      "Name": "Dickinson-Mueller",
      "ToolTip": "Eos consequatur sequi dicta dignissimos.",
      "Deleted": false,
      "Rank": 77,
      "Type": "amet",
      "ColorBlock": 36,
      "IconHint": "aspernatur",
      "Selected": true,
      "LastChanged": "2013-12-06T16:54:55.6955075+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "modi",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Ms. Manuel Haley"
    }
  ],
  "PersonNumber": "867765",
  "FullName": "Lea Creola Kutch MD",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "culpa",
      "StrippedValue": "velit",
      "Description": "Virtual global migration"
    },
    {
      "Value": "culpa",
      "StrippedValue": "velit",
      "Description": "Virtual global migration"
    }
  ],
  "FormalName": "Kihn-Wisozk",
  "Address": null,
  "Post3": "incidunt",
  "Post2": "officiis",
  "Post1": "iure",
  "Kanalname": "facere",
  "Kanafname": "facere",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "nihil",
  "ActiveInterests": 647,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 641,
  "DbiKey": "praesentium",
  "DbiLastModified": "2023-10-21T16:54:55.6975072+02:00",
  "DbiLastSyncronized": "2012-06-20T16:54:55.6975072+02:00",
  "SentInfo": 441,
  "ShowContactTickets": 613,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "doloremque",
      "StrippedValue": "est",
      "Description": "Extended attitude-oriented analyzer"
    },
    {
      "Value": "doloremque",
      "StrippedValue": "est",
      "Description": "Extended attitude-oriented analyzer"
    }
  ],
  "InternetPhones": [
    {
      "Value": "officia",
      "StrippedValue": "qui",
      "Description": "Cross-group fault-tolerant definition"
    },
    {
      "Value": "officia",
      "StrippedValue": "qui",
      "Description": "Cross-group fault-tolerant definition"
    }
  ],
  "Source": 153,
  "ActiveErpLinks": 979,
  "ShipmentTypes": [
    {
      "Id": 347,
      "Name": "Barrows, Waelchi and Predovic",
      "ToolTip": "Accusantium temporibus et dolorem facere odio.",
      "Deleted": false,
      "Rank": 735,
      "Type": "aut",
      "ColorBlock": 294,
      "IconHint": "dolor",
      "Selected": true,
      "LastChanged": "2021-11-10T16:54:55.6975072+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iure",
      "StyleHint": "voluptatibus",
      "Hidden": false,
      "FullName": "Patrick Beatty"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 626,
      "Comment": "magni",
      "Registered": "2015-03-03T16:54:55.6985067+01:00",
      "RegisteredAssociateId": 486,
      "Updated": "2005-11-03T16:54:55.6985067+01:00",
      "UpdatedAssociateId": 789,
      "LegalBaseId": 570,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Jacobi, Ullrich and Mosciski",
      "ConsentPurposeId": 511,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "Pollich Group",
      "ConsentSourceId": 505,
      "ConsentSourceKey": "voluptatum",
      "ConsentSourceName": "Denesik-Kessler"
    }
  ],
  "BounceEmails": [
    "sedrick@wilderman.uk",
    "mireya@kunze.com"
  ],
  "ActiveStatusMonitorId": 169,
  "UserDefinedFields": {
    "SuperOffice:1": "Sophie Blanda",
    "SuperOffice:2": "1699869526"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "vitae"
  },
  "CustomFields": {
    "CustomFields1": "totam",
    "CustomFields2": "enim"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 361,
  "Firstname": "Maxime",
  "MiddleName": "Larson LLC",
  "Lastname": "Simonis",
  "Mrmrs": "consectetur",
  "Title": "quia",
  "UpdatedDate": "2000-08-22T16:54:55.7045068+02:00",
  "CreatedDate": "2003-09-27T16:54:55.7045068+02:00",
  "BirthDate": "2009-05-27T16:54:55.7045068+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sunt",
      "StrippedValue": "hic",
      "Description": "Persevering bi-directional projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "hic",
      "Description": "Persevering bi-directional projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    }
  ],
  "Description": "Open-source bi-directional concept",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "reiciendis",
      "Description": "Quality-focused reciprocal infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "reiciendis",
      "Description": "Quality-focused reciprocal infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "hic",
      "StrippedValue": "officia",
      "Description": "Exclusive human-resource task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 61
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "officia",
      "Description": "Exclusive human-resource task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 61
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "non",
      "StrippedValue": "reprehenderit",
      "Description": "Seamless logistical pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 359
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "reprehenderit",
      "Description": "Seamless logistical pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 359
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "corrupti",
      "StrippedValue": "dolorum",
      "Description": "Fundamental analyzing portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 224
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "dolorum",
      "Description": "Fundamental analyzing portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 224
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "velit",
      "Description": "Enhanced static alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 541
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "velit",
      "Description": "Enhanced static alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 541
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
      "Id": 753,
      "Name": "Turcotte Group",
      "ToolTip": "Minima provident quia voluptatem iusto tempora culpa.",
      "Deleted": false,
      "Rank": 526,
      "Type": "omnis",
      "ColorBlock": 112,
      "IconHint": "repellendus",
      "Selected": true,
      "LastChanged": "2018-12-31T16:54:55.7077491+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "optio",
      "StyleHint": "sit",
      "Hidden": true,
      "FullName": "Morris Hickle",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 183
        }
      }
    }
  ],
  "PersonNumber": "459190",
  "FullName": "Margot Kohler PhD",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "maiores",
      "Description": "Customizable zero administration pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 956
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "maiores",
      "Description": "Customizable zero administration pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 956
        }
      }
    }
  ],
  "FormalName": "Sipes, Goodwin and Prosacco",
  "Address": null,
  "Post3": "officia",
  "Post2": "aut",
  "Post1": "eos",
  "Kanalname": "odio",
  "Kanafname": "voluptates",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "animi",
  "ActiveInterests": 669,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 128,
  "DbiKey": "molestiae",
  "DbiLastModified": "2016-10-31T16:54:55.7097477+01:00",
  "DbiLastSyncronized": "2018-08-31T16:54:55.7097477+02:00",
  "SentInfo": 705,
  "ShowContactTickets": 819,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "vel",
      "StrippedValue": "vel",
      "Description": "Re-contextualized next generation access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 974
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "vel",
      "Description": "Re-contextualized next generation access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 974
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "tempore",
      "StrippedValue": "et",
      "Description": "Seamless upward-trending access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 180
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "et",
      "Description": "Seamless upward-trending access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 180
        }
      }
    }
  ],
  "Source": 744,
  "ActiveErpLinks": 906,
  "ShipmentTypes": [
    {
      "Id": 93,
      "Name": "Christiansen, Bashirian and Gleason",
      "ToolTip": "Explicabo numquam doloribus sunt aliquam.",
      "Deleted": true,
      "Rank": 904,
      "Type": "fugit",
      "ColorBlock": 599,
      "IconHint": "autem",
      "Selected": false,
      "LastChanged": "2007-01-17T16:54:55.7097477+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "a",
      "Hidden": true,
      "FullName": "Miss Immanuel Michaela O'Connell",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 804,
      "Comment": "a",
      "Registered": "2008-05-27T16:54:55.7107421+02:00",
      "RegisteredAssociateId": 849,
      "Updated": "2013-08-27T16:54:55.7107421+02:00",
      "UpdatedAssociateId": 609,
      "LegalBaseId": 437,
      "LegalBaseKey": "corporis",
      "LegalBaseName": "Shanahan, Ritchie and Kertzmann",
      "ConsentPurposeId": 49,
      "ConsentPurposeKey": "doloremque",
      "ConsentPurposeName": "Pacocha, Terry and Mills",
      "ConsentSourceId": 170,
      "ConsentSourceKey": "recusandae",
      "ConsentSourceName": "Doyle, Bruen and Corkery",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    }
  ],
  "BounceEmails": [
    "celine@kshlerin.co.uk",
    "luisa@connellypacocha.name"
  ],
  "ActiveStatusMonitorId": 664,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "972853243"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "nobis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 639
    }
  }
}
```