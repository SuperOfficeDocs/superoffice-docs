---
title: Watchcom initial security evaluation
uid: watchcom-app-evaluation
description: About Watchcom initial security evaluation
author: Margrethe Romnes, Watchcom
date: 12.14.2023
keywords: Watchcom, security, certification
topic: concept
envir: cloud
client: online
---

# About Watchcom initial security evaluation

SuperOffice's security policy requires that applications (and partners) pass a security evaluation before being accepted into the software sphere of SuperOffice. This security evaluation is performed by [Watchcom Security Group][1], a specialist on internet security.

Watchcom works for SuperOffice AS to evaluate the security of your company as a **prerequisite to getting your standard application accepted**.

The security evaluation is designed to make sure that you as a partner have given thought to the cybersecurity of your company and the information security of your application.

> [!NOTE]
> We are aware that some partners may already have done a security audit by another vendor. However, for the SuperOffice App Store, we require that your application goes through our particular audit because Watchcom knows SuperOffice and our environment.

## What exactly is this mandatory evaluation?

The Watchcom security evaluation has 3 key elements:

* Self-assessment review
* Testing
* Audit report

The self-assessment and the audit report are **confidential** between the partner and Watchcom. SuperOffice is only informed if there are red flags needing to be fixed.

## How is the testing done?

### Self-assessment review

SuperOffice will present you with a questionnaire that must be filled out. This questionnaire allows you to do a self-assessment of the company's view on cyber security and will reflect how the company thinks about cyber security, and how routines, processes, and policies are enforced.

The questions cover the whole specter of the organization’s information security, and it may therefore be necessary to get information from multiple resources within the organization to answer precisely.

Watchcom will review the self-assessment and inform SuperOffice of potential red flags.

### Manual audit

Watchcom’s expert penetration testers will make a limited manual audit of the application. The overall goal is to identify potential weaknesses and vulnerabilities in how the third-party application is integrated toward SuperOffice, and how the integration could affect SuperOffice and the data belonging to SuperOffice.

Depending on the integration toward SuperOffice, the testing will include (but is not limited to) testing of weaknesses and vulnerabilities related to network communication, API endpoints, and web applications.

The testing performed by Watchcom involves both manual and automated testing. **This may impact the service that is in scope, and could cause unwanted down-time.**

### Audit report

When the test is completed, you will receive a full security report from Watchcom.

The report will include an executive summary, and detailed information about each finding. All findings will be mapped to OWASP Top 10 with a dedicated risk-score. Each finding will also have relevant information for how to replicate and mitigate the finding.

Any finding classified as **medium risk, or above**, will result in the application not being approved. To get approved, a re-test of the application will be necessary.

The report can also serve as proof of a conducted security evaluation for other third parties.

## Does it cost anything?

You will be invoiced and pay Watchcom directly for the services delivered in connection with the security audit.

Security audits come in 3 different packages: small, medium (for most apps), and large.

<!-- markdownlint-disable MD033 -->
<table class="table-striped" style="width: 100%;" border="1">
  <caption>Watchcom price models</caption>
  <colgroup> <col style="width: 20%;" span="1" /> <col style="width: 20%;" span="1" /> <col style="width: 20%;" span="1" /><col style="width: 20%;" span="1" /><col style="width: 20%;" span="1" /></colgroup>
  <thead>
    <tr>
    <th>&nbsp;</th>
    <th scope="col">Small</th>
    <th scope="col">Medium</th>
    <th scope="col">Large</th>
    <th scope="col">Extended</th>
    </tr>
  </thead>
  <tbody>
    <tr>
    <th scope="row">Description</th>
    <td>
    <ul>
    <li>The app has little interaction with a customer's database</li>
    <li>Typically a read-only app</li>
    </ul>
    </td>
    <td>
    <ul>
    <li>The app has both read and write access to a customer's database</li>
    </ul>
    </td>
    <td>
    <ul>
    <li>The app has both read and write access to a customer's database</li>
    <li>Users sign in with the application's login screen and not just SuperOffice federated authentication</li>
    <li>The app has database mirroring</li>
    </ul>
    </td>
    <td>
    <ul>
    <li>A standalone web application where users see their own login screen and not just SuperOffice federated authentication</li>
    <li>A standalone web application where SuperOffice is integrated into the application</li>
    </ul>
    </td>
    </tr>
    <tr>
    <th scope="row">Time (testing and prepare report)</th>
    <td>7 work hours</td>
    <td>11 work hours</td>
    <td>18 work hours</td>
    <td>Per agreement</td>
    </tr>
    <tr>
    <th scope="row">Price</th>
    <td>12.500 NOK + VAT <br>(approx &euro; 1060)</td>
    <td>17.500 NOK + VAT <br>(approx &euro; 1480)</td>
    <td>29.500 NOK + VAT <br>(approx &euro; 2500)</td>
    <td>Per agreement </td>
    </tr>
  </tbody>
</table>
<!-- markdownlint-restore -->

> [!WARNING]
> If the audit uncovers extensive issues that need to be fixed, it may lead to re-testing and additional auditing services. This may induce additional fees. You will be notified if and when this occurs. You are not obliged to complete and pay for an additional audit - however, **failing to do so will lead to your application not being certified and therefore not listed in the SuperOffice App Store**.

## Pre-requisites

* You have [submitted your standard application for certification][4].
* Your designated certification contact must be available during the test period.
* We have screened your application and approved it for our staging environment (`qaonline.superoffice.com`).

We may send you multiple sets of keys at the same time. You will **not** be able to connect using the production keys until you pass the security evaluation and we explicitly activate them!

## Workflow

1. We send you the [application keys][2] for both [stage and production][3].

2. You set up the application in stage and **make sure that it still works**.

3. Your certification contact notifies us that you are ready to proceed.

4. We run a quick verification to confirm that you are ready for Watchcom.

5. We prepare a **Handover document** and send it to Watchcom. It explains:

    * What does the application add?
    * How does the application work with SuperOffice?

6. Our Watchcom contact will get in touch with your certification contact to schedule a date and time for testing.

7. After the test, you get the full report from Watchcom while SuperOffice only receive a pass/fail notification.

    > [!NOTE]
    > **It is your responsibility to fix any red flags!** Contact SuperOffice to schedule a re-test. We will verify that the integration and environment is ready for Watchcom to perform the re-test.

8. When approved, we activate the application's keys to the production environment.

9. You can now set up the application in production and connect to test that it works. **The application is still not published!**

**Next steps:** [get listed in the App Store][5] and [publish your application][6]

<!-- Referenced links -->
[1]: https://www.watchcom.no/
[2]: ../../getting-started/index.md#terminology
[3]: ../../getting-started/app-envir.md
[4]: certify-app.md
[5]: ../app-store/update-app-page.md
[6]: ../publish.md
