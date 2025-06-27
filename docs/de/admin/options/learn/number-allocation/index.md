---
uid: help-de-number-allocation
title: Zahlenzuweisung
description: Zahlenzuweisung
author: Bergfrid Dias
date: 03.24.2023
keywords: Nummer, Zähler
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Zahlenzuweisung

Mit einem Zähler wird der Wert des Felds bei jeder Registrierung um 1 erhöht. Zum Beispiel: Wenn die erste erstellte Firma in der Datenbank im Feld **Nummer** der Wert 10001 zugewiesen wird, erhält die neunzehnte Firma den Wert **10019**.

Die Zähler können für folgende Felder übernommen werden:

* Die Felder **Nummer** in den Ansichten Firma, Projekt, Verkauf und die Ansicht Person.

* Das Feld **Unser Zeichen** im Dialogfeld Dokument, wenn es für die relevante Vorlage definiert ist.

* Es können auch Zähler von Drittherstellern verwendet werden.

Im oberen Teil der Registrierkarte **Nummernzuweisung** befindet sich eine Tabelle, welche die definierten Zähler anzeigt.

## Spalten

| Spalte | Beschreibung |
|---|---|
| \[Icon\] | Zeigt an, wo der Zähler verwendet wird (zum Beispiel <i class="ph ph-buildings" aria-label="Company icon"></i> für die Ansicht Firma). |
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

## Was möchten Sie jetzt tun?

* [Nummernzuweisung festlegen][2]
* [Standardwerte für neue Dokumentvorlagen festlegen][3]

<!-- Referenced links -->
[2]: configure.md
[3]: document-template-defaults.md
