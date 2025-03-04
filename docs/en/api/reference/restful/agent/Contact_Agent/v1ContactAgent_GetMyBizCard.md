---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 910,
  "Name": "Dickens Group",
  "Department": "",
  "OrgNr": "463715",
  "Number1": "1202350",
  "Number2": "1626285",
  "UpdatedDate": "2012-12-23T14:13:39.8442326+01:00",
  "CreatedDate": "2016-04-10T14:13:39.8442326+02:00",
  "Emails": [
    {
      "Value": "ad",
      "StrippedValue": "magni",
      "Description": "Face to face 3rd generation concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 449
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "magni",
      "Description": "Face to face 3rd generation concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 449
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 815,
      "Name": "Wehner-Olson",
      "ToolTip": "Quia expedita assumenda impedit error.",
      "Deleted": false,
      "Rank": 899,
      "Type": "aperiam",
      "ColorBlock": 752,
      "IconHint": "omnis",
      "Selected": false,
      "LastChanged": "2015-07-07T14:13:39.8442326+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "error",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Miss Cordie Addison Halvorson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "nisi",
      "Description": "Integrated holistic task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 513
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "nisi",
      "Description": "Integrated holistic task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 513
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "illum",
      "StrippedValue": "id",
      "Description": "Phased non-volatile synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "id",
      "Description": "Phased non-volatile synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sunt",
      "StrippedValue": "est",
      "Description": "Persevering mobile superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 469
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "est",
      "Description": "Persevering mobile superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 469
        }
      }
    }
  ],
  "Description": "Distributed impactful moderator",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "deserunt",
      "PersonId": 244,
      "Mrmrs": "enim",
      "Firstname": "Krystal",
      "Lastname": "Abernathy",
      "MiddleName": "Ziemann-Greenfelder",
      "Title": "nihil",
      "Description": "Upgradable holistic projection",
      "Email": "pierce@rippin.com",
      "FullName": "Grady Stamm",
      "DirectPhone": "(034)823-3911 x230",
      "FormalName": "Moen, Goyette and Kilback",
      "CountryId": 925,
      "ContactId": 990,
      "ContactName": "Breitenberg Group",
      "Retired": 470,
      "Rank": 811,
      "ActiveInterests": 720,
      "ContactDepartment": "",
      "ContactCountryId": 98,
      "ContactOrgNr": "1719079",
      "FaxPhone": "(528)526-9102 x9670",
      "MobilePhone": "752-011-0305 x375",
      "ContactPhone": "(665)720-8302 x0773",
      "AssociateName": "Jerde-Terry",
      "AssociateId": 887,
      "UsePersonAddress": false,
      "ContactFax": "quis",
      "Kanafname": "voluptatem",
      "Kanalname": "dolore",
      "Post1": "quod",
      "Post2": "iste",
      "Post3": "et",
      "EmailName": "letha.kozey@shields.uk",
      "ContactFullName": "Madaline Rempel",
      "ActiveErpLinks": 28,
      "TicketPriorityId": 688,
      "SupportLanguageId": 96,
      "SupportAssociateId": 106,
      "CategoryName": "VIP Customer",
      "PersonNumber": "507499",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 794
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "mollitia",
  "Xstop": false,
  "ActiveInterests": 371,
  "GroupId": 591,
  "ActiveStatusMonitorId": 808,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 638,
  "DbiAgentId": 53,
  "DbiLastSyncronized": "2014-08-08T14:13:39.8442326+02:00",
  "DbiKey": "aspernatur",
  "DbiLastModified": "2009-03-30T14:13:39.8442326+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 911,
  "ActiveErpLinks": 525,
  "BounceEmails": [
    "newton@cole.name",
    "ruby@bogan.us"
  ],
  "Domains": [
    "nesciunt",
    "magni"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Royce Labadie",
    "SuperOffice:2": "Crawford Fisher"
  },
  "ExtraFields": {
    "ExtraFields1": "ad",
    "ExtraFields2": "voluptates"
  },
  "CustomFields": {
    "CustomFields1": "vitae",
    "CustomFields2": "ad"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 186
    }
  }
}
```