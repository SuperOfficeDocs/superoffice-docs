---
uid: help-de-utm-parameters
title: UTM-Parameter
description: UTM-Parameter
keywords: UTM-Parameter, Link, Kampagne, Tracking, SuperOffice Marketing
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: concept
category: marketing
topic: conversion
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: de
---

# UTM-Parameter

Es gibt fünf Standard-UTM-Parameter, die Sie am Ende Ihrer Kampagnenlinks hinzufügen können:

## Standard-UTM-Parameter

| Parameter | Bedeutung | Beispielwerte | Analogie |
|---|---|---|---|
| **utm_source** | Zeigt, woher der Traffic stammt. Hilft Ihnen zu sehen, welche Plattform oder welcher Verweis Besucher auf Ihre Website gebracht hat. | `google`, `linkedin`, `newsletter`, `messe` | Der Ort, von dem sie kamen |
| **utm_medium** | Zeigt den Marketingkanal oder die Methode, mit der die Nachricht übermittelt wurde. | `email`, `cpc`, `banner`, `organisch`, `event` | Die Straße, die sie genommen haben |
| **utm_campaign** | Gibt die Kampagne, Aktion oder das Thema an, mit dem der Link verbunden ist. | `fruehjahrs_sale`, `ebook_launch`, `black_friday`, `q2_brand_ads` | Das Fahrzeug, das sie benutzt haben |
| **utm_term** | Erfasst das bezahlte Keyword aus Suchanzeigen, das zum Besuch geführt hat. | `crm+software`, `marketing+automation` | Das Schild, das sie geführt hat |
| **utm_content** | Unterscheidet mehrere Links oder kreative Elemente innerhalb derselben Anzeige oder Kampagne. | `cta_button`, `header_banner`, `textlink_a` | Die Spur, die sie gewählt haben |

## Best Practices für UTM-Benennung

Befolgen Sie diese Richtlinien, um konsistentes und genaues UTM-Tracking in SuperOffice und Analyse-Tools sicherzustellen.

* **Nur Kleinbuchstaben:** Verwenden Sie Kleinbuchstaben für alle UTM-Werte, um doppelte Einträge zu vermeiden.
* **Unterstriche oder Bindestriche verwenden:** Wählen Sie ein Trennzeichen und verwenden Sie es konsequent (z. B. `webinar_sept2025`).
* **Dokumentieren Sie Ihre Struktur:** Erstellen Sie eine einfache Anleitung, damit Ihr Team Links einheitlich taggt.
* **Automatisieren Sie das Tagging:** Verwenden Sie ein UTM-Builder-Tool, um manuelle Fehler zu reduzieren und Konventionen durchzusetzen.
* **Regelmäßig prüfen:** Überprüfen Sie Ihre Analysen auf Unstimmigkeiten und bereinigen Sie sie bei Bedarf.
* **Einheitliches Namensformat verwenden:** Vereinbaren Sie ein Kampagnen-Namensformat und wenden Sie es auf alle Links an.

**Beispiel-Kampagnenname:**
`leadgen_smb_webinar_sept2025`

**Beispiel-Tracking-URL:**
`https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=leadgen_smb_webinar_sept2025`

Erfahren Sie, wie diese Parameter verwendet werden, um Lead-Quellen in SuperOffice CRM zu messen, unter [Conversion-Tracking][1].

## Verwandte Inhalte

* [UTM-Tracking für Formularübermittlungen aktivieren][2]
* [UTM-Builder für SuperOffice-Formulare][3]
* [Google Analytics Campaign URL Builder][4]
* [UTM Builder][5]

[1]: index.md
[2]: ../admin/set-up.md
[3]: ../../forms/learn/publish.md
[4]: https://ga-dev-tools.google/campaign-url-builder
[5]: utmbuilder.net
