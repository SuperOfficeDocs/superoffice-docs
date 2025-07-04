---
uid: help-de-quote-create
title: Angebot erstellen
description: Erfahren Sie, wie Sie in SuperOffice CRM ein Angebot erstellen, Produkte hinzufügen, Angebotsdetails bearbeiten und häufige Probleme lösen.
keywords: Angebot erstellen, Angebot kopieren, Produkt hinzufügen, Dialog Produkt hinzufügen/bearbeiten, Dialogfeld Angebot bearbeiten, Angebot
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: de
redirect_from:
  - /de/quote/learn/add-product
  - /de/quote/learn/copy
  - /de/quote/learn/create
  - /de/quote/learn/screen/edit-quote-dialog
---

# Angebot erstellen

In SuperOffice CRM können Sie ein Angebot von Grund auf neu erstellen oder eines aus einem anderen Verkauf kopieren. Nach dem Erstellen des Angebots können Sie Produkte hinzufügen, Preise anpassen und den Vorschlag für den Kunden vorbereiten.

## Neues Angebot erstellen

1. [Erstellen Sie einen neuen Verkauf][1] oder öffnen Sie einen bestehenden Verkauf (einen, der nicht als Verkauft oder Verloren markiert ist).

1. Gehen Sie zur Bereichsregisterkarte **Angebot**.

1. Klicken Sie auf **Ein neues Angebot erstellen**.

1. Das Dialogfeld **Angebot bearbeiten** wird geöffnet. Von hier aus können Sie [Produkte hinzufügen](#add-products) und Angebotsdetails bearbeiten.

![Dialogfeld Angebot bearbeiten -screenshot][img1]

## <a id="copy"></a>Angebot aus einem anderen Verkauf kopieren

Um Zeit zu sparen, können Sie ein vorhandenes Angebot aus einem anderen Verkauf wiederverwenden, sofern dieselbe Währung verwendet wird.

1. Öffnen Sie einen Verkauf ohne Angebot und gehen Sie zur Bereichsregisterkarte **Angebot**.

1. Klicken Sie auf **Angebot aus einem anderen Verkauf kopieren**.

1. Im Dialogfeld **Neues Angebot durch Kopieren eines vorhandenen Angebots erstellen**:

    * Wählen Sie einen Verkauf aus der Liste aus (muss ein Angebot mit derselben Währung enthalten).
    * Oder, beginnen Sie mit der Eingabe, um nach dem Verkaufsnamen zu suchen.

1. Klicken Sie auf **OK**. Das Angebot und alle Alternativen werden in den aktuellen Verkauf kopiert und in der Registerkarte **Angebot** mit dem Status **Entwurf** angezeigt.

1. Klicken Sie auf **Öffnen**, um das Angebot im Dialogfeld **Angebot bearbeiten** anzuzeigen oder zu bearbeiten.

## <a id="add-products"></a>Produkte zum Angebot hinzufügen

### Ein Produkt hinzufügen

1. Klicken Sie in der Registerkarte **Produkte** des Angebots auf **Hinzufügen**.
    Das Dialogfeld **Produkt hinzufügen/bearbeiten** wird geöffnet.

1. Beginnen Sie mit der Eingabe im Feld **Produktsuche**, um ein Produkt nach Name oder Code zu finden.

1. Wählen Sie ein Produkt aus der Liste aus.

    Die Produktfelder werden automatisch anhand der ausgewählten Preisliste ausgefüllt.

1. Geben Sie die **Menge** ein (Pflichtfeld).

1. Optional: Passen Sie den Preis mit einer der folgenden Optionen an:

    * **Rabattprozentsatz**
    * **Rabattbetrag**
    * **Gesamtpreis**

    Bewegen Sie den Mauszeiger über ein Rabattfeld, um etwaige Systemrabatte anzuzeigen (z. B. automatisch angewendete Mengenrabatte).

1. Wechseln Sie zur Registerkarte **Details**, um:

    * **Einnahmen** (Prozentsatz oder Betrag) anzuzeigen oder anzupassen
    * Optional **MwSt.** festzulegen

    > [!NOTE]
    > Rabatt, Gesamtpreis und Einnahmen sind miteinander verknüpft. Änderungen an einem Feld wirken sich automatisch auf die anderen aus. Das zuletzt bearbeitete Feld wird hervorgehoben.
    >
    > Wenn Sie einen vom System nicht erlaubten Rabatt eingeben, wird eine Warnung oder andere Nachricht angezeigt.

1. Optional: Produktinformationen in den Registerkarten **Beschreibung** oder **Bild** anzeigen.

1. Klicken Sie auf **Speichern**, um das Produkt dem Angebot hinzuzufügen, oder auf **Speichern + neu**, um direkt ein weiteres Produkt hinzuzufügen.

![Dialog Produkt hinzufügen/bearbeiten -screenshot][img2]

### Mehrere Produkte hinzufügen

Um mehrere Produkte auf einmal hinzuzufügen, müssen Sie die erweiterte Suche verwenden.

1. Klicken Sie in der Registerkarte **Produkte** auf **Hinzufügen**.

1. Klicken Sie auf <i class="ph ph-magnifying-glass" aria-label="Search icon"></i>, um das Dialogfeld **Produkte suchen** zu öffnen.

1. Verwenden Sie ein oder mehrere Kriterien, um die Liste einzugrenzen. Klicken Sie auf **Kriterium hinzufügen**, um zusätzliche Filter hinzuzufügen.

    Die Suche umfasst alle aktiven Preislisten mit der Währung des Verkaufs.

1. Wählen Sie die gewünschten Produkte aus: Verwenden Sie **Strg+Klick** (Windows) oder **Cmd+Klick** (Mac), um mehrere Produkte zu markieren.

1. Klicken Sie auf **OK**. Alle ausgewählten Produkte werden dem Angebot hinzugefügt.

    Sie kehren zum Dialogfeld **Angebot bearbeiten** zurück.

1. Um Menge (sowie ggf. Rabatt, Preis oder Einnahmen) zu bearbeiten, doppelklicken Sie auf die jeweilige Produktzeile.

## Zahlungs- und Lieferoptionen festlegen

Bevor Sie das Angebot senden oder das Angebotsdokument erzeugen, wechseln Sie zur Registerkarte **Details** im Angebot.

Hier können Sie festlegen:

* **Zahlungsbedingungen** und **Zahlungsart**
* **Lieferbedingungen** und **Lieferart**
* **Rechnungsadresse** und **Lieferadresse**

Diese Felder werden im Angebotsdokument angezeigt und beim Erstellen des Auftrags verwendet.

## Fehlerbehebung

### Warum wird das Dialogfeld "ERP-Verbindung auswählen" angezeigt?

Dieses Dialogfeld erscheint, wenn:

* Keine Preisliste für die ausgewählte Währung vorhanden ist
* Mehrere ERP-Verbindungen verfügbar sind

**Lösung:** Wählen Sie eine andere Währung oder stellen Sie sicher, dass eine gültige Preisliste existiert. Wählen Sie anschließend die passende ERP-Verbindung aus.

> [!NOTE]
> Um die Auswahl der Währung in einem Verkauf zu aktivieren, gehen Sie zu **Einstellungen und Verwaltung** > **Voreinstellungen** und aktivieren Sie **Verwendung von Währungen**.

### Warum kann ich den gewünschten Verkauf nicht finden?

Beim Kopieren eines Angebots zeigt die Liste **Verkäufe** nur jene an, die:

* Ein bestehendes Angebot enthalten
* Dieselbe Währung wie der aktuelle Verkauf verwenden

**Lösung:**

* Überprüfen Sie, ob das gewünschte Verkaufselement ein Angebot enthält.
* Bestätigen Sie, dass beide Verkäufe dieselbe Währung verwenden.
* Ändern Sie bei Bedarf die Währung des aktuellen Verkaufs, damit sie übereinstimmt.

Wenn die Liste weiterhin leer ist, gibt es keine passenden Verkäufe zum Kopieren.

### Warum ist die OK-Schaltfläche beim Kopieren deaktiviert?

Möglicherweise haben Sie keinen Zugriff auf die ERP-Verbindung, die im Angebot verwendet wurde.
Bewegen Sie den Mauszeiger über die **OK**-Schaltfläche, um zu sehen, welche Verbindung eingeschränkt ist.

### <a id="warning"></a>Warum werden Warnungen oder Fehler angezeigt?

Wenn Sie Produkte in ein Angebot einfügen oder bearbeiten, zeigt SuperOffice möglicherweise eine Nachricht an, wenn etwas außerhalb der erlaubten Grenzen liegt.

Häufige Ursachen sind:

* Produkte nicht im Sortiment enthalten
* Inaktive Preislisten
* Der Rabatt ist zu hoch
* Die Einnahmen sind zu niedrig
* Der Preis ist zu niedrig oder gleich null

Das System zeigt eines der folgenden Symbole an:

| Symbol | Nachrichtentyp | Beschreibung | Was ist zu tun |
|:-:|---|---|---|
| <i class="ph ph-info" aria-label="Info icon"></i> | Info | Das Angebot enthält eine Meldung, kann aber trotzdem gesendet werden. | Optional: Lesen und bei Bedarf beheben |
| <i class="ph ph-warning" aria-label="Warning icon"></i> | Warnung | Das Angebot muss genehmigt werden, bevor es gesendet werden kann. | [Genehmigung ist erforderlich][7] |
| <i class="ph ph-circle-wavy-warning" aria-label="Error icon"></i> | Fehler | Das Angebot kann aufgrund eines Fehlers nicht gesendet werden. | Fehler beheben, bevor gesendet wird |

Diese Meldungen können an folgenden Stellen angezeigt werden:

* Im Dialogfeld **Produkt hinzufügen/bearbeiten**
* Im Dialogfeld **Angebot bearbeiten**
* Auf den Produktzeilen in der Bereichsregisterkarte **Angebot**
* In der Registerkarte **Produkte** (und Alternativen) im Angebot
* Beim Versuch, ein Angebot zu senden oder ein Auftrag zu erteilen

## Verwandte Inhalte

* [Alternativen zum Angebot hinzufügen][5]
* [Angebotsdokument erstellen][6]
* [Angebot senden][7]
* [Auftrag erstellen][8]
* [Produkte und Preise in Einstellungen und Verwaltung einrichten][9]

<!-- Referenced links -->
[1]: ../create.md
[5]: add-alternative.md
[6]: create-quote-document.md
[7]: send.md
[8]: place-order.md
[9]: ../../admin/quote/price-list-and-products.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/edit-quote-dialog-empty.png
[img2]: ../../../../media/loc/en/sale/add-edit-product-dialog.png
