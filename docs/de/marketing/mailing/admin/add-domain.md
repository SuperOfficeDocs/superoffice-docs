---
uid: help-de-add-mailing-domain
title: Kampagne-Domäne hinzufügen
description: Objekte zur Liste Kampagne-Domäne hinzufügen
keywords: Kampagne, Domäne, SPF
author: digitaldiina
date: 10.28.2025
version: 11.5
content_type: howto
license: marketingessentials
category: Marketing
topic: mailing
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /de/admin/lists/learn/add-items-to-mailing-domain
language: de
---

# Kampagnen-Domänen hinzufügen

Wenn die globale Präferenz **Nur genehmigte E-Mail-Absenderdomänen verwenden** auf **Ja** festgelegt wurde, können Benutzer nur E-Mails von Domänen senden, die dieser Liste in SuperOffice CRM hinzugefügt wurden. Es ist daher wichtig, genehmigte Domänen mit einer gültigen [SPF-Eintragung (Sender Policy Framework)][1] zu dieser Liste hinzuzufügen.

> [!NOTE]
> Die globale Präferenz **Nur genehmigte E-Mail-Absenderdomänen** in der Gruppe **Marketing** muss auf **Ja** festgelegt werden, um die Liste Kampagne-Domäne zu verwenden.

## Schritte

1. Klicken Sie unter **Einstellungen und Verwaltung** auf **Listen** und wählen Sie **Kampagnen-Domänen** aus.

1. Klicken Sie auf **Hinzufügen**, um eine neue genehmigte Domäne hinzuzufügen.

1. Fügen Sie den Domänennamen hinzu und klicken Sie auf **Speichern**. Das System führt eine SPF-Suche durch, um zu überprüfen, ob die Domäne über eine gültige SPF-Eintragung verfügt. Anderenfalls wird eine Warnung angezeigt, die Sie darauf hinweist, dass für Kampagnen-Domänen eine gültige SPF-Eintragung erforderlich ist. Klicken Sie auf **OK** und versuchen Sie eine andere Domäne.

1. Wenn die SPF-Suche der Domäne erfolgreich abgeschlossen wird, wird sie in die Liste der genehmigten Domänen aufgenommen und die Benutzer können Kampagnen von dieser Domäne senden.

> [!NOTE]
> Sie können einen SPF-Eintrag für Ihre Domäne festlegen, um sicherzustellen, dass Ihre Organisation Kampagnen mit erhöhter Zustellbarkeit senden kann (NUR ONLINE). Wenn Ihre Umgebung eine VOR-ORT-Umgebung ist, wird keine SPF-Suche durchgeführt. Sie können die Liste jedoch weiterhin verwenden, um Ihren Benutzern voreingestellte Domänen für **Absender-** und **Antwortadressen** zur Verfügung zu stellen.

<!-- Referenced links -->
[1]: ../../../../en/online/mail-services/mailgun/spf/index.md

<!-- Referenced images -->
