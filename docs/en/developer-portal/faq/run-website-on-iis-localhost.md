---
title: Run website on IIS localhost
uid: run_website_on_iis_localhost
description: Run a website on your machine, IIS localhost
author: {github-id}
keywords: IIS, localhost, Visual Studio
topic: howto
envir: cloud
client: online
---

# Run a website on your machine, IIS localhost

Many web applications are configured to run a website on your machine, IIS localhost.

To make it easier on yourself:

1. Open Visual Studio as an administrator. Your instance of Visual Studio should have **(Administrator)** in the title bar.
2. Let Visual Studio create the site in IIS for you automatically.

![x -screenshot][img1]

If you open a solution and notice that the project has failed to load, this is probably because your Visual Studio is not run as an administrator. Restart the application and select **Run as administrator**.

<!-- Referenced images -->
[img1]: media/image014.png
