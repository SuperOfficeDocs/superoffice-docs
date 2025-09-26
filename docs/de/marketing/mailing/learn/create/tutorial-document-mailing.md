---
uid: help-de-tutorial-document-mailing
title: Tutorial - Dokumentenkampagne
description: In diesem Tutorial erfahren Sie, wie Sie eine Dokumentkampagne erstellen.
keywords: dokumentkampagne
date: 09.26.2025
version: 10.5
content_type: tutorial
audience: person
language: de
---

# Tutorial - Dokumentenkampagne

[!include[Tipp](includes/tip-mailing-save-draft.md)]

## Schritt 1: Einstellungen

> [!TIP]
> Wenn Sie eine vorhandene Dokumentenkampagne anzeigen und drucken möchten, schließen Sie den Schritt **Setup**, indem Sie auf **Abbrechen** oder **Speichern + schließen** klicken. Wählen Sie die Registerkarte **Kampagnen**, suchen Sie das Dokument, klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabe"></i> und wählen Sie **Ansicht** an. Klicken Sie auf die Schaltfläche unter **Erstelltes Dokument herunterladen**. Das Dokument wird in Ihrem Browser heruntergeladen. Öffnen und drucken Sie das Dokument.

Mit dem Workflow für Dokumentenkampagnen können Sie ein PDF-Dokument drucken und an Ihre Kunden versenden. Der erste Schritt zum Erstellen einer Dokumentenkampagne wird als **Einstellungen** bezeichnet. Hier können Sie den Namen der Kampagne, die Überschrift und den Verteiler im Dokument sowie Archivierungsoptionen für die Kampagne einstellen.

Sie können eine Dokumentenkampagne mit einem bestimmten Projekt verknüpfen. Dies kann bei der Erstellung von Kampagnen eine Rolle spielen, bei denen die Empfänger Projektmitglieder eines SuperOffice CRM-Projekts sind. Durch die Nutzung von Vorlagenvariablen in einer Vorlage können Sie Ihrer Kampagne Projektdaten hinzufügen.

Sie können eine Dokumentenkampagne mit einem bestimmten Verkauf verknüpfen. Dies kann bei der Erstellung von Kampagnen eine Rolle spielen, bei denen die Empfänger Verkaufsbeteiligte eines SuperOffice CRM-Verkaufs sind. Durch die Nutzung von Vorlagenvariablen in einer Vorlage können Sie Ihrer Kampagne Verkaufsdaten hinzufügen.

**Schritte:**

1. Geben Sie einen Namen im Feld **Name der Kampagne** ein.

1. Geben Sie im Feld **Überschrift** die Dokumentenüberschrift ein.

1. Im Feld **Verteiler** müssen Sie auswählen, an wen die Kampagne gerichtet werden soll. Wählen Sie eine der folgenden Optionen:

    * **Wenn leer**: Wählen Sie diese Option, wenn standardmäßig die Empfängernamen verwendet werden sollen. Wenn kein Empfängername vorhanden ist, wird der Empfänger verwendet, den Sie in das Textfeld eingeben. Wenn Sie eine Kampagne erstellen, die an IT-Fachkräfte in einer Firma gerichtet ist, können Sie "IT-Abteilung" oder Ähnliches eingeben.

    * **Immer verwenden**: Wählen Sie diese Option, wenn Sie die Empfängernamen außer Acht lassen wollen und stattdessen der Empfänger verwendet werden soll, den Sie in das Textfeld eingeben.

1. Geben Sie im Feld **Unser Zeichen** den Namen ein, der im Dokument bei "Unser Zeichen" erscheinen soll. In diesem Feld können Sie [Vorlagenvariablen][1] von SuperOffice CRM verwenden.

    > [!NOTE]
    > Damit Variablen wie Verkaufs-ID oder Projekt-ID funktionieren, müssen Sie die Dokumentenkampagne mit einem Verkauf oder Dokument verknüpfen.

1. Wählen Sie einen **Order** aus, in dem Sie die Kampagne platzieren wollen.

    [Wie man einen Kampagnen-Ordner erstellt][3]

1. In den Feldern **Selektion** und **Projekt** können Sie die Kampagne einer Selektion und/oder einem Projekt zuordnen. Beginnen Sie mit der Eingabe, um zu suchen.

1. Klicken Sie auf **Weiter**, um zum nächsten Schritt zu gelangen.

## Schritt 2: Vorlage

[!include[So wählen Sie eine Vorlage aus](includes/mailing-choose-template.md)]

## Schritt 3: Inhalt

Im Schritt **Inhalt** können Sie das Erscheinungsbild und den Inhalt des Dokuments bearbeiten.

1. Klicken Sie auf die Schaltfläche **Bearbeiten**.

1. Klicken Sie im Dialogfeld auf **Dokument herunterladen**. Die Datei wird in Ihrem Browser heruntergeladen.

1. Öffnen Sie das Dokument für eine Bearbeitung. In den meisten Browsern können Sie auf die heruntergeladene Datei klicken, um sie in der Standard-Anwendung zu öffnen.

1. Bearbeiten Sie den Inhalt des Dokuments.

1. Speichern Sie das Dokument.

1. Klicken Sie gegebenenfalls in SuperOffice Marketing auf **Bearbeiten**, um das Dialogfeld erneut zu öffnen.

1. Klicken Sie auf **Datei auswählen**, wählen Sie das gespeicherte Dokument und klicken Sie auf **Ausgewählte Datei hochladen**. Die Vorschau auf der rechten Seite wird mit dem Inhalt der hochgeladenen Datei aktualisiert.

1. Klicken Sie auf **Weiter**, um zum nächsten Schritt zu gelangen.

### Vorlagenvariablen verwenden

Sie können [Vorlagenvariablen][1] von SuperOffice CRM in Ihrem Dokument verwenden, um kundenspezifische Informationen einzufügen. Dadurch geben Sie Ihrer Nachricht eine persönlichere Note.

## Schritt 4: Empfänger

[!include[Schritt 4 Empfänger](includes/step-4-recipients.md)]

## Schritt 5: Bestätigen

> [!NOTE]
> Dokumentenkampagnen werden nicht wirklich versendet, wenn Sie auf **Jetzt senden** klicken. Stattdessen wird ein PDF-Dokument erstellt, das alle Seiten für alle als Empfänger der Kampagne ausgewählten Personen/Firmen enthält. Sie können das PDF-Dokument in der Ansicht **Kampagne anzeigen** [öffnen und drucken](#pdf).

Im letzten Schritt – **Bestätigen** – können Sie sich eine Zusammenfassung der Kampagne anzeigen lassen und deren Richtigkeit überprüfen. Alle in dieser Ansicht angezeigten Fehlermeldungen müssen vor dem Senden der Kampagne beseitigt werden.

> [!NOTE]
> Die Sendeoptionen sind deaktiviert, falls noch nicht alle Schritte vollständig sind oder Informationen in der Kampagne fehlen. Diese werden in Rot angezeigt.

### Kampagne jetzt senden

Klicken Sie auf **Jetzt senden**, um ein PDF-Dokument zu erstellen. Ein PDF-Dokument wird erstellt. Der Workflow wird abgeschlossen und Sie gelangen wieder zur Registerkarte **Kampagnen**.

Klicken Sie auf die Kampagne in der Liste, um sich den [Sendestatus und Statistiken anzeigen][2] zu lassen.

### <a id="pdf"></a>Dokument öffnen und drucken

1. Wählen Sie die Registerkarte **Kampagnen** aus.
1. Suchen Sie das Dokument, klicken Sie auf <i class="ph ph-list" aria-label="Aufgabe"></i> und wählen Sie **Ansicht**.
1. Klicken Sie auf die Schaltfläche unter **Erstelltes Dokument herunterladen**. Das Dokument wird in Ihrem Browser heruntergeladen.
1. Öffnen und drucken Sie das Dokument.

<!-- Referenced links -->
[2]: ../view-statistics.md
[1]: ../../../editor/learn/index.md#variables
[3]: ../../../learn/create-folder.md
