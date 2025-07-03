---
uid: help-de-sale-type-add
title: Verkaufstyp hinzufügen
description: Erfahren Sie, wie Sie einen neuen Verkaufstyp in SuperOffice CRM hinzufügen. Definieren Sie Stufen, Angebote und Genehmigungen für verschiedene Verkaufsprozesse.
keywords: neue Verkaufstyp, Verkaufstyp hinzufügen, Verkauf - Typ Stufen Angebot Liste, Verkauf - Kategorie Liste, Verkaufstypkonfiguration, Angebotsanhänge Registerkarte, Angebotsstandards, Angebotsgenehmigung, Verkaufstyp, Verkauf, Angebot
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: howto
license: salesessentials
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from:
  - /de/admin/lists/learn/sale-type
  - /de/sale/learn/screen/sales-type-for-stages
---

# Verkaufstyp

[!include[Must be admin](../../learn/includes/req-admin.md)]

Das Feld **Verkaufstyp** in der Verkaufsansicht kategorisiert Verkäufe und definiert ihre Abläufe. Diese Typen sind in der Liste **Verkauf - Typ, Stufen, Angebot** vordefiniert, die Sie in Einstellungen und Verwaltung unter **Listen** verwalten können.

Jeder Verkauf muss einen Typ haben, der mit bestimmten [Stufen][1] und optional mit [Verkaufsleitfäden][4] verknüpft sein kann. Verkaufsleitfäden helfen, den Prozess zu standardisieren, indem sie Vertriebsmitarbeiter durch vordefinierte Stufen, Folgeaufgaben und Dokumente leiten.

## Verkaufstyp hinzufügen

1. Wählen Sie <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listen** im Navigator.

1. Wählen Sie **Verkauf - Typ, Stufen, Angebot** aus dem Dropdown-Menü. Die Registerkarte **Objekte** zeigt alle bestehenden Verkaufstypen an.

1. Klicken Sie auf **Hinzufügen**, um das Dialogfeld **Listenobjekte bearbeiten** zu öffnen.

    ![Dialogfeld Listenobjekte bearbeiten mit Feldern für die Verkaufstypkonfiguration -screenshot][img1]

1. Geben Sie im Feld **Name** den Namen des Verkaufstyps ein. *(Pflichtfeld)*

    Dieser Name erscheint im Feld **Verkaufstyp** auf der Verkaufskarte.

1. Wählen Sie die passende Kategorie aus der Liste **Verkaufstypkategorie** aus.

    > [!TIP]
    > Neue Kategorien können in der Liste **Verkauf - Kategorie (für Verkaufstyp)** erstellt werden.

1. Legen Sie im Feld **Geschätzte Zeit für diesen Verkaufsvorgang** die typische Verkaufsdauer fest (Wochen, Tage oder Monate).

    Diese Angabe bestimmt das Standardenddatum beim Erstellen eines Verkaufs (aktuelles Tagesdatum + geschätzte Zeit).

1. Wählen Sie auf der Registerkarte **Stufen** die gewünschten Stufen aus der Liste **Für diesen Verkaufstyp verwendete Stufen** aus.

    > [!NOTE]
    > Um den Verkaufstyp mit einem Verkaufsleitfaden zu verknüpfen, müssen mindestens zwei Stufen ausgewählt werden.

1. *(Optional)* Aktivieren Sie **Dieser Verkaufstyp ist mit einem Leitfaden verknüpft**, um den Verkaufstyp mit einem [Verkaufsleitfaden][4] zu verknüpfen.

1. *(Optional)* Aktivieren Sie **Vorschlagen, den Verkauf automatisch in die nächste Stufe zu verschieben**, um Benutzer aufzufordern, nach Abschluss aller Aktivitäten zur nächsten Stufe zu wechseln.

1. *(Optional)* Aktivieren Sie **Dieser Verkaufstyp hat Beteiligte**, um die Verknüpfung von [Beteiligten][5] mit Verkäufen dieses Typs zuzulassen. *(Erfordert die SalesPremium-Lizenz.)*

1. Geben Sie eine Beschreibung des Verkaufstyps im Feld **Beschreibung** ein, falls erforderlich.

1. Für die Angebotsverwaltung konfigurieren Sie die Felder in den Registerkarten **Angebotsanhänge**, **Angebotsstandards** und **Angebotsgenehmigung**, wie unter [Erklärung der Angebotsfelder](#quote-fields) beschrieben. *(Erfordert die SalesPremium-Lizenz.)* Diese Einstellungen ermöglichen eine individuelle Anpassung der Angebote an die Anforderungen Ihrer Organisation.

1. Klicken Sie auf **Speichern**, um die Änderungen zu übernehmen, oder auf **Abbrechen**, um sie zu verwerfen.

## <a id="quote-fields"></a>Erklärung der Angebotsfelder

Ein Angebot gehört zu einem Verkauf, und jeder Verkauf hat einen Verkaufstyp. In jedem Verkaufstyp können Sie verschiedene Angebotsoptionen definieren, wie Anhänge, Genehmigungen oder Vorlagen.

<!-- markdownlint-disable MD051 -->
### [Registerkarte Angebotsanhänge](#tab/quote-attachment)

In der Registerkarte **Angebotsanhänge** können Sie Dokumente hinzufügen, die zusammen mit dem Angebot an den Kunden gesendet werden, wie Produktspezifikationen oder Broschüren.

> [!NOTE]
> Die Dokumente müssen zuvor als Dokumentvorlagen in SuperOffice hinzugefügt werden.

#### Angebotsanhang hinzufügen

1. Klicken Sie auf **Hinzufügen**.
1. Im **Suchen**-Dialog [nach den gewünschten Dokumenten suchen][7].
1. Wählen Sie ein oder mehrere Dokumente aus und klicken Sie auf **OK**. Die Dokumente werden in der Registerkarte **Angebotsanhänge** angezeigt.
1. Wählen Sie die Dokumente in der Spalte **Einbeziehen** aus.

Beim Erstellen eines Angebots mit diesem Verkaufstyp werden die ausgewählten Dokumente dem Angebot hinzugefügt, erscheinen jedoch nicht in der Bereichsregisterkarte **Aktivitäten**.

### [Registerkarte Angebotsstandards](#tab/quote-defaults)

In der Registerkarte **Angebotsstandards** können Sie folgende Einstellungen konfigurieren:

* **Hinzufügen von Alternativen zu Angebot erlauben:** Aktivieren, um mehrere Alternativen in einem Angebot zu ermöglichen.
* **Standardwert für die Tage, die ein Angebot gültig ist:** Anzahl der Tage, die ein Angebot gültig bleibt. Dieser Wert kann bei der Angebotsübermittlung angepasst werden.
* **Formatvorlage Angebot:** Wählen Sie die Standardvorlage für Angebote aus.
* **Vorlage für Auftragsbestätigung:** Wählen Sie die Standardvorlage für Auftragsbestätigungen aus.

### [Registerkarte Angebotsgenehmigung](#tab/quote-approval)

In der Registerkarte **Angebotsgenehmigung** können Sie festlegen, ob eine Genehmigung erforderlich ist:

* **Keine Genehmigung erforderlich:** Das Angebot benötigt keine Genehmigung.
* **Gesamtrabatt liegt über dem Grenzwert:** Geben Sie eine Prozentgrenze an, ab der eine Genehmigung erforderlich ist.
* **Gesamtgewinn liegt unter dem Grenzwert:** Geben Sie eine Mindestgewinnmarge an, die eine Genehmigung erfordert.

***
<!-- markdownlint-enable MD051 -->

## Verkaufstyp bearbeiten oder löschen

1. Folgen Sie den Schritten 1–2 in **Verkaufstyp hinzufügen**, um die Liste **Verkauf - Typ, Stufen, Angebot** zu öffnen.

1. Zum Bearbeiten:
    * Doppelklicken Sie auf den gewünschten Verkaufstyp, um das **Listenobjekte bearbeiten**-Dialogfeld zu öffnen.
    * Aktualisieren Sie die Felder nach Bedarf und klicken Sie auf **Speichern**.

1. Zum Löschen:
   * Wählen Sie den Verkaufstyp in der Liste aus und klicken Sie auf **Löschen**.

    > [!CAUTION]
    > Das Löschen eines Verkaufstyps entfernt auch dessen Verknüpfung mit Stufen und Verkaufsleitfäden. Stellen Sie sicher, dass er nicht aktiv verwendet wird.

## <a id="restore"></a>Gelöschten Verkaufstyp wiederherstellen

Falls ein Verkaufstyp gelöscht wurde, kann er aus der Liste **Verkauf - Typ, Stufen, Angebot** wiederhergestellt werden. Eine Wiederherstellung stellt jedoch nicht automatisch die Verknüpfungen zu Verkaufstufen oder Verkaufsleitfäden wieder her. Diese müssen manuell neu zugewiesen werden.

1. Gehen Sie zur Liste **Verkauf - Typ, Stufen, Angebot**.

1. Aktivieren Sie im Fußbereich die Option **Gelöschte Einträge und Überschriften anzeigen**. Gelöschte Einträge werden durchgestrichen dargestellt.

1. Doppelklicken Sie auf das wiederherzustellende Element. Das **Listenobjekte bearbeiten**-Dialogfeld öffnet sich.

1. Klicken Sie auf **Wiederherstellen**.

1. Aktualisieren Sie bei Bedarf die Felder und klicken Sie auf **Speichern**. Der Verkaufstyp wird nun wieder in der **Objekte**-Liste angezeigt.

## Verwandte Inhalte

* [Verkaufsstufe hinzufügen][1]
* [Verkaufsleitfaden erstellen][2]
* [Verkaufsleitfaden bearbeiten][3]
* [Angebotsvorlagen][6]

<!-- Referenced links -->
[1]: sale-stage.md
[2]: create-sales-guide.md
[3]: edit-sales-guide.md
[4]: ../learn/sales-guides.md
[5]: ../learn/stakeholders/index.md
[6]: ../../document/templates/learn/quote-templates.md
[7]: ../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/edit-sale-type.png
