---
uid: help-de-udef
title: Felder Web
description: Felder Web
author: SuperOffice RnD
so.date: 06.29.2022
keywords: udef, benutzerdefiniertes Feld
so.topic: concept
so.user: admin
so.user.tooltip: Settings and maintenance
language: de
---

# Benutzerdefinierte Felder

Mehrere Bereiche von SuperOffice CRM wie zum Beispiel die Anzeige Firma, enthalten eine separate Registerkarte namens **Mehr**. Hier können Sie Ihre eigenen Felder eingeben, um das Programm an die Anforderungen Ihrer Organisation anzupassen. [!include[SM](../../../learn/includes/are-defined-sm.md)]

Alle Firmen und Organisationen haben ihre eigenen Anforderungen an die Informationen, die sie benötigen, um sich über ihre Kunden, Verkäufe, Projekte, Verträge usw. zu registrieren. In der Ansicht **Felder** können Sie in SuperOffice CRM Ihre eigenen Felder eingeben. Auf diese Weise können Sie den Informationstyp anpassen, die in Bezug auf Firmen, Personen, Projekte, Verkäufe, Dokumente und Folgeaufgaben erfasst werden können.

> [!NOTE]
> Sie können Seite 3 Felder festlegen, die auf der „ersten Seite“ der entsprechenden Ansichten oder Dialogfelder angezeigt werden. [Wie?][1] Beachten Sie, dass dies möglicherweise nicht anwendbar ist, wenn Sie ein anderes Layout über den [Ansichtsdesigner][8] verwenden.

## <a id="field-types" />Feldtypen

[!include[List of field types](includes/field-types.md)]

## Welcher Vorteil ergibt sich für mich aus den Informationen, die ich in diese Felder eingebe?

* Mit Hilfe der **Suchen**-Funktion können Sie nach Informationen suchen, die Sie in diesen Feldern erfassen wollen, und dynamische Selektionen treffen.
    **Beispiel**: Wenn Sie das Ablaufdatum der Wartungsverträge ihrer Kunden erfassen, können Sie eine dynamische Selektion erstellen, die die Kunden anzeigt, deren Verträge in weniger als einem Monat ablaufen.

* Sie können die Informationen von diesen Feldern mithilfe von Vorlagenvariablen in Dokumenten und E-Mails wiederverwenden. Jedes Feld, dass sie hinzufügen, bekommt seine eigene, eindeutige ID, die in Dokumenten benutzt werden kann, um kundenspezifische Informationen zusammenzuführen.
    **Beispiel**: Wenn Sie eine E-Mail an Kunden senden, um sie darüber zu informieren, dass der Wartungsvertrag bald abläuft, kann die Vorlagenvariable für das Ablaufdatum verwendet werden, um das richtige Ablaufdatum in der gesendeten Mitteilung festzulegen.

## Wo werden die von mir erstellten Felder angezeigt?

* [Registerkarte Mehr (Firma)][6]
* [Registerkarte Mehr (Person)][7]
* [Registerkarte Mehr (Projekt)][3]
* [Registerkarte Mehr (Folgeaufgaben)][4]
* [Registerkarte Mehr (Dokument)][5]
* Die Registerkarte Details in der Anzeige Verkauf

Sie können *Felder auf Seite 1* (Felder, die auf der „ersten Seite“ der entsprechenden Ansichten oder Dialogfelder angezeigt werden) an folgenden Stellen festlegen:

[!include[List](includes/list-page-1-field-locations.md)]

## Beispiele

### Benutzerdefinierte Felder für Firmen

Ihre Firma verkauft Software und Benutzersupport-Dienstleistungen. Die Benutzersupport-Abteilung muss darüber Bescheid wissen, über wie viele Mitarbeiter und PCs die jeweiligen Kunden verfügen. Außerdem müssen Sie wissen, welchen Wartungsvertrag die Kunden aufweisen und wann diese ablaufen.

Sie können diese Felder dann der Ansicht Firma hinzufügen:

| Feldname | Typ | Beschreibung |
|---|---|---|
| Anzahl an PCs | Nummer | Ein Nummernfeld, in dem Sie die Anzahl an PCs erfassen können. |
| Anzahl der Mitarbeiter | Nummer | Ein Nummernfeld, in dem Sie die Anzahl der Mitarbeiter erfassen können. |
| Wartungsvertrag | Liste | Eine Auflistung der verschiedenen Arten von Wartungsverträgen, die Sie anbieten. Die Liste muss [in der Ansicht Listen erstellt][2] sein. |
| Der Vertrag läuft ab | Datum | Ein Datumsfeld, in dem Sie das Ablaufdatum des Vertrags erfassen können. |
| Anwendung A; Anwendung B; Anwendung C | Kontrollkästchen | Drei Kontrollkästchen, womit Sie die Anwendungen kennzeichnen können, die der Kunde erworben hat. |

> [!NOTE]
> Die hinzugefügten Felder werden in der Registerkarte **Mehr** in der Ansicht Firma angezeigt. Um sie auf der Firmenkarte anzuzeigen, [geben Sie sie als *Felder auf Seite 1*][1] an.

### Benutzerdefinierte Felder für Verkäufe

Bei der Erstellung eines Verkaufs kann es hilfreich sein, die verkauften Produkte und deren Anzahl anzugeben.

Sie können dann die folgenden Felder zur Anzeige Verkauf hinzufügen:

| Feldname | Typ | Beschreibung |
|---|---|---|
| Produkt | Langer Text | Ein Textfeld, in das Sie den Namen des verkauften Produkts eingeben können. |
| Menge | Nummer | Ein Nummernfeld, in dem Sie die Anzahl der verkauften Einheiten erfassen können. |

> [!TIP]
> Hier können Sie auch ein Listenfeld verwenden, wenn Sie eine Liste der zu verkaufenden Produkte erstellt haben.

### Benutzerdefinierte Felder für Projekte

Sie möchten, dass das Budget zu einem Projekt für die Projektmitglieder gut sichtbar ist.

Sie können diese Felder dann der Ansicht Projekt hinzufügen:

| Feldname | Typ | Beschreibung | Anmerkungen |
|---|---|---|---|
| Budget | Dezimal | Ein Nummernfeld, in das Sie eine Summe eingeben können. | [Wählen Sie das auf Seite 1 anzuzeigende Feld aus][1]. |

<!-- Referenced links -->
[1]: page-1-fields.md
[2]: ../../../admin/lists/learn/adding-user-defined-lists.md
[3]: ../../../project/learn/index.md#more-tab
[4]: ../../../diary/learn/screen/dialog-for-followups.md
[5]: ../../../document/learn/screen/index.md
[6]: ../../../company/learn/create.md#more-tab
[7]: ../../../contact/learn/create.md#more-tab
[8]: ../../../ui/screen-designer/learn/index.md

<!-- Referenced images -->