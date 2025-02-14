---
uid: help-de-sales-target-types
title: Verkaufszieltyp mit Untertypen einrichten
description: Es kann stressig sein, den Überblick über Ihre Verkaufsziele zu behalten. Wenn Sie jedoch Parameter und Dimensionen Ihrer Verkaufsziele definieren, wird die Verwaltung Ihrer Ziele viel einfacher.
author: SuperOffice RnD
date: 02.16.2023
keywords: Verkauf
topic: howto
language: de
---

# Verkaufszieltyp mit Untertypen einrichten

Es kann stressig sein, den Überblick über Ihre Verkaufsziele zu behalten. Wenn Sie jedoch Parameter und Dimensionen Ihrer Verkaufsziele definieren, wird die Verwaltung Ihrer Ziele viel einfacher.

Sie können zusätzlich zum Standardzieltyp **Alle Verkäufe - Betrag** neue Zieltypen (Dimensionen) hinzufügen.

> [!NOTE]
> Sie benötigen die Sales Premium-Lizenz zusammen mit der Sales Target Unlimited-Lizenz, um mehr als eine Benutzergruppe und einen Zieltyp hinzuzufügen. Wenn Sie nur über eine Sales Premium-Lizenz verfügen, können Sie eine Gruppe für den Zieltyp Alle Verkäufe - Betrag hinzufügen.

Sie benötigen das funktionale Recht Administrator für Ziele für Ihre Rolle, um Zieltypen hinzuzufügen, zu bearbeiten und zu entfernen.

## Zieltyp festlegen

Um die Parameter und Dimensionen zu definieren, müssen Sie zunächst einen Zieltyp einrichten.

Sie können einen Zieltyp sowohl für Benutzer als auch für Gruppen einrichten und andere Zielparameter festlegen: Zieltyp, Maßeinheit, Separate Ziele. Sie können auch festlegen, ob das Ziel nur auf Unternehmens- und Gruppenebene (und nicht auf Benutzerebene) verfügbar sein soll.

![Übersicht über die verschiedenen Zieltypen und Untertypen eines Verkaufsziels -screenshot][img1]

## Neuen Zieltyp hinzufügen

1. Klicken Sie auf **Neuen Zieltyp hinzufügen**. Oder klicken Sie in der Registerkarte auf <i class="ph ph-gear" aria-label="Gear"></i> (**Ziel konfigurieren**), um einen vorhandenen Zieltyp zu bearbeiten.

2. Klicken Sie auf **Zieltyp**, um den gewünschten Zieltyp (die gewünschte Dimension) auszuwählen.

3. Klicken Sie auf **Maßeinheit** um die relevante Einheit auszuwählen. Die verfügbaren Einheiten hängen vom ausgewählten Zieltyp ab. Wenn Sie **Kategorie** als Zieltyp ausgewählt haben, können Sie beispielsweise nach Betrag oder Anzahl (Anzahl der Verkäufe in einer Kategorie) messen.

4. In der nächsten Liste können Sie bestimmte Elemente des gewählten Zieltyps auswählen. Wenn Sie keine auswählen, werden alle ausgewählt. Beispiel: Wenn Sie **Kategorie** als Zieltyp ausgewählt haben, können Sie die Firmenkategorien auswählen, für die Sie Ziele erstellen möchten.

5. Wählen Sie **Nur auf Firmen- und Gruppenebene verfügbar**, wenn dieser Zieltyp nicht auf Benutzerebene, sondern nur auf Gruppen-/Teamebene und Firmenebene zur Verfügung stehen soll.

6. Klicken Sie auf **Speichern**. Der neue Zieltyp wird als Registerkarte hinzugefügt. Sie können nun wie oben beschrieben Ziele hinzufügen.

> [!NOTE]
> Zieltyp und Maßeinheit können nicht in einem vorhanden Zieltyp geändert werden können. Alternativ können Sie auch einen neuen Zieltyp mit den gewünschten Einstellungen erstellen und dann den alten löschen.

### Zieltypen (Parameter)

* Alle Verkäufe
* Verkaufstyp
* Verkaufsquelle
* Verkauf belastet
* Verkaufswettbewerber
* Firmenkategorie
* Firmenbranche
* Firmenland

Sie können auch Ziele für Ihre eigenen benutzerdefinierten Felder festlegen, die Listen enthalten. Nachdem ein Zieltyp ausgewählt wurde, kann dieser Zieltyp nicht erneut ausgewählt werden, um die Erstellung von Duplikaten zu vermeiden.

### Maßeinheit

Sie können einen Verkauf auf unterschiedliche Weise messen. Wählen Sie Ihre bevorzugte Einheit je nach den Einheiten aus, die in Ihrem Unternehmen verwendet werden.

* Betrag
* Anzahl
* Ertrag

### Separate Zieluntertypen (Dimensionen)

Die verfügbare Liste hängt vom ausgewählten Zieltyp ab. Zum Beispiel:

* Wenn der Zieltyp auf Verkaufstyp festgelegt wurde, zeigen die Zieluntertypen die Liste für Verkaufstypen an, die von Ihrer Firma definiert wurden.
* Wenn der Zieltyp auf Quelle festgelegt wurde, zeigen die Zieluntertypen die Liste für Verkaufsquellen an, die von Ihrer Firma definiert wurden.

Am unteren Rand des Dialogfelds befindet sich ein Kontrollkästchen für nur auf Unternehmens- und Gruppenebene verfügbar. Wenn Sie dieses Kontrollkästchen aktivieren, wird der Zieltyp nur auf Unternehmens- und Gruppenebene hinzugefügt, und die verschiedenen Benutzer werden nicht in Ihrer Zielliste angezeigt.

> [!NOTE]
> Wenn Sie Ihr neues Ziel gespeichert haben, können Sie immer noch zu den Einstellungen gehen und die Liste Separate Ziele und das Kontrollkästchen nur auf Unternehmens- und Gruppenebene verfügbar ändern. Wenn Sie erst auf Unternehmens- und Gruppenebene verfügbar auswählen, nachdem Sie Nummern auf Benutzerebene hinzugefügt haben, wird eine Warnung angezeigt, die darauf hinweist, dass die Benutzernummern beim Speichern gelöscht werden.

Wenn der neue Zieltyp gespeichert wurde, können Sie die Option [Gruppen und Benutzer zu Ihrem Verkaufsziele hinzufügen][3] ausführen.

![Die Schaltfläche Gruppen und Benutzer hinzufügen finden Sie in der Verkaufszielübersicht -screenshot][img2]

## Zieltypen filtern

Bei Zieltypen mit der Liste der Zieluntertypen können Sie auf die Schaltfläche Filter klicken und die Liste nach den verschiedenen Listenelementen filtern.

![Klicken Sie auf die Schaltfläche Filter, um nach dem Zieluntertyp zu filtern -screenshot][img3]

## Zieltypen entfernen

Um einen Zieltyp zu löschen, müssen Sie auf die Zieleinstellungen und dann auf die Schaltfläche Löschen klicken. Beachten Sie, dass die Aktion für das Löschen eines Zieltyps nicht rückgängig gemacht werden kann und alle Daten für den Zieltyp in früheren, aktuellen und zukünftigen Jahren gelöscht werden. Der Standardzieltyp Alle Verkäufe - Betrag kann nicht gelöscht werden.

## Verwandte Themen

* [Verkaufsziele in Dashboard-Kacheln verwenden][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md
[3]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/user-targets-new-target-type.png
[img2]: ../../../../media/loc/en/sale/user-targets-add-groups-users.png
[img3]: ../../../../media/loc/en/sale/user-targets-filter-type.png
