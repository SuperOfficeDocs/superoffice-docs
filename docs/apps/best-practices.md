---
uid: app_best_practices
title: Best practices
description: Best practices for SuperOffice CRM Online apps
author: Margrethe Romnes, Anthony Yates
keywords: apps, best practices
so.topic: howto
so.envir: cloud
so.client: online
---

# Best practices for SuperOffice CRM Online apps

Building integrations in the cloud requires a different mindset than onsite integrations. This guide presents concepts to consider when building online applications and provides suggestions for how to best work in this **stateless environment**.

First and foremost, every application must have a solid testing foundation where every measurable metric is measured. This requirement is not limited to just your integration with SuperOffice but also frequently used 3rd-party applications. **How will your application affect the performance of a tenant or one of the other applications used by that tenant?** These are the type of questions you must ask yourself and have answers to when or if a tenant starts to complain about performance.

There is a wide variety of things to consider, from authentication and basic connectivity issues to API usage, complex query analysis, and notifications.

The following content outlines these concerns and presents guidelines for you to think about while building or updating your applications.

## Credential management

Access to our APIs requires a valid credential and unique application secret.

Valid credentials are:

* An [access token][22]
* A [ticket][23]

To obtain either one of these credentials requires authentication. SuperOffice supports two types of authentication: front-channel and back-channel. Both exist outside any tenant API space and availability is independent of the tenant.

**Front-channel** authentication is a user-interactive experience facilitated by OAuth 2.0 or **OpenID Connect** (OIDC), and is documented in our [interactive authentication][8] section. In short, the result of an OIDC flow includes an access token, an ID token, and a refresh token. An access token is good for 20 minutes, and a new one is easily obtained using the refresh token. As a **best practice**, several frameworks including ASP.NET, continue to use access tokens until an HTTP 403 error occurs, at which time it uses the refresh token to obtain a new access token and then tries the request again. We have [one example][18] (ASP.NET Core 3.1) that demonstrates another routine using [middleware][19] that checks the expiration of the token before each request and updates it if necessary. We do not claim this to be *the way* to do it but share this as one option among several possible solutions.

**Back-channel** authentication is a non-interactive, server-to-server, experience facilitated by the [System User flow][9]. This flow returns a JWT token that contains several claims **including a ticket**. The ticket claim is *the* credential, **not** the JWT itself, and is valid for up to 6 hours. Our recommended **best practice** for back-channel communications is to actively manage the system user ticket credential. Because the ticket is good for 6 hours, we recommend the application cache it and keep track of the timeout period from when it was issued. Then, only obtain a new one when the ticket has expired or is about to expire. Do not invoke the system user flow before each and every call to a tenant's API.

You must for security reasons [Validate every security token][5] sent from SuperOffice CRM Online.

## Tenant availability

Online tenants can be in one of several [states][1] at any given time and therefore, it is recommended you always check the state of the tenant before sending any requests to the API. There are two options to check a tenant's current state or be notified of a tenant's state change.

* Tenant status API
* Tenant status webhook

### Tenant status API

This is a proactive means to determine the current state of a tenant. Your application precedes each API request with a call to the state endpoint to ensure the tenant is in a **Running** state. This signals the tenant is available for handling API requests. The following example demonstrates how the request by an application should work.

**Tenant status API request example:**

```http
https://online.superoffice.com/api/state/Cust12345
```

**Tenant status API Response example:**

```json
{
    "ContextIdentifier": "Cust12345",
    "Endpoint": "https://online.superoffice.com/Cust12345",
    "State": "Running",
    "IsRunning": true,
    "ValidUntil": "2020-10-05T09:52:01.9342965Z",
    "Api": "https://online.superoffice.com/Cust12345/api"
}
```

### Tenant status webhook

This option is a more reactive flow that sends notifications each and every time a tenant state changes. SuperOffice sends out a [notifications][10] payload and gives you a chance to manage tenant customer states better.

The five possible state changes are:

* Upgrade
* BackupRestored
* Suspend
* Resume
* Delete

Not only does that provide advanced notice when tenants are upgraded to new versions of SuperOffice, but it can signal whenever a customer has canceled a subscription (Delete).

> [!NOTE]
> The only way to subscribe to this webhook is by supplying a **State Change URL** when you [register the application][12], or submitting an [application change request][4]. Provide the URL where the state change payload is sent in the **Other changes** textbox as *Stage Change URL: https://your_domain.com/your_endpoint_name*.

## API Usage

Applications must be resilient! Every integration must anticipate downtime and incorporate strategies that facilitate redundancy when failures occur or services are unavailable. Your integrations must be able to recover from occasions when errors occur in the middle of important transactions. You must protect customers from losing data if and when the tenant should become unavailable, or posted data contains missing information.

Expect problems when interacting with web services and handle unexpected responses at every junction.

### Mixing APIs

We recommend that each application either use REST or SOAP. **Don't mix multiple APIs** in the same application. Read more about which API is right for you in the [What API to use][13] section.

### Caching

Cache all infrequently updated data. The following list contains information that should be asked for **very infrequently**:

* All Lists (business, category, sale type, project type, web panels, and so on)
* All preferences
* Address formats
* Archive and MDO provider names
* Associates
* Countries
* Language information
* User-defined fields
* Data and functional rights
* Module licenses
* User groups

Other common types of requested data that should be cached:

| Agent         | Method          |
|---------------|-----------------|
| AssociateAgent | GetAssociateList |
| SoPrincipalAgent | AuthenticateUsernamePassword<br>GetSystemInfo |
| ContactAgent | GetMyContact |
| MDOAgent | GetList |
| ArchiveAgent | GetProviderNames |
| UserDefinedFieldInfoAgent |GetUserDefinedFieldList<br>FigureOutListIdFromListTableIDAndUDListDefinitionId |

Another big problem integrations make is not taking advantage of caching for authentication tokens. See the credentials management section above.

Think about the APIs you are using and ask yourself "How often does this data change? Is it something I should cache? "Can I subscribe to a webhook and be notified when something changes?" How often does your company change? Then why call GetMyContact 50,000 times a day? Don't do it!

### Entity creation

The entity lifecycle encapsulates the creation, modification, and deletion of all business objects. Each entity contains dependencies derived from preferences, and therefore it is important API consumers create entities using APIs that now about and leverage the preference system.

Using `Default` will calculate some of the needed values for you, similar to clicking **New** inside the SuperOffice client. ​

For the REST APIs, that means sending a GET request to the appropriate entity to create a default endpoint. The following example demonstrates what you should do.

### [RESTful REST API](#tab/create-rest)

Proper creation invocation:

```http
/api/v1/{Entity}/default
```

The following example demonstrates how you should use the `default` endpoint. This ensures the returned entity contains all preference-derived data and default data structures.

```csharp
PersonEntity person = GetRequest("/api/v1/Person/default​");
person.FirstName = "Jack";
person.LastName = "Black";
person.Contact = new Contact()
{
  ContactId = 1234; // where 1234 is a real contact ID
};

PostRequest(person, "/api/v1/Agent/Person");
...
```

### [AGENT REST API](#tab/create-soap)

Proper creation invocation:

```http
/api/v1/Agent/{Entity}/CreateDefault{Entity}
```

The following example demonstrates how to use the `CreateDefault` endpoint. This ensures the returned entity contains all preference-derived data and default data structures.

```csharp
// DO use the CreateDefault endpoint to properly create a person entity.

PersonEntity person = PostRequest("/api/v1/Agent/Person/CreateDefaultPersonEntity​");

person.FirstName = "Jack";
person.LastName = "Black";
person.Contact = new Contact()
{
  ContactId = 1234; // where 1234 is a real contact ID
};

PostRequest(person, "/api/v1/Agent/Person/SavePersonEntity​");
...
```

***

### Provisioning

Adding lists, list items, and web panels are just some of the common [provisioning tasks][24] when your application elements are provisioned in a tenant. Here are a few things to remember when adding elements into SuperOffice:

* **Set the visibility** of new web panels. [Set the appropriate user group and heading options][3].
* Use the **description fields** so administrators can easily distinguish which items belong to which application.
* Check out the full list of guidelines on the [certification list][14].

### Security

The integrity of SuperOffice must be paramount at all times. While we could list the most obvious things here, like **deny network traffic over un-secure connections** and **establish secure coding practices** appropriate to the programming language and development environment being used, we recommend you read our [security requirements][15] to learn more.

### Searching

Web requests are stateless, and therefore every request must stand on its own feet and should not be dependent on the in-memory state left behind by an earlier request. Therefore, whenever you request a page from an archive provider, NetServer has to start from the bottom. An additional constraint comes from the [Sentry system][25], whose rules are too complex to be expressed in something the database can filter for us. We, therefore, have to fetch, evaluate, possibly discard, and go on fetching rows until we arrive at the start of the page you requested. The end result is that the repeated paging is required to fetch data scales like [O(N^2)][20].

"It’s a feature" – you can call for any page at any time. But like much in the cloud, it leads to implementations that can scale out wonderfully, but still perform badly in some situations.

A few things can improve the situation. But the first and most important question is this: **Why do you have to repeatedly read so much?** When working with a local database, reading a few hundred thousand rows is trivial and a completely valid way to structure your logic.

A cloud service with lots of business logic is not the same as a nearby database table. It will never have the same performance, not even close. You must think differently about it and reflect that in your design. When working with a cloud service that’s logically and physically far away, and that by its nature has a different usage pattern, it’s no longer a good solution.

> [!NOTE]
> Adapting to the cloud doesn’t mean switching from an IDataReader to an ArchiveProvider and keeping everything else the same. While the latter mimics the former, they are fundamentally different in their performance behavior.

The difference cannot be hidden or optimized away, and that means your logic has to change in a significant way.

A larger page size reduces the number of calls, so it pushes the curve down about. Note that you’re still in O(N^2), it’s just that the y-scale has been stretched a bit so that the number of rows you can have before things become unacceptable is higher.

Internally, NetServer takes the query generated by the provider and splits it into two passes. In pass 1 we eliminate as many joins and fields as possible, to narrow down the search to retrieve only the primary keys. Once we get our pageful of IDs, in Pass 2 we fetch from all tables and fields, but this time with a simplified restriction consisting only of the primary keys, thereby fetching only those specific rows.

This usually works well. NetServer caches the Pass 1 query in the background, so that if someone later asks for another page, and everything except the page number is identical, then it goes straight to Pass 2. This cache dies 60 seconds after the last call.

However, there are cases where such splitting doesn’t work. The caching works only if you give it time to run – and then there are lock concerns. If it works then you go from O(N^2) to O(N), but it can’t be guaranteed.

#### Count

Don’t ask for counts. Fetching an accurate count means we have to process every row and the database has to process a SELECT COUNT query. Don’t do it unless absolutely necessary.

Looking at the following images, notice how using count(id) causes tremendous load on the server and performs badly.

![count][img1]

Instead, consider using the sequence table to get an estimate of how many records a particular table has, and use that value to iterate over all desired records.

The Sequence table has the next primary key id for all tables. Asking for `next_id` will give the next primary key for any given table. The following example queries the sequence table to obtain the next primary key for the contact table:

```http
.../api/v1/archive/dynamic?$select=sequence.next_id&$filter=sequence.tablename = 'contact'
```

And here again for the person table.

```http
.../api/v1/archive/dynamic?$select=sequence.next_id&$filter=sequence.tablename = 'person'
```

Then, when you have the estimated number of records, use the Dynamic archive provider again to perform even a more granular search for just the contact ID and orgNr, instead of using the default provider, `SimpleContact`, when querying the `api/v1/contact` endpoint.

Adjust the query to pick up `contact_id`, `OrgNr`, and order it by the primary key field. That way you will be able to ask for a pagesize of 1000, the ordering on the table's primary key is for free and NetServer will not have to perform a lot of expensive data fetching.

#### Use filters

Archive searches accept a wide variety of [search operators][21]. Difference data types can have different operators. Each OData search page contains a table of data types and their associated operators.

#### Optimization

Optimized searches means putting in as many restrictions as possible that will translate to good SQL, thereby off-loading the heavy lifting to the database server. Therefore, consider the following recommendations:

1. Always use an __$orderby__={primarykey}
2. Strongly suggest use a __$filter__={criteria} (especially when using __\$top__)
3. If using __\$top__, use __\$skip__ for further optimization. (do __NOT__ ask for all records every request)

### Polling

While there may be scenarios where polling the `traveltransactionlog` (TTL) table is necessary, it is rarely a good idea and should be considered a last resort.

There are cases where polling the TTL tables are useless. For example, MergeMoveLog records are not persisted in the `traveltransactionlog​`. Neither are SoftDeletes – where the API just sets the deletedDate timestamp on the entity. After 14 days, when they are HardDeleted, this operation is also not written to the `traveltransactionlog​`.

Here is an example search query to fetch which companies have been merged into another company, and actually deleted. The source record is the `contact_id​` (company identity).

```http
../api/v1/archive/dynamic?$select=mergemovelog.operation, mergemovelog.tableNumber, mergemovelog.sourceRecord&$filter=movemergelog.registered afterTime <LastSyncTime>​
```

We recommend that you, instead of polling to the TTL table, use webhooks.

### ​Webhooks

[Webhooks][16] are notifications sent to your application whenever events happen in SuperOffice - regardless of the SuperOffice product used. They provide you an opportunity to react to many different types of changes, such as new companies created, sales marked as sold, and more.

The webhook workflow begins with applications subscribing to interesting events. The way an application does this is by adding one or more webhook definitions in SuperOffice.

When a webhook payload is sent, which is a JSON formatted string, it includes information that describes what has changed. However, our security policy is such that the only CRM data sent out is the type of entity that raised the event and the primary ID of said entity. Webhook receivers must authenticate to fetch data about the entity via an API to ensure that they are allowed to read the data.

### Bulk Operations

Bulk insert, update and delete operations are supported in all SuperOffice APIs. These capabilities exist as:

* Bulk-updates
* Mass Operations

Bulk-update is great for targeted changes; when data already exists in SuperOffice and a need arises to change one or more fields, on one or more entities, based on a specified criterion. A hypothetical bulk-update example is an organization that changes a data policy where a person's title must conform to a certain format. For example, all contacts with the title "sales man" or "sales woman" must be redefined as "Sales Person". A Bulk-Update operation is useful to perform such changes. Users must be assigned the bulk-update functional right.

Mass operations are different in that they involve inserting, updating, or deleting large datasets. All actions work towards one particular table at a time. This is an extremely fast and powerful API that is only accessible to system user accounts.

> [!NOTE]
> The Mass Operations API requires a system user to function.

Read more about `Bulk-Updates` and `Mass Operations` in the [Bulk Operations API documentation][17].

## Logging

Both you and SuperOffice are required to log network communications. Your application must keep logs for a minimum of 3 months. You may be required to provide your log files for security analysis at any time.

## User interaction and design

### Be consistent

* Either use Microsoft Windows standard looks, or copy the SuperOffice CRM looks, but don’t mix the two.

* Avoid having different modes on the same display.

### Be action-oriented

* Use **buttons** to indicate actions.

* In dialogs, place buttons along the bottom ordered like this: **Task** \- **OK** \- **Cancel**.

* Deactivate buttons that have no effect.
  * Example: the **Save** button cannot be clicked until the user has changed something.

* Provide explanatory **tooltips** for deactivated fields and buttons.

* Prefer selecting from a drop-down list to typing in a text field.
  * Provide history or autocomplete if possible.

### Use progressive disclosure

* Use a tooltip to show additional information on a list item.

* Hide unnecessary details behind a **MORE** button.

* Hide actions that are used infrequently behind a **TASK** menu button.

* Avoid nesting tabs – multiple tab layers are confusing.

Read about [effective visual design][6].

## Stay informed and share information

* Sign up for email notifications in [the forums][7] to learn about changes that might affect your application.

* **Provide feedback** to the user if an operation takes time to complete.
  * Example: In SuperOffice CRM Online, a cogwheel indicates that a background task is running

* Offer **easy access** to a knowledge base or to support pages from your application.

* Provide SuperOffice with URLs to your application **documentation**. Links to the documentation will appear in the App Store.

<!-- Referenced links -->
[1]: tenant-status/status-page.md
[2]: tenant-status/check-status.md
[3]: https://github.com/SuperOffice/SuperOffice.DevNet.Online/blob/master/Source/SuperOffice.DevNet.Online.Provisioning/WebPanelHelper.cs#L335
[4]: https://community.superoffice.com/change-application
[5]: ../../../data-access/docs/authentication/online/validate-security-tokens.md
[6]: ../../../user-interface/docs/design/index.md
[7]: https://community.superoffice.com/en/technical/forums/general-forums/announcements/
[8]: ../../../data-access/docs/authentication/online/sign-in-user/index.md
[9]: ../../../data-access/docs/authentication/online/auth-application/index.md
[10]: tenant-status/notifications.md
[11]: tenant-status/get-notifications.md
[12]: https://community.superoffice.com/application-registration/
[13]: getting-started/what-api-to-use.md
[14]: certification/checklist.md
[15]: requirements/security.md
[16]: ../../../data-access/docs/netserver/webhooks/index.md
[17]: ../../../data-access/docs/netserver/bulk-operations/index.md
[18]: https://github.com/SuperOffice/devnet-oidc-razor-pages-webapi
[19]: https://github.com/SuperOffice/devnet-oidc-razor-pages-webapi/blob/master/source/SuperOffice.DevNet.RazorPages/Middleware/RefreshTokenMiddleware.cs
[20]: https://en.wikipedia.org/wiki/Big_O_notation
[21]: ../../../data-access/docs/netserver/search/odata/index.md
[22]: ../../../data-access/docs/authentication/online/api.md#access-tokens
[23]: ../../../data-access/docs/authentication/online/api.md#soticket-authentication
[24]: provisioning/index.md
[25]: ../../../data-access/docs/security/sentry/index.md

<!-- Referenced images -->
[img1]: media/count.png
