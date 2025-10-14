---
uid: help-de-ui-web-panels
title: Web-Bildschirme
description: Web-Bildschirme
keywords: Web-Bildschirm
author: digitaldiina
date: 10.13.2025
version: 11.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
language: de
index: true
redirect_from: /de/ui/web-panels/learn/index
---

# Web-Bildschirme

Ein **Web-Bildschirm** ist ein konfigurierbarer Bereich innerhalb von SuperOffice CRM, der Inhalte von einer Webseite oder internen Ressource basierend auf einer URL anzeigt. Dies ermöglicht es Ihnen, externe Datenquellen oder interne Tools direkt in SuperOffice zu integrieren.

Web-Bildschirme können an verschiedenen Orten erscheinen und sind auf den Kontext zugeschnitten, in dem der Benutzer arbeitet, wie eine Firmenkarte, eine Anfrage oder eine Folgeaufgabe.

## Von Web-Bildschirmen unterstützte Inhaltstypen

Web-Bildschirme unterstützen eine Reihe von Inhaltstypen:

* **URLs:** externe Webseiten oder interne Systeme
* **Ansichten:** SuperOffice CRM-Ansichts-Shortcuts
* **Selektionen:** Shortcuts zu Selektionen
* **Skripts/Makros:** Aktionen ausgelöst über eine Schaltfläche oder ein Menü

## Anzeigeorte für Web-Bildschirme

Der **Anzeigeort** wird beim Konfigurieren des Panels definiert. Dies steuert, wo in SuperOffice das Panel erscheint.

* Seitenpanel
* Symbolleiste
* Navigator-Schaltfläche (Hauptmenü)
* Panels:
  * Firma-, Person-, Projekt-, Verkaufs- und Selektionskarten
  * SuperOffice-Schaltfläche Web-Panel
  * Abschnitt-Registerkarten für Firma-, Person-, Projekt- und Verkaufsansichten
* Dialoge:
  * Folgeaufgabendialog
  * Dokumentdialog
  * Produkt- und Angebotsdialoge
* Menüs:
  * Werkzeugmenü
  * Ansichtsmenü
* Dashboard-Kacheln (über Inhaltsauswahl-Dropdown)

### In Service (veraltet)

* Hauptansicht
* Anfrageansicht
* Firmaansicht
* Personenansicht
* Zusatztabelleneintragsansicht

## <a id="www"></a>Die www-Registerkarte

An Orten wie Firma, Person, Projekt und Verkauf werden Web-Bildschirme häufig unter der **www**-Registerkarte angezeigt.

Sie können die Registerkarte in **Einstellungen und Verwaltung** > **Optionen** > **Bezeichnungen** umbenennen. Um die Registerkarte innerhalb der CRM-Oberfläche neu zu positionieren, verwenden Sie die Liste **GUI - Web-Bildschirm**.

### In separatem Fenster öffnen

Alle eingebetteten URLs können mit **In separatem Fenster öffnen** in einem separaten Browser-Fenster geöffnet werden.

## Wie Web-Bildschirme funktionieren

Web-Bildschirme laden Inhalte dynamisch basierend auf dem CRM-Kontext und der für das Panel definierten URL:

1. Ein Benutzer öffnet einen Datensatz (zum Beispiel eine Firma).
1. Das System berechnet die URL unter Verwendung verfügbarer Template-Variablen.
    * Zum Beispiel wird `http://server/seite.asp?id=<cuid>` zu `http://server/seite.asp?id=123`
1. Wenn die neue URL anders ist als die vorherige, sendet das System eine neue Anfrage.
1. Der Server antwortet mit der entsprechenden Webseite: er empfängt die URL, berechnet die Seite anhand der URL-Parameter und gibt das Ergebnis zurück.
1. Das Panel rendert die Webseite innerhalb von SuperOffice CRM.

<!-- Referenced links -->

<!-- Referenced images -->