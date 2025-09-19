---
uid: help-sales-target-types
title: Verkaufszieltyp mit Untertypen einrichten
description: Es kann stressig sein, den Überblick über Ihre Verkaufsziele zu behalten. Wenn Sie jedoch Parameter und Dimensionen Ihrer Verkaufsziele definieren, wird die Verwaltung Ihrer Ziele viel einfacher.
keywords: Verkaufsziel, Dimension
author: SuperOffice Product and Engineering
date: 09.19.2025
version: 10.5
content_type: howto
license: salespremium, Unlimited sales targets
functional_right: Targets administrator
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Verkaufszieltyp mit Untertypen einrichten

Es kann stressig sein, den Überblick über Ihre Verkaufsziele zu behalten. Wenn Sie jedoch Parameter und Dimensionen Ihrer Verkaufsziele definieren, wird die Verwaltung Ihrer Ziele viel einfacher.

Standardmäßig enthält SuperOffice einen Zieltyp: **Alle Verkäufe – Betrag**. Sie können benutzerdefinierte Zieltypen basierend auf Verkaufsdaten, Firmendetails oder benutzerdefinierten Feldern hinzufügen.

## Anforderungen

Sie müssen das funktionale Recht **Targets administrator** haben, um Zieltypen hinzuzufügen, zu bearbeiten oder zu löschen.

> [!NOTE]
> Um Zieltypen hinzuzufügen, benötigen Sie die Unlimited Sales Targets-Lizenz zusätzlich zur Sales Premium-Lizenz.

## Verfügbare Zieltypen

Ein **Zieltyp** definiert, was Sie messen möchten. Sie können aus den folgenden systemdefinierten Dimensionen wählen:

* Alle Verkäufe
* Verkaufstyp
* Verkaufsquelle
* Verkauf belastet
* Verkaufswettbewerber
* Firmenkategorie
* Firmenbranche
* Firmenland

Sie können auch Ihre eigenen benutzerdefinierten Felder verwenden, wenn sie Listenwerte enthalten.

**Jede Dimension kann nur einmal verwendet werden, um Duplikate zu vermeiden.**

## Neuen Zieltyp hinzufügen

1. Klicken Sie <i class="ph ph-list" aria-label="Hauptmenü"></i> und wählen Sie **Ziele**.

1. Im **Ziele**-Bildschirm klicken Sie **Neuen Zieltyp hinzufügen**, um eine benutzerdefinierte Verkaufsdimension zu definieren. Sie können auch auf <i class="ph ph-gear" aria-label="Zahnrad"></i> (**Ziel konfigurieren**) auf einer vorhandenen Registerkarte klicken, um sie zu bearbeiten.

    ![Ziele-Bildschirm mit Schaltfläche "Neuen Zieltyp hinzufügen" -screenshot][img4]

1. Klicken Sie **Zieltyp**, um die zu verfolgende Dimension auszuwählen, wie **Verkaufsquelle** oder **Firmenkategorie**.

    ![Zieleinstellungen-Dialog zum Erstellen eines neuen Zieltyps -screenshot][img1]

1. Klicken Sie **Maßeinheit**, um auszuwählen, wie Ergebnisse berechnet werden:

    * **Betrag:** Gesamtwert der Verkäufe
    * **Anzahl:** Anzahl der Verkäufe
    * **Gewinn:** Gewinnspanne

    Die Optionen hängen vom ausgewählten Zieltyp ab.

1. Unter **Separate Ziele** wählen Sie spezifische Untertypen aus, die separat verfolgt werden sollen. Die Optionen hängen vom ausgewählten Zieltyp ab.

    Zum Beispiel, wenn der Zieltyp **Kategorie** ist, sind die Untertypen Ihre Firmenkategorien.

1. Wählen Sie das Kontrollkästchen **Nur auf Firmen- und Gruppenebene verfügbar**, wenn dieser Zieltyp nicht auf Benutzerebene verfügbar sein soll.

1. Klicken Sie **Speichern**. Der Zieltyp wird als Registerkarte hinzugefügt. Sie können nun [Gruppen und Benutzer zu Ihrem Verkaufsziel hinzufügen][3].

## Zieltyp entfernen

Um einen Zieltyp zu löschen:

1. Öffnen Sie **Zieleinstellungen** von der entsprechenden Registerkarte.
2. Klicken Sie **Löschen**.

> [!WARNING]
> Das Löschen eines Zieltyps entfernt dauerhaft alle zugehörigen Daten für alle Jahre - vergangene, aktuelle und zukünftige. Sie können den Standardtyp **Alle Verkäufe – Betrag** nicht löschen.

## Tipps und Fehlerbehebung

* Nach dem Speichern können der Zieltyp und die Maßeinheit nicht geändert werden. Um diese Einstellungen anzupassen, erstellen Sie einen neuen Zieltyp und löschen Sie den alten.

* Sie können die Liste **Separate Ziele** und das Kontrollkästchen **Nur auf Firmen- und Gruppenebene verfügbar** nach dem Speichern bearbeiten.

    > [!NOTE]
    > Wenn Sie die Verfügbarkeit nur auf Firmen-/Gruppenebene aktivieren, nachdem Sie Werte auf Benutzerebene eingegeben haben, erscheint eine Warnung. Das Speichern dieser Änderung löscht die Ziele auf Benutzerebene.

## Verwandte Inhalte

* [Gruppen und Benutzer zu Ihrem Verkaufsziel hinzufügen][3]
* [Verkaufsziele in Dashboard-Kacheln verwenden][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md
[3]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/target-settings.png
[img4]: ../../../../media/loc/en/sale/add-new-target-type-button.png
