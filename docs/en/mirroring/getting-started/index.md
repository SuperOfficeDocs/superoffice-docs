---
title: Getting started
uid: mirroring_getting_started
description: Getting started with database mirroring
author: Tony Yates
so.date: 04.20.2016
keywords:
so.topic: guide
so.envir: cloud
so.client: online
---

# Getting started with database mirroring

Database Mirroring presents a new API capability for partners building online integrations. By mirroring a customer's database, it gives partners a tremendous about of flexibility to perform deep analysis on customer data; all without having to rely on web services subjected to latency or throughput issues.

We believe there are many scenarios where this capability will be extremely beneficial to partner applications and those customers who consume them. We also realize that this capability poses a potential problem where partners will try to create solutions that don't fit any of the ideal scenarios. In most of these cases, they will be filtered and vetted through the certification process, so perhaps in the future, there will be more best-case scenario guidance for application vendors to follow.

## Database mirror options

Data Mirroring Service is a copy of your data stored at a location of your choice outside the SuperOffice CRM Online environment. This requires [the database mirroring subscription][7].

* [Order Database Mirroring][7] as a standalone application

* Get Database Mirror capability on an existing or new app
  * [Register a new application][9]
  * [Update existing application][8]

## Where to begin

With application details registered, it's time to create a web service that implements the IMirrorClientService and IMirrorAdmin interfaces. There are three options:

* Implement the service from <a href="../../../assets/downloads/dbmirroring-wsdl.zip" download>WSDL files</a>.
* Add a [.NET nuget package][4] to a WCF Service application project.
* Clone or download the [database mirror service repository from GitHub][11].
  * This is a 'ready-to-go' .NET solution that only needs to be compiled and deployed.

Once the mirroring endpoint is ready and the application has been activated, each synchronization cycle begins with an authentication phase. The authentication phase requires certificates to ensure a trusted connection.

SuperOffice generates a certificate for each application. The public side of the certificate is stored inside SuperOffice, while the private side of the certificate is sent to the application owner. The private side of the certificate is used by the service to sign authentication request responses.

The authentication flow begins with SuperOffice issuing a signed authentication request that the mirroring service must both validate and issue a signed response.

The mirroring service must use one of the following certificate strategies to validate the authentication request.

* [install the SuperOffice public certificates][2] in the server certificate store.
* [overridden the certificate resolver][1] and load the certificate on demand.

In return, the mirroring service must use its' private certificate to sign the response sent back to SuperOffice.SuperOffice uses the applications stored public certificate to verify the authentication response. Once successfully validated, the SuperOffice Database Mirroring service begin sending data to the application endpoint.

## Testing in SuperOffice Online Development Environment (SOD)

This mirroring service will provision the mirror databases on one fixed SQL server; each database will be named `Mirror_<contextId>`.

Any test databases (tenants) that Authorize your application (after successfully signing in on SuperOffices' login page) will then receive a mirror, and the mirror will be kept up to date as long as it is authorized. This represents the beginning of testing.

Mirroring activities are registered in the Event Log for the customer in OC. There is one Information entry for each successful mirroring cycle, as well as Error events when something fails.

In principle, any change to any table should be mirrored. This includes Insert/Update/Delete, as well as additions of extra tables and fields in the Service product. Note that many GUI operations that look like a delete do not actually delete physical rows from the database, so when testing deletes make sure that a delete actually happened in the customer database.

Since there is no GUI to look at data in a mirror, SQL Server Management Studio must be used. Generally, it should be possible to do `select * from <sometable>` in both the customer table and the mirror and get the same result.

Backup/restore is a special case. If the sequence of events is mirror – backup – change – mirror – restore – mirror, then the system will detect that the mirror is "ahead" of the original and trigger a full repopulation. However, if the scenario is mirror – backup – change – mirror – restore – change – change – mirror then the sum of changes since the restore may be enough to camouflage the fact that a restore happened. In that case, the mirror must be manually invalidated at the partner-side, which can be done by setting the LSN of all tables to -1 in the mirror database’s `<context_id>_mirroring` table. Whether we need a way to force this from OC is something we’ll have to find out.

## Restrictions

It does not make business sense to provide a complete database mirror to partner applications. Not only might this incur unnecessary stress between systems, but we also prevent access to sensitive customer data that simply doesn't belong in any other domain, such as area and travel tables, search criteria and operators, dbi agent information, and windows positions. A complete list of tables both replicated and not replicated with reason is listed in the [blocked tables list][3].

If you believe you have a great case for an application, navigate to the [application registration page][10] (for existing partners) and get started today! If you are not yet an online application partner, get started today by filling our [developer registration form][6].

<!-- Referenced links -->
[1]: ../../api/authentication/online/certificates/override-resolver.md
[2]: ../../api/authentication/online/certificates/index.md
[3]: ../blocked-tables.md
[4]: https://www.nuget.org/packages/SuperOffice.Crm.Online.Mirroring
[7]: ../order-database-mirroring.md
[6]: ../../developer-portal/getting-started/get-access-to-sod.md
[8]: ../../developer-portal/faq/update-app.md
[9]: ../../developer-portal/create-app/mirror-app.md
[10]: ../../developer-portal/create-app/index.md
[11]: https://github.com/SuperOffice/devnet-database-mirroring
