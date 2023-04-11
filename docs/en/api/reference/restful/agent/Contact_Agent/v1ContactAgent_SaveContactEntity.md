---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "ContactId": 766,
  "Name": "Gleason Group",
  "Department": "",
  "OrgNr": "763204",
  "Number1": "1068631",
  "Number2": "940206",
  "UpdatedDate": "2013-02-27T15:29:21.0707856+01:00",
  "CreatedDate": "2014-03-14T15:29:21.0707856+01:00",
  "Emails": [
    {
      "Value": "in",
      "StrippedValue": "dolores",
      "Description": "Reduced national Graphical User Interface"
    },
    {
      "Value": "in",
      "StrippedValue": "dolores",
      "Description": "Reduced national Graphical User Interface"
    }
  ],
  "Interests": [
    {
      "Id": 296,
      "Name": "Gutmann Inc and Sons",
      "ToolTip": "Dolorem accusamus a nemo magnam voluptatem odit.",
      "Deleted": false,
      "Rank": 999,
      "Type": "voluptatem",
      "ColorBlock": 999,
      "IconHint": "debitis",
      "Selected": true,
      "LastChanged": "2019-05-28T15:29:21.0712851+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "saepe",
      "Hidden": true,
      "FullName": "Cecil Aracely Koepp I"
    }
  ],
  "Urls": [
    {
      "Value": "amet",
      "StrippedValue": "laudantium",
      "Description": "Persevering transitional initiative"
    },
    {
      "Value": "amet",
      "StrippedValue": "laudantium",
      "Description": "Persevering transitional initiative"
    }
  ],
  "Phones": [
    {
      "Value": "in",
      "StrippedValue": "quis",
      "Description": "Cross-group 24/7 attitude"
    },
    {
      "Value": "in",
      "StrippedValue": "quis",
      "Description": "Cross-group 24/7 attitude"
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "adipisci",
      "Description": "Cross-platform global paradigm"
    },
    {
      "Value": "non",
      "StrippedValue": "adipisci",
      "Description": "Cross-platform global paradigm"
    }
  ],
  "Description": "Vision-oriented demand-driven throughput",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 60,
      "Mrmrs": "voluptas",
      "Firstname": "Logan",
      "Lastname": "Walter",
      "MiddleName": "Heller-Stark",
      "Title": "rerum",
      "Description": "Streamlined even-keeled matrices",
      "Email": "luisa@predovicwalker.us",
      "FullName": "Miss Valentine Lockman I",
      "DirectPhone": "515-468-2417 x8711",
      "FormalName": "Stracke LLC",
      "CountryId": 695,
      "ContactId": 842,
      "ContactName": "Stroman, O'Kon and Feil",
      "Retired": 969,
      "Rank": 120,
      "ActiveInterests": 330,
      "ContactDepartment": "leverage enterprise solutions",
      "ContactCountryId": 907,
      "ContactOrgNr": "724884",
      "FaxPhone": "195.673.6504 x17138",
      "MobilePhone": "336.134.4938 x20541",
      "ContactPhone": "677-818-8393 x295",
      "AssociateName": "Vandervort, Kohler and Grimes",
      "AssociateId": 169,
      "UsePersonAddress": true,
      "ContactFax": "sint",
      "Kanafname": "dolor",
      "Kanalname": "et",
      "Post1": "distinctio",
      "Post2": "enim",
      "Post3": "et",
      "EmailName": "callie@willms.com",
      "ContactFullName": "Mrs. Dorris Faye Purdy",
      "ActiveErpLinks": 104,
      "TicketPriorityId": 230,
      "SupportLanguageId": 301,
      "SupportAssociateId": 114,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "sed",
  "Xstop": false,
  "ActiveInterests": 760,
  "GroupId": 501,
  "ActiveStatusMonitorId": 856,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 199,
  "DbiAgentId": 926,
  "DbiLastSyncronized": "2022-11-25T15:29:21.0767851+01:00",
  "DbiKey": "voluptates",
  "DbiLastModified": "2018-10-28T15:29:21.0767851+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 317,
  "ActiveErpLinks": 4,
  "BounceEmails": [
    "marco_connelly@wisozk.name",
    "lee@brownturcotte.biz"
  ],
  "Domains": [
    "quia",
    "quae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Jamel Rafael Turner Jr.",
    "SuperOffice:2": "Kenneth Ward"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "fugit"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "nesciunt"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 25,
  "Name": "Lemke, Bayer and Gibson",
  "Department": "",
  "OrgNr": "1035434",
  "Number1": "1622222",
  "Number2": "1425864",
  "UpdatedDate": "2003-04-22T15:29:21.0872858+02:00",
  "CreatedDate": "2009-02-18T15:29:21.0872858+01:00",
  "Emails": [
    {
      "Value": "deleniti",
      "StrippedValue": "libero",
      "Description": "Organic heuristic architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "libero",
      "Description": "Organic heuristic architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 239,
      "Name": "Deckow, Bogan and Harvey",
      "ToolTip": "Dolores autem.",
      "Deleted": false,
      "Rank": 970,
      "Type": "in",
      "ColorBlock": 117,
      "IconHint": "molestiae",
      "Selected": false,
      "LastChanged": "2003-10-04T15:29:21.087785+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "architecto",
      "StyleHint": "tempora",
      "Hidden": false,
      "FullName": "Florine Beatty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 402
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ab",
      "StrippedValue": "omnis",
      "Description": "Intuitive maximized workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 318
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "omnis",
      "Description": "Intuitive maximized workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 318
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aspernatur",
      "StrippedValue": "inventore",
      "Description": "Diverse bifurcated neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 849
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "inventore",
      "Description": "Diverse bifurcated neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 849
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "aspernatur",
      "Description": "Up-sized even-keeled complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 705
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "aspernatur",
      "Description": "Up-sized even-keeled complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 705
        }
      }
    }
  ],
  "Description": "Grass-roots cohesive encryption",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sunt",
      "PersonId": 525,
      "Mrmrs": "qui",
      "Firstname": "Natasha",
      "Lastname": "Hessel",
      "MiddleName": "Thiel Inc and Sons",
      "Title": "esse",
      "Description": "Business-focused composite moratorium",
      "Email": "lesly@hyatt.name",
      "FullName": "Taurean Zboncak",
      "DirectPhone": "(774)439-5005 x166",
      "FormalName": "Rogahn Group",
      "CountryId": 143,
      "ContactId": 553,
      "ContactName": "Jast Group",
      "Retired": 527,
      "Rank": 849,
      "ActiveInterests": 348,
      "ContactDepartment": "",
      "ContactCountryId": 965,
      "ContactOrgNr": "1260278",
      "FaxPhone": "318.545.3817 x64323",
      "MobilePhone": "014.168.3657 x50520",
      "ContactPhone": "697.965.1529 x0734",
      "AssociateName": "Durgan-Gusikowski",
      "AssociateId": 987,
      "UsePersonAddress": false,
      "ContactFax": "veniam",
      "Kanafname": "pariatur",
      "Kanalname": "reiciendis",
      "Post1": "deleniti",
      "Post2": "fuga",
      "Post3": "aut",
      "EmailName": "ezra_rempel@kris.name",
      "ContactFullName": "Freida Marquardt",
      "ActiveErpLinks": 311,
      "TicketPriorityId": 936,
      "SupportLanguageId": 658,
      "SupportAssociateId": 416,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 153
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "vel",
  "Xstop": false,
  "ActiveInterests": 774,
  "GroupId": 817,
  "ActiveStatusMonitorId": 504,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 465,
  "DbiAgentId": 594,
  "DbiLastSyncronized": "2003-01-02T15:29:21.0917848+01:00",
  "DbiKey": "saepe",
  "DbiLastModified": "2000-04-19T15:29:21.0917848+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 241,
  "ActiveErpLinks": 638,
  "BounceEmails": [
    "edyth_schuppe@schneider.ca",
    "carmella@oberbrunner.ca"
  ],
  "Domains": [
    "sapiente",
    "recusandae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Billie Gibson",
    "SuperOffice:2": "Fausto Gaylord"
  },
  "ExtraFields": {
    "ExtraFields1": "dignissimos",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "cum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 220
    }
  }
}
```