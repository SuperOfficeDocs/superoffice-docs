---
uid: help-de-tutorial-form-mailing
title: Tutorial - Formularantwort-Kampagne
description: In diesem Tutorial erfahren Sie, wie Sie eine Formularantwort erstellen.
keywords: formularantwort, kampagne
date: 06.27.2025
version: 10.5
content_type: tutorial
audience: person
language: de
---

# Tutorial - Formularantwort-Kampagne

[!include[Tipp](includes/tip-mailing-save-draft.md)]

## Schritt 1: Einstellungen

Der erste Schritt zum Erstellen einer Formularantwort wird als **Einstellungen** bezeichnet. Hier können Sie Informationen zur E-Mail-Kopfzeile einstellen, z. B. Absender, Antwort an und Betreff. Darüber hinaus können Sie Anlagen und Archivierungsoptionen für die Kampagne hinzufügen und Überwachungsoptionen wählen.

1. Geben Sie einen Namen im Feld **Name der Kampagne** ein.

1. Geben Sie den Betreff der E-Mail im Feld **E-Mail-Betreff** ein.

1. Wählen Sie in der Liste **Von** **Immer verwenden** und geben Sie die E-Mail-Adresse des Absenders in das darunter liegende Feld ein, um für alle Kampagnen den gleichen Absender zu verwenden. Sie können auch einen Vertriebs-Ansprechpartner oder einen Verantwortlichen für den Benutzersupport als Absender angeben, falls einer für diesen Empfänger festgelegt ist. Geben Sie die E-Mail-Adresse ein, die verwendet werden soll, wenn keine für Vertrieb oder Benutzersupport verantwortliche Person verfügbar ist. Wenn Ihr Administrator die [globale E-Mail-Validierungseinstellung][1] aktiviert hat, müssen Sie in der Dropdown-Liste die Domäne auswählen, von der Sie senden möchten. Geben Sie anderenfalls die Adresse und Domäne ein, von der Sie senden möchten.

    [!include[Note](includes/spf-look-up.md)]

1. In der Liste **Antwort an** haben Sie die gleichen Optionen wie oben. Zusätzlich dazu können Sie **"Von" als Antwortadresse verwenden** auswählen. Sämtliche Antworten werden dann an den Absender gesendet.

1. Wählen Sie einen **Order** aus, in dem Sie die Kampagne platzieren wollen.

    [Wie man einen Kampagnen-Ordner erstellt][2]

1. In den Feldern **Selektion** und **Projekt** können Sie die Kampagne einer Selektion und/oder einem Projekt zuordnen. Nehmen Sie zuerst eine Eingabe in den Feldern vor, um zu suchen.

    Wenn Sie eine Selektion hinzufügen, werden alle Personen aus der Selektion als Empfänger zur Kampagne hinzugefügt.

1. **Anlagen**: Wählen Sie eine der folgenden Methoden, um der Kampagne eine oder mehrere Anlagen hinzuzufügen:

    * Klicken Sie auf **Dateien hochladen (oder hierhin ziehen und ablegen)**, um eine Datei auf einer Festplatte oder einem Server zu suchen und hinzuzufügen.
    * Ziehen Sie das Dokument aus dem Windows Explorer in das Feld Anlagen und legen Sie es dort ab.
    * Klicken Sie auf **Ein CRM-Dokument auswählen**, um ein Dokument in SuperOffice CRM auszuwählen.

1. Unter **Überwachen** finden Sie die folgenden Optionen:

    [!include[Tracking options for mailing](includes/mailing-tracking-options.md)]

1. Klicken Sie auf **Weiter**, um zum nächsten Schritt zu gelangen.

## Schritt 2: Vorlage

[!include[So wählen Sie eine Vorlage aus](includes/mailing-choose-template.md)]

## Schritt 3: Inhalt

[!include[Schritt 3 E-Mail](includes/step-3-content-email.md)]

<!-- Referenced links -->
[1]: ../../../../admin/lists/learn/add-items-to-mailing-domain.md
[2]: ../../../learn/create-folder.md
