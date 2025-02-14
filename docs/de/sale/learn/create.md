---
uid: help-de-sale-create
title: Verkauf erfassen
description: Erfassen Sie Verkäufe in SuperOffice Sales, um alle Verkaufschancen und Kundeninformationen an einem Ort zu speichern. Diese Anleitung zeigt Ihnen, wie Sie Verkäufe erfassen.
keywords: Verkauf erstellen, neuer Verkauf, Verkauf hinzufügen, Verkauf erfassen, Verkauf
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Verkauf erfassen

Sie können einen Verkauf in SuperOffice CRM über die Schaltfläche **Neu** in der oberen Leiste erstellen. Sehen Sie sich dieses Video an oder folgen Sie den unten aufgeführten Schritten, um einen Verkauf zu erstellen:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/7Am9pqMyHSA]

(Videolänge – 2:10)

## Schritte

1. Klicken Sie auf **Neu** in der oberen Leiste und wählen Sie **Verkauf**.

1. Geben Sie einen **Verkaufstitel** ein (Pflichtfeld, rot markiert). Dies ist die Hauptbezeichnung für den Verkauf.

    ![Registerkarte Verkauf mit grundlegenden Feldern in der Verkaufskarte -screenshot][img1]

1. Geben Sie den **Betrag und die Währung** ein, um den geschätzten Wert des Verkaufs anzugeben.

1. Wählen Sie den **Verkaufstyp** aus dem Menü (Pflichtfeld). Verkaufstypen definieren den Prozess und können Stufen oder Leitfäden enthalten. Diese Werte werden in Einstellungen und Verwaltung vordefiniert.

1. *(Optional)* Ergänzen Sie weitere Informationen auf der Registerkarte **Verkauf**, wie zum Beispiel:
    * Verknüpfen Sie den Verkauf mit einer **Firma**.
    * Verknüpfen Sie den Verkauf mit einem laufenden **Projekt**.
    * Passen Sie das erwartete Abschlussdatum des Verkaufs an.
    * Nutzen Sie das große Textfeld für eine optionale Beschreibung des Verkaufs.
    * Wählen Sie die aktuelle **Verkaufsstufe** aus (falls zutreffend). Stufen verfolgen den Fortschritt des Verkaufs.

    > [!NOTE]
    > Falls der Verkaufstyp des Verkaufs keine Stufen enthält, bleibt der Verkaufsstatus **Offen**.

1. Wechseln Sie zur Registerkarte **Details**, um finanzielle Informationen wie Kosten, Gewinn und Wettbewerber hinzuzufügen.

1. **Weitere Details hinzufügen:**
    * Wechseln Sie zur Registerkarte **Mehr**, um [benutzerdefinierte Felder einzugeben][12].
    * Wechseln Sie zur Registerkarte **Notiz**, um [Freitextnotizen hinzuzufügen][11].
    * Wechseln Sie zur Registerkarte **Verknüpfungen**, um [Folgeaufgaben, Dokumente oder Webseiten mit dem Verkauf zu verknüpfen][10].

1. Klicken Sie auf **Speichern**, um den Verkauf zu speichern. Die Verkaufskarte ist nun erstellt.

## <a id="fields"></a>Wichtige Felder erklärt

Die folgenden Felder stehen in der Verkaufskarte zur Verfügung. Einige Felder werden automatisch ausgefüllt, andere müssen manuell eingegeben werden.

> [!NOTE]
> Felder und Layout können je nach **Ansichtsdesigner**-Konfigurationen und anderen UI-Anpassungen variieren.

<!-- markdownlint-disable MD051 -->
### [Registerkarte Verkauf](#tab/sale)

* **Titel:** Pflichtfeld zur Identifikation des Verkaufs.
* **Beschreibung:** Optionales Textfeld zur Zusammenfassung des Verkaufs.
* **Verkaufstyp:** Vordefinierte Typen, die den Prozess festlegen und möglicherweise mit Stufen oder Verkaufsleitfäden verknüpft sind. In Einstellungen und Verwaltung festgelegt.
* **Stufe:** Verfolgt den Fortschritt des Verkaufs. Verfügbare Stufen hängen vom gewählten Verkaufstyp ab.
* **Betrag und Währung:** Geschätzter Wert des Verkaufs. *(Die Währung muss in Einstellungen und Verwaltung aktiviert sein.)*
* **Wahrscheinlichkeit:** Gibt die Erfolgswahrscheinlichkeit des Verkaufs an. Basierend auf der aktuellen Stufe, aber manuell anpassbar.
* **Firma:** Die mit dem Verkauf verknüpfte Firma.
* **Person:** Die Kontaktperson bei der Firma, die mit dem Verkauf verknüpft ist.
* **Projekt:** Verknüpft den Verkauf mit einem laufenden Projekt.
* **Eigentümer:** Der für den Verkauf verantwortliche Benutzer. Standardmäßig der aktuell angemeldete Benutzer, kann aber geändert werden.
* **Verkaufsdatum:** Das erwartete Abschlussdatum des Verkaufs.
* **Nächste Aktivität:** Wird automatisch mit der ältesten unvollendeten Folgeaufgabe ausgefüllt. Daten vor dem heutigen Tag werden rot markiert.
* **Aufgeschoben-Kästchen:** Markiert den Verkauf als pausiert und ermöglicht die Eingabe von **Wiedereröffnungsdatum** und **Grund (aufgeschoben)**.

[!include[3 udef](../../learn/includes/more-udef.md)]

### [Registerkarte Details](#tab/details)

Die **Details**-Registerkarte enthält finanzielle Informationen zum Verkauf.

* **Nummer:** Automatisch generierte Verkaufs-ID.
* **Quelle:** Zeigt die Herkunft des Verkaufs an.
* **Wettbewerb:** Wählen Sie einen vordefinierten Wettbewerber, der mit dem Verkauf verknüpft ist. Es kann nur ein Wettbewerber ausgewählt werden.
* **Gesamtkosten:** Die mit dem Verkauf verbundenen Kosten. Aktualisiert automatisch den Ertrag. Dieser wird in der gleichen Währung wie der Betrag angezeigt. Der Standardwert ist 0. Wenn Sie einen Betrag in dieses Feld eingeben, wird im Feld darunter automatisch der Ertrag in Prozent und der Betrag ermittelt.
* **Ertrag:** Gewinn basierend auf Verkaufsbetrag und Kosten.
* **Gutschrift:** (Belastet) Weist den Verkauf einer verantwortlichen Abteilung zu.

> [!NOTE]
> Wenn Sie den Wert im Feld **Gesamtkosten**, **Ertrag** oder im Feld für die Ertragsprozentzahl ändern, werden die anderen Felder automatisch aktualisiert.

Werte für *Wettbewerber* und *Gutschrift* werden in Einstellungen und Verwaltung definiert.

### [Registerkarten Verknüpfungen und Notiz](#tab/other)

* **Verknüpfungen:** Verknüpfen Sie relevante Aktivitäten, Dokumente oder andere Verkäufe.
* **Notiz:** Fügen Sie Freitextnotizen hinzu, um zusätzliche Informationen zu erfassen.

***
<!-- markdownlint-enable MD051 -->

## Verwandte Inhalte

* [Angebot erstellen][4]
* [Verkauf aktualisieren][1]
* [Mit Verkaufsleitfäden arbeiten][2]

<!-- Referenced links -->
[1]: update.md
[2]: sales-guides.md
[4]: ../../quote/learn/create.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/notes.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/create-sale.png
