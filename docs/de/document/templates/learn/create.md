---
uid: help-de-document-template-create
title: Vorlagendokument erstellen
description: Vorlagendokument erstellen
keywords: Dokumentvorlage, Dokument, Vorlage
author: Bergfrid Dias, Terje Nøstdahl, samuelholmstroem
date: 07.31.2024
version: 10
topic: howto
language: de
---

# Vorlagendokument erstellen

Um sicherzustellen, dass alle in Ihrer Firma die gleichen Dokumente verwenden, können Sie Ihre eigenen Dokumentvorlagen für verschiedene Dateitypen erstellen und hinzufügen. Verwenden Sie die verfügbaren Vorlagenvariablen, um die Eingabe von Kundeninformationen in Ihre Dokumente zu personalisieren und zu automatisieren.

Eine Vorlage erstellen Sie als Dokument in einer Anwendung, die mit SuperOffice CRM verknüpft ist (z. B. in einem Textverarbeitungsprogramm). Wenn Sie die Vorlage in Word erstellen, speichern Sie sie als normales Dokument (mit der Dateierweiterung **DOC** oder **DOCX**), nicht als Vorlage (mit der Dateierweiterung **DOT** oder **DOTX**).

Sie können auch Vorlagen im HTML-Format erstellen und die Vorlage mit dem SuperOffice HTML-Editor bearbeiten.

> [!TIP]
> Um neue Vorlagen hinzuzufügen, können Sie ganz einfach vorhandene Dokumentvorlagen kopieren und bearbeiten, um sie an Ihre Bedürfnisse anzupassen.

## Schritte

1. Starten Sie die gewünschte Anwendung.
2. Erstellen Sie ein neues Dokument.
3. Fügen Sie die gewünschten [Vorlagenvariablen][1], wie zum Beispiel Variablen für Namen, Adresse und Telefonnummer in die Vorlage ein.
4. Speichern Sie das Vorlagendokument irgendwo, wo Sie es jederzeit problemlos wiederfinden.

Nachdem Sie eine Vorlage definiert und im Vorlagenordner gespeichert haben, müssen Sie die [Vorlage mit SuperOffice CRM verknüpfen][2], um daraus Dokumente zu erstellen.

## Merge fields zur Angebotsvorlage hinzufügen

Felder in der Angebotszeile, die nicht aktiviert sind, haben leere Werte für ihre Tags – auch wenn Sie manuell Daten in die Datenbank eingeben. Um alle Tags zu verwenden, gehen Sie zu den Angebotseinstellungen in Einstellungen und Verwaltung und aktivieren Sie alle Felder.

Um Felder in Ihre Vorlage einzufügen, können Sie eine der folgenden Methoden verwenden:

### Methode 1: Verwenden Sie den Felddialog

1. Platzieren Sie den Cursor dort, wo Sie das Feld einfügen möchten.

1. Klicken Sie auf **Einfügen** > **Schnellbausteine** > **Feld**.

    ![Schnellbausteine -screenshot][img1]

1. Geben Sie in der Liste **Feldnamen** "merge" ein, um **MergeField** hervorzuheben.

1. Geben Sie in **Feldeigenschaften** Ihren [Feldnamen][3] (ohne «») ein:

    ![Feldeigenschaften im Microsoft Word-screenshot][img2]

1. Klicken Sie auf **OK** und die Variable wird in Ihr Dokument eingefügt:

    ![MergeField einfügen -screenshot][img3]

### Methode 2: Kopieren und Einfügen vorhandener Felder (am schnellsten)

1. **Kopieren** Sie ein vorhandenes Feld aus der Vorlage. Stellen Sie sicher, dass Sie das gesamte Feld einschließlich der «»-Klammern kopieren.

1. **Fügen** Sie das Feld in Ihre Vorlage ein, wo es benötigt wird.

1. Klicken Sie mit der rechten Maustaste auf das eingefügte Feld und wählen Sie **Felder bearbeiten**.

1. Geben Sie im Feld **Feldname** unter **Feldeigenschaften** den neuen Feldnamen ein oder fügen Sie ihn ein (ohne «»).

1. Klicken Sie auf **OK**.

## Berechnungen

Sie können Berechnungen mit den Merge fields durchführen.

### Nettopreis pro Einheit

Um den Preis pro Einheit nach Rabatten anzuzeigen, können Sie ein Merge field wie dieses hinzufügen:

```text
{= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}
```

**Schritte:**

1. Drücken Sie Strg + F9, um ein neues Merge field hinzuzufügen. Sie sehen zwei geschweifte Klammern { }.

1. Innerhalb der Klammern:
    1. Fügen Sie "= " hinzu und drücken Sie erneut Strg + F9.
    1. Fügen Sie "MERGEFIELD line/totalPrice" in einem neuen Satz Klammern hinzu.
    1. Geben Sie "/" ein und drücken Sie dann Strg + F9.
    1. Fügen Sie "MERGEFIELD line/quantity" in den letzten Satz Klammern ein.

1. Jetzt sollten Sie ein Feld haben, das so aussieht: {= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}

## Verwandte Inhalte

* [Wie man mit Feldern in Aspose Words arbeitet][9]
* [Angebotsvorlagen und Merge fields][4]
* [Referenz für Merge fields][3]
* [Referenz für Vorlagenvariablen][6]

<!-- Referenced links -->
[1]: template-variables.md
[4]: quote-templates.md
[2]: ../admin/link-template.md
[3]: ../merge-fields/index.md
[6]: ../variables/for-quote-line.md
[9]: https://docs.aspose.com/words/net/fields-overview/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/word-insert-quick-parts.png
[img2]: ../../../../media/loc/en/document/word-field-dialog.png
[img3]: ../../../../media/loc/en/document/6764-11541.jpg
