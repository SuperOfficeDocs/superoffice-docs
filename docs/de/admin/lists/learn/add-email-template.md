---
uid: help-de-add-email-template
title: E-Mail-Vorlage hinzufügen
description: E-Mail-Vorlage hinzufügen
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen und Verwaltung
topic: help
language: de
---

# E-Mail-Vorlage hinzufügen

E-Mail-Vorlagen können zum Erstellen neuer E-Mails in SuperOffice E-Mail und zum Senden von Angeboten, Auftragsbestätigungen und Datenschutzbestätigungen verwendet werden.

Vorlagen werden in der Liste **E-Mail-Vorlage** als Objekte angezeigt. Sie können neue Vorlagen mit SuperOffice CRM hinzufügen, indem Sie sie als Objekt in diese Liste eingeben.

[!include[Edit list item](includes/edit-list-item.md)] wenn die Objekte E-Mail-Vorlagen sind:

1. Geben Sie den gewünschten Namen für das Objekt in das Feld **Vorlagenname** ein.

2. Wählen Sie im Feld **Vorlagentyp** den Typ der Vorlage, die Sie erstellen. Wählen Sie **Normal**, wenn die Vorlage in **E-Mail** verfügbar sein soll. Sie können die Vorlage auch als Angebotsvorlage, als [Vorlage für Auftragsbestätigung][3] oder als [Datenschutzbestätigungsvorlage][4] verfügbar machen.

3. In der Liste **Vorlage speichern in** können Sie angeben, wo die Dokumentvorlage gespeichert werden soll.

4. Sie haben jetzt drei Möglichkeiten:

    * **Neue E-Mail-Vorlage erstellen**
    * **Vorhandene E-Mail-Vorlagendatei kopieren**.
        1. Klicken Sie auf die Liste **Vorlage kopieren**.
        2. Wählen Sie die gewünschte Vorlage in der Liste aus.
    * **Neue E-Mail-Vorlage von der Festplatte laden (.md/.md)**
        1. Klicken Sie auf die Schaltfläche **Hochladen**.
        2. Klicken Sie auf **Datei hochladen** im Dialogfeld **Datei hochladen**.
        3. Wählen Sie die gewünschte Datei aus und klicken Sie auf **Öffnen**. Der Name der Datei wird im Dialogfeld **Listenobjekt bearbeiten** angezeigt.

5. Klicken Sie im Dialogfeld **Listenobjekt bearbeiten** auf **Speichern**. Das Dialogfeld ist aktualisiert.

6. Optional: Bearbeiten Sie gegebenenfalls den Namen der Vorlage.

7. Klicken Sie auf **Bearbeiten**, um die Vorlagendatei selbst zu bearbeiten. Fügen Sie den Inhalt zur Vorlage hinzu, wenn Sie eine neue E-Mail-Vorlage erstellt haben.

8. Geben Sie die erforderlichen Informationen in die Registerkarten **Details** und **Sprachen** ein.

9. Klicken Sie auf **Speichern**. Die Vorlage wird als separates Objekt zur Liste **Objekte** hinzugefügt. Wiederholen Sie diesen Vorgang, wenn Sie weitere Vorlagen hinzufügen möchten.

## Registerkarte Details

Geben Sie die folgenden Informationen in die Registerkarte **Details** ein:

1. (optional) Bearbeiten Sie den Namen der Vorlage im Feld **Name**. Klicken Sie auf ![Symbol][img1], um die Funktion [Vorlagenname in anderen Sprachen hinzufügen][1] auszuführen.

2. Geben Sie den Titel der E-Mail im Feld **Betreff** ein. Sie können auch den [Betreff in anderen Sprachen hinzufügen][1], indem Sie auf ![Symbol][img1] klicken.

3. Wählen Sie **Signatur für neue E-Mail verwenden**, um Ihre Signatur in neuen E-Mails hinzuzufügen. Wenn Sie nicht über eine persönliche Signatur verfügen, wird die Systemsignatur verwendet.

4. Wählen Sie **E-Mail-Dialogfeld anzeigen**, um das Dialogfeld **Neue E-Mail** aufzurufen, wenn Sie basierend auf dieser Vorlage eine neue E-Mail erstellen. In diesem Dialogfeld können Sie Daten wie Firma, Person und Projekt usw. eingeben, die benötigt werden, wenn die E-Mail-Vorlage Vorlagenvariablen enthält.

5. Geben Sie optional in das Feld Beschreibung eine **Beschreibung** für die Vorlage ein.

6. Legen Sie im Feld **Richtung** fest, ob die Vorlage ein- oder ausgehend ist, indem Sie auf den Pfeil (![Symbol][img2]) klicken und im Listenfeld eine Option auswählen. Wählen Sie **Ausgehend**, wenn die Vorlage in **E-Mail** verfügbar sein soll.

7. Klicken Sie im Feld **Zweck** auf den Pfeil (![Symbol][img2]) und wählen Sie eine der vordefinierten Optionen vom Listenfeld aus. Diese Objekte gehören zur Statuskontrollfunktion (für die eine [Sales Intelligence][5]-Lizenz erforderlich ist).

    > [!TIP]
    > Zusätzlich zu den vordefinierten Optionen können Sie neue Optionen erstellen, indem Sie sie zur Liste **Folgeaufgabe - Zweck** in Einstellungen und Verwaltung hinzufügen.

8. Im Feld **Dokument gespeichert unter** können Sie einen von der Standardoption abweichenden Speicherort angeben.

9. Geben Sie eine Standardeinstellung in das Feld **Unser Zeichen** ein, indem Sie [Vorlagenvariablen][2] verwenden, zum Beispiel *verf* für den Vor- und Nachnamen des Absenders.

> [!NOTE]
> Sie können die Vorlage direkt im Dialogfeld **Listenobjekt bearbeiten** öffnen und bearbeiten, indem Sie auf die Schaltfläche **Bearbeiten** klicken. Nur htm/html-Dateien können direkt in diesem Editor bearbeitet werden. Der Dateityp wird im Feld **Dateiname** auf der Registerkarte **Details** angezeigt. Klicken Sie auf die Schaltfläche **Herunterladen**, um andere Dateitypen herunterzuladen und in der entsprechenden Anwendung zu bearbeiten.

## Registerkarte Sprachen

Hier können Sie übersetzte Versionen der Dokumentvorlage hinzufügen.

1. Klicken Sie auf **Hinzufügen**.
2. Wählen Sie im Dialogfeld **Listenobjekt bearbeiten** die gewünschte Sprache von der Liste **Sprache hinzufügen** aus.
3. Fügen Sie eine übersetzte Dokumentvorlage hinzu, wie oben beschrieben.
4. Klicken Sie auf **Hinzufügen**. Die Sprache ist in der Registerkarte **Sprachen** aufgeführt.
5. Gehen Sie wie in den Schritten oben erläutert vor, um weitere Sprachen hinzuzufügen.

> [!TIP]
> Klicken Sie auf ![Symbol][img1] neben dem entsprechenden Feld, um für den Vorlagennamen und E-Mail-Betreff die Funktion [Übersetzungen hinzufügen][1] auszuführen.

<!-- Referenced links -->
[1]: ../../../globalization-and-localization/learn/translate-fields.md
[2]: ../../../document/templates/learn/template-variables.md
[3]: sale-type.md
[4]: privacy-source-add.md
[5]: ../../../saint/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/az.png
[img2]: ../../../../media/icons/arrow-down.png
