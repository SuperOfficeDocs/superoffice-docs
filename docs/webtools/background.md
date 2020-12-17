---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: webtools_background       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Small recap on the road behind us

SuperOffice Web Tools bridges document editing in SuperOffice CRM Web with the associated applications on the user's desktop. In previous versions, this was possible by using a protocol handler. The Web client executed URIs to make Web Tools download a document. Web Tools would start the associated editor and when the user was finished editing the document, would upload the document. After a while, using protocol handlers became unreliable on some browsers. For instance, issuing the same protocol multiple times within a small time-frame would stop executing the commands entirely.

Our response to that was to create a browser plugin which worked on the most popular browsers, but of course, shortly after some browsers decided to drop support for NPAPI-based plugins. This leads us to the current implementation where we use SignalR-technology to communicate between SuperOffice in the web browser and Web Tools running on the user's desktop.  As you may realize by now, the interaction between SuperOffice Web Tools and SuperOffice Web is heavily dependent on the capabilities in the browser used.
