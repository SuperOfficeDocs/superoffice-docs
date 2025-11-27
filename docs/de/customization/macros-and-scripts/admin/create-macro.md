---
uid: help-de-automation-macro-create
title: Makro erstellen - Beispiel aus SuperOffice
description: Beispiel für die Erstellung eines Makros in SuperOffice.
keywords: Skript, Makro
author: digitaldiina
date: 11.26.2025
version: 11.6
content_type: howto
category: automation
topic: CRMScript
audience: settings
audience_tooltip: Settings and maintenance
redirect_from: /de/automation/crmscript/learn/create-macro
language: de
index: true
---

# Makro erstellen - Beispiel aus SuperOffice

Viele Firmen erhalten oft Anfragen bezüglich der Rechnungslegung. Solche Anfragen sollten direkt an die Buchhaltungsabteilung weitergeleitet werden. Anstatt jede Anfrage einzeln zu bearbeiten und Kategorie und Eigentümer zu ändern, können wir ein Makro für diese Aktionen erstellen. Das Makro kann der Schaltfläche **Aufgabe** in der Ansicht Anfrage zugewiesen werden. Fragen zur Rechnungslegung können daher mit nur einem Klick an die Buchhaltungsabteilung weitergeleitet werden.

> [!TIP]
> Wenn Sie diesen Prozess vollständig automatisieren möchten, erstellen Sie einen E-Mail-Filter, mit dem die Betreff-Zeilen von E-Mails nach dem Begriff "Rechnung" durchsucht werden. Führen Sie dann für entsprechende E-Mails das Makro aus, das sie der richtigen Abteilung zuweist.

Wir werden jetzt ein Makro basierend auf dem Beispiel oben erstellen.

## Schritte

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Wählen Sie <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** und die Registerkarte für **Makros und Skript** aus. Führen Sie einen der folgenden Schritte aus:
    * So erstellen Sie ein neues Makro: Klicken Sie auf **Neues Makro**.
    * So bearbeiten Sie ein vorhandenes Makro: Klicken Sie auf den Namen des Makros.

1. Auf der Registerkarte **Informationen** geben Sie "Anfrage an Buchhaltung senden" in das Feld **Name** und in das Feld darunter eine Beschreibung ein.

1. Aktivieren Sie die Option **Neues Menü**, damit das Makro über die Schaltfläche **Aufgabe** in der Ansicht Firma, Person oder Anfrage oder auf der Registerkarte **Mitteilung** zur Verfügung steht.

1. Gehen Sie zur Registerkarte **Aktionen** und wählen Sie **Aktionstyp ändern** > **Anfrage ändern** aus.

1. Aktivieren Sie **Kategorie** und wählen Sie eine Kategorie in der Liste (z. B. *Buchhaltung*).

1. Aktivieren Sie **Eigentümer** und wählen Sie einen Benutzer.

    > [!TIP]
    > Alternativ können Sie **Automatisch zugeordnet** auswählen, damit das System die Anfrage gemäß der aktuellen Verteilungsregeln verteilen kann.

1. Aktivieren Sie **Interne Mitteilung** und schreiben Sie eine kurze Standardnachricht an die Buchhaltungsabteilung darüber, warum sie diese Anfrage erhalten haben.

1. Klicken Sie, sobald Sie fertig sind, auf **OK**.

## Zugehörige Inhalte

* [Weitere Infos über erweiterte Makrofunktionen und Trigger][1]

<!-- Referenced links -->
[1]: trigger.md

<!-- Referenced images -->
