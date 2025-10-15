---
uid: help-de-ai-categorization-setup
title: AI-basierte Kategorisierung einrichten
description: So trainieren und konfigurieren Sie die Kategorisierung in SuperOffice AI
keywords: AI, Kategorisierung, maschinelles Lernen, Training
author: digitaldiina
date: 10.15.2025
version: 11.5
content_type: howto
license: aiplatform, categorization
category: automation
topic: ai
deployment: online
platform: web
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from: /de/ai/admin/index
---

# AI-basierte Kategorisierung einrichten

Die Kategorisierung nutzt maschinelles Lernen, um Kategorien für eingehende Anfragen basierend auf ihrem Inhalt vorzuschlagen. Bevor diese Funktion verwendet werden kann, muss die AI mit einer Selektion bestehender Anfragen trainiert werden.

> [!NOTE]
> Die Kategorisierung erfordert die SuperOffice AI Platform und eine **Categorization-Lizenz**. SuperOffice AI ist nur für CRM Online verfügbar.

## 1. Eine Selektion von Anfragen erstellen

Sie müssen zunächst eine Selektion von Anfragen in SuperOffice erstellen, um das AI-Modell zu trainieren.

1. Klicken Sie auf <i class="ph ph-list-magnifying-glass" aria-label="Suchen-Symbol"></i> **Suchen** oder gehen Sie zu **Neu** > **Selektion**.

    ![Neue Selektionsoptionen im Sales-Client -screenshot][img1]

1. Wählen Sie **Anfrage** als Selektionstyp. Verwenden Sie **Anfrage suchen** oder wählen Sie aus **Typische Suchen**.

    ![Typische Suchen für Anfrageselektion -screenshot][img2]

1. Suchkriterien definieren:
    1. Fügen Sie Filter hinzu, um die Anfragen zu finden, die Sie für das Training verwenden möchten.
    2. Klicken Sie auf **Suchen**.

    ![Kriterien für Anfrageselektion -screenshot][img3]

1. Die Selektion speichern:
    1. Klicken Sie auf **Als Selektion speichern**.
    2. Wählen Sie statisch oder dynamisch.
    3. Geben Sie einen Namen ein und klicken Sie auf **Speichern**.

    ![Selektionstyp auswählen -screenshot][img4]
    ![Selektionsname eingeben -screenshot][img5]

> [!NOTE]
> Nur die ersten 5000 Anfragen in der Selektion werden analysiert.

## 2. Die Selektion in Einstellungen und Verwaltung auswählen

1. Öffnen Sie **Einstellungen und Verwaltung**.
1. Wählen Sie **AI-Dienste** aus dem Navigator.
1. Unter **Kategorisierung** öffnen Sie das Dropdown-Menü und suchen Sie nach dem Selektionsnamen.
1. Wählen Sie die korrekte Anfrageselektion.

    ![Anfrageselektion in AI-Diensten auswählen -screenshot][img6]

## 3. Die Anfrageselektion analysieren

Sobald eine gültige Selektion gewählt ist, wird die Schaltfläche **Anfragen analysieren** aktiv.

> [!NOTE]
> Große Datensätze können Stunden oder sogar Tage zur Analyse benötigen.

1. Klicken Sie auf **Anfragen analysieren**, um den Trainingsprozess zu starten.
1. Wenn das Training abgeschlossen ist, zeigt der Status **Letztes Training** *Modell erfolgreich trainiert* an.
1. Falls Fehler auftreten, überprüfen Sie die Nachricht und erstellen Sie bei Bedarf eine neue Selektion.

    ![Trainingsergebnisse und Feedback -screenshot][img7]
    ![Beispiele für Trainingszusammenfassung -screenshot][img8]

## 4. Vorschläge aktivieren

Nach erfolgreichem Training:

1. Aktivieren Sie das Kontrollkästchen **AI verwenden, um Kategorien vorzuschlagen**, um die Funktion zu aktivieren.

    ![Kontrollkästchen zum Aktivieren von AI-Vorschlägen -screenshot][img9]

## 5. Ergebnis: Kategorievorschläge in Anfragen

Wenn aktiviert, sehen Benutzer einen vorgeschlagenen Kategorie in der Anfragefußzeile. Durch Klicken auf den Link wird die Kategorie auf die Anfrage angewendet und der Vorschlag entfernt.

Wenn es keine Übereinstimmung gibt, wird kein Vorschlag angezeigt.

## Neu trainieren oder Selektion ändern

Sie können jederzeit eine neue oder aktualisierte Selektion erneut analysieren:

1. Gehen Sie zu **Einstellungen und Verwaltung** > **AI-Dienste**.
1. Unter **Kategorisierung** wählen Sie eine neue Selektion.
1. Klicken Sie auf **Anfragen analysieren**, um erneut zu trainieren.

## Verwandter Inhalt

* [Wie man eine Selektion erstellt][1]
* [Anfragenkategorisierung][2]
* [Andere AI-Dienste][3]

<!-- Referenced links -->
[1]: ../../search-options/selection/learn/create.md
[2]: ../learn/categorization.md
[3]: ../learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/choose-new-selection.png
[img2]: ../../../media/loc/en/search-options/typical-request-searches.png
[img3]: ../../../media/loc/en/ai/find-request-search-criteria.png
[img4]: ../../../media/loc/en/ai/select-selection-type-dialog.png
[img5]: ../../../media/loc/en/ai/name-selection-input.png
[img6]: ../../../media/loc/en/ai/select-category-menu.png
[img7]: ../../../media/loc/en/ai/categorization-analysis.png
[img8]: ../../../media/loc/en/ai/categorization-summary.png
[img9]: ../../../media/loc/en/ai/use-ai-suggested-categories-checkbox.png
