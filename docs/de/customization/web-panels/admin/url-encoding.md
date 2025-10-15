---
uid: help-de-url-encoding
title: URL-Codierung
description: URL-Codierung in Web-Bildschirmen
keywords: Web-Bildschirm, URL-Codierung
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
---

# URL-Codierung

Browser fordern Seiten von Webservern über eine URL an – **die Adresse einer Webseite**.

Diese URLs können nur als ASCII-Zeichen über das Internet gesendet werden. Sie enthalten jedoch häufig Nicht-ASCII-Zeichen, zum Beispiel *Leerzeichen*.

Die **URL-Codierung** konvertiert die ursprüngliche URL in das richtige Format. Wenn Sie neue Web-Bildschirme hinzufügen, können Sie die URL-Codierung direkt in einem Dropdown-Menü auswählen.

## ANSI

Die Konvertierung ersetzt unsichere Zeichen durch ein Prozentzeichen (%) gefolgt von 2 hexadezimalen Ziffern. Zum Beispiel wird ein Leerzeichen zu *%20*. Also:

* Zeichen bis 0x7F (127) werden unverändert übergeben
* Zeichen von 0x7F bis 0xFF werden codiert

## Unicode

Die Konvertierung wandelt alle Zeichen in UTF-8 um und setzt dann vor jede 1–3 Byte lange hexadezimale Zeichenfolge ein % gemäß RFC 2279.
