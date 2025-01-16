---
title: Benutzerdefinierte Objekte
uid: help-de-custom-objects
description: Benutzerdefinierte Objekte
keywords: benutzerdefiniertes Objekt, Felder, udef
author: Bergfrid Dias
date: 01.30.2024
version: 10
topic: concept
language: de
audience: user
audience_tooltip: SuperOffice CRM
---

# Benutzerdefinierte Objekte und Felder

>Alle Firmen und Organisationen haben ihre eigenen Anforderungen an die Informationen, die sie bezüglich ihrer Kunden, Verkäufe, Projekte, Verträge usw. registrieren müssen. Administratoren können in SuperOffice Felder und Tabellen hinzufügen, um den Typ der zu registrierenden Informationen anzupassen.

SuperOffice CRM und Service waren einmal zwei separate Anwendungen mit unterschiedlichen Erweiterungsoptionen. [**Benutzerdefinierte Felder**][1] (kurz udefs) gehören zu SuperOffice CRM, während [**Zusättabellen**][3] (auch als Drittanbietertabellen bezeichnet) und [**Zusätzfelder**][2] zu Service gehören. Der Begriff **benutzerdefiniertes Feld** umfasst sowohl benutzerdefinierte Felder als auch zusätzliche Felder.

## Verwendung

* Ein gutes Beispiel für ein benutzerdefiniertes Feld, das Sie auf der Ansicht **Kontakt** verwenden können, ist ein Feld namens "Zufriedener Kunde", bei dem der Wert des Feldes Ja oder Nein ist. Sie können zum Beispiel Ihren Kontakten eine E-Mail (mit Verknüpfungsaktionen) senden, in der sie angeben können, ob sie mit Ihren Dienstleistungen zufrieden sind. Dies gibt Ihnen wertvolle Einblicke in die allgemeine Kundenzufriedenheitsrate.

* Mit der **Suchen**-Funktion können Sie nach den Informationen suchen, die Sie in benutzerdefinierten Feldern registrieren, und Selektionen erstellen. Wenn Sie zum Beispiel das Ablaufdatum der Wartungsvertrag registrieren, die Sie mit Kunden haben, können Sie eine dynamische Selektion erstellen, die die Kunden zeigt, für die die Vereinbarung in weniger als einem Monat abläuft.

* Sie können die Informationen aus diesen Feldern in Dokumenten und E-Mails als **Vorlagenvariablen** wiederverwenden. Jedes Feld, das Sie hinzufügen, erhält seine eigene eindeutige ID (Prog ID), die in Dokumenten verwendet werden kann, um kontaktspezifische Informationen zu fusionieren. Wenn Sie also eine E-Mail an Kunden senden möchten, in der steht, dass ihre Wartungsvertrag bald abläuft, können Sie die Vorlagenvariable für das Ablaufdatum verwenden, um das korrekte Ablaufdatum ihrer Vereinbarung in der Mitteilung anzuzeigen.

## Anforderungen

| Anpassung | Lizenz | Kommentar |
|---|---|---|
| Benutzerdefiniertes Feld hinzufügen/entfernen | Keine | Wird automatisch auf der [Registerkarte Mehr][12] angezeigt. Benötigt Development Tools, um die Platzierung anzupassen. |
| Layout der Registerkarte Mehr anpassen | Development Tools | |
| Site-1-Felder verwalten | Development Tools | |
| Zusatzfeld | Development Tools | |
| Zusatztabelle | Development Tools | |
| [Ansichtsdesigner][5] | Development Tools | SuperOffice Version 10 und neuer. |
| [Benutzerdefinierte Ansichten][6] | Development Tools, Service | Neues Ansicht in Service erstellen. |

## Layout (Positionierung von Feldern)

Die UI-Anpassung jeder Art erfordert die Development Tools-Lizenz. Alle benutzerdefinierten Ansichtlayouts (erstellt im Ansichtsdesigner) können die Einstellungen für individuelle benutzerdefinierte Felder außer Kraft setzen.

Wenn Sie keine Development Tools-Lizenz haben, verwenden Sie die Reihenfolge der verschiedenen Felder, um sie auf dem Tab **Mehr** zu sortieren.

## Zugehörige Inhalte

* [Der Ansichtsdesigner][5]

<!-- Referenced links -->
[1]: udef.md
[2]: extra-field.md
[3]: extra-table.md
[5]: ../../ui/screen-designer/learn/index.md
[6]: https://docs.superoffice.com/en/ui/blogic/custom-screens/index.html
[12]: more-tab.md

<!-- Referenced images -->
