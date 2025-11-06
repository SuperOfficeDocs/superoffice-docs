---
uid: help-de-utm-setup
title: UTM-Tracking einrichten
description: Erfahren Sie, wie Sie das UTM-Tracking in SuperOffice Marketing aktivieren und verwenden, um Lead-Quellen zu erfassen.
keywords: UTM aktivieren, Conversion-Tracking, Lead-Quelle
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: marketing
topic: conversion
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: de
---

# UTM-Tracking einrichten

Das UTM-Tracking ermöglicht es SuperOffice, die Quelle, das Medium und die Kampagne zu erfassen, die ein Lead generiert haben. Diese Einrichtung stellt sicher, dass jede Formularübermittlung der Marketingaktivität zugeordnet werden kann, die sie ausgelöst hat.

Sie müssen eine **einmalige Einrichtung** (durch einen Administrator oder Webentwickler) durchführen und einige **regelmäßige Schritte** für jede Kampagne befolgen.

## Überblick der Schritte

| Schritt | Wer | Häufigkeit | Zweck |
|---|---|---|---|
| **1. UTM-Datenübertragung aktivieren** | Administrator | Einmalig | Ermöglicht Formularen, UTM-Daten zu erfassen und in CRM-Feldern zu speichern. |
| **2. UTM-Tracking-Skript zur Website hinzufügen** | Webentwickler | Einmalig | Aktiviert dauerhaftes UTM-Tracking über Seiten und Sitzungen hinweg. |
| **3. Kampagnenlinks mit UTM-Parametern erstellen** | Marketingmitarbeiter | Pro Kampagne | Identifiziert, woher der Traffic stammt. |
| **4. Getaggte Links in Kampagnen verwenden** | Marketingmitarbeiter | Pro Kampagne | Nutzung der Links in Anzeigen, E-Mails und sozialen Medien. |
| **5. Formular korrekt veröffentlichen** | Marketingmitarbeiter | Pro Kampagne | Stellt sicher, dass das Formular UTM-Daten erfassen kann. |
| **6. Einrichtung testen und überprüfen** | Marketingmitarbeiter | Nach Erstkonfiguration und vor jeder Kampagne | Prüft, ob Tracking und Datenerfassung korrekt funktionieren. |
| **7. Ergebnisse analysieren und visualisieren** | Marketingmitarbeiter | Nach jeder Kampagne | Misst Kampagnenleistung in Dashboards und Berichten. |

## <a id="enable"></a>1. UTM-Datenübertragung aktivieren

**Wer:** Administrator
**Wann:** Einmalig

Die Aktivierung der UTM-Datenübertragung ermöglicht es SuperOffice, Informationen darüber zu erfassen, von wo Besucher stammen, wenn sie ein Formular absenden.

Diese Daten stehen sowohl auf der **Personenkarte** als auch bei der **Formularübermittlung** zur Verfügung.

1. Gehen Sie zu **Einstellungen und Verwaltung** > **Marketing**.
1. Aktivieren Sie **UTM-Datenübertragung bei Formularübermittlungen aktivieren**.

   ![Die Seite „Marketingeinstellungen“ in SuperOffice Einstellungen und Verwaltung mit der Option zur Aktivierung der UTM-Datenübertragung. -screenshot][img1]

## <a id="script"></a>2. UTM-Tracking-Skript zur Website hinzufügen

**Wer:** Webentwickler oder Website-Verantwortlicher
**Wann:** Einmalig

Dieses Skript ermöglicht dauerhaftes Tracking. Es erkennt UTM-Parameter in der URL und speichert sie vorübergehend im Browser, sodass selbst dann, wenn ein Besucher mehrere Seiten aufruft, bevor er ein Formular absendet, die Daten der ersten Interaktion erhalten bleiben.

1. Kopieren Sie das untenstehende Skript.
1. Fügen Sie es direkt nach dem `<head>`-Tag in den Quellcode Ihrer Website ein.
1. Veröffentlichen Sie die aktualisierte Seite.

```html
<!-- SuperOffice UTM tag -->
<script src="https://sod2.superoffice.com/CustXXXXX/cs/javascript/utm.js"></script>
```

> [!TIP]
> Ohne dieses Skript werden UTM-Daten nur für direkte Formularlinks erfasst, nicht jedoch für Besucher, die zwischen Seiten navigieren.

## <a id="build-url"></a>3. Kampagnenlinks mit UTM-Parametern erstellen

**Wer:** Marketingmitarbeiter
**Wann:** Pro Kampagne

UTM-Parameter identifizieren, woher Besucher kommen und wie sie mit Ihren Kampagnen interagieren.

Sie können diese Parameter manuell hinzufügen oder ein UTM-Builder-Tool verwenden.

```text
https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=webinar_sept
```

Verwenden Sie den [SuperOffice UTM-Builder für Formularseiten][1] oder den [Google Campaign URL Builder][4], um konsistente Kampagnenlinks zu generieren und manuelle Fehler zu vermeiden.

**Standardparameter:**
utm_source, utm_medium, utm_campaign, utm_term, utm_content

Weitere Beschreibungen und Namenskonventionen finden Sie unter [UTM-Parameter][2].

## <a id="tag"></a>4. Getaggte Links in Kampagnen verwenden

**Wer:** Marketingmitarbeiter
**Wann:** Pro Kampagne

Verwenden Sie die getaggten Links überall dort, wo Sie Ihre Kampagnen bewerben, z. B.:

* Call-to-Action-Schaltflächen in Blogbeiträgen
* E-Mail-Newsletter
* Facebook-Anzeigen oder Retargeting
* Google Ads
* LinkedIn-Beiträge

## <a id="publish"></a>5. Formular korrekt veröffentlichen

**Wer:** Marketingmitarbeiter
**Wann:** Pro Kampagne

SuperOffice kann UTM-Daten erfassen, unabhängig davon, ob Ihr Formular **eingebettet** auf Ihrer Website oder **von SuperOffice gehostet** ist.

| Methode | Beschreibung | Erfasst erste Quelle? |
|---|---|---|
| **Eingebettetes Formular** | Fügen Sie das Tracking-Skript auf Ihrer Website hinzu und verwenden Sie eine Landingpage mit UTM-Parametern. | <i class="ph ph-check-circle" aria-hidden="true"></i> Ja |
| **Von SuperOffice gehostetes Formular (Direktlink)** | Fügen Sie UTM-Parameter zur Formular-URL hinzu. | <i class="ph ph-warning-circle" aria-hidden="true"></i> Nein |

> [!TIP]
> Verlinken Sie nicht direkt von Ihrer Website zu einem SuperOffice-gehosteten Formular, da UTM-Tags zwischen Seiten verloren gehen können.

## <a id="test"></a>6. Einrichtung testen und überprüfen

**Wer:** Marketingmitarbeiter
**Wann:** Nach der ersten Einrichtung und vor jeder neuen Kampagne

1. Klicken Sie auf einen Ihrer Kampagnenlinks.
1. Füllen Sie das Formular aus und senden Sie es ab.
1. Öffnen Sie die neue Personenkarte in SuperOffice.
1. Überprüfen Sie, ob die Felder **Quelle**, **Medium** und/oder **Kampagne** Daten enthalten.

Wenn Daten fehlen, überprüfen Sie Folgendes:

* Ist das Tracking-Skript korrekt installiert?
* Sind die UTM-Parameter richtig geschrieben und formatiert?
* Werden Browser-Cookies blockiert oder gelöscht?

## <a id="analyze"></a>7. Ergebnisse analysieren und visualisieren

**Wer:** Marketingmitarbeiter
**Wann:** Nach jeder Kampagne

Sobald Daten erfasst sind, können Sie die Leistung in Dashboards und Berichten messen.

* Anzeigen neuer Leads nach **erster Quelle** (welcher Kanal generierte den Traffic).
* Anzeigen neuer Leads nach **Kampagne** (welche Kampagne generierte Conversions).
* Erstellen Sie eine **Dashboard-Kachel**, die neue Leads nach Quelle, Medium oder Kampagne für das aktuelle Jahr anzeigt.

Weitere Informationen finden Sie unter [Marketing-Dashboards und Berichte][5].

[2]: ../learn/parameters.md
[1]: ../../forms/learn/publish.md
[4]: https://ga-dev-tools.google/campaign-url-builder
[5]: ../../../dashboard/learn/show-marketing.md

[img1]: ../../../../media/loc/en/marketing/conversion-tracking.png
