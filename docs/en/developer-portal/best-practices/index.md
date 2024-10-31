---
uid: app-best-practices
title: Best practices
description: Best practices for SuperOffice CRM Online apps
keywords: apps, best practices, 3rd-party
author: Margrethe Romnes, Anthony Yates
date: 10.31.2024
version: 10
topic: howto
envir: cloud
client: online
---

# Best practices for SuperOffice CRM Online apps

Building integrations in the cloud requires a different mindset than onsite integrations. This guide presents concepts to consider when building online applications and provides suggestions for how to best work in this **stateless environment**.

First and foremost, every application must have a solid testing foundation where every measurable metric is measured. This requirement is not limited to just your integration with SuperOffice but also frequently used 3rd-party applications. **How will your application affect the performance of a tenant or one of the other applications used by that tenant?** These are the type of questions you must ask yourself and have answers to when or if a tenant starts to run into performance-issues.

There is a wide variety of things to consider, from authentication and basic connectivity issues to API usage, complex query analysis, and notifications.

The following content outlines these concerns and presents guidelines for you to think about while building or updating your applications.

## Credential management

Access to our APIs requires a valid credential and unique application secret.

Valid credentials are:

* An [access token][22]
* A [ticket][23]

To obtain either one of these credentials requires authentication. SuperOffice supports two types of authentication: [front-channel][2] and [back-channel][5]. Both exist outside any tenant API space and availability is independent of the tenant.

## Tenant availability

Online tenants can be in one of several [states][1] at any given time and therefore, it is recommended you always check the state of the tenant before sending any requests to the API. There are two options to check a tenant's current state or be notified of a tenant's state change, both described in the [Tenant status][8] section.

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

<!-- markdownlint-disable MD051 -->
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
<!-- markdownlint-restore -->

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

Don't ask for counts. Fetching an accurate count means we have to process every row and the database has to process a SELECT COUNT query. Don't do it unless absolutely necessary. Instead, use the [count aggregation][26].

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

Here are some thoughts for constructing optimal queries:

* Design efficient queries. Think about how the queries are translated and executed on the database server.
* Optimize and fine tune your queries. Try a variation of query techniques for a given scenario and choose the one, not that is easiest to implement for the developer, but with the best performance for online services.
* Perform efficient transactions. Target as few fields as possible, use indexed fields, and avoid large table joins. Pre-fetch lists to avoid performing lookups for each record with list IDs.
* Identify and eliminate sub-optimal queries. Instead of creating queries that contain lots of duplicate criterion field restrictions, i.e. contact_id=1 OR contact_id=2 OR contactID=3, use a more appropriate clause that will result in better performance - such as Contact_id IN (1,2,3).
* Test and monitor your data access performance. Do not wait for customer complaints. Have a data performance monitoring strategy, set conservative tolerance thresholds, and take action to refactor problems.

Optimized searches means using smart restrictions that will translate to optimal SQL. Therefore, consider the following recommendations:

1. Always use an **$orderby**={primarykey}
2. Strongly suggest use a **$filter**={criteria} (especially when using **\$top**)
3. If using **\$top**, use **\$skip** for further optimization. (do **NOT** ask for all records every request)

 By creating well-defined It's good to off-loading heavy lifting queries to the database server, .

### Polling

While there may be scenarios where polling the `traveltransactionlog` (TTL) table is necessary, it is rarely a good idea and should be considered a last resort.

There are cases where polling the TTL tables are useless. For example, MergeMoveLog records are not persisted in the `traveltransactionlog​`. Neither are SoftDeletes – where the API just sets the deletedDate timestamp on the entity. After 14 days, when they are HardDeleted, this operation is also not written to the `traveltransactionlog​`.

Here is an example search query to fetch which companies have been merged into another company, and actually deleted. The source record is the `contact_id​` (company identity).

```http
.../api/v1/archive/dynamic?$select=mergemovelog.operation, mergemovelog.tableNumber, mergemovelog.sourceRecord&$filter=movemergelog.registered afterTime <LastSyncTime>​
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

* In dialogs, place buttons along the bottom ordered like this: **Task** - **OK** - **Cancel**.

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

[2]: ../../api/authentication/online/sign-in-user/index.md
[5]: ../../api/authentication/online/auth-application/index.md

[1]: ./tenant-status/index.md
[8]: ./tenant-status/index.md

[13]: ../getting-started/what-api-to-use.md
[14]: ../standard-app/certification/checklist.md
[15]: ../standard-app/requirements/security.md
[24]: ../provisioning/index.md

[6]: ../../ui/design/index.md
[16]: ../../automation/webhook/index.md

[17]: ../../api/bulk-operations/index.md
[21]: ../../api/search/odata/index.md
[22]: ../../api/authentication/online/api.md#access-tokens
[23]: ../../api/web-services/webapi/index.md#soticket
[25]: ../../api/security/sentry/index.md
[26]: ../../api/archive-providers/data-aggregation.md

[7]: https://community.superoffice.com/en/technical/forums/general-forums/announcements/
[3]: https://github.com/SuperOffice/SuperOffice.DevNet.Online/blob/master/Source/SuperOffice.DevNet.Online.Provisioning/WebPanelHelper.cs#L335
[20]: https://en.wikipedia.org/wiki/Big_O_notation

<!-- Referenced images -->
[img1]: media/count.png
