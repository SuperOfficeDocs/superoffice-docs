---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 762,
  "Name": "Streich, Reilly and Johnson",
  "Department": "enable revolutionary e-business",
  "OrgNr": "1283605",
  "Number1": "1109916",
  "Number2": "1180694",
  "UpdatedDate": "2019-08-25T14:19:03.0105285+02:00",
  "CreatedDate": "2022-02-28T14:19:03.0105285+01:00",
  "Emails": [
    {
      "Value": "illo",
      "StrippedValue": "optio",
      "Description": "Persistent eco-centric middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 472
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "optio",
      "Description": "Persistent eco-centric middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 472
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 5,
      "Name": "Medhurst LLC",
      "ToolTip": "Molestias veniam dolore.",
      "Deleted": false,
      "Rank": 315,
      "Type": "libero",
      "ColorBlock": 563,
      "IconHint": "maiores",
      "Selected": false,
      "LastChanged": "2003-05-29T14:19:03.0105285+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ducimus",
      "StyleHint": "tempora",
      "Hidden": true,
      "FullName": "Erich Kilback",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 871
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolore",
      "StrippedValue": "quam",
      "Description": "Upgradable next generation synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 502
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "quam",
      "Description": "Upgradable next generation synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 502
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "commodi",
      "Description": "Public-key bandwidth-monitored pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 992
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "commodi",
      "Description": "Public-key bandwidth-monitored pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 992
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptates",
      "StrippedValue": "perspiciatis",
      "Description": "Reduced holistic collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 23
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "perspiciatis",
      "Description": "Reduced holistic collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 23
        }
      }
    }
  ],
  "Description": "Organic local encoding",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "culpa",
      "PersonId": 745,
      "Mrmrs": "omnis",
      "Firstname": "Dillan",
      "Lastname": "Simonis",
      "MiddleName": "Mitchell, Rath and Donnelly",
      "Title": "culpa",
      "Description": "Front-line impactful utilisation",
      "Email": "stanton.hahn@powlowski.ca",
      "FullName": "Haley Stanton",
      "DirectPhone": "(899)638-7407 x13068",
      "FormalName": "Borer-Olson",
      "CountryId": 627,
      "ContactId": 953,
      "ContactName": "Flatley, Smith and Gibson",
      "Retired": 433,
      "Rank": 609,
      "ActiveInterests": 863,
      "ContactDepartment": "",
      "ContactCountryId": 896,
      "ContactOrgNr": "1364790",
      "FaxPhone": "(375)440-2226",
      "MobilePhone": "(451)092-0273",
      "ContactPhone": "1-052-495-8344 x06689",
      "AssociateName": "Larkin-Reynolds",
      "AssociateId": 349,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "quos",
      "Kanalname": "veniam",
      "Post1": "aut",
      "Post2": "quibusdam",
      "Post3": "rerum",
      "EmailName": "abbie.marvin@cassin.info",
      "ContactFullName": "Miss Patricia McDermott",
      "ActiveErpLinks": 429,
      "TicketPriorityId": 238,
      "SupportLanguageId": 303,
      "SupportAssociateId": 518,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 295
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ut",
  "Xstop": false,
  "ActiveInterests": 94,
  "GroupId": 594,
  "ActiveStatusMonitorId": 695,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 783,
  "DbiAgentId": 148,
  "DbiLastSyncronized": "2007-05-23T14:19:03.0105285+02:00",
  "DbiKey": "dolorem",
  "DbiLastModified": "2011-02-14T14:19:03.0105285+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 333,
  "ActiveErpLinks": 320,
  "BounceEmails": [
    "desmond.herzog@grady.co.uk",
    "rasheed@miller.us"
  ],
  "Domains": [
    "magni",
    "sequi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Nadia Shanahan",
    "SuperOffice:2": "Kiera Dooley"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "temporibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 354
    }
  }
}
```