---
title: Watchcom initial security evaluation
uid: watchcom-app-evaluation
description: About Watchcom initial security evaluation
author: Margrethe Romnes
so.date: 09.07.2023
keywords: Watchcom, security, certification
so.topic: concept
so.envir: cloud
so.client: online
---

# About Watchcom initial security evaluation

Our security policy requires that applications pass a security evaluation before being accepted into the software sphere of SuperOffice. This security evaluation is performed by [Watchcom Security Group][1], a specialist on internet security.

Watchcom works for SuperOffice AS to evaluate the security of your company as a **prerequisite to getting your standard application accepted**.

The security evaluation is designed to make sure that you as a partner have given thought to the cybersecurity of your company and the information security of your application.

> [!NOTE]
> We are aware that some partners may already have done a security audit by another vendor. However, for our App Store, we require that your application goes through our particular audit because Watchcom knows SuperOffice and our environment.

## What exactly is this mandatory evaluation?

The Watchcom security evaluation has 3 key elements:

* Self-assessment review
* Testing
* Audit report

The self-assessment and the audit report are **confidential** between the partner and Watchcom. SuperOffice is only informed if there are red flags needing to be fixed.

## How is the testing done?

### Scan ports of exposed infrastructure

Depending on the internet presence of your company, we will scan the whole of your external infrastructure to make sure that computers in the network don’t expose services that can be easily exploited.

The focus will be on computers hosting the partner application.

### Scan exposed infrastructure for vulnerabilities

Exposed services found in the previous phase will be scanned for known vulnerabilities. Watchcom employs a range of vulnerability scanners to keep up with industry standards.

### Scan web applications and web APIs for vulnerability

Any web applications or web APIs that will communicate with SuperOffice’s servers will be scanned.

### Manual audit

Watchcom’s expert penetration testers will make a limited manual audit of the application.

### Audit information security

Design, architecture, infrastructure, and data storage will be audited to make sure that customer data, and data belonging to SuperOffice, is properly protected.

## Does it cost anything?

You will be invoiced and pay Wathcom directly for the services delivered in connection with the security audit.

Security audits come in 3 different packages: small, medium (for most apps), and large.

<!-- markdownlint-disable MD033 -->
<table class="table-striped" style="width: 100%;" border="1">
  <caption>Watchcom price models</caption>
  <colgroup> <col style="width: 25%;" span="1" /> <col style="width: 25%;" span="1" /> <col style="width: 25%;" span="1" /><col style="width: 25%;" span="1" /></colgroup>
  <thead>
    <tr>
    <th>&nbsp;</th>
    <th scope="col">Small</th>
    <th scope="col">Medium</th>
    <th scope="col">Large</th>
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
    <li>Users see their own login screen and not just SuperOffice federated authentication</li>
    <li>The app has database mirroring</li>
    </ul>
    </td>
    </tr>
    <tr>
    <th scope="row">Time (testing and prepare report)</th>
    <td>7 work hours</td>
    <td>11 work hours</td>
    <td>18 work hours</td>
    </tr>
    <tr>
    <th scope="row">Price</th>
    <td>10.000 NOK + VAT <br>(approx &euro; 995)</td>
    <td>15.000 NOK + VAT <br>(approx &euro; 1490)</td>
    <td>25.000 NOK + VAT <br>(approx &euro; 2480)</td>
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

7. After the test, you get the full report from Watchcom while we only receive a pass/fail notification. **It is your responsibility to fix any red flags!**

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
