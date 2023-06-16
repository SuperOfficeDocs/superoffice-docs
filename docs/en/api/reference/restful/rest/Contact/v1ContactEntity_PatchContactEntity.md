---
title: PATCH Contact/{id}
uid: v1ContactEntity_PatchContactEntity
generated: true
---

# PATCH Contact/{id}

```http
PATCH /api/v1/Contact/{id}
```

Update a ContactEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.


See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IContactAgent} service SaveContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Contact/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | String | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | String | The property names to modify.  "/users/0/email", "/users/-", |
| value | Object | New/Replaced value - string or object. |

## Response:

ContactEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity  updated. |
| 404 | ContactEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |

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
PATCH /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "earum",
    "value": {}
  },
  {
    "op": "add",
    "path": "earum",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 878,
  "Name": "Kuhlman-Jones",
  "Department": "",
  "OrgNr": "846684",
  "Number1": "833276",
  "Number2": "456806",
  "UpdatedDate": "2013-06-22T16:00:47.7741025+02:00",
  "CreatedDate": "2012-07-06T16:00:47.7741025+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "quo",
      "Description": "Open-architected dedicated analyzer",
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
      "Value": "qui",
      "StrippedValue": "quo",
      "Description": "Open-architected dedicated analyzer",
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
  "Interests": [
    {
      "Id": 245,
      "Name": "Hayes, Robel and Turcotte",
      "ToolTip": "Sed in quod.",
      "Deleted": true,
      "Rank": 37,
      "Type": "nihil",
      "ColorBlock": 425,
      "IconHint": "velit",
      "Selected": false,
      "LastChanged": "1999-09-17T16:00:47.7741025+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quos",
      "StyleHint": "laudantium",
      "Hidden": false,
      "FullName": "Jesus Lehner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "veniam",
      "Description": "Phased high-level open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "veniam",
      "Description": "Phased high-level open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "tempora",
      "StrippedValue": "atque",
      "Description": "Triple-buffered needs-based architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 28
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "atque",
      "Description": "Triple-buffered needs-based architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 28
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "rerum",
      "Description": "Public-key zero defect pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "rerum",
      "Description": "Public-key zero defect pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    }
  ],
  "Description": "Quality-focused client-driven synergy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 595,
      "Mrmrs": "blanditiis",
      "Firstname": "Roma",
      "Lastname": "Gleason",
      "MiddleName": "Farrell-Konopelski",
      "Title": "earum",
      "Description": "Diverse logistical internet solution",
      "Email": "terrill_koelpin@barrows.biz",
      "FullName": "Quinn Nitzsche",
      "DirectPhone": "234.551.7105 x068",
      "FormalName": "Stark-Stroman",
      "CountryId": 581,
      "ContactId": 350,
      "ContactName": "Toy, Block and Miller",
      "Retired": 689,
      "Rank": 700,
      "ActiveInterests": 865,
      "ContactDepartment": "",
      "ContactCountryId": 779,
      "ContactOrgNr": "606664",
      "FaxPhone": "286.217.1534 x126",
      "MobilePhone": "696-164-8881",
      "ContactPhone": "902-744-4152",
      "AssociateName": "Huel Group",
      "AssociateId": 274,
      "UsePersonAddress": true,
      "ContactFax": "corporis",
      "Kanafname": "aut",
      "Kanalname": "iure",
      "Post1": "aliquam",
      "Post2": "veritatis",
      "Post3": "aut",
      "EmailName": "chadd@ritchieconn.biz",
      "ContactFullName": "Finn Pagac",
      "ActiveErpLinks": 2,
      "TicketPriorityId": 381,
      "SupportLanguageId": 629,
      "SupportAssociateId": 857,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 272
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "autem",
  "Xstop": false,
  "ActiveInterests": 974,
  "GroupId": 630,
  "ActiveStatusMonitorId": 581,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 154,
  "DbiAgentId": 499,
  "DbiLastSyncronized": "2001-03-22T16:00:47.7897206+01:00",
  "DbiKey": "non",
  "DbiLastModified": "2020-05-08T16:00:47.7897206+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 511,
  "ActiveErpLinks": 55,
  "BounceEmails": [
    "okey@mohr.uk",
    "armand@johnsherman.us"
  ],
  "Domains": [
    "eveniet",
    "nemo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "613281581",
    "SuperOffice:2": "Mrs. Amari Enoch Gorczany"
  },
  "ExtraFields": {
    "ExtraFields1": "excepturi",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "occaecati"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 69
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```