---
uid: help-de-service-mailbox-create
title: Postfächer erstellen
description: Postfächer erstellen
author: digitaldiina
date: 11.27.2025
version: 11.6
keywords: E-Mail
content_type: howto
category: email
topic: Service mailbox
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: de
---

# Postfächer erstellen

Sie können ein Postfach erstellen, das zum Importieren von E-Mails in SuperOffice Service verwendet wird. Vorher müssen Sie allerdings ein Postfach auf dem E-Mail-Server erstellen, an den die E-Mails gesendet werden.

> [!NOTE]
> Stellen Sie vor dem Einrichten eines Postfachs sicher, dass sich in diesem Postfach auf dem E-Mail-Server keine alten Nachrichten befinden. Von SuperOffice Service werden alle E-Mails in das Postfach importiert. Daher besteht die Gefahr, dass automatische Antworten an alle Personen, die eine E-Mail an diese Adresse gesendet haben, erfolgen. Um diese alten E-Mails zu importieren, sollten Sie die Funktion Automatische Antwort deaktivieren. Dies betrifft vor allem die Option **automatische Antwort deaktivieren** in der Ansicht **Eigenschaften des Postfachs** und die Option **Keine E-Mail an neue Personen senden** auf der Registerkarte **Einstellungen** in der Ansicht **System** in SuperOffice Service.

## Schritte

1. [!include[Go to email](includes/goto-email.md)]

1. Klicken Sie auf **Neues Postfach**. Die Ansicht **Eigenschaften des Postfachs** wird angezeigt, wobei die Registerkarte **Eigenschaften** geöffnet ist.

1. Geben Sie in das Feld **Adresse** den Namen ohne @domain.xx ein und drücken Sie die **TAB-Taste**, um die CRM Online-Einstellungen zur E-Mail-Adresse hinzuzufügen.

    > [!NOTE]
    > Der Adresse kann eine freundliche E-Mail-Adresse hinzugefügt werden, indem ("Anzeigename") am Ende der E-Mail-Adresse hinzugefügt wird. Zum Beispiel: `info@company.com` (Customer Ltd.).

1. Wählen Sie Kategorie, Priorität, und Anfragetyp aus:

    * Wählen Sie im Listenfeld **Kategorie** aus, zu welcher Kategorie Nachrichten in diesem Postfach gehören.

    * Wählen Sie im Listenfeld **Priorität** die Priorität für Anfragen von diesem Postfach aus.

    * Wählen Sie im Listenfeld **Anfragetyp** den Typ, dem die Nachrichten in diesem Postfach angehören.

1. [!include[Set customer language](includes/step-set-language.md)]

1. Antwort bearbeiten:

    1. Aktivieren Sie das Kontrollkästchen **Nicht automatisch antworten**, um die Funktion zur automatischen Beantwortung von E-Mails zu deaktivieren. Siehe den Hinweis oben in diesem Thema.

    1. Im Feld **E-Mail-Felder** können Sie eine durch Kommas getrennte Liste mit E-Mail-Feldern (Kopfzeilen), zum Beispiel An und CC eingeben, die in der Anfragemitteilung angezeigt werden sollen.

    1. Im Listenfeld **Vorlage für Antwort an Personen** wählen Sie die Antwortvorlage für die automatische Beantwortung von Nachrichten an den Kunden aus.

    1. **FAQ-Einträge vorschlagen**: Wenn Sie diese Option aktivieren, schlägt das System die Option FAQ-Einträge anhand des Textes vorschlagen in der eingehenden E-Mail vor. Die vorgeschlagenen FAQ-Einträge stehen als Vorlagenvariablen zur Verfügung und können daher in der gewählten Antwortvorlage verwendet werden. Außerdem können Sie festlegen, welcher Teil der FAQ-Hierarchie durchsucht werden soll, indem Sie den gewünschten Ordner festlegen.

1. **Automatische Antworten und Systemmeldungen importieren**: Standardmäßig werden E-Mails, die Abwesenheitsnachrichten, Systemnachrichten und andere irrelevante Nachrichten enthalten, nicht importiert. Wenn Sie solche E-Mails importieren möchten, können Sie diese Option aktivieren.

1. **KI-Services**: Hier können Sie die folgenden Optionen für Kategorisierung und Textanalyse anhand von [KI][4] auswählen:

    * **KI Kategorien vorschlagen lassen**: Wählen Sie diese Option, damit Sie die [KI anhand des Inhalts von E-Mail-Nachrichten eine Kategorie für Anfragen vorschlagen lassen][3] können.
    * **Textanalyse verwenden:** Wählen Sie diese Option, damit Sie die [KI den Text in E-Mail-Nachrichten analysieren lassen][2] können, um die Sprache zu erkennen (für Übersetzung) und eine Stimmungsanalyse durchzuführen.

1. Klicken Sie auf **OK**. Das Postfach wird erstellt.

## Verwandte Inhalte

* [Postfächer löschen][1]
* [E-Mail in Service und Marketing][5]
* [Postfach erstellen (vor Ort)][6]

<!-- Referenced links -->
[1]: delete-mailbox.md
[2]: ../../../ai/learn/text-analysis.md
[3]: ../../../ai/learn/categorization.md
[4]: ../../../ai/learn/index.md
[5]: ../../../../en/online/mail-services/curl/index.md
[6]: https://help.superoffice.com/docs/11/de/email/admin/mailbox/create-mailbox.html
