---
uid: help-de-form-prefilled
title: Verwenden vorausgefüllter Felder in Formularen
description: Verwenden vorausgefüllter Felder in Formularen
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Formulare
so.topic: howto
language: de
---

# Verwenden vorausgefüllter Felder in Formularen

Um Ihren Kunden die Eingabe ihres Namens, ihrer E-Mail-Adresse, Telefonnummer usw. in Formularen zu ersparen, können Sie den Formular-Links/URLs Feldbezeichnungen und Vorlagenvariablen hinzufügen. Wenn der Kunde ein Formular öffnet, wurden vorhandene Kundendaten mithilfe von SuperOffice-Daten bereits angegeben.

1. [Erstellen Sie ein neues Formular][1].

2. Bei jedem Feld, das vorausgefüllt werden soll: Klicken Sie auf ![Symbol][img1] **Erweiterte Optionen**, um das Feld **Bezeichnung** anzuzeigen, in dem Sie eine ID für das Feld hinzufügen können. Diese Angabe ist eine eindeutige ID für das Feld und ändert sich nicht, wenn der Feldname bzw. die Feldbezeichnung oder die Sprache geändert wird. Damit können Sie sicherstellen, dass Links auf das Feld nach Veröffentlichung des Formulars weiterhin funktionieren.

3. [Veröffentlichen Sie Formulare][2].

4. Wählen Sie **Mit vorausgefüllten Feldern anzeigen**, um Feldbezeichnungen zur Verknüpfung/JavaScript hinzuzufügen.
    Das sollte in etwa so aussehen:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=&field-mail=
    ```

5. Kopieren Sie die Verknüpfung oder JavaScript in einen Texteditor o. Ä.

6. Geben Sie die entsprechenden [Vorlagenvariablen][3] zwischen zwei eckigen Klammern NACH dem Gleichheitszeichen ein:
    ```text
    ...formId=F-FH2K4Vru&field-name-1=\[\[customer.name\]\]&field-mail=\[\[customer.email\]\]
    ```

7. Kopieren Sie die vollständige Verknüpfung oder JavaScript und veröffentlichen Sie sie.

<!-- Referenced links -->
[1]: create.md
[2]: publish.md
[3]: ../../../request/reply-templates/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/cog-wheel.png
