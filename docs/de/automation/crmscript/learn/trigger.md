---
uid: help-de-automation-trigger
title: Auslöser
description: Auslöser
author: SuperOffice RnD
date: 06.29.2022
keywords: CRMScript, Auslöser
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Auslöser

[!include[Requirement](../../../learn/includes/req-expander-services.md)]

Auslöser sind Skripts, die bei bestimmten Ereignissen im System ausgeführt werden, beispielsweise wenn ein neuer Verkauf erstellt oder eine Anfrage geschlossen wird. Auslöser können im Hintergrund auf das Geschehen reagieren oder den Vorgang blockieren und dem Benutzer eine Erklärung anzeigen.

Mit CRMScript können Sie verschiedene Aufgaben automatisieren und Ihre Arbeit damit effizienter gestalten. Sie können definieren, dass ein bestimmtes Ereignis im System eine oder mehrere vordefinierte Aktionen auslösen soll. Es sind keine Scripting-Kenntnisse erforderlich, um dies vorzunehmen.

**Beispiel aus SuperOffice**: Wenn eine Anfrage geschlossen wird, muss der Kunde per E-Mail darüber informiert werden. Wir können ein Makro erstellen, das eine Reihe von Aktionen enthält, um diese E-Mail-Benachrichtigung zu erstellen und zu senden. Dieses Makro wird beim Schließen einer Anfrage automatisch ausgeführt. Die Aktionen im Makro laden die entsprechende Anfrage, rufen die richtige Antwortvorlage ab und senden eine E-Mail an den Kunden, dass die Anfrage geschlossen ist.

Dies ist ein Beispiel für einen ganz einfachen Auslöser. Sie können den Aktionen in einem Auslöser beispielsweise Bedingungen hinzufügen, indem Sie die Standardeinstellung **Immer** ändern.

## Auslöser erstellen

Wir werden jetzt eine Reihe von Aktionen basierend auf dem Beispiel oben erstellen.

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Klicken Sie auf <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** und wählen Sie die Registerkarte **Auslöser** aus.
1. Klicken Sie auf die Schaltfläche **Neuer Auslöser (Makro)**. In der Ansicht **Auslöser wählen** werden die verfügbaren Auslöser angezeigt. Dies sind Ereignisse im System, mit denen Aktionen/Makros ausgelöst werden können. In unserem Beispiel wählen wir **Anfrage bearbeitet**, sodass das Makro ausgeführt wird, wenn eine Anfrage in SuperOffice Service bearbeitet wird.
1. Geben Sie "Anfrage" in das Suchfeld ein und wählen Sie den Auslöser namens **Anfrage bearbeitet**.
1. Geben Sie eine kurze Beschreibung für den Auslöser in das Feld **Beschreibung** ein.
1. Wählen Sie **Aktiviert**.
1. Wählen Sie unten **Anfrage ändern** unter **Aktionsart auswählen**. Sie gelangen zur Registerkarte **Anfrage ändern**.
    Dies ist die erste Aktion im Makro. Es ruft die Anfrage ab, so dass die verschiedenen Werte (ID, Titel, Personenname usw.) in den nächsten Aktionen verwendet werden können.
1. Optional: Markieren Sie das Kontrollkästchen **interne Nachricht** und geben Sie zum Beispiel Folgendes ein: "Anfrage geschlossen und Bestätigung an Kunden gesendet."
1. Klicken Sie auf **Übernehmen**.
1. Klicken Sie auf **Neue Aktion** neben der Registerkarte **Anfrage ändern**.
1. Wählen Sie **Antwort-Vorlage für Zusammenführung laden**. Wir werden nun die zu verwendende Antwortvorlage abrufen.
1. Klicken Sie auf das Feld **Antwortvorlage** und wählen Sie eine bestehende Antwortvorlage aus der angezeigten Liste, z. B. "Anfrage bearbeitet".
1. Klicken Sie auf **Übernehmen**.
1. Klicken Sie auf **Neue Aktion**, und wählen Sie **E-Mail oder SMS** senden aus. Wir passen nun die E-Mail an, die an den Kunden gesendet wird.
1. Aktivieren Sie **Betreff**.
1. Klicken Sie auf <i class="ph ph-gear" aria-label="Gear"></i> auf der rechten Seite, und klicken Sie dann auf das Feld **Parameter auswählen**.
1. Wählen Sie **Anfrage ändern** > **Titel**. Dadurch wird der Anforderungstitel in den Betreff der E-Mail eingefügt.
1. Markieren Sie das Kontrollkästchen **Von** und wählen Sie **Anfrage ändern** > **Eigentümer**.
1. Markieren Sie das Kontrollkästchen **An** und wählen Sie **Anfrage ändern** > **Person: E-Mail-Adresse**.
1. Markieren Sie das Kontrollkästchen **HTML-Nachricht** und wählen Sie **Antwort-Vorlage für Zusammenführung laden** > **HTML-Text**.
1. Klicken Sie auf **Übernehmen**.

Sie haben nun ein Makro erstellt, das eine E-Mail mit "Anfrage geschlossen" an den Kunden sendet, wenn eine Anfrage geschlossen wird. Dieser Auslöser ist sofort aktiv, wenn Sie oben die Option **Aktiviert** aktiviert haben.
