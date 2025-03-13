---
title: Getting starting with SuperOffice Apps
uid: tutorial-getting-started-apps
description: Introduction to building online integrations and applications
author: Tony Yates
date: 03.04.2024
keywords: online, development
topic: tutorial
envir: cloud
client: online
---

# Build your first application and access the APIs

As an integration partner, you’re not just building an integration or application — you’re extending the capabilities of SuperOffice CRM Online. Your work enables custom integrations and complementary applications that enhance the value of our CRM.

## Creating your first application

In the **SuperOffice developer portal**, you can create applications for various use cases.

Step 1: Sign-in to the [developer portal][2]

Step 2: Click "[Create app][3]"

Step 3: Choose an application template. Which templated should you chose? The simplest way to decide is to answer the following questions:

1. **Is your app a web application?**
   * If **yes**, use **web app** (interactive login).
   * If **no**, use **server-to-server app** (system-user authentication). Good for **web applications** that also need **back-channel** communications.

2. **Will your app require users to interact with it in a web browser?**
   * If **yes**, choose a **web app** or **native app**.
   * If **no**, consider a **server-to-server app** for automation.  

3. **Is your app syncing SuperOffice data to another system?**
   * If **yes**, consider **ERP sync & quote** or **mirroring app**.

4. **Are you building a unique solution that doesn’t fit a template?**
   * If **yes**, start with the **empty app (DIY)** template and configure it manually.


  <!-- Links -->

[1]: https://www.superoffice.com/order/sandbox/
[2]: https://dev.superoffice.com/
[3]: ../create-app/index.md