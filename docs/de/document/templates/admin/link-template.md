---
uid: help-de-document-template-link
title: Eine Dokumentvorlage hinzufügen
description: In dieser Anleitung lernen Sie, wie Sie eine neue Dokumentvorlage zu SuperOffice CRM hinzufügen.
keywords: Dokument, Vorlage, Listen
author: Bergfrid Dias
date: 07.12.2024
version: 10
topic: howto
language: de
audience: settings
audience_tooltip: Settings and maintenance
---

# Eine Dokumentvorlage hinzufügen

Wenn Sie neue Vorlagen erstellen oder eine Standardvorlage ändern und unter einem anderen Dateinamen speichern, müssen Sie die Vorlagen mit SuperOffice CRM verknüpfen, damit das Programm diese finden kann, wenn Sie in SuperOffice CRM Dokumente schreiben.

Vorlagen werden in der Liste **Dokument - Vorlage** als Objekte angezeigt. Sie können also eine Vorlage mit SuperOffice CRM verknüpfen, indem Sie sie als Objekt in diese Liste eingeben.

Sehen Sie sich dieses Video an oder befolgen Sie die folgenden Schritte mit Leitfaden, um zu lernen, wie Sie eine Dokumentvorlage hinzufügen können:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/FnhcmjP-TgE]

(Videolänge - 2:30)

## Schritte

1. In Einstellungen und Verwaltung, klicken Sie im Navigator auf die Schaltfläche **Listen** (1).

1. Wählen Sie **Objekte**, klicken Sie auf den Pfeil und wählen Sie **Dokument - Vorlage** (2).

1. Klicken Sie auf **Hinzufügen** (3).

    ![Dokumentvorlage hinzufügen -screenshot][img3]

1. Geben Sie den gewünschten Namen für das Objekt in das Feld **Name** ein (1).

    ![Listenobjekt bearbeiten -screenshot ][img2]

1. In der Liste **Vorlage speichern in** können Sie angeben, wo die Dokumentvorlage gespeichert werden soll (2).

1. Hier haben Sie zwei Möglichkeiten:

    * Eine neue Dokumentvorlage hochladen:

        1. Klicken Sie auf **Eine bereits vorhandene Dokumentvorlagendatei kopieren**.
        2. Klicken Sie auf die Liste **Vorlage kopieren**.
        3. Wählen Sie die gewünschte Vorlage in der Liste aus.

    * Eine bereits vorhandene Vorlage in SuperOffice kopieren:

        1. Wählen Sie **Neue Dokumentvorlage von Datenträger hochladen** (3).
        2. Klicken Sie auf die Schaltfläche **Hochladen**.
        3. Klicken Sie auf **Datei hochladen** im Dialogfeld **Datei hochladen**.
        4. Wählen Sie die gewünschte Datei aus und klicken Sie auf **Öffnen**. Der Name der Datei wird im Dialogfeld **Listenobjekt bearbeiten** angezeigt.

1. Klicken Sie im Dialogfeld **Listenobjekt bearbeiten** auf **Speichern**. Das Dialogfeld ist aktualisiert.

1. Optional: Bearbeiten Sie, falls nötig, den Vorlagennamen und klicken Sie auf **Bearbeiten**, um die Vorlagendatei zu ändern.

1. Geben Sie die erforderlichen Informationen in die Registerkarten **Details** und **Sprachen** ein.

1. Klicken Sie auf **Speichern**. Die Vorlage wird als separates Objekt zur Liste **Objekte** hinzugefügt und ist jetzt im CRM-Client verfügbar:

![New document -screenshot][img4]

![New document dialog -screenshot][img5]

> [!TIP]
> Wiederholen Sie diesen Vorgang, wenn Sie weitere Vorlagen hinzufügen möchten.

## Registerkarte Details

Geben Sie die folgenden Informationen in die Registerkarte **Details** ein:

1. Legen Sie im Feld **Richtung** fest, ob die Vorlage eingehend oder ausgehend ist, indem Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i> klicken und im Listenfeld eine Option auswählen.

2. Wählen Sie im Feld **Dokumenttyp** entweder **Dokument** oder **Fax** als Vorlagentyp aus.

3. Im Feld **Dokument gespeichert unter** können Sie einen von der Standardoption abweichenden Speicherort angeben.

4. Klicken Sie im Feld **Zweck** auf <i class="ph ph-caret-down" aria-label="Chevron"></i> und wählen Sie eine der vordefinierten Optionen aus der Liste aus. Diese Objekte gehören zur Statuskontrollfunktion (für die eine [Sales Intelligence][4]-Lizenz erforderlich ist).

    > [!TIP]
    > Zusätzlich zu den vordefinierten Optionen können Sie neue Optionen erstellen, indem Sie sie zur Liste **Folgeaufgabe - Zweck** in Einstellungen und Verwaltung hinzufügen.

5. Vor Ort: Aktivieren Sie die Option **Veröffentlichen**, damit Sie im Dialogfeld Dokument festlegen können, dass die betreffende Dokumentvorlage für externe Benutzer verfügbar sein soll.

6. Vor Ort: Aktivieren Sie die Option **In Datenbank speichern**, wenn mit dieser Vorlage erstellte Dokumente in der Dokumentdatenbank gespeichert werden sollen. Wenn Sie diese Option aktivieren, wird das Dokument auf der Bereichsregisterkarte **Aktivitäten** in SuperOffice CRM angezeigt. Andernfalls wird das Dokument nach der Erstellung nicht in SuperOffice CRM angezeigt, und Sie können vom Programm aus nicht darauf zugreifen.

7. Aktivieren Sie die Option **Typ des Angebotsdokuments**, (4) wenn das Dokument als [Angebotsvorlage][2] oder Auftragsbestätigungsvorlage verfügbar sein sollte. Den gewünschten Typ des Angebotsdokuments wählen Sie in der Liste unten aus.

    ![Listenobjekt bearbeiten -screenshot][img8]

8. Geben Sie eine Standardeinstellung in das Feld **Unser Zeichen (Standard)** ein, indem Sie Vorlagenvariablen verwenden, z. B. *verf* für den Vor- und Nachnamen des Absenders, oder {oref}.

9. Geben Sie optional in das Feld Beschreibung eine **Beschreibung** für die Vorlage ein.

    > [!TIP]
    > Sie können die Vorlage direkt im Dialogfeld **Listenobjekt bearbeiten** öffnen und bearbeiten, indem Sie auf die Schaltfläche **Bearbeiten** klicken.

## Registerkarte Sprachen

Hier können Sie übersetzte Versionen der Dokumentvorlage hinzufügen.

1. Klicken Sie auf **Hinzufügen**.

    ![Sprache hinzufügen -screenshot][img6]

1. Wählen Sie im Dialogfeld **Listenobjekt bearbeiten** die gewünschte Sprache in der Liste **Sprache hinzufügen** aus.

1. Fügen Sie eine übersetzte Dokumentvorlage hinzu, wie oben beschrieben.

    ![Übersetzte Dokumentvorlage -screenshot][img7]

1. Klicken Sie auf **Hinzufügen**. Die Sprache ist in der Registerkarte **Sprachen** aufgeführt.

1. Gehen Sie wie in den Schritten oben erläutert vor, um weitere Sprachen hinzuzufügen.

## Verwandt

* [Vorhandene Vorlage ersetzen][1]

<!-- Referenced links -->
[1]: update-template.md
[2]: ../learn/quote-templates.md
[4]: ../../../saint/learn/index.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/document/edit-list-item.png
[img3]: ../../../../media/loc/en/document/lists-add.png
[img4]: ../../../../media/loc/en/document/imagedmnmi.png
[img5]: ../../../../media/loc/en/document/image6r9sc.png
[img6]: ../../../../media/loc/en/document/language-add.png
[img7]: ../../../../media/loc/en/document/deutch-document-upload.png
[img8]: ../../../../media/loc/en/document/reference-item.png
