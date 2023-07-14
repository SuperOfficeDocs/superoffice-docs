---
uid: help-de-add-template
title: Vorlage hinzufügen
description: "In dieser Anleitung lernen Sie, wie Sie eine neue Dokumentvorlage zu SuperOffice CRM hinzufügen."
author: SuperOffice RnD
so.date: 03.24.2023
keywords: Dokument, Vorlage
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: de
---

# Eine Dokumentvorlage hinzufügen

Um sicherzustellen, dass alle in Ihrer Firma die gleichen Dokumente verwenden, können Sie Ihre eigenen Dokumentvorlagen für verschiedene Dateitypen erstellen und hinzufügen. Verwenden Sie die verfügbaren Vorlagenvariablen, um die Eingabe von Kundeninformationen in Ihre Dokumente zu personalisieren und zu automatisieren.

Wenn Sie neue Vorlagen erstellen oder eine Standardvorlage ändern und unter einem anderen Dateinamen speichern, müssen Sie die Vorlagen mit SuperOffice CRM verknüpfen, damit das Programm diese finden kann, wenn Sie in SuperOffice CRM Dokumente schreiben. Nachdem Sie die Vorlage verknüpft haben, können Sie mühelos Briefe, Faxe und andere Dokumente, für die Sie Vorlagen erstellt haben, mit der [Funktion Dokument in SuperOffice CRM][5] schreiben.

Sehen Sie sich dieses Video an oder befolgen Sie die folgenden Schritte mit Leitfaden, um zu lernen, wie Sie eine Dokumentvorlage hinzufügen können (Videolänge - 2:30):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/FnhcmjP-TgE]

## Schritte

> [!TIP]
> Um neue Vorlagen hinzuzufügen, können Sie ganz einfach vorhandene Dokumentvorlagen kopieren und bearbeiten, um sie an Ihre Bedürfnisse anzupassen.

Vorlagen werden in der Liste **Dokument - Vorlage** als Objekte angezeigt. Sie können also eine Vorlage mit SuperOffice CRM verknüpfen, indem Sie sie als Objekt in diese Liste eingeben.

[!include[Edit list item](includes/edit-list-item.md)] wenn die Objekte Dokumentvorlagen sind:

1. Geben Sie den gewünschten Namen für das Objekt in das Feld **Name** ein.
2. In der Liste **Vorlage speichern in** können Sie angeben, wo die Dokumentvorlage gespeichert werden soll.
3. Hier haben Sie zwei Möglichkeiten:

    * Eine neue Dokumentvorlage hochladen:

        1. Klicken Sie auf **Eine bereits vorhandene Dokumentvorlagendatei kopieren**.
        2. Klicken Sie auf die Liste **Vorlage kopieren**.
        3. Wählen Sie die gewünschte Vorlage in der Liste aus.

    * Eine bereits vorhandene Vorlage in SuperOffice kopieren:

        1. Wählen Sie **Neue Dokumentvorlage von Datenträger hochladen**.
        2. Klicken Sie auf die Schaltfläche **Hochladen**.
        3. Klicken Sie auf **Datei hochladen** im Dialogfeld **Datei hochladen**.
        4. Wählen Sie die gewünschte Datei aus und klicken Sie auf **Öffnen**. Der Name der Datei wird im Dialogfeld **Listenobjekt bearbeiten** angezeigt.

4. Klicken Sie im Dialogfeld **Listenobjekt bearbeiten** auf **Speichern**. Das Dialogfeld ist aktualisiert.
5. Optional: Bearbeiten Sie, falls nötig, den Vorlagennamen und klicken Sie auf **Bearbeiten**, um die Vorlagendatei zu ändern.
6. Geben Sie die erforderlichen Informationen in die Registerkarten **Details** und **Sprachen** ein.
7. Klicken Sie auf **Speichern**. Die Vorlage wird als separates Objekt zur Liste **Objekte** hinzugefügt. Wiederholen Sie diesen Vorgang, wenn Sie weitere Vorlagen hinzufügen möchten.

## Registerkarte Details

Geben Sie die folgenden Informationen in die Registerkarte **Details** ein:

1. Legen Sie im Feld **Richtung** fest, ob die Vorlage eingehend oder ausgehend ist, indem Sie auf den Pfeil ![Symbol][img1]  klicken und im Listenfeld eine Option auswählen.

2. Wählen Sie im Feld **Dokumenttyp** entweder **Dokument** oder **Fax** als Vorlagentyp aus.

3. Im Feld **Dokument gespeichert unter** können Sie einen von der Standardoption abweichenden Speicherort angeben.

4. Klicken Sie im Feld **Zweck** auf das ![Symbol][img1] und wählen Sie eine der vordefinierten Optionen aus der Liste aus. Diese Objekte gehören zur Statuskontrollfunktion (für die eine [Sales Intelligence][4]-Lizenz erforderlich ist).

    > [!TIP]
    >Zusätzlich zu den vordefinierten Optionen können Sie neue Optionen erstellen, indem Sie sie zur Liste **Folgeaufgabe - Zweck** in Einstellungen und Verwaltung hinzufügen.

5. Vor Ort: Aktivieren Sie die Option **Veröffentlichen**, damit Sie in der Ansicht Dokument festlegen können, dass die betreffende Dokumentvorlage für externe Benutzer verfügbar sein soll.

6. Vor Ort: Aktivieren Sie die Option **In Datenbank speichern**, wenn mit dieser Vorlage erstellte Dokumente in der Dokumentdatenbank gespeichert werden sollen. Wenn Sie diese Option aktivieren, wird das Dokument auf der Bereichsregisterkarte **Aktivitäten** in SuperOffice CRM angezeigt. Andernfalls wird das Dokument nach der Erstellung nicht in SuperOffice CRM angezeigt, und Sie können vom Programm aus nicht darauf zugreifen.

7. Aktivieren Sie die Option **Typ des Angebotsdokuments**, wenn das Dokument als Angebotsvorlage oder Auftragsbestätigungsvorlage verfügbar sein sollte. Den gewünschten Typ des Angebotsdokuments wählen Sie in der Liste unten aus.

    [!include[Link to quote template docs](includes/learn-quote-templates.md)]

8. Geben Sie eine Standardeinstellung in das Feld **Unser Zeichen (Standard)** ein, indem Sie [Vorlagenvariablen][2] verwenden, z. B. *verf* für den Vor- und Nachnamen des Absenders.

9. Geben Sie optional in das Feld Beschreibung eine **Beschreibung** für die Vorlage ein.

    > [!TIP]
    > Sie können die Vorlage direkt im Dialogfeld **Listenobjekt bearbeiten** öffnen und bearbeiten, indem Sie auf die Schaltfläche **Bearbeiten** klicken.

## Registerkarte Sprachen

Hier können Sie übersetzte Versionen der Dokumentvorlage hinzufügen.

1. Klicken Sie auf **Hinzufügen**.
2. Wählen Sie im Dialogfeld **Listenobjekt bearbeiten** die gewünschte Sprache in der Liste **Sprache hinzufügen** aus.
3. Fügen Sie eine übersetzte Dokumentvorlage hinzu, wie oben beschrieben.
4. Klicken Sie auf **Hinzufügen**. Die Sprache ist in der Registerkarte **Sprachen** aufgeführt.
5. Gehen Sie wie in den Schritten oben erläutert vor, um weitere Sprachen hinzuzufügen.

## Verwandt

* [Wie lade ich Dokumentvorlagen hoch und verwende sie?][3] - FAQ
* [Vorhandene Vorlage ersetzen][1]

<!-- Referenced links -->
[2]: ../../../document/learn/template-variables.md
[5]: ../../../document/learn/index.md
[1]: replace-existing-template.md
[4]: ../../../sale/saint/learn/index.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-upload-and-use-document-templates-in-superoffice-crm/

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-down.png
