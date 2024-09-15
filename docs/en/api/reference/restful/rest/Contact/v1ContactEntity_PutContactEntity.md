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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 465,
  "Name": "Wintheiser-Denesik",
  "Department": "",
  "OrgNr": "351957",
  "Number1": "828727",
  "Number2": "1234032",
  "UpdatedDate": "2016-07-06T04:02:06.3999163+02:00",
  "CreatedDate": "1999-07-19T04:02:06.3999163+02:00",
  "Emails": [
    {
      "Value": "doloremque",
      "StrippedValue": "a",
      "Description": "Realigned content-based matrix"
    },
    {
      "Value": "doloremque",
      "StrippedValue": "a",
      "Description": "Realigned content-based matrix"
    }
  ],
  "Interests": [
    {
      "Id": 190,
      "Name": "Franecki Inc and Sons",
      "ToolTip": "Consequatur architecto soluta nesciunt odit.",
      "Deleted": false,
      "Rank": 90,
      "Type": "sapiente",
      "ColorBlock": 37,
      "IconHint": "natus",
      "Selected": true,
      "LastChanged": "2004-10-19T04:02:06.3999163+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "error",
      "StyleHint": "itaque",
      "Hidden": false,
      "FullName": "Sam Bayer I"
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "laboriosam",
      "Description": "Optimized logistical model"
    },
    {
      "Value": "aut",
      "StrippedValue": "laboriosam",
      "Description": "Optimized logistical model"
    }
  ],
  "Phones": [
    {
      "Value": "repellat",
      "StrippedValue": "dolores",
      "Description": "Mandatory interactive approach"
    },
    {
      "Value": "repellat",
      "StrippedValue": "dolores",
      "Description": "Mandatory interactive approach"
    }
  ],
  "Faxes": [
    {
      "Value": "consequuntur",
      "StrippedValue": "dolorem",
      "Description": "Reduced modular groupware"
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "dolorem",
      "Description": "Reduced modular groupware"
    }
  ],
  "Description": "Total background framework",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sint",
      "PersonId": 496,
      "Mrmrs": "asperiores",
      "Firstname": "Nikolas",
      "Lastname": "Larkin",
      "MiddleName": "Reinger Group",
      "Title": "incidunt",
      "Description": "Compatible dynamic standardization",
      "Email": "nedra_wunsch@zulaufroob.us",
      "FullName": "Sierra Goyette",
      "DirectPhone": "913-993-8902 x52610",
      "FormalName": "Dooley Group",
      "CountryId": 635,
      "ContactId": 689,
      "ContactName": "Lemke LLC",
      "Retired": 689,
      "Rank": 565,
      "ActiveInterests": 255,
      "ContactDepartment": "",
      "ContactCountryId": 124,
      "ContactOrgNr": "254247",
      "FaxPhone": "(203)507-1185 x523",
      "MobilePhone": "433.964.3049",
      "ContactPhone": "716.093.2237 x7512",
      "AssociateName": "Stiedemann-Torphy",
      "AssociateId": 1001,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "magnam",
      "Kanalname": "quo",
      "Post1": "asperiores",
      "Post2": "harum",
      "Post3": "rerum",
      "EmailName": "vincenzo.schowalter@toy.uk",
      "ContactFullName": "Lizzie Reinger III",
      "ActiveErpLinks": 507,
      "TicketPriorityId": 778,
      "SupportLanguageId": 150,
      "SupportAssociateId": 180,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "cum",
  "Xstop": false,
  "ActiveInterests": 327,
  "GroupId": 89,
  "ActiveStatusMonitorId": 440,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 750,
  "DbiAgentId": 574,
  "DbiLastSyncronized": "2016-03-24T04:02:06.3999163+01:00",
  "DbiKey": "dolor",
  "DbiLastModified": "2022-04-14T04:02:06.3999163+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 995,
  "ActiveErpLinks": 448,
  "BounceEmails": [
    "brent@monahanbarrows.info",
    "rosa.hilll@herzog.info"
  ],
  "Domains": [
    "possimus",
    "alias"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1328039522",
    "SuperOffice:2": "Mr. Bertram Thompson"
  },
  "ExtraFields": {
    "ExtraFields1": "unde",
    "ExtraFields2": "vitae"
  },
  "CustomFields": {
    "CustomFields1": "error",
    "CustomFields2": "illo"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 480,
  "Name": "Reichel-Kertzmann",
  "Department": "",
  "OrgNr": "1460063",
  "Number1": "1793916",
  "Number2": "968806",
  "UpdatedDate": "2013-06-02T04:02:06.3999163+02:00",
  "CreatedDate": "2013-06-12T04:02:06.3999163+02:00",
  "Emails": [
    {
      "Value": "quos",
      "StrippedValue": "quod",
      "Description": "Configurable intangible budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 44
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "quod",
      "Description": "Configurable intangible budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 44
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 462,
      "Name": "Kiehn-Hodkiewicz",
      "ToolTip": "Tempore ut dolore facere.",
      "Deleted": false,
      "Rank": 609,
      "Type": "placeat",
      "ColorBlock": 195,
      "IconHint": "iste",
      "Selected": false,
      "LastChanged": "2000-02-09T04:02:06.4156491+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestiae",
      "StyleHint": "consequuntur",
      "Hidden": false,
      "FullName": "Adella Emard",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "a",
      "StrippedValue": "placeat",
      "Description": "Pre-emptive real-time interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "placeat",
      "Description": "Pre-emptive real-time interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sit",
      "StrippedValue": "soluta",
      "Description": "Mandatory mobile definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 670
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "soluta",
      "Description": "Mandatory mobile definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 670
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "ut",
      "Description": "Adaptive client-driven methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 200
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "ut",
      "Description": "Adaptive client-driven methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 200
        }
      }
    }
  ],
  "Description": "Reactive systematic superstructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "mollitia",
      "PersonId": 593,
      "Mrmrs": "fugiat",
      "Firstname": "Rico",
      "Lastname": "Upton",
      "MiddleName": "Jones-Baumbach",
      "Title": "eveniet",
      "Description": "Triple-buffered cohesive strategy",
      "Email": "robin.schumm@collierraynor.ca",
      "FullName": "Alexa Reinger",
      "DirectPhone": "(448)359-7972 x65122",
      "FormalName": "Hermann Group",
      "CountryId": 707,
      "ContactId": 329,
      "ContactName": "Balistreri, Hayes and Blanda",
      "Retired": 558,
      "Rank": 277,
      "ActiveInterests": 312,
      "ContactDepartment": "",
      "ContactCountryId": 21,
      "ContactOrgNr": "1322000",
      "FaxPhone": "(278)493-5920 x384",
      "MobilePhone": "244.046.8100",
      "ContactPhone": "1-148-348-6871 x2087",
      "AssociateName": "Vandervort Group",
      "AssociateId": 138,
      "UsePersonAddress": true,
      "ContactFax": "optio",
      "Kanafname": "praesentium",
      "Kanalname": "laborum",
      "Post1": "suscipit",
      "Post2": "facere",
      "Post3": "corporis",
      "EmailName": "arvel@balistreri.info",
      "ContactFullName": "Dr. Gust Esta Reinger",
      "ActiveErpLinks": 610,
      "TicketPriorityId": 260,
      "SupportLanguageId": 111,
      "SupportAssociateId": 701,
      "CategoryName": "VIP Customer",
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
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 998,
  "GroupId": 504,
  "ActiveStatusMonitorId": 383,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 164,
  "DbiAgentId": 636,
  "DbiLastSyncronized": "2023-01-03T04:02:06.4161579+01:00",
  "DbiKey": "error",
  "DbiLastModified": "2009-06-19T04:02:06.4161579+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 990,
  "ActiveErpLinks": 822,
  "BounceEmails": [
    "ceasar_muller@howell.name",
    "bryana.goodwin@hoegermonahan.co.uk"
  ],
  "Domains": [
    "aliquam",
    "impedit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Margaretta Therese Wolf",
    "SuperOffice:2": "Levi Dare"
  },
  "ExtraFields": {
    "ExtraFields1": "consequuntur",
    "ExtraFields2": "aliquam"
  },
  "CustomFields": {
    "CustomFields1": "laudantium",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 693
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```