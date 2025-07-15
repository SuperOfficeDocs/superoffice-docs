---
uid: help-de-form-prefilled
title: Verwenden vorausgefüllter Felder in Formularen
description: Verwenden vorausgefüllter Felder in Formularen
keywords: Formular, Feld, vorausgefüllt, vorausgefüllts Feld, Feldidentifikator, Feldbezeichnung
author: SuperOffice RnD
date: 03.18.2024
version: 10
content_type: howto
language: de
audience: person
audience_tooltip: SuperOffice Marketing
---

# Verwenden vorausgefüllter Felder in Formularen

Um Ihren Kunden die Eingabe ihres Namens, ihrer E-Mail-Adresse, Telefonnummer usw. in Formularen zu ersparen, können Sie den Formular-Links/URLs Feldbezeichnungen und Vorlagenvariablen hinzufügen. Wenn der Kunde ein Formular öffnet, wurden vorhandene Kundendaten mithilfe von SuperOffice-Daten bereits angegeben.

Ein Feldidentifikator ist eine eindeutige ID für ein bestimmtes Feld. Sie wird sich nicht ändern, selbst wenn sich der Feldname/die Feldbezeichnung oder die Sprache ändert. Auf diese Weise können Sie sicherstellen, dass Links zu diesem Feld nach der Veröffentlichung des Formulars nicht unterbrochen werden.

## Schritte

1. [Erstellen Sie ein neues Formular][1].

2. Bei jedem Feld, das vorausgefüllt werden soll: Klicken Sie auf **Erweiterte Optionen** (<i class="ph ph-gear" aria-hidden="true"></i>), um das Feld **Bezeichnung** anzuzeigen, in dem Sie eine ID für das Feld hinzufügen können.

3. [Veröffentlichen Sie Formulare][2].

4. Wählen Sie **Mit vorausgefüllten Feldern anzeigen**, um Feldbezeichnungen zur Verknüpfung/JavaScript hinzuzufügen. Das sollte in etwa so aussehen:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=&field-mail=
    ```

    Wenn keine Feldbezeichnungen hinzugefügt werden, haben Sie die IDs womöglich nicht zu den Feldern im Formular hinzugefügt.

5. Kopieren Sie die Verknüpfung oder JavaScript in einen Texteditor o. Ä.

6. Geben Sie die entsprechenden [Vorlagenvariablen][3] zwischen zwei eckigen Klammern NACH dem Gleichheitszeichen ein:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=\[\[customer.name\]\]&field-mail=\[\[customer.email\]\]
    ```

7. Kopieren Sie die vollständige Verknüpfung oder JavaScript und veröffentlichen Sie sie.

<!-- Referenced links -->
[1]: create.md
[2]: publish.md
[3]: ../../../knowledge-base/learn/reply-templates/template-variables.md
