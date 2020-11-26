---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: onsite_compatibility_reports # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Compatibility test reports for SuperOffice onsite # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Compatibility reports

The compatibility test reports published. A "Test Passed" status is a 90% assurance that this product will work as intended in the environment tested.

We make the compatibility reports when other vendors release newer versions after our release. This is where you see if e.g a new version of Internet Explorer is compatible with the current releases of SuperOffice. Our system requirements are found [here](https://community.superoffice.com/en/technical/documentation/prepare/system-requirement/).

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/mac-os-big-sur.jpg)

## MacOS Big Sur

We have tested WebTools for Mac 11.4.7460.1008 on MacOS ‘Big Sur’. We’ve conducted the test on Big Sur Beta release as the final RTM is not yet released. No issues found during testing. Report made September 29th 2020.

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-maclink---os-macosbigsur.xlsx)

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/safari14.jpg)

## Safari 14

We have tested SuperOffice 9.1 R03 Web and Service with Safari 14 browser on MacOS ‘Big Sur’. We’ve conducted the test on Big Sur Beta release as the final RTM is not yet released. We found several UI related bugs both in Web and Service clients and logged in TFS (Web: 75607, 75606, 75608, Service: 75360, 75309). None of them are considered critical, hence we conclude the test as ‘Passed’. Report made September 29th 2020.

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-safari14_bigsur.xlsx)

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/macos-catalina.jpg)

## MacOS Catalina

We have tested SuperOffice 8.5 Web and Web Tools for Mac (11.2.7306) with MacOS Catalina. These issues have been identified while doing the testing: Bug 68216 (MacLink quts after sleep/or restart), Bug 68406 (Accessibility Dialog keep appearing on MacOS Catalina), Bug 67972 (Installer requires permission to Download folder). Report made January 22nd 2020.

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-maclink---os-macoscatalina.xlsx)

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/mssqlserver2019.png)

## SQL Server 2019

Microsoft SQL Server 2019 tested with SuperOffice 8.5 R07 along with ODBC driver 17.4.2.1. We mainly focused on product installation and performed smoke testing on critical functional areas of the products. No critical issues found during testing. Report made November 14th 2019.

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-sql-server-2019.xlsx)

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/moj.jpg)

## MacOS Mojave

We have tested SuperOffice 8.4 R03 Web and Service in Chrome and Safari with MacOS Mojave. See attached Compatibility report for found issues. Report made December 3rd 2018.

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-browser-compatibility-test-report-mojave.xlsx)

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/download-1.png)

## MS Office 2019

We have tested MS Office 2019 with SuperOffice 8.4. We put more focus on Office related functionalities such as Web Tools, Maillink and document handling, and the rest of the areas were smoked. We did not find any compatibility related issues/bugs during the test. Report made October 18th 2018.

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-office-2019.xlsx)

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/download.png)

## Windows Server 2019

We have tested Windows Server 2019 with SuperOffice 8.4. We mainly focused on product installation and performed smoke testing on critical functional areas. We did not find any compatibility related issues/bugs during the test. Report made October 18th 2018.

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-windows-server-2019.xlsx)

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/sqlserver2017.png)

## SQL Server 2017

We have tested SQL Server 2017 for SuperOffice 8.0 SR6 and performed smoke tests on all clients. All product installations were OK. No DB related issues encountered during installation. SQL Server 2017 (RTM) - 14.0.1000.169 (X64). Report made October 18th 2017.

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-sql-server-2017.xlsx)

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/macoshighsierra.jpg)

## MacOS High Sierra

We have tested WebTools for SuperOffice 8.1.6477 (for CRM Online) and 8.0.6477 (SR6). No issues found during our smoke tests. Please note that upgrading to this OS requires that you also update your WebTools or your documents will not be automatically uploaded to the server. Report made September 26th 2017.

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-maclink---macoshigh-sierra.xlsx)

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/windows-server-2016.png)

## Windows Server 2016

We have tested SuperOffice 8 version 8.0.6144 (SR4) for all clients \[Win, Web, CS and Pocket\] Pocket version 8.0.6109 on the new released server OS. No issues found during our smoke tests. Report made November 11th 2016.

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-windows-server-2016.xlsx)

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/macos-sierra.jpg)

## MacOS Sierra

SuperOffice MacLink have been tested successfully on MacOS Sierra. No issues found during our smoke tests. Report made October 2016.

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-maclink---os-sierra.xlsx)

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/sqlexpress.png)

## Microsoft SQL Express 2016

The objective of the test was to verify that SQL Express 2016 that is normally used as a Travel DB for CRM clients also can be used as the main DB for the CRM clients. DB Compatibility test for SuperOffice version 8.0 SR2 \[Win,Web, CS\] was carried out. Please note that this database version have limitations and may not suite your needs. Report made July 29th 2016

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-sql-server-2016-express.xlsx)

![](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/microsoft-sql.png)

## SQL Server 2016

Microsoft SQL Server 2016 have been tested successfully with SuperOffice 7.5 SR2 and SuperOffice 8.0 SR1, for all clients \[Win, Web, CS and Pocket\] Report made March 8th 2016 using SQL Server 2016 version 13.0.1000.281 / CTP 3.3

[Report (\*.xlsx)](https://community.superoffice.com/globalassets/technical-club/compatibility-reports/superoffice-compatibility-test-report-sql-server-2016.xlsx)