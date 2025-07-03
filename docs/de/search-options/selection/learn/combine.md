---
uid: help-de-selection-combine
title: Kombinierte Selektion erstellen
description: In dieser Anleitung lernen Sie, wie Sie eine kombinierte Selektion erstellen.
keywords: Selektionen kombinieren, Kombinierte Selektion, Selektion
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
redirect_from: /de/search-options/selection/learn/create/combine
---

# Kombinierte Selektion erstellen

Die zwei zu kombinierenden Selektionen können statisch oder dynamisch sein. Es gibt jedoch bestimmte Einschränkungen für Kombinationen:

* Wenn Sie eine kombinierte Selektion bestehend aus Firmen erstellen, sind alle Selektionstypen verfügbar.
* Wenn Sie jedoch eine kombinierte Selektion bestehend aus Verkäufen, Projekten, Dokumenten, Folgeaufgaben oder Produkten erstellen, sind nur Selektionen des ausgewählten Typs verfügbar.

## Daten suchen

1. Öffnen Sie eine der Selektionen, die Sie kombinieren möchten.

1. Klicken Sie auf die Schaltfläche **Aufgabe** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) und wählen Sie **Selektion kombinieren mit** aus. Eine neue Ansicht Selektion wird geöffnet.

1. Geben Sie den Namen der neuen Selektion im Feld mit der Beschriftung *Selektionsname* ein. Die Eingabe in dieses Feld ist obligatorisch.

1. Wählen Sie im Feld **Selektion aus** den Inhalt der Selektion aus. Die Auswahlmöglichkeiten sind auf **Firma/Person** und den von Ihnen gewählten Selektionstyp beschränkt. Sie können diese Auswahl nicht mehr ändern, nachdem Sie sie in der Datenbank gespeichert haben.

1. Im Feld **Selektion ist** ist standardmäßig die Option **Kombiniert** ausgewählt.

1. Wählen Sie unter **Selektion 2** die andere Selektion aus, die Sie kombinieren möchten.

    > [!NOTE]
    > Wenn Sie **Firmen/Personen** unter **Selektion aus** ausgewählt haben, können Sie hier aus allen Selektionstypen wählen (eine Verkaufsselektion enthält auch Firmen/Personen in Bezug auf die Verkäufe). Wenn die kombinierte Selektion jedoch Verkäufe, Projekte, Dokumente, Folgeaufgaben, Anfragen, Formularübermittlungen, Chat-Gespräche, Kampagnen oder Produkte enthält, müssen Sie für **Selektion 1** und **Selektion 2** denselben Selektionstyp auswählen.

1. Wählen Sie unter **Vergleichen** aus, welche Einträge der beiden Selektionen in der kombinierten Selektion enthalten sein sollen.

| Symbol | Option | Beschreibung |
|:-:|---|---|
| <i class="ph ph-subtract" aria-label="Only in one selection icon"></i> | Nur in Selektion 1/Nur in Selektion 2 | Zeigt Einträge aus Selektion 1 oder Selektion 2 an und schließt Einträge aus, die sowohl in Selektion 1 als auch in Selektion 2 enthalten sind. |
| <i class="ph ph-intersect" aria-label="Common entries icon"></i> | Schnittmenge | Zeigt nur Einträge, die sowohl in Selektion 1 als auch in Selektion 2 enthalten sind. |
| <i class="ph ph-exclude" aria-label="Difference icon"></i> | Differenz | Zeigt nur Einträge, die entweder in Selektion 1 oder in Selektion 2 enthalten sind. |
| <i class="ph ph-unite" aria-label="All entries icon"></i> | Alle | Zeigt nur Einträge aus Selektion 1 und Selektion 2. |

## Details auswählen

Legen Sie die Eigenschaften gemäß den Anweisungen im Schritt 2 im Lernprogramm [Selektion erstellen][1] fest.

## Fertig stellen

1. Optional können Sie auf das Sternsymbol (<i class="ph ph-star" aria-hidden="true"></i>) klicken, um die Selektion zu [Ihren Favoriten][2] hinzuzufügen.

1. Klicken Sie auf **Speichern**.

Nachdem Sie die Selektion gespeichert haben, können Sie diese [bearbeiten][3], um sowohl den Kombinationstyp als auch die zu kombinierenden Selektionen zu ändern. Es ist jedoch nicht möglich, das Feld **Selektion aus** zu ändern.

## Beispiele für kombinierte Selektionen

### Firmen und Verkäufe

1. Erstellen Sie eine kombinierte Selektion mit Firmen/Personen auf Grundlage von zwei vorhandenen Selektionen: "Kunden in Schweden" (Selektion 1) und "Verkäufe im letzten Jahr" (Selektion 2).
2. Wählen Sie den Kombinationstyp **Nur in Selektion 1**. Als Ergebnis werden Kunden in Schweden angezeigt, für die im letzten Jahr keine Verkäufe stattgefunden haben.
3. Speichern Sie das Ergebnis als statische Selektion unter dem Namen "Kunden in Schweden ohne Verkäufe", und beauftragen Sie einen Ihrer Vertriebsmitarbeiter damit, diese Kunden zu betreuen.

### Folgeaufgaben

1. Erstellen Sie eine kombinierte Selektion mit Folgeaufgaben auf Grundlage von zwei vorhandenen Selektionen: "Folgeaufgaben, die mit meinen Kunden verknüpft sind" (Selektion 1) und "Geplante Folgeaufgaben im nächsten Monat" (Selektion 2).
2. Wählen Sie den Kombinationstyp **Schnittmenge**. Als Ergebnis wird eine Liste der Folgeaufgaben angezeigt, die im nächsten Monat anstehen. Sie können dieses Ergebnis nun über die Aufgabe **Export in Datei** in eine Datei exportieren.

> [!NOTE]
> Wenn Sie die Firmen vergleichen möchten, die mit diesen beiden Selektionen verknüpft sind, wählen Sie **Nur Firmen vergleichen**.

<!-- Referenced links -->
[1]: create.md
[3]: update/index.md
[2]: ../../../learn/basics/fav.md
