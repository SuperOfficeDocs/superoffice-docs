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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 423,
  "Firstname": "Lavon",
  "MiddleName": "Ratke-Labadie",
  "Lastname": "Kreiger",
  "Mrmrs": "ab",
  "Title": "adipisci",
  "UpdatedDate": "2015-11-04T02:38:21.5888948+01:00",
  "CreatedDate": "2021-10-20T02:38:21.5888948+02:00",
  "BirthDate": "2015-08-02T02:38:21.5888948+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "fugiat",
      "Description": "Self-enabling fresh-thinking intranet"
    },
    {
      "Value": "quia",
      "StrippedValue": "fugiat",
      "Description": "Self-enabling fresh-thinking intranet"
    }
  ],
  "Description": "Streamlined multimedia model",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "assumenda",
      "StrippedValue": "et",
      "Description": "Grass-roots regional matrix"
    },
    {
      "Value": "assumenda",
      "StrippedValue": "et",
      "Description": "Grass-roots regional matrix"
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Secured reciprocal archive"
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Secured reciprocal archive"
    }
  ],
  "MobilePhones": [
    {
      "Value": "illo",
      "StrippedValue": "corporis",
      "Description": "Universal impactful moratorium"
    },
    {
      "Value": "illo",
      "StrippedValue": "corporis",
      "Description": "Universal impactful moratorium"
    }
  ],
  "OfficePhones": [
    {
      "Value": "totam",
      "StrippedValue": "aut",
      "Description": "Robust homogeneous matrix"
    },
    {
      "Value": "totam",
      "StrippedValue": "aut",
      "Description": "Robust homogeneous matrix"
    }
  ],
  "OtherPhones": [
    {
      "Value": "amet",
      "StrippedValue": "aut",
      "Description": "Enhanced disintermediate definition"
    },
    {
      "Value": "amet",
      "StrippedValue": "aut",
      "Description": "Enhanced disintermediate definition"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 115,
      "Name": "Schamberger Group",
      "ToolTip": "Mollitia soluta perspiciatis dolorem.",
      "Deleted": false,
      "Rank": 274,
      "Type": "quasi",
      "ColorBlock": 977,
      "IconHint": "asperiores",
      "Selected": false,
      "LastChanged": "2013-05-28T02:38:21.5888948+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "corporis",
      "StyleHint": "quidem",
      "Hidden": false,
      "FullName": "Callie Volkman"
    }
  ],
  "PersonNumber": "1164574",
  "FullName": "Prof. Manuela Hoppe V",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "qui",
      "Description": "Intuitive cohesive productivity"
    },
    {
      "Value": "sit",
      "StrippedValue": "qui",
      "Description": "Intuitive cohesive productivity"
    }
  ],
  "FormalName": "Reichel Group",
  "Address": null,
  "Post3": "ullam",
  "Post2": "reiciendis",
  "Post1": "quia",
  "Kanalname": "et",
  "Kanafname": "quisquam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "doloribus",
  "ActiveInterests": 140,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 183,
  "DbiKey": "sunt",
  "DbiLastModified": "1998-09-22T02:38:21.5888948+02:00",
  "DbiLastSyncronized": "2009-08-19T02:38:21.5888948+02:00",
  "SentInfo": 389,
  "ShowContactTickets": 794,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "aut",
      "StrippedValue": "libero",
      "Description": "Customizable 24/7 migration"
    },
    {
      "Value": "aut",
      "StrippedValue": "libero",
      "Description": "Customizable 24/7 migration"
    }
  ],
  "InternetPhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "consequatur",
      "Description": "Object-based zero defect structure"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "consequatur",
      "Description": "Object-based zero defect structure"
    }
  ],
  "Source": 263,
  "ActiveErpLinks": 228,
  "ShipmentTypes": [
    {
      "Id": 779,
      "Name": "Howell LLC",
      "ToolTip": "Reprehenderit consequatur dolores sint omnis.",
      "Deleted": false,
      "Rank": 258,
      "Type": "laudantium",
      "ColorBlock": 466,
      "IconHint": "eum",
      "Selected": false,
      "LastChanged": "2021-12-29T02:38:21.5888948+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "suscipit",
      "StyleHint": "corrupti",
      "Hidden": false,
      "FullName": "Hazle Burdette Casper V"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 749,
      "Comment": "doloremque",
      "Registered": "2008-09-28T02:38:21.5888948+02:00",
      "RegisteredAssociateId": 153,
      "Updated": "2012-08-07T02:38:21.5888948+02:00",
      "UpdatedAssociateId": 690,
      "LegalBaseId": 746,
      "LegalBaseKey": "temporibus",
      "LegalBaseName": "Kiehn Inc and Sons",
      "ConsentPurposeId": 774,
      "ConsentPurposeKey": "eveniet",
      "ConsentPurposeName": "Hilpert, Cartwright and Hackett",
      "ConsentSourceId": 628,
      "ConsentSourceKey": "ea",
      "ConsentSourceName": "Schuppe, Doyle and Jenkins"
    }
  ],
  "BounceEmails": [
    "demetrius.schmeler@mayert.uk",
    "melissa.crooks@stromanconroy.biz"
  ],
  "ActiveStatusMonitorId": 302,
  "CreatedByFormId": 979,
  "UserDefinedFields": {
    "SuperOffice:1": "292563064",
    "SuperOffice:2": "Wade Koelpin"
  },
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "eligendi"
  },
  "CustomFields": {
    "CustomFields1": "dolorum",
    "CustomFields2": "quod"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 287,
  "Firstname": "Eula",
  "MiddleName": "Mayert-Wisoky",
  "Lastname": "Reichert",
  "Mrmrs": "suscipit",
  "Title": "occaecati",
  "UpdatedDate": "2008-01-21T02:38:21.5888948+01:00",
  "CreatedDate": "2019-09-02T02:38:21.5888948+02:00",
  "BirthDate": "2020-11-19T02:38:21.5888948+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quibusdam",
      "StrippedValue": "ratione",
      "Description": "Pre-emptive web-enabled complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 845
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "ratione",
      "Description": "Pre-emptive web-enabled complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 845
        }
      }
    }
  ],
  "Description": "Exclusive bi-directional flexibility",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "assumenda",
      "StrippedValue": "aspernatur",
      "Description": "Switchable actuating policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 653
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "aspernatur",
      "Description": "Switchable actuating policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 653
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "earum",
      "StrippedValue": "rerum",
      "Description": "Vision-oriented didactic algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "rerum",
      "Description": "Vision-oriented didactic algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quia",
      "StrippedValue": "voluptates",
      "Description": "Balanced bi-directional migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 53
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "voluptates",
      "Description": "Balanced bi-directional migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 53
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "aut",
      "StrippedValue": "amet",
      "Description": "Down-sized coherent internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 161
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "amet",
      "Description": "Down-sized coherent internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 161
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "qui",
      "StrippedValue": "velit",
      "Description": "Ergonomic fresh-thinking workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 969
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "velit",
      "Description": "Ergonomic fresh-thinking workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 969
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
      "Id": 405,
      "Name": "Kemmer-Yost",
      "ToolTip": "Est et alias quibusdam rem.",
      "Deleted": false,
      "Rank": 77,
      "Type": "sequi",
      "ColorBlock": 43,
      "IconHint": "vel",
      "Selected": false,
      "LastChanged": "2013-04-02T02:38:21.5888948+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "iste",
      "Hidden": true,
      "FullName": "Mckayla West",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 411
        }
      }
    }
  ],
  "PersonNumber": "834598",
  "FullName": "Luther Nicolas",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Ameliorated eco-centric service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Ameliorated eco-centric service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    }
  ],
  "FormalName": "Wiegand Inc and Sons",
  "Address": null,
  "Post3": "aut",
  "Post2": "officia",
  "Post1": "nesciunt",
  "Kanalname": "omnis",
  "Kanafname": "nesciunt",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dolore",
  "ActiveInterests": 60,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 590,
  "DbiKey": "voluptatem",
  "DbiLastModified": "1999-03-15T02:38:21.5888948+01:00",
  "DbiLastSyncronized": "2007-11-24T02:38:21.5888948+01:00",
  "SentInfo": 881,
  "ShowContactTickets": 490,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "omnis",
      "Description": "Multi-lateral bandwidth-monitored definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 763
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "omnis",
      "Description": "Multi-lateral bandwidth-monitored definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 763
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "quo",
      "Description": "Diverse human-resource collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 418
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quo",
      "Description": "Diverse human-resource collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 418
        }
      }
    }
  ],
  "Source": 941,
  "ActiveErpLinks": 212,
  "ShipmentTypes": [
    {
      "Id": 173,
      "Name": "Hermann LLC",
      "ToolTip": "Nihil expedita ex est voluptatem.",
      "Deleted": false,
      "Rank": 341,
      "Type": "magni",
      "ColorBlock": 413,
      "IconHint": "nesciunt",
      "Selected": false,
      "LastChanged": "2024-02-14T02:38:21.5888948+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nam",
      "StyleHint": "nesciunt",
      "Hidden": false,
      "FullName": "Jamarcus Abernathy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 711
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 854,
      "Comment": "consequatur",
      "Registered": "1998-03-26T02:38:21.5888948+01:00",
      "RegisteredAssociateId": 755,
      "Updated": "2004-06-25T02:38:21.5888948+02:00",
      "UpdatedAssociateId": 254,
      "LegalBaseId": 107,
      "LegalBaseKey": "unde",
      "LegalBaseName": "Murazik, Walter and Cartwright",
      "ConsentPurposeId": 907,
      "ConsentPurposeKey": "nostrum",
      "ConsentPurposeName": "Corwin Group",
      "ConsentSourceId": 926,
      "ConsentSourceKey": "labore",
      "ConsentSourceName": "Reilly, Stiedemann and Huels",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 294
        }
      }
    }
  ],
  "BounceEmails": [
    "tyshawn@hyattking.info",
    "amara@gottlieb.co.uk"
  ],
  "ActiveStatusMonitorId": 233,
  "CreatedByFormId": 592,
  "UserDefinedFields": {
    "SuperOffice:1": "Abbie Reichert",
    "SuperOffice:2": "Mr. May Toy"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "exercitationem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 937
    }
  }
}
```