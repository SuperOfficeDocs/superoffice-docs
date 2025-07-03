---
uid: eol-pagebuilder
title: End of life - Pagebuilder customization
description: This is a reminder of end of life for SuperOffice Pagebuilder customizations.
keywords: Pagebuilder, EOL
author: Trude Lien Smedbråten
date: 11.01.2023
version: 10.2.9
content_type: release-note
deployment: onsite
language: en
---

# End of life - Pagebuilder customization

SuperOffice Onsite version 10.2.9 is the last version to support [PageBuilder][2] customizations.

As we are gradually rewriting all UI using our new SCIL framework, Pagebuilder based customizations will stop working. (This is not new, Pagebuilder extensibility is deprecated, and no longer supported).

After refactoring the Sale card, Project card, and Archives, we have kept a possibility open for disabling these new versions for a few Onsite customers with extensive customizations. This have been possible by manually disabling feature toggles within the *web.config* file.

This message is a heads up for those who have used this possibility to keep Pagebuilder customizations live a bit longer: **Onsite version 10.2.9 is the last onsite version where you can switch back to Pagebuilder versions of the Sale card, Project card, and Archives.**

## What does this mean for you as a customer/developer?

You are recommended to switch to the [Screen Designer][1].

<!-- Referenced links -->
[1]: ../../docs/en/ui/screen-designer/learn/index.md
[2]: ../../docs/en/ui/web-app/pagebuilder/index.md
