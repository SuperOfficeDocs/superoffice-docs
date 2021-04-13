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

Database Mirroring presents a new API capability for partners building online integrations. By mirroring a customers database, it gives partners a tremendous about of flexibility to perform deep analysis on customer data; all without having to relay on web services subjected to latency or throughput issues.

We believe there are many scenarios where this capability will be extremely beneficial to partner applications, and those customers who consume them. We also realize that this capability poses a potential problem where partners will try to create solutions that don't fit any of the ideal scenarios. In most of these cases, they will be filtered and vetted through the certification process, so perhaps in the future there will be more best-case scenario guidance for application vendors to follow.

## Where to begin

Whether the sole purpose of an application is database processing or a myriad of services, partners must first [register an application][1] and specify Database Mirroring should be enabled. In addition to the application details, a partner must provide a URL where the web service implementing IMirrorClientService and IMirrorAdmin is located.

Because each synchronization cycle begins with an authentication phase, certificates are used to ensure a trusted connection, and partners must ensure their servers have [installed the public SuperOffice certificates][2] to successfully validate security tokens sent from SuperOffice. Partners must also have a private certificate with which to sign authentication responses sent back to SuperOffice. Finally, SuperOffice must have the public side of the partners certificate to successfully validate those responses. There is a great deal more information about certificates in the [Security and Authentication][3] section of this topic.

With an application successfully registered in OC, and certificates setup correctly, the rest is pretty straight forward using our NuGet package. As you will discover in the next section, .NET and SQL Server partners can have an implementation up and running in about 10 minutes or less.

Partners who prefer to implement the `IMirrorClientServce` interfaces using another technology can download the [WSDL files here][4]. We do not provide support for any other technologies than those discussed here in this article, i.e. SQL Server.

## Testing in SuperOffice Online Development Environment (SOD)

This mirroring service will provision the mirror databases on one fixed SQL server; each database will be named `Mirror_<contextId>`.

Any test databases (tenants) that Authorize your application (after successfully signing in on SuperOffices' login page) will then receive a mirror, and the mirror will be kept up to date as long as it is authorized. This represents the beginning of testing.

Mirroring activities are registered in the Event Log for the customer in OC. There is one Information entry for each successful mirroring cycle, as well as Error events when something fails.

In principle, any change to any table should be mirrored. This includes Insert/Update/Delete, as well as additions of extra tables and fields in the Service product. Note that many GUI operations that look like a delete do not actually delete physical rows from the database, so when testing deletes make sure that a delete actually happened in the customer database.

Since there is no GUI to look at data in a mirror, Sql Server Management Studio must be used. Generally it should be possible to do `select * from <sometable>` in both the customer table and the mirror, and get the same result.

Backup/restore is a special case. If the sequence of events is mirror – backup – change – mirror – restore – mirror, then the system will detect that the mirror is "ahead" of the original and trigger a full repopulation. However, if the scenario is mirror – backup – change – mirror – restore – change – change – mirror then the sum of changes since the restore may be enough to camouflage that fact that a restore happened. In that case the mirror must be manually invalidated at the partner side, which can be done by setting the LSN of all tables to -1 in the mirror database’s `<context_id>_mirroring` table. Whether we need a way to force this from OC is something we’ll have to find out.

## Restrictions

It does not make business sense to provide a complete database mirror to partner applications. Not only might this incur unnecessary stress between systems, we prevent access to sensitive customer data that simply doesn't belong in any other domain, such as area and travel tables, search criteria and operators, dbi agent information and windows positions. A complete list of tables both replicated and not replicated with reason is listed in the <a href="../../assets/downloads/mirroredtables.docx" download>Mirrored Tables document</a>.

If you believe you have a great case for an application, navigate to the [application registration page][1] (for existing partners) and get started today! If you are not yet an online application partner, get started today by filling our [developer registration form][6].

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/developer/create-apps/resources/application-registration/
[2]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/authentication/online/certificates/configure.md
[3]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/authentication/online/index.md
[4]: https://www.nuget.org/packages/SuperOffice.Crm.Online.Mirroring
[6]: https://community.superoffice.com/en/developer/create-apps/resources/developer-registration/
