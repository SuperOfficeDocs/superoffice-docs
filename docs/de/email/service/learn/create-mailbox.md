---
uid: help-de-service-mailbox-create
title: Postfächer erstellen
description: Postfächer erstellen
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: E-Mail
so.topic: howto
language: de
---

# Postfächer erstellen

Sie können ein Postfach erstellen, das zum Importieren von E-Mails in SuperOffice Service verwendet wird. Vorher müssen Sie allerdings ein Postfach auf dem E-Mail-Server erstellen, an den die E-Mails gesendet werden.

> [!NOTE]
> Stellen Sie vor dem Einrichten eines Postfachs sicher, dass sich in diesem Postfach auf dem E-Mail-Server keine alten Nachrichten befinden. Von SuperOffice Service werden alle E-Mails in das Postfach importiert. Daher besteht die Gefahr, dass automatische Antworten an alle Personen, die eine E-Mail an diese Adresse gesendet haben, erfolgen. Um diese alten E-Mails zu importieren, sollten Sie die Funktion Automatische Antwort deaktivieren. Dies betrifft vor allem die Option **automatische Antwort deaktivieren** in der Ansicht **Eigenschaften des Postfachs** und die Option **Keine E-Mail an neue Personen senden** auf der Registerkarte **Einstellungen** in der Ansicht **System** in SuperOffice Service.

## Wie man neues Postfach erstellt - online

1. [!include[Go to email](includes/goto-email.md)]

1. Klicken Sie auf **Neues Postfach**. Die Ansicht **Eigenschaften des Postfachs** wird angezeigt, wobei die Registerkarte **Eigenschaften** geöffnet ist.

1. Geben Sie in das Feld **Adresse** den Namen ohne @domain.xx ein und drücken Sie die **TAB-Taste**, um die CRM Online-Einstellungen zur E-Mail-Adresse hinzuzufügen.

    > [!NOTE]
    > Der Adresse kann eine freundliche E-Mail-Adresse hinzugefügt werden, indem ("Anzeigename") am Ende der E-Mail-Adresse hinzugefügt wird. Zum Beispiel: <info@company.com> (Customer Ltd.).

1. Wählen Sie Kategorie, Priorität, und Anfragetyp aus:

    [!include[Select category and priority](includes/step-select-category-priority.md)]

1. [!include[Set customer language](includes/step-set-language.md)]

1. Antwort bearbeiten:

    [!include[Common steps](includes/step-set-reply.md)]

1. [!include[Import stuff](includes/step-import.md)]

1. **KI-Services**: Hier können Sie die folgenden Optionen für Kategorisierung und Textanalyse anhand von [KI][4] auswählen:

    * **KI Kategorien vorschlagen lassen**: Wählen Sie diese Option, damit Sie die [KI anhand des Inhalts von E-Mail-Nachrichten eine Kategorie für Anfragen vorschlagen lassen][3] können.
    * **Textanalyse verwenden:** Wählen Sie diese Option, damit Sie die [KI den Text in E-Mail-Nachrichten analysieren lassen][2] können, um die Sprache zu erkennen (für Übersetzung) und eine Stimmungsanalyse durchzuführen.

1. Klicken Sie auf **OK**. Das Postfach wird erstellt.

## Wie man ein neues Postfach erstellt - onsite

1. [!include[Go to email](includes/goto-email.md)]

1. Klicken Sie auf **Neues Postfach**. Die Ansicht **Eigenschaften des Postfachs** wird angezeigt, wobei die Registerkarte **Eigenschaften** geöffnet ist.

1. Geben Sie im Feld **Adresse** die E-Mail-Adresse ein, die Sie für das Postfach verwenden möchten.

    > [!NOTE]
    > Richten Sie die Weiterleitung an diese Postfachadresse ein, wenn Sie die E-Mail-Adresse Ihrer Firma (zum Beispiel <info@company.com>) verwenden möchten. Verwenden Sie **Weiterleitungsadresse** in der Ansicht **Postfächer**.

1. Wählen Sie im Listenfeld **Protokoll** das Protokoll für die Kommunikation mit dem E-Mail-Server aus. Für einige Protokolle sind ggf. weitere Konfigurationsschritte erforderlich.

1. Geben Sie in das Feld **E-Mail-Server** den Hostnamen des Servers ein.

1. Geben Sie in die Felder **Benutzername** und **Kennwort** den Benutzernamen und das Kennwort für das Postfach ein.

1. Geben Sie in das Feld **Ordner** den Ordnernamen für das Postfach auf dem Server ein.

1. Im Feld **Port** können Sie den vorgeschlagenen Standardport für das ausgewählte Protokoll ändern.

1. Wählen Sie Kategorie, Priorität, und Anfragetyp aus:

    [!include[Select category and priority](includes/step-select-category-priority.md)]

1. Wählen Sie im Listenfeld **Intervall** aus, wie häufig SuperOffice Service prüfen soll, ob Nachrichten in diesem Postfach vorhanden sind.

1. [!include[Set customer language](includes/step-set-language.md)]

1. Antwort bearbeiten:

    [!include[Common steps](includes/step-set-reply.md)]

1. Wechseln Sie zur Registerkarte **Alias**. Hier können Sie einen beliebigen E-Mail-Alias für ein Postfach eingeben (zum Beispiel, gehen Sei zum selben Postfach, wenn <sales@company.com> und <sale@company.com>). Um einen Alias hinzuzufügen, müssen Sie eine E-Mail-Adresse angeben und anschließend auf ![Symbol][img1] klicken.

1. [!include[Import stuff](includes/step-import.md)]

1. Klicken Sie auf **OK**. Das Postfach wird erstellt.

## Was möchten Sie jetzt tun?

* [Postfächer löschen][1]

<!-- Referenced links -->
[1]: delete-mailbox.md
[2]: ../../../ai/learn/text-analysis.md
[3]: ../../../ai/learn/categorization.md
[4]: ../../../ai/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-add.png
