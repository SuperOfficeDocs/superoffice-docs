---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: onsite_compatibility_reports # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Compatibility test reports for SuperOffice onsite # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: requirements
so.topic: reference             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Compatibility reports

The published compatibility test reports. A "Test Passed" status is a 90% assurance that this product will work as intended in the environment tested.

We make the compatibility reports when other vendors release newer versions after our release. This is where you see if, for example, a new version of Internet Explorer is compatible with the current releases of SuperOffice. You can also check out the [system requirements][1].

## MacOS Big Sur

![mac-os-big-sur.jpg][img1]

We have tested WebTools for Mac 11.4.7460.1008 on MacOS ‘Big Sur’. We’ve conducted the test on Big Sur Beta release as the final RTM is not yet released. No issues were found during testing. The report was made on September 29th 2020.

[Report (\*.xlsx)][2]

## Safari 14

![safari14.jpg][img2]

We have tested SuperOffice 9.1 R03 Web and Service with Safari 14 browser on MacOS ‘Big Sur’. We’ve conducted the test on Big Sur Beta release as the final RTM is not yet released. We found several UI-related bugs both in Web and Service clients and logged in TFS (Web: 75607, 75606, 75608, Service: 75360, 75309). None of them are considered critical, hence we conclude the test as ‘Passed’. The report was made on September 29th 2020.

[Report (\*.xlsx)][3]

## MacOS Catalina

![macos-catalina.jpg][img3]

We have tested SuperOffice 8.5 Web and Web Tools for Mac (11.2.7306) with MacOS Catalina. These issues have been identified while doing the testing: Bug 68216 (MacLink quits after sleep/or restart), Bug 68406 (Accessibility Dialog keep appearing on MacOS Catalina), Bug 67972 (Installer requires permission to Download folder). The report was made on January 22nd 2020.

[Report (\*.xlsx)][4]

## SQL Server 2019

![mssqlserver2019.png][img4]

Microsoft SQL Server 2019 tested with SuperOffice 8.5 R07 along with ODBC driver 17.4.2.1. We mainly focused on product installation and performed smoke testing on critical functional areas of the products. No critical issues were found during testing. The report was made on November 14th 2019.

[Report (\*.xlsx)][5]

## MacOS Mojave

![moj.jpg][img5]

We have tested SuperOffice 8.4 R03 Web and Service in Chrome and Safari with MacOS Mojave. See attached Compatibility report for found issues. The report was made on December 3rd 2018.

[Report (\*.xlsx)][6]

## MS Office 2019

![office2019.png][img6]

We have tested MS Office 2019 with SuperOffice 8.4. We put more focus on Office-related functionalities such as Web Tools, MailLink, and document handling, and the rest of the areas were smoked. We did not find any compatibility-related issues/bugs during the test. The report was made on October 18th 2018.

[Report (\*.xlsx)][7]

## Windows Server 2019

![win-server-2019.png][img7]

We have tested Windows Server 2019 with SuperOffice 8.4. We mainly focused on product installation and performed smoke testing on critical functional areas. We did not find any compatibility-related issues/bugs during the test. The report was made on October 18th 2018.

[Report (\*.xlsx)][8]

## SQL Server 2017

![sqlserver2017.png][img8]

We have tested SQL Server 2017 for SuperOffice 8.0 SR6 and performed smoke tests on all clients. All product installations were OK. No database-related issues were encountered during installation. SQL Server 2017 (RTM) - 14.0.1000.169 (X64). The report was made on October 18th 2017.

[Report (\*.xlsx)][9]

## MacOS High Sierra

![macoshighsierra.jpg][img9]

We have tested WebTools for SuperOffice 8.1.6477 (for CRM Online) and 8.0.6477 (SR6). No issues were found during our smoke tests. Please note that upgrading to this OS requires that you also update your WebTools or your documents will not be automatically uploaded to the server. The report was made on September 26th 2017.

[Report (\*.xlsx)][10]

## Windows Server 2016

![windows-server-2016.png][img10]

We have tested SuperOffice 8 version 8.0.6144 (SR4) for all clients (Win, Web, CS, and Pocket) Pocket version 8.0.6109 on the new, released server OS. No issues were found during our smoke tests. The report was made on November 11th 2016.

[Report (\*.xlsx)][11]

## MacOS Sierra

![macos-sierra.jpg][img11]

SuperOffice MacLink has been tested successfully on MacOS Sierra. No issues were found during our smoke tests. The report was made in October 2016.

[Report (\*.xlsx)][12]

## Microsoft SQL Express 2016

![sqlexpress.png][img12]

The objective of the test was to verify that SQL Express 2016m which is normally used as a Travel DB for CRM clients, also can be used as the main DB for the CRM clients. DB Compatibility test for SuperOffice version 8.0 SR2 [Win, Web, CS) was carried out. Please note that this database version has limitations and may not suit your needs. The report was made on July 29th 2016.

[Report (\*.xlsx)][13]

![microsoft-sql.png][img13]

## SQL Server 2016

Microsoft SQL Server 2016 has been tested successfully with SuperOffice 7.5 SR2 and SuperOffice 8.0 SR1, for all clients (Win, Web, CS, and Pocket) The report was made on March 8th 2016 using SQL Server 2016 version 13.0.1000.281 / CTP 3.3.

[Report (\*.xlsx)][14]

<!-- Referenced links -->
[1]: ../system-requirements.md
[2]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-maclink---os-macosbigsur.xlsx
[3]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-safari14_bigsur.xlsx
[4]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-maclink---os-macoscatalina.xlsx
[5]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-sql-server-2019.xlsx
[6]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-browser-compatibility-test-report-mojave.xlsx
[7]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-office-2019.xlsx
[8]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-windows-server-2019.xlsx
[9]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-sql-server-2017.xlsx
[10]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-maclink---macoshigh-sierra.xlsx
[11]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-windows-server-2016.xlsx
[12]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-maclink---os-sierra.xlsx
[13]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-sql-server-2016-express.xlsx
[14]: https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-sql-server-2016.xlsx

<!-- Referenced images -->
[img1]: media/mac-os-big-sur.jpg
[img2]: media/safari14.jpg
[img3]: media/macos-catalina.jpg
[img4]: media/mssqlserver2019.png
[img5]: media/moj.jpg
[img6]: media/office2019.png
[img7]: media/win-server-2019.png
[img8]: media/sqlserver2017.png
[img9]: media/macoshighsierra.jpg
[img10]: media/windows-server-2016.png
[img11]: media/macos-sierra.jpg
[img12]: media/sqlexpress.png
[img13]: media/microsoft-sql.png
