---
title: Inline CRMScript
uid: inline_crmscript
description: Inline CRMScript
author: SuperOffice Product and Engineering
date: 03.16.2023
keywords: Customer Center, CEP, CRMScript
audience: settings
content_type: concept
index: true
---

# Inline CRMScript

Inline CRMScript is our parallel to ASPX or PHP, where CRMScript is inlined into an HTML document. This allows for large portions of the document to be pure HTML (without having to use print-statements), and then inlining CRMScript using a special tag to "switch mode" between HTML and CRMScript. Here is an example of a very simple inlined CRMScript:

![CRMScript -screenshot][img1]

The leading `%EJSCRIPT_START%` and matching `%EJSCRIPT_END%` tell the Parser that what is between is inline CRMScript. If you want to, you can also have plain HTML outside these tags. Immediately inside these tags, we are in Parser-mode, which means we will output everything directly, but also look for parser variables, such as `%customer.name%`. When we encounter a `<%`, we switch into **CRMScript** mode, which we keep until we see an `%>`. This is completely analogous to PHP’s `""`. In this mode, we will execute the CRMScript, and you use `print()` to output HTML code. Note: you can have many CRMScript-blocks in the document, and they will be merged before parsing and execution. This means that you can start a loop in one block, then switch back to HTML-mode to print a lot of stuff, and then switch back to **CRMScript** mode to finish the loop:

![Example -screenshot][img2]

<!-- Referenced images -->
[img1]: media/image001.png
[img2]: media/image002.png
