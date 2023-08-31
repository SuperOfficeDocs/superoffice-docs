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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 600,
  "Name": "Pagac Group",
  "Department": "",
  "OrgNr": "526932",
  "Number1": "164234",
  "Number2": "982412",
  "UpdatedDate": "2008-08-24T03:31:32.4258286+02:00",
  "CreatedDate": "2002-07-14T03:31:32.4258286+02:00",
  "Emails": [
    {
      "Value": "animi",
      "StrippedValue": "totam",
      "Description": "Expanded 24/7 knowledge user"
    },
    {
      "Value": "animi",
      "StrippedValue": "totam",
      "Description": "Expanded 24/7 knowledge user"
    }
  ],
  "Interests": [
    {
      "Id": 488,
      "Name": "Hodkiewicz-O'Kon",
      "ToolTip": "Sit qui minima sed minus vel praesentium.",
      "Deleted": true,
      "Rank": 872,
      "Type": "similique",
      "ColorBlock": 251,
      "IconHint": "sint",
      "Selected": false,
      "LastChanged": "2015-02-02T03:31:32.4258286+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fuga",
      "StyleHint": "occaecati",
      "Hidden": false,
      "FullName": "Kieran Turner"
    }
  ],
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "alias",
      "Description": "Customizable real-time matrices"
    },
    {
      "Value": "nihil",
      "StrippedValue": "alias",
      "Description": "Customizable real-time matrices"
    }
  ],
  "Phones": [
    {
      "Value": "laborum",
      "StrippedValue": "sit",
      "Description": "Persistent 3rd generation budgetary management"
    },
    {
      "Value": "laborum",
      "StrippedValue": "sit",
      "Description": "Persistent 3rd generation budgetary management"
    }
  ],
  "Faxes": [
    {
      "Value": "ea",
      "StrippedValue": "commodi",
      "Description": "Optimized systematic website"
    },
    {
      "Value": "ea",
      "StrippedValue": "commodi",
      "Description": "Optimized systematic website"
    }
  ],
  "Description": "Down-sized systemic parallelism",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "cum",
      "PersonId": 179,
      "Mrmrs": "at",
      "Firstname": "Annamarie",
      "Lastname": "Roberts",
      "MiddleName": "Lakin-Kreiger",
      "Title": "deleniti",
      "Description": "Business-focused clear-thinking flexibility",
      "Email": "rosario@gleason.ca",
      "FullName": "Ralph Quitzon MD",
      "DirectPhone": "998-581-7388 x90026",
      "FormalName": "Satterfield LLC",
      "CountryId": 57,
      "ContactId": 730,
      "ContactName": "Miller-Metz",
      "Retired": 406,
      "Rank": 941,
      "ActiveInterests": 630,
      "ContactDepartment": "",
      "ContactCountryId": 204,
      "ContactOrgNr": "1431597",
      "FaxPhone": "607-513-6440 x02971",
      "MobilePhone": "1-407-600-2845",
      "ContactPhone": "785-578-3594",
      "AssociateName": "Greenholt-Hilll",
      "AssociateId": 30,
      "UsePersonAddress": false,
      "ContactFax": "asperiores",
      "Kanafname": "nobis",
      "Kanalname": "et",
      "Post1": "quia",
      "Post2": "rerum",
      "Post3": "magnam",
      "EmailName": "noel@kulas.us",
      "ContactFullName": "Laurie Dare DDS",
      "ActiveErpLinks": 486,
      "TicketPriorityId": 878,
      "SupportLanguageId": 723,
      "SupportAssociateId": 6,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "ut",
  "Xstop": true,
  "ActiveInterests": 13,
  "GroupId": 364,
  "ActiveStatusMonitorId": 333,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 162,
  "DbiAgentId": 349,
  "DbiLastSyncronized": "2023-05-15T03:31:32.4414471+02:00",
  "DbiKey": "voluptatem",
  "DbiLastModified": "1997-03-02T03:31:32.4414471+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 286,
  "ActiveErpLinks": 357,
  "BounceEmails": [
    "toy.moore@boyleoberbrunner.biz",
    "brook@stromanmraz.biz"
  ],
  "Domains": [
    "soluta",
    "rem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Amely Turner",
    "SuperOffice:2": "2077874539"
  },
  "ExtraFields": {
    "ExtraFields1": "consectetur",
    "ExtraFields2": "maxime"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 652,
  "Name": "Bailey, Kling and Kuvalis",
  "Department": "",
  "OrgNr": "1239514",
  "Number1": "847916",
  "Number2": "1121728",
  "UpdatedDate": "2000-01-09T03:31:32.4414471+01:00",
  "CreatedDate": "1997-06-17T03:31:32.4414471+02:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "qui",
      "Description": "Multi-layered bifurcated encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 891
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "qui",
      "Description": "Multi-layered bifurcated encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 891
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 720,
      "Name": "Dare-Homenick",
      "ToolTip": "Harum deserunt ducimus ea est architecto.",
      "Deleted": false,
      "Rank": 744,
      "Type": "et",
      "ColorBlock": 235,
      "IconHint": "in",
      "Selected": true,
      "LastChanged": "2016-06-26T03:31:32.4414471+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laboriosam",
      "StyleHint": "ipsa",
      "Hidden": false,
      "FullName": "Rodger Kuhlman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "fugit",
      "StrippedValue": "repudiandae",
      "Description": "Realigned mobile challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 31
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "repudiandae",
      "Description": "Realigned mobile challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 31
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "enim",
      "Description": "Streamlined grid-enabled encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 131
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "enim",
      "Description": "Streamlined grid-enabled encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 131
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tenetur",
      "StrippedValue": "commodi",
      "Description": "Balanced uniform challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 477
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "commodi",
      "Description": "Balanced uniform challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 477
        }
      }
    }
  ],
  "Description": "Exclusive client-driven orchestration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "impedit",
      "PersonId": 479,
      "Mrmrs": "dolores",
      "Firstname": "Rhiannon",
      "Lastname": "McDermott",
      "MiddleName": "Marquardt-Erdman",
      "Title": "iste",
      "Description": "Profound intangible orchestration",
      "Email": "demetrius@lueilwitz.info",
      "FullName": "Mr. Cordia Giovanna Orn",
      "DirectPhone": "(011)297-4651 x26539",
      "FormalName": "Parisian Inc and Sons",
      "CountryId": 201,
      "ContactId": 190,
      "ContactName": "Roberts, Ebert and Crist",
      "Retired": 525,
      "Rank": 541,
      "ActiveInterests": 252,
      "ContactDepartment": "",
      "ContactCountryId": 502,
      "ContactOrgNr": "412349",
      "FaxPhone": "755-201-5142 x4914",
      "MobilePhone": "1-196-160-3689",
      "ContactPhone": "1-719-870-6608 x70295",
      "AssociateName": "Windler Inc and Sons",
      "AssociateId": 672,
      "UsePersonAddress": true,
      "ContactFax": "voluptatem",
      "Kanafname": "magnam",
      "Kanalname": "eos",
      "Post1": "aut",
      "Post2": "aliquam",
      "Post3": "aut",
      "EmailName": "mauricio.dietrich@jacobs.us",
      "ContactFullName": "Verna Carter",
      "ActiveErpLinks": 387,
      "TicketPriorityId": 562,
      "SupportLanguageId": 213,
      "SupportAssociateId": 737,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "facere",
  "Xstop": true,
  "ActiveInterests": 801,
  "GroupId": 492,
  "ActiveStatusMonitorId": 237,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 30,
  "DbiAgentId": 867,
  "DbiLastSyncronized": "2001-08-04T03:31:32.4414471+02:00",
  "DbiKey": "odit",
  "DbiLastModified": "2016-09-13T03:31:32.4414471+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 187,
  "ActiveErpLinks": 995,
  "BounceEmails": [
    "simeon@mills.com",
    "virginie@schaefer.us"
  ],
  "Domains": [
    "maiores",
    "asperiores"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "758789048",
    "SuperOffice:2": "Anjali Jewess"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "temporibus",
    "CustomFields2": "molestias"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 921
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```