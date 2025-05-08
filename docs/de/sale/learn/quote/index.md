---
uid: help-de-quote
title: Mit Angeboten arbeiten
description: Erfahren Sie, wie Sie Angebote in SuperOffice CRM erstellen, verwalten und versenden – um Ihren Verkaufsprozess zu optimieren und Fehler zu minimieren.
keywords: Angebots-Registerkarte, Bereichsregisterkarte Angebot, Vorschlag, Angebotsalternative, Angebotsprozess, Angebot-zu-Auftrag, Angebot, Verkauf
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
topic: concept
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Mit Angeboten arbeiten

SuperOffice Quote hilft Ihnen, Angebote schnell und genau zu erstellen, zu verwalten und zu versenden. Durch die Nutzung einer vordefinierten Produktdatenbank und automatischer Berechnungen können Sie manuelle Fehler reduzieren und Zeit sparen. Angebote können mehrere Alternativen enthalten, sodass Ihre Kunden einfacher auswählen können.

Nach Annahme eines Angebots können Sie mit einem Klick einen Auftrag generieren und zur Bearbeitung senden – entweder manuell oder automatisch über ein ERP-System, je nach Konfiguration.

SuperOffice Quote unterstützt den gesamten Angebot-zu-Auftrag-Prozess. Es hilft Ihnen, neue oder aktualisierte Angebote schneller bereitzustellen und beschleunigt die Umwandlung von einem Lead in einen abgeschlossenen Verkauf.

> [!NOTE]
> Diese Funktion erfordert den Benutzerplan Sales Premium.

![Angebots-Bildschirm mit einem Angebot -screenshot][img1]

## Warum SuperOffice Quote verwenden?

* Professionelle Vorschläge schneller erstellen
* Produkte und Preise aus vordefinierten Listen wiederverwenden
* Berechnungen SuperOffice überlassen
* Mehrere Angebotsalternativen versenden
* Angebot sofort in Auftrag umwandeln
* Einheitlichkeit durch Angebotsvorlagen sicherstellen
* Genehmigungsengpässe und Fehler reduzieren

## Übersicht über den Angebotsprozess

1. Öffnen Sie einen Verkauf und [erstellen Sie ein Angebot][1].
1. [Fügen Sie dem Angebot Produkte hinzu][2].
1. [Erstellen Sie das Angebotsdokument][3], das an den Kunden gesendet wird. Dies ist das Begleitschreiben zur Produktliste.
1. [Senden Sie das Angebot][4].
1. [Erteilen Sie den Auftrag][5], sobald der Kunde zustimmt.

![Nach dem Klick auf die Schaltfläche zum Erstellen eines Angebots können Sie Produkte und Dienstleistungen hinzufügen (animiert) -screenshot][img2]

### <a id="status"></a>Angebotsstatus

| Symbol | Status |
|---|---|
| <i class="ph ph-pencil" aria-label="Draft"></i> <i class="ph ph-calculator" aria-label="Draft – not Calculated"></i> | Entwurf / Entwurf – nicht berechnet |
| <i class="ph ph-question" aria-label="Needs approval"></i> | Genehmigung erforderlich |
| <i class="ph ph-check-square" aria-label="Approved"></i> <i class="ph ph-x-square" aria-label="Not approved"></i> | Genehmigt / Abgelehnt |
| <i class="ph ph-envelope-simple" aria-label="Sent"></i> | Gesendet |
| <i class="ph ph-clock-counter-clockwise" aria-label="Sent – Expired"></i> | Gesendet – abgelaufen |
| <i class="ph ph-currency-dollar" aria-hidden="true"></i> <i class="ph ph-check" aria-label="Sold"></i> | Verkauft |
| <i class="ph ph-currency-dollar" aria-hidden="true"></i> <i class="ph ph-x" aria-label="Lost"></i> | Verloren |
| <i class="ph ph-shopping-cart-simple" aria-label="Ordered"></i> | In Auftrag gegeben |
| <i class="ph ph-folder-simple" aria-label="Archived"></i> | Archiviert |

## <a id="quote-tab"></a>Bereichsregisterkarte Angebot

In der Bereichsregisterkarte **Angebot** unten in einem Verkauf können Sie Angebote erstellen, anzeigen und verwalten.

### Wenn kein Angebot vorhanden ist

* [Erstellen Sie ein neues Angebot][1] von Grund auf.
* [Kopieren Sie ein Angebot aus einem anderen Verkauf][6] (muss dieselbe Währung haben).

### Wenn ein Angebot vorhanden ist

* Angebotsnummer, Version und [Status](#status) anzeigen
* [Angebotsdokument erstellen][3]
* Angebotsalternativen auswählen und verwalten (falls für den Verkaufstyp aktiviert)
* **Öffnen** klicken, um das Angebot anzuzeigen oder zu bearbeiten
* Produktliste in eine Tabelle exportieren

Produktliste: Falls Produkte zum Angebot hinzugefügt wurden, werden sie in der Liste angezeigt. Am unteren Ende der Liste wird der Gesamtpreis der Produkte in der Liste angezeigt.

## <a id="alternatives"></a>Alternativen im Angebot

Ein Angebot kann eine oder mehrere **Alternativen** enthalten, mit denen Sie unterschiedliche Produkt-, Mengen- oder Rabattkombinationen anbieten können. Jede Alternative erscheint als Registerkarte im Dialogfeld **Angebot bearbeiten** und kann umbenannt werden. So geben Sie dem Kunden Auswahlmöglichkeiten, ohne mehrere Angebote zu erstellen.

Standardmäßig ist die erste Alternative als **Favorit** markiert. Der Favorit wird mit einem Sternsymbol <i class="ph ph-star" aria-label="Favorite alternative"></i> gekennzeichnet und wird beim [Versand des Angebots][4] verwendet. Sie bestimmt außerdem den Prognosewert des Verkaufs. Um den Favoriten zu ändern, wählen Sie eine andere Registerkarte aus und klicken unten im Dialog auf **Favoritalternative**.

## Tipps

Um Einheitlichkeit zu gewährleisten, sollten Sie eine gut gestaltete Angebotsvorlage verwenden. Administratoren können Vorlagen anpassen und Produktregeln in **Einstellungen und Verwaltung** einrichten.

## Verwandte Inhalte

* [Produkt im Angebot hinzufügen/bearbeiten][2]
* [Angebotsdokument erstellen][3]
* [Alternativen zu einem Angebot hinzufügen][7]
* [Produkte und Preise in Einstellungen und Verwaltung einrichten][11]

<!-- Referenzierte Links -->
[1]: create.md
[2]: create.md#add-products
[6]: create.md#copy
[3]: create-quote-document.md
[4]: send.md
[5]: place-order.md
[7]: add-alternative.md
[11]: ../../admin/quote/price-list-and-products.md

[img1]: ../../../../media/loc/en/sale/quote-management.png
[img2]: ../../../../media/loc/en/sale/quote-create-send.gif
