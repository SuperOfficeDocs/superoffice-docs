---
uid: soprotocol-webpanel-web
title: SOProtocol and web panels - web
description: SoProtocol and web panels - web
keywords: soprotocol, deeplinking, web panel, crossmessaging, window.postMessage
author: Tony Yates
date: 05.26.2023
content_type: reference
category: customization
topic: soprotocol
redirect_from: /en/ui/soprotocol/used-in-webpanels-web
language: en
---

# SOProtocol and web panels - web

<!-- TODO rewrite -->

[dialog=stop]

[mode=display|edit] (issues via crossmessaging, in app JavaScript)

* info[mode=edit]

[refresh=false]

[usesuperstatecopy=true] (disconnect dialog from current updates)

* Only for dialogs use.

Normal operation is to refresh card, but refresh is used to stop
rerendering card, but still update the current (superstate).

Can force card refresh by setting to true.

webPaneName[refresh=false].minipreview?appointment_id=245

Use SoProtocol to set the currents...

Currents are History Items:
person_id =>

person:

* id
* name: shortcut to reduce access to the DB, list items contain IDs and name.
* type: used for different things. (differentiate)
  * associate or resource

<!-- Explain how to use soprotocol elements/parameters to pre-set fields in new entities, i.e.
soprotocol:document?contact_id=395678&person_id=1198581&document_id=0&task_idx=123 -->

## Sample

To get started, explore the [SoClientCrossMessaging.js sample on DevNet][1]. This sample demonstrates how `window.postMessage` can be used for communication from embedded web panels to SuperOffice CRM.

<!-- Referenced links -->
[1]: https://github.com/SuperOffice/DevNet/tree/master/CrossMessaging
