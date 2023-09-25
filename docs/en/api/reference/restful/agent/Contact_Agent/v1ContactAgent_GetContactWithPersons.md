---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

## Request Body: request 

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 570
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 266,
  "Name": "Baumbach, Halvorson and Hand",
  "Department": "morph one-to-one paradigms",
  "OrgNr": "1292000",
  "Number1": "1204793",
  "Number2": "1200188",
  "UpdatedDate": "2022-11-15T03:24:47.4083086+01:00",
  "CreatedDate": "2017-01-18T03:24:47.4083086+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "ad",
      "Description": "Profound optimizing data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 417
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ad",
      "Description": "Profound optimizing data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 417
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 127,
      "Name": "Emard-Marvin",
      "ToolTip": "Maiores qui tenetur quia laudantium veniam.",
      "Deleted": true,
      "Rank": 612,
      "Type": "et",
      "ColorBlock": 990,
      "IconHint": "laboriosam",
      "Selected": false,
      "LastChanged": "2019-01-20T03:24:47.4083086+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "voluptas",
      "Hidden": true,
      "FullName": "Barney Hodkiewicz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 486
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "aut",
      "Description": "Function-based directional alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "aut",
      "Description": "Function-based directional alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "vel",
      "StrippedValue": "commodi",
      "Description": "Versatile composite implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 609
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "commodi",
      "Description": "Versatile composite implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 609
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolore",
      "StrippedValue": "enim",
      "Description": "Ameliorated client-driven interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 781
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "enim",
      "Description": "Ameliorated client-driven interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 781
        }
      }
    }
  ],
  "Description": "Extended hybrid paradigm",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "assumenda",
      "PersonId": 563,
      "Mrmrs": "ad",
      "Firstname": "Kaylin",
      "Lastname": "Leannon",
      "MiddleName": "Dare Group",
      "Title": "voluptate",
      "Description": "Function-based bottom-line artificial intelligence",
      "Email": "fanny.deckow@hartmann.ca",
      "FullName": "Ms. Reyes Kling",
      "DirectPhone": "297.213.8265 x5524",
      "FormalName": "Huels LLC",
      "CountryId": 855,
      "ContactId": 711,
      "ContactName": "Durgan, Beahan and Bauch",
      "Retired": 727,
      "Rank": 643,
      "ActiveInterests": 621,
      "ContactDepartment": "",
      "ContactCountryId": 346,
      "ContactOrgNr": "490424",
      "FaxPhone": "859-151-2605",
      "MobilePhone": "659.425.6945",
      "ContactPhone": "1-504-586-7087",
      "AssociateName": "Blick, Kohler and Rath",
      "AssociateId": 93,
      "UsePersonAddress": false,
      "ContactFax": "laborum",
      "Kanafname": "incidunt",
      "Kanalname": "sed",
      "Post1": "voluptatem",
      "Post2": "dolore",
      "Post3": "itaque",
      "EmailName": "adonis.vonrueden@lind.info",
      "ContactFullName": "Phoebe Altenwerth",
      "ActiveErpLinks": 16,
      "TicketPriorityId": 858,
      "SupportLanguageId": 57,
      "SupportAssociateId": 355,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 735
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatem",
  "Xstop": true,
  "ActiveInterests": 97,
  "GroupId": 173,
  "ActiveStatusMonitorId": 1000,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 799,
  "DbiAgentId": 866,
  "DbiLastSyncronized": "1997-04-19T03:24:47.4083086+02:00",
  "DbiKey": "est",
  "DbiLastModified": "2013-08-12T03:24:47.4083086+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 905,
  "ActiveErpLinks": 828,
  "BounceEmails": [
    "selena@wiegand.us",
    "khalid_ullrich@klocko.uk"
  ],
  "Domains": [
    "consequatur",
    "aliquam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1455234513",
    "SuperOffice:2": "Raphael Balistreri"
  },
  "ExtraFields": {
    "ExtraFields1": "inventore",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "dolorum",
    "CustomFields2": "aspernatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 85
    }
  }
}
```