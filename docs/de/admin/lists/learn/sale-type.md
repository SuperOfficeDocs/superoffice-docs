---
uid: help-de-sale-add-type
title: Verkaufstyp hinzufügen
description: Verkaufstyp hinzufügen
author: SuperOffice RnD
date: 06.29.2022
keywords: Verkaufstyp
topic: howto
language: de
---

# Verkaufstyp hinzufügen

[!include[Must be admin](../../../learn/includes/req-admin.md)]

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

> [!NOTE]
> Ein Angebot gehört zu einem Verkauf und alle Verkäufe haben einen Verkaufstyp. In jedem Verkaufstyp können Sie viele der Eigenschaften eines Angebots definieren, wie zum Beispiel Anhänge, Einstellungen für Genehmigungen, Verwendung von Alternativen und Vorlagen.

[!include[Edit list item](includes/edit-list-item.md)] wenn die Listenobjekte Verkaufstypen sind:

1. Geben Sie den gewünschten Namen für das Objekt in das Feld **Name** ein.

    [!include[Mandatory](includes/note-mandatory-field.md)]

2. Wählen Sie im Listenfeld **Verkaufstypkategorie** die gewünschte Kategorie für den Verkaufstyp.

    > [!TIP]
    > Zusätzlich zu den bereits vordefinierten Optionen können Sie neue Optionen erstellen, indem Sie zur Liste **Verkauf - Kategorie (für Verkaufstyp)** in Einstellungen und Verwaltung [Objekte hinzufügen][2].

3. Geben Sie in das Feld **Geschätzte Zeit für diesen Verkaufsvorgang** eine Dauer für den Verkaufstyp ein (Anzahl der Wochen, Tage oder Monate). Wenn Sie einen neuen Verkauf für diesen Verkaufstyp erstellen, wird das Verkaufsdatum anhand der geschätzten Dauer eingestellt, die Sie hier eingeben (aktuelles Tagesdatum + geschätzte Zeit).

4. Geben Sie unten im Dialogfeld eine Beschreibung des Verkaufstyps ein.

5. Geben Sie die Informationen in die Registerkarten **Stufen**, **Angebotsanhänge**, **Standardinhalte für Angebote** und **Angebotsgenehmigung** ein. Gehen Sie dazu wie nachfolgend beschrieben vor.

    > [!NOTE]
    > Die Registerkarten **Angebotsanhänge**, **Angebotsstandards** und **Angebotsgenehmigung** sind nur relevant, wenn Sie eine Verwaltungslizenz für Verkaufsangebote haben.

6. [!include[Save or cancel](includes/save-or-cancel.md)]

## Registerkarte Stufen

In der Registerkarte **Stufen** gehen Sie folgendermaßen vor:

1. Wählen Sie in der Liste **Für diesen Verkaufstyp verwendete Stufen** die Stufen, die Sie in diesen Verkaufstyp einbeziehen möchten. Dieser Schritt ist optional. Sie sollten jedoch mindestens zwei Stufen auswählen, wenn Sie den Verkaufstyp mit einem Verkaufsleitfaden verknüpfen möchten.

    [Wie man eine Stufe erstellt][3].

2. Markieren Sie die Option **Dieser Verkaufstyp ist mit einem Leitfaden verknüpft**, wenn sich alle Verkäufe dieses Verkaufstyps nach einem [Verkaufsleitfaden][5] richten sollen.

3. Wenn Sie möchten, können Sie die Option **Vorschlagen, den Verkauf automatisch in die nächste Stufe zu verschieben** auswählen.

    Nachdem alle Folgeaufgaben und Dokumente für eine Stufe abgeschlossen sind, werden Sie gefragt, ob Sie sie zum nächsten Status verschieben möchten.

4. Aktivieren Sie die Option **Dieser Verkaufstyp hat Beteiligte**, um die Verknüpfung von [Beteiligten][4] mit Verkäufen dieses Typs zuzulassen.

## Registerkarte Angebotsanhänge

In der Registerkarte **Angebotsanhänge** können Sie Dokumente anhängen, die Sie dem Kunden zusammen mit dem Angebot senden möchten. Zum Beispiel Produktspezifikationen, Broschüren usw.

> [!NOTE]
> Die Dokumente müssen zunächst als Dokumentvorlagen in SuperOffice hinzugefügt werden.

### Angebotsanhang hinzufügen

1. Klicken Sie auf **Hinzufügen**.
2. Suchen Sie in der Ansicht Suchen die Option [Nach hinzuzufügenden Dokumenten suchen][1].
3. Wählen Sie eines oder mehrere Dokumente aus und klicken Sie auf **OK**. Die Dokumente werden in der Registerkarte **Angebotsanhänge** angezeigt.
4. Wählen Sie die Dokumente aus, die Sie der Spalte **Einbeziehen** hinzufügen möchten.

Wenn Sie ein Angebot mit diesem Verkaufstyp erstellen, werden die ausgewählten Dokumente dem Angebot als Anhänge hinzugefügt. Sie werden jedoch nicht in der Bereichsregisterkarte **Aktivitäten** im Verkauf hinzugefügt.

## Standardinhalte für Angebote

Einstellungen für Angebote mit diesem Verkaufstyp:

* **Hinzufügen von Alternativen zu Angebot erlauben**: Aktivieren Sie diese Option, wenn Benutzer einem Angebot mehrere Alternativen hinzufügen dürfen.
* **Standardwert für die Tage, die ein Angebot gültig ist**: Geben Sie die Anzahl an Tagen ein, für die ein Angebot gültig sein soll. Dieser Wert kann noch einmal geändert werden, wenn das Angebot gesendet worden ist.
* **Formatvorlage Angebot**: Aktivieren Sie die Vorlage, die Sie für das Angebot verwenden möchten.
* **Vorlage für Auftragsbestätigung**: Aktivieren Sie die Vorlage, die Sie für die Bestätigung verwenden möchten.

## Angebotsgenehmigung

Hier können Sie auswählen, ob das Angebot genehmigt werden muss, wenn der Gesamtrabatt über einem gewissen Grenzwert oder die Gesamteinnahmen unter einem gewissen Grenzwert liegt:

* Keine Genehmigung erforderlich. Keine Einschränkungen. Das Angebot erfordert keine Genehmigung.
* **Gesamtrabatt liegt über dem Grenzwert**. Geben Sie einen Prozentwert ein.
* **Gesamtverdienst liegt unter dem Grenzwert**. Geben Sie einen Prozentwert ein.

## Verwandte Themen

* [Angebotsvorlage][6]

<!-- Referenced links -->
[2]: adding-items.md
[3]: ../../../sale/learn/screen/sale-stage.md
[4]: ../../../sale/learn/stakeholders/index.md
[5]: ../../../sale/learn/screen/sales-guide-admin.md
[1]: ../../../search-options/learn/search-criteria.md
[6]: ../../../document/templates/learn/quote-templates.md

<!-- Referenced images -->
