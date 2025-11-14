---
uid: help-de-number-allocation-configure
title: Nummernzuweisung festlegen
description: Nummernzuweisung festlegen
keywords: nummernzuweisung, zähler, firmennummer
author: digitaldiina
date: 10.21.2025
version: 11.5
content_type: howto
category: Settings and maintenance
topic: options
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /de/admin/options/learn/number-allocation/index
  - /de/admin/options/learn/number-allocation/configure
language: de
---

# Nummernzuweisung festlegen

Mit einem Zähler wird der Wert des Felds bei jeder Registrierung um 1 erhöht. Zum Beispiel: Wenn die erste erstellte Firma in der Datenbank im Feld **Nummer** der Wert 10001 zugewiesen wird, erhält die neunzehnte Firma den Wert **10019**.

Die Zähler können für folgende Felder übernommen werden:

* Die Felder **Nummer** in den Ansichten Firma, Projekt, Verkauf und die Ansicht Person.
* Das Feld **Unser Zeichen** im Dialogfeld Dokument, wenn es für die relevante Vorlage definiert ist.
* Es können auch Zähler von Drittherstellern verwendet werden.

Im oberen Teil der Registrierkarte **Nummernzuweisung** befindet sich eine Tabelle, welche die definierten Zähler anzeigt.

## Nummernzuweisung pro Feld festlegen

1. Gehen Sie zu Einstellungen und Verwaltung und wählen Sie <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Optionen** aus.

1. Wählen Sie die Registerkarte **Nummernzuweisung**.

1. Doppelklicken Sie in der Tabelle auf den gewünschten Zähler. Daraufhin wird ein Dialogfeld für den gewählten Zähler geöffnet.

1. Aktivieren Sie die Option **Eindeutig**, wenn Sie möchten, dass die Zählerwerte im Feld **Nummer** eindeutig sind. Dies ist nützlich, wenn SuperOffice CRM-Benutzer selbst Werte zuweisen.

1. Aktivieren Sie **Leerzeichen erlaubt**, um leere Zählerfelder zuzulassen. Dies ist nützlich, wenn die Zählerwerte eindeutig sein müssen. Für leere Felder gilt nämlich die Einschränkung der Eindeutigkeit nicht.

1. Aktivieren Sie die Option **Schreibgeschützt**, wenn Sie nicht möchten, dass die SuperOffice CRM-Benutzer selbst Werte in das Feld **Nummer** eingeben können.

1. Aktivieren Sie **Zuweisen**, um die automatische Zählerfunktion zu verwenden. Das System vergibt dann automatisch die Werte im Feld **Nummer**.

1. Die nächste angewendete Nummer wird im Feld **Nächste Nummer** angezeigt. Wenn Sie möchten, können Sie diesen Wert ändern.

1. Klicken Sie auf **Speichern**.

## Spalten

| Spalte | Beschreibung |
|---|---|
| [Icon] | Zeigt an, wo der Zähler verwendet wird (zum Beispiel <i class="ph ph-buildings" aria-label="Company icon"></i> für die Ansicht Firma). |
| Zähler | Zeigt den Namen des Zählers an (zum Beispiel **Firmennummer** für das Feld **Nummer** in der Ansicht Firma). |
| Weiter | Zeigt den nächsten Wert für den Zähler an. |
| Zuweisen | Gibt an, ob die automatische Zählerfunktion verwendet wird, damit das System die Werte für Sie einträgt. |
| Eindeutig | Gibt an, ob die Zählerwerte eindeutig sein müssen. Dies ist nützlich, wenn Benutzer selbst Werte zuweisen. |
| Schreibgeschützt | Gibt an, ob Benutzer selbst Werte in die Zählerfelder eingeben dürfen. |
| Leerzeichen erlaubt | Gibt an, ob ein leeres Zählerfeld zulässig ist. Dies ist nützlich, wenn die Zählerwerte eindeutig sein müssen. Für leere Felder gilt nämlich die Einschränkung der Eindeutigkeit nicht. |
| Zuletzt verwendet | Zeigt an, wann das betreffende Zählerfeld zuletzt verwendet wurde. |
| Von - Benutzer-ID | Zeigt an, wer das betreffende Zählerfeld zuletzt verwendet hat. |
| Von - Porträt | Zeigt eine Miniaturansicht des Benutzers, der das Zählerfeld zuletzt verwendet hat. |

## Ergebnisse der Nummernzuweisung

Die nachfolgende Tabelle gibt an, wie sich die verschiedenen Kombinationen der angewandten Werte **Zuweisen** (A), **Eindeutig** (U), **Schreibgeschützt** (R) und **Leerzeichen erlaubt** (B) auswirken:

| A | U | R | B | Ergebnis |
|:-:|:-:|:-:|:-:|---|
| | | | | Benutzer können beliebige Eingaben vornehmen. |
| x | | | | Es wird eine Nummer zugewiesen, die vom Benutzer geändert werden kann. |
| x | x | | | Es wird eine Nummer zugewiesen, die vom Benutzer in einen eindeutigen Wert geändert werden kann. Die Datenbank darf nur ein leeres Feld haben. |
| x | x | x | | Es wird eine Nummer zugewiesen, die vom Benutzer nicht geändert werden kann. |
| x | x | x | x | Es wird eine Nummer zugewiesen, die vom Benutzer nicht geändert werden kann. |
| x | x | | x | Es wird eine Nummer zugewiesen, die vom Benutzer in einen eindeutigen Wert geändert oder entfernt werden kann. Die Datenbank darf unbegrenzt viele leere Felder enthalten. |
| x | | x | | Es wird eine Nummer zugewiesen, die vom Benutzer nicht geändert werden kann. Wenn irgendwelche externen Prozesse die Nummer ändern, wird die Eindeutigkeit nicht überprüft. |
| | x | | | Es wird keine Nummer zugewiesen. Der Benutzer kann eine Nummer festlegen, sie muss jedoch eindeutig sein. Die Datenbank darf nur ein leeres Feld haben. |
| | x | | x | Es wird keine Nummer zugewiesen. Der Benutzer kann eine Nummer festlegen, sie muss jedoch eindeutig sein. Die Datenbank darf unbegrenzt viele leere Felder enthalten. |
| | | x | x | Es wird keine Nummer zugewiesen und der Benutzer kann auch keine Nummer festlegen. Dies ist nützlich, wenn Zähler von Drittherstellern verwendet werden. |
| | | x | | Es wird keine Nummer zugewiesen und der Benutzer kann auch keine Nummer festlegen. Die Datenbank darf nur ein leeres Feld haben. (Nicht empfohlen.) |

## Verwandte Inhalte

* [Standardwerte für neue Dokumentvorlagen festlegen][3]

<!-- Referenced links -->
[3]: ../../document/templates/admin/document-template-defaults.md
