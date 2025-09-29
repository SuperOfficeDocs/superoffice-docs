---
uid: help-de-tutorial-email-mailing
title: Tutorial - E-Mail-Kampagne
description: Wenn Sie die notwendigen Vorbereitungen getroffen haben, einschließlich der Erstellung Ihrer Zielliste und der Vorbereitung Ihrer Kampagnevorlage, können Sie eine neue Kampagne in SuperOffice CRM erstellen. In diesem Tutorial erfahren Sie, wie Sie eine E-Mail-Kampagne erstellen.
keywords: e-mail-kampagne
date: 09.26.2025
version: 10.5
content_type: tutorial
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: de
---

# Tutorial - E-Mail-Kampagne

[!include[Tipp](includes/tip-mailing-save-draft.md)]

## Schritt 1: Einstellungen

Sie können Ihre neue Kampagne im Bild Marketing in der Registerkarte Kampagnen erstellen. Klicken Sie auf "Kampagne erstellen" und Sie gelangen zum ersten Schritt, in dem Sie Ihre Kampagne einstellen können.

Der erste Schritt beim Erstellen einer E-Mail-Kampagne wird als **Setup** bezeichnet. Hier können Sie Informationen zur E-Mail-Kopfzeile einstellen, z. B. Absender, Antwort an und Betreff. Darüber hinaus können Sie Anlagen und Archivierungsoptionen für die Kampagne hinzufügen und Überwachungsoptionen wählen.

1. Geben Sie einen Namen im Feld **Name der Kampagne** ein.

1. Geben Sie den Betreff der E-Mail im Feld **E-Mail-Betreff** ein.

1. Wählen Sie in der Liste **Von** **Immer verwenden** und geben Sie die E-Mail-Adresse des Absenders in das darunter liegende Feld ein, um für alle Kampagnen den gleichen Absender zu verwenden. Sie können auch einen Vertriebs-Ansprechpartner oder einen Verantwortlichen für den Benutzersupport als Absender angeben, falls einer für diesen Empfänger festgelegt ist. Geben Sie die E-Mail-Adresse ein, die verwendet werden soll, wenn keine für Vertrieb oder Benutzersupport verantwortliche Person verfügbar ist. Wenn Ihr Administrator die [globale E-Mail-Validierungseinstellung][2] aktiviert hat, müssen Sie in der Dropdown-Liste die Domäne auswählen, von der Sie senden möchten.

    [!include[Note](includes/spf-look-up.md)]

1. In der Liste **Antwort an** haben Sie die gleichen Optionen wie oben. Zusätzlich dazu können Sie **"Von" als Antwortadresse verwenden** auswählen. Sämtliche Antworten werden dann an den Absender gesendet.

1. Wählen Sie einen **Order** aus, in dem Sie die Kampagne platzieren wollen.

    [Wie man einen Kampagnen-Ordner erstellt][4]

1. In den Feldern **Selektion** und **Projekt** können Sie die Kampagne einer Selektion und/oder einem Projekt zuordnen. Beginnen Sie mit der Eingabe, um zu suchen.

    Wenn Sie eine Selektion hinzufügen, werden alle Personen aus der Selektion als Empfänger zur Kampagne hinzugefügt.

1. Wählen Sie in der Liste **Typ** den Typ der Kampagne aus, die Sie erstellen. Wählen Sie **(Beliebig)**, wenn die Kampagne zwei oder mehr der verfügbaren Typen entspricht. Verwenden Sie **Alle**, nachdem Sie mehrere Empfänger mit mehreren Abonnements hinzugefügt haben und die Kampagne an alle gesendet werden soll.

1. **Anlagen**: Wählen Sie eine der folgenden Methoden, um der Kampagne eine oder mehrere Anlagen hinzuzufügen:

    * Klicken Sie auf **Dateien hochladen (oder hierhin ziehen und ablegen)**, um eine Datei auf einer Festplatte oder einem Server zu suchen und hinzuzufügen.
    * Ziehen Sie das Dokument aus dem Windows Explorer in das Feld Anlagen und legen Sie es dort ab.
    * Klicken Sie auf **Ein CRM-Dokument auswählen**, um ein Dokument in SuperOffice CRM auszuwählen.

1. Unter **Überwachen** finden Sie die folgenden Optionen:

    [!include[Tracking options for mailing](includes/mailing-tracking-options.md)]

1. Klicken Sie auf **Weiter**, um zum nächsten Schritt zu gelangen.

### E-Mail-Domäne-Validierung (NUR ONLINE)

Wenn Ihr Administrator die [globale Einstellung][2] **Nur genehmigte E-Mail-Domänen verwenden** aktiviert hat, wird das Feld **Von Adresse** aufgeteilt, und Sie müssen die Domäne, von der Sie senden möchten, in der Dropdown-Liste der genehmigten Domänen auswählen.
Wenn Sie versuchen, von einer Domain zu senden, die keinen gültigen SPF-Eintrag hat, wird eine Warnung ausgegeben und die Sendung von dieser Domäne ist nicht möglich. Dies gilt für alle E-Mail-Domäne, auch wenn die Validierungseinstellung nicht aktiviert ist.

> [!NOTE]
> Wenn die **Unsere Kontaktadresse**eine nicht validierte E-Mail-Domäne hat, wird die Kampagne automatisch von der Adresse gesendet, die in den Optionen der Dropdown-Liste **Andernfalls verwenden** angegeben ist.

## Schritt 2: Vorlage

[!include[So wählen Sie eine Vorlage aus](includes/mailing-choose-template.md)]

## Schritt 3: Inhalt

[!include[Schritt 3 E-Mail](includes/step-3-content-email.md)]

## Schritt 4: Empfänger

[!include[Schritt 4 Empfänger](includes/step-4-recipients.md)]

## Schritt 5: Bestätigen

[!include[So bestätigen und versenden Sie eine Kampagne](includes/step-5-confirm-and-send-mailing.md)]

<!-- Referenced links -->
[2]: ../../../../admin/lists/learn/add-items-to-mailing-domain.md
[4]: ../../../learn/create-folder.md
